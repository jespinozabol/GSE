Namespace Interfaz.Creditos
    Public Class FrmHistorialAbonos

        Private Sub FrmHistorial_Abonos_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            With dgvAbonos
                .Columns("IdAbono").HeaderText = "# Abono"
                .Columns("IdAbono").Width = 56
                .Columns("NumDoc").Visible = False
                .Columns("Fecha").Width = 75
                .Columns("Monto").Width = 70
                .Columns("Observaciones").Width = 190
                .Columns("Estado").Visible = False
                .Columns("TipoDoc").Visible = False
            End With
        End Sub

        Private Sub FrmHistorialAbonos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub
    End Class
End Namespace