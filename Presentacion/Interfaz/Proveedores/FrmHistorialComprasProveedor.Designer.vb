Namespace Interfaz.Proveedores
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmHistorialComprasPorProveedor
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
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.btnImprimir = New System.Windows.Forms.Button()
            Me.dgvProveedor = New System.Windows.Forms.DataGridView()
            Me.gbTipo = New System.Windows.Forms.GroupBox()
            Me.txtDato = New System.Windows.Forms.TextBox()
            Me.chkRangoFechas = New System.Windows.Forms.CheckBox()
            Me.rbSinAnular = New System.Windows.Forms.RadioButton()
            Me.rbAnulada = New System.Windows.Forms.RadioButton()
            Me.rbTodas = New System.Windows.Forms.RadioButton()
            Me.rbPendiente = New System.Windows.Forms.RadioButton()
            Me.dtpFinal = New System.Windows.Forms.DateTimePicker()
            Me.rbCancelada = New System.Windows.Forms.RadioButton()
            Me.lblFechaFinal = New System.Windows.Forms.Label()
            Me.lblFechaInicial = New System.Windows.Forms.Label()
            Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
            Me.cmbTipoConsulta = New System.Windows.Forms.ComboBox()
            Me.txtDato2 = New System.Windows.Forms.TextBox()
            Me.btnBuscar = New System.Windows.Forms.Button()
            Me.dgvFacturas = New System.Windows.Forms.DataGridView()
            Me.Id_DocPorPagar = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.NumFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Empresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.subTotalIV = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.subTotalEx = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.IV = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.FechaCancelacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.txtIdProveedor = New System.Windows.Forms.TextBox()
            Me.lblTotalesFacturas = New System.Windows.Forms.Label()
            Me.lblTotalesNC = New System.Windows.Forms.Label()
            Me.lblTotalFinal = New System.Windows.Forms.Label()
            Me.lblSubTotalIV = New System.Windows.Forms.Label()
            Me.lblSubTotalGeneral = New System.Windows.Forms.Label()
            Me.lblSubTotalEx = New System.Windows.Forms.Label()
            Me.lblSubTotalExGeneral = New System.Windows.Forms.Label()
            Me.lblIV = New System.Windows.Forms.Label()
            Me.lblIVGeneral = New System.Windows.Forms.Label()
            Me.lblTotal = New System.Windows.Forms.Label()
            Me.lblTotalGeneral = New System.Windows.Forms.Label()
            Me.lblTotalNC = New System.Windows.Forms.Label()
            Me.lblIVNC = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.btnLimpiar = New System.Windows.Forms.Button()
            Me.lblSubTotalExNC = New System.Windows.Forms.Label()
            Me.lblSubTotalIVNC = New System.Windows.Forms.Label()
            Me.lblTotalND = New System.Windows.Forms.Label()
            Me.lblIVND = New System.Windows.Forms.Label()
            Me.lblSubTotalExND = New System.Windows.Forms.Label()
            Me.lblSubTotalIVND = New System.Windows.Forms.Label()
            Me.lblTotalesND = New System.Windows.Forms.Label()
            Me.MnEditar = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            CType(Me.dgvProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbTipo.SuspendLayout()
            CType(Me.dgvFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MnEditar.SuspendLayout()
            Me.SuspendLayout()
            '
            'btnImprimir
            '
            Me.btnImprimir.Image = Global.Presentacion.My.Resources.Resources.Imprimir
            Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnImprimir.Location = New System.Drawing.Point(0, 0)
            Me.btnImprimir.Name = "btnImprimir"
            Me.btnImprimir.Size = New System.Drawing.Size(65, 57)
            Me.btnImprimir.TabIndex = 261
            Me.btnImprimir.Text = "Imprimir"
            Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnImprimir.UseVisualStyleBackColor = True
            '
            'dgvProveedor
            '
            Me.dgvProveedor.AllowUserToAddRows = False
            Me.dgvProveedor.AllowUserToDeleteRows = False
            Me.dgvProveedor.AllowUserToResizeColumns = False
            Me.dgvProveedor.AllowUserToResizeRows = False
            Me.dgvProveedor.BackgroundColor = System.Drawing.Color.White
            Me.dgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvProveedor.GridColor = System.Drawing.Color.White
            Me.dgvProveedor.Location = New System.Drawing.Point(356, 49)
            Me.dgvProveedor.MultiSelect = False
            Me.dgvProveedor.Name = "dgvProveedor"
            Me.dgvProveedor.ReadOnly = True
            Me.dgvProveedor.RowHeadersVisible = False
            Me.dgvProveedor.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvProveedor.Size = New System.Drawing.Size(324, 105)
            Me.dgvProveedor.TabIndex = 265
            Me.dgvProveedor.Visible = False
            '
            'gbTipo
            '
            Me.gbTipo.Controls.Add(Me.txtDato)
            Me.gbTipo.Controls.Add(Me.chkRangoFechas)
            Me.gbTipo.Controls.Add(Me.rbSinAnular)
            Me.gbTipo.Controls.Add(Me.rbAnulada)
            Me.gbTipo.Controls.Add(Me.rbTodas)
            Me.gbTipo.Controls.Add(Me.rbPendiente)
            Me.gbTipo.Controls.Add(Me.dtpFinal)
            Me.gbTipo.Controls.Add(Me.rbCancelada)
            Me.gbTipo.Controls.Add(Me.lblFechaFinal)
            Me.gbTipo.Controls.Add(Me.lblFechaInicial)
            Me.gbTipo.Controls.Add(Me.dtpInicio)
            Me.gbTipo.Controls.Add(Me.cmbTipoConsulta)
            Me.gbTipo.Controls.Add(Me.txtDato2)
            Me.gbTipo.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTipo.Location = New System.Drawing.Point(204, 6)
            Me.gbTipo.Name = "gbTipo"
            Me.gbTipo.Size = New System.Drawing.Size(521, 104)
            Me.gbTipo.TabIndex = 260
            Me.gbTipo.TabStop = False
            Me.gbTipo.Text = "Consultar por"
            '
            'txtDato
            '
            Me.txtDato.Location = New System.Drawing.Point(150, 20)
            Me.txtDato.Name = "txtDato"
            Me.txtDato.Size = New System.Drawing.Size(341, 23)
            Me.txtDato.TabIndex = 247
            Me.txtDato.Visible = False
            '
            'chkRangoFechas
            '
            Me.chkRangoFechas.AutoSize = True
            Me.chkRangoFechas.Location = New System.Drawing.Point(23, 54)
            Me.chkRangoFechas.Name = "chkRangoFechas"
            Me.chkRangoFechas.Size = New System.Drawing.Size(101, 19)
            Me.chkRangoFechas.TabIndex = 279
            Me.chkRangoFechas.Text = "Rango Fechas"
            Me.chkRangoFechas.UseVisualStyleBackColor = True
            '
            'rbSinAnular
            '
            Me.rbSinAnular.AutoSize = True
            Me.rbSinAnular.Location = New System.Drawing.Point(322, 80)
            Me.rbSinAnular.Name = "rbSinAnular"
            Me.rbSinAnular.Size = New System.Drawing.Size(81, 19)
            Me.rbSinAnular.TabIndex = 278
            Me.rbSinAnular.TabStop = True
            Me.rbSinAnular.Text = "Sin Anular"
            Me.rbSinAnular.UseVisualStyleBackColor = True
            '
            'rbAnulada
            '
            Me.rbAnulada.AutoSize = True
            Me.rbAnulada.Location = New System.Drawing.Point(433, 80)
            Me.rbAnulada.Name = "rbAnulada"
            Me.rbAnulada.Size = New System.Drawing.Size(74, 19)
            Me.rbAnulada.TabIndex = 277
            Me.rbAnulada.TabStop = True
            Me.rbAnulada.Text = "Anuladas"
            Me.rbAnulada.UseVisualStyleBackColor = True
            '
            'rbTodas
            '
            Me.rbTodas.AutoSize = True
            Me.rbTodas.Checked = True
            Me.rbTodas.Location = New System.Drawing.Point(23, 80)
            Me.rbTodas.Name = "rbTodas"
            Me.rbTodas.Size = New System.Drawing.Size(56, 19)
            Me.rbTodas.TabIndex = 276
            Me.rbTodas.TabStop = True
            Me.rbTodas.Text = "Todas"
            Me.rbTodas.UseVisualStyleBackColor = True
            '
            'rbPendiente
            '
            Me.rbPendiente.AutoSize = True
            Me.rbPendiente.Location = New System.Drawing.Point(100, 80)
            Me.rbPendiente.Name = "rbPendiente"
            Me.rbPendiente.Size = New System.Drawing.Size(87, 19)
            Me.rbPendiente.TabIndex = 275
            Me.rbPendiente.Text = "Pendientes"
            Me.rbPendiente.UseVisualStyleBackColor = True
            '
            'dtpFinal
            '
            Me.dtpFinal.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFinal.Enabled = False
            Me.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFinal.Location = New System.Drawing.Point(408, 52)
            Me.dtpFinal.MaxDate = New Date(3000, 12, 31, 0, 0, 0, 0)
            Me.dtpFinal.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
            Me.dtpFinal.Name = "dtpFinal"
            Me.dtpFinal.Size = New System.Drawing.Size(99, 23)
            Me.dtpFinal.TabIndex = 271
            Me.dtpFinal.Value = New Date(2011, 12, 27, 0, 0, 0, 0)
            '
            'rbCancelada
            '
            Me.rbCancelada.AutoSize = True
            Me.rbCancelada.Location = New System.Drawing.Point(208, 80)
            Me.rbCancelada.Name = "rbCancelada"
            Me.rbCancelada.Size = New System.Drawing.Size(85, 19)
            Me.rbCancelada.TabIndex = 274
            Me.rbCancelada.Text = "Canceladas"
            Me.rbCancelada.UseVisualStyleBackColor = True
            '
            'lblFechaFinal
            '
            Me.lblFechaFinal.AutoSize = True
            Me.lblFechaFinal.Enabled = False
            Me.lblFechaFinal.Location = New System.Drawing.Point(335, 57)
            Me.lblFechaFinal.Name = "lblFechaFinal"
            Me.lblFechaFinal.Size = New System.Drawing.Size(67, 15)
            Me.lblFechaFinal.TabIndex = 273
            Me.lblFechaFinal.Text = "Fecha Final"
            '
            'lblFechaInicial
            '
            Me.lblFechaInicial.AutoSize = True
            Me.lblFechaInicial.Enabled = False
            Me.lblFechaInicial.Location = New System.Drawing.Point(150, 57)
            Me.lblFechaInicial.Name = "lblFechaInicial"
            Me.lblFechaInicial.Size = New System.Drawing.Size(74, 15)
            Me.lblFechaInicial.TabIndex = 272
            Me.lblFechaInicial.Text = "Fecha Inicial"
            '
            'dtpInicio
            '
            Me.dtpInicio.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpInicio.Enabled = False
            Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpInicio.Location = New System.Drawing.Point(230, 52)
            Me.dtpInicio.MaxDate = New Date(3000, 12, 31, 0, 0, 0, 0)
            Me.dtpInicio.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
            Me.dtpInicio.Name = "dtpInicio"
            Me.dtpInicio.Size = New System.Drawing.Size(99, 23)
            Me.dtpInicio.TabIndex = 270
            Me.dtpInicio.Value = New Date(2011, 12, 27, 0, 0, 0, 0)
            '
            'cmbTipoConsulta
            '
            Me.cmbTipoConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbTipoConsulta.FormattingEnabled = True
            Me.cmbTipoConsulta.Items.AddRange(New Object() {"Nombre del Proveedor", "Id del Proveedor", "Todas las Facturas"})
            Me.cmbTipoConsulta.Location = New System.Drawing.Point(6, 20)
            Me.cmbTipoConsulta.Name = "cmbTipoConsulta"
            Me.cmbTipoConsulta.Size = New System.Drawing.Size(138, 23)
            Me.cmbTipoConsulta.TabIndex = 249
            '
            'txtDato2
            '
            Me.txtDato2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDato2.Location = New System.Drawing.Point(151, 21)
            Me.txtDato2.MaxLength = 6
            Me.txtDato2.Name = "txtDato2"
            Me.txtDato2.Size = New System.Drawing.Size(76, 21)
            Me.txtDato2.TabIndex = 0
            Me.txtDato2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'btnBuscar
            '
            Me.btnBuscar.Image = Global.Presentacion.My.Resources.Resources.buscar
            Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnBuscar.Location = New System.Drawing.Point(740, 28)
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(76, 40)
            Me.btnBuscar.TabIndex = 252
            Me.btnBuscar.Text = "Buscar"
            Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnBuscar.UseVisualStyleBackColor = True
            '
            'dgvFacturas
            '
            Me.dgvFacturas.AllowUserToAddRows = False
            Me.dgvFacturas.AllowUserToDeleteRows = False
            Me.dgvFacturas.AllowUserToResizeColumns = False
            Me.dgvFacturas.AllowUserToResizeRows = False
            Me.dgvFacturas.BackgroundColor = System.Drawing.Color.White
            Me.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            Me.dgvFacturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_DocPorPagar, Me.Doc, Me.NumFactura, Me.Empresa, Me.subTotalIV, Me.subTotalEx, Me.IV, Me.Total, Me.FechaCancelacion})
            Me.dgvFacturas.GridColor = System.Drawing.Color.White
            Me.dgvFacturas.Location = New System.Drawing.Point(3, 116)
            Me.dgvFacturas.MultiSelect = False
            Me.dgvFacturas.Name = "dgvFacturas"
            Me.dgvFacturas.ReadOnly = True
            Me.dgvFacturas.RowHeadersVisible = False
            Me.dgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvFacturas.Size = New System.Drawing.Size(815, 337)
            Me.dgvFacturas.TabIndex = 262
            '
            'Id_DocPorPagar
            '
            Me.Id_DocPorPagar.HeaderText = "Column1"
            Me.Id_DocPorPagar.Name = "Id_DocPorPagar"
            Me.Id_DocPorPagar.ReadOnly = True
            Me.Id_DocPorPagar.Visible = False
            '
            'Doc
            '
            Me.Doc.DataPropertyName = "Fecha"
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.Format = "d"
            DataGridViewCellStyle1.NullValue = Nothing
            Me.Doc.DefaultCellStyle = DataGridViewCellStyle1
            Me.Doc.HeaderText = "Fecha"
            Me.Doc.Name = "Doc"
            Me.Doc.ReadOnly = True
            Me.Doc.Width = 70
            '
            'NumFactura
            '
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.NumFactura.DefaultCellStyle = DataGridViewCellStyle2
            Me.NumFactura.HeaderText = "# Factura"
            Me.NumFactura.Name = "NumFactura"
            Me.NumFactura.ReadOnly = True
            Me.NumFactura.Width = 80
            '
            'Empresa
            '
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.Format = "d"
            DataGridViewCellStyle3.NullValue = Nothing
            Me.Empresa.DefaultCellStyle = DataGridViewCellStyle3
            Me.Empresa.HeaderText = "Empresa"
            Me.Empresa.Name = "Empresa"
            Me.Empresa.ReadOnly = True
            Me.Empresa.Width = 235
            '
            'subTotalIV
            '
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.Format = "C2"
            DataGridViewCellStyle4.NullValue = Nothing
            Me.subTotalIV.DefaultCellStyle = DataGridViewCellStyle4
            Me.subTotalIV.HeaderText = "SubTotal (IV)"
            Me.subTotalIV.Name = "subTotalIV"
            Me.subTotalIV.ReadOnly = True
            Me.subTotalIV.Width = 85
            '
            'subTotalEx
            '
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle5.Format = "C2"
            DataGridViewCellStyle5.NullValue = Nothing
            Me.subTotalEx.DefaultCellStyle = DataGridViewCellStyle5
            Me.subTotalEx.HeaderText = "SubTotal (EX)"
            Me.subTotalEx.Name = "subTotalEx"
            Me.subTotalEx.ReadOnly = True
            Me.subTotalEx.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.subTotalEx.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.subTotalEx.Width = 80
            '
            'IV
            '
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.Format = "C2"
            DataGridViewCellStyle6.NullValue = Nothing
            Me.IV.DefaultCellStyle = DataGridViewCellStyle6
            Me.IV.HeaderText = "IV"
            Me.IV.Name = "IV"
            Me.IV.ReadOnly = True
            Me.IV.Width = 70
            '
            'Total
            '
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle7.Format = "C2"
            DataGridViewCellStyle7.NullValue = Nothing
            Me.Total.DefaultCellStyle = DataGridViewCellStyle7
            Me.Total.HeaderText = "Total"
            Me.Total.Name = "Total"
            Me.Total.ReadOnly = True
            '
            'FechaCancelacion
            '
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FechaCancelacion.DefaultCellStyle = DataGridViewCellStyle8
            Me.FechaCancelacion.HeaderText = "Estado"
            Me.FechaCancelacion.Name = "FechaCancelacion"
            Me.FechaCancelacion.ReadOnly = True
            Me.FechaCancelacion.Width = 70
            '
            'txtIdProveedor
            '
            Me.txtIdProveedor.Location = New System.Drawing.Point(71, 16)
            Me.txtIdProveedor.Name = "txtIdProveedor"
            Me.txtIdProveedor.Size = New System.Drawing.Size(46, 20)
            Me.txtIdProveedor.TabIndex = 269
            '
            'lblTotalesFacturas
            '
            Me.lblTotalesFacturas.AutoSize = True
            Me.lblTotalesFacturas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotalesFacturas.Location = New System.Drawing.Point(270, 480)
            Me.lblTotalesFacturas.Name = "lblTotalesFacturas"
            Me.lblTotalesFacturas.Size = New System.Drawing.Size(128, 15)
            Me.lblTotalesFacturas.TabIndex = 270
            Me.lblTotalesFacturas.Text = "TOTALES FACTURAS:"
            '
            'lblTotalesNC
            '
            Me.lblTotalesNC.AutoSize = True
            Me.lblTotalesNC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotalesNC.Location = New System.Drawing.Point(219, 506)
            Me.lblTotalesNC.Name = "lblTotalesNC"
            Me.lblTotalesNC.Size = New System.Drawing.Size(182, 15)
            Me.lblTotalesNC.TabIndex = 271
            Me.lblTotalesNC.Text = "TOTALES NOTAS DE CREDITO:"
            '
            'lblTotalFinal
            '
            Me.lblTotalFinal.AutoSize = True
            Me.lblTotalFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotalFinal.Location = New System.Drawing.Point(235, 554)
            Me.lblTotalFinal.Name = "lblTotalFinal"
            Me.lblTotalFinal.Size = New System.Drawing.Size(166, 15)
            Me.lblTotalFinal.TabIndex = 272
            Me.lblTotalFinal.Text = "TOTAL FINAL DE COMPRAS:"
            '
            'lblSubTotalIV
            '
            Me.lblSubTotalIV.Location = New System.Drawing.Point(399, 480)
            Me.lblSubTotalIV.Name = "lblSubTotalIV"
            Me.lblSubTotalIV.Size = New System.Drawing.Size(95, 13)
            Me.lblSubTotalIV.TabIndex = 273
            Me.lblSubTotalIV.Text = "0.00"
            Me.lblSubTotalIV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblSubTotalGeneral
            '
            Me.lblSubTotalGeneral.Location = New System.Drawing.Point(399, 554)
            Me.lblSubTotalGeneral.Name = "lblSubTotalGeneral"
            Me.lblSubTotalGeneral.Size = New System.Drawing.Size(95, 13)
            Me.lblSubTotalGeneral.TabIndex = 274
            Me.lblSubTotalGeneral.Text = "0.00"
            Me.lblSubTotalGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblSubTotalEx
            '
            Me.lblSubTotalEx.Location = New System.Drawing.Point(496, 480)
            Me.lblSubTotalEx.Name = "lblSubTotalEx"
            Me.lblSubTotalEx.Size = New System.Drawing.Size(95, 13)
            Me.lblSubTotalEx.TabIndex = 275
            Me.lblSubTotalEx.Text = "0.00"
            Me.lblSubTotalEx.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblSubTotalExGeneral
            '
            Me.lblSubTotalExGeneral.Location = New System.Drawing.Point(496, 554)
            Me.lblSubTotalExGeneral.Name = "lblSubTotalExGeneral"
            Me.lblSubTotalExGeneral.Size = New System.Drawing.Size(95, 13)
            Me.lblSubTotalExGeneral.TabIndex = 276
            Me.lblSubTotalExGeneral.Text = "0.00"
            Me.lblSubTotalExGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblIV
            '
            Me.lblIV.Location = New System.Drawing.Point(591, 481)
            Me.lblIV.Name = "lblIV"
            Me.lblIV.Size = New System.Drawing.Size(95, 13)
            Me.lblIV.TabIndex = 279
            Me.lblIV.Text = "0.00"
            Me.lblIV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblIVGeneral
            '
            Me.lblIVGeneral.Location = New System.Drawing.Point(591, 555)
            Me.lblIVGeneral.Name = "lblIVGeneral"
            Me.lblIVGeneral.Size = New System.Drawing.Size(95, 13)
            Me.lblIVGeneral.TabIndex = 280
            Me.lblIVGeneral.Text = "0.00"
            Me.lblIVGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblTotal
            '
            Me.lblTotal.Location = New System.Drawing.Point(690, 481)
            Me.lblTotal.Name = "lblTotal"
            Me.lblTotal.Size = New System.Drawing.Size(95, 13)
            Me.lblTotal.TabIndex = 281
            Me.lblTotal.Text = "0.00"
            Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblTotalGeneral
            '
            Me.lblTotalGeneral.Location = New System.Drawing.Point(690, 555)
            Me.lblTotalGeneral.Name = "lblTotalGeneral"
            Me.lblTotalGeneral.Size = New System.Drawing.Size(95, 13)
            Me.lblTotalGeneral.TabIndex = 282
            Me.lblTotalGeneral.Text = "0.00"
            Me.lblTotalGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblTotalNC
            '
            Me.lblTotalNC.Location = New System.Drawing.Point(690, 507)
            Me.lblTotalNC.Name = "lblTotalNC"
            Me.lblTotalNC.Size = New System.Drawing.Size(95, 13)
            Me.lblTotalNC.TabIndex = 284
            Me.lblTotalNC.Text = "0.00"
            Me.lblTotalNC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblIVNC
            '
            Me.lblIVNC.Location = New System.Drawing.Point(591, 507)
            Me.lblIVNC.Name = "lblIVNC"
            Me.lblIVNC.Size = New System.Drawing.Size(95, 13)
            Me.lblIVNC.TabIndex = 283
            Me.lblIVNC.Text = "0.00"
            Me.lblIVNC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(403, 456)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(89, 16)
            Me.Label1.TabIndex = 285
            Me.Label1.Text = "Sub Total (IV)"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(499, 456)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(94, 16)
            Me.Label2.TabIndex = 286
            Me.Label2.Text = "Sub Total (EX)"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(628, 457)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(20, 16)
            Me.Label4.TabIndex = 288
            Me.Label4.Text = "IV"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(711, 457)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(39, 16)
            Me.Label5.TabIndex = 289
            Me.Label5.Text = "Total"
            '
            'btnLimpiar
            '
            Me.btnLimpiar.Image = Global.Presentacion.My.Resources.Resources.Limpiar
            Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnLimpiar.Location = New System.Drawing.Point(64, 0)
            Me.btnLimpiar.Name = "btnLimpiar"
            Me.btnLimpiar.Size = New System.Drawing.Size(65, 57)
            Me.btnLimpiar.TabIndex = 290
            Me.btnLimpiar.Text = "Limpiar"
            Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnLimpiar.UseVisualStyleBackColor = True
            '
            'lblSubTotalExNC
            '
            Me.lblSubTotalExNC.Location = New System.Drawing.Point(496, 508)
            Me.lblSubTotalExNC.Name = "lblSubTotalExNC"
            Me.lblSubTotalExNC.Size = New System.Drawing.Size(95, 13)
            Me.lblSubTotalExNC.TabIndex = 291
            Me.lblSubTotalExNC.Text = "0.00"
            Me.lblSubTotalExNC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblSubTotalIVNC
            '
            Me.lblSubTotalIVNC.Location = New System.Drawing.Point(399, 508)
            Me.lblSubTotalIVNC.Name = "lblSubTotalIVNC"
            Me.lblSubTotalIVNC.Size = New System.Drawing.Size(95, 13)
            Me.lblSubTotalIVNC.TabIndex = 292
            Me.lblSubTotalIVNC.Text = "0.00"
            Me.lblSubTotalIVNC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblTotalND
            '
            Me.lblTotalND.Location = New System.Drawing.Point(690, 532)
            Me.lblTotalND.Name = "lblTotalND"
            Me.lblTotalND.Size = New System.Drawing.Size(95, 13)
            Me.lblTotalND.TabIndex = 297
            Me.lblTotalND.Text = "0.00"
            Me.lblTotalND.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblIVND
            '
            Me.lblIVND.Location = New System.Drawing.Point(591, 532)
            Me.lblIVND.Name = "lblIVND"
            Me.lblIVND.Size = New System.Drawing.Size(95, 13)
            Me.lblIVND.TabIndex = 296
            Me.lblIVND.Text = "0.00"
            Me.lblIVND.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblSubTotalExND
            '
            Me.lblSubTotalExND.Location = New System.Drawing.Point(496, 531)
            Me.lblSubTotalExND.Name = "lblSubTotalExND"
            Me.lblSubTotalExND.Size = New System.Drawing.Size(95, 13)
            Me.lblSubTotalExND.TabIndex = 295
            Me.lblSubTotalExND.Text = "0.00"
            Me.lblSubTotalExND.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblSubTotalIVND
            '
            Me.lblSubTotalIVND.Location = New System.Drawing.Point(399, 531)
            Me.lblSubTotalIVND.Name = "lblSubTotalIVND"
            Me.lblSubTotalIVND.Size = New System.Drawing.Size(95, 13)
            Me.lblSubTotalIVND.TabIndex = 294
            Me.lblSubTotalIVND.Text = "0.00"
            Me.lblSubTotalIVND.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblTotalesND
            '
            Me.lblTotalesND.AutoSize = True
            Me.lblTotalesND.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotalesND.Location = New System.Drawing.Point(229, 531)
            Me.lblTotalesND.Name = "lblTotalesND"
            Me.lblTotalesND.Size = New System.Drawing.Size(173, 15)
            Me.lblTotalesND.TabIndex = 293
            Me.lblTotalesND.Text = "TOTALES NOTAS DE DEBITO:"
            '
            'MnEditar
            '
            Me.MnEditar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem})
            Me.MnEditar.Name = "MnEditar"
            Me.MnEditar.Size = New System.Drawing.Size(127, 26)
            '
            'EditarToolStripMenuItem
            '
            Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
            Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
            Me.EditarToolStripMenuItem.Text = "Ver/Editar"
            '
            'FrmHistorialComprasPorProveedor
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(825, 577)
            Me.Controls.Add(Me.dgvProveedor)
            Me.Controls.Add(Me.lblTotalND)
            Me.Controls.Add(Me.lblIVND)
            Me.Controls.Add(Me.lblSubTotalExND)
            Me.Controls.Add(Me.lblSubTotalIVND)
            Me.Controls.Add(Me.lblTotalesND)
            Me.Controls.Add(Me.lblSubTotalIVNC)
            Me.Controls.Add(Me.lblSubTotalExNC)
            Me.Controls.Add(Me.btnLimpiar)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.btnBuscar)
            Me.Controls.Add(Me.lblTotalNC)
            Me.Controls.Add(Me.lblIVNC)
            Me.Controls.Add(Me.btnImprimir)
            Me.Controls.Add(Me.lblTotal)
            Me.Controls.Add(Me.lblTotalGeneral)
            Me.Controls.Add(Me.lblIV)
            Me.Controls.Add(Me.lblSubTotalEx)
            Me.Controls.Add(Me.lblIVGeneral)
            Me.Controls.Add(Me.lblSubTotalExGeneral)
            Me.Controls.Add(Me.lblSubTotalIV)
            Me.Controls.Add(Me.txtIdProveedor)
            Me.Controls.Add(Me.lblSubTotalGeneral)
            Me.Controls.Add(Me.lblTotalFinal)
            Me.Controls.Add(Me.lblTotalesNC)
            Me.Controls.Add(Me.lblTotalesFacturas)
            Me.Controls.Add(Me.gbTipo)
            Me.Controls.Add(Me.dgvFacturas)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmHistorialComprasPorProveedor"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Historial de compras por proveedor"
            CType(Me.dgvProveedor, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbTipo.ResumeLayout(False)
            Me.gbTipo.PerformLayout()
            CType(Me.dgvFacturas, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MnEditar.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents btnImprimir As System.Windows.Forms.Button
        Friend WithEvents dgvProveedor As System.Windows.Forms.DataGridView
        Friend WithEvents gbTipo As System.Windows.Forms.GroupBox
        Friend WithEvents txtDato2 As System.Windows.Forms.TextBox
        Friend WithEvents cmbTipoConsulta As System.Windows.Forms.ComboBox
        Friend WithEvents txtDato As System.Windows.Forms.TextBox
        Friend WithEvents btnBuscar As System.Windows.Forms.Button
        Friend WithEvents dgvFacturas As System.Windows.Forms.DataGridView
        Friend WithEvents txtIdProveedor As System.Windows.Forms.TextBox
        Friend WithEvents dtpFinal As System.Windows.Forms.DateTimePicker
        Friend WithEvents lblFechaFinal As System.Windows.Forms.Label
        Friend WithEvents lblFechaInicial As System.Windows.Forms.Label
        Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
        Friend WithEvents lblTotalesFacturas As System.Windows.Forms.Label
        Friend WithEvents lblTotalesNC As System.Windows.Forms.Label
        Friend WithEvents lblTotalFinal As System.Windows.Forms.Label
        Friend WithEvents lblSubTotalIV As System.Windows.Forms.Label
        Friend WithEvents lblSubTotalGeneral As System.Windows.Forms.Label
        Friend WithEvents lblSubTotalEx As System.Windows.Forms.Label
        Friend WithEvents lblSubTotalExGeneral As System.Windows.Forms.Label
        Friend WithEvents lblIV As System.Windows.Forms.Label
        Friend WithEvents lblIVGeneral As System.Windows.Forms.Label
        Friend WithEvents lblTotal As System.Windows.Forms.Label
        Friend WithEvents lblTotalGeneral As System.Windows.Forms.Label
        Friend WithEvents lblTotalNC As System.Windows.Forms.Label
        Friend WithEvents lblIVNC As System.Windows.Forms.Label
        Friend WithEvents rbPendiente As System.Windows.Forms.RadioButton
        Friend WithEvents rbCancelada As System.Windows.Forms.RadioButton
        Friend WithEvents rbTodas As System.Windows.Forms.RadioButton
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents btnLimpiar As System.Windows.Forms.Button
        Friend WithEvents lblSubTotalExNC As System.Windows.Forms.Label
        Friend WithEvents lblSubTotalIVNC As System.Windows.Forms.Label
        Friend WithEvents lblTotalND As System.Windows.Forms.Label
        Friend WithEvents lblIVND As System.Windows.Forms.Label
        Friend WithEvents lblSubTotalExND As System.Windows.Forms.Label
        Friend WithEvents lblSubTotalIVND As System.Windows.Forms.Label
        Friend WithEvents lblTotalesND As System.Windows.Forms.Label
        Friend WithEvents rbAnulada As System.Windows.Forms.RadioButton
        Friend WithEvents rbSinAnular As System.Windows.Forms.RadioButton
        Friend WithEvents chkRangoFechas As System.Windows.Forms.CheckBox
        Friend WithEvents MnEditar As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents Id_DocPorPagar As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Doc As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents NumFactura As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Empresa As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents subTotalIV As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents subTotalEx As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents IV As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents FechaCancelacion As System.Windows.Forms.DataGridViewTextBoxColumn
    End Class
End Namespace