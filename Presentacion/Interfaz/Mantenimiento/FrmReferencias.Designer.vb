Namespace Interfaz.Mantenimiento
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmReferencias
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
            Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.btnInactivar = New System.Windows.Forms.Button()
            Me.lblIdRef = New System.Windows.Forms.Label()
            Me.lblNombre = New System.Windows.Forms.Label()
            Me.lblApellidos = New System.Windows.Forms.Label()
            Me.txtIdRef = New System.Windows.Forms.TextBox()
            Me.txtId = New System.Windows.Forms.TextBox()
            Me.txtNombre = New System.Windows.Forms.TextBox()
            Me.txtApellidos = New System.Windows.Forms.TextBox()
            Me.txtDireccion = New System.Windows.Forms.TextBox()
            Me.lblDireccion = New System.Windows.Forms.Label()
            Me.dgvReferencias = New System.Windows.Forms.DataGridView()
            Me.btnActivar = New System.Windows.Forms.Button()
            Me.lblInactivos = New System.Windows.Forms.Label()
            Me.dgvReferenciasInactivas = New System.Windows.Forms.DataGridView()
            Me.dgvPersonas = New System.Windows.Forms.DataGridView()
            Me.errorReferencias = New System.Windows.Forms.ErrorProvider(Me.components)
            Me.btnCalcularRef = New System.Windows.Forms.Button()
            Me.txtCedula = New System.Windows.Forms.TextBox()
            Me.lblCedula = New System.Windows.Forms.Label()
            Me.btnGuardar = New System.Windows.Forms.Button()
            Me.btnTrasladar = New System.Windows.Forms.Button()
            Me.btnLimpiar = New System.Windows.Forms.Button()
            Me.lblUltimoCalculo = New System.Windows.Forms.Label()
            Me.lblFechaCalculo = New System.Windows.Forms.Label()
            Me.txtOtroTelefono = New System.Windows.Forms.TextBox()
            Me.lblOtroTelefono = New System.Windows.Forms.Label()
            Me.txtFax = New System.Windows.Forms.TextBox()
            Me.lblFax = New System.Windows.Forms.Label()
            Me.txtTelefono = New System.Windows.Forms.TextBox()
            Me.lblTelefono = New System.Windows.Forms.Label()
            Me.lblEmail = New System.Windows.Forms.Label()
            Me.txtEmail = New System.Windows.Forms.TextBox()
            CType(Me.dgvReferencias, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvReferenciasInactivas, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvPersonas, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.errorReferencias, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'btnInactivar
            '
            Me.btnInactivar.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnInactivar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnInactivar.Location = New System.Drawing.Point(43, 432)
            Me.btnInactivar.Name = "btnInactivar"
            Me.btnInactivar.Size = New System.Drawing.Size(83, 23)
            Me.btnInactivar.TabIndex = 25
            Me.btnInactivar.Text = "Inactivar"
            Me.btnInactivar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnInactivar.UseVisualStyleBackColor = True
            '
            'lblIdRef
            '
            Me.lblIdRef.AutoSize = True
            Me.lblIdRef.BackColor = System.Drawing.Color.Transparent
            Me.lblIdRef.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblIdRef.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdRef.Location = New System.Drawing.Point(0, 74)
            Me.lblIdRef.Name = "lblIdRef"
            Me.lblIdRef.Size = New System.Drawing.Size(37, 15)
            Me.lblIdRef.TabIndex = 26
            Me.lblIdRef.Text = "IdRef"
            '
            'lblNombre
            '
            Me.lblNombre.AutoSize = True
            Me.lblNombre.BackColor = System.Drawing.Color.Transparent
            Me.lblNombre.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblNombre.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombre.Location = New System.Drawing.Point(52, 74)
            Me.lblNombre.Name = "lblNombre"
            Me.lblNombre.Size = New System.Drawing.Size(53, 15)
            Me.lblNombre.TabIndex = 28
            Me.lblNombre.Text = "Nombre"
            '
            'lblApellidos
            '
            Me.lblApellidos.AutoSize = True
            Me.lblApellidos.BackColor = System.Drawing.Color.Transparent
            Me.lblApellidos.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblApellidos.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblApellidos.Location = New System.Drawing.Point(297, 74)
            Me.lblApellidos.Name = "lblApellidos"
            Me.lblApellidos.Size = New System.Drawing.Size(57, 15)
            Me.lblApellidos.TabIndex = 29
            Me.lblApellidos.Text = "Apellidos"
            '
            'txtIdRef
            '
            Me.txtIdRef.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtIdRef.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdRef.Location = New System.Drawing.Point(3, 92)
            Me.txtIdRef.Name = "txtIdRef"
            Me.txtIdRef.ReadOnly = True
            Me.txtIdRef.Size = New System.Drawing.Size(48, 20)
            Me.txtIdRef.TabIndex = 30
            '
            'txtId
            '
            Me.txtId.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtId.Location = New System.Drawing.Point(508, 247)
            Me.txtId.Name = "txtId"
            Me.txtId.ReadOnly = True
            Me.txtId.Size = New System.Drawing.Size(48, 20)
            Me.txtId.TabIndex = 31
            '
            'txtNombre
            '
            Me.txtNombre.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombre.Location = New System.Drawing.Point(53, 92)
            Me.txtNombre.Name = "txtNombre"
            Me.txtNombre.Size = New System.Drawing.Size(242, 20)
            Me.txtNombre.TabIndex = 0
            '
            'txtApellidos
            '
            Me.txtApellidos.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtApellidos.Location = New System.Drawing.Point(297, 92)
            Me.txtApellidos.Name = "txtApellidos"
            Me.txtApellidos.Size = New System.Drawing.Size(161, 20)
            Me.txtApellidos.TabIndex = 1
            '
            'txtDireccion
            '
            Me.txtDireccion.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDireccion.Location = New System.Drawing.Point(5, 141)
            Me.txtDireccion.MaxLength = 100
            Me.txtDireccion.Name = "txtDireccion"
            Me.txtDireccion.Size = New System.Drawing.Size(574, 20)
            Me.txtDireccion.TabIndex = 4
            '
            'lblDireccion
            '
            Me.lblDireccion.AutoSize = True
            Me.lblDireccion.BackColor = System.Drawing.Color.Transparent
            Me.lblDireccion.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblDireccion.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDireccion.Location = New System.Drawing.Point(5, 123)
            Me.lblDireccion.Name = "lblDireccion"
            Me.lblDireccion.Size = New System.Drawing.Size(59, 15)
            Me.lblDireccion.TabIndex = 39
            Me.lblDireccion.Text = "Dirección"
            '
            'dgvReferencias
            '
            Me.dgvReferencias.AllowUserToAddRows = False
            Me.dgvReferencias.AllowUserToDeleteRows = False
            Me.dgvReferencias.AllowUserToResizeColumns = False
            Me.dgvReferencias.AllowUserToResizeRows = False
            DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvReferencias.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
            Me.dgvReferencias.BackgroundColor = System.Drawing.Color.White
            Me.dgvReferencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvReferencias.Cursor = System.Windows.Forms.Cursors.Hand
            Me.dgvReferencias.GridColor = System.Drawing.Color.White
            Me.dgvReferencias.Location = New System.Drawing.Point(5, 219)
            Me.dgvReferencias.MultiSelect = False
            Me.dgvReferencias.Name = "dgvReferencias"
            Me.dgvReferencias.ReadOnly = True
            Me.dgvReferencias.RowHeadersVisible = False
            DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvReferencias.RowsDefaultCellStyle = DataGridViewCellStyle12
            Me.dgvReferencias.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvReferencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvReferencias.Size = New System.Drawing.Size(576, 210)
            Me.dgvReferencias.TabIndex = 40
            '
            'btnActivar
            '
            Me.btnActivar.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnActivar.Location = New System.Drawing.Point(464, 432)
            Me.btnActivar.Name = "btnActivar"
            Me.btnActivar.Size = New System.Drawing.Size(75, 23)
            Me.btnActivar.TabIndex = 41
            Me.btnActivar.Text = "Activar"
            Me.btnActivar.UseVisualStyleBackColor = True
            '
            'lblInactivos
            '
            Me.lblInactivos.AutoSize = True
            Me.lblInactivos.BackColor = System.Drawing.Color.Transparent
            Me.lblInactivos.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblInactivos.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblInactivos.Location = New System.Drawing.Point(193, 432)
            Me.lblInactivos.Name = "lblInactivos"
            Me.lblInactivos.Size = New System.Drawing.Size(179, 23)
            Me.lblInactivos.TabIndex = 42
            Me.lblInactivos.Text = "Referencias Inactivas"
            '
            'dgvReferenciasInactivas
            '
            Me.dgvReferenciasInactivas.AllowUserToAddRows = False
            Me.dgvReferenciasInactivas.AllowUserToDeleteRows = False
            Me.dgvReferenciasInactivas.AllowUserToResizeColumns = False
            Me.dgvReferenciasInactivas.AllowUserToResizeRows = False
            DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvReferenciasInactivas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
            Me.dgvReferenciasInactivas.BackgroundColor = System.Drawing.Color.White
            Me.dgvReferenciasInactivas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvReferenciasInactivas.Cursor = System.Windows.Forms.Cursors.Hand
            Me.dgvReferenciasInactivas.GridColor = System.Drawing.Color.White
            Me.dgvReferenciasInactivas.Location = New System.Drawing.Point(5, 461)
            Me.dgvReferenciasInactivas.MultiSelect = False
            Me.dgvReferenciasInactivas.Name = "dgvReferenciasInactivas"
            Me.dgvReferenciasInactivas.ReadOnly = True
            Me.dgvReferenciasInactivas.RowHeadersVisible = False
            DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvReferenciasInactivas.RowsDefaultCellStyle = DataGridViewCellStyle14
            Me.dgvReferenciasInactivas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvReferenciasInactivas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvReferenciasInactivas.Size = New System.Drawing.Size(576, 102)
            Me.dgvReferenciasInactivas.TabIndex = 43
            '
            'dgvPersonas
            '
            Me.dgvPersonas.AllowUserToAddRows = False
            Me.dgvPersonas.AllowUserToDeleteRows = False
            Me.dgvPersonas.AllowUserToResizeColumns = False
            Me.dgvPersonas.AllowUserToResizeRows = False
            DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvPersonas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle15
            Me.dgvPersonas.BackgroundColor = System.Drawing.Color.White
            Me.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvPersonas.GridColor = System.Drawing.Color.White
            Me.dgvPersonas.Location = New System.Drawing.Point(53, 112)
            Me.dgvPersonas.MultiSelect = False
            Me.dgvPersonas.Name = "dgvPersonas"
            Me.dgvPersonas.ReadOnly = True
            Me.dgvPersonas.RowHeadersVisible = False
            Me.dgvPersonas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvPersonas.Size = New System.Drawing.Size(315, 114)
            Me.dgvPersonas.TabIndex = 44
            Me.dgvPersonas.Visible = False
            '
            'errorReferencias
            '
            Me.errorReferencias.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
            Me.errorReferencias.ContainerControl = Me
            '
            'btnCalcularRef
            '
            Me.btnCalcularRef.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnCalcularRef.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.errorReferencias.SetIconAlignment(Me.btnCalcularRef, System.Windows.Forms.ErrorIconAlignment.TopRight)
            Me.btnCalcularRef.Image = Global.Presentacion.My.Resources.Resources.Modificar
            Me.btnCalcularRef.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnCalcularRef.Location = New System.Drawing.Point(138, 0)
            Me.btnCalcularRef.Name = "btnCalcularRef"
            Me.btnCalcularRef.Size = New System.Drawing.Size(80, 65)
            Me.btnCalcularRef.TabIndex = 51
            Me.btnCalcularRef.Text = "Calcular Referencia"
            Me.btnCalcularRef.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnCalcularRef.UseVisualStyleBackColor = True
            '
            'txtCedula
            '
            Me.txtCedula.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCedula.Location = New System.Drawing.Point(460, 92)
            Me.txtCedula.MaxLength = 9
            Me.txtCedula.Name = "txtCedula"
            Me.txtCedula.Size = New System.Drawing.Size(119, 20)
            Me.txtCedula.TabIndex = 2
            '
            'lblCedula
            '
            Me.lblCedula.AutoSize = True
            Me.lblCedula.BackColor = System.Drawing.Color.Transparent
            Me.lblCedula.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblCedula.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCedula.Location = New System.Drawing.Point(461, 74)
            Me.lblCedula.Name = "lblCedula"
            Me.lblCedula.Size = New System.Drawing.Size(44, 15)
            Me.lblCedula.TabIndex = 46
            Me.lblCedula.Text = "Cédula"
            '
            'btnGuardar
            '
            Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnGuardar.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = Global.Presentacion.My.Resources.Resources.Guardar
            Me.btnGuardar.Location = New System.Drawing.Point(0, 0)
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(70, 65)
            Me.btnGuardar.TabIndex = 5
            Me.btnGuardar.Text = "Guardar"
            Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnGuardar.UseVisualStyleBackColor = True
            '
            'btnTrasladar
            '
            Me.btnTrasladar.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnTrasladar.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnTrasladar.Image = Global.Presentacion.My.Resources.Resources.Copiar
            Me.btnTrasladar.Location = New System.Drawing.Point(69, 0)
            Me.btnTrasladar.Name = "btnTrasladar"
            Me.btnTrasladar.Size = New System.Drawing.Size(70, 65)
            Me.btnTrasladar.TabIndex = 23
            Me.btnTrasladar.Text = "Trasladar"
            Me.btnTrasladar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnTrasladar.UseVisualStyleBackColor = True
            '
            'btnLimpiar
            '
            Me.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnLimpiar.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnLimpiar.Image = Global.Presentacion.My.Resources.Resources.Limpiar
            Me.btnLimpiar.Location = New System.Drawing.Point(217, 0)
            Me.btnLimpiar.Name = "btnLimpiar"
            Me.btnLimpiar.Size = New System.Drawing.Size(70, 65)
            Me.btnLimpiar.TabIndex = 21
            Me.btnLimpiar.Text = "Limpiar"
            Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnLimpiar.UseVisualStyleBackColor = True
            '
            'lblUltimoCalculo
            '
            Me.lblUltimoCalculo.AutoSize = True
            Me.lblUltimoCalculo.BackColor = System.Drawing.Color.Transparent
            Me.lblUltimoCalculo.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblUltimoCalculo.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblUltimoCalculo.Location = New System.Drawing.Point(420, 18)
            Me.lblUltimoCalculo.Name = "lblUltimoCalculo"
            Me.lblUltimoCalculo.Size = New System.Drawing.Size(119, 15)
            Me.lblUltimoCalculo.TabIndex = 52
            Me.lblUltimoCalculo.Text = "Ult Cálculo Comisión"
            '
            'lblFechaCalculo
            '
            Me.lblFechaCalculo.AutoSize = True
            Me.lblFechaCalculo.Location = New System.Drawing.Point(451, 37)
            Me.lblFechaCalculo.Name = "lblFechaCalculo"
            Me.lblFechaCalculo.Size = New System.Drawing.Size(10, 15)
            Me.lblFechaCalculo.TabIndex = 53
            Me.lblFechaCalculo.Text = "-"
            '
            'txtOtroTelefono
            '
            Me.txtOtroTelefono.Location = New System.Drawing.Point(111, 185)
            Me.txtOtroTelefono.MaxLength = 9
            Me.txtOtroTelefono.Name = "txtOtroTelefono"
            Me.txtOtroTelefono.Size = New System.Drawing.Size(90, 23)
            Me.txtOtroTelefono.TabIndex = 245
            Me.txtOtroTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblOtroTelefono
            '
            Me.lblOtroTelefono.AutoSize = True
            Me.lblOtroTelefono.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblOtroTelefono.Location = New System.Drawing.Point(110, 169)
            Me.lblOtroTelefono.Name = "lblOtroTelefono"
            Me.lblOtroTelefono.Size = New System.Drawing.Size(84, 15)
            Me.lblOtroTelefono.TabIndex = 244
            Me.lblOtroTelefono.Text = "Otro Teléfono"
            '
            'txtFax
            '
            Me.txtFax.Location = New System.Drawing.Point(217, 185)
            Me.txtFax.MaxLength = 9
            Me.txtFax.Name = "txtFax"
            Me.txtFax.Size = New System.Drawing.Size(90, 23)
            Me.txtFax.TabIndex = 243
            Me.txtFax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblFax
            '
            Me.lblFax.AutoSize = True
            Me.lblFax.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFax.Location = New System.Drawing.Point(215, 169)
            Me.lblFax.Name = "lblFax"
            Me.lblFax.Size = New System.Drawing.Size(76, 15)
            Me.lblFax.TabIndex = 242
            Me.lblFax.Text = "Fax Principal"
            '
            'txtTelefono
            '
            Me.txtTelefono.Location = New System.Drawing.Point(6, 185)
            Me.txtTelefono.MaxLength = 9
            Me.txtTelefono.Name = "txtTelefono"
            Me.txtTelefono.Size = New System.Drawing.Size(90, 23)
            Me.txtTelefono.TabIndex = 241
            Me.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblTelefono
            '
            Me.lblTelefono.AutoSize = True
            Me.lblTelefono.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTelefono.Location = New System.Drawing.Point(4, 169)
            Me.lblTelefono.Name = "lblTelefono"
            Me.lblTelefono.Size = New System.Drawing.Size(100, 14)
            Me.lblTelefono.TabIndex = 240
            Me.lblTelefono.Text = "Teléfono Principal"
            '
            'lblEmail
            '
            Me.lblEmail.AutoSize = True
            Me.lblEmail.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEmail.Location = New System.Drawing.Point(321, 167)
            Me.lblEmail.Name = "lblEmail"
            Me.lblEmail.Size = New System.Drawing.Size(37, 15)
            Me.lblEmail.TabIndex = 247
            Me.lblEmail.Text = "Email"
            '
            'txtEmail
            '
            Me.txtEmail.Location = New System.Drawing.Point(323, 185)
            Me.txtEmail.MaxLength = 45
            Me.txtEmail.Name = "txtEmail"
            Me.txtEmail.Size = New System.Drawing.Size(256, 23)
            Me.txtEmail.TabIndex = 246
            '
            'FrmReferencias
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.ClientSize = New System.Drawing.Size(589, 568)
            Me.Controls.Add(Me.dgvPersonas)
            Me.Controls.Add(Me.lblEmail)
            Me.Controls.Add(Me.txtEmail)
            Me.Controls.Add(Me.txtOtroTelefono)
            Me.Controls.Add(Me.lblOtroTelefono)
            Me.Controls.Add(Me.txtFax)
            Me.Controls.Add(Me.lblFax)
            Me.Controls.Add(Me.txtTelefono)
            Me.Controls.Add(Me.lblTelefono)
            Me.Controls.Add(Me.lblFechaCalculo)
            Me.Controls.Add(Me.lblUltimoCalculo)
            Me.Controls.Add(Me.btnCalcularRef)
            Me.Controls.Add(Me.txtCedula)
            Me.Controls.Add(Me.lblCedula)
            Me.Controls.Add(Me.dgvReferenciasInactivas)
            Me.Controls.Add(Me.lblInactivos)
            Me.Controls.Add(Me.btnActivar)
            Me.Controls.Add(Me.dgvReferencias)
            Me.Controls.Add(Me.lblDireccion)
            Me.Controls.Add(Me.txtDireccion)
            Me.Controls.Add(Me.txtApellidos)
            Me.Controls.Add(Me.txtNombre)
            Me.Controls.Add(Me.txtId)
            Me.Controls.Add(Me.txtIdRef)
            Me.Controls.Add(Me.lblApellidos)
            Me.Controls.Add(Me.lblNombre)
            Me.Controls.Add(Me.lblIdRef)
            Me.Controls.Add(Me.btnInactivar)
            Me.Controls.Add(Me.btnGuardar)
            Me.Controls.Add(Me.btnTrasladar)
            Me.Controls.Add(Me.btnLimpiar)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmReferencias"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "FrmReferencias"
            CType(Me.dgvReferencias, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvReferenciasInactivas, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvPersonas, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.errorReferencias, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents btnGuardar As System.Windows.Forms.Button
        Friend WithEvents btnTrasladar As System.Windows.Forms.Button
        Friend WithEvents btnLimpiar As System.Windows.Forms.Button
        Friend WithEvents btnInactivar As System.Windows.Forms.Button
        Friend WithEvents lblIdRef As System.Windows.Forms.Label
        Friend WithEvents lblNombre As System.Windows.Forms.Label
        Friend WithEvents lblApellidos As System.Windows.Forms.Label
        Friend WithEvents txtIdRef As System.Windows.Forms.TextBox
        Friend WithEvents txtId As System.Windows.Forms.TextBox
        Friend WithEvents txtNombre As System.Windows.Forms.TextBox
        Friend WithEvents txtApellidos As System.Windows.Forms.TextBox
        Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
        Friend WithEvents lblDireccion As System.Windows.Forms.Label
        Friend WithEvents dgvReferencias As System.Windows.Forms.DataGridView
        Friend WithEvents btnActivar As System.Windows.Forms.Button
        Friend WithEvents lblInactivos As System.Windows.Forms.Label
        Friend WithEvents dgvReferenciasInactivas As System.Windows.Forms.DataGridView
        Friend WithEvents dgvPersonas As System.Windows.Forms.DataGridView
        Friend WithEvents errorReferencias As System.Windows.Forms.ErrorProvider
        Friend WithEvents txtCedula As System.Windows.Forms.TextBox
        Friend WithEvents lblCedula As System.Windows.Forms.Label
        Friend WithEvents btnCalcularRef As System.Windows.Forms.Button
        Friend WithEvents lblFechaCalculo As System.Windows.Forms.Label
        Friend WithEvents lblUltimoCalculo As System.Windows.Forms.Label
        Friend WithEvents txtOtroTelefono As System.Windows.Forms.TextBox
        Friend WithEvents lblOtroTelefono As System.Windows.Forms.Label
        Friend WithEvents txtFax As System.Windows.Forms.TextBox
        Friend WithEvents lblFax As System.Windows.Forms.Label
        Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
        Friend WithEvents lblTelefono As System.Windows.Forms.Label
        Friend WithEvents lblEmail As System.Windows.Forms.Label
        Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    End Class
End Namespace