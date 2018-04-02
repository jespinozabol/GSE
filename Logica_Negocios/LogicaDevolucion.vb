Imports Acceso_Datos
Imports Entidades

Public Class LogicaDevolucion

    Private ReadOnly _oAccesoDevolucion As New AccesoDevolucion

    Public Sub Insertar(ByVal oDevolucion As Devolucion)
        _oAccesoDevolucion.Insertar(oDevolucion)
    End Sub

    Public Sub Modificar(ByVal oDevolucion As Devolucion)
        _oAccesoDevolucion.Modificar(oDevolucion)
    End Sub

    Public Sub Eliminar(ByVal idDevolucion As Integer)
        _oAccesoDevolucion.Eliminar(idDevolucion)
    End Sub

    Public Function ConsultarPorIdProveedor()
        Return _oAccesoDevolucion.Consultar()
    End Function

    '************************************PAQUETES*********************************************
    Public Sub InsertarPaquete(ByVal paquete As Paquete)
        _oAccesoDevolucion.InsertarPaquete(paquete)
    End Sub

    Public Sub ModificarPaquete(ByVal paquete As Paquete)
        _oAccesoDevolucion.ModificarPaquete(paquete)
    End Sub

    Public Sub EliminarPaquete(ByVal idPaquete As Integer)
        _oAccesoDevolucion.EliminarPaquete(idPaquete)
    End Sub

    Public Function ConsultarPaquetes()
        Return _oAccesoDevolucion.ConsultarPaquetes()
    End Function

    '************************************DEVOLUCION POR PAQUETES*********************************************
    Public Sub InsertarDevPorPaq(ByVal devPorPaq As DevolucionPorPaquete)
        _oAccesoDevolucion.InsertarDevPorPaq(devPorPaq)
    End Sub

    Public Sub ModificarDevPorPaq(ByVal devPorPaq As DevolucionPorPaquete)
        _oAccesoDevolucion.ModificarDevPorPaq(devPorPaq)
    End Sub

    Public Sub EliminarDevPorPaq(ByVal idDevolucion As Integer)
        _oAccesoDevolucion.EliminarDevPorPaq(idDevolucion)
    End Sub

    Public Function ConsultarDevPorPaq()
        Return _oAccesoDevolucion.ConsultarDevPorPaq()
    End Function
End Class
