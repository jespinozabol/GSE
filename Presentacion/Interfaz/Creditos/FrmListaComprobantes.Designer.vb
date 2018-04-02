Namespace Interfaz.Creditos
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmListaComprobantes
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
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.gbTipo = New System.Windows.Forms.GroupBox()
            Me.txtDato2 = New System.Windows.Forms.TextBox()
            Me.cmbTipoConsulta = New System.Windows.Forms.ComboBox()
            Me.txtDato = New System.Windows.Forms.TextBox()
            Me.rbVale = New System.Windows.Forms.RadioButton()
            Me.btnBuscar = New System.Windows.Forms.Button()
            Me.rbNDGeneral = New System.Windows.Forms.RadioButton()
            Me.rbRecibos = New System.Windows.Forms.RadioButton()
            Me.rbNC = New System.Windows.Forms.RadioButton()
            Me.dgvLista = New System.Windows.Forms.DataGridView()
            Me.Doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.NombreCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Nula = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.txtNum_Impresiones = New System.Windows.Forms.TextBox()
            Me.chkImpresion = New System.Windows.Forms.CheckBox()
            Me.MnLista = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.txtIdPersona = New System.Windows.Forms.TextBox()
            Me.dgvCliente = New System.Windows.Forms.DataGridView()
            Me.gbTipo.SuspendLayout()
            CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.MnLista.SuspendLayout()
            CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gbTipo
            '
            Me.gbTipo.Controls.Add(Me.txtDato2)
            Me.gbTipo.Controls.Add(Me.cmbTipoConsulta)
            Me.gbTipo.Controls.Add(Me.txtDato)
            Me.gbTipo.Controls.Add(Me.rbVale)
            Me.gbTipo.Controls.Add(Me.btnBuscar)
            Me.gbTipo.Controls.Add(Me.rbNDGeneral)
            Me.gbTipo.Controls.Add(Me.rbRecibos)
            Me.gbTipo.Controls.Add(Me.rbNC)
            Me.gbTipo.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTipo.Location = New System.Drawing.Point(57, 5)
            Me.gbTipo.Name = "gbTipo"
            Me.gbTipo.Size = New System.Drawing.Size(446, 85)
            Me.gbTipo.TabIndex = 0
            Me.gbTipo.TabStop = False
            Me.gbTipo.Text = "consultar los(as)"
            '
            'txtDato2
            '
            Me.txtDato2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDato2.Location = New System.Drawing.Point(121, 23)
            Me.txtDato2.MaxLength = 6
            Me.txtDato2.Name = "txtDato2"
            Me.txtDato2.Size = New System.Drawing.Size(76, 21)
            Me.txtDato2.TabIndex = 250
            Me.txtDato2.Visible = False
            '
            'cmbTipoConsulta
            '
            Me.cmbTipoConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbTipoConsulta.FormattingEnabled = True
            Me.cmbTipoConsulta.Items.AddRange(New Object() {"Todos", "Nombre Cliente", "# Doc", "# Factura"})
            Me.cmbTipoConsulta.Location = New System.Drawing.Point(6, 23)
            Me.cmbTipoConsulta.Name = "cmbTipoConsulta"
            Me.cmbTipoConsulta.Size = New System.Drawing.Size(112, 23)
            Me.cmbTipoConsulta.TabIndex = 249
            '
            'txtDato
            '
            Me.txtDato.Enabled = False
            Me.txtDato.Location = New System.Drawing.Point(121, 23)
            Me.txtDato.Name = "txtDato"
            Me.txtDato.Size = New System.Drawing.Size(264, 23)
            Me.txtDato.TabIndex = 0
            '
            'rbVale
            '
            Me.rbVale.AutoSize = True
            Me.rbVale.Location = New System.Drawing.Point(294, 56)
            Me.rbVale.Name = "rbVale"
            Me.rbVale.Size = New System.Drawing.Size(53, 19)
            Me.rbVale.TabIndex = 11
            Me.rbVale.Text = "Vales"
            Me.rbVale.UseVisualStyleBackColor = True
            '
            'btnBuscar
            '
            Me.btnBuscar.Image = Global.Presentacion.My.Resources.Resources.buscar
            Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnBuscar.Location = New System.Drawing.Point(388, 31)
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(52, 35)
            Me.btnBuscar.TabIndex = 15
            Me.btnBuscar.Text = "Buscar"
            Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnBuscar.UseVisualStyleBackColor = True
            '
            'rbNDGeneral
            '
            Me.rbNDGeneral.AutoSize = True
            Me.rbNDGeneral.Location = New System.Drawing.Point(84, 57)
            Me.rbNDGeneral.Name = "rbNDGeneral"
            Me.rbNDGeneral.Size = New System.Drawing.Size(97, 19)
            Me.rbNDGeneral.TabIndex = 9
            Me.rbNDGeneral.Text = "Notas Débito"
            Me.rbNDGeneral.UseVisualStyleBackColor = True
            '
            'rbRecibos
            '
            Me.rbRecibos.AutoSize = True
            Me.rbRecibos.Checked = True
            Me.rbRecibos.Location = New System.Drawing.Point(10, 56)
            Me.rbRecibos.Name = "rbRecibos"
            Me.rbRecibos.Size = New System.Drawing.Size(68, 19)
            Me.rbRecibos.TabIndex = 10
            Me.rbRecibos.TabStop = True
            Me.rbRecibos.Text = "Recibos"
            Me.rbRecibos.UseVisualStyleBackColor = True
            '
            'rbNC
            '
            Me.rbNC.AutoSize = True
            Me.rbNC.Location = New System.Drawing.Point(187, 56)
            Me.rbNC.Name = "rbNC"
            Me.rbNC.Size = New System.Drawing.Size(101, 19)
            Me.rbNC.TabIndex = 9
            Me.rbNC.Text = "Notas Crédito"
            Me.rbNC.UseVisualStyleBackColor = True
            '
            'dgvLista
            '
            Me.dgvLista.AllowUserToAddRows = False
            Me.dgvLista.AllowUserToDeleteRows = False
            Me.dgvLista.AllowUserToResizeColumns = False
            Me.dgvLista.AllowUserToResizeRows = False
            Me.dgvLista.BackgroundColor = System.Drawing.Color.White
            Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            Me.dgvLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Doc, Me.NombreCliente, Me.Fecha, Me.Monto, Me.Nula})
            Me.dgvLista.GridColor = System.Drawing.Color.White
            Me.dgvLista.Location = New System.Drawing.Point(0, 96)
            Me.dgvLista.MultiSelect = False
            Me.dgvLista.Name = "dgvLista"
            Me.dgvLista.ReadOnly = True
            Me.dgvLista.RowHeadersVisible = False
            Me.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvLista.Size = New System.Drawing.Size(643, 434)
            Me.dgvLista.TabIndex = 18
            '
            'Doc
            '
            Me.Doc.DataPropertyName = "Doc"
            Me.Doc.HeaderText = "# Doc"
            Me.Doc.Name = "Doc"
            Me.Doc.ReadOnly = True
            Me.Doc.Width = 50
            '
            'NombreCliente
            '
            Me.NombreCliente.HeaderText = "Cliente"
            Me.NombreCliente.Name = "NombreCliente"
            Me.NombreCliente.ReadOnly = True
            Me.NombreCliente.Width = 350
            '
            'Fecha
            '
            DataGridViewCellStyle5.Format = "d"
            DataGridViewCellStyle5.NullValue = Nothing
            Me.Fecha.DefaultCellStyle = DataGridViewCellStyle5
            Me.Fecha.HeaderText = "Fecha"
            Me.Fecha.Name = "Fecha"
            Me.Fecha.ReadOnly = True
            Me.Fecha.Width = 75
            '
            'Monto
            '
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle6.Format = "C2"
            DataGridViewCellStyle6.NullValue = Nothing
            Me.Monto.DefaultCellStyle = DataGridViewCellStyle6
            Me.Monto.HeaderText = "Monto"
            Me.Monto.Name = "Monto"
            Me.Monto.ReadOnly = True
            '
            'Nula
            '
            Me.Nula.HeaderText = "Nula"
            Me.Nula.Name = "Nula"
            Me.Nula.ReadOnly = True
            Me.Nula.Width = 40
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.txtNum_Impresiones)
            Me.GroupBox1.Controls.Add(Me.chkImpresion)
            Me.GroupBox1.Location = New System.Drawing.Point(509, 6)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(110, 38)
            Me.GroupBox1.TabIndex = 243
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Impresiones"
            '
            'txtNum_Impresiones
            '
            Me.txtNum_Impresiones.Enabled = False
            Me.txtNum_Impresiones.Location = New System.Drawing.Point(73, 12)
            Me.txtNum_Impresiones.Name = "txtNum_Impresiones"
            Me.txtNum_Impresiones.ReadOnly = True
            Me.txtNum_Impresiones.Size = New System.Drawing.Size(30, 20)
            Me.txtNum_Impresiones.TabIndex = 232
            Me.txtNum_Impresiones.Text = "1"
            Me.txtNum_Impresiones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'chkImpresion
            '
            Me.chkImpresion.AutoSize = True
            Me.chkImpresion.Checked = True
            Me.chkImpresion.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkImpresion.Location = New System.Drawing.Point(6, 15)
            Me.chkImpresion.Name = "chkImpresion"
            Me.chkImpresion.Size = New System.Drawing.Size(70, 17)
            Me.chkImpresion.TabIndex = 231
            Me.chkImpresion.Text = "# copias:"
            Me.chkImpresion.UseVisualStyleBackColor = True
            '
            'MnLista
            '
            Me.MnLista.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerToolStripMenuItem, Me.ImprimirToolStripMenuItem})
            Me.MnLista.Name = "MnAbonar"
            Me.MnLista.Size = New System.Drawing.Size(121, 48)
            '
            'VerToolStripMenuItem
            '
            Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
            Me.VerToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
            Me.VerToolStripMenuItem.Text = "Ver"
            '
            'ImprimirToolStripMenuItem
            '
            Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
            Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
            Me.ImprimirToolStripMenuItem.Text = "Imprimir"
            '
            'txtIdPersona
            '
            Me.txtIdPersona.Enabled = False
            Me.txtIdPersona.Location = New System.Drawing.Point(35, 144)
            Me.txtIdPersona.Name = "txtIdPersona"
            Me.txtIdPersona.Size = New System.Drawing.Size(52, 20)
            Me.txtIdPersona.TabIndex = 244
            '
            'dgvCliente
            '
            Me.dgvCliente.AllowUserToAddRows = False
            Me.dgvCliente.AllowUserToDeleteRows = False
            Me.dgvCliente.BackgroundColor = System.Drawing.Color.White
            Me.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvCliente.GridColor = System.Drawing.Color.White
            Me.dgvCliente.Location = New System.Drawing.Point(178, 51)
            Me.dgvCliente.MultiSelect = False
            Me.dgvCliente.Name = "dgvCliente"
            Me.dgvCliente.ReadOnly = True
            Me.dgvCliente.RowHeadersVisible = False
            Me.dgvCliente.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvCliente.Size = New System.Drawing.Size(313, 105)
            Me.dgvCliente.TabIndex = 250
            Me.dgvCliente.Visible = False
            '
            'FrmListaComprobantes
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(646, 532)
            Me.Controls.Add(Me.dgvCliente)
            Me.Controls.Add(Me.dgvLista)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.gbTipo)
            Me.Controls.Add(Me.txtIdPersona)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmListaComprobantes"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Lista Comprobantes"
            Me.gbTipo.ResumeLayout(False)
            Me.gbTipo.PerformLayout()
            CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.MnLista.ResumeLayout(False)
            CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents gbTipo As System.Windows.Forms.GroupBox
        Friend WithEvents rbRecibos As System.Windows.Forms.RadioButton
        Friend WithEvents rbNDGeneral As System.Windows.Forms.RadioButton
        Friend WithEvents rbNC As System.Windows.Forms.RadioButton
        Friend WithEvents btnBuscar As System.Windows.Forms.Button
        Friend WithEvents rbVale As System.Windows.Forms.RadioButton
        Friend WithEvents dgvLista As System.Windows.Forms.DataGridView
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents txtNum_Impresiones As System.Windows.Forms.TextBox
        Friend WithEvents chkImpresion As System.Windows.Forms.CheckBox
        Friend WithEvents Doc As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents NombreCliente As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Monto As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Nula As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents MnLista As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents VerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ImprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents txtDato As System.Windows.Forms.TextBox
        Friend WithEvents cmbTipoConsulta As System.Windows.Forms.ComboBox
        Friend WithEvents txtIdPersona As System.Windows.Forms.TextBox
        Friend WithEvents dgvCliente As System.Windows.Forms.DataGridView
        Friend WithEvents txtDato2 As System.Windows.Forms.TextBox
    End Class
End Namespace