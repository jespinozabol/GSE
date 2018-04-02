'Contiene: Id_Producto, Id_Proveedor, Prioridad, Nombre_Proveedor
Public Class ProductoPorProveedor

    'Variable extraída de la tabla PRODUCTO y que guarda el producto que será relacionado con el proveedor
    Private _varIdProducto As Integer
    Public Property Id_Producto() As Integer
        Get
            Return _varIdProducto
        End Get
        Set(ByVal value As Integer)
            _varIdProducto = value
        End Set
    End Property

    'Variable extraída de la tabla PROVEEDOR y que guarda el proveedor que será relacionado con el producto
    Private _varIdProveedor As UShort
    Public Property IdProveedor() As UShort
        Get
            Return _varIdProveedor
        End Get
        Set(ByVal value As UShort)
            _varIdProveedor = value
        End Set
    End Property

    'La prioridad del proveedor, se asignará acorde se inserten.
    Private _varPrioridad As Byte
    Public Property Prioridad() As Byte
        Get
            Return _varPrioridad
        End Get
        Set(ByVal value As Byte)
            _varPrioridad = value
        End Set
    End Property

    'El nombre del proveedor, se sacara de la tabla proveedor.
    Private _varNombreProveedor As String
    Public Property NombreProveedor() As String
        Get
            Return _varNombreProveedor
        End Get
        Set(ByVal value As String)
            _varNombreProveedor = value
        End Set
    End Property
End Class