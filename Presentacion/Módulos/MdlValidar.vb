Option Explicit On
Imports Logica_Negocios
Imports Entidades

Module MdlValidar

    Private ReadOnly Utilidades As New Utilidades

    Public Sub ValidarSoloNumeros(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs)
        Dim keyAscii As Short = CShort(Asc(e.KeyChar))
        keyAscii = CShort(Utilidades.SoloNumeros(keyAscii))

        If keyAscii = 0 Then e.Handled = True
    End Sub

    Public Sub ValidarNumerosPunto(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs)
        Dim keyAscii As Short = CShort(Asc(e.KeyChar))
        keyAscii = CShort(Utilidades.NumerosPunto(keyAscii))

        If keyAscii = 0 Then e.Handled = True
    End Sub

    Public Sub ValidaVacioDevuelveEntero(ByRef valida As Boolean, ByVal txtValida As String, ByRef objeto As Object, ByVal lblMostrarError As Label, ByVal cadenaError As String,
                                       ByVal errores As ErrorProvider)
        If txtValida = "" Then
            errores.SetError(lblMostrarError, cadenaError)
            valida = False
        Else
            objeto = CInt(txtValida)
        End If
    End Sub

    Public Sub ValidaVacioDevuelveDouble(ByRef valida As Boolean, ByVal txtValida As String, ByRef objeto As Object, ByVal lblMostrarError As Label, ByVal cadenaError As String,
                                       ByVal errores As ErrorProvider)
        If txtValida = "" Then
            errores.SetError(lblMostrarError, cadenaError)
            valida = False
        Else
            objeto = CDbl(txtValida)
        End If
    End Sub

    Public Sub ValidaVacioDevuelveCadena(ByRef valida As Boolean, ByVal txtValida As String, ByRef objeto As Object, ByVal lblMostrarError As Label, ByVal cadenaError As String,
                                       ByVal errores As ErrorProvider)
        If txtValida = "" Then
            errores.SetError(lblMostrarError, cadenaError)
            valida = False
        Else
            objeto = UCase(txtValida)
        End If
    End Sub

    Public Sub ValidaVacioCeroDevuelveCadena(ByRef valida As Boolean, ByVal txtValida As String, ByRef objeto As Object, ByVal lblMostrarError As Label, ByVal cadenaError As String,
                                              ByVal errores As ErrorProvider)
        If txtValida = "" Then
            errores.SetError(lblMostrarError, cadenaError)
            valida = False
        Else
            objeto = txtValida
        End If
    End Sub

    Public Function RetornaEstadoCheckBox(ByVal chkBox As CheckBox) As Boolean
        If chkBox.Checked Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function ValidarFecha(ByVal valido As Boolean, ByVal txtFecha As TextBox, ByVal msg As String)
        Try
            txtFecha.Text = CDate(txtFecha.Text)
        Catch ex As Exception
            MsgBox("La fecha " & msg & " esta vacía o el formato es incorrecto", MsgBoxStyle.Exclamation)
            valido = False
        End Try

        Return valido
    End Function

    Public Sub ValidarTelefonoPrincipal(ByRef valida As Boolean, ByVal telefono As String, ByRef oPersona As Persona, ByVal errores As ErrorProvider, ByVal lblError As Label)
        Dim salida = Utilidades.TelefonoFaxValido(telefono)
        oPersona.OtraInformacion.TelefonoPrincipal = RetornarValorOpcional(valida, salida, errores, lblError, telefono)
    End Sub

    Public Sub ValidarOtroTelefono(ByRef valida As Boolean, ByVal telefono As String, ByRef oPersona As Persona, ByVal errores As ErrorProvider, ByVal lblError As Label)
        Dim salida = Utilidades.TelefonoFaxValidoOpcional(telefono)
        oPersona.OtraInformacion.OtroTelefono = RetornarValorOpcional(valida, salida, errores, lblError, telefono)
    End Sub

    Public Sub ValidarFaxPrincipal(ByRef valida As Boolean, ByVal fax As String, ByRef oPersona As Persona, ByVal errores As ErrorProvider, ByVal lblError As Label)
        Dim salida = Utilidades.TelefonoFaxValidoOpcional(fax)
        oPersona.OtraInformacion.FaxPrincipal = RetornarValorOpcional(valida, salida, errores, lblError, fax)
    End Sub

    Public Sub ValidarEmail(ByRef valida As Boolean, ByVal email As String, ByRef oPersona As Persona, ByVal errores As ErrorProvider, ByVal lblError As Label)
        Dim salida = Utilidades.ValidarCorreo(email)
        oPersona.OtraInformacion.Email = LCase(RetornarValorOpcional(valida, salida, errores, lblError, email))
    End Sub

    Public Function RetornarValorOpcional(ByRef valida As Boolean, ByVal salida As String, ByVal errores As ErrorProvider, ByVal lblError As Label, ByVal valor As String) As String
        Dim retorno = String.Empty
        If salida = "" Then
            retorno = valor
        ElseIf salida <> "0" Then
            errores.SetError(lblError, salida)
            valida = False
        End If
        Return retorno
    End Function
End Module
