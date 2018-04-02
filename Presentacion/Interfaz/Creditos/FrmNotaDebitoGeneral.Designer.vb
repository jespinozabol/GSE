Namespace Interfaz.Creditos
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmNotaDebitoGeneral
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
            Me.txtTotal = New System.Windows.Forms.TextBox()
            Me.lblMontoIV = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtId_Credito = New System.Windows.Forms.TextBox()
            Me.txtImpuesto = New System.Windows.Forms.TextBox()
            Me.chkImpuesto = New System.Windows.Forms.CheckBox()
            Me.txtMotivo = New System.Windows.Forms.TextBox()
            Me.lblMotivo = New System.Windows.Forms.Label()
            Me.txtMonto = New System.Windows.Forms.TextBox()
            Me.lblMonto = New System.Windows.Forms.Label()
            Me.lblMostrarReciboNotas = New System.Windows.Forms.Label()
            Me.lblRecibo = New System.Windows.Forms.Label()
            Me.txtNombreCliente = New System.Windows.Forms.TextBox()
            Me.lblNombreCliente = New System.Windows.Forms.Label()
            Me.btnNota = New System.Windows.Forms.Button()
            Me.numNota_Debito = New System.Windows.Forms.Timer(Me.components)
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.txtNum_Impresiones = New System.Windows.Forms.TextBox()
            Me.chkImpresion = New System.Windows.Forms.CheckBox()
            Me.txtDiasPlazo = New System.Windows.Forms.TextBox()
            Me.lblDiasPlazo = New System.Windows.Forms.Label()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'txtTotal
            '
            Me.txtTotal.Location = New System.Drawing.Point(398, 113)
            Me.txtTotal.Name = "txtTotal"
            Me.txtTotal.ReadOnly = True
            Me.txtTotal.Size = New System.Drawing.Size(99, 20)
            Me.txtTotal.TabIndex = 241
            Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblMontoIV
            '
            Me.lblMontoIV.AutoSize = True
            Me.lblMontoIV.Location = New System.Drawing.Point(361, 116)
            Me.lblMontoIV.Name = "lblMontoIV"
            Me.lblMontoIV.Size = New System.Drawing.Size(31, 13)
            Me.lblMontoIV.TabIndex = 240
            Me.lblMontoIV.Text = "Total"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(250, 6)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(179, 23)
            Me.Label1.TabIndex = 239
            Me.Label1.Text = "Nota débito a cuenta"
            '
            'txtId_Credito
            '
            Me.txtId_Credito.Location = New System.Drawing.Point(8, 6)
            Me.txtId_Credito.Name = "txtId_Credito"
            Me.txtId_Credito.Size = New System.Drawing.Size(49, 20)
            Me.txtId_Credito.TabIndex = 238
            Me.txtId_Credito.Visible = False
            '
            'txtImpuesto
            '
            Me.txtImpuesto.Enabled = False
            Me.txtImpuesto.Location = New System.Drawing.Point(215, 113)
            Me.txtImpuesto.Name = "txtImpuesto"
            Me.txtImpuesto.Size = New System.Drawing.Size(50, 20)
            Me.txtImpuesto.TabIndex = 237
            Me.txtImpuesto.Text = "0"
            Me.txtImpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'chkImpuesto
            '
            Me.chkImpuesto.AutoSize = True
            Me.chkImpuesto.Location = New System.Drawing.Point(147, 113)
            Me.chkImpuesto.Name = "chkImpuesto"
            Me.chkImpuesto.Size = New System.Drawing.Size(69, 17)
            Me.chkImpuesto.TabIndex = 236
            Me.chkImpuesto.Text = "Impuesto"
            Me.chkImpuesto.UseVisualStyleBackColor = True
            '
            'txtMotivo
            '
            Me.txtMotivo.Location = New System.Drawing.Point(67, 147)
            Me.txtMotivo.MaxLength = 100
            Me.txtMotivo.Multiline = True
            Me.txtMotivo.Name = "txtMotivo"
            Me.txtMotivo.Size = New System.Drawing.Size(430, 55)
            Me.txtMotivo.TabIndex = 227
            '
            'lblMotivo
            '
            Me.lblMotivo.AutoSize = True
            Me.lblMotivo.Location = New System.Drawing.Point(18, 150)
            Me.lblMotivo.Name = "lblMotivo"
            Me.lblMotivo.Size = New System.Drawing.Size(39, 13)
            Me.lblMotivo.TabIndex = 235
            Me.lblMotivo.Text = "Motivo"
            '
            'txtMonto
            '
            Me.txtMonto.Location = New System.Drawing.Point(67, 113)
            Me.txtMonto.Name = "txtMonto"
            Me.txtMonto.Size = New System.Drawing.Size(74, 20)
            Me.txtMonto.TabIndex = 226
            Me.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblMonto
            '
            Me.lblMonto.AutoSize = True
            Me.lblMonto.Location = New System.Drawing.Point(15, 113)
            Me.lblMonto.Name = "lblMonto"
            Me.lblMonto.Size = New System.Drawing.Size(37, 13)
            Me.lblMonto.TabIndex = 234
            Me.lblMonto.Text = "Monto"
            '
            'lblMostrarReciboNotas
            '
            Me.lblMostrarReciboNotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarReciboNotas.Location = New System.Drawing.Point(435, 36)
            Me.lblMostrarReciboNotas.Name = "lblMostrarReciboNotas"
            Me.lblMostrarReciboNotas.Size = New System.Drawing.Size(62, 25)
            Me.lblMostrarReciboNotas.TabIndex = 233
            Me.lblMostrarReciboNotas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblRecibo
            '
            Me.lblRecibo.AutoSize = True
            Me.lblRecibo.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblRecibo.Location = New System.Drawing.Point(298, 42)
            Me.lblRecibo.Name = "lblRecibo"
            Me.lblRecibo.Size = New System.Drawing.Size(119, 15)
            Me.lblRecibo.TabIndex = 232
            Me.lblRecibo.Text = "Recibo NotaDébito#"
            '
            'txtNombreCliente
            '
            Me.txtNombreCliente.Location = New System.Drawing.Point(67, 71)
            Me.txtNombreCliente.Name = "txtNombreCliente"
            Me.txtNombreCliente.ReadOnly = True
            Me.txtNombreCliente.Size = New System.Drawing.Size(430, 20)
            Me.txtNombreCliente.TabIndex = 231
            '
            'lblNombreCliente
            '
            Me.lblNombreCliente.AutoSize = True
            Me.lblNombreCliente.Location = New System.Drawing.Point(15, 74)
            Me.lblNombreCliente.Name = "lblNombreCliente"
            Me.lblNombreCliente.Size = New System.Drawing.Size(44, 13)
            Me.lblNombreCliente.TabIndex = 230
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
            Me.btnNota.TabIndex = 229
            Me.btnNota.Text = "Imprimir"
            Me.btnNota.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnNota.UseVisualStyleBackColor = True
            '
            'numNota_Debito
            '
            Me.numNota_Debito.Enabled = True
            Me.numNota_Debito.Interval = 6
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.txtNum_Impresiones)
            Me.GroupBox1.Controls.Add(Me.chkImpresion)
            Me.GroupBox1.Location = New System.Drawing.Point(82, 12)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(134, 38)
            Me.GroupBox1.TabIndex = 242
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
            'txtDiasPlazo
            '
            Me.txtDiasPlazo.Location = New System.Drawing.Point(328, 112)
            Me.txtDiasPlazo.Name = "txtDiasPlazo"
            Me.txtDiasPlazo.Size = New System.Drawing.Size(30, 20)
            Me.txtDiasPlazo.TabIndex = 244
            Me.txtDiasPlazo.Text = "30"
            Me.txtDiasPlazo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblDiasPlazo
            '
            Me.lblDiasPlazo.AutoSize = True
            Me.lblDiasPlazo.BackColor = System.Drawing.Color.Transparent
            Me.lblDiasPlazo.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblDiasPlazo.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDiasPlazo.Location = New System.Drawing.Point(270, 115)
            Me.lblDiasPlazo.Name = "lblDiasPlazo"
            Me.lblDiasPlazo.Size = New System.Drawing.Size(60, 14)
            Me.lblDiasPlazo.TabIndex = 243
            Me.lblDiasPlazo.Text = "Días Plazo"
            '
            'FrmNotaDebitoGeneral
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(514, 209)
            Me.Controls.Add(Me.btnNota)
            Me.Controls.Add(Me.txtDiasPlazo)
            Me.Controls.Add(Me.lblDiasPlazo)
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
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmNotaDebitoGeneral"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "FrmNota_DebitoGeneral"
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents txtTotal As System.Windows.Forms.TextBox
        Friend WithEvents lblMontoIV As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtId_Credito As System.Windows.Forms.TextBox
        Friend WithEvents txtImpuesto As System.Windows.Forms.TextBox
        Friend WithEvents chkImpuesto As System.Windows.Forms.CheckBox
        Friend WithEvents txtMotivo As System.Windows.Forms.TextBox
        Friend WithEvents lblMotivo As System.Windows.Forms.Label
        Friend WithEvents txtMonto As System.Windows.Forms.TextBox
        Friend WithEvents lblMonto As System.Windows.Forms.Label
        Friend WithEvents lblMostrarReciboNotas As System.Windows.Forms.Label
        Friend WithEvents lblRecibo As System.Windows.Forms.Label
        Friend WithEvents txtNombreCliente As System.Windows.Forms.TextBox
        Friend WithEvents lblNombreCliente As System.Windows.Forms.Label
        Friend WithEvents btnNota As System.Windows.Forms.Button
        Friend WithEvents numNota_Debito As System.Windows.Forms.Timer
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents txtNum_Impresiones As System.Windows.Forms.TextBox
        Friend WithEvents chkImpresion As System.Windows.Forms.CheckBox
        Friend WithEvents txtDiasPlazo As System.Windows.Forms.TextBox
        Friend WithEvents lblDiasPlazo As System.Windows.Forms.Label
    End Class
End Namespace