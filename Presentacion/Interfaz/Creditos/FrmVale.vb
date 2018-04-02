Imports Logica_Negocios
Imports Entidades

Namespace Interfaz.Creditos

    Public Class FrmVale

        Private ReadOnly _oLogicaVale As New LogicaVale
        Private ReadOnly _oUtilidades As New Utilidades
        Private ReadOnly _oLogicaEmpleadoOtro As New LogicaEmpleadoOtro
        Private ReadOnly _oLogicaPersona As New LogicaPersona
        Private _oListaEmpleados As List(Of EmpleadoOtro)
        Private ReadOnly _oLogicaFlujoCaja As New LogicaFlujoCaja
        Private ReadOnly _oLogicaVarios As New LogicaVarios

        Private Sub FrmVale_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            If FrmPrincipal.lblCerrarSesion.Visible Then
                btnEliminar.Visible = True
            End If

            AddHandler txtMonto.KeyPress, AddressOf validarSoloNumeros

            cmbSolicitante.Items.Clear()
            cmbAutorizado.Items.Clear()
            cmbSolicitante.Text = String.Empty
            cmbAutorizado.Text = String.Empty
            _oListaEmpleados = _oLogicaEmpleadoOtro.consultarTodos
            For i As Integer = 0 To _oListaEmpleados.Count - 1
                Dim persona = _oLogicaPersona.Consultar(_oListaEmpleados(i).IdPersona)
                cmbSolicitante.Items.Add(persona.Nombre + " " + persona.PrimerApellido + " " + persona.SegundoApellido)
                cmbAutorizado.Items.Add(persona.Nombre + " " + persona.PrimerApellido + " " + persona.SegundoApellido)
            Next

            ConsultarTodos()
        End Sub

        Private Sub ConsultarTodos()
            dgvVales.Rows.Clear()
            dgvVales.DataSource = Nothing
            Dim oTblVales = _oLogicaVale.consultarTodos
            For i As Integer = 0 To oTblVales.Count - 1
                Dim idPersonaSolicitante As Integer
                Dim idPersonaAutorizado As Integer

                For j = 0 To _oListaEmpleados.Count - 1
                    If _oListaEmpleados(j).IdEmpleado = oTblVales(i).Solicitante Then
                        idPersonaSolicitante = _oListaEmpleados(j).IdPersona
                        Exit For
                    End If
                Next

                For j = 0 To _oListaEmpleados.Count - 1
                    If _oListaEmpleados(j).IdEmpleado = oTblVales(i).Autorizado Then
                        idPersonaAutorizado = _oListaEmpleados(j).IdPersona
                        Exit For
                    End If
                Next

                Dim idSolicitante = _oLogicaPersona.Consultar(idPersonaSolicitante)
                Dim autorizado = _oLogicaPersona.Consultar(idPersonaAutorizado)
                Dim nombreSolicitante = idSolicitante.Nombre + " " + idSolicitante.PrimerApellido + " " + idSolicitante.SegundoApellido
                Dim nombreAutorizado = autorizado.Nombre + " " + autorizado.PrimerApellido + " " + autorizado.SegundoApellido
                dgvVales.Rows.Add(oTblVales(i).Num_Vale, oTblVales(i).Fecha, nombreSolicitante, "¢" + oTblVales(i).Monto.ToString, nombreAutorizado)
            Next i

            If dgvVales.Rows.Count > 0 Then dgvVales.Rows(0).Selected = False
        End Sub

        Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnLimpiar.Click
            LimpiarTodo()
        End Sub

        Private Sub LimpiarTodo()
            txtMonto.Text = String.Empty
            txtNum_vale.Text = String.Empty
            lblMostrarHora.Text = String.Empty
            lblMostrarFecha.Text = String.Empty
            txtObservaciones.Text = String.Empty
            cmbSolicitante.Text = String.Empty
            cmbAutorizado.Text = String.Empty
            cmbAutorizado.SelectedIndex = -1
            cmbSolicitante.SelectedIndex = -1
            txtMonto.ReadOnly = False
            txtObservaciones.ReadOnly = False
            btnGuardar.Enabled = True
            ConsultarTodos()
        End Sub

        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            ValidaVale()
        End Sub

        Private Sub ValidaVale()
            errorVale.Clear()
            Dim valida As Boolean = True
            Dim oVale As New Vale

            If Trim(txtMonto.Text) = "" Then
                errorVale.SetError(lblMonto, "El monto del vale no puede estar vacío")
                valida = False
            Else
                oVale.Monto = CDbl(txtMonto.Text)
            End If

            oVale.Fecha = Now.Date
            oVale.Hora = Now.ToString("H:mm:ss")

            If cmbSolicitante.SelectedIndex < 0 Then
                errorVale.SetError(lblSolicitante, "Debe de seleccionar la persona que solicita el vale")
                valida = False
            Else
                oVale.Solicitante = _oListaEmpleados.Item(cmbSolicitante.SelectedIndex).IdEmpleado
            End If

            If cmbAutorizado.SelectedIndex < 0 Then
                errorVale.SetError(lblAutorizado, "Debe de seleccionar la persona que autoriza el vale")
                valida = False
            Else
                oVale.Autorizado = _oListaEmpleados.Item(cmbAutorizado.SelectedIndex).IdEmpleado
            End If

            oVale.Observaciones = UCase(txtObservaciones.Text)

            If valida Then

                Dim imprime As Integer

                imprime = MessageBox.Show("Esta seguro q desea impirmir este vale?", "Imprimir vale", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If imprime = 6 Then
                    If Trim(txtNum_vale.Text) = "" Then
                        _oLogicaVale.insertar(oVale)
                        Dim oFlujoCaja As New FlujoCaja

                        Dim nueva = _oLogicaFlujoCaja.consultarNuevo(Now.Date)

                        If nueva Then
                            oFlujoCaja.Vale = oVale.Monto
                            oFlujoCaja.Fecha = Now.Date
                            oFlujoCaja.Efectivo = 0
                            oFlujoCaja.Cheques = 0
                            oFlujoCaja.Transferencia = 0
                            oFlujoCaja.Tarjeta = 0
                            oFlujoCaja.DolaresColones = 0
                            oFlujoCaja.Redondeo = 0
                            oFlujoCaja.Creditos = 0
                            oFlujoCaja.Vuelto = 0
                            _oLogicaFlujoCaja.insertar(oFlujoCaja)
                        Else
                            oFlujoCaja.Vale = oVale.Monto
                            oFlujoCaja.Fecha = Now.Date
                            _oLogicaFlujoCaja.modificar(oFlujoCaja)
                        End If

                        Dim rptVale As New RptVale

                        rptVale.SetParameterValue("hora", oVale.Hora)
                        rptVale.SetParameterValue("fecha", oVale.Fecha)
                        rptVale.SetParameterValue("monto", oVale.Monto)
                        rptVale.SetParameterValue("solicitante", cmbSolicitante.SelectedItem)
                        rptVale.SetParameterValue("monto_Letras", _oUtilidades.Num_A_Letras(oVale.Monto) + " COLONES NETOS.")
                        rptVale.SetParameterValue("autoriza", cmbAutorizado.SelectedItem)
                        rptVale.SetParameterValue("observaciones", oVale.Observaciones)

                        Dim nombreImpresora = _oLogicaVarios.ConsultarColumna("Imp_Tercio_Oficio")
                        Dim nombrePc = _oLogicaVarios.ConsultarColumna("PC_Tercio_Oficio")
                        rptVale.PrintOptions.PrinterName = "\\" & nombrePc & "\" & nombreImpresora
                        rptVale.PrintToPrinter(1, False, 1, 1)

                    End If

                    LimpiarTodo()
                End If

            End If
        End Sub

        Private Sub dgvVales_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvVales.Click
            With dgvVales
                Try
                    txtNum_vale.Text = .Item(0, .CurrentRow.Index).Value
                    Dim oVale = _oLogicaVale.consultarNumVale(CInt(txtNum_vale.Text))

                    lblMostrarFecha.Text = oVale.Fecha
                    lblMostrarHora.Text = oVale.Hora
                    txtMonto.Text = oVale.Monto

                    For j = 0 To _oListaEmpleados.Count - 1
                        If _oListaEmpleados(j).IdEmpleado = oVale.Solicitante Then
                            cmbSolicitante.SelectedIndex = j
                            Exit For
                        End If
                    Next

                    For j = 0 To _oListaEmpleados.Count - 1
                        If _oListaEmpleados(j).IdEmpleado = oVale.Autorizado Then
                            cmbAutorizado.SelectedIndex = j
                            Exit For
                        End If
                    Next

                    txtObservaciones.Text = oVale.Observaciones
                    txtMonto.ReadOnly = True
                    txtObservaciones.ReadOnly = True
                    btnGuardar.Enabled = False
                Catch ex As Exception

                End Try
            End With
        End Sub

        Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnEliminar.Click
            If Trim(txtNum_vale.Text) <> "" Then
                Dim elimina As Integer

                elimina = MessageBox.Show("Esta seguro q desea eliminar este vale?", "Eliminar vale", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If elimina = 6 Then
                    _oLogicaVale.eliminar(CInt(txtNum_vale.Text))
                    LimpiarTodo()
                End If
            Else
                MessageBox.Show("Debe de seleccionar un vale antes de presionar eliminar", "Eliminar proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Sub

        Private Sub FrmVale_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub
    End Class
End Namespace