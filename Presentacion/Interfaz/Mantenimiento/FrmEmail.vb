Imports Logica_Negocios

Public Class FrmEmail

    Private _oLogicaVarios As New LogicaVarios
    Private _oLogicaPersona As New LogicaPersona
    Private _oLogicaCliente As New LogicaClienteCredito
    Public IdCredito As Integer

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim listaEmails = txtEmails.Text.Split(";").ToList
        Dim email = listaEmails.Last()
        If email = "" Then
            listaEmails.Remove(email)
        End If
        Try
            Cursor.Current = Cursors.WaitCursor
            _oLogicaVarios.EnviarEmail(listaEmails, txtAsunto.Text,
                                   txtBody.Text, lblMostrarAdjuntos.Text)
            MessageBox.Show("Correo electrónico enviado con éxito", "Enviando correo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Cursor.Current = Cursors.Default
            Me.Dispose()
        Catch ex As Exception
            MessageBox.Show(String.Format("Error enviando el correo electrónico, mas detalles:\n {0}", ex.ToString), "Enviando correo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAdjuntarArchivo_Click(sender As Object, e As EventArgs)
        OpenFileAdjuntar = New OpenFileDialog()
        If (OpenFileAdjuntar.ShowDialog = Windows.Forms.DialogResult.OK) Then

        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim cliente = _oLogicaCliente.ConsultarPorIdCredito(IdCredito)
        Dim emails = New List(Of String)
        emails.Add(cliente.OtraInformacion.Email)
        For Each encargado In cliente.Encargados
            emails.Add(encargado.Correo)
        Next
        For Each correo In emails
            If Not String.IsNullOrWhiteSpace(correo) Then
                dgvEmails.Rows.Add(False, correo)
            End If
        Next
        pnlEmails.Visible = True
    End Sub

    Private Sub btnAgregarEmail_Click(sender As Object, e As EventArgs) Handles btnAgregarEmail.Click
        For i As Integer = 0 To dgvEmails.Rows.Count - 1
            If dgvEmails.Item(0, i).Value = True Then
                txtEmails.AppendText(String.Format("{0};", dgvEmails.Item(1, i).Value))
            End If
        Next
        If dgvEmails.Rows.Count > 0 Then dgvEmails.Rows(0).Selected = False
        pnlEmails.Visible = False
    End Sub

    Private Sub FrmEmail_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        txtAsunto.Text = String.Empty
        txtBody.Text = String.Empty
        txtEmails.Text = String.Empty
        lblMostrarAdjuntos.Text = String.Empty
        dgvEmails.Rows.Clear()
    End Sub

    Private Sub FrmEmail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlEmails.Visible = False
    End Sub
End Class