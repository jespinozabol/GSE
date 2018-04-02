Imports Entidades
Imports Acceso_Datos
Public Class LogicaConsecutivo
    Private ReadOnly _oAccesoConsecutivo As New AccesoConsecutivo

    Function ConsultarMaxConsecutivo(ByVal tabla As String) As Long
        Return _oAccesoConsecutivo.ConsultarMaxConsecutivo(tabla)
    End Function

    Sub AumentarConsecutivo(ByVal consecutivo As Consecutivo)
        _oAccesoConsecutivo.Aumentar_Consecutivo(consecutivo)
    End Sub

    Sub ModificarConsecutivo(ByVal consecutivo As Consecutivo)
        _oAccesoConsecutivo.Modificar(consecutivo)
    End Sub

    Sub Modificar_Bloqueo(ByVal consecutivo As Consecutivo)
        _oAccesoConsecutivo.Modificar_Bloqueo(consecutivo)
    End Sub

    Function ConsultarConsecutivo(ByVal tabla As String) As Consecutivo
        Return _oAccesoConsecutivo.Consultar(tabla)
    End Function
End Class
