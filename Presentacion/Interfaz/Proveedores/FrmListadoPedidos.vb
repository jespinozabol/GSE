Imports Logica_Negocios
Imports Entidades

Namespace Interfaz.Proveedores
    Public Class FrmListadoPedidos

        Private ReadOnly _oLogicaPedidos As New LogicaPedido
        Private ReadOnly _oUtilidades As New Utilidades
        Private ReadOnly _oLogicaProducto As New LogicaProducto

        Private Sub txtNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombre.KeyDown
            CambiarControlADataGrid(dgvProveedores, e, txtNombre, txtFechaCreacion, txtFechaCreacion)
        End Sub

        Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
            BuscarListadoPedidoPorNombreProveedor(dgvProveedores, e, txtNombre, txtId_Pedido)
        End Sub

        Private Sub dgvProveedores_Click(sender As Object, e As EventArgs) Handles dgvProveedores.Click
            LlenarDatosCliente()
        End Sub

        Private Sub LlenarDatosCliente()
            With dgvProveedores
                Dim idPedido = .Item(0, .CurrentRow.Index).Value
                LimpiarTodo()
                txtId_Pedido.Text = idPedido
                ActualizarCliente()
                .Visible = False
            End With
        End Sub

        Public Sub ActualizarCliente()
            Dim oPedido = _oLogicaPedidos.Consultar(CInt(txtId_Pedido.Text))

            txtNombre.Text = oPedido.NombreProveedor
            txtFechaCreacion.Text = oPedido.Fecha

            If (oPedido.Modificado) Then
                lblMostrarModificado.Text = "SI"
            Else
                lblMostrarModificado.Text = "NO"

            End If

            For j = 0 To oPedido.PedidoDetalle.Count - 1

                Dim cantidad = _oUtilidades.PasarMoneda(oPedido.PedidoDetalle(j).Cantidad)
                Dim recibido = _oUtilidades.PasarMoneda(oPedido.PedidoDetalle(j).CantidadRecibida)
                Dim idProducto = oPedido.PedidoDetalle(j).IdProducto
                Dim descripcion = _oLogicaProducto.ConsultarDescripcion(idProducto)
                dgvProductos.Rows.Add(True, cantidad, recibido, idProducto, descripcion)
                If (recibido > 0) Then dgvProductos.Rows(dgvProductos.Rows.Count - 1).Cells(2).Style.ForeColor = Color.Red
            Next
        End Sub

        Private Sub dgvProveedores_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvProveedores.KeyDown
            If e.KeyValue = 13 Then
                LlenarDatosCliente()
            End If
        End Sub

        Public Sub LimpiarTodo()
            txtId_Pedido.Text = String.Empty
            txtFechaCreacion.Text = String.Empty
            txtNombre.Text = String.Empty
            dgvProveedores.Visible = False
            dgvProductos.Rows.Clear()
            txtNombre.Enabled = True
            txtNombre.ReadOnly = False
            txtNombre.Focus()
        End Sub

        Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
            LimpiarTodo()
        End Sub

        Private Sub FrmListadoPedidos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
            FrmConsultaListadosPedidos.ConsultarTodos()
            Me.Dispose()
        End Sub

        Private Sub txtNombre_Click(sender As Object, e As EventArgs) Handles txtNombre.Click
            LimpiarTodo()
        End Sub

        Private Sub btnReprocesarPedido_Click(sender As Object, e As EventArgs) Handles btnReprocesarPedido.Click
            If Not String.IsNullOrWhiteSpace(txtNombre.Text) Then
                Dim pedido As New Pedido
                pedido.IdPedido = txtId_Pedido.Text
                pedido.NombreProveedor = txtNombre.Text
                pedido.Fecha = txtFechaCreacion.Text
                FrmTrasladarPedido.oPedido = pedido
                FrmTrasladarPedido.ShowDialog()
                Dispose()
            End If
        End Sub

        Private Sub FrmListadoPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub

        Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
            Dim respuesta = MsgBox("Esta seguro que desea eliminar este pedido?", vbQuestion + vbYesNo, "Eliminar pedido...")

            If Not String.IsNullOrWhiteSpace(txtNombre.Text) Then
                If respuesta = vbYes Then
                    _oLogicaPedidos.Eliminar(CInt(txtId_Pedido.Text))
                    LimpiarTodo()
                End If
            Else
                MsgBox("No existe ningun pedido seleccionado", MsgBoxStyle.Exclamation)
            End If
            Me.Close()

        End Sub

        Private Sub lblModificado_Click(sender As Object, e As EventArgs) Handles lblModificado.Click

        End Sub

        Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
            Dim respuesta = MsgBox("Esta seguro que desea imprimir este pedido?", vbQuestion + vbYesNo, "Eliminar pedido...")

            If Not String.IsNullOrWhiteSpace(txtNombre.Text) Then
                Dim pedido = New Pedido
                pedido = _oLogicaPedidos.Consultar(CInt(txtId_Pedido.Text))
                FrmPedidos.ImprimirPedido(pedido, False)
            End If
        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            FrmSeleccionarEmails.lblMostrarProveedor.Text = txtNombre.Text
            FrmSeleccionarEmails.btnEnviar.Visible = True
            FrmSeleccionarEmails.btnAceptar.Visible = False
            FrmSeleccionarEmails.IdPedido = CInt(txtId_Pedido.Text)
            FrmSeleccionarEmails.ShowDialog()
        End Sub
    End Class
End Namespace
