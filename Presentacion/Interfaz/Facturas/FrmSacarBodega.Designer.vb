Namespace Interfaz.Facturas
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmSacarBodega
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
            Me.dgvMostrarProductos = New System.Windows.Forms.DataGridView()
            Me.txtCodigo = New System.Windows.Forms.TextBox()
            Me.txtArticulo = New System.Windows.Forms.TextBox()
            Me.lbl1 = New System.Windows.Forms.Label()
            Me.lblCodigo = New System.Windows.Forms.Label()
            Me.lblArticulo = New System.Windows.Forms.Label()
            Me.txtCantidad = New System.Windows.Forms.TextBox()
            Me.lblCantidad = New System.Windows.Forms.Label()
            Me.txtExist_Bodega = New System.Windows.Forms.TextBox()
            Me.lblExis_Bodega = New System.Windows.Forms.Label()
            Me.btnRetirarBodega = New System.Windows.Forms.Button()
            Me.btnCorregir = New System.Windows.Forms.Button()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.txtDespues = New System.Windows.Forms.TextBox()
            Me.lblDespues = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            CType(Me.dgvMostrarProductos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgvMostrarProductos
            '
            Me.dgvMostrarProductos.AllowUserToAddRows = False
            Me.dgvMostrarProductos.AllowUserToDeleteRows = False
            Me.dgvMostrarProductos.AllowUserToResizeColumns = False
            Me.dgvMostrarProductos.BackgroundColor = System.Drawing.Color.White
            Me.dgvMostrarProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
            Me.dgvMostrarProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            Me.dgvMostrarProductos.GridColor = System.Drawing.Color.White
            Me.dgvMostrarProductos.Location = New System.Drawing.Point(12, 69)
            Me.dgvMostrarProductos.MultiSelect = False
            Me.dgvMostrarProductos.Name = "dgvMostrarProductos"
            Me.dgvMostrarProductos.ReadOnly = True
            Me.dgvMostrarProductos.RowHeadersVisible = False
            Me.dgvMostrarProductos.RowTemplate.Height = 18
            Me.dgvMostrarProductos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvMostrarProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvMostrarProductos.Size = New System.Drawing.Size(414, 127)
            Me.dgvMostrarProductos.TabIndex = 167
            Me.dgvMostrarProductos.Visible = False
            '
            'txtCodigo
            '
            Me.txtCodigo.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtCodigo.Location = New System.Drawing.Point(12, 47)
            Me.txtCodigo.Name = "txtCodigo"
            Me.txtCodigo.Size = New System.Drawing.Size(53, 20)
            Me.txtCodigo.TabIndex = 166
            '
            'txtArticulo
            '
            Me.txtArticulo.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtArticulo.Location = New System.Drawing.Point(67, 47)
            Me.txtArticulo.Name = "txtArticulo"
            Me.txtArticulo.Size = New System.Drawing.Size(313, 20)
            Me.txtArticulo.TabIndex = 165
            '
            'lbl1
            '
            Me.lbl1.AutoSize = True
            Me.lbl1.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbl1.Location = New System.Drawing.Point(134, 9)
            Me.lbl1.Name = "lbl1"
            Me.lbl1.Size = New System.Drawing.Size(181, 23)
            Me.lbl1.TabIndex = 168
            Me.lbl1.Text = "Descontar de Bodega"
            '
            'lblCodigo
            '
            Me.lblCodigo.AutoSize = True
            Me.lblCodigo.BackColor = System.Drawing.Color.Transparent
            Me.lblCodigo.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblCodigo.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCodigo.Location = New System.Drawing.Point(17, 30)
            Me.lblCodigo.Name = "lblCodigo"
            Me.lblCodigo.Size = New System.Drawing.Size(44, 14)
            Me.lblCodigo.TabIndex = 170
            Me.lblCodigo.Text = "Código"
            '
            'lblArticulo
            '
            Me.lblArticulo.AutoSize = True
            Me.lblArticulo.BackColor = System.Drawing.Color.Transparent
            Me.lblArticulo.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblArticulo.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblArticulo.Location = New System.Drawing.Point(72, 30)
            Me.lblArticulo.Name = "lblArticulo"
            Me.lblArticulo.Size = New System.Drawing.Size(46, 14)
            Me.lblArticulo.TabIndex = 169
            Me.lblArticulo.Text = "Artículo"
            '
            'txtCantidad
            '
            Me.txtCantidad.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCantidad.Location = New System.Drawing.Point(8, 53)
            Me.txtCantidad.MaxLength = 8
            Me.txtCantidad.Name = "txtCantidad"
            Me.txtCantidad.Size = New System.Drawing.Size(69, 22)
            Me.txtCantidad.TabIndex = 172
            Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblCantidad
            '
            Me.lblCantidad.AutoSize = True
            Me.lblCantidad.BackColor = System.Drawing.Color.Transparent
            Me.lblCantidad.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblCantidad.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCantidad.Location = New System.Drawing.Point(12, 36)
            Me.lblCantidad.Name = "lblCantidad"
            Me.lblCantidad.Size = New System.Drawing.Size(57, 15)
            Me.lblCantidad.TabIndex = 171
            Me.lblCantidad.Text = "A Retirar"
            '
            'txtExist_Bodega
            '
            Me.txtExist_Bodega.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtExist_Bodega.Enabled = False
            Me.txtExist_Bodega.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtExist_Bodega.Location = New System.Drawing.Point(28, 46)
            Me.txtExist_Bodega.MaxLength = 10
            Me.txtExist_Bodega.Name = "txtExist_Bodega"
            Me.txtExist_Bodega.Size = New System.Drawing.Size(64, 22)
            Me.txtExist_Bodega.TabIndex = 173
            Me.txtExist_Bodega.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblExis_Bodega
            '
            Me.lblExis_Bodega.AutoSize = True
            Me.lblExis_Bodega.BackColor = System.Drawing.Color.Transparent
            Me.lblExis_Bodega.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblExis_Bodega.Location = New System.Drawing.Point(25, 30)
            Me.lblExis_Bodega.Name = "lblExis_Bodega"
            Me.lblExis_Bodega.Size = New System.Drawing.Size(39, 15)
            Me.lblExis_Bodega.TabIndex = 174
            Me.lblExis_Bodega.Text = "Antes"
            '
            'btnRetirarBodega
            '
            Me.btnRetirarBodega.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnRetirarBodega.Image = Global.Presentacion.My.Resources.Resources.Guardar
            Me.btnRetirarBodega.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnRetirarBodega.Location = New System.Drawing.Point(19, 29)
            Me.btnRetirarBodega.Name = "btnRetirarBodega"
            Me.btnRetirarBodega.Size = New System.Drawing.Size(73, 55)
            Me.btnRetirarBodega.TabIndex = 176
            Me.btnRetirarBodega.Text = "Guardar"
            Me.btnRetirarBodega.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnRetirarBodega.UseVisualStyleBackColor = True
            '
            'btnCorregir
            '
            Me.btnCorregir.Location = New System.Drawing.Point(118, 47)
            Me.btnCorregir.Name = "btnCorregir"
            Me.btnCorregir.Size = New System.Drawing.Size(67, 47)
            Me.btnCorregir.TabIndex = 177
            Me.btnCorregir.Text = "Corregir"
            Me.btnCorregir.UseVisualStyleBackColor = True
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.txtCantidad)
            Me.GroupBox1.Controls.Add(Me.lblCantidad)
            Me.GroupBox1.Location = New System.Drawing.Point(12, 73)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(96, 114)
            Me.GroupBox1.TabIndex = 178
            Me.GroupBox1.TabStop = False
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.Label2)
            Me.GroupBox2.Controls.Add(Me.txtDespues)
            Me.GroupBox2.Controls.Add(Me.lblDespues)
            Me.GroupBox2.Controls.Add(Me.btnCorregir)
            Me.GroupBox2.Controls.Add(Me.txtExist_Bodega)
            Me.GroupBox2.Controls.Add(Me.lblExis_Bodega)
            Me.GroupBox2.Location = New System.Drawing.Point(110, 72)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(201, 115)
            Me.GroupBox2.TabIndex = 179
            Me.GroupBox2.TabStop = False
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.btnRetirarBodega)
            Me.GroupBox3.Location = New System.Drawing.Point(313, 72)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(113, 115)
            Me.GroupBox3.TabIndex = 179
            Me.GroupBox3.TabStop = False
            '
            'txtDespues
            '
            Me.txtDespues.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtDespues.Enabled = False
            Me.txtDespues.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDespues.Location = New System.Drawing.Point(28, 85)
            Me.txtDespues.MaxLength = 10
            Me.txtDespues.Name = "txtDespues"
            Me.txtDespues.Size = New System.Drawing.Size(64, 22)
            Me.txtDespues.TabIndex = 178
            Me.txtDespues.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblDespues
            '
            Me.lblDespues.AutoSize = True
            Me.lblDespues.BackColor = System.Drawing.Color.Transparent
            Me.lblDespues.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDespues.Location = New System.Drawing.Point(25, 69)
            Me.lblDespues.Name = "lblDespues"
            Me.lblDespues.Size = New System.Drawing.Size(53, 15)
            Me.lblDespues.TabIndex = 179
            Me.lblDespues.Text = "Despues"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(37, 10)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(130, 15)
            Me.Label2.TabIndex = 180
            Me.Label2.Text = "Existencias en Bodega"
            '
            'FrmSacar_Bodega
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(442, 197)
            Me.Controls.Add(Me.dgvMostrarProductos)
            Me.Controls.Add(Me.GroupBox3)
            Me.Controls.Add(Me.GroupBox2)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.lblCodigo)
            Me.Controls.Add(Me.lblArticulo)
            Me.Controls.Add(Me.lbl1)
            Me.Controls.Add(Me.txtCodigo)
            Me.Controls.Add(Me.txtArticulo)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmSacar_Bodega"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Retirar existencias de Bodega"
            CType(Me.dgvMostrarProductos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.GroupBox3.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvMostrarProductos As System.Windows.Forms.DataGridView
        Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
        Friend WithEvents txtArticulo As System.Windows.Forms.TextBox
        Friend WithEvents lbl1 As System.Windows.Forms.Label
        Friend WithEvents lblCodigo As System.Windows.Forms.Label
        Friend WithEvents lblArticulo As System.Windows.Forms.Label
        Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
        Friend WithEvents lblCantidad As System.Windows.Forms.Label
        Friend WithEvents txtExist_Bodega As System.Windows.Forms.TextBox
        Friend WithEvents lblExis_Bodega As System.Windows.Forms.Label
        Friend WithEvents btnRetirarBodega As System.Windows.Forms.Button
        Friend WithEvents btnCorregir As System.Windows.Forms.Button
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents txtDespues As System.Windows.Forms.TextBox
        Friend WithEvents lblDespues As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
    End Class
End Namespace