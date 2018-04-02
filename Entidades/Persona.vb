'Continene: Id_Persona,Nombre, Primer_Apellido,Segundo_Apellido, Cedula.
Public Class Persona

    'Se declara un constructor para inicializar el objeto que contiene información adicional de la persona.
    Public Sub New()
        OtraInformacion = New InformacionPersonal
    End Sub

    'Un identificador único que identifica a cada persona.
    Private _varIdPersona As Integer
    Public Property IdPersona() As Integer
        Get
            Return _varIdPersona
        End Get
        Set(ByVal value As Integer)
            _varIdPersona = value
        End Set
    End Property

    'El nombre(también segundo nombre si tiene) de la persona o empresa.
    Private _varNombre As String
    Public Property Nombre() As String
        Get
            Return _varNombre
        End Get
        Set(ByVal value As String)
            _varNombre = value
        End Set
    End Property

    'En caso de no ser una empresa se debe guardar el primer apellido.
    Private _varApellido1 As String
    Public Property PrimerApellido() As String
        Get
            Return _varApellido1
        End Get
        Set(ByVal value As String)
            _varApellido1 = value
        End Set
    End Property

    'En caso de no ser una empresa se debe guardar el segundo apellido.
    Private _varApellido2 As String
    Public Property SegundoApellido() As String
        Get
            Return _varApellido2
        End Get
        Set(ByVal value As String)
            _varApellido2 = value
        End Set
    End Property

    'La cédula de la persona o la empresa.
    Private _varCedula As String
    Public Property Cedula() As String
        Get
            Return _varCedula
        End Get
        Set(ByVal value As String)
            _varCedula = value
        End Set
    End Property

    'Contiene una lista con la información adicional del cliente como dirección y observaciones.
    Private _varOtraInformacion As InformacionPersonal
    Public Property OtraInformacion() As InformacionPersonal
        Get
            Return _varOtraInformacion
        End Get
        Set(ByVal value As InformacionPersonal)
            _varOtraInformacion = value
        End Set
    End Property
End Class