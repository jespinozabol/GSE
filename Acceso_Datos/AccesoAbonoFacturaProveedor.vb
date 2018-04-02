Imports MySql.Data.MySqlClient
Imports Entidades
Public Class AccesoAbonoFacturaProveedor
    Inherits Transaccion

    Private Sub InicializarParametros(ByRef oComando As MySqlCommand, ByVal oAbonoFacturaProveedor As AbonoFacturaProveedor)
        oComando.Parameters.AddWithValue("@Id_DocPorPagar", oAbonoFacturaProveedor.IdFacturaProveedor)
        oComando.Parameters.AddWithValue("@Id_Abono", oAbonoFacturaProveedor.IdAbono)
        oComando.Parameters.AddWithValue("@Fecha", oAbonoFacturaProveedor.Fecha)
        oComando.Parameters.AddWithValue("@Motivo", oAbonoFacturaProveedor.Motivo)
        oComando.Parameters.AddWithValue("@Estado", oAbonoFacturaProveedor.Estado)
        oComando.Parameters.AddWithValue("@Total", oAbonoFacturaProveedor.Monto)
        oComando.Parameters.AddWithValue("@Num_Abono", oAbonoFacturaProveedor.NumAbono)
        Return
    End Sub

    Public Function Insertar(ByVal oAbonoFacturaProveedor As AbonoFacturaProveedor) As Integer

        Const sql As String = "INSERT INTO ABONO_FACTURAPAGAR " _
                              & " (Id_DocPorPagar, Fecha, Motivo, Estado, Total, Num_Abono) " _
                              & " VALUES (@Id_DocPorPagar, @Fecha, @Motivo, @Estado, @Total, @Num_Abono); " _
                              & " SELECT @@Identity"
        Dim oComando As New MySqlCommand(sql, Conexion)
        InicializarParametros(oComando, oAbonoFacturaProveedor)

        Dim id As Integer = 0

        Try
            id = InsertarDatosDevuelveId(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Insertando abono")
        End Try

        Return id
    End Function

    'Modifica el Estado de un Abono a 0-Pendiente, 1-Aplicado, 2-Anulado por Id_Abono
    Public Sub ModificarEstadoPor_IdAbono(ByVal oAbonoFacturaProveedor As AbonoFacturaProveedor)
        Const sql As String = "UPDATE ABONO_FACTURAPAGAR SET Estado = @Estado WHERE Id_Abono = @Id_Abono"
        Dim oComando As New MySqlCommand(sql, Conexion)
        oComando.Parameters.AddWithValue("@Id_Abono", oAbonoFacturaProveedor.IdAbono)
        oComando.Parameters.AddWithValue("@Estado", oAbonoFacturaProveedor.Estado)

        Try
            ModificarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Actualizando estado de abono por Id_Abono")
        End Try
    End Sub

    'Modifica el Estado de los Abonos de una factura a 0-Pendiente, 1-Aplicado, 2-Anulado por Id_Factura_Proveedor
    Public Sub ModificarEstadoPorId_Factura_Proveedor(ByVal oAbonoFacturaProveedor As AbonoFacturaProveedor)
        Const sql As String = "UPDATE ABONO_FACTURAPAGAR SET Estado = @Estado WHERE Id_DocPorPagar = @Id_DocPorPagar"
        Dim oComando As New MySqlCommand(sql, Conexion)
        oComando.Parameters.AddWithValue("@Estado", oAbonoFacturaProveedor.Estado)
        oComando.Parameters.AddWithValue("@Id_DocPorPagar", oAbonoFacturaProveedor.IdFacturaProveedor)

        Try
            ModificarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Actualizando estado de abonos por Id_Factura_Proveedor")
        End Try
    End Sub

    Public Sub EliminarAbono(ByVal idAbono As Integer)
        Dim sql As String = "DELETE FROM ABONO_FACTURAPAGAR WHERE Id_Abono = " & idAbono

        Try
            EliminarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Eliminar abonos por Id_Abono")
        End Try
    End Sub

    'Retorna todos los abonos pendientes de una factura por proveedor
    Public Function ConsultarPor_IdFacturaProveedor(ByVal idFacturaProveedor As Integer) As List(Of AbonoFacturaProveedor)
        Dim sql As String = "SELECT * FROM ABONO_FACTURAPAGAR WHERE Estado = 0 AND Id_DocPorPagar = " & idFacturaProveedor
        Dim lista As New List(Of AbonoFacturaProveedor) 'Lista de Abonos que será devuelta.

        Try
            Dim oDataTable = ConsultarDatos(sql)

            For i = 0 To oDataTable.Rows.Count - 1
                lista.Add(LlenarAbono(oDataTable.Rows(i)))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando abonos por N° Factura")
        End Try

        Return lista
    End Function

    Public Function ConsultarAbonoPorId(ByVal idAbono As Integer) As AbonoFacturaProveedor
        Dim sql As String = "SELECT * FROM ABONO_FACTURAPAGAR WHERE Id_Abono = " & idAbono

        Try
            Dim oDataTable = ConsultarDatos(sql)

            If oDataTable.Rows.Count > 0 Then
                Return LlenarAbono(oDataTable.Rows(0))
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando abono por IdAbono")
        End Try

        Return New AbonoFacturaProveedor
    End Function

    Private Function LlenarAbono(ByVal row As DataRow) As AbonoFacturaProveedor
        Dim oAbonoFacturaProveedor As New AbonoFacturaProveedor
        oAbonoFacturaProveedor.IdFacturaProveedor = row.Item(0)
        oAbonoFacturaProveedor.IdAbono = row.Item(1)
        oAbonoFacturaProveedor.Fecha = row.Item(2)
        oAbonoFacturaProveedor.Motivo = row.Item(3)
        oAbonoFacturaProveedor.Estado = row.Item(4)
        oAbonoFacturaProveedor.Monto = row.Item(5)
        oAbonoFacturaProveedor.NumAbono = row.Item(6)
        Return oAbonoFacturaProveedor
    End Function
End Class