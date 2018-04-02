Imports Logica_Negocios

Namespace Interfaz.Facturas
    Public Class FrmCaja

        Private ReadOnly _oLogicaFlujoCaja As New LogicaFlujoCaja
        Private ReadOnly _oUtilidades As New Utilidades
        Private _ambos As Boolean = False
        Dim _ctrl As Boolean, _a As Boolean, _s As Boolean
        Private Const VbKeyA = 65
        Private Const VbKeyS = 83
        Private Const VbKeyControl = 18

        Private Sub FrmCaja_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            dtpFecha.Value = New DateTime(Now.Year, Now.Month, Now.Day)
        End Sub

        Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnLimpiar.Click
            lblMostrar_Cheques.Text = "0.00"
            lblMostrar_Efectivo.Text = "0.00"
            lblMostrar_Tarjetas.Text = "0.00"
            lblMostrar_Transf.Text = "0.00"
            lblMostrar_Otros.Text = "0.00"
            lblMostrarTotal.Text = "0.00"
            lblMostrar_Equivalencia.Text = "0.00"
            lblMostrar_Vales.Text = "0.00"
            lblMostrar_OtrosIngresos.Text = "0.00"
            lblMostrar_TotalGeneral.Text = "0.00"
            lblMostrar_Redondeo.Text = "0.00"
            lblMostrar_Ventas.Text = "0.00"
            lblMostrar_Creditos.Text = "0.00"
            _ambos = False
            dtpFecha.Value = New DateTime(Now.Year, Now.Month, Now.Day)
        End Sub

        Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCalcular.Click
            If _ambos Then
                Dim flujo = _oLogicaFlujoCaja.consultarFlujo(dtpFecha.Value)
                Dim flujo2 = _oLogicaFlujoCaja.consultarFlujo_Otro(dtpFecha.Value)

                lblMostrar_Efectivo.Text = _oUtilidades.PasarMoneda(flujo.Efectivo + flujo2.Efectivo)
                lblMostrar_Otros.Text = _oUtilidades.PasarMoneda(flujo.Vuelto + flujo2.Vuelto)
                lblMostrar_Cheques.Text = _oUtilidades.PasarMoneda(flujo.Cheques + flujo2.Cheques)
                lblMostrar_Redondeo.Text = _oUtilidades.PasarMoneda(flujo.Redondeo + flujo2.Redondeo)
                lblMostrar_Equivalencia.Text = _oUtilidades.PasarMoneda(flujo.DolaresColones + flujo2.DolaresColones)

                lblMostrar_Vales.Text = _oUtilidades.PasarMoneda(flujo.Vale)

                If flujo.Vale > 0 Then
                    lblMostrar_Vales.ForeColor = Color.Red
                End If

                lblMostrarTotal.Text = _oUtilidades.PasarMoneda(flujo.Cheques + flujo.Efectivo + flujo.DolaresColones - flujo.Vuelto + flujo2.Cheques + flujo2.Efectivo + flujo2.DolaresColones - flujo2.Vuelto - flujo.Vale)

                lblMostrar_Tarjetas.Text = _oUtilidades.PasarMoneda(flujo.Tarjeta + flujo2.Tarjeta)
                lblMostrar_Transf.Text = _oUtilidades.PasarMoneda(flujo.Transferencia + flujo2.Transferencia)
                lblMostrar_OtrosIngresos.Text = _oUtilidades.PasarMoneda(CDbl(lblMostrar_Tarjetas.Text) + CDbl(lblMostrar_Transf.Text))

                lblMostrar_TotalGeneral.Text = _oUtilidades.PasarMoneda(CDbl(lblMostrarTotal.Text) + CDbl(lblMostrar_OtrosIngresos.Text))

                lblMostrar_Creditos.Text = _oUtilidades.PasarMoneda(flujo.Creditos + flujo2.Creditos)
            Else
                Dim flujo = _oLogicaFlujoCaja.consultarFlujo(dtpFecha.Value)

                lblMostrar_Efectivo.Text = _oUtilidades.PasarMoneda(flujo.Efectivo)
                lblMostrar_Otros.Text = _oUtilidades.PasarMoneda(flujo.Vuelto)
                lblMostrar_Cheques.Text = _oUtilidades.PasarMoneda(flujo.Cheques)
                lblMostrar_Redondeo.Text = _oUtilidades.PasarMoneda(flujo.Redondeo)
                lblMostrar_Equivalencia.Text = _oUtilidades.PasarMoneda(flujo.DolaresColones)

                lblMostrar_Vales.Text = _oUtilidades.PasarMoneda(flujo.Vale)

                If flujo.Vale > 0 Then
                    lblMostrar_Vales.ForeColor = Color.Red
                End If

                lblMostrarTotal.Text = _oUtilidades.PasarMoneda(flujo.Cheques + flujo.Efectivo + flujo.DolaresColones - flujo.Vuelto - flujo.Vale)

                lblMostrar_Tarjetas.Text = _oUtilidades.PasarMoneda(flujo.Tarjeta)
                lblMostrar_Transf.Text = _oUtilidades.PasarMoneda(flujo.Transferencia)
                lblMostrar_OtrosIngresos.Text = _oUtilidades.PasarMoneda(flujo.Tarjeta + flujo.Transferencia)

                lblMostrar_TotalGeneral.Text = _oUtilidades.PasarMoneda(CDbl(lblMostrarTotal.Text) + CDbl(lblMostrar_OtrosIngresos.Text))

                lblMostrar_Creditos.Text = _oUtilidades.PasarMoneda(flujo.Creditos)
            End If


        End Sub

        Private Sub FrmCaja_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            'Verifica las teclas Alt - Ctrl y la A   
            If e.KeyCode = VbKeyControl Then _ctrl = True
            If e.KeyCode = VbKeyA Then _a = True
            If e.KeyCode = VbKeyS Then _s = True

            'Si las 3 variables están en True .. mostramos un mensaje   
            If _ctrl And _a Then
                _ambos = True
            ElseIf _ctrl And _s Then
                _ambos = False
            End If
        End Sub

        Private Sub FrmCaja_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
            'Cuando se produce KeyUp ponemos las variables en false   
            _ctrl = False
            _a = False
            _s = False
        End Sub

        Private Sub FrmCaja_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub
    End Class
End Namespace