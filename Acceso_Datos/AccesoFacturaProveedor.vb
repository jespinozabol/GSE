Imports MySql.Data.MySqlClient
Imports Entidades
Imports System.Text.RegularExpressions

Public Class AccesoFacturaProveedor
    Inherits Transaccion

    Private ReadOnly _oAccesoAbonos As New AccesoAbonoFacturaProveedor

    Function ConsultarNumFacturasPor_ProveedorFecha(ByVal idProveedor As Integer, ByVal fechaInicio As Date) As DataTable
        Dim sql As String = "SELECT Num_Factura FROM FACTURA_PORPAGAR WHERE Id_Proveedor = " & idProveedor & " AND Fecha >= '" & fechaInicio.ToString("yyyy-MM-dd") & "' ORDER BY Num_Factura ASC"
        Dim oDataTable As New DataTable

        Try
            oDataTable = ConsultarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando numFacturas por IdProveedor y fecha ")
        End Try

        Return oDataTable
    End Function

    '***********************************************************************************************************
    '***********************************************************************************************************
    '****************************************FACTURAS PROVEEDORES***********************************************
    '***********************************************************************************************************
    Private Function InicializarParametros(ByVal oComando As MySqlCommand, ByVal oDocPorPagar As FacturaProveedor) As MySqlCommand
        oComando.Parameters.AddWithValue("@Id_Proveedor", oDocPorPagar.IdProveedor)
        oComando.Parameters.AddWithValue("@Id_DocPagar", oDocPorPagar.IdDocPagar)
        oComando.Parameters.AddWithValue("@Fecha", oDocPorPagar.Fecha)
        oComando.Parameters.AddWithValue("@Num_Factura", oDocPorPagar.NumFactura)
        oComando.Parameters.AddWithValue("@SubTotalIV", oDocPorPagar.SubTotalIV)
        oComando.Parameters.AddWithValue("@SubTotalEx", oDocPorPagar.SubTotalEx)
        oComando.Parameters.AddWithValue("@IV", oDocPorPagar.IV)
        oComando.Parameters.AddWithValue("@Total", oDocPorPagar.Total)
        oComando.Parameters.AddWithValue("@Estado", oDocPorPagar.Estado)
        oComando.Parameters.AddWithValue("@FechaCancelacion", oDocPorPagar.FechaCancelacion)
        oComando.Parameters.AddWithValue("@FechaIngreso", oDocPorPagar.FechaIngreso)
        oComando.Parameters.AddWithValue("@MesTributo", oDocPorPagar.MesTributo)
        oComando.Parameters.AddWithValue("@Dias", oDocPorPagar.Dias)
        oComando.Parameters.AddWithValue("@Motivo", oDocPorPagar.Motivo)
        oComando.Parameters.AddWithValue("@Contado", oDocPorPagar.Contado)
        Return oComando
    End Function

    Public Sub Insertar(ByVal oDocPorPagar As FacturaProveedor)
        Const sql As String = "INSERT INTO FACTURA_PORPAGAR (Id_Proveedor, Fecha, Num_Factura, " _
                              & " SubTotalIV, SubTotalEx,IV,Total,Estado,FechaCancelacion,FechaIngreso,MesTributo,Dias,Motivo,Contado) " _
                              & " VALUES (@Id_Proveedor, @Fecha, @Num_Factura, @SubTotalIV, @SubTotalEx,@IV,@Total,@Estado, " _
                              & " @FechaCancelacion,@FechaIngreso,@MesTributo,@Dias,@Motivo,@Contado); SELECT @@Identity"
        Dim oComando As New MySqlCommand(sql, Conexion)
        oComando = InicializarParametros(oComando, oDocPorPagar)

        Try
            Dim id = InsertarDatosDevuelveId(oComando)

            For i = 0 To oDocPorPagar.ListaNC.Count - 1
                oDocPorPagar.ListaNC(i).IdDocPorPagar = id
                Insertar_NC(oDocPorPagar.ListaNC(i))
            Next

            For i = 0 To oDocPorPagar.ListaND.Count - 1
                oDocPorPagar.ListaND(i).IdDocPorPagar = id
                Insertar_ND(oDocPorPagar.ListaND(i))
            Next

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Insertando factura proveedor")
        End Try
    End Sub

    Public Sub Modificar(ByVal oDocPorPagar As FacturaProveedor)
        Const sql As String = "UPDATE FACTURA_PORPAGAR SET Id_Proveedor = @Id_Proveedor, Fecha = @Fecha, Num_Factura=@Num_Factura, " _
                              & " SubTotalIV=@SubTotalIV , SubTotalEx = @SubTotalEx, IV=@IV, Total = @Total, Estado=@Estado, " _
                              & " FechaCancelacion=@FechaCancelacion, FechaIngreso = @FechaIngreso, MesTributo = @MesTributo, Dias = @Dias, Motivo = @Motivo, Contado = @Contado WHERE Id_DocPagar = @Id_DocPagar"
        Dim oComando As New MySqlCommand(sql, Conexion)
        oComando = InicializarParametros(oComando, oDocPorPagar)

        Try
            ModificarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Modificando factura proveedor")
        End Try
    End Sub

    'Actualiza el estado de una factura
    Public Sub ModificarEstadoFechaCancelacion(ByVal idDocPagar As Integer, ByVal estado As FacturaProveedor.ListaEstado, ByVal fechaCancelacion As Date)
        Dim sql As String = "UPDATE FACTURA_PORPAGAR SET Estado = " & estado & ", FechaCancelacion = '" & fechaCancelacion.ToString("yyyy-MM-dd") & "' WHERE Id_DocPagar = " & idDocPagar

        Try
            ModificarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Modificando el Estado y la fecha de cancelación de una factura proveedor")
        End Try
    End Sub

    Public Function Consultar(ByVal idFacturaProveedor As Integer) As FacturaProveedor
        Dim sql As String = " SELECT f.* FROM FACTURA_PORPAGAR f INNER JOIN PROVEEDOR p " _
                     & " ON f.Id_Proveedor = p.Id_Proveedor WHERE Id_DocPagar = " & idFacturaProveedor
        Return DevolverFacturaProveedor(sql)
    End Function

    Public Function Consultar(ByVal idProveedor As Integer, ByVal numFactura As String) As FacturaProveedor
        If (IsNumeric(numFactura)) Then
            numFactura = Convert.ToInt64(numFactura)
        End If
        Dim sql As String = " SELECT f.* FROM FACTURA_PORPAGAR f INNER JOIN PROVEEDOR p " _
                     & " ON f.Id_Proveedor = p.Id_Proveedor WHERE f.Id_Proveedor = " & idProveedor & " AND REPLACE(f.Num_Factura, '-', '')  like '%" & Regex.Replace(numFactura, "-", "") & "%'"
        Return DevolverFacturaProveedor(sql)
    End Function

    Private Function DevolverFacturaProveedor(ByVal sql As String) As FacturaProveedor
        Dim oDocPorPagar As New FacturaProveedor

        Try
            Dim oDataTable = ConsultarDatos(sql)
            If oDataTable.Rows.Count > 0 Then
                oDocPorPagar = LlenarDatos(oDataTable.Rows(0))
            Else
                oDocPorPagar.IdDocPagar = 0
            End If
        Catch ex As Exception

        End Try
        Return oDocPorPagar
    End Function

    Private Function LlenarDatos(ByVal oRow As DataRow) As FacturaProveedor
        Dim oDocPorPagar As New FacturaProveedor
        oDocPorPagar.IdDocPagar = oRow.Item(0)
        oDocPorPagar.IdProveedor = oRow.Item(1)
        oDocPorPagar.Fecha = oRow.Item(2)
        oDocPorPagar.NumFactura = oRow.Item(3)
        oDocPorPagar.SubTotalIV = oRow.Item(4)
        oDocPorPagar.SubTotalEx = oRow.Item(5)
        oDocPorPagar.IV = oRow.Item(6)
        oDocPorPagar.Total = oRow.Item(7)
        oDocPorPagar.Estado = oRow.Item(8)
        oDocPorPagar.FechaCancelacion = oRow.Item(9)
        oDocPorPagar.FechaIngreso = oRow.Item(10)
        oDocPorPagar.MesTributo = oRow.Item(11)
        oDocPorPagar.Dias = oRow.Item(12)
        oDocPorPagar.Motivo = oRow.Item(13)
        oDocPorPagar.Contado = oRow.Item(14)

        oDocPorPagar.ListaNC = ConsultarNC_IdDocPorPagar(oDocPorPagar.IdDocPagar)
        oDocPorPagar.ListaND = ConsultarNd_IdDocPorPagar(oDocPorPagar.IdDocPagar)
        oDocPorPagar.ListaAbonos = _oAccesoAbonos.ConsultarPor_IdFacturaProveedor(oDocPorPagar.IdDocPagar)
        Return oDocPorPagar
    End Function

    'Anular una factura de un proveedor he inserta el motivo por lo que fue anulado
    Public Sub Anular(ByVal idDocPagar As Integer, ByVal estado As FacturaProveedor.ListaEstado, ByVal motivo As String)
        Dim sql As String = "UPDATE FACTURA_PORPAGAR SET Estado = " & estado & ", Motivo = '" & motivo & "' WHERE Id_DocPagar = " & idDocPagar

        Try
            ModificarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Anulando factura proveedor he insertando motivo")
        End Try
    End Sub

    '**************************************************************CONSULTAS VARIAS********************************

    'Recibe una cadena con los criterios de búsqueda y devuelve una lista de Facturas_Proveedor
    Private Function ConsultarLista(ByVal condicion As String) As List(Of FacturaProveedor)
        Dim sql As String = " SELECT f.* FROM FACTURA_PORPAGAR f INNER JOIN PROVEEDOR p " _
                       & " ON f.Id_Proveedor = p.Id_Proveedor " & condicion
        Dim oLista As New List(Of FacturaProveedor)

        Try
            Dim oDataTable = ConsultarDatos(sql)
            For i = 0 To oDataTable.Rows.Count - 1
                oLista.Add(LlenarDatos(oDataTable.Rows(i)))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando facturas proveedor según criterio")
        End Try

        Return oLista
    End Function

    Public Function ConsultaGeneralLista(ByVal tipo As Integer, Optional ByVal id As Integer = 0,
                                      Optional ByVal fechaInicio As Date = Nothing, Optional ByVal fechaFinal As Date = Nothing,
                                      Optional ByVal estado As Integer = 0) As List(Of FacturaProveedor)
        '1-Id_Proveedor 2-Id_Proveedor,Estado 3-Sin Anular,Id_Proveedor 4- Id_Proveedor,Rango Fechas 
        '5-Sin Anular,Id_Proveedor,RangoFechas 6-Id_Proveedor,RangoFechas,Estado 7-Todas 8-Todas,Sin Anular
        '9-Todas,Estado 10-RangoFechas 11-RangoFechas,Estado 12- Sin Anular Rango Fechas
        Dim condicion As String = ""

        Select Case tipo
            Case 1
                condicion = "WHERE f.Id_Proveedor = " & id & " ORDER BY f.Fecha, f.Num_Factura"
            Case 2
                condicion = "WHERE f.Id_Proveedor = " & id & " AND f.Estado = " & estado & " ORDER BY f.Fecha, f.Num_Factura"
            Case 3
                condicion = "WHERE f.Id_Proveedor = " & id & " AND f.Estado <> 2 ORDER BY f.Fecha, f.Num_Factura"
            Case 4
                condicion = "WHERE f.Id_Proveedor = " & id & " AND f.Fecha  >= '" & fechaInicio.ToString("yyyy-MM-dd") & "' AND f.Fecha <= '" _
                    & fechaFinal.ToString("yyyy-MM-dd") & "' ORDER BY Fecha, Num_Factura"
            Case 5
                condicion = "WHERE f.Id_Proveedor = " & id & " AND f.Estado <> 2 " _
                       & " AND f.Fecha  >= '" & fechaInicio.ToString("yyyy-MM-dd") & "' AND f.Fecha <= '" & fechaFinal.ToString("yyyy-MM-dd") & "'" _
                       & " ORDER BY Fecha, Num_Factura"
            Case 6
                condicion = "WHERE f.Id_Proveedor = " & id & " AND f.Estado = " & estado _
                      & " AND f.Fecha  >= '" & fechaInicio.ToString("yyyy-MM-dd") & "' AND f.Fecha <= '" & fechaFinal.ToString("yyyy-MM-dd") & "'" _
                      & " ORDER BY Fecha, Num_Factura"
            Case 7
                condicion = "ORDER BY p.Nombre ASC, f.Fecha ASC, f.Num_Factura ASC"
            Case 8
                condicion = "WHERE  f.Estado <> 2 ORDER BY p.Nombre ASC, f.Fecha ASC, f.Num_Factura ASC"
            Case 9
                condicion = "WHERE  f.Estado =  " & estado & " ORDER BY p.Nombre ASC, f.Fecha ASC, f.Num_Factura ASC"
            Case 10

                condicion = "WHERE f.Fecha  >= '" & fechaInicio.ToString("yyyy-MM-dd") & "' AND f.Fecha <= '" & fechaFinal.ToString("yyyy-MM-dd") _
                       & " ' AND f.Estado <> 2 ORDER BY p.Nombre ASC, f.Fecha ASC, f.Num_Factura ASC"
            Case 11
                condicion = "WHERE f.Fecha  >= '" & fechaInicio.ToString("yyyy-MM-dd") & "' AND f.Fecha <= '" & fechaFinal.ToString("yyyy-MM-dd") _
                     & " ' AND f.Estado = " & estado & " ORDER BY p.Nombre ASC, f.Fecha ASC, f.Num_Factura ASC"
            Case 12
                condicion = "WHERE f.Fecha  >= '" & fechaInicio.ToString("yyyy-MM-dd") & "' AND f.Fecha <= '" & fechaFinal.ToString("yyyy-MM-dd") _
                      & " ' AND f.Estado <> 2 ORDER BY p.Nombre ASC, f.Fecha ASC, f.Num_Factura ASC"
        End Select

        Return ConsultarLista(condicion)
    End Function

    '***********************************************************************************************************
    '****************************************NOTAS DE CREDITO***************************************************
    '***********************************************************************************************************
    Private Function InicializarParametrosNC(ByVal oComando As MySqlCommand, ByVal oNcDocPorPagar As NCFacturaProveedor) As MySqlCommand
        oComando.Parameters.AddWithValue("@Id_NC", oNcDocPorPagar.IdNC)
        oComando.Parameters.AddWithValue("@Id_DocPorPagar", oNcDocPorPagar.IdDocPorPagar)
        oComando.Parameters.AddWithValue("@Num_NC", oNcDocPorPagar.NumNC)
        oComando.Parameters.AddWithValue("@Total", oNcDocPorPagar.Total)
        oComando.Parameters.AddWithValue("@IV", oNcDocPorPagar.IV)
        oComando.Parameters.AddWithValue("@Motivo", oNcDocPorPagar.Motivo)
        oComando.Parameters.AddWithValue("@BoletaDev", oNcDocPorPagar.BoletaDev)
        oComando.Parameters.AddWithValue("@Fecha", oNcDocPorPagar.Fecha)
        oComando.Parameters.AddWithValue("@FechaBoleta", oNcDocPorPagar.FechaBoleta)
        oComando.Parameters.AddWithValue("@SubTotalIV", oNcDocPorPagar.SubTotalIV)
        oComando.Parameters.AddWithValue("@SubTotalEx", oNcDocPorPagar.SubTotalEx)
        oComando.Parameters.AddWithValue("@PorDescuento", oNcDocPorPagar.PorDescuento)
        Return oComando
    End Function

    Public Function Insertar_NC(ByVal oNcDocPorPagar As NCFacturaProveedor) As Integer
        Const sql As String = "INSERT INTO NC_FACTURAPAGAR (Id_DocPorPagar,Num_NC,Total,IV,Motivo,BoletaDev,Fecha,FechaBoleta,SubTotalIV,SubTotalEx,PorDescuento)" _
                     & " VALUES (@Id_DocPorPagar,@Num_NC,@Total,@IV,@Motivo,@BoletaDev,@Fecha,@FechaBoleta,@SubTotalIV,@SubTotalEx,@PorDescuento); SELECT @@Identity"
        Dim oComando As New MySqlCommand(sql, Conexion)
        oComando = InicializarParametrosNC(oComando, oNcDocPorPagar)

        Try
            Return InsertarDatosDevuelveId(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Insertando NC factura proveedor")
        End Try
        Return 0
    End Function

    Public Sub ModificarNc(ByVal oNcDocPorPagar As NCFacturaProveedor)
        Const sql As String = "UPDATE NC_FACTURAPAGAR SET Num_NC = @Num_NC, Total = @Total, IV=@IV, Motivo=@Motivo , BoletaDev = @BoletaDev, Fecha=@Fecha, FechaBoleta=@FechaBoleta, SubTotalIV = @SubTotalIV, SubTotalEx = @SubTotalEx, PorDescuento = @PorDescuento WHERE Id_NC = @Id_NC"
        Dim oComando As New MySqlCommand(sql, Conexion)
        oComando = InicializarParametrosNC(oComando, oNcDocPorPagar)

        Try
            ModificarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Modificando NC factura proveedor")
        End Try
    End Sub

    'Elimina todas las notas de crédito de una factura proveedor
    Public Sub EliminarTodasNCPor_IdDocPorPagar(ByVal idDocPorPagar As Integer)
        Dim sql As String = "DELETE FROM NC_FACTURAPAGAR WHERE Id_DocPorPagar = " & idDocPorPagar

        Try
            EliminarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Eliminando notas de crédito de una factura proveedor")
        End Try
    End Sub

    'Elimina una nota de crédito que coincida con el Id_DocPorPagar, el NumNC y el Total
    Public Sub EliminarNC(ByVal idNC As Integer)
        Dim sql As String = "DELETE FROM NC_FACTURAPAGAR WHERE Id_NC = " & idNC

        Try
            EliminarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Eliminando NC factura proveedor")
        End Try
    End Sub

    'Retorna una lista con todas las notas de crédito de una factura proveedor
    Public Function ConsultarNC_IdDocPorPagar(ByVal idDocPorPagar As Integer) As List(Of NCFacturaProveedor)
        Dim sql As String = "SELECT * FROM NC_FACTURAPAGAR WHERE Id_DocPorPagar = " & idDocPorPagar
        Dim lista As New List(Of NCFacturaProveedor)

        Try
            Dim oDataTable = ConsultarDatos(sql)

            For i = 0 To oDataTable.Rows.Count - 1
                Dim oNCDocPorPagar = LlenarNC(oDataTable.Rows(i))
                lista.Add(oNCDocPorPagar)
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando notas de crédito de una factura proveedor")
        End Try

        Return lista
    End Function

    Public Function ConsultarNC(ByVal idNC As Integer) As NCFacturaProveedor
        Dim sql As String = "SELECT * FROM NC_FACTURAPAGAR WHERE Id_NC = " & idNC

        Try
            Dim oDataTable = ConsultarDatos(sql)
            Return LlenarNC(oDataTable.Rows(0))
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando nota de crédito de una factura proveedor")
        End Try

        Return Nothing
    End Function

    Private Function LlenarNC(ByVal oRow As DataRow) As NCFacturaProveedor
        Dim oNCDocPorPagar As New NCFacturaProveedor
        oNCDocPorPagar.IdNC = oRow.Item(0)
        oNCDocPorPagar.IdDocPorPagar = oRow.Item(1)
        oNCDocPorPagar.NumNC = oRow.Item(2)
        oNCDocPorPagar.Total = oRow.Item(3)
        oNCDocPorPagar.IV = oRow.Item(4)
        oNCDocPorPagar.Motivo = oRow.Item(5)
        oNCDocPorPagar.BoletaDev = oRow.Item(6)
        oNCDocPorPagar.Fecha = oRow.Item(7)
        oNCDocPorPagar.FechaBoleta = oRow.Item(8)
        oNCDocPorPagar.SubTotalIV = oRow.Item(9)
        oNCDocPorPagar.SubTotalEx = oRow.Item(10)
        oNCDocPorPagar.PorDescuento = oRow.Item(11)
        Return oNCDocPorPagar
    End Function

    'Recibe una cadena con las condiciones de busqueda
    Private Function ConsultarNC(ByVal condicion As String) As DataTable
        Dim sql As String = " SELECT n.Id_NC, n.Num_NC, p.Nombre, n.Fecha, n.Total " _
                        & " FROM nc_facturapagar n INNER JOIN factura_porpagar f " _
                        & " ON n.Id_DocPorPagar = f.Id_DocPagar INNER JOIN proveedor p " _
                        & " ON f.Id_Proveedor = p.Id_Proveedor " & condicion
        Dim oDataTable As New DataTable
        Try
            oDataTable = ConsultarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando NC según criterio")
        End Try

        Return oDataTable
    End Function

    Public Function ConsultaGeneralNC(ByVal tipo As Integer, Optional ByVal num As Integer = 0,
                                      Optional ByVal numFactura As String = "", Optional ByVal fechaInicio As Date = Nothing,
                                      Optional ByVal fechaFinal As Date = Nothing) As DataTable
        '1- Por Num_Factura, 2- Por numero de NC, 3- Todas, 4- Todas Rango Fecha, 
        '5- Por Id_Proveedor, 6- Por Id_Proveedor y Rango Fechas
        Dim condicion As String = ""
        Select Case tipo
            Case 1
                condicion = "WHERE f.Num_Factura LIKE '" & numFactura & "'"
            Case 2
                condicion = "WHERE n.Num_NC =" & num
            Case 3
                condicion = "ORDER BY p.Nombre"
            Case 4
                condicion = "WHERE f.Fecha  >= '" & fechaInicio.ToString("yyyy-MM-dd") & "' AND f.Fecha <= '" _
                    & fechaFinal.ToString("yyyy-MM-dd") & "' ORDER BY p.Nombre"
            Case 5
                condicion = "WHERE  p.Id_Proveedor = " & num & " ORDER BY n.Num_NC"
            Case 6
                condicion = " WHERE p.Id_Proveedor = " & num & " AND f.Fecha  >= '" & fechaInicio.ToString("yyyy-MM-dd") _
                          & "' AND f.Fecha <= '" & fechaFinal.ToString("yyyy-MM-dd") & "' ORDER BY n.Num_NC"
        End Select

        Return ConsultarNC(condicion)
    End Function


    '***********************************************************************************************************
    '****************************************NOTAS DE DEBITO***************************************************
    '***********************************************************************************************************
    Private Function InicializarParametrosND(ByVal oComando As MySqlCommand, ByVal oNdDocPorPagar As NDFacturaProveedor) As MySqlCommand
        oComando.Parameters.AddWithValue("@Id_ND", oNdDocPorPagar.IdND)
        oComando.Parameters.AddWithValue("@Id_DocPorPagar", oNdDocPorPagar.IdDocPorPagar)
        oComando.Parameters.AddWithValue("@Num_ND", oNdDocPorPagar.NumND)
        oComando.Parameters.AddWithValue("@Total", oNdDocPorPagar.Total)
        oComando.Parameters.AddWithValue("@IV", oNdDocPorPagar.IV)
        oComando.Parameters.AddWithValue("@Motivo", oNdDocPorPagar.Motivo)
        oComando.Parameters.AddWithValue("@Boleta", oNdDocPorPagar.Boleta)
        oComando.Parameters.AddWithValue("@Fecha", oNdDocPorPagar.Fecha)
        oComando.Parameters.AddWithValue("@FechaBoleta", oNdDocPorPagar.FechaBoleta)
        oComando.Parameters.AddWithValue("@SubTotalIV", oNdDocPorPagar.SubTotalIV)
        oComando.Parameters.AddWithValue("@SubTotalEx", oNdDocPorPagar.SubTotalEx)
        Return oComando
    End Function

    Public Function Insertar_ND(ByVal oNdDocPorPagar As NDFacturaProveedor) As Integer
        Const sql As String = "INSERT INTO ND_FACTURAPAGAR (Id_DocPorPagar,Num_ND,Total,IV,Motivo,Boleta,Fecha,FechaBoleta,SubTotalIV,SubTotalEx) " _
                    & " VALUES (@Id_DocPorPagar,@Num_ND,@Total,@IV,@Motivo,@Boleta,@Fecha,@FechaBoleta,@SubTotalIV,@SubTotalEx) ; SELECT @@Identity"
        Dim oComando As New MySqlCommand(sql, Conexion)
        oComando = InicializarParametrosND(oComando, oNdDocPorPagar)

        Try
            Return InsertarDatosDevuelveId(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Insertando ND factura proveedor")
        End Try
        Return 0
    End Function

    Public Sub ModificarNd(ByVal oNdDocPorPagar As NDFacturaProveedor)
        Const sql As String = "UPDATE ND_FACTURAPAGAR SET Num_ND = @Num_ND, Total = @Total, IV=@IV, Motivo=@Motivo , Boleta = @Boleta, Fecha=@Fecha, FechaBoleta=@FechaBoleta, SubTotalIV = @SubTotalIV, SubTotalEx = @SubTotalEx WHERE Id_ND = @Id_ND"
        Dim oComando As New MySqlCommand(sql, Conexion)
        oComando = InicializarParametrosND(oComando, oNdDocPorPagar)

        Try
            ModificarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Modificando ND factura proveedor")
        End Try
    End Sub

    'Elimina todas las notas de crédito de una factura proveedor
    Public Sub EliminarTodasNDPor_IdDocPorPagar(ByVal idDocPorPagar As Integer)
        Dim sql As String = "DELETE FROM ND_FACTURAPAGAR WHERE Id_DocPorPagar = " & idDocPorPagar

        Try
            EliminarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Eliminando notas de crédito de una factura proveedor")
        End Try
    End Sub

    'Elimina una nota de débito que coincida con el Id_DocPorPagar, el NumND y el Total
    Public Sub EliminarND(ByVal idNd As Integer)
        Dim sql As String = "DELETE FROM ND_FACTURAPAGAR WHERE Id_ND = " & idNd

        Try
            EliminarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Eliminando ND de una factura proveedor")
        End Try
    End Sub

    'Retorna una lista con todas las notas de débito de una factura proveedor
    Public Function ConsultarNd_IdDocPorPagar(ByVal idDocPorPagar As Integer) As List(Of NDFacturaProveedor)
        Dim sql As String = "SELECT * FROM ND_FACTURAPAGAR WHERE Id_DocPorPagar = " & idDocPorPagar
        Dim lista As New List(Of NDFacturaProveedor)

        Try
            Dim oDataTable = ConsultarDatos(sql)
            For i = 0 To oDataTable.Rows.Count - 1
                Dim oNDDocPorPagar = LlenarND(oDataTable.Rows(i))
                lista.Add(oNDDocPorPagar)
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando todas las ND de una factura proveedor")
        End Try

        Return lista
    End Function

    Public Function ConsultarND(ByVal idND As Integer) As NDFacturaProveedor
        Dim sql As String = "SELECT * FROM ND_FACTURAPAGAR WHERE Id_ND = " & idND

        Try
            Dim oDataTable = ConsultarDatos(sql)
            Return LlenarND(oDataTable.Rows(0))
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando nota de debito de una factura proveedor")
        End Try

        Return Nothing
    End Function

    Public Function LlenarND(ByVal row As DataRow) As NDFacturaProveedor
        Dim oNDDocPorPagar As New NDFacturaProveedor
        oNDDocPorPagar.IdND = row.Item(0)
        oNDDocPorPagar.IdDocPorPagar = row.Item(1)
        oNDDocPorPagar.NumND = row.Item(2)
        oNDDocPorPagar.Total = row.Item(3)
        oNDDocPorPagar.IV = row.Item(4)
        oNDDocPorPagar.Motivo = row.Item(5)
        oNDDocPorPagar.Boleta = row.Item(6)
        oNDDocPorPagar.Fecha = row.Item(7)
        oNDDocPorPagar.FechaBoleta = row.Item(8)
        oNDDocPorPagar.SubTotalIV = row.Item(9)
        oNDDocPorPagar.SubTotalEx = row.Item(10)
        Return oNDDocPorPagar
    End Function

    Public Function ConsultaGeneralND(ByVal tipo As Integer, Optional ByVal num As Integer = 0,
                                      Optional ByVal numFactura As String = "", Optional ByVal fechaInicio As Date = Nothing,
                                      Optional ByVal fechaFinal As Date = Nothing) As DataTable
        '1- Por Num_Factura, 2- Por numero de NC, 3- Todas, 4- Todas Rango Fecha, 
        '5- Por Id_Proveedor, 6- Por Id_Proveedor y Rango Fechas
        Dim condicion As String = ""
        Select Case tipo
            Case 1
                condicion = "WHERE f.Num_Factura LIKE '" & numFactura & "'"
            Case 2
                condicion = "WHERE n.Num_ND =" & num
            Case 3
                condicion = "ORDER BY p.Nombre"
            Case 4
                condicion = "WHERE f.Fecha  >= '" & fechaInicio.ToString("yyyy-MM-dd") & "' AND f.Fecha <= '" _
                    & FechaFinal.ToString("yyyy-MM-dd") & "' ORDER BY p.Nombre"
            Case 5
                condicion = "WHERE  p.Id_Proveedor = " & num & " ORDER BY n.Num_ND"
            Case 6
                condicion = " WHERE p.Id_Proveedor = " & num & " AND f.Fecha  >= '" & fechaInicio.ToString("yyyy-MM-dd") _
                          & "' AND f.Fecha <= '" & FechaFinal.ToString("yyyy-MM-dd") & "' ORDER BY n.Num_ND"
        End Select

        Return ConsultarNd(condicion)
    End Function

    'Recibe una cadena con las condiciones de busqueda
    Private Function ConsultarND(ByVal condicion As String) As DataTable
        Dim sql As String = " SELECT n.Id_ND, n.Num_ND, p.Nombre, n.Fecha, n.Total " _
                        & " FROM nd_facturapagar n INNER JOIN factura_porpagar f " _
                        & " ON n.Id_DocPorPagar = f.Id_DocPagar INNER JOIN proveedor p " _
                        & " ON f.Id_Proveedor = p.Id_Proveedor " & condicion
        Dim oDataTable As New DataTable
        Try
            oDataTable = ConsultarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando ND según criterio")
        End Try

        Return oDataTable
    End Function
End Class