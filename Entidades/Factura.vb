'Continene: Num_Factura, Id_Persona, Id_Referencia, Contado, Fecha, Anulada, Ganancia.
Public Class Factura

    'Se declara un constructor para inicializar la lista que tendrá todas las líneas de productos de la factura.
    Public Sub New()
        FacturaDetalles = New List(Of FacturaDetalle)
    End Sub

    'Un identificador único para cada factura, será extraído de la tabla CONSECUTIVO_FACTURA
    Private _varNumFactura As Integer
    Public Property NumFactura() As Integer
        Get
            Return _varNumFactura
        End Get
        Set(ByVal value As Integer)
            _varNumFactura = value
        End Set
    End Property

    'Variable extraída de la tabla PERSONA y que específica a la persona a la cuál fue facturado. 
    Private _varIdPersona As Integer
    Public Property IdPersona() As Integer
        Get
            Return _varIdPersona
        End Get
        Set(ByVal value As Integer)
            _varIdPersona = value
        End Set
    End Property

    'Variable extraída de la tabla REFERENCIA y que específica la referencia de la factura en el caso de que tenga
    Private _varIdReferencia As UShort
    Public Property IdReferencia() As UShort
        Get
            Return _varIdReferencia
        End Get
        Set(ByVal value As UShort)
            _varIdReferencia = value
        End Set
    End Property

    'Guarda si la factura es de contado o de crédito
    Private _varContado As Boolean
    Public Property Contado() As Boolean
        Get
            Return _varContado
        End Get
        Set(ByVal value As Boolean)
            _varContado = value
        End Set
    End Property

    'Guarda la fecha en que fue facturada.
    Private _varFecha As Date
    Public Property Fecha() As Date
        Get
            Return _varFecha
        End Get
        Set(ByVal value As Date)
            _varFecha = value
        End Set
    End Property

    'Si esta variable está en 1, la factura ha sido anulada.
    Private _varAnulada As Boolean
    Public Property Anulada() As Boolean
        Get
            Return _varAnulada
        End Get
        Set(ByVal value As Boolean)
            _varAnulada = value
        End Set
    End Property

    'La ganancia total de esta venta.
    Private _varGanancia As Double
    Public Property Ganancia() As Double
        Get
            Return _varGanancia
        End Get
        Set(ByVal value As Double)
            _varGanancia = value
        End Set
    End Property

    'Una lista que guarda todas las líneas con los productos que fueron vendidos.
    Private _varFacturaDetalles As List(Of FacturaDetalle)
    Public Property FacturaDetalles() As List(Of FacturaDetalle)
        Get
            Return _varFacturaDetalles
        End Get
        Set(ByVal value As List(Of FacturaDetalle))
            _varFacturaDetalles = value
        End Set
    End Property
End Class