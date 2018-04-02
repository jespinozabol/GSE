Imports Entidades
Imports Logica_Negocios

Namespace Interfaz.Listados
    Public Class FrmMostrarListado

        Private ReadOnly _oLogicaListado As New LogicaListado
        Private ReadOnly _oLogicaProducto As New LogicaProducto

        Private Sub FrmMostrarListado_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            LimpiarTodo()
            txtId_Listado.Text = FrmConsultaListadosFacturados.dgvListados.Item(0, FrmConsultaListadosFacturados.dgvListados.CurrentRow.Index).Value
            ActualizarCliente()
        End Sub

        Public Sub LimpiarTodo()
            txtId_Listado.Text = String.Empty
            txtNombre.Text = String.Empty
            txtTelfCliente.Text = String.Empty
            dgvProductos.Rows.Clear()
            dgvAutorizados.Rows.Clear()
            txtFecha.Text = String.Empty
        End Sub

        Public Sub ActualizarCliente()
            Dim oListado As Listado
            oListado = _oLogicaListado.consultarPorIdConInfo(CInt(txtId_Listado.Text))

            txtNombre.Text = oListado.NombreCliente
            txtTelfCliente.Text = oListado.Telefono
            txtFecha.Text = oListado.Fecha

            For i = 0 To oListado.ListaAutorizados.Count - 1
                dgvAutorizados.Rows.Add(oListado.ListaAutorizados(i).Nombre, oListado.ListaAutorizados(i).Telefono)
            Next

            If dgvAutorizados.Rows.Count > 0 Then dgvAutorizados.Rows(0).Selected = False

            For j = 0 To oListado.ListaResumen.Count - 1
                Dim descripcionArticulo = _oLogicaProducto.ConsultarDescripcion(oListado.ListaResumen(j).Id_Producto)

                dgvProductos.Rows.Add("Ver", oListado.ListaResumen(j).Cantidad, oListado.ListaResumen(j).Id_Producto, descripcionArticulo)
            Next
            If dgvProductos.Rows.Count > 0 Then dgvProductos.Rows(0).Selected = False
        End Sub

        Private Sub dgvProductos_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvProductos.Click
            With dgvProductos
                If .Rows(.CurrentRow.Index).Cells(0).Selected Then
                    Dim lista = _oLogicaListado.consultarHistorial(txtId_Listado.Text, .Rows(.CurrentRow.Index).Cells(2).Value)
                    FrmHistorialesProducto.ModificarGridHistrorial(lista)
                    FrmHistorialesProducto.ShowDialog()
                End If
            End With
        End Sub

        Private Sub FrmMostrarListado_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub
    End Class
End Namespace