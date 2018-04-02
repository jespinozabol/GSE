Imports Entidades
Imports Logica_Negocios

Namespace Interfaz.Creditos
    Public Class FrmNotaCreditoGeneral

        Private ReadOnly _oLogicaConsecutivo As New LogicaConsecutivo
        Private ReadOnly _oUtilidades As New Utilidades
        Private ReadOnly _oLogicaImpuesto As New LogicaImpuesto
        Private ReadOnly _oLogicaNc As New LogicaNotaCredito
        Private ReadOnly _oLogicaClienteCredito As New LogicaClienteCredito
        Private ReadOnly _oLogicaVarios As New LogicaVarios

        Private Sub numNota_Credito_Tick(ByVal sender As System.Object, ByVal e As EventArgs) Handles numNota_Credito.Tick
            lblMostrarReciboNotas.Text = _oLogicaConsecutivo.ConsultarMaxConsecutivo("CONSECUTIVO_NC") + 1
        End Sub

        Private Sub chkImpuesto_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkImpuesto.CheckedChanged
            If chkImpuesto.Checked Then
                txtImpuesto.Enabled = True
                txtImpuesto.Text = _oLogicaImpuesto.consultarImpuesto
                txtTotal.Text = _oUtilidades.PasarMoneda(CDbl(txtMonto.Text) + (CDbl(txtMonto.Text) * (CDbl(txtImpuesto.Text) / 100)))
                txtMotivo.Focus()
            Else
                txtImpuesto.Enabled = False
                txtImpuesto.Text = 0
                txtTotal.Text = _oUtilidades.PasarMoneda(CDbl(txtMonto.Text))
            End If
        End Sub

        Private Sub txtMonto_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtMonto.KeyDown
            If e.KeyValue = 13 Then
                If IsNumeric(txtMonto.Text) Then
                    txtTotal.Text = _oUtilidades.PasarMoneda(txtMonto.Text)
                End If

                txtMotivo.Focus()
            End If
        End Sub

        Private Sub FrmNota_CreditoGeneral_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            AddHandler txtMonto.KeyPress, AddressOf ValidarNumerosPunto
            AddHandler txtImpuesto.KeyPress, AddressOf ValidarNumerosPunto
        End Sub

        Private Sub btnNota_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNota.Click
            If txtMonto.Text <> "" And txtMotivo.Text <> "" Then
                If CDbl(txtMonto.Text) > 0 Then
                    Dim respuesta As String

                    respuesta = MsgBox("Esta seguro que desea imprimir esta nota de crédito?", vbCritical + vbYesNo, "Realizar Transacción...")

                    If respuesta = vbYes Then

                        _oLogicaNc.RevisaBloqueo()
                        _oLogicaNc.Bloqueo(True)

                        Dim notaCreditoGeneral As New NotaCreditoGeneral
                        notaCreditoGeneral.Fecha = Now.ToString("dd/MM/yyyy")
                        notaCreditoGeneral.IdNC = CInt(lblMostrarReciboNotas.Text)
                        notaCreditoGeneral.IdClienteCredito = CInt(txtId_Credito.Text)
                        notaCreditoGeneral.Estado = NotaCreditoGeneral.ListaEstado.Pendiente
                        notaCreditoGeneral.Motivo = UCase(txtMotivo.Text)

                        If chkImpuesto.Checked Then
                            notaCreditoGeneral.Impuesto = CDbl(txtImpuesto.Text)
                            notaCreditoGeneral.Monto = CDbl(txtTotal.Text)
                        Else
                            notaCreditoGeneral.Impuesto = 0
                            notaCreditoGeneral.Monto = CDbl(txtTotal.Text)
                        End If

                        _oLogicaNc.insertar_General(notaCreditoGeneral)

                        Dim oCliente As New ClienteCredito
                        oCliente.IdCredito = CInt(txtId_Credito.Text)
                        oCliente.TotalCreditos = CDbl(txtTotal.Text)
                        _oLogicaClienteCredito.restaTotal_Creditos(oCliente)

                        imprimeNota_Credito()

                        Dim oConsecutivoReciboFact As New Consecutivo
                        oConsecutivoReciboFact.Tabla = "CONSECUTIVO_NC"
                        _oLogicaConsecutivo.AumentarConsecutivo(oConsecutivoReciboFact)

                        _oLogicaNc.Bloqueo(False)

                        FrmFacturaCredito.dgvFacturas.Rows.Clear()
                        FrmFacturaCredito.CargarDatos(CInt(txtId_Credito.Text))
                        Dispose()
                    End If
                Else
                    MsgBox("El monto debe ser mayor a cero", MsgBoxStyle.Exclamation)
                End If
            Else
                MsgBox("Debe de especificar el monto y el motivo antes de imprimir la nota de crédito", MsgBoxStyle.Exclamation)
            End If
        End Sub

        Private Sub imprimeNota_Credito()

            Dim reporte As New RptNC_General
            reporte.SetParameterValue("cliente", txtNombreCliente.Text)
            reporte.SetParameterValue("numNota", "#" & lblMostrarReciboNotas.Text)
            reporte.SetParameterValue("motivo", UCase(Trim(txtMotivo.Text)))
            reporte.SetParameterValue("fecha", Now.Date)
            reporte.SetParameterValue("total", CDbl(txtTotal.Text))

            Dim copias = _oUtilidades.NumCopias(txtNum_Impresiones.Text, 2)
            Dim nombreImpresora = _oLogicaVarios.ConsultarColumna("Imp_Tercio_Oficio")
            Dim nombrePc = _oLogicaVarios.ConsultarColumna("PC_Tercio_Oficio")
            reporte.PrintOptions.PrinterName = "\\" & nombrePc & "\" & nombreImpresora
            reporte.PrintToPrinter(copias, False, 1, 1)
        End Sub

        Private Sub txtImpuesto_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtImpuesto.KeyDown
            If e.KeyValue = 13 Then
                If txtMonto.Text <> "" Then
                    If CDbl(txtMonto.Text) > 0 Then
                        txtTotal.Text = _oUtilidades.PasarMoneda(CDbl(txtMonto.Text) + (CDbl(txtMonto.Text) * (CDbl(txtImpuesto.Text) / 100)))
                    End If
                End If
            End If
        End Sub

        Private Sub txtMonto_Leave(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtMonto.Leave
            If IsNumeric(txtMonto.Text) Then
                txtTotal.Text = _oUtilidades.PasarMoneda(txtMonto.Text)
            End If
        End Sub

        Private Sub chkImpresion_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkImpresion.CheckedChanged
            If chkImpresion.Checked Then
                txtNum_Impresiones.Enabled = False
                txtNum_Impresiones.ReadOnly = True
                txtNum_Impresiones.Text = 2
            Else
                txtNum_Impresiones.Enabled = True
                txtNum_Impresiones.ReadOnly = False
                txtNum_Impresiones.Focus()
            End If
        End Sub

        Private Sub FrmNota_CreditoGeneral_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub
    End Class
End Namespace