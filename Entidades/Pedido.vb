Public Class Pedido

    'Se declara un constructor para inicializar la lista que tendrán los detalles del recibo.
    Public Sub New()
        PedidoDetalle = New List(Of PedidoDetalle)
        ImprimeDTOModel = New List(Of ImprimeDTOModel)
    End Sub

    Private _varIdPedido As Integer
    Public Property IdPedido() As Integer
        Get
            Return _varIdPedido
        End Get
        Set(ByVal value As Integer)
            _varIdPedido = value
        End Set
    End Property

    Private _varFecha As Date
    Public Property Fecha() As Date
        Get
            Return _varFecha
        End Get
        Set(ByVal value As Date)
            _varFecha = value
        End Set
    End Property

    Private _varIdProveedor As Integer
    Public Property IdProveedor() As Integer
        Get
            Return _varIdProveedor
        End Get
        Set(ByVal value As Integer)
            _varIdProveedor = value
        End Set
    End Property

    Private _varNombreProveedor As String
    Public Property NombreProveedor() As String
        Get
            Return _varNombreProveedor
        End Get
        Set(ByVal value As String)
            _varNombreProveedor = value
        End Set
    End Property

    Private _varModificado As Boolean
    Public Property Modificado() As Boolean
        Get
            Return _varModificado
        End Get
        Set(ByVal value As Boolean)
            _varModificado = value
        End Set
    End Property

    Private _varTransporte As String
    Public Property Transporte() As String
        Get
            Return _varTransporte
        End Get
        Set(ByVal value As String)
            _varTransporte = value
        End Set
    End Property

    Private _varPedidoDetalle As List(Of PedidoDetalle)
    Public Property PedidoDetalle() As List(Of PedidoDetalle)
        Get
            Return _varPedidoDetalle
        End Get
        Set(ByVal value As List(Of PedidoDetalle))
            _varPedidoDetalle = value
        End Set
    End Property

    Private _varImprimeDTOModel As List(Of ImprimeDTOModel)
    Public Property ImprimeDTOModel() As List(Of ImprimeDTOModel)
        Get
            Return _varImprimeDTOModel
        End Get
        Set(ByVal value As List(Of ImprimeDTOModel))
            _varImprimeDTOModel = value
        End Set
    End Property
End Class

Public Class ImprimeDTOModel
    Private _codigo As Integer
    Public Property Codigo() As Integer
        Get
            Return _codigo
        End Get
        Set(ByVal value As Integer)
            _codigo = value
        End Set
    End Property
    Private _descripcion As String
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property
    Private _exist As Double
    Public Property Exist() As Double
        Get
            Return _exist
        End Get
        Set(ByVal value As Double)
            _exist = value
        End Set
    End Property
    Private _pedir As Double
    Public Property Pedir() As Double
        Get
            Return _pedir
        End Get
        Set(ByVal value As Double)
            _pedir = value
        End Set
    End Property
End Class
