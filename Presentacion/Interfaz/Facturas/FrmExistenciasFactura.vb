Imports Logica_Negocios

Namespace Interfaz.Facturas
    Public Class FrmExistenciasFactura

        Private ReadOnly _oUtilidades As New Utilidades

        Private Sub FrmExistenciasFactura_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            lblCodigo.Text = FrmFacturar.txtCodigo.Text
            lblDescripcion.Text = FrmFacturar.txtArticulo.Text
            lblCantidad.Text = FrmFacturar.txtCantidad.Text

            Dim suma As Double

            suma = _oUtilidades.ValorUtil(FrmFacturar.txtCantidad.Text) + _oUtilidades.ValorUtil(lblExistencias.Text)

            lblTotal.Text = suma
        End Sub

        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelar.Click
            Dispose()
        End Sub

        Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAceptar.Click
            FrmFacturar.ActualizarCantidad(CDbl(lblTotal.Text))
            Dispose()
        End Sub

        Private Sub FrmExistenciasFactura_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub
    End Class
End Namespace