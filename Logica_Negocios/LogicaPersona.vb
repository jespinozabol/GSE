Imports Acceso_Datos
Imports Entidades
Public Class LogicaPersona
    Private ReadOnly _oAccesoPersona As New AccesoPersona
    Private ReadOnly _oAccesoInformacionPersonal As New AccesoInformacionPersonal
    Private ReadOnly _oAccesoReferencia As New AccesoReferencia

    Public Function ConsultarPorNombre(ByVal nombre As String) As DataTable
        Return _oAccesoPersona.ConsultarPor_NombreConcatenado(nombre)
    End Function

    Public Function Consultar(ByVal idPersona As Integer) As Persona
        Return _oAccesoPersona.Consultar(idPersona)
    End Function

    Public Sub Modificar(ByVal oPersona As Persona)
        _oAccesoPersona.Modificar(oPersona)
    End Sub

    Public Sub ModificarOtraInfo(ByVal informacionPersonal As InformacionPersonal)
        _oAccesoInformacionPersonal.Modificar(informacionPersonal)
    End Sub

    Public Function ConsultarTodos() As DataTable
        Return _oAccesoPersona.ConsultarTodosNombreConcatenado
    End Function

    Public Function ConsultarTelefonos(ByVal idPersona As Integer) As List(Of Telefonos_Cliente)
        Return _oAccesoInformacionPersonal.ConsultarTelefonos(idPersona)
    End Function

    Public Sub eliminarInformacion_Personal(ByVal idPersona As Integer)
        Dim oReferencia = _oAccesoReferencia.ConsultarPor_IdPersona(idPersona)
        If oReferencia.IdReferencia = 0 Then
            _oAccesoInformacionPersonal.Eliminar(idPersona)
            _oAccesoInformacionPersonal.EliminarTelefonos(idPersona)
        End If
    End Sub

    Public Sub Eliminar(ByVal idCliente As Integer)
        _oAccesoPersona.Eliminar(idCliente)
    End Sub

End Class
