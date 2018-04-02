'Continene: Id_Credito, Fecha_Hora, Descripcion
Public Class Bitacora

    'Variable extraída de la tabla CLIENTE_CREDITO y que específica a cual cliente pertenece la bitacora.
    Private _varIdCredito As Integer
    Public Property IdCredito() As Integer
        Get
            Return _varIdCredito
        End Get
        Set(ByVal value As Integer)
            _varIdCredito = value
        End Set
    End Property

    'Fecha y hora en que fue creada la bitacora
    Private _varFechaHora As String
    Public Property FechaHora() As String
        Get
            Return _varFechaHora
        End Get
        Set(ByVal value As String)
            _varFechaHora = value
        End Set
    End Property

    'Descripción o motivo de la creación de la bitacora.
    Private _varDescripcion As String
    Public Property Descripcion() As String
        Get
            Return _varDescripcion
        End Get
        Set(ByVal value As String)
            _varDescripcion = value
        End Set
    End Property
End Class
