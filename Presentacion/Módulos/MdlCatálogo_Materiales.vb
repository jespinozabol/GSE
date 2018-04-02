Option Explicit On
Imports Logica_Negocios
Imports Presentacion.Interfaz.Catalogo
Module MdlCatálogo_Materiales
    Private ReadOnly Utilidades As New Utilidades
    Private ReadOnly OLogicaImpuesto As New LogicaImpuesto

    Public Sub CalcularPrecioVenta()
        With FrmCatalogoMateriales
            If .chkImpuesto.Checked Then
                .txtPrecio_Venta.Text = Utilidades.PasarMoneda((Utilidades.ValorUtil(.txtPrecioCosto.Text) * ((Utilidades.ValorUtil(.txtGanancia.Text) / 100) + 1)) * ((OLogicaImpuesto.consultarImpuesto / 100) + 1))
            Else
                .txtPrecio_Venta.Text = Utilidades.PasarMoneda((Utilidades.ValorUtil(.txtPrecioCosto.Text) * ((Utilidades.ValorUtil(.txtGanancia.Text) / 100) + 1)))
            End If
        End With
    End Sub

End Module
