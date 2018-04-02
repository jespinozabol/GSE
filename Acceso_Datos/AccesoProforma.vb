Imports MySql.Data.MySqlClient
Imports Entidades
Public Class AccesoProforma
    Inherits Transaccion

    Private Sub InicializarParametros(ByVal oComando As MySqlCommand, ByVal oProforma As Proforma)
        oComando.Parameters.AddWithValue("@NumProforma", oProforma.NumProforma)
        oComando.Parameters.AddWithValue("@Nombre_Cliente", oProforma.Cliente)
        oComando.Parameters.AddWithValue("@Fecha", oProforma.Fecha)
        oComando.Parameters.AddWithValue("@Id_Referencia", oProforma.IdReferencia)
        oComando.Parameters.AddWithValue("@Telefono", oProforma.Telefono)
        Return
    End Sub

    Public Sub Insertar(ByVal oProforma As Proforma)
        Const sql As String = "INSERT INTO PROFORMA_ENCABEZADO VALUES (@NumProforma, @Nombre_Cliente, @Fecha,@Id_Referencia, @Telefono)"
        Dim oComando As New MySqlCommand(sql, Conexion)
        InicializarParametros(oComando, oProforma)

        Try
            InsertarDatos(oComando)

            For i As Integer = 0 To oProforma.ProformaDetalles.Count - 1
                Insertar_Detalle(oProforma.ProformaDetalles(i))
            Next i
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Insertando proforma")
        End Try
    End Sub

    Public Sub Modificar(ByVal oProforma As Proforma)
        Const sql As String = "UPDATE PROFORMA_ENCABEZADO SET Nombre_Cliente = @Nombre_Cliente, Fecha = @Fecha, Id_Referencia=@Id_Referencia, Telefono=@Telefono WHERE NumProforma = @NumProforma"
        Dim oComando As New MySqlCommand(sql, Conexion)
        InicializarParametros(oComando, oProforma)

        Try
            ModificarDatos(oComando)

            Eliminar_Detalle(oProforma.NumProforma)

            For i As Integer = 0 To oProforma.ProformaDetalles.Count - 1
                Insertar_Detalle(oProforma.ProformaDetalles(i))
            Next i
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Modificando proforma")
        End Try
    End Sub

    'Cambia un código de producto por un nuevo código
    Public Sub TrasladarCodigoProducto(ByVal idProducto As Long, ByVal idTraslado As Long)
        Dim sql As String = "UPDATE PROFORMA_DETALLE SET Id_Producto = " & idTraslado & " WHERE Id_Producto = " & idProducto
        Try
            ModificarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Trasladando código producto")
        End Try
    End Sub

    Public Function Consultar(ByVal nombre As String) As List(Of Proforma)
        Dim sql As String = "SELECT * FROM PROFORMA_ENCABEZADO WHERE Nombre_Cliente like '%" _
                            & nombre & "%' order by Nombre_Cliente"
        Dim oListaProformas As New List(Of Proforma)
        Try
            Dim oDataTable = ConsultarDatos(sql)
            For i = 0 To oDataTable.Rows.Count - 1
                oListaProformas.Add(LlenarProforma(oDataTable.Rows(i)))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando lista de proformas")
        End Try

        Return oListaProformas
    End Function

    Public Function Consultar(ByVal numProforma As Integer) As Proforma
        Dim sql As String = "SELECT * FROM PROFORMA_ENCABEZADO WHERE NumProforma = " & numProforma
        Dim oProforma As New Proforma
        Try
            Dim oDataTable = ConsultarDatos(sql)
            If oDataTable.Rows.Count > 0 Then
                oProforma = LlenarProforma(oDataTable.Rows(0))
            Else
                oProforma.NumProforma = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando proforma")
        End Try

        Return oProforma
    End Function

    Private Function LlenarProforma(ByVal row As DataRow) As Proforma
        Dim oProforma As New Proforma
        oProforma.NumProforma = row.Item(0)
        oProforma.Cliente = row.Item(1)
        oProforma.Fecha = row.Item(2)
        oProforma.IdReferencia = row.Item(3)
        oProforma.Telefono = row.Item(4)
        oProforma.ProformaDetalles = Consultar_Detalle(oProforma.NumProforma)
        Return oProforma
    End Function

    '******************************************PROFORMA DETALLE****************************************************

    Private Sub InicializarParametrosDetalle(ByVal oComando As MySqlCommand, ByVal oProforma As ProformaDetalle)
        oComando.Parameters.AddWithValue("@Num_Proforma", oProforma.NumProforma)
        oComando.Parameters.AddWithValue("@Id_Producto", oProforma.IdProducto)
        oComando.Parameters.AddWithValue("@PrecioUnitario", oProforma.PrecioUnitario)
        oComando.Parameters.AddWithValue("@Cantidad", oProforma.Cantidad)
        oComando.Parameters.AddWithValue("@Impuesto", oProforma.Impuesto)
        oComando.Parameters.AddWithValue("@Descuento", oProforma.Descuento)
        oComando.Parameters.AddWithValue("@Timpuesto", oProforma.TImpuesto)
        oComando.Parameters.AddWithValue("@Tdescuento", oProforma.TDescuento)
        Return
    End Sub

    Private Sub Insertar_Detalle(ByVal oProformaDetalle As ProformaDetalle)
        Const sql As String = "INSERT INTO PROFORMA_DETALLE VALUES (@Num_Proforma, @Id_Producto, @PrecioUnitario, @Cantidad, @Impuesto,@Descuento, @Timpuesto,@Tdescuento)"
        Dim oComando As New MySqlCommand(sql, Conexion)
        InicializarParametrosDetalle(oComando, oProformaDetalle)

        Try
            InsertarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Insertando proforma detalle")
        End Try
    End Sub

    Private Sub Eliminar_Detalle(ByVal idProforma As Integer)
        Dim sql As String = "DELETE FROM PROFORMA_DETALLE WHERE Num_Proforma = " & idProforma

        Try
            EliminarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Eliminando proforma detalle")
        End Try
    End Sub

    Public Function Consultar_Detalle(ByVal numProforma As Integer) As List(Of ProformaDetalle)
        Dim sql As String = "SELECT * FROM PROFORMA_DETALLE WHERE Num_Proforma = " & numProforma
        Dim oListaDetalle As New List(Of ProformaDetalle)
        Try
            Dim oDataTable = ConsultarDatos(sql)
            For i = 0 To oDataTable.Rows.Count - 1
                oListaDetalle.Add(LlenarDetalle(oDataTable.Rows(i)))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando lista de proformas detalle")
        End Try

        Return oListaDetalle
    End Function

    Private Function LlenarDetalle(ByVal row As DataRow) As ProformaDetalle
        Dim oDetalle As New ProformaDetalle
        oDetalle.NumProforma = row.Item(0)
        oDetalle.IdProducto = row.Item(1)
        oDetalle.PrecioUnitario = row.Item(2)
        oDetalle.Cantidad = row.Item(3)
        oDetalle.Impuesto = row.Item(4)
        oDetalle.Descuento = row.Item(5)
        oDetalle.TImpuesto = row.Item(6)
        oDetalle.TDescuento = row.Item(7)
        Return oDetalle
    End Function

    'Retorna una lista con los datos de los detalles de las lineas, necesario para imprimir 
    Public Function ConsultarDetallesImprimir(ByVal numProforma As Integer) As DataTable
        Dim sql As String = "SELECT d.Cantidad, d.Id_Producto, p.Descripcion, d.Descuento, " _
                          & " d.PrecioUnitario, d.Tdescuento, d.Timpuesto " _
                          & " FROM PROFORMA_DETALLE d INNER JOIN PRODUCTO p ON d.Id_Producto = p.Id_Producto " _
                          & " WHERE d.Num_Proforma = " & numProforma
        Dim oDataTable As New DataTable

        Try
            oDataTable = ConsultarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando lista de proformas detalle que se desean facturar")
        End Try

        Return oDataTable
    End Function

    Function ConsultarPor_IdProducto(ByVal codigo As Integer) As Integer
        Dim sql As String = " SELECT COUNT(*) " _
                    & " FROM PROFORMA_DETALLE " _
                    & " WHERE Id_Producto = " & codigo

        Try
            Dim oDataTable = ConsultarDatos(sql)
            Return oDataTable.Rows(0).Item(0)
        Catch ex As Exception
            Return 0
        End Try
    End Function

End Class