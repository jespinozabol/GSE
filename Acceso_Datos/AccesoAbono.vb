Imports MySql.Data.MySqlClient
Imports Entidades
Imports Entidades.Abono

Public Class AccesoAbono
    Inherits Transaccion

    Private Sub InicializarParametros(ByRef oComando As MySqlCommand, ByVal oAbono As Abono)
        oComando.Parameters.AddWithValue("@Id_Abono", oAbono.IdAbono)
        oComando.Parameters.AddWithValue("@NumDoc", oAbono.NumDoc)
        oComando.Parameters.AddWithValue("@Fecha", oAbono.Fecha)
        oComando.Parameters.AddWithValue("@Monto", oAbono.Monto)
        oComando.Parameters.AddWithValue("@Observaciones", oAbono.Observaciones)
        oComando.Parameters.AddWithValue("@Estado", oAbono.Estado)
        oComando.Parameters.AddWithValue("@TipoDoc", oAbono.TipoDoc)
        Return
    End Sub

    Public Sub Insertar(ByVal oAbono As Abono)
        Const sql As String = "INSERT INTO ABONO VALUES (@Id_Abono,@NumDoc, @Fecha, @Monto, @Observaciones, @Estado, @TipoDoc)"
        Dim oComando As New MySqlCommand(sql, Conexion)
        InicializarParametros(oComando, oAbono)

        Try
            InsertarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Insertando abono")
        End Try
    End Sub

    'Modifica el Estado de todos los abonos de una factura a "Pendiente" o "Aplicado" o "Anulado"
    Public Sub ModificarEstadoPorNumDocYTipo(ByVal oAbono As Abono)
        Const sql As String = "UPDATE ABONO SET Estado = @Estado WHERE NumDoc = @NumDoc AND TipoDoc = @TipoDoc"
        Dim oComando As New MySqlCommand(sql, Conexion)

        oComando.Parameters.AddWithValue("@NumDoc", oAbono.NumDoc)
        oComando.Parameters.AddWithValue("@Estado", oAbono.Estado)
        oComando.Parameters.AddWithValue("@TipoDoc", oAbono.TipoDoc)

        Try
            ModificarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Actualizar estado de abono por N° Factura")
        End Try
    End Sub

    'Modifica el Estado de un abono a "Pendiente" o "Aplicado" o "Anulado"
    Public Sub ModificarEstadoPor_IdAbono(ByVal oAbono As Abono)
        Const sql As String = "UPDATE ABONO SET Estado = @Estado WHERE Id_Abono = @Id_Abono"
        Dim oComando As New MySqlCommand(sql, Conexion)

        oComando.Parameters.AddWithValue("@Id_Abono", oAbono.IdAbono)
        oComando.Parameters.AddWithValue("@Estado", oAbono.Estado)

        Try
            'Se abre la conexion se ejecuta el comando y luego se cierra la conexion
            AbrirConexion()
            oComando.ExecuteNonQuery()
            CerrarConexion()
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Actualizar estado de abono por Id_Abono")
        End Try
    End Sub

    'Elimina todos los abonos de una factura de crédito
    Public Sub EliminarPorNumDocYTipo(ByVal numDoc As Long, ByVal tipo As ListaTipoDoc)
        Dim sql As String = String.Format("DELETE FROM ABONO WHERE NumDoc = {0} AND TipoDoc = {1}", numDoc, Convert.ToInt32(tipo))

        Try
            EliminarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Eliminando abonos por N° Factura")
        End Try
    End Sub

    'Retorna todos los abonos de una factura de crédito y que esten pendientes.
    Public Function ConsultarPendientesPorNumDocYTipo(ByVal numDoc As Long, ByVal tipo As ListaTipoDoc) As List(Of Abono)
        Dim sql = String.Format("SELECT * FROM ABONO WHERE Estado = 0 AND NumDoc = {0} AND TipoDoc = {1}", numDoc, Convert.ToInt32(tipo))
        Dim oLista As New List(Of Abono) 'Lista de Abonos que será devuelta.

        Try
            Dim oDataTable = ConsultarDatos(sql)

            For i = 0 To oDataTable.Rows.Count - 1
                oLista.Add(LlenarAbono(oDataTable.Rows(i)))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando abonos pendientes por N° Factura")
        End Try

        Return oLista
    End Function

    'Retorna todos los abonos de una factura de crédito.
    Public Function ConsultarPorNumDocYTipo(ByVal numDoc As Long, ByVal tipo As ListaTipoDoc) As List(Of Abono)
        Dim sql = String.Format("SELECT * FROM ABONO WHERE NumDoc = {0} AND TipoDoc = {1}", numDoc, Convert.ToInt32(tipo))
        Dim oLista As New List(Of Abono) 'Lista de Abonos que será devuelta.

        Try
            Dim oDataTable = ConsultarDatos(sql)

            For i = 0 To oDataTable.Rows.Count - 1
                oLista.Add(LlenarAbono(oDataTable.Rows(i)))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando abonos por N° Factura")
        End Try

        Return oLista
    End Function

    'Retorna el abono que coincida con el Id espeficicado.
    Public Function ConsultarPor_IdAbono(ByVal idAbono As Integer) As Abono
        Dim sql As String = "SELECT * FROM ABONO WHERE Id_Abono = " & idAbono
        Dim oAbono As New Abono

        Try
            Dim oDataTable = ConsultarDatos(sql)

            'Devuelve el abono o el objeto vació con un Id=0
            If oDataTable.Rows.Count > 0 Then
                oAbono = LlenarAbono(oDataTable.Rows(0))
            Else
                oAbono.IdAbono = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultar abonos por Id_Abono")
        End Try

        Return oAbono
    End Function

    Private Function LlenarAbono(ByVal row As DataRow) As Abono
        Dim oAbono As New Abono
        oAbono.IdAbono = row.Item(0)
        oAbono.NumDoc = row.Item(1)
        oAbono.Fecha = row.Item(2)
        oAbono.Monto = row.Item(3)
        oAbono.Observaciones = row.Item(4)
        oAbono.Estado = row.Item(5)
        oAbono.TipoDoc = row.Item(6)
        Return oAbono
    End Function

End Class