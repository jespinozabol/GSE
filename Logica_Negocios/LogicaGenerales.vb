Imports Acceso_Datos
Imports Entidades
Public Class LogicaGenerales

    Private ReadOnly _oAccesoGenerales As New AccesoGenerales
    Private ReadOnly _oAccesoPersona As New AccesoPersona
    Private ReadOnly _oAccesoFactura As New AccesoFactura
    Private ReadOnly _oAccesoProveedor As New AccesoProveedor
    Private ReadOnly _oAccesoDocPorPagar As New AccesoFacturaProveedor
    Private ReadOnly _oUtilidades As New Utilidades


    Function CalSubTotalVentas(ByVal fechaInicio As Date, ByVal fechaFin As Date) As Double
        Return _oAccesoGenerales.CalSubTotalVentas(fechaInicio, fechaFin)
    End Function

    Function CalTotalDescuentos(ByVal fechaInicio As Date, ByVal fechaFin As Date) As Double
        Return _oAccesoGenerales.CalTotalDescuentos(fechaInicio, fechaFin)
    End Function

    Function CalImpuestoNormal(ByVal fechaInicio As Date, ByVal fechaFin As Date) As Double
        Return _oAccesoGenerales.CalImpuestoNormal(fechaInicio, fechaFin)
    End Function

    Function CalTImpuestoParcial(ByVal fechaInicio As Date, ByVal fechaFin As Date) As Double
        Return _oAccesoGenerales.CalTImpuestoParcial(fechaInicio, fechaFin)
    End Function

    Function CalTVentasExcentas(ByVal fechaInicio As Date, ByVal fechaFin As Date) As Double
        Return _oAccesoGenerales.CalTVentasExcentas(fechaInicio, fechaFin)
    End Function

    Function CalTVentasServiciosProfesionales(ByVal fechaInicio As Date, ByVal fechaFin As Date) As Double
        Return _oAccesoGenerales.CalTVentasServiciosProfesionales(fechaInicio, fechaFin)
    End Function

    Function TotalVentasPorCliente(ByVal mayor As Double, ByVal fechainicio As Date, ByVal fechaFin As Date) As DataTable
        Dim tblPersonas = _oAccesoPersona.ConsultarTodosNombreConcatenado
        Dim listaPersonas As New DataTable

        listaPersonas.Columns.Add("Id")
        listaPersonas.Columns.Add("Nombre")
        listaPersonas.Columns.Add("Cedula")
        listaPersonas.Columns.Add("Telefono")
        listaPersonas.Columns.Add("Monto")

        Dim oListaFacturas As New List(Of Factura)

        For i = 0 To tblPersonas.Rows.Count - 1
            oListaFacturas.Clear()
            oListaFacturas = _oAccesoFactura.ConsultarPor_IdPersonaRango(tblPersonas.Rows(i).Item(0), fechainicio, FechaFin)

            Dim totalFactura As Double
            Dim totalGeneral As Double = 0

            Dim detalles As List(Of FacturaDetalle)

            For j = 0 To oListaFacturas.Count - 1
                totalFactura = 0
                detalles = _oAccesoFactura.ConsultarDetalle(oListaFacturas(j).NumFactura)

                Dim subtotal As Double = 0

                For k = 0 To detalles.Count - 1
                    subtotal = subtotal + (detalles(k).PrecioUnitario * detalles(k).Cantidad)
                    subtotal = subtotal - detalles(k).TDescuento
                Next

                totalFactura = totalFactura + subtotal
                totalGeneral = totalGeneral + totalFactura
            Next

            If totalGeneral >= mayor Then

                Dim persona As Persona
                Dim telefono As String = ""

                persona = _oAccesoPersona.Consultar(tblPersonas.Rows(i).Item(0))
                telefono = persona.OtraInformacion.TelefonoPrincipal

                listaPersonas.Rows.Add(persona.IdPersona, tblPersonas.Rows(i).Item(1), persona.Cedula, telefono, _oUtilidades.PasarMoneda(totalGeneral))
            End If
        Next
        Return listaPersonas
    End Function

    Function TotalComprasPorProveedor(ByVal mayor As Double, ByVal fechaInicio As Date, ByVal fechaFin As Date) As DataTable
        Dim tblProveedores = _oAccesoProveedor.ConsultarNombre
        Dim listaProveedores As New DataTable

        listaProveedores.Columns.Add("Id")
        listaProveedores.Columns.Add("Nombre")
        listaProveedores.Columns.Add("SubTotal(IV)")
        listaProveedores.Columns.Add("SubTotal(EX)")
        listaProveedores.Columns.Add("Monto")

        Dim oListaDocPorPagar As List(Of FacturaProveedor)

        For i = 0 To tblProveedores.Rows.Count - 1
            oListaDocPorPagar = _oAccesoDocPorPagar.ConsultaGeneralLista(4, CInt(tblProveedores.Rows(i).Item(0)), fechaInicio, FechaFin)

            Dim total As Double = 0
            Dim totalConIV As Double = 0
            Dim totalEx As Double = 0

            For j = 0 To oListaDocPorPagar.Count - 1

                Dim oDocPorPagar = _oAccesoDocPorPagar.Consultar(oListaDocPorPagar(j).IdDocPagar)
                Dim totalNc As Double = 0
                Dim totalNd As Double = 0

                For k = 0 To oDocPorPagar.ListaNC.Count - 1
                    totalNc += oDocPorPagar.ListaNC(k).SubTotalIV + oDocPorPagar.ListaNC(k).SubTotalEx
                Next

                For k = 0 To oDocPorPagar.ListaND.Count - 1
                    totalNd += oDocPorPagar.ListaND(k).SubTotalIV + oDocPorPagar.ListaND(k).SubTotalEx
                Next

                totalConIV = oListaDocPorPagar(j).SubTotalIV
                totalEx = oListaDocPorPagar(j).SubTotalEx
                total += totalConIV + totalEx - totalNc + totalNd
            Next

            Dim generales = _oAccesoProveedor.ConsultarNCGPor_IdProveedor(tblProveedores.Rows(i).Item(0))
            Dim totalGenerales As Double = 0

            For j = 0 To generales.Count - 1
                totalGenerales += generales(j).SubTotalIV + generales(j).SubTotalEx
            Next

            total = total - totalGenerales
            If total >= mayor Then
                listaProveedores.Rows.Add(tblProveedores.Rows(i).Item(0), tblProveedores.Rows(i).Item(1), _oUtilidades.PasarMoneda(totalConIV), _oUtilidades.PasarMoneda(totalEx), _oUtilidades.PasarMoneda(total))
            End If
        Next
        Return listaProveedores
    End Function

End Class
