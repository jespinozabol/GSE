Imports Presentacion.Interfaz.Creditos
Namespace Interfaz.Administrativos
    Public Class FrmInicioSesion

        '1- principal 2- cliente crédito 
        Private _varVentana As Integer
        Public Property Ventana() As Integer
            Get
                Return _varVentana
            End Get
            Set(ByVal value As Integer)
                _varVentana = value
            End Set
        End Property

        Private Sub txtContraseña_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtContraseña.KeyDown
            If e.KeyData = Keys.Enter Then
                If Trim(txtContraseña.Text) <> "" Then

                    If txtContraseña.Text = "70707" Then
                        If Ventana = 1 Then
                            FrmPrincipal.AdminImpuestoVenta.Visible = True
                            FrmPrincipal.CalcularImpuestoToolStripMenuItem.Visible = True
                            FrmPrincipal.lblCerrarSesion.Visible = True
                            FrmPrincipal.CajaMenuItem.Visible = True
                            FrmPrincipal.MonedaMinimaToolStripMenuItem.Visible = True
                            FrmPrincipal.AdministrarImpresorasToolStripMenuItem.Visible = True
                            FrmPrincipal.AdministrarTiposCréditoToolStripMenuItem.Visible = True
                            FrmPrincipal.TotalVentasPorClienteToolStripMenuItem.Visible = True
                            FrmPrincipal.TotalComprasPorProveedorToolStripMenuItem.Visible = True
                            FrmPrincipal.InventarioToolStripMenuItem.Visible = True
                            FrmPrincipal.OtrosToolStripMenuItem.Visible = False
                            FrmPrincipal.Timer1.Enabled = True
                        Else
                            FrmClienteCredito.correcta = True
                        End If
                        Dispose()
                    ElseIf txtContraseña.Text = "55555" Then
                        FrmPrincipal.CajaMenuItem.Visible = True
                        FrmPrincipal.lblCerrarSesion.Visible = True
                        FrmPrincipal.AdministrarConsecutivosToolStripMenuItem.Visible = True
                        Dispose()
                    Else
                        MsgBox("La contraseña no es correcta, inténtelo de nuevo")
                    End If
                End If
            End If
        End Sub

        Private Sub FrmInicioSesion_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub
    End Class
End Namespace