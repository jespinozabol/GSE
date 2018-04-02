'Continene: Id_Encargado, Id_Proveedor, Nombre, Servicio, Telefono1, Telefono2, Ext1, Ext2, Fax, Correo.
Public Class Encargado

    'Identificador único autoincrementable para cada encargado que se crea.
    Private _varIdEncargado As Short
    Public Property IdEncargado() As Short
        Get
            Return _varIdEncargado
        End Get
        Set(ByVal value As Short)
            _varIdEncargado = value
        End Set
    End Property

    'Variable extraída de la tabla PROVEEDOR y que específica a cual proveedor representa el encargado.
    Private _varIdProveedor As Short
    Public Property IdProveedor() As Short
        Get
            Return _varIdProveedor
        End Get
        Set(ByVal value As Short)
            _varIdProveedor = value
        End Set
    End Property

    'Nombre completo del encargado.
    Private _varNombre As String
    Public Property Nombre() As String
        Get
            Return _varNombre
        End Get
        Set(ByVal value As String)
            _varNombre = value
        End Set
    End Property

    'Guardara la función del encargado, descripción breve de en que nos puede ayudar.
    Private _varServicio As String
    Public Property Servicio() As String
        Get
            Return _varServicio
        End Get
        Set(ByVal value As String)
            _varServicio = value
        End Set
    End Property

    'Un teléfono donde se pueda localizar.
    Private _varTelefono1 As String
    Public Property Telefono1() As String
        Get
            Return _varTelefono1
        End Get
        Set(ByVal value As String)
            _varTelefono1 = value
        End Set
    End Property

    'Un teléfono secundario que mejore o facilite una mejor localización.
    Private _varTelefono2 As String
    Public Property Telefono2() As String
        Get
            Return _varTelefono2
        End Get
        Set(ByVal value As String)
            _varTelefono2 = value
        End Set
    End Property

    'En el caso de tener asignada una extensión telefónica, se almacenara.
    Private _varExt1 As String
    Public Property Ext1() As String
        Get
            Return _varExt1
        End Get
        Set(ByVal value As String)
            _varExt1 = value
        End Set
    End Property

    'Guarda otra extensión si fuese el caso de que hubiera más de una.
    Private _varExt2 As String
    Public Property Ext2() As String
        Get
            Return _varExt2
        End Get
        Set(ByVal value As String)
            _varExt2 = value
        End Set
    End Property

    'Número donde se le puedan enviar fax a este encargado.
    Private _varFax As String
    Public Property Fax() As String
        Get
            Return _varFax
        End Get
        Set(ByVal value As String)
            _varFax = value
        End Set
    End Property

    'Correo electrónico en donde se pueda localizar directamente.
    Private _varCorreo As String
    Public Property Correo() As String
        Get
            Return _varCorreo
        End Get
        Set(ByVal value As String)
            _varCorreo = value
        End Set
    End Property
End Class