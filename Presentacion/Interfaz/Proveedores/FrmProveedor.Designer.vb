Namespace Interfaz.Proveedores
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmProveedor
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
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.lblTelefono2 = New System.Windows.Forms.Label()
            Me.lblTelefono1 = New System.Windows.Forms.Label()
            Me.lblNombre_Agente = New System.Windows.Forms.Label()
            Me.lblFax_Agente = New System.Windows.Forms.Label()
            Me.txtTelefono1_Agente = New System.Windows.Forms.TextBox()
            Me.txtNombre_Agente = New System.Windows.Forms.TextBox()
            Me.txtTelefono2_Agente = New System.Windows.Forms.TextBox()
            Me.txtFax_Agente = New System.Windows.Forms.TextBox()
            Me.dgvAgentes = New System.Windows.Forms.DataGridView()
            Me.txtNombre = New System.Windows.Forms.TextBox()
            Me.txtId_Proveedor = New System.Windows.Forms.TextBox()
            Me.lblNombre = New System.Windows.Forms.Label()
            Me.lblId_Proveedor = New System.Windows.Forms.Label()
            Me.txtCentral_Telefonica = New System.Windows.Forms.TextBox()
            Me.lblCentral_Telefonica = New System.Windows.Forms.Label()
            Me.txtFax_Principal = New System.Windows.Forms.TextBox()
            Me.lblFax_Principal = New System.Windows.Forms.Label()
            Me.gbAgente = New System.Windows.Forms.GroupBox()
            Me.txtCorreo_Agente = New System.Windows.Forms.TextBox()
            Me.lblCorreo_Agente = New System.Windows.Forms.Label()
            Me.btnAgregar_Agente = New System.Windows.Forms.Button()
            Me.txtId_Agente = New System.Windows.Forms.TextBox()
            Me.gbEncargados = New System.Windows.Forms.GroupBox()
            Me.txtCorreoEncargado = New System.Windows.Forms.TextBox()
            Me.lblCorreoEncargado = New System.Windows.Forms.Label()
            Me.txtExt1_Encargado = New System.Windows.Forms.TextBox()
            Me.lblExt1_Encargado = New System.Windows.Forms.Label()
            Me.txtExt2_Encargado = New System.Windows.Forms.TextBox()
            Me.lblExt2_Encargado = New System.Windows.Forms.Label()
            Me.txtTelefono2_Encargado = New System.Windows.Forms.TextBox()
            Me.btnAgregar_Encargado = New System.Windows.Forms.Button()
            Me.txtFax_Encargado = New System.Windows.Forms.TextBox()
            Me.txtTelefono1_Encargado = New System.Windows.Forms.TextBox()
            Me.txtServicio = New System.Windows.Forms.TextBox()
            Me.lblServicio = New System.Windows.Forms.Label()
            Me.lblFax_Encargado = New System.Windows.Forms.Label()
            Me.lblNombre_Encargado = New System.Windows.Forms.Label()
            Me.lblTelefono1_Encargado = New System.Windows.Forms.Label()
            Me.lblTelefono2_Encargado = New System.Windows.Forms.Label()
            Me.txtNombre_Encargado = New System.Windows.Forms.TextBox()
            Me.dgvEncargados = New System.Windows.Forms.DataGridView()
            Me.txtId_Encargado = New System.Windows.Forms.TextBox()
            Me.errDerechoProveedor = New System.Windows.Forms.ErrorProvider(Me.components)
            Me.MnEliminarAgente = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.errIzqProveedor = New System.Windows.Forms.ErrorProvider(Me.components)
            Me.dgvProveedores = New System.Windows.Forms.DataGridView()
            Me.MnEliminarEncargado = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.EliminarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.lblDireccion = New System.Windows.Forms.Label()
            Me.txtDireccion = New System.Windows.Forms.TextBox()
            Me.lblCorreo = New System.Windows.Forms.Label()
            Me.txtCorreo = New System.Windows.Forms.TextBox()
            Me.txtCC = New System.Windows.Forms.TextBox()
            Me.lblCC = New System.Windows.Forms.Label()
            Me.txtCedula = New System.Windows.Forms.TextBox()
            Me.lblCedula = New System.Windows.Forms.Label()
            Me.btnListadosPendientes = New System.Windows.Forms.Button()
            Me.btnLimpiar = New System.Windows.Forms.Button()
            Me.btnInsertar = New System.Windows.Forms.Button()
            Me.btnEliminar = New System.Windows.Forms.Button()
            Me.lblN_Cuenta = New System.Windows.Forms.Label()
            Me.txtNum_Cuenta = New System.Windows.Forms.TextBox()
            CType(Me.dgvAgentes, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbAgente.SuspendLayout()
            Me.gbEncargados.SuspendLayout()
            CType(Me.dgvEncargados, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.errDerechoProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MnEliminarAgente.SuspendLayout()
            CType(Me.errIzqProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MnEliminarEncargado.SuspendLayout()
            Me.SuspendLayout()
            '
            'lblTelefono2
            '
            Me.lblTelefono2.AutoSize = True
            Me.lblTelefono2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblTelefono2.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTelefono2.Location = New System.Drawing.Point(324, 20)
            Me.lblTelefono2.Name = "lblTelefono2"
            Me.lblTelefono2.Size = New System.Drawing.Size(71, 15)
            Me.lblTelefono2.TabIndex = 1
            Me.lblTelefono2.Text = "Teléfono #2"
            '
            'lblTelefono1
            '
            Me.lblTelefono1.AutoSize = True
            Me.lblTelefono1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblTelefono1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTelefono1.Location = New System.Drawing.Point(246, 20)
            Me.lblTelefono1.Name = "lblTelefono1"
            Me.lblTelefono1.Size = New System.Drawing.Size(70, 15)
            Me.lblTelefono1.TabIndex = 2
            Me.lblTelefono1.Text = "Teléfono #1"
            '
            'lblNombre_Agente
            '
            Me.lblNombre_Agente.AutoSize = True
            Me.lblNombre_Agente.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblNombre_Agente.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombre_Agente.Location = New System.Drawing.Point(6, 20)
            Me.lblNombre_Agente.Name = "lblNombre_Agente"
            Me.lblNombre_Agente.Size = New System.Drawing.Size(53, 15)
            Me.lblNombre_Agente.TabIndex = 3
            Me.lblNombre_Agente.Text = "Nombre"
            '
            'lblFax_Agente
            '
            Me.lblFax_Agente.AutoSize = True
            Me.lblFax_Agente.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblFax_Agente.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFax_Agente.Location = New System.Drawing.Point(404, 22)
            Me.lblFax_Agente.Name = "lblFax_Agente"
            Me.lblFax_Agente.Size = New System.Drawing.Size(26, 15)
            Me.lblFax_Agente.TabIndex = 5
            Me.lblFax_Agente.Text = "Fax"
            '
            'txtTelefono1_Agente
            '
            Me.txtTelefono1_Agente.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtTelefono1_Agente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTelefono1_Agente.Location = New System.Drawing.Point(252, 36)
            Me.txtTelefono1_Agente.MaxLength = 9
            Me.txtTelefono1_Agente.Name = "txtTelefono1_Agente"
            Me.txtTelefono1_Agente.Size = New System.Drawing.Size(70, 20)
            Me.txtTelefono1_Agente.TabIndex = 5
            Me.txtTelefono1_Agente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtNombre_Agente
            '
            Me.txtNombre_Agente.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtNombre_Agente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombre_Agente.Location = New System.Drawing.Point(6, 36)
            Me.txtNombre_Agente.MaxLength = 40
            Me.txtNombre_Agente.Name = "txtNombre_Agente"
            Me.txtNombre_Agente.Size = New System.Drawing.Size(240, 20)
            Me.txtNombre_Agente.TabIndex = 4
            '
            'txtTelefono2_Agente
            '
            Me.txtTelefono2_Agente.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtTelefono2_Agente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTelefono2_Agente.Location = New System.Drawing.Point(328, 36)
            Me.txtTelefono2_Agente.MaxLength = 9
            Me.txtTelefono2_Agente.Name = "txtTelefono2_Agente"
            Me.txtTelefono2_Agente.Size = New System.Drawing.Size(70, 20)
            Me.txtTelefono2_Agente.TabIndex = 6
            Me.txtTelefono2_Agente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtFax_Agente
            '
            Me.txtFax_Agente.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtFax_Agente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFax_Agente.Location = New System.Drawing.Point(404, 36)
            Me.txtFax_Agente.MaxLength = 9
            Me.txtFax_Agente.Name = "txtFax_Agente"
            Me.txtFax_Agente.Size = New System.Drawing.Size(70, 20)
            Me.txtFax_Agente.TabIndex = 8
            Me.txtFax_Agente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'dgvAgentes
            '
            Me.dgvAgentes.AllowUserToAddRows = False
            Me.dgvAgentes.AllowUserToDeleteRows = False
            Me.dgvAgentes.AllowUserToResizeColumns = False
            Me.dgvAgentes.AllowUserToResizeRows = False
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvAgentes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
            Me.dgvAgentes.BackgroundColor = System.Drawing.Color.White
            Me.dgvAgentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvAgentes.Cursor = System.Windows.Forms.Cursors.Hand
            Me.dgvAgentes.Location = New System.Drawing.Point(6, 97)
            Me.dgvAgentes.MultiSelect = False
            Me.dgvAgentes.Name = "dgvAgentes"
            Me.dgvAgentes.ReadOnly = True
            Me.dgvAgentes.RowHeadersVisible = False
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvAgentes.RowsDefaultCellStyle = DataGridViewCellStyle7
            Me.dgvAgentes.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvAgentes.RowTemplate.Height = 18
            Me.dgvAgentes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvAgentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvAgentes.Size = New System.Drawing.Size(606, 72)
            Me.dgvAgentes.TabIndex = 41
            '
            'txtNombre
            '
            Me.txtNombre.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtNombre.Location = New System.Drawing.Point(66, 86)
            Me.txtNombre.MaxLength = 55
            Me.txtNombre.Name = "txtNombre"
            Me.txtNombre.Size = New System.Drawing.Size(239, 20)
            Me.txtNombre.TabIndex = 0
            '
            'txtId_Proveedor
            '
            Me.txtId_Proveedor.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtId_Proveedor.Location = New System.Drawing.Point(10, 86)
            Me.txtId_Proveedor.MaxLength = 5
            Me.txtId_Proveedor.Name = "txtId_Proveedor"
            Me.txtId_Proveedor.Size = New System.Drawing.Size(50, 20)
            Me.txtId_Proveedor.TabIndex = 1
            Me.txtId_Proveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblNombre
            '
            Me.lblNombre.AutoSize = True
            Me.lblNombre.BackColor = System.Drawing.Color.Transparent
            Me.lblNombre.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblNombre.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombre.Location = New System.Drawing.Point(67, 68)
            Me.lblNombre.Name = "lblNombre"
            Me.lblNombre.Size = New System.Drawing.Size(111, 15)
            Me.lblNombre.TabIndex = 43
            Me.lblNombre.Text = "Nombre Comercial"
            '
            'lblId_Proveedor
            '
            Me.lblId_Proveedor.AutoSize = True
            Me.lblId_Proveedor.BackColor = System.Drawing.Color.Transparent
            Me.lblId_Proveedor.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblId_Proveedor.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblId_Proveedor.Location = New System.Drawing.Point(9, 69)
            Me.lblId_Proveedor.Name = "lblId_Proveedor"
            Me.lblId_Proveedor.Size = New System.Drawing.Size(45, 15)
            Me.lblId_Proveedor.TabIndex = 42
            Me.lblId_Proveedor.Text = "Código"
            '
            'txtCentral_Telefonica
            '
            Me.txtCentral_Telefonica.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtCentral_Telefonica.Location = New System.Drawing.Point(311, 86)
            Me.txtCentral_Telefonica.MaxLength = 9
            Me.txtCentral_Telefonica.Name = "txtCentral_Telefonica"
            Me.txtCentral_Telefonica.Size = New System.Drawing.Size(88, 20)
            Me.txtCentral_Telefonica.TabIndex = 2
            Me.txtCentral_Telefonica.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblCentral_Telefonica
            '
            Me.lblCentral_Telefonica.AutoSize = True
            Me.lblCentral_Telefonica.BackColor = System.Drawing.Color.Transparent
            Me.lblCentral_Telefonica.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblCentral_Telefonica.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCentral_Telefonica.Location = New System.Drawing.Point(308, 68)
            Me.lblCentral_Telefonica.Name = "lblCentral_Telefonica"
            Me.lblCentral_Telefonica.Size = New System.Drawing.Size(76, 15)
            Me.lblCentral_Telefonica.TabIndex = 46
            Me.lblCentral_Telefonica.Text = "C. Teléfonica"
            '
            'txtFax_Principal
            '
            Me.txtFax_Principal.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtFax_Principal.Location = New System.Drawing.Point(405, 86)
            Me.txtFax_Principal.MaxLength = 9
            Me.txtFax_Principal.Name = "txtFax_Principal"
            Me.txtFax_Principal.Size = New System.Drawing.Size(88, 20)
            Me.txtFax_Principal.TabIndex = 3
            Me.txtFax_Principal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblFax_Principal
            '
            Me.lblFax_Principal.AutoSize = True
            Me.lblFax_Principal.BackColor = System.Drawing.Color.Transparent
            Me.lblFax_Principal.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblFax_Principal.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFax_Principal.Location = New System.Drawing.Point(402, 68)
            Me.lblFax_Principal.Name = "lblFax_Principal"
            Me.lblFax_Principal.Size = New System.Drawing.Size(76, 15)
            Me.lblFax_Principal.TabIndex = 48
            Me.lblFax_Principal.Text = "Fax Principal"
            '
            'gbAgente
            '
            Me.gbAgente.BackColor = System.Drawing.Color.Transparent
            Me.gbAgente.Controls.Add(Me.txtCorreo_Agente)
            Me.gbAgente.Controls.Add(Me.lblCorreo_Agente)
            Me.gbAgente.Controls.Add(Me.btnAgregar_Agente)
            Me.gbAgente.Controls.Add(Me.txtFax_Agente)
            Me.gbAgente.Controls.Add(Me.txtNombre_Agente)
            Me.gbAgente.Controls.Add(Me.txtTelefono1_Agente)
            Me.gbAgente.Controls.Add(Me.lblFax_Agente)
            Me.gbAgente.Controls.Add(Me.lblNombre_Agente)
            Me.gbAgente.Controls.Add(Me.lblTelefono1)
            Me.gbAgente.Controls.Add(Me.lblTelefono2)
            Me.gbAgente.Controls.Add(Me.txtTelefono2_Agente)
            Me.gbAgente.Controls.Add(Me.dgvAgentes)
            Me.gbAgente.Controls.Add(Me.txtId_Agente)
            Me.gbAgente.Cursor = System.Windows.Forms.Cursors.Hand
            Me.gbAgente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbAgente.Location = New System.Drawing.Point(10, 199)
            Me.gbAgente.Name = "gbAgente"
            Me.gbAgente.Size = New System.Drawing.Size(620, 175)
            Me.gbAgente.TabIndex = 18
            Me.gbAgente.TabStop = False
            Me.gbAgente.Text = "Agente(s)"
            '
            'txtCorreo_Agente
            '
            Me.txtCorreo_Agente.Location = New System.Drawing.Point(6, 74)
            Me.txtCorreo_Agente.MaxLength = 50
            Me.txtCorreo_Agente.Name = "txtCorreo_Agente"
            Me.txtCorreo_Agente.Size = New System.Drawing.Size(243, 20)
            Me.txtCorreo_Agente.TabIndex = 85
            '
            'lblCorreo_Agente
            '
            Me.lblCorreo_Agente.AutoSize = True
            Me.lblCorreo_Agente.BackColor = System.Drawing.Color.Transparent
            Me.lblCorreo_Agente.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCorreo_Agente.Location = New System.Drawing.Point(6, 56)
            Me.lblCorreo_Agente.Name = "lblCorreo_Agente"
            Me.lblCorreo_Agente.Size = New System.Drawing.Size(111, 15)
            Me.lblCorreo_Agente.TabIndex = 84
            Me.lblCorreo_Agente.Text = "Correo Eléctronico"
            '
            'btnAgregar_Agente
            '
            Me.btnAgregar_Agente.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnAgregar_Agente.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAgregar_Agente.Location = New System.Drawing.Point(486, 36)
            Me.btnAgregar_Agente.Name = "btnAgregar_Agente"
            Me.btnAgregar_Agente.Size = New System.Drawing.Size(72, 40)
            Me.btnAgregar_Agente.TabIndex = 9
            Me.btnAgregar_Agente.Text = "Agregar / Modificar"
            Me.btnAgregar_Agente.UseVisualStyleBackColor = True
            '
            'txtId_Agente
            '
            Me.txtId_Agente.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtId_Agente.Enabled = False
            Me.txtId_Agente.Location = New System.Drawing.Point(474, 111)
            Me.txtId_Agente.MaxLength = 5
            Me.txtId_Agente.Name = "txtId_Agente"
            Me.txtId_Agente.Size = New System.Drawing.Size(50, 20)
            Me.txtId_Agente.TabIndex = 47
            Me.txtId_Agente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.txtId_Agente.Visible = False
            '
            'gbEncargados
            '
            Me.gbEncargados.BackColor = System.Drawing.Color.Transparent
            Me.gbEncargados.Controls.Add(Me.txtCorreoEncargado)
            Me.gbEncargados.Controls.Add(Me.lblCorreoEncargado)
            Me.gbEncargados.Controls.Add(Me.txtExt1_Encargado)
            Me.gbEncargados.Controls.Add(Me.lblExt1_Encargado)
            Me.gbEncargados.Controls.Add(Me.txtExt2_Encargado)
            Me.gbEncargados.Controls.Add(Me.lblExt2_Encargado)
            Me.gbEncargados.Controls.Add(Me.txtTelefono2_Encargado)
            Me.gbEncargados.Controls.Add(Me.btnAgregar_Encargado)
            Me.gbEncargados.Controls.Add(Me.txtFax_Encargado)
            Me.gbEncargados.Controls.Add(Me.txtTelefono1_Encargado)
            Me.gbEncargados.Controls.Add(Me.txtServicio)
            Me.gbEncargados.Controls.Add(Me.lblServicio)
            Me.gbEncargados.Controls.Add(Me.lblFax_Encargado)
            Me.gbEncargados.Controls.Add(Me.lblNombre_Encargado)
            Me.gbEncargados.Controls.Add(Me.lblTelefono1_Encargado)
            Me.gbEncargados.Controls.Add(Me.lblTelefono2_Encargado)
            Me.gbEncargados.Controls.Add(Me.txtNombre_Encargado)
            Me.gbEncargados.Controls.Add(Me.dgvEncargados)
            Me.gbEncargados.Controls.Add(Me.txtId_Encargado)
            Me.gbEncargados.Cursor = System.Windows.Forms.Cursors.Hand
            Me.gbEncargados.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbEncargados.Location = New System.Drawing.Point(10, 380)
            Me.gbEncargados.Name = "gbEncargados"
            Me.gbEncargados.Size = New System.Drawing.Size(620, 261)
            Me.gbEncargados.TabIndex = 19
            Me.gbEncargados.TabStop = False
            Me.gbEncargados.Text = "Encargado(s)"
            '
            'txtCorreoEncargado
            '
            Me.txtCorreoEncargado.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtCorreoEncargado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCorreoEncargado.Location = New System.Drawing.Point(327, 68)
            Me.txtCorreoEncargado.MaxLength = 100
            Me.txtCorreoEncargado.Name = "txtCorreoEncargado"
            Me.txtCorreoEncargado.Size = New System.Drawing.Size(213, 20)
            Me.txtCorreoEncargado.TabIndex = 48
            '
            'lblCorreoEncargado
            '
            Me.lblCorreoEncargado.AutoSize = True
            Me.lblCorreoEncargado.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblCorreoEncargado.Location = New System.Drawing.Point(324, 54)
            Me.lblCorreoEncargado.Name = "lblCorreoEncargado"
            Me.lblCorreoEncargado.Size = New System.Drawing.Size(45, 15)
            Me.lblCorreoEncargado.TabIndex = 47
            Me.lblCorreoEncargado.Text = "Correo"
            '
            'txtExt1_Encargado
            '
            Me.txtExt1_Encargado.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtExt1_Encargado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtExt1_Encargado.Location = New System.Drawing.Point(483, 32)
            Me.txtExt1_Encargado.MaxLength = 4
            Me.txtExt1_Encargado.Name = "txtExt1_Encargado"
            Me.txtExt1_Encargado.Size = New System.Drawing.Size(50, 20)
            Me.txtExt1_Encargado.TabIndex = 15
            Me.txtExt1_Encargado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblExt1_Encargado
            '
            Me.lblExt1_Encargado.AutoSize = True
            Me.lblExt1_Encargado.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblExt1_Encargado.Location = New System.Drawing.Point(483, 16)
            Me.lblExt1_Encargado.Name = "lblExt1_Encargado"
            Me.lblExt1_Encargado.Size = New System.Drawing.Size(41, 15)
            Me.lblExt1_Encargado.TabIndex = 46
            Me.lblExt1_Encargado.Text = "Ext #1"
            '
            'txtExt2_Encargado
            '
            Me.txtExt2_Encargado.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtExt2_Encargado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtExt2_Encargado.Location = New System.Drawing.Point(546, 32)
            Me.txtExt2_Encargado.MaxLength = 4
            Me.txtExt2_Encargado.Name = "txtExt2_Encargado"
            Me.txtExt2_Encargado.Size = New System.Drawing.Size(50, 20)
            Me.txtExt2_Encargado.TabIndex = 16
            Me.txtExt2_Encargado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblExt2_Encargado
            '
            Me.lblExt2_Encargado.AutoSize = True
            Me.lblExt2_Encargado.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblExt2_Encargado.Location = New System.Drawing.Point(546, 16)
            Me.lblExt2_Encargado.Name = "lblExt2_Encargado"
            Me.lblExt2_Encargado.Size = New System.Drawing.Size(42, 15)
            Me.lblExt2_Encargado.TabIndex = 44
            Me.lblExt2_Encargado.Text = "Ext #2"
            '
            'txtTelefono2_Encargado
            '
            Me.txtTelefono2_Encargado.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtTelefono2_Encargado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTelefono2_Encargado.Location = New System.Drawing.Point(330, 32)
            Me.txtTelefono2_Encargado.MaxLength = 9
            Me.txtTelefono2_Encargado.Name = "txtTelefono2_Encargado"
            Me.txtTelefono2_Encargado.Size = New System.Drawing.Size(70, 20)
            Me.txtTelefono2_Encargado.TabIndex = 12
            Me.txtTelefono2_Encargado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'btnAgregar_Encargado
            '
            Me.btnAgregar_Encargado.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnAgregar_Encargado.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAgregar_Encargado.Location = New System.Drawing.Point(546, 58)
            Me.btnAgregar_Encargado.Name = "btnAgregar_Encargado"
            Me.btnAgregar_Encargado.Size = New System.Drawing.Size(66, 38)
            Me.btnAgregar_Encargado.TabIndex = 17
            Me.btnAgregar_Encargado.Text = "Agregar / Modificar"
            Me.btnAgregar_Encargado.UseVisualStyleBackColor = True
            '
            'txtFax_Encargado
            '
            Me.txtFax_Encargado.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtFax_Encargado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFax_Encargado.Location = New System.Drawing.Point(407, 32)
            Me.txtFax_Encargado.MaxLength = 9
            Me.txtFax_Encargado.Name = "txtFax_Encargado"
            Me.txtFax_Encargado.Size = New System.Drawing.Size(70, 20)
            Me.txtFax_Encargado.TabIndex = 14
            Me.txtFax_Encargado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTelefono1_Encargado
            '
            Me.txtTelefono1_Encargado.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtTelefono1_Encargado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTelefono1_Encargado.Location = New System.Drawing.Point(254, 32)
            Me.txtTelefono1_Encargado.MaxLength = 9
            Me.txtTelefono1_Encargado.Name = "txtTelefono1_Encargado"
            Me.txtTelefono1_Encargado.Size = New System.Drawing.Size(70, 20)
            Me.txtTelefono1_Encargado.TabIndex = 11
            Me.txtTelefono1_Encargado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtServicio
            '
            Me.txtServicio.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtServicio.Location = New System.Drawing.Point(12, 69)
            Me.txtServicio.MaxLength = 50
            Me.txtServicio.Name = "txtServicio"
            Me.txtServicio.Size = New System.Drawing.Size(312, 20)
            Me.txtServicio.TabIndex = 13
            '
            'lblServicio
            '
            Me.lblServicio.AutoSize = True
            Me.lblServicio.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblServicio.Location = New System.Drawing.Point(9, 55)
            Me.lblServicio.Name = "lblServicio"
            Me.lblServicio.Size = New System.Drawing.Size(51, 15)
            Me.lblServicio.TabIndex = 6
            Me.lblServicio.Text = "Servicio"
            '
            'lblFax_Encargado
            '
            Me.lblFax_Encargado.AutoSize = True
            Me.lblFax_Encargado.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblFax_Encargado.Location = New System.Drawing.Point(406, 16)
            Me.lblFax_Encargado.Name = "lblFax_Encargado"
            Me.lblFax_Encargado.Size = New System.Drawing.Size(26, 15)
            Me.lblFax_Encargado.TabIndex = 5
            Me.lblFax_Encargado.Text = "Fax"
            '
            'lblNombre_Encargado
            '
            Me.lblNombre_Encargado.AutoSize = True
            Me.lblNombre_Encargado.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblNombre_Encargado.Location = New System.Drawing.Point(9, 16)
            Me.lblNombre_Encargado.Name = "lblNombre_Encargado"
            Me.lblNombre_Encargado.Size = New System.Drawing.Size(53, 15)
            Me.lblNombre_Encargado.TabIndex = 3
            Me.lblNombre_Encargado.Text = "Nombre"
            '
            'lblTelefono1_Encargado
            '
            Me.lblTelefono1_Encargado.AutoSize = True
            Me.lblTelefono1_Encargado.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblTelefono1_Encargado.Location = New System.Drawing.Point(251, 16)
            Me.lblTelefono1_Encargado.Name = "lblTelefono1_Encargado"
            Me.lblTelefono1_Encargado.Size = New System.Drawing.Size(70, 15)
            Me.lblTelefono1_Encargado.TabIndex = 2
            Me.lblTelefono1_Encargado.Text = "Teléfono #1"
            '
            'lblTelefono2_Encargado
            '
            Me.lblTelefono2_Encargado.AutoSize = True
            Me.lblTelefono2_Encargado.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblTelefono2_Encargado.Location = New System.Drawing.Point(329, 16)
            Me.lblTelefono2_Encargado.Name = "lblTelefono2_Encargado"
            Me.lblTelefono2_Encargado.Size = New System.Drawing.Size(71, 15)
            Me.lblTelefono2_Encargado.TabIndex = 1
            Me.lblTelefono2_Encargado.Text = "Teléfono #2"
            '
            'txtNombre_Encargado
            '
            Me.txtNombre_Encargado.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtNombre_Encargado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombre_Encargado.Location = New System.Drawing.Point(9, 32)
            Me.txtNombre_Encargado.MaxLength = 40
            Me.txtNombre_Encargado.Name = "txtNombre_Encargado"
            Me.txtNombre_Encargado.Size = New System.Drawing.Size(240, 20)
            Me.txtNombre_Encargado.TabIndex = 10
            '
            'dgvEncargados
            '
            Me.dgvEncargados.AllowUserToAddRows = False
            Me.dgvEncargados.AllowUserToDeleteRows = False
            Me.dgvEncargados.AllowUserToResizeColumns = False
            Me.dgvEncargados.AllowUserToResizeRows = False
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvEncargados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
            Me.dgvEncargados.BackgroundColor = System.Drawing.Color.White
            Me.dgvEncargados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvEncargados.Cursor = System.Windows.Forms.Cursors.Hand
            Me.dgvEncargados.Location = New System.Drawing.Point(12, 100)
            Me.dgvEncargados.MultiSelect = False
            Me.dgvEncargados.Name = "dgvEncargados"
            Me.dgvEncargados.ReadOnly = True
            Me.dgvEncargados.RowHeadersVisible = False
            DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvEncargados.RowsDefaultCellStyle = DataGridViewCellStyle9
            Me.dgvEncargados.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvEncargados.RowTemplate.Height = 18
            Me.dgvEncargados.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvEncargados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvEncargados.Size = New System.Drawing.Size(600, 155)
            Me.dgvEncargados.TabIndex = 41
            '
            'txtId_Encargado
            '
            Me.txtId_Encargado.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtId_Encargado.Enabled = False
            Me.txtId_Encargado.Location = New System.Drawing.Point(546, 111)
            Me.txtId_Encargado.Name = "txtId_Encargado"
            Me.txtId_Encargado.Size = New System.Drawing.Size(50, 23)
            Me.txtId_Encargado.TabIndex = 20
            Me.txtId_Encargado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.txtId_Encargado.Visible = False
            '
            'errDerechoProveedor
            '
            Me.errDerechoProveedor.BlinkRate = 20
            Me.errDerechoProveedor.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
            Me.errDerechoProveedor.ContainerControl = Me
            '
            'MnEliminarAgente
            '
            Me.MnEliminarAgente.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarToolStripMenuItem})
            Me.MnEliminarAgente.Name = "ContextMenuStrip1"
            Me.MnEliminarAgente.Size = New System.Drawing.Size(118, 26)
            '
            'EliminarToolStripMenuItem
            '
            Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
            Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
            Me.EliminarToolStripMenuItem.Text = "Eliminar"
            '
            'errIzqProveedor
            '
            Me.errIzqProveedor.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
            Me.errIzqProveedor.ContainerControl = Me
            Me.errIzqProveedor.RightToLeft = True
            '
            'dgvProveedores
            '
            Me.dgvProveedores.AllowUserToAddRows = False
            Me.dgvProveedores.AllowUserToDeleteRows = False
            Me.dgvProveedores.AllowUserToResizeColumns = False
            Me.dgvProveedores.AllowUserToResizeRows = False
            Me.dgvProveedores.BackgroundColor = System.Drawing.Color.White
            Me.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvProveedores.Location = New System.Drawing.Point(66, 107)
            Me.dgvProveedores.MultiSelect = False
            Me.dgvProveedores.Name = "dgvProveedores"
            Me.dgvProveedores.ReadOnly = True
            Me.dgvProveedores.RowHeadersVisible = False
            DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvProveedores.RowsDefaultCellStyle = DataGridViewCellStyle10
            Me.dgvProveedores.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvProveedores.RowTemplate.Height = 18
            Me.dgvProveedores.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvProveedores.Size = New System.Drawing.Size(318, 122)
            Me.dgvProveedores.TabIndex = 49
            Me.dgvProveedores.Visible = False
            '
            'MnEliminarEncargado
            '
            Me.MnEliminarEncargado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarToolStripMenuItem1})
            Me.MnEliminarEncargado.Name = "MnEliminarEncargado"
            Me.MnEliminarEncargado.Size = New System.Drawing.Size(118, 26)
            '
            'EliminarToolStripMenuItem1
            '
            Me.EliminarToolStripMenuItem1.Name = "EliminarToolStripMenuItem1"
            Me.EliminarToolStripMenuItem1.Size = New System.Drawing.Size(117, 22)
            Me.EliminarToolStripMenuItem1.Text = "Eliminar"
            '
            'lblDireccion
            '
            Me.lblDireccion.AutoSize = True
            Me.lblDireccion.BackColor = System.Drawing.Color.Transparent
            Me.lblDireccion.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDireccion.Location = New System.Drawing.Point(10, 153)
            Me.lblDireccion.Name = "lblDireccion"
            Me.lblDireccion.Size = New System.Drawing.Size(59, 15)
            Me.lblDireccion.TabIndex = 49
            Me.lblDireccion.Text = "Dirección"
            '
            'txtDireccion
            '
            Me.txtDireccion.Location = New System.Drawing.Point(13, 171)
            Me.txtDireccion.MaxLength = 75
            Me.txtDireccion.Name = "txtDireccion"
            Me.txtDireccion.Size = New System.Drawing.Size(521, 20)
            Me.txtDireccion.TabIndex = 50
            '
            'lblCorreo
            '
            Me.lblCorreo.AutoSize = True
            Me.lblCorreo.BackColor = System.Drawing.Color.Transparent
            Me.lblCorreo.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCorreo.Location = New System.Drawing.Point(426, 114)
            Me.lblCorreo.Name = "lblCorreo"
            Me.lblCorreo.Size = New System.Drawing.Size(111, 15)
            Me.lblCorreo.TabIndex = 51
            Me.lblCorreo.Text = "Correo Eléctronico"
            '
            'txtCorreo
            '
            Me.txtCorreo.Location = New System.Drawing.Point(414, 132)
            Me.txtCorreo.MaxLength = 50
            Me.txtCorreo.Name = "txtCorreo"
            Me.txtCorreo.Size = New System.Drawing.Size(216, 20)
            Me.txtCorreo.TabIndex = 52
            '
            'txtCC
            '
            Me.txtCC.Location = New System.Drawing.Point(10, 132)
            Me.txtCC.MaxLength = 60
            Me.txtCC.Name = "txtCC"
            Me.txtCC.Size = New System.Drawing.Size(400, 20)
            Me.txtCC.TabIndex = 54
            '
            'lblCC
            '
            Me.lblCC.AutoSize = True
            Me.lblCC.BackColor = System.Drawing.Color.Transparent
            Me.lblCC.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCC.Location = New System.Drawing.Point(10, 114)
            Me.lblCC.Name = "lblCC"
            Me.lblCC.Size = New System.Drawing.Size(80, 15)
            Me.lblCC.TabIndex = 53
            Me.lblCC.Text = "Nombre Real"
            '
            'txtCedula
            '
            Me.txtCedula.Location = New System.Drawing.Point(499, 86)
            Me.txtCedula.MaxLength = 50
            Me.txtCedula.Name = "txtCedula"
            Me.txtCedula.Size = New System.Drawing.Size(131, 20)
            Me.txtCedula.TabIndex = 56
            '
            'lblCedula
            '
            Me.lblCedula.AutoSize = True
            Me.lblCedula.BackColor = System.Drawing.Color.Transparent
            Me.lblCedula.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCedula.Location = New System.Drawing.Point(496, 68)
            Me.lblCedula.Name = "lblCedula"
            Me.lblCedula.Size = New System.Drawing.Size(44, 15)
            Me.lblCedula.TabIndex = 55
            Me.lblCedula.Text = "Cédula"
            '
            'btnListadosPendientes
            '
            Me.btnListadosPendientes.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnListadosPendientes.Image = Global.Presentacion.My.Resources.Resources.e_listados
            Me.btnListadosPendientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnListadosPendientes.Location = New System.Drawing.Point(547, 0)
            Me.btnListadosPendientes.Name = "btnListadosPendientes"
            Me.btnListadosPendientes.Size = New System.Drawing.Size(81, 80)
            Me.btnListadosPendientes.TabIndex = 81
            Me.btnListadosPendientes.Text = "Lista Proveedores"
            Me.btnListadosPendientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnListadosPendientes.UseVisualStyleBackColor = True
            '
            'btnLimpiar
            '
            Me.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnLimpiar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnLimpiar.Image = Global.Presentacion.My.Resources.Resources.Limpiar
            Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnLimpiar.Location = New System.Drawing.Point(140, 0)
            Me.btnLimpiar.Name = "btnLimpiar"
            Me.btnLimpiar.Size = New System.Drawing.Size(71, 57)
            Me.btnLimpiar.TabIndex = 20
            Me.btnLimpiar.Text = "Limpiar"
            Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnLimpiar.UseVisualStyleBackColor = True
            '
            'btnInsertar
            '
            Me.btnInsertar.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnInsertar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnInsertar.Image = Global.Presentacion.My.Resources.Resources.Guardar
            Me.btnInsertar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnInsertar.Location = New System.Drawing.Point(0, 0)
            Me.btnInsertar.Name = "btnInsertar"
            Me.btnInsertar.Size = New System.Drawing.Size(71, 57)
            Me.btnInsertar.TabIndex = 21
            Me.btnInsertar.Text = "Guardar"
            Me.btnInsertar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnInsertar.UseVisualStyleBackColor = True
            '
            'btnEliminar
            '
            Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnEliminar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliminar.Image = Global.Presentacion.My.Resources.Resources.Eliminar
            Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnEliminar.Location = New System.Drawing.Point(70, 0)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(71, 57)
            Me.btnEliminar.TabIndex = 23
            Me.btnEliminar.Text = "Eliminar"
            Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnEliminar.UseVisualStyleBackColor = True
            '
            'lblN_Cuenta
            '
            Me.lblN_Cuenta.AutoSize = True
            Me.lblN_Cuenta.Location = New System.Drawing.Point(557, 155)
            Me.lblN_Cuenta.Name = "lblN_Cuenta"
            Me.lblN_Cuenta.Size = New System.Drawing.Size(54, 13)
            Me.lblN_Cuenta.TabIndex = 82
            Me.lblN_Cuenta.Text = "N° Cliente"
            '
            'txtNum_Cuenta
            '
            Me.txtNum_Cuenta.Location = New System.Drawing.Point(558, 171)
            Me.txtNum_Cuenta.MaxLength = 6
            Me.txtNum_Cuenta.Name = "txtNum_Cuenta"
            Me.txtNum_Cuenta.Size = New System.Drawing.Size(64, 20)
            Me.txtNum_Cuenta.TabIndex = 83
            '
            'FrmProveedor
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.ClientSize = New System.Drawing.Size(640, 641)
            Me.Controls.Add(Me.dgvProveedores)
            Me.Controls.Add(Me.txtNum_Cuenta)
            Me.Controls.Add(Me.lblN_Cuenta)
            Me.Controls.Add(Me.btnListadosPendientes)
            Me.Controls.Add(Me.txtId_Proveedor)
            Me.Controls.Add(Me.txtDireccion)
            Me.Controls.Add(Me.lblId_Proveedor)
            Me.Controls.Add(Me.lblFax_Principal)
            Me.Controls.Add(Me.lblCedula)
            Me.Controls.Add(Me.txtCC)
            Me.Controls.Add(Me.lblCC)
            Me.Controls.Add(Me.btnLimpiar)
            Me.Controls.Add(Me.gbEncargados)
            Me.Controls.Add(Me.txtCorreo)
            Me.Controls.Add(Me.txtCentral_Telefonica)
            Me.Controls.Add(Me.btnInsertar)
            Me.Controls.Add(Me.txtNombre)
            Me.Controls.Add(Me.lblNombre)
            Me.Controls.Add(Me.btnEliminar)
            Me.Controls.Add(Me.gbAgente)
            Me.Controls.Add(Me.lblDireccion)
            Me.Controls.Add(Me.lblCorreo)
            Me.Controls.Add(Me.txtFax_Principal)
            Me.Controls.Add(Me.lblCentral_Telefonica)
            Me.Controls.Add(Me.txtCedula)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Name = "FrmProveedor"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Proveedores"
            CType(Me.dgvAgentes, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbAgente.ResumeLayout(False)
            Me.gbAgente.PerformLayout()
            Me.gbEncargados.ResumeLayout(False)
            Me.gbEncargados.PerformLayout()
            CType(Me.dgvEncargados, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.errDerechoProveedor, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MnEliminarAgente.ResumeLayout(False)
            CType(Me.errIzqProveedor, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MnEliminarEncargado.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents lblTelefono2 As System.Windows.Forms.Label
        Friend WithEvents lblTelefono1 As System.Windows.Forms.Label
        Friend WithEvents lblNombre_Agente As System.Windows.Forms.Label
        Friend WithEvents lblFax_Agente As System.Windows.Forms.Label
        Friend WithEvents btnLimpiar As System.Windows.Forms.Button
        Friend WithEvents btnInsertar As System.Windows.Forms.Button
        Friend WithEvents btnEliminar As System.Windows.Forms.Button
        Friend WithEvents txtTelefono1_Agente As System.Windows.Forms.TextBox
        Friend WithEvents txtNombre_Agente As System.Windows.Forms.TextBox
        Friend WithEvents txtTelefono2_Agente As System.Windows.Forms.TextBox
        Friend WithEvents txtFax_Agente As System.Windows.Forms.TextBox
        Friend WithEvents dgvAgentes As System.Windows.Forms.DataGridView
        Friend WithEvents txtNombre As System.Windows.Forms.TextBox
        Friend WithEvents txtId_Proveedor As System.Windows.Forms.TextBox
        Friend WithEvents lblNombre As System.Windows.Forms.Label
        Friend WithEvents lblId_Proveedor As System.Windows.Forms.Label
        Friend WithEvents txtCentral_Telefonica As System.Windows.Forms.TextBox
        Friend WithEvents lblCentral_Telefonica As System.Windows.Forms.Label
        Friend WithEvents txtFax_Principal As System.Windows.Forms.TextBox
        Friend WithEvents lblFax_Principal As System.Windows.Forms.Label
        Friend WithEvents gbAgente As System.Windows.Forms.GroupBox
        Friend WithEvents btnAgregar_Agente As System.Windows.Forms.Button
        Friend WithEvents gbEncargados As System.Windows.Forms.GroupBox
        Friend WithEvents txtTelefono2_Encargado As System.Windows.Forms.TextBox
        Friend WithEvents btnAgregar_Encargado As System.Windows.Forms.Button
        Friend WithEvents dgvEncargados As System.Windows.Forms.DataGridView
        Friend WithEvents txtFax_Encargado As System.Windows.Forms.TextBox
        Friend WithEvents txtNombre_Encargado As System.Windows.Forms.TextBox
        Friend WithEvents txtTelefono1_Encargado As System.Windows.Forms.TextBox
        Friend WithEvents txtServicio As System.Windows.Forms.TextBox
        Friend WithEvents txtId_Encargado As System.Windows.Forms.TextBox
        Friend WithEvents lblServicio As System.Windows.Forms.Label
        Friend WithEvents lblFax_Encargado As System.Windows.Forms.Label
        Friend WithEvents lblNombre_Encargado As System.Windows.Forms.Label
        Friend WithEvents lblTelefono1_Encargado As System.Windows.Forms.Label
        Friend WithEvents lblTelefono2_Encargado As System.Windows.Forms.Label
        Friend WithEvents txtExt1_Encargado As System.Windows.Forms.TextBox
        Friend WithEvents lblExt1_Encargado As System.Windows.Forms.Label
        Friend WithEvents txtExt2_Encargado As System.Windows.Forms.TextBox
        Friend WithEvents lblExt2_Encargado As System.Windows.Forms.Label
        Friend WithEvents errDerechoProveedor As System.Windows.Forms.ErrorProvider
        Friend WithEvents MnEliminarAgente As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents errIzqProveedor As System.Windows.Forms.ErrorProvider
        Friend WithEvents dgvProveedores As System.Windows.Forms.DataGridView
        Friend WithEvents txtId_Agente As System.Windows.Forms.TextBox
        Friend WithEvents MnEliminarEncargado As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents EliminarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
        Friend WithEvents lblDireccion As System.Windows.Forms.Label
        Friend WithEvents lblCorreo As System.Windows.Forms.Label
        Friend WithEvents txtCorreo As System.Windows.Forms.TextBox
        Friend WithEvents txtCC As System.Windows.Forms.TextBox
        Friend WithEvents lblCC As System.Windows.Forms.Label
        Friend WithEvents lblCedula As System.Windows.Forms.Label
        Friend WithEvents txtCedula As System.Windows.Forms.TextBox
        Friend WithEvents btnListadosPendientes As System.Windows.Forms.Button
        Friend WithEvents txtNum_Cuenta As System.Windows.Forms.TextBox
        Friend WithEvents lblN_Cuenta As System.Windows.Forms.Label
        Friend WithEvents txtCorreoEncargado As System.Windows.Forms.TextBox
        Friend WithEvents lblCorreoEncargado As System.Windows.Forms.Label
        Friend WithEvents txtCorreo_Agente As System.Windows.Forms.TextBox
        Friend WithEvents lblCorreo_Agente As System.Windows.Forms.Label
    End Class
End Namespace