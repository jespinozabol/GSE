Public Class EmailCliente
    'Variable extraída de la tabla PERSONA y que específica a cual persona pertenece el email
    Private varId_Persona As Integer
    Public Property Id_Persona() As Integer
        Get
            Return varId_Persona
        End Get
        Set(ByVal value As Integer)
            varId_Persona = value
        End Set
    End Property

    'Variable que almacena el email.
    Private varEmail As String
    Public Property Email() As String
        Get
            Return varEmail
        End Get
        Set(ByVal value As String)
            varEmail = value
        End Set
    End Property

    'Cadena que almacena alguna observación o detalle del email.
    Private varDetalle As String
    Public Property Detalle() As String
        Get
            Return varDetalle
        End Get
        Set(ByVal value As String)
            varDetalle = value
        End Set
    End Property
End Class
