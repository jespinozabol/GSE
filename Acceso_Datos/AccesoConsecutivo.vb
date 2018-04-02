Imports MySql.Data.MySqlClient
Imports Entidades
Public Class AccesoConsecutivo
    Inherits Transaccion

    Public Sub Modificar(ByVal oConsecutivo As Consecutivo)
        Dim sql As String = "UPDATE " & oConsecutivo.Tabla & " SET Consecutivo = @Consecutivo, Bloqueo = @Bloqueo"
        Dim oComando As New MySqlCommand(sql, Conexion)

        oComando.Parameters.AddWithValue("@Consecutivo", oConsecutivo.Consecutivo)
        oComando.Parameters.AddWithValue("@Bloqueo", oConsecutivo.Bloqueo)

        Try
            ModificarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Modificando " & oConsecutivo.Tabla)
        End Try
    End Sub

    'Modifica el estado de la columna bloqueo
    Public Sub Modificar_Bloqueo(ByVal oConsecutivo As Consecutivo)
        Dim sql As String = "UPDATE " & oConsecutivo.Tabla & " SET Bloqueo = " & oConsecutivo.Bloqueo

        Try
            ModificarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Modificando bloqueo de tabla " & oConsecutivo.Tabla)
        End Try
    End Sub

    Function Consultar(ByVal tabla As String) As Consecutivo
        Dim sql As String = "SELECT * FROM " & tabla
        Dim oConsecutivo As New Consecutivo

        Try
            Dim oDataTable = ConsultarDatos(sql)
            oConsecutivo.Consecutivo = oDataTable.Rows(0).Item(0)
            oConsecutivo.Bloqueo = oDataTable.Rows(0).Item(1)
        Catch ex As Exception
            oConsecutivo.Consecutivo = 0
        End Try

        Return oConsecutivo
    End Function

    'Retorna el estado de la columna bloqueo, "False" o "True" o false si esta vacío
    Function ConsultarBloqueo(ByVal tabla As String) As Boolean
        Dim sql As String = "SELECT Bloqueo FROM " & tabla

        Try
            Dim oDataTable = ConsultarDatos(sql)
            Return CLng(oDataTable.Rows(0).Item(0))
        Catch ex As Exception
            Return False
        End Try
    End Function

    'Retorna el número mayor de la columna consecutivo o cero si no hay datos
    Function ConsultarMaxConsecutivo(ByVal tabla As String) As Long
        Dim sql As String = "SELECT max(Consecutivo) FROM " & tabla

        Try
            Dim oDataTable = ConsultarDatos(sql)
            Return CLng(oDataTable.Rows(0).Item(0))
        Catch ex As Exception
            Return 0
        End Try
    End Function

    'Aumenta el consecutivo en una unidad.
    Public Sub Aumentar_Consecutivo(ByVal oConsecutivo As Consecutivo)
        Dim sql As String = "UPDATE " & oConsecutivo.Tabla & " SET Consecutivo = Consecutivo + 1"

        Try
            ModificarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Aumentando " & oConsecutivo.Tabla)
        End Try
    End Sub

End Class
