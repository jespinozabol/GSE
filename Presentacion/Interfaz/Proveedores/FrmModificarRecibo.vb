Imports Logica_Negocios

Namespace Interfaz.Proveedores
    Public Class FrmModificarRecibo

        Private ReadOnly _oUtilidades As New Utilidades
        Private ReadOnly _oLogicaReciboDocPagar As New LogicaReciboDocPorPagar

        Private Sub FrmModificar_Recibo_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub

        Private Sub chkHoy_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkHoy.CheckedChanged
            If chkHoy.Checked Then
                txtFecha.Text = Now.Date.ToString("dd/MM/yyyy")
                txtNumRecibo.Focus()
            Else
                txtFecha.Text = String.Empty
                txtFecha.Focus()
            End If
        End Sub

        Private Sub FrmModificar_Recibo_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            AddHandler txtFecha.KeyPress, AddressOf FormatoFecha
        End Sub

        Private Sub txtFecha_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtFecha.KeyDown
            If e.KeyData = Keys.Enter Then txtNumRecibo.Focus()
        End Sub

        Private Sub txtNumRecibo_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNumRecibo.KeyDown
            If e.KeyData = Keys.Enter Then btnGuardar.Focus()
        End Sub

        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            Try
                _oLogicaReciboDocPagar.ModificarFechaDetalleRecibo(UCase(txtNumRecibo.Text), CDate(txtFecha.Text), CInt(txtNum_Recibo.Text), txtObservaciones.Text)
                MsgBox("Datos modificados con éxito", MsgBoxStyle.Information)
                FrmListaRecibos.BuscarFacturas()
                Dispose()
            Catch ex As Exception
                MsgBox("La fecha esta vacía o el formato es incorrecto", MsgBoxStyle.Exclamation)
            End Try
        End Sub
    End Class
End Namespace