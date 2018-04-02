'Continene: Id_Persona, Direccion, Observaciones
Public Class InformacionPersonal

    'Se declara un constructor para inicializar la lista de teléfonos de una persona
    Public Sub New()

    End Sub

    'Variable extraída de la tabla PERSONA y que específica a cual persona pertenece la información.
    Private _varIdPersona As Integer
    Public Property IdPersona() As Integer
        Get
            Return _varIdPersona
        End Get
        Set(ByVal value As Integer)
            _varIdPersona = value
        End Set
    End Property

    'La direccion exacta donde se puede localizar al cliente.
    Private _varDireccion As String
    Public Property Direccion() As String
        Get
            Return _varDireccion
        End Get
        Set(ByVal value As String)
            _varDireccion = value
        End Set
    End Property

    'Alguna otra cosa que se debe saber del cliente.
    Private _varObservaciones As String
    Public Property Observaciones() As String
        Get
            Return _varObservaciones
        End Get
        Set(ByVal value As String)
            _varObservaciones = value
        End Set
    End Property

    Private _varTelefonoPrincipal As String
    Public Property TelefonoPrincipal() As String
        Get
            Return _varTelefonoPrincipal
        End Get
        Set(ByVal value As String)
            _varTelefonoPrincipal = value
        End Set
    End Property

    Private _varOtroTelefono As String
    Public Property OtroTelefono() As String
        Get
            Return _varOtroTelefono
        End Get
        Set(ByVal value As String)
            _varOtroTelefono = value
        End Set
    End Property

    Private _varFaxPrincipal As String
    Public Property FaxPrincipal() As String
        Get
            Return _varFaxPrincipal
        End Get
        Set(ByVal value As String)
            _varFaxPrincipal = value
        End Set
    End Property

    Private _varEmail As String
    Public Property Email() As String
        Get
            Return _varEmail
        End Get
        Set(ByVal value As String)
            _varEmail = value
        End Set
    End Property

    'Almacena la dirección del sitio web del cliente.
    Private _varSitioWeb As String
    Public Property SitioWeb() As String
        Get
            Return _varSitioWeb
        End Get
        Set(ByVal value As String)
            _varSitioWeb = value
        End Set
    End Property
End Class
