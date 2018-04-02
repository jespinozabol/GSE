Imports MySql.Data.MySqlClient
Imports Entidades
Public Class AccesoFacturaCredito
    Inherits Transaccion

    Private Sub InicializarParametros(ByVal oComando As MySqlCommand, ByVal oFacturaCredito As FacturaCredito)
        oComando.Parameters.AddWithValue("@Num_Factura", oFacturaCredito.NumFactura)
        oComando.Parameters.AddWithValue("@Monto", oFacturaCredito.Monto)
        oComando.Parameters.AddWithValue("@Num_Dias", oFacturaCredito.NumDias)
        oComando.Parameters.AddWithValue("@Id_Credito", oFacturaCredito.IdCredito)
        oComando.Parameters.AddWithValue("@Fecha", oFacturaCredito.Fecha)
        oComando.Parameters.AddWithValue("@Estado", oFacturaCredito.Estado)
        Return
    End Sub

    Public Sub Insertar(ByVal oFacturaCredito As FacturaCredito)
        Const sql As String = "INSERT INTO FACTURA_CREDITO VALUES (@Num_Factura, @Monto, @Num_Dias,@Id_Credito,@Fecha, @Estado)"
        Dim oComando As New MySqlCommand(sql, Conexion)
        InicializarParametros(oComando, oFacturaCredito)

        Try
            InsertarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Insertando factura de crédito")
        End Try
    End Sub

    'Modifica el Estado de una factura de crédito 0- Pendiente, 1- Cancelada, 2-Anulada 
    Public Sub ModificarEstado(ByVal numFactura As Long, ByVal estado As FacturaCredito.ListaEstado)
        Dim sql As String = "UPDATE FACTURA_CREDITO SET Estado = " & estado & " WHERE Num_Factura = " & numFactura

        Try
            ModificarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Modificando el Estado de una factura de crédito")
        End Try
    End Sub

    Public Sub Eliminar(ByVal numFactura As Integer)
        Dim sql As String = "DELETE FROM FACTURA_CREDITO WHERE Num_Factura = " & numFactura

        Try
            EliminarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Eliminando factura de crédito")
        End Try
    End Sub

    'Retorna una lista de todas las facturas pendientes que tiene un cliente
    Public Function ConsultarPendientesPor_IdCredito(ByVal idCredito As Integer) As List(Of FacturaCredito)
        Dim sql As String = "SELECT * FROM FACTURA_CREDITO WHERE Estado = 0 AND Id_Credito = " & idCredito
        Return DevolverListaFacturas(sql)
    End Function

    'Retorna una lista de todas las facturas de crédito de un cliente
    Public Function ConsultarPor_IdCredito(ByVal idCredito As Integer) As List(Of FacturaCredito)
        Dim sql As String = " Select * From FACTURA_CREDITO WHERE Id_Credito = " & idCredito
        Return DevolverListaFacturas(sql)
    End Function

    Private Function DevolverListaFacturas(ByVal sql As String) As List(Of FacturaCredito)
        Dim oListaFacturasCredito As New List(Of FacturaCredito)

        Try
            Dim oDataTable = ConsultarDatos(sql)
            For i = 0 To oDataTable.Rows.Count - 1
                oListaFacturasCredito.Add(LlenarFacturaCredito(oDataTable.Rows(i)))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando facturas pendientes de un cliente")
        End Try

        Return oListaFacturasCredito
    End Function

    Public Function Consultar(ByVal numFactura As Integer) As FacturaCredito
        Dim sql As String = "SELECT * FROM FACTURA_CREDITO WHERE Num_Factura = " & numFactura
        Dim oFacturaCredito As New FacturaCredito

        Try
            Dim oDataTable = ConsultarDatos(sql)
            If oDataTable.Rows.Count > 0 Then
                oFacturaCredito = LlenarFacturaCredito(oDataTable.Rows(0))
            Else
                oFacturaCredito.NumFactura = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando factura por número de factura")
        End Try

        Return oFacturaCredito
    End Function

    'Retorna el número de facturas pendientes que tiene un cliente
    Public Function ConsultarNumeroFacturasPendientes(ByVal idCredito As Integer) As Integer
        Dim sql As String = "SELECT * FROM FACTURA_CREDITO WHERE Estado = 0 AND Id_Credito = " & idCredito

        Try
            Dim oDataTable = ConsultarDatos(sql)
            Return oDataTable.Rows.Count
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando número de facturas pendientes de un cliente")
        End Try
        Return 0
    End Function

    'Retorna la Fecha de creación de una factura
    Public Function ConsultarFechaPor_NumFactura(ByVal numFactura As Integer) As String
        Dim sql As String = "SELECT Fecha FROM FACTURA_CREDITO c WHERE Num_Factura = " & numFactura
        Try
            Dim oDataTable = ConsultarDatos(sql)
            Return oDataTable.Rows(0).Item(0)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando fecha de un factura crédito")
        End Try
        Return ""
    End Function

    'Traslada las facturas de crédito de un cliente a otro
    Public Sub TrasladarFacturas(ByVal idActual As Integer, ByVal idTrasladar As Integer)
        Dim sql As String = "UPDATE FACTURA_CREDITO SET Id_Credito = " & idActual & " WHERE Id_Credito = " & idTrasladar

        Try
            ModificarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Trasladando facturas de crédito a otro cliente")
        End Try
    End Sub

    Private Function LlenarFacturaCredito(ByVal row As DataRow) As FacturaCredito
        Dim oFacturaCredito As New FacturaCredito
        oFacturaCredito.NumFactura = row.Item(0)
        oFacturaCredito.Monto = row.Item(1)
        oFacturaCredito.NumDias = row.Item(2)
        oFacturaCredito.IdCredito = row.Item(3)
        oFacturaCredito.Fecha = row.Item(4)
        oFacturaCredito.Estado = row.Item(5)
        Return oFacturaCredito
    End Function
End Class