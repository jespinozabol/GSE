Imports Entidades
Imports Logica_Negocios
Imports Presentacion.Interfaz.Catalogo
Imports Presentacion.Interfaz.Mantenimiento
Imports Presentacion.Reportes

Namespace Interfaz.Facturas
    Public Class FrmFacturar
        Private ReadOnly _oLogicaConsecutivo As New LogicaConsecutivo
        Private ReadOnly _oUtilidades As New Utilidades
        Private _oPersona As New Persona
        Private ReadOnly _oLogicaPersona As New LogicaPersona
        Private ReadOnly _oLogicaReferencia As New LogicaReferencia
        Private ReadOnly _oLogicaProducto As New LogicaProducto
        Private ReadOnly _oLogicaImpuesto As New LogicaImpuesto
        Private ReadOnly _oLogicaFactura As New LogicaFacturar
        Private _impuesto As Double
        Private ReadOnly _oLogicaListado As New LogicaListado
        Private ReadOnly _oLogicaProforma As New LogicaProforma
        Private ReadOnly _oLogicaFacturaCredito As New LogicaFacturaCredito
        Private ReadOnly _oLogicaFlujo As New LogicaFlujoCaja
        Public OFlujoCaja As New FlujoCaja
        Private ReadOnly _oLogicaTipoCredito As New LogicaTipoCredito
        Private ReadOnly _oLogicaClienteCredito As New LogicaClienteCredito
        Public ListaChequeada As New List(Of ListadoResumen)
        Public ListaDesChequeada As New List(Of ListadoResumen)
        Public Respuesta As Boolean

        ''' <summary>
        ''' 1 = Listado
        ''' 2 = Factura
        ''' 3 = Recuperando Factura
        ''' 4 = ListadoChequeado
        ''' </summary>
        ''' <remarks></remarks>
        Private _varTipo As Integer
        Public Property Tipo() As Integer
            Get
                Return _varTipo
            End Get
            Set(ByVal value As Integer)
                _varTipo = value
            End Set
        End Property

        'True = acepto, False = Cancelo
        Private _varEstadoFlujoCaja As Boolean
        Public Property EstadoFlujoCaja() As Boolean
            Get
                Return _varEstadoFlujoCaja
            End Get
            Set(ByVal value As Boolean)
                _varEstadoFlujoCaja = value
            End Set
        End Property

        Private _varIdTipo As Integer
        Public Property IdTipo() As Integer
            Get
                Return _varIdTipo
            End Get
            Set(ByVal value As Integer)
                _varIdTipo = value
            End Set
        End Property

        Private Sub FrmFacturar_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load

            rbContado.Checked = True
            txtFecha.Text = Now.ToString("dd/MM/yyyy")
            EstadoFlujoCaja = False
            txtImpuesto.Text = _oLogicaImpuesto.consultarImpuesto

            AddHandler txtId_Cliente.KeyPress, AddressOf ValidarSoloNumeros
            AddHandler txtId_Referencia.KeyPress, AddressOf ValidarSoloNumeros
            AddHandler txtDiasPlazo.KeyPress, AddressOf ValidarSoloNumeros

            AddHandler txtImpuesto.KeyPress, AddressOf ValidarNumerosPunto
            AddHandler txtCantidad.KeyPress, AddressOf ValidarNumerosPunto
            AddHandler txtDescuento.KeyPress, AddressOf ValidarNumerosPunto
            AddHandler txtDescuentoGen.KeyPress, AddressOf ValidarNumerosPunto
            txtImpuesto.Text = _oUtilidades.PasarMoneda(_oLogicaImpuesto.consultarImpuesto)

            If Tipo = 1 Or Tipo = 4 Then
                Dim listado = _oLogicaListado.consultarPorIdConInfo(IdTipo)
                lblNombreTipo.Text = listado.NombreCliente
                lblNombreTipo.Visible = True
                lblMensajeTipo.Text = "Esta facturando un listado"
                lblMensajeTipo.Visible = True

                If Tipo = 4 Then
                    listado.ListaResumen = Nothing
                    listado.ListaResumen = ListaChequeada
                End If

                For i As Integer = 0 To listado.ListaResumen.Count - 1
                    Dim oProducto = _oLogicaProducto.Consultar(listado.ListaResumen(i).Id_Producto)
                    Dim precioArticulo As Double

                    precioArticulo = _oUtilidades.PasarMoneda((oProducto.PrecioUnitario * ((oProducto.Ganancia / 100) + 1)))

                    If oProducto.Impuesto Then
                        _impuesto = CDbl(txtImpuesto.Text)
                    Else
                        _impuesto = 0
                    End If

                    Dim subTotalLinea As Double

                    subTotalLinea = CalcularSubTotal(listado.ListaResumen(i).Cantidad, precioArticulo, 0, _impuesto)

                    dgvProductos.Rows.Add(listado.ListaResumen(i).Cantidad, listado.ListaResumen(i).Id_Producto, oProducto.Descripcion, _oUtilidades.PasarMoneda(precioArticulo), "0%", _oUtilidades.PasarMoneda(_impuesto) & "%", _oUtilidades.PasarMoneda(subTotalLinea))
                    dgvProductos.Rows(0).Selected = False
                    CalcularLineas(dgvProductos.RowCount)
                Next
                txtCantidad.Focus()
            ElseIf Tipo = 2 Then
                Dim proforma = _oLogicaProforma.consultarPorId_ConInfo(IdTipo)
                lblNombreTipo.Text = proforma.Cliente
                lblNombreTipo.Visible = True

                lblMensajeTipo.Text = "Esta facturando una proforma"
                lblMensajeTipo.Visible = True

                For i As Integer = 0 To proforma.ProformaDetalles.Count - 1
                    Dim oProducto = _oLogicaProducto.Consultar(proforma.ProformaDetalles(i).IdProducto)

                    Dim precioArticulo As Double

                    If Respuesta Then
                        precioArticulo = _oUtilidades.PasarMoneda((oProducto.PrecioUnitario * ((oProducto.Ganancia / 100) + 1)))
                        lblMensajeTipo2.Text = "Los precios han sido actualizados"
                    Else
                        precioArticulo = _oUtilidades.PasarMoneda(proforma.ProformaDetalles(i).PrecioUnitario)
                        lblMensajeTipo2.Text = "Los precios no han sido actualizados"
                    End If

                    lblMensajeTipo2.Visible = True

                    If oProducto.Impuesto Then
                        _impuesto = proforma.ProformaDetalles(i).Impuesto
                    Else
                        _impuesto = 0
                    End If

                    Dim subTotalLinea As Double

                    subTotalLinea = CalcularSubTotal(proforma.ProformaDetalles(i).Cantidad, precioArticulo, proforma.ProformaDetalles(i).Descuento, _impuesto)

                    dgvProductos.Rows.Add(proforma.ProformaDetalles(i).Cantidad, proforma.ProformaDetalles(i).IdProducto, oProducto.Descripcion, _oUtilidades.PasarMoneda(precioArticulo), proforma.ProformaDetalles(i).Descuento & "%", _oUtilidades.PasarMoneda(_impuesto) & "%", _oUtilidades.PasarMoneda(subTotalLinea))
                    dgvProductos.Rows(0).Selected = False
                    CalcularLineas(dgvProductos.RowCount)
                Next

                txtCantidad.Focus()
            ElseIf Tipo = 3 Then
                Dim factura = _oLogicaFactura.ConsultarFactura(IdTipo)

                Dim actualizarPrecios As String = MsgBox("Está recuperando una factura, desea actualizar los precios?", vbCritical + vbYesNo, "Eliminar Listado...")

                txtId_Cliente.Text = factura.IdPersona
                ActualizarCliente()

                If factura.IdReferencia > 1 Then
                    chkReferencia.Checked = True
                    txtId_Referencia.Text = factura.IdReferencia
                    Dim nombreReferencia = _oLogicaReferencia.ConsultarNombrePor_IdReferencia(factura.IdReferencia)
                    txtNombre_Referencia.Text = nombreReferencia
                End If

                If factura.Contado Then
                    rbContado.Checked = True
                Else
                    rbCredito.Checked = True
                End If

                For i As Integer = 0 To factura.FacturaDetalles.Count - 1
                    Dim oProducto = _oLogicaProducto.Consultar(factura.FacturaDetalles(i).Id_Producto)

                    If oProducto.Impuesto Then
                        _impuesto = factura.FacturaDetalles(i).Impuesto
                    Else
                        _impuesto = 0
                    End If

                    Dim precioArticulo As Double

                    Select Case actualizarPrecios
                        Case vbYes
                            precioArticulo = _oUtilidades.PasarMoneda((oProducto.PrecioUnitario * ((oProducto.Ganancia / 100) + 1)))
                            lblMensajeTipo2.Text = "Los precios han sido actualizados"
                        Case Else
                            precioArticulo = _oUtilidades.PasarMoneda(factura.FacturaDetalles(i).PrecioUnitario)
                            lblMensajeTipo2.Text = "Los precios no han sido actualizados"
                    End Select

                    lblMensajeTipo.Text = "Se anuló la factura # " & factura.NumFactura
                    lblMensajeTipo.Visible = True
                    lblMensajeTipo2.Visible = True

                    Dim subTotalLinea As Double

                    subTotalLinea = CalcularSubTotal(factura.FacturaDetalles(i).Cantidad, precioArticulo, factura.FacturaDetalles(i).Descuento, _impuesto)

                    dgvProductos.Rows.Add(factura.FacturaDetalles(i).Cantidad, factura.FacturaDetalles(i).Id_Producto, oProducto.Descripcion, _oUtilidades.PasarMoneda(precioArticulo), factura.FacturaDetalles(i).Descuento & "%", _oUtilidades.PasarMoneda(_impuesto) & "%", _oUtilidades.PasarMoneda(subTotalLinea))
                    dgvProductos.Rows(0).Selected = False
                    CalcularLineas(dgvProductos.RowCount)
                Next

                txtCantidad.SelectAll()
            End If

            txtCantidad.Focus()
        End Sub

        Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As EventArgs) Handles Timer.Tick
            lblMostrarNumFactura.Text = _oLogicaConsecutivo.ConsultarMaxConsecutivo("CONSECUTIVO_FACTURA") + 1
        End Sub

        Private Sub txtApellidos_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtApellidos.Click
            If txtNombre.Text <> "" And txtId_Cliente.Text = "" Then
                txtApellidos.Focus()
                dgvClientes.Visible = False
            Else
                LimpiarCliente()
            End If
        End Sub

        Private Sub txtCedula_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtCedula.Click
            LimpiarCliente()
        End Sub

        Private Sub txtNombre_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtNombre.Click
            LimpiarCliente()
        End Sub

        Private Sub LimpiarCliente()
            txtId_Cliente.Text = String.Empty
            txtNombre.Text = String.Empty
            txtApellidos.Text = String.Empty
            txtCedula.Text = String.Empty
            dgvClientes.Visible = False
            txtNombre.Focus()
        End Sub

        Private Sub txtApellidos_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtApellidos.KeyDown
            If e.KeyValue = 13 Then txtCedula.Focus()
        End Sub

        Private Sub txtId_Cliente_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtId_Cliente.KeyPress
            Dim keyAscii As Short = CShort(Asc(e.KeyChar))
            If Not keyAscii = 13 Then
                Dim oPersona = BuscarPersonaPorId(e, txtId_Cliente)
                If oPersona.IdPersona <> 0 Then
                    txtNombre.Text = oPersona.Nombre
                    txtApellidos.Text = oPersona.PrimerApellido & " " & oPersona.SegundoApellido
                    txtCedula.Text = oPersona.Cedula

                    Dim oCliente = _oLogicaClienteCredito.ConsultarPorIdPersona(oPersona.IdPersona)
                    ActualizarDatosCredito(oCliente)
                Else
                    lblMostrarEstado.Text = String.Empty
                    lblMostrarTipo.Text = String.Empty
                    lblMostrarDisponible.Text = String.Empty
                    lblMostrarDias.Text = String.Empty
                    txtNombre.Text = String.Empty
                    txtApellidos.Text = String.Empty
                    txtCedula.Text = String.Empty
                End If
            End If
        End Sub

        Private Sub txtId_Cliente_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtId_Cliente.KeyDown
            If e.KeyData = Keys.Enter And txtNombre.Text = "" Then
                txtNombre.Focus()
            ElseIf e.KeyData = Keys.Enter Then
                txtCantidad.Focus()
            End If
        End Sub

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
            txtImpuesto.Text = _oLogicaImpuesto.ConsultarImpuesto
            chkDescuento.Checked = False
            txtDescuentoGen.Visible = False
            rbContado.Checked = True
            Tipo = 0
            EstadoFlujoCaja = False
            txtFecha.Text = Now.ToString("dd/MM/yyyy")
            lblNombreTipo.Visible = False
            lblMensajeTipo.Visible = False
            lblMensajeTipo2.Visible = False
            lblCantLineas.Text = String.Empty
            lblNumFacturas.Text = String.Empty
            txtDescuentoGen.Text = 0.0
            txtNombre.Focus()
            lblMostrarDisponible.Text = String.Empty
            lblMostrarTipo.Text = String.Empty
            lblMostrarEstado.Text = String.Empty
            lblMostrarDias.Text = String.Empty
            pnCredito.Visible = False
        End Sub

        Private Sub dgvClientes_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvClientes.Click
            LlenarDatosCliente()
        End Sub

        Private Sub dgvClientes_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles dgvClientes.KeyDown
            If e.KeyValue = 13 Then
                LlenarDatosCliente()
            End If
        End Sub

        Private Sub LlenarDatosCliente()
            With dgvClientes
                txtId_Cliente.Text = .Item(0, .CurrentRow.Index).Value
                ActualizarCliente()
                .Visible = False
            End With
        End Sub

        Private Sub btnCorregir_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCorregir.Click
            If txtId_Cliente.Text <> "" Then
                FrmModificarCliente.IdCliente = CInt(txtId_Cliente.Text)
                FrmModificarCliente.Formulario = 1
                FrmModificarCliente.ShowDialog()
            Else
                MessageBox.Show("Debe de seleccionar un cliente antes de presionar corregir", "Corregir cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Sub

        Public Sub ActualizarCliente()
            _oPersona = New Persona
            _oPersona = _oLogicaPersona.Consultar(CInt(txtId_Cliente.Text))

            txtCedula.Text = _oPersona.Cedula
            txtNombre.Text = _oPersona.Nombre
            txtApellidos.Text = _oPersona.PrimerApellido + " " + _oPersona.SegundoApellido

            Dim oCliente = _oLogicaClienteCredito.ConsultarPorIdPersona(_oPersona.IdPersona)
           
            ActualizarDatosCredito(oCliente)
            txtCantidad.Focus()
        End Sub

        Private Sub ActualizarDatosCredito(ByVal oCliente As ClienteCredito)
            If oCliente.IdCredito <> 0 Then
                Dim oClienteCredito As New ClienteCredito
                Dim lista = _oUtilidades.calcularDatos_Cliente(oCliente.IdCredito)

                oClienteCredito.IdCredito = oCliente.IdCredito
                oClienteCredito.DiasAtrasado = lista(0)
                oClienteCredito.TotalAtrasado = lista(1)
                oClienteCredito.TotalCreditos = lista(2)

                _oLogicaClienteCredito.actualizarDatos_Credito(oClienteCredito)

                pnCredito.Visible = True

                If oCliente.Tipo = ClienteCredito.ListaTipo.Normal Then
                    lblMostrarTipo.Text = "Normal"
                ElseIf oCliente.Tipo = ClienteCredito.ListaTipo.Preferencial Then
                    lblMostrarTipo.Text = "Prefer"
                ElseIf oCliente.Tipo = ClienteCredito.ListaTipo.Prueba Then
                    lblMostrarTipo.Text = "Prueba"
                End If

                VerificarEstadoCredito()
            Else
                rbContado.Checked = True
                lblMostrarEstado.Text = "No tiene"
                lblMostrarTipo.Text = String.Empty
                lblMostrarDisponible.Text = String.Empty
            End If
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

        Private Sub txtCantidad_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtCantidad.KeyDown
            If e.KeyValue = 13 Then
                txtCodigo.Focus()
                txtCodigo.SelectAll()
            End If
        End Sub

        Private Sub LimpiarProducto()
            txtArticulo.Text = String.Empty
            txtExistencias.Text = String.Empty
            txtPrecio.Text = String.Empty
            txtPrecioIVI.Text = String.Empty
            txtDescuento.Text = String.Empty
            txtExistencias.BackColor = SystemColors.Window
            dgvMostrarProductos.Visible = False
            dgvMostrarProductos.DataSource = Nothing
            txtCodigo.Focus()
        End Sub

        Private Sub dgvMostrarProductos_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvMostrarProductos.Click
            MostrarProductos()
        End Sub

        Private Sub dgvMostrarProductos_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles dgvMostrarProductos.KeyDown
            If e.KeyData = Keys.Enter Then
                MostrarProductos()
            End If
        End Sub

        Private Sub MostrarProductos()
            txtCodigo.Text = dgvMostrarProductos.Item(0, dgvMostrarProductos.CurrentRow.Index).Value
            dgvMostrarProductos.DataSource = Nothing
            dgvMostrarProductos.Visible = False
            LlenarProducto(_oLogicaProducto.Consultar(CLng(txtCodigo.Text)))
            txtCantidad.Focus()
        End Sub

        Private Sub LlenarProducto(ByVal oProducto As Producto)
            txtArticulo.Text = oProducto.Descripcion
            Dim existenciasListados = _oLogicaListado.ConsultarExistenciasPorProducto(oProducto.Id_Producto)
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

            Dim impuesto2 = _oLogicaImpuesto.ConsultarImpuesto
            If IsNumeric(txtImpuesto.Text) Then
                If CInt(txtImpuesto.Text) > 0 Then
                    impuesto2 = txtImpuesto.Text
                Else
                    impuesto2 = 0
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

                If (BuscarArticulo(CLng(txtCodigo.Text))) Then
                    FrmExistenciasFactura.lblExistencias.Text = BuscarTotalExistencias(CLng(txtCodigo.Text))
                    FrmExistenciasFactura.ShowDialog()
                Else
                    Dim subTotalLinea As Double

                    subTotalLinea = CalcularSubTotal(CDbl(txtCantidad.Text), CDbl(txtPrecio.Text), CDbl(txtDescuento.Text), _impuesto)

                    dgvProductos.Rows.Add(txtCantidad.Text, txtCodigo.Text, txtArticulo.Text, _oUtilidades.PasarMoneda(txtPrecio.Text), _oUtilidades.PasarMoneda(txtDescuento.Text) & "%", _oUtilidades.PasarMoneda(_impuesto) & "%", _oUtilidades.PasarMoneda(subTotalLinea), "")
                    dgvProductos.Rows(0).Selected = False

                    If (CDbl(txtExistencias.Text) - CDbl(txtCantidad.Text)) < 0 Then
                        dgvProductos.Item(7, dgvProductos.Rows.Count - 1).Style.BackColor = Color.Red
                    End If

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

        Private Sub dgvProductos_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvProductos.Click
            With dgvProductos
                If .RowCount > 0 Then
                    txtCodigo.Text = .Item(1, .CurrentRow.Index).Value
                    txtCantidad.Text = .Item(0, .CurrentRow.Index).Value
                    Dim producto As Producto
                    producto = _oLogicaProducto.Consultar(CLng(txtCodigo.Text))
                    LlenarProducto(producto)
                    SubTotalRestando(.Item(0, .CurrentRow.Index).Value, .Item(3, .CurrentRow.Index).Value, _oUtilidades.QuitarSimboloPorcentaje(.Item(4, .CurrentRow.Index).Value), _oUtilidades.QuitarSimboloPorcentaje(.Item(5, .CurrentRow.Index).Value))
                    txtDescuento.Text = _oUtilidades.QuitarSimboloPorcentaje(.Item(4, .CurrentRow.Index).Value)
                    .Rows.RemoveAt(.CurrentRow.Index)
                    If .RowCount > 0 Then .Rows(0).Selected = False
                    CalcularLineas(dgvProductos.Rows.Count)
                    txtCantidad.Focus()
                End If
            End With
        End Sub


        Private Sub chkImpuesto_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkImpuesto.CheckedChanged
            If chkImpuesto.Checked Then
                txtImpuesto.Visible = True
                txtImpuesto.Text = _oUtilidades.PasarMoneda(_oLogicaImpuesto.ConsultarImpuesto)
                txtImpuesto.Focus()
            Else
                txtImpuesto.Visible = False
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
                                .Item(6, i).Value = _oUtilidades.PasarMoneda(CalcularSubTotal(.Item(0, i).Value, .Item(3, i).Value, _oUtilidades.QuitarSimboloPorcentaje(.Item(4, i).Value), CDbl(txtImpuesto.Text)))
                                .Item(5, i).Value = _oUtilidades.PasarMoneda(txtImpuesto.Text) + "%"
                            Else
                                .Item(6, i).Value = _oUtilidades.PasarMoneda(CalcularSubTotal(.Item(0, i).Value, .Item(3, i).Value, _oUtilidades.QuitarSimboloPorcentaje(.Item(4, i).Value), 0))
                            End If
                        Next
                    End If
                End With

                txtCantidad.Focus()
            End If
        End Sub

        Private Sub LimpiarTotales()
            lblMostrarDesc.Text = "0.00"
            lblMostrarIV.Text = "0.00"
            lblMostrarSubTotal.Text = "0.00"
            lblMostrarTotal.Text = "0.00"
        End Sub

        Private Sub rbCredito_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbCredito.CheckedChanged
            If rbCredito.Checked Then
                If Trim(txtId_Cliente.Text) <> "" Then
                    ActualizarCliente()
                    If lblMostrarEstado.Text = "Abierto" Then
                        DarCredito()
                        txtDiasPlazo.Focus()
                    ElseIf lblMostrarEstado.Text = "Cerrado" Then
                        rbContado.Checked = True
                        MsgBox("El crédito de este cliente ha sido cerrado")
                    ElseIf lblMostrarEstado.Text = "Congelado" Then
                        rbContado.Checked = True
                        MsgBox("El crédito de este cliente ha sido congelado, debe activarlo si desea facturar a crédito")
                    ElseIf lblMostrarEstado.Text = "Suspendido" Then
                        rbContado.Checked = True
                        MsgBox("El cliente tiene facturas vencidas")
                    Else
                        rbContado.Checked = True
                        MsgBox("Este cliente no tiene crédito, debe asignarle un crédito antes de facturar")
                    End If
                Else
                    rbContado.Checked = True
                End If
            End If
        End Sub

        Private Sub DarCredito()
            If lblMostrarDias.ForeColor = Color.Red And lblMostrarDisponible.ForeColor = Color.Red Then
                rbContado.Checked = True
                MsgBox("El número de días de atraso y el limite de crédito es superior al permitido", MsgBoxStyle.Exclamation)
            ElseIf lblMostrarDias.ForeColor = Color.Red Then
                rbContado.Checked = True
                MsgBox("El cliente tiene facturas con plazo mayor al permitido", MsgBoxStyle.Exclamation)
            ElseIf lblMostrarDisponible.ForeColor = Color.Red Then
                rbContado.Checked = True
                MsgBox("El limite de crédito es superior al permitido", MsgBoxStyle.Exclamation)
            Else
                lblDiasPlazo.Visible = True
                txtDiasPlazo.Visible = True
            End If
        End Sub

        'evento 1-clic
        Private Sub VerificarEstadoCredito()
            If lblMostrarTipo.Text = "Prefer" Then
                lblMostrarTipo.Text = "Preferencial"
            End If

            Dim tipoCredito = _oLogicaTipoCredito.ConsultarDato(lblMostrarTipo.Text)
            Dim clienteCredito = _oLogicaClienteCredito.ConsultarPorIdPersona(CInt(txtId_Cliente.Text))

            lblMostrarDias.Text = clienteCredito.DiasAtrasado
            Dim limite = (tipoCredito.Limite) * clienteCredito.Limite

            If clienteCredito.Estado = clienteCredito.ListaEstado.Cerrado Then
                lblMostrarEstado.Text = clienteCredito.Estado.ToString
                lblMostrarEstado.ForeColor = Color.Red
                lblMostrarTipo.ForeColor = Color.Red
                lblDisponible.Text = "Deuda"
                lblMostrarDisponible.ForeColor = Color.Red
                lblMostrarDisponible.Text = "¢" + _oUtilidades.PasarMoneda(clienteCredito.TotalCreditos)
                lblMostrarDias.ForeColor = Color.Red
            ElseIf clienteCredito.Estado = clienteCredito.ListaEstado.Congelado Then
                lblMostrarEstado.Text = clienteCredito.Estado.ToString
                lblMostrarEstado.ForeColor = Color.Red
                lblMostrarTipo.ForeColor = Color.Yellow
                lblDisponible.Text = "Deuda"
                lblMostrarDisponible.ForeColor = Color.Yellow
                If (clienteCredito.TotalCreditos > 0) Then
                    lblMostrarDisponible.ForeColor = Color.Red
                End If
                lblMostrarDisponible.Text = "¢" + _oUtilidades.PasarMoneda(clienteCredito.TotalCreditos)
                lblMostrarDias.ForeColor = Color.Yellow
                If clienteCredito.DiasAtrasado > 0 Then
                    lblMostrarDias.ForeColor = Color.Red
                End If
            Else
                lblMostrarEstado.Text = clienteCredito.Estado.ToString
                lblMostrarEstado.ForeColor = Color.Green
                lblMostrarTipo.ForeColor = Color.Green
                lblDisponible.Text = "Disponible ¢"
                lblMostrarDisponible.ForeColor = Color.Green
                lblMostrarDias.ForeColor = Color.Green

                If (clienteCredito.Limite - clienteCredito.TotalCreditos) >= 0 Then
                    lblMostrarDisponible.ForeColor = Color.Green
                    lblMostrarDisponible.Text = _oUtilidades.PasarMoneda(clienteCredito.Limite - clienteCredito.TotalCreditos)
                ElseIf (limite - clienteCredito.TotalCreditos) > 0 Then
                    lblMostrarDisponible.ForeColor = Color.Yellow
                    lblMostrarDisponible.Text = _oUtilidades.PasarMoneda(limite - clienteCredito.TotalCreditos)
                Else
                    lblMostrarDisponible.ForeColor = Color.Red
                    lblMostrarEstado.ForeColor = Color.Yellow
                    lblMostrarEstado.Text = "Suspendido"
                End If

                If clienteCredito.DiasAtrasado <= 0 Then
                    lblMostrarDias.ForeColor = Color.Green
                ElseIf clienteCredito.DiasAtrasado < tipoCredito.Dias Then
                    lblMostrarDias.ForeColor = Color.Yellow
                Else
                    lblMostrarEstado.ForeColor = Color.Yellow
                    lblMostrarTipo.ForeColor = Color.Yellow
                    lblMostrarEstado.Text = "Suspendido"
                    lblMostrarDias.ForeColor = Color.Red
                    lblDisponible.Text = "Saldo Vencido"
                    lblMostrarDisponible.Text = "¢" + _oUtilidades.PasarMoneda(clienteCredito.TotalAtrasado)
                    lblMostrarDisponible.ForeColor = Color.Red
                End If

            End If

            If lblMostrarTipo.Text = "Preferencial" Then
                lblMostrarTipo.Text = "Prefer"
            End If
        End Sub

        Private Sub rbContado_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbContado.CheckedChanged
            lblDiasPlazo.Visible = False
            txtDiasPlazo.Visible = False
            txtCantidad.Focus()
        End Sub

        Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnImprimir.Click
            If rbCredito.Checked Then
                If lblMostrarTipo.Text = "Prefer" Then
                    lblMostrarTipo.Text = "Preferencial"
                End If

                Dim tipoCredito = _oLogicaTipoCredito.ConsultarDato(lblMostrarTipo.Text)
                Dim clienteCredito = _oLogicaClienteCredito.ConsultarPorIdPersona(CInt(txtId_Cliente.Text))

                Dim limite = (tipoCredito.Limite) * clienteCredito.Limite

                If (clienteCredito.TotalCreditos + CDbl(lblMostrarTotal.Text)) < limite Then
                    Imprimir()
                Else
                    MsgBox("Con el monto que desea facturar el cliente soprepasa el limite permitido, Solo le queda disponible ¢" & _oUtilidades.PasarMoneda(limite - clienteCredito.TotalCreditos), MsgBoxStyle.Critical)
                End If
            Else
                Imprimir()
            End If

        End Sub

        Public Sub Imprimir()
            If Trim(txtNombre.Text) = "" Then
                MessageBox.Show("Datos imcompletos, Debe agregar el nombre del cliente", "Insertar nueva linea", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf dgvProductos.RowCount = 0 Then
                MessageBox.Show("Datos imcompletos, Debe agregar al menos un producto", "Insertar nueva linea", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If rbContado.Checked Then
                    FrmFlujoCaja.Tipo = 1
                    FrmFlujoCaja.Pantalla = 1
                    FrmFlujoCaja.ShowDialog()
                Else
                    EstadoFlujoCaja = True
                End If

                If EstadoFlujoCaja Then
                    Dim factura As Integer
                    factura = MessageBox.Show("Esta seguro que desea imprimir esta factura?", "Imprimir Factura", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    If factura = vbYes Then

                        _oLogicaFactura.RevisaBloqueo()
                        _oLogicaFactura.Bloqueo(True)

                        Dim idCliente As Integer
                        If EsClienteNuevo() Then
                            idCliente = _oLogicaFactura.GuardarDatosCliente(UCase(RTrim(txtNombre.Text)), UCase(txtApellidos.Text), txtCedula.Text)
                        Else
                            idCliente = CInt(txtId_Cliente.Text)
                        End If

                        Dim numFacturas = CInt(lblNumFacturas.Text)

                        lblMostrarNumFactura.Text = _oLogicaConsecutivo.ConsultarMaxConsecutivo("CONSECUTIVO_FACTURA") + 1

                        For i As Integer = 1 To numFacturas
                            Dim oFactura = New Factura

                            oFactura.NumFactura = CLng(lblMostrarNumFactura.Text)

                            oFactura.IdPersona = idCliente

                            If IsNumeric(txtId_Referencia.Text) Then
                                oFactura.IdReferencia = CInt(txtId_Referencia.Text)
                            Else
                                oFactura.IdReferencia = 1
                            End If

                            If rbContado.Checked Then
                                oFactura.Contado = True
                            Else
                                oFactura.Contado = False
                            End If

                            oFactura.Fecha = txtFecha.Text
                            oFactura.Anulada = False

                            oFactura = GuardarLineas((i * 15) - 15, oFactura)
                            _oLogicaFactura.Insertar(oFactura)

                            Dim oConsecutivo As New Consecutivo
                            oConsecutivo.Tabla = "CONSECUTIVO_FACTURA"
                            _oLogicaConsecutivo.AumentarConsecutivo(oConsecutivo)

                            lblMostrarNumFactura.Text = _oLogicaConsecutivo.ConsultarMaxConsecutivo("CONSECUTIVO_FACTURA") + 1

                            _oLogicaFactura.CalcularGanancia(oFactura.FacturaDetalles)

                            _oLogicaFactura.GuardarCtrlImpFact(oFactura.NumFactura, Environment.MachineName)

                            If Not oFactura.Contado Then
                                Dim oFacturaCredito As New FacturaCredito
                                oFacturaCredito.NumFactura = oFactura.NumFactura
                                oFacturaCredito.Monto = _oLogicaFactura.CalcularTotal(oFactura.FacturaDetalles)
                                oFacturaCredito.NumDias = CInt(txtDiasPlazo.Text)
                                oFacturaCredito.Fecha = oFactura.Fecha
                                oFacturaCredito.Estado = FacturaCredito.ListaEstado.Pendiente
                                Dim oCliente = _oLogicaClienteCredito.ConsultarPorIdPersona(oFactura.IdPersona)
                                oFacturaCredito.IdCredito = oCliente.IdCredito
                                oCliente.TotalCreditos = oFacturaCredito.Monto
                                _oLogicaClienteCredito.sumarTotal_Creditos(oCliente)
                                _oLogicaFacturaCredito.Insertar(oFacturaCredito)
                            End If

                        Next i

                        Dim tblImpresion As DataTable
                        tblImpresion = _oLogicaFactura.ConsultarCtrlImpFact(Environment.MachineName)

                        Cursor.Current = Cursors.WaitCursor

                        For i As Integer = 0 To tblImpresion.Rows.Count - 1

                            Dim oFactura = _oLogicaFactura.ConsultarFactura(tblImpresion.Rows(i).Item(0))

                            Try
                                Dim imprimir As New ImprimeFactura
                                imprimir.Imprime(UCase(txtNombre.Text + " " + txtApellidos.Text), oFactura, txtDiasPlazo.Text)
                            Catch ex As Exception
                                MsgBox(ex.ToString)
                            End Try
                        Next

                        Cursor.Current = Cursors.Default

                        _oLogicaFactura.EliminarCtrlImpFact(Environment.MachineName)
                        _oLogicaFactura.Bloqueo(False)

                        With dgvProductos
                            For i As Integer = 0 To .RowCount - 1
                                Dim producto As Producto = _oLogicaProducto.Consultar(.Item(1, i).Value)

                                If producto.MaxVendido < .Item(1, i).Value Then
                                    _oLogicaProducto.ActualizarMaximoVendido(.Item(1, i).Value, .Item(0, i).Value)
                                End If
                            Next
                        End With

                        If Tipo = 1 Then
                            _oLogicaListado.ActualizarEstado(IdTipo)
                        ElseIf Tipo = 4 Then
                            Dim listado = _oLogicaListado.ConsultarPorIdConInfo(IdTipo)
                            Dim listaHistorial As New List(Of ListadoHistorial)
                            listado.ListaHistorial = listaHistorial
                            listado.ListaResumen = Nothing
                            listado.ListaResumen = ListaDesChequeada
                            For i = 0 To listado.ListaAutorizados.Count - 1
                                listado.ListaAutorizados(i).IdAutorizado = 0
                            Next
                            _oLogicaListado.Insertar(listado)
                            _oLogicaListado.ActualizarEstado(IdTipo)
                        End If

                        If rbContado.Checked Then
                            Dim nuevo = _oLogicaFlujo.ConsultarNuevo(Now.ToString("dd/MM/yyyy"))
                            If nuevo Then
                                _oLogicaFlujo.Insertar(OFlujoCaja)
                            Else
                                _oLogicaFlujo.Modificar(OFlujoCaja)
                            End If
                        End If

                        LimpiarTodo()
                    End If

                End If
            End If

        End Sub

        Public Function EsClienteNuevo() As Boolean
            EsClienteNuevo = False

            If (Trim(txtId_Cliente.Text) = "") Then
                EsClienteNuevo = True
            End If
        End Function

        Private Function GuardarLineas(ByVal inicio As Integer, ByVal oFactura As Factura) As Factura
            Dim indice As Integer, final As Integer

            With dgvProductos
                If inicio + 15 < .RowCount Then ' reviso si aun quedan 14 o mas lineas
                    final = inicio + 15
                Else
                    final = .RowCount
                End If
                For indice = inicio To final - 1
                    oFactura.FacturaDetalles.Add(LlenarFacturaDetalle(oFactura.NumFactura,
                           .Item(1, indice).Value, .Item(2, indice).Value, .Item(3, indice).Value,
                           .Item(0, indice).Value, _oUtilidades.QuitarSimboloPorcentaje(.Item(5, indice).Value),
                           _oUtilidades.QuitarSimboloPorcentaje(.Item(4, indice).Value)))
                Next indice
            End With

            Return oFactura
        End Function

        Private Function LlenarFacturaDetalle(numFactura As Integer, idProducto As Integer, descripcion As String, precioUnitario As Double, cantidad As Double, impuesto As Double, descuento As Double)
            Dim oFacturaDetalle As New FacturaDetalle
            oFacturaDetalle.NumFactura = numFactura
            oFacturaDetalle.Id_Producto = idProducto
            oFacturaDetalle.Descripcion = descripcion
            oFacturaDetalle.PrecioUnitario = precioUnitario
            oFacturaDetalle.Cantidad = cantidad
            oFacturaDetalle.Impuesto = impuesto
            oFacturaDetalle.Descuento = descuento
            oFacturaDetalle.Tdescuento = _oUtilidades.PasarMoneda((oFacturaDetalle.Cantidad * oFacturaDetalle.PrecioUnitario) * (oFacturaDetalle.Descuento / 100))
            oFacturaDetalle.Timpuesto = (_oUtilidades.PasarMoneda((oFacturaDetalle.Cantidad * oFacturaDetalle.PrecioUnitario) - oFacturaDetalle.Tdescuento) * (oFacturaDetalle.Impuesto / 100))
            Return oFacturaDetalle
        End Function

        Private Function GuardarLineasTrasladar(ByVal inicio As Integer, ByVal oFactura As Factura) As Factura
            With dgvProductos
                For i = 0 To .Rows.Count - 1
                    oFactura.FacturaDetalles.Add(LlenarFacturaDetalle(oFactura.NumFactura,
                           .Item(1, i).Value, .Item(2, i).Value, .Item(3, i).Value,
                           .Item(0, i).Value, _oUtilidades.QuitarSimboloPorcentaje(.Item(5, i).Value),
                           _oUtilidades.QuitarSimboloPorcentaje(.Item(4, i).Value)))
                Next
            End With

            Return oFactura
        End Function

        Private Sub chkDescuento_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkDescuento.CheckedChanged
            If chkDescuento.Checked Then
                txtDescuentoGen.Visible = True
                txtDescuentoGen.Text = _oUtilidades.PasarMoneda(0)
                txtDescuentoGen.Focus()
            Else
                txtDescuentoGen.Visible = False
            End If
        End Sub

        Private Sub txtDescuentoGen_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtDescuentoGen.KeyDown
            If e.KeyValue = 13 Then
                LimpiarTotales()
                If IsNumeric(txtDescuentoGen.Text) Then
                    With dgvProductos
                        If .RowCount > 0 Then
                            For i As Integer = 0 To .RowCount - 1
                                .Item(6, i).Value = _oUtilidades.PasarMoneda(CalcularSubTotal(.Item(0, i).Value, .Item(3, i).Value, CDbl(txtDescuentoGen.Text), _oUtilidades.QuitarSimboloPorcentaje(.Item(5, i).Value)))
                                .Item(4, i).Value = _oUtilidades.PasarMoneda(txtDescuentoGen.Text) + "%"
                            Next
                        End If
                    End With

                    txtCantidad.Focus()
                End If
            End If
        End Sub


        Private Sub btnCatalogo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCatalogo.Click
            FrmCatalogoMateriales.ShowDialog()
        End Sub

        Private Sub btnCatalogo_Enter(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCatalogo.Enter
            txtCantidad.Focus()
            txtCantidad.SelectAll()
        End Sub

        Private Sub CalcularLineas(ByVal total As Integer)
            Dim lineas = Int((total / 16))

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

        Public Sub ActualizarCantidad(ByVal cantidad As Double)
            With dgvProductos
                For i = 0 To .RowCount - 1
                    If (.Item(1, i).Value = CLng(txtCodigo.Text)) Then
                        Dim cantAnterior = .Item(0, i).Value
                        .Item(0, i).Value = cantidad

                        SubTotalRestando(cantAnterior, CDbl(txtPrecio.Text), CDbl(_oUtilidades.QuitarSimboloPorcentaje(.Item(4, i).Value)), _impuesto)
                        Dim subTotalLinea = CalcularSubTotal(cantidad, CDbl(txtPrecio.Text), CDbl(_oUtilidades.QuitarSimboloPorcentaje(.Item(4, i).Value)), _impuesto)
                        .Item(6, i).Value = _oUtilidades.PasarMoneda(subTotalLinea)
                        Exit For
                    End If
                Next

                If .RowCount > 0 Then .Rows(0).Selected = False
            End With
        End Sub

        Private Sub btnAltO_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAltO.Click
            FrmFlujoCaja.Tipo = 2
            FrmFlujoCaja.Pantalla = 1
            FrmFlujoCaja.ShowDialog()

            If EstadoFlujoCaja Then
                Dim oFactura As New Factura
                oFactura.FacturaDetalles = LlenarFacturaDetalle(dgvProductos)

                If Tipo = 1 Then
                    _oLogicaListado.ActualizarEstado(IdTipo)
                ElseIf Tipo = 4 Then
                    Dim listado = _oLogicaListado.ConsultarPorIdConInfo(IdTipo)
                    Dim listaHistorial As New List(Of ListadoHistorial)
                    listado.ListaHistorial = listaHistorial
                    listado.ListaResumen = Nothing
                    listado.ListaResumen = ListaDesChequeada
                    _oLogicaListado.Insertar(listado)
                    _oLogicaListado.ActualizarEstado(IdTipo)
                End If

                _oLogicaFactura.DescontarExistencias(oFactura)

                LimpiarTodo()
            End If
        End Sub

        Private Sub btnAltU_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAltU.Click
            FrmFlujoCaja.Tipo = 3
            FrmFlujoCaja.Pantalla = 1
            FrmFlujoCaja.ShowDialog()

            If EstadoFlujoCaja Then
                Dim oFactura As New Factura
                oFactura.FacturaDetalles = LlenarFacturaDetalle(dgvProductos)
                _oLogicaFactura.AumentarExistencias(oFactura)
                LimpiarTodo()
            End If
        End Sub

        Private Function LlenarFacturaDetalle(ByVal dgvArticulos As DataGridView) As List(Of FacturaDetalle)
            Dim oListaFacturasDetalle As New List(Of FacturaDetalle)
            With dgvArticulos
                For i = 0 To .RowCount - 1
                    Dim oFacturaDetalle As New FacturaDetalle
                    oFacturaDetalle.Id_Producto = .Item(1, i).Value
                    oFacturaDetalle.Descripcion = .Item(2, i).Value
                    oFacturaDetalle.PrecioUnitario = .Item(3, i).Value
                    oFacturaDetalle.Cantidad = .Item(0, i).Value
                    oFacturaDetalle.Impuesto = _oUtilidades.QuitarSimboloPorcentaje(.Item(5, i).Value)
                    oFacturaDetalle.Descuento = _oUtilidades.QuitarSimboloPorcentaje(.Item(4, i).Value)
                    oFacturaDetalle.Tdescuento = _oUtilidades.PasarMoneda((oFacturaDetalle.Cantidad * oFacturaDetalle.PrecioUnitario) * (oFacturaDetalle.Descuento / 100))
                    oFacturaDetalle.Timpuesto = (_oUtilidades.PasarMoneda((oFacturaDetalle.Cantidad * oFacturaDetalle.PrecioUnitario) - oFacturaDetalle.Tdescuento) * (oFacturaDetalle.Impuesto / 100))
                    oListaFacturasDetalle.Add(oFacturaDetalle)
                Next i
            End With
            Return oListaFacturasDetalle
        End Function

        Private Sub btnAltI_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAltI.Click
            Imprimir()
        End Sub

        Private Sub FrmFacturar_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub

        Private Sub txtApellidos_Enter(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtApellidos.Enter
            dgvClientes.Visible = False
        End Sub

        Private Sub EliminFlu_Tick(ByVal sender As System.Object, ByVal e As EventArgs) Handles EliminFlu.Tick
            Dim hoy As Date = Now.Date
            Dim fecha As Date = DateAdd(DateInterval.Day, -3, hoy)

            _oLogicaFlujo.EliminarViejos(fecha)
        End Sub

        Private Sub txtCedula_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtCedula.KeyDown
            If e.KeyValue = 13 Then
                txtCantidad.Focus()
            End If
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

        Private Sub txtDiasPlazo_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtDiasPlazo.KeyDown
            If e.KeyValue = 13 Then
                txtCantidad.Focus()
            End If
        End Sub

        Private Sub txtArticulo_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtArticulo.KeyDown
            CambiarControlADataGrid(dgvMostrarProductos, e, txtArticulo, txtCantidad, txtDescuento)
        End Sub

        Private Sub txtArticulo_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtArticulo.KeyPress
            BuscarProductoPorDescripcion(dgvMostrarProductos, e, txtArticulo, txtCodigo)
        End Sub

        Private Sub txtNombre_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
            BuscarPersonaPorNombre(dgvClientes, e, txtNombre, txtApellidos, txtId_Cliente, txtCantidad)
        End Sub

        Private Sub txtNombre_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
            CambiarControlADataGrid(dgvClientes, e, txtNombre, txtCantidad, txtApellidos)
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

        Private Sub btnTrasladar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnTrasladar.Click
            If Trim(txtNombre.Text) = "" Then
                MessageBox.Show("Datos imcompletos, Debe agregar el nombre del cliente", "Insertar nueva linea", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf dgvProductos.RowCount = 0 Then
                MessageBox.Show("Datos imcompletos, Debe agregar al menos un producto", "Insertar nueva linea", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim oFactura = New Factura
                oFactura = GuardarLineasTrasladar(0, oFactura)
                FrmTrasladarFactura.Nombre = UCase(txtNombre.Text & " " & txtApellidos.Text)
                FrmTrasladarFactura.OFactura = oFactura
                FrmTrasladarFactura.ShowDialog()
            End If
        End Sub

        Private Sub btnSacarBodega_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnSacarBodega.Click
            FrmSacarBodega.ShowDialog()
        End Sub
    End Class
End Namespace