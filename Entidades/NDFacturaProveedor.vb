'Continene: Id_DocPorPagar,Num_ND, Total, IV, Motivo, Boleta, Fecha, FechaBoleta, SubTotalIV, SubTotalEx
Public Class NDFacturaProveedor

    Private varIdND As Integer
    Public Property IdND() As Integer
        Get
            Return varIdND
        End Get
        Set(ByVal value As Integer)
            varIdND = value
        End Set
    End Property

    'Variable extraída de la tabla FACTURA_PROVEEDOR y que guarda el id de la factura a la cual se le hizo la ND.
    Private _varIdDocPorPagar As Integer
    Public Property IdDocPorPagar() As Integer
        Get
            Return _varIdDocPorPagar
        End Get
        Set(ByVal value As Integer)
            _varIdDocPorPagar = value
        End Set
    End Property

    'Variable que almacena el número de la nota de débito. (Extraída del doc que el proveedor nos manda)
    Private _varNumND As Integer
    Public Property NumND() As Integer
        Get
            Return _varNumND
        End Get
        Set(ByVal value As Integer)
            _varNumND = value
        End Set
    End Property

    'Valor monetario con el monto total de la nota.
    Private _varTotal As Double
    Public Property Total() As Double
        Get
            Return _varTotal
        End Get
        Set(ByVal value As Double)
            _varTotal = value
        End Set
    End Property

    'Valor monetario con el impuesto de venta de la nota.
    Private _varIV As Double
    Public Property IV() As Double
        Get
            Return _varIV
        End Get
        Set(ByVal value As Double)
            _varIV = value
        End Set
    End Property

    'Cadena que almacena el motivo por el cual fue hecha la nota débito.
    Private _varMotivo As String
    Public Property Motivo() As String
        Get
            Return _varMotivo
        End Get
        Set(ByVal value As String)
            _varMotivo = value
        End Set
    End Property

    'Variable que guarda el número de boleta si existe.
    Private _varBoleta As Integer
    Public Property Boleta() As Integer
        Get
            Return _varBoleta
        End Get
        Set(ByVal value As Integer)
            _varBoleta = value
        End Set
    End Property

    'Fecha en que fue creada la nota de débito por parte del proveedor.
    Private _varFecha As Date
    Public Property Fecha() As Date
        Get
            Return _varFecha
        End Get
        Set(ByVal value As Date)
            _varFecha = value
        End Set
    End Property

    'Fecha en que se realizó la boleta.
    Private _varFechaBoleta As Date
    Public Property FechaBoleta() As Date
        Get
            Return _varFechaBoleta
        End Get
        Set(ByVal value As Date)
            _varFechaBoleta = value
        End Set
    End Property

    'Valor monetario con el subtotal al que se le aplicará impuesto.
    Private _varSubTotalIV As Double
    Public Property SubTotalIV() As Double
        Get
            Return _varSubTotalIV
        End Get
        Set(ByVal value As Double)
            _varSubTotalIV = value
        End Set
    End Property

    'Valor monetario con el subtotal excento del impuesto de venta.
    Private _varSubTotalEx As Double
    Public Property SubTotalEx() As Double
        Get
            Return _varSubTotalEx
        End Get
        Set(ByVal value As Double)
            _varSubTotalEx = value
        End Set
    End Property
End Class
