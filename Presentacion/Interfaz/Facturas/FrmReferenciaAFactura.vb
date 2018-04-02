Imports Logica_Negocios

Namespace Interfaz.Facturas
    Public Class FrmReferenciaAFactura

        Private ReadOnly _oLogicaFactura As New LogicaFacturar

        Private Sub txtId_Referencia_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtId_Referencia.KeyPress
            Dim keyAscii As Short = CShort(Asc(e.KeyChar))
            If Not keyAscii = 13 Then
                Dim oReferencia = BuscarReferenciaPorId(e, txtId_Referencia)
                If oReferencia.IdReferencia <> 0 Then
                    txtNombre_Referencia.Text = oReferencia.Nombre
                Else
                    txtNombre_Referencia.Text = ""
                End If
            End If
        End Sub

        Private Sub txtId_Referencia_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtId_Referencia.KeyDown
            If e.KeyData = Keys.Enter And txtNombre_Referencia.Text <> "" Then
                btnAsigar.Focus()
            End If
        End Sub

        Private Sub btnAsigar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAsigar.Click
            If IsNumeric(txtId_Referencia.Text) And txtNombre_Referencia.Text <> "" Then
                Dim respuesta As String
                respuesta = MsgBox("Esta seguro que desea asignar esta referencia?", vbQuestion + vbYesNo, "Asignar referencia...")

                If respuesta = vbYes Then
                    _oLogicaFactura.asignarReferencia(CInt(txtNumFactura.Text), CInt(txtId_Referencia.Text))
                    MsgBox("Referencia asignada con éxito", MsgBoxStyle.Information)
                End If
            Else
                MsgBox("Inserte la referencia a asignar", MsgBoxStyle.Exclamation)
            End If
        End Sub

        Public Sub LlenarCampos(ByVal numFactura As Integer, ByVal nombre As String)
            txtNumFactura.Text = numFactura
            txtNombre.Text = nombre
        End Sub

        Private Sub FrmReferencia_a_Factura_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub
    End Class
End Namespace