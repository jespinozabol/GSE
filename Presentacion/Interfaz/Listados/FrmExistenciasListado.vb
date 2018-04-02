Imports Entidades
Imports Logica_Negocios

Namespace Interfaz.Listados
    Public Class FrmExistenciasListado

        Private ReadOnly _oUtilidades As New Utilidades
        Private ReadOnly _oListadoHistorial As New ListadoHistorial

        Private Sub btnSumar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnSumar.Click
            Dim suma As Double

            lblTipo.Text = "Se va a sumar"
            Resumen.Visible = True
            suma = _oUtilidades.ValorUtil(FrmListado.txtCantidad.Text) + _oUtilidades.ValorUtil(lblExistencias.Text)

            lblTotal.Text = suma

            FrmListado.TipoTransaccion = True
            _oListadoHistorial.Cantidad = _oUtilidades.ValorUtil(FrmListado.txtCantidad.Text)


        End Sub

        Private Sub btnRestar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnRestar.Click
            Dim resta As Double

            resta = _oUtilidades.ValorUtil(lblExistencias.Text) - _oUtilidades.ValorUtil(FrmListado.txtCantidad.Text)

            If (resta < 0) Then
                MsgBox("La cantidad a restar es mayor a la cantidad entragada")
                Resumen.Visible = False
            Else
                lblTipo.Text = "Se va a restar"
                Resumen.Visible = True
                lblTotal.Text = resta

                FrmListado.TipoTransaccion = False
                _oListadoHistorial.Cantidad = -_oUtilidades.ValorUtil(FrmListado.txtCantidad.Text)
            End If

        End Sub

        Private Sub FrmExistenciasListado_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            lblCodigo.Text = FrmListado.txtCodigo.Text
            lblDescripcion.Text = FrmListado.txtArticulo.Text
            lblCantidad.Text = FrmListado.txtCantidad.Text
        End Sub

        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelar.Click
            Dispose()
        End Sub

        Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAceptar.Click
            _oListadoHistorial.Id_Producto = CInt(FrmListado.txtCodigo.Text)
            _oListadoHistorial.Fecha = Now.ToString("dd/MM/yyyy")

            If FrmListado.cmbAutorizados.Items.Count > 0 Then
                Dim cadena1 = Split(FrmListado.cmbAutorizados.SelectedItem, "-")
                Dim cadena2 = Split(cadena1(1), ":")
                _oListadoHistorial.Retira = cadena2(0).Substring(0, cadena2(0).Length - 5)
            Else
                _oListadoHistorial.Retira = FrmListado.txtNombre.Text
            End If

            _oListadoHistorial.Hora = Now.ToString("H:mm:ss")

            If Not FrmListado.txtId_Listado.Text = "" Then
                _oListadoHistorial.IdListado = CLng(FrmListado.txtId_Listado.Text)
            End If

            FrmListado.ActualizarCantidad(CDbl(lblTotal.Text), _oListadoHistorial)
            Dispose()
        End Sub

        Private Sub FrmExistenciasListado_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub
    End Class
End Namespace