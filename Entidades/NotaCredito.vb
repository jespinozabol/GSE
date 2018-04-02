'Continene: Id_NC, Num_Factura, Fecha, Monto, Estado
Public Class NotaCredito

    'Lista usada para la propiedad Estado.
    Enum ListaEstado
        Pendiente = 0
        Aplicada = 1
        Anulada = 2
    End Enum

    'Se declara un constructor para inicializar la lista que tendrá todas las líneas de productos a los que se le hicieron la NC
    Public Sub New()
        NCDetalles = New List(Of NotaCreditoDetalle)
    End Sub

    'Variable extraída de la tabla CONSECUTIVO_NC y que identifica de forma única a cada NC
    Private _varIdNC As Integer
    Public Property IdNC() As Integer
        Get
            Return _varIdNC
        End Get
        Set(ByVal value As Integer)
            _varIdNC = value
        End Set
    End Property

    'Variable extraída de la tabla FACTURA y que específica a cual factura pertenece la nota de crédito.
    Private _varNumFactura As Integer
    Public Property NumFactura() As Integer
        Get
            Return _varNumFactura
        End Get
        Set(ByVal value As Integer)
            _varNumFactura = value
        End Set
    End Property

    'Fecha en que fue creada la nota de crédito.
    Private _varFecha As Date
    Public Property Fecha() As Date
        Get
            Return _varFecha
        End Get
        Set(ByVal value As Date)
            _varFecha = value
        End Set
    End Property

    'Valor monetario que almacena el monto total de la nota de crédito.
    Private _varMonto As Double
    Public Property Monto() As Double
        Get
            Return _varMonto
        End Get
        Set(ByVal value As Double)
            _varMonto = value
        End Set
    End Property

    '0- Pendiente 1- Aplicado 2- Anulado
    Private _varEstado As ListaEstado
    Public Property Estado() As ListaEstado
        Get
            Return _varEstado
        End Get
        Set(ByVal value As ListaEstado)
            _varEstado = value
        End Set
    End Property

    'Una lista que guarda todas las líneas con los productos a los que se les hizo la nota.
    Private _varNCDetalles As List(Of NotaCreditoDetalle)
    Public Property NCDetalles() As List(Of NotaCreditoDetalle)
        Get
            Return _varNCDetalles
        End Get
        Set(ByVal value As List(Of NotaCreditoDetalle))
            _varNCDetalles = value
        End Set
    End Property
End Class
