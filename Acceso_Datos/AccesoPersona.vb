Imports MySql.Data.MySqlClient
Imports Entidades
Public Class AccesoPersona
    Inherits Transaccion

    Private ReadOnly _oAccesoInformacion As New AccesoInformacionPersonal

    Private Sub InicializarParametros(ByVal oComando As MySqlCommand, ByVal oPersona As Persona)
        oComando.Parameters.AddWithValue("@Nombre", oPersona.Nombre)
        oComando.Parameters.AddWithValue("@Apellido1", oPersona.PrimerApellido)
        oComando.Parameters.AddWithValue("@Apellido2", oPersona.SegundoApellido)
        oComando.Parameters.AddWithValue("@Cedula", oPersona.Cedula)
        oComando.Parameters.AddWithValue("@Id_Persona", oPersona.IdPersona)
        Return
    End Sub

    Public Function Insertar(ByVal oPersona As Persona) As Integer
        Const sql As String = "INSERT INTO PERSONA (Nombre,Apellido1,Apellido2,Cedula) VALUES (@Nombre, @Apellido1, @Apellido2, @Cedula); SELECT @@Identity"
        Dim oComando As New MySqlCommand(sql, Conexion)
        InicializarParametros(oComando, oPersona)

        Dim id As Integer
        Try
            id = InsertarDatosDevuelveId(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Insertando persona")
        End Try

        Return id
    End Function

    Public Sub Modificar(ByVal oPersona As Persona)
        Const sql As String = "UPDATE PERSONA SET Nombre = @Nombre, Apellido1 = @Apellido1, Apellido2 = @Apellido2, Cedula= @Cedula  WHERE Id_Persona = @Id_Persona"
        Dim oComando As New MySqlCommand(sql, Conexion)
        InicializarParametros(oComando, oPersona)

        Try
            ModificarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Modificando persona")
        End Try
    End Sub

    Public Sub Eliminar(ByVal idPersona As Integer)
        Dim sql As String = "DELETE FROM PERSONA WHERE Id_Persona = " & idPersona

        Try
            EliminarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Eliminando persona")
        End Try
    End Sub

    Public Function Consultar(ByVal nombre As String) As List(Of Persona)
        Dim sql As String = "SELECT * FROM PERSONA WHERE CONCAT(Nombre ,' ', Apellido1 ,' ' ,  Apellido2) LIKE '%" _
                            & nombre & "%' order by Nombre"
        Return DevolverListaPersonas(sql)
    End Function

    'Retorna una lista con todas las personas
    Public Function Consultar() As List(Of Persona)
        Const sql As String = "SELECT * FROM PERSONA ORDER BY Nombre"
        Return DevolverListaPersonas(sql)
    End Function

    Public Function Consultar(ByVal idPersona As Integer) As Persona
        Dim sql As String = "SELECT * FROM PERSONA WHERE Id_Persona = " & idPersona
        Dim oPersona As New Persona

        Try
            Dim oDataTable = ConsultarDatos(sql)
            If oDataTable.Rows.Count > 0 Then
                oPersona = LlenarPersona(oDataTable.Rows(0))
            Else
                oPersona.IdPersona = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando persona")
        End Try

        Return oPersona
    End Function

    Private Function LlenarPersona(ByVal row As DataRow) As Persona
        Dim oPersona As New Persona
        oPersona.IdPersona = row.Item(0)
        oPersona.Nombre = row.Item(1)
        oPersona.PrimerApellido = row.Item(2)
        oPersona.SegundoApellido = row.Item(3)
        oPersona.Cedula = row.Item(4)
        oPersona.OtraInformacion = _oAccesoInformacion.Consultar(oPersona.IdPersona)
        Return oPersona
    End Function

    Private Function DevolverListaPersonas(ByVal sql As String) As List(Of Persona)
        Dim oListaPersonas As New List(Of Persona)

        Try
            Dim oDataTable = ConsultarDatos(sql)

            For i = 0 To oDataTable.Rows.Count - 1
                oListaPersonas.Add(LlenarPersona(oDataTable.Rows(i)))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando lista de personas")
        End Try

        Return oListaPersonas
    End Function

    'Retorna el Id del ultimo cliente insertado
    Public Function ConsultarIdMaximo() As Integer
        Const sql As String = "SELECT Max(Id_Persona) FROM PERSONA"
        Try
            Dim oDataTable = ConsultarDatos(sql)
            Return oDataTable.Rows(0).Item(0)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando Id_Maximo")
        End Try

        Return 0
    End Function

    Public Function ConsultarTodosNombreConcatenado() As DataTable
        Const sql = "SELECT Id_Persona, CONCAT(Nombre ,' ', Apellido1 ,' ' ,  Apellido2) as nombre,Cedula FROM PERSONA ORDER BY nombre"
        Dim oDataTable As New DataTable

        Try
            oDataTable = ConsultarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando todas las personas con el nombre concatenado")
        End Try

        Return oDataTable
    End Function

    Public Function ConsultarPor_NombreConcatenado(ByVal nombre As String) As DataTable
        Dim sql As String = "SELECT Id_Persona, CONCAT(Nombre ,' ', Apellido1 ,' ' ,  Apellido2) as Nombre,Cedula FROM PERSONA WHERE CONCAT(Nombre ,' ', Apellido1 ,' ' ,  Apellido2) LIKE '%" _
                            & nombre & "%' order by Nombre"
        Dim oDataTable As New DataTable

        Try
            oDataTable = ConsultarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando todas las personas por nombre concatenado")
        End Try

        Return oDataTable
    End Function
End Class