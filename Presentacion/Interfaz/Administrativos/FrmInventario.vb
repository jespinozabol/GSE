Imports Entidades
Imports Logica_Negocios
Imports Presentacion.Interfaz.Catalogo


Namespace Interfaz.Administrativos
    Public Class FrmInventario

        Private ReadOnly _oLogicaProducto As New LogicaProducto
        Private ReadOnly _oUtilidades As New Utilidades

        Private Sub FrmInventario_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            AddHandler txtCodInicial.KeyPress, AddressOf ValidarSoloNumeros
            AddHandler txtCodFinal.KeyPress, AddressOf ValidarSoloNumeros
            cmbTipoConsulta.SelectedIndex = 0
            dgvProductos.ContextMenuStrip = Catalogo
            AddHandler dgvProductos.MouseDown, AddressOf SeleccionaClickDerecho
        End Sub

        Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscar.Click
            Limpiar()
            Cursor.Current = Cursors.WaitCursor

            If IsNumeric(txtCodInicial.Text) And IsNumeric(txtCodFinal.Text) Then
                If CInt(txtCodInicial.Text) < CInt(txtCodFinal.Text) Then
                    Dim rango As Integer

                    If rbTodas.Checked Then
                        rango = 0
                    ElseIf rbConsignacion.Checked Then
                        rango = 1
                    Else
                        rango = 2
                    End If

                    Dim oProductos As New List(Of Producto)
                    Select Case cmbTipoConsulta.SelectedIndex
                        Case 0
                            oProductos = _oLogicaProducto.ConsultarPorRangoTodas(CInt(txtCodInicial.Text), CInt(txtCodFinal.Text), rango)
                        Case 1
                            oProductos = _oLogicaProducto.ConsultarPorRangoPositivos(CInt(txtCodInicial.Text), CInt(txtCodFinal.Text), rango)
                        Case 2
                            oProductos = _oLogicaProducto.ConsultarPorRangoNegativos(CInt(txtCodInicial.Text), CInt(txtCodFinal.Text), rango)
                    End Select

                    LlenarDataGrid(oProductos)
                Else
                    MsgBox("El código final no puede ser mayor al código inical", MsgBoxStyle.Critical, "Error buscando por rango de códigos")
                End If
            Else
                MsgBox("Deben existir el código de Inicio y Fin de búsqueda", MsgBoxStyle.Critical, "Error buscando por rango de códigos")
            End If
            Cursor.Current = Cursors.Default
            If dgvProductos.RowCount > 0 Then dgvProductos.Rows(0).Selected = False
        End Sub

        Private Sub LlenarDataGrid(ByVal oProductos As List(Of Producto))
            Dim totalGeneral As Double
            Dim totalLinea As Double

            For i = 0 To oProductos.Count - 1
                If oProductos(i).Existencias >= 0 Then
                    totalLinea = (oProductos(i).PrecioUnitario * oProductos(i).Existencias)
                    dgvProductos.Rows.Add(oProductos(i).Id_Producto, oProductos(i).Descripcion, oProductos(i).PrecioUnitario, oProductos(i).Existencias, totalLinea, oProductos(i).Impuesto = False)
                Else
                    totalLinea = 0
                    dgvProductos.Rows.Add(oProductos(i).Id_Producto, oProductos(i).Descripcion, oProductos(i).PrecioUnitario, oProductos(i).Existencias, "", oProductos(i).Impuesto = False)
                    dgvProductos.Rows(i).DefaultCellStyle.BackColor = Color.OrangeRed
                End If
                totalGeneral += totalLinea
            Next

            lblMostarTotal.Text = String.Concat("¢", _oUtilidades.PasarMoneda(totalGeneral))
        End Sub

        Private Sub Limpiar()
            dgvProductos.Rows.Clear()
            lblMostarTotal.Text = String.Empty
        End Sub

        Private Sub txtCodInicial_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtCodInicial.KeyDown
            If e.KeyValue = Keys.Enter Then
                txtCodFinal.Focus()
                txtCodFinal.SelectAll()
            End If

        End Sub

        Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnExportar.Click
            Cursor.Current = Cursors.WaitCursor
            Dim msg As String = "Datos imcompletos, Debe agregar al menos un producto"
            If dgvProductos.RowCount <> 0 Then
                Dim reporte As New RptInventario
                Dim table = GuardarLineas()
                If table.Rows.Count <> 0 Then
                    reporte.SetDataSource(table)
                    FrmReportesComprobantes.crvListado.ReportSource = reporte
                    FrmReportesComprobantes.crvListado.ShowPrintButton = True
                    FrmReportesComprobantes.crvListado.ShowGotoPageButton = True
                    FrmReportesComprobantes.crvListado.ShowPageNavigateButtons = True
                    FrmReportesComprobantes.ShowDialog()
                    msg = String.Empty
                End If
            End If
            Cursor.Current = Cursors.Default
            If Not String.IsNullOrEmpty(msg) Then
                MessageBox.Show(msg, "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Sub

        Private Function GuardarLineas() As DataTable
            Dim table = InicializarDataTable()
            With dgvProductos
                For i = 0 To .Rows.Count - 1
                    Dim totalLinea As Double = 0
                    If .Rows(i).DefaultCellStyle.BackColor <> Color.OrangeRed Then totalLinea = .Item(4, i).Value
                    LlenarFila(table, .Item(0, i).Value, .Item(1, i).Value, .Item(2, i).Value,
                               .Item(3, i).Value, totalLinea, .Item(5, i).Value)
                Next i
            End With

            Return table
        End Function

        Private Sub LlenarFila(ByVal table As DataTable, ByVal idProducto As Integer, ByVal articulo As String,
                               ByVal precio As Double, ByVal existencias As Double, ByVal totalLinea As Double, ByVal impuesto As Boolean)
            Dim fila As DataRow
            fila = table.NewRow
            fila.Item("Id_Producto") = idProducto
            fila.Item("Descripcion") = articulo
            fila.Item("PrecioUnitario") = precio
            fila.Item("Existencias") = existencias
            fila.Item("Total") = totalLinea
            fila.Item("Impuesto") = impuesto
            table.Rows.Add(fila)
        End Sub

        Private Function InicializarDataTable() As DataTable
            Dim table As DataTable
            Dim colum As DataColumn

            table = New DataTable("rptInventario")
            colum = New DataColumn("Id_Producto", Type.GetType("System.Int32"))
            table.Columns.Add(colum)
            colum = New DataColumn("Descripcion")
            table.Columns.Add(colum)
            colum = New DataColumn("PrecioUnitario", Type.GetType("System.Single"))
            table.Columns.Add(colum)
            colum = New DataColumn("Existencias", Type.GetType("System.Single"))
            table.Columns.Add(colum)
            colum = New DataColumn("Total", Type.GetType("System.Single"))
            table.Columns.Add(colum)
            colum = New DataColumn("Impuesto", Type.GetType("System.Int16"))
            table.Columns.Add(colum)
            Return table
        End Function

        Private Sub txtCodFinal_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodFinal.KeyDown
            If e.KeyValue = Keys.Enter Then btnBuscar.Focus()
        End Sub

        Private Sub EditarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarToolStripMenuItem.Click
            If dgvProductos.Rows.Count > 0 Then
                FrmCatalogoMateriales.txtCodigo.Text = dgvProductos.Item(0, dgvProductos.CurrentCell.RowIndex).Value
                FrmCatalogoMateriales.pantalla = 1
                FrmCatalogoMateriales.ShowDialog()
            End If
        End Sub

        Private Sub FrmInventario_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub
    End Class
End Namespace