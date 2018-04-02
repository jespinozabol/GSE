<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRespaldo
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
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.btnCopiaSeguridad = New System.Windows.Forms.Button()
        Me.carpeta = New System.Windows.Forms.OpenFileDialog()
        Me.Respaldar = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Location = New System.Drawing.Point(220, 34)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(75, 23)
        Me.btnRestaurar.TabIndex = 0
        Me.btnRestaurar.Text = "Restaurar"
        Me.btnRestaurar.UseVisualStyleBackColor = True
        '
        'btnCopiaSeguridad
        '
        Me.btnCopiaSeguridad.Location = New System.Drawing.Point(220, 124)
        Me.btnCopiaSeguridad.Name = "btnCopiaSeguridad"
        Me.btnCopiaSeguridad.Size = New System.Drawing.Size(145, 23)
        Me.btnCopiaSeguridad.TabIndex = 1
        Me.btnCopiaSeguridad.Text = "Copia Seguridad"
        Me.btnCopiaSeguridad.UseVisualStyleBackColor = True
        '
        'carpeta
        '
        Me.carpeta.FileName = "carpeta"
        '
        'FrmRespaldo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 271)
        Me.Controls.Add(Me.btnCopiaSeguridad)
        Me.Controls.Add(Me.btnRestaurar)
        Me.Name = "FrmRespaldo"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRestaurar As System.Windows.Forms.Button
    Friend WithEvents btnCopiaSeguridad As System.Windows.Forms.Button
    Friend WithEvents carpeta As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Respaldar As System.Windows.Forms.SaveFileDialog

End Class
