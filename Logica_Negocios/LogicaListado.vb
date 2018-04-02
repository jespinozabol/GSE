Imports Entidades
Imports Acceso_Datos
Public Class LogicaListado
    Private ReadOnly _oAccesoListado As New AccesoListado

    Function ConsultarPorNombre(ByVal nombre As String) As List(Of Listado)
        Return _oAccesoListado.Consultar(nombre)
    End Function

    Function ConsultarPorIdConInfo(ByVal idListado As Integer) As Listado
        Return _oAccesoListado.Consultar(idListado)
    End Function

    Sub Insertar(ByVal oListado As Listado)
        _oAccesoListado.Insertar(oListado)
    End Sub

    Sub Modificar(ByVal oListado As Listado)
        _oAccesoListado.Modificar(oListado)
    End Sub

    Sub Eliminar(ByVal idListado As Integer)
        _oAccesoListado.Eliminar(idListado)
    End Sub

    Sub inactivar_Autorizado(ByVal idAutorizado As Integer)
        _oAccesoListado.Inactivar_Autorizado(idAutorizado)
    End Sub

    Function ConsultarHistorial(ByVal idListado As Integer, ByVal idProducto As Integer) As List(Of ListadoHistorial)
        Return _oAccesoListado.Consultar_Historial(idListado, idProducto)
    End Function

    Function ConsultarHistorial(ByVal idListado As Integer) As List(Of ListadoHistorial)
        Return _oAccesoListado.Consultar_Historial(idListado)
    End Function

    Function ConsultarAutorizado(ByVal idAutorizado As Integer) As ListadoAutorizado
        Return _oAccesoListado.Consultar_Autorizado(idAutorizado)
    End Function

    Function ConsultarAutorizados(ByVal idListado As Integer, ByVal activo As Boolean) As List(Of ListadoAutorizado)
        Return _oAccesoListado.Consultar_Autorizados(idListado, activo)
    End Function

    Function ConsultarTodos() As DataTable
        Return _oAccesoListado.ConsultarTodosSinFacturar()
    End Function

    Function ConsultarTodosFacturados() As DataTable
        Return _oAccesoListado.ConsultarTodosFacturados()
    End Function

    Function ConsultarFacturadosEliminar(ByVal fecha As Date) As List(Of Listado)
        Return _oAccesoListado.ConsultarFacturados(fecha)
    End Function

    Sub ActualizarEstado(ByVal idListado As Integer)
        _oAccesoListado.ActualizaAImpreso(idListado)
    End Sub

    Function ConsultarListadoImprimir(ByVal idListado As Integer) As DataTable
        Return _oAccesoListado.ConsultarListadoImprimir(idListado)
    End Function

    Function ConsultarExistenciasPorProducto(ByVal idListado As Long) As Double
        Return _oAccesoListado.ConsultarExistenciasPor_IdProducto(idListado)
    End Function

    Sub ModificarBloqueo(ByVal idListado As Integer, ByVal valor As Integer)
        _oAccesoListado.ModificarBloqueo(idListado, valor)
    End Sub
End Class
