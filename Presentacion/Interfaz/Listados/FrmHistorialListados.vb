Imports Logica_Negocios

Namespace Interfaz.Listados
    Public Class FrmHistorialListados

        Private ReadOnly _oLogicaListado As New LogicaListado
        Private ReadOnly _oLogicaProducto As New LogicaProducto

        Private Sub FrmHistorial_Listados_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            Dim listado = _oLogicaListado.ConsultarHistorial(FrmListado.OListado.IdListado)

            For i As Integer = 0 To listado.Count - 1
                With dgvListados
                    Dim esta = False
                    For j = 0 To .Rows.Count - 1
                        If .Rows(j).Cells(2).Value = listado(i).Id_Producto Then
                            esta = True
                            .Rows(j).Cells(1).Value = .Rows(j).Cells(1).Value + listado(i).Cantidad
                        End If
                    Next

                    If Not esta Then
                        Dim descripcionArticulo = _oLogicaProducto.ConsultarDescripcion(listado(i).Id_Producto)
                        .Rows.Add("Ver", listado(i).Cantidad, listado(i).Id_Producto, descripcionArticulo)
                    End If
                End With
            Next

            If dgvListados.Rows.Count > 0 Then dgvListados.Rows(0).Selected = False
        End Sub

        Private Sub dgvListados_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvListados.Click
            With dgvListados
                If .Rows(.CurrentRow.Index).Cells(0).Selected Then
                    Dim lista = _oLogicaListado.ConsultarHistorial(FrmListado.OListado.IdListado, .Rows(.CurrentRow.Index).Cells(2).Value)
                    FrmHistorialesProducto.ModificarGridHistrorial(lista)
                    FrmHistorialesProducto.ShowDialog()
                End If
            End With
        End Sub

        Private Sub FrmHistorial_Listados_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub
    End Class
End Namespace