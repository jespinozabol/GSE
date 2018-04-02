Public Class ResumenPedido

    Private _proveedor As String
    Public Property Proveedor() As String
        Get
            Return _proveedor
        End Get
        Set(ByVal value As String)
            _proveedor = value
        End Set
    End Property

    Private _imprime As Boolean
    Public Property Imprime() As Boolean
        Get
            Return _imprime
        End Get
        Set(ByVal value As Boolean)
            _imprime = value
        End Set
    End Property

    Private _enviarEmail As Boolean
    Public Property EnviarEmail() As Boolean
        Get
            Return _enviarEmail
        End Get
        Set(ByVal value As Boolean)
            _enviarEmail = value
        End Set
    End Property

    Private _pedir As Boolean
    Public Property Pedir() As Boolean
        Get
            Return _pedir
        End Get
        Set(ByVal value As Boolean)
            _pedir = value
        End Set
    End Property

    Private _email As List(Of String)
    Public Property Email() As List(Of String)
        Get
            Return _email
        End Get
        Set(ByVal value As List(Of String))
            _email = value
        End Set
    End Property

    Private _transporte As String
    Public Property Transporte() As String
        Get
            Return _transporte
        End Get
        Set(ByVal value As String)
            _transporte = value
        End Set
    End Property
End Class
