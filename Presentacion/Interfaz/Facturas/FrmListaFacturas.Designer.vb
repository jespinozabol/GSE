Namespace Interfaz.Facturas
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmListaFacturas
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
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.dgvCliente = New System.Windows.Forms.DataGridView()
            Me.dgvLista = New System.Windows.Forms.DataGridView()
            Me.Doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.NombreCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Plazo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Ref = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.txtNum_Impresiones = New System.Windows.Forms.TextBox()
            Me.chkImpresion = New System.Windows.Forms.CheckBox()
            Me.gbTipo = New System.Windows.Forms.GroupBox()
            Me.txtDato2 = New System.Windows.Forms.TextBox()
            Me.cmbTipoConsulta = New System.Windows.Forms.ComboBox()
            Me.txtDato = New System.Windows.Forms.TextBox()
            Me.btnBuscar = New System.Windows.Forms.Button()
            Me.txtIdPersona = New System.Windows.Forms.TextBox()
            Me.MnLista = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.AgregarReferenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.RecuperarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.TextBox1 = New System.Windows.Forms.TextBox()
            Me.dgvDetalle = New System.Windows.Forms.DataGridView()
            Me.NumRecibo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.lblNumFactura = New System.Windows.Forms.Label()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.lblTotalNC = New System.Windows.Forms.Label()
            Me.lblTotalAbonos = New System.Windows.Forms.Label()
            Me.lblFactura = New System.Windows.Forms.Label()
            Me.lblNC = New System.Windows.Forms.Label()
            Me.lblAbonos = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.gbTipo.SuspendLayout()
            Me.MnLista.SuspendLayout()
            CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox2.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgvCliente
            '
            Me.dgvCliente.AllowUserToAddRows = False
            Me.dgvCliente.AllowUserToDeleteRows = False
            Me.dgvCliente.BackgroundColor = System.Drawing.Color.White
            Me.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvCliente.GridColor = System.Drawing.Color.White
            Me.dgvCliente.Location = New System.Drawing.Point(200, 51)
            Me.dgvCliente.MultiSelect = False
            Me.dgvCliente.Name = "dgvCliente"
            Me.dgvCliente.ReadOnly = True
            Me.dgvCliente.RowHeadersVisible = False
            Me.dgvCliente.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvCliente.Size = New System.Drawing.Size(313, 105)
            Me.dgvCliente.TabIndex = 257
            Me.dgvCliente.Visible = False
            '
            'dgvLista
            '
            Me.dgvLista.AllowUserToAddRows = False
            Me.dgvLista.AllowUserToDeleteRows = False
            Me.dgvLista.AllowUserToResizeColumns = False
            Me.dgvLista.AllowUserToResizeRows = False
            Me.dgvLista.BackgroundColor = System.Drawing.Color.White
            Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            Me.dgvLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Doc, Me.NombreCliente, Me.Fecha, Me.Monto, Me.Tipo, Me.Estado, Me.Plazo, Me.Ref})
            Me.dgvLista.GridColor = System.Drawing.Color.White
            Me.dgvLista.Location = New System.Drawing.Point(4, 66)
            Me.dgvLista.MultiSelect = False
            Me.dgvLista.Name = "dgvLista"
            Me.dgvLista.ReadOnly = True
            Me.dgvLista.RowHeadersVisible = False
            Me.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvLista.Size = New System.Drawing.Size(724, 274)
            Me.dgvLista.TabIndex = 254
            '
            'Doc
            '
            Me.Doc.DataPropertyName = "Doc"
            Me.Doc.HeaderText = "# Fact"
            Me.Doc.Name = "Doc"
            Me.Doc.ReadOnly = True
            Me.Doc.Width = 50
            '
            'NombreCliente
            '
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.NombreCliente.DefaultCellStyle = DataGridViewCellStyle1
            Me.NombreCliente.HeaderText = "Cliente"
            Me.NombreCliente.Name = "NombreCliente"
            Me.NombreCliente.ReadOnly = True
            Me.NombreCliente.Width = 320
            '
            'Fecha
            '
            DataGridViewCellStyle2.Format = "d"
            DataGridViewCellStyle2.NullValue = Nothing
            Me.Fecha.DefaultCellStyle = DataGridViewCellStyle2
            Me.Fecha.HeaderText = "Fecha"
            Me.Fecha.Name = "Fecha"
            Me.Fecha.ReadOnly = True
            Me.Fecha.Width = 75
            '
            'Monto
            '
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle3.Format = "C2"
            DataGridViewCellStyle3.NullValue = Nothing
            Me.Monto.DefaultCellStyle = DataGridViewCellStyle3
            Me.Monto.HeaderText = "Monto"
            Me.Monto.Name = "Monto"
            Me.Monto.ReadOnly = True
            '
            'Tipo
            '
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Tipo.DefaultCellStyle = DataGridViewCellStyle4
            Me.Tipo.HeaderText = "Tipo"
            Me.Tipo.Name = "Tipo"
            Me.Tipo.ReadOnly = True
            Me.Tipo.Width = 40
            '
            'Estado
            '
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Estado.DefaultCellStyle = DataGridViewCellStyle5
            Me.Estado.HeaderText = "Estado"
            Me.Estado.Name = "Estado"
            Me.Estado.ReadOnly = True
            Me.Estado.Width = 43
            '
            'Plazo
            '
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Plazo.DefaultCellStyle = DataGridViewCellStyle6
            Me.Plazo.HeaderText = "Plazo"
            Me.Plazo.Name = "Plazo"
            Me.Plazo.ReadOnly = True
            Me.Plazo.Width = 40
            '
            'Ref
            '
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Ref.DefaultCellStyle = DataGridViewCellStyle7
            Me.Ref.HeaderText = "Ref"
            Me.Ref.Name = "Ref"
            Me.Ref.ReadOnly = True
            Me.Ref.Width = 30
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.txtNum_Impresiones)
            Me.GroupBox1.Controls.Add(Me.chkImpresion)
            Me.GroupBox1.Location = New System.Drawing.Point(537, 18)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(110, 38)
            Me.GroupBox1.TabIndex = 255
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
            'gbTipo
            '
            Me.gbTipo.Controls.Add(Me.txtDato2)
            Me.gbTipo.Controls.Add(Me.cmbTipoConsulta)
            Me.gbTipo.Controls.Add(Me.txtDato)
            Me.gbTipo.Controls.Add(Me.btnBuscar)
            Me.gbTipo.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTipo.Location = New System.Drawing.Point(79, 6)
            Me.gbTipo.Name = "gbTipo"
            Me.gbTipo.Size = New System.Drawing.Size(446, 52)
            Me.gbTipo.TabIndex = 0
            Me.gbTipo.TabStop = False
            Me.gbTipo.Text = "consultar por"
            '
            'txtDato2
            '
            Me.txtDato2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDato2.Location = New System.Drawing.Point(121, 22)
            Me.txtDato2.MaxLength = 6
            Me.txtDato2.Name = "txtDato2"
            Me.txtDato2.Size = New System.Drawing.Size(76, 21)
            Me.txtDato2.TabIndex = 0
            Me.txtDato2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'cmbTipoConsulta
            '
            Me.cmbTipoConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbTipoConsulta.FormattingEnabled = True
            Me.cmbTipoConsulta.Items.AddRange(New Object() {"Nombre Cliente", "Id_Cliente", "# Factura"})
            Me.cmbTipoConsulta.Location = New System.Drawing.Point(6, 22)
            Me.cmbTipoConsulta.Name = "cmbTipoConsulta"
            Me.cmbTipoConsulta.Size = New System.Drawing.Size(109, 23)
            Me.cmbTipoConsulta.TabIndex = 249
            '
            'txtDato
            '
            Me.txtDato.Location = New System.Drawing.Point(121, 22)
            Me.txtDato.Name = "txtDato"
            Me.txtDato.Size = New System.Drawing.Size(264, 23)
            Me.txtDato.TabIndex = 247
            Me.txtDato.Visible = False
            '
            'btnBuscar
            '
            Me.btnBuscar.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscar.Image = Global.Presentacion.My.Resources.Resources.buscar
            Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnBuscar.Location = New System.Drawing.Point(391, 12)
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(52, 35)
            Me.btnBuscar.TabIndex = 252
            Me.btnBuscar.Text = "Buscar"
            Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnBuscar.UseVisualStyleBackColor = True
            '
            'txtIdPersona
            '
            Me.txtIdPersona.Enabled = False
            Me.txtIdPersona.Location = New System.Drawing.Point(12, 13)
            Me.txtIdPersona.Name = "txtIdPersona"
            Me.txtIdPersona.Size = New System.Drawing.Size(52, 20)
            Me.txtIdPersona.TabIndex = 256
            '
            'MnLista
            '
            Me.MnLista.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerToolStripMenuItem, Me.ImprimirToolStripMenuItem, Me.AgregarReferenciaToolStripMenuItem, Me.RecuperarToolStripMenuItem})
            Me.MnLista.Name = "MnLista"
            Me.MnLista.Size = New System.Drawing.Size(175, 92)
            '
            'VerToolStripMenuItem
            '
            Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
            Me.VerToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
            Me.VerToolStripMenuItem.Text = "Ver en pantalla"
            '
            'ImprimirToolStripMenuItem
            '
            Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
            Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
            Me.ImprimirToolStripMenuItem.Text = "Imprimir copia"
            '
            'AgregarReferenciaToolStripMenuItem
            '
            Me.AgregarReferenciaToolStripMenuItem.Name = "AgregarReferenciaToolStripMenuItem"
            Me.AgregarReferenciaToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
            Me.AgregarReferenciaToolStripMenuItem.Text = "Agregar Referencia"
            '
            'RecuperarToolStripMenuItem
            '
            Me.RecuperarToolStripMenuItem.Name = "RecuperarToolStripMenuItem"
            Me.RecuperarToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
            Me.RecuperarToolStripMenuItem.Text = "Recuperar factura"
            '
            'TextBox1
            '
            Me.TextBox1.Enabled = False
            Me.TextBox1.Location = New System.Drawing.Point(13, 13)
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Size = New System.Drawing.Size(52, 20)
            Me.TextBox1.TabIndex = 259
            '
            'dgvDetalle
            '
            Me.dgvDetalle.AllowUserToAddRows = False
            Me.dgvDetalle.AllowUserToDeleteRows = False
            Me.dgvDetalle.AllowUserToResizeColumns = False
            Me.dgvDetalle.AllowUserToResizeRows = False
            Me.dgvDetalle.BackgroundColor = System.Drawing.Color.White
            Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            Me.dgvDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumRecibo, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewCheckBoxColumn1})
            Me.dgvDetalle.GridColor = System.Drawing.Color.White
            Me.dgvDetalle.Location = New System.Drawing.Point(8, 20)
            Me.dgvDetalle.MultiSelect = False
            Me.dgvDetalle.Name = "dgvDetalle"
            Me.dgvDetalle.ReadOnly = True
            Me.dgvDetalle.RowHeadersVisible = False
            Me.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDetalle.Size = New System.Drawing.Size(445, 124)
            Me.dgvDetalle.TabIndex = 260
            '
            'NumRecibo
            '
            Me.NumRecibo.HeaderText = "N° Recibo"
            Me.NumRecibo.Name = "NumRecibo"
            Me.NumRecibo.ReadOnly = True
            Me.NumRecibo.Width = 75
            '
            'DataGridViewTextBoxColumn1
            '
            Me.DataGridViewTextBoxColumn1.DataPropertyName = "Doc"
            Me.DataGridViewTextBoxColumn1.HeaderText = "# Doc"
            Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
            Me.DataGridViewTextBoxColumn1.ReadOnly = True
            Me.DataGridViewTextBoxColumn1.Width = 50
            '
            'DataGridViewTextBoxColumn2
            '
            Me.DataGridViewTextBoxColumn2.HeaderText = "Tipo"
            Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
            Me.DataGridViewTextBoxColumn2.ReadOnly = True
            Me.DataGridViewTextBoxColumn2.Width = 75
            '
            'DataGridViewTextBoxColumn3
            '
            DataGridViewCellStyle8.Format = "d"
            DataGridViewCellStyle8.NullValue = Nothing
            Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle8
            Me.DataGridViewTextBoxColumn3.HeaderText = "Fecha"
            Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
            Me.DataGridViewTextBoxColumn3.ReadOnly = True
            Me.DataGridViewTextBoxColumn3.Width = 75
            '
            'DataGridViewTextBoxColumn4
            '
            DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle9.Format = "C2"
            DataGridViewCellStyle9.NullValue = Nothing
            Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle9
            Me.DataGridViewTextBoxColumn4.HeaderText = "Monto"
            Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
            Me.DataGridViewTextBoxColumn4.ReadOnly = True
            '
            'DataGridViewCheckBoxColumn1
            '
            Me.DataGridViewCheckBoxColumn1.HeaderText = "Nulo"
            Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
            Me.DataGridViewCheckBoxColumn1.ReadOnly = True
            Me.DataGridViewCheckBoxColumn1.Width = 40
            '
            'lblNumFactura
            '
            Me.lblNumFactura.AutoSize = True
            Me.lblNumFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNumFactura.Location = New System.Drawing.Point(461, 20)
            Me.lblNumFactura.Name = "lblNumFactura"
            Me.lblNumFactura.Size = New System.Drawing.Size(86, 24)
            Me.lblNumFactura.TabIndex = 261
            Me.lblNumFactura.Text = "Factura:"
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.lblTotalNC)
            Me.GroupBox2.Controls.Add(Me.lblTotalAbonos)
            Me.GroupBox2.Controls.Add(Me.lblFactura)
            Me.GroupBox2.Controls.Add(Me.lblNC)
            Me.GroupBox2.Controls.Add(Me.lblAbonos)
            Me.GroupBox2.Controls.Add(Me.lblNumFactura)
            Me.GroupBox2.Controls.Add(Me.dgvDetalle)
            Me.GroupBox2.Location = New System.Drawing.Point(5, 358)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(641, 156)
            Me.GroupBox2.TabIndex = 262
            Me.GroupBox2.TabStop = False
            '
            'lblTotalNC
            '
            Me.lblTotalNC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotalNC.Location = New System.Drawing.Point(548, 88)
            Me.lblTotalNC.Name = "lblTotalNC"
            Me.lblTotalNC.Size = New System.Drawing.Size(68, 23)
            Me.lblTotalNC.TabIndex = 267
            Me.lblTotalNC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblTotalAbonos
            '
            Me.lblTotalAbonos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotalAbonos.Location = New System.Drawing.Point(548, 58)
            Me.lblTotalAbonos.Name = "lblTotalAbonos"
            Me.lblTotalAbonos.Size = New System.Drawing.Size(68, 23)
            Me.lblTotalAbonos.TabIndex = 266
            Me.lblTotalAbonos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblFactura
            '
            Me.lblFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFactura.Location = New System.Drawing.Point(548, 23)
            Me.lblFactura.Name = "lblFactura"
            Me.lblFactura.Size = New System.Drawing.Size(68, 23)
            Me.lblFactura.TabIndex = 265
            Me.lblFactura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblNC
            '
            Me.lblNC.AutoSize = True
            Me.lblNC.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNC.Location = New System.Drawing.Point(513, 89)
            Me.lblNC.Name = "lblNC"
            Me.lblNC.Size = New System.Drawing.Size(33, 19)
            Me.lblNC.TabIndex = 263
            Me.lblNC.Text = "NC:"
            '
            'lblAbonos
            '
            Me.lblAbonos.AutoSize = True
            Me.lblAbonos.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblAbonos.Location = New System.Drawing.Point(479, 59)
            Me.lblAbonos.Name = "lblAbonos"
            Me.lblAbonos.Size = New System.Drawing.Size(66, 19)
            Me.lblAbonos.TabIndex = 262
            Me.lblAbonos.Text = "Abonos:"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(5, 344)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(452, 14)
            Me.Label1.TabIndex = 263
            Me.Label1.Text = "*Contado = Cont, Crédito = Cred, Pendiente = Pend, Cancelada = Canc, Anulada = Nu" & _
        "la"
            '
            'FrmListaFacturas
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(731, 538)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.GroupBox2)
            Me.Controls.Add(Me.TextBox1)
            Me.Controls.Add(Me.dgvCliente)
            Me.Controls.Add(Me.gbTipo)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.txtIdPersona)
            Me.Controls.Add(Me.dgvLista)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmListaFacturas"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "FrmLista_Facturas"
            CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.gbTipo.ResumeLayout(False)
            Me.gbTipo.PerformLayout()
            Me.MnLista.ResumeLayout(False)
            CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvCliente As System.Windows.Forms.DataGridView
        Friend WithEvents dgvLista As System.Windows.Forms.DataGridView
        Friend WithEvents btnBuscar As System.Windows.Forms.Button
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents txtNum_Impresiones As System.Windows.Forms.TextBox
        Friend WithEvents chkImpresion As System.Windows.Forms.CheckBox
        Friend WithEvents gbTipo As System.Windows.Forms.GroupBox
        Friend WithEvents txtDato2 As System.Windows.Forms.TextBox
        Friend WithEvents cmbTipoConsulta As System.Windows.Forms.ComboBox
        Friend WithEvents txtDato As System.Windows.Forms.TextBox
        Friend WithEvents txtIdPersona As System.Windows.Forms.TextBox
        Friend WithEvents MnLista As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents VerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ImprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents RecuperarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
        Friend WithEvents AgregarReferenciaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
        Friend WithEvents lblNumFactura As System.Windows.Forms.Label
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents lblNC As System.Windows.Forms.Label
        Friend WithEvents lblAbonos As System.Windows.Forms.Label
        Friend WithEvents lblFactura As System.Windows.Forms.Label
        Friend WithEvents lblTotalNC As System.Windows.Forms.Label
        Friend WithEvents lblTotalAbonos As System.Windows.Forms.Label
        Friend WithEvents NumRecibo As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Doc As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents NombreCliente As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Monto As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Tipo As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Estado As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Plazo As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Ref As System.Windows.Forms.DataGridViewTextBoxColumn
    End Class
End Namespace