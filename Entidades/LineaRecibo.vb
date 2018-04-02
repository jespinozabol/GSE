'Continene: Tipo, Doc, Fecha, Monto
Public Class LineaRecibo

    'Específica si el documento es una Nota crédito NC, Nota Débito ND, Abono AB, Factura Fact, Cancelación CA
    Private _varTipo As String
    Public Property Tipo() As String
        Get
            Return _varTipo
        End Get
        Set(ByVal value As String)
            _varTipo = value
        End Set
    End Property

    'Almacena el num de documento.
    Private _varDoc As String
    Public Property Doc() As String
        Get
            Return _varDoc
        End Get
        Set(ByVal value As String)
            _varDoc = value
        End Set
    End Property

    'Almacena la fecha en que fue creado.
    Private _varFecha As String
    Public Property Fecha() As String
        Get
            Return _varFecha
        End Get
        Set(ByVal value As String)
            _varFecha = value
        End Set
    End Property

    'Variable monetaria que especifica el monto total del documento.
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
