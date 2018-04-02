Namespace Interfaz.Facturas
    Public Class FrmControlMsgBox

        Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAceptar.Click
            FrmFlujoCaja.MenosDinero = True
            Dispose()
        End Sub

        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelar.Click
            FrmFlujoCaja.MenosDinero = False
            Dispose()
        End Sub

        Private Sub FrmControl_MsgBox_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub
    End Class
End Namespace