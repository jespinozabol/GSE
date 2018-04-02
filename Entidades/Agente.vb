'Conformado por Id_Agente, Id_Proveedor, Nombre, Telefono1, Telefono2, Fax.
Public Class Agente

    'Variable autoincrementable que lleva el número de abonos realizados e identifica de forma única a cada agente.
    Private _varIdAgente As Short
    Public Property IdAgente() As Short
        Get
            Return _varIdAgente
        End Get
        Set(ByVal value As Short)
            _varIdAgente = value
        End Set
    End Property

    'Variable extraída de la tabla PROVEEDOR y que específica a cual proveedor representa el agente.
    Private _varIdProveedor As Short
    Public Property IdProveedor() As Short
        Get
            Return _varIdProveedor
        End Get
        Set(ByVal value As Short)
            _varIdProveedor = value
        End Set
    End Property

    'Nombre completo del agente.
    Private _varNombre As String
    Public Property Nombre() As String
        Get
            Return _varNombre
        End Get
        Set(ByVal value As String)
            _varNombre = value
        End Set
    End Property

    'Teléfono donde se localizará al agente, que puede ser el celular o el de la casa.
    Private _varTelefono1 As String
    Public Property Telefono1() As String
        Get
            Return _varTelefono1
        End Get
        Set(ByVal value As String)
            _varTelefono1 = value
        End Set
    End Property

    'Un teléfono secundario, para mayor facilidad de localización.
    Private _varTelefono2 As String
    Public Property Telefono2() As String
        Get
            Return _varTelefono2
        End Get
        Set(ByVal value As String)
            _varTelefono2 = value
        End Set
    End Property

    'El Fax del agente.
    Private _varFax As String
    Public Property Fax() As String
        Get
            Return _varFax
        End Get
        Set(ByVal value As String)
            _varFax = value
        End Set
    End Property

    'El correo del agente.
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
