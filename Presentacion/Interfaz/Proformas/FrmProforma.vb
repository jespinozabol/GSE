Imports Logica_Negocios
Imports Entidades
Imports Presentacion.Interfaz.Facturas

Namespace Interfaz.Proformas
    Public Class FrmProforma

        Private ReadOnly _oUtilidades As New Utilidades
        Private ReadOnly _oLogicaProducto As New LogicaProducto
        Private ReadOnly _oLogicaImpuesto As New LogicaImpuesto
        Private _impuesto As Double
        Private ReadOnly _oLogicaReferencia As New LogicaReferencia
        Private ReadOnly _oLogicaProforma As New LogicaProforma
        Private ReadOnly _oLogicaConsecutivo As New LogicaConsecutivo
        Private ReadOnly _oLogicaListado As New LogicaListado
        Private ReadOnly _oLogicaVarios As New LogicaVarios

        Private Sub chkReferencia_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkReferencia.CheckedChanged
            If chkReferencia.Checked Then
                lblId_Referencia.Visible = True
                txtId_Referencia.Visible = True
                lblNombre_Referencia.Visible = True
                txtNombre_Referencia.Visible = True
                txtId_Referencia.Focus()
            Else
                lblId_Referencia.Visible = False
                txtId_Referencia.Visible = False
                lblNombre_Referencia.Visible = False
                txtNombre_Referencia.Visible = False
                txtId_Referencia.Text = String.Empty
                txtNombre_Referencia.Text = String.Empty
            End If
        End Sub

        Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnLimpiar.Click
            LimpiarTodo()
            txtNombre.Focus()
        End Sub

        Private Sub LimpiarTodo()
            LimpiarCliente()
            LimpiarProducto()
            LimpiarTotales()
            txtCodigo.Text = String.Empty
            txtCantidad.Text = 1
            lblId_Referencia.Visible = False
            txtId_Referencia.Visible = False
            lblNombre_Referencia.Visible = False
            txtNombre_Referencia.Visible = False
            chkReferencia.Checked = False
            dgvProductos.Rows.Clear()
            chkImpuesto.Checked = False
            txtImpuesto.Visible = False
            chkDescuento.Checked = False
            txtDescuentoGen.Visible = False
            lblCantLineas.Text = String.Empty
            lblNumFacturas.Text = String.Empty
            chkMostrarDescuento.Checked = False
            Timer1.Enabled = True
            txtDescuentoGen.Text = 0.0
        End Sub

        Private Sub LimpiarCliente()
            txtId_Proforma.Text = String.Empty
            txtNombre.Text = String.Empty
            txtTelefono.Text = String.Empty
            dgvClientes.Visible = False
            txtNombre.Focus()
        End Sub

        Private Sub LimpiarProducto()
            txtArticulo.Text = String.Empty
            txtExistencias.Text = String.Empty
            txtPrecio.Text = String.Empty
            txtPrecioIVI.Text = String.Empty
            txtDescuento.Text = String.Empty
            dgvMostrarProductos.Visible = False
            dgvMostrarProductos.DataSource = Nothing
            txtExistencias.BackColor = System.Drawing.SystemColors.Window
            txtCodigo.Focus()
        End Sub

        Private Sub LimpiarTotales()
            lblMostrarDesc.Text = "0.00"
            lblMostrarIV.Text = "0.00"
            lblMostrarSubTotal.Text = "0.00"
            lblMostrarTotal.Text = "0.00"
        End Sub

        Private Sub txtCantidad_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtCantidad.KeyDown
            If e.KeyValue = 13 Then
                txtCodigo.Focus()
                txtCodigo.SelectAll()
            End If
        End Sub

        Private Sub LlenarProducto(ByVal oProducto As Producto)
            txtArticulo.Text = oProducto.Descripcion
            Dim existenciasListados = _oLogicaListado.consultarExistenciasPorProducto(oProducto.Id_Producto)
            txtExistencias.Text = oProducto.Existencias - existenciasListados
            txtPrecio.Text = _oUtilidades.PasarMoneda((oProducto.PrecioUnitario * ((oProducto.Ganancia / 100) + 1)))
            VerificarExistencias(txtExistencias)
            If IsNumeric(txtDescuentoGen.Text) Then
                If CInt(txtDescuentoGen.Text) > 0 Then
                    txtDescuento.Text = txtDescuentoGen.Text
                Else
                    txtDescuento.Text = 0
                End If
            Else
                txtDescuento.Text = 0
            End If

            Dim impuesto2 = _oLogicaImpuesto.consultarImpuesto
            If IsNumeric(txtImpuesto.Text) Then
                If CInt(txtImpuesto.Text) > 0 Then
                    impuesto2 = txtImpuesto.Text
                End If
            End If

            If oProducto.Impuesto Then
                txtPrecioIVI.Text = _oUtilidades.PasarMoneda((oProducto.PrecioUnitario * ((oProducto.Ganancia / 100) + 1)) * ((CDbl(impuesto2) / 100) + 1))
                _impuesto = impuesto2
            Else
                txtPrecioIVI.Text = _oUtilidades.PasarMoneda((oProducto.PrecioUnitario * ((oProducto.Ganancia / 100) + 1)))
                _impuesto = 0
            End If
        End Sub

        Private Sub txtDescuento_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtDescuento.KeyDown
            If e.KeyValue = 13 Then
                btnAgregar.Focus()
            End If
        End Sub

        Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAgregar.Click
            If IsNumeric(txtCantidad.Text) And IsNumeric(txtPrecio.Text) And IsNumeric(txtDescuento.Text) Then

                If (buscarArticulo(CLng(txtCodigo.Text))) Then
                    FrmExistenciasProforma.lblExistencias.Text = buscarTotalExistencias(CLng(txtCodigo.Text))
                    FrmExistenciasProforma.ShowDialog()
                Else
                    Dim subTotalLinea As Double

                    subTotalLinea = CalcularSubTotalProforma(CDbl(txtCantidad.Text), CDbl(txtPrecio.Text), CDbl(txtDescuento.Text), _impuesto)
                    dgvProductos.Rows.Add(txtCantidad.Text, txtCodigo.Text, txtArticulo.Text, _oUtilidades.PasarMoneda(txtPrecio.Text), _oUtilidades.PasarMoneda(txtDescuento.Text) & "%", _oUtilidades.PasarMoneda(_impuesto) & "%", _oUtilidades.PasarMoneda(subTotalLinea), 0)
                    dgvProductos.Rows(0).Selected = False

                    CalcularLineas(dgvProductos.Rows.Count)

                    Dim fila As Integer = dgvProductos.RowCount - 1

                    If fila <> -1 Then
                        dgvProductos.FirstDisplayedScrollingRowIndex = fila
                    End If

                End If

                LimpiarProducto()
                txtCodigo.Text = String.Empty
                txtCantidad.Text = 1
                txtCantidad.Focus()
            Else
                MessageBox.Show("Datos imcompletos", "Insertar nueva linea", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Sub


        Public Sub CalcularLineas(ByVal total As Integer)
            Dim lineas = Int((total / 23))

            lblCantLineas.Text = total
            lblNumFacturas.Text = lineas + 1
        End Sub

        Private Function BuscarArticulo(ByVal codigo As Long) As Boolean
            Dim encontro = False
            With dgvProductos
                For i = 0 To .RowCount - 1
                    If (.Item(1, i).Value = codigo) Then
                        encontro = True
                    End If
                Next i
            End With
            Return encontro
        End Function

        Private Function BuscarTotalExistencias(ByVal codigo As Long) As Double
            With dgvProductos
                For i = 0 To .RowCount - 1
                    If (.Item(1, i).Value = codigo) Then
                        Return .Item(0, i).Value
                    End If
                Next i
            End With
            Return 0
        End Function

        Private Sub dgvMostrarProductos_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvMostrarProductos.Click
            txtCodigo.Text = dgvMostrarProductos.Item(0, dgvMostrarProductos.CurrentRow.Index).Value
            dgvMostrarProductos.DataSource = Nothing
            dgvMostrarProductos.Visible = False
            LlenarProducto(_oLogicaProducto.Consultar(CLng(txtCodigo.Text)))
            txtDescuento.Focus()
        End Sub

        Private Sub dgvMostrarProductos_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles dgvMostrarProductos.KeyDown
            If e.KeyData = Keys.Enter Then
                txtCodigo.Text = dgvMostrarProductos.Item(0, dgvMostrarProductos.CurrentRow.Index).Value
                dgvMostrarProductos.DataSource = Nothing
                dgvMostrarProductos.Visible = False
                LlenarProducto(_oLogicaProducto.Consultar(CLng(txtCodigo.Text)))
                txtDescuento.Focus()
            End If
        End Sub

        Public Sub ActualizarCantidad(ByVal cantidad As Double)
            With dgvProductos
                For i = 0 To .RowCount - 1
                    If (.Item(1, i).Value = CLng(txtCodigo.Text)) Then
                        Dim cantAnterior = .Item(0, i).Value
                        .Item(0, i).Value = cantidad

                        SubTotalRestandoProforma(cantAnterior, CDbl(txtPrecio.Text), CDbl(_oUtilidades.QuitarSimboloPorcentaje(.Item(4, i).Value)), _impuesto)
                        Dim subTotalLinea = CalcularSubTotalProforma(cantidad, CDbl(txtPrecio.Text), CDbl(_oUtilidades.QuitarSimboloPorcentaje(.Item(4, i).Value)), _impuesto)
                        .Item(6, i).Value = _oUtilidades.PasarMoneda(subTotalLinea)
                        Exit For
                    End If
                Next i

                If .RowCount > 0 Then .Rows(0).Selected = False
            End With
        End Sub

        Private Sub chkDescuento_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkDescuento.CheckedChanged
            If chkDescuento.Checked Then
                txtDescuentoGen.Visible = True
                txtDescuentoGen.Text = _oUtilidades.PasarMoneda(0)
                txtDescuentoGen.Focus()
            Else
                txtDescuentoGen.Visible = False
            End If
        End Sub

        Private Sub chkImpuesto_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkImpuesto.CheckedChanged
            If chkImpuesto.Checked Then
                txtImpuesto.Visible = True
                txtImpuesto.Text = _oUtilidades.PasarMoneda(_oLogicaImpuesto.consultarImpuesto)
                txtImpuesto.Focus()
            Else
                txtImpuesto.Visible = False
            End If
        End Sub

        Private Sub txtDescuentoGen_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtDescuentoGen.KeyDown
            If e.KeyValue = 13 Then
                LimpiarTotales()
                If IsNumeric(txtDescuentoGen.Text) Then
                    With dgvProductos
                        If .RowCount > 0 Then
                            For i As Integer = 0 To .RowCount - 1
                                .Item(6, i).Value = _oUtilidades.PasarMoneda(CalcularSubTotalProforma(.Item(0, i).Value, .Item(3, i).Value, CDbl(txtDescuentoGen.Text), _oUtilidades.QuitarSimboloPorcentaje(.Item(5, i).Value)))
                                .Item(4, i).Value = _oUtilidades.PasarMoneda(txtDescuentoGen.Text) + "%"
                            Next
                        End If
                    End With

                    txtCantidad.Focus()
                End If
            End If
        End Sub

        Private Sub txtImpuesto_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtImpuesto.KeyDown
            If e.KeyValue = 13 Then
                LimpiarTotales()
                With dgvProductos
                    If .RowCount > 0 Then
                        For i As Integer = 0 To .RowCount - 1
                            Dim producto As Producto
                            producto = _oLogicaProducto.Consultar(.Item(1, i).Value)

                            If producto.Impuesto Then
                                .Item(6, i).Value = _oUtilidades.PasarMoneda(CalcularSubTotalProforma(.Item(0, i).Value, .Item(3, i).Value, _oUtilidades.QuitarSimboloPorcentaje(.Item(4, i).Value), CDbl(txtImpuesto.Text)))
                                .Item(5, i).Value = _oUtilidades.PasarMoneda(txtImpuesto.Text) + "%"
                            Else
                                .Item(6, i).Value = _oUtilidades.PasarMoneda(CalcularSubTotalProforma(.Item(0, i).Value, .Item(3, i).Value, _oUtilidades.QuitarSimboloPorcentaje(.Item(4, i).Value), 0))
                            End If
                        Next
                    End If
                End With

                txtCantidad.Focus()
            End If
        End Sub



        Private Sub txtId_Proforma_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtId_Proforma.KeyDown
            If e.KeyData = Keys.Enter Then
                If IsNumeric(txtId_Proforma.Text) Then
                    Dim oProformaEnc As Proforma

                    oProformaEnc = _oLogicaProforma.consultarPorId_ConInfo(CInt(txtId_Proforma.Text))

                    If oProformaEnc.NumProforma <> 0 Then
                        LlenarProforma(oProformaEnc)
                    Else
                        txtNombre.Text = String.Empty
                    End If

                End If
            End If
        End Sub

        Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnImprimir.Click
            Dim imprime As Integer
            imprime = MessageBox.Show("Esta seguro que desea imprimir esta proforma?", "Imprimir Proforma", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If imprime = vbYes Then
                GuardarTodo(True)
                LimpiarTodo()
            End If
        End Sub

        Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As EventArgs) Handles Timer1.Tick
            lblMostrarNumProforma.Text = _oLogicaConsecutivo.ConsultarMaxConsecutivo("CONSECUTIVO_PROFORMA") + 1
        End Sub

        Private Sub LlenarProforma(ByVal oProformaEnc As Proforma)
            txtNombre.Text = oProformaEnc.Cliente
            txtTelefono.Text = Trim(oProformaEnc.Telefono)

            If oProformaEnc.IdReferencia > 1 Then
                chkReferencia.Checked = True
                Dim nombReferencia = _oLogicaReferencia.ConsultarNombrePor_IdReferencia(oProformaEnc.IdReferencia)
                txtId_Referencia.Text = oProformaEnc.IdReferencia
                txtNombre_Referencia.Text = nombReferencia
            End If

            dgvProductos.Rows.Clear()
            For i As Integer = 0 To oProformaEnc.ProformaDetalles.Count - 1
                Dim oProducto = _oLogicaProducto.Consultar(oProformaEnc.ProformaDetalles(i).IdProducto)
                Dim precioArticulo As Double

                precioArticulo = _oUtilidades.PasarMoneda(oProformaEnc.ProformaDetalles(i).PrecioUnitario)

                If oProducto.Impuesto Then
                    _impuesto = oProformaEnc.ProformaDetalles(i).Impuesto
                Else
                    _impuesto = 0
                End If

                Dim subTotalLinea As Double

                subTotalLinea = CalcularSubTotalProforma(oProformaEnc.ProformaDetalles(i).Cantidad, precioArticulo, oProformaEnc.ProformaDetalles(i).Descuento, _impuesto)

                dgvProductos.Rows.Add(_oUtilidades.PasarMoneda(oProformaEnc.ProformaDetalles(i).Cantidad), oProformaEnc.ProformaDetalles(i).IdProducto, oProducto.Descripcion, _oUtilidades.PasarMoneda(precioArticulo), oProformaEnc.ProformaDetalles(i).Descuento & "%", _oUtilidades.PasarMoneda(_impuesto) & "%", _oUtilidades.PasarMoneda(subTotalLinea))
                dgvProductos.Rows(0).Selected = False
                CalcularLineas(dgvProductos.RowCount)
                txtCantidad.Focus()
            Next

            Timer1.Enabled = False
            lblMostrarNumProforma.Text = txtId_Proforma.Text
        End Sub

        Private Sub txtNombre_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
            CambiarControlADataGrid(dgvClientes, e, txtNombre, txtTelefono, txtCantidad)
        End Sub

        Private Sub txtNombre_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
            BuscarProformaPorNombre(dgvClientes, e, txtNombre, txtId_Proforma)
        End Sub

        Private Sub dgvClientes_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvClientes.Click
            LlenarIdProforma()
        End Sub

        Private Sub dgvClientes_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles dgvClientes.KeyDown
            If e.KeyData = Keys.Enter Then
                LlenarIdProforma()
            End If
        End Sub

        Private Sub LlenarIdProforma()
            With dgvClientes
                txtId_Proforma.Text = .Item(0, .CurrentRow.Index).Value
                Dim oProformaEnc As Proforma

                oProformaEnc = _oLogicaProforma.consultarPorId_ConInfo(CInt(txtId_Proforma.Text))
                LlenarProforma(oProformaEnc)
                .Visible = False
            End With
        End Sub

        Private Sub txtId_Proforma_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtId_Proforma.Click
            LimpiarTodo()
            txtId_Proforma.Focus()
        End Sub

        Private Sub GuardarTodo(ByVal imprime As Boolean)

            If Trim(txtNombre.Text) = "" Then
                MessageBox.Show("Datos imcompletos, Debe agregar el nombre del cliente", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf dgvProductos.RowCount = 0 Then
                MessageBox.Show("Datos imcompletos, Debe agregar al menos un producto", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim oProforma As New Proforma

                _oLogicaProforma.RevisaBloqueo()

                _oLogicaProforma.Bloqueo(True)

                If Trim(txtId_Proforma.Text) = "" Then
                    oProforma.NumProforma = CInt(lblMostrarNumProforma.Text)
                Else
                    oProforma.NumProforma = CInt(txtId_Proforma.Text)
                End If

                oProforma.Cliente = UCase(txtNombre.Text)
                oProforma.Fecha = CDate(Now.ToString("dd/MM/yyyy"))

                If IsNumeric(txtId_Referencia.Text) Then
                    oProforma.IdReferencia = CInt(txtId_Referencia.Text)
                Else
                    oProforma.IdReferencia = 1
                End If

                If Trim(txtTelefono.Text) = "" Then
                    oProforma.Telefono = 0
                Else
                    oProforma.Telefono = (txtTelefono.Text)
                End If

                Dim oldProforma = _oLogicaProforma.consultarPorId_ConInfo(oProforma.NumProforma)
                With dgvProductos
                    For i = 0 To .RowCount - 1
                        Dim oProformaDetalle As New ProformaDetalle
                        oProformaDetalle.NumProforma = oProforma.NumProforma
                        Dim idProducto, precioUnitario, cantidad, impuesto
                        Dim descuento, tDescuento, tImpuesto

                        idProducto = .Item(1, i).Value
                        cantidad = .Item(0, i).Value
                        impuesto = _oUtilidades.QuitarSimboloPorcentaje(.Item(5, i).Value)
                        descuento = _oUtilidades.QuitarSimboloPorcentaje(.Item(4, i).Value)

                        If Not IsNothing(oldProforma) Then
                            Dim detalle = (From n In oldProforma.ProformaDetalles
                                          Select n Where n.IdProducto = idProducto).FirstOrDefault
                            If Not IsNothing(detalle) Then
                                precioUnitario = detalle.PrecioUnitario
                            Else
                                Dim Producto = _oLogicaProducto.Consultar(idProducto)
                                precioUnitario = (Producto.PrecioUnitario * ((Producto.Ganancia / 100) + 1))
                            End If
                        Else
                            Dim Producto = _oLogicaProducto.Consultar(idProducto)
                            precioUnitario = (Producto.PrecioUnitario * ((Producto.Ganancia / 100) + 1))
                        End If

                        tDescuento = _oUtilidades.PasarMoneda((cantidad * precioUnitario) * (descuento / 100))
                        tImpuesto = (_oUtilidades.PasarMoneda((cantidad * precioUnitario) - tDescuento) * (impuesto / 100))

                        oProformaDetalle.IdProducto = idProducto
                        oProformaDetalle.PrecioUnitario = precioUnitario
                        oProformaDetalle.Cantidad = cantidad
                        oProformaDetalle.Impuesto = impuesto
                        oProformaDetalle.Descuento = descuento
                        oProformaDetalle.Tdescuento = tDescuento
                        oProformaDetalle.Timpuesto = tImpuesto
                        oProforma.ProformaDetalles.Add(oProformaDetalle)
                    Next i
                End With

                If Trim(txtId_Proforma.Text) = "" Then
                    _oLogicaProforma.Insertar(oProforma)
                    txtId_Proforma.Text = lblMostrarNumProforma.Text
                    Dim oConsecutivo As New Consecutivo
                    oConsecutivo.Tabla = "CONSECUTIVO_PROFORMA"
                    _oLogicaConsecutivo.AumentarConsecutivo(oConsecutivo)

                    lblMostrarNumProforma.Text = _oLogicaConsecutivo.ConsultarMaxConsecutivo("CONSECUTIVO_PROFORMA") + 1
                Else
                    _oLogicaProforma.Modificar(oProforma)
                End If

                _oLogicaProforma.Bloqueo(False)

                If imprime Then
                    Cursor.Current = Cursors.WaitCursor
                    Imprimir(1)
                    Cursor.Current = Cursors.Default
                End If
            End If
        End Sub

        'Si tipo = 1 imprime, tipo = 2 exporta
        Private Sub Imprimir(ByVal tipo As Integer)

            Dim proforma = _oLogicaProforma.consultarProformaImprimir(CInt(txtId_Proforma.Text))

            Dim reporte As New RptProforma

            Dim table As DataTable
            Dim colum As DataColumn

            table = New DataTable("rpt_PROFORMA")

            colum = New DataColumn("Cantidad", Type.GetType("System.Single"))
            table.Columns.Add(colum)
            colum = New DataColumn("Id_Producto")
            table.Columns.Add(colum)
            colum = New DataColumn("Descripcion")
            table.Columns.Add(colum)
            colum = New DataColumn("Descuento", Type.GetType("System.Single"))
            table.Columns.Add(colum)
            colum = New DataColumn("PrecioUnitario", Type.GetType("System.Single"))
            table.Columns.Add(colum)
            colum = New DataColumn("Tdescuento", Type.GetType("System.Single"))
            table.Columns.Add(colum)
            colum = New DataColumn("Timpuesto", Type.GetType("System.Single"))
            table.Columns.Add(colum)

            Dim paginas = _oUtilidades.CalculaPaginas((proforma.Rows.Count + 4) / 25)

            For i As Integer = 1 To paginas
                table.Rows.Clear()
                reporte.SetDataSource(guardarLineas((i * 25) - 25, proforma, table))
                reporte.SetParameterValue("numPagina", i)
                reporte.SetParameterValue("paginas", paginas)
                reporte.SetParameterValue("nombre", txtNombre.Text)
                reporte.SetParameterValue("telefono", txtTelefono.Text)
                reporte.SetParameterValue("numProforma", "#" & txtId_Proforma.Text)
                reporte.SetParameterValue("subTotal", CDbl(lblMostrarSubTotal.Text))


                reporte.SetParameterValue("totalImpuesto", CDbl(lblMostrarIV.Text))
                reporte.SetParameterValue("total", CDbl(lblMostrarTotal.Text))

                If chkMostrarDescuento.Checked Then
                    reporte.SetParameterValue("desc", "True")
                    reporte.SetParameterValue("totalDescuento", "")
                Else
                    reporte.SetParameterValue("desc", "False")
                    reporte.SetParameterValue("totalDescuento", "¢" & _oUtilidades.PasarMoneda(lblMostrarDesc.Text))
                End If

                If tipo = 1 Then
                    Dim nombreImpresora = _oLogicaVarios.ConsultarColumna("Imp_Medio_Oficio")
                    Dim nombrePc = _oLogicaVarios.ConsultarColumna("PC_Medio_Oficio")
                    reporte.PrintOptions.PrinterName = "\\" & nombrePc & "\" & nombreImpresora
                    reporte.PrintToPrinter(1, False, 1, 1)
                ElseIf tipo = 2 Then
                    FrmReportesComprobantes.crvListado.ReportSource = reporte
                    FrmReportesComprobantes.ShowDialog()
                End If
            Next

        End Sub

        Private Function guardarLineas(ByVal inicio As Integer, ByVal proforma As DataTable, ByVal table As DataTable) As DataTable
            Dim indice As Integer, final As Integer
            Dim fila As DataRow

            With proforma
                If inicio + 25 < proforma.Rows.Count Then
                    final = inicio + 25
                Else
                    final = proforma.Rows.Count
                End If

                For indice = inicio To final - 1
                    fila = table.NewRow
                    fila.Item("Cantidad") = proforma.Rows(indice).Item(0)
                    fila.Item("Id_Producto") = proforma.Rows(indice).Item(1)
                    fila.Item("Descripcion") = proforma.Rows(indice).Item(2)
                    fila.Item("Descuento") = proforma.Rows(indice).Item(3)
                    fila.Item("PrecioUnitario") = proforma.Rows(indice).Item(4)
                    fila.Item("Tdescuento") = proforma.Rows(indice).Item(5)
                    fila.Item("Timpuesto") = proforma.Rows(indice).Item(6)
                    table.Rows.Add(fila)
                Next indice

            End With

            Return table
        End Function

        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            GuardarTodo(False)
            LimpiarTodo()
        End Sub

        Private Sub btnFacturar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnFacturar.Click
            GuardarTodo(False)

            If txtId_Proforma.Text <> "" And txtNombre.Text <> "" Then
                Dim respuesta As String
                respuesta = MsgBox("Va a facturar una proforma, desea actualizar los precios?", vbYesNoCancel, "Actualizar precios...")

                If respuesta <> vbCancel Then
                    If respuesta = vbYes Then
                        FrmFacturar.Respuesta = True
                    Else
                        FrmFacturar.Respuesta = False
                    End If
                    FrmFacturar.Tipo = 2
                    FrmFacturar.IdTipo = CInt(txtId_Proforma.Text)
                    Dispose()
                    FrmFacturar.ShowDialog()
                End If
            End If
        End Sub

        Private Sub dgvProductos_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvProductos.Click
            With dgvProductos
                If .RowCount > 0 Then
                    txtCodigo.Text = .Item(1, .CurrentRow.Index).Value
                    txtCantidad.Text = .Item(0, .CurrentRow.Index).Value
                    LlenarProducto(_oLogicaProducto.Consultar(CLng(txtCodigo.Text)))
                    SubTotalRestandoProforma(.Item(0, .CurrentRow.Index).Value, CDbl(txtPrecio.Text), _oUtilidades.QuitarSimboloPorcentaje(.Item(4, .CurrentRow.Index).Value), _oUtilidades.QuitarSimboloPorcentaje(.Item(5, .CurrentRow.Index).Value))
                    txtDescuento.Text = _oUtilidades.QuitarSimboloPorcentaje(.Item(4, .CurrentRow.Index).Value)
                    .Rows.RemoveAt(.CurrentRow.Index)
                    If .RowCount > 0 Then .Rows(0).Selected = False
                    CalcularLineas(dgvProductos.Rows.Count)
                    txtCantidad.Focus()
                End If
            End With
        End Sub

        Private Sub FrmProforma_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub

        Private Sub txtArticulo_Enter(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtArticulo.Enter
            If txtCodigo.Text <> "" Then
                txtExistencias.Text = String.Empty
                txtPrecio.Text = String.Empty
                txtPrecioIVI.Text = String.Empty
                txtDescuento.Text = String.Empty
                txtCodigo.Text = String.Empty
                txtArticulo.Text = String.Empty
                dgvMostrarProductos.Visible = False
                dgvMostrarProductos.DataSource = Nothing
            End If
        End Sub

        Private Sub txtNombre_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtNombre.Click
            If txtId_Proforma.Text <> "" Then
                LimpiarTodo()
                txtNombre.Focus()
            End If

        End Sub

        Private Sub txtTelefono_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtTelefono.KeyDown
            If e.KeyValue = Keys.Enter Then
                txtCantidad.Focus()
            End If
        End Sub

        Private Sub btnCorregirNombre_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCorregirNombre.Click
            If Trim(txtId_Proforma.Text <> "") Then
                Dim myValue As String = InputBox("Modifique el nombre", "Modificar nombre", txtNombre.Text)

                If myValue <> "" Then
                    txtNombre.Text = myValue
                End If
            End If
        End Sub

        Private Sub FrmProforma_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            AddHandler txtTelefono.KeyPress, AddressOf FormatoNumTelefono

            AddHandler txtCodigo.KeyPress, AddressOf ValidarNumerosPunto
            AddHandler txtCantidad.KeyPress, AddressOf ValidarNumerosPunto
            AddHandler txtDescuento.KeyPress, AddressOf ValidarNumerosPunto
        End Sub

        Private Sub txtId_Referencia_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtId_Referencia.KeyPress
            Dim keyAscii As Short = CShort(Asc(e.KeyChar))
            If Not keyAscii = 13 Then
                Dim oReferencia = BuscarReferenciaPorId(e, txtId_Referencia)
                If oReferencia.IdReferencia <> 0 Then
                    txtNombre_Referencia.Text = oReferencia.Nombre
                Else
                    txtNombre_Referencia.Text = ""
                End If
            End If
        End Sub

        Private Sub txtId_Referencia_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtId_Referencia.KeyDown
            If e.KeyData = Keys.Enter And txtNombre_Referencia.Text <> "" Then
                txtCantidad.Focus()
            End If
        End Sub

        Private Sub txtCodigo_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
            Dim keyAscii As Short = CShort(Asc(e.KeyChar))
            If keyAscii <> 13 Then
                Dim oProducto = BuscarProductoPorCodigo(e, txtCodigo)
                If oProducto.Id_Producto <> 0 Then
                    LlenarProducto(oProducto)
                Else
                    LimpiarProducto()
                End If
            End If
        End Sub

        Private Sub txtCodigo_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
            If e.KeyData = Keys.Enter And txtArticulo.Text = "" Then
                txtArticulo.Focus()
                txtCodigo.Text = String.Empty
            ElseIf e.KeyData = Keys.Enter Then
                txtDescuento.Focus()
            End If
        End Sub

        Private Sub txtArticulo_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtArticulo.KeyDown
            CambiarControlADataGrid(dgvMostrarProductos, e, txtArticulo, txtCantidad, txtDescuento)
        End Sub

        Private Sub txtArticulo_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtArticulo.KeyPress
            BuscarProductoPorDescripcion(dgvMostrarProductos, e, txtArticulo, txtCodigo)
        End Sub

        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnExportar.Click
            If Trim(txtNombre.Text) = "" Then
                MessageBox.Show("Datos imcompletos, Debe agregar el nombre del cliente", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf dgvProductos.RowCount = 0 Then
                MessageBox.Show("Datos imcompletos, Debe agregar al menos un producto", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Imprimir(2)
            End If
        End Sub
    End Class
End Namespace