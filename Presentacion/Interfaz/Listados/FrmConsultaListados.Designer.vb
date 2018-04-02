Namespace Interfaz.Listados
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmConsultaListados
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
            Me.lblMostrar = New System.Windows.Forms.Label()
            Me.dgvListados = New System.Windows.Forms.DataGridView()
            Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
            CType(Me.dgvListados, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'lblMostrar
            '
            Me.lblMostrar.AutoSize = True
            Me.lblMostrar.Font = New System.Drawing.Font("Candara", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrar.Location = New System.Drawing.Point(159, 0)
            Me.lblMostrar.Name = "lblMostrar"
            Me.lblMostrar.Size = New System.Drawing.Size(262, 36)
            Me.lblMostrar.TabIndex = 0
            Me.lblMostrar.Text = "Listados Pendientes"
            '
            'dgvListados
            '
            Me.dgvListados.AllowUserToAddRows = False
            Me.dgvListados.AllowUserToDeleteRows = False
            Me.dgvListados.AllowUserToResizeColumns = False
            Me.dgvListados.AllowUserToResizeRows = False
            Me.dgvListados.BackgroundColor = System.Drawing.Color.White
            Me.dgvListados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            Me.dgvListados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Fecha, Me.Cliente, Me.Telefono, Me.Total})
            Me.dgvListados.GridColor = System.Drawing.Color.White
            Me.dgvListados.Location = New System.Drawing.Point(1, 33)
            Me.dgvListados.MultiSelect = False
            Me.dgvListados.Name = "dgvListados"
            Me.dgvListados.ReadOnly = True
            Me.dgvListados.RowHeadersVisible = False
            Me.dgvListados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvListados.Size = New System.Drawing.Size(587, 335)
            Me.dgvListados.TabIndex = 1
            '
            'Id
            '
            Me.Id.HeaderText = "# List"
            Me.Id.Name = "Id"
            Me.Id.ReadOnly = True
            Me.Id.Width = 55
            '
            'Fecha
            '
            Me.Fecha.HeaderText = "Fecha"
            Me.Fecha.Name = "Fecha"
            Me.Fecha.ReadOnly = True
            Me.Fecha.Width = 85
            '
            'Cliente
            '
            Me.Cliente.HeaderText = "Cliente"
            Me.Cliente.Name = "Cliente"
            Me.Cliente.ReadOnly = True
            Me.Cliente.Width = 260
            '
            'Telefono
            '
            Me.Telefono.HeaderText = "Telefono"
            Me.Telefono.Name = "Telefono"
            Me.Telefono.ReadOnly = True
            Me.Telefono.Width = 80
            '
            'Total
            '
            Me.Total.HeaderText = "Total"
            Me.Total.Name = "Total"
            Me.Total.ReadOnly = True
            '
            'FrmConsultaListados
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(590, 371)
            Me.Controls.Add(Me.dgvListados)
            Me.Controls.Add(Me.lblMostrar)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmConsultaListados"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Listados Pendientes"
            CType(Me.dgvListados, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents lblMostrar As System.Windows.Forms.Label
        Friend WithEvents dgvListados As System.Windows.Forms.DataGridView
        Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Telefono As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    End Class
End Namespace