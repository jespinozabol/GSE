Namespace Interfaz.Proveedores
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmListadoPedidos
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
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.txtFechaCreacion = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtId_Pedido = New System.Windows.Forms.TextBox()
            Me.txtNombre = New System.Windows.Forms.TextBox()
            Me.lblNombre = New System.Windows.Forms.Label()
            Me.dgvProveedores = New System.Windows.Forms.DataGridView()
            Me.dgvProductos = New System.Windows.Forms.DataGridView()
            Me.Check = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Recibido = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.btnReprocesarPedido = New System.Windows.Forms.Button()
            Me.btnImprimir = New System.Windows.Forms.Button()
            Me.btnEliminar = New System.Windows.Forms.Button()
            Me.btnLimpiar = New System.Windows.Forms.Button()
            Me.lblModificado = New System.Windows.Forms.Label()
            Me.lblMostrarModificado = New System.Windows.Forms.Label()
            Me.Button1 = New System.Windows.Forms.Button()
            CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'txtFechaCreacion
            '
            Me.txtFechaCreacion.Enabled = False
            Me.txtFechaCreacion.Location = New System.Drawing.Point(328, 81)
            Me.txtFechaCreacion.MaxLength = 8
            Me.txtFechaCreacion.Name = "txtFechaCreacion"
            Me.txtFechaCreacion.Size = New System.Drawing.Size(87, 20)
            Me.txtFechaCreacion.TabIndex = 1
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(325, 65)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(82, 13)
            Me.Label1.TabIndex = 123
            Me.Label1.Text = "Fecha Creación"
            '
            'txtId_Pedido
            '
            Me.txtId_Pedido.Location = New System.Drawing.Point(70, 58)
            Me.txtId_Pedido.Name = "txtId_Pedido"
            Me.txtId_Pedido.ReadOnly = True
            Me.txtId_Pedido.Size = New System.Drawing.Size(42, 20)
            Me.txtId_Pedido.TabIndex = 120
            Me.txtId_Pedido.Visible = False
            '
            'txtNombre
            '
            Me.txtNombre.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtNombre.Location = New System.Drawing.Point(12, 81)
            Me.txtNombre.MaxLength = 45
            Me.txtNombre.Name = "txtNombre"
            Me.txtNombre.Size = New System.Drawing.Size(311, 20)
            Me.txtNombre.TabIndex = 0
            '
            'lblNombre
            '
            Me.lblNombre.AutoSize = True
            Me.lblNombre.BackColor = System.Drawing.Color.Transparent
            Me.lblNombre.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblNombre.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombre.Location = New System.Drawing.Point(16, 65)
            Me.lblNombre.Name = "lblNombre"
            Me.lblNombre.Size = New System.Drawing.Size(53, 15)
            Me.lblNombre.TabIndex = 119
            Me.lblNombre.Text = "Nombre"
            '
            'dgvProveedores
            '
            Me.dgvProveedores.AllowUserToAddRows = False
            Me.dgvProveedores.AllowUserToDeleteRows = False
            Me.dgvProveedores.AllowUserToResizeColumns = False
            Me.dgvProveedores.AllowUserToResizeRows = False
            Me.dgvProveedores.BackgroundColor = System.Drawing.Color.White
            Me.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvProveedores.Cursor = System.Windows.Forms.Cursors.Hand
            Me.dgvProveedores.GridColor = System.Drawing.Color.White
            Me.dgvProveedores.Location = New System.Drawing.Point(12, 102)
            Me.dgvProveedores.MultiSelect = False
            Me.dgvProveedores.Name = "dgvProveedores"
            Me.dgvProveedores.ReadOnly = True
            Me.dgvProveedores.RowHeadersVisible = False
            Me.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvProveedores.Size = New System.Drawing.Size(287, 92)
            Me.dgvProveedores.TabIndex = 125
            Me.dgvProveedores.Visible = False
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
            Me.dgvProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Check, Me.Cantidad, Me.Recibido, Me.Codigo, Me.Descripcion})
            Me.dgvProductos.Cursor = System.Windows.Forms.Cursors.Hand
            Me.dgvProductos.GridColor = System.Drawing.Color.White
            Me.dgvProductos.Location = New System.Drawing.Point(8, 116)
            Me.dgvProductos.MultiSelect = False
            Me.dgvProductos.Name = "dgvProductos"
            Me.dgvProductos.ReadOnly = True
            Me.dgvProductos.RowHeadersVisible = False
            Me.dgvProductos.RowTemplate.Height = 19
            Me.dgvProductos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
            Me.dgvProductos.Size = New System.Drawing.Size(700, 276)
            Me.dgvProductos.TabIndex = 126
            '
            'Check
            '
            Me.Check.HeaderText = ""
            Me.Check.Name = "Check"
            Me.Check.ReadOnly = True
            Me.Check.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.Check.Visible = False
            Me.Check.Width = 19
            '
            'Cantidad
            '
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle3
            Me.Cantidad.HeaderText = "Solicitado"
            Me.Cantidad.Name = "Cantidad"
            Me.Cantidad.ReadOnly = True
            Me.Cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.Cantidad.Width = 80
            '
            'Recibido
            '
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Recibido.DefaultCellStyle = DataGridViewCellStyle4
            Me.Recibido.HeaderText = "Recibido"
            Me.Recibido.Name = "Recibido"
            Me.Recibido.ReadOnly = True
            Me.Recibido.Width = 80
            '
            'Codigo
            '
            Me.Codigo.HeaderText = "Código"
            Me.Codigo.Name = "Codigo"
            Me.Codigo.ReadOnly = True
            Me.Codigo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.Codigo.Width = 80
            '
            'Descripcion
            '
            Me.Descripcion.HeaderText = "Descripción"
            Me.Descripcion.Name = "Descripcion"
            Me.Descripcion.ReadOnly = True
            Me.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.Descripcion.Width = 420
            '
            'btnReprocesarPedido
            '
            Me.btnReprocesarPedido.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnReprocesarPedido.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReprocesarPedido.Image = Global.Presentacion.My.Resources.Resources.trasladar
            Me.btnReprocesarPedido.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnReprocesarPedido.Location = New System.Drawing.Point(252, 0)
            Me.btnReprocesarPedido.Name = "btnReprocesarPedido"
            Me.btnReprocesarPedido.Size = New System.Drawing.Size(119, 52)
            Me.btnReprocesarPedido.TabIndex = 42
            Me.btnReprocesarPedido.Text = "Reprocesar pedido"
            Me.btnReprocesarPedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnReprocesarPedido.UseVisualStyleBackColor = True
            '
            'btnImprimir
            '
            Me.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnImprimir.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnImprimir.Image = Global.Presentacion.My.Resources.Resources.Imprimir
            Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnImprimir.Location = New System.Drawing.Point(0, 0)
            Me.btnImprimir.Name = "btnImprimir"
            Me.btnImprimir.Size = New System.Drawing.Size(64, 52)
            Me.btnImprimir.TabIndex = 39
            Me.btnImprimir.Text = "Imprimir"
            Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnImprimir.UseVisualStyleBackColor = True
            '
            'btnEliminar
            '
            Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnEliminar.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliminar.Image = Global.Presentacion.My.Resources.Resources.Eliminar
            Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnEliminar.Location = New System.Drawing.Point(126, 0)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(64, 52)
            Me.btnEliminar.TabIndex = 40
            Me.btnEliminar.Text = "Eliminar"
            Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnEliminar.UseVisualStyleBackColor = True
            '
            'btnLimpiar
            '
            Me.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnLimpiar.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnLimpiar.Image = Global.Presentacion.My.Resources.Resources.Limpiar
            Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnLimpiar.Location = New System.Drawing.Point(189, 0)
            Me.btnLimpiar.Name = "btnLimpiar"
            Me.btnLimpiar.Size = New System.Drawing.Size(64, 52)
            Me.btnLimpiar.TabIndex = 38
            Me.btnLimpiar.Text = "Limpiar"
            Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnLimpiar.UseVisualStyleBackColor = True
            '
            'lblModificado
            '
            Me.lblModificado.AutoSize = True
            Me.lblModificado.Location = New System.Drawing.Point(426, 65)
            Me.lblModificado.Name = "lblModificado"
            Me.lblModificado.Size = New System.Drawing.Size(59, 13)
            Me.lblModificado.TabIndex = 128
            Me.lblModificado.Text = "Modificado"
            '
            'lblMostrarModificado
            '
            Me.lblMostrarModificado.AutoSize = True
            Me.lblMostrarModificado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarModificado.Location = New System.Drawing.Point(441, 82)
            Me.lblMostrarModificado.Name = "lblMostrarModificado"
            Me.lblMostrarModificado.Size = New System.Drawing.Size(0, 16)
            Me.lblMostrarModificado.TabIndex = 129
            Me.lblMostrarModificado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Button1
            '
            Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Button1.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.Button1.Location = New System.Drawing.Point(63, 0)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(64, 52)
            Me.Button1.TabIndex = 130
            Me.Button1.Text = "Reenviar Email"
            Me.Button1.UseVisualStyleBackColor = True
            '
            'FrmListadoPedidos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(713, 397)
            Me.Controls.Add(Me.Button1)
            Me.Controls.Add(Me.lblMostrarModificado)
            Me.Controls.Add(Me.lblModificado)
            Me.Controls.Add(Me.dgvProveedores)
            Me.Controls.Add(Me.dgvProductos)
            Me.Controls.Add(Me.txtFechaCreacion)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.txtId_Pedido)
            Me.Controls.Add(Me.txtNombre)
            Me.Controls.Add(Me.lblNombre)
            Me.Controls.Add(Me.btnReprocesarPedido)
            Me.Controls.Add(Me.btnImprimir)
            Me.Controls.Add(Me.btnEliminar)
            Me.Controls.Add(Me.btnLimpiar)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmListadoPedidos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Pedidos pendientes"
            CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents btnReprocesarPedido As System.Windows.Forms.Button
        Friend WithEvents btnImprimir As System.Windows.Forms.Button
        Friend WithEvents btnEliminar As System.Windows.Forms.Button
        Friend WithEvents btnLimpiar As System.Windows.Forms.Button
        Friend WithEvents txtFechaCreacion As System.Windows.Forms.TextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtId_Pedido As System.Windows.Forms.TextBox
        Friend WithEvents txtNombre As System.Windows.Forms.TextBox
        Friend WithEvents lblNombre As System.Windows.Forms.Label
        Friend WithEvents dgvProveedores As System.Windows.Forms.DataGridView
        Friend WithEvents dgvProductos As System.Windows.Forms.DataGridView
        Friend WithEvents lblModificado As System.Windows.Forms.Label
        Friend WithEvents lblMostrarModificado As System.Windows.Forms.Label
        Friend WithEvents Check As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Recibido As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Button1 As System.Windows.Forms.Button
    End Class
End Namespace

