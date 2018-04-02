Namespace Interfaz
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class msgAutomatico
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
            Me.components = New System.ComponentModel.Container()
            Me.btnAceptar = New System.Windows.Forms.Button()
            Me.lblMensaje = New System.Windows.Forms.Label()
            Me.timerCerrar = New System.Windows.Forms.Timer(Me.components)
            Me.SuspendLayout()
            '
            'btnAceptar
            '
            Me.btnAceptar.Location = New System.Drawing.Point(182, 74)
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
            Me.btnAceptar.TabIndex = 0
            Me.btnAceptar.Text = "Aceptar"
            Me.btnAceptar.UseVisualStyleBackColor = True
            '
            'lblMensaje
            '
            Me.lblMensaje.Location = New System.Drawing.Point(12, 34)
            Me.lblMensaje.Name = "lblMensaje"
            Me.lblMensaje.Size = New System.Drawing.Size(257, 23)
            Me.lblMensaje.TabIndex = 1
            '
            'timerCerrar
            '
            Me.timerCerrar.Enabled = True
            Me.timerCerrar.Interval = 700
            '
            'msgAutomatico
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(281, 109)
            Me.Controls.Add(Me.lblMensaje)
            Me.Controls.Add(Me.btnAceptar)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "msgAutomatico"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Soluciones Eléctricas"
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents btnAceptar As System.Windows.Forms.Button
        Friend WithEvents lblMensaje As System.Windows.Forms.Label
        Friend WithEvents timerCerrar As System.Windows.Forms.Timer
    End Class
End Namespace