Imports Entidades
Imports Logica_Negocios

Namespace Interfaz.Mantenimiento
    Public Class FrmCalcularReferencia

        Private ReadOnly _oLogicaReferencias As New LogicaReferencia
        Private ReadOnly _oUtilidades As New Utilidades

        Private Sub FrmCalcular_Referencia_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            Dim fecha = CDate(FrmReferencias.lblFechaCalculo.Text)
            Dim primer = DateSerial(fecha.Year, fecha.Month, fecha.Day)

            dtpInicio.Value = New DateTime(primer.Year, primer.Month, primer.Day + 1)
            dtpFinal.Value = New DateTime(Now.Year, Now.Month, Now.Day)

            Dim listaBitacora = _oLogicaReferencias.consultarBitacoras(CInt(txtId_Referencia.Text))

            LlenarBitocara(listaBitacora)
            FormatoDgvBitacora()
            CalcularReferencia()
        End Sub

        Private Sub LlenarBitocara(ByVal lista As List(Of BitacoraReferencia))
            For i = 0 To lista.Count - 1
                dgvBitacora.Rows.Add(lista(i).Linea1)
                dgvBitacora.Rows.Add(lista(i).Linea2)
            Next i
        End Sub

        Private Sub FormatoDgvBitacora()
            With dgvBitacora

                For i = 0 To .Rows.Count - 2
                    .Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255)
                    .Rows(i + 1).DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255)
                Next

                For i = 0 To .Rows.Count - 2
                    .Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(196, 173, 151)
                    .Rows(i + 1).DefaultCellStyle.BackColor = Color.FromArgb(196, 173, 151)
                    i = i + 3
                Next
            End With
        End Sub

        Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCalcular.Click
            If CDate(FrmReferencias.lblFechaCalculo.Text) <= dtpInicio.Value Then
                CalcularReferencia()
            Else
                MsgBox("La fecha de inicio no debe ser menor al último cálculo")
            End If
        End Sub

        Private Sub CalcularReferencia()
            Dim total = _oLogicaReferencias.calcularReferencia(CInt(txtId_Referencia.Text), dtpInicio.Value, dtpFinal.Value)
            lblMostrarTotal.Text = _oUtilidades.PasarMoneda(total)
            lblMostrarReferencia.Text = _oUtilidades.PasarMoneda((total * CDbl(txtDescuentoGen.Text)) / 100)
        End Sub

        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            If CDbl(lblMostrarTotal.Text) > 0 Then
                Dim linea = "Periodo del " & dtpInicio.Value & " al " & dtpFinal.Value
                Dim linea2 = "Monto Facturas ¢" & lblMostrarTotal.Text & " Total Referencia ¢" & lblMostrarReferencia.Text

                Dim oBitacora As New BitacoraReferencia
                oBitacora.IdReferencia = CInt(txtId_Referencia.Text)
                oBitacora.Linea1 = linea
                oBitacora.Linea2 = linea2

                Dim oReferencia As New Referencia
                oReferencia.IdReferencia = CInt(txtId_Referencia.Text)
                oReferencia.UltimoCalculo = dtpFinal.Value

                _oLogicaReferencias.guardarUltimo_Calculo(oBitacora, oReferencia)
                MsgBox("Cálculo guardo con éxito...")

                lblMostrarTotal.Text = 0.0
                lblMostrarReferencia.Text = 0.0

                Dim fecha = dtpFinal.Value
                Dim primer = DateSerial(fecha.Year, fecha.Month, fecha.Day + 1)

                dtpInicio.Value = New DateTime(primer.Year, primer.Month, primer.Day)
                dtpFinal.Value = New DateTime(Now.Year, Now.Month, Now.Day)

                dgvBitacora.Rows.Add(linea)
                dgvBitacora.Rows.Add(linea2)
                FormatoDgvBitacora()
            Else
                MsgBox("Debe calcular el monto de referencia antes de guardarlo")
            End If

        End Sub

        Private Sub FrmCalcular_Referencia_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub
    End Class
End Namespace