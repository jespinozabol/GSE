Imports MySql.Data.MySqlClient
Imports Entidades
Public Class AccesoAgente
    Inherits Transaccion

    Private Function InicializarParametros(ByRef oComando As MySqlCommand, ByVal oAgente As Agente) As MySqlCommand
        oComando.Parameters.AddWithValue("@Id_Proveedor", oAgente.IdProveedor)
        oComando.Parameters.AddWithValue("@Id_Agente", oAgente.IdAgente)
        oComando.Parameters.AddWithValue("@Nombre", oAgente.Nombre)
        oComando.Parameters.AddWithValue("@Telefono1", oAgente.Telefono1)
        oComando.Parameters.AddWithValue("@Telefono2", oAgente.Telefono2)
        oComando.Parameters.AddWithValue("@Fax", oAgente.Fax)
        oComando.Parameters.AddWithValue("@Correo", oAgente.Correo)
        Return oComando
    End Function

    Public Sub Insertar(ByVal oAgente As Agente)
        Const sql As String = "INSERT INTO AGENTE_PROVEEDOR (Id_Proveedor,Nombre,Telefono1,Telefono2,Fax,Correo) " _
                              & " VALUES (@Id_Proveedor, @Nombre, @Telefono1, @Telefono2, @Fax, @Correo)"
        Dim oComando As New MySqlCommand(sql, Conexion)
        InicializarParametros(oComando, oAgente)

        Try
            InsertarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Insertando Agente")
        End Try
    End Sub

    Public Sub Modificar(ByVal oAgente As Agente)
        Const sql As String = "UPDATE AGENTE_PROVEEDOR SET Nombre = @Nombre, Telefono1=@Telefono1, " _
                              & " Telefono2 = @Telefono2, Fax = @Fax, Correo = @Correo WHERE Id_Agente = @Id_Agente"
        Dim oComando As New MySqlCommand(sql, Conexion)
        oComando = InicializarParametros(oComando, oAgente)

        Try
            ModificarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Modificando Agente")
        End Try
    End Sub

    Public Sub Eliminar(ByVal idAgente As UInteger)
        Dim sql As String = "DELETE FROM AGENTE_PROVEEDOR WHERE Id_Agente = " & idAgente

        Try
            EliminarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Eliminando Agente")
        End Try
    End Sub

    'Consulta todos los agentes de un proveedor, por Id_Proveedor. Retorna una lista de Agentes.
    Public Function ConsultarPor_IdProveedor(ByVal idProveedor As Integer) As List(Of Agente)
        Dim sql As String = "SELECT * FROM AGENTE_PROVEEDOR WHERE Id_Proveedor = " & idProveedor
        Dim oLista As New List(Of Agente)

        Try
            Dim oDataTable = ConsultarDatos(sql)

            For i As Integer = 0 To oDataTable.Rows.Count - 1
                oLista.Add(LlenarAgente(oDataTable.Rows(i)))
            Next i
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando agentes por Id_Proveedor")
        End Try

        Return oLista
    End Function

    Private Function LlenarAgente(ByVal row As DataRow) As Agente
        Dim oAgente As New Agente
        oAgente.IdAgente = row.Item(0)
        oAgente.IdProveedor = row.Item(1)
        oAgente.Nombre = row.Item(2)
        oAgente.Telefono1 = row.Item(3)
        oAgente.Telefono2 = row.Item(4)
        oAgente.Fax = row.Item(5)
        oAgente.Correo = row.Item(6)
        Return oAgente
    End Function
End Class