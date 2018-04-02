Namespace Interfaz.Administrativos
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmImpuesto
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
            Me.lblImpuesto = New System.Windows.Forms.Label()
            Me.txtImpuesto = New System.Windows.Forms.TextBox()
            Me.btnGuardar = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'lblImpuesto
            '
            Me.lblImpuesto.AutoSize = True
            Me.lblImpuesto.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblImpuesto.Location = New System.Drawing.Point(12, 64)
            Me.lblImpuesto.Name = "lblImpuesto"
            Me.lblImpuesto.Size = New System.Drawing.Size(67, 18)
            Me.lblImpuesto.TabIndex = 217
            Me.lblImpuesto.Text = "Impuesto"
            '
            'txtImpuesto
            '
            Me.txtImpuesto.Location = New System.Drawing.Point(15, 85)
            Me.txtImpuesto.MaxLength = 4
            Me.txtImpuesto.Name = "txtImpuesto"
            Me.txtImpuesto.Size = New System.Drawing.Size(79, 20)
            Me.txtImpuesto.TabIndex = 218
            Me.txtImpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'btnGuardar
            '
            Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnGuardar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = Global.Presentacion.My.Resources.Resources.Guardar
            Me.btnGuardar.Location = New System.Drawing.Point(0, 0)
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(71, 57)
            Me.btnGuardar.TabIndex = 216
            Me.btnGuardar.Text = "Guardar"
            Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnGuardar.UseVisualStyleBackColor = True
            '
            'FrmImpuesto
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(172, 110)
            Me.Controls.Add(Me.txtImpuesto)
            Me.Controls.Add(Me.lblImpuesto)
            Me.Controls.Add(Me.btnGuardar)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmImpuesto"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Impuesto"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents btnGuardar As System.Windows.Forms.Button
        Friend WithEvents lblImpuesto As System.Windows.Forms.Label
        Friend WithEvents txtImpuesto As System.Windows.Forms.TextBox
    End Class
End Namespace