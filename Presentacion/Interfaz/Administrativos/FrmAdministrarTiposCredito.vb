Imports Logica_Negocios
Imports Entidades

Namespace Interfaz.Administrativos

    Public Class FrmAdministrarTiposCredito

        Private ReadOnly _oLogicaTipoCredito As New LogicaTipoCredito

        Private Sub FrmAdministrar_TiposCredito_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            Dim lista = _oLogicaTipoCredito.consultarTodos

            txtDiasCreditoPre.Text = lista(0).Dias
            txtLimiteExtraPre.Text = lista(0).Limite
            txtDiasCobroPre.Text = lista(0).DiasAtraso

            txtDiasCreditoNor.Text = lista(1).Dias
            txtLimiteExtraNor.Text = lista(1).Limite
            txtDiasCobroNor.Text = lista(1).DiasAtraso

            txtDiasCreditoPru.Text = lista(2).Dias
            txtLimiteExtraPru.Text = lista(2).Limite
            txtDiasCobroPru.Text = lista(2).DiasAtraso

            AddHandler txtDiasCreditoPre.KeyPress, AddressOf ValidarSoloNumeros
            AddHandler txtDiasCreditoNor.KeyPress, AddressOf ValidarSoloNumeros
            AddHandler txtDiasCreditoPru.KeyPress, AddressOf ValidarSoloNumeros

            AddHandler txtLimiteExtraPre.KeyPress, AddressOf ValidarNumerosPunto
            AddHandler txtLimiteExtraNor.KeyPress, AddressOf ValidarNumerosPunto
            AddHandler txtLimiteExtraPru.KeyPress, AddressOf ValidarNumerosPunto
        End Sub

        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
            Dim listaTipos = valida()
            For i = 0 To listaTipos.Count - 1
                _oLogicaTipoCredito.modificar(listaTipos(i))
            Next
            MsgBox("Datos guardados con éxito", MsgBoxStyle.Information)
        End Sub

        Private Function valida() As List(Of Tipo_Credito)
            errorTipos.Clear()
            Dim list As New List(Of Tipo_Credito)
            Dim valido = True

            Dim preferencial As New Tipo_Credito
            preferencial.Tipo = "Preferencial"

            Dim normal As New Tipo_Credito
            normal.Tipo = "Normal"

            Dim prueba As New Tipo_Credito
            prueba.Tipo = "Prueba"

            If Trim(txtDiasCreditoPre.Text) = "" Or Trim(txtDiasCreditoPru.Text) = "" Or Trim(txtDiasCreditoNor.Text) = "" Then
                errorTipos.SetError(lblError1, "Se deben agregar todos los días plazo para dar crédito")
                valido = False
            Else
                preferencial.Dias = CInt(txtDiasCreditoPre.Text)
                prueba.Dias = CInt(txtDiasCreditoPru.Text)
                normal.Dias = CInt(txtDiasCreditoNor.Text)
            End If

            If Trim(txtDiasCobroPre.Text) = "" Or Trim(txtDiasCobroPru.Text) = "" Or Trim(txtDiasCobroNor.Text) = "" Then
                errorTipos.SetError(lblerror3, "Se deben agregar todos los días plazo para realizar el cobro")
                valido = False
            Else
                preferencial.DiasAtraso = CInt(txtDiasCobroPre.Text)
                prueba.DiasAtraso = CInt(txtDiasCobroPru.Text)
                normal.DiasAtraso = CInt(txtDiasCobroNor.Text)
            End If

            If Trim(txtLimiteExtraPre.Text) = "" Or Trim(txtLimiteExtraPru.Text) = "" Or Trim(txtLimiteExtraNor.Text) = "" Then
                errorTipos.SetError(lblerror2, "Debe agregar el límite de todos los tipos")
                valido = False
            Else
                preferencial.Limite = CDbl(txtLimiteExtraPre.Text)
                normal.Limite = CDbl(txtLimiteExtraNor.Text)
                prueba.Limite = CDbl(txtLimiteExtraPru.Text)
            End If

            If valido Then
                list.Add(preferencial)
                list.Add(normal)
                list.Add(prueba)
            End If

            Return list
        End Function

        Private Sub FrmAdministrar_TiposCredito_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Dispose()
        End Sub
    End Class
End Namespace