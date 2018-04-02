Imports Entidades
Imports Acceso_Datos
Public Class LogicaFacturar
    Private ReadOnly _oAccesoConsecutivo As New AccesoConsecutivo
    Private ReadOnly _oAccesoPersona As New AccesoPersona
    Private ReadOnly _oAccesoFactura As New AccesoFactura
    Private ReadOnly _oAccesoProducto As New AccesoProducto
    Private ReadOnly _oUtilidades As New Utilidades

    Public Sub RevisaBloqueo()
        Dim siga As Boolean = True
        While siga
            siga = _oAccesoConsecutivo.ConsultarBloqueo("CONSECUTIVO_FACTURA")
        End While
    End Sub

    Public Sub Bloqueo(ByVal valor As Boolean)
        Dim oConsecutivo As New Consecutivo

        oConsecutivo.Tabla = "CONSECUTIVO_FACTURA"
        oConsecutivo.Bloqueo = Valor

        _oAccesoConsecutivo.Modificar_Bloqueo(oConsecutivo)
    End Sub

    'Inserta un cliente en la TblCliente
    Public Function GuardarDatosCliente(ByVal nombre As String, ByVal apellidos As String, ByVal cedula As String) As Integer
        Dim arreglo() As String
        Dim apellido1 As String
        Dim apellido2 As String
        Dim oPersona As New Persona

        If Not (apellidos = "") Then
            arreglo = Split(apellidos)

            If (UBound(arreglo) = 0) Then
                apellido1 = arreglo(0)
                apellido2 = "-"
            Else
                apellido1 = arreglo(0)
                apellido2 = arreglo(1)
            End If
        Else
            apellido1 = "-"
            apellido2 = "-"
        End If

        If (Cedula = "") Then
            Cedula = "0"
        End If

        oPersona.Nombre = nombre
        oPersona.PrimerApellido = apellido1
        oPersona.SegundoApellido = apellido2
        oPersona.Cedula = Cedula

        _oAccesoPersona.Insertar(oPersona)

        Return _oAccesoPersona.ConsultarIdMaximo
    End Function

    Public Sub GuardarCtrlImpFact(ByVal factura As Long, ByVal nombrePc As String)
        _oAccesoFactura.InsertarCtrlImpFact(Factura, nombrePc)
    End Sub

    Public Sub EliminarCtrlImpFact(ByVal nombrePc As String)
        _oAccesoFactura.EliminarCtrlImpFact(nombrePC)
    End Sub

    Public Sub Insertar(ByVal oFactura As Factura)
        _oAccesoFactura.Insertar(oFactura)
        descontarExistencias(oFactura)
    End Sub

    Public Sub DescontarExistencias(ByVal ofactura As Factura)
        For i As Integer = 0 To ofactura.FacturaDetalles.Count - 1
            _oAccesoProducto.DescontarExistencias(ofactura.FacturaDetalles(i).Cantidad, ofactura.FacturaDetalles(i).Id_Producto)
        Next
    End Sub

    Public Sub AumentarExistencias(ByVal ofactura As Factura)
        For i As Integer = 0 To ofactura.FacturaDetalles.Count - 1
            _oAccesoProducto.AumentarExistencias(ofactura.FacturaDetalles(i).Cantidad, ofactura.FacturaDetalles(i).Id_Producto)
        Next
    End Sub

    Public Sub CalcularGanancia(ByVal oFacturasDetalle As List(Of FacturaDetalle))
        Dim ganancia As Double

        For i As Integer = 0 To oFacturasDetalle.Count - 1
            Dim oProducto As Producto
            oProducto = _oAccesoProducto.Consultar(oFacturasDetalle(i).Id_Producto)

            ganancia = ganancia + (oProducto.PrecioUnitario * oFacturasDetalle(i).Cantidad * (oProducto.Ganancia / 100))
        Next

        _oAccesoFactura.ModificarGanancia(ganancia, oFacturasDetalle(0).NumFactura)
    End Sub

    Function ConsultarFacturaDetalle(ByVal numFactura As Integer) As List(Of FacturaDetalle)
        Return _oAccesoFactura.ConsultarDetalle(numFactura)
    End Function

    Function ConsultarFactura(ByVal numFactura As Integer) As Factura
        Return _oAccesoFactura.Consultar(numFactura)
    End Function

    Function consultarFacturaEncabezado_ConNombre(ByVal numFactura As Integer) As DataTable
        Return _oAccesoFactura.ConsultarPor_NumFactura_ConNombre(numFactura)
    End Function

    Function ConsultarCtrlImpFact(ByVal nombrePc As String) As DataTable
        Return _oAccesoFactura.ConsultarCtrlImpFact(NombrePC)
    End Function

    Function ConsultarFacturaAnular(ByVal numFactura As Integer) As DataTable
        Return _oAccesoFactura.ConsultarFacturaAnular(numFactura)
    End Function

    Public Sub Anular(ByVal numFactura As Long)
        _oAccesoFactura.Anular(numFactura)
        AumentarExistencias(ConsultarFactura(numFactura))
    End Sub

    Public Sub AsignarReferencia(ByVal numFactura As Integer, ByVal idReferencia As Integer)
        _oAccesoFactura.AsignarReferencia(numFactura, idReferencia)
    End Sub

    Public Function CalcularTotal(ByVal oFacturasDetalle As List(Of FacturaDetalle)) As Double
        Dim total As Double

        For i As Integer = 0 To oFacturasDetalle.Count - 1
            Dim subTotal As Double = _oUtilidades.PasarMoneda(oFacturasDetalle(i).PrecioUnitario * oFacturasDetalle(i).Cantidad)
            Dim descuento As Double = subTotal * ((oFacturasDetalle(i).Descuento / 100))
            Dim subTotalConDescuento As Double = subTotal - descuento
            Dim impuesto As Double = subTotalConDescuento * ((oFacturasDetalle(i).Impuesto / 100))
            total += subTotalConDescuento + impuesto
        Next

        Return total
    End Function

    Function ConsultarCantidadFacturasContado(ByVal idPersona As Integer) As Integer
        Return _oAccesoFactura.ConsultarCantidadFacturasContado(idPersona)
    End Function

    Function consultarUltima_Compra(ByVal idPersona As Integer) As String
        Return _oAccesoFactura.ConsultarUltimaCompra(idPersona)
    End Function

    Sub TrasladarFacturas(ByVal idActual As Integer, ByVal idTrasladar As Integer)
        _oAccesoFactura.TrasladarFacturas(idActual, idTrasladar)
    End Sub

    Function consultarPorIdPersona_ConNombre(ByVal idPersona As Integer) As DataTable
        Return _oAccesoFactura.ConsultarPor_IdPersona_ConNombre(idPersona)
    End Function

End Class
