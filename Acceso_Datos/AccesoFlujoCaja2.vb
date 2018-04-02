Imports MySql.Data.MySqlClient
Imports Entidades
Public Class AccesoFlujoCaja2
    Inherits Transaccion

    Private Function InicializarParametros(ByVal oComando As MySqlCommand, ByVal oFlujoCaja As FlujoCaja) As MySqlCommand
        oComando.Parameters.AddWithValue("@Fecha", oFlujoCaja.Fecha)
        oComando.Parameters.AddWithValue("@Efectivo", oFlujoCaja.Efectivo)
        oComando.Parameters.AddWithValue("@Cheques", oFlujoCaja.Cheques)
        oComando.Parameters.AddWithValue("@Transferencia", oFlujoCaja.Transferencia)
        oComando.Parameters.AddWithValue("@Tarjeta", oFlujoCaja.Tarjeta)
        oComando.Parameters.AddWithValue("@Dolares_Colones", oFlujoCaja.DolaresColones)
        oComando.Parameters.AddWithValue("@Redondeo", oFlujoCaja.Redondeo)
        oComando.Parameters.AddWithValue("@Vuelto", oFlujoCaja.Vuelto)
        Return oComando
    End Function

    Public Sub Insertar(ByVal oFlujoCaja As FlujoCaja)
        Const sql As String = "INSERT INTO FLUJO_CAJA2 VALUES (@Fecha,@Efectivo,@Cheques,@Transferencia,@Tarjeta,@Dolares_Colones,@Redondeo,@Vuelto)"
        Dim oComando As New MySqlCommand(sql, Conexion)
        oComando = InicializarParametros(oComando, oFlujoCaja)

        Try
            InsertarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Insertando Flujo de Caja 2")
        End Try
    End Sub

    Public Sub Modificar(ByVal oFlujoCaja As FlujoCaja)
        'Se crea la sentencia SQL, Se crea un nuevo comando que recibe la sentencia y la conexion
        Const sql As String = "UPDATE FLUJO_CAJA2 SET Efectivo = Efectivo + @Efectivo, " _
                              & "Cheques = Cheques + @Cheques,Transferencia = Transferencia + @Transferencia, " _
                              & "Tarjeta = Tarjeta + @Tarjeta ,Dolares_Colones = Dolares_Colones + @Dolares_Colones, " _
                              & "Redondeo = Redondeo + @Redondeo,Vuelto = Vuelto + @Vuelto " _
                              & "WHERE Fecha = @Fecha"
        Dim oComando As New MySqlCommand(sql, Conexion)
        oComando = InicializarParametros(oComando, oFlujoCaja)
        Try
            ModificarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Modificando Flujo de caja 2")
        End Try
    End Sub

    Public Sub Eliminar(ByVal fecha As Date)
        Dim sql As String = "DELETE FROM FLUJO_CAJA2 WHERE Fecha < '" & fecha.ToString("yyyy-MM-dd") & "'"

        Try
            EliminarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Eliminando Flujo de caja 2")
        End Try
    End Sub

    'Retorna el flujo de caja de un dia en específico
    Public Function ConsultarPor_Fecha(ByVal fecha As Date) As FlujoCaja
        Dim sql As String = "SELECT * FROM FLUJO_CAJA2 WHERE Fecha = '" & fecha.ToString("yyyy-MM-dd") & "'"
        Dim oFlujoCaja As New FlujoCaja

        Try
            Dim oDataTable = ConsultarDatos(sql)
            If oDataTable.Rows.Count > 0 Then
                oFlujoCaja.Fecha = oDataTable.Rows(0).Item(0)
                oFlujoCaja.Efectivo = oDataTable.Rows(0).Item(1)
                oFlujoCaja.Cheques = oDataTable.Rows(0).Item(2)
                oFlujoCaja.Transferencia = oDataTable.Rows(0).Item(3)
                oFlujoCaja.Tarjeta = oDataTable.Rows(0).Item(4)
                oFlujoCaja.DolaresColones = oDataTable.Rows(0).Item(5)
                oFlujoCaja.Redondeo = oDataTable.Rows(0).Item(6)
                oFlujoCaja.Vuelto = oDataTable.Rows(0).Item(7)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando Flujo de caja 2 por fecha")
        End Try

        Return oFlujoCaja
    End Function

    'Retorna "True" si el flujo de caja existe o "False" de lo contrario
    Public Function ConsultarNueva(ByVal fecha As Date) As Boolean
        Dim sql As String = "SELECT * FROM FLUJO_CAJA2 WHERE Fecha = '" & fecha.ToString("yyyy-MM-dd") & "'"
        Dim oDataTable As DataTable
        Try
            oDataTable = ConsultarDatos(sql)
            If oDataTable.Rows.Count > 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando si existe el flujo de caja 2")
            Return True
        End Try
    End Function
End Class