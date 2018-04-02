Imports Entidades
Imports Logica_Negocios

Namespace Interfaz.Proveedores
    Public Class FrmProveedor
        Private _oListaAgentes As New List(Of Agente)
        Private ReadOnly _oListaAgentesEliminar As New List(Of Agente)
        Private _oListaEncargado As New List(Of Encargado)
        Private ReadOnly _oListaEncargadosEliminar As New List(Of Encargado)
        Private ReadOnly _oUtilidades As New Utilidades
        Private ReadOnly _oLogicaProveedor As New LogicaProveedor
        Private _oProveedor As New Proveedor
        Private _cambios As Boolean = False

        Private _varLlamadoCatalogo As Boolean
        Public Property LlamadoCatalogo() As Boolean
            Get
                Return _varLlamadoCatalogo
            End Get
            Set(ByVal value As Boolean)
                _varLlamadoCatalogo = value
            End Set
        End Property

        Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnLimpiar.Click
            LimpiarTodo()
        End Sub

        Public Sub LimpiarTodo()
            txtNombre.Text = String.Empty
            txtCentral_Telefonica.Text = String.Empty
            txtFax_Principal.Text = String.Empty
            txtDireccion.Text = String.Empty
            txtCC.Text = String.Empty
            txtCedula.Text = String.Empty
            txtNum_Cuenta.Text = String.Empty
            LimpiarAgente()
            LimpiarEncargado()
            dgvAgentes.DataSource = Nothing
            _oListaAgentes = New List(Of Agente)
            dgvEncargados.DataSource = Nothing
            _oListaEncargado = New List(Of Encargado)
            txtCorreo.Text = String.Empty
            limpiarErroresProveedor()
            dgvProveedores.Visible = False
            If Not txtId_Proveedor.Focused Then
                txtId_Proveedor.Text = String.Empty
                txtNombre.Focus()
                _cambios = False
            End If
        End Sub

        Private Sub LimpiarAgente()
            txtId_Agente.Text = String.Empty
            txtNombre_Agente.Text = String.Empty
            txtTelefono1_Agente.Text = String.Empty
            txtTelefono2_Agente.Text = String.Empty
            txtFax_Agente.Text = String.Empty
            txtCorreo_Agente.Text = String.Empty
            limpiarErroresAgente()
        End Sub

        Private Sub LimpiarEncargado()
            txtId_Encargado.Text = String.Empty
            txtNombre_Encargado.Text = String.Empty
            txtTelefono1_Encargado.Text = String.Empty
            txtTelefono2_Encargado.Text = String.Empty
            txtServicio.Text = String.Empty
            txtFax_Encargado.Text = String.Empty
            txtExt1_Encargado.Text = String.Empty
            txtExt2_Encargado.Text = String.Empty
            txtCorreoEncargado.Text = String.Empty
            limpiarErroresEncargado()
        End Sub

        Private Sub txtCentral_Telefonica_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtCentral_Telefonica.KeyDown
            If (e.KeyValue = 13) Then txtFax_Principal.Focus()
        End Sub

        Private Sub txtFax_Principal_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtFax_Principal.KeyDown
            If (e.KeyValue = 13) Then txtCedula.Focus()
        End Sub

        Private Sub txtNombre_Agente_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNombre_Agente.KeyDown
            If (e.KeyValue = 13) Then txtTelefono1_Agente.Focus()
        End Sub

        Private Sub txtTelefono1_Agente_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtTelefono1_Agente.KeyDown
            If (e.KeyValue = 13) Then txtTelefono2_Agente.Focus()
        End Sub

        Private Sub txtTelefono2_Agente_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtTelefono2_Agente.KeyDown
            If (e.KeyValue = 13) Then txtFax_Agente.Focus()
        End Sub

        Private Sub txtFax_Agente_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtFax_Agente.KeyDown
            If (e.KeyValue = 13) Then btnAgregar_Agente.Focus()
        End Sub

        Private Sub txtNombre_Encargado_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNombre_Encargado.KeyDown
            If (e.KeyValue = 13) Then txtTelefono1_Encargado.Focus()
        End Sub

        Private Sub txtTelefono1_Encargado_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtTelefono1_Encargado.KeyDown
            If (e.KeyValue = 13) Then txtTelefono2_Encargado.Focus()
        End Sub

        Private Sub txtTelefono2_Encargado_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtTelefono2_Encargado.KeyDown
            If (e.KeyValue = 13) Then txtFax_Encargado.Focus()
        End Sub

        Private Sub txtServicio_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtServicio.KeyDown
            If (e.KeyValue = 13) Then txtCorreoEncargado.Focus()
        End Sub

        Private Sub txtFax_Encargado_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtFax_Encargado.KeyDown
            If (e.KeyValue = 13) Then txtExt1_Encargado.Focus()
        End Sub

        Private Sub txtExt1_Encargado_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtExt1_Encargado.KeyDown
            If (e.KeyValue = 13) Then txtExt2_Encargado.Focus()
        End Sub

        Private Sub txtExt2_Encargado_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtExt2_Encargado.KeyDown
            If (e.KeyValue = 13) Then txtServicio.Focus()
        End Sub

        Private Sub btnAgregar_Agente_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAgregar_Agente.Click
            ValidarAgente()
        End Sub

        Private Sub ActualizargdvAgentes()
            With dgvAgentes
                .Columns("IdAgente").Visible = False
                .Columns("IdProveedor").Visible = False
                .Columns("Nombre").Width = 325
                .Columns("Telefono1").Width = 73
                .Columns("Telefono2").Width = 73
                .Columns("Fax").Width = 73
                .Columns("Correo").Visible = False
                .Visible = True
                If .RowCount > 0 Then .Rows(0).Selected = False
            End With
        End Sub

        Private Sub ValidarAgente()
            limpiarErroresAgente()
            Dim valida As Boolean = True
            Dim oAgente As New Agente
            Dim salida As String

            ValidaVacioDevuelveCadena(valida, Trim(txtNombre_Agente.Text), oAgente.Nombre, lblNombre_Agente,
                                      "El nombre del agente no puede estar vacío", errDerechoProveedor)

            salida = _oUtilidades.TelefonoFaxValido(txtTelefono1_Agente.Text)
            oAgente.Telefono1 = RetornarValorOpcional(valida, salida, errDerechoProveedor, lblTelefono1, txtTelefono1_Agente.Text)

            salida = _oUtilidades.TelefonoFaxValidoOpcional(txtTelefono2_Agente.Text)
            oAgente.Telefono2 = RetornarValorOpcional(valida, salida, errDerechoProveedor, lblTelefono2, txtTelefono2_Agente.Text)

            salida = _oUtilidades.TelefonoFaxValidoOpcional(txtFax_Agente.Text)
            oAgente.Fax = RetornarValorOpcional(valida, salida, errDerechoProveedor, lblFax_Agente, txtFax_Agente.Text)

            salida = _oUtilidades.ValidarCorreo(txtCorreo_Agente.Text)
            oAgente.Correo = LCase(RetornarValorOpcional(valida, salida, errDerechoProveedor, lblCorreo_Agente, txtCorreo_Agente.Text))

            If valida Then
                If txtId_Agente.Text = "" Then
                    oAgente.IdAgente = -_oListaAgentes.Count
                    _oListaAgentes.Add(oAgente)
                Else
                    For i As Integer = 0 To _oListaAgentes.Count - 1
                        If _oListaAgentes(i).IdAgente = CInt(txtId_Agente.Text) Then
                            oAgente.IdAgente = CInt(txtId_Agente.Text)
                            _oListaAgentes(i) = oAgente
                        End If
                    Next
                End If
                dgvAgentes.DataSource = Nothing
                dgvAgentes.DataSource = _oListaAgentes
                ActualizargdvAgentes()
                limpiarErroresAgente()
                LimpiarAgente()
                _cambios = True
            End If

        End Sub

        Private Sub FrmProveedor_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load

            AddHandler txtCentral_Telefonica.KeyPress, AddressOf FormatoNumTelefono
            AddHandler txtFax_Principal.KeyPress, AddressOf FormatoNumTelefono
            AddHandler txtTelefono1_Agente.KeyPress, AddressOf FormatoNumTelefono
            AddHandler txtTelefono2_Agente.KeyPress, AddressOf FormatoNumTelefono
            AddHandler txtFax_Agente.KeyPress, AddressOf FormatoNumTelefono
            AddHandler txtTelefono1_Encargado.KeyPress, AddressOf FormatoNumTelefono
            AddHandler txtTelefono2_Encargado.KeyPress, AddressOf FormatoNumTelefono
            AddHandler txtFax_Encargado.KeyPress, AddressOf FormatoNumTelefono
            AddHandler txtExt1_Encargado.KeyPress, AddressOf ValidarSoloNumeros
            AddHandler txtExt2_Encargado.KeyPress, AddressOf ValidarSoloNumeros

            AddHandler dgvAgentes.MouseDown, AddressOf SeleccionaClickDerecho
            AddHandler dgvEncargados.MouseDown, AddressOf SeleccionaClickDerecho

            dgvAgentes.ContextMenuStrip = MnEliminarAgente
            dgvEncargados.ContextMenuStrip = MnEliminarEncargado

        End Sub

        Private Sub LimpiarErroresAgente()
            errDerechoProveedor.SetError(lblNombre_Agente, String.Empty)
            errDerechoProveedor.SetError(lblTelefono1, String.Empty)
            errDerechoProveedor.SetError(lblTelefono2, String.Empty)
            errDerechoProveedor.SetError(lblFax_Agente, String.Empty)
            errDerechoProveedor.SetError(lblCorreo_Agente, String.Empty)
        End Sub

        Private Sub btnAgregar_Encargado_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAgregar_Encargado.Click
            ValidarEncargado()
        End Sub

        Private Sub ValidarEncargado()
            limpiarErroresEncargado()
            Dim valida As Boolean = True
            Dim oEncargado As New Encargado
            Dim salida As String

            ValidaVacioDevuelveCadena(valida, Trim(txtNombre_Encargado.Text), oEncargado.Nombre, lblNombre_Encargado,
                                      "El nombre del encargado no puede estar vacío", errDerechoProveedor)

            salida = _oUtilidades.TelefonoFaxValido(txtTelefono1_Encargado.Text)
            oEncargado.Telefono1 = RetornarValorOpcional(valida, salida, errDerechoProveedor, lblTelefono1_Encargado, txtTelefono1_Encargado.Text)

            salida = _oUtilidades.TelefonoFaxValidoOpcional(txtTelefono2_Encargado.Text)
            oEncargado.Telefono2 = RetornarValorOpcional(valida, salida, errDerechoProveedor, lblTelefono2_Encargado, txtTelefono2_Encargado.Text)

            ValidaVacioDevuelveCadena(valida, Trim(txtServicio.Text), oEncargado.Servicio, lblServicio,
                                      "La descripción del servicio del encargado no puede estar vacío", errDerechoProveedor)

            salida = _oUtilidades.TelefonoFaxValidoOpcional(txtFax_Encargado.Text)
            oEncargado.Fax = RetornarValorOpcional(valida, salida, errDerechoProveedor, lblFax_Encargado, txtFax_Encargado.Text)

            salida = _oUtilidades.ValidarCorreo(txtCorreoEncargado.Text)
            oEncargado.Correo = LCase(RetornarValorOpcional(valida, salida, errDerechoProveedor, lblCorreoEncargado, txtCorreoEncargado.Text))

            If Trim(txtExt1_Encargado.Text) <> "" Then
                oEncargado.Ext1 = txtExt1_Encargado.Text
            Else
                oEncargado.Ext1 = 0
            End If

            If Trim(txtExt2_Encargado.Text) <> "" Then
                oEncargado.Ext2 = txtExt2_Encargado.Text
            Else
                oEncargado.Ext2 = 0
            End If

            If valida Then
                If txtId_Encargado.Text = "" Then
                    _oListaEncargado.Add(oEncargado)
                    oEncargado.IdEncargado = -_oListaEncargado.Count
                Else
                    For i As Integer = 0 To _oListaEncargado.Count - 1
                        If _oListaEncargado(i).IdEncargado = CInt(txtId_Encargado.Text) Then
                            oEncargado.IdEncargado = CInt(txtId_Encargado.Text)
                            _oListaEncargado(i) = oEncargado
                        End If
                    Next
                End If

                dgvEncargados.DataSource = Nothing
                dgvEncargados.DataSource = _oListaEncargado
                ActualizargdvEncargado()
                LimpiarErroresEncargado()
                LimpiarEncargado()
                _cambios = True
            End If

        End Sub

        Private Sub LimpiarErroresEncargado()
            errDerechoProveedor.SetError(lblNombre_Encargado, String.Empty)
            errDerechoProveedor.SetError(lblTelefono1_Encargado, String.Empty)
            errDerechoProveedor.SetError(lblTelefono2_Encargado, String.Empty)
            errDerechoProveedor.SetError(lblServicio, String.Empty)
            errDerechoProveedor.SetError(lblFax_Encargado, String.Empty)
            errDerechoProveedor.SetError(lblCorreoEncargado, String.Empty)
        End Sub

        Private Sub ActualizargdvEncargado()
            With dgvEncargados
                .Columns("IdEncargado").Visible = False
                .Columns("IdProveedor").Visible = False
                .Columns("Nombre").Width = 245
                .Columns("Servicio").Width = 220
                .Columns("Telefono1").Width = 65
                .Columns("Telefono2").Visible = False
                .Columns("Fax").Visible = False
                .Columns("Ext1").Width = 50
                .Columns("Ext2").Visible = False
                .Columns("Correo").Visible = False
                If .RowCount > 0 Then .Rows(0).Selected = False
            End With
        End Sub

        Private Sub btnInsertar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnInsertar.Click
            validaProveedor()
        End Sub

        Private Sub LimpiarErroresProveedor()
            errDerechoProveedor.SetError(lblNombre, String.Empty)
            errDerechoProveedor.SetError(lblCentral_Telefonica, String.Empty)
            errDerechoProveedor.SetError(lblFax_Principal, String.Empty)
            errDerechoProveedor.SetError(lblCorreo, String.Empty)
        End Sub

        Private Sub dgvProveedores_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles dgvProveedores.KeyDown
            If (e.KeyValue = 13) Then
                txtId_Proveedor.Text = dgvProveedores.Item(0, dgvProveedores.CurrentRow.Index).Value
                txtNombre.Text = dgvProveedores.Item(1, dgvProveedores.CurrentRow.Index).Value
                llenarProveedor(_oLogicaProveedor.Consultar(CInt(txtId_Proveedor.Text)))
            End If
        End Sub

        Private Sub dgvProveedores_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvProveedores.Click
            txtId_Proveedor.Text = dgvProveedores.Item(0, dgvProveedores.CurrentRow.Index).Value
            txtNombre.Text = dgvProveedores.Item(1, dgvProveedores.CurrentRow.Index).Value
            llenarProveedor(_oLogicaProveedor.Consultar(CInt(txtId_Proveedor.Text)))
        End Sub

        Public Sub LlenarProveedor(ByVal oProveedor As Proveedor)
            If oProveedor.IdProveedor <> 0 Then
                txtNombre.Text = oProveedor.Nombre
                txtCentral_Telefonica.Text = Trim(oProveedor.CentralTelefonica)
                txtFax_Principal.Text = Trim(oProveedor.FaxPrincipal)
                txtDireccion.Text = oProveedor.Direccion
                txtCorreo.Text = oProveedor.Correo
                txtCedula.Text = Trim(oProveedor.Cedula)
                txtCC.Text = oProveedor.CC
                txtNum_Cuenta.Text = Trim(oProveedor.NCuenta)
                dgvAgentes.DataSource = Nothing

                _oListaAgentes = oProveedor.Agentes
                dgvAgentes.DataSource = _oListaAgentes
                ActualizargdvAgentes()
                dgvEncargados.DataSource = Nothing
                _oListaEncargado = oProveedor.Encargados
                dgvEncargados.DataSource = _oListaEncargado
                _oProveedor = oProveedor
                ActualizargdvEncargado()
                dgvProveedores.Visible = False
            Else
                LimpiarTodo()
            End If
        End Sub

        Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles EliminarToolStripMenuItem.Click

            If dgvAgentes.RowCount > 0 Then
                Dim elimina As Integer

                elimina = MessageBox.Show("Esta seguro q desea eliminar el agente?", "Eliminar Agente", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If elimina = 6 Then

                    Dim idAgente As Integer = CInt(dgvAgentes.Item(0, dgvAgentes.CurrentRow.Index).Value)

                    Dim oAgente As Agente
                    oAgente = _oListaAgentes(dgvAgentes.CurrentRow.Index)

                    If idAgente <> 0 Then
                        _oListaAgentesEliminar.Add(oAgente)
                    End If

                    _oListaAgentes.RemoveAt(dgvAgentes.CurrentRow.Index)
                    dgvAgentes.DataSource = Nothing
                    dgvAgentes.DataSource = _oListaAgentes
                    ActualizargdvAgentes()
                    _cambios = True
                End If
            End If

        End Sub

        Private Sub EliminarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles EliminarToolStripMenuItem1.Click
            If dgvEncargados.RowCount > 0 Then
                Dim elimina As Integer

                elimina = MessageBox.Show("Esta seguro q desea eliminar el encargado?", "Eliminar Encargado", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If elimina = 6 Then

                    Dim idEncargado As Integer = CInt(dgvEncargados.Item(0, dgvEncargados.CurrentRow.Index).Value)

                    Dim oEncargado As Encargado
                    oEncargado = _oListaEncargado(dgvEncargados.CurrentRow.Index)

                    If idEncargado <> 0 Then
                        _oListaEncargadosEliminar.Add(oEncargado)
                    End If

                    _oListaEncargado.RemoveAt(dgvEncargados.CurrentRow.Index)
                    dgvEncargados.DataSource = Nothing
                    dgvEncargados.DataSource = _oListaEncargado
                    ActualizargdvEncargado()
                    _cambios = True
                End If
            End If
        End Sub

        Private Sub dgvAgentes_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvAgentes.Click
            With dgvAgentes
                Try
                    txtId_Agente.Text = .Item(0, .CurrentRow.Index).Value
                    txtNombre_Agente.Text = .Item(2, .CurrentRow.Index).Value
                    txtTelefono1_Agente.Text = Trim(.Item(3, .CurrentRow.Index).Value)
                    txtTelefono2_Agente.Text = Trim(.Item(4, .CurrentRow.Index).Value)
                    txtFax_Agente.Text = Trim(.Item(5, .CurrentRow.Index).Value)
                    txtCorreo_Agente.Text = Trim(.Item(6, .CurrentRow.Index).Value)
                Catch ex As Exception

                End Try
            End With

        End Sub

        Private Sub dgvEncargados_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvEncargados.Click
            With dgvEncargados
                Try
                    txtId_Encargado.Text = .Item(0, .CurrentRow.Index).Value
                    txtNombre_Encargado.Text = .Item(2, .CurrentRow.Index).Value
                    txtServicio.Text = .Item(3, .CurrentRow.Index).Value
                    txtTelefono1_Encargado.Text = Trim(.Item(4, .CurrentRow.Index).Value)
                    txtTelefono2_Encargado.Text = Trim(.Item(5, .CurrentRow.Index).Value)
                    txtExt1_Encargado.Text = Trim(.Item(6, .CurrentRow.Index).Value)
                    txtExt2_Encargado.Text = Trim(.Item(7, .CurrentRow.Index).Value)
                    txtFax_Encargado.Text = Trim(.Item(8, .CurrentRow.Index).Value)
                    txtCorreoEncargado.Text = Trim(.Item(9, .CurrentRow.Index).Value)
                Catch ex As Exception

                End Try
            End With

        End Sub

        Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnEliminar.Click

            If Trim(txtId_Proveedor.Text) <> "" And Trim(txtNombre.Text) <> "" Then
                Dim elimina As Integer

                elimina = MessageBox.Show("Esta seguro q desea eliminar el proveedor?", "Eliminar Proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If elimina = 6 Then
                    _oLogicaProveedor.EliminarProveedor(CInt(txtId_Proveedor.Text))
                    LimpiarTodo()
                End If
            Else
                MessageBox.Show("Debe de seleccionar un proveedor antes de presionar aceptar", "Eliminar proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End Sub

        Private Sub FrmProveedor_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

            If Trim(txtId_Proveedor.Text) <> "" And Trim(txtNombre.Text) <> "" Then
                Try
                    If LTrim(txtNombre.Text) <> LTrim(_oProveedor.Nombre) Or LTrim(txtCentral_Telefonica.Text) <> LTrim(_oProveedor.CentralTelefonica) Or LTrim(txtFax_Principal.Text) <> LTrim(_oProveedor.FaxPrincipal) Or _cambios = True Then
                        Dim guardar As Integer

                        guardar = MessageBox.Show("Se han realizado algunos cambios. ¿Desea guardar los cambios realizados?", "Proveedores", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                        If guardar = 6 Then
                            Dim guardo = ValidaProveedor()

                            If Not guardo Then MessageBox.Show("No se guardarón los cambios por formato inválido", "Guardar cambios proveedor", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If
                Catch ex As Exception
                    MessageBox.Show("No se guardarón los cambios por formato inválido", "Guardar cambios proveedor", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                Dispose()
            End If

            If LlamadoCatalogo Then
                Dispose()
            End If
        End Sub

        Private Sub txtId_Proveedor_MouseClick(ByVal sender As System.Object, ByVal e As Windows.Forms.MouseEventArgs) Handles txtId_Proveedor.MouseClick
            LimpiarTodo()
            txtId_Proveedor.Text = String.Empty
        End Sub

        Private Function ValidaProveedor() As Boolean
            LimpiarErroresProveedor()
            Dim valida As Boolean = True
            Dim oProveedor As New Proveedor
            Dim salida As String

            ValidaVacioDevuelveCadena(valida, Trim(txtNombre.Text), oProveedor.Nombre, lblNombre,
                                      "El nombre del proveedor no puede estar vacío", errDerechoProveedor)

            salida = _oUtilidades.TelefonoFaxValido(txtCentral_Telefonica.Text)
            oProveedor.CentralTelefonica = RetornarValorOpcional(valida, salida, errDerechoProveedor, lblCentral_Telefonica, txtCentral_Telefonica.Text)

            salida = _oUtilidades.TelefonoFaxValidoOpcional(txtFax_Principal.Text)
            oProveedor.FaxPrincipal = RetornarValorOpcional(valida, salida, errDerechoProveedor, lblFax_Principal, txtFax_Principal.Text)

            If Trim(txtDireccion.Text) = "" Then
                oProveedor.Direccion = "-"
            Else
                oProveedor.Direccion = UCase(txtDireccion.Text)
            End If

            salida = _oUtilidades.ValidarCorreo(txtCorreo.Text)
            oProveedor.Correo = LCase(RetornarValorOpcional(valida, salida, errDerechoProveedor, lblCorreo, txtCorreo.Text))

            If (_oListaAgentes.Count > 0) Or (_oListaEncargado.Count > 0) Then
                If _oListaAgentes.Count > 0 Then
                    oProveedor.Agentes = _oListaAgentes
                End If

                If _oListaEncargado.Count > 0 Then
                    oProveedor.Encargados = _oListaEncargado
                End If
            Else
                MessageBox.Show("Debe de insertar al menos un agente o un encargado", "Insertar proveedor", MessageBoxButtons.OK, MessageBoxIcon.Error)
                valida = False
            End If

            oProveedor.Cedula = UCase(Trim(txtCedula.Text))
            oProveedor.CC = UCase(Trim(txtCC.Text))
            oProveedor.NCuenta = Trim(txtNum_Cuenta.Text)

            If valida Then
                If Trim(txtId_Proveedor.Text) <> "" And Trim(txtNombre.Text) <> "" Then
                    oProveedor.IdProveedor = CInt(txtId_Proveedor.Text)
                    _oLogicaProveedor.Modificar(oProveedor, _oListaAgentesEliminar, _oListaEncargadosEliminar)
                    MessageBox.Show("Proveedor modificado con éxito", "Modificar proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    _oLogicaProveedor.Insertar(oProveedor)
                    MessageBox.Show("Proveedor insertado con éxito", "Insertar proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                If LlamadoCatalogo Then
                    Dispose()
                End If

                LimpiarTodo()
            End If

            Return valida
        End Function


        Private Sub txtDireccion_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtDireccion.KeyDown
            If (e.KeyValue = 13) Then txtNum_Cuenta.Focus()
        End Sub

        Private Sub txtCorreo_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtCorreo.KeyDown
            If (e.KeyValue = 13) Then txtDireccion.Focus()
        End Sub

        Private Sub txtCC_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtCC.KeyDown
            If (e.KeyValue = 13) Then txtCorreo.Focus()
        End Sub

        Private Sub txtCedula_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtCedula.KeyDown
            If (e.KeyValue = 13) Then txtCC.Focus()
        End Sub

        Private Sub btnListadosPendientes_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnListadosPendientes.Click
            FrmConsultaProveedores.ShowDialog()
        End Sub

        Private Sub txtNum_Cuenta_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNum_Cuenta.KeyDown
            If (e.KeyValue = 13) Then txtNombre_Agente.Focus()
        End Sub

        Private Sub txtCorreo_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtCorreo.TextChanged
            txtCorreo.CharacterCasing = CharacterCasing.Lower
        End Sub

        Private Sub txtCorreoEncargado_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtCorreoEncargado.TextChanged
            txtCorreo.CharacterCasing = CharacterCasing.Lower
        End Sub

        Private Sub txtCorreoEncargado_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtCorreoEncargado.KeyDown
            If (e.KeyValue = 13) Then btnAgregar_Encargado.Focus()
        End Sub

        Private Sub txtNombre_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
            CambiarControlADataGrid(dgvProveedores, e, txtNombre, txtCentral_Telefonica, txtCentral_Telefonica)
        End Sub

        Private Sub txtNombre_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
            BuscarProveedorPorNombre(dgvProveedores, e, txtNombre, txtId_Proveedor)
        End Sub

        Private Sub txtId_Proveedor_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtId_Proveedor.KeyPress
            Dim keyAscii As Short = CShort(Asc(e.KeyChar))
            If Not keyAscii = 13 Then
                Dim oProveedor = BuscarProveedorPorId(e, txtId_Proveedor, txtNombre)
                If oProveedor.IdProveedor <> 0 Then
                    LlenarProveedor(oProveedor)
                Else
                    LimpiarTodo()
                End If
            End If
        End Sub

        Private Sub txtId_Proveedor_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtId_Proveedor.KeyDown
            If e.KeyData = Keys.Enter And txtNombre.Text = "" Then
                txtNombre.Focus()
            ElseIf e.KeyData = Keys.Enter Then
                txtNombre.Focus()
            End If
        End Sub
    End Class
End Namespace