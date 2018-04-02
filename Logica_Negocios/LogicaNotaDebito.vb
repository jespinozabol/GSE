Imports Entidades
Imports Acceso_Datos
Public Class LogicaNotaDebito

    Private ReadOnly _oAccesoNotaDebito As New AccesoNotaDebito
    Private ReadOnly _oAccesoConsecutivo As New AccesoConsecutivo

    Public Sub RevisaBloqueo()
        Dim siga As Boolean = True
        While siga
            siga = _oAccesoConsecutivo.ConsultarBloqueo("CONSECUTIVO_ND")
        End While
    End Sub

    Public Sub Bloqueo(ByVal valor As Boolean)
        Dim oConsecutivo As New Consecutivo

        oConsecutivo.Tabla = "CONSECUTIVO_ND"
        oConsecutivo.Bloqueo = valor

        _oAccesoConsecutivo.Modificar_Bloqueo(oConsecutivo)
    End Sub

    Sub insertar_General(ByVal oNotaCredito As NotaDebitoGeneral)
        _oAccesoNotaDebito.Insertar_NDG(oNotaCredito)
    End Sub

    Function ConsultarGeneral(ByVal idClienteCredito As Integer) As List(Of NotaDebitoGeneral)
        Return _oAccesoNotaDebito.ConsultarNDG_Pendientes(idClienteCredito)
    End Function

    Public Function ND_Generales_Pendientes(ByVal idClienteCredito As Integer) As Integer
        Return _oAccesoNotaDebito.ConsultarNumNDG_Pendientes(idClienteCredito)
    End Function

    Function ConsultarMotivo(ByVal idNd As Integer) As String
        Return _oAccesoNotaDebito.ConsultarMotivoNDG(idNd)
    End Function

    Sub actualizarGeneralEstado_IdND(ByVal oNotaDebito As NotaDebitoGeneral)
        _oAccesoNotaDebito.ModificarEstadoNDGPor_IdND(oNotaDebito.IdND, oNotaDebito.Estado)
    End Sub

    Sub actualizarGeneralEstado_IdClienteCredito(ByVal oNotaDebito As NotaDebitoGeneral)
        _oAccesoNotaDebito.ModificarEstadoNCGPor_IdClienteCredito(oNotaDebito.IdClienteCredito, oNotaDebito.Estado)
    End Sub

    Function consultarNota_DebitoGeneral(ByVal idNd As Integer) As NotaDebitoGeneral
        Return _oAccesoNotaDebito.ConsultarNDG(idNd)
    End Function

    Function ConsultarTodasGeneralesInfo() As DataTable
        Return _oAccesoNotaDebito.ConsultarTodasNDG
    End Function

    Function ConsultarPorIdPersonaGenerales(ByVal idPersona As Integer) As DataTable
        Return _oAccesoNotaDebito.ConsultarPor_IdPersonaNDG(idPersona)
    End Function

    Function ConsultarPorNumNotaDebitoGenerales(ByVal numDoc As Integer) As DataTable
        Return _oAccesoNotaDebito.ConsultarPor_IdNDG(numDoc)
    End Function

End Class
