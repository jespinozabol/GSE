Public Class DevolucionPorPaquete

    Private varIdDevolucion As Integer
    Public Property IdDevolucion() As Integer
        Get
            Return varIdDevolucion
        End Get
        Set(ByVal value As Integer)
            varIdDevolucion = value
        End Set
    End Property


    Private varIdPaquete As Integer
    Public Property IdPaquete() As Integer
        Get
            Return varIdPaquete
        End Get
        Set(ByVal value As Integer)
            varIdPaquete = value
        End Set
    End Property

End Class
