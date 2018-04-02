Imports Entidades
Imports Logica_Negocios

Namespace Interfaz.Proveedores

    Public Class FrmDevoluciones

        Private ReadOnly _oLogicaDevoluciones As New LogicaDevolucion
        Private ReadOnly _oLogicaProveedor As New LogicaProveedor

        Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnLimpiar.Click
            LimpiarTodo()
        End Sub

        Private Sub LimpiarTodo()
            txtId_Proveedor.Text = String.Empty
            txtNombre.Text = String.Empty
            txtCantidad.Text = String.Empty
            txtCodigo.Text = String.Empty
            txtProducto.Text = String.Empty
            txtMotivo.Text = String.Empty
            txtNumFactura.Text = String.Empty
            rbCambio.Checked = False
            rbNc.Checked = False
            dgvDevoluciones.Rows.Clear()
        End Sub

        Private Sub txtId_Proveedor_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtId_Proveedor.KeyDown
            If e.KeyData = Keys.Enter And txtNombre.Text = "" Then
                txtNombre.Focus()
            ElseIf e.KeyData = Keys.Enter Then
                txtNumFactura.Focus()
            End If
        End Sub

        Private Sub txtId_Proveedor_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtId_Proveedor.KeyPress
            Dim keyAscii As Short = CShort(Asc(e.KeyChar))
            If Not keyAscii = 13 Then
                Dim oProveedor = BuscarProveedorPorId(e, txtId_Proveedor, txtNombre)
                If oProveedor.IdProveedor <> 0 Then
                    LlenarDatos(oProveedor)
                Else
                    LimpiarTodo()
                End If
            End If
        End Sub

        Private Sub LlenarDatos(ByRef oProveedor As Proveedor)
            txtNombre.Text = oProveedor.Nombre
            dgvProveedores.Visible = False
        End Sub

        Private Sub txtNombre_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
            CambiarControlADataGrid(dgvProveedores, e, txtNombre, txtNumFactura, txtNumFactura)
        End Sub

        Private Sub txtNombre_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
            BuscarProveedorPorNombre(dgvProveedores, e, txtNombre, txtId_Proveedor)
        End Sub

        Private Sub dgvProveedores_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvProveedores.Click
            LlenarDatos(_oLogicaProveedor.Consultar(dgvProveedores.Item(0, dgvProveedores.CurrentRow.Index).Value))
            txtId_Proveedor.Text = dgvProveedores.Item(0, dgvProveedores.CurrentRow.Index).Value
            txtNumFactura.Focus()
        End Sub

        Private Sub dgvProveedores_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles dgvProveedores.KeyDown
            If e.KeyValue = 13 Then
                LlenarDatos(_oLogicaProveedor.Consultar(dgvProveedores.Item(0, dgvProveedores.CurrentRow.Index).Value))
                txtId_Proveedor.Text = dgvProveedores.Item(0, dgvProveedores.CurrentRow.Index).Value
                txtNumFactura.Focus()
            End If
        End Sub

        Private Sub FrmDevoluciones_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            Dim oListaDevoluciones As List(Of Devolucion)
            oListaDevoluciones = _oLogicaDevoluciones.ConsultarPorIdProveedor

            For i = 0 To oListaDevoluciones.Count - 1
                dgvDevoluciones.Rows.Add(oListaDevoluciones(i).Cantidad, oListaDevoluciones(i).Producto)
            Next
        End Sub

        Private Sub txtCodigo_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
            Dim keyAscii As Short = CShort(Asc(e.KeyChar))
            If keyAscii <> 13 Then
                Dim oProducto = BuscarProductoPorCodigo(e, txtCodigo)
                If oProducto.Id_Producto <> 0 Then
                    LlenarProducto(oProducto)
                Else
                    'LimpiarProducto()
                End If
            End If
        End Sub

        Private Sub LlenarProducto(ByVal oProducto As Producto)
            txtProducto.Text = oProducto.Descripcion
            dgvProductos.Visible = False
        End Sub

        Private Sub txtCodigo_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
            If e.KeyData = Keys.Enter And txtProducto.Text = "" Then
                txtProducto.Focus()
                txtCodigo.Text = String.Empty
            ElseIf e.KeyData = Keys.Enter Then
                txtMotivo.Focus()
            End If
        End Sub

        Private Sub txtProducto_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtProducto.KeyDown
            CambiarControlADataGrid(dgvProductos, e, txtProducto, txtMotivo, txtMotivo)
        End Sub

        Private Sub txtProducto_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtProducto.KeyPress
            BuscarProductoPorDescripcion(dgvProductos, e, txtProducto, txtCodigo)
        End Sub

        Private Sub dgvMostrarProductos_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvProductos.Click
            MostrarProductos()
        End Sub

        Private Sub MostrarProductos()
            txtCodigo.Text = dgvProductos.Item(0, dgvProductos.CurrentRow.Index).Value
            dgvProductos.DataSource = Nothing
            dgvProductos.Visible = False
            txtCantidad.Focus()
        End Sub

        Private Sub dgvMostrarProductos_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles dgvProductos.KeyDown
            If e.KeyData = Keys.Enter Then
                MostrarProductos()
            End If
        End Sub

        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            ValidarDevolucion()
        End Sub

        Private Sub LimpiarErroresValidacion()
            errValidacion.SetError(lblIdProveedor, String.Empty)
            errValidacion.SetError(lblNumFactura, String.Empty)
            errValidacion.SetError(lblNombre, String.Empty)
            errValidacion.SetError(lblCantidad, String.Empty)
            errValidacion.SetError(lblNumBoleta, String.Empty)
            errValidacion.SetError(lblProducto, String.Empty)
            errValidacion.SetError(lblMotivo, String.Empty)
            errValidacion.SetError(lblFecha, String.Empty)
            errValidacion.SetError(lblObservaciones, String.Empty)
        End Sub

        Private Sub ValidarDevolucion()
            LimpiarErroresValidacion()
            Dim valida As Boolean = True
            Dim oDevolucion = New Devolucion

            ValidaVacioDevuelveCadena(valida, Trim(txtMotivo.Text), oDevolucion.Motivo, lblMotivo,
                                          "El motivo no puede estar vacío", errValidacion)
            ValidaVacioDevuelveCadena(valida, Trim(txtProducto.Text), oDevolucion.Producto, lblProducto,
                                          "El producto no puede estar vacío", errValidacion)
            ValidaVacioDevuelveDouble(valida, Trim(txtCantidad.Text), oDevolucion.Cantidad, lblCantidad,
                                          "La cantidad no puede estar vacía", errValidacion)
            ValidaVacioCeroDevuelveCadena(valida, Trim(txtNumFactura.Text), oDevolucion.Factura, lblNumFactura,
                                         "El número de la factura no puede estar vacío o ser cero", errValidacion)

            If Trim(txtId_Proveedor.Text) = "" Or Trim(txtNombre.Text) = "" Then
                errValidacion.SetError(lblNombre, "El proveedor debe existir")
                valida = False
            Else
                oDevolucion.IdProveedor = CInt(txtId_Proveedor.Text)
            End If

            If Trim(txtCodigo.Text) <> "" Then
                oDevolucion.Codigo = CInt(txtCodigo.Text)
            Else
                oDevolucion.Codigo = 0
            End If

            oDevolucion.Observaciones = txtObservaciones.Text

            Dim tipoDevolucion As String = ""

            If rbNc.Checked Then
                tipoDevolucion = "NC"
                oDevolucion.Fecha = Now
                oDevolucion.Boleta = txtNumBoleta.Text
            ElseIf rbCambio.Checked Then
                tipoDevolucion = "Cambio"
                ValidaVacioDevuelveCadena(valida, Trim(txtNumBoleta.Text), oDevolucion.Boleta, lblNumBoleta,
                                        "El número de boleta no puede estar vacío", errValidacion)

                If Trim(txtFecha.Text) = "" Or Trim(txtFecha.Text).Length <> 10 Then
                    errValidacion.SetError(lblFecha, "No se ha asignado una fecha válida. Formato '10/12/2002'")
                    valida = False
                Else
                    Try
                        oDevolucion.Fecha = CDate(txtFecha.Text)
                    Catch ex As Exception
                        errValidacion.SetError(lblFecha, "No se ha asignado una fecha válida. Formato '10/12/2002'")
                        valida = False
                    End Try

                End If
            End If

            If valida Then
                dgvDevoluciones.Rows.Add(oDevolucion.Cantidad, oDevolucion.Producto, oDevolucion.Factura, tipoDevolucion, oDevolucion.Motivo)
                _oLogicaDevoluciones.Insertar(oDevolucion)
                LimpiarTodo()
            End If
        End Sub

        Private Sub rbCambio_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbCambio.CheckedChanged
            If rbCambio.Checked Then
                txtFecha.Enabled = True
                txtNumBoleta.Enabled = True
                rbNc.Checked = False
                txtFecha.Focus()
            End If
        End Sub

        Private Sub rbNc_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbNc.CheckedChanged
            If rbNc.Checked Then
                txtFecha.Enabled = False
                txtNumBoleta.Enabled = False
                txtFecha.Text = String.Empty
                txtNumBoleta.Text = String.Empty
                rbCambio.Checked = False
            End If
        End Sub

        Private Sub txtCantidad_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtCantidad.KeyDown
            If e.KeyData = Keys.Enter Then txtCodigo.Focus()
        End Sub

        Private Sub txtNumFactura_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNumFactura.KeyDown
            If e.KeyData = Keys.Enter Then txtCantidad.Focus()
        End Sub

        Private Sub txtMotivo_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtMotivo.KeyDown
            If e.KeyData = Keys.Enter Then txtObservaciones.Focus()
        End Sub

        Private Sub txtFecha_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtFecha.KeyDown
            If e.KeyData = Keys.Enter Then txtNumBoleta.Focus()
        End Sub

        Private Sub FrmDevoluciones_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub
    End Class
End Namespace