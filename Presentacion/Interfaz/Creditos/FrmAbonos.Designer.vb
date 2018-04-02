Namespace Interfaz.Creditos
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmAbonos
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
            Me.txtNumAb = New System.Windows.Forms.TextBox()
            Me.lblNumAb = New System.Windows.Forms.Label()
            Me.txtNumDoc = New System.Windows.Forms.TextBox()
            Me.lblNum_Factura = New System.Windows.Forms.Label()
            Me.lblMonto = New System.Windows.Forms.Label()
            Me.lblMontoNeto = New System.Windows.Forms.Label()
            Me.txtMontoNeto = New System.Windows.Forms.TextBox()
            Me.txtMonto = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblMontoAbonar = New System.Windows.Forms.Label()
            Me.txtMontoAbonar = New System.Windows.Forms.TextBox()
            Me.btnAbonar = New System.Windows.Forms.Button()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.lblMostrarSaldo = New System.Windows.Forms.Label()
            Me.lblTipo = New System.Windows.Forms.Label()
            Me.txtTipo = New System.Windows.Forms.TextBox()
            Me.SuspendLayout()
            '
            'txtNumAb
            '
            Me.txtNumAb.Location = New System.Drawing.Point(83, 99)
            Me.txtNumAb.MaxLength = 60
            Me.txtNumAb.Name = "txtNumAb"
            Me.txtNumAb.ReadOnly = True
            Me.txtNumAb.Size = New System.Drawing.Size(62, 20)
            Me.txtNumAb.TabIndex = 183
            '
            'lblNumAb
            '
            Me.lblNumAb.AutoSize = True
            Me.lblNumAb.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNumAb.Location = New System.Drawing.Point(14, 101)
            Me.lblNumAb.Name = "lblNumAb"
            Me.lblNumAb.Size = New System.Drawing.Size(63, 15)
            Me.lblNumAb.TabIndex = 185
            Me.lblNumAb.Text = "N° Abonos"
            '
            'txtNumDoc
            '
            Me.txtNumDoc.Location = New System.Drawing.Point(83, 68)
            Me.txtNumDoc.MaxLength = 5
            Me.txtNumDoc.Name = "txtNumDoc"
            Me.txtNumDoc.ReadOnly = True
            Me.txtNumDoc.Size = New System.Drawing.Size(62, 20)
            Me.txtNumDoc.TabIndex = 182
            '
            'lblNum_Factura
            '
            Me.lblNum_Factura.AutoSize = True
            Me.lblNum_Factura.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNum_Factura.Location = New System.Drawing.Point(14, 68)
            Me.lblNum_Factura.Name = "lblNum_Factura"
            Me.lblNum_Factura.Size = New System.Drawing.Size(43, 15)
            Me.lblNum_Factura.TabIndex = 184
            Me.lblNum_Factura.Text = "N° Doc"
            '
            'lblMonto
            '
            Me.lblMonto.AutoSize = True
            Me.lblMonto.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMonto.Location = New System.Drawing.Point(151, 70)
            Me.lblMonto.Name = "lblMonto"
            Me.lblMonto.Size = New System.Drawing.Size(44, 15)
            Me.lblMonto.TabIndex = 186
            Me.lblMonto.Text = "Monto"
            '
            'lblMontoNeto
            '
            Me.lblMontoNeto.AutoSize = True
            Me.lblMontoNeto.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMontoNeto.Location = New System.Drawing.Point(151, 99)
            Me.lblMontoNeto.Name = "lblMontoNeto"
            Me.lblMontoNeto.Size = New System.Drawing.Size(75, 15)
            Me.lblMontoNeto.TabIndex = 187
            Me.lblMontoNeto.Text = "Monto Neto"
            '
            'txtMontoNeto
            '
            Me.txtMontoNeto.Location = New System.Drawing.Point(232, 96)
            Me.txtMontoNeto.MaxLength = 5
            Me.txtMontoNeto.Name = "txtMontoNeto"
            Me.txtMontoNeto.ReadOnly = True
            Me.txtMontoNeto.Size = New System.Drawing.Size(117, 20)
            Me.txtMontoNeto.TabIndex = 188
            '
            'txtMonto
            '
            Me.txtMonto.Location = New System.Drawing.Point(232, 70)
            Me.txtMonto.MaxLength = 5
            Me.txtMonto.Name = "txtMonto"
            Me.txtMonto.ReadOnly = True
            Me.txtMonto.Size = New System.Drawing.Size(117, 20)
            Me.txtMonto.TabIndex = 189
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(149, 132)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(77, 26)
            Me.Label1.TabIndex = 190
            Me.Label1.Text = "Abonar"
            '
            'lblMontoAbonar
            '
            Me.lblMontoAbonar.AutoSize = True
            Me.lblMontoAbonar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMontoAbonar.Location = New System.Drawing.Point(101, 169)
            Me.lblMontoAbonar.Name = "lblMontoAbonar"
            Me.lblMontoAbonar.Size = New System.Drawing.Size(44, 15)
            Me.lblMontoAbonar.TabIndex = 191
            Me.lblMontoAbonar.Text = "Monto"
            '
            'txtMontoAbonar
            '
            Me.txtMontoAbonar.Location = New System.Drawing.Point(151, 167)
            Me.txtMontoAbonar.MaxLength = 13
            Me.txtMontoAbonar.Name = "txtMontoAbonar"
            Me.txtMontoAbonar.Size = New System.Drawing.Size(89, 20)
            Me.txtMontoAbonar.TabIndex = 0
            Me.txtMontoAbonar.Text = "0.00"
            Me.txtMontoAbonar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'btnAbonar
            '
            Me.btnAbonar.Enabled = False
            Me.btnAbonar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAbonar.Location = New System.Drawing.Point(0, 0)
            Me.btnAbonar.Name = "btnAbonar"
            Me.btnAbonar.Size = New System.Drawing.Size(65, 57)
            Me.btnAbonar.TabIndex = 193
            Me.btnAbonar.Text = "Abonar"
            Me.btnAbonar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnAbonar.UseVisualStyleBackColor = True
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(14, 209)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(78, 15)
            Me.Label2.TabIndex = 194
            Me.Label2.Text = "Saldo Actual:"
            '
            'lblMostrarSaldo
            '
            Me.lblMostrarSaldo.AutoSize = True
            Me.lblMostrarSaldo.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarSaldo.Location = New System.Drawing.Point(98, 203)
            Me.lblMostrarSaldo.Name = "lblMostrarSaldo"
            Me.lblMostrarSaldo.Size = New System.Drawing.Size(25, 23)
            Me.lblMostrarSaldo.TabIndex = 195
            Me.lblMostrarSaldo.Text = "..."
            '
            'lblTipo
            '
            Me.lblTipo.AutoSize = True
            Me.lblTipo.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTipo.Location = New System.Drawing.Point(17, 132)
            Me.lblTipo.Name = "lblTipo"
            Me.lblTipo.Size = New System.Drawing.Size(31, 15)
            Me.lblTipo.TabIndex = 196
            Me.lblTipo.Text = "Tipo"
            '
            'txtTipo
            '
            Me.txtTipo.Location = New System.Drawing.Point(83, 127)
            Me.txtTipo.MaxLength = 60
            Me.txtTipo.Name = "txtTipo"
            Me.txtTipo.ReadOnly = True
            Me.txtTipo.Size = New System.Drawing.Size(62, 20)
            Me.txtTipo.TabIndex = 197
            '
            'FrmAbonos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(357, 239)
            Me.Controls.Add(Me.txtTipo)
            Me.Controls.Add(Me.lblTipo)
            Me.Controls.Add(Me.lblMostrarSaldo)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.btnAbonar)
            Me.Controls.Add(Me.txtMontoAbonar)
            Me.Controls.Add(Me.lblMontoAbonar)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.txtMonto)
            Me.Controls.Add(Me.txtMontoNeto)
            Me.Controls.Add(Me.lblMontoNeto)
            Me.Controls.Add(Me.lblMonto)
            Me.Controls.Add(Me.txtNumAb)
            Me.Controls.Add(Me.lblNumAb)
            Me.Controls.Add(Me.txtNumDoc)
            Me.Controls.Add(Me.lblNum_Factura)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmAbonos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Abonos"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents txtNumAb As System.Windows.Forms.TextBox
        Friend WithEvents lblNumAb As System.Windows.Forms.Label
        Friend WithEvents txtNumDoc As System.Windows.Forms.TextBox
        Friend WithEvents lblNum_Factura As System.Windows.Forms.Label
        Friend WithEvents lblMonto As System.Windows.Forms.Label
        Friend WithEvents lblMontoNeto As System.Windows.Forms.Label
        Friend WithEvents txtMontoNeto As System.Windows.Forms.TextBox
        Friend WithEvents txtMonto As System.Windows.Forms.TextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents lblMontoAbonar As System.Windows.Forms.Label
        Friend WithEvents txtMontoAbonar As System.Windows.Forms.TextBox
        Friend WithEvents btnAbonar As System.Windows.Forms.Button
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents lblMostrarSaldo As System.Windows.Forms.Label
        Friend WithEvents lblTipo As System.Windows.Forms.Label
        Friend WithEvents txtTipo As System.Windows.Forms.TextBox
    End Class
End Namespace