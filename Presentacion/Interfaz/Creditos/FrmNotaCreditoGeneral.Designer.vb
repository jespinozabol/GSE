Namespace Interfaz.Creditos
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmNotaCreditoGeneral
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
            Me.lblMostrarReciboNotas = New System.Windows.Forms.Label()
            Me.lblRecibo = New System.Windows.Forms.Label()
            Me.txtNombreCliente = New System.Windows.Forms.TextBox()
            Me.lblNombreCliente = New System.Windows.Forms.Label()
            Me.btnNota = New System.Windows.Forms.Button()
            Me.lblMonto = New System.Windows.Forms.Label()
            Me.txtMonto = New System.Windows.Forms.TextBox()
            Me.lblMotivo = New System.Windows.Forms.Label()
            Me.txtMotivo = New System.Windows.Forms.TextBox()
            Me.chkImpuesto = New System.Windows.Forms.CheckBox()
            Me.txtImpuesto = New System.Windows.Forms.TextBox()
            Me.numNota_Credito = New System.Windows.Forms.Timer(Me.components)
            Me.txtId_Credito = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblMontoIV = New System.Windows.Forms.Label()
            Me.txtTotal = New System.Windows.Forms.TextBox()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.txtNum_Impresiones = New System.Windows.Forms.TextBox()
            Me.chkImpresion = New System.Windows.Forms.CheckBox()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'lblMostrarReciboNotas
            '
            Me.lblMostrarReciboNotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarReciboNotas.Location = New System.Drawing.Point(417, 32)
            Me.lblMostrarReciboNotas.Name = "lblMostrarReciboNotas"
            Me.lblMostrarReciboNotas.Size = New System.Drawing.Size(62, 25)
            Me.lblMostrarReciboNotas.TabIndex = 215
            Me.lblMostrarReciboNotas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblRecibo
            '
            Me.lblRecibo.AutoSize = True
            Me.lblRecibo.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblRecibo.Location = New System.Drawing.Point(285, 38)
            Me.lblRecibo.Name = "lblRecibo"
            Me.lblRecibo.Size = New System.Drawing.Size(126, 15)
            Me.lblRecibo.TabIndex = 214
            Me.lblRecibo.Text = "Recibo Nota Crédito#"
            '
            'txtNombreCliente
            '
            Me.txtNombreCliente.Location = New System.Drawing.Point(64, 68)
            Me.txtNombreCliente.Name = "txtNombreCliente"
            Me.txtNombreCliente.ReadOnly = True
            Me.txtNombreCliente.Size = New System.Drawing.Size(415, 20)
            Me.txtNombreCliente.TabIndex = 211
            '
            'lblNombreCliente
            '
            Me.lblNombreCliente.AutoSize = True
            Me.lblNombreCliente.Location = New System.Drawing.Point(12, 71)
            Me.lblNombreCliente.Name = "lblNombreCliente"
            Me.lblNombreCliente.Size = New System.Drawing.Size(44, 13)
            Me.lblNombreCliente.TabIndex = 210
            Me.lblNombreCliente.Text = "Nombre"
            '
            'btnNota
            '
            Me.btnNota.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNota.Image = Global.Presentacion.My.Resources.Resources.Imprimir
            Me.btnNota.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnNota.Location = New System.Drawing.Point(0, 0)
            Me.btnNota.Name = "btnNota"
            Me.btnNota.Size = New System.Drawing.Size(65, 57)
            Me.btnNota.TabIndex = 207
            Me.btnNota.Text = "Imprimir"
            Me.btnNota.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnNota.UseVisualStyleBackColor = True
            '
            'lblMonto
            '
            Me.lblMonto.AutoSize = True
            Me.lblMonto.Location = New System.Drawing.Point(13, 110)
            Me.lblMonto.Name = "lblMonto"
            Me.lblMonto.Size = New System.Drawing.Size(37, 13)
            Me.lblMonto.TabIndex = 216
            Me.lblMonto.Text = "Monto"
            '
            'txtMonto
            '
            Me.txtMonto.Location = New System.Drawing.Point(64, 110)
            Me.txtMonto.Name = "txtMonto"
            Me.txtMonto.Size = New System.Drawing.Size(74, 20)
            Me.txtMonto.TabIndex = 0
            Me.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblMotivo
            '
            Me.lblMotivo.AutoSize = True
            Me.lblMotivo.Location = New System.Drawing.Point(15, 147)
            Me.lblMotivo.Name = "lblMotivo"
            Me.lblMotivo.Size = New System.Drawing.Size(39, 13)
            Me.lblMotivo.TabIndex = 218
            Me.lblMotivo.Text = "Motivo"
            '
            'txtMotivo
            '
            Me.txtMotivo.Location = New System.Drawing.Point(64, 144)
            Me.txtMotivo.MaxLength = 150
            Me.txtMotivo.Multiline = True
            Me.txtMotivo.Name = "txtMotivo"
            Me.txtMotivo.Size = New System.Drawing.Size(413, 54)
            Me.txtMotivo.TabIndex = 1
            '
            'chkImpuesto
            '
            Me.chkImpuesto.AutoSize = True
            Me.chkImpuesto.Location = New System.Drawing.Point(163, 110)
            Me.chkImpuesto.Name = "chkImpuesto"
            Me.chkImpuesto.Size = New System.Drawing.Size(69, 17)
            Me.chkImpuesto.TabIndex = 220
            Me.chkImpuesto.Text = "Impuesto"
            Me.chkImpuesto.UseVisualStyleBackColor = True
            '
            'txtImpuesto
            '
            Me.txtImpuesto.Enabled = False
            Me.txtImpuesto.Location = New System.Drawing.Point(238, 108)
            Me.txtImpuesto.Name = "txtImpuesto"
            Me.txtImpuesto.Size = New System.Drawing.Size(50, 20)
            Me.txtImpuesto.TabIndex = 221
            Me.txtImpuesto.Text = "0"
            Me.txtImpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'numNota_Credito
            '
            Me.numNota_Credito.Enabled = True
            Me.numNota_Credito.Interval = 6
            '
            'txtId_Credito
            '
            Me.txtId_Credito.Location = New System.Drawing.Point(12, 6)
            Me.txtId_Credito.Name = "txtId_Credito"
            Me.txtId_Credito.Size = New System.Drawing.Size(49, 20)
            Me.txtId_Credito.TabIndex = 222
            Me.txtId_Credito.Visible = False
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(255, 2)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(183, 23)
            Me.Label1.TabIndex = 223
            Me.Label1.Text = "Nota crédito a cuenta"
            '
            'lblMontoIV
            '
            Me.lblMontoIV.AutoSize = True
            Me.lblMontoIV.Location = New System.Drawing.Point(340, 114)
            Me.lblMontoIV.Name = "lblMontoIV"
            Me.lblMontoIV.Size = New System.Drawing.Size(31, 13)
            Me.lblMontoIV.TabIndex = 224
            Me.lblMontoIV.Text = "Total"
            '
            'txtTotal
            '
            Me.txtTotal.Location = New System.Drawing.Point(386, 110)
            Me.txtTotal.Name = "txtTotal"
            Me.txtTotal.ReadOnly = True
            Me.txtTotal.Size = New System.Drawing.Size(93, 20)
            Me.txtTotal.TabIndex = 225
            Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.txtNum_Impresiones)
            Me.GroupBox1.Controls.Add(Me.chkImpresion)
            Me.GroupBox1.Location = New System.Drawing.Point(78, 11)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(134, 38)
            Me.GroupBox1.TabIndex = 234
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Impresiones"
            '
            'txtNum_Impresiones
            '
            Me.txtNum_Impresiones.Enabled = False
            Me.txtNum_Impresiones.Location = New System.Drawing.Point(82, 12)
            Me.txtNum_Impresiones.Name = "txtNum_Impresiones"
            Me.txtNum_Impresiones.ReadOnly = True
            Me.txtNum_Impresiones.Size = New System.Drawing.Size(40, 20)
            Me.txtNum_Impresiones.TabIndex = 232
            Me.txtNum_Impresiones.Text = "2"
            Me.txtNum_Impresiones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'chkImpresion
            '
            Me.chkImpresion.AutoSize = True
            Me.chkImpresion.Checked = True
            Me.chkImpresion.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkImpresion.Location = New System.Drawing.Point(6, 15)
            Me.chkImpresion.Name = "chkImpresion"
            Me.chkImpresion.Size = New System.Drawing.Size(70, 17)
            Me.chkImpresion.TabIndex = 231
            Me.chkImpresion.Text = "# copias:"
            Me.chkImpresion.UseVisualStyleBackColor = True
            '
            'FrmNotaCreditoGeneral
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(489, 210)
            Me.Controls.Add(Me.btnNota)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.txtTotal)
            Me.Controls.Add(Me.lblMontoIV)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.txtId_Credito)
            Me.Controls.Add(Me.txtImpuesto)
            Me.Controls.Add(Me.chkImpuesto)
            Me.Controls.Add(Me.txtMotivo)
            Me.Controls.Add(Me.lblMotivo)
            Me.Controls.Add(Me.txtMonto)
            Me.Controls.Add(Me.lblMonto)
            Me.Controls.Add(Me.lblMostrarReciboNotas)
            Me.Controls.Add(Me.lblRecibo)
            Me.Controls.Add(Me.txtNombreCliente)
            Me.Controls.Add(Me.lblNombreCliente)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmNotaCreditoGeneral"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Nota Crédito General"
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents lblMostrarReciboNotas As System.Windows.Forms.Label
        Friend WithEvents lblRecibo As System.Windows.Forms.Label
        Friend WithEvents txtNombreCliente As System.Windows.Forms.TextBox
        Friend WithEvents lblNombreCliente As System.Windows.Forms.Label
        Friend WithEvents btnNota As System.Windows.Forms.Button
        Friend WithEvents lblMonto As System.Windows.Forms.Label
        Friend WithEvents txtMonto As System.Windows.Forms.TextBox
        Friend WithEvents lblMotivo As System.Windows.Forms.Label
        Friend WithEvents txtMotivo As System.Windows.Forms.TextBox
        Friend WithEvents chkImpuesto As System.Windows.Forms.CheckBox
        Friend WithEvents txtImpuesto As System.Windows.Forms.TextBox
        Friend WithEvents numNota_Credito As System.Windows.Forms.Timer
        Friend WithEvents txtId_Credito As System.Windows.Forms.TextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents lblMontoIV As System.Windows.Forms.Label
        Friend WithEvents txtTotal As System.Windows.Forms.TextBox
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents txtNum_Impresiones As System.Windows.Forms.TextBox
        Friend WithEvents chkImpresion As System.Windows.Forms.CheckBox
    End Class
End Namespace