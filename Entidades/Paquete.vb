Public Class Paquete


    Private varIdPaqute As Integer
    Public Property IdPaquete() As Integer
        Get
            Return varIdPaqute
        End Get
        Set(ByVal value As Integer)
            varIdPaqute = value
        End Set
    End Property


    Private varIdProveedor As Integer
    Public Property IdProveedor() As Integer
        Get
            Return varIdProveedor
        End Get
        Set(ByVal value As Integer)
            varIdProveedor = value
        End Set
    End Property

    Private varNombreProveedor As String
    Public Property NombreProveedor() As String
        Get
            Return varNombreProveedor
        End Get
        Set(ByVal value As String)
            varNombreProveedor = value
        End Set
    End Property

End Class
