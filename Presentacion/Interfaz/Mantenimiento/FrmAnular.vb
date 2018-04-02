Imports Logica_Negocios
Imports Entidades

Namespace Interfaz.Mantenimiento
    Public Class FrmAnular

        Private ReadOnly _oUtilidades As New Utilidades
        Private ReadOnly _oLogicaFactura As New LogicaFacturar
        Private ReadOnly _oLogicaFactCredito As New LogicaFacturaCredito
        Private ReadOnly _oLogicaPersona As New LogicaPersona
        Private ReadOnly _oLogicaNotaCredito As New LogicaNotaCredito
        Private ReadOnly _oLogicaNotaDebito As New LogicaNotaDebito
        Private ReadOnly _oLogicaClienteCredito As New LogicaClienteCredito
        Private ReadOnly _oLogicaReciboDinero As New LogicaReciboDinero

        Private _otblFactura As New DataTable
        Private _oNotaCredito As New NotaCredito
        Private _oNcGeneral As New NotaCreditoGeneral
        Private _oNdGeneral As New NotaDebitoGeneral
        Private _oRecibo As New Recibo

        Private Sub FrmAnularFactura_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            AddHandler txtNumFactura.KeyPress, AddressOf ValidarSoloNumeros
            AddHandler txtId_NC.KeyPress, AddressOf ValidarSoloNumeros
            AddHandler txtIdNC_General.KeyPress, AddressOf ValidarSoloNumeros
            AddHandler txtNum_Recibo.KeyPress, AddressOf ValidarSoloNumeros

            txtNumFactura.Select()
        End Sub

        Private Sub TabControl1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles TabControl1.Click
            Dim tabPage = TabControl1.SelectedTab

            If tabPage.Name = "tagFactura" Then
                txtNumFactura.Select()
            ElseIf tabPage.Name = "tagNC" Then
                txtId_NC.Select()
            ElseIf tabPage.Name = "tagNC_GEneral" Then
                txtIdNC_General.Select()
            ElseIf tabPage.Name = "tagRecibos" Then
                txtNum_Recibo.Select()
            End If
        End Sub

        '**************************************************FACTURA************************************************
        Private Sub txtNumFactura_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNumFactura.KeyDown
            If e.KeyData = Keys.Enter And txtNumFactura.Text <> "" Then

                _otblFactura = New DataTable
                _otblFactura = _oLogicaFactura.consultarFacturaAnular(CInt(txtNumFactura.Text))

                If _otblFactura.Rows.Count > 0 Then
                    If _otblFactura.Rows(0).Item(1) Then
                        MsgBox("Esta factura ya ha sido anulada anteriormente")
                        btnAnularFact.Enabled = False
                        txtNombre.Text = _otblFactura.Rows(0).Item(2) + " " + _otblFactura.Rows(0).Item(3) + " " + _otblFactura.Rows(0).Item(4)
                        txtNumFactura.Focus()
                    Else
                        txtNombre.Text = _otblFactura.Rows(0).Item(2) + " " + _otblFactura.Rows(0).Item(3) + " " + _otblFactura.Rows(0).Item(4)
                        btnAnularFact.Enabled = True
                    End If
                Else
                    MsgBox("No existe una factura con ese número")
                End If
            End If
        End Sub

        Private Sub txtNumFactura_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtNumFactura.Click
            txtNumFactura.Text = String.Empty
            txtNombre.Text = String.Empty
        End Sub

        Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAnularFact.Click
            If IsNumeric(txtNumFactura.Text) And txtNombre.Text <> "" Then
                If _otblFactura.Rows(0).Item(1) = 0 Then
                    Dim respuesta As String
                    respuesta = MsgBox("Esta seguro que desea anular esta factura?", vbCritical + vbYesNo, "Anular Factura...")

                    If (respuesta = vbYes) Then
                        _oLogicaFactura.anular(CLng(txtNumFactura.Text))
                        _oLogicaFactCredito.cambiarNulo_NumFactura(CLng(txtNumFactura.Text))
                        txtNumFactura.Text = String.Empty
                        txtNombre.Text = String.Empty
                        _otblFactura = New DataTable
                        txtNumFactura.Focus()
                        MsgBox("Factura anulada con éxito", MsgBoxStyle.Information)
                    End If
                Else
                    MsgBox("Está factura ya ha sido anulada", MsgBoxStyle.Exclamation)
                End If
            End If
            txtNumFactura.Focus()
        End Sub

        '**************************************************NOTA CREDITO************************************************

        Private Sub LimpiarNc()
            txtNum_FacturaNC.Text = String.Empty
            txtFechaNC.Text = String.Empty
            txtId_NC.Text = String.Empty
            txtMontoNC.Text = String.Empty
            txtCliente_NC.Text = String.Empty
            txtId_NC.Focus()
        End Sub

        Private Sub txtId_NC_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtId_NC.KeyDown
            If e.KeyValue = 13 And Trim(txtId_NC.Text) <> "" Then
                _oNotaCredito = _oLogicaNotaCredito.consultar(CInt(txtId_NC.Text))
                If _oNotaCredito.IdNC > 0 Then
                    txtNum_FacturaNC.Text = _oNotaCredito.NumFactura
                    txtFechaNC.Text = _oNotaCredito.Fecha
                    txtMontoNC.Text = _oUtilidades.PasarMoneda(_oNotaCredito.Monto)

                    Dim factura = _oLogicaFactura.ConsultarFactura(_oNotaCredito.NumFactura)
                    Dim persona = _oLogicaPersona.Consultar(factura.IdPersona)

                    txtCliente_NC.Text = persona.Nombre & " " & persona.PrimerApellido & " " & persona.SegundoApellido

                    btnAnularNC.Focus()
                Else
                    MsgBox("No existe una nota de crédito con ese número", MsgBoxStyle.Exclamation)
                End If
            End If
        End Sub

        Private Sub txtId_NC_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtId_NC.Click
            LimpiarNc()
        End Sub

        Private Sub btnAnularNC_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAnularNC.Click
            If IsNumeric(txtId_NC.Text) And txtNum_FacturaNC.Text <> "" Then
                If _oNotaCredito.Estado = NotaCredito.ListaEstado.Pendiente Then
                    Dim respuesta As String
                    respuesta = MsgBox("Esta seguro que desea anular esta nota de crédito?", vbCritical + vbYesNo, "Anular Nota de crédito...")

                    If respuesta = vbYes Then
                        _oNotaCredito.Estado = NotaCredito.ListaEstado.Anulada
                        _oLogicaNotaCredito.actualizarNCEstado_IdNC(_oNotaCredito)
                        _oNotaCredito = New NotaCredito
                        LimpiarNc()
                        MsgBox("Nota crédito anulada con éxito", MsgBoxStyle.Information)
                    End If
                ElseIf _oNotaCredito.Estado = NotaCredito.ListaEstado.Aplicada Then
                    MsgBox("Esta nota de crédito ya fue aplicada a un recibo por lo que no puede ser anulada", MsgBoxStyle.Exclamation)
                Else
                    MsgBox("Esta nota de crédito ya fue anulada", MsgBoxStyle.Exclamation)
                End If
            End If
            txtId_NC.Focus()
        End Sub

        '**************************************************NOTA CREDITO GENERAL************************************************

        Private Sub LimpiarNcGeneral()
            txtIdNC_General.Text = String.Empty
            txtFechaNC_General.Text = String.Empty
            txtMontoNC_General.Text = String.Empty
            txtMotivoNC_General.Text = String.Empty
            txtCliente_General.Text = String.Empty
            txtIdNC_General.Focus()
        End Sub

        Private Sub txtIdNC_General_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtIdNC_General.KeyDown
            If e.KeyValue = Keys.Enter And txtIdNC_General.Text <> "" Then
                _oNcGeneral = _oLogicaNotaCredito.consultarNota_CreditoGeneral(CInt(txtIdNC_General.Text))
                If _oNcGeneral.IdNC > 0 Then
                    txtFechaNC_General.Text = _oNcGeneral.Fecha
                    txtMontoNC_General.Text = _oUtilidades.PasarMoneda(_oNcGeneral.Monto)
                    txtMotivoNC_General.Text = _oNcGeneral.Motivo

                    Dim idPersona = _oLogicaClienteCredito.consultarIdCliente_PorId_Credito(_oNcGeneral.IdClienteCredito)
                    Dim persona = _oLogicaPersona.Consultar(idPersona)

                    txtCliente_General.Text = persona.Nombre & " " & persona.PrimerApellido & " " & persona.SegundoApellido
                    btnAnularNC_General.Focus()
                Else
                    MsgBox("No existe una nota de crédito general con ese número", MsgBoxStyle.Exclamation)
                End If
            End If
        End Sub

        Private Sub txtIdNC_General_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtIdNC_General.Click
            LimpiarNcGeneral()
        End Sub

        Private Sub btnAnularNC_General_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAnularNC_General.Click
            If IsNumeric(txtIdNC_General.Text) And txtCliente_General.Text <> "" Then
                If _oNcGeneral.Estado = NotaCreditoGeneral.ListaEstado.Pendiente Then
                    Dim respuesta As String
                    respuesta = MsgBox("Esta seguro que desea anular esta nota de crédito general?", vbCritical + vbYesNo, "Anular Nota de crédito general...")

                    If respuesta = vbYes Then
                        _oNcGeneral.Estado = NotaCreditoGeneral.ListaEstado.Anulada
                        _oLogicaNotaCredito.actualizarGeneralEstado_IdNC(_oNcGeneral)
                        _oNcGeneral = New NotaCreditoGeneral
                        LimpiarNcGeneral()
                        MsgBox("Nota crédito general anulada con éxito", MsgBoxStyle.Information)
                    End If
                ElseIf _oNcGeneral.Estado = NotaCreditoGeneral.ListaEstado.Aplicada Then
                    MsgBox("Esta nota de crédito general ya fue aplicada a un recibo por lo que no puede ser anulada", MsgBoxStyle.Exclamation)
                Else
                    MsgBox("Esta nota de crédito general ya ha sido anulada", MsgBoxStyle.Exclamation)
                End If
            End If
            txtIdNC_General.Focus()
        End Sub

        '**************************************************RECIBOS************************************************

        Private Sub LimpiarRecibos()
            txtNum_Recibo.Text = String.Empty
            txtFecha_Recibo.Text = String.Empty
            txtMonto_Recibo.Text = String.Empty
            txtCliente_Recibo.Text = String.Empty
            txtObserva_Recibo.Text = String.Empty
            txtNum_Recibo.Focus()
        End Sub

        Private Sub txtNum_Recibo_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNum_Recibo.KeyDown
            If e.KeyValue = Keys.Enter And txtNum_Recibo.Text <> "" Then
                _oRecibo = _oLogicaReciboDinero.consultarRecibo_NumRecibo(CInt(txtNum_Recibo.Text))

                If _oRecibo.NumRecibo > 0 Then
                    txtFecha_Recibo.Text = _oRecibo.Fecha
                    txtMonto_Recibo.Text = _oUtilidades.PasarMoneda(_oRecibo.Monto)
                    txtObserva_Recibo.Text = _oRecibo.Observaciones

                    Dim idPersona = _oLogicaClienteCredito.consultarIdCliente_PorId_Credito(_oRecibo.IdClienteCredito)
                    Dim persona = _oLogicaPersona.Consultar(idPersona)

                    txtCliente_Recibo.Text = persona.Nombre & " " & persona.PrimerApellido & " " & persona.SegundoApellido
                    btnAnularRecibos.Focus()
                Else
                    MsgBox("No existe un recibo por dinero con ese número", MsgBoxStyle.Exclamation)
                End If
            End If
        End Sub

        Private Sub txtNum_Recibo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtNum_Recibo.Click
            LimpiarRecibos()
        End Sub

        Private Sub btnAnularRecibos_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAnularRecibos.Click
            If IsNumeric(txtNum_Recibo.Text) And txtCliente_Recibo.Text <> "" Then
                If Not _oRecibo.Anulado Then
                    Dim respuesta As String
                    respuesta = MsgBox("Esta seguro que desea anular este recibo?", vbCritical + vbYesNo, "Anular recibo por dinero...")

                    If respuesta = vbYes Then
                        _oLogicaReciboDinero.anularReciboDinero_NumRecibo(CInt(txtNum_Recibo.Text))
                        _oRecibo = New Recibo
                        LimpiarRecibos()
                        MsgBox("Recibo por dinero anulado con éxito", MsgBoxStyle.Information)
                    End If
                Else
                    MsgBox("Este recibo por dinero ya ha sido anulado", MsgBoxStyle.Exclamation)
                End If
            End If
            txtNum_Recibo.Focus()
        End Sub

        Private Sub FrmAnular_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub

        Private Sub txtNumND_General_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNumND_General.KeyDown
            If e.KeyValue = Keys.Enter And txtNumND_General.Text <> "" Then
                _oNdGeneral = _oLogicaNotaDebito.consultarNota_DebitoGeneral(CInt(txtNumND_General.Text))
                If _oNdGeneral.IdND > 0 Then
                    txtFechaND_General.Text = _oNdGeneral.Fecha
                    txtMontoND_General.Text = _oUtilidades.PasarMoneda(_oNdGeneral.Monto)
                    txtMotivoND_General.Text = _oNdGeneral.Motivo

                    Dim idPersona = _oLogicaClienteCredito.consultarIdCliente_PorId_Credito(_oNdGeneral.IdClienteCredito)
                    Dim persona = _oLogicaPersona.Consultar(idPersona)

                    txtClientND_General.Text = persona.Nombre & " " & persona.PrimerApellido & " " & persona.SegundoApellido
                    btnAnularNDGeneral.Focus()
                Else
                    MsgBox("No existe una nota de débito general con ese número", MsgBoxStyle.Exclamation)
                End If
            End If
        End Sub

        Private Sub txtNumND_General_Click(sender As Object, e As EventArgs) Handles txtNumND_General.Click
            LimpiarNdGeneral()
        End Sub

        Private Sub LimpiarNdGeneral()
            txtNumND_General.Text = String.Empty
            txtFechaND_General.Text = String.Empty
            txtMontoND_General.Text = String.Empty
            txtMotivoND_General.Text = String.Empty
            txtClientND_General.Text = String.Empty
            txtNumND_General.Focus()
        End Sub

        Private Sub btnAnularNDGeneral_Click(sender As Object, e As EventArgs) Handles btnAnularNDGeneral.Click
            If IsNumeric(txtNumND_General.Text) And txtClientND_General.Text <> "" Then
                If _oNdGeneral.Estado = NotaCreditoGeneral.ListaEstado.Pendiente Then
                    Dim respuesta As String
                    respuesta = MsgBox("Esta seguro que desea anular esta nota de crédito general?", vbCritical + vbYesNo, "Anular Nota de crédito general...")

                    If respuesta = vbYes Then
                        _oNdGeneral.Estado = NotaCreditoGeneral.ListaEstado.Anulada
                        _oLogicaNotaDebito.actualizarGeneralEstado_IdND(_oNdGeneral)
                        _oNdGeneral = New NotaDebitoGeneral
                        LimpiarNdGeneral()
                        MsgBox("Nota débito general anulada con éxito", MsgBoxStyle.Information)
                    End If
                ElseIf _oNdGeneral.Estado = NotaCreditoGeneral.ListaEstado.Aplicada Then
                    MsgBox("Esta nota de débito general ya fue aplicada a un recibo por lo que no puede ser anulada", MsgBoxStyle.Exclamation)
                Else
                    MsgBox("Esta nota de débito general ya ha sido anulada", MsgBoxStyle.Exclamation)
                End If
            End If
            txtNumND_General.Focus()
        End Sub
    End Class
End Namespace