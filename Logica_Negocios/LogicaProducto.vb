Imports Entidades
Imports Acceso_Datos
Public Class LogicaProducto
    Private ReadOnly _oAccesoProducto As New AccesoProducto
    Private ReadOnly _oAccesoFactura As New AccesoFactura
    Private ReadOnly _oAccesoListado As New AccesoListado
    Private ReadOnly _oAccesoProforma As New AccesoProforma

    Public Sub Insertar(ByVal oProducto As Producto)
        _oAccesoProducto.Insertar(oProducto, False)
        Insertar_ProductoBodega(oProducto.Bodega)
    End Sub

    Public Sub Modificar(ByVal oProducto As Producto)
        _oAccesoProducto.Modificar(oProducto)
        Modificar_ProductoBodega(oProducto.Bodega)
    End Sub

    Public Sub Eliminar(ByVal idProducto As Integer)
        _oAccesoProducto.Eliminar(idProducto)
    End Sub

    Public Sub EliminarRepetido(ByVal idProducto As Long, ByVal idTraslado As Long)
        TrasladarRelaciones(idProducto, idTraslado)
        Eliminar(idProducto)
    End Sub

    Public Function ConsultarDescripcion(ByVal idProducto As Integer) As String
        Return _oAccesoProducto.ConsultarDescripcion(idProducto)
    End Function

    Public Function ConsultarPor_Descripcion(ByVal descripcion As String) As DataTable
        Return _oAccesoProducto.ConsultarPor_Descripcion(descripcion)
    End Function

    Public Function Consultar(ByVal idProducto As Integer) As Producto
        Return _oAccesoProducto.Consultar(idProducto)
    End Function

    Public Function ConsultarRango(ByVal rango As Integer) As DataTable
        Return _oAccesoProducto.ConsultarRango(Rango)
    End Function

    Public Function ConsultarRangoCodigo(ByVal rango As Integer, ByVal codigo As Integer) As DataTable
        'Consulta según la cantidad digitada los códigos mayores y menores al dicho, los une en una tabla
        'y los ordena por medio de un dataView
        Dim oTblProductos = _oAccesoProducto.ConsultarRangoCodigoMenores(rango, Codigo)
        oTblProductos.Merge(_oAccesoProducto.ConsultarRangoCodigoMayores(rango, Codigo))
        Dim oView As New DataView(oTblProductos)
        oView.Sort = "Id_Producto"
        Return oView.ToTable
    End Function

    Public Function ConsultarProductosPorRangoCodigos(ByVal codInicio As Integer, ByVal codFinal As Integer) As List(Of Producto)
        Return _oAccesoProducto.ConsultarPorRangoCodigos(codInicio, codFinal)
    End Function

    Public Sub ActualizarMaximoVendido(ByVal idProducto As Long, ByVal vendido As Double)
        _oAccesoProducto.ActualizarMaximoVendido(idProducto, vendido)
    End Sub

    'Inserta el producto en el código nuevo, traslada todas las 
    'relaciones del código anterior al nuevo y elimina el producto nuevo.
    Public Sub TrasladarCodigo(ByVal producto As Producto, ByVal idTraslado As Long)
        Dim idProducto = producto.Id_Producto
        producto.Id_Producto = idTraslado
        _oAccesoProducto.Insertar(producto, True)
        TrasladarRelaciones(idProducto, idTraslado)
        Eliminar(idProducto)
    End Sub

    Private Sub TrasladarRelaciones(ByVal idProducto As Integer, ByVal idTraslado As Integer)
        _oAccesoFactura.TrasladarCodigoProducto(idProducto, idTraslado)
        _oAccesoListado.TrasladarCodigoProducto_Historial(idProducto, idTraslado)
        TrasladarCodigoProductoResumen(idProducto, idTraslado)
        _oAccesoProforma.TrasladarCodigoProducto(idProducto, idTraslado)
        _oAccesoProducto.TrasladarCodigo_ProductoRelacionado(idProducto, idTraslado)
        _oAccesoProducto.TrasladarCodigo_ProductoProveedor(idProducto, idTraslado)
    End Sub

    Public Sub TrasladarCodigoProductoResumen(ByVal idProducto As Integer, ByVal idTraslado As Integer)
        Dim tblListados = _oAccesoListado.ConsultarListadosResumenPor_IdProducto(idProducto)
        For i As Integer = 0 To tblListados.Rows.Count - 1
            Dim listado = _oAccesoListado.ConsultarTodosPorId(Convert.ToInt32(tblListados.Rows(i).Item(0)))
            Dim producto = (From l In listado.ListaResumen
                               Where l.Id_Producto = idTraslado Select l).FirstOrDefault
            Dim productoATrasladar = (From l In listado.ListaResumen
                               Where l.Id_Producto = idProducto Select l).FirstOrDefault
            If IsNothing(producto) Then
                productoATrasladar.Id_Producto = idTraslado
            Else
                producto.Cantidad = productoATrasladar.Cantidad
                listado.ListaResumen.Remove(productoATrasladar)
            End If
            _oAccesoListado.Modificar(listado)
        Next
    End Sub

    Public Function ConsultarTodoPor_Descripcion(ByVal patron As String) As List(Of Producto)
        Return _oAccesoProducto.ConsultarTodoPor_Descripcion(patron)
    End Function

    Public Function ConsultarProductosPorProveedor(ByVal idProveedor As Integer) As List(Of Producto)
        Dim oListaProductosPorProveedor = _oAccesoProducto.ConsultarProductosPorProveedor(idProveedor)
        Dim oListaProductos As New List(Of Producto)

        For i As Integer = 0 To oListaProductosPorProveedor.Count - 1
            oListaProductos.Add(_oAccesoProducto.Consultar(oListaProductosPorProveedor(i).Id_Producto))
        Next

        Return oListaProductos
    End Function

    '**********************************************PROVEEDORES DE PRODUCTO************************************

    Public Sub Insertar_Proveedor(ByVal oProductoProveedor As ProductoPorProveedor)
        _oAccesoProducto.Insertar_ProductoPorProveedor(oProductoProveedor)
    End Sub

    Public Sub Eliminar_Proveedor(ByVal oProductoProveedor As ProductoPorProveedor)
        _oAccesoProducto.Eliminar_ProductoPorProveedor(oProductoProveedor.Id_Producto, oProductoProveedor.IdProveedor)
    End Sub

    Public Function ConsultarProveedores(ByVal idProducto As Long) As List(Of ProductoPorProveedor)
        Return _oAccesoProducto.ConsultarProveedores(idProducto)
    End Function

    '**********************************************PRODUCTOS RELACIONADOS************************************

    Public Sub Insertar_Relacionado(ByVal oProductoRelacionado As ProductoRelacionado)
        _oAccesoProducto.Insertar_ProductoRelacionado(oProductoRelacionado)
    End Sub

    Public Sub Eliminar_Relacionado(ByVal idProducto As Integer)
        _oAccesoProducto.Eliminar_ProductoRelacionado(idProducto)
    End Sub

    '**********************************************PRODUCTOS EN BODEGA************************************

    Public Sub Insertar_ProductoBodega(ByVal oProductoBodega As Bodega)
        If oProductoBodega.Id_Producto <> 0 Then
            _oAccesoProducto.Insertar_ProductoBodega(oProductoBodega)
        End If
    End Sub

    Public Sub Modificar_ProductoBodega(ByVal oProductoBodega As Bodega)
        Dim existe As Boolean
        existe = _oAccesoProducto.Modificar_ProductoBodega(oProductoBodega)
        If Not existe Then
            Insertar_ProductoBodega(oProductoBodega)
        End If
    End Sub

    Public Sub Consultar_ProductoBodega(ByVal idProducto As Integer)
        _oAccesoProducto.ConsultarBodega(idProducto)
    End Sub

    Sub ModificarExist_ProductoBodega(ByVal idProducto As Integer, ByVal existencias As Double)
        _oAccesoProducto.ModificarExist_ProductoBodega(idProducto, existencias)
    End Sub

    Function TieneRelaciones(ByVal codigo As Integer) As Boolean
        Dim relaciones = 0

        relaciones += _oAccesoFactura.ConsultarPor_IdProducto(codigo)
        relaciones += _oAccesoListado.ConsultarHistorialPor_IdProducto(codigo)
        relaciones += _oAccesoListado.ConsultarResumenPor_IdProducto(codigo)
        relaciones += _oAccesoProforma.ConsultarPor_IdProducto(codigo)
        relaciones += _oAccesoProducto.ConsultarProductoRelacionadoPor_IdProducto(codigo)
        relaciones += _oAccesoProducto.ConsultarProductoProveedoroPor_IdProducto(codigo)

        If relaciones > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function ConsultarPorRangoTodas(ByVal codInicio As Integer, ByVal codFinal As Integer, ByVal rango As Integer) As List(Of Producto)
        Select Case rango
            Case 0
                Return _oAccesoProducto.ConsultaGeneralLista(0, codInicio, codFinal)
            Case 1
                Return _oAccesoProducto.ConsultaGeneralLista(1, codInicio, codFinal, True)
            Case Else
                Return _oAccesoProducto.ConsultaGeneralLista(1, codInicio, codFinal, False)
        End Select
    End Function

    Public Function ConsultarPorRangoPositivos(ByVal codInicio As Integer, ByVal codFinal As Integer, ByVal rango As Integer) As List(Of Producto)
        Select Case rango
            Case 0
                Return _oAccesoProducto.ConsultaGeneralLista(2, codInicio, codFinal)
            Case 1
                Return _oAccesoProducto.ConsultaGeneralLista(3, codInicio, codFinal, True)
            Case Else
                Return _oAccesoProducto.ConsultaGeneralLista(3, codInicio, codFinal, False)
        End Select
    End Function

    Public Function ConsultarPorRangoNegativos(ByVal codInicio As Integer, ByVal codFinal As Integer, ByVal rango As Integer) As List(Of Producto)
        Select Case rango
            Case 0
                Return _oAccesoProducto.ConsultaGeneralLista(4, codInicio, codFinal)
            Case 1
                Return _oAccesoProducto.ConsultaGeneralLista(5, codInicio, codFinal, True)
            Case Else
                Return _oAccesoProducto.ConsultaGeneralLista(5, codInicio, codFinal, False)
        End Select
    End Function
End Class