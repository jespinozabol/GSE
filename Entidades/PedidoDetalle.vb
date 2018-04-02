Public Class PedidoDetalle

    Private _varIdPedido As Integer
    Public Property IdPedido() As Integer
        Get
            Return _varIdPedido
        End Get
        Set(ByVal value As Integer)
            _varIdPedido = value
        End Set
    End Property

    Private _varIdProducto As Integer
    Public Property IdProducto() As Integer
        Get
            Return _varIdProducto
        End Get
        Set(ByVal value As Integer)
            _varIdProducto = value
        End Set
    End Property

    Private _varCantidad As Double
    Public Property Cantidad() As Double
        Get
            Return _varCantidad
        End Get
        Set(ByVal value As Double)
            _varCantidad = value
        End Set
    End Property

    Private _varCantidadRecibida As Double
    Public Property CantidadRecibida() As Double
        Get
            Return _varCantidadRecibida
        End Get
        Set(ByVal value As Double)
            _varCantidadRecibida = value
        End Set
    End Property

End Class
