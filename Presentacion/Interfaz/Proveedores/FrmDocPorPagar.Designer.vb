Namespace Interfaz.Proveedores
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmDocPorPagar
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDocPorPagar))
            Me.dgvProveedores = New System.Windows.Forms.DataGridView()
            Me.txtId_Proveedor = New System.Windows.Forms.TextBox()
            Me.lblId_Proveedor = New System.Windows.Forms.Label()
            Me.lblNumFactura = New System.Windows.Forms.Label()
            Me.btnLimpiar = New System.Windows.Forms.Button()
            Me.btnInsertar = New System.Windows.Forms.Button()
            Me.txtNombreProveedor = New System.Windows.Forms.TextBox()
            Me.lblNombreProveedor = New System.Windows.Forms.Label()
            Me.txtNumFactura = New System.Windows.Forms.TextBox()
            Me.lblFecha = New System.Windows.Forms.Label()
            Me.lblSubTotalIV = New System.Windows.Forms.Label()
            Me.txtSubTotalIV = New System.Windows.Forms.TextBox()
            Me.lblSubTotalEx = New System.Windows.Forms.Label()
            Me.txtSubTotalEx = New System.Windows.Forms.TextBox()
            Me.lblMes = New System.Windows.Forms.Label()
            Me.lblIV = New System.Windows.Forms.Label()
            Me.txtIV = New System.Windows.Forms.TextBox()
            Me.lblTotal = New System.Windows.Forms.Label()
            Me.txtTotal = New System.Windows.Forms.TextBox()
            Me.chkCancelada = New System.Windows.Forms.CheckBox()
            Me.lblFechaCancelacion = New System.Windows.Forms.Label()
            Me.gbCancelada = New System.Windows.Forms.GroupBox()
            Me.txtFechaCancelacion = New System.Windows.Forms.TextBox()
            Me.errorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
            Me.lblNumNC1 = New System.Windows.Forms.Label()
            Me.txtNumNC1 = New System.Windows.Forms.TextBox()
            Me.gbNotas = New System.Windows.Forms.GroupBox()
            Me.dgvNotas = New System.Windows.Forms.DataGridView()
            Me.Id_Nota = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.NDoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.chkDescuento = New System.Windows.Forms.CheckBox()
            Me.lblSubTotalExNC = New System.Windows.Forms.Label()
            Me.txtSubTotalExN = New System.Windows.Forms.TextBox()
            Me.lblSubTotalIVNC = New System.Windows.Forms.Label()
            Me.txtSubTotalIVN = New System.Windows.Forms.TextBox()
            Me.txtFechaBoleta1 = New System.Windows.Forms.TextBox()
            Me.lblFechaBoleta1 = New System.Windows.Forms.Label()
            Me.txtFechaNC1 = New System.Windows.Forms.TextBox()
            Me.lblBoleta1 = New System.Windows.Forms.Label()
            Me.txtBoleta1 = New System.Windows.Forms.TextBox()
            Me.lblMotivo1 = New System.Windows.Forms.Label()
            Me.txtMotivo1 = New System.Windows.Forms.TextBox()
            Me.lblIVNC1 = New System.Windows.Forms.Label()
            Me.txtIVNC1 = New System.Windows.Forms.TextBox()
            Me.lblFechaNC1 = New System.Windows.Forms.Label()
            Me.lblTotalNC1 = New System.Windows.Forms.Label()
            Me.txtTotalNC1 = New System.Windows.Forms.TextBox()
            Me.txtIdNota = New System.Windows.Forms.TextBox()
            Me.chkNuevaNota = New System.Windows.Forms.CheckBox()
            Me.btnLimpiarNC = New System.Windows.Forms.Button()
            Me.btnND = New System.Windows.Forms.Button()
            Me.btnNC = New System.Windows.Forms.Button()
            Me.btnAgregar = New System.Windows.Forms.Button()
            Me.txtFechaFactura = New System.Windows.Forms.TextBox()
            Me.txtIdDoc_PorPagar = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.cbMes = New System.Windows.Forms.ComboBox()
            Me.MenuEliminar = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.txtDias = New System.Windows.Forms.TextBox()
            Me.lblDias = New System.Windows.Forms.Label()
            Me.txtFechaIngreso = New System.Windows.Forms.TextBox()
            Me.chkAnulada = New System.Windows.Forms.CheckBox()
            Me.txtMotivoAnulada = New System.Windows.Forms.TextBox()
            Me.gbDocPagar = New System.Windows.Forms.GroupBox()
            Me.lblMotivoAnulada = New System.Windows.Forms.Label()
            Me.gbContado = New System.Windows.Forms.GroupBox()
            Me.rbContado = New System.Windows.Forms.RadioButton()
            Me.rbCredito = New System.Windows.Forms.RadioButton()
            Me.errorBlink = New System.Windows.Forms.ErrorProvider(Me.components)
            CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbCancelada.SuspendLayout()
            CType(Me.errorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbNotas.SuspendLayout()
            CType(Me.dgvNotas, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuEliminar.SuspendLayout()
            Me.gbDocPagar.SuspendLayout()
            Me.gbContado.SuspendLayout()
            CType(Me.errorBlink, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dgvProveedores
            '
            Me.dgvProveedores.AllowUserToAddRows = False
            Me.dgvProveedores.AllowUserToDeleteRows = False
            Me.dgvProveedores.BackgroundColor = System.Drawing.Color.White
            Me.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvProveedores.Location = New System.Drawing.Point(84, 50)
            Me.dgvProveedores.MultiSelect = False
            Me.dgvProveedores.Name = "dgvProveedores"
            Me.dgvProveedores.ReadOnly = True
            Me.dgvProveedores.RowHeadersVisible = False
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvProveedores.RowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvProveedores.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvProveedores.RowTemplate.Height = 18
            Me.dgvProveedores.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvProveedores.Size = New System.Drawing.Size(338, 122)
            Me.dgvProveedores.TabIndex = 62
            Me.dgvProveedores.Visible = False
            '
            'txtId_Proveedor
            '
            Me.txtId_Proveedor.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtId_Proveedor.Location = New System.Drawing.Point(21, 29)
            Me.txtId_Proveedor.MaxLength = 5
            Me.txtId_Proveedor.Name = "txtId_Proveedor"
            Me.txtId_Proveedor.Size = New System.Drawing.Size(50, 20)
            Me.txtId_Proveedor.TabIndex = 0
            Me.txtId_Proveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblId_Proveedor
            '
            Me.lblId_Proveedor.AutoSize = True
            Me.lblId_Proveedor.BackColor = System.Drawing.Color.Transparent
            Me.lblId_Proveedor.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblId_Proveedor.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblId_Proveedor.Location = New System.Drawing.Point(6, 12)
            Me.lblId_Proveedor.Name = "lblId_Proveedor"
            Me.lblId_Proveedor.Size = New System.Drawing.Size(79, 15)
            Me.lblId_Proveedor.TabIndex = 58
            Me.lblId_Proveedor.Text = "Id Proveedor"
            '
            'lblNumFactura
            '
            Me.lblNumFactura.AutoSize = True
            Me.lblNumFactura.BackColor = System.Drawing.Color.Transparent
            Me.lblNumFactura.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblNumFactura.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNumFactura.Location = New System.Drawing.Point(458, 12)
            Me.lblNumFactura.Name = "lblNumFactura"
            Me.lblNumFactura.Size = New System.Drawing.Size(78, 15)
            Me.lblNumFactura.TabIndex = 61
            Me.lblNumFactura.Text = "Num Factura"
            '
            'btnLimpiar
            '
            Me.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnLimpiar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnLimpiar.Image = Global.Presentacion.My.Resources.Resources.Limpiar
            Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnLimpiar.Location = New System.Drawing.Point(70, 0)
            Me.btnLimpiar.Name = "btnLimpiar"
            Me.btnLimpiar.Size = New System.Drawing.Size(71, 57)
            Me.btnLimpiar.TabIndex = 11
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
            Me.btnInsertar.TabIndex = 12
            Me.btnInsertar.Text = "Guardar"
            Me.btnInsertar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnInsertar.UseVisualStyleBackColor = True
            '
            'txtNombreProveedor
            '
            Me.txtNombreProveedor.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtNombreProveedor.Location = New System.Drawing.Point(84, 29)
            Me.txtNombreProveedor.MaxLength = 55
            Me.txtNombreProveedor.Name = "txtNombreProveedor"
            Me.txtNombreProveedor.Size = New System.Drawing.Size(371, 20)
            Me.txtNombreProveedor.TabIndex = 1
            '
            'lblNombreProveedor
            '
            Me.lblNombreProveedor.AutoSize = True
            Me.lblNombreProveedor.BackColor = System.Drawing.Color.Transparent
            Me.lblNombreProveedor.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblNombreProveedor.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombreProveedor.Location = New System.Drawing.Point(84, 12)
            Me.lblNombreProveedor.Name = "lblNombreProveedor"
            Me.lblNombreProveedor.Size = New System.Drawing.Size(114, 15)
            Me.lblNombreProveedor.TabIndex = 59
            Me.lblNombreProveedor.Text = "Nombre Proveedor"
            '
            'txtNumFactura
            '
            Me.txtNumFactura.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtNumFactura.Location = New System.Drawing.Point(461, 29)
            Me.txtNumFactura.MaxLength = 25
            Me.txtNumFactura.Name = "txtNumFactura"
            Me.txtNumFactura.Size = New System.Drawing.Size(104, 20)
            Me.txtNumFactura.TabIndex = 1
            '
            'lblFecha
            '
            Me.lblFecha.AutoSize = True
            Me.lblFecha.BackColor = System.Drawing.Color.Transparent
            Me.lblFecha.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblFecha.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFecha.Location = New System.Drawing.Point(17, 61)
            Me.lblFecha.Name = "lblFecha"
            Me.lblFecha.Size = New System.Drawing.Size(65, 15)
            Me.lblFecha.TabIndex = 60
            Me.lblFecha.Text = "Fecha Fact"
            '
            'lblSubTotalIV
            '
            Me.lblSubTotalIV.AutoSize = True
            Me.lblSubTotalIV.BackColor = System.Drawing.Color.Transparent
            Me.lblSubTotalIV.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblSubTotalIV.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubTotalIV.Location = New System.Drawing.Point(18, 113)
            Me.lblSubTotalIV.Name = "lblSubTotalIV"
            Me.lblSubTotalIV.Size = New System.Drawing.Size(79, 15)
            Me.lblSubTotalIV.TabIndex = 65
            Me.lblSubTotalIV.Text = "SubTotal (IV)"
            '
            'txtSubTotalIV
            '
            Me.txtSubTotalIV.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtSubTotalIV.Enabled = False
            Me.txtSubTotalIV.Location = New System.Drawing.Point(21, 131)
            Me.txtSubTotalIV.MaxLength = 15
            Me.txtSubTotalIV.Name = "txtSubTotalIV"
            Me.txtSubTotalIV.Size = New System.Drawing.Size(88, 20)
            Me.txtSubTotalIV.TabIndex = 4
            Me.txtSubTotalIV.Text = "0"
            Me.txtSubTotalIV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblSubTotalEx
            '
            Me.lblSubTotalEx.AutoSize = True
            Me.lblSubTotalEx.BackColor = System.Drawing.Color.Transparent
            Me.lblSubTotalEx.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblSubTotalEx.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubTotalEx.Location = New System.Drawing.Point(111, 113)
            Me.lblSubTotalEx.Name = "lblSubTotalEx"
            Me.lblSubTotalEx.Size = New System.Drawing.Size(82, 15)
            Me.lblSubTotalEx.TabIndex = 67
            Me.lblSubTotalEx.Text = "SubTotal (Ex)"
            '
            'txtSubTotalEx
            '
            Me.txtSubTotalEx.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtSubTotalEx.Enabled = False
            Me.txtSubTotalEx.Location = New System.Drawing.Point(113, 131)
            Me.txtSubTotalEx.MaxLength = 15
            Me.txtSubTotalEx.Name = "txtSubTotalEx"
            Me.txtSubTotalEx.Size = New System.Drawing.Size(88, 20)
            Me.txtSubTotalEx.TabIndex = 5
            Me.txtSubTotalEx.Text = "0"
            Me.txtSubTotalEx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblMes
            '
            Me.lblMes.AutoSize = True
            Me.lblMes.BackColor = System.Drawing.Color.Transparent
            Me.lblMes.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblMes.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMes.Location = New System.Drawing.Point(287, 60)
            Me.lblMes.Name = "lblMes"
            Me.lblMes.Size = New System.Drawing.Size(86, 15)
            Me.lblMes.TabIndex = 69
            Me.lblMes.Text = "Mes Tributado"
            '
            'lblIV
            '
            Me.lblIV.AutoSize = True
            Me.lblIV.BackColor = System.Drawing.Color.Transparent
            Me.lblIV.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblIV.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIV.Location = New System.Drawing.Point(204, 113)
            Me.lblIV.Name = "lblIV"
            Me.lblIV.Size = New System.Drawing.Size(18, 15)
            Me.lblIV.TabIndex = 71
            Me.lblIV.Text = "IV"
            '
            'txtIV
            '
            Me.txtIV.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtIV.Location = New System.Drawing.Point(207, 131)
            Me.txtIV.MaxLength = 15
            Me.txtIV.Name = "txtIV"
            Me.txtIV.Size = New System.Drawing.Size(88, 20)
            Me.txtIV.TabIndex = 7
            Me.txtIV.Text = "0"
            Me.txtIV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblTotal
            '
            Me.lblTotal.AutoSize = True
            Me.lblTotal.BackColor = System.Drawing.Color.Transparent
            Me.lblTotal.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblTotal.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotal.Location = New System.Drawing.Point(300, 113)
            Me.lblTotal.Name = "lblTotal"
            Me.lblTotal.Size = New System.Drawing.Size(34, 15)
            Me.lblTotal.TabIndex = 73
            Me.lblTotal.Text = "Total"
            '
            'txtTotal
            '
            Me.txtTotal.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtTotal.Location = New System.Drawing.Point(303, 131)
            Me.txtTotal.MaxLength = 15
            Me.txtTotal.Name = "txtTotal"
            Me.txtTotal.Size = New System.Drawing.Size(88, 20)
            Me.txtTotal.TabIndex = 8
            Me.txtTotal.Text = "0"
            Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'chkCancelada
            '
            Me.chkCancelada.AutoSize = True
            Me.chkCancelada.Location = New System.Drawing.Point(35, 12)
            Me.chkCancelada.Name = "chkCancelada"
            Me.chkCancelada.Size = New System.Drawing.Size(77, 17)
            Me.chkCancelada.TabIndex = 9
            Me.chkCancelada.Text = "Cancelada"
            Me.chkCancelada.UseVisualStyleBackColor = True
            '
            'lblFechaCancelacion
            '
            Me.lblFechaCancelacion.AutoSize = True
            Me.lblFechaCancelacion.BackColor = System.Drawing.Color.Transparent
            Me.lblFechaCancelacion.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblFechaCancelacion.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFechaCancelacion.Location = New System.Drawing.Point(4, 33)
            Me.lblFechaCancelacion.Name = "lblFechaCancelacion"
            Me.lblFechaCancelacion.Size = New System.Drawing.Size(39, 15)
            Me.lblFechaCancelacion.TabIndex = 75
            Me.lblFechaCancelacion.Text = "Fecha"
            '
            'gbCancelada
            '
            Me.gbCancelada.Controls.Add(Me.txtFechaCancelacion)
            Me.gbCancelada.Controls.Add(Me.chkCancelada)
            Me.gbCancelada.Controls.Add(Me.lblFechaCancelacion)
            Me.gbCancelada.Location = New System.Drawing.Point(428, 99)
            Me.gbCancelada.Name = "gbCancelada"
            Me.gbCancelada.Size = New System.Drawing.Size(137, 60)
            Me.gbCancelada.TabIndex = 77
            Me.gbCancelada.TabStop = False
            '
            'txtFechaCancelacion
            '
            Me.txtFechaCancelacion.Location = New System.Drawing.Point(51, 30)
            Me.txtFechaCancelacion.Name = "txtFechaCancelacion"
            Me.txtFechaCancelacion.Size = New System.Drawing.Size(78, 20)
            Me.txtFechaCancelacion.TabIndex = 85
            '
            'errorValidacion
            '
            Me.errorValidacion.BlinkRate = 20
            Me.errorValidacion.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
            Me.errorValidacion.ContainerControl = Me
            '
            'lblNumNC1
            '
            Me.lblNumNC1.AutoSize = True
            Me.lblNumNC1.BackColor = System.Drawing.Color.Transparent
            Me.lblNumNC1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblNumNC1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNumNC1.Location = New System.Drawing.Point(182, 61)
            Me.lblNumNC1.Name = "lblNumNC1"
            Me.lblNumNC1.Size = New System.Drawing.Size(44, 15)
            Me.lblNumNC1.TabIndex = 79
            Me.lblNumNC1.Text = "# Nota"
            '
            'txtNumNC1
            '
            Me.txtNumNC1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtNumNC1.Enabled = False
            Me.txtNumNC1.Location = New System.Drawing.Point(185, 78)
            Me.txtNumNC1.MaxLength = 15
            Me.txtNumNC1.Name = "txtNumNC1"
            Me.txtNumNC1.Size = New System.Drawing.Size(75, 20)
            Me.txtNumNC1.TabIndex = 78
            Me.txtNumNC1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'gbNotas
            '
            Me.gbNotas.Controls.Add(Me.dgvNotas)
            Me.gbNotas.Controls.Add(Me.chkDescuento)
            Me.gbNotas.Controls.Add(Me.lblSubTotalExNC)
            Me.gbNotas.Controls.Add(Me.txtSubTotalExN)
            Me.gbNotas.Controls.Add(Me.lblSubTotalIVNC)
            Me.gbNotas.Controls.Add(Me.txtSubTotalIVN)
            Me.gbNotas.Controls.Add(Me.txtFechaBoleta1)
            Me.gbNotas.Controls.Add(Me.lblFechaBoleta1)
            Me.gbNotas.Controls.Add(Me.txtFechaNC1)
            Me.gbNotas.Controls.Add(Me.lblBoleta1)
            Me.gbNotas.Controls.Add(Me.txtBoleta1)
            Me.gbNotas.Controls.Add(Me.lblMotivo1)
            Me.gbNotas.Controls.Add(Me.txtMotivo1)
            Me.gbNotas.Controls.Add(Me.lblIVNC1)
            Me.gbNotas.Controls.Add(Me.txtIVNC1)
            Me.gbNotas.Controls.Add(Me.lblFechaNC1)
            Me.gbNotas.Controls.Add(Me.lblTotalNC1)
            Me.gbNotas.Controls.Add(Me.txtTotalNC1)
            Me.gbNotas.Controls.Add(Me.lblNumNC1)
            Me.gbNotas.Controls.Add(Me.txtNumNC1)
            Me.gbNotas.Controls.Add(Me.txtIdNota)
            Me.gbNotas.Controls.Add(Me.chkNuevaNota)
            Me.gbNotas.Controls.Add(Me.btnLimpiarNC)
            Me.gbNotas.Controls.Add(Me.btnND)
            Me.gbNotas.Controls.Add(Me.btnNC)
            Me.gbNotas.Controls.Add(Me.btnAgregar)
            Me.gbNotas.Location = New System.Drawing.Point(5, 263)
            Me.gbNotas.Name = "gbNotas"
            Me.gbNotas.Size = New System.Drawing.Size(651, 222)
            Me.gbNotas.TabIndex = 80
            Me.gbNotas.TabStop = False
            '
            'dgvNotas
            '
            Me.dgvNotas.AllowUserToAddRows = False
            Me.dgvNotas.AllowUserToDeleteRows = False
            Me.dgvNotas.AllowUserToResizeColumns = False
            Me.dgvNotas.AllowUserToResizeRows = False
            Me.dgvNotas.BackgroundColor = System.Drawing.Color.White
            Me.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvNotas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_Nota, Me.Tipo, Me.NDoc, Me.Monto})
            Me.dgvNotas.GridColor = System.Drawing.Color.White
            Me.dgvNotas.Location = New System.Drawing.Point(431, 37)
            Me.dgvNotas.MultiSelect = False
            Me.dgvNotas.Name = "dgvNotas"
            Me.dgvNotas.ReadOnly = True
            Me.dgvNotas.RowHeadersVisible = False
            Me.dgvNotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvNotas.Size = New System.Drawing.Size(211, 179)
            Me.dgvNotas.TabIndex = 99
            '
            'Id_Nota
            '
            Me.Id_Nota.HeaderText = "Id_Nota"
            Me.Id_Nota.Name = "Id_Nota"
            Me.Id_Nota.ReadOnly = True
            Me.Id_Nota.Visible = False
            '
            'Tipo
            '
            Me.Tipo.HeaderText = "Tipo"
            Me.Tipo.Name = "Tipo"
            Me.Tipo.ReadOnly = True
            Me.Tipo.Width = 35
            '
            'NDoc
            '
            Me.NDoc.HeaderText = "N°Doc"
            Me.NDoc.Name = "NDoc"
            Me.NDoc.ReadOnly = True
            Me.NDoc.Width = 60
            '
            'Monto
            '
            DataGridViewCellStyle2.Format = "C2"
            DataGridViewCellStyle2.NullValue = Nothing
            Me.Monto.DefaultCellStyle = DataGridViewCellStyle2
            Me.Monto.HeaderText = "Monto"
            Me.Monto.Name = "Monto"
            Me.Monto.ReadOnly = True
            Me.Monto.Width = 90
            '
            'chkDescuento
            '
            Me.chkDescuento.AutoSize = True
            Me.chkDescuento.Location = New System.Drawing.Point(30, 40)
            Me.chkDescuento.Name = "chkDescuento"
            Me.chkDescuento.Size = New System.Drawing.Size(97, 17)
            Me.chkDescuento.TabIndex = 103
            Me.chkDescuento.Text = "Por Descuento"
            Me.chkDescuento.UseVisualStyleBackColor = True
            Me.chkDescuento.Visible = False
            '
            'lblSubTotalExNC
            '
            Me.lblSubTotalExNC.AutoSize = True
            Me.lblSubTotalExNC.BackColor = System.Drawing.Color.Transparent
            Me.lblSubTotalExNC.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblSubTotalExNC.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubTotalExNC.Location = New System.Drawing.Point(98, 113)
            Me.lblSubTotalExNC.Name = "lblSubTotalExNC"
            Me.lblSubTotalExNC.Size = New System.Drawing.Size(82, 15)
            Me.lblSubTotalExNC.TabIndex = 98
            Me.lblSubTotalExNC.Text = "SubTotal (Ex)"
            '
            'txtSubTotalExN
            '
            Me.txtSubTotalExN.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtSubTotalExN.Enabled = False
            Me.txtSubTotalExN.Location = New System.Drawing.Point(96, 131)
            Me.txtSubTotalExN.MaxLength = 15
            Me.txtSubTotalExN.Name = "txtSubTotalExN"
            Me.txtSubTotalExN.Size = New System.Drawing.Size(87, 20)
            Me.txtSubTotalExN.TabIndex = 97
            Me.txtSubTotalExN.Text = "0"
            Me.txtSubTotalExN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblSubTotalIVNC
            '
            Me.lblSubTotalIVNC.AutoSize = True
            Me.lblSubTotalIVNC.BackColor = System.Drawing.Color.Transparent
            Me.lblSubTotalIVNC.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblSubTotalIVNC.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubTotalIVNC.Location = New System.Drawing.Point(7, 113)
            Me.lblSubTotalIVNC.Name = "lblSubTotalIVNC"
            Me.lblSubTotalIVNC.Size = New System.Drawing.Size(79, 15)
            Me.lblSubTotalIVNC.TabIndex = 96
            Me.lblSubTotalIVNC.Text = "SubTotal (IV)"
            '
            'txtSubTotalIVN
            '
            Me.txtSubTotalIVN.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtSubTotalIVN.Enabled = False
            Me.txtSubTotalIVN.Location = New System.Drawing.Point(8, 131)
            Me.txtSubTotalIVN.MaxLength = 15
            Me.txtSubTotalIVN.Name = "txtSubTotalIVN"
            Me.txtSubTotalIVN.Size = New System.Drawing.Size(86, 20)
            Me.txtSubTotalIVN.TabIndex = 95
            Me.txtSubTotalIVN.Text = "0"
            Me.txtSubTotalIVN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtFechaBoleta1
            '
            Me.txtFechaBoleta1.Enabled = False
            Me.txtFechaBoleta1.Location = New System.Drawing.Point(93, 78)
            Me.txtFechaBoleta1.MaxLength = 10
            Me.txtFechaBoleta1.Name = "txtFechaBoleta1"
            Me.txtFechaBoleta1.Size = New System.Drawing.Size(78, 20)
            Me.txtFechaBoleta1.TabIndex = 92
            '
            'lblFechaBoleta1
            '
            Me.lblFechaBoleta1.AutoSize = True
            Me.lblFechaBoleta1.BackColor = System.Drawing.Color.Transparent
            Me.lblFechaBoleta1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblFechaBoleta1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFechaBoleta1.Location = New System.Drawing.Point(93, 61)
            Me.lblFechaBoleta1.Name = "lblFechaBoleta1"
            Me.lblFechaBoleta1.Size = New System.Drawing.Size(78, 15)
            Me.lblFechaBoleta1.TabIndex = 91
            Me.lblFechaBoleta1.Text = "Fecha Boleta"
            '
            'txtFechaNC1
            '
            Me.txtFechaNC1.Enabled = False
            Me.txtFechaNC1.Location = New System.Drawing.Point(265, 78)
            Me.txtFechaNC1.MaxLength = 10
            Me.txtFechaNC1.Name = "txtFechaNC1"
            Me.txtFechaNC1.Size = New System.Drawing.Size(78, 20)
            Me.txtFechaNC1.TabIndex = 90
            '
            'lblBoleta1
            '
            Me.lblBoleta1.AutoSize = True
            Me.lblBoleta1.BackColor = System.Drawing.Color.Transparent
            Me.lblBoleta1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblBoleta1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblBoleta1.Location = New System.Drawing.Point(4, 60)
            Me.lblBoleta1.Name = "lblBoleta1"
            Me.lblBoleta1.Size = New System.Drawing.Size(53, 15)
            Me.lblBoleta1.TabIndex = 89
            Me.lblBoleta1.Text = "# Boleta"
            '
            'txtBoleta1
            '
            Me.txtBoleta1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtBoleta1.Enabled = False
            Me.txtBoleta1.Location = New System.Drawing.Point(6, 78)
            Me.txtBoleta1.MaxLength = 15
            Me.txtBoleta1.Name = "txtBoleta1"
            Me.txtBoleta1.Size = New System.Drawing.Size(76, 20)
            Me.txtBoleta1.TabIndex = 88
            Me.txtBoleta1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblMotivo1
            '
            Me.lblMotivo1.AutoSize = True
            Me.lblMotivo1.BackColor = System.Drawing.Color.Transparent
            Me.lblMotivo1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblMotivo1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMotivo1.Location = New System.Drawing.Point(13, 156)
            Me.lblMotivo1.Name = "lblMotivo1"
            Me.lblMotivo1.Size = New System.Drawing.Size(46, 15)
            Me.lblMotivo1.TabIndex = 87
            Me.lblMotivo1.Text = "Motivo"
            '
            'txtMotivo1
            '
            Me.txtMotivo1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtMotivo1.Enabled = False
            Me.txtMotivo1.Location = New System.Drawing.Point(9, 173)
            Me.txtMotivo1.MaxLength = 235
            Me.txtMotivo1.Multiline = True
            Me.txtMotivo1.Name = "txtMotivo1"
            Me.txtMotivo1.Size = New System.Drawing.Size(337, 40)
            Me.txtMotivo1.TabIndex = 86
            '
            'lblIVNC1
            '
            Me.lblIVNC1.AutoSize = True
            Me.lblIVNC1.BackColor = System.Drawing.Color.Transparent
            Me.lblIVNC1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblIVNC1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIVNC1.Location = New System.Drawing.Point(188, 113)
            Me.lblIVNC1.Name = "lblIVNC1"
            Me.lblIVNC1.Size = New System.Drawing.Size(18, 15)
            Me.lblIVNC1.TabIndex = 85
            Me.lblIVNC1.Text = "IV"
            '
            'txtIVNC1
            '
            Me.txtIVNC1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtIVNC1.Enabled = False
            Me.txtIVNC1.Location = New System.Drawing.Point(185, 131)
            Me.txtIVNC1.MaxLength = 15
            Me.txtIVNC1.Name = "txtIVNC1"
            Me.txtIVNC1.Size = New System.Drawing.Size(76, 20)
            Me.txtIVNC1.TabIndex = 84
            Me.txtIVNC1.Text = "0"
            Me.txtIVNC1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblFechaNC1
            '
            Me.lblFechaNC1.AutoSize = True
            Me.lblFechaNC1.BackColor = System.Drawing.Color.Transparent
            Me.lblFechaNC1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblFechaNC1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFechaNC1.Location = New System.Drawing.Point(262, 61)
            Me.lblFechaNC1.Name = "lblFechaNC1"
            Me.lblFechaNC1.Size = New System.Drawing.Size(39, 15)
            Me.lblFechaNC1.TabIndex = 83
            Me.lblFechaNC1.Text = "Fecha"
            '
            'lblTotalNC1
            '
            Me.lblTotalNC1.AutoSize = True
            Me.lblTotalNC1.BackColor = System.Drawing.Color.Transparent
            Me.lblTotalNC1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblTotalNC1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotalNC1.Location = New System.Drawing.Point(265, 113)
            Me.lblTotalNC1.Name = "lblTotalNC1"
            Me.lblTotalNC1.Size = New System.Drawing.Size(34, 15)
            Me.lblTotalNC1.TabIndex = 81
            Me.lblTotalNC1.Text = "Total"
            '
            'txtTotalNC1
            '
            Me.txtTotalNC1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtTotalNC1.Enabled = False
            Me.txtTotalNC1.Location = New System.Drawing.Point(263, 131)
            Me.txtTotalNC1.MaxLength = 15
            Me.txtTotalNC1.Name = "txtTotalNC1"
            Me.txtTotalNC1.Size = New System.Drawing.Size(83, 20)
            Me.txtTotalNC1.TabIndex = 80
            Me.txtTotalNC1.Text = "0"
            Me.txtTotalNC1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtIdNota
            '
            Me.txtIdNota.Location = New System.Drawing.Point(580, 173)
            Me.txtIdNota.Name = "txtIdNota"
            Me.txtIdNota.Size = New System.Drawing.Size(29, 20)
            Me.txtIdNota.TabIndex = 102
            Me.txtIdNota.Visible = False
            '
            'chkNuevaNota
            '
            Me.chkNuevaNota.AutoSize = True
            Me.chkNuevaNota.Checked = True
            Me.chkNuevaNota.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkNuevaNota.Location = New System.Drawing.Point(484, 173)
            Me.chkNuevaNota.Name = "chkNuevaNota"
            Me.chkNuevaNota.Size = New System.Drawing.Size(56, 17)
            Me.chkNuevaNota.TabIndex = 101
            Me.chkNuevaNota.Text = "nueva"
            Me.chkNuevaNota.UseVisualStyleBackColor = True
            Me.chkNuevaNota.Visible = False
            '
            'btnLimpiarNC
            '
            Me.btnLimpiarNC.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnLimpiarNC.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnLimpiarNC.Location = New System.Drawing.Point(177, 11)
            Me.btnLimpiarNC.Name = "btnLimpiarNC"
            Me.btnLimpiarNC.Size = New System.Drawing.Size(71, 25)
            Me.btnLimpiarNC.TabIndex = 89
            Me.btnLimpiarNC.Text = "Limpiar"
            Me.btnLimpiarNC.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnLimpiarNC.UseVisualStyleBackColor = True
            '
            'btnND
            '
            Me.btnND.Location = New System.Drawing.Point(96, 11)
            Me.btnND.Name = "btnND"
            Me.btnND.Size = New System.Drawing.Size(72, 23)
            Me.btnND.TabIndex = 104
            Me.btnND.Text = "Nota Débito"
            Me.btnND.UseVisualStyleBackColor = True
            '
            'btnNC
            '
            Me.btnNC.Location = New System.Drawing.Point(11, 11)
            Me.btnNC.Name = "btnNC"
            Me.btnNC.Size = New System.Drawing.Size(75, 23)
            Me.btnNC.TabIndex = 105
            Me.btnNC.Text = "Nota Crédito"
            Me.btnNC.UseVisualStyleBackColor = True
            '
            'btnAgregar
            '
            Me.btnAgregar.Enabled = False
            Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnAgregar.Location = New System.Drawing.Point(351, 114)
            Me.btnAgregar.Name = "btnAgregar"
            Me.btnAgregar.Size = New System.Drawing.Size(75, 37)
            Me.btnAgregar.TabIndex = 100
            Me.btnAgregar.Text = "Agregar/ Modificar"
            Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnAgregar.UseVisualStyleBackColor = True
            '
            'txtFechaFactura
            '
            Me.txtFechaFactura.Location = New System.Drawing.Point(20, 79)
            Me.txtFechaFactura.MaxLength = 10
            Me.txtFechaFactura.Name = "txtFechaFactura"
            Me.txtFechaFactura.Size = New System.Drawing.Size(78, 20)
            Me.txtFechaFactura.TabIndex = 3
            '
            'txtIdDoc_PorPagar
            '
            Me.txtIdDoc_PorPagar.Location = New System.Drawing.Point(89, 12)
            Me.txtIdDoc_PorPagar.Name = "txtIdDoc_PorPagar"
            Me.txtIdDoc_PorPagar.Size = New System.Drawing.Size(47, 20)
            Me.txtIdDoc_PorPagar.TabIndex = 85
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Label1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(179, 60)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(87, 15)
            Me.Label1.TabIndex = 86
            Me.Label1.Text = "Fecha Ingreso:"
            '
            'cbMes
            '
            Me.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbMes.FormattingEnabled = True
            Me.cbMes.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
            Me.cbMes.Location = New System.Drawing.Point(286, 78)
            Me.cbMes.Name = "cbMes"
            Me.cbMes.Size = New System.Drawing.Size(120, 21)
            Me.cbMes.TabIndex = 88
            '
            'MenuEliminar
            '
            Me.MenuEliminar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarToolStripMenuItem})
            Me.MenuEliminar.Name = "MenuEliminar"
            Me.MenuEliminar.Size = New System.Drawing.Size(118, 26)
            '
            'EliminarToolStripMenuItem
            '
            Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
            Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
            Me.EliminarToolStripMenuItem.Text = "Eliminar"
            '
            'txtDias
            '
            Me.txtDias.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtDias.Location = New System.Drawing.Point(113, 79)
            Me.txtDias.MaxLength = 5
            Me.txtDias.Name = "txtDias"
            Me.txtDias.Size = New System.Drawing.Size(50, 20)
            Me.txtDias.TabIndex = 89
            Me.txtDias.Text = "30"
            Me.txtDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblDias
            '
            Me.lblDias.AutoSize = True
            Me.lblDias.BackColor = System.Drawing.Color.Transparent
            Me.lblDias.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblDias.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDias.Location = New System.Drawing.Point(109, 62)
            Me.lblDias.Name = "lblDias"
            Me.lblDias.Size = New System.Drawing.Size(29, 15)
            Me.lblDias.TabIndex = 90
            Me.lblDias.Text = "Dias"
            '
            'txtFechaIngreso
            '
            Me.txtFechaIngreso.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtFechaIngreso.Enabled = False
            Me.txtFechaIngreso.Location = New System.Drawing.Point(180, 78)
            Me.txtFechaIngreso.MaxLength = 15
            Me.txtFechaIngreso.Name = "txtFechaIngreso"
            Me.txtFechaIngreso.Size = New System.Drawing.Size(93, 20)
            Me.txtFechaIngreso.TabIndex = 106
            Me.txtFechaIngreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'chkAnulada
            '
            Me.chkAnulada.AutoSize = True
            Me.chkAnulada.Location = New System.Drawing.Point(20, 177)
            Me.chkAnulada.Name = "chkAnulada"
            Me.chkAnulada.Size = New System.Drawing.Size(56, 17)
            Me.chkAnulada.TabIndex = 110
            Me.chkAnulada.Text = "Anular"
            Me.chkAnulada.UseVisualStyleBackColor = True
            '
            'txtMotivoAnulada
            '
            Me.txtMotivoAnulada.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMotivoAnulada.Location = New System.Drawing.Point(87, 175)
            Me.txtMotivoAnulada.MaxLength = 100
            Me.txtMotivoAnulada.Name = "txtMotivoAnulada"
            Me.txtMotivoAnulada.Size = New System.Drawing.Size(478, 18)
            Me.txtMotivoAnulada.TabIndex = 111
            '
            'gbDocPagar
            '
            Me.gbDocPagar.Controls.Add(Me.dgvProveedores)
            Me.gbDocPagar.Controls.Add(Me.gbContado)
            Me.gbDocPagar.Controls.Add(Me.lblMotivoAnulada)
            Me.gbDocPagar.Controls.Add(Me.lblId_Proveedor)
            Me.gbDocPagar.Controls.Add(Me.txtMotivoAnulada)
            Me.gbDocPagar.Controls.Add(Me.txtFechaIngreso)
            Me.gbDocPagar.Controls.Add(Me.chkAnulada)
            Me.gbDocPagar.Controls.Add(Me.cbMes)
            Me.gbDocPagar.Controls.Add(Me.lblFecha)
            Me.gbDocPagar.Controls.Add(Me.lblNombreProveedor)
            Me.gbDocPagar.Controls.Add(Me.txtNumFactura)
            Me.gbDocPagar.Controls.Add(Me.txtNombreProveedor)
            Me.gbDocPagar.Controls.Add(Me.txtDias)
            Me.gbDocPagar.Controls.Add(Me.lblNumFactura)
            Me.gbDocPagar.Controls.Add(Me.lblDias)
            Me.gbDocPagar.Controls.Add(Me.txtId_Proveedor)
            Me.gbDocPagar.Controls.Add(Me.Label1)
            Me.gbDocPagar.Controls.Add(Me.txtSubTotalIV)
            Me.gbDocPagar.Controls.Add(Me.txtFechaFactura)
            Me.gbDocPagar.Controls.Add(Me.lblSubTotalIV)
            Me.gbDocPagar.Controls.Add(Me.lblSubTotalEx)
            Me.gbDocPagar.Controls.Add(Me.gbCancelada)
            Me.gbDocPagar.Controls.Add(Me.lblMes)
            Me.gbDocPagar.Controls.Add(Me.txtSubTotalEx)
            Me.gbDocPagar.Controls.Add(Me.txtIV)
            Me.gbDocPagar.Controls.Add(Me.lblTotal)
            Me.gbDocPagar.Controls.Add(Me.lblIV)
            Me.gbDocPagar.Controls.Add(Me.txtTotal)
            Me.gbDocPagar.Location = New System.Drawing.Point(5, 60)
            Me.gbDocPagar.Name = "gbDocPagar"
            Me.gbDocPagar.Size = New System.Drawing.Size(651, 205)
            Me.gbDocPagar.TabIndex = 0
            Me.gbDocPagar.TabStop = False
            '
            'lblMotivoAnulada
            '
            Me.lblMotivoAnulada.AutoSize = True
            Me.lblMotivoAnulada.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMotivoAnulada.Location = New System.Drawing.Point(84, 158)
            Me.lblMotivoAnulada.Name = "lblMotivoAnulada"
            Me.lblMotivoAnulada.Size = New System.Drawing.Size(74, 15)
            Me.lblMotivoAnulada.TabIndex = 112
            Me.lblMotivoAnulada.Text = "Motivo Nula"
            '
            'gbContado
            '
            Me.gbContado.Controls.Add(Me.rbCredito)
            Me.gbContado.Controls.Add(Me.rbContado)
            Me.gbContado.Location = New System.Drawing.Point(428, 55)
            Me.gbContado.Name = "gbContado"
            Me.gbContado.Size = New System.Drawing.Size(137, 44)
            Me.gbContado.TabIndex = 86
            Me.gbContado.TabStop = False
            '
            'rbContado
            '
            Me.rbContado.AutoSize = True
            Me.rbContado.Location = New System.Drawing.Point(67, 17)
            Me.rbContado.Name = "rbContado"
            Me.rbContado.Size = New System.Drawing.Size(65, 17)
            Me.rbContado.TabIndex = 0
            Me.rbContado.Text = "Contado"
            Me.rbContado.UseVisualStyleBackColor = True
            '
            'rbCredito
            '
            Me.rbCredito.AutoSize = True
            Me.rbCredito.Checked = True
            Me.rbCredito.Location = New System.Drawing.Point(7, 17)
            Me.rbCredito.Name = "rbCredito"
            Me.rbCredito.Size = New System.Drawing.Size(58, 17)
            Me.rbCredito.TabIndex = 1
            Me.rbCredito.TabStop = True
            Me.rbCredito.Text = "Credito"
            Me.rbCredito.UseVisualStyleBackColor = True
            '
            'errorBlink
            '
            Me.errorBlink.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
            Me.errorBlink.ContainerControl = Me
            Me.errorBlink.Icon = CType(resources.GetObject("errorBlink.Icon"), System.Drawing.Icon)
            '
            'FrmDocPorPagar
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(663, 497)
            Me.Controls.Add(Me.gbDocPagar)
            Me.Controls.Add(Me.gbNotas)
            Me.Controls.Add(Me.btnLimpiar)
            Me.Controls.Add(Me.btnInsertar)
            Me.Controls.Add(Me.txtIdDoc_PorPagar)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmDocPorPagar"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Agregar/Editar Facturas"
            CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbCancelada.ResumeLayout(False)
            Me.gbCancelada.PerformLayout()
            CType(Me.errorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbNotas.ResumeLayout(False)
            Me.gbNotas.PerformLayout()
            CType(Me.dgvNotas, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuEliminar.ResumeLayout(False)
            Me.gbDocPagar.ResumeLayout(False)
            Me.gbDocPagar.PerformLayout()
            Me.gbContado.ResumeLayout(False)
            Me.gbContado.PerformLayout()
            CType(Me.errorBlink, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvProveedores As System.Windows.Forms.DataGridView
        Friend WithEvents txtId_Proveedor As System.Windows.Forms.TextBox
        Friend WithEvents lblId_Proveedor As System.Windows.Forms.Label
        Friend WithEvents lblNumFactura As System.Windows.Forms.Label
        Friend WithEvents btnLimpiar As System.Windows.Forms.Button
        Friend WithEvents btnInsertar As System.Windows.Forms.Button
        Friend WithEvents txtNombreProveedor As System.Windows.Forms.TextBox
        Friend WithEvents lblNombreProveedor As System.Windows.Forms.Label
        Friend WithEvents txtNumFactura As System.Windows.Forms.TextBox
        Friend WithEvents lblFecha As System.Windows.Forms.Label
        Friend WithEvents lblSubTotalIV As System.Windows.Forms.Label
        Friend WithEvents txtSubTotalIV As System.Windows.Forms.TextBox
        Friend WithEvents lblSubTotalEx As System.Windows.Forms.Label
        Friend WithEvents txtSubTotalEx As System.Windows.Forms.TextBox
        Friend WithEvents lblMes As System.Windows.Forms.Label
        Friend WithEvents lblIV As System.Windows.Forms.Label
        Friend WithEvents txtIV As System.Windows.Forms.TextBox
        Friend WithEvents lblTotal As System.Windows.Forms.Label
        Friend WithEvents txtTotal As System.Windows.Forms.TextBox
        Friend WithEvents chkCancelada As System.Windows.Forms.CheckBox
        Friend WithEvents lblFechaCancelacion As System.Windows.Forms.Label
        Friend WithEvents gbCancelada As System.Windows.Forms.GroupBox
        Friend WithEvents errorValidacion As System.Windows.Forms.ErrorProvider
        Friend WithEvents lblNumNC1 As System.Windows.Forms.Label
        Friend WithEvents txtNumNC1 As System.Windows.Forms.TextBox
        Friend WithEvents gbNotas As System.Windows.Forms.GroupBox
        Friend WithEvents lblBoleta1 As System.Windows.Forms.Label
        Friend WithEvents txtBoleta1 As System.Windows.Forms.TextBox
        Friend WithEvents lblMotivo1 As System.Windows.Forms.Label
        Friend WithEvents txtMotivo1 As System.Windows.Forms.TextBox
        Friend WithEvents lblIVNC1 As System.Windows.Forms.Label
        Friend WithEvents txtIVNC1 As System.Windows.Forms.TextBox
        Friend WithEvents lblFechaNC1 As System.Windows.Forms.Label
        Friend WithEvents lblTotalNC1 As System.Windows.Forms.Label
        Friend WithEvents txtTotalNC1 As System.Windows.Forms.TextBox
        Friend WithEvents txtFechaCancelacion As System.Windows.Forms.TextBox
        Friend WithEvents txtFechaFactura As System.Windows.Forms.TextBox
        Friend WithEvents txtFechaNC1 As System.Windows.Forms.TextBox
        Friend WithEvents txtFechaBoleta1 As System.Windows.Forms.TextBox
        Friend WithEvents lblFechaBoleta1 As System.Windows.Forms.Label
        Friend WithEvents txtIdDoc_PorPagar As System.Windows.Forms.TextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents cbMes As System.Windows.Forms.ComboBox
        Friend WithEvents lblSubTotalExNC As System.Windows.Forms.Label
        Friend WithEvents txtSubTotalExN As System.Windows.Forms.TextBox
        Friend WithEvents lblSubTotalIVNC As System.Windows.Forms.Label
        Friend WithEvents txtSubTotalIVN As System.Windows.Forms.TextBox
        Friend WithEvents btnAgregar As System.Windows.Forms.Button
        Friend WithEvents dgvNotas As System.Windows.Forms.DataGridView
        Friend WithEvents chkNuevaNota As System.Windows.Forms.CheckBox
        Friend WithEvents txtIdNota As System.Windows.Forms.TextBox
        Friend WithEvents btnLimpiarNC As System.Windows.Forms.Button
        Friend WithEvents MenuEliminar As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents txtDias As System.Windows.Forms.TextBox
        Friend WithEvents lblDias As System.Windows.Forms.Label
        Friend WithEvents chkDescuento As System.Windows.Forms.CheckBox
        Friend WithEvents btnNC As System.Windows.Forms.Button
        Friend WithEvents btnND As System.Windows.Forms.Button
        Friend WithEvents txtFechaIngreso As System.Windows.Forms.TextBox
        Friend WithEvents txtMotivoAnulada As System.Windows.Forms.TextBox
        Friend WithEvents chkAnulada As System.Windows.Forms.CheckBox
        Friend WithEvents gbDocPagar As System.Windows.Forms.GroupBox
        Friend WithEvents lblMotivoAnulada As System.Windows.Forms.Label
        Friend WithEvents Id_Nota As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Tipo As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents NDoc As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Monto As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents gbContado As System.Windows.Forms.GroupBox
        Friend WithEvents rbCredito As System.Windows.Forms.RadioButton
        Friend WithEvents rbContado As System.Windows.Forms.RadioButton
        Friend WithEvents errorBlink As System.Windows.Forms.ErrorProvider
    End Class
End Namespace