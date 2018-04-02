'Continene: Id_Factura_Det, Num_Factura, Id_Producto, Descripcion, PrecioUnitario, Cantidad,
' Impuesto, Descuento, Timpuesto, Tdescuento 
Public Class FacturaDetalle

    'Variable autoincrementable que identifica de forma única a cada linea de todas las facturas.
    Private _varIdFacturaDet As Integer
    Public Property IdFacturaDet() As Integer
        Get
            Return _varIdFacturaDet
        End Get
        Set(ByVal value As Integer)
            _varIdFacturaDet = value
        End Set
    End Property

    'Variable extraída de la tabla FACTURA_ENCABEZADO y que específica a cual factura pertenece la línea.
    Private _varNumFactura As Integer
    Public Property NumFactura() As Integer
        Get
            Return _varNumFactura
        End Get
        Set(ByVal value As Integer)
            _varNumFactura = value
        End Set
    End Property

    'El código del producto que es agregado a la factura.
    Private _varIdProducto As Integer
    Public Property Id_Producto() As Integer
        Get
            Return _varIdProducto
        End Get
        Set(ByVal value As Integer)
            _varIdProducto = value
        End Set
    End Property

    'La descripción que muestra el tipo, marca y otras características del producto.
    Private _varDescripcion As String
    Public Property Descripcion() As String
        Get
            Return _varDescripcion
        End Get
        Set(ByVal value As String)
            _varDescripcion = value
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
    Private _varTimpuesto As Double
    Public Property Timpuesto() As Double
        Get
            Return _varTimpuesto
        End Get
        Set(ByVal value As Double)
            _varTimpuesto = value
        End Set
    End Property

    'El descuento total calculado por la ((Cantidad * PrecioUnitario)*Descuento%)
    Private _varTdescuento As Double
    Public Property Tdescuento() As Double
        Get
            Return _varTdescuento
        End Get
        Set(ByVal value As Double)
            _varTdescuento = value
        End Set
    End Property
End Class