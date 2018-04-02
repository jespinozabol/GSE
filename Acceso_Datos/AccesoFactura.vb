Imports MySql.Data.MySqlClient
Imports Entidades
Public Class AccesoFactura
    Inherits Transaccion

    Private Sub InicializarParametros(ByVal oComando As MySqlCommand, ByVal oFactura As Factura)
        oComando.Parameters.AddWithValue("@Num_Factura", oFactura.NumFactura)
        oComando.Parameters.AddWithValue("@Id_Persona", oFactura.IdPersona)
        oComando.Parameters.AddWithValue("@Id_Referencia", oFactura.IdReferencia)
        oComando.Parameters.AddWithValue("@Contado", oFactura.Contado)
        oComando.Parameters.AddWithValue("@Fecha", oFactura.Fecha)
        oComando.Parameters.AddWithValue("@Anulada", oFactura.Anulada)
        oComando.Parameters.AddWithValue("@Ganancia", oFactura.Ganancia)
        Return
    End Sub

    Private Sub InicializarParametrosDetalle(ByVal oComando As MySqlCommand, ByVal oFacturaDetalle As FacturaDetalle)
        oComando.Parameters.AddWithValue("@Num_Factura", oFacturaDetalle.NumFactura)
        oComando.Parameters.AddWithValue("@Id_Producto", oFacturaDetalle.Id_Producto)
        oComando.Parameters.AddWithValue("@Descripcion", oFacturaDetalle.Descripcion)
        oComando.Parameters.AddWithValue("@PrecioUnitario", oFacturaDetalle.PrecioUnitario)
        oComando.Parameters.AddWithValue("@Cantidad", oFacturaDetalle.Cantidad)
        oComando.Parameters.AddWithValue("@Impuesto", oFacturaDetalle.Impuesto)
        oComando.Parameters.AddWithValue("@Descuento", oFacturaDetalle.Descuento)
        oComando.Parameters.AddWithValue("@Timpuesto", oFacturaDetalle.TImpuesto)
        oComando.Parameters.AddWithValue("@Tdescuento", oFacturaDetalle.TDescuento)
        Return
    End Sub

    Public Sub Insertar(ByVal oFactura As Factura)
        Const sql As String = "INSERT INTO FACTURA_ENCABEZADO VALUES (@Num_Factura, @Id_Persona, @Id_Referencia, @Contado, @Fecha, @Anulada,@Ganancia)"
        Dim oComando As New MySqlCommand(sql, Conexion)
        InicializarParametros(oComando, oFactura)

        Try
            InsertarDatos(oComando)

            For i As Integer = 0 To oFactura.FacturaDetalles.Count - 1
                Insertar_Detalle(oFactura.FacturaDetalles(i))
            Next i

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Insertando factura")
        End Try
    End Sub

    Private Sub Insertar_Detalle(ByVal oFacturaDetalle As FacturaDetalle)
        Const sql As String = "INSERT INTO FACTURA_DETALLE (Num_Factura,Id_Producto,Descripcion,PrecioUnitario,Cantidad,Impuesto,Descuento,Timpuesto,Tdescuento) " _
                              & " VALUES (@Num_Factura, @Id_Producto, @Descripcion, @PrecioUnitario, @Cantidad, @Impuesto,@Descuento, @Timpuesto,@Tdescuento)"
        Dim oComando As New MySqlCommand(sql, Conexion)
        InicializarParametrosDetalle(oComando, oFacturaDetalle)

        Try
            InsertarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Insertando factura detalle")
        End Try
    End Sub

    'Modifica la ganancia de una factura
    Public Sub ModificarGanancia(ByVal ganancia As Double, ByVal numFactura As Long)
        Dim sql As String = "UPDATE FACTURA_ENCABEZADO SET Ganancia = " & ganancia & " WHERE Num_Factura = " & numFactura

        Try
            ModificarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Modificando la ganancia de una factura")
        End Try
    End Sub

    'Cambia un código de producto por el nuevo código
    Public Sub TrasladarCodigoProducto(ByVal idProducto As Long, ByVal idTraslado As Long)
        Dim sql As String = "UPDATE FACTURA_DETALLE SET Id_Producto = " & idTraslado & " WHERE Id_Producto = " & idProducto
        Try
            ModificarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Trasladando código producto")
        End Try
    End Sub

    'Retorna una factura con el num de factura o 0 si no existe.
    Public Function Consultar(ByVal numFactura As Integer) As Factura
        Dim sql As String = "SELECT * FROM FACTURA_ENCABEZADO WHERE Num_Factura = " & numFactura
        Dim oFactura As New Factura

        Try
            Dim oDataTable = ConsultarDatos(sql)
            If oDataTable.Rows.Count > 0 Then
                oFactura = LlenarFacturaEncabezado(oDataTable(0))
                oFactura.FacturaDetalles = ConsultarDetalle(oFactura.NumFactura)
            Else
                oFactura.NumFactura = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando factura")
        End Try

        Return oFactura
    End Function

    'Retorna una lista con todas las lineas de una factura
    Public Function ConsultarDetalle(ByVal numFactura As Integer) As List(Of FacturaDetalle)
        Dim sql As String = "SELECT * FROM FACTURA_DETALLE WHERE Num_Factura = " & numFactura
        Dim oListaFactDetalle As New List(Of FacturaDetalle)

        Try
            Dim oDataTable = ConsultarDatos(sql)
            For i = 0 To oDataTable.Rows.Count - 1
                oListaFactDetalle.Add(LlenarDetalle(oDataTable.Rows(i)))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando factura detalle")
        End Try

        Return oListaFactDetalle
    End Function

    'Agrega la referencia a una factura por el numero de factura
    Public Sub AsignarReferencia(ByVal numFactura As Integer, ByVal idReferencia As Integer)
        Dim sql As String = "UPDATE FACTURA_ENCABEZADO SET Id_Referencia = " & idReferencia & " WHERE Num_Factura = " & numFactura

        Try
            ModificarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Public Sub Anular(ByVal numFactura As Long)
        Dim sql As String = "UPDATE FACTURA_ENCABEZADO SET Anulada = '1' WHERE Num_Factura = " & numFactura

        Try
            ModificarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Anulando una factura")
        End Try
    End Sub

    'Retorna una factura y el nombre del cliente al que pertenece por el número de factura
    Public Function ConsultarPor_NumFactura_ConNombre(ByVal numFactura As Integer) As DataTable
        Dim sql As String = "SELECT f.*, p.Nombre, p.Apellido1, p.Apellido2 " _
                          & " FROM FACTURA_ENCABEZADO f INNER JOIN " _
                          & " PERSONA p ON f.Id_Persona = p.Id_Persona " _
                          & " WHERE f.Num_Factura = " & numFactura
        Dim oDataTable As New DataTable
        Try
            oDataTable = ConsultarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando una factura con el nombre del cliente")
        End Try

        Return oDataTable
    End Function

    'Retorna una factura y el nombre del cliente al que pertenece por el id del cliente
    Public Function ConsultarPor_IdPersona_ConNombre(ByVal idPersona As Integer) As DataTable
        Dim sql As String = "SELECT f.*, p.Nombre, p.Apellido1, p.Apellido2 " _
                          & " FROM FACTURA_ENCABEZADO f INNER JOIN " _
                          & " PERSONA p ON f.Id_Persona = p.Id_Persona " _
                          & " WHERE f.Id_Persona = " & idPersona

        Dim oDataTable As New DataTable
        Try
            oDataTable = ConsultarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando una factura con el nombre del cliente")
        End Try

        Return oDataTable
    End Function

    'Retorna algunos datos necesario de una factura que se desea anular
    Public Function ConsultarFacturaAnular(ByVal numFactura As Integer) As DataTable
        Dim sql As String = "SELECT f.Num_Factura, f.Anulada, p.Nombre, p.Apellido1, p.Apellido2 " _
                          & " FROM FACTURA_ENCABEZADO f INNER JOIN " _
                          & " PERSONA p ON f.Id_Persona = p.Id_Persona " _
                          & " WHERE f.Num_Factura = " & numFactura
        Dim oDataTable As New DataTable
        Try
            oDataTable = ConsultarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando algunos datos de una factura")
        End Try

        Return oDataTable
    End Function

    'Retorna un entero con el número de facturas que se han realizado al nombre de un cliente
    Public Function ConsultarCantidadFacturasContado(ByVal idPersona As Integer) As Integer
        Dim sql As String = " SELECT COUNT(*) AS Cantidad " _
                         & " FROM FACTURA_ENCABEZADO " _
                         & " WHERE Contado = 1 GROUP BY Id_Persona " _
                         & " HAVING Id_Persona = " & idPersona

        Try
            Dim oDataTable = ConsultarDatos(sql)
            Return oDataTable.Rows(0).Item(0)
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function ConsultarPor_IdProducto(ByVal codigo As Integer) As Integer
        Dim sql As String = " SELECT COUNT(*) " _
                        & " FROM FACTURA_DETALLE " _
                        & " WHERE Id_Producto = " & codigo

        Try
            Dim oDataTable = ConsultarDatos(sql)
            Return oDataTable.Rows(0).Item(0)
        Catch ex As Exception
            Return 0
        End Try
    End Function

    'Retorna la Fecha de la última compra de un cliente
    Public Function ConsultarUltimaCompra(ByVal idPersona As Integer) As String
        Dim sql As String = " SELECT Fecha " _
                        & " FROM FACTURA_ENCABEZADO " _
                        & " WHERE Id_Persona = " & idPersona _
                        & " ORDER BY Fecha DESC LIMIT 1"

        Try
            Dim oDataTable = ConsultarDatos(sql)
            Return oDataTable.Rows(0).Item(0).ToString
        Catch ex As Exception
            Return ""
        End Try
    End Function

    'Retorna una lista de facturas de un cliente en un rango de fechas especificado
    Public Function ConsultarPor_IdPersonaRango(ByVal idPersona As Integer, ByVal fechainicio As Date, ByVal fechaFin As Date) As List(Of Factura)
        Dim sql As String = "SELECT * FROM FACTURA_ENCABEZADO WHERE Id_Persona = " & idPersona & " and Anulada = 0 and Fecha >= '" & fechainicio.ToString("yyyy-MM-dd") & "' and Fecha <= '" & fechaFin.ToString("yyyy-MM-dd") & "'"
        Dim oListaFactura As New List(Of Factura)

        Try
            Dim oDataTable = ConsultarDatos(sql)

            For i = 0 To oDataTable.Rows.Count - 1
                oListaFactura.Add(LlenarFacturaEncabezado(oDataTable.Rows(i)))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando facturas por rango fechas")
        End Try

        Return oListaFactura
    End Function

    'Traslada todas las facturas de un cliente a otro.
    Public Sub TrasladarFacturas(ByVal idActual As Integer, ByVal idTrasladar As Integer)
        Dim sql As String = "UPDATE FACTURA_ENCABEZADO SET Id_Persona = " & idActual & " WHERE Id_Persona = " & idTrasladar

        Try
            ModificarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Trasladando facturas a otro cliente")
        End Try
    End Sub

    Private Function LlenarFacturaEncabezado(ByVal row As DataRow) As Factura
        Dim oFactura As New Factura
        oFactura.NumFactura = row.Item(0)
        oFactura.IdPersona = row.Item(1)
        oFactura.IdReferencia = row.Item(2)
        oFactura.Contado = row.Item(3)
        oFactura.Fecha = row.Item(4)
        oFactura.Anulada = row.Item(5)
        oFactura.Ganancia = row.Item(6)
        Return oFactura
    End Function

    Private Function LlenarDetalle(ByVal row As DataRow) As FacturaDetalle
        Dim oFacturaDetalle As New FacturaDetalle
        oFacturaDetalle.IdFacturaDet = row.Item(0)
        oFacturaDetalle.NumFactura = row.Item(1)
        oFacturaDetalle.Id_Producto = row.Item(2)
        oFacturaDetalle.Descripcion = row.Item(3)
        oFacturaDetalle.PrecioUnitario = row.Item(4)
        oFacturaDetalle.Cantidad = row.Item(5)
        oFacturaDetalle.Impuesto = row.Item(6)
        oFacturaDetalle.Descuento = row.Item(7)
        oFacturaDetalle.TImpuesto = row.Item(8)
        oFacturaDetalle.TDescuento = row.Item(9)
        Return oFacturaDetalle
    End Function

    '*******************************************CONTROL DE IMPRESION******************************************
    Public Sub InsertarCtrlImpFact(ByVal numFactura As Long, ByVal nombrePc As String)
        Const sql As String = "INSERT INTO CONTROLIMPFACTURA VALUES (@Num_Factura, @NombrePC)"
        Dim oComando As New MySqlCommand(sql, Conexion)

        oComando.Parameters.AddWithValue("@Num_Factura", numFactura)
        oComando.Parameters.AddWithValue("@NombrePC", nombrePC)

        Try
            InsertarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Insertando CONTROLIMPFACTURA")
        End Try
    End Sub

    Public Sub EliminarCtrlImpFact(ByVal nombrePc As String)
        Dim sql As String = "DELETE FROM CONTROLIMPFACTURA WHERE NombrePC = '" & NombrePC & "'"

        Try
            EliminarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Eliminando CONTROLIMPFACTURA")
        End Try
    End Sub

    Public Function ConsultarCtrlImpFact(ByVal nombrePc As String) As DataTable
        Dim sql As String = "SELECT * FROM CONTROLIMPFACTURA WHERE NombrePC = '" & NombrePC & "'"
        Dim oDatatable As New DataTable
        Try
            oDatatable = ConsultarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando CONTROLIMPFACTURA de un Equipo")
        End Try
        Return oDatatable
    End Function

End Class
