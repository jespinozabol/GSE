Imports MySql.Data.MySqlClient
Imports Entidades
Public Class AccesoVale
    Inherits Transaccion

    Public Sub Insertar(ByVal oVale As Vale)
        Const sql As String = "INSERT INTO VALE (Fecha,Hora,Monto,Solicitante,Autorizado,Observaciones)VALUES (@Fecha,@Hora,@Monto,@Solicitante,@Autorizado,@Observaciones)"
        Dim oComando As New MySqlCommand(sql, Conexion)
        oComando.Parameters.AddWithValue("@Fecha", oVale.Fecha)
        oComando.Parameters.AddWithValue("@Hora", oVale.Hora)
        oComando.Parameters.AddWithValue("@Monto", oVale.Monto)
        oComando.Parameters.AddWithValue("@Solicitante", oVale.Solicitante)
        oComando.Parameters.AddWithValue("@Autorizado", oVale.Autorizado)
        oComando.Parameters.AddWithValue("@Observaciones", oVale.Observaciones)

        Try
            InsertarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Insertando vale")
        End Try
    End Sub

    Public Sub Eliminar(ByVal numVale As Integer)
        Dim sql As String = "DELETE FROM VALE WHERE Num_Vale = " & numVale

        Try
            EliminarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Eliminando vale")
        End Try
    End Sub

    Public Function Consultar() As List(Of Vale)
        Const sql As String = "SELECT * FROM VALE ORDER BY Fecha"
        Dim listaVale As New List(Of Vale)
        Try
            Dim oDataTable = ConsultarDatos(sql)
            For i = 0 To oDataTable.Rows.Count - 1
                listaVale.Add(LlenarVale(oDataTable.Rows(i)))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando todos los vales")
        End Try
        Return listaVale
    End Function

    Public Function Consultar(ByVal numVale As Integer) As Vale
        Dim sql As String = "SELECT * FROM VALE WHERE Num_Vale = " & numVale
        Dim oVale As New Vale
        Try
            Dim oDataTable = ConsultarDatos(sql)
            If oDataTable.Rows.Count > 0 Then
                oVale = LlenarVale(oDataTable.Rows(0))
            Else
                oVale.Num_Vale = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando vale por numVale")
        End Try
        Return oVale
    End Function

    Private Function LlenarVale(ByVal row As DataRow) As Vale
        Dim oVale As New Vale
        oVale.Num_Vale = row.Item(0)
        oVale.Fecha = row.Item(1)
        oVale.Hora = row.Item(2)
        oVale.Monto = row.Item(3)
        oVale.Solicitante = row.Item(4)
        oVale.Autorizado = row.Item(5)
        oVale.Observaciones = row.Item(6)
        Return oVale
    End Function

    Public Function ConsultarTodosInfo() As DataTable
        Const sql As String = "SELECT v.Num_Vale, CONCAT(p.Nombre , ' ' , p.Apellido1 , ' ' , p.Apellido2), v.Fecha, v.Monto " _
                              & " From VALE v INNER JOIN EMPLEADO_OTRO e ON v.Solicitante = e.Id_Empleado_Otro INNER JOIN " _
                              & " PERSONA p ON e.Id_Persona = p.Id_Persona"
        Return DevolverResultados(sql)
    End Function

    Public Function ConsultarPor_IdPersonaInfo(ByVal idPersona As Integer) As DataTable
        Dim sql As String = "SELECT v.Num_Vale,CONCAT(p.Nombre , ' ' , p.Apellido1 , ' ' , p.Apellido2), v.Fecha, v.Monto " _
                       & " From VALE v INNER JOIN EMPLEADO_OTRO e ON v.Solicitante = e.Id_Empleado_Otro INNER JOIN " _
                       & " PERSONA p ON e.Id_Persona = p.Id_Persona WHERE p.Id_Persona = " & idPersona
        Return DevolverResultados(sql)
    End Function

    Public Function ConsultarPor_NumValeInfo(ByVal numDoc As Integer) As DataTable
        Dim sql As String = "SELECT v.Num_Vale, CONCAT(p.Nombre , ' ' , p.Apellido1 , ' ' , p.Apellido2), v.Fecha, v.Monto " _
                       & " From VALE v INNER JOIN EMPLEADO_OTRO e ON v.Solicitante = e.Id_Empleado_Otro INNER JOIN " _
                       & " PERSONA p ON e.Id_Persona = p.Id_Persona WHERE v.Num_Vale = " & numDoc
        Return DevolverResultados(sql)
    End Function

    Private Function DevolverResultados(ByVal sql As String) As DataTable
        Dim oDataTable As New DataTable

        Try
            oDataTable = ConsultarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando datos de un recibo")
        End Try

        Return oDataTable
    End Function
End Class