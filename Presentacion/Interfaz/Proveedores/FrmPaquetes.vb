Imports Entidades
Imports Logica_Negocios
Public Class FrmPaquetes

    Private ReadOnly _oLogicaDevoluciones As New LogicaDevolucion

    Private Sub txtId_Proveedor_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtId_Proveedor.KeyDown
        If e.KeyData = Keys.Enter And txtNombre.Text = "" Then
            txtNombre.Focus()
        ElseIf e.KeyData = Keys.Enter Then
            txtNumPaquete.Focus()
        End If
    End Sub

    Private Sub txtId_Proveedor_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtId_Proveedor.KeyPress
        Dim keyAscii As Short = CShort(Asc(e.KeyChar))
        If Not keyAscii = 13 Then
            Dim oProveedor = BuscarProveedorPorId(e, txtId_Proveedor, txtNombre)
            If oProveedor.IdProveedor <> 0 Then
                txtNombre.Text = oProveedor.Nombre
                dgvProveedores.Visible = False
            Else
                LimpiarTodo()
            End If
        End If
    End Sub

    Private Sub LimpiarTodo()
        txtNombre.Text = String.Empty
        txtNumPaquete.Text = String.Empty
        LimpiarErroresValidacion()
    End Sub

    Private Sub txtNombre_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
        CambiarControlADataGrid(dgvProveedores, e, txtNombre, txtNumPaquete, txtNumPaquete)
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        BuscarProveedorPorNombre(dgvProveedores, e, txtNombre, txtId_Proveedor)
    End Sub

    Private Sub FrmPaquetes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oListaPaquetes As List(Of Paquete)
        oListaPaquetes = _oLogicaDevoluciones.ConsultarPaquetes

        For i = 0 To oListaPaquetes.Count - 1
            dgvPaquetes.Rows.Add(oListaPaquetes(i).IdPaquete, oListaPaquetes(i).IdProveedor, oListaPaquetes(i).NombreProveedor)
        Next

        dgvPaquetes.ContextMenuStrip = MenuPaquete
        AddHandler txtNumPaquete.KeyPress, AddressOf ValidarSoloNumeros
        AddHandler dgvPaquetes.MouseDown, AddressOf SeleccionaClickDerecho
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        ValidarPaquete()
    End Sub

    Private Sub ValidarPaquete()
        LimpiarErroresValidacion()
        Dim valida As Boolean = True
        Dim oPaquete = New Paquete

        If Trim(txtId_Proveedor.Text) = "" Or Trim(txtNombre.Text) = "" Then
            errorPaquete.SetError(lblNombre, "El proveedor debe existir")
            valida = False
        Else
            oPaquete.IdProveedor = CInt(txtId_Proveedor.Text)
            oPaquete.NombreProveedor = txtNombre.Text
        End If

        If Trim(txtNumPaquete.Text) = "" Then
            errorPaquete.SetError(lblNombre, "El # de paquete debe de existir")
            valida = False
        Else
            oPaquete.IdPaquete = CInt(txtNumPaquete.Text)
        End If

        If valida Then
            dgvPaquetes.Rows.Add(oPaquete.IdPaquete, oPaquete.IdProveedor, oPaquete.NombreProveedor)
            _oLogicaDevoluciones.InsertarPaquete(oPaquete)
            LimpiarTodo()
        End If
    End Sub

    Private Sub LimpiarErroresValidacion()
        errorPaquete.SetError(lblIdProveedor, String.Empty)
        errorPaquete.SetError(lblNumPaquete, String.Empty)
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        LimpiarTodo()
        txtId_Proveedor.Text = String.Empty
    End Sub

    Private Sub dgvPaquetes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvPaquetes.Click
        txtNumPaquete.Text = dgvPaquetes.Rows(dgvPaquetes.CurrentRow.Index).Cells(0).Value
        txtId_Proveedor.Text = dgvPaquetes.Rows(dgvPaquetes.CurrentRow.Index).Cells(1).Value
        txtNombre.Text = dgvPaquetes.Rows(dgvPaquetes.CurrentRow.Index).Cells(2).Value
    End Sub

    Private Sub EditarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarToolStripMenuItem.Click
        With dgvPaquetes
            FrmDevolucionPorPaquete.lblMostrarNumPaquete.Text = .Rows(.CurrentRow.Index).Cells(0).Value
            FrmDevolucionPorPaquete.lblMostrarProveedor.Text = .Rows(.CurrentRow.Index).Cells(2).Value
            FrmDevolucionPorPaquete.ShowDialog()
        End With
       
    End Sub

    Private Sub FrmPaquetes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
End Class