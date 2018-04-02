Imports Logica_Negocios
Imports Entidades

Namespace Reportes
    Public Class ImprimeFactura

        Private ReadOnly _oLogicaVarios As New LogicaVarios

        Public Sub Imprime(ByVal nombre As String, ByVal oFactura As Factura, ByVal diasPlazo As String)
            Dim salida As String

            Const cInicializacion As String = Chr(27) + "@" 'Inicializa la impresora devuelve el cabezal y acomoda la hoja
            Const cLargoHoja As String = Chr(27) + Chr(67) + Chr(33) 'Ultimo valor Chr(32) especifica el numero de lineas del formulario, ejemplo si la factura es de 20 lineas debes cambiarlo por Chr(20)
            Const cTipoLetra As String = Chr(27) + "x" + Chr(0)  'Draf, puedes usar Chr(1) tambien
            Const cEspaciadoLetra As String = Chr(27) + Chr(80) ' Ultimo valor Chr(80) indica q es a 10 cpi
            Const cCondensado As String = Chr(15) 'Indica q el tipo de letra a usar es Draf Condensada
            Const cFormFeed As String = Chr(12) 'Este comando debe enviarse al final de la impresion, sirve  para mover la hoja hacia arriba de manera q el usuario puede cortar la factura y luego en la proxima impresion la impresora regresa el papel a la posicion inicial 

            Dim dia = oFactura.Fecha.Day
            Dim mes = oFactura.Fecha.Month
            Dim year = oFactura.Fecha.Year

            salida = cInicializacion & cLargoHoja & cEspaciadoLetra & cCondensado & cTipoLetra
            salida = salida & vbCrLf & vbCrLf & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & "     " & dia & "   " & mes & "   " & year

            salida = salida & vbCrLf & vbCrLf

            salida = salida & Chr(9) & nombre
            For i = 0 To (60 - nombre.Length)
                salida = salida & " "
            Next

            Dim codCliente As String = oFactura.IdPersona
            salida = salida & Chr(9) & codCliente
            For j = 0 To (4 - codCliente.Length)
                salida = salida & " "
            Next

            Dim codRef As String = oFactura.IdReferencia
            salida = salida & "      " & codRef
            For j = 0 To (3 - codRef.Length)
                salida = salida & " "
            Next

            Dim numFactura As String = oFactura.NumFactura
            salida = salida & Chr(9) & "          " & numFactura
            For j = 0 To (6 - numFactura.Length)
                salida = salida & " "
            Next

            Dim contado As Boolean = oFactura.Contado
            If contado Then
                salida = salida & Chr(9) & "FACTURA DE CONTADO" & vbCrLf
            Else
                salida = salida & Chr(9) & "FACTURA DE CREDITO" & vbCrLf
            End If

            salida = salida & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9)

            If Not contado Then
                salida = salida & " " & diasPlazo & " DIAS PLAZO"
            End If

            salida = salida & vbCrLf & vbCrLf & vbCrLf

            Dim subtotalGeneral As Double
            Dim totalDescuento As Double
            Dim totalImpuesto As Double
            Dim totalGeneral As Double

            For i = 0 To oFactura.FacturaDetalles.Count - 1

                Dim cantidad As Double = oFactura.FacturaDetalles(i).Cantidad
                Dim cantidadCadena As String = Format(cantidad, "##,##0.00")
                For j = 0 To (11 - cantidadCadena.Length)
                    salida = salida & " "
                Next
                salida = salida & cantidadCadena

                Dim codigo As String = oFactura.FacturaDetalles(i).Id_Producto
                For k = 0 To (6 - codigo.Length)
                    salida = salida & " "
                Next
                salida = salida & "  " & codigo

                Dim descripcion As String = oFactura.FacturaDetalles(i).Descripcion
                If descripcion.Length >= 65 Then
                    descripcion = descripcion.Substring(0, 65)
                End If

                salida = salida & "   " & descripcion
                For l = 0 To (65 - descripcion.Length)
                    salida = salida & " "
                Next

                Dim descuento As Double = oFactura.FacturaDetalles(i).Descuento
                Dim descuentoCadena As String = Format(descuento, "##0.0")

                If CInt(descuento) <> 0 Then
                    For k = 0 To (4 - descuentoCadena.Length)
                        salida = salida & " "
                    Next
                    salida = salida & descuentoCadena
                Else
                    For k = 0 To 4
                        salida = salida & " "
                    Next
                End If

                Dim subTotal As Double = oFactura.FacturaDetalles(i).PrecioUnitario
                Dim subTotalCadena As String = Format(subTotal, "#,###,##0.00")
                For k = 0 To (13 - subTotalCadena.Length)
                    salida = salida & " "
                Next
                salida = salida & " " & subTotalCadena

                Dim total As Double = (oFactura.FacturaDetalles(i).PrecioUnitario * cantidad)
                subtotalGeneral = subtotalGeneral + total
                Dim totalCadena As String = Format(total, "#,###,##0.00")
                For k = 0 To (13 - totalCadena.Length)
                    salida = salida & " "
                Next
                salida = salida & "   " & totalCadena

                Dim impuesto As Double = oFactura.FacturaDetalles(i).Impuesto
                If CInt(impuesto) = 0 Then
                    salida = salida & "  *"
                End If

                salida = salida & vbCrLf
                totalDescuento = totalDescuento + oFactura.FacturaDetalles(i).Tdescuento
                totalImpuesto = totalImpuesto + oFactura.FacturaDetalles(i).Timpuesto
            Next

            If oFactura.FacturaDetalles.Count < 15 Then
                Dim lineasFaltantes = 15 - oFactura.FacturaDetalles.Count

                For i = 0 To lineasFaltantes - 1
                    salida = salida & vbCrLf
                Next
            End If

            totalGeneral = subtotalGeneral - totalDescuento + totalImpuesto
            salida = salida & vbCrLf & vbCrLf

            salida = salida & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9)

            Dim subtotalgenCadena = Format(subtotalGeneral, "#,###,##0.00")
            For i = 0 To (14 - subtotalgenCadena.Length)
                salida = salida & " "
            Next
            salida = salida & subtotalgenCadena & vbCrLf

            salida = salida & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9)

            Dim totaldescCadena = Format(totalDescuento, "#,###,##0.00")
            If CInt(totalDescuento) <> 0 Then
                For i = 0 To (14 - totaldescCadena.Length)
                    salida = salida & " "
                Next
                salida = salida & totaldescCadena & vbCrLf
            Else
                For i = 0 To 14
                    salida = salida & " "
                Next
                salida = salida & vbCrLf
            End If

            salida = salida & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9)

            Dim totalimpCadena = Format(totalImpuesto, "#,###,##0.00")
            For i = 0 To (14 - totalimpCadena.Length)
                salida = salida & " "
            Next
            salida = salida & totalimpCadena & vbCrLf & vbCrLf

            salida = salida & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9)

            Dim totalgenCadena = Format(totalGeneral, "#,###,##0.00")
            For i = 0 To (14 - totalgenCadena.Length)
                salida = salida & " "
            Next
            salida = salida & totalgenCadena

            salida = salida & cFormFeed

            Dim nombreImpresora = _oLogicaVarios.ConsultarColumna("Imp_Factura")
            Dim nombrePc = _oLogicaVarios.ConsultarColumna("PC_Factura")
            Global.Imprime.Impresion.SendStringToPrinter("\\" & nombrePc & "\" & nombreImpresora, salida)
        End Sub

    End Class
End Namespace