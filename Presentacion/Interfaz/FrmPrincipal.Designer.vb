Namespace Interfaz
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmPrincipal
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
            Me.MenuPrincipal = New System.Windows.Forms.MenuStrip()
            Me.MenuItemSalir = New System.Windows.Forms.ToolStripMenuItem()
            Me.MenuItemMantenimiento = New System.Windows.Forms.ToolStripMenuItem()
            Me.MantCatálogoDeMateriales = New System.Windows.Forms.ToolStripMenuItem()
            Me.MantAnular = New System.Windows.Forms.ToolStripMenuItem()
            Me.ListaFacturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ListadosFacturadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.MantReferenciaDeVentas = New System.Windows.Forms.ToolStripMenuItem()
            Me.EmpleadosYOtrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.FacturarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ListadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ProformaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.MenuItemCredito = New System.Windows.Forms.ToolStripMenuItem()
            Me.CreditosFacturasPorCliente = New System.Windows.Forms.ToolStripMenuItem()
            Me.CreditosDatosCliente = New System.Windows.Forms.ToolStripMenuItem()
            Me.ValeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ListaClientesCréditoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ListaComprobantesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.FacturasPorProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.IngresarFacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.DatosProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ListadoDeFacturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.HacerPedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ListaRecibosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.DevolucionesYCambiosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.MenuItemAdministrativos = New System.Windows.Forms.ToolStripMenuItem()
            Me.CajaMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ValeToolStripMenuItemAdm = New System.Windows.Forms.ToolStripMenuItem()
            Me.CalcularImpuestoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.AdministrarConsecutivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.AdministrarImpresorasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.AdministrarTiposCréditoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.TotalVentasPorClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.TotalComprasPorProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.AdminImpuestoVenta = New System.Windows.Forms.ToolStripMenuItem()
            Me.MonedaMinimaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.OtrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.lblCerrarSesion = New System.Windows.Forms.Label()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.MenuPrincipal.SuspendLayout()
            Me.SuspendLayout()
            '
            'MenuPrincipal
            '
            resources.ApplyResources(Me.MenuPrincipal, "MenuPrincipal")
            Me.MenuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemSalir, Me.MenuItemMantenimiento, Me.FacturarToolStripMenuItem, Me.ListadoToolStripMenuItem, Me.ProformaToolStripMenuItem, Me.MenuItemCredito, Me.ProveedoresToolStripMenuItem, Me.MenuItemAdministrativos})
            Me.MenuPrincipal.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
            Me.MenuPrincipal.Name = "MenuPrincipal"
            Me.MenuPrincipal.ShowItemToolTips = True
            '
            'MenuItemSalir
            '
            Me.MenuItemSalir.Name = "MenuItemSalir"
            resources.ApplyResources(Me.MenuItemSalir, "MenuItemSalir")
            '
            'MenuItemMantenimiento
            '
            Me.MenuItemMantenimiento.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantCatálogoDeMateriales, Me.MantAnular, Me.ListaFacturasToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.ListadosFacturadosToolStripMenuItem, Me.MantReferenciaDeVentas, Me.EmpleadosYOtrosToolStripMenuItem})
            Me.MenuItemMantenimiento.Name = "MenuItemMantenimiento"
            resources.ApplyResources(Me.MenuItemMantenimiento, "MenuItemMantenimiento")
            '
            'MantCatálogoDeMateriales
            '
            Me.MantCatálogoDeMateriales.Name = "MantCatálogoDeMateriales"
            resources.ApplyResources(Me.MantCatálogoDeMateriales, "MantCatálogoDeMateriales")
            '
            'MantAnular
            '
            Me.MantAnular.Name = "MantAnular"
            resources.ApplyResources(Me.MantAnular, "MantAnular")
            '
            'ListaFacturasToolStripMenuItem
            '
            Me.ListaFacturasToolStripMenuItem.Name = "ListaFacturasToolStripMenuItem"
            resources.ApplyResources(Me.ListaFacturasToolStripMenuItem, "ListaFacturasToolStripMenuItem")
            '
            'ClientesToolStripMenuItem
            '
            Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
            resources.ApplyResources(Me.ClientesToolStripMenuItem, "ClientesToolStripMenuItem")
            '
            'ListadosFacturadosToolStripMenuItem
            '
            Me.ListadosFacturadosToolStripMenuItem.Name = "ListadosFacturadosToolStripMenuItem"
            resources.ApplyResources(Me.ListadosFacturadosToolStripMenuItem, "ListadosFacturadosToolStripMenuItem")
            '
            'MantReferenciaDeVentas
            '
            Me.MantReferenciaDeVentas.Name = "MantReferenciaDeVentas"
            resources.ApplyResources(Me.MantReferenciaDeVentas, "MantReferenciaDeVentas")
            '
            'EmpleadosYOtrosToolStripMenuItem
            '
            Me.EmpleadosYOtrosToolStripMenuItem.Name = "EmpleadosYOtrosToolStripMenuItem"
            resources.ApplyResources(Me.EmpleadosYOtrosToolStripMenuItem, "EmpleadosYOtrosToolStripMenuItem")
            '
            'FacturarToolStripMenuItem
            '
            Me.FacturarToolStripMenuItem.Name = "FacturarToolStripMenuItem"
            resources.ApplyResources(Me.FacturarToolStripMenuItem, "FacturarToolStripMenuItem")
            '
            'ListadoToolStripMenuItem
            '
            Me.ListadoToolStripMenuItem.Name = "ListadoToolStripMenuItem"
            resources.ApplyResources(Me.ListadoToolStripMenuItem, "ListadoToolStripMenuItem")
            '
            'ProformaToolStripMenuItem
            '
            Me.ProformaToolStripMenuItem.Name = "ProformaToolStripMenuItem"
            resources.ApplyResources(Me.ProformaToolStripMenuItem, "ProformaToolStripMenuItem")
            '
            'MenuItemCredito
            '
            Me.MenuItemCredito.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreditosFacturasPorCliente, Me.CreditosDatosCliente, Me.ListaClientesCréditoToolStripMenuItem, Me.ListaComprobantesToolStripMenuItem, Me.ValeToolStripMenuItem})
            Me.MenuItemCredito.Name = "MenuItemCredito"
            resources.ApplyResources(Me.MenuItemCredito, "MenuItemCredito")
            '
            'CreditosFacturasPorCliente
            '
            Me.CreditosFacturasPorCliente.Name = "CreditosFacturasPorCliente"
            resources.ApplyResources(Me.CreditosFacturasPorCliente, "CreditosFacturasPorCliente")
            '
            'CreditosDatosCliente
            '
            Me.CreditosDatosCliente.Name = "CreditosDatosCliente"
            resources.ApplyResources(Me.CreditosDatosCliente, "CreditosDatosCliente")
            '
            'ValeToolStripMenuItem
            '
            Me.ValeToolStripMenuItem.Name = "ValeToolStripMenuItem"
            resources.ApplyResources(Me.ValeToolStripMenuItem, "ValeToolStripMenuItem")
            '
            'ListaClientesCréditoToolStripMenuItem
            '
            Me.ListaClientesCréditoToolStripMenuItem.Name = "ListaClientesCréditoToolStripMenuItem"
            resources.ApplyResources(Me.ListaClientesCréditoToolStripMenuItem, "ListaClientesCréditoToolStripMenuItem")
            '
            'ListaComprobantesToolStripMenuItem
            '
            Me.ListaComprobantesToolStripMenuItem.Name = "ListaComprobantesToolStripMenuItem"
            resources.ApplyResources(Me.ListaComprobantesToolStripMenuItem, "ListaComprobantesToolStripMenuItem")
            '
            'ProveedoresToolStripMenuItem
            '
            Me.ProveedoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FacturasPorProveedorToolStripMenuItem, Me.IngresarFacturaToolStripMenuItem, Me.DatosProveedorToolStripMenuItem, Me.ListadoDeFacturasToolStripMenuItem, Me.HacerPedidosToolStripMenuItem, Me.ListaRecibosToolStripMenuItem, Me.DevolucionesYCambiosToolStripMenuItem})
            Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
            resources.ApplyResources(Me.ProveedoresToolStripMenuItem, "ProveedoresToolStripMenuItem")
            '
            'FacturasPorProveedorToolStripMenuItem
            '
            Me.FacturasPorProveedorToolStripMenuItem.Name = "FacturasPorProveedorToolStripMenuItem"
            resources.ApplyResources(Me.FacturasPorProveedorToolStripMenuItem, "FacturasPorProveedorToolStripMenuItem")
            '
            'IngresarFacturaToolStripMenuItem
            '
            Me.IngresarFacturaToolStripMenuItem.Name = "IngresarFacturaToolStripMenuItem"
            resources.ApplyResources(Me.IngresarFacturaToolStripMenuItem, "IngresarFacturaToolStripMenuItem")
            '
            'DatosProveedorToolStripMenuItem
            '
            Me.DatosProveedorToolStripMenuItem.Name = "DatosProveedorToolStripMenuItem"
            resources.ApplyResources(Me.DatosProveedorToolStripMenuItem, "DatosProveedorToolStripMenuItem")
            '
            'ListadoDeFacturasToolStripMenuItem
            '
            Me.ListadoDeFacturasToolStripMenuItem.Name = "ListadoDeFacturasToolStripMenuItem"
            resources.ApplyResources(Me.ListadoDeFacturasToolStripMenuItem, "ListadoDeFacturasToolStripMenuItem")
            '
            'HacerPedidosToolStripMenuItem
            '
            Me.HacerPedidosToolStripMenuItem.Name = "HacerPedidosToolStripMenuItem"
            resources.ApplyResources(Me.HacerPedidosToolStripMenuItem, "HacerPedidosToolStripMenuItem")
            '
            'ListaRecibosToolStripMenuItem
            '
            Me.ListaRecibosToolStripMenuItem.Name = "ListaRecibosToolStripMenuItem"
            resources.ApplyResources(Me.ListaRecibosToolStripMenuItem, "ListaRecibosToolStripMenuItem")
            '
            'DevolucionesYCambiosToolStripMenuItem
            '
            Me.DevolucionesYCambiosToolStripMenuItem.Name = "DevolucionesYCambiosToolStripMenuItem"
            resources.ApplyResources(Me.DevolucionesYCambiosToolStripMenuItem, "DevolucionesYCambiosToolStripMenuItem")
            '
            'MenuItemAdministrativos
            '
            Me.MenuItemAdministrativos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CajaMenuItem, Me.ValeToolStripMenuItemAdm, Me.CalcularImpuestoToolStripMenuItem, Me.AdministrarConsecutivosToolStripMenuItem, Me.AdministrarImpresorasToolStripMenuItem, Me.AdministrarTiposCréditoToolStripMenuItem, Me.TotalVentasPorClienteToolStripMenuItem, Me.TotalComprasPorProveedorToolStripMenuItem, Me.AdminImpuestoVenta, Me.MonedaMinimaToolStripMenuItem, Me.InventarioToolStripMenuItem, Me.OtrosToolStripMenuItem})
            Me.MenuItemAdministrativos.Name = "MenuItemAdministrativos"
            resources.ApplyResources(Me.MenuItemAdministrativos, "MenuItemAdministrativos")
            '
            'CajaMenuItem
            '
            Me.CajaMenuItem.Name = "CajaMenuItem"
            resources.ApplyResources(Me.CajaMenuItem, "CajaMenuItem")
            '
            'ValeToolStripMenuItemAdm
            '
            Me.ValeToolStripMenuItemAdm.Name = "ValeToolStripMenuItemAdm"
            resources.ApplyResources(Me.ValeToolStripMenuItemAdm, "ValeToolStripMenuItemAdm")
            '
            'CalcularImpuestoToolStripMenuItem
            '
            Me.CalcularImpuestoToolStripMenuItem.Name = "CalcularImpuestoToolStripMenuItem"
            resources.ApplyResources(Me.CalcularImpuestoToolStripMenuItem, "CalcularImpuestoToolStripMenuItem")
            '
            'AdministrarConsecutivosToolStripMenuItem
            '
            Me.AdministrarConsecutivosToolStripMenuItem.Name = "AdministrarConsecutivosToolStripMenuItem"
            resources.ApplyResources(Me.AdministrarConsecutivosToolStripMenuItem, "AdministrarConsecutivosToolStripMenuItem")
            '
            'AdministrarImpresorasToolStripMenuItem
            '
            Me.AdministrarImpresorasToolStripMenuItem.Name = "AdministrarImpresorasToolStripMenuItem"
            resources.ApplyResources(Me.AdministrarImpresorasToolStripMenuItem, "AdministrarImpresorasToolStripMenuItem")
            '
            'AdministrarTiposCréditoToolStripMenuItem
            '
            Me.AdministrarTiposCréditoToolStripMenuItem.Name = "AdministrarTiposCréditoToolStripMenuItem"
            resources.ApplyResources(Me.AdministrarTiposCréditoToolStripMenuItem, "AdministrarTiposCréditoToolStripMenuItem")
            '
            'TotalVentasPorClienteToolStripMenuItem
            '
            Me.TotalVentasPorClienteToolStripMenuItem.Name = "TotalVentasPorClienteToolStripMenuItem"
            resources.ApplyResources(Me.TotalVentasPorClienteToolStripMenuItem, "TotalVentasPorClienteToolStripMenuItem")
            '
            'TotalComprasPorProveedorToolStripMenuItem
            '
            Me.TotalComprasPorProveedorToolStripMenuItem.Name = "TotalComprasPorProveedorToolStripMenuItem"
            resources.ApplyResources(Me.TotalComprasPorProveedorToolStripMenuItem, "TotalComprasPorProveedorToolStripMenuItem")
            '
            'AdminImpuestoVenta
            '
            Me.AdminImpuestoVenta.Name = "AdminImpuestoVenta"
            resources.ApplyResources(Me.AdminImpuestoVenta, "AdminImpuestoVenta")
            '
            'MonedaMinimaToolStripMenuItem
            '
            Me.MonedaMinimaToolStripMenuItem.Name = "MonedaMinimaToolStripMenuItem"
            resources.ApplyResources(Me.MonedaMinimaToolStripMenuItem, "MonedaMinimaToolStripMenuItem")
            '
            'InventarioToolStripMenuItem
            '
            Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
            resources.ApplyResources(Me.InventarioToolStripMenuItem, "InventarioToolStripMenuItem")
            '
            'OtrosToolStripMenuItem
            '
            Me.OtrosToolStripMenuItem.Name = "OtrosToolStripMenuItem"
            resources.ApplyResources(Me.OtrosToolStripMenuItem, "OtrosToolStripMenuItem")
            '
            'lblCerrarSesion
            '
            resources.ApplyResources(Me.lblCerrarSesion, "lblCerrarSesion")
            Me.lblCerrarSesion.BackColor = System.Drawing.Color.Transparent
            Me.lblCerrarSesion.ForeColor = System.Drawing.Color.Red
            Me.lblCerrarSesion.Name = "lblCerrarSesion"
            '
            'Timer1
            '
            Me.Timer1.Interval = 600
            '
            'FrmPrincipal
            '
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackgroundImage = Global.Presentacion.My.Resources.Resources.general
            Me.Controls.Add(Me.lblCerrarSesion)
            Me.Controls.Add(Me.MenuPrincipal)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmPrincipal"
            Me.ShowInTaskbar = False
            Me.MenuPrincipal.ResumeLayout(False)
            Me.MenuPrincipal.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents MenuItemSalir As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents MenuItemMantenimiento As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents MenuItemCredito As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents MenuItemAdministrativos As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents MantCatálogoDeMateriales As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents MantAnular As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents MantReferenciaDeVentas As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents CreditosFacturasPorCliente As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents CreditosDatosCliente As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents AdminImpuestoVenta As System.Windows.Forms.ToolStripMenuItem
        Public WithEvents MenuPrincipal As System.Windows.Forms.MenuStrip
        Friend WithEvents lblCerrarSesion As System.Windows.Forms.Label
        Friend WithEvents CalcularImpuestoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents CajaMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents MonedaMinimaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents FacturarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ListadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ProformaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ValeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents EmpleadosYOtrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ValeToolStripMenuItemAdm As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ListaClientesCréditoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents AdministrarConsecutivosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents AdministrarImpresorasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents AdministrarTiposCréditoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ListaComprobantesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents TotalVentasPorClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ListaFacturasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents IngresarFacturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents DatosProveedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents FacturasPorProveedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ListadoDeFacturasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ListadosFacturadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents HacerPedidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ListaRecibosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents TotalComprasPorProveedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents OtrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents Timer1 As System.Windows.Forms.Timer
        Friend WithEvents DevolucionesYCambiosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents InventarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

    End Class
End Namespace