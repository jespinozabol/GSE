Namespace Interfaz.Listados
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmModificarAutorizado
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
            Me.btnGuardar = New System.Windows.Forms.Button()
            Me.txtNombre = New System.Windows.Forms.TextBox()
            Me.lblNombre = New System.Windows.Forms.Label()
            Me.txtTelefono = New System.Windows.Forms.TextBox()
            Me.lblTelefono = New System.Windows.Forms.Label()
            Me.txtId = New System.Windows.Forms.TextBox()
            Me.btnAgregar = New System.Windows.Forms.Button()
            Me.dgvAutorizados = New System.Windows.Forms.DataGridView()
            Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.MnEliminar = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.InactivarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            CType(Me.dgvAutorizados, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MnEliminar.SuspendLayout()
            Me.SuspendLayout()
            '
            'btnGuardar
            '
            Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnGuardar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = Global.Presentacion.My.Resources.Resources.Modificar
            Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnGuardar.Location = New System.Drawing.Point(70, 0)
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(71, 57)
            Me.btnGuardar.TabIndex = 13
            Me.btnGuardar.Text = "Modificar"
            Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnGuardar.UseVisualStyleBackColor = True
            '
            'txtNombre
            '
            Me.txtNombre.Location = New System.Drawing.Point(8, 78)
            Me.txtNombre.MaxLength = 30
            Me.txtNombre.Name = "txtNombre"
            Me.txtNombre.Size = New System.Drawing.Size(259, 20)
            Me.txtNombre.TabIndex = 0
            '
            'lblNombre
            '
            Me.lblNombre.AutoSize = True
            Me.lblNombre.BackColor = System.Drawing.Color.Transparent
            Me.lblNombre.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombre.Location = New System.Drawing.Point(8, 60)
            Me.lblNombre.Name = "lblNombre"
            Me.lblNombre.Size = New System.Drawing.Size(56, 15)
            Me.lblNombre.TabIndex = 14
            Me.lblNombre.Text = "Nombre:"
            '
            'txtTelefono
            '
            Me.txtTelefono.Location = New System.Drawing.Point(273, 78)
            Me.txtTelefono.MaxLength = 8
            Me.txtTelefono.Name = "txtTelefono"
            Me.txtTelefono.Size = New System.Drawing.Size(116, 20)
            Me.txtTelefono.TabIndex = 1
            '
            'lblTelefono
            '
            Me.lblTelefono.AutoSize = True
            Me.lblTelefono.BackColor = System.Drawing.Color.Transparent
            Me.lblTelefono.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTelefono.Location = New System.Drawing.Point(270, 60)
            Me.lblTelefono.Name = "lblTelefono"
            Me.lblTelefono.Size = New System.Drawing.Size(58, 15)
            Me.lblTelefono.TabIndex = 10
            Me.lblTelefono.Text = "Teléfono:"
            '
            'txtId
            '
            Me.txtId.Location = New System.Drawing.Point(240, 39)
            Me.txtId.Name = "txtId"
            Me.txtId.ReadOnly = True
            Me.txtId.Size = New System.Drawing.Size(51, 20)
            Me.txtId.TabIndex = 17
            Me.txtId.Visible = False
            '
            'btnAgregar
            '
            Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnAgregar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAgregar.Image = Global.Presentacion.My.Resources.Resources.Guardar
            Me.btnAgregar.Location = New System.Drawing.Point(0, 0)
            Me.btnAgregar.Name = "btnAgregar"
            Me.btnAgregar.Size = New System.Drawing.Size(71, 57)
            Me.btnAgregar.TabIndex = 18
            Me.btnAgregar.Text = "Guardar"
            Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnAgregar.UseVisualStyleBackColor = True
            '
            'dgvAutorizados
            '
            Me.dgvAutorizados.AllowUserToAddRows = False
            Me.dgvAutorizados.AllowUserToDeleteRows = False
            Me.dgvAutorizados.AllowUserToResizeColumns = False
            Me.dgvAutorizados.AllowUserToResizeRows = False
            Me.dgvAutorizados.BackgroundColor = System.Drawing.Color.White
            Me.dgvAutorizados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvAutorizados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Nombre, Me.Telefono})
            Me.dgvAutorizados.GridColor = System.Drawing.Color.White
            Me.dgvAutorizados.Location = New System.Drawing.Point(8, 104)
            Me.dgvAutorizados.MultiSelect = False
            Me.dgvAutorizados.Name = "dgvAutorizados"
            Me.dgvAutorizados.ReadOnly = True
            Me.dgvAutorizados.RowHeadersVisible = False
            Me.dgvAutorizados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvAutorizados.Size = New System.Drawing.Size(381, 125)
            Me.dgvAutorizados.TabIndex = 19
            '
            'Id
            '
            Me.Id.HeaderText = "Id"
            Me.Id.Name = "Id"
            Me.Id.ReadOnly = True
            Me.Id.Width = 25
            '
            'Nombre
            '
            Me.Nombre.HeaderText = "Nombre"
            Me.Nombre.Name = "Nombre"
            Me.Nombre.ReadOnly = True
            Me.Nombre.Width = 245
            '
            'Telefono
            '
            Me.Telefono.HeaderText = "Teléfono"
            Me.Telefono.Name = "Telefono"
            Me.Telefono.ReadOnly = True
            '
            'MnEliminar
            '
            Me.MnEliminar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InactivarToolStripMenuItem})
            Me.MnEliminar.Name = "MnEliminar"
            Me.MnEliminar.Size = New System.Drawing.Size(120, 26)
            '
            'InactivarToolStripMenuItem
            '
            Me.InactivarToolStripMenuItem.Name = "InactivarToolStripMenuItem"
            Me.InactivarToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
            Me.InactivarToolStripMenuItem.Text = "Inactivar"
            '
            'FrmModificarAutorizado
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(398, 238)
            Me.Controls.Add(Me.dgvAutorizados)
            Me.Controls.Add(Me.btnAgregar)
            Me.Controls.Add(Me.btnGuardar)
            Me.Controls.Add(Me.txtNombre)
            Me.Controls.Add(Me.lblNombre)
            Me.Controls.Add(Me.txtTelefono)
            Me.Controls.Add(Me.lblTelefono)
            Me.Controls.Add(Me.txtId)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmModificarAutorizado"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Modificar Autorizado"
            CType(Me.dgvAutorizados, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MnEliminar.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents btnGuardar As System.Windows.Forms.Button
        Friend WithEvents txtNombre As System.Windows.Forms.TextBox
        Friend WithEvents lblNombre As System.Windows.Forms.Label
        Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
        Friend WithEvents lblTelefono As System.Windows.Forms.Label
        Friend WithEvents txtId As System.Windows.Forms.TextBox
        Friend WithEvents btnAgregar As System.Windows.Forms.Button
        Friend WithEvents dgvAutorizados As System.Windows.Forms.DataGridView
        Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Telefono As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents MnEliminar As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents InactivarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace