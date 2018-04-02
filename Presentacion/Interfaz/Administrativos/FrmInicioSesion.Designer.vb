Namespace Interfaz.Administrativos
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmInicioSesion
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
            Me.gbInicioSesion = New System.Windows.Forms.GroupBox()
            Me.txtContraseña = New System.Windows.Forms.TextBox()
            Me.lblContraseña = New System.Windows.Forms.Label()
            Me.gbInicioSesion.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbInicioSesion
            '
            Me.gbInicioSesion.BackColor = System.Drawing.Color.Transparent
            Me.gbInicioSesion.Controls.Add(Me.txtContraseña)
            Me.gbInicioSesion.Controls.Add(Me.lblContraseña)
            Me.gbInicioSesion.Location = New System.Drawing.Point(32, 11)
            Me.gbInicioSesion.Name = "gbInicioSesion"
            Me.gbInicioSesion.Size = New System.Drawing.Size(200, 51)
            Me.gbInicioSesion.TabIndex = 3
            Me.gbInicioSesion.TabStop = False
            Me.gbInicioSesion.Text = "Iniciar Sesión"
            '
            'txtContraseña
            '
            Me.txtContraseña.Location = New System.Drawing.Point(86, 23)
            Me.txtContraseña.Name = "txtContraseña"
            Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.txtContraseña.Size = New System.Drawing.Size(100, 20)
            Me.txtContraseña.TabIndex = 2
            '
            'lblContraseña
            '
            Me.lblContraseña.AutoSize = True
            Me.lblContraseña.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.lblContraseña.Location = New System.Drawing.Point(16, 26)
            Me.lblContraseña.Name = "lblContraseña"
            Me.lblContraseña.Size = New System.Drawing.Size(64, 13)
            Me.lblContraseña.TabIndex = 1
            Me.lblContraseña.Text = "Contraseña:"
            '
            'FrmInicioSesion
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(265, 73)
            Me.Controls.Add(Me.gbInicioSesion)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmInicioSesion"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Iniciar Sesión"
            Me.gbInicioSesion.ResumeLayout(False)
            Me.gbInicioSesion.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents gbInicioSesion As System.Windows.Forms.GroupBox
        Friend WithEvents txtContraseña As System.Windows.Forms.TextBox
        Friend WithEvents lblContraseña As System.Windows.Forms.Label
    End Class
End Namespace