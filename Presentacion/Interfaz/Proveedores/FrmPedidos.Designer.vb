Namespace Interfaz.Proveedores
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmPedidos
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
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.rbNombre = New System.Windows.Forms.RadioButton()
            Me.rbProveedor = New System.Windows.Forms.RadioButton()
            Me.gbTipo = New System.Windows.Forms.GroupBox()
            Me.rbRangoCodigos = New System.Windows.Forms.RadioButton()
            Me.gbMaterial = New System.Windows.Forms.GroupBox()
            Me.lblDescripcion = New System.Windows.Forms.Label()
            Me.txtDescripcion = New System.Windows.Forms.TextBox()
            Me.dgvProductos = New System.Windows.Forms.DataGridView()
            Me.gbProveedor = New System.Windows.Forms.GroupBox()
            Me.cmbProveedor = New System.Windows.Forms.ComboBox()
            Me.lblProveedor = New System.Windows.Forms.Label()
            Me.lblCodigo = New System.Windows.Forms.Label()
            Me.txtCodigo = New System.Windows.Forms.TextBox()
            Me.btnBuscar = New System.Windows.Forms.Button()
            Me.btnImprimir = New System.Windows.Forms.Button()
            Me.gbRango = New System.Windows.Forms.GroupBox()
            Me.lblCodigo2 = New System.Windows.Forms.Label()
            Me.txtCodigo2 = New System.Windows.Forms.TextBox()
            Me.lblCodigo1 = New System.Windows.Forms.Label()
            Me.txtCodigo1 = New System.Windows.Forms.TextBox()
            Me.chkMostrarExist = New System.Windows.Forms.CheckBox()
            Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Min = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Max = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Exist = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.MaxVendido = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Pedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Proveedores = New System.Windows.Forms.DataGridViewLinkColumn()
            Me.gbTipo.SuspendLayout()
            Me.gbMaterial.SuspendLayout()
            CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbProveedor.SuspendLayout()
            Me.gbRango.SuspendLayout()
            Me.SuspendLayout()
            '
            'rbNombre
            '
            Me.rbNombre.AutoSize = True
            Me.rbNombre.Checked = True
            Me.rbNombre.Location = New System.Drawing.Point(13, 17)
            Me.rbNombre.Name = "rbNombre"
            Me.rbNombre.Size = New System.Drawing.Size(135, 17)
            Me.rbNombre.TabIndex = 29
            Me.rbNombre.TabStop = True
            Me.rbNombre.Text = "Descripción de material"
            Me.rbNombre.UseVisualStyleBackColor = True
            '
            'rbProveedor
            '
            Me.rbProveedor.AutoSize = True
            Me.rbProveedor.Location = New System.Drawing.Point(13, 39)
            Me.rbProveedor.Name = "rbProveedor"
            Me.rbProveedor.Size = New System.Drawing.Size(74, 17)
            Me.rbProveedor.TabIndex = 30
            Me.rbProveedor.Text = "Proveedor"
            Me.rbProveedor.UseVisualStyleBackColor = True
            '
            'gbTipo
            '
            Me.gbTipo.Controls.Add(Me.rbRangoCodigos)
            Me.gbTipo.Controls.Add(Me.rbNombre)
            Me.gbTipo.Controls.Add(Me.rbProveedor)
            Me.gbTipo.Location = New System.Drawing.Point(191, 1)
            Me.gbTipo.Name = "gbTipo"
            Me.gbTipo.Size = New System.Drawing.Size(154, 86)
            Me.gbTipo.TabIndex = 31
            Me.gbTipo.TabStop = False
            Me.gbTipo.Text = "Tipo Busqueda"
            '
            'rbRangoCodigos
            '
            Me.rbRangoCodigos.AutoSize = True
            Me.rbRangoCodigos.Location = New System.Drawing.Point(13, 63)
            Me.rbRangoCodigos.Name = "rbRangoCodigos"
            Me.rbRangoCodigos.Size = New System.Drawing.Size(98, 17)
            Me.rbRangoCodigos.TabIndex = 31
            Me.rbRangoCodigos.Text = "Rango Códigos"
            Me.rbRangoCodigos.UseVisualStyleBackColor = True
            '
            'gbMaterial
            '
            Me.gbMaterial.Controls.Add(Me.lblDescripcion)
            Me.gbMaterial.Controls.Add(Me.txtDescripcion)
            Me.gbMaterial.Location = New System.Drawing.Point(355, 1)
            Me.gbMaterial.Name = "gbMaterial"
            Me.gbMaterial.Size = New System.Drawing.Size(368, 86)
            Me.gbMaterial.TabIndex = 0
            Me.gbMaterial.TabStop = False
            '
            'lblDescripcion
            '
            Me.lblDescripcion.AutoSize = True
            Me.lblDescripcion.Location = New System.Drawing.Point(15, 22)
            Me.lblDescripcion.Name = "lblDescripcion"
            Me.lblDescripcion.Size = New System.Drawing.Size(288, 13)
            Me.lblDescripcion.TabIndex = 1
            Me.lblDescripcion.Text = "Escriba la descripción del material o un patrón de busqueda"
            '
            'txtDescripcion
            '
            Me.txtDescripcion.Location = New System.Drawing.Point(15, 41)
            Me.txtDescripcion.Name = "txtDescripcion"
            Me.txtDescripcion.Size = New System.Drawing.Size(337, 20)
            Me.txtDescripcion.TabIndex = 0
            '
            'dgvProductos
            '
            Me.dgvProductos.AllowUserToAddRows = False
            Me.dgvProductos.AllowUserToDeleteRows = False
            Me.dgvProductos.AllowUserToResizeColumns = False
            Me.dgvProductos.AllowUserToResizeRows = False
            Me.dgvProductos.BackgroundColor = System.Drawing.Color.White
            Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Descripcion, Me.Min, Me.Max, Me.Exist, Me.MaxVendido, Me.Pedido, Me.Proveedores})
            Me.dgvProductos.Location = New System.Drawing.Point(12, 93)
            Me.dgvProductos.MultiSelect = False
            Me.dgvProductos.Name = "dgvProductos"
            Me.dgvProductos.RowHeadersVisible = False
            Me.dgvProductos.RowTemplate.Height = 18
            Me.dgvProductos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
            Me.dgvProductos.Size = New System.Drawing.Size(748, 348)
            Me.dgvProductos.TabIndex = 33
            '
            'gbProveedor
            '
            Me.gbProveedor.Controls.Add(Me.cmbProveedor)
            Me.gbProveedor.Controls.Add(Me.lblProveedor)
            Me.gbProveedor.Controls.Add(Me.lblCodigo)
            Me.gbProveedor.Controls.Add(Me.txtCodigo)
            Me.gbProveedor.Location = New System.Drawing.Point(355, 1)
            Me.gbProveedor.Name = "gbProveedor"
            Me.gbProveedor.Size = New System.Drawing.Size(368, 86)
            Me.gbProveedor.TabIndex = 34
            Me.gbProveedor.TabStop = False
            Me.gbProveedor.Visible = False
            '
            'cmbProveedor
            '
            Me.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbProveedor.FormattingEnabled = True
            Me.cmbProveedor.Location = New System.Drawing.Point(64, 38)
            Me.cmbProveedor.Name = "cmbProveedor"
            Me.cmbProveedor.Size = New System.Drawing.Size(298, 21)
            Me.cmbProveedor.TabIndex = 3
            '
            'lblProveedor
            '
            Me.lblProveedor.AutoSize = True
            Me.lblProveedor.Location = New System.Drawing.Point(61, 21)
            Me.lblProveedor.Name = "lblProveedor"
            Me.lblProveedor.Size = New System.Drawing.Size(56, 13)
            Me.lblProveedor.TabIndex = 2
            Me.lblProveedor.Text = "Proveedor"
            '
            'lblCodigo
            '
            Me.lblCodigo.AutoSize = True
            Me.lblCodigo.Location = New System.Drawing.Point(15, 21)
            Me.lblCodigo.Name = "lblCodigo"
            Me.lblCodigo.Size = New System.Drawing.Size(40, 13)
            Me.lblCodigo.TabIndex = 1
            Me.lblCodigo.Text = "Código"
            '
            'txtCodigo
            '
            Me.txtCodigo.Enabled = False
            Me.txtCodigo.Location = New System.Drawing.Point(15, 40)
            Me.txtCodigo.Name = "txtCodigo"
            Me.txtCodigo.Size = New System.Drawing.Size(40, 20)
            Me.txtCodigo.TabIndex = 0
            '
            'btnBuscar
            '
            Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnBuscar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscar.Image = Global.Presentacion.My.Resources.Resources.buscar
            Me.btnBuscar.Location = New System.Drawing.Point(0, 0)
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(71, 57)
            Me.btnBuscar.TabIndex = 25
            Me.btnBuscar.Text = "Buscar"
            Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnBuscar.UseVisualStyleBackColor = True
            '
            'btnImprimir
            '
            Me.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnImprimir.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnImprimir.Image = Global.Presentacion.My.Resources.Resources.Imprimir
            Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnImprimir.Location = New System.Drawing.Point(70, 0)
            Me.btnImprimir.Name = "btnImprimir"
            Me.btnImprimir.Size = New System.Drawing.Size(71, 57)
            Me.btnImprimir.TabIndex = 35
            Me.btnImprimir.Text = "Imprimir"
            Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnImprimir.UseVisualStyleBackColor = True
            '
            'gbRango
            '
            Me.gbRango.Controls.Add(Me.lblCodigo2)
            Me.gbRango.Controls.Add(Me.txtCodigo2)
            Me.gbRango.Controls.Add(Me.lblCodigo1)
            Me.gbRango.Controls.Add(Me.txtCodigo1)
            Me.gbRango.Location = New System.Drawing.Point(355, 1)
            Me.gbRango.Name = "gbRango"
            Me.gbRango.Size = New System.Drawing.Size(368, 86)
            Me.gbRango.TabIndex = 2
            Me.gbRango.TabStop = False
            Me.gbRango.Visible = False
            '
            'lblCodigo2
            '
            Me.lblCodigo2.AutoSize = True
            Me.lblCodigo2.Location = New System.Drawing.Point(109, 24)
            Me.lblCodigo2.Name = "lblCodigo2"
            Me.lblCodigo2.Size = New System.Drawing.Size(51, 13)
            Me.lblCodigo2.TabIndex = 3
            Me.lblCodigo2.Text = "Cod Final"
            '
            'txtCodigo2
            '
            Me.txtCodigo2.Location = New System.Drawing.Point(109, 43)
            Me.txtCodigo2.Name = "txtCodigo2"
            Me.txtCodigo2.Size = New System.Drawing.Size(82, 20)
            Me.txtCodigo2.TabIndex = 2
            '
            'lblCodigo1
            '
            Me.lblCodigo1.AutoSize = True
            Me.lblCodigo1.Location = New System.Drawing.Point(15, 24)
            Me.lblCodigo1.Name = "lblCodigo1"
            Me.lblCodigo1.Size = New System.Drawing.Size(56, 13)
            Me.lblCodigo1.TabIndex = 1
            Me.lblCodigo1.Text = "Cod Inicial"
            '
            'txtCodigo1
            '
            Me.txtCodigo1.Location = New System.Drawing.Point(15, 43)
            Me.txtCodigo1.Name = "txtCodigo1"
            Me.txtCodigo1.Size = New System.Drawing.Size(82, 20)
            Me.txtCodigo1.TabIndex = 0
            '
            'chkMostrarExist
            '
            Me.chkMostrarExist.AutoSize = True
            Me.chkMostrarExist.Location = New System.Drawing.Point(14, 69)
            Me.chkMostrarExist.Name = "chkMostrarExist"
            Me.chkMostrarExist.Size = New System.Drawing.Size(134, 17)
            Me.chkMostrarExist.TabIndex = 208
            Me.chkMostrarExist.Text = "No Mostrar Existencias"
            Me.chkMostrarExist.UseVisualStyleBackColor = True
            '
            'Codigo
            '
            Me.Codigo.HeaderText = "Código"
            Me.Codigo.Name = "Codigo"
            Me.Codigo.ReadOnly = True
            Me.Codigo.Width = 50
            '
            'Descripcion
            '
            Me.Descripcion.HeaderText = "Descripción"
            Me.Descripcion.Name = "Descripcion"
            Me.Descripcion.ReadOnly = True
            Me.Descripcion.Width = 358
            '
            'Min
            '
            Me.Min.HeaderText = "Mín"
            Me.Min.Name = "Min"
            Me.Min.ReadOnly = True
            Me.Min.Width = 35
            '
            'Max
            '
            Me.Max.HeaderText = "Máx"
            Me.Max.Name = "Max"
            Me.Max.ReadOnly = True
            Me.Max.Width = 35
            '
            'Exist
            '
            DataGridViewCellStyle1.Format = "N2"
            DataGridViewCellStyle1.NullValue = Nothing
            Me.Exist.DefaultCellStyle = DataGridViewCellStyle1
            Me.Exist.HeaderText = "E-Stock"
            Me.Exist.Name = "Exist"
            Me.Exist.ReadOnly = True
            Me.Exist.Width = 50
            '
            'MaxVendido
            '
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.MaxVendido.DefaultCellStyle = DataGridViewCellStyle2
            Me.MaxVendido.HeaderText = "MáxVend"
            Me.MaxVendido.Name = "MaxVendido"
            Me.MaxVendido.ReadOnly = True
            Me.MaxVendido.Width = 60
            '
            'Pedido
            '
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red
            DataGridViewCellStyle3.Format = "N2"
            DataGridViewCellStyle3.NullValue = Nothing
            Me.Pedido.DefaultCellStyle = DataGridViewCellStyle3
            Me.Pedido.HeaderText = "Pedir"
            Me.Pedido.Name = "Pedido"
            Me.Pedido.Width = 58
            '
            'Proveedores
            '
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Proveedores.DefaultCellStyle = DataGridViewCellStyle4
            Me.Proveedores.HeaderText = "Proveedores"
            Me.Proveedores.Name = "Proveedores"
            Me.Proveedores.ReadOnly = True
            Me.Proveedores.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.Proveedores.Width = 80
            '
            'FrmPedidos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(776, 447)
            Me.Controls.Add(Me.chkMostrarExist)
            Me.Controls.Add(Me.btnImprimir)
            Me.Controls.Add(Me.gbTipo)
            Me.Controls.Add(Me.btnBuscar)
            Me.Controls.Add(Me.dgvProductos)
            Me.Controls.Add(Me.gbRango)
            Me.Controls.Add(Me.gbProveedor)
            Me.Controls.Add(Me.gbMaterial)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmPedidos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Informe de Pedidos"
            Me.gbTipo.ResumeLayout(False)
            Me.gbTipo.PerformLayout()
            Me.gbMaterial.ResumeLayout(False)
            Me.gbMaterial.PerformLayout()
            CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbProveedor.ResumeLayout(False)
            Me.gbProveedor.PerformLayout()
            Me.gbRango.ResumeLayout(False)
            Me.gbRango.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents btnBuscar As System.Windows.Forms.Button
        Friend WithEvents rbNombre As System.Windows.Forms.RadioButton
        Friend WithEvents rbProveedor As System.Windows.Forms.RadioButton
        Friend WithEvents gbTipo As System.Windows.Forms.GroupBox
        Friend WithEvents gbMaterial As System.Windows.Forms.GroupBox
        Friend WithEvents dgvProductos As System.Windows.Forms.DataGridView
        Friend WithEvents lblDescripcion As System.Windows.Forms.Label
        Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
        Friend WithEvents gbProveedor As System.Windows.Forms.GroupBox
        Friend WithEvents lblProveedor As System.Windows.Forms.Label
        Friend WithEvents lblCodigo As System.Windows.Forms.Label
        Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
        Friend WithEvents cmbProveedor As System.Windows.Forms.ComboBox
        Friend WithEvents btnImprimir As System.Windows.Forms.Button
        Friend WithEvents rbRangoCodigos As System.Windows.Forms.RadioButton
        Friend WithEvents gbRango As System.Windows.Forms.GroupBox
        Friend WithEvents lblCodigo2 As System.Windows.Forms.Label
        Friend WithEvents txtCodigo2 As System.Windows.Forms.TextBox
        Friend WithEvents lblCodigo1 As System.Windows.Forms.Label
        Friend WithEvents txtCodigo1 As System.Windows.Forms.TextBox
        Friend WithEvents chkMostrarExist As System.Windows.Forms.CheckBox
        Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Min As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Max As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Exist As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents MaxVendido As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Pedido As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Proveedores As System.Windows.Forms.DataGridViewLinkColumn
    End Class
End Namespace