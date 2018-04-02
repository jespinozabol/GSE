Imports Presentacion.Interfaz.Creditos
Imports Logica_Negocios
Imports Entidades

Public Class FrmEncargadosCliente

    Private ReadOnly _oLogicaEncargadoClienteCredito As New LogicaClienteCredito
    Private ReadOnly _oUtilidades As New Utilidades
    Private _oListaEncargados As List(Of EncargadoClienteCredito)

    Private Sub btnAgregar_Encargado_Click(sender As Object, e As EventArgs) Handles btnAgregar_Encargado.Click
        ValidarEncargado()
    End Sub

    Private Sub FrmEncargadosCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler txtTelefono1_Encargado.KeyPress, AddressOf FormatoNumTelefono
        AddHandler txtTelefono2_Encargado.KeyPress, AddressOf FormatoNumTelefono
        AddHandler txtFax_Encargado.KeyPress, AddressOf FormatoNumTelefono
        AddHandler txtExt1_Encargado.KeyPress, AddressOf ValidarSoloNumeros

        AddHandler dgvEncargados.MouseDown, AddressOf SeleccionaClickDerecho
        dgvEncargados.ContextMenuStrip = MnEliminarEncargado
        txtNombre_Encargado.Focus()
    End Sub

    Public Sub LlenarEncargados(ByVal encargados As List(Of EncargadoClienteCredito))
        _oListaEncargados = New List(Of EncargadoClienteCredito)
        dgvEncargados.DataSource = Nothing
        If IsNothing(encargados) Then
            encargados = New List(Of EncargadoClienteCredito)
        End If
        _oListaEncargados = encargados
        If _oListaEncargados.Count > 0 Then
            dgvEncargados.DataSource = _oListaEncargados
            ActualizargdvEncargado()
        End If
    End Sub

    Private Sub ActualizargdvEncargado()
        With dgvEncargados
            .Columns("IdEncargado").Visible = False
            .Columns("IdClienteCredito").Visible = False
            .Columns("Nombre").Width = 245
            .Columns("Servicio").Width = 220
            .Columns("Telefono1").Width = 65
            .Columns("Telefono2").Visible = False
            .Columns("Fax").Visible = False
            .Columns("Ext1").Width = 50
            .Columns("Correo").Visible = False
            If .RowCount > 0 Then .Rows(0).Selected = False
        End With
    End Sub

    Private Sub ValidarEncargado()
        LimpiarErroresEncargado()
        Dim valida As Boolean = True
        Dim oEncargado As New EncargadoClienteCredito
        Dim salida As String

        ValidaVacioDevuelveCadena(valida, Trim(txtNombre_Encargado.Text), oEncargado.Nombre, lblNombre_Encargado,
                                  "El nombre del encargado no puede estar vacío", errProvider)

        salida = _oUtilidades.TelefonoFaxValido(txtTelefono1_Encargado.Text)
        oEncargado.Telefono1 = RetornarValorOpcional(valida, salida, errProvider, lblTelefono1_Encargado, txtTelefono1_Encargado.Text)

        salida = _oUtilidades.TelefonoFaxValidoOpcional(txtTelefono2_Encargado.Text)
        oEncargado.Telefono2 = RetornarValorOpcional(valida, salida, errProvider, lblTelefono2_Encargado, txtTelefono2_Encargado.Text)

        ValidaVacioDevuelveCadena(valida, Trim(txtServicio.Text), oEncargado.Servicio, lblServicio,
                                  "La descripción del servicio del encargado no puede estar vacío", errProvider)

        salida = _oUtilidades.TelefonoFaxValidoOpcional(txtFax_Encargado.Text)
        oEncargado.Fax = RetornarValorOpcional(valida, salida, errProvider, lblFax_Encargado, txtFax_Encargado.Text)

        salida = _oUtilidades.ValidarCorreo(txtCorreoEncargado.Text)
        oEncargado.Correo = LCase(RetornarValorOpcional(valida, salida, errProvider, lblCorreoEncargado, txtCorreoEncargado.Text))

        If Trim(txtExt1_Encargado.Text) <> "" Then
            oEncargado.Ext1 = txtExt1_Encargado.Text
        Else
            oEncargado.Ext1 = 0
        End If

        If valida Then
            Dim idClienteCredito = FrmClienteCredito.txtId_Credito.Text
            If txtId_Encargado.Text = "" Then
                _oListaEncargados.Add(oEncargado)
                If (idClienteCredito <> "") Then
                    oEncargado.IdClienteCredito = CInt(idClienteCredito)
                    _oLogicaEncargadoClienteCredito.InsertarEncargado(oEncargado)
                End If
            Else
                For i As Integer = 0 To _oListaEncargados.Count - 1
                    If _oListaEncargados(i).IdEncargado = CInt(txtId_Encargado.Text) Then
                        oEncargado.IdEncargado = CInt(txtId_Encargado.Text)
                        _oListaEncargados(i) = oEncargado
                    End If
                    _oLogicaEncargadoClienteCredito.ModificarEncargado(oEncargado)
                Next
            End If

            dgvEncargados.DataSource = Nothing
            dgvEncargados.DataSource = _oListaEncargados
            ActualizargdvEncargado()
            LimpiarErroresEncargado()
            LimpiarEncargado()
        End If

    End Sub

    Private Sub LimpiarErroresEncargado()
        errProvider.SetError(lblNombre_Encargado, String.Empty)
        errProvider.SetError(lblTelefono1_Encargado, String.Empty)
        errProvider.SetError(lblTelefono2_Encargado, String.Empty)
        errProvider.SetError(lblServicio, String.Empty)
        errProvider.SetError(lblFax_Encargado, String.Empty)
        errProvider.SetError(lblCorreoEncargado, String.Empty)
    End Sub

    Private Sub LimpiarEncargado()
        txtId_Encargado.Text = String.Empty
        txtNombre_Encargado.Text = String.Empty
        txtTelefono1_Encargado.Text = String.Empty
        txtTelefono2_Encargado.Text = String.Empty
        txtServicio.Text = String.Empty
        txtFax_Encargado.Text = String.Empty
        txtExt1_Encargado.Text = String.Empty
        txtCorreoEncargado.Text = String.Empty
        limpiarErroresEncargado()
    End Sub

    Private Sub FrmEncargadosCliente_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        LimpiarEncargado()
        FrmClienteCredito.ListaEncargados = _oListaEncargados
    End Sub

    Private Sub txtNombre_Encargado_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombre_Encargado.KeyDown
        If (e.KeyValue = 13) Then txtTelefono1_Encargado.Focus()
    End Sub

    Private Sub txtTelefono1_Encargado_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTelefono1_Encargado.KeyDown
        If (e.KeyValue = 13) Then txtTelefono2_Encargado.Focus()
    End Sub

    Private Sub txtTelefono2_Encargado_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTelefono2_Encargado.KeyDown
        If (e.KeyValue = 13) Then txtFax_Encargado.Focus()
    End Sub

    Private Sub txtFax_Encargado_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFax_Encargado.KeyDown
        If (e.KeyValue = 13) Then txtExt1_Encargado.Focus()
    End Sub

    Private Sub txtExt1_Encargado_KeyDown(sender As Object, e As KeyEventArgs) Handles txtExt1_Encargado.KeyDown
        If (e.KeyValue = 13) Then txtServicio.Focus()
    End Sub

    Private Sub txtServicio_KeyDown(sender As Object, e As KeyEventArgs) Handles txtServicio.KeyDown
        If (e.KeyValue = 13) Then txtCorreoEncargado.Focus()
    End Sub

    Private Sub txtCorreoEncargado_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCorreoEncargado.KeyDown
        If (e.KeyValue = 13) Then btnAgregar_Encargado.Focus()
    End Sub

    Private Sub EliminarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem1.Click
        If dgvEncargados.RowCount > 0 Then
            Dim elimina As Integer

            elimina = MessageBox.Show("Esta seguro q desea eliminar el encargado?", "Eliminar Encargado", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If elimina = 6 Then
                Dim idEncargado As Integer = CInt(dgvEncargados.Item(0, dgvEncargados.CurrentRow.Index).Value)
                Dim oEncargado As EncargadoClienteCredito
                oEncargado = _oListaEncargados(dgvEncargados.CurrentRow.Index)

                If idEncargado <> 0 Then
                    _oLogicaEncargadoClienteCredito.EliminarEncargado(oEncargado.IdEncargado)
                End If

                _oListaEncargados.RemoveAt(dgvEncargados.CurrentRow.Index)
                dgvEncargados.DataSource = Nothing
                dgvEncargados.DataSource = _oListaEncargados
                ActualizargdvEncargado()
                LimpiarEncargado()
            End If
        End If
    End Sub

    Private Sub dgvEncargados_Click(sender As Object, e As EventArgs) Handles dgvEncargados.Click
        With dgvEncargados
            Try
                txtId_Encargado.Text = .Item(0, .CurrentRow.Index).Value
                txtNombre_Encargado.Text = .Item(2, .CurrentRow.Index).Value
                txtServicio.Text = .Item(3, .CurrentRow.Index).Value
                txtTelefono1_Encargado.Text = Trim(.Item(4, .CurrentRow.Index).Value)
                txtTelefono2_Encargado.Text = Trim(.Item(5, .CurrentRow.Index).Value)
                txtExt1_Encargado.Text = Trim(.Item(6, .CurrentRow.Index).Value)
                txtFax_Encargado.Text = Trim(.Item(7, .CurrentRow.Index).Value)
                txtCorreoEncargado.Text = Trim(.Item(8, .CurrentRow.Index).Value)
            Catch ex As Exception

            End Try
        End With
    End Sub
End Class


