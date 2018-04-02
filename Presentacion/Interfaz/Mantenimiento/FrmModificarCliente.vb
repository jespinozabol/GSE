Imports Entidades
Imports Logica_Negocios
Imports Presentacion.Interfaz.Creditos
Imports Presentacion.Interfaz.Facturas

Namespace Interfaz.Mantenimiento
    Public Class FrmModificarCliente

        Private ReadOnly _oLogicaPersona As New LogicaPersona

        Private Sub FrmModificarCliente_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            LlenarDatos()
        End Sub

        Private Sub btnInsertar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            Dim oPersona As New Persona
            oPersona.IdPersona = CInt(txtId.Text)
            oPersona.Cedula = UCase(txtCedula.Text)
            oPersona.Nombre = UCase(txtNombre.Text)
            oPersona.PrimerApellido = UCase(txtApellido1.Text)
            oPersona.SegundoApellido = UCase(txtApellido2.Text)

            _oLogicaPersona.Modificar(oPersona)

            MessageBox.Show("Datos actualizados correctamente", "Actualizar Datos cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)

            If Formulario = 1 Then
                FrmFacturar.ActualizarCliente()
            ElseIf Formulario = 2 Then
                FrmClienteCredito.ActualizarPersona()
            Else
                FrmEmpleadoOtros.ActualizarPersona()
            End If

            Dispose()
        End Sub

        Private _varIdCliente As Integer
        Public WriteOnly Property IdCliente() As Integer
            Set(ByVal value As Integer)
                _varIdCliente = value
            End Set
        End Property

        Private _varFormulario As Integer
        Public Property Formulario() As Integer
            Get
                Return _varFormulario
            End Get
            Set(ByVal value As Integer)
                _varFormulario = value
            End Set
        End Property

        Private Sub LlenarDatos()
            Dim oPersona As Persona
            oPersona = _oLogicaPersona.Consultar(_varIdCliente)

            txtId.Text = oPersona.IdPersona
            txtCedula.Text = oPersona.Cedula
            txtNombre.Text = oPersona.Nombre
            txtApellido1.Text = oPersona.PrimerApellido
            txtApellido2.Text = oPersona.SegundoApellido
        End Sub


        Private Sub txtCedula_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtCedula.KeyDown
            If e.KeyValue = 13 Then txtNombre.Focus()
        End Sub

        Private Sub txtNombre_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
            If e.KeyValue = 13 Then txtApellido1.Focus()
        End Sub

        Private Sub txtApellido1_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtApellido1.KeyDown
            If e.KeyValue = 13 Then txtApellido2.Focus()
        End Sub

        Private Sub txtApellido2_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtApellido2.KeyDown
            If e.KeyValue = 13 Then btnGuardar.Focus()
        End Sub

        Private Sub FrmModificar_Cliente_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub
    End Class
End Namespace