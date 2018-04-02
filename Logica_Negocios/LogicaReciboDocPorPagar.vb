Imports Entidades
Imports Acceso_Datos
Public Class LogicaReciboDocPorPagar

    Private ReadOnly _oAccesoRecibo As New AccesoReciboDocPorPagar
    Private ReadOnly _oAccesoDocPorPagar As New AccesoFacturaProveedor
    Private ReadOnly _oAccesoAbonoDocPorPagar As New AccesoAbonoFacturaProveedor
    Private ReadOnly _oAccesoProveedor As New AccesoProveedor

    Public Sub Insertar(ByVal oRecibo As ReciboDocPorPagar)
        _oAccesoRecibo.Insertar(oRecibo)
    End Sub

    Function ConsultarTodosInfo() As DataTable
        Return _oAccesoRecibo.ConsultarTodosInfo
    End Function

    Function ConsultarTodosInfo(ByVal fechaInicio As Date, ByVal fechaFinal As Date) As DataTable
        Return _oAccesoRecibo.ConsultarTodosInfo(fechaInicio, fechaFinal)
    End Function

    Function ConsultarPorIdProveedor(ByVal idProveedor As Integer) As DataTable
        Return _oAccesoRecibo.ConsultarPor_IdProveedor(idProveedor)
    End Function

    Function ConsultarPorIdProveedor(ByVal idProveedor As Integer, ByVal fechaInicio As Date, ByVal fechaFinal As Date) As DataTable
        Return _oAccesoRecibo.ConsultarPor_IdProveedor(idProveedor, fechaInicio, fechaFinal)
    End Function

    Function ConsultarPorNumReciboProveedor(ByVal numRecibo As Integer) As DataTable
        Return _oAccesoRecibo.ConsultarPor_NumReciboProveedor(numRecibo)
    End Function

    Function ConsultarPorNumFactura(ByVal numFactura As String) As DataTable
        Return _oAccesoRecibo.consultarPor_NumFactura(numFactura)
    End Function

    Sub EliminarRecibo(ByVal numRecibo As Integer)
        Dim oRecibo As ReciboDocPorPagar
        oRecibo = _oAccesoRecibo.Consultar(numRecibo)
        _oAccesoRecibo.Eliminar(numRecibo)

        Select Case oRecibo.Concepto
            Case 1
                RetornarReciboCancelacion(oRecibo)
            Case 2
                RetornarReciboCancelacionAbono(oRecibo)
            Case 3
                eliminar_Abono(oRecibo.ReciboDetalle(1).IdDoc)
        End Select

    End Sub

    Private Sub RetornarReciboCancelacion(ByVal oRecibo As ReciboDocPorPagar)
        For i As Integer = 0 To oRecibo.ReciboDetalle.Count - 1
            RetornarLinea(oRecibo.ReciboDetalle(i))
        Next
    End Sub

    Private Sub RetornarReciboCancelacionAbono(ByVal oRecibo As ReciboDocPorPagar)
        eliminar_Abono(oRecibo.ReciboDetalle(oRecibo.ReciboDetalle.Count - 1).IdDoc)

        For i As Integer = 0 To oRecibo.ReciboDetalle.Count - 2
            RetornarLinea(oRecibo.ReciboDetalle(i))
        Next
    End Sub

    Private Sub RetornarLinea(ByVal oReciboDetalle As ReciboDocPorPagarDetalle)
        Select Case oReciboDetalle.Tipo
            Case ReciboDocPorPagarDetalle.ListaTipo.Cancelacion
                cambiarEstado_Factura(oReciboDetalle.IdDoc)
            Case ReciboDocPorPagarDetalle.ListaTipo.Abono
                eliminar_Abono(oReciboDetalle.IdDoc)
            Case ReciboDocPorPagarDetalle.ListaTipo.NotaCreditoGeneral
                cambiarEstado_NCGeneral(oReciboDetalle.IdDoc)
        End Select
    End Sub

    Private Sub eliminar_Abono(ByVal idAbono As Integer)
        _oAccesoAbonoDocPorPagar.EliminarAbono(idAbono)
    End Sub

    Private Sub cambiarEstado_Factura(ByVal idDocPorPagar As Integer)
        _oAccesoDocPorPagar.ModificarEstadoFechaCancelacion(idDocPorPagar, FacturaProveedor.ListaEstado.Pendiente, Nothing)
    End Sub

    Private Sub cambiarEstado_NCGeneral(ByVal idNcg As Integer)
        Dim oNcGeneral As New NCProveedorGeneral
        oNcGeneral.IdNcg = idNcg
        oNcGeneral.Estado = 0
        _oAccesoProveedor.ActualizarEstadoNcg(oNcGeneral.IdNcg, oNcGeneral.Estado)
    End Sub

    Function ConsultarPorNumRecibo(ByVal numRecibo As Integer) As ReciboDocPorPagar
        Dim recibo = _oAccesoRecibo.Consultar(numRecibo)
        recibo.ReciboDetalle = _oAccesoRecibo.ConsultarDetalles_Recibo(recibo.NumRecibo)
        Return recibo
    End Function

    Sub ModificarFechaDetalleRecibo(ByVal numRecibo As String, ByVal fecha As Date, ByVal idFactProveedor As Integer, ByVal observaciones As String)
        _oAccesoRecibo.ModificarFechaDetalleRecibo(numRecibo, fecha, idFactProveedor, observaciones)
    End Sub
End Class
