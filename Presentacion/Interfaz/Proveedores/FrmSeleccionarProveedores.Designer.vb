<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSeleccionarProveedores
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
        Me.dgvProveedores = New System.Windows.Forms.DataGridView()
        Me.btnEjecutar = New System.Windows.Forms.Button()
        Me.Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Imprime = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.EmailList = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pedir = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Transporte = New System.Windows.Forms.DataGridViewComboBoxColumn()
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
        Me.dgvProveedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Proveedor, Me.Imprime, Me.Email, Me.EmailList, Me.Pedir, Me.Transporte})
        Me.dgvProveedores.Location = New System.Drawing.Point(7, 57)
        Me.dgvProveedores.MultiSelect = False
        Me.dgvProveedores.Name = "dgvProveedores"
        Me.dgvProveedores.RowHeadersVisible = False
        Me.dgvProveedores.RowTemplate.Height = 18
        Me.dgvProveedores.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvProveedores.Size = New System.Drawing.Size(693, 211)
        Me.dgvProveedores.TabIndex = 34
        '
        'btnEjecutar
        '
        Me.btnEjecutar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEjecutar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEjecutar.Image = Global.Presentacion.My.Resources.Resources.icono_carrito
        Me.btnEjecutar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEjecutar.Location = New System.Drawing.Point(-1, -1)
        Me.btnEjecutar.Name = "btnEjecutar"
        Me.btnEjecutar.Size = New System.Drawing.Size(68, 52)
        Me.btnEjecutar.TabIndex = 259
        Me.btnEjecutar.Text = "Procesar"
        Me.btnEjecutar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEjecutar.UseVisualStyleBackColor = True
        '
        'Proveedor
        '
        Me.Proveedor.HeaderText = "Proveedor"
        Me.Proveedor.Name = "Proveedor"
        Me.Proveedor.ReadOnly = True
        Me.Proveedor.Width = 290
        '
        'Imprime
        '
        Me.Imprime.HeaderText = "Imprime"
        Me.Imprime.Name = "Imprime"
        Me.Imprime.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Imprime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Imprime.Width = 45
        '
        'Email
        '
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        Me.Email.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Email.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Email.Width = 45
        '
        'EmailList
        '
        Me.EmailList.HeaderText = "Email"
        Me.EmailList.Name = "EmailList"
        Me.EmailList.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EmailList.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.EmailList.Width = 120
        '
        'Pedir
        '
        Me.Pedir.HeaderText = "Hacer Pedido"
        Me.Pedir.Name = "Pedir"
        Me.Pedir.Width = 80
        '
        'Transporte
        '
        Me.Transporte.HeaderText = "Transporte"
        Me.Transporte.Name = "Transporte"
        '
        'FrmSeleccionarProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 274)
        Me.Controls.Add(Me.btnEjecutar)
        Me.Controls.Add(Me.dgvProveedores)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSeleccionarProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccionar Proveedores"
        CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvProveedores As System.Windows.Forms.DataGridView
    Friend WithEvents btnEjecutar As System.Windows.Forms.Button
    Friend WithEvents Proveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Imprime As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Email As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents EmailList As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pedir As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Transporte As System.Windows.Forms.DataGridViewComboBoxColumn
End Class
