Imports Entidades
Imports Logica_Negocios
Imports Presentacion.Interfaz.Listados
Imports Presentacion.Interfaz.Proformas
Namespace Interfaz.Facturas
    Public Class FrmTrasladarFactura

        Public Nombre As String
        Public OFactura As New Factura
        Private ReadOnly _oLogicaProducto As New LogicaProducto
        Private ReadOnly _oUtilidades As New Utilidades
        Private ReadOnly _oLogicaImpuesto As New LogicaImpuesto

        Private Sub FrmTrasladarFactura_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub

        Private Sub btnProforma_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnProforma.Click
            FrmFacturar.Dispose()
            FrmProforma.txtNombre.Text = Nombre
            FrmProforma.dgvProductos.Rows.Clear()
            For i As Integer = 0 To OFactura.FacturaDetalles.Count - 1
                Dim oProducto = _oLogicaProducto.Consultar(OFactura.FacturaDetalles(i).Id_Producto)
                Dim precio As Double
                Dim impuesto As Double
                precio = _oUtilidades.PasarMoneda(OFactura.FacturaDetalles(i).PrecioUnitario)

                If oProducto.Impuesto Then
                    impuesto = OFactura.FacturaDetalles(i).Impuesto
                Else
                    impuesto = 0
                End If

                Dim subTotal As Double

                subTotal = CalcularSubTotalProforma(OFactura.FacturaDetalles(i).Cantidad, precio, OFactura.FacturaDetalles(i).Descuento, impuesto)

                FrmProforma.dgvProductos.Rows.Add(_oUtilidades.PasarMoneda(OFactura.FacturaDetalles(i).Cantidad), OFactura.FacturaDetalles(i).Id_Producto, oProducto.Descripcion, _oUtilidades.PasarMoneda(precio), OFactura.FacturaDetalles(i).Descuento & "%", _oUtilidades.PasarMoneda(impuesto) & "%", _oUtilidades.PasarMoneda(subTotal))
                FrmProforma.dgvProductos.Rows(0).Selected = False
                FrmProforma.calcularLineas(FrmProforma.dgvProductos.RowCount)
                FrmProforma.txtCantidad.Focus()
            Next
            FrmProforma.ShowDialog()
            Dispose()
        End Sub

        Private Sub btnListado_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnListado.Click
            FrmFacturar.Dispose()
            FrmListado.txtNombre.Text = Nombre
            FrmListado.dgvProductos.Rows.Clear()
            For j = 0 To OFactura.FacturaDetalles.Count - 1
                Dim descripcion = _oLogicaProducto.ConsultarDescripcion(OFactura.FacturaDetalles(j).Id_Producto)

                Dim precio As Double
                Dim oProducto = _oLogicaProducto.Consultar(OFactura.FacturaDetalles(j).Id_Producto)

                If oProducto.Impuesto Then
                    precio = _oUtilidades.PasarMoneda((oProducto.PrecioUnitario * ((oProducto.Ganancia / 100) + 1)) * ((CDbl(_oLogicaImpuesto.consultarImpuesto) / 100) + 1))
                Else
                    precio = _oUtilidades.PasarMoneda((oProducto.PrecioUnitario * ((oProducto.Ganancia / 100) + 1)))
                End If
                precio = precio * OFactura.FacturaDetalles(j).Cantidad
                FrmListado.lblMostrarTotal.Text = CDbl(FrmListado.lblMostrarTotal.Text) + precio

                FrmListado.dgvProductos.Rows.Add(True, _oUtilidades.PasarMoneda(OFactura.FacturaDetalles(j).Cantidad), OFactura.FacturaDetalles(j).Id_Producto, descripcion)
            Next

            FrmListado.cmbAutorizados.Items.Add("0- " + Nombre + " Telf:")
            FrmListado.cmbAutorizados.SelectedIndex = 0
            Dim oAutorizado As New ListadoAutorizado
            oAutorizado.Nombre = Nombre
            oAutorizado.Telefono = ""
            FrmListado.OListado.ListaAutorizados.Add(oAutorizado)

            FrmListado.ShowDialog()
            Dispose()
        End Sub
    End Class
End Namespace