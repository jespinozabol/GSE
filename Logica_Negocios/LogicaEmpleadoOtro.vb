Imports Acceso_Datos
Imports Entidades
Public Class LogicaEmpleadoOtro

    Private ReadOnly _oAccesoEmpleadoOtro As New AccesoEmpleadoOtro
    Private ReadOnly _oAccesoPersona As New AccesoPersona
    Private ReadOnly _oAccesoInformacionPersonal As New AccesoInformacionPersonal

    Public Sub Insertar(ByVal oEmpleadoOtro As EmpleadoOtro)
        If oEmpleadoOtro.IdPersona = 0 Then
            Dim oPersona As New Persona
            oPersona.Cedula = oEmpleadoOtro.Cedula
            oPersona.Nombre = oEmpleadoOtro.Nombre
            oPersona.PrimerApellido = oEmpleadoOtro.PrimerApellido
            oPersona.SegundoApellido = oEmpleadoOtro.SegundoApellido

            Dim idPersona = _oAccesoPersona.Insertar(oPersona)
            oEmpleadoOtro.IdPersona = idPersona
            _oAccesoEmpleadoOtro.Insertar(oEmpleadoOtro)

            oEmpleadoOtro.OtraInformacion.IdPersona = idPersona
            _oAccesoInformacionPersonal.Insertar(oEmpleadoOtro.OtraInformacion)
        ElseIf oEmpleadoOtro.IdEmpleado = 0 Then
            _oAccesoEmpleadoOtro.Insertar(oEmpleadoOtro)
            _oAccesoInformacionPersonal.Insertar(oEmpleadoOtro.OtraInformacion)
        Else
            _oAccesoEmpleadoOtro.Modificar(oEmpleadoOtro)
            _oAccesoInformacionPersonal.Modificar(oEmpleadoOtro.OtraInformacion)
        End If
    End Sub


    Public Function ConsultarPorIdPersona(ByVal idPersona As Integer) As EmpleadoOtro
        Dim oEmpleado = _oAccesoEmpleadoOtro.ConsultarPor_IdPersona(idPersona)

        If oEmpleado.IdPersona <> 0 Then
            oEmpleado.OtraInformacion = _oAccesoInformacionPersonal.Consultar(oEmpleado.IdPersona)
        End If

        Return oEmpleado
    End Function


    Public Function ConsultarPorIdEmpleado(ByVal idEmpleado As Integer) As EmpleadoOtro
        Dim oEmpleado = _oAccesoEmpleadoOtro.ConsultarPor_IdEmpleado(idEmpleado)

        If oEmpleado.IdEmpleado <> 0 Then
            Dim persona = _oAccesoPersona.Consultar(oEmpleado.IdPersona)
            oEmpleado.Nombre = persona.Nombre
            oEmpleado.PrimerApellido = persona.PrimerApellido
            oEmpleado.SegundoApellido = persona.SegundoApellido
            oEmpleado.OtraInformacion = _oAccesoInformacionPersonal.Consultar(oEmpleado.IdPersona)
        End If

        Return oEmpleado
    End Function

    Public Function ConsultarTodos() As List(Of EmpleadoOtro)
        Return _oAccesoEmpleadoOtro.Consultar()
    End Function

    Sub TrasladarEmpleado(ByVal idActual As Integer, ByVal idTrasladar As Integer)
        _oAccesoEmpleadoOtro.TrasladarEmpleado(idActual, idTrasladar)
    End Sub

End Class
