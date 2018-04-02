Imports MySql.Data.MySqlClient
Imports Entidades
Public Class AccesoEmpleadoOtro
    Inherits Transaccion

    Public Function Insertar(ByVal oEmpleadoOtro As EmpleadoOtro) As Integer
        Const sql As String = "INSERT INTO EMPLEADO_OTRO (Id_Persona,Tipo) VALUES (@Id_Persona, @Tipo); SELECT @@Identity"
        Dim oComando As New MySqlCommand(sql, Conexion)

        oComando.Parameters.AddWithValue("@Id_Persona", oEmpleadoOtro.IdPersona)
        oComando.Parameters.AddWithValue("@Tipo", oEmpleadoOtro.Tipo)

        Dim id As Integer
        Try
            id = InsertarDatosDevuelveId(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Insertando Empleado")
        End Try

        Return id
    End Function

    Public Sub Modificar(ByVal oEmpleadoOtro As EmpleadoOtro)
        'Se crea la sentencia SQL, Se crea un nuevo comando que recibe la sentencia y la conexion, Se inicializan los parametros
        Const sql As String = "UPDATE EMPLEADO_OTRO SET Tipo = @Tipo WHERE Id_Empleado_Otro = @Id_Empleado_Otro"
        Dim oComando As New MySqlCommand(sql, Conexion)

        oComando.Parameters.AddWithValue("@Id_Empleado_Otro", oEmpleadoOtro.IdEmpleado)
        oComando.Parameters.AddWithValue("@Tipo", oEmpleadoOtro.Tipo)

        Try
            ModificarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Modificando Empleado")
        End Try
    End Sub

    Public Function ConsultarPor_IdPersona(ByVal idPersona As Integer) As EmpleadoOtro
        Dim sql As String = "SELECT * FROM EMPLEADO_OTRO WHERE Id_Persona = " & idPersona
        Return DevuelveEmpleado(sql)
    End Function

    Public Function ConsultarPor_IdEmpleado(ByVal idEmpleado As Integer) As EmpleadoOtro
        Dim sql As String = "SELECT * FROM EMPLEADO_OTRO WHERE Id_Empleado_Otro = " & idEmpleado
        Return DevuelveEmpleado(sql)
    End Function

    Private Function DevuelveEmpleado(ByVal sql As String) As EmpleadoOtro
        Dim oEmpleadoOtro As New EmpleadoOtro
        Try
            Dim oDataTable = ConsultarDatos(sql)
            If oDataTable.Rows.Count > 0 Then
                oEmpleadoOtro = LlenarDatos(oDataTable.Rows(0))
            Else
                oEmpleadoOtro.IdEmpleado = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultado Empleado")
        End Try

        Return oEmpleadoOtro
    End Function

    Private Function LlenarDatos(ByVal row As DataRow) As EmpleadoOtro
        Dim oEmpleadoOtro As New EmpleadoOtro
        oEmpleadoOtro.IdEmpleado = row.Item(0)
        oEmpleadoOtro.IdPersona = row.Item(1)
        oEmpleadoOtro.Tipo = row.Item(2)
        Return oEmpleadoOtro
    End Function

    'Retorna una lista con todos los empleados existentes.
    Public Function Consultar() As List(Of EmpleadoOtro)
        Const sql As String = "SELECT * FROM EMPLEADO_OTRO"
        Dim oListaEmpleados As New List(Of EmpleadoOtro)

        Try
            Dim oDataTable = ConsultarDatos(sql)
            For i = 0 To oDataTable.Rows.Count - 1
                oListaEmpleados.Add(LlenarDatos(oDataTable.Rows(i)))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultado lista de todos los empleados")
        End Try

        Return oListaEmpleados
    End Function

    'Traslada los datos del empleado de una persona a otra.
    Public Sub TrasladarEmpleado(ByVal idActual As Integer, ByVal idTrasladar As Integer)
        Dim sql As String = "UPDATE EMPLEADO_OTRO SET Id_Persona = " & idActual & " WHERE Id_Persona = " & idTrasladar

        Try
            ModificarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Trasladando Empleado")
        End Try
    End Sub

End Class
