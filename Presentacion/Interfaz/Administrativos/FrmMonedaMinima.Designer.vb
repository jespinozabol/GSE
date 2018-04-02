Namespace Interfaz.Administrativos
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmMonedaMinima
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
            Me.txtMoneda = New System.Windows.Forms.TextBox()
            Me.lblMoneda = New System.Windows.Forms.Label()
            Me.btnGuardar = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'txtMoneda
            '
            Me.txtMoneda.Location = New System.Drawing.Point(14, 85)
            Me.txtMoneda.MaxLength = 4
            Me.txtMoneda.Name = "txtMoneda"
            Me.txtMoneda.Size = New System.Drawing.Size(79, 20)
            Me.txtMoneda.TabIndex = 222
            Me.txtMoneda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblMoneda
            '
            Me.lblMoneda.AutoSize = True
            Me.lblMoneda.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMoneda.Location = New System.Drawing.Point(11, 64)
            Me.lblMoneda.Name = "lblMoneda"
            Me.lblMoneda.Size = New System.Drawing.Size(60, 18)
            Me.lblMoneda.TabIndex = 221
            Me.lblMoneda.Text = "Moneda"
            '
            'btnGuardar
            '
            Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnGuardar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = Global.Presentacion.My.Resources.Resources.Guardar
            Me.btnGuardar.Location = New System.Drawing.Point(0, 0)
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(71, 57)
            Me.btnGuardar.TabIndex = 220
            Me.btnGuardar.Text = "Guardar"
            Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnGuardar.UseVisualStyleBackColor = True
            '
            'FrmMonedaMinima
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(172, 110)
            Me.Controls.Add(Me.txtMoneda)
            Me.Controls.Add(Me.lblMoneda)
            Me.Controls.Add(Me.btnGuardar)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmMonedaMinima"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Moneda"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents txtMoneda As System.Windows.Forms.TextBox
        Friend WithEvents lblMoneda As System.Windows.Forms.Label
        Friend WithEvents btnGuardar As System.Windows.Forms.Button
    End Class
End Namespace