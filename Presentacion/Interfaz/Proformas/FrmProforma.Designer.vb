Namespace Interfaz.Proformas
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmProforma
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
            Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.gbIVDESC = New System.Windows.Forms.GroupBox()
            Me.chkMostrarDescuento = New System.Windows.Forms.CheckBox()
            Me.txtDescuentoGen = New System.Windows.Forms.TextBox()
            Me.chkDescuento = New System.Windows.Forms.CheckBox()
            Me.txtImpuesto = New System.Windows.Forms.TextBox()
            Me.chkImpuesto = New System.Windows.Forms.CheckBox()
            Me.lblMostrarNumProforma = New System.Windows.Forms.Label()
            Me.lblNumProforma = New System.Windows.Forms.Label()
            Me.txtNombre = New System.Windows.Forms.TextBox()
            Me.lblNombre = New System.Windows.Forms.Label()
            Me.txtNombre_Referencia = New System.Windows.Forms.TextBox()
            Me.txtId_Referencia = New System.Windows.Forms.TextBox()
            Me.chkReferencia = New System.Windows.Forms.CheckBox()
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
            Me.dgvProductos = New System.Windows.Forms.DataGridView()
            Me.Cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Descripción = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.IV = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.SubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.lblMostrarTotal = New System.Windows.Forms.Label()
            Me.lblMostrarIV = New System.Windows.Forms.Label()
            Me.lblMostrarDesc = New System.Windows.Forms.Label()
            Me.lblMostrarSubTotal = New System.Windows.Forms.Label()
            Me.lblTotal = New System.Windows.Forms.Label()
            Me.lblTotalIV = New System.Windows.Forms.Label()
            Me.lblTotalDesc = New System.Windows.Forms.Label()
            Me.lblSubTotal = New System.Windows.Forms.Label()
            Me.lblNumFacturas = New System.Windows.Forms.Label()
            Me.lbl2 = New System.Windows.Forms.Label()
            Me.lblCantLineas = New System.Windows.Forms.Label()
            Me.lbl1 = New System.Windows.Forms.Label()
            Me.lblNumeroProforma = New System.Windows.Forms.Label()
            Me.txtId_Proforma = New System.Windows.Forms.TextBox()
            Me.lblNombre_Referencia = New System.Windows.Forms.Label()
            Me.lblId_Referencia = New System.Windows.Forms.Label()
            Me.dgvClientes = New System.Windows.Forms.DataGridView()
            Me.dgvMostrarProductos = New System.Windows.Forms.DataGridView()
            Me.btnFacturar = New System.Windows.Forms.Button()
            Me.btnImprimir = New System.Windows.Forms.Button()
            Me.btnLimpiar = New System.Windows.Forms.Button()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.btnGuardar = New System.Windows.Forms.Button()
            Me.txtTelefono = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.btnCorregirNombre = New System.Windows.Forms.Button()
            Me.btnExportar = New System.Windows.Forms.Button()
            Me.gbIVDESC.SuspendLayout()
            CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvMostrarProductos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gbIVDESC
            '
            Me.gbIVDESC.BackColor = System.Drawing.Color.Transparent
            Me.gbIVDESC.Controls.Add(Me.chkMostrarDescuento)
            Me.gbIVDESC.Controls.Add(Me.txtDescuentoGen)
            Me.gbIVDESC.Controls.Add(Me.chkDescuento)
            Me.gbIVDESC.Controls.Add(Me.txtImpuesto)
            Me.gbIVDESC.Controls.Add(Me.chkImpuesto)
            Me.gbIVDESC.Location = New System.Drawing.Point(546, 6)
            Me.gbIVDESC.Name = "gbIVDESC"
            Me.gbIVDESC.Size = New System.Drawing.Size(135, 77)
            Me.gbIVDESC.TabIndex = 170
            Me.gbIVDESC.TabStop = False
            '
            'chkMostrarDescuento
            '
            Me.chkMostrarDescuento.AutoSize = True
            Me.chkMostrarDescuento.Location = New System.Drawing.Point(6, 54)
            Me.chkMostrarDescuento.Name = "chkMostrarDescuento"
            Me.chkMostrarDescuento.Size = New System.Drawing.Size(133, 17)
            Me.chkMostrarDescuento.TabIndex = 207
            Me.chkMostrarDescuento.Text = "No Mostrar Descuento"
            Me.chkMostrarDescuento.UseVisualStyleBackColor = True
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
            Me.chkDescuento.Location = New System.Drawing.Point(8, 10)
            Me.chkDescuento.Name = "chkDescuento"
            Me.chkDescuento.Size = New System.Drawing.Size(58, 17)
            Me.chkDescuento.TabIndex = 71
            Me.chkDescuento.Text = "DESC."
            Me.chkDescuento.UseVisualStyleBackColor = False
            '
            'txtImpuesto
            '
            Me.txtImpuesto.Location = New System.Drawing.Point(72, 28)
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
            Me.chkImpuesto.Location = New System.Drawing.Point(72, 8)
            Me.chkImpuesto.Name = "chkImpuesto"
            Me.chkImpuesto.Size = New System.Drawing.Size(39, 17)
            Me.chkImpuesto.TabIndex = 69
            Me.chkImpuesto.Text = "I.V"
            Me.chkImpuesto.UseVisualStyleBackColor = False
            '
            'lblMostrarNumProforma
            '
            Me.lblMostrarNumProforma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarNumProforma.Location = New System.Drawing.Point(688, 60)
            Me.lblMostrarNumProforma.Name = "lblMostrarNumProforma"
            Me.lblMostrarNumProforma.Size = New System.Drawing.Size(62, 23)
            Me.lblMostrarNumProforma.TabIndex = 169
            Me.lblMostrarNumProforma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblNumProforma
            '
            Me.lblNumProforma.AutoSize = True
            Me.lblNumProforma.BackColor = System.Drawing.Color.Transparent
            Me.lblNumProforma.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblNumProforma.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNumProforma.Location = New System.Drawing.Point(688, 42)
            Me.lblNumProforma.Name = "lblNumProforma"
            Me.lblNumProforma.Size = New System.Drawing.Size(74, 15)
            Me.lblNumProforma.TabIndex = 167
            Me.lblNumProforma.Text = "N° Proforma"
            '
            'txtNombre
            '
            Me.txtNombre.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtNombre.Location = New System.Drawing.Point(70, 78)
            Me.txtNombre.MaxLength = 40
            Me.txtNombre.Name = "txtNombre"
            Me.txtNombre.Size = New System.Drawing.Size(312, 20)
            Me.txtNombre.TabIndex = 0
            '
            'lblNombre
            '
            Me.lblNombre.AutoSize = True
            Me.lblNombre.BackColor = System.Drawing.Color.Transparent
            Me.lblNombre.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblNombre.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombre.Location = New System.Drawing.Point(75, 60)
            Me.lblNombre.Name = "lblNombre"
            Me.lblNombre.Size = New System.Drawing.Size(95, 15)
            Me.lblNombre.TabIndex = 173
            Me.lblNombre.Text = "Nombre Cliente"
            '
            'txtNombre_Referencia
            '
            Me.txtNombre_Referencia.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtNombre_Referencia.Location = New System.Drawing.Point(137, 120)
            Me.txtNombre_Referencia.Name = "txtNombre_Referencia"
            Me.txtNombre_Referencia.Size = New System.Drawing.Size(269, 20)
            Me.txtNombre_Referencia.TabIndex = 178
            Me.txtNombre_Referencia.Visible = False
            '
            'txtId_Referencia
            '
            Me.txtId_Referencia.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtId_Referencia.Location = New System.Drawing.Point(89, 120)
            Me.txtId_Referencia.Name = "txtId_Referencia"
            Me.txtId_Referencia.Size = New System.Drawing.Size(46, 20)
            Me.txtId_Referencia.TabIndex = 177
            Me.txtId_Referencia.Visible = False
            '
            'chkReferencia
            '
            Me.chkReferencia.AutoSize = True
            Me.chkReferencia.BackColor = System.Drawing.Color.Transparent
            Me.chkReferencia.Cursor = System.Windows.Forms.Cursors.Hand
            Me.chkReferencia.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkReferencia.Location = New System.Drawing.Point(5, 117)
            Me.chkReferencia.Name = "chkReferencia"
            Me.chkReferencia.Size = New System.Drawing.Size(86, 19)
            Me.chkReferencia.TabIndex = 176
            Me.chkReferencia.Text = "Referencia"
            Me.chkReferencia.UseVisualStyleBackColor = False
            '
            'btnAgregar
            '
            Me.btnAgregar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAgregar.Location = New System.Drawing.Point(698, 142)
            Me.btnAgregar.Name = "btnAgregar"
            Me.btnAgregar.Size = New System.Drawing.Size(64, 36)
            Me.btnAgregar.TabIndex = 187
            Me.btnAgregar.Text = "Agregar"
            Me.btnAgregar.UseVisualStyleBackColor = True
            '
            'txtDescuento
            '
            Me.txtDescuento.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtDescuento.Location = New System.Drawing.Point(642, 158)
            Me.txtDescuento.MaxLength = 8
            Me.txtDescuento.Name = "txtDescuento"
            Me.txtDescuento.Size = New System.Drawing.Size(46, 20)
            Me.txtDescuento.TabIndex = 186
            '
            'lblDescuento
            '
            Me.lblDescuento.AutoSize = True
            Me.lblDescuento.BackColor = System.Drawing.Color.Transparent
            Me.lblDescuento.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblDescuento.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDescuento.Location = New System.Drawing.Point(639, 142)
            Me.lblDescuento.Name = "lblDescuento"
            Me.lblDescuento.Size = New System.Drawing.Size(14, 15)
            Me.lblDescuento.TabIndex = 185
            Me.lblDescuento.Text = "%"
            '
            'txtPrecioIVI
            '
            Me.txtPrecioIVI.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtPrecioIVI.Location = New System.Drawing.Point(559, 158)
            Me.txtPrecioIVI.Name = "txtPrecioIVI"
            Me.txtPrecioIVI.ReadOnly = True
            Me.txtPrecioIVI.Size = New System.Drawing.Size(82, 20)
            Me.txtPrecioIVI.TabIndex = 184
            Me.txtPrecioIVI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblPrecioIVI
            '
            Me.lblPrecioIVI.AutoSize = True
            Me.lblPrecioIVI.BackColor = System.Drawing.Color.Transparent
            Me.lblPrecioIVI.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblPrecioIVI.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPrecioIVI.Location = New System.Drawing.Point(556, 142)
            Me.lblPrecioIVI.Name = "lblPrecioIVI"
            Me.lblPrecioIVI.Size = New System.Drawing.Size(60, 15)
            Me.lblPrecioIVI.TabIndex = 183
            Me.lblPrecioIVI.Text = "Precio IVI"
            '
            'txtExistencias
            '
            Me.txtExistencias.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtExistencias.Location = New System.Drawing.Point(428, 158)
            Me.txtExistencias.Name = "txtExistencias"
            Me.txtExistencias.ReadOnly = True
            Me.txtExistencias.Size = New System.Drawing.Size(46, 20)
            Me.txtExistencias.TabIndex = 182
            Me.txtExistencias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblExistencias
            '
            Me.lblExistencias.AutoSize = True
            Me.lblExistencias.BackColor = System.Drawing.Color.Transparent
            Me.lblExistencias.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblExistencias.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblExistencias.Location = New System.Drawing.Point(425, 142)
            Me.lblExistencias.Name = "lblExistencias"
            Me.lblExistencias.Size = New System.Drawing.Size(48, 15)
            Me.lblExistencias.TabIndex = 181
            Me.lblExistencias.Text = "E-Stock"
            '
            'txtPrecio
            '
            Me.txtPrecio.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtPrecio.Location = New System.Drawing.Point(476, 158)
            Me.txtPrecio.Name = "txtPrecio"
            Me.txtPrecio.ReadOnly = True
            Me.txtPrecio.Size = New System.Drawing.Size(82, 20)
            Me.txtPrecio.TabIndex = 180
            Me.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblPrecio
            '
            Me.lblPrecio.AutoSize = True
            Me.lblPrecio.BackColor = System.Drawing.Color.Transparent
            Me.lblPrecio.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblPrecio.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPrecio.Location = New System.Drawing.Point(473, 142)
            Me.lblPrecio.Name = "lblPrecio"
            Me.lblPrecio.Size = New System.Drawing.Size(42, 15)
            Me.lblPrecio.TabIndex = 179
            Me.lblPrecio.Text = "Precio"
            '
            'txtCodigo
            '
            Me.txtCodigo.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtCodigo.Location = New System.Drawing.Point(61, 158)
            Me.txtCodigo.Name = "txtCodigo"
            Me.txtCodigo.Size = New System.Drawing.Size(55, 20)
            Me.txtCodigo.TabIndex = 193
            '
            'lblCodigo
            '
            Me.lblCodigo.AutoSize = True
            Me.lblCodigo.BackColor = System.Drawing.Color.Transparent
            Me.lblCodigo.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblCodigo.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCodigo.Location = New System.Drawing.Point(60, 142)
            Me.lblCodigo.Name = "lblCodigo"
            Me.lblCodigo.Size = New System.Drawing.Size(45, 15)
            Me.lblCodigo.TabIndex = 192
            Me.lblCodigo.Text = "Código"
            '
            'txtCantidad
            '
            Me.txtCantidad.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtCantidad.Location = New System.Drawing.Point(5, 158)
            Me.txtCantidad.MaxLength = 8
            Me.txtCantidad.Name = "txtCantidad"
            Me.txtCantidad.Size = New System.Drawing.Size(55, 20)
            Me.txtCantidad.TabIndex = 191
            Me.txtCantidad.Text = "1"
            '
            'lblCantidad
            '
            Me.lblCantidad.AutoSize = True
            Me.lblCantidad.BackColor = System.Drawing.Color.Transparent
            Me.lblCantidad.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblCantidad.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCantidad.Location = New System.Drawing.Point(4, 142)
            Me.lblCantidad.Name = "lblCantidad"
            Me.lblCantidad.Size = New System.Drawing.Size(55, 15)
            Me.lblCantidad.TabIndex = 190
            Me.lblCantidad.Text = "Cantidad"
            '
            'txtArticulo
            '
            Me.txtArticulo.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtArticulo.Location = New System.Drawing.Point(118, 158)
            Me.txtArticulo.Name = "txtArticulo"
            Me.txtArticulo.Size = New System.Drawing.Size(308, 20)
            Me.txtArticulo.TabIndex = 189
            '
            'lblArticulo
            '
            Me.lblArticulo.AutoSize = True
            Me.lblArticulo.BackColor = System.Drawing.Color.Transparent
            Me.lblArticulo.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblArticulo.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblArticulo.Location = New System.Drawing.Point(115, 142)
            Me.lblArticulo.Name = "lblArticulo"
            Me.lblArticulo.Size = New System.Drawing.Size(51, 15)
            Me.lblArticulo.TabIndex = 188
            Me.lblArticulo.Text = "Artículo"
            '
            'dgvProductos
            '
            Me.dgvProductos.AllowUserToAddRows = False
            Me.dgvProductos.AllowUserToDeleteRows = False
            Me.dgvProductos.AllowUserToResizeColumns = False
            Me.dgvProductos.AllowUserToResizeRows = False
            Me.dgvProductos.BackgroundColor = System.Drawing.Color.White
            Me.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
            Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cant, Me.Cod, Me.Descripción, Me.Precio, Me.Desc, Me.IV, Me.SubTotal})
            DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvProductos.DefaultCellStyle = DataGridViewCellStyle16
            Me.dgvProductos.GridColor = System.Drawing.Color.White
            Me.dgvProductos.Location = New System.Drawing.Point(5, 181)
            Me.dgvProductos.MultiSelect = False
            Me.dgvProductos.Name = "dgvProductos"
            Me.dgvProductos.ReadOnly = True
            Me.dgvProductos.RowHeadersVisible = False
            Me.dgvProductos.RowTemplate.Height = 18
            Me.dgvProductos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvProductos.Size = New System.Drawing.Size(762, 282)
            Me.dgvProductos.TabIndex = 194
            '
            'Cant
            '
            DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Cant.DefaultCellStyle = DataGridViewCellStyle9
            Me.Cant.HeaderText = "Cant"
            Me.Cant.Name = "Cant"
            Me.Cant.ReadOnly = True
            Me.Cant.Width = 60
            '
            'Cod
            '
            DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            Me.Cod.DefaultCellStyle = DataGridViewCellStyle10
            Me.Cod.HeaderText = "Cod"
            Me.Cod.Name = "Cod"
            Me.Cod.ReadOnly = True
            Me.Cod.Width = 50
            '
            'Descripción
            '
            DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            Me.Descripción.DefaultCellStyle = DataGridViewCellStyle11
            Me.Descripción.HeaderText = "Descripción"
            Me.Descripción.MaxInputLength = 150
            Me.Descripción.Name = "Descripción"
            Me.Descripción.ReadOnly = True
            Me.Descripción.Width = 360
            '
            'Precio
            '
            DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Precio.DefaultCellStyle = DataGridViewCellStyle12
            Me.Precio.HeaderText = "Precio/U"
            Me.Precio.Name = "Precio"
            Me.Precio.ReadOnly = True
            Me.Precio.Width = 75
            '
            'Desc
            '
            DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Desc.DefaultCellStyle = DataGridViewCellStyle13
            Me.Desc.HeaderText = "Desc"
            Me.Desc.Name = "Desc"
            Me.Desc.ReadOnly = True
            Me.Desc.Width = 52
            '
            'IV
            '
            DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.IV.DefaultCellStyle = DataGridViewCellStyle14
            Me.IV.HeaderText = "I.V"
            Me.IV.Name = "IV"
            Me.IV.ReadOnly = True
            Me.IV.Width = 52
            '
            'SubTotal
            '
            DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SubTotal.DefaultCellStyle = DataGridViewCellStyle15
            Me.SubTotal.HeaderText = "SubTotal"
            Me.SubTotal.Name = "SubTotal"
            Me.SubTotal.ReadOnly = True
            Me.SubTotal.Width = 90
            '
            'lblMostrarTotal
            '
            Me.lblMostrarTotal.BackColor = System.Drawing.Color.Transparent
            Me.lblMostrarTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarTotal.ForeColor = System.Drawing.Color.Red
            Me.lblMostrarTotal.Location = New System.Drawing.Point(620, 542)
            Me.lblMostrarTotal.Name = "lblMostrarTotal"
            Me.lblMostrarTotal.Size = New System.Drawing.Size(130, 22)
            Me.lblMostrarTotal.TabIndex = 202
            Me.lblMostrarTotal.Text = "0.00"
            Me.lblMostrarTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblMostrarIV
            '
            Me.lblMostrarIV.BackColor = System.Drawing.Color.Transparent
            Me.lblMostrarIV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarIV.Location = New System.Drawing.Point(629, 516)
            Me.lblMostrarIV.Name = "lblMostrarIV"
            Me.lblMostrarIV.Size = New System.Drawing.Size(120, 16)
            Me.lblMostrarIV.TabIndex = 201
            Me.lblMostrarIV.Text = "0.00"
            Me.lblMostrarIV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblMostrarDesc
            '
            Me.lblMostrarDesc.BackColor = System.Drawing.Color.Transparent
            Me.lblMostrarDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarDesc.Location = New System.Drawing.Point(629, 490)
            Me.lblMostrarDesc.Name = "lblMostrarDesc"
            Me.lblMostrarDesc.Size = New System.Drawing.Size(120, 16)
            Me.lblMostrarDesc.TabIndex = 200
            Me.lblMostrarDesc.Text = "0.00"
            Me.lblMostrarDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblMostrarSubTotal
            '
            Me.lblMostrarSubTotal.BackColor = System.Drawing.Color.Transparent
            Me.lblMostrarSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarSubTotal.Location = New System.Drawing.Point(629, 466)
            Me.lblMostrarSubTotal.Name = "lblMostrarSubTotal"
            Me.lblMostrarSubTotal.Size = New System.Drawing.Size(120, 16)
            Me.lblMostrarSubTotal.TabIndex = 199
            Me.lblMostrarSubTotal.Text = "0.00"
            Me.lblMostrarSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblTotal
            '
            Me.lblTotal.AutoSize = True
            Me.lblTotal.BackColor = System.Drawing.Color.Transparent
            Me.lblTotal.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotal.Location = New System.Drawing.Point(552, 542)
            Me.lblTotal.Name = "lblTotal"
            Me.lblTotal.Size = New System.Drawing.Size(70, 23)
            Me.lblTotal.TabIndex = 198
            Me.lblTotal.Text = "Total ¢:"
            '
            'lblTotalIV
            '
            Me.lblTotalIV.AutoSize = True
            Me.lblTotalIV.BackColor = System.Drawing.Color.Transparent
            Me.lblTotalIV.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotalIV.Location = New System.Drawing.Point(552, 516)
            Me.lblTotalIV.Name = "lblTotalIV"
            Me.lblTotalIV.Size = New System.Drawing.Size(82, 18)
            Me.lblTotalIV.TabIndex = 197
            Me.lblTotalIV.Text = "Impuesto ¢:"
            '
            'lblTotalDesc
            '
            Me.lblTotalDesc.AutoSize = True
            Me.lblTotalDesc.BackColor = System.Drawing.Color.Transparent
            Me.lblTotalDesc.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotalDesc.Location = New System.Drawing.Point(543, 490)
            Me.lblTotalDesc.Name = "lblTotalDesc"
            Me.lblTotalDesc.Size = New System.Drawing.Size(91, 18)
            Me.lblTotalDesc.TabIndex = 196
            Me.lblTotalDesc.Text = "Descuento ¢:"
            '
            'lblSubTotal
            '
            Me.lblSubTotal.AutoSize = True
            Me.lblSubTotal.BackColor = System.Drawing.Color.Transparent
            Me.lblSubTotal.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubTotal.Location = New System.Drawing.Point(553, 466)
            Me.lblSubTotal.Name = "lblSubTotal"
            Me.lblSubTotal.Size = New System.Drawing.Size(81, 18)
            Me.lblSubTotal.TabIndex = 195
            Me.lblSubTotal.Text = "Sub-Total ¢:"
            '
            'lblNumFacturas
            '
            Me.lblNumFacturas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNumFacturas.Location = New System.Drawing.Point(236, 464)
            Me.lblNumFacturas.Name = "lblNumFacturas"
            Me.lblNumFacturas.Size = New System.Drawing.Size(32, 23)
            Me.lblNumFacturas.TabIndex = 206
            Me.lblNumFacturas.Text = "0"
            Me.lblNumFacturas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lbl2
            '
            Me.lbl2.AutoSize = True
            Me.lbl2.Location = New System.Drawing.Point(134, 466)
            Me.lbl2.Name = "lbl2"
            Me.lbl2.Size = New System.Drawing.Size(90, 13)
            Me.lbl2.TabIndex = 205
            Me.lbl2.Text = "Cantidad Páginas"
            '
            'lblCantLineas
            '
            Me.lblCantLineas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCantLineas.Location = New System.Drawing.Point(96, 464)
            Me.lblCantLineas.Name = "lblCantLineas"
            Me.lblCantLineas.Size = New System.Drawing.Size(32, 23)
            Me.lblCantLineas.TabIndex = 204
            Me.lblCantLineas.Text = "0"
            Me.lblCantLineas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lbl1
            '
            Me.lbl1.AutoSize = True
            Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbl1.Location = New System.Drawing.Point(7, 466)
            Me.lbl1.Name = "lbl1"
            Me.lbl1.Size = New System.Drawing.Size(88, 13)
            Me.lbl1.TabIndex = 203
            Me.lbl1.Text = "Cantidad Líneas:"
            '
            'lblNumeroProforma
            '
            Me.lblNumeroProforma.AutoSize = True
            Me.lblNumeroProforma.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNumeroProforma.Location = New System.Drawing.Point(2, 61)
            Me.lblNumeroProforma.Name = "lblNumeroProforma"
            Me.lblNumeroProforma.Size = New System.Drawing.Size(74, 15)
            Me.lblNumeroProforma.TabIndex = 207
            Me.lblNumeroProforma.Text = "N° Proforma"
            '
            'txtId_Proforma
            '
            Me.txtId_Proforma.Location = New System.Drawing.Point(7, 78)
            Me.txtId_Proforma.MaxLength = 5
            Me.txtId_Proforma.Name = "txtId_Proforma"
            Me.txtId_Proforma.Size = New System.Drawing.Size(57, 20)
            Me.txtId_Proforma.TabIndex = 208
            '
            'lblNombre_Referencia
            '
            Me.lblNombre_Referencia.AutoSize = True
            Me.lblNombre_Referencia.BackColor = System.Drawing.Color.Transparent
            Me.lblNombre_Referencia.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblNombre_Referencia.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombre_Referencia.Location = New System.Drawing.Point(137, 102)
            Me.lblNombre_Referencia.Name = "lblNombre_Referencia"
            Me.lblNombre_Referencia.Size = New System.Drawing.Size(53, 15)
            Me.lblNombre_Referencia.TabIndex = 210
            Me.lblNombre_Referencia.Text = "Nombre"
            Me.lblNombre_Referencia.Visible = False
            '
            'lblId_Referencia
            '
            Me.lblId_Referencia.AutoSize = True
            Me.lblId_Referencia.BackColor = System.Drawing.Color.Transparent
            Me.lblId_Referencia.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblId_Referencia.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblId_Referencia.Location = New System.Drawing.Point(87, 102)
            Me.lblId_Referencia.Name = "lblId_Referencia"
            Me.lblId_Referencia.Size = New System.Drawing.Size(18, 15)
            Me.lblId_Referencia.TabIndex = 209
            Me.lblId_Referencia.Text = "Id"
            Me.lblId_Referencia.Visible = False
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
            Me.dgvClientes.Location = New System.Drawing.Point(70, 98)
            Me.dgvClientes.MultiSelect = False
            Me.dgvClientes.Name = "dgvClientes"
            Me.dgvClientes.ReadOnly = True
            Me.dgvClientes.RowHeadersVisible = False
            Me.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvClientes.Size = New System.Drawing.Size(330, 95)
            Me.dgvClientes.TabIndex = 211
            Me.dgvClientes.Visible = False
            '
            'dgvMostrarProductos
            '
            Me.dgvMostrarProductos.AllowUserToAddRows = False
            Me.dgvMostrarProductos.AllowUserToDeleteRows = False
            Me.dgvMostrarProductos.AllowUserToResizeColumns = False
            Me.dgvMostrarProductos.AllowUserToResizeRows = False
            Me.dgvMostrarProductos.BackgroundColor = System.Drawing.Color.White
            Me.dgvMostrarProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvMostrarProductos.GridColor = System.Drawing.Color.White
            Me.dgvMostrarProductos.Location = New System.Drawing.Point(61, 178)
            Me.dgvMostrarProductos.MultiSelect = False
            Me.dgvMostrarProductos.Name = "dgvMostrarProductos"
            Me.dgvMostrarProductos.ReadOnly = True
            Me.dgvMostrarProductos.RowHeadersVisible = False
            Me.dgvMostrarProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvMostrarProductos.Size = New System.Drawing.Size(413, 113)
            Me.dgvMostrarProductos.TabIndex = 212
            Me.dgvMostrarProductos.Visible = False
            '
            'btnFacturar
            '
            Me.btnFacturar.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnFacturar.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnFacturar.Image = Global.Presentacion.My.Resources.Resources.facturar
            Me.btnFacturar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnFacturar.Location = New System.Drawing.Point(138, 0)
            Me.btnFacturar.Name = "btnFacturar"
            Me.btnFacturar.Size = New System.Drawing.Size(71, 57)
            Me.btnFacturar.TabIndex = 42
            Me.btnFacturar.Text = "Facturar"
            Me.btnFacturar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnFacturar.UseVisualStyleBackColor = True
            '
            'btnImprimir
            '
            Me.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnImprimir.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnImprimir.Image = Global.Presentacion.My.Resources.Resources.Imprimir
            Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnImprimir.Location = New System.Drawing.Point(69, 0)
            Me.btnImprimir.Name = "btnImprimir"
            Me.btnImprimir.Size = New System.Drawing.Size(71, 57)
            Me.btnImprimir.TabIndex = 39
            Me.btnImprimir.Text = "Imprimir"
            Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnImprimir.UseVisualStyleBackColor = True
            '
            'btnLimpiar
            '
            Me.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnLimpiar.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnLimpiar.Image = Global.Presentacion.My.Resources.Resources.Limpiar
            Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnLimpiar.Location = New System.Drawing.Point(278, 0)
            Me.btnLimpiar.Name = "btnLimpiar"
            Me.btnLimpiar.Size = New System.Drawing.Size(71, 57)
            Me.btnLimpiar.TabIndex = 38
            Me.btnLimpiar.Text = "Limpiar"
            Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnLimpiar.UseVisualStyleBackColor = True
            '
            'Timer1
            '
            Me.Timer1.Enabled = True
            Me.Timer1.Interval = 1
            '
            'btnGuardar
            '
            Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnGuardar.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = Global.Presentacion.My.Resources.Resources.Guardar
            Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnGuardar.Location = New System.Drawing.Point(0, 0)
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(71, 57)
            Me.btnGuardar.TabIndex = 213
            Me.btnGuardar.Text = "Guardar"
            Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnGuardar.UseVisualStyleBackColor = True
            '
            'txtTelefono
            '
            Me.txtTelefono.Location = New System.Drawing.Point(388, 78)
            Me.txtTelefono.MaxLength = 9
            Me.txtTelefono.Name = "txtTelefono"
            Me.txtTelefono.Size = New System.Drawing.Size(71, 20)
            Me.txtTelefono.TabIndex = 215
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(383, 61)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(55, 15)
            Me.Label1.TabIndex = 214
            Me.Label1.Text = "Teléfono"
            '
            'btnCorregirNombre
            '
            Me.btnCorregirNombre.Location = New System.Drawing.Point(465, 78)
            Me.btnCorregirNombre.Name = "btnCorregirNombre"
            Me.btnCorregirNombre.Size = New System.Drawing.Size(75, 23)
            Me.btnCorregirNombre.TabIndex = 216
            Me.btnCorregirNombre.Text = "Corregir"
            Me.btnCorregirNombre.UseVisualStyleBackColor = True
            '
            'btnExportar
            '
            Me.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnExportar.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = Global.Presentacion.My.Resources.Resources.Exportar
            Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnExportar.Location = New System.Drawing.Point(208, 0)
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(71, 57)
            Me.btnExportar.TabIndex = 217
            Me.btnExportar.Text = "Exportar"
            Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnExportar.UseVisualStyleBackColor = True
            '
            'FrmProforma
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.DarkGray
            Me.ClientSize = New System.Drawing.Size(774, 564)
            Me.Controls.Add(Me.btnExportar)
            Me.Controls.Add(Me.dgvClientes)
            Me.Controls.Add(Me.btnCorregirNombre)
            Me.Controls.Add(Me.txtTelefono)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.btnGuardar)
            Me.Controls.Add(Me.dgvMostrarProductos)
            Me.Controls.Add(Me.lblNombre_Referencia)
            Me.Controls.Add(Me.lblId_Referencia)
            Me.Controls.Add(Me.txtId_Proforma)
            Me.Controls.Add(Me.lblNumeroProforma)
            Me.Controls.Add(Me.lblNumFacturas)
            Me.Controls.Add(Me.lbl2)
            Me.Controls.Add(Me.lblCantLineas)
            Me.Controls.Add(Me.lbl1)
            Me.Controls.Add(Me.lblMostrarTotal)
            Me.Controls.Add(Me.lblMostrarIV)
            Me.Controls.Add(Me.lblMostrarDesc)
            Me.Controls.Add(Me.lblMostrarSubTotal)
            Me.Controls.Add(Me.lblTotal)
            Me.Controls.Add(Me.lblTotalIV)
            Me.Controls.Add(Me.lblTotalDesc)
            Me.Controls.Add(Me.lblSubTotal)
            Me.Controls.Add(Me.dgvProductos)
            Me.Controls.Add(Me.txtCodigo)
            Me.Controls.Add(Me.lblCodigo)
            Me.Controls.Add(Me.txtCantidad)
            Me.Controls.Add(Me.lblCantidad)
            Me.Controls.Add(Me.txtArticulo)
            Me.Controls.Add(Me.lblArticulo)
            Me.Controls.Add(Me.btnAgregar)
            Me.Controls.Add(Me.txtDescuento)
            Me.Controls.Add(Me.lblDescuento)
            Me.Controls.Add(Me.txtPrecioIVI)
            Me.Controls.Add(Me.lblPrecioIVI)
            Me.Controls.Add(Me.txtExistencias)
            Me.Controls.Add(Me.lblExistencias)
            Me.Controls.Add(Me.txtPrecio)
            Me.Controls.Add(Me.lblPrecio)
            Me.Controls.Add(Me.txtId_Referencia)
            Me.Controls.Add(Me.chkReferencia)
            Me.Controls.Add(Me.txtNombre)
            Me.Controls.Add(Me.lblNombre)
            Me.Controls.Add(Me.gbIVDESC)
            Me.Controls.Add(Me.lblMostrarNumProforma)
            Me.Controls.Add(Me.lblNumProforma)
            Me.Controls.Add(Me.btnFacturar)
            Me.Controls.Add(Me.btnImprimir)
            Me.Controls.Add(Me.btnLimpiar)
            Me.Controls.Add(Me.txtNombre_Referencia)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmProforma"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Proforma"
            Me.gbIVDESC.ResumeLayout(False)
            Me.gbIVDESC.PerformLayout()
            CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvMostrarProductos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents btnFacturar As System.Windows.Forms.Button
        Friend WithEvents btnImprimir As System.Windows.Forms.Button
        Friend WithEvents btnLimpiar As System.Windows.Forms.Button
        Friend WithEvents gbIVDESC As System.Windows.Forms.GroupBox
        Friend WithEvents txtDescuentoGen As System.Windows.Forms.TextBox
        Friend WithEvents chkDescuento As System.Windows.Forms.CheckBox
        Friend WithEvents txtImpuesto As System.Windows.Forms.TextBox
        Friend WithEvents chkImpuesto As System.Windows.Forms.CheckBox
        Friend WithEvents lblMostrarNumProforma As System.Windows.Forms.Label
        Friend WithEvents lblNumProforma As System.Windows.Forms.Label
        Friend WithEvents txtNombre As System.Windows.Forms.TextBox
        Friend WithEvents lblNombre As System.Windows.Forms.Label
        Friend WithEvents txtNombre_Referencia As System.Windows.Forms.TextBox
        Friend WithEvents txtId_Referencia As System.Windows.Forms.TextBox
        Friend WithEvents chkReferencia As System.Windows.Forms.CheckBox
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
        Friend WithEvents dgvProductos As System.Windows.Forms.DataGridView
        Friend WithEvents Cant As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Cod As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Descripción As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Desc As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents IV As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents SubTotal As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents lblMostrarTotal As System.Windows.Forms.Label
        Friend WithEvents lblMostrarIV As System.Windows.Forms.Label
        Friend WithEvents lblMostrarDesc As System.Windows.Forms.Label
        Friend WithEvents lblMostrarSubTotal As System.Windows.Forms.Label
        Friend WithEvents lblTotal As System.Windows.Forms.Label
        Friend WithEvents lblTotalIV As System.Windows.Forms.Label
        Friend WithEvents lblTotalDesc As System.Windows.Forms.Label
        Friend WithEvents lblSubTotal As System.Windows.Forms.Label
        Friend WithEvents lblNumFacturas As System.Windows.Forms.Label
        Friend WithEvents lbl2 As System.Windows.Forms.Label
        Friend WithEvents lblCantLineas As System.Windows.Forms.Label
        Friend WithEvents lbl1 As System.Windows.Forms.Label
        Friend WithEvents chkMostrarDescuento As System.Windows.Forms.CheckBox
        Friend WithEvents lblNumeroProforma As System.Windows.Forms.Label
        Friend WithEvents txtId_Proforma As System.Windows.Forms.TextBox
        Friend WithEvents lblNombre_Referencia As System.Windows.Forms.Label
        Friend WithEvents lblId_Referencia As System.Windows.Forms.Label
        Friend WithEvents dgvClientes As System.Windows.Forms.DataGridView
        Friend WithEvents dgvMostrarProductos As System.Windows.Forms.DataGridView
        Friend WithEvents Timer1 As System.Windows.Forms.Timer
        Friend WithEvents btnGuardar As System.Windows.Forms.Button
        Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents btnCorregirNombre As System.Windows.Forms.Button
        Friend WithEvents btnExportar As System.Windows.Forms.Button
    End Class
End Namespace