Imports MySql.Data.MySqlClient
Imports Entidades
Public Class AccesoEncargadoProveedor
    Inherits Transaccion

    Private Function InicializarParametros(ByVal oComando As MySqlCommand, ByVal oEncargado As Encargado) As MySqlCommand
        oComando.Parameters.AddWithValue("@Id_Encargado", oEncargado.IdEncargado)
        oComando.Parameters.AddWithValue("@Id_Proveedor", oEncargado.IdProveedor)
        oComando.Parameters.AddWithValue("@Nombre", oEncargado.Nombre)
        oComando.Parameters.AddWithValue("@Servicio", oEncargado.Servicio)
        oComando.Parameters.AddWithValue("@Telefono1", oEncargado.Telefono1)
        oComando.Parameters.AddWithValue("@Telefono2", oEncargado.Telefono2)
        oComando.Parameters.AddWithValue("@Ext1", oEncargado.Ext1)
        oComando.Parameters.AddWithValue("@Ext2", oEncargado.Ext2)
        oComando.Parameters.AddWithValue("@Fax", oEncargado.Fax)
        oComando.Parameters.AddWithValue("@Correo", oEncargado.Correo)

        Return oComando
    End Function

    Public Sub Insertar(ByVal oEncargado As Encargado)
        Const sql As String = "INSERT INTO ENCARGADO_PROVEEDOR (Id_Proveedor,Nombre,Servicio,Telefono1,Telefono2,Ext1,Ext2,Fax,Correo) VALUES (@Id_Proveedor, @Nombre, @Servicio,@Telefono1, @Telefono2, @Ext1, @Ext2, @Fax, @Correo)"
        Dim oComando As New MySqlCommand(sql, Conexion)
        oComando = InicializarParametros(oComando, oEncargado)

        Try
            InsertarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Insertando encargado proveedor")
        End Try
    End Sub

    Public Sub Modificar(ByVal oEncargado As Encargado)
        Const sql As String = "UPDATE ENCARGADO_PROVEEDOR SET Nombre = @Nombre, Servicio = @Servicio,Telefono1=@Telefono1, Telefono2= @Telefono2, Ext1= @Ext1, Ext2=@Ext2, Fax=@Fax, Correo=@Correo WHERE Id_Encargado = @Id_Encargado"
        Dim oComando As New MySqlCommand(sql, Conexion)
        oComando = InicializarParametros(oComando, oEncargado)

        Try
            ModificarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Modificando encargado proveedor")
        End Try
    End Sub

    Public Sub Eliminar(ByVal idEncargado As UShort)
        Dim sql As String = "DELETE FROM ENCARGADO_PROVEEDOR WHERE Id_Encargado = " & idEncargado

        Try
            EliminarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Eliminando encargado proveedor")
        End Try
    End Sub

    'Retorna una lista con todos los encargados de un proveedor
    Public Function ConsultarPor_IdProveedor(ByVal idProveedor As Integer) As List(Of Encargado)
        Dim sql As String = "SELECT * FROM ENCARGADO_PROVEEDOR WHERE Id_Proveedor = " & idProveedor
        Dim oLista As New List(Of Encargado)

        Try
            Dim oDataTable = ConsultarDatos(sql)

            For i As Integer = 0 To oDataTable.Rows.Count - 1
                Dim oEncargado As New Encargado
                oEncargado.IdEncargado = oDataTable.Rows(i).Item(0)
                oEncargado.IdProveedor = oDataTable.Rows(i).Item(1)
                oEncargado.Nombre = oDataTable.Rows(i).Item(2)
                oEncargado.Servicio = oDataTable.Rows(i).Item(3)
                oEncargado.Telefono1 = oDataTable.Rows(i).Item(4)
                oEncargado.Telefono2 = oDataTable.Rows(i).Item(5)
                oEncargado.Ext1 = oDataTable.Rows(i).Item(6)
                oEncargado.Ext2 = oDataTable.Rows(i).Item(7)
                oEncargado.Fax = oDataTable.Rows(i).Item(8)
                oEncargado.Correo = oDataTable.Rows(i).Item(9)
                oLista.Add(oEncargado)
            Next i
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando encargados de un proveedor")
        End Try

        Return oLista
    End Function
End Class

