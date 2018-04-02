'Continene: Id_Producto,Descripcion, PrecioUnitario,Ganancia, Existencias, Impuesto, Minimo,
' Maximo, Activo, Consignacion, MaxVendido
Public Class Producto

    'Se declara un constructor para inicializar las lista de los proveedores y los productos relacionados.
    Public Sub New()
        ListaProveedores = New List(Of ProductoPorProveedor)
        ListaRelacionados = New List(Of ProductoRelacionado)
    End Sub

    'Un identificador único para cada producto.
    Private _varIdProducto As Integer
    Public Property Id_Producto() As Integer
        Get
            Return _varIdProducto
        End Get
        Set(ByVal value As Integer)
            _varIdProducto = value
        End Set
    End Property

    'La descripción que muestra el tipo, marca y otras características del producto.
    Private _varDescripcion As String
    Public Property Descripcion() As String
        Get
            Return _varDescripcion
        End Get
        Set(ByVal value As String)
            _varDescripcion = value
        End Set
    End Property

    'El precio por cada unidad del producto.
    Private _varPrecioUnitario As Double
    Public Property PrecioUnitario() As Double
        Get
            Return _varPrecioUnitario
        End Get
        Set(ByVal value As Double)
            _varPrecioUnitario = value
        End Set
    End Property

    'La ganancia que se tendrá sobre cada unidad del producto.
    Private _varGanancia As Double
    Public Property Ganancia() As Double
        Get
            Return _varGanancia
        End Get
        Set(ByVal value As Double)
            _varGanancia = value
        End Set
    End Property

    'El número de unidades disponibles del producto.
    Private _varExistencias As Double
    Public Property Existencias() As Double
        Get
            Return _varExistencias
        End Get
        Set(ByVal value As Double)
            _varExistencias = value
        End Set
    End Property

    'Si se tiene que aplicarle o no impuesto.
    Private _varImpuesto As Boolean
    Public Property Impuesto() As Boolean
        Get
            Return _varImpuesto
        End Get
        Set(ByVal value As Boolean)
            _varImpuesto = value
        End Set
    End Property

    'El valor mínimo de unidades que se deben de tener en stock, se usará para realizar los pedidos.
    Private _varMinimo As Double
    Public Property Minimo() As Double
        Get
            Return _varMinimo
        End Get
        Set(ByVal value As Double)
            _varMinimo = value
        End Set
    End Property

    'Un valor que ayuda a mantener una adecuada cantidad de unidades, para no sobrepasar desmedidamente la cantidad.
    Private _varMaximo As Double
    Public Property Maximo() As Double
        Get
            Return _varMaximo
        End Get
        Set(ByVal value As Double)
            _varMaximo = value
        End Set
    End Property

    'Si el producto esta activo, o ya no se usa.
    Private _varActivo As Boolean
    Public Property Activo() As Boolean
        Get
            Return _varActivo
        End Get
        Set(ByVal value As Boolean)
            _varActivo = value
        End Set
    End Property

    'Si el producto es o no a consignación.
    Private _varConsignacion As Boolean
    Public Property Consignacion() As Boolean
        Get
            Return _varConsignacion
        End Get
        Set(ByVal value As Boolean)
            _varConsignacion = value
        End Set
    End Property

    'El número máximo de unidades vendidas en una sola venta.
    Private _varMaxVendido As Double
    Public Property MaxVendido() As Double
        Get
            Return _varMaxVendido
        End Get
        Set(ByVal value As Double)
            _varMaxVendido = value
        End Set
    End Property

    'Una lista donde se guardarán todos los proveedores de este producto.
    Private _varProveedores As List(Of ProductoPorProveedor)
    Public Property ListaProveedores() As List(Of ProductoPorProveedor)
        Get
            Return _varProveedores
        End Get
        Set(ByVal value As List(Of ProductoPorProveedor))
            _varProveedores = value
        End Set
    End Property

    'Una lista donde se guardan los productos relacionados.
    Private _varRelacionados As List(Of ProductoRelacionado)
    Public Property ListaRelacionados() As List(Of ProductoRelacionado)
        Get
            Return _varRelacionados
        End Get
        Set(ByVal value As List(Of ProductoRelacionado))
            _varRelacionados = value
        End Set
    End Property

    'Obtiene todos los datos que tiene la tabla bodega
    Private _varBodega As Bodega
    Public Property Bodega() As Bodega
        Get
            Return _varBodega
        End Get
        Set(ByVal value As Bodega)
            _varBodega = value
        End Set
    End Property

End Class