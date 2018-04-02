Imports Acceso_Datos
Imports Entidades

Public Class LogicaFacturaCredito

    Private ReadOnly _oAccesoFacturaCredito As New AccesoFacturaCredito
    Private ReadOnly _oAccesoAbono As New AccesoAbono
    Private ReadOnly _oLogicaNotaCredito As New LogicaNotaCredito
    Private ReadOnly _oAccesoNotaCredito As New AccesoNotaCredito
    Private ReadOnly _oAccesoClienteCredito As New AccesoClienteCredito

    Public Sub Insertar(ByVal oFacturaCredito As FacturaCredito)
        _oAccesoFacturaCredito.Insertar(oFacturaCredito)
    End Sub

    Public Function consultarFacturasPorId_Credito(ByVal idCredito As Integer) As List(Of FacturaCredito)
        Dim oLista As New List(Of FacturaCredito)

        Dim oListaFacturasCredito = _oAccesoFacturaCredito.ConsultarPendientesPor_IdCredito(idCredito)

        With oListaFacturasCredito
            For i = 0 To .Count - 1
                Dim oFacturaCredito As FacturaCredito

                oFacturaCredito = oListaFacturasCredito(i)
                oFacturaCredito.Abonos = _oAccesoAbono.ConsultarPendientesPorNumDocYTipo(oFacturaCredito.NumFactura, Abono.ListaTipoDoc.FACT)
                oFacturaCredito.NotasCredito = _oLogicaNotaCredito.consultarPorNum_FacturaSinAplicar(oFacturaCredito.NumFactura)
                oLista.Add(oFacturaCredito)
            Next
        End With

        Return oLista
    End Function

    Public Function ConsultarFacturaPorNumFacturaSinAplicar(ByVal numFactura As Long) As FacturaCredito

        Dim oFacturaCredito = _oAccesoFacturaCredito.Consultar(numFactura)

        oFacturaCredito.Abonos = _oAccesoAbono.ConsultarPendientesPorNumDocYTipo(oFacturaCredito.NumFactura, Abono.ListaTipoDoc.FACT)
        oFacturaCredito.NotasCredito = _oLogicaNotaCredito.consultarPorNum_FacturaSinAplicar(oFacturaCredito.NumFactura)
        Return oFacturaCredito
    End Function

    Public Function ConsultarPorNumFactura(ByVal numFactura As Long) As FacturaCredito

        Dim oFacturaCredito = _oAccesoFacturaCredito.Consultar(numFactura)

        oFacturaCredito.Abonos = _oAccesoAbono.ConsultarPorNumDocYTipo(oFacturaCredito.NumFactura, Abono.ListaTipoDoc.FACT)
        oFacturaCredito.NotasCredito = _oLogicaNotaCredito.consultarTodasPorNum_Factura(oFacturaCredito.NumFactura)
        Return oFacturaCredito
    End Function

    Public Function ConsultarFechaPorNumFactura(ByVal numFactura As Long) As String
        Return _oAccesoFacturaCredito.ConsultarFechaPor_NumFactura(numFactura)
    End Function

    Public Sub cambiarNulo_NumFactura(ByVal numFactura As Integer)

        _oAccesoFacturaCredito.ModificarEstado(numFactura, FacturaCredito.ListaEstado.Anulada)

        Dim oAbono As New Abono
        oAbono.NumDoc = numFactura
        oAbono.Estado = Abono.ListaEstado.Anulado
        oAbono.TipoDoc = Abono.ListaTipoDoc.FACT
        _oAccesoAbono.ModificarEstadoPorNumDocYTipo(oAbono)

        _oAccesoNotaCredito.ModificarEstadoNCPor_NumFactura(numFactura, NotaCredito.ListaEstado.Anulada)

        Dim factura = _oAccesoFacturaCredito.Consultar(numFactura)

        If factura.IdCredito > 0 Then
            Dim oCliente As New ClienteCredito
            oCliente.IdCredito = factura.IdCredito
            oCliente.TotalCreditos = factura.Monto
            _oAccesoClienteCredito.RestarTotalCredito(factura.IdCredito, factura.Monto)
        End If
    End Sub

    Public Sub cambiarAplicada_NumFactura(ByVal numFactura As Integer)

        _oAccesoFacturaCredito.ModificarEstado(numFactura, FacturaCredito.ListaEstado.Aplicada)

        Dim oAbono As New Abono
        oAbono.NumDoc = numFactura
        oAbono.Estado = Abono.ListaEstado.Aplicado
        oAbono.TipoDoc = Abono.ListaTipoDoc.FACT
        _oAccesoAbono.ModificarEstadoPorNumDocYTipo(oAbono)

        _oAccesoNotaCredito.ModificarEstadoNCPor_NumFactura(numFactura, NotaCredito.ListaEstado.Aplicada)
    End Sub

    Public Function facturas_Credito_Pendientes(ByVal idCredito As Integer) As Integer
        Return _oAccesoFacturaCredito.ConsultarNumeroFacturasPendientes(idCredito)
    End Function

    Sub TrasladarFacturas(ByVal idActual As Integer, ByVal idTrasladar As Integer)
        _oAccesoFacturaCredito.TrasladarFacturas(idActual, idTrasladar)
    End Sub

    
End Class
