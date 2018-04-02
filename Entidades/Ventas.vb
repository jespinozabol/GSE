Public Class Ventas

    Private varIdProducto As Integer
    Public Property IdProducto() As Integer
        Get
            Return varIdProducto
        End Get
        Set(ByVal value As Integer)
            varIdProducto = value
        End Set
    End Property

    Private varMes As Integer
    Public Property Mes() As Integer
        Get
            Return varMes
        End Get
        Set(ByVal value As Integer)
            varMes = value
        End Set
    End Property

    Private varAño As Integer
    Public Property Año() As Integer
        Get
            Return varAño
        End Get
        Set(ByVal value As Integer)
            varAño = value
        End Set
    End Property

    Private varCantidad As Double
    Public Property Cantidad() As Double
        Get
            Return varCantidad
        End Get
        Set(ByVal value As Double)
            varCantidad = value
        End Set
    End Property
End Class
