Imports Logica_Negocios
Imports Presentacion.Interfaz.Proveedores

Public Class FrmSeleccionarEmails

    Private ReadOnly _oLogicaProveedor As New LogicaProveedor
    Private ReadOnly _oUtilidades As New Utilidades
    Private ReadOnly _oLogicaPedidos As New LogicaPedido
    Public EmailsAnteriores As String
    Public IdPedido As Integer

    Private Sub FrmSeleccionarEmails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbEmails.Items.Clear()
        cmbEmails.Text = String.Empty
        dgvEmails.Rows.Clear()

        If Not String.IsNullOrWhiteSpace(EmailsAnteriores) Then
            Dim emails = EmailsAnteriores.Split(";")
            For Each correo In emails
                If _oUtilidades.ValidarCorreo(correo) = "" Then
                    dgvEmails.Rows.Add(correo)
                End If
            Next
        End If

        Dim proveedor = _oLogicaProveedor.Consultar(lblMostrarProveedor.Text)
        Dim listaEmails = New List(Of String)

        validarCorreo(proveedor.Correo, listaEmails)

        For Each encargado In proveedor.Encargados
            validarCorreo(encargado.Correo, listaEmails)
        Next

        For Each agente In proveedor.Agentes
            validarCorreo(agente.Correo, listaEmails)
        Next

        For Each ema In listaEmails
            cmbEmails.Items.Add(ema)
        Next

        If cmbEmails.Items.Count > 0 Then cmbEmails.SelectedIndex = 0
    End Sub

    Private Sub validarCorreo(ByVal correo As String, ByRef lista As List(Of String))
        If _oUtilidades.ValidarCorreo(correo) = "" Then
            lista.Add(correo)
        End If
    End Sub

    Private Sub lblMostrarProveedor_Click(sender As Object, e As EventArgs) Handles lblMostrarProveedor.Click

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        FrmSeleccionarProveedores.dgvProveedores.Item(3, FrmSeleccionarProveedores.linea).Value = String.Join(";", GetEmails())
        Me.Close()
    End Sub

    Private Function GetEmails() As List(Of String)
        Dim correos = New List(Of String)
        With dgvEmails
            For i As Integer = 0 To .Rows.Count - 1
                correos.Add(dgvEmails.Item(0, i).Value)
            Next
        End With
        Return correos
    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If _oUtilidades.ValidarCorreo(cmbEmails.Text) = "" Then
            dgvEmails.Rows.Add(cmbEmails.Text)
        End If
    End Sub

    Private Sub dgvEmails_Click(sender As Object, e As EventArgs) Handles dgvEmails.Click
        If Not IsNothing(dgvEmails.CurrentRow) Then
            If dgvEmails.CurrentRow.Index >= 0 Then
                dgvEmails.Rows.RemoveAt(dgvEmails.CurrentRow.Index)
            End If
        End If
        
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim respuesta = MsgBox("Esta seguro que desea enviar este pedido por correo?", vbQuestion + vbYesNo, "Enviar pedido...")

        If (respuesta = vbYes) Then
            Dim oPedido = _oLogicaPedidos.Consultar(IdPedido)
            FrmPedidos.EnviarPorEmail(oPedido, GetEmails())

            MsgBox("Email enviado con éxito")
            Dispose()
        End If
    End Sub
End Class