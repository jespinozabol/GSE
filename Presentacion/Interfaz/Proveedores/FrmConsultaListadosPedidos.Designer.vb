Namespace Interfaz.Proveedores
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmConsultaListadosPedidos
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
            Me.dgvListados = New System.Windows.Forms.DataGridView()
            Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.lblMostrar = New System.Windows.Forms.Label()
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
            Me.dgvListados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            Me.dgvListados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Fecha, Me.Cliente, Me.Telefono})
            Me.dgvListados.GridColor = System.Drawing.Color.White
            Me.dgvListados.Location = New System.Drawing.Point(10, 43)
            Me.dgvListados.MultiSelect = False
            Me.dgvListados.Name = "dgvListados"
            Me.dgvListados.ReadOnly = True
            Me.dgvListados.RowHeadersVisible = False
            Me.dgvListados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvListados.Size = New System.Drawing.Size(587, 335)
            Me.dgvListados.TabIndex = 3
            '
            'Id
            '
            Me.Id.HeaderText = "Id"
            Me.Id.Name = "Id"
            Me.Id.ReadOnly = True
            Me.Id.Visible = False
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
            Me.Cliente.HeaderText = "Proveedor"
            Me.Cliente.Name = "Cliente"
            Me.Cliente.ReadOnly = True
            Me.Cliente.Width = 400
            '
            'Telefono
            '
            Me.Telefono.HeaderText = "Modificado"
            Me.Telefono.Name = "Telefono"
            Me.Telefono.ReadOnly = True
            Me.Telefono.Width = 80
            '
            'lblMostrar
            '
            Me.lblMostrar.AutoSize = True
            Me.lblMostrar.Font = New System.Drawing.Font("Candara", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrar.Location = New System.Drawing.Point(168, 10)
            Me.lblMostrar.Name = "lblMostrar"
            Me.lblMostrar.Size = New System.Drawing.Size(258, 36)
            Me.lblMostrar.TabIndex = 2
            Me.lblMostrar.Text = "Pedidos Pendientes"
            '
            'FrmConsultaListadosPedidos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(606, 388)
            Me.Controls.Add(Me.dgvListados)
            Me.Controls.Add(Me.lblMostrar)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmConsultaListadosPedidos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "ConsultaListadosPedidos"
            CType(Me.dgvListados, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvListados As System.Windows.Forms.DataGridView
        Friend WithEvents lblMostrar As System.Windows.Forms.Label
        Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    End Class
End Namespace

