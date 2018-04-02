Imports Entidades
Imports Logica_Negocios

Namespace Interfaz.Proveedores
    Public Class FrmPedidos

        Private ReadOnly _oLogicaProducto As New LogicaProducto
        Private ReadOnly _oLogicaProveedor As New LogicaProveedor
        Private _oTblProveedores As New DataTable
        Private _oLista As New List(Of Producto)
        Private ReadOnly _oUtilidades As New Utilidades
        Private ReadOnly _oLogicaVarios As New LogicaVarios
        Private ReadOnly _oLogicaListado As New LogicaListado

        Private Sub rbNombre_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbNombre.CheckedChanged
            If rbNombre.Checked Then
                gbMaterial.Visible = True
                txtDescripcion.Focus()
                dgvProductos.Rows.Clear()
            Else
                gbMaterial.Visible = False
                txtDescripcion.Text = String.Empty
            End If
        End Sub

        Private Sub rbProveedor_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbProveedor.CheckedChanged
            If rbProveedor.Checked Then
                gbProveedor.Visible = True
                cmbProveedor.Items.Clear()
                cmbProveedor.Text = String.Empty
                _oTblProveedores = _oLogicaProveedor.ConsultarTodos
                For i As Integer = 0 To _oTblProveedores.Rows.Count - 1
                    cmbProveedor.Items.Add(_oTblProveedores.Rows(i).Item(1))
                Next
                txtCodigo.Text = String.Empty
                dgvProductos.Rows.Clear()
                txtCodigo.Enabled = False
            Else
                txtCodigo.Text = String.Empty
                txtCodigo.Enabled = True
                gbProveedor.Visible = False
            End If
        End Sub

        Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As EventArgs)
            Dispose()
        End Sub

        Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscar.Click
            dgvProductos.Rows.Clear()
            Cursor.Current = Cursors.WaitCursor
            If rbNombre.Checked Then
                If Trim(txtDescripcion.Text) <> "" Then
                    _oLista = _oLogicaProducto.ConsultarTodoPor_Descripcion(txtDescripcion.Text)

                    For i = _oLista.Count - 1 To 0 Step -1
                        Dim existenciasListados = _oLogicaListado.consultarExistenciasPorProducto(_oLista(i).Id_Producto)
                        Dim cantidadPedir = _oLista(i).Maximo - (_oLista(i).Existencias - existenciasListados)
                        If _oLista(i).Minimo > (_oLista(i).Existencias - existenciasListados) Then
                            dgvProductos.Rows.Add(_oLista(i).Id_Producto, _oLista(i).Descripcion, _oLista(i).Minimo, _oLista(i).Maximo, (_oLista(i).Existencias - existenciasListados), _oLista(i).MaxVendido, cantidadPedir, "Ver")
                        End If
                    Next
                    If dgvProductos.RowCount > 0 Then dgvProductos.Rows(0).Selected = False

                Else
                    MsgBox("Debe de escribir la descipción antes de buscar el producto", MsgBoxStyle.Exclamation)
                End If
            ElseIf rbProveedor.Checked Then
                If Not txtCodigo.Enabled And cmbProveedor.SelectedIndex > 0 Then

                    _oLista = _oLogicaProducto.ConsultarProductosPorProveedor(txtCodigo.Text)

                    For i = _oLista.Count - 1 To 0 Step -1
                        Dim existenciasListados = _oLogicaListado.consultarExistenciasPorProducto(_oLista(i).Id_Producto)
                        Dim cantidadPedir = _oLista(i).Maximo - (_oLista(i).Existencias - existenciasListados)
                        If _oLista(i).Minimo > (_oLista(i).Existencias - existenciasListados) Then
                            dgvProductos.Rows.Add(_oLista(i).Id_Producto, _oLista(i).Descripcion, _oLista(i).Minimo, _oLista(i).Maximo, _oLista(i).Existencias, _oLista(i).MaxVendido, cantidadPedir, "Ver")
                        End If
                    Next
                    If dgvProductos.RowCount > 0 Then dgvProductos.Rows(0).Selected = False
                End If
            ElseIf rbRangoCodigos.Checked Then
                If IsNumeric(txtCodigo1.Text) And IsNumeric(txtCodigo2.Text) Then

                    If CInt(txtCodigo1.Text) < CInt(txtCodigo2.Text) Then

                        _oLista = _oLogicaProducto.ConsultarProductosPorRangoCodigos(CInt(txtCodigo1.Text), CInt(txtCodigo2.Text))

                        For i = _oLista.Count - 1 To 0 Step -1
                            Dim existenciasListados = _oLogicaListado.consultarExistenciasPorProducto(_oLista(i).Id_Producto)
                            Dim cantidadPedir = _oLista(i).Maximo - (_oLista(i).Existencias - existenciasListados)
                            If _oLista(i).Minimo > (_oLista(i).Existencias - existenciasListados) Then
                                dgvProductos.Rows.Add(_oLista(i).Id_Producto, _oLista(i).Descripcion, _oLista(i).Minimo, _oLista(i).Maximo, _oLista(i).Existencias, _oLista(i).MaxVendido, cantidadPedir, "Ver")
                            End If
                        Next
                        If dgvProductos.RowCount > 0 Then dgvProductos.Rows(0).Selected = False

                    Else
                        MsgBox("El código final no puede ser mayor al código inical", MsgBoxStyle.Critical, "Error buscando por rango de códigos")
                    End If

                Else
                    MsgBox("Deben existir el código inicial y final por los que se van a buscar", MsgBoxStyle.Critical, "Error buscando por rango de códigos")
                End If
            End If
            Cursor.Current = Cursors.Default
        End Sub


        Private Sub dgvProductos_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvProductos.Click
            With dgvProductos
                If .Rows(.CurrentRow.Index).Cells(7).Selected Then
                    FrmProductoConProveed.dgvProveedores.DataSource = _oLogicaProducto.ConsultarProveedores(.Rows(.CurrentRow.Index).Cells(0).Value)
                    FrmProductoConProveed.ShowDialog()
                End If
            End With
        End Sub

        Private Sub cmbProveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbProveedor.SelectedIndexChanged
            txtCodigo.Text = _oTblProveedores.Rows(cmbProveedor.SelectedIndex).Item(0)
            dgvProductos.Rows.Clear()
            txtCodigo.Enabled = False
        End Sub

        Private Sub FrmPedidos_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            AddHandler txtCodigo1.KeyPress, AddressOf ValidarSoloNumeros
            AddHandler txtCodigo2.KeyPress, AddressOf ValidarSoloNumeros
        End Sub

        Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnImprimir.Click
            If dgvProductos.RowCount > 0 Then
                Dim reporte As New RptPedido
                Dim imprime As Integer

                imprime = MessageBox.Show("Esta seguro que desea imprimir la lista de pedido?", "Imprimir lista de artículos a pedir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If imprime = 6 Then

                    Dim paginas = _oUtilidades.CalculaPaginas((dgvProductos.Rows.Count) / 20)

                    For i As Integer = 1 To paginas
                        Dim table = InicializarDataTable()
                        reporte.SetDataSource(guardarLineas((i * 20) - 20, table))
                        reporte.SetParameterValue("numPagina", i)
                        reporte.SetParameterValue("paginas", paginas)
                        reporte.SetParameterValue("empresa", cmbProveedor.Text)
                        If chkMostrarExist.Checked Then
                            reporte.SetParameterValue("mostrar", False)
                        Else
                            reporte.SetParameterValue("mostrar", True)
                        End If
                        reporte.SetParameterValue("email", "solucioneselectricas@ice.co.cr")

                        Dim nombreImpresora = _oLogicaVarios.ConsultarColumna("Imp_Medio_Oficio")
                        Dim nombrePc = _oLogicaVarios.ConsultarColumna("PC_Medio_Oficio")
                        reporte.PrintOptions.PrinterName = "\\" & nombrePc & "\" & nombreImpresora
                        reporte.PrintToPrinter(1, False, 1, 1)
                    Next

                End If
            Else
                MsgBox("Debe de realizar la lista antes de presionar imprimir", MsgBoxStyle.Exclamation)
            End If
        End Sub

        Private Function InicializarDataTable() As DataTable
            Dim table As DataTable
            Dim colum As DataColumn

            table = New DataTable("LISTA_PEDIDO")
            colum = New DataColumn("Codigo")
            table.Columns.Add(colum)
            colum = New DataColumn("Descripcion")
            table.Columns.Add(colum)
            colum = New DataColumn("Pedir")
            table.Columns.Add(colum)
            colum = New DataColumn("Exist")
            table.Columns.Add(colum)
            colum = New DataColumn("Linea")
            table.Columns.Add(colum)
            Return table
        End Function

        Private Function GuardarLineas(ByVal inicio As Integer, ByVal table As DataTable) As DataTable
            Dim indice As Integer, final As Integer
            Dim fila As DataRow

            With dgvProductos
                If inicio + 20 < dgvProductos.Rows.Count Then ' reviso si aun quedan 14 o mas lineas
                    final = inicio + 20
                Else
                    final = dgvProductos.Rows.Count
                End If

                For indice = inicio To final - 1
                    fila = table.NewRow
                    fila.Item("Codigo") = dgvProductos.Item(0, indice).Value
                    fila.Item("Descripcion") = dgvProductos.Item(1, indice).Value
                    fila.Item("Pedir") = dgvProductos.Item(6, indice).Value
                    fila.Item("Exist") = dgvProductos.Item(4, indice).Value
                    fila.Item("Linea") = indice + 1
                    table.Rows.Add(fila)
                Next indice

            End With

            Return table
        End Function

        Private Sub rbRangoCodigos_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbRangoCodigos.CheckedChanged
            If rbRangoCodigos.Checked Then
                gbRango.Visible = True
                dgvProductos.Rows.Clear()
                txtCodigo1.Focus()
            Else
                txtCodigo1.Text = String.Empty
                txtCodigo2.Text = String.Empty
                gbRango.Visible = False
            End If
        End Sub

        Private Sub txtCodigo1_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtCodigo1.KeyDown
            If e.KeyValue = 13 Then txtCodigo2.Focus()
        End Sub

        Private Sub txtCodigo2_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtCodigo2.KeyDown
            If e.KeyValue = 13 Then btnBuscar.Focus()
        End Sub

        Private Sub FrmPedidos_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub

        Private Sub txtDescripcion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcion.Click
            txtDescripcion.Text = String.Empty
            dgvProductos.Rows.Clear()
        End Sub

        Private Sub txtCodigo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo1.Click
            dgvProductos.Rows.Clear()
            txtCodigo1.Text = String.Empty
        End Sub

        Private Sub txtCodigo2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo2.Click
            dgvProductos.Rows.Clear()
            txtCodigo2.Text = String.Empty
        End Sub
    End Class
End Namespace