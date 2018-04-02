Namespace Interfaz.Catalogo
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmProductoRelacionado
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
            Me.components = New System.ComponentModel.Container()
            Me.btnAplicar = New System.Windows.Forms.Button()
            Me.btnAbajo = New System.Windows.Forms.Button()
            Me.btnArriba = New System.Windows.Forms.Button()
            Me.btnAgregarProveedor = New System.Windows.Forms.Button()
            Me.dgvRelacionados = New System.Windows.Forms.DataGridView()
            Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Prioridad = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Observacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.txtDescripcion = New System.Windows.Forms.TextBox()
            Me.txtCodigo = New System.Windows.Forms.TextBox()
            Me.lblDescripcion = New System.Windows.Forms.Label()
            Me.lblCodigo = New System.Windows.Forms.Label()
            Me.lblObservacion = New System.Windows.Forms.Label()
            Me.txtObservacion = New System.Windows.Forms.TextBox()
            Me.Menu_Relacionados = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.lbl1 = New System.Windows.Forms.Label()
            Me.dgvMostrarProductos = New System.Windows.Forms.DataGridView()
            Me.btnLimpiar = New System.Windows.Forms.Button()
            Me.txtCodigo_Product = New System.Windows.Forms.TextBox()
            CType(Me.dgvRelacionados, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Menu_Relacionados.SuspendLayout()
            CType(Me.dgvMostrarProductos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'btnAplicar
            '
            Me.btnAplicar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAplicar.Image = Global.Presentacion.My.Resources.Resources.aceptar
            Me.btnAplicar.Location = New System.Drawing.Point(0, 0)
            Me.btnAplicar.Name = "btnAplicar"
            Me.btnAplicar.Size = New System.Drawing.Size(71, 57)
            Me.btnAplicar.TabIndex = 40
            Me.btnAplicar.Text = "Aplicar"
            Me.btnAplicar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnAplicar.UseVisualStyleBackColor = True
            '
            'btnAbajo
            '
            Me.btnAbajo.BackgroundImage = Global.Presentacion.My.Resources.Resources.Flecha_Abajo
            Me.btnAbajo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnAbajo.Location = New System.Drawing.Point(657, 190)
            Me.btnAbajo.Name = "btnAbajo"
            Me.btnAbajo.Size = New System.Drawing.Size(26, 37)
            Me.btnAbajo.TabIndex = 41
            Me.btnAbajo.UseVisualStyleBackColor = True
            '
            'btnArriba
            '
            Me.btnArriba.BackgroundImage = Global.Presentacion.My.Resources.Resources.Flecha_Arriba
            Me.btnArriba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnArriba.Location = New System.Drawing.Point(657, 142)
            Me.btnArriba.Name = "btnArriba"
            Me.btnArriba.Size = New System.Drawing.Size(26, 37)
            Me.btnArriba.TabIndex = 40
            Me.btnArriba.UseVisualStyleBackColor = True
            '
            'btnAgregarProveedor
            '
            Me.btnAgregarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.btnAgregarProveedor.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAgregarProveedor.Location = New System.Drawing.Point(505, 101)
            Me.btnAgregarProveedor.Name = "btnAgregarProveedor"
            Me.btnAgregarProveedor.Size = New System.Drawing.Size(111, 23)
            Me.btnAgregarProveedor.TabIndex = 38
            Me.btnAgregarProveedor.Text = "Agregar"
            Me.btnAgregarProveedor.UseVisualStyleBackColor = True
            '
            'dgvRelacionados
            '
            Me.dgvRelacionados.AllowUserToAddRows = False
            Me.dgvRelacionados.AllowUserToDeleteRows = False
            Me.dgvRelacionados.AllowUserToResizeColumns = False
            Me.dgvRelacionados.BackgroundColor = System.Drawing.Color.White
            Me.dgvRelacionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            Me.dgvRelacionados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Prioridad, Me.Descripcion, Me.Observacion})
            Me.dgvRelacionados.GridColor = System.Drawing.Color.White
            Me.dgvRelacionados.Location = New System.Drawing.Point(12, 129)
            Me.dgvRelacionados.MultiSelect = False
            Me.dgvRelacionados.Name = "dgvRelacionados"
            Me.dgvRelacionados.ReadOnly = True
            Me.dgvRelacionados.RowHeadersVisible = False
            Me.dgvRelacionados.RowTemplate.Height = 18
            Me.dgvRelacionados.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvRelacionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvRelacionados.Size = New System.Drawing.Size(639, 98)
            Me.dgvRelacionados.TabIndex = 2
            '
            'Codigo
            '
            Me.Codigo.HeaderText = "Código"
            Me.Codigo.Name = "Codigo"
            Me.Codigo.ReadOnly = True
            Me.Codigo.Width = 45
            '
            'Prioridad
            '
            Me.Prioridad.HeaderText = "Prioridad"
            Me.Prioridad.Name = "Prioridad"
            Me.Prioridad.ReadOnly = True
            Me.Prioridad.Width = 55
            '
            'Descripcion
            '
            Me.Descripcion.HeaderText = "Descripción"
            Me.Descripcion.Name = "Descripcion"
            Me.Descripcion.ReadOnly = True
            Me.Descripcion.Width = 340
            '
            'Observacion
            '
            Me.Observacion.HeaderText = "Observación"
            Me.Observacion.Name = "Observacion"
            Me.Observacion.ReadOnly = True
            Me.Observacion.Width = 190
            '
            'txtDescripcion
            '
            Me.txtDescripcion.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtDescripcion.Location = New System.Drawing.Point(79, 76)
            Me.txtDescripcion.MaxLength = 65
            Me.txtDescripcion.Name = "txtDescripcion"
            Me.txtDescripcion.Size = New System.Drawing.Size(537, 20)
            Me.txtDescripcion.TabIndex = 43
            '
            'txtCodigo
            '
            Me.txtCodigo.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtCodigo.Location = New System.Drawing.Point(12, 76)
            Me.txtCodigo.MaxLength = 7
            Me.txtCodigo.Name = "txtCodigo"
            Me.txtCodigo.Size = New System.Drawing.Size(63, 20)
            Me.txtCodigo.TabIndex = 0
            Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblDescripcion
            '
            Me.lblDescripcion.AutoSize = True
            Me.lblDescripcion.BackColor = System.Drawing.Color.Transparent
            Me.lblDescripcion.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDescripcion.Location = New System.Drawing.Point(76, 60)
            Me.lblDescripcion.Name = "lblDescripcion"
            Me.lblDescripcion.Size = New System.Drawing.Size(140, 15)
            Me.lblDescripcion.TabIndex = 45
            Me.lblDescripcion.Text = "Descripción del Material"
            '
            'lblCodigo
            '
            Me.lblCodigo.AutoSize = True
            Me.lblCodigo.BackColor = System.Drawing.Color.Transparent
            Me.lblCodigo.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCodigo.Location = New System.Drawing.Point(9, 60)
            Me.lblCodigo.Name = "lblCodigo"
            Me.lblCodigo.Size = New System.Drawing.Size(45, 15)
            Me.lblCodigo.TabIndex = 44
            Me.lblCodigo.Text = "Código"
            '
            'lblObservacion
            '
            Me.lblObservacion.AutoSize = True
            Me.lblObservacion.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblObservacion.Location = New System.Drawing.Point(12, 103)
            Me.lblObservacion.Name = "lblObservacion"
            Me.lblObservacion.Size = New System.Drawing.Size(90, 15)
            Me.lblObservacion.TabIndex = 48
            Me.lblObservacion.Text = "Observaciones:"
            '
            'txtObservacion
            '
            Me.txtObservacion.Location = New System.Drawing.Point(108, 103)
            Me.txtObservacion.MaxLength = 40
            Me.txtObservacion.Name = "txtObservacion"
            Me.txtObservacion.Size = New System.Drawing.Size(369, 20)
            Me.txtObservacion.TabIndex = 30
            '
            'Menu_Relacionados
            '
            Me.Menu_Relacionados.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarToolStripMenuItem})
            Me.Menu_Relacionados.Name = "Menu_Relacionados"
            Me.Menu_Relacionados.Size = New System.Drawing.Size(118, 26)
            '
            'EliminarToolStripMenuItem
            '
            Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
            Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
            Me.EliminarToolStripMenuItem.Text = "Eliminar"
            '
            'lbl1
            '
            Me.lbl1.AutoSize = True
            Me.lbl1.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbl1.Location = New System.Drawing.Point(359, 9)
            Me.lbl1.Name = "lbl1"
            Me.lbl1.Size = New System.Drawing.Size(230, 26)
            Me.lbl1.TabIndex = 50
            Me.lbl1.Text = "Productos Relacionados"
            '
            'dgvMostrarProductos
            '
            Me.dgvMostrarProductos.AllowUserToAddRows = False
            Me.dgvMostrarProductos.AllowUserToDeleteRows = False
            Me.dgvMostrarProductos.AllowUserToResizeColumns = False
            Me.dgvMostrarProductos.BackgroundColor = System.Drawing.Color.White
            Me.dgvMostrarProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            Me.dgvMostrarProductos.GridColor = System.Drawing.Color.White
            Me.dgvMostrarProductos.Location = New System.Drawing.Point(81, 97)
            Me.dgvMostrarProductos.MultiSelect = False
            Me.dgvMostrarProductos.Name = "dgvMostrarProductos"
            Me.dgvMostrarProductos.ReadOnly = True
            Me.dgvMostrarProductos.RowHeadersVisible = False
            Me.dgvMostrarProductos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvMostrarProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvMostrarProductos.Size = New System.Drawing.Size(476, 109)
            Me.dgvMostrarProductos.TabIndex = 51
            Me.dgvMostrarProductos.Visible = False
            '
            'btnLimpiar
            '
            Me.btnLimpiar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnLimpiar.Image = Global.Presentacion.My.Resources.Resources.Limpiar
            Me.btnLimpiar.Location = New System.Drawing.Point(70, 0)
            Me.btnLimpiar.Name = "btnLimpiar"
            Me.btnLimpiar.Size = New System.Drawing.Size(71, 57)
            Me.btnLimpiar.TabIndex = 52
            Me.btnLimpiar.Text = "Limpiar"
            Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnLimpiar.UseVisualStyleBackColor = True
            '
            'txtCodigo_Product
            '
            Me.txtCodigo_Product.Enabled = False
            Me.txtCodigo_Product.Location = New System.Drawing.Point(271, 15)
            Me.txtCodigo_Product.Name = "txtCodigo_Product"
            Me.txtCodigo_Product.Size = New System.Drawing.Size(72, 20)
            Me.txtCodigo_Product.TabIndex = 53
            Me.txtCodigo_Product.Visible = False
            '
            'FrmProductoRelacionado
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(695, 234)
            Me.Controls.Add(Me.dgvMostrarProductos)
            Me.Controls.Add(Me.btnLimpiar)
            Me.Controls.Add(Me.txtCodigo_Product)
            Me.Controls.Add(Me.lbl1)
            Me.Controls.Add(Me.txtObservacion)
            Me.Controls.Add(Me.lblObservacion)
            Me.Controls.Add(Me.dgvRelacionados)
            Me.Controls.Add(Me.btnAbajo)
            Me.Controls.Add(Me.btnArriba)
            Me.Controls.Add(Me.txtDescripcion)
            Me.Controls.Add(Me.btnAplicar)
            Me.Controls.Add(Me.txtCodigo)
            Me.Controls.Add(Me.btnAgregarProveedor)
            Me.Controls.Add(Me.lblDescripcion)
            Me.Controls.Add(Me.lblCodigo)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmProductoRelacionado"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Productos Relacionados"
            CType(Me.dgvRelacionados, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Menu_Relacionados.ResumeLayout(False)
            CType(Me.dgvMostrarProductos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents btnAplicar As System.Windows.Forms.Button
        Friend WithEvents btnAbajo As System.Windows.Forms.Button
        Friend WithEvents btnArriba As System.Windows.Forms.Button
        Friend WithEvents btnAgregarProveedor As System.Windows.Forms.Button
        Friend WithEvents dgvRelacionados As System.Windows.Forms.DataGridView
        Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
        Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
        Friend WithEvents lblDescripcion As System.Windows.Forms.Label
        Friend WithEvents lblCodigo As System.Windows.Forms.Label
        Friend WithEvents lblObservacion As System.Windows.Forms.Label
        Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
        Friend WithEvents Menu_Relacionados As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents lbl1 As System.Windows.Forms.Label
        Friend WithEvents dgvMostrarProductos As System.Windows.Forms.DataGridView
        Friend WithEvents btnLimpiar As System.Windows.Forms.Button
        Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Prioridad As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Observacion As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents txtCodigo_Product As System.Windows.Forms.TextBox
    End Class
End Namespace