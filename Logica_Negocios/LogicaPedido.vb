Imports Acceso_Datos
Imports Entidades
Public Class LogicaPedido
    Private ReadOnly _oAccesoPedidos As New AccesoPedidos

    Function Consultar(ByVal idPedido As Integer) As Pedido
        Return _oAccesoPedidos.Consultar(idPedido)
    End Function

    Function ConsultarPorIdProducto(ByVal idProducto As Integer) As DataTable
        Return _oAccesoPedidos.ConsultarPorIdProducto(idProducto)
    End Function

    Function ConsultarPorNombre(ByVal nombre As String) As List(Of Pedido)
        Return _oAccesoPedidos.ConsultarPorProveedor(nombre)
    End Function

    Function ConsultarTodos() As List(Of Pedido)
        Return _oAccesoPedidos.ConsultarTodos()
    End Function

    Sub Insertar(ByVal pedido As Pedido)
        _oAccesoPedidos.Insertar(pedido)
    End Sub

    Sub EliminarDetalle(ByVal idProducto As Integer)
        _oAccesoPedidos.Eliminar_DetallePorIdProducto(idProducto)
    End Sub

    Sub ActualizarDetalle(ByVal idProducto As Integer, ByVal cantidadRecibida As Integer)
        _oAccesoPedidos.Actualizar_DetallePorIdProducto(idProducto, cantidadRecibida)
    End Sub

    Sub TrasladarPedido(ByVal idPedido As Integer, ByVal IdProveedorTraslado As Integer)
        _oAccesoPedidos.TrasladarPedido(idPedido, IdProveedorTraslado)
    End Sub

    Sub Eliminar(ByVal idPedido As Integer)
        _oAccesoPedidos.Eliminar_Pedido(idPedido)
    End Sub

End Class
