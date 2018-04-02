'Contiene: Id_Producto, Prioridad, Relacion, Observacion
Public Class ProductoRelacionado

    'Variable extraída de la tabla PRODUCTO y que guarda el producto que será relacionado con otros productos.
    Private _varIdProducto As Long
    Public Property Id_Producto() As Long
        Get
            Return _varIdProducto
        End Get
        Set(ByVal value As Long)
            _varIdProducto = value
        End Set
    End Property

    'La prioridad del producto en comparación con el producto relacionado.
    Private _varPrioridad As Integer
    Public Property Prioridad() As Integer
        Get
            Return _varPrioridad
        End Get
        Set(ByVal value As Integer)
            _varPrioridad = value
        End Set
    End Property

    'El número de relación, si el producto ya tiene otra relación se le asigna el mismo número.
    Private _varRelacion As Long
    Public Property Relacion() As Long
        Get
            Return _varRelacion
        End Get
        Set(ByVal value As Long)
            _varRelacion = value
        End Set
    End Property

    'Algún otro tipo de observación que se desee que se conozca de la relación
    Private _varObservacion As String
    Public Property Observacion() As String
        Get
            Return _varObservacion
        End Get
        Set(ByVal value As String)
            _varObservacion = value
        End Set
    End Property
End Class