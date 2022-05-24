<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Bitacora = New System.Windows.Forms.RichTextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(123, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tabla de Paginas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(504, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Memoria Principal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(943, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Disco"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(22, 81)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(355, 287)
        Me.DataGridView1.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(560, 500)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 21)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Velocidad"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(614, 554)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(79, 40)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = ">>>"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(513, 554)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(78, 40)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "<<<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(577, 521)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 30)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "1.0X"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(929, 393)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 30)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Bitacora"
        '
        'Bitacora
        '
        Me.Bitacora.BackColor = System.Drawing.Color.White
        Me.Bitacora.Location = New System.Drawing.Point(744, 438)
        Me.Bitacora.Name = "Bitacora"
        Me.Bitacora.ReadOnly = True
        Me.Bitacora.Size = New System.Drawing.Size(434, 179)
        Me.Bitacora.TabIndex = 13
        Me.Bitacora.Text = ""
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(513, 68)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 25
        Me.DataGridView2.Size = New System.Drawing.Size(156, 300)
        Me.DataGridView2.TabIndex = 15
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1193, 633)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Bitacora)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Bitacora As RichTextBox
    Friend WithEvents DataGridView2 As DataGridView
End Class
