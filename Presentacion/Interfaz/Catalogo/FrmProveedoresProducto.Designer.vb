Namespace Interfaz.Catalogo
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmProveedoresProducto
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
            Me.gbProveedores = New System.Windows.Forms.GroupBox()
            Me.btnAbajo = New System.Windows.Forms.Button()
            Me.btnArriba = New System.Windows.Forms.Button()
            Me.btnAgregarProveedor = New System.Windows.Forms.Button()
            Me.cmbProveedores = New System.Windows.Forms.ComboBox()
            Me.dgvProveedores = New System.Windows.Forms.DataGridView()
            Me.btnAplicar = New System.Windows.Forms.Button()
            Me.Menu_Proveedores = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.MnEliminar = New System.Windows.Forms.ToolStripMenuItem()
            Me.VerDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.lbl1 = New System.Windows.Forms.Label()
            Me.gbProveedores.SuspendLayout()
            CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Menu_Proveedores.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbProveedores
            '
            Me.gbProveedores.Controls.Add(Me.btnAbajo)
            Me.gbProveedores.Controls.Add(Me.btnArriba)
            Me.gbProveedores.Controls.Add(Me.btnAgregarProveedor)
            Me.gbProveedores.Controls.Add(Me.cmbProveedores)
            Me.gbProveedores.Controls.Add(Me.dgvProveedores)
            Me.gbProveedores.Location = New System.Drawing.Point(0, 62)
            Me.gbProveedores.Name = "gbProveedores"
            Me.gbProveedores.Size = New System.Drawing.Size(413, 136)
            Me.gbProveedores.TabIndex = 37
            Me.gbProveedores.TabStop = False
            Me.gbProveedores.Text = "Proveedores"
            '
            'btnAbajo
            '
            Me.btnAbajo.BackgroundImage = Global.Presentacion.My.Resources.Resources.Flecha_Abajo
            Me.btnAbajo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnAbajo.Location = New System.Drawing.Point(366, 91)
            Me.btnAbajo.Name = "btnAbajo"
            Me.btnAbajo.Size = New System.Drawing.Size(26, 37)
            Me.btnAbajo.TabIndex = 41
            Me.btnAbajo.UseVisualStyleBackColor = True
            '
            'btnArriba
            '
            Me.btnArriba.BackgroundImage = Global.Presentacion.My.Resources.Resources.Flecha_Arriba
            Me.btnArriba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnArriba.Location = New System.Drawing.Point(366, 44)
            Me.btnArriba.Name = "btnArriba"
            Me.btnArriba.Size = New System.Drawing.Size(26, 37)
            Me.btnArriba.TabIndex = 40
            Me.btnArriba.UseVisualStyleBackColor = True
            '
            'btnAgregarProveedor
            '
            Me.btnAgregarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.btnAgregarProveedor.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAgregarProveedor.Location = New System.Drawing.Point(340, 15)
            Me.btnAgregarProveedor.Name = "btnAgregarProveedor"
            Me.btnAgregarProveedor.Size = New System.Drawing.Size(67, 23)
            Me.btnAgregarProveedor.TabIndex = 38
            Me.btnAgregarProveedor.Text = "Agregar"
            Me.btnAgregarProveedor.UseVisualStyleBackColor = True
            '
            'cmbProveedores
            '
            Me.cmbProveedores.DropDownHeight = 130
            Me.cmbProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbProveedores.FormattingEnabled = True
            Me.cmbProveedores.IntegralHeight = False
            Me.cmbProveedores.ItemHeight = 13
            Me.cmbProveedores.Location = New System.Drawing.Point(6, 17)
            Me.cmbProveedores.Name = "cmbProveedores"
            Me.cmbProveedores.Size = New System.Drawing.Size(313, 21)
            Me.cmbProveedores.TabIndex = 37
            '
            'dgvProveedores
            '
            Me.dgvProveedores.AllowUserToAddRows = False
            Me.dgvProveedores.AllowUserToDeleteRows = False
            Me.dgvProveedores.AllowUserToResizeColumns = False
            Me.dgvProveedores.BackgroundColor = System.Drawing.Color.White
            Me.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            Me.dgvProveedores.GridColor = System.Drawing.Color.White
            Me.dgvProveedores.Location = New System.Drawing.Point(6, 44)
            Me.dgvProveedores.MultiSelect = False
            Me.dgvProveedores.Name = "dgvProveedores"
            Me.dgvProveedores.ReadOnly = True
            Me.dgvProveedores.RowHeadersVisible = False
            Me.dgvProveedores.RowTemplate.Height = 18
            Me.dgvProveedores.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvProveedores.Size = New System.Drawing.Size(355, 84)
            Me.dgvProveedores.TabIndex = 2
            '
            'btnAplicar
            '
            Me.btnAplicar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAplicar.Image = Global.Presentacion.My.Resources.Resources.aceptar
            Me.btnAplicar.Location = New System.Drawing.Point(0, 0)
            Me.btnAplicar.Name = "btnAplicar"
            Me.btnAplicar.Size = New System.Drawing.Size(71, 57)
            Me.btnAplicar.TabIndex = 38
            Me.btnAplicar.Text = "Aplicar"
            Me.btnAplicar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnAplicar.UseVisualStyleBackColor = True
            '
            'Menu_Proveedores
            '
            Me.Menu_Proveedores.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnEliminar, Me.VerDatosToolStripMenuItem})
            Me.Menu_Proveedores.Name = "Menu"
            Me.Menu_Proveedores.Size = New System.Drawing.Size(125, 48)
            '
            'MnEliminar
            '
            Me.MnEliminar.Name = "MnEliminar"
            Me.MnEliminar.Size = New System.Drawing.Size(124, 22)
            Me.MnEliminar.Text = "Eliminar"
            '
            'VerDatosToolStripMenuItem
            '
            Me.VerDatosToolStripMenuItem.Name = "VerDatosToolStripMenuItem"
            Me.VerDatosToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
            Me.VerDatosToolStripMenuItem.Text = "Ver Datos"
            '
            'lbl1
            '
            Me.lbl1.AutoSize = True
            Me.lbl1.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbl1.Location = New System.Drawing.Point(163, 9)
            Me.lbl1.Name = "lbl1"
            Me.lbl1.Size = New System.Drawing.Size(250, 26)
            Me.lbl1.TabIndex = 39
            Me.lbl1.Text = "Proveedores del Producto"
            '
            'FrmProveedoresProducto
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(415, 200)
            Me.Controls.Add(Me.btnAplicar)
            Me.Controls.Add(Me.lbl1)
            Me.Controls.Add(Me.gbProveedores)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmProveedoresProducto"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "FrmProveedores_Producto"
            Me.gbProveedores.ResumeLayout(False)
            CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Menu_Proveedores.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents gbProveedores As System.Windows.Forms.GroupBox
        Friend WithEvents btnAbajo As System.Windows.Forms.Button
        Friend WithEvents btnArriba As System.Windows.Forms.Button
        Friend WithEvents btnAgregarProveedor As System.Windows.Forms.Button
        Friend WithEvents cmbProveedores As System.Windows.Forms.ComboBox
        Friend WithEvents dgvProveedores As System.Windows.Forms.DataGridView
        Friend WithEvents btnAplicar As System.Windows.Forms.Button
        Friend WithEvents Menu_Proveedores As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents MnEliminar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents VerDatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents lbl1 As System.Windows.Forms.Label
    End Class
End Namespace