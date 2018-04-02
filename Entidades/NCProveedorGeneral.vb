'Continene: Id_NCG,Id_Proveedor, Num_NC,Total, IV, Motivo, Boleta, Fecha, FechaBoleta,
' SubTotalIV, SubTotalEx, PorDescuento, Estado.
Public Class NCProveedorGeneral

    'Lista usada para la propiedad Estado.
    Enum ListaEstado
        Pendiente = 0
        Aplicado = 1
        Anulado = 2
    End Enum

    'Variable autoincrementable que identifica de forma única a cada nota de crédito general de un proveedor.
    Private _varIdNcg As Integer
    Public Property IdNcg() As Integer
        Get
            Return _varIdNcg
        End Get
        Set(ByVal value As Integer)
            _varIdNcg = value
        End Set
    End Property

    'Variable extraída de la tabla PROVEEDOR y que específica a cual proveedor pertenece la nota de crédito.
    Private _varIdProveedor As Integer
    Public Property IdProveedor() As Integer
        Get
            Return _varIdProveedor
        End Get
        Set(ByVal value As Integer)
            _varIdProveedor = value
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
    Private _varBoleta As Integer
    Public Property Boleta() As Integer
        Get
            Return _varBoleta
        End Get
        Set(ByVal value As Integer)
            _varBoleta = value
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
End Class
