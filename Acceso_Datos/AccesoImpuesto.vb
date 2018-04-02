Public Class AccesoImpuesto
    Inherits Transaccion

    Public Sub Modificar(ByVal impuesto As Double)
        Dim sql As String = "UPDATE IMPUESTO SET Impuesto = " & impuesto

        Try
            ModificarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Modificando Impuesto")
        End Try
    End Sub

    'Extraetodo de la tabla Impuesto si existe lo devuelve o un cero de lo contrario
    Function Consultar() As Double
        Const sql As String = "SELECT * FROM IMPUESTO"

        Try
            Dim oDataTable = ConsultarDatos(sql)
            If oDataTable.Rows.Count > 0 Then
                Return oDataTable.Rows(0).Item(0)
            Else
                Return 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando Impuesto")
            Return 0
        End Try
    End Function
End Class