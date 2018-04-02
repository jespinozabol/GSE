'Continene: Id_Listado, Nombre_Cliente, Telefono, Total_Listado, Fecha, Impreso, Fecha_Impreso, Bloqueo.
Public Class Listado

    'Se declara un constructor para inicializar las listas de personas autorizadas, el resumen de las lineas
    ' entregadas y una lista con el historial de cada linea.
    Public Sub New()
        ListaAutorizados = New List(Of ListadoAutorizado)
        ListaResumen = New List(Of ListadoResumen)
        ListaHistorial = New List(Of ListadoHistorial)
    End Sub

    'Un identificador único para cada listado, será extraído de la tabla CONSECUTIVO_LISTADO
    Private _varIdListado As Integer
    Public Property IdListado() As Integer
        Get
            Return _varIdListado
        End Get
        Set(ByVal value As Integer)
            _varIdListado = value
        End Set
    End Property

    'El nombre completo del supuesto cliente, a quién se le cobrarán los materiales.
    Private _varNombreCliente As String
    Public Property NombreCliente() As String
        Get
            Return _varNombreCliente
        End Get
        Set(ByVal value As String)
            _varNombreCliente = value
        End Set
    End Property

    'Un número de teléfono en donde se pueda localizar al cliente.
    Private _varTelefono As String
    Public Property Telefono() As String
        Get
            Return _varTelefono
        End Get
        Set(ByVal value As String)
            _varTelefono = value
        End Set
    End Property

    'El total monetario del listado.
    Private _varTotalListado As Double
    Public Property TotalListado() As Double
        Get
            Return _varTotalListado
        End Get
        Set(ByVal value As Double)
            _varTotalListado = value
        End Set
    End Property

    'La fecha en que fue creado el listado.
    Private _varFecha As Date
    Public Property Fecha() As Date
        Get
            Return _varFecha
        End Get
        Set(ByVal value As Date)
            _varFecha = value
        End Set
    End Property

    'La fecha en que fue facturado el listado.
    Private _varFechaImpreso As Date
    Public Property NewProperty() As Date
        Get
            Return _varFechaImpreso
        End Get
        Set(ByVal value As Date)
            _varFechaImpreso = value
        End Set
    End Property

    'Almacena si el listado esta bloqueado o no, Si está bloqueado significa que ha sido abierto en otra pantalla.
    Private _varBloqueo As Boolean
    Public Property Bloqueo() As Boolean
        Get
            Return _varBloqueo
        End Get
        Set(ByVal value As Boolean)
            _varBloqueo = value
        End Set
    End Property

    'Contiene una lista de todos los autorizados que pueden retirar productos para ese cliente
    Private _varListadoAutorizado As List(Of ListadoAutorizado)
    Public Property ListaAutorizados() As List(Of ListadoAutorizado)
        Get
            Return _varListadoAutorizado
        End Get
        Set(ByVal value As List(Of ListadoAutorizado))
            _varListadoAutorizado = value
        End Set
    End Property

    'Contiene una lista de todas las lineas con los productos entregados. 
    Private _varListadoResumen As List(Of ListadoResumen)
    Public Property ListaResumen() As List(Of ListadoResumen)
        Get
            Return _varListadoResumen
        End Get
        Set(ByVal value As List(Of ListadoResumen))
            _varListadoResumen = value
        End Set
    End Property

    'Contiene una lista con el historial de cada producto entregado.
    Private _varListaHistorial As List(Of ListadoHistorial)
    Public Property ListaHistorial() As List(Of ListadoHistorial)
        Get
            Return _varListaHistorial
        End Get
        Set(ByVal value As List(Of ListadoHistorial))
            _varListaHistorial = value
        End Set
    End Property
End Class
