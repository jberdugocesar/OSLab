
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
                        If (U < proc) Then
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
                        Else
                            Bitacora.Clear()
                            Bitacora.AppendText("El tamaño del proceso es menor al de la pagina")
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
        llenarDisco(proc, U)
        LlenarTablaPag()

    End Sub

    Private Sub llenarDisco(proc As Integer, U As Integer)
        Dim n As Integer = proc / U
        ' corregir esto cuando vuelva 
        Dim m As Integer = n
        Disco.ColumnCount = n
        Disco.RowCount = m
        If n >= 1 Then
            Bitacora.AppendText(String.Format("El proceso posee {0} paginas en disco duro", n * n))
            Bitacora.ScrollToCaret()
            Dim pagina = 1
            For i = 0 To m - 1
                For j = 0 To n - 1
                    Disco.Rows(i).Cells(j).Value = pagina
                    pagina += 1
                Next
            Next
        End If
    End Sub

    Private Sub Pausar_Click(sender As Object, e As EventArgs) Handles Pausar.Click

    End Sub

    Private Sub Detener_Click(sender As Object, e As EventArgs) Handles Detener.Click

    End Sub

    Public Sub LlenarTablaPag()
        Dim marcos As String() = marcosLib.Text.Split(",")
    End Sub


End Class