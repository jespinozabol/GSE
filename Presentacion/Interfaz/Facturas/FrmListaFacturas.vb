Imports Entidades
Imports Logica_Negocios

Namespace Interfaz.Facturas
    Public Class FrmListaFacturas

        Private ReadOnly _oUtilidades As New Utilidades
        Private ReadOnly _oLogicaPersona As New LogicaPersona
        Private ReadOnly _oLogicaFactura As New LogicaFacturar
        Private ReadOnly _oLogicaFacturaCredito As New LogicaFacturaCredito
        Private ReadOnly _oLogicaRecibo As New LogicaReciboDinero
        Private ReadOnly _oLogicaVarios As New LogicaVarios


        Private Sub RecuperarFactura(ByVal numFactura As Integer, ByVal anulada As String)

            If anulada <> "Nula" Then
                Dim respuesta As String
                respuesta = MsgBox("Ésta factura debe ser anula antes de ser recuperada, desea anularla?", vbCritical + vbYesNo, "Anular Factura...")

                If respuesta = vbYes Then
                    _oLogicaFactura.Anular(numFactura)
                    _oLogicaFacturaCredito.cambiarNulo_NumFactura(numFactura)
                    anulada = True
                End If
            End If

            If anulada = "True" Or anulada = "Nula" Then
                FrmFacturar.Tipo = 3
                FrmFacturar.IdTipo = numFactura
                Dispose()
                FrmFacturar.ShowDialog()
            End If
        End Sub

        Private Sub LimpiarTodo()
            txtDato.Text = String.Empty
            dgvLista.Rows.Clear()
            dgvDetalle.Rows.Clear()
            lblTotalAbonos.Text = String.Empty
            lblTotalNC.Text = String.Empty
            lblFactura.Text = String.Empty
            txtDato2.Text = String.Empty
            dgvCliente.Visible = False
        End Sub

        Private Sub CargarFactura(ByVal tipo As Integer)
            Dim copias = _oUtilidades.NumCopias(txtNum_Impresiones.Text, 1)

            Cursor.Current = Cursors.WaitCursor

            Dim oFactura = _oLogicaFactura.ConsultarFactura(dgvLista.Item(0, dgvLista.CurrentRow.Index).Value)
            Dim cliente = _oLogicaPersona.Consultar(oFactura.IdPersona)

            For i = oFactura.FacturaDetalles.Count To 15
                Dim detalle As New FacturaDetalle
                detalle.Cantidad = 0
                detalle.Descripcion = ""
                detalle.Descuento = 0
                detalle.IdFacturaDet = 1
                detalle.Id_Producto = 0
                detalle.Impuesto = 0.000000001
                detalle.NumFactura = oFactura.NumFactura
                detalle.PrecioUnitario = 0
                detalle.TDescuento = 0
                detalle.TImpuesto = 0
                oFactura.FacturaDetalles.Add(detalle)
            Next

            Dim reporte As New RptFactura
            reporte.SetDataSource(oFactura.FacturaDetalles)
            If oFactura.Contado Then
                reporte.SetParameterValue("contado", "XX")
                reporte.SetParameterValue("credito", " ")
            Else
                reporte.SetParameterValue("contado", " ")
                reporte.SetParameterValue("credito", "XX")
            End If
            reporte.SetParameterValue("numFactura", oFactura.NumFactura)
            reporte.SetParameterValue("cliente", cliente.Nombre + " " + cliente.PrimerApellido + " " + cliente.SegundoApellido)
            reporte.SetParameterValue("fecha", oFactura.Fecha)
            reporte.SetParameterValue("codCliente", oFactura.IdPersona)
            reporte.SetParameterValue("codReferencia", oFactura.IdReferencia)
            reporte.SetParameterValue("codFactura", oFactura.NumFactura)

            If tipo = 1 Then
                Dim nombreImpresora = _oLogicaVarios.ConsultarColumna("Imp_Medio_Oficio")
                Dim nombrePc = _oLogicaVarios.ConsultarColumna("PC_Medio_Oficio")
                reporte.PrintOptions.PrinterName = "\\" & nombrePc & "\" & nombreImpresora
                reporte.PrintToPrinter(copias, False, 1, 1)
            Else
                FrmReportesComprobantes.crvListado.ReportSource = reporte
                FrmReportesComprobantes.ShowDialog()
            End If

            Cursor.Current = Cursors.Default
        End Sub

        Private Sub FrmLista_Facturas_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            AddHandler txtNum_Impresiones.KeyPress, AddressOf ValidarSoloNumeros
            AddHandler dgvLista.MouseDown, AddressOf SeleccionaClickDerecho
            AddHandler txtDato2.KeyPress, AddressOf ValidarSoloNumeros

            dgvLista.ContextMenuStrip = MnLista
            cmbTipoConsulta.SelectedIndex = 2
        End Sub

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

        Private Sub txtDato_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtDato.KeyPress
            If cmbTipoConsulta.SelectedIndex = 0 Then
                BuscarPersonaPorNombre(dgvCliente, e, txtDato, txtDato, txtIdPersona, txtDato)
            End If
        End Sub

        Private Sub txtDato_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtDato.KeyDown
            CambiarControlADataGrid(dgvCliente, e, txtDato, txtDato, btnBuscar)
        End Sub

        Private Sub txtDato_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtDato.Click
            LimpiarTodo()
        End Sub

        Private Sub txtDato2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtDato2.Click
            LimpiarTodo()
        End Sub

        Private Sub txtDato2_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtDato2.KeyDown
            If e.KeyValue = Keys.Enter And txtDato2.Text <> "" Then btnBuscar.Focus()
        End Sub

        Private Sub dgvCliente_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles dgvCliente.KeyDown
            If e.KeyValue = Keys.Enter Then EscojerPersona()
        End Sub

        Private Sub dgvCliente_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvCliente.Click
            EscojerPersona()
        End Sub

        Private Sub EscojerPersona()
            Dim oPersona = _oLogicaPersona.Consultar(dgvCliente.Item(0, dgvCliente.CurrentRow.Index).Value)
            txtIdPersona.Text = oPersona.IdPersona
            txtDato.Text = oPersona.Nombre + " " + oPersona.PrimerApellido + " " + oPersona.SegundoApellido
            dgvCliente.Visible = False
            btnBuscar.Focus()
        End Sub

        Private Sub dgvLista_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvLista.Click
            If dgvLista.Rows.Count > 0 And dgvLista.CurrentRow.Index >= 0 Then
                dgvDetalle.Rows.Clear()
                Dim factura = _oLogicaFacturaCredito.consultarPorNumFactura(dgvLista.Item(0, dgvLista.CurrentRow.Index).Value)

                lblFactura.Text = dgvLista.Item(0, dgvLista.CurrentRow.Index).Value
                lblTotalAbonos.Text = factura.Abonos.Count
                lblTotalNC.Text = factura.NotasCredito.Count

                For i = 0 To factura.NotasCredito.Count - 1
                    Dim anulada As Boolean = False
                    If factura.NotasCredito(i).Estado = NotaCredito.ListaEstado.Anulada Then anulada = True
                    Dim numeroRecibo = _oLogicaRecibo.buscarReciboId_NC(factura.NotasCredito(i).IdNC)
                    dgvDetalle.Rows.Add(numeroRecibo, factura.NotasCredito(i).IdNC, "Nota Crédito", factura.NotasCredito(i).Fecha, factura.NotasCredito(i).Monto, anulada)
                Next

                For i = 0 To factura.Abonos.Count - 1
                    Dim anulada As Boolean = False
                    If factura.Abonos(i).Estado = Abono.ListaEstado.Anulado Then anulada = True
                    Dim abon = _oLogicaRecibo.buscarReciboId_Abono(factura.Abonos(i).IdAbono, factura.NumFactura)
                    dgvDetalle.Rows.Add(abon, factura.Abonos(i).IdAbono, "Abono", factura.Abonos(i).Fecha, factura.Abonos(i).Monto, anulada)
                Next
            End If
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
                        txtDato2.Visible = True
                        txtDato.Visible = False
                        txtDato2.Focus()
                End Select
                LimpiarTodo()
            End With
        End Sub

        Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscar.Click
            dgvLista.Rows.Clear()

            Dim oTblFacturas As New DataTable

            Select Case cmbTipoConsulta.SelectedIndex
                Case 0
                    If txtIdPersona.Text <> "" Then
                        oTblFacturas = _oLogicaFactura.consultarPorIdPersona_ConNombre(CLng(txtIdPersona.Text))
                    End If
                Case 1
                    If txtDato2.Text <> "" Then
                        oTblFacturas = _oLogicaFactura.consultarPorIdPersona_ConNombre(CLng(txtDato2.Text))
                    End If
                Case 2
                    If txtDato2.Text <> "" Then
                        oTblFacturas = _oLogicaFactura.consultarFacturaEncabezado_ConNombre(CLng(txtDato2.Text))
                    End If
            End Select

            For i = 0 To oTblFacturas.Rows.Count - 1
                Dim detalle As List(Of FacturaDetalle)
                detalle = _oLogicaFactura.consultarFacturaDetalle(oTblFacturas.Rows(i).Item(0))

                Dim total As Double = 0

                For j As Integer = 0 To detalle.Count - 1
                    Dim subTotal As Double = _oUtilidades.PasarMoneda(detalle(j).PrecioUnitario * detalle(j).Cantidad)
                    Dim descuento As Double = subTotal * ((detalle(j).Descuento / 100))
                    Dim subTotalConDescuento As Double = subTotal - descuento
                    Dim impuesto As Double = subTotalConDescuento * ((detalle(j).Impuesto / 100))
                    total += subTotalConDescuento + impuesto
                Next

                Dim tipo As String
                Dim estado As String = String.Empty
                Dim plazo As String

                If oTblFacturas.Rows(i).Item(3) Then
                    tipo = "Cont"
                    estado = "Canc"
                    plazo = "-"
                Else
                    Dim facturaCredito = _oLogicaFacturaCredito.ConsultarPorNumFactura(oTblFacturas.Rows(i).Item(0))
                    tipo = "Cred"
                    Select Case (facturaCredito.Estado)
                        Case Entidades.FacturaCredito.ListaEstado.Pendiente
                            estado = "Pend"
                        Case Entidades.FacturaCredito.ListaEstado.Anulada
                            estado = "Nula"
                        Case Entidades.FacturaCredito.ListaEstado.Aplicada
                            estado = "Canc"
                    End Select
                    plazo = facturaCredito.NumDias
                End If
                If oTblFacturas.Rows(i).Item(5) Then
                    estado = "Nula"
                End If
                dgvLista.Rows.Add(oTblFacturas.Rows(i).Item(0), oTblFacturas.Rows(i).Item(7) & " " & oTblFacturas.Rows(i).Item(8) & " " & oTblFacturas.Rows(i).Item(9),
                                  oTblFacturas.Rows(i).Item(4), "¢" & _oUtilidades.PasarMoneda(total),
                                  tipo, estado, plazo, oTblFacturas.Rows(i).Item(2))
            Next

            If dgvLista.RowCount > 0 Then dgvLista.Rows(0).Selected = False
        End Sub

        Private Sub VerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles VerToolStripMenuItem.Click
            If dgvLista.Rows.Count > 0 And dgvLista.CurrentRow.Index >= 0 Then
                CargarFactura(2)
            End If
        End Sub

        Private Sub ImprimirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ImprimirToolStripMenuItem.Click
            Dim imprime As Integer
            imprime = MessageBox.Show("Esta seguro que desea reimprimir esta factura?", "Reimprimir Factura", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If dgvLista.Rows.Count > 0 And dgvLista.CurrentRow.Index >= 0 And imprime = vbYes Then
                CargarFactura(1)
            End If
        End Sub

        Private Sub RecuperarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles RecuperarToolStripMenuItem.Click
            If dgvLista.Rows.Count > 0 And dgvLista.CurrentRow.Index >= 0 Then
                RecuperarFactura(dgvLista.Item(0, dgvLista.CurrentRow.Index).Value, dgvLista.Item(5, dgvLista.CurrentRow.Index).Value)
            End If
        End Sub

        Private Sub AgregarReferenciaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles AgregarReferenciaToolStripMenuItem.Click
            If dgvLista.Rows.Count > 0 And dgvLista.CurrentRow.Index >= 0 Then
                'Cuando la referencia es = 1 entonces no pertenece a ningúna persona.
                Dim referencia As Integer = dgvLista.Item(7, dgvLista.CurrentRow.Index).Value
                If referencia = 1 Then
                    FrmReferenciaAFactura.LlenarCampos(dgvLista.Item(0, dgvLista.CurrentRow.Index).Value, dgvLista.Item(1, dgvLista.CurrentRow.Index).Value)
                    FrmReferenciaAFactura.ShowDialog()
                Else
                    MsgBox("Esta factura ya tiene una referencia asignada", MsgBoxStyle.Exclamation)
                End If
            End If
        End Sub

        Private Sub FrmLista_Facturas_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub
    End Class
End Namespace