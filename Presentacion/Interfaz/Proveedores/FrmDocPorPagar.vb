Imports Entidades
Imports Logica_Negocios

Namespace Interfaz.Proveedores
    Public Class FrmDocPorPagar

        Private ReadOnly _oUtilidades As New Utilidades
        Private ReadOnly _oLogicaProveedor As New LogicaProveedor
        Private ReadOnly _oLogicaDocPorPagar As New LogicaDocPorPagar
        Private _oListaNc As New List(Of NCFacturaProveedor)
        Private _oListaNd As New List(Of NDFacturaProveedor)
        Private _oListaAb As New List(Of AbonoFacturaProveedor)
        Private _tipoNota As Integer '1 - Nota crédito 2- NOta debito
        Private _modifica As Boolean = False

        '1- Facturas por proveedor 
        Private _varPantalla As Integer
        Public Property Pantalla() As Integer
            Get
                Return _varPantalla
            End Get
            Set(ByVal value As Integer)
                _varPantalla = value
            End Set
        End Property

        Private Sub GuardarCambios()
            If _modifica Then
                Dim respuesta As String

                respuesta = MsgBox("Desea guardar los cambios realizados antes de cerrar la ventana?", vbCritical + vbYesNo, "Guardar cambios...")

                If (respuesta = vbYes) Then
                    ValidarDocPorPagar()
                End If
            End If
        End Sub

        Public Sub LlenarProveedor(ByVal oProveedor As Proveedor)
            If oProveedor.IdProveedor <> 0 Then
                txtNombreProveedor.Text = oProveedor.Nombre
                dgvProveedores.Visible = False
            Else
                LimpiarTodo()
            End If
        End Sub

        Private Sub LimpiarTodo()
            txtNombreProveedor.Text = String.Empty
            txtNumFactura.Text = String.Empty
            txtSubTotalEx.Text = 0
            txtSubTotalIV.Text = 0
            txtTotal.Text = 0
            txtIV.Text = 0
            chkCancelada.Checked = False
            chkCancelada.Enabled = True
            txtDias.Text = 30
            chkDescuento.Visible = False
            chkDescuento.Checked = False
            gbContado.Enabled = True
            txtFechaCancelacion.Text = String.Empty
            txtFechaFactura.Text = String.Empty
            txtFechaIngreso.Text = String.Empty
            dgvProveedores.Visible = False
            gbCancelada.Enabled = True
            chkAnulada.Enabled = True
            chkAnulada.Checked = False
            txtMotivoAnulada.Enabled = True
            txtMotivoAnulada.Text = String.Empty
            txtNumFactura.Enabled = True
            dgvNotas.ContextMenuStrip = MenuEliminar
            LimpiarErroresValidacion()
            txtIdDoc_PorPagar.Text = String.Empty
            cbMes.SelectedIndex = -1
            dgvNotas.Rows.Clear()
            _modifica = False
            _oListaNc = New List(Of NCFacturaProveedor)
            _oListaNd = New List(Of NDFacturaProveedor)
            LimpiarNotas()
        End Sub

        Public Sub LimpiarNotas()
            txtIdNota.Text = String.Empty
            chkNuevaNota.Checked = True
            txtTotalNC1.Text = 0
            txtFechaNC1.Text = String.Empty
            txtIVNC1.Text = 0
            txtSubTotalExN.Text = 0
            txtSubTotalIVN.Text = 0
            txtMotivo1.Text = String.Empty
            txtNumNC1.Text = String.Empty
            txtBoleta1.Text = String.Empty
            txtFechaBoleta1.Text = String.Empty
            LimpiarErroresValidacionNotas()
            If Not chkCancelada.Checked Then
                btnNC.Enabled = True
                btnND.Enabled = True
            End If
            chkDescuento.Visible = False
            chkDescuento.Checked = False
            _tipoNota = 0
            CambiarEstado(False)
        End Sub

        Private Sub txtId_Proveedor_MouseClick(ByVal sender As System.Object, ByVal e As Windows.Forms.MouseEventArgs) Handles txtId_Proveedor.MouseClick
            LimpiarTodo()
            txtId_Proveedor.Text = String.Empty
        End Sub

        Private Sub dgvProveedores_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles dgvProveedores.KeyDown
            If (e.KeyValue = 13) Then
                txtId_Proveedor.Text = dgvProveedores.Item(0, dgvProveedores.CurrentRow.Index).Value
                txtNombreProveedor.Text = dgvProveedores.Item(1, dgvProveedores.CurrentRow.Index).Value
                LlenarProveedor(_oLogicaProveedor.Consultar(CInt(txtId_Proveedor.Text)))
                txtNumFactura.Focus()
            End If
        End Sub

        Private Sub dgvProveedores_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvProveedores.Click
            txtId_Proveedor.Text = dgvProveedores.Item(0, dgvProveedores.CurrentRow.Index).Value
            txtNombreProveedor.Text = dgvProveedores.Item(1, dgvProveedores.CurrentRow.Index).Value
            LlenarProveedor(_oLogicaProveedor.Consultar(CInt(txtId_Proveedor.Text)))
            txtNumFactura.Focus()
        End Sub

        Private Sub txtNumFactura_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNumFactura.KeyDown
            If (e.KeyValue = 13) Then
                BuscarFactura()
            End If
        End Sub

        Private Sub txtSubTotalIV_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtSubTotalIV.KeyDown
            If (e.KeyValue = 13) Then txtSubTotalEx.Focus()
        End Sub

        Private Sub txtSubTotalEx_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtSubTotalEx.KeyDown
            If (e.KeyValue = 13) Then txtIV.Focus()
        End Sub

        Private Sub txtIV_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtIV.KeyDown
            If (e.KeyValue = 13) Then txtTotal.Focus()
        End Sub

        Private Sub txtTotal_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtTotal.KeyDown
            If (e.KeyValue = 13) Then chkCancelada.Focus()
        End Sub

        Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnLimpiar.Click
            GuardarCambios()
            LimpiarTodo()
            txtId_Proveedor.Text = String.Empty
            txtNombreProveedor.Focus()
        End Sub

        Private Sub btnInsertar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnInsertar.Click
            ValidarDocPorPagar()
        End Sub

        Private Sub ValidarDocPorPagar()
            LimpiarErroresValidacion()
            Dim valida As Boolean = True
            Dim oDocPorPagar As New FacturaProveedor


            ValidaVacioCeroDevuelveCadena(valida, Trim(txtNumFactura.Text), oDocPorPagar.NumFactura, lblNumFactura,
                                          "El número de la factura no puede estar vacío o ser cero", errorValidacion)
            ValidaVacioDevuelveDouble(valida, Trim(txtIV.Text), oDocPorPagar.IV, lblIV,
                                      "El impuesto no puede estar vacío", errorValidacion)
            ValidaVacioDevuelveDouble(valida, Trim(txtTotal.Text), oDocPorPagar.Total, lblTotal,
                                      "El total no puede estar vacío", errorValidacion)
            ValidaVacioDevuelveDouble(valida, Trim(txtDias.Text), oDocPorPagar.Dias, lblTotal,
                                      "El número de días no puede estar vacío", errorValidacion)

            If Trim(txtId_Proveedor.Text) = "" Or Trim(txtNombreProveedor.Text) = "" Then
                errorValidacion.SetError(lblNombreProveedor, "El proveedor debe existir")
                valida = False
            Else
                oDocPorPagar.IdProveedor = CInt(txtId_Proveedor.Text)
            End If

            If chkCancelada.Checked Then
                oDocPorPagar.Estado = FacturaProveedor.ListaEstado.Cancelada

                If Trim(txtFechaCancelacion.Text) = "" Or Trim(txtFechaCancelacion.Text).Length <> 10 Then
                    errorValidacion.SetError(chkCancelada, "No se ha asignado una fecha válida de cancelación. Formato '10/12/2002'")
                    valida = False
                Else
                    Try
                        oDocPorPagar.FechaCancelacion = CDate(txtFechaCancelacion.Text)
                    Catch ex As Exception
                        errorValidacion.SetError(chkCancelada, "No se ha asignado una fecha válida de cancelación. Formato '10/12/2002'")
                        valida = False
                    End Try
                End If

            Else
                oDocPorPagar.Estado = FacturaProveedor.ListaEstado.Pendiente
                oDocPorPagar.FechaCancelacion = CDate("01/01/0001")
            End If

            If chkAnulada.Checked Then
                If Trim(txtMotivoAnulada.Text) = "" Then
                    errorValidacion.SetError(lblMotivoAnulada, "El motivo del porqué la factura fue anulada no puede estar vacío")
                    valida = False
                Else
                    oDocPorPagar.Estado = FacturaProveedor.ListaEstado.Anulada
                    oDocPorPagar.Motivo = txtMotivoAnulada.Text
                End If
            Else
                oDocPorPagar.Motivo = "-"
            End If

            If Trim(txtFechaFactura.Text) = "" Or Trim(txtFechaFactura.Text).Length <> 10 Then
                errorValidacion.SetError(lblFecha, "No se ha asignado una fecha válida a la factura. Formato '10/12/2002'")
                valida = False
            Else
                Try
                    oDocPorPagar.Fecha = CDate(txtFechaFactura.Text)
                Catch ex As Exception
                    errorValidacion.SetError(lblFecha, "No se ha asignado una fecha válida a la factura. Formato '10/12/2002'")
                    valida = False
                End Try

            End If

            oDocPorPagar.FechaIngreso = Now.ToString("yyyy-MM-dd")

            If cbMes.SelectedIndex >= 0 Then
                oDocPorPagar.MesTributo = cbMes.SelectedIndex
            Else
                errorValidacion.SetError(cbMes, "No se ha seleccionado el mes tributado")
                valida = False
            End If


            oDocPorPagar.ListaNC = _oListaNc
            oDocPorPagar.ListaND = _oListaNd

            If valida Then

                'Se utiliza 4 como valor maximo porqué el mayor error posible es de 3.84 al redondedar de dos decimales a cero decimales basados en un 13%

                Dim subTotalIV = oDocPorPagar.IV / 0.13
                If subTotalIV < 4 Then
                    subTotalIV = 0
                End If

                Dim subTotalEx = oDocPorPagar.Total - subTotalIV - oDocPorPagar.IV
                If subTotalEx < 4 Then
                    subTotalEx = 0
                End If

                oDocPorPagar.SubTotalIV = _oUtilidades.PasarMoneda(subTotalIV)
                oDocPorPagar.SubTotalEx = _oUtilidades.PasarMoneda(subTotalEx)


                Dim suma = oDocPorPagar.SubTotalIV + oDocPorPagar.SubTotalEx + oDocPorPagar.IV
                Dim resta = suma - oDocPorPagar.Total

                If resta >= -4 And resta <= 4 Then
                    If Trim(txtIdDoc_PorPagar.Text = "") Then
                        Dim inserto = _oLogicaDocPorPagar.Insertar(oDocPorPagar)
                        If inserto Then
                            MessageBox.Show("Factura insertada con éxito", "Insertar documento por pagar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Dim nombre = txtNombreProveedor.Text
                            LimpiarTodo()
                            txtNombreProveedor.Text = nombre
                            txtIdDoc_PorPagar.Text = String.Empty
                            txtNombreProveedor.Focus()
                        Else
                            MsgBox("No se permite agregar esta factura, ya que este número de factura ha sido insertado anteriormente", MsgBoxStyle.Critical)
                        End If
                    Else
                        oDocPorPagar.IdDocPagar = CInt(txtIdDoc_PorPagar.Text)
                        _oLogicaDocPorPagar.Modificar(oDocPorPagar)
                        MessageBox.Show("Factura modificada con éxito", "Modificar documento por pagar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Dim nombre = txtNombreProveedor.Text
                        LimpiarTodo()
                        txtNombreProveedor.Text = nombre
                        txtIdDoc_PorPagar.Text = String.Empty
                        txtNombreProveedor.Focus()
                    End If
                Else
                    MsgBox("Los datos ingresados no cierran con el monto total", MsgBoxStyle.Critical)
                End If
            End If
        End Sub

        Private Sub LimpiarErroresValidacion()
            errorValidacion.SetError(lblNombreProveedor, String.Empty)
            errorValidacion.SetError(lblNumFactura, String.Empty)
            errorValidacion.SetError(lblSubTotalIV, String.Empty)
            errorValidacion.SetError(lblSubTotalEx, String.Empty)
            errorValidacion.SetError(lblMes, String.Empty)
            errorValidacion.SetError(lblIV, String.Empty)
            errorValidacion.SetError(lblTotal, String.Empty)
            errorValidacion.SetError(lblFecha, String.Empty)
            errorValidacion.SetError(lblFechaCancelacion, String.Empty)
            errorValidacion.SetError(cbMes, String.Empty)
            errorBlink.SetError(lblMes, String.Empty)
            LimpiarErroresValidacionNotas()

        End Sub

        Private Sub LimpiarErroresValidacionNotas()
            errorValidacion.SetError(lblFechaBoleta1, String.Empty)
            errorValidacion.SetError(lblFechaNC1, String.Empty)
            errorValidacion.SetError(lblSubTotalIVNC, String.Empty)
            errorValidacion.SetError(lblIVNC1, String.Empty)
            errorValidacion.SetError(lblSubTotalExNC, String.Empty)
            errorValidacion.SetError(lblTotalNC1, String.Empty)
            errorValidacion.SetError(lblMotivo1, String.Empty)
        End Sub
        Private Sub FrmDocPorPagar_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load

            AddHandler dgvNotas.MouseDown, AddressOf SeleccionaClickDerecho
            dgvNotas.ContextMenuStrip = MenuEliminar

            AddHandler txtBoleta1.KeyPress, AddressOf ValidarSoloNumeros
            AddHandler txtNumNC1.KeyPress, AddressOf ValidarSoloNumeros
            AddHandler txtDias.KeyPress, AddressOf ValidarSoloNumeros

            AddHandler txtSubTotalEx.KeyPress, AddressOf ValidarNumerosPunto
            AddHandler txtSubTotalIV.KeyPress, AddressOf ValidarNumerosPunto
            AddHandler txtIV.KeyPress, AddressOf ValidarNumerosPunto
            AddHandler txtTotal.KeyPress, AddressOf ValidarNumerosPunto
            AddHandler txtIVNC1.KeyPress, AddressOf ValidarNumerosPunto
            AddHandler txtTotalNC1.KeyPress, AddressOf ValidarNumerosPunto
            AddHandler txtSubTotalExN.KeyPress, AddressOf ValidarNumerosPunto
            AddHandler txtSubTotalIVN.KeyPress, AddressOf ValidarNumerosPunto

            AddHandler txtFechaFactura.KeyPress, AddressOf FormatoFecha
            AddHandler txtFechaCancelacion.KeyPress, AddressOf FormatoFecha
            AddHandler txtFechaNC1.KeyPress, AddressOf FormatoFecha
            AddHandler txtFechaBoleta1.KeyPress, AddressOf FormatoFecha
        End Sub

        Private Sub txtFechaFactura_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtFechaFactura.KeyDown
            If (e.KeyValue = 13) Then
                txtDias.Focus()
                If Trim(txtFechaFactura.Text) <> "" Or Trim(txtFechaFactura.Text).Length = 10 Then
                    Dim fecha = CDate(txtFechaFactura.Text)
                    If (fecha.Month = Now.Month) Then
                        cbMes.SelectedIndex = Convert.ToInt32(Now.Month - 1)
                        errorBlink.SetError(lblMes, String.Empty)
                    ElseIf (fecha.Month < Now.Month And Now.Day > 17) Then
                        cbMes.SelectedIndex = Convert.ToInt32(Now.Month - 1)
                        errorBlink.SetError(lblMes, "Verifique el mes tributado")
                    ElseIf (fecha.Month < Now.Month And Now.Day < 14) Then
                        cbMes.SelectedIndex = Convert.ToInt32(Now.Month - 2)
                        errorBlink.SetError(lblMes, "Verifique el mes tributado")
                    Else
                        cbMes.SelectedIndex = -1
                        cbMes.SelectedText = String.Empty
                        errorBlink.SetError(lblMes, String.Empty)
                    End If
                End If
            End If
        End Sub

        Private Sub txtBoleta1_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtBoleta1.KeyDown
            If (e.KeyValue = 13) Then txtFechaBoleta1.Focus()
        End Sub

        Private Sub txtFechaBoleta1_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtFechaBoleta1.KeyDown
            If (e.KeyValue = 13) Then txtNumNC1.Focus()
        End Sub

        Private Sub txtNumNC1_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNumNC1.KeyDown
            If (e.KeyValue = 13) Then txtFechaNC1.Focus()
        End Sub

        Private Sub txtFechaNC1_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtFechaNC1.KeyDown
            If (e.KeyValue = 13) Then
                If chkDescuento.Checked Then
                    txtTotalNC1.Focus()
                Else
                    txtIVNC1.Focus()
                End If
            End If

        End Sub

        Private Sub txtIVNC1_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtIVNC1.KeyDown
            If (e.KeyValue = 13) Then txtTotalNC1.Focus()
        End Sub

        Private Sub txtTotalNC1_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtTotalNC1.KeyDown
            If (e.KeyValue = 13) Then
                If _tipoNota = 1 Then
                    If chkDescuento.Checked Then

                        Dim subTotalIV = CDbl(txtTotalNC1.Text) / 1.13
                        txtIVNC1.Text = _oUtilidades.PasarMoneda(subTotalIV * 0.13)
                        txtSubTotalIVN.Text = _oUtilidades.PasarMoneda(subTotalIV)
                        txtSubTotalExN.Text = 0

                    Else
                        Dim subTotalIV = CDbl(txtIVNC1.Text) / 0.13
                        If subTotalIV < 4 Then
                            subTotalIV = 0
                        End If

                        Dim subTotalEx = CDbl(txtTotalNC1.Text) - subTotalIV - CDbl(txtIVNC1.Text)
                        If subTotalEx < 4 Then
                            subTotalEx = 0
                        End If

                        txtSubTotalIVN.Text = _oUtilidades.PasarMoneda(subTotalIV)
                        txtSubTotalExN.Text = _oUtilidades.PasarMoneda(subTotalEx)
                    End If
                ElseIf _tipoNota = 2 Then
                    Dim subTotalIV = CDbl(txtIVNC1.Text) / 0.13
                    If subTotalIV < 4 Then
                        subTotalIV = 0
                    End If

                    Dim subTotalEx = CDbl(txtTotalNC1.Text) - subTotalIV - CDbl(txtIVNC1.Text)
                    If subTotalEx < 4 Then
                        subTotalEx = 0
                    End If

                    txtSubTotalIVN.Text = _oUtilidades.PasarMoneda(subTotalIV)
                    txtSubTotalExN.Text = _oUtilidades.PasarMoneda(subTotalEx)
                End If
                txtMotivo1.Focus()
            End If
        End Sub

        Private Sub txtMotivo1_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtMotivo1.KeyDown
            If (e.KeyValue = 13) Then btnAgregar.Focus()
        End Sub

        Public Sub BuscarDocFactura()
            Dim oDocPorPagar As FacturaProveedor
            oDocPorPagar = _oLogicaDocPorPagar.ConsultarPorIdDocPagar(CInt(txtIdDoc_PorPagar.Text))
            LlenarDatos(oDocPorPagar)
        End Sub

        Private Sub LlenarDatos(ByVal oDocPorPagar As FacturaProveedor)
            txtFechaFactura.Text = oDocPorPagar.Fecha
            txtNumFactura.Text = oDocPorPagar.NumFactura
            txtId_Proveedor.Text = oDocPorPagar.IdProveedor
            txtIdDoc_PorPagar.Text = oDocPorPagar.IdDocPagar
            txtNombreProveedor.Text = _oLogicaProveedor.consultarNombre_PorCodigo(oDocPorPagar.IdProveedor)
            txtSubTotalIV.Text = _oUtilidades.PasarMoneda(oDocPorPagar.SubTotalIV)
            txtSubTotalEx.Text = _oUtilidades.PasarMoneda(oDocPorPagar.SubTotalEx)
            txtIV.Text = _oUtilidades.PasarMoneda(oDocPorPagar.IV)
            txtTotal.Text = _oUtilidades.PasarMoneda(oDocPorPagar.Total)
            txtFechaIngreso.Text = oDocPorPagar.FechaIngreso
            cbMes.SelectedIndex = oDocPorPagar.MesTributo
            txtDias.Text = oDocPorPagar.Dias

            If oDocPorPagar.Estado = FacturaProveedor.ListaEstado.Cancelada Then
                chkCancelada.Checked = True
                txtFechaCancelacion.Text = oDocPorPagar.FechaCancelacion
                btnNC.Enabled = False
                btnND.Enabled = False
                dgvNotas.ContextMenuStrip = Nothing
                gbContado.Enabled = False

                If Not oDocPorPagar.Contado Then
                    chkCancelada.Enabled = False
                    txtFechaCancelacion.Enabled = False
                End If
            ElseIf oDocPorPagar.Estado = FacturaProveedor.ListaEstado.Anulada Then
                chkAnulada.Checked = True
                txtMotivoAnulada.Text = oDocPorPagar.Motivo
                txtMotivoAnulada.Enabled = True
                btnNC.Enabled = False
                btnND.Enabled = False
                chkCancelada.Enabled = False
            End If

            If oDocPorPagar.Contado Then
                rbContado.Checked = True
            Else
                rbCredito.Checked = True
            End If
            dgvProveedores.Visible = False

            _oListaNc = oDocPorPagar.ListaNC

            For i = 0 To _oListaNc.Count - 1
                dgvNotas.Rows.Add(_oListaNc(i).IdNC, "NC", _oListaNc(i).NumNC, _oListaNc(i).Total)
            Next

            _oListaNd = oDocPorPagar.ListaND

            For i = 0 To _oListaNd.Count - 1
                dgvNotas.Rows.Add(_oListaNd(i).IdND, "ND", _oListaNd(i).NumND, _oListaNd(i).Total)
            Next

            _oListaAb = oDocPorPagar.ListaAbonos

            For i = 0 To _oListaAb.Count - 1
                dgvNotas.Rows.Add(_oListaAb(i).IdAbono, "AB", _oListaAb(i).NumAbono, _oListaAb(i).Monto)
            Next

            If dgvNotas.RowCount > 0 Then dgvNotas.Rows(0).Selected = False
        End Sub

        Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAgregar.Click
            If _tipoNota = 1 Then

                Dim oNcDocPorPagar As New NCFacturaProveedor

                If Trim(txtNumNC1.Text) = "" Then
                    oNcDocPorPagar.NumNC = 0
                Else
                    oNcDocPorPagar.NumNC = CInt(txtNumNC1.Text)
                End If

                If Trim(txtBoleta1.Text) = "" Then
                    oNcDocPorPagar.BoletaDev = 0
                Else
                    oNcDocPorPagar.BoletaDev = CInt(txtBoleta1.Text)
                End If

                If ValidaNotas(oNcDocPorPagar) Then

                    'Se utiliza 4 como valor maximo porqué el mayor error posible es de 3.84 al redondedar de dos decimales a cero decimales basados en un 13%
                    'Si es una nota de crédito por descuento se saca el subtotalIV y se calcula el iv

                    If chkNuevaNota.Checked Then
                        oNcDocPorPagar.IV = CDbl(txtIVNC1.Text)
                        oNcDocPorPagar.Total = CDbl(txtTotalNC1.Text)
                    End If

                    If chkDescuento.Checked Then

                        Dim subTotalIV = oNcDocPorPagar.Total / 1.13
                        oNcDocPorPagar.IV = _oUtilidades.PasarMoneda(subTotalIV * 0.13)
                        oNcDocPorPagar.SubTotalIV = _oUtilidades.PasarMoneda(subTotalIV)
                        oNcDocPorPagar.SubTotalEx = 0
                        oNcDocPorPagar.PorDescuento = True
                    Else
                        Dim subTotalIV = oNcDocPorPagar.IV / 0.13
                        If subTotalIV < 4 Then
                            subTotalIV = 0
                        End If

                        Dim subTotalEx = oNcDocPorPagar.Total - subTotalIV - oNcDocPorPagar.IV
                        If subTotalEx < 4 Then
                            subTotalEx = 0
                        End If

                        oNcDocPorPagar.SubTotalIV = _oUtilidades.PasarMoneda(subTotalIV)
                        oNcDocPorPagar.SubTotalEx = _oUtilidades.PasarMoneda(subTotalEx)
                    End If


                    Dim suma = oNcDocPorPagar.SubTotalIV + oNcDocPorPagar.SubTotalEx + oNcDocPorPagar.IV
                    Dim resta = suma - oNcDocPorPagar.Total

                    If resta >= -4 And resta <= 4 Then
                        If chkNuevaNota.Checked Then
                            _oListaNc.Add(oNcDocPorPagar)
                            If (IsNumeric(txtIdDoc_PorPagar.Text)) Then
                                oNcDocPorPagar.IdDocPorPagar = Convert.ToInt32(txtIdDoc_PorPagar.Text)
                                oNcDocPorPagar.IdNC = _oLogicaDocPorPagar.InsertarNC(oNcDocPorPagar)
                            End If
                            dgvNotas.Rows.Add(oNcDocPorPagar.IdNC, "NC", oNcDocPorPagar.NumNC, _oUtilidades.PasarMoneda(oNcDocPorPagar.Total))
                        Else
                            For i = 0 To _oListaNc.Count - 1
                                If _oListaNc(i).IdNC = CInt(txtIdNota.Text) Then
                                    _oListaNc(i) = oNcDocPorPagar
                                End If
                            Next
                            oNcDocPorPagar.IdDocPorPagar = Convert.ToInt32(txtIdDoc_PorPagar.Text)
                            oNcDocPorPagar.IdNC = Convert.ToInt32(txtIdNota.Text)
                            _oLogicaDocPorPagar.ModificarNC(oNcDocPorPagar)
                            For i = 0 To dgvNotas.Rows.Count - 1
                                If dgvNotas.Rows(i).Cells("Id_Nota").Value = oNcDocPorPagar.IdNC Then
                                    dgvNotas.Rows(i).Cells("NDoc").Value = oNcDocPorPagar.NumNC
                                    dgvNotas.Rows(i).Cells("Monto").Value = _oUtilidades.PasarMoneda(oNcDocPorPagar.Total)
                                End If
                            Next
                        End If
                        _modifica = True
                        LimpiarNotas()
                    Else
                        MsgBox("Los datos ingresados de la nota de crédito no cierran con el monto total", MsgBoxStyle.Critical)
                    End If
                End If

            ElseIf _tipoNota = 2 Then
                Dim oNdDocPorPagar As New NDFacturaProveedor

                If Trim(txtNumNC1.Text) = "" Then
                    oNdDocPorPagar.NumND = 0
                Else
                    oNdDocPorPagar.NumND = CInt(txtNumNC1.Text)
                End If

                If Trim(txtBoleta1.Text) = "" Then
                    oNdDocPorPagar.Boleta = 0
                Else
                    oNdDocPorPagar.Boleta = CInt(txtBoleta1.Text)
                End If

                If ValidaNotas(oNdDocPorPagar) Then

                    Dim subTotalIV = oNdDocPorPagar.IV / 0.13
                    If subTotalIV < 4 Then
                        subTotalIV = 0
                    End If

                    Dim subTotalEx = oNdDocPorPagar.Total - subTotalIV - oNdDocPorPagar.IV
                    If subTotalEx < 4 Then
                        subTotalEx = 0
                    End If

                    oNdDocPorPagar.SubTotalIV = _oUtilidades.PasarMoneda(subTotalIV)
                    oNdDocPorPagar.SubTotalEx = _oUtilidades.PasarMoneda(subTotalEx)

                    Dim suma = oNdDocPorPagar.SubTotalIV + oNdDocPorPagar.SubTotalEx + oNdDocPorPagar.IV
                    Dim resta = suma - oNdDocPorPagar.Total

                    If resta >= -4 And resta <= 4 Then
                        If chkNuevaNota.Checked Then
                            _oListaNd.Add(oNdDocPorPagar)
                            If (IsNumeric(txtIdDoc_PorPagar.Text)) Then
                                oNdDocPorPagar.IdDocPorPagar = Convert.ToInt32(txtIdDoc_PorPagar.Text)
                                oNdDocPorPagar.IdND = _oLogicaDocPorPagar.InsertarND(oNdDocPorPagar)
                            End If
                            dgvNotas.Rows.Add(oNdDocPorPagar.IdND, "ND", oNdDocPorPagar.NumND, _oUtilidades.PasarMoneda(oNdDocPorPagar.Total))
                        Else
                            For i = 0 To _oListaNd.Count - 1
                                If _oListaNd(i).IdND = CInt(txtIdNota.Text) Then
                                    _oListaNd(i) = oNdDocPorPagar
                                End If
                            Next
                        oNdDocPorPagar.IdDocPorPagar = Convert.ToInt32(txtIdDoc_PorPagar.Text)
                        oNdDocPorPagar.IdND = Convert.ToInt32(txtIdNota.Text)
                        _oLogicaDocPorPagar.ModificarND(oNdDocPorPagar)
                        For i = 0 To dgvNotas.Rows.Count - 1
                            If dgvNotas.Rows(i).Cells("Id_Nota").Value = oNdDocPorPagar.IdND Then
                                dgvNotas.Rows(i).Cells("NDoc").Value = oNdDocPorPagar.NumND
                                dgvNotas.Rows(i).Cells("Monto").Value = _oUtilidades.PasarMoneda(oNdDocPorPagar.Total)
                            End If
                        Next
                        End If

                        _modifica = True
                        LimpiarNotas()
                    Else
                        MsgBox("Los datos ingresados de la nota de débito no cierran con el monto total", MsgBoxStyle.Critical)
                    End If

                End If
            End If

        End Sub

        Private Function ValidaNotas(ByVal objeto As Object) As Boolean

            Dim valida = True

            ValidaVacioDevuelveDouble(valida, Trim(txtTotalNC1.Text), objeto.Total, lblTotalNC1,
                                      "El total no puede estar vacío", errorValidacion)
            ValidaVacioDevuelveDouble(valida, Trim(txtIVNC1.Text), objeto.IV, lblIVNC1,
                                      "El impuesto no puede estar vacío", errorValidacion)

            objeto.SubTotalIV = CDbl(txtSubTotalIVN.Text)
            objeto.SubTotalEx = CDbl(txtSubTotalExN.Text)

            If Trim(txtFechaNC1.Text) = "" Then
                objeto.Fecha = Nothing
            ElseIf Trim(txtFechaNC1.Text).Length <> 10 Then
                errorValidacion.SetError(lblFechaNC1, "No se ha asignado una fecha válida a la nota de crédito. Formato '10/12/2002'")
                valida = False
            Else
                Try
                    objeto.Fecha = CDate(txtFechaNC1.Text)
                Catch ex As Exception
                    errorValidacion.SetError(lblFechaNC1, "No se ha asignado una fecha válida a la nota de crédito. Formato '10/12/2002'")
                    valida = False
                End Try

            End If

            If Trim(txtFechaBoleta1.Text) = "" Then
                objeto.FechaBoleta = Nothing
            ElseIf Trim(txtFechaBoleta1.Text).Length <> 10 Then
                errorValidacion.SetError(lblFechaBoleta1, "No se ha asignado una fecha válida a la boleta. Formato '10/12/2002'")
                valida = False
            Else
                Try
                    objeto.FechaBoleta = CDate(txtFechaBoleta1.Text)
                Catch ex As Exception
                    errorValidacion.SetError(lblFechaBoleta1, "No se ha asignado una fecha válida a la boleta. Formato '10/12/2002'")
                    valida = False
                End Try

            End If

            ValidaVacioDevuelveCadena(valida, Trim(txtMotivo1.Text), objeto.Motivo, lblMotivo1,
                                      "El motivo de la nota de crédito no puede estar vacío", errorValidacion)

            Return valida
        End Function

        Private Sub dgvNotas_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvNotas.Click
            LimpiarNotas()
            With dgvNotas
                If .RowCount > 0 Then
                    Dim idDoc = .Item(0, .CurrentRow.Index).Value
                    chkNuevaNota.Checked = False

                    If .Item(1, .CurrentRow.Index).Value = "NC" Then
                        Dim notaCredito = New NCFacturaProveedor
                        For Each nc In _oListaNc
                            If (nc.IdNC = idDoc) Then
                                notaCredito = nc
                            End If
                        Next

                        If notaCredito.BoletaDev <> Nothing Then
                            txtBoleta1.Text = notaCredito.BoletaDev
                        End If

                        If notaCredito.FechaBoleta <> Nothing Then
                            txtFechaBoleta1.Text = notaCredito.FechaBoleta
                        End If

                        If notaCredito.NumNC <> Nothing Then
                            txtNumNC1.Text = notaCredito.NumNC
                        End If

                        If notaCredito.Fecha <> Nothing Then
                            txtFechaNC1.Text = notaCredito.Fecha
                        End If

                        If notaCredito.PorDescuento <> Nothing Then
                            chkDescuento.Checked = True
                        End If

                        txtSubTotalIVN.Text = notaCredito.SubTotalIV
                        txtSubTotalExN.Text = notaCredito.SubTotalEx
                        txtIVNC1.Text = notaCredito.IV
                        txtTotalNC1.Text = notaCredito.Total
                        txtMotivo1.Text = notaCredito.Motivo
                        txtIdNota.Text = notaCredito.IdNC

                        CambiarEstado(True)

                        If notaCredito.PorDescuento Then
                            chkDescuento.Visible = True
                            chkDescuento.Checked = True
                            chkDescuento.Enabled = False
                            txtFechaBoleta1.Enabled = False
                            txtBoleta1.Enabled = False
                            txtIVNC1.Enabled = False
                        End If

                        If chkCancelada.Checked Then
                            txtIVNC1.Enabled = False
                            txtTotalNC1.Enabled = False
                        End If
                        btnNC.Enabled = False
                        btnND.Enabled = False
                        _tipoNota = 1
                        txtBoleta1.Focus()
                    ElseIf .Item(1, .CurrentRow.Index).Value = "ND" Then
                        Dim notaDebito = New NDFacturaProveedor
                        For Each nd In _oListaNd
                            If (nd.IdND = idDoc) Then
                                notaDebito = nd
                            End If
                        Next

                        If notaDebito.Boleta <> Nothing Then
                            txtBoleta1.Text = notaDebito.Boleta
                        End If

                        If notaDebito.FechaBoleta <> Nothing Then
                            txtFechaBoleta1.Text = notaDebito.FechaBoleta
                        End If

                        If notaDebito.NumND <> Nothing Then
                            txtNumNC1.Text = notaDebito.NumND
                        End If

                        If notaDebito.Fecha <> Nothing Then
                            txtFechaNC1.Text = notaDebito.Fecha
                        End If

                        txtSubTotalIVN.Text = notaDebito.SubTotalIV
                        txtSubTotalExN.Text = notaDebito.SubTotalEx
                        txtIVNC1.Text = notaDebito.IV
                        txtTotalNC1.Text = notaDebito.Total
                        txtMotivo1.Text = notaDebito.Motivo
                        txtIdNota.Text = notaDebito.IdND

                        CambiarEstado(True)
                        If chkCancelada.Checked Then
                            txtIVNC1.Enabled = False
                            txtTotalNC1.Enabled = False
                        End If
                        btnNC.Enabled = False
                        btnND.Enabled = False
                        _tipoNota = 2
                        txtBoleta1.Focus()
                    Else
                        Dim abono = New AbonoFacturaProveedor
                        For Each ab In _oListaAb
                            If (ab.IdAbono = idDoc) Then
                                abono = ab
                            End If
                        Next
                        txtNumNC1.Text = abono.NumAbono
                        txtFechaNC1.Text = abono.Fecha
                        txtTotalNC1.Text = abono.Monto
                        txtMotivo1.Text = abono.Motivo

                        CambiarEstado(False)
                        btnNC.Enabled = False
                        btnND.Enabled = False
                        btnLimpiar.Enabled = True
                        _tipoNota = 3
                    End If

                End If
            End With

        End Sub

        Private Sub txtSubTotalIVN_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtSubTotalIVN.KeyDown
            If (e.KeyValue = 13) Then txtSubTotalExN.Focus()
        End Sub

        Private Sub txtSubTotalExN_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtSubTotalExN.KeyDown
            If (e.KeyValue = 13) Then txtIVNC1.Focus()
        End Sub

        Private Sub btnLimpiarNC_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnLimpiarNC.Click
            LimpiarNotas()
            CambiarEstado(False)
            _tipoNota = 0
        End Sub

        Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles EliminarToolStripMenuItem.Click
            Dim respuesta As String
            respuesta = MsgBox("Esta seguro que desea eliminar esta Nota?", vbCritical + vbYesNo, "Realizar Transacción...")

            If (respuesta = vbYes) Then
                Dim idNota = CInt(dgvNotas.Item(0, dgvNotas.CurrentCell.RowIndex).Value)
                If dgvNotas.Item(1, dgvNotas.CurrentCell.RowIndex).Value = "NC" Then
                    Dim notaCredito = New NCFacturaProveedor
                    For Each nc In _oListaNc
                        If (nc.IdNC = idNota) Then
                            notaCredito = nc
                        End If
                    Next
                    _oListaNc.Remove(notaCredito)
                    _oLogicaDocPorPagar.eliminarNC(notaCredito.IdNC)
                    dgvNotas.Rows.RemoveAt(dgvNotas.CurrentCell.RowIndex)
                ElseIf dgvNotas.Item(1, dgvNotas.CurrentCell.RowIndex).Value = "ND" Then
                    Dim notaDebito = New NDFacturaProveedor
                    For Each nd In _oListaNd
                        If (nd.IdND = idNota) Then
                            notaDebito = nd
                        End If
                    Next
                    _oListaNd.Remove(notaDebito)
                    _oLogicaDocPorPagar.eliminarND(notaDebito.IdND)
                    dgvNotas.Rows.RemoveAt(dgvNotas.CurrentCell.RowIndex)
                Else
                    MsgBox("Los abonos no pueden ser eliminados", MsgBoxStyle.Critical)
                End If

                LimpiarNotas()
            End If
        End Sub

        Private Sub txtDias_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtDias.KeyDown
            If (e.KeyValue = 13) Then cbMes.Focus()
        End Sub

        Private Sub chkDescuento_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkDescuento.CheckedChanged
            If chkDescuento.Checked Then
                txtIVNC1.Enabled = False
                txtIVNC1.Text = 0
                txtBoleta1.Enabled = False
                txtFechaBoleta1.Enabled = False
                txtMotivo1.Text = "Por Descuento"
                txtTotalNC1.Focus()
            Else
                txtIVNC1.Enabled = True
            End If
        End Sub

        Private Sub btnNC_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNC.Click
            LimpiarNotas()
            CambiarEstado(True)
            chkDescuento.Visible = True
            btnNC.Enabled = False
            btnND.Enabled = False
            _tipoNota = 1
            txtBoleta1.Focus()
        End Sub

        Private Sub CambiarEstado(ByVal estado As Boolean)
            txtBoleta1.Enabled = estado
            txtFechaBoleta1.Enabled = estado
            txtFechaNC1.Enabled = estado
            txtNumNC1.Enabled = estado
            txtIVNC1.Enabled = estado
            txtTotalNC1.Enabled = estado
            txtMotivo1.Enabled = estado
            btnAgregar.Enabled = estado
            btnLimpiarNC.Enabled = estado
        End Sub

        Private Sub btnND_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnND.Click
            LimpiarNotas()
            CambiarEstado(True)
            btnNC.Enabled = False
            btnND.Enabled = False
            _tipoNota = 2
            txtBoleta1.Focus()
        End Sub

        Private Sub FrmDocPorPagar_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            If Pantalla = 1 Then
                Dim idProveedor = CInt(FrmCancelacionDeFacturasPorProveedor.txtId_Proveedor.Text)
                FrmCancelacionDeFacturasPorProveedor.LimpiarTodo()
                FrmCancelacionDeFacturasPorProveedor.LlenarProveedor(_oLogicaProveedor.Consultar(idProveedor))
            End If
            GuardarCambios()
            Dispose()
        End Sub

        Private Sub chkAnulada_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkAnulada.CheckedChanged
            If chkAnulada.Checked Then
                txtMotivoAnulada.Enabled = True
                gbCancelada.Enabled = False
            Else
                txtMotivoAnulada.Enabled = False
                gbCancelada.Enabled = True
            End If
            txtMotivoAnulada.Text = String.Empty
        End Sub

        Private Sub chkCancelada_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkCancelada.CheckedChanged
            If chkCancelada.Checked Then
                chkAnulada.Enabled = False
                chkAnulada.Checked = False
                txtMotivoAnulada.Enabled = False
                txtMotivoAnulada.Text = String.Empty
                txtFechaCancelacion.Focus()
            End If
        End Sub

        Private Sub cbMes_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles cbMes.KeyDown
            If e.KeyValue = 13 Then
                txtIV.Focus()
            End If
        End Sub

        Private Sub txtId_Proveedor_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtId_Proveedor.KeyPress
            Dim keyAscii As Short = CShort(Asc(e.KeyChar))
            If Not keyAscii = 13 Then
                Dim oProveedor = BuscarProveedorPorId(e, txtId_Proveedor, txtNombreProveedor)
                If oProveedor.IdProveedor <> 0 Then
                    LlenarProveedor(oProveedor)
                Else
                    LimpiarTodo()
                End If
            End If
        End Sub

        Private Sub txtId_Proveedor_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtId_Proveedor.KeyDown
            If e.KeyData = Keys.Enter Then
                txtNombreProveedor.Focus()
            ElseIf e.KeyData = Keys.Enter Then
                txtNumFactura.Focus()
            End If
        End Sub

        Private Sub txtNombreProveedor_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNombreProveedor.KeyDown
            CambiarControlADataGrid(dgvProveedores, e, txtNombreProveedor, txtNombreProveedor, txtNumFactura)
        End Sub

        Private Sub txtNombreProveedor_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtNombreProveedor.KeyPress
            BuscarProveedorPorNombre(dgvProveedores, e, txtNombreProveedor, txtId_Proveedor)
        End Sub

        Private Sub BuscarFactura()
            If txtId_Proveedor.Text <> "" And txtNumFactura.Text <> "" Then
                Dim oDocPorPagar As FacturaProveedor

                oDocPorPagar = _oLogicaDocPorPagar.consultarPorNumFactura_Proveedor(CInt(txtId_Proveedor.Text), txtNumFactura.Text)
                Dim nombre = txtNombreProveedor.Text
                Dim numFactura = txtNumFactura.Text
                LimpiarTodo()
                If oDocPorPagar.IdDocPagar = 0 Then
                    txtNombreProveedor.Text = nombre
                    txtNumFactura.Text = numFactura
                    dgvProveedores.Visible = False
                Else
                    LlenarDatos(oDocPorPagar)
                End If
                txtFechaFactura.Focus()
            End If
        End Sub

        Private Sub MenuEliminar_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MenuEliminar.Opening

        End Sub

        Private Sub chkCancelada_Click(sender As Object, e As EventArgs) Handles chkCancelada.Click
            If Not chkCancelada.Checked Then
                Dim respuesta = MsgBox("Esta seguro que desea cambiar el estado a la factura?", vbCritical + vbYesNo, "Cambio estado de factura")

                If (respuesta = vbYes) Then
                    chkAnulada.Enabled = True
                    chkAnulada.Checked = False
                    txtFechaCancelacion.Enabled = True
                    txtFechaCancelacion.Text = String.Empty
                    txtMotivoAnulada.Enabled = True
                    txtMotivoAnulada.Text = String.Empty
                    gbContado.Enabled = True

                End If
            End If
        End Sub
    End Class
End Namespace