Imports System.Text.RegularExpressions
Public Class Utilidades

    Private ReadOnly _oLogicaFactCredito As New LogicaFacturaCredito
    Private ReadOnly _oLogicaNotasCredito As New LogicaNotaCredito
    Private ReadOnly _oLogicaNotaDebito As New LogicaNotaDebito

    Function SoloNumeros(ByVal keyascii As Short) As Short
        If InStr("1234567890", Chr(keyascii)) = 0 Then
            SoloNumeros = 0
        Else
            SoloNumeros = keyascii
        End If
        Select Case keyascii
            Case 8
                SoloNumeros = keyascii
            Case 13
                SoloNumeros = keyascii
        End Select
    End Function

    Function TelefonoFaxValido(ByVal texto As String) As String
        If Trim(texto) = "" Then
            Return "El campo del Télefono/Fax no puede estar vacío"
        ElseIf texto.Length <> 9 Then
            Return "Error en el formato del teléfono/Fax, Ejemplo 0000-0000"
        Else
            Return ""
        End If
    End Function

    Function TelefonoFaxValidoOpcional(ByVal texto As String) As String
        If Trim(texto) = "" Or texto = "0" Then
            Return "0"
        ElseIf texto.Length <> 9 Then
            Return "Error en el formato del teléfono/Fax, Ejemplo 0000-0000"
        Else
            Return ""
        End If
    End Function

    Function ValidarCorreo(ByVal texto As String) As String
        Dim valido = Regex.IsMatch(texto, "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$")

        If Trim(texto) = "" Or Trim(texto) = "-" Then
            Return "0"
        ElseIf Not valido Then
            Return "Error en el formato del correo 'usuario@xxx.xxx'"
        Else
            Return ""
        End If
    End Function

    Function NumerosPunto(ByVal keyascii As Short) As Short
        If InStr("1234567890.", Chr(keyascii)) = 0 Then
            NumerosPunto = 0
        Else
            NumerosPunto = keyascii
        End If
        Select Case keyascii
            Case 8
                NumerosPunto = keyascii
            Case 13
                NumerosPunto = keyascii
        End Select
    End Function

    Function NumerosLinea(ByVal keyascii As Short) As Short
        If InStr("1234567890-", Chr(keyascii)) = 0 Then
            NumerosLinea = 0
        Else
            NumerosLinea = keyascii
        End If
        Select Case keyascii
            Case 8
                NumerosLinea = keyascii
            Case 13
                NumerosLinea = keyascii
        End Select
    End Function

    Function ValorUtil(ByVal cadena As String) As Double
        If IsNumeric(cadena) Then
            Return CDbl(cadena)
        Else
            Return 0
        End If
    End Function

    Function PasarMoneda(ByVal monto As Double) As String
        monto = ValorUtil(monto)
        Return Format(monto, "#,###,##0.00")
    End Function

    Function QuitarSimboloPorcentaje(ByVal impuesto As String) As Double
        impuesto = Mid(impuesto, 1, (impuesto.Length - 1))
        Return CDbl(impuesto)
    End Function

    Function ValidarApellidos(ByVal apellidos As String) As List(Of String)
        Dim arreglo() As String
        Dim cadena As String
        Dim apellido1 As String
        Dim apellido2 As String

        cadena = apellidos

        If Not (cadena = "") Then
            arreglo = Split(cadena)

            If (UBound(arreglo) = 0) Then
                apellido1 = arreglo(0)
                apellido2 = "-"
            Else
                apellido1 = arreglo(0)
                apellido2 = arreglo(1)
            End If
        Else
            apellido1 = "-"
            apellido2 = "-"
        End If

        Dim listaApellidos As New List(Of String)
        listaApellidos.Add(UCase(apellido1))
        listaApellidos.Add(UCase(apellido2))

        Return listaApellidos
    End Function

    Public Function Num_A_Letras(ByVal value As Double) As String
        Select Case value
            Case 0 : Num_A_Letras = "CERO"
            Case 1 : Num_A_Letras = "UN"
            Case 2 : Num_A_Letras = "DOS"
            Case 3 : Num_A_Letras = "TRES"
            Case 4 : Num_A_Letras = "CUATRO"
            Case 5 : Num_A_Letras = "CINCO"
            Case 6 : Num_A_Letras = "SEIS"
            Case 7 : Num_A_Letras = "SIETE"
            Case 8 : Num_A_Letras = "OCHO"
            Case 9 : Num_A_Letras = "NUEVE"
            Case 10 : Num_A_Letras = "DIEZ"
            Case 11 : Num_A_Letras = "ONCE"
            Case 12 : Num_A_Letras = "DOCE"
            Case 13 : Num_A_Letras = "TRECE"
            Case 14 : Num_A_Letras = "CATORCE"
            Case 15 : Num_A_Letras = "QUINCE"
            Case Is < 20 : Num_A_Letras = "DIECI" & Num_A_Letras(value - 10)
            Case 20 : Num_A_Letras = "VEINTE"
            Case Is < 30 : Num_A_Letras = "VEINTI" & Num_A_Letras(value - 20)
            Case 30 : Num_A_Letras = "TREINTA"
            Case 40 : Num_A_Letras = "CUARENTA"
            Case 50 : Num_A_Letras = "CINCUENTA"
            Case 60 : Num_A_Letras = "SESENTA"
            Case 70 : Num_A_Letras = "SETENTA"
            Case 80 : Num_A_Letras = "OCHENTA"
            Case 90 : Num_A_Letras = "NOVENTA"
            Case Is < 100 : Num_A_Letras = Num_A_Letras(Int(value \ 10) * 10) & " Y " & Num_A_Letras(value Mod 10)
            Case 100 : Num_A_Letras = "CIEN"
            Case Is < 200 : Num_A_Letras = "CIENTO " & Num_A_Letras(value - 100)
            Case 200, 300, 400, 600, 800 : Num_A_Letras = Num_A_Letras(Int(value \ 100)) & "CIENTOS"
            Case 500 : Num_A_Letras = "QUINIENTOS"
            Case 700 : Num_A_Letras = "SETECIENTOS"
            Case 900 : Num_A_Letras = "NOVECIENTOS"
            Case Is < 1000 : Num_A_Letras = Num_A_Letras(Int(value \ 100) * 100) & " " & Num_A_Letras(value Mod 100)
            Case 1000 : Num_A_Letras = "MIL"
            Case Is < 2000 : Num_A_Letras = "MIL " & Num_A_Letras(value Mod 1000)
            Case Is < 1000000 : Num_A_Letras = Num_A_Letras(Int(value \ 1000)) & " MIL"
                If value Mod 1000 Then Num_A_Letras = Num_A_Letras & " " & Num_A_Letras(value Mod 1000)
            Case 1000000 : Num_A_Letras = "UN MILLON"
            Case Is < 2000000 : Num_A_Letras = "UN MILLON " & Num_A_Letras(value Mod 1000000)
            Case Is < 1000000000000.0# : Num_A_Letras = Num_A_Letras(Int(value / 1000000)) & " MILLONES "
                If (value - Int(value / 1000000) * 1000000) Then Num_A_Letras = Num_A_Letras & " " & Num_A_Letras(value - Int(value / 1000000) * 1000000)
            Case 1000000000000.0# : Num_A_Letras = "UN BILLON"
            Case Is < 2000000000000.0# : Num_A_Letras = "UN BILLON " & Num_A_Letras(value - Int(value / 1000000000000.0#) * 1000000000000.0#)
            Case Else : Num_A_Letras = Num_A_Letras(Int(value / 1000000000000.0#)) & " BILLONES"
                If (value - Int(value / 1000000000000.0#) * 1000000000000.0#) Then Num_A_Letras = Num_A_Letras & " " & Num_A_Letras(value - Int(value / 1000000000000.0#) * 1000000000000.0#)
        End Select
    End Function

    Public Function calcularDatos_Cliente(ByVal idCredito As Integer) As List(Of Double)
        Dim oListFacturas
        Dim totalAtrasados As Double
        Dim totalCreditos As Double
        Dim abonos As Double
        Dim notasCredito As Double
        oListFacturas = _oLogicaFactCredito.consultarFacturasPorId_Credito(idCredito)
        Dim listaDevolver As New List(Of Double)
        Dim maxDias As Integer = 0

        With oListFacturas

            For i As Integer = 0 To oListFacturas.Count - 1
                Dim dias = DateDiff("d", oListFacturas(i).Fecha, Now)
                Dim atraso As Integer
                Dim montoConAbonos As Double

                abonos = 0
                For j = 0 To oListFacturas(i).Abonos.Count - 1
                    abonos = abonos + oListFacturas(i).Abonos(j).Monto
                Next

                notasCredito = 0
                For j = 0 To oListFacturas(i).NotasCredito.Count - 1
                    notasCredito = notasCredito + oListFacturas(i).NotasCredito(j).Monto
                Next

                montoConAbonos = oListFacturas(i).Monto - abonos - notasCredito
                totalCreditos = totalCreditos + montoConAbonos

                atraso = dias - oListFacturas(i).NumDias
                If atraso > 0 Then
                    totalAtrasados = totalAtrasados + montoConAbonos

                    If maxDias < atraso Then
                        maxDias = atraso
                    End If
                End If

            Next

            Dim oNcGenerales = _oLogicaNotasCredito.consultarGeneral(idCredito)
            Dim totalNcGenerales As Double = 0
            For i = 0 To oNcGenerales.Count - 1
                totalNcGenerales = totalNcGenerales + oNcGenerales(i).Monto
            Next

            Dim oNotasDebito = _oLogicaNotaDebito.consultarGeneral(idCredito)
            Dim totalNotasDebito As Double = 0
            For i = 0 To oNotasDebito.Count - 1
                Dim dias = DateDiff("d", oNotasDebito(i).Fecha, Now)

                Dim atraso = dias - oNotasDebito(i).NumDias
                If atraso > 0 Then
                    totalAtrasados = totalAtrasados + oNotasDebito(i).Monto

                    If maxDias < atraso Then
                        maxDias = atraso
                    End If
                End If
                totalNotasDebito = totalNotasDebito + oNotasDebito(i).Monto
            Next

            listaDevolver.Add(maxDias)
            listaDevolver.Add(PasarMoneda(totalAtrasados - totalNcGenerales))
            listaDevolver.Add(PasarMoneda(totalCreditos - totalNcGenerales + totalNotasDebito))

        End With

        Return listaDevolver
    End Function

    Public Function CalculaPaginas(ByVal paginas As Double) As Integer
        If paginas - CInt(paginas) <> 0 Then
            Dim entero = CInt(paginas)

            If entero - paginas > 0 Then
                paginas = entero
            Else
                paginas = CInt(paginas + 1)
            End If
        End If

        Return paginas
    End Function

    Public Function NumCopias(ByVal valor As String, ByVal defaul As Integer) As Integer
        Dim copias As Integer
        Try
            copias = CInt(valor)
            If copias = 0 Then
                copias = defaul
            End If
        Catch ex As Exception
            copias = defaul
        End Try

        Return copias
    End Function
End Class
