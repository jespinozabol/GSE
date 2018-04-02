Namespace Interfaz.Creditos
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmHistorialAbonos
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
            Me.dgvAbonos = New System.Windows.Forms.DataGridView()
            Me.lblNum = New System.Windows.Forms.Label()
            Me.lblMostrarFactura = New System.Windows.Forms.Label()
            CType(Me.dgvAbonos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dgvAbonos
            '
            Me.dgvAbonos.AllowUserToAddRows = False
            Me.dgvAbonos.AllowUserToDeleteRows = False
            Me.dgvAbonos.AllowUserToResizeColumns = False
            Me.dgvAbonos.AllowUserToResizeRows = False
            Me.dgvAbonos.BackgroundColor = System.Drawing.Color.White
            Me.dgvAbonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvAbonos.Location = New System.Drawing.Point(0, 65)
            Me.dgvAbonos.MultiSelect = False
            Me.dgvAbonos.Name = "dgvAbonos"
            Me.dgvAbonos.ReadOnly = True
            Me.dgvAbonos.RowHeadersVisible = False
            Me.dgvAbonos.RowTemplate.Height = 18
            Me.dgvAbonos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvAbonos.Size = New System.Drawing.Size(407, 182)
            Me.dgvAbonos.TabIndex = 0
            '
            'lblNum
            '
            Me.lblNum.AutoSize = True
            Me.lblNum.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNum.Location = New System.Drawing.Point(58, 34)
            Me.lblNum.Name = "lblNum"
            Me.lblNum.Size = New System.Drawing.Size(201, 23)
            Me.lblNum.TabIndex = 1
            Me.lblNum.Text = "Número de Documento"
            '
            'lblMostrarFactura
            '
            Me.lblMostrarFactura.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarFactura.Location = New System.Drawing.Point(265, 35)
            Me.lblMostrarFactura.Name = "lblMostrarFactura"
            Me.lblMostrarFactura.Size = New System.Drawing.Size(100, 23)
            Me.lblMostrarFactura.TabIndex = 2
            '
            'FrmHistorialAbonos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(408, 247)
            Me.Controls.Add(Me.lblMostrarFactura)
            Me.Controls.Add(Me.lblNum)
            Me.Controls.Add(Me.dgvAbonos)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmHistorialAbonos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "FrmHistorial_Abonos"
            CType(Me.dgvAbonos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvAbonos As System.Windows.Forms.DataGridView
        Friend WithEvents lblNum As System.Windows.Forms.Label
        Friend WithEvents lblMostrarFactura As System.Windows.Forms.Label
    End Class
End Namespace