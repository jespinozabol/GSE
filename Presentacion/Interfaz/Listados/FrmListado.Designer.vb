Namespace Interfaz.Listados
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmListado
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
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.dgvClientes = New System.Windows.Forms.DataGridView()
            Me.txtNombre = New System.Windows.Forms.TextBox()
            Me.lblNombre = New System.Windows.Forms.Label()
            Me.txtPrecio = New System.Windows.Forms.TextBox()
            Me.lblPrecio = New System.Windows.Forms.Label()
            Me.txtCodigo = New System.Windows.Forms.TextBox()
            Me.lblCodigo = New System.Windows.Forms.Label()
            Me.txtCantidad = New System.Windows.Forms.TextBox()
            Me.lblCantidad = New System.Windows.Forms.Label()
            Me.txtArticulo = New System.Windows.Forms.TextBox()
            Me.lblArticulo = New System.Windows.Forms.Label()
            Me.btnAgregar = New System.Windows.Forms.Button()
            Me.dgvProductos = New System.Windows.Forms.DataGridView()
            Me.Check = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvMostrarProductos = New System.Windows.Forms.DataGridView()
            Me.lbl3 = New System.Windows.Forms.Label()
            Me.lblMostrarTotal = New System.Windows.Forms.Label()
            Me.txtExistInventario = New System.Windows.Forms.TextBox()
            Me.lblExtInventario = New System.Windows.Forms.Label()
            Me.cmbAutorizados = New System.Windows.Forms.ComboBox()
            Me.lblRetira = New System.Windows.Forms.Label()
            Me.btnAgregarAutorizado = New System.Windows.Forms.Button()
            Me.txtId_Listado = New System.Windows.Forms.TextBox()
            Me.lblTelfCliente = New System.Windows.Forms.Label()
            Me.txtTelfCliente = New System.Windows.Forms.TextBox()
            Me.lbl1 = New System.Windows.Forms.Label()
            Me.lblCantLineas = New System.Windows.Forms.Label()
            Me.lbl2 = New System.Windows.Forms.Label()
            Me.lblNumFacturas = New System.Windows.Forms.Label()
            Me.txtFechaCreacion = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.chkTodos = New System.Windows.Forms.CheckBox()
            Me.lblMostrarTotalRestante = New System.Windows.Forms.Label()
            Me.lbl4 = New System.Windows.Forms.Label()
            Me.btnHistorial = New System.Windows.Forms.Button()
            Me.btnListadosPendientes = New System.Windows.Forms.Button()
            Me.btnFacturar = New System.Windows.Forms.Button()
            Me.btnGuardar = New System.Windows.Forms.Button()
            Me.btnImprimir = New System.Windows.Forms.Button()
            Me.btnEliminar = New System.Windows.Forms.Button()
            Me.btnLimpiar = New System.Windows.Forms.Button()
            Me.lblMostrarSubTotal = New System.Windows.Forms.Label()
            Me.lblTotalImpuesto = New System.Windows.Forms.Label()
            CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvMostrarProductos, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.dgvClientes.Cursor = System.Windows.Forms.Cursors.Hand
            Me.dgvClientes.GridColor = System.Drawing.Color.White
            Me.dgvClientes.Location = New System.Drawing.Point(12, 102)
            Me.dgvClientes.MultiSelect = False
            Me.dgvClientes.Name = "dgvClientes"
            Me.dgvClientes.ReadOnly = True
            Me.dgvClientes.RowHeadersVisible = False
            Me.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvClientes.Size = New System.Drawing.Size(287, 92)
            Me.dgvClientes.TabIndex = 74
            Me.dgvClientes.Visible = False
            '
            'txtNombre
            '
            Me.txtNombre.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtNombre.Location = New System.Drawing.Point(12, 81)
            Me.txtNombre.MaxLength = 45
            Me.txtNombre.Name = "txtNombre"
            Me.txtNombre.Size = New System.Drawing.Size(311, 20)
            Me.txtNombre.TabIndex = 0
            '
            'lblNombre
            '
            Me.lblNombre.AutoSize = True
            Me.lblNombre.BackColor = System.Drawing.Color.Transparent
            Me.lblNombre.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblNombre.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombre.Location = New System.Drawing.Point(16, 65)
            Me.lblNombre.Name = "lblNombre"
            Me.lblNombre.Size = New System.Drawing.Size(53, 15)
            Me.lblNombre.TabIndex = 69
            Me.lblNombre.Text = "Nombre"
            '
            'txtPrecio
            '
            Me.txtPrecio.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtPrecio.Enabled = False
            Me.txtPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPrecio.Location = New System.Drawing.Point(548, 173)
            Me.txtPrecio.MaxLength = 11
            Me.txtPrecio.Name = "txtPrecio"
            Me.txtPrecio.ReadOnly = True
            Me.txtPrecio.Size = New System.Drawing.Size(70, 20)
            Me.txtPrecio.TabIndex = 88
            Me.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblPrecio
            '
            Me.lblPrecio.AutoSize = True
            Me.lblPrecio.BackColor = System.Drawing.Color.Transparent
            Me.lblPrecio.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblPrecio.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPrecio.Location = New System.Drawing.Point(545, 158)
            Me.lblPrecio.Name = "lblPrecio"
            Me.lblPrecio.Size = New System.Drawing.Size(60, 15)
            Me.lblPrecio.TabIndex = 87
            Me.lblPrecio.Text = "Precio IVI"
            '
            'txtCodigo
            '
            Me.txtCodigo.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtCodigo.Location = New System.Drawing.Point(70, 174)
            Me.txtCodigo.MaxLength = 6
            Me.txtCodigo.Name = "txtCodigo"
            Me.txtCodigo.Size = New System.Drawing.Size(51, 20)
            Me.txtCodigo.TabIndex = 3
            '
            'lblCodigo
            '
            Me.lblCodigo.AutoSize = True
            Me.lblCodigo.BackColor = System.Drawing.Color.Transparent
            Me.lblCodigo.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblCodigo.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCodigo.Location = New System.Drawing.Point(69, 158)
            Me.lblCodigo.Name = "lblCodigo"
            Me.lblCodigo.Size = New System.Drawing.Size(45, 15)
            Me.lblCodigo.TabIndex = 85
            Me.lblCodigo.Text = "Código"
            '
            'txtCantidad
            '
            Me.txtCantidad.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtCantidad.Location = New System.Drawing.Point(14, 174)
            Me.txtCantidad.MaxLength = 8
            Me.txtCantidad.Name = "txtCantidad"
            Me.txtCantidad.Size = New System.Drawing.Size(55, 20)
            Me.txtCantidad.TabIndex = 2
            Me.txtCantidad.Text = "1"
            '
            'lblCantidad
            '
            Me.lblCantidad.AutoSize = True
            Me.lblCantidad.BackColor = System.Drawing.Color.Transparent
            Me.lblCantidad.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblCantidad.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCantidad.Location = New System.Drawing.Point(13, 158)
            Me.lblCantidad.Name = "lblCantidad"
            Me.lblCantidad.Size = New System.Drawing.Size(55, 15)
            Me.lblCantidad.TabIndex = 83
            Me.lblCantidad.Text = "Cantidad"
            '
            'txtArticulo
            '
            Me.txtArticulo.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtArticulo.Location = New System.Drawing.Point(121, 174)
            Me.txtArticulo.MaxLength = 65
            Me.txtArticulo.Name = "txtArticulo"
            Me.txtArticulo.Size = New System.Drawing.Size(374, 20)
            Me.txtArticulo.TabIndex = 4
            '
            'lblArticulo
            '
            Me.lblArticulo.AutoSize = True
            Me.lblArticulo.BackColor = System.Drawing.Color.Transparent
            Me.lblArticulo.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblArticulo.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblArticulo.Location = New System.Drawing.Point(124, 158)
            Me.lblArticulo.Name = "lblArticulo"
            Me.lblArticulo.Size = New System.Drawing.Size(51, 15)
            Me.lblArticulo.TabIndex = 81
            Me.lblArticulo.Text = "Artículo"
            '
            'btnAgregar
            '
            Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnAgregar.Location = New System.Drawing.Point(624, 171)
            Me.btnAgregar.Name = "btnAgregar"
            Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
            Me.btnAgregar.TabIndex = 5
            Me.btnAgregar.Text = "Agregar"
            Me.btnAgregar.UseVisualStyleBackColor = True
            '
            'dgvProductos
            '
            Me.dgvProductos.AllowUserToAddRows = False
            Me.dgvProductos.AllowUserToDeleteRows = False
            Me.dgvProductos.AllowUserToResizeColumns = False
            Me.dgvProductos.AllowUserToResizeRows = False
            Me.dgvProductos.BackgroundColor = System.Drawing.Color.White
            Me.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
            Me.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Check, Me.Cantidad, Me.Codigo, Me.Descripcion})
            Me.dgvProductos.Cursor = System.Windows.Forms.Cursors.Hand
            Me.dgvProductos.GridColor = System.Drawing.Color.White
            Me.dgvProductos.Location = New System.Drawing.Point(7, 198)
            Me.dgvProductos.MultiSelect = False
            Me.dgvProductos.Name = "dgvProductos"
            Me.dgvProductos.RowHeadersVisible = False
            Me.dgvProductos.RowTemplate.Height = 19
            Me.dgvProductos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
            Me.dgvProductos.Size = New System.Drawing.Size(707, 276)
            Me.dgvProductos.TabIndex = 92
            '
            'Check
            '
            Me.Check.HeaderText = ""
            Me.Check.Name = "Check"
            Me.Check.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.Check.Width = 19
            '
            'Cantidad
            '
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle2
            Me.Cantidad.HeaderText = "Cantidad"
            Me.Cantidad.Name = "Cantidad"
            Me.Cantidad.ReadOnly = True
            Me.Cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.Cantidad.Width = 80
            '
            'Codigo
            '
            Me.Codigo.HeaderText = "Código"
            Me.Codigo.Name = "Codigo"
            Me.Codigo.ReadOnly = True
            Me.Codigo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.Codigo.Width = 80
            '
            'Descripcion
            '
            Me.Descripcion.HeaderText = "Descripción"
            Me.Descripcion.Name = "Descripcion"
            Me.Descripcion.ReadOnly = True
            Me.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.Descripcion.Width = 500
            '
            'dgvMostrarProductos
            '
            Me.dgvMostrarProductos.AllowUserToAddRows = False
            Me.dgvMostrarProductos.AllowUserToDeleteRows = False
            Me.dgvMostrarProductos.AllowUserToResizeColumns = False
            Me.dgvMostrarProductos.AllowUserToResizeRows = False
            Me.dgvMostrarProductos.BackgroundColor = System.Drawing.Color.White
            Me.dgvMostrarProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvMostrarProductos.Cursor = System.Windows.Forms.Cursors.Hand
            Me.dgvMostrarProductos.GridColor = System.Drawing.Color.White
            Me.dgvMostrarProductos.Location = New System.Drawing.Point(70, 195)
            Me.dgvMostrarProductos.MultiSelect = False
            Me.dgvMostrarProductos.Name = "dgvMostrarProductos"
            Me.dgvMostrarProductos.ReadOnly = True
            Me.dgvMostrarProductos.RowHeadersVisible = False
            Me.dgvMostrarProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvMostrarProductos.Size = New System.Drawing.Size(425, 113)
            Me.dgvMostrarProductos.TabIndex = 93
            Me.dgvMostrarProductos.Visible = False
            '
            'lbl3
            '
            Me.lbl3.AutoSize = True
            Me.lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbl3.Location = New System.Drawing.Point(480, 480)
            Me.lbl3.Name = "lbl3"
            Me.lbl3.Size = New System.Drawing.Size(140, 13)
            Me.lbl3.TabIndex = 94
            Me.lbl3.Text = "TOTAL A FACTURAR¢:"
            '
            'lblMostrarTotal
            '
            Me.lblMostrarTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarTotal.ForeColor = System.Drawing.Color.Red
            Me.lblMostrarTotal.Location = New System.Drawing.Point(612, 478)
            Me.lblMostrarTotal.Name = "lblMostrarTotal"
            Me.lblMostrarTotal.Size = New System.Drawing.Size(107, 23)
            Me.lblMostrarTotal.TabIndex = 95
            Me.lblMostrarTotal.Text = "0.00"
            Me.lblMostrarTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtExistInventario
            '
            Me.txtExistInventario.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtExistInventario.Enabled = False
            Me.txtExistInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtExistInventario.Location = New System.Drawing.Point(497, 173)
            Me.txtExistInventario.MaxLength = 7
            Me.txtExistInventario.Name = "txtExistInventario"
            Me.txtExistInventario.ReadOnly = True
            Me.txtExistInventario.Size = New System.Drawing.Size(48, 20)
            Me.txtExistInventario.TabIndex = 97
            Me.txtExistInventario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblExtInventario
            '
            Me.lblExtInventario.AutoSize = True
            Me.lblExtInventario.BackColor = System.Drawing.Color.Transparent
            Me.lblExtInventario.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblExtInventario.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblExtInventario.Location = New System.Drawing.Point(494, 158)
            Me.lblExtInventario.Name = "lblExtInventario"
            Me.lblExtInventario.Size = New System.Drawing.Size(48, 15)
            Me.lblExtInventario.TabIndex = 96
            Me.lblExtInventario.Text = "E-Stock"
            '
            'cmbAutorizados
            '
            Me.cmbAutorizados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbAutorizados.FormattingEnabled = True
            Me.cmbAutorizados.Location = New System.Drawing.Point(14, 122)
            Me.cmbAutorizados.MaxDropDownItems = 40
            Me.cmbAutorizados.MaxLength = 40
            Me.cmbAutorizados.Name = "cmbAutorizados"
            Me.cmbAutorizados.Size = New System.Drawing.Size(309, 21)
            Me.cmbAutorizados.TabIndex = 101
            '
            'lblRetira
            '
            Me.lblRetira.AutoSize = True
            Me.lblRetira.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblRetira.Location = New System.Drawing.Point(16, 105)
            Me.lblRetira.Name = "lblRetira"
            Me.lblRetira.Size = New System.Drawing.Size(88, 15)
            Me.lblRetira.TabIndex = 102
            Me.lblRetira.Text = "Retira/Devulve"
            '
            'btnAgregarAutorizado
            '
            Me.btnAgregarAutorizado.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnAgregarAutorizado.Location = New System.Drawing.Point(329, 119)
            Me.btnAgregarAutorizado.Name = "btnAgregarAutorizado"
            Me.btnAgregarAutorizado.Size = New System.Drawing.Size(99, 25)
            Me.btnAgregarAutorizado.TabIndex = 103
            Me.btnAgregarAutorizado.Text = "Agrega/Modifica"
            Me.btnAgregarAutorizado.UseVisualStyleBackColor = True
            '
            'txtId_Listado
            '
            Me.txtId_Listado.Location = New System.Drawing.Point(70, 58)
            Me.txtId_Listado.Name = "txtId_Listado"
            Me.txtId_Listado.ReadOnly = True
            Me.txtId_Listado.Size = New System.Drawing.Size(42, 20)
            Me.txtId_Listado.TabIndex = 106
            Me.txtId_Listado.Visible = False
            '
            'lblTelfCliente
            '
            Me.lblTelfCliente.AutoSize = True
            Me.lblTelfCliente.Location = New System.Drawing.Point(325, 65)
            Me.lblTelfCliente.Name = "lblTelfCliente"
            Me.lblTelfCliente.Size = New System.Drawing.Size(49, 13)
            Me.lblTelfCliente.TabIndex = 108
            Me.lblTelfCliente.Text = "Teléfono"
            '
            'txtTelfCliente
            '
            Me.txtTelfCliente.Location = New System.Drawing.Point(328, 81)
            Me.txtTelfCliente.MaxLength = 9
            Me.txtTelfCliente.Name = "txtTelfCliente"
            Me.txtTelfCliente.Size = New System.Drawing.Size(87, 20)
            Me.txtTelfCliente.TabIndex = 1
            '
            'lbl1
            '
            Me.lbl1.AutoSize = True
            Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbl1.Location = New System.Drawing.Point(8, 483)
            Me.lbl1.Name = "lbl1"
            Me.lbl1.Size = New System.Drawing.Size(88, 13)
            Me.lbl1.TabIndex = 110
            Me.lbl1.Text = "Cantidad Líneas:"
            '
            'lblCantLineas
            '
            Me.lblCantLineas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCantLineas.Location = New System.Drawing.Point(97, 478)
            Me.lblCantLineas.Name = "lblCantLineas"
            Me.lblCantLineas.Size = New System.Drawing.Size(32, 23)
            Me.lblCantLineas.TabIndex = 111
            Me.lblCantLineas.Text = "0"
            Me.lblCantLineas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lbl2
            '
            Me.lbl2.AutoSize = True
            Me.lbl2.Location = New System.Drawing.Point(135, 483)
            Me.lbl2.Name = "lbl2"
            Me.lbl2.Size = New System.Drawing.Size(96, 13)
            Me.lbl2.TabIndex = 112
            Me.lbl2.Text = "Cantidad Facturas:"
            '
            'lblNumFacturas
            '
            Me.lblNumFacturas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNumFacturas.Location = New System.Drawing.Point(230, 478)
            Me.lblNumFacturas.Name = "lblNumFacturas"
            Me.lblNumFacturas.Size = New System.Drawing.Size(32, 23)
            Me.lblNumFacturas.TabIndex = 113
            Me.lblNumFacturas.Text = "0"
            Me.lblNumFacturas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'txtFechaCreacion
            '
            Me.txtFechaCreacion.Enabled = False
            Me.txtFechaCreacion.Location = New System.Drawing.Point(421, 81)
            Me.txtFechaCreacion.MaxLength = 8
            Me.txtFechaCreacion.Name = "txtFechaCreacion"
            Me.txtFechaCreacion.Size = New System.Drawing.Size(87, 20)
            Me.txtFechaCreacion.TabIndex = 115
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(418, 65)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(82, 13)
            Me.Label1.TabIndex = 116
            Me.Label1.Text = "Fecha Creación"
            '
            'chkTodos
            '
            Me.chkTodos.AutoSize = True
            Me.chkTodos.Checked = True
            Me.chkTodos.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkTodos.Location = New System.Drawing.Point(15, 203)
            Me.chkTodos.Name = "chkTodos"
            Me.chkTodos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.chkTodos.Size = New System.Drawing.Size(15, 14)
            Me.chkTodos.TabIndex = 117
            Me.chkTodos.UseVisualStyleBackColor = True
            '
            'lblMostrarTotalRestante
            '
            Me.lblMostrarTotalRestante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarTotalRestante.ForeColor = System.Drawing.Color.Red
            Me.lblMostrarTotalRestante.Location = New System.Drawing.Point(375, 477)
            Me.lblMostrarTotalRestante.Name = "lblMostrarTotalRestante"
            Me.lblMostrarTotalRestante.Size = New System.Drawing.Size(107, 23)
            Me.lblMostrarTotalRestante.TabIndex = 119
            Me.lblMostrarTotalRestante.Text = "0.00"
            Me.lblMostrarTotalRestante.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lbl4
            '
            Me.lbl4.AutoSize = True
            Me.lbl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbl4.Location = New System.Drawing.Point(254, 481)
            Me.lbl4.Name = "lbl4"
            Me.lbl4.Size = New System.Drawing.Size(122, 13)
            Me.lbl4.TabIndex = 118
            Me.lbl4.Text = "TOTAL EN LISTA ¢:"
            '
            'btnHistorial
            '
            Me.btnHistorial.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnHistorial.Image = Global.Presentacion.My.Resources.Resources.Historial
            Me.btnHistorial.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnHistorial.Location = New System.Drawing.Point(514, 65)
            Me.btnHistorial.Name = "btnHistorial"
            Me.btnHistorial.Size = New System.Drawing.Size(72, 77)
            Me.btnHistorial.TabIndex = 114
            Me.btnHistorial.Text = "Ver Historial"
            Me.btnHistorial.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnHistorial.UseVisualStyleBackColor = True
            '
            'btnListadosPendientes
            '
            Me.btnListadosPendientes.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnListadosPendientes.Image = Global.Presentacion.My.Resources.Resources.e_listados
            Me.btnListadosPendientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnListadosPendientes.Location = New System.Drawing.Point(639, 65)
            Me.btnListadosPendientes.Name = "btnListadosPendientes"
            Me.btnListadosPendientes.Size = New System.Drawing.Size(72, 77)
            Me.btnListadosPendientes.TabIndex = 80
            Me.btnListadosPendientes.Text = "Listados Pendientes"
            Me.btnListadosPendientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnListadosPendientes.UseVisualStyleBackColor = True
            '
            'btnFacturar
            '
            Me.btnFacturar.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnFacturar.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnFacturar.Image = Global.Presentacion.My.Resources.Resources.facturar
            Me.btnFacturar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnFacturar.Location = New System.Drawing.Point(126, 0)
            Me.btnFacturar.Name = "btnFacturar"
            Me.btnFacturar.Size = New System.Drawing.Size(64, 52)
            Me.btnFacturar.TabIndex = 36
            Me.btnFacturar.Text = "Facturar"
            Me.btnFacturar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnFacturar.UseVisualStyleBackColor = True
            '
            'btnGuardar
            '
            Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnGuardar.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = Global.Presentacion.My.Resources.Resources.Guardar
            Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnGuardar.Location = New System.Drawing.Point(0, 0)
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(64, 52)
            Me.btnGuardar.TabIndex = 37
            Me.btnGuardar.Text = "Guardar"
            Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnGuardar.UseVisualStyleBackColor = True
            '
            'btnImprimir
            '
            Me.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnImprimir.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnImprimir.Image = Global.Presentacion.My.Resources.Resources.Imprimir
            Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnImprimir.Location = New System.Drawing.Point(63, 0)
            Me.btnImprimir.Name = "btnImprimir"
            Me.btnImprimir.Size = New System.Drawing.Size(64, 52)
            Me.btnImprimir.TabIndex = 32
            Me.btnImprimir.Text = "Imprimir"
            Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnImprimir.UseVisualStyleBackColor = True
            '
            'btnEliminar
            '
            Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnEliminar.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliminar.Image = Global.Presentacion.My.Resources.Resources.Eliminar
            Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnEliminar.Location = New System.Drawing.Point(189, 0)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(64, 52)
            Me.btnEliminar.TabIndex = 33
            Me.btnEliminar.Text = "Eliminar"
            Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnEliminar.UseVisualStyleBackColor = True
            '
            'btnLimpiar
            '
            Me.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnLimpiar.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnLimpiar.Image = Global.Presentacion.My.Resources.Resources.Limpiar
            Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnLimpiar.Location = New System.Drawing.Point(252, 0)
            Me.btnLimpiar.Name = "btnLimpiar"
            Me.btnLimpiar.Size = New System.Drawing.Size(64, 52)
            Me.btnLimpiar.TabIndex = 31
            Me.btnLimpiar.Text = "Limpiar"
            Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnLimpiar.UseVisualStyleBackColor = True
            '
            'lblMostrarSubTotal
            '
            Me.lblMostrarSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarSubTotal.ForeColor = System.Drawing.Color.Red
            Me.lblMostrarSubTotal.Location = New System.Drawing.Point(592, 407)
            Me.lblMostrarSubTotal.Name = "lblMostrarSubTotal"
            Me.lblMostrarSubTotal.Size = New System.Drawing.Size(107, 21)
            Me.lblMostrarSubTotal.TabIndex = 120
            Me.lblMostrarSubTotal.Text = "0.00"
            Me.lblMostrarSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.lblMostrarSubTotal.Visible = False
            '
            'lblTotalImpuesto
            '
            Me.lblTotalImpuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotalImpuesto.ForeColor = System.Drawing.Color.Red
            Me.lblTotalImpuesto.Location = New System.Drawing.Point(592, 439)
            Me.lblTotalImpuesto.Name = "lblTotalImpuesto"
            Me.lblTotalImpuesto.Size = New System.Drawing.Size(107, 21)
            Me.lblTotalImpuesto.TabIndex = 121
            Me.lblTotalImpuesto.Text = "0.00"
            Me.lblTotalImpuesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.lblTotalImpuesto.Visible = False
            '
            'FrmListado
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.ClientSize = New System.Drawing.Size(726, 503)
            Me.Controls.Add(Me.dgvMostrarProductos)
            Me.Controls.Add(Me.dgvProductos)
            Me.Controls.Add(Me.lblTotalImpuesto)
            Me.Controls.Add(Me.lblMostrarSubTotal)
            Me.Controls.Add(Me.dgvClientes)
            Me.Controls.Add(Me.lblMostrarTotalRestante)
            Me.Controls.Add(Me.lbl4)
            Me.Controls.Add(Me.chkTodos)
            Me.Controls.Add(Me.txtFechaCreacion)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.btnHistorial)
            Me.Controls.Add(Me.lblNumFacturas)
            Me.Controls.Add(Me.lbl2)
            Me.Controls.Add(Me.lblCantLineas)
            Me.Controls.Add(Me.lbl1)
            Me.Controls.Add(Me.txtTelfCliente)
            Me.Controls.Add(Me.lblTelfCliente)
            Me.Controls.Add(Me.txtId_Listado)
            Me.Controls.Add(Me.btnAgregarAutorizado)
            Me.Controls.Add(Me.lblRetira)
            Me.Controls.Add(Me.cmbAutorizados)
            Me.Controls.Add(Me.txtExistInventario)
            Me.Controls.Add(Me.lblExtInventario)
            Me.Controls.Add(Me.lblMostrarTotal)
            Me.Controls.Add(Me.lbl3)
            Me.Controls.Add(Me.btnAgregar)
            Me.Controls.Add(Me.txtPrecio)
            Me.Controls.Add(Me.lblPrecio)
            Me.Controls.Add(Me.txtCodigo)
            Me.Controls.Add(Me.lblCodigo)
            Me.Controls.Add(Me.txtCantidad)
            Me.Controls.Add(Me.lblCantidad)
            Me.Controls.Add(Me.txtArticulo)
            Me.Controls.Add(Me.lblArticulo)
            Me.Controls.Add(Me.btnListadosPendientes)
            Me.Controls.Add(Me.txtNombre)
            Me.Controls.Add(Me.lblNombre)
            Me.Controls.Add(Me.btnFacturar)
            Me.Controls.Add(Me.btnGuardar)
            Me.Controls.Add(Me.btnImprimir)
            Me.Controls.Add(Me.btnEliminar)
            Me.Controls.Add(Me.btnLimpiar)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmListado"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Listado"
            CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvMostrarProductos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents btnImprimir As System.Windows.Forms.Button
        Friend WithEvents btnEliminar As System.Windows.Forms.Button
        Friend WithEvents btnLimpiar As System.Windows.Forms.Button
        Friend WithEvents btnFacturar As System.Windows.Forms.Button
        Friend WithEvents btnGuardar As System.Windows.Forms.Button
        Friend WithEvents dgvClientes As System.Windows.Forms.DataGridView
        Friend WithEvents txtNombre As System.Windows.Forms.TextBox
        Friend WithEvents lblNombre As System.Windows.Forms.Label
        Friend WithEvents btnListadosPendientes As System.Windows.Forms.Button
        Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
        Friend WithEvents lblPrecio As System.Windows.Forms.Label
        Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
        Friend WithEvents lblCodigo As System.Windows.Forms.Label
        Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
        Friend WithEvents lblCantidad As System.Windows.Forms.Label
        Friend WithEvents txtArticulo As System.Windows.Forms.TextBox
        Friend WithEvents lblArticulo As System.Windows.Forms.Label
        Friend WithEvents btnAgregar As System.Windows.Forms.Button
        Friend WithEvents dgvProductos As System.Windows.Forms.DataGridView
        Friend WithEvents dgvMostrarProductos As System.Windows.Forms.DataGridView
        Friend WithEvents lbl3 As System.Windows.Forms.Label
        Friend WithEvents lblMostrarTotal As System.Windows.Forms.Label
        Friend WithEvents txtExistInventario As System.Windows.Forms.TextBox
        Friend WithEvents lblExtInventario As System.Windows.Forms.Label
        Friend WithEvents cmbAutorizados As System.Windows.Forms.ComboBox
        Friend WithEvents lblRetira As System.Windows.Forms.Label
        Friend WithEvents btnAgregarAutorizado As System.Windows.Forms.Button
        Friend WithEvents txtId_Listado As System.Windows.Forms.TextBox
        Friend WithEvents reloj As System.Windows.Forms.Timer
        Friend WithEvents lblTelfCliente As System.Windows.Forms.Label
        Friend WithEvents txtTelfCliente As System.Windows.Forms.TextBox
        Friend WithEvents lbl1 As System.Windows.Forms.Label
        Friend WithEvents lblCantLineas As System.Windows.Forms.Label
        Friend WithEvents lbl2 As System.Windows.Forms.Label
        Friend WithEvents lblNumFacturas As System.Windows.Forms.Label
        Friend WithEvents btnHistorial As System.Windows.Forms.Button
        Friend WithEvents txtFechaCreacion As System.Windows.Forms.TextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
        Friend WithEvents Check As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents lblMostrarTotalRestante As System.Windows.Forms.Label
        Friend WithEvents lbl4 As System.Windows.Forms.Label
        Friend WithEvents lblMostrarSubTotal As System.Windows.Forms.Label
        Friend WithEvents lblTotalImpuesto As System.Windows.Forms.Label
    End Class
End Namespace