
Imports System.IO
Imports System.Threading


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
                    mem = LlenarOS(os, U)
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

    Public Function LlenarOS(tamOS As Integer, U As Integer)
        MemoriaPrincipalBindingSource.Clear()
        Bitacora.AppendText(String.Format("Llenando la parte baja de la Memoria Principal" & vbCrLf))
        Dim n As Integer = tamOS / U
        Dim lista As List(Of MemoriaPrincipal) = New List(Of MemoriaPrincipal)
        For i = 0 To n
            lista.Add(New MemoriaPrincipal() With {
                  .dirFisica = i,
                  .pag = "OS"})
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
        Bitacora.AppendText(vbCrLf & "Se empieza la simulación " & vbCrLf)
        Dim mem As List(Of MemoriaPrincipal) = New List(Of MemoriaPrincipal)
        Dim U, os, proc As Integer
        U = Convert.ToInt64(tamMarco.Text)
        os = Convert.ToInt64(tamOS.Text)
        proc = Convert.ToInt64(tamProc.Text)
        Dim marcos As String() = marcosLib.Text.Split(",")
        mem = LlenarOS(os, U)
        For i = 0 To marcos.Length - 1
            mem.Add(New MemoriaPrincipal() With {
                                .dirFisica = marcos(i),
                                .pag = -1})
        Next
        MemoriaPrincipalBindingSource.DataSource = mem
        Dim paginas(,) As Integer
        paginas = llenarDisco(proc, U)
        Dim tablapags As List(Of TablaPagina) = New List(Of TablaPagina)
        tablapags = LlenarTablaPag(marcos, paginas)
        Dim entrada As List(Of Entrada) = New List(Of Entrada)
        entrada = EntradaBindingSource.DataSource
        Bitacora.AppendText(String.Format(vbCrLf & "-------------------------------------" & vbCrLf))
        EmpezarSimulacion(entrada, marcos, mem, paginas, tablapags, U)

    End Sub


    Private Sub EmpezarSimulacion(entrada As List(Of Entrada), marcos() As String, mem As List(Of MemoriaPrincipal), paginas(,) As Integer, tablapags As List(Of TablaPagina), U As Integer)




        For i = 0 To entrada.Count - 1
            Dim DL As Integer = entrada(i).numero
            Dim p As Integer = DL / U
            Dim d As Integer = DL Mod U
            Dim m As Integer = BuscarMarcoDisp(entrada(i).numero, paginas, mem, tablapags)
            Dim DF As Integer = m * U + d

            If entrada(i).valor.Equals("E") Then
                tablapags(m).BitActivoInactivo = 1
                tablapags(m).BitModificado = 1
            Else
                If entrada(i).valor.Equals("L") Then
                    tablapags(m).BitActivoInactivo = 1
                    tablapags(m).BitModificado = 0
                End If
            End If

        Next

        Bitacora.ScrollToCaret()




    End Sub

    Private Function BuscarMarcoDisp(entrada As Integer, paginas(,) As Integer, mem As List(Of MemoriaPrincipal), tablapags As List(Of TablaPagina)) As Integer
        Dim i As Integer = 0
        Dim encontrado As Integer = 0
        ' Si entrada se encuentra en el rango de las paginas establecidas
        If (tablapags.Count() > entrada) Then
            Bitacora.AppendText(String.Format(vbCrLf & "Hallando la entrada: {0} en la tabla de paginas" & vbCrLf, entrada))
            If (tablapags(entrada).Marco.Equals(-1)) Then
                Bitacora.AppendText(String.Format("Se produjo un fallo de pagina con la entrada: {0} en pagina: {1}" & vbCrLf, entrada, tablapags(entrada).Pagina))
                ' Buscar en disco la pagina
                Bitacora.AppendText(String.Format("Buscando Pagina en el disco..." & vbCrLf))
                For i = 0 To paginas.GetLength(0) - 1
                    For j = 0 To paginas.GetLength(1) - 1
                        If (tablapags(entrada).Pagina.Equals(paginas(i, j))) Then
                            Bitacora.AppendText(String.Format("Se ha encontrado la pagina {0}" & vbCrLf, paginas(i, j)))
                            encontrado = paginas(i, j)
                            i = paginas.GetLength(0) + 1
                            j = paginas.GetLength(1) + 1
                            tablapags(entrada).Pagina = encontrado
                        End If

                    Next
                Next
                Bitacora.AppendText(String.Format("Buscando Marco disponible en memoria..." & vbCrLf))
                ' Buscar en memoria la pagina
                For i = 0 To mem.Count - 1
                    If mem(i).pag.Equals("-1") Then
                        Bitacora.AppendText(String.Format("Marco: {0} Disponible en {1}" & vbCrLf, mem(i).pag, mem(i).dirFisica))
                        Bitacora.AppendText(String.Format("SWAP IN [ X ]" & vbCrLf))
                        mem(i).pag = encontrado
                        tablapags(entrada).Marco = mem(i).dirFisica
                        i = mem.Count + 1

                    End If
                Next
                'Actualizar tabla
                Bitacora.AppendText(String.Format("Actualizando Tabla..." & vbCrLf))
                Bitacora.AppendText(String.Format("-------------------------------------------" & vbCrLf))
                Bitacora.ScrollToCaret()


                Return encontrado
                ' Crear un else cuando entrada no existe y me falta un OR
            End If
        Else
            Bitacora.AppendText(String.Format("La entrada: {0} es muy grande para ser encontrada", entrada))
        End If

        Return encontrado

    End Function

    Private Function llenarDisco(proc As Integer, U As Integer)
        Disco.Columns.Clear()
        Disco.Rows.Clear()
        Bitacora.AppendText(String.Format("Llenando el disco duro... " & vbCrLf))
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

    Public Function LlenarTablaPag(marcos As String(), paginas(,) As Integer)
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
        Next
        TablaPaginaBindingSource.DataSource = tablapags
        Return tablapags
    End Function



    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        'add delayed code here
        '...
        '...
        MessageBox.Show("Delayed message...")
    End Sub

End Class