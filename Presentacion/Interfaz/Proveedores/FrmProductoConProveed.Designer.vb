Namespace Interfaz.Proveedores
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmProductoConProveed
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
            Me.dgvProveedores = New System.Windows.Forms.DataGridView()
            CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dgvProveedores
            '
            Me.dgvProveedores.AllowUserToAddRows = False
            Me.dgvProveedores.AllowUserToDeleteRows = False
            Me.dgvProveedores.AllowUserToResizeColumns = False
            Me.dgvProveedores.AllowUserToResizeRows = False
            Me.dgvProveedores.BackgroundColor = System.Drawing.Color.White
            Me.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvProveedores.Location = New System.Drawing.Point(13, 13)
            Me.dgvProveedores.MultiSelect = False
            Me.dgvProveedores.Name = "dgvProveedores"
            Me.dgvProveedores.ReadOnly = True
            Me.dgvProveedores.RowHeadersVisible = False
            Me.dgvProveedores.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvProveedores.Size = New System.Drawing.Size(378, 135)
            Me.dgvProveedores.TabIndex = 30
            '
            'FrmProductoConProveed
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(403, 153)
            Me.Controls.Add(Me.dgvProveedores)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmProductoConProveed"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Proveedores"
            CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents dgvProveedores As System.Windows.Forms.DataGridView
    End Class
End Namespace