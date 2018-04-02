Imports Acceso_Datos
Imports Entidades
Public Class LogicaClienteCredito

    Private ReadOnly _oAccesoClienteCredito As New AccesoClienteCredito
    Private ReadOnly _oAccesoPersona As New AccesoPersona
    Private ReadOnly _oAccesoInformacionPersonal As New AccesoInformacionPersonal
    Private ReadOnly _oAccesoNotasCredito As New AccesoNotaCredito
    Private ReadOnly _oAccesoNotasDebito As New AccesoNotaDebito
    Private ReadOnly _oAccesoFacturaCredito As New AccesoFacturaCredito
    Private ReadOnly _oAccesoAbono As New AccesoAbono
    Private ReadOnly _oAccesoRecibos As New AccesoRecibo
    Private ReadOnly _oLogicaInformacionPersonal As New LogicaPersona
    Private ReadOnly _oAccesoEncargado As New AccesoEncargadoClienteCredito

    Public Sub Insertar(ByVal oCliente As ClienteCredito)
        If oCliente.IdPersona = 0 Then
            Dim oPersona As New Persona
            oPersona.Cedula = oCliente.Cedula
            oPersona.Nombre = oCliente.Nombre
            oPersona.PrimerApellido = oCliente.PrimerApellido
            oPersona.SegundoApellido = oCliente.SegundoApellido

            Dim idPersona = _oAccesoPersona.Insertar(oPersona)
            oCliente.IdPersona = idPersona

            oCliente.FechaCreacion = Now.ToString
            Dim idClienteCredito = _oAccesoClienteCredito.Insertar(oCliente)
            InsertarEncargados(oCliente.Encargados, idClienteCredito)
            oCliente.OtraInformacion.IdPersona = idPersona
            _oAccesoInformacionPersonal.Insertar(oCliente.OtraInformacion)
        ElseIf oCliente.IdCredito = 0 Then
            oCliente.FechaCreacion = Now.ToString
            Dim idClienteCredito = _oAccesoClienteCredito.Insertar(oCliente)
            InsertarEncargados(oCliente.Encargados, idClienteCredito)
            Dim informacion = _oAccesoInformacionPersonal.Consultar(oCliente.IdPersona)

            If informacion.IdPersona = 0 Then
                _oAccesoInformacionPersonal.Insertar(oCliente.OtraInformacion)
            Else
                _oAccesoInformacionPersonal.Modificar(oCliente.OtraInformacion)
            End If
        Else
            _oAccesoClienteCredito.Modificar(oCliente)
            For Each encargado In oCliente.Encargados
                ModificarEncargado(encargado)
            Next
            _oAccesoInformacionPersonal.Modificar(oCliente.OtraInformacion)
        End If
    End Sub

    Private Sub InsertarEncargados(ByVal listaEncargados As List(Of EncargadoClienteCredito), ByVal idClienteCredito As Integer)
        For Each encargado In listaEncargados
            encargado.IdClienteCredito = idClienteCredito
            InsertarEncargado(encargado)
        Next
    End Sub

    Public Sub InsertarBitacora(ByVal oBitacora As Bitacora)
        _oAccesoClienteCredito.Insertar_Bitacora(oBitacora)
    End Sub

    Public Sub EliminarBitacora(ByVal oBitacora As Bitacora)
        _oAccesoClienteCredito.Eliminar_Bitacora(oBitacora.IdCredito, oBitacora.FechaHora)
    End Sub

    Public Sub sumarTotal_Creditos(ByVal oCliente As ClienteCredito)
        _oAccesoClienteCredito.SumarTotalCredito(oCliente.IdCredito, oCliente.TotalCreditos)
    End Sub

    Public Sub restaTotal_Creditos(ByVal oCliente As ClienteCredito)
        _oAccesoClienteCredito.RestarTotalCredito(oCliente.IdCredito, oCliente.TotalCreditos)
    End Sub

    Public Sub actualizarTotal_Credito(ByVal oCliente As ClienteCredito)
        _oAccesoClienteCredito.ModificarTotalCredito(oCliente.IdCredito, oCliente.TotalCreditos)
    End Sub

    Public Sub actualizarDatos_Credito(ByVal oCliente As ClienteCredito)
        _oAccesoClienteCredito.ModificarDatos_Credito(oCliente)
    End Sub

    Public Function ConsultarBitacora(ByVal idCredito As Integer) As List(Of Bitacora)
        Return _oAccesoClienteCredito.ConsultarBitacorasPor_IdCredito(idCredito)
    End Function

    Public Function ConsultarPor_NombreConCredito(ByVal nombre As String) As DataTable
        Return _oAccesoClienteCredito.ConsultarPor_NombreConCredito(nombre)
    End Function

    Public Function ConsultarPorIdPersona(ByVal idPersona As Integer) As ClienteCredito
        Dim oCliente = _oAccesoClienteCredito.ConsultarPor_IdPersona(idPersona)
        If oCliente.IdCredito <> 0 Then
            oCliente.OtraInformacion = _oAccesoInformacionPersonal.Consultar(oCliente.IdPersona)
            oCliente.Encargados = ConsultarEncargadosPorClienteCredito(oCliente.IdCredito)
        End If

        Return oCliente
    End Function

    Public Function consultarIdCliente_PorId_Credito(ByVal idCredito As Integer) As Integer
        Return _oAccesoClienteCredito.ConsultarIdClientePor_IdCredito(idCredito)
    End Function

    Public Function ConsultarPorIdCredito(ByVal idCredito As Integer) As ClienteCredito
        Dim oCliente = _oAccesoClienteCredito.ConsultarPor_IdCredito(idCredito)

        If oCliente.IdCredito <> 0 Then
            oCliente.OtraInformacion = _oAccesoInformacionPersonal.Consultar(oCliente.IdPersona)
            oCliente.Encargados = ConsultarEncargadosPorClienteCredito(oCliente.IdCredito)
        End If

        If oCliente.IdPersona <> 0 Then
            Dim persona = _oAccesoPersona.Consultar(oCliente.IdPersona)
            oCliente.Nombre = persona.Nombre
            oCliente.PrimerApellido = persona.PrimerApellido
            oCliente.SegundoApellido = persona.SegundoApellido
        End If

        Return oCliente
    End Function

    Public Function ConsultarTodos(ByVal enteFisico As Integer, ByVal tipo As Integer, ByVal estado As Integer, ByVal incluirEnCobro As Boolean) As DataTable
        Return _oAccesoClienteCredito.ConsultarVarios(enteFisico, tipo, estado, incluirEnCobro)
    End Function

    Public Function ConsultarTodos_SoloIdCredito() As DataTable
        Return _oAccesoClienteCredito.ConsultarTodos_SoloIdCredito()
    End Function

    Public Sub eliminarCliente_Credito(ByVal idClienteCredito As Integer, ByVal idCliente As Integer)
        _oAccesoClienteCredito.Eliminar_Bitacoras(idClienteCredito)
        _oAccesoNotasCredito.EliminarNCG(idClienteCredito)

        Dim oListaFacturasCredito = _oAccesoFacturaCredito.ConsultarPor_IdCredito(idClienteCredito)

        For i As Integer = 0 To oListaFacturasCredito.Count - 1
            _oAccesoAbono.EliminarPorNumDocYTipo(oListaFacturasCredito(i).NumFactura, Abono.ListaTipoDoc.FACT)
            _oAccesoNotasCredito.Eliminar(oListaFacturasCredito(i).NumFactura)
            _oAccesoFacturaCredito.Eliminar(oListaFacturasCredito(i).NumFactura)
        Next

        _oAccesoRecibos.Eliminar_IdCredito(idClienteCredito)
        EliminarEncargadosPorIdCliente(idClienteCredito)
        _oAccesoClienteCredito.Eliminar(idClienteCredito)

        _oLogicaInformacionPersonal.eliminarInformacion_Personal(idCliente)
    End Sub

    Public Sub TrasladarCredito(ByVal idActual As Integer, ByVal idTrasladar As Integer)
        _oAccesoClienteCredito.TrasladarCredito(idActual, idTrasladar)
    End Sub

    Public Sub UnirCredito(ByVal idCreditoActual As Integer, ByVal idCreditoTrasladar As Integer)
        _oAccesoClienteCredito.TrasladarBitacoras(idCreditoActual, idCreditoTrasladar)
        _oAccesoFacturaCredito.TrasladarFacturas(idCreditoActual, idCreditoTrasladar)
        _oAccesoRecibos.TrasladarRecibo(idCreditoActual, idCreditoTrasladar)
        _oAccesoNotasCredito.TrasladarGenerales(idCreditoActual, idCreditoTrasladar)
        _oAccesoNotasDebito.TrasladarGenerales(idCreditoActual, idCreditoTrasladar)
        _oAccesoEncargado.TrasladarEncargados(idCreditoActual, idCreditoTrasladar)
        _oAccesoClienteCredito.Eliminar(idCreditoTrasladar)
    End Sub

    Public Sub TrasladarEncargados(ByVal idActual As Integer, ByVal idTrasladar As Integer)
        _oAccesoEncargado.TrasladarEncargados(idActual, idTrasladar)
    End Sub

    Public Sub TrasladarEncargado(ByVal idActual As Integer, ByVal idEncargado As Integer)
        _oAccesoEncargado.TrasladarEncargado(idActual, idEncargado)
    End Sub

    Public Function ConsultarTotalCreditos() As Double
        Return _oAccesoClienteCredito.ConsultarTotalCreditos
    End Function

    Sub ModificarBloqueo(ByVal idCliente As Integer, ByVal valor As Integer)
        _oAccesoClienteCredito.ModificarBloqueo(idCliente, valor)
    End Sub

    Sub DesbloquearTodos()
        _oAccesoClienteCredito.DesbloquearTodos()
    End Sub


    '**********************************Encargados*****************************
    Public Sub EliminarEncargado(ByVal idEncargado As Integer)
        _oAccesoEncargado.Eliminar(idEncargado)
    End Sub

    Public Sub EliminarEncargadosPorIdCliente(ByVal idCredito As Integer)
        _oAccesoEncargado.EliminarPorCliente(idCredito)
    End Sub

    Public Sub InsertarEncargado(ByVal encargado As EncargadoClienteCredito)
        _oAccesoEncargado.Insertar(encargado)
    End Sub

    Public Sub ModificarEncargado(ByVal encargado As EncargadoClienteCredito)
        _oAccesoEncargado.Modificar(encargado)
    End Sub

    Public Function ConsultarEncargadosPorClienteCredito(ByVal idCredito) As List(Of EncargadoClienteCredito)
        Return _oAccesoEncargado.ConsultarPor_IdClienteCredito(idCredito)
    End Function

    Public Function ConsultarEncargado(ByVal idEncargado) As EncargadoClienteCredito
        Return _oAccesoEncargado.Consultar(idEncargado)
    End Function
End Class
