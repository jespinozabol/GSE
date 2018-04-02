Namespace Interfaz.Listados
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmMostrarListado
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
            Me.txtTelfCliente = New System.Windows.Forms.TextBox()
            Me.lblTelfCliente = New System.Windows.Forms.Label()
            Me.txtId_Listado = New System.Windows.Forms.TextBox()
            Me.txtNombre = New System.Windows.Forms.TextBox()
            Me.lblNombre = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtFecha = New System.Windows.Forms.TextBox()
            Me.lblFecha = New System.Windows.Forms.Label()
            Me.dgvProductos = New System.Windows.Forms.DataGridView()
            Me.Ver = New System.Windows.Forms.DataGridViewLinkColumn()
            Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvAutorizados = New System.Windows.Forms.DataGridView()
            Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.lblAutorizados = New System.Windows.Forms.Label()
            CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvAutorizados, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'txtTelfCliente
            '
            Me.txtTelfCliente.Location = New System.Drawing.Point(59, 98)
            Me.txtTelfCliente.MaxLength = 8
            Me.txtTelfCliente.Name = "txtTelfCliente"
            Me.txtTelfCliente.ReadOnly = True
            Me.txtTelfCliente.Size = New System.Drawing.Size(87, 20)
            Me.txtTelfCliente.TabIndex = 114
            '
            'lblTelfCliente
            '
            Me.lblTelfCliente.AutoSize = True
            Me.lblTelfCliente.Location = New System.Drawing.Point(3, 98)
            Me.lblTelfCliente.Name = "lblTelfCliente"
            Me.lblTelfCliente.Size = New System.Drawing.Size(49, 13)
            Me.lblTelfCliente.TabIndex = 113
            Me.lblTelfCliente.Text = "Teléfono"
            '
            'txtId_Listado
            '
            Me.txtId_Listado.Location = New System.Drawing.Point(425, 22)
            Me.txtId_Listado.Name = "txtId_Listado"
            Me.txtId_Listado.ReadOnly = True
            Me.txtId_Listado.Size = New System.Drawing.Size(42, 20)
            Me.txtId_Listado.TabIndex = 112
            '
            'txtNombre
            '
            Me.txtNombre.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtNombre.Location = New System.Drawing.Point(59, 66)
            Me.txtNombre.MaxLength = 40
            Me.txtNombre.Name = "txtNombre"
            Me.txtNombre.ReadOnly = True
            Me.txtNombre.Size = New System.Drawing.Size(217, 20)
            Me.txtNombre.TabIndex = 110
            '
            'lblNombre
            '
            Me.lblNombre.AutoSize = True
            Me.lblNombre.BackColor = System.Drawing.Color.Transparent
            Me.lblNombre.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblNombre.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombre.Location = New System.Drawing.Point(3, 68)
            Me.lblNombre.Name = "lblNombre"
            Me.lblNombre.Size = New System.Drawing.Size(53, 15)
            Me.lblNombre.TabIndex = 111
            Me.lblNombre.Text = "Nombre"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(366, 25)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(53, 13)
            Me.Label1.TabIndex = 115
            Me.Label1.Text = "Id Listado"
            '
            'txtFecha
            '
            Me.txtFecha.Location = New System.Drawing.Point(526, 22)
            Me.txtFecha.MaxLength = 8
            Me.txtFecha.Name = "txtFecha"
            Me.txtFecha.ReadOnly = True
            Me.txtFecha.Size = New System.Drawing.Size(87, 20)
            Me.txtFecha.TabIndex = 118
            '
            'lblFecha
            '
            Me.lblFecha.AutoSize = True
            Me.lblFecha.Location = New System.Drawing.Point(483, 25)
            Me.lblFecha.Name = "lblFecha"
            Me.lblFecha.Size = New System.Drawing.Size(37, 13)
            Me.lblFecha.TabIndex = 117
            Me.lblFecha.Text = "Fecha"
            '
            'dgvProductos
            '
            Me.dgvProductos.AllowUserToAddRows = False
            Me.dgvProductos.AllowUserToDeleteRows = False
            Me.dgvProductos.AllowUserToResizeColumns = False
            Me.dgvProductos.AllowUserToResizeRows = False
            Me.dgvProductos.BackgroundColor = System.Drawing.Color.White
            Me.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
            Me.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ver, Me.Cantidad, Me.Codigo, Me.Descripcion})
            Me.dgvProductos.Cursor = System.Windows.Forms.Cursors.Hand
            Me.dgvProductos.GridColor = System.Drawing.Color.White
            Me.dgvProductos.Location = New System.Drawing.Point(6, 158)
            Me.dgvProductos.MultiSelect = False
            Me.dgvProductos.Name = "dgvProductos"
            Me.dgvProductos.ReadOnly = True
            Me.dgvProductos.RowHeadersVisible = False
            Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvProductos.Size = New System.Drawing.Size(613, 276)
            Me.dgvProductos.TabIndex = 119
            '
            'Ver
            '
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Ver.DefaultCellStyle = DataGridViewCellStyle1
            Me.Ver.HeaderText = "Ver"
            Me.Ver.Name = "Ver"
            Me.Ver.ReadOnly = True
            Me.Ver.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.Ver.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.Ver.Width = 40
            '
            'Cantidad
            '
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
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
            Me.Descripcion.Width = 425
            '
            'dgvAutorizados
            '
            Me.dgvAutorizados.AllowUserToAddRows = False
            Me.dgvAutorizados.AllowUserToDeleteRows = False
            Me.dgvAutorizados.AllowUserToResizeColumns = False
            Me.dgvAutorizados.AllowUserToResizeRows = False
            Me.dgvAutorizados.BackgroundColor = System.Drawing.Color.White
            Me.dgvAutorizados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
            Me.dgvAutorizados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            Me.dgvAutorizados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvAutorizados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Telefono})
            Me.dgvAutorizados.Cursor = System.Windows.Forms.Cursors.Hand
            Me.dgvAutorizados.GridColor = System.Drawing.Color.White
            Me.dgvAutorizados.Location = New System.Drawing.Point(288, 66)
            Me.dgvAutorizados.MultiSelect = False
            Me.dgvAutorizados.Name = "dgvAutorizados"
            Me.dgvAutorizados.ReadOnly = True
            Me.dgvAutorizados.RowHeadersVisible = False
            Me.dgvAutorizados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvAutorizados.Size = New System.Drawing.Size(331, 86)
            Me.dgvAutorizados.TabIndex = 120
            '
            'Nombre
            '
            Me.Nombre.HeaderText = "Nombre"
            Me.Nombre.Name = "Nombre"
            Me.Nombre.ReadOnly = True
            Me.Nombre.Width = 220
            '
            'Telefono
            '
            Me.Telefono.HeaderText = "Telefono"
            Me.Telefono.Name = "Telefono"
            Me.Telefono.ReadOnly = True
            '
            'lblAutorizados
            '
            Me.lblAutorizados.AutoSize = True
            Me.lblAutorizados.Location = New System.Drawing.Point(285, 50)
            Me.lblAutorizados.Name = "lblAutorizados"
            Me.lblAutorizados.Size = New System.Drawing.Size(62, 13)
            Me.lblAutorizados.TabIndex = 121
            Me.lblAutorizados.Text = "Autorizados"
            '
            'FrmMostrarListado
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(631, 437)
            Me.Controls.Add(Me.lblAutorizados)
            Me.Controls.Add(Me.dgvAutorizados)
            Me.Controls.Add(Me.dgvProductos)
            Me.Controls.Add(Me.txtFecha)
            Me.Controls.Add(Me.lblFecha)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.txtTelfCliente)
            Me.Controls.Add(Me.lblTelfCliente)
            Me.Controls.Add(Me.txtId_Listado)
            Me.Controls.Add(Me.txtNombre)
            Me.Controls.Add(Me.lblNombre)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmMostrarListado"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "FrmMostrarListado"
            CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvAutorizados, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents txtTelfCliente As System.Windows.Forms.TextBox
        Friend WithEvents lblTelfCliente As System.Windows.Forms.Label
        Friend WithEvents txtId_Listado As System.Windows.Forms.TextBox
        Friend WithEvents txtNombre As System.Windows.Forms.TextBox
        Friend WithEvents lblNombre As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtFecha As System.Windows.Forms.TextBox
        Friend WithEvents lblFecha As System.Windows.Forms.Label
        Friend WithEvents dgvProductos As System.Windows.Forms.DataGridView
        Friend WithEvents dgvAutorizados As System.Windows.Forms.DataGridView
        Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Telefono As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents lblAutorizados As System.Windows.Forms.Label
        Friend WithEvents Ver As System.Windows.Forms.DataGridViewLinkColumn
        Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    End Class
End Namespace