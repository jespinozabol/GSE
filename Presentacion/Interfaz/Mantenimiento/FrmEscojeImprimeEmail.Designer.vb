<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEscojeImprimeEmail
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
        Me.lblImprimir = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblImprimir
        '
        Me.lblImprimir.BackColor = System.Drawing.SystemColors.Control
        Me.lblImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImprimir.Location = New System.Drawing.Point(-1, 20)
        Me.lblImprimir.Name = "lblImprimir"
        Me.lblImprimir.Size = New System.Drawing.Size(340, 32)
        Me.lblImprimir.TabIndex = 0
        Me.lblImprimir.Text = "Imprimir"
        Me.lblImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCorreo
        '
        Me.lblCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.Location = New System.Drawing.Point(-5, 76)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(344, 32)
        Me.lblCorreo.TabIndex = 1
        Me.lblCorreo.Text = "Enviar por correo"
        Me.lblCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmEscojeImprimeEmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 136)
        Me.Controls.Add(Me.lblCorreo)
        Me.Controls.Add(Me.lblImprimir)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmEscojeImprimeEmail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imprimir/Enviar por correo"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblImprimir As System.Windows.Forms.Label
    Friend WithEvents lblCorreo As System.Windows.Forms.Label
End Class
