Imports Entidades
Imports Logica_Negocios

Namespace Interfaz.Creditos
    Public Class FrmNotaCredito

        Private ReadOnly _oLogicaFactura As New LogicaFacturar
        Private ReadOnly _oUtilidades As New Utilidades
        Private _fila As Integer
        Private ReadOnly _oLogicaConsecutivo As New LogicaConsecutivo
        Private ReadOnly _oLogicaNc As New LogicaNotaCredito
        Private ReadOnly _oLogicaClienteCredito As New LogicaClienteCredito
        Private ReadOnly _oLogicaVarios As New LogicaVarios

        Private Sub FrmNota_Credito_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            Dim oListaDetalles As List(Of FacturaDetalle)
            dgvFactura.Rows.Clear()

            oListaDetalles = _oLogicaFactura.consultarFacturaDetalle(CInt(txtNumFactura.Text))

            With oListaDetalles
                For i As Integer = 0 To .Count - 1
                    Dim precio = (oListaDetalles(i).Cantidad * oListaDetalles(i).PrecioUnitario)
                    Dim subTotalLinea = precio - (precio * (oListaDetalles(i).Descuento / 100)) + (precio * (oListaDetalles(i).Impuesto / 100))
                    dgvFactura.Rows.Add(oListaDetalles(i).Cantidad, oListaDetalles(i).Id_Producto, oListaDetalles(i).Descripcion, _oUtilidades.PasarMoneda(oListaDetalles(i).PrecioUnitario), _oUtilidades.PasarMoneda(oListaDetalles(i).Descuento) & "%", _oUtilidades.PasarMoneda(oListaDetalles(i).Impuesto) & "%", _oUtilidades.PasarMoneda(subTotalLinea))
                Next
            End With

            AddHandler txtCantidad.KeyPress, AddressOf ValidarNumerosPunto
            AddHandler txtNum_Impresiones.KeyPress, AddressOf ValidarSoloNumeros
        End Sub

        Private Sub dgvFactura_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvFactura.Click
            With dgvFactura
                txtCantidad.Text = .CurrentRow.Cells(0).Value
                txtCodigo.Text = .CurrentRow.Cells(1).Value
                txtArticulo.Text = .CurrentRow.Cells(2).Value
                _fila = .CurrentRow.Index
                txtCantidad.Focus()
            End With
        End Sub

        Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAgregar.Click
            With dgvFactura
                If txtCantidad.Text <> "" Then
                    If CDbl(txtCantidad.Text) > 0 And CDbl(txtCantidad.Text) <= .Item(0, _fila).Value Then
                        If CDbl(txtCantidad.Text) = .Item(0, _fila).Value Then

                            Dim index = estaProducto(.CurrentRow.Cells(1).Value, dgvNotaCredito)
                            If index >= 0 Then
                                dgvNotaCredito.CurrentRow.Cells(0).Value = dgvNotaCredito.CurrentRow.Cells(0).Value + .CurrentRow.Cells(0).Value
                                Dim subTotalLinea = CDbl(dgvNotaCredito.CurrentRow.Cells(6).Value) + CDbl(.CurrentRow.Cells(6).Value)
                                dgvNotaCredito.CurrentRow.Cells(6).Value = _oUtilidades.PasarMoneda(subTotalLinea)
                            Else
                                dgvNotaCredito.Rows.Add(.CurrentRow.Cells(0).Value, .CurrentRow.Cells(1).Value, .CurrentRow.Cells(2).Value, .CurrentRow.Cells(3).Value, .CurrentRow.Cells(4).Value, .CurrentRow.Cells(5).Value, _oUtilidades.PasarMoneda(.CurrentRow.Cells(6).Value))
                            End If
                            lblMostrarTotal.Text = _oUtilidades.PasarMoneda(CDbl(lblMostrarTotal.Text) + .CurrentRow.Cells(6).Value)
                            .Rows.RemoveAt(.CurrentRow.Index)
                        Else

                            'subtotal de la linea de la nota de credito
                            Dim precio = .CurrentRow.Cells(3).Value * CDbl(txtCantidad.Text)
                            Dim desc = .CurrentRow.Cells(4).Value.ToString.Substring(0, .CurrentRow.Cells(4).Value.ToString.Length - 1)
                            Dim impuesto = .CurrentRow.Cells(5).Value.ToString.Substring(0, .CurrentRow.Cells(5).Value.ToString.Length - 1)
                            Dim subTotalLinea = precio - (precio * (CDbl(desc) / 100)) + (precio * (CDbl(impuesto) / 100))
                            dgvNotaCredito.Rows.Add(txtCantidad.Text, .CurrentRow.Cells(1).Value, .CurrentRow.Cells(2).Value, .CurrentRow.Cells(3).Value, .CurrentRow.Cells(4).Value, .CurrentRow.Cells(5).Value, _oUtilidades.PasarMoneda(subTotalLinea))

                            lblMostrarTotal.Text = _oUtilidades.PasarMoneda(CDbl(lblMostrarTotal.Text) + subTotalLinea)
                            .CurrentRow.Cells(0).Value = .CurrentRow.Cells(0).Value - CDbl(txtCantidad.Text)

                            'subtotal que queda en la linea de la factura
                            precio = .CurrentRow.Cells(3).Value * .CurrentRow.Cells(0).Value
                            subTotalLinea = precio - (precio * (CDbl(desc) / 100)) + (precio * (CDbl(impuesto) / 100))
                            .CurrentRow.Cells(6).Value = _oUtilidades.PasarMoneda(subTotalLinea)

                        End If

                        LimpiarLinea()
                    Else
                        MsgBox("La cantidad debe ser mayor a cero y menor o igual a la cantidad facturada", MsgBoxStyle.Exclamation)
                    End If
                End If


            End With
        End Sub

        Private Sub LimpiarLinea()
            txtCantidad.Text = String.Empty
            txtCodigo.Text = String.Empty
            txtArticulo.Text = String.Empty
            If dgvNotaCredito.Rows.Count > 0 Then dgvNotaCredito.Rows(0).Selected = False
            If dgvFactura.Rows.Count > 0 Then dgvFactura.Rows(0).Selected = False
        End Sub

        Private Sub dgvNotaCredito_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvNotaCredito.Click

            With dgvNotaCredito
                Try
                    If .CurrentRow.Index >= 0 Then

                        Dim index = estaProducto(.CurrentRow.Cells(1).Value, dgvFactura)
                        If index >= 0 Then
                            dgvFactura.CurrentRow.Cells(0).Value = dgvFactura.CurrentRow.Cells(0).Value + .CurrentRow.Cells(0).Value
                            dgvFactura.CurrentRow.Cells(6).Value = dgvFactura.CurrentRow.Cells(6).Value + .CurrentRow.Cells(6).Value
                        Else
                            dgvFactura.Rows.Add(.CurrentRow.Cells(0).Value, .CurrentRow.Cells(1).Value, .CurrentRow.Cells(2).Value, .CurrentRow.Cells(3).Value, .CurrentRow.Cells(4).Value, .CurrentRow.Cells(5).Value, .CurrentRow.Cells(6).Value)
                        End If
                        lblMostrarTotal.Text = _oUtilidades.PasarMoneda(CDbl(lblMostrarTotal.Text) - .CurrentRow.Cells(6).Value)
                        .Rows.RemoveAt(.CurrentRow.Index)

                        If dgvNotaCredito.Rows.Count > 0 Then dgvNotaCredito.Rows(0).Selected = False
                        If dgvFactura.Rows.Count > 0 Then dgvFactura.Rows(0).Selected = False
                    End If
                Catch ex As Exception

                End Try


            End With
        End Sub

        Private Function estaProducto(ByVal codigo As Integer, ByVal dataGrid As DataGridView) As Integer

            With dataGrid
                For i As Integer = 0 To .Rows.Count - 1
                    If .Item(1, i).Value = codigo Then
                        Return i
                    End If
                Next
            End With

            Return -1
        End Function

        Private Sub timerNota_Tick(ByVal sender As System.Object, ByVal e As EventArgs) Handles timerNota.Tick
            lblMostrarReciboNotas.Text = _oLogicaConsecutivo.ConsultarMaxConsecutivo("CONSECUTIVO_NC") + 1
        End Sub

        Private Sub btnNota_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNota.Click
            If dgvNotaCredito.Rows.Count > 0 Then
                If dgvNotaCredito.Rows.Count < 7 Then
                    Dim respuesta As String

                    respuesta = MsgBox("Esta seguro que desea imprimir esta nota de crédito?", vbCritical + vbYesNo, "Realizar Transacción...")

                    If (respuesta = vbYes) Then
                        _oLogicaNc.RevisaBloqueo()
                        _oLogicaNc.Bloqueo(True)

                        Dim oNotaCredito As New NotaCredito
                        oNotaCredito.IdNC = CInt(lblMostrarReciboNotas.Text)
                        oNotaCredito.NumFactura = CInt(txtNumFactura.Text)
                        oNotaCredito.Fecha = Now.ToString("dd/MM/yyyy")
                        oNotaCredito.Monto = CDbl(lblMostrarTotal.Text)
                        oNotaCredito.Estado = NotaCredito.ListaEstado.Pendiente

                        With dgvNotaCredito
                            For i As Integer = 0 To .Rows.Count - 1
                                Dim notaDetalle As New NotaCreditoDetalle
                                notaDetalle.IdNC = oNotaCredito.IdNC
                                notaDetalle.Cantidad = CDbl(.Item(0, i).Value)
                                notaDetalle.Id_Producto = CInt(.Item(1, i).Value)
                                notaDetalle.Descripcion = .Item(2, i).Value
                                notaDetalle.PrecioUnitario = CDbl(.Item(3, i).Value)

                                Dim desc = .Item(4, i).Value.ToString.Substring(0, .Item(4, i).Value.ToString.Length - 1)
                                Dim impuesto = .Item(5, i).Value.ToString.Substring(0, .Item(5, i).Value.ToString.Length - 1)

                                notaDetalle.Descuento = desc
                                notaDetalle.Impuesto = impuesto
                                notaDetalle.Tdescuento = _oUtilidades.PasarMoneda((notaDetalle.Cantidad * notaDetalle.PrecioUnitario) * (notaDetalle.Descuento / 100))
                                notaDetalle.Timpuesto = (_oUtilidades.PasarMoneda((notaDetalle.Cantidad * notaDetalle.PrecioUnitario) - notaDetalle.Tdescuento) * (notaDetalle.Impuesto / 100))
                                oNotaCredito.NCDetalles.Add(notaDetalle)
                            Next
                        End With

                        _oLogicaNc.insertar(oNotaCredito)

                        Dim oCliente As New ClienteCredito
                        oCliente.IdCredito = CInt(txtId_Credito.Text)
                        oCliente.TotalCreditos = CDbl(lblMostrarTotal.Text)
                        _oLogicaClienteCredito.restaTotal_Creditos(oCliente)

                        imprimeNota_Credito(oNotaCredito.IdNC)

                        Dim oConsecutivoNotaCredito As New Consecutivo
                        oConsecutivoNotaCredito.Tabla = "CONSECUTIVO_NC"
                        _oLogicaConsecutivo.AumentarConsecutivo(oConsecutivoNotaCredito)

                        _oLogicaNc.Bloqueo(False)

                        FrmFacturaCredito.dgvFacturas.Rows.Clear()
                        FrmFacturaCredito.CargarDatos(CInt(FrmFacturaCredito.txtId_Credito.Text))
                        Dispose()
                    End If
                Else
                    MsgBox("Una nota de crédito no puede contener más de 6 líneas", MsgBoxStyle.Exclamation)
                End If
            Else
                MsgBox("Debe agregar primero un producto a la nota de crédito", MsgBoxStyle.Exclamation)
            End If
        End Sub

        Private Sub imprimeNota_Credito(ByVal numNota As Integer)

            Dim notaCredito = _oLogicaNc.consultar(numNota)

            Dim reporte As New RptNota_Credito
            reporte.SetDataSource(notaCredito.NCDetalles)

            reporte.SetParameterValue("cliente", txtNombreCliente.Text)
            reporte.SetParameterValue("numNota", "#" & lblMostrarReciboNotas.Text)
            reporte.SetParameterValue("motivo", "Nota de crédito a factura #" & txtNumFactura.Text)
            reporte.SetParameterValue("fecha", Now.Date)

            Dim copias = _oUtilidades.NumCopias(txtNum_Impresiones.Text, 2)
            Dim nombreImpresora = _oLogicaVarios.ConsultarColumna("Imp_Tercio_Oficio")
            Dim nombrePc = _oLogicaVarios.ConsultarColumna("PC_Tercio_Oficio")
            reporte.PrintOptions.PrinterName = "\\" & nombrePc & "\" & nombreImpresora
            reporte.PrintToPrinter(copias, False, 1, 1)
        End Sub

        Private Sub txtCantidad_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtCantidad.KeyDown
            If e.KeyValue = 13 Then btnAgregar.Focus()
        End Sub

        Private Sub chkImpresion_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkImpresion.CheckedChanged
            If chkImpresion.Checked Then
                txtNum_Impresiones.Enabled = False
                txtNum_Impresiones.ReadOnly = True
                txtNum_Impresiones.Text = 2
            Else
                txtNum_Impresiones.Enabled = True
                txtNum_Impresiones.ReadOnly = False
                txtNum_Impresiones.Focus()
            End If
        End Sub

        Private Sub FrmNota_Credito_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub
    End Class
End Namespace