'Contiene: Id_Proveedor, Nombre, Central_Telefonica, Fax_Principal, Direccion, Correo_Electronico, 
' Cedula, CC, NCuenta.
Public Class Proveedor

    'Se declara un constructor para inicializar las listas que tendrán los agentes y encargados del proveedor.
    Public Sub New()
        Agentes = New List(Of Agente)
        Encargados = New List(Of Encargado)
    End Sub

    'Un identificador autoincrementable único para cada proveedor.
    Private _varIdProveedor As UShort
    Public Property IdProveedor() As UShort
        Get
            Return _varIdProveedor
        End Get
        Set(ByVal value As UShort)
            _varIdProveedor = value
        End Set
    End Property

    'El nombre del proveedor, ya sea personal o una empresa.
    Private _varNombre As String
    Public Property Nombre() As String
        Get
            Return _varNombre
        End Get
        Set(ByVal value As String)
            _varNombre = value
        End Set
    End Property

    'El número de la central telefónica, si no tuviese se guardará el teléfono principal.
    Private _varCentralTelefonica As String
    Public Property CentralTelefonica() As String
        Get
            Return _varCentralTelefonica
        End Get
        Set(ByVal value As String)
            _varCentralTelefonica = value
        End Set
    End Property

    'Número que específica el fax principal del proveedor.
    Private _varFaxPrincipal As String
    Public Property FaxPrincipal() As String
        Get
            Return _varFaxPrincipal
        End Get
        Set(ByVal value As String)
            _varFaxPrincipal = value
        End Set
    End Property

    'Dirección donde se encuentran ubicadas las oficinas centrales.
    Private _varDireccion As String
    Public Property Direccion() As String
        Get
            Return _varDireccion
        End Get
        Set(ByVal value As String)
            _varDireccion = value
        End Set
    End Property

    'Correo electrónico donde se puedan localizar.
    Private _varCorreo As String
    Public Property Correo() As String
        Get
            Return _varCorreo
        End Get
        Set(ByVal value As String)
            _varCorreo = value
        End Set
    End Property

    'Cédula Juridica o Fisica con la que tributan.
    Private _varCedula As String
    Public Property Cedula() As String
        Get
            Return _varCedula
        End Get
        Set(ByVal value As String)
            _varCedula = value
        End Set
    End Property

    'Cadena que almacena el nombre como son conocidos.
    Private _varCc As String
    Public Property CC() As String
        Get
            Return _varCc
        End Get
        Set(ByVal value As String)
            _varCc = value
        End Set
    End Property

    'Cadena que almacena el número de cliente que tiene GSE en cada compañía.
    Private _varNCuenta As String
    Public Property NCuenta() As String
        Get
            Return _varNCuenta
        End Get
        Set(ByVal value As String)
            _varNCuenta = value
        End Set
    End Property

    'Lista que tendrá todos los agentes de un proveedor.
    Private _varAgentes As List(Of Agente)
    Public Property Agentes() As List(Of Agente)
        Get
            Return _varAgentes
        End Get
        Set(ByVal value As List(Of Agente))
            _varAgentes = value
        End Set
    End Property

    'Lista que almacenará los encargados de todas las áreas del proveedor que nos brindan algún servicio.
    Private _varEncargados As List(Of Encargado)
    Public Property Encargados() As List(Of Encargado)
        Get
            Return _varEncargados
        End Get
        Set(ByVal value As List(Of Encargado))
            _varEncargados = value
        End Set
    End Property
End Class