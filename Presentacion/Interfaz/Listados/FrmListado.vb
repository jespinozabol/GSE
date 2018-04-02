Imports Entidades
Imports Logica_Negocios
Imports Presentacion.Interfaz.Facturas

Namespace Interfaz.Listados
    Public Class FrmListado

        Private ReadOnly _oLogicaListado As New LogicaListado
        Private ReadOnly _oLogicaProducto As New LogicaProducto
        Private ReadOnly _oUtilidades As New Utilidades
        Private ReadOnly _oLogicaImpuesto As New LogicaImpuesto
        Private _nombreViejo As String
        Private ReadOnly _listaDeschequeadas As New List(Of ListadoResumen)
        Private ReadOnly _listaChequeadas As New List(Of ListadoResumen)
        Private ReadOnly _oLogicaVarios As New LogicaVarios

        Private _varListado As New Listado
        Public Property OListado() As Listado
            Get
                Return _varListado
            End Get
            Set(ByVal value As Listado)
                _varListado = value
            End Set
        End Property


        Private _varTipoTransaccion As Boolean
        Public Property TipoTransaccion() As Boolean
            Get
                Return _varTipoTransaccion
            End Get
            Set(ByVal value As Boolean)
                _varTipoTransaccion = value
            End Set
        End Property

        Private Sub LimpiarCliente()
            txtNombre.Text = String.Empty
            _nombreViejo = ""
            txtId_Listado.Text = String.Empty
            txtTelfCliente.Text = String.Empty
            txtFechaCreacion.Text = String.Empty
            dgvClientes.Visible = False
            cmbAutorizados.Items.Clear()
            txtNombre.Focus()
        End Sub

        Private Sub dgvClientes_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvClientes.Click
            LlenarDatosCliente()
        End Sub

        Private Sub LlenarDatosCliente()
            With dgvClientes
                If Trim(txtId_Listado.Text) <> "" Then
                    _oLogicaListado.modificarBloqueo(CInt(txtId_Listado.Text), 0)
                End If
                Dim idListado = .Item(0, .CurrentRow.Index).Value
                LimpiarTodo()
                txtId_Listado.Text = idListado
                ActualizarCliente()
                .Visible = False
            End With
        End Sub

        Public Sub ActualizarCliente()
            oListado = New Listado
            oListado = _oLogicaListado.consultarPorIdConInfo(CInt(txtId_Listado.Text))

            If oListado.Bloqueo Then
                MsgBox("El listado esta abierto en otra ventana por lo que no puede ser abierto", MsgBoxStyle.Information)
                txtNombre.Text = String.Empty
                dgvClientes.Visible = False
                txtId_Listado.Text = String.Empty
                txtCantidad.Select()
            Else
                txtNombre.Text = OListado.NombreCliente
                _nombreViejo = OListado.NombreCliente
                txtTelfCliente.Text = OListado.Telefono
                txtFechaCreacion.Text = OListado.Fecha
                lblMostrarTotal.Text = OListado.TotalListado

                For i = 0 To OListado.ListaAutorizados.Count - 1
                    FrmEscojeAutorizado.dgvAutorizados.Rows.Add(OListado.ListaAutorizados(i).Nombre)
                    cmbAutorizados.Items.Add(OListado.ListaAutorizados(i).IdAutorizado.ToString + "- " + OListado.ListaAutorizados(i).Nombre + " Telf: " + OListado.ListaAutorizados(i).Telefono)
                Next

                FrmEscojeAutorizado.ShowDialog()
                lblMostrarTotal.Text = 0.0
                lblMostrarSubTotal.Text = 0.0
                lblTotalImpuesto.Text = 0.0

                For j = 0 To OListado.ListaResumen.Count - 1
                    Dim descripcionArticulo = _oLogicaProducto.ConsultarDescripcion(OListado.ListaResumen(j).Id_Producto)

                    Dim precio As Double
                    Dim oProducto = _oLogicaProducto.Consultar(OListado.ListaResumen(j).Id_Producto)

                    precio = _oUtilidades.PasarMoneda((oProducto.PrecioUnitario * ((oProducto.Ganancia / 100) + 1)))
                    precio = precio * OListado.ListaResumen(j).Cantidad

                    lblMostrarSubTotal.Text = CDbl(lblMostrarSubTotal.Text) + precio

                    If oProducto.Impuesto Then
                        Dim impuesto = precio * (CDbl(_oLogicaImpuesto.ConsultarImpuesto) / 100)
                        lblTotalImpuesto.Text = CDbl(lblTotalImpuesto.Text) + impuesto
                    End If

                    dgvProductos.Rows.Add(True, _oUtilidades.PasarMoneda(OListado.ListaResumen(j).Cantidad), OListado.ListaResumen(j).Id_Producto, descripcionArticulo)
                Next

                lblMostrarTotal.Text = CDbl(lblMostrarSubTotal.Text) + CDbl(lblTotalImpuesto.Text)

                lblMostrarTotal.Text = _oUtilidades.PasarMoneda(CDbl(lblMostrarTotal.Text))
                OListado.TotalListado = CDbl(lblMostrarTotal.Text)

                If dgvProductos.RowCount > 0 Then
                    dgvProductos.Rows(0).Selected = False
                    CalcularLineas(dgvProductos.Rows.Count)
                End If
                _oLogicaListado.ModificarBloqueo(CInt(txtId_Listado.Text), 1)
                txtCantidad.Select()

            End If

        End Sub

        Private Sub dgvClientes_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles dgvClientes.KeyDown
            If e.KeyValue = 13 Then
                LlenarDatosCliente()
            End If
        End Sub

        Private Sub LlenarProducto(ByVal oProducto As Producto)
            txtArticulo.Text = oProducto.Descripcion
            Dim existenciasListados = _oLogicaListado.ConsultarExistenciasPorProducto(oProducto.Id_Producto)
            txtExistInventario.Text = oProducto.Existencias - existenciasListados
            VerificarExistencias(txtExistInventario)
            If oProducto.Impuesto Then
                txtPrecio.Text = _oUtilidades.PasarMoneda((oProducto.PrecioUnitario * ((oProducto.Ganancia / 100) + 1)) * ((CDbl(_oLogicaImpuesto.ConsultarImpuesto) / 100) + 1))
            Else
                txtPrecio.Text = _oUtilidades.PasarMoneda((oProducto.PrecioUnitario * ((oProducto.Ganancia / 100) + 1)))
            End If
        End Sub

        Private Sub dgvMostrarProductos_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvMostrarProductos.Click
            txtCodigo.Text = dgvMostrarProductos.Item(0, dgvMostrarProductos.CurrentRow.Index).Value
            dgvMostrarProductos.DataSource = Nothing
            dgvMostrarProductos.Visible = False
            LlenarProducto(_oLogicaProducto.Consultar(CLng(txtCodigo.Text)))
            txtCantidad.Focus()
        End Sub

        Private Sub dgvMostrarProductos_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles dgvMostrarProductos.KeyDown
            If e.KeyData = Keys.Enter Then
                txtCodigo.Text = dgvMostrarProductos.Item(0, dgvMostrarProductos.CurrentRow.Index).Value
                dgvMostrarProductos.DataSource = Nothing
                dgvMostrarProductos.Visible = False
                LlenarProducto(_oLogicaProducto.Consultar(CLng(txtCodigo.Text)))
                txtCantidad.Focus()
            End If
        End Sub

        Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAgregar.Click
            If IsNumeric(txtCantidad.Text) And IsNumeric(txtPrecio.Text) Then
                If Not Trim(txtNombre.Text) = "" Then
                    Dim oProducto = _oLogicaProducto.Consultar(CLng(txtCodigo.Text))

                    If (BuscarArticulo(CLng(txtCodigo.Text))) Then
                        FrmExistenciasListado.lblExistencias.Text = BuscarTotalExistencias(CLng(txtCodigo.Text))
                        FrmExistenciasListado.ShowDialog()
                    Else
                        dgvProductos.Rows.Add(True, txtCantidad.Text, txtCodigo.Text, txtArticulo.Text)
                        Dim oListadoResumen As New ListadoResumen
                        oListadoResumen.Cantidad = CDbl(txtCantidad.Text)
                        oListadoResumen.Id_Producto = CInt(txtCodigo.Text)

                        Dim oListadoHistorial As New ListadoHistorial
                        oListadoHistorial.Cantidad = CDbl(txtCantidad.Text)
                        oListadoHistorial.Id_Producto = CInt(txtCodigo.Text)
                        oListadoHistorial.Fecha = Now.ToString("dd/MM/yyyy")

                        If cmbAutorizados.Items.Count > 0 Then
                            Dim cadena1 = Split(cmbAutorizados.SelectedItem, "-")
                            Dim cadena2 = Split(cadena1(1), ":")
                            oListadoHistorial.Retira = cadena2(0).Substring(0, cadena2(0).Length - 5)
                        Else
                            oListadoHistorial.Retira = txtNombre.Text
                        End If

                        oListadoHistorial.Hora = Now.ToString("H:mm:ss")

                        If Not txtId_Listado.Text = "" Then
                            oListadoHistorial.IdListado = CLng(txtId_Listado.Text)
                            oListadoResumen.IdListado = CLng(txtId_Listado.Text)
                        End If

                        OListado.ListaHistorial.Add(oListadoHistorial)
                        OListado.ListaResumen.Add(oListadoResumen)

                        dgvProductos.Rows(0).Selected = False
                        Dim precio As Double
                        precio = _oUtilidades.PasarMoneda((oProducto.PrecioUnitario * ((oProducto.Ganancia / 100) + 1)))
                        precio = precio * txtCantidad.Text

                        lblMostrarSubTotal.Text = CDbl(lblMostrarSubTotal.Text) + precio

                        If oProducto.Impuesto Then
                            Dim impuesto = precio * (CDbl(_oLogicaImpuesto.ConsultarImpuesto) / 100)
                            lblTotalImpuesto.Text = CDbl(lblTotalImpuesto.Text) + impuesto
                        End If
                        lblMostrarTotal.Text = _oUtilidades.PasarMoneda(CDbl(lblMostrarSubTotal.Text) + CDbl(lblTotalImpuesto.Text))
                       
                    End If

                    LimpiarProducto()
                    CalcularLineas(dgvProductos.Rows.Count)
                    txtCodigo.Text = String.Empty
                    txtCantidad.Text = 1
                    txtCantidad.Focus()
                Else
                    MessageBox.Show("Debe de escribir el nombre del cliente antes de agregar una linea", "Insertar nueva linea", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtNombre.Focus()
                End If

            Else
                MessageBox.Show("Datos imcompletos", "Insertar nueva linea", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Sub

        Private Sub LimpiarProducto()
            txtArticulo.Text = String.Empty
            txtPrecio.Text = String.Empty
            txtExistInventario.Text = String.Empty
            dgvMostrarProductos.Visible = False
            dgvMostrarProductos.DataSource = Nothing
            txtExistInventario.BackColor = System.Drawing.SystemColors.Window
            txtCodigo.Focus()
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
            ElseIf e.KeyData = Keys.Enter Then
                btnAgregar.Focus()
            End If
        End Sub

        Private Sub txtCantidad_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtCantidad.KeyDown
            If e.KeyValue = 13 Then
                txtCodigo.Focus()
            End If
        End Sub

        Private Function BuscarArticulo(ByVal codigoArticulo As Long) As Boolean
            Dim encontro = False
            With dgvProductos
                For i = 0 To .RowCount - 1
                    If (.Item(2, i).Value = codigoArticulo) Then
                        encontro = True
                    End If
                Next i
            End With
            Return encontro
        End Function

        Private Function BuscarTotalExistencias(ByVal codigoArticulo As Long) As Double
            With dgvProductos
                For i = 0 To .RowCount - 1
                    If (.Item(2, i).Value = codigoArticulo) Then
                        Return .Item(1, i).Value
                    End If
                Next i
            End With
            Return 0
        End Function

        Public Sub ActualizarCantidad(ByVal cant As Double, ByVal oListadoHistorial As ListadoHistorial)
            With dgvProductos
                For i = 0 To .RowCount - 1
                    If (.Item(2, i).Value = CLng(txtCodigo.Text)) Then
                        Dim cantAnterior = .Item(1, i).Value
                        .Item(1, i).Value = cant
                        Dim oProducto = _oLogicaProducto.Consultar(CLng(txtCodigo.Text))
                        If cant <> 0 Then
                            Dim precio As Double

                            If oProducto.Impuesto Then
                                precio = _oUtilidades.PasarMoneda((oProducto.PrecioUnitario * ((oProducto.Ganancia / 100) + 1)) * ((CDbl(_oLogicaImpuesto.ConsultarImpuesto) / 100) + 1))
                            Else
                                precio = _oUtilidades.PasarMoneda((oProducto.PrecioUnitario * ((oProducto.Ganancia / 100) + 1)))
                            End If

                            If TipoTransaccion = True Then
                                lblMostrarTotal.Text = _oUtilidades.PasarMoneda(_oUtilidades.ValorUtil(lblMostrarTotal.Text) + (precio * ((cant - cantAnterior))))
                            Else
                                lblMostrarTotal.Text = _oUtilidades.PasarMoneda(_oUtilidades.ValorUtil(lblMostrarTotal.Text) - (precio * ((cantAnterior - cant))))
                            End If
                        Else
                            For j = 0 To OListado.ListaResumen.Count - 1
                                If .Item(2, i).Value = OListado.ListaResumen(j).Id_Producto Then
                                    OListado.ListaResumen.RemoveAt(j)
                                    Exit For
                                End If
                            Next
                            .Rows.RemoveAt(i)
                            Dim precio As Double
                            If oProducto.Impuesto Then
                                precio = _oUtilidades.PasarMoneda((oProducto.PrecioUnitario * ((oProducto.Ganancia / 100) + 1)) * ((CDbl(_oLogicaImpuesto.ConsultarImpuesto) / 100) + 1))
                            Else
                                precio = _oUtilidades.PasarMoneda((oProducto.PrecioUnitario * ((oProducto.Ganancia / 100) + 1)))
                            End If
                            lblMostrarTotal.Text = _oUtilidades.PasarMoneda(_oUtilidades.ValorUtil(lblMostrarTotal.Text) - (precio * cantAnterior))
                        End If

                        Exit For
                    End If
                Next i


                OListado.ListaHistorial.Add(oListadoHistorial)

                If .RowCount > 0 Then .Rows(0).Selected = False
            End With
        End Sub

        Private Sub dgvProductos_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvProductos.Click
            With dgvProductos
                Try
                    If .CurrentRow.Index >= 0 Then

                        If .CurrentCell.ColumnIndex <> 0 Then

                            txtCantidad.Text = .Item(1, .CurrentRow.Index).Value
                            txtCodigo.Text = .Item(2, .CurrentRow.Index).Value
                            Dim oProducto = _oLogicaProducto.Consultar(CLng(txtCodigo.Text))
                            LlenarProducto(oProducto)

                             Dim precio As Double
                            precio = _oUtilidades.PasarMoneda((oProducto.PrecioUnitario * ((oProducto.Ganancia / 100) + 1)))
                            precio = precio * txtCantidad.Text

                            lblMostrarSubTotal.Text = CDbl(lblMostrarSubTotal.Text) - precio

                            If oProducto.Impuesto Then
                                Dim impuesto = precio * (CDbl(_oLogicaImpuesto.ConsultarImpuesto) / 100)
                                lblTotalImpuesto.Text = CDbl(lblTotalImpuesto.Text) - impuesto
                            End If
                            lblMostrarTotal.Text = _oUtilidades.PasarMoneda(CDbl(lblMostrarSubTotal.Text) + CDbl(lblTotalImpuesto.Text))

                            .Rows.RemoveAt(.CurrentRow.Index)
                            If .RowCount > 0 Then .Rows(0).Selected = False
                            txtCantidad.Focus()

                            Dim oListadoHistorial As New ListadoHistorial
                            oListadoHistorial.Cantidad = -CDbl(txtCantidad.Text)
                            oListadoHistorial.Id_Producto = CInt(txtCodigo.Text)
                            oListadoHistorial.Fecha = Now.ToString("dd/MM/yyyy")

                            If cmbAutorizados.Items.Count > 0 Then
                                Dim cadena1 = Split(cmbAutorizados.SelectedItem, "-")
                                Dim cadena2 = Split(cadena1(1), ":")
                                oListadoHistorial.Retira = cadena2(0).Substring(0, cadena2(0).Length - 5)
                            Else
                                oListadoHistorial.Retira = txtNombre.Text
                            End If

                            oListadoHistorial.Hora = Now.ToString("H:mm:ss")

                            If Not txtId_Listado.Text = "" Then
                                oListadoHistorial.IdListado = CLng(txtId_Listado.Text)
                            End If

                            OListado.ListaHistorial.Add(oListadoHistorial)
                        Else
                            Dim cell = CType(.CurrentRow.Cells(0), DataGridViewCheckBoxCell)

                            If .IsCurrentCellDirty Then
                                .CommitEdit(DataGridViewDataErrorContexts.Commit)
                            End If

                            Dim oProducto = _oLogicaProducto.Consultar(CLng(dgvProductos.Item(2, dgvProductos.CurrentRow.Index).Value))
                            Dim totalLinea As Double

                            If oProducto.Impuesto Then
                                totalLinea = _oUtilidades.PasarMoneda((oProducto.PrecioUnitario * ((oProducto.Ganancia / 100) + 1)) * ((_oLogicaImpuesto.ConsultarImpuesto / 100) + 1))
                            Else
                                totalLinea = _oUtilidades.PasarMoneda((oProducto.PrecioUnitario * ((oProducto.Ganancia / 100) + 1)))
                            End If
                            totalLinea = totalLinea * dgvProductos.Item(1, dgvProductos.CurrentRow.Index).Value

                            If cell.Value = True Then
                                chkTodos.Checked = False
                                lblMostrarTotalRestante.Text = _oUtilidades.PasarMoneda(CDbl(lblMostrarTotalRestante.Text) + totalLinea)
                                lblMostrarTotal.Text = _oUtilidades.PasarMoneda(CDbl(lblMostrarTotal.Text) - totalLinea)
                            Else
                                Dim chequeadas = 0
                                For i = 0 To dgvProductos.Rows.Count - 1
                                    If dgvProductos.Item(0, i).Value = True Then
                                        chequeadas += 1
                                    End If
                                Next
                                If chequeadas = dgvProductos.RowCount Then
                                    chkTodos.Checked = True
                                End If
                                lblMostrarTotalRestante.Text = _oUtilidades.PasarMoneda(CDbl(lblMostrarTotalRestante.Text) - totalLinea)
                                lblMostrarTotal.Text = _oUtilidades.PasarMoneda(CDbl(lblMostrarTotal.Text) + totalLinea)
                            End If
                            dgvProductos.CurrentCell.Selected = False
                        End If
                    End If
                Catch ex As Exception

                End Try

            End With
        End Sub

        Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnLimpiar.Click
            LimpiarTodo()
        End Sub

        Public Sub LimpiarTodo()
            If Trim(txtId_Listado.Text) <> "" Then
                _oLogicaListado.ModificarBloqueo(CInt(txtId_Listado.Text), 0)
            End If
            LimpiarCliente()
            LimpiarProducto()
            lblMostrarTotalRestante.Text = 0.0
            dgvProductos.Rows.Clear()
            lblMostrarTotal.Text = 0.0
            txtNombre.Focus()
            lblCantLineas.Text = 0
            lblNumFacturas.Text = 0
            txtCodigo.Text = String.Empty
            txtCantidad.Text = 1
            OListado = New Listado
        End Sub


        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            Guardar()
        End Sub

        Private Sub Guardar()
            Dim respuesta As String

            If ((txtNombre.Text <> "") And (dgvProductos.RowCount > 0)) Then

                If txtTelfCliente.Text <> "" Then
                    OListado.Telefono = txtTelfCliente.Text
                Else
                    OListado.Telefono = 0
                End If

                OListado.TotalListado = _oUtilidades.PasarMoneda(_oUtilidades.ValorUtil(lblMostrarTotal.Text))

                OListado.ListaResumen.Clear()

                With dgvProductos
                    For i = 0 To .RowCount - 1
                        Dim oResumen As New ListadoResumen
                        If Not txtId_Listado.Text = "" Then
                            oResumen.IdListado = CInt(txtId_Listado.Text)
                        End If
                        oResumen.Cantidad = .Item(1, i).Value
                        oResumen.Id_Producto = .Item(2, i).Value
                        OListado.ListaResumen.Add(oResumen)
                    Next i
                End With

                If (txtId_Listado.Text = "") Then
                    OListado.NombreCliente = UCase(txtNombre.Text)
                    OListado.Fecha = Now
                    _oLogicaListado.Insertar(OListado)
                    msgAutomatico.lblMensaje.Text = "Listado insertado con éxito..."
                    msgAutomatico.ShowDialog()
                Else
                    If txtNombre.Text <> _nombreViejo Then
                        respuesta = MsgBox("Está seguro que desea modificar el nombre", vbCritical + vbYesNo, "Modificar nombre...")
                        If (respuesta = vbYes) Then
                            OListado.NombreCliente = UCase(txtNombre.Text)
                        Else
                            OListado.NombreCliente = _nombreViejo
                        End If
                    End If
                    _oLogicaListado.Modificar(OListado)
                    msgAutomatico.lblMensaje.Text = "Listado modificado con éxito..."
                    msgAutomatico.ShowDialog()
                End If

                LimpiarTodo()

            Else
                MsgBox("Debe insertar el nombre y un producto como mínimo para guardar un listado", MsgBoxStyle.Exclamation)
            End If
        End Sub

        Private Sub btnAgregarAutorizado_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAgregarAutorizado.Click
            If Trim(txtNombre.Text) <> "" Then
                Dim cadena = Split(cmbAutorizados.SelectedItem, "-")

                If cadena(0) = "0" Then
                    If cmbAutorizados.SelectedIndex = 0 Then
                        FrmModificarAutorizado.txtId.Text = "a"
                    Else
                        FrmModificarAutorizado.txtId.Text = "b"
                    End If
                ElseIf cmbAutorizados.SelectedIndex > 0 Then
                    FrmModificarAutorizado.txtId.Text = cadena(0)
                Else
                    FrmModificarAutorizado.txtId.Text = "a"
                End If
                FrmModificarAutorizado.Existe_Autorizado()
                FrmModificarAutorizado.ShowDialog()
            Else
                MsgBox("Debe escribir el nombre del cliente antes de agregar un autorizado", MsgBoxStyle.Exclamation)
            End If


        End Sub

        Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnImprimir.Click
            If txtId_Listado.Text <> "" Then
                Dim imprime As Integer

                imprime = MessageBox.Show("Esta seguro que desea imprimir el listado?", "Imprimir listado", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If imprime = 6 Then
                    Dim listado = _oLogicaListado.ConsultarListadoImprimir(CInt(txtId_Listado.Text))

                    Dim reporte As New RptListado

                    Dim table As DataTable
                    Dim colum As DataColumn

                    table = New DataTable("rpt_LISTADO")

                    colum = New DataColumn("Cantidad")
                    table.Columns.Add(colum)
                    colum = New DataColumn("Id_Producto")
                    table.Columns.Add(colum)
                    colum = New DataColumn("Descripcion")
                    table.Columns.Add(colum)
                    colum = New DataColumn("PrecioUnitario")
                    table.Columns.Add(colum)
                    colum = New DataColumn("Ganancia")
                    table.Columns.Add(colum)
                    colum = New DataColumn("Impuesto", Type.GetType("System.Boolean"))
                    table.Columns.Add(colum)
                    colum = New DataColumn("Id_Listado")
                    table.Columns.Add(colum)

                    Dim paginas = _oUtilidades.CalculaPaginas((listado.Rows.Count + 3) / 25)

                    For i As Integer = 1 To paginas
                        table.Rows.Clear()
                        reporte.SetDataSource(guardarLineas((i * 25) - 25, listado, table))
                        reporte.SetParameterValue("numPagina", i)
                        reporte.SetParameterValue("paginas", paginas)
                        reporte.SetParameterValue("nombre", txtNombre.Text)
                        reporte.SetParameterValue("telefono", txtTelfCliente.Text)
                        reporte.SetParameterValue("fecha", txtFechaCreacion.Text)
                        reporte.SetParameterValue("numListado", txtId_Listado.Text)
                        reporte.SetParameterValue("imp", _oLogicaImpuesto.ConsultarImpuesto)

                        reporte.SetParameterValue("subTotal", CDbl(lblMostrarSubTotal.Text))
                        reporte.SetParameterValue("totalImpuesto", CDbl(lblTotalImpuesto.Text))
                        reporte.SetParameterValue("total", CDbl(lblMostrarTotal.Text) + CDbl(lblMostrarTotalRestante.Text))

                        Dim nombreImpresora = _oLogicaVarios.ConsultarColumna("Imp_Medio_Oficio")
                        Dim nombrePc = _oLogicaVarios.ConsultarColumna("PC_Medio_Oficio")
                        reporte.PrintOptions.PrinterName = "\\" & nombrePc & "\" & nombreImpresora
                        reporte.PrintToPrinter(1, False, 1, 1)
                    Next
                End If
            Else
                MsgBox("No existe ningún listado a imprimir", MsgBoxStyle.Exclamation)
            End If
        End Sub

        Private Function guardarLineas(ByVal inicio As Integer, ByVal listado As DataTable, ByVal table As DataTable) As DataTable
            Dim indice As Integer, final As Integer
            Dim fila As DataRow

            With listado
                If inicio + 25 < listado.Rows.Count Then ' reviso si aun quedan 14 o mas lineas
                    final = inicio + 25
                Else
                    final = listado.Rows.Count
                End If

                For indice = inicio To final - 1
                    fila = table.NewRow
                    fila.Item("Cantidad") = listado.Rows(indice).Item(0)
                    fila.Item("Id_Producto") = listado.Rows(indice).Item(1)
                    fila.Item("Descripcion") = listado.Rows(indice).Item(2)
                    fila.Item("PrecioUnitario") = listado.Rows(indice).Item(3)
                    fila.Item("Ganancia") = listado.Rows(indice).Item(4)
                    fila.Item("Impuesto") = listado.Rows(indice).Item(5)
                    fila.Item("Id_Listado") = listado.Rows(indice).Item(6)
                    table.Rows.Add(fila)
                Next indice

            End With

            Return table
        End Function

        Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnEliminar.Click
            Dim respuesta As String

            If (txtId_Listado.Text <> "") Then

                respuesta = MsgBox("Esta seguro que desea eliminar este listado?", vbQuestion + vbYesNo, "Eliminar Listado...")

                If dgvProductos.Rows.Count = 0 Then
                    If respuesta = vbYes Then
                        _oLogicaListado.Eliminar(CInt(txtId_Listado.Text))
                        msgAutomatico.lblMensaje.Text = "Listado eliminado con éxito..."
                        msgAutomatico.ShowDialog()
                        LimpiarTodo()
                    End If
                Else
                    MsgBox("Debe eliminar todos los productos antes de borrar el listado", MsgBoxStyle.Exclamation)
                End If
            Else
                MsgBox("No existe ningún listado a eliminar", MsgBoxStyle.Exclamation)
            End If
        End Sub

        Private Sub btnListadosPendientes_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnListadosPendientes.Click
            If Trim(txtId_Listado.Text) <> "" Then
                _oLogicaListado.ModificarBloqueo(CInt(txtId_Listado.Text), 1)
            End If
            FrmConsultaListados.Dispose()
            FrmConsultaListados.ShowDialog()
        End Sub

        Private Sub txtTelfCliente_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtTelfCliente.KeyDown
            If e.KeyData = Keys.Enter Then
                txtCantidad.Focus()
            End If
        End Sub

        Private Sub txtCantidad_Enter(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtCantidad.Enter
            If cmbAutorizados.Items.Count = 0 And Trim(txtNombre.Text) <> "" Then
                cmbAutorizados.Items.Add("0- " + UCase(txtNombre.Text) + " Telf:" + txtTelfCliente.Text)
                cmbAutorizados.SelectedIndex = 0
                Dim oAutorizado As New ListadoAutorizado
                oAutorizado.Nombre = UCase(txtNombre.Text)
                oAutorizado.Telefono = txtTelfCliente.Text
                OListado.ListaAutorizados.Add(oAutorizado)
            ElseIf cmbAutorizados.Items.Count > 0 And Trim(txtNombre.Text) <> "" Then
                Dim cadena = Split(cmbAutorizados.SelectedItem, "-")
                cmbAutorizados.Items.Item(0) = cadena(0) + "- " + UCase(txtNombre.Text) + " Telf:" + txtTelfCliente.Text
                OListado.ListaAutorizados(0).Nombre = UCase(txtNombre.Text)
                OListado.ListaAutorizados(0).Telefono = txtTelfCliente.Text
            End If
        End Sub

        Public Sub ActualizarAutorizados()
            cmbAutorizados.Items.Clear()
            For i = 0 To OListado.ListaAutorizados.Count - 1
                cmbAutorizados.Items.Add(OListado.ListaAutorizados(i).IdAutorizado.ToString + "- " + OListado.ListaAutorizados(i).Nombre + " Telf: " + OListado.ListaAutorizados(i).Telefono)
            Next
            cmbAutorizados.SelectedIndex = 0
        End Sub

        Private Sub txtTelfCliente_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtTelfCliente.KeyPress
            Dim keyAscii As Short = CShort(Asc(e.KeyChar))

            Dim texto As TextBox = sender

            Dim cant = texto.Text.Length
            Dim cant2 = texto.Text.Length

            If keyAscii = 8 Then
                cant = cant - 1
            Else
                cant = cant + 1
            End If

            keyAscii = CShort(_oUtilidades.SoloNumeros(keyAscii))

            If keyAscii = 0 Then e.Handled = True

            If cant = 4 And cant2 < cant Then
                texto.Text = texto.Text & e.KeyChar & "-"
                e.Handled = True
                texto.Select(texto.Text.Length, 0)
            End If
        End Sub

        Private Sub txtCantidad_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
            Dim keyAscii As Short = CShort(Asc(e.KeyChar))
            keyAscii = CShort(_oUtilidades.NumerosPunto(keyAscii))

            If keyAscii = 0 Then e.Handled = True
        End Sub

        Private Sub btnFacturar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnFacturar.Click
            If txtId_Listado.Text <> "" Then
                Dim respuesta As String
                respuesta = MsgBox("Esta seguro que desea facturar este listado?", vbYesNo, "Facturar Listado...")

                If respuesta = vbYes Then
                    FrmFacturar.IdTipo = CInt(txtId_Listado.Text)
                    For i = 0 To dgvProductos.Rows.Count - 1
                        Dim lineaResumen As New ListadoResumen
                        lineaResumen.Cantidad = dgvProductos.Item(1, i).Value
                        lineaResumen.Id_Producto = dgvProductos.Item(2, i).Value
                        lineaResumen.IdListado = txtId_Listado.Text

                        If dgvProductos.Item(0, i).Value = True Then

                            _listaChequeadas.Add(lineaResumen)
                        Else
                            _listaDeschequeadas.Add(lineaResumen)
                        End If
                    Next
                    Guardar()

                    If _listaDeschequeadas.Count = 0 Then
                        FrmFacturar.Tipo = 1
                    Else
                        FrmFacturar.Tipo = 4
                        FrmFacturar.ListaChequeada = _listaChequeadas
                        FrmFacturar.ListaDesChequeada = _listaDeschequeadas
                    End If

                    FrmFacturar.ShowDialog()
                    Dispose()
                End If
            Else
                MsgBox("Debe de escoger el listado antes de presionar facturar", MsgBoxStyle.Exclamation)
            End If
        End Sub

        Private Sub CalcularLineas(ByVal total As Integer)
            lblCantLineas.Text = total
            lblNumFacturas.Text = _oUtilidades.CalculaPaginas((total + 3) / 25)
        End Sub

        Private Sub FrmListado_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            If Trim(txtId_Listado.Text) <> "" Then
                _oLogicaListado.ModificarBloqueo(CInt(txtId_Listado.Text), 0)
            End If
            Dispose()
        End Sub

        Private Sub txtArticulo_Enter(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtArticulo.Enter
            If txtCodigo.Text <> "" Then
                txtArticulo.Text = String.Empty
                txtPrecio.Text = String.Empty
                txtExistInventario.Text = String.Empty
                txtCodigo.Text = String.Empty
                dgvMostrarProductos.Visible = False
                dgvMostrarProductos.DataSource = Nothing
                txtArticulo.Text = String.Empty
            End If
        End Sub

        Private Sub chkTodos_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkTodos.Click
            If chkTodos.Checked Then
                For i = 0 To dgvProductos.Rows.Count - 1
                    dgvProductos.Item(0, i).Value = True
                Next
                lblMostrarTotal.Text = _oUtilidades.PasarMoneda(CDbl(lblMostrarTotal.Text) + CDbl(lblMostrarTotalRestante.Text))
                lblMostrarTotalRestante.Text = _oUtilidades.PasarMoneda(0.0)
            Else
                For i = 0 To dgvProductos.Rows.Count - 1
                    dgvProductos.Item(0, i).Value = False
                Next
                lblMostrarTotalRestante.Text = _oUtilidades.PasarMoneda(CDbl(lblMostrarTotalRestante.Text) + CDbl(lblMostrarTotal.Text))
                lblMostrarTotal.Text = _oUtilidades.PasarMoneda(0.0)
            End If
        End Sub

        Private Sub txtNombre_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
            CambiarControlADataGrid(dgvClientes, e, txtNombre, txtCantidad, txtCantidad)
        End Sub

        Private Sub txtNombre_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
            BuscarListadoPorNombre(dgvClientes, e, txtNombre, txtId_Listado)
        End Sub

        Private Sub txtArticulo_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtArticulo.KeyPress
            BuscarProductoPorDescripcion(dgvMostrarProductos, e, txtArticulo, txtCodigo)
        End Sub

        Private Sub txtArticulo_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtArticulo.KeyDown
            CambiarControlADataGrid(dgvMostrarProductos, e, txtArticulo, txtCantidad, txtCantidad)
        End Sub

        Private Sub btnHistorial_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnHistorial.Click
            If txtId_Listado.Text <> "" Then
                FrmHistorialListados.ShowDialog()
            Else
                MsgBox("Debe de escoger el listado que desea ver el historial", MsgBoxStyle.Exclamation)
            End If
        End Sub
    End Class
End Namespace