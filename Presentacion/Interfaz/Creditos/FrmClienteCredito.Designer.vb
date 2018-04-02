Namespace Interfaz.Creditos
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmClienteCredito
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
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.lblId_Credito = New System.Windows.Forms.Label()
            Me.lblId_Cliente = New System.Windows.Forms.Label()
            Me.lblApellido1 = New System.Windows.Forms.Label()
            Me.lblNombre = New System.Windows.Forms.Label()
            Me.lblApellido2 = New System.Windows.Forms.Label()
            Me.txtId_Credito = New System.Windows.Forms.TextBox()
            Me.txtId_Cliente = New System.Windows.Forms.TextBox()
            Me.txtNombre = New System.Windows.Forms.TextBox()
            Me.txtApellido1 = New System.Windows.Forms.TextBox()
            Me.txtApellido2 = New System.Windows.Forms.TextBox()
            Me.btnCorregir = New System.Windows.Forms.Button()
            Me.txtCedula = New System.Windows.Forms.TextBox()
            Me.txtDireccion = New System.Windows.Forms.TextBox()
            Me.lblDireccion = New System.Windows.Forms.Label()
            Me.txtLimite = New System.Windows.Forms.TextBox()
            Me.lblLimite = New System.Windows.Forms.Label()
            Me.rbPrueba = New System.Windows.Forms.RadioButton()
            Me.rbNormal = New System.Windows.Forms.RadioButton()
            Me.rbPreferencial = New System.Windows.Forms.RadioButton()
            Me.txtObservaciones = New System.Windows.Forms.TextBox()
            Me.lblObserv = New System.Windows.Forms.Label()
            Me.dgvClientes = New System.Windows.Forms.DataGridView()
            Me.errorCredito = New System.Windows.Forms.ErrorProvider(Me.components)
            Me.gbBitacora = New System.Windows.Forms.GroupBox()
            Me.dgvCreacion = New System.Windows.Forms.DataGridView()
            Me.Creacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvBitacora = New System.Windows.Forms.DataGridView()
            Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.txtNuevo = New System.Windows.Forms.TextBox()
            Me.lblNuevo = New System.Windows.Forms.Label()
            Me.MnEliminarBitacora = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.txtTotal_Creditos = New System.Windows.Forms.TextBox()
            Me.lblTotal_Creditos = New System.Windows.Forms.Label()
            Me.rbJuridico = New System.Windows.Forms.RadioButton()
            Me.rbFisico = New System.Windows.Forms.RadioButton()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblMostrarEstado = New System.Windows.Forms.Label()
            Me.lblDias_Atraso = New System.Windows.Forms.Label()
            Me.txtDias_Atraso = New System.Windows.Forms.TextBox()
            Me.txtTotal_Atrasado = New System.Windows.Forms.TextBox()
            Me.txtNombreReal = New System.Windows.Forms.TextBox()
            Me.lblNombreReal = New System.Windows.Forms.Label()
            Me.lblCedula = New System.Windows.Forms.Label()
            Me.lblSitioWeb = New System.Windows.Forms.Label()
            Me.txtSitioWeb = New System.Windows.Forms.TextBox()
            Me.gbTipo_Cedula = New System.Windows.Forms.GroupBox()
            Me.gbTipo_Credito = New System.Windows.Forms.GroupBox()
            Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
            Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.btnCerrarCredito = New System.Windows.Forms.Button()
            Me.btnCongelar = New System.Windows.Forms.Button()
            Me.btnReactivar = New System.Windows.Forms.Button()
            Me.btnInformacionPersonal = New System.Windows.Forms.Button()
            Me.lblTelefono = New System.Windows.Forms.Label()
            Me.btnGuardar = New System.Windows.Forms.Button()
            Me.btnLimpiar = New System.Windows.Forms.Button()
            Me.btnEliminar = New System.Windows.Forms.Button()
            Me.txtTelefono = New System.Windows.Forms.TextBox()
            Me.txtFax = New System.Windows.Forms.TextBox()
            Me.lblFax = New System.Windows.Forms.Label()
            Me.lblEmail = New System.Windows.Forms.Label()
            Me.txtEmail = New System.Windows.Forms.TextBox()
            Me.txtOtroTelefono = New System.Windows.Forms.TextBox()
            Me.lblOtroTelefono = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.chkIncluirEnCobro = New System.Windows.Forms.CheckBox()
            Me.btnDesbloquear = New System.Windows.Forms.Button()
            CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.errorCredito, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbBitacora.SuspendLayout()
            CType(Me.dgvCreacion, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvBitacora, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MnEliminarBitacora.SuspendLayout()
            Me.gbTipo_Cedula.SuspendLayout()
            Me.gbTipo_Credito.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'lblId_Credito
            '
            Me.lblId_Credito.AutoSize = True
            Me.lblId_Credito.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblId_Credito.Location = New System.Drawing.Point(15, 187)
            Me.lblId_Credito.Name = "lblId_Credito"
            Me.lblId_Credito.Size = New System.Drawing.Size(58, 15)
            Me.lblId_Credito.TabIndex = 0
            Me.lblId_Credito.Text = "# Crédito"
            '
            'lblId_Cliente
            '
            Me.lblId_Cliente.AutoSize = True
            Me.lblId_Cliente.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblId_Cliente.Location = New System.Drawing.Point(74, 187)
            Me.lblId_Cliente.Name = "lblId_Cliente"
            Me.lblId_Cliente.Size = New System.Drawing.Size(56, 15)
            Me.lblId_Cliente.TabIndex = 1
            Me.lblId_Cliente.Text = "# Cliente"
            '
            'lblApellido1
            '
            Me.lblApellido1.AutoSize = True
            Me.lblApellido1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblApellido1.Location = New System.Drawing.Point(15, 105)
            Me.lblApellido1.Name = "lblApellido1"
            Me.lblApellido1.Size = New System.Drawing.Size(93, 15)
            Me.lblApellido1.TabIndex = 2
            Me.lblApellido1.Text = "Primer Apellido"
            '
            'lblNombre
            '
            Me.lblNombre.AutoSize = True
            Me.lblNombre.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombre.Location = New System.Drawing.Point(15, 65)
            Me.lblNombre.Name = "lblNombre"
            Me.lblNombre.Size = New System.Drawing.Size(111, 15)
            Me.lblNombre.TabIndex = 3
            Me.lblNombre.Text = "Nombre Comercial"
            '
            'lblApellido2
            '
            Me.lblApellido2.AutoSize = True
            Me.lblApellido2.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblApellido2.Location = New System.Drawing.Point(136, 105)
            Me.lblApellido2.Name = "lblApellido2"
            Me.lblApellido2.Size = New System.Drawing.Size(104, 15)
            Me.lblApellido2.TabIndex = 4
            Me.lblApellido2.Text = "Segundo Apellido"
            '
            'txtId_Credito
            '
            Me.txtId_Credito.Location = New System.Drawing.Point(15, 205)
            Me.txtId_Credito.MaxLength = 5
            Me.txtId_Credito.Name = "txtId_Credito"
            Me.txtId_Credito.ReadOnly = True
            Me.txtId_Credito.Size = New System.Drawing.Size(45, 20)
            Me.txtId_Credito.TabIndex = 1
            '
            'txtId_Cliente
            '
            Me.txtId_Cliente.Location = New System.Drawing.Point(75, 205)
            Me.txtId_Cliente.MaxLength = 5
            Me.txtId_Cliente.Name = "txtId_Cliente"
            Me.txtId_Cliente.ReadOnly = True
            Me.txtId_Cliente.Size = New System.Drawing.Size(45, 20)
            Me.txtId_Cliente.TabIndex = 1
            '
            'txtNombre
            '
            Me.txtNombre.Location = New System.Drawing.Point(15, 82)
            Me.txtNombre.MaxLength = 60
            Me.txtNombre.Name = "txtNombre"
            Me.txtNombre.Size = New System.Drawing.Size(348, 20)
            Me.txtNombre.TabIndex = 0
            '
            'txtApellido1
            '
            Me.txtApellido1.Location = New System.Drawing.Point(15, 123)
            Me.txtApellido1.MaxLength = 15
            Me.txtApellido1.Name = "txtApellido1"
            Me.txtApellido1.Size = New System.Drawing.Size(115, 20)
            Me.txtApellido1.TabIndex = 3
            '
            'txtApellido2
            '
            Me.txtApellido2.Location = New System.Drawing.Point(136, 123)
            Me.txtApellido2.MaxLength = 15
            Me.txtApellido2.Name = "txtApellido2"
            Me.txtApellido2.Size = New System.Drawing.Size(115, 20)
            Me.txtApellido2.TabIndex = 4
            '
            'btnCorregir
            '
            Me.btnCorregir.Location = New System.Drawing.Point(279, 121)
            Me.btnCorregir.Name = "btnCorregir"
            Me.btnCorregir.Size = New System.Drawing.Size(75, 23)
            Me.btnCorregir.TabIndex = 175
            Me.btnCorregir.Text = "Corregir"
            Me.btnCorregir.UseVisualStyleBackColor = True
            '
            'txtCedula
            '
            Me.txtCedula.Location = New System.Drawing.Point(126, 205)
            Me.txtCedula.MaxLength = 18
            Me.txtCedula.Name = "txtCedula"
            Me.txtCedula.Size = New System.Drawing.Size(100, 20)
            Me.txtCedula.TabIndex = 5
            '
            'txtDireccion
            '
            Me.txtDireccion.Location = New System.Drawing.Point(10, 427)
            Me.txtDireccion.MaxLength = 100
            Me.txtDireccion.Multiline = True
            Me.txtDireccion.Name = "txtDireccion"
            Me.txtDireccion.Size = New System.Drawing.Size(353, 33)
            Me.txtDireccion.TabIndex = 11
            '
            'lblDireccion
            '
            Me.lblDireccion.AutoSize = True
            Me.lblDireccion.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDireccion.Location = New System.Drawing.Point(11, 408)
            Me.lblDireccion.Name = "lblDireccion"
            Me.lblDireccion.Size = New System.Drawing.Size(59, 15)
            Me.lblDireccion.TabIndex = 186
            Me.lblDireccion.Text = "Dirección"
            '
            'txtLimite
            '
            Me.txtLimite.Location = New System.Drawing.Point(10, 388)
            Me.txtLimite.MaxLength = 14
            Me.txtLimite.Name = "txtLimite"
            Me.txtLimite.Size = New System.Drawing.Size(90, 20)
            Me.txtLimite.TabIndex = 10
            Me.txtLimite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblLimite
            '
            Me.lblLimite.AutoSize = True
            Me.lblLimite.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblLimite.Location = New System.Drawing.Point(12, 368)
            Me.lblLimite.Name = "lblLimite"
            Me.lblLimite.Size = New System.Drawing.Size(42, 15)
            Me.lblLimite.TabIndex = 188
            Me.lblLimite.Text = "Límite"
            '
            'rbPrueba
            '
            Me.rbPrueba.AutoSize = True
            Me.rbPrueba.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbPrueba.Location = New System.Drawing.Point(251, 22)
            Me.rbPrueba.Name = "rbPrueba"
            Me.rbPrueba.Size = New System.Drawing.Size(64, 19)
            Me.rbPrueba.TabIndex = 2
            Me.rbPrueba.TabStop = True
            Me.rbPrueba.Text = "Prueba"
            Me.rbPrueba.UseVisualStyleBackColor = True
            '
            'rbNormal
            '
            Me.rbNormal.AutoSize = True
            Me.rbNormal.Checked = True
            Me.rbNormal.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbNormal.Location = New System.Drawing.Point(145, 23)
            Me.rbNormal.Name = "rbNormal"
            Me.rbNormal.Size = New System.Drawing.Size(66, 19)
            Me.rbNormal.TabIndex = 1
            Me.rbNormal.TabStop = True
            Me.rbNormal.Text = "Normal"
            Me.rbNormal.UseVisualStyleBackColor = True
            '
            'rbPreferencial
            '
            Me.rbPreferencial.AutoSize = True
            Me.rbPreferencial.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbPreferencial.Location = New System.Drawing.Point(23, 22)
            Me.rbPreferencial.Name = "rbPreferencial"
            Me.rbPreferencial.Size = New System.Drawing.Size(92, 19)
            Me.rbPreferencial.TabIndex = 0
            Me.rbPreferencial.TabStop = True
            Me.rbPreferencial.Text = "Preferencial"
            Me.rbPreferencial.UseVisualStyleBackColor = True
            '
            'txtObservaciones
            '
            Me.txtObservaciones.Location = New System.Drawing.Point(8, 480)
            Me.txtObservaciones.MaxLength = 180
            Me.txtObservaciones.Multiline = True
            Me.txtObservaciones.Name = "txtObservaciones"
            Me.txtObservaciones.Size = New System.Drawing.Size(355, 47)
            Me.txtObservaciones.TabIndex = 14
            '
            'lblObserv
            '
            Me.lblObserv.AutoSize = True
            Me.lblObserv.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblObserv.Location = New System.Drawing.Point(9, 461)
            Me.lblObserv.Name = "lblObserv"
            Me.lblObserv.Size = New System.Drawing.Size(87, 15)
            Me.lblObserv.TabIndex = 192
            Me.lblObserv.Text = "Observaciones"
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
            Me.dgvClientes.Location = New System.Drawing.Point(15, 103)
            Me.dgvClientes.MultiSelect = False
            Me.dgvClientes.Name = "dgvClientes"
            Me.dgvClientes.ReadOnly = True
            Me.dgvClientes.RowHeadersVisible = False
            Me.dgvClientes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvClientes.Size = New System.Drawing.Size(347, 105)
            Me.dgvClientes.TabIndex = 193
            Me.dgvClientes.Visible = False
            '
            'errorCredito
            '
            Me.errorCredito.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
            Me.errorCredito.ContainerControl = Me
            '
            'gbBitacora
            '
            Me.gbBitacora.Controls.Add(Me.dgvCreacion)
            Me.gbBitacora.Controls.Add(Me.dgvBitacora)
            Me.gbBitacora.Controls.Add(Me.txtNuevo)
            Me.gbBitacora.Controls.Add(Me.lblNuevo)
            Me.gbBitacora.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbBitacora.Location = New System.Drawing.Point(388, 117)
            Me.gbBitacora.Name = "gbBitacora"
            Me.gbBitacora.Size = New System.Drawing.Size(310, 422)
            Me.gbBitacora.TabIndex = 194
            Me.gbBitacora.TabStop = False
            Me.gbBitacora.Text = "Bitácora"
            '
            'dgvCreacion
            '
            Me.dgvCreacion.AllowUserToAddRows = False
            Me.dgvCreacion.AllowUserToDeleteRows = False
            Me.dgvCreacion.AllowUserToResizeColumns = False
            Me.dgvCreacion.AllowUserToResizeRows = False
            Me.dgvCreacion.BackgroundColor = System.Drawing.SystemColors.Control
            Me.dgvCreacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvCreacion.ColumnHeadersVisible = False
            Me.dgvCreacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Creacion})
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvCreacion.DefaultCellStyle = DataGridViewCellStyle1
            Me.dgvCreacion.Enabled = False
            Me.dgvCreacion.GridColor = System.Drawing.SystemColors.Control
            Me.dgvCreacion.Location = New System.Drawing.Point(9, 22)
            Me.dgvCreacion.MultiSelect = False
            Me.dgvCreacion.Name = "dgvCreacion"
            Me.dgvCreacion.ReadOnly = True
            Me.dgvCreacion.RowHeadersVisible = False
            Me.dgvCreacion.RowTemplate.Height = 20
            Me.dgvCreacion.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvCreacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvCreacion.Size = New System.Drawing.Size(295, 46)
            Me.dgvCreacion.TabIndex = 4
            '
            'Creacion
            '
            Me.Creacion.HeaderText = "Creacion"
            Me.Creacion.Name = "Creacion"
            Me.Creacion.ReadOnly = True
            Me.Creacion.Width = 285
            '
            'dgvBitacora
            '
            Me.dgvBitacora.AllowUserToAddRows = False
            Me.dgvBitacora.AllowUserToDeleteRows = False
            Me.dgvBitacora.AllowUserToOrderColumns = True
            Me.dgvBitacora.AllowUserToResizeRows = False
            Me.dgvBitacora.BackgroundColor = System.Drawing.Color.White
            Me.dgvBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvBitacora.ColumnHeadersVisible = False
            Me.dgvBitacora.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Descripcion})
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvBitacora.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvBitacora.GridColor = System.Drawing.Color.White
            Me.dgvBitacora.Location = New System.Drawing.Point(9, 67)
            Me.dgvBitacora.MultiSelect = False
            Me.dgvBitacora.Name = "dgvBitacora"
            Me.dgvBitacora.RowHeadersVisible = False
            Me.dgvBitacora.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
            Me.dgvBitacora.RowTemplate.Height = 20
            Me.dgvBitacora.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvBitacora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvBitacora.Size = New System.Drawing.Size(295, 315)
            Me.dgvBitacora.TabIndex = 3
            '
            'Descripcion
            '
            Me.Descripcion.HeaderText = "Descripción"
            Me.Descripcion.Name = "Descripcion"
            Me.Descripcion.ReadOnly = True
            Me.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.Descripcion.Width = 750
            '
            'txtNuevo
            '
            Me.txtNuevo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNuevo.Location = New System.Drawing.Point(55, 388)
            Me.txtNuevo.MaxLength = 100
            Me.txtNuevo.Name = "txtNuevo"
            Me.txtNuevo.Size = New System.Drawing.Size(249, 22)
            Me.txtNuevo.TabIndex = 2
            '
            'lblNuevo
            '
            Me.lblNuevo.AutoSize = True
            Me.lblNuevo.Location = New System.Drawing.Point(6, 395)
            Me.lblNuevo.Name = "lblNuevo"
            Me.lblNuevo.Size = New System.Drawing.Size(43, 15)
            Me.lblNuevo.TabIndex = 1
            Me.lblNuevo.Text = "Nuevo"
            '
            'MnEliminarBitacora
            '
            Me.MnEliminarBitacora.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarToolStripMenuItem})
            Me.MnEliminarBitacora.Name = "MnEliminarBitacora"
            Me.MnEliminarBitacora.Size = New System.Drawing.Size(118, 26)
            '
            'EliminarToolStripMenuItem
            '
            Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
            Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
            Me.EliminarToolStripMenuItem.Text = "Eliminar"
            '
            'txtTotal_Creditos
            '
            Me.txtTotal_Creditos.Enabled = False
            Me.txtTotal_Creditos.Location = New System.Drawing.Point(116, 388)
            Me.txtTotal_Creditos.MaxLength = 14
            Me.txtTotal_Creditos.Name = "txtTotal_Creditos"
            Me.txtTotal_Creditos.Size = New System.Drawing.Size(90, 20)
            Me.txtTotal_Creditos.TabIndex = 196
            Me.txtTotal_Creditos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblTotal_Creditos
            '
            Me.lblTotal_Creditos.AutoSize = True
            Me.lblTotal_Creditos.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotal_Creditos.Location = New System.Drawing.Point(123, 368)
            Me.lblTotal_Creditos.Name = "lblTotal_Creditos"
            Me.lblTotal_Creditos.Size = New System.Drawing.Size(83, 15)
            Me.lblTotal_Creditos.TabIndex = 197
            Me.lblTotal_Creditos.Text = "Total Créditos"
            '
            'rbJuridico
            '
            Me.rbJuridico.AutoSize = True
            Me.rbJuridico.Location = New System.Drawing.Point(62, 17)
            Me.rbJuridico.Name = "rbJuridico"
            Me.rbJuridico.Size = New System.Drawing.Size(68, 19)
            Me.rbJuridico.TabIndex = 1
            Me.rbJuridico.Text = "Jurídico"
            Me.rbJuridico.UseVisualStyleBackColor = True
            '
            'rbFisico
            '
            Me.rbFisico.Location = New System.Drawing.Point(6, 17)
            Me.rbFisico.Name = "rbFisico"
            Me.rbFisico.Size = New System.Drawing.Size(55, 17)
            Me.rbFisico.TabIndex = 0
            Me.rbFisico.Text = "Físico"
            Me.rbFisico.UseVisualStyleBackColor = True
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.Black
            Me.Label1.Location = New System.Drawing.Point(393, 91)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(120, 23)
            Me.Label1.TabIndex = 198
            Me.Label1.Text = "Estado Actual"
            '
            'lblMostrarEstado
            '
            Me.lblMostrarEstado.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarEstado.ForeColor = System.Drawing.Color.Black
            Me.lblMostrarEstado.Location = New System.Drawing.Point(519, 91)
            Me.lblMostrarEstado.Name = "lblMostrarEstado"
            Me.lblMostrarEstado.Size = New System.Drawing.Size(179, 23)
            Me.lblMostrarEstado.TabIndex = 199
            '
            'lblDias_Atraso
            '
            Me.lblDias_Atraso.AutoSize = True
            Me.lblDias_Atraso.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDias_Atraso.Location = New System.Drawing.Point(245, 368)
            Me.lblDias_Atraso.Name = "lblDias_Atraso"
            Me.lblDias_Atraso.Size = New System.Drawing.Size(109, 15)
            Me.lblDias_Atraso.TabIndex = 201
            Me.lblDias_Atraso.Text = "Facturas Atrasadas"
            '
            'txtDias_Atraso
            '
            Me.txtDias_Atraso.Enabled = False
            Me.txtDias_Atraso.Location = New System.Drawing.Point(322, 388)
            Me.txtDias_Atraso.MaxLength = 8
            Me.txtDias_Atraso.Name = "txtDias_Atraso"
            Me.txtDias_Atraso.Size = New System.Drawing.Size(41, 20)
            Me.txtDias_Atraso.TabIndex = 200
            '
            'txtTotal_Atrasado
            '
            Me.txtTotal_Atrasado.Enabled = False
            Me.txtTotal_Atrasado.Location = New System.Drawing.Point(230, 388)
            Me.txtTotal_Atrasado.MaxLength = 14
            Me.txtTotal_Atrasado.Name = "txtTotal_Atrasado"
            Me.txtTotal_Atrasado.Size = New System.Drawing.Size(90, 20)
            Me.txtTotal_Atrasado.TabIndex = 202
            Me.txtTotal_Atrasado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtNombreReal
            '
            Me.txtNombreReal.Location = New System.Drawing.Point(15, 164)
            Me.txtNombreReal.MaxLength = 60
            Me.txtNombreReal.Name = "txtNombreReal"
            Me.txtNombreReal.Size = New System.Drawing.Size(348, 20)
            Me.txtNombreReal.TabIndex = 205
            '
            'lblNombreReal
            '
            Me.lblNombreReal.AutoSize = True
            Me.lblNombreReal.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombreReal.Location = New System.Drawing.Point(15, 147)
            Me.lblNombreReal.Name = "lblNombreReal"
            Me.lblNombreReal.Size = New System.Drawing.Size(80, 15)
            Me.lblNombreReal.TabIndex = 206
            Me.lblNombreReal.Text = "Nombre Real"
            '
            'lblCedula
            '
            Me.lblCedula.AutoSize = True
            Me.lblCedula.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCedula.Location = New System.Drawing.Point(128, 187)
            Me.lblCedula.Name = "lblCedula"
            Me.lblCedula.Size = New System.Drawing.Size(44, 15)
            Me.lblCedula.TabIndex = 207
            Me.lblCedula.Text = "Cédula"
            '
            'lblSitioWeb
            '
            Me.lblSitioWeb.AutoSize = True
            Me.lblSitioWeb.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSitioWeb.Location = New System.Drawing.Point(188, 274)
            Me.lblSitioWeb.Name = "lblSitioWeb"
            Me.lblSitioWeb.Size = New System.Drawing.Size(61, 15)
            Me.lblSitioWeb.TabIndex = 224
            Me.lblSitioWeb.Text = "Sitio Web"
            '
            'txtSitioWeb
            '
            Me.txtSitioWeb.Location = New System.Drawing.Point(190, 290)
            Me.txtSitioWeb.MaxLength = 45
            Me.txtSitioWeb.Name = "txtSitioWeb"
            Me.txtSitioWeb.Size = New System.Drawing.Size(170, 20)
            Me.txtSitioWeb.TabIndex = 223
            '
            'gbTipo_Cedula
            '
            Me.gbTipo_Cedula.Controls.Add(Me.rbFisico)
            Me.gbTipo_Cedula.Controls.Add(Me.rbJuridico)
            Me.gbTipo_Cedula.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTipo_Cedula.Location = New System.Drawing.Point(230, 187)
            Me.gbTipo_Cedula.Name = "gbTipo_Cedula"
            Me.gbTipo_Cedula.Size = New System.Drawing.Size(133, 40)
            Me.gbTipo_Cedula.TabIndex = 225
            Me.gbTipo_Cedula.TabStop = False
            Me.gbTipo_Cedula.Text = "               Tipo"
            '
            'gbTipo_Credito
            '
            Me.gbTipo_Credito.Controls.Add(Me.rbPreferencial)
            Me.gbTipo_Credito.Controls.Add(Me.rbNormal)
            Me.gbTipo_Credito.Controls.Add(Me.rbPrueba)
            Me.gbTipo_Credito.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTipo_Credito.Location = New System.Drawing.Point(13, 312)
            Me.gbTipo_Credito.Name = "gbTipo_Credito"
            Me.gbTipo_Credito.Size = New System.Drawing.Size(348, 48)
            Me.gbTipo_Credito.TabIndex = 226
            Me.gbTipo_Credito.TabStop = False
            Me.gbTipo_Credito.Text = "                                    Tipo de Crédito"
            '
            'ShapeContainer1
            '
            Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
            Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
            Me.ShapeContainer1.Name = "ShapeContainer1"
            Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
            Me.ShapeContainer1.Size = New System.Drawing.Size(702, 559)
            Me.ShapeContainer1.TabIndex = 227
            Me.ShapeContainer1.TabStop = False
            '
            'LineShape1
            '
            Me.LineShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot
            Me.LineShape1.Name = "LineShape1"
            Me.LineShape1.X1 = 372
            Me.LineShape1.X2 = 371
            Me.LineShape1.Y1 = 71
            Me.LineShape1.Y2 = 538
            '
            'btnCerrarCredito
            '
            Me.btnCerrarCredito.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCerrarCredito.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnCerrarCredito.Location = New System.Drawing.Point(223, 19)
            Me.btnCerrarCredito.Name = "btnCerrarCredito"
            Me.btnCerrarCredito.Size = New System.Drawing.Size(65, 36)
            Me.btnCerrarCredito.TabIndex = 228
            Me.btnCerrarCredito.Text = "Cerrar"
            Me.btnCerrarCredito.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnCerrarCredito.UseVisualStyleBackColor = True
            '
            'btnCongelar
            '
            Me.btnCongelar.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCongelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnCongelar.Location = New System.Drawing.Point(159, 19)
            Me.btnCongelar.Name = "btnCongelar"
            Me.btnCongelar.Size = New System.Drawing.Size(65, 36)
            Me.btnCongelar.TabIndex = 229
            Me.btnCongelar.Text = "Congelar"
            Me.btnCongelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnCongelar.UseVisualStyleBackColor = True
            '
            'btnReactivar
            '
            Me.btnReactivar.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReactivar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnReactivar.Location = New System.Drawing.Point(95, 19)
            Me.btnReactivar.Name = "btnReactivar"
            Me.btnReactivar.Size = New System.Drawing.Size(65, 36)
            Me.btnReactivar.TabIndex = 230
            Me.btnReactivar.Text = "Activar"
            Me.btnReactivar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnReactivar.UseVisualStyleBackColor = True
            '
            'btnInformacionPersonal
            '
            Me.btnInformacionPersonal.Location = New System.Drawing.Point(10, 533)
            Me.btnInformacionPersonal.Name = "btnInformacionPersonal"
            Me.btnInformacionPersonal.Size = New System.Drawing.Size(162, 23)
            Me.btnInformacionPersonal.TabIndex = 231
            Me.btnInformacionPersonal.Text = "Encargados..."
            Me.btnInformacionPersonal.UseVisualStyleBackColor = True
            '
            'lblTelefono
            '
            Me.lblTelefono.AutoSize = True
            Me.lblTelefono.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTelefono.Location = New System.Drawing.Point(12, 233)
            Me.lblTelefono.Name = "lblTelefono"
            Me.lblTelefono.Size = New System.Drawing.Size(100, 14)
            Me.lblTelefono.TabIndex = 232
            Me.lblTelefono.Text = "Teléfono Principal"
            '
            'btnGuardar
            '
            Me.btnGuardar.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = Global.Presentacion.My.Resources.Resources.Guardar
            Me.btnGuardar.Location = New System.Drawing.Point(0, 0)
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(65, 57)
            Me.btnGuardar.TabIndex = 171
            Me.btnGuardar.Text = "Guardar"
            Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnGuardar.UseVisualStyleBackColor = True
            '
            'btnLimpiar
            '
            Me.btnLimpiar.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnLimpiar.Image = Global.Presentacion.My.Resources.Resources.Limpiar
            Me.btnLimpiar.Location = New System.Drawing.Point(64, 0)
            Me.btnLimpiar.Name = "btnLimpiar"
            Me.btnLimpiar.Size = New System.Drawing.Size(65, 57)
            Me.btnLimpiar.TabIndex = 170
            Me.btnLimpiar.Text = "Limpiar"
            Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnLimpiar.UseVisualStyleBackColor = True
            '
            'btnEliminar
            '
            Me.btnEliminar.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliminar.Image = Global.Presentacion.My.Resources.Resources.Eliminar
            Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnEliminar.Location = New System.Drawing.Point(31, 19)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(65, 36)
            Me.btnEliminar.TabIndex = 204
            Me.btnEliminar.Text = "Eliminar"
            Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnEliminar.UseVisualStyleBackColor = True
            '
            'txtTelefono
            '
            Me.txtTelefono.Location = New System.Drawing.Point(14, 249)
            Me.txtTelefono.MaxLength = 9
            Me.txtTelefono.Name = "txtTelefono"
            Me.txtTelefono.Size = New System.Drawing.Size(90, 20)
            Me.txtTelefono.TabIndex = 233
            Me.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtFax
            '
            Me.txtFax.Location = New System.Drawing.Point(251, 249)
            Me.txtFax.MaxLength = 9
            Me.txtFax.Name = "txtFax"
            Me.txtFax.Size = New System.Drawing.Size(90, 20)
            Me.txtFax.TabIndex = 235
            Me.txtFax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblFax
            '
            Me.lblFax.AutoSize = True
            Me.lblFax.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFax.Location = New System.Drawing.Point(249, 233)
            Me.lblFax.Name = "lblFax"
            Me.lblFax.Size = New System.Drawing.Size(76, 15)
            Me.lblFax.TabIndex = 234
            Me.lblFax.Text = "Fax Principal"
            '
            'lblEmail
            '
            Me.lblEmail.AutoSize = True
            Me.lblEmail.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEmail.Location = New System.Drawing.Point(12, 272)
            Me.lblEmail.Name = "lblEmail"
            Me.lblEmail.Size = New System.Drawing.Size(37, 15)
            Me.lblEmail.TabIndex = 237
            Me.lblEmail.Text = "Email"
            '
            'txtEmail
            '
            Me.txtEmail.Location = New System.Drawing.Point(14, 290)
            Me.txtEmail.MaxLength = 45
            Me.txtEmail.Name = "txtEmail"
            Me.txtEmail.Size = New System.Drawing.Size(170, 20)
            Me.txtEmail.TabIndex = 236
            '
            'txtOtroTelefono
            '
            Me.txtOtroTelefono.Location = New System.Drawing.Point(134, 249)
            Me.txtOtroTelefono.MaxLength = 9
            Me.txtOtroTelefono.Name = "txtOtroTelefono"
            Me.txtOtroTelefono.Size = New System.Drawing.Size(90, 20)
            Me.txtOtroTelefono.TabIndex = 239
            Me.txtOtroTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblOtroTelefono
            '
            Me.lblOtroTelefono.AutoSize = True
            Me.lblOtroTelefono.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblOtroTelefono.Location = New System.Drawing.Point(133, 233)
            Me.lblOtroTelefono.Name = "lblOtroTelefono"
            Me.lblOtroTelefono.Size = New System.Drawing.Size(84, 15)
            Me.lblOtroTelefono.TabIndex = 238
            Me.lblOtroTelefono.Text = "Otro Teléfono"
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.btnEliminar)
            Me.GroupBox1.Controls.Add(Me.btnCongelar)
            Me.GroupBox1.Controls.Add(Me.btnCerrarCredito)
            Me.GroupBox1.Controls.Add(Me.btnReactivar)
            Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(386, 3)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(305, 68)
            Me.GroupBox1.TabIndex = 240
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Crédito"
            '
            'chkIncluirEnCobro
            '
            Me.chkIncluirEnCobro.AutoSize = True
            Me.chkIncluirEnCobro.Enabled = False
            Me.chkIncluirEnCobro.Location = New System.Drawing.Point(261, 536)
            Me.chkIncluirEnCobro.Name = "chkIncluirEnCobro"
            Me.chkIncluirEnCobro.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.chkIncluirEnCobro.Size = New System.Drawing.Size(99, 17)
            Me.chkIncluirEnCobro.TabIndex = 241
            Me.chkIncluirEnCobro.Text = "Incluir en cobro"
            Me.chkIncluirEnCobro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.chkIncluirEnCobro.UseVisualStyleBackColor = True
            '
            'btnDesbloquear
            '
            Me.btnDesbloquear.Location = New System.Drawing.Point(178, 533)
            Me.btnDesbloquear.Name = "btnDesbloquear"
            Me.btnDesbloquear.Size = New System.Drawing.Size(77, 23)
            Me.btnDesbloquear.TabIndex = 242
            Me.btnDesbloquear.Text = "Desbloquear"
            Me.btnDesbloquear.UseVisualStyleBackColor = True
            '
            'FrmClienteCredito
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(702, 559)
            Me.Controls.Add(Me.btnDesbloquear)
            Me.Controls.Add(Me.chkIncluirEnCobro)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.dgvClientes)
            Me.Controls.Add(Me.txtOtroTelefono)
            Me.Controls.Add(Me.lblOtroTelefono)
            Me.Controls.Add(Me.lblEmail)
            Me.Controls.Add(Me.txtEmail)
            Me.Controls.Add(Me.txtFax)
            Me.Controls.Add(Me.lblFax)
            Me.Controls.Add(Me.txtTelefono)
            Me.Controls.Add(Me.lblSitioWeb)
            Me.Controls.Add(Me.btnInformacionPersonal)
            Me.Controls.Add(Me.lblTelefono)
            Me.Controls.Add(Me.txtSitioWeb)
            Me.Controls.Add(Me.lblLimite)
            Me.Controls.Add(Me.txtLimite)
            Me.Controls.Add(Me.lblTotal_Creditos)
            Me.Controls.Add(Me.txtTotal_Creditos)
            Me.Controls.Add(Me.lblDias_Atraso)
            Me.Controls.Add(Me.txtTotal_Atrasado)
            Me.Controls.Add(Me.txtDias_Atraso)
            Me.Controls.Add(Me.lblDireccion)
            Me.Controls.Add(Me.txtDireccion)
            Me.Controls.Add(Me.lblObserv)
            Me.Controls.Add(Me.txtObservaciones)
            Me.Controls.Add(Me.btnGuardar)
            Me.Controls.Add(Me.btnLimpiar)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.gbBitacora)
            Me.Controls.Add(Me.lblMostrarEstado)
            Me.Controls.Add(Me.lblId_Credito)
            Me.Controls.Add(Me.lblId_Cliente)
            Me.Controls.Add(Me.txtId_Credito)
            Me.Controls.Add(Me.txtId_Cliente)
            Me.Controls.Add(Me.gbTipo_Credito)
            Me.Controls.Add(Me.txtCedula)
            Me.Controls.Add(Me.gbTipo_Cedula)
            Me.Controls.Add(Me.lblCedula)
            Me.Controls.Add(Me.txtNombreReal)
            Me.Controls.Add(Me.lblNombreReal)
            Me.Controls.Add(Me.btnCorregir)
            Me.Controls.Add(Me.txtApellido1)
            Me.Controls.Add(Me.txtApellido2)
            Me.Controls.Add(Me.lblApellido2)
            Me.Controls.Add(Me.txtNombre)
            Me.Controls.Add(Me.lblNombre)
            Me.Controls.Add(Me.lblApellido1)
            Me.Controls.Add(Me.ShapeContainer1)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmClienteCredito"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Clientes de Credito"
            CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.errorCredito, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbBitacora.ResumeLayout(False)
            Me.gbBitacora.PerformLayout()
            CType(Me.dgvCreacion, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvBitacora, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MnEliminarBitacora.ResumeLayout(False)
            Me.gbTipo_Cedula.ResumeLayout(False)
            Me.gbTipo_Cedula.PerformLayout()
            Me.gbTipo_Credito.ResumeLayout(False)
            Me.gbTipo_Credito.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents lblId_Credito As System.Windows.Forms.Label
        Friend WithEvents lblId_Cliente As System.Windows.Forms.Label
        Friend WithEvents lblApellido1 As System.Windows.Forms.Label
        Friend WithEvents lblNombre As System.Windows.Forms.Label
        Friend WithEvents lblApellido2 As System.Windows.Forms.Label
        Friend WithEvents txtId_Credito As System.Windows.Forms.TextBox
        Friend WithEvents txtId_Cliente As System.Windows.Forms.TextBox
        Friend WithEvents txtNombre As System.Windows.Forms.TextBox
        Friend WithEvents txtApellido1 As System.Windows.Forms.TextBox
        Friend WithEvents txtApellido2 As System.Windows.Forms.TextBox
        Friend WithEvents btnGuardar As System.Windows.Forms.Button
        Friend WithEvents btnLimpiar As System.Windows.Forms.Button
        Friend WithEvents btnCorregir As System.Windows.Forms.Button
        Friend WithEvents txtCedula As System.Windows.Forms.TextBox
        Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
        Friend WithEvents lblDireccion As System.Windows.Forms.Label
        Friend WithEvents txtLimite As System.Windows.Forms.TextBox
        Friend WithEvents lblLimite As System.Windows.Forms.Label
        Friend WithEvents rbPrueba As System.Windows.Forms.RadioButton
        Friend WithEvents rbNormal As System.Windows.Forms.RadioButton
        Friend WithEvents rbPreferencial As System.Windows.Forms.RadioButton
        Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
        Friend WithEvents lblObserv As System.Windows.Forms.Label
        Friend WithEvents dgvClientes As System.Windows.Forms.DataGridView
        Friend WithEvents errorCredito As System.Windows.Forms.ErrorProvider
        Friend WithEvents gbBitacora As System.Windows.Forms.GroupBox
        Friend WithEvents txtNuevo As System.Windows.Forms.TextBox
        Friend WithEvents lblNuevo As System.Windows.Forms.Label
        Friend WithEvents dgvBitacora As System.Windows.Forms.DataGridView
        Friend WithEvents MnEliminarBitacora As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents txtTotal_Creditos As System.Windows.Forms.TextBox
        Friend WithEvents lblTotal_Creditos As System.Windows.Forms.Label
        Friend WithEvents rbJuridico As System.Windows.Forms.RadioButton
        Friend WithEvents rbFisico As System.Windows.Forms.RadioButton
        Friend WithEvents lblMostrarEstado As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtTotal_Atrasado As System.Windows.Forms.TextBox
        Friend WithEvents lblDias_Atraso As System.Windows.Forms.Label
        Friend WithEvents txtDias_Atraso As System.Windows.Forms.TextBox
        Friend WithEvents btnEliminar As System.Windows.Forms.Button
        Friend WithEvents lblCedula As System.Windows.Forms.Label
        Friend WithEvents txtNombreReal As System.Windows.Forms.TextBox
        Friend WithEvents lblNombreReal As System.Windows.Forms.Label
        Friend WithEvents lblSitioWeb As System.Windows.Forms.Label
        Friend WithEvents txtSitioWeb As System.Windows.Forms.TextBox
        Friend WithEvents gbTipo_Cedula As System.Windows.Forms.GroupBox
        Friend WithEvents gbTipo_Credito As System.Windows.Forms.GroupBox
        Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents dgvCreacion As System.Windows.Forms.DataGridView
        Friend WithEvents Creacion As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents btnCerrarCredito As System.Windows.Forms.Button
        Friend WithEvents btnCongelar As System.Windows.Forms.Button
        Friend WithEvents btnReactivar As System.Windows.Forms.Button
        Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents btnInformacionPersonal As System.Windows.Forms.Button
        Friend WithEvents lblTelefono As System.Windows.Forms.Label
        Friend WithEvents lblEmail As System.Windows.Forms.Label
        Friend WithEvents txtEmail As System.Windows.Forms.TextBox
        Friend WithEvents txtFax As System.Windows.Forms.TextBox
        Friend WithEvents lblFax As System.Windows.Forms.Label
        Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
        Friend WithEvents txtOtroTelefono As System.Windows.Forms.TextBox
        Friend WithEvents lblOtroTelefono As System.Windows.Forms.Label
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents chkIncluirEnCobro As System.Windows.Forms.CheckBox
        Friend WithEvents btnDesbloquear As System.Windows.Forms.Button
    End Class
End Namespace