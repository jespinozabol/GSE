Imports Entidades
Imports Acceso_Datos
Public Class LogicaReferencia
    Private ReadOnly _oAccesoReferencia As New AccesoReferencia
    Private ReadOnly _oAccesoInformacionPersonal As New AccesoInformacionPersonal
    Private ReadOnly _oAccesoPersona As New AccesoPersona
    Private ReadOnly _oAccesoFactura As New AccesoFactura

    Public Function ConsultarPorId_Persona(ByVal idPersona As UInteger) As Referencia
        Return _oAccesoReferencia.ConsultarPor_IdPersona(idPersona)
    End Function

    Public Function ConsultarActivos() As DataTable
        Return _oAccesoReferencia.ConsultarPor_Estado(True)
    End Function

    Public Function ConsultarInactivos() As DataTable
        Return _oAccesoReferencia.ConsultarPor_Estado(False)
    End Function

    Public Sub Insertar(ByVal oReferencia As Referencia)
        _oAccesoPersona.Modificar(oReferencia)
        Dim existe = _oAccesoInformacionPersonal.Modificar(oReferencia.OtraInformacion)
        If existe = 0 Then
            _oAccesoInformacionPersonal.Insertar(oReferencia.OtraInformacion)
        End If

        _oAccesoReferencia.Insertar(oReferencia)
    End Sub

    Public Sub ModificarDatos(ByVal oReferencia As Referencia)
        _oAccesoPersona.Modificar(oReferencia)
        _oAccesoInformacionPersonal.Modificar(oReferencia.OtraInformacion)
    End Sub

    Public Sub ModificarRef(ByVal oReferencia As Referencia)
        _oAccesoReferencia.Modificar(oReferencia)
    End Sub

    Public Function ConsultarNombrePor_IdReferencia(ByVal idReferencia As Integer) As String
        Return _oAccesoReferencia.ConsultarNombrePor_IdReferencia(idReferencia)
    End Function

    Public Function Consultar(ByVal idReferencia As Integer) As Referencia
        Return _oAccesoReferencia.Consultar(idReferencia)
    End Function

    Public Sub TrasladarDatosReferencia(ByVal oReferencia As Referencia)
        _oAccesoReferencia.TrasladarDatosReferencia(oReferencia.IdPersona, oReferencia.IdReferencia)
    End Sub

    Public Sub ModificarInfoPersonal(ByVal oReferencia As Referencia)
        'Se intenta modificar los datos de la persona, en caso de que exista se modifican, de lo contrario
        ' se insertan.
        Dim existe = _oAccesoInformacionPersonal.Modificar(oReferencia.OtraInformacion)
        If existe = 0 Then
            _oAccesoInformacionPersonal.Insertar(oReferencia.OtraInformacion)
        End If
    End Sub

    Public Function CalcularReferencia(ByVal idReferencia As Integer, ByVal fechaInicio As Date, ByVal fechaFinal As Date) As Double
        Dim oTblFacturas = _oAccesoReferencia.ConsultarFacturasReferencias(idReferencia, fechaInicio, fechaFinal)
        Dim total As Double

        For i = 0 To oTblFacturas.Rows.Count - 1
            Dim oListaDetalles = _oAccesoFactura.ConsultarDetalle(oTblFacturas.Rows(i).Item(0))

            For j = 0 To oListaDetalles.Count - 1
                total = total + (oListaDetalles(j).PrecioUnitario * oListaDetalles(j).Cantidad)
                total = total - oListaDetalles(j).Tdescuento
            Next
        Next

        Return total
    End Function

    Public Sub guardarUltimo_Calculo(ByVal oBitacora As BitacoraReferencia, ByVal oReferencia As Referencia)
        _oAccesoReferencia.Insertar_Bitacora(oBitacora)
        _oAccesoReferencia.ModificarUltimo_Calculo(oReferencia.IdReferencia, oReferencia.UltimoCalculo)
    End Sub

    Public Function ConsultarBitacoras(ByVal idReferencia As Integer) As List(Of BitacoraReferencia)
        Return _oAccesoReferencia.ConsultarBitacoras(idReferencia)
    End Function

    Public Sub TrasladarPersonaReferencia(ByVal idActual As Integer, ByVal idTrasladar As Integer)
        _oAccesoReferencia.TrasladarReferencia(idActual, idTrasladar)
    End Sub
End Class
