Public Class AccesoVarios
    Inherits Transaccion

    Public Sub ActualizarFecha(ByVal fecha As Date)
        Dim sql As String = "UPDATE VARIOS SET Ultima_Actualizacion = " & fecha

        Try
            ModificarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Modificando ultima actualizacion en varios")
        End Try
    End Sub

    Public Function ConsultarDato(ByVal columna As String) As String
        Dim sql As String = "SELECT " & columna & " FROM VARIOS"
        Dim dato As String = ""

        Try
            Dim oDataTable = ConsultarDatos(sql)
            If oDataTable.Rows.Count > 0 Then
                dato = oDataTable.Rows(0).Item(0)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando " & columna)
        End Try

        Return dato
    End Function

    Public Sub ActualizarDato(ByVal columna As String, ByVal dato As String)
        Dim sql As String = "UPDATE VARIOS SET " & columna & " = '" & dato & "'"
        Try
            ModificarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Modificando " & columna)
        End Try
    End Sub

    Public Function Consultar() As DataTable
        Const sql As String = "SELECT * FROM VARIOS"
        Dim oDataTable As New DataTable

        Try
            oDataTable = ConsultarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando todo varios")
        End Try

        Return oDataTable
    End Function
End Class