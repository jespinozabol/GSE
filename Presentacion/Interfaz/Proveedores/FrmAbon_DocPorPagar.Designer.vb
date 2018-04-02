Namespace Interfaz.Proveedores
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmAbonoDocPorPagar
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
            Me.Label2 = New System.Windows.Forms.Label()
            Me.btnAbonar = New System.Windows.Forms.Button()
            Me.txtMontoAbonar = New System.Windows.Forms.TextBox()
            Me.lblMontoAbonar = New System.Windows.Forms.Label()
            Me.txtMonto = New System.Windows.Forms.TextBox()
            Me.txtMontoNeto = New System.Windows.Forms.TextBox()
            Me.lblMontoNeto = New System.Windows.Forms.Label()
            Me.lblMonto = New System.Windows.Forms.Label()
            Me.txtNumAb = New System.Windows.Forms.TextBox()
            Me.lblNumAb = New System.Windows.Forms.Label()
            Me.txtNumFactura = New System.Windows.Forms.TextBox()
            Me.lblNum_Factura = New System.Windows.Forms.Label()
            Me.txtId_DocPorPagar = New System.Windows.Forms.TextBox()
            Me.lblMontoTotal = New System.Windows.Forms.Label()
            Me.txtMontoVuelto = New System.Windows.Forms.TextBox()
            Me.txtNuevoSaldo = New System.Windows.Forms.TextBox()
            Me.txtMontoAB = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtMontoNC = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtNumNC = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtMontoND = New System.Windows.Forms.TextBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.txtNumND = New System.Windows.Forms.TextBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
            Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.txtMostrarAbono = New System.Windows.Forms.TextBox()
            Me.lblMostrarAbono = New System.Windows.Forms.Label()
            Me.lblFacturasEscogidas = New System.Windows.Forms.Label()
            Me.txtFacturasEscogidas = New System.Windows.Forms.TextBox()
            Me.lblColonesSaldo = New System.Windows.Forms.Label()
            Me.lblColonesCancelacion = New System.Windows.Forms.Label()
            Me.lblColonesAbono = New System.Windows.Forms.Label()
            Me.txtFecha = New System.Windows.Forms.TextBox()
            Me.lblFecha = New System.Windows.Forms.Label()
            Me.SuspendLayout()
            '
            'Label2
            '
            Me.Label2.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(83, 343)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(87, 15)
            Me.Label2.TabIndex = 209
            Me.Label2.Text = "Nuevo Saldo ¢"
            '
            'btnAbonar
            '
            Me.btnAbonar.Enabled = False
            Me.btnAbonar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAbonar.Location = New System.Drawing.Point(0, 0)
            Me.btnAbonar.Name = "btnAbonar"
            Me.btnAbonar.Size = New System.Drawing.Size(65, 57)
            Me.btnAbonar.TabIndex = 208
            Me.btnAbonar.Text = "Abonar"
            Me.btnAbonar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnAbonar.UseVisualStyleBackColor = True
            '
            'txtMontoAbonar
            '
            Me.txtMontoAbonar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMontoAbonar.Location = New System.Drawing.Point(83, 83)
            Me.txtMontoAbonar.MaxLength = 13
            Me.txtMontoAbonar.Name = "txtMontoAbonar"
            Me.txtMontoAbonar.Size = New System.Drawing.Size(120, 22)
            Me.txtMontoAbonar.TabIndex = 0
            Me.txtMontoAbonar.Text = "0.00"
            Me.txtMontoAbonar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblMontoAbonar
            '
            Me.lblMontoAbonar.AutoSize = True
            Me.lblMontoAbonar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMontoAbonar.Location = New System.Drawing.Point(205, 87)
            Me.lblMontoAbonar.Name = "lblMontoAbonar"
            Me.lblMontoAbonar.Size = New System.Drawing.Size(85, 15)
            Me.lblMontoAbonar.TabIndex = 207
            Me.lblMontoAbonar.Text = "Monto abonar"
            '
            'txtMonto
            '
            Me.txtMonto.Location = New System.Drawing.Point(260, 157)
            Me.txtMonto.MaxLength = 5
            Me.txtMonto.Name = "txtMonto"
            Me.txtMonto.ReadOnly = True
            Me.txtMonto.Size = New System.Drawing.Size(100, 20)
            Me.txtMonto.TabIndex = 205
            Me.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtMontoNeto
            '
            Me.txtMontoNeto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMontoNeto.Location = New System.Drawing.Point(172, 290)
            Me.txtMontoNeto.MaxLength = 5
            Me.txtMontoNeto.Name = "txtMontoNeto"
            Me.txtMontoNeto.ReadOnly = True
            Me.txtMontoNeto.Size = New System.Drawing.Size(120, 22)
            Me.txtMontoNeto.TabIndex = 204
            Me.txtMontoNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblMontoNeto
            '
            Me.lblMontoNeto.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMontoNeto.Location = New System.Drawing.Point(84, 293)
            Me.lblMontoNeto.Name = "lblMontoNeto"
            Me.lblMontoNeto.Size = New System.Drawing.Size(87, 15)
            Me.lblMontoNeto.TabIndex = 203
            Me.lblMontoNeto.Text = "Monto Neto ¢"
            '
            'lblMonto
            '
            Me.lblMonto.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMonto.Location = New System.Drawing.Point(155, 159)
            Me.lblMonto.Name = "lblMonto"
            Me.lblMonto.Size = New System.Drawing.Size(99, 15)
            Me.lblMonto.TabIndex = 202
            Me.lblMonto.Text = "Monto ¢"
            Me.lblMonto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtNumAb
            '
            Me.txtNumAb.Location = New System.Drawing.Point(87, 188)
            Me.txtNumAb.MaxLength = 60
            Me.txtNumAb.Name = "txtNumAb"
            Me.txtNumAb.ReadOnly = True
            Me.txtNumAb.Size = New System.Drawing.Size(62, 20)
            Me.txtNumAb.TabIndex = 199
            '
            'lblNumAb
            '
            Me.lblNumAb.AutoSize = True
            Me.lblNumAb.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNumAb.Location = New System.Drawing.Point(18, 190)
            Me.lblNumAb.Name = "lblNumAb"
            Me.lblNumAb.Size = New System.Drawing.Size(63, 15)
            Me.lblNumAb.TabIndex = 201
            Me.lblNumAb.Text = "N° Abonos"
            '
            'txtNumFactura
            '
            Me.txtNumFactura.Location = New System.Drawing.Point(87, 157)
            Me.txtNumFactura.MaxLength = 5
            Me.txtNumFactura.Name = "txtNumFactura"
            Me.txtNumFactura.ReadOnly = True
            Me.txtNumFactura.Size = New System.Drawing.Size(62, 20)
            Me.txtNumFactura.TabIndex = 198
            '
            'lblNum_Factura
            '
            Me.lblNum_Factura.AutoSize = True
            Me.lblNum_Factura.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNum_Factura.Location = New System.Drawing.Point(18, 157)
            Me.lblNum_Factura.Name = "lblNum_Factura"
            Me.lblNum_Factura.Size = New System.Drawing.Size(63, 15)
            Me.lblNum_Factura.TabIndex = 200
            Me.lblNum_Factura.Text = "N° Factura"
            '
            'txtId_DocPorPagar
            '
            Me.txtId_DocPorPagar.Location = New System.Drawing.Point(120, 370)
            Me.txtId_DocPorPagar.Name = "txtId_DocPorPagar"
            Me.txtId_DocPorPagar.Size = New System.Drawing.Size(29, 20)
            Me.txtId_DocPorPagar.TabIndex = 211
            Me.txtId_DocPorPagar.Visible = False
            '
            'lblMontoTotal
            '
            Me.lblMontoTotal.AutoSize = True
            Me.lblMontoTotal.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMontoTotal.Location = New System.Drawing.Point(172, 86)
            Me.lblMontoTotal.Name = "lblMontoTotal"
            Me.lblMontoTotal.Size = New System.Drawing.Size(174, 15)
            Me.lblMontoTotal.TabIndex = 212
            Me.lblMontoTotal.Text = "Pago Multiple (Abonar vuelto)"
            Me.lblMontoTotal.Visible = False
            '
            'txtMontoVuelto
            '
            Me.txtMontoVuelto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMontoVuelto.Location = New System.Drawing.Point(51, 83)
            Me.txtMontoVuelto.MaxLength = 13
            Me.txtMontoVuelto.Name = "txtMontoVuelto"
            Me.txtMontoVuelto.Size = New System.Drawing.Size(120, 22)
            Me.txtMontoVuelto.TabIndex = 1
            Me.txtMontoVuelto.Text = "0.00"
            Me.txtMontoVuelto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.txtMontoVuelto.Visible = False
            '
            'txtNuevoSaldo
            '
            Me.txtNuevoSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNuevoSaldo.Location = New System.Drawing.Point(172, 341)
            Me.txtNuevoSaldo.MaxLength = 5
            Me.txtNuevoSaldo.Name = "txtNuevoSaldo"
            Me.txtNuevoSaldo.ReadOnly = True
            Me.txtNuevoSaldo.Size = New System.Drawing.Size(120, 22)
            Me.txtNuevoSaldo.TabIndex = 214
            Me.txtNuevoSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtMontoAB
            '
            Me.txtMontoAB.Location = New System.Drawing.Point(260, 188)
            Me.txtMontoAB.MaxLength = 5
            Me.txtMontoAB.Name = "txtMontoAB"
            Me.txtMontoAB.ReadOnly = True
            Me.txtMontoAB.Size = New System.Drawing.Size(100, 20)
            Me.txtMontoAB.TabIndex = 220
            Me.txtMontoAB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label3
            '
            Me.Label3.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(155, 190)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(99, 15)
            Me.Label3.TabIndex = 219
            Me.Label3.Text = "Monto Abonos ¢"
            '
            'txtMontoNC
            '
            Me.txtMontoNC.Location = New System.Drawing.Point(260, 219)
            Me.txtMontoNC.MaxLength = 5
            Me.txtMontoNC.Name = "txtMontoNC"
            Me.txtMontoNC.ReadOnly = True
            Me.txtMontoNC.Size = New System.Drawing.Size(100, 20)
            Me.txtMontoNC.TabIndex = 224
            Me.txtMontoNC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label4
            '
            Me.Label4.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(155, 221)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(99, 15)
            Me.Label4.TabIndex = 223
            Me.Label4.Text = "Monto NC ¢"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtNumNC
            '
            Me.txtNumNC.Location = New System.Drawing.Point(87, 219)
            Me.txtNumNC.MaxLength = 60
            Me.txtNumNC.Name = "txtNumNC"
            Me.txtNumNC.ReadOnly = True
            Me.txtNumNC.Size = New System.Drawing.Size(62, 20)
            Me.txtNumNC.TabIndex = 221
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(18, 221)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(38, 15)
            Me.Label5.TabIndex = 222
            Me.Label5.Text = "N° NC"
            '
            'txtMontoND
            '
            Me.txtMontoND.Location = New System.Drawing.Point(260, 247)
            Me.txtMontoND.MaxLength = 5
            Me.txtMontoND.Name = "txtMontoND"
            Me.txtMontoND.ReadOnly = True
            Me.txtMontoND.Size = New System.Drawing.Size(100, 20)
            Me.txtMontoND.TabIndex = 228
            Me.txtMontoND.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label6
            '
            Me.Label6.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(155, 249)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(99, 15)
            Me.Label6.TabIndex = 227
            Me.Label6.Text = "Monto ND ¢"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtNumND
            '
            Me.txtNumND.Location = New System.Drawing.Point(87, 247)
            Me.txtNumND.MaxLength = 60
            Me.txtNumND.Name = "txtNumND"
            Me.txtNumND.ReadOnly = True
            Me.txtNumND.Size = New System.Drawing.Size(62, 20)
            Me.txtNumND.TabIndex = 225
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(18, 249)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(39, 15)
            Me.Label7.TabIndex = 226
            Me.Label7.Text = "N° ND"
            '
            'ShapeContainer1
            '
            Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
            Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
            Me.ShapeContainer1.Name = "ShapeContainer1"
            Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
            Me.ShapeContainer1.Size = New System.Drawing.Size(384, 401)
            Me.ShapeContainer1.TabIndex = 229
            Me.ShapeContainer1.TabStop = False
            '
            'LineShape2
            '
            Me.LineShape2.Name = "LineShape2"
            Me.LineShape2.X1 = 11
            Me.LineShape2.X2 = 370
            Me.LineShape2.Y1 = 147
            Me.LineShape2.Y2 = 147
            '
            'LineShape1
            '
            Me.LineShape1.Name = "LineShape1"
            Me.LineShape1.X1 = 11
            Me.LineShape1.X2 = 370
            Me.LineShape1.Y1 = 276
            Me.LineShape1.Y2 = 276
            '
            'txtMostrarAbono
            '
            Me.txtMostrarAbono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMostrarAbono.Location = New System.Drawing.Point(172, 316)
            Me.txtMostrarAbono.MaxLength = 5
            Me.txtMostrarAbono.Name = "txtMostrarAbono"
            Me.txtMostrarAbono.ReadOnly = True
            Me.txtMostrarAbono.Size = New System.Drawing.Size(120, 22)
            Me.txtMostrarAbono.TabIndex = 231
            Me.txtMostrarAbono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblMostrarAbono
            '
            Me.lblMostrarAbono.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarAbono.Location = New System.Drawing.Point(58, 318)
            Me.lblMostrarAbono.Name = "lblMostrarAbono"
            Me.lblMostrarAbono.Size = New System.Drawing.Size(112, 20)
            Me.lblMostrarAbono.TabIndex = 230
            Me.lblMostrarAbono.Text = "Abono ¢"
            Me.lblMostrarAbono.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblFacturasEscogidas
            '
            Me.lblFacturasEscogidas.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFacturasEscogidas.Location = New System.Drawing.Point(164, 119)
            Me.lblFacturasEscogidas.Name = "lblFacturasEscogidas"
            Me.lblFacturasEscogidas.Size = New System.Drawing.Size(159, 20)
            Me.lblFacturasEscogidas.TabIndex = 232
            Me.lblFacturasEscogidas.Text = "Saldo de Facturas Escogidas"
            Me.lblFacturasEscogidas.Visible = False
            '
            'txtFacturasEscogidas
            '
            Me.txtFacturasEscogidas.Location = New System.Drawing.Point(58, 116)
            Me.txtFacturasEscogidas.Name = "txtFacturasEscogidas"
            Me.txtFacturasEscogidas.ReadOnly = True
            Me.txtFacturasEscogidas.Size = New System.Drawing.Size(100, 20)
            Me.txtFacturasEscogidas.TabIndex = 233
            Me.txtFacturasEscogidas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.txtFacturasEscogidas.Visible = False
            '
            'lblColonesSaldo
            '
            Me.lblColonesSaldo.AutoSize = True
            Me.lblColonesSaldo.Location = New System.Drawing.Point(39, 119)
            Me.lblColonesSaldo.Name = "lblColonesSaldo"
            Me.lblColonesSaldo.Size = New System.Drawing.Size(13, 13)
            Me.lblColonesSaldo.TabIndex = 234
            Me.lblColonesSaldo.Text = "¢"
            Me.lblColonesSaldo.Visible = False
            '
            'lblColonesCancelacion
            '
            Me.lblColonesCancelacion.AutoSize = True
            Me.lblColonesCancelacion.Location = New System.Drawing.Point(32, 87)
            Me.lblColonesCancelacion.Name = "lblColonesCancelacion"
            Me.lblColonesCancelacion.Size = New System.Drawing.Size(13, 13)
            Me.lblColonesCancelacion.TabIndex = 235
            Me.lblColonesCancelacion.Text = "¢"
            Me.lblColonesCancelacion.Visible = False
            '
            'lblColonesAbono
            '
            Me.lblColonesAbono.AutoSize = True
            Me.lblColonesAbono.Location = New System.Drawing.Point(64, 87)
            Me.lblColonesAbono.Name = "lblColonesAbono"
            Me.lblColonesAbono.Size = New System.Drawing.Size(13, 13)
            Me.lblColonesAbono.TabIndex = 236
            Me.lblColonesAbono.Text = "¢"
            '
            'txtFecha
            '
            Me.txtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFecha.Location = New System.Drawing.Point(172, 369)
            Me.txtFecha.MaxLength = 10
            Me.txtFecha.Name = "txtFecha"
            Me.txtFecha.Size = New System.Drawing.Size(118, 24)
            Me.txtFecha.TabIndex = 238
            '
            'lblFecha
            '
            Me.lblFecha.AutoSize = True
            Me.lblFecha.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFecha.Location = New System.Drawing.Point(88, 375)
            Me.lblFecha.Name = "lblFecha"
            Me.lblFecha.Size = New System.Drawing.Size(78, 15)
            Me.lblFecha.TabIndex = 237
            Me.lblFecha.Text = "Fecha Abono"
            '
            'FrmAbonoDocPorPagar
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(384, 401)
            Me.Controls.Add(Me.txtFecha)
            Me.Controls.Add(Me.lblFecha)
            Me.Controls.Add(Me.lblColonesAbono)
            Me.Controls.Add(Me.lblColonesCancelacion)
            Me.Controls.Add(Me.lblColonesSaldo)
            Me.Controls.Add(Me.txtFacturasEscogidas)
            Me.Controls.Add(Me.lblFacturasEscogidas)
            Me.Controls.Add(Me.txtMostrarAbono)
            Me.Controls.Add(Me.lblMostrarAbono)
            Me.Controls.Add(Me.txtMontoND)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.txtNumND)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.txtMontoNC)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.txtNumNC)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.txtMontoAB)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.txtNuevoSaldo)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.btnAbonar)
            Me.Controls.Add(Me.txtMontoAbonar)
            Me.Controls.Add(Me.lblMontoAbonar)
            Me.Controls.Add(Me.txtMonto)
            Me.Controls.Add(Me.txtMontoNeto)
            Me.Controls.Add(Me.lblMontoNeto)
            Me.Controls.Add(Me.lblMonto)
            Me.Controls.Add(Me.txtNumAb)
            Me.Controls.Add(Me.lblNumAb)
            Me.Controls.Add(Me.txtNumFactura)
            Me.Controls.Add(Me.lblNum_Factura)
            Me.Controls.Add(Me.txtId_DocPorPagar)
            Me.Controls.Add(Me.txtMontoVuelto)
            Me.Controls.Add(Me.lblMontoTotal)
            Me.Controls.Add(Me.ShapeContainer1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmAbonoDocPorPagar"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "FrmAbono_DocPorPagar"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents btnAbonar As System.Windows.Forms.Button
        Friend WithEvents txtMontoAbonar As System.Windows.Forms.TextBox
        Friend WithEvents lblMontoAbonar As System.Windows.Forms.Label
        Friend WithEvents txtMonto As System.Windows.Forms.TextBox
        Friend WithEvents txtMontoNeto As System.Windows.Forms.TextBox
        Friend WithEvents lblMontoNeto As System.Windows.Forms.Label
        Friend WithEvents lblMonto As System.Windows.Forms.Label
        Friend WithEvents txtNumAb As System.Windows.Forms.TextBox
        Friend WithEvents lblNumAb As System.Windows.Forms.Label
        Friend WithEvents txtNumFactura As System.Windows.Forms.TextBox
        Friend WithEvents lblNum_Factura As System.Windows.Forms.Label
        Friend WithEvents txtId_DocPorPagar As System.Windows.Forms.TextBox
        Friend WithEvents lblMontoTotal As System.Windows.Forms.Label
        Friend WithEvents txtMontoVuelto As System.Windows.Forms.TextBox
        Friend WithEvents txtNuevoSaldo As System.Windows.Forms.TextBox
        Friend WithEvents txtMontoAB As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtMontoNC As System.Windows.Forms.TextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtNumNC As System.Windows.Forms.TextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents txtMontoND As System.Windows.Forms.TextBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents txtNumND As System.Windows.Forms.TextBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents txtMostrarAbono As System.Windows.Forms.TextBox
        Friend WithEvents lblMostrarAbono As System.Windows.Forms.Label
        Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents lblFacturasEscogidas As System.Windows.Forms.Label
        Friend WithEvents txtFacturasEscogidas As System.Windows.Forms.TextBox
        Friend WithEvents lblColonesSaldo As System.Windows.Forms.Label
        Friend WithEvents lblColonesCancelacion As System.Windows.Forms.Label
        Friend WithEvents lblColonesAbono As System.Windows.Forms.Label
        Friend WithEvents txtFecha As System.Windows.Forms.TextBox
        Friend WithEvents lblFecha As System.Windows.Forms.Label
    End Class
End Namespace