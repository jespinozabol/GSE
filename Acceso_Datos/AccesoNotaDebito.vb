Imports MySql.Data.MySqlClient
Imports Entidades
Public Class AccesoNotaDebito
    Inherits Transaccion

    Private ReadOnly _oAccesoAbono As New AccesoAbono

    Private Sub InicializarParametrosNDG(ByVal oComando As MySqlCommand, ByVal oNdg As NotaDebitoGeneral)
        oComando.Parameters.AddWithValue("@Id_ND", oNdg.IdND)
        oComando.Parameters.AddWithValue("@Fecha", oNdg.Fecha)
        oComando.Parameters.AddWithValue("@IdCliente_Credito", oNdg.IdClienteCredito)
        oComando.Parameters.AddWithValue("@Monto", oNdg.Monto)
        oComando.Parameters.AddWithValue("@Motivo", oNdg.Motivo)
        oComando.Parameters.AddWithValue("@Impuesto", oNdg.Impuesto)
        oComando.Parameters.AddWithValue("@Estado", oNdg.Estado)
        oComando.Parameters.AddWithValue("@NumDias", oNdg.NumDias)
        Return
    End Sub

    Public Sub Insertar_NDG(ByVal oNdg As NotaDebitoGeneral)
        Const sql As String = "INSERT INTO ND_GENERAL VALUES (@Id_ND, @Fecha,@IdCliente_Credito, @Monto, @Motivo, @Impuesto, @Estado, @NumDias)"
        Dim oComando As New MySqlCommand(sql, Conexion)
        InicializarParametrosNDG(oComando, oNdg)

        Try
            InsertarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Insertando nota de débito general")
        End Try

    End Sub

    'Retorna una lista de todas las notas de débito generales pendientes de un cliente
    Public Function ConsultarNDG_Pendientes(ByVal idClienteCredito As Integer) As List(Of NotaDebitoGeneral)
        Dim sql As String = "SELECT * FROM ND_GENERAL WHERE Estado = 0 AND IdCliente_Credito = " & idClienteCredito
        Dim oLista As New List(Of NotaDebitoGeneral)

        Try
            Dim oDataTable = ConsultarDatos(sql)

            For i = 0 To oDataTable.Rows.Count - 1
                oLista.Add(LlenarNotasDebitoGeneral(oDataTable.Rows(i)))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando nota de crédito general")
        End Try

        Return oLista
    End Function

    Private Function LlenarNotasDebitoGeneral(ByVal row As DataRow) As NotaDebitoGeneral
        Dim oNdg As New NotaDebitoGeneral
        oNdg.IdND = row.Item(0)
        oNdg.Fecha = row.Item(1)
        oNdg.IdClienteCredito = row.Item(2)
        oNdg.Monto = row.Item(3)
        oNdg.Motivo = row.Item(4)
        oNdg.Impuesto = row.Item(5)
        oNdg.Estado = row.Item(6)
        oNdg.NumDias = row.Item(7)
        oNdg.Abonos = _oAccesoAbono.ConsultarPendientesPorNumDocYTipo(oNdg.IdND, Abono.ListaTipoDoc.NDG)
        Return oNdg
    End Function

    'Retorna la cantidad de notas de débito pendientes que tiene un cliente
    Public Function ConsultarNumNDG_Pendientes(ByVal idClienteCredito As Integer) As Integer
        Dim sql As String = "SELECT * FROM ND_GENERAL WHERE Estado = 0 AND IdCliente_Credito = " & idClienteCredito
        Dim oDataTable As DataTable 'Se crea un dataTable

        Try
            oDataTable = ConsultarDatos(sql)
            If oDataTable.Rows.Count > 0 Then
                Return oDataTable.Rows.Count
            Else
                Return 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando cantidad de notas generales pendientes")
            Return 0
        End Try
    End Function

    'Retorna una cadena con el motivo de la nota de crédito
    Public Function ConsultarMotivoNdg(ByVal idNd As Integer) As String
        Dim sql As String = "SELECT Motivo FROM ND_GENERAL WHERE Id_ND = " & idNd
        Try
            Dim oDataTable = ConsultarDatos(sql)
            If oDataTable.Rows.Count > 0 Then
                Return oDataTable.Rows(0).Item(0)
            Else
                Return ""
            End If
        Catch ex As Exception
            MsgBox("No existe ninguna nota de débito con ese Id", MsgBoxStyle.Critical, "Consultando motivo NDG")
            Return ""
        End Try
    End Function

    'Modifica el estado de una nota de crédito general
    Public Sub ModificarEstadoNDGPor_IdND(ByVal idNd As Integer, ByVal estado As NotaDebitoGeneral.ListaEstado)
        Dim sql As String = "UPDATE ND_GENERAL SET Estado = " & estado & "  WHERE Id_ND = " & idNd
        Try
            ModificarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Modificando Estado de la NDG")
        End Try
    End Sub

    'Modifica todos los estados de las notas de crédito de un cliente
    Public Sub ModificarEstadoNCGPor_IdClienteCredito(ByVal idClienteCredito As Integer, ByVal estado As NotaDebitoGeneral.ListaEstado)
        Const sql As String = "UPDATE ND_GENERAL SET Estado = @Estado WHERE IdCliente_Credito = @IdCliente_Credito"
        Try
            ModificarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Modificando los Estados de las NCG de un cliente")
        End Try
    End Sub

    Public Function ConsultarNdg(ByVal idNd As Integer) As NotaDebitoGeneral
        Dim sql As String = "SELECT * FROM ND_GENERAL WHERE Id_ND = " & idNd
        Dim ndGeneral As New NotaDebitoGeneral

        Try
            Dim oDataTable = ConsultarDatos(sql)

            If oDataTable.Rows.Count > 0 Then
                ndGeneral = LlenarNotasDebitoGeneral(oDataTable.Rows(0))
            Else
                ndGeneral.IdND = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando Nota de débito general")
        End Try

        Return ndGeneral
    End Function

    'Elimina todas las notas de débito generales de un cliente
    Public Sub EliminarNdg(ByVal idClienteCredito As Integer)
        Dim sql As String = "DELETE FROM ND_GENERAL WHERE IdCliente_Credito = " & idClienteCredito

        Try
            EliminarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Eliminando todas las Notas de débito generales de un clientes")
        End Try
    End Sub

    Public Function ConsultarTodasNdg() As DataTable
        Const sql As String = " SELECT ndg.Id_ND, CONCAT(p.Nombre , ' ' , p.Apellido1 , ' ' , p.Apellido2), ndg.Fecha, ndg.Monto, " _
                              & " ndg.Estado FROM CLIENTE_CREDITO c INNER JOIN " _
                              & " ND_GENERAL ndg ON c.Id_Credito = ndg.IdCliente_Credito INNER JOIN " _
                              & " PERSONA p ON c.Id_Persona = p.Id_Persona"
        Return DevolverConsulta(sql)
    End Function

    Public Function ConsultarPor_IdPersonaNDG(ByVal idPersona As Integer) As DataTable
        Dim sql As String = "SELECT n.Id_ND, CONCAT(p.Nombre , ' ' , p.Apellido1 , ' ' , p.Apellido2) as Nombre, " _
                     & " n.Fecha, n.Monto, n.Estado " _
                     & " FROM ND_GENERAL n INNER JOIN CLIENTE_CREDITO c ON n.IdCliente_Credito = c.Id_Credito " _
                     & " INNER JOIN PERSONA p ON c.Id_Persona = p.Id_Persona WHERE p.Id_Persona = " & idPersona
        Return DevolverConsulta(sql)
    End Function

    Public Function ConsultarPor_IdNDG(ByVal idNd As Integer) As DataTable
        Dim sql As String = "SELECT n.Id_ND,CONCAT(p.Nombre , ' ' , p.Apellido1 , ' ' , p.Apellido2) as Nombre, " _
                     & " n.Fecha, n.Monto, n.Estado " _
                     & " FROM ND_GENERAL n INNER JOIN CLIENTE_CREDITO c ON n.IdCliente_Credito = c.Id_Credito " _
                     & " INNER JOIN PERSONA p ON c.Id_Persona = p.Id_Persona WHERE n.Id_ND = " & idNd
        Return DevolverConsulta(sql)
    End Function

    Private Function DevolverConsulta(ByVal sql As String) As DataTable
        Dim oDataTable As New DataTable
        Try
            oDataTable = ConsultarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Realizando consulta según criterios")
        End Try
        Return oDataTable
    End Function

    'Traslada las NDG de un cliente a otro.
    Public Sub TrasladarGenerales(ByVal idCreditoActual As Integer, ByVal idCreditoTrasladar As Integer)
        Dim sql As String = "UPDATE ND_GENERAL SET IdCliente_Credito = " & idCreditoActual & " WHERE IdCliente_Credito = " & idCreditoTrasladar
        Try
            ModificarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Trasladando NDG de un cliente a otro")
        End Try
    End Sub
End Class