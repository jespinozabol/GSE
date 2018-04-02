'Continene: Id_Autorizado,Id_Listado, Nombre, Telefono, Activo
Public Class ListadoAutorizado

    'Variable autoincrementable que identifica de forma única a cada autorizado.
    Private _varIdAutorizado As Integer
    Public Property IdAutorizado() As Integer
        Get
            Return _varIdAutorizado
        End Get
        Set(ByVal value As Integer)
            _varIdAutorizado = value
        End Set
    End Property

    'Variable extraída de la tabla LISTADO y que específica a cual listado pertenece el autorizado.
    Private _varIdListado As Integer
    Public Property IdListado() As Integer
        Get
            Return _varIdListado
        End Get
        Set(ByVal value As Integer)
            _varIdListado = value
        End Set
    End Property

    'Nombre de la persona autorizada a retirar los productos.
    Private _varNombre As String
    Public Property Nombre() As String
        Get
            Return _varNombre
        End Get
        Set(ByVal value As String)
            _varNombre = value
        End Set
    End Property

    'Un teléfono donde se pueda localizar al autorizado.
    Private _varTelefono As String
    Public Property Telefono() As String
        Get
            Return _varTelefono
        End Get
        Set(ByVal value As String)
            _varTelefono = value
        End Set
    End Property

    'Especifica si el autorizado pueden seguir retirando articulos o no.
    Private _varActivo As Boolean
    Public Property Activo() As Boolean
        Get
            Return _varActivo
        End Get
        Set(ByVal value As Boolean)
            _varActivo = value
        End Set
    End Property
End Class
