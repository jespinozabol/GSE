Public Class FrmEscojeImprimeEmail

    Public tipo As Integer

    Private Sub activarLabel(ByVal label As Label)
        label.BackColor = System.Drawing.SystemColors.Highlight
    End Sub

    Private Sub desActivarLabel(ByVal label As Label)
        label.BackColor = System.Drawing.SystemColors.Control
    End Sub

    Private Sub lblImprimir_MouseEnter(sender As Object, e As EventArgs) Handles lblImprimir.MouseEnter
        activarLabel(lblImprimir)
    End Sub

    Private Sub lblImprimir_MouseLeave(sender As Object, e As EventArgs) Handles lblImprimir.MouseLeave
        desActivarLabel(lblImprimir)
    End Sub

    Private Sub lblCorreo_MouseEnter(sender As Object, e As EventArgs) Handles lblCorreo.MouseEnter
        activarLabel(lblCorreo)
    End Sub

    Private Sub lblCorreo_MouseLeave(sender As Object, e As EventArgs) Handles lblCorreo.MouseLeave
        desActivarLabel(lblCorreo)
    End Sub

    Private Sub lblImprimir_Click(sender As Object, e As EventArgs) Handles lblImprimir.Click
        tipo = 1
        Me.Close()
    End Sub

    Private Sub lblCorreo_Click(sender As Object, e As EventArgs) Handles lblCorreo.Click
        tipo = 2
        Me.Close()
    End Sub

    Private Sub FrmEscojeImprimeEmail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tipo = 0
    End Sub

    Private Sub FrmEscojeImprimeEmail_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dispose()
    End Sub
End Class