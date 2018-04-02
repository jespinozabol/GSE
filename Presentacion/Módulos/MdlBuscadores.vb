Option Explicit On
Imports Logica_Negocios
Imports Entidades
Module MdlBuscadores

    Private ReadOnly Utilidades As New Utilidades
    Private ReadOnly LogicaPersona As New LogicaPersona
    Private ReadOnly LogicaProducto As New LogicaProducto
    Private ReadOnly LogicaReferencia As New LogicaReferencia
    Private ReadOnly LogicaProveedor As New LogicaProveedor
    Private ReadOnly LogicaEmpleadoYOtro As New LogicaEmpleadoOtro
    Private ReadOnly LogicaListado As New LogicaListado
    Private ReadOnly LogicaProforma As New LogicaProforma
    Private ReadOnly LogicaCliente As New LogicaClienteCredito

    Public Function BuscarPersonaPorId(ByVal e As Windows.Forms.KeyPressEventArgs, ByVal txtIdCliente As TextBox) As Persona
        Dim oPersona As Persona
        oPersona = LogicaPersona.Consultar(ExtraeId(e, txtIdCliente))
        Return oPersona
    End Function

    Public Function BuscarProductoPorCodigo(ByVal e As Windows.Forms.KeyPressEventArgs, ByVal txtCodigo As TextBox) As Producto
        Dim oProducto As Producto
        oProducto = LogicaProducto.Consultar(ExtraeId(e, txtCodigo))
        Return oProducto
    End Function

    Public Function BuscarProveedorPorId(ByVal e As Windows.Forms.KeyPressEventArgs, ByVal txtIdProveedor As TextBox, ByVal txtSiguienteFocus As TextBox) As Proveedor
        Dim oProveedor As Proveedor
        oProveedor = LogicaProveedor.Consultar(ExtraeId(e, txtIdProveedor))
        Return oProveedor
    End Function

    Public Function BuscarReferenciaPorId(ByVal e As Windows.Forms.KeyPressEventArgs, ByVal txtIdReferencia As TextBox) As Referencia
        Dim oReferencia As Referencia
        oReferencia = LogicaReferencia.Consultar(ExtraeId(e, txtIdReferencia))
        Return oReferencia
    End Function

    Public Function BuscarEmpleadoPorId(ByVal e As Windows.Forms.KeyPressEventArgs, ByVal txtIdEmpleado As TextBox) As EmpleadoOtro
        Dim oEmpleado As EmpleadoOtro
        oEmpleado = LogicaEmpleadoYOtro.consultarPorIdEmpleado(ExtraeId(e, txtIdEmpleado))
        Return oEmpleado
    End Function

    Public Function BuscarClienteCreditoPorId(ByVal e As Windows.Forms.KeyPressEventArgs, ByVal txtIdEmpleado As TextBox) As ClienteCredito
        Dim oClienteCredito As ClienteCredito
        oClienteCredito = LogicaCliente.ConsultarPorIdCredito(ExtraeId(e, txtIdEmpleado))
        Return oClienteCredito
    End Function

    Private Function ExtraeId(ByVal e As Windows.Forms.KeyPressEventArgs, ByVal txtCodigo As TextBox) As Long
        Dim keyAscii As Short = CShort(Asc(e.KeyChar))
        keyAscii = CShort(Utilidades.SoloNumeros(keyAscii))
        Dim codigo As Long = 0

        If keyAscii = 0 Then
            e.Handled = True
        Else
            Dim caracterDigitado = e.KeyChar
            Dim digitado = Convert.ToInt32(caracterDigitado)
            Dim cadena As String = txtCodigo.Text

            If Not Trim((cadena + caracterDigitado)) = "" Then
                If (digitado = 8) Then
                    Try
                        cadena = Mid(cadena, 1, cadena.Length - 1)
                        If cadena <> "" Then
                            codigo = CLng(cadena)
                        End If
                    Catch ex As Exception

                    End Try
                Else
                    codigo = CLng(Trim(cadena) + caracterDigitado)
                End If
            End If
        End If
        Return codigo
    End Function

    Public Sub BuscarPersonaPorNombre(ByVal dgvClientes As DataGridView, ByVal e As Windows.Forms.KeyPressEventArgs, ByVal txtNombre As TextBox, ByVal txtApellidos As TextBox, ByVal txtIdCliente As TextBox, ByVal txtSiguiente As TextBox)
        Dim keyAscii As Short = CShort(Asc(e.KeyChar))
        If keyAscii <> 13 Then
            Dim oTblPersonas = LogicaPersona.ConsultarPorNombre(ExtraerCadena(e, txtNombre, txtIdCliente))
            If oTblPersonas.Rows.Count > 0 Then
                With dgvClientes
                    .DataSource = oTblPersonas
                    .Columns(0).Visible = False
                    .Columns(1).Width = 290
                    .Columns(2).Visible = False
                    .Visible = True
                    .Rows(0).Selected = False
                End With
            Else
                dgvClientes.DataSource = Nothing
                dgvClientes.Visible = False
            End If
        End If
    End Sub

    Public Sub BuscarProductoPorDescripcion(ByVal dgvMostrarProductos As DataGridView, ByVal e As Windows.Forms.KeyPressEventArgs, ByVal txtDescripcion As TextBox, ByVal txtCodigo As TextBox)
        Dim keyAscii As Short = CShort(Asc(e.KeyChar))
        If keyAscii <> 13 Then
            Dim oTblProductos = LogicaProducto.ConsultarPor_Descripcion(ExtraerCadena(e, txtDescripcion, txtCodigo))
            If oTblProductos.Rows.Count > 0 Then
                With dgvMostrarProductos
                    .DataSource = oTblProductos
                    .Columns(0).HeaderText = "Código"
                    .Columns(0).Width = 50
                    .Columns("Descripcion").Width = 400
                    .Visible = True
                    .Rows(0).Selected = False
                End With
            Else
                dgvMostrarProductos.DataSource = Nothing
                dgvMostrarProductos.Visible = False
            End If
        End If
    End Sub

    Public Sub BuscarListadoPorNombre(ByVal dgvClientes As DataGridView, ByVal e As Windows.Forms.KeyPressEventArgs, ByVal txtNombre As TextBox, ByVal txtIdListado As TextBox)
        Dim keyAscii As Short = CShort(Asc(e.KeyChar))
        If keyAscii <> 13 Then
            Dim oListaListado = LogicaListado.consultarPorNombre(txtNombre.Text)
            If oListaListado.Count > 0 Then
                With dgvClientes
                    .DataSource = oListaListado
                    .Columns(0).Visible = False
                    .Columns(1).Width = 240
                    .Columns(2).Visible = False
                    .Columns(3).Visible = False
                    .Columns(4).Visible = False
                    .Columns(5).Visible = False
                    .Columns(6).Visible = False
                    .Visible = True
                    .Rows(0).Selected = False
                End With
            Else
                dgvClientes.DataSource = Nothing
                dgvClientes.Visible = False
            End If
        End If
    End Sub

    Public Sub BuscarProformaPorNombre(ByVal dgvClientes As DataGridView, ByVal e As Windows.Forms.KeyPressEventArgs, ByVal txtNombre As TextBox, ByVal txtIdListado As TextBox)
        Dim keyAscii As Short = CShort(Asc(e.KeyChar))
        If keyAscii <> 13 Then
            Dim oTblProforma = LogicaProforma.consultarPorNombre(txtNombre.Text)
            If oTblProforma.Count > 0 Then
                With dgvClientes
                    .DataSource = oTblProforma
                    .Columns(0).Width = 30
                    .Columns(1).Width = 200
                    .Columns(2).Width = 75
                    .Columns(3).Visible = False
                    .Columns(4).Visible = False
                    .Visible = True
                    .Rows(0).Selected = False
                End With
            Else
                dgvClientes.DataSource = Nothing
                dgvClientes.Visible = False
            End If
        End If
    End Sub

    Public Sub BuscarClienteCreditoPorNombre(ByVal dgvClientes As DataGridView, ByVal e As Windows.Forms.KeyPressEventArgs, ByVal txtNombre As TextBox, ByVal txtIdCredito As TextBox)
        Dim keyAscii As Short = CShort(Asc(e.KeyChar))
        If keyAscii <> 13 Then
            Dim oTblClientes = LogicaCliente.ConsultarPor_NombreConCredito(txtNombre.Text)
            If oTblClientes.Rows.Count > 0 Then
                With dgvClientes
                    .DataSource = oTblClientes
                    .Columns(0).Visible = False
                    .Columns(1).Visible = False
                    .Columns(2).Width = 325
                    .Columns(3).Visible = False
                    .Visible = True
                    .Rows(0).Selected = False
                End With
            Else
                dgvClientes.DataSource = Nothing
                dgvClientes.Visible = False
            End If
        End If
    End Sub

    Public Sub BuscarProveedorPorNombre(ByVal dgvProveedores As DataGridView, ByVal e As Windows.Forms.KeyPressEventArgs, ByVal txtNombre As TextBox, ByVal txtIdProveedor As TextBox)
        Dim keyAscii As Short = CShort(Asc(e.KeyChar))
        If keyAscii <> 13 Then
            Dim oTblProveedores = LogicaProveedor.ConsultarPorNombre(txtNombre.Text)
            If oTblProveedores.Rows.Count > 0 Then
                With dgvProveedores
                    .DataSource = oTblProveedores
                    .Columns("Id_Proveedor").Visible = False
                    .Columns("Nombre").Width = 250
                    .Visible = True
                    .Rows(0).Selected = False
                End With
            Else
                dgvProveedores.DataSource = Nothing
                dgvProveedores.Visible = False
            End If
        End If
    End Sub

    Private Function ExtraerCadena(ByVal e As Windows.Forms.KeyPressEventArgs, ByVal txtBusqueda As TextBox, ByVal txtId As TextBox) As String
        Dim keyAscii As Short = CShort(Asc(e.KeyChar))
        If keyAscii <> 13 Then
            If txtBusqueda.Text.Length = 1 Then
                txtId.Text = String.Empty
            End If

            If Trim(txtBusqueda.Text.Length) > 0 And txtId.Text.Length = 0 Then
                Return txtBusqueda.Text + e.KeyChar
            End If
        End If

        Return ""
    End Function

    Public Function BuscarFila( _
     ByVal columna As String, _
     ByVal texto As String, _
     ByVal oTblBusqueda As DataTable) As Integer

        Dim bindingSource As Windows.Forms.BindingSource = New BindingSource
        bindingSource.DataSource = oTblBusqueda

        Try
            ' si está vacio salir y no retornar nada   
            If bindingSource.DataSource Is Nothing Then
                Return -1
            End If

            ' Ejecutar el método Find pasándole los datos   
            Dim fila As Integer = bindingSource.Find(columna.Trim, texto)

            ' Mover el cursor a la fila obtenida   
            bindingSource.Position = fila

            ' retornar el valor   
            Return fila

            ' errores   
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try

        Return -1
    End Function
End Module