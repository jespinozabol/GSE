Imports Entidades
Imports Logica_Negocios

Namespace Interfaz.Catalogo
    Public Class FrmCatalogoMateriales

        Private ReadOnly _oLogicaProducto As New LogicaProducto
        Private ReadOnly _oLogicaListado As New LogicaListado
        Private ReadOnly _oUtilidades As New Utilidades
        Public Producto As New Producto
        Public pantalla As Integer

        'Si se ha seleccionado un producto devuelve False, o si esta vacío devuelve true.
        Private Function CodigoVacio() As Boolean
            If txtCodigo.ReadOnly Then
                Return False
            Else
                MsgBox("Primero debe seleccionar el producto", MsgBoxStyle.Exclamation)
                Return True
            End If
        End Function

        Public Sub LimpiarTodo()
            txtDescripcion.Text = String.Empty
            txtGanancia.Text = String.Empty
            txtMaximo.Text = String.Empty
            txtMinimo.Text = String.Empty
            txtPrecioCosto.Text = String.Empty
            txtMaxVendido.Text = String.Empty
            txtExistReal.Text = String.Empty
            chkConsignacion.Checked = False
            chkImpuesto.Checked = False
            txtExistTotal.Text = String.Empty
            txtPrecio_Venta.Text = String.Empty
            Producto = New Producto
            dgvMostrarProductos.Visible = False
            txtCodigo.ReadOnly = False
            chkOtros.Checked = False
            errCatalogo.Clear()
            txtCodigo.Focus()
        End Sub

        Private Sub LlenarDgvProductos(ByVal oTblProductos As DataTable)
            dgvProductos.Rows.Clear()
            For i As Integer = 0 To oTblProductos.Rows.Count - 1
                With oTblProductos.Rows(i)
                    dgvProductos.Rows.Add(.Item(0), .Item(1), .Item(2), .Item(3), .Item(4), .Item(5), .Item(6), .Item(7))
                    If .Item(4) < 0 Then
                        CambiarColorCelda(dgvProductos, 4, dgvProductos.Rows.Count - 1)
                    End If
                End With
            Next
            If dgvProductos.RowCount > 0 Then dgvProductos.Rows(dgvProductos.CurrentCell.RowIndex).Selected = False
        End Sub

        Private Sub LlenarProducto()
            dgvMostrarProductos.Visible = False

            Producto = _oLogicaProducto.Consultar(CInt(txtCodigo.Text))

            If Producto.Id_Producto <> 0 Then
                txtDescripcion.Text = Producto.Descripcion
                txtPrecioCosto.Text = _oUtilidades.PasarMoneda(Producto.PrecioUnitario)
                txtGanancia.Text = Producto.Ganancia
                Dim existenciasListados = _oLogicaListado.ConsultarExistenciasPorProducto(Producto.Id_Producto)

                txtExistTotal.Text = Math.Round(Producto.Existencias, 2)
                txtExistReal.Text = Math.Round(CDbl(txtExistTotal.Text) - existenciasListados, 2)

                VerificarExistencias(txtExistTotal)
                VerificarExistencias(txtExistReal)

                txtExistList.Text = Math.Round(existenciasListados, 2)
                txtMinimo.Text = Producto.Minimo
                txtMaximo.Text = Producto.Maximo
                txtMaxVendido.Text = Producto.MaxVendido

                If Producto.Impuesto Then
                    chkImpuesto.Checked = True
                Else
                    chkImpuesto.Checked = False
                End If

                If Producto.Consignacion Then
                    chkConsignacion.Checked = True
                Else
                    chkConsignacion.Checked = False
                End If

                If Producto.Bodega.Id_Producto <> 0 Then
                    chkOtros.Checked = True
                    txtExist_Bodega.Text = Producto.Bodega.ExistBodega
                    txtMaximoCaja.Text = Producto.Bodega.MaximoCaja
                Else
                    chkOtros.Checked = False
                End If

                Call CalcularPrecioVenta()
                txtCodigo.ReadOnly = True
                errCatalogo.Clear()
            Else
                LimpiarTodo()
                txtDescripcion.Focus()
            End If
        End Sub

        'Llena el dataGrid con los productos que están dentro del rango solicitado, selecciona la fila en 
        'donde se encuentra el producto escogido.
        Public Sub MarcarProducto()
            Dim oTblProductos = _oLogicaProducto.ConsultarRangoCodigo(CInt(txtRangoVista.Text), CInt(txtCodigo.Text))
            LlenarDgvProductos(oTblProductos)
            Dim fila As Integer = BuscarFila("Id_Producto", txtCodigo.Text, oTblProductos)

            If fila <> -1 Then
                dgvProductos.FirstDisplayedScrollingRowIndex = fila
                dgvProductos.Rows(fila).Selected = True
            End If
        End Sub

        Private Sub ValidarProducto()
            errCatalogo.Clear()
            Dim valida = True

            ValidaVacioDevuelveEntero(valida, Trim(txtCodigo.Text), Producto.Id_Producto, lblCodigo,
                                      "El código del producto no puede estar vacío", errCatalogo)

            ValidaVacioDevuelveCadena(valida, Trim(txtDescripcion.Text), Producto.Descripcion, lblDescripcion,
                                      "La descripción del producto no puede estar vacía", errCatalogo)

            ValidaVacioDevuelveDouble(valida, Trim(txtGanancia.Text), Producto.Ganancia, lblGanancia,
                                      "La ganancia no puede estar vacía", errCatalogo)

            ValidaVacioDevuelveDouble(valida, Trim(txtExistTotal.Text), Producto.Existencias, lblExistTotal,
                                      "Las existencias no pueden estar vacías", errCatalogo)

            ValidaVacioDevuelveDouble(valida, Trim(txtMinimo.Text), Producto.Minimo, lblMinimo,
                                      "La cantidad mínima del producto no puede estar vacía", errCatalogo)

            ValidaVacioDevuelveDouble(valida, Trim(txtMaximo.Text), Producto.Maximo, lblMaximo,
                                      "La cantidad máxima del producto no puede estar vacía", errCatalogo)

            ValidaVacioDevuelveDouble(valida, Trim(txtPrecioCosto.Text), Producto.PrecioUnitario, lblPrecio_Costo,
                                      "El precio costo del producto no puede estar vacío", errCatalogo)

            Producto.Impuesto = RetornaEstadoCheckBox(chkImpuesto)
            Producto.Consignacion = RetornaEstadoCheckBox(chkConsignacion)
            Producto.Activo = True

            Dim oBodega As New Bodega
            If chkOtros.Checked Then
                oBodega.Id_Producto = Producto.Id_Producto
                If txtExist_Bodega.Text <> "" Then
                    oBodega.ExistBodega = CDbl(txtExist_Bodega.Text)
                Else
                    oBodega.ExistBodega = 0
                End If
                If txtMaximoCaja.Text <> "" Then
                    oBodega.MaximoCaja = CDbl(txtMaximoCaja.Text)
                Else
                    oBodega.MaximoCaja = 0
                End If
            Else
                oBodega.Id_Producto = 0
            End If

            Producto.Bodega = oBodega

            If valida Then
                If txtCodigo.ReadOnly Then
                    _oLogicaProducto.Modificar(Producto)
                Else
                    Producto.MaxVendido = 0
                    _oLogicaProducto.Insertar(Producto)
                End If

                If txtRangoVista.Text.Length > 0 Then
                    MarcarProducto()
                End If

                LimpiarTodo()
                txtCodigo.Text = String.Empty
            End If
        End Sub


        Private Sub Catalogo_Materiales_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            'Método que se activa al cargar la ventana y asigna el método KeyPress a varios txt y si existe un
            'rango muestra los primeros 10 productos ordenados por código.

            AddHandler txtPrecioCosto.KeyPress, AddressOf ValidarNumerosPunto
            AddHandler txtMaximo.KeyPress, AddressOf ValidarNumerosPunto
            AddHandler txtMinimo.KeyPress, AddressOf ValidarNumerosPunto
            AddHandler txtExistTotal.KeyPress, AddressOf ValidarNumerosPunto
            AddHandler txtGanancia.KeyPress, AddressOf ValidarNumerosPunto
            AddHandler txtRangoVista.KeyPress, AddressOf ValidarSoloNumeros
            AddHandler txtCodigo.KeyPress, AddressOf ValidarSoloNumeros
            AddHandler txtExist_Bodega.KeyPress, AddressOf ValidarNumerosPunto
            AddHandler txtMaximoCaja.KeyPress, AddressOf ValidarNumerosPunto

            If pantalla = 1 Then
                LlenarProducto()
                MarcarProducto()
            Else
                If txtRangoVista.Text.Length > 0 Then
                    Dim oTblProductos = _oLogicaProducto.ConsultarRango(10)
                    LlenarDgvProductos(oTblProductos)
                End If
            End If
            
        End Sub

        Private Sub txtCodigo_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
            'Si se presiona enter y el campo del código tiene algo se marca el producto seleccionado
            'y se llenan los campos con los datos del producto.
            If e.KeyData = Keys.Enter Then
                If Trim(txtCodigo.Text) <> "" Then
                    MarcarProducto()
                    LlenarProducto()
                End If
                txtDescripcion.Focus()
            End If
        End Sub

        Private Sub txtCodigo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtCodigo.Click
            'Limpia todos los datos de un producto al hacer clic sobre el txt del código.
            LimpiarTodo()
            txtCodigo.Text = String.Empty
        End Sub

        Private Sub txtDescripcion_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtDescripcion.KeyDown
            cambiarControlADataGrid(dgvMostrarProductos, e, txtDescripcion, txtPrecioCosto, txtPrecioCosto)
        End Sub

        Private Sub txtDescripcion_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
            BuscarProductoPorDescripcion(dgvMostrarProductos, e, txtDescripcion, txtGanancia)
        End Sub

        Private Sub txtPrecioCosto_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtPrecioCosto.KeyDown
            If e.KeyData = Keys.Enter Then
                txtGanancia.Focus()
                Call CalcularPrecioVenta()
            End If
        End Sub

        Private Sub txtGanancia_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtGanancia.KeyDown
            If e.KeyData = Keys.Enter Then
                txtExistReal.Focus()
                Call CalcularPrecioVenta()
            End If
        End Sub

        Private Sub txtExistReal_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtExistReal.KeyDown
            If e.KeyData = Keys.Enter Then
                txtMinimo.Focus()
                txtExistTotal.Text = Math.Round(CDbl(txtExistReal.Text) + CDbl(txtExistList.Text), 2)
                Call CalcularPrecioVenta()
                VerificarExistencias(txtExistTotal)
                VerificarExistencias(txtExistReal)
            End If
        End Sub

        Private Sub txtMinimo_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtMinimo.KeyDown
            If e.KeyData = Keys.Enter Then txtMaximo.Focus()
        End Sub

        Private Sub txtMaximo_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtMaximo.KeyDown
            If e.KeyData = Keys.Enter Then
                chkImpuesto.Checked = True
                chkImpuesto.Focus()
            End If
        End Sub

        Private Sub chkImpuesto_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles chkImpuesto.KeyDown
            If e.KeyData = Keys.Enter Then chkConsignacion.Focus()
        End Sub

        Private Sub chkImpuesto_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkImpuesto.CheckedChanged
            Call CalcularPrecioVenta()
        End Sub

        Private Sub chkConsignacion_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles chkConsignacion.KeyDown
            If e.KeyData = Keys.Enter Then btnGuardar.Focus()
        End Sub

        Private Sub txtRangoVista_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtRangoVista.KeyDown
            If e.KeyData = Keys.Enter And txtRangoVista.Text.Length > 0 And txtCodigo.ReadOnly Then MarcarProducto()
        End Sub

        Private Sub dgvProductos_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles dgvProductos.KeyDown
            If e.KeyData = Keys.Enter Then
                txtCodigo.Text = dgvProductos.Item(0, dgvProductos.CurrentRow.Index).Value
                LlenarProducto()
                e.Handled = True
            End If
        End Sub

        Private Sub dgvProductos_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvProductos.Click
            txtCodigo.Text = dgvProductos.Item(0, dgvProductos.CurrentRow.Index).Value
            LlenarProducto()
        End Sub

        Private Sub dgvMostrarProductos_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvMostrarProductos.Click
            With dgvMostrarProductos
                txtCodigo.Text = .Item(0, .CurrentRow.Index).Value
                MarcarProducto()
                LlenarProducto()
            End With
        End Sub

        Private Sub dgvMostrarProductos_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles dgvMostrarProductos.KeyDown
            If e.KeyValue = 13 Then
                With dgvMostrarProductos
                    txtCodigo.Text = .Item(0, .CurrentRow.Index).Value
                    MarcarProducto()
                    LlenarProducto()
                End With
            End If
        End Sub

        Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnLimpiar.Click
            LimpiarTodo()
            txtRangoVista.Text = 10
            If dgvProductos.RowCount > 0 Then dgvProductos.Rows(dgvProductos.CurrentCell.RowIndex).Selected = False
            txtCodigo.Text = String.Empty
        End Sub

        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            ValidarProducto()
            txtCodigo.Focus()
        End Sub

        Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnEliminar.Click
            If Not CodigoVacio() Then

                If _oLogicaProducto.TieneRelaciones(CInt(txtCodigo.Text)) Then
                    MsgBox("El producto está relacionado con otras tablas por lo que los datos deben ser traslados a otro código")
                    FrmEliminarCodigoRepetido.lblMostrarCodigo.Text = txtCodigo.Text
                    FrmEliminarCodigoRepetido.lblMostrarDescripcion.Text = txtDescripcion.Text
                    FrmEliminarCodigoRepetido.ShowDialog()
                Else
                    Dim elimina As Integer
                    elimina = MessageBox.Show("Esta seguro que desea eliminar el producto?", "Eliminar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    If elimina = vbYes Then
                        _oLogicaProducto.Eliminar(CInt(txtCodigo.Text))
                        LimpiarTodo()
                        MarcarProducto()
                        txtCodigo.Text = String.Empty
                    End If

                End If
            End If
        End Sub

        Private Sub btnTrasladar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnTrasladar.Click
            If Not CodigoVacio() Then
                Dim codigo As String = txtCodigo.Text
                Dim descripcion As String = txtDescripcion.Text
                ValidarProducto()
                FrmTrasladarCodigo.lblMostrarCodigo.Text = codigo
                FrmTrasladarCodigo.lblMostrarDescripcion.Text = descripcion
                FrmTrasladarCodigo.ShowDialog()
            End If
        End Sub

        Private Sub btnProveedores_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnProveedores.Click
            If txtCodigo.Text <> "" Then FrmProveedoresProducto.ShowDialog()
        End Sub

        Private Sub btnRelacionados_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnRelacionados.Click
            If txtCodigo.Text <> "" Then FrmProductoRelacionado.ShowDialog()
        End Sub

        Private Sub FrmCatalogo_Materiales_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub

        Private Sub chkOtros_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkOtros.CheckedChanged
            If chkOtros.Checked Then
                lblExis_Bodega.Enabled = True
                txtExist_Bodega.Enabled = True
                lblMaximoCaja.Enabled = True
                txtMaximoCaja.Enabled = True
                txtExist_Bodega.Focus()
            Else
                lblExis_Bodega.Enabled = False
                txtExist_Bodega.Enabled = False
                lblMaximoCaja.Enabled = False
                txtMaximoCaja.Enabled = False
                txtExist_Bodega.Text = 0
                txtMaximoCaja.Text = 0
            End If
        End Sub

        Private Sub txtExist_Bodega_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtExist_Bodega.KeyDown
            If e.KeyData = Keys.Enter Then txtMaximoCaja.Focus()
        End Sub

        Private Sub txtMaximoCaja_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtMaximoCaja.KeyDown
            If e.KeyData = Keys.Enter Then btnGuardar.Focus()
        End Sub


        Private Sub txtExistReal_Leave(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtExistReal.Leave
            If IsNumeric(txtExistReal.Text) Then
                txtMinimo.Focus()
                txtExistTotal.Text = Math.Round(CDbl(txtExistReal.Text) + CDbl(txtExistList.Text), 2)
                Call CalcularPrecioVenta()
                VerificarExistencias(txtExistTotal)
                VerificarExistencias(txtExistReal)
            End If
        End Sub
    End Class
End Namespace