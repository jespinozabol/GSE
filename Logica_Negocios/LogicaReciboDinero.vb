Imports Entidades
Imports Acceso_Datos
Public Class LogicaReciboDinero
    Private ReadOnly _oAccesoRecibo As New AccesoRecibo
    Private ReadOnly _oAccesoFacturaCredito As New AccesoFacturaCredito
    Private ReadOnly _oAccesoAbono As New AccesoAbono
    Private ReadOnly _oAccesoNotaCredito As New AccesoNotaCredito
    Private ReadOnly _oUtilidades As New Utilidades
    Private ReadOnly _oLogicaClienteCredito As New LogicaClienteCredito

    Public Sub Insertar(ByVal oRecibo As Recibo)
        _oAccesoRecibo.Insertar(oRecibo)
    End Sub

    Public Sub anularReciboDinero_NumRecibo(ByVal numRecibo As Integer)

        Dim oRecibo As Recibo
        oRecibo = _oAccesoRecibo.Consultar(numRecibo)
        _oAccesoRecibo.AnularRecibo(oRecibo.NumRecibo)

        Select Case oRecibo.Concepto
            Case 1
                RetornarReciboCancelacion(oRecibo)
            Case 2
                RetornarReciboCancelacionAbono(oRecibo)
            Case 3
                RetornarReciboAbono(oRecibo)
        End Select

        Dim oClienteCredito As New ClienteCredito
        Dim lista = _oUtilidades.calcularDatos_Cliente(oRecibo.IdClienteCredito)

        oClienteCredito.IdCredito = oRecibo.IdClienteCredito
        oClienteCredito.DiasAtrasado = lista(0)
        oClienteCredito.TotalAtrasado = lista(1)
        oClienteCredito.TotalCreditos = lista(2)

        _oLogicaClienteCredito.actualizarDatos_Credito(oClienteCredito)
    End Sub

    Private Sub RetornarReciboCancelacion(ByVal oRecibo As Recibo)

        For i As Integer = 0 To oRecibo.ReciboDetalle.Count - 1

            Select Case oRecibo.ReciboDetalle(i).Tipo

                Case ReciboDetalle.ListaTipo.Cancelacion
                    cambiarEstado_Factura(oRecibo.ReciboDetalle(i).Doc)
                Case ReciboDetalle.ListaTipo.Abono
                    cambiarEstado_Abono(oRecibo.ReciboDetalle(i).Doc)
                Case ReciboDetalle.ListaTipo.NotaCredito
                    cambiarEstado_NotaCredito(oRecibo.ReciboDetalle(i).Doc)
                Case ReciboDetalle.ListaTipo.NCGeneral
                    cambiarEstado_NCGeneral(oRecibo.ReciboDetalle(i).Doc)
            End Select
        Next

    End Sub

    Private Sub RetornarReciboCancelacionAbono(ByVal oRecibo As Recibo)
        Dim oAbono As New Abono
        oAbono.IdAbono = oRecibo.ReciboDetalle(oRecibo.ReciboDetalle.Count - 2).Doc
        oAbono.Estado = Abono.ListaEstado.Anulado
        _oAccesoAbono.ModificarEstadoPor_IdAbono(oAbono)

        For i As Integer = 0 To oRecibo.ReciboDetalle.Count - 3

            Select Case oRecibo.ReciboDetalle(i).Tipo
                Case ReciboDetalle.ListaTipo.Cancelacion
                    cambiarEstado_Factura(oRecibo.ReciboDetalle(i).Doc)
                Case ReciboDetalle.ListaTipo.Abono
                    cambiarEstado_Abono(oRecibo.ReciboDetalle(i).Doc)
                Case ReciboDetalle.ListaTipo.NotaCredito
                    cambiarEstado_NotaCredito(oRecibo.ReciboDetalle(i).Doc)
                Case ReciboDetalle.ListaTipo.NCGeneral
                    cambiarEstado_NCGeneral(oRecibo.ReciboDetalle(i).Doc)
            End Select
        Next
    End Sub

    Private Sub RetornarReciboAbono(ByVal oRecibo As Recibo)
        Dim oAbono As New Abono
        oAbono.IdAbono = oRecibo.ReciboDetalle(1).Doc
        oAbono.Estado = Abono.ListaEstado.Anulado
        _oAccesoAbono.ModificarEstadoPor_IdAbono(oAbono)
    End Sub

    Private Sub cambiarEstado_Factura(ByVal numFactura As Integer)
        _oAccesoFacturaCredito.ModificarEstado(numFactura, FacturaCredito.ListaEstado.Pendiente)
    End Sub

    Private Sub cambiarEstado_Abono(ByVal idAbono As Integer)
        Dim oAbono As New Abono
        oAbono.IdAbono = idAbono
        oAbono.Estado = Abono.ListaEstado.Pendiente
        _oAccesoAbono.ModificarEstadoPor_IdAbono(oAbono)
    End Sub

    Private Sub cambiarEstado_NotaCredito(ByVal idNc As Integer)
        _oAccesoNotaCredito.ModificarEstadoNCPor_IdNC(idNc, NotaCredito.ListaEstado.Pendiente)
    End Sub

    Private Sub cambiarEstado_NCGeneral(ByVal idNc As Integer)
        _oAccesoNotaCredito.ModificarEstadoNCGPor_IdNC(idNc, NotaCreditoGeneral.ListaEstado.Pendiente)
    End Sub

    Function consultarRecibo_NumRecibo(ByVal numRecibo As Integer) As Recibo
        Return _oAccesoRecibo.Consultar(numRecibo)
    End Function

    Function ConsultarTodosInfo() As DataTable
        Return _oAccesoRecibo.ConsultarTodosInfo
    End Function

    Function ConsultarPorNumRecibo(ByVal numRecibo As Integer) As DataTable
        Return _oAccesoRecibo.ConsultarPor_NumReciboInfo(numRecibo)
    End Function

    Function ConsultarPorNumFactura(ByVal numFactura As Long) As DataTable
        Return _oAccesoRecibo.ConsultarPor_NumFacturaInfo(numFactura)
    End Function

    Function ConsultarPorIdPersona(ByVal idPersona As Integer) As DataTable
        Return _oAccesoRecibo.ConsultarPor_IdPersonaInfo(idPersona)
    End Function

    Function buscarReciboId_NC(ByVal idNc As Integer) As Integer
        Return _oAccesoRecibo.BuscarReciboPor_IdNC(idNc)
    End Function

    Function buscarReciboId_Abono(ByVal idAbono As Integer, ByVal numFactura As Integer) As Integer
        Return _oAccesoRecibo.BuscarReciboPor_IdAbono(idAbono, numFactura)
    End Function

End Class
