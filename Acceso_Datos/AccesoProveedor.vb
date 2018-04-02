Imports MySql.Data.MySqlClient
Imports Entidades
Public Class AccesoProveedor
    Inherits Transaccion

    Private Sub InicializarParametros(ByVal oComando As MySqlCommand, ByVal oProvedor As Proveedor)
        oComando.Parameters.AddWithValue("@Id_Proveedor", oProvedor.IdProveedor)
        oComando.Parameters.AddWithValue("@Nombre", oProvedor.Nombre)
        oComando.Parameters.AddWithValue("@Central_Telefonica", oProvedor.CentralTelefonica)
        oComando.Parameters.AddWithValue("@Fax_Principal", oProvedor.FaxPrincipal)
        oComando.Parameters.AddWithValue("@Direccion", oProvedor.Direccion)
        oComando.Parameters.AddWithValue("@Correo_Electronico", oProvedor.Correo)
        oComando.Parameters.AddWithValue("@Cedula", oProvedor.Cedula)
        oComando.Parameters.AddWithValue("@CC", oProvedor.CC)
        oComando.Parameters.AddWithValue("@NCuenta", oProvedor.NCuenta)
        Return
    End Sub

    Public Function Insertar(ByVal oProveedor As Proveedor) As Integer
        Const sql As String = "INSERT INTO PROVEEDOR (Nombre,Central_Telefonica,Fax_Principal,Direccion,Correo_Electronico,Cedula,CC,NCuenta) " _
                              & " VALUES (@Nombre,@Central_Telefonica,@Fax_Principal,@Direccion,@Correo_Electronico,@Cedula,@CC, @NCuenta); SELECT @@Identity"
        Dim oComando As New MySqlCommand(sql, Conexion)
        InicializarParametros(oComando, oProveedor)
        Dim id As Integer

        Try
            id = InsertarDatosDevuelveId(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Insertando proveedor")
            id = 0
        End Try

        Return id
    End Function

    Public Sub Modificar(ByVal oProveedor As Proveedor)
        Const sql As String = "UPDATE PROVEEDOR SET Nombre = @Nombre,Central_Telefonica=@Central_Telefonica,Fax_Principal=@Fax_Principal,Direccion=@Direccion, " _
                              & " Correo_Electronico=@Correo_Electronico,Cedula=@Cedula,CC=@CC, NCuenta=@NCuenta  WHERE Id_Proveedor = @Id_Proveedor"
        Dim oComando As New MySqlCommand(sql, Conexion)
        InicializarParametros(oComando, oProveedor)

        Try
            ModificarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Modificando proveedor")
        End Try
    End Sub

    Public Sub Eliminar(ByVal idProveedor As UShort)
        Dim sql As String = "DELETE QUICK FROM PROVEEDOR WHERE Id_Proveedor = " & idProveedor

        Try
            EliminarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Eliminando proveedor")
        End Try
    End Sub

    'Retorna una tabla con el Id y el nombre de todos los proveedores que cumplen con el patrón de búsqueda.
    Public Function ConsultarNombre(ByVal nombre As String) As DataTable
        Dim sql As String = "SELECT Id_Proveedor,Nombre FROM PROVEEDOR WHERE (Nombre like '%" & nombre & "%') order by Nombre"
        Dim oDataTable As New DataTable

        Try
            oDataTable = ConsultarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando Id, Nombre de proveedores")
        End Try

        Return oDataTable
    End Function

    'Retorna una tabla con el Id y el nombre de todos los proveedores.
    Public Function ConsultarNombre() As DataTable
        Const sql As String = "SELECT Id_Proveedor,Nombre FROM PROVEEDOR order by Nombre"
        Dim oDataTable As New DataTable

        Try
            oDataTable = ConsultarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando Id, Nombre de proveedores")
        End Try

        Return oDataTable
    End Function

    'Retorna una cadena con el nombre del proveedor al que pertene el Id o "" si no existe.
    Public Function ConsultarNombre(ByVal idProveedor As Integer) As String
        Dim sql As String = "SELECT Nombre FROM PROVEEDOR WHERE Id_Proveedor = " & idProveedor
        Dim nombre As String = ""

        Try
            Dim oDataTable = ConsultarDatos(sql)
            If oDataTable.Rows.Count > 0 Then
                nombre = oDataTable.Rows(0).Item(0)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando Id, Nombre de proveedores")
        End Try

        Return nombre
    End Function

    Public Function Consultar(ByVal idProveedor As Integer) As Proveedor
        Dim sql As String = "SELECT * FROM PROVEEDOR WHERE Id_Proveedor = " & idProveedor
        Dim oProveedor As New Proveedor
        Try
            Dim oDataTable = ConsultarDatos(sql)
            If oDataTable.Rows.Count > 0 Then
                oProveedor = LlenarProveedor(oDataTable.Rows(0))
            Else
                oProveedor.IdProveedor = 0
            End If
        Catch ex As Exception

        End Try
        Return oProveedor
    End Function

    Public Function Consultar() As List(Of Proveedor)
        Const sql As String = "SELECT * FROM PROVEEDOR order by Nombre"
        Dim oListaProveedores As New List(Of Proveedor)

        Try
            Dim oDataTable = ConsultarDatos(sql)
            For i = 0 To oDataTable.Rows.Count - 1
                oListaProveedores.Add(LlenarProveedor(oDataTable.Rows(i)))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando proveedor")
        End Try

        Return oListaProveedores
    End Function

    Private Function LlenarProveedor(ByVal row As DataRow) As Proveedor
        Dim oProveedor As New Proveedor
        oProveedor.IdProveedor = row.Item(0)
        oProveedor.Nombre = row.Item(1)
        oProveedor.CentralTelefonica = row.Item(2)
        oProveedor.FaxPrincipal = row.Item(3)
        oProveedor.Direccion = row.Item(4)
        oProveedor.Correo = row.Item(5)
        If IsDBNull(row.Item(6)) Then
            oProveedor.Cedula = ""
        Else
            oProveedor.Cedula = row.Item(6)
        End If
        If IsDBNull(row.Item(7)) Then
            oProveedor.CC = ""
        Else
            oProveedor.CC = row.Item(7)
        End If
        oProveedor.NCuenta = row.Item(8)
        Return oProveedor
    End Function

    'Retorna una tabla con algunos datos del proveedor y su agente
    Public Function ConsultarDatosProveedor(ByVal idProveedor As Integer) As DataTable
        Dim sql As String = "SELECT a.Nombre, a.Telefono1, p.Nombre as Nombre_Proveedor, p.Central_Telefonica, " _
                            & " p.Fax_Principal FROM AGENTE_PROVEEDOR a INNER JOIN PROVEEDOR p" _
                            & " ON a.Id_Proveedor = p.Id_Proveedor WHERE p.Id_Proveedor = " & idProveedor
        Dim oDataTable As New DataTable

        Try
            oDataTable = ConsultarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando datos de proveedor")
        End Try

        Return oDataTable
    End Function

    '************************************************NOTA CREDITO GENERAL***********************************************

    Private Sub InicializarParametrosNCG(ByVal oComando As MySqlCommand, ByVal oNcg As NCProveedorGeneral)
        oComando.Parameters.AddWithValue("@Id_NCG", oNcg.IdNcg)
        oComando.Parameters.AddWithValue("@Id_Proveedor", oNcg.IdProveedor)
        oComando.Parameters.AddWithValue("@Num_NC", oNcg.NumNC)
        oComando.Parameters.AddWithValue("@Total", oNcg.Total)
        oComando.Parameters.AddWithValue("@IV", oNcg.IV)
        oComando.Parameters.AddWithValue("@Motivo", oNcg.Motivo)
        oComando.Parameters.AddWithValue("@Boleta", oNcg.Boleta)
        oComando.Parameters.AddWithValue("@Fecha", oNcg.Fecha)
        oComando.Parameters.AddWithValue("@Fecha_Boleta", oNcg.FechaBoleta)
        oComando.Parameters.AddWithValue("@SubTotalIV", oNcg.SubTotalIV)
        oComando.Parameters.AddWithValue("@SubTotalEx", oNcg.SubTotalEx)
        oComando.Parameters.AddWithValue("@PorDescuento", oNcg.PorDescuento)
        oComando.Parameters.AddWithValue("@Estado", oNcg.Estado)
        Return
    End Sub

    Public Function Insertar_NCG(ByVal oNcProveedorGeneral As NCProveedorGeneral) As Integer
        Const sql As String = "INSERT INTO NC_GENERAL_FACTURAPAGAR  (Id_Proveedor,Num_NC,Total,IV,Motivo,Boleta, " _
                              & " Fecha,Fecha_Boleta,SubTotalIV,SubTotalEx,PorDescuento,Estado) VALUES (@Id_Proveedor,@Num_NC,@Total, " _
                              & " @IV,@Motivo,@Boleta,@Fecha,@Fecha_Boleta,@SubTotalIV,@SubTotalEx,@PorDescuento,@Estado); SELECT @@Identity"
        Dim oComando As New MySqlCommand(sql, Conexion)
        InicializarParametrosNCG(oComando, oNcProveedorGeneral)

        Dim id As Integer
        Try
            id = InsertarDatosDevuelveId(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Insertando nota de crédito general")
        End Try

        Return id
    End Function

    Public Sub Modificar_NCG(ByVal oNcProveedorGeneral As NCProveedorGeneral)
        Const sql As String = "UPDATE NC_GENERAL_FACTURAPAGAR SET Num_NC = @Num_NC, Total = @Total, IV = @IV, Motivo = @Motivo, " _
                              & " Boleta = @Boleta, Fecha = @Fecha, Fecha_Boleta = @Fecha_Boleta, SubTotalIV = @SubTotalIV, " _
                              & " SubTotalEx = @SubTotalEx , Estado = @Estado  WHERE Id_NCG = @Id_NCG"
        Dim oComando As New MySqlCommand(sql, Conexion)
        InicializarParametrosNCG(oComando, oNcProveedorGeneral)

        Try
            ModificarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Modificando nota de crédito general")
        End Try
    End Sub

    Public Sub Eliminar_NCG(ByVal idNcg As Integer)
        Dim sql As String = "DELETE FROM NC_GENERAL_FACTURAPAGAR WHERE Id_NCG = " & idNcg

        Try
            EliminarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Eliminando nota de crédito general")
        End Try
    End Sub

    'Cambia el estado de una nota de crédito
    Public Sub ActualizarEstadoNcg(ByVal idNcg As Integer, ByVal estado As Integer)
        Dim sql As String = "UPDATE NC_GENERAL_FACTURAPAGAR SET Estado = " & estado & "  WHERE Id_NCG = " & idNcg

        Try
            ModificarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Actualizando esta de nota de crédito general")
        End Try
    End Sub

    Public Function ConsultarNCGPor_IdProveedor(ByVal idProveedor As Integer) As List(Of NCProveedorGeneral)
        Dim sql As String = "SELECT * FROM NC_GENERAL_FACTURAPAGAR WHERE Id_Proveedor = " & idProveedor & " AND Estado = 0"
        Dim lista As New List(Of NCProveedorGeneral)

        Try
            Dim oDataTable = ConsultarDatos(sql)
            For i = 0 To oDataTable.Rows.Count - 1
                lista.Add(LlenarNCG(oDataTable.Rows(i)))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando notas de crédito generales")
        End Try

        Return lista
    End Function

    Private Function LlenarNCG(ByVal row As DataRow) As NCProveedorGeneral
        Dim oNcProveedorGeneral As New NCProveedorGeneral
        oNcProveedorGeneral.IdNcg = row.Item(0)
        oNcProveedorGeneral.IdProveedor = row.Item(1)
        oNcProveedorGeneral.NumNC = row.Item(2)
        oNcProveedorGeneral.Total = row.Item(3)
        oNcProveedorGeneral.IV = row.Item(4)
        oNcProveedorGeneral.Motivo = row.Item(5)
        oNcProveedorGeneral.Boleta = row.Item(6)
        oNcProveedorGeneral.Fecha = row.Item(7)
        oNcProveedorGeneral.FechaBoleta = row.Item(8)
        oNcProveedorGeneral.SubTotalIV = row.Item(9)
        oNcProveedorGeneral.SubTotalEx = row.Item(10)
        oNcProveedorGeneral.PorDescuento = row.Item(11)
        oNcProveedorGeneral.Estado = row.Item(12)
        Return oNcProveedorGeneral
    End Function

    Public Function Consultar_NCG(ByVal idNcg As Integer) As NCProveedorGeneral
        Dim sql As String = "SELECT * FROM NC_GENERAL_FACTURAPAGAR WHERE Id_NCG = " & idNcg
        Dim oNcg As New NCProveedorGeneral

        Try
            Dim oDataTable = ConsultarDatos(sql)
            If oDataTable.Rows.Count > 0 Then
                oNcg = LlenarNCG(oDataTable.Rows(0))
            Else
                oNcg.IdNcg = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando nota de crédito general")
        End Try

        Return oNcg
    End Function

    'Retorna una tabla con todas las notas de crédito generales
    Public Function ConsultarDNCG_Todas() As DataTable
        Const sql As String = " SELECT n.Id_NCG, n.Num_NC, p.Nombre, n.Fecha, n.Total " _
                              & " FROM nc_general_facturapagar n INNER JOIN proveedor p " _
                              & " ON n.Id_Proveedor = p.Id_Proveedor ORDER BY p.Nombre"
        Return DevolverResultados(sql)
    End Function

    'Retorna una tabla con todas las notas de crédito generales que esten dentro del rango de fechas.
    Public Function ConsultarDNCG_Todas(ByVal fechaInicio As Date, ByVal fechaFinal As Date) As DataTable
        Dim sql As String = " SELECT n.Id_NCG, n.Num_NC, p.Nombre, n.Fecha, n.Total " _
                        & " FROM nc_general_facturapagar n INNER JOIN proveedor p " _
                        & " ON n.Id_Proveedor = p.Id_Proveedor " _
                        & " WHERE n.Fecha  >= '" & fechaInicio.ToString("yyyy-MM-dd") & "' AND n.Fecha <= '" & fechaFinal.ToString("yyyy-MM-dd") & "'" _
                        & " ORDER BY p.Nombre, n.Fecha "
        Return DevolverResultados(sql)
    End Function

    'Retorna una tabla con todas las notas de crédito generales de un proveedor
    Public Function ConsultarDNCGPor_IdProveedor(ByVal idProveedor As Integer) As DataTable
        Dim sql As String = " SELECT n.Id_NCG, n.Num_NC, p.Nombre, n.Fecha, n.Total " _
                        & " FROM nc_general_facturapagar n INNER JOIN proveedor p " _
                        & " ON n.Id_Proveedor = p.Id_Proveedor " _
                        & " WHERE p.Id_Proveedor = " & idProveedor & " ORDER BY p.Nombre"
        Return DevolverResultados(sql)
    End Function

    'Retorna una tabla con todas las notas de crédito generales de un proveedor y que esten dentro del rango de fechas
    Public Function ConsultarDNCGPor_IdProveedor(ByVal idProveedor As Integer, ByVal fechaInicio As Date, ByVal fechaFinal As Date) As DataTable
        Dim sql As String = " SELECT n.Id_NCG, n.Num_NC, p.Nombre, n.Fecha, n.Total " _
                        & " FROM nc_general_facturapagar n INNER JOIN proveedor p " _
                        & " ON n.Id_Proveedor = p.Id_Proveedor " _
                        & " WHERE p.Id_Proveedor = " & idProveedor _
                        & " AND n.Fecha  >= '" & fechaInicio.ToString("yyyy-MM-dd") & "' AND n.Fecha <= '" & fechaFinal.ToString("yyyy-MM-dd") & "'" _
                        & " ORDER BY p.Nombre"
        Return DevolverResultados(sql)
    End Function

    'Retorna una tabla con la nota de crédito general que tiene ese núm de NC
    Public Function ConsultarDNCGPor_numNC(ByVal numNcg As Integer) As DataTable
        Dim sql As String = " SELECT n.Id_NCG, n.Num_NC, p.Nombre, n.Fecha, n.Total " _
                        & " FROM nc_general_facturapagar n INNER JOIN proveedor p " _
                        & " ON n.Id_Proveedor = p.Id_Proveedor " _
                        & " WHERE n.Num_NC = " & numNCG
        Return DevolverResultados(sql)
    End Function

    Private Function DevolverResultados(ByVal sql As String) As DataTable
        Dim oDataTable As New DataTable

        Try
            oDataTable = ConsultarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando datos de nota de crédito")
        End Try

        Return oDataTable
    End Function
End Class