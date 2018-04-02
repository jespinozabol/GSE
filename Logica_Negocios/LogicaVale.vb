Imports Entidades
Imports Acceso_Datos
Public Class LogicaVale

    Private ReadOnly _oAccesoVale As New AccesoVale

    Public Sub Insertar(ByVal oVale As Vale)
        _oAccesoVale.Insertar(oVale)
    End Sub

    Public Sub Eliminar(ByVal numVale As Integer)
        _oAccesoVale.Eliminar(numVale)
    End Sub

    Function ConsultarTodos() As List(Of Vale)
        Return _oAccesoVale.Consultar()
    End Function

    Function ConsultarNumVale(ByVal numVale As Integer) As Vale
        Return _oAccesoVale.Consultar(numVale)
    End Function

    Function ConsultarTodosInfo() As DataTable
        Return _oAccesoVale.ConsultarTodosInfo()
    End Function

    Function ConsultarPorIdPersona(ByVal idPersona As Integer) As DataTable
        Return _oAccesoVale.ConsultarPor_IdPersonaInfo(idPersona)
    End Function

    Function ConsultarPorNumVale(ByVal numDoc As Integer) As DataTable
        Return _oAccesoVale.ConsultarPor_NumValeInfo(numDoc)
    End Function

End Class
