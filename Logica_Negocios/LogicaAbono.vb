Imports Entidades
Imports Acceso_Datos
Imports Entidades.Abono

Public Class LogicaAbono

    Private ReadOnly _oAccesoAbono As New AccesoAbono
    Private ReadOnly _oAccesoConsecutivo As New AccesoConsecutivo

    Public Sub RevisaBloqueo()
        Dim siga As Boolean = True
        While siga
            siga = _oAccesoConsecutivo.ConsultarBloqueo("CONSECUTIVO_ABONO")
        End While
    End Sub

    Public Sub Bloqueo(ByVal valor As Boolean)
        Dim oConsecutivo As New Consecutivo

        oConsecutivo.Tabla = "CONSECUTIVO_ABONO"
        oConsecutivo.Bloqueo = valor

        _oAccesoConsecutivo.Modificar_Bloqueo(oConsecutivo)
    End Sub

    Public Sub RevisaBloqueoFactura()
        Dim siga As Boolean = True
        While siga
            siga = _oAccesoConsecutivo.ConsultarBloqueo("CONSECUTIVO_RECIBO_FACT")
        End While
    End Sub

    Public Sub BloqueoRecibo_Facturas(ByVal valor As Boolean)
        Dim oConsecutivo As New Consecutivo

        oConsecutivo.Tabla = "CONSECUTIVO_RECIBO_FACT"
        oConsecutivo.Bloqueo = valor

        _oAccesoConsecutivo.Modificar_Bloqueo(oConsecutivo)
    End Sub

    Sub Insertar(ByVal oAbono As Abono)
        _oAccesoAbono.Insertar(oAbono)
    End Sub

    Function consultarPendientesPorNumDocYTipo(ByVal numDoc As Long, ByVal tipo As ListaTipoDoc) As List(Of Abono)
        Return _oAccesoAbono.ConsultarPendientesPorNumDocYTipo(numDoc, tipo)
    End Function

    Function consultarPorId_Abono(ByVal idAbono As Integer) As Abono
        Return _oAccesoAbono.ConsultarPor_IdAbono(idAbono)
    End Function

    Sub actualizarEstado_IdAbono(ByVal oAbono As Abono)
        _oAccesoAbono.ModificarEstadoPor_IdAbono(oAbono)
    End Sub

    Sub actualizarEstadoPorNumDocYTipo(ByVal oAbono As Abono)
        _oAccesoAbono.ModificarEstadoPorNumDocYTipo(oAbono)
    End Sub
End Class
