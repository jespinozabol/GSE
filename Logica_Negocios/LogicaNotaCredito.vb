Imports Entidades
Imports Acceso_Datos
Public Class LogicaNotaCredito

    Private ReadOnly _oAccesoNotaCredito As New AccesoNotaCredito
    Private ReadOnly _oAccesoConsecutivo As New AccesoConsecutivo

    Public Sub RevisaBloqueo()
        Dim siga As Boolean = True
        While siga
            siga = _oAccesoConsecutivo.ConsultarBloqueo("CONSECUTIVO_NC")
        End While
    End Sub

    Public Sub Bloqueo(ByVal valor As Boolean)
        Dim oConsecutivo As New Consecutivo

        oConsecutivo.Tabla = "CONSECUTIVO_NC"
        oConsecutivo.Bloqueo = Valor

        _oAccesoConsecutivo.Modificar_Bloqueo(oConsecutivo)
    End Sub

    Sub Insertar(ByVal oNotaCredito As NotaCredito)
        _oAccesoNotaCredito.Insertar(oNotaCredito)
    End Sub

    Sub insertar_General(ByVal oNotaCredito As NotaCreditoGeneral)
        _oAccesoNotaCredito.Insertar_NCG(oNotaCredito)
    End Sub

    Function consultarPorNum_FacturaSinAplicar(ByVal numFactura As Long) As List(Of NotaCredito)
        Return _oAccesoNotaCredito.ConsultarSinAplicarPor_NumFactura(numFactura)
    End Function

    Function consultarTodasPorNum_Factura(ByVal numFactura As Long) As List(Of NotaCredito)
        Return _oAccesoNotaCredito.ConsultarTodasPor_NumFactura(numFactura)
    End Function

    Function ConsultarGeneral(ByVal idClienteCredito As Integer) As List(Of NotaCreditoGeneral)
        Return _oAccesoNotaCredito.ConsultarNCG_Pendientes(idClienteCredito)
    End Function

    Function ConsultarMotivo(ByVal idNc As Integer) As String
        Return _oAccesoNotaCredito.ConsultarMotivoNCG(idNc)
    End Function

    Sub actualizarNCEstado_IdNC(ByVal oNotaCredito As NotaCredito)
        _oAccesoNotaCredito.ModificarEstadoNCPor_IdNC(oNotaCredito.IdNC, oNotaCredito.Estado)
    End Sub

    Sub actualizarNCEstado_NumFactura(ByVal oNotaCredito As NotaCredito)
        _oAccesoNotaCredito.ModificarEstadoNCPor_NumFactura(oNotaCredito.NumFactura, oNotaCredito.Estado)
    End Sub

    Sub actualizarGeneralEstado_IdNC(ByVal oNotaCredito As NotaCreditoGeneral)
        _oAccesoNotaCredito.ModificarEstadoNCGPor_IdNC(oNotaCredito.IdNC, oNotaCredito.Estado)
    End Sub

    Sub actualizarGeneralEstado_IdClienteCredito(ByVal oNotaCredito As NotaCreditoGeneral)
        _oAccesoNotaCredito.ModificarEstadoNCGPor_IdClienteCredito(oNotaCredito.IdClienteCredito, oNotaCredito.Estado)
    End Sub

    Function Consultar(ByVal idNc As Integer) As NotaCredito
        Return _oAccesoNotaCredito.Consultar(idNc)
    End Function

    Function consultarNota_CreditoGeneral(ByVal idNc As Integer) As NotaCreditoGeneral
        Return _oAccesoNotaCredito.ConsultarNCG(idNc)
    End Function

    Public Function NC_Generales_Pendientes(ByVal idClienteCredito As Integer) As Integer
        Return _oAccesoNotaCredito.ConsultarNumNCG_Pendientes(idClienteCredito)
    End Function

    Function ConsultarTodasInfo() As DataTable
        Return _oAccesoNotaCredito.ConsultarTodas
    End Function

    Function ConsultarTodasGeneralesInfo() As DataTable
        Return _oAccesoNotaCredito.ConsultarTodasNCG
    End Function

    Function ConsultarPorIdPersona(ByVal idPersona As Integer) As DataTable
        Return _oAccesoNotaCredito.ConsultarPor_IdPersona(idPersona)
    End Function

    Function ConsultarPorIdPersonaGenerales(ByVal idPersona As Integer) As DataTable
        Return _oAccesoNotaCredito.ConsultarPor_IdPersonaNCG(idPersona)
    End Function

    Function ConsultarPorNumNotaCredito(ByVal numDoc As Integer) As DataTable
        Return _oAccesoNotaCredito.ConsultarPor_IdNC(numDoc)
    End Function

    Function ConsultarPorNumNotaCreditoGenerales(ByVal numDoc As Integer) As DataTable
        Return _oAccesoNotaCredito.ConsultarPor_IdNCG(numDoc)
    End Function

    Function ConsultarPorNumFactura(ByVal numFactura As Long) As DataTable
        Return _oAccesoNotaCredito.ConsultarPor_NumFactura(numFactura)
    End Function
End Class
