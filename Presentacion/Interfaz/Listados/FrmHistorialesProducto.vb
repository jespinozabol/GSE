Imports Entidades

Namespace Interfaz.Listados
    Public Class FrmHistorialesProducto

        Sub ModificarGridHistrorial(ByVal oLista As List(Of ListadoHistorial))
            With dgvProductos
                .DataSource = oLista
                .Columns("IdListado").Visible = False
                .Columns("Id_Producto").Visible = False
                .Columns("Cantidad").Width = 65
                .Columns("Fecha").Width = 75
                .Columns("Retira").Width = 226
                .Columns("Hora").Width = 65
            End With
        End Sub

        Private Sub FrmHistoriales_Producto_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub
    End Class
End Namespace