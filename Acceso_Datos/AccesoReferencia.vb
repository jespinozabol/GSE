Imports MySql.Data.MySqlClient
Imports Entidades
Public Class AccesoReferencia
    Inherits Transaccion

    Private ReadOnly _oAccesoPersona As New AccesoPersona

    Private Function InicializarParametros(ByVal oComando As MySqlCommand, ByVal oReferencia As Referencia)
        oComando.Parameters.AddWithValue("@Id_Referencia", oReferencia.IdReferencia)
        oComando.Parameters.AddWithValue("@Id_Persona", oReferencia.IdPersona)
        oComando.Parameters.AddWithValue("@Activo", oReferencia.Activo)
        oComando.Parameters.AddWithValue("@Ultimo_Calculo", oReferencia.UltimoCalculo)
        Return oComando
    End Function

    Public Sub Insertar(ByVal oReferencia As Referencia)
        Const sql As String = "INSERT INTO REFERENCIA (Id_Persona,Activo) VALUES (@Id_Persona,@Activo)"
        Dim oComando As New MySqlCommand(sql, Conexion)
        InicializarParametros(oComando, oReferencia)

        Try
            InsertarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Insertando referencia")
        End Try
    End Sub

    Public Sub Modificar(ByVal oReferencia As Referencia)
        Const sql As String = "UPDATE REFERENCIA SET Id_Persona = @Id_Persona,Activo = @Activo WHERE Id_Referencia = @Id_Referencia"
        Dim oComando As New MySqlCommand(sql, Conexion)
        InicializarParametros(oComando, oReferencia)

        Try
            ModificarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Modificando referencia")
        End Try
    End Sub

    'Actualiza la fecha del último calculo de referencia
    Public Sub ModificarUltimo_Calculo(ByVal idReferencia As Integer, ByVal ultimoCalculo As Date)
        Dim sql As String = "UPDATE REFERENCIA SET Ultimo_Calculo = '" & ultimoCalculo.ToString("yyyy-MM-dd") & "' WHERE Id_Referencia = " & idReferencia

        Try
            ModificarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Modificando fecha del último cálculo de la referencia")
        End Try
    End Sub

    Public Sub Eliminar(ByVal idReferencia As UShort)
        Dim sql As String = "DELETE QUICK FROM REFERENCIA WHERE Id_Referencia = " & idReferencia

        Try
            EliminarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Public Function ConsultarPor_IdPersona(ByVal idPersona As String) As Referencia
        Dim sql As String = "SELECT * FROM REFERENCIA WHERE Id_Persona = " & idPersona
        Dim oReferencia As New Referencia

        Try
            Dim oDataTable = ConsultarDatos(sql)
            If oDataTable.Rows.Count > 0 Then
                oReferencia = LlenarReferencia(oDataTable.Rows(0))
            Else
                oReferencia.IdReferencia = 0
            End If
            Return oReferencia
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando referencia")
        End Try
        Return oReferencia
    End Function

    Private Function LlenarReferencia(ByVal row As DataRow) As Referencia
        Dim oReferencia As New Referencia
        oReferencia.IdReferencia = row.Item(0)
        oReferencia.IdPersona = row.Item(1)
        oReferencia.Activo = row.Item(2)
        If Not IsDBNull(row.Item(3)) Then
            oReferencia.UltimoCalculo = row.Item(3)
        End If
        Return oReferencia
    End Function

    Function Consultar(ByVal idReferencia As Integer) As Referencia
        Dim sql As String = "SELECT * FROM REFERENCIA WHERE Id_Referencia = " & idReferencia
        Dim oReferencia As New Referencia

        Try
            Dim oDataTable = ConsultarDatos(sql)
            If oDataTable.Rows.Count > 0 Then
                Dim oPersona As Persona
                oPersona = _oAccesoPersona.Consultar(oDataTable.Rows(0).Item(1))
                oReferencia = LlenarReferencia(oDataTable.Rows(0))
                oReferencia.Nombre = oPersona.Nombre
                oReferencia.PrimerApellido = oPersona.PrimerApellido
                oReferencia.SegundoApellido = oPersona.SegundoApellido
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando la referencia")
        End Try

        Return oReferencia
    End Function

    'Retorna una cadena con el nombre a al que esta asignado la referencia de ventas.
    Public Function ConsultarNombrePor_IdReferencia(ByVal idReferencia As Integer) As String
        Dim sql As String = "SELECT Id_Persona FROM REFERENCIA WHERE Id_Referencia = " & idReferencia & " AND Activo= 1"

        Try
            Dim oDataTable = ConsultarDatos(sql)
            If oDataTable.Rows.Count > 0 Then
                Dim oPersona As Persona
                oPersona = _oAccesoPersona.Consultar(oDataTable.Rows(0).Item(0))
                Return oPersona.Nombre + " " + oPersona.PrimerApellido + " " + oPersona.SegundoApellido
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando nombre del cliente que tiene la referencia")
        End Try

        Return ""
    End Function

    'Retorna una tabla con todas las referencias con el estado escogido
    Public Function ConsultarPor_Estado(ByVal estado As Boolean) As DataTable
        Dim sql As String = "SELECT r.Id_Referencia, p.Id_Persona, p.Nombre, p.Apellido1, p.Apellido2" _
                            & " FROM PERSONA p INNER JOIN REFERENCIA r ON p.Id_Persona = r.Id_Persona" _
                            & " WHERE r.Activo = " & Estado
        Dim oDataTable As New DataTable

        Try
            oDataTable = ConsultarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando datos de las referencias por estado")
        End Try

        Return oDataTable
    End Function

    'Traslada los datos de la referencia de un cliente a otro.
    Public Sub TrasladarDatosReferencia(ByVal idPersona As Integer, ByVal idReferencia As Integer)
        Dim sql As String = "UPDATE FACTURA_ENCABEZADO SET Id_Referencia = 1 WHERE Id_Referencia = " & idReferencia
        Dim sql2 As String = "UPDATE PROFORMA_ENCABEZADO SET Id_Referencia = 1 WHERE Id_Referencia = " & idReferencia
        Dim sql3 As String = "UPDATE REFERENCIA SET Id_PERSONA = " & idPersona & " WHERE Id_Referencia = " & idReferencia

        Try
            ModificarDatos(sql)
            ModificarDatos(sql2)
            ModificarDatos(sql3)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Trasladando referencia")
        End Try
    End Sub

    'Retorna una tabla con todas las facturas que están asignadas a una referencia en un lapso de tiempo.
    Public Function ConsultarFacturasReferencias(ByVal idReferencia As Integer, ByVal fechaInicio As Date, ByVal fechaFinal As Date) As DataTable
        Dim sql As String = " SELECT FACTURA_ENCABEZADO.Num_Factura FROM REFERENCIA INNER JOIN " _
                         & " FACTURA_ENCABEZADO ON REFERENCIA.Id_Referencia = FACTURA_ENCABEZADO.Id_Referencia " _
                         & " WHERE (REFERENCIA.Id_Referencia = " & idReferencia & ") AND (FACTURA_ENCABEZADO.Anulada = 0) " _
                         & " AND (FACTURA_ENCABEZADO.Fecha >= '" & fechaInicio.ToString("yyyy-MM-dd") & "') AND (FACTURA_ENCABEZADO.Fecha <= '" & fechaFinal.ToString("yyyy-MM-dd") & "')"
        Dim oDataTable As New DataTable
        Try
            oDataTable = ConsultarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando facturas para calculo referencia")
        End Try

        Return oDataTable
    End Function

    'Traslada toda la referencia de un cliente a otro.
    Public Sub TrasladarReferencia(ByVal idActual As Integer, ByVal idTrasladar As Integer)
        Dim sql As String = "UPDATE REFERENCIA SET Id_Persona = " & idActual & " WHERE Id_Persona = " & idTrasladar

        Try
            ModificarDatos(sql)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Trasladando la referencia a otra persona")
        End Try
    End Sub

    '************************************************BITACORAS***********************************************

    Public Sub Insertar_Bitacora(ByVal oBitacora As BitacoraReferencia)
        Const sql As String = "INSERT INTO BITACORA_REFERENCIA VALUES (@Id_Referencia,@Linea1,@Linea2)"
        Dim oComando As New MySqlCommand(sql, Conexion)
        oComando.Parameters.AddWithValue("@Id_Referencia", oBitacora.IdReferencia)
        oComando.Parameters.AddWithValue("@Linea1", oBitacora.Linea1)
        oComando.Parameters.AddWithValue("@Linea2", oBitacora.Linea2)

        Try
            InsertarDatos(oComando)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Insertando bitacora")
        End Try
    End Sub

    'Retorna una lista con todas las bitacoras de una persona con referencia
    Public Function ConsultarBitacoras(ByVal idReferencia As Integer) As List(Of BitacoraReferencia)
        Dim sql As String = "SELECT * FROM BITACORA_REFERENCIA WHERE Id_Referencia = " & idReferencia
        Dim lista As New List(Of BitacoraReferencia)
        Try
            Dim oDataTable = ConsultarDatos(sql)
            For i = 0 To oDataTable.Rows.Count - 1
                Dim bitacora As New BitacoraReferencia
                bitacora.IdReferencia = oDataTable.Rows(i).Item(0)
                bitacora.Linea1 = oDataTable.Rows(i).Item(1)
                bitacora.Linea2 = oDataTable.Rows(i).Item(2)
                lista.Add(bitacora)
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Consultando bitacoras de una referencia")
        End Try

        Return lista
    End Function
End Class