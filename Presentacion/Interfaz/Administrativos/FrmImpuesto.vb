Imports Logica_Negocios
Namespace Interfaz.Administrativos
    Public Class FrmImpuesto

        Private ReadOnly _oLogicaImpuesto As New LogicaImpuesto

        Private Sub FrmImpuesto_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            txtImpuesto.Text = _oLogicaImpuesto.consultarImpuesto
            AddHandler txtImpuesto.KeyPress, AddressOf ValidarNumerosPunto
        End Sub

        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            Dim respuesta As String

            respuesta = MsgBox("Esta seguro que desea cambiar el impuesto?", vbCritical + vbYesNo, "Modificar Impuesto...")

            If (respuesta = vbYes) Then
                If Trim(txtImpuesto.Text) <> "" Then
                    _oLogicaImpuesto.modificar(CDbl(txtImpuesto.Text))
                    MsgBox("Impuesto modificado con éxito")
                Else
                    MsgBox("No debe dejar el campo en blanco")
                End If
            End If
        End Sub

        Private Sub FrmImpuesto_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub
    End Class
End Namespace