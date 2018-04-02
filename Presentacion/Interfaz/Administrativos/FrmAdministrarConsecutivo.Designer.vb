Namespace Interfaz.Administrativos
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmAdministrarConsecutivo
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
            Me.lbl1 = New System.Windows.Forms.Label()
            Me.btnGuardar = New System.Windows.Forms.Button()
            Me.gbNumFactura = New System.Windows.Forms.GroupBox()
            Me.chkBloq_Facturas = New System.Windows.Forms.CheckBox()
            Me.txtCon_Factura = New System.Windows.Forms.TextBox()
            Me.lblCons_Factura = New System.Windows.Forms.Label()
            Me.gbAbonos = New System.Windows.Forms.GroupBox()
            Me.chkBloq_Abonos = New System.Windows.Forms.CheckBox()
            Me.txtCons_Abonos = New System.Windows.Forms.TextBox()
            Me.lblCons_Abonos = New System.Windows.Forms.Label()
            Me.gbNotas_Credito = New System.Windows.Forms.GroupBox()
            Me.chkBloq_NC = New System.Windows.Forms.CheckBox()
            Me.txtCons_NC = New System.Windows.Forms.TextBox()
            Me.lblCons_NC = New System.Windows.Forms.Label()
            Me.gbProformas = New System.Windows.Forms.GroupBox()
            Me.chkBloq_Proforma = New System.Windows.Forms.CheckBox()
            Me.txtCons_Proforma = New System.Windows.Forms.TextBox()
            Me.lblCons_Proforma = New System.Windows.Forms.Label()
            Me.gbRecibos = New System.Windows.Forms.GroupBox()
            Me.chkBloq_Recibo = New System.Windows.Forms.CheckBox()
            Me.txtCons_Recibo = New System.Windows.Forms.TextBox()
            Me.lblCons_Recibo = New System.Windows.Forms.Label()
            Me.btnRecargar = New System.Windows.Forms.Button()
            Me.gbNumFactura.SuspendLayout()
            Me.gbAbonos.SuspendLayout()
            Me.gbNotas_Credito.SuspendLayout()
            Me.gbProformas.SuspendLayout()
            Me.gbRecibos.SuspendLayout()
            Me.SuspendLayout()
            '
            'lbl1
            '
            Me.lbl1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbl1.Location = New System.Drawing.Point(227, 9)
            Me.lbl1.Name = "lbl1"
            Me.lbl1.Size = New System.Drawing.Size(118, 48)
            Me.lbl1.TabIndex = 0
            Me.lbl1.Text = "Administrar Consecutivos"
            Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'btnGuardar
            '
            Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnGuardar.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = Global.Presentacion.My.Resources.Resources.Guardar
            Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnGuardar.Location = New System.Drawing.Point(0, 0)
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(71, 57)
            Me.btnGuardar.TabIndex = 46
            Me.btnGuardar.Text = "Guardar"
            Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnGuardar.UseVisualStyleBackColor = True
            '
            'gbNumFactura
            '
            Me.gbNumFactura.Controls.Add(Me.chkBloq_Facturas)
            Me.gbNumFactura.Controls.Add(Me.txtCon_Factura)
            Me.gbNumFactura.Controls.Add(Me.lblCons_Factura)
            Me.gbNumFactura.Location = New System.Drawing.Point(51, 72)
            Me.gbNumFactura.Name = "gbNumFactura"
            Me.gbNumFactura.Size = New System.Drawing.Size(260, 45)
            Me.gbNumFactura.TabIndex = 47
            Me.gbNumFactura.TabStop = False
            Me.gbNumFactura.Text = "Facturas"
            '
            'chkBloq_Facturas
            '
            Me.chkBloq_Facturas.AutoSize = True
            Me.chkBloq_Facturas.Location = New System.Drawing.Point(180, 20)
            Me.chkBloq_Facturas.Name = "chkBloq_Facturas"
            Me.chkBloq_Facturas.Size = New System.Drawing.Size(77, 17)
            Me.chkBloq_Facturas.TabIndex = 2
            Me.chkBloq_Facturas.Text = "Bloqueado"
            Me.chkBloq_Facturas.UseVisualStyleBackColor = True
            '
            'txtCon_Factura
            '
            Me.txtCon_Factura.Location = New System.Drawing.Point(80, 17)
            Me.txtCon_Factura.Name = "txtCon_Factura"
            Me.txtCon_Factura.Size = New System.Drawing.Size(72, 20)
            Me.txtCon_Factura.TabIndex = 1
            '
            'lblCons_Factura
            '
            Me.lblCons_Factura.AutoSize = True
            Me.lblCons_Factura.Location = New System.Drawing.Point(7, 20)
            Me.lblCons_Factura.Name = "lblCons_Factura"
            Me.lblCons_Factura.Size = New System.Drawing.Size(69, 13)
            Me.lblCons_Factura.TabIndex = 0
            Me.lblCons_Factura.Text = "Consecutivo:"
            '
            'gbAbonos
            '
            Me.gbAbonos.Controls.Add(Me.chkBloq_Abonos)
            Me.gbAbonos.Controls.Add(Me.txtCons_Abonos)
            Me.gbAbonos.Controls.Add(Me.lblCons_Abonos)
            Me.gbAbonos.Location = New System.Drawing.Point(51, 123)
            Me.gbAbonos.Name = "gbAbonos"
            Me.gbAbonos.Size = New System.Drawing.Size(260, 45)
            Me.gbAbonos.TabIndex = 48
            Me.gbAbonos.TabStop = False
            Me.gbAbonos.Text = "Abonos"
            '
            'chkBloq_Abonos
            '
            Me.chkBloq_Abonos.AutoSize = True
            Me.chkBloq_Abonos.Location = New System.Drawing.Point(180, 20)
            Me.chkBloq_Abonos.Name = "chkBloq_Abonos"
            Me.chkBloq_Abonos.Size = New System.Drawing.Size(77, 17)
            Me.chkBloq_Abonos.TabIndex = 2
            Me.chkBloq_Abonos.Text = "Bloqueado"
            Me.chkBloq_Abonos.UseVisualStyleBackColor = True
            '
            'txtCons_Abonos
            '
            Me.txtCons_Abonos.Location = New System.Drawing.Point(80, 17)
            Me.txtCons_Abonos.Name = "txtCons_Abonos"
            Me.txtCons_Abonos.Size = New System.Drawing.Size(72, 20)
            Me.txtCons_Abonos.TabIndex = 1
            '
            'lblCons_Abonos
            '
            Me.lblCons_Abonos.AutoSize = True
            Me.lblCons_Abonos.Location = New System.Drawing.Point(7, 20)
            Me.lblCons_Abonos.Name = "lblCons_Abonos"
            Me.lblCons_Abonos.Size = New System.Drawing.Size(69, 13)
            Me.lblCons_Abonos.TabIndex = 0
            Me.lblCons_Abonos.Text = "Consecutivo:"
            '
            'gbNotas_Credito
            '
            Me.gbNotas_Credito.Controls.Add(Me.chkBloq_NC)
            Me.gbNotas_Credito.Controls.Add(Me.txtCons_NC)
            Me.gbNotas_Credito.Controls.Add(Me.lblCons_NC)
            Me.gbNotas_Credito.Location = New System.Drawing.Point(51, 174)
            Me.gbNotas_Credito.Name = "gbNotas_Credito"
            Me.gbNotas_Credito.Size = New System.Drawing.Size(260, 45)
            Me.gbNotas_Credito.TabIndex = 49
            Me.gbNotas_Credito.TabStop = False
            Me.gbNotas_Credito.Text = "Notas Crédito"
            '
            'chkBloq_NC
            '
            Me.chkBloq_NC.AutoSize = True
            Me.chkBloq_NC.Location = New System.Drawing.Point(180, 20)
            Me.chkBloq_NC.Name = "chkBloq_NC"
            Me.chkBloq_NC.Size = New System.Drawing.Size(77, 17)
            Me.chkBloq_NC.TabIndex = 2
            Me.chkBloq_NC.Text = "Bloqueado"
            Me.chkBloq_NC.UseVisualStyleBackColor = True
            '
            'txtCons_NC
            '
            Me.txtCons_NC.Location = New System.Drawing.Point(80, 17)
            Me.txtCons_NC.Name = "txtCons_NC"
            Me.txtCons_NC.Size = New System.Drawing.Size(72, 20)
            Me.txtCons_NC.TabIndex = 1
            '
            'lblCons_NC
            '
            Me.lblCons_NC.AutoSize = True
            Me.lblCons_NC.Location = New System.Drawing.Point(7, 20)
            Me.lblCons_NC.Name = "lblCons_NC"
            Me.lblCons_NC.Size = New System.Drawing.Size(69, 13)
            Me.lblCons_NC.TabIndex = 0
            Me.lblCons_NC.Text = "Consecutivo:"
            '
            'gbProformas
            '
            Me.gbProformas.Controls.Add(Me.chkBloq_Proforma)
            Me.gbProformas.Controls.Add(Me.txtCons_Proforma)
            Me.gbProformas.Controls.Add(Me.lblCons_Proforma)
            Me.gbProformas.Location = New System.Drawing.Point(51, 225)
            Me.gbProformas.Name = "gbProformas"
            Me.gbProformas.Size = New System.Drawing.Size(260, 45)
            Me.gbProformas.TabIndex = 50
            Me.gbProformas.TabStop = False
            Me.gbProformas.Text = "Proformas"
            '
            'chkBloq_Proforma
            '
            Me.chkBloq_Proforma.AutoSize = True
            Me.chkBloq_Proforma.Location = New System.Drawing.Point(180, 20)
            Me.chkBloq_Proforma.Name = "chkBloq_Proforma"
            Me.chkBloq_Proforma.Size = New System.Drawing.Size(77, 17)
            Me.chkBloq_Proforma.TabIndex = 2
            Me.chkBloq_Proforma.Text = "Bloqueado"
            Me.chkBloq_Proforma.UseVisualStyleBackColor = True
            '
            'txtCons_Proforma
            '
            Me.txtCons_Proforma.Location = New System.Drawing.Point(80, 17)
            Me.txtCons_Proforma.Name = "txtCons_Proforma"
            Me.txtCons_Proforma.Size = New System.Drawing.Size(72, 20)
            Me.txtCons_Proforma.TabIndex = 1
            '
            'lblCons_Proforma
            '
            Me.lblCons_Proforma.AutoSize = True
            Me.lblCons_Proforma.Location = New System.Drawing.Point(7, 20)
            Me.lblCons_Proforma.Name = "lblCons_Proforma"
            Me.lblCons_Proforma.Size = New System.Drawing.Size(69, 13)
            Me.lblCons_Proforma.TabIndex = 0
            Me.lblCons_Proforma.Text = "Consecutivo:"
            '
            'gbRecibos
            '
            Me.gbRecibos.Controls.Add(Me.chkBloq_Recibo)
            Me.gbRecibos.Controls.Add(Me.txtCons_Recibo)
            Me.gbRecibos.Controls.Add(Me.lblCons_Recibo)
            Me.gbRecibos.Location = New System.Drawing.Point(51, 276)
            Me.gbRecibos.Name = "gbRecibos"
            Me.gbRecibos.Size = New System.Drawing.Size(260, 45)
            Me.gbRecibos.TabIndex = 51
            Me.gbRecibos.TabStop = False
            Me.gbRecibos.Text = "Recibos por dinero"
            '
            'chkBloq_Recibo
            '
            Me.chkBloq_Recibo.AutoSize = True
            Me.chkBloq_Recibo.Location = New System.Drawing.Point(180, 20)
            Me.chkBloq_Recibo.Name = "chkBloq_Recibo"
            Me.chkBloq_Recibo.Size = New System.Drawing.Size(77, 17)
            Me.chkBloq_Recibo.TabIndex = 2
            Me.chkBloq_Recibo.Text = "Bloqueado"
            Me.chkBloq_Recibo.UseVisualStyleBackColor = True
            '
            'txtCons_Recibo
            '
            Me.txtCons_Recibo.Location = New System.Drawing.Point(80, 17)
            Me.txtCons_Recibo.Name = "txtCons_Recibo"
            Me.txtCons_Recibo.Size = New System.Drawing.Size(72, 20)
            Me.txtCons_Recibo.TabIndex = 1
            '
            'lblCons_Recibo
            '
            Me.lblCons_Recibo.AutoSize = True
            Me.lblCons_Recibo.Location = New System.Drawing.Point(7, 20)
            Me.lblCons_Recibo.Name = "lblCons_Recibo"
            Me.lblCons_Recibo.Size = New System.Drawing.Size(69, 13)
            Me.lblCons_Recibo.TabIndex = 0
            Me.lblCons_Recibo.Text = "Consecutivo:"
            '
            'btnRecargar
            '
            Me.btnRecargar.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnRecargar.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnRecargar.Image = Global.Presentacion.My.Resources.Resources.buscar
            Me.btnRecargar.Location = New System.Drawing.Point(70, 0)
            Me.btnRecargar.Name = "btnRecargar"
            Me.btnRecargar.Size = New System.Drawing.Size(71, 57)
            Me.btnRecargar.TabIndex = 52
            Me.btnRecargar.Text = "Refrescar"
            Me.btnRecargar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnRecargar.UseVisualStyleBackColor = True
            '
            'FrmAdministrarConsecutivo
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(373, 333)
            Me.Controls.Add(Me.btnRecargar)
            Me.Controls.Add(Me.gbRecibos)
            Me.Controls.Add(Me.gbProformas)
            Me.Controls.Add(Me.gbNotas_Credito)
            Me.Controls.Add(Me.gbAbonos)
            Me.Controls.Add(Me.gbNumFactura)
            Me.Controls.Add(Me.btnGuardar)
            Me.Controls.Add(Me.lbl1)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmAdministrarConsecutivo"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "FrmAdministrar_Consecutivo"
            Me.gbNumFactura.ResumeLayout(False)
            Me.gbNumFactura.PerformLayout()
            Me.gbAbonos.ResumeLayout(False)
            Me.gbAbonos.PerformLayout()
            Me.gbNotas_Credito.ResumeLayout(False)
            Me.gbNotas_Credito.PerformLayout()
            Me.gbProformas.ResumeLayout(False)
            Me.gbProformas.PerformLayout()
            Me.gbRecibos.ResumeLayout(False)
            Me.gbRecibos.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents lbl1 As System.Windows.Forms.Label
        Friend WithEvents btnGuardar As System.Windows.Forms.Button
        Friend WithEvents gbNumFactura As System.Windows.Forms.GroupBox
        Friend WithEvents txtCon_Factura As System.Windows.Forms.TextBox
        Friend WithEvents lblCons_Factura As System.Windows.Forms.Label
        Friend WithEvents chkBloq_Facturas As System.Windows.Forms.CheckBox
        Friend WithEvents gbAbonos As System.Windows.Forms.GroupBox
        Friend WithEvents chkBloq_Abonos As System.Windows.Forms.CheckBox
        Friend WithEvents txtCons_Abonos As System.Windows.Forms.TextBox
        Friend WithEvents lblCons_Abonos As System.Windows.Forms.Label
        Friend WithEvents gbNotas_Credito As System.Windows.Forms.GroupBox
        Friend WithEvents chkBloq_NC As System.Windows.Forms.CheckBox
        Friend WithEvents txtCons_NC As System.Windows.Forms.TextBox
        Friend WithEvents lblCons_NC As System.Windows.Forms.Label
        Friend WithEvents gbProformas As System.Windows.Forms.GroupBox
        Friend WithEvents chkBloq_Proforma As System.Windows.Forms.CheckBox
        Friend WithEvents txtCons_Proforma As System.Windows.Forms.TextBox
        Friend WithEvents lblCons_Proforma As System.Windows.Forms.Label
        Friend WithEvents gbRecibos As System.Windows.Forms.GroupBox
        Friend WithEvents chkBloq_Recibo As System.Windows.Forms.CheckBox
        Friend WithEvents txtCons_Recibo As System.Windows.Forms.TextBox
        Friend WithEvents lblCons_Recibo As System.Windows.Forms.Label
        Friend WithEvents btnRecargar As System.Windows.Forms.Button
    End Class
End Namespace