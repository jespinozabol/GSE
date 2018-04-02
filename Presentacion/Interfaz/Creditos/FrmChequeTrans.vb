Imports Logica_Negocios
Imports Presentacion.Interfaz.Facturas

Namespace Interfaz.Creditos
    Public Class FrmChequeTrans

        Public Tipo As Integer '1 cheque 2 transferencia
        Private ReadOnly _oUtilidades As New Utilidades
        Private _cadena As String = ""
        Private _monto As Double

        Private Sub FrmChequeTrans_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            If Tipo = 2 Then
                lbl1.Text = "Transferencia"
                lblNum.Text = "# Transferencia"
            End If

            AddHandler txtMonto1.KeyPress, AddressOf ValidarNumerosPunto
            AddHandler txtMonto2.KeyPress, AddressOf ValidarNumerosPunto
            AddHandler txtMonto3.KeyPress, AddressOf ValidarNumerosPunto
            AddHandler txtMonto4.KeyPress, AddressOf ValidarNumerosPunto

            AddHandler txtFecha1.KeyPress, AddressOf FormatoFecha
            AddHandler txtFecha2.KeyPress, AddressOf FormatoFecha
            AddHandler txtFecha3.KeyPress, AddressOf FormatoFecha
            AddHandler txtFecha4.KeyPress, AddressOf FormatoFecha
        End Sub

        Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnLimpiar.Click
            txtMonto1.Text = String.Empty
            txtMonto2.Text = String.Empty
            txtMonto3.Text = String.Empty
            txtMonto4.Text = String.Empty
            txtNum1.Text = String.Empty
            txtNum2.Text = String.Empty
            txtNum3.Text = String.Empty
            txtNum4.Text = String.Empty
            cb1.SelectedIndex = -1
            cb2.SelectedIndex = -1
            cb3.SelectedIndex = -1
            cb4.SelectedIndex = -1
            cb1.Text = String.Empty
            cb2.Text = String.Empty
            cb3.Text = String.Empty
            cb4.Text = String.Empty
        End Sub

        Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAceptar.Click
            If Tipo = 1 Then
                If Validar() Then
                    FrmFlujoCaja.txtCheques.Text = _oUtilidades.PasarMoneda(_monto)
                    FrmFlujoCaja.cadenaCheque = _cadena
                    Dispose()
                End If
            Else
                If Validar() Then
                    FrmFlujoCaja.txtTransferencia.Text = _oUtilidades.PasarMoneda(_monto)
                    FrmFlujoCaja.cadenaTrans = _cadena
                    Dispose()
                End If
            End If
        End Sub

        Private Function Validar()
            Dim valido = False

            If txtNum1.Text <> "" And cb1.SelectedIndex <> -1 And txtMonto1.Text <> "" And txtFecha1.Text <> "" Then
                _cadena += "CH#" & txtNum1.Text & "-" & txtFecha1.Text & "-" & cb1.SelectedItem & " x ¢" & txtMonto1.Text
                _monto = _monto + CDbl(txtMonto1.Text)
                valido = True
            Else
                MsgBox("Debe de completar los 3 valores de la linea #1 antes de presionar aceptar")
            End If

            If txtNum2.Text <> "" And cb2.SelectedIndex <> -1 And txtMonto2.Text <> "" And txtFecha2.Text <> "" Then
                _cadena += " /CH#" & txtNum2.Text & "-" & txtFecha2.Text & "-" & cb2.SelectedItem & " x ¢" & txtMonto2.Text
                _monto = _monto + CDbl(txtMonto2.Text)
                valido = True
            End If

            If txtNum3.Text <> "" And cb3.SelectedIndex <> -1 And txtMonto3.Text <> "" And txtFecha3.Text <> "" Then
                _cadena += " /CH#" & txtNum3.Text & "-" & txtFecha3.Text & "-" & cb3.SelectedItem & " x ¢" & txtMonto3.Text
                _monto = _monto + CDbl(txtMonto3.Text)
                valido = True
            End If

            If txtNum4.Text <> "" And cb4.SelectedIndex <> -1 And txtMonto4.Text <> "" And txtFecha4.Text <> "" Then
                _cadena += " /CH#" & txtNum4.Text & "-" & txtFecha4.Text & "-" & cb4.SelectedItem & " x ¢" & txtMonto4.Text
                _monto = _monto + CDbl(txtMonto4.Text)
                valido = True
            End If

            If Tipo = 2 Then
                _cadena = _cadena.Replace("CH", "TR")
            End If

            Return valido
        End Function

        Private Sub txtNum1_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNum1.KeyDown
            If e.KeyValue = 13 Then txtFecha1.Focus()
        End Sub

        Private Sub txtNum2_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNum2.KeyDown
            If e.KeyValue = 13 Then txtFecha2.Focus()
        End Sub

        Private Sub txtNum3_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNum3.KeyDown
            If e.KeyValue = 13 Then txtFecha3.Focus()
        End Sub

        Private Sub cb1_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles cb1.KeyDown
            If e.KeyValue = 13 Then txtMonto1.Focus()
        End Sub

        Private Sub txtMonto1_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtMonto1.KeyDown
            If e.KeyValue = 13 Then
                If (IsNumeric(txtMonto1.Text)) Then
                    txtMonto1.Text = _oUtilidades.PasarMoneda(CDbl(txtMonto1.Text))
                End If
                txtNum2.Focus()
            End If
        End Sub

        Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblFecha.Click

        End Sub

        Private Sub txtFecha1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFecha1.KeyDown
            If e.KeyValue = 13 Then cb1.Focus()
        End Sub

        Private Sub txtFecha2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFecha2.KeyDown
            If e.KeyValue = 13 Then cb2.Focus()
        End Sub

        Private Sub txtFecha3_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFecha3.KeyDown
            If e.KeyValue = 13 Then cb3.Focus()
        End Sub

        Private Sub FrmChequeTrans_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub

        Private Sub cb2_KeyDown(sender As Object, e As KeyEventArgs) Handles cb2.KeyDown
            If e.KeyValue = 13 Then txtMonto2.Focus()
        End Sub

        Private Sub cb3_KeyDown(sender As Object, e As KeyEventArgs) Handles cb3.KeyDown
            If e.KeyValue = 13 Then txtMonto3.Focus()
        End Sub

        Private Sub txtMonto2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMonto2.KeyDown
            If e.KeyValue = 13 Then
                If (IsNumeric(txtMonto2.Text)) Then
                    txtMonto2.Text = _oUtilidades.PasarMoneda(CDbl(txtMonto2.Text))
                End If
                txtNum3.Focus()
            End If
        End Sub

        Private Sub txtMonto3_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMonto3.KeyDown
            If e.KeyValue = 13 Then
                If (IsNumeric(txtMonto3.Text)) Then
                    txtMonto3.Text = _oUtilidades.PasarMoneda(CDbl(txtMonto3.Text))
                End If
                txtNum4.Focus()
            End If
        End Sub

        Private Sub txtNum4_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNum4.KeyDown
            If e.KeyValue = 13 Then txtFecha4.Focus()
        End Sub

        Private Sub txtFecha4_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFecha4.KeyDown
            If e.KeyValue = 13 Then cb4.Focus()
        End Sub

        Private Sub cb4_KeyDown(sender As Object, e As KeyEventArgs) Handles cb4.KeyDown
            If e.KeyValue = 13 Then txtMonto4.Focus()
        End Sub

        Private Sub txtMonto4_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMonto4.KeyDown
            If e.KeyValue = 13 Then
                If (IsNumeric(txtMonto4.Text)) Then
                    txtMonto4.Text = _oUtilidades.PasarMoneda(CDbl(txtMonto4.Text))
                End If
                btnAceptar.Focus()
            End If
        End Sub
    End Class
End Namespace