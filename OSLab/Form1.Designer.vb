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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.Empezar = New System.Windows.Forms.Button()
        Me.memPrincipal = New System.Windows.Forms.DataGridView()
        Me.DirFisicaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemoriaPrincipalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Bitacora = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Pausar = New System.Windows.Forms.Button()
        Me.Detener = New System.Windows.Forms.Button()
        Me.TablaPag = New System.Windows.Forms.DataGridView()
        Me.PaginaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BitActivoInactivoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BitModificadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TiempoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TablaPaginaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Disco = New System.Windows.Forms.DataGridView()
        DataGrid = New System.Windows.Forms.DataGridView()
        GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EntradaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(Me.memPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoriaPrincipalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablaPag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablaPaginaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Disco, System.ComponentModel.ISupportInitialize).BeginInit()
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
        GroupBox1.Size = New System.Drawing.Size(422, 517)
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
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(60, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 15)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Marcos Libres:"
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
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(60, 105)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 15)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Tamaño Del Proceso:"
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
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(60, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Tamaño OS:"
        '
        'Aceptar
        '
        Me.Aceptar.Location = New System.Drawing.Point(139, 468)
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
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(60, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tamaño Marco:"
        '
        'Empezar
        '
        Me.Empezar.Enabled = False
        Me.Empezar.Location = New System.Drawing.Point(501, 495)
        Me.Empezar.Name = "Empezar"
        Me.Empezar.Size = New System.Drawing.Size(132, 41)
        Me.Empezar.TabIndex = 17
        Me.Empezar.Text = "Empezar"
        Me.Empezar.UseVisualStyleBackColor = True
        '
        'memPrincipal
        '
        Me.memPrincipal.AutoGenerateColumns = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.memPrincipal.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.memPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.memPrincipal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DirFisicaDataGridViewTextBoxColumn, Me.ValorDataGridViewTextBoxColumn1})
        Me.memPrincipal.DataSource = Me.MemoriaPrincipalBindingSource
        Me.memPrincipal.Location = New System.Drawing.Point(956, 51)
        Me.memPrincipal.Name = "memPrincipal"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.memPrincipal.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.memPrincipal.RowHeadersVisible = False
        Me.memPrincipal.RowTemplate.Height = 25
        Me.memPrincipal.Size = New System.Drawing.Size(183, 308)
        Me.memPrincipal.TabIndex = 28
        '
        'DirFisicaDataGridViewTextBoxColumn
        '
        Me.DirFisicaDataGridViewTextBoxColumn.DataPropertyName = "dirFisica"
        Me.DirFisicaDataGridViewTextBoxColumn.HeaderText = "Dir.Fisica"
        Me.DirFisicaDataGridViewTextBoxColumn.Name = "DirFisicaDataGridViewTextBoxColumn"
        Me.DirFisicaDataGridViewTextBoxColumn.Width = 80
        '
        'ValorDataGridViewTextBoxColumn1
        '
        Me.ValorDataGridViewTextBoxColumn1.DataPropertyName = "valor"
        Me.ValorDataGridViewTextBoxColumn1.HeaderText = "Contenido"
        Me.ValorDataGridViewTextBoxColumn1.Name = "ValorDataGridViewTextBoxColumn1"
        '
        'MemoriaPrincipalBindingSource
        '
        Me.MemoriaPrincipalBindingSource.DataSource = GetType(OSLab.MemoriaPrincipal)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(673, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 30)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Bitacora"
        '
        'Bitacora
        '
        Me.Bitacora.BackColor = System.Drawing.Color.White
        Me.Bitacora.Location = New System.Drawing.Point(501, 267)
        Me.Bitacora.Name = "Bitacora"
        Me.Bitacora.ReadOnly = True
        Me.Bitacora.Size = New System.Drawing.Size(434, 179)
        Me.Bitacora.TabIndex = 26
        Me.Bitacora.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(693, 580)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 30)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "1.0X"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(676, 559)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 21)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Velocidad"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(756, 579)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(79, 40)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = ">>>"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(609, 580)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(78, 40)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "<<<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(1294, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 25)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Disco Duro"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(956, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(175, 25)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Memoria Principal"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(622, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(159, 25)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Tabla de Paginas"
        '
        'Pausar
        '
        Me.Pausar.Enabled = False
        Me.Pausar.Location = New System.Drawing.Point(656, 495)
        Me.Pausar.Name = "Pausar"
        Me.Pausar.Size = New System.Drawing.Size(125, 41)
        Me.Pausar.TabIndex = 29
        Me.Pausar.Text = "Pausar"
        Me.Pausar.UseVisualStyleBackColor = True
        '
        'Detener
        '
        Me.Detener.Enabled = False
        Me.Detener.Location = New System.Drawing.Point(809, 495)
        Me.Detener.Name = "Detener"
        Me.Detener.Size = New System.Drawing.Size(121, 40)
        Me.Detener.TabIndex = 30
        Me.Detener.Text = "Detener"
        Me.Detener.UseVisualStyleBackColor = True
        '
        'TablaPag
        '
        Me.TablaPag.AutoGenerateColumns = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TablaPag.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.TablaPag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaPag.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PaginaDataGridViewTextBoxColumn, Me.MarcoDataGridViewTextBoxColumn, Me.BitActivoInactivoDataGridViewTextBoxColumn, Me.BitModificadoDataGridViewTextBoxColumn, Me.TiempoDataGridViewTextBoxColumn})
        Me.TablaPag.DataSource = Me.TablaPaginaBindingSource
        Me.TablaPag.Location = New System.Drawing.Point(487, 54)
        Me.TablaPag.Name = "TablaPag"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TablaPag.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.TablaPag.RowHeadersVisible = False
        Me.TablaPag.RowTemplate.Height = 25
        Me.TablaPag.Size = New System.Drawing.Size(443, 150)
        Me.TablaPag.TabIndex = 31
        '
        'PaginaDataGridViewTextBoxColumn
        '
        Me.PaginaDataGridViewTextBoxColumn.DataPropertyName = "Pagina"
        Me.PaginaDataGridViewTextBoxColumn.HeaderText = "Pagina"
        Me.PaginaDataGridViewTextBoxColumn.Name = "PaginaDataGridViewTextBoxColumn"
        Me.PaginaDataGridViewTextBoxColumn.Width = 80
        '
        'MarcoDataGridViewTextBoxColumn
        '
        Me.MarcoDataGridViewTextBoxColumn.DataPropertyName = "Marco"
        Me.MarcoDataGridViewTextBoxColumn.HeaderText = "Marco"
        Me.MarcoDataGridViewTextBoxColumn.Name = "MarcoDataGridViewTextBoxColumn"
        Me.MarcoDataGridViewTextBoxColumn.Width = 80
        '
        'BitActivoInactivoDataGridViewTextBoxColumn
        '
        Me.BitActivoInactivoDataGridViewTextBoxColumn.DataPropertyName = "BitActivoInactivo"
        Me.BitActivoInactivoDataGridViewTextBoxColumn.HeaderText = "BitActivoInactivo"
        Me.BitActivoInactivoDataGridViewTextBoxColumn.Name = "BitActivoInactivoDataGridViewTextBoxColumn"
        '
        'BitModificadoDataGridViewTextBoxColumn
        '
        Me.BitModificadoDataGridViewTextBoxColumn.DataPropertyName = "BitModificado"
        Me.BitModificadoDataGridViewTextBoxColumn.HeaderText = "BitModificado"
        Me.BitModificadoDataGridViewTextBoxColumn.Name = "BitModificadoDataGridViewTextBoxColumn"
        '
        'TiempoDataGridViewTextBoxColumn
        '
        Me.TiempoDataGridViewTextBoxColumn.DataPropertyName = "Tiempo"
        Me.TiempoDataGridViewTextBoxColumn.HeaderText = "Tiempo"
        Me.TiempoDataGridViewTextBoxColumn.Name = "TiempoDataGridViewTextBoxColumn"
        Me.TiempoDataGridViewTextBoxColumn.Width = 80
        '
        'TablaPaginaBindingSource
        '
        Me.TablaPaginaBindingSource.DataSource = GetType(OSLab.TablaPagina)
        '
        'Disco
        '
        Me.Disco.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Disco.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.Disco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Disco.ColumnHeadersVisible = False
        Me.Disco.Location = New System.Drawing.Point(1171, 51)
        Me.Disco.Name = "Disco"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Disco.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.Disco.RowHeadersVisible = False
        Me.Disco.RowTemplate.Height = 25
        Me.Disco.Size = New System.Drawing.Size(382, 308)
        Me.Disco.TabIndex = 32
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1565, 643)
        Me.Controls.Add(Me.Disco)
        Me.Controls.Add(Me.TablaPag)
        Me.Controls.Add(Me.Detener)
        Me.Controls.Add(Me.Pausar)
        Me.Controls.Add(Me.memPrincipal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Bitacora)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Empezar)
        Me.Controls.Add(GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EntradaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(Me.memPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoriaPrincipalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablaPag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablaPaginaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Disco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click
        If Not tamMarco.Text.Equals("") And Not tamOS.Text.Equals("") And Not tamProc.Text.Equals("") And Not marcosLib.Text.Equals("") Then

            Using ofd As OpenFileDialog = New OpenFileDialog() With {.Filter = "Text file|*.csv"}
                If ofd.ShowDialog() = DialogResult.OK Then
                    Bitacora.Clear()
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

                    Dim lines As List(Of String) = File.ReadAllLines(ofd.FileName).ToList()
                    Dim lista As List(Of Entrada) = New List(Of Entrada)
                    Dim numero As String() = lines(0).Split(",")
                    Dim valor As String() = lines(1).Split(",")
                    For i As Integer = 0 To numero.Length - 1
                        Bitacora.AppendText(String.Format("La linea {0} Posee número {1} y valor {2} " & vbCrLf, i + 1, numero(i), valor(i)))
                        lista.Add(New Entrada() With {
                              .numero = numero(i),
                              .valor = valor(i)})
                    Next

                    EntradaBindingSource.DataSource = lista
                    Empezar.Enabled = True
                    Pausar.Enabled = True
                    Detener.Enabled = True
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
    Friend WithEvents memPrincipal As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Bitacora As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents MemoriaPrincipalBindingSource As BindingSource
    Friend WithEvents Pausar As Button
    Friend WithEvents Detener As Button
    Friend WithEvents DirFisicaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValorDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TablaPag As DataGridView
    Friend WithEvents PaginaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MarcoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BitActivoInactivoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BitModificadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TiempoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TablaPaginaBindingSource As BindingSource
    Friend WithEvents Disco As DataGridView
End Class
