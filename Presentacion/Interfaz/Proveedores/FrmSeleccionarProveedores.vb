Imports Entidades
Imports Presentacion.Interfaz.Proveedores
Imports Logica_Negocios

Public Class FrmSeleccionarProveedores

    Public ResumenPedido As New List(Of ResumenPedido)
    Private ReadOnly _oUtilidades As New Utilidades
    Public linea As Integer

    Private Sub FrmSeleccionarProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For i As Integer = 0 To ResumenPedido.Count - 1
            dgvProveedores.Rows.Add(ResumenPedido(i).Proveedor, ResumenPedido(i).Imprime, ResumenPedido(i).EnviarEmail, ResumenPedido(i).Email, ResumenPedido(i).Pedir)

            Dim a = New DataGridViewComboBoxCell
            a.Style.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            a.Items.Add("Zarcero y el Rápido")
            a.Items.Add("Cajeta")
            a.Items.Add("Lazaro")
            a.Items.Add("Sancarleño")

            dgvProveedores.Item(5, i) = a
            If (ResumenPedido.Count > 0) Then
                CType(dgvProveedores.Rows(i).Cells(5), DataGridViewComboBoxCell).Value = "Zarcero y el Rápido"
            End If
        Next
    End Sub

    Private Sub FrmSeleccionarProveedores_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dispose()
    End Sub

    Private Sub btnEjecutar_Click(sender As Object, e As EventArgs) Handles btnEjecutar.Click
        Dim ejecutar As Integer
        ejecutar = MessageBox.Show("Esta seguro que desea ejecutar el pedido?", "Pedido a ejecutar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If ejecutar = 6 Then
            Cursor.Current = Cursors.WaitCursor

            Dim resumenPedido = New List(Of ResumenPedido)
            With dgvProveedores
                For i As Integer = 0 To .Rows.Count - 1
                    Dim pro = New ResumenPedido
                    pro.Proveedor = .Item(0, i).Value
                    pro.Imprime = .Item(1, i).Value
                    pro.EnviarEmail = .Item(2, i).Value
                    pro.Email = New List(Of String)
                    If (pro.EnviarEmail) Then
                        Dim emails = .Item(3, i).Value.ToString().Split(";")
                        pro.Email = emails.ToList
                    End If
                    If (pro.EnviarEmail And pro.Email.Count <= 0) Then
                        MsgBox(String.Format("El proveedor {0} no tiene un email válido", pro.Proveedor), MsgBoxStyle.Exclamation)
                        Return
                    End If
                    pro.Pedir = .Item(4, i).Value
                    pro.Transporte = .Item(5, i).Value
                    resumenPedido.Add(pro)
                Next
            End With
            FrmPedidos.EjecutarPedido(resumenPedido)

            Cursor.Current = Cursors.Default

            Dispose()
        End If
    End Sub

    Private Sub dgvProveedores_Click(sender As Object, e As EventArgs) Handles dgvProveedores.Click
        If dgvProveedores.CurrentRow.Index >= 0 And dgvProveedores.CurrentCell.ColumnIndex = 2 Then
            linea = dgvProveedores.CurrentRow.Index
            FrmSeleccionarEmails.lblMostrarProveedor.Text = dgvProveedores.Item(0, dgvProveedores.CurrentRow.Index).Value
            FrmSeleccionarEmails.EmailsAnteriores = dgvProveedores.Item(3, dgvProveedores.CurrentRow.Index).Value
            FrmSeleccionarEmails.btnEnviar.Visible = False
            FrmSeleccionarEmails.btnAceptar.Visible = True
            FrmSeleccionarEmails.ShowDialog()
        End If
    End Sub
End Class