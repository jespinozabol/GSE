Imports MySql.Data.MySqlClient
Imports Entidades
Public Class AccesoListado
    Inherits Transaccion

    '***********************************************************************************************************
    '****************************************LISTADO HISTORIAL**************************************************

    Private Sub InicializarParametrosHistorial(ByVal oComando As MySqlCommand, ByVal oListadoHistorial As ListadoHistorial)
        oComando.Parameters.AddWithValue("@Id_Listado", oListadoHistorial.IdListado)
        oComando.Parameters.AddWithValue("@Id_Producto", oListadoHistorial.Id_Producto)
        oComando.Parameters.AddWithValue("@Cantidad", oListadoHistorial.Cantidad)
        oComando.Parameters.AddWithValue("@Fecha", oListadoHistorial.Fecha)
        oComando.Parameters.AddWithValue("@Retiro", oListadoHistorial.Retira)
        oComando.Parameters.AddWithValue("@Hora", oListadoHistorial.Hora)
        Return
    End Sub

    Public Sub Insertar_Historial(ByVal oListadoHistorial As ListadoHistorial)
        Const sql As String = "INSERT INTO LISTADO_HISTORIAL VALUES (@Id_Listado, @Id_Producto, @Cantidad, @Fecha, @Retiro, @Hora)"
        Dim oComando As New MySqlCommand(sql, Conexion)
        InicializarParametrosHistorial(oComando, oListadoHistorial)

        Try
            InsertarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Insertando Listado Historial")
        End Try
    End Sub

    'Cambia un código de producto por un nuevo código
    Public Sub TrasladarCodigoProducto_Historial(ByVal idProducto As Long, ByVal idTraslado As Long)
        Dim sql As String = "UPDATE LISTADO_HISTORIAL SET Id_Producto = " & idTraslado & " WHERE Id_Producto = " & idProducto
        Try
            ModificarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Trasladando código producto")
        End Try
    End Sub

    Private Sub Eliminar_Historial(ByVal idListado As Integer)
        Dim sql As String = "DELETE FROM LISTADO_HISTORIAL WHERE Id_Listado = " & idListado

        Try
            EliminarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Eliminando Listado Historial")
        End Try
    End Sub

    'Retorna una lista con el historial de cierto producto en un listado.
    Public Function Consultar_Historial(ByVal idListado As Integer, ByVal idProducto As Integer) As List(Of ListadoHistorial)
        Dim sql As String = "SELECT * FROM LISTADO_HISTORIAL WHERE Id_Listado = " & idListado & " AND Id_Producto = " & idProducto
        Return DevolverListaHistoriales(sql)
    End Function

    'Retornatodo el historial de los productos de un listadio.
    Public Function Consultar_Historial(ByVal idListado As Integer) As List(Of ListadoHistorial)
        Dim sql As String = "SELECT * FROM LISTADO_HISTORIAL WHERE Id_Listado = " & idListado
        Return DevolverListaHistoriales(sql)
    End Function

    Private Function DevolverListaHistoriales(ByVal sql) As List(Of ListadoHistorial)
        Dim oLista As New List(Of ListadoHistorial)

        Try
            Dim oDataTable = ConsultarDatos(sql)

            If oDataTable.Rows.Count > 0 Then
                For i = 0 To oDataTable.Rows.Count - 1
                    oLista.Add(LlenarHistorial(oDataTable.Rows(i)))
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando lista de historiales")
        End Try

        Return oLista
    End Function

    Private Function LlenarHistorial(ByVal row As DataRow) As ListadoHistorial
        Dim oHistorial As New ListadoHistorial
        oHistorial.IdListado = row.Item(0)
        oHistorial.Id_Producto = row.Item(1)
        oHistorial.Cantidad = row.Item(2)
        oHistorial.Fecha = row.Item(3)
        oHistorial.Retira = row.Item(4)
        oHistorial.Hora = row.Item(5)
        Return oHistorial
    End Function

    '***********************************************************************************************************
    '****************************************LISTADO RESUMEN****************************************************

    Private Sub InicializarParametrosResumen(ByVal oComando As MySqlCommand, ByVal oListadoResumen As ListadoResumen)
        oComando.Parameters.AddWithValue("@Id_Listado", oListadoResumen.IdListado)
        oComando.Parameters.AddWithValue("@Id_Producto", oListadoResumen.Id_Producto)
        oComando.Parameters.AddWithValue("@Cantidad", oListadoResumen.Cantidad)
        Return
    End Sub

    Public Sub Insertar_Resumen(ByVal oListadoResumen As ListadoResumen)
        Const sql As String = "INSERT INTO LISTADO_RESUMEN VALUES (@Id_Listado, @Id_Producto, @Cantidad)"
        Dim oComando As New MySqlCommand(sql, Conexion)
        InicializarParametrosResumen(oComando, oListadoResumen)

        Try
            InsertarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Insertando listado resumen")
        End Try
    End Sub

    Private Sub Eliminar_Resumen(ByVal idListado As Integer)
        Dim sql As String = "DELETE FROM LISTADO_RESUMEN WHERE Id_Listado = " & idListado

        Try
            EliminarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Eliminando listado resumen")
        End Try
    End Sub

    'Retorna las existencias de un producto en los listados que no han sido facturados
    Public Function ConsultarExistenciasPor_IdProducto(ByVal idProducto As Long) As Double
        Dim sql As String = " SELECT SUM(lr.Cantidad) AS suma " _
                          & " FROM LISTADO_RESUMEN lr INNER JOIN LISTADO_ENCABEZADO le ON " _
                          & " lr.Id_Listado = le.Id_Listado WHERE le.Impreso = 0" _
                          & " GROUP BY lr.Id_Producto HAVING lr.Id_Producto = " & idProducto

        Try
            Dim oDataTable = ConsultarDatos(sql)
            If oDataTable.Rows.Count > 0 Then
                Return oDataTable.Rows(0).Item(0)
            Else
                Return 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando existencias de producto")
            Return 0
        End Try
    End Function

    Public Function Consultar_Resumen(ByVal idListado As Integer) As List(Of ListadoResumen)
        Dim sql As String = "SELECT * FROM LISTADO_RESUMEN WHERE Id_Listado = " & idListado
        Dim oLista As New List(Of ListadoResumen)

        Try
            Dim oDataTable = ConsultarDatos(sql)

            For i = 0 To oDataTable.Rows.Count - 1
                Dim oResumen As New ListadoResumen
                oResumen.IdListado = oDataTable.Rows(i).Item(0)
                oResumen.Id_Producto = oDataTable.Rows(i).Item(1)
                oResumen.Cantidad = oDataTable.Rows(i).Item(2)
                oLista.Add(oResumen)
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando listado resumen")
        End Try

        Return oLista
    End Function

    '***********************************************************************************************************
    '****************************************LISTADO AUTORIZADO**************************************************

    Private Function InicializarParametrosListadoAutorizado(ByVal oComando As MySqlCommand, ByVal oListadoAutorizado As ListadoAutorizado) As MySqlCommand
        oComando.Parameters.AddWithValue("@Id_Listado", oListadoAutorizado.IdListado)
        oComando.Parameters.AddWithValue("@Id_Autorizado", oListadoAutorizado.IdAutorizado)
        oComando.Parameters.AddWithValue("@Nombre", oListadoAutorizado.Nombre)
        oComando.Parameters.AddWithValue("@Telf", oListadoAutorizado.Telefono)
        Return oComando
    End Function

    Public Sub Insertar_Autorizado(ByVal oListadoAutorizado As ListadoAutorizado)
        Const sql As String = "INSERT INTO LISTADO_AUTORIZADO (Id_Listado,Nombre,Telf, Activo) VALUES (@Id_Listado, @Nombre, @Telf, 1)"
        Dim oComando As New MySqlCommand(sql, Conexion)
        oComando = InicializarParametrosListadoAutorizado(oComando, oListadoAutorizado)

        Try
            InsertarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Insertando listado autorizado")
        End Try
    End Sub

    Private Sub Modificar_Autorizado(ByVal oListadoAutorizado As ListadoAutorizado)
        Const sql As String = "UPDATE LISTADO_AUTORIZADO SET Nombre = @Nombre , Telf= @Telf WHERE Id_Autorizado = @Id_Autorizado"
        Dim oComando As New MySqlCommand(sql, Conexion)
        oComando = InicializarParametrosListadoAutorizado(oComando, oListadoAutorizado)

        Try
            ModificarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "A Modificando listado autorizado")
        End Try
    End Sub

    'Elimina todos los autorizados de un listado
    Private Sub Eliminar_Autorizados(ByVal idListado As Integer)
        Dim sql As String = "DELETE FROM LISTADO_AUTORIZADO WHERE Id_Listado = " & idListado

        Try
            EliminarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Eliminando listado autorizado")
        End Try
    End Sub

    'Cambiar el estado de activo a inactivo en un autorizado de un listado
    Public Sub Inactivar_Autorizado(ByVal idAutorizado As Integer)
        Dim sql As String = "UPDATE LISTADO_AUTORIZADO SET Activo = 0 WHERE Id_Autorizado = " & idAutorizado

        Try
            ModificarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Inactivando listado autorizado")
        End Try
    End Sub

    'Retorna una lista de los autorizados de un listado que cumplan con el criterio "Activo" o "Inactivo"
    Public Function Consultar_Autorizados(ByVal idListado As Integer, ByVal activo As Boolean) As List(Of ListadoAutorizado)
        Dim sql = "SELECT * FROM LISTADO_AUTORIZADO WHERE Id_Listado = " & idListado & " AND Activo = 1"
        Dim oLista As New List(Of ListadoAutorizado)

        Try
            Dim oDataTable = ConsultarDatos(sql)

            For i = 0 To oDataTable.Rows.Count - 1
                oLista.Add(LlenarAutorizado(oDataTable.Rows(i)))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando listados autorizados")
        End Try

        Return oLista
    End Function

    Public Function Consultar_Autorizado(ByVal idAutorizado As Integer) As ListadoAutorizado
        Dim sql As String = "SELECT * FROM LISTADO_AUTORIZADO WHERE Id_Autorizado = " & idAutorizado
        Dim oListadoAutorizado As New ListadoAutorizado

        Try
            Dim oDataTable = ConsultarDatos(sql)
            If oDataTable.Rows.Count > 0 Then
                oListadoAutorizado = LlenarAutorizado(oDataTable.Rows(0))
            Else
                oListadoAutorizado.IdAutorizado = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando listado autorizado")
        End Try

        Return oListadoAutorizado
    End Function

    Private Function LlenarAutorizado(ByVal row As DataRow) As ListadoAutorizado
        Dim oAutorizado As New ListadoAutorizado
        oAutorizado.IdAutorizado = row.Item(0)
        oAutorizado.IdListado = row.Item(1)
        oAutorizado.Nombre = row.Item(2)
        oAutorizado.Telefono = row.Item(3)
        oAutorizado.Activo = row.Item(4)
        Return oAutorizado
    End Function

    '***********************************************************************************************************
    '****************************************LISTADO************************************************************

    Private Function InicializarParametros(ByVal oComando As MySqlCommand, ByVal oListado As Listado) As MySqlCommand
        oComando.Parameters.AddWithValue("@Id_Listado", oListado.IdListado)
        oComando.Parameters.AddWithValue("@Nombre_Cliente", oListado.NombreCliente)
        oComando.Parameters.AddWithValue("@Telefono", oListado.Telefono)
        oComando.Parameters.AddWithValue("@Total_Listado", oListado.TotalListado)
        oComando.Parameters.AddWithValue("@Fecha", oListado.Fecha)
        oComando.Parameters.AddWithValue("@Impreso", False)
        oComando.Parameters.AddWithValue("@Bloqueo", False)
        Return oComando
    End Function

    Public Sub Insertar(ByVal oListado As Listado)
        Const sql As String = "INSERT INTO LISTADO_ENCABEZADO (Nombre_Cliente,Telefono,Total_Listado,Fecha,Impreso, Bloqueo) VALUES (@Nombre_Cliente, @Telefono, @Total_Listado,@Fecha,@Impreso, @Bloqueo); SELECT @@Identity"
        Dim oComando As New MySqlCommand(sql, Conexion)
        oComando = InicializarParametros(oComando, oListado)

        Try
            Dim id = InsertarDatosDevuelveId(oComando)
            InsertarOtrosListados(oListado, id)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Insertando listado")
        End Try
    End Sub

    Public Sub Modificar(ByVal oListado As Listado)
        Const sql As String = "UPDATE LISTADO_ENCABEZADO SET Nombre_Cliente = @Nombre_Cliente,Telefono = @Telefono,Total_Listado = @Total_Listado WHERE Id_Listado = @Id_Listado"
        Dim oComando As New MySqlCommand(sql, Conexion)
        oComando = InicializarParametros(oComando, oListado)

        Try
            ModificarDatos(oComando)
            Eliminar_Resumen(oListado.IdListado)
            InsertarOtrosListados(oListado, oListado.IdListado)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Modificando listado")
        End Try
    End Sub

    'Método que recibe un listado, su Id, agrega el Id a los demás tipos de listados y los inserta
    Private Sub InsertarOtrosListados(ByVal oListado As Listado, ByVal id As Integer)
        'Recorre la lista de autorizados les actualiza su Id_Listado y revisa si el Id_Autorizado es cero
        ' significa que es nuevo, sino lo modifica.
        For i As Integer = 0 To oListado.ListaAutorizados.Count - 1
            oListado.ListaAutorizados(i).IdListado = id
            If oListado.ListaAutorizados(i).IdAutorizado = 0 Then
                Insertar_Autorizado(oListado.ListaAutorizados(i))
            Else
                Modificar_Autorizado(oListado.ListaAutorizados(i))
            End If
        Next i

        For i As Integer = 0 To oListado.ListaResumen.Count - 1
            oListado.ListaResumen(i).IdListado = id
            Insertar_Resumen(oListado.ListaResumen(i))
        Next i

        For j As Integer = 0 To oListado.ListaHistorial.Count - 1
            oListado.ListaHistorial(j).IdListado = id
            Insertar_Historial(oListado.ListaHistorial(j))
        Next j
    End Sub

    'Cambia el valor de un listado a "Bloqueado" o "Desbloqueado" según se indique
    Public Sub ModificarBloqueo(ByVal idListado As Integer, ByVal bloqueo As Integer)
        Dim sql As String = "UPDATE LISTADO_ENCABEZADO SET Bloqueo = " & bloqueo & " WHERE Id_Listado = " & idListado

        Try
            ModificarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Modificando bloqeo listado")
        End Try
    End Sub

    'Pone el listado como facturado, y agrega la fecha de impresión.
    Public Sub ActualizaAImpreso(ByVal idListado As Integer)
        Dim fecha As Date = Now.Date
        Dim sql As String = "UPDATE LISTADO_ENCABEZADO SET Impreso = '1', Fecha_Impreso = '" & fecha.ToString("yyyy-MM-dd") & "' WHERE Id_Listado = " & idListado

        Try
            ModificarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Actualizando listado como facturado")
        End Try
    End Sub

    'Elimina todos los datos de un listado
    Public Sub Eliminar(ByVal listado As Integer)
        Dim sql As String = "DELETE FROM LISTADO_ENCABEZADO WHERE Id_Listado = " & listado

        Try
            Eliminar_Autorizados(listado)
            Eliminar_Resumen(listado)
            Eliminar_Historial(listado)
            EliminarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Eliminando listado")
        End Try
    End Sub

    'Retorna los datos necesarios para mandarlo a la ventana facturacion
    Public Function ConsultarListadoImprimir(ByVal idListado As Integer) As DataTable
        Dim sql As String = " SELECT r.Cantidad, r.Id_Producto, p.Descripcion, p.PrecioUnitario, p.Ganancia, " _
                          & " p.Impuesto, e.Id_Listado FROM LISTADO_ENCABEZADO e INNER JOIN " _
                          & " LISTADO_RESUMEN r ON e.Id_Listado = r.Id_Listado INNER JOIN " _
                          & " PRODUCTO p ON r.Id_Producto = p.Id_Producto WHERE e.Id_Listado = " & idListado
        Dim oDataTable As New DataTable

        Try
            oDataTable = ConsultarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando listado imprimir")
        End Try
        Return oDataTable
    End Function

    'Consulta todos los listados que concuerden con el nombre y que no esten facturados.
    Public Function Consultar(ByVal nombre As String) As List(Of Listado)
        Dim sql As String = "SELECT * FROM LISTADO_ENCABEZADO WHERE Nombre_Cliente like '%" _
                            & nombre & "%' AND Impreso = '0' order by Nombre_Cliente"
        Return DevolverListados(sql)
    End Function

    Public Function Consultar(ByVal idListado As Integer) As Listado
        Dim sql As String = "SELECT * FROM LISTADO_ENCABEZADO WHERE Id_Listado = " & idListado & " AND Impreso = '0'"
        Dim oListado As New Listado

        Try
            Dim oDataTable = ConsultarDatos(sql)
            If oDataTable.Rows.Count > 0 Then
                oListado = LlenarListado(oDataTable.Rows(0))
            Else
                oListado.IdListado = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando listado")
        End Try

        Return oListado
    End Function

    Public Function ConsultarTodosPorId(ByVal idListado As Integer) As Listado
        Dim sql As String = "SELECT * FROM LISTADO_ENCABEZADO WHERE Id_Listado = " & idListado
        Dim oListado As New Listado

        Try
            Dim oDataTable = ConsultarDatos(sql)
            If oDataTable.Rows.Count > 0 Then
                oListado = LlenarListado(oDataTable.Rows(0))
            Else
                oListado.IdListado = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando listado")
        End Try

        Return oListado
    End Function

    'Retorna una lista con todos los listados facturados
    Public Function ConsultarFacturados(ByVal fecha As Date) As List(Of Listado)
        Dim sql As String = "SELECT * FROM LISTADO_ENCABEZADO WHERE Impreso = '1' AND Fecha_Impreso < '" & fecha & "'"
        Return DevolverListados(sql)
    End Function

    'Retorna una lista con algunos datos de todos los listados sin facturar
    Public Function ConsultarTodosSinFacturar() As DataTable
        Const sql As String = "SELECT Id_Listado,Fecha,Nombre_Cliente,Telefono,Total_Listado FROM LISTADO_ENCABEZADO WHERE Impreso = '0'"
        Dim oDataTable As New DataTable

        Try
            oDataTable = ConsultarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando algunos datos de todos los listados sin facturar")
        End Try

        Return oDataTable
    End Function

    'Retorna una lista con algunos datos de todos los listados facturados
    Public Function ConsultarTodosFacturados() As DataTable
        Const sql As String = "SELECT Id_Listado,Fecha_Impreso,Nombre_Cliente,Telefono,Total_Listado FROM LISTADO_ENCABEZADO WHERE Impreso = '1'"
        Dim oDataTable As New DataTable

        Try
            oDataTable = ConsultarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando algunos datos de todos los listados impresos")
        End Try

        Return oDataTable
    End Function

    Private Function DevolverListados(ByVal sql As String) As List(Of Listado)
        Dim oListaListados As New List(Of Listado)

        Try
            Dim oDataTable = ConsultarDatos(sql)
            For i = 0 To oDataTable.Rows.Count - 1
                oListaListados.Add(LlenarListado(oDataTable.Rows(i)))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando listado")
        End Try

        Return oListaListados
    End Function

    Private Function LlenarListado(ByVal row As DataRow) As Listado
        Dim oListado As New Listado
        oListado.IdListado = row.Item(0)
        oListado.NombreCliente = row.Item(1)
        oListado.Telefono = row.Item(2)
        oListado.TotalListado = row.Item(3)
        oListado.Fecha = row.Item(4)
        oListado.Bloqueo = row.Item(7)

        oListado.ListaAutorizados = Consultar_Autorizados(oListado.IdListado, 1)
        oListado.ListaResumen = Consultar_Resumen(oListado.IdListado)
        Return oListado
    End Function

    Public Function ConsultarHistorialPor_IdProducto(ByVal codigo As Integer) As Integer
        Dim sql As String = " SELECT COUNT(*) " _
                      & " FROM LISTADO_HISTORIAL " _
                      & " WHERE Id_Producto = " & codigo

        Try
            Dim oDataTable = ConsultarDatos(sql)
            Return oDataTable.Rows(0).Item(0)
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function ConsultarResumenPor_IdProducto(ByVal codigo As Integer) As Integer
        Dim sql As String = " SELECT COUNT(*) " _
                    & " FROM LISTADO_RESUMEN " _
                    & " WHERE Id_Producto = " & codigo

        Try
            Dim oDataTable = ConsultarDatos(sql)
            Return oDataTable.Rows(0).Item(0)
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function ConsultarListadosResumenPor_IdProducto(ByVal codigo As Integer) As DataTable
        Dim sql As String = " SELECT * " _
                    & " FROM LISTADO_RESUMEN " _
                    & " WHERE Id_Producto = " & codigo
        Try
            Return ConsultarDatos(sql)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class