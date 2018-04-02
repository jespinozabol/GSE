'Continene: Id_Listado,Id_Producto, Cantidad, Fecha, Retiro, Hora
Public Class ListadoHistorial

    'Variable extraída de la tabla LISTADO y que guarda el número de listado al que pertenece ésta línea.
    Private _varIdListado As Integer
    Public Property IdListado() As Integer
        Get
            Return _varIdListado
        End Get
        Set(ByVal value As Integer)
            _varIdListado = value
        End Set
    End Property

    'Variable extraída de la tabla PRODUCTO y que guarda el id del producto que se va a listar.
    Private _varIdProducto As Integer
    Public Property Id_Producto() As Integer
        Get
            Return _varIdProducto
        End Get
        Set(ByVal value As Integer)
            _varIdProducto = value
        End Set
    End Property

    'Las unidades que se entregáron del producto listado.
    Private _varCantidad As Double
    Public Property Cantidad() As Double
        Get
            Return _varCantidad
        End Get
        Set(ByVal value As Double)
            _varCantidad = value
        End Set
    End Property

    'Fecha en que fue retirado el artículo.
    Private _varFecha As Date
    Public Property Fecha() As Date
        Get
            Return _varFecha
        End Get
        Set(ByVal value As Date)
            _varFecha = value
        End Set
    End Property

    'Quién retiró el artículo
    Private _varRetiro As String
    Public Property Retira() As String
        Get
            Return _varRetiro
        End Get
        Set(ByVal value As String)
            _varRetiro = value
        End Set
    End Property

    'La hora en que fue retirado el artículo
    Private _varHora As String
    Public Property Hora() As String
        Get
            Return _varHora
        End Get
        Set(ByVal value As String)
            _varHora = value
        End Set
    End Property
End Class
