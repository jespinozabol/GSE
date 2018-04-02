Imports Entidades
Imports Acceso_Datos
Public Class LogicaDocPorPagar

    Private ReadOnly _oAccesoDocPorPagar As New AccesoFacturaProveedor
    Private ReadOnly _oAccesoAbonoDocPorPagar As New AccesoAbonoFacturaProveedor

    Public Function Insertar(ByVal oDocPorPagar As FacturaProveedor) As Boolean
        If _oAccesoDocPorPagar.Consultar(oDocPorPagar.IdProveedor, oDocPorPagar.NumFactura).IdDocPagar <> 0 Then
            Return 0
        Else
            _oAccesoDocPorPagar.Insertar(oDocPorPagar)
            Return 1
        End If
    End Function

    Function consultarNC_IDDocPagar(ByVal idDocPorPagar As Integer) As List(Of NCFacturaProveedor)
        Return _oAccesoDocPorPagar.ConsultarNC_IdDocPorPagar(idDocPorPagar)
    End Function

    Function consultarND_IDDocPagar(ByVal idDocPorPagar As Integer) As List(Of NDFacturaProveedor)
        Return _oAccesoDocPorPagar.ConsultarNd_IdDocPorPagar(idDocPorPagar)
    End Function

    Function ConsultarPorIdDocPagar(ByVal idDocPorPagar As Integer) As FacturaProveedor
        Return _oAccesoDocPorPagar.Consultar(idDocPorPagar)
    End Function

    Sub Modificar(ByVal oDocPorPagar As FacturaProveedor)
        For Each nc In oDocPorPagar.ListaNC
            ModificarNC(nc)
        Next
        For Each nd In oDocPorPagar.ListaND
            ModificarND(nd)
        Next
        _oAccesoDocPorPagar.Modificar(oDocPorPagar)
    End Sub

    Public Sub ModificarNC(ByVal nc As NCFacturaProveedor)
        _oAccesoDocPorPagar.ModificarNc(nc)
    End Sub

    Public Sub ModificarND(ByVal nd As NDFacturaProveedor)
        _oAccesoDocPorPagar.ModificarNd(nd)
    End Sub

    Public Function InsertarNC(ByVal nc As NCFacturaProveedor) As Integer
        Return _oAccesoDocPorPagar.Insertar_NC(nc)
    End Function

    Public Function InsertarND(ByVal nd As NDFacturaProveedor) As Integer
        Return _oAccesoDocPorPagar.Insertar_ND(nd)
    End Function

    Function consultarFacturasPorId_Proveedor(ByVal idProveedor As Integer) As List(Of FacturaProveedor)
        Return _oAccesoDocPorPagar.ConsultaGeneralLista(2, idProveedor, Nothing, Nothing, 0)
    End Function

    Sub cambiarAplicada_IdDocPorPagar(ByVal idPorDocPagar As Integer, ByVal fecha As Date)
        _oAccesoDocPorPagar.ModificarEstadoFechaCancelacion(idPorDocPagar, FacturaProveedor.ListaEstado.Cancelada, fecha)

        Dim oAbono As New AbonoFacturaProveedor
        oAbono.IdFacturaProveedor = idPorDocPagar
        oAbono.Estado = AbonoFacturaProveedor.ListaEstado.Aplicado
        _oAccesoAbonoDocPorPagar.ModificarEstadoPorId_Factura_Proveedor(oAbono)
    End Sub

    Sub eliminarNC(ByVal idNc As Integer)
        _oAccesoDocPorPagar.EliminarNC(idNc)
    End Sub

    Sub eliminarND(ByVal idNd As Integer)
        _oAccesoDocPorPagar.EliminarND(idNd)
    End Sub

    Function consultarNumFacturas_PorProveedoryFecha(ByVal idProveedor As Integer, ByVal fechaInicio As Date) As DataTable
        Return _oAccesoDocPorPagar.ConsultarNumFacturasPor_ProveedorFecha(idProveedor, fechaInicio)
    End Function

    Function consultarPorNumFactura_Proveedor(ByVal idProveedor As Integer, ByVal numFactura As String) As FacturaProveedor
        Return _oAccesoDocPorPagar.Consultar(idProveedor, numFactura)
    End Function

    Sub Anular(ByVal oDocPorPagar As FacturaProveedor)
        _oAccesoDocPorPagar.Anular(oDocPorPagar.IdDocPagar, oDocPorPagar.Estado, oDocPorPagar.Motivo)
    End Sub

    '************************************** Notas de crédito Facturas Proveedor ****************************************

    Function ConsultarTodasNc(ByVal rango As UInteger, Optional ByVal fechaInicio As Date = Nothing, Optional ByVal fechaFinal As Date = Nothing) As DataTable
        If rango = 0 Then
            Return _oAccesoDocPorPagar.ConsultaGeneralNC(3)
        Else
            Return _oAccesoDocPorPagar.ConsultaGeneralNC(4, 0, "", fechaInicio, fechaFinal)
        End If
    End Function

    Function ConsultarNcPorIdProveedorFechas(ByVal rango As UInteger, ByVal idProveedor As Integer, Optional ByVal fechaInicio As Date = Nothing, Optional ByVal fechaFinal As Date = Nothing) As DataTable
        If rango = 0 Then
            Return _oAccesoDocPorPagar.ConsultaGeneralNC(5, idProveedor)
        Else
            Return _oAccesoDocPorPagar.ConsultaGeneralNC(6, idProveedor, "", fechaInicio, fechaFinal)
        End If
    End Function

    Function ConsultarNcPorNumNc(ByVal numDoc As Integer) As DataTable
        Return _oAccesoDocPorPagar.ConsultaGeneralNC(2, numDoc)
    End Function

    Function ConsultarPorNumFactura(ByVal numFactura As String) As DataTable
        Return _oAccesoDocPorPagar.ConsultaGeneralNC(1, 0, numFactura)
    End Function

    Function ConsultarPorIdNC(ByVal idNc As Integer) As NCFacturaProveedor
        Return _oAccesoDocPorPagar.ConsultarNC(idNc)
    End Function

    '************************************** Notas de débito Facturas Proveedor ****************************************

    Function ConsultarTodasNd(ByVal rango As UInteger, Optional ByVal fechaInicio As Date = Nothing, Optional ByVal fechaFinal As Date = Nothing) As DataTable
        If rango = 0 Then
            Return _oAccesoDocPorPagar.ConsultaGeneralND(3)
        Else
            Return _oAccesoDocPorPagar.ConsultaGeneralND(4, 0, "", fechaInicio, fechaFinal)
        End If
    End Function

    Function ConsultarNdPorIdProveedorFechas(ByVal rango As UInteger, ByVal idProveedor As Integer, Optional ByVal fechaInicio As Date = Nothing, Optional ByVal fechaFinal As Date = Nothing) As DataTable
        If rango = 0 Then
            Return _oAccesoDocPorPagar.ConsultaGeneralND(5, idProveedor)
        Else
            Return _oAccesoDocPorPagar.ConsultaGeneralND(6, idProveedor, "", fechaInicio, fechaFinal)
        End If
    End Function

    Function ConsultarNdPorNumNd(ByVal numDoc As Integer) As DataTable
        Return _oAccesoDocPorPagar.ConsultaGeneralND(2, numDoc)
    End Function

    Function ConsultarNdPorNumFactura(ByVal numFactura As String) As DataTable
        Return _oAccesoDocPorPagar.ConsultaGeneralND(1, 0, numFactura)
    End Function

    Function ConsultarPorIdND(ByVal idNd As Integer) As NDFacturaProveedor
        Return _oAccesoDocPorPagar.ConsultarND(idNd)
    End Function

    '***************************************FACTURAS PROVEEDOR***********************************************
    'Rango = 
    ' 0 = pendientes
    ' 1 = canceladas
    ' 2 = sin anular
    ' 3 = anuladas
    ' 4 = todas
    Function ConsultarPorIdProveedorRangoFechas(ByVal idProveedor As Integer, ByVal rango As Integer, ByVal fechaInicio As Date, ByVal fechaFinal As Date) As List(Of FacturaProveedor)
        Select Case rango
            Case 0
                Return _oAccesoDocPorPagar.ConsultaGeneralLista(6, idProveedor, fechaInicio, fechaFinal, 0)
            Case 1
                Return _oAccesoDocPorPagar.ConsultaGeneralLista(6, idProveedor, fechaInicio, fechaFinal, 1)
            Case 2
                Return _oAccesoDocPorPagar.ConsultaGeneralLista(5, idProveedor, fechaInicio, fechaFinal)
            Case 3
                Return _oAccesoDocPorPagar.ConsultaGeneralLista(6, idProveedor, fechaInicio, fechaFinal, 2)
            Case Else
                Return _oAccesoDocPorPagar.ConsultaGeneralLista(4, idProveedor, fechaInicio, fechaFinal)
        End Select
    End Function

    Function ConsultarTodasRangoFecha(ByVal rango As Integer, ByVal fechaInicio As Date, ByVal fechaFinal As Date) As List(Of FacturaProveedor)
        Select Case rango
            Case 0
                Return _oAccesoDocPorPagar.ConsultaGeneralLista(11, 0, fechaInicio, fechaFinal, 0)
            Case 1
                Return _oAccesoDocPorPagar.ConsultaGeneralLista(11, 0, fechaInicio, fechaFinal, 1)
            Case 2
                Return _oAccesoDocPorPagar.ConsultaGeneralLista(12, 0, fechaInicio, fechaFinal)
            Case 3
                Return _oAccesoDocPorPagar.ConsultaGeneralLista(11, 0, fechaInicio, fechaFinal, 2)
            Case Else
                Return _oAccesoDocPorPagar.ConsultaGeneralLista(10, 0, fechaInicio, fechaFinal)
        End Select
    End Function

    Function ConsultarPorIdProveedor(ByVal idProveedor As Integer, ByVal rango As Integer) As List(Of FacturaProveedor)
        Select Case rango
            Case 0
                Return _oAccesoDocPorPagar.ConsultaGeneralLista(2, idProveedor, Nothing, Nothing, 0)
            Case 1
                Return _oAccesoDocPorPagar.ConsultaGeneralLista(2, idProveedor, Nothing, Nothing, 1)
            Case 2
                Return _oAccesoDocPorPagar.ConsultaGeneralLista(3, idProveedor)
            Case 3
                Return _oAccesoDocPorPagar.ConsultaGeneralLista(2, idProveedor, Nothing, Nothing, 2)
            Case Else
                Return _oAccesoDocPorPagar.ConsultaGeneralLista(1, idProveedor)
        End Select
    End Function

    Function ConsultarTodas(ByVal rango As Integer) As List(Of FacturaProveedor)
        Select Case rango
            Case 0
                Return _oAccesoDocPorPagar.ConsultaGeneralLista(9, 0, Nothing, Nothing, 0)
            Case 1
                Return _oAccesoDocPorPagar.ConsultaGeneralLista(9, 0, Nothing, Nothing, 1)
            Case 2
                Return _oAccesoDocPorPagar.ConsultaGeneralLista(8)
            Case 3
                Return _oAccesoDocPorPagar.ConsultaGeneralLista(9, 0, Nothing, Nothing, 2)
            Case Else
                Return _oAccesoDocPorPagar.ConsultaGeneralLista(7)
        End Select
    End Function
End Class
