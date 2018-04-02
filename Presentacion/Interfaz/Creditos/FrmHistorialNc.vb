Imports Logica_Negocios

Namespace Interfaz.Creditos
    Public Class FrmHistorialNc

        Private ReadOnly _oLogicaNotasCredito As New LogicaNotaCredito
        Private ReadOnly _oUtilidades As New Utilidades

        Private Sub FrmHistorial_NC_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            With dgvNotas_Credito
                .Columns("IdNC").HeaderText = "# NC"
                .Columns("IdNC").Width = 60
                .Columns("NumFactura").Visible = False
                .Columns("Fecha").Width = 75
                .Columns("Monto").Width = 80
                .Columns("Estado").Visible = False
            End With
            dgvNotas_Credito.Rows(0).Selected = False
        End Sub

        Private Sub dgvNotas_Credito_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvNotas_Credito.Click
            dgvLineasNC.Rows.Clear()
            lblMostrarReciboNotas.Text = dgvNotas_Credito.Item(0, dgvNotas_Credito.CurrentRow.Index).Value
            Dim nota = _oLogicaNotasCredito.consultar(CInt(lblMostrarReciboNotas.Text))

            For i = 0 To nota.NCDetalles.Count - 1
                Dim precio = (nota.NCDetalles(i).PrecioUnitario * nota.NCDetalles(i).Cantidad)
                Dim subTotalLinea = precio - (precio * (nota.NCDetalles(i).Descuento / 100)) + (precio * (nota.NCDetalles(i).Impuesto / 100))
                dgvLineasNC.Rows.Add(nota.NCDetalles(i).Cantidad, nota.NCDetalles(i).Id_Producto, nota.NCDetalles(i).Descripcion, nota.NCDetalles(i).PrecioUnitario, nota.NCDetalles(i).Descuento & "%", nota.NCDetalles(i).Impuesto & "%", _oUtilidades.PasarMoneda(subTotalLinea))
            Next

            lblMostrarTotal.Text = _oUtilidades.PasarMoneda(dgvNotas_Credito.Item(3, dgvNotas_Credito.CurrentRow.Index).Value)
            dgvLineasNC.Rows(0).Selected = False
        End Sub

        Private Sub FrmHistorial_NC_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub
    End Class
End Namespace