Imports Logica_Negocios

Namespace Interfaz.Proveedores
    Public Class FrmChequeTransDocPorPagar

        Public Tipo As Integer '1 cheque 2 transferencia
        Private ReadOnly _oUtilidades As New Utilidades
        Private _cadena As String
        Private _monto As Double

        Private Sub FrmChequeTrans_DocPorPagar_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            If Tipo = 2 Then
                lbl1.Text = "Transferencia"
                lblNum.Text = "# Transferencia"
            End If

            AddHandler txtMonto1.KeyPress, AddressOf ValidarNumerosPunto
            AddHandler txtMonto2.KeyPress, AddressOf ValidarNumerosPunto
            AddHandler txtMonto3.KeyPress, AddressOf ValidarNumerosPunto
        End Sub

        Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnLimpiar.Click
            txtMonto1.Text = String.Empty
            txtMonto2.Text = String.Empty
            txtMonto3.Text = String.Empty
            txtNum1.Text = String.Empty
            txtNum2.Text = String.Empty
            txtNum3.Text = String.Empty
            cb1.SelectedIndex = -1
            cb2.SelectedIndex = -1
            cb3.SelectedIndex = -1
            cb1.Text = String.Empty
            cb2.Text = String.Empty
            cb3.Text = String.Empty
        End Sub

        Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAceptar.Click
            If Tipo = 1 Then
                If validar() Then
                    FrmFormaPago.txtCheques.Text = _oUtilidades.PasarMoneda(_monto)
                    FrmFormaPago.cadenaCheque = _cadena
                    Dispose()
                End If
            Else
                If validar() Then
                    FrmFormaPago.txtTransferencia.Text = _oUtilidades.PasarMoneda(_monto)
                    FrmFormaPago.cadenaTrans = _cadena
                    Dispose()
                End If
            End If
        End Sub

        Private Function Validar()
            Dim valido = False

            If txtNum1.Text <> "" And cb1.SelectedIndex <> -1 And txtMonto1.Text <> "" Then
                _cadena += " CH#" & txtNum1.Text & "-" & cb1.SelectedItem & " x ¢" & txtMonto1.Text
                _monto = _monto + CDbl(txtMonto1.Text)
                valido = True
            Else
                MsgBox("Debe de completar los 3 valores de la linea #1 antes de presionar aceptar")
            End If

            If txtNum2.Text <> "" And cb2.SelectedIndex <> -1 And txtMonto2.Text <> "" Then
                _cadena += " /CH#" & txtNum2.Text & "-" & cb2.SelectedItem & " x ¢" & txtMonto2.Text
                _monto = _monto + CDbl(txtMonto2.Text)
                valido = True
            End If

            If txtNum3.Text <> "" And cb3.SelectedIndex <> -1 And txtMonto2.Text <> "" Then
                _cadena += " /CH#" & txtNum3.Text & "-" & cb3.SelectedItem & " x ¢" & txtMonto3.Text
                _monto = _monto + CDbl(txtMonto3.Text)
                valido = True
            End If

            If Tipo = 2 Then
                _cadena = _cadena.Replace("CH", "TR")
            End If

            Return valido
        End Function

        Private Sub txtNum1_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNum1.KeyDown
            If e.KeyValue = 13 Then cb1.Focus()
        End Sub

        Private Sub txtNum2_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNum2.KeyDown
            If e.KeyValue = 13 Then cb2.Focus()
        End Sub

        Private Sub txtNum3_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNum3.KeyDown
            If e.KeyValue = 13 Then cb3.Focus()
        End Sub

        Private Sub cb1_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles cb1.KeyDown
            If e.KeyValue = 13 Then txtMonto1.Focus()
        End Sub

        Private Sub txtMonto1_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtMonto1.KeyDown
            If e.KeyValue = 13 Then btnAceptar.Focus()
        End Sub

        Private Sub FrmChequeTransDocPorPagar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub
    End Class
End Namespace