Imports Logica_Negocios

Namespace Interfaz.Catalogo
    Public Class FrmTrasladarCodigo

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
                btnTrasladar.Focus()
            End If
        End Sub

        Private Sub btnTrasladar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnTrasladar.Click
            Dim respuesta As String
            respuesta = MsgBox("Esta seguro que desea trasladar este código?", vbCritical + vbYesNo, "Trasladar código...")

            If respuesta = vbYes Then
                If Trim(txtCodigo.Text) <> "" And lblNuevoDescripción.Text = "" Then
                    Dim producto = _oLogicaProducto.Consultar(CLng(lblMostrarCodigo.Text))
                    _oLogicaProducto.TrasladarCodigo(producto, CLng(txtCodigo.Text))
                    MsgBox("Producto traslado con éxito al código: " & txtCodigo.Text)
                    FrmCatalogoMateriales.LimpiarTodo()
                    FrmCatalogoMateriales.txtCodigo.Text = txtCodigo.Text
                    FrmCatalogoMateriales.MarcarProducto()
                    FrmCatalogoMateriales.txtCodigo.Text = String.Empty
                    Dispose()
                    FrmCatalogoMateriales.txtDescripcion.Focus()
                Else
                    MsgBox("Debe escribir un código que no exista", MsgBoxStyle.Exclamation)
                End If
            End If
        End Sub

        Private Sub FrmTrasladarCodigo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub
    End Class
End Namespace