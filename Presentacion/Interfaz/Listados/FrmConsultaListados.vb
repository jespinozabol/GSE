Imports Logica_Negocios

Namespace Interfaz.Listados
    Public Class FrmConsultaListados

        Private ReadOnly _oLogicaListado As New LogicaListado
        Private ReadOnly _oUtilidades As New Utilidades

        Private Sub FrmConsulta_Listados_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load

            Dim listado = _oLogicaListado.consultarTodos

            For i As Integer = 0 To listado.Rows.Count - 1
                With dgvListados
                    .Rows.Add()
                    .Rows(i).Cells(0).Value = listado.Rows(i).Item(0)
                    Dim fechaListado As Date = listado.Rows(i).Item(1)
                    .Rows(i).Cells(1).Value = fechaListado.ToString("dd/MM/yyyy")
                    .Rows(i).Cells(2).Value = listado.Rows(i).Item(2)
                    .Rows(i).Cells(3).Value = listado.Rows(i).Item(3)
                    .Rows(i).Cells(4).Value = "¢" + _oUtilidades.PasarMoneda(listado.Rows(i).Item(4))
                    If .Rows.Count > 0 Then .Rows(0).Selected = False
                End With
            Next

        End Sub

        Private Sub dgvListados_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvListados.Click
            Dim idListado = dgvListados.Item(0, dgvListados.CurrentRow.Index).Value
            If FrmListado.txtId_Listado.Text <> "" Then
                _oLogicaListado.modificarBloqueo(CInt(FrmListado.txtId_Listado.Text), 0)
            End If
            FrmListado.Dispose()
            FrmListado.txtId_Listado.Text = idListado
            FrmListado.ActualizarCliente()
            FrmListado.ShowDialog()
            Dispose()
        End Sub

        Private Sub FrmConsulta_Listados_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub
    End Class
End Namespace