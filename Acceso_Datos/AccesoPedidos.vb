Imports MySql.Data.MySqlClient
Imports Entidades
Public Class AccesoPedidos
    Inherits Transaccion

    Private Sub InicializarParametros(ByVal oComando As MySqlCommand, ByVal oPedido As Pedido)
        oComando.Parameters.AddWithValue("@IdPedido", oPedido.IdPedido)
        oComando.Parameters.AddWithValue("@Fecha", oPedido.Fecha)
        oComando.Parameters.AddWithValue("@IdProveedor", oPedido.IdProveedor)
        oComando.Parameters.AddWithValue("@Modificado", oPedido.Modificado)
        oComando.Parameters.AddWithValue("@Transporte", oPedido.Transporte)
        Return
    End Sub

    Public Sub Insertar(ByVal oPedido As Pedido)
        Const sql As String = "INSERT INTO PEDIDO_ENCABEZADO (Fecha,IdProveedor,Modificado,Transporte) VALUES (@Fecha, @IdProveedor, @Modificado, @Transporte) ; SELECT @@Identity"
        Dim oComando As New MySqlCommand(sql, Conexion)
        InicializarParametros(oComando, oPedido)

        Try
            Dim idPedido = InsertarDatosDevuelveId(oComando)

            For i As Integer = 0 To oPedido.PedidoDetalle.Count - 1
                oPedido.PedidoDetalle(i).IdPedido = idPedido
                Insertar_Detalle(oPedido.PedidoDetalle(i))
            Next i
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Insertando pedido")
        End Try
    End Sub

    Public Sub Eliminar_Pedido(ByVal idPedido As Integer)
        Eliminar_Detalles(idPedido)
        Dim sql = String.Format("DELETE FROM PEDIDO_ENCABEZADO WHERE IdPedido = {0}", idPedido)

        Try
            EliminarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Eliminando pedido detalle")
        End Try
    End Sub

    'Cambia codigo que se cambie en el pedido
    'Public Sub TrasladarCodigoProducto(ByVal idProducto As Long, ByVal idTraslado As Long)
    '    Dim sql As String = "UPDATE PROFORMA_DETALLE SET Id_Producto = " & idTraslado & " WHERE Id_Producto = " & idProducto
    '    Try
    '        ModificarDatos(sql)
    '    Catch ex As Exception
    '        MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Trasladando código producto")
    '    End Try
    'End Sub

    Public Function ConsultarTodos() As List(Of Pedido)
        Dim sql As String = "SELECT pedido.*, proveedor.Nombre FROM PEDIDO_ENCABEZADO AS pedido INNER JOIN proveedor ON pedido.IdProveedor = proveedor.Id_Proveedor"
        Return DevolverListados(sql)
    End Function

    Public Function ConsultarPorIdProducto(ByVal idProducto As Integer) As DataTable
        Dim sql = String.Format("SELECT e.Fecha,d.Cantidad,proveedor.Nombre " +
                            "FROM pedido_detalle As d " +
                            "INNER JOIN pedido_encabezado as e on d.IdPedido = e.IdPedido " +
                            "INNER JOIN proveedor on e.IdProveedor = proveedor.Id_Proveedor " +
                            "WHERE d.IdProducto = {0}", idProducto)
        Dim oDataTable = New DataTable
        Try
            oDataTable = ConsultarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando lista de pedidos")
        End Try

        Return oDataTable
    End Function

    Public Function Consultar(ByVal numPedido As Integer) As Pedido
        Dim sql As String = "SELECT pedido.*, proveedor.Nombre FROM PEDIDO_ENCABEZADO AS pedido INNER JOIN proveedor ON pedido.IdProveedor = proveedor.Id_Proveedor WHERE IdPedido = " & numPedido
        Dim oPedido As New Pedido
        Try
            Dim oDataTable = ConsultarDatos(sql)
            If oDataTable.Rows.Count > 0 Then
                oPedido = LlenarPedido(oDataTable.Rows(0))
            Else
                oPedido.IdPedido = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando pedido")
        End Try

        Return oPedido
    End Function

    'Consulta todos los listados que concuerden con el nombre y que no esten facturados.
    Public Function ConsultarPorProveedor(ByVal nombre As String) As List(Of Pedido)
        Dim sql = String.Format("SELECT pedido.*, proveedor.Nombre FROM PEDIDO_ENCABEZADO as pedido " +
                                " INNER JOIN proveedor ON pedido.IdProveedor = proveedor.Id_Proveedor " +
                                " WHERE proveedor.Nombre like '%{0}%' order by Nombre", nombre)
        Return DevolverListados(sql)
    End Function

    Private Function DevolverListados(ByVal sql As String) As List(Of Pedido)
        Dim oListaPedidos As New List(Of Pedido)
        Try
            Dim oDataTable = ConsultarDatos(sql)
            For i = 0 To oDataTable.Rows.Count - 1
                oListaPedidos.Add(LlenarPedido(oDataTable.Rows(i)))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando lista de pedidos")
        End Try

        Return oListaPedidos
    End Function

    Private Function LlenarPedido(ByVal row As DataRow) As Pedido
        Dim oPedido As New Pedido
        oPedido.IdPedido = row.Item(0)
        oPedido.Fecha = row.Item(1)
        oPedido.IdProveedor = row.Item(2)
        oPedido.Modificado = row.Item(3)
        oPedido.Transporte = Convert.ToString(row.Item(4))
        oPedido.NombreProveedor = row.Item(5)
        oPedido.PedidoDetalle = Consultar_Detalle(oPedido.IdPedido)
        oPedido.ImprimeDTOModel = ConsultarImprime(oPedido.IdPedido)
        Return oPedido
    End Function

    Sub TrasladarPedido(idPedido As Integer, IdProveedorTraslado As Integer)
        Dim sql = String.Format("UPDATE pedido_encabezado SET IdProveedor = {0}, Fecha  = DATE(Now()), Modificado = {2} WHERE IdPedido = {1}", IdProveedorTraslado, idPedido, False)

        Try
            EjecutarSql(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Trasladando pedido")
        End Try
    End Sub

    Sub UpdateModificado(ByVal idPedido As Integer, ByVal modificado As Boolean)
        Dim sql = String.Format("UPDATE pedido_encabezado SET Modificado = {1} WHERE IdPedido = {0}", idPedido, modificado)

        Try
            EjecutarSql(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Actulizando modificacion del pedido")
        End Try
    End Sub

    '******************************************PEDIDO DETALLE****************************************************

    Private Sub InicializarParametrosDetalle(ByVal oComando As MySqlCommand, ByVal oPedidoDetalle As PedidoDetalle)
        oComando.Parameters.AddWithValue("@IdPedido", oPedidoDetalle.IdPedido)
        oComando.Parameters.AddWithValue("@IdProducto", oPedidoDetalle.IdProducto)
        oComando.Parameters.AddWithValue("@Cantidad", oPedidoDetalle.Cantidad)
        oComando.Parameters.AddWithValue("@CantidadRecibida", oPedidoDetalle.CantidadRecibida)
        Return
    End Sub

    Private Sub Insertar_Detalle(ByVal oPedidoDetalle As PedidoDetalle)
        Const sql As String = "INSERT INTO PEDIDO_DETALLE VALUES (@IdPedido, @IdProducto, @Cantidad, @CantidadRecibida)"
        Dim oComando As New MySqlCommand(sql, Conexion)
        InicializarParametrosDetalle(oComando, oPedidoDetalle)

        Try
            InsertarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Insertando pedido detalle")
        End Try
    End Sub

    Public Sub Eliminar_Detalles(ByVal idPedido As Integer)
        Dim sql = String.Format("DELETE FROM PEDIDO_DETALLE WHERE IdPedido = {0}", idPedido)

        Try
            EliminarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Eliminando detalles del pedido")
        End Try
    End Sub

    Public Sub Eliminar_DetallePorIdProducto(ByVal idProducto As Integer)
        Dim sql = String.Format("SELECT IdPedido FROM PEDIDO_DETALLE Where IdProducto = {0}", idProducto)
        Dim pedidos = ConsultarDatos(sql)

        If (pedidos.Rows.Count > 0) Then
            Dim idPedido = pedidos.Rows(0).Item(0)
            sql = String.Format("DELETE FROM PEDIDO_DETALLE WHERE IdProducto = {0}", idProducto)

            Try
                EliminarDatos(sql)
                UpdateModificado(idPedido, True)
            Catch ex As Exception
                MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Eliminando pedido detalle")
            End Try
        End If
        
    End Sub

    Public Function Consultar_Detalle(ByVal idPedido As Integer) As List(Of PedidoDetalle)
        Dim sql As String = "SELECT * FROM PEDIDO_DETALLE WHERE IdPedido = " & idPedido
        Dim oListaPedidoDetalle As New List(Of PedidoDetalle)
        Try
            Dim oDataTable = ConsultarDatos(sql)
            For i = 0 To oDataTable.Rows.Count - 1
                oListaPedidoDetalle.Add(LlenarDetalle(oDataTable.Rows(i)))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando lista de proformas detalle")
        End Try

        Return oListaPedidoDetalle
    End Function

    Private Function LlenarDetalle(ByVal row As DataRow) As PedidoDetalle
        Dim oDetalle As New PedidoDetalle
        oDetalle.IdPedido = row.Item(0)
        oDetalle.IdProducto = row.Item(1)
        oDetalle.Cantidad = row.Item(2)
        oDetalle.CantidadRecibida = row.Item(3)
        Return oDetalle
    End Function


    Public Function ConsultarImprime(ByVal idPedido As Integer) As List(Of ImprimeDTOModel)
        Dim sql As String = "SELECT p.Id_Producto,p.Descripcion,d.Cantidad " _
                    & " FROM PEDIDO_DETALLE AS d" _
                    & " INNER JOIN producto AS p ON d.IdProducto = p.Id_Producto" _
                    & " WHERE d.IdPedido = " & idPedido
        Dim oListaPedidoDetalle As New List(Of ImprimeDTOModel)
        Try
            Dim oDataTable = ConsultarDatos(sql)
            For i = 0 To oDataTable.Rows.Count - 1
                oListaPedidoDetalle.Add(LlenarDTOModel(oDataTable.Rows(i)))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando datos para imprimir pedido detalle")
        End Try

        Return oListaPedidoDetalle
    End Function

    Private Function LlenarDTOModel(ByVal row As DataRow) As ImprimeDTOModel
        Dim oDetalle As New ImprimeDTOModel
        oDetalle.Codigo = row.Item(0)
        oDetalle.Descripcion = row.Item(1)
        oDetalle.Pedir = row.Item(2)
        Return oDetalle
    End Function

    Sub Actualizar_DetallePorIdProducto(idProducto As Integer, cantidadRecibida As Integer)
        Dim sql = String.Format("UPDATE pedido_detalle SET  CantidadRecibida = {1} WHERE IdProducto = {0}", idProducto, cantidadRecibida)

        Try
            EjecutarSql(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Actulizando cantidad recibida")
        End Try
    End Sub

   
End Class
