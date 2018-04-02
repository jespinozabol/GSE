Namespace Interfaz.Facturas
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmControlMsgBox
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
            Me.btnAceptar = New System.Windows.Forms.Button()
            Me.btnCancelar = New System.Windows.Forms.Button()
            Me.lbl1 = New System.Windows.Forms.Label()
            Me.lbl2 = New System.Windows.Forms.Label()
            Me.lblMostrar = New System.Windows.Forms.Label()
            Me.SuspendLayout()
            '
            'btnAceptar
            '
            Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAceptar.Location = New System.Drawing.Point(70, 75)
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
            Me.btnAceptar.TabIndex = 0
            Me.btnAceptar.Text = "Aceptar"
            Me.btnAceptar.UseVisualStyleBackColor = True
            '
            'btnCancelar
            '
            Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelar.Location = New System.Drawing.Point(220, 75)
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
            Me.btnCancelar.TabIndex = 1
            Me.btnCancelar.Text = "Cancelar"
            Me.btnCancelar.UseVisualStyleBackColor = True
            '
            'lbl1
            '
            Me.lbl1.AutoSize = True
            Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbl1.Location = New System.Drawing.Point(2, 35)
            Me.lbl1.Name = "lbl1"
            Me.lbl1.Size = New System.Drawing.Size(102, 16)
            Me.lbl1.TabIndex = 2
            Me.lbl1.Text = "Está recibiendo"
            '
            'lbl2
            '
            Me.lbl2.AutoSize = True
            Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbl2.Location = New System.Drawing.Point(260, 35)
            Me.lbl2.Name = "lbl2"
            Me.lbl2.Size = New System.Drawing.Size(100, 16)
            Me.lbl2.TabIndex = 3
            Me.lbl2.Text = "de lo facturado."
            '
            'lblMostrar
            '
            Me.lblMostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrar.Location = New System.Drawing.Point(100, 29)
            Me.lblMostrar.Name = "lblMostrar"
            Me.lblMostrar.Size = New System.Drawing.Size(163, 23)
            Me.lblMostrar.TabIndex = 4
            Me.lblMostrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'FrmControl_MsgBox
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(361, 108)
            Me.ControlBox = False
            Me.Controls.Add(Me.lblMostrar)
            Me.Controls.Add(Me.lbl2)
            Me.Controls.Add(Me.lbl1)
            Me.Controls.Add(Me.btnCancelar)
            Me.Controls.Add(Me.btnAceptar)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmControl_MsgBox"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Rebajo de Dinero"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents btnAceptar As System.Windows.Forms.Button
        Friend WithEvents btnCancelar As System.Windows.Forms.Button
        Friend WithEvents lbl1 As System.Windows.Forms.Label
        Friend WithEvents lbl2 As System.Windows.Forms.Label
        Friend WithEvents lblMostrar As System.Windows.Forms.Label
    End Class
End Namespace