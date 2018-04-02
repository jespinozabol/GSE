Imports MySql.Data.MySqlClient
Imports Entidades
Public Class AccesoNotaCredito
    Inherits Transaccion

    Private Sub InicializarParametros(ByVal oComando As MySqlCommand, ByVal oNotaCredito As NotaCredito)
        oComando.Parameters.AddWithValue("@Id_NC", oNotaCredito.IdNC)
        oComando.Parameters.AddWithValue("@Num_Factura", oNotaCredito.NumFactura)
        oComando.Parameters.AddWithValue("@Fecha", oNotaCredito.Fecha)
        oComando.Parameters.AddWithValue("@Monto", oNotaCredito.Monto)
        oComando.Parameters.AddWithValue("@Estado", oNotaCredito.Estado)
        Return
    End Sub

    Private Sub InicializarParametrosDetalle(ByVal oComando As MySqlCommand, ByVal oNcDetalle As NotaCreditoDetalle)
        oComando.Parameters.AddWithValue("@Id_NC", oNcDetalle.IdNC)
        oComando.Parameters.AddWithValue("@Cantidad", oNcDetalle.Cantidad)
        oComando.Parameters.AddWithValue("@Id_Producto", oNcDetalle.Id_Producto)
        oComando.Parameters.AddWithValue("@Descripcion", oNcDetalle.Descripcion)
        oComando.Parameters.AddWithValue("@PrecioUnitario", oNcDetalle.PrecioUnitario)
        oComando.Parameters.AddWithValue("@Descuento", oNcDetalle.Descuento)
        oComando.Parameters.AddWithValue("@Impuesto", oNcDetalle.Impuesto)
        oComando.Parameters.AddWithValue("@Tdescuento", oNcDetalle.TDescuento)
        oComando.Parameters.AddWithValue("@Timpuesto", oNcDetalle.TImpuesto)
        Return
    End Sub

    Private Sub Insertar_Detalle(ByVal oNcDetalle As NotaCreditoDetalle)
        Const sql As String = "INSERT INTO NC_DETALLE VALUES (@Id_NC,@Cantidad, @Id_Producto, @Descripcion, @PrecioUnitario, @Descuento, @Impuesto, @Tdescuento, @Timpuesto)"
        Dim oComando As New MySqlCommand(sql, Conexion)
        InicializarParametrosDetalle(oComando, oNcDetalle)

        Try
            InsertarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Insertando detalle de la nota de crédito")
        End Try
    End Sub

    Public Sub Insertar(ByVal oNotaCredito As NotaCredito)
        Const sql As String = "INSERT INTO NOTA_CREDITO VALUES (@Id_NC, @Num_Factura,@Fecha, @Monto, @Estado)"
        Dim oComando As New MySqlCommand(sql, Conexion)
        InicializarParametros(oComando, oNotaCredito)

        Try
            InsertarDatos(oComando)

            For i As Integer = 0 To oNotaCredito.NCDetalles.Count - 1
                Insertar_Detalle(oNotaCredito.NCDetalles(i))
            Next i
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Insertando nota de crédito")
        End Try
    End Sub

    'Retorna una lista con todas las notas de crédito pendientes de una factura
    Public Function ConsultarSinAplicarPor_NumFactura(ByVal numFactura As Long) As List(Of NotaCredito)
        Dim sql As String = "SELECT * FROM NOTA_CREDITO WHERE Estado = 0 AND Num_Factura = " & numFactura
        Dim oLista As New List(Of NotaCredito)

        Try
            Dim oDataTable = ConsultarDatos(sql)

            For i = 0 To oDataTable.Rows.Count - 1
                oLista.Add(LlenarNotasCredito(oDataTable.Rows(i)))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando notas de crédito pendientes")
        End Try

        Return oLista
    End Function

    'Retorna una lista con todas las notas de crédito de una factura
    Public Function ConsultarTodasPor_NumFactura(ByVal numFactura As Long) As List(Of NotaCredito)
        Dim sql As String = "SELECT * FROM NOTA_CREDITO WHERE Num_Factura = " & numFactura
        Dim oLista As New List(Of NotaCredito)

        Try
            Dim oDataTable = ConsultarDatos(sql)

            For i = 0 To oDataTable.Rows.Count - 1
                oLista.Add(LlenarNotasCredito(oDataTable.Rows(i)))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando notas de crédito")
        End Try

        Return oLista
    End Function

    'Retorna una lista con todos los detalles de una NC
    Private Function ConsultarDetalles(ByVal idNc As Integer) As List(Of NotaCreditoDetalle)
        Dim sql As String = "SELECT * FROM NC_DETALLE WHERE Id_NC = " & idNc
        Dim oLista As New List(Of NotaCreditoDetalle)

        Try
            Dim oDataTable = ConsultarDatos(sql)

            For i = 0 To oDataTable.Rows.Count - 1
                Dim oDetalle As NotaCreditoDetalle
                oDetalle = New NotaCreditoDetalle
                oDetalle.IdNC = oDataTable.Rows(i).Item(0)
                oDetalle.Cantidad = oDataTable.Rows(i).Item(1)
                oDetalle.Id_Producto = oDataTable.Rows(i).Item(2)
                oDetalle.Descripcion = oDataTable.Rows(i).Item(3)
                oDetalle.PrecioUnitario = oDataTable.Rows(i).Item(4)
                oDetalle.Descuento = oDataTable.Rows(i).Item(5)
                oDetalle.Impuesto = oDataTable.Rows(i).Item(6)
                oDetalle.TDescuento = oDataTable.Rows(i).Item(7)
                oDetalle.TImpuesto = oDataTable.Rows(i).Item(8)
                oLista.Add(oDetalle)
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando lista de notas de crédito detalle")
        End Try

        Return oLista
    End Function

    'Modifica el estado de una nota de crédito
    Public Sub ModificarEstadoNCPor_IdNC(ByVal idNc As Integer, ByVal estado As NotaCreditoGeneral.ListaEstado)
        Dim sql As String = "UPDATE NOTA_CREDITO SET Estado = " & estado & " WHERE Id_NC = " & idNc
        Try
            ModificarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Modificando Estado de la NC por el Id")
        End Try
    End Sub

    'Modifica todos los estados de las notas de crédito de una factura
    Public Sub ModificarEstadoNCPor_NumFactura(ByVal numFactura As Integer, ByVal estado As NotaCreditoGeneral.ListaEstado)
        Dim sql As String = "UPDATE NOTA_CREDITO SET Estado = " & estado & " WHERE Num_Factura = " & numFactura
        Try
            ModificarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Modificando los Estados de la notas de crédito de una factura")
        End Try
    End Sub

    Function Consultar(ByVal idNc As Integer) As NotaCredito
        Dim sql As String = "SELECT * FROM NOTA_CREDITO WHERE Id_NC = " & idNc
        Dim oNotaCredito As New NotaCredito

        Try
            Dim oDataTable = ConsultarDatos(sql)

            If oDataTable.Rows.Count > 0 Then
                oNotaCredito = LlenarNotasCredito(oDataTable.Rows(0))
            Else
                oNotaCredito.IdNC = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando Nota de crédito")
        End Try

        Return oNotaCredito
    End Function

    Private Function LlenarNotasCredito(ByVal row As DataRow) As NotaCredito
        Dim oNotaCredito As New NotaCredito
        oNotaCredito.IdNC = row.Item(0)
        oNotaCredito.NumFactura = row.Item(1)
        oNotaCredito.Fecha = row.Item(2)
        oNotaCredito.Monto = row.Item(3)
        oNotaCredito.Estado = row.Item(4)
        oNotaCredito.NCDetalles = ConsultarDetalles(oNotaCredito.IdNC)
        Return oNotaCredito
    End Function


    '****************************************************NOTAS CREDITO GENERALES***************************************

    Private Sub InicializarParametrosGeneral(ByVal oComando As MySqlCommand, ByVal oNcg As NotaCreditoGeneral)
        oComando.Parameters.AddWithValue("@Id_NC", oNcg.IdNC)
        oComando.Parameters.AddWithValue("@Fecha", oNcg.Fecha)
        oComando.Parameters.AddWithValue("@IdCliente_Credito", oNcg.IdClienteCredito)
        oComando.Parameters.AddWithValue("@Monto", oNcg.Monto)
        oComando.Parameters.AddWithValue("@Motivo", oNcg.Motivo)
        oComando.Parameters.AddWithValue("@Impuesto", oNcg.Impuesto)
        oComando.Parameters.AddWithValue("@Estado", oNcg.Estado)
        Return
    End Sub

    Public Sub Insertar_NCG(ByVal oNotaCredito As NotaCreditoGeneral)
        Const sql As String = "INSERT INTO NC_GENERAL VALUES (@Id_NC, @Fecha,@IdCliente_Credito, @Monto, @Motivo, @Impuesto, @Estado)"
        Dim oComando As New MySqlCommand(sql, Conexion)
        InicializarParametrosGeneral(oComando, oNotaCredito)

        Try
            InsertarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Insertando nota de crédito general")
        End Try
    End Sub

    'Retorna una lista de todas las notas de crédito generales pendientes de un cliente 
    Public Function ConsultarNCG_Pendientes(ByVal idClienteCredito As Integer) As List(Of NotaCreditoGeneral)
        Dim sql As String = "SELECT * FROM NC_GENERAL WHERE Estado = 0 AND IdCliente_Credito = " & idClienteCredito
        Dim oLista As New List(Of NotaCreditoGeneral)

        Try
            Dim oDataTable = ConsultarDatos(sql)

            For i = 0 To oDataTable.Rows.Count - 1
                oLista.Add(LlenarNotasCreditoGeneral(oDataTable.Rows(i)))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando nota de crédito general")
        End Try

        Return oLista
    End Function

    'Retorna la cantidad de notas de crédito pendientes que tiene un cliente
    Public Function ConsultarNumNCG_Pendientes(ByVal idClienteCredito As Integer) As Integer
        Dim sql As String = "SELECT * FROM NC_GENERAL WHERE Estado = 0 AND IdCliente_Credito = " & idClienteCredito
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
    Public Function ConsultarMotivoNcg(ByVal idNc As Integer) As String
        Dim sql As String = "SELECT Motivo FROM NC_GENERAL WHERE Id_NC = " & idNc

        Try
            Dim oDataTable = ConsultarDatos(sql)
            If oDataTable.Rows.Count > 0 Then
                Return oDataTable.Rows(0).Item(0)
            Else
                Return ""
            End If
        Catch ex As Exception
            MsgBox("No existe ninguna nota de crédito con ese Id", MsgBoxStyle.Critical, "Consultando motivo NCG")
            Return ""
        End Try
    End Function

    'Modifica el estado de una nota de crédito general
    Public Sub ModificarEstadoNCGPor_IdNC(ByVal idNc As Integer, ByVal estado As NotaCreditoGeneral.ListaEstado)
        Dim sql As String = "UPDATE NC_GENERAL SET Estado = " & estado & " WHERE Id_NC = " & idNc
        Try
            ModificarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Modificando Estado de la NCG")
        End Try
    End Sub

    'Modifica todos los estados de las notas de crédito de un cliente
    Public Sub ModificarEstadoNCGPor_IdClienteCredito(ByVal idClienteCredito As Integer, ByVal estado As NotaCreditoGeneral.ListaEstado)
        Dim sql As String = "UPDATE NC_GENERAL SET Estado = " & estado & " WHERE IdCliente_Credito = " & idClienteCredito
        Try
            ModificarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Modificando los Estados de las NCG de un cliente")
        End Try
    End Sub

    'Elimina todas las notas de crédito generales de un cliente
    Public Sub EliminarNcg(ByVal idClienteCredito As Integer)
        Dim sql As String = "DELETE FROM NC_GENERAL WHERE IdCliente_Credito = " & idClienteCredito

        Try
            EliminarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Eliminando Nota de crédito general")
        End Try
    End Sub

    Function ConsultarNcg(ByVal idNc As Integer) As NotaCreditoGeneral
        Dim sql As String = "SELECT * FROM NC_GENERAL WHERE Id_NC = " & idNc
        Dim ncGeneral As New NotaCreditoGeneral

        Try
            Dim oDataTable = ConsultarDatos(sql)

            If oDataTable.Rows.Count > 0 Then
                ncGeneral = LlenarNotasCreditoGeneral(oDataTable.Rows(0))
            Else
                ncGeneral.IdNC = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando Nota de crédito general")
        End Try

        Return ncGeneral
    End Function

    Private Function LlenarNotasCreditoGeneral(ByVal row As DataRow) As NotaCreditoGeneral
        Dim oNotaGeneral As New NotaCreditoGeneral
        oNotaGeneral.IdNC = row.Item(0)
        oNotaGeneral.Fecha = row.Item(1)
        oNotaGeneral.IdClienteCredito = row.Item(2)
        oNotaGeneral.Monto = row.Item(3)
        oNotaGeneral.Motivo = row.Item(4)
        oNotaGeneral.Impuesto = row.Item(5)
        oNotaGeneral.Estado = row.Item(6)
        Return oNotaGeneral
    End Function

    'Elimina todas las notas de crédito de un cliente
    Public Sub Eliminar(ByVal numFactura As Integer)
        Dim sql As String = "DELETE FROM NOTA_CREDITO WHERE Num_Factura = " & numFactura

        Try
            EliminarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Eliminando Nota de crédito")
        End Try
    End Sub

    'Traslada las NCG de un cliente a otro.
    Public Sub TrasladarGenerales(ByVal idCreditoActual As Integer, ByVal idCreditoTrasladar As Integer)
        Dim sql As String = "UPDATE NC_GENERAL SET IdCliente_Credito = " & idCreditoActual & " WHERE IdCliente_Credito = " & idCreditoTrasladar

        Try
            ModificarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Trasladando NCG de un cliente a otro")
        End Try
    End Sub

    Public Function ConsultarTodas() As DataTable
        Const sql As String = " SELECT n.Id_NC, CONCAT(p.Nombre , ' ' , p.Apellido1 , ' ' , p.Apellido2) as Nombre, n.Fecha, n.Monto, " _
                              & " n.Estado FROM CLIENTE_CREDITO c INNER JOIN " _
                              & " PERSONA p ON c.Id_Persona = p.Id_Persona INNER JOIN " _
                              & " FACTURA_CREDITO f ON c.Id_Credito = f.Id_Credito INNER JOIN " _
                              & " NOTA_CREDITO n ON f.Num_Factura = n.Num_Factura"
        Return DevolverConsulta(sql)
    End Function

    Public Function ConsultarTodasNcg() As DataTable
        Const sql As String = " SELECT ncg.Id_NC, CONCAT(p.Nombre , ' ' , p.Apellido1 , ' ' , p.Apellido2), ncg.Fecha, ncg.Monto, " _
                              & " ncg.Estado FROM CLIENTE_CREDITO c INNER JOIN " _
                              & " NC_GENERAL ncg ON c.Id_Credito = ncg.IdCliente_Credito INNER JOIN " _
                              & " PERSONA p ON c.Id_Persona = p.Id_Persona"
        Return DevolverConsulta(sql)
    End Function

    Public Function ConsultarPor_IdPersona(ByVal idPersona As Integer) As DataTable
        Dim sql As String = "SELECT n.Id_NC,CONCAT(p.Nombre , ' ' , p.Apellido1 , ' ' , p.Apellido2) as Nombre, " _
                      & " n.Fecha, n.Monto, n.Estado " _
                      & " FROM NOTA_CREDITO n INNER JOIN FACTURA_ENCABEZADO f ON n.Num_Factura = f.Num_Factura " _
                      & " INNER JOIN PERSONA p ON f.Id_Persona = p.Id_Persona WHERE p.Id_Persona = " & idPersona
        Return DevolverConsulta(sql)
    End Function

    Public Function ConsultarPor_IdPersonaNCG(ByVal idPersona As Integer) As DataTable
        Dim sql As String = "SELECT n.Id_NC, CONCAT(p.Nombre , ' ' , p.Apellido1 , ' ' , p.Apellido2) as Nombre, " _
                      & " n.Fecha, n.Monto, n.Estado " _
                      & " FROM NC_GENERAL n INNER JOIN CLIENTE_CREDITO c ON n.IdCliente_Credito = c.Id_Credito " _
                      & " INNER JOIN PERSONA p ON c.Id_Persona = p.Id_Persona WHERE p.Id_Persona = " & idPersona
        Return DevolverConsulta(sql)
    End Function

    Public Function ConsultarPor_IdNC(ByVal idNc As Integer) As DataTable
        Dim sql As String = "SELECT n.Id_NC, CONCAT(p.Nombre , ' ' , p.Apellido1 , ' ' , p.Apellido2) as Nombre, " _
                      & " n.Fecha, n.Monto, n.Estado " _
                      & " FROM NOTA_CREDITO n INNER JOIN FACTURA_ENCABEZADO f ON n.Num_Factura = f.Num_Factura " _
                      & " INNER JOIN PERSONA p ON f.Id_Persona = p.Id_Persona WHERE n.Id_NC = " & idNc
        Return DevolverConsulta(sql)
    End Function

    Public Function ConsultarPor_IdNCG(ByVal idNc As Integer) As DataTable
        Dim sql As String = "SELECT n.Id_NC,CONCAT(p.Nombre , ' ' , p.Apellido1 , ' ' , p.Apellido2) as Nombre, " _
                      & " n.Fecha, n.Monto, n.Estado " _
                      & " FROM NC_GENERAL n INNER JOIN CLIENTE_CREDITO c ON n.IdCliente_Credito = c.Id_Credito " _
                      & " INNER JOIN PERSONA p ON c.Id_Persona = p.Id_Persona WHERE n.Id_NC = " & idNc
        Return DevolverConsulta(sql)
    End Function

    Public Function ConsultarPor_NumFactura(ByVal numFactura As Long) As DataTable
        Dim sql As String = "SELECT n.Id_NC, CONCAT(p.Nombre , ' ' , p.Apellido1 , ' ' , p.Apellido2) as Nombre, " _
                     & " n.Fecha, n.Monto, n.Estado " _
                     & " FROM NOTA_CREDITO n INNER JOIN FACTURA_ENCABEZADO f ON n.Num_Factura = f.Num_Factura " _
                     & " INNER JOIN PERSONA p ON f.Id_Persona = p.Id_Persona WHERE f.Num_Factura = " & numFactura
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
End Class