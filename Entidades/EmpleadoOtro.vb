'Continene: Tipo, Id_Empleado. Además los atributos del objeto Persona.
Public Class EmpleadoOtro
    Inherits Persona

    'Empleado, propietario, ect
    Private _varTipo As String
    Public Property Tipo() As String
        Get
            Return _varTipo
        End Get
        Set(ByVal value As String)
            _varTipo = value
        End Set
    End Property

    'Identificador único autoincrementable para cada empleado que se crea.
    Private _varIdEmpleado As Integer
    Public Property IdEmpleado() As Integer
        Get
            Return _varIdEmpleado
        End Get
        Set(ByVal value As Integer)
            _varIdEmpleado = value
        End Set
    End Property
End Class
