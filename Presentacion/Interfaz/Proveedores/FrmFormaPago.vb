Imports Entidades
Imports Logica_Negocios

Namespace Interfaz.Proveedores
    Public Class FrmFormaPago

        Private ReadOnly _oReciboDocPorPagar As New ReciboDocPorPagar
        Private ReadOnly _oUtilidades As New Utilidades
        Public CadenaCheque As String
        Public CadenaTrans As String
        Private _suma As Double = 0.0

        Private Sub FrmForma_Pago_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            lblMostrarTotal.Text = FrmCancelacionDeFacturasPorProveedor.lblMostrarAbono.Text
            txtEfectivo.Text = lblMostrarTotal.Text
            txtObservaciones.Text = String.Empty
            AddHandler txtFechaCanc.KeyPress, AddressOf FormatoFecha
            AddHandler txtFechaRecibo.KeyPress, AddressOf FormatoFecha

            AddHandler txtEfectivo.KeyPress, AddressOf ValidarNumerosPunto
            AddHandler txtCheques.KeyPress, AddressOf ValidarNumerosPunto
            AddHandler txtTransferencia.KeyPress, AddressOf ValidarNumerosPunto
            AddHandler txtEfectivo_Dolares.KeyPress, AddressOf ValidarNumerosPunto
            AddHandler txtTipo_Cambio.KeyPress, AddressOf ValidarNumerosPunto
            AddHandler txtMonto_Dolares.KeyPress, AddressOf ValidarNumerosPunto
        End Sub

        Private Sub txtTransferencia_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtTransferencia.KeyDown
            If e.KeyData = Keys.Enter Then
                txtFechaCanc.Focus()
                ValidarActualizar()
            ElseIf e.KeyValue = 40 Then
                btnAceptar.Focus()
            ElseIf e.KeyValue = 38 Then
                txtCheques.Focus()
            End If
        End Sub

        Private Sub txtEfectivo_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtEfectivo.KeyDown
            If e.KeyData = Keys.Enter Then
                txtFechaCanc.Focus()
                ValidarActualizar()
            ElseIf e.KeyValue = 40 Then
                txtCheques.Focus()
            End If
        End Sub

        Private Sub txtCheques_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtCheques.KeyDown
            If e.KeyData = Keys.Enter Then
                txtFechaCanc.Focus()
                ValidarActualizar()
            ElseIf e.KeyValue = 40 Then
                txtTransferencia.Focus()
            ElseIf e.KeyValue = 38 Then
                txtEfectivo.Focus()
            End If
        End Sub

        Private Function ValidarActualizar() As Boolean
            Dim valido = False
            _suma = 0.0
            If IsNumeric(txtEfectivo.Text) Then
                If txtEfectivo.Text > 0 Then
                    _suma = CDbl(txtEfectivo.Text)
                    _oReciboDocPorPagar.TotalEfectivo = _oUtilidades.PasarMoneda(CDbl(txtEfectivo.Text))
                    valido = True
                Else
                    _oReciboDocPorPagar.TotalEfectivo = 0
                End If
            Else
                _oReciboDocPorPagar.TotalEfectivo = 0
            End If

            If IsNumeric(txtCheques.Text) Then
                If txtCheques.Text > 0 Then
                    _suma = _suma + CDbl(txtCheques.Text)
                    _oReciboDocPorPagar.TotalCheques = _oUtilidades.PasarMoneda(CDbl(txtCheques.Text))
                    valido = True
                Else
                    _oReciboDocPorPagar.TotalCheques = 0
                End If
            Else
                _oReciboDocPorPagar.TotalCheques = 0
            End If

            If IsNumeric(txtTransferencia.Text) Then
                If txtTransferencia.Text > 0 Then
                    _suma = _suma + CDbl(txtTransferencia.Text)
                    _oReciboDocPorPagar.TotalTransferencias = _oUtilidades.PasarMoneda(CDbl(txtTransferencia.Text))
                    valido = True
                Else
                    _oReciboDocPorPagar.TotalTransferencias = 0
                End If
            Else
                _oReciboDocPorPagar.TotalTransferencias = 0
            End If

            If IsNumeric(txtEfectivo_Dolares.Text) Then
                If txtEfectivo_Dolares.Text > 0 Then
                    _suma = _suma + CDbl(txtEfectivo_Dolares.Text)
                    _oReciboDocPorPagar.TotalDolares = _oUtilidades.PasarMoneda(CDbl(txtEfectivo_Dolares.Text))
                    valido = True
                Else
                    _oReciboDocPorPagar.TotalDolares = 0
                End If
            Else
                _oReciboDocPorPagar.TotalDolares = 0
            End If

            _oReciboDocPorPagar.NumReciboProveedor = txtNum_Recibo.Text

            Return valido
        End Function

        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelar.Click
            FrmCancelacionDeFacturasPorProveedor.EstadoFlujoCaja = False
            Dispose()
        End Sub

        Private Sub chkEfectivo_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkEfectivo.CheckedChanged
            LimpiarCamposTexto()
            If chkEfectivo.Checked Then
                txtEfectivo.Enabled = True
                txtEfectivo.Focus()
                DesactivarVacias(sender)
                If Not chkCheques.Checked And Not chkTransf.Checked And Not chkDolares.Checked Then
                    txtEfectivo.Text = lblMonto.Text
                End If
            Else
                txtEfectivo.Text = String.Empty
                txtEfectivo.Enabled = False
                ValidarActualizar()
            End If
        End Sub

        Private Sub LimpiarCamposTexto()
            lblMonto.Text = String.Empty
        End Sub

        Private Sub DesactivarVacias(ByVal e As CheckBox)
            If e.Name <> chkEfectivo.Name And txtEfectivo.Text = "" Then
                chkEfectivo.Checked = False
            End If

            If e.Name <> chkDolares.Name And txtEfectivo_Dolares.Text = "" Then
                chkDolares.Checked = False
            End If

            If e.Name <> chkCheques.Name And txtCheques.Text = "" Then
                chkCheques.Checked = False
            End If

            If e.Name <> chkTransf.Name And txtTransferencia.Text = "" Then
                chkTransf.Checked = False
            End If
        End Sub

        Private Sub chkCheques_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkCheques.CheckedChanged
            LimpiarCamposTexto()
            If chkCheques.Checked Then
                txtCheques.Enabled = True
                txtCheques.Focus()
                DesactivarVacias(sender)
                If Not chkEfectivo.Checked And Not chkTransf.Checked And Not chkDolares.Checked Then
                    txtCheques.Text = lblMostrarTotal.Text
                End If
                FrmChequeTransDocPorPagar.Tipo = 1
                FrmChequeTransDocPorPagar.txtMonto1.Text = _oUtilidades.PasarMoneda(CDbl(lblMostrarTotal.Text))
                FrmChequeTransDocPorPagar.ShowDialog()
            Else
                txtCheques.Text = String.Empty
                txtCheques.Enabled = False
                ValidarActualizar()
            End If
        End Sub

        Private Sub chkTransf_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkTransf.CheckedChanged
            LimpiarCamposTexto()
            If chkTransf.Checked Then
                txtTransferencia.Enabled = True
                txtTransferencia.Focus()
                DesactivarVacias(sender)
                If Not chkEfectivo.Checked And Not chkCheques.Checked And Not chkDolares.Checked Then
                    txtTransferencia.Text = lblMostrarTotal.Text
                End If
                FrmChequeTransDocPorPagar.Tipo = 2
                FrmChequeTransDocPorPagar.txtMonto1.Text = _oUtilidades.PasarMoneda(CDbl(lblMostrarTotal.Text))
                FrmChequeTransDocPorPagar.ShowDialog()

            Else
                txtTransferencia.Text = String.Empty
                txtTransferencia.Enabled = False
                ValidarActualizar()
            End If
        End Sub

        Private Sub chkDolares_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkDolares.CheckedChanged
            LimpiarCamposTexto()
            If chkDolares.Checked Then
                gbTipo_Cambio.Visible = True
                txtTipo_Cambio.Text = String.Empty
                txtMonto_Dolares.Text = String.Empty
                txtEfectivo_Dolares.Text = String.Empty
                txtTipo_Cambio.Focus()
                DesactivarVacias(sender)
            Else
                txtEfectivo_Dolares.Text = String.Empty
                txtTipo_Cambio.Text = String.Empty
                txtMonto_Dolares.Text = String.Empty
                gbTipo_Cambio.Visible = False
                ValidarActualizar()
            End If
        End Sub

        Private Sub txtMonto_Dolares_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtMonto_Dolares.KeyDown
            If e.KeyData = Keys.Enter Then
                txtEfectivo_Dolares.Text = (CDbl(txtTipo_Cambio.Text) * CDbl(txtMonto_Dolares.Text))
                ValidarActualizar()
            End If
        End Sub

        Private Sub txtTipo_Cambio_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtTipo_Cambio.KeyDown
            If e.KeyData = Keys.Enter Then txtMonto_Dolares.Focus()
        End Sub

        Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAceptar.Click
            Dim valido = ValidarActualizar()
            If Not valido Then
                MsgBox("Debe seleccionar una forma de pago")
            Else
                valido = ValidarFecha(valido, txtFechaCanc, "de cancelación")
            End If

            If (valido) Then

                Dim continua As Integer

                If _suma > CDbl(lblMostrarTotal.Text) Then
                    continua = MessageBox.Show("Está cancelando ¢" & _oUtilidades.PasarMoneda(_suma - CDbl(lblMostrarTotal.Text)) & " colones MAS del monto total, esta seguro que desea continuar", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                ElseIf _suma < CDbl(lblMostrarTotal.Text) Then
                    continua = MessageBox.Show("Está cancelando ¢" & _oUtilidades.PasarMoneda(CDbl(lblMostrarTotal.Text) - _suma) & " colones MENOS del monto total, esta seguro que desea continuar", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                Else
                    continua = 6
                End If

                If continua = vbYes Then
                    If IsDate(txtFechaRecibo.Text) Then
                        _oReciboDocPorPagar.FechaReciboProveedor = CDate(txtFechaRecibo.Text)
                    End If
                    FrmCancelacionDeFacturasPorProveedor.FechaCancelacion = CDate(_txtFechaCanc.Text)
                    FrmCancelacionDeFacturasPorProveedor.OReciboDocPorPagar = _oReciboDocPorPagar
                    FrmCancelacionDeFacturasPorProveedor.EstadoFlujoCaja = True
                    Dim cadenaEfectivo = String.Empty
                    If _oReciboDocPorPagar.TotalEfectivo > 0 Then
                        cadenaEfectivo = " EFECTIVO ¢" & _oUtilidades.PasarMoneda(_oReciboDocPorPagar.TotalEfectivo)
                    End If
                    txtObservaciones.Text = txtObservaciones.Text & " " & CadenaCheque & CadenaTrans & cadenaEfectivo
                    FrmCancelacionDeFacturasPorProveedor.OReciboDocPorPagar.Observaciones = UCase(txtObservaciones.Text)
                    Dispose()
                End If

            Else
                txtEfectivo.Focus()
            End If
        End Sub

        Private Sub chkHoy_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkHoy.CheckedChanged
            If chkHoy.Checked Then
                txtFechaCanc.Text = Now.Date.ToString("dd/MM/yyyy")
                txtFechaRecibo.Text = txtFechaCanc.Text
                txtFechaRecibo.Focus()
            Else
                txtFechaCanc.Text = String.Empty
                txtFechaCanc.Focus()
            End If
        End Sub

        Private Sub txtFecha_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtFechaCanc.KeyDown
            If e.KeyValue = 13 Then
                txtFechaRecibo.Text = txtFechaCanc.Text
                txtFechaRecibo.Focus()
            End If
        End Sub

        Private Sub txtNum_Recibo_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNum_Recibo.KeyDown
            If e.KeyValue = 13 Then btnAceptar.Focus()
        End Sub

        Private Sub FrmForma_Pago_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub

        Private Sub txtFechaRecibo_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtFechaRecibo.KeyDown
            If e.KeyValue = Keys.Enter Then txtNum_Recibo.Focus()
        End Sub

        Private Sub txtEfectivo_Leave(sender As Object, e As EventArgs) Handles txtEfectivo.Leave
            If IsNumeric(txtEfectivo.Text) Then
                txtEfectivo.Text = _oUtilidades.PasarMoneda(txtEfectivo.Text)
            End If
        End Sub
    End Class
End Namespace