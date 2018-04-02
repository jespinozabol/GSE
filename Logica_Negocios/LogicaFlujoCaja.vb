Imports Acceso_Datos
Imports Entidades
Public Class LogicaFlujoCaja

    Private ReadOnly _oAccesoFlujoCaja As New AccesoFlujoCaja
    Private ReadOnly _oAccesoFlujoCaja2 As New AccesoFlujoCaja2

    Sub Modificar(ByVal oFLujo As FlujoCaja)
        _oAccesoFlujoCaja.Modificar(oFLujo)
    End Sub

    Sub Insertar(ByVal oFLujo As FlujoCaja)
        _oAccesoFlujoCaja.Insertar(oFLujo)
    End Sub

    Function ConsultarFlujo(ByVal fecha As Date) As FlujoCaja
        Return _oAccesoFlujoCaja.ConsultarPor_Fecha(fecha)
    End Function

    Function ConsultarNuevo(ByVal fecha As Date) As Boolean
        Return _oAccesoFlujoCaja.ConsultarNueva(fecha)
    End Function

    Sub modificar_Otro(ByVal oFLujo As FlujoCaja)
        _oAccesoFlujoCaja2.Modificar(oFLujo)
    End Sub

    Sub insertar_Otro(ByVal oFLujo As FlujoCaja)
        _oAccesoFlujoCaja2.Insertar(oFLujo)
    End Sub

    Function consultarFlujo_Otro(ByVal fecha As Date) As FlujoCaja
        Return _oAccesoFlujoCaja2.ConsultarPor_Fecha(fecha)
    End Function

    Function consultarNuevo_Otro(ByVal fecha As Date) As Boolean
        Return _oAccesoFlujoCaja2.ConsultarNueva(fecha)
    End Function

    Sub EliminarViejos(ByVal fecha As Date)
        _oAccesoFlujoCaja.Eliminar(fecha)
        _oAccesoFlujoCaja2.Eliminar(fecha)
    End Sub
End Class
