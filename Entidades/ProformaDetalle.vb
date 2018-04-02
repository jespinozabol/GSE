'Contiene: Num_Proforma, Id_Producto, PrecioUnitario, Cantidad, Impuesto, Descuento, Timpuesto, Tdescuento.
Public Class ProformaDetalle

    'Variable extraída de la tabla PROFORMA_ENCABEZADO y que específica a cual proforma pertenece la línea.
    Private _varNumProforma As Integer
    Public Property NumProforma() As Integer
        Get
            Return _varNumProforma
        End Get
        Set(ByVal value As Integer)
            _varNumProforma = value
        End Set
    End Property

    'El código del producto que es agregado a la proforma.
    Private _varIdProducto As Integer
    Public Property IdProducto() As Integer
        Get
            Return _varIdProducto
        End Get
        Set(ByVal value As Integer)
            _varIdProducto = value
        End Set
    End Property

    'El precio unitario con la ganancia incluída del producto agregado.
    Private _varPrecioUnitario As Double
    Public Property PrecioUnitario() As Double
        Get
            Return _varPrecioUnitario
        End Get
        Set(ByVal value As Double)
            _varPrecioUnitario = value
        End Set
    End Property

    'El número de unidades que se agregaron a la proforma.
    Private _varCantidad As Double
    Public Property Cantidad() As Double
        Get
            Return _varCantidad
        End Get
        Set(ByVal value As Double)
            _varCantidad = value
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
End Class