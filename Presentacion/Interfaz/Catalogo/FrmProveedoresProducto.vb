Imports Entidades
Imports Logica_Negocios
Imports Presentacion.Interfaz.Proveedores
Namespace Interfaz.Catalogo
    Public Class FrmProveedoresProducto

        Private _oTblProveedores As DataTable
        Private ReadOnly _oLogicaProveedor As New LogicaProveedor
        Private ReadOnly _oLogicaProducto As New LogicaProducto
        Private _filaActual As Integer

        Public Sub LlenarProveedores()
            cmbProveedores.Items.Clear()
            cmbProveedores.Text = String.Empty
            cmbProveedores.Items.Add("Nuevo...")
            _oTblProveedores = _oLogicaProveedor.ConsultarTodos
            For i As Integer = 0 To _oTblProveedores.Rows.Count - 1
                cmbProveedores.Items.Add(_oTblProveedores.Rows(i).Item(1))
            Next
        End Sub

        Private Sub CambiarPropiedadesdgvProveedores()
            With dgvProveedores
                .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(2).Width = 50
                .Columns(3).Width = 274
                If .RowCount > 0 Then .Rows(0).Selected = False
            End With
        End Sub

        Private Sub FrmProveedores_Producto_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            LlenarProveedores()

            dgvProveedores.DataSource = Nothing
            If FrmCatalogoMateriales.Producto.ListaProveedores.Count > 0 Then
                dgvProveedores.DataSource = FrmCatalogoMateriales.Producto.ListaProveedores
                CambiarPropiedadesdgvProveedores()
            End If

            AddHandler dgvProveedores.MouseDown, AddressOf seleccionaClickDerecho
            dgvProveedores.ContextMenuStrip = Menu_Proveedores
        End Sub

        Private Sub cmbProveedores_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbProveedores.SelectedIndexChanged
            If cmbProveedores.SelectedItem = "Nuevo..." Then
                FrmProveedor.llamadoCatalogo = True
                FrmProveedor.ShowDialog()
            Else
                btnAgregarProveedor.Focus()
            End If
        End Sub

        Private Sub VerDatosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles VerDatosToolStripMenuItem.Click
            Try
                If dgvProveedores.CurrentRow.Index >= 0 Then
                    FrmInfoProveedor.LlenarProveedor(dgvProveedores.Item(1, dgvProveedores.CurrentRow.Index).Value)
                    FrmInfoProveedor.ShowDialog()
                End If
            Catch ex As Exception
                MsgBox("Debe seleccionar un proveedor para ver la información del mismo", MsgBoxStyle.Exclamation)
            End Try
        End Sub

        Private Sub MnEliminar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles MnEliminar.Click
            If dgvProveedores.RowCount > 0 And dgvProveedores.CurrentRow.Index >= 0 Then
                Try
                    Dim elimina As Integer
                    elimina = MessageBox.Show("Esta seguro q desea desvincular el proveedor con el producto?", "Eliminar Proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    If elimina = vbYes Then

                        Dim oProductoPorProveedor As New ProductoPorProveedor
                        oProductoPorProveedor.Id_Producto = CInt(FrmCatalogoMateriales.txtCodigo.Text)
                        oProductoPorProveedor.IdProveedor = CInt(dgvProveedores.Item(1, dgvProveedores.CurrentRow.Index).Value)
                        _oLogicaProducto.Eliminar_Proveedor(oProductoPorProveedor)

                        'Elimina de la lista de proveedores del producto al proveedor seleccionado.
                        For i = 0 To FrmCatalogoMateriales.Producto.ListaProveedores.Count - 1
                            If FrmCatalogoMateriales.Producto.ListaProveedores(i).IdProveedor = oProductoPorProveedor.IdProveedor Then
                                FrmCatalogoMateriales.Producto.ListaProveedores.RemoveAt(i)
                                i = FrmCatalogoMateriales.Producto.ListaProveedores.Count
                            End If
                        Next

                        'Carga todos los proveedores que tiene el producto
                        dgvProveedores.DataSource = Nothing
                        If FrmCatalogoMateriales.Producto.ListaProveedores.Count > 0 Then
                            dgvProveedores.DataSource = FrmCatalogoMateriales.Producto.ListaProveedores
                            CambiarPropiedadesdgvProveedores()
                        End If

                        'Reasigna todos los números de prioridades de los proveedores
                        For i As Integer = 0 To dgvProveedores.RowCount - 1
                            dgvProveedores.Item(2, i).Value = i + 1
                        Next
                    End If
                Catch ex As Exception
                    MsgBox("Debe seleccionar el proveedor que desea eliminar")
                End Try
            End If
        End Sub

        Private Sub dgvProveedores_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvProveedores.Click
            Try
                _filaActual = dgvProveedores.CurrentRow.Index
            Catch ex As Exception
                _filaActual = -1
            End Try
        End Sub

        Private Sub btnArriba_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnArriba.Click
            With dgvProveedores
                If .RowCount > 1 Then
                    If _filaActual > 0 Then

                        Dim oProveedorSube As New ProductoPorProveedor
                        oProveedorSube.Id_Producto = .Item(0, _filaActual).Value
                        oProveedorSube.IdProveedor = .Item(1, _filaActual).Value
                        oProveedorSube.Prioridad = .Item(2, _filaActual).Value
                        oProveedorSube.NombreProveedor = .Item(3, _filaActual).Value

                        .Item(0, _filaActual).Value = .Item(0, _filaActual - 1).Value
                        .Item(1, _filaActual).Value = .Item(1, _filaActual - 1).Value
                        .Item(2, _filaActual).Value = .Item(2, _filaActual - 1).Value + 1
                        .Item(3, _filaActual).Value = .Item(3, _filaActual - 1).Value

                        .Item(0, _filaActual - 1).Value = oProveedorSube.Id_Producto
                        .Item(1, _filaActual - 1).Value = oProveedorSube.IdProveedor
                        .Item(2, _filaActual - 1).Value = oProveedorSube.Prioridad - 1
                        .Item(3, _filaActual - 1).Value = oProveedorSube.NombreProveedor

                        .Rows(_filaActual - 1).Selected = True
                        .FirstDisplayedScrollingRowIndex = _filaActual - 1
                        _filaActual -= 1
                    End If
                End If
            End With
        End Sub

        Private Sub btnAbajo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAbajo.Click
            With dgvProveedores
                If .RowCount > 1 Then
                    If _filaActual < .RowCount - 1 Then

                        Dim oProveedorBaja As New ProductoPorProveedor
                        oProveedorBaja.Id_Producto = .Item(0, _filaActual).Value
                        oProveedorBaja.IdProveedor = .Item(1, _filaActual).Value
                        oProveedorBaja.Prioridad = .Item(2, _filaActual).Value
                        oProveedorBaja.NombreProveedor = .Item(3, _filaActual).Value

                        .Item(0, _filaActual).Value = .Item(0, _filaActual + 1).Value
                        .Item(1, _filaActual).Value = .Item(1, _filaActual + 1).Value
                        .Item(2, _filaActual).Value = .Item(2, _filaActual + 1).Value - 1
                        .Item(3, _filaActual).Value = .Item(3, _filaActual + 1).Value

                        .Item(0, _filaActual + 1).Value = oProveedorBaja.Id_Producto
                        .Item(1, _filaActual + 1).Value = oProveedorBaja.IdProveedor
                        .Item(2, _filaActual + 1).Value = oProveedorBaja.Prioridad + 1
                        .Item(3, _filaActual + 1).Value = oProveedorBaja.NombreProveedor

                        .Rows(_filaActual + 1).Selected = True
                        .FirstDisplayedScrollingRowIndex = _filaActual + 1
                        _filaActual += 1
                    End If
                End If
            End With
        End Sub

        Private Sub btnAgregarProveedor_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAgregarProveedor.Click
            Dim valida As Boolean = True

            If cmbProveedores.SelectedIndex = -1 Then
                MsgBox("Debe de seleccionar un proveedor antes de precionar agregar")
                valida = False
            End If

            If valida Then
                Dim oProductoPorProveedor As New ProductoPorProveedor
                oProductoPorProveedor.IdProveedor = _oTblProveedores.Rows(cmbProveedores.SelectedIndex - 1).Item(0)
                oProductoPorProveedor.NombreProveedor = _oTblProveedores.Rows(cmbProveedores.SelectedIndex - 1).Item(1)
                oProductoPorProveedor.Prioridad = CInt(dgvProveedores.Rows.Count + 1)
                FrmCatalogoMateriales.Producto.ListaProveedores.Add(oProductoPorProveedor)
                dgvProveedores.DataSource = Nothing
                dgvProveedores.DataSource = FrmCatalogoMateriales.Producto.ListaProveedores
                cmbProveedores.Text = String.Empty
                cmbProveedores.SelectedIndex = -1
                CambiarPropiedadesdgvProveedores()
            End If
        End Sub

        Private Sub btnAplicar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAplicar.Click
            Dispose()
        End Sub

        Private Sub FrmProveedoresProducto_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub
    End Class
End Namespace