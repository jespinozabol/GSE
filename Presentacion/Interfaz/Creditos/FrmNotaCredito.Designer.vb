Namespace Interfaz.Creditos
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmNotaCredito
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
            Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.dgvFactura = New System.Windows.Forms.DataGridView()
            Me.Cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.PrecioU = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Descuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.IV = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.lblNumFactura = New System.Windows.Forms.Label()
            Me.txtNumFactura = New System.Windows.Forms.TextBox()
            Me.lblNombreCliente = New System.Windows.Forms.Label()
            Me.txtNombreCliente = New System.Windows.Forms.TextBox()
            Me.txtFecha = New System.Windows.Forms.TextBox()
            Me.lblFecha = New System.Windows.Forms.Label()
            Me.lblMostrarReciboNotas = New System.Windows.Forms.Label()
            Me.lblRecibo = New System.Windows.Forms.Label()
            Me.dgvNotaCredito = New System.Windows.Forms.DataGridView()
            Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.btnAgregar = New System.Windows.Forms.Button()
            Me.txtCodigo = New System.Windows.Forms.TextBox()
            Me.lblCodigo = New System.Windows.Forms.Label()
            Me.txtCantidad = New System.Windows.Forms.TextBox()
            Me.lblCantidad = New System.Windows.Forms.Label()
            Me.txtArticulo = New System.Windows.Forms.TextBox()
            Me.lblArticulo = New System.Windows.Forms.Label()
            Me.lblTotal = New System.Windows.Forms.Label()
            Me.lblMostrarTotal = New System.Windows.Forms.Label()
            Me.timerNota = New System.Windows.Forms.Timer(Me.components)
            Me.btnNota = New System.Windows.Forms.Button()
            Me.txtId_Credito = New System.Windows.Forms.TextBox()
            Me.chkImpresion = New System.Windows.Forms.CheckBox()
            Me.txtNum_Impresiones = New System.Windows.Forms.TextBox()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            CType(Me.dgvFactura, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvNotaCredito, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgvFactura
            '
            Me.dgvFactura.AllowUserToAddRows = False
            Me.dgvFactura.AllowUserToDeleteRows = False
            Me.dgvFactura.AllowUserToResizeColumns = False
            Me.dgvFactura.AllowUserToResizeRows = False
            Me.dgvFactura.BackgroundColor = System.Drawing.Color.White
            Me.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvFactura.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cant, Me.Cod, Me.Descripcion, Me.PrecioU, Me.Descuento, Me.IV, Me.Subtotal})
            Me.dgvFactura.GridColor = System.Drawing.Color.White
            Me.dgvFactura.Location = New System.Drawing.Point(12, 118)
            Me.dgvFactura.MultiSelect = False
            Me.dgvFactura.Name = "dgvFactura"
            Me.dgvFactura.ReadOnly = True
            Me.dgvFactura.RowHeadersVisible = False
            Me.dgvFactura.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
            Me.dgvFactura.RowTemplate.Height = 18
            Me.dgvFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvFactura.Size = New System.Drawing.Size(738, 182)
            Me.dgvFactura.TabIndex = 196
            '
            'Cant
            '
            DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Cant.DefaultCellStyle = DataGridViewCellStyle11
            Me.Cant.HeaderText = "Cant"
            Me.Cant.Name = "Cant"
            Me.Cant.ReadOnly = True
            Me.Cant.Width = 50
            '
            'Cod
            '
            Me.Cod.HeaderText = "Cod"
            Me.Cod.Name = "Cod"
            Me.Cod.ReadOnly = True
            Me.Cod.Width = 50
            '
            'Descripcion
            '
            Me.Descripcion.HeaderText = "Descripción"
            Me.Descripcion.Name = "Descripcion"
            Me.Descripcion.ReadOnly = True
            Me.Descripcion.Width = 345
            '
            'PrecioU
            '
            DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.PrecioU.DefaultCellStyle = DataGridViewCellStyle12
            Me.PrecioU.HeaderText = "Precio/U"
            Me.PrecioU.Name = "PrecioU"
            Me.PrecioU.ReadOnly = True
            Me.PrecioU.Width = 75
            '
            'Descuento
            '
            DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Descuento.DefaultCellStyle = DataGridViewCellStyle13
            Me.Descuento.HeaderText = "Desc"
            Me.Descuento.Name = "Descuento"
            Me.Descuento.ReadOnly = True
            Me.Descuento.Width = 52
            '
            'IV
            '
            DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.IV.DefaultCellStyle = DataGridViewCellStyle14
            Me.IV.HeaderText = "I.V"
            Me.IV.Name = "IV"
            Me.IV.ReadOnly = True
            Me.IV.Width = 52
            '
            'Subtotal
            '
            DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Subtotal.DefaultCellStyle = DataGridViewCellStyle15
            Me.Subtotal.HeaderText = "SubTotal"
            Me.Subtotal.Name = "Subtotal"
            Me.Subtotal.ReadOnly = True
            Me.Subtotal.Width = 92
            '
            'lblNumFactura
            '
            Me.lblNumFactura.AutoSize = True
            Me.lblNumFactura.Location = New System.Drawing.Point(13, 64)
            Me.lblNumFactura.Name = "lblNumFactura"
            Me.lblNumFactura.Size = New System.Drawing.Size(58, 13)
            Me.lblNumFactura.TabIndex = 198
            Me.lblNumFactura.Text = "N° Factura"
            '
            'txtNumFactura
            '
            Me.txtNumFactura.Location = New System.Drawing.Point(77, 61)
            Me.txtNumFactura.Name = "txtNumFactura"
            Me.txtNumFactura.ReadOnly = True
            Me.txtNumFactura.Size = New System.Drawing.Size(81, 20)
            Me.txtNumFactura.TabIndex = 199
            '
            'lblNombreCliente
            '
            Me.lblNombreCliente.AutoSize = True
            Me.lblNombreCliente.Location = New System.Drawing.Point(13, 93)
            Me.lblNombreCliente.Name = "lblNombreCliente"
            Me.lblNombreCliente.Size = New System.Drawing.Size(44, 13)
            Me.lblNombreCliente.TabIndex = 200
            Me.lblNombreCliente.Text = "Nombre"
            '
            'txtNombreCliente
            '
            Me.txtNombreCliente.Location = New System.Drawing.Point(77, 90)
            Me.txtNombreCliente.Name = "txtNombreCliente"
            Me.txtNombreCliente.ReadOnly = True
            Me.txtNombreCliente.Size = New System.Drawing.Size(437, 20)
            Me.txtNombreCliente.TabIndex = 201
            '
            'txtFecha
            '
            Me.txtFecha.Location = New System.Drawing.Point(257, 61)
            Me.txtFecha.Name = "txtFecha"
            Me.txtFecha.ReadOnly = True
            Me.txtFecha.Size = New System.Drawing.Size(81, 20)
            Me.txtFecha.TabIndex = 203
            '
            'lblFecha
            '
            Me.lblFecha.AutoSize = True
            Me.lblFecha.Location = New System.Drawing.Point(176, 64)
            Me.lblFecha.Name = "lblFecha"
            Me.lblFecha.Size = New System.Drawing.Size(76, 13)
            Me.lblFecha.TabIndex = 202
            Me.lblFecha.Text = "Fecha Factura"
            '
            'lblMostrarReciboNotas
            '
            Me.lblMostrarReciboNotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarReciboNotas.Location = New System.Drawing.Point(675, 32)
            Me.lblMostrarReciboNotas.Name = "lblMostrarReciboNotas"
            Me.lblMostrarReciboNotas.Size = New System.Drawing.Size(62, 25)
            Me.lblMostrarReciboNotas.TabIndex = 205
            Me.lblMostrarReciboNotas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblRecibo
            '
            Me.lblRecibo.AutoSize = True
            Me.lblRecibo.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblRecibo.Location = New System.Drawing.Point(538, 38)
            Me.lblRecibo.Name = "lblRecibo"
            Me.lblRecibo.Size = New System.Drawing.Size(126, 15)
            Me.lblRecibo.TabIndex = 204
            Me.lblRecibo.Text = "Recibo Nota Crédito#"
            '
            'dgvNotaCredito
            '
            Me.dgvNotaCredito.AllowUserToAddRows = False
            Me.dgvNotaCredito.AllowUserToDeleteRows = False
            Me.dgvNotaCredito.AllowUserToResizeColumns = False
            Me.dgvNotaCredito.AllowUserToResizeRows = False
            Me.dgvNotaCredito.BackgroundColor = System.Drawing.Color.White
            Me.dgvNotaCredito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvNotaCredito.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
            Me.dgvNotaCredito.GridColor = System.Drawing.Color.White
            Me.dgvNotaCredito.Location = New System.Drawing.Point(12, 359)
            Me.dgvNotaCredito.MultiSelect = False
            Me.dgvNotaCredito.Name = "dgvNotaCredito"
            Me.dgvNotaCredito.ReadOnly = True
            Me.dgvNotaCredito.RowHeadersVisible = False
            Me.dgvNotaCredito.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
            Me.dgvNotaCredito.RowTemplate.Height = 18
            Me.dgvNotaCredito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvNotaCredito.Size = New System.Drawing.Size(738, 127)
            Me.dgvNotaCredito.TabIndex = 206
            '
            'DataGridViewTextBoxColumn1
            '
            DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle16
            Me.DataGridViewTextBoxColumn1.HeaderText = "Cant"
            Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
            Me.DataGridViewTextBoxColumn1.ReadOnly = True
            Me.DataGridViewTextBoxColumn1.Width = 50
            '
            'DataGridViewTextBoxColumn2
            '
            Me.DataGridViewTextBoxColumn2.HeaderText = "Cod"
            Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
            Me.DataGridViewTextBoxColumn2.ReadOnly = True
            Me.DataGridViewTextBoxColumn2.Width = 50
            '
            'DataGridViewTextBoxColumn3
            '
            Me.DataGridViewTextBoxColumn3.HeaderText = "Descripción"
            Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
            Me.DataGridViewTextBoxColumn3.ReadOnly = True
            Me.DataGridViewTextBoxColumn3.Width = 345
            '
            'DataGridViewTextBoxColumn4
            '
            DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle17
            Me.DataGridViewTextBoxColumn4.HeaderText = "Precio/U"
            Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
            Me.DataGridViewTextBoxColumn4.ReadOnly = True
            Me.DataGridViewTextBoxColumn4.Width = 75
            '
            'DataGridViewTextBoxColumn5
            '
            DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle18
            Me.DataGridViewTextBoxColumn5.HeaderText = "Desc"
            Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
            Me.DataGridViewTextBoxColumn5.ReadOnly = True
            Me.DataGridViewTextBoxColumn5.Width = 52
            '
            'DataGridViewTextBoxColumn6
            '
            DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle19
            Me.DataGridViewTextBoxColumn6.HeaderText = "I.V"
            Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
            Me.DataGridViewTextBoxColumn6.ReadOnly = True
            Me.DataGridViewTextBoxColumn6.Width = 52
            '
            'DataGridViewTextBoxColumn7
            '
            DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle20
            Me.DataGridViewTextBoxColumn7.HeaderText = "SubTotal"
            Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
            Me.DataGridViewTextBoxColumn7.ReadOnly = True
            Me.DataGridViewTextBoxColumn7.Width = 92
            '
            'btnAgregar
            '
            Me.btnAgregar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAgregar.Location = New System.Drawing.Point(588, 320)
            Me.btnAgregar.Name = "btnAgregar"
            Me.btnAgregar.Size = New System.Drawing.Size(64, 36)
            Me.btnAgregar.TabIndex = 221
            Me.btnAgregar.Text = "Agregar"
            Me.btnAgregar.UseVisualStyleBackColor = True
            '
            'txtCodigo
            '
            Me.txtCodigo.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtCodigo.Location = New System.Drawing.Point(202, 329)
            Me.txtCodigo.Name = "txtCodigo"
            Me.txtCodigo.ReadOnly = True
            Me.txtCodigo.Size = New System.Drawing.Size(55, 20)
            Me.txtCodigo.TabIndex = 212
            '
            'lblCodigo
            '
            Me.lblCodigo.AutoSize = True
            Me.lblCodigo.BackColor = System.Drawing.Color.Transparent
            Me.lblCodigo.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblCodigo.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCodigo.Location = New System.Drawing.Point(201, 313)
            Me.lblCodigo.Name = "lblCodigo"
            Me.lblCodigo.Size = New System.Drawing.Size(45, 15)
            Me.lblCodigo.TabIndex = 211
            Me.lblCodigo.Text = "Código"
            '
            'txtCantidad
            '
            Me.txtCantidad.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtCantidad.Location = New System.Drawing.Point(146, 329)
            Me.txtCantidad.MaxLength = 8
            Me.txtCantidad.Name = "txtCantidad"
            Me.txtCantidad.Size = New System.Drawing.Size(55, 20)
            Me.txtCantidad.TabIndex = 210
            Me.txtCantidad.Text = "1"
            '
            'lblCantidad
            '
            Me.lblCantidad.AutoSize = True
            Me.lblCantidad.BackColor = System.Drawing.Color.Transparent
            Me.lblCantidad.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblCantidad.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCantidad.Location = New System.Drawing.Point(145, 313)
            Me.lblCantidad.Name = "lblCantidad"
            Me.lblCantidad.Size = New System.Drawing.Size(55, 15)
            Me.lblCantidad.TabIndex = 209
            Me.lblCantidad.Text = "Cantidad"
            '
            'txtArticulo
            '
            Me.txtArticulo.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtArticulo.Location = New System.Drawing.Point(259, 329)
            Me.txtArticulo.Name = "txtArticulo"
            Me.txtArticulo.ReadOnly = True
            Me.txtArticulo.Size = New System.Drawing.Size(313, 20)
            Me.txtArticulo.TabIndex = 208
            '
            'lblArticulo
            '
            Me.lblArticulo.AutoSize = True
            Me.lblArticulo.BackColor = System.Drawing.Color.Transparent
            Me.lblArticulo.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblArticulo.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblArticulo.Location = New System.Drawing.Point(256, 313)
            Me.lblArticulo.Name = "lblArticulo"
            Me.lblArticulo.Size = New System.Drawing.Size(51, 15)
            Me.lblArticulo.TabIndex = 207
            Me.lblArticulo.Text = "Artículo"
            '
            'lblTotal
            '
            Me.lblTotal.AutoSize = True
            Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotal.Location = New System.Drawing.Point(556, 499)
            Me.lblTotal.Name = "lblTotal"
            Me.lblTotal.Size = New System.Drawing.Size(65, 25)
            Me.lblTotal.TabIndex = 222
            Me.lblTotal.Text = "Total"
            '
            'lblMostrarTotal
            '
            Me.lblMostrarTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarTotal.ForeColor = System.Drawing.Color.Red
            Me.lblMostrarTotal.Location = New System.Drawing.Point(627, 499)
            Me.lblMostrarTotal.Name = "lblMostrarTotal"
            Me.lblMostrarTotal.Size = New System.Drawing.Size(123, 20)
            Me.lblMostrarTotal.TabIndex = 229
            Me.lblMostrarTotal.Text = "0.00"
            Me.lblMostrarTotal.TextAlign = System.Drawing.ContentAlignment.BottomRight
            '
            'timerNota
            '
            Me.timerNota.Enabled = True
            Me.timerNota.Interval = 6
            '
            'btnNota
            '
            Me.btnNota.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNota.Image = Global.Presentacion.My.Resources.Resources.Imprimir
            Me.btnNota.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnNota.Location = New System.Drawing.Point(0, 0)
            Me.btnNota.Name = "btnNota"
            Me.btnNota.Size = New System.Drawing.Size(65, 57)
            Me.btnNota.TabIndex = 195
            Me.btnNota.Text = "Imprimir"
            Me.btnNota.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnNota.UseVisualStyleBackColor = True
            '
            'txtId_Credito
            '
            Me.txtId_Credito.Enabled = False
            Me.txtId_Credito.Location = New System.Drawing.Point(12, 12)
            Me.txtId_Credito.Name = "txtId_Credito"
            Me.txtId_Credito.Size = New System.Drawing.Size(41, 20)
            Me.txtId_Credito.TabIndex = 230
            Me.txtId_Credito.Visible = False
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
            'txtNum_Impresiones
            '
            Me.txtNum_Impresiones.Enabled = False
            Me.txtNum_Impresiones.Location = New System.Drawing.Point(82, 12)
            Me.txtNum_Impresiones.Name = "txtNum_Impresiones"
            Me.txtNum_Impresiones.ReadOnly = True
            Me.txtNum_Impresiones.Size = New System.Drawing.Size(40, 20)
            Me.txtNum_Impresiones.TabIndex = 232
            Me.txtNum_Impresiones.Text = "2"
            Me.txtNum_Impresiones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.txtNum_Impresiones)
            Me.GroupBox1.Controls.Add(Me.chkImpresion)
            Me.GroupBox1.Location = New System.Drawing.Point(77, 12)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(134, 38)
            Me.GroupBox1.TabIndex = 233
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Impresiones"
            '
            'FrmNotaCredito
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(762, 531)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.lblMostrarTotal)
            Me.Controls.Add(Me.lblTotal)
            Me.Controls.Add(Me.btnAgregar)
            Me.Controls.Add(Me.txtCodigo)
            Me.Controls.Add(Me.lblCodigo)
            Me.Controls.Add(Me.txtCantidad)
            Me.Controls.Add(Me.lblCantidad)
            Me.Controls.Add(Me.txtArticulo)
            Me.Controls.Add(Me.lblArticulo)
            Me.Controls.Add(Me.dgvNotaCredito)
            Me.Controls.Add(Me.lblMostrarReciboNotas)
            Me.Controls.Add(Me.lblRecibo)
            Me.Controls.Add(Me.txtFecha)
            Me.Controls.Add(Me.lblFecha)
            Me.Controls.Add(Me.txtNombreCliente)
            Me.Controls.Add(Me.lblNombreCliente)
            Me.Controls.Add(Me.txtNumFactura)
            Me.Controls.Add(Me.lblNumFactura)
            Me.Controls.Add(Me.dgvFactura)
            Me.Controls.Add(Me.btnNota)
            Me.Controls.Add(Me.txtId_Credito)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmNotaCredito"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Nota Crédito"
            CType(Me.dgvFactura, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvNotaCredito, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents btnNota As System.Windows.Forms.Button
        Friend WithEvents dgvFactura As System.Windows.Forms.DataGridView
        Friend WithEvents lblNumFactura As System.Windows.Forms.Label
        Friend WithEvents txtNumFactura As System.Windows.Forms.TextBox
        Friend WithEvents lblNombreCliente As System.Windows.Forms.Label
        Friend WithEvents txtNombreCliente As System.Windows.Forms.TextBox
        Friend WithEvents txtFecha As System.Windows.Forms.TextBox
        Friend WithEvents lblFecha As System.Windows.Forms.Label
        Friend WithEvents lblMostrarReciboNotas As System.Windows.Forms.Label
        Friend WithEvents lblRecibo As System.Windows.Forms.Label
        Friend WithEvents Cant As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Cod As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents PrecioU As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Descuento As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents IV As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Subtotal As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvNotaCredito As System.Windows.Forms.DataGridView
        Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents btnAgregar As System.Windows.Forms.Button
        Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
        Friend WithEvents lblCodigo As System.Windows.Forms.Label
        Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
        Friend WithEvents lblCantidad As System.Windows.Forms.Label
        Friend WithEvents txtArticulo As System.Windows.Forms.TextBox
        Friend WithEvents lblArticulo As System.Windows.Forms.Label
        Friend WithEvents lblTotal As System.Windows.Forms.Label
        Friend WithEvents lblMostrarTotal As System.Windows.Forms.Label
        Friend WithEvents timerNota As System.Windows.Forms.Timer
        Friend WithEvents txtId_Credito As System.Windows.Forms.TextBox
        Friend WithEvents chkImpresion As System.Windows.Forms.CheckBox
        Friend WithEvents txtNum_Impresiones As System.Windows.Forms.TextBox
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    End Class
End Namespace