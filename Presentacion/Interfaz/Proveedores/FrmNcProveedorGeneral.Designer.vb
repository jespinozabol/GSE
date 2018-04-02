Namespace Interfaz.Proveedores
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmNcProveedorGeneral
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
            Me.gbNC1 = New System.Windows.Forms.GroupBox()
            Me.chkPorDescuento = New System.Windows.Forms.CheckBox()
            Me.lblSubTotalEx = New System.Windows.Forms.Label()
            Me.txtSubTotalExN = New System.Windows.Forms.TextBox()
            Me.lblSubTotalIV = New System.Windows.Forms.Label()
            Me.txtSubTotalIVN = New System.Windows.Forms.TextBox()
            Me.txtFechaBoleta = New System.Windows.Forms.TextBox()
            Me.lblFechaBoleta = New System.Windows.Forms.Label()
            Me.txtFechaNota = New System.Windows.Forms.TextBox()
            Me.lblBoleta = New System.Windows.Forms.Label()
            Me.txtBoleta = New System.Windows.Forms.TextBox()
            Me.lblMotivo = New System.Windows.Forms.Label()
            Me.txtMotivo = New System.Windows.Forms.TextBox()
            Me.lblIV = New System.Windows.Forms.Label()
            Me.txtIVNota = New System.Windows.Forms.TextBox()
            Me.lblFechaDoc = New System.Windows.Forms.Label()
            Me.lblTotal = New System.Windows.Forms.Label()
            Me.txtTotalNota = New System.Windows.Forms.TextBox()
            Me.lblNumDoc = New System.Windows.Forms.Label()
            Me.txtNumNota = New System.Windows.Forms.TextBox()
            Me.lblId_Proveedor = New System.Windows.Forms.Label()
            Me.lblNombre = New System.Windows.Forms.Label()
            Me.lblMostrar_Id = New System.Windows.Forms.Label()
            Me.lblMostrarNombre = New System.Windows.Forms.Label()
            Me.btnGuardar = New System.Windows.Forms.Button()
            Me.errorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
            Me.txtId_NCG = New System.Windows.Forms.TextBox()
            Me.gbNC1.SuspendLayout()
            CType(Me.errorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gbNC1
            '
            Me.gbNC1.Controls.Add(Me.chkPorDescuento)
            Me.gbNC1.Controls.Add(Me.lblSubTotalEx)
            Me.gbNC1.Controls.Add(Me.txtSubTotalExN)
            Me.gbNC1.Controls.Add(Me.lblSubTotalIV)
            Me.gbNC1.Controls.Add(Me.txtSubTotalIVN)
            Me.gbNC1.Controls.Add(Me.txtFechaBoleta)
            Me.gbNC1.Controls.Add(Me.lblFechaBoleta)
            Me.gbNC1.Controls.Add(Me.txtFechaNota)
            Me.gbNC1.Controls.Add(Me.lblBoleta)
            Me.gbNC1.Controls.Add(Me.txtBoleta)
            Me.gbNC1.Controls.Add(Me.lblMotivo)
            Me.gbNC1.Controls.Add(Me.txtMotivo)
            Me.gbNC1.Controls.Add(Me.lblIV)
            Me.gbNC1.Controls.Add(Me.txtIVNota)
            Me.gbNC1.Controls.Add(Me.lblFechaDoc)
            Me.gbNC1.Controls.Add(Me.lblTotal)
            Me.gbNC1.Controls.Add(Me.txtTotalNota)
            Me.gbNC1.Controls.Add(Me.lblNumDoc)
            Me.gbNC1.Controls.Add(Me.txtNumNota)
            Me.gbNC1.Location = New System.Drawing.Point(12, 105)
            Me.gbNC1.Name = "gbNC1"
            Me.gbNC1.Size = New System.Drawing.Size(383, 206)
            Me.gbNC1.TabIndex = 0
            Me.gbNC1.TabStop = False
            '
            'chkPorDescuento
            '
            Me.chkPorDescuento.AutoSize = True
            Me.chkPorDescuento.Location = New System.Drawing.Point(135, 10)
            Me.chkPorDescuento.Name = "chkPorDescuento"
            Me.chkPorDescuento.Size = New System.Drawing.Size(97, 17)
            Me.chkPorDescuento.TabIndex = 9
            Me.chkPorDescuento.Text = "Por Descuento"
            Me.chkPorDescuento.UseVisualStyleBackColor = True
            '
            'lblSubTotalEx
            '
            Me.lblSubTotalEx.AutoSize = True
            Me.lblSubTotalEx.BackColor = System.Drawing.Color.Transparent
            Me.lblSubTotalEx.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblSubTotalEx.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubTotalEx.Location = New System.Drawing.Point(110, 91)
            Me.lblSubTotalEx.Name = "lblSubTotalEx"
            Me.lblSubTotalEx.Size = New System.Drawing.Size(82, 15)
            Me.lblSubTotalEx.TabIndex = 98
            Me.lblSubTotalEx.Text = "SubTotal (Ex)"
            '
            'txtSubTotalExN
            '
            Me.txtSubTotalExN.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtSubTotalExN.Enabled = False
            Me.txtSubTotalExN.Location = New System.Drawing.Point(108, 109)
            Me.txtSubTotalExN.MaxLength = 15
            Me.txtSubTotalExN.Name = "txtSubTotalExN"
            Me.txtSubTotalExN.Size = New System.Drawing.Size(87, 20)
            Me.txtSubTotalExN.TabIndex = 5
            Me.txtSubTotalExN.Text = "0"
            Me.txtSubTotalExN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblSubTotalIV
            '
            Me.lblSubTotalIV.AutoSize = True
            Me.lblSubTotalIV.BackColor = System.Drawing.Color.Transparent
            Me.lblSubTotalIV.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblSubTotalIV.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubTotalIV.Location = New System.Drawing.Point(19, 91)
            Me.lblSubTotalIV.Name = "lblSubTotalIV"
            Me.lblSubTotalIV.Size = New System.Drawing.Size(79, 15)
            Me.lblSubTotalIV.TabIndex = 96
            Me.lblSubTotalIV.Text = "SubTotal (IV)"
            '
            'txtSubTotalIVN
            '
            Me.txtSubTotalIVN.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtSubTotalIVN.Enabled = False
            Me.txtSubTotalIVN.Location = New System.Drawing.Point(20, 109)
            Me.txtSubTotalIVN.MaxLength = 15
            Me.txtSubTotalIVN.Name = "txtSubTotalIVN"
            Me.txtSubTotalIVN.Size = New System.Drawing.Size(86, 20)
            Me.txtSubTotalIVN.TabIndex = 4
            Me.txtSubTotalIVN.Text = "0"
            Me.txtSubTotalIVN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtFechaBoleta
            '
            Me.txtFechaBoleta.Location = New System.Drawing.Point(105, 56)
            Me.txtFechaBoleta.MaxLength = 10
            Me.txtFechaBoleta.Name = "txtFechaBoleta"
            Me.txtFechaBoleta.Size = New System.Drawing.Size(78, 20)
            Me.txtFechaBoleta.TabIndex = 1
            '
            'lblFechaBoleta
            '
            Me.lblFechaBoleta.AutoSize = True
            Me.lblFechaBoleta.BackColor = System.Drawing.Color.Transparent
            Me.lblFechaBoleta.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblFechaBoleta.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFechaBoleta.Location = New System.Drawing.Point(105, 39)
            Me.lblFechaBoleta.Name = "lblFechaBoleta"
            Me.lblFechaBoleta.Size = New System.Drawing.Size(78, 15)
            Me.lblFechaBoleta.TabIndex = 91
            Me.lblFechaBoleta.Text = "Fecha Boleta"
            '
            'txtFechaNota
            '
            Me.txtFechaNota.Location = New System.Drawing.Point(277, 56)
            Me.txtFechaNota.MaxLength = 10
            Me.txtFechaNota.Name = "txtFechaNota"
            Me.txtFechaNota.Size = New System.Drawing.Size(78, 20)
            Me.txtFechaNota.TabIndex = 3
            '
            'lblBoleta
            '
            Me.lblBoleta.AutoSize = True
            Me.lblBoleta.BackColor = System.Drawing.Color.Transparent
            Me.lblBoleta.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblBoleta.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblBoleta.Location = New System.Drawing.Point(16, 38)
            Me.lblBoleta.Name = "lblBoleta"
            Me.lblBoleta.Size = New System.Drawing.Size(53, 15)
            Me.lblBoleta.TabIndex = 89
            Me.lblBoleta.Text = "# Boleta"
            '
            'txtBoleta
            '
            Me.txtBoleta.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtBoleta.Location = New System.Drawing.Point(18, 56)
            Me.txtBoleta.MaxLength = 15
            Me.txtBoleta.Name = "txtBoleta"
            Me.txtBoleta.Size = New System.Drawing.Size(76, 20)
            Me.txtBoleta.TabIndex = 0
            Me.txtBoleta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblMotivo
            '
            Me.lblMotivo.AutoSize = True
            Me.lblMotivo.BackColor = System.Drawing.Color.Transparent
            Me.lblMotivo.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblMotivo.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMotivo.Location = New System.Drawing.Point(25, 134)
            Me.lblMotivo.Name = "lblMotivo"
            Me.lblMotivo.Size = New System.Drawing.Size(46, 15)
            Me.lblMotivo.TabIndex = 87
            Me.lblMotivo.Text = "Motivo"
            '
            'txtMotivo
            '
            Me.txtMotivo.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtMotivo.Location = New System.Drawing.Point(21, 151)
            Me.txtMotivo.MaxLength = 235
            Me.txtMotivo.Multiline = True
            Me.txtMotivo.Name = "txtMotivo"
            Me.txtMotivo.Size = New System.Drawing.Size(337, 40)
            Me.txtMotivo.TabIndex = 8
            '
            'lblIV
            '
            Me.lblIV.AutoSize = True
            Me.lblIV.BackColor = System.Drawing.Color.Transparent
            Me.lblIV.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblIV.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIV.Location = New System.Drawing.Point(200, 91)
            Me.lblIV.Name = "lblIV"
            Me.lblIV.Size = New System.Drawing.Size(18, 15)
            Me.lblIV.TabIndex = 85
            Me.lblIV.Text = "IV"
            '
            'txtIVNota
            '
            Me.txtIVNota.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtIVNota.Location = New System.Drawing.Point(197, 109)
            Me.txtIVNota.MaxLength = 15
            Me.txtIVNota.Name = "txtIVNota"
            Me.txtIVNota.Size = New System.Drawing.Size(76, 20)
            Me.txtIVNota.TabIndex = 6
            Me.txtIVNota.Text = "0"
            Me.txtIVNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblFechaDoc
            '
            Me.lblFechaDoc.AutoSize = True
            Me.lblFechaDoc.BackColor = System.Drawing.Color.Transparent
            Me.lblFechaDoc.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblFechaDoc.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFechaDoc.Location = New System.Drawing.Point(274, 39)
            Me.lblFechaDoc.Name = "lblFechaDoc"
            Me.lblFechaDoc.Size = New System.Drawing.Size(39, 15)
            Me.lblFechaDoc.TabIndex = 83
            Me.lblFechaDoc.Text = "Fecha"
            '
            'lblTotal
            '
            Me.lblTotal.AutoSize = True
            Me.lblTotal.BackColor = System.Drawing.Color.Transparent
            Me.lblTotal.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblTotal.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotal.Location = New System.Drawing.Point(277, 91)
            Me.lblTotal.Name = "lblTotal"
            Me.lblTotal.Size = New System.Drawing.Size(34, 15)
            Me.lblTotal.TabIndex = 81
            Me.lblTotal.Text = "Total"
            '
            'txtTotalNota
            '
            Me.txtTotalNota.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtTotalNota.Location = New System.Drawing.Point(275, 109)
            Me.txtTotalNota.MaxLength = 15
            Me.txtTotalNota.Name = "txtTotalNota"
            Me.txtTotalNota.Size = New System.Drawing.Size(83, 20)
            Me.txtTotalNota.TabIndex = 7
            Me.txtTotalNota.Text = "0"
            Me.txtTotalNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblNumDoc
            '
            Me.lblNumDoc.AutoSize = True
            Me.lblNumDoc.BackColor = System.Drawing.Color.Transparent
            Me.lblNumDoc.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblNumDoc.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNumDoc.Location = New System.Drawing.Point(194, 39)
            Me.lblNumDoc.Name = "lblNumDoc"
            Me.lblNumDoc.Size = New System.Drawing.Size(33, 15)
            Me.lblNumDoc.TabIndex = 79
            Me.lblNumDoc.Text = "# NC"
            '
            'txtNumNota
            '
            Me.txtNumNota.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtNumNota.Location = New System.Drawing.Point(197, 56)
            Me.txtNumNota.MaxLength = 15
            Me.txtNumNota.Name = "txtNumNota"
            Me.txtNumNota.Size = New System.Drawing.Size(75, 20)
            Me.txtNumNota.TabIndex = 2
            Me.txtNumNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblId_Proveedor
            '
            Me.lblId_Proveedor.AutoSize = True
            Me.lblId_Proveedor.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblId_Proveedor.Location = New System.Drawing.Point(12, 67)
            Me.lblId_Proveedor.Name = "lblId_Proveedor"
            Me.lblId_Proveedor.Size = New System.Drawing.Size(60, 15)
            Me.lblId_Proveedor.TabIndex = 184
            Me.lblId_Proveedor.Text = "Id Provee"
            '
            'lblNombre
            '
            Me.lblNombre.AutoSize = True
            Me.lblNombre.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombre.Location = New System.Drawing.Point(85, 67)
            Me.lblNombre.Name = "lblNombre"
            Me.lblNombre.Size = New System.Drawing.Size(53, 15)
            Me.lblNombre.TabIndex = 188
            Me.lblNombre.Text = "Nombre"
            '
            'lblMostrar_Id
            '
            Me.lblMostrar_Id.Location = New System.Drawing.Point(15, 89)
            Me.lblMostrar_Id.Name = "lblMostrar_Id"
            Me.lblMostrar_Id.Size = New System.Drawing.Size(56, 23)
            Me.lblMostrar_Id.TabIndex = 189
            Me.lblMostrar_Id.Text = "Label1"
            '
            'lblMostrarNombre
            '
            Me.lblMostrarNombre.Location = New System.Drawing.Point(85, 89)
            Me.lblMostrarNombre.Name = "lblMostrarNombre"
            Me.lblMostrarNombre.Size = New System.Drawing.Size(310, 23)
            Me.lblMostrarNombre.TabIndex = 190
            Me.lblMostrarNombre.Text = "Label1"
            '
            'btnGuardar
            '
            Me.btnGuardar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnGuardar.Location = New System.Drawing.Point(0, 0)
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(68, 57)
            Me.btnGuardar.TabIndex = 191
            Me.btnGuardar.Text = "Insertar"
            Me.btnGuardar.UseVisualStyleBackColor = True
            '
            'errorValidacion
            '
            Me.errorValidacion.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
            Me.errorValidacion.ContainerControl = Me
            '
            'txtId_NCG
            '
            Me.txtId_NCG.Location = New System.Drawing.Point(15, 12)
            Me.txtId_NCG.Name = "txtId_NCG"
            Me.txtId_NCG.Size = New System.Drawing.Size(44, 20)
            Me.txtId_NCG.TabIndex = 192
            Me.txtId_NCG.Visible = False
            '
            'FrmNcProveedorGeneral
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(408, 322)
            Me.Controls.Add(Me.btnGuardar)
            Me.Controls.Add(Me.lblMostrarNombre)
            Me.Controls.Add(Me.lblMostrar_Id)
            Me.Controls.Add(Me.lblNombre)
            Me.Controls.Add(Me.gbNC1)
            Me.Controls.Add(Me.lblId_Proveedor)
            Me.Controls.Add(Me.txtId_NCG)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmNcProveedorGeneral"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "FrmNC_Proveedor_General"
            Me.gbNC1.ResumeLayout(False)
            Me.gbNC1.PerformLayout()
            CType(Me.errorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents gbNC1 As System.Windows.Forms.GroupBox
        Friend WithEvents lblSubTotalEx As System.Windows.Forms.Label
        Friend WithEvents txtSubTotalExN As System.Windows.Forms.TextBox
        Friend WithEvents lblSubTotalIV As System.Windows.Forms.Label
        Friend WithEvents txtSubTotalIVN As System.Windows.Forms.TextBox
        Friend WithEvents txtFechaBoleta As System.Windows.Forms.TextBox
        Friend WithEvents lblFechaBoleta As System.Windows.Forms.Label
        Friend WithEvents txtFechaNota As System.Windows.Forms.TextBox
        Friend WithEvents lblBoleta As System.Windows.Forms.Label
        Friend WithEvents txtBoleta As System.Windows.Forms.TextBox
        Friend WithEvents lblMotivo As System.Windows.Forms.Label
        Friend WithEvents txtMotivo As System.Windows.Forms.TextBox
        Friend WithEvents lblIV As System.Windows.Forms.Label
        Friend WithEvents txtIVNota As System.Windows.Forms.TextBox
        Friend WithEvents lblFechaDoc As System.Windows.Forms.Label
        Friend WithEvents lblTotal As System.Windows.Forms.Label
        Friend WithEvents txtTotalNota As System.Windows.Forms.TextBox
        Friend WithEvents lblNumDoc As System.Windows.Forms.Label
        Friend WithEvents txtNumNota As System.Windows.Forms.TextBox
        Friend WithEvents lblId_Proveedor As System.Windows.Forms.Label
        Friend WithEvents lblNombre As System.Windows.Forms.Label
        Friend WithEvents lblMostrar_Id As System.Windows.Forms.Label
        Friend WithEvents lblMostrarNombre As System.Windows.Forms.Label
        Friend WithEvents chkPorDescuento As System.Windows.Forms.CheckBox
        Friend WithEvents btnGuardar As System.Windows.Forms.Button
        Friend WithEvents errorValidacion As System.Windows.Forms.ErrorProvider
        Friend WithEvents txtId_NCG As System.Windows.Forms.TextBox
    End Class
End Namespace