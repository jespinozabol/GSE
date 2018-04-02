Imports Logica_Negocios

Namespace Interfaz.Administrativos
    Public Class FrmAdministrarImpresoras

        Private ReadOnly _oLogicaVarios As New LogicaVarios

        Private Sub FrmAdministrar_Impresoras_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            recargarDatos()
        End Sub

        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            If txtFacturas.Text <> "" And txtMedioOficio.Text <> "" And txtTercioOficio.Text <> "" Then
                _oLogicaVarios.ActualizarDato("Imp_Factura", txtFacturas.Text)
                _oLogicaVarios.ActualizarDato("PC_Factura", txtPC_Factura.Text)
                _oLogicaVarios.ActualizarDato("Imp_Tercio_Oficio", txtTercioOficio.Text)
                _oLogicaVarios.ActualizarDato("PC_Tercio_Oficio", txtPC_Tercio_Oficio.Text)
                _oLogicaVarios.ActualizarDato("Imp_Medio_Oficio", txtMedioOficio.Text)
                _oLogicaVarios.ActualizarDato("PC_Medio_Oficio", txtPC_Medio_Oficio.Text)
                recargarDatos()
            Else
                MsgBox("Impresoras actualizadas con éxito", MsgBoxStyle.Information)
            End If
        End Sub

        Private Sub RecargarDatos()
            Dim oDatatable = _oLogicaVarios.ConsultarTodo
            txtFacturas.Text = oDatatable.Rows(0).Item(1)
            txtMedioOficio.Text = oDatatable.Rows(0).Item(3)
            txtTercioOficio.Text = oDatatable.Rows(0).Item(2)
            txtPC_Factura.Text = oDatatable.Rows(0).Item(4)
            txtPC_Medio_Oficio.Text = oDatatable.Rows(0).Item(6)
            txtPC_Tercio_Oficio.Text = oDatatable.Rows(0).Item(5)
        End Sub

        Private Sub FrmAdministrar_Impresoras_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub
    End Class
End Namespace