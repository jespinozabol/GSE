Imports Logica_Negocios
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine

Public Class FrmReportes

    Private ReadOnly _oLogicaVarios As New LogicaVarios

    Private _datosReporte As DatosReporte
    Public Property DatosReporte() As DatosReporte
        Get
            Return _datosReporte
        End Get
        Set(ByVal value As DatosReporte)
            _datosReporte = value
        End Set
    End Property

    Private Sub FrmReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim respuesta As String
        respuesta = MsgBox(DatosReporte.MsgBoxMensaje, vbInformation + vbYesNo, DatosReporte.MsgBoxTilulo)
        If (respuesta = vbYes) Then
            For Each reporte In DatosReporte.ListaReportes
                reporte.PrintOptions.PrinterName = "\\" & DatosReporte.NombrePC & "\" & DatosReporte.NombreImpresora
                reporte.PrintToPrinter(1, False, 1, 1)
            Next
        End If
    End Sub

    Private Sub btnEmail_Click(sender As Object, e As EventArgs) Handles btnEmail.Click
        Dim reporte = crvReporte.ReportSource
        _oLogicaVarios.ExportarAPdf(reporte, DatosReporte.NombreReporte)
        FrmEmail.lblMostrarAdjuntos.Text = DatosReporte.NombreReporte
        FrmEmail.IdCredito = DatosReporte.Id
        FrmEmail.ShowDialog()
    End Sub

    Private Sub FrmReportes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dispose()
    End Sub
End Class

Public Class DatosReporte

    Private _varMsgBoxMensaje As String
    Public Property MsgBoxMensaje() As String
        Get
            Return _varMsgBoxMensaje
        End Get
        Set(ByVal value As String)
            _varMsgBoxMensaje = value
        End Set
    End Property

    Private _varMsgBoxTilulo As String
    Public Property MsgBoxTilulo() As String
        Get
            Return _varMsgBoxTilulo
        End Get
        Set(ByVal value As String)
            _varMsgBoxTilulo = value
        End Set
    End Property

    Private _varNombreReporte As String
    Public Property NombreReporte() As String
        Get
            Return _varNombreReporte
        End Get
        Set(ByVal value As String)
            _varNombreReporte = value
        End Set
    End Property

    Private _varId As Integer
    Public Property Id() As Integer
        Get
            Return _varId
        End Get
        Set(ByVal value As Integer)
            _varId = value
        End Set
    End Property

    Private _varListaReportes As List(Of ReportDocument)
    Public Property ListaReportes As List(Of ReportDocument)
        Get
            Return _varListaReportes
        End Get
        Set(ByVal value As List(Of ReportDocument))
            _varListaReportes = value
        End Set
    End Property

    Private _varNombrePc As String
    Public Property NombrePC As String
        Get
            Return _varNombrePc
        End Get
        Set(ByVal value As String)
            _varNombrePc = value
        End Set
    End Property

    Private _varNombreImpresora As String
    Public Property NombreImpresora As String
        Get
            Return _varNombreImpresora
        End Get
        Set(ByVal value As String)
            _varNombreImpresora = value
        End Set
    End Property
End Class