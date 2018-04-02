Namespace Interfaz.Proveedores
    Public Class FrmProductoConProveed

        Private Sub FrmProductoConProveed_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            With dgvProveedores
                .Columns(0).Visible = False
                .Columns(1).HeaderText = "Cod"
                .Columns(1).Width = 45
                .Columns(2).HeaderText = "Prioridad"
                .Columns(2).Width = 60
                .Columns(3).HeaderText = "Nombre"
                .Columns(3).Width = 250

            End With
        End Sub

        Private Sub FrmProductoConProveed_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub
    End Class
End Namespace