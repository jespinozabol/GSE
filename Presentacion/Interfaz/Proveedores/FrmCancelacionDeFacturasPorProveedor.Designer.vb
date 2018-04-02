Namespace Interfaz.Proveedores
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmCancelacionDeFacturasPorProveedor
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
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.dgvProveedores = New System.Windows.Forms.DataGridView()
            Me.txtMontoNC = New System.Windows.Forms.TextBox()
            Me.lblMontoNC = New System.Windows.Forms.Label()
            Me.txtNumNC = New System.Windows.Forms.TextBox()
            Me.lblNum_NotasC = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.dgvTrans3 = New System.Windows.Forms.DataGridView()
            Me.dgvTrans2 = New System.Windows.Forms.DataGridView()
            Me.lblMostrarAnterior = New System.Windows.Forms.Label()
            Me.lblActual = New System.Windows.Forms.Label()
            Me.lblMostrarAbono = New System.Windows.Forms.Label()
            Me.lblAbono = New System.Windows.Forms.Label()
            Me.lblSaldoActual = New System.Windows.Forms.Label()
            Me.lblSaldoAnterior = New System.Windows.Forms.Label()
            Me.dgvTrans1 = New System.Windows.Forms.DataGridView()
            Me.txtTotalCreditos = New System.Windows.Forms.TextBox()
            Me.lblTotalCreditos = New System.Windows.Forms.Label()
            Me.txtNombre = New System.Windows.Forms.TextBox()
            Me.lblNombre = New System.Windows.Forms.Label()
            Me.txtId_Proveedor = New System.Windows.Forms.TextBox()
            Me.lblIdProveedor = New System.Windows.Forms.Label()
            Me.dgvFacturas = New System.Windows.Forms.DataGridView()
            Me.IdPorPagar = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Tipo2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.MontoAbonos = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Plazo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Atraso = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.VerND = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.VerNC = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.AB = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.btnEstado = New System.Windows.Forms.Button()
            Me.txtMontoND = New System.Windows.Forms.TextBox()
            Me.lblMontoND = New System.Windows.Forms.Label()
            Me.txtNumND = New System.Windows.Forms.TextBox()
            Me.lblNum_NotasD = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.MnFactura = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.AbonarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.AnularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelar = New System.Windows.Forms.Button()
            Me.btnBajarTodo = New System.Windows.Forms.Button()
            Me.btnLimpiar = New System.Windows.Forms.Button()
            Me.txtMontoAB = New System.Windows.Forms.TextBox()
            Me.lblMontoAB = New System.Windows.Forms.Label()
            Me.txtNumAbonos = New System.Windows.Forms.TextBox()
            Me.lblNum_Abonos = New System.Windows.Forms.Label()
            Me.txtTotalAtrasado = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.btnNC_General = New System.Windows.Forms.Button()
            Me.txtMontoAbono = New System.Windows.Forms.TextBox()
            Me.btnAbonar = New System.Windows.Forms.Button()
            Me.btnCargarRecibo = New System.Windows.Forms.Button()
            Me.txtVuelto = New System.Windows.Forms.TextBox()
            Me.lblVuelto = New System.Windows.Forms.Label()
            Me.MnNCG = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.VerToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
            Me.EliminarToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnDatosProveedor = New System.Windows.Forms.Button()
            Me.btnFacturas = New System.Windows.Forms.Button()
            Me.btnBajarVencido = New System.Windows.Forms.Button()
            Me.IdDoc1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Desc1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Documento1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Fecha1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Monto1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.IdDoc2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Fecha2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.IdDoc3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Fecha3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvTrans3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvTrans2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvTrans1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MnFactura.SuspendLayout()
            Me.MnNCG.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgvProveedores
            '
            Me.dgvProveedores.AllowUserToAddRows = False
            Me.dgvProveedores.AllowUserToDeleteRows = False
            Me.dgvProveedores.AllowUserToResizeColumns = False
            Me.dgvProveedores.AllowUserToResizeRows = False
            Me.dgvProveedores.BackgroundColor = System.Drawing.Color.White
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvProveedores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvProveedores.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvProveedores.GridColor = System.Drawing.Color.White
            Me.dgvProveedores.Location = New System.Drawing.Point(80, 107)
            Me.dgvProveedores.MultiSelect = False
            Me.dgvProveedores.Name = "dgvProveedores"
            Me.dgvProveedores.ReadOnly = True
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvProveedores.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
            Me.dgvProveedores.RowHeadersVisible = False
            Me.dgvProveedores.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvProveedores.Size = New System.Drawing.Size(349, 105)
            Me.dgvProveedores.TabIndex = 298
            Me.dgvProveedores.Visible = False
            '
            'txtMontoNC
            '
            Me.txtMontoNC.Location = New System.Drawing.Point(67, 134)
            Me.txtMontoNC.MaxLength = 5
            Me.txtMontoNC.Name = "txtMontoNC"
            Me.txtMontoNC.ReadOnly = True
            Me.txtMontoNC.Size = New System.Drawing.Size(88, 20)
            Me.txtMontoNC.TabIndex = 306
            Me.txtMontoNC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblMontoNC
            '
            Me.lblMontoNC.AutoSize = True
            Me.lblMontoNC.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMontoNC.Location = New System.Drawing.Point(66, 116)
            Me.lblMontoNC.Name = "lblMontoNC"
            Me.lblMontoNC.Size = New System.Drawing.Size(63, 15)
            Me.lblMontoNC.TabIndex = 305
            Me.lblMontoNC.Text = "Monto NC"
            '
            'txtNumNC
            '
            Me.txtNumNC.Location = New System.Drawing.Point(12, 134)
            Me.txtNumNC.MaxLength = 5
            Me.txtNumNC.Name = "txtNumNC"
            Me.txtNumNC.ReadOnly = True
            Me.txtNumNC.Size = New System.Drawing.Size(49, 20)
            Me.txtNumNC.TabIndex = 304
            '
            'lblNum_NotasC
            '
            Me.lblNum_NotasC.AutoSize = True
            Me.lblNum_NotasC.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNum_NotasC.Location = New System.Drawing.Point(12, 116)
            Me.lblNum_NotasC.Name = "lblNum_NotasC"
            Me.lblNum_NotasC.Size = New System.Drawing.Size(38, 15)
            Me.lblNum_NotasC.TabIndex = 303
            Me.lblNum_NotasC.Text = "N° NC"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label1.Location = New System.Drawing.Point(11, 496)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(327, 13)
            Me.Label1.TabIndex = 301
            Me.Label1.Text = "* Cancelación (CA), Abono(AB), Nota crédito (NC), Nota débito (ND)"
            '
            'dgvTrans3
            '
            Me.dgvTrans3.AllowUserToAddRows = False
            Me.dgvTrans3.AllowUserToDeleteRows = False
            Me.dgvTrans3.AllowUserToResizeColumns = False
            Me.dgvTrans3.AllowUserToResizeRows = False
            Me.dgvTrans3.BackgroundColor = System.Drawing.Color.White
            Me.dgvTrans3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvTrans3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvTrans3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvTrans3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDoc3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.Fecha3, Me.DataGridViewTextBoxColumn6})
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvTrans3.DefaultCellStyle = DataGridViewCellStyle7
            Me.dgvTrans3.GridColor = System.Drawing.Color.White
            Me.dgvTrans3.Location = New System.Drawing.Point(504, 343)
            Me.dgvTrans3.MultiSelect = False
            Me.dgvTrans3.Name = "dgvTrans3"
            Me.dgvTrans3.ReadOnly = True
            DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvTrans3.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
            Me.dgvTrans3.RowHeadersVisible = False
            Me.dgvTrans3.RowTemplate.Height = 18
            Me.dgvTrans3.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvTrans3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvTrans3.Size = New System.Drawing.Size(260, 150)
            Me.dgvTrans3.TabIndex = 295
            '
            'dgvTrans2
            '
            Me.dgvTrans2.AllowUserToAddRows = False
            Me.dgvTrans2.AllowUserToDeleteRows = False
            Me.dgvTrans2.AllowUserToResizeColumns = False
            Me.dgvTrans2.AllowUserToResizeRows = False
            Me.dgvTrans2.BackgroundColor = System.Drawing.Color.White
            Me.dgvTrans2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
            DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvTrans2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
            Me.dgvTrans2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvTrans2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDoc2, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Fecha2, Me.DataGridViewTextBoxColumn3})
            DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvTrans2.DefaultCellStyle = DataGridViewCellStyle12
            Me.dgvTrans2.GridColor = System.Drawing.Color.White
            Me.dgvTrans2.Location = New System.Drawing.Point(258, 343)
            Me.dgvTrans2.MultiSelect = False
            Me.dgvTrans2.Name = "dgvTrans2"
            Me.dgvTrans2.ReadOnly = True
            DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvTrans2.RowHeadersDefaultCellStyle = DataGridViewCellStyle13
            Me.dgvTrans2.RowHeadersVisible = False
            Me.dgvTrans2.RowTemplate.Height = 18
            Me.dgvTrans2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvTrans2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvTrans2.Size = New System.Drawing.Size(245, 150)
            Me.dgvTrans2.TabIndex = 294
            '
            'lblMostrarAnterior
            '
            Me.lblMostrarAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarAnterior.ForeColor = System.Drawing.Color.Black
            Me.lblMostrarAnterior.Location = New System.Drawing.Point(353, 511)
            Me.lblMostrarAnterior.Name = "lblMostrarAnterior"
            Me.lblMostrarAnterior.Size = New System.Drawing.Size(114, 19)
            Me.lblMostrarAnterior.TabIndex = 289
            Me.lblMostrarAnterior.Text = "0.00"
            Me.lblMostrarAnterior.TextAlign = System.Drawing.ContentAlignment.BottomRight
            '
            'lblActual
            '
            Me.lblActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblActual.ForeColor = System.Drawing.Color.Black
            Me.lblActual.Location = New System.Drawing.Point(600, 542)
            Me.lblActual.Name = "lblActual"
            Me.lblActual.Size = New System.Drawing.Size(123, 20)
            Me.lblActual.TabIndex = 291
            Me.lblActual.Text = "0.00"
            Me.lblActual.TextAlign = System.Drawing.ContentAlignment.BottomRight
            '
            'lblMostrarAbono
            '
            Me.lblMostrarAbono.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarAbono.ForeColor = System.Drawing.Color.Red
            Me.lblMostrarAbono.Location = New System.Drawing.Point(597, 511)
            Me.lblMostrarAbono.Name = "lblMostrarAbono"
            Me.lblMostrarAbono.Size = New System.Drawing.Size(126, 19)
            Me.lblMostrarAbono.TabIndex = 290
            Me.lblMostrarAbono.Text = "0.00"
            Me.lblMostrarAbono.TextAlign = System.Drawing.ContentAlignment.BottomRight
            '
            'lblAbono
            '
            Me.lblAbono.AutoSize = True
            Me.lblAbono.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblAbono.Location = New System.Drawing.Point(484, 511)
            Me.lblAbono.Name = "lblAbono"
            Me.lblAbono.Size = New System.Drawing.Size(118, 19)
            Me.lblAbono.TabIndex = 287
            Me.lblAbono.Text = "Monto a Pagar¢"
            '
            'lblSaldoActual
            '
            Me.lblSaldoActual.AutoSize = True
            Me.lblSaldoActual.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSaldoActual.Location = New System.Drawing.Point(497, 541)
            Me.lblSaldoActual.Name = "lblSaldoActual"
            Me.lblSaldoActual.Size = New System.Drawing.Size(105, 19)
            Me.lblSaldoActual.TabIndex = 288
            Me.lblSaldoActual.Text = "Saldo Actual ¢"
            '
            'lblSaldoAnterior
            '
            Me.lblSaldoAnterior.AutoSize = True
            Me.lblSaldoAnterior.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSaldoAnterior.Location = New System.Drawing.Point(231, 511)
            Me.lblSaldoAnterior.Name = "lblSaldoAnterior"
            Me.lblSaldoAnterior.Size = New System.Drawing.Size(119, 19)
            Me.lblSaldoAnterior.TabIndex = 286
            Me.lblSaldoAnterior.Text = "Saldo Anterior ¢"
            '
            'dgvTrans1
            '
            Me.dgvTrans1.AllowUserToAddRows = False
            Me.dgvTrans1.AllowUserToDeleteRows = False
            Me.dgvTrans1.AllowUserToResizeColumns = False
            Me.dgvTrans1.AllowUserToResizeRows = False
            Me.dgvTrans1.BackgroundColor = System.Drawing.Color.White
            Me.dgvTrans1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
            DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvTrans1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
            Me.dgvTrans1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvTrans1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDoc1, Me.Desc1, Me.Documento1, Me.Fecha1, Me.Monto1})
            DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvTrans1.DefaultCellStyle = DataGridViewCellStyle17
            Me.dgvTrans1.GridColor = System.Drawing.Color.White
            Me.dgvTrans1.Location = New System.Drawing.Point(12, 343)
            Me.dgvTrans1.MultiSelect = False
            Me.dgvTrans1.Name = "dgvTrans1"
            Me.dgvTrans1.ReadOnly = True
            DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvTrans1.RowHeadersDefaultCellStyle = DataGridViewCellStyle18
            Me.dgvTrans1.RowHeadersVisible = False
            Me.dgvTrans1.RowTemplate.Height = 18
            Me.dgvTrans1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvTrans1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvTrans1.Size = New System.Drawing.Size(245, 150)
            Me.dgvTrans1.TabIndex = 285
            '
            'txtTotalCreditos
            '
            Me.txtTotalCreditos.Location = New System.Drawing.Point(577, 134)
            Me.txtTotalCreditos.MaxLength = 5
            Me.txtTotalCreditos.Name = "txtTotalCreditos"
            Me.txtTotalCreditos.ReadOnly = True
            Me.txtTotalCreditos.Size = New System.Drawing.Size(110, 20)
            Me.txtTotalCreditos.TabIndex = 279
            Me.txtTotalCreditos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblTotalCreditos
            '
            Me.lblTotalCreditos.AutoSize = True
            Me.lblTotalCreditos.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotalCreditos.Location = New System.Drawing.Point(576, 116)
            Me.lblTotalCreditos.Name = "lblTotalCreditos"
            Me.lblTotalCreditos.Size = New System.Drawing.Size(83, 15)
            Me.lblTotalCreditos.TabIndex = 278
            Me.lblTotalCreditos.Text = "Total Creditos"
            '
            'txtNombre
            '
            Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombre.Location = New System.Drawing.Point(80, 85)
            Me.txtNombre.MaxLength = 60
            Me.txtNombre.Name = "txtNombre"
            Me.txtNombre.Size = New System.Drawing.Size(409, 22)
            Me.txtNombre.TabIndex = 1
            '
            'lblNombre
            '
            Me.lblNombre.AutoSize = True
            Me.lblNombre.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombre.Location = New System.Drawing.Point(77, 67)
            Me.lblNombre.Name = "lblNombre"
            Me.lblNombre.Size = New System.Drawing.Size(53, 15)
            Me.lblNombre.TabIndex = 265
            Me.lblNombre.Text = "Nombre"
            '
            'txtId_Proveedor
            '
            Me.txtId_Proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtId_Proveedor.Location = New System.Drawing.Point(11, 85)
            Me.txtId_Proveedor.MaxLength = 5
            Me.txtId_Proveedor.Name = "txtId_Proveedor"
            Me.txtId_Proveedor.Size = New System.Drawing.Size(63, 22)
            Me.txtId_Proveedor.TabIndex = 0
            '
            'lblIdProveedor
            '
            Me.lblIdProveedor.AutoSize = True
            Me.lblIdProveedor.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdProveedor.Location = New System.Drawing.Point(5, 67)
            Me.lblIdProveedor.Name = "lblIdProveedor"
            Me.lblIdProveedor.Size = New System.Drawing.Size(53, 15)
            Me.lblIdProveedor.TabIndex = 264
            Me.lblIdProveedor.Text = "Id Prove"
            '
            'dgvFacturas
            '
            Me.dgvFacturas.AllowUserToAddRows = False
            Me.dgvFacturas.AllowUserToDeleteRows = False
            Me.dgvFacturas.AllowUserToResizeColumns = False
            Me.dgvFacturas.AllowUserToResizeRows = False
            Me.dgvFacturas.BackgroundColor = System.Drawing.Color.White
            Me.dgvFacturas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
            Me.dgvFacturas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvFacturas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle19
            Me.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvFacturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPorPagar, Me.Tipo2, Me.Doc, Me.Fecha, Me.Monto, Me.MontoAbonos, Me.Plazo, Me.Atraso, Me.VerND, Me.VerNC, Me.AB})
            DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvFacturas.DefaultCellStyle = DataGridViewCellStyle28
            Me.dgvFacturas.GridColor = System.Drawing.Color.White
            Me.dgvFacturas.Location = New System.Drawing.Point(12, 161)
            Me.dgvFacturas.MultiSelect = False
            Me.dgvFacturas.Name = "dgvFacturas"
            Me.dgvFacturas.ReadOnly = True
            Me.dgvFacturas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvFacturas.RowHeadersDefaultCellStyle = DataGridViewCellStyle29
            Me.dgvFacturas.RowHeadersVisible = False
            Me.dgvFacturas.RowTemplate.Height = 18
            Me.dgvFacturas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvFacturas.Size = New System.Drawing.Size(722, 147)
            Me.dgvFacturas.TabIndex = 280
            '
            'IdPorPagar
            '
            Me.IdPorPagar.HeaderText = "IdPorPagar"
            Me.IdPorPagar.Name = "IdPorPagar"
            Me.IdPorPagar.ReadOnly = True
            Me.IdPorPagar.Visible = False
            '
            'Tipo2
            '
            Me.Tipo2.HeaderText = "Tipo"
            Me.Tipo2.Name = "Tipo2"
            Me.Tipo2.ReadOnly = True
            Me.Tipo2.Width = 40
            '
            'Doc
            '
            Me.Doc.HeaderText = "# Doc"
            Me.Doc.Name = "Doc"
            Me.Doc.ReadOnly = True
            Me.Doc.Width = 80
            '
            'Fecha
            '
            DataGridViewCellStyle20.Format = "d"
            DataGridViewCellStyle20.NullValue = Nothing
            Me.Fecha.DefaultCellStyle = DataGridViewCellStyle20
            Me.Fecha.HeaderText = "Fecha"
            Me.Fecha.Name = "Fecha"
            Me.Fecha.ReadOnly = True
            Me.Fecha.Width = 70
            '
            'Monto
            '
            DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Monto.DefaultCellStyle = DataGridViewCellStyle21
            Me.Monto.HeaderText = "Total"
            Me.Monto.Name = "Monto"
            Me.Monto.ReadOnly = True
            Me.Monto.Width = 105
            '
            'MontoAbonos
            '
            DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MontoAbonos.DefaultCellStyle = DataGridViewCellStyle22
            Me.MontoAbonos.HeaderText = "Total Neto"
            Me.MontoAbonos.Name = "MontoAbonos"
            Me.MontoAbonos.ReadOnly = True
            Me.MontoAbonos.Width = 105
            '
            'Plazo
            '
            DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Plazo.DefaultCellStyle = DataGridViewCellStyle23
            Me.Plazo.HeaderText = "Plazo"
            Me.Plazo.Name = "Plazo"
            Me.Plazo.ReadOnly = True
            Me.Plazo.Width = 55
            '
            'Atraso
            '
            DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Atraso.DefaultCellStyle = DataGridViewCellStyle24
            Me.Atraso.HeaderText = "Atraso"
            Me.Atraso.Name = "Atraso"
            Me.Atraso.ReadOnly = True
            Me.Atraso.Width = 55
            '
            'VerND
            '
            DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle25.BackColor = System.Drawing.Color.Moccasin
            Me.VerND.DefaultCellStyle = DataGridViewCellStyle25
            Me.VerND.HeaderText = "ND"
            Me.VerND.Name = "VerND"
            Me.VerND.ReadOnly = True
            Me.VerND.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.VerND.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.VerND.Width = 45
            '
            'VerNC
            '
            DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle26.BackColor = System.Drawing.Color.Moccasin
            Me.VerNC.DefaultCellStyle = DataGridViewCellStyle26
            Me.VerNC.HeaderText = "NC"
            Me.VerNC.Name = "VerNC"
            Me.VerNC.ReadOnly = True
            Me.VerNC.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.VerNC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.VerNC.Width = 45
            '
            'AB
            '
            DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle27.BackColor = System.Drawing.Color.Moccasin
            Me.AB.DefaultCellStyle = DataGridViewCellStyle27
            Me.AB.HeaderText = "AB"
            Me.AB.Name = "AB"
            Me.AB.ReadOnly = True
            Me.AB.Width = 45
            '
            'btnEstado
            '
            Me.btnEstado.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEstado.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnEstado.Location = New System.Drawing.Point(69, 0)
            Me.btnEstado.Name = "btnEstado"
            Me.btnEstado.Size = New System.Drawing.Size(70, 57)
            Me.btnEstado.TabIndex = 302
            Me.btnEstado.Text = "Estado Cuenta"
            Me.btnEstado.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnEstado.UseVisualStyleBackColor = True
            '
            'txtMontoND
            '
            Me.txtMontoND.Location = New System.Drawing.Point(216, 134)
            Me.txtMontoND.MaxLength = 5
            Me.txtMontoND.Name = "txtMontoND"
            Me.txtMontoND.ReadOnly = True
            Me.txtMontoND.Size = New System.Drawing.Size(88, 20)
            Me.txtMontoND.TabIndex = 312
            Me.txtMontoND.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblMontoND
            '
            Me.lblMontoND.AutoSize = True
            Me.lblMontoND.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMontoND.Location = New System.Drawing.Point(215, 116)
            Me.lblMontoND.Name = "lblMontoND"
            Me.lblMontoND.Size = New System.Drawing.Size(64, 15)
            Me.lblMontoND.TabIndex = 311
            Me.lblMontoND.Text = "Monto ND"
            '
            'txtNumND
            '
            Me.txtNumND.Location = New System.Drawing.Point(161, 134)
            Me.txtNumND.MaxLength = 5
            Me.txtNumND.Name = "txtNumND"
            Me.txtNumND.ReadOnly = True
            Me.txtNumND.Size = New System.Drawing.Size(49, 20)
            Me.txtNumND.TabIndex = 310
            '
            'lblNum_NotasD
            '
            Me.lblNum_NotasD.AutoSize = True
            Me.lblNum_NotasD.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNum_NotasD.Location = New System.Drawing.Point(161, 116)
            Me.lblNum_NotasD.Name = "lblNum_NotasD"
            Me.lblNum_NotasD.Size = New System.Drawing.Size(39, 15)
            Me.lblNum_NotasD.TabIndex = 309
            Me.lblNum_NotasD.Text = "N° ND"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(412, 21)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(242, 24)
            Me.Label2.TabIndex = 314
            Me.Label2.Text = "Cancelación de Facturas"
            '
            'MnFactura
            '
            Me.MnFactura.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbonarToolStripMenuItem, Me.EditarToolStripMenuItem, Me.AnularToolStripMenuItem})
            Me.MnFactura.Name = "MnAbonar"
            Me.MnFactura.Size = New System.Drawing.Size(127, 70)
            '
            'AbonarToolStripMenuItem
            '
            Me.AbonarToolStripMenuItem.Name = "AbonarToolStripMenuItem"
            Me.AbonarToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
            Me.AbonarToolStripMenuItem.Text = "Abonar"
            '
            'EditarToolStripMenuItem
            '
            Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
            Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
            Me.EditarToolStripMenuItem.Text = "Ver/Editar"
            '
            'AnularToolStripMenuItem
            '
            Me.AnularToolStripMenuItem.Name = "AnularToolStripMenuItem"
            Me.AnularToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
            Me.AnularToolStripMenuItem.Text = "Anular"
            '
            'btnCancelar
            '
            Me.btnCancelar.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnCancelar.Location = New System.Drawing.Point(0, 0)
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.Size = New System.Drawing.Size(70, 57)
            Me.btnCancelar.TabIndex = 315
            Me.btnCancelar.Text = "Cancelar Facturas"
            Me.btnCancelar.UseVisualStyleBackColor = True
            '
            'btnBajarTodo
            '
            Me.btnBajarTodo.Enabled = False
            Me.btnBajarTodo.Image = Global.Presentacion.My.Resources.Resources.abajo
            Me.btnBajarTodo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnBajarTodo.Location = New System.Drawing.Point(682, 314)
            Me.btnBajarTodo.Name = "btnBajarTodo"
            Me.btnBajarTodo.Size = New System.Drawing.Size(52, 23)
            Me.btnBajarTodo.TabIndex = 313
            Me.btnBajarTodo.Text = "Todo"
            Me.btnBajarTodo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnBajarTodo.UseVisualStyleBackColor = True
            '
            'btnLimpiar
            '
            Me.btnLimpiar.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnLimpiar.Image = Global.Presentacion.My.Resources.Resources.Limpiar
            Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnLimpiar.Location = New System.Drawing.Point(207, 0)
            Me.btnLimpiar.Name = "btnLimpiar"
            Me.btnLimpiar.Size = New System.Drawing.Size(70, 57)
            Me.btnLimpiar.TabIndex = 262
            Me.btnLimpiar.Text = "Limpiar"
            Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnLimpiar.UseVisualStyleBackColor = True
            '
            'txtMontoAB
            '
            Me.txtMontoAB.Location = New System.Drawing.Point(365, 134)
            Me.txtMontoAB.MaxLength = 5
            Me.txtMontoAB.Name = "txtMontoAB"
            Me.txtMontoAB.ReadOnly = True
            Me.txtMontoAB.Size = New System.Drawing.Size(88, 20)
            Me.txtMontoAB.TabIndex = 319
            Me.txtMontoAB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblMontoAB
            '
            Me.lblMontoAB.AutoSize = True
            Me.lblMontoAB.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMontoAB.Location = New System.Drawing.Point(364, 116)
            Me.lblMontoAB.Name = "lblMontoAB"
            Me.lblMontoAB.Size = New System.Drawing.Size(63, 15)
            Me.lblMontoAB.TabIndex = 318
            Me.lblMontoAB.Text = "Monto AB"
            '
            'txtNumAbonos
            '
            Me.txtNumAbonos.Location = New System.Drawing.Point(310, 134)
            Me.txtNumAbonos.MaxLength = 5
            Me.txtNumAbonos.Name = "txtNumAbonos"
            Me.txtNumAbonos.ReadOnly = True
            Me.txtNumAbonos.Size = New System.Drawing.Size(49, 20)
            Me.txtNumAbonos.TabIndex = 317
            '
            'lblNum_Abonos
            '
            Me.lblNum_Abonos.AutoSize = True
            Me.lblNum_Abonos.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNum_Abonos.Location = New System.Drawing.Point(310, 116)
            Me.lblNum_Abonos.Name = "lblNum_Abonos"
            Me.lblNum_Abonos.Size = New System.Drawing.Size(38, 15)
            Me.lblNum_Abonos.TabIndex = 316
            Me.lblNum_Abonos.Text = "N° AB"
            '
            'txtTotalAtrasado
            '
            Me.txtTotalAtrasado.Location = New System.Drawing.Point(461, 134)
            Me.txtTotalAtrasado.MaxLength = 5
            Me.txtTotalAtrasado.Name = "txtTotalAtrasado"
            Me.txtTotalAtrasado.ReadOnly = True
            Me.txtTotalAtrasado.Size = New System.Drawing.Size(110, 20)
            Me.txtTotalAtrasado.TabIndex = 321
            Me.txtTotalAtrasado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(460, 116)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(86, 15)
            Me.Label3.TabIndex = 320
            Me.Label3.Text = "Total Atrasado"
            '
            'btnNC_General
            '
            Me.btnNC_General.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNC_General.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnNC_General.Location = New System.Drawing.Point(138, 0)
            Me.btnNC_General.Name = "btnNC_General"
            Me.btnNC_General.Size = New System.Drawing.Size(70, 57)
            Me.btnNC_General.TabIndex = 322
            Me.btnNC_General.Text = "Crear NC General"
            Me.btnNC_General.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnNC_General.UseVisualStyleBackColor = True
            '
            'txtMontoAbono
            '
            Me.txtMontoAbono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMontoAbono.Location = New System.Drawing.Point(11, 316)
            Me.txtMontoAbono.MaxLength = 10
            Me.txtMontoAbono.Name = "txtMontoAbono"
            Me.txtMontoAbono.Size = New System.Drawing.Size(112, 22)
            Me.txtMontoAbono.TabIndex = 327
            Me.txtMontoAbono.Text = "0"
            Me.txtMontoAbono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'btnAbonar
            '
            Me.btnAbonar.Enabled = False
            Me.btnAbonar.Location = New System.Drawing.Point(475, 314)
            Me.btnAbonar.Name = "btnAbonar"
            Me.btnAbonar.Size = New System.Drawing.Size(96, 23)
            Me.btnAbonar.TabIndex = 326
            Me.btnAbonar.Text = "Abonar Vuelto?"
            Me.btnAbonar.UseVisualStyleBackColor = True
            '
            'btnCargarRecibo
            '
            Me.btnCargarRecibo.Enabled = False
            Me.btnCargarRecibo.Location = New System.Drawing.Point(129, 314)
            Me.btnCargarRecibo.Name = "btnCargarRecibo"
            Me.btnCargarRecibo.Size = New System.Drawing.Size(161, 23)
            Me.btnCargarRecibo.TabIndex = 323
            Me.btnCargarRecibo.Text = "Abono/Cancelación General"
            Me.btnCargarRecibo.UseVisualStyleBackColor = True
            '
            'txtVuelto
            '
            Me.txtVuelto.Location = New System.Drawing.Point(369, 315)
            Me.txtVuelto.MaxLength = 5
            Me.txtVuelto.Name = "txtVuelto"
            Me.txtVuelto.ReadOnly = True
            Me.txtVuelto.Size = New System.Drawing.Size(100, 20)
            Me.txtVuelto.TabIndex = 325
            Me.txtVuelto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblVuelto
            '
            Me.lblVuelto.AutoSize = True
            Me.lblVuelto.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblVuelto.Location = New System.Drawing.Point(320, 318)
            Me.lblVuelto.Name = "lblVuelto"
            Me.lblVuelto.Size = New System.Drawing.Size(43, 15)
            Me.lblVuelto.TabIndex = 324
            Me.lblVuelto.Text = "Vuelto"
            '
            'MnNCG
            '
            Me.MnNCG.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerToolStripMenuItem2, Me.EliminarToolStripMenuItem3})
            Me.MnNCG.Name = "MnAbonar"
            Me.MnNCG.Size = New System.Drawing.Size(127, 48)
            '
            'VerToolStripMenuItem2
            '
            Me.VerToolStripMenuItem2.Name = "VerToolStripMenuItem2"
            Me.VerToolStripMenuItem2.Size = New System.Drawing.Size(126, 22)
            Me.VerToolStripMenuItem2.Text = "Ver/Editar"
            '
            'EliminarToolStripMenuItem3
            '
            Me.EliminarToolStripMenuItem3.Name = "EliminarToolStripMenuItem3"
            Me.EliminarToolStripMenuItem3.Size = New System.Drawing.Size(126, 22)
            Me.EliminarToolStripMenuItem3.Text = "Eliminar"
            '
            'btnDatosProveedor
            '
            Me.btnDatosProveedor.Enabled = False
            Me.btnDatosProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnDatosProveedor.Location = New System.Drawing.Point(630, 67)
            Me.btnDatosProveedor.Name = "btnDatosProveedor"
            Me.btnDatosProveedor.Size = New System.Drawing.Size(134, 45)
            Me.btnDatosProveedor.TabIndex = 328
            Me.btnDatosProveedor.Text = "Datos del proveedor"
            Me.btnDatosProveedor.UseVisualStyleBackColor = True
            '
            'btnFacturas
            '
            Me.btnFacturas.Enabled = False
            Me.btnFacturas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnFacturas.Location = New System.Drawing.Point(495, 67)
            Me.btnFacturas.Name = "btnFacturas"
            Me.btnFacturas.Size = New System.Drawing.Size(128, 45)
            Me.btnFacturas.TabIndex = 329
            Me.btnFacturas.Text = "Agregar/Editar Facturas"
            Me.btnFacturas.UseVisualStyleBackColor = True
            '
            'btnBajarVencido
            '
            Me.btnBajarVencido.Enabled = False
            Me.btnBajarVencido.Image = Global.Presentacion.My.Resources.Resources.abajo
            Me.btnBajarVencido.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnBajarVencido.Location = New System.Drawing.Point(612, 313)
            Me.btnBajarVencido.Name = "btnBajarVencido"
            Me.btnBajarVencido.Size = New System.Drawing.Size(64, 23)
            Me.btnBajarVencido.TabIndex = 330
            Me.btnBajarVencido.Text = "Vencido"
            Me.btnBajarVencido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnBajarVencido.UseVisualStyleBackColor = True
            '
            'IdDoc1
            '
            Me.IdDoc1.HeaderText = "IdDoc1"
            Me.IdDoc1.Name = "IdDoc1"
            Me.IdDoc1.ReadOnly = True
            Me.IdDoc1.Visible = False
            '
            'Desc1
            '
            DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Desc1.DefaultCellStyle = DataGridViewCellStyle15
            Me.Desc1.HeaderText = "Tipo"
            Me.Desc1.Name = "Desc1"
            Me.Desc1.ReadOnly = True
            Me.Desc1.Width = 36
            '
            'Documento1
            '
            Me.Documento1.HeaderText = "Doc"
            Me.Documento1.Name = "Documento1"
            Me.Documento1.ReadOnly = True
            Me.Documento1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
            Me.Documento1.Width = 57
            '
            'Fecha1
            '
            Me.Fecha1.HeaderText = "Fecha"
            Me.Fecha1.Name = "Fecha1"
            Me.Fecha1.ReadOnly = True
            Me.Fecha1.Width = 68
            '
            'Monto1
            '
            DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Monto1.DefaultCellStyle = DataGridViewCellStyle16
            Me.Monto1.HeaderText = "Monto"
            Me.Monto1.Name = "Monto1"
            Me.Monto1.ReadOnly = True
            Me.Monto1.Width = 80
            '
            'IdDoc2
            '
            Me.IdDoc2.HeaderText = "IdDoc2"
            Me.IdDoc2.Name = "IdDoc2"
            Me.IdDoc2.ReadOnly = True
            Me.IdDoc2.Visible = False
            '
            'DataGridViewTextBoxColumn1
            '
            DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle10
            Me.DataGridViewTextBoxColumn1.HeaderText = "Tipo"
            Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
            Me.DataGridViewTextBoxColumn1.ReadOnly = True
            Me.DataGridViewTextBoxColumn1.Width = 36
            '
            'DataGridViewTextBoxColumn2
            '
            Me.DataGridViewTextBoxColumn2.HeaderText = "Doc"
            Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
            Me.DataGridViewTextBoxColumn2.ReadOnly = True
            Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
            Me.DataGridViewTextBoxColumn2.Width = 57
            '
            'Fecha2
            '
            Me.Fecha2.HeaderText = "Fecha"
            Me.Fecha2.Name = "Fecha2"
            Me.Fecha2.ReadOnly = True
            Me.Fecha2.Width = 68
            '
            'DataGridViewTextBoxColumn3
            '
            DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle11
            Me.DataGridViewTextBoxColumn3.HeaderText = "Monto"
            Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
            Me.DataGridViewTextBoxColumn3.ReadOnly = True
            Me.DataGridViewTextBoxColumn3.Width = 80
            '
            'IdDoc3
            '
            Me.IdDoc3.HeaderText = "IdDoc3"
            Me.IdDoc3.Name = "IdDoc3"
            Me.IdDoc3.ReadOnly = True
            Me.IdDoc3.Visible = False
            '
            'DataGridViewTextBoxColumn4
            '
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle5
            Me.DataGridViewTextBoxColumn4.HeaderText = "Tipo"
            Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
            Me.DataGridViewTextBoxColumn4.ReadOnly = True
            Me.DataGridViewTextBoxColumn4.Width = 36
            '
            'DataGridViewTextBoxColumn5
            '
            Me.DataGridViewTextBoxColumn5.HeaderText = "Doc"
            Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
            Me.DataGridViewTextBoxColumn5.ReadOnly = True
            Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
            Me.DataGridViewTextBoxColumn5.Width = 52
            '
            'Fecha3
            '
            Me.Fecha3.HeaderText = "Fecha"
            Me.Fecha3.Name = "Fecha3"
            Me.Fecha3.ReadOnly = True
            Me.Fecha3.Width = 68
            '
            'DataGridViewTextBoxColumn6
            '
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle6
            Me.DataGridViewTextBoxColumn6.HeaderText = "Monto"
            Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
            Me.DataGridViewTextBoxColumn6.ReadOnly = True
            Me.DataGridViewTextBoxColumn6.Width = 80
            '
            'FrmCancelacionDeFacturasPorProveedor
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(770, 576)
            Me.Controls.Add(Me.btnBajarVencido)
            Me.Controls.Add(Me.btnFacturas)
            Me.Controls.Add(Me.btnDatosProveedor)
            Me.Controls.Add(Me.txtMontoAbono)
            Me.Controls.Add(Me.btnAbonar)
            Me.Controls.Add(Me.btnCargarRecibo)
            Me.Controls.Add(Me.txtVuelto)
            Me.Controls.Add(Me.lblVuelto)
            Me.Controls.Add(Me.txtTotalAtrasado)
            Me.Controls.Add(Me.btnNC_General)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.dgvProveedores)
            Me.Controls.Add(Me.txtMontoAB)
            Me.Controls.Add(Me.lblMontoAB)
            Me.Controls.Add(Me.txtNumAbonos)
            Me.Controls.Add(Me.lblNum_Abonos)
            Me.Controls.Add(Me.txtMontoND)
            Me.Controls.Add(Me.btnBajarTodo)
            Me.Controls.Add(Me.btnCancelar)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.lblMontoND)
            Me.Controls.Add(Me.txtNumND)
            Me.Controls.Add(Me.lblNum_NotasD)
            Me.Controls.Add(Me.txtMontoNC)
            Me.Controls.Add(Me.lblMontoNC)
            Me.Controls.Add(Me.txtNumNC)
            Me.Controls.Add(Me.lblNum_NotasC)
            Me.Controls.Add(Me.btnEstado)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.dgvTrans3)
            Me.Controls.Add(Me.dgvTrans2)
            Me.Controls.Add(Me.lblMostrarAnterior)
            Me.Controls.Add(Me.lblActual)
            Me.Controls.Add(Me.lblMostrarAbono)
            Me.Controls.Add(Me.lblSaldoActual)
            Me.Controls.Add(Me.lblAbono)
            Me.Controls.Add(Me.lblSaldoAnterior)
            Me.Controls.Add(Me.txtTotalCreditos)
            Me.Controls.Add(Me.txtNombre)
            Me.Controls.Add(Me.lblTotalCreditos)
            Me.Controls.Add(Me.lblNombre)
            Me.Controls.Add(Me.txtId_Proveedor)
            Me.Controls.Add(Me.lblIdProveedor)
            Me.Controls.Add(Me.btnLimpiar)
            Me.Controls.Add(Me.dgvFacturas)
            Me.Controls.Add(Me.dgvTrans1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmCancelacionDeFacturasPorProveedor"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Cancelación de Facturas"
            CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvTrans3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvTrans2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvTrans1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvFacturas, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MnFactura.ResumeLayout(False)
            Me.MnNCG.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvProveedores As System.Windows.Forms.DataGridView
        Friend WithEvents txtMontoNC As System.Windows.Forms.TextBox
        Friend WithEvents lblMontoNC As System.Windows.Forms.Label
        Friend WithEvents txtNumNC As System.Windows.Forms.TextBox
        Friend WithEvents lblNum_NotasC As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents dgvTrans3 As System.Windows.Forms.DataGridView
        Friend WithEvents dgvTrans2 As System.Windows.Forms.DataGridView
        Friend WithEvents lblMostrarAnterior As System.Windows.Forms.Label
        Friend WithEvents lblActual As System.Windows.Forms.Label
        Friend WithEvents lblMostrarAbono As System.Windows.Forms.Label
        Friend WithEvents lblAbono As System.Windows.Forms.Label
        Friend WithEvents lblSaldoActual As System.Windows.Forms.Label
        Friend WithEvents lblSaldoAnterior As System.Windows.Forms.Label
        Friend WithEvents dgvTrans1 As System.Windows.Forms.DataGridView
        Friend WithEvents txtTotalCreditos As System.Windows.Forms.TextBox
        Friend WithEvents lblTotalCreditos As System.Windows.Forms.Label
        Friend WithEvents txtNombre As System.Windows.Forms.TextBox
        Friend WithEvents lblNombre As System.Windows.Forms.Label
        Friend WithEvents txtId_Proveedor As System.Windows.Forms.TextBox
        Friend WithEvents lblIdProveedor As System.Windows.Forms.Label
        Friend WithEvents btnLimpiar As System.Windows.Forms.Button
        Friend WithEvents dgvFacturas As System.Windows.Forms.DataGridView
        Friend WithEvents btnEstado As System.Windows.Forms.Button
        Friend WithEvents txtMontoND As System.Windows.Forms.TextBox
        Friend WithEvents lblMontoND As System.Windows.Forms.Label
        Friend WithEvents txtNumND As System.Windows.Forms.TextBox
        Friend WithEvents lblNum_NotasD As System.Windows.Forms.Label
        Friend WithEvents btnBajarTodo As System.Windows.Forms.Button
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents MnFactura As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents AbonarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelar As System.Windows.Forms.Button
        Friend WithEvents txtMontoAB As System.Windows.Forms.TextBox
        Friend WithEvents lblMontoAB As System.Windows.Forms.Label
        Friend WithEvents txtNumAbonos As System.Windows.Forms.TextBox
        Friend WithEvents lblNum_Abonos As System.Windows.Forms.Label
        Friend WithEvents txtTotalAtrasado As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnNC_General As System.Windows.Forms.Button
        Friend WithEvents txtMontoAbono As System.Windows.Forms.TextBox
        Friend WithEvents btnAbonar As System.Windows.Forms.Button
        Friend WithEvents btnCargarRecibo As System.Windows.Forms.Button
        Friend WithEvents txtVuelto As System.Windows.Forms.TextBox
        Friend WithEvents lblVuelto As System.Windows.Forms.Label
        Friend WithEvents AnularToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents IdPorPagar As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Tipo2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Doc As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Monto As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents MontoAbonos As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Plazo As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Atraso As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents VerND As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents VerNC As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents AB As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents MnNCG As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents VerToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents EliminarToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnDatosProveedor As System.Windows.Forms.Button
        Friend WithEvents btnFacturas As System.Windows.Forms.Button
        Friend WithEvents btnBajarVencido As System.Windows.Forms.Button
        Friend WithEvents IdDoc3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Fecha3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents IdDoc2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Fecha2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents IdDoc1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Desc1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Documento1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Fecha1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Monto1 As System.Windows.Forms.DataGridViewTextBoxColumn
    End Class
End Namespace