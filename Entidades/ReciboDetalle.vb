'Contiene: Tipo, Num_Recibo, Doc, Fecha, Monto
Public Class ReciboDetalle

    'Lista usada para la propiedad Tipo.
    Enum ListaTipo
        Cancelacion = 1
        FactAbono = 2
        Abono = 3
        NotaCredito = 4
        NCGeneral = 5
        NDGeneral = 6
        SaldoActual = 7
    End Enum

    '1-Cancelacion 2-Fact_Abono, 3-Abono, 4-Nota_Credito, 5-NC_General, 6-ND_General
    Private _varTipo As ListaTipo
    Public Property Tipo() As ListaTipo
        Get
            Return _varTipo
        End Get
        Set(ByVal value As ListaTipo)
            _varTipo = value
        End Set
    End Property

    'Variable extraída de la tabla RECIBODINERO_ENCABEZADO y que específica a cual recibo pertenece la linea de detalle.
    Private _varNumRecibo As Integer
    Public Property NumRecibo() As Integer
        Get
            Return _varNumRecibo
        End Get
        Set(ByVal value As Integer)
            _varNumRecibo = value
        End Set
    End Property

    'Num de documento segun sea el tipo
    Private _varDoc As Integer
    Public Property Doc() As Integer
        Get
            Return _varDoc
        End Get
        Set(ByVal value As Integer)
            _varDoc = value
        End Set
    End Property

    'La fecha en que fue emitido el documento.
    Private _varFecha As String
    Public Property Fecha() As String
        Get
            Return _varFecha
        End Get
        Set(ByVal value As String)
            _varFecha = value
        End Set
    End Property

    'El monto total del documento.
    Private _varMonto As Double
    Public Property Monto() As Double
        Get
            Return _varMonto
        End Get
        Set(ByVal value As Double)
            _varMonto = value
        End Set
    End Property
End Class
