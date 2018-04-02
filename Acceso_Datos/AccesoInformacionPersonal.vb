Imports MySql.Data.MySqlClient
Imports Entidades
Public Class AccesoInformacionPersonal
    Inherits Transaccion

    Private Function InicializarParametros(ByVal oComando As MySqlCommand, ByVal oInformacionPersonal As InformacionPersonal) As MySqlCommand
        oComando.Parameters.AddWithValue("@Id_Persona", oInformacionPersonal.IdPersona)
        oComando.Parameters.AddWithValue("@Direccion", oInformacionPersonal.Direccion)
        oComando.Parameters.AddWithValue("@Observaciones", oInformacionPersonal.Observaciones)
        oComando.Parameters.AddWithValue("@TelefonoPrincipal", oInformacionPersonal.TelefonoPrincipal)
        oComando.Parameters.AddWithValue("@OtroTelefono", oInformacionPersonal.OtroTelefono)
        oComando.Parameters.AddWithValue("@FaxPrincipal", oInformacionPersonal.FaxPrincipal)
        oComando.Parameters.AddWithValue("@Email", oInformacionPersonal.Email)
        oComando.Parameters.AddWithValue("@SitioWeb", oInformacionPersonal.SitioWeb)
        Return oComando
    End Function

    Public Sub Insertar(ByVal oInformacionPersonal As InformacionPersonal)
        Const sql As String = "INSERT INTO INFORMACION_PERSONAL VALUES (@Id_Persona, @Direccion, " _
                    & " @Observaciones, @TelefonoPrincipal, @OtroTelefono, @FaxPrincipal, @Email, @SitioWeb) "
        Dim oComando As New MySqlCommand(sql, Conexion)
        oComando = InicializarParametros(oComando, oInformacionPersonal)

        Try
            InsertarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Insertando Información Personal")
        End Try
    End Sub

    Public Function Modificar(ByVal oInformacionPersonal As InformacionPersonal) As Integer
        Const sql As String = "UPDATE INFORMACION_PERSONAL SET Direccion=@Direccion, Observaciones = @Observaciones, " _
                            & " TelefonoPrincipal = @TelefonoPrincipal, OtroTelefono = @OtroTelefono, FaxPrincipal = @FaxPrincipal, Email = @Email, SitioWeb = @SitioWeb " _
                            & " WHERE Id_Persona = @Id_Persona"
        Dim oComando As New MySqlCommand(sql, Conexion)
        oComando = InicializarParametros(oComando, oInformacionPersonal)

        Dim existe As Integer
        Try
            existe = ModificarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Modificando Información Personal")
        End Try

        Return existe
    End Function

    Public Sub Eliminar(ByVal idPersona As Integer)
        Dim sql As String = "DELETE FROM INFORMACION_PERSONAL WHERE Id_Persona = " & idPersona

        Try
            EliminarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Eliminando Información Personal")
        End Try
    End Sub

    Public Function Consultar() As InformacionPersonal
        Return Consultar(Nothing)
    End Function

    Public Function Consultar(ByVal idPersona As String) As InformacionPersonal
        Dim sql As String = "SELECT * FROM INFORMACION_PERSONAL WHERE Id_Persona = " & idPersona
        Dim oInformacionPersonal As New InformacionPersonal

        Try
            Dim oDataTable = ConsultarDatos(sql)
            If oDataTable.Rows.Count > 0 Then
                oInformacionPersonal.IdPersona = oDataTable.Rows(0).Item(0)
                oInformacionPersonal.Direccion = oDataTable.Rows(0).Item(1)
                oInformacionPersonal.Observaciones = oDataTable.Rows(0).Item(2)
                oInformacionPersonal.TelefonoPrincipal = oDataTable.Rows(0).Item(3)
                oInformacionPersonal.OtroTelefono = oDataTable.Rows(0).Item(4)
                oInformacionPersonal.FaxPrincipal = oDataTable.Rows(0).Item(5)
                oInformacionPersonal.Email = oDataTable.Rows(0).Item(6)
                oInformacionPersonal.SitioWeb = oDataTable.Rows(0).Item(7)
            Else
                oInformacionPersonal.IdPersona = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando Información Personal")
        End Try

        Return oInformacionPersonal
    End Function

    '***********************************************TELEFONOS*****************************************************
    Private Function InicializarParametrosTelefonos(ByVal oComando As MySqlCommand, ByVal oTelefono As Telefonos_Cliente) As MySqlCommand
        oComando.Parameters.AddWithValue("@Id_Persona", oTelefono.Id_Persona)
        oComando.Parameters.AddWithValue("@Prioridad", oTelefono.Prioridad)
        oComando.Parameters.AddWithValue("@Telefono", oTelefono.Telefono)
        oComando.Parameters.AddWithValue("@Detalle", oTelefono.Detalle)
        Return oComando
    End Function

    Public Sub InsertarTelefono(ByVal oTelefono As Telefonos_Cliente)
        Const sql As String = "INSERT INTO TELEFONOS_CLIENTE VALUES (@Id_Persona, @Prioridad, @Telefono, @Detalle)"
        Dim oComando As New MySqlCommand(sql, Conexion)
        oComando = InicializarParametrosTelefonos(oComando, oTelefono)

        Try
            InsertarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Insertando Teléfono cliente")
        End Try
    End Sub

    Public Sub ModificarTelefono(ByVal oTelefono As Telefonos_Cliente)
        Const sql As String = "UPDATE TELEFONOS_CLIENTE SET Telefono=@Telefono, Detalle= @Detalle WHERE (Id_Persona = @Id_Persona AND Prioridad = @Prioridad)"
        Dim oComando As New MySqlCommand(sql, Conexion)
        oComando = InicializarParametrosTelefonos(oComando, oTelefono)

        Try
            AbrirConexion()
            Dim esta = oComando.ExecuteNonQuery()
            If esta = 0 Then
                InsertarTelefono(oTelefono)
            End If
            CerrarConexion()
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Modificando Teléfono cliente")
        End Try
    End Sub

    Public Sub EliminarTelefonos(ByVal idPersona As Integer)
        Dim sql As String = "DELETE FROM TELEFONOS_CLIENTE WHERE Id_Persona = " & idPersona

        Try
            EliminarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Eliminando Teléfono cliente")
        End Try
    End Sub

    Public Function ConsultarTelefonos(ByVal idPersona As String) As List(Of Telefonos_Cliente)
        Dim sql As String = "SELECT * FROM TELEFONOS_CLIENTE WHERE Id_Persona = " & idPersona & " ORDER BY Prioridad"
        Dim listaTelefonos As New List(Of Telefonos_Cliente)

        Try
            Dim oDataTable = ConsultarDatos(sql)

            For i = 0 To oDataTable.Rows.Count - 1
                Dim telefono As New Telefonos_Cliente
                telefono.Id_Persona = oDataTable.Rows(i).Item(0)
                telefono.Prioridad = oDataTable.Rows(i).Item(1)
                telefono.Telefono = oDataTable.Rows(i).Item(2)
                telefono.Detalle = oDataTable.Rows(i).Item(3)
                listaTelefonos.Add(telefono)
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando Teléfonos del cliente")
        End Try

        Return listaTelefonos
    End Function

End Class

