Imports Entidades
Imports Logica_Negocios

Namespace Interfaz.Creditos
    Public Class FrmConsultaCreditos

        Private ReadOnly _oLogicaClienteCredito As New LogicaClienteCredito
        Private ReadOnly _oUtilidades As New Utilidades
        Private ReadOnly _oLogicaVarios As New LogicaVarios
        Private ReadOnly _oLogicaPersona As New LogicaPersona
        Private ReadOnly _oLogicaTipoCredito As New LogicaTipoCredito
        Private actualizado As Boolean

        Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscar.Click
            If Not actualizado Then
                ActualizarDatos()
            End If
            LlenaDatos()
        End Sub

        Private Sub LlenaDatos()
            dgvLista.Rows.Clear()
            Dim atrasa = 0

            Dim enteFisico = 4
            If rbFisico.Checked Then
                enteFisico = 1
            ElseIf rbJuridico.Checked Then
                enteFisico = 0
            End If

            Dim tipo = 4
            If rbAbierto.Checked Then
                tipo = ClienteCredito.ListaEstado.Abierto
                atrasa = 1
            ElseIf rbCerrado.Checked Then
                tipo = ClienteCredito.ListaEstado.Cerrado
                atrasa = 3
            ElseIf rbCreditoCongelado.Checked Then
                tipo = ClienteCredito.ListaEstado.Congelado
            End If

            Dim estado = 4
            If rbAlDia.Checked Then
                estado = 0
            ElseIf rbAtrasados.Checked Then
                atrasa = 2
                estado = 1
            End If

            Dim oDataTable = _oLogicaClienteCredito.ConsultarTodos(enteFisico, tipo, estado, chkIncluirEnCobro.Checked)
            LlenarGrid(oDataTable, atrasa)
        End Sub

        Private Sub LlenarGrid(ByVal oDataTable As DataTable, ByVal atrasa As Integer)
            Dim totalGeneral As Double
            With oDataTable
                Dim nombreCliente As String
                Dim estadoCliente As String

                For i As Integer = 0 To .Rows.Count - 1
                    If .Rows(i).Item(7) Then
                        nombreCliente = .Rows(i).Item(2) & " " & .Rows(i).Item(3) & " " & .Rows(i).Item(4)
                    Else
                        nombreCliente = .Rows(i).Item(2)
                    End If

                    Dim muestra As Boolean = False
                    Dim tipoCredito = _oLogicaTipoCredito.ConsultarDato(GetTipoCredito(.Rows(i).Item(13)))

                    Select Case atrasa
                        Case 0
                            lblTotal1.Text = "Deuda por créditos"
                            totalGeneral = totalGeneral + .Rows(i).Item(8)
                            muestra = True
                        Case 1
                            lblTotal1.Text = "Deuda por créditos abiertos"
                            totalGeneral = totalGeneral + .Rows(i).Item(8)
                            muestra = True
                        Case 2
                            lblTotal1.Text = "Deuda por créditos atrasados"
                            If .Rows(i).Item(10) > tipoCredito.DiasAtraso Then
                                muestra = True
                                totalGeneral = totalGeneral + .Rows(i).Item(11)
                            End If
                        Case 3
                            lblTotal1.Text = "Deuda por créditos cerrado"
                            totalGeneral = totalGeneral + .Rows(i).Item(8)
                            muestra = True
                    End Select

                    If muestra Then
                        If .Rows(i).Item(12) Then
                            estadoCliente = "ABIERTO"
                            If .Rows(i).Item(8) > .Rows(i).Item(9) Or .Rows(i).Item(10) > 0 Then

                                Dim limite = (tipoCredito.Limite) * .Rows(i).Item(9)
                                If limite < .Rows(i).Item(8) Or .Rows(i).Item(10) > tipoCredito.Dias Then
                                    estadoCliente = "SUSPEND"
                                End If

                            End If
                            dgvLista.Rows.Add(.Rows(i).Item(1), nombreCliente, .Rows(i).Item(5), .Rows(i).Item(6), _oUtilidades.PasarMoneda(.Rows(i).Item(8)), _oUtilidades.PasarMoneda(.Rows(i).Item(9)), .Rows(i).Item(10), _oUtilidades.PasarMoneda(.Rows(i).Item(11)), estadoCliente)
                        Else
                            estadoCliente = "CERRADO"
                            dgvLista.Rows.Add(.Rows(i).Item(1), nombreCliente, .Rows(i).Item(5), .Rows(i).Item(6), _oUtilidades.PasarMoneda(.Rows(i).Item(8)), _oUtilidades.PasarMoneda(.Rows(i).Item(9)), .Rows(i).Item(10), _oUtilidades.PasarMoneda(.Rows(i).Item(11)), estadoCliente)
                            dgvLista.Rows(dgvLista.Rows.Count - 1).DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#DF2626")
                        End If
                    End If
                Next
            End With

            lblMostrarTipo.Text = "¢ " & _oUtilidades.PasarMoneda(totalGeneral)

            lblMostrarTotalGeneral.Text = "¢ " & _oUtilidades.PasarMoneda(_oLogicaClienteCredito.ConsultarTotalCreditos)
            If dgvLista.Rows.Count > 0 Then dgvLista.Rows(0).Selected = False
        End Sub


        Private Function GetTipoCredito(ByVal tipo As Integer) As String
            Select Case tipo
                Case 1
                    Return "Preferencial"
                Case 2
                    Return "Normal"
                Case 3
                    Return "Prueba"
            End Select
            Return String.Empty
        End Function

        Private Sub VerDatosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles VerDatosToolStripMenuItem.Click
            Dim idPersona = _oLogicaClienteCredito.consultarIdCliente_PorId_Credito(CInt(dgvLista.Item(0, dgvLista.CurrentRow.Index).Value))
            FrmClienteCredito.txtId_Cliente.Text = idPersona
            FrmClienteCredito.ActualizarCliente()
            FrmClienteCredito.ShowDialog()

            LlenaDatos()
        End Sub

        Private Sub VerFacturasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles VerFacturasToolStripMenuItem.Click
            Dim idPersona = _oLogicaClienteCredito.consultarIdCliente_PorId_Credito(CInt(dgvLista.Item(0, dgvLista.CurrentRow.Index).Value))
            FrmFacturaCredito.clienteCredito(idPersona)
            FrmFacturaCredito.Show()
            Close()
        End Sub

        Private Sub FrmConsulta_Creditos_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            AddHandler dgvLista.MouseDown, AddressOf seleccionaClickDerecho
            dgvLista.ContextMenuStrip = MnDatos
            actualizado = False
        End Sub

        Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnImprimir.Click
            If dgvLista.Rows.Count > 0 Then
                Dim imprime As Integer

                imprime = MessageBox.Show("Esta seguro que desea imprimir la lista de créditos?", "Imprimir lista de clientes crédito", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If imprime = 6 Then
                    Dim table As DataTable
                    Dim colum As DataColumn

                    table = New DataTable("LISTA_CREDITOS")

                    colum = New DataColumn("Id")
                    table.Columns.Add(colum)
                    colum = New DataColumn("Nombre")
                    table.Columns.Add(colum)
                    colum = New DataColumn("Telefono")
                    table.Columns.Add(colum)
                    colum = New DataColumn("Telefono2")
                    table.Columns.Add(colum)
                    colum = New DataColumn("Total_Creditos")
                    table.Columns.Add(colum)
                    colum = New DataColumn("Limite")
                    table.Columns.Add(colum)
                    colum = New DataColumn("Dias")
                    table.Columns.Add(colum)
                    colum = New DataColumn("Total_Atrasado")
                    table.Columns.Add(colum)
                    colum = New DataColumn("Estado")
                    table.Columns.Add(colum)

                    Dim paginas = _oUtilidades.CalculaPaginas((dgvLista.Rows.Count) / 26)

                    For i As Integer = 1 To paginas
                        table.Rows.Clear()
                        Dim reporte As New RptLista_Creditos
                        reporte.SetDataSource(GuardarLineas((i * 26) - 26, table))
                        reporte.SetParameterValue("numPagina", i)
                        reporte.SetParameterValue("paginas", paginas)

                        Dim nombreImpresora = _oLogicaVarios.ConsultarColumna("Imp_Medio_Oficio")
                        Dim nombrePc = _oLogicaVarios.ConsultarColumna("PC_Medio_Oficio")
                        reporte.PrintOptions.PrinterName = "\\" & nombrePc & "\" & nombreImpresora
                        reporte.PrintToPrinter(1, False, 1, 1)
                    Next

                End If
            Else
                MsgBox("No existe nada que imprimir", MsgBoxStyle.Exclamation)
            End If
        End Sub


        Private Function GuardarLineas(ByVal inicio As Integer, ByVal table As DataTable) As DataTable
            Dim indice As Integer, final As Integer
            Dim fila As DataRow

            With dgvLista
                If inicio + 26 < dgvLista.Rows.Count Then ' reviso si aun quedan 14 o mas lineas
                    final = inicio + 26
                Else
                    final = dgvLista.Rows.Count
                End If

                For indice = inicio To final - 1
                    fila = table.NewRow
                    fila.Item("Id") = dgvLista.Item(0, indice).Value
                    fila.Item("Nombre") = dgvLista.Item(1, indice).Value
                    fila.Item("Telefono") = dgvLista.Item(2, indice).Value
                    fila.Item("Telefono2") = dgvLista.Item(3, indice).Value
                    fila.Item("Total_Creditos") = dgvLista.Item(4, indice).Value
                    fila.Item("Limite") = dgvLista.Item(5, indice).Value
                    fila.Item("Dias") = dgvLista.Item(6, indice).Value
                    fila.Item("Total_Atrasado") = dgvLista.Item(7, indice).Value
                    fila.Item("Estado") = dgvLista.Item(8, indice).Value
                    table.Rows.Add(fila)
                Next indice
            End With

            Return table
        End Function

        Private Sub ActualizarDatos()
            Cursor.Current = Cursors.WaitCursor

            Dim oTblClientesCredito = _oLogicaClienteCredito.ConsultarTodos_SoloIdCredito

            For i As Integer = 0 To oTblClientesCredito.Rows.Count - 1

                Dim oClienteCredito As New ClienteCredito
                Dim lista = _oUtilidades.calcularDatos_Cliente(oTblClientesCredito.Rows(i).Item(0))

                oClienteCredito.IdCredito = oTblClientesCredito.Rows(i).Item(0)
                oClienteCredito.DiasAtrasado = lista(0)
                oClienteCredito.TotalAtrasado = lista(1)
                oClienteCredito.TotalCreditos = lista(2)

                _oLogicaClienteCredito.actualizarDatos_Credito(oClienteCredito)
            Next

            Cursor.Current = Cursors.Default
            actualizado = True
        End Sub

        Private Sub FrmConsulta_Creditos_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub

        Private Sub chkIncluirEnCobro_CheckedChanged(sender As Object, e As EventArgs) Handles chkIncluirEnCobro.CheckedChanged

        End Sub

        Private Sub rbTodos_CheckedChanged(sender As Object, e As EventArgs) Handles rbTodos.CheckedChanged
            If rbTodos.Checked Then
                chkIncluirEnCobro.Enabled = False
            End If
        End Sub

        Private Sub rbCreditoCongelado_CheckedChanged(sender As Object, e As EventArgs) Handles rbCreditoCongelado.CheckedChanged
            If rbCreditoCongelado.Checked Then
                chkIncluirEnCobro.Enabled = False
            End If
        End Sub

        Private Sub rbCerrado_CheckedChanged(sender As Object, e As EventArgs) Handles rbCerrado.CheckedChanged
            If rbCerrado.Checked Then
                chkIncluirEnCobro.Enabled = False
            End If
        End Sub

        Private Sub rbTodosEstado_CheckedChanged(sender As Object, e As EventArgs) Handles rbTodosEstado.CheckedChanged
            If rbTodosEstado.Checked Then
                chkIncluirEnCobro.Enabled = False
            End If
        End Sub

        Private Sub rbAlDia_CheckedChanged(sender As Object, e As EventArgs) Handles rbAlDia.CheckedChanged
            If rbAlDia.Checked Then
                chkIncluirEnCobro.Enabled = False
            End If
        End Sub

        Private Sub rbAbierto_CheckedChanged(sender As Object, e As EventArgs) Handles rbAbierto.CheckedChanged
            If rbAbierto.Checked And rbAtrasados.Checked Then
                chkIncluirEnCobro.Enabled = True
            End If
        End Sub

        Private Sub rbAtrasados_CheckedChanged(sender As Object, e As EventArgs) Handles rbAtrasados.CheckedChanged
            If rbAbierto.Checked And rbAtrasados.Checked Then
                chkIncluirEnCobro.Enabled = True
            End If
        End Sub
    End Class
End Namespace