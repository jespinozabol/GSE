Imports Acceso_Datos
Imports Entidades
Public Class LogicaProforma
    Private ReadOnly _oAccesoProforma As New AccesoProforma
    Private ReadOnly _oAccesoConsecutivo As New AccesoConsecutivo

    Function ConsultarPorNombre(ByVal nombre As String) As List(Of Proforma)
        Return _oAccesoProforma.Consultar(nombre)
    End Function

    Function ConsultarPorId(ByVal numProforma As Integer) As Proforma
        Return _oAccesoProforma.Consultar(numProforma)
    End Function

    Function consultarPorId_ConInfo(ByVal numProforma As Integer) As Proforma
        Return _oAccesoProforma.Consultar(numProforma)
    End Function

    Function ConsultarProformaImprimir(ByVal numProforma As Integer) As DataTable
        Return _oAccesoProforma.ConsultarDetallesImprimir(numProforma)
    End Function

    Sub Insertar(ByVal proforma As Proforma)
        _oAccesoProforma.Insertar(proforma)
    End Sub

    Sub Modificar(ByVal proforma As Proforma)
        _oAccesoProforma.Modificar(proforma)
    End Sub

    Public Sub RevisaBloqueo()
        Dim siga As Boolean = True
        While siga
            siga = _oAccesoConsecutivo.ConsultarBloqueo("CONSECUTIVO_PROFORMA")
        End While
    End Sub

    Public Sub Bloqueo(ByVal valor As Boolean)
        Dim oConsecutivo As New Consecutivo

        oConsecutivo.Tabla = "CONSECUTIVO_PROFORMA"
        oConsecutivo.Bloqueo = Valor

        _oAccesoConsecutivo.Modificar_Bloqueo(oConsecutivo)
    End Sub

End Class
