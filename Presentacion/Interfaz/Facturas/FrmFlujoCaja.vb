Imports Logica_Negocios
Imports Entidades
Imports Presentacion.Interfaz.Creditos

Namespace Interfaz.Facturas
    Public Class FrmFlujoCaja

        ' 1 factura, 2 Alt-0, 3 Alt-U
        Private _varTipo As Integer
        Private ReadOnly _oLogicaFlujo As New LogicaFlujoCaja
        Private ReadOnly _oFlujoCaja As New FlujoCaja
        Private ReadOnly _oUtilidades As New Utilidades
        Public Pantalla As Integer '1 Factura 2 Factura_Credito
        Public MenosDinero As Boolean
        Private ReadOnly _oLogicaMoneda As New LogicaMoneda
        Private _aceptar As Boolean = False
        Public CadenaCheque As String
        Public CadenaTrans As String

        Public Property Tipo() As Integer
            Get
                Return _varTipo
            End Get
            Set(ByVal value As Integer)
                _varTipo = value
            End Set
        End Property

        Private Sub txtEfectivo_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtEfectivo.KeyDown
            If e.KeyData = Keys.Enter Then
                If Tipo = 3 Then
                    validarReintegro()
                Else
                    _aceptar = False
                    btnAceptar.Focus()
                    validarActualizar()
                End If
            ElseIf e.KeyValue = 40 Then
                txtTarjetas.Focus()
            End If
        End Sub

        Private Sub txtTarjetas_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtTarjetas.KeyDown
            If e.KeyData = Keys.Enter Then
                If Tipo = 3 Then
                    validarReintegro()
                Else
                    _aceptar = False
                    btnAceptar.Focus()
                    validarActualizar()
                End If
            ElseIf e.KeyValue = 40 Then
                txtCheques.Focus()
            ElseIf e.KeyValue = 38 Then
                txtEfectivo.Focus()
            End If
        End Sub

        Private Sub txtCheques_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtCheques.KeyDown
            If e.KeyData = Keys.Enter Then
                If Tipo = 3 Then
                    validarReintegro()
                Else
                    _aceptar = False
                    btnAceptar.Focus()
                    validarActualizar()
                End If
            ElseIf e.KeyValue = 40 Then
                txtTransferencia.Focus()
            ElseIf e.KeyValue = 38 Then
                txtTarjetas.Focus()
            End If
        End Sub

        Private Sub txtTransferencia_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtTransferencia.KeyDown
            If e.KeyData = Keys.Enter Then
                If Tipo = 3 Then
                    validarReintegro()
                Else
                    _aceptar = False
                    btnAceptar.Focus()
                    validarActualizar()
                End If
            ElseIf e.KeyValue = 40 Then
                btnAceptar.Focus()
            ElseIf e.KeyValue = 38 Then
                txtCheques.Focus()
            End If
        End Sub

        Private Sub FrmFlujoCaja_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            If Pantalla = 1 Then
                lblMostrarTotal.Text = FrmFacturar.lblMostrarTotal.Text
            ElseIf Pantalla = 2 Then
                lblMostrarTotal.Text = FrmFacturaCredito.lblMostrarAbono.Text
            End If

            Dim numeroRedondeo = _oLogicaMoneda.consultarMoneda
            Dim redondeo = (Math.Round((CDbl(lblMostrarTotal.Text) / numeroRedondeo))) * numeroRedondeo
            lblMonto_Redondeo.Text = _oUtilidades.PasarMoneda(redondeo)
            txtEfectivo.Text = lblMonto_Redondeo.Text
            If Tipo = 3 Then
                lblVuelto.Visible = False
                lblMostrarVuelto.Visible = False
                lbl1.Visible = True
                chkForzarCero.Visible = False
                txtForzar.Visible = False
            End If

            AddHandler txtEfectivo.KeyPress, AddressOf ValidarNumerosPunto
            AddHandler txtTarjetas.KeyPress, AddressOf ValidarNumerosPunto
            AddHandler txtCheques.KeyPress, AddressOf ValidarNumerosPunto
            AddHandler txtEfectivo_Dolares.KeyPress, AddressOf ValidarNumerosPunto
            AddHandler txtTransferencia.KeyPress, AddressOf ValidarNumerosPunto
            AddHandler txtForzar.KeyPress, AddressOf ValidarNumerosPunto
            AddHandler txtTipo_Cambio.KeyPress, AddressOf ValidarNumerosPunto
            AddHandler txtMonto_Dolares.KeyPress, AddressOf ValidarNumerosPunto
        End Sub

        Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAceptar.Click
            If Tipo = 3 Then
                If validarReintegro() Then
                    _oFlujoCaja.Efectivo = -_oFlujoCaja.Efectivo
                    _oFlujoCaja.Cheques = -_oFlujoCaja.Cheques
                    _oFlujoCaja.Transferencia = -_oFlujoCaja.Transferencia
                    _oFlujoCaja.Tarjeta = -_oFlujoCaja.Tarjeta
                    Dim otro = _oLogicaFlujo.consultarNuevo_Otro(Now.Date)
                    _oFlujoCaja.Fecha = Now.Date
                    If Pantalla = 1 Then
                        _oFlujoCaja.Creditos = 0
                        FrmFacturar.EstadoFlujoCaja = True
                    ElseIf Pantalla = 2 Then
                        _oFlujoCaja.Creditos = CDbl(lblMostrarTotal.Text)
                        FrmFacturaCredito.EstadoFlujoCaja = True
                    End If
                    If otro Then
                        _oLogicaFlujo.insertar_Otro(_oFlujoCaja)
                    Else
                        _oLogicaFlujo.modificar_Otro(_oFlujoCaja)
                    End If
                    Dispose()
                End If

            Else
                _aceptar = True
                If (validarActualizar()) Then
                    Dim nuevo = _oLogicaFlujo.consultarNuevo(Now.Date)
                    _oFlujoCaja.Fecha = Now.Date

                    If IsNumeric(lblMostrarVuelto.Text) Then
                        Select Case Tipo
                            Case 1
                                If CDbl(lblMostrarVuelto.Text) < 0 Then
                                    MsgBox("Revise la información digitada ya que le vuelto da un monto negativo")
                                Else
                                    If Pantalla = 1 Then
                                        _oFlujoCaja.Creditos = 0
                                        FrmFacturar.OFlujoCaja = _oFlujoCaja
                                        FrmFacturar.EstadoFlujoCaja = True
                                        Dispose()
                                    ElseIf Pantalla = 2 Then
                                        _oFlujoCaja.Creditos = CDbl(lblMostrarTotal.Text)
                                        Dim efectivo = String.Empty
                                        If IsNumeric(txtEfectivo.Text) Then
                                            efectivo = String.Format(" Efectivo ¢{0}", _oUtilidades.PasarMoneda(txtEfectivo.Text))
                                        End If
                                        FrmFacturaCredito.OFlujoCaja = _oFlujoCaja
                                        FrmFacturaCredito.CalcularTotales()
                                        FrmObservaciones.LlenarDatos(_oFlujoCaja, True,
                                                                                  Trim(CadenaCheque & " " & CadenaTrans & " " & efectivo))
                                        FrmObservaciones.ShowDialog()
                                    End If
                                End If
                            Case 2
                                If CDbl(lblMostrarVuelto.Text) < 0 Then
                                    MsgBox("Revise la información digitada ya que le vuelto da un monto negativo")
                                Else

                                    Dim otro = _oLogicaFlujo.consultarNuevo_Otro(Now.Date)
                                    _oFlujoCaja.Fecha = Now.Date
                                    If Pantalla = 1 Then
                                        _oFlujoCaja.Creditos = 0
                                        FrmFacturar.EstadoFlujoCaja = True
                                    ElseIf Pantalla = 2 Then
                                        _oFlujoCaja.Creditos = CDbl(lblMostrarTotal.Text)
                                        FrmFacturaCredito.EstadoFlujoCaja = True
                                    End If
                                    If otro Then
                                        _oLogicaFlujo.insertar_Otro(_oFlujoCaja)
                                    Else
                                        _oLogicaFlujo.modificar_Otro(_oFlujoCaja)
                                    End If

                                    Dispose()
                                End If
                        End Select
                    End If

                Else
                    MsgBox("Debe seleccionar al menos una forma de pagó, y escribir el monto")
                    txtEfectivo.Focus()
                End If
            End If
        End Sub

        Private Function ValidarReintegro() As Boolean
            Dim valido = False
            Dim suma As Double = 0

            If IsNumeric(txtEfectivo.Text) Then
                If txtEfectivo.Text > 0 Then
                    suma = CDbl(txtEfectivo.Text)
                    _oFlujoCaja.Efectivo = _oUtilidades.PasarMoneda(CDbl(txtEfectivo.Text))
                    valido = True
                Else
                    _oFlujoCaja.Efectivo = 0
                End If
            Else
                _oFlujoCaja.Efectivo = 0
            End If


            If IsNumeric(txtTarjetas.Text) Then
                If txtTarjetas.Text > 0 Then
                    suma = suma + CDbl(txtTarjetas.Text)
                    _oFlujoCaja.Tarjeta = _oUtilidades.PasarMoneda(CDbl(txtTarjetas.Text))
                    valido = True
                Else
                    _oFlujoCaja.Tarjeta = 0
                End If
            Else
                _oFlujoCaja.Tarjeta = 0
            End If


            If IsNumeric(txtCheques.Text) Then
                If txtCheques.Text > 0 Then
                    suma = suma + CDbl(txtCheques.Text)
                    _oFlujoCaja.Cheques = _oUtilidades.PasarMoneda(CDbl(txtCheques.Text))
                    valido = True
                Else
                    _oFlujoCaja.Cheques = 0
                End If
            Else
                _oFlujoCaja.Cheques = 0
            End If


            If IsNumeric(txtTransferencia.Text) Then
                If txtTransferencia.Text > 0 Then
                    suma = suma + CDbl(txtTransferencia.Text)
                    _oFlujoCaja.Transferencia = _oUtilidades.PasarMoneda(CDbl(txtTransferencia.Text))
                    valido = True
                Else
                    _oFlujoCaja.Transferencia = 0
                End If
            Else
                _oFlujoCaja.Transferencia = 0
            End If

            If IsNumeric(txtEfectivo_Dolares.Text) Then
                If txtEfectivo_Dolares.Text > 0 Then
                    suma = suma + CDbl(txtEfectivo_Dolares.Text)
                    _oFlujoCaja.DolaresColones = _oUtilidades.PasarMoneda(CDbl(txtEfectivo_Dolares.Text))
                    valido = True
                Else
                    _oFlujoCaja.DolaresColones = 0
                End If
            Else
                _oFlujoCaja.DolaresColones = 0
            End If

            lblMostrar_Redondeo.Text = _oUtilidades.PasarMoneda((CDbl(lblMostrarTotal.Text)) - suma)
            If IsNumeric(lblMostrar_Redondeo.Text) Then
                _oFlujoCaja.Redondeo = _oUtilidades.PasarMoneda(CDbl(lblMostrar_Redondeo.Text))

                If CDbl(lblMostrar_Redondeo.Text) < 0 Then
                    lblMostrar_Redondeo.ForeColor = Color.Red
                Else
                    lblMostrar_Redondeo.ForeColor = Color.Black
                End If
            Else
                _oFlujoCaja.Redondeo = 0
            End If

            _oFlujoCaja.Creditos = 0
            _oFlujoCaja.Vale = 0

            Return valido
        End Function

        Private Function ValidarActualizar() As Boolean
            Dim valido = False
            Dim suma As Double = 0

            If IsNumeric(txtEfectivo.Text) Then
                suma = CDbl(txtEfectivo.Text)
                _oFlujoCaja.Efectivo = _oUtilidades.PasarMoneda(CDbl(txtEfectivo.Text))
                valido = True
            Else
                _oFlujoCaja.Efectivo = 0
            End If


            If IsNumeric(txtTarjetas.Text) Then
                If txtTarjetas.Text > 0 Then
                    suma = suma + CDbl(txtTarjetas.Text)
                    _oFlujoCaja.Tarjeta = _oUtilidades.PasarMoneda(CDbl(txtTarjetas.Text))
                    valido = True
                Else
                    _oFlujoCaja.Tarjeta = 0
                End If
            Else
                _oFlujoCaja.Tarjeta = 0
            End If


            If IsNumeric(txtCheques.Text) Then
                If txtCheques.Text > 0 Then
                    suma = suma + CDbl(txtCheques.Text)
                    _oFlujoCaja.Cheques = _oUtilidades.PasarMoneda(CDbl(txtCheques.Text))
                    valido = True
                Else
                    _oFlujoCaja.Cheques = 0
                End If
            Else
                _oFlujoCaja.Cheques = 0
            End If


            If IsNumeric(txtTransferencia.Text) Then
                If txtTransferencia.Text > 0 Then
                    suma = suma + CDbl(txtTransferencia.Text)
                    _oFlujoCaja.Transferencia = _oUtilidades.PasarMoneda(CDbl(txtTransferencia.Text))
                    valido = True
                Else
                    _oFlujoCaja.Transferencia = 0
                End If
            Else
                _oFlujoCaja.Transferencia = 0
            End If

            If IsNumeric(txtEfectivo_Dolares.Text) Then
                If txtEfectivo_Dolares.Text > 0 Then
                    suma = suma + CDbl(txtEfectivo_Dolares.Text)
                    _oFlujoCaja.DolaresColones = _oUtilidades.PasarMoneda(CDbl(txtEfectivo_Dolares.Text))
                    valido = True
                Else
                    _oFlujoCaja.DolaresColones = 0
                End If
            Else
                _oFlujoCaja.DolaresColones = 0
            End If

            lblMostrarVuelto.Text = _oUtilidades.PasarMoneda(suma - (CDbl(lblMostrarTotal.Text)))

            If CDbl(lblMostrarVuelto.Text) < 0 Then
                Dim numeroRedondeo = _oLogicaMoneda.consultarMoneda
                Dim redondeo = (Math.Round((CDbl(lblMostrarTotal.Text) / numeroRedondeo))) * numeroRedondeo
                lblMostrar_Redondeo.Text = _oUtilidades.PasarMoneda(redondeo - CDbl(lblMostrarTotal.Text))

                If Math.Abs(CDbl(lblMostrarTotal.Text) - suma) < (numeroRedondeo / 2) Then
                    lblMostrarVuelto.Text = 0
                    lblMostrar_Redondeo.Text = _oUtilidades.PasarMoneda(suma - CDbl(lblMostrarTotal.Text))
                Else

                    If _aceptar Then
                        Dim total As String = CDbl(lblMostrarTotal.Text) - suma
                        total = "¢" & _oUtilidades.PasarMoneda(total) & " menos"

                        FrmControlMsgBox.lblMostrar.Text = total
                        FrmControlMsgBox.ShowDialog()

                        If MenosDinero Then
                            lblMostrar_Redondeo.Text = _oUtilidades.PasarMoneda(suma - CDbl(lblMostrarTotal.Text))
                            lblMostrarVuelto.Text = 0
                        Else
                            limpiarCamposTexto()
                            txtEfectivo.Focus()
                        End If
                    Else
                        lblMostrar_Redondeo.Text = _oUtilidades.PasarMoneda(suma - CDbl(lblMostrarTotal.Text))
                        lblMostrarVuelto.Text = 0
                    End If

                End If
            ElseIf CDbl(lblMostrarVuelto.Text) > 0 Then
                Dim numeroRedondeo = _oLogicaMoneda.consultarMoneda
                Dim redondeo = (Math.Round((CDbl(lblMostrarTotal.Text) / numeroRedondeo))) * numeroRedondeo
                lblMostrar_Redondeo.Text = _oUtilidades.PasarMoneda(redondeo - CDbl(lblMostrarTotal.Text))

                If Math.Abs(suma - CDbl(lblMostrarTotal.Text)) < (numeroRedondeo / 2) Then
                    lblMostrarVuelto.Text = 0
                    lblMostrar_Redondeo.Text = _oUtilidades.PasarMoneda(suma - CDbl(lblMostrarTotal.Text))
                Else
                    Dim redondeoVuelto = (Math.Round((suma - redondeo) / numeroRedondeo)) * numeroRedondeo
                    lblMostrarVuelto.Text = _oUtilidades.PasarMoneda(redondeoVuelto)
                End If
            Else
                lblMostrar_Redondeo.Text = 0
            End If


            If IsNumeric(txtForzar.Text) Then
                If CDbl(txtForzar.Text) = 0 Then
                    lblMostrar_Redondeo.Text = _oUtilidades.PasarMoneda(suma - CDbl(lblMostrarTotal.Text))
                    lblMostrarVuelto.Text = "0.00"
                Else
                    lblMostrar_Redondeo.Text = _oUtilidades.PasarMoneda(suma - CDbl(lblMostrarTotal.Text) - CDbl(txtForzar.Text))
                    lblMostrarVuelto.Text = txtForzar.Text
                End If
            End If

            If IsNumeric(lblMostrar_Redondeo.Text) Then
                _oFlujoCaja.Redondeo = _oUtilidades.PasarMoneda(CDbl(lblMostrar_Redondeo.Text))

                If CDbl(lblMostrar_Redondeo.Text) < 0 Then
                    lblMostrar_Redondeo.ForeColor = Color.Red
                Else
                    lblMostrar_Redondeo.ForeColor = Color.Black
                End If
            Else
                _oFlujoCaja.Redondeo = 0
            End If

            If IsNumeric(lblMostrarVuelto.Text) Then
                _oFlujoCaja.Vuelto = _oUtilidades.PasarMoneda(CDbl(lblMostrarVuelto.Text))
            Else
                _oFlujoCaja.Vuelto = 0
            End If

            _oFlujoCaja.Creditos = 0
            _oFlujoCaja.Vale = 0

            Return valido
        End Function

        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelar.Click
            FrmFacturar.EstadoFlujoCaja = False
            Dispose()
        End Sub

        Private Sub chkEfectivo_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkEfectivo.CheckedChanged
            limpiarCamposTexto()
            If chkEfectivo.Checked Then
                txtEfectivo.Enabled = True
                txtEfectivo.Focus()
                desactivarVacias(sender)
                If Not chkCheques.Checked And Not chkTarjetas.Checked And Not chkTransf.Checked And Not chkDolares.Checked Then
                    txtEfectivo.Text = lblMonto_Redondeo.Text
                End If
            Else
                txtEfectivo.Text = String.Empty
                txtEfectivo.Enabled = False
                ValidarActualizar()
            End If
        End Sub

        Private Sub chkTarjetas_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkTarjetas.CheckedChanged
            limpiarCamposTexto()
            If chkTarjetas.Checked Then
                txtTarjetas.Enabled = True
                txtTarjetas.Focus()
                desactivarVacias(sender)
                If Not chkCheques.Checked And Not chkEfectivo.Checked And Not chkTransf.Checked And Not chkDolares.Checked Then
                    txtTarjetas.Text = lblMostrarTotal.Text
                End If
            Else
                txtTarjetas.Text = String.Empty
                txtTarjetas.Enabled = False
                ValidarActualizar()
            End If
        End Sub

        Private Sub LimpiarCamposTexto()
            lblMostrar_Redondeo.Text = String.Empty
            lblMostrarVuelto.Text = String.Empty
            _aceptar = False
        End Sub

        Private Sub DesactivarVacias(ByVal e As CheckBox)
            If e.Name <> chkEfectivo.Name And txtEfectivo.Text = "" Then
                chkEfectivo.Checked = False
            End If

            If e.Name <> chkDolares.Name And txtEfectivo_Dolares.Text = "" Then
                chkDolares.Checked = False
            End If

            If e.Name <> chkTarjetas.Name And txtTarjetas.Text = "" Then
                chkTarjetas.Checked = False
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
                If Not chkTarjetas.Checked And Not chkEfectivo.Checked And Not chkTransf.Checked And Not chkDolares.Checked Then
                    txtCheques.Text = lblMostrarTotal.Text
                End If
                If Pantalla = 2 Then
                    FrmChequeTrans.Tipo = 1
                    FrmChequeTrans.txtMonto1.Text = _oUtilidades.PasarMoneda(CDbl(lblMostrarTotal.Text))
                    FrmChequeTrans.ShowDialog()
                End If
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
                If Not chkTarjetas.Checked And Not chkEfectivo.Checked And Not chkCheques.Checked And Not chkDolares.Checked Then
                    txtTransferencia.Text = lblMostrarTotal.Text
                End If
                If Pantalla = 2 Then
                    FrmChequeTrans.Tipo = 2
                    FrmChequeTrans.txtMonto1.Text = _oUtilidades.PasarMoneda(CDbl(lblMostrarTotal.Text))
                    FrmChequeTrans.ShowDialog()
                End If
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

        Private Sub txtTipo_Cambio_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtTipo_Cambio.KeyDown
            If e.KeyData = Keys.Enter Then
                txtMonto_Dolares.Focus()
            End If

        End Sub

        Private Sub txtMonto_Dolares_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtMonto_Dolares.KeyDown
            If e.KeyData = Keys.Enter Then
                txtEfectivo_Dolares.Text = (CDbl(txtTipo_Cambio.Text) * CDbl(txtMonto_Dolares.Text))
                If Tipo <> 3 Then
                    ValidarActualizar()
                End If
            End If
        End Sub

        Private Sub chkForzarCero_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkForzarCero.CheckedChanged
            If chkForzarCero.Checked Then
                txtForzar.Enabled = True
                txtForzar.Text = 0.0
                txtForzar.Focus()
            Else
                txtForzar.Text = String.Empty
                txtForzar.Enabled = False
                LimpiarCamposTexto()
            End If
        End Sub

        Private Sub txtForzar_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtForzar.KeyDown
            If e.KeyData = Keys.Enter Then
                btnAceptar.Focus()
                ValidarActualizar()
            End If
        End Sub

        Private Sub FrmFlujoCaja_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub
    End Class
End Namespace