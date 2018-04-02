Imports Logica_Negocios
Imports Presentacion.Interfaz.Proformas
Module MdlProforma
    Private ReadOnly Utilidades As New Utilidades

    Public Function CalcularSubTotalProforma(ByVal cantidad As Double, _
        ByVal precioUnitario As Double, ByVal descuento As Double, _
        ByVal impuesto As Double) As Double

        With FrmProforma
            Dim precio As Double
            Dim montoDesc As Double
            Dim montoImp As Double
            precio = cantidad * precioUnitario
            .lblMostrarSubTotal.Text = Utilidades.PasarMoneda(CDbl(.lblMostrarSubTotal.Text) + precio)

            montoDesc = precio * (descuento / 100)
            .lblMostrarDesc.Text = Utilidades.PasarMoneda(CDbl(.lblMostrarDesc.Text) + montoDesc)

            precio = precio - montoDesc
            montoImp = precio * (impuesto / 100)
            .lblMostrarIV.Text = Utilidades.PasarMoneda(CDbl(.lblMostrarIV.Text) + montoImp)

            precio = precio + montoImp

            .lblMostrarTotal.Text = Utilidades.PasarMoneda(CDbl(.lblMostrarTotal.Text) + precio)

            Return precio
        End With

    End Function

    Public Function SubTotalRestandoProforma(ByVal cantidad As Double, _
        ByVal precioUnitario As Double, ByVal descuento As Double, _
        ByVal impuesto As Double) As Double

        With FrmProforma
            Dim precio As Double
            Dim montoDesc As Double
            Dim montoImp As Double
            precio = cantidad * precioUnitario
            .lblMostrarSubTotal.Text = Utilidades.PasarMoneda(CDbl(.lblMostrarSubTotal.Text) - precio)

            montoDesc = precio * (descuento / 100)
            .lblMostrarDesc.Text = Utilidades.PasarMoneda(CDbl(.lblMostrarDesc.Text) - montoDesc)

            precio = precio - montoDesc
            montoImp = precio * (impuesto / 100)
            .lblMostrarIV.Text = Utilidades.PasarMoneda(CDbl(.lblMostrarIV.Text) - montoImp)

            precio = precio + montoImp
            .lblMostrarTotal.Text = Utilidades.PasarMoneda(CDbl(.lblMostrarTotal.Text) - precio)

            Return precio
        End With

    End Function
End Module
