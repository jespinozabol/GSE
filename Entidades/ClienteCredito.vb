'Continene: Id_Credito, Limite, Estado, Tipo, Total_Creditos, Ente_Fisico, Dias_Atrasado, Total_Atrasado,
' Nombre_Real, Email, Sitio_Web, Fecha_Creacion y una lista Bitacoras. Además los atributos del objeto Persona.
Public Class ClienteCredito
    Inherits Persona

    'Se usa para no guardar toda la  palabra, sino solamente un número que represente el tipo de crédito. 
    Enum ListaTipo
        Preferencial = 1
        Normal = 2
        Prueba = 3
    End Enum

    'Lista usada para la propiedad Estado.
    Enum ListaEstado
        Cerrado = 0
        Abierto = 1
        Congelado = 2
    End Enum

    'Se inicializa la lista de bitacoras que contiene el cliente.
    Public Sub New()
        ListaBitacora = New List(Of Bitacora)
    End Sub

    'Identificador único autoincrementable para cada cliente que se crea de crédito.
    Private _varIdCredito As Integer
    Public Property IdCredito() As Integer
        Get
            Return _varIdCredito
        End Get
        Set(ByVal value As Integer)
            _varIdCredito = value
        End Set
    End Property

    'Un valor monetario del máximo en dinero que se le puede dar al cliente.
    Private _varLimite As Double
    Public Property Limite() As Double
        Get
            Return _varLimite
        End Get
        Set(ByVal value As Double)
            _varLimite = value
        End Set
    End Property

    '0- Cerrado 1- Abierto 2- Congelado
    Private _varEstado As ListaEstado
    Public Property Estado() As ListaEstado
        Get
            Return _varEstado
        End Get
        Set(ByVal value As ListaEstado)
            _varEstado = value
        End Set
    End Property

    '1- Preferencial, 2- Normal, 3- Prueba).
    Private _varTipo As ListaTipo
    Public Property Tipo() As ListaTipo
        Get
            Return _varTipo
        End Get
        Set(ByVal value As ListaTipo)
            _varTipo = value
        End Set
    End Property

    'Un valor monetario con el total de crédito pendiente.
    Private _varTotalCreditos As Double
    Public Property TotalCreditos() As Double
        Get
            Return _varTotalCreditos
        End Get
        Set(ByVal value As Double)
            _varTotalCreditos = value
        End Set
    End Property

    'Específica si el cliente es Físico o Jurídico 0-Juridico 1-Fisico.
    Private _varEnteFisico As Boolean
    Public Property EnteFisico() As Boolean
        Get
            Return _varEnteFisico
        End Get
        Set(ByVal value As Boolean)
            _varEnteFisico = value
        End Set
    End Property

    'Almacena el número de días atrasados en el pago de las facturas.
    Private _varDiasAtrasado As Integer
    Public Property DiasAtrasado() As Integer
        Get
            Return _varDiasAtrasado
        End Get
        Set(ByVal value As Integer)
            _varDiasAtrasado = value
        End Set
    End Property

    'Un valor monetario con el total de crédito atrasado.
    Private _varTotalAtrasado As Double
    Public Property TotalAtrasado() As Double
        Get
            Return _varTotalAtrasado
        End Get
        Set(ByVal value As Double)
            _varTotalAtrasado = value
        End Set
    End Property

    'El nombre real del cliente, ya que se puede facturar a un nombre pero tenga otro.
    Private _varNombreReal As String
    Public Property NombreReal() As String
        Get
            Return _varNombreReal
        End Get
        Set(ByVal value As String)
            _varNombreReal = value
        End Set
    End Property

    'Guarda la fecha en que fue creado el crédito para control interno.
    Private _varFechaCreacion As Date
    Public Property FechaCreacion() As Date
        Get
            Return _varFechaCreacion
        End Get
        Set(ByVal value As Date)
            _varFechaCreacion = value
        End Set
    End Property

    'Contiene una lista de todas las bitocoras emitidas a un cliente.
    Private _varListaBitacoras As List(Of Bitacora)
    Public Property ListaBitacora() As List(Of Bitacora)
        Get
            Return _varListaBitacoras
        End Get
        Set(ByVal value As List(Of Bitacora))
            _varListaBitacoras = value
        End Set
    End Property

    Private varBloqueo As Boolean
    Public Property Bloqueo() As Boolean
        Get
            Return varBloqueo
        End Get
        Set(ByVal value As Boolean)
            varBloqueo = value
        End Set
    End Property

    Private varIncluirEnCobro As Boolean
    Public Property IncluirEnCobro() As Boolean
        Get
            Return varIncluirEnCobro
        End Get
        Set(ByVal value As Boolean)
            varIncluirEnCobro = value
        End Set
    End Property

    'Contiene una lista de todos sus encargados
    Private _varEncargados As List(Of EncargadoClienteCredito)
    Public Property Encargados() As List(Of EncargadoClienteCredito)
        Get
            Return _varEncargados
        End Get
        Set(ByVal value As List(Of EncargadoClienteCredito))
            _varEncargados = value
        End Set
    End Property
End Class
