'Continene: Id_DocPorPagar,Num_NC, Total, IV, Motivo, BoletaDev, Fecha, FechaBoleta, SubTotalIV, SubTotalEx, PorDescuento
Public Class NCFacturaProveedor

    Private varIdNC As Integer
    Public Property IdNC() As Integer
        Get
            Return varIdNC
        End Get
        Set(ByVal value As Integer)
            varIdNC = value
        End Set
    End Property

    'Variable extraída de la tabla FACTURA_PROVEEDOR y que guarda el id de la factura a la cual se le hizo la NC.
    Private _varIdDocPorPagar As Integer
    Public Property IdDocPorPagar() As Integer
        Get
            Return _varIdDocPorPagar
        End Get
        Set(ByVal value As Integer)
            _varIdDocPorPagar = value
        End Set
    End Property

    'Variable que almacena el número de la nota de crédito. (Extraída del doc que el proveedor nos manda)
    Private _varNumNC As Integer
    Public Property NumNC() As Integer
        Get
            Return _varNumNC
        End Get
        Set(ByVal value As Integer)
            _varNumNC = value
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

    'Cadena que almacena el motivo por el cual fue hecha la nota y los materiales que fueron devueltos.
    Private _varMotivo As String
    Public Property Motivo() As String
        Get
            Return _varMotivo
        End Get
        Set(ByVal value As String)
            _varMotivo = value
        End Set
    End Property

    'Variable que guarda el número de boleta que fue entregado al devolver los artículos.
    Private _varBoletaDev As Integer
    Public Property BoletaDev() As Integer
        Get
            Return _varBoletaDev
        End Get
        Set(ByVal value As Integer)
            _varBoletaDev = value
        End Set
    End Property

    'Fecha en que fue creada la nota de crédito por parte del proveedor.
    Private _varFecha As Date
    Public Property Fecha() As Date
        Get
            Return _varFecha
        End Get
        Set(ByVal value As Date)
            _varFecha = value
        End Set
    End Property

    'Fecha en que se realizó la boleta de devolución.
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

    'Especifica si la nota de crédito es por un descuento faltante o adicional.
    Private _varPorDescuento As Boolean
    Public Property PorDescuento() As Boolean
        Get
            Return _varPorDescuento
        End Get
        Set(ByVal value As Boolean)
            _varPorDescuento = value
        End Set
    End Property
End Class