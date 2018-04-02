Namespace Interfaz
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmReportesComprobantes
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
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

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.crvListado = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.SuspendLayout()
            '
            'crvListado
            '
            Me.crvListado.ActiveViewIndex = -1
            Me.crvListado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.crvListado.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvListado.DisplayBackgroundEdge = False
            Me.crvListado.DisplayStatusBar = False
            Me.crvListado.Dock = System.Windows.Forms.DockStyle.Fill
            Me.crvListado.EnableToolTips = False
            Me.crvListado.Location = New System.Drawing.Point(0, 0)
            Me.crvListado.Margin = New System.Windows.Forms.Padding(0)
            Me.crvListado.Name = "crvListado"
            Me.crvListado.ShowCloseButton = False
            Me.crvListado.ShowCopyButton = False
            Me.crvListado.ShowGotoPageButton = False
            Me.crvListado.ShowGroupTreeButton = False
            Me.crvListado.ShowPageNavigateButtons = False
            Me.crvListado.ShowParameterPanelButton = False
            Me.crvListado.ShowPrintButton = False
            Me.crvListado.ShowRefreshButton = False
            Me.crvListado.ShowTextSearchButton = False
            Me.crvListado.ShowZoomButton = False
            Me.crvListado.Size = New System.Drawing.Size(850, 534)
            Me.crvListado.TabIndex = 0
            Me.crvListado.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'FrmReportesComprobantes
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(850, 534)
            Me.Controls.Add(Me.crvListado)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmReportesComprobantes"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Reporte Listado"
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents crvListado As CrystalDecisions.Windows.Forms.CrystalReportViewer
    End Class
End Namespace