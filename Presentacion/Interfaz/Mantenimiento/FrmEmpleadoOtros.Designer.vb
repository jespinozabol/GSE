Namespace Interfaz.Mantenimiento
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmEmpleadoOtros
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
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

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.dgvClientes = New System.Windows.Forms.DataGridView()
            Me.txtObservaciones = New System.Windows.Forms.TextBox()
            Me.lblObserv = New System.Windows.Forms.Label()
            Me.txtDireccion = New System.Windows.Forms.TextBox()
            Me.lblDireccion = New System.Windows.Forms.Label()
            Me.txtCedula = New System.Windows.Forms.TextBox()
            Me.lblCedula = New System.Windows.Forms.Label()
            Me.btnCorregir = New System.Windows.Forms.Button()
            Me.txtApellido2 = New System.Windows.Forms.TextBox()
            Me.txtApellido1 = New System.Windows.Forms.TextBox()
            Me.txtNombre = New System.Windows.Forms.TextBox()
            Me.lblApellido2 = New System.Windows.Forms.Label()
            Me.lblNombre = New System.Windows.Forms.Label()
            Me.lblApellido1 = New System.Windows.Forms.Label()
            Me.btnGuardar = New System.Windows.Forms.Button()
            Me.btnLimpiar = New System.Windows.Forms.Button()
            Me.lblId_Persona = New System.Windows.Forms.Label()
            Me.txtId_Persona = New System.Windows.Forms.TextBox()
            Me.lblRol = New System.Windows.Forms.Label()
            Me.txtRol = New System.Windows.Forms.TextBox()
            Me.errorEmpleados = New System.Windows.Forms.ErrorProvider(Me.components)
            Me.txtId_Empleado = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtOtroTelefono = New System.Windows.Forms.TextBox()
            Me.lblOtroTelefono = New System.Windows.Forms.Label()
            Me.txtFax = New System.Windows.Forms.TextBox()
            Me.lblFax = New System.Windows.Forms.Label()
            Me.txtTelefono = New System.Windows.Forms.TextBox()
            Me.lblTelefono = New System.Windows.Forms.Label()
            Me.txtSitioWeb = New System.Windows.Forms.TextBox()
            Me.lblSitio = New System.Windows.Forms.Label()
            Me.txtEmail = New System.Windows.Forms.TextBox()
            Me.lblEmail = New System.Windows.Forms.Label()
            CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.errorEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dgvClientes
            '
            Me.dgvClientes.AllowUserToAddRows = False
            Me.dgvClientes.AllowUserToDeleteRows = False
            Me.dgvClientes.AllowUserToResizeColumns = False
            Me.dgvClientes.AllowUserToResizeRows = False
            Me.dgvClientes.BackgroundColor = System.Drawing.Color.White
            Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvClientes.GridColor = System.Drawing.Color.White
            Me.dgvClientes.Location = New System.Drawing.Point(135, 109)
            Me.dgvClientes.MultiSelect = False
            Me.dgvClientes.Name = "dgvClientes"
            Me.dgvClientes.ReadOnly = True
            Me.dgvClientes.RowHeadersVisible = False
            Me.dgvClientes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvClientes.Size = New System.Drawing.Size(351, 105)
            Me.dgvClientes.TabIndex = 230
            Me.dgvClientes.Visible = False
            '
            'txtObservaciones
            '
            Me.txtObservaciones.Location = New System.Drawing.Point(7, 291)
            Me.txtObservaciones.MaxLength = 140
            Me.txtObservaciones.Multiline = True
            Me.txtObservaciones.Name = "txtObservaciones"
            Me.txtObservaciones.Size = New System.Drawing.Size(477, 33)
            Me.txtObservaciones.TabIndex = 217
            '
            'lblObserv
            '
            Me.lblObserv.AutoSize = True
            Me.lblObserv.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblObserv.Location = New System.Drawing.Point(6, 273)
            Me.lblObserv.Name = "lblObserv"
            Me.lblObserv.Size = New System.Drawing.Size(87, 15)
            Me.lblObserv.TabIndex = 229
            Me.lblObserv.Text = "Observaciones"
            '
            'txtDireccion
            '
            Me.txtDireccion.Location = New System.Drawing.Point(7, 250)
            Me.txtDireccion.MaxLength = 100
            Me.txtDireccion.Name = "txtDireccion"
            Me.txtDireccion.Size = New System.Drawing.Size(479, 20)
            Me.txtDireccion.TabIndex = 214
            '
            'lblDireccion
            '
            Me.lblDireccion.AutoSize = True
            Me.lblDireccion.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDireccion.Location = New System.Drawing.Point(4, 232)
            Me.lblDireccion.Name = "lblDireccion"
            Me.lblDireccion.Size = New System.Drawing.Size(59, 15)
            Me.lblDireccion.TabIndex = 227
            Me.lblDireccion.Text = "Dirección"
            '
            'txtCedula
            '
            Me.txtCedula.Location = New System.Drawing.Point(246, 128)
            Me.txtCedula.MaxLength = 18
            Me.txtCedula.Name = "txtCedula"
            Me.txtCedula.Size = New System.Drawing.Size(148, 20)
            Me.txtCedula.TabIndex = 208
            '
            'lblCedula
            '
            Me.lblCedula.AutoSize = True
            Me.lblCedula.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCedula.Location = New System.Drawing.Point(243, 110)
            Me.lblCedula.Name = "lblCedula"
            Me.lblCedula.Size = New System.Drawing.Size(44, 15)
            Me.lblCedula.TabIndex = 226
            Me.lblCedula.Text = "Cédula"
            '
            'btnCorregir
            '
            Me.btnCorregir.Location = New System.Drawing.Point(411, 126)
            Me.btnCorregir.Name = "btnCorregir"
            Me.btnCorregir.Size = New System.Drawing.Size(75, 23)
            Me.btnCorregir.TabIndex = 221
            Me.btnCorregir.Text = "Corregir"
            Me.btnCorregir.UseVisualStyleBackColor = True
            '
            'txtApellido2
            '
            Me.txtApellido2.Location = New System.Drawing.Point(125, 129)
            Me.txtApellido2.MaxLength = 15
            Me.txtApellido2.Name = "txtApellido2"
            Me.txtApellido2.Size = New System.Drawing.Size(115, 20)
            Me.txtApellido2.TabIndex = 206
            '
            'txtApellido1
            '
            Me.txtApellido1.Location = New System.Drawing.Point(7, 129)
            Me.txtApellido1.MaxLength = 15
            Me.txtApellido1.Name = "txtApellido1"
            Me.txtApellido1.Size = New System.Drawing.Size(115, 20)
            Me.txtApellido1.TabIndex = 205
            '
            'txtNombre
            '
            Me.txtNombre.Location = New System.Drawing.Point(135, 88)
            Me.txtNombre.MaxLength = 60
            Me.txtNombre.Name = "txtNombre"
            Me.txtNombre.Size = New System.Drawing.Size(353, 20)
            Me.txtNombre.TabIndex = 202
            '
            'lblApellido2
            '
            Me.lblApellido2.AutoSize = True
            Me.lblApellido2.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblApellido2.Location = New System.Drawing.Point(125, 111)
            Me.lblApellido2.Name = "lblApellido2"
            Me.lblApellido2.Size = New System.Drawing.Size(104, 15)
            Me.lblApellido2.TabIndex = 207
            Me.lblApellido2.Text = "Segundo Apellido"
            '
            'lblNombre
            '
            Me.lblNombre.AutoSize = True
            Me.lblNombre.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombre.Location = New System.Drawing.Point(135, 70)
            Me.lblNombre.Name = "lblNombre"
            Me.lblNombre.Size = New System.Drawing.Size(53, 15)
            Me.lblNombre.TabIndex = 204
            Me.lblNombre.Text = "Nombre"
            '
            'lblApellido1
            '
            Me.lblApellido1.AutoSize = True
            Me.lblApellido1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblApellido1.Location = New System.Drawing.Point(6, 111)
            Me.lblApellido1.Name = "lblApellido1"
            Me.lblApellido1.Size = New System.Drawing.Size(93, 15)
            Me.lblApellido1.TabIndex = 203
            Me.lblApellido1.Text = "Primer Apellido"
            '
            'btnGuardar
            '
            Me.btnGuardar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = Global.Presentacion.My.Resources.Resources.Guardar
            Me.btnGuardar.Location = New System.Drawing.Point(64, 0)
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(65, 57)
            Me.btnGuardar.TabIndex = 219
            Me.btnGuardar.Text = "Guardar"
            Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnGuardar.UseVisualStyleBackColor = True
            '
            'btnLimpiar
            '
            Me.btnLimpiar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnLimpiar.Image = Global.Presentacion.My.Resources.Resources.Limpiar
            Me.btnLimpiar.Location = New System.Drawing.Point(0, 0)
            Me.btnLimpiar.Name = "btnLimpiar"
            Me.btnLimpiar.Size = New System.Drawing.Size(65, 57)
            Me.btnLimpiar.TabIndex = 218
            Me.btnLimpiar.Text = "Limpiar"
            Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnLimpiar.UseVisualStyleBackColor = True
            '
            'lblId_Persona
            '
            Me.lblId_Persona.AutoSize = True
            Me.lblId_Persona.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblId_Persona.Location = New System.Drawing.Point(4, 70)
            Me.lblId_Persona.Name = "lblId_Persona"
            Me.lblId_Persona.Size = New System.Drawing.Size(49, 15)
            Me.lblId_Persona.TabIndex = 201
            Me.lblId_Persona.Text = "Id_Pers"
            '
            'txtId_Persona
            '
            Me.txtId_Persona.Location = New System.Drawing.Point(7, 88)
            Me.txtId_Persona.MaxLength = 5
            Me.txtId_Persona.Name = "txtId_Persona"
            Me.txtId_Persona.Size = New System.Drawing.Size(45, 20)
            Me.txtId_Persona.TabIndex = 200
            '
            'lblRol
            '
            Me.lblRol.AutoSize = True
            Me.lblRol.Location = New System.Drawing.Point(305, 155)
            Me.lblRol.Name = "lblRol"
            Me.lblRol.Size = New System.Drawing.Size(23, 13)
            Me.lblRol.TabIndex = 231
            Me.lblRol.Text = "Rol"
            '
            'txtRol
            '
            Me.txtRol.Location = New System.Drawing.Point(304, 171)
            Me.txtRol.MaxLength = 15
            Me.txtRol.Name = "txtRol"
            Me.txtRol.Size = New System.Drawing.Size(182, 20)
            Me.txtRol.TabIndex = 232
            '
            'errorEmpleados
            '
            Me.errorEmpleados.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
            Me.errorEmpleados.ContainerControl = Me
            '
            'txtId_Empleado
            '
            Me.txtId_Empleado.Location = New System.Drawing.Point(64, 88)
            Me.txtId_Empleado.MaxLength = 5
            Me.txtId_Empleado.Name = "txtId_Empleado"
            Me.txtId_Empleado.Size = New System.Drawing.Size(45, 20)
            Me.txtId_Empleado.TabIndex = 233
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(55, 70)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(80, 15)
            Me.Label1.TabIndex = 234
            Me.Label1.Text = "Id_Empleado"
            '
            'txtOtroTelefono
            '
            Me.txtOtroTelefono.Location = New System.Drawing.Point(113, 171)
            Me.txtOtroTelefono.MaxLength = 9
            Me.txtOtroTelefono.Name = "txtOtroTelefono"
            Me.txtOtroTelefono.Size = New System.Drawing.Size(90, 20)
            Me.txtOtroTelefono.TabIndex = 251
            Me.txtOtroTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblOtroTelefono
            '
            Me.lblOtroTelefono.AutoSize = True
            Me.lblOtroTelefono.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblOtroTelefono.Location = New System.Drawing.Point(112, 155)
            Me.lblOtroTelefono.Name = "lblOtroTelefono"
            Me.lblOtroTelefono.Size = New System.Drawing.Size(84, 15)
            Me.lblOtroTelefono.TabIndex = 250
            Me.lblOtroTelefono.Text = "Otro Teléfono"
            '
            'txtFax
            '
            Me.txtFax.Location = New System.Drawing.Point(209, 171)
            Me.txtFax.MaxLength = 9
            Me.txtFax.Name = "txtFax"
            Me.txtFax.Size = New System.Drawing.Size(90, 20)
            Me.txtFax.TabIndex = 249
            Me.txtFax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblFax
            '
            Me.lblFax.AutoSize = True
            Me.lblFax.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFax.Location = New System.Drawing.Point(207, 155)
            Me.lblFax.Name = "lblFax"
            Me.lblFax.Size = New System.Drawing.Size(76, 15)
            Me.lblFax.TabIndex = 248
            Me.lblFax.Text = "Fax Principal"
            '
            'txtTelefono
            '
            Me.txtTelefono.Location = New System.Drawing.Point(7, 171)
            Me.txtTelefono.MaxLength = 9
            Me.txtTelefono.Name = "txtTelefono"
            Me.txtTelefono.Size = New System.Drawing.Size(90, 20)
            Me.txtTelefono.TabIndex = 247
            Me.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblTelefono
            '
            Me.lblTelefono.AutoSize = True
            Me.lblTelefono.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTelefono.Location = New System.Drawing.Point(5, 155)
            Me.lblTelefono.Name = "lblTelefono"
            Me.lblTelefono.Size = New System.Drawing.Size(100, 14)
            Me.lblTelefono.TabIndex = 246
            Me.lblTelefono.Text = "Teléfono Principal"
            '
            'txtSitioWeb
            '
            Me.txtSitioWeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSitioWeb.Location = New System.Drawing.Point(240, 209)
            Me.txtSitioWeb.MaxLength = 45
            Me.txtSitioWeb.Name = "txtSitioWeb"
            Me.txtSitioWeb.Size = New System.Drawing.Size(248, 20)
            Me.txtSitioWeb.TabIndex = 255
            '
            'lblSitio
            '
            Me.lblSitio.AutoSize = True
            Me.lblSitio.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSitio.Location = New System.Drawing.Point(239, 191)
            Me.lblSitio.Name = "lblSitio"
            Me.lblSitio.Size = New System.Drawing.Size(61, 15)
            Me.lblSitio.TabIndex = 254
            Me.lblSitio.Text = "Sitio Web"
            '
            'txtEmail
            '
            Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtEmail.Location = New System.Drawing.Point(8, 209)
            Me.txtEmail.MaxLength = 45
            Me.txtEmail.Name = "txtEmail"
            Me.txtEmail.Size = New System.Drawing.Size(226, 20)
            Me.txtEmail.TabIndex = 253
            '
            'lblEmail
            '
            Me.lblEmail.AutoSize = True
            Me.lblEmail.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEmail.Location = New System.Drawing.Point(7, 191)
            Me.lblEmail.Name = "lblEmail"
            Me.lblEmail.Size = New System.Drawing.Size(37, 15)
            Me.lblEmail.TabIndex = 252
            Me.lblEmail.Text = "Email"
            '
            'FrmEmpleadoOtros
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(496, 332)
            Me.Controls.Add(Me.dgvClientes)
            Me.Controls.Add(Me.txtSitioWeb)
            Me.Controls.Add(Me.lblSitio)
            Me.Controls.Add(Me.txtEmail)
            Me.Controls.Add(Me.lblEmail)
            Me.Controls.Add(Me.txtOtroTelefono)
            Me.Controls.Add(Me.lblOtroTelefono)
            Me.Controls.Add(Me.txtFax)
            Me.Controls.Add(Me.lblFax)
            Me.Controls.Add(Me.txtTelefono)
            Me.Controls.Add(Me.lblTelefono)
            Me.Controls.Add(Me.txtId_Empleado)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.txtObservaciones)
            Me.Controls.Add(Me.lblObserv)
            Me.Controls.Add(Me.txtDireccion)
            Me.Controls.Add(Me.lblDireccion)
            Me.Controls.Add(Me.txtCedula)
            Me.Controls.Add(Me.lblCedula)
            Me.Controls.Add(Me.btnCorregir)
            Me.Controls.Add(Me.btnGuardar)
            Me.Controls.Add(Me.btnLimpiar)
            Me.Controls.Add(Me.txtApellido2)
            Me.Controls.Add(Me.txtApellido1)
            Me.Controls.Add(Me.txtNombre)
            Me.Controls.Add(Me.txtId_Persona)
            Me.Controls.Add(Me.lblApellido2)
            Me.Controls.Add(Me.lblNombre)
            Me.Controls.Add(Me.lblApellido1)
            Me.Controls.Add(Me.lblId_Persona)
            Me.Controls.Add(Me.txtRol)
            Me.Controls.Add(Me.lblRol)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmEmpleadoOtros"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Empleados Y Otros"
            CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.errorEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvClientes As System.Windows.Forms.DataGridView
        Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
        Friend WithEvents lblObserv As System.Windows.Forms.Label
        Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
        Friend WithEvents lblDireccion As System.Windows.Forms.Label
        Friend WithEvents txtCedula As System.Windows.Forms.TextBox
        Friend WithEvents lblCedula As System.Windows.Forms.Label
        Friend WithEvents btnCorregir As System.Windows.Forms.Button
        Friend WithEvents btnGuardar As System.Windows.Forms.Button
        Friend WithEvents btnLimpiar As System.Windows.Forms.Button
        Friend WithEvents txtApellido2 As System.Windows.Forms.TextBox
        Friend WithEvents txtApellido1 As System.Windows.Forms.TextBox
        Friend WithEvents txtNombre As System.Windows.Forms.TextBox
        Friend WithEvents lblApellido2 As System.Windows.Forms.Label
        Friend WithEvents lblNombre As System.Windows.Forms.Label
        Friend WithEvents lblApellido1 As System.Windows.Forms.Label
        Friend WithEvents lblId_Persona As System.Windows.Forms.Label
        Friend WithEvents txtId_Persona As System.Windows.Forms.TextBox
        Friend WithEvents lblRol As System.Windows.Forms.Label
        Friend WithEvents txtRol As System.Windows.Forms.TextBox
        Friend WithEvents errorEmpleados As System.Windows.Forms.ErrorProvider
        Friend WithEvents txtId_Empleado As System.Windows.Forms.TextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtOtroTelefono As System.Windows.Forms.TextBox
        Friend WithEvents lblOtroTelefono As System.Windows.Forms.Label
        Friend WithEvents txtFax As System.Windows.Forms.TextBox
        Friend WithEvents lblFax As System.Windows.Forms.Label
        Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
        Friend WithEvents lblTelefono As System.Windows.Forms.Label
        Friend WithEvents txtSitioWeb As System.Windows.Forms.TextBox
        Friend WithEvents lblSitio As System.Windows.Forms.Label
        Friend WithEvents txtEmail As System.Windows.Forms.TextBox
        Friend WithEvents lblEmail As System.Windows.Forms.Label
    End Class
End Namespace