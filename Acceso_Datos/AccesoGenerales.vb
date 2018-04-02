Public Class AccesoGenerales
    Inherits Transaccion

    Public Function CalSubTotalVentas(ByVal fechaInicio As Date, ByVal fechaFin As Date) As Double
        Dim sql As String = " Select sum((d.Cantidad*d.PrecioUnitario)) " _
                          & " From FACTURA_DETALLE d, FACTURA_ENCABEZADO e " _
                          & " Where e.Anulada=0 and e.Num_Factura = d.Num_Factura " _
                          & " And e.Fecha >= '" & fechaInicio.ToString("yyyy-MM-dd") & "' And e.Fecha <= '" & fechaFin.ToString("yyyy-MM-dd") & "' " _
                          & " And (d.Id_Producto <= 99500 or d.Id_Producto >= 100000)"
        Return RealizarConsulta(sql)
    End Function

    Public Function CalTotalDescuentos(ByVal fechaInicio As Date, ByVal fechaFin As Date) As Double
        Dim sql As String = " Select sum((d.Cantidad*d.PrecioUnitario) * d.descuento/100) as Monto " _
                          & " From FACTURA_DETALLE d, FACTURA_ENCABEZADO e " _
                          & " Where e.Anulada=0 and e.Num_Factura = d.Num_Factura " _
                          & " And e.Fecha >= '" & fechaInicio.ToString("yyyy-MM-dd") & "' And e.Fecha <= '" & fechaFin.ToString("yyyy-MM-dd") & "'"
        Return RealizarConsulta(sql)
    End Function

    Public Function CalImpuestoNormal(ByVal fechaInicio As Date, ByVal fechaFin As Date) As Double
        Dim sql As String = " Select sum((d.Cantidad*d.PrecioUnitario)* d.Impuesto/100) as Monto " _
                          & " From FACTURA_DETALLE d, FACTURA_ENCABEZADO e, IMPUESTO i" _
                          & " Where e.Anulada = 0 and e.Num_Factura = d.Num_Factura And d.Impuesto = i.Impuesto" _
                          & " And e.Fecha >= '" & fechaInicio.ToString("yyyy-MM-dd") & "' And e.Fecha <= '" & fechaFin.ToString("yyyy-MM-dd") & "'"
        Return RealizarConsulta(sql)
    End Function

    Public Function CalTImpuestoParcial(ByVal fechaInicio As Date, ByVal fechaFin As Date) As Double
        Dim sql As String = " Select sum((d.Cantidad*d.PrecioUnitario)* d.Impuesto/100)" _
                          & " From FACTURA_DETALLE d, FACTURA_ENCABEZADO e, IMPUESTO i" _
                          & " Where e.Anulada=0 and e.Num_Factura = d.Num_Factura And d.Impuesto <> i.Impuesto" _
                          & " And e.Fecha >= '" & fechaInicio.ToString("yyyy-MM-dd") & "' And e.Fecha<= '" & fechaFin.ToString("yyyy-MM-dd") & "'"
        Return RealizarConsulta(sql)
    End Function

    Public Function CalTVentasExcentas(ByVal fechaInicio As Date, ByVal fechaFin As Date) As Double
        Dim sql As String = " Select sum((d.Cantidad*d.PrecioUnitario)) " _
                          & " From FACTURA_DETALLE d, FACTURA_ENCABEZADO e, IMPUESTO i" _
                          & " Where e.Anulada=0 and e.Num_Factura =d.Num_Factura And d.Impuesto=0" _
                          & " And e.Fecha>= '" & fechaInicio.ToString("yyyy-MM-dd") & "' And e.Fecha<= '" & fechaFin.ToString("yyyy-MM-dd") & "'" _
                          & " And (d.Id_Producto <= 99500 or d.Id_Producto >= 100000)"
        Return RealizarConsulta(sql)
    End Function

    Public Function CalTVentasServiciosProfesionales(ByVal fechaInicio As Date, ByVal fechaFin As Date) As Double
        Dim sql As String = " Select sum((d.Cantidad*d.PrecioUnitario)) " _
                          & " From FACTURA_DETALLE d, FACTURA_ENCABEZADO e " _
                          & " Where e.Anulada=0 and e.Num_Factura=d.Num_Factura " _
                          & " And e.Fecha>= '" & fechaInicio.ToString("yyyy-MM-dd") & "' And e.Fecha<= '" & fechaFin.ToString("yyyy-MM-dd") & "'" _
                          & " And (d.Id_Producto >= 99500 and d.Id_Producto <= 100000)"
        Return RealizarConsulta(sql)
    End Function

    Private Function RealizarConsulta(ByVal sql As String) As Double
        Try
            Dim oDataTable = ConsultarDatos(sql)
            If oDataTable.Rows.Count > 0 Then
                If IsDBNull(oDataTable.Rows(0).Item(0)) Then
                    Return 0
                Else
                    Return oDataTable.Rows(0).Item(0)
                End If
            Else
                Return 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Realizando calculos para tributación")
            Return 0
        End Try
    End Function
End Class