Imports Entidades
Imports Acceso_Datos
Public Class LogicaVentas
    Private ReadOnly _oAccesoVentas As New AccesoVentas
    Private ReadOnly _oAccesoProducto As New AccesoProducto
    Private ReadOnly _oAc

    Public Sub Insertar(ByVal oVentas As Ventas)
        _oAccesoVentas.Insertar(oVentas)
    End Sub

    Function Consultar(ByVal idProducto As Integer) As List(Of Ventas)
        Return _oAccesoVentas.Consultar(idProducto)
    End Function

    Public Sub FillData()
        'SELECT Id_Producto,Sum(Cantidad) FROM gseprueba.factura_detalle As d
        'INNER JOIN gseprueba.factura_encabezado As e on d.Num_Factura = e.Num_Factura
        'Where e.Fecha > '2012-03-01' and e.Fecha < '2012-03-31'
        'Group by Id_Producto
    End Sub

End Class
