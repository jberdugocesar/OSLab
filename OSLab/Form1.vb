
Imports System.IO

Public Class Form1
    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click

        If Not tamMarco.Text.Equals("") And Not tamOS.Text.Equals("") And Not tamProc.Text.Equals("") And Not marcosLib.Text.Equals("") Then

            Using ofd As OpenFileDialog = New OpenFileDialog() With {.Filter = "Text file|*.csv"}
                If ofd.ShowDialog() = DialogResult.OK Then
                    Bitacora.Clear()
                    Dim U, os, proc As Integer
                    U = Convert.ToInt64(tamMarco.Text)
                    os = Convert.ToInt64(tamOS.Text)
                    proc = Convert.ToInt64(tamProc.Text)
                    Dim marcos As String() = marcosLib.Text.Split(",")
                    Dim lista As List(Of Entrada) = New List(Of Entrada)
                    Dim mem As List(Of MemoriaPrincipal) = New List(Of MemoriaPrincipal)
                    mem = LlenarOS(os, U, marcos, mem)
                    Dim sw As Integer = ComprobarMarcos(mem, marcos)
                    If (sw.Equals(0)) Then
                        If (U <= proc) Then
                            LLenarEntrada(lista, ofd)

                            Bitacora.AppendText(String.Format("Los tamaños son: " & vbCrLf & "Marco: {0} Bits" & vbCrLf & "OS: {1} Bits" & vbCrLf & "Proceso: {2} Bits" & vbCrLf, U, os, proc))
                            Bitacora.AppendText("Los marcos libres son: ")
                            For i As Integer = 0 To marcos.Length - 1
                                Bitacora.AppendText(String.Format(" {0} ", marcos(i)))
                            Next
                            Bitacora.AppendText(vbCrLf)

                            EntradaBindingSource.DataSource = lista
                            Empezar.Enabled = True
                            Pausar.Enabled = True
                            Detener.Enabled = True
                            Bitacora.ScrollToCaret()
                        End If
                    End If
                End If
            End Using
        End If

    End Sub

    Private Function ComprobarMarcos(mem As List(Of MemoriaPrincipal), marcos() As String)
        For i = 0 To mem.Count - 1
            For j = 0 To marcos.Length - 1
                If (marcos(j).Equals(mem(i).dirFisica)) Then
                    Bitacora.Clear()
                    Bitacora.AppendText(String.Format("El marco: {0}, se encuentra en el marco del OS" & vbCrLf, marcos(j), mem(i).dirFisica))
                    Bitacora.AppendText(String.Format("Por favor, corrija el error" & vbCrLf, marcos(j), mem(i).dirFisica))
                    Bitacora.ScrollToCaret()
                    Return 1
                End If
            Next
        Next
        Return 0
    End Function

    Public Function LlenarOS(tamOS As Integer, U As Integer, marcos As String(), Mem As List(Of MemoriaPrincipal))
        MemoriaPrincipalBindingSource.Clear()
        Dim n As Integer = tamOS / U
        Dim lista As List(Of MemoriaPrincipal) = New List(Of MemoriaPrincipal)
        For i = 0 To n
            lista.Add(New MemoriaPrincipal() With {
                  .dirFisica = i,
                  .valor = i + 5})
        Next
        Bitacora.AppendText(String.Format("Hay {0} Bits de Fragmentación Interna en el OS" & vbCrLf, tamOS Mod U))
        Return lista
    End Function

    Public Function LLenarEntrada(lista As List(Of Entrada), ofd As OpenFileDialog)
        Dim lines As List(Of String) = File.ReadAllLines(ofd.FileName).ToList()
        Dim numero As String() = lines(0).Split(",")
        Dim valor As String() = lines(1).Split(",")
        For i As Integer = 0 To numero.Length - 1
            lista.Add(New Entrada() With {
                  .numero = numero(i),
                  .valor = valor(i)})
        Next
        Return lista
    End Function

    Private Sub Empezar_Click(sender As Object, e As EventArgs) Handles Empezar.Click
        Bitacora.Clear()
        tamMarco.Enabled = False
        tamOS.Enabled = False
        tamProc.Enabled = False
        marcosLib.Enabled = False
        Aceptar.Enabled = False

        Dim mem As List(Of MemoriaPrincipal) = New List(Of MemoriaPrincipal)
        Dim U, os, proc As Integer
        U = Convert.ToInt64(tamMarco.Text)
        os = Convert.ToInt64(tamOS.Text)
        proc = Convert.ToInt64(tamProc.Text)
        Dim marcos As String() = marcosLib.Text.Split(",")
        mem = LlenarOS(os, U, marcos, mem)
        MemoriaPrincipalBindingSource.DataSource = mem
        Bitacora.AppendText(vbCrLf & "Se empieza la simulación " & vbCrLf)
        Bitacora.ScrollToCaret()
        Dim paginas(,) As Integer
        paginas = llenarDisco(proc, U)
        Bitacora.AppendText(vbCrLf)
        LlenarTablaPag(marcos, paginas)

    End Sub

    Private Function llenarDisco(proc As Integer, U As Integer)
        Disco.Columns.Clear()
        Disco.Rows.Clear()
        Dim cantpag As Integer = Math.Ceiling(proc / U)
        Dim m As Integer = U
        Dim n As Integer = Math.Ceiling(cantpag / m)
        Dim paginas(n - 1, m - 1) As Integer
        Dim pagina = 0
        Disco.ColumnCount = m
        Disco.RowCount = n
        For i = 0 To n - 1
                For j = 0 To m - 1
                If i * U + j >= cantpag Then
                    paginas(i, j) = -1
                Else
                    Disco.Rows(i).Cells(j).Value = pagina
                        paginas(i, j) = pagina
                        pagina += 1
                    End If
                Next
            Next
            Bitacora.AppendText(String.Format("El proceso posee {0} paginas en disco duro" & vbCrLf, cantpag))
            Bitacora.AppendText(String.Format("De las cuales se pierden {0} Bits" & vbCrLf, cantpag * U - proc))
        Bitacora.ScrollToCaret()
        Return paginas
    End Function

    Private Sub Pausar_Click(sender As Object, e As EventArgs) Handles Pausar.Click

    End Sub

    Private Sub Detener_Click(sender As Object, e As EventArgs) Handles Detener.Click
        tamMarco.Enabled = True
        tamOS.Enabled = True
        tamProc.Enabled = True
        marcosLib.Enabled = True
        Aceptar.Enabled = True
        Pausar.Enabled = False
        Empezar.Enabled = False
    End Sub

    Public Sub LlenarTablaPag(marcos As String(), paginas(,) As Integer)
        TablaPaginaBindingSource.Clear()
        Dim tablapags As List(Of TablaPagina) = New List(Of TablaPagina)
        Bitacora.AppendText(String.Format("Llenando la tabla de paginas ..."))
        For i = 0 To paginas.GetLength(0) - 1
            For j = 0 To paginas.GetLength(1) - 1
                If (Not (paginas(i, j) = -1)) Then
                    tablapags.Add(New TablaPagina() With {
                    .BitActivoInactivo = 0,
                    .BitModificado = 0,
                    .Tiempo = 0,
                    .Marco = -1,
                    .Pagina = paginas(i, j)
                        })
                End If


            Next
            Bitacora.AppendText(vbCrLf)
        Next
        TablaPaginaBindingSource.DataSource = tablapags

    End Sub


End Class