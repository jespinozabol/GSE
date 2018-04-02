Imports Entidades
Imports Acceso_Datos
Public Class LogicaProveedor
    Private ReadOnly _oAccesoProveedor As New AccesoProveedor
    Private ReadOnly _oAccesoAgente As New AccesoAgente
    Private ReadOnly _oAccesoEncargado As New AccesoEncargadoProveedor

    Public Sub Insertar(ByVal oProveedor As Proveedor)

        oProveedor.IdProveedor = _oAccesoProveedor.Insertar(oProveedor)

        For i As Integer = 0 To oProveedor.Agentes.Count - 1
            oProveedor.Agentes(i).IdProveedor = oProveedor.IdProveedor
            _oAccesoAgente.Insertar(oProveedor.Agentes(i))
        Next i

        For i As Integer = 0 To oProveedor.Encargados.Count - 1
            oProveedor.Encargados(i).IdProveedor = oProveedor.IdProveedor
            _oAccesoEncargado.Insertar(oProveedor.Encargados(i))
        Next i
    End Sub

    Public Sub EliminarAgente(ByVal idAgente As Integer)
        _oAccesoAgente.Eliminar(idAgente)
    End Sub

    Public Sub EliminarEncargado(ByVal idEncargado As Integer)
        _oAccesoEncargado.Eliminar(idEncargado)
    End Sub

    Public Sub EliminarProveedor(ByVal idProveedor As Integer)
        _oAccesoProveedor.Eliminar(idProveedor)
    End Sub

    Public Function ConsultarPorNombre(ByVal nombre As String) As DataTable
        Return _oAccesoProveedor.ConsultarNombre(nombre)
    End Function

    Public Function ExtraerDatos(ByVal idProveedor As Integer) As Proveedor
        Dim oProveedor As Proveedor
        oProveedor = _oAccesoProveedor.Consultar(idProveedor)
        oProveedor.Agentes = _oAccesoAgente.ConsultarPor_IdProveedor(oProveedor.IdProveedor)
        oProveedor.Encargados = _oAccesoEncargado.ConsultarPor_IdProveedor(oProveedor.IdProveedor)
        Return oProveedor
    End Function

    Public Sub Modificar(ByVal oProveedor As Proveedor, ByVal oListaAgentesEliminar As List(Of Agente), ByVal oListaEncargadosEliminar As List(Of Encargado))

        _oAccesoProveedor.Modificar(oProveedor)

        For i As Integer = 0 To oProveedor.Agentes.Count - 1
            oProveedor.Agentes(i).IdProveedor = oProveedor.IdProveedor

            If oProveedor.Agentes(i).IdAgente <= 0 Then
                _oAccesoAgente.Insertar(oProveedor.Agentes(i))
            Else
                _oAccesoAgente.Modificar(oProveedor.Agentes(i))
            End If
        Next i

        For i As Integer = 0 To oProveedor.Encargados.Count - 1
            oProveedor.Encargados(i).IdProveedor = oProveedor.IdProveedor
            If oProveedor.Encargados(i).IdEncargado <= 0 Then
                _oAccesoEncargado.Insertar(oProveedor.Encargados(i))
            Else
                _oAccesoEncargado.Modificar(oProveedor.Encargados(i))
            End If
        Next i

        If oListaAgentesEliminar.Count > 0 Then
            For i As Integer = 0 To oListaAgentesEliminar.Count - 1
                _oAccesoAgente.Eliminar(oListaAgentesEliminar(i).IdAgente)
            Next
        End If

        If oListaEncargadosEliminar.Count > 0 Then
            For i As Integer = 0 To oListaEncargadosEliminar.Count - 1
                _oAccesoEncargado.Eliminar(oListaEncargadosEliminar(i).IdEncargado)
            Next
        End If
    End Sub

    Function ConsultarTodos() As DataTable
        Return _oAccesoProveedor.ConsultarNombre
    End Function

    'Lista todos los proveedores Código, Nombre, Teléfono y fax
    Function ConsultarLista() As List(Of Proveedor)
        Return _oAccesoProveedor.Consultar
    End Function

    Function Consultar(ByVal idProveedor As Integer) As Proveedor
        Dim oProveedor As Proveedor
        oProveedor = _oAccesoProveedor.Consultar(idProveedor)
        oProveedor.Agentes = _oAccesoAgente.ConsultarPor_IdProveedor(oProveedor.IdProveedor)
        oProveedor.Encargados = _oAccesoEncargado.ConsultarPor_IdProveedor(oProveedor.IdProveedor)
        Return oProveedor
    End Function

    Function ConsultarDatosProveedor(ByVal idProveedor As Integer) As DataTable
        Return _oAccesoProveedor.ConsultarDatosProveedor(idProveedor)
    End Function

    Function consultarNombre_PorCodigo(ByVal idProveedor As Integer) As String
        Return _oAccesoProveedor.ConsultarNombre(idProveedor)
    End Function

    Function insertar_NCGeneral(ByVal oNcProveedorGeneral As NCProveedorGeneral) As Integer
        Return _oAccesoProveedor.Insertar_NCG(oNcProveedorGeneral)
    End Function

    Function ConsultarGenerales(ByVal idProveedor As Integer) As List(Of NCProveedorGeneral)
        Return _oAccesoProveedor.ConsultarNCGPor_IdProveedor(idProveedor)
    End Function

    Sub actualizarGeneralEstado_IdNC(ByVal ncGeneral As NCProveedorGeneral)
        _oAccesoProveedor.ActualizarEstadoNcg(ncGeneral.IdNcg, ncGeneral.Estado)
    End Sub

    Function ConsultarGeneralPorIdNcg(ByVal idNcg As Integer) As NCProveedorGeneral
        Return _oAccesoProveedor.Consultar_NCG(idNcg)
    End Function

    Sub modificar_NCGeneral(ByVal oNcProveedorGeneral As NCProveedorGeneral)
        _oAccesoProveedor.Modificar_NCG(oNcProveedorGeneral)
    End Sub

    Sub eliminarNCG_PorId(ByVal idNcg As Integer)
        _oAccesoProveedor.Eliminar_NCG(idNcg)
    End Sub

    Function ConsultarTodasGeneralesInfo() As DataTable
        Return _oAccesoProveedor.ConsultarDNCG_Todas()
    End Function

    Function ConsultarTodasGeneralesInfo(ByVal fechaInicio As Date, ByVal fechaFinal As Date) As DataTable
        Return _oAccesoProveedor.ConsultarDNCG_Todas(fechaInicio, fechaFinal)
    End Function

    Function ConsultarPorIdProveedorGenerales(ByVal idProveedor As Integer) As DataTable
        Return _oAccesoProveedor.ConsultarDNCGPor_IdProveedor(idProveedor)
    End Function

    Function ConsultarPorIdProveedorGenerales(ByVal idProveedor As Integer, ByVal fechaInicio As Date, ByVal fechaFinal As Date) As DataTable
        Return _oAccesoProveedor.ConsultarDNCGPor_IdProveedor(idProveedor, fechaInicio, fechaFinal)
    End Function

    Function ConsultarPorNumNotaCreditoGenerales(ByVal numNcg As Integer) As DataTable
        Return _oAccesoProveedor.ConsultarDNCGPor_numNC(numNcg)
    End Function

End Class
