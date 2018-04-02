'Contiene: Id_Persona, Prioridad, Telefono, Detalle
Public Class Telefonos_Cliente

    'Variable extraída de la tabla PERSONA y que específica a cual persona pertenece el teléfono
    Private varId_Persona As Integer
    Public Property Id_Persona() As Integer
        Get
            Return varId_Persona
        End Get
        Set(ByVal value As Integer)
            varId_Persona = value
        End Set
    End Property

    'La prioridad que tiene el teléfono en comparación con otro del mismo cliente.
    Private varPrioridad As Integer
    Public Property Prioridad() As Integer
        Get
            Return varPrioridad
        End Get
        Set(ByVal value As Integer)
            varPrioridad = value
        End Set
    End Property

    'Variable que almacena el número de teléfono.
    Private varTelefono As String
    Public Property Telefono() As String
        Get
            Return varTelefono
        End Get
        Set(ByVal value As String)
            varTelefono = value
        End Set
    End Property

    'Cadena que almacena alguna observación o detalle del télefono.
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