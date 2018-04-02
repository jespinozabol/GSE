Imports Entidades
Imports Logica_Negocios

Namespace Interfaz.Creditos
    Public Class FrmListaComprobantes

        Private ReadOnly _oLogicaReciboDinero As New LogicaReciboDinero
        Private ReadOnly _oLogicaNotasCredito As New LogicaNotaCredito
        Private ReadOnly _oLogicaNotasDebito As New LogicaNotaDebito
        Private ReadOnly _oLogicaVales As New LogicaVale
        Private ReadOnly _oUtilidades As New Utilidades
        Private ReadOnly _oLogicaVarios As New LogicaVarios
        Private ReadOnly _oLogicaClienteCredito As New LogicaClienteCredito
        Private ReadOnly _oLogicaPersona As New LogicaPersona
        Private ReadOnly _oLogicaVale As New LogicaVale
        Private ReadOnly _oLogicaEmpleado As New LogicaEmpleadoOtro
        Private ReadOnly _oLogicaFactura As New LogicaFacturaCredito

        Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscar.Click
            dgvLista.Rows.Clear()

            If rbRecibos.Checked Then
                Dim oTblRecibos As New DataTable

                Select Case cmbTipoConsulta.SelectedIndex
                    Case 0
                        oTblRecibos = _oLogicaReciboDinero.consultarTodosInfo()
                    Case 1
                        If txtIdPersona.Text <> "" Then
                            oTblRecibos = _oLogicaReciboDinero.consultarPorIdPersona(CInt(txtIdPersona.Text))
                        End If
                    Case 2
                        If txtDato2.Text <> "" Then
                            oTblRecibos = _oLogicaReciboDinero.consultarPorNumRecibo(CInt(txtDato2.Text))
                        End If
                    Case 3
                        If txtDato2.Text <> "" Then
                            oTblRecibos = _oLogicaReciboDinero.consultarPorNumFactura(CLng(txtDato2.Text))
                        End If
                End Select

                For i = 0 To oTblRecibos.Rows.Count - 1
                    dgvLista.Rows.Add(oTblRecibos.Rows(i).Item(0), oTblRecibos.Rows(i).Item(1), oTblRecibos.Rows(i).Item(2), oTblRecibos.Rows(i).Item(3), oTblRecibos.Rows(i).Item(4))
                Next

            ElseIf rbNC.Checked Then

                Dim oTblNc As New DataTable
                Dim oTblNcg As New DataTable

                Select Case cmbTipoConsulta.SelectedIndex
                    Case 0
                        oTblNc = _oLogicaNotasCredito.consultarTodasInfo()
                        oTblNcg = _oLogicaNotasCredito.consultarTodasGeneralesInfo()
                    Case 1
                        If txtIdPersona.Text <> "" Then
                            oTblNc = _oLogicaNotasCredito.ConsultarPorIdPersona(CInt(txtIdPersona.Text))
                            oTblNcg = _oLogicaNotasCredito.ConsultarPorIdPersonaGenerales(CInt(txtIdPersona.Text))
                        End If
                    Case 2
                        If txtDato2.Text <> "" Then
                            oTblNc = _oLogicaNotasCredito.ConsultarPorNumNotaCredito(CInt(txtDato2.Text))
                            oTblNcg = _oLogicaNotasCredito.ConsultarPorNumNotaCreditoGenerales(CInt(txtDato2.Text))
                        End If
                    Case 3
                        If txtDato2.Text <> "" Then
                           oTblNc = _oLogicaNotasCredito.ConsultarPorNumFactura(CLng(txtDato2.Text))
                        End If
                End Select

                Dim docNulo As Boolean
                For i = 0 To oTblNc.Rows.Count - 1
                    docNulo = False
                    If oTblNc.Rows(i).Item(4) = 2 Then
                        docNulo = True
                    End If
                    dgvLista.Rows.Add(oTblNc.Rows(i).Item(0), oTblNc.Rows(i).Item(1), oTblNc.Rows(i).Item(2), oTblNc.Rows(i).Item(3), docNulo)
                Next

                For i = 0 To oTblNcg.Rows.Count - 1
                    docNulo = False
                    If oTblNcg.Rows(i).Item(4) = 2 Then
                        docNulo = True
                    End If
                    dgvLista.Rows.Add(oTblNcg.Rows(i).Item(0), oTblNcg.Rows(i).Item(1), oTblNcg.Rows(i).Item(2), oTblNcg.Rows(i).Item(3), docNulo)
                Next

                dgvLista.Sort(dgvLista.Columns(0), System.ComponentModel.ListSortDirection.Ascending)

            ElseIf rbNDGeneral.Checked Then

                Dim oTblNdg As New DataTable

                Select Case cmbTipoConsulta.SelectedIndex
                    Case 0
                        oTblNdg = _oLogicaNotasDebito.consultarTodasGeneralesInfo()
                    Case 1
                        If txtIdPersona.Text <> "" Then
                            oTblNdg = _oLogicaNotasDebito.ConsultarPorIdPersonaGenerales(CInt(txtIdPersona.Text))
                        End If
                    Case 2
                        If txtDato2.Text <> "" Then
                            oTblNdg = _oLogicaNotasDebito.ConsultarPorNumNotaDebitoGenerales(CInt(txtDato2.Text))
                        End If
                End Select

                Dim docNulo As Boolean
                For i = 0 To oTblNdg.Rows.Count - 1
                    docNulo = False
                    If oTblNdg.Rows(i).Item(4) = 2 Then
                        docNulo = True
                    End If
                    dgvLista.Rows.Add(oTblNdg.Rows(i).Item(0), oTblNdg.Rows(i).Item(1), oTblNdg.Rows(i).Item(2), oTblNdg.Rows(i).Item(3), docNulo)
                Next

            ElseIf rbVale.Checked Then

                Dim oTblVales As New DataTable

                Select Case cmbTipoConsulta.SelectedIndex
                    Case 0
                        oTblVales = _oLogicaVales.consultarTodosInfo()
                    Case 1
                        If txtIdPersona.Text <> "" Then
                            oTblVales = _oLogicaVales.ConsultarPorIdPersona(CInt(txtIdPersona.Text))
                        End If
                    Case 2
                        If txtDato2.Text <> "" Then
                            oTblVales = _oLogicaVales.ConsultarPorNumVale(CInt(txtDato2.Text))
                        End If
                End Select

                For i = 0 To oTblVales.Rows.Count - 1
                    dgvLista.Rows.Add(oTblVales.Rows(i).Item(0), oTblVales.Rows(i).Item(1), oTblVales.Rows(i).Item(2), oTblVales.Rows(i).Item(3), False)
                Next
            End If
            If dgvLista.Rows.Count > 0 Then dgvLista.Rows(0).Selected = False

        End Sub

        Private Sub ImprimeNotaCredito(ByVal tipoVista As Integer, ByVal notaCredito As NotaCredito, ByVal copias As Integer)

            Dim oNotaCredito = _oLogicaNotasCredito.consultar(notaCredito.IdNC)

            Dim reporte As New RptNota_Credito

            reporte.SetDataSource(oNotaCredito.NCDetalles)

            Dim factura = _oLogicaFactura.consultarFacturaPorNumFacturaSinAplicar(notaCredito.NumFactura)
            Dim personaCredito = _oLogicaClienteCredito.ConsultarPorIdCredito(factura.IdCredito)
            reporte.SetParameterValue("cliente", personaCredito.Nombre + " " + personaCredito.PrimerApellido + " " + personaCredito.SegundoApellido)
            reporte.SetParameterValue("numNota", "#" & notaCredito.IdNC)
            reporte.SetParameterValue("fecha", notaCredito.Fecha)
            reporte.SetParameterValue("motivo", "Nota de crédito a factura #" & notaCredito.NumFactura)

            If tipoVista = 1 Then
                Dim nombreImpresora = _oLogicaVarios.ConsultarColumna("Imp_Tercio_Oficio")
                Dim nombrePc = _oLogicaVarios.ConsultarColumna("PC_Tercio_Oficio")
                reporte.PrintOptions.PrinterName = "\\" & nombrePc & "\" & nombreImpresora
                reporte.PrintToPrinter(copias, False, 1, 1)
            Else
                FrmReportesComprobantes.crvListado.ReportSource = reporte
                FrmReportesComprobantes.ShowDialog()
            End If


        End Sub

        Private Sub LlenarRecibo(ByVal tipoVista As Integer, ByVal recibo As Recibo, ByVal nombre As String, ByVal pagina As Integer, ByVal paginas As Integer)
            Dim rptRecibo As New RptReciboDinero

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

                If pagina = 1 Then
                    Dim indice As Integer = 20

                    If recibo.ReciboDetalle.Count < 21 Then
                        indice = recibo.ReciboDetalle.Count - 1
                    End If

                    For j = 0 To indice
                        Dim tipo = FormatoTipo(recibo.ReciboDetalle(j).Tipo)
                        If j < 7 Then
                            fila = table.NewRow
                            fila = AgregarAFilaLinea1(fila, tipo, recibo.ReciboDetalle(j).Doc, recibo.ReciboDetalle(j).Fecha, _oUtilidades.PasarMoneda(recibo.ReciboDetalle(j).Monto))
                            table.Rows.Add(fila)
                        ElseIf j < 14 Then
                            table = AgregarAFilaLinea2(table, j, tipo, recibo.ReciboDetalle(j).Doc, recibo.ReciboDetalle(j).Fecha, _oUtilidades.PasarMoneda(recibo.ReciboDetalle(j).Monto))
                        Else
                            table = AgregarAFilaLinea3(table, j, tipo, recibo.ReciboDetalle(j).Doc, recibo.ReciboDetalle(j).Fecha, _oUtilidades.PasarMoneda(recibo.ReciboDetalle(j).Monto))
                        End If
                    Next

                ElseIf pagina = 2 Then
                    For j = 21 To recibo.ReciboDetalle.Count - 1
                        Dim tipo = FormatoTipo(recibo.ReciboDetalle(j).Tipo)
                        If j < 28 Then
                            fila = table.NewRow
                            fila = AgregarAFilaLinea1(fila, tipo, recibo.ReciboDetalle(j).Doc, recibo.ReciboDetalle(j).Fecha, recibo.ReciboDetalle(j).Monto)
                            table.Rows.Add(fila)
                        ElseIf j < 35 Then
                            table = AgregarAFilaLinea2(table, j - 21, tipo, recibo.ReciboDetalle(j).Doc, recibo.ReciboDetalle(j).Fecha, recibo.ReciboDetalle(j).Monto)
                        Else
                            table = AgregarAFilaLinea3(table, j - 21, tipo, recibo.ReciboDetalle(j).Doc, recibo.ReciboDetalle(j).Fecha, recibo.ReciboDetalle(j).Monto)
                        End If
                    Next

                End If

                Dim faltan = 7 - table.Rows.Count

                For i = 1 To faltan
                    fila = table.NewRow
                    fila = AgregarAFilaLinea1(fila, "-", "-", "-", 0)
                    table.Rows.Add(fila)
                Next

                .SetDataSource(table)

                Dim montoTotal = Math.Abs(recibo.Monto)
                Dim decimales As String = _oUtilidades.PasarMoneda(montoTotal)
                Dim dec = decimales.Split(".")

                If CInt(montoTotal) = montoTotal Then
                    .SetParameterValue("monto_Letras", _oUtilidades.Num_A_Letras(dec(0)) & " COLONES NETOS.")
                Else
                    .SetParameterValue("monto_Letras", _oUtilidades.Num_A_Letras(dec(0)) & " COLONES CON " & dec(1) & "/100.")
                End If

                .SetParameterValue("cliente", nombre)
                .SetParameterValue("num_Recibo", "#" & recibo.NumRecibo)
                .SetParameterValue("monto", montoTotal)

                .SetParameterValue("totalCheques", recibo.TotalCheques)
                .SetParameterValue("totalTransferencia", recibo.TotalTransferencias)
                .SetParameterValue("totalEfectivo", recibo.TotalEfectivo)

                .SetParameterValue("observaciones", recibo.Observaciones)
                .SetParameterValue("numPagina", pagina)
                .SetParameterValue("Paginas", paginas)
                .SetParameterValue("fecha", recibo.Fecha)
                .SetParameterValue("saldo", recibo.SaldoActual)

                Select Case recibo.Concepto
                    Case recibo.ListaConcepto.Cancelacion
                        .SetParameterValue("concepto", "CANCELACION DE FACTURA(S)")
                    Case recibo.ListaConcepto.CancelacionAbono
                        .SetParameterValue("concepto", "CANCELACION Y ABONO A FACTURA(S)")
                    Case recibo.ListaConcepto.Abono
                        .SetParameterValue("concepto", "ABONO A FACTURA")
                End Select

                Dim copias = _oUtilidades.NumCopias(txtNum_Impresiones.Text, 1)

                If tipoVista = 1 Then
                    Dim nombreImpresora = _oLogicaVarios.ConsultarColumna("Imp_Tercio_Oficio")
                    Dim nombrePc = _oLogicaVarios.ConsultarColumna("PC_Tercio_Oficio")
                    .PrintOptions.PrinterName = "\\" & nombrePc & "\" & nombreImpresora
                    .PrintToPrinter(copias, False, 1, 1)
                Else
                    FrmReportesComprobantes.crvListado.ReportSource = rptRecibo
                    FrmReportesComprobantes.ShowDialog()
                End If

            End With
        End Sub

        Private Function FormatoTipo(ByVal tipo As ReciboDetalle.ListaTipo) As String
            Dim cadena As String = ""
            Select Case tipo
                Case ReciboDetalle.ListaTipo.Abono
                    cadena = "AB"
                Case ReciboDetalle.ListaTipo.Cancelacion
                    cadena = "CA"
                Case ReciboDetalle.ListaTipo.FactAbono
                    cadena = "Fact"
                Case ReciboDetalle.ListaTipo.NCGeneral
                    cadena = "NCG"
                Case ReciboDetalle.ListaTipo.NDGeneral
                    cadena = "NDG"
                Case ReciboDetalle.ListaTipo.NotaCredito
                    cadena = "NC"
                Case ReciboDetalle.ListaTipo.SaldoActual
                    cadena = "SA"
            End Select
            Return cadena
        End Function

        Private Function AgregarAFilaLinea1(ByVal fila As DataRow, ByVal tipo As String, ByVal numDoc As String, ByVal fechaDoc As String, ByVal montoDoc As Double) As DataRow
            fila.Item("Tipo") = tipo
            fila.Item("Doc") = numDoc
            fila.Item("Fecha") = fechaDoc
            fila.Item("Monto") = montoDoc

            Return fila
        End Function

        Private Function AgregarAFilaLinea2(ByVal table As DataTable, ByVal j As Integer, ByVal tipo As String, ByVal numDoc As String, ByVal fechaDoc As String, ByVal montoDoc As Double) As DataTable
            table.Rows(j - 7).Item("Tipo2") = tipo
            table.Rows(j - 7).Item("Doc2") = numDoc
            table.Rows(j - 7).Item("Fecha2") = fechaDoc
            table.Rows(j - 7).Item("Monto2") = montoDoc

            Return table
        End Function

        Private Function AgregarAFilaLinea3(ByVal table As DataTable, ByVal j As Integer, ByVal tipo As String, ByVal numDoc As String, ByVal fechaDoc As String, ByVal montoDoc As Double) As DataTable
            table.Rows(j - 14).Item("Tipo3") = tipo
            table.Rows(j - 14).Item("Doc3") = numDoc
            table.Rows(j - 14).Item("Fecha3") = fechaDoc
            table.Rows(j - 14).Item("Monto3") = montoDoc

            Return table
        End Function

        Private Sub chkImpresion_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkImpresion.CheckedChanged
            If chkImpresion.Checked Then
                txtNum_Impresiones.Enabled = False
                txtNum_Impresiones.ReadOnly = True
                txtNum_Impresiones.Text = 1
            Else
                txtNum_Impresiones.Enabled = True
                txtNum_Impresiones.ReadOnly = False
                txtNum_Impresiones.Focus()
            End If
        End Sub

        Private Sub FrmLista_Comprobantes_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            AddHandler txtNum_Impresiones.KeyPress, AddressOf ValidarSoloNumeros
            AddHandler dgvLista.MouseDown, AddressOf seleccionaClickDerecho
            AddHandler txtDato2.KeyPress, AddressOf ValidarSoloNumeros

            dgvLista.ContextMenuStrip = MnLista
            cmbTipoConsulta.SelectedIndex = 1
        End Sub

        Private Sub seleccionaClickDerecho(ByVal sender As System.Object, ByVal e As Windows.Forms.MouseEventArgs)
            If e.Button = Windows.Forms.MouseButtons.Right Then

                ' Si se ha pulsado el botón derecho del ratón,
                ' seleccionamos la fila completa del control
                ' DataGridView.
                '
                With sender

                    Dim hti As DataGridView.HitTestInfo = .HitTest(e.X, e.Y)

                    ' Obtenemos la parte del control a las que
                    ' pertenecen las coordenadas.
                    '
                    If hti.Type = DataGridViewHitTestType.Cell Then
                        .CurrentCell = _
                            .Rows(hti.RowIndex).Cells(hti.ColumnIndex)
                    End If

                End With
            End If
        End Sub

        Private Sub ImprimirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ImprimirToolStripMenuItem.Click
            If dgvLista.Rows.Count > 0 And dgvLista.CurrentRow.Index >= 0 Then
                If Not dgvLista.Item(4, dgvLista.CurrentRow.Index).Value Then
                    Dim respuesta As String

                    If rbRecibos.Checked Then
                        respuesta = MsgBox("Esta seguro que desea reimprimir este recibo?", vbCritical + vbYesNo, "Reimprimir recibo...")
                        If (respuesta = vbYes) Then
                            CargarRecibos(1)
                        End If

                    ElseIf rbVale.Checked Then
                        respuesta = MsgBox("Esta seguro que desea reimprimir este vale?", vbCritical + vbYesNo, "Reimprimir vale...")
                        If (respuesta = vbYes) Then
                            CargarVales(1)
                        End If

                    ElseIf rbNDGeneral.Checked Then
                        respuesta = MsgBox("Esta seguro que desea reimprimir esta nota de débito?", vbCritical + vbYesNo, "Reimprimir Nota Débito...")
                        If (respuesta = vbYes) Then
                            CargarNotasDebito(1)
                        End If

                    ElseIf rbNC.Checked Then
                        respuesta = MsgBox("Esta seguro que desea reimprimir esta nota de crédito?", vbCritical + vbYesNo, "Reimprimir Nota Crédito...")
                        If (respuesta = vbYes) Then
                            CargarNotasCredito(1)
                        End If
                    End If
                Else
                    MsgBox("Este recibo ha sido anulado por que no puede se puede reimprimir", MsgBoxStyle.Critical)
                End If
            End If
        End Sub

        Private Sub VerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles VerToolStripMenuItem.Click
            If dgvLista.Rows.Count > 0 And dgvLista.CurrentRow.Index >= 0 Then

                If rbRecibos.Checked Then
                    CargarRecibos(2)
                ElseIf rbVale.Checked Then
                    CargarVales(2)
                ElseIf rbNDGeneral.Checked Then
                    CargarNotasDebito(2)
                ElseIf rbNC.Checked Then
                    CargarNotasCredito(2)
                End If

            End If
        End Sub

        Private Sub CargarRecibos(ByVal tipo As Integer)
            Dim recibo = _oLogicaReciboDinero.consultarRecibo_NumRecibo(dgvLista.Item(0, dgvLista.CurrentRow.Index).Value)
            Dim clienteCredito = _oLogicaClienteCredito.ConsultarPorIdCredito(recibo.IdClienteCredito)
            Dim persona = _oLogicaPersona.Consultar(clienteCredito.IdPersona)

            Dim paginas = _oUtilidades.CalculaPaginas(recibo.ReciboDetalle.Count / 21)

            For i = 1 To paginas
                LlenarRecibo(tipo, recibo, persona.Nombre & " " & persona.PrimerApellido & " " & persona.SegundoApellido, i, paginas)
            Next
        End Sub

        'Tipo 1- Si desea imprimir 2-Si desea Visualizarlo
        Private Sub CargarVales(ByVal tipo As Integer)
            Dim copias = _oUtilidades.NumCopias(txtNum_Impresiones.Text, 1)
            Dim oVale = _oLogicaVale.ConsultarNumVale(dgvLista.Item(0, dgvLista.CurrentRow.Index).Value)
            Dim solicitante = _oLogicaEmpleado.ConsultarPorIdEmpleado(oVale.Solicitante)
            Dim autorizado = _oLogicaEmpleado.ConsultarPorIdEmpleado(oVale.Autorizado)
            Dim rptVale As New RptVale

            rptVale.SetParameterValue("hora", oVale.Hora)
            rptVale.SetParameterValue("fecha", oVale.Fecha)
            rptVale.SetParameterValue("monto", oVale.Monto)
            rptVale.SetParameterValue("solicitante", solicitante.Nombre + " " + solicitante.PrimerApellido + " " + solicitante.SegundoApellido)
            rptVale.SetParameterValue("monto_Letras", _oUtilidades.Num_A_Letras(oVale.Monto) + " COLONES NETOS.")
            rptVale.SetParameterValue("autoriza", autorizado.Nombre + " " + autorizado.PrimerApellido + " " + autorizado.SegundoApellido)
            rptVale.SetParameterValue("observaciones", oVale.Observaciones)

            If tipo = 1 Then
                Dim nombreImpresora = _oLogicaVarios.ConsultarColumna("Imp_Tercio_Oficio")
                Dim nombrePc = _oLogicaVarios.ConsultarColumna("PC_Tercio_Oficio")
                rptVale.PrintOptions.PrinterName = "\\" & nombrePc & "\" & nombreImpresora
                rptVale.PrintToPrinter(copias, False, 1, 1)
            Else
                FrmReportesComprobantes.crvListado.ReportSource = rptVale
                FrmReportesComprobantes.ShowDialog()
            End If

        End Sub

        'Tipo 1- Si desea imprimir 2-Si desea Visualizarlo
        Private Sub CargarNotasDebito(ByVal tipo As Integer)
            Dim copias = _oUtilidades.NumCopias(txtNum_Impresiones.Text, 1)
            Dim oNdGeneral = _oLogicaNotasDebito.consultarNota_DebitoGeneral(dgvLista.Item(0, dgvLista.CurrentRow.Index).Value)
            Dim personaCredito = _oLogicaClienteCredito.ConsultarPorIdCredito(oNdGeneral.IdClienteCredito)
            Dim reporte As New RptND_General

            reporte.SetParameterValue("cliente", personaCredito.Nombre + " " + personaCredito.PrimerApellido + " " + personaCredito.SegundoApellido)
            reporte.SetParameterValue("numNota", "#" & oNdGeneral.IdND)
            reporte.SetParameterValue("motivo", oNdGeneral.Motivo)
            reporte.SetParameterValue("fecha", oNdGeneral.Fecha)
            reporte.SetParameterValue("total", CDbl(oNdGeneral.Monto))

            If tipo = 1 Then
                Dim nombreImpresora = _oLogicaVarios.ConsultarColumna("Imp_Tercio_Oficio")
                Dim nombrePc = _oLogicaVarios.ConsultarColumna("PC_Tercio_Oficio")
                reporte.PrintOptions.PrinterName = "\\" & nombrePc & "\" & nombreImpresora
                reporte.PrintToPrinter(copias, False, 1, 1)
            Else
                FrmReportesComprobantes.crvListado.ReportSource = reporte
                FrmReportesComprobantes.ShowDialog()
            End If

        End Sub

        'Tipo 1- Si desea imprimir 2-Si desea Visualizarlo
        Private Sub CargarNotasCredito(ByVal tipo As Integer)
            Dim copias = _oUtilidades.NumCopias(txtNum_Impresiones.Text, 1)
            Dim oNotaCredito = _oLogicaNotasCredito.Consultar(dgvLista.Item(0, dgvLista.CurrentRow.Index).Value)

            If oNotaCredito.IdNC <> 0 Then
                ImprimeNotaCredito(tipo, oNotaCredito, copias)
            Else
                Dim oNcGEneral = _oLogicaNotasCredito.consultarNota_CreditoGeneral(dgvLista.Item(0, dgvLista.CurrentRow.Index).Value)
                Dim personaCredito = _oLogicaClienteCredito.ConsultarPorIdCredito(oNcGEneral.IdClienteCredito)
                Dim reporte As New RptNC_General

                reporte.SetParameterValue("cliente", personaCredito.Nombre + " " + personaCredito.PrimerApellido + " " + personaCredito.SegundoApellido)
                reporte.SetParameterValue("numNota", "#" & oNcGEneral.IdNC)
                reporte.SetParameterValue("motivo", oNcGEneral.Motivo)
                reporte.SetParameterValue("fecha", oNcGEneral.Fecha)
                reporte.SetParameterValue("total", CDbl(oNcGEneral.Monto))

                If tipo = 1 Then
                    Dim nombreImpresora = _oLogicaVarios.ConsultarColumna("Imp_Tercio_Oficio")
                    Dim nombrePc = _oLogicaVarios.ConsultarColumna("PC_Tercio_Oficio")
                    reporte.PrintOptions.PrinterName = "\\" & nombrePc & "\" & nombreImpresora
                    reporte.PrintToPrinter(copias, False, 1, 1)
                Else
                    FrmReportesComprobantes.crvListado.ReportSource = reporte
                    FrmReportesComprobantes.ShowDialog()
                End If
            End If

        End Sub

        Private Sub rbVale_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbVale.CheckedChanged
            cmbTipoConsulta.Items.Clear()
            If rbVale.Checked Then
                cmbTipoConsulta.Items.AddRange(New Object() {"Todos", "Nombre Cliente", "# Doc"})
            Else
                cmbTipoConsulta.Items.AddRange(New Object() {"Todos", "Nombre Cliente", "# Doc", "# Factura"})
            End If
            cmbTipoConsulta.SelectedIndex = 1
        End Sub

        Private Sub cmbTipoConsulta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbTipoConsulta.SelectedIndexChanged
            With cmbTipoConsulta
                Select Case .SelectedIndex
                    Case 0
                        txtDato.Enabled = False
                        txtDato.Visible = True
                        txtDato2.Visible = False
                    Case 1
                        txtDato.Enabled = True
                        txtDato.Visible = True
                        txtDato2.Visible = False
                        txtDato.Focus()
                    Case 2
                        txtDato.Visible = False
                        txtDato2.Visible = True
                        txtDato2.Focus()
                    Case 3
                        txtDato.Visible = False
                        txtDato2.Visible = True
                        txtDato2.Focus()
                End Select
            End With
        End Sub

        Private Sub txtDato_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtDato.KeyPress
            If cmbTipoConsulta.SelectedIndex = 1 Then
                BuscarPersonaPorNombre(dgvCliente, e, txtDato, txtDato, txtIdPersona, txtDato)
            End If
        End Sub

        Private Sub dgvCliente_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles dgvCliente.KeyDown
            If e.KeyValue = 13 Then
                Dim oPersona = _oLogicaPersona.Consultar(dgvCliente.Item(0, dgvCliente.CurrentRow.Index).Value)
                txtIdPersona.Text = oPersona.IdPersona
                txtDato.Text = oPersona.Nombre + " " + oPersona.PrimerApellido + " " + oPersona.SegundoApellido
                dgvCliente.Visible = False
                btnBuscar.Focus()
            End If
        End Sub

        Private Sub dgvCliente_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvCliente.Click
            Dim oPersona = _oLogicaPersona.Consultar(dgvCliente.Item(0, dgvCliente.CurrentRow.Index).Value)
            txtIdPersona.Text = oPersona.IdPersona
            txtDato.Text = oPersona.Nombre + " " + oPersona.PrimerApellido + " " + oPersona.SegundoApellido
            dgvCliente.Visible = False
            btnBuscar.Focus()
        End Sub

        Private Sub rbNDGeneral_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbNDGeneral.CheckedChanged
            cmbTipoConsulta.Items.Clear()
            If rbNDGeneral.Checked Then
                cmbTipoConsulta.Items.AddRange(New Object() {"Todos", "Nombre Cliente", "# Doc"})
            Else
                cmbTipoConsulta.Items.AddRange(New Object() {"Todos", "Nombre Cliente", "# Doc", "# Factura"})
            End If
            limpiarDatos()
            cmbTipoConsulta.SelectedIndex = 1
            btnBuscar.Focus()
        End Sub

        Private Sub txtDato_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtDato.Click
            limpiarDatos()
            txtDato.Text = String.Empty
        End Sub

        Public Sub limpiarDatos()
            dgvCliente.Visible = False
            dgvLista.Rows.Clear()
            dgvLista.DataSource = Nothing
        End Sub

        Private Sub FrmLista_Comprobantes_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub

        Private Sub txtDato_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtDato.KeyDown
            CambiarControlADataGrid(dgvCliente, e, txtDato, txtDato, txtDato)
        End Sub

        Private Sub rbRecibos_CheckedChanged(sender As Object, e As EventArgs) Handles rbRecibos.CheckedChanged
            limpiarDatos()
            btnBuscar.Focus()
        End Sub

        Private Sub rbNC_CheckedChanged(sender As Object, e As EventArgs) Handles rbNC.CheckedChanged
            limpiarDatos()
            btnBuscar.Focus()
        End Sub

        Private Sub txtDato_MouseCaptureChanged(sender As Object, e As EventArgs) Handles txtDato.MouseCaptureChanged
            limpiarDatos()
            txtDato.Text = String.Empty
        End Sub

        Private Sub gbTipo_Enter(sender As Object, e As EventArgs) Handles gbTipo.Enter

        End Sub
    End Class
End Namespace