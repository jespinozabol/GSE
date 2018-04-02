Namespace Interfaz.Facturas
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmFacturar
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
            Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.dgvClientes = New System.Windows.Forms.DataGridView()
            Me.lblNumFacturas = New System.Windows.Forms.Label()
            Me.lbl2 = New System.Windows.Forms.Label()
            Me.lblCantLineas = New System.Windows.Forms.Label()
            Me.Timer = New System.Windows.Forms.Timer(Me.components)
            Me.txtDescuentoGen = New System.Windows.Forms.TextBox()
            Me.chkDescuento = New System.Windows.Forms.CheckBox()
            Me.txtImpuesto = New System.Windows.Forms.TextBox()
            Me.chkImpuesto = New System.Windows.Forms.CheckBox()
            Me.lbl1 = New System.Windows.Forms.Label()
            Me.lblNombreTipo = New System.Windows.Forms.Label()
            Me.lblMostrarTotal = New System.Windows.Forms.Label()
            Me.lblMensajeTipo = New System.Windows.Forms.Label()
            Me.lblDiasPlazo = New System.Windows.Forms.Label()
            Me.gbDESC = New System.Windows.Forms.GroupBox()
            Me.txtFecha = New System.Windows.Forms.TextBox()
            Me.gbFechas = New System.Windows.Forms.GroupBox()
            Me.txtDiasPlazo = New System.Windows.Forms.TextBox()
            Me.lblFecha = New System.Windows.Forms.Label()
            Me.lblMostrarNumFactura = New System.Windows.Forms.Label()
            Me.lblMostrarIV = New System.Windows.Forms.Label()
            Me.lblMostrarDesc = New System.Windows.Forms.Label()
            Me.lblMostrarSubTotal = New System.Windows.Forms.Label()
            Me.lblTotal = New System.Windows.Forms.Label()
            Me.lblTotalIV = New System.Windows.Forms.Label()
            Me.lblTotalDesc = New System.Windows.Forms.Label()
            Me.lblSubTotal = New System.Windows.Forms.Label()
            Me.btnAgregar = New System.Windows.Forms.Button()
            Me.txtDescuento = New System.Windows.Forms.TextBox()
            Me.lblDescuento = New System.Windows.Forms.Label()
            Me.txtPrecioIVI = New System.Windows.Forms.TextBox()
            Me.lblPrecioIVI = New System.Windows.Forms.Label()
            Me.txtExistencias = New System.Windows.Forms.TextBox()
            Me.lblExistencias = New System.Windows.Forms.Label()
            Me.txtPrecio = New System.Windows.Forms.TextBox()
            Me.lblPrecio = New System.Windows.Forms.Label()
            Me.txtCodigo = New System.Windows.Forms.TextBox()
            Me.lblCodigo = New System.Windows.Forms.Label()
            Me.txtCantidad = New System.Windows.Forms.TextBox()
            Me.lblCantidad = New System.Windows.Forms.Label()
            Me.txtArticulo = New System.Windows.Forms.TextBox()
            Me.lblArticulo = New System.Windows.Forms.Label()
            Me.txtNombre_Referencia = New System.Windows.Forms.TextBox()
            Me.txtId_Referencia = New System.Windows.Forms.TextBox()
            Me.chkReferencia = New System.Windows.Forms.CheckBox()
            Me.btnCorregir = New System.Windows.Forms.Button()
            Me.txtCedula = New System.Windows.Forms.TextBox()
            Me.lblCedula = New System.Windows.Forms.Label()
            Me.txtId_Cliente = New System.Windows.Forms.TextBox()
            Me.lblId_Cliente = New System.Windows.Forms.Label()
            Me.gbTipo = New System.Windows.Forms.GroupBox()
            Me.rbCredito = New System.Windows.Forms.RadioButton()
            Me.rbContado = New System.Windows.Forms.RadioButton()
            Me.lblNumFactura = New System.Windows.Forms.Label()
            Me.lblNombre_Referencia = New System.Windows.Forms.Label()
            Me.lblId_Referencia = New System.Windows.Forms.Label()
            Me.txtApellidos = New System.Windows.Forms.TextBox()
            Me.lblApellidos = New System.Windows.Forms.Label()
            Me.lblNombre = New System.Windows.Forms.Label()
            Me.txtNombre = New System.Windows.Forms.TextBox()
            Me.dgvMostrarProductos = New System.Windows.Forms.DataGridView()
            Me.dgvProductos = New System.Windows.Forms.DataGridView()
            Me.Cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Descripción = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.IV = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.SubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Adv = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.lblMensajeTipo2 = New System.Windows.Forms.Label()
            Me.btnAltO = New System.Windows.Forms.Button()
            Me.btnAltU = New System.Windows.Forms.Button()
            Me.lblEstado = New System.Windows.Forms.Label()
            Me.lblMostrarEstado = New System.Windows.Forms.Label()
            Me.lblMostrarDias = New System.Windows.Forms.Label()
            Me.lblDiasAtraso = New System.Windows.Forms.Label()
            Me.lblMostrarDisponible = New System.Windows.Forms.Label()
            Me.lblDisponible = New System.Windows.Forms.Label()
            Me.lblMostrarTipo = New System.Windows.Forms.Label()
            Me.lblTipo = New System.Windows.Forms.Label()
            Me.btnAltI = New System.Windows.Forms.Button()
            Me.gbIV = New System.Windows.Forms.GroupBox()
            Me.EliminFlu = New System.Windows.Forms.Timer(Me.components)
            Me.pnCredito = New System.Windows.Forms.Panel()
            Me.btnSacarBodega = New System.Windows.Forms.Button()
            Me.btnTrasladar = New System.Windows.Forms.Button()
            Me.btnCatalogo = New System.Windows.Forms.Button()
            Me.btnImprimir = New System.Windows.Forms.Button()
            Me.btnLimpiar = New System.Windows.Forms.Button()
            CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbDESC.SuspendLayout()
            Me.gbFechas.SuspendLayout()
            Me.gbTipo.SuspendLayout()
            CType(Me.dgvMostrarProductos, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbIV.SuspendLayout()
            Me.pnCredito.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgvClientes
            '
            Me.dgvClientes.AllowUserToAddRows = False
            Me.dgvClientes.AllowUserToDeleteRows = False
            Me.dgvClientes.BackgroundColor = System.Drawing.Color.White
            Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvClientes.GridColor = System.Drawing.Color.White
            Me.dgvClientes.Location = New System.Drawing.Point(52, 97)
            Me.dgvClientes.MultiSelect = False
            Me.dgvClientes.Name = "dgvClientes"
            Me.dgvClientes.ReadOnly = True
            Me.dgvClientes.RowHeadersVisible = False
            Me.dgvClientes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvClientes.Size = New System.Drawing.Size(320, 105)
            Me.dgvClientes.TabIndex = 163
            Me.dgvClientes.Visible = False
            '
            'lblNumFacturas
            '
            Me.lblNumFacturas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNumFacturas.Location = New System.Drawing.Point(224, 462)
            Me.lblNumFacturas.Name = "lblNumFacturas"
            Me.lblNumFacturas.Size = New System.Drawing.Size(32, 23)
            Me.lblNumFacturas.TabIndex = 173
            Me.lblNumFacturas.Text = "0"
            Me.lblNumFacturas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lbl2
            '
            Me.lbl2.AutoSize = True
            Me.lbl2.Location = New System.Drawing.Point(127, 467)
            Me.lbl2.Name = "lbl2"
            Me.lbl2.Size = New System.Drawing.Size(96, 13)
            Me.lbl2.TabIndex = 172
            Me.lbl2.Text = "Cantidad Facturas:"
            '
            'lblCantLineas
            '
            Me.lblCantLineas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCantLineas.Location = New System.Drawing.Point(89, 462)
            Me.lblCantLineas.Name = "lblCantLineas"
            Me.lblCantLineas.Size = New System.Drawing.Size(32, 23)
            Me.lblCantLineas.TabIndex = 171
            Me.lblCantLineas.Text = "0"
            Me.lblCantLineas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Timer
            '
            Me.Timer.Enabled = True
            Me.Timer.Interval = 1500
            '
            'txtDescuentoGen
            '
            Me.txtDescuentoGen.Location = New System.Drawing.Point(13, 28)
            Me.txtDescuentoGen.Name = "txtDescuentoGen"
            Me.txtDescuentoGen.Size = New System.Drawing.Size(40, 20)
            Me.txtDescuentoGen.TabIndex = 72
            Me.txtDescuentoGen.Text = "0"
            Me.txtDescuentoGen.Visible = False
            '
            'chkDescuento
            '
            Me.chkDescuento.AutoSize = True
            Me.chkDescuento.BackColor = System.Drawing.Color.Transparent
            Me.chkDescuento.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkDescuento.Location = New System.Drawing.Point(8, 10)
            Me.chkDescuento.Name = "chkDescuento"
            Me.chkDescuento.Size = New System.Drawing.Size(56, 18)
            Me.chkDescuento.TabIndex = 71
            Me.chkDescuento.Text = "DESC."
            Me.chkDescuento.UseVisualStyleBackColor = False
            '
            'txtImpuesto
            '
            Me.txtImpuesto.Location = New System.Drawing.Point(11, 28)
            Me.txtImpuesto.Name = "txtImpuesto"
            Me.txtImpuesto.Size = New System.Drawing.Size(40, 20)
            Me.txtImpuesto.TabIndex = 70
            Me.txtImpuesto.Text = "0"
            Me.txtImpuesto.Visible = False
            '
            'chkImpuesto
            '
            Me.chkImpuesto.AutoSize = True
            Me.chkImpuesto.BackColor = System.Drawing.Color.Transparent
            Me.chkImpuesto.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkImpuesto.Location = New System.Drawing.Point(8, 10)
            Me.chkImpuesto.Name = "chkImpuesto"
            Me.chkImpuesto.Size = New System.Drawing.Size(39, 18)
            Me.chkImpuesto.TabIndex = 69
            Me.chkImpuesto.Text = "I.V"
            Me.chkImpuesto.UseVisualStyleBackColor = False
            '
            'lbl1
            '
            Me.lbl1.AutoSize = True
            Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbl1.Location = New System.Drawing.Point(0, 467)
            Me.lbl1.Name = "lbl1"
            Me.lbl1.Size = New System.Drawing.Size(88, 13)
            Me.lbl1.TabIndex = 170
            Me.lbl1.Text = "Cantidad Líneas:"
            '
            'lblNombreTipo
            '
            Me.lblNombreTipo.Location = New System.Drawing.Point(108, 62)
            Me.lblNombreTipo.Name = "lblNombreTipo"
            Me.lblNombreTipo.Size = New System.Drawing.Size(164, 13)
            Me.lblNombreTipo.TabIndex = 168
            Me.lblNombreTipo.Text = "Label1"
            Me.lblNombreTipo.Visible = False
            '
            'lblMostrarTotal
            '
            Me.lblMostrarTotal.BackColor = System.Drawing.Color.Transparent
            Me.lblMostrarTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarTotal.ForeColor = System.Drawing.Color.Red
            Me.lblMostrarTotal.Location = New System.Drawing.Point(622, 540)
            Me.lblMostrarTotal.Name = "lblMostrarTotal"
            Me.lblMostrarTotal.Size = New System.Drawing.Size(130, 22)
            Me.lblMostrarTotal.TabIndex = 161
            Me.lblMostrarTotal.Text = "0.00"
            Me.lblMostrarTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblMensajeTipo
            '
            Me.lblMensajeTipo.AutoSize = True
            Me.lblMensajeTipo.Font = New System.Drawing.Font("Candara", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMensajeTipo.ForeColor = System.Drawing.Color.Red
            Me.lblMensajeTipo.Location = New System.Drawing.Point(82, 485)
            Me.lblMensajeTipo.Name = "lblMensajeTipo"
            Me.lblMensajeTipo.Size = New System.Drawing.Size(381, 39)
            Me.lblMensajeTipo.TabIndex = 167
            Me.lblMensajeTipo.Text = "Esta Facturando un listado"
            Me.lblMensajeTipo.Visible = False
            '
            'lblDiasPlazo
            '
            Me.lblDiasPlazo.AutoSize = True
            Me.lblDiasPlazo.BackColor = System.Drawing.Color.Transparent
            Me.lblDiasPlazo.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblDiasPlazo.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDiasPlazo.Location = New System.Drawing.Point(6, 5)
            Me.lblDiasPlazo.Name = "lblDiasPlazo"
            Me.lblDiasPlazo.Size = New System.Drawing.Size(60, 14)
            Me.lblDiasPlazo.TabIndex = 23
            Me.lblDiasPlazo.Text = "Días Plazo"
            Me.lblDiasPlazo.Visible = False
            '
            'gbDESC
            '
            Me.gbDESC.BackColor = System.Drawing.Color.Transparent
            Me.gbDESC.Controls.Add(Me.txtDescuentoGen)
            Me.gbDESC.Controls.Add(Me.chkDescuento)
            Me.gbDESC.Location = New System.Drawing.Point(584, 6)
            Me.gbDESC.Name = "gbDESC"
            Me.gbDESC.Size = New System.Drawing.Size(67, 52)
            Me.gbDESC.TabIndex = 165
            Me.gbDESC.TabStop = False
            '
            'txtFecha
            '
            Me.txtFecha.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtFecha.Location = New System.Drawing.Point(74, 22)
            Me.txtFecha.Name = "txtFecha"
            Me.txtFecha.Size = New System.Drawing.Size(70, 20)
            Me.txtFecha.TabIndex = 22
            Me.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'gbFechas
            '
            Me.gbFechas.BackColor = System.Drawing.Color.Transparent
            Me.gbFechas.Controls.Add(Me.txtDiasPlazo)
            Me.gbFechas.Controls.Add(Me.lblDiasPlazo)
            Me.gbFechas.Controls.Add(Me.txtFecha)
            Me.gbFechas.Controls.Add(Me.lblFecha)
            Me.gbFechas.Location = New System.Drawing.Point(428, 6)
            Me.gbFechas.Name = "gbFechas"
            Me.gbFechas.Size = New System.Drawing.Size(150, 49)
            Me.gbFechas.TabIndex = 166
            Me.gbFechas.TabStop = False
            '
            'txtDiasPlazo
            '
            Me.txtDiasPlazo.Location = New System.Drawing.Point(13, 22)
            Me.txtDiasPlazo.Name = "txtDiasPlazo"
            Me.txtDiasPlazo.Size = New System.Drawing.Size(37, 20)
            Me.txtDiasPlazo.TabIndex = 24
            Me.txtDiasPlazo.Text = "30"
            Me.txtDiasPlazo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblFecha
            '
            Me.lblFecha.AutoSize = True
            Me.lblFecha.BackColor = System.Drawing.Color.Transparent
            Me.lblFecha.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblFecha.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFecha.Location = New System.Drawing.Point(91, 5)
            Me.lblFecha.Name = "lblFecha"
            Me.lblFecha.Size = New System.Drawing.Size(37, 14)
            Me.lblFecha.TabIndex = 21
            Me.lblFecha.Text = "Fecha"
            '
            'lblMostrarNumFactura
            '
            Me.lblMostrarNumFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarNumFactura.Location = New System.Drawing.Point(721, 30)
            Me.lblMostrarNumFactura.Name = "lblMostrarNumFactura"
            Me.lblMostrarNumFactura.Size = New System.Drawing.Size(62, 23)
            Me.lblMostrarNumFactura.TabIndex = 162
            Me.lblMostrarNumFactura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblMostrarIV
            '
            Me.lblMostrarIV.BackColor = System.Drawing.Color.Transparent
            Me.lblMostrarIV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarIV.Location = New System.Drawing.Point(631, 514)
            Me.lblMostrarIV.Name = "lblMostrarIV"
            Me.lblMostrarIV.Size = New System.Drawing.Size(120, 16)
            Me.lblMostrarIV.TabIndex = 160
            Me.lblMostrarIV.Text = "0.00"
            Me.lblMostrarIV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblMostrarDesc
            '
            Me.lblMostrarDesc.BackColor = System.Drawing.Color.Transparent
            Me.lblMostrarDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarDesc.Location = New System.Drawing.Point(631, 488)
            Me.lblMostrarDesc.Name = "lblMostrarDesc"
            Me.lblMostrarDesc.Size = New System.Drawing.Size(120, 16)
            Me.lblMostrarDesc.TabIndex = 159
            Me.lblMostrarDesc.Text = "0.00"
            Me.lblMostrarDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblMostrarSubTotal
            '
            Me.lblMostrarSubTotal.BackColor = System.Drawing.Color.Transparent
            Me.lblMostrarSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarSubTotal.Location = New System.Drawing.Point(631, 464)
            Me.lblMostrarSubTotal.Name = "lblMostrarSubTotal"
            Me.lblMostrarSubTotal.Size = New System.Drawing.Size(120, 16)
            Me.lblMostrarSubTotal.TabIndex = 158
            Me.lblMostrarSubTotal.Text = "0.00"
            Me.lblMostrarSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblTotal
            '
            Me.lblTotal.AutoSize = True
            Me.lblTotal.BackColor = System.Drawing.Color.Transparent
            Me.lblTotal.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotal.Location = New System.Drawing.Point(554, 540)
            Me.lblTotal.Name = "lblTotal"
            Me.lblTotal.Size = New System.Drawing.Size(70, 23)
            Me.lblTotal.TabIndex = 157
            Me.lblTotal.Text = "Total ¢:"
            '
            'lblTotalIV
            '
            Me.lblTotalIV.AutoSize = True
            Me.lblTotalIV.BackColor = System.Drawing.Color.Transparent
            Me.lblTotalIV.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotalIV.Location = New System.Drawing.Point(554, 514)
            Me.lblTotalIV.Name = "lblTotalIV"
            Me.lblTotalIV.Size = New System.Drawing.Size(82, 18)
            Me.lblTotalIV.TabIndex = 156
            Me.lblTotalIV.Text = "Impuesto ¢:"
            '
            'lblTotalDesc
            '
            Me.lblTotalDesc.AutoSize = True
            Me.lblTotalDesc.BackColor = System.Drawing.Color.Transparent
            Me.lblTotalDesc.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotalDesc.Location = New System.Drawing.Point(545, 488)
            Me.lblTotalDesc.Name = "lblTotalDesc"
            Me.lblTotalDesc.Size = New System.Drawing.Size(91, 18)
            Me.lblTotalDesc.TabIndex = 155
            Me.lblTotalDesc.Text = "Descuento ¢:"
            '
            'lblSubTotal
            '
            Me.lblSubTotal.AutoSize = True
            Me.lblSubTotal.BackColor = System.Drawing.Color.Transparent
            Me.lblSubTotal.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubTotal.Location = New System.Drawing.Point(555, 464)
            Me.lblSubTotal.Name = "lblSubTotal"
            Me.lblSubTotal.Size = New System.Drawing.Size(81, 18)
            Me.lblSubTotal.TabIndex = 154
            Me.lblSubTotal.Text = "Sub-Total ¢:"
            '
            'btnAgregar
            '
            Me.btnAgregar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAgregar.Location = New System.Drawing.Point(703, 136)
            Me.btnAgregar.Name = "btnAgregar"
            Me.btnAgregar.Size = New System.Drawing.Size(64, 36)
            Me.btnAgregar.TabIndex = 152
            Me.btnAgregar.Text = "Agregar"
            Me.btnAgregar.UseVisualStyleBackColor = True
            '
            'txtDescuento
            '
            Me.txtDescuento.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtDescuento.Location = New System.Drawing.Point(650, 152)
            Me.txtDescuento.MaxLength = 8
            Me.txtDescuento.Name = "txtDescuento"
            Me.txtDescuento.Size = New System.Drawing.Size(46, 20)
            Me.txtDescuento.TabIndex = 151
            '
            'lblDescuento
            '
            Me.lblDescuento.AutoSize = True
            Me.lblDescuento.BackColor = System.Drawing.Color.Transparent
            Me.lblDescuento.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblDescuento.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDescuento.Location = New System.Drawing.Point(647, 136)
            Me.lblDescuento.Name = "lblDescuento"
            Me.lblDescuento.Size = New System.Drawing.Size(13, 14)
            Me.lblDescuento.TabIndex = 150
            Me.lblDescuento.Text = "%"
            '
            'txtPrecioIVI
            '
            Me.txtPrecioIVI.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtPrecioIVI.Enabled = False
            Me.txtPrecioIVI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPrecioIVI.Location = New System.Drawing.Point(565, 152)
            Me.txtPrecioIVI.Name = "txtPrecioIVI"
            Me.txtPrecioIVI.ReadOnly = True
            Me.txtPrecioIVI.Size = New System.Drawing.Size(82, 20)
            Me.txtPrecioIVI.TabIndex = 149
            Me.txtPrecioIVI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblPrecioIVI
            '
            Me.lblPrecioIVI.AutoSize = True
            Me.lblPrecioIVI.BackColor = System.Drawing.Color.Transparent
            Me.lblPrecioIVI.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblPrecioIVI.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPrecioIVI.Location = New System.Drawing.Point(564, 136)
            Me.lblPrecioIVI.Name = "lblPrecioIVI"
            Me.lblPrecioIVI.Size = New System.Drawing.Size(55, 14)
            Me.lblPrecioIVI.TabIndex = 148
            Me.lblPrecioIVI.Text = "Precio IVI"
            '
            'txtExistencias
            '
            Me.txtExistencias.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtExistencias.Enabled = False
            Me.txtExistencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtExistencias.Location = New System.Drawing.Point(432, 152)
            Me.txtExistencias.Name = "txtExistencias"
            Me.txtExistencias.ReadOnly = True
            Me.txtExistencias.Size = New System.Drawing.Size(46, 20)
            Me.txtExistencias.TabIndex = 147
            Me.txtExistencias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblExistencias
            '
            Me.lblExistencias.AutoSize = True
            Me.lblExistencias.BackColor = System.Drawing.Color.Transparent
            Me.lblExistencias.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblExistencias.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblExistencias.Location = New System.Drawing.Point(429, 136)
            Me.lblExistencias.Name = "lblExistencias"
            Me.lblExistencias.Size = New System.Drawing.Size(44, 14)
            Me.lblExistencias.TabIndex = 146
            Me.lblExistencias.Text = "E-Stock"
            '
            'txtPrecio
            '
            Me.txtPrecio.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtPrecio.Enabled = False
            Me.txtPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPrecio.Location = New System.Drawing.Point(481, 152)
            Me.txtPrecio.Name = "txtPrecio"
            Me.txtPrecio.ReadOnly = True
            Me.txtPrecio.Size = New System.Drawing.Size(82, 20)
            Me.txtPrecio.TabIndex = 145
            Me.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblPrecio
            '
            Me.lblPrecio.AutoSize = True
            Me.lblPrecio.BackColor = System.Drawing.Color.Transparent
            Me.lblPrecio.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblPrecio.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPrecio.Location = New System.Drawing.Point(478, 136)
            Me.lblPrecio.Name = "lblPrecio"
            Me.lblPrecio.Size = New System.Drawing.Size(39, 14)
            Me.lblPrecio.TabIndex = 144
            Me.lblPrecio.Text = "Precio"
            '
            'txtCodigo
            '
            Me.txtCodigo.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtCodigo.Location = New System.Drawing.Point(62, 152)
            Me.txtCodigo.Name = "txtCodigo"
            Me.txtCodigo.Size = New System.Drawing.Size(53, 20)
            Me.txtCodigo.TabIndex = 143
            '
            'lblCodigo
            '
            Me.lblCodigo.AutoSize = True
            Me.lblCodigo.BackColor = System.Drawing.Color.Transparent
            Me.lblCodigo.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblCodigo.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCodigo.Location = New System.Drawing.Point(59, 136)
            Me.lblCodigo.Name = "lblCodigo"
            Me.lblCodigo.Size = New System.Drawing.Size(44, 14)
            Me.lblCodigo.TabIndex = 142
            Me.lblCodigo.Text = "Código"
            '
            'txtCantidad
            '
            Me.txtCantidad.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtCantidad.Location = New System.Drawing.Point(4, 152)
            Me.txtCantidad.MaxLength = 8
            Me.txtCantidad.Name = "txtCantidad"
            Me.txtCantidad.Size = New System.Drawing.Size(55, 20)
            Me.txtCantidad.TabIndex = 141
            Me.txtCantidad.Text = "1"
            '
            'lblCantidad
            '
            Me.lblCantidad.AutoSize = True
            Me.lblCantidad.BackColor = System.Drawing.Color.Transparent
            Me.lblCantidad.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblCantidad.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCantidad.Location = New System.Drawing.Point(3, 136)
            Me.lblCantidad.Name = "lblCantidad"
            Me.lblCantidad.Size = New System.Drawing.Size(54, 14)
            Me.lblCantidad.TabIndex = 140
            Me.lblCantidad.Text = "Cantidad"
            '
            'txtArticulo
            '
            Me.txtArticulo.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtArticulo.Location = New System.Drawing.Point(117, 152)
            Me.txtArticulo.Name = "txtArticulo"
            Me.txtArticulo.Size = New System.Drawing.Size(313, 20)
            Me.txtArticulo.TabIndex = 139
            '
            'lblArticulo
            '
            Me.lblArticulo.AutoSize = True
            Me.lblArticulo.BackColor = System.Drawing.Color.Transparent
            Me.lblArticulo.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblArticulo.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblArticulo.Location = New System.Drawing.Point(114, 136)
            Me.lblArticulo.Name = "lblArticulo"
            Me.lblArticulo.Size = New System.Drawing.Size(46, 14)
            Me.lblArticulo.TabIndex = 138
            Me.lblArticulo.Text = "Artículo"
            '
            'txtNombre_Referencia
            '
            Me.txtNombre_Referencia.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtNombre_Referencia.Location = New System.Drawing.Point(81, 113)
            Me.txtNombre_Referencia.Name = "txtNombre_Referencia"
            Me.txtNombre_Referencia.Size = New System.Drawing.Size(219, 20)
            Me.txtNombre_Referencia.TabIndex = 137
            Me.txtNombre_Referencia.Visible = False
            '
            'txtId_Referencia
            '
            Me.txtId_Referencia.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtId_Referencia.Location = New System.Drawing.Point(49, 113)
            Me.txtId_Referencia.Name = "txtId_Referencia"
            Me.txtId_Referencia.Size = New System.Drawing.Size(31, 20)
            Me.txtId_Referencia.TabIndex = 135
            Me.txtId_Referencia.Visible = False
            '
            'chkReferencia
            '
            Me.chkReferencia.AutoSize = True
            Me.chkReferencia.BackColor = System.Drawing.Color.Transparent
            Me.chkReferencia.Cursor = System.Windows.Forms.Cursors.Hand
            Me.chkReferencia.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkReferencia.Location = New System.Drawing.Point(6, 111)
            Me.chkReferencia.Name = "chkReferencia"
            Me.chkReferencia.Size = New System.Drawing.Size(43, 18)
            Me.chkReferencia.TabIndex = 133
            Me.chkReferencia.Text = "Ref"
            Me.chkReferencia.UseVisualStyleBackColor = False
            '
            'btnCorregir
            '
            Me.btnCorregir.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCorregir.Location = New System.Drawing.Point(634, 75)
            Me.btnCorregir.Name = "btnCorregir"
            Me.btnCorregir.Size = New System.Drawing.Size(75, 23)
            Me.btnCorregir.TabIndex = 132
            Me.btnCorregir.Text = "Corregir"
            Me.btnCorregir.UseVisualStyleBackColor = True
            '
            'txtCedula
            '
            Me.txtCedula.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtCedula.Location = New System.Drawing.Point(519, 77)
            Me.txtCedula.MaxLength = 18
            Me.txtCedula.Name = "txtCedula"
            Me.txtCedula.Size = New System.Drawing.Size(110, 20)
            Me.txtCedula.TabIndex = 2
            '
            'lblCedula
            '
            Me.lblCedula.AutoSize = True
            Me.lblCedula.BackColor = System.Drawing.Color.Transparent
            Me.lblCedula.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblCedula.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCedula.Location = New System.Drawing.Point(516, 60)
            Me.lblCedula.Name = "lblCedula"
            Me.lblCedula.Size = New System.Drawing.Size(42, 14)
            Me.lblCedula.TabIndex = 130
            Me.lblCedula.Text = "Cédula"
            '
            'txtId_Cliente
            '
            Me.txtId_Cliente.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtId_Cliente.Location = New System.Drawing.Point(4, 77)
            Me.txtId_Cliente.MaxLength = 5
            Me.txtId_Cliente.Name = "txtId_Cliente"
            Me.txtId_Cliente.Size = New System.Drawing.Size(46, 20)
            Me.txtId_Cliente.TabIndex = 126
            '
            'lblId_Cliente
            '
            Me.lblId_Cliente.AutoSize = True
            Me.lblId_Cliente.BackColor = System.Drawing.Color.Transparent
            Me.lblId_Cliente.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblId_Cliente.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblId_Cliente.Location = New System.Drawing.Point(3, 61)
            Me.lblId_Cliente.Name = "lblId_Cliente"
            Me.lblId_Cliente.Size = New System.Drawing.Size(17, 14)
            Me.lblId_Cliente.TabIndex = 125
            Me.lblId_Cliente.Text = "Id"
            '
            'gbTipo
            '
            Me.gbTipo.BackColor = System.Drawing.Color.Transparent
            Me.gbTipo.Controls.Add(Me.rbCredito)
            Me.gbTipo.Controls.Add(Me.rbContado)
            Me.gbTipo.Cursor = System.Windows.Forms.Cursors.Hand
            Me.gbTipo.Location = New System.Drawing.Point(340, 5)
            Me.gbTipo.Name = "gbTipo"
            Me.gbTipo.Size = New System.Drawing.Size(88, 50)
            Me.gbTipo.TabIndex = 124
            Me.gbTipo.TabStop = False
            '
            'rbCredito
            '
            Me.rbCredito.AutoSize = True
            Me.rbCredito.BackColor = System.Drawing.Color.Transparent
            Me.rbCredito.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbCredito.Location = New System.Drawing.Point(7, 28)
            Me.rbCredito.Name = "rbCredito"
            Me.rbCredito.Size = New System.Drawing.Size(63, 18)
            Me.rbCredito.TabIndex = 28
            Me.rbCredito.TabStop = True
            Me.rbCredito.Text = "Credito"
            Me.rbCredito.UseVisualStyleBackColor = False
            '
            'rbContado
            '
            Me.rbContado.AutoSize = True
            Me.rbContado.BackColor = System.Drawing.Color.Transparent
            Me.rbContado.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbContado.Location = New System.Drawing.Point(7, 10)
            Me.rbContado.Name = "rbContado"
            Me.rbContado.Size = New System.Drawing.Size(70, 18)
            Me.rbContado.TabIndex = 0
            Me.rbContado.TabStop = True
            Me.rbContado.Text = "Contado"
            Me.rbContado.UseVisualStyleBackColor = False
            '
            'lblNumFactura
            '
            Me.lblNumFactura.AutoSize = True
            Me.lblNumFactura.BackColor = System.Drawing.Color.Transparent
            Me.lblNumFactura.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblNumFactura.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNumFactura.Location = New System.Drawing.Point(720, 9)
            Me.lblNumFactura.Name = "lblNumFactura"
            Me.lblNumFactura.Size = New System.Drawing.Size(63, 15)
            Me.lblNumFactura.TabIndex = 123
            Me.lblNumFactura.Text = "N° Factura"
            '
            'lblNombre_Referencia
            '
            Me.lblNombre_Referencia.AutoSize = True
            Me.lblNombre_Referencia.BackColor = System.Drawing.Color.Transparent
            Me.lblNombre_Referencia.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblNombre_Referencia.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombre_Referencia.Location = New System.Drawing.Point(85, 97)
            Me.lblNombre_Referencia.Name = "lblNombre_Referencia"
            Me.lblNombre_Referencia.Size = New System.Drawing.Size(49, 14)
            Me.lblNombre_Referencia.TabIndex = 136
            Me.lblNombre_Referencia.Text = "Nombre"
            Me.lblNombre_Referencia.Visible = False
            '
            'lblId_Referencia
            '
            Me.lblId_Referencia.AutoSize = True
            Me.lblId_Referencia.BackColor = System.Drawing.Color.Transparent
            Me.lblId_Referencia.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblId_Referencia.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblId_Referencia.Location = New System.Drawing.Point(48, 97)
            Me.lblId_Referencia.Name = "lblId_Referencia"
            Me.lblId_Referencia.Size = New System.Drawing.Size(17, 14)
            Me.lblId_Referencia.TabIndex = 134
            Me.lblId_Referencia.Text = "Id"
            Me.lblId_Referencia.Visible = False
            '
            'txtApellidos
            '
            Me.txtApellidos.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtApellidos.Location = New System.Drawing.Point(331, 77)
            Me.txtApellidos.MaxLength = 30
            Me.txtApellidos.Name = "txtApellidos"
            Me.txtApellidos.Size = New System.Drawing.Size(185, 20)
            Me.txtApellidos.TabIndex = 1
            '
            'lblApellidos
            '
            Me.lblApellidos.AutoSize = True
            Me.lblApellidos.BackColor = System.Drawing.Color.Transparent
            Me.lblApellidos.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblApellidos.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblApellidos.Location = New System.Drawing.Point(331, 60)
            Me.lblApellidos.Name = "lblApellidos"
            Me.lblApellidos.Size = New System.Drawing.Size(55, 14)
            Me.lblApellidos.TabIndex = 128
            Me.lblApellidos.Text = "Apellidos"
            '
            'lblNombre
            '
            Me.lblNombre.AutoSize = True
            Me.lblNombre.BackColor = System.Drawing.Color.Transparent
            Me.lblNombre.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblNombre.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombre.Location = New System.Drawing.Point(49, 60)
            Me.lblNombre.Name = "lblNombre"
            Me.lblNombre.Size = New System.Drawing.Size(49, 14)
            Me.lblNombre.TabIndex = 127
            Me.lblNombre.Text = "Nombre"
            '
            'txtNombre
            '
            Me.txtNombre.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtNombre.Location = New System.Drawing.Point(52, 77)
            Me.txtNombre.MaxLength = 60
            Me.txtNombre.Name = "txtNombre"
            Me.txtNombre.Size = New System.Drawing.Size(277, 20)
            Me.txtNombre.TabIndex = 0
            '
            'dgvMostrarProductos
            '
            Me.dgvMostrarProductos.AllowUserToAddRows = False
            Me.dgvMostrarProductos.AllowUserToDeleteRows = False
            Me.dgvMostrarProductos.AllowUserToResizeColumns = False
            Me.dgvMostrarProductos.BackgroundColor = System.Drawing.Color.White
            Me.dgvMostrarProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
            Me.dgvMostrarProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            Me.dgvMostrarProductos.GridColor = System.Drawing.Color.White
            Me.dgvMostrarProductos.Location = New System.Drawing.Point(60, 173)
            Me.dgvMostrarProductos.MultiSelect = False
            Me.dgvMostrarProductos.Name = "dgvMostrarProductos"
            Me.dgvMostrarProductos.ReadOnly = True
            Me.dgvMostrarProductos.RowHeadersVisible = False
            Me.dgvMostrarProductos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvMostrarProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvMostrarProductos.Size = New System.Drawing.Size(414, 148)
            Me.dgvMostrarProductos.TabIndex = 164
            Me.dgvMostrarProductos.Visible = False
            '
            'dgvProductos
            '
            Me.dgvProductos.AllowUserToAddRows = False
            Me.dgvProductos.AllowUserToDeleteRows = False
            Me.dgvProductos.AllowUserToResizeColumns = False
            Me.dgvProductos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dgvProductos.BackgroundColor = System.Drawing.Color.White
            Me.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
            Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cant, Me.Cod, Me.Descripción, Me.Precio, Me.Desc, Me.IV, Me.SubTotal, Me.Adv})
            Me.dgvProductos.Cursor = System.Windows.Forms.Cursors.Hand
            DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvProductos.DefaultCellStyle = DataGridViewCellStyle24
            Me.dgvProductos.GridColor = System.Drawing.Color.White
            Me.dgvProductos.Location = New System.Drawing.Point(4, 179)
            Me.dgvProductos.MultiSelect = False
            Me.dgvProductos.Name = "dgvProductos"
            Me.dgvProductos.ReadOnly = True
            Me.dgvProductos.RowHeadersVisible = False
            Me.dgvProductos.RowTemplate.Height = 18
            Me.dgvProductos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvProductos.Size = New System.Drawing.Size(781, 282)
            Me.dgvProductos.TabIndex = 153
            '
            'Cant
            '
            DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Cant.DefaultCellStyle = DataGridViewCellStyle17
            Me.Cant.HeaderText = "Cant"
            Me.Cant.Name = "Cant"
            Me.Cant.ReadOnly = True
            Me.Cant.Width = 60
            '
            'Cod
            '
            DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            Me.Cod.DefaultCellStyle = DataGridViewCellStyle18
            Me.Cod.HeaderText = "Cod"
            Me.Cod.Name = "Cod"
            Me.Cod.ReadOnly = True
            Me.Cod.Width = 50
            '
            'Descripción
            '
            DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            Me.Descripción.DefaultCellStyle = DataGridViewCellStyle19
            Me.Descripción.HeaderText = "Descripción"
            Me.Descripción.MaxInputLength = 150
            Me.Descripción.Name = "Descripción"
            Me.Descripción.ReadOnly = True
            Me.Descripción.Width = 360
            '
            'Precio
            '
            DataGridViewCellStyle20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Precio.DefaultCellStyle = DataGridViewCellStyle20
            Me.Precio.HeaderText = "Precio/U"
            Me.Precio.Name = "Precio"
            Me.Precio.ReadOnly = True
            Me.Precio.Width = 75
            '
            'Desc
            '
            DataGridViewCellStyle21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Desc.DefaultCellStyle = DataGridViewCellStyle21
            Me.Desc.HeaderText = "Desc"
            Me.Desc.Name = "Desc"
            Me.Desc.ReadOnly = True
            Me.Desc.Width = 52
            '
            'IV
            '
            DataGridViewCellStyle22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.IV.DefaultCellStyle = DataGridViewCellStyle22
            Me.IV.HeaderText = "I.V"
            Me.IV.Name = "IV"
            Me.IV.ReadOnly = True
            Me.IV.Width = 52
            '
            'SubTotal
            '
            DataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            DataGridViewCellStyle23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SubTotal.DefaultCellStyle = DataGridViewCellStyle23
            Me.SubTotal.HeaderText = "SubTotal"
            Me.SubTotal.Name = "SubTotal"
            Me.SubTotal.ReadOnly = True
            Me.SubTotal.Width = 90
            '
            'Adv
            '
            Me.Adv.HeaderText = "*"
            Me.Adv.Name = "Adv"
            Me.Adv.ReadOnly = True
            Me.Adv.Width = 20
            '
            'lblMensajeTipo2
            '
            Me.lblMensajeTipo2.AutoSize = True
            Me.lblMensajeTipo2.Font = New System.Drawing.Font("Candara", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMensajeTipo2.ForeColor = System.Drawing.Color.Red
            Me.lblMensajeTipo2.Location = New System.Drawing.Point(82, 524)
            Me.lblMensajeTipo2.Name = "lblMensajeTipo2"
            Me.lblMensajeTipo2.Size = New System.Drawing.Size(396, 33)
            Me.lblMensajeTipo2.TabIndex = 174
            Me.lblMensajeTipo2.Text = "Los precios han sido actualizados"
            Me.lblMensajeTipo2.Visible = False
            '
            'btnAltO
            '
            Me.btnAltO.Location = New System.Drawing.Point(122, 12)
            Me.btnAltO.Name = "btnAltO"
            Me.btnAltO.Size = New System.Drawing.Size(43, 24)
            Me.btnAltO.TabIndex = 175
            Me.btnAltO.Text = "btn&O"
            Me.btnAltO.UseVisualStyleBackColor = True
            '
            'btnAltU
            '
            Me.btnAltU.Location = New System.Drawing.Point(68, 14)
            Me.btnAltU.Name = "btnAltU"
            Me.btnAltU.Size = New System.Drawing.Size(43, 24)
            Me.btnAltU.TabIndex = 176
            Me.btnAltU.Text = "btn&U"
            Me.btnAltU.UseVisualStyleBackColor = True
            '
            'lblEstado
            '
            Me.lblEstado.AutoSize = True
            Me.lblEstado.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEstado.Location = New System.Drawing.Point(0, 9)
            Me.lblEstado.Name = "lblEstado"
            Me.lblEstado.Size = New System.Drawing.Size(45, 14)
            Me.lblEstado.TabIndex = 177
            Me.lblEstado.Text = "Estado:"
            '
            'lblMostrarEstado
            '
            Me.lblMostrarEstado.BackColor = System.Drawing.Color.Silver
            Me.lblMostrarEstado.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarEstado.ForeColor = System.Drawing.SystemColors.Control
            Me.lblMostrarEstado.Location = New System.Drawing.Point(43, 7)
            Me.lblMostrarEstado.Name = "lblMostrarEstado"
            Me.lblMostrarEstado.Size = New System.Drawing.Size(82, 18)
            Me.lblMostrarEstado.TabIndex = 178
            Me.lblMostrarEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblMostrarDias
            '
            Me.lblMostrarDias.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarDias.ForeColor = System.Drawing.SystemColors.Control
            Me.lblMostrarDias.Location = New System.Drawing.Point(433, 7)
            Me.lblMostrarDias.Name = "lblMostrarDias"
            Me.lblMostrarDias.Size = New System.Drawing.Size(38, 18)
            Me.lblMostrarDias.TabIndex = 184
            Me.lblMostrarDias.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblDiasAtraso
            '
            Me.lblDiasAtraso.AutoSize = True
            Me.lblDiasAtraso.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDiasAtraso.Location = New System.Drawing.Point(365, 9)
            Me.lblDiasAtraso.Name = "lblDiasAtraso"
            Me.lblDiasAtraso.Size = New System.Drawing.Size(70, 14)
            Me.lblDiasAtraso.TabIndex = 183
            Me.lblDiasAtraso.Text = "Días Atraso:"
            '
            'lblMostrarDisponible
            '
            Me.lblMostrarDisponible.BackColor = System.Drawing.Color.Silver
            Me.lblMostrarDisponible.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarDisponible.ForeColor = System.Drawing.SystemColors.Control
            Me.lblMostrarDisponible.Location = New System.Drawing.Point(275, 7)
            Me.lblMostrarDisponible.Name = "lblMostrarDisponible"
            Me.lblMostrarDisponible.Size = New System.Drawing.Size(88, 20)
            Me.lblMostrarDisponible.TabIndex = 182
            Me.lblMostrarDisponible.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblDisponible
            '
            Me.lblDisponible.AutoSize = True
            Me.lblDisponible.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDisponible.Location = New System.Drawing.Point(199, 9)
            Me.lblDisponible.Name = "lblDisponible"
            Me.lblDisponible.Size = New System.Drawing.Size(72, 14)
            Me.lblDisponible.TabIndex = 181
            Me.lblDisponible.Text = "Disponible ¢"
            '
            'lblMostrarTipo
            '
            Me.lblMostrarTipo.BackColor = System.Drawing.Color.Silver
            Me.lblMostrarTipo.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarTipo.ForeColor = System.Drawing.SystemColors.Control
            Me.lblMostrarTipo.Location = New System.Drawing.Point(147, 7)
            Me.lblMostrarTipo.Name = "lblMostrarTipo"
            Me.lblMostrarTipo.Size = New System.Drawing.Size(55, 20)
            Me.lblMostrarTipo.TabIndex = 180
            Me.lblMostrarTipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblTipo
            '
            Me.lblTipo.AutoSize = True
            Me.lblTipo.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTipo.Location = New System.Drawing.Point(121, 9)
            Me.lblTipo.Name = "lblTipo"
            Me.lblTipo.Size = New System.Drawing.Size(30, 14)
            Me.lblTipo.TabIndex = 179
            Me.lblTipo.Text = "Tipo"
            '
            'btnAltI
            '
            Me.btnAltI.Location = New System.Drawing.Point(12, 14)
            Me.btnAltI.Name = "btnAltI"
            Me.btnAltI.Size = New System.Drawing.Size(43, 24)
            Me.btnAltI.TabIndex = 180
            Me.btnAltI.Text = "btn&I"
            Me.btnAltI.UseVisualStyleBackColor = True
            '
            'gbIV
            '
            Me.gbIV.BackColor = System.Drawing.Color.Transparent
            Me.gbIV.Controls.Add(Me.chkImpuesto)
            Me.gbIV.Controls.Add(Me.txtImpuesto)
            Me.gbIV.Location = New System.Drawing.Point(652, 6)
            Me.gbIV.Name = "gbIV"
            Me.gbIV.Size = New System.Drawing.Size(59, 52)
            Me.gbIV.TabIndex = 166
            Me.gbIV.TabStop = False
            '
            'EliminFlu
            '
            Me.EliminFlu.Enabled = True
            Me.EliminFlu.Interval = 2400000
            '
            'pnCredito
            '
            Me.pnCredito.BackColor = System.Drawing.Color.Silver
            Me.pnCredito.Controls.Add(Me.lblMostrarDias)
            Me.pnCredito.Controls.Add(Me.lblEstado)
            Me.pnCredito.Controls.Add(Me.lblDiasAtraso)
            Me.pnCredito.Controls.Add(Me.lblMostrarEstado)
            Me.pnCredito.Controls.Add(Me.lblMostrarDisponible)
            Me.pnCredito.Controls.Add(Me.lblTipo)
            Me.pnCredito.Controls.Add(Me.lblDisponible)
            Me.pnCredito.Controls.Add(Me.lblMostrarTipo)
            Me.pnCredito.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.pnCredito.Location = New System.Drawing.Point(306, 104)
            Me.pnCredito.Name = "pnCredito"
            Me.pnCredito.Size = New System.Drawing.Size(479, 30)
            Me.pnCredito.TabIndex = 181
            Me.pnCredito.Visible = False
            '
            'btnSacarBodega
            '
            Me.btnSacarBodega.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnSacarBodega.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSacarBodega.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnSacarBodega.Location = New System.Drawing.Point(0, 524)
            Me.btnSacarBodega.Name = "btnSacarBodega"
            Me.btnSacarBodega.Size = New System.Drawing.Size(71, 39)
            Me.btnSacarBodega.TabIndex = 182
            Me.btnSacarBodega.Text = "Sacar de bodega"
            Me.btnSacarBodega.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnSacarBodega.UseVisualStyleBackColor = True
            '
            'btnTrasladar
            '
            Me.btnTrasladar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnTrasladar.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnTrasladar.Image = Global.Presentacion.My.Resources.Resources.Flecha
            Me.btnTrasladar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnTrasladar.Location = New System.Drawing.Point(148, 0)
            Me.btnTrasladar.Name = "btnTrasladar"
            Me.btnTrasladar.Size = New System.Drawing.Size(65, 52)
            Me.btnTrasladar.TabIndex = 120
            Me.btnTrasladar.Text = "Listado Proforma"
            Me.btnTrasladar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnTrasladar.UseVisualStyleBackColor = True
            '
            'btnCatalogo
            '
            Me.btnCatalogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnCatalogo.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCatalogo.Image = Global.Presentacion.My.Resources.Resources.Modificar
            Me.btnCatalogo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnCatalogo.Location = New System.Drawing.Point(74, 0)
            Me.btnCatalogo.Name = "btnCatalogo"
            Me.btnCatalogo.Size = New System.Drawing.Size(75, 55)
            Me.btnCatalogo.TabIndex = 169
            Me.btnCatalogo.Text = "Catálogo"
            Me.btnCatalogo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnCatalogo.UseVisualStyleBackColor = True
            '
            'btnImprimir
            '
            Me.btnImprimir.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnImprimir.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnImprimir.Image = Global.Presentacion.My.Resources.Resources.Imprimir
            Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnImprimir.Location = New System.Drawing.Point(0, 0)
            Me.btnImprimir.Name = "btnImprimir"
            Me.btnImprimir.Size = New System.Drawing.Size(75, 55)
            Me.btnImprimir.TabIndex = 121
            Me.btnImprimir.Text = "Imprimir"
            Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnImprimir.UseVisualStyleBackColor = True
            '
            'btnLimpiar
            '
            Me.btnLimpiar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnLimpiar.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnLimpiar.Image = Global.Presentacion.My.Resources.Resources.Limpiar
            Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnLimpiar.Location = New System.Drawing.Point(212, 0)
            Me.btnLimpiar.Name = "btnLimpiar"
            Me.btnLimpiar.Size = New System.Drawing.Size(65, 52)
            Me.btnLimpiar.TabIndex = 119
            Me.btnLimpiar.Text = "Limpiar"
            Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnLimpiar.UseVisualStyleBackColor = True
            '
            'FrmFacturar
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(793, 564)
            Me.Controls.Add(Me.dgvClientes)
            Me.Controls.Add(Me.btnSacarBodega)
            Me.Controls.Add(Me.pnCredito)
            Me.Controls.Add(Me.btnTrasladar)
            Me.Controls.Add(Me.btnCatalogo)
            Me.Controls.Add(Me.gbIV)
            Me.Controls.Add(Me.btnImprimir)
            Me.Controls.Add(Me.lblNumFacturas)
            Me.Controls.Add(Me.lbl2)
            Me.Controls.Add(Me.lblCantLineas)
            Me.Controls.Add(Me.lbl1)
            Me.Controls.Add(Me.lblNombreTipo)
            Me.Controls.Add(Me.lblMostrarTotal)
            Me.Controls.Add(Me.gbDESC)
            Me.Controls.Add(Me.gbFechas)
            Me.Controls.Add(Me.lblMostrarNumFactura)
            Me.Controls.Add(Me.lblMostrarIV)
            Me.Controls.Add(Me.lblMostrarDesc)
            Me.Controls.Add(Me.lblMostrarSubTotal)
            Me.Controls.Add(Me.lblTotal)
            Me.Controls.Add(Me.lblTotalIV)
            Me.Controls.Add(Me.lblTotalDesc)
            Me.Controls.Add(Me.lblSubTotal)
            Me.Controls.Add(Me.txtNombre_Referencia)
            Me.Controls.Add(Me.txtId_Referencia)
            Me.Controls.Add(Me.chkReferencia)
            Me.Controls.Add(Me.btnCorregir)
            Me.Controls.Add(Me.lblCedula)
            Me.Controls.Add(Me.txtId_Cliente)
            Me.Controls.Add(Me.lblId_Cliente)
            Me.Controls.Add(Me.gbTipo)
            Me.Controls.Add(Me.lblNumFactura)
            Me.Controls.Add(Me.lblNombre_Referencia)
            Me.Controls.Add(Me.lblId_Referencia)
            Me.Controls.Add(Me.lblApellidos)
            Me.Controls.Add(Me.lblNombre)
            Me.Controls.Add(Me.txtNombre)
            Me.Controls.Add(Me.dgvMostrarProductos)
            Me.Controls.Add(Me.dgvProductos)
            Me.Controls.Add(Me.txtCedula)
            Me.Controls.Add(Me.txtApellidos)
            Me.Controls.Add(Me.btnAltU)
            Me.Controls.Add(Me.btnAltO)
            Me.Controls.Add(Me.btnAgregar)
            Me.Controls.Add(Me.txtDescuento)
            Me.Controls.Add(Me.lblDescuento)
            Me.Controls.Add(Me.txtPrecioIVI)
            Me.Controls.Add(Me.lblPrecioIVI)
            Me.Controls.Add(Me.txtExistencias)
            Me.Controls.Add(Me.lblExistencias)
            Me.Controls.Add(Me.txtPrecio)
            Me.Controls.Add(Me.lblPrecio)
            Me.Controls.Add(Me.txtCodigo)
            Me.Controls.Add(Me.lblCodigo)
            Me.Controls.Add(Me.txtCantidad)
            Me.Controls.Add(Me.lblCantidad)
            Me.Controls.Add(Me.txtArticulo)
            Me.Controls.Add(Me.lblArticulo)
            Me.Controls.Add(Me.lblMensajeTipo)
            Me.Controls.Add(Me.lblMensajeTipo2)
            Me.Controls.Add(Me.btnLimpiar)
            Me.Controls.Add(Me.btnAltI)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmFacturar"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Facturar"
            CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbDESC.ResumeLayout(False)
            Me.gbDESC.PerformLayout()
            Me.gbFechas.ResumeLayout(False)
            Me.gbFechas.PerformLayout()
            Me.gbTipo.ResumeLayout(False)
            Me.gbTipo.PerformLayout()
            CType(Me.dgvMostrarProductos, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbIV.ResumeLayout(False)
            Me.gbIV.PerformLayout()
            Me.pnCredito.ResumeLayout(False)
            Me.pnCredito.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvClientes As System.Windows.Forms.DataGridView
        Friend WithEvents lblNumFacturas As System.Windows.Forms.Label
        Friend WithEvents lbl2 As System.Windows.Forms.Label
        Friend WithEvents lblCantLineas As System.Windows.Forms.Label
        Friend WithEvents Timer As System.Windows.Forms.Timer
        Friend WithEvents txtDescuentoGen As System.Windows.Forms.TextBox
        Friend WithEvents chkDescuento As System.Windows.Forms.CheckBox
        Friend WithEvents txtImpuesto As System.Windows.Forms.TextBox
        Friend WithEvents chkImpuesto As System.Windows.Forms.CheckBox
        Friend WithEvents lbl1 As System.Windows.Forms.Label
        Friend WithEvents btnCatalogo As System.Windows.Forms.Button
        Friend WithEvents lblNombreTipo As System.Windows.Forms.Label
        Friend WithEvents lblMostrarTotal As System.Windows.Forms.Label
        Friend WithEvents lblMensajeTipo As System.Windows.Forms.Label
        Friend WithEvents lblDiasPlazo As System.Windows.Forms.Label
        Friend WithEvents gbDESC As System.Windows.Forms.GroupBox
        Friend WithEvents txtFecha As System.Windows.Forms.TextBox
        Friend WithEvents gbFechas As System.Windows.Forms.GroupBox
        Friend WithEvents lblFecha As System.Windows.Forms.Label
        Friend WithEvents lblMostrarNumFactura As System.Windows.Forms.Label
        Friend WithEvents lblMostrarIV As System.Windows.Forms.Label
        Friend WithEvents lblMostrarDesc As System.Windows.Forms.Label
        Friend WithEvents lblMostrarSubTotal As System.Windows.Forms.Label
        Friend WithEvents lblTotal As System.Windows.Forms.Label
        Friend WithEvents lblTotalIV As System.Windows.Forms.Label
        Friend WithEvents lblTotalDesc As System.Windows.Forms.Label
        Friend WithEvents lblSubTotal As System.Windows.Forms.Label
        Friend WithEvents btnAgregar As System.Windows.Forms.Button
        Friend WithEvents txtDescuento As System.Windows.Forms.TextBox
        Friend WithEvents lblDescuento As System.Windows.Forms.Label
        Friend WithEvents txtPrecioIVI As System.Windows.Forms.TextBox
        Friend WithEvents lblPrecioIVI As System.Windows.Forms.Label
        Friend WithEvents txtExistencias As System.Windows.Forms.TextBox
        Friend WithEvents lblExistencias As System.Windows.Forms.Label
        Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
        Friend WithEvents lblPrecio As System.Windows.Forms.Label
        Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
        Friend WithEvents lblCodigo As System.Windows.Forms.Label
        Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
        Friend WithEvents lblCantidad As System.Windows.Forms.Label
        Friend WithEvents txtArticulo As System.Windows.Forms.TextBox
        Friend WithEvents lblArticulo As System.Windows.Forms.Label
        Friend WithEvents txtNombre_Referencia As System.Windows.Forms.TextBox
        Friend WithEvents txtId_Referencia As System.Windows.Forms.TextBox
        Friend WithEvents chkReferencia As System.Windows.Forms.CheckBox
        Friend WithEvents btnCorregir As System.Windows.Forms.Button
        Friend WithEvents txtCedula As System.Windows.Forms.TextBox
        Friend WithEvents lblCedula As System.Windows.Forms.Label
        Friend WithEvents txtId_Cliente As System.Windows.Forms.TextBox
        Friend WithEvents lblId_Cliente As System.Windows.Forms.Label
        Friend WithEvents gbTipo As System.Windows.Forms.GroupBox
        Friend WithEvents rbCredito As System.Windows.Forms.RadioButton
        Friend WithEvents rbContado As System.Windows.Forms.RadioButton
        Friend WithEvents lblNumFactura As System.Windows.Forms.Label
        Friend WithEvents btnTrasladar As System.Windows.Forms.Button
        Friend WithEvents btnImprimir As System.Windows.Forms.Button
        Friend WithEvents btnLimpiar As System.Windows.Forms.Button
        Friend WithEvents lblNombre_Referencia As System.Windows.Forms.Label
        Friend WithEvents lblId_Referencia As System.Windows.Forms.Label
        Friend WithEvents txtApellidos As System.Windows.Forms.TextBox
        Friend WithEvents lblApellidos As System.Windows.Forms.Label
        Friend WithEvents lblNombre As System.Windows.Forms.Label
        Friend WithEvents txtNombre As System.Windows.Forms.TextBox
        Friend WithEvents dgvMostrarProductos As System.Windows.Forms.DataGridView
        Friend WithEvents dgvProductos As System.Windows.Forms.DataGridView
        Friend WithEvents lblMensajeTipo2 As System.Windows.Forms.Label
        Friend WithEvents btnAltO As System.Windows.Forms.Button
        Friend WithEvents btnAltU As System.Windows.Forms.Button
        Friend WithEvents lblEstado As System.Windows.Forms.Label
        Friend WithEvents lblMostrarEstado As System.Windows.Forms.Label
        Friend WithEvents lblMostrarTipo As System.Windows.Forms.Label
        Friend WithEvents lblTipo As System.Windows.Forms.Label
        Friend WithEvents lblMostrarDisponible As System.Windows.Forms.Label
        Friend WithEvents lblDisponible As System.Windows.Forms.Label
        Friend WithEvents btnAltI As System.Windows.Forms.Button
        Friend WithEvents gbIV As System.Windows.Forms.GroupBox
        Friend WithEvents EliminFlu As System.Windows.Forms.Timer
        Friend WithEvents txtDiasPlazo As System.Windows.Forms.TextBox
        Friend WithEvents lblDiasAtraso As System.Windows.Forms.Label
        Friend WithEvents lblMostrarDias As System.Windows.Forms.Label
        Friend WithEvents pnCredito As System.Windows.Forms.Panel
        Friend WithEvents btnSacarBodega As System.Windows.Forms.Button
        Friend WithEvents Cant As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Cod As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Descripción As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Desc As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents IV As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents SubTotal As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Adv As System.Windows.Forms.DataGridViewTextBoxColumn
    End Class
End Namespace