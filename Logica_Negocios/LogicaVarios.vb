Imports Acceso_Datos
Imports System.Net.Mail
Imports System.Net
Imports CrystalDecisions.Shared

Public Class LogicaVarios

    Private ReadOnly _oAccesoVarios As New AccesoVarios

    Public Sub ActualizarFecha(ByVal fecha As Date)
        _oAccesoVarios.ActualizarFecha(fecha)
    End Sub

    Public Sub ActualizarDato(ByVal columna As String, ByVal dato As String)
        _oAccesoVarios.ActualizarDato(columna, dato)
    End Sub

    Public Function ConsultarColumna(ByVal columna As String) As String
        Return _oAccesoVarios.ConsultarDato(columna)
    End Function

    Public Function ConsultarTodo() As DataTable
        Return _oAccesoVarios.Consultar()
    End Function

    Public Sub EnviarEmail(ByVal emails As List(Of String), ByVal asunto As String,
                           ByVal body As String, ByVal adjuntoName As String)
        Dim message = GetMessage(emails, asunto, body, adjuntoName)
        Dim client = GetSmtpClient()
        client.Send(message)
        client.Dispose()
    End Sub

    Public Sub BorrarArchivos(ByVal nombreArchivo As String)
        Dim file As String = String.Format("c:\{0}", nombreArchivo)
        If System.IO.File.Exists(file) = True Then
            System.IO.File.Delete(file)
        End If
    End Sub
    Private Function GetSmtpClient() As SmtpClient
        Dim client = New SmtpClient()
        Dim credenciales = New NetworkCredential(_oAccesoVarios.ConsultarDato("EmailUserName"),
                                                 _oAccesoVarios.ConsultarDato("EmailPassword"))
        client.DeliveryMethod = SmtpDeliveryMethod.Network
        client.UseDefaultCredentials = False
        client.Host = _oAccesoVarios.ConsultarDato("EmailHost")
        client.Credentials = credenciales
        Return client
    End Function

    Private Function GetMessage(ByVal emails As List(Of String), ByVal asunto As String,
                                ByVal body As String, ByVal adjuntoName As String) As MailMessage
        Dim message = New MailMessage()
        Dim archivo = New Attachment(String.Format("c:\{0}", adjuntoName))
        With message
            .Attachments.Add(archivo)
            .Subject = asunto
            .Body = body
            .From = New MailAddress(_oAccesoVarios.ConsultarDato("EmailFrom"), "Soluciones Eléctricas")
            For Each email In emails
                .To.Add(email)
            Next
        End With
        Return message
    End Function

    Public Sub ExportarAPdf(ByVal reporte, ByVal fileName)
        Dim CrExportOptions As ExportOptions
        Dim CrDiskFileDestinationOptions As New DiskFileDestinationOptions()
        Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()
        CrDiskFileDestinationOptions.DiskFileName = String.Format("c:\{0}", Convert.ToString(fileName))
        CrExportOptions = reporte.ExportOptions
        With CrExportOptions
            .ExportDestinationType = ExportDestinationType.DiskFile
            .ExportFormatType = ExportFormatType.PortableDocFormat
            .DestinationOptions = CrDiskFileDestinationOptions
            .FormatOptions = CrFormatTypeOptions
        End With
        reporte.Export()
    End Sub


End Class
