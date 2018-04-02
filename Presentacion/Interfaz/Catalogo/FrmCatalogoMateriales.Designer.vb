Namespace Interfaz.Catalogo
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmCatalogoMateriales
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
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCatalogoMateriales))
            Me.lblRangoVista = New System.Windows.Forms.Label()
            Me.txtRangoVista = New System.Windows.Forms.TextBox()
            Me.lblCodigo = New System.Windows.Forms.Label()
            Me.lblDescripcion = New System.Windows.Forms.Label()
            Me.txtCodigo = New System.Windows.Forms.TextBox()
            Me.txtDescripcion = New System.Windows.Forms.TextBox()
            Me.txtPrecioCosto = New System.Windows.Forms.TextBox()
            Me.lblPrecio_Costo = New System.Windows.Forms.Label()
            Me.txtGanancia = New System.Windows.Forms.TextBox()
            Me.lblGanancia = New System.Windows.Forms.Label()
            Me.txtExistTotal = New System.Windows.Forms.TextBox()
            Me.lblExistTotal = New System.Windows.Forms.Label()
            Me.txtMinimo = New System.Windows.Forms.TextBox()
            Me.lblMinimo = New System.Windows.Forms.Label()
            Me.txtMaximo = New System.Windows.Forms.TextBox()
            Me.lblMaximo = New System.Windows.Forms.Label()
            Me.chkImpuesto = New System.Windows.Forms.CheckBox()
            Me.txtPrecio_Venta = New System.Windows.Forms.TextBox()
            Me.lblPrecio_Venta = New System.Windows.Forms.Label()
            Me.chkConsignacion = New System.Windows.Forms.CheckBox()
            Me.errCatalogo = New System.Windows.Forms.ErrorProvider(Me.components)
            Me.dgvMostrarProductos = New System.Windows.Forms.DataGridView()
            Me.MnEliminar = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.VerDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.lblMaxVendido = New System.Windows.Forms.Label()
            Me.txtMaxVendido = New System.Windows.Forms.TextBox()
            Me.txtExistReal = New System.Windows.Forms.TextBox()
            Me.lblExistReal = New System.Windows.Forms.Label()
            Me.btnRelacionados = New System.Windows.Forms.Button()
            Me.dgvProductos = New System.Windows.Forms.DataGridView()
            Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Gan = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Exist = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Imp = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.Min = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Max = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.txtExist_Bodega = New System.Windows.Forms.TextBox()
            Me.lblExis_Bodega = New System.Windows.Forms.Label()
            Me.gbOtros = New System.Windows.Forms.GroupBox()
            Me.btnProveedores = New System.Windows.Forms.Button()
            Me.chkOtros = New System.Windows.Forms.CheckBox()
            Me.txtMaximoCaja = New System.Windows.Forms.TextBox()
            Me.lblMaximoCaja = New System.Windows.Forms.Label()
            Me.gbBodega = New System.Windows.Forms.GroupBox()
            Me.txtExistList = New System.Windows.Forms.TextBox()
            Me.lblExistList = New System.Windows.Forms.Label()
            Me.btnTrasladar = New System.Windows.Forms.Button()
            Me.btnGuardar = New System.Windows.Forms.Button()
            Me.btnEliminar = New System.Windows.Forms.Button()
            Me.btnLimpiar = New System.Windows.Forms.Button()
            CType(Me.errCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvMostrarProductos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MnEliminar.SuspendLayout()
            CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbOtros.SuspendLayout()
            Me.gbBodega.SuspendLayout()
            Me.SuspendLayout()
            '
            'lblRangoVista
            '
            Me.lblRangoVista.AutoSize = True
            Me.lblRangoVista.BackColor = System.Drawing.Color.Transparent
            Me.lblRangoVista.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblRangoVista.Location = New System.Drawing.Point(446, 9)
            Me.lblRangoVista.Name = "lblRangoVista"
            Me.lblRangoVista.Size = New System.Drawing.Size(100, 15)
            Me.lblRangoVista.TabIndex = 4
            Me.lblRangoVista.Text = "Rango de la Vista"
            '
            'txtRangoVista
            '
            Me.txtRangoVista.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtRangoVista.Location = New System.Drawing.Point(459, 25)
            Me.txtRangoVista.Name = "txtRangoVista"
            Me.txtRangoVista.Size = New System.Drawing.Size(69, 20)
            Me.txtRangoVista.TabIndex = 12
            Me.txtRangoVista.Text = "10"
            Me.txtRangoVista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'lblCodigo
            '
            Me.lblCodigo.AutoSize = True
            Me.lblCodigo.BackColor = System.Drawing.Color.Transparent
            Me.lblCodigo.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCodigo.Location = New System.Drawing.Point(0, 65)
            Me.lblCodigo.Name = "lblCodigo"
            Me.lblCodigo.Size = New System.Drawing.Size(45, 15)
            Me.lblCodigo.TabIndex = 6
            Me.lblCodigo.Text = "Código"
            '
            'lblDescripcion
            '
            Me.lblDescripcion.AutoSize = True
            Me.lblDescripcion.BackColor = System.Drawing.Color.Transparent
            Me.lblDescripcion.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDescripcion.Location = New System.Drawing.Point(67, 65)
            Me.lblDescripcion.Name = "lblDescripcion"
            Me.lblDescripcion.Size = New System.Drawing.Size(140, 15)
            Me.lblDescripcion.TabIndex = 7
            Me.lblDescripcion.Text = "Descripción del Material"
            '
            'txtCodigo
            '
            Me.txtCodigo.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtCodigo.Location = New System.Drawing.Point(3, 81)
            Me.txtCodigo.MaxLength = 7
            Me.txtCodigo.Name = "txtCodigo"
            Me.txtCodigo.Size = New System.Drawing.Size(63, 20)
            Me.txtCodigo.TabIndex = 0
            Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtDescripcion
            '
            Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
            Me.txtDescripcion.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtDescripcion.Location = New System.Drawing.Point(70, 81)
            Me.txtDescripcion.MaxLength = 65
            Me.txtDescripcion.Name = "txtDescripcion"
            Me.txtDescripcion.Size = New System.Drawing.Size(537, 20)
            Me.txtDescripcion.TabIndex = 1
            '
            'txtPrecioCosto
            '
            Me.txtPrecioCosto.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtPrecioCosto.Location = New System.Drawing.Point(613, 81)
            Me.txtPrecioCosto.MaxLength = 15
            Me.txtPrecioCosto.Name = "txtPrecioCosto"
            Me.txtPrecioCosto.Size = New System.Drawing.Size(89, 20)
            Me.txtPrecioCosto.TabIndex = 2
            Me.txtPrecioCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblPrecio_Costo
            '
            Me.lblPrecio_Costo.AutoSize = True
            Me.lblPrecio_Costo.BackColor = System.Drawing.Color.Transparent
            Me.lblPrecio_Costo.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPrecio_Costo.Location = New System.Drawing.Point(610, 65)
            Me.lblPrecio_Costo.Name = "lblPrecio_Costo"
            Me.lblPrecio_Costo.Size = New System.Drawing.Size(76, 15)
            Me.lblPrecio_Costo.TabIndex = 11
            Me.lblPrecio_Costo.Text = "Precio Costo"
            '
            'txtGanancia
            '
            Me.txtGanancia.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtGanancia.Location = New System.Drawing.Point(7, 117)
            Me.txtGanancia.MaxLength = 4
            Me.txtGanancia.Name = "txtGanancia"
            Me.txtGanancia.Size = New System.Drawing.Size(42, 20)
            Me.txtGanancia.TabIndex = 3
            Me.txtGanancia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblGanancia
            '
            Me.lblGanancia.AutoSize = True
            Me.lblGanancia.BackColor = System.Drawing.Color.Transparent
            Me.lblGanancia.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblGanancia.Location = New System.Drawing.Point(0, 103)
            Me.lblGanancia.Name = "lblGanancia"
            Me.lblGanancia.Size = New System.Drawing.Size(56, 15)
            Me.lblGanancia.TabIndex = 13
            Me.lblGanancia.Text = "Ganancia"
            '
            'txtExistTotal
            '
            Me.txtExistTotal.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtExistTotal.Enabled = False
            Me.txtExistTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtExistTotal.Location = New System.Drawing.Point(127, 118)
            Me.txtExistTotal.MaxLength = 10
            Me.txtExistTotal.Name = "txtExistTotal"
            Me.txtExistTotal.ReadOnly = True
            Me.txtExistTotal.Size = New System.Drawing.Size(50, 20)
            Me.txtExistTotal.TabIndex = 4
            Me.txtExistTotal.Text = "0"
            Me.txtExistTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblExistTotal
            '
            Me.lblExistTotal.AutoSize = True
            Me.lblExistTotal.BackColor = System.Drawing.Color.Transparent
            Me.lblExistTotal.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblExistTotal.Location = New System.Drawing.Point(125, 103)
            Me.lblExistTotal.Name = "lblExistTotal"
            Me.lblExistTotal.Size = New System.Drawing.Size(44, 15)
            Me.lblExistTotal.TabIndex = 15
            Me.lblExistTotal.Text = "E-Total"
            '
            'txtMinimo
            '
            Me.txtMinimo.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtMinimo.Location = New System.Drawing.Point(251, 119)
            Me.txtMinimo.MaxLength = 10
            Me.txtMinimo.Name = "txtMinimo"
            Me.txtMinimo.Size = New System.Drawing.Size(50, 20)
            Me.txtMinimo.TabIndex = 5
            Me.txtMinimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblMinimo
            '
            Me.lblMinimo.AutoSize = True
            Me.lblMinimo.BackColor = System.Drawing.Color.Transparent
            Me.lblMinimo.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMinimo.Location = New System.Drawing.Point(248, 104)
            Me.lblMinimo.Name = "lblMinimo"
            Me.lblMinimo.Size = New System.Drawing.Size(49, 15)
            Me.lblMinimo.TabIndex = 17
            Me.lblMinimo.Text = "Mínimo"
            '
            'txtMaximo
            '
            Me.txtMaximo.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtMaximo.Location = New System.Drawing.Point(307, 119)
            Me.txtMaximo.MaxLength = 10
            Me.txtMaximo.Name = "txtMaximo"
            Me.txtMaximo.Size = New System.Drawing.Size(53, 20)
            Me.txtMaximo.TabIndex = 6
            Me.txtMaximo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblMaximo
            '
            Me.lblMaximo.AutoSize = True
            Me.lblMaximo.BackColor = System.Drawing.Color.Transparent
            Me.lblMaximo.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMaximo.Location = New System.Drawing.Point(308, 104)
            Me.lblMaximo.Name = "lblMaximo"
            Me.lblMaximo.Size = New System.Drawing.Size(52, 15)
            Me.lblMaximo.TabIndex = 19
            Me.lblMaximo.Text = "Máximo"
            '
            'chkImpuesto
            '
            Me.chkImpuesto.AutoSize = True
            Me.chkImpuesto.BackColor = System.Drawing.Color.Transparent
            Me.chkImpuesto.CheckAlign = System.Drawing.ContentAlignment.TopLeft
            Me.chkImpuesto.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
            Me.chkImpuesto.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkImpuesto.Location = New System.Drawing.Point(445, 118)
            Me.chkImpuesto.Name = "chkImpuesto"
            Me.chkImpuesto.Size = New System.Drawing.Size(139, 18)
            Me.chkImpuesto.TabIndex = 7
            Me.chkImpuesto.Text = "Aplicar Impuesto (13%)"
            Me.chkImpuesto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.chkImpuesto.UseVisualStyleBackColor = False
            '
            'txtPrecio_Venta
            '
            Me.txtPrecio_Venta.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtPrecio_Venta.Enabled = False
            Me.txtPrecio_Venta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPrecio_Venta.Location = New System.Drawing.Point(606, 115)
            Me.txtPrecio_Venta.MaxLength = 14
            Me.txtPrecio_Venta.Name = "txtPrecio_Venta"
            Me.txtPrecio_Venta.ReadOnly = True
            Me.txtPrecio_Venta.Size = New System.Drawing.Size(96, 20)
            Me.txtPrecio_Venta.TabIndex = 23
            Me.txtPrecio_Venta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblPrecio_Venta
            '
            Me.lblPrecio_Venta.AutoSize = True
            Me.lblPrecio_Venta.BackColor = System.Drawing.Color.Transparent
            Me.lblPrecio_Venta.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPrecio_Venta.Location = New System.Drawing.Point(612, 101)
            Me.lblPrecio_Venta.Name = "lblPrecio_Venta"
            Me.lblPrecio_Venta.Size = New System.Drawing.Size(77, 15)
            Me.lblPrecio_Venta.TabIndex = 24
            Me.lblPrecio_Venta.Text = "Precio Venta"
            '
            'chkConsignacion
            '
            Me.chkConsignacion.AutoSize = True
            Me.chkConsignacion.BackColor = System.Drawing.Color.Transparent
            Me.chkConsignacion.CheckAlign = System.Drawing.ContentAlignment.TopLeft
            Me.chkConsignacion.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkConsignacion.Location = New System.Drawing.Point(265, 22)
            Me.chkConsignacion.Name = "chkConsignacion"
            Me.chkConsignacion.Size = New System.Drawing.Size(112, 18)
            Me.chkConsignacion.TabIndex = 8
            Me.chkConsignacion.Text = "En Consignación"
            Me.chkConsignacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.chkConsignacion.UseVisualStyleBackColor = False
            '
            'errCatalogo
            '
            Me.errCatalogo.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
            Me.errCatalogo.ContainerControl = Me
            '
            'dgvMostrarProductos
            '
            Me.dgvMostrarProductos.AllowUserToAddRows = False
            Me.dgvMostrarProductos.AllowUserToDeleteRows = False
            Me.dgvMostrarProductos.AllowUserToResizeColumns = False
            Me.dgvMostrarProductos.BackgroundColor = System.Drawing.Color.White
            Me.dgvMostrarProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            Me.dgvMostrarProductos.GridColor = System.Drawing.Color.White
            Me.dgvMostrarProductos.Location = New System.Drawing.Point(70, 102)
            Me.dgvMostrarProductos.MultiSelect = False
            Me.dgvMostrarProductos.Name = "dgvMostrarProductos"
            Me.dgvMostrarProductos.ReadOnly = True
            Me.dgvMostrarProductos.RowHeadersVisible = False
            Me.dgvMostrarProductos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvMostrarProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvMostrarProductos.Size = New System.Drawing.Size(476, 150)
            Me.dgvMostrarProductos.TabIndex = 37
            Me.dgvMostrarProductos.Visible = False
            '
            'MnEliminar
            '
            Me.MnEliminar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarToolStripMenuItem, Me.VerDatosToolStripMenuItem})
            Me.MnEliminar.Name = "MnEliminar"
            Me.MnEliminar.Size = New System.Drawing.Size(125, 48)
            '
            'EliminarToolStripMenuItem
            '
            Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
            Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
            Me.EliminarToolStripMenuItem.Text = "Eliminar"
            '
            'VerDatosToolStripMenuItem
            '
            Me.VerDatosToolStripMenuItem.Name = "VerDatosToolStripMenuItem"
            Me.VerDatosToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
            Me.VerDatosToolStripMenuItem.Text = "Ver Datos"
            '
            'lblMaxVendido
            '
            Me.lblMaxVendido.AutoSize = True
            Me.lblMaxVendido.BackColor = System.Drawing.Color.Transparent
            Me.lblMaxVendido.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMaxVendido.Location = New System.Drawing.Point(366, 104)
            Me.lblMaxVendido.Name = "lblMaxVendido"
            Me.lblMaxVendido.Size = New System.Drawing.Size(76, 15)
            Me.lblMaxVendido.TabIndex = 38
            Me.lblMaxVendido.Text = "MáxVendido"
            '
            'txtMaxVendido
            '
            Me.txtMaxVendido.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtMaxVendido.Enabled = False
            Me.txtMaxVendido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMaxVendido.Location = New System.Drawing.Point(373, 119)
            Me.txtMaxVendido.MaxLength = 10
            Me.txtMaxVendido.Name = "txtMaxVendido"
            Me.txtMaxVendido.ReadOnly = True
            Me.txtMaxVendido.Size = New System.Drawing.Size(60, 20)
            Me.txtMaxVendido.TabIndex = 39
            Me.txtMaxVendido.Text = "0"
            Me.txtMaxVendido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtExistReal
            '
            Me.txtExistReal.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtExistReal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtExistReal.Location = New System.Drawing.Point(70, 119)
            Me.txtExistReal.MaxLength = 10
            Me.txtExistReal.Name = "txtExistReal"
            Me.txtExistReal.Size = New System.Drawing.Size(50, 20)
            Me.txtExistReal.TabIndex = 41
            Me.txtExistReal.Text = "0"
            Me.txtExistReal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblExistReal
            '
            Me.lblExistReal.AutoSize = True
            Me.lblExistReal.BackColor = System.Drawing.Color.Transparent
            Me.lblExistReal.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblExistReal.Location = New System.Drawing.Point(67, 104)
            Me.lblExistReal.Name = "lblExistReal"
            Me.lblExistReal.Size = New System.Drawing.Size(48, 15)
            Me.lblExistReal.TabIndex = 42
            Me.lblExistReal.Text = "E-Stock"
            '
            'btnRelacionados
            '
            Me.btnRelacionados.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnRelacionados.Location = New System.Drawing.Point(150, 19)
            Me.btnRelacionados.Name = "btnRelacionados"
            Me.btnRelacionados.Size = New System.Drawing.Size(167, 21)
            Me.btnRelacionados.TabIndex = 45
            Me.btnRelacionados.Text = "Productos Relacionados"
            Me.btnRelacionados.UseVisualStyleBackColor = True
            '
            'dgvProductos
            '
            Me.dgvProductos.AllowUserToAddRows = False
            Me.dgvProductos.AllowUserToResizeColumns = False
            Me.dgvProductos.BackgroundColor = System.Drawing.Color.White
            Me.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
            Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Descripcion, Me.Precio, Me.Gan, Me.Exist, Me.Imp, Me.Min, Me.Max})
            Me.dgvProductos.GridColor = System.Drawing.Color.White
            Me.dgvProductos.Location = New System.Drawing.Point(7, 193)
            Me.dgvProductos.MultiSelect = False
            Me.dgvProductos.Name = "dgvProductos"
            Me.dgvProductos.ReadOnly = True
            Me.dgvProductos.RowHeadersVisible = False
            Me.dgvProductos.RowTemplate.Height = 20
            Me.dgvProductos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvProductos.Size = New System.Drawing.Size(739, 287)
            Me.dgvProductos.TabIndex = 46
            '
            'Codigo
            '
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Codigo.DefaultCellStyle = DataGridViewCellStyle1
            Me.Codigo.HeaderText = "Código"
            Me.Codigo.Name = "Codigo"
            Me.Codigo.ReadOnly = True
            Me.Codigo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.Codigo.Width = 50
            '
            'Descripcion
            '
            Me.Descripcion.HeaderText = "Descripción"
            Me.Descripcion.Name = "Descripcion"
            Me.Descripcion.ReadOnly = True
            Me.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.Descripcion.Width = 365
            '
            'Precio
            '
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle2.Format = "N2"
            DataGridViewCellStyle2.NullValue = Nothing
            Me.Precio.DefaultCellStyle = DataGridViewCellStyle2
            Me.Precio.HeaderText = "Precio"
            Me.Precio.Name = "Precio"
            Me.Precio.ReadOnly = True
            Me.Precio.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.Precio.Width = 75
            '
            'Gan
            '
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Gan.DefaultCellStyle = DataGridViewCellStyle3
            Me.Gan.HeaderText = "Gan"
            Me.Gan.Name = "Gan"
            Me.Gan.ReadOnly = True
            Me.Gan.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.Gan.Width = 40
            '
            'Exist
            '
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle4.Format = "N2"
            DataGridViewCellStyle4.NullValue = Nothing
            Me.Exist.DefaultCellStyle = DataGridViewCellStyle4
            Me.Exist.HeaderText = "Exist"
            Me.Exist.Name = "Exist"
            Me.Exist.ReadOnly = True
            Me.Exist.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.Exist.Width = 60
            '
            'Imp
            '
            Me.Imp.HeaderText = "Imp"
            Me.Imp.Name = "Imp"
            Me.Imp.ReadOnly = True
            Me.Imp.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.Imp.Width = 35
            '
            'Min
            '
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Min.DefaultCellStyle = DataGridViewCellStyle5
            Me.Min.HeaderText = "Mín"
            Me.Min.Name = "Min"
            Me.Min.ReadOnly = True
            Me.Min.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.Min.Width = 40
            '
            'Max
            '
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Max.DefaultCellStyle = DataGridViewCellStyle6
            Me.Max.HeaderText = "Máx"
            Me.Max.Name = "Max"
            Me.Max.ReadOnly = True
            Me.Max.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.Max.Width = 40
            '
            'txtExist_Bodega
            '
            Me.txtExist_Bodega.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtExist_Bodega.Enabled = False
            Me.txtExist_Bodega.Location = New System.Drawing.Point(66, 23)
            Me.txtExist_Bodega.MaxLength = 10
            Me.txtExist_Bodega.Name = "txtExist_Bodega"
            Me.txtExist_Bodega.Size = New System.Drawing.Size(50, 20)
            Me.txtExist_Bodega.TabIndex = 48
            Me.txtExist_Bodega.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblExis_Bodega
            '
            Me.lblExis_Bodega.AutoSize = True
            Me.lblExis_Bodega.BackColor = System.Drawing.Color.Transparent
            Me.lblExis_Bodega.Enabled = False
            Me.lblExis_Bodega.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblExis_Bodega.Location = New System.Drawing.Point(67, 7)
            Me.lblExis_Bodega.Name = "lblExis_Bodega"
            Me.lblExis_Bodega.Size = New System.Drawing.Size(49, 15)
            Me.lblExis_Bodega.TabIndex = 49
            Me.lblExis_Bodega.Text = "Bodega"
            '
            'gbOtros
            '
            Me.gbOtros.Controls.Add(Me.btnProveedores)
            Me.gbOtros.Controls.Add(Me.btnRelacionados)
            Me.gbOtros.Location = New System.Drawing.Point(6, 141)
            Me.gbOtros.Name = "gbOtros"
            Me.gbOtros.Size = New System.Drawing.Size(342, 48)
            Me.gbOtros.TabIndex = 50
            Me.gbOtros.TabStop = False
            '
            'btnProveedores
            '
            Me.btnProveedores.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnProveedores.Location = New System.Drawing.Point(16, 19)
            Me.btnProveedores.Name = "btnProveedores"
            Me.btnProveedores.Size = New System.Drawing.Size(115, 21)
            Me.btnProveedores.TabIndex = 44
            Me.btnProveedores.Text = "Proveedores"
            Me.btnProveedores.UseVisualStyleBackColor = True
            '
            'chkOtros
            '
            Me.chkOtros.AutoSize = True
            Me.chkOtros.Location = New System.Drawing.Point(6, 22)
            Me.chkOtros.Name = "chkOtros"
            Me.chkOtros.Size = New System.Drawing.Size(51, 17)
            Me.chkOtros.TabIndex = 50
            Me.chkOtros.Text = "Otros"
            Me.chkOtros.UseVisualStyleBackColor = True
            '
            'txtMaximoCaja
            '
            Me.txtMaximoCaja.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtMaximoCaja.Enabled = False
            Me.txtMaximoCaja.Location = New System.Drawing.Point(134, 22)
            Me.txtMaximoCaja.MaxLength = 10
            Me.txtMaximoCaja.Name = "txtMaximoCaja"
            Me.txtMaximoCaja.Size = New System.Drawing.Size(50, 20)
            Me.txtMaximoCaja.TabIndex = 51
            Me.txtMaximoCaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblMaximoCaja
            '
            Me.lblMaximoCaja.AutoSize = True
            Me.lblMaximoCaja.BackColor = System.Drawing.Color.Transparent
            Me.lblMaximoCaja.Enabled = False
            Me.lblMaximoCaja.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMaximoCaja.Location = New System.Drawing.Point(124, 7)
            Me.lblMaximoCaja.Name = "lblMaximoCaja"
            Me.lblMaximoCaja.Size = New System.Drawing.Size(87, 15)
            Me.lblMaximoCaja.TabIndex = 52
            Me.lblMaximoCaja.Text = "Capacidad Caja"
            '
            'gbBodega
            '
            Me.gbBodega.Controls.Add(Me.txtExist_Bodega)
            Me.gbBodega.Controls.Add(Me.txtMaximoCaja)
            Me.gbBodega.Controls.Add(Me.lblExis_Bodega)
            Me.gbBodega.Controls.Add(Me.lblMaximoCaja)
            Me.gbBodega.Controls.Add(Me.chkConsignacion)
            Me.gbBodega.Controls.Add(Me.chkOtros)
            Me.gbBodega.Location = New System.Drawing.Point(348, 141)
            Me.gbBodega.Name = "gbBodega"
            Me.gbBodega.Size = New System.Drawing.Size(386, 48)
            Me.gbBodega.TabIndex = 46
            Me.gbBodega.TabStop = False
            '
            'txtExistList
            '
            Me.txtExistList.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtExistList.Enabled = False
            Me.txtExistList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtExistList.Location = New System.Drawing.Point(186, 118)
            Me.txtExistList.MaxLength = 10
            Me.txtExistList.Name = "txtExistList"
            Me.txtExistList.ReadOnly = True
            Me.txtExistList.Size = New System.Drawing.Size(50, 20)
            Me.txtExistList.TabIndex = 51
            Me.txtExistList.Text = "0"
            Me.txtExistList.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblExistList
            '
            Me.lblExistList.AutoSize = True
            Me.lblExistList.BackColor = System.Drawing.Color.Transparent
            Me.lblExistList.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblExistList.Location = New System.Drawing.Point(183, 103)
            Me.lblExistList.Name = "lblExistList"
            Me.lblExistList.Size = New System.Drawing.Size(61, 15)
            Me.lblExistList.TabIndex = 52
            Me.lblExistList.Text = "E-Listados"
            '
            'btnTrasladar
            '
            Me.btnTrasladar.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnTrasladar.Image = Global.Presentacion.My.Resources.Resources.trasladar
            Me.btnTrasladar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnTrasladar.Location = New System.Drawing.Point(70, 0)
            Me.btnTrasladar.Name = "btnTrasladar"
            Me.btnTrasladar.Size = New System.Drawing.Size(71, 57)
            Me.btnTrasladar.TabIndex = 40
            Me.btnTrasladar.Text = "Trasladar"
            Me.btnTrasladar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnTrasladar.UseVisualStyleBackColor = True
            '
            'btnGuardar
            '
            Me.btnGuardar.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = Global.Presentacion.My.Resources.Resources.Guardar
            Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnGuardar.Location = New System.Drawing.Point(0, 0)
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(71, 57)
            Me.btnGuardar.TabIndex = 14
            Me.btnGuardar.Text = "Guardar"
            Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnGuardar.UseVisualStyleBackColor = True
            '
            'btnEliminar
            '
            Me.btnEliminar.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliminar.Image = Global.Presentacion.My.Resources.Resources.Eliminar
            Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnEliminar.Location = New System.Drawing.Point(140, 0)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(71, 57)
            Me.btnEliminar.TabIndex = 15
            Me.btnEliminar.Text = "Eliminar"
            Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnEliminar.UseVisualStyleBackColor = True
            '
            'btnLimpiar
            '
            Me.btnLimpiar.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnLimpiar.Image = Global.Presentacion.My.Resources.Resources.Limpiar
            Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnLimpiar.Location = New System.Drawing.Point(210, 0)
            Me.btnLimpiar.Name = "btnLimpiar"
            Me.btnLimpiar.Size = New System.Drawing.Size(71, 57)
            Me.btnLimpiar.TabIndex = 13
            Me.btnLimpiar.Text = "Limpiar"
            Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnLimpiar.UseVisualStyleBackColor = True
            '
            'FrmCatalogoMateriales
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.ClientSize = New System.Drawing.Size(751, 483)
            Me.Controls.Add(Me.dgvMostrarProductos)
            Me.Controls.Add(Me.gbBodega)
            Me.Controls.Add(Me.dgvProductos)
            Me.Controls.Add(Me.txtExistList)
            Me.Controls.Add(Me.btnTrasladar)
            Me.Controls.Add(Me.lblExistList)
            Me.Controls.Add(Me.txtPrecio_Venta)
            Me.Controls.Add(Me.lblPrecio_Venta)
            Me.Controls.Add(Me.txtGanancia)
            Me.Controls.Add(Me.chkImpuesto)
            Me.Controls.Add(Me.lblGanancia)
            Me.Controls.Add(Me.txtMaximo)
            Me.Controls.Add(Me.lblMaximo)
            Me.Controls.Add(Me.txtMinimo)
            Me.Controls.Add(Me.lblMinimo)
            Me.Controls.Add(Me.txtExistTotal)
            Me.Controls.Add(Me.txtPrecioCosto)
            Me.Controls.Add(Me.lblPrecio_Costo)
            Me.Controls.Add(Me.lblExistTotal)
            Me.Controls.Add(Me.txtDescripcion)
            Me.Controls.Add(Me.txtCodigo)
            Me.Controls.Add(Me.lblDescripcion)
            Me.Controls.Add(Me.lblCodigo)
            Me.Controls.Add(Me.txtRangoVista)
            Me.Controls.Add(Me.lblRangoVista)
            Me.Controls.Add(Me.btnGuardar)
            Me.Controls.Add(Me.btnEliminar)
            Me.Controls.Add(Me.btnLimpiar)
            Me.Controls.Add(Me.txtExistReal)
            Me.Controls.Add(Me.lblExistReal)
            Me.Controls.Add(Me.gbOtros)
            Me.Controls.Add(Me.txtMaxVendido)
            Me.Controls.Add(Me.lblMaxVendido)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmCatalogoMateriales"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Catalogo de Materiales"
            CType(Me.errCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvMostrarProductos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MnEliminar.ResumeLayout(False)
            CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbOtros.ResumeLayout(False)
            Me.gbBodega.ResumeLayout(False)
            Me.gbBodega.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents btnLimpiar As System.Windows.Forms.Button
        Friend WithEvents btnEliminar As System.Windows.Forms.Button
        Friend WithEvents btnGuardar As System.Windows.Forms.Button
        Friend WithEvents lblRangoVista As System.Windows.Forms.Label
        Friend WithEvents txtRangoVista As System.Windows.Forms.TextBox
        Friend WithEvents lblCodigo As System.Windows.Forms.Label
        Friend WithEvents lblDescripcion As System.Windows.Forms.Label
        Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
        Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
        Friend WithEvents txtPrecioCosto As System.Windows.Forms.TextBox
        Friend WithEvents lblPrecio_Costo As System.Windows.Forms.Label
        Friend WithEvents txtGanancia As System.Windows.Forms.TextBox
        Friend WithEvents lblGanancia As System.Windows.Forms.Label
        Friend WithEvents txtExistTotal As System.Windows.Forms.TextBox
        Friend WithEvents lblExistTotal As System.Windows.Forms.Label
        Friend WithEvents txtMinimo As System.Windows.Forms.TextBox
        Friend WithEvents lblMinimo As System.Windows.Forms.Label
        Friend WithEvents txtMaximo As System.Windows.Forms.TextBox
        Friend WithEvents lblMaximo As System.Windows.Forms.Label
        Friend WithEvents chkImpuesto As System.Windows.Forms.CheckBox
        Friend WithEvents txtPrecio_Venta As System.Windows.Forms.TextBox
        Friend WithEvents lblPrecio_Venta As System.Windows.Forms.Label
        Friend WithEvents chkConsignacion As System.Windows.Forms.CheckBox
        Friend WithEvents errCatalogo As System.Windows.Forms.ErrorProvider
        Friend WithEvents dgvMostrarProductos As System.Windows.Forms.DataGridView
        Friend WithEvents MnEliminar As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents txtMaxVendido As System.Windows.Forms.TextBox
        Friend WithEvents lblMaxVendido As System.Windows.Forms.Label
        Friend WithEvents btnTrasladar As System.Windows.Forms.Button
        Friend WithEvents txtExistReal As System.Windows.Forms.TextBox
        Friend WithEvents lblExistReal As System.Windows.Forms.Label
        Friend WithEvents VerDatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnProveedores As System.Windows.Forms.Button
        Friend WithEvents btnRelacionados As System.Windows.Forms.Button
        Friend WithEvents dgvProductos As System.Windows.Forms.DataGridView
        Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Gan As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Exist As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Imp As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents Min As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Max As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents txtExist_Bodega As System.Windows.Forms.TextBox
        Friend WithEvents lblExis_Bodega As System.Windows.Forms.Label
        Friend WithEvents gbOtros As System.Windows.Forms.GroupBox
        Friend WithEvents chkOtros As System.Windows.Forms.CheckBox
        Friend WithEvents txtMaximoCaja As System.Windows.Forms.TextBox
        Friend WithEvents lblMaximoCaja As System.Windows.Forms.Label
        Friend WithEvents gbBodega As System.Windows.Forms.GroupBox
        Friend WithEvents txtExistList As System.Windows.Forms.TextBox
        Friend WithEvents lblExistList As System.Windows.Forms.Label
    End Class
End Namespace