Imports Entidades
Imports Logica_Negocios

Namespace Interfaz.Proveedores
    Public Class FrmCancelacionDeFacturasPorProveedor

        Private ReadOnly _oUtilidades As New Utilidades
        Private _lineas As Integer = 0
        Private _oListaFacturas As New List(Of Long)
        Private _oListaLineasRecibo As New List(Of LineaReciboDocPorPagar)
        Public Tipo As Integer = 1 '1 Escoje, 2 Automatico,3 Abono
        Private ReadOnly _oLogicaProveedor As New LogicaProveedor
        Private ReadOnly _oLogicaDocPorPagar As New LogicaDocPorPagar
        Public OAbono As New AbonoFacturaProveedor
        Private ReadOnly _oLogicaReciboDocPagar As New LogicaReciboDocPorPagar
        Private ReadOnly _oLogicaAbonoDocPorPagar As New LogicaAbonoDocPorPagar
        Public OReciboDocPorPagar As New ReciboDocPorPagar
        Private ReadOnly _oListaNcg As New List(Of Integer)
        Private ReadOnly _oLogicaVarios As New LogicaVarios

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

        Private _varFechaCancelacion As Date
        Public Property FechaCancelacion() As Date
            Get
                Return _varFechaCancelacion
            End Get
            Set(ByVal value As Date)
                _varFechaCancelacion = value
            End Set
        End Property

        Private Sub FrmFacturasPorProveedor_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            EstadoFlujoCaja = False
            AddHandler txtMontoAbono.KeyPress, AddressOf ValidarNumerosPunto
        End Sub

        Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnLimpiar.Click
            LimpiarTodo()
            txtId_Proveedor.Text = String.Empty
        End Sub

        Public Sub LimpiarTodo()
            txtNombre.Text = String.Empty
            txtNumNC.Text = String.Empty
            txtNumND.Text = String.Empty
            txtTotalCreditos.Text = String.Empty
            dgvFacturas.Rows.Clear()
            dgvTrans1.Rows.Clear()
            dgvTrans2.Rows.Clear()
            dgvTrans3.Rows.Clear()
            dgvProveedores.Visible = False
            _lineas = 0
            lblMostrarAbono.Text = 0.0
            lblMostrarAnterior.Text = 0.0
            lblActual.Text = 0.0
            _oListaFacturas = New List(Of Long)
            txtMontoNC.Text = String.Empty
            txtMontoND.Text = String.Empty
            _oListaLineasRecibo = New List(Of LineaReciboDocPorPagar)
            Tipo = 1
            txtMontoAbono.Text = String.Empty
            txtTotalAtrasado.Text = String.Empty
            txtMontoAB.Text = String.Empty
            txtNumAbonos.Text = String.Empty
            btnAbonar.Enabled = False
            txtVuelto.Text = String.Empty
            btnCargarRecibo.Enabled = False
            EstadoFlujoCaja = False
            btnBajarTodo.Enabled = True
            OAbono = New AbonoFacturaProveedor
            btnDatosProveedor.Enabled = False
            btnBajarTodo.Enabled = False
            btnFacturas.Enabled = False
            txtId_Proveedor.Focus()
        End Sub

        Public Sub LlenarProveedor(ByVal oProveedor As Proveedor)
            If oProveedor.IdProveedor <> 0 Then
                LimpiarTodo()
                txtNombre.Text = oProveedor.Nombre
                dgvProveedores.Visible = False
                btnDatosProveedor.Enabled = True
                btnFacturas.Enabled = True
                CargarDatos(oProveedor)
            Else
                LimpiarTodo()
            End If
        End Sub

        Private Sub dgvProveedores_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles dgvProveedores.KeyDown
            If e.KeyValue = 13 Then
                LlenarProveedor(_oLogicaProveedor.Consultar(dgvProveedores.Item(0, dgvProveedores.CurrentRow.Index).Value))
                txtId_Proveedor.Text = dgvProveedores.Item(0, dgvProveedores.CurrentRow.Index).Value
            End If
        End Sub

        Private Sub dgvProveedores_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvProveedores.Click
            LlenarProveedor(_oLogicaProveedor.Consultar(dgvProveedores.Item(0, dgvProveedores.CurrentRow.Index).Value))
            txtId_Proveedor.Text = dgvProveedores.Item(0, dgvProveedores.CurrentRow.Index).Value
        End Sub

        Public Sub CargarDatos(ByVal oProveedor As Proveedor)

            Dim oListaDocPorPagar
            Dim totalAtrasados As Double
            Dim totalCreditos As Double
            Dim numNotasCredito As Integer
            Dim numNotasDebito As Integer
            Dim numAbonos As Integer
            Dim notasDebito As Double
            Dim notasCredito As Double
            Dim abonos As Double
            Dim montoNeto As Double
            Dim montoNotasCredito As Double
            Dim montoNotasDebito As Double
            Dim montoTotalAbonos As Double

            oListaDocPorPagar = _oLogicaDocPorPagar.consultarFacturasPorId_Proveedor(oProveedor.IdProveedor)

            With oListaDocPorPagar
                For i As Integer = 0 To oListaDocPorPagar.Count - 1

                    Dim dias = DateDiff("d", oListaDocPorPagar(i).Fecha, Now)
                    Dim diasAtraso As Integer

                    Dim fechaFactura As Date = oListaDocPorPagar(i).Fecha
                    totalCreditos = totalCreditos + oListaDocPorPagar(i).Total

                    numNotasCredito += oListaDocPorPagar(i).ListaNC.Count
                    numNotasDebito += oListaDocPorPagar(i).ListaND.Count
                    numAbonos += oListaDocPorPagar(i).ListaAbonos.Count

                    notasCredito = 0
                    For j = 0 To oListaDocPorPagar(i).ListaNC.Count - 1
                        notasCredito += oListaDocPorPagar(i).ListaNC(j).Total
                    Next

                    notasDebito = 0
                    For j = 0 To oListaDocPorPagar(i).ListaND.Count - 1
                        notasDebito += oListaDocPorPagar(i).ListaND(j).Total
                    Next

                    abonos = 0
                    For j = 0 To oListaDocPorPagar(i).ListaAbonos.Count - 1
                        abonos += oListaDocPorPagar(i).ListaAbonos(j).Monto
                    Next

                    montoNeto = oListaDocPorPagar(i).Total - notasCredito + notasDebito - abonos

                    diasAtraso = dias - oListaDocPorPagar(i).Dias

                    montoNotasDebito += notasDebito
                    montoNotasCredito += notasCredito
                    montoTotalAbonos += abonos
                    dgvFacturas.Rows.Add(oListaDocPorPagar(i).IdDocPagar, "FACT", oListaDocPorPagar(i).NumFactura, fechaFactura.ToString("dd/MM/yyyy"), _oUtilidades.PasarMoneda(oListaDocPorPagar(i).Total), _oUtilidades.PasarMoneda(montoNeto), oListaDocPorPagar(i).Dias, diasAtraso, oListaDocPorPagar(i).ListaND.Count, oListaDocPorPagar(i).ListaNC.Count, oListaDocPorPagar(i).ListaAbonos.Count)

                    If diasAtraso > 0 Then
                        totalAtrasados = totalAtrasados + montoNeto
                    End If
                Next

                Dim oNcGenerales As List(Of NCProveedorGeneral) = _oLogicaProveedor.ConsultarGenerales(oProveedor.IdProveedor)
                Dim totalNcGenerales As Double = 0
                For i = 0 To oNcGenerales.Count - 1

                    Dim dias = DateDiff("d", oNcGenerales(i).Fecha, Now)
                    Dim diasAtraso = 0

                    Dim fechaFactura = ""
                    If oNcGenerales(i).Fecha <> Nothing Then
                        fechaFactura = oNcGenerales(i).Fecha
                        diasAtraso = dias - 30
                    End If

                    totalNcGenerales = totalNcGenerales + oNcGenerales(i).Total
                    dgvFacturas.Rows.Add(oNcGenerales(i).IdNcg, "NCG", oNcGenerales(i).NumNC, fechaFactura, _oUtilidades.PasarMoneda(oNcGenerales(i).Total), _oUtilidades.PasarMoneda(oNcGenerales(i).Total), 30, diasAtraso, "-", "-", "-")
                Next

                If dgvFacturas.Rows.Count > 0 Then
                    dgvFacturas.Rows(0).Selected = False
                    btnBajarTodo.Enabled = True
                    btnBajarVencido.Enabled = True
                End If

                txtTotalCreditos.Text = _oUtilidades.PasarMoneda(totalCreditos + montoNotasDebito - montoNotasCredito - montoTotalAbonos - totalNcGenerales)
                txtNumND.Text = numNotasDebito
                txtNumNC.Text = numNotasCredito + oNcGenerales.Count
                txtNumAbonos.Text = numAbonos
                txtTotalAtrasado.Text = _oUtilidades.PasarMoneda(totalAtrasados - totalNcGenerales)
                lblMostrarAnterior.Text = _oUtilidades.PasarMoneda(txtTotalCreditos.Text)
                lblActual.Text = _oUtilidades.PasarMoneda(txtTotalCreditos.Text)
                txtMontoNC.Text = _oUtilidades.PasarMoneda(montoNotasCredito + totalNcGenerales)
                txtMontoND.Text = _oUtilidades.PasarMoneda(montoNotasDebito)
                txtMontoAB.Text = _oUtilidades.PasarMoneda(montoTotalAbonos)


            End With

            If dgvFacturas.Rows.Count > 0 Then dgvFacturas.Rows(0).Selected = False
        End Sub

        Private Sub dgvFacturas_Leave(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvFacturas.Leave
            If dgvFacturas.Rows.Count > 0 Then
                If dgvFacturas.CurrentRow.Index >= 0 Then dgvFacturas.Rows(dgvFacturas.CurrentRow.Index).Selected = False
            End If
        End Sub

        Private Sub dgvFacturas_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvFacturas.Click
            With dgvFacturas
                If .Rows.Count > 0 Then
                    Dim fila As Integer = .CurrentCell.RowIndex
                    If .Rows.Count > 0 And Tipo = 1 Then
                        If fila >= 0 Then
                            BajarLinea()
                        End If
                    End If
                End If
            End With
        End Sub

        Private Sub BajarLinea()

            With dgvFacturas

                Dim fila As Integer = .CurrentCell.RowIndex
                Dim idDocPorPagar As Integer = .Item(0, fila).Value
                Dim tipoDoc As String = .Item(1, fila).Value
                Dim numDoc As String = .Item(2, fila).Value

                Dim fechaDoc = ""
                If .Item(3, fila).Value <> "" Then
                    fechaDoc = .Item(3, fila).Value
                End If

                Dim montoDoc As Double = .Item(4, fila).Value
                Dim montoNeto As Double = .Item(5, fila).Value

                If _lineas < 42 Then
                    Dim lineaRecibo As LineaReciboDocPorPagar
                    If tipoDoc = "FACT" Then

                        Dim oListaNotasCredito = _oLogicaDocPorPagar.consultarNC_IDDocPagar(idDocPorPagar)
                        Dim oListaNotasDebito = _oLogicaDocPorPagar.consultarND_IDDocPagar(idDocPorPagar)
                        Dim oListaAbonos = _oLogicaAbonoDocPorPagar.consultarAbono_IDDocPagar(idDocPorPagar)
                        Dim cantLineas = oListaNotasDebito.Count - 1 + oListaNotasCredito.Count - 1 + oListaAbonos.Count - 1

                        If cantLineas + _lineas < 42 Then
                            lineaRecibo = CrearLineaRecibo(idDocPorPagar, "CA", numDoc, fechaDoc, montoDoc)
                            agregarLinea_Recibo(lineaRecibo)

                            lblMostrarAbono.Text = _oUtilidades.PasarMoneda(CDbl(lblMostrarAbono.Text) + montoNeto)
                            _oListaFacturas.Add(idDocPorPagar)
                            lblActual.Text = _oUtilidades.PasarMoneda(CDbl(lblActual.Text) - montoNeto)
                            .Rows.RemoveAt(fila)

                            AgregarNotasCredito(oListaNotasCredito)
                            AgregarNotasDebito(oListaNotasDebito)
                            AgregarAbonos(oListaAbonos)
                        Else
                            MsgBox("Está factura contiene muchos abonos y notas de crédito que no caben en el recibo, debe imprimir este y hacer otro")
                        End If
                    Else
                        lineaRecibo = CrearLineaRecibo(.CurrentRow.Cells(0).Value, "NCG", numDoc, fechaDoc, montoDoc)
                        agregarLinea_Recibo(lineaRecibo)

                        _oListaNcg.Add(.CurrentRow.Cells(0).Value)

                        lblMostrarAbono.Text = _oUtilidades.PasarMoneda(CDbl(lblMostrarAbono.Text) - .CurrentRow.Cells(4).Value)
                        lblActual.Text = _oUtilidades.PasarMoneda(CDbl(lblActual.Text) + .Item(4, .CurrentRow.Index).Value)
                        .Rows.RemoveAt(.CurrentRow.Index)
                    End If

                Else
                    MsgBox("El recibo está lleno, debe imprimir este y hacer otro")
                End If
            End With
        End Sub

        Public Function CrearLineaRecibo(ByVal idDocPorPagar As String, ByVal tipoDoc As String, ByVal numDoc As String, ByVal fechaDoc As String, ByVal montoDoc As Double) As LineaReciboDocPorPagar
            Dim lineaRecibo As New LineaReciboDocPorPagar
            lineaRecibo.IdDoc = idDocPorPagar
            lineaRecibo.Tipo = tipoDoc
            lineaRecibo.Doc = numDoc
            lineaRecibo.Fecha = fechaDoc
            lineaRecibo.Monto = montoDoc

            Return lineaRecibo
        End Function

        Public Sub agregarLinea_Recibo(ByVal lineaRecibo As LineaReciboDocPorPagar)

            If _oListaLineasRecibo.Count < 7 Then
                dgvTrans1.Rows.Add(lineaRecibo.IdDoc, lineaRecibo.Tipo, lineaRecibo.Doc, lineaRecibo.Fecha, _oUtilidades.PasarMoneda(lineaRecibo.Monto))
            ElseIf _lineas < 14 Then
                dgvTrans2.Rows.Add(lineaRecibo.IdDoc, lineaRecibo.Tipo, lineaRecibo.Doc, lineaRecibo.Fecha, _oUtilidades.PasarMoneda(lineaRecibo.Monto))
            Else
                dgvTrans3.Rows.Add(lineaRecibo.IdDoc, lineaRecibo.Tipo, lineaRecibo.Doc, lineaRecibo.Fecha, _oUtilidades.PasarMoneda(lineaRecibo.Monto))
            End If

            _lineas = _lineas + 1
            _oListaLineasRecibo.Add(lineaRecibo)

        End Sub

        Private Sub dgvTrans1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvTrans1.Click
            SubirLinea(dgvTrans1)
        End Sub

        Private Sub SubirLinea(ByVal dgvSubir As DataGridView)

            Dim numDgv As Integer

            If dgvSubir.Equals(dgvTrans1) Then
                numDgv = 1
            ElseIf dgvSubir.Equals(dgvTrans2) Then
                numDgv = 2
            Else
                numDgv = 3
            End If

            With dgvSubir
                If .Rows.Count > 0 And Tipo = 1 Then
                    If .CurrentCell.RowIndex >= 0 And .Rows(.CurrentRow.Index).Cells(1).Value <> "ND" And .Rows(.CurrentRow.Index).Cells(1).Value <> "NC" And .Rows(.CurrentRow.Index).Cells(1).Value <> "AB" Then
                        ActualizarDatosResta(.Item(0, .CurrentRow.Index).Value, .Item(1, .CurrentRow.Index).Value, numDgv)
                        Dim lineaRecibo As LineaRecibo
                        lineaRecibo = CrearLineaRecibo(.Item(0, .CurrentRow.Index).Value, .Item(1, .CurrentRow.Index).Value, .Item(2, .CurrentRow.Index).Value, .Item(3, .CurrentRow.Index).Value, .Item(4, .CurrentRow.Index).Value)
                        eliminarLinea_Recibo(lineaRecibo)
                        .Rows.RemoveAt(.CurrentRow.Index)

                        If .RowCount > 0 Then

                            Dim i As Integer = .CurrentRow.Index

                            While (.Rows(i).Cells(1).Value = "ND" Or .Rows(i).Cells(1).Value = "NC" Or .Rows(i).Cells(1).Value = "AB")
                                lineaRecibo = CrearLineaRecibo(.Item(0, i).Value, .Item(1, i).Value, .Item(2, i).Value, .Item(3, i).Value, .Item(4, i).Value)
                                eliminarLinea_Recibo(lineaRecibo)
                                .Rows.RemoveAt(i)

                                If numDgv = 1 Then
                                    moverFacturasHacia_dgvTrans1()
                                ElseIf numDgv = 2 Then
                                    moverFacturasHacia_dgvTrans2()
                                End If

                                If .Rows.Count = 0 Or .Rows.Count <= i Then
                                    Exit While
                                End If
                            End While


                            If numDgv = 1 Then
                                moverFacturasHacia_dgvTrans1()
                            ElseIf numDgv = 2 Then
                                moverFacturasHacia_dgvTrans2()
                            End If

                        End If

                    End If
                End If

                _lineas = dgvSubir.RowCount + dgvTrans2.RowCount + dgvTrans3.RowCount
            End With

            dgvFacturas.Sort(dgvFacturas.Columns(7), System.ComponentModel.ListSortDirection.Descending)
        End Sub

        Private Sub moverFacturasHacia_dgvTrans1()
            If dgvTrans2.Rows.Count > 0 Then
                dgvTrans1.Rows.Add(dgvTrans2.Rows(0).Cells(0).Value, dgvTrans2.Rows(0).Cells(1).Value, dgvTrans2.Rows(0).Cells(2).Value, dgvTrans2.Rows(0).Cells(3).Value, dgvTrans2.Rows(0).Cells(4).Value)
                dgvTrans2.Rows.RemoveAt(0)

                If dgvTrans3.Rows.Count > 0 Then
                    dgvTrans2.Rows.Add(dgvTrans3.Rows(0).Cells(0).Value, dgvTrans3.Rows(0).Cells(1).Value, dgvTrans3.Rows(0).Cells(2).Value, dgvTrans3.Rows(0).Cells(3).Value, dgvTrans3.Rows(0).Cells(4).Value)
                    dgvTrans3.Rows.RemoveAt(0)
                End If
            End If
        End Sub

        Private Sub moverFacturasHacia_dgvTrans2()
            If dgvTrans2.Rows.Count > 0 Then
                If dgvTrans3.Rows.Count > 0 Then
                    dgvTrans2.Rows.Add(dgvTrans3.Rows(0).Cells(0).Value, dgvTrans3.Rows(0).Cells(1).Value, dgvTrans3.Rows(0).Cells(2).Value, dgvTrans3.Rows(0).Cells(3).Value, dgvTrans3.Rows(0).Cells(4).Value)
                    dgvTrans3.Rows.RemoveAt(0)
                End If
            End If
        End Sub

        Private Sub eliminarLinea_Recibo(ByVal lineaRecibo As LineaReciboDocPorPagar)
            For i = 0 To _oListaLineasRecibo.Count - 1
                If _oListaLineasRecibo(i).Tipo = lineaRecibo.Tipo And _oListaLineasRecibo(i).IdDoc = lineaRecibo.IdDoc Then
                    _oListaLineasRecibo.RemoveAt(i)
                    Exit For
                End If
            Next
        End Sub

        Private Sub ActualizarDatosResta(ByVal numDoc As Long, ByVal tipoDoc As String, ByVal numDvg As Integer)
            Dim oDocPorPagar As New FacturaProveedor

            If tipoDoc = "FACT" Or tipoDoc = "CA" Then
                For i = 0 To _oListaFacturas.Count - 1

                    If _oListaFacturas(i) = numDoc Then
                        oDocPorPagar = _oLogicaDocPorPagar.ConsultarPorIdDocPagar(_oListaFacturas(i))
                        _oListaFacturas.RemoveAt(i)
                        Exit For
                    End If
                Next

                Dim dias = DateDiff("d", oDocPorPagar.Fecha, Now)
                Dim diasAtraso As Integer

                Dim fechaDoc As Date = oDocPorPagar.Fecha
                Dim montoNeto As Double

                Dim notasCredito As Double = 0

                For j = 0 To oDocPorPagar.ListaNC.Count - 1
                    notasCredito += oDocPorPagar.ListaNC(j).Total
                Next

                Dim notasDebito As Double = 0

                For j = 0 To oDocPorPagar.ListaND.Count - 1
                    notasDebito += oDocPorPagar.ListaND(j).Total
                Next

                Dim abonos As Double = 0

                For j = 0 To oDocPorPagar.ListaAbonos.Count - 1
                    abonos += oDocPorPagar.ListaAbonos(j).Monto
                Next

                montoNeto = oDocPorPagar.Total - notasCredito + notasDebito - abonos

                diasAtraso = dias - oDocPorPagar.Dias

                lblMostrarAbono.Text = _oUtilidades.PasarMoneda(CDbl(lblMostrarAbono.Text) - montoNeto)
                lblActual.Text = _oUtilidades.PasarMoneda(CDbl(lblActual.Text) + montoNeto)

                dgvFacturas.Rows.Add(oDocPorPagar.IdDocPagar, "FACT", oDocPorPagar.NumFactura, fechaDoc.ToString("dd/MM/yyyy"), _oUtilidades.PasarMoneda(oDocPorPagar.Total), _oUtilidades.PasarMoneda(montoNeto), oDocPorPagar.Dias, diasAtraso, oDocPorPagar.ListaND.Count, oDocPorPagar.ListaNC.Count, oDocPorPagar.ListaAbonos.Count)
            ElseIf tipoDoc = "NCG" Then
                Select Case numDvg
                    Case 1
                        Subir(dgvTrans1)
                    Case 2
                        Subir(dgvTrans2)
                    Case 3
                        Subir(dgvTrans3)
                End Select
            End If

        End Sub

        Private Sub Subir(ByVal dgv As DataGridView)
            With dgv
                Dim dias As Long
                Dim diasAtraso As Integer = 0

                Dim fechaDoc = ""
                If .Item(3, .CurrentRow.Index).Value <> "" Then
                    dias = DateDiff("d", .Item(3, .CurrentRow.Index).Value, Now)
                    fechaDoc = .Item(3, .CurrentRow.Index).Value
                    diasAtraso = dias - 30
                End If

                dgvFacturas.Rows.Add(.Item(0, .CurrentRow.Index).Value, "NCG", .Item(2, .CurrentRow.Index).Value, fechaDoc, .Item(4, .CurrentRow.Index).Value, .Item(4, .CurrentRow.Index).Value, 30, diasAtraso, "-", "-", "-")
                lblMostrarAbono.Text = _oUtilidades.PasarMoneda(CDbl(lblMostrarAbono.Text) + .Item(4, .CurrentRow.Index).Value)
                lblActual.Text = _oUtilidades.PasarMoneda(CDbl(lblActual.Text) - .Item(4, .CurrentRow.Index).Value)
                _oListaNcg.Remove(.Item(0, .CurrentRow.Index).Value)
            End With
        End Sub
        Private Sub dgvTrans2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvTrans2.Click
            SubirLinea(dgvTrans2)
        End Sub

        Private Sub dgvTrans3_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvTrans3.Click
            SubirLinea(dgvTrans3)
        End Sub

        Private Sub btnBajarTodo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBajarTodo.Click
            With dgvFacturas
                If dgvFacturas.Rows.Count > 0 Then
                    _lineas = 0

                    For i = 0 To .Rows.Count - 1
                        BajarLinea()
                    Next

                    lblActual.Text = _oUtilidades.PasarMoneda(CDbl(lblMostrarAnterior.Text) - CDbl(lblMostrarAbono.Text))

                    If .Rows.Count > 0 Then .Rows(0).Selected = False

                    btnBajarTodo.Enabled = False
                    lblMostrarAnterior.Text = _oUtilidades.PasarMoneda(txtTotalCreditos.Text)
                    lblMostrarAbono.Text = _oUtilidades.PasarMoneda(lblMostrarAbono.Text)
                    lblActual.Text = _oUtilidades.PasarMoneda(txtTotalCreditos.Text - lblMostrarAbono.Text)

                End If
            End With
        End Sub

        Private Sub AgregarNotasCredito(ByVal oListaNc As List(Of NCFacturaProveedor))

            Dim lineaRecibo As LineaReciboDocPorPagar

            For i = 0 To oListaNc.Count - 1
                Dim fechaDoc As String = ""
                If oListaNc(i).Fecha <> Nothing Then
                    fechaDoc = oListaNc(i).Fecha
                End If

                lineaRecibo = CrearLineaRecibo(oListaNc(i).IdNC, "NC", oListaNc(i).NumNC, fechaDoc, oListaNc(i).Total)
                agregarLinea_Recibo(lineaRecibo)
            Next
        End Sub

        Private Sub AgregarNotasDebito(ByVal oListaNd As List(Of NDFacturaProveedor))

            Dim lineaRecibo As LineaReciboDocPorPagar

            For i = 0 To oListaNd.Count - 1

                Dim fechaDoc As String = ""
                If oListaNd(i).Fecha <> Nothing Then
                    fechaDoc = oListaNd(i).Fecha
                End If

                lineaRecibo = CrearLineaRecibo(oListaNd(i).IdND, "ND", oListaNd(i).NumND, fechaDoc, oListaNd(i).Total)
                agregarLinea_Recibo(lineaRecibo)
            Next
        End Sub

        Private Sub AbonarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles AbonarToolStripMenuItem.Click
            If OAbono.Monto <= 0 Then
                If dgvFacturas.Rows.Count > 0 Then
                    With FrmAbonoDocPorPagar
                        If dgvTrans1.Rows.Count <= 0 Then
                            .Pantalla = 1
                        Else
                            .Pantalla = 2
                        End If
                        .txtNumFactura.Text = dgvFacturas.CurrentRow.Cells(2).Value
                        .txtMonto.Text = dgvFacturas.CurrentRow.Cells(4).Value
                        .txtMontoNeto.Text = dgvFacturas.CurrentRow.Cells(5).Value
                        .txtNumND.Text = dgvFacturas.CurrentRow.Cells(8).Value
                        .txtNumNC.Text = dgvFacturas.CurrentRow.Cells(9).Value
                        .txtNumAb.Text = dgvFacturas.CurrentRow.Cells(10).Value
                        .txtId_DocPorPagar.Text = dgvFacturas.CurrentRow.Cells(0).Value

                        Dim oDocPorPagar As FacturaProveedor
                        oDocPorPagar = _oLogicaDocPorPagar.ConsultarPorIdDocPagar(dgvFacturas.CurrentRow.Cells(0).Value)

                        Dim totalNc As Double
                        For i = 0 To oDocPorPagar.ListaNC.Count - 1
                            totalNc += oDocPorPagar.ListaNC(i).Total
                        Next

                        Dim totalNd As Double
                        For i = 0 To oDocPorPagar.ListaND.Count - 1
                            totalNd += oDocPorPagar.ListaND(i).Total
                        Next

                        Dim totalAbonos As Double
                        For i = 0 To oDocPorPagar.ListaAbonos.Count - 1
                            totalAbonos += oDocPorPagar.ListaAbonos(i).Monto
                        Next

                        .txtMontoAB.Text = _oUtilidades.PasarMoneda(totalAbonos)
                        .txtMontoNC.Text = _oUtilidades.PasarMoneda(totalNc)
                        .txtMontoND.Text = _oUtilidades.PasarMoneda(totalNd)

                        .ShowDialog()
                    End With
                End If
            Else
                MsgBox("No se puede realizar mas de un abono en el mismo recibo", MsgBoxStyle.Exclamation)
            End If

        End Sub

        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelar.Click

            If Trim(txtNombre.Text) = "" Then
                MessageBox.Show("Datos imcompletos, Debe agregar el nombre del proveedor", "Insertar nueva linea", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf dgvTrans1.RowCount = 0 Then
                MessageBox.Show("Datos imcompletos, Debe seleccionar al menos una factura", "Insertar nueva linea", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else

                If Tipo = 2 Or Tipo = 3 Then
                    FrmFormaPago.txtFechaCanc.Text = FechaCancelacion
                    If Tipo = 3 Then
                        FrmFormaPago.lblFechaCanc.Text = "Fecha Abono"
                    End If
                End If
                FrmFormaPago.ShowDialog()

                If EstadoFlujoCaja Then
                    Dim respuesta As String
                    respuesta = MsgBox("Esta seguro que desea realizar esta transacción?", vbCritical + vbYesNo, "Realizar Transacción...")

                    If respuesta = vbYes Then

                        Cursor.Current = Cursors.WaitCursor

                        OReciboDocPorPagar.IdProveedor = CInt(txtId_Proveedor.Text)
                        OReciboDocPorPagar.Anulado = 0
                        OReciboDocPorPagar.Monto = _oUtilidades.PasarMoneda(CDbl(lblMostrarAbono.Text))
                        OReciboDocPorPagar.Concepto = Tipo
                        OReciboDocPorPagar.SaldoActual = CDbl(lblActual.Text)
                        OReciboDocPorPagar.Fecha = Now

                        Dim idAbono As Integer
                        If Tipo = 1 Then
                            Cancelar(FechaCancelacion)
                        ElseIf Tipo = 2 Then
                            Cancelar(FechaCancelacion)
                            idAbono = Abonar(FechaCancelacion, OReciboDocPorPagar.NumReciboProveedor)
                            ActualizarIdAbono(idAbono)
                        ElseIf Tipo = 3 Then
                            idAbono = Abonar(FechaCancelacion, OReciboDocPorPagar.NumReciboProveedor)
                            ActualizarIdAbono(idAbono)
                        End If

                        OReciboDocPorPagar = LlenarRecibosDetalle(OReciboDocPorPagar)
                        _oLogicaReciboDocPagar.Insertar(OReciboDocPorPagar)

                        Cursor.Current = Cursors.Default

                        LimpiarTodo()
                        LlenarProveedor(_oLogicaProveedor.Consultar(CInt(txtId_Proveedor.Text)))
                    End If
                End If
            End If
        End Sub

        Private Sub ActualizarIdAbono(ByVal idAbono As Integer)
            For Each obj In _oListaLineasRecibo
                If obj.Tipo = "AB" And obj.Doc = "0" Then
                    obj.IdDoc = idAbono
                End If
            Next
        End Sub

        Private Function LlenarRecibosDetalle(ByVal oRecibo As ReciboDocPorPagar) As ReciboDocPorPagar
            With _oListaLineasRecibo
                For i As Integer = 0 To .Count - 1
                    If _oListaLineasRecibo(i).Tipo <> "" Then
                        Dim oReciboDetalle As New ReciboDocPorPagarDetalle
                        oReciboDetalle.Tipo = VerificarTipo(_oListaLineasRecibo(i).Tipo)
                        oReciboDetalle.IdDoc = _oListaLineasRecibo(i).IdDoc
                        oRecibo.ReciboDetalle.Add(oReciboDetalle)
                    End If
                Next
            End With

            Return oRecibo
        End Function

        Private Shared Function VerificarTipo(ByVal tipo As String) As Recibo.ListaConcepto

            If tipo = "Fact" Then
                Return ReciboDocPorPagarDetalle.ListaTipo.FactAbono
            ElseIf tipo = "AB" Then
                Return ReciboDocPorPagarDetalle.ListaTipo.Abono
            ElseIf tipo = "CA" Then
                Return ReciboDocPorPagarDetalle.ListaTipo.Cancelacion
            ElseIf tipo = "NC" Then
                Return ReciboDocPorPagarDetalle.ListaTipo.NotaCredito
            ElseIf tipo = "ND" Then
                Return ReciboDocPorPagarDetalle.ListaTipo.NotaDebito
            ElseIf tipo = "NCG" Then
                Return ReciboDocPorPagarDetalle.ListaTipo.NotaCreditoGeneral
            Else
                Return ReciboDocPorPagarDetalle.ListaTipo.NotaCreditoGeneral
            End If
        End Function

        Private Sub Cancelar(ByVal fechaCancela As Date)
            For i As Integer = 0 To _oListaFacturas.Count - 1
                _oLogicaDocPorPagar.cambiarAplicada_IdDocPorPagar(_oListaFacturas(i), fechaCancela)
            Next

            For i As Integer = 0 To _oListaNcg.Count - 1
                Dim ncGeneral As New NCProveedorGeneral
                ncGeneral.IdNcg = _oListaNcg(i)
                ncGeneral.Estado = 1
                _oLogicaProveedor.actualizarGeneralEstado_IdNC(ncGeneral)
            Next
        End Sub

        Private Function Abonar(ByVal fechaAbono As Date, ByVal numRecibo As String) As Integer

            Dim abono As New AbonoFacturaProveedor
            abono.IdFacturaProveedor = OAbono.IdFacturaProveedor
            abono.NumAbono = numRecibo
            abono.Fecha = fechaAbono
            abono.Monto = OAbono.Monto
            abono.Motivo = OReciboDocPorPagar.Observaciones
            abono.Estado = AbonoFacturaProveedor.ListaEstado.Pendiente

            Return _oLogicaAbonoDocPorPagar.Insertar(abono)
        End Function

        Private Sub AgregarAbonos(ByVal oListaAbonos As List(Of AbonoFacturaProveedor))

            Dim lineaRecibo As LineaReciboDocPorPagar

            For i = 0 To oListaAbonos.Count - 1

                Dim fechaAbono As String = ""
                If oListaAbonos(i).Fecha <> Nothing Then
                    fechaAbono = oListaAbonos(i).Fecha
                End If

                lineaRecibo = CrearLineaRecibo(oListaAbonos(i).IdAbono, "AB", oListaAbonos(i).IdAbono, fechaAbono, oListaAbonos(i).Monto)
                agregarLinea_Recibo(lineaRecibo)
            Next
        End Sub

        Private Sub EditarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles EditarToolStripMenuItem.Click
            If dgvFacturas.CurrentRow.Index >= 0 Then
                FrmDocPorPagar.txtIdDoc_PorPagar.Text = dgvFacturas.Item(0, dgvFacturas.CurrentRow.Index).Value
                FrmDocPorPagar.Pantalla = 1
                FrmDocPorPagar.BuscarDocFactura()
                FrmDocPorPagar.ShowDialog()
            End If
        End Sub

        Private Sub btnNC_General_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNC_General.Click
            If txtId_Proveedor.Text <> "" And txtNombre.Text <> "" Then
                FrmNcProveedorGeneral.lblMostrar_Id.Text = txtId_Proveedor.Text
                FrmNcProveedorGeneral.lblMostrarNombre.Text = txtNombre.Text
                FrmNcProveedorGeneral.ShowDialog()
            Else
                MsgBox("Debe de seleccionar un proveedor antes de hacer la nota de crédito", MsgBoxStyle.Exclamation)
            End If
        End Sub

        Private Sub FrmFacturasPorProveedor_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub

        Private Sub btnCargarRecibo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCargarRecibo.Click
            If IsNumeric(txtMontoAbono.Text) And txtMontoAbono.Text <> "0" Then
                With dgvFacturas
                    Dim total = CDbl(txtMontoAbono.Text)

                    If total <= CDbl(lblActual.Text) Then
                        _lineas = 0
                        Dim oListaFacturasTmp As New List(Of Long)

                        For i = 0 To .Rows.Count - 1
                            If .Item(1, i).Value = "FACT" Then
                                total = total - .Item(5, i).Value
                                If total >= 0 Then
                                    oListaFacturasTmp.Add(.Item(0, i).Value)
                                Else
                                    Exit For
                                End If
                            ElseIf .Item(1, i).Value = "NCG" Then
                                total = total + .Item(5, i).Value
                                If total >= 0 Then
                                    oListaFacturasTmp.Add(.Item(0, i).Value)
                                    _oListaNcg.Add(.Item(0, i).Value)
                                Else
                                    Exit For
                                End If
                            End If
                        Next

                        For i = 0 To oListaFacturasTmp.Count - 1

                            For j = .Rows.Count - 1 To 0 Step -1

                                If oListaFacturasTmp(i) = .Item(0, j).Value Then

                                    _lineas = 0
                                    BajarLinea()
                                    lblActual.Text = _oUtilidades.PasarMoneda(CDbl(lblMostrarAnterior.Text) - CDbl(lblMostrarAbono.Text))

                                    If .Rows.Count > 0 Then .Rows(0).Selected = False

                                    btnBajarTodo.Enabled = False
                                    lblMostrarAnterior.Text = _oUtilidades.PasarMoneda(txtTotalCreditos.Text)
                                    lblMostrarAbono.Text = _oUtilidades.PasarMoneda(lblMostrarAbono.Text)
                                    lblActual.Text = _oUtilidades.PasarMoneda(txtTotalCreditos.Text - lblMostrarAbono.Text)

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
                        btnBajarTodo.Enabled = False
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

        Private Sub txtMontoAbono_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtMontoAbono.KeyDown
            If IsNumeric(txtMontoAbono.Text) And Trim(txtId_Proveedor.Text) <> "" Then
                If CInt(txtMontoAbono.Text) > 0 And dgvTrans1.Rows.Count <= 0 Then
                    btnCargarRecibo.Enabled = True
                End If

                If e.KeyValue = 13 Then
                    btnCargarRecibo.Focus()
                End If
            End If
        End Sub

        Private Sub btnAbonar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAbonar.Click
            With dgvFacturas
                If .Rows.Count > 0 Then
                    If _lineas < 39 Then
                        Dim lineaRecibo As LineaRecibo
                        lineaRecibo = CrearLineaRecibo(.Rows(0).Cells(0).Value, "Fact", .Rows(0).Cells(2).Value, .Rows(0).Cells(3).Value, .Rows(0).Cells(4).Value)
                        agregarLinea_Recibo(lineaRecibo)

                        lineaRecibo = CrearLineaRecibo(.Rows(0).Cells(0).Value, "", "", "Anterior", _oUtilidades.PasarMoneda(.Rows(0).Cells(5).Value))
                        agregarLinea_Recibo(lineaRecibo)

                        lineaRecibo = CrearLineaRecibo(.Rows(0).Cells(0).Value, "AB", 0, Now.ToString("dd/MM/yyyy"), txtVuelto.Text)
                        agregarLinea_Recibo(lineaRecibo)

                        lineaRecibo = CrearLineaRecibo(.Rows(0).Cells(0).Value, "", "", "Actual", _oUtilidades.PasarMoneda(.Rows(0).Cells(5).Value - txtVuelto.Text))
                        agregarLinea_Recibo(lineaRecibo)

                        OAbono.IdFacturaProveedor = .Rows(0).Cells(0).Value
                        OAbono.Monto = CDbl(txtVuelto.Text)
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

        Private Sub btnEstado_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnEstado.Click

            If IsNumeric(txtId_Proveedor.Text) Then

                Dim respuesta As String
                respuesta = MsgBox("Esta seguro que desea imprimir el estado de cuenta", vbInformation + vbYesNo, "Imprimir estado de cuenta...")

                If respuesta = vbYes Then
                    Dim table As DataTable
                    Dim colum As DataColumn
                    Dim colum2 As DataColumn
                    Dim fila As DataRow
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
                    colum = New DataColumn("Monto", Type.GetType("System.Double"))
                    table.Columns.Add(colum)
                    colum2 = New DataColumn("Monto", Type.GetType("System.Double"))
                    tmpTable.Columns.Add(colum2)

                    Dim oListFacturas As List(Of FacturaProveedor)

                    oListFacturas = _oLogicaDocPorPagar.consultarFacturasPorId_Proveedor(CInt(txtId_Proveedor.Text))

                    Dim total As Double
                    For i As Integer = 0 To oListFacturas.Count - 1
                        Dim dias = DateDiff("d", oListFacturas(i).Fecha, Now)
                        Dim diasAtraso As Integer

                        Dim fechaFactura As Date = oListFacturas(i).Fecha
                        diasAtraso = dias - oListFacturas(i).Dias

                        fila = table.NewRow
                        fila.Item("Tipo") = "FACT"
                        fila.Item("Doc") = oListFacturas(i).NumFactura
                        fila.Item("Fecha") = fechaFactura
                        fila.Item("Fecha_Vence") = DateAdd(DateInterval.Day, oListFacturas(i).Dias, fechaFactura)
                        fila.Item("Dias") = oListFacturas(i).Dias
                        fila.Item("Atraso") = diasAtraso
                        fila.Item("Monto") = oListFacturas(i).Total
                        total = total + oListFacturas(i).Total
                        table.Rows.Add(fila)

                        For j = 0 To oListFacturas(i).ListaAbonos.Count - 1
                            fila = table.NewRow
                            fila.Item("Tipo") = "AB"
                            fila.Item("Doc") = oListFacturas(i).ListaAbonos(j).NumAbono
                            fila.Item("Fecha") = oListFacturas(i).ListaAbonos(j).Fecha
                            fila.Item("Fecha_Vence") = "-"
                            fila.Item("Dias") = "-"
                            fila.Item("Atraso") = "-"
                            fila.Item("Monto") = -oListFacturas(i).ListaAbonos(j).Monto
                            total = total - oListFacturas(i).ListaAbonos(j).Monto
                            table.Rows.Add(fila)
                        Next

                        For j = 0 To oListFacturas(i).ListaNC.Count - 1
                            fila = table.NewRow
                            fila.Item("Tipo") = "NC"

                            If oListFacturas(i).ListaNC(j).NumNC > 0 Then
                                fila.Item("Doc") = oListFacturas(i).ListaNC(j).NumNC
                            Else
                                fila.Item("Doc") = "-"
                            End If

                            If oListFacturas(i).ListaNC(j).Fecha <> Nothing Then
                                fila.Item("Fecha") = oListFacturas(i).ListaNC(j).Fecha
                            Else
                                fila.Item("Fecha") = "-"
                            End If

                            fila.Item("Fecha_Vence") = "-"
                            fila.Item("Dias") = "-"
                            fila.Item("Atraso") = "-"
                            fila.Item("Monto") = -oListFacturas(i).ListaNC(j).Total
                            total = total - oListFacturas(i).ListaNC(j).Total
                            table.Rows.Add(fila)
                        Next

                        For j = 0 To oListFacturas(i).ListaND.Count - 1
                            fila = table.NewRow
                            fila.Item("Tipo") = "ND"

                            If oListFacturas(i).ListaND(j).NumND > 0 Then
                                fila.Item("Doc") = oListFacturas(i).ListaND(j).NumND
                            Else
                                fila.Item("Doc") = "-"
                            End If

                            If oListFacturas(i).ListaND(j).Fecha <> Nothing Then
                                fila.Item("Fecha") = oListFacturas(i).ListaND(j).Fecha
                            Else
                                fila.Item("Fecha") = "-"
                            End If

                            fila.Item("Fecha_Vence") = "-"
                            fila.Item("Dias") = "-"
                            fila.Item("Atraso") = "-"
                            fila.Item("Monto") = oListFacturas(i).ListaND(j).Total
                            total = total + oListFacturas(i).ListaND(j).Total
                            table.Rows.Add(fila)
                        Next
                    Next

                    Dim oNotasGenerales As List(Of NCProveedorGeneral)

                    oNotasGenerales = _oLogicaProveedor.ConsultarGenerales(CInt(txtId_Proveedor.Text))

                    For j = 0 To oNotasGenerales.Count - 1
                        fila = table.NewRow
                        fila.Item("Tipo") = "NCG"
                        fila.Item("Doc") = oNotasGenerales(j).NumNC
                        fila.Item("Fecha") = oNotasGenerales(j).Fecha
                        fila.Item("Fecha_Vence") = "-"
                        fila.Item("Dias") = "-"
                        fila.Item("Atraso") = "-"
                        fila.Item("Monto") = -_oUtilidades.PasarMoneda(oNotasGenerales(j).Total)
                        total = total - oNotasGenerales(j).Total
                        table.Rows.Add(fila)
                    Next

                    Dim paginas = _oUtilidades.CalculaPaginas((table.Rows.Count) / 25)

                    For i As Integer = 1 To paginas
                        tmpTable.Rows.Clear()
                        Dim reporte As New RptEstadoCuenta
                        reporte.SetDataSource(guardarLineas((i * 25) - 25, table, tmpTable))
                        Dim proveedor = _oLogicaProveedor.Consultar(CInt(txtId_Proveedor.Text))
                        reporte.SetParameterValue("nombre", proveedor.Nombre)
                        reporte.SetParameterValue("total", total)
                        reporte.SetParameterValue("numPagina", i)
                        reporte.SetParameterValue("paginas", paginas)
                        reporte.SetParameterValue("cuenta", proveedor.NCuenta)
                        reporte.SetParameterValue("direccion", proveedor.Direccion)
                        reporte.SetParameterValue("Telefonos", proveedor.CentralTelefonica)
                        reporte.SetParameterValue("fax", proveedor.FaxPrincipal)
                        Dim nombreImpresora = _oLogicaVarios.ConsultarColumna("Imp_Medio_Oficio")
                        Dim nombrePc = _oLogicaVarios.ConsultarColumna("PC_Medio_Oficio")
                        reporte.PrintOptions.PrinterName = "\\" & nombrePc & "\" & nombreImpresora
                        reporte.PrintToPrinter(1, False, 1, 1)
                    Next
                End If

            Else
                MsgBox("Debe de seleccionar el proveedor antes de imprimir el Estado de Cuenta", MsgBoxStyle.Exclamation)
            End If

        End Sub

        Private Function guardarLineas(ByVal inicio As Integer, ByVal table As DataTable, ByVal tmpTable As DataTable) As DataTable
            Dim indice As Integer, final As Integer
            Dim fila As DataRow

            With table
                If inicio + 25 < .Rows.Count Then
                    final = inicio + 25
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
                    tmpTable.Rows.Add(fila)
                Next indice
            End With

            Return tmpTable
        End Function

        Private Sub AnularToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles AnularToolStripMenuItem.Click
            With dgvFacturas
                If dgvFacturas.Rows.Count > 0 Then
                    FrmAnularDocPorPagar.lblMostrarNumFactura.Text = .Rows(.CurrentCell.RowIndex).Cells(2).Value
                    FrmAnularDocPorPagar.txtId_DocPorPagar.Text = .Rows(.CurrentCell.RowIndex).Cells(0).Value
                    FrmAnularDocPorPagar.lblMostrarMonto.Text = .Rows(.CurrentCell.RowIndex).Cells(5).Value
                    FrmAnularDocPorPagar.ShowDialog()
                End If
            End With
        End Sub

        Private Sub dgvFacturas_MouseDown(ByVal sender As System.Object, ByVal e As Windows.Forms.MouseEventArgs) Handles dgvFacturas.MouseDown
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

                If dgvFacturas.Item(1, dgvFacturas.CurrentCell.RowIndex).Value = "NCG" Then
                    sender.ContextMenuStrip = MnNCG
                Else
                    sender.ContextMenuStrip = MnFactura
                End If

            End If
        End Sub

        Private Sub VerToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles VerToolStripMenuItem2.Click
            If dgvFacturas.RowCount > 0 Then
                FrmNcProveedorGeneral.txtId_NCG.Text = dgvFacturas.Item(0, dgvFacturas.CurrentCell.RowIndex).Value
                FrmNcProveedorGeneral.lblMostrar_Id.Text = txtId_Proveedor.Text
                FrmNcProveedorGeneral.lblMostrarNombre.Text = txtNombre.Text
                FrmNcProveedorGeneral.ShowDialog()
            End If
        End Sub

        Private Sub EliminarToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles EliminarToolStripMenuItem3.Click
            Dim respuesta As String
            respuesta = MsgBox("Esta seguro que desea eliminar esta Nota?", vbCritical + vbYesNo, "Eliminar Nota...")

            If respuesta = vbYes Then
                _oLogicaProveedor.eliminarNCG_PorId(CInt(dgvFacturas.Item(0, dgvFacturas.CurrentCell.RowIndex).Value))
                lblActual.Text = _oUtilidades.PasarMoneda(CDbl(lblActual.Text) + CInt(dgvFacturas.Item(5, dgvFacturas.CurrentCell.RowIndex).Value))
                dgvFacturas.Rows.RemoveAt(dgvFacturas.CurrentCell.RowIndex)
            End If

        End Sub

        Private Sub txtId_Proveedor_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtId_Proveedor.KeyDown
            If e.KeyData = Keys.Enter Then
                txtNombre.Focus()
            ElseIf e.KeyData = Keys.Enter Then
                'falta definir el focus del clic en esta opción
            End If
        End Sub

        Private Sub txtId_Proveedor_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtId_Proveedor.KeyPress
            Dim keyAscii As Short = CShort(Asc(e.KeyChar))
            If Not keyAscii = 13 Then
                Dim oProveedor = BuscarProveedorPorId(e, txtId_Proveedor, txtNombre)
                If oProveedor.IdProveedor <> 0 Then
                    LlenarProveedor(oProveedor)
                Else
                    LimpiarTodo()
                End If
            End If
        End Sub

        Private Sub txtNombre_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
            cambiarControlADataGrid(dgvProveedores, e, txtNombre, txtNombre, txtNombre)
        End Sub

        Private Sub txtNombre_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
            BuscarProveedorPorNombre(dgvProveedores, e, txtNombre, txtId_Proveedor)
        End Sub

        Private Sub btnDatosProveedor_Click(sender As Object, e As EventArgs) Handles btnDatosProveedor.Click
            If IsNumeric(txtId_Proveedor.Text) And txtNombre.Text <> "" Then
                Dim proveedor = _oLogicaProveedor.Consultar(CInt(txtId_Proveedor.Text))
                FrmProveedor.txtId_Proveedor.Text = proveedor.IdProveedor
                FrmProveedor.LlenarProveedor(proveedor)
                FrmProveedor.ShowDialog()
            End If
        End Sub

        Private Sub txtId_Proveedor_MouseCaptureChanged(sender As Object, e As EventArgs) Handles txtId_Proveedor.MouseCaptureChanged
            LimpiarTodo()
            txtId_Proveedor.Text = String.Empty
        End Sub

        Private Sub txtNombre_MouseCaptureChanged(sender As Object, e As EventArgs) Handles txtNombre.MouseCaptureChanged
            LimpiarTodo()
            txtId_Proveedor.Text = String.Empty

            txtNombre.Focus()
        End Sub

        Private Sub btnFacturas_Click(sender As Object, e As EventArgs) Handles btnFacturas.Click
            If IsNumeric(txtId_Proveedor.Text) And txtNombre.Text <> "" Then
                FrmDocPorPagar.txtId_Proveedor.Text = txtId_Proveedor.Text
                FrmDocPorPagar.txtNombreProveedor.Text = txtNombre.Text
                FrmDocPorPagar.txtNumFactura.TabIndex = 0
                FrmDocPorPagar.Pantalla = 1
                FrmDocPorPagar.ShowDialog()
            End If
        End Sub

        Private Sub btnBajarVencido_Click(sender As Object, e As EventArgs) Handles btnBajarVencido.Click
            With dgvFacturas
                If dgvFacturas.Rows.Count > 0 Then
                    _lineas = 0

                    For i = 0 To .Rows.Count - 1
                        Dim fila As Integer = .CurrentCell.RowIndex
                        Dim diasAtrasado As String = .Item(7, fila).Value
                        If diasAtrasado > 0 Then
                            BajarLinea()
                        End If
                    Next

                    lblActual.Text = _oUtilidades.PasarMoneda(CDbl(lblMostrarAnterior.Text) - CDbl(lblMostrarAbono.Text))

                    If .Rows.Count > 0 Then .Rows(0).Selected = False

                    btnBajarVencido.Enabled = False
                    lblMostrarAnterior.Text = _oUtilidades.PasarMoneda(txtTotalCreditos.Text)
                    lblMostrarAbono.Text = _oUtilidades.PasarMoneda(lblMostrarAbono.Text)
                    lblActual.Text = _oUtilidades.PasarMoneda(txtTotalCreditos.Text - lblMostrarAbono.Text)

                End If
            End With
        End Sub
    End Class
End Namespace