Imports Logica_Negocios

Namespace Interfaz.Proveedores
    Public Class FrmInfoProveedor

        Private ReadOnly _oLogicaProveedores As New LogicaProveedor

        Public Sub LlenarProveedor(ByVal codigo As Integer)
            Dim tblProveedor As DataTable = _oLogicaProveedores.ConsultarDatosProveedor(codigo)

            lblNombre_Empresa.Text = tblProveedor.Rows(0).Item(2)
            lblMostrar_TelfPrin.Text = tblProveedor.Rows(0).Item(3)
            lblMostrar_FaxPrinc.Text = tblProveedor.Rows(0).Item(4)

            lblMostrar_TelfAgente.Text = tblProveedor.Rows(0).Item(1)
            lblNombre_Agente.Text = tblProveedor.Rows(0).Item(0)
        End Sub

        Private Sub FrmInfo_Proveedor_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub
    End Class
End Namespace