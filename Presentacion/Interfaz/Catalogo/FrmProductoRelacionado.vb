Imports Entidades
Imports Logica_Negocios

Namespace Interfaz.Catalogo
    Public Class FrmProductoRelacionado

        Private ReadOnly _oLogicaProducto As New LogicaProducto
        Private _filaActual As Integer

        Private Sub LlenarProducto()
            Dim oProducto = _oLogicaProducto.Consultar(CLng(txtCodigo.Text))
            txtDescripcion.Text = oProducto.Descripcion
            dgvMostrarProductos.Visible = False
            txtObservacion.Focus()
        End Sub

        Private Sub AgregarRelaciones(ByVal listaRelacionados As List(Of ProductoRelacionado))
            With dgvRelacionados
                .Rows.Clear()
                For i = 0 To listaRelacionados.Count - 1
                    Dim descripcion = _oLogicaProducto.ConsultarDescripcion(listaRelacionados(i).Id_Producto)
                    .Rows.Add(listaRelacionados(i).Id_Producto, listaRelacionados(i).Prioridad, descripcion, listaRelacionados(i).Observacion)
                Next
            End With
        End Sub

        Private Sub txtCodigo_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
            Dim keyAscii As Short = CShort(Asc(e.KeyChar))
            If Not keyAscii = 13 Then
                Dim oProducto = BuscarProductoPorCodigo(e, txtCodigo)
                If oProducto.Id_Producto <> 0 Then
                    txtDescripcion.Text = oProducto.Descripcion
                Else
                    txtDescripcion.Text = String.Empty
                End If
                dgvMostrarProductos.Visible = False
            End If
        End Sub

        Private Sub txtCodigo_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
            If e.KeyData = Keys.Enter And txtDescripcion.Text = "" Then
                txtDescripcion.Focus()
            ElseIf e.KeyData = Keys.Enter Then
                txtObservacion.Focus()
            End If
        End Sub

        Private Sub txtDescripcion_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtDescripcion.KeyDown
            CambiarControlADataGrid(dgvMostrarProductos, e, txtDescripcion, txtObservacion, txtObservacion)
        End Sub

        Private Sub txtObservacion_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtObservacion.KeyDown
            If e.KeyData = Keys.Enter Then
                btnAgregarProveedor.Focus()
            End If
        End Sub

        Private Sub FrmProducto_Relacionado_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            txtCodigo_Product.Text = FrmCatalogoMateriales.txtCodigo.Text

            Dim listaRelacionados As New List(Of ProductoRelacionado)
            listaRelacionados = FrmCatalogoMateriales.Producto.ListaRelacionados
            If listaRelacionados.Count > 0 Then
                For i = 0 To listaRelacionados.Count - 1
                    With dgvRelacionados
                        Dim descripcion = _oLogicaProducto.ConsultarDescripcion(listaRelacionados(i).Id_Producto)
                        .Rows.Add(listaRelacionados(i).Id_Producto, listaRelacionados(i).Prioridad, descripcion, listaRelacionados(i).Observacion)
                    End With
                Next i
            Else
                Dim oProducto As New ProductoRelacionado
                oProducto.Id_Producto = CLng(txtCodigo_Product.Text)
                oProducto.Prioridad = CInt(dgvRelacionados.Rows.Count + 1)
                oProducto.Observacion = UCase(txtObservacion.Text)

                FrmCatalogoMateriales.Producto.ListaRelacionados.Add(oProducto)
                AgregarRelaciones(FrmCatalogoMateriales.Producto.ListaRelacionados)
            End If

            AddHandler dgvRelacionados.MouseDown, AddressOf SeleccionaClickDerecho
            dgvRelacionados.ContextMenuStrip = Menu_Relacionados
        End Sub

        Private Sub dgvRelacionados_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvRelacionados.Click
            Try
                _filaActual = dgvRelacionados.CurrentRow.Index
            Catch ex As Exception
                _filaActual = -1
            End Try
        End Sub

        Private Sub dgvMostrarProductos_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles dgvMostrarProductos.KeyDown
            If e.KeyValue = 13 Then
                With dgvMostrarProductos
                    txtCodigo.Text = .Item(0, .CurrentRow.Index).Value
                    LlenarProducto()
                End With
            End If
        End Sub

        Private Sub dgvMostrarProductos_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvMostrarProductos.Click
            With dgvMostrarProductos
                txtCodigo.Text = .Item(0, .CurrentRow.Index).Value
                LlenarProducto()
            End With
        End Sub

        Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles EliminarToolStripMenuItem.Click
            If dgvRelacionados.RowCount > 0 Then
                Try
                    If dgvRelacionados.CurrentRow.Index >= 0 Then
                        Dim elimina As Integer
                        elimina = MessageBox.Show("Esta seguro q desea quitar este producto de los relacionados?", "Desvincular Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                        If elimina = vbYes Then
                            Try
                                'Obtiene el número de relación de los productos
                                Dim relacion = CInt(dgvRelacionados.Item(0, dgvRelacionados.CurrentRow.Index).Value)


                                _oLogicaProducto.Eliminar_Relacionado(CInt(txtCodigo_Product.Text))

                                For i = 0 To FrmCatalogoMateriales.Producto.ListaRelacionados.Count - 1
                                    If FrmCatalogoMateriales.Producto.ListaRelacionados(i).Relacion = relacion Then
                                        FrmCatalogoMateriales.Producto.ListaRelacionados.RemoveAt(i)
                                        i = FrmCatalogoMateriales.Producto.ListaRelacionados.Count
                                    End If
                                Next

                                dgvRelacionados.DataSource = Nothing
                                dgvRelacionados.Rows.Clear()
                                If FrmCatalogoMateriales.Producto.ListaRelacionados.Count > 0 Then
                                    AgregarRelaciones(FrmCatalogoMateriales.Producto.ListaRelacionados)
                                End If

                                For i As Integer = 0 To dgvRelacionados.RowCount - 1
                                    dgvRelacionados.Item(2, i).Value = i + 1
                                Next
                            Catch ex As Exception
                                MsgBox(ex.Message.ToString)
                            End Try

                        End If
                    Else
                        MsgBox("Debe seleccionar el producto que desea desvincular")
                    End If
                Catch ex As Exception
                    MsgBox("Debe seleccionar el producto que desea desvincular")
                End Try

            End If
        End Sub

        Private Sub btnAplicar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAplicar.Click
            Dispose()
        End Sub

        Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnLimpiar.Click
            txtCodigo.Text = String.Empty
            txtObservacion.Text = String.Empty
            txtDescripcion.Text = String.Empty
            dgvMostrarProductos.Visible = False
            dgvMostrarProductos.Rows.Clear()
            If dgvRelacionados.Rows.Count > 0 Then dgvRelacionados.Rows(0).Selected = False
        End Sub

        Private Sub btnAgregarProveedor_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAgregarProveedor.Click
            Dim valida As Boolean = True

            If (Not IsNumeric(txtCodigo.Text)) And (txtDescripcion.Text = "") Then
                MsgBox("Debe de seleccionar un producto antes de precionar agregar")
                valida = False
            End If

            If valida Then

                Dim oProductoRelacionado As New ProductoRelacionado

                oProductoRelacionado.Id_Producto = CLng(txtCodigo.Text)
                oProductoRelacionado.Prioridad = CInt(dgvRelacionados.Rows.Count + 1)
                oProductoRelacionado.Observacion = UCase(txtObservacion.Text)

                FrmCatalogoMateriales.Producto.ListaRelacionados.Add(oProductoRelacionado)
                AgregarRelaciones(FrmCatalogoMateriales.Producto.ListaRelacionados)
                txtCodigo.Text = String.Empty
                txtObservacion.Text = String.Empty
                txtDescripcion.Text = String.Empty
                txtCodigo.Focus()
            End If
        End Sub

        Private Sub btnArriba_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnArriba.Click
            With dgvRelacionados
                If .RowCount > 1 Then
                    If _filaActual > 0 Then

                        Dim oRelacionadoSube As New ProductoRelacionado
                        oRelacionadoSube.Id_Producto = .Item(0, _filaActual).Value
                        oRelacionadoSube.Prioridad = .Item(1, _filaActual).Value - 1
                        oRelacionadoSube.Observacion = .Item(3, _filaActual).Value
                        Dim descripcion As String = .Item(2, _filaActual).Value

                        Dim oRelacionadoBaja As New ProductoRelacionado
                        oRelacionadoBaja.Id_Producto = .Item(0, _filaActual - 1).Value
                        oRelacionadoBaja.Prioridad = .Item(1, _filaActual - 1).Value + 1
                        oRelacionadoBaja.Observacion = .Item(3, _filaActual - 1).Value
                        Dim descripcion_baja As String = .Item(2, _filaActual - 1).Value

                        .Item(0, _filaActual).Value = oRelacionadoBaja.Id_Producto
                        .Item(1, _filaActual).Value = oRelacionadoBaja.Prioridad
                        .Item(2, _filaActual).Value = descripcion_baja
                        .Item(3, _filaActual).Value = oRelacionadoBaja.Observacion

                        .Item(0, _filaActual - 1).Value = oRelacionadoSube.Id_Producto
                        .Item(1, _filaActual - 1).Value = oRelacionadoSube.Prioridad
                        .Item(2, _filaActual - 1).Value = descripcion
                        .Item(3, _filaActual - 1).Value = oRelacionadoSube.Observacion

                        FrmCatalogoMateriales.Producto.ListaRelacionados(_filaActual - 1) = oRelacionadoSube
                        FrmCatalogoMateriales.Producto.ListaRelacionados(_filaActual) = oRelacionadoBaja

                        .Rows(_filaActual - 1).Selected = True
                        .FirstDisplayedScrollingRowIndex = _filaActual - 1
                        _filaActual -= 1


                    End If
                End If
            End With
        End Sub

        Private Sub btnAbajo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAbajo.Click
            With dgvRelacionados
                If .RowCount > 1 Then
                    If _filaActual < .RowCount - 1 Then

                        Dim oRelacionadoSube As New ProductoRelacionado
                        oRelacionadoSube.Id_Producto = .Item(0, _filaActual).Value
                        oRelacionadoSube.Prioridad = .Item(1, _filaActual).Value + 1
                        oRelacionadoSube.Observacion = .Item(3, _filaActual).Value
                        Dim descripcion As String = .Item(2, _filaActual).Value

                        Dim oRelacionadoBaja As New ProductoRelacionado
                        oRelacionadoBaja.Id_Producto = .Item(0, _filaActual + 1).Value
                        oRelacionadoBaja.Prioridad = .Item(1, _filaActual + 1).Value - 1
                        oRelacionadoBaja.Observacion = .Item(3, _filaActual + 1).Value
                        Dim descripcion_baja As String = .Item(2, _filaActual + 1).Value

                        .Item(0, _filaActual).Value = oRelacionadoBaja.Id_Producto
                        .Item(1, _filaActual).Value = oRelacionadoBaja.Prioridad
                        .Item(2, _filaActual).Value = descripcion_baja
                        .Item(3, _filaActual).Value = oRelacionadoBaja.Observacion

                        .Item(0, _filaActual + 1).Value = oRelacionadoSube.Id_Producto
                        .Item(1, _filaActual + 1).Value = oRelacionadoSube.Prioridad
                        .Item(2, _filaActual + 1).Value = descripcion
                        .Item(3, _filaActual + 1).Value = oRelacionadoSube.Observacion

                        FrmCatalogoMateriales.Producto.ListaRelacionados(_filaActual + 1) = oRelacionadoSube
                        FrmCatalogoMateriales.Producto.ListaRelacionados(_filaActual) = oRelacionadoBaja

                        .Rows(_filaActual + 1).Selected = True
                        .FirstDisplayedScrollingRowIndex = _filaActual + 1
                        _filaActual += 1


                    End If
                End If
            End With
        End Sub

        Private Sub txtDescripcion_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
            BuscarProductoPorDescripcion(dgvMostrarProductos, e, txtDescripcion, txtCodigo)
        End Sub

        Private Sub FrmProductoRelacionado_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub
    End Class
End Namespace