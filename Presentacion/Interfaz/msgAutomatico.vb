Namespace Interfaz
    Public Class msgAutomatico

        Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAceptar.Click
            Dispose()
        End Sub

        Private Sub timerCerrar_Tick(ByVal sender As System.Object, ByVal e As EventArgs) Handles timerCerrar.Tick
            Dispose()
        End Sub

        Private Sub msgAutomatico_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub
    End Class
End Namespace