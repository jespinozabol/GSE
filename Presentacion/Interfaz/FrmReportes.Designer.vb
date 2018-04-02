<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.crvReporte = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.btnEmail = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'crvReporte
        '
        Me.crvReporte.ActiveViewIndex = -1
        Me.crvReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvReporte.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvReporte.DisplayBackgroundEdge = False
        Me.crvReporte.DisplayStatusBar = False
        Me.crvReporte.EnableToolTips = False
        Me.crvReporte.Location = New System.Drawing.Point(0, 42)
        Me.crvReporte.Margin = New System.Windows.Forms.Padding(0)
        Me.crvReporte.Name = "crvReporte"
        Me.crvReporte.ShowCloseButton = False
        Me.crvReporte.ShowCopyButton = False
        Me.crvReporte.ShowExportButton = False
        Me.crvReporte.ShowGotoPageButton = False
        Me.crvReporte.ShowGroupTreeButton = False
        Me.crvReporte.ShowLogo = False
        Me.crvReporte.ShowParameterPanelButton = False
        Me.crvReporte.ShowPrintButton = False
        Me.crvReporte.ShowRefreshButton = False
        Me.crvReporte.ShowTextSearchButton = False
        Me.crvReporte.ShowZoomButton = False
        Me.crvReporte.Size = New System.Drawing.Size(876, 503)
        Me.crvReporte.TabIndex = 1
        Me.crvReporte.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'btnEmail
        '
        Me.btnEmail.Image = Global.Presentacion.My.Resources.Resources.email
        Me.btnEmail.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEmail.Location = New System.Drawing.Point(74, 0)
        Me.btnEmail.Name = "btnEmail"
        Me.btnEmail.Size = New System.Drawing.Size(75, 41)
        Me.btnEmail.TabIndex = 3
        Me.btnEmail.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEmail.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = Global.Presentacion.My.Resources.Resources.Imprimir
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimir.Location = New System.Drawing.Point(0, 0)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 41)
        Me.btnImprimir.TabIndex = 2
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'FrmReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 544)
        Me.Controls.Add(Me.btnEmail)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.crvReporte)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmReportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmReportes"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvReporte As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnEmail As System.Windows.Forms.Button
End Class
