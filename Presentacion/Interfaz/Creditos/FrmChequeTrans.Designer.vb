Namespace Interfaz.Creditos
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmChequeTrans
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
            Me.btnLimpiar = New System.Windows.Forms.Button()
            Me.btnAceptar = New System.Windows.Forms.Button()
            Me.lblNum = New System.Windows.Forms.Label()
            Me.lblBanco = New System.Windows.Forms.Label()
            Me.lblMonto = New System.Windows.Forms.Label()
            Me.txtNum1 = New System.Windows.Forms.TextBox()
            Me.txtNum2 = New System.Windows.Forms.TextBox()
            Me.txtNum3 = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.cb1 = New System.Windows.Forms.ComboBox()
            Me.cb2 = New System.Windows.Forms.ComboBox()
            Me.cb3 = New System.Windows.Forms.ComboBox()
            Me.txtMonto3 = New System.Windows.Forms.TextBox()
            Me.txtMonto2 = New System.Windows.Forms.TextBox()
            Me.txtMonto1 = New System.Windows.Forms.TextBox()
            Me.lblFecha = New System.Windows.Forms.Label()
            Me.txtFecha3 = New System.Windows.Forms.TextBox()
            Me.txtFecha2 = New System.Windows.Forms.TextBox()
            Me.txtFecha1 = New System.Windows.Forms.TextBox()
            Me.txtFecha4 = New System.Windows.Forms.TextBox()
            Me.txtMonto4 = New System.Windows.Forms.TextBox()
            Me.cb4 = New System.Windows.Forms.ComboBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtNum4 = New System.Windows.Forms.TextBox()
            Me.SuspendLayout()
            '
            'lbl1
            '
            Me.lbl1.AutoSize = True
            Me.lbl1.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbl1.Location = New System.Drawing.Point(213, 30)
            Me.lbl1.Name = "lbl1"
            Me.lbl1.Size = New System.Drawing.Size(90, 26)
            Me.lbl1.TabIndex = 0
            Me.lbl1.Text = "Cheques"
            '
            'btnLimpiar
            '
            Me.btnLimpiar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnLimpiar.Image = Global.Presentacion.My.Resources.Resources.Limpiar
            Me.btnLimpiar.Location = New System.Drawing.Point(64, 0)
            Me.btnLimpiar.Name = "btnLimpiar"
            Me.btnLimpiar.Size = New System.Drawing.Size(65, 57)
            Me.btnLimpiar.TabIndex = 177
            Me.btnLimpiar.Text = "Limpiar"
            Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnLimpiar.UseVisualStyleBackColor = True
            '
            'btnAceptar
            '
            Me.btnAceptar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAceptar.Image = Global.Presentacion.My.Resources.Resources.aceptar
            Me.btnAceptar.Location = New System.Drawing.Point(0, 0)
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(65, 57)
            Me.btnAceptar.TabIndex = 179
            Me.btnAceptar.Text = "Aceptar"
            Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnAceptar.UseVisualStyleBackColor = True
            '
            'lblNum
            '
            Me.lblNum.AutoSize = True
            Me.lblNum.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNum.Location = New System.Drawing.Point(26, 71)
            Me.lblNum.Name = "lblNum"
            Me.lblNum.Size = New System.Drawing.Size(59, 15)
            Me.lblNum.TabIndex = 180
            Me.lblNum.Text = "# Cheque"
            '
            'lblBanco
            '
            Me.lblBanco.AutoSize = True
            Me.lblBanco.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblBanco.Location = New System.Drawing.Point(239, 70)
            Me.lblBanco.Name = "lblBanco"
            Me.lblBanco.Size = New System.Drawing.Size(41, 15)
            Me.lblBanco.TabIndex = 181
            Me.lblBanco.Text = "Banco"
            '
            'lblMonto
            '
            Me.lblMonto.AutoSize = True
            Me.lblMonto.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMonto.Location = New System.Drawing.Point(361, 69)
            Me.lblMonto.Name = "lblMonto"
            Me.lblMonto.Size = New System.Drawing.Size(44, 15)
            Me.lblMonto.TabIndex = 182
            Me.lblMonto.Text = "Monto"
            '
            'txtNum1
            '
            Me.txtNum1.Location = New System.Drawing.Point(29, 90)
            Me.txtNum1.Name = "txtNum1"
            Me.txtNum1.Size = New System.Drawing.Size(114, 20)
            Me.txtNum1.TabIndex = 0
            '
            'txtNum2
            '
            Me.txtNum2.Location = New System.Drawing.Point(29, 116)
            Me.txtNum2.Name = "txtNum2"
            Me.txtNum2.Size = New System.Drawing.Size(114, 20)
            Me.txtNum2.TabIndex = 184
            '
            'txtNum3
            '
            Me.txtNum3.Location = New System.Drawing.Point(29, 142)
            Me.txtNum3.Name = "txtNum3"
            Me.txtNum3.Size = New System.Drawing.Size(114, 20)
            Me.txtNum3.TabIndex = 185
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(3, 93)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(19, 15)
            Me.Label1.TabIndex = 186
            Me.Label1.Text = "#1"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(3, 119)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(20, 15)
            Me.Label2.TabIndex = 187
            Me.Label2.Text = "#2"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(3, 145)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(20, 15)
            Me.Label3.TabIndex = 188
            Me.Label3.Text = "#3"
            '
            'cb1
            '
            Me.cb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cb1.FormattingEnabled = True
            Me.cb1.Items.AddRange(New Object() {"BN", "BCR", "Popular", "Bancredito", "Banhvi", "HSBC", "Scotiabank", "Citibank", "Improsa", "Cathay", "Promerica", "Banco General", "Coocique", "Grupo Mutual", "Mucap"})
            Me.cb1.Location = New System.Drawing.Point(242, 87)
            Me.cb1.Name = "cb1"
            Me.cb1.Size = New System.Drawing.Size(116, 21)
            Me.cb1.TabIndex = 189
            '
            'cb2
            '
            Me.cb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cb2.FormattingEnabled = True
            Me.cb2.Items.AddRange(New Object() {"BN", "BCR", "Popular", "Bancredito", "Banhvi", "HSBC", "Scotiabank", "Citibank", "Improsa", "Cathay", "Promerica", "Banco General", "Coocique", "Grupo Mutual", "Mucap"})
            Me.cb2.Location = New System.Drawing.Point(242, 114)
            Me.cb2.Name = "cb2"
            Me.cb2.Size = New System.Drawing.Size(116, 21)
            Me.cb2.TabIndex = 190
            '
            'cb3
            '
            Me.cb3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cb3.FormattingEnabled = True
            Me.cb3.Items.AddRange(New Object() {"BN", "BCR", "Popular", "Bancredito", "Banhvi", "HSBC", "Scotiabank", "Citibank", "Improsa", "Cathay", "Promerica", "Banco General", "Coocique", "Grupo Mutual", "Mucap"})
            Me.cb3.Location = New System.Drawing.Point(242, 144)
            Me.cb3.Name = "cb3"
            Me.cb3.Size = New System.Drawing.Size(116, 21)
            Me.cb3.TabIndex = 191
            '
            'txtMonto3
            '
            Me.txtMonto3.Location = New System.Drawing.Point(364, 140)
            Me.txtMonto3.Name = "txtMonto3"
            Me.txtMonto3.Size = New System.Drawing.Size(85, 20)
            Me.txtMonto3.TabIndex = 194
            Me.txtMonto3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtMonto2
            '
            Me.txtMonto2.Location = New System.Drawing.Point(364, 114)
            Me.txtMonto2.Name = "txtMonto2"
            Me.txtMonto2.Size = New System.Drawing.Size(85, 20)
            Me.txtMonto2.TabIndex = 193
            Me.txtMonto2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtMonto1
            '
            Me.txtMonto1.Location = New System.Drawing.Point(364, 88)
            Me.txtMonto1.Name = "txtMonto1"
            Me.txtMonto1.Size = New System.Drawing.Size(85, 20)
            Me.txtMonto1.TabIndex = 192
            Me.txtMonto1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblFecha
            '
            Me.lblFecha.AutoSize = True
            Me.lblFecha.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFecha.Location = New System.Drawing.Point(152, 71)
            Me.lblFecha.Name = "lblFecha"
            Me.lblFecha.Size = New System.Drawing.Size(39, 15)
            Me.lblFecha.TabIndex = 195
            Me.lblFecha.Text = "Fecha"
            '
            'txtFecha3
            '
            Me.txtFecha3.Location = New System.Drawing.Point(151, 142)
            Me.txtFecha3.Name = "txtFecha3"
            Me.txtFecha3.Size = New System.Drawing.Size(85, 20)
            Me.txtFecha3.TabIndex = 198
            '
            'txtFecha2
            '
            Me.txtFecha2.Location = New System.Drawing.Point(151, 116)
            Me.txtFecha2.Name = "txtFecha2"
            Me.txtFecha2.Size = New System.Drawing.Size(85, 20)
            Me.txtFecha2.TabIndex = 197
            '
            'txtFecha1
            '
            Me.txtFecha1.Location = New System.Drawing.Point(151, 90)
            Me.txtFecha1.Name = "txtFecha1"
            Me.txtFecha1.Size = New System.Drawing.Size(85, 20)
            Me.txtFecha1.TabIndex = 196
            '
            'txtFecha4
            '
            Me.txtFecha4.Location = New System.Drawing.Point(151, 168)
            Me.txtFecha4.Name = "txtFecha4"
            Me.txtFecha4.Size = New System.Drawing.Size(85, 20)
            Me.txtFecha4.TabIndex = 203
            '
            'txtMonto4
            '
            Me.txtMonto4.Location = New System.Drawing.Point(364, 166)
            Me.txtMonto4.Name = "txtMonto4"
            Me.txtMonto4.Size = New System.Drawing.Size(85, 20)
            Me.txtMonto4.TabIndex = 202
            Me.txtMonto4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'cb4
            '
            Me.cb4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cb4.FormattingEnabled = True
            Me.cb4.Items.AddRange(New Object() {"BN", "BCR", "Popular", "Bancredito", "Banhvi", "HSBC", "Scotiabank", "Citibank", "Improsa", "Cathay", "Promerica", "Banco General", "Coocique", "Grupo Mutual", "Mucap"})
            Me.cb4.Location = New System.Drawing.Point(242, 170)
            Me.cb4.Name = "cb4"
            Me.cb4.Size = New System.Drawing.Size(116, 21)
            Me.cb4.TabIndex = 201
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(3, 171)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(21, 15)
            Me.Label4.TabIndex = 200
            Me.Label4.Text = "#4"
            '
            'txtNum4
            '
            Me.txtNum4.Location = New System.Drawing.Point(29, 168)
            Me.txtNum4.Name = "txtNum4"
            Me.txtNum4.Size = New System.Drawing.Size(114, 20)
            Me.txtNum4.TabIndex = 199
            '
            'FrmChequeTrans
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(470, 193)
            Me.Controls.Add(Me.txtFecha4)
            Me.Controls.Add(Me.txtMonto4)
            Me.Controls.Add(Me.cb4)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.txtNum4)
            Me.Controls.Add(Me.txtFecha3)
            Me.Controls.Add(Me.txtFecha2)
            Me.Controls.Add(Me.txtFecha1)
            Me.Controls.Add(Me.lblFecha)
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
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmChequeTrans"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "FrmChequeTrans"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents lbl1 As System.Windows.Forms.Label
        Friend WithEvents btnLimpiar As System.Windows.Forms.Button
        Friend WithEvents btnAceptar As System.Windows.Forms.Button
        Friend WithEvents lblNum As System.Windows.Forms.Label
        Friend WithEvents lblBanco As System.Windows.Forms.Label
        Friend WithEvents lblMonto As System.Windows.Forms.Label
        Friend WithEvents txtNum1 As System.Windows.Forms.TextBox
        Friend WithEvents txtNum2 As System.Windows.Forms.TextBox
        Friend WithEvents txtNum3 As System.Windows.Forms.TextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents cb1 As System.Windows.Forms.ComboBox
        Friend WithEvents cb2 As System.Windows.Forms.ComboBox
        Friend WithEvents cb3 As System.Windows.Forms.ComboBox
        Friend WithEvents txtMonto3 As System.Windows.Forms.TextBox
        Friend WithEvents txtMonto2 As System.Windows.Forms.TextBox
        Friend WithEvents txtMonto1 As System.Windows.Forms.TextBox
        Friend WithEvents lblFecha As System.Windows.Forms.Label
        Friend WithEvents txtFecha3 As System.Windows.Forms.TextBox
        Friend WithEvents txtFecha2 As System.Windows.Forms.TextBox
        Friend WithEvents txtFecha1 As System.Windows.Forms.TextBox
        Friend WithEvents txtFecha4 As System.Windows.Forms.TextBox
        Friend WithEvents txtMonto4 As System.Windows.Forms.TextBox
        Friend WithEvents cb4 As System.Windows.Forms.ComboBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtNum4 As System.Windows.Forms.TextBox
    End Class
End Namespace