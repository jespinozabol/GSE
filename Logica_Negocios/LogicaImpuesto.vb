Imports Acceso_Datos
Public Class LogicaImpuesto
    Private ReadOnly _oAccesoImpuesto As New AccesoImpuesto

    Sub Modificar(ByVal impuesto As Double)
        _oAccesoImpuesto.Modificar(impuesto)
    End Sub

    Function ConsultarImpuesto() As Double
        Return _oAccesoImpuesto.Consultar
    End Function
End Class
