Namespace Interfaz.Proveedores
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmListaRecibos
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
            Me.dgvLista = New System.Windows.Forms.DataGridView()
            Me.gbTipo = New System.Windows.Forms.GroupBox()
            Me.chkRangoFechas = New System.Windows.Forms.CheckBox()
            Me.dtpFinal = New System.Windows.Forms.DateTimePicker()
            Me.lblFechaFinal = New System.Windows.Forms.Label()
            Me.lblFechaInicial = New System.Windows.Forms.Label()
            Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
            Me.txtDato2 = New System.Windows.Forms.TextBox()
            Me.cmbTipoConsulta = New System.Windows.Forms.ComboBox()
            Me.txtDato = New System.Windows.Forms.TextBox()
            Me.rbRecibos = New System.Windows.Forms.RadioButton()
            Me.rbND = New System.Windows.Forms.RadioButton()
            Me.rbNC = New System.Windows.Forms.RadioButton()
            Me.btnBuscar = New System.Windows.Forms.Button()
            Me.txtIdProveedor = New System.Windows.Forms.TextBox()
            Me.MnLista = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.dgvProveedores = New System.Windows.Forms.DataGridView()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.MnNotas = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.VerNotasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.NombreProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
            CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbTipo.SuspendLayout()
            Me.MnLista.SuspendLayout()
            CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.MnNotas.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgvLista
            '
            Me.dgvLista.AllowUserToAddRows = False
            Me.dgvLista.AllowUserToDeleteRows = False
            Me.dgvLista.AllowUserToResizeColumns = False
            Me.dgvLista.AllowUserToResizeRows = False
            Me.dgvLista.BackgroundColor = System.Drawing.Color.White
            Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            Me.dgvLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Tipo, Me.Doc, Me.NombreProveedor, Me.Fecha, Me.Monto})
            Me.dgvLista.GridColor = System.Drawing.Color.White
            Me.dgvLista.Location = New System.Drawing.Point(1, 121)
            Me.dgvLista.MultiSelect = False
            Me.dgvLista.Name = "dgvLista"
            Me.dgvLista.ReadOnly = True
            Me.dgvLista.RowHeadersVisible = False
            Me.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvLista.Size = New System.Drawing.Size(643, 434)
            Me.dgvLista.TabIndex = 253
            '
            'gbTipo
            '
            Me.gbTipo.Controls.Add(Me.chkRangoFechas)
            Me.gbTipo.Controls.Add(Me.dtpFinal)
            Me.gbTipo.Controls.Add(Me.lblFechaFinal)
            Me.gbTipo.Controls.Add(Me.lblFechaInicial)
            Me.gbTipo.Controls.Add(Me.dtpInicio)
            Me.gbTipo.Controls.Add(Me.txtDato2)
            Me.gbTipo.Controls.Add(Me.cmbTipoConsulta)
            Me.gbTipo.Controls.Add(Me.txtDato)
            Me.gbTipo.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTipo.Location = New System.Drawing.Point(81, 5)
            Me.gbTipo.Name = "gbTipo"
            Me.gbTipo.Size = New System.Drawing.Size(482, 70)
            Me.gbTipo.TabIndex = 252
            Me.gbTipo.TabStop = False
            '
            'chkRangoFechas
            '
            Me.chkRangoFechas.AutoSize = True
            Me.chkRangoFechas.Location = New System.Drawing.Point(12, 47)
            Me.chkRangoFechas.Name = "chkRangoFechas"
            Me.chkRangoFechas.Size = New System.Drawing.Size(101, 19)
            Me.chkRangoFechas.TabIndex = 284
            Me.chkRangoFechas.Text = "Rango Fechas"
            Me.chkRangoFechas.UseVisualStyleBackColor = True
            '
            'dtpFinal
            '
            Me.dtpFinal.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFinal.Enabled = False
            Me.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFinal.Location = New System.Drawing.Point(376, 44)
            Me.dtpFinal.MaxDate = New Date(3000, 12, 31, 0, 0, 0, 0)
            Me.dtpFinal.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
            Me.dtpFinal.Name = "dtpFinal"
            Me.dtpFinal.Size = New System.Drawing.Size(99, 23)
            Me.dtpFinal.TabIndex = 281
            Me.dtpFinal.Value = New Date(2011, 12, 27, 0, 0, 0, 0)
            '
            'lblFechaFinal
            '
            Me.lblFechaFinal.AutoSize = True
            Me.lblFechaFinal.Enabled = False
            Me.lblFechaFinal.Location = New System.Drawing.Point(303, 49)
            Me.lblFechaFinal.Name = "lblFechaFinal"
            Me.lblFechaFinal.Size = New System.Drawing.Size(67, 15)
            Me.lblFechaFinal.TabIndex = 283
            Me.lblFechaFinal.Text = "Fecha Final"
            '
            'lblFechaInicial
            '
            Me.lblFechaInicial.AutoSize = True
            Me.lblFechaInicial.Enabled = False
            Me.lblFechaInicial.Location = New System.Drawing.Point(118, 49)
            Me.lblFechaInicial.Name = "lblFechaInicial"
            Me.lblFechaInicial.Size = New System.Drawing.Size(74, 15)
            Me.lblFechaInicial.TabIndex = 282
            Me.lblFechaInicial.Text = "Fecha Inicial"
            '
            'dtpInicio
            '
            Me.dtpInicio.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpInicio.Enabled = False
            Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpInicio.Location = New System.Drawing.Point(198, 44)
            Me.dtpInicio.MaxDate = New Date(3000, 12, 31, 0, 0, 0, 0)
            Me.dtpInicio.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
            Me.dtpInicio.Name = "dtpInicio"
            Me.dtpInicio.Size = New System.Drawing.Size(99, 23)
            Me.dtpInicio.TabIndex = 280
            Me.dtpInicio.Value = New Date(2011, 12, 27, 0, 0, 0, 0)
            '
            'txtDato2
            '
            Me.txtDato2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDato2.Location = New System.Drawing.Point(126, 17)
            Me.txtDato2.MaxLength = 20
            Me.txtDato2.Name = "txtDato2"
            Me.txtDato2.Size = New System.Drawing.Size(123, 21)
            Me.txtDato2.TabIndex = 250
            Me.txtDato2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.txtDato2.Visible = False
            '
            'cmbTipoConsulta
            '
            Me.cmbTipoConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbTipoConsulta.FormattingEnabled = True
            Me.cmbTipoConsulta.Items.AddRange(New Object() {"Todos", "Nombre Proveedor", "# Doc", "# Factura"})
            Me.cmbTipoConsulta.Location = New System.Drawing.Point(11, 16)
            Me.cmbTipoConsulta.Name = "cmbTipoConsulta"
            Me.cmbTipoConsulta.Size = New System.Drawing.Size(112, 23)
            Me.cmbTipoConsulta.TabIndex = 249
            '
            'txtDato
            '
            Me.txtDato.Enabled = False
            Me.txtDato.Location = New System.Drawing.Point(126, 16)
            Me.txtDato.Name = "txtDato"
            Me.txtDato.Size = New System.Drawing.Size(264, 23)
            Me.txtDato.TabIndex = 247
            '
            'rbRecibos
            '
            Me.rbRecibos.AutoSize = True
            Me.rbRecibos.Checked = True
            Me.rbRecibos.Location = New System.Drawing.Point(120, 11)
            Me.rbRecibos.Name = "rbRecibos"
            Me.rbRecibos.Size = New System.Drawing.Size(64, 17)
            Me.rbRecibos.TabIndex = 10
            Me.rbRecibos.TabStop = True
            Me.rbRecibos.Text = "Recibos"
            Me.rbRecibos.UseVisualStyleBackColor = True
            '
            'rbND
            '
            Me.rbND.AutoSize = True
            Me.rbND.Location = New System.Drawing.Point(205, 11)
            Me.rbND.Name = "rbND"
            Me.rbND.Size = New System.Drawing.Size(87, 17)
            Me.rbND.TabIndex = 9
            Me.rbND.Text = "Notas Débito"
            Me.rbND.UseVisualStyleBackColor = True
            '
            'rbNC
            '
            Me.rbNC.AutoSize = True
            Me.rbNC.Location = New System.Drawing.Point(307, 11)
            Me.rbNC.Name = "rbNC"
            Me.rbNC.Size = New System.Drawing.Size(89, 17)
            Me.rbNC.TabIndex = 9
            Me.rbNC.Text = "Notas Crédito"
            Me.rbNC.UseVisualStyleBackColor = True
            '
            'btnBuscar
            '
            Me.btnBuscar.Image = Global.Presentacion.My.Resources.Resources.buscar
            Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnBuscar.Location = New System.Drawing.Point(582, 41)
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(52, 35)
            Me.btnBuscar.TabIndex = 256
            Me.btnBuscar.Text = "Buscar"
            Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnBuscar.UseVisualStyleBackColor = True
            '
            'txtIdProveedor
            '
            Me.txtIdProveedor.Location = New System.Drawing.Point(3, 21)
            Me.txtIdProveedor.Name = "txtIdProveedor"
            Me.txtIdProveedor.Size = New System.Drawing.Size(62, 20)
            Me.txtIdProveedor.TabIndex = 251
            Me.txtIdProveedor.Visible = False
            '
            'MnLista
            '
            Me.MnLista.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.EditarToolStripMenuItem, Me.ImprimirToolStripMenuItem})
            Me.MnLista.Name = "MnLista"
            Me.MnLista.Size = New System.Drawing.Size(121, 92)
            '
            'VerToolStripMenuItem
            '
            Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
            Me.VerToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
            Me.VerToolStripMenuItem.Text = "Ver"
            '
            'EliminarToolStripMenuItem
            '
            Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
            Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
            Me.EliminarToolStripMenuItem.Text = "Eliminar"
            '
            'EditarToolStripMenuItem
            '
            Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
            Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
            Me.EditarToolStripMenuItem.Text = "Editar"
            '
            'ImprimirToolStripMenuItem
            '
            Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
            Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
            Me.ImprimirToolStripMenuItem.Text = "Imprimir"
            '
            'dgvProveedores
            '
            Me.dgvProveedores.AllowUserToAddRows = False
            Me.dgvProveedores.AllowUserToDeleteRows = False
            Me.dgvProveedores.AllowUserToResizeColumns = False
            Me.dgvProveedores.AllowUserToResizeRows = False
            Me.dgvProveedores.BackgroundColor = System.Drawing.Color.White
            Me.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvProveedores.GridColor = System.Drawing.Color.White
            Me.dgvProveedores.Location = New System.Drawing.Point(207, 45)
            Me.dgvProveedores.MultiSelect = False
            Me.dgvProveedores.Name = "dgvProveedores"
            Me.dgvProveedores.ReadOnly = True
            Me.dgvProveedores.RowHeadersVisible = False
            Me.dgvProveedores.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvProveedores.Size = New System.Drawing.Size(313, 105)
            Me.dgvProveedores.TabIndex = 255
            Me.dgvProveedores.Visible = False
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.rbRecibos)
            Me.GroupBox1.Controls.Add(Me.rbND)
            Me.GroupBox1.Controls.Add(Me.rbNC)
            Me.GroupBox1.Location = New System.Drawing.Point(81, 81)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(481, 34)
            Me.GroupBox1.TabIndex = 257
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Consultar los(as)"
            '
            'MnNotas
            '
            Me.MnNotas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerNotasToolStripMenuItem1})
            Me.MnNotas.Name = "MnLista"
            Me.MnNotas.Size = New System.Drawing.Size(92, 26)
            '
            'VerNotasToolStripMenuItem1
            '
            Me.VerNotasToolStripMenuItem1.Name = "VerNotasToolStripMenuItem1"
            Me.VerNotasToolStripMenuItem1.Size = New System.Drawing.Size(91, 22)
            Me.VerNotasToolStripMenuItem1.Text = "Ver"
            '
            'ID
            '
            Me.ID.HeaderText = "ID"
            Me.ID.Name = "ID"
            Me.ID.ReadOnly = True
            Me.ID.Width = 45
            '
            'Tipo
            '
            Me.Tipo.HeaderText = "Tipo"
            Me.Tipo.Name = "Tipo"
            Me.Tipo.ReadOnly = True
            Me.Tipo.Width = 40
            '
            'Doc
            '
            Me.Doc.DataPropertyName = "Doc"
            Me.Doc.HeaderText = "# Doc"
            Me.Doc.Name = "Doc"
            Me.Doc.ReadOnly = True
            Me.Doc.Width = 105
            '
            'NombreProveedor
            '
            Me.NombreProveedor.HeaderText = "Proveedor"
            Me.NombreProveedor.Name = "NombreProveedor"
            Me.NombreProveedor.ReadOnly = True
            Me.NombreProveedor.Width = 240
            '
            'Fecha
            '
            DataGridViewCellStyle1.Format = "d"
            DataGridViewCellStyle1.NullValue = Nothing
            Me.Fecha.DefaultCellStyle = DataGridViewCellStyle1
            Me.Fecha.HeaderText = "Fecha"
            Me.Fecha.Name = "Fecha"
            Me.Fecha.ReadOnly = True
            Me.Fecha.Width = 75
            '
            'Monto
            '
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle2.Format = "C2"
            DataGridViewCellStyle2.NullValue = Nothing
            Me.Monto.DefaultCellStyle = DataGridViewCellStyle2
            Me.Monto.HeaderText = "Monto"
            Me.Monto.Name = "Monto"
            Me.Monto.ReadOnly = True
            Me.Monto.Width = 112
            '
            'FrmListaRecibos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(646, 557)
            Me.Controls.Add(Me.dgvProveedores)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.btnBuscar)
            Me.Controls.Add(Me.gbTipo)
            Me.Controls.Add(Me.txtIdProveedor)
            Me.Controls.Add(Me.dgvLista)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmListaRecibos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "FrmLista_Recibos"
            CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbTipo.ResumeLayout(False)
            Me.gbTipo.PerformLayout()
            Me.MnLista.ResumeLayout(False)
            CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.MnNotas.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvLista As System.Windows.Forms.DataGridView
        Friend WithEvents gbTipo As System.Windows.Forms.GroupBox
        Friend WithEvents txtDato2 As System.Windows.Forms.TextBox
        Friend WithEvents cmbTipoConsulta As System.Windows.Forms.ComboBox
        Friend WithEvents txtDato As System.Windows.Forms.TextBox
        Friend WithEvents rbRecibos As System.Windows.Forms.RadioButton
        Friend WithEvents rbND As System.Windows.Forms.RadioButton
        Friend WithEvents rbNC As System.Windows.Forms.RadioButton
        Friend WithEvents txtIdProveedor As System.Windows.Forms.TextBox
        Friend WithEvents btnBuscar As System.Windows.Forms.Button
        Friend WithEvents MnLista As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents VerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents chkRangoFechas As System.Windows.Forms.CheckBox
        Friend WithEvents dtpFinal As System.Windows.Forms.DateTimePicker
        Friend WithEvents lblFechaFinal As System.Windows.Forms.Label
        Friend WithEvents lblFechaInicial As System.Windows.Forms.Label
        Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
        Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents dgvProveedores As System.Windows.Forms.DataGridView
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents ImprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents MnNotas As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents VerNotasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Tipo As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Doc As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents NombreProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Monto As System.Windows.Forms.DataGridViewTextBoxColumn
    End Class
End Namespace