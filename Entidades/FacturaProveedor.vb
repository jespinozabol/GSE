'Continene: Id_DocPagar, Id_Proveedor, Fecha, Num_Factura, SubTotalIV, SubTotalEx,
' IV, Total, Estado, FechaCancelacion, FechaIngreso, MesTributo, Dias, Motivo. 
Public Class FacturaProveedor

    'Lista usada para la propiedad MesTributo.
    Enum ListaMes
        Enero = 0
        Febrero = 1
        Marzo = 2
        Abril = 3
        Mayo = 4
        Junio = 5
        Julio = 6
        Agosto = 7
        Septiembre = 8
        Octubre = 9
        Noviembre = 10
        Diciembre = 11
    End Enum

    'Lista usada para la propiedad Estado.
    Enum ListaEstado
        Pendiente = 0
        Cancelada = 1
        Anulada = 2
    End Enum

    'Se declara un constructor para inicializar las listas de Abonos, NC y ND de la factura de un proveedor.
    Public Sub New()
        ListaNC = New List(Of NCFacturaProveedor)
        ListaND = New List(Of NDFacturaProveedor)
        ListaAbonos = New List(Of AbonoFacturaProveedor)
    End Sub

    'Variable autoincrementable que identifica de forma única a cada factura de los proveedores.
    Private _varIdDocPagar As Integer
    Public Property IdDocPagar() As Integer
        Get
            Return _varIdDocPagar
        End Get
        Set(ByVal value As Integer)
            _varIdDocPagar = value
        End Set
    End Property

    'Variable extraída de la tabla PROVEEDOR y que específica a cual proveedor pertenece la factura.
    Private _varIdProveedor As Integer
    Public Property IdProveedor() As Integer
        Get
            Return _varIdProveedor
        End Get
        Set(ByVal value As Integer)
            _varIdProveedor = value
        End Set
    End Property

    'Guarda la fecha de la factura
    Private _varFecha As Date
    Public Property Fecha() As Date
        Get
            Return _varFecha
        End Get
        Set(ByVal value As Date)
            _varFecha = value
        End Set
    End Property

    'Un identificador único para cada factura según su proveedor
    Private _varNumFactura As String
    Public Property NumFactura() As String
        Get
            Return _varNumFactura
        End Get
        Set(ByVal value As String)
            _varNumFactura = value
        End Set
    End Property

    'Variable que almacena el subtotal de la factura con impuesto. 
    Private _varSubTotalIV As Double
    Public Property SubTotalIV() As Double
        Get
            Return _varSubTotalIV
        End Get
        Set(ByVal value As Double)
            _varSubTotalIV = value
        End Set
    End Property

    'Variable que almacena el subtotal de la factura sin impuesto. 
    Private _varSubTotalEx As Double
    Public Property SubTotalEx() As Double
        Get
            Return _varSubTotalEx
        End Get
        Set(ByVal value As Double)
            _varSubTotalEx = value
        End Set
    End Property

    'El impuesto total calculado por la ((Cantidad *  PrecioUnitario)*Impuesto%)
    Private _varIV As Double
    Public Property IV() As Double
        Get
            Return _varIV
        End Get
        Set(ByVal value As Double)
            _varIV = value
        End Set
    End Property

    'Guarda el total de la factura de un proveedor.
    Private _varTotal As Double
    Public Property Total() As Double
        Get
            Return _varTotal
        End Get
        Set(ByVal value As Double)
            _varTotal = value
        End Set
    End Property

    '0-Pendiente, 1-Cancelada 2-Anulada
    Private _varEstado As ListaEstado
    Public Property Estado() As ListaEstado
        Get
            Return _varEstado
        End Get
        Set(ByVal value As ListaEstado)
            _varEstado = value
        End Set
    End Property

    'Guarda le fecha en que fue cancelada al proveedor.
    Private _varFechaCancelacion As Date
    Public Property FechaCancelacion() As Date
        Get
            Return _varFechaCancelacion
        End Get
        Set(ByVal value As Date)
            _varFechaCancelacion = value
        End Set
    End Property

    'Guarda la fecha en que se ingreso en el sistema.
    Private _varFechaIngreso As Date
    Public Property FechaIngreso() As Date
        Get
            Return _varFechaIngreso
        End Get
        Set(ByVal value As Date)
            _varFechaIngreso = value
        End Set
    End Property

    'Guarda el mes en que se mandó a tributar. ya que no precisamente es igual al de la fecha de creación.
    Private _varMesTributo As ListaMes
    Public Property MesTributo() As ListaMes
        Get
            Return _varMesTributo
        End Get
        Set(ByVal value As ListaMes)
            _varMesTributo = value
        End Set
    End Property

    'Guarda el número de días de plazo que se tiene para cancelar la factura.
    Private _varDias As Integer
    Public Property Dias() As Integer
        Get
            Return _varDias
        End Get
        Set(ByVal value As Integer)
            _varDias = value
        End Set
    End Property

    'Guarda una cadena con todas las observaciones de la factura.
    Private _varMotivo As String
    Public Property Motivo() As String
        Get
            Return _varMotivo
        End Get
        Set(ByVal value As String)
            _varMotivo = value
        End Set
    End Property

    Private _varContado As Boolean
    Public Property Contado() As Boolean
        Get
            Return _varContado
        End Get
        Set(ByVal value As Boolean)
            _varContado = value
        End Set
    End Property

    'Contiene una lista de todas las notas de crédito de la factura.
    Private _varListaNC As List(Of NCFacturaProveedor)
    Public Property ListaNC() As List(Of NCFacturaProveedor)
        Get
            Return _varListaNC
        End Get
        Set(ByVal value As List(Of NCFacturaProveedor))
            _varListaNC = value
        End Set
    End Property

    'Contiene una lista de todas las notas de débito de la factura.
    Private _varListaND As List(Of NDFacturaProveedor)
    Public Property ListaND() As List(Of NDFacturaProveedor)
        Get
            Return _varListaND
        End Get
        Set(ByVal value As List(Of NDFacturaProveedor))
            _varListaND = value
        End Set
    End Property

    'Contiene una lista de todos los abonos de la factura.
    Private _varListaAbonos As List(Of AbonoFacturaProveedor)
    Public Property ListaAbonos() As List(Of AbonoFacturaProveedor)
        Get
            Return _varListaAbonos
        End Get
        Set(ByVal value As List(Of AbonoFacturaProveedor))
            _varListaAbonos = value
        End Set
    End Property
End Class
