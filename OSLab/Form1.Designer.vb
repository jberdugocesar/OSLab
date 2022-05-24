Imports System.IO

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGrid As System.Windows.Forms.DataGridView
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim GroupBox1 As System.Windows.Forms.GroupBox
        Me.NumeroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EntradaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.marcosLib = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tamProc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tamOS = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Aceptar = New System.Windows.Forms.Button()
        Me.tamMarco = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Bitacora = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Empezar = New System.Windows.Forms.Button()
        DataGrid = New System.Windows.Forms.DataGridView()
        GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EntradaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGrid
        '
        DataGrid.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        DataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroDataGridViewTextBoxColumn, Me.ValorDataGridViewTextBoxColumn})
        DataGrid.DataSource = Me.EntradaBindingSource
        DataGrid.Location = New System.Drawing.Point(8, 240)
        DataGrid.Name = "DataGrid"
        DataGrid.ReadOnly = True
        DataGrid.RowHeadersVisible = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGrid.RowsDefaultCellStyle = DataGridViewCellStyle2
        DataGrid.RowTemplate.Height = 25
        DataGrid.Size = New System.Drawing.Size(402, 220)
        DataGrid.TabIndex = 17
        '
        'NumeroDataGridViewTextBoxColumn
        '
        Me.NumeroDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NumeroDataGridViewTextBoxColumn.DataPropertyName = "numero"
        Me.NumeroDataGridViewTextBoxColumn.HeaderText = "Número"
        Me.NumeroDataGridViewTextBoxColumn.Name = "NumeroDataGridViewTextBoxColumn"
        Me.NumeroDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ValorDataGridViewTextBoxColumn
        '
        Me.ValorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ValorDataGridViewTextBoxColumn.DataPropertyName = "valor"
        Me.ValorDataGridViewTextBoxColumn.HeaderText = "Valor"
        Me.ValorDataGridViewTextBoxColumn.Name = "ValorDataGridViewTextBoxColumn"
        Me.ValorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EntradaBindingSource
        '
        Me.EntradaBindingSource.DataSource = GetType(OSLab.Entrada)
        '
        'GroupBox1
        '
        GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        GroupBox1.Controls.Add(Me.marcosLib)
        GroupBox1.Controls.Add(Me.Label5)
        GroupBox1.Controls.Add(DataGrid)
        GroupBox1.Controls.Add(Me.tamProc)
        GroupBox1.Controls.Add(Me.Label7)
        GroupBox1.Controls.Add(Me.Label9)
        GroupBox1.Controls.Add(Me.tamOS)
        GroupBox1.Controls.Add(Me.Label2)
        GroupBox1.Controls.Add(Me.Aceptar)
        GroupBox1.Controls.Add(Me.tamMarco)
        GroupBox1.Controls.Add(Me.Label1)
        GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        GroupBox1.Location = New System.Drawing.Point(30, 27)
        GroupBox1.Margin = New System.Windows.Forms.Padding(0)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New System.Windows.Forms.Padding(5)
        GroupBox1.Size = New System.Drawing.Size(422, 531)
        GroupBox1.TabIndex = 16
        GroupBox1.TabStop = False
        GroupBox1.Text = "Datos"
        '
        'marcosLib
        '
        Me.marcosLib.Location = New System.Drawing.Point(160, 140)
        Me.marcosLib.Name = "marcosLib"
        Me.marcosLib.Size = New System.Drawing.Size(185, 23)
        Me.marcosLib.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(68, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 15)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Marcos Libres"
        '
        'tamProc
        '
        Me.tamProc.Location = New System.Drawing.Point(188, 102)
        Me.tamProc.Name = "tamProc"
        Me.tamProc.Size = New System.Drawing.Size(163, 23)
        Me.tamProc.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(136, 197)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 21)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Datos de Entrada"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(68, 105)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 15)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Tamaño Del Proceso"
        '
        'tamOS
        '
        Me.tamOS.Location = New System.Drawing.Point(158, 62)
        Me.tamOS.Name = "tamOS"
        Me.tamOS.Size = New System.Drawing.Size(153, 23)
        Me.tamOS.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Tamaño OS"
        '
        'Aceptar
        '
        Me.Aceptar.Location = New System.Drawing.Point(136, 482)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(137, 41)
        Me.Aceptar.TabIndex = 0
        Me.Aceptar.Text = "Guardar Datos"
        Me.Aceptar.UseVisualStyleBackColor = True
        '
        'tamMarco
        '
        Me.tamMarco.Location = New System.Drawing.Point(158, 24)
        Me.tamMarco.Name = "tamMarco"
        Me.tamMarco.Size = New System.Drawing.Size(153, 23)
        Me.tamMarco.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tamaño Marco"
        '
        'Bitacora
        '
        Me.Bitacora.BackColor = System.Drawing.Color.White
        Me.Bitacora.Location = New System.Drawing.Point(481, 246)
        Me.Bitacora.Name = "Bitacora"
        Me.Bitacora.ReadOnly = True
        Me.Bitacora.Size = New System.Drawing.Size(426, 212)
        Me.Bitacora.TabIndex = 2
        Me.Bitacora.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(651, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 30)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Bitacora"
        '
        'Empezar
        '
        Me.Empezar.Enabled = False
        Me.Empezar.Location = New System.Drawing.Point(638, 495)
        Me.Empezar.Name = "Empezar"
        Me.Empezar.Size = New System.Drawing.Size(132, 41)
        Me.Empezar.TabIndex = 17
        Me.Empezar.Text = "Empezar"
        Me.Empezar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 566)
        Me.Controls.Add(Me.Empezar)
        Me.Controls.Add(GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Bitacora)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EntradaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bitacora As RichTextBox
    Friend WithEvents Label4 As Label

    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click

        If Not tamMarco.Text.Equals("") And Not tamOS.Text.Equals("") And Not tamProc.Text.Equals("") And Not marcosLib.Text.Equals("") Then
            Bitacora.Clear()
            Empezar.Enabled = True
            Dim tam1 As String = tamMarco.Text
            Dim tam2 As String = tamOS.Text
            Dim tam3 As String = tamProc.Text
            Dim marcos As String() = marcosLib.Text.Split(",")
            Bitacora.AppendText(String.Format("Los tamaños son: " & vbCrLf & "Marco {0}" & vbCrLf & "OS: {1}" & vbCrLf & "Proceso: {2}" & vbCrLf, tam1, tam2, tam3))
            Bitacora.AppendText("Los marcos libres son: ")
            For i As Integer = 0 To marcos.Length - 1
                Bitacora.AppendText(String.Format(" {0} ", marcos(i)))
            Next
            Bitacora.AppendText(vbCrLf)
            Using ofd As OpenFileDialog = New OpenFileDialog() With {.Filter = "Text file|*.csv"}
                If ofd.ShowDialog() = DialogResult.OK Then
                    Dim lines As List(Of String) = File.ReadAllLines(ofd.FileName).ToList()
                    Dim lista As List(Of Entrada) = New List(Of Entrada)
                    Dim numero As String() = lines(0).Split(",")
                    Dim valor As String() = lines(1).Split(",")
                    For i As Integer = 0 To numero.Length - 1
                        Bitacora.AppendText(String.Format("La linea {0} Posee número {1} y valor {2} " & vbCrLf, i, numero(i), valor(i)))
                        lista.Add(New Entrada() With {
                              .numero = numero(i),
                              .valor = valor(i)})
                    Next
                    EntradaBindingSource.DataSource = lista
                End If
            End Using
        End If

    End Sub
    Friend WithEvents EntradaBindingSource As BindingSource
    Friend WithEvents Empezar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tamMarco As TextBox
    Friend WithEvents Aceptar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents tamOS As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tamProc As TextBox
    Friend WithEvents NumeroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents marcosLib As TextBox
End Class
