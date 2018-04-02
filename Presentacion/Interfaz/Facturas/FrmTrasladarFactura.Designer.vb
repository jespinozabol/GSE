Namespace Interfaz.Facturas
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmTrasladarFactura
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
            Me.Label1 = New System.Windows.Forms.Label()
            Me.btnProforma = New System.Windows.Forms.Button()
            Me.btnListado = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(68, 9)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(110, 26)
            Me.Label1.TabIndex = 127
            Me.Label1.Text = "Trasladar A"
            '
            'btnProforma
            '
            Me.btnProforma.Location = New System.Drawing.Point(27, 51)
            Me.btnProforma.Name = "btnProforma"
            Me.btnProforma.Size = New System.Drawing.Size(75, 23)
            Me.btnProforma.TabIndex = 128
            Me.btnProforma.Text = "Proforma"
            Me.btnProforma.UseVisualStyleBackColor = True
            '
            'btnListado
            '
            Me.btnListado.Location = New System.Drawing.Point(149, 51)
            Me.btnListado.Name = "btnListado"
            Me.btnListado.Size = New System.Drawing.Size(75, 23)
            Me.btnListado.TabIndex = 129
            Me.btnListado.Text = "Listado"
            Me.btnListado.UseVisualStyleBackColor = True
            '
            'FrmTrasladarFactura
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(249, 84)
            Me.Controls.Add(Me.btnListado)
            Me.Controls.Add(Me.btnProforma)
            Me.Controls.Add(Me.Label1)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmTrasladarFactura"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "FrmTrasladarFactura"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents btnProforma As System.Windows.Forms.Button
        Friend WithEvents btnListado As System.Windows.Forms.Button
    End Class
End Namespace