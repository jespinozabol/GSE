Imports MySql.Data.MySqlClient
Imports Entidades
Public Class AccesoProducto
    Inherits Transaccion

    Private ReadOnly _oAccesoProveedor As New AccesoProveedor

    Private Sub InicializarParametros(ByVal oComando As MySqlCommand, ByVal oProducto As Producto)
        oComando.Parameters.AddWithValue("@Id_Producto", oProducto.Id_Producto)
        oComando.Parameters.AddWithValue("@Descripcion", oProducto.Descripcion)
        oComando.Parameters.AddWithValue("@PrecioUnitario", oProducto.PrecioUnitario)
        oComando.Parameters.AddWithValue("@Ganancia", oProducto.Ganancia)
        oComando.Parameters.AddWithValue("@Existencias", oProducto.Existencias)
        oComando.Parameters.AddWithValue("@Impuesto", oProducto.Impuesto)
        oComando.Parameters.AddWithValue("@Minimo", oProducto.Minimo)
        oComando.Parameters.AddWithValue("@Maximo", oProducto.Maximo)
        oComando.Parameters.AddWithValue("@Activo", oProducto.Activo)
        oComando.Parameters.AddWithValue("@Consignacion", oProducto.Consignacion)
        oComando.Parameters.AddWithValue("@MaxVendido", oProducto.MaxVendido)
        Return
    End Sub

    Public Sub Insertar(ByVal oProducto As Producto, ByVal traslado As Boolean)
        Const sql As String = "INSERT INTO PRODUCTO VALUES (@Id_Producto, @Descripcion,@PrecioUnitario, @Ganancia, @Existencias, @Impuesto, @Minimo,@Maximo,@Activo,@Consignacion,@MaxVendido)"
        Dim oComando As New MySqlCommand(sql, Conexion)
        InicializarParametros(oComando, oProducto)

        Try
            InsertarDatos(oComando)

            If oProducto.ListaProveedores.Count > 0 Then
                If traslado Then
                    For i As Integer = 0 To oProducto.ListaProveedores.Count - 1
                        Eliminar_ProductoPorProveedor(oProducto.ListaProveedores(i).Id_Producto, oProducto.ListaProveedores(i).IdProveedor)
                    Next
                End If

                For i As Integer = 0 To oProducto.ListaProveedores.Count - 1
                    oProducto.ListaProveedores(i).Id_Producto = oProducto.Id_Producto
                    Insertar_ProductoPorProveedor(oProducto.ListaProveedores(i))
                Next i
            End If

            If oProducto.ListaRelacionados.Count > 0 Then
                If traslado Then
                    Trasladar_ProductoRelacionado(oProducto.ListaRelacionados(0), oProducto.Id_Producto)
                Else
                    Dim relacion = ConsultarConsecutivo_Relacion() + 1
                    For i As Integer = 0 To oProducto.ListaRelacionados.Count - 1
                        oProducto.ListaRelacionados(i).Relacion = relacion
                        Insertar_ProductoRelacionado(oProducto.ListaRelacionados(i))
                    Next i
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Insertando producto")
        End Try
    End Sub

    Public Sub Modificar(ByVal oProducto As Producto)
        Const sql As String = "UPDATE PRODUCTO SET Descripcion = @Descripcion,PrecioUnitario=@PrecioUnitario, Ganancia= @Ganancia, Existencias= @Existencias, Impuesto=@Impuesto, Minimo=@Minimo, Maximo=@Maximo, Activo=@Activo, Consignacion=@Consignacion WHERE Id_Producto = @Id_Producto"
        Dim oComando As New MySqlCommand(sql, Conexion)
        InicializarParametros(oComando, oProducto)

        Try
            ModificarDatos(oComando)

            If oProducto.ListaProveedores.Count > 0 Then
                For i As Integer = 0 To oProducto.ListaProveedores.Count - 1
                    oProducto.ListaProveedores(i).Id_Producto = oProducto.Id_Producto
                    Eliminar_ProductoPorProveedor(oProducto.ListaProveedores(i).Id_Producto, oProducto.ListaProveedores(i).IdProveedor)
                Next

                For i As Integer = 0 To oProducto.ListaProveedores.Count - 1
                    oProducto.ListaProveedores(i).Id_Producto = oProducto.Id_Producto
                    Insertar_ProductoPorProveedor(oProducto.ListaProveedores(i))
                Next i
            End If

            If oProducto.ListaRelacionados.Count > 0 Then
                Dim relacion = 0
                For i As Integer = 0 To oProducto.ListaRelacionados.Count - 1
                    Dim tempRelacion = ConsultarNumero_Relacion(oProducto.ListaRelacionados(i).Id_Producto)
                    If tempRelacion > 0 Then
                        relacion = tempRelacion
                    End If
                Next i

                If relacion = 0 Then
                    Dim relacion2 = ConsultarConsecutivo_Relacion() + 1
                    For i As Integer = 0 To oProducto.ListaRelacionados.Count - 1
                        oProducto.ListaRelacionados(i).Relacion = relacion2
                        Insertar_ProductoRelacionado(oProducto.ListaRelacionados(i))
                    Next i
                Else
                    For i As Integer = 0 To oProducto.ListaRelacionados.Count - 1
                        Dim relacion3 = ConsultarNumero_Relacion(oProducto.ListaRelacionados(i).Id_Producto)
                        If relacion3 = 0 Then
                            oProducto.ListaRelacionados(i).Relacion = relacion
                            Insertar_ProductoRelacionado(oProducto.ListaRelacionados(i))
                        Else
                            Modificar_ProductoRelacionado(oProducto.ListaRelacionados(i))
                        End If

                    Next i
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Modificando producto")
        End Try
    End Sub

    Public Sub Eliminar(ByVal idProducto As Integer)
        Dim sql As String = "DELETE FROM PRODUCTO WHERE Id_Producto = " & idProducto

        Try
            EliminarDatos(sql)
        Catch ex As Exception
            MsgBox("Este producto ya ha sido facturado o esta ligado a un proveedor por lo que no puede ser eliminado", MsgBoxStyle.Critical, "Eliminando producto")
        End Try
    End Sub

    'Devuelve el código y la descripción de los productos que contienen el patrón de búsqueda
    Public Function ConsultarPor_Descripcion(ByVal descripcion As String) As DataTable
        Dim sql As String = "SELECT Id_Producto,Descripcion FROM PRODUCTO WHERE (Descripcion like '%" & descripcion & "%') order by Id_Producto"
        Dim oDataTable As New DataTable 'Se crea un dataTable

        Try
            oDataTable = ConsultarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando productos por descripción")
        End Try

        Return oDataTable
    End Function

    'Devuelve una cadena con la descripción de un producto
    Public Function ConsultarDescripcion(ByVal codigo As Integer) As String
        Dim sql As String = "SELECT Descripcion FROM PRODUCTO WHERE Id_Producto = " & codigo

        Try
            Dim oDataTable = ConsultarDatos(sql)
            If oDataTable.Rows.Count > 0 Then
                Return oDataTable.Rows(0).Item(0)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando descripción de producto")
        End Try
        Return ""
    End Function

    Public Function Consultar(ByVal codigo As Integer) As Producto
        Dim sql As String = "SELECT * FROM PRODUCTO WHERE Id_Producto = " & codigo
        Dim producto As New Producto
        Try
            Dim oDataTable = ConsultarDatos(sql)
            If oDataTable.Rows.Count > 0 Then
                producto = LlenarProducto(oDataTable.Rows(0))
            Else
                producto.Id_Producto = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando producto")
        End Try
        Return producto
    End Function

    'Devuelve una lista con todos los productos que cumplen con el patrón de la descripción
    Public Function ConsultarTodoPor_Descripcion(ByVal descripcion As String) As List(Of Producto)
        Dim sql As String = "SELECT * FROM PRODUCTO WHERE (Descripcion like '%" & descripcion & "%') order by Descripcion"
        Return DevolverListaProductos(sql)
    End Function

    'Devuelve una lista de productos con un número específico de lineas
    Public Function ConsultarRango(ByVal cantidad As Integer) As DataTable
        Dim sql As String = "SELECT * FROM PRODUCTO LIMIT " & cantidad
        Dim oDataTable As New DataTable 'Se crea un dataTable

        Try
            oDataTable = ConsultarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando productos por rango")
        End Try

        Return oDataTable
    End Function

    'Devuelve una lista de productos con un número específico de lineas y que sean menores al código
    'La tabla con los resultados se asigna a una lista y se ordena por código 
    Public Function ConsultarRangoCodigoMenores(ByVal rango As Integer, ByVal codigo As Integer) As DataTable
        Dim sql As String = "SELECT * FROM PRODUCTO " _
                           & "WHERE Id_Producto < " & codigo & " ORDER BY Id_Producto DESC LIMIT " & rango
        Dim oDataTable As New DataTable 'Se crea un dataTable

        Try
            oDataTable = ConsultarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando productos por rango y codigo")
        End Try

        Return oDataTable
    End Function

    'Devuelve una lista de productos con un número específico de lineas y que sean mayores al código
    Public Function ConsultarRangoCodigoMayores(ByVal rango As Integer, ByVal codigo As Integer) As DataTable
        Dim sql As String = "SELECT * FROM PRODUCTO " _
                          & "WHERE Id_Producto >= " & codigo & " LIMIT " & rango + 1
        Dim oDataTable As New DataTable 'Se crea un dataTable

        Try
            oDataTable = ConsultarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando productos por rango y codigo")
        End Try

        Return oDataTable
    End Function

    'Cambia el máximo vendido de un producto en el caso que se haya seperado el número de unidaddes vendidas.
    Public Sub ActualizarMaximoVendido(ByVal idProducto As Long, ByVal vendido As Double)
        Dim sql As String = "UPDATE PRODUCTO SET MaxVendido = " & vendido & " WHERE Id_Producto = " & idProducto

        Try
            ModificarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Modificando maxvendido de un producto")
        End Try
    End Sub

    'Devuelve una lista con todos los productos que se encuentra en el rango
    Public Function ConsultarPorRangoCodigos(ByVal codInicio As Integer, ByVal codFinal As Integer) As List(Of Producto)
        Dim sql As String = "SELECT * FROM PRODUCTO " _
                          & " WHERE Id_Producto >= " & codInicio & " AND Id_Producto <= " & codFinal & " ORDER BY Id_Producto DESC"
        Return DevolverListaProductos(sql)
    End Function

    Public Function ConsultaGeneralLista(ByVal tipo As Integer, ByVal codInicio As Integer,
                                      ByVal codFinal As Integer, Optional ByVal consignacion As Boolean = False) As List(Of Producto)
        '0-Todos 1-Todos Consignacion 2-Todos Positivos 3-Positivos Consignacion 
        '4-Todos Negativos 5- Negativos Consignacion 

        Dim condicion As String = "WHERE Id_Producto >= " & codInicio & " AND Id_Producto <= " & codFinal

        Select Case tipo
            Case 1
                condicion += " AND Consignacion = " & consignacion
            Case 2
                condicion += " AND Existencias >= 0"
            Case 3
                condicion += " AND Existencias >= 0 AND Consignacion = " & consignacion
            Case 4
                condicion += " AND Existencias < 0"
            Case 5
                condicion += " AND Existencias < 0 AND Consignacion = " & consignacion
        End Select

        Dim sql As String = "SELECT * FROM PRODUCTO " & condicion

        Return DevolverListaProductos(sql)
    End Function

    'Resta las existencias en una cantidad específica
    Public Sub DescontarExistencias(ByVal cantidad As Double, ByVal codProducto As Integer)
        Dim sql As String = "UPDATE PRODUCTO SET Existencias = Existencias - " & cantidad & " WHERE Id_Producto = " & codProducto

        Try
            ModificarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Restando una cantidad a las existencias")
        End Try
    End Sub

    'Aumenta las existencias en una cantidad específica
    Public Sub AumentarExistencias(ByVal cantidad As Double, ByVal codProducto As Integer)
        Dim sql As String = "UPDATE PRODUCTO SET Existencias = Existencias + " & cantidad & " WHERE Id_Producto = " & codProducto

        Try
            ModificarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Sumando una cantidad a las existencias")
        End Try
    End Sub

    Private Function DevolverListaProductos(ByVal sql As String) As List(Of Producto)
        Dim oLista As New List(Of Producto)

        Try
            Dim oDataTable = ConsultarDatos(sql)
            For i = 0 To oDataTable.Rows.Count - 1
                oLista.Add(LlenarProducto(oDataTable.Rows(i)))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando lista productos")
        End Try

        Return oLista
    End Function

    Private Function LlenarProducto(ByVal row As DataRow) As Producto
        Dim oProducto As New Producto
        oProducto.Id_Producto = row.Item(0)
        oProducto.Descripcion = row.Item(1)
        oProducto.PrecioUnitario = row.Item(2)
        oProducto.Ganancia = row.Item(3)
        oProducto.Existencias = row.Item(4)
        oProducto.Impuesto = row.Item(5)
        oProducto.Minimo = row.Item(6)
        oProducto.Maximo = row.Item(7)
        oProducto.Activo = row.Item(8)
        oProducto.Consignacion = row.Item(9)
        oProducto.MaxVendido = row.Item(10)
        oProducto.ListaProveedores = ConsultarProveedores(oProducto.Id_Producto)
        oProducto.ListaRelacionados = ConsultarRelacionados(oProducto.Id_Producto)
        oProducto.Bodega = ConsultarBodega(oProducto.Id_Producto)
        Return oProducto
    End Function

    '********************************************PROVEEDORES POR PRODUCTO***************************************************
    Private Sub InicializarParametrosProveedores(ByVal oComando As MySqlCommand, ByVal oProductoProveedor As ProductoPorProveedor)
        oComando.Parameters.AddWithValue("@Id_Producto", oProductoProveedor.Id_Producto)
        oComando.Parameters.AddWithValue("@Id_Proveedor", oProductoProveedor.IdProveedor)
        oComando.Parameters.AddWithValue("@Prioridad", oProductoProveedor.Prioridad)
        Return
    End Sub

    Public Sub Insertar_ProductoPorProveedor(ByVal oProductoProveedor As ProductoPorProveedor)
        Const sql As String = "INSERT INTO PRODUCTO_POR_PROVEEDOR VALUES (@Id_Producto, @Id_Proveedor, @Prioridad)"
        Dim oComando As New MySqlCommand(sql, Conexion)
        InicializarParametrosProveedores(oComando, oProductoProveedor)

        Try
            InsertarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Insertando proveedores de un producto")
        End Try
    End Sub

    'Cambia un código de un producto por proveedor a otro código
    Public Sub TrasladarCodigo_ProductoProveedor(ByVal idProducto As Long, ByVal idTraslado As Long)
        Dim sql As String = "UPDATE PRODUCTO_POR_PROVEEDOR SET Id_Producto = " & idTraslado & " WHERE Id_Producto = " & idProducto
        Try
            ModificarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Trasladando código producto por proveedor")
        End Try
    End Sub

    Public Sub Eliminar_ProductoPorProveedor(ByVal idProducto As Integer, ByVal idProveedor As Integer)
        Dim sql As String = "DELETE FROM PRODUCTO_POR_PROVEEDOR WHERE Id_Producto = " & idProducto & " AND Id_Proveedor = " & idProveedor

        Try
            EliminarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Eliminando proveedores de un producto")
        End Try
    End Sub

    'Devuelve una lista con todos los proveedores que tiene un producto
    Public Function ConsultarProveedores(ByVal codigo As Long) As List(Of ProductoPorProveedor)
        Dim sql = "SELECT * FROM PRODUCTO_POR_PROVEEDOR WHERE Id_Producto = " & codigo & " ORDER BY Prioridad"
        Dim oListaProveedores As New List(Of ProductoPorProveedor)
        Try
            Dim oDataTable = ConsultarDatos(sql)
            For i As Integer = 0 To oDataTable.Rows.Count - 1
                oListaProveedores.Add(LlenarProductoPorProveedor(oDataTable.Rows(i)))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando proveedores de un producto")
        End Try
        Return oListaProveedores
    End Function

    'Devuelve una lista con todos los productos que tiene asociado un proveedor
    Public Function ConsultarProductosPorProveedor(ByVal idProveedor As Long) As List(Of ProductoPorProveedor)
        Dim sql = "SELECT DISTINCT * FROM PRODUCTO_POR_PROVEEDOR WHERE Id_Proveedor = " & idProveedor & " ORDER BY Id_Producto DESC"
        Dim oListaProveedores As New List(Of ProductoPorProveedor)
        Try
            Dim oDataTable = ConsultarDatos(sql)
            For i As Integer = 0 To oDataTable.Rows.Count - 1
                oListaProveedores.Add(LlenarProductoPorProveedor(oDataTable.Rows(i)))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando proveedores de un producto")
        End Try
        Return oListaProveedores
    End Function

    Private Function LlenarProductoPorProveedor(ByVal row As DataRow) As ProductoPorProveedor
        Dim oProductoPorProveedor As New ProductoPorProveedor
        oProductoPorProveedor.Id_Producto = row.Item(0)
        oProductoPorProveedor.IdProveedor = row.Item(1)
        oProductoPorProveedor.Prioridad = row.Item(2)
        oProductoPorProveedor.NombreProveedor = _oAccesoProveedor.ConsultarNombre(oProductoPorProveedor.IdProveedor)
        Return oProductoPorProveedor
    End Function

    '******************************************PRODUCTO RELACIONADO********************************************

    Private Sub InicializarParametrosRelacionados(ByVal oComando As MySqlCommand, ByVal oProductoRelacionado As ProductoRelacionado)
        oComando.Parameters.AddWithValue("@Id_Producto", oProductoRelacionado.Id_Producto)
        oComando.Parameters.AddWithValue("@Prioridad", oProductoRelacionado.Prioridad)
        oComando.Parameters.AddWithValue("@Relacion", oProductoRelacionado.Relacion)
        oComando.Parameters.AddWithValue("@Observacion", oProductoRelacionado.Observacion)
        Return
    End Sub

    Public Sub Insertar_ProductoRelacionado(ByVal oProductoRelacionado As ProductoRelacionado)
        Const sql As String = "INSERT INTO PRODUCTO_RELACIONADO VALUES (@Id_Producto, @Prioridad, @Relacion, @Observacion)"
        Dim oComando As New MySqlCommand(sql, Conexion)
        InicializarParametrosRelacionados(oComando, oProductoRelacionado)

        Try
            InsertarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Insertando productos relacionados")
        End Try
    End Sub

    Public Sub Modificar_ProductoRelacionado(ByVal oProductoRelacionado As ProductoRelacionado)
        Const sql As String = "UPDATE PRODUCTO_RELACIONADO SET Prioridad = @Prioridad, Observacion = @Observacion WHERE Id_Producto = @Id_Producto"
        Dim oComando As New MySqlCommand(sql, Conexion)
        InicializarParametrosRelacionados(oComando, oProductoRelacionado)

        Try
            ModificarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Modificando productos relacionados")
        End Try
    End Sub

    'Cambia un código de un producto relacionado a otro.
    Public Sub TrasladarCodigo_ProductoRelacionado(ByVal idProducto As Long, ByVal idTraslado As Long)
        Dim sql As String = "UPDATE PRODUCTO_RELACIONADO SET Id_Producto = " & idTraslado & " WHERE Id_Producto = " & idProducto
        Try
            ModificarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Trasladando código producto por proveedor")
        End Try
    End Sub

    Public Sub Eliminar_ProductoRelacionado(ByVal idProducto As Integer)
        Dim sql As String = "DELETE FROM PRODUCTO_RELACIONADO WHERE Id_Producto = " & idProducto

        Try
            EliminarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Eliminando relaciones de un producto")
        End Try
    End Sub

    'Devuelve un entero con el último producto relacionado de la tabla o cero si se encuentra vacía
    Public Function ConsultarConsecutivo_Relacion() As Integer
        Const sql As String = "SELECT max(Relacion) FROM PRODUCTO_RELACIONADO"

        Try
            Dim oDataTable = ConsultarDatos(sql)
            Return oDataTable.Rows(0).Item(0)
        Catch ex As Exception
            Return 0
        End Try
    End Function

    'Devuelve el numero de relación de un producto o cero si el producto no tiene productos relacionados.
    Private Function ConsultarNumero_Relacion(ByVal idProducto As Long) As Integer
        Dim sql As String = "SELECT Relacion FROM PRODUCTO_RELACIONADO WHERE Id_Producto = " & idProducto

        Try
            Dim oDataTable = ConsultarDatos(sql)
            Return oDataTable.Rows(0).Item(0)
        Catch ex As Exception
            Return 0
        End Try
    End Function

    'Devuelve una lista con todos los productos relacionados de un solo producto
    Public Function ConsultarRelacionados(ByVal codigo As Long) As List(Of ProductoRelacionado)
        Dim relacion = ConsultarNumero_Relacion(codigo)
        Dim sql = "SELECT * FROM PRODUCTO_RELACIONADO WHERE Relacion = " & relacion & " ORDER BY Prioridad"
        Dim oListaRelacionados As New List(Of ProductoRelacionado)
        Try
            Dim oDataTable = ConsultarDatos(sql)
            For i As Integer = 0 To oDataTable.Rows.Count - 1
                oListaRelacionados.Add(LlenarProductoRelacionado(oDataTable.Rows(i)))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando productos relacionados")
        End Try
        Return oListaRelacionados
    End Function

    Private Function LlenarProductoRelacionado(ByVal row As DataRow) As ProductoRelacionado
        Dim oProductoRelacionado As New ProductoRelacionado
        oProductoRelacionado.Id_Producto = row.Item(0)
        oProductoRelacionado.Prioridad = row.Item(1)
        oProductoRelacionado.Relacion = row.Item(2)
        oProductoRelacionado.Observacion = row.Item(3)
        Return oProductoRelacionado
    End Function

    'Trasladar las relaciones de un producto a otro código
    Public Sub Trasladar_ProductoRelacionado(ByVal oProductoRelacionado As ProductoRelacionado, ByVal idTraslado As Integer)
        Dim sql As String = "UPDATE PRODUCTO_RELACIONADO SET Prioridad = @Prioridad, Observacion = @Observacion, Id_Producto = @Id_Producto WHERE Id_Producto = " & oProductoRelacionado.Id_Producto
        Dim oComando As New MySqlCommand(sql, Conexion)
        InicializarParametrosRelacionados(oComando, oProductoRelacionado)

        Try
            ModificarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Trasladando productos relacionados")
        End Try
    End Sub

    '******************************************PRODUCTO EN BODEGA********************************************

    Private Sub InicializarParametrosBodega(ByVal oComando As MySqlCommand, ByVal oBodega As Bodega)
        oComando.Parameters.AddWithValue("@Id_Producto", oBodega.Id_Producto)
        oComando.Parameters.AddWithValue("@Exist_Bodega", oBodega.ExistBodega)
        oComando.Parameters.AddWithValue("@Maximo_Caja", oBodega.MaximoCaja)
        Return
    End Sub

    Public Sub Insertar_ProductoBodega(ByVal oBodega As Bodega)
        Const sql As String = "INSERT INTO BODEGA VALUES (@Id_Producto, @Exist_Bodega, @Maximo_Caja)"
        Dim oComando As New MySqlCommand(sql, Conexion)
        InicializarParametrosBodega(oComando, oBodega)

        Try
            InsertarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Insertando producto bodega")
        End Try
    End Sub

    Public Function Modificar_ProductoBodega(ByVal oBodega As Bodega) As Integer
        Const sql As String = "UPDATE BODEGA SET Exist_Bodega = @Exist_Bodega, Maximo_Caja = @Maximo_Caja WHERE Id_Producto = @Id_Producto"
        Dim oComando As New MySqlCommand(sql, Conexion)
        InicializarParametrosBodega(oComando, oBodega)
        Dim id As Integer = 0
        Try
            id = ModificarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Modificando producto bodega")
        End Try
        Return id
    End Function

    'Devuelve un producto y los datos que existen en la bodega
    Public Function ConsultarBodega(ByVal idProducto As Integer) As Bodega
        Dim sql = "SELECT * FROM BODEGA WHERE Id_Producto = " & idProducto
        Dim oBodega As New Bodega
        Try
            Dim oDataTable = ConsultarDatos(sql)
            If oDataTable.Rows.Count > 0 Then
                oBodega.Id_Producto = oDataTable.Rows(0).Item(0)
                oBodega.ExistBodega = oDataTable.Rows(0).Item(1)
                oBodega.MaximoCaja = oDataTable.Rows(0).Item(2)
            Else
                oBodega.Id_Producto = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando producto en bodega")
        End Try
        Return oBodega
    End Function

    Public Sub ModificarExist_ProductoBodega(ByVal idProducto As Integer, ByVal existencias As Double)
        Dim sql As String = "UPDATE BODEGA SET Exist_Bodega = " & existencias & " WHERE Id_Producto = " & idProducto

        Try
            ModificarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Modificando existencias producto bodega")
        End Try
    End Sub

    Function ConsultarProductoRelacionadoPor_IdProducto(ByVal codigo As Integer) As Integer
        Dim sql As String = " SELECT COUNT(*) " _
                    & " FROM PRODUCTO_RELACIONADO " _
                    & " WHERE Id_Producto = " & codigo

        Try
            Dim oDataTable = ConsultarDatos(sql)
            Return oDataTable.Rows(0).Item(0)
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Function ConsultarProductoProveedoroPor_IdProducto(ByVal codigo As Integer) As Integer
        Dim sql As String = " SELECT COUNT(*) " _
                     & " FROM PRODUCTO_POR_PROVEEDOR " _
                     & " WHERE Id_Producto = " & codigo
        Try
            Dim oDataTable = ConsultarDatos(sql)
            Return oDataTable.Rows(0).Item(0)
        Catch ex As Exception
            Return 0
        End Try
    End Function

End Class