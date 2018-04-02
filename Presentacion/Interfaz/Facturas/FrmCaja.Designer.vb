Namespace Interfaz.Facturas
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmCaja
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
            Me.lblFecha = New System.Windows.Forms.Label()
            Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
            Me.btnCalcular = New System.Windows.Forms.Button()
            Me.lblTransferencia = New System.Windows.Forms.Label()
            Me.Cheques = New System.Windows.Forms.Label()
            Me.lblTarjetas = New System.Windows.Forms.Label()
            Me.lblEfectivo = New System.Windows.Forms.Label()
            Me.lblMostrarTotal = New System.Windows.Forms.Label()
            Me.lblTotal = New System.Windows.Forms.Label()
            Me.lblMostrar_Efectivo = New System.Windows.Forms.Label()
            Me.lblMostrar_Tarjetas = New System.Windows.Forms.Label()
            Me.lblMostrar_Cheques = New System.Windows.Forms.Label()
            Me.lblMostrar_Transf = New System.Windows.Forms.Label()
            Me.btnLimpiar = New System.Windows.Forms.Button()
            Me.lblMostrar_Equivalencia = New System.Windows.Forms.Label()
            Me.lblMostrar_Redondeo = New System.Windows.Forms.Label()
            Me.lblRedondeo = New System.Windows.Forms.Label()
            Me.lblEquivalencia = New System.Windows.Forms.Label()
            Me.lblMostrar_TotalGeneral = New System.Windows.Forms.Label()
            Me.lblTotal_General = New System.Windows.Forms.Label()
            Me.lblMostrar_Otros = New System.Windows.Forms.Label()
            Me.lblOtros = New System.Windows.Forms.Label()
            Me.lblMostrar_Vales = New System.Windows.Forms.Label()
            Me.lblVales = New System.Windows.Forms.Label()
            Me.lblMostrar_Creditos = New System.Windows.Forms.Label()
            Me.lblCreditos = New System.Windows.Forms.Label()
            Me.lblMostrar_OtrosIngresos = New System.Windows.Forms.Label()
            Me.lblOtros_Ingresos = New System.Windows.Forms.Label()
            Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
            Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.lblMostrar_Ventas = New System.Windows.Forms.Label()
            Me.lblVentas = New System.Windows.Forms.Label()
            Me.lbl1 = New System.Windows.Forms.Label()
            Me.SuspendLayout()
            '
            'lblFecha
            '
            Me.lblFecha.AutoSize = True
            Me.lblFecha.Location = New System.Drawing.Point(248, 9)
            Me.lblFecha.Name = "lblFecha"
            Me.lblFecha.Size = New System.Drawing.Size(37, 13)
            Me.lblFecha.TabIndex = 222
            Me.lblFecha.Text = "Fecha"
            '
            'dtpFecha
            '
            Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFecha.Location = New System.Drawing.Point(251, 25)
            Me.dtpFecha.MaxDate = New Date(3000, 12, 31, 0, 0, 0, 0)
            Me.dtpFecha.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
            Me.dtpFecha.Name = "dtpFecha"
            Me.dtpFecha.Size = New System.Drawing.Size(99, 20)
            Me.dtpFecha.TabIndex = 221
            Me.dtpFecha.Value = New Date(2011, 12, 27, 0, 0, 0, 0)
            '
            'btnCalcular
            '
            Me.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnCalcular.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCalcular.Image = Global.Presentacion.My.Resources.Resources.sumar
            Me.btnCalcular.Location = New System.Drawing.Point(0, 0)
            Me.btnCalcular.Name = "btnCalcular"
            Me.btnCalcular.Size = New System.Drawing.Size(71, 57)
            Me.btnCalcular.TabIndex = 220
            Me.btnCalcular.Text = "Calcular"
            Me.btnCalcular.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnCalcular.UseVisualStyleBackColor = True
            '
            'lblTransferencia
            '
            Me.lblTransferencia.AutoSize = True
            Me.lblTransferencia.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTransferencia.Location = New System.Drawing.Point(54, 303)
            Me.lblTransferencia.Name = "lblTransferencia"
            Me.lblTransferencia.Size = New System.Drawing.Size(91, 15)
            Me.lblTransferencia.TabIndex = 230
            Me.lblTransferencia.Text = "Transferencia ¢"
            '
            'Cheques
            '
            Me.Cheques.AutoSize = True
            Me.Cheques.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Cheques.Location = New System.Drawing.Point(81, 142)
            Me.Cheques.Name = "Cheques"
            Me.Cheques.Size = New System.Drawing.Size(64, 15)
            Me.Cheques.TabIndex = 227
            Me.Cheques.Text = "Cheques ¢"
            '
            'lblTarjetas
            '
            Me.lblTarjetas.AutoSize = True
            Me.lblTarjetas.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTarjetas.Location = New System.Drawing.Point(81, 274)
            Me.lblTarjetas.Name = "lblTarjetas"
            Me.lblTarjetas.Size = New System.Drawing.Size(60, 15)
            Me.lblTarjetas.TabIndex = 225
            Me.lblTarjetas.Text = "Tarjetas ¢"
            '
            'lblEfectivo
            '
            Me.lblEfectivo.AutoSize = True
            Me.lblEfectivo.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEfectivo.Location = New System.Drawing.Point(34, 74)
            Me.lblEfectivo.Name = "lblEfectivo"
            Me.lblEfectivo.Size = New System.Drawing.Size(107, 15)
            Me.lblEfectivo.TabIndex = 223
            Me.lblEfectivo.Text = "Ingreso Efectivo ¢"
            '
            'lblMostrarTotal
            '
            Me.lblMostrarTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarTotal.ForeColor = System.Drawing.Color.Blue
            Me.lblMostrarTotal.Location = New System.Drawing.Point(170, 232)
            Me.lblMostrarTotal.Name = "lblMostrarTotal"
            Me.lblMostrarTotal.Size = New System.Drawing.Size(217, 36)
            Me.lblMostrarTotal.TabIndex = 232
            Me.lblMostrarTotal.Text = "0.00"
            Me.lblMostrarTotal.TextAlign = System.Drawing.ContentAlignment.BottomRight
            '
            'lblTotal
            '
            Me.lblTotal.AutoSize = True
            Me.lblTotal.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotal.Location = New System.Drawing.Point(23, 232)
            Me.lblTotal.Name = "lblTotal"
            Me.lblTotal.Size = New System.Drawing.Size(155, 29)
            Me.lblTotal.TabIndex = 231
            Me.lblTotal.Text = "Ingreso Caja ¢"
            '
            'lblMostrar_Efectivo
            '
            Me.lblMostrar_Efectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrar_Efectivo.Location = New System.Drawing.Point(153, 74)
            Me.lblMostrar_Efectivo.Name = "lblMostrar_Efectivo"
            Me.lblMostrar_Efectivo.Size = New System.Drawing.Size(105, 20)
            Me.lblMostrar_Efectivo.TabIndex = 233
            Me.lblMostrar_Efectivo.Text = "0.00"
            Me.lblMostrar_Efectivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblMostrar_Tarjetas
            '
            Me.lblMostrar_Tarjetas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrar_Tarjetas.Location = New System.Drawing.Point(153, 274)
            Me.lblMostrar_Tarjetas.Name = "lblMostrar_Tarjetas"
            Me.lblMostrar_Tarjetas.Size = New System.Drawing.Size(105, 20)
            Me.lblMostrar_Tarjetas.TabIndex = 234
            Me.lblMostrar_Tarjetas.Text = "0.00"
            Me.lblMostrar_Tarjetas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblMostrar_Cheques
            '
            Me.lblMostrar_Cheques.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrar_Cheques.Location = New System.Drawing.Point(153, 142)
            Me.lblMostrar_Cheques.Name = "lblMostrar_Cheques"
            Me.lblMostrar_Cheques.Size = New System.Drawing.Size(105, 20)
            Me.lblMostrar_Cheques.TabIndex = 235
            Me.lblMostrar_Cheques.Text = "0.00"
            Me.lblMostrar_Cheques.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblMostrar_Transf
            '
            Me.lblMostrar_Transf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrar_Transf.Location = New System.Drawing.Point(153, 303)
            Me.lblMostrar_Transf.Name = "lblMostrar_Transf"
            Me.lblMostrar_Transf.Size = New System.Drawing.Size(105, 20)
            Me.lblMostrar_Transf.TabIndex = 236
            Me.lblMostrar_Transf.Text = "0.00"
            Me.lblMostrar_Transf.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'btnLimpiar
            '
            Me.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnLimpiar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnLimpiar.Image = Global.Presentacion.My.Resources.Resources.Limpiar
            Me.btnLimpiar.Location = New System.Drawing.Point(70, 0)
            Me.btnLimpiar.Name = "btnLimpiar"
            Me.btnLimpiar.Size = New System.Drawing.Size(71, 57)
            Me.btnLimpiar.TabIndex = 237
            Me.btnLimpiar.Text = "Limpiar"
            Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnLimpiar.UseVisualStyleBackColor = True
            '
            'lblMostrar_Equivalencia
            '
            Me.lblMostrar_Equivalencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrar_Equivalencia.Location = New System.Drawing.Point(153, 173)
            Me.lblMostrar_Equivalencia.Name = "lblMostrar_Equivalencia"
            Me.lblMostrar_Equivalencia.Size = New System.Drawing.Size(105, 20)
            Me.lblMostrar_Equivalencia.TabIndex = 242
            Me.lblMostrar_Equivalencia.Text = "0.00"
            Me.lblMostrar_Equivalencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblMostrar_Redondeo
            '
            Me.lblMostrar_Redondeo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrar_Redondeo.Location = New System.Drawing.Point(165, 490)
            Me.lblMostrar_Redondeo.Name = "lblMostrar_Redondeo"
            Me.lblMostrar_Redondeo.Size = New System.Drawing.Size(105, 20)
            Me.lblMostrar_Redondeo.TabIndex = 241
            Me.lblMostrar_Redondeo.Text = "0.00"
            Me.lblMostrar_Redondeo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblRedondeo
            '
            Me.lblRedondeo.AutoSize = True
            Me.lblRedondeo.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblRedondeo.Location = New System.Drawing.Point(81, 490)
            Me.lblRedondeo.Name = "lblRedondeo"
            Me.lblRedondeo.Size = New System.Drawing.Size(74, 15)
            Me.lblRedondeo.TabIndex = 240
            Me.lblRedondeo.Text = "Redondeo ¢"
            '
            'lblEquivalencia
            '
            Me.lblEquivalencia.AutoSize = True
            Me.lblEquivalencia.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEquivalencia.Location = New System.Drawing.Point(49, 173)
            Me.lblEquivalencia.Name = "lblEquivalencia"
            Me.lblEquivalencia.Size = New System.Drawing.Size(96, 15)
            Me.lblEquivalencia.TabIndex = 239
            Me.lblEquivalencia.Text = "Conversión $ a ¢"
            '
            'lblMostrar_TotalGeneral
            '
            Me.lblMostrar_TotalGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrar_TotalGeneral.ForeColor = System.Drawing.Color.Blue
            Me.lblMostrar_TotalGeneral.Location = New System.Drawing.Point(170, 384)
            Me.lblMostrar_TotalGeneral.Name = "lblMostrar_TotalGeneral"
            Me.lblMostrar_TotalGeneral.Size = New System.Drawing.Size(217, 36)
            Me.lblMostrar_TotalGeneral.TabIndex = 244
            Me.lblMostrar_TotalGeneral.Text = "0.00"
            Me.lblMostrar_TotalGeneral.TextAlign = System.Drawing.ContentAlignment.BottomRight
            '
            'lblTotal_General
            '
            Me.lblTotal_General.AutoSize = True
            Me.lblTotal_General.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotal_General.Location = New System.Drawing.Point(96, 391)
            Me.lblTotal_General.Name = "lblTotal_General"
            Me.lblTotal_General.Size = New System.Drawing.Size(82, 29)
            Me.lblTotal_General.TabIndex = 243
            Me.lblTotal_General.Text = "Total ¢"
            '
            'lblMostrar_Otros
            '
            Me.lblMostrar_Otros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrar_Otros.Location = New System.Drawing.Point(155, 106)
            Me.lblMostrar_Otros.Name = "lblMostrar_Otros"
            Me.lblMostrar_Otros.Size = New System.Drawing.Size(105, 20)
            Me.lblMostrar_Otros.TabIndex = 246
            Me.lblMostrar_Otros.Text = "0.00"
            Me.lblMostrar_Otros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblOtros
            '
            Me.lblOtros.AutoSize = True
            Me.lblOtros.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblOtros.Location = New System.Drawing.Point(38, 109)
            Me.lblOtros.Name = "lblOtros"
            Me.lblOtros.Size = New System.Drawing.Size(103, 15)
            Me.lblOtros.TabIndex = 245
            Me.lblOtros.Text = "Egreso Efectivo ¢"
            '
            'lblMostrar_Vales
            '
            Me.lblMostrar_Vales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrar_Vales.Location = New System.Drawing.Point(153, 202)
            Me.lblMostrar_Vales.Name = "lblMostrar_Vales"
            Me.lblMostrar_Vales.Size = New System.Drawing.Size(105, 20)
            Me.lblMostrar_Vales.TabIndex = 248
            Me.lblMostrar_Vales.Text = "0.00"
            Me.lblMostrar_Vales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblVales
            '
            Me.lblVales.AutoSize = True
            Me.lblVales.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblVales.Location = New System.Drawing.Point(96, 202)
            Me.lblVales.Name = "lblVales"
            Me.lblVales.Size = New System.Drawing.Size(45, 15)
            Me.lblVales.TabIndex = 247
            Me.lblVales.Text = "Vales ¢"
            '
            'lblMostrar_Creditos
            '
            Me.lblMostrar_Creditos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrar_Creditos.Location = New System.Drawing.Point(165, 555)
            Me.lblMostrar_Creditos.Name = "lblMostrar_Creditos"
            Me.lblMostrar_Creditos.Size = New System.Drawing.Size(105, 20)
            Me.lblMostrar_Creditos.TabIndex = 250
            Me.lblMostrar_Creditos.Text = "0.00"
            Me.lblMostrar_Creditos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblCreditos
            '
            Me.lblCreditos.AutoSize = True
            Me.lblCreditos.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCreditos.Location = New System.Drawing.Point(70, 555)
            Me.lblCreditos.Name = "lblCreditos"
            Me.lblCreditos.Size = New System.Drawing.Size(85, 15)
            Me.lblCreditos.TabIndex = 249
            Me.lblCreditos.Text = "Por Créditos ¢"
            '
            'lblMostrar_OtrosIngresos
            '
            Me.lblMostrar_OtrosIngresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrar_OtrosIngresos.ForeColor = System.Drawing.Color.Blue
            Me.lblMostrar_OtrosIngresos.Location = New System.Drawing.Point(170, 332)
            Me.lblMostrar_OtrosIngresos.Name = "lblMostrar_OtrosIngresos"
            Me.lblMostrar_OtrosIngresos.Size = New System.Drawing.Size(217, 36)
            Me.lblMostrar_OtrosIngresos.TabIndex = 252
            Me.lblMostrar_OtrosIngresos.Text = "0.00"
            Me.lblMostrar_OtrosIngresos.TextAlign = System.Drawing.ContentAlignment.BottomRight
            '
            'lblOtros_Ingresos
            '
            Me.lblOtros_Ingresos.AutoSize = True
            Me.lblOtros_Ingresos.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblOtros_Ingresos.Location = New System.Drawing.Point(-2, 338)
            Me.lblOtros_Ingresos.Name = "lblOtros_Ingresos"
            Me.lblOtros_Ingresos.Size = New System.Drawing.Size(180, 29)
            Me.lblOtros_Ingresos.TabIndex = 251
            Me.lblOtros_Ingresos.Text = "Otros Ingresos ¢"
            '
            'ShapeContainer1
            '
            Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
            Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
            Me.ShapeContainer1.Name = "ShapeContainer1"
            Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
            Me.ShapeContainer1.Size = New System.Drawing.Size(388, 582)
            Me.ShapeContainer1.TabIndex = 253
            Me.ShapeContainer1.TabStop = False
            '
            'LineShape1
            '
            Me.LineShape1.BorderWidth = 5
            Me.LineShape1.Name = "LineShape1"
            Me.LineShape1.X1 = 0
            Me.LineShape1.X2 = 389
            Me.LineShape1.Y1 = 438
            Me.LineShape1.Y2 = 438
            '
            'lblMostrar_Ventas
            '
            Me.lblMostrar_Ventas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrar_Ventas.Location = New System.Drawing.Point(165, 522)
            Me.lblMostrar_Ventas.Name = "lblMostrar_Ventas"
            Me.lblMostrar_Ventas.Size = New System.Drawing.Size(105, 20)
            Me.lblMostrar_Ventas.TabIndex = 255
            Me.lblMostrar_Ventas.Text = "0.00"
            Me.lblMostrar_Ventas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblVentas
            '
            Me.lblVentas.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblVentas.Location = New System.Drawing.Point(78, 522)
            Me.lblVentas.Name = "lblVentas"
            Me.lblVentas.Size = New System.Drawing.Size(77, 20)
            Me.lblVentas.TabIndex = 254
            Me.lblVentas.Text = "Por Ventas ¢"
            '
            'lbl1
            '
            Me.lbl1.AutoSize = True
            Me.lbl1.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbl1.Location = New System.Drawing.Point(96, 455)
            Me.lbl1.Name = "lbl1"
            Me.lbl1.Size = New System.Drawing.Size(190, 26)
            Me.lbl1.TabIndex = 256
            Me.lbl1.Text = "Síntesis de Ingresos"
            '
            'FrmCaja
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(388, 582)
            Me.Controls.Add(Me.lbl1)
            Me.Controls.Add(Me.lblMostrar_Ventas)
            Me.Controls.Add(Me.lblVentas)
            Me.Controls.Add(Me.lblMostrar_OtrosIngresos)
            Me.Controls.Add(Me.lblOtros_Ingresos)
            Me.Controls.Add(Me.lblMostrar_Creditos)
            Me.Controls.Add(Me.lblCreditos)
            Me.Controls.Add(Me.lblMostrar_Vales)
            Me.Controls.Add(Me.lblVales)
            Me.Controls.Add(Me.lblMostrar_Otros)
            Me.Controls.Add(Me.lblOtros)
            Me.Controls.Add(Me.lblMostrar_TotalGeneral)
            Me.Controls.Add(Me.lblTotal_General)
            Me.Controls.Add(Me.lblMostrar_Equivalencia)
            Me.Controls.Add(Me.lblMostrar_Redondeo)
            Me.Controls.Add(Me.lblRedondeo)
            Me.Controls.Add(Me.lblEquivalencia)
            Me.Controls.Add(Me.btnLimpiar)
            Me.Controls.Add(Me.lblMostrar_Transf)
            Me.Controls.Add(Me.lblMostrar_Cheques)
            Me.Controls.Add(Me.lblMostrar_Tarjetas)
            Me.Controls.Add(Me.lblMostrar_Efectivo)
            Me.Controls.Add(Me.lblMostrarTotal)
            Me.Controls.Add(Me.lblTotal)
            Me.Controls.Add(Me.lblTransferencia)
            Me.Controls.Add(Me.Cheques)
            Me.Controls.Add(Me.lblTarjetas)
            Me.Controls.Add(Me.lblEfectivo)
            Me.Controls.Add(Me.lblFecha)
            Me.Controls.Add(Me.dtpFecha)
            Me.Controls.Add(Me.btnCalcular)
            Me.Controls.Add(Me.ShapeContainer1)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.KeyPreview = True
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmCaja"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Ingreso de Efectivo"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents lblFecha As System.Windows.Forms.Label
        Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
        Friend WithEvents btnCalcular As System.Windows.Forms.Button
        Friend WithEvents lblTransferencia As System.Windows.Forms.Label
        Friend WithEvents Cheques As System.Windows.Forms.Label
        Friend WithEvents lblTarjetas As System.Windows.Forms.Label
        Friend WithEvents lblEfectivo As System.Windows.Forms.Label
        Friend WithEvents lblMostrarTotal As System.Windows.Forms.Label
        Friend WithEvents lblTotal As System.Windows.Forms.Label
        Friend WithEvents lblMostrar_Efectivo As System.Windows.Forms.Label
        Friend WithEvents lblMostrar_Tarjetas As System.Windows.Forms.Label
        Friend WithEvents lblMostrar_Cheques As System.Windows.Forms.Label
        Friend WithEvents lblMostrar_Transf As System.Windows.Forms.Label
        Friend WithEvents btnLimpiar As System.Windows.Forms.Button
        Friend WithEvents lblMostrar_Equivalencia As System.Windows.Forms.Label
        Friend WithEvents lblMostrar_Redondeo As System.Windows.Forms.Label
        Friend WithEvents lblRedondeo As System.Windows.Forms.Label
        Friend WithEvents lblEquivalencia As System.Windows.Forms.Label
        Friend WithEvents lblMostrar_TotalGeneral As System.Windows.Forms.Label
        Friend WithEvents lblTotal_General As System.Windows.Forms.Label
        Friend WithEvents lblMostrar_Otros As System.Windows.Forms.Label
        Friend WithEvents lblOtros As System.Windows.Forms.Label
        Friend WithEvents lblMostrar_Vales As System.Windows.Forms.Label
        Friend WithEvents lblVales As System.Windows.Forms.Label
        Friend WithEvents lblMostrar_Creditos As System.Windows.Forms.Label
        Friend WithEvents lblCreditos As System.Windows.Forms.Label
        Friend WithEvents lblMostrar_OtrosIngresos As System.Windows.Forms.Label
        Friend WithEvents lblOtros_Ingresos As System.Windows.Forms.Label
        Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents lblMostrar_Ventas As System.Windows.Forms.Label
        Friend WithEvents lblVentas As System.Windows.Forms.Label
        Friend WithEvents lbl1 As System.Windows.Forms.Label
    End Class
End Namespace