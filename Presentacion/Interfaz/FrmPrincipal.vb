Imports Presentacion.Interfaz.Administrativos
Imports Presentacion.Interfaz.Proveedores
Imports Presentacion.Interfaz.Catalogo
Imports Presentacion.Interfaz.Creditos
Imports Presentacion.Interfaz.Facturas
Imports Presentacion.Interfaz.Listados
Imports Presentacion.Interfaz.Mantenimiento
Imports Presentacion.Interfaz.Proformas

Namespace Interfaz
    Public Class FrmPrincipal

        Private Sub MenuItemSalir_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles MenuItemSalir.Click
            Dispose()
        End Sub

        Private Sub MantCatálogoDeMateriales_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles MantCatálogoDeMateriales.Click
            FrmCatalogoMateriales.ShowDialog()
        End Sub

        Private Sub MantReferenciaDeVentas_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles MantReferenciaDeVentas.Click
            FrmReferencias.ShowDialog()
        End Sub

        Private Sub MantAnular_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles MantAnular.Click
            FrmAnular.ShowDialog()
        End Sub

        Private Sub lblCerrarSesion_MouseEnter(ByVal sender As System.Object, ByVal e As EventArgs) Handles lblCerrarSesion.MouseEnter
            lblCerrarSesion.ForeColor = Color.Blue
        End Sub

        Private Sub lblCerrarSesion_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles lblCerrarSesion.Click
            AdminImpuestoVenta.Visible = False
            CalcularImpuestoToolStripMenuItem.Visible = False
            lblCerrarSesion.Visible = False
            MonedaMinimaToolStripMenuItem.Visible = False
            CajaMenuItem.Visible = False
            AdministrarImpresorasToolStripMenuItem.Visible = False
            AdministrarTiposCréditoToolStripMenuItem.Visible = False
            TotalVentasPorClienteToolStripMenuItem.Visible = False
            TotalComprasPorProveedorToolStripMenuItem.Visible = False
            InventarioToolStripMenuItem.Visible = False
            OtrosToolStripMenuItem.Visible = True
            Timer1.Enabled = False
        End Sub

        Private Sub lblCerrarSesion_MouseLeave(ByVal sender As System.Object, ByVal e As EventArgs) Handles lblCerrarSesion.MouseLeave
            lblCerrarSesion.ForeColor = Color.Black
        End Sub

        Private Sub CalcularImpuestoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles CalcularImpuestoToolStripMenuItem.Click
            FrmCalculoImpuesto.ShowDialog()
        End Sub

        Private Sub AdminImpuestoVenta_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles AdminImpuestoVenta.Click
            FrmImpuesto.ShowDialog()
        End Sub

        Private Sub CreditosDatosCliente_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles CreditosDatosCliente.Click
            FrmClienteCredito.ShowDialog()
        End Sub

        Private Sub CreditosFacturasPorCliente_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles CreditosFacturasPorCliente.Click
            FrmFacturaCredito.ShowDialog()
        End Sub

        Private Sub CajaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles CajaMenuItem.Click
            FrmCaja.ShowDialog()
        End Sub

        Private Sub MonedaMinimaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles MonedaMinimaToolStripMenuItem.Click
            FrmMonedaMinima.ShowDialog()
        End Sub

        Private Sub FacturarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles FacturarToolStripMenuItem.Click
            FrmFacturar.ShowDialog()
        End Sub

        Private Sub ListadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ListadoToolStripMenuItem.Click
            FrmListado.ShowDialog()
        End Sub

        Private Sub ProformaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ProformaToolStripMenuItem.Click
            FrmProforma.ShowDialog()
        End Sub

        Private Sub ValeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ValeToolStripMenuItem.Click
            FrmVale.ShowDialog()
        End Sub

        Private Sub EmpleadosYOtrosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles EmpleadosYOtrosToolStripMenuItem.Click
            FrmEmpleadoOtros.ShowDialog()
        End Sub

        Private Sub ValeToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ValeToolStripMenuItemAdm.Click
            FrmVale.ShowDialog()
        End Sub

        Private Sub ListaClientesCréditoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ListaClientesCréditoToolStripMenuItem.Click
            FrmConsultaCreditos.ShowDialog()
        End Sub

        Private Sub AdministrarConsecutivosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles AdministrarConsecutivosToolStripMenuItem.Click
            FrmAdministrarConsecutivo.ShowDialog()
        End Sub

        Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ClientesToolStripMenuItem.Click
            FrmClienteRepetido.ShowDialog()
        End Sub

        Private Sub AdministrarImpresorasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles AdministrarImpresorasToolStripMenuItem.Click
            FrmAdministrarImpresoras.ShowDialog()
        End Sub

        Private Sub AdministrarTiposCréditoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles AdministrarTiposCréditoToolStripMenuItem.Click
            FrmAdministrarTiposCredito.ShowDialog()
        End Sub

        Private Sub ListaComprobantesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ListaComprobantesToolStripMenuItem.Click
            FrmListaComprobantes.ShowDialog()
        End Sub

        Private Sub TotalVentasPorClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles TotalVentasPorClienteToolStripMenuItem.Click
            FrmTotalVentaPorCliente.ShowDialog()
        End Sub

        Private Sub ListaFacturasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ListaFacturasToolStripMenuItem.Click
            FrmListaFacturas.ShowDialog()
        End Sub

        Private Sub IngresarFacturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles IngresarFacturaToolStripMenuItem.Click
            FrmDocPorPagar.ShowDialog()
        End Sub

        Private Sub DatosProveedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles DatosProveedorToolStripMenuItem.Click
            FrmProveedor.ShowDialog()
        End Sub

        Private Sub ListadosFacturadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ListadosFacturadosToolStripMenuItem.Click
            FrmConsultaListadosFacturados.ShowDialog()
        End Sub

        Private Sub HacerPedidosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles HacerPedidosToolStripMenuItem.Click
            FrmPedidos.ShowDialog()
        End Sub

        Private Sub ListadoDeFacturasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ListadoDeFacturasToolStripMenuItem.Click
            FrmHistorialComprasPorProveedor.ShowDialog()
        End Sub

        Private Sub FacturasPorProveedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles FacturasPorProveedorToolStripMenuItem.Click
            FrmCancelacionDeFacturasPorProveedor.ShowDialog()
        End Sub

        Private Sub ListaRecibosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ListaRecibosToolStripMenuItem.Click
            FrmListaRecibos.ShowDialog()
        End Sub

        Private Sub TotalComprasPorProveedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles TotalComprasPorProveedorToolStripMenuItem.Click
            FrmTotalComprasPorProveedor.ShowDialog()
        End Sub

        Private Sub OtrosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles OtrosToolStripMenuItem.Click
            If Not lblCerrarSesion.Visible Then
                FrmInicioSesion.Ventana = 1
                FrmInicioSesion.ShowDialog()
            End If
        End Sub

        Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As EventArgs) Handles Timer1.Tick
            If lblCerrarSesion.Visible Then
                If lblCerrarSesion.ForeColor = Color.Blue Then
                    lblCerrarSesion.ForeColor = Color.Red
                Else
                    lblCerrarSesion.ForeColor = Color.Blue
                End If
            End If
        End Sub

        Private Sub DevolucionesYCambiosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles DevolucionesYCambiosToolStripMenuItem.Click
            FrmPaquetes.ShowDialog()
        End Sub

        Private Sub InventarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InventarioToolStripMenuItem.Click
            FrmInventario.ShowDialog()
        End Sub
    End Class
End Namespace