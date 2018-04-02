Imports Entidades
Imports Logica_Negocios
Imports Presentacion.Interfaz.Administrativos
Imports Presentacion.Interfaz.Mantenimiento

Namespace Interfaz.Creditos
    Public Class FrmClienteCredito

        Private ReadOnly _oUtilidades As New Utilidades
        Private ReadOnly _oLogicaPersona As New LogicaPersona
        Private ReadOnly _oLogicaCliente As New LogicaClienteCredito
        Private ReadOnly _oLogicaFacturaCredito As New LogicaFacturaCredito
        Private ReadOnly _oLogicaNotasCredito As New LogicaNotaCredito
        Public Correcta As Boolean
        Public ListaEncargados As New List(Of EncargadoClienteCredito)

        Private Sub FrmClienteCredito_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            AddHandler txtId_Credito.KeyPress, AddressOf ValidarSoloNumeros
            AddHandler txtLimite.KeyPress, AddressOf ValidarSoloNumeros
            AddHandler txtTelefono.KeyPress, AddressOf FormatoNumTelefono
            AddHandler txtOtroTelefono.KeyPress, AddressOf FormatoNumTelefono
            AddHandler txtFax.KeyPress, AddressOf FormatoNumTelefono

            AddHandler dgvBitacora.MouseDown, AddressOf seleccionaClickDerecho

            dgvBitacora.ContextMenuStrip = MnEliminarBitacora
        End Sub

        Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnLimpiar.Click
            LimpiarTodo()
        End Sub

        Private Sub LimpiarTodo()
            txtId_Credito.Text = String.Empty
            txtId_Cliente.Text = String.Empty
            txtApellido1.Text = String.Empty
            txtApellido2.Text = String.Empty
            txtCedula.Text = String.Empty
            txtNombre.Text = String.Empty
            txtNombreReal.Text = String.Empty
            txtSitioWeb.Text = String.Empty
            txtEmail.Text = String.Empty
            txtTelefono.Text = String.Empty
            txtOtroTelefono.Text = String.Empty
            txtFax.Text = String.Empty
            txtLimite.Text = String.Empty
            txtDireccion.Text = String.Empty
            txtObservaciones.Text = String.Empty
            txtTotal_Creditos.Text = String.Empty
            txtDias_Atraso.Text = String.Empty
            txtTotal_Atrasado.Text = String.Empty
            dgvClientes.Visible = False
            rbFisico.Checked = False
            rbJuridico.Checked = False
            rbNormal.Checked = True
            rbPreferencial.Checked = False
            lblMostrarEstado.Text = String.Empty
            lblMostrarEstado.ForeColor = Color.Black
            rbPrueba.Checked = False
            txtNombre.ReadOnly = False
            txtApellido1.ReadOnly = False
            txtApellido2.ReadOnly = False
            txtCedula.ReadOnly = False
            dgvBitacora.Rows.Clear()
            dgvCreacion.Rows.Clear()
            errorCredito.Clear()
            CambiarTodo(True)
            txtNuevo.Text = String.Empty
            Correcta = False
            chkIncluirEnCobro.Enabled = False
            txtNombre.Focus()
        End Sub

        Private Sub txtApellido1_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtApellido1.KeyDown
            If e.KeyData = Keys.Enter Then txtApellido2.Focus()
        End Sub

        Private Sub txtApellido2_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtApellido2.KeyDown
            If e.KeyData = Keys.Enter Then txtNombreReal.Focus()
        End Sub

        Private Sub txtCedula_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtCedula.KeyDown
            If e.KeyData = Keys.Enter Then gbTipo_Cedula.Focus()
        End Sub

        Private Sub txtLimite_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtLimite.KeyDown
            If e.KeyData = Keys.Enter Then txtDireccion.Focus()
        End Sub

        Private Sub txtDireccion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDireccion.KeyDown
            If e.KeyCode = Keys.Enter Then
                txtObservaciones.Focus()
                txtObservaciones.DeselectAll()
                txtObservaciones.SelectionStart = txtDireccion.TextLength
                e.Handled = True
                e.SuppressKeyPress = True
            End If
        End Sub

        Public Sub ActualizarCliente()
            ActualizarPersona()
            CargarOtrosDatos(0, CInt(txtId_Cliente.Text))
        End Sub

        Public Sub ActualizarPersona()
            Dim oPersona As Persona
            oPersona = _oLogicaPersona.Consultar(CInt(txtId_Cliente.Text))
            txtCedula.Text = oPersona.Cedula
            txtNombre.Text = oPersona.Nombre
            txtApellido1.Text = oPersona.PrimerApellido
            txtApellido2.Text = oPersona.SegundoApellido
            txtNombre.ReadOnly = True
            txtApellido1.ReadOnly = True
            txtApellido2.ReadOnly = True
            txtCedula.ReadOnly = True
        End Sub

        Private Sub btnCorregir_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCorregir.Click
            If txtId_Cliente.Text <> "" Then
                FrmModificarCliente.IdCliente = CInt(txtId_Cliente.Text)
                FrmModificarCliente.Formulario = 2
                FrmModificarCliente.ShowDialog()
            Else
                MessageBox.Show("Debe de seleccionar un cliente antes de presionar corregir", "Corregir cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Sub

        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            ValidarCliente()
        End Sub

        Private Sub ValidarCliente()
            errorCredito.Clear()
            Dim valida = True
            Dim oCliente As New ClienteCredito
            Dim tipo As Integer

            ValidaVacioDevuelveCadena(valida, Trim(txtDireccion.Text), oCliente.OtraInformacion.Direccion, lblDireccion,
                                      "La dirección no puede estar vacía", errorCredito)
            ValidaVacioCeroDevuelveCadena(valida, Trim(txtCedula.Text), oCliente.Cedula, lblCedula,
                                          "La cédula no puede estar vacía o ser cero", errorCredito)
            ValidaVacioDevuelveDouble(valida, Trim(txtLimite.Text), oCliente.Limite, lblLimite,
                                      "Debe agregar el limite máximo del crédito", errorCredito)


            If rbFisico.Checked Or rbJuridico.Checked Then
                If rbFisico.Checked Then
                    oCliente.EnteFisico = True

                    ValidaVacioDevuelveCadena(valida, Trim(txtApellido1.Text), oCliente.PrimerApellido, lblApellido1,
                                              "El primer apellido no puede estar vacío", errorCredito)
                    ValidaVacioDevuelveCadena(valida, Trim(txtApellido2.Text), oCliente.SegundoApellido, lblApellido2,
                                              "El segundo apellido no puede estar vacío", errorCredito)
                Else
                    oCliente.EnteFisico = False
                    oCliente.PrimerApellido = "-"
                    oCliente.SegundoApellido = "-"
                End If
            Else
                errorCredito.SetError(gbTipo_Cedula, "Debe seleccionar un tipo de cliente")
                valida = False
            End If

            Dim idPersona As Integer = 0

            If txtId_Cliente.Text <> "" Then
                idPersona = CInt(txtId_Cliente.Text)
            End If

            oCliente.OtraInformacion.Observaciones = UCase(txtObservaciones.Text)
            oCliente.OtraInformacion.SitioWeb = txtSitioWeb.Text
            ValidarTelefonoPrincipal(valida, txtTelefono.Text, oCliente, errorCredito, lblTelefono)
            ValidarOtroTelefono(valida, txtOtroTelefono.Text, oCliente, errorCredito, lblOtroTelefono)
            ValidarFaxPrincipal(valida, txtFax.Text, oCliente, errorCredito, lblFax)
            ValidarEmail(valida, txtEmail.Text, oCliente, errorCredito, lblEmail)

            If rbPreferencial.Checked Then
                oCliente.Tipo = ClienteCredito.ListaTipo.Preferencial
            ElseIf rbNormal.Checked Then
                oCliente.Tipo = ClienteCredito.ListaTipo.Normal
            ElseIf rbPrueba.Checked Then
                oCliente.Tipo = ClienteCredito.ListaTipo.Prueba
            End If

            If Trim(txtTotal_Creditos.Text) <> "" Then
                oCliente.TotalCreditos = CDbl(txtTotal_Creditos.Text)
            Else
                oCliente.TotalCreditos = 0
            End If

            If Trim(txtTotal_Atrasado.Text) <> "" Then
                oCliente.TotalAtrasado = CDbl(txtTotal_Atrasado.Text)
            Else
                oCliente.TotalAtrasado = 0
            End If

            If Trim(txtDias_Atraso.Text) <> "" Then
                oCliente.DiasAtrasado = CInt(txtDias_Atraso.Text)
            Else
                oCliente.DiasAtrasado = 0
            End If

            If lblMostrarEstado.ForeColor = Color.Red Then
                oCliente.Estado = ClienteCredito.ListaEstado.Cerrado
            ElseIf lblMostrarEstado.ForeColor = Color.Yellow Then
                oCliente.Estado = ClienteCredito.ListaEstado.Congelado
            Else
                oCliente.Estado = ClienteCredito.ListaEstado.Abierto
            End If

            If txtId_Cliente.Text = "" And txtId_Credito.Text = "" Then
                If Trim(txtNombre.Text) = "" Then
                    errorCredito.SetError(lblNombre, "El nombre no puede estar vacío")
                    valida = False
                Else
                    oCliente.Nombre = RTrim(UCase(txtNombre.Text))
                    oCliente.IdPersona = 0
                    tipo = 0
                End If
            ElseIf txtId_Credito.Text = "" And txtId_Cliente.Text <> "" Then
                oCliente.IdPersona = CInt(txtId_Cliente.Text)
                oCliente.IdCredito = 0
                oCliente.OtraInformacion.IdPersona = CInt(txtId_Cliente.Text)
                tipo = 0
            ElseIf txtId_Credito.Text <> "" And txtId_Cliente.Text <> "" Then
                oCliente.IdPersona = CInt(txtId_Cliente.Text)
                oCliente.IdCredito = CInt(txtId_Credito.Text)
                oCliente.OtraInformacion.IdPersona = CInt(txtId_Cliente.Text)
                tipo = 1
            End If

            oCliente.NombreReal = Trim(UCase(txtNombreReal.Text))
            oCliente.OtraInformacion.SitioWeb = Trim(UCase(txtSitioWeb.Text))
            oCliente.IncluirEnCobro = chkIncluirEnCobro.Checked
            oCliente.Encargados = ListaEncargados
            If valida Then
                _oLogicaCliente.Insertar(oCliente)
                If tipo = 0 Then
                    MsgBox("Crédito creado con éxito")
                ElseIf tipo = 1 Then
                    MsgBox("Crédito modificado con éxito")
                End If

                LimpiarTodo()
            End If
        End Sub

        Private Sub dgvClientes_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvClientes.Click
            txtId_Cliente.Text = dgvClientes.Item(0, dgvClientes.CurrentRow.Index).Value
            LlenarDatos()
        End Sub

        Private Sub dgvClientes_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles dgvClientes.KeyDown
            If e.KeyData = Keys.Enter Then
                txtId_Cliente.Text = dgvClientes.Item(0, dgvClientes.CurrentRow.Index).Value
                LlenarDatos()
            End If
        End Sub

        Public Sub LlenarDatos()
            ActualizarCliente()
            dgvClientes.Visible = False
        End Sub

        'tipo = 0 Id_Persona, tipo = 1 Id_Credito
        Private Sub CargarOtrosDatos(ByVal tipo As Integer, ByVal id As Integer, Optional ByVal idCredito As Integer = 0)
            Dim oCliente As ClienteCredito
            oCliente = _oLogicaCliente.ConsultarPorIdPersona(id)

            If oCliente.IdCredito <> 0 Then

                cargarInformacion_Personal(oCliente.OtraInformacion)
                txtLimite.Text = _oUtilidades.PasarMoneda(oCliente.Limite)
                txtTotal_Creditos.Text = _oUtilidades.PasarMoneda(oCliente.TotalCreditos)
                txtNombreReal.Text = oCliente.NombreReal
                chkIncluirEnCobro.Checked = oCliente.IncluirEnCobro

                With dgvBitacora
                    For i = 0 To oCliente.ListaBitacora.Count - 1
                        .Rows.Insert(0, oCliente.ListaBitacora(i).FechaHora)
                        .Rows.Insert(1, oCliente.ListaBitacora(i).Descripcion)
                    Next

                    For i = 0 To .Rows.Count - 2
                        .Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(196, 173, 151)
                        .Rows(i + 1).DefaultCellStyle.BackColor = Color.FromArgb(196, 173, 151)
                        i = i + 3
                    Next

                End With

                If oCliente.FechaCreacion.ToString = "01/01/0001 12:00:00 a.m." Then
                    dgvCreacion.Rows.Insert(0, "ANTES DE AGOSTO DEL 2012")
                    dgvCreacion.Rows.Insert(1, "FECHA DE CREACION DE CREDITO")
                    dgvCreacion.Rows(0).Selected = False
                Else
                    dgvCreacion.Rows.Insert(0, oCliente.FechaCreacion)
                    dgvCreacion.Rows.Insert(1, "FECHA DE CREACION DE CREDITO")
                    dgvCreacion.Rows(0).Selected = False
                End If


                If oCliente.EnteFisico Then
                    rbFisico.Checked = True
                Else
                    rbJuridico.Checked = True
                End If

                If tipo = 0 Then
                    txtId_Credito.Text = oCliente.IdCredito
                    calcularDiasMonto_Atrasado(oCliente.IdCredito)
                ElseIf tipo = 1 Then
                    txtId_Cliente.Text = oCliente.IdPersona
                End If

                If idCredito > 0 Then
                    calcularDiasMonto_Atrasado(idCredito)
                End If

                If oCliente.Estado = ClienteCredito.ListaEstado.Abierto Then
                    lblMostrarEstado.Text = "Crédito Abierto"
                    lblMostrarEstado.ForeColor = Color.Green

                    CambiarTodo(True)
                    If oCliente.Tipo = ClienteCredito.ListaTipo.Preferencial Then
                        rbPreferencial.Checked = True
                    ElseIf oCliente.Tipo = ClienteCredito.ListaTipo.Normal Then
                        rbNormal.Checked = True
                    ElseIf oCliente.Tipo = ClienteCredito.ListaTipo.Prueba Then
                        rbPrueba.Checked = True
                    End If

                ElseIf oCliente.Estado = ClienteCredito.ListaEstado.Cerrado Then
                    lblMostrarEstado.Text = "Crédito Cerrado"
                    lblMostrarEstado.ForeColor = Color.Red
                    CambiarTodo(False)
                    chkIncluirEnCobro.Enabled = True
                Else
                    lblMostrarEstado.Text = "Crédito Congelado"
                    lblMostrarEstado.ForeColor = Color.Yellow
                    CambiarTodo(True)
                    chkIncluirEnCobro.Enabled = True
                End If

                ListaEncargados = oCliente.Encargados
                txtNombreReal.Focus()
            Else
                Dim respuesta As String

                respuesta = MsgBox("Este cliente no tiene un crédito, desea abrirle uno?", vbCritical + vbYesNo, "Abrir crédito...")

                If (respuesta = vbYes) Then

                    Dim oPersona As Persona
                    oPersona = _oLogicaPersona.Consultar(id)

                    If oPersona.IdPersona <> 0 Then
                        cargarInformacion_Personal(oPersona.OtraInformacion)
                    End If
                    Limpiar()
                    txtNombreReal.Focus()
                Else
                    LimpiarTodo()
                    rbNormal.Checked = False
                    txtNombre.Focus()
                End If

            End If

        End Sub

        Private Sub CambiarTodo(ByVal estado As Boolean)
            rbPreferencial.Enabled = estado
            rbNormal.Enabled = estado
            rbPrueba.Enabled = estado
            btnCorregir.Enabled = estado
            txtNombreReal.Enabled = estado
            txtId_Credito.Enabled = estado
            txtId_Cliente.Enabled = estado
            txtLimite.Enabled = estado
            rbFisico.Enabled = estado
            rbJuridico.Enabled = estado
            'dgvBitacora.Enabled = estado
            txtNombre.Enabled = estado
            txtApellido1.Enabled = estado
            txtApellido2.Enabled = estado
            txtCedula.Enabled = estado
        End Sub
        Private Sub Limpiar()
            txtLimite.Text = String.Empty
            txtTotal_Creditos.Text = String.Empty
            txtDias_Atraso.Text = String.Empty
            txtTotal_Atrasado.Text = String.Empty
            dgvClientes.Visible = False
            rbFisico.Checked = False
            rbJuridico.Checked = False
            rbNormal.Checked = True
            rbPreferencial.Checked = False
            lblMostrarEstado.Text = String.Empty
            rbPrueba.Checked = False
            dgvBitacora.Rows.Clear()
            dgvCreacion.Rows.Clear()
            txtNuevo.Text = String.Empty
            errorCredito.Clear()
            txtId_Credito.Text = String.Empty
        End Sub
        Public Sub calcularDiasMonto_Atrasado(ByVal idCredito As Integer)
            Dim oListFacturas As List(Of FacturaCredito)
            Dim totalAtrasados As Double
            Dim abonos As Double
            Dim notasCredito As Double
            Dim maxDias As Integer = 0

            oListFacturas = _oLogicaFacturaCredito.consultarFacturasPorId_Credito(idCredito)

            With oListFacturas

                For i As Integer = 0 To oListFacturas.Count - 1
                    Dim dias = DateDiff("d", oListFacturas(i).Fecha, Now)
                    Dim atraso As Integer
                    Dim montoConAbonos As Double

                    abonos = 0
                    For j = 0 To oListFacturas(i).Abonos.Count - 1
                        abonos = abonos + oListFacturas(i).Abonos(j).Monto
                    Next

                    notasCredito = 0
                    For j = 0 To oListFacturas(i).NotasCredito.Count - 1
                        notasCredito = notasCredito + oListFacturas(i).NotasCredito(j).Monto
                    Next

                    montoConAbonos = oListFacturas(i).Monto - abonos - notasCredito

                    atraso = dias - oListFacturas(i).NumDias
                    If atraso > 0 Then
                        totalAtrasados = totalAtrasados + montoConAbonos

                        If maxDias < atraso Then
                            maxDias = atraso
                        End If
                    End If

                Next

                Dim oNcGenerales = _oLogicaNotasCredito.ConsultarGeneral(idCredito)
                Dim totalNcGenerales As Double = 0
                For i = 0 To oNcGenerales.Count - 1
                    totalNcGenerales = totalNcGenerales + oNcGenerales(i).Monto
                Next

                txtTotal_Atrasado.Text = _oUtilidades.PasarMoneda(totalAtrasados - totalNcGenerales)
                txtDias_Atraso.Text = maxDias
            End With

        End Sub

        Private Sub txtNuevo_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNuevo.KeyDown
            If e.KeyData = Keys.Enter Then
                If Trim(txtNuevo.Text <> "") Then
                    If Trim(txtId_Credito.Text) <> "" Then
                        LlenarBitacora(UCase(txtNuevo.Text))
                    Else
                        MsgBox("El cliente de crédito no existe, inserte el cliente antes de agregar algo a la bitácora")
                    End If


                End If

            End If
        End Sub

        Private Sub LlenarBitacora(ByVal texto As String)
            With dgvBitacora

                Dim oBitacora As New Bitacora
                oBitacora.IdCredito = CInt(txtId_Credito.Text)
                oBitacora.FechaHora = Now.ToString
                oBitacora.Descripcion = texto
                _oLogicaCliente.InsertarBitacora(oBitacora)

                .Rows.Insert(0, Now.ToString)
                .Rows.Insert(1, texto)

                For i = 0 To .Rows.Count - 2
                    .Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255)
                    .Rows(i + 1).DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255)
                Next

                For i = 0 To .Rows.Count - 2
                    .Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(196, 173, 151)
                    .Rows(i + 1).DefaultCellStyle.BackColor = Color.FromArgb(196, 173, 151)
                    i = i + 3
                Next

                If .Rows.Count > 0 Then .Rows(.CurrentRow.Index).Selected = False

                txtNuevo.Text = String.Empty
            End With

        End Sub

        Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles EliminarToolStripMenuItem.Click
            With dgvBitacora
                If .RowCount > 0 Then
                    Dim oBitacora As New Bitacora
                    oBitacora.IdCredito = CInt(txtId_Credito.Text)

                    Dim num As Double = .CurrentRow.Index

                    If num Mod 2 = 0 Then
                        oBitacora.FechaHora = .Item(0, .CurrentRow.Index).Value
                    Else
                        oBitacora.FechaHora = .Item(0, (.CurrentRow.Index - 1)).Value
                    End If

                    Dim elimina As Integer
                    elimina = MessageBox.Show("Esta seguro q desea eliminar está línea de la bitácora?", "Eliminar línea de bitácora", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    If elimina = vbYes Then
                        Try
                            _oLogicaCliente.EliminarBitacora(oBitacora)

                            Dim oListaBitacoras As List(Of Bitacora)
                            oListaBitacoras = _oLogicaCliente.ConsultarBitacora(CInt(txtId_Credito.Text))

                            With dgvBitacora
                                .Rows.Clear()
                                For i = 0 To oListaBitacoras.Count - 1
                                    .Rows.Insert(0, oListaBitacoras(i).FechaHora)
                                    .Rows.Insert(1, oListaBitacoras(i).Descripcion)
                                Next

                                For i = 0 To .Rows.Count - 2
                                    .Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(196, 173, 151)
                                    .Rows(i + 1).DefaultCellStyle.BackColor = Color.FromArgb(196, 173, 151)
                                    i = i + 3
                                Next

                                If .Rows.Count > 0 Then .Rows(.CurrentRow.Index).Selected = False
                            End With
                        Catch ex As Exception
                            MessageBox.Show(ex.Message, "Eliminar Categoría", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    End If
                End If
            End With
        End Sub

        Private Sub FrmClienteCredito_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub

        Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnEliminar.Click
            Dim respuesta As String

            respuesta = MsgBox("Esta seguro que desea eliminar este crédito?", vbCritical + vbYesNo, "Eliminar crédito...")

            If (respuesta = vbYes) Then
                If IsNumeric(txtId_Cliente.Text) And IsNumeric(txtId_Credito.Text) Then
                    Dim oFacturasCredito = _oLogicaFacturaCredito.facturas_Credito_Pendientes(CInt(txtId_Credito.Text))

                    If oFacturasCredito = 0 Then
                        Dim oNcGenerales = _oLogicaNotasCredito.NC_Generales_Pendientes(CInt(txtId_Credito.Text))

                        If oNcGenerales = 0 Then
                            _oLogicaCliente.eliminarCliente_Credito(CInt(txtId_Credito.Text), CInt(txtId_Cliente.Text))
                            MsgBox("Cliente de crédito eliminado con éxito", MsgBoxStyle.Information)
                            LimpiarTodo()
                        Else
                            MsgBox("Este cliente tiene " & oNcGenerales & " nota(s) de crédito generale(s) pendiente(s) por lo que no puede ser eliminado", MsgBoxStyle.Critical)
                        End If

                    Else
                        MsgBox("Este cliente tiene " & oFacturasCredito & " factura(s) de crédito pendiente(s) por lo que no puede ser eliminado", MsgBoxStyle.Critical)
                    End If


                Else
                    MsgBox("Primero debe seleccionar el cliente a eliminar", MsgBoxStyle.Information)
                End If
            End If

        End Sub

        Private Sub txtNombreReal_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNombreReal.KeyDown
            If e.KeyData = Keys.Enter Then txtId_Credito.Focus()
        End Sub

        Private Sub txtSitioWeb_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtSitioWeb.KeyDown
            If e.KeyData = Keys.Enter Then txtLimite.Focus()
        End Sub

        Private Sub cargarInformacion_Personal(ByVal oInformacionPersonal As InformacionPersonal)
            txtDireccion.Text = oInformacionPersonal.Direccion
            txtObservaciones.Text = oInformacionPersonal.Observaciones
            txtTelefono.Text = oInformacionPersonal.TelefonoPrincipal
            txtOtroTelefono.Text = oInformacionPersonal.OtroTelefono
            txtFax.Text = oInformacionPersonal.FaxPrincipal
            txtEmail.Text = oInformacionPersonal.Email
            txtSitioWeb.Text = oInformacionPersonal.SitioWeb
        End Sub

        Private Sub btnCerrarCredito_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCerrarCredito.Click
            If txtId_Credito.Text <> "" And txtNombre.Text <> "" Then

                Dim motivo = InputBox("Está seguro que desea CERRAR este crédito de " & txtNombre.Text & " Escriba el motivo por el cúal lo va a cerrar")

                If motivo <> "" Then
                    FrmInicioSesion.Ventana = 2
                    FrmInicioSesion.ShowDialog()

                    If Correcta Then
                        LlenarBitacora(motivo)
                        lblMostrarEstado.Text = "Crédito Cerrado"
                        lblMostrarEstado.ForeColor = Color.Red
                        ValidarCliente()
                    End If

                End If
            End If

        End Sub

        Private Sub rbPreferencial_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbPreferencial.Click
            If rbPreferencial.Checked Then
                FrmInicioSesion.Ventana = 2
                FrmInicioSesion.ShowDialog()

                If Not Correcta Then
                    rbNormal.Checked = True
                End If

            End If
        End Sub

        Private Sub btnCongelar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCongelar.Click
            If txtId_Credito.Text <> "" And txtNombre.Text <> "" Then

                Dim motivo = InputBox("Está seguro que desea CONGELAR este crédito de " & txtNombre.Text & " Escriba el motivo por el cúal lo va a congelar")

                If motivo <> "" Then
                    FrmInicioSesion.Ventana = 2
                    FrmInicioSesion.ShowDialog()

                    If Correcta Then
                        LlenarBitacora(motivo)
                        lblMostrarEstado.Text = "Crédito Congelado"
                        lblMostrarEstado.ForeColor = Color.Yellow
                        ValidarCliente()
                    End If

                End If
            End If
        End Sub

        Private Sub btnReactivar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnReactivar.Click
            If txtId_Credito.Text <> "" And txtNombre.Text <> "" Then

                Dim motivo = InputBox("Está seguro que desea ACTIVAR de nuevo este crédito de " & txtNombre.Text & " Escriba el motivo por el cúal lo va a activar")

                If motivo <> "" Then
                    FrmInicioSesion.Ventana = 2
                    FrmInicioSesion.ShowDialog()

                    If Correcta Then
                        LlenarBitacora(motivo)
                        lblMostrarEstado.Text = "Crédito Abierto"
                        lblMostrarEstado.ForeColor = Color.Green
                        ValidarCliente()
                    End If

                End If
            End If
        End Sub

        Private Sub txtNombre_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
            cambiarControlADataGrid(dgvClientes, e, txtNombre, txtNombre, txtNombre)
        End Sub

        Private Sub txtNombre_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
            BuscarPersonaPorNombre(dgvClientes, e, txtNombre, txtApellido1, txtId_Credito, txtApellido1)
        End Sub

        Private Sub btnInformacionPersonal_Click(sender As Object, e As EventArgs) Handles btnInformacionPersonal.Click
            If (txtId_Cliente.Text <> "") Then
                FrmEncargadosCliente.LlenarEncargados(ListaEncargados)
                FrmEncargadosCliente.ShowDialog()
            Else
                MsgBox("Debe seleccionar un cliente credito", MsgBoxStyle.Information, "Encargagos del cliente credito")
            End If
        End Sub

        Private Sub txtTelefono_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTelefono.KeyDown
            If e.KeyData = Keys.Enter Then txtOtroTelefono.Focus()
        End Sub

        Private Sub txtOtroTelefono_KeyDown(sender As Object, e As KeyEventArgs) Handles txtOtroTelefono.KeyDown
            If e.KeyData = Keys.Enter Then txtFax.Focus()
        End Sub

        Private Sub txtFax_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFax.KeyDown
            If e.KeyData = Keys.Enter Then txtEmail.Focus()
        End Sub

        Private Sub txtEmail_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEmail.KeyDown
            If e.KeyData = Keys.Enter Then txtSitioWeb.Focus()
        End Sub

        Private Sub btnDesbloquear_Click(sender As Object, e As EventArgs) Handles btnDesbloquear.Click
            If (txtId_Credito.Text <> "") Then
                _oLogicaCliente.ModificarBloqueo(CInt(txtId_Credito.Text), 0)
                MsgBox("Cliente desbloqueado con éxito", MsgBoxStyle.Information, "Cliente crédito")
            End If
        End Sub
    End Class
End Namespace