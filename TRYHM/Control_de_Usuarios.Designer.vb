<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Control_de_Usuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Control_de_Usuarios))
        Me.DataGridUsers = New System.Windows.Forms.DataGridView()
        Me.btnmostrar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSent = New System.Windows.Forms.Button()
        Me.txtidentificacion = New System.Windows.Forms.TextBox()
        Me.txtapellido2 = New System.Windows.Forms.TextBox()
        Me.txtapellido1 = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridUsers
        '
        Me.DataGridUsers.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DataGridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridUsers.Location = New System.Drawing.Point(306, 85)
        Me.DataGridUsers.Name = "DataGridUsers"
        Me.DataGridUsers.Size = New System.Drawing.Size(501, 214)
        Me.DataGridUsers.TabIndex = 0
        '
        'btnmostrar
        '
        Me.btnmostrar.BackColor = System.Drawing.Color.Black
        Me.btnmostrar.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmostrar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnmostrar.Location = New System.Drawing.Point(436, 317)
        Me.btnmostrar.Name = "btnmostrar"
        Me.btnmostrar.Size = New System.Drawing.Size(101, 36)
        Me.btnmostrar.TabIndex = 1
        Me.btnmostrar.Text = "Mostrar"
        Me.btnmostrar.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(692, 416)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 43)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Regresar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnmodificar
        '
        Me.btnmodificar.BackColor = System.Drawing.Color.Black
        Me.btnmodificar.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnmodificar.Location = New System.Drawing.Point(565, 317)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(101, 36)
        Me.btnmodificar.TabIndex = 4
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = False
        '
        'btneliminar
        '
        Me.btneliminar.BackColor = System.Drawing.Color.Black
        Me.btneliminar.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminar.ForeColor = System.Drawing.SystemColors.Control
        Me.btneliminar.Location = New System.Drawing.Point(692, 317)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(101, 36)
        Me.btneliminar.TabIndex = 5
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnSent)
        Me.Panel1.Controls.Add(Me.txtidentificacion)
        Me.Panel1.Controls.Add(Me.txtapellido2)
        Me.Panel1.Controls.Add(Me.txtapellido1)
        Me.Panel1.Controls.Add(Me.txtname)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(298, 486)
        Me.Panel1.TabIndex = 6
        '
        'btnSent
        '
        Me.btnSent.BackColor = System.Drawing.Color.Black
        Me.btnSent.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSent.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSent.Location = New System.Drawing.Point(187, 342)
        Me.btnSent.Name = "btnSent"
        Me.btnSent.Size = New System.Drawing.Size(101, 43)
        Me.btnSent.TabIndex = 7
        Me.btnSent.Text = "ENVIAR"
        Me.btnSent.UseVisualStyleBackColor = False
        '
        'txtidentificacion
        '
        Me.txtidentificacion.Location = New System.Drawing.Point(198, 269)
        Me.txtidentificacion.Name = "txtidentificacion"
        Me.txtidentificacion.Size = New System.Drawing.Size(100, 20)
        Me.txtidentificacion.TabIndex = 14
        '
        'txtapellido2
        '
        Me.txtapellido2.Location = New System.Drawing.Point(198, 187)
        Me.txtapellido2.Name = "txtapellido2"
        Me.txtapellido2.Size = New System.Drawing.Size(100, 20)
        Me.txtapellido2.TabIndex = 13
        '
        'txtapellido1
        '
        Me.txtapellido1.Location = New System.Drawing.Point(198, 116)
        Me.txtapellido1.Name = "txtapellido1"
        Me.txtapellido1.Size = New System.Drawing.Size(100, 20)
        Me.txtapellido1.TabIndex = 12
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(198, 33)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(100, 20)
        Me.txtname.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(26, 269)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 22)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(26, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 22)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Segundo Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(26, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 22)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Primer Apellido"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(26, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 22)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nombre"
        '
        'Control_de_Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(819, 471)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnmostrar)
        Me.Controls.Add(Me.DataGridUsers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Control_de_Usuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control_de_Usuarios"
        CType(Me.DataGridUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridUsers As DataGridView
    Friend WithEvents btnmostrar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSent As Button
    Friend WithEvents txtidentificacion As TextBox
    Friend WithEvents txtapellido2 As TextBox
    Friend WithEvents txtapellido1 As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
