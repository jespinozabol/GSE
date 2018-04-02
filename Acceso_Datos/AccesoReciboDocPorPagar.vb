Imports MySql.Data.MySqlClient
Imports Entidades
Public Class AccesoReciboDocPorPagar
    Inherits Transaccion

    Private Sub InicializarParametros(ByVal oComando As MySqlCommand, ByVal oRecibo As ReciboDocPorPagar)
        oComando.Parameters.AddWithValue("@Id_Proveedor", oRecibo.IdProveedor)
        oComando.Parameters.AddWithValue("@Anulado", oRecibo.Anulado)
        oComando.Parameters.AddWithValue("@Monto", oRecibo.Monto)
        oComando.Parameters.AddWithValue("@Fecha", oRecibo.Fecha)
        oComando.Parameters.AddWithValue("@Concepto", oRecibo.Concepto)
        oComando.Parameters.AddWithValue("@Total_Cheques", oRecibo.TotalCheques)
        oComando.Parameters.AddWithValue("@Total_Transferencias", oRecibo.TotalTransferencias)
        oComando.Parameters.AddWithValue("@Total_Efectivo", oRecibo.TotalEfectivo)
        oComando.Parameters.AddWithValue("@Total_Dolares", oRecibo.TotalDolares)
        oComando.Parameters.AddWithValue("@Observaciones", oRecibo.Observaciones)
        oComando.Parameters.AddWithValue("@Saldo_Actual", oRecibo.SaldoActual)
        oComando.Parameters.AddWithValue("@Num_Recibo_Proveedor", oRecibo.NumReciboProveedor)
        oComando.Parameters.AddWithValue("@Fecha_Recibo_Proveedor", oRecibo.FechaReciboProveedor)
        Return
    End Sub

    Public Sub Insertar(ByVal oReciboDocPorPagar As ReciboDocPorPagar)
        Const sql As String = "INSERT INTO RECIBODOCPORPAGAR_ENCABEZADO (Id_Proveedor,Anulado,Monto,Fecha,Concepto,Total_Cheques, " _
                              & " Total_Transferencias,Total_Efectivo,Total_Dolares,Observaciones,Saldo_Actual,Num_Recibo_Proveedor,Fecha_Recibo_Proveedor) VALUES (@Id_Proveedor, " _
                              & " @Anulado, @Monto, @Fecha, @Concepto,@Total_Cheques,@Total_Transferencias,@Total_Efectivo,@Total_Dolares,@Observaciones,@Saldo_Actual," _
                              & " @Num_Recibo_Proveedor, @Fecha_Recibo_Proveedor) ; SELECT @@Identity"
        Dim oComando As New MySqlCommand(sql, Conexion)
        InicializarParametros(oComando, oReciboDocPorPagar)

        Dim id As Integer
        Try
            id = InsertarDatosDevuelveId(oComando)

            For i As Integer = 0 To oReciboDocPorPagar.ReciboDetalle.Count - 1
                oReciboDocPorPagar.ReciboDetalle(i).NumRecibo = id
                Insertar_Detalle(oReciboDocPorPagar.ReciboDetalle(i))
            Next i
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Insertando recibo")
        End Try
    End Sub

    Public Sub ModificarFechaDetalleRecibo(ByVal numRecibo As String, ByVal fecha As Date, ByVal idFactProveedor As Integer, ByVal observaciones As String)
        Dim sql As String = "UPDATE RECIBODOCPORPAGAR_ENCABEZADO SET Fecha_Recibo_Proveedor = '" & fecha.ToString("yyyy-MM-dd") & "' , Num_Recibo_Proveedor = '" & numRecibo _
                            & "', Observaciones = '" & observaciones & "'  WHERE Num_Recibo = " & idFactProveedor
        Try
            ModificarDatos(Sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Modificando fecha y numRecibo recibo")
        End Try
    End Sub

    Public Sub Eliminar(ByVal numRecibo As Integer)
        Dim sql As String = "DELETE FROM RECIBODOCPORPAGAR_ENCABEZADO WHERE Num_Recibo = " & numRecibo

        Try
            EliminarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Public Function Consultar(ByVal numRecibo As Integer) As ReciboDocPorPagar
        Dim sql As String = "SELECT * FROM RECIBODOCPORPAGAR_ENCABEZADO WHERE Num_Recibo = " & numRecibo
        Dim oRecibo As New ReciboDocPorPagar

        Try
            Dim oDataTable = ConsultarDatos(sql)
            If oDataTable.Rows.Count > 0 Then
                oRecibo = LlenarRecibo(oDataTable.Rows(0))
                oRecibo.ReciboDetalle = ConsultarDetalles_Recibo(oRecibo.NumRecibo)
            Else
                oRecibo.NumRecibo = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando recibo")
        End Try

        Return oRecibo
    End Function

    Private Function LlenarRecibo(ByVal row As DataRow) As ReciboDocPorPagar
        Dim oRecibo As New ReciboDocPorPagar
        oRecibo.NumRecibo = row.Item(0)
        oRecibo.IdProveedor = row.Item(1)
        oRecibo.Anulado = row.Item(2)
        oRecibo.Monto = row.Item(3)
        oRecibo.Fecha = row.Item(4)
        oRecibo.Concepto = row.Item(5)
        oRecibo.TotalCheques = row.Item(6)
        oRecibo.TotalTransferencias = row.Item(7)
        oRecibo.TotalEfectivo = row.Item(8)
        oRecibo.TotalDolares = row.Item(9)
        oRecibo.Observaciones = row.Item(10)
        oRecibo.SaldoActual = row.Item(11)
        oRecibo.NumReciboProveedor = row.Item(12)
        oRecibo.FechaReciboProveedor = row.Item(13)
        Return oRecibo
    End Function

    '**********************************************RECIBO DETALLE***************************************************

    Private Function InicializarParametrosDetalle(ByVal oComando As MySqlCommand, ByVal oReciboDetalle As ReciboDocPorPagarDetalle)
        oComando.Parameters.AddWithValue("@Num_Recibo", oReciboDetalle.NumRecibo)
        oComando.Parameters.AddWithValue("@Tipo", oReciboDetalle.Tipo)
        oComando.Parameters.AddWithValue("@IdDoc", oReciboDetalle.IdDoc)
        Return oComando
    End Function

    Private Sub Insertar_Detalle(ByVal oReciboDetalle As ReciboDocPorPagarDetalle)
        Const sql As String = "INSERT INTO RECIBODOCPORPAGAR_DETALLE (Num_Recibo, Tipo, IdDoc) VALUES (@Num_Recibo, @Tipo, @IdDoc)"
        Dim oComando As New MySqlCommand(sql, Conexion)
        InicializarParametrosDetalle(oComando, oReciboDetalle)

        Try
            InsertarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Insertando recibo detalle")
        End Try
    End Sub

    Private Function LlenarReciboDetalle(ByVal row As DataRow) As ReciboDocPorPagarDetalle
        Dim oDetalle As New ReciboDocPorPagarDetalle
        oDetalle.NumRecibo = row.Item(0)
        oDetalle.Tipo = row.Item(1)
        oDetalle.IdDoc = row.Item(2)
        Return oDetalle
    End Function

    Public Function ConsultarDetalles_Recibo(ByVal numRecibo As Integer) As List(Of ReciboDocPorPagarDetalle)
        Dim sql As String = "SELECT * FROM RECIBODOCPORPAGAR_DETALLE WHERE Num_Recibo = " & numRecibo
        Dim oListaDetalles As New List(Of ReciboDocPorPagarDetalle)

        Try
            Dim oDataTable = ConsultarDatos(sql)
            For i = 0 To oDataTable.Rows.Count - 1
                oListaDetalles.Add(LlenarReciboDetalle(oDataTable.Rows(i)))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando detalles del recibo")
        End Try

        Return oListaDetalles
    End Function

    'Retornan el número de recibo, el número de recibo del proveedor, el nombre del cliente, la fecha, el monto según los 
    ' criterios de búsqueda.
    Public Function ConsultarTodosInfo() As DataTable
        Const sql As String = "SELECT r.Num_Recibo, r.Num_Recibo_Proveedor, p.Nombre , r.Fecha, r.Monto " _
                              & " FROM RECIBODOCPORPAGAR_ENCABEZADO r " _
                              & " INNER JOIN PROVEEDOR p ON r.Id_Proveedor = p.Id_Proveedor " _
                              & " ORDER BY p.Nombre, r.Fecha"
        Return DevolverResultados(sql)
    End Function

    Public Function ConsultarTodosInfo(ByVal fechaInicio As Date, ByVal fechaFinal As Date) As DataTable
        Dim sql As String = "SELECT r.Num_Recibo, r.Num_Recibo_Proveedor, p.Nombre , r.Fecha, r.Monto " _
                             & " FROM RECIBODOCPORPAGAR_ENCABEZADO r INNER JOIN PROVEEDOR p ON r.Id_Proveedor = p.Id_Proveedor " _
                             & " WHERE r.Fecha  >= '" & fechaInicio.ToString("yyyy-MM-dd") & "' AND r.Fecha <= '" & fechaFinal.ToString("yyyy-MM-dd") & "'" _
                             & " ORDER BY p.Nombre, r.Fecha"
        Return DevolverResultados(sql)
    End Function

    Public Function ConsultarPor_IdProveedor(ByVal idProveedor As Integer) As DataTable
        Dim sql As String = "SELECT  r.Num_Recibo, r.Num_Recibo_Proveedor, p.Nombre, r.Fecha, r.Monto " _
                          & " FROM RECIBODOCPORPAGAR_ENCABEZADO r INNER JOIN PROVEEDOR p ON r.Id_Proveedor = p.Id_Proveedor " _
                          & " WHERE p.Id_Proveedor = " & idProveedor & " Order by r.Num_Recibo"
        Return DevolverResultados(sql)
    End Function

    Public Function ConsultarPor_IdProveedor(ByVal idProveedor As Integer, ByVal fechaInicio As Date, ByVal fechaFinal As Date) As DataTable
        Dim sql As String = "SELECT  r.Num_Recibo, r.Num_Recibo_Proveedor, p.Nombre, r.Fecha, r.Monto " _
                          & " FROM RECIBODOCPORPAGAR_ENCABEZADO r INNER JOIN PROVEEDOR p ON r.Id_Proveedor = p.Id_Proveedor " _
                          & " WHERE p.Id_Proveedor = " & idProveedor _
                          & " AND r.Fecha  >= '" & fechaInicio.ToString("yyyy-MM-dd") & "' AND r.Fecha <= '" & fechaFinal.ToString("yyyy-MM-dd") & "' Order by r.Num_Recibo"""
        Return DevolverResultados(sql)
    End Function

    Public Function ConsultarPor_NumReciboProveedor(ByVal numRecibo As Integer) As DataTable
        Dim sql As String = "SELECT  r.Num_Recibo, r.Num_Recibo_Proveedor, p.Nombre, r.Fecha, r.Monto " _
                       & " FROM RECIBODOCPORPAGAR_ENCABEZADO r INNER JOIN PROVEEDOR p ON r.Id_Proveedor = p.Id_Proveedor " _
                       & "  WHERE r.Num_Recibo_Proveedor = " & numRecibo
        Return DevolverResultados(sql)
    End Function

    Public Function consultarPor_NumFactura(ByVal numFactura As String) As DataTable
        Return New DataTable
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