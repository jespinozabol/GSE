Public Class Devolucion

    Private _varIdDevolucion As Int32
    Public Property IdDevolucion() As Int32
        Get
            Return _varIdDevolucion
        End Get
        Set(ByVal value As Int32)
            _varIdDevolucion = value
        End Set
    End Property

    Private _varIdProveedor As Int32
    Public Property IdProveedor() As Int32
        Get
            Return _varIdProveedor
        End Get
        Set(ByVal value As Int32)
            _varIdProveedor = value
        End Set
    End Property

    Private _varFactura As String
    Public Property Factura() As String
        Get
            Return _varFactura
        End Get
        Set(ByVal value As String)
            _varFactura = value
        End Set
    End Property

    Private _varFecha As Date
    Public Property Fecha() As Date
        Get
            Return _varFecha
        End Get
        Set(ByVal value As Date)
            _varFecha = value
        End Set
    End Property

    Private _varBoleta As String
    Public Property Boleta() As String
        Get
            Return _varBoleta
        End Get
        Set(ByVal value As String)
            _varBoleta = value
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

    Private _varProducto As String
    Public Property Producto() As String
        Get
            Return _varProducto
        End Get
        Set(ByVal value As String)
            _varProducto = value
        End Set
    End Property

    Private _varCodigo As Int32
    Public Property Codigo() As Int32
        Get
            Return _varCodigo
        End Get
        Set(ByVal value As Int32)
            _varCodigo = value
        End Set
    End Property

    Private _varMotivo As String
    Public Property Motivo() As String
        Get
            Return _varMotivo
        End Get
        Set(ByVal value As String)
            _varMotivo = value
        End Set
    End Property

    Private _varObservaciones As String
    Public Property Observaciones() As String
        Get
            Return _varObservaciones
        End Get
        Set(ByVal value As String)
            _varObservaciones = value
        End Set
    End Property
End Class
