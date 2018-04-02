Namespace Interfaz.Mantenimiento
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmAnular
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
            Me.tabRecibos = New System.Windows.Forms.TabPage()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtObserva_Recibo = New System.Windows.Forms.TextBox()
            Me.txtMonto_Recibo = New System.Windows.Forms.TextBox()
            Me.txtFecha_Recibo = New System.Windows.Forms.TextBox()
            Me.txtNum_Recibo = New System.Windows.Forms.TextBox()
            Me.txtCliente_Recibo = New System.Windows.Forms.TextBox()
            Me.lblObservaciones = New System.Windows.Forms.Label()
            Me.lblMonto = New System.Windows.Forms.Label()
            Me.lblFecha = New System.Windows.Forms.Label()
            Me.lblNum_Recibo = New System.Windows.Forms.Label()
            Me.lblCliente = New System.Windows.Forms.Label()
            Me.btnAnularRecibos = New System.Windows.Forms.Button()
            Me.tabNC_General = New System.Windows.Forms.TabPage()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtMotivoNC_General = New System.Windows.Forms.TextBox()
            Me.txtMontoNC_General = New System.Windows.Forms.TextBox()
            Me.txtFechaNC_General = New System.Windows.Forms.TextBox()
            Me.txtIdNC_General = New System.Windows.Forms.TextBox()
            Me.txtCliente_General = New System.Windows.Forms.TextBox()
            Me.lblMotivoNC_General = New System.Windows.Forms.Label()
            Me.lblMontoNC_General = New System.Windows.Forms.Label()
            Me.lblFecha_General = New System.Windows.Forms.Label()
            Me.lblNC_General = New System.Windows.Forms.Label()
            Me.lblClienteNC_General = New System.Windows.Forms.Label()
            Me.btnAnularNC_General = New System.Windows.Forms.Button()
            Me.tabNC = New System.Windows.Forms.TabPage()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtCliente_NC = New System.Windows.Forms.TextBox()
            Me.txtMontoNC = New System.Windows.Forms.TextBox()
            Me.txtFechaNC = New System.Windows.Forms.TextBox()
            Me.txtId_NC = New System.Windows.Forms.TextBox()
            Me.txtNum_FacturaNC = New System.Windows.Forms.TextBox()
            Me.lblCliente_NC = New System.Windows.Forms.Label()
            Me.lblMontoNC = New System.Windows.Forms.Label()
            Me.lblFechaNC = New System.Windows.Forms.Label()
            Me.lblId_NC = New System.Windows.Forms.Label()
            Me.lblNum_FacturaNC = New System.Windows.Forms.Label()
            Me.btnAnularNC = New System.Windows.Forms.Button()
            Me.tabFactura = New System.Windows.Forms.TabPage()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.btnAnularFact = New System.Windows.Forms.Button()
            Me.txtNumFactura = New System.Windows.Forms.TextBox()
            Me.txtNombre = New System.Windows.Forms.TextBox()
            Me.lblNumFactura = New System.Windows.Forms.Label()
            Me.lblNombre = New System.Windows.Forms.Label()
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.TabND_General = New System.Windows.Forms.TabPage()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtMotivoND_General = New System.Windows.Forms.TextBox()
            Me.txtMontoND_General = New System.Windows.Forms.TextBox()
            Me.txtFechaND_General = New System.Windows.Forms.TextBox()
            Me.txtNumND_General = New System.Windows.Forms.TextBox()
            Me.txtClientND_General = New System.Windows.Forms.TextBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.btnAnularNDGeneral = New System.Windows.Forms.Button()
            Me.tabRecibos.SuspendLayout()
            Me.tabNC_General.SuspendLayout()
            Me.tabNC.SuspendLayout()
            Me.tabFactura.SuspendLayout()
            Me.TabControl1.SuspendLayout()
            Me.TabND_General.SuspendLayout()
            Me.SuspendLayout()
            '
            'tabRecibos
            '
            Me.tabRecibos.BackColor = System.Drawing.SystemColors.Control
            Me.tabRecibos.Controls.Add(Me.Label5)
            Me.tabRecibos.Controls.Add(Me.txtObserva_Recibo)
            Me.tabRecibos.Controls.Add(Me.txtMonto_Recibo)
            Me.tabRecibos.Controls.Add(Me.txtFecha_Recibo)
            Me.tabRecibos.Controls.Add(Me.txtNum_Recibo)
            Me.tabRecibos.Controls.Add(Me.txtCliente_Recibo)
            Me.tabRecibos.Controls.Add(Me.lblObservaciones)
            Me.tabRecibos.Controls.Add(Me.lblMonto)
            Me.tabRecibos.Controls.Add(Me.lblFecha)
            Me.tabRecibos.Controls.Add(Me.lblNum_Recibo)
            Me.tabRecibos.Controls.Add(Me.lblCliente)
            Me.tabRecibos.Controls.Add(Me.btnAnularRecibos)
            Me.tabRecibos.Location = New System.Drawing.Point(4, 24)
            Me.tabRecibos.Name = "tabRecibos"
            Me.tabRecibos.Padding = New System.Windows.Forms.Padding(3)
            Me.tabRecibos.Size = New System.Drawing.Size(441, 230)
            Me.tabRecibos.TabIndex = 4
            Me.tabRecibos.Text = "Recibos P/Dinero"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.ForeColor = System.Drawing.Color.Green
            Me.Label5.Location = New System.Drawing.Point(175, 21)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(185, 26)
            Me.Label5.TabIndex = 84
            Me.Label5.Text = "Recibos por dinero"
            '
            'txtObserva_Recibo
            '
            Me.txtObserva_Recibo.Enabled = False
            Me.txtObserva_Recibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtObserva_Recibo.Location = New System.Drawing.Point(12, 172)
            Me.txtObserva_Recibo.Multiline = True
            Me.txtObserva_Recibo.Name = "txtObserva_Recibo"
            Me.txtObserva_Recibo.Size = New System.Drawing.Size(286, 48)
            Me.txtObserva_Recibo.TabIndex = 83
            '
            'txtMonto_Recibo
            '
            Me.txtMonto_Recibo.Enabled = False
            Me.txtMonto_Recibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMonto_Recibo.Location = New System.Drawing.Point(152, 79)
            Me.txtMonto_Recibo.Name = "txtMonto_Recibo"
            Me.txtMonto_Recibo.Size = New System.Drawing.Size(100, 21)
            Me.txtMonto_Recibo.TabIndex = 81
            Me.txtMonto_Recibo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtFecha_Recibo
            '
            Me.txtFecha_Recibo.Enabled = False
            Me.txtFecha_Recibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFecha_Recibo.Location = New System.Drawing.Point(70, 79)
            Me.txtFecha_Recibo.Name = "txtFecha_Recibo"
            Me.txtFecha_Recibo.Size = New System.Drawing.Size(76, 21)
            Me.txtFecha_Recibo.TabIndex = 79
            '
            'txtNum_Recibo
            '
            Me.txtNum_Recibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNum_Recibo.Location = New System.Drawing.Point(12, 79)
            Me.txtNum_Recibo.MaxLength = 10
            Me.txtNum_Recibo.Name = "txtNum_Recibo"
            Me.txtNum_Recibo.Size = New System.Drawing.Size(54, 21)
            Me.txtNum_Recibo.TabIndex = 0
            '
            'txtCliente_Recibo
            '
            Me.txtCliente_Recibo.Enabled = False
            Me.txtCliente_Recibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCliente_Recibo.Location = New System.Drawing.Point(12, 122)
            Me.txtCliente_Recibo.Name = "txtCliente_Recibo"
            Me.txtCliente_Recibo.Size = New System.Drawing.Size(286, 21)
            Me.txtCliente_Recibo.TabIndex = 77
            '
            'lblObservaciones
            '
            Me.lblObservaciones.AutoSize = True
            Me.lblObservaciones.Location = New System.Drawing.Point(9, 153)
            Me.lblObservaciones.Name = "lblObservaciones"
            Me.lblObservaciones.Size = New System.Drawing.Size(87, 15)
            Me.lblObservaciones.TabIndex = 82
            Me.lblObservaciones.Text = "Observaciones"
            '
            'lblMonto
            '
            Me.lblMonto.AutoSize = True
            Me.lblMonto.Location = New System.Drawing.Point(149, 60)
            Me.lblMonto.Name = "lblMonto"
            Me.lblMonto.Size = New System.Drawing.Size(44, 15)
            Me.lblMonto.TabIndex = 80
            Me.lblMonto.Text = "Monto"
            '
            'lblFecha
            '
            Me.lblFecha.AutoSize = True
            Me.lblFecha.Location = New System.Drawing.Point(67, 60)
            Me.lblFecha.Name = "lblFecha"
            Me.lblFecha.Size = New System.Drawing.Size(39, 15)
            Me.lblFecha.TabIndex = 78
            Me.lblFecha.Text = "Fecha"
            '
            'lblNum_Recibo
            '
            Me.lblNum_Recibo.AutoSize = True
            Me.lblNum_Recibo.Location = New System.Drawing.Point(8, 60)
            Me.lblNum_Recibo.Name = "lblNum_Recibo"
            Me.lblNum_Recibo.Size = New System.Drawing.Size(60, 15)
            Me.lblNum_Recibo.TabIndex = 75
            Me.lblNum_Recibo.Text = "N° Recibo"
            '
            'lblCliente
            '
            Me.lblCliente.AutoSize = True
            Me.lblCliente.Location = New System.Drawing.Point(9, 103)
            Me.lblCliente.Name = "lblCliente"
            Me.lblCliente.Size = New System.Drawing.Size(46, 15)
            Me.lblCliente.TabIndex = 76
            Me.lblCliente.Text = "Cliente"
            '
            'btnAnularRecibos
            '
            Me.btnAnularRecibos.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnAnularRecibos.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAnularRecibos.Image = Global.Presentacion.My.Resources.Resources.cancela
            Me.btnAnularRecibos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnAnularRecibos.Location = New System.Drawing.Point(0, 0)
            Me.btnAnularRecibos.Name = "btnAnularRecibos"
            Me.btnAnularRecibos.Size = New System.Drawing.Size(71, 57)
            Me.btnAnularRecibos.TabIndex = 73
            Me.btnAnularRecibos.Text = "Anular"
            Me.btnAnularRecibos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnAnularRecibos.UseVisualStyleBackColor = True
            '
            'tabNC_General
            '
            Me.tabNC_General.BackColor = System.Drawing.SystemColors.Control
            Me.tabNC_General.Controls.Add(Me.Label1)
            Me.tabNC_General.Controls.Add(Me.txtMotivoNC_General)
            Me.tabNC_General.Controls.Add(Me.txtMontoNC_General)
            Me.tabNC_General.Controls.Add(Me.txtFechaNC_General)
            Me.tabNC_General.Controls.Add(Me.txtIdNC_General)
            Me.tabNC_General.Controls.Add(Me.txtCliente_General)
            Me.tabNC_General.Controls.Add(Me.lblMotivoNC_General)
            Me.tabNC_General.Controls.Add(Me.lblMontoNC_General)
            Me.tabNC_General.Controls.Add(Me.lblFecha_General)
            Me.tabNC_General.Controls.Add(Me.lblNC_General)
            Me.tabNC_General.Controls.Add(Me.lblClienteNC_General)
            Me.tabNC_General.Controls.Add(Me.btnAnularNC_General)
            Me.tabNC_General.Location = New System.Drawing.Point(4, 24)
            Me.tabNC_General.Name = "tabNC_General"
            Me.tabNC_General.Size = New System.Drawing.Size(441, 230)
            Me.tabNC_General.TabIndex = 3
            Me.tabNC_General.Text = "NC General"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.Green
            Me.Label1.Location = New System.Drawing.Point(175, 21)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(177, 26)
            Me.Label1.TabIndex = 71
            Me.Label1.Text = "Anular NC General"
            '
            'txtMotivoNC_General
            '
            Me.txtMotivoNC_General.Enabled = False
            Me.txtMotivoNC_General.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMotivoNC_General.Location = New System.Drawing.Point(12, 172)
            Me.txtMotivoNC_General.Multiline = True
            Me.txtMotivoNC_General.Name = "txtMotivoNC_General"
            Me.txtMotivoNC_General.Size = New System.Drawing.Size(286, 48)
            Me.txtMotivoNC_General.TabIndex = 70
            '
            'txtMontoNC_General
            '
            Me.txtMontoNC_General.Enabled = False
            Me.txtMontoNC_General.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMontoNC_General.Location = New System.Drawing.Point(152, 79)
            Me.txtMontoNC_General.Name = "txtMontoNC_General"
            Me.txtMontoNC_General.Size = New System.Drawing.Size(100, 21)
            Me.txtMontoNC_General.TabIndex = 68
            Me.txtMontoNC_General.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtFechaNC_General
            '
            Me.txtFechaNC_General.Enabled = False
            Me.txtFechaNC_General.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFechaNC_General.Location = New System.Drawing.Point(70, 79)
            Me.txtFechaNC_General.Name = "txtFechaNC_General"
            Me.txtFechaNC_General.Size = New System.Drawing.Size(76, 21)
            Me.txtFechaNC_General.TabIndex = 66
            '
            'txtIdNC_General
            '
            Me.txtIdNC_General.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdNC_General.Location = New System.Drawing.Point(12, 79)
            Me.txtIdNC_General.MaxLength = 10
            Me.txtIdNC_General.Name = "txtIdNC_General"
            Me.txtIdNC_General.Size = New System.Drawing.Size(54, 21)
            Me.txtIdNC_General.TabIndex = 0
            '
            'txtCliente_General
            '
            Me.txtCliente_General.Enabled = False
            Me.txtCliente_General.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCliente_General.Location = New System.Drawing.Point(12, 122)
            Me.txtCliente_General.Name = "txtCliente_General"
            Me.txtCliente_General.Size = New System.Drawing.Size(286, 21)
            Me.txtCliente_General.TabIndex = 64
            '
            'lblMotivoNC_General
            '
            Me.lblMotivoNC_General.AutoSize = True
            Me.lblMotivoNC_General.Location = New System.Drawing.Point(9, 153)
            Me.lblMotivoNC_General.Name = "lblMotivoNC_General"
            Me.lblMotivoNC_General.Size = New System.Drawing.Size(46, 15)
            Me.lblMotivoNC_General.TabIndex = 69
            Me.lblMotivoNC_General.Text = "Motivo"
            '
            'lblMontoNC_General
            '
            Me.lblMontoNC_General.AutoSize = True
            Me.lblMontoNC_General.Location = New System.Drawing.Point(149, 60)
            Me.lblMontoNC_General.Name = "lblMontoNC_General"
            Me.lblMontoNC_General.Size = New System.Drawing.Size(44, 15)
            Me.lblMontoNC_General.TabIndex = 67
            Me.lblMontoNC_General.Text = "Monto"
            '
            'lblFecha_General
            '
            Me.lblFecha_General.AutoSize = True
            Me.lblFecha_General.Location = New System.Drawing.Point(67, 60)
            Me.lblFecha_General.Name = "lblFecha_General"
            Me.lblFecha_General.Size = New System.Drawing.Size(39, 15)
            Me.lblFecha_General.TabIndex = 65
            Me.lblFecha_General.Text = "Fecha"
            '
            'lblNC_General
            '
            Me.lblNC_General.AutoSize = True
            Me.lblNC_General.Location = New System.Drawing.Point(8, 60)
            Me.lblNC_General.Name = "lblNC_General"
            Me.lblNC_General.Size = New System.Drawing.Size(38, 15)
            Me.lblNC_General.TabIndex = 62
            Me.lblNC_General.Text = "N° NC"
            '
            'lblClienteNC_General
            '
            Me.lblClienteNC_General.AutoSize = True
            Me.lblClienteNC_General.Location = New System.Drawing.Point(9, 103)
            Me.lblClienteNC_General.Name = "lblClienteNC_General"
            Me.lblClienteNC_General.Size = New System.Drawing.Size(46, 15)
            Me.lblClienteNC_General.TabIndex = 63
            Me.lblClienteNC_General.Text = "Cliente"
            '
            'btnAnularNC_General
            '
            Me.btnAnularNC_General.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnAnularNC_General.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAnularNC_General.Image = Global.Presentacion.My.Resources.Resources.cancela
            Me.btnAnularNC_General.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnAnularNC_General.Location = New System.Drawing.Point(0, 0)
            Me.btnAnularNC_General.Name = "btnAnularNC_General"
            Me.btnAnularNC_General.Size = New System.Drawing.Size(71, 57)
            Me.btnAnularNC_General.TabIndex = 60
            Me.btnAnularNC_General.Text = "Anular"
            Me.btnAnularNC_General.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnAnularNC_General.UseVisualStyleBackColor = True
            '
            'tabNC
            '
            Me.tabNC.BackColor = System.Drawing.SystemColors.Control
            Me.tabNC.Controls.Add(Me.Label4)
            Me.tabNC.Controls.Add(Me.txtCliente_NC)
            Me.tabNC.Controls.Add(Me.txtMontoNC)
            Me.tabNC.Controls.Add(Me.txtFechaNC)
            Me.tabNC.Controls.Add(Me.txtId_NC)
            Me.tabNC.Controls.Add(Me.txtNum_FacturaNC)
            Me.tabNC.Controls.Add(Me.lblCliente_NC)
            Me.tabNC.Controls.Add(Me.lblMontoNC)
            Me.tabNC.Controls.Add(Me.lblFechaNC)
            Me.tabNC.Controls.Add(Me.lblId_NC)
            Me.tabNC.Controls.Add(Me.lblNum_FacturaNC)
            Me.tabNC.Controls.Add(Me.btnAnularNC)
            Me.tabNC.Location = New System.Drawing.Point(4, 24)
            Me.tabNC.Name = "tabNC"
            Me.tabNC.Padding = New System.Windows.Forms.Padding(3)
            Me.tabNC.Size = New System.Drawing.Size(441, 230)
            Me.tabNC.TabIndex = 2
            Me.tabNC.Text = "Nota Crédito"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.ForeColor = System.Drawing.Color.Green
            Me.Label4.Location = New System.Drawing.Point(157, 18)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(193, 26)
            Me.Label4.TabIndex = 72
            Me.Label4.Text = "Anular Nota Crédito"
            '
            'txtCliente_NC
            '
            Me.txtCliente_NC.Enabled = False
            Me.txtCliente_NC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCliente_NC.Location = New System.Drawing.Point(11, 131)
            Me.txtCliente_NC.Name = "txtCliente_NC"
            Me.txtCliente_NC.Size = New System.Drawing.Size(303, 21)
            Me.txtCliente_NC.TabIndex = 68
            '
            'txtMontoNC
            '
            Me.txtMontoNC.Enabled = False
            Me.txtMontoNC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMontoNC.Location = New System.Drawing.Point(214, 79)
            Me.txtMontoNC.Name = "txtMontoNC"
            Me.txtMontoNC.Size = New System.Drawing.Size(100, 21)
            Me.txtMontoNC.TabIndex = 66
            Me.txtMontoNC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtFechaNC
            '
            Me.txtFechaNC.Enabled = False
            Me.txtFechaNC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFechaNC.Location = New System.Drawing.Point(136, 79)
            Me.txtFechaNC.Name = "txtFechaNC"
            Me.txtFechaNC.Size = New System.Drawing.Size(72, 21)
            Me.txtFechaNC.TabIndex = 64
            '
            'txtId_NC
            '
            Me.txtId_NC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtId_NC.Location = New System.Drawing.Point(12, 79)
            Me.txtId_NC.MaxLength = 10
            Me.txtId_NC.Name = "txtId_NC"
            Me.txtId_NC.Size = New System.Drawing.Size(54, 21)
            Me.txtId_NC.TabIndex = 0
            '
            'txtNum_FacturaNC
            '
            Me.txtNum_FacturaNC.Enabled = False
            Me.txtNum_FacturaNC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNum_FacturaNC.Location = New System.Drawing.Point(70, 79)
            Me.txtNum_FacturaNC.Name = "txtNum_FacturaNC"
            Me.txtNum_FacturaNC.Size = New System.Drawing.Size(60, 21)
            Me.txtNum_FacturaNC.TabIndex = 62
            '
            'lblCliente_NC
            '
            Me.lblCliente_NC.AutoSize = True
            Me.lblCliente_NC.Location = New System.Drawing.Point(8, 112)
            Me.lblCliente_NC.Name = "lblCliente_NC"
            Me.lblCliente_NC.Size = New System.Drawing.Size(46, 15)
            Me.lblCliente_NC.TabIndex = 67
            Me.lblCliente_NC.Text = "Cliente"
            '
            'lblMontoNC
            '
            Me.lblMontoNC.AutoSize = True
            Me.lblMontoNC.Location = New System.Drawing.Point(211, 60)
            Me.lblMontoNC.Name = "lblMontoNC"
            Me.lblMontoNC.Size = New System.Drawing.Size(44, 15)
            Me.lblMontoNC.TabIndex = 65
            Me.lblMontoNC.Text = "Monto"
            '
            'lblFechaNC
            '
            Me.lblFechaNC.AutoSize = True
            Me.lblFechaNC.Location = New System.Drawing.Point(139, 60)
            Me.lblFechaNC.Name = "lblFechaNC"
            Me.lblFechaNC.Size = New System.Drawing.Size(39, 15)
            Me.lblFechaNC.TabIndex = 63
            Me.lblFechaNC.Text = "Fecha"
            '
            'lblId_NC
            '
            Me.lblId_NC.AutoSize = True
            Me.lblId_NC.Location = New System.Drawing.Point(8, 60)
            Me.lblId_NC.Name = "lblId_NC"
            Me.lblId_NC.Size = New System.Drawing.Size(38, 15)
            Me.lblId_NC.TabIndex = 60
            Me.lblId_NC.Text = "N° NC"
            '
            'lblNum_FacturaNC
            '
            Me.lblNum_FacturaNC.AutoSize = True
            Me.lblNum_FacturaNC.Location = New System.Drawing.Point(67, 60)
            Me.lblNum_FacturaNC.Name = "lblNum_FacturaNC"
            Me.lblNum_FacturaNC.Size = New System.Drawing.Size(63, 15)
            Me.lblNum_FacturaNC.TabIndex = 61
            Me.lblNum_FacturaNC.Text = "N° Factura"
            '
            'btnAnularNC
            '
            Me.btnAnularNC.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnAnularNC.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAnularNC.Image = Global.Presentacion.My.Resources.Resources.cancela
            Me.btnAnularNC.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnAnularNC.Location = New System.Drawing.Point(0, 0)
            Me.btnAnularNC.Name = "btnAnularNC"
            Me.btnAnularNC.Size = New System.Drawing.Size(71, 57)
            Me.btnAnularNC.TabIndex = 58
            Me.btnAnularNC.Text = "Anular"
            Me.btnAnularNC.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnAnularNC.UseVisualStyleBackColor = True
            '
            'tabFactura
            '
            Me.tabFactura.BackColor = System.Drawing.SystemColors.Control
            Me.tabFactura.Controls.Add(Me.Label2)
            Me.tabFactura.Controls.Add(Me.btnAnularFact)
            Me.tabFactura.Controls.Add(Me.txtNumFactura)
            Me.tabFactura.Controls.Add(Me.txtNombre)
            Me.tabFactura.Controls.Add(Me.lblNumFactura)
            Me.tabFactura.Controls.Add(Me.lblNombre)
            Me.tabFactura.Location = New System.Drawing.Point(4, 24)
            Me.tabFactura.Margin = New System.Windows.Forms.Padding(0)
            Me.tabFactura.Name = "tabFactura"
            Me.tabFactura.Size = New System.Drawing.Size(441, 230)
            Me.tabFactura.TabIndex = 0
            Me.tabFactura.Text = "Factura"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.Green
            Me.Label2.Location = New System.Drawing.Point(186, 20)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(142, 26)
            Me.Label2.TabIndex = 72
            Me.Label2.Text = "Anular Factura"
            '
            'btnAnularFact
            '
            Me.btnAnularFact.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnAnularFact.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAnularFact.Image = Global.Presentacion.My.Resources.Resources.cancela
            Me.btnAnularFact.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnAnularFact.Location = New System.Drawing.Point(0, 0)
            Me.btnAnularFact.Name = "btnAnularFact"
            Me.btnAnularFact.Size = New System.Drawing.Size(71, 57)
            Me.btnAnularFact.TabIndex = 44
            Me.btnAnularFact.Text = "Anular"
            Me.btnAnularFact.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnAnularFact.UseVisualStyleBackColor = True
            '
            'txtNumFactura
            '
            Me.txtNumFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumFactura.Location = New System.Drawing.Point(8, 88)
            Me.txtNumFactura.MaxLength = 10
            Me.txtNumFactura.Name = "txtNumFactura"
            Me.txtNumFactura.Size = New System.Drawing.Size(68, 21)
            Me.txtNumFactura.TabIndex = 0
            '
            'txtNombre
            '
            Me.txtNombre.Enabled = False
            Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombre.Location = New System.Drawing.Point(81, 88)
            Me.txtNombre.Name = "txtNombre"
            Me.txtNombre.Size = New System.Drawing.Size(279, 21)
            Me.txtNombre.TabIndex = 48
            '
            'lblNumFactura
            '
            Me.lblNumFactura.AutoSize = True
            Me.lblNumFactura.Location = New System.Drawing.Point(4, 69)
            Me.lblNumFactura.Name = "lblNumFactura"
            Me.lblNumFactura.Size = New System.Drawing.Size(48, 15)
            Me.lblNumFactura.TabIndex = 45
            Me.lblNumFactura.Text = "Factura"
            '
            'lblNombre
            '
            Me.lblNombre.AutoSize = True
            Me.lblNombre.Location = New System.Drawing.Point(75, 69)
            Me.lblNombre.Name = "lblNombre"
            Me.lblNombre.Size = New System.Drawing.Size(115, 15)
            Me.lblNombre.TabIndex = 46
            Me.lblNombre.Text = "Nombre del Cliente"
            '
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.tabFactura)
            Me.TabControl1.Controls.Add(Me.tabNC)
            Me.TabControl1.Controls.Add(Me.tabNC_General)
            Me.TabControl1.Controls.Add(Me.TabND_General)
            Me.TabControl1.Controls.Add(Me.tabRecibos)
            Me.TabControl1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TabControl1.Location = New System.Drawing.Point(0, 0)
            Me.TabControl1.Margin = New System.Windows.Forms.Padding(0)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(449, 258)
            Me.TabControl1.TabIndex = 0
            '
            'TabND_General
            '
            Me.TabND_General.Controls.Add(Me.Label3)
            Me.TabND_General.Controls.Add(Me.txtMotivoND_General)
            Me.TabND_General.Controls.Add(Me.txtMontoND_General)
            Me.TabND_General.Controls.Add(Me.txtFechaND_General)
            Me.TabND_General.Controls.Add(Me.txtNumND_General)
            Me.TabND_General.Controls.Add(Me.txtClientND_General)
            Me.TabND_General.Controls.Add(Me.Label6)
            Me.TabND_General.Controls.Add(Me.Label7)
            Me.TabND_General.Controls.Add(Me.Label8)
            Me.TabND_General.Controls.Add(Me.Label9)
            Me.TabND_General.Controls.Add(Me.Label10)
            Me.TabND_General.Controls.Add(Me.btnAnularNDGeneral)
            Me.TabND_General.Location = New System.Drawing.Point(4, 24)
            Me.TabND_General.Name = "TabND_General"
            Me.TabND_General.Padding = New System.Windows.Forms.Padding(3)
            Me.TabND_General.Size = New System.Drawing.Size(441, 230)
            Me.TabND_General.TabIndex = 5
            Me.TabND_General.Text = "ND General"
            Me.TabND_General.UseVisualStyleBackColor = True
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.Green
            Me.Label3.Location = New System.Drawing.Point(177, 23)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(179, 26)
            Me.Label3.TabIndex = 84
            Me.Label3.Text = "Anular ND General"
            '
            'txtMotivoND_General
            '
            Me.txtMotivoND_General.Enabled = False
            Me.txtMotivoND_General.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMotivoND_General.Location = New System.Drawing.Point(14, 174)
            Me.txtMotivoND_General.Multiline = True
            Me.txtMotivoND_General.Name = "txtMotivoND_General"
            Me.txtMotivoND_General.Size = New System.Drawing.Size(286, 48)
            Me.txtMotivoND_General.TabIndex = 83
            '
            'txtMontoND_General
            '
            Me.txtMontoND_General.Enabled = False
            Me.txtMontoND_General.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMontoND_General.Location = New System.Drawing.Point(154, 81)
            Me.txtMontoND_General.Name = "txtMontoND_General"
            Me.txtMontoND_General.Size = New System.Drawing.Size(100, 21)
            Me.txtMontoND_General.TabIndex = 81
            Me.txtMontoND_General.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtFechaND_General
            '
            Me.txtFechaND_General.Enabled = False
            Me.txtFechaND_General.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFechaND_General.Location = New System.Drawing.Point(72, 81)
            Me.txtFechaND_General.Name = "txtFechaND_General"
            Me.txtFechaND_General.Size = New System.Drawing.Size(76, 21)
            Me.txtFechaND_General.TabIndex = 79
            '
            'txtNumND_General
            '
            Me.txtNumND_General.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumND_General.Location = New System.Drawing.Point(14, 81)
            Me.txtNumND_General.MaxLength = 10
            Me.txtNumND_General.Name = "txtNumND_General"
            Me.txtNumND_General.Size = New System.Drawing.Size(54, 21)
            Me.txtNumND_General.TabIndex = 72
            '
            'txtClientND_General
            '
            Me.txtClientND_General.Enabled = False
            Me.txtClientND_General.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtClientND_General.Location = New System.Drawing.Point(14, 124)
            Me.txtClientND_General.Name = "txtClientND_General"
            Me.txtClientND_General.Size = New System.Drawing.Size(286, 21)
            Me.txtClientND_General.TabIndex = 77
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(11, 155)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(46, 15)
            Me.Label6.TabIndex = 82
            Me.Label6.Text = "Motivo"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(151, 62)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(44, 15)
            Me.Label7.TabIndex = 80
            Me.Label7.Text = "Monto"
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(69, 62)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(39, 15)
            Me.Label8.TabIndex = 78
            Me.Label8.Text = "Fecha"
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(10, 62)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(39, 15)
            Me.Label9.TabIndex = 75
            Me.Label9.Text = "N° ND"
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(11, 105)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(46, 15)
            Me.Label10.TabIndex = 76
            Me.Label10.Text = "Cliente"
            '
            'btnAnularNDGeneral
            '
            Me.btnAnularNDGeneral.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnAnularNDGeneral.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAnularNDGeneral.Image = Global.Presentacion.My.Resources.Resources.cancela
            Me.btnAnularNDGeneral.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnAnularNDGeneral.Location = New System.Drawing.Point(2, 2)
            Me.btnAnularNDGeneral.Name = "btnAnularNDGeneral"
            Me.btnAnularNDGeneral.Size = New System.Drawing.Size(71, 57)
            Me.btnAnularNDGeneral.TabIndex = 74
            Me.btnAnularNDGeneral.Text = "Anular"
            Me.btnAnularNDGeneral.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnAnularNDGeneral.UseVisualStyleBackColor = True
            '
            'FrmAnular
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(448, 256)
            Me.Controls.Add(Me.TabControl1)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmAnular"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Anular Documentos"
            Me.tabRecibos.ResumeLayout(False)
            Me.tabRecibos.PerformLayout()
            Me.tabNC_General.ResumeLayout(False)
            Me.tabNC_General.PerformLayout()
            Me.tabNC.ResumeLayout(False)
            Me.tabNC.PerformLayout()
            Me.tabFactura.ResumeLayout(False)
            Me.tabFactura.PerformLayout()
            Me.TabControl1.ResumeLayout(False)
            Me.TabND_General.ResumeLayout(False)
            Me.TabND_General.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents tabRecibos As System.Windows.Forms.TabPage
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents txtObserva_Recibo As System.Windows.Forms.TextBox
        Friend WithEvents txtMonto_Recibo As System.Windows.Forms.TextBox
        Friend WithEvents txtFecha_Recibo As System.Windows.Forms.TextBox
        Friend WithEvents txtNum_Recibo As System.Windows.Forms.TextBox
        Friend WithEvents txtCliente_Recibo As System.Windows.Forms.TextBox
        Friend WithEvents lblObservaciones As System.Windows.Forms.Label
        Friend WithEvents lblMonto As System.Windows.Forms.Label
        Friend WithEvents lblFecha As System.Windows.Forms.Label
        Friend WithEvents lblNum_Recibo As System.Windows.Forms.Label
        Friend WithEvents lblCliente As System.Windows.Forms.Label
        Friend WithEvents btnAnularRecibos As System.Windows.Forms.Button
        Friend WithEvents tabNC_General As System.Windows.Forms.TabPage
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtMotivoNC_General As System.Windows.Forms.TextBox
        Friend WithEvents txtMontoNC_General As System.Windows.Forms.TextBox
        Friend WithEvents txtFechaNC_General As System.Windows.Forms.TextBox
        Friend WithEvents txtIdNC_General As System.Windows.Forms.TextBox
        Friend WithEvents txtCliente_General As System.Windows.Forms.TextBox
        Friend WithEvents lblMotivoNC_General As System.Windows.Forms.Label
        Friend WithEvents lblMontoNC_General As System.Windows.Forms.Label
        Friend WithEvents lblFecha_General As System.Windows.Forms.Label
        Friend WithEvents lblNC_General As System.Windows.Forms.Label
        Friend WithEvents lblClienteNC_General As System.Windows.Forms.Label
        Friend WithEvents btnAnularNC_General As System.Windows.Forms.Button
        Friend WithEvents tabNC As System.Windows.Forms.TabPage
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtCliente_NC As System.Windows.Forms.TextBox
        Friend WithEvents txtMontoNC As System.Windows.Forms.TextBox
        Friend WithEvents txtFechaNC As System.Windows.Forms.TextBox
        Friend WithEvents txtId_NC As System.Windows.Forms.TextBox
        Friend WithEvents txtNum_FacturaNC As System.Windows.Forms.TextBox
        Friend WithEvents lblCliente_NC As System.Windows.Forms.Label
        Friend WithEvents lblMontoNC As System.Windows.Forms.Label
        Friend WithEvents lblFechaNC As System.Windows.Forms.Label
        Friend WithEvents lblId_NC As System.Windows.Forms.Label
        Friend WithEvents lblNum_FacturaNC As System.Windows.Forms.Label
        Friend WithEvents btnAnularNC As System.Windows.Forms.Button
        Friend WithEvents tabFactura As System.Windows.Forms.TabPage
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents btnAnularFact As System.Windows.Forms.Button
        Friend WithEvents txtNumFactura As System.Windows.Forms.TextBox
        Friend WithEvents txtNombre As System.Windows.Forms.TextBox
        Friend WithEvents lblNumFactura As System.Windows.Forms.Label
        Friend WithEvents lblNombre As System.Windows.Forms.Label
        Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
        Friend WithEvents TabND_General As System.Windows.Forms.TabPage
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtMotivoND_General As System.Windows.Forms.TextBox
        Friend WithEvents txtMontoND_General As System.Windows.Forms.TextBox
        Friend WithEvents txtFechaND_General As System.Windows.Forms.TextBox
        Friend WithEvents txtNumND_General As System.Windows.Forms.TextBox
        Friend WithEvents txtClientND_General As System.Windows.Forms.TextBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents btnAnularNDGeneral As System.Windows.Forms.Button
    End Class
End Namespace