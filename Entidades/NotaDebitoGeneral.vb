'Continene: Id_ND,Fecha, IdCliente_Credito,Monto, Motivo, Impuesto, Estado.
Public Class NotaDebitoGeneral

    'Lista usada para la propiedad Estado.
    Enum ListaEstado
        NoAplicada = 0
        Aplicada = 1
        Anulada = 2
    End Enum

    'Variable extraída de la tabla CONSECUTIVO_ND y que identifica de forma única a cada NC
    Private _varIdND As Integer
    Public Property IdND() As Integer
        Get
            Return _varIdND
        End Get
        Set(ByVal value As Integer)
            _varIdND = value
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

    'Variable extraída de la tabla CLIENTE_CREDITO y que específica a cual cliente pertenece la nota de crédito.
    Private _varIdClienteCredito As Integer
    Public Property IdClienteCredito() As Integer
        Get
            Return _varIdClienteCredito
        End Get
        Set(ByVal value As Integer)
            _varIdClienteCredito = value
        End Set
    End Property

    'Valor monetario con el monto total de la nota.
    Private _varMonto As Double
    Public Property Monto() As Double
        Get
            Return _varMonto
        End Get
        Set(ByVal value As Double)
            _varMonto = value
        End Set
    End Property

    'Cadena que almacena el motivo por el cual fue hecha la nota.
    Private _varMotivo As String
    Public Property Motivo() As String
        Get
            Return _varMotivo
        End Get
        Set(ByVal value As String)
            _varMotivo = value
        End Set
    End Property

    'Valor monetario con el impuesto de venta de la nota.
    Private _varImpuesto As Double
    Public Property Impuesto() As Double
        Get
            Return _varImpuesto
        End Get
        Set(ByVal value As Double)
            _varImpuesto = value
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

    Private varNumDias As Integer
    Public Property NumDias() As Integer
        Get
            Return varNumDias
        End Get
        Set(ByVal value As Integer)
            varNumDias = value
        End Set
    End Property

    Private _varAbonos As List(Of Abono)
    Public Property Abonos() As List(Of Abono)
        Get
            Return _varAbonos
        End Get
        Set(ByVal value As List(Of Abono))
            _varAbonos = value
        End Set
    End Property
End Class