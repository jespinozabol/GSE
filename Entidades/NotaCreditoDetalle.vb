'Continene: Id_NC,Cantidad, Id_Producto,Descripcion, PrecioUnitario, Descuento,
' Impuesto, Tdescuento, Timpuesto.
Public Class NotaCreditoDetalle

    'Variable extraída de la tabla NOTA_CREDITO y que específica a cual nc pertenece el detalle.
    Private _varIdNC As Integer
    Public Property IdNC() As Integer
        Get
            Return _varIdNC
        End Get
        Set(ByVal value As Integer)
            _varIdNC = value
        End Set
    End Property

    'Número de unidades de un producto que se le realiza lanota.
    Private _varCantidad As Double
    Public Property Cantidad() As Double
        Get
            Return _varCantidad
        End Get
        Set(ByVal value As Double)
            _varCantidad = value
        End Set
    End Property

    'Variable extraída de la tabla PRODUCTO y que específica a cual producto se le realiza la nota.
    Private _varIdProducto As Integer
    Public Property Id_Producto() As Integer
        Get
            Return _varIdProducto
        End Get
        Set(ByVal value As Integer)
            _varIdProducto = value
        End Set
    End Property

    'Descripción del producto al cual se le realiza la nota.
    Private _varDescripcion As String
    Public Property Descripcion() As String
        Get
            Return _varDescripcion
        End Get
        Set(ByVal value As String)
            _varDescripcion = value
        End Set
    End Property

    'Precio unitario del producto se le realiza la nota.
    Private _varPrecioUnitario As Double
    Public Property PrecioUnitario() As Double
        Get
            Return _varPrecioUnitario
        End Get
        Set(ByVal value As Double)
            _varPrecioUnitario = value
        End Set
    End Property

    'El descuento que se la rebará al total del producto(es un porcentaje).
    Private _varDescuento As Double
    Public Property Descuento() As Double
        Get
            Return _varDescuento
        End Get
        Set(ByVal value As Double)
            _varDescuento = value
        End Set
    End Property

    'El impuesto que se le agregará al producto(es un porcentaje).
    Private _varImpuesto As Double
    Public Property Impuesto() As Double
        Get
            Return _varImpuesto
        End Get
        Set(ByVal value As Double)
            _varImpuesto = value
        End Set
    End Property

    'El descuento total calculado por la ((Cantidad * PrecioUnitario)*Descuento%)
    Private _varTTdescuento As Double
    Public Property Tdescuento() As Double
        Get
            Return _varTTdescuento
        End Get
        Set(ByVal value As Double)
            _varTTdescuento = value
        End Set
    End Property

    'El impuesto total calculado por la ((Cantidad *  PrecioUnitario)*Impuesto%)
    Private _varTTimpuesto As Double
    Public Property Timpuesto() As Double
        Get
            Return _varTTimpuesto
        End Get
        Set(ByVal value As Double)
            _varTTimpuesto = value
        End Set
    End Property
End Class