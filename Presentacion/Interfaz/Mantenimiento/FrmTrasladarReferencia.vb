Imports Entidades
Imports Logica_Negocios

Namespace Interfaz.Mantenimiento
    Public Class FrmTrasladarReferencia
        Private ReadOnly _oLogicaPersona As New LogicaPersona
        Private ReadOnly _oLogicaReferencia As New LogicaReferencia
        Public Referencia As New Referencia

        Private Sub FrmTrasladarReferencia_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            txtIdRef.Text = Referencia.IdReferencia
            txtGen.Text = Referencia.IdPersona
            txtNombre.Text = Referencia.Nombre + " " + Referencia.PrimerApellido + " " + Referencia.SegundoApellido

            AddHandler txtTelefono.KeyPress, AddressOf FormatoNumTelefono
            AddHandler txtOtroTelefono.KeyPress, AddressOf FormatoNumTelefono
            AddHandler txtFax.KeyPress, AddressOf FormatoNumTelefono
        End Sub

        Private Sub btnTrasladar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnTrasladar.Click
            errorTrasladar.Clear()
            Dim valida As Boolean = True
            Dim oReferencia As New Referencia

            If Trim(txtId.Text) = "" Then
                MessageBox.Show("Debe seleccionar un cliente antes de realizar el traslado", "Trasladar referencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If Trim(txtId.Text) = "" Then
                    errorTrasladar.SetError(lblNombreC, "Debe seleccionar la persona a quién se le trasladará la referencia")
                    valida = False
                Else
                    oReferencia.OtraInformacion.IdPersona = CInt(txtId.Text)
                    oReferencia.IdPersona = CInt(txtId.Text)
                    oReferencia.IdReferencia = CInt(txtIdRef.Text)
                End If

                ValidarTelefonoPrincipal(valida, txtTelefono.Text, oReferencia, errorTrasladar, lblTelefono)
                ValidarOtroTelefono(valida, txtOtroTelefono.Text, oReferencia, errorTrasladar, lblOtroTelefono)
                ValidarFaxPrincipal(valida, txtFax.Text, oReferencia, errorTrasladar, lblFax)
                ValidarEmail(valida, txtEmail.Text, oReferencia, errorTrasladar, lblEmail)

                ValidaVacioDevuelveCadena(valida, Trim(txtDireccion.Text), oReferencia.OtraInformacion.Direccion, lblDireccion,
                                          "La dirección no puede estar vacía", errorTrasladar)

                oReferencia.Activo = True
                oReferencia.Cedula = txtCedula.Text

                oReferencia.OtraInformacion.Observaciones = String.Empty
                oReferencia.OtraInformacion.SitioWeb = String.Empty

                If valida Then
                    Dim trasladar As Integer
                    trasladar = MessageBox.Show("Esta seguro que desea trasladar la referencia?", "Trasladar referencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    'Primero se trasladan todos los datos de la referencia de la antigua persona que la tenía
                    ' al código de referencia 1 y despúes 
                    If trasladar = vbYes Then
                        _oLogicaReferencia.TrasladarDatosReferencia(oReferencia)
                        _oLogicaReferencia.ModificarInfoPersonal(oReferencia)
                        MessageBox.Show("Referencia trasladada con éxito", "Traslado de Referencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        FrmReferencias.LimpiarTodo()
                        Dispose()
                    End If
                End If
            End If
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
            Dim oPersona As Persona
            oPersona = _oLogicaPersona.Consultar(CInt(txtId.Text))
            txtNombreCambio.Text = oPersona.Nombre + " " + oPersona.PrimerApellido + " " + oPersona.SegundoApellido
            txtCedula.Text = oPersona.Cedula

            txtDireccion.Text = oPersona.OtraInformacion.Direccion
            txtTelefono.Text = oPersona.OtraInformacion.TelefonoPrincipal
            txtOtroTelefono.Text = oPersona.OtraInformacion.OtroTelefono
            txtEmail.Text = oPersona.OtraInformacion.Email
            txtFax.Text = oPersona.OtraInformacion.FaxPrincipal
        End Sub

        Private Sub FrmTrasladarReferencia_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub

        Private Sub txtNombreCambio_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtNombreCambio.KeyPress
            BuscarPersonaPorNombre(dgvPersonas, e, txtNombreCambio, txtCedula, txtId, txtNombreCambio)
        End Sub

        Private Sub txtTelefono_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTelefono.KeyDown
            If e.KeyValue = 13 Then txtOtroTelefono.Focus()
        End Sub

        Private Sub txtOtroTelefono_KeyDown(sender As Object, e As KeyEventArgs) Handles txtOtroTelefono.KeyDown
            If e.KeyValue = 13 Then txtFax.Focus()
        End Sub

        Private Sub txtFax_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFax.KeyDown
            If e.KeyValue = 13 Then txtCedula.Focus()
        End Sub

        Private Sub txtCedula_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCedula.KeyDown
            If e.KeyValue = 13 Then txtEmail.Focus()
        End Sub

        Private Sub txtEmail_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEmail.KeyDown
            If e.KeyValue = 13 Then txtDireccion.Focus()
        End Sub

        Private Sub txtNombreCambio_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombreCambio.KeyDown
            CambiarControlADataGrid(dgvPersonas, e, txtNombre, txtNombre, txtNombre)
        End Sub
    End Class
End Namespace