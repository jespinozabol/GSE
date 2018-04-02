Imports MySql.Data.MySqlClient
Imports Entidades
Public Class AccesoClienteCredito
    Inherits Transaccion

    Private Function InicializarParametros(ByVal oComando As MySqlCommand, ByVal oClienteCredito As ClienteCredito) As MySqlCommand
        oComando.Parameters.AddWithValue("@Id_Persona", oClienteCredito.IdPersona)
        oComando.Parameters.AddWithValue("@Id_Credito", oClienteCredito.IdCredito)
        oComando.Parameters.AddWithValue("@Limite", oClienteCredito.Limite)
        oComando.Parameters.AddWithValue("@Estado", oClienteCredito.Estado)
        oComando.Parameters.AddWithValue("@Tipo", oClienteCredito.Tipo)
        oComando.Parameters.AddWithValue("@Total_Creditos", oClienteCredito.TotalCreditos)
        oComando.Parameters.AddWithValue("@Ente_Fisico", oClienteCredito.EnteFisico)
        oComando.Parameters.AddWithValue("@Dias_Atrasado", oClienteCredito.DiasAtrasado)
        oComando.Parameters.AddWithValue("@Total_Atrasado", oClienteCredito.TotalAtrasado)
        oComando.Parameters.AddWithValue("@Nombre_Real", oClienteCredito.NombreReal)
        oComando.Parameters.AddWithValue("@Fecha_Creacion", oClienteCredito.FechaCreacion)
        oComando.Parameters.AddWithValue("@Bloqueo", False)
        oComando.Parameters.AddWithValue("@IncluirEnCobro", oClienteCredito.IncluirEnCobro)
        Return oComando
    End Function

    Public Function Insertar(ByVal oClienteCredito As ClienteCredito) As Integer
        Const sql As String = "INSERT INTO CLIENTE_CREDITO (Id_Persona,Limite,Estado,Tipo,Total_Creditos,Ente_Fisico,Dias_Atrasado, " _
                              & " Total_Atrasado,Nombre_Real,Fecha_Creacion,Bloqueo,IncluirEnCobro) VALUES (@Id_Persona, @Limite, @Estado, @Tipo, " _
                              & " @Total_Creditos, @Ente_Fisico, @Dias_Atrasado, @Total_Atrasado, @Nombre_Real, @Fecha_Creacion, @Bloqueo,@IncluirEnCobro); SELECT @@Identity"
        Dim oComando As New MySqlCommand(sql, Conexion)
        oComando = InicializarParametros(oComando, oClienteCredito)

        Dim id As Integer

        Try
            id = InsertarDatosDevuelveId(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Insertando cliente de crédito")
        End Try

        Return (id)
    End Function

    Public Sub Modificar(ByVal oClienteCredito As ClienteCredito)
        Const sql As String = "UPDATE CLIENTE_CREDITO SET Limite = @Limite, Estado = @Estado,Tipo = @Tipo, Total_Creditos = @Total_Creditos, " _
                              & " Ente_Fisico = @Ente_Fisico, Dias_Atrasado = @Dias_Atrasado, Total_Atrasado = @Total_Atrasado, Nombre_Real = @Nombre_Real, Bloqueo = @Bloqueo, IncluirEnCobro = @IncluirEnCobro " _
                              & " WHERE Id_Credito = @Id_Credito"
        Dim oComando As New MySqlCommand(sql, Conexion)
        oComando = InicializarParametros(oComando, oClienteCredito)

        Try
            ModificarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Modificando un cliente de crédito")
        End Try
    End Sub

    'Suma el monto al total de créditos de un Cliente.
    Public Sub SumarTotalCredito(ByVal idCredito As Integer, ByVal total As Double)
        Dim sql = "UPDATE CLIENTE_CREDITO SET Total_Creditos = Total_Creditos + " & total & " WHERE Id_Credito= " & idCredito

        Try
            ModificarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Sumando total al Total de créditos")
        End Try
    End Sub

    'Resta el monto al total de créditos de un Cliente.
    Public Sub RestarTotalCredito(ByVal idCredito As Integer, ByVal total As Double)
        Dim sql = "UPDATE CLIENTE_CREDITO SET Total_Creditos = Total_Creditos - " & total & " WHERE Id_Credito= " & idCredito

        Try
            ModificarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Restando total al Total de créditos")
        End Try
    End Sub

    'Modifica el total de créditos de un Cliente.
    Public Sub ModificarTotalCredito(ByVal idCredito As Integer, ByVal total As Double)
        Dim sql = "UPDATE CLIENTE_CREDITO SET Total_Creditos = " & total & " WHERE Id_Credito= " & idCredito

        Try
            ModificarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Restando total al Total de créditos")
        End Try
    End Sub

    'Modifica el Total Crédito, los Días Atrasados y el Total Atrasado de un cliente de crédito
    Public Sub ModificarDatos_Credito(ByVal oCliente As ClienteCredito)
        Const sql As String = "UPDATE CLIENTE_CREDITO SET Total_Creditos = @Total_Creditos, Dias_Atrasado = @Dias_Atrasado, Total_Atrasado = @Total_Atrasado WHERE Id_Credito=@Id_Credito"
        Dim oComando As New MySqlCommand(sql, Conexion)

        oComando.Parameters.AddWithValue("@Id_Credito", oCliente.IdCredito)
        oComando.Parameters.AddWithValue("@Total_Creditos", oCliente.TotalCreditos)
        oComando.Parameters.AddWithValue("@Dias_Atrasado", oCliente.DiasAtrasado)
        oComando.Parameters.AddWithValue("@Total_Atrasado", oCliente.TotalAtrasado)

        Try
            ModificarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Modificando Datos de crédito")
        End Try
    End Sub

    Public Sub Eliminar(ByVal idCredito As Integer)
        Dim sql As String = "DELETE FROM CLIENTE_CREDITO WHERE Id_Credito = " & idCredito

        Try
            EliminarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Eliminando un cliente credito")
        End Try
    End Sub

    'Si el cliente existe retorna el Id_Cliente de lo contrario retorna 0
    Public Function ConsultarIdClientePor_IdCredito(ByVal idCredito As Integer) As Integer
        Dim sql As String = "SELECT Id_Persona FROM CLIENTE_CREDITO WHERE Id_Credito = " & idCredito

        Try
            Dim oDataTable = ConsultarDatos(sql)
            Return oDataTable.Rows(0).Item(0)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando Id_Cliente por Id_Credito")
            Return 0
        End Try
    End Function

    Public Function ConsultarPor_IdCredito(ByVal idCredito As Integer) As ClienteCredito
        Dim sql = "SELECT * FROM CLIENTE_CREDITO WHERE Id_Credito = " & idCredito
        Return DevolverCliente(sql)
    End Function

    Public Function ConsultarPor_IdPersona(ByVal idPersona As Integer) As ClienteCredito
        Dim sql = "SELECT * FROM CLIENTE_CREDITO WHERE Id_Persona = " & idPersona
        Return DevolverCliente(sql)
    End Function

    'Si el cliente existe devulve todos los datos, de lo contrario devuelve un cliente con Id_Credito = 0
    Private Function DevolverCliente(ByVal sql As String) As ClienteCredito
        Dim oClienteCredito As New ClienteCredito

        Try
            Dim oTblCreditos = ConsultarDatos(sql)

            If oTblCreditos.Rows.Count > 0 Then
                oClienteCredito = LlenarDatos(oTblCreditos.Rows(0))
            Else
                oClienteCredito.IdCredito = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando cliente crédito por Id_Credito")
        End Try

        Return oClienteCredito
    End Function

    Private Function LlenarDatos(ByVal row As DataRow) As ClienteCredito
        Dim oClienteCredito As New ClienteCredito

        oClienteCredito.IdCredito = row.Item(0)
        oClienteCredito.IdPersona = row.Item(1)
        oClienteCredito.Limite = row.Item(2)
        oClienteCredito.Estado = row.Item(3)
        oClienteCredito.Tipo = row.Item(4)
        oClienteCredito.TotalCreditos = row.Item(5)
        oClienteCredito.EnteFisico = row.Item(6)
        oClienteCredito.DiasAtrasado = row.Item(7)
        oClienteCredito.TotalAtrasado = row.Item(8)

        If Not IsDBNull(row.Item(9)) Then
            oClienteCredito.NombreReal = row.Item(9)
        End If
        If Not IsDBNull(row.Item(10)) Then
            oClienteCredito.FechaCreacion = row.Item(10)
        End If
        oClienteCredito.Bloqueo = row.Item(11)
        oClienteCredito.IncluirEnCobro = row.Item(12)
        oClienteCredito.ListaBitacora = ConsultarBitacorasPor_IdCredito(oClienteCredito.IdCredito)

        Return oClienteCredito
    End Function

    'Retorna una tabla con todos los Id de los clientes de crédito
    Function ConsultarTodos_SoloIdCredito() As DataTable
        Const sql As String = "SELECT Id_Credito FROM CLIENTE_CREDITO"
        Return ConsultarDatos(sql)
    End Function

    'Retorna todas las personas que coincidan con el nombre y que tengan un crédito.
    Public Function ConsultarPor_NombreConCredito(ByVal nombre As String) As DataTable
        Dim sql As String = " SELECT c.Id_Credito, p.Id_Persona, CONCAT(p.Nombre ,' ', p.Apellido1 ,' ' , p.Apellido2) as Nombre, p.Cedula " _
                            & " FROM CLIENTE_CREDITO c INNER JOIN PERSONA p ON c.Id_Persona = p.Id_Persona " _
                           & " WHERE (CONCAT(p.Nombre ,' ', p.Apellido1 ,' ' , p.Apellido2) LIKE N'%" & nombre & "%') " _
                           & " ORDER BY p.Nombre"
        Dim oTblClientes As New DataTable
        Try
            oTblClientes = ConsultarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando personas con crédito")
        End Try
        Return oTblClientes
    End Function

    'Traslada el credito de un cliente a otro
    Public Sub TrasladarCredito(ByVal idActual As Integer, ByVal idTrasladar As Integer)
        Dim sql As String = "UPDATE CLIENTE_CREDITO SET Id_Persona = " & idActual & " WHERE Id_Persona = " & idTrasladar

        Try
            ModificarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Error trasladando un cliente credito")
        End Try
    End Sub

    'Cambia el valor de un cliente a "Bloqueado" o "Desbloqueado" según se indique
    Public Sub ModificarBloqueo(ByVal idCliente As Integer, ByVal bloqueo As Integer)
        Dim sql As String = "UPDATE CLIENTE_CREDITO SET Bloqueo = " & bloqueo & " WHERE Id_Credito = " & idCliente

        Try
            ModificarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Modificando bloqueo listado")
        End Try
    End Sub

    Public Sub DesbloquearTodos()
        Dim idClientesCredito = ConsultarTodos_SoloIdCredito()
        For i As Integer = 0 To idClientesCredito.Rows.Count - 1
            ModificarBloqueo(idClientesCredito.Rows(i).Item(0), False)
        Next i
    End Sub
    '****************************************BITACORAS******************************************************
    Public Sub Insertar_Bitacora(ByVal oBitacora As Bitacora)
        Const sql As String = "INSERT INTO BITACORA VALUES (@Id_Credito, @Fecha_Hora, @Descripcion)"
        Dim oComando As New MySqlCommand(sql, Conexion)

        oComando.Parameters.AddWithValue("@Id_Credito", oBitacora.IdCredito)
        oComando.Parameters.AddWithValue("@Fecha_Hora", oBitacora.FechaHora)
        oComando.Parameters.AddWithValue("@Descripcion", oBitacora.Descripcion)

        Try
            InsertarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Insertando bitácora de un cliente de crédito")
        End Try
    End Sub

    'Elimina una bitacora de un cliente según la fecha de creación
    Public Sub Eliminar_Bitacora(ByVal idCredito As Integer, ByVal fechaHora As String)
        Dim sql As String = "DELETE FROM BITACORA WHERE Id_Credito = " & idCredito & " AND Fecha_Hora = '" & fechaHora & "'"

        Try
            EliminarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Eliminando bitácora de un cliente de crédito")
        End Try
    End Sub

    'Elimina todas las bitacoras de un cliente
    Public Sub Eliminar_Bitacoras(ByVal idCredito As Integer)
        Dim sql As String = "DELETE FROM BITACORA WHERE Id_Credito = " & idCredito

        Try
            EliminarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Eliminando bitácoras de un cliente de crédito")
        End Try
    End Sub

    'Retorna una lista con todas las bitacoras de un cliente de crédito
    Public Function ConsultarBitacorasPor_IdCredito(ByVal idCredito As Integer) As List(Of Bitacora)
        Dim sql As String = "SELECT * FROM BITACORA WHERE Id_Credito = " & idCredito
        Dim oListaBitacoras As New List(Of Bitacora) 'Lista de bitacoras que sera devuelta

        Try
            Dim oDataTable = ConsultarDatos(sql)

            For i = 0 To oDataTable.Rows.Count - 1
                Dim oBitacora As New Bitacora
                oBitacora.IdCredito = oDataTable.Rows(i).Item(0)
                oBitacora.FechaHora = oDataTable.Rows(i).Item(1)
                oBitacora.Descripcion = oDataTable.Rows(i).Item(2)
                oListaBitacoras.Add(oBitacora)
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando bitacoras por Id_Credito")
        End Try

        Return oListaBitacoras
    End Function

    'Traslada las bitacoras de un cliente a otro.
    Public Sub TrasladarBitacoras(ByVal idCreditoActual As Integer, ByVal idCreditoTrasladar As Integer)
        Dim sql As String = "UPDATE BITACORA SET Id_Credito = " & idCreditoActual & " WHERE Id_Credito = " & idCreditoTrasladar

        Try
            ModificarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Error trasladando las bitacoras de un cliente credito")
        End Try
    End Sub

    'Recibe el WHERE de la consulta con los criterios de búsqueda
    Private Function Consultar(ByVal condicion As String) As DataTable
        Dim sql As String = " SELECT c.Id_Persona, c.Id_Credito, p.Nombre, p.Apellido1, p.Apellido2, i.TelefonoPrincipal, i.OtroTelefono, " _
                          & " c.Ente_Fisico,c.Total_Creditos, c.Limite, " _
                          & " c.Dias_Atrasado, c.Total_Atrasado, c.Estado, c.Tipo " _
                          & " FROM CLIENTE_CREDITO c INNER JOIN " _
                          & " PERSONA p ON c.Id_Persona = p.Id_Persona INNER JOIN " _
                          & " INFORMACION_PERSONAL i ON p.Id_Persona = i.Id_Persona " & condicion _
                          & " ORDER BY c.Ente_Fisico DESC, p.Nombre, p.Apellido1, p.Apellido2"
        Dim oDataTable As New DataTable
        Try
            oDataTable = ConsultarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando clientes de crédito según algún criterio")
        End Try

        Return oDataTable
    End Function

    Public Function ConsultarVarios(ByVal enteFisico As Integer, ByVal tipo As Integer, ByVal estado As Integer, ByVal incluirEnCobro As Boolean) As DataTable
        Dim condicion As String = ""

        If enteFisico <> 4 Then
            condicion += GetSqlCondicion(condicion, GetSqlEnte(enteFisico))
        End If

        If estado <> 4 Then
            condicion += GetSqlCondicion(condicion, GetSqlEstado(estado))
        End If

        If tipo <> 4 Then
            If tipo = ClienteCredito.ListaEstado.Abierto And incluirEnCobro And estado = 1 Then
                condicion += GetSqlCondicion(condicion, GetSqlIncluyendoEnCobro(tipo))
            Else
                condicion += GetSqlCondicion(condicion, GetSqlTipo(tipo))
            End If
        End If

        Return Consultar(condicion)
    End Function

    Private Function GetSqlCondicion(ByVal condicion As String, ByVal sql As String)
        If condicion = String.Empty Then
            Return String.Format(" WHERE {0}", sql)
        Else
            Return String.Format(" AND {0}", sql)
        End If
    End Function

    Private Function GetSqlEnte(ByVal enteFisico As Integer) As String
        Return String.Format("c.Ente_Fisico = {0}", enteFisico)
    End Function

    Private Function GetSqlTipo(ByVal tipo As Integer) As String
        Return String.Format("c.Estado = {0}", tipo)
    End Function

    Private Function GetSqlIncluyendoEnCobro(ByVal tipo As Integer) As String
        Return String.Format("({0} || c.IncluirEnCobro = 1)", GetSqlTipo(tipo))
    End Function

    Private Function GetSqlEstado(ByVal estado As Integer) As String
        If estado = 0 Then
            Return String.Format("c.Total_Atrasado <= {0}", estado)
        Else
            Return String.Format("c.Total_Atrasado > {0}", estado)
        End If
    End Function

    Public Function ConsultarTotalCreditos() As Double
        Const sql As String = " SELECT sum(Total_Creditos) FROM CLIENTE_CREDITO"
        Dim total As Double = 0.0
        Try
            Dim oDataTable = ConsultarDatos(sql)
            If oDataTable.Rows.Count > 0 Then
                total = oDataTable.Rows(0).Item(0)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando total de todos lso créditos")
        End Try

        Return total
    End Function

End Class
