'Contiene: Num_Vale, Fecha, Hora, Monto, Solicitante, Autorizado, Observaciones
Public Class Vale

    'Identificador único para cada vale que se crea.
    Private varNum_Vale As Integer
    Public Property Num_Vale() As Integer
        Get
            Return varNum_Vale
        End Get
        Set(ByVal value As Integer)
            varNum_Vale = value
        End Set
    End Property

    'La fecha en que se realizó el vale
    Private varFecha As Date
    Public Property Fecha() As Date
        Get
            Return varFecha
        End Get
        Set(ByVal value As Date)
            varFecha = value
        End Set
    End Property

    'La hora en que se realizó el vale
    Private varHora As String
    Public Property Hora() As String
        Get
            Return varHora
        End Get
        Set(ByVal value As String)
            varHora = value
        End Set
    End Property

    'El monto solicitado en el vale.
    Private varMonto As Double
    Public Property Monto() As Double
        Get
            Return varMonto
        End Get
        Set(ByVal value As Double)
            varMonto = value
        End Set
    End Property

    'Variable extraída de la tabla EMPLEADO_OTRO y que específica cuál es el empleado que solicitó el vale.
    Private varSolicitante As Integer
    Public Property Solicitante() As Integer
        Get
            Return varSolicitante
        End Get
        Set(ByVal value As Integer)
            varSolicitante = value
        End Set
    End Property

    'Variable extraída de la tabla EMPLEADO_OTRO y que específica cuál es el empleado que autorizó el vale.
    Private varAutorizado As Integer
    Public Property Autorizado() As Integer
        Get
            Return varAutorizado
        End Get
        Set(ByVal value As Integer)
            varAutorizado = value
        End Set
    End Property

    'Cadena que almacena las observaciones del vale así como algún motivo si existe.
    Private varObservaciones As String
    Public Property Observaciones() As String
        Get
            Return varObservaciones
        End Get
        Set(ByVal value As String)
            varObservaciones = value
        End Set
    End Property
End Class