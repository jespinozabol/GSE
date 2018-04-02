Imports Entidades
Imports MySql.Data.MySqlClient

Public Class AccesoDevolucion
    Inherits Transaccion

    Private Shared Sub InicializarParametros(ByVal oComando As MySqlCommand, ByVal oDevolucion As Devolucion)
        oComando.Parameters.AddWithValue("@IdDevolucion", oDevolucion.IdDevolucion)
        oComando.Parameters.AddWithValue("@IdProveedor", oDevolucion.IdProveedor)
        oComando.Parameters.AddWithValue("@Factura", oDevolucion.Factura)
        oComando.Parameters.AddWithValue("@Fecha", oDevolucion.Fecha)
        oComando.Parameters.AddWithValue("@Boleta", oDevolucion.Boleta)
        oComando.Parameters.AddWithValue("@Cantidad", oDevolucion.Cantidad)
        oComando.Parameters.AddWithValue("@Producto", oDevolucion.Producto)
        oComando.Parameters.AddWithValue("@Codigo", oDevolucion.Codigo)
        oComando.Parameters.AddWithValue("@Motivo", oDevolucion.Motivo)
        oComando.Parameters.AddWithValue("@Observaciones", oDevolucion.Observaciones)
        Return
    End Sub

    Public Sub Insertar(ByVal oDevolucion As Devolucion)
        Const sql As String = "INSERT INTO DEVOLUCION (IdProveedor,Factura,Fecha,Boleta,Cantidad,Producto,Codigo,Motivo,Observaciones) " _
                              & "VALUES (@IdProveedor,@Factura,@Fecha,@Boleta,@Cantidad,@Producto,@Codigo,@Motivo,@Observaciones)"
        Dim oComando As New MySqlCommand(sql, Conexion)
        InicializarParametros(oComando, oDevolucion)

        Try
            InsertarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Insertando devolución")
        End Try
    End Sub

    Public Sub Modificar(ByVal oDevolucion As Devolucion)
        Const sql As String = "UPDATE DEVOLUCION SET IdProveedor = @IdProveedor,Factura=@Factura,Fecha=@Fecha,Boleta=@Boleta, " _
                              & " Cantidad=@Cantidad,Producto=@Producto,Codigo=@Codigo, Observaciones=@Observaciones, Motivo=@Motivo  WHERE IdDevolucion = @IdDevolucion"
        Dim oComando As New MySqlCommand(sql, Conexion)
        InicializarParametros(oComando, oDevolucion)

        Try
            ModificarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Modificando devolución")
        End Try
    End Sub

    Public Sub Eliminar(ByVal idDevolucion As UShort)
        Dim sql As String = "DELETE FROM DEVOLUCION WHERE IdDevolucion = " & idDevolucion

        Try
            EliminarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Eliminando devolución")
        End Try
    End Sub

    Public Function Consultar() As List(Of Devolucion)
        Const sql As String = "SELECT * FROM DEVOLUCION"
        Dim listaDevoluciones As New List(Of Devolucion)
        Try
            Dim oDataTable = ConsultarDatos(sql)
            For i = 0 To oDataTable.Rows.Count - 1
                listaDevoluciones.Add(LlenarDevolucion(oDataTable.Rows(i)))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando las devoluciones por proveedor")
        End Try
        Return listaDevoluciones
    End Function

    Private Function LlenarDevolucion(ByVal row As DataRow) As Devolucion
        Dim oDevolucion As New Devolucion
        oDevolucion.IdDevolucion = row.Item(0)
        oDevolucion.IdProveedor = row.Item(1)
        oDevolucion.Factura = row.Item(2)
        oDevolucion.Fecha = row.Item(3)
        oDevolucion.Boleta = row.Item(4)
        oDevolucion.Cantidad = row.Item(5)
        oDevolucion.Producto = row.Item(6)
        oDevolucion.Codigo = row.Item(7)
        oDevolucion.Motivo = row.Item(8)
        oDevolucion.Observaciones = row.Item(9)
        Return oDevolucion
    End Function

    '**********************************************PAQUETES ******************************************************

    Private Shared Sub InicializarParametrosPaquete(ByVal oComando As MySqlCommand, ByVal paquete As Paquete)
        oComando.Parameters.AddWithValue("@IdPaquete", paquete.IdPaquete)
        oComando.Parameters.AddWithValue("@IdProveedor", paquete.IdProveedor)
        Return
    End Sub

    Public Sub InsertarPaquete(ByVal paquete As Paquete)
        Const sql As String = "INSERT INTO PAQUETE (IdPaquete,IdProveedor) " _
                              & "VALUES ( @IdPaquete, @IdProveedor)"
        Dim oComando As New MySqlCommand(sql, Conexion)
        InicializarParametrosPaquete(oComando, paquete)

        Try
            InsertarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Insertando paquete")
        End Try
    End Sub

    Public Sub ModificarPaquete(ByVal paquete As Paquete)
        Const sql As String = "UPDATE PAQUETE SET IdProveedor = @IdProveedor, IdPaquete = @IdPaquete WHERE IdPaquete = @IdPaquete"
        Dim oComando As New MySqlCommand(sql, Conexion)
        InicializarParametrosPaquete(oComando, paquete)

        Try
            ModificarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Modificando paquete")
        End Try
    End Sub

    Public Sub EliminarPaquete(ByVal idPaquete As Integer)
        Dim sql As String = "DELETE FROM PAQUETE WHERE IdPaquete = " & idPaquete

        Try
            EliminarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Eliminando paquete")
        End Try
    End Sub

    Public Function ConsultarPaquetes() As List(Of Paquete)
        Const sql As String = "SELECT Paquete.*, Proveedor.Nombre FROM Paquete " _
            & " INNER JOIN Proveedor ON Paquete.IdProveedor = Proveedor.Id_Proveedor"
        Dim listaPaquetes As New List(Of Paquete)
        Try
            Dim oDataTable = ConsultarDatos(sql)
            For i = 0 To oDataTable.Rows.Count - 1
                listaPaquetes.Add(LlenarPaquete(oDataTable.Rows(i)))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando los paquetes")
        End Try
        Return listaPaquetes
    End Function

    Private Function LlenarPaquete(ByVal row As DataRow) As Paquete
        Dim oDevolucion As New Paquete
        oDevolucion.IdPaquete = row.Item(0)
        oDevolucion.IdProveedor = row.Item(1)
        oDevolucion.NombreProveedor = row.Item(2)
        Return oDevolucion
    End Function


    '**********************************************DEVOLUCIONES POR PAQUETES ******************************************************

    Private Shared Sub InicializarParametrosDevolucionesPaquete(ByVal oComando As MySqlCommand, ByVal devolucionPaquete As DevolucionPorPaquete)
        oComando.Parameters.AddWithValue("@IdDevolucion", devolucionPaquete.IdDevolucion)
        oComando.Parameters.AddWithValue("@IdPaquete", devolucionPaquete.IdPaquete)
        Return
    End Sub

    Public Sub InsertarDevPorPaq(ByVal devolucionPaquete As DevolucionPorPaquete)
        Const sql As String = "INSERT INTO DEVOLUCIONPORPAQUETE (IdDevolucion,IdPaquete) " _
                              & "VALUES ( @IdDevolucion,@IdPaquete)"
        Dim oComando As New MySqlCommand(sql, Conexion)
        InicializarParametrosDevolucionesPaquete(oComando, devolucionPaquete)

        Try
            InsertarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Insertando devolución por paquete")
        End Try
    End Sub

    Public Sub ModificarDevPorPaq(ByVal devolucionPaquete As DevolucionPorPaquete)
        Const sql As String = "UPDATE DEVOLUCIONPORPAQUETE SET IdDevolucion = @IdDevolucion, IdPaquete = @IdPaquete WHERE IdDevolucion = @IdDevolucion"
        Dim oComando As New MySqlCommand(sql, Conexion)
        InicializarParametrosDevolucionesPaquete(oComando, devolucionPaquete)

        Try
            ModificarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Modificando devolución por paquete")
        End Try
    End Sub

    Public Sub EliminarDevPorPaq(ByVal idDevolucion As Integer)
        Dim sql As String = "DELETE FROM DEVOLUCIONPORPAQUETE WHERE IdDevolucion = " & idDevolucion

        Try
            EliminarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Eliminando devolución por paquete")
        End Try
    End Sub

    Public Function ConsultarDevPorPaq() As List(Of DevolucionPorPaquete)
        Const sql As String = "SELECT * FROM DEVOLUCIONPORPAQUETE"
        Dim listaPaquetes As New List(Of DevolucionPorPaquete)
        Try
            Dim oDataTable = ConsultarDatos(sql)
            For i = 0 To oDataTable.Rows.Count - 1
                listaPaquetes.Add(LlenarDevolucionPorPaquete(oDataTable.Rows(i)))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando las  devoluciónes por paquete")
        End Try
        Return listaPaquetes
    End Function

    Private Function LlenarDevolucionPorPaquete(ByVal row As DataRow) As DevolucionPorPaquete
        Dim oDevolucion As New DevolucionPorPaquete
        oDevolucion.IdDevolucion = row.Item(0)
        oDevolucion.IdPaquete = row.Item(1)
        Return oDevolucion
    End Function
End Class
