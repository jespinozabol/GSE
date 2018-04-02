Imports Entidades
Imports Logica_Negocios

Namespace Interfaz.Listados
    Public Class FrmModificarAutorizado

        Private ReadOnly _oLogicaListado As New LogicaListado

        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            Dim oAutorizados As List(Of ListadoAutorizado)
            oAutorizados = FrmListado.OListado.ListaAutorizados

            If IsNumeric(txtId.Text) Then
                If txtId.Text > 0 Then
                    For i = 0 To oAutorizados.Count - 1
                        If oAutorizados(i).IdAutorizado = txtId.Text Then
                            FrmListado.OListado.ListaAutorizados(i).Nombre = UCase(txtNombre.Text)
                            FrmListado.OListado.ListaAutorizados(i).Telefono = txtTelefono.Text
                        End If
                    Next
                    With dgvAutorizados
                        For i = 0 To .Rows.Count - 1
                            If .Item(0, i).Value = txtId.Text Then
                                .Item(1, i).Value = UCase(txtNombre.Text)
                                .Item(2, i).Value = txtTelefono.Text
                            End If
                        Next
                    End With
                Else
                    Dim indice = CInt(txtId.Text.Substring(1))
                    FrmListado.OListado.ListaAutorizados(indice).Nombre = UCase(txtNombre.Text)
                    FrmListado.OListado.ListaAutorizados(indice).Telefono = txtTelefono.Text
                    dgvAutorizados.Item(1, indice).Value = UCase(txtNombre.Text)
                    dgvAutorizados.Item(2, indice).Value = txtTelefono.Text
                End If
                MsgBox("Autorizado modificado con éxito...", MsgBoxStyle.Information)
                LimpiarTodo()
            Else
                MsgBox("Debe de seleccionar un modificado", MsgBoxStyle.Exclamation)
            End If

        End Sub

        Private Sub txtNombre_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
            If e.KeyValue = 13 Then
                txtTelefono.Focus()
            End If
        End Sub

        Private Sub FrmModificar_Autorizado_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            Dim oAutorizados As List(Of ListadoAutorizado)
            oAutorizados = FrmListado.OListado.ListaAutorizados

            For i = 0 To oAutorizados.Count - 1
                dgvAutorizados.Rows.Add(oAutorizados(i).IdAutorizado, oAutorizados(i).Nombre, oAutorizados(i).Telefono)
            Next

            If dgvAutorizados.Rows.Count > 0 Then dgvAutorizados.Rows(0).Selected = False

            dgvAutorizados.ContextMenuStrip = MnEliminar
        End Sub

        Public Sub Existe_Autorizado()
            If txtId.Text = "a" Then
                txtId.Text = String.Empty
            ElseIf txtId.Text = "b" Then
                txtId.Text = String.Empty
            ElseIf txtId.Text > 0 Then
                Dim oAutorizado As ListadoAutorizado
                oAutorizado = _oLogicaListado.consultarAutorizado(txtId.Text)
                txtNombre.Text = oAutorizado.Nombre
                txtTelefono.Text = oAutorizado.Telefono
            End If
        End Sub

        Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAgregar.Click
            Dim repetido = (From l In FrmListado.OListado.ListaAutorizados
                           Where l.Nombre = UCase(txtNombre.Text) Select l).FirstOrDefault
            If txtId.Text = "" And txtNombre.Text <> "" And IsNothing(repetido) Then
                Dim oAutorizado As New ListadoAutorizado
                oAutorizado.Nombre = UCase(txtNombre.Text)
                oAutorizado.Telefono = txtTelefono.Text
                dgvAutorizados.Rows.Add("0", oAutorizado.Nombre, oAutorizado.Telefono)
                FrmListado.OListado.ListaAutorizados.Add(oAutorizado)
                LimpiarTodo()
                MsgBox("Autorizado agregado con éxito", MsgBoxStyle.Information)
                FrmListado.ActualizarAutorizados()
                FrmListado.cmbAutorizados.SelectedIndex = FrmListado.cmbAutorizados.Items.Count - 1
                Dispose()
            Else
                MsgBox("Este autorizado ya existe, o el nombre está vacío", MsgBoxStyle.Exclamation)
            End If
        End Sub

        Private Sub LimpiarTodo()
            txtNombre.Text = String.Empty
            txtTelefono.Text = String.Empty
            txtId.Text = String.Empty
        End Sub

        Private Sub dgvAutorizados_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvAutorizados.Click
            If dgvAutorizados.CurrentRow.Index <> 0 Then

                Dim codigo = dgvAutorizados.Item(0, dgvAutorizados.CurrentRow.Index).Value
                If codigo = "0" Then
                    txtId.Text = -dgvAutorizados.CurrentRow.Index
                Else
                    txtId.Text = codigo
                End If

                txtNombre.Text = dgvAutorizados.Item(1, dgvAutorizados.CurrentRow.Index).Value
                txtTelefono.Text = dgvAutorizados.Item(2, dgvAutorizados.CurrentRow.Index).Value
            Else
                LimpiarTodo()
            End If


        End Sub

        Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles InactivarToolStripMenuItem.Click
            If dgvAutorizados.RowCount > 0 Then
                Dim inactivar As Integer
                inactivar = MessageBox.Show("Esta seguro q desea inactivar el autorizado?", "Inactivar autorizado", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If inactivar = vbYes Then

                    Dim codigo = CInt(dgvAutorizados.Item(0, dgvAutorizados.CurrentRow.Index).Value)

                    If codigo >= 0 And dgvAutorizados.Rows.Count > 1 Then
                        _oLogicaListado.inactivar_Autorizado(codigo)
                        dgvAutorizados.DataSource = Nothing
                        dgvAutorizados.Rows.Clear()
                    Else
                        MsgBox("Existe solo un autorizado, por lo que no puede ser inactivado", MsgBoxStyle.Exclamation)
                    End If
                End If
            End If
        End Sub

        Private Sub FrmModificarAutorizado_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
            txtId.Text = String.Empty
            txtTelefono.Text = String.Empty
            txtNombre.Text = String.Empty
            FrmListado.ActualizarAutorizados()
            Dispose()
        End Sub
    End Class
End Namespace