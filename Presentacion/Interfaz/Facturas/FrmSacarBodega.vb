Imports Logica_Negocios
Imports Entidades

Namespace Interfaz.Facturas
    Public Class FrmSacarBodega

        Private ReadOnly _oLogicaProducto As New LogicaProducto

        Private Sub FrmSacar_Bodega_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub

        Private Sub FrmSacar_Bodega_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            AddHandler txtCantidad.KeyPress, AddressOf ValidarNumerosPunto
            AddHandler txtExist_Bodega.KeyPress, AddressOf ValidarNumerosPunto
        End Sub

        Private Sub txtCodigo_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
            If e.KeyData = Keys.Enter And txtArticulo.Text = "" Then
                txtArticulo.Focus()
                txtCodigo.Text = String.Empty
            ElseIf e.KeyData = Keys.Enter Then
                txtCantidad.Focus()
            End If
        End Sub

        Private Sub txtCodigo_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
            Dim keyAscii As Short = CShort(Asc(e.KeyChar))
            If keyAscii <> 13 Then
                Dim oProducto = BuscarProductoPorCodigo(e, txtCodigo)
                llenarProducto(oProducto)
            End If
        End Sub

        Private Sub txtArticulo_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtArticulo.KeyDown
            CambiarControlADataGrid(dgvMostrarProductos, e, txtArticulo, txtCantidad, txtCantidad)
        End Sub

        Private Sub txtArticulo_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtArticulo.KeyPress
            BuscarProductoPorDescripcion(dgvMostrarProductos, e, txtArticulo, txtCodigo)
        End Sub

        Private Sub dgvMostrarProductos_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles dgvMostrarProductos.KeyDown
            If e.KeyData = Keys.Enter Then mostrarProductos()
        End Sub

        Private Sub MostrarProductos()
            txtCodigo.Text = dgvMostrarProductos.Item(0, dgvMostrarProductos.CurrentRow.Index).Value
            dgvMostrarProductos.DataSource = Nothing
            dgvMostrarProductos.Visible = False
            llenarProducto(_oLogicaProducto.Consultar(CLng(txtCodigo.Text)))
            txtCantidad.Focus()
        End Sub

        Private Sub LlenarProducto(ByVal oProducto As Producto)
            If oProducto.Id_Producto <> 0 Then
                txtArticulo.Text = oProducto.Descripcion
                txtExist_Bodega.Text = oProducto.Bodega.ExistBodega
                txtDespues.Text = oProducto.Bodega.ExistBodega
            Else
                LimpiarTodo()
            End If
        End Sub
        Private Sub dgvMostrarProductos_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvMostrarProductos.Click
            MostrarProductos()
        End Sub

        Private Sub txtCodigo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtCodigo.Click
            LimpiarTodo()
            txtCodigo.Text = String.Empty
            txtArticulo.Text = String.Empty
        End Sub

        Private Sub btnCorregir_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCorregir.Click
            txtExist_Bodega.Enabled = True
            txtExist_Bodega.Focus()
        End Sub

        Private Sub LimpiarTodo()
            txtExist_Bodega.Text = String.Empty
            txtCantidad.Text = String.Empty
            dgvMostrarProductos.Visible = False
            txtExist_Bodega.Enabled = False
            txtDespues.Text = String.Empty
            dgvMostrarProductos.DataSource = Nothing
        End Sub

        Private Sub txtArticulo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtArticulo.Click
            LimpiarTodo()
            txtArticulo.Text = String.Empty
            txtCodigo.Text = String.Empty
        End Sub


        Private Sub btnRetirarBodega_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnRetirarBodega.Click
            If IsNumeric(txtCantidad.Text) And IsNumeric(txtExist_Bodega.Text) Then
                If txtCodigo.Text <> "" And txtArticulo.Text <> "" Then
                    _oLogicaProducto.ModificarExist_ProductoBodega(CInt(txtCodigo.Text), CDbl(txtDespues.Text))
                    LimpiarTodo()
                    txtArticulo.Text = String.Empty
                    txtCodigo.Text = String.Empty
                    MsgBox("Retiro realizado con éxito", MsgBoxStyle.Information)
                    Dispose()
                Else
                    MsgBox("Debe seleccionar el producto al cual se le descontarán las existencias", MsgBoxStyle.Exclamation)
                End If
            Else
                MsgBox("Tanto la cantidad a retirar como las existencias en bodega no pueden estar vacías", MsgBoxStyle.Exclamation)
            End If
        End Sub

        Private Sub txtCantidad_Leave(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtCantidad.Leave
            If IsNumeric(txtCantidad.Text) And IsNumeric(txtExist_Bodega.Text) Then
                txtDespues.Text = CDbl(txtExist_Bodega.Text) - CDbl(txtCantidad.Text)
            End If
        End Sub

        Private Sub txtExist_Bodega_Leave(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtExist_Bodega.Leave
            If IsNumeric(txtCantidad.Text) And IsNumeric(txtExist_Bodega.Text) Then
                txtDespues.Text = CDbl(txtExist_Bodega.Text) - CDbl(txtCantidad.Text)
            End If
        End Sub

        Private Sub txtCantidad_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtCantidad.KeyDown
            If e.KeyData = Keys.Enter And txtExist_Bodega.Enabled Then
                txtExist_Bodega.Focus()
            ElseIf e.KeyData = Keys.Enter Then
                btnRetirarBodega.Focus()
            End If
        End Sub

        Private Sub txtExist_Bodega_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtExist_Bodega.KeyDown
            If e.KeyData = Keys.Enter Then btnRetirarBodega.Focus()
        End Sub
    End Class
End Namespace