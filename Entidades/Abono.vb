'Conformado por Id_Abono, Num_Factura, Fecha, Monto, Observaciones, Estado.
Public Class Abono

    'Lista usada para la propiedad Estado.
    Enum ListaEstado
        Pendiente = 0
        Aplicado = 1
        Anulado = 2
    End Enum

    'Lista usada para la propiedad TipoDoc.
    Enum ListaTipoDoc
        FACT = 0
        NDG = 1
    End Enum

    'Un identificador único para cada ABONO, será extraído de la tabla CONSECUTIVO_ABONO
    Private _varIdAbono As Integer
    Public Property IdAbono() As Integer
        Get
            Return _varIdAbono
        End Get
        Set(ByVal value As Integer)
            _varIdAbono = value
        End Set
    End Property

    'Variable extraída de la tabla FACTURA_CREDITO y que específica a cual factura pertenece el abono.
    Private _varNumDoc As Long
    Public Property NumDoc() As Long
        Get
            Return _varNumDoc
        End Get
        Set(ByVal value As Long)
            _varNumDoc = value
        End Set
    End Property

    'Fecha en la cuál se produjo el abono.
    Private _varFecha As Date
    Public Property Fecha() As Date
        Get
            Return _varFecha
        End Get
        Set(ByVal value As Date)
            _varFecha = value
        End Set
    End Property

    'El monto en colones que fue abonado a la cuenta o la factura.
    Private _varMonto As Double
    Public Property Monto() As Double
        Get
            Return _varMonto
        End Get
        Set(ByVal value As Double)
            _varMonto = value
        End Set
    End Property

    'Cualquier otra información considerada importante.
    Private _varObservaciones As String
    Public Property Observaciones() As String
        Get
            Return _varObservaciones
        End Get
        Set(ByVal value As String)
            _varObservaciones = value
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

    '0- FACT 1- NDG
    Private _varTipoDoc As ListaTipoDoc
    Public Property TipoDoc() As ListaTipoDoc
        Get
            Return _varTipoDoc
        End Get
        Set(ByVal value As ListaTipoDoc)
            _varTipoDoc = value
        End Set
    End Property
End Class