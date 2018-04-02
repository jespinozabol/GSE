Imports Entidades
Imports Logica_Negocios

Namespace Interfaz.Mantenimiento
    Public Class FrmEmpleadoOtros

        Private ReadOnly _oLogicaPersona As New LogicaPersona
        Private ReadOnly _oLogicaEmpleadoYOtro As New LogicaEmpleadoOtro

        Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnLimpiar.Click
            LimpiarTodo()
            txtId_Persona.Focus()
        End Sub

        Private Sub LimpiarTodo()
            txtId_Persona.Text = String.Empty
            txtNombre.Text = String.Empty
            txtApellido1.Text = String.Empty
            txtApellido2.Text = String.Empty
            txtCedula.Text = String.Empty
            txtTelefono.Text = String.Empty
            txtOtroTelefono.Text = String.Empty
            txtFax.Text = String.Empty
            txtEmail.Text = String.Empty
            txtSitioWeb.Text = String.Empty
            txtRol.Text = String.Empty
            txtDireccion.Text = String.Empty
            txtObservaciones.Text = String.Empty
            txtNombre.ReadOnly = False
            txtApellido1.ReadOnly = False
            txtApellido2.ReadOnly = False
            txtCedula.ReadOnly = False
            txtId_Empleado.Text = String.Empty
            errorEmpleados.Clear()
        End Sub

        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            validarEmpleado()
        End Sub

        Private Sub ValidarEmpleado()
            errorEmpleados.Clear()
            Dim valida = True
            Dim tipo As Integer
            Dim oEmpleadoOtro As New EmpleadoOtro

            Dim idPersona As Integer = 0
            If txtId_Persona.Text <> "" Then
                idPersona = CInt(txtId_Persona.Text)
            End If

            oEmpleadoOtro.OtraInformacion.Observaciones = UCase(txtObservaciones.Text)
            oEmpleadoOtro.OtraInformacion.SitioWeb = txtSitioWeb.Text
            ValidarTelefonoPrincipal(valida, txtTelefono.Text, oEmpleadoOtro, errorEmpleados, lblTelefono)
            ValidarOtroTelefono(valida, txtOtroTelefono.Text, oEmpleadoOtro, errorEmpleados, lblOtroTelefono)
            ValidarFaxPrincipal(valida, txtFax.Text, oEmpleadoOtro, errorEmpleados, lblFax)
            ValidarEmail(valida, txtEmail.Text, oEmpleadoOtro, errorEmpleados, lblEmail)

            ValidaVacioDevuelveCadena(valida, Trim(txtDireccion.Text), oEmpleadoOtro.OtraInformacion.Direccion, lblDireccion,
                                      "La dirección no puede estar vacía", errorEmpleados)
            ValidaVacioDevuelveCadena(valida, Trim(txtRol.Text), oEmpleadoOtro.Tipo, lblRol,
                                      "Debe agregar el rol que cumple la persona en la compañía", errorEmpleados)

            If txtId_Persona.Text = "" And txtId_Empleado.Text = "" Then
                If Trim(txtNombre.Text) = "" Then
                    errorEmpleados.SetError(lblNombre, "El nombre no puede estar vacío")
                    valida = False
                Else
                    oEmpleadoOtro.Nombre = UCase(txtNombre.Text)
                    oEmpleadoOtro.PrimerApellido = UCase(txtApellido1.Text)
                    oEmpleadoOtro.SegundoApellido = UCase(txtApellido2.Text)
                    oEmpleadoOtro.Cedula = txtCedula.Text
                    tipo = 0
                End If
            ElseIf txtId_Empleado.Text = "" And txtId_Persona.Text <> "" Then
                oEmpleadoOtro.IdPersona = CInt(txtId_Persona.Text)
                oEmpleadoOtro.OtraInformacion.IdPersona = CInt(txtId_Persona.Text)
                tipo = 0
            ElseIf txtId_Empleado.Text <> "" And txtId_Persona.Text <> "" Then
                oEmpleadoOtro.IdPersona = CInt(txtId_Persona.Text)
                oEmpleadoOtro.IdEmpleado = CInt(txtId_Empleado.Text)
                oEmpleadoOtro.OtraInformacion.IdPersona = CInt(txtId_Persona.Text)
                tipo = 1
            End If

            If valida Then
                _oLogicaEmpleadoYOtro.Insertar(oEmpleadoOtro)
                If tipo = 0 Then
                    MsgBox("Empleado creado con éxito")
                ElseIf tipo = 1 Then
                    MsgBox("Empleado modificado con éxito")
                End If

                LimpiarTodo()
            End If
        End Sub

        Private Sub FrmEmpleadosYOtros_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            AddHandler txtId_Persona.KeyPress, AddressOf ValidarSoloNumeros
            AddHandler txtTelefono.KeyPress, AddressOf FormatoNumTelefono
            AddHandler txtOtroTelefono.KeyPress, AddressOf FormatoNumTelefono
            AddHandler txtFax.KeyPress, AddressOf FormatoNumTelefono
        End Sub

        Private Sub txtApellido1_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtApellido1.KeyDown
            If e.KeyData = Keys.Enter Then txtApellido2.Focus()
        End Sub

        Private Sub txtCedula_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtCedula.KeyDown
            If e.KeyData = Keys.Enter Then txtTelefono.Focus()
        End Sub

        Private Sub txtApellido2_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtApellido2.KeyDown
            If e.KeyData = Keys.Enter Then txtCedula.Focus()
        End Sub

        Private Sub txtRol_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtRol.KeyDown
            If e.KeyData = Keys.Enter Then txtEmail.Focus()
        End Sub

        Private Sub txtDireccion_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtDireccion.KeyDown
            If e.KeyData = Keys.Enter Then txtObservaciones.Focus()
        End Sub

        Private Sub txtObservaciones_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtObservaciones.KeyDown
            If e.KeyData = Keys.Enter Then btnGuardar.Focus()
        End Sub

        Private Sub btnCorregir_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCorregir.Click
            If txtId_Persona.Text <> "" Then
                FrmModificarCliente.IdCliente = CInt(txtId_Persona.Text)
                FrmModificarCliente.Formulario = 3
                FrmModificarCliente.ShowDialog()
            Else
                MessageBox.Show("Debe de seleccionar una persona antes de presionar corregir", "Corregir datos persona", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Sub

        Private Sub txtId_Persona_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtId_Persona.Click
            LimpiarTodo()
        End Sub

        Private Sub dgvClientes_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvClientes.Click
            txtId_Persona.Text = dgvClientes.Item(0, dgvClientes.CurrentRow.Index).Value
            ActualizarPersona()
            dgvClientes.Visible = False
        End Sub

        Public Sub ActualizarPersona()
            Dim oPersona As Persona
            oPersona = _oLogicaPersona.Consultar(CInt(txtId_Persona.Text))

            txtCedula.Text = oPersona.Cedula
            txtNombre.Text = oPersona.Nombre
            txtApellido1.Text = oPersona.PrimerApellido
            txtApellido2.Text = oPersona.SegundoApellido
            txtNombre.ReadOnly = True
            txtApellido1.ReadOnly = True
            txtApellido2.ReadOnly = True
            txtCedula.ReadOnly = True
            CargarOtrosDatos(0, oPersona.IdPersona)
            txtTelefono.Focus()
        End Sub

        Private Sub dgvClientes_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles dgvClientes.KeyDown
            If e.KeyData = Keys.Enter Then
                txtId_Persona.Text = dgvClientes.Item(0, dgvClientes.CurrentRow.Index).Value
                ActualizarPersona()
                dgvClientes.Visible = False
            End If
        End Sub

        Private Sub CargarOtrosDatos(ByVal tipo As Integer, ByVal id As Integer)
            Dim oPersona As Persona

            oPersona = _oLogicaPersona.Consultar(id)

            If oPersona.IdPersona <> 0 Then
                txtDireccion.Text = oPersona.OtraInformacion.Direccion
                txtObservaciones.Text = oPersona.OtraInformacion.Observaciones
                txtTelefono.Text = oPersona.OtraInformacion.TelefonoPrincipal
                txtOtroTelefono.Text = oPersona.OtraInformacion.OtroTelefono
                txtFax.Text = oPersona.OtraInformacion.FaxPrincipal
                txtEmail.Text = oPersona.OtraInformacion.Email
                txtSitioWeb.Text = oPersona.OtraInformacion.SitioWeb

                Dim oEmpleado As EmpleadoOtro
                oEmpleado = _oLogicaEmpleadoYOtro.ConsultarPorIdPersona(id)

                If oEmpleado.IdPersona <> 0 Then
                    txtRol.Text = oEmpleado.Tipo

                    If tipo = 1 Then
                        txtId_Persona.Text = oEmpleado.IdPersona
                    Else
                        txtId_Empleado.Text = oEmpleado.IdEmpleado
                    End If

                End If
            End If

        End Sub

        Private Sub txtId_Empleado_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtId_Empleado.Click
            LimpiarTodo()
        End Sub

        Private Sub txtId_Empleado_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtId_Empleado.KeyPress
            Dim keyAscii As Short = CShort(Asc(e.KeyChar))
            If keyAscii <> 13 Then
                Dim oEmpleadoOtro = BuscarEmpleadoPorId(e, txtId_Empleado)
                If oEmpleadoOtro.IdEmpleado <> 0 Then
                    Dim persona = _oLogicaPersona.Consultar(oEmpleadoOtro.IdPersona)
                    txtNombre.Text = persona.Nombre
                    txtApellido1.Text = persona.PrimerApellido
                    txtApellido2.Text = persona.SegundoApellido
                    txtCedula.Text = persona.Cedula
                    txtNombre.ReadOnly = True
                    txtApellido1.ReadOnly = True
                    txtApellido2.ReadOnly = True
                    txtCedula.ReadOnly = True
                    CargarOtrosDatos(1, oEmpleadoOtro.IdPersona)
                Else
                    LimpiarTodo()
                    txtNombre.ReadOnly = False
                    txtApellido1.ReadOnly = False
                    txtApellido2.ReadOnly = False
                    txtCedula.ReadOnly = False
                End If
            End If
        End Sub

        Private Sub txtId_Empleado_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtId_Empleado.KeyDown
            If e.KeyData = Keys.Enter And txtNombre.Text = "" Then
                txtNombre.Focus()
            ElseIf e.KeyData = Keys.Enter Then
                txtTelefono.Focus()
            End If
        End Sub

        Private Sub txtId_Persona_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtId_Persona.KeyPress
            Dim keyAscii As Short = CShort(Asc(e.KeyChar))
            If keyAscii <> 13 Then
                Dim oPersona = BuscarPersonaPorId(e, txtId_Persona)
                If oPersona.IdPersona <> 0 Then
                    txtNombre.Text = oPersona.Nombre
                    txtApellido1.Text = oPersona.PrimerApellido
                    txtApellido2.Text = oPersona.SegundoApellido
                    txtCedula.Text = oPersona.Cedula
                    txtNombre.ReadOnly = True
                    txtApellido1.ReadOnly = True
                    txtApellido2.ReadOnly = True
                    txtCedula.ReadOnly = True
                    CargarOtrosDatos(0, oPersona.IdPersona)
                Else
                    LimpiarTodo()
                End If
            End If
        End Sub

        Private Sub txtId_Persona_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtId_Persona.KeyDown
            If e.KeyData = Keys.Enter And txtNombre.Text = "" Then
                txtNombre.Focus()
            ElseIf e.KeyData = Keys.Enter Then
                txtTelefono.Focus()
            End If
        End Sub

        Private Sub txtNombre_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
            CambiarControlADataGrid(dgvClientes, e, txtNombre, txtApellido1, txtApellido1)
        End Sub

        Private Sub txtNombre_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
            BuscarPersonaPorNombre(dgvClientes, e, txtNombre, txtApellido1, txtId_Persona, txtNombre)
        End Sub

        Private Sub txtTelefono_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTelefono.KeyDown
            If e.KeyData = Keys.Enter Then txtOtroTelefono.Focus()
        End Sub

        Private Sub txtOtroTelefono_KeyDown(sender As Object, e As KeyEventArgs) Handles txtOtroTelefono.KeyDown
            If e.KeyData = Keys.Enter Then txtFax.Focus()
        End Sub

        Private Sub txtFax_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFax.KeyDown
            If e.KeyData = Keys.Enter Then txtRol.Focus()
        End Sub

        Private Sub txtEmail_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEmail.KeyDown
            If e.KeyData = Keys.Enter Then txtSitioWeb.Focus()
        End Sub

        Private Sub txtSitioWeb_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSitioWeb.KeyDown
            If e.KeyData = Keys.Enter Then txtDireccion.Focus()
        End Sub

        Private Sub FrmEmpleadoOtros_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub
    End Class
End Namespace