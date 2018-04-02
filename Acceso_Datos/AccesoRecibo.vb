Imports MySql.Data.MySqlClient
Imports Entidades
Public Class AccesoRecibo
    Inherits Transaccion

    Private Function InicializarParametros(ByVal oComando As MySqlCommand, ByVal oRecibo As Recibo)
        oComando.Parameters.AddWithValue("@Num_Recibo", oRecibo.NumRecibo)
        oComando.Parameters.AddWithValue("@IdCliente_Credito", oRecibo.IdClienteCredito)
        oComando.Parameters.AddWithValue("@Anulado", oRecibo.Anulado)
        oComando.Parameters.AddWithValue("@Monto", oRecibo.Monto)
        oComando.Parameters.AddWithValue("@Fecha", oRecibo.Fecha)
        oComando.Parameters.AddWithValue("@Concepto", oRecibo.Concepto)
        oComando.Parameters.AddWithValue("@Total_Cheques", oRecibo.TotalCheques)
        oComando.Parameters.AddWithValue("@Total_Transferencias", oRecibo.TotalTransferencias)
        oComando.Parameters.AddWithValue("@Total_Efectivo", oRecibo.TotalEfectivo)
        oComando.Parameters.AddWithValue("@Observaciones", oRecibo.Observaciones)
        oComando.Parameters.AddWithValue("@Saldo_Actual", oRecibo.SaldoActual)
        Return oComando
    End Function

    Public Sub Insertar(ByVal oRecibo As Recibo)
        Const sql As String = "INSERT INTO RECIBODINERO_ENCABEZADO VALUES (@Num_Recibo, @IdCliente_Credito, @Anulado, @Monto, @Fecha, @Concepto,@Total_Cheques,@Total_Transferencias,@Total_Efectivo,@Observaciones,@Saldo_Actual)"
        Dim oComando As New MySqlCommand(sql, Conexion)
        InicializarParametros(oComando, oRecibo)

        Try
            InsertarDatos(oComando)

            For i As Integer = 0 To oRecibo.ReciboDetalle.Count - 1
                Insertar_Detalle(oRecibo.ReciboDetalle(i))
            Next i

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Insertando recibo")
        End Try
    End Sub

    'Elimina todos los recibos de un cliente
    Public Sub Eliminar_IdCredito(ByVal idCredito As Integer)
        Dim sql As String = "DELETE FROM RECIBODINERO_ENCABEZADO WHERE IdCliente_Credito = " & idCredito

        Try
            EliminarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Eliminando recibos")
        End Try
    End Sub

    Public Sub AnularRecibo(ByVal numRecibo As Integer)
        Dim sql As String = "UPDATE RECIBODINERO_ENCABEZADO SET Anulado = 1 WHERE Num_Recibo = " & numRecibo

        Try
            ModificarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Anulando recibo")
        End Try
    End Sub

    'Traslado el recibo de un cliente de credito a otro.
    Public Sub TrasladarRecibo(ByVal idCreditoActual As Integer, ByVal idCreditoTrasladar As Integer)
        Dim sql As String = "UPDATE RECIBODINERO_ENCABEZADO SET IdCliente_Credito = " & idCreditoActual & " WHERE IdCliente_Credito = " & idCreditoTrasladar

        Try
            ModificarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Trasladando un recibo de un cliente a otro.")
        End Try
    End Sub

    Public Function Consultar(ByVal numRecibo As Integer) As Recibo
        Dim sql As String = "SELECT * FROM RECIBODINERO_ENCABEZADO WHERE Num_Recibo = " & numRecibo
        Dim oRecibo As New Recibo

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

    Private Function LlenarRecibo(ByVal row As DataRow) As Recibo
        Dim oRecibo As New Recibo
        oRecibo.NumRecibo = row.Item(0)
        oRecibo.IdClienteCredito = row.Item(1)
        oRecibo.Anulado = row.Item(2)
        oRecibo.Monto = row.Item(3)
        oRecibo.Fecha = row.Item(4)
        oRecibo.Concepto = row.Item(5)
        oRecibo.TotalCheques = row.Item(6)
        oRecibo.TotalTransferencias = row.Item(7)
        oRecibo.TotalEfectivo = row.Item(8)
        oRecibo.Observaciones = row.Item(9)
        oRecibo.SaldoActual = row.Item(10)
        Return oRecibo
    End Function

    '**********************************************RECIBO DETALLE***************************************************

    Private Function InicializarParametrosDetalle(ByVal oComando As MySqlCommand, ByVal oReciboDetalle As ReciboDetalle)
        oComando.Parameters.AddWithValue("@Num_Recibo", oReciboDetalle.NumRecibo)
        oComando.Parameters.AddWithValue("@Tipo", oReciboDetalle.Tipo)
        oComando.Parameters.AddWithValue("@Doc", oReciboDetalle.Doc)
        oComando.Parameters.AddWithValue("@Fecha", oReciboDetalle.Fecha)
        oComando.Parameters.AddWithValue("@Monto", oReciboDetalle.Monto)
        Return oComando
    End Function

    Private Sub Insertar_Detalle(ByVal oReciboDetalle As ReciboDetalle)
        Const sql As String = "INSERT INTO RECIBODINERO_DETALLE VALUES (@Num_Recibo, @Tipo, @Doc, @Fecha, @Monto)"
        Dim oComando As New MySqlCommand(sql, Conexion)
        InicializarParametrosDetalle(oComando, oReciboDetalle)

        Try
            InsertarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Insertando recibo detalle")
        End Try
    End Sub

    Private Function LlenarReciboDetalle(ByVal row As DataRow) As ReciboDetalle
        Dim oDetalle As New ReciboDetalle
        oDetalle.NumRecibo = row.Item(0)
        oDetalle.Tipo = row.Item(1)
        oDetalle.Doc = row.Item(2)
        oDetalle.Fecha = row.Item(3)
        oDetalle.Monto = row.Item(4)
        Return oDetalle
    End Function

    Public Function ConsultarDetalles_Recibo(ByVal numRecibo As Integer) As List(Of ReciboDetalle)
        Dim sql As String = "SELECT * FROM RECIBODINERO_DETALLE WHERE Num_Recibo = " & numRecibo
        Dim oListaDetalles As New List(Of ReciboDetalle)

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

    'Retornan el número de recibo, el nombre del cliente, la fecha, el monto y la columna anulado según los 
    ' criterios de búsqueda.

    Public Function ConsultarTodosInfo() As DataTable
        Const sql As String = "SELECT r.Num_Recibo, CONCAT(p.Nombre , ' ' , p.Apellido1 , ' ' , p.Apellido2) as Nombre, " _
                              & " r.Fecha, r.Monto, r.Anulado " _
                              & " FROM RECIBODINERO_ENCABEZADO r INNER JOIN CLIENTE_CREDITO c ON r.IdCliente_Credito = c.Id_Credito " _
                              & " INNER JOIN PERSONA p ON c.Id_Persona = p.Id_Persona " _
                              & " ORDER BY r.Num_Recibo"
        Return DevolverResultados(sql)
    End Function

    Public Function ConsultarPor_NumReciboInfo(ByVal numRecibo As Integer) As DataTable
        Dim sql As String = "SELECT r.Num_Recibo, CONCAT(p.Nombre , ' ' , p.Apellido1 , ' ' , p.Apellido2) as Nombre, " _
                       & " r.Fecha, r.Monto, r.Anulado " _
                       & " FROM RECIBODINERO_ENCABEZADO r INNER JOIN CLIENTE_CREDITO c ON r.IdCliente_Credito = c.Id_Credito " _
                       & " INNER JOIN PERSONA p ON c.Id_Persona = p.Id_Persona WHERE r.Num_Recibo = " & numRecibo
        Return DevolverResultados(sql)
    End Function

    Public Function ConsultarPor_NumFacturaInfo(ByVal numFactura As Long) As DataTable
        Dim sql As String = " SELECT r.Num_Recibo,  CONCAT(p.Nombre , ' ' , p.Apellido1 , ' ' , p.Apellido2) as Nombre, " _
                           & " r.Fecha, r.Monto, r.Anulado " _
                           & " FROM CLIENTE_CREDITO c INNER JOIN PERSONA p ON c.Id_Persona = p.Id_Persona INNER JOIN " _
                           & " RECIBODINERO_ENCABEZADO r ON c.Id_Credito = r.IdCliente_Credito INNER JOIN " _
                           & " RECIBODINERO_DETALLE d ON r.Num_Recibo = d.Num_Recibo " _
                           & " WHERE d.Doc = " & numFactura & " AND d.Tipo = 1" _
                           & " ORDER BY r.Num_Recibo "
        Return DevolverResultados(sql)
    End Function

    Public Function ConsultarPor_IdPersonaInfo(ByVal idPersona As Integer) As DataTable
        Dim sql As String = "SELECT r.Num_Recibo, CONCAT(p.Nombre , ' ' , p.Apellido1 , ' ' , p.Apellido2) as Nombre, " _
                      & " r.Fecha, r.Monto, r.Anulado " _
                      & " FROM RECIBODINERO_ENCABEZADO r INNER JOIN CLIENTE_CREDITO c ON r.IdCliente_Credito = c.Id_Credito " _
                      & " INNER JOIN PERSONA p ON c.Id_Persona = p.Id_Persona WHERE p.Id_Persona = " & idPersona
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

    'Retorna un entero con el Id del recibo donde se encuentra una NC o un cero de no existir
    Public Function BuscarReciboPor_IdNC(ByVal idNc As Integer) As Integer
        Dim sql As String = " SELECT RECIBODINERO_DETALLE.Num_Recibo" _
                          & " FROM RECIBODINERO_ENCABEZADO" _
                          & " INNER JOIN RECIBODINERO_DETALLE ON RECIBODINERO_ENCABEZADO.Num_Recibo = RECIBODINERO_DETALLE.Num_Recibo" _
                          & " INNER JOIN CLIENTE_CREDITO ON RECIBODINERO_ENCABEZADO.IdCliente_Credito = CLIENTE_CREDITO.Id_Credito" _
                          & " INNER JOIN FACTURA_CREDITO ON CLIENTE_CREDITO.Id_Credito = FACTURA_CREDITO.Id_Credito" _
                          & " INNER JOIN NOTA_CREDITO ON FACTURA_CREDITO.Num_Factura = NOTA_CREDITO.Num_Factura" _
                          & " WHERE RECIBODINERO_DETALLE.Tipo = 4  AND NOTA_CREDITO.Id_NC = " & idNc
        Dim id As Integer = 0
        String.Format("SELECT RECIBODINERO_DETALLE.Num_Recibo " _
                      & "FROM RECIBODINERO_ENCABEZADO")
        Try
            Dim oDataTable = ConsultarDatos(sql)
            If oDataTable.Rows.Count > 0 Then
                id = oDataTable.Rows(0).Item(0)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando Id de un recibo pot Id_NC")
        End Try
        Return id
    End Function

    'Retorna un entero con el Id del recibo donde se encuentra un abono o un cero de no existir
    Function BuscarReciboPor_IdAbono(ByVal idAbono As Integer, ByVal numFactura As Integer) As Integer
        Dim sql As String = " SELECT RECIBODINERO_ENCABEZADO.Num_Recibo " _
                          & " FROM RECIBODINERO_DETALLE INNER JOIN " _
                          & " RECIBODINERO_ENCABEZADO ON RECIBODINERO_DETALLE.Num_Recibo = RECIBODINERO_ENCABEZADO.Num_Recibo " _
                          & " WHERE RECIBODINERO_DETALLE.Tipo = 3 AND RECIBODINERO_DETALLE.Doc = " & idAbono
        Dim id As Integer = 0
        Try
            Dim oDataTable = ConsultarDatos(sql)
            If oDataTable.Rows.Count > 0 Then
                id = oDataTable.Rows(0).Item(0)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando Id de un recibo por Id_Abono")
        End Try
        Return id
    End Function
End Class