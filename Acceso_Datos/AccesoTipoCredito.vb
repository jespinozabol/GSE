Imports MySql.Data.MySqlClient
Imports Entidades
Public Class AccesoTipoCredito
    Inherits Transaccion

    Public Sub Modificar(ByVal tipo As Tipo_Credito)
        Const sql As String = "UPDATE ADM_TIPO_CREDITO SET Dias = @Dias, Limite = @Limite, DiasAtraso = @DiasAtraso WHERE Tipo = @Tipo"
        Dim oComando As New MySqlCommand(sql, Conexion)
        oComando.Parameters.AddWithValue("@Tipo", tipo.Tipo)
        oComando.Parameters.AddWithValue("@Dias", tipo.Dias)
        oComando.Parameters.AddWithValue("@Limite", tipo.Limite)
        oComando.Parameters.AddWithValue("@DiasAtraso", tipo.DiasAtraso)

        Try
            ModificarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Modificando tipo de crédito")
        End Try
    End Sub

    Public Function Consultar(ByVal tipo As String) As Tipo_Credito
        Dim sql As String = "SELECT * FROM ADM_TIPO_CREDITO WHERE Tipo = '" & tipo & "'"
        Dim oTipoCredito As New Tipo_Credito
        Try
            Dim oDataTable = ConsultarDatos(sql)
            If oDataTable.Rows.Count > 0 Then
                oTipoCredito = LlenarTipoCredito(oDataTable.Rows(0))
            Else
                oTipoCredito.Tipo = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando tipo de crédito")
        End Try

        Return oTipoCredito
    End Function

    Public Function Consultar() As List(Of Tipo_Credito)
        Const sql As String = "SELECT * FROM ADM_TIPO_CREDITO"
        Dim listTipoCredito As New List(Of Tipo_Credito)
        Try
            Dim oDataTable = ConsultarDatos(sql)
            For i = 0 To oDataTable.Rows.Count - 1
                listTipoCredito.Add(LlenarTipoCredito(oDataTable.Rows(i)))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando todos los tipos de crédito")
        End Try
        Return listTipoCredito
    End Function

    Private Function LlenarTipoCredito(ByVal row As DataRow) As Tipo_Credito
        Dim oTipoCredito = New Tipo_Credito
        oTipoCredito.Tipo = row.Item(0)
        oTipoCredito.Dias = row.Item(1)
        oTipoCredito.Limite = row.Item(2)
        oTipoCredito.DiasAtraso = row.Item(3)
        Return oTipoCredito
    End Function
End Class
