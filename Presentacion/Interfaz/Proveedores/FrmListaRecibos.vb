Imports Logica_Negocios
Imports Entidades

Namespace Interfaz.Proveedores
    Public Class FrmListaRecibos

        Private ReadOnly _oUtilidades As New Utilidades
        Private ReadOnly _oLogicaReciboDocPorPagar As New LogicaReciboDocPorPagar
        Private ReadOnly _oLogicaDocPorPagar As New LogicaDocPorPagar
        Private ReadOnly _oLogicaProveedor As New LogicaProveedor
        Private ReadOnly _oLogicaVarios As New LogicaVarios
        Private ReadOnly _oLogicaAbono As New LogicaAbonoDocPorPagar


        Private Sub cmbTipoConsulta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbTipoConsulta.SelectedIndexChanged
            With cmbTipoConsulta
                Select Case .SelectedIndex
                    Case 0
                        txtDato.Enabled = False
                        txtDato.Visible = True
                        txtDato2.Visible = False
                        chkRangoFechas.Enabled = True
                    Case 1
                        txtDato.Enabled = True
                        txtDato.Visible = True
                        txtDato2.Visible = False
                        chkRangoFechas.Enabled = True
                        txtDato.Focus()
                    Case 2
                        chkRangoFechas.Enabled = False
                        txtDato.Visible = False
                        txtDato2.Visible = True
                        txtDato2.Text = String.Empty
                        txtDato2.Focus()
                    Case 3
                        chkRangoFechas.Enabled = False
                        txtDato.Visible = False
                        txtDato2.Visible = True
                        txtDato2.Text = String.Empty
                        txtDato2.Focus()
                End Select
                txtDato.Text = String.Empty
            End With
        End Sub

        Private Sub txtDato_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtDato.Click
            txtDato.Text = String.Empty
            txtDato2.Text = String.Empty
            txtIdProveedor.Text = String.Empty
            dgvProveedores.Visible = False
            dgvLista.Rows.Clear()
        End Sub

        Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscar.Click
            BuscarFacturas()
        End Sub

        Private Sub FrmLista_Recibos_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load

            AddHandler txtDato2.KeyPress, AddressOf ValidarSoloNumeros

            cmbTipoConsulta.SelectedIndex = 1
            Dim primer = DateSerial(Now.Year, Now.Month, 1)
            Dim ultimo = DateSerial(Now.Year, Now.Month + 1, 0)

            dtpInicio.Value = New DateTime(primer.Year, primer.Month, primer.Day)
            dtpFinal.Value = New DateTime(ultimo.Year, ultimo.Month, ultimo.Day)
        End Sub

        Private Sub dgvProveedores_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles dgvProveedores.KeyDown
            If e.KeyValue = 13 Then
                txtIdProveedor.Text = dgvProveedores.Item(0, dgvProveedores.CurrentRow.Index).Value
                txtDato.Text = dgvProveedores.Item(1, dgvProveedores.CurrentRow.Index).Value
                dgvProveedores.Visible = False
                btnBuscar.Focus()
            End If
        End Sub

        Private Sub dgvProveedores_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvProveedores.Click
            txtIdProveedor.Text = dgvProveedores.Item(0, dgvProveedores.CurrentRow.Index).Value
            txtDato.Text = dgvProveedores.Item(1, dgvProveedores.CurrentRow.Index).Value
            dgvProveedores.Visible = False
            btnBuscar.Focus()
        End Sub

        Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles EliminarToolStripMenuItem.Click
            If dgvLista.RowCount > 0 Then
                If rbRecibos.Checked Then
                    Dim respuesta As String
                    respuesta = MsgBox("Esta seguro que desea eliminar el recibo #" & dgvLista.Item(1, dgvLista.CurrentCell.RowIndex).Value, vbCritical + vbYesNo, "Eliminar recibo..")

                    If respuesta = vbYes Then
                        Dim numRecibo = dgvLista.Item(0, dgvLista.CurrentCell.RowIndex).Value
                        _oLogicaReciboDocPorPagar.eliminarRecibo(numRecibo)
                        MsgBox("Recibo eliminado con éxito", MsgBoxStyle.Information)
                        BuscarFacturas()
                    End If
                End If
            End If
        End Sub

        Public Sub BuscarFacturas()
            dgvLista.Rows.Clear()

            Dim rango As Boolean = False
            If chkRangoFechas.Checked Then
                rango = True
            End If

            If rbRecibos.Checked Then
                Dim oTblRecibos As New DataTable

                Select Case cmbTipoConsulta.SelectedIndex
                    Case 0
                        If rango Then
                            oTblRecibos = _oLogicaReciboDocPorPagar.consultarTodosInfo(dtpInicio.Value, dtpFinal.Value)
                        Else
                            oTblRecibos = _oLogicaReciboDocPorPagar.consultarTodosInfo()
                        End If
                    Case 1
                        If txtIdProveedor.Text <> "" Then
                            If rango Then
                                oTblRecibos = _oLogicaReciboDocPorPagar.consultarPorIdProveedor(CInt(txtIdProveedor.Text), dtpInicio.Value, dtpFinal.Value)
                            Else
                                oTblRecibos = _oLogicaReciboDocPorPagar.consultarPorIdProveedor(CInt(txtIdProveedor.Text))
                            End If
                        End If
                    Case 2
                        If txtDato2.Text <> "" Then
                            oTblRecibos = _oLogicaReciboDocPorPagar.consultarPorNumReciboProveedor(CInt(txtDato2.Text))
                        End If
                    Case 3
                        oTblRecibos = _oLogicaReciboDocPorPagar.consultarPorNumFactura(txtDato2.Text)
                End Select

                Dim rowList = oTblRecibos.Select("", "Num_Recibo ASC")
                For Each row In rowList
                    Dim recibo = _oLogicaReciboDocPorPagar.ConsultarPorNumRecibo(row(0))
                    dgvLista.Rows.Add(row(0), "RD", row(1), row(2), ObtenerFechaCancelacion(recibo), row(4))
                Next

            ElseIf rbNC.Checked Then

                    Dim oTblNc As New DataTable
                    Dim oTblNcg As New DataTable

                    Select Case cmbTipoConsulta.SelectedIndex
                        Case 0
                            oTblNc = _oLogicaDocPorPagar.ConsultarTodasNc(rango, dtpInicio.Value, dtpFinal.Value)
                            If rango Then
                                oTblNcg = _oLogicaProveedor.ConsultarTodasGeneralesInfo(dtpInicio.Value, dtpFinal.Value)
                            Else
                                oTblNcg = _oLogicaProveedor.ConsultarTodasGeneralesInfo()
                            End If
                        Case 1
                            oTblNc = _oLogicaDocPorPagar.ConsultarNcPorIdProveedorFechas(rango, CInt(txtIdProveedor.Text), dtpInicio.Value, dtpFinal.Value)
                            If rango Then
                                oTblNcg = _oLogicaProveedor.ConsultarPorIdProveedorGenerales(CInt(txtIdProveedor.Text), dtpInicio.Value, dtpFinal.Value)
                            Else
                                oTblNcg = _oLogicaProveedor.ConsultarPorIdProveedorGenerales(CInt(txtIdProveedor.Text))
                            End If
                        Case 2
                            oTblNc = _oLogicaDocPorPagar.ConsultarNcPorNumNc(CInt(txtDato2.Text))
                            oTblNcg = _oLogicaProveedor.ConsultarPorNumNotaCreditoGenerales(CInt(txtDato2.Text))
                        Case 3
                            oTblNc = _oLogicaDocPorPagar.ConsultarPorNumFactura(txtDato2.Text)
                    End Select

                    Dim rowList = oTblNc.Select("", "Id_NC ASC")
                    For Each row In rowList

                        Dim numNc As String = ""
                        If row(1) <> 0 Then
                            numNc = row.Item(1)
                        End If
                        Dim fechaDoc As String = ""
                        If row(3) <> Nothing Then
                            fechaDoc = row.Item(3)
                        End If
                        dgvLista.Rows.Add(row.Item(0), "NC", numNc, row.Item(2), fechaDoc, row.Item(4))
                    Next

                    rowList = oTblNcg.Select("", "Id_NCG ASC")
                    For Each row In rowList
                        Dim numNc As String = ""
                        If row(1) <> 0 Then
                            numNc = row(1)
                        End If
                        Dim fechaDoc As String = ""
                        If row(3) <> Nothing Then
                            fechaDoc = row(3)
                        End If
                        dgvLista.Rows.Add(row(0), "NCG", numNc, row(2), fechaDoc, row(4))
                    Next
            ElseIf rbND.Checked Then

                    Dim oTblNd As New DataTable

                    Select Case cmbTipoConsulta.SelectedIndex
                        Case 0
                            oTblNd = _oLogicaDocPorPagar.ConsultarTodasNd(rango, dtpInicio.Value, dtpFinal.Value)
                        Case 1
                            oTblNd = _oLogicaDocPorPagar.ConsultarNdPorIdProveedorFechas(rango, CInt(txtIdProveedor.Text), dtpInicio.Value, dtpFinal.Value)
                        Case 2
                            If txtDato2.Text <> "" Then
                                oTblNd = _oLogicaDocPorPagar.ConsultarNdPorNumNd(CInt(txtDato2.Text))
                            End If
                        Case 3
                            oTblNd = _oLogicaDocPorPagar.ConsultarNdPorNumFactura(txtDato2.Text)
                    End Select

                Dim rowList = oTblNd.Select("", "Id_ND ASC")
                For Each row In rowList
                    Dim numNd As String = ""
                    If row(1) <> 0 Then
                        numNd = row(1)
                    End If
                    Dim fechaDoc As String = ""
                    If row(3) <> Nothing Then
                        fechaDoc = row(3)
                    End If
                    dgvLista.Rows.Add(row(0), "ND", numNd, row(2), fechaDoc, row(4))
                Next
            End If
            If dgvLista.Rows.Count > 0 Then dgvLista.Rows(0).Selected = False
        End Sub

        Private Sub chkRangoFechas_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkRangoFechas.CheckedChanged
            If chkRangoFechas.Checked Then
                CambiarEstado(True)
            Else
                Dim primer = DateSerial(Now.Year, Now.Month, 1)
                Dim ultimo = DateSerial(Now.Year, Now.Month + 1, 0)

                dtpInicio.Value = New DateTime(primer.Year, primer.Month, primer.Day)
                dtpFinal.Value = New DateTime(ultimo.Year, ultimo.Month, ultimo.Day)
                CambiarEstado(False)
            End If
        End Sub

        Public Sub CambiarEstado(ByVal estado As Boolean)
            lblFechaInicial.Enabled = estado
            lblFechaFinal.Enabled = estado
            dtpInicio.Enabled = estado
            dtpFinal.Enabled = estado
        End Sub

        Private Sub rbRecibos_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbRecibos.CheckedChanged
            AlistarBusqueda()
        End Sub

        Private Sub rbND_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbND.CheckedChanged
            AlistarBusqueda()
        End Sub

        Private Sub rbNC_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbNC.CheckedChanged
            AlistarBusqueda()
        End Sub

        Private Sub AlistarBusqueda()
            chkRangoFechas.Checked = False
            cmbTipoConsulta.SelectedIndex = 1
            dgvLista.DataSource = Nothing
            dgvLista.Rows.Clear()
            btnBuscar.Focus()
        End Sub

        Private Sub VerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles VerToolStripMenuItem.Click
            CargarRecibos(1)
        End Sub

        Private Sub CargarRecibos(ByVal tipoVista As Integer)
            Dim recibo = _oLogicaReciboDocPorPagar.ConsultarPorNumRecibo(dgvLista.Item(0, dgvLista.CurrentRow.Index).Value)
            Dim proveedor = _oLogicaProveedor.ExtraerDatos(recibo.IdProveedor)

            LlenarRecibo(recibo, proveedor.Nombre, tipoVista, ObtenerFechaCancelacion(recibo))
        End Sub

        Private Function ObtenerFechaCancelacion(ByVal recibo As ReciboDocPorPagar) As Date
            Dim idPorPagar As Integer
            For i As Integer = 0 To recibo.ReciboDetalle.Count - 1
                If recibo.ReciboDetalle(i).IdDoc <> 0 And (recibo.ReciboDetalle(i).Tipo = ReciboDocPorPagarDetalle.ListaTipo.Cancelacion Or recibo.ReciboDetalle(i).Tipo = ReciboDocPorPagarDetalle.ListaTipo.FactAbono) Then
                    idPorPagar = recibo.ReciboDetalle(i).IdDoc
                End If
            Next
            Return _oLogicaDocPorPagar.ConsultarPorIdDocPagar(idPorPagar).FechaCancelacion
        End Function
        Private Sub LlenarRecibo(ByVal recibo As ReciboDocPorPagar, ByVal nombre As String, ByVal tipoVista As Integer, ByVal fechaCancelacion As Date)
            Dim rptRecibo As New RptRecibo_DocPorPagar

            With rptRecibo

                Dim table As DataTable
                Dim colum As DataColumn
                Dim fila As DataRow

                table = New DataTable("rpt_RECIBO_DINERO")

                colum = New DataColumn("Tipo")
                table.Columns.Add(colum)
                colum = New DataColumn("Doc")
                table.Columns.Add(colum)
                colum = New DataColumn("Fecha")
                table.Columns.Add(colum)
                colum = New DataColumn("Monto", Type.GetType("System.Single"))
                table.Columns.Add(colum)
                colum = New DataColumn("Tipo2")
                table.Columns.Add(colum)
                colum = New DataColumn("Doc2")
                table.Columns.Add(colum)
                colum = New DataColumn("Fecha2")
                table.Columns.Add(colum)
                colum = New DataColumn("Monto2", Type.GetType("System.Single"))
                table.Columns.Add(colum)
                colum = New DataColumn("Tipo3")
                table.Columns.Add(colum)
                colum = New DataColumn("Doc3")
                table.Columns.Add(colum)
                colum = New DataColumn("Fecha3")
                table.Columns.Add(colum)
                colum = New DataColumn("Monto3", Type.GetType("System.Single"))
                table.Columns.Add(colum)

                Dim indice As Integer = 41

                If recibo.ReciboDetalle.Count < 21 Then
                    indice = recibo.ReciboDetalle.Count - 1
                End If

                For j = 0 To indice

                    If j < 14 Then
                        fila = table.NewRow
                        fila = agregarAFila_Linea1(fila, ObtenerLinea(recibo.ReciboDetalle(j).Tipo, recibo.ReciboDetalle(j).IdDoc))
                        table.Rows.Add(fila)
                    ElseIf j < 28 Then
                        table = agregarAFila_Linea2(table, j, ObtenerLinea(recibo.ReciboDetalle(j).Tipo, recibo.ReciboDetalle(j).IdDoc))
                    Else
                        table = agregarAFila_Linea3(table, j, ObtenerLinea(recibo.ReciboDetalle(j).Tipo, recibo.ReciboDetalle(j).IdDoc))
                    End If
                Next

                Dim faltan = 14 - table.Rows.Count

                For i = 1 To faltan
                    fila = table.NewRow
                    fila = agregarAFila_Linea1(fila, ObtenerLinea(0, 0))
                    table.Rows.Add(fila)
                Next

                .SetDataSource(table)

                Dim montoTotal = recibo.Monto
                Dim decimales As String = _oUtilidades.PasarMoneda(montoTotal)
                Dim dec = decimales.Split(".")

                If CInt(montoTotal) = montoTotal Then
                    .SetParameterValue("montoLetras", _oUtilidades.Num_A_Letras(dec(0)) & " COLONES NETOS.")
                Else
                    .SetParameterValue("montoLetras", _oUtilidades.Num_A_Letras(dec(0)) & " COLONES CON " & dec(1) & "/100.")
                End If

                .SetParameterValue("proveedor", nombre)
                .SetParameterValue("numRecibo", "#" & recibo.NumRecibo)
                .SetParameterValue("monto", montoTotal)

                .SetParameterValue("totalCheques", recibo.TotalCheques)
                .SetParameterValue("totalTransferencia", recibo.TotalTransferencias)
                .SetParameterValue("totalEfectivo", recibo.TotalEfectivo)
                .SetParameterValue("total", recibo.Monto)

                .SetParameterValue("observaciones", recibo.Observaciones)
                .SetParameterValue("fecha", fechaCancelacion)

                Select Case recibo.Concepto
                    Case Entidades.Recibo.ListaConcepto.Cancelacion
                        .SetParameterValue("concepto", "CANCELACION DE FACTURA(S) SEGUN RECIBO #" & recibo.NumReciboProveedor)
                    Case Entidades.Recibo.ListaConcepto.CancelacionAbono
                        .SetParameterValue("concepto", "CANCELACION Y ABONO A FACTURA(S) SEGUN RECIBO #" & recibo.NumReciboProveedor)
                    Case Entidades.Recibo.ListaConcepto.Abono
                        .SetParameterValue("concepto", "ABONO A FACTURA SEGUN RECIBO #" & recibo.NumReciboProveedor)
                End Select

                If tipoVista = 1 Then
                    FrmReportesComprobantes.crvListado.ReportSource = rptRecibo
                    FrmReportesComprobantes.ShowDialog()
                Else
                    Dim nombreImpresora = _oLogicaVarios.ConsultarColumna("Imp_Medio_Oficio")
                    Dim nombrePc = _oLogicaVarios.ConsultarColumna("PC_Medio_Oficio")
                    rptRecibo.PrintOptions.PrinterName = "\\" & nombrePc & "\" & nombreImpresora
                    rptRecibo.PrintToPrinter(1, False, 1, 1)
                End If
            End With
        End Sub

        Private Function ObtenerLinea(ByVal tipo As ReciboDocPorPagarDetalle.ListaTipo, ByVal idDoc As String) As LineaRecibo
            Dim linea = New LineaRecibo
            If idDoc <> "0" And Not String.IsNullOrWhiteSpace(idDoc) Then
                linea.Tipo = formatoTipo(tipo)
                linea.Doc = idDoc
                Dim id = Convert.ToInt32(idDoc)
                Dim fecha = New Date
                Select Case tipo
                    Case ReciboDocPorPagarDetalle.ListaTipo.Abono
                        Dim abono = _oLogicaAbono.ConsultarAbonoPorId(id)
                        fecha = abono.Fecha
                        linea.Monto = abono.Monto
                    Case ReciboDocPorPagarDetalle.ListaTipo.Cancelacion
                        Dim facturaProveedor = _oLogicaDocPorPagar.ConsultarPorIdDocPagar(id)
                        fecha = facturaProveedor.Fecha
                        linea.Monto = facturaProveedor.Total
                    Case ReciboDocPorPagarDetalle.ListaTipo.FactAbono
                        Dim facturaProveedor = _oLogicaDocPorPagar.ConsultarPorIdDocPagar(id)
                        fecha = facturaProveedor.Fecha
                        linea.Monto = facturaProveedor.Total
                    Case ReciboDocPorPagarDetalle.ListaTipo.NotaCredito
                        Dim facturaProveedor = _oLogicaDocPorPagar.ConsultarPorIdNC(id)
                        fecha = facturaProveedor.Fecha
                        linea.Monto = facturaProveedor.Total
                    Case ReciboDocPorPagarDetalle.ListaTipo.NotaDebito
                        Dim facturaProveedor = _oLogicaDocPorPagar.ConsultarPorIdND(id)
                        fecha = facturaProveedor.Fecha
                        linea.Monto = facturaProveedor.Total
                End Select

                If fecha = New Date Then
                    linea.Fecha = ""
                Else
                    linea.Fecha = fecha
                End If
            Else
                linea.Fecha = "-"
                linea.Monto = 0
                linea.Tipo = "-"
                linea.Doc = "-"
            End If
            
            Return linea
        End Function

        Private Function agregarAFila_Linea1(ByVal fila As DataRow, ByVal linea As LineaRecibo) As DataRow
            fila.Item("Tipo") = linea.Tipo
            fila.Item("Doc") = linea.Doc
            fila.Item("Fecha") = linea.Fecha
            fila.Item("Monto") = linea.Monto

            Return fila
        End Function

        Private Function agregarAFila_Linea2(ByVal table As DataTable, ByVal j As Integer, ByVal linea As LineaRecibo) As DataTable
            table.Rows(j - 14).Item("Tipo2") = linea.Tipo
            table.Rows(j - 14).Item("Doc2") = linea.Doc
            table.Rows(j - 14).Item("Fecha2") = linea.Fecha
            table.Rows(j - 14).Item("Monto2") = linea.Monto

            Return table
        End Function

        Private Function agregarAFila_Linea3(ByVal table As DataTable, ByVal j As Integer, ByVal linea As LineaRecibo) As DataTable
            table.Rows(j - 28).Item("Tipo3") = linea.Tipo
            table.Rows(j - 28).Item("Doc3") = linea.Doc
            table.Rows(j - 28).Item("Fecha3") = linea.Fecha
            table.Rows(j - 28).Item("Monto3") = linea.Monto

            Return table
        End Function

        Private Function formatoTipo(ByVal tipo As ReciboDocPorPagarDetalle.ListaTipo) As String
            Dim cadena As String = ""
            Select Case tipo
                Case ReciboDocPorPagarDetalle.ListaTipo.Abono
                    cadena = "AB"
                Case ReciboDocPorPagarDetalle.ListaTipo.Cancelacion
                    cadena = "CA"
                Case ReciboDocPorPagarDetalle.ListaTipo.FactAbono
                    cadena = "Fact"
                Case ReciboDocPorPagarDetalle.ListaTipo.NotaCreditoGeneral
                    cadena = "NCG"
                Case ReciboDocPorPagarDetalle.ListaTipo.NotaCredito
                    cadena = "NC"
                Case ReciboDocPorPagarDetalle.ListaTipo.NotaDebito
                    cadena = "ND"
            End Select
            Return cadena
        End Function

        Private Sub dgvLista_MouseDown(ByVal sender As System.Object, ByVal e As Windows.Forms.MouseEventArgs) Handles dgvLista.MouseDown
            If e.Button = Windows.Forms.MouseButtons.Right Then

                With sender
                    Dim hti As DataGridView.HitTestInfo = .HitTest(e.X, e.Y)

                    If hti.Type = DataGridViewHitTestType.Cell Then
                        .CurrentCell = _
                            .Rows(hti.RowIndex).Cells(hti.ColumnIndex)
                    End If
                End With

                If rbRecibos.Checked Then
                    sender.ContextMenuStrip = MnLista
                Else
                    sender.ContextMenuStrip = MnNotas
                End If

            End If
        End Sub

        Private Sub FrmLista_Recibos_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub

        Private Sub txtDato_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtDato.KeyDown
            CambiarControlADataGrid(dgvProveedores, e, txtDato, btnBuscar, btnBuscar)
        End Sub

        Private Sub txtDato_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtDato.KeyPress
            BuscarProveedorPorNombre(dgvProveedores, e, txtDato, txtIdProveedor)
        End Sub

        Private Sub EditarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles EditarToolStripMenuItem.Click
            With dgvLista
                Dim oRecibo = _oLogicaReciboDocPorPagar.ConsultarPorNumRecibo(CInt(.Item(0, .CurrentCell.RowIndex).Value))

                If oRecibo.FechaReciboProveedor <> Nothing Then
                    FrmModificarRecibo.txtFecha.Text = oRecibo.FechaReciboProveedor
                End If
                FrmModificarRecibo.lblMontoRecibo.Text = "¢ " & _oUtilidades.PasarMoneda(oRecibo.Monto)
                FrmModificarRecibo.lblNomreEmpresa.Text = .Item(3, .CurrentCell.RowIndex).Value
                FrmModificarRecibo.txtNum_Recibo.Text = oRecibo.NumRecibo
                FrmModificarRecibo.txtNumRecibo.Text = oRecibo.NumReciboProveedor
                FrmModificarRecibo.txtObservaciones.Text = oRecibo.Observaciones

                FrmModificarRecibo.ShowDialog()
            End With
        End Sub

        Private Sub ImprimirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirToolStripMenuItem.Click
            Dim respuesta As String
            respuesta = MsgBox("Esta seguro que desea imprimir este recibo?", vbCritical + vbYesNo, "Realizar Transacción...")

            If respuesta = vbYes Then
                CargarRecibos(2)
            End If
        End Sub

        Private Sub VerNotasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VerNotasToolStripMenuItem1.Click
            If (rbNC.Checked) Then
                If dgvLista.Item(1, dgvLista.CurrentRow.Index).Value = "NC" Then
                    Dim nota = _oLogicaDocPorPagar.ConsultarPorIdNC(dgvLista.Item(0, dgvLista.CurrentRow.Index).Value)
                    Dim factura = _oLogicaDocPorPagar.ConsultarPorIdDocPagar(nota.IdDocPorPagar)
                    Dim proveedor = _oLogicaProveedor.ExtraerDatos(factura.IdProveedor)

                    mostrarNC(proveedor.Nombre, String.Format("NC-{0}", nota.IdNC), nota.Fecha, factura.NumFactura, nota.BoletaDev, nota.FechaBoleta, nota.SubTotalIV,
                              nota.SubTotalEx, nota.IV, nota.Total, nota.PorDescuento, nota.Motivo, nota.NumNC)
                Else
                    Dim nota = _oLogicaProveedor.ConsultarGeneralPorIdNcg(dgvLista.Item(0, dgvLista.CurrentRow.Index).Value)
                    Dim proveedor = _oLogicaProveedor.ExtraerDatos(nota.IdProveedor)

                    mostrarNC(proveedor.Nombre, String.Format("NCG-{0}", nota.IdNcg), nota.Fecha, "NOTA GENERAL", nota.Boleta, nota.FechaBoleta, nota.SubTotalIV,
                              nota.SubTotalEx, nota.IV, nota.Total, nota.PorDescuento, nota.Motivo, nota.NumNC)
                End If

            ElseIf rbND.Checked Then
                Dim nota = _oLogicaDocPorPagar.ConsultarPorIdND(dgvLista.Item(0, dgvLista.CurrentRow.Index).Value)
                Dim factura = _oLogicaDocPorPagar.ConsultarPorIdDocPagar(nota.IdDocPorPagar)
                Dim proveedor = _oLogicaProveedor.ExtraerDatos(factura.IdProveedor)

                Dim rptRecibo As New RptND_DocPorPagar

                With rptRecibo
                    .SetParameterValue("cliente", proveedor.Nombre)
                    .SetParameterValue("numNota", String.Format("ND-{0}", nota.IdND))
                    .SetParameterValue("numNotaProveedor", nota.NumND)
                    .SetParameterValue("fecha", nota.Fecha)
                    .SetParameterValue("numFactura", factura.NumFactura)
                    .SetParameterValue("numBoleta", String.Empty)
                    If nota.Boleta <> 0 Then
                        .SetParameterValue("numBoleta", nota.Boleta)
                    End If
                    .SetParameterValue("fechaBoleta", String.Empty)
                    If nota.FechaBoleta <> Nothing Then
                        .SetParameterValue("fechaBoleta", nota.FechaBoleta)
                    End If
                    .SetParameterValue("subTotalIV", "¢" & _oUtilidades.PasarMoneda(nota.SubTotalIV))
                    .SetParameterValue("subTotalEx", "¢" & _oUtilidades.PasarMoneda(nota.SubTotalEx))
                    .SetParameterValue("impuesto", "¢" & _oUtilidades.PasarMoneda(nota.IV))
                    .SetParameterValue("total", "¢" & _oUtilidades.PasarMoneda(nota.Total))
                    .SetParameterValue("motivo", nota.Motivo)
                    FrmReportesComprobantes.crvListado.ReportSource = rptRecibo
                    FrmReportesComprobantes.ShowDialog()
                End With
            End If

        End Sub

        Private Sub mostrarNC(nombre As String, numNota As String, fecha As Date, numFactura As String, numBoleta As Integer,
                              fechaBoleta As Date, subTotalIV As Double, subTotalEx As Double, iv As Double, total As Double,
                              porDescuento As Boolean, motivo As String, numNotaProveedor As String)
            Dim rptRecibo As New RptNC_DocPorPagar
            With rptRecibo
                .SetParameterValue("cliente", nombre)
                .SetParameterValue("numNota", numNota)
                .SetParameterValue("numNotaProveedor", numNotaProveedor)
                .SetParameterValue("fecha", fecha)
                .SetParameterValue("numFactura", numFactura)
                .SetParameterValue("numBoleta", String.Empty)
                If numBoleta <> 0 Then
                    .SetParameterValue("numBoleta", numBoleta)
                End If
                .SetParameterValue("fechaBoleta", String.Empty)
                If fechaBoleta <> Nothing Then
                    .SetParameterValue("fechaBoleta", fechaBoleta)
                End If
                .SetParameterValue("subTotalIV", "¢" & _oUtilidades.PasarMoneda(subTotalIV))
                .SetParameterValue("subTotalEx", "¢" & _oUtilidades.PasarMoneda(subTotalEx))
                .SetParameterValue("impuesto", "¢" & _oUtilidades.PasarMoneda(iv))
                .SetParameterValue("total", "¢" & _oUtilidades.PasarMoneda(total))
                If porDescuento Then
                    .SetParameterValue("porDescuento", "SI")
                Else
                    .SetParameterValue("porDescuento", "NO")
                End If
                .SetParameterValue("motivo", motivo)
                FrmReportesComprobantes.crvListado.ReportSource = rptRecibo
                FrmReportesComprobantes.ShowDialog()
            End With
        End Sub

        Private Sub txtDato_MouseCaptureChanged(sender As Object, e As EventArgs) Handles txtDato.MouseCaptureChanged
            txtDato.Text = String.Empty
            txtDato2.Text = String.Empty
            dgvProveedores.Visible = False
            txtIdProveedor.Text = String.Empty
            dgvLista.Rows.Clear()
        End Sub
    End Class
End Namespace