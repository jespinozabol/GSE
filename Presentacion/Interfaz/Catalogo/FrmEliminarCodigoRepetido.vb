Imports Logica_Negocios

Namespace Interfaz.Catalogo
    Public Class FrmEliminarCodigoRepetido

        Private ReadOnly _oLogicaProducto As New LogicaProducto

        Private Sub txtCodigo_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
            Dim keyAscii As Short = CShort(Asc(e.KeyChar))
            If Not keyAscii = 13 Then
                Dim oProducto = BuscarProductoPorCodigo(e, txtCodigo)
                If oProducto.Id_Producto <> 0 Then
                    lblNuevoDescripción.Text = oProducto.Descripcion
                Else
                    lblNuevoDescripción.Text = ""
                End If
            End If
        End Sub

        Private Sub txtCodigo_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
            If e.KeyData = Keys.Enter And lblNuevoDescripción.Text <> "" Then
                btnEliminar.Focus()
            End If
        End Sub

        Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnEliminar.Click
            If Trim(txtCodigo.Text) <> "" And lblNuevoDescripción.Text <> "" Then
                Dim respuesta As String
                respuesta = MsgBox("Esta seguro que desea trasladar los datos relacionados del código al otro código y eliminar este?", vbInformation + vbYesNo, "Trasladar código...")

                If respuesta = vbYes Then
                    _oLogicaProducto.EliminarRepetido(CLng(lblMostrarCodigo.Text), CLng(txtCodigo.Text))
                    MsgBox("Producto repetido eliminado con éxito")
                    FrmCatalogoMateriales.LimpiarTodo()
                    FrmCatalogoMateriales.MarcarProducto()
                    FrmCatalogoMateriales.txtCodigo.Text = String.Empty
                    Dispose()
                    FrmCatalogoMateriales.txtDescripcion.Focus()
                End If
            Else
                MsgBox("Debe escribir un código que exista", MsgBoxStyle.Exclamation)
            End If
        End Sub

        Private Sub FrmEliminarCodigoRepetido_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub
    End Class
End Namespace