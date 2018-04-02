Namespace Interfaz.Creditos
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmFacturaCredito
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
            Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle36 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.btnLimpiar = New System.Windows.Forms.Button()
            Me.txtId_Credito = New System.Windows.Forms.TextBox()
            Me.lblId_Credito = New System.Windows.Forms.Label()
            Me.txtNombre = New System.Windows.Forms.TextBox()
            Me.lblNombre = New System.Windows.Forms.Label()
            Me.txtCedula = New System.Windows.Forms.TextBox()
            Me.lblCedula = New System.Windows.Forms.Label()
            Me.lblRecibo = New System.Windows.Forms.Label()
            Me.lblMostrarReciboAbonos = New System.Windows.Forms.Label()
            Me.txtNumAbonos = New System.Windows.Forms.TextBox()
            Me.lblNumAbonos = New System.Windows.Forms.Label()
            Me.txtMontoAbonos = New System.Windows.Forms.TextBox()
            Me.lblMontoAbonos = New System.Windows.Forms.Label()
            Me.txtLimite = New System.Windows.Forms.TextBox()
            Me.lblLimite = New System.Windows.Forms.Label()
            Me.txtTotalAtrasado = New System.Windows.Forms.TextBox()
            Me.lblTotalAtrasado = New System.Windows.Forms.Label()
            Me.txtTotalCreditos = New System.Windows.Forms.TextBox()
            Me.lblTotalCreditos = New System.Windows.Forms.Label()
            Me.dgvFacturas = New System.Windows.Forms.DataGridView()
            Me.Tipo2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.MontoAbonos = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Plazo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Atraso = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.VerAbono = New System.Windows.Forms.DataGridViewLinkColumn()
            Me.VerNC = New System.Windows.Forms.DataGridViewLinkColumn()
            Me.VerND = New System.Windows.Forms.DataGridViewLinkColumn()
            Me.btnCargarRecibo = New System.Windows.Forms.Button()
            Me.txtVuelto = New System.Windows.Forms.TextBox()
            Me.lblVuelto = New System.Windows.Forms.Label()
            Me.btnAbonar = New System.Windows.Forms.Button()
            Me.dgvTrans1 = New System.Windows.Forms.DataGridView()
            Me.Desc1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Documento1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Fecha1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Monto1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.lblSaldoAnterior = New System.Windows.Forms.Label()
            Me.lblAbono = New System.Windows.Forms.Label()
            Me.lblSaldoActual = New System.Windows.Forms.Label()
            Me.lblMostrarAnterior = New System.Windows.Forms.Label()
            Me.lblMostrarAbono = New System.Windows.Forms.Label()
            Me.lblActual = New System.Windows.Forms.Label()
            Me.btnEjecutar = New System.Windows.Forms.Button()
            Me.timerRecibo = New System.Windows.Forms.Timer(Me.components)
            Me.txtMontoAbono = New System.Windows.Forms.TextBox()
            Me.dgvTrans2 = New System.Windows.Forms.DataGridView()
            Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Fecha2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvTrans3 = New System.Windows.Forms.DataGridView()
            Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Fecha3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.MnAbonar = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.AbonarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.NotaCréditoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.lblReciboFacturas = New System.Windows.Forms.Label()
            Me.lblRciboFact = New System.Windows.Forms.Label()
            Me.dgvClientes = New System.Windows.Forms.DataGridView()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.btnEstado = New System.Windows.Forms.Button()
            Me.txtMontoNC = New System.Windows.Forms.TextBox()
            Me.lblMontoNC = New System.Windows.Forms.Label()
            Me.txtNumNC = New System.Windows.Forms.TextBox()
            Me.lblNum_Notas = New System.Windows.Forms.Label()
            Me.notaCredito = New System.Windows.Forms.Button()
            Me.btnClientes_Credito = New System.Windows.Forms.Button()
            Me.btnNota_Debito = New System.Windows.Forms.Button()
            Me.btnDatosCliente = New System.Windows.Forms.Button()
            Me.lblMostrarObservaciones = New System.Windows.Forms.Label()
            CType(Me.dgvFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvTrans1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvTrans2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvTrans3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MnAbonar.SuspendLayout()
            CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'btnLimpiar
            '
            Me.btnLimpiar.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnLimpiar.Image = Global.Presentacion.My.Resources.Resources.Limpiar
            Me.btnLimpiar.Location = New System.Drawing.Point(256, 0)
            Me.btnLimpiar.Name = "btnLimpiar"
            Me.btnLimpiar.Size = New System.Drawing.Size(65, 57)
            Me.btnLimpiar.TabIndex = 174
            Me.btnLimpiar.Text = "Limpiar"
            Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnLimpiar.UseVisualStyleBackColor = True
            '
            'txtId_Credito
            '
            Me.txtId_Credito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtId_Credito.Location = New System.Drawing.Point(12, 88)
            Me.txtId_Credito.MaxLength = 5
            Me.txtId_Credito.Name = "txtId_Credito"
            Me.txtId_Credito.Size = New System.Drawing.Size(53, 20)
            Me.txtId_Credito.TabIndex = 1
            '
            'lblId_Credito
            '
            Me.lblId_Credito.AutoSize = True
            Me.lblId_Credito.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblId_Credito.Location = New System.Drawing.Point(6, 70)
            Me.lblId_Credito.Name = "lblId_Credito"
            Me.lblId_Credito.Size = New System.Drawing.Size(59, 15)
            Me.lblId_Credito.TabIndex = 178
            Me.lblId_Credito.Text = "IdCredito"
            '
            'txtNombre
            '
            Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombre.Location = New System.Drawing.Point(66, 88)
            Me.txtNombre.MaxLength = 60
            Me.txtNombre.Name = "txtNombre"
            Me.txtNombre.Size = New System.Drawing.Size(349, 20)
            Me.txtNombre.TabIndex = 0
            '
            'lblNombre
            '
            Me.lblNombre.AutoSize = True
            Me.lblNombre.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombre.Location = New System.Drawing.Point(63, 70)
            Me.lblNombre.Name = "lblNombre"
            Me.lblNombre.Size = New System.Drawing.Size(53, 15)
            Me.lblNombre.TabIndex = 181
            Me.lblNombre.Text = "Nombre"
            '
            'txtCedula
            '
            Me.txtCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCedula.Location = New System.Drawing.Point(418, 88)
            Me.txtCedula.MaxLength = 18
            Me.txtCedula.Name = "txtCedula"
            Me.txtCedula.ReadOnly = True
            Me.txtCedula.Size = New System.Drawing.Size(113, 20)
            Me.txtCedula.TabIndex = 185
            '
            'lblCedula
            '
            Me.lblCedula.AutoSize = True
            Me.lblCedula.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCedula.Location = New System.Drawing.Point(418, 70)
            Me.lblCedula.Name = "lblCedula"
            Me.lblCedula.Size = New System.Drawing.Size(44, 15)
            Me.lblCedula.TabIndex = 188
            Me.lblCedula.Text = "Cédula"
            '
            'lblRecibo
            '
            Me.lblRecibo.AutoSize = True
            Me.lblRecibo.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblRecibo.Location = New System.Drawing.Point(382, 42)
            Me.lblRecibo.Name = "lblRecibo"
            Me.lblRecibo.Size = New System.Drawing.Size(104, 15)
            Me.lblRecibo.TabIndex = 189
            Me.lblRecibo.Text = "Recibo P/Abono #"
            Me.lblRecibo.Visible = False
            '
            'lblMostrarReciboAbonos
            '
            Me.lblMostrarReciboAbonos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarReciboAbonos.Location = New System.Drawing.Point(488, 36)
            Me.lblMostrarReciboAbonos.Name = "lblMostrarReciboAbonos"
            Me.lblMostrarReciboAbonos.Size = New System.Drawing.Size(62, 25)
            Me.lblMostrarReciboAbonos.TabIndex = 191
            Me.lblMostrarReciboAbonos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.lblMostrarReciboAbonos.Visible = False
            '
            'txtNumAbonos
            '
            Me.txtNumAbonos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumAbonos.Location = New System.Drawing.Point(12, 129)
            Me.txtNumAbonos.MaxLength = 5
            Me.txtNumAbonos.Name = "txtNumAbonos"
            Me.txtNumAbonos.ReadOnly = True
            Me.txtNumAbonos.Size = New System.Drawing.Size(49, 20)
            Me.txtNumAbonos.TabIndex = 193
            '
            'lblNumAbonos
            '
            Me.lblNumAbonos.AutoSize = True
            Me.lblNumAbonos.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNumAbonos.Location = New System.Drawing.Point(3, 111)
            Me.lblNumAbonos.Name = "lblNumAbonos"
            Me.lblNumAbonos.Size = New System.Drawing.Size(63, 15)
            Me.lblNumAbonos.TabIndex = 192
            Me.lblNumAbonos.Text = "N° Abonos"
            '
            'txtMontoAbonos
            '
            Me.txtMontoAbonos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMontoAbonos.Location = New System.Drawing.Point(67, 129)
            Me.txtMontoAbonos.MaxLength = 5
            Me.txtMontoAbonos.Name = "txtMontoAbonos"
            Me.txtMontoAbonos.ReadOnly = True
            Me.txtMontoAbonos.Size = New System.Drawing.Size(88, 20)
            Me.txtMontoAbonos.TabIndex = 195
            Me.txtMontoAbonos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblMontoAbonos
            '
            Me.lblMontoAbonos.AutoSize = True
            Me.lblMontoAbonos.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMontoAbonos.Location = New System.Drawing.Point(67, 111)
            Me.lblMontoAbonos.Name = "lblMontoAbonos"
            Me.lblMontoAbonos.Size = New System.Drawing.Size(88, 15)
            Me.lblMontoAbonos.TabIndex = 194
            Me.lblMontoAbonos.Text = "Monto Abonos"
            '
            'txtLimite
            '
            Me.txtLimite.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtLimite.Location = New System.Drawing.Point(310, 130)
            Me.txtLimite.MaxLength = 5
            Me.txtLimite.Name = "txtLimite"
            Me.txtLimite.ReadOnly = True
            Me.txtLimite.Size = New System.Drawing.Size(100, 20)
            Me.txtLimite.TabIndex = 197
            Me.txtLimite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblLimite
            '
            Me.lblLimite.AutoSize = True
            Me.lblLimite.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblLimite.Location = New System.Drawing.Point(311, 112)
            Me.lblLimite.Name = "lblLimite"
            Me.lblLimite.Size = New System.Drawing.Size(42, 15)
            Me.lblLimite.TabIndex = 196
            Me.lblLimite.Text = "Limite"
            '
            'txtTotalAtrasado
            '
            Me.txtTotalAtrasado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalAtrasado.Location = New System.Drawing.Point(413, 130)
            Me.txtTotalAtrasado.MaxLength = 5
            Me.txtTotalAtrasado.Name = "txtTotalAtrasado"
            Me.txtTotalAtrasado.ReadOnly = True
            Me.txtTotalAtrasado.Size = New System.Drawing.Size(110, 20)
            Me.txtTotalAtrasado.TabIndex = 199
            Me.txtTotalAtrasado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblTotalAtrasado
            '
            Me.lblTotalAtrasado.AutoSize = True
            Me.lblTotalAtrasado.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotalAtrasado.Location = New System.Drawing.Point(414, 112)
            Me.lblTotalAtrasado.Name = "lblTotalAtrasado"
            Me.lblTotalAtrasado.Size = New System.Drawing.Size(86, 15)
            Me.lblTotalAtrasado.TabIndex = 198
            Me.lblTotalAtrasado.Text = "Total Atrasado"
            '
            'txtTotalCreditos
            '
            Me.txtTotalCreditos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalCreditos.Location = New System.Drawing.Point(526, 130)
            Me.txtTotalCreditos.MaxLength = 5
            Me.txtTotalCreditos.Name = "txtTotalCreditos"
            Me.txtTotalCreditos.ReadOnly = True
            Me.txtTotalCreditos.Size = New System.Drawing.Size(110, 20)
            Me.txtTotalCreditos.TabIndex = 201
            Me.txtTotalCreditos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblTotalCreditos
            '
            Me.lblTotalCreditos.AutoSize = True
            Me.lblTotalCreditos.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotalCreditos.Location = New System.Drawing.Point(525, 112)
            Me.lblTotalCreditos.Name = "lblTotalCreditos"
            Me.lblTotalCreditos.Size = New System.Drawing.Size(83, 15)
            Me.lblTotalCreditos.TabIndex = 200
            Me.lblTotalCreditos.Text = "Total Creditos"
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
            Me.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvFacturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Tipo2, Me.Doc, Me.Fecha, Me.Monto, Me.MontoAbonos, Me.Plazo, Me.Atraso, Me.VerAbono, Me.VerNC, Me.VerND})
            Me.dgvFacturas.GridColor = System.Drawing.Color.White
            Me.dgvFacturas.Location = New System.Drawing.Point(13, 156)
            Me.dgvFacturas.MultiSelect = False
            Me.dgvFacturas.Name = "dgvFacturas"
            Me.dgvFacturas.ReadOnly = True
            Me.dgvFacturas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle26.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvFacturas.RowHeadersDefaultCellStyle = DataGridViewCellStyle26
            Me.dgvFacturas.RowHeadersVisible = False
            DataGridViewCellStyle27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvFacturas.RowsDefaultCellStyle = DataGridViewCellStyle27
            Me.dgvFacturas.RowTemplate.Height = 18
            Me.dgvFacturas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvFacturas.Size = New System.Drawing.Size(722, 147)
            Me.dgvFacturas.TabIndex = 202
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
            Me.Doc.Width = 70
            '
            'Fecha
            '
            Me.Fecha.HeaderText = "Fecha"
            Me.Fecha.Name = "Fecha"
            Me.Fecha.ReadOnly = True
            Me.Fecha.Width = 70
            '
            'Monto
            '
            DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Monto.DefaultCellStyle = DataGridViewCellStyle19
            Me.Monto.HeaderText = "Total"
            Me.Monto.Name = "Monto"
            Me.Monto.ReadOnly = True
            Me.Monto.Width = 105
            '
            'MontoAbonos
            '
            DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MontoAbonos.DefaultCellStyle = DataGridViewCellStyle20
            Me.MontoAbonos.HeaderText = "Total Neto"
            Me.MontoAbonos.Name = "MontoAbonos"
            Me.MontoAbonos.ReadOnly = True
            Me.MontoAbonos.Width = 105
            '
            'Plazo
            '
            DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Plazo.DefaultCellStyle = DataGridViewCellStyle21
            Me.Plazo.HeaderText = "Plazo"
            Me.Plazo.Name = "Plazo"
            Me.Plazo.ReadOnly = True
            Me.Plazo.Width = 55
            '
            'Atraso
            '
            DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Atraso.DefaultCellStyle = DataGridViewCellStyle22
            Me.Atraso.HeaderText = "Atraso"
            Me.Atraso.Name = "Atraso"
            Me.Atraso.ReadOnly = True
            Me.Atraso.Width = 55
            '
            'VerAbono
            '
            DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.VerAbono.DefaultCellStyle = DataGridViewCellStyle23
            Me.VerAbono.HeaderText = "Abonos"
            Me.VerAbono.Name = "VerAbono"
            Me.VerAbono.ReadOnly = True
            Me.VerAbono.Text = ""
            Me.VerAbono.Width = 65
            '
            'VerNC
            '
            DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.VerNC.DefaultCellStyle = DataGridViewCellStyle24
            Me.VerNC.HeaderText = "NC"
            Me.VerNC.Name = "VerNC"
            Me.VerNC.ReadOnly = True
            Me.VerNC.Width = 65
            '
            'VerND
            '
            DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.VerND.DefaultCellStyle = DataGridViewCellStyle25
            Me.VerND.HeaderText = "ND"
            Me.VerND.Name = "VerND"
            Me.VerND.ReadOnly = True
            Me.VerND.Width = 65
            '
            'btnCargarRecibo
            '
            Me.btnCargarRecibo.Enabled = False
            Me.btnCargarRecibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCargarRecibo.Location = New System.Drawing.Point(131, 308)
            Me.btnCargarRecibo.Name = "btnCargarRecibo"
            Me.btnCargarRecibo.Size = New System.Drawing.Size(161, 23)
            Me.btnCargarRecibo.TabIndex = 205
            Me.btnCargarRecibo.Text = "Abono/Cancelación General"
            Me.btnCargarRecibo.UseVisualStyleBackColor = True
            '
            'txtVuelto
            '
            Me.txtVuelto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtVuelto.Location = New System.Drawing.Point(371, 309)
            Me.txtVuelto.MaxLength = 5
            Me.txtVuelto.Name = "txtVuelto"
            Me.txtVuelto.ReadOnly = True
            Me.txtVuelto.Size = New System.Drawing.Size(100, 20)
            Me.txtVuelto.TabIndex = 207
            Me.txtVuelto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblVuelto
            '
            Me.lblVuelto.AutoSize = True
            Me.lblVuelto.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblVuelto.Location = New System.Drawing.Point(322, 312)
            Me.lblVuelto.Name = "lblVuelto"
            Me.lblVuelto.Size = New System.Drawing.Size(43, 15)
            Me.lblVuelto.TabIndex = 206
            Me.lblVuelto.Text = "Vuelto"
            '
            'btnAbonar
            '
            Me.btnAbonar.Enabled = False
            Me.btnAbonar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAbonar.Location = New System.Drawing.Point(477, 308)
            Me.btnAbonar.Name = "btnAbonar"
            Me.btnAbonar.Size = New System.Drawing.Size(96, 23)
            Me.btnAbonar.TabIndex = 208
            Me.btnAbonar.Text = "Abonar Vuelto?"
            Me.btnAbonar.UseVisualStyleBackColor = True
            '
            'dgvTrans1
            '
            Me.dgvTrans1.AllowUserToAddRows = False
            Me.dgvTrans1.AllowUserToDeleteRows = False
            Me.dgvTrans1.AllowUserToResizeColumns = False
            Me.dgvTrans1.AllowUserToResizeRows = False
            Me.dgvTrans1.BackgroundColor = System.Drawing.Color.White
            Me.dgvTrans1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
            Me.dgvTrans1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvTrans1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Desc1, Me.Documento1, Me.Fecha1, Me.Monto1})
            Me.dgvTrans1.GridColor = System.Drawing.Color.White
            Me.dgvTrans1.Location = New System.Drawing.Point(13, 338)
            Me.dgvTrans1.MultiSelect = False
            Me.dgvTrans1.Name = "dgvTrans1"
            Me.dgvTrans1.ReadOnly = True
            Me.dgvTrans1.RowHeadersVisible = False
            DataGridViewCellStyle30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvTrans1.RowsDefaultCellStyle = DataGridViewCellStyle30
            Me.dgvTrans1.RowTemplate.Height = 18
            Me.dgvTrans1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvTrans1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvTrans1.Size = New System.Drawing.Size(240, 150)
            Me.dgvTrans1.TabIndex = 209
            '
            'Desc1
            '
            DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Desc1.DefaultCellStyle = DataGridViewCellStyle28
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
            Me.Documento1.Width = 52
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
            DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Monto1.DefaultCellStyle = DataGridViewCellStyle29
            Me.Monto1.HeaderText = "Monto"
            Me.Monto1.Name = "Monto1"
            Me.Monto1.ReadOnly = True
            Me.Monto1.Width = 80
            '
            'lblSaldoAnterior
            '
            Me.lblSaldoAnterior.AutoSize = True
            Me.lblSaldoAnterior.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSaldoAnterior.Location = New System.Drawing.Point(272, 506)
            Me.lblSaldoAnterior.Name = "lblSaldoAnterior"
            Me.lblSaldoAnterior.Size = New System.Drawing.Size(119, 19)
            Me.lblSaldoAnterior.TabIndex = 223
            Me.lblSaldoAnterior.Text = "Saldo Anterior ¢"
            '
            'lblAbono
            '
            Me.lblAbono.AutoSize = True
            Me.lblAbono.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblAbono.Location = New System.Drawing.Point(536, 506)
            Me.lblAbono.Name = "lblAbono"
            Me.lblAbono.Size = New System.Drawing.Size(67, 19)
            Me.lblAbono.TabIndex = 224
            Me.lblAbono.Text = "Monto ¢"
            '
            'lblSaldoActual
            '
            Me.lblSaldoActual.AutoSize = True
            Me.lblSaldoActual.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSaldoActual.Location = New System.Drawing.Point(498, 536)
            Me.lblSaldoActual.Name = "lblSaldoActual"
            Me.lblSaldoActual.Size = New System.Drawing.Size(105, 19)
            Me.lblSaldoActual.TabIndex = 225
            Me.lblSaldoActual.Text = "Saldo Actual ¢"
            '
            'lblMostrarAnterior
            '
            Me.lblMostrarAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarAnterior.ForeColor = System.Drawing.Color.Black
            Me.lblMostrarAnterior.Location = New System.Drawing.Point(394, 506)
            Me.lblMostrarAnterior.Name = "lblMostrarAnterior"
            Me.lblMostrarAnterior.Size = New System.Drawing.Size(114, 19)
            Me.lblMostrarAnterior.TabIndex = 226
            Me.lblMostrarAnterior.Text = "0.00"
            Me.lblMostrarAnterior.TextAlign = System.Drawing.ContentAlignment.BottomRight
            '
            'lblMostrarAbono
            '
            Me.lblMostrarAbono.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarAbono.ForeColor = System.Drawing.Color.Red
            Me.lblMostrarAbono.Location = New System.Drawing.Point(598, 506)
            Me.lblMostrarAbono.Name = "lblMostrarAbono"
            Me.lblMostrarAbono.Size = New System.Drawing.Size(126, 19)
            Me.lblMostrarAbono.TabIndex = 227
            Me.lblMostrarAbono.Text = "0.00"
            Me.lblMostrarAbono.TextAlign = System.Drawing.ContentAlignment.BottomRight
            '
            'lblActual
            '
            Me.lblActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblActual.ForeColor = System.Drawing.Color.Red
            Me.lblActual.Location = New System.Drawing.Point(601, 537)
            Me.lblActual.Name = "lblActual"
            Me.lblActual.Size = New System.Drawing.Size(123, 20)
            Me.lblActual.TabIndex = 228
            Me.lblActual.Text = "0.00"
            Me.lblActual.TextAlign = System.Drawing.ContentAlignment.BottomRight
            '
            'btnEjecutar
            '
            Me.btnEjecutar.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEjecutar.Image = Global.Presentacion.My.Resources.Resources.Imprimir
            Me.btnEjecutar.Location = New System.Drawing.Point(0, 0)
            Me.btnEjecutar.Name = "btnEjecutar"
            Me.btnEjecutar.Size = New System.Drawing.Size(65, 57)
            Me.btnEjecutar.TabIndex = 229
            Me.btnEjecutar.Text = "Imprimir"
            Me.btnEjecutar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnEjecutar.UseVisualStyleBackColor = True
            '
            'timerRecibo
            '
            Me.timerRecibo.Enabled = True
            Me.timerRecibo.Interval = 3
            '
            'txtMontoAbono
            '
            Me.txtMontoAbono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMontoAbono.Location = New System.Drawing.Point(13, 310)
            Me.txtMontoAbono.MaxLength = 10
            Me.txtMontoAbono.Name = "txtMontoAbono"
            Me.txtMontoAbono.Size = New System.Drawing.Size(112, 22)
            Me.txtMontoAbono.TabIndex = 243
            Me.txtMontoAbono.Text = "0"
            Me.txtMontoAbono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'dgvTrans2
            '
            Me.dgvTrans2.AllowUserToAddRows = False
            Me.dgvTrans2.AllowUserToDeleteRows = False
            Me.dgvTrans2.AllowUserToResizeColumns = False
            Me.dgvTrans2.AllowUserToResizeRows = False
            Me.dgvTrans2.BackgroundColor = System.Drawing.Color.White
            Me.dgvTrans2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
            Me.dgvTrans2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvTrans2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Fecha2, Me.DataGridViewTextBoxColumn3})
            Me.dgvTrans2.GridColor = System.Drawing.Color.White
            Me.dgvTrans2.Location = New System.Drawing.Point(254, 338)
            Me.dgvTrans2.MultiSelect = False
            Me.dgvTrans2.Name = "dgvTrans2"
            Me.dgvTrans2.ReadOnly = True
            Me.dgvTrans2.RowHeadersVisible = False
            DataGridViewCellStyle33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvTrans2.RowsDefaultCellStyle = DataGridViewCellStyle33
            Me.dgvTrans2.RowTemplate.Height = 18
            Me.dgvTrans2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvTrans2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvTrans2.Size = New System.Drawing.Size(240, 150)
            Me.dgvTrans2.TabIndex = 244
            '
            'DataGridViewTextBoxColumn1
            '
            DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle31
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
            Me.DataGridViewTextBoxColumn2.Width = 52
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
            DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle32
            Me.DataGridViewTextBoxColumn3.HeaderText = "Monto"
            Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
            Me.DataGridViewTextBoxColumn3.ReadOnly = True
            Me.DataGridViewTextBoxColumn3.Width = 80
            '
            'dgvTrans3
            '
            Me.dgvTrans3.AllowUserToAddRows = False
            Me.dgvTrans3.AllowUserToDeleteRows = False
            Me.dgvTrans3.AllowUserToResizeColumns = False
            Me.dgvTrans3.AllowUserToResizeRows = False
            Me.dgvTrans3.BackgroundColor = System.Drawing.Color.White
            Me.dgvTrans3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
            Me.dgvTrans3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvTrans3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.Fecha3, Me.DataGridViewTextBoxColumn6})
            Me.dgvTrans3.GridColor = System.Drawing.Color.White
            Me.dgvTrans3.Location = New System.Drawing.Point(495, 338)
            Me.dgvTrans3.MultiSelect = False
            Me.dgvTrans3.Name = "dgvTrans3"
            Me.dgvTrans3.ReadOnly = True
            Me.dgvTrans3.RowHeadersVisible = False
            DataGridViewCellStyle36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvTrans3.RowsDefaultCellStyle = DataGridViewCellStyle36
            Me.dgvTrans3.RowTemplate.Height = 18
            Me.dgvTrans3.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvTrans3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvTrans3.Size = New System.Drawing.Size(264, 150)
            Me.dgvTrans3.TabIndex = 245
            '
            'DataGridViewTextBoxColumn4
            '
            DataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle34
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
            DataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle35
            Me.DataGridViewTextBoxColumn6.HeaderText = "Monto"
            Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
            Me.DataGridViewTextBoxColumn6.ReadOnly = True
            Me.DataGridViewTextBoxColumn6.Width = 80
            '
            'MnAbonar
            '
            Me.MnAbonar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbonarToolStripMenuItem, Me.NotaCréditoToolStripMenuItem})
            Me.MnAbonar.Name = "MnAbonar"
            Me.MnAbonar.Size = New System.Drawing.Size(143, 48)
            '
            'AbonarToolStripMenuItem
            '
            Me.AbonarToolStripMenuItem.Name = "AbonarToolStripMenuItem"
            Me.AbonarToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
            Me.AbonarToolStripMenuItem.Text = "Abonar"
            '
            'NotaCréditoToolStripMenuItem
            '
            Me.NotaCréditoToolStripMenuItem.Name = "NotaCréditoToolStripMenuItem"
            Me.NotaCréditoToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
            Me.NotaCréditoToolStripMenuItem.Text = "Nota Crédito"
            '
            'lblReciboFacturas
            '
            Me.lblReciboFacturas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblReciboFacturas.Location = New System.Drawing.Point(667, 36)
            Me.lblReciboFacturas.Name = "lblReciboFacturas"
            Me.lblReciboFacturas.Size = New System.Drawing.Size(62, 25)
            Me.lblReciboFacturas.TabIndex = 247
            Me.lblReciboFacturas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblRciboFact
            '
            Me.lblRciboFact.AutoSize = True
            Me.lblRciboFact.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblRciboFact.Location = New System.Drawing.Point(547, 42)
            Me.lblRciboFact.Name = "lblRciboFact"
            Me.lblRciboFact.Size = New System.Drawing.Size(105, 15)
            Me.lblRciboFact.TabIndex = 246
            Me.lblRciboFact.Text = "Recibo P/Dinero #"
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
            Me.dgvClientes.Location = New System.Drawing.Point(67, 109)
            Me.dgvClientes.MultiSelect = False
            Me.dgvClientes.Name = "dgvClientes"
            Me.dgvClientes.ReadOnly = True
            Me.dgvClientes.RowHeadersVisible = False
            Me.dgvClientes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvClientes.Size = New System.Drawing.Size(349, 105)
            Me.dgvClientes.TabIndex = 248
            Me.dgvClientes.Visible = False
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label1.Location = New System.Drawing.Point(12, 491)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(451, 13)
            Me.Label1.TabIndex = 251
            Me.Label1.Text = "* Cancelación (CA), Abono (AB), Nota crédito (NC), Nota crédito General (NCG), No" & _
        "ta débito (ND)"
            '
            'btnEstado
            '
            Me.btnEstado.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEstado.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnEstado.Location = New System.Drawing.Point(64, 0)
            Me.btnEstado.Name = "btnEstado"
            Me.btnEstado.Size = New System.Drawing.Size(65, 57)
            Me.btnEstado.TabIndex = 252
            Me.btnEstado.Text = "Estado Cuenta"
            Me.btnEstado.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnEstado.UseVisualStyleBackColor = True
            '
            'txtMontoNC
            '
            Me.txtMontoNC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMontoNC.Location = New System.Drawing.Point(216, 129)
            Me.txtMontoNC.MaxLength = 5
            Me.txtMontoNC.Name = "txtMontoNC"
            Me.txtMontoNC.ReadOnly = True
            Me.txtMontoNC.Size = New System.Drawing.Size(88, 20)
            Me.txtMontoNC.TabIndex = 256
            Me.txtMontoNC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblMontoNC
            '
            Me.lblMontoNC.AutoSize = True
            Me.lblMontoNC.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMontoNC.Location = New System.Drawing.Point(215, 111)
            Me.lblMontoNC.Name = "lblMontoNC"
            Me.lblMontoNC.Size = New System.Drawing.Size(63, 15)
            Me.lblMontoNC.TabIndex = 255
            Me.lblMontoNC.Text = "Monto NC"
            '
            'txtNumNC
            '
            Me.txtNumNC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumNC.Location = New System.Drawing.Point(161, 129)
            Me.txtNumNC.MaxLength = 5
            Me.txtNumNC.Name = "txtNumNC"
            Me.txtNumNC.ReadOnly = True
            Me.txtNumNC.Size = New System.Drawing.Size(49, 20)
            Me.txtNumNC.TabIndex = 254
            '
            'lblNum_Notas
            '
            Me.lblNum_Notas.AutoSize = True
            Me.lblNum_Notas.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNum_Notas.Location = New System.Drawing.Point(161, 111)
            Me.lblNum_Notas.Name = "lblNum_Notas"
            Me.lblNum_Notas.Size = New System.Drawing.Size(38, 15)
            Me.lblNum_Notas.TabIndex = 253
            Me.lblNum_Notas.Text = "N° NC"
            '
            'notaCredito
            '
            Me.notaCredito.BackColor = System.Drawing.SystemColors.Control
            Me.notaCredito.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.notaCredito.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.notaCredito.Location = New System.Drawing.Point(128, 0)
            Me.notaCredito.Name = "notaCredito"
            Me.notaCredito.Size = New System.Drawing.Size(65, 57)
            Me.notaCredito.TabIndex = 257
            Me.notaCredito.Text = "Nota Crédito General"
            Me.notaCredito.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.notaCredito.UseVisualStyleBackColor = False
            '
            'btnClientes_Credito
            '
            Me.btnClientes_Credito.Image = Global.Presentacion.My.Resources.Resources.e_listados
            Me.btnClientes_Credito.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnClientes_Credito.Location = New System.Drawing.Point(655, 70)
            Me.btnClientes_Credito.Name = "btnClientes_Credito"
            Me.btnClientes_Credito.Size = New System.Drawing.Size(75, 79)
            Me.btnClientes_Credito.TabIndex = 258
            Me.btnClientes_Credito.Text = "Clientes crédito"
            Me.btnClientes_Credito.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnClientes_Credito.UseVisualStyleBackColor = True
            '
            'btnNota_Debito
            '
            Me.btnNota_Debito.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNota_Debito.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnNota_Debito.Location = New System.Drawing.Point(192, 0)
            Me.btnNota_Debito.Name = "btnNota_Debito"
            Me.btnNota_Debito.Size = New System.Drawing.Size(65, 57)
            Me.btnNota_Debito.TabIndex = 259
            Me.btnNota_Debito.Text = "Nota Débito General"
            Me.btnNota_Debito.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnNota_Debito.UseVisualStyleBackColor = True
            '
            'btnDatosCliente
            '
            Me.btnDatosCliente.Location = New System.Drawing.Point(537, 85)
            Me.btnDatosCliente.Name = "btnDatosCliente"
            Me.btnDatosCliente.Size = New System.Drawing.Size(96, 23)
            Me.btnDatosCliente.TabIndex = 260
            Me.btnDatosCliente.Text = "Datos de cliente"
            Me.btnDatosCliente.UseVisualStyleBackColor = True
            '
            'lblMostrarObservaciones
            '
            Me.lblMostrarObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblMostrarObservaciones.Location = New System.Drawing.Point(14, 531)
            Me.lblMostrarObservaciones.Name = "lblMostrarObservaciones"
            Me.lblMostrarObservaciones.Size = New System.Drawing.Size(479, 46)
            Me.lblMostrarObservaciones.TabIndex = 261
            '
            'FrmFacturaCredito
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(771, 583)
            Me.Controls.Add(Me.lblMostrarObservaciones)
            Me.Controls.Add(Me.btnEjecutar)
            Me.Controls.Add(Me.btnDatosCliente)
            Me.Controls.Add(Me.dgvClientes)
            Me.Controls.Add(Me.btnClientes_Credito)
            Me.Controls.Add(Me.txtMontoNC)
            Me.Controls.Add(Me.lblMontoNC)
            Me.Controls.Add(Me.txtNumNC)
            Me.Controls.Add(Me.lblNum_Notas)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.txtMontoAbono)
            Me.Controls.Add(Me.lblReciboFacturas)
            Me.Controls.Add(Me.lblRciboFact)
            Me.Controls.Add(Me.dgvTrans3)
            Me.Controls.Add(Me.dgvTrans2)
            Me.Controls.Add(Me.lblMostrarAnterior)
            Me.Controls.Add(Me.lblActual)
            Me.Controls.Add(Me.lblMostrarAbono)
            Me.Controls.Add(Me.lblAbono)
            Me.Controls.Add(Me.lblSaldoActual)
            Me.Controls.Add(Me.lblSaldoAnterior)
            Me.Controls.Add(Me.dgvTrans1)
            Me.Controls.Add(Me.btnAbonar)
            Me.Controls.Add(Me.btnCargarRecibo)
            Me.Controls.Add(Me.txtVuelto)
            Me.Controls.Add(Me.lblVuelto)
            Me.Controls.Add(Me.lblTotalCreditos)
            Me.Controls.Add(Me.txtMontoAbonos)
            Me.Controls.Add(Me.lblTotalAtrasado)
            Me.Controls.Add(Me.txtLimite)
            Me.Controls.Add(Me.lblLimite)
            Me.Controls.Add(Me.lblMontoAbonos)
            Me.Controls.Add(Me.txtNumAbonos)
            Me.Controls.Add(Me.lblNumAbonos)
            Me.Controls.Add(Me.lblCedula)
            Me.Controls.Add(Me.lblMostrarReciboAbonos)
            Me.Controls.Add(Me.lblRecibo)
            Me.Controls.Add(Me.txtNombre)
            Me.Controls.Add(Me.lblNombre)
            Me.Controls.Add(Me.txtId_Credito)
            Me.Controls.Add(Me.lblId_Credito)
            Me.Controls.Add(Me.dgvFacturas)
            Me.Controls.Add(Me.txtTotalAtrasado)
            Me.Controls.Add(Me.txtTotalCreditos)
            Me.Controls.Add(Me.txtCedula)
            Me.Controls.Add(Me.btnLimpiar)
            Me.Controls.Add(Me.btnEstado)
            Me.Controls.Add(Me.notaCredito)
            Me.Controls.Add(Me.btnNota_Debito)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmFacturaCredito"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Detalle facturas de crédito"
            CType(Me.dgvFacturas, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvTrans1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvTrans2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvTrans3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MnAbonar.ResumeLayout(False)
            CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents btnLimpiar As System.Windows.Forms.Button
        Friend WithEvents txtId_Credito As System.Windows.Forms.TextBox
        Friend WithEvents lblId_Credito As System.Windows.Forms.Label
        Friend WithEvents txtNombre As System.Windows.Forms.TextBox
        Friend WithEvents lblNombre As System.Windows.Forms.Label
        Friend WithEvents txtCedula As System.Windows.Forms.TextBox
        Friend WithEvents lblCedula As System.Windows.Forms.Label
        Friend WithEvents lblRecibo As System.Windows.Forms.Label
        Friend WithEvents lblMostrarReciboAbonos As System.Windows.Forms.Label
        Friend WithEvents txtNumAbonos As System.Windows.Forms.TextBox
        Friend WithEvents lblNumAbonos As System.Windows.Forms.Label
        Friend WithEvents txtMontoAbonos As System.Windows.Forms.TextBox
        Friend WithEvents lblMontoAbonos As System.Windows.Forms.Label
        Friend WithEvents txtLimite As System.Windows.Forms.TextBox
        Friend WithEvents lblLimite As System.Windows.Forms.Label
        Friend WithEvents txtTotalAtrasado As System.Windows.Forms.TextBox
        Friend WithEvents lblTotalAtrasado As System.Windows.Forms.Label
        Friend WithEvents txtTotalCreditos As System.Windows.Forms.TextBox
        Friend WithEvents lblTotalCreditos As System.Windows.Forms.Label
        Friend WithEvents dgvFacturas As System.Windows.Forms.DataGridView
        Friend WithEvents btnCargarRecibo As System.Windows.Forms.Button
        Friend WithEvents txtVuelto As System.Windows.Forms.TextBox
        Friend WithEvents lblVuelto As System.Windows.Forms.Label
        Friend WithEvents btnAbonar As System.Windows.Forms.Button
        Friend WithEvents dgvTrans1 As System.Windows.Forms.DataGridView
        Friend WithEvents lblSaldoAnterior As System.Windows.Forms.Label
        Friend WithEvents lblAbono As System.Windows.Forms.Label
        Friend WithEvents lblSaldoActual As System.Windows.Forms.Label
        Friend WithEvents lblMostrarAnterior As System.Windows.Forms.Label
        Friend WithEvents lblMostrarAbono As System.Windows.Forms.Label
        Friend WithEvents lblActual As System.Windows.Forms.Label
        Friend WithEvents btnEjecutar As System.Windows.Forms.Button
        Friend WithEvents timerRecibo As System.Windows.Forms.Timer
        Friend WithEvents txtMontoAbono As System.Windows.Forms.TextBox
        Friend WithEvents dgvTrans2 As System.Windows.Forms.DataGridView
        Friend WithEvents dgvTrans3 As System.Windows.Forms.DataGridView
        Friend WithEvents MnAbonar As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents AbonarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents lblReciboFacturas As System.Windows.Forms.Label
        Friend WithEvents lblRciboFact As System.Windows.Forms.Label
        Friend WithEvents NotaCréditoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents dgvClientes As System.Windows.Forms.DataGridView
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents btnEstado As System.Windows.Forms.Button
        Friend WithEvents Desc1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Documento1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Fecha1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Monto1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Fecha2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Fecha3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents txtMontoNC As System.Windows.Forms.TextBox
        Friend WithEvents lblMontoNC As System.Windows.Forms.Label
        Friend WithEvents txtNumNC As System.Windows.Forms.TextBox
        Friend WithEvents lblNum_Notas As System.Windows.Forms.Label
        Friend WithEvents notaCredito As System.Windows.Forms.Button
        Friend WithEvents btnClientes_Credito As System.Windows.Forms.Button
        Friend WithEvents Tipo2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Doc As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Monto As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents MontoAbonos As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Plazo As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Atraso As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents VerAbono As System.Windows.Forms.DataGridViewLinkColumn
        Friend WithEvents VerNC As System.Windows.Forms.DataGridViewLinkColumn
        Friend WithEvents VerND As System.Windows.Forms.DataGridViewLinkColumn
        Friend WithEvents btnNota_Debito As System.Windows.Forms.Button
        Friend WithEvents btnDatosCliente As System.Windows.Forms.Button
        Friend WithEvents lblMostrarObservaciones As System.Windows.Forms.Label
    End Class
End Namespace