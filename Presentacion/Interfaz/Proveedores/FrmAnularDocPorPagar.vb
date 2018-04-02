Imports Entidades
Imports Logica_Negocios

Namespace Interfaz.Proveedores
    Public Class FrmAnularDocPorPagar

        Private ReadOnly _oLogicaDocPorPagar As New LogicaDocPorPagar
        Private ReadOnly _oLogicaProveedor As New LogicaProveedor

        Private Sub FrmAnular_DocPorPagar_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub

        Private Sub btnAnularFact_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAnularFact.Click
            If Trim(txtMotivo.Text) <> "" Then
                Dim respuesta As String
                respuesta = MsgBox("Esta seguro que desea anular esta factura?", vbCritical + vbYesNo, "Anular Factura...")

                If respuesta = vbYes Then
                    Dim oDocPorPagar As New FacturaProveedor
                    oDocPorPagar.IdDocPagar = CInt(txtId_DocPorPagar.Text)
                    oDocPorPagar.Estado = FacturaProveedor.ListaEstado.Anulada
                    oDocPorPagar.Motivo = UCase(txtMotivo.Text)
                    _oLogicaDocPorPagar.anular(oDocPorPagar)
                    MsgBox("Factura anulada con éxito", MsgBoxStyle.Information)
                    Dim idProveedor = CInt(FrmCancelacionDeFacturasPorProveedor.txtId_Proveedor.Text)
                    FrmCancelacionDeFacturasPorProveedor.LimpiarTodo()
                    FrmCancelacionDeFacturasPorProveedor.LlenarProveedor(_oLogicaProveedor.Consultar(idProveedor))
                    Dispose()
                End If
            Else
                MsgBox("El motivo no puede estar vacío", MsgBoxStyle.Exclamation)
            End If
        End Sub
    End Class
End Namespace