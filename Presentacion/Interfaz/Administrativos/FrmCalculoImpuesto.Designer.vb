Imports Logica_Negocios
Imports Entidades
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCalculoImpuesto
    Inherits System.Windows.Forms.Form

    Private oLogica_Varios As New LogicaVarios

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
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpFinal = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaInicial = New System.Windows.Forms.Label()
        Me.lblFechaFinal = New System.Windows.Forms.Label()
        Me.lblSubVentas = New System.Windows.Forms.Label()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.txtTotalDescuentos = New System.Windows.Forms.TextBox()
        Me.lblTotalDescuentos = New System.Windows.Forms.Label()
        Me.txtImpuestoNormal = New System.Windows.Forms.TextBox()
        Me.lblImpuestoNormal = New System.Windows.Forms.Label()
        Me.txtImpuestoParcial = New System.Windows.Forms.TextBox()
        Me.lblImpuestoParcial = New System.Windows.Forms.Label()
        Me.txtVentasExcentas = New System.Windows.Forms.TextBox()
        Me.lblVentasExcentas = New System.Windows.Forms.Label()
        Me.txtServiciosEspeciales = New System.Windows.Forms.TextBox()
        Me.lblServiciosEspeciales = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'dtpInicio
        '
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicio.Location = New System.Drawing.Point(146, 23)
        Me.dtpInicio.MaxDate = New Date(3000, 12, 31, 0, 0, 0, 0)
        Me.dtpInicio.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(99, 20)
        Me.dtpInicio.TabIndex = 217
        Me.dtpInicio.Value = New Date(2011, 12, 27, 0, 0, 0, 0)
        '
        'dtpFinal
        '
        Me.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFinal.Location = New System.Drawing.Point(249, 23)
        Me.dtpFinal.MaxDate = New Date(3000, 12, 31, 0, 0, 0, 0)
        Me.dtpFinal.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtpFinal.Name = "dtpFinal"
        Me.dtpFinal.Size = New System.Drawing.Size(99, 20)
        Me.dtpFinal.TabIndex = 218
        Me.dtpFinal.Value = New Date(2011, 12, 27, 0, 0, 0, 0)
        '
        'lblFechaInicial
        '
        Me.lblFechaInicial.AutoSize = True
        Me.lblFechaInicial.Location = New System.Drawing.Point(146, 8)
        Me.lblFechaInicial.Name = "lblFechaInicial"
        Me.lblFechaInicial.Size = New System.Drawing.Size(67, 13)
        Me.lblFechaInicial.TabIndex = 219
        Me.lblFechaInicial.Text = "Fecha Inicial"
        '
        'lblFechaFinal
        '
        Me.lblFechaFinal.AutoSize = True
        Me.lblFechaFinal.Location = New System.Drawing.Point(246, 8)
        Me.lblFechaFinal.Name = "lblFechaFinal"
        Me.lblFechaFinal.Size = New System.Drawing.Size(62, 13)
        Me.lblFechaFinal.TabIndex = 220
        Me.lblFechaFinal.Text = "Fecha Final"
        '
        'lblSubVentas
        '
        Me.lblSubVentas.AutoSize = True
        Me.lblSubVentas.Location = New System.Drawing.Point(13, 64)
        Me.lblSubVentas.Name = "lblSubVentas"
        Me.lblSubVentas.Size = New System.Drawing.Size(101, 13)
        Me.lblSubVentas.TabIndex = 221
        Me.lblSubVentas.Text = "SubTotal de Ventas"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.Location = New System.Drawing.Point(12, 80)
        Me.txtSubTotal.Multiline = True
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(322, 39)
        Me.txtSubTotal.TabIndex = 222
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalDescuentos
        '
        Me.txtTotalDescuentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDescuentos.Location = New System.Drawing.Point(12, 149)
        Me.txtTotalDescuentos.Multiline = True
        Me.txtTotalDescuentos.Name = "txtTotalDescuentos"
        Me.txtTotalDescuentos.Size = New System.Drawing.Size(322, 39)
        Me.txtTotalDescuentos.TabIndex = 224
        Me.txtTotalDescuentos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTotalDescuentos
        '
        Me.lblTotalDescuentos.AutoSize = True
        Me.lblTotalDescuentos.Location = New System.Drawing.Point(13, 133)
        Me.lblTotalDescuentos.Name = "lblTotalDescuentos"
        Me.lblTotalDescuentos.Size = New System.Drawing.Size(91, 13)
        Me.lblTotalDescuentos.TabIndex = 223
        Me.lblTotalDescuentos.Text = "Total Descuentos"
        '
        'txtImpuestoNormal
        '
        Me.txtImpuestoNormal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpuestoNormal.Location = New System.Drawing.Point(14, 214)
        Me.txtImpuestoNormal.Multiline = True
        Me.txtImpuestoNormal.Name = "txtImpuestoNormal"
        Me.txtImpuestoNormal.Size = New System.Drawing.Size(322, 39)
        Me.txtImpuestoNormal.TabIndex = 226
        Me.txtImpuestoNormal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblImpuestoNormal
        '
        Me.lblImpuestoNormal.AutoSize = True
        Me.lblImpuestoNormal.Location = New System.Drawing.Point(15, 198)
        Me.lblImpuestoNormal.Name = "lblImpuestoNormal"
        Me.lblImpuestoNormal.Size = New System.Drawing.Size(86, 13)
        Me.lblImpuestoNormal.TabIndex = 225
        Me.lblImpuestoNormal.Text = "Impuesto Normal"
        '
        'txtImpuestoParcial
        '
        Me.txtImpuestoParcial.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpuestoParcial.Location = New System.Drawing.Point(11, 288)
        Me.txtImpuestoParcial.Multiline = True
        Me.txtImpuestoParcial.Name = "txtImpuestoParcial"
        Me.txtImpuestoParcial.Size = New System.Drawing.Size(322, 39)
        Me.txtImpuestoParcial.TabIndex = 228
        Me.txtImpuestoParcial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblImpuestoParcial
        '
        Me.lblImpuestoParcial.AutoSize = True
        Me.lblImpuestoParcial.Location = New System.Drawing.Point(12, 272)
        Me.lblImpuestoParcial.Name = "lblImpuestoParcial"
        Me.lblImpuestoParcial.Size = New System.Drawing.Size(85, 13)
        Me.lblImpuestoParcial.TabIndex = 227
        Me.lblImpuestoParcial.Text = "Impuesto Parcial"
        '
        'txtVentasExcentas
        '
        Me.txtVentasExcentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVentasExcentas.Location = New System.Drawing.Point(8, 357)
        Me.txtVentasExcentas.Multiline = True
        Me.txtVentasExcentas.Name = "txtVentasExcentas"
        Me.txtVentasExcentas.Size = New System.Drawing.Size(322, 39)
        Me.txtVentasExcentas.TabIndex = 230
        Me.txtVentasExcentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblVentasExcentas
        '
        Me.lblVentasExcentas.AutoSize = True
        Me.lblVentasExcentas.Location = New System.Drawing.Point(9, 341)
        Me.lblVentasExcentas.Name = "lblVentasExcentas"
        Me.lblVentasExcentas.Size = New System.Drawing.Size(87, 13)
        Me.lblVentasExcentas.TabIndex = 229
        Me.lblVentasExcentas.Text = "Ventas Excentas"
        '
        'txtServiciosEspeciales
        '
        Me.txtServiciosEspeciales.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServiciosEspeciales.Location = New System.Drawing.Point(14, 432)
        Me.txtServiciosEspeciales.Multiline = True
        Me.txtServiciosEspeciales.Name = "txtServiciosEspeciales"
        Me.txtServiciosEspeciales.Size = New System.Drawing.Size(322, 39)
        Me.txtServiciosEspeciales.TabIndex = 232
        Me.txtServiciosEspeciales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblServiciosEspeciales
        '
        Me.lblServiciosEspeciales.AutoSize = True
        Me.lblServiciosEspeciales.Location = New System.Drawing.Point(15, 416)
        Me.lblServiciosEspeciales.Name = "lblServiciosEspeciales"
        Me.lblServiciosEspeciales.Size = New System.Drawing.Size(116, 13)
        Me.lblServiciosEspeciales.TabIndex = 231
        Me.lblServiciosEspeciales.Text = "Servicios Profesionales"
        '
        'btnCalcular
        '
        Me.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalcular.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Image = Global.Presentacion.My.Resources.Resources.sumar
        Me.btnCalcular.Location = New System.Drawing.Point(70, 0)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(71, 57)
        Me.btnCalcular.TabIndex = 214
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImprimir.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = Global.Presentacion.My.Resources.Resources.Imprimir
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimir.Location = New System.Drawing.Point(0, 0)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(71, 57)
        Me.btnImprimir.TabIndex = 233
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'FrmCalculoImpuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 490)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.txtServiciosEspeciales)
        Me.Controls.Add(Me.lblServiciosEspeciales)
        Me.Controls.Add(Me.txtVentasExcentas)
        Me.Controls.Add(Me.lblVentasExcentas)
        Me.Controls.Add(Me.txtImpuestoParcial)
        Me.Controls.Add(Me.lblImpuestoParcial)
        Me.Controls.Add(Me.txtImpuestoNormal)
        Me.Controls.Add(Me.lblImpuestoNormal)
        Me.Controls.Add(Me.txtTotalDescuentos)
        Me.Controls.Add(Me.lblTotalDescuentos)
        Me.Controls.Add(Me.txtSubTotal)
        Me.Controls.Add(Me.lblSubVentas)
        Me.Controls.Add(Me.lblFechaFinal)
        Me.Controls.Add(Me.lblFechaInicial)
        Me.Controls.Add(Me.dtpFinal)
        Me.Controls.Add(Me.dtpInicio)
        Me.Controls.Add(Me.btnCalcular)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCalculoImpuesto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculo Impuesto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaInicial As System.Windows.Forms.Label
    Friend WithEvents lblFechaFinal As System.Windows.Forms.Label
    Friend WithEvents lblSubVentas As System.Windows.Forms.Label
    Friend WithEvents txtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalDescuentos As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalDescuentos As System.Windows.Forms.Label
    Friend WithEvents txtImpuestoNormal As System.Windows.Forms.TextBox
    Friend WithEvents lblImpuestoNormal As System.Windows.Forms.Label
    Friend WithEvents txtImpuestoParcial As System.Windows.Forms.TextBox
    Friend WithEvents lblImpuestoParcial As System.Windows.Forms.Label
    Friend WithEvents txtVentasExcentas As System.Windows.Forms.TextBox
    Friend WithEvents lblVentasExcentas As System.Windows.Forms.Label
    Friend WithEvents txtServiciosEspeciales As System.Windows.Forms.TextBox
    Friend WithEvents lblServiciosEspeciales As System.Windows.Forms.Label

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        Dim logica_General As New Logica_Negocios.LogicaGenerales
        Dim oUtilidades As New Logica_Negocios.Utilidades

        txtSubTotal.Text = oUtilidades.PasarMoneda(logica_General.calSubTotalVentas(dtpInicio.Value, dtpFinal.Value))
        txtTotalDescuentos.Text = oUtilidades.PasarMoneda(logica_General.calTotalDescuentos(dtpInicio.Value, dtpFinal.Value))
        txtImpuestoNormal.Text = oUtilidades.PasarMoneda(logica_General.calImpuestoNormal(dtpInicio.Value, dtpFinal.Value))
        txtImpuestoParcial.Text = oUtilidades.PasarMoneda(logica_General.calTImpuestoParcial(dtpInicio.Value, dtpFinal.Value))
        txtVentasExcentas.Text = oUtilidades.PasarMoneda(logica_General.calTVentasExcentas(dtpInicio.Value, dtpFinal.Value))
        txtServiciosEspeciales.Text = oUtilidades.PasarMoneda(logica_General.calTVentasServiciosProfesionales(dtpInicio.Value, dtpFinal.Value))
    End Sub

    Private Sub FrmCalculoImpuesto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Primer = DateSerial(Now.Year, Now.Month + 0, 1)
        Dim Ultimo = DateSerial(Now.Year, Now.Month + 1, 0)


        dtpInicio.Value = New DateTime(Primer.Year, Primer.Month, Primer.Day)
        dtpFinal.Value = New DateTime(Ultimo.Year, Ultimo.Month, Ultimo.Day)

    End Sub
    Friend WithEvents btnImprimir As System.Windows.Forms.Button

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnImprimir.Click
        Dim imprime As Integer
        imprime = MessageBox.Show("Esta seguro q desea imprimir este cálculo?", "Imprimir cálculo de impuesto", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If imprime = vbYes Then

            Dim rptCalculo As New RptCalculoImpuesto

            With rptCalculo
                .SetParameterValue("subTotalVentas", txtSubTotal.Text)
                .SetParameterValue("totalDescuentos", txtTotalDescuentos.Text)
                .SetParameterValue("impuestoNormal", txtImpuestoNormal.Text)
                .SetParameterValue("impuestoParcial", txtImpuestoParcial.Text)
                .SetParameterValue("ventasExcentas", txtVentasExcentas.Text)
                .SetParameterValue("serviciosProfesionales", txtServiciosEspeciales.Text)

                .SetParameterValue("mes", "Mes " & dtpInicio.Value.Month & " / " & dtpInicio.Value.Year)

                Dim nombre_Impresora = oLogica_Varios.ConsultarColumna("Imp_Medio_Oficio")
                Dim nombre_PC = oLogica_Varios.ConsultarColumna("PC_Medio_Oficio")
                .PrintOptions.PrinterName = "\\" & nombre_PC & "\" & nombre_Impresora
                .PrintToPrinter(1, False, 1, 1)
            End With
        End If
    End Sub

    Private Sub FrmCalculoImpuesto_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
End Class
