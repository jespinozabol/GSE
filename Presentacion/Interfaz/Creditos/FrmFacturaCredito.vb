Imports Entidades
Imports Logica_Negocios
Imports Presentacion.Interfaz.Facturas
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Management

Namespace Interfaz.Creditos
    Public Class FrmFacturaCredito

        Private ReadOnly _oUtilidades As New Utilidades
        Private ReadOnly _oLogicaCliente As New LogicaClienteCredito
        Private ReadOnly _oLogicaConsecutivo As New LogicaConsecutivo
        Private ReadOnly _oLogicaFactCredito As New LogicaFacturaCredito
        Private _oListaFacturas As New List(Of Long)
        Private _oListaNcg As New List(Of Integer)
        Private _oListaNdg As New List(Of Integer)
        Private ReadOnly _oLogicaAbonos As New LogicaAbono
        Public OAbono As New Abono
        Private _lineas As Integer = 0
        Public Tipo As Integer = 1 '1 Escoje, 2 Automatico,3 Abono
        Public OFlujoCaja As New FlujoCaja
        Private ReadOnly _oLogicaFlujo As New LogicaFlujoCaja
        Private ReadOnly _oLogicaMoneda As New LogicaMoneda
        Private ReadOnly _oLogicaNotasCredito As New LogicaNotaCredito
        Private ReadOnly _oLogicaReciboDinero As New LogicaReciboDinero
        Private ReadOnly _oLogicaVarios As New LogicaVarios
        Private ReadOnly _oLogicaNotasDebito As New LogicaNotaDebito
        Private _oListaLineasRecibo As New List(Of LineaRecibo)
        Private _totalTransferencias As Double
        Private _totalEfectivo As Double
        Private _totalCheque As Double
        Public Observaciones As String

        'True = acepto, False = Cancelo
        Private _varEstadoFlujoCaja As Boolean
        Public Property EstadoFlujoCaja() As Boolean
            Get
                Return _varEstadoFlujoCaja
            End Get
            Set(ByVal value As Boolean)
                _varEstadoFlujoCaja = value
            End Set
        End Property

        Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnLimpiar.Click
            LimpiarTodo()
            txtId_Credito.Text = String.Empty
        End Sub

        Private Sub LimpiarTodo()
            txtNombre.Text = String.Empty
            txtCedula.Text = String.Empty
            txtMontoAbonos.Text = String.Empty
            txtLimite.Text = String.Empty
            txtNumAbonos.Text = String.Empty
            txtTotalAtrasado.Text = String.Empty
            txtTotalCreditos.Text = String.Empty
            dgvFacturas.Rows.Clear()
            txtVuelto.Text = String.Empty
            dgvTrans1.Rows.Clear()
            dgvTrans2.Rows.Clear()
            dgvTrans3.Rows.Clear()
            lblMostrarObservaciones.Text = String.Empty
            Observaciones = String.Empty
            _lineas = 0
            txtMontoAbono.Text = String.Empty
            lblMostrarAbono.Text = 0.0
            lblMostrarAnterior.Text = 0.0
            lblActual.Text = 0.0
            _oListaFacturas = New List(Of Long)
            _oListaNcg = New List(Of Integer)
            _oListaNdg = New List(Of Integer)
            _oListaLineasRecibo = New List(Of LineaRecibo)
            Tipo = 1
            EstadoFlujoCaja = False
            btnCargarRecibo.Enabled = False
            btnAbonar.Enabled = False
            If Trim(txtId_Credito.Text) <> "" Then
                _oLogicaCliente.ModificarBloqueo(CInt(txtId_Credito.Text), 0)
            End If
            txtId_Credito.Focus()
        End Sub

        Private Sub txtId_Credito_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtId_Credito.KeyPress
            Dim keyAscii As Short = CShort(Asc(e.KeyChar))
            If Not keyAscii = 13 Then
                Dim oCredito = BuscarClienteCreditoPorId(e, txtId_Credito)
                If oCredito.IdCredito <> 0 Then
                    If oCredito.Bloqueo Then
                        MsgBox("El cliente credito ha sido abierto en otra ventana por lo que no puede ser abierto", MsgBoxStyle.Information)
                        txtNombre.Text = String.Empty
                        dgvClientes.Visible = False
                        txtId_Credito.Text = String.Empty
                    Else
                        LimpiarTodo()
                        txtNombre.Text = oCredito.Nombre + " " + oCredito.PrimerApellido + " " + oCredito.SegundoApellido
                        txtCedula.Text = oCredito.Cedula
                        txtLimite.Text = _oUtilidades.PasarMoneda(oCredito.Limite)
                        CargarDatos(oCredito.IdCredito)
                        _oLogicaCliente.ModificarBloqueo(oCredito.IdCredito, 1)
                    End If
                Else
                    LimpiarTodo()
                End If
            End If
        End Sub

        Private Sub txtId_Credito_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtId_Credito.KeyDown
            If e.KeyData = Keys.Enter And txtNombre.Text = "" Then
                txtNombre.Focus()
            ElseIf e.KeyData = Keys.Enter Then
                'falta definir el focus del clic en esta opción
            End If
        End Sub

        Private Sub timerRecibo_Tick(ByVal sender As System.Object, ByVal e As EventArgs) Handles timerRecibo.Tick
            lblMostrarReciboAbonos.Text = _oLogicaConsecutivo.ConsultarMaxConsecutivo("CONSECUTIVO_ABONO") + 1
            lblReciboFacturas.Text = _oLogicaConsecutivo.ConsultarMaxConsecutivo("CONSECUTIVO_RECIBO_FACT") + 1
        End Sub

        Public Sub CargarDatos(ByVal idCredito As Integer)
            Dim oListFacturas As List(Of FacturaCredito)
            Dim totalAtrasados As Double
            Dim totalCreditos As Double
            Dim numAbonos As Integer
            Dim numNotasCredito As Integer
            Dim montoTotalAbonos As Double
            Dim abonos As Double
            Dim notasCredito As Double
            Dim montoNotas As Double
            dgvTrans1.Rows.Clear()
            dgvTrans2.Rows.Clear()
            dgvTrans3.Rows.Clear()
            oListFacturas = _oLogicaFactCredito.consultarFacturasPorId_Credito(idCredito)

            With oListFacturas

                For i As Integer = 0 To oListFacturas.Count - 1
                    Dim dias = DateDiff("d", oListFacturas(i).Fecha, Now)
                    Dim diasAtraso As Integer
                    Dim montoConAbonos As Double

                    Dim fechaFactura As Date = oListFacturas(i).Fecha
                    totalCreditos = totalCreditos + oListFacturas(i).Monto
                    numAbonos = numAbonos + oListFacturas(i).Abonos.Count
                    numNotasCredito = numNotasCredito + oListFacturas(i).NotasCredito.Count

                    abonos = 0
                    For j = 0 To oListFacturas(i).Abonos.Count - 1
                        abonos = abonos + oListFacturas(i).Abonos(j).Monto
                    Next

                    notasCredito = 0
                    For j = 0 To oListFacturas(i).NotasCredito.Count - 1
                        notasCredito = notasCredito + oListFacturas(i).NotasCredito(j).Monto
                    Next

                    montoConAbonos = oListFacturas(i).Monto - abonos - notasCredito

                    diasAtraso = dias - oListFacturas(i).NumDias
                    If diasAtraso > 0 Then
                        totalAtrasados = totalAtrasados + montoConAbonos
                    End If

                    montoTotalAbonos = montoTotalAbonos + abonos
                    montoNotas = montoNotas + notasCredito
                    dgvFacturas.Rows.Add("FACT", oListFacturas(i).NumFactura, fechaFactura.ToString("dd/MM/yyyy"), _oUtilidades.PasarMoneda(oListFacturas(i).Monto), _oUtilidades.PasarMoneda(montoConAbonos), oListFacturas(i).NumDias, diasAtraso, oListFacturas(i).Abonos.Count & "- Ver", oListFacturas(i).NotasCredito.Count & "- Ver", "Ver")
                Next

                Dim oNcGenerales = _oLogicaNotasCredito.ConsultarGeneral(idCredito)
                Dim totalNcGEnerales As Double = 0
                For i = 0 To oNcGenerales.Count - 1
                    Dim dias = DateDiff("d", oNcGenerales(i).Fecha, Now)
                    Dim diasAtraso = dias - 30
                    totalNcGEnerales = totalNcGEnerales + oNcGenerales(i).Monto
                    dgvFacturas.Rows.Add("NCG", oNcGenerales(i).IdNC, oNcGenerales(i).Fecha.ToString("dd/MM/yyyy"), _oUtilidades.PasarMoneda(oNcGenerales(i).Monto), _oUtilidades.PasarMoneda(oNcGenerales(i).Monto), 30, diasAtraso, "Ver")
                Next

                Dim oNdGenerales = _oLogicaNotasDebito.ConsultarGeneral(idCredito)
                Dim totalNdGenerales As Double = 0
                For i = 0 To oNdGenerales.Count - 1
                    Dim dias = DateDiff("d", oNdGenerales(i).Fecha, Now)
                    Dim montoConAbonos As Double
                    numAbonos = numAbonos + oNdGenerales(i).Abonos.Count

                    abonos = 0
                    For j = 0 To oNdGenerales(i).Abonos.Count - 1
                        abonos = abonos + oNdGenerales(i).Abonos(j).Monto
                    Next
                    montoConAbonos = oNdGenerales(i).Monto - abonos
                    Dim diasAtraso = dias - 30
                    If diasAtraso > 0 Then
                        totalAtrasados = totalAtrasados + montoConAbonos
                    End If
                    totalNdGenerales = totalNdGenerales + oNdGenerales(i).Monto
                    montoTotalAbonos = montoTotalAbonos + abonos
                    dgvFacturas.Rows.Add("NDG", oNdGenerales(i).IdND, oNdGenerales(i).Fecha.ToString("dd/MM/yyyy"), _oUtilidades.PasarMoneda(oNdGenerales(i).Monto), _oUtilidades.PasarMoneda(montoConAbonos), 30, diasAtraso, oNdGenerales(i).Abonos.Count & "- Ver", "", "Ver")
                Next

                If dgvFacturas.Rows.Count > 0 Then dgvFacturas.Rows(0).Selected = False
                txtTotalAtrasado.Text = _oUtilidades.PasarMoneda(totalAtrasados - totalNcGEnerales)
                txtTotalCreditos.Text = _oUtilidades.PasarMoneda(totalCreditos - montoTotalAbonos - montoNotas - totalNcGEnerales + totalNdGenerales)
                txtNumAbonos.Text = numAbonos
                txtNumNC.Text = numNotasCredito + oNcGenerales.Count
                lblMostrarAnterior.Text = _oUtilidades.PasarMoneda(txtTotalCreditos.Text)
                lblActual.Text = _oUtilidades.PasarMoneda(txtTotalCreditos.Text)
                txtMontoNC.Text = _oUtilidades.PasarMoneda(montoNotas + totalNcGEnerales)
                txtMontoAbonos.Text = _oUtilidades.PasarMoneda(montoTotalAbonos)
            End With

            dgvFacturas.Sort(dgvFacturas.Columns(1), System.ComponentModel.ListSortDirection.Ascending)

        End Sub

        Private Sub dgvFacturas_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvFacturas.Click
            With dgvFacturas
                If .Rows.Count > 0 And Tipo = 1 Then
                    If .CurrentCell.RowIndex >= 0 Then
                        If .CurrentCell.ColumnIndex = 7 Then
                            If .Item(0, .CurrentRow.Index).Value = "FACT" Then
                                Dim oListAbonos = _oLogicaAbonos.consultarPendientesPorNumDocYTipo(.Item(1, .CurrentRow.Index).Value, Abono.ListaTipoDoc.FACT)
                                If oListAbonos.Count > 0 Then
                                    With FrmHistorialAbonos
                                        .dgvAbonos.DataSource = oListAbonos
                                        .lblMostrarFactura.Text = oListAbonos(0).NumDoc
                                        .ShowDialog()
                                    End With
                                Else
                                    MsgBox("No existen abonos a mostrar")
                                End If
                            ElseIf .Item(0, .CurrentRow.Index).Value = "NCG" Then
                                MsgBox(_oLogicaNotasCredito.ConsultarMotivo(.Item(1, .CurrentRow.Index).Value))
                            ElseIf .Item(0, .CurrentRow.Index).Value = "NDG" Then
                                Dim oListAbonos = _oLogicaAbonos.consultarPendientesPorNumDocYTipo(.Item(1, .CurrentRow.Index).Value, Abono.ListaTipoDoc.NDG)
                                If oListAbonos.Count > 0 Then
                                    With FrmHistorialAbonos
                                        .dgvAbonos.DataSource = oListAbonos
                                        .lblMostrarFactura.Text = oListAbonos(0).NumDoc
                                        .ShowDialog()
                                    End With
                                Else
                                    MsgBox("No existen abonos a mostrar")
                                End If
                            End If
                        ElseIf .CurrentCell.ColumnIndex = 8 Then
                            If .Item(0, .CurrentRow.Index).Value = "FACT" Then
                                Dim oListaNc = _oLogicaNotasCredito.consultarPorNum_FacturaSinAplicar(.Item(1, .CurrentRow.Index).Value)

                                If oListaNc.Count > 0 Then
                                    With FrmHistorialNc
                                        .dgvNotas_Credito.DataSource = oListaNc
                                        .lblMostrarFactura.Text = oListaNc(0).NumFactura
                                        .ShowDialog()
                                    End With
                                Else
                                    MsgBox("No existen notas de crédito a mostrar")
                                End If
                            End If
                        ElseIf .CurrentCell.ColumnIndex = 9 Then
                            MsgBox(_oLogicaNotasDebito.ConsultarMotivo(.Item(1, .CurrentRow.Index).Value))
                        Else
                            If _lineas < 42 Then
                                Dim lineaRecibo As LineaRecibo
                                If .Item(0, .CurrentRow.Index).Value = "FACT" Then
                                    Dim oListAbonos = _oLogicaAbonos.consultarPendientesPorNumDocYTipo(.Item(1, .CurrentRow.Index).Value, Abono.ListaTipoDoc.FACT)
                                    Dim oListaNotasCredito = _oLogicaNotasCredito.consultarPorNum_FacturaSinAplicar(.Item(1, .CurrentRow.Index).Value)
                                    Dim cantLineas = oListAbonos.Count + oListaNotasCredito.Count

                                    If cantLineas + _lineas + 1 < 42 Then
                                        lineaRecibo = CrearLineaRecibo("CA", .CurrentRow.Cells(1).Value, .CurrentRow.Cells(2).Value, .CurrentRow.Cells(3).Value)
                                        AgregarLineaRecibo(lineaRecibo)

                                        Dim actual = .CurrentRow.Cells(4).Value
                                        Dim numFactura = .CurrentRow.Cells(1).Value
                                        lblMostrarAbono.Text = _oUtilidades.PasarMoneda(CDbl(lblMostrarAbono.Text) + .Item(4, .CurrentRow.Index).Value)
                                        _oListaFacturas.Add(.CurrentRow.Cells(1).Value)
                                        lblActual.Text = _oUtilidades.PasarMoneda(CDbl(lblActual.Text) - .Item(4, .CurrentRow.Index).Value)
                                        .Rows.RemoveAt(.CurrentRow.Index)

                                        For i = 0 To oListAbonos.Count - 1
                                            lineaRecibo = CrearLineaRecibo("AB", oListAbonos(i).IdAbono, oListAbonos(i).Fecha, oListAbonos(i).Monto)
                                            AgregarLineaRecibo(lineaRecibo)
                                        Next

                                        For i = 0 To oListaNotasCredito.Count - 1
                                            lineaRecibo = CrearLineaRecibo("NC", oListaNotasCredito(i).IdNC, oListaNotasCredito(i).Fecha, oListaNotasCredito(i).Monto)
                                            AgregarLineaRecibo(lineaRecibo)
                                        Next

                                        If cantLineas > 0 Then
                                            lineaRecibo = CrearLineaRecibo("SA", numFactura, Now.ToString("dd/MM/yyyy"), actual)
                                            AgregarLineaRecibo(lineaRecibo)
                                        End If
                                    Else
                                        MsgBox("Está factura contiene muchos abonos y notas de crédito que no caben en el recibo, debe imprimir este y hacer otro")
                                    End If
                                ElseIf .Item(0, .CurrentRow.Index).Value = "NCG" Then

                                    lineaRecibo = CrearLineaRecibo("NCG", .CurrentRow.Cells(1).Value, .CurrentRow.Cells(2).Value, .CurrentRow.Cells(3).Value)
                                    AgregarLineaRecibo(lineaRecibo)

                                    _oListaNcg.Add(.CurrentRow.Cells(1).Value)
                                    lblMostrarAbono.Text = _oUtilidades.PasarMoneda(CDbl(lblMostrarAbono.Text) - .CurrentRow.Cells(4).Value)
                                    lblActual.Text = _oUtilidades.PasarMoneda(CDbl(lblActual.Text) + .Item(4, .CurrentRow.Index).Value)
                                    .Rows.RemoveAt(.CurrentRow.Index)
                                Else
                                    Dim oListAbonos = _oLogicaAbonos.consultarPendientesPorNumDocYTipo(.Item(1, .CurrentRow.Index).Value, Abono.ListaTipoDoc.NDG)

                                    lineaRecibo = CrearLineaRecibo("NDG", .CurrentRow.Cells(1).Value, .CurrentRow.Cells(2).Value, .CurrentRow.Cells(3).Value)
                                    AgregarLineaRecibo(lineaRecibo)

                                    For i = 0 To oListAbonos.Count - 1
                                        lineaRecibo = CrearLineaRecibo("AB", oListAbonos(i).IdAbono, oListAbonos(i).Fecha, oListAbonos(i).Monto)
                                        AgregarLineaRecibo(lineaRecibo)
                                    Next

                                    _oListaNdg.Add(.CurrentRow.Cells(1).Value)
                                    lblMostrarAbono.Text = _oUtilidades.PasarMoneda(CDbl(lblMostrarAbono.Text) + .CurrentRow.Cells(4).Value)
                                    lblActual.Text = _oUtilidades.PasarMoneda(CDbl(lblActual.Text) - .Item(4, .CurrentRow.Index).Value)
                                    .Rows.RemoveAt(.CurrentRow.Index)
                                End If

                            Else
                                MsgBox("El recibo está lleno, debe imprimir este y hacer otro")
                            End If
                        End If


                    End If
                End If


            End With
        End Sub

        Public Function CrearLineaRecibo(ByVal tipoDoc As String, ByVal numDoc As String, ByVal fechaDoc As String, ByVal montoDoc As Double) As LineaRecibo
            Dim lineaRecibo As New LineaRecibo
            lineaRecibo.Tipo = tipoDoc
            lineaRecibo.Doc = numDoc
            lineaRecibo.Fecha = fechaDoc
            lineaRecibo.Monto = montoDoc

            Return lineaRecibo
        End Function

        Public Sub AgregarLineaRecibo(ByVal lineaRecibo As LineaRecibo)

            If _oListaLineasRecibo.Count < 7 Then
                dgvTrans1.Rows.Add(lineaRecibo.Tipo, lineaRecibo.Doc, lineaRecibo.Fecha, _oUtilidades.PasarMoneda(lineaRecibo.Monto))
            ElseIf _lineas < 14 Then
                dgvTrans2.Rows.Add(lineaRecibo.Tipo, lineaRecibo.Doc, lineaRecibo.Fecha, _oUtilidades.PasarMoneda(lineaRecibo.Monto))
            Else
                dgvTrans3.Rows.Add(lineaRecibo.Tipo, lineaRecibo.Doc, lineaRecibo.Fecha, _oUtilidades.PasarMoneda(lineaRecibo.Monto))
            End If

            _lineas = _lineas + 1
            _oListaLineasRecibo.Add(lineaRecibo)
        End Sub

        Private Sub EliminarLineaRecibo(ByVal lineaRecibo As LineaRecibo)

            For i = 0 To _oListaLineasRecibo.Count - 1
                If _oListaLineasRecibo(i).Tipo = lineaRecibo.Tipo And _oListaLineasRecibo(i).Doc = lineaRecibo.Doc Then
                    _oListaLineasRecibo.RemoveAt(i)
                    Exit For
                End If
            Next

        End Sub

        Private Sub btnCargarRecibo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCargarRecibo.Click
            If IsNumeric(txtMontoAbono.Text) And txtMontoAbono.Text <> "0" Then
                With dgvFacturas
                    Dim total = CDbl(txtMontoAbono.Text)

                    If total <= CDbl(lblActual.Text) Then
                        _lineas = 0
                        Dim oListaFacturasTmp As New List(Of Long)

                        For i = 0 To .Rows.Count - 1
                            If .Item(0, i).Value = "FACT" Then
                                total = total - .Item(4, i).Value
                                If total >= 0 Then
                                    oListaFacturasTmp.Add(.Item(1, i).Value)
                                Else
                                    Exit For
                                End If
                            ElseIf .Item(0, i).Value = "NCG" Then
                                total = total + .Item(4, i).Value
                                If total >= 0 Then
                                    oListaFacturasTmp.Add(.Item(1, i).Value)
                                    _oListaNcg.Add(.Item(1, i).Value)
                                Else
                                    Exit For
                                End If
                            ElseIf .Item(0, i).Value = "NDG" Then
                                total = total - .Item(4, i).Value
                                If total >= 0 Then
                                    oListaFacturasTmp.Add(.Item(1, i).Value)
                                    _oListaNdg.Add(.Item(1, i).Value)
                                Else
                                    Exit For
                                End If
                            End If
                        Next

                        For i = 0 To oListaFacturasTmp.Count - 1

                            For j = .Rows.Count - 1 To 0 Step -1

                                If oListaFacturasTmp(i) = .Item(1, j).Value Then

                                    Dim factura = _oLogicaFactCredito.ConsultarFacturaPorNumFacturaSinAplicar(oListaFacturasTmp(i))

                                    If factura.NumFactura <> 0 Then
                                        Dim oListAbonos = _oLogicaAbonos.consultarPendientesPorNumDocYTipo(oListaFacturasTmp(i), Abono.ListaTipoDoc.FACT)
                                        Dim oListaNotasCredito = _oLogicaNotasCredito.consultarPorNum_FacturaSinAplicar(oListaFacturasTmp(i))
                                        Dim cantLineas = oListAbonos.Count + oListaNotasCredito.Count

                                        If _lineas < 42 Then

                                            If cantLineas + _lineas < 42 Then
                                                _oListaFacturas.Add(oListaFacturasTmp(i))

                                                Dim lineaRecibo As LineaRecibo
                                                lineaRecibo = CrearLineaRecibo("CA", .Rows(j).Cells(1).Value, .Rows(j).Cells(2).Value, .Rows(j).Cells(3).Value)
                                                AgregarLineaRecibo(lineaRecibo)

                                                Dim actual = .Rows(j).Cells(3).Value
                                                lblMostrarAbono.Text = _oUtilidades.PasarMoneda(CDbl(lblMostrarAbono.Text) + .Item(4, .Rows(j).Index).Value)
                                                .Rows.RemoveAt(.Rows(j).Index)

                                                For k = 0 To oListAbonos.Count - 1
                                                    lineaRecibo = CrearLineaRecibo("AB", oListAbonos(k).IdAbono, oListAbonos(k).Fecha, oListAbonos(k).Monto)
                                                    AgregarLineaRecibo(lineaRecibo)
                                                    actual -= oListAbonos(k).Monto
                                                Next

                                                For l = 0 To oListaNotasCredito.Count - 1
                                                    lineaRecibo = CrearLineaRecibo("NC", oListaNotasCredito(l).IdNC, oListaNotasCredito(l).Fecha.ToString("dd/MM/yyyy"), _oUtilidades.PasarMoneda(oListaNotasCredito(l).Monto))
                                                    AgregarLineaRecibo(lineaRecibo)
                                                    actual -= oListaNotasCredito(l).Monto
                                                Next

                                                If cantLineas > 0 Then
                                                    lineaRecibo = CrearLineaRecibo("SA", oListaFacturasTmp(i), Now.ToString("dd/MM/yyyy"), actual)
                                                    AgregarLineaRecibo(lineaRecibo)
                                                End If
                                            Else

                                                MsgBox("Está factura contiene muchos abonos y/o notas de crédito y no caben en el recibo, debe imprimir este y hacer otro", MsgBoxStyle.Information)
                                                j = 0
                                                i = oListaFacturasTmp.Count
                                            End If
                                        Else
                                            MsgBox("El recibo está lleno, debe imprimir este y hacer otro", MsgBoxStyle.Information)
                                            j = 0
                                            i = oListaFacturasTmp.Count
                                        End If

                                    Else
                                        If _lineas < 42 Then

                                            Dim notaCreditoGeneral = _oLogicaNotasCredito.consultarNota_CreditoGeneral(oListaFacturasTmp(i))
                                            Dim tipoDoc As String

                                            If notaCreditoGeneral.IdNC <> 0 Then
                                                tipoDoc = "NCG"
                                                lblMostrarAbono.Text = _oUtilidades.PasarMoneda(CDbl(lblMostrarAbono.Text) - .Item(4, .Rows(j).Index).Value)
                                            Else
                                                tipoDoc = "NDG"
                                                lblMostrarAbono.Text = _oUtilidades.PasarMoneda(CDbl(lblMostrarAbono.Text) + .Item(4, .Rows(j).Index).Value)
                                            End If

                                            Dim lineaRecibo As LineaRecibo
                                            lineaRecibo = CrearLineaRecibo(tipoDoc, .Rows(j).Cells(1).Value, .Rows(j).Cells(2).Value, .Rows(j).Cells(4).Value)
                                            AgregarLineaRecibo(lineaRecibo)

                                            .Rows.RemoveAt(.Rows(j).Index)
                                        End If
                                    End If

                                End If
                            Next

                        Next

                        lblActual.Text = _oUtilidades.PasarMoneda(CDbl(lblMostrarAnterior.Text) - CDbl(lblMostrarAbono.Text))

                        Dim vuelto = txtMontoAbono.Text - lblMostrarAbono.Text

                        If vuelto > 0 Then
                            btnAbonar.Enabled = True
                            txtVuelto.Text = _oUtilidades.PasarMoneda(vuelto)
                            btnAbonar.Focus()
                        End If

                        If .Rows.Count > 0 Then .Rows(0).Selected = False

                        btnCargarRecibo.Enabled = False
                        lblMostrarAnterior.Text = _oUtilidades.PasarMoneda(txtTotalCreditos.Text)
                        lblMostrarAbono.Text = _oUtilidades.PasarMoneda(lblMostrarAbono.Text)
                        lblActual.Text = _oUtilidades.PasarMoneda(txtTotalCreditos.Text - lblMostrarAbono.Text)
                    Else
                        MsgBox("El monto digitado no puede ser mayor al saldo actual")
                    End If

                End With
            End If
        End Sub

        Private Sub dgvFacturas_Leave(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvFacturas.Leave
            If dgvFacturas.Rows.Count > 0 Then
                If dgvFacturas.CurrentRow.Index >= 0 Then dgvFacturas.Rows(dgvFacturas.CurrentRow.Index).Selected = False
            End If
        End Sub

        Private Sub btnEjecutar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnEjecutar.Click

            If Trim(txtNombre.Text) = "" Then
                MessageBox.Show("Datos imcompletos, Debe agregar el nombre del cliente", "Insertar nueva linea", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf dgvTrans1.RowCount = 0 Then
                MessageBox.Show("Datos imcompletos, Debe seleccionar al menos una factura", "Insertar nueva linea", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                FrmFlujoCaja.Tipo = 1
                FrmFlujoCaja.Pantalla = 2
                FrmFlujoCaja.ShowDialog()

                If EstadoFlujoCaja Then
                    Dim respuesta As String

                    respuesta = MsgBox("Esta seguro que desea realizar esta transacción?", vbCritical + vbYesNo, "Realizar Transacción...")

                    If (respuesta = vbYes) Then

                        Cursor.Current = Cursors.WaitCursor
                        _oLogicaAbonos.RevisaBloqueoFactura()
                        _oLogicaAbonos.BloqueoRecibo_Facturas(True)

                        Dim oRecibo As New Recibo
                        oRecibo.Monto = _oUtilidades.PasarMoneda(CDbl(lblMostrarAbono.Text))
                        oRecibo.IdClienteCredito = CInt(txtId_Credito.Text)
                        oRecibo.NumRecibo = CInt(lblReciboFacturas.Text)
                        oRecibo.Anulado = 0
                        oRecibo.Fecha = Now.ToString("dd/MM/yyyy")
                        oRecibo.TotalCheques = OFlujoCaja.Cheques
                        oRecibo.TotalTransferencias = OFlujoCaja.Transferencia
                        oRecibo.TotalEfectivo = CDbl(lblMostrarAbono.Text) - OFlujoCaja.Cheques - OFlujoCaja.Transferencia
                        oRecibo.Observaciones = Observaciones
                        oRecibo.Concepto = Tipo
                        oRecibo.SaldoActual = CDbl(lblActual.Text)
                        oRecibo = LlenarRecibosDetalle(oRecibo)

                        Dim paginas = _oUtilidades.CalculaPaginas(_oListaLineasRecibo.Count / 21)

                        For i = 1 To paginas
                            If Tipo = 1 Then
                                LlenarRecibo(1, i, paginas)
                            ElseIf Tipo = 2 Then
                                LlenarRecibo(2, i, paginas)
                            ElseIf Tipo = 3 Then
                                LlenarRecibo(3, i, paginas)
                            End If
                        Next

                        _oLogicaReciboDinero.Insertar(oRecibo)

                        If Tipo = 1 Then
                            Cancelar()
                        ElseIf Tipo = 2 Then
                            Cancelar()
                            Abonar()
                        ElseIf Tipo = 3 Then
                            Abonar()
                        End If

                        AumentarConsecutivo()

                        Dim oCliente As New ClienteCredito
                        oCliente.IdCredito = CInt(txtId_Credito.Text)
                        oCliente.TotalCreditos = CDbl(lblActual.Text)
                        _oLogicaCliente.actualizarTotal_Credito(oCliente)

                        Dim nuevo = _oLogicaFlujo.ConsultarNuevo(Now.ToString("dd/MM/yyyy"))
                        If nuevo Then
                            _oLogicaFlujo.Insertar(OFlujoCaja)
                        Else
                            _oLogicaFlujo.Modificar(OFlujoCaja)
                        End If

                        _oLogicaAbonos.BloqueoRecibo_Facturas(False)

                        Cursor.Current = Cursors.Default

                        Dim oClienteCredito As New ClienteCredito
                        Dim lista = _oUtilidades.calcularDatos_Cliente(CInt(txtId_Credito.Text))

                        oClienteCredito.IdCredito = CInt(txtId_Credito.Text)
                        oClienteCredito.DiasAtrasado = lista(0)
                        oClienteCredito.TotalAtrasado = lista(1)
                        oClienteCredito.TotalCreditos = lista(2)

                        _oLogicaCliente.actualizarDatos_Credito(oClienteCredito)

                        Dim idClienteCredito = oClienteCredito.IdCredito
                        LimpiarTodo()
                        ClienteCredito(idClienteCredito)
                        txtId_Credito.Text = idClienteCredito
                    End If
                End If
            End If
        End Sub

        Public Sub CalcularTotales()
            Dim montoTotal = CDbl(lblMostrarAbono.Text)
            Dim numeroRedondeo = _oLogicaMoneda.ConsultarMoneda

            _totalTransferencias = OFlujoCaja.Transferencia
            _totalEfectivo = 0.0
            _totalCheque = OFlujoCaja.Cheques

            If OFlujoCaja.Cheques >= Math.Abs(montoTotal) Then
                _totalCheque = montoTotal
                _totalEfectivo = 0
                _totalTransferencias = 0
                If OFlujoCaja.Cheques > montoTotal + numeroRedondeo Then
                    Observaciones += " -Se reintegra al cliente una diferencia en efectivo por cheque de ¢" & (OFlujoCaja.Cheques - montoTotal)
                End If
            End If

            If OFlujoCaja.Transferencia >= Math.Abs(montoTotal) Then
                _totalTransferencias = montoTotal
                _totalEfectivo = 0
                _totalCheque = 0
                If OFlujoCaja.Transferencia > montoTotal + numeroRedondeo Then
                    Observaciones += " -Se reintegra al cliente una diferencia en efectivo por transferencia de ¢" & (OFlujoCaja.Transferencia - montoTotal)
                End If
            End If

            If OFlujoCaja.Transferencia < Math.Abs(montoTotal) And OFlujoCaja.Cheques < Math.Abs(montoTotal) Then
                If (OFlujoCaja.Transferencia + OFlujoCaja.Cheques) > montoTotal + numeroRedondeo Then
                    Observaciones += " -Se reintegra al cliente una diferencia en efectivo de ¢" & (OFlujoCaja.Transferencia + OFlujoCaja.Cheques - montoTotal)
                    _totalEfectivo = 0
                    _totalCheque = 0
                End If
            End If

            If (OFlujoCaja.Transferencia + OFlujoCaja.Cheques) < Math.Abs(montoTotal) Then
                _totalEfectivo = montoTotal - (_totalTransferencias + _totalCheque)
            End If
        End Sub

        Private Sub Cancelar()

            For i As Integer = 0 To _oListaFacturas.Count - 1
                _oLogicaFactCredito.cambiarAplicada_NumFactura(_oListaFacturas(i))
            Next

            For i As Integer = 0 To _oListaNcg.Count - 1
                Dim ncGeneral As New NotaCreditoGeneral
                ncGeneral.IdNC = _oListaNcg(i)
                ncGeneral.Estado = NotaCreditoGeneral.ListaEstado.Aplicada
                _oLogicaNotasCredito.actualizarGeneralEstado_IdNC(ncGeneral)
            Next

            For i As Integer = 0 To _oListaNdg.Count - 1
                Dim ndGeneral As New NotaDebitoGeneral
                ndGeneral.IdND = _oListaNdg(i)
                ndGeneral.Estado = NotaDebitoGeneral.ListaEstado.Aplicada
                _oLogicaNotasDebito.actualizarGeneralEstado_IdND(ndGeneral)
            Next
        End Sub

        Private Sub AumentarConsecutivo()
            Dim oConsecutivoReciboFact As New Consecutivo
            oConsecutivoReciboFact.Tabla = "CONSECUTIVO_RECIBO_FACT"
            _oLogicaConsecutivo.AumentarConsecutivo(oConsecutivoReciboFact)
        End Sub

        Private Sub LlenarRecibo(ByVal concepto As Integer, ByVal pagina As Integer, ByVal paginas As Integer)
            Dim rptRecibo As New RptReciboDinero
            Dim numCopias As Integer = 1

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

                    If _oListaLineasRecibo.Count < 21 Then
                        indice = _oListaLineasRecibo.Count - 1
                    End If

                    For j = 0 To indice

                        If j < 7 Then
                            fila = table.NewRow
                            fila = AgregarAFilaLinea1(fila, _oListaLineasRecibo(j).Tipo, _oListaLineasRecibo(j).Doc, _oListaLineasRecibo(j).Fecha, _oUtilidades.PasarMoneda(_oListaLineasRecibo(j).Monto))
                            table.Rows.Add(fila)
                        ElseIf j < 14 Then
                            table = AgregarAFilaLinea2(table, j, _oListaLineasRecibo(j).Tipo, _oListaLineasRecibo(j).Doc, _oListaLineasRecibo(j).Fecha, _oUtilidades.PasarMoneda(_oListaLineasRecibo(j).Monto))
                        Else
                            table = AgregarAFilaLinea3(table, j, _oListaLineasRecibo(j).Tipo, _oListaLineasRecibo(j).Doc, _oListaLineasRecibo(j).Fecha, _oUtilidades.PasarMoneda(_oListaLineasRecibo(j).Monto))
                        End If
                    Next

                ElseIf pagina = 2 Then
                    For j = 21 To _oListaLineasRecibo.Count - 1
                        If j < 28 Then
                            fila = table.NewRow
                            fila = AgregarAFilaLinea1(fila, _oListaLineasRecibo(j).Tipo, _oListaLineasRecibo(j).Doc, _oListaLineasRecibo(j).Fecha, _oListaLineasRecibo(j).Monto)
                            table.Rows.Add(fila)
                        ElseIf j < 35 Then
                            table = AgregarAFilaLinea2(table, j - 21, _oListaLineasRecibo(j).Tipo, _oListaLineasRecibo(j).Doc, _oListaLineasRecibo(j).Fecha, _oListaLineasRecibo(j).Monto)
                        Else
                            table = AgregarAFilaLinea3(table, j - 21, _oListaLineasRecibo(j).Tipo, _oListaLineasRecibo(j).Doc, _oListaLineasRecibo(j).Fecha, _oListaLineasRecibo(j).Monto)
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
                Dim montoTotal = CDbl(lblMostrarAbono.Text)
                Dim esPositivo = True
                If montoTotal < 0 Then
                    esPositivo = False
                End If
                Dim decimales As String = _oUtilidades.PasarMoneda(montoTotal)
                Dim dec = decimales.Split(".")

                If CInt(montoTotal) = montoTotal Then
                    If esPositivo Then
                        .SetParameterValue("monto_Letras", _oUtilidades.Num_A_Letras(dec(0)) & " COLONES NETOS.")
                    Else
                        Dim mont As Double = Math.Abs(CDbl(dec(0)))
                        .SetParameterValue("monto_Letras", _oUtilidades.Num_A_Letras(mont) & " COLONES NETOS A DEVOLVER.")
                    End If
                Else
                    If esPositivo Then
                        .SetParameterValue("monto_Letras", _oUtilidades.Num_A_Letras(dec(0)) & " COLONES CON " & dec(1) & "/100.")
                    Else
                        Dim mont As Double = Math.Abs(CDbl(dec(0)))
                        .SetParameterValue("monto_Letras", _oUtilidades.Num_A_Letras(mont) & " COLONES CON " & dec(1) & "/100 A DEVOLVER")
                    End If
                End If

                .SetParameterValue("cliente", txtNombre.Text)
                .SetParameterValue("num_Recibo", "#" & lblReciboFacturas.Text)
                .SetParameterValue("fecha", Now.ToString("dd/MM/yyyy"))
                .SetParameterValue("monto", montoTotal)

                If paginas = 2 And pagina = 1 Then
                    .SetParameterValue("totalCheques", 0)
                    .SetParameterValue("totalTransferencia", 0)
                    .SetParameterValue("totalEfectivo", 0)
                Else
                    .SetParameterValue("totalCheques", _totalCheque)
                    .SetParameterValue("totalTransferencia", _totalTransferencias)
                    .SetParameterValue("totalEfectivo", _totalEfectivo)
                End If

                .SetParameterValue("observaciones", UCase(Observaciones))
                .SetParameterValue("numPagina", pagina)
                .SetParameterValue("Paginas", paginas)
                .SetParameterValue("saldo", _oUtilidades.PasarMoneda(CDbl(lblActual.Text)))

                Select Case concepto
                    Case 1
                        .SetParameterValue("concepto", "CANCELACION DE FACTURA(S)")
                        numCopias = 1
                    Case 2
                        .SetParameterValue("concepto", "CANCELACION Y ABONO A FACTURA(S)")
                        numCopias = 2
                    Case 3
                        .SetParameterValue("concepto", "ABONO A FACTURA")
                        numCopias = 2
                End Select

                Dim nombreImpresora = _oLogicaVarios.ConsultarColumna("Imp_Tercio_Oficio")
                Dim nombrePc = _oLogicaVarios.ConsultarColumna("PC_Tercio_Oficio")
                .PrintOptions.PrinterName = "\\" & nombrePc & "\" & nombreImpresora

                .PrintToPrinter(numCopias, False, 1, 1)

            End With
        End Sub

        Private Function ImpresoraConectada(ByVal nombreImpresora As String) As Boolean
            Dim oquery As ObjectQuery = New ObjectQuery("SELECT * FROM Win32_Printer")
            Dim mosearcher As ManagementObjectSearcher = New ManagementObjectSearcher(oquery)
            Dim moc As System.Management.ManagementObjectCollection = mosearcher.Get()


            For Each printer As ManagementObject In moc
                Dim val = New List(Of String)
                For Each pro As PropertyData In printer.Properties
                    'If (pro.Name = "Name" Or pro.Name = "PrinterState" Or pro.Name = "PrinterStatus") Then
                    Dim name = pro.Name
                    Dim value = pro.Value
                    Val.Add(Convert.ToString(name) & "---" & Convert.ToString(value))
                    'End If
                Next pro
            Next printer

            Return False
        End Function

        Private Function AgregarAFilaLinea1(ByVal fila As DataRow, ByVal tipoDoc As String, ByVal numDoc As String, ByVal fechaDoc As String, ByVal montoDoc As Double) As DataRow
            fila.Item("Tipo") = tipoDoc
            fila.Item("Doc") = numDoc
            fila.Item("Fecha") = fechaDoc
            fila.Item("Monto") = montoDoc

            Return fila
        End Function

        Private Function AgregarAFilaLinea2(ByVal table As DataTable, ByVal j As Integer, ByVal tipoDoc As String, ByVal numDoc As String, ByVal fechaDoc As String, ByVal montoDoc As Double) As DataTable
            table.Rows(j - 7).Item("Tipo2") = tipoDoc
            table.Rows(j - 7).Item("Doc2") = numDoc
            table.Rows(j - 7).Item("Fecha2") = fechaDoc
            table.Rows(j - 7).Item("Monto2") = montoDoc

            Return table
        End Function

        Private Function AgregarAFilaLinea3(ByVal table As DataTable, ByVal j As Integer, ByVal tipoDoc As String, ByVal numDoc As String, ByVal fechaDoc As String, ByVal montoDoc As Double) As DataTable
            table.Rows(j - 14).Item("Tipo3") = tipoDoc
            table.Rows(j - 14).Item("Doc3") = numDoc
            table.Rows(j - 14).Item("Fecha3") = fechaDoc
            table.Rows(j - 14).Item("Monto3") = montoDoc

            Return table
        End Function

        Private Function LlenarRecibosDetalle(ByVal oRecibo As Recibo) As Recibo
            With _oListaLineasRecibo
                For i As Integer = 0 To .Count - 1
                    Dim oReciboDetalle As New ReciboDetalle
                    oReciboDetalle.NumRecibo = CInt(lblReciboFacturas.Text)
                    oReciboDetalle.Tipo = VerificarTipo(_oListaLineasRecibo(i).Tipo)
                    oReciboDetalle.Doc = _oListaLineasRecibo(i).Doc
                    oReciboDetalle.Fecha = _oListaLineasRecibo(i).Fecha
                    oReciboDetalle.Monto = _oUtilidades.PasarMoneda(_oListaLineasRecibo(i).Monto)
                    oRecibo.ReciboDetalle.Add(oReciboDetalle)
                Next
            End With

            Return oRecibo
        End Function

        Private Function VerificarTipo(ByVal tipoDoc As String) As Recibo.ListaConcepto

            If tipoDoc = "Fact" Then
                Return ReciboDetalle.ListaTipo.FactAbono
            ElseIf tipoDoc = "AB" Then
                Return ReciboDetalle.ListaTipo.Abono
            ElseIf tipoDoc = "CA" Then
                Return ReciboDetalle.ListaTipo.Cancelacion
            ElseIf tipoDoc = "NC" Then
                Return ReciboDetalle.ListaTipo.NotaCredito
            ElseIf tipoDoc = "NCG" Then
                Return ReciboDetalle.ListaTipo.NCGeneral
            ElseIf tipoDoc = "NDG" Then
                Return ReciboDetalle.ListaTipo.NDGeneral
            ElseIf tipoDoc = "SA" Then
                Return ReciboDetalle.ListaTipo.SaldoActual
            Else
                Return ReciboDetalle.ListaTipo.NDGeneral
            End If
        End Function

        Private Sub Abonar()
            _oLogicaAbonos.RevisaBloqueo()

            _oLogicaAbonos.Bloqueo(True)

            Dim abono As New Abono
            abono.IdAbono = CInt(lblMostrarReciboAbonos.Text)
            abono.NumDoc = OAbono.NumDoc
            abono.Fecha = Now.ToString("dd/MM/yyyy")
            abono.Monto = OAbono.Monto
            abono.TipoDoc = OAbono.TipoDoc
            abono.Observaciones = UCase(Observaciones)
            abono.Estado = abono.ListaEstado.Pendiente

            Dim oConsecutivo As New Consecutivo
            oConsecutivo.Tabla = "CONSECUTIVO_ABONO"
            _oLogicaConsecutivo.AumentarConsecutivo(oConsecutivo)

            _oLogicaAbonos.Insertar(abono)
            _oLogicaAbonos.Bloqueo(False)
        End Sub

        Private Sub txtMontoAbono_KeyDown_1(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtMontoAbono.KeyDown
            If IsNumeric(txtMontoAbono.Text) And Trim(txtId_Credito.Text) <> "" Then
                If CInt(txtMontoAbono.Text) > 0 And dgvTrans1.Rows.Count <= 0 Then
                    btnCargarRecibo.Enabled = True
                End If
            End If
            If e.KeyValue = 13 Then
                btnCargarRecibo.Focus()
            End If
        End Sub

        Private Sub dgvTrans1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvTrans1.Click
            With dgvTrans1
                If .Rows.Count > 0 And Tipo = 1 Then
                    If .CurrentCell.RowIndex >= 0 And .Rows(.CurrentRow.Index).Cells(0).Value <> "AB" And .Rows(.CurrentRow.Index).Cells(0).Value <> "NC" And .Rows(.CurrentRow.Index).Cells(0).Value <> "SA" Then
                        ActualizarDatosResta(.Item(1, .CurrentRow.Index).Value, .Item(0, .CurrentRow.Index).Value, 1)
                        Dim lineaRecibo As LineaRecibo
                        lineaRecibo = CrearLineaRecibo(.Item(0, .CurrentRow.Index).Value, .Item(1, .CurrentRow.Index).Value, .Item(2, .CurrentRow.Index).Value, .Item(3, .CurrentRow.Index).Value)
                        EliminarLineaRecibo(lineaRecibo)
                        .Rows.RemoveAt(.CurrentRow.Index)

                        If .RowCount > 0 Then

                            Dim i As Integer = .CurrentRow.Index

                            While (.Rows(i).Cells(0).Value = "AB" Or .Rows(i).Cells(0).Value = "NC" Or .Rows(i).Cells(0).Value = "SA")
                                lineaRecibo = CrearLineaRecibo(.Item(0, i).Value, .Item(1, i).Value, .Item(2, i).Value, .Item(3, i).Value)
                                EliminarLineaRecibo(lineaRecibo)
                                .Rows.RemoveAt(i)
                                moverFacturasHacia_dgvTrans1()

                                If .Rows.Count = 0 Or .Rows.Count <= i Then
                                    Exit While
                                End If
                            End While

                            moverFacturasHacia_dgvTrans1()

                        End If
                    End If
                End If

                _lineas = dgvTrans1.RowCount + dgvTrans2.RowCount + dgvTrans3.RowCount
            End With

            dgvFacturas.Sort(dgvFacturas.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
        End Sub

        Private Sub moverFacturasHacia_dgvTrans1()
            If dgvTrans2.Rows.Count > 0 Then
                dgvTrans1.Rows.Add(dgvTrans2.Rows(0).Cells(0).Value, dgvTrans2.Rows(0).Cells(1).Value, dgvTrans2.Rows(0).Cells(2).Value, dgvTrans2.Rows(0).Cells(3).Value)
                dgvTrans2.Rows.RemoveAt(0)

                If dgvTrans3.Rows.Count > 0 Then
                    dgvTrans2.Rows.Add(dgvTrans3.Rows(0).Cells(0).Value, dgvTrans3.Rows(0).Cells(1).Value, dgvTrans3.Rows(0).Cells(2).Value, dgvTrans3.Rows(0).Cells(3).Value)
                    dgvTrans3.Rows.RemoveAt(0)
                End If
            End If
        End Sub

        Private Sub ActualizarDatosResta(ByVal numDoc As Long, ByVal tipoDoc As String, ByVal numDvg As Integer)
            Dim oFactura As New FacturaCredito

            If tipoDoc = "FACT" Or tipoDoc = "CA" Then
                For i = 0 To _oListaFacturas.Count - 1
                    If _oListaFacturas(i) = numDoc Then
                        oFactura = _oLogicaFactCredito.ConsultarFacturaPorNumFacturaSinAplicar(_oListaFacturas(i))
                        _oListaFacturas.RemoveAt(i)
                        Exit For
                    End If
                Next

                Dim fechaFactura As Date = oFactura.Fecha
                Dim dias = DateDiff("d", oFactura.Fecha, Now)
                Dim diasAtraso As Integer
                Dim montoConAbonos As Double

                diasAtraso = dias - oFactura.NumDias
                Dim abonos As Double = 0
                For j = 0 To oFactura.Abonos.Count - 1
                    abonos = abonos + oFactura.Abonos(j).Monto
                Next

                Dim notasCredito As Double = 0
                For j = 0 To oFactura.NotasCredito.Count - 1
                    notasCredito = notasCredito + oFactura.NotasCredito(j).Monto
                Next

                montoConAbonos = oFactura.Monto - abonos - notasCredito

                lblMostrarAbono.Text = _oUtilidades.PasarMoneda(CDbl(lblMostrarAbono.Text) - montoConAbonos)
                lblActual.Text = _oUtilidades.PasarMoneda(CDbl(lblActual.Text) + montoConAbonos)

                dgvFacturas.Rows.Add("FACT", oFactura.NumFactura, fechaFactura.ToString("dd/MM/yyyy"), _oUtilidades.PasarMoneda(oFactura.Monto), _oUtilidades.PasarMoneda(montoConAbonos), oFactura.NumDias, diasAtraso, oFactura.Abonos.Count & "- Ver", oFactura.NotasCredito.Count & "- Ver", "Ver")
            ElseIf tipoDoc = "NCG" Then
                Select Case numDvg
                    Case 1
                        DevolverLineaNCG(ObtenerFecha(dgvTrans1), ObtenerNumDoc(dgvTrans1), ObtenerMonto(dgvTrans1))
                    Case 2
                        DevolverLineaNCG(ObtenerFecha(dgvTrans2), ObtenerNumDoc(dgvTrans2), ObtenerMonto(dgvTrans2))
                    Case 3
                        DevolverLineaNCG(ObtenerFecha(dgvTrans3), ObtenerNumDoc(dgvTrans3), ObtenerMonto(dgvTrans3))
                End Select
            ElseIf tipoDoc = "NDG" Then
                Select Case numDvg
                    Case 1
                        DevolverLineaNDG(ObtenerFecha(dgvTrans1), ObtenerNumDoc(dgvTrans1), ObtenerMonto(dgvTrans1))
                    Case 2
                        DevolverLineaNDG(ObtenerFecha(dgvTrans2), ObtenerNumDoc(dgvTrans2), ObtenerMonto(dgvTrans2))
                    Case 3
                        DevolverLineaNDG(ObtenerFecha(dgvTrans3), ObtenerNumDoc(dgvTrans3), ObtenerMonto(dgvTrans3))
                End Select
            End If
        End Sub

        Private Sub DevolverLineaNDG(ByVal fecha As DateTime, ByVal numDoc As Integer, ByVal total As Double)
            Dim oNdg = _oLogicaNotasDebito.consultarNota_DebitoGeneral(numDoc)
            Dim dias = DateDiff("d", fecha, Now)
            Dim diasAtraso = dias - 30
            Dim montoConAbonos As Double

            Dim abonos As Double = 0
            For j = 0 To oNdg.Abonos.Count - 1
                abonos = abonos + oNdg.Abonos(j).Monto
            Next
            montoConAbonos = total - abonos
            dgvFacturas.Rows.Add("NDG", numDoc, fecha.ToString("dd/MM/yyyy"), _oUtilidades.PasarMoneda(total), _oUtilidades.PasarMoneda(montoConAbonos), 30, diasAtraso, oNdg.Abonos.Count & "- Ver", "", "Ver")
            lblMostrarAbono.Text = _oUtilidades.PasarMoneda(CDbl(lblMostrarAbono.Text) - montoConAbonos)
            lblActual.Text = _oUtilidades.PasarMoneda(CDbl(lblActual.Text) + montoConAbonos)
            _oListaNdg.Remove(numDoc)
        End Sub

        Private Sub DevolverLineaNCG(ByVal fecha As DateTime, ByVal numDoc As Integer, ByVal total As Double)
            Dim dias = DateDiff("d", fecha, Now)
            Dim diasAtraso = dias - 30
            dgvFacturas.Rows.Add("NCG", numDoc, fecha.ToString("dd/MM/yyyy"), _oUtilidades.PasarMoneda(total), _oUtilidades.PasarMoneda(total), 30, diasAtraso, "Ver")
            lblMostrarAbono.Text = _oUtilidades.PasarMoneda(CDbl(lblMostrarAbono.Text) + total)
            lblActual.Text = _oUtilidades.PasarMoneda(CDbl(lblActual.Text) - total)
            _oListaNcg.Remove(numDoc)
        End Sub

        Private Function ObtenerFecha(ByRef dgv As DataGridView) As DateTime
            Return dgv.Item(2, dgv.CurrentRow.Index).Value
        End Function

        Private Function ObtenerMonto(ByRef dgv As DataGridView) As Double
            Return dgv.Item(3, dgv.CurrentRow.Index).Value
        End Function

        Private Function ObtenerNumDoc(ByRef dgv As DataGridView) As Integer
            Return dgv.Item(1, dgv.CurrentRow.Index).Value
        End Function

        Private Sub dgvTrans2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvTrans2.Click
            With dgvTrans2
                If .Rows.Count > 0 And Tipo = 1 Then
                    If .CurrentCell.RowIndex >= 0 And .Rows(.CurrentRow.Index).Cells(0).Value <> "AB" And .Rows(.CurrentRow.Index).Cells(0).Value <> "NC" Then
                        ActualizarDatosResta(.Item(1, .CurrentRow.Index).Value, .Item(0, .CurrentRow.Index).Value, 2)
                        Dim lineaRecibo As LineaRecibo
                        lineaRecibo = CrearLineaRecibo(.Item(0, .CurrentRow.Index).Value, .Item(1, .CurrentRow.Index).Value, .Item(2, .CurrentRow.Index).Value, .Item(3, .CurrentRow.Index).Value)
                        EliminarLineaRecibo(lineaRecibo)
                        .Rows.RemoveAt(.CurrentRow.Index)

                        If .RowCount > 0 Then
                            Dim i As Integer = .CurrentRow.Index

                            While (.Rows(i).Cells(0).Value = "AB" Or .Rows(i).Cells(0).Value = "NC")
                                lineaRecibo = CrearLineaRecibo(.Item(0, i).Value, .Item(1, i).Value, .Item(2, i).Value, .Item(3, i).Value)
                                EliminarLineaRecibo(lineaRecibo)
                                .Rows.RemoveAt(i)

                                If dgvTrans3.Rows.Count > 0 Then
                                    .Rows.Add(dgvTrans3.Rows(0).Cells(0).Value, dgvTrans3.Rows(0).Cells(1).Value, dgvTrans3.Rows(0).Cells(2).Value, dgvTrans3.Rows(0).Cells(3).Value)
                                    dgvTrans3.Rows.RemoveAt(0)
                                End If

                                If .Rows.Count = 0 Or .Rows.Count <= i Then
                                    Exit While
                                End If
                            End While

                            If dgvTrans3.Rows.Count > 0 Then
                                .Rows.Add(dgvTrans3.Rows(0).Cells(0).Value, dgvTrans3.Rows(0).Cells(1).Value, dgvTrans3.Rows(0).Cells(2).Value, dgvTrans3.Rows(0).Cells(3).Value)
                                dgvTrans3.Rows.RemoveAt(0)
                            End If
                        End If

                    End If
                End If

                _lineas = dgvTrans1.RowCount + dgvTrans2.RowCount + dgvTrans3.RowCount
            End With

            dgvFacturas.Sort(dgvFacturas.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
        End Sub

        Private Sub dgvTrans3_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvTrans3.Click
            With dgvTrans3
                If .Rows.Count > 0 And Tipo = 1 Then
                    If .CurrentCell.RowIndex >= 0 And .Rows(.CurrentRow.Index).Cells(0).Value <> "AB" And .Rows(.CurrentRow.Index).Cells(0).Value <> "NC" Then
                        ActualizarDatosResta(.Item(1, .CurrentRow.Index).Value, .Item(0, .CurrentRow.Index).Value, 3)
                        Dim lineaRecibo As LineaRecibo
                        lineaRecibo = CrearLineaRecibo(.Item(0, .CurrentRow.Index).Value, .Item(1, .CurrentRow.Index).Value, .Item(2, .CurrentRow.Index).Value, .Item(3, .CurrentRow.Index).Value)
                        EliminarLineaRecibo(lineaRecibo)
                        .Rows.RemoveAt(.CurrentRow.Index)

                        If .RowCount > 0 Then
                            Dim i As Integer = .CurrentRow.Index

                            While (.Rows(i).Cells(0).Value = "AB" Or .Rows(i).Cells(0).Value = "NC")
                                lineaRecibo = CrearLineaRecibo(.Item(0, i).Value, .Item(1, i).Value, .Item(2, i).Value, .Item(3, i).Value)
                                EliminarLineaRecibo(lineaRecibo)
                                .Rows.RemoveAt(i)

                                If .Rows.Count = 0 Or .Rows.Count <= i Then
                                    Exit While
                                End If
                            End While
                        End If

                    End If
                End If

                _lineas = dgvTrans1.RowCount + dgvTrans2.RowCount + dgvTrans3.RowCount
            End With

            dgvFacturas.Sort(dgvFacturas.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
        End Sub

        Private Sub btnAbonar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAbonar.Click
            With dgvFacturas
                If .Rows.Count > 0 Then
                    If _lineas < 39 Then
                        Dim lineaRecibo As LineaRecibo
                        lineaRecibo = CrearLineaRecibo("Fact", .Rows(0).Cells(1).Value, .Rows(0).Cells(2).Value, .Rows(0).Cells(3).Value)
                        AgregarLineaRecibo(lineaRecibo)

                        lineaRecibo = CrearLineaRecibo("AB", lblMostrarReciboAbonos.Text, Now.ToString("dd/MM/yyyy"), txtVuelto.Text)
                        AgregarLineaRecibo(lineaRecibo)

                        lineaRecibo = CrearLineaRecibo("SA", .Rows(0).Cells(1).Value, Now.ToString("dd/MM/yyyy"), _oUtilidades.PasarMoneda(.Rows(0).Cells(4).Value - txtVuelto.Text))
                        AgregarLineaRecibo(lineaRecibo)

                        OAbono.NumDoc = .Rows(0).Cells(1).Value
                        OAbono.Monto = txtVuelto.Text
                        _lineas = _lineas + 1
                        lblMostrarAbono.Text = _oUtilidades.PasarMoneda(CDbl(lblMostrarAbono.Text) + txtVuelto.Text)
                        lblActual.Text = _oUtilidades.PasarMoneda(CDbl(lblMostrarAnterior.Text) - CDbl(lblMostrarAbono.Text))
                        txtVuelto.Text = 0
                        Tipo = 2
                        btnAbonar.Enabled = False
                    Else
                        MsgBox("El recibo está lleno, debe imprimir este y hacer otro")
                    End If
                End If

            End With

        End Sub

        Private Sub AbonarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles AbonarToolStripMenuItem.Click
            Try
                If dgvFacturas.Rows.Count > 0 Then
                    If dgvTrans1.Rows.Count <= 0 Then
                        FrmAbonos.txtNumDoc.Text = dgvFacturas.CurrentRow.Cells(1).Value
                        FrmAbonos.txtMonto.Text = dgvFacturas.CurrentRow.Cells(3).Value
                        FrmAbonos.txtMontoNeto.Text = dgvFacturas.CurrentRow.Cells(4).Value
                        FrmAbonos.txtNumAb.Text = dgvFacturas.CurrentRow.Cells(7).Value
                        FrmAbonos.txtTipo.Text = dgvFacturas.CurrentRow.Cells(0).Value
                        FrmAbonos.ShowDialog()
                    Else
                        MsgBox("No debe haber nada en la tabla del recibo, limpie la tabla primero")
                    End If
                End If
            Catch ex As Exception

            End Try
        End Sub

        Private Sub FrmFacturaCredito_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            AddHandler dgvFacturas.MouseDown, AddressOf SeleccionaClickDerecho
            AddHandler txtMontoAbono.KeyPress, AddressOf ValidarNumerosPunto
            EstadoFlujoCaja = False
            dgvFacturas.ContextMenuStrip = MnAbonar
        End Sub

        Private Sub FrmFacturaCredito_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            If Trim(txtId_Credito.Text) <> "" Then
                _oLogicaCliente.ModificarBloqueo(CInt(txtId_Credito.Text), 0)
            End If
            Dispose()
        End Sub

        Private Sub NotaCréditoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles NotaCréditoToolStripMenuItem.Click
            Try
                If dgvFacturas.Rows.Count > 0 Then
                    With FrmNotaCredito
                        .txtNumFactura.Text = dgvFacturas.CurrentRow.Cells(1).Value
                        .txtFecha.Text = dgvFacturas.CurrentRow.Cells(2).Value
                        .txtNombreCliente.Text = txtNombre.Text
                        .txtId_Credito.Text = txtId_Credito.Text
                        .ShowDialog()
                    End With
                End If
            Catch ex As Exception

            End Try

        End Sub

        Private Sub txtNombre_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
            CambiarControlADataGrid(dgvClientes, e, txtNombre, txtNombre, txtNombre)
        End Sub

        Private Sub txtNombre_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
            BuscarClienteCreditoPorNombre(dgvClientes, e, txtNombre, txtId_Credito)
        End Sub

        Private Sub dgvClientes_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles dgvClientes.KeyDown
            If e.KeyValue = 13 Then
                ClienteCredito(dgvClientes.Item(0, dgvClientes.CurrentRow.Index).Value)
            End If
        End Sub

        Private Sub dgvClientes_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvClientes.Click
            ClienteCredito(dgvClientes.Item(0, dgvClientes.CurrentRow.Index).Value)
        End Sub

        Public Sub ClienteCredito(ByVal idCredito As Integer)
            dgvClientes.DataSource = Nothing
            dgvClientes.Visible = False

            Dim oCredito = _oLogicaCliente.ConsultarPorIdCredito(idCredito)
            If oCredito.IdCredito <> 0 Then
                If oCredito.Bloqueo Then
                    MsgBox("El cliente credito ha sido abierto en otra ventana por lo que no puede ser abierto", MsgBoxStyle.Information)
                    txtNombre.Text = String.Empty
                    dgvClientes.Visible = False
                    txtId_Credito.Text = String.Empty
                Else
                    txtNombre.Text = oCredito.Nombre + " " + oCredito.PrimerApellido + " " + oCredito.SegundoApellido
                    txtCedula.Text = oCredito.Cedula

                    txtLimite.Text = _oUtilidades.PasarMoneda(oCredito.Limite)
                    txtId_Credito.Text = oCredito.IdCredito
                    CargarDatos(oCredito.IdCredito)
                    _oLogicaCliente.ModificarBloqueo(oCredito.IdCredito, 1)
                End If
            Else
                LimpiarTodo()
                MsgBox("El cliente seleccionado no tiene crédito")
            End If

        End Sub

        Private Sub btnEstado_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnEstado.Click

            If IsNumeric(txtId_Credito.Text) Then
                Dim table As DataTable
                Dim colum As DataColumn
                Dim colum2 As DataColumn
                Dim tmpTable As DataTable

                table = New DataTable("rptESTADO")
                tmpTable = New DataTable("rptESTADO")

                colum = New DataColumn("Tipo")
                table.Columns.Add(colum)
                colum2 = New DataColumn("Tipo")
                tmpTable.Columns.Add(colum2)
                colum = New DataColumn("Doc")
                table.Columns.Add(colum)
                colum2 = New DataColumn("Doc")
                tmpTable.Columns.Add(colum2)
                colum = New DataColumn("Fecha")
                table.Columns.Add(colum)
                colum2 = New DataColumn("Fecha")
                tmpTable.Columns.Add(colum2)
                colum = New DataColumn("Fecha_Vence")
                table.Columns.Add(colum)
                colum2 = New DataColumn("Fecha_Vence")
                tmpTable.Columns.Add(colum2)
                colum = New DataColumn("Dias")
                table.Columns.Add(colum)
                colum2 = New DataColumn("Dias")
                tmpTable.Columns.Add(colum2)
                colum = New DataColumn("Atraso")
                table.Columns.Add(colum)
                colum2 = New DataColumn("Atraso")
                tmpTable.Columns.Add(colum2)
                colum = New DataColumn("Monto")
                table.Columns.Add(colum)
                colum2 = New DataColumn("Monto")
                tmpTable.Columns.Add(colum2)
                colum = New DataColumn("SaldoAcumulado")
                table.Columns.Add(colum)
                colum2 = New DataColumn("SaldoAcumulado")
                tmpTable.Columns.Add(colum2)
                colum = New DataColumn("Negrita")
                table.Columns.Add(colum)
                colum2 = New DataColumn("Negrita")
                tmpTable.Columns.Add(colum2)

                Dim oListFacturas As List(Of FacturaCredito)
                oListFacturas = _oLogicaFactCredito.consultarFacturasPorId_Credito(CInt(txtId_Credito.Text))

                Dim oNotasCreditoGenerales As List(Of NotaCreditoGeneral)
                oNotasCreditoGenerales = _oLogicaNotasCredito.ConsultarGeneral(CInt(txtId_Credito.Text))

                Dim oNotasDebitoGenerales As List(Of NotaDebitoGeneral)
                oNotasDebitoGenerales = _oLogicaNotasDebito.ConsultarGeneral(CInt(txtId_Credito.Text))

                Dim total As Double

                For i = 0 To dgvFacturas.Rows.Count - 1
                    Dim type = dgvFacturas.Item(0, i).Value

                    Select Case type
                        Case "FACT"
                            Dim factura = GetFacturaCredito(oListFacturas, dgvFacturas.Item(1, i).Value)
                            total = CargarFacturaCredito(factura, total, table)
                        Case "NCG"
                            Dim ncg = GetNCG(oNotasCreditoGenerales, dgvFacturas.Item(1, i).Value)
                            total = CargarNCG(ncg, total, table)
                        Case "NDG"
                            Dim ndg = GetNDG(oNotasDebitoGenerales, dgvFacturas.Item(1, i).Value)
                            total = CargarNDG(ndg, total, table)
                    End Select
                Next

                Dim paginas = _oUtilidades.CalculaPaginas((table.Rows.Count) / 25)
                Dim cliente = _oLogicaCliente.ConsultarPorIdCredito(Convert.ToInt32(txtId_Credito.Text))
                Dim datos = LlenarDatosReporte()
                datos.ListaReportes = New List(Of ReportDocument)

                For i = 1 To paginas
                    tmpTable.Rows.Clear()
                    Dim reportePagina As New RptEstadoCuenta
                    reportePagina.SetDataSource(GuardarLineas((i * 25) - 25, table, tmpTable, 25))
                    reportePagina.SetParameterValue("numPagina", i)
                    LlenarEncabezadoReporte(reportePagina, cliente, paginas, total)
                    If i = paginas Then
                        reportePagina.SetParameterValue("total", _oUtilidades.PasarMoneda(total))
                    Else
                        reportePagina.SetParameterValue("total", 0)
                    End If
                    datos.ListaReportes.Add(reportePagina)
                Next

                tmpTable.Rows.Clear()
                Dim reporte As New RptEstadoCuenta
                reporte.SetDataSource(GuardarLineas(0, table, tmpTable, table.Rows.Count))
                LlenarEncabezadoReporte(reporte, cliente, paginas, total)
                reporte.SetParameterValue("total", _oUtilidades.PasarMoneda(total))
                reporte.SetParameterValue("numPagina", 0)
                FrmReportes.DatosReporte = datos
                FrmReportes.crvReporte.ReportSource = reporte
                FrmReportes.ShowDialog()
            Else
                MsgBox("Debe de seleccionar el cliente de crédito")
            End If
        End Sub

        Private Function GetFacturaCredito(ByVal oListFacturas As List(Of FacturaCredito), ByVal numFactura As Integer) As FacturaCredito
            For Each item As FacturaCredito In oListFacturas
                If (item.NumFactura = numFactura) Then
                    Return item
                End If
            Next
            Return Nothing
        End Function

        Private Function GetNCG(ByVal oListaNCGenerales As List(Of NotaCreditoGeneral), ByVal numNCG As Integer) As NotaCreditoGeneral
            For Each item As NotaCreditoGeneral In oListaNCGenerales
                If (item.IdNC = numNCG) Then
                    Return item
                End If
            Next
            Return Nothing
        End Function

        Private Function GetNDG(ByVal oListaNDGenerales As List(Of NotaDebitoGeneral), ByVal numNDG As Integer) As NotaDebitoGeneral
            For Each item As NotaDebitoGeneral In oListaNDGenerales
                If (item.IdND = numNDG) Then
                    Return item
                End If
            Next
            Return Nothing
        End Function

        Private Function CargarFacturaCredito(ByVal factura As FacturaCredito, ByVal total As Double, ByRef table As DataTable) As Double
            Dim dias = DateDiff("d", factura.Fecha, Now)
            Dim diasAtraso As Integer

            Dim fechaFactura As Date = factura.Fecha
            diasAtraso = dias - factura.NumDias
            Dim negrita = String.Empty
            If diasAtraso > 0 Then
                negrita = "*"
            End If

            total = total + factura.Monto
            AgregarFila(table, "FACT", factura.NumFactura, fechaFactura,
                        DateAdd(DateInterval.Day, factura.NumDias, fechaFactura),
                        factura.NumDias, diasAtraso, factura.Monto, total, negrita)


            For j = 0 To factura.Abonos.Count - 1
                total = total - factura.Abonos(j).Monto
                AgregarFila(table, "AB", factura.Abonos(j).IdAbono, factura.Abonos(j).Fecha,
                            "-", "-", "-", -factura.Abonos(j).Monto, total, negrita)
            Next

            For j = 0 To factura.NotasCredito.Count - 1
                total = total - factura.NotasCredito(j).Monto
                AgregarFila(table, "NC", factura.NotasCredito(j).IdNC, factura.NotasCredito(j).Fecha,
                            "-", "-", "-", -factura.NotasCredito(j).Monto, total, negrita)
            Next

            Return total
        End Function

        Private Function CargarNCG(ByVal ncg As NotaCreditoGeneral, ByVal total As Double, ByRef table As DataTable) As Double
            total = total - ncg.Monto
            AgregarFila(table, "NCG", ncg.IdNC, ncg.Fecha, "-", "-",
                         "-", -ncg.Monto, total, String.Empty)

            Return total
        End Function

        Private Function CargarNDG(ByVal ndg As NotaDebitoGeneral, ByVal total As Double, ByRef table As DataTable) As Double
            total = total + ndg.Monto
            AgregarFila(table, "NDG", ndg.IdND, ndg.Fecha, "-", "-",
                        "-", ndg.Monto, total, String.Empty)

            Return total
        End Function

        Public Function LlenarDatosReporte() As DatosReporte
            Dim datos = New DatosReporte
            With datos
                .MsgBoxMensaje = "Esta seguro que desea imprimir el estado de cuenta"
                .MsgBoxTilulo = "Imprimir estado de cuenta..."
                .NombreReporte = String.Format("Estado de cuenta al {0}.pdf", DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss"))
                .Id = Convert.ToInt32(txtId_Credito.Text)
                .NombrePC = _oLogicaVarios.ConsultarColumna("PC_Medio_Oficio")
                .NombreImpresora = _oLogicaVarios.ConsultarColumna("Imp_Medio_Oficio")
            End With
            Return datos
        End Function

        Public Function LlenarEncabezadoReporte(ByVal reporte As RptEstadoCuenta, ByVal cliente As ClienteCredito, ByVal paginas As Integer, ByVal total As Double)
            reporte.SetParameterValue("nombre", String.Format("{0} {1} {2}", cliente.Nombre, cliente.PrimerApellido, cliente.SegundoApellido))
            reporte.SetParameterValue("cuenta", cliente.IdCredito)
            reporte.SetParameterValue("direccion", cliente.OtraInformacion.Direccion)
            Dim telefonos = String.Format("{0}, {1}", cliente.OtraInformacion.TelefonoPrincipal, cliente.OtraInformacion.OtroTelefono)
            reporte.SetParameterValue("telefonos", telefonos)
            reporte.SetParameterValue("fax", cliente.OtraInformacion.FaxPrincipal)
            reporte.SetParameterValue("paginas", paginas)
            Return reporte
        End Function

        Private Sub AgregarFila(ByRef table As DataTable, ByVal tipo As String, ByVal doc As Integer,
                                ByVal fecha As Date, ByVal fechaVence As String, ByVal dias As String,
                                ByVal atraso As String, ByVal monto As Double, ByVal saldoAcumulado As Double, ByVal negrita As String)
            Dim fila As DataRow
            fila = table.NewRow
            fila.Item("Tipo") = tipo
            fila.Item("Doc") = doc
            fila.Item("Fecha") = fecha
            fila.Item("Fecha_Vence") = fechaVence
            fila.Item("Dias") = dias
            fila.Item("Atraso") = atraso
            fila.Item("Monto") = _oUtilidades.PasarMoneda(monto)
            fila.Item("SaldoAcumulado") = _oUtilidades.PasarMoneda(saldoAcumulado)
            fila.Item("Negrita") = negrita
            table.Rows.Add(fila)
        End Sub

        Private Function GuardarLineas(ByVal inicio As Integer, ByVal table As DataTable, ByVal tmpTable As DataTable, ByVal lineas As Int32) As DataTable
            Dim indice As Integer, final As Integer
            Dim fila As DataRow

            With table
                If inicio + lineas < .Rows.Count Then
                    final = inicio + lineas
                Else
                    final = .Rows.Count
                End If

                For indice = inicio To final - 1
                    fila = tmpTable.NewRow
                    fila.Item("Tipo") = table.Rows(indice).Item(0)
                    fila.Item("Doc") = table.Rows(indice).Item(1)
                    fila.Item("Fecha") = table.Rows(indice).Item(2)
                    fila.Item("Fecha_Vence") = table.Rows(indice).Item(3)
                    fila.Item("Dias") = table.Rows(indice).Item(4)
                    fila.Item("Atraso") = table.Rows(indice).Item(5)
                    fila.Item("Monto") = table.Rows(indice).Item(6)
                    fila.Item("SaldoAcumulado") = table.Rows(indice).Item(7)
                    fila.Item("Negrita") = table.Rows(indice).Item(8)
                    tmpTable.Rows.Add(fila)
                Next indice
            End With

            Return tmpTable
        End Function

        Private Sub notaCredito_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles notaCredito.Click
            If txtId_Credito.Text <> "" And txtNombre.Text <> "" Then
                FrmNotaCreditoGeneral.txtNombreCliente.Text = txtNombre.Text
                FrmNotaCreditoGeneral.txtId_Credito.Text = txtId_Credito.Text
                FrmNotaCreditoGeneral.ShowDialog()
            Else
                MsgBox("Debe de seleccionar un cliente antes de hacer la nota de crédito", MsgBoxStyle.Exclamation)
            End If
        End Sub

        Private Sub btnClientes_Credito_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnClientes_Credito.Click
            FrmConsultaCreditos.ShowDialog()
        End Sub

        Private Sub txtNombre_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtNombre.Click
            LimpiarTodo()
            txtId_Credito.Text = String.Empty
            txtNombre.Focus()
        End Sub

        Private Sub btnNota_Debito_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNota_Debito.Click
            If txtId_Credito.Text <> "" And txtNombre.Text <> "" Then
                FrmNotaDebitoGeneral.txtNombreCliente.Text = txtNombre.Text
                FrmNotaDebitoGeneral.txtId_Credito.Text = txtId_Credito.Text
                FrmNotaDebitoGeneral.ShowDialog()
            Else
                MsgBox("Debe de seleccionar un cliente antes de hacer la nota de débito", MsgBoxStyle.Exclamation)
            End If
        End Sub

        Private Sub btnDatosCliente_Click(sender As Object, e As EventArgs) Handles btnDatosCliente.Click
            If IsNumeric(txtId_Credito.Text) And txtNombre.Text <> "" Then
                Dim cliente = _oLogicaCliente.ConsultarPorIdCredito(txtId_Credito.Text)
                FrmClienteCredito.txtId_Cliente.Text = cliente.IdPersona
                FrmClienteCredito.LlenarDatos()
                FrmClienteCredito.ShowDialog()
            End If
        End Sub

        Private Sub txtNombre_MouseCaptureChanged(sender As Object, e As EventArgs) Handles txtNombre.MouseCaptureChanged
            LimpiarTodo()
            txtId_Credito.Text = String.Empty
            txtNombre.Focus()
        End Sub
    End Class
End Namespace