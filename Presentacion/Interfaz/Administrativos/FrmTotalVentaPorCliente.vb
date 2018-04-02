Imports Logica_Negocios

Namespace Interfaz.Administrativos
    Public Class FrmTotalVentaPorCliente

        Private ReadOnly _oUtilidades As New Utilidades
        Private ReadOnly _oLogicaGeneral As New LogicaGenerales

        Private Sub FrmTotalVentaPorCliente_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            Dim fecha As Date = "05/10/2000"
            Dim primer = DateSerial(Now.Year - 1, Month(fecha), 1)
            Dim ultimo = DateSerial(Now.Year, Month(fecha) - 1, 30)

            dtpInicio.Value = New DateTime(primer.Year, primer.Month, primer.Day)
            dtpFinal.Value = New DateTime(ultimo.Year, ultimo.Month, ultimo.Day)
            txtMayor.Text = _oUtilidades.PasarMoneda(2500000)
            AddHandler txtMayor.KeyPress, AddressOf ValidarSoloNumeros
        End Sub

        Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCalcular.Click
            Cursor.Current = Cursors.WaitCursor
            Dim tblTotales = _oLogicaGeneral.totalVentasPorCliente(CDbl(txtMayor.Text), dtpInicio.Value, dtpFinal.Value)

            dgvLista.DataSource = tblTotales
            Cursor.Current = Cursors.Default

            With dgvLista
                .Columns(0).Width = 35
                .Columns(1).Width = 220
                .Columns(2).Width = 70
                .Columns(2).HeaderText = "Cédula"
                .Columns(3).Width = 70
                .Columns(3).HeaderText = "Teléfono"
                .Columns(4).Width = 100
                .Columns(4).HeaderText = "Monto"
                .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            End With
        End Sub

        Private Sub FrmTotalVentaPorCliente_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub
    End Class
End Namespace