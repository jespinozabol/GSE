Imports Entidades
Imports Presentacion.Interfaz.Creditos
Imports Presentacion.Interfaz.Facturas

Public Class FrmObservaciones

    Private _flujoCaja As FlujoCaja
    Private _estadoFlujoCaja As Boolean

    Public Sub LlenarDatos(ByVal flujoCaja As FlujoCaja, ByVal estadoFlujoCaja As Boolean, ByVal observaciones As String)
        _flujoCaja = flujoCaja
        _estadoFlujoCaja = estadoFlujoCaja
        txtObservaciones.Text = UCase(observaciones)
    End Sub

    Private Sub FrmObservaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtObservaciones.Select(txtObservaciones.Text.Length, 0)
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        FrmFacturaCredito.OFlujoCaja = _flujoCaja
        FrmFacturaCredito.EstadoFlujoCaja = _estadoFlujoCaja
        Dim observaciones = UCase(Trim(txtObservaciones.Text))
        FrmFacturaCredito.Observaciones = observaciones
        FrmFacturaCredito.lblMostrarObservaciones.Text = observaciones
        FrmFlujoCaja.Dispose()
        Me.Dispose()
    End Sub

    Private Sub FrmObservaciones_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
End Class