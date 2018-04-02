Imports Acceso_Datos
Public Class LogicaMoneda

    Private ReadOnly _oAccesoMoneda As New AccesoMonedaMinima

    Sub Modificar(ByVal moneda As Integer)
        _oAccesoMoneda.Modificar(moneda)
    End Sub

    Function ConsultarMoneda() As Integer
        Return _oAccesoMoneda.ConsultarMoneda
    End Function
End Class
