Imports Entidades
Imports Logica_Negocios

Namespace Interfaz.Proveedores
    Public Class FrmAbonoDocPorPagar

        Private ReadOnly _oUtilidades As New Utilidades

        '1- solo abono 2-cancelacion y abono
        Private _varPantalla As Integer
        Public Property Pantalla() As Integer
            Get
                Return _varPantalla
            End Get
            Set(ByVal value As Integer)
                _varPantalla = value
            End Set
        End Property

        Private Sub txtMontoAbonar_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtMontoAbonar.KeyDown
            If e.KeyData = Keys.Enter Then
                If IsNumeric(txtMontoAbonar.Text) Then
                    If txtMontoAbonar.Text > 0 Then
                        Dim actual = CDbl(txtMontoNeto.Text) - CDbl(txtMontoAbonar.Text)
                        txtMostrarAbono.Text = _oUtilidades.PasarMoneda(txtMontoAbonar.Text)
                        If actual > 0 Then
                            txtNuevoSaldo.Text = _oUtilidades.PasarMoneda(actual)
                            btnAbonar.Enabled = True
                            txtFecha.Focus()
                        Else
                            MsgBox("El monto del abono sobrepasa el total de la factura", MsgBoxStyle.Critical)
                        End If
                    Else
                        MsgBox("El monto del abono no puede ser 0", MsgBoxStyle.Critical)
                    End If
                End If
            End If
        End Sub

        Private Sub btnAbonar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAbonar.Click
            Dim abono As Double
            Dim saldoActual As Double
            Dim saldoTotal As Double
            Dim tipo As Integer
            If Pantalla = 1 Then
                abono = CDbl(txtMontoAbonar.Text)
                saldoActual = txtMontoNeto.Text - txtMontoAbonar.Text
                saldoTotal = txtMontoAbonar.Text
                tipo = 3
            ElseIf Pantalla = 2 Then
                abono = txtMostrarAbono.Text
                saldoActual = txtMontoNeto.Text - abono
                saldoTotal = txtMontoVuelto.Text
                tipo = 2
            End If

            Dim valido As Boolean = True
            valido = ValidarFecha(valido, txtFecha, "del abono")

            If valido Then
                With FrmCancelacionDeFacturasPorProveedor
                    Dim idDocPorPagar As Integer = CInt(txtId_DocPorPagar.Text)
                    Dim lineaRecibo As LineaRecibo
                    lineaRecibo = .CrearLineaRecibo(idDocPorPagar, "Fact", txtNumFactura.Text, .dgvFacturas.Rows(.dgvFacturas.CurrentRow.Index).Cells(3).Value, txtMonto.Text)
                    .agregarLinea_Recibo(lineaRecibo)

                    lineaRecibo = .CrearLineaRecibo(idDocPorPagar, "", 0, "Anterior", _oUtilidades.PasarMoneda(txtMontoNeto.Text))
                    .agregarLinea_Recibo(lineaRecibo)

                    lineaRecibo = .CrearLineaRecibo(idDocPorPagar, "AB", 0, CDate(txtFecha.Text).ToString("dd/MM/yyyy"), _oUtilidades.PasarMoneda(abono))
                    .agregarLinea_Recibo(lineaRecibo)

                    lineaRecibo = .CrearLineaRecibo(idDocPorPagar, "", 0, "Actual", _oUtilidades.PasarMoneda(saldoActual))
                    .agregarLinea_Recibo(lineaRecibo)

                    .Tipo = tipo
                    .FechaCancelacion = CDate(txtFecha.Text)
                    .OAbono.IdFacturaProveedor = CInt(txtId_DocPorPagar.Text)
                    .OAbono.Monto = txtMostrarAbono.Text
                    .lblMostrarAbono.Text = _oUtilidades.PasarMoneda(saldoTotal)
                    .lblActual.Text = _oUtilidades.PasarMoneda(CDbl(.lblMostrarAnterior.Text) - CDbl(.lblMostrarAbono.Text))
                End With
                Dispose()
            End If

        End Sub

        Private Sub FrmAbono_DocPorPagar_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            If Pantalla = 2 Then
                txtMontoAbonar.Visible = False
                lblMontoAbonar.Visible = False
                txtFacturasEscogidas.Text = _oUtilidades.PasarMoneda(FrmCancelacionDeFacturasPorProveedor.lblMostrarAbono.Text)
                txtMontoVuelto.Visible = True
                lblMontoTotal.Visible = True
                txtFacturasEscogidas.Visible = True
                lblFacturasEscogidas.Visible = True
                lblMostrarAbono.Text = "Abono (Vuelto) ¢"
                txtMontoVuelto.Focus()
                lblColonesCancelacion.Visible = True
                lblColonesSaldo.Visible = True
                lblColonesAbono.Visible = False
            End If

            txtFecha.Text = Now.ToString("dd/MM/yyyy")
            AddHandler txtMontoAbonar.KeyPress, AddressOf ValidarNumerosPunto
            AddHandler txtMontoVuelto.KeyPress, AddressOf ValidarNumerosPunto
            AddHandler txtFecha.KeyPress, AddressOf FormatoFecha
        End Sub

        Private Sub txtMontoCancelar_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtMontoVuelto.KeyDown
            If Pantalla = 2 Then
                If e.KeyData = Keys.Enter Then
                    If IsNumeric(txtMontoVuelto.Text) Then
                        If txtMontoVuelto.Text <> "0" Then
                            Dim abono = CDbl(txtMontoVuelto.Text) - CDbl(txtFacturasEscogidas.Text)
                            Dim actual = CDbl(txtMontoNeto.Text - abono)
                            txtMontoVuelto.Text = _oUtilidades.PasarMoneda(txtMontoVuelto.Text)
                            txtMostrarAbono.Text = _oUtilidades.PasarMoneda(abono)
                            If actual > 0 Then
                                txtNuevoSaldo.Text = _oUtilidades.PasarMoneda(actual)
                                btnAbonar.Enabled = True
                                txtFecha.Focus()
                            Else
                                MsgBox("El monto del abono sobrepasa el total de la factura", MsgBoxStyle.Critical)
                            End If
                        Else
                            MsgBox("El monto del abono no puede ser 0", MsgBoxStyle.Critical)
                        End If
                    End If

                End If
            End If
        End Sub

        Private Sub FrmAbono_DocPorPagar_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub

        Private Sub txtFecha_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtFecha.KeyDown
            If e.KeyData = Keys.Enter Then
                btnAbonar.Focus()
            End If
        End Sub
    End Class
End Namespace