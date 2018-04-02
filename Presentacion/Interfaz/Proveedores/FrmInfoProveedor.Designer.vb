Namespace Interfaz.Proveedores
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmInfoProveedor
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
            Me.lblMostrar_FaxPrinc = New System.Windows.Forms.Label()
            Me.lblFaxPrincipal = New System.Windows.Forms.Label()
            Me.lblMostrar_TelfPrin = New System.Windows.Forms.Label()
            Me.lblTelfPrin = New System.Windows.Forms.Label()
            Me.lblNombre_Empresa = New System.Windows.Forms.Label()
            Me.gbAgente = New System.Windows.Forms.GroupBox()
            Me.lblMostrar_TelfAgente = New System.Windows.Forms.Label()
            Me.lblTelf_Agente = New System.Windows.Forms.Label()
            Me.lblNombre_Agente = New System.Windows.Forms.Label()
            Me.lblAgente = New System.Windows.Forms.Label()
            Me.gbAgente.SuspendLayout()
            Me.SuspendLayout()
            '
            'lblMostrar_FaxPrinc
            '
            Me.lblMostrar_FaxPrinc.BackColor = System.Drawing.Color.Transparent
            Me.lblMostrar_FaxPrinc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrar_FaxPrinc.ForeColor = System.Drawing.Color.RoyalBlue
            Me.lblMostrar_FaxPrinc.Location = New System.Drawing.Point(195, 39)
            Me.lblMostrar_FaxPrinc.Name = "lblMostrar_FaxPrinc"
            Me.lblMostrar_FaxPrinc.Size = New System.Drawing.Size(74, 13)
            Me.lblMostrar_FaxPrinc.TabIndex = 15
            Me.lblMostrar_FaxPrinc.Text = "Label1"
            '
            'lblFaxPrincipal
            '
            Me.lblFaxPrincipal.AutoSize = True
            Me.lblFaxPrincipal.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFaxPrincipal.Location = New System.Drawing.Point(155, 37)
            Me.lblFaxPrincipal.Name = "lblFaxPrincipal"
            Me.lblFaxPrincipal.Size = New System.Drawing.Size(34, 18)
            Me.lblFaxPrincipal.TabIndex = 14
            Me.lblFaxPrincipal.Text = "Fax:"
            '
            'lblMostrar_TelfPrin
            '
            Me.lblMostrar_TelfPrin.BackColor = System.Drawing.Color.Transparent
            Me.lblMostrar_TelfPrin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrar_TelfPrin.ForeColor = System.Drawing.Color.RoyalBlue
            Me.lblMostrar_TelfPrin.Location = New System.Drawing.Point(73, 39)
            Me.lblMostrar_TelfPrin.Name = "lblMostrar_TelfPrin"
            Me.lblMostrar_TelfPrin.Size = New System.Drawing.Size(76, 13)
            Me.lblMostrar_TelfPrin.TabIndex = 13
            Me.lblMostrar_TelfPrin.Text = "Label1"
            '
            'lblTelfPrin
            '
            Me.lblTelfPrin.AutoSize = True
            Me.lblTelfPrin.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTelfPrin.Location = New System.Drawing.Point(6, 37)
            Me.lblTelfPrin.Name = "lblTelfPrin"
            Me.lblTelfPrin.Size = New System.Drawing.Size(67, 18)
            Me.lblTelfPrin.TabIndex = 12
            Me.lblTelfPrin.Text = "Teléfono:"
            '
            'lblNombre_Empresa
            '
            Me.lblNombre_Empresa.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombre_Empresa.ForeColor = System.Drawing.Color.RoyalBlue
            Me.lblNombre_Empresa.Location = New System.Drawing.Point(9, 3)
            Me.lblNombre_Empresa.Name = "lblNombre_Empresa"
            Me.lblNombre_Empresa.Size = New System.Drawing.Size(378, 23)
            Me.lblNombre_Empresa.TabIndex = 11
            Me.lblNombre_Empresa.Text = "Label1"
            Me.lblNombre_Empresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'gbAgente
            '
            Me.gbAgente.Controls.Add(Me.lblMostrar_TelfAgente)
            Me.gbAgente.Controls.Add(Me.lblTelf_Agente)
            Me.gbAgente.Controls.Add(Me.lblNombre_Agente)
            Me.gbAgente.Controls.Add(Me.lblAgente)
            Me.gbAgente.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbAgente.Location = New System.Drawing.Point(3, 63)
            Me.gbAgente.Name = "gbAgente"
            Me.gbAgente.Size = New System.Drawing.Size(414, 39)
            Me.gbAgente.TabIndex = 16
            Me.gbAgente.TabStop = False
            Me.gbAgente.Text = "Agente"
            '
            'lblMostrar_TelfAgente
            '
            Me.lblMostrar_TelfAgente.BackColor = System.Drawing.Color.Transparent
            Me.lblMostrar_TelfAgente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrar_TelfAgente.ForeColor = System.Drawing.Color.RoyalBlue
            Me.lblMostrar_TelfAgente.Location = New System.Drawing.Point(332, 16)
            Me.lblMostrar_TelfAgente.Name = "lblMostrar_TelfAgente"
            Me.lblMostrar_TelfAgente.Size = New System.Drawing.Size(76, 13)
            Me.lblMostrar_TelfAgente.TabIndex = 9
            Me.lblMostrar_TelfAgente.Text = "Label1"
            '
            'lblTelf_Agente
            '
            Me.lblTelf_Agente.AutoSize = True
            Me.lblTelf_Agente.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTelf_Agente.Location = New System.Drawing.Point(259, 16)
            Me.lblTelf_Agente.Name = "lblTelf_Agente"
            Me.lblTelf_Agente.Size = New System.Drawing.Size(67, 18)
            Me.lblTelf_Agente.TabIndex = 8
            Me.lblTelf_Agente.Text = "Teléfono:"
            '
            'lblNombre_Agente
            '
            Me.lblNombre_Agente.BackColor = System.Drawing.Color.Transparent
            Me.lblNombre_Agente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombre_Agente.ForeColor = System.Drawing.Color.RoyalBlue
            Me.lblNombre_Agente.Location = New System.Drawing.Point(61, 16)
            Me.lblNombre_Agente.Name = "lblNombre_Agente"
            Me.lblNombre_Agente.Size = New System.Drawing.Size(192, 13)
            Me.lblNombre_Agente.TabIndex = 7
            Me.lblNombre_Agente.Text = "Label1"
            '
            'lblAgente
            '
            Me.lblAgente.AutoSize = True
            Me.lblAgente.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblAgente.Location = New System.Drawing.Point(3, 16)
            Me.lblAgente.Name = "lblAgente"
            Me.lblAgente.Size = New System.Drawing.Size(63, 18)
            Me.lblAgente.TabIndex = 5
            Me.lblAgente.Text = "Nombre:"
            '
            'FrmInfo_Proveedor
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(420, 105)
            Me.Controls.Add(Me.lblMostrar_FaxPrinc)
            Me.Controls.Add(Me.lblFaxPrincipal)
            Me.Controls.Add(Me.lblMostrar_TelfPrin)
            Me.Controls.Add(Me.lblTelfPrin)
            Me.Controls.Add(Me.lblNombre_Empresa)
            Me.Controls.Add(Me.gbAgente)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmInfo_Proveedor"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Información del Proveedor"
            Me.gbAgente.ResumeLayout(False)
            Me.gbAgente.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents lblMostrar_FaxPrinc As System.Windows.Forms.Label
        Friend WithEvents lblFaxPrincipal As System.Windows.Forms.Label
        Friend WithEvents lblMostrar_TelfPrin As System.Windows.Forms.Label
        Friend WithEvents lblTelfPrin As System.Windows.Forms.Label
        Friend WithEvents lblNombre_Empresa As System.Windows.Forms.Label
        Friend WithEvents gbAgente As System.Windows.Forms.GroupBox
        Friend WithEvents lblMostrar_TelfAgente As System.Windows.Forms.Label
        Friend WithEvents lblTelf_Agente As System.Windows.Forms.Label
        Friend WithEvents lblNombre_Agente As System.Windows.Forms.Label
        Friend WithEvents lblAgente As System.Windows.Forms.Label
    End Class
End Namespace