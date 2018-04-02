Imports Logica_Negocios

Namespace Interfaz.Proveedores
    Public Class FrmConsultaProveedores

        Private ReadOnly _oLogicaProveedor As New LogicaProveedor

        Private Sub FrmConsulta_Proveedores_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            Dim listaProveedor = _oLogicaProveedor.ConsultarLista
            With dgvProveedores
                dgvProveedores.DataSource = listaProveedor

                .Columns(0).HeaderText = "Código"
                .Columns(0).Width = 50
                .Columns(1).Width = 300
                .Columns(2).HeaderText = "Conocido Como"
                .Columns(2).Width = 120
                .Columns(3).HeaderText = "Teléfono"
                .Columns(3).Width = 72
                .Columns(4).HeaderText = "Fax"
                .Columns(4).Width = 72
                If .RowCount > 0 Then .Rows(0).Selected = False
            End With

        End Sub

        Private Sub dgvProveedores_CellContentClick(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvProveedores.CellContentClick
            FrmProveedor.limpiarTodo()
            FrmProveedor.txtId_Proveedor.Text = dgvProveedores.Item(0, dgvProveedores.CurrentRow.Index).Value
            FrmProveedor.llenarProveedor(dgvProveedores.Item(0, dgvProveedores.CurrentRow.Index).Value)
            Dispose()
        End Sub

        Private Sub FrmConsulta_Proveedores_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub
    End Class
End Namespace