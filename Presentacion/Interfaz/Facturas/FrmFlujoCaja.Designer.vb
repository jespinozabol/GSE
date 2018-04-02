Namespace Interfaz.Facturas
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmFlujoCaja
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
            Me.txtEfectivo = New System.Windows.Forms.TextBox()
            Me.txtTarjetas = New System.Windows.Forms.TextBox()
            Me.txtCheques = New System.Windows.Forms.TextBox()
            Me.txtTransferencia = New System.Windows.Forms.TextBox()
            Me.lblTotal = New System.Windows.Forms.Label()
            Me.lblMostrarTotal = New System.Windows.Forms.Label()
            Me.lblVuelto = New System.Windows.Forms.Label()
            Me.lblMostrarVuelto = New System.Windows.Forms.Label()
            Me.btnAceptar = New System.Windows.Forms.Button()
            Me.lbl1 = New System.Windows.Forms.Label()
            Me.btnCancelar = New System.Windows.Forms.Button()
            Me.chkEfectivo = New System.Windows.Forms.CheckBox()
            Me.chkTarjetas = New System.Windows.Forms.CheckBox()
            Me.chkCheques = New System.Windows.Forms.CheckBox()
            Me.chkTransf = New System.Windows.Forms.CheckBox()
            Me.lblRedondeo = New System.Windows.Forms.Label()
            Me.lblMostrar_Redondeo = New System.Windows.Forms.Label()
            Me.gbTipo_Cambio = New System.Windows.Forms.GroupBox()
            Me.txtMonto_Dolares = New System.Windows.Forms.TextBox()
            Me.lblMonto = New System.Windows.Forms.Label()
            Me.txtTipo_Cambio = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.chkDolares = New System.Windows.Forms.CheckBox()
            Me.txtEfectivo_Dolares = New System.Windows.Forms.TextBox()
            Me.lblMonto_Redondeo = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.chkForzarCero = New System.Windows.Forms.CheckBox()
            Me.txtForzar = New System.Windows.Forms.TextBox()
            Me.gbTipo_Cambio.SuspendLayout()
            Me.SuspendLayout()
            '
            'txtEfectivo
            '
            Me.txtEfectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtEfectivo.Location = New System.Drawing.Point(131, 86)
            Me.txtEfectivo.Name = "txtEfectivo"
            Me.txtEfectivo.Size = New System.Drawing.Size(100, 24)
            Me.txtEfectivo.TabIndex = 0
            '
            'txtTarjetas
            '
            Me.txtTarjetas.Enabled = False
            Me.txtTarjetas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTarjetas.Location = New System.Drawing.Point(131, 113)
            Me.txtTarjetas.Name = "txtTarjetas"
            Me.txtTarjetas.Size = New System.Drawing.Size(100, 24)
            Me.txtTarjetas.TabIndex = 1
            '
            'txtCheques
            '
            Me.txtCheques.Enabled = False
            Me.txtCheques.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCheques.Location = New System.Drawing.Point(131, 140)
            Me.txtCheques.Name = "txtCheques"
            Me.txtCheques.Size = New System.Drawing.Size(100, 24)
            Me.txtCheques.TabIndex = 2
            '
            'txtTransferencia
            '
            Me.txtTransferencia.Enabled = False
            Me.txtTransferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTransferencia.Location = New System.Drawing.Point(131, 167)
            Me.txtTransferencia.Name = "txtTransferencia"
            Me.txtTransferencia.Size = New System.Drawing.Size(100, 24)
            Me.txtTransferencia.TabIndex = 3
            '
            'lblTotal
            '
            Me.lblTotal.AutoSize = True
            Me.lblTotal.Font = New System.Drawing.Font("Candara", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotal.Location = New System.Drawing.Point(4, 9)
            Me.lblTotal.Name = "lblTotal"
            Me.lblTotal.Size = New System.Drawing.Size(161, 36)
            Me.lblTotal.TabIndex = 8
            Me.lblTotal.Text = "Facturado ¢"
            '
            'lblMostrarTotal
            '
            Me.lblMostrarTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarTotal.ForeColor = System.Drawing.Color.Black
            Me.lblMostrarTotal.Location = New System.Drawing.Point(158, 8)
            Me.lblMostrarTotal.Name = "lblMostrarTotal"
            Me.lblMostrarTotal.Size = New System.Drawing.Size(201, 36)
            Me.lblMostrarTotal.TabIndex = 9
            Me.lblMostrarTotal.Text = "0.00"
            Me.lblMostrarTotal.TextAlign = System.Drawing.ContentAlignment.BottomRight
            '
            'lblVuelto
            '
            Me.lblVuelto.AutoSize = True
            Me.lblVuelto.Font = New System.Drawing.Font("Candara", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblVuelto.Location = New System.Drawing.Point(43, 243)
            Me.lblVuelto.Name = "lblVuelto"
            Me.lblVuelto.Size = New System.Drawing.Size(118, 36)
            Me.lblVuelto.TabIndex = 10
            Me.lblVuelto.Text = "Vuelto ¢"
            '
            'lblMostrarVuelto
            '
            Me.lblMostrarVuelto.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarVuelto.ForeColor = System.Drawing.Color.Black
            Me.lblMostrarVuelto.Location = New System.Drawing.Point(158, 240)
            Me.lblMostrarVuelto.Name = "lblMostrarVuelto"
            Me.lblMostrarVuelto.Size = New System.Drawing.Size(201, 36)
            Me.lblMostrarVuelto.TabIndex = 11
            Me.lblMostrarVuelto.Text = "0.00"
            Me.lblMostrarVuelto.TextAlign = System.Drawing.ContentAlignment.BottomRight
            '
            'btnAceptar
            '
            Me.btnAceptar.Image = Global.Presentacion.My.Resources.Resources.aceptar
            Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnAceptar.Location = New System.Drawing.Point(81, 314)
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(75, 46)
            Me.btnAceptar.TabIndex = 4
            Me.btnAceptar.Text = "Aceptar"
            Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnAceptar.UseVisualStyleBackColor = True
            '
            'lbl1
            '
            Me.lbl1.AutoSize = True
            Me.lbl1.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbl1.ForeColor = System.Drawing.Color.Red
            Me.lbl1.Location = New System.Drawing.Point(18, 253)
            Me.lbl1.Name = "lbl1"
            Me.lbl1.Size = New System.Drawing.Size(307, 23)
            Me.lbl1.TabIndex = 12
            Me.lbl1.Text = "Está reintegrando dinero a un cliente"
            Me.lbl1.Visible = False
            '
            'btnCancelar
            '
            Me.btnCancelar.Image = Global.Presentacion.My.Resources.Resources.Cancelar
            Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnCancelar.Location = New System.Drawing.Point(220, 314)
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.Size = New System.Drawing.Size(75, 46)
            Me.btnCancelar.TabIndex = 13
            Me.btnCancelar.Text = "Cancelar"
            Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnCancelar.UseVisualStyleBackColor = True
            '
            'chkEfectivo
            '
            Me.chkEfectivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.chkEfectivo.Checked = True
            Me.chkEfectivo.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkEfectivo.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkEfectivo.Location = New System.Drawing.Point(44, 86)
            Me.chkEfectivo.Name = "chkEfectivo"
            Me.chkEfectivo.Size = New System.Drawing.Size(81, 20)
            Me.chkEfectivo.TabIndex = 14
            Me.chkEfectivo.Text = "Efectivo ¢"
            Me.chkEfectivo.UseVisualStyleBackColor = True
            '
            'chkTarjetas
            '
            Me.chkTarjetas.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.chkTarjetas.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkTarjetas.Location = New System.Drawing.Point(44, 113)
            Me.chkTarjetas.Name = "chkTarjetas"
            Me.chkTarjetas.Size = New System.Drawing.Size(81, 20)
            Me.chkTarjetas.TabIndex = 15
            Me.chkTarjetas.Text = "Tarjetas ¢"
            Me.chkTarjetas.UseVisualStyleBackColor = True
            '
            'chkCheques
            '
            Me.chkCheques.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.chkCheques.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkCheques.Location = New System.Drawing.Point(41, 140)
            Me.chkCheques.Name = "chkCheques"
            Me.chkCheques.Size = New System.Drawing.Size(83, 20)
            Me.chkCheques.TabIndex = 16
            Me.chkCheques.Text = "Cheques ¢"
            Me.chkCheques.UseVisualStyleBackColor = True
            '
            'chkTransf
            '
            Me.chkTransf.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.chkTransf.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkTransf.Location = New System.Drawing.Point(12, 167)
            Me.chkTransf.Name = "chkTransf"
            Me.chkTransf.Size = New System.Drawing.Size(112, 20)
            Me.chkTransf.TabIndex = 17
            Me.chkTransf.Text = "Transferencia ¢"
            Me.chkTransf.UseVisualStyleBackColor = True
            '
            'lblRedondeo
            '
            Me.lblRedondeo.AutoSize = True
            Me.lblRedondeo.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblRedondeo.Location = New System.Drawing.Point(51, 222)
            Me.lblRedondeo.Name = "lblRedondeo"
            Me.lblRedondeo.Size = New System.Drawing.Size(68, 15)
            Me.lblRedondeo.TabIndex = 18
            Me.lblRedondeo.Text = "Sobrante ¢"
            '
            'lblMostrar_Redondeo
            '
            Me.lblMostrar_Redondeo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrar_Redondeo.Location = New System.Drawing.Point(131, 222)
            Me.lblMostrar_Redondeo.Name = "lblMostrar_Redondeo"
            Me.lblMostrar_Redondeo.Size = New System.Drawing.Size(100, 19)
            Me.lblMostrar_Redondeo.TabIndex = 19
            Me.lblMostrar_Redondeo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'gbTipo_Cambio
            '
            Me.gbTipo_Cambio.Controls.Add(Me.txtMonto_Dolares)
            Me.gbTipo_Cambio.Controls.Add(Me.lblMonto)
            Me.gbTipo_Cambio.Controls.Add(Me.txtTipo_Cambio)
            Me.gbTipo_Cambio.Controls.Add(Me.Label1)
            Me.gbTipo_Cambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTipo_Cambio.Location = New System.Drawing.Point(248, 86)
            Me.gbTipo_Cambio.Name = "gbTipo_Cambio"
            Me.gbTipo_Cambio.Size = New System.Drawing.Size(111, 102)
            Me.gbTipo_Cambio.TabIndex = 20
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
            'chkDolares
            '
            Me.chkDolares.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.chkDolares.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkDolares.Location = New System.Drawing.Point(10, 194)
            Me.chkDolares.Name = "chkDolares"
            Me.chkDolares.Size = New System.Drawing.Size(114, 20)
            Me.chkDolares.TabIndex = 21
            Me.chkDolares.Text = "Pago en Dolar ¢"
            Me.chkDolares.UseVisualStyleBackColor = True
            '
            'txtEfectivo_Dolares
            '
            Me.txtEfectivo_Dolares.Enabled = False
            Me.txtEfectivo_Dolares.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtEfectivo_Dolares.Location = New System.Drawing.Point(131, 194)
            Me.txtEfectivo_Dolares.Name = "txtEfectivo_Dolares"
            Me.txtEfectivo_Dolares.Size = New System.Drawing.Size(100, 24)
            Me.txtEfectivo_Dolares.TabIndex = 22
            '
            'lblMonto_Redondeo
            '
            Me.lblMonto_Redondeo.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMonto_Redondeo.ForeColor = System.Drawing.Color.Black
            Me.lblMonto_Redondeo.Location = New System.Drawing.Point(158, 47)
            Me.lblMonto_Redondeo.Name = "lblMonto_Redondeo"
            Me.lblMonto_Redondeo.Size = New System.Drawing.Size(201, 36)
            Me.lblMonto_Redondeo.TabIndex = 24
            Me.lblMonto_Redondeo.Text = "0.00"
            Me.lblMonto_Redondeo.TextAlign = System.Drawing.ContentAlignment.BottomRight
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Candara", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(4, 48)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(163, 36)
            Me.Label3.TabIndex = 23
            Me.Label3.Text = "Redondeo ¢"
            '
            'chkForzarCero
            '
            Me.chkForzarCero.AutoSize = True
            Me.chkForzarCero.Location = New System.Drawing.Point(54, 282)
            Me.chkForzarCero.Name = "chkForzarCero"
            Me.chkForzarCero.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.chkForzarCero.Size = New System.Drawing.Size(67, 17)
            Me.chkForzarCero.TabIndex = 25
            Me.chkForzarCero.Text = "Forzar a "
            Me.chkForzarCero.UseVisualStyleBackColor = True
            '
            'txtForzar
            '
            Me.txtForzar.Enabled = False
            Me.txtForzar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtForzar.Location = New System.Drawing.Point(130, 279)
            Me.txtForzar.Name = "txtForzar"
            Me.txtForzar.Size = New System.Drawing.Size(100, 24)
            Me.txtForzar.TabIndex = 26
            '
            'FrmFlujoCaja
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(371, 370)
            Me.ControlBox = False
            Me.Controls.Add(Me.txtForzar)
            Me.Controls.Add(Me.chkForzarCero)
            Me.Controls.Add(Me.lblMonto_Redondeo)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.txtEfectivo_Dolares)
            Me.Controls.Add(Me.chkDolares)
            Me.Controls.Add(Me.gbTipo_Cambio)
            Me.Controls.Add(Me.lblMostrar_Redondeo)
            Me.Controls.Add(Me.lblRedondeo)
            Me.Controls.Add(Me.chkTransf)
            Me.Controls.Add(Me.chkCheques)
            Me.Controls.Add(Me.chkTarjetas)
            Me.Controls.Add(Me.chkEfectivo)
            Me.Controls.Add(Me.btnCancelar)
            Me.Controls.Add(Me.btnAceptar)
            Me.Controls.Add(Me.lblVuelto)
            Me.Controls.Add(Me.lblMostrarTotal)
            Me.Controls.Add(Me.lblTotal)
            Me.Controls.Add(Me.txtTransferencia)
            Me.Controls.Add(Me.txtCheques)
            Me.Controls.Add(Me.txtTarjetas)
            Me.Controls.Add(Me.txtEfectivo)
            Me.Controls.Add(Me.lblMostrarVuelto)
            Me.Controls.Add(Me.lbl1)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmFlujoCaja"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Flujo de Caja"
            Me.gbTipo_Cambio.ResumeLayout(False)
            Me.gbTipo_Cambio.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents txtEfectivo As System.Windows.Forms.TextBox
        Friend WithEvents txtTarjetas As System.Windows.Forms.TextBox
        Friend WithEvents txtCheques As System.Windows.Forms.TextBox
        Friend WithEvents txtTransferencia As System.Windows.Forms.TextBox
        Friend WithEvents lblTotal As System.Windows.Forms.Label
        Friend WithEvents lblMostrarTotal As System.Windows.Forms.Label
        Friend WithEvents lblVuelto As System.Windows.Forms.Label
        Friend WithEvents lblMostrarVuelto As System.Windows.Forms.Label
        Friend WithEvents btnAceptar As System.Windows.Forms.Button
        Friend WithEvents lbl1 As System.Windows.Forms.Label
        Friend WithEvents btnCancelar As System.Windows.Forms.Button
        Friend WithEvents chkEfectivo As System.Windows.Forms.CheckBox
        Friend WithEvents chkTarjetas As System.Windows.Forms.CheckBox
        Friend WithEvents chkCheques As System.Windows.Forms.CheckBox
        Friend WithEvents chkTransf As System.Windows.Forms.CheckBox
        Friend WithEvents lblRedondeo As System.Windows.Forms.Label
        Friend WithEvents lblMostrar_Redondeo As System.Windows.Forms.Label
        Friend WithEvents gbTipo_Cambio As System.Windows.Forms.GroupBox
        Friend WithEvents chkDolares As System.Windows.Forms.CheckBox
        Friend WithEvents txtMonto_Dolares As System.Windows.Forms.TextBox
        Friend WithEvents lblMonto As System.Windows.Forms.Label
        Friend WithEvents txtTipo_Cambio As System.Windows.Forms.TextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtEfectivo_Dolares As System.Windows.Forms.TextBox
        Friend WithEvents lblMonto_Redondeo As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents chkForzarCero As System.Windows.Forms.CheckBox
        Friend WithEvents txtForzar As System.Windows.Forms.TextBox
    End Class
End Namespace