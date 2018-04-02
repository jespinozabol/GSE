Imports Entidades
Imports Logica_Negocios

Namespace Interfaz.Mantenimiento
    Public Class FrmReferencias

        Private ReadOnly _oLogicaPersona As New LogicaPersona
        Private ReadOnly _oLogicaReferencia As New LogicaReferencia
        Private ReadOnly _oUtilidades As New Utilidades

        Private Sub FrmReferencias_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            CargarDatos()
            AddHandler txtTelefono.KeyPress, AddressOf FormatoNumTelefono
            AddHandler txtOtroTelefono.KeyPress, AddressOf FormatoNumTelefono
            AddHandler txtFax.KeyPress, AddressOf FormatoNumTelefono
        End Sub

        Private Sub dgvPersonas_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvPersonas.Click
            txtId.Text = dgvPersonas.Item(0, dgvPersonas.CurrentRow.Index).Value
            dgvPersonas.Visible = False
            LlenarDatosReferencia()
        End Sub

        Private Sub dgvPersonas_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles dgvPersonas.KeyDown
            If e.KeyValue = 13 Then
                txtId.Text = dgvPersonas.Item(0, dgvPersonas.CurrentRow.Index).Value
                dgvPersonas.Visible = False
                LlenarDatosReferencia()
            End If
        End Sub

        Private Sub LlenarDatosReferencia()
            dgvPersonas.DataSource = Nothing
            dgvPersonas.Visible = False
            Dim oPersona As Persona
            oPersona = _oLogicaPersona.Consultar(CInt(txtId.Text))
            txtNombre.Text = oPersona.Nombre
            txtCedula.Text = oPersona.Cedula
            txtApellidos.Text = oPersona.PrimerApellido + " " + oPersona.SegundoApellido

            txtDireccion.Text = oPersona.OtraInformacion.Direccion
            txtTelefono.Text = oPersona.OtraInformacion.TelefonoPrincipal
            txtOtroTelefono.Text = oPersona.OtraInformacion.OtroTelefono
            txtEmail.Text = oPersona.OtraInformacion.Email
            txtFax.Text = oPersona.OtraInformacion.FaxPrincipal

            Dim oReferencia As Referencia
            oReferencia = _oLogicaReferencia.ConsultarPorId_Persona(oPersona.IdPersona)

            If oReferencia.IdReferencia <> 0 Then
                txtIdRef.Text = oReferencia.IdReferencia
            End If

            lblFechaCalculo.Text = oReferencia.UltimoCalculo
            txtTelefono.Focus()
        End Sub

        Private Sub CambiarPropiedadesDgv(ByVal sender As DataGridView)
            With sender
                .Columns(0).HeaderText = "IdRef"
                .Columns(0).Width = 45
                .Columns(1).HeaderText = "IdGen"
                .Columns(1).Width = 45
                .Columns(2).Width = 225
                .Columns(3).HeaderText = "1er Apellido"
                .Columns(3).Width = 100
                .Columns(4).HeaderText = "2do Apellido"
                .Columns(4).Width = 100
                If .RowCount > 0 Then .Rows(0).Selected = False
            End With
        End Sub

        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            errorReferencias.Clear()
            Dim valida As Boolean = True
            Dim oReferencia As New Referencia

            If Trim(txtId.Text) = "" Then
                MessageBox.Show("Debe seleccionar un cliente antes de actualizarlo o agregarlo como referencia", "Agregar o actualizar cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                oReferencia.IdPersona = CInt(txtId.Text)

                ValidaVacioDevuelveCadena(valida, Trim(txtNombre.Text), oReferencia.Nombre, lblNombre,
                                          "El nombre no puede estar vacío", errorReferencias)

                oReferencia.PrimerApellido = _oUtilidades.ValidarApellidos(txtApellidos.Text)(0)
                oReferencia.SegundoApellido = _oUtilidades.ValidarApellidos(txtApellidos.Text)(1)

                Dim idPersona As Integer = 0
                If txtId.Text <> "" Then
                    idPersona = CInt(txtId.Text)
                End If

                ValidarTelefonoPrincipal(valida, txtTelefono.Text, oReferencia, errorReferencias, lblTelefono)
                ValidarOtroTelefono(valida, txtOtroTelefono.Text, oReferencia, errorReferencias, lblOtroTelefono)
                ValidarFaxPrincipal(valida, txtFax.Text, oReferencia, errorReferencias, lblFax)
                ValidarEmail(valida, txtEmail.Text, oReferencia, errorReferencias, lblEmail)

                ValidaVacioDevuelveCadena(valida, Trim(txtDireccion.Text), oReferencia.OtraInformacion.Direccion, lblDireccion,
                                          "La dirección no puede estar vacía", errorReferencias)

                oReferencia.Activo = True
                oReferencia.Cedula = txtCedula.Text
                oReferencia.OtraInformacion.IdPersona = CInt(txtId.Text)
                oReferencia.OtraInformacion.Observaciones = String.Empty
                oReferencia.OtraInformacion.SitioWeb = String.Empty

                If valida Then
                    If txtIdRef.Text = "" Then
                        _oLogicaReferencia.Insertar(oReferencia)
                        MessageBox.Show("Datos insertados con éxito", "Insertar Referencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LimpiarTodo()
                    Else
                        oReferencia.IdReferencia = CInt(txtIdRef.Text)
                        _oLogicaReferencia.ModificarDatos(oReferencia)
                        MessageBox.Show("Datos modificados con éxito", "Modificar Referencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LimpiarTodo()
                    End If

                End If
            End If
        End Sub

        Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnLimpiar.Click
            LimpiarTodo()
        End Sub

        Private Sub CargarDatos()
            dgvReferencias.DataSource = _oLogicaReferencia.ConsultarActivos
            CambiarPropiedadesDgv(dgvReferencias)
            dgvReferenciasInactivas.DataSource = _oLogicaReferencia.ConsultarInactivos
            CambiarPropiedadesDgv(dgvReferenciasInactivas)
        End Sub

        Public Sub LimpiarTodo()
            txtId.Text = String.Empty
            txtIdRef.Text = String.Empty
            txtNombre.Text = String.Empty
            txtApellidos.Text = String.Empty
            txtDireccion.Text = String.Empty
            txtCedula.Text = String.Empty
            CargarDatos()
            txtTelefono.Text = String.Empty
            txtOtroTelefono.Text = String.Empty
            txtFax.Text = String.Empty
            txtEmail.Text = String.Empty
            txtNombre.Focus()
        End Sub

        Private Sub txtApellidos_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtApellidos.KeyDown
            If e.KeyValue = 13 Then txtCedula.Focus()
        End Sub

        Private Sub txtDireccion_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtDireccion.KeyDown
            If e.KeyValue = 13 Then txtTelefono.Focus()
        End Sub

        Private Sub txtCedula_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtCedula.KeyDown
            If e.KeyValue = 13 Then txtDireccion.Focus()
        End Sub

        Private Sub dgvReferencias_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvReferencias.Click
            txtId.Text = dgvReferencias.Item(1, dgvReferencias.CurrentRow.Index).Value
            LlenarDatosReferencia()
        End Sub

        Private Sub dgvReferenciasInactivas_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvReferenciasInactivas.Click
            txtId.Text = dgvReferenciasInactivas.Item(1, dgvReferenciasInactivas.CurrentRow.Index).Value
            LlenarDatosReferencia()
        End Sub

        Private Sub btnActivar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnActivar.Click
            If txtIdRef.Text <> "" Then
                Dim activar As Integer
                activar = MessageBox.Show("Esta seguro q desea activar la referencia?", "Activar Referencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If activar = vbYes Then
                    Dim oReferencia As New Referencia
                    oReferencia.Activo = True
                    oReferencia.IdReferencia = CInt(txtIdRef.Text)
                    oReferencia.IdPersona = CInt(txtId.Text)
                    _oLogicaReferencia.ModificarRef(oReferencia)
                    LimpiarTodo()
                End If
            Else
                MessageBox.Show("Debe de seleccionar una referencia antes de presionar activar", "Activar Referencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Sub

        Private Sub btnInactivar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnInactivar.Click
            If txtIdRef.Text <> "" Then
                Dim inactivar As Integer
                inactivar = MessageBox.Show("Esta seguro que desea inactivar la referencia?", "Inactivar Referencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If inactivar = vbYes Then
                    Dim oReferencia As New Referencia
                    oReferencia.Activo = False
                    oReferencia.IdReferencia = CInt(txtIdRef.Text)
                    oReferencia.IdPersona = CInt(txtId.Text)
                    _oLogicaReferencia.ModificarRef(oReferencia)
                    LimpiarTodo()
                End If
            Else
                MessageBox.Show("Debe de seleccionar una referencia antes de presionar inactivar", "Inactivar Referencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Sub

        Private Sub btnTrasladar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnTrasladar.Click
            If txtIdRef.Text <> "" Then
                Dim oReferencia As New Referencia
                oReferencia.IdReferencia = CInt(txtIdRef.Text)
                oReferencia.IdPersona = CInt(txtId.Text)
                oReferencia.Nombre = txtNombre.Text
                oReferencia.PrimerApellido = _oUtilidades.ValidarApellidos(txtApellidos.Text)(0)
                oReferencia.SegundoApellido = _oUtilidades.ValidarApellidos(txtApellidos.Text)(1)

                FrmTrasladarReferencia.Referencia = oReferencia
                FrmTrasladarReferencia.ShowDialog()
            Else
                MessageBox.Show("No se ha seleccionado la referencia a trasladar", "Trasladar Referencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Sub

        Private Sub FrmReferencias_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub

        Private Sub btnCalcularRef_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCalcularRef.Click
            If txtIdRef.Text <> "" Then
                FrmCalcularReferencia.txtId_Referencia.Text = txtIdRef.Text
                FrmCalcularReferencia.lblMostrarNombre.Text = txtNombre.Text & " " & txtApellidos.Text
                FrmCalcularReferencia.ShowDialog()
            Else
                MessageBox.Show("No se ha seleccionado la referencia a calcular", "Calcular Referencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        End Sub

        Private Sub txtNombre_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
            BuscarPersonaPorNombre(dgvPersonas, e, txtNombre, txtApellidos, txtId, txtNombre)
        End Sub

        Private Sub txtNombre_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
            CambiarControlADataGrid(dgvPersonas, e, txtNombre, txtApellidos, txtApellidos)
        End Sub

        Private Sub txtTelefono_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTelefono.KeyDown
            If e.KeyValue = 13 Then txtOtroTelefono.Focus()
        End Sub

        Private Sub txtOtroTelefono_KeyDown(sender As Object, e As KeyEventArgs) Handles txtOtroTelefono.KeyDown
            If e.KeyValue = 13 Then txtFax.Focus()
        End Sub

        Private Sub txtFax_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFax.KeyDown
            If e.KeyValue = 13 Then txtEmail.Focus()
        End Sub

        Private Sub txtEmail_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEmail.KeyDown
            If e.KeyValue = 13 Then btnGuardar.Focus()
        End Sub
    End Class
End Namespace