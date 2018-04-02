Imports MySql.Data.MySqlClient

<Serializable()>
Public Class Transaccion
    Inherits Conexion

    Public Sub InsertarDatos(ByVal oComando As MySqlCommand)
        AbrirConexion()
        oComando.ExecuteNonQuery()
        CerrarConexion()
    End Sub

    Public Function InsertarDatosDevuelveId(ByVal oComando As MySqlCommand) As Integer
        AbrirConexion()
        Dim id = oComando.ExecuteScalar()
        CerrarConexion()
        Return id
    End Function

    Public Function ModificarDatos(ByVal oComando As MySqlCommand) As Integer
        AbrirConexion()
        Dim id = oComando.ExecuteNonQuery()
        CerrarConexion()
        Return id
    End Function

    Public Sub ModificarDatos(ByVal sql As String)
        Dim oComando As New MySqlCommand(sql, Conexion)
        AbrirConexion()
        oComando.ExecuteNonQuery()
        CerrarConexion()
    End Sub

    Public Sub EliminarDatos(ByVal sql As String)
        Dim oComando As New MySqlCommand(sql, Conexion)
        AbrirConexion()
        oComando.ExecuteNonQuery()
        CerrarConexion()
    End Sub

    Public Function ConsultarDatos(ByVal sql As String) As DataTable
        'Se abre la conexion se ejecuta el comando y luego se cierra la conexion, 
        'y retorna una tabla con los resultado
        Dim oDataAdapter As New MySqlDataAdapter(sql, Conexion)
        Dim oDataTable As New DataTable
        AbrirConexion()
        oDataAdapter.Fill(oDataTable)
        CerrarConexion()
        Return oDataTable
    End Function

End Class
