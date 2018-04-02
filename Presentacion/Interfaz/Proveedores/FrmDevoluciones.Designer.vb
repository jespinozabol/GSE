Namespace Interfaz.Proveedores
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmDevoluciones
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
            Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.dgvProveedores = New System.Windows.Forms.DataGridView()
            Me.txtNombre = New System.Windows.Forms.TextBox()
            Me.lblNombre = New System.Windows.Forms.Label()
            Me.txtId_Proveedor = New System.Windows.Forms.TextBox()
            Me.lblIdProveedor = New System.Windows.Forms.Label()
            Me.txtNumFactura = New System.Windows.Forms.TextBox()
            Me.lblNumFactura = New System.Windows.Forms.Label()
            Me.txtCantidad = New System.Windows.Forms.TextBox()
            Me.lblCantidad = New System.Windows.Forms.Label()
            Me.txtProducto = New System.Windows.Forms.TextBox()
            Me.lblProducto = New System.Windows.Forms.Label()
            Me.txtCodigo = New System.Windows.Forms.TextBox()
            Me.lblCodigo = New System.Windows.Forms.Label()
            Me.dgvDevoluciones = New System.Windows.Forms.DataGridView()
            Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.NumFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Motivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.txtMotivo = New System.Windows.Forms.TextBox()
            Me.lblMotivo = New System.Windows.Forms.Label()
            Me.dgvProductos = New System.Windows.Forms.DataGridView()
            Me.txtObservaciones = New System.Windows.Forms.TextBox()
            Me.lblObservaciones = New System.Windows.Forms.Label()
            Me.rbNc = New System.Windows.Forms.RadioButton()
            Me.rbCambio = New System.Windows.Forms.RadioButton()
            Me.lblFecha = New System.Windows.Forms.Label()
            Me.txtFecha = New System.Windows.Forms.TextBox()
            Me.lblNumBoleta = New System.Windows.Forms.Label()
            Me.txtNumBoleta = New System.Windows.Forms.TextBox()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.errValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
            Me.btnGuardar = New System.Windows.Forms.Button()
            Me.btnLimpiar = New System.Windows.Forms.Button()
            CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvDevoluciones, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            CType(Me.errValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dgvProveedores
            '
            Me.dgvProveedores.AllowUserToAddRows = False
            Me.dgvProveedores.AllowUserToDeleteRows = False
            Me.dgvProveedores.AllowUserToResizeColumns = False
            Me.dgvProveedores.AllowUserToResizeRows = False
            Me.dgvProveedores.BackgroundColor = System.Drawing.Color.White
            DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvProveedores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
            Me.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvProveedores.DefaultCellStyle = DataGridViewCellStyle14
            Me.dgvProveedores.GridColor = System.Drawing.Color.White
            Me.dgvProveedores.Location = New System.Drawing.Point(67, 112)
            Me.dgvProveedores.MultiSelect = False
            Me.dgvProveedores.Name = "dgvProveedores"
            Me.dgvProveedores.ReadOnly = True
            DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvProveedores.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
            Me.dgvProveedores.RowHeadersVisible = False
            Me.dgvProveedores.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvProveedores.Size = New System.Drawing.Size(349, 105)
            Me.dgvProveedores.TabIndex = 303
            Me.dgvProveedores.Visible = False
            '
            'txtNombre
            '
            Me.txtNombre.Location = New System.Drawing.Point(66, 92)
            Me.txtNombre.MaxLength = 60
            Me.txtNombre.Name = "txtNombre"
            Me.txtNombre.Size = New System.Drawing.Size(349, 20)
            Me.txtNombre.TabIndex = 300
            '
            'lblNombre
            '
            Me.lblNombre.AutoSize = True
            Me.lblNombre.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombre.Location = New System.Drawing.Point(63, 74)
            Me.lblNombre.Name = "lblNombre"
            Me.lblNombre.Size = New System.Drawing.Size(53, 15)
            Me.lblNombre.TabIndex = 302
            Me.lblNombre.Text = "Nombre"
            '
            'txtId_Proveedor
            '
            Me.txtId_Proveedor.Location = New System.Drawing.Point(8, 92)
            Me.txtId_Proveedor.MaxLength = 5
            Me.txtId_Proveedor.Name = "txtId_Proveedor"
            Me.txtId_Proveedor.Size = New System.Drawing.Size(53, 20)
            Me.txtId_Proveedor.TabIndex = 299
            '
            'lblIdProveedor
            '
            Me.lblIdProveedor.AutoSize = True
            Me.lblIdProveedor.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdProveedor.Location = New System.Drawing.Point(6, 74)
            Me.lblIdProveedor.Name = "lblIdProveedor"
            Me.lblIdProveedor.Size = New System.Drawing.Size(53, 15)
            Me.lblIdProveedor.TabIndex = 301
            Me.lblIdProveedor.Text = "Id Prove"
            '
            'txtNumFactura
            '
            Me.txtNumFactura.Location = New System.Drawing.Point(423, 92)
            Me.txtNumFactura.MaxLength = 5
            Me.txtNumFactura.Name = "txtNumFactura"
            Me.txtNumFactura.Size = New System.Drawing.Size(93, 20)
            Me.txtNumFactura.TabIndex = 306
            '
            'lblNumFactura
            '
            Me.lblNumFactura.AutoSize = True
            Me.lblNumFactura.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNumFactura.Location = New System.Drawing.Point(424, 74)
            Me.lblNumFactura.Name = "lblNumFactura"
            Me.lblNumFactura.Size = New System.Drawing.Size(58, 15)
            Me.lblNumFactura.TabIndex = 307
            Me.lblNumFactura.Text = "# Factura"
            '
            'txtCantidad
            '
            Me.txtCantidad.Location = New System.Drawing.Point(8, 134)
            Me.txtCantidad.MaxLength = 5
            Me.txtCantidad.Name = "txtCantidad"
            Me.txtCantidad.Size = New System.Drawing.Size(53, 20)
            Me.txtCantidad.TabIndex = 308
            '
            'lblCantidad
            '
            Me.lblCantidad.AutoSize = True
            Me.lblCantidad.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCantidad.Location = New System.Drawing.Point(8, 116)
            Me.lblCantidad.Name = "lblCantidad"
            Me.lblCantidad.Size = New System.Drawing.Size(32, 15)
            Me.lblCantidad.TabIndex = 309
            Me.lblCantidad.Text = "Cant"
            '
            'txtProducto
            '
            Me.txtProducto.Location = New System.Drawing.Point(126, 134)
            Me.txtProducto.MaxLength = 60
            Me.txtProducto.Name = "txtProducto"
            Me.txtProducto.Size = New System.Drawing.Size(390, 20)
            Me.txtProducto.TabIndex = 310
            '
            'lblProducto
            '
            Me.lblProducto.AutoSize = True
            Me.lblProducto.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblProducto.Location = New System.Drawing.Point(126, 116)
            Me.lblProducto.Name = "lblProducto"
            Me.lblProducto.Size = New System.Drawing.Size(58, 15)
            Me.lblProducto.TabIndex = 311
            Me.lblProducto.Text = "Producto"
            '
            'txtCodigo
            '
            Me.txtCodigo.Location = New System.Drawing.Point(67, 134)
            Me.txtCodigo.MaxLength = 5
            Me.txtCodigo.Name = "txtCodigo"
            Me.txtCodigo.Size = New System.Drawing.Size(53, 20)
            Me.txtCodigo.TabIndex = 312
            '
            'lblCodigo
            '
            Me.lblCodigo.AutoSize = True
            Me.lblCodigo.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCodigo.Location = New System.Drawing.Point(67, 116)
            Me.lblCodigo.Name = "lblCodigo"
            Me.lblCodigo.Size = New System.Drawing.Size(45, 15)
            Me.lblCodigo.TabIndex = 313
            Me.lblCodigo.Text = "Código"
            '
            'dgvDevoluciones
            '
            Me.dgvDevoluciones.AllowUserToAddRows = False
            Me.dgvDevoluciones.AllowUserToDeleteRows = False
            Me.dgvDevoluciones.AllowUserToResizeColumns = False
            Me.dgvDevoluciones.AllowUserToResizeRows = False
            Me.dgvDevoluciones.BackgroundColor = System.Drawing.Color.White
            Me.dgvDevoluciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
            Me.dgvDevoluciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvDevoluciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16
            Me.dgvDevoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvDevoluciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cantidad, Me.Producto, Me.NumFactura, Me.Tipo, Me.Motivo})
            DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvDevoluciones.DefaultCellStyle = DataGridViewCellStyle17
            Me.dgvDevoluciones.GridColor = System.Drawing.Color.White
            Me.dgvDevoluciones.Location = New System.Drawing.Point(8, 261)
            Me.dgvDevoluciones.MultiSelect = False
            Me.dgvDevoluciones.Name = "dgvDevoluciones"
            Me.dgvDevoluciones.ReadOnly = True
            Me.dgvDevoluciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvDevoluciones.RowHeadersDefaultCellStyle = DataGridViewCellStyle18
            Me.dgvDevoluciones.RowHeadersVisible = False
            Me.dgvDevoluciones.RowTemplate.Height = 18
            Me.dgvDevoluciones.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvDevoluciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDevoluciones.Size = New System.Drawing.Size(708, 158)
            Me.dgvDevoluciones.TabIndex = 314
            '
            'Cantidad
            '
            Me.Cantidad.HeaderText = "Cant"
            Me.Cantidad.Name = "Cantidad"
            Me.Cantidad.ReadOnly = True
            Me.Cantidad.Width = 60
            '
            'Producto
            '
            Me.Producto.HeaderText = "Descripcion del Producto"
            Me.Producto.Name = "Producto"
            Me.Producto.ReadOnly = True
            Me.Producto.Width = 300
            '
            'NumFactura
            '
            Me.NumFactura.HeaderText = "# Factura"
            Me.NumFactura.Name = "NumFactura"
            Me.NumFactura.ReadOnly = True
            Me.NumFactura.Width = 80
            '
            'Tipo
            '
            Me.Tipo.HeaderText = "Tipo"
            Me.Tipo.Name = "Tipo"
            Me.Tipo.ReadOnly = True
            Me.Tipo.Width = 80
            '
            'Motivo
            '
            Me.Motivo.HeaderText = "Motivo"
            Me.Motivo.Name = "Motivo"
            Me.Motivo.ReadOnly = True
            Me.Motivo.Width = 170
            '
            'txtMotivo
            '
            Me.txtMotivo.Location = New System.Drawing.Point(8, 172)
            Me.txtMotivo.MaxLength = 60
            Me.txtMotivo.Name = "txtMotivo"
            Me.txtMotivo.Size = New System.Drawing.Size(508, 20)
            Me.txtMotivo.TabIndex = 316
            '
            'lblMotivo
            '
            Me.lblMotivo.AutoSize = True
            Me.lblMotivo.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMotivo.Location = New System.Drawing.Point(8, 154)
            Me.lblMotivo.Name = "lblMotivo"
            Me.lblMotivo.Size = New System.Drawing.Size(46, 15)
            Me.lblMotivo.TabIndex = 317
            Me.lblMotivo.Text = "Motivo"
            '
            'dgvProductos
            '
            Me.dgvProductos.AllowUserToAddRows = False
            Me.dgvProductos.AllowUserToDeleteRows = False
            Me.dgvProductos.AllowUserToResizeColumns = False
            Me.dgvProductos.BackgroundColor = System.Drawing.Color.White
            Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            Me.dgvProductos.GridColor = System.Drawing.Color.White
            Me.dgvProductos.Location = New System.Drawing.Point(126, 155)
            Me.dgvProductos.MultiSelect = False
            Me.dgvProductos.Name = "dgvProductos"
            Me.dgvProductos.ReadOnly = True
            Me.dgvProductos.RowHeadersVisible = False
            Me.dgvProductos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvProductos.Size = New System.Drawing.Size(414, 150)
            Me.dgvProductos.TabIndex = 318
            Me.dgvProductos.Visible = False
            '
            'txtObservaciones
            '
            Me.txtObservaciones.Location = New System.Drawing.Point(533, 92)
            Me.txtObservaciones.MaxLength = 60
            Me.txtObservaciones.Multiline = True
            Me.txtObservaciones.Name = "txtObservaciones"
            Me.txtObservaciones.Size = New System.Drawing.Size(183, 100)
            Me.txtObservaciones.TabIndex = 330
            '
            'lblObservaciones
            '
            Me.lblObservaciones.AutoSize = True
            Me.lblObservaciones.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblObservaciones.Location = New System.Drawing.Point(533, 74)
            Me.lblObservaciones.Name = "lblObservaciones"
            Me.lblObservaciones.Size = New System.Drawing.Size(87, 15)
            Me.lblObservaciones.TabIndex = 331
            Me.lblObservaciones.Text = "Observaciones"
            '
            'rbNc
            '
            Me.rbNc.AutoSize = True
            Me.rbNc.Location = New System.Drawing.Point(6, 12)
            Me.rbNc.Name = "rbNc"
            Me.rbNc.Size = New System.Drawing.Size(84, 17)
            Me.rbNc.TabIndex = 332
            Me.rbNc.TabStop = True
            Me.rbNc.Text = "Nota Credito"
            Me.rbNc.UseVisualStyleBackColor = True
            '
            'rbCambio
            '
            Me.rbCambio.AutoSize = True
            Me.rbCambio.Location = New System.Drawing.Point(7, 12)
            Me.rbCambio.Name = "rbCambio"
            Me.rbCambio.Size = New System.Drawing.Size(60, 17)
            Me.rbCambio.TabIndex = 333
            Me.rbCambio.TabStop = True
            Me.rbCambio.Text = "Cambio"
            Me.rbCambio.UseVisualStyleBackColor = True
            '
            'lblFecha
            '
            Me.lblFecha.AutoSize = True
            Me.lblFecha.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFecha.Location = New System.Drawing.Point(102, 15)
            Me.lblFecha.Name = "lblFecha"
            Me.lblFecha.Size = New System.Drawing.Size(39, 15)
            Me.lblFecha.TabIndex = 323
            Me.lblFecha.Text = "Fecha"
            '
            'txtFecha
            '
            Me.txtFecha.Enabled = False
            Me.txtFecha.Location = New System.Drawing.Point(147, 13)
            Me.txtFecha.MaxLength = 10
            Me.txtFecha.Name = "txtFecha"
            Me.txtFecha.Size = New System.Drawing.Size(73, 20)
            Me.txtFecha.TabIndex = 322
            '
            'lblNumBoleta
            '
            Me.lblNumBoleta.AutoSize = True
            Me.lblNumBoleta.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNumBoleta.Location = New System.Drawing.Point(226, 15)
            Me.lblNumBoleta.Name = "lblNumBoleta"
            Me.lblNumBoleta.Size = New System.Drawing.Size(53, 15)
            Me.lblNumBoleta.TabIndex = 325
            Me.lblNumBoleta.Text = "# Boleta"
            '
            'txtNumBoleta
            '
            Me.txtNumBoleta.Enabled = False
            Me.txtNumBoleta.Location = New System.Drawing.Point(286, 12)
            Me.txtNumBoleta.MaxLength = 20
            Me.txtNumBoleta.Name = "txtNumBoleta"
            Me.txtNumBoleta.Size = New System.Drawing.Size(73, 20)
            Me.txtNumBoleta.TabIndex = 324
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.rbCambio)
            Me.GroupBox1.Controls.Add(Me.txtNumBoleta)
            Me.GroupBox1.Controls.Add(Me.lblNumBoleta)
            Me.GroupBox1.Controls.Add(Me.txtFecha)
            Me.GroupBox1.Controls.Add(Me.lblFecha)
            Me.GroupBox1.Location = New System.Drawing.Point(8, 220)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(387, 37)
            Me.GroupBox1.TabIndex = 334
            Me.GroupBox1.TabStop = False
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.rbNc)
            Me.GroupBox2.Location = New System.Drawing.Point(8, 195)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(387, 35)
            Me.GroupBox2.TabIndex = 335
            Me.GroupBox2.TabStop = False
            '
            'errValidacion
            '
            Me.errValidacion.BlinkRate = 20
            Me.errValidacion.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
            Me.errValidacion.ContainerControl = Me
            '
            'btnGuardar
            '
            Me.btnGuardar.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = Global.Presentacion.My.Resources.Resources.Guardar
            Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnGuardar.Location = New System.Drawing.Point(0, 0)
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(70, 57)
            Me.btnGuardar.TabIndex = 315
            Me.btnGuardar.Text = "Guardar"
            Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnGuardar.UseVisualStyleBackColor = True
            '
            'btnLimpiar
            '
            Me.btnLimpiar.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnLimpiar.Image = Global.Presentacion.My.Resources.Resources.Limpiar
            Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnLimpiar.Location = New System.Drawing.Point(69, 0)
            Me.btnLimpiar.Name = "btnLimpiar"
            Me.btnLimpiar.Size = New System.Drawing.Size(70, 57)
            Me.btnLimpiar.TabIndex = 304
            Me.btnLimpiar.Text = "Limpiar"
            Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnLimpiar.UseVisualStyleBackColor = True
            '
            'FrmDevoluciones
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(728, 427)
            Me.Controls.Add(Me.dgvProveedores)
            Me.Controls.Add(Me.dgvProductos)
            Me.Controls.Add(Me.GroupBox2)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.txtObservaciones)
            Me.Controls.Add(Me.lblObservaciones)
            Me.Controls.Add(Me.txtMotivo)
            Me.Controls.Add(Me.lblMotivo)
            Me.Controls.Add(Me.btnGuardar)
            Me.Controls.Add(Me.dgvDevoluciones)
            Me.Controls.Add(Me.txtCodigo)
            Me.Controls.Add(Me.lblCodigo)
            Me.Controls.Add(Me.txtProducto)
            Me.Controls.Add(Me.lblProducto)
            Me.Controls.Add(Me.txtCantidad)
            Me.Controls.Add(Me.lblCantidad)
            Me.Controls.Add(Me.txtNumFactura)
            Me.Controls.Add(Me.lblNumFactura)
            Me.Controls.Add(Me.btnLimpiar)
            Me.Controls.Add(Me.txtNombre)
            Me.Controls.Add(Me.lblNombre)
            Me.Controls.Add(Me.txtId_Proveedor)
            Me.Controls.Add(Me.lblIdProveedor)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmDevoluciones"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Devoluciones y Cambios"
            CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvDevoluciones, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            CType(Me.errValidacion, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvProveedores As System.Windows.Forms.DataGridView
        Friend WithEvents txtNombre As System.Windows.Forms.TextBox
        Friend WithEvents lblNombre As System.Windows.Forms.Label
        Friend WithEvents txtId_Proveedor As System.Windows.Forms.TextBox
        Friend WithEvents lblIdProveedor As System.Windows.Forms.Label
        Friend WithEvents btnLimpiar As System.Windows.Forms.Button
        Friend WithEvents txtNumFactura As System.Windows.Forms.TextBox
        Friend WithEvents lblNumFactura As System.Windows.Forms.Label
        Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
        Friend WithEvents lblCantidad As System.Windows.Forms.Label
        Friend WithEvents txtProducto As System.Windows.Forms.TextBox
        Friend WithEvents lblProducto As System.Windows.Forms.Label
        Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
        Friend WithEvents lblCodigo As System.Windows.Forms.Label
        Friend WithEvents dgvDevoluciones As System.Windows.Forms.DataGridView
        Friend WithEvents btnGuardar As System.Windows.Forms.Button
        Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Producto As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents NumFactura As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Tipo As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Motivo As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents txtMotivo As System.Windows.Forms.TextBox
        Friend WithEvents lblMotivo As System.Windows.Forms.Label
        Friend WithEvents dgvProductos As System.Windows.Forms.DataGridView
        Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
        Friend WithEvents lblObservaciones As System.Windows.Forms.Label
        Friend WithEvents rbNc As System.Windows.Forms.RadioButton
        Friend WithEvents rbCambio As System.Windows.Forms.RadioButton
        Friend WithEvents lblFecha As System.Windows.Forms.Label
        Friend WithEvents txtFecha As System.Windows.Forms.TextBox
        Friend WithEvents lblNumBoleta As System.Windows.Forms.Label
        Friend WithEvents txtNumBoleta As System.Windows.Forms.TextBox
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents errValidacion As System.Windows.Forms.ErrorProvider
    End Class
End Namespace