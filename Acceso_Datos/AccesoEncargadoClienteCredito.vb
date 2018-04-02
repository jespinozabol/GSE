Imports MySql.Data.MySqlClient
Imports Entidades
Public Class AccesoEncargadoClienteCredito
    Inherits Transaccion

    Private Function InicializarParametros(ByVal oComando As MySqlCommand, ByVal oEncargado As EncargadoClienteCredito) As MySqlCommand
        oComando.Parameters.AddWithValue("@Id_Encargado", oEncargado.IdEncargado)
        oComando.Parameters.AddWithValue("@Id_ClienteCredito", oEncargado.IdClienteCredito)
        oComando.Parameters.AddWithValue("@Nombre", oEncargado.Nombre)
        oComando.Parameters.AddWithValue("@Servicio", oEncargado.Servicio)
        oComando.Parameters.AddWithValue("@Telefono1", oEncargado.Telefono1)
        oComando.Parameters.AddWithValue("@Telefono2", oEncargado.Telefono2)
        oComando.Parameters.AddWithValue("@Ext1", oEncargado.Ext1)
        oComando.Parameters.AddWithValue("@Fax", oEncargado.Fax)
        oComando.Parameters.AddWithValue("@Correo", oEncargado.Correo)

        Return oComando
    End Function

    Public Sub Insertar(ByVal oEncargado As EncargadoClienteCredito)
        Const sql As String = "INSERT INTO ENCARGADO_CLIENTE_CREDITO (Id_ClienteCredito,Nombre,Servicio,Telefono1,Telefono2,Ext1,Fax,Correo) VALUES (@Id_ClienteCredito, @Nombre, @Servicio,@Telefono1, @Telefono2, @Ext1, @Fax, @Correo)"
        Dim oComando As New MySqlCommand(sql, Conexion)
        oComando = InicializarParametros(oComando, oEncargado)

        Try
            InsertarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Insertando encargado cliente credito")
        End Try
    End Sub

    Public Sub Modificar(ByVal oEncargado As EncargadoClienteCredito)
        Const sql As String = "UPDATE ENCARGADO_CLIENTE_CREDITO SET Nombre = @Nombre, Servicio = @Servicio,Telefono1=@Telefono1, Telefono2= @Telefono2, Ext1= @Ext1, Fax=@Fax, Correo=@Correo WHERE Id_Encargado = @Id_Encargado"
        Dim oComando As New MySqlCommand(sql, Conexion)
        oComando = InicializarParametros(oComando, oEncargado)

        Try
            ModificarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Modificando encargado cliente credito")
        End Try
    End Sub

    Public Sub Eliminar(ByVal idEncargado As UShort)
        Dim sql As String = "DELETE FROM ENCARGADO_CLIENTE_CREDITO WHERE Id_Encargado = " & idEncargado

        Try
            EliminarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Eliminando encargado cliente credito")
        End Try
    End Sub

    'Retorna una lista con todos los encargados de un cliente credito
    Public Function ConsultarPor_IdClienteCredito(ByVal idClienteCredito As Integer) As List(Of EncargadoClienteCredito)
        Dim sql As String = "SELECT * FROM ENCARGADO_CLIENTE_CREDITO WHERE Id_ClienteCredito = " & idClienteCredito
        Dim oLista As New List(Of EncargadoClienteCredito)

        Try
            Dim oDataTable = ConsultarDatos(sql)

            For i As Integer = 0 To oDataTable.Rows.Count - 1
                oLista.Add(LlenarEncargado(oDataTable.Rows(i)))
            Next i
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando encargados de un cliente credito")
        End Try

        Return oLista
    End Function

    Public Function Consultar(ByVal idEncargado As Integer) As EncargadoClienteCredito
        Dim sql As String = "SELECT * FROM ENCARGADO_CLIENTE_CREDITO WHERE Id_Encargado = " & idEncargado
        Dim encargado As New EncargadoClienteCredito

        Try
            Dim oDataTable = ConsultarDatos(sql)

            'Devuelve el encargado o el objeto vació con un Id=0
            If oDataTable.Rows.Count > 0 Then
                encargado = LlenarEncargado(oDataTable.Rows(0))
            Else
                encargado.IdEncargado = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando encargado credito")
        End Try

        Return encargado
    End Function

    Sub EliminarPorCliente(ByVal idCredito As Integer)
        Dim sql As String = "DELETE FROM ENCARGADO_CLIENTE_CREDITO WHERE Id_ClienetCredito = " & idCredito

        Try
            EliminarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Eliminando encargados cliente credito")
        End Try
    End Sub

    'Traslada los encargados de un cliente a otro
    Public Sub TrasladarEncargados(ByVal idActual As Integer, ByVal idTrasladar As Integer)
        Dim sql As String = "UPDATE ENCARGADO_CLIENTE_CREDITO SET Id_ClienteCredito = " & idActual & " WHERE Id_ClienteCredito = " & idTrasladar

        Try
            ModificarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Error trasladando los encargados de un cliente credito")
        End Try
    End Sub

    Private Function LlenarEncargado(ByVal row As DataRow) As EncargadoClienteCredito
        Dim oEncargado As New EncargadoClienteCredito
        oEncargado.IdEncargado = row.Item(0)
        oEncargado.IdClienteCredito = row.Item(1)
        oEncargado.Nombre = row.Item(2)
        oEncargado.Servicio = row.Item(3)
        oEncargado.Telefono1 = row.Item(4)
        oEncargado.Telefono2 = row.Item(5)
        oEncargado.Ext1 = row.Item(6)
        oEncargado.Fax = row.Item(7)
        oEncargado.Correo = row.Item(8)
        Return oEncargado
    End Function

    Sub TrasladarEncargado(idActual As Integer, idEncargado As Integer)
        Dim sql As String = "UPDATE ENCARGADO_CLIENTE_CREDITO SET Id_ClienteCredito = " & idActual & " WHERE Id_Encargado = " & idEncargado

        Try
            ModificarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Error trasladando el encargado de un cliente credito")
        End Try
    End Sub

End Class
