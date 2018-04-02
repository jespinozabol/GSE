Imports Logica_Negocios
Namespace Interfaz.Proveedores
    Public Class FrmConsultaListadosPedidos

        Private ReadOnly _oLogicaPedidos As New LogicaPedido
        Private ReadOnly _oUtilidades As New Utilidades

        Private Sub ConsultaListadosPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ConsultarTodos()
        End Sub

        Public Sub ConsultarTodos()
            dgvListados.Rows.Clear()
            Dim listado = _oLogicaPedidos.ConsultarTodos

            For i As Integer = 0 To listado.Count - 1
                With dgvListados
                    .Rows.Add()
                    .Rows(i).Cells(0).Value = listado(i).IdPedido
                    Dim fechaListado As Date = listado(i).Fecha
                    .Rows(i).Cells(1).Value = fechaListado.ToString("dd/MM/yyyy")
                    .Rows(i).Cells(2).Value = listado(i).NombreProveedor
                    If (listado(i).Modificado) Then
                        .Rows(i).Cells(3).Value = "SI"
                        .Rows(i).Cells(3).Style.ForeColor = Color.Red
                    Else
                        .Rows(i).Cells(3).Value = "NO"
                    End If
                    If .Rows.Count > 0 Then .Rows(0).Selected = False
                End With
            Next
        End Sub

        Private Sub FrmConsultaListadosPedidos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub

        Private Sub dgvListados_Click(sender As Object, e As EventArgs) Handles dgvListados.Click
            If (dgvListados.Rows.Count > 0) Then
                Dim idPedido = dgvListados.Item(0, dgvListados.CurrentRow.Index).Value
                FrmListadoPedidos.txtId_Pedido.Text = idPedido
                FrmListadoPedidos.ActualizarCliente()
                FrmListadoPedidos.txtNombre.ReadOnly = True
                FrmListadoPedidos.txtNombre.Enabled = False
                FrmListadoPedidos.ShowDialog()
            End If
        End Sub
    End Class
End Namespace
