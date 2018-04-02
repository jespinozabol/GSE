Imports Entidades
Imports Logica_Negocios
Imports Entidades.Abono

Namespace Interfaz.Creditos
    Public Class FrmAbonos

        Private ReadOnly _oUtilidades As New Utilidades

        Private Sub FrmAbonos_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            Dim num = Split(txtNumAb.Text, "-")
            txtNumAb.Text = num(0)
            AddHandler txtMontoAbonar.KeyPress, AddressOf ValidarNumerosPunto
        End Sub

        Private Sub txtMontoAbonar_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtMontoAbonar.KeyDown
            If e.KeyData = Keys.Enter Then
                If IsNumeric(txtMontoAbonar.Text) Then
                    If txtMontoAbonar.Text <> "0" Then
                        Dim actual = CDbl(txtMontoNeto.Text) - CDbl(txtMontoAbonar.Text)

                        If actual > 0 Then
                            lblMostrarSaldo.Text = _oUtilidades.PasarMoneda(actual)
                            btnAbonar.Enabled = True
                        Else
                            MsgBox("El monto del abono sobrepasa el total de la factura")
                        End If
                    Else
                        MsgBox("El monto del abono no puede ser 0")
                    End If
                End If

            End If

        End Sub

        Private Sub btnAbonar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAbonar.Click
            With FrmFacturaCredito.dgvTrans1
                Dim lineaRecibo As LineaRecibo
                lineaRecibo = FrmFacturaCredito.CrearLineaRecibo(txtTipo.Text, txtNumDoc.Text, FrmFacturaCredito.dgvFacturas.Rows(FrmFacturaCredito.dgvFacturas.CurrentRow.Index).Cells(2).Value, txtMonto.Text)
                FrmFacturaCredito.AgregarLineaRecibo(lineaRecibo)

                lineaRecibo = FrmFacturaCredito.CrearLineaRecibo("AB", FrmFacturaCredito.lblMostrarReciboAbonos.Text, Now.ToString("dd/MM/yyyy"), _oUtilidades.PasarMoneda(txtMontoAbonar.Text))
                FrmFacturaCredito.AgregarLineaRecibo(lineaRecibo)

                lineaRecibo = FrmFacturaCredito.CrearLineaRecibo("SA", txtNumDoc.Text, Now.ToString("dd/MM/yyyy"), _oUtilidades.PasarMoneda(txtMontoNeto.Text - txtMontoAbonar.Text))
                FrmFacturaCredito.AgregarLineaRecibo(lineaRecibo)
            End With

            FrmFacturaCredito.Tipo = 3
            FrmFacturaCredito.OAbono.NumDoc = txtNumDoc.Text
            FrmFacturaCredito.OAbono.TipoDoc = DirectCast([Enum].Parse(GetType(ListaTipoDoc), txtTipo.Text), ListaTipoDoc)
            FrmFacturaCredito.OAbono.Monto = txtMontoAbonar.Text
            FrmFacturaCredito.lblMostrarAbono.Text = _oUtilidades.PasarMoneda(CDbl(txtMontoAbonar.Text))
            FrmFacturaCredito.lblActual.Text = _oUtilidades.PasarMoneda(CDbl(FrmFacturaCredito.lblMostrarAnterior.Text) - CDbl(txtMontoAbonar.Text))
            Dispose()
        End Sub

        Private Sub FrmAbonos_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub
    End Class
End Namespace