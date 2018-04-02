Imports Entidades
Imports Logica_Negocios

Namespace Interfaz.Proveedores

    Public Class FrmNcProveedorGeneral

        Private ReadOnly _oUtilidades As New Utilidades
        Private ReadOnly _oLogicaProveedor As New LogicaProveedor

        Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click

            Dim oNcProveedorGeneral As New NCProveedorGeneral

            If Trim(txtNumNota.Text) = "" Then
                oNcProveedorGeneral.NumNC = 0
            Else
                oNcProveedorGeneral.NumNC = CInt(txtNumNota.Text)
            End If

            If Trim(txtBoleta.Text) = "" Then
                oNcProveedorGeneral.Boleta = 0
            Else
                oNcProveedorGeneral.Boleta = CInt(txtBoleta.Text)
            End If

            Dim objeto = ValidaNotas(oNcProveedorGeneral)
            Dim iguales = ReferenceEquals(objeto, oNcProveedorGeneral)
            If iguales Then

                oNcProveedorGeneral = objeto

                'Se utiliza 4 como valor maximo porqué el mayor error posible es de 3.84 al redondedar de dos decimales a cero decimales basados en un 13%
                'Si es una nota de crédito por descuento se saca el subtotalIV y se calcula el iv

                If chkPorDescuento.Checked Then

                    Dim subTotalIV = oNcProveedorGeneral.Total / 1.13
                    oNcProveedorGeneral.IV = _oUtilidades.PasarMoneda(subTotalIV * 0.13)
                    oNcProveedorGeneral.SubTotalIV = _oUtilidades.PasarMoneda(subTotalIV)
                    oNcProveedorGeneral.SubTotalEx = 0
                    oNcProveedorGeneral.PorDescuento = True
                Else
                    Dim subTotalIV = oNcProveedorGeneral.IV / 0.13
                    If subTotalIV < 4 Then
                        subTotalIV = 0
                    End If

                    Dim subTotalEx = oNcProveedorGeneral.Total - subTotalIV - oNcProveedorGeneral.IV
                    If subTotalEx < 4 Then
                        subTotalEx = 0
                    End If

                    oNcProveedorGeneral.SubTotalIV = _oUtilidades.PasarMoneda(subTotalIV)
                    oNcProveedorGeneral.SubTotalEx = _oUtilidades.PasarMoneda(subTotalEx)
                    oNcProveedorGeneral.PorDescuento = False
                End If

                oNcProveedorGeneral.Estado = 0
                oNcProveedorGeneral.IdProveedor = CInt(lblMostrar_Id.Text)
                Dim suma = oNcProveedorGeneral.SubTotalIV + oNcProveedorGeneral.SubTotalEx + oNcProveedorGeneral.IV
                Dim resta = suma - oNcProveedorGeneral.Total

                If resta >= -4 And resta <= 4 Then

                    Dim dias = DateDiff("d", oNcProveedorGeneral.Fecha, Now)
                    Dim atraso = 0

                    Dim fecha = ""
                    If oNcProveedorGeneral.Fecha <> Nothing Then
                        fecha = oNcProveedorGeneral.Fecha

                        atraso = dias - 30
                    End If

                    If txtId_NCG.Text <> "" Then
                        oNcProveedorGeneral.IdNcg = CInt(txtId_NCG.Text)
                        _oLogicaProveedor.modificar_NCGeneral(oNcProveedorGeneral)
                        MsgBox("Nota de crédito general modificada con éxito", MsgBoxStyle.Information)
                    Else
                        _oLogicaProveedor.insertar_NCGeneral(oNcProveedorGeneral)
                        MsgBox("Nota de crédito general insertada con éxito", MsgBoxStyle.Information)
                    End If

                    Dim idProveedor = CInt(FrmCancelacionDeFacturasPorProveedor.txtId_Proveedor.Text)
                    FrmCancelacionDeFacturasPorProveedor.LimpiarTodo()
                    FrmCancelacionDeFacturasPorProveedor.LlenarProveedor(_oLogicaProveedor.Consultar(idProveedor))

                    Dispose()
                Else
                    MsgBox("Los datos ingresados de la nota de crédito no cierran con el monto total", MsgBoxStyle.Critical)
                End If
            End If
        End Sub

        Private Function ValidaNotas(ByVal objeto As Object) As Object

            Dim valida = True

            ValidaVacioDevuelveDouble(valida, Trim(txtTotalNota.Text), objeto.Total, lblTotal,
                                      "El total no puede estar vacío", errorValidacion)
            ValidaVacioDevuelveDouble(valida, Trim(txtIVNota.Text), objeto.IV, lblIV,
                                      "El impuesto no puede estar vacío", errorValidacion)

            objeto.SubTotalIV = CDbl(txtSubTotalIVN.Text)
            objeto.SubTotalEx = CDbl(txtSubTotalExN.Text)

            If Trim(txtFechaNota.Text) = "" Then
                objeto.Fecha = Nothing
            ElseIf Trim(txtFechaNota.Text).Length <> 10 Then
                errorValidacion.SetError(lblFechaDoc, "No se ha asignado una fecha válida a la nota de crédito. Formato '10/12/2002'")
                valida = False
            Else
                Try
                    objeto.Fecha = CDate(txtFechaNota.Text)
                Catch ex As Exception
                    errorValidacion.SetError(lblFechaDoc, "No se ha asignado una fecha válida a la nota de crédito. Formato '10/12/2002'")
                    valida = False
                End Try
            End If

            If Trim(txtFechaBoleta.Text) = "" Then
                objeto.FechaBoleta = Nothing
            ElseIf Trim(txtFechaBoleta.Text).Length <> 10 Then
                errorValidacion.SetError(lblFechaBoleta, "No se ha asignado una fecha válida a la boleta. Formato '10/12/2002'")
                valida = False
            Else
                Try
                    objeto.FechaBoleta = CDate(txtFechaBoleta.Text)
                Catch ex As Exception
                    errorValidacion.SetError(lblFechaBoleta, "No se ha asignado una fecha válida a la boleta. Formato '10/12/2002'")
                    valida = False
                End Try
            End If

            ValidaVacioDevuelveCadena(valida, Trim(txtMotivo.Text), objeto.Motivo, lblMotivo,
                                      "El motivo de la nota de crédito no puede estar vacío", errorValidacion)

            If valida Then
                Return objeto
            Else
                Return Nothing
            End If

        End Function

        Private Sub FrmNC_Proveedor_General_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load

            AddHandler txtBoleta.KeyPress, AddressOf ValidarSoloNumeros
            AddHandler txtNumNota.KeyPress, AddressOf ValidarSoloNumeros

            AddHandler txtIVNota.KeyPress, AddressOf ValidarNumerosPunto
            AddHandler txtTotalNota.KeyPress, AddressOf ValidarNumerosPunto

            AddHandler txtFechaBoleta.KeyPress, AddressOf FormatoFecha
            AddHandler txtFechaNota.KeyPress, AddressOf FormatoFecha

            If txtId_NCG.Text <> "" Then
                LlenarNotaCreditoGeneral()
                btnGuardar.Text = "Modificar"
            End If
        End Sub

        Private Sub txtBoleta_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtBoleta.KeyDown
            If (e.KeyValue = 13) Then txtFechaBoleta.Focus()
        End Sub

        Private Sub txtFechaBoleta_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtFechaBoleta.KeyDown
            If (e.KeyValue = 13) Then txtNumNota.Focus()
        End Sub

        Private Sub txtNumNota_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNumNota.KeyDown
            If (e.KeyValue = 13) Then txtFechaNota.Focus()
        End Sub

        Private Sub txtFechaNota_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtFechaNota.KeyDown
            If (e.KeyValue = 13) And chkPorDescuento.Checked Then
                txtTotalNota.Focus()
            ElseIf (e.KeyValue = 13) Then
                txtIVNota.Focus()
            End If
        End Sub

        Private Sub txtIVNota_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtIVNota.KeyDown
            If (e.KeyValue = 13) Then txtTotalNota.Focus()
        End Sub

        Private Sub txtTotalNota_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtTotalNota.KeyDown
            If (e.KeyValue = 13) Then
                If chkPorDescuento.Checked Then

                    Dim subTotalIV = CDbl(txtTotalNota.Text) / 1.13
                    txtIVNota.Text = _oUtilidades.PasarMoneda(subTotalIV * 0.13)
                    txtSubTotalIVN.Text = _oUtilidades.PasarMoneda(subTotalIV)
                    txtSubTotalExN.Text = 0

                Else
                    Dim subTotalIV = CDbl(txtIVNota.Text) / 0.13
                    If subTotalIV < 4 Then
                        subTotalIV = 0
                    End If

                    Dim subTotalEx = CDbl(txtTotalNota.Text) - subTotalIV - CDbl(txtIVNota.Text)
                    If subTotalEx < 4 Then
                        subTotalEx = 0
                    End If

                    txtSubTotalIVN.Text = _oUtilidades.PasarMoneda(subTotalIV)
                    txtSubTotalExN.Text = _oUtilidades.PasarMoneda(subTotalEx)
                End If

                txtMotivo.Focus()
            End If
        End Sub

        Private Sub chkPorDescuento_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkPorDescuento.CheckedChanged
            If chkPorDescuento.Checked Then
                txtIVNota.Enabled = False
                txtBoleta.Enabled = False
                txtFechaBoleta.Enabled = False
                txtMotivo.Text = "Por descuento"
                txtTotalNota.Focus()
            Else
                txtIVNota.Enabled = True
                txtBoleta.Enabled = True
                txtFechaBoleta.Enabled = True
                txtMotivo.Text = String.Empty
            End If
        End Sub

        Private Sub LlenarNotaCreditoGeneral()
            Dim oNcg As NCProveedorGeneral

            oNcg = _oLogicaProveedor.ConsultarGeneralPorIdNcg(CInt(txtId_NCG.Text))

            If oNcg.Boleta <> 0 Then
                txtBoleta.Text = oNcg.Boleta
            End If

            If oNcg.FechaBoleta <> Nothing Then
                txtFechaBoleta.Text = oNcg.FechaBoleta
            End If

            If oNcg.NumNC <> 0 Then
                txtNumNota.Text = oNcg.NumNC
            End If

            If oNcg.Fecha <> Nothing Then
                txtFechaNota.Text = oNcg.Fecha
            End If

            txtSubTotalIVN.Text = _oUtilidades.PasarMoneda(oNcg.SubTotalIV)
            txtSubTotalExN.Text = _oUtilidades.PasarMoneda(oNcg.SubTotalEx)
            txtIVNota.Text = _oUtilidades.PasarMoneda(oNcg.IV)
            txtTotalNota.Text = _oUtilidades.PasarMoneda(oNcg.Total)
            txtMotivo.Text = oNcg.Motivo

            If oNcg.PorDescuento Then
                chkPorDescuento.Checked = True
            End If
            txtBoleta.Focus()
        End Sub

        Private Sub FrmNC_Proveedor_General_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub
    End Class
End Namespace