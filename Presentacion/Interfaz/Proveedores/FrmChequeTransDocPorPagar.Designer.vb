Namespace Interfaz.Proveedores
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmChequeTransDocPorPagar
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
            Me.txtMonto3 = New System.Windows.Forms.TextBox()
            Me.txtMonto2 = New System.Windows.Forms.TextBox()
            Me.txtMonto1 = New System.Windows.Forms.TextBox()
            Me.cb3 = New System.Windows.Forms.ComboBox()
            Me.cb2 = New System.Windows.Forms.ComboBox()
            Me.cb1 = New System.Windows.Forms.ComboBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtNum3 = New System.Windows.Forms.TextBox()
            Me.txtNum2 = New System.Windows.Forms.TextBox()
            Me.txtNum1 = New System.Windows.Forms.TextBox()
            Me.lblMonto = New System.Windows.Forms.Label()
            Me.lblBanco = New System.Windows.Forms.Label()
            Me.lblNum = New System.Windows.Forms.Label()
            Me.lbl1 = New System.Windows.Forms.Label()
            Me.btnAceptar = New System.Windows.Forms.Button()
            Me.btnLimpiar = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'txtMonto3
            '
            Me.txtMonto3.Location = New System.Drawing.Point(273, 143)
            Me.txtMonto3.Name = "txtMonto3"
            Me.txtMonto3.Size = New System.Drawing.Size(85, 20)
            Me.txtMonto3.TabIndex = 213
            Me.txtMonto3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtMonto2
            '
            Me.txtMonto2.Location = New System.Drawing.Point(273, 117)
            Me.txtMonto2.Name = "txtMonto2"
            Me.txtMonto2.Size = New System.Drawing.Size(85, 20)
            Me.txtMonto2.TabIndex = 212
            Me.txtMonto2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtMonto1
            '
            Me.txtMonto1.Location = New System.Drawing.Point(273, 91)
            Me.txtMonto1.Name = "txtMonto1"
            Me.txtMonto1.Size = New System.Drawing.Size(85, 20)
            Me.txtMonto1.TabIndex = 2
            Me.txtMonto1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'cb3
            '
            Me.cb3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cb3.FormattingEnabled = True
            Me.cb3.Items.AddRange(New Object() {"BN", "BCR", "Popular", "Bancredito", "Banhvi", "HSBC", "Scotiabank", "Citibank", "Improsa", "Cathay", "Promerica", "Banco General", "Coocique", "Grupo Mutual", "Mucap"})
            Me.cb3.Location = New System.Drawing.Point(151, 146)
            Me.cb3.Name = "cb3"
            Me.cb3.Size = New System.Drawing.Size(116, 21)
            Me.cb3.TabIndex = 210
            '
            'cb2
            '
            Me.cb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cb2.FormattingEnabled = True
            Me.cb2.Items.AddRange(New Object() {"BN", "BCR", "Popular", "Bancredito", "Banhvi", "HSBC", "Scotiabank", "Citibank", "Improsa", "Cathay", "Promerica", "Banco General", "Coocique", "Grupo Mutual", "Mucap"})
            Me.cb2.Location = New System.Drawing.Point(151, 116)
            Me.cb2.Name = "cb2"
            Me.cb2.Size = New System.Drawing.Size(116, 21)
            Me.cb2.TabIndex = 209
            '
            'cb1
            '
            Me.cb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cb1.FormattingEnabled = True
            Me.cb1.Items.AddRange(New Object() {"BN", "BCR", "Popular", "Bancredito", "Banhvi", "HSBC", "Scotiabank", "Citibank", "Improsa", "Cathay", "Promerica", "Banco General", "Coocique", "Grupo Mutual", "Mucap"})
            Me.cb1.Location = New System.Drawing.Point(151, 89)
            Me.cb1.Name = "cb1"
            Me.cb1.Size = New System.Drawing.Size(116, 21)
            Me.cb1.TabIndex = 1
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(4, 146)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(20, 15)
            Me.Label3.TabIndex = 207
            Me.Label3.Text = "#3"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(4, 120)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(20, 15)
            Me.Label2.TabIndex = 206
            Me.Label2.Text = "#2"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(4, 94)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(19, 15)
            Me.Label1.TabIndex = 205
            Me.Label1.Text = "#1"
            '
            'txtNum3
            '
            Me.txtNum3.Location = New System.Drawing.Point(30, 143)
            Me.txtNum3.Name = "txtNum3"
            Me.txtNum3.Size = New System.Drawing.Size(114, 20)
            Me.txtNum3.TabIndex = 204
            '
            'txtNum2
            '
            Me.txtNum2.Location = New System.Drawing.Point(30, 117)
            Me.txtNum2.Name = "txtNum2"
            Me.txtNum2.Size = New System.Drawing.Size(114, 20)
            Me.txtNum2.TabIndex = 203
            '
            'txtNum1
            '
            Me.txtNum1.Location = New System.Drawing.Point(30, 91)
            Me.txtNum1.Name = "txtNum1"
            Me.txtNum1.Size = New System.Drawing.Size(114, 20)
            Me.txtNum1.TabIndex = 0
            '
            'lblMonto
            '
            Me.lblMonto.AutoSize = True
            Me.lblMonto.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMonto.Location = New System.Drawing.Point(270, 72)
            Me.lblMonto.Name = "lblMonto"
            Me.lblMonto.Size = New System.Drawing.Size(44, 15)
            Me.lblMonto.TabIndex = 201
            Me.lblMonto.Text = "Monto"
            '
            'lblBanco
            '
            Me.lblBanco.AutoSize = True
            Me.lblBanco.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblBanco.Location = New System.Drawing.Point(148, 72)
            Me.lblBanco.Name = "lblBanco"
            Me.lblBanco.Size = New System.Drawing.Size(41, 15)
            Me.lblBanco.TabIndex = 200
            Me.lblBanco.Text = "Banco"
            '
            'lblNum
            '
            Me.lblNum.AutoSize = True
            Me.lblNum.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNum.Location = New System.Drawing.Point(27, 72)
            Me.lblNum.Name = "lblNum"
            Me.lblNum.Size = New System.Drawing.Size(59, 15)
            Me.lblNum.TabIndex = 199
            Me.lblNum.Text = "# Cheque"
            '
            'lbl1
            '
            Me.lbl1.AutoSize = True
            Me.lbl1.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbl1.Location = New System.Drawing.Point(214, 31)
            Me.lbl1.Name = "lbl1"
            Me.lbl1.Size = New System.Drawing.Size(90, 26)
            Me.lbl1.TabIndex = 195
            Me.lbl1.Text = "Cheques"
            '
            'btnAceptar
            '
            Me.btnAceptar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAceptar.Image = Global.Presentacion.My.Resources.Resources.aceptar
            Me.btnAceptar.Location = New System.Drawing.Point(0, 0)
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(65, 57)
            Me.btnAceptar.TabIndex = 198
            Me.btnAceptar.Text = "Aceptar"
            Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnAceptar.UseVisualStyleBackColor = True
            '
            'btnLimpiar
            '
            Me.btnLimpiar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnLimpiar.Image = Global.Presentacion.My.Resources.Resources.Limpiar
            Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnLimpiar.Location = New System.Drawing.Point(64, 0)
            Me.btnLimpiar.Name = "btnLimpiar"
            Me.btnLimpiar.Size = New System.Drawing.Size(65, 57)
            Me.btnLimpiar.TabIndex = 196
            Me.btnLimpiar.Text = "Limpiar"
            Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnLimpiar.UseVisualStyleBackColor = True
            '
            'FrmChequeTransDocPorPagar
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(369, 179)
            Me.Controls.Add(Me.txtMonto3)
            Me.Controls.Add(Me.txtMonto2)
            Me.Controls.Add(Me.txtMonto1)
            Me.Controls.Add(Me.cb3)
            Me.Controls.Add(Me.cb2)
            Me.Controls.Add(Me.cb1)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.txtNum3)
            Me.Controls.Add(Me.txtNum2)
            Me.Controls.Add(Me.txtNum1)
            Me.Controls.Add(Me.lblMonto)
            Me.Controls.Add(Me.lblBanco)
            Me.Controls.Add(Me.lblNum)
            Me.Controls.Add(Me.btnAceptar)
            Me.Controls.Add(Me.btnLimpiar)
            Me.Controls.Add(Me.lbl1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmChequeTransDocPorPagar"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Cheques/Trans DocPorPagar"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents txtMonto3 As System.Windows.Forms.TextBox
        Friend WithEvents txtMonto2 As System.Windows.Forms.TextBox
        Friend WithEvents txtMonto1 As System.Windows.Forms.TextBox
        Friend WithEvents cb3 As System.Windows.Forms.ComboBox
        Friend WithEvents cb2 As System.Windows.Forms.ComboBox
        Friend WithEvents cb1 As System.Windows.Forms.ComboBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtNum3 As System.Windows.Forms.TextBox
        Friend WithEvents txtNum2 As System.Windows.Forms.TextBox
        Friend WithEvents txtNum1 As System.Windows.Forms.TextBox
        Friend WithEvents lblMonto As System.Windows.Forms.Label
        Friend WithEvents lblBanco As System.Windows.Forms.Label
        Friend WithEvents lblNum As System.Windows.Forms.Label
        Friend WithEvents btnAceptar As System.Windows.Forms.Button
        Friend WithEvents btnLimpiar As System.Windows.Forms.Button
        Friend WithEvents lbl1 As System.Windows.Forms.Label
    End Class
End Namespace