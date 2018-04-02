Imports Presentacion.Interfaz.Proveedores

Public Class FrmDevolucionPorPaquete

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        FrmDevoluciones.ShowDialog()
    End Sub

    Private Sub btnPaquetes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmPaquetes.ShowDialog()
    End Sub

    Private Sub FrmDevolucionPorPaquete_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
End Class