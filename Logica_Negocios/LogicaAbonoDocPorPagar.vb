Imports Entidades
Imports Acceso_Datos
Public Class LogicaAbonoDocPorPagar

    Private ReadOnly _oAccesoAbonoDocPorPagar As New AccesoAbonoFacturaProveedor

    Public Function Insertar(ByVal oAbono As AbonoFacturaProveedor) As Integer
        Return _oAccesoAbonoDocPorPagar.Insertar(oAbono)
    End Function

    Public Function consultarAbono_IDDocPagar(ByVal idDocPorPagar As Integer) As List(Of AbonoFacturaProveedor)
        Return _oAccesoAbonoDocPorPagar.ConsultarPor_IdFacturaProveedor(idDocPorPagar)
    End Function

    Public Function ConsultarAbonoPorId(ByVal idAbono As Integer) As AbonoFacturaProveedor
        Return _oAccesoAbonoDocPorPagar.ConsultarAbonoPorId(idAbono)
    End Function
End Class
