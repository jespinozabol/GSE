Imports Entidades
Imports Logica_Negocios

Namespace Interfaz.Mantenimiento
    Public Class FrmClienteRepetido

        Private ReadOnly _oLogicaPersona As New LogicaPersona
        Private ReadOnly _oLogicaCredito As New LogicaClienteCredito
        Private ReadOnly _oLogicaFactura As New LogicaFacturar
        Private ReadOnly _oLogicaFacturaCredito As New LogicaFacturaCredito
        Private ReadOnly _oUtilidades As New Utilidades
        Private ReadOnly _oLogicaReferencia As New LogicaReferencia
        Private ReadOnly _oLogicaEmpleado As New LogicaEmpleadoOtro
        Private _id1 As Integer
        Private _id2 As Integer

        Private Sub LlenarCliente1(ByVal oCliente1 As Persona)

            txtNombre1.Text = oCliente1.Nombre
            txtPrimerApellido1.Text = oCliente1.PrimerApellido
            txtSegundoApellido1.Text = oCliente1.SegundoApellido
            txtCedula1.Text = oCliente1.Cedula
            cargarInformacion_PersonalCliente1(oCliente1.OtraInformacion)

            Dim credito = _oLogicaCredito.ConsultarPorIdPersona(oCliente1.IdPersona)

            If credito.IdPersona <> 0 Then
                lblMostrarId_Credito1.Text = credito.IdCredito
                If credito.Estado Then
                    lblMostrarEstado1.Text = "Abierto"
                Else
                    lblMostrarEstado1.Text = "Cerrado"
                End If
                txtLimite1.Text = _oUtilidades.PasarMoneda(credito.Limite)
                If credito.EnteFisico Then
                    rbFisico1.Checked = True
                Else
                    rbJuridico1.Checked = True
                End If
                If credito.Tipo = ClienteCredito.ListaTipo.Normal Then
                    rbNormal1.Checked = True
                ElseIf credito.Tipo = ClienteCredito.ListaTipo.Preferencial Then
                    rbPreferencial1.Checked = True
                Else
                    rbPrueba1.Checked = True
                End If

                Dim facturasCredito = _oLogicaFacturaCredito.consultarFacturasPorId_Credito(credito.IdCredito)
                Dim total As Double

                For i As Integer = 0 To facturasCredito.Count - 1
                    tblFactCredito1.Rows.Add(facturasCredito(i).NumFactura, facturasCredito(i).Fecha, facturasCredito(i).Monto)
                    total += facturasCredito(i).Monto
                Next

                lblMostrarCantidad1.Text = facturasCredito.Count
                lblMostrarTotal1.Text = "¢" & _oUtilidades.PasarMoneda(total)
                For Each encargado In credito.Encargados
                    dgvEncargado1.Rows.Add(encargado.IdEncargado, encargado.Nombre)
                Next
            Else
                lblMostrarId_Credito1.Text = String.Empty
                lblMostrarEstado1.Text = String.Empty
                txtLimite1.Text = String.Empty
                rbFisico1.Checked = False
                rbJuridico1.Checked = False
                rbNormal1.Checked = False
                rbPreferencial1.Checked = False
                rbPrueba1.Checked = False
                tblFactCredito1.Rows.Clear()
                lblMostrarCantidad1.Text = String.Empty
                lblMostrarTotal1.Text = String.Empty
            End If

            LlenarFacturasContado(lblMostrarCantContado1, lblMostrarUltimaCompra1, oCliente1.IdPersona)
            LlenarReferencia(lblMuestraCodRef1, lblMuestraActivoRef1, lblMuestraUltimoCalRef1, oCliente1.IdPersona)
            LlenarEmpleadoOtro(lblMuestraCodEmpleado1, lblMuestraPuestoEmpleado1, oCliente1.IdPersona)
        End Sub

        Private Sub cargarInformacion_PersonalCliente1(ByVal oInformacionPersonal As InformacionPersonal)
            txtDireccion1.Text = oInformacionPersonal.Direccion
            txtObservaciones1.Text = oInformacionPersonal.Observaciones
            txtTelPrincipal1.Text = oInformacionPersonal.TelefonoPrincipal
            txtOtroTelefono1.Text = oInformacionPersonal.OtroTelefono
            txtFax1.Text = oInformacionPersonal.FaxPrincipal
            txtEmail1.Text = oInformacionPersonal.Email
            txtSitioWeb1.Text = oInformacionPersonal.SitioWeb
        End Sub

        Private Sub LlenarCliente2(ByVal oCliente2 As Persona)

            txtNombre2.Text = oCliente2.Nombre
            txtPrimerApellido2.Text = oCliente2.PrimerApellido
            txtSegundoApellido2.Text = oCliente2.SegundoApellido
            txtCedula2.Text = oCliente2.Cedula
            cargarInformacion_PersonalCliente2(oCliente2.OtraInformacion)

            Dim credito = _oLogicaCredito.ConsultarPorIdPersona(oCliente2.IdPersona)

            If credito.IdPersona <> 0 Then
                lblMostrarId_Credito2.Text = credito.IdCredito
                btnTrasladarCredito.Enabled = True
                If credito.Estado Then
                    lblMostrarEstado2.Text = "Abierto"
                Else
                    lblMostrarEstado2.Text = "Cerrado"
                End If
                txtLimite2.Text = _oUtilidades.PasarMoneda(credito.Limite)
                If credito.EnteFisico Then
                    rbFisico2.Checked = True
                Else
                    rbJuridico2.Checked = True
                End If
                If credito.Tipo = ClienteCredito.ListaTipo.Normal Then
                    rbNormal2.Checked = True
                ElseIf credito.Tipo = ClienteCredito.ListaTipo.Preferencial Then
                    rbPreferencial2.Checked = True
                Else
                    rbPrueba2.Checked = True
                End If
                txtSitioWeb2.Text = credito.OtraInformacion.SitioWeb

                Dim facturasCredito = _oLogicaFacturaCredito.consultarFacturasPorId_Credito(credito.IdCredito)
                Dim total As Double

                For i As Integer = 0 To facturasCredito.Count - 1
                    tblFactCredito2.Rows.Add(facturasCredito(i).NumFactura, facturasCredito(i).Fecha, facturasCredito(i).Monto)
                    total += facturasCredito(i).Monto
                Next

                lblMostrarCantidad2.Text = facturasCredito.Count
                lblMostrarTotal2.Text = "¢" & _oUtilidades.PasarMoneda(total)
                For Each encargado In credito.Encargados
                    dgvEncargado2.Rows.Add(encargado.IdEncargado, encargado.Nombre)
                Next
                If credito.Encargados.Count > 0 Then
                    btnTrasladarTodosEncargados.Enabled = True
                    btnTrasladarEncargado.Enabled = True
                End If
            Else
                lblMostrarId_Credito2.Text = String.Empty
                lblMostrarEstado2.Text = String.Empty
                txtLimite2.Text = String.Empty
                rbFisico2.Checked = False
                rbJuridico2.Checked = False
                rbNormal2.Checked = False
                rbPreferencial2.Checked = False
                rbPrueba2.Checked = False
                tblFactCredito2.Rows.Clear()
                lblMostrarCantidad2.Text = String.Empty
                lblMostrarTotal2.Text = String.Empty
                btnTrasladarCredito.Enabled = False
            End If

            LlenarFacturasContado(lblMostrarCantContado2, lblMostrarUltimaCompra2, oCliente2.IdPersona)

            If Trim(lblMostrarCantContado2.Text) <> "" And Trim(lblMostrarCantContado2.Text) <> "0" Then
                btnTrasladarFacturasContado.Enabled = True
            Else
                btnTrasladarFacturasContado.Enabled = False
            End If

            LlenarReferencia(lblMuestraCodRef2, lblMuestraActivoRef2, lblMuestraUltimoCalRef2, oCliente2.IdPersona)

            If Trim(lblMuestraCodRef2.Text) <> "" Then
                btnTrasladarReferencia2.Enabled = True
            Else
                btnTrasladarReferencia2.Enabled = False
            End If

            LlenarEmpleadoOtro(lblMuestraCodEmpleado2, lblMuestraPuesto2, oCliente2.IdPersona)

            If Trim(lblMuestraCodEmpleado2.Text) <> "" Then
                btnTrasladarEmpleado2.Enabled = True
            Else
                btnTrasladarEmpleado2.Enabled = False
            End If

        End Sub

        Private Sub LlenarFacturasContado(ByVal lblMostrarCantContado As Label, ByVal lblMostrarUltimaCompra As Label, ByVal idPersona As Integer)
            lblMostrarCantContado.Text = _oLogicaFactura.consultarCantidadFacturasContado(idPersona)
            lblMostrarUltimaCompra.Text = _oLogicaFactura.consultarUltima_Compra(idPersona)
        End Sub

        Private Sub LlenarReferencia(ByVal lblMuestraCodRef As Label, ByVal lblMuestraActivoRef As Label, ByVal lblMuestraUltimoCalRef As Label, ByVal idPersona As Integer)

            Dim oReferencia = _oLogicaReferencia.ConsultarPorId_Persona(idPersona)

            If oReferencia.IdReferencia > 1 Then
                lblMuestraCodRef.Text = oReferencia.IdReferencia
                If oReferencia.Activo Then
                    lblMuestraActivoRef.Text = "Sí"
                Else
                    lblMuestraActivoRef.Text = "No"
                End If
                lblMuestraUltimoCalRef.Text = oReferencia.UltimoCalculo
            Else
                lblMuestraCodRef.Text = String.Empty
                lblMuestraActivoRef.Text = String.Empty
                lblMuestraUltimoCalRef.Text = String.Empty
            End If

        End Sub

        Private Sub LlenarEmpleadoOtro(ByVal lblMuestraCodEmpleado As Label, ByVal lblMuestraPuestoEmpleado As Label, ByVal idPersona As Integer)

            Dim oEmpleadoOtro = _oLogicaEmpleado.consultarPorIdPersona(idPersona)

            If oEmpleadoOtro.IdPersona <> 0 Then
                lblMuestraCodEmpleado.Text = oEmpleadoOtro.IdEmpleado
                lblMuestraPuestoEmpleado.Text = oEmpleadoOtro.Tipo
            Else
                lblMuestraCodEmpleado.Text = String.Empty
                lblMuestraPuestoEmpleado.Text = String.Empty
            End If

        End Sub

        Private Sub cargarInformacion_PersonalCliente2(ByVal oInformacionPersonal As InformacionPersonal)
            txtDireccion2.Text = oInformacionPersonal.Direccion
            txtObserv2.Text = oInformacionPersonal.Observaciones
            txtTelPrincipal2.Text = oInformacionPersonal.TelefonoPrincipal
            txtOtroTelefono2.Text = oInformacionPersonal.OtroTelefono
            txtFax2.Text = oInformacionPersonal.FaxPrincipal
            txtEmail2.Text = oInformacionPersonal.Email
            txtSitioWeb2.Text = oInformacionPersonal.SitioWeb
        End Sub

        Private Sub txtNombre1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtNombre1.Click
            LimpiarCliente1()
            txtNombre1.Focus()
        End Sub

        Private Sub LimpiarCliente1()
            txtNombre1.Text = String.Empty
            txtId_Cliente1.Text = String.Empty
            txtPrimerApellido1.Text = String.Empty
            txtSegundoApellido1.Text = String.Empty
            txtCedula1.Text = String.Empty
            dgvCliente1.Visible = False
            txtEmail1.Text = String.Empty
            txtSitioWeb1.Text = String.Empty
            txtDireccion1.Text = String.Empty
            txtObservaciones1.Text = String.Empty
            lblMostrarId_Credito1.Text = String.Empty
            lblMostrarEstado1.Text = String.Empty
            txtLimite1.Text = String.Empty
            txtTelPrincipal1.Text = String.Empty
            txtFax1.Text = String.Empty
            txtOtroTelefono1.Text = String.Empty
            rbFisico1.Checked = False
            rbJuridico1.Checked = False
            rbNormal1.Checked = False
            rbPreferencial1.Checked = False
            rbPrueba1.Checked = False
            lblMostrarCantContado1.Text = String.Empty
            lblMostrarUltimaCompra1.Text = String.Empty
            lblMostrarCantidad1.Text = String.Empty
            lblMostrarTotal1.Text = String.Empty
            tblFactCredito1.Rows.Clear()
            lblMuestraActivoRef1.Text = String.Empty
            lblMuestraCodEmpleado1.Text = String.Empty
            lblMuestraCodRef1.Text = String.Empty
            lblMuestraPuestoEmpleado1.Text = String.Empty
            lblMuestraUltimoCalRef1.Text = String.Empty
            LimpiarEncargadoCliente1()
            _id1 = 0
            errorCliente.Clear()
        End Sub

        Private Sub LimpiarCliente2()
            txtNombre2.Text = String.Empty
            txtId_Cliente2.Text = String.Empty
            txtPrimerApellido2.Text = String.Empty
            txtSegundoApellido2.Text = String.Empty
            txtCedula2.Text = String.Empty
            dgvCliente2.Visible = False
            txtEmail2.Text = String.Empty
            txtSitioWeb2.Text = String.Empty
            txtDireccion2.Text = String.Empty
            txtObserv2.Text = String.Empty
            lblMostrarId_Credito2.Text = String.Empty
            lblMostrarEstado2.Text = String.Empty
            txtLimite2.Text = String.Empty
            txtTelPrincipal2.Text = String.Empty
            txtFax2.Text = String.Empty
            txtOtroTelefono2.Text = String.Empty
            rbFisico2.Checked = False
            rbJuridico2.Checked = False
            rbNormal2.Checked = False
            rbPreferencial2.Checked = False
            rbPrueba2.Checked = False
            lblMostrarCantContado2.Text = String.Empty
            lblMostrarUltimaCompra2.Text = String.Empty
            lblMostrarCantidad2.Text = String.Empty
            lblMostrarTotal2.Text = String.Empty
            tblFactCredito2.Rows.Clear()
            lblMuestraActivoRef2.Text = String.Empty
            lblMuestraCodEmpleado2.Text = String.Empty
            lblMuestraCodRef2.Text = String.Empty
            lblMuestraPuesto2.Text = String.Empty
            lblMuestraUltimoCalRef2.Text = String.Empty
            btnTrasladarEmpleado2.Enabled = False
            btnTrasladarReferencia2.Enabled = False
            btnTrasladarCredito.Enabled = False
            btnTrasladarFacturasContado.Enabled = False
            LimpiarEncargadoCliente2()
            _id2 = 0
        End Sub

        Private Sub txtId_Cliente1_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtId_Cliente1.KeyPress
            Dim keyAscii As Short = CShort(Asc(e.KeyChar))
            If keyAscii <> 13 Then
                Dim oPersona = BuscarPersonaPorId(e, txtId_Cliente1)
                If oPersona.IdPersona <> 0 And oPersona.IdPersona <> _id2 Then
                    _id1 = oPersona.IdPersona
                    LlenarCliente1(oPersona)
                Else
                    LimpiarCliente1()
                End If
            End If
        End Sub

        Private Sub txtId_Cliente1_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtId_Cliente1.KeyDown
            If e.KeyData = Keys.Enter And txtNombre1.Text = "" Then
                txtNombre1.Focus()
            ElseIf e.KeyData = Keys.Enter Then
                txtTelPrincipal1.Focus()
            End If
        End Sub

        Private Sub dgvCliente1_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles dgvCliente1.KeyDown
            If e.KeyValue = 13 Then EscojerPersona()
        End Sub

        Private Sub dgvCliente1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvCliente1.Click
            EscojerPersona()
        End Sub

        Private Sub EscojerPersona()
            Dim oPersona = _oLogicaPersona.Consultar(dgvCliente1.Item(0, dgvCliente1.CurrentRow.Index).Value)
            txtId_Cliente1.Text = oPersona.IdPersona
            LlenarCliente1(oPersona)
            dgvCliente1.Visible = False
        End Sub

        Private Sub EscojerPersona2()
            Dim oPersona = _oLogicaPersona.Consultar(dgvCliente2.Item(0, dgvCliente2.CurrentRow.Index).Value)
            txtId_Cliente2.Text = oPersona.IdPersona
            LlenarCliente2(oPersona)
            dgvCliente2.Visible = False
        End Sub

        Private Sub txtNombre2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtNombre2.Click
            LimpiarCliente2()
            txtNombre2.Focus()
        End Sub

        Private Sub tabCliente1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles tabCliente1.SelectedIndexChanged
            tabCliente2.SelectedIndex = tabCliente1.SelectedIndex
            If tabCliente1.SelectedIndex = 0 Then
                If Trim(lblMostrarId_Credito1.Text) <> "" And Trim(lblMostrarId_Credito2.Text) <> "" Then
                    txtLimite1.Enabled = True
                    gbEnte1.Enabled = True
                    gbTipo1.Enabled = True
                End If
            End If
        End Sub

        Private Sub tabCliente2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles tabCliente2.SelectedIndexChanged
            tabCliente1.SelectedIndex = tabCliente2.SelectedIndex
        End Sub

        Private Sub btnTrasladarEmpleado2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnTrasladarEmpleado2.Click
            If Trim(txtId_Cliente1.Text) = "" Then
                MsgBox("Debe seleccionar el cliente al que desea trasladarle el código de empleado", MsgBoxStyle.Critical)
            ElseIf Trim(lblMuestraCodEmpleado1.Text) = "" Then
                _oLogicaEmpleado.trasladarEmpleado(CInt(txtId_Cliente1.Text), CInt(txtId_Cliente2.Text))

                LlenarEmpleadoOtro(lblMuestraCodEmpleado1, lblMuestraPuestoEmpleado1, CInt(txtId_Cliente1.Text))

                lblMuestraCodEmpleado2.Text = String.Empty
                lblMuestraPuesto2.Text = String.Empty
                btnTrasladarEmpleado2.Enabled = False
            Else
                MsgBox("El empleado no puede ser trasladado porqué el otro cliente ya cuenta con un codigo de empleado", MsgBoxStyle.Critical)
            End If
        End Sub

        Private Sub btnTrasladarReferencia2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnTrasladarReferencia2.Click
            'Valida que existan los dos clientes, si existen y el cliente al que se le trasladará la 
            ' referencia no tiene una asignada entonces se le traslada sino se indica que ya cuenta con una.
            If Trim(txtId_Cliente1.Text) = "" Then
                MsgBox("Debe seleccionar el cliente al que desea trasladarle la referencia", MsgBoxStyle.Critical)
            ElseIf Trim(lblMuestraCodRef1.Text) = "" Then
                _oLogicaReferencia.trasladarPersonaReferencia(CInt(txtId_Cliente1.Text), CInt(txtId_Cliente2.Text))

                LlenarReferencia(lblMuestraCodRef1, lblMuestraActivoRef1, lblMuestraUltimoCalRef1, CInt(txtId_Cliente1.Text))

                lblMuestraCodRef2.Text = String.Empty
                lblMuestraActivoRef2.Text = String.Empty
                lblMuestraUltimoCalRef2.Text = String.Empty
                btnTrasladarReferencia2.Enabled = False
            Else
                MsgBox("La referencia no puede ser trasladada porqué el otro cliente ya cuenta con un código de referencia", MsgBoxStyle.Critical)
            End If
        End Sub

        Private Sub btnLimpiar2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnLimpiar2.Click
            LimpiarCliente2()
            txtNombre2.Focus()
        End Sub

        Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnLimpiar1.Click
            LimpiarCliente1()
            txtNombre1.Focus()
        End Sub

        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            ValidarCliente()
        End Sub

        Private Sub FrmTrasladar_Persona_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            AddHandler txtTelPrincipal1.KeyPress, AddressOf FormatoNumTelefono
            AddHandler txtOtroTelefono1.KeyPress, AddressOf FormatoNumTelefono
            AddHandler txtFax1.KeyPress, AddressOf FormatoNumTelefono
            AddHandler txtTelPrincipal2.KeyPress, AddressOf FormatoNumTelefono
            AddHandler txtOtroTelefono2.KeyPress, AddressOf FormatoNumTelefono
            AddHandler txtFax2.KeyPress, AddressOf FormatoNumTelefono
            AddHandler txtTelf1Encarg1.KeyPress, AddressOf FormatoNumTelefono
            AddHandler txtTelf2Encarg1.KeyPress, AddressOf FormatoNumTelefono
            AddHandler txtFaxEncarg1.KeyPress, AddressOf FormatoNumTelefono
        End Sub

        Private Sub ValidarCliente()
            errorCliente.Clear()
            Dim valida = True
            Dim oPersona As New Persona

            ValidaVacioDevuelveCadena(valida, RTrim(txtNombre1.Text), oPersona.Nombre, lblNombre1,
                                      "El nombre no puede estar vacío", errorCliente)
            ValidaVacioDevuelveCadena(valida, Trim(txtDireccion1.Text), oPersona.OtraInformacion.Direccion, lblDireccion1,
                                      "La dirección no puede estar vacía", errorCliente)
            ValidaVacioCeroDevuelveCadena(valida, Trim(txtCedula1.Text), oPersona.Cedula, lblCedula1,
                                          "La cédula no puede estar vacía o ser cero", errorCliente)
            If rbFisico1.Checked Then
                ValidaVacioDevuelveCadena(valida, Trim(txtPrimerApellido1.Text), oPersona.PrimerApellido, lblPrimerApellido1,
                                          "El primer apellido no puede estar vacío", errorCliente)
                ValidaVacioDevuelveCadena(valida, Trim(txtSegundoApellido1.Text), oPersona.SegundoApellido, lblSegundoApellido1,
                                          "El segundo apellido no puede estar vacío", errorCliente)
            Else
                oPersona.PrimerApellido = "-"
                oPersona.SegundoApellido = "-"
            End If

            oPersona.OtraInformacion.Observaciones = UCase(txtObservaciones1.Text)
            oPersona.OtraInformacion.SitioWeb = txtSitioWeb1.Text
            ValidarTelefonoPrincipal(valida, txtTelPrincipal1.Text, oPersona, errorCliente, lblTelefonoPrincipal1)
            ValidarOtroTelefono(valida, txtOtroTelefono1.Text, oPersona, errorCliente, lblOtroTelefono1)
            ValidarFaxPrincipal(valida, txtFax1.Text, oPersona, errorCliente, lblFax1)
            ValidarEmail(valida, txtEmail1.Text, oPersona, errorCliente, lblEmail1)

            If valida Then
                oPersona.OtraInformacion.IdPersona = CInt(txtId_Cliente1.Text)
                oPersona.IdPersona = CInt(txtId_Cliente1.Text)
                _oLogicaPersona.ModificarOtraInfo(oPersona.OtraInformacion)
                _oLogicaPersona.Modificar(oPersona)
                MsgBox("Datos modificados con éxito", MsgBoxStyle.Information)
            End If
        End Sub

        Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnEliminar.Click
            'Valida que existan los dos usuarios, si los dos existen se valida que el cliente a eliminar
            ' no tenga asignado un crédito, ser un empleado o referencia. 'Si se cumple se elimina el cliente.
            If Trim(lblMostrarCantContado2.Text) = "" And Trim(lblMuestraCodEmpleado2.Text) = "" And Trim(lblMuestraCodRef2.Text) = "" Then
                EliminarCliente()
            Else
                Dim valida = True
                Dim errores As String = "El cliente no puede ser eliminado porque tiene asignado: "

                If txtId_Cliente1.Text <> "" And txtNombre1.Text <> "" And txtId_Cliente2.Text <> "" And txtNombre2.Text <> "" Then

                    If Trim(lblMuestraCodEmpleado2.Text) <> "" Then
                        errores += " código de empleado"
                        valida = False
                    End If

                    If Trim(lblMuestraCodRef2.Text) <> "" Then
                        errores += " código de referencia"
                        valida = False
                    End If

                    errores += "."

                    If valida Then
                        EliminarCliente()
                    Else
                        MsgBox(errores, MsgBoxStyle.Critical)
                    End If

                Else
                    MsgBox("Debe seleccionar primero los clientes a modificar", MsgBoxStyle.Exclamation)
                End If
            End If
        End Sub

        Private Sub EliminarCliente()
            If txtId_Cliente2.Text <> "" And txtNombre2.Text <> "" Then
                Dim msgConfimacion As String
                Dim respuesta As String

                If Trim(lblMostrarId_Credito2.Text) <> "" Then
                    msgConfimacion = "El cliente contiene un crédito, esta seguro que desea eliminarlo?"
                Else
                    msgConfimacion = "Esta seguro que desea eliminar este cliente?"
                End If

                respuesta = MsgBox(msgConfimacion, vbCritical + vbYesNo, "Eliminar crédito...")

                If respuesta = vbYes Then
                    If Trim(lblMostrarId_Credito2.Text) <> "" Then
                        _oLogicaCredito.eliminarCliente_Credito(CInt(lblMostrarId_Credito2.Text), CInt(txtId_Cliente2.Text))
                    End If

                    _oLogicaPersona.Eliminar(CInt(txtId_Cliente2.Text))
                    LimpiarCliente2()
                    MsgBox("Cliente eliminado con éxito", MsgBoxStyle.Information)
                    txtNombre2.Focus()
                End If
            Else
                MsgBox("No existe un cliente a eliminar", MsgBoxStyle.Critical)
            End If

        End Sub

        Private Sub btnTrasladarCredito_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnTrasladarCredito.Click
            'Valida que existan los dos clientes, si existen y el cliente al que se le trasladará el 
            ' crédito no tiene otro entonces se le traslada sino se indica que ya cuenta con uno.
            If Trim(txtId_Cliente1.Text) = "" Then
                MsgBox("Debe seleccionar el cliente al que desea trasladarle el crédito", MsgBoxStyle.Critical)
            ElseIf Trim(lblMostrarId_Credito1.Text) = "" Then
                _oLogicaCredito.TrasladarCredito(CInt(txtId_Cliente1.Text), CInt(txtId_Cliente2.Text))
                ActualizarClienteCredito()
            Else
                Dim respuesta As String
                respuesta = MsgBox("Esta seguro que desea unir los dos créditos?", vbCritical + vbYesNo, "Eliminar crédito...")

                If respuesta = vbYes Then
                    _oLogicaCredito.UnirCredito(CInt(lblMostrarId_Credito1.Text), CInt(lblMostrarId_Credito2.Text))
                    ActualizarClienteCredito()
                End If
            End If
        End Sub

        Private Sub ActualizarClienteCredito()
            'Actualiza todos los datos de crédito de un cliente, una vez que se han unido dos créditos
            Dim persona = _oLogicaPersona.Consultar(CInt(txtId_Cliente1.Text))
            LimpiarCliente1()
            txtId_Cliente1.Text = persona.IdPersona
            LlenarCliente1(persona)

            lblMostrarCantidad2.Text = String.Empty
            lblMostrarTotal2.Text = String.Empty
            tblFactCredito2.Rows.Clear()
            txtLimite2.Text = String.Empty
            lblMostrarId_Credito2.Text = String.Empty
            lblMostrarEstado2.Text = String.Empty
            rbFisico2.Checked = False
            rbJuridico2.Checked = False
            rbNormal2.Checked = False
            rbPreferencial2.Checked = False
            rbPrueba2.Checked = False
            btnTrasladarCredito.Enabled = False
        End Sub

        Private Sub btnTrasladarFacturasContado_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnTrasladarFacturasContado.Click
            'Valida que existan los dos clientes, si existen se le traslada todas las facturas que tiene 
            'asignado el cliente al otro.
            If Trim(txtId_Cliente1.Text) = "" Then
                MsgBox("Debe seleccionar el cliente al que desea trasladarle las facturas", MsgBoxStyle.Critical)
            Else
                _oLogicaFactura.trasladarFacturas(CInt(txtId_Cliente1.Text), CInt(txtId_Cliente2.Text))

                Dim persona = _oLogicaPersona.Consultar(CInt(txtId_Cliente1.Text))
                LimpiarCliente1()
                txtId_Cliente1.Text = persona.IdPersona
                LlenarCliente1(persona)

                lblMostrarCantContado2.Text = String.Empty
                lblMostrarUltimaCompra2.Text = String.Empty
                btnTrasladarFacturasContado.Enabled = False
            End If
        End Sub

        Private Sub txtId_Cliente2_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtId_Cliente2.KeyPress
            Dim keyAscii As Short = CShort(Asc(e.KeyChar))
            If Not keyAscii = 13 Then
                Dim oPersona = BuscarPersonaPorId(e, txtId_Cliente2)
                If oPersona.IdPersona <> 0 And oPersona.IdPersona <> _id1 Then
                    _id2 = oPersona.IdPersona
                    LlenarCliente2(oPersona)
                Else
                    LimpiarCliente2()
                End If
            End If
        End Sub

        Private Sub txtId_Cliente2_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtId_Cliente2.KeyDown
            If e.KeyData = Keys.Enter And txtNombre2.Text = "" Then
                txtNombre2.Focus()
            ElseIf e.KeyData = Keys.Enter Then
                txtTelPrincipal2.Focus()
            End If
        End Sub

        Private Sub txtNombre1_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNombre1.KeyDown
            CambiarControlADataGrid(dgvCliente1, e, txtNombre1, txtPrimerApellido1, txtPrimerApellido1)
        End Sub

        Private Sub txtNombre1_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtNombre1.KeyPress
            BuscarPersonaPorNombre(dgvCliente1, e, txtNombre1, txtPrimerApellido1, txtId_Cliente1, txtNombre1)
        End Sub

        Private Sub txtNombre2_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtNombre2.KeyPress
            BuscarPersonaPorNombre(dgvCliente2, e, txtNombre2, txtPrimerApellido2, txtId_Cliente2, txtNombre2)
        End Sub

        Private Sub txtNombre2_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNombre2.KeyDown
            CambiarControlADataGrid(dgvCliente2, e, txtNombre2, txtPrimerApellido2, txtPrimerApellido2)
        End Sub

        Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel2.Paint

        End Sub

        Private Sub dgvCliente2_Click_1(sender As Object, e As EventArgs) Handles dgvCliente2.Click
            EscojerPersona2()
        End Sub

        Private Sub dgvCliente2_KeyDown_1(sender As Object, e As KeyEventArgs) Handles dgvCliente2.KeyDown
            If e.KeyValue = 13 Then EscojerPersona2()
        End Sub

        Private Sub FrmClienteRepetido_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
            Me.Dispose()
        End Sub

        Private Sub btnModificarEncarg1_Click(sender As Object, e As EventArgs) Handles btnModificarEncarg1.Click
            ValidarEncargado()
        End Sub

        Private Sub dgvEncargado1_Click(sender As Object, e As EventArgs) Handles dgvEncargado1.Click
            If dgvEncargado1.Rows.Count > 0 Then
                Dim encargado = _oLogicaCredito.ConsultarEncargado(dgvEncargado1.Item(0, dgvEncargado1.CurrentRow.Index).Value)

                txtId_Encargado.Text = encargado.IdEncargado
                txtNombreEncarg1.Text = encargado.Nombre
                txtTelf1Encarg1.Text = encargado.Telefono1
                txtTelf2Encarg1.Text = encargado.Telefono2
                txtFaxEncarg1.Text = encargado.Fax
                txtExt1Encarg1.Text = encargado.Ext1
                txtServicioEncarg1.Text = encargado.Servicio
                txtCorreoEncarg1.Text = encargado.Correo
            End If
        End Sub

        Private Sub dgvEncargado2_Click(sender As Object, e As EventArgs) Handles dgvEncargado2.Click
            If dgvEncargado2.Rows.Count > 0 Then
                Dim encargado = _oLogicaCredito.ConsultarEncargado(dgvEncargado2.Item(0, dgvEncargado2.CurrentRow.Index).Value)

                lblMostrarNombreEncarg2.Text = encargado.Nombre
                lblMostrarTel1Encarg2.Text = encargado.Telefono1
                lblMostrarTel2Encarg2.Text = encargado.Telefono2
                lblMostrarFaxEncarg2.Text = encargado.Fax
                lblMostrarExtEncarg2.Text = encargado.Ext1
                lblMostrarServicioEncarg2.Text = encargado.Servicio
                lblMostrarCorreoEncarg2.Text = encargado.Correo
                txtIdEncargadoCliente2.Text = encargado.IdEncargado
            End If
        End Sub

        Private Sub LimpiarErroresEncargado()
            errorCliente.SetError(lblNombre_Encargado, String.Empty)
            errorCliente.SetError(lblTelefono1_Encargado, String.Empty)
            errorCliente.SetError(lblTelefono2_Encargado, String.Empty)
            errorCliente.SetError(lblServicioEncargado, String.Empty)
            errorCliente.SetError(lblFax_Encargado, String.Empty)
            errorCliente.SetError(lblCorreoEncargado, String.Empty)
        End Sub

        Private Sub ValidarEncargado()
            LimpiarErroresEncargado()
            Dim valida As Boolean = True
            Dim oEncargado As New EncargadoClienteCredito
            Dim salida As String

            ValidaVacioDevuelveCadena(valida, Trim(txtNombreEncarg1.Text), oEncargado.Nombre, lblNombre_Encargado,
                                      "El nombre del encargado no puede estar vacío", errorCliente)

            salida = _oUtilidades.TelefonoFaxValido(txtTelf1Encarg1.Text)
            oEncargado.Telefono1 = RetornarValorOpcional(valida, salida, errorCliente, lblTelefono1_Encargado, txtTelf1Encarg1.Text)

            salida = _oUtilidades.TelefonoFaxValidoOpcional(txtTelf2Encarg1.Text)
            oEncargado.Telefono2 = RetornarValorOpcional(valida, salida, errorCliente, lblTelefono2_Encargado, txtTelf2Encarg1.Text)

            ValidaVacioDevuelveCadena(valida, Trim(txtServicioEncarg1.Text), oEncargado.Servicio, lblServicioEncargado,
                                      "La descripción del servicio del encargado no puede estar vacío", errorCliente)

            salida = _oUtilidades.TelefonoFaxValidoOpcional(txtFaxEncarg1.Text)
            oEncargado.Fax = RetornarValorOpcional(valida, salida, errorCliente, lblFax_Encargado, txtFaxEncarg1.Text)

            salida = _oUtilidades.ValidarCorreo(txtCorreoEncarg1.Text)
            oEncargado.Correo = LCase(RetornarValorOpcional(valida, salida, errorCliente, lblCorreoEncargado, txtCorreoEncarg1.Text))

            If Trim(txtExt1Encarg1.Text) <> "" Then
                oEncargado.Ext1 = txtExt1Encarg1.Text
            Else
                oEncargado.Ext1 = 0
            End If

            If valida Then
                oEncargado.IdEncargado = txtId_Encargado.Text
                oEncargado.IdClienteCredito = lblMostrarId_Credito1.Text
                _oLogicaCredito.ModificarEncargado(oEncargado)

                LimpiarErroresEncargado()
                LimpiarEncargadoCliente1()
                Dim listaEncargados = _oLogicaCredito.ConsultarEncargadosPorClienteCredito(oEncargado.IdClienteCredito)
                For Each encargado In listaEncargados
                    dgvEncargado1.Rows.Add(encargado.IdEncargado, encargado.Nombre)
                Next
            End If

        End Sub

        Private Sub lblMostrarExtEncarg2_Click(sender As Object, e As EventArgs) Handles lblMostrarExtEncarg2.Click

        End Sub

        Private Sub LimpiarEncargadoCliente1()
            txtCorreoEncarg1.Text = String.Empty
            txtNombreEncarg1.Text = String.Empty
            txtTelf1Encarg1.Text = String.Empty
            txtTelf2Encarg1.Text = String.Empty
            txtServicioEncarg1.Text = String.Empty
            txtFaxEncarg1.Text = String.Empty
            txtExt1Encarg1.Text = String.Empty
            dgvEncargado1.DataSource = Nothing
            dgvEncargado1.Rows.Clear()
        End Sub

        Private Sub btnTrasladarTodosEncargados_Click(sender As Object, e As EventArgs) Handles btnTrasladarTodosEncargados.Click
            If Trim(txtId_Cliente1.Text) = "" Then
                MsgBox("Debe seleccionar el cliente al que desea trasladarle todos los encargados", MsgBoxStyle.Critical)
            ElseIf Trim(lblMostrarId_Credito1.Text) = "" Then
                MsgBox("El cliente al que desea trasladarle todos los encargados no tiene credito", MsgBoxStyle.Critical)
            Else
                _oLogicaCredito.TrasladarEncargados(CInt(lblMostrarId_Credito1.Text), CInt(lblMostrarId_Credito2.Text))
                'Actualiza todos los datos de crédito de un cliente, una vez que se han unido dos créditos
                Dim persona = _oLogicaPersona.Consultar(CInt(txtId_Cliente1.Text))
                LimpiarCliente1()
                txtId_Cliente1.Text = persona.IdPersona
                LlenarCliente1(persona)
                LimpiarEncargadoCliente2()
            End If
        End Sub

        Private Sub LimpiarEncargadoCliente2()
            lblMostrarCorreoEncarg2.Text = String.Empty
            lblMostrarNombreEncarg2.Text = String.Empty
            lblMostrarTel1Encarg2.Text = String.Empty
            lblMostrarTel2Encarg2.Text = String.Empty
            lblMostrarServicioEncarg2.Text = String.Empty
            lblMostrarFaxEncarg2.Text = String.Empty
            lblMostrarExtEncarg2.Text = String.Empty
            txtIdEncargadoCliente2.Text = String.Empty
            btnTrasladarEncargado.Enabled = False
            btnTrasladarTodosEncargados.Enabled = False
            dgvEncargado2.Rows.Clear()
        End Sub

        Private Sub btnTrasladarEncargado_Click(sender As Object, e As EventArgs) Handles btnTrasladarEncargado.Click
            If Trim(txtId_Cliente1.Text) = "" Then
                MsgBox("Debe seleccionar el cliente al que desea trasladarle el encargado", MsgBoxStyle.Critical)
            ElseIf Trim(lblMostrarId_Credito1.Text) = "" Then
                MsgBox("El cliente al que desea trasladarle el encargado no tiene credito", MsgBoxStyle.Critical)
            ElseIf txtIdEncargadoCliente2.Text = "" Then
                MsgBox("Debe seleccionar el encargado que desea trasladar", MsgBoxStyle.Critical)
            Else
                _oLogicaCredito.TrasladarEncargado(CInt(lblMostrarId_Credito1.Text), CInt(txtIdEncargadoCliente2.Text))
                Dim idClienteCredito = CInt(lblMostrarId_Credito2.Text)
                'Actualiza todos los datos de crédito de un cliente, una vez que se han unido dos créditos
                Dim persona = _oLogicaPersona.Consultar(CInt(txtId_Cliente1.Text))
                LimpiarCliente1()
                txtId_Cliente1.Text = persona.IdPersona
                LlenarCliente1(persona)
                LimpiarEncargadoCliente2()
                Dim listaEncargados = _oLogicaCredito.ConsultarEncargadosPorClienteCredito(idClienteCredito)
                For Each encargado In listaEncargados
                    dgvEncargado2.Rows.Add(encargado.IdEncargado, encargado.Nombre)
                Next
                If listaEncargados.Count > 0 Then
                    btnTrasladarEncargado.Enabled = True
                    btnTrasladarTodosEncargados.Enabled = True
                End If
            End If
        End Sub
    End Class
End Namespace