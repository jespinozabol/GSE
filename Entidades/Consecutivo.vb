'Continene: Id_Credito, Limite, Estado, Tipo
Public Class Consecutivo

    'Contiene el siguiente número ya sea de la proforma, factura, abono, nc, nd o recibo_fact.
    Private _varConsecutivo As Integer
    Public Property Consecutivo() As Integer
        Get
            Return _varConsecutivo
        End Get
        Set(ByVal value As Integer)
            _varConsecutivo = value
        End Set
    End Property

    'Específica si la tabla esta bloqueada o no.
    Private _varBloqueo As Boolean
    Public Property Bloqueo() As Boolean
        Get
            Return _varBloqueo
        End Get
        Set(ByVal value As Boolean)
            _varBloqueo = value
        End Set
    End Property

    'Guarda el nombre de la tabla de la cual se debe realizar la transacción 
    ' (CONSECUTIVO_ABONO, CONSECUTIVO_FACTURA, CONSECUTIVO_LISTADO, CONSECUTIVO_PROFORMA)
    Private _varTabla As String
    Public Property Tabla() As String
        Get
            Return _varTabla
        End Get
        Set(ByVal value As String)
            _varTabla = value
        End Set
    End Property
End Class
