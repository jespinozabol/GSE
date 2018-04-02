Imports Logica_Negocios

Namespace Interfaz.Proformas
    Public Class FrmExistenciasProforma

        Private ReadOnly _oUtilidades As New Utilidades

        Private Sub FrmExistenciasProforma_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            lblCodigo.Text = FrmProforma.txtCodigo.Text
            lblDescripcion.Text = FrmProforma.txtArticulo.Text
            lblCantidad.Text = FrmProforma.txtCantidad.Text

            Dim suma As Double

            suma = _oUtilidades.ValorUtil(FrmProforma.txtCantidad.Text) + _oUtilidades.ValorUtil(lblExistencias.Text)

            lblTotal.Text = suma
        End Sub

        Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAceptar.Click
            FrmProforma.actualizarCantidad(CDbl(lblTotal.Text))
            Dispose()
        End Sub

        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelar.Click
            Dispose()
        End Sub

        Private Sub FrmExistenciasProforma_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub
    End Class
End Namespace