Imports Logica_Negocios

Namespace Interfaz.Administrativos
    Public Class FrmTotalComprasPorProveedor

        Private ReadOnly _oUtilidades As New Utilidades
        Private ReadOnly _oLogicaGeneral As New LogicaGenerales

        Private Sub FrmTotalComprasPorProveedor_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
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
            Dim tblTotales = _oLogicaGeneral.totalComprasPorProveedor(CDbl(txtMayor.Text), dtpInicio.Value, dtpFinal.Value)

            For i = 0 To tblTotales.Rows.Count - 1
                dgvLista.Rows.Add(tblTotales.Rows(i).Item(1), tblTotales.Rows(i).Item(2), tblTotales.Rows(i).Item(3), tblTotales.Rows(i).Item(4))
            Next

            Cursor.Current = Cursors.Default

            dgvLista.Sort(New OrdenarColumnaNumerica(SortOrder.Descending, 3))
        End Sub

        Private Sub FrmTotalComprasPorProveedor_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub
    End Class
End Namespace