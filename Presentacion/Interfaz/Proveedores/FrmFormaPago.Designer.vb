Namespace Interfaz.Proveedores
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmFormaPago
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
            Me.txtEfectivo_Dolares = New System.Windows.Forms.TextBox()
            Me.chkDolares = New System.Windows.Forms.CheckBox()
            Me.gbTipo_Cambio = New System.Windows.Forms.GroupBox()
            Me.txtMonto_Dolares = New System.Windows.Forms.TextBox()
            Me.lblMonto = New System.Windows.Forms.Label()
            Me.txtTipo_Cambio = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.chkTransf = New System.Windows.Forms.CheckBox()
            Me.chkCheques = New System.Windows.Forms.CheckBox()
            Me.chkEfectivo = New System.Windows.Forms.CheckBox()
            Me.lblMostrarTotal = New System.Windows.Forms.Label()
            Me.lblTotal = New System.Windows.Forms.Label()
            Me.txtTransferencia = New System.Windows.Forms.TextBox()
            Me.txtCheques = New System.Windows.Forms.TextBox()
            Me.txtEfectivo = New System.Windows.Forms.TextBox()
            Me.btnCancelar = New System.Windows.Forms.Button()
            Me.btnAceptar = New System.Windows.Forms.Button()
            Me.lblFechaCanc = New System.Windows.Forms.Label()
            Me.txtFechaCanc = New System.Windows.Forms.TextBox()
            Me.chkHoy = New System.Windows.Forms.CheckBox()
            Me.txtNum_Recibo = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtFechaRecibo = New System.Windows.Forms.TextBox()
            Me.lblFechaRecibo = New System.Windows.Forms.Label()
            Me.txtObservaciones = New System.Windows.Forms.TextBox()
            Me.lblObservaciones = New System.Windows.Forms.Label()
            Me.gbTipo_Cambio.SuspendLayout()
            Me.SuspendLayout()
            '
            'txtEfectivo_Dolares
            '
            Me.txtEfectivo_Dolares.Enabled = False
            Me.txtEfectivo_Dolares.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtEfectivo_Dolares.Location = New System.Drawing.Point(139, 132)
            Me.txtEfectivo_Dolares.Name = "txtEfectivo_Dolares"
            Me.txtEfectivo_Dolares.Size = New System.Drawing.Size(100, 24)
            Me.txtEfectivo_Dolares.TabIndex = 46
            '
            'chkDolares
            '
            Me.chkDolares.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.chkDolares.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkDolares.Location = New System.Drawing.Point(18, 132)
            Me.chkDolares.Name = "chkDolares"
            Me.chkDolares.Size = New System.Drawing.Size(114, 20)
            Me.chkDolares.TabIndex = 45
            Me.chkDolares.Text = "Pago en Dolar ¢"
            Me.chkDolares.UseVisualStyleBackColor = True
            '
            'gbTipo_Cambio
            '
            Me.gbTipo_Cambio.Controls.Add(Me.txtMonto_Dolares)
            Me.gbTipo_Cambio.Controls.Add(Me.lblMonto)
            Me.gbTipo_Cambio.Controls.Add(Me.txtTipo_Cambio)
            Me.gbTipo_Cambio.Controls.Add(Me.Label1)
            Me.gbTipo_Cambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTipo_Cambio.Location = New System.Drawing.Point(256, 52)
            Me.gbTipo_Cambio.Name = "gbTipo_Cambio"
            Me.gbTipo_Cambio.Size = New System.Drawing.Size(111, 102)
            Me.gbTipo_Cambio.TabIndex = 44
            Me.gbTipo_Cambio.TabStop = False
            Me.gbTipo_Cambio.Visible = False
            '
            'txtMonto_Dolares
            '
            Me.txtMonto_Dolares.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMonto_Dolares.Location = New System.Drawing.Point(11, 71)
            Me.txtMonto_Dolares.Name = "txtMonto_Dolares"
            Me.txtMonto_Dolares.Size = New System.Drawing.Size(81, 24)
            Me.txtMonto_Dolares.TabIndex = 3
            '
            'lblMonto
            '
            Me.lblMonto.AutoSize = True
            Me.lblMonto.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMonto.Location = New System.Drawing.Point(8, 54)
            Me.lblMonto.Name = "lblMonto"
            Me.lblMonto.Size = New System.Drawing.Size(53, 15)
            Me.lblMonto.TabIndex = 2
            Me.lblMonto.Text = "Monto $"
            '
            'txtTipo_Cambio
            '
            Me.txtTipo_Cambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTipo_Cambio.Location = New System.Drawing.Point(9, 31)
            Me.txtTipo_Cambio.Name = "txtTipo_Cambio"
            Me.txtTipo_Cambio.Size = New System.Drawing.Size(81, 24)
            Me.txtTipo_Cambio.TabIndex = 0
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(6, 14)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(94, 15)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Tipo Cambio ¢/$"
            '
            'chkTransf
            '
            Me.chkTransf.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.chkTransf.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkTransf.Location = New System.Drawing.Point(20, 105)
            Me.chkTransf.Name = "chkTransf"
            Me.chkTransf.Size = New System.Drawing.Size(112, 20)
            Me.chkTransf.TabIndex = 41
            Me.chkTransf.Text = "Transferencia ¢"
            Me.chkTransf.UseVisualStyleBackColor = True
            '
            'chkCheques
            '
            Me.chkCheques.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.chkCheques.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkCheques.Location = New System.Drawing.Point(49, 78)
            Me.chkCheques.Name = "chkCheques"
            Me.chkCheques.Size = New System.Drawing.Size(83, 20)
            Me.chkCheques.TabIndex = 40
            Me.chkCheques.Text = "Cheques ¢"
            Me.chkCheques.UseVisualStyleBackColor = True
            '
            'chkEfectivo
            '
            Me.chkEfectivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.chkEfectivo.Checked = True
            Me.chkEfectivo.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkEfectivo.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkEfectivo.Location = New System.Drawing.Point(52, 52)
            Me.chkEfectivo.Name = "chkEfectivo"
            Me.chkEfectivo.Size = New System.Drawing.Size(81, 20)
            Me.chkEfectivo.TabIndex = 38
            Me.chkEfectivo.Text = "Efectivo ¢"
            Me.chkEfectivo.UseVisualStyleBackColor = True
            '
            'lblMostrarTotal
            '
            Me.lblMostrarTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarTotal.ForeColor = System.Drawing.Color.Black
            Me.lblMostrarTotal.Location = New System.Drawing.Point(166, 8)
            Me.lblMostrarTotal.Name = "lblMostrarTotal"
            Me.lblMostrarTotal.Size = New System.Drawing.Size(201, 36)
            Me.lblMostrarTotal.TabIndex = 33
            Me.lblMostrarTotal.Text = "0.00"
            Me.lblMostrarTotal.TextAlign = System.Drawing.ContentAlignment.BottomRight
            '
            'lblTotal
            '
            Me.lblTotal.AutoSize = True
            Me.lblTotal.Font = New System.Drawing.Font("Candara", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotal.Location = New System.Drawing.Point(46, 8)
            Me.lblTotal.Name = "lblTotal"
            Me.lblTotal.Size = New System.Drawing.Size(120, 36)
            Me.lblTotal.TabIndex = 32
            Me.lblTotal.Text = "Monto ¢"
            '
            'txtTransferencia
            '
            Me.txtTransferencia.Enabled = False
            Me.txtTransferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTransferencia.Location = New System.Drawing.Point(139, 105)
            Me.txtTransferencia.Name = "txtTransferencia"
            Me.txtTransferencia.Size = New System.Drawing.Size(100, 24)
            Me.txtTransferencia.TabIndex = 30
            '
            'txtCheques
            '
            Me.txtCheques.Enabled = False
            Me.txtCheques.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCheques.Location = New System.Drawing.Point(139, 78)
            Me.txtCheques.Name = "txtCheques"
            Me.txtCheques.Size = New System.Drawing.Size(100, 24)
            Me.txtCheques.TabIndex = 29
            '
            'txtEfectivo
            '
            Me.txtEfectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtEfectivo.Location = New System.Drawing.Point(139, 52)
            Me.txtEfectivo.Name = "txtEfectivo"
            Me.txtEfectivo.Size = New System.Drawing.Size(100, 24)
            Me.txtEfectivo.TabIndex = 27
            '
            'btnCancelar
            '
            Me.btnCancelar.Image = Global.Presentacion.My.Resources.Resources.Cancelar
            Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnCancelar.Location = New System.Drawing.Point(226, 325)
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.Size = New System.Drawing.Size(75, 46)
            Me.btnCancelar.TabIndex = 37
            Me.btnCancelar.Text = "Cancelar"
            Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnCancelar.UseVisualStyleBackColor = True
            '
            'btnAceptar
            '
            Me.btnAceptar.Image = Global.Presentacion.My.Resources.Resources.aceptar
            Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnAceptar.Location = New System.Drawing.Point(91, 325)
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(75, 46)
            Me.btnAceptar.TabIndex = 31
            Me.btnAceptar.Text = "Aceptar"
            Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnAceptar.UseVisualStyleBackColor = True
            '
            'lblFechaCanc
            '
            Me.lblFechaCanc.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFechaCanc.Location = New System.Drawing.Point(26, 177)
            Me.lblFechaCanc.Name = "lblFechaCanc"
            Me.lblFechaCanc.Size = New System.Drawing.Size(107, 15)
            Me.lblFechaCanc.TabIndex = 47
            Me.lblFechaCanc.Text = "Fecha Cancelación"
            Me.lblFechaCanc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtFechaCanc
            '
            Me.txtFechaCanc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFechaCanc.Location = New System.Drawing.Point(139, 171)
            Me.txtFechaCanc.MaxLength = 10
            Me.txtFechaCanc.Name = "txtFechaCanc"
            Me.txtFechaCanc.Size = New System.Drawing.Size(100, 24)
            Me.txtFechaCanc.TabIndex = 48
            '
            'chkHoy
            '
            Me.chkHoy.AutoSize = True
            Me.chkHoy.Location = New System.Drawing.Point(246, 174)
            Me.chkHoy.Name = "chkHoy"
            Me.chkHoy.Size = New System.Drawing.Size(45, 17)
            Me.chkHoy.TabIndex = 49
            Me.chkHoy.Text = "Hoy"
            Me.chkHoy.UseVisualStyleBackColor = True
            '
            'txtNum_Recibo
            '
            Me.txtNum_Recibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNum_Recibo.Location = New System.Drawing.Point(139, 228)
            Me.txtNum_Recibo.MaxLength = 20
            Me.txtNum_Recibo.Name = "txtNum_Recibo"
            Me.txtNum_Recibo.Size = New System.Drawing.Size(162, 22)
            Me.txtNum_Recibo.TabIndex = 51
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(57, 234)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(75, 15)
            Me.Label2.TabIndex = 50
            Me.Label2.Text = "Num Recibo"
            '
            'txtFechaRecibo
            '
            Me.txtFechaRecibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFechaRecibo.Location = New System.Drawing.Point(139, 201)
            Me.txtFechaRecibo.MaxLength = 10
            Me.txtFechaRecibo.Name = "txtFechaRecibo"
            Me.txtFechaRecibo.Size = New System.Drawing.Size(100, 24)
            Me.txtFechaRecibo.TabIndex = 53
            '
            'lblFechaRecibo
            '
            Me.lblFechaRecibo.AutoSize = True
            Me.lblFechaRecibo.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFechaRecibo.Location = New System.Drawing.Point(53, 206)
            Me.lblFechaRecibo.Name = "lblFechaRecibo"
            Me.lblFechaRecibo.Size = New System.Drawing.Size(80, 15)
            Me.lblFechaRecibo.TabIndex = 52
            Me.lblFechaRecibo.Text = "Fecha Recibo"
            '
            'txtObservaciones
            '
            Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtObservaciones.Location = New System.Drawing.Point(139, 257)
            Me.txtObservaciones.MaxLength = 200
            Me.txtObservaciones.Multiline = True
            Me.txtObservaciones.Name = "txtObservaciones"
            Me.txtObservaciones.Size = New System.Drawing.Size(228, 62)
            Me.txtObservaciones.TabIndex = 302
            '
            'lblObservaciones
            '
            Me.lblObservaciones.AutoSize = True
            Me.lblObservaciones.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblObservaciones.Location = New System.Drawing.Point(43, 261)
            Me.lblObservaciones.Name = "lblObservaciones"
            Me.lblObservaciones.Size = New System.Drawing.Size(87, 15)
            Me.lblObservaciones.TabIndex = 301
            Me.lblObservaciones.Text = "Observaciones"
            '
            'FrmFormaPago
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(383, 374)
            Me.Controls.Add(Me.txtObservaciones)
            Me.Controls.Add(Me.lblObservaciones)
            Me.Controls.Add(Me.txtFechaRecibo)
            Me.Controls.Add(Me.lblFechaRecibo)
            Me.Controls.Add(Me.txtNum_Recibo)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.chkHoy)
            Me.Controls.Add(Me.txtFechaCanc)
            Me.Controls.Add(Me.lblFechaCanc)
            Me.Controls.Add(Me.txtEfectivo_Dolares)
            Me.Controls.Add(Me.chkDolares)
            Me.Controls.Add(Me.gbTipo_Cambio)
            Me.Controls.Add(Me.chkTransf)
            Me.Controls.Add(Me.chkCheques)
            Me.Controls.Add(Me.chkEfectivo)
            Me.Controls.Add(Me.btnCancelar)
            Me.Controls.Add(Me.btnAceptar)
            Me.Controls.Add(Me.lblMostrarTotal)
            Me.Controls.Add(Me.lblTotal)
            Me.Controls.Add(Me.txtTransferencia)
            Me.Controls.Add(Me.txtCheques)
            Me.Controls.Add(Me.txtEfectivo)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmFormaPago"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Forma de Pago"
            Me.gbTipo_Cambio.ResumeLayout(False)
            Me.gbTipo_Cambio.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents txtEfectivo_Dolares As System.Windows.Forms.TextBox
        Friend WithEvents chkDolares As System.Windows.Forms.CheckBox
        Friend WithEvents gbTipo_Cambio As System.Windows.Forms.GroupBox
        Friend WithEvents txtMonto_Dolares As System.Windows.Forms.TextBox
        Friend WithEvents lblMonto As System.Windows.Forms.Label
        Friend WithEvents txtTipo_Cambio As System.Windows.Forms.TextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents chkTransf As System.Windows.Forms.CheckBox
        Friend WithEvents chkCheques As System.Windows.Forms.CheckBox
        Friend WithEvents chkEfectivo As System.Windows.Forms.CheckBox
        Friend WithEvents btnCancelar As System.Windows.Forms.Button
        Friend WithEvents btnAceptar As System.Windows.Forms.Button
        Friend WithEvents lblMostrarTotal As System.Windows.Forms.Label
        Friend WithEvents lblTotal As System.Windows.Forms.Label
        Friend WithEvents txtTransferencia As System.Windows.Forms.TextBox
        Friend WithEvents txtCheques As System.Windows.Forms.TextBox
        Friend WithEvents txtEfectivo As System.Windows.Forms.TextBox
        Friend WithEvents lblFechaCanc As System.Windows.Forms.Label
        Friend WithEvents txtFechaCanc As System.Windows.Forms.TextBox
        Friend WithEvents chkHoy As System.Windows.Forms.CheckBox
        Friend WithEvents txtNum_Recibo As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtFechaRecibo As System.Windows.Forms.TextBox
        Friend WithEvents lblFechaRecibo As System.Windows.Forms.Label
        Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
        Friend WithEvents lblObservaciones As System.Windows.Forms.Label
    End Class
End Namespace