Imports MySql.Data.MySqlClient
Public Class AccesoMonedaMinima
    Inherits Transaccion

    Public Sub Modificar(ByVal moneda As Integer)
        Const sql As String = "UPDATE MONEDA_MINIMA SET Moneda = @Moneda"
        Dim oComando As New MySqlCommand(sql, Conexion)
        oComando.Parameters.AddWithValue("@Moneda", moneda)

        Try
            InsertarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Insertando Moneda")
        End Try
    End Sub

    'Devuelve la moneda minima permitida o 0 si la tabla esta vacía
    Public Function ConsultarMoneda() As Integer
        Const sql As String = "SELECT * FROM MONEDA_MINIMA"

        Try
            Dim oDataTable = ConsultarDatos(sql)
            If oDataTable.Rows.Count > 0 Then
                Return oDataTable.Rows(0).Item(0)
            Else
                Return 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando Moneda")
            Return 0
        End Try
    End Function

End Class