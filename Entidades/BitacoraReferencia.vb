'Continene: Id_Referencia, Linea1, Linea2
Public Class BitacoraReferencia

    'Variable extraída de la tabla REFERENCIA y que específica a cual referencia pertenece la bitacora.
    Private _varIdReferencia As Integer
    Public Property IdReferencia() As Integer
        Get
            Return _varIdReferencia
        End Get
        Set(ByVal value As Integer)
            _varIdReferencia = value
        End Set
    End Property

    'Primera linea de la descripción de la bitacora.
    Private _varLinea1 As String
    Public Property Linea1() As String
        Get
            Return _varLinea1
        End Get
        Set(ByVal value As String)
            _varLinea1 = value
        End Set
    End Property

    'Segunda linea de la descripción de la bitacora.
    Private _varLinea2 As String
    Public Property Linea2() As String
        Get
            Return _varLinea2
        End Get
        Set(ByVal value As String)
            _varLinea2 = value
        End Set
    End Property
End Class
