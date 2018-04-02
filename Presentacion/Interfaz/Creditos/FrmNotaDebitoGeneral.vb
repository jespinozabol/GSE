Imports Entidades
Imports Logica_Negocios

Namespace Interfaz.Creditos
    Public Class FrmNotaDebitoGeneral

        Private ReadOnly _oLogicaConsecutivo As New LogicaConsecutivo
        Private ReadOnly _oUtilidades As New Utilidades
        Private ReadOnly _oLogicaImpuesto As New LogicaImpuesto
        Private ReadOnly _oLogicaNd As New LogicaNotaDebito
        Private ReadOnly _oLogicaClienteCredito As New LogicaClienteCredito
        Private ReadOnly _oLogicaVarios As New LogicaVarios

        Private Sub numNota_Debito_Tick(ByVal sender As System.Object, ByVal e As EventArgs) Handles numNota_Debito.Tick
            lblMostrarReciboNotas.Text = _oLogicaConsecutivo.ConsultarMaxConsecutivo("CONSECUTIVO_ND") + 1
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

        Private Sub FrmNota_DebitoGeneral_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            AddHandler txtMonto.KeyPress, AddressOf ValidarNumerosPunto
            AddHandler txtImpuesto.KeyPress, AddressOf ValidarNumerosPunto
            AddHandler txtNum_Impresiones.KeyPress, AddressOf ValidarSoloNumeros
            AddHandler txtDiasPlazo.KeyPress, AddressOf ValidarSoloNumeros
        End Sub

        Private Sub txtImpuesto_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtImpuesto.KeyDown
            If e.KeyValue = 13 Then
                If txtMonto.Text <> "" Then
                    If CDbl(txtMonto.Text) > 0 Then
                        txtTotal.Text = _oUtilidades.PasarMoneda(CDbl(txtMonto.Text) + (CDbl(txtMonto.Text) * (CDbl(txtImpuesto.Text) / 100)))
                    End If
                End If
                txtDiasPlazo.Focus()
            End If
        End Sub

        Private Sub txtMonto_Leave(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtMonto.Leave
            If IsNumeric(txtMonto.Text) Then
                txtTotal.Text = _oUtilidades.PasarMoneda(txtMonto.Text)
            End If
        End Sub

        Private Sub btnNota_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNota.Click
            If txtMonto.Text <> "" And txtMotivo.Text <> "" Then
                If CDbl(txtMonto.Text) > 0 Then
                    Dim respuesta As String

                    respuesta = MsgBox("Esta seguro que desea imprimir esta nota de débito?", vbQuestion + vbYesNo, "Realizar Transacción...")

                    If (respuesta = vbYes) Then

                        _oLogicaNd.RevisaBloqueo()
                        _oLogicaNd.Bloqueo(True)

                        Dim notaDebitoGeneral As New NotaDebitoGeneral
                        notaDebitoGeneral.Fecha = Now.ToString("dd/MM/yyyy")
                        notaDebitoGeneral.IdND = CInt(lblMostrarReciboNotas.Text)
                        notaDebitoGeneral.IdClienteCredito = CInt(txtId_Credito.Text)
                        notaDebitoGeneral.Estado = NotaDebitoGeneral.ListaEstado.NoAplicada
                        notaDebitoGeneral.Motivo = UCase(txtMotivo.Text)

                        If chkImpuesto.Checked Then
                            notaDebitoGeneral.Impuesto = CDbl(txtImpuesto.Text)
                            notaDebitoGeneral.Monto = CDbl(txtTotal.Text)
                        Else
                            notaDebitoGeneral.Impuesto = 0
                            notaDebitoGeneral.Monto = CDbl(txtTotal.Text)
                        End If

                        If txtDiasPlazo.Text <> String.Empty Then
                            notaDebitoGeneral.NumDias = CInt(txtDiasPlazo.Text)
                        Else
                            notaDebitoGeneral.NumDias = 30
                        End If

                        _oLogicaNd.insertar_General(notaDebitoGeneral)

                        Dim oCliente As New ClienteCredito
                        oCliente.IdCredito = CInt(txtId_Credito.Text)
                        oCliente.TotalCreditos = CDbl(txtTotal.Text)
                        _oLogicaClienteCredito.restaTotal_Creditos(oCliente)

                        ImprimeNotaDebito()

                        Dim oConsecutivoNotaDebito As New Consecutivo
                        oConsecutivoNotaDebito.Tabla = "CONSECUTIVO_ND"
                        _oLogicaConsecutivo.AumentarConsecutivo(oConsecutivoNotaDebito)

                        _oLogicaNd.Bloqueo(False)

                        FrmFacturaCredito.dgvFacturas.Rows.Clear()
                        FrmFacturaCredito.CargarDatos(CInt(txtId_Credito.Text))
                        Dispose()
                    End If
                Else
                    MsgBox("El monto debe ser mayor a cero", MsgBoxStyle.Exclamation)
                End If
            Else
                MsgBox("Debe de especificar el monto y el motivo antes de imprimir la nota de débito", MsgBoxStyle.Exclamation)
            End If
        End Sub

        Private Sub ImprimeNotaDebito()

            Dim reporte As New RptND_General

            reporte.SetParameterValue("cliente", txtNombreCliente.Text)
            reporte.SetParameterValue("numNota", "#" & lblMostrarReciboNotas.Text)
            reporte.SetParameterValue("motivo", UCase(Trim(txtMotivo.Text)))
            reporte.SetParameterValue("total", CDbl(txtTotal.Text))
            reporte.SetParameterValue("fecha", Now.Date)

            Dim copias = _oUtilidades.NumCopias(txtNum_Impresiones.Text, 2)
            Dim nombreImpresora = _oLogicaVarios.ConsultarColumna("Imp_Tercio_Oficio")
            Dim nombrePc = _oLogicaVarios.ConsultarColumna("PC_Tercio_Oficio")
            reporte.PrintOptions.PrinterName = "\\" & nombrePc & "\" & nombreImpresora
            reporte.PrintToPrinter(copias, False, 1, 1)
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

        Private Sub FrmNota_DebitoGeneral_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub
    End Class
End Namespace