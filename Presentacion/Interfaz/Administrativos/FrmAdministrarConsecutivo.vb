Imports Entidades
Imports Logica_Negocios

Namespace Interfaz.Administrativos
    Public Class FrmAdministrarConsecutivo

        Private ReadOnly _oLogicaConsecutivo As New LogicaConsecutivo
        Private _oConsFactura As Consecutivo
        Private _oConsAbono As Consecutivo
        Private _oConsNotaCredito As Consecutivo
        Private _oConsProforma As Consecutivo
        Private _oConsReciboPorDinero As Consecutivo

        Private Sub FrmAdministrar_Consecutivo_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            MostrarConsucutivos()
            AddHandler txtCon_Factura.KeyPress, AddressOf ValidarSoloNumeros
            AddHandler txtCons_Abonos.KeyPress, AddressOf ValidarSoloNumeros
            AddHandler txtCons_NC.KeyPress, AddressOf ValidarSoloNumeros
            AddHandler txtCons_Proforma.KeyPress, AddressOf ValidarSoloNumeros
            AddHandler txtCons_Recibo.KeyPress, AddressOf ValidarSoloNumeros
        End Sub

        Private Sub MostrarConsucutivos()
            _oConsFactura = _oLogicaConsecutivo.ConsultarConsecutivo("CONSECUTIVO_FACTURA")
            _oConsAbono = _oLogicaConsecutivo.ConsultarConsecutivo("CONSECUTIVO_ABONO")
            _oConsNotaCredito = _oLogicaConsecutivo.ConsultarConsecutivo("CONSECUTIVO_NC")
            _oConsProforma = _oLogicaConsecutivo.ConsultarConsecutivo("CONSECUTIVO_PROFORMA")
            _oConsReciboPorDinero = _oLogicaConsecutivo.ConsultarConsecutivo("CONSECUTIVO_RECIBO_FACT")

            txtCon_Factura.Text = _oConsFactura.Consecutivo
            If _oConsFactura.Bloqueo Then
                chkBloq_Facturas.Checked = True
            Else
                chkBloq_Facturas.Checked = False
            End If

            txtCons_Abonos.Text = _oConsAbono.Consecutivo
            If _oConsAbono.Bloqueo Then
                chkBloq_Abonos.Checked = True
            Else
                chkBloq_Abonos.Checked = False
            End If

            txtCons_NC.Text = _oConsNotaCredito.Consecutivo
            If _oConsNotaCredito.Bloqueo Then
                chkBloq_NC.Checked = True
            Else
                chkBloq_NC.Checked = False
            End If

            txtCons_Proforma.Text = _oConsProforma.Consecutivo
            If _oConsProforma.Bloqueo Then
                chkBloq_Proforma.Checked = True
            Else
                chkBloq_Proforma.Checked = False
            End If

            txtCons_Recibo.Text = _oConsReciboPorDinero.Consecutivo
            If _oConsReciboPorDinero.Bloqueo Then
                chkBloq_Recibo.Checked = True
            Else
                chkBloq_Recibo.Checked = False
            End If
        End Sub

        Private Sub btnRecargar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnRecargar.Click
            MostrarConsucutivos()
        End Sub

        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            Dim salida As String
            Dim cambios As Boolean = False

            If IsNumeric(txtCon_Factura.Text) And IsNumeric(txtCons_Abonos.Text) And IsNumeric(txtCons_NC.Text) And IsNumeric(txtCons_Proforma.Text) And IsNumeric(txtCons_Recibo.Text) Then
                If Not chkBloq_Facturas.Checked And Not chkBloq_Abonos.Checked And Not chkBloq_NC.Checked And Not chkBloq_Proforma.Checked And Not chkBloq_Recibo.Checked Then
                    salida = "Está seguro que desea realizar los siguientes cambios:" & Environment.NewLine() & Environment.NewLine()

                    If CInt(txtCon_Factura.Text) <> _oConsFactura.Consecutivo Then
                        salida += "-Modificar el consecutivo facturas de " & _oConsFactura.Consecutivo & " a " & txtCon_Factura.Text & Environment.NewLine()
                        cambios = True
                    End If

                    If CInt(txtCons_Abonos.Text) <> _oConsAbono.Consecutivo Then
                        salida += "-Modificar el consecutivo de abonos de " & _oConsAbono.Consecutivo & " a " & txtCons_Abonos.Text & Environment.NewLine()
                        cambios = True
                    End If

                    If CInt(txtCons_NC.Text) <> _oConsNotaCredito.Consecutivo Then
                        salida += "-Modificar el consecutivo de notas de crédito de " & _oConsNotaCredito.Consecutivo & " a " & txtCons_NC.Text & Environment.NewLine()
                        cambios = True
                    End If

                    If CInt(txtCons_Proforma.Text) <> _oConsProforma.Consecutivo Then
                        salida += "-Modificar el consecutivo de proformas de " & _oConsProforma.Consecutivo & " a " & txtCons_Proforma.Text & Environment.NewLine()
                        cambios = True
                    End If

                    If CInt(txtCons_Recibo.Text) <> _oConsReciboPorDinero.Consecutivo Then
                        salida += "-Modificar el consecutivo recibos por dinero de " & _oConsReciboPorDinero.Consecutivo & " a " & txtCons_Recibo.Text & Environment.NewLine()
                        cambios = True
                    End If

                    _oConsFactura.Tabla = "CONSECUTIVO_FACTURA"
                    _oConsAbono.Tabla = "CONSECUTIVO_ABONO"
                    _oConsNotaCredito.Tabla = "CONSECUTIVO_NC"
                    _oConsProforma.Tabla = "CONSECUTIVO_PROFORMA"
                    _oConsReciboPorDinero.Tabla = "CONSECUTIVO_RECIBO_FACT"

                    If cambios Then
                        Dim respuesta As String
                        respuesta = MsgBox(salida, vbCritical + vbYesNo, "Guardar cambios consecutivos...")

                        If respuesta = vbYes Then
                            _oConsFactura.Bloqueo = False

                            _oConsFactura.Consecutivo = CInt(txtCon_Factura.Text)
                            _oLogicaConsecutivo.ModificarConsecutivo(_oConsFactura)

                            _oConsAbono.Bloqueo = False
                            _oConsAbono.Consecutivo = CInt(txtCons_Abonos.Text)
                            _oLogicaConsecutivo.ModificarConsecutivo(_oConsAbono)

                            _oConsNotaCredito.Bloqueo = False
                            _oConsNotaCredito.Consecutivo = CInt(txtCons_NC.Text)
                            _oLogicaConsecutivo.ModificarConsecutivo(_oConsNotaCredito)

                            _oConsProforma.Bloqueo = False
                            _oConsProforma.Consecutivo = CInt(txtCons_Proforma.Text)
                            _oLogicaConsecutivo.ModificarConsecutivo(_oConsProforma)

                            _oConsReciboPorDinero.Bloqueo = False
                            _oConsReciboPorDinero.Consecutivo = CInt(txtCons_Recibo.Text)
                            _oLogicaConsecutivo.ModificarConsecutivo(_oConsReciboPorDinero)

                            MsgBox("Consecutivos actualizados con éxito", MsgBoxStyle.Information)
                        End If

                    Else
                        _oConsFactura.Bloqueo = False
                        _oLogicaConsecutivo.Modificar_Bloqueo(_oConsFactura)

                        _oConsAbono.Bloqueo = False
                        _oLogicaConsecutivo.Modificar_Bloqueo(_oConsAbono)

                        _oConsNotaCredito.Bloqueo = False
                        _oLogicaConsecutivo.Modificar_Bloqueo(_oConsNotaCredito)

                        _oConsProforma.Bloqueo = False
                        _oLogicaConsecutivo.Modificar_Bloqueo(_oConsProforma)

                        _oConsReciboPorDinero.Bloqueo = False
                        _oLogicaConsecutivo.Modificar_Bloqueo(_oConsReciboPorDinero)

                        MsgBox("Bloqueos actualizados con éxito", MsgBoxStyle.Information)

                    End If
                    MostrarConsucutivos()
                Else
                    MsgBox("Todos los consecutivos deben estar desbloqueados", MsgBoxStyle.Exclamation)
                End If
            Else
                MsgBox("Todos los campos de consecutivos deben estar llenos", MsgBoxStyle.Exclamation)
            End If

        End Sub

        Private Sub FrmAdministrar_Consecutivo_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub
    End Class
End Namespace