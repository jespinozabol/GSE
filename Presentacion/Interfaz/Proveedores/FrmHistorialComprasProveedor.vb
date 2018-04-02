Imports Entidades
Imports Logica_Negocios

Namespace Interfaz.Proveedores
    Public Class FrmHistorialComprasPorProveedor

        Private ReadOnly _oUtilidades As New Utilidades
        Private ReadOnly _oLogicaProveedor As New LogicaProveedor
        Private ReadOnly _oLogicaDocPorPadar As New LogicaDocPorPagar
        Private ReadOnly _oLogicaVarios As New LogicaVarios

        Private Sub FrmConsultarFactura_Proveedor_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            AddHandler dgvFacturas.MouseDown, AddressOf seleccionaClickDerecho
            AddHandler txtDato2.KeyPress, AddressOf ValidarSoloNumeros

            cmbTipoConsulta.SelectedIndex = 2
            Dim primer = DateSerial(Now.Year, Now.Month - 1, 1)
            Dim ultimo = DateSerial(Now.Year, Now.Month + 0, 0)

            dtpInicio.Value = New DateTime(primer.Year, primer.Month, primer.Day)
            dtpFinal.Value = New DateTime(ultimo.Year, ultimo.Month, ultimo.Day)
            dgvFacturas.ContextMenuStrip = MnEditar
        End Sub

        Private Sub cmbTipoConsulta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbTipoConsulta.SelectedIndexChanged
            With cmbTipoConsulta
                Select Case .SelectedIndex
                    Case 0
                        txtDato.Visible = True
                        txtDato2.Visible = False
                        txtDato.Focus()
                    Case 1
                        txtDato2.Visible = True
                        txtDato.Visible = False
                        txtDato2.Focus()
                    Case 2
                        txtDato.Visible = False
                        txtDato2.Visible = False
                End Select
                LimpiarTodo()
            End With
        End Sub

        Public Sub CambiarEstado(ByVal estado As Boolean)
            lblFechaInicial.Enabled = estado
            lblFechaFinal.Enabled = estado
            dtpInicio.Enabled = estado
            dtpFinal.Enabled = estado
        End Sub

        Private Sub LimpiarTodo()
            txtDato.Text = String.Empty
            dgvFacturas.Rows.Clear()
            txtDato2.Text = String.Empty
            dgvProveedor.Visible = False
        End Sub

        Private Sub dgvProveedor_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvProveedor.Click
            txtIdProveedor.Text = dgvProveedor.Item(0, dgvProveedor.CurrentRow.Index).Value
            txtDato.Text = dgvProveedor.Item(1, dgvProveedor.CurrentRow.Index).Value
            dgvProveedor.Visible = False
            btnBuscar.Focus()
        End Sub

        Private Sub dgvProveedor_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles dgvProveedor.KeyDown
            If (e.KeyValue = 13) Then
                txtIdProveedor.Text = dgvProveedor.Item(0, dgvProveedor.CurrentRow.Index).Value
                txtDato.Text = dgvProveedor.Item(1, dgvProveedor.CurrentRow.Index).Value
                dgvProveedor.Visible = False
                btnBuscar.Focus()
            End If
        End Sub

        Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscar.Click
            dgvFacturas.Rows.Clear()

            Dim oListaDocsPorPagar As New List(Of FacturaProveedor)
            Dim nombreProveedor As String = ""

            Dim subTotalConIV As Double = 0.0
            Dim subTotalSinIV As Double = 0.0
            Dim impuesto As Double = 0.0
            Dim ivnc As Double = 0.0
            Dim ivnd As Double = 0.0
            Dim totalFacturas As Double = 0.0
            Dim totalNc As Double = 0.0
            Dim totalNd As Double = 0.0
            Dim subTotalIvnc As Double = 0.0
            Dim subTotalExNc As Double = 0.0
            Dim subTotalIvnd As Double = 0.0
            Dim subTotalExNd As Double = 0.0

            'Rango = 
            ' 0 = pendientes
            ' 1 = canceladas
            ' 2 = sin anular
            ' 3 = anuladas
            ' 4 = todas
            Dim rango As Integer

            If rbPendiente.Checked Then
                rango = 0
            ElseIf rbCancelada.Checked Then
                rango = 1
            ElseIf rbSinAnular.Checked Then
                rango = 2
            ElseIf rbAnulada.Checked Then
                rango = 3
            Else
                rango = 4
            End If


            Select Case cmbTipoConsulta.SelectedIndex
                Case 0
                    If txtDato.Text <> "" Then
                        If chkRangoFechas.Checked Then
                            oListaDocsPorPagar = _oLogicaDocPorPadar.consultarPorIdProveedorRangoFechas(CInt(txtIdProveedor.Text), rango, dtpInicio.Value, dtpFinal.Value)
                        Else
                            oListaDocsPorPagar = _oLogicaDocPorPadar.consultarPorIdProveedor(CInt(txtIdProveedor.Text), rango)
                        End If
                        nombreProveedor = txtDato.Text
                    End If
                Case 1
                    If txtDato2.Text <> "" Then
                        If chkRangoFechas.Checked Then
                            oListaDocsPorPagar = _oLogicaDocPorPadar.consultarPorIdProveedorRangoFechas(CInt(txtDato2.Text), rango, dtpInicio.Value, dtpFinal.Value)
                        Else
                            oListaDocsPorPagar = _oLogicaDocPorPadar.consultarPorIdProveedor(CInt(txtDato2.Text), rango)
                        End If
                        nombreProveedor = _oLogicaProveedor.consultarNombre_PorCodigo(CInt(txtDato2.Text))
                    End If
                Case 2
                    If chkRangoFechas.Checked Then
                        oListaDocsPorPagar = _oLogicaDocPorPadar.consultarTodasRangoFecha(rango, dtpInicio.Value, dtpFinal.Value)
                    Else
                        oListaDocsPorPagar = _oLogicaDocPorPadar.consultarTodas(rango)
                    End If
            End Select

            For i = 0 To oListaDocsPorPagar.Count - 1

                If cmbTipoConsulta.SelectedIndex = 2 Then
                    nombreProveedor = _oLogicaProveedor.consultarNombre_PorCodigo(oListaDocsPorPagar(i).IdProveedor)
                End If

                dgvFacturas.Rows.Add(oListaDocsPorPagar(i).IdDocPagar, oListaDocsPorPagar(i).Fecha, oListaDocsPorPagar(i).NumFactura, nombreProveedor, oListaDocsPorPagar(i).SubTotalIV, oListaDocsPorPagar(i).SubTotalEx, oListaDocsPorPagar(i).IV, oListaDocsPorPagar(i).Total, oListaDocsPorPagar(i).Estado)

                Dim oListaNc = _oLogicaDocPorPadar.consultarNC_IDDocPagar(oListaDocsPorPagar(i).IdDocPagar)

                For j = 0 To oListaNc.Count - 1
                    ivnc += oListaNc(j).IV
                    totalNc += oListaNc(j).Total
                    subTotalIvnc += oListaNc(j).SubTotalIV
                    subTotalExNc += oListaNc(j).SubTotalEx
                Next

                Dim oListaNd = _oLogicaDocPorPadar.consultarND_IDDocPagar(oListaDocsPorPagar(i).IdDocPagar)

                For j = 0 To oListaNd.Count - 1
                    ivnd += oListaNd(j).IV
                    totalNd += oListaNd(j).Total
                    subTotalIvnd += oListaNd(j).SubTotalIV
                    subTotalExNd += oListaNd(j).SubTotalEx
                Next

                subTotalConIV += oListaDocsPorPagar(i).SubTotalIV
                subTotalSinIV += oListaDocsPorPagar(i).SubTotalEx
                impuesto += oListaDocsPorPagar(i).IV
                totalFacturas += oListaDocsPorPagar(i).Total
            Next

            lblSubTotalIV.Text = "¢" & _oUtilidades.PasarMoneda(subTotalConIV)
            lblSubTotalGeneral.Text = "¢" & _oUtilidades.PasarMoneda(subTotalConIV - subTotalIvnc + subTotalIvnd)
            lblSubTotalEx.Text = "¢" & _oUtilidades.PasarMoneda(subTotalSinIV)
            lblSubTotalExGeneral.Text = "¢" & _oUtilidades.PasarMoneda(subTotalSinIV - subTotalExNc + subTotalExNd)
            lblIV.Text = "¢" & _oUtilidades.PasarMoneda(impuesto)
            lblTotal.Text = "¢" & _oUtilidades.PasarMoneda(totalFacturas)
            lblIVNC.Text = "¢" & _oUtilidades.PasarMoneda(ivnc)
            lblTotalNC.Text = "¢" & _oUtilidades.PasarMoneda(totalNc)
            lblSubTotalIVNC.Text = "¢" & _oUtilidades.PasarMoneda(subTotalIvnc)
            lblSubTotalExNC.Text = "¢" & _oUtilidades.PasarMoneda(subTotalExNc)
            lblIVGeneral.Text = "¢" & _oUtilidades.PasarMoneda((impuesto - ivnc + ivnd))
            lblTotalGeneral.Text = "¢" & _oUtilidades.PasarMoneda((totalFacturas - totalNc + totalNd))

            lblIVND.Text = "¢" & _oUtilidades.PasarMoneda(ivnd)
            lblTotalND.Text = "¢" & _oUtilidades.PasarMoneda(totalNd)
            lblSubTotalIVND.Text = "¢" & _oUtilidades.PasarMoneda(subTotalIvnd)
            lblSubTotalExND.Text = "¢" & _oUtilidades.PasarMoneda(subTotalExNd)

            If dgvFacturas.RowCount > 0 Then dgvFacturas.Rows(0).Selected = False
        End Sub

        Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnLimpiar.Click
            LimpiarTodo()
            txtDato.Visible = True
            txtDato2.Visible = False
            txtDato.Focus()
            cmbTipoConsulta.SelectedIndex = 0
            lblSubTotalIV.Text = "0.00"
            lblSubTotalGeneral.Text = "0.00"
            lblSubTotalEx.Text = "0.00"
            lblSubTotalExGeneral.Text = "0.00"
            lblIV.Text = "0.00"
            lblIVGeneral.Text = "0.00"
            lblIVNC.Text = "0.00"
            lblTotal.Text = "0.00"
            lblTotalNC.Text = "0.00"
            lblTotalGeneral.Text = "0.00"
            rbTodas.Checked = True
            chkRangoFechas.Checked = False
            CambiarEstado(False)
        End Sub

        Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnImprimir.Click
            If dgvFacturas.RowCount > 0 Then
                Dim respuesta As String
                respuesta = MsgBox("Esta seguro que desea imprimir este reporte de compras?", vbCritical + vbYesNo, "Imprimir Reporte...")

                If (respuesta = vbYes) Then
                    Dim rptDocPorPagar As New RptDocsPorPagar

                    With rptDocPorPagar

                        Dim table As DataTable
                        Dim colum As DataColumn
                        Dim fila As DataRow

                        table = New DataTable("rptdocporpagar")

                        colum = New DataColumn("Fecha")
                        table.Columns.Add(colum)
                        colum = New DataColumn("Num_Factura")
                        table.Columns.Add(colum)
                        colum = New DataColumn("Nombre")
                        table.Columns.Add(colum)
                        colum = New DataColumn("SubTotalIV", Type.GetType("System.Single"))
                        table.Columns.Add(colum)
                        colum = New DataColumn("SubTotalEx", Type.GetType("System.Single"))
                        table.Columns.Add(colum)
                        colum = New DataColumn("IV", Type.GetType("System.Single"))
                        table.Columns.Add(colum)
                        colum = New DataColumn("Total", Type.GetType("System.Single"))
                        table.Columns.Add(colum)

                        For i = 0 To dgvFacturas.Rows.Count - 1
                            fila = table.NewRow
                            fila.Item("Fecha") = dgvFacturas.Item(1, i).Value
                            fila.Item("Num_Factura") = dgvFacturas.Item(2, i).Value
                            fila.Item("Nombre") = dgvFacturas.Item(3, i).Value
                            fila.Item("SubTotalIV") = _oUtilidades.PasarMoneda(dgvFacturas.Item(4, i).Value)
                            fila.Item("SubTotalEx") = _oUtilidades.PasarMoneda(dgvFacturas.Item(5, i).Value)
                            fila.Item("IV") = _oUtilidades.PasarMoneda(dgvFacturas.Item(6, i).Value)
                            fila.Item("Total") = _oUtilidades.PasarMoneda(dgvFacturas.Item(7, i).Value)
                            table.Rows.Add(fila)
                        Next

                        Dim paginas = Int((table.Rows.Count / 22))

                        .SetDataSource(table)

                        .SetParameterValue("total", CDbl(lblTotal.Text.Substring(1)))
                        .SetParameterValue("totalNC", CDbl(lblTotalNC.Text.Substring(1)))
                        .SetParameterValue("totalND", CDbl(lblTotalND.Text.Substring(1)))
                        .SetParameterValue("totalGeneral", CDbl(lblTotalGeneral.Text.Substring(1)))

                        .SetParameterValue("totalIV", CDbl(lblIV.Text.Substring(1)))
                        .SetParameterValue("totalIVNC", CDbl(lblIVNC.Text.Substring(1)))
                        .SetParameterValue("totalIVND", CDbl(lblIVND.Text.Substring(1)))
                        .SetParameterValue("totalIVGeneral", CDbl(lblIVGeneral.Text.Substring(1)))

                        .SetParameterValue("subTotalEx", CDbl(lblSubTotalEx.Text.Substring(1)))
                        .SetParameterValue("subTotalExNC", CDbl(lblSubTotalExNC.Text.Substring(1)))
                        .SetParameterValue("subTotalExND", CDbl(lblSubTotalExND.Text.Substring(1)))
                        .SetParameterValue("subTotalGeneralEx", CDbl(lblSubTotalExGeneral.Text.Substring(1)))

                        .SetParameterValue("subTotalIV", CDbl(lblSubTotalIV.Text.Substring(1)))
                        .SetParameterValue("subTotalIVNC", CDbl(lblSubTotalIVNC.Text.Substring(1)))
                        .SetParameterValue("subTotalIVND", CDbl(lblSubTotalIVND.Text.Substring(1)))
                        .SetParameterValue("subTotalGeneralIV", CDbl(lblSubTotalGeneral.Text.Substring(1)))

                        .SetParameterValue("mes", "Mes " & dtpInicio.Value.Month & " / " & dtpInicio.Value.Year)

                        Dim nombreImpresora = _oLogicaVarios.ConsultarColumna("Imp_Medio_Oficio")
                        Dim nombrePc = _oLogicaVarios.ConsultarColumna("PC_Medio_Oficio")
                        rptDocPorPagar.PrintOptions.PrinterName = "\\" & nombrePc & "\" & nombreImpresora
                        rptDocPorPagar.PrintToPrinter(1, False, 1, paginas + 1)

                    End With
                End If
            Else
                MsgBox("Primero debe seleccionar el informe a imprimir", MsgBoxStyle.Exclamation)
            End If
        End Sub

        Private Sub txtDato_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtDato.Click
            LimpiarTodo()
            cmbTipoConsulta.SelectedIndex = 0
            LimpiarTotales()
            rbTodas.Checked = True

        End Sub

        Private Sub LimpiarTotales()
            lblSubTotalIV.Text = "0.00"
            lblSubTotalGeneral.Text = "0.00"
            lblSubTotalEx.Text = "0.00"
            lblSubTotalExGeneral.Text = "0.00"
            lblIV.Text = "0.00"
            lblIVGeneral.Text = "0.00"
            lblIVNC.Text = "0.00"
            lblTotal.Text = "0.00"
            lblTotalNC.Text = "0.00"
            lblTotalGeneral.Text = "0.00"
            lblSubTotalIVNC.Text = "0.00"
            lblSubTotalExNC.Text = "0.00"
        End Sub
        Private Sub FrmConsultarFactura_Proveedor_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub

        Private Sub dtpFinal_ValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dtpFinal.ValueChanged
            dgvFacturas.Rows.Clear()
            LimpiarTotales()
        End Sub

        Private Sub dtpInicio_ValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dtpInicio.ValueChanged
            dgvFacturas.Rows.Clear()
            LimpiarTotales()
        End Sub

        Private Sub chkRangoFechas_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkRangoFechas.CheckedChanged
            If chkRangoFechas.Checked Then
                CambiarEstado(True)
            Else
                Dim primer = DateSerial(Now.Year, Now.Month - 1, 1)
                Dim ultimo = DateSerial(Now.Year, Now.Month + 0, 0)

                dtpInicio.Value = New DateTime(primer.Year, primer.Month, primer.Day)
                dtpFinal.Value = New DateTime(ultimo.Year, ultimo.Month, ultimo.Day)
                CambiarEstado(False)
            End If
        End Sub

        Private Sub txtDato_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtDato.KeyDown
            cambiarControlADataGrid(dgvProveedor, e, txtDato, btnBuscar, btnBuscar)
        End Sub

        Private Sub txtDato_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtDato.KeyPress
            BuscarProveedorPorNombre(dgvProveedor, e, txtDato, txtIdProveedor)
        End Sub

        Private Sub EditarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarToolStripMenuItem.Click
            If dgvFacturas.CurrentRow.Index >= 0 Then
                FrmDocPorPagar.txtIdDoc_PorPagar.Text = dgvFacturas.Item(0, dgvFacturas.CurrentRow.Index).Value
                FrmDocPorPagar.BuscarDocFactura()
                FrmDocPorPagar.ShowDialog()
            End If
        End Sub
    End Class
End Namespace