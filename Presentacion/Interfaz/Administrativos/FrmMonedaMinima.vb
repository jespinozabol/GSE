Imports Logica_Negocios

Namespace Interfaz.Administrativos
    Public Class FrmMonedaMinima

        Private ReadOnly _oLogicaMoneda As New LogicaMoneda

        Private Sub FrmMoneda_Minima_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            txtMoneda.Text = _oLogicaMoneda.consultarMoneda
            AddHandler txtMoneda.KeyPress, AddressOf ValidarSoloNumeros
        End Sub

        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            Dim respuesta As String
            respuesta = MsgBox("Esta seguro que desea cambiar la moneda?", vbCritical + vbYesNo, "Modificar moneda...")

            If (respuesta = vbYes) Then
                If Trim(txtMoneda.Text) <> "" Then
                    _oLogicaMoneda.modificar(CDbl(txtMoneda.Text))
                    MsgBox("Moneda modificada con éxito", MsgBoxStyle.Information)
                Else
                    MsgBox("No debe dejar el campo en blanco", MsgBoxStyle.Exclamation)
                End If
            End If
        End Sub

        Private Sub FrmMoneda_Minima_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub
    End Class
End Namespace