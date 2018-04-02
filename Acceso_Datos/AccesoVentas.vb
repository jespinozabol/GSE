Imports MySql.Data.MySqlClient
Imports Entidades
Public Class AccesoVentas
    Inherits Transaccion

    Public Sub Insertar(ByVal oVenta As Ventas)
        Const sql As String = "INSERT INTO PromedioVentas (IdProducto,Mes,Año,Cantidad)VALUES (@Fecha,@Hora,@Monto,@Solicitante,@Autorizado,@Observaciones)"
        Dim oComando As New MySqlCommand(sql, Conexion)
        oComando.Parameters.AddWithValue("@IdProducto", oVenta.IdProducto)
        oComando.Parameters.AddWithValue("@Mes", oVenta.Mes)
        oComando.Parameters.AddWithValue("@Año", oVenta.Año)
        oComando.Parameters.AddWithValue("@Cantidad", oVenta.Cantidad)

        Try
            InsertarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Insertando promedio venta mensual")
        End Try
    End Sub

    Public Function Consultar(ByVal IdProducto As Integer) As List(Of Ventas)
        Dim sql As String = "SELECT * FROM PromedioVentas WHERE IdProducto = " & IdProducto
        Dim promedios As New List(Of Ventas)
        Try
            Dim oDataTable = ConsultarDatos(sql)
            For i = 0 To oDataTable.Rows.Count - 1
                promedios.Add(LlenarVale(oDataTable.Rows(i)))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando promedios por IdProducto")
        End Try
        Return promedios
    End Function

    Private Function LlenarVale(ByVal row As DataRow) As Ventas
        Dim oVenta As New Ventas
        oVenta.IdProducto = row.Item(0)
        oVenta.Mes = row.Item(1)
        oVenta.Año = row.Item(2)
        oVenta.Cantidad = row.Item(3)
        Return oVenta
    End Function

    Private Function DevolverResultados(ByVal sql As String) As DataTable
        Dim oDataTable As New DataTable

        Try
            oDataTable = ConsultarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando datos de uns venta")
        End Try

        Return oDataTable
    End Function

End Class
