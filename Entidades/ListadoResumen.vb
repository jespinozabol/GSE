'Continene: Id_Listado,Id_Producto, Cantidad
Public Class ListadoResumen

    'Variable extraída de la tabla LISTADO y que guarda el número de listado al que pertenece ésta línea.
    Private _varIdListado As Integer
    Public Property IdListado() As Integer
        Get
            Return _varIdListado
        End Get
        Set(ByVal value As Integer)
            _varIdListado = value
        End Set
    End Property

    'Variable extraída de la tabla PRODUCTO y que guarda el id del producto que se va a listar.
    Private _varIdProducto As Integer
    Public Property Id_Producto() As Integer
        Get
            Return _varIdProducto
        End Get
        Set(ByVal value As Integer)
            _varIdProducto = value
        End Set
    End Property

    'Las unidades que se entregáron del producto listado.
    Private _varCantidad As Double
    Public Property Cantidad() As Double
        Get
            Return _varCantidad
        End Get
        Set(ByVal value As Double)
            _varCantidad = value
        End Set
    End Property
End Class
