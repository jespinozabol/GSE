Imports Entidades
Imports Logica_Negocios
Namespace Interfaz.Proveedores
    Public Class FrmTrasladarPedido

        Public oPedido As Pedido
        Private ReadOnly _oLogicaPedidos As New LogicaPedido

        Private Sub FrmTrasladarPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            txtNombre.Text = oPedido.NombreProveedor
            txtFechaCreacion.Text = oPedido.Fecha
            txtId_Pedido.Text = oPedido.IdPedido
        End Sub

        Private Sub txtNombreTrasladar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombreTrasladar.KeyDown
            CambiarControlADataGrid(dgvProveedores, e, txtNombreTrasladar, txtFechaCreacion, txtFechaCreacion)
        End Sub

        Private Sub txtNombreTrasladar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreTrasladar.KeyPress
            BuscarProveedorPorNombre(dgvProveedores, e, txtNombreTrasladar, txtId_Pedido)
        End Sub

        Private Sub dgvProveedores_Click(sender As Object, e As EventArgs) Handles dgvProveedores.Click
            LlenarDatosCliente()
        End Sub

        Private Sub LlenarDatosCliente()
            With dgvProveedores
                txtIdProveedorTrasladar.Text = .Item(0, .CurrentRow.Index).Value
                txtNombreTrasladar.Text = .Item(1, .CurrentRow.Index).Value
                .Visible = False
            End With
        End Sub

        Private Sub dgvProveedores_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvProveedores.KeyDown
            If e.KeyValue = 13 Then
                LlenarDatosCliente()
            End If
        End Sub

        Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
            Dim respuesta = MsgBox("Esta seguro que desea trasladar este pedido?", vbQuestion + vbYesNo, "Trasladar pedido...")

            If Not String.IsNullOrWhiteSpace(txtIdProveedorTrasladar.Text) Then
                If respuesta = vbYes Then
                    _oLogicaPedidos.TrasladarPedido(CInt(txtId_Pedido.Text), CInt(txtIdProveedorTrasladar.Text))
                    FrmPedidos.rbProveedor.Checked = True
                    FrmProveedor.txtNombre.Text = txtNombreTrasladar.Text
                    Dispose()
                End If
            Else
                MsgBox("Debe seleccionar el proveedor a trasladar el pedido", MsgBoxStyle.Exclamation)
            End If
        End Sub

        Private Sub dgvProveedores_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dgvProveedores.KeyPress
            
        End Sub
    End Class
End Namespace
