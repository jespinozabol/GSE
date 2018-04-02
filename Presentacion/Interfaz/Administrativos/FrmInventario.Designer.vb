Namespace Interfaz.Administrativos
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmInventario
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
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.lblCodigo2 = New System.Windows.Forms.Label()
            Me.btnBuscar = New System.Windows.Forms.Button()
            Me.txtCodFinal = New System.Windows.Forms.TextBox()
            Me.txtCodInicial = New System.Windows.Forms.TextBox()
            Me.lblCodigo1 = New System.Windows.Forms.Label()
            Me.dgvProductos = New System.Windows.Forms.DataGridView()
            Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.PUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Ex = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.lblTotal = New System.Windows.Forms.Label()
            Me.lblMostarTotal = New System.Windows.Forms.Label()
            Me.btnExportar = New System.Windows.Forms.Button()
            Me.gbTipo = New System.Windows.Forms.GroupBox()
            Me.rbTodas = New System.Windows.Forms.RadioButton()
            Me.rbConsignacion = New System.Windows.Forms.RadioButton()
            Me.rbSinConsignacion = New System.Windows.Forms.RadioButton()
            Me.cmbTipoConsulta = New System.Windows.Forms.ComboBox()
            Me.Catalogo = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbTipo.SuspendLayout()
            Me.Catalogo.SuspendLayout()
            Me.SuspendLayout()
            '
            'lblCodigo2
            '
            Me.lblCodigo2.AutoSize = True
            Me.lblCodigo2.Location = New System.Drawing.Point(336, 25)
            Me.lblCodigo2.Name = "lblCodigo2"
            Me.lblCodigo2.Size = New System.Drawing.Size(56, 15)
            Me.lblCodigo2.TabIndex = 32
            Me.lblCodigo2.Text = "Cod Final"
            '
            'btnBuscar
            '
            Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnBuscar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscar.Image = Global.Presentacion.My.Resources.Resources.buscar
            Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnBuscar.Location = New System.Drawing.Point(636, 24)
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(71, 40)
            Me.btnBuscar.TabIndex = 33
            Me.btnBuscar.Text = "Buscar"
            Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnBuscar.UseVisualStyleBackColor = True
            '
            'txtCodFinal
            '
            Me.txtCodFinal.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCodFinal.Location = New System.Drawing.Point(394, 21)
            Me.txtCodFinal.Name = "txtCodFinal"
            Me.txtCodFinal.Size = New System.Drawing.Size(82, 22)
            Me.txtCodFinal.TabIndex = 31
            Me.txtCodFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtCodInicial
            '
            Me.txtCodInicial.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCodInicial.Location = New System.Drawing.Point(250, 21)
            Me.txtCodInicial.Name = "txtCodInicial"
            Me.txtCodInicial.Size = New System.Drawing.Size(82, 22)
            Me.txtCodInicial.TabIndex = 0
            Me.txtCodInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblCodigo1
            '
            Me.lblCodigo1.AutoSize = True
            Me.lblCodigo1.Location = New System.Drawing.Point(184, 25)
            Me.lblCodigo1.Name = "lblCodigo1"
            Me.lblCodigo1.Size = New System.Drawing.Size(63, 15)
            Me.lblCodigo1.TabIndex = 30
            Me.lblCodigo1.Text = "Cod Inicial"
            '
            'dgvProductos
            '
            Me.dgvProductos.AllowUserToAddRows = False
            Me.dgvProductos.AllowUserToDeleteRows = False
            Me.dgvProductos.AllowUserToResizeColumns = False
            Me.dgvProductos.AllowUserToResizeRows = False
            Me.dgvProductos.BackgroundColor = System.Drawing.Color.White
            Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            Me.dgvProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Descripcion, Me.PUnitario, Me.Cant, Me.Total, Me.Ex})
            Me.dgvProductos.Location = New System.Drawing.Point(6, 84)
            Me.dgvProductos.MultiSelect = False
            Me.dgvProductos.Name = "dgvProductos"
            Me.dgvProductos.ReadOnly = True
            Me.dgvProductos.RowHeadersVisible = False
            Me.dgvProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
            Me.dgvProductos.RowTemplate.Height = 18
            Me.dgvProductos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvProductos.Size = New System.Drawing.Size(716, 429)
            Me.dgvProductos.TabIndex = 35
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
            Me.Descripcion.Width = 345
            '
            'PUnitario
            '
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle1.Format = "C2"
            DataGridViewCellStyle1.NullValue = Nothing
            Me.PUnitario.DefaultCellStyle = DataGridViewCellStyle1
            Me.PUnitario.HeaderText = "P/Costo"
            Me.PUnitario.Name = "PUnitario"
            Me.PUnitario.ReadOnly = True
            Me.PUnitario.Width = 85
            '
            'Cant
            '
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle2.Format = "N2"
            DataGridViewCellStyle2.NullValue = Nothing
            Me.Cant.DefaultCellStyle = DataGridViewCellStyle2
            Me.Cant.HeaderText = "Cant"
            Me.Cant.Name = "Cant"
            Me.Cant.ReadOnly = True
            Me.Cant.Width = 55
            '
            'Total
            '
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle3.Format = "C2"
            DataGridViewCellStyle3.NullValue = Nothing
            Me.Total.DefaultCellStyle = DataGridViewCellStyle3
            Me.Total.HeaderText = "Total"
            Me.Total.Name = "Total"
            Me.Total.ReadOnly = True
            Me.Total.Width = 120
            '
            'Ex
            '
            Me.Ex.HeaderText = "Ex"
            Me.Ex.Name = "Ex"
            Me.Ex.ReadOnly = True
            Me.Ex.Width = 30
            '
            'lblTotal
            '
            Me.lblTotal.AutoSize = True
            Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotal.Location = New System.Drawing.Point(483, 516)
            Me.lblTotal.Name = "lblTotal"
            Me.lblTotal.Size = New System.Drawing.Size(62, 24)
            Me.lblTotal.TabIndex = 36
            Me.lblTotal.Text = "Total:"
            '
            'lblMostarTotal
            '
            Me.lblMostarTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostarTotal.Location = New System.Drawing.Point(551, 516)
            Me.lblMostarTotal.Name = "lblMostarTotal"
            Me.lblMostarTotal.Size = New System.Drawing.Size(173, 24)
            Me.lblMostarTotal.TabIndex = 37
            Me.lblMostarTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'btnExportar
            '
            Me.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnExportar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnExportar.Location = New System.Drawing.Point(0, 0)
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(71, 57)
            Me.btnExportar.TabIndex = 38
            Me.btnExportar.Text = "Exportar ó Imprimir"
            Me.btnExportar.UseVisualStyleBackColor = True
            '
            'gbTipo
            '
            Me.gbTipo.Controls.Add(Me.rbTodas)
            Me.gbTipo.Controls.Add(Me.rbConsignacion)
            Me.gbTipo.Controls.Add(Me.rbSinConsignacion)
            Me.gbTipo.Controls.Add(Me.lblCodigo2)
            Me.gbTipo.Controls.Add(Me.txtCodFinal)
            Me.gbTipo.Controls.Add(Me.txtCodInicial)
            Me.gbTipo.Controls.Add(Me.lblCodigo1)
            Me.gbTipo.Controls.Add(Me.cmbTipoConsulta)
            Me.gbTipo.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTipo.Location = New System.Drawing.Point(147, 0)
            Me.gbTipo.Name = "gbTipo"
            Me.gbTipo.Size = New System.Drawing.Size(483, 78)
            Me.gbTipo.TabIndex = 0
            Me.gbTipo.TabStop = False
            Me.gbTipo.Text = "Consultar por"
            '
            'rbTodas
            '
            Me.rbTodas.AutoSize = True
            Me.rbTodas.Checked = True
            Me.rbTodas.Location = New System.Drawing.Point(23, 53)
            Me.rbTodas.Name = "rbTodas"
            Me.rbTodas.Size = New System.Drawing.Size(56, 19)
            Me.rbTodas.TabIndex = 276
            Me.rbTodas.TabStop = True
            Me.rbTodas.Text = "Todas"
            Me.rbTodas.UseVisualStyleBackColor = True
            '
            'rbConsignacion
            '
            Me.rbConsignacion.AutoSize = True
            Me.rbConsignacion.Location = New System.Drawing.Point(100, 52)
            Me.rbConsignacion.Name = "rbConsignacion"
            Me.rbConsignacion.Size = New System.Drawing.Size(97, 19)
            Me.rbConsignacion.TabIndex = 275
            Me.rbConsignacion.Text = "Consignación"
            Me.rbConsignacion.UseVisualStyleBackColor = True
            '
            'rbSinConsignacion
            '
            Me.rbSinConsignacion.AutoSize = True
            Me.rbSinConsignacion.Location = New System.Drawing.Point(208, 51)
            Me.rbSinConsignacion.Name = "rbSinConsignacion"
            Me.rbSinConsignacion.Size = New System.Drawing.Size(107, 19)
            Me.rbSinConsignacion.TabIndex = 274
            Me.rbSinConsignacion.Text = "S/Consignación"
            Me.rbSinConsignacion.UseVisualStyleBackColor = True
            '
            'cmbTipoConsulta
            '
            Me.cmbTipoConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbTipoConsulta.FormattingEnabled = True
            Me.cmbTipoConsulta.Items.AddRange(New Object() {"Todos", "Con existencias positivas", "Con existencias negativas"})
            Me.cmbTipoConsulta.Location = New System.Drawing.Point(6, 20)
            Me.cmbTipoConsulta.Name = "cmbTipoConsulta"
            Me.cmbTipoConsulta.Size = New System.Drawing.Size(172, 23)
            Me.cmbTipoConsulta.TabIndex = 249
            '
            'Catalogo
            '
            Me.Catalogo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem})
            Me.Catalogo.Name = "Catalogo"
            Me.Catalogo.Size = New System.Drawing.Size(105, 26)
            '
            'EditarToolStripMenuItem
            '
            Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
            Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
            Me.EditarToolStripMenuItem.Text = "Editar"
            '
            'FrmInventario
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(730, 551)
            Me.Controls.Add(Me.gbTipo)
            Me.Controls.Add(Me.btnExportar)
            Me.Controls.Add(Me.lblMostarTotal)
            Me.Controls.Add(Me.lblTotal)
            Me.Controls.Add(Me.dgvProductos)
            Me.Controls.Add(Me.btnBuscar)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmInventario"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "FrmInventario"
            CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbTipo.ResumeLayout(False)
            Me.gbTipo.PerformLayout()
            Me.Catalogo.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents lblCodigo2 As System.Windows.Forms.Label
        Friend WithEvents btnBuscar As System.Windows.Forms.Button
        Friend WithEvents txtCodFinal As System.Windows.Forms.TextBox
        Friend WithEvents txtCodInicial As System.Windows.Forms.TextBox
        Friend WithEvents lblCodigo1 As System.Windows.Forms.Label
        Friend WithEvents dgvProductos As System.Windows.Forms.DataGridView
        Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents PUnitario As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Cant As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Ex As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents lblTotal As System.Windows.Forms.Label
        Friend WithEvents lblMostarTotal As System.Windows.Forms.Label
        Friend WithEvents btnExportar As System.Windows.Forms.Button
        Friend WithEvents gbTipo As System.Windows.Forms.GroupBox
        Friend WithEvents rbTodas As System.Windows.Forms.RadioButton
        Friend WithEvents rbConsignacion As System.Windows.Forms.RadioButton
        Friend WithEvents rbSinConsignacion As System.Windows.Forms.RadioButton
        Friend WithEvents cmbTipoConsulta As System.Windows.Forms.ComboBox
        Friend WithEvents Catalogo As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace