Imports Entidades
Imports Acceso_Datos
Public Class LogicaTipoCredito

    Private ReadOnly _oAccesoTipoCredito As New AccesoTipoCredito

    Public Sub Modificar(ByVal tipo As Tipo_Credito)
        _oAccesoTipoCredito.Modificar(tipo)
    End Sub

    Function ConsultarDato(ByVal tipo As String) As Tipo_Credito
        Return _oAccesoTipoCredito.Consultar(tipo)
    End Function

    Function ConsultarTodos() As List(Of Tipo_Credito)
        Return _oAccesoTipoCredito.Consultar()
    End Function

End Class
