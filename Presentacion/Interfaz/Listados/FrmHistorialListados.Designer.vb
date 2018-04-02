Namespace Interfaz.Listados
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmHistorialListados
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
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.dgvListados = New System.Windows.Forms.DataGridView()
            Me.Ver = New System.Windows.Forms.DataGridViewLinkColumn()
            Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.lbl1 = New System.Windows.Forms.Label()
            CType(Me.dgvListados, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dgvListados
            '
            Me.dgvListados.AllowUserToAddRows = False
            Me.dgvListados.AllowUserToDeleteRows = False
            Me.dgvListados.AllowUserToResizeColumns = False
            Me.dgvListados.AllowUserToResizeRows = False
            Me.dgvListados.BackgroundColor = System.Drawing.Color.White
            Me.dgvListados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
            Me.dgvListados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            Me.dgvListados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ver, Me.Cantidad, Me.Codigo, Me.Descripcion})
            Me.dgvListados.GridColor = System.Drawing.Color.White
            Me.dgvListados.Location = New System.Drawing.Point(3, 39)
            Me.dgvListados.MultiSelect = False
            Me.dgvListados.Name = "dgvListados"
            Me.dgvListados.ReadOnly = True
            Me.dgvListados.RowHeadersVisible = False
            Me.dgvListados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
            Me.dgvListados.Size = New System.Drawing.Size(573, 379)
            Me.dgvListados.TabIndex = 4
            '
            'Ver
            '
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Ver.DefaultCellStyle = DataGridViewCellStyle1
            Me.Ver.HeaderText = "Ver"
            Me.Ver.Name = "Ver"
            Me.Ver.ReadOnly = True
            Me.Ver.Width = 50
            '
            'Cantidad
            '
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle2
            Me.Cantidad.HeaderText = "Cantidad"
            Me.Cantidad.Name = "Cantidad"
            Me.Cantidad.ReadOnly = True
            Me.Cantidad.Width = 70
            '
            'Codigo
            '
            Me.Codigo.HeaderText = "Código"
            Me.Codigo.Name = "Codigo"
            Me.Codigo.ReadOnly = True
            Me.Codigo.Width = 70
            '
            'Descripcion
            '
            Me.Descripcion.HeaderText = "Descripción"
            Me.Descripcion.Name = "Descripcion"
            Me.Descripcion.ReadOnly = True
            Me.Descripcion.Width = 375
            '
            'lbl1
            '
            Me.lbl1.AutoSize = True
            Me.lbl1.Font = New System.Drawing.Font("Candara", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbl1.Location = New System.Drawing.Point(145, 0)
            Me.lbl1.Name = "lbl1"
            Me.lbl1.Size = New System.Drawing.Size(259, 36)
            Me.lbl1.TabIndex = 3
            Me.lbl1.Text = "Historial del Listado"
            '
            'FrmHistorialListados
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(579, 421)
            Me.Controls.Add(Me.dgvListados)
            Me.Controls.Add(Me.lbl1)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmHistorialListados"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Historial"
            CType(Me.dgvListados, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvListados As System.Windows.Forms.DataGridView
        Friend WithEvents lbl1 As System.Windows.Forms.Label
        Friend WithEvents Ver As System.Windows.Forms.DataGridViewLinkColumn
        Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    End Class
End Namespace