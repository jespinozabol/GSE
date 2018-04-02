Public Class Bodega

    Private _varIdProducto As Integer
    Public Property Id_Producto() As Integer
        Get
            Return _varIdProducto
        End Get
        Set(ByVal value As Integer)
            _varIdProducto = value
        End Set
    End Property

    Private _varExistBodega As Double
    Public Property ExistBodega() As Double
        Get
            Return _varExistBodega
        End Get
        Set(ByVal value As Double)
            _varExistBodega = value
        End Set
    End Property


    Private _varMaximoCaja As Double
    Public Property MaximoCaja() As Double
        Get
            Return _varMaximoCaja
        End Get
        Set(ByVal value As Double)
            _varMaximoCaja = value
        End Set
    End Property

End Class
