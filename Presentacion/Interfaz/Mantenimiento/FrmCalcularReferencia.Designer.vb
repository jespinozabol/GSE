Namespace Interfaz.Mantenimiento
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmCalcularReferencia
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
            Me.lblFechaFinal = New System.Windows.Forms.Label()
            Me.lblFechaInicial = New System.Windows.Forms.Label()
            Me.dtpFinal = New System.Windows.Forms.DateTimePicker()
            Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
            Me.lblTotal = New System.Windows.Forms.Label()
            Me.lblMostrarTotal = New System.Windows.Forms.Label()
            Me.lblNombre = New System.Windows.Forms.Label()
            Me.lblMostrarNombre = New System.Windows.Forms.Label()
            Me.btnCalcular = New System.Windows.Forms.Button()
            Me.btnGuardar = New System.Windows.Forms.Button()
            Me.lblMostrarReferencia = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtId_Referencia = New System.Windows.Forms.TextBox()
            Me.gbBitacora = New System.Windows.Forms.GroupBox()
            Me.dgvBitacora = New System.Windows.Forms.DataGridView()
            Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.txtDescuentoGen = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.gbBitacora.SuspendLayout()
            CType(Me.dgvBitacora, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'lblFechaFinal
            '
            Me.lblFechaFinal.AutoSize = True
            Me.lblFechaFinal.Location = New System.Drawing.Point(331, 18)
            Me.lblFechaFinal.Name = "lblFechaFinal"
            Me.lblFechaFinal.Size = New System.Drawing.Size(62, 13)
            Me.lblFechaFinal.TabIndex = 224
            Me.lblFechaFinal.Text = "Fecha Final"
            '
            'lblFechaInicial
            '
            Me.lblFechaInicial.AutoSize = True
            Me.lblFechaInicial.Location = New System.Drawing.Point(209, 18)
            Me.lblFechaInicial.Name = "lblFechaInicial"
            Me.lblFechaInicial.Size = New System.Drawing.Size(67, 13)
            Me.lblFechaInicial.TabIndex = 223
            Me.lblFechaInicial.Text = "Fecha Inicial"
            '
            'dtpFinal
            '
            Me.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFinal.Location = New System.Drawing.Point(334, 33)
            Me.dtpFinal.MaxDate = New Date(3000, 12, 31, 0, 0, 0, 0)
            Me.dtpFinal.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
            Me.dtpFinal.Name = "dtpFinal"
            Me.dtpFinal.Size = New System.Drawing.Size(99, 20)
            Me.dtpFinal.TabIndex = 222
            Me.dtpFinal.Value = New Date(2011, 12, 27, 0, 0, 0, 0)
            '
            'dtpInicio
            '
            Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpInicio.Location = New System.Drawing.Point(209, 33)
            Me.dtpInicio.MaxDate = New Date(3000, 12, 31, 0, 0, 0, 0)
            Me.dtpInicio.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
            Me.dtpInicio.Name = "dtpInicio"
            Me.dtpInicio.Size = New System.Drawing.Size(99, 20)
            Me.dtpInicio.TabIndex = 221
            Me.dtpInicio.Value = New Date(2011, 1, 1, 0, 0, 0, 0)
            '
            'lblTotal
            '
            Me.lblTotal.AutoSize = True
            Me.lblTotal.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotal.Location = New System.Drawing.Point(12, 115)
            Me.lblTotal.Name = "lblTotal"
            Me.lblTotal.Size = New System.Drawing.Size(47, 15)
            Me.lblTotal.TabIndex = 225
            Me.lblTotal.Text = "Total: ¢"
            '
            'lblMostrarTotal
            '
            Me.lblMostrarTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarTotal.Location = New System.Drawing.Point(60, 115)
            Me.lblMostrarTotal.Name = "lblMostrarTotal"
            Me.lblMostrarTotal.Size = New System.Drawing.Size(143, 23)
            Me.lblMostrarTotal.TabIndex = 226
            Me.lblMostrarTotal.Text = "0.00"
            '
            'lblNombre
            '
            Me.lblNombre.AutoSize = True
            Me.lblNombre.BackColor = System.Drawing.Color.Transparent
            Me.lblNombre.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblNombre.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombre.Location = New System.Drawing.Point(12, 72)
            Me.lblNombre.Name = "lblNombre"
            Me.lblNombre.Size = New System.Drawing.Size(53, 15)
            Me.lblNombre.TabIndex = 227
            Me.lblNombre.Text = "Nombre"
            '
            'lblMostrarNombre
            '
            Me.lblMostrarNombre.Location = New System.Drawing.Point(71, 73)
            Me.lblMostrarNombre.Name = "lblMostrarNombre"
            Me.lblMostrarNombre.Size = New System.Drawing.Size(250, 23)
            Me.lblMostrarNombre.TabIndex = 228
            '
            'btnCalcular
            '
            Me.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnCalcular.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCalcular.Image = Global.Presentacion.My.Resources.Resources.sumar
            Me.btnCalcular.Location = New System.Drawing.Point(70, 0)
            Me.btnCalcular.Name = "btnCalcular"
            Me.btnCalcular.Size = New System.Drawing.Size(71, 57)
            Me.btnCalcular.TabIndex = 229
            Me.btnCalcular.Text = "Calcular"
            Me.btnCalcular.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnCalcular.UseVisualStyleBackColor = True
            '
            'btnGuardar
            '
            Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnGuardar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = Global.Presentacion.My.Resources.Resources.Guardar
            Me.btnGuardar.Location = New System.Drawing.Point(0, 0)
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(71, 57)
            Me.btnGuardar.TabIndex = 230
            Me.btnGuardar.Text = "Guardar"
            Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnGuardar.UseVisualStyleBackColor = True
            '
            'lblMostrarReferencia
            '
            Me.lblMostrarReferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarReferencia.Location = New System.Drawing.Point(285, 115)
            Me.lblMostrarReferencia.Name = "lblMostrarReferencia"
            Me.lblMostrarReferencia.Size = New System.Drawing.Size(143, 23)
            Me.lblMostrarReferencia.TabIndex = 232
            Me.lblMostrarReferencia.Text = "0.00"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(209, 115)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(80, 15)
            Me.Label2.TabIndex = 231
            Me.Label2.Text = "Referencia: ¢"
            '
            'txtId_Referencia
            '
            Me.txtId_Referencia.Enabled = False
            Me.txtId_Referencia.Location = New System.Drawing.Point(55, 18)
            Me.txtId_Referencia.Name = "txtId_Referencia"
            Me.txtId_Referencia.Size = New System.Drawing.Size(47, 20)
            Me.txtId_Referencia.TabIndex = 233
            Me.txtId_Referencia.Visible = False
            '
            'gbBitacora
            '
            Me.gbBitacora.Controls.Add(Me.dgvBitacora)
            Me.gbBitacora.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbBitacora.Location = New System.Drawing.Point(15, 141)
            Me.gbBitacora.Name = "gbBitacora"
            Me.gbBitacora.Size = New System.Drawing.Size(426, 300)
            Me.gbBitacora.TabIndex = 234
            Me.gbBitacora.TabStop = False
            Me.gbBitacora.Text = "Bitácora"
            '
            'dgvBitacora
            '
            Me.dgvBitacora.AllowUserToAddRows = False
            Me.dgvBitacora.AllowUserToDeleteRows = False
            Me.dgvBitacora.AllowUserToResizeColumns = False
            Me.dgvBitacora.AllowUserToResizeRows = False
            Me.dgvBitacora.BackgroundColor = System.Drawing.Color.White
            Me.dgvBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvBitacora.ColumnHeadersVisible = False
            Me.dgvBitacora.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Descripcion})
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvBitacora.DefaultCellStyle = DataGridViewCellStyle1
            Me.dgvBitacora.GridColor = System.Drawing.Color.White
            Me.dgvBitacora.Location = New System.Drawing.Point(9, 22)
            Me.dgvBitacora.MultiSelect = False
            Me.dgvBitacora.Name = "dgvBitacora"
            Me.dgvBitacora.ReadOnly = True
            Me.dgvBitacora.RowHeadersVisible = False
            Me.dgvBitacora.RowTemplate.Height = 20
            Me.dgvBitacora.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvBitacora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvBitacora.Size = New System.Drawing.Size(404, 267)
            Me.dgvBitacora.TabIndex = 3
            '
            'Descripcion
            '
            Me.Descripcion.HeaderText = "Descripción"
            Me.Descripcion.Name = "Descripcion"
            Me.Descripcion.ReadOnly = True
            Me.Descripcion.Width = 382
            '
            'txtDescuentoGen
            '
            Me.txtDescuentoGen.Location = New System.Drawing.Point(378, 72)
            Me.txtDescuentoGen.Name = "txtDescuentoGen"
            Me.txtDescuentoGen.Size = New System.Drawing.Size(42, 20)
            Me.txtDescuentoGen.TabIndex = 236
            Me.txtDescuentoGen.Text = "2.5"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(315, 74)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(57, 15)
            Me.Label1.TabIndex = 237
            Me.Label1.Text = "Comisión"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(418, 75)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(15, 13)
            Me.Label3.TabIndex = 238
            Me.Label3.Text = "%"
            '
            'FrmCalcularReferencia
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(453, 450)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.txtDescuentoGen)
            Me.Controls.Add(Me.gbBitacora)
            Me.Controls.Add(Me.lblMostrarReferencia)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.btnGuardar)
            Me.Controls.Add(Me.btnCalcular)
            Me.Controls.Add(Me.lblMostrarNombre)
            Me.Controls.Add(Me.lblNombre)
            Me.Controls.Add(Me.lblMostrarTotal)
            Me.Controls.Add(Me.lblTotal)
            Me.Controls.Add(Me.lblFechaFinal)
            Me.Controls.Add(Me.lblFechaInicial)
            Me.Controls.Add(Me.dtpFinal)
            Me.Controls.Add(Me.dtpInicio)
            Me.Controls.Add(Me.txtId_Referencia)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmCalcularReferencia"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "FrmCalcular_Referencia"
            Me.gbBitacora.ResumeLayout(False)
            CType(Me.dgvBitacora, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents lblFechaFinal As System.Windows.Forms.Label
        Friend WithEvents lblFechaInicial As System.Windows.Forms.Label
        Friend WithEvents dtpFinal As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
        Friend WithEvents lblTotal As System.Windows.Forms.Label
        Friend WithEvents lblMostrarTotal As System.Windows.Forms.Label
        Friend WithEvents lblNombre As System.Windows.Forms.Label
        Friend WithEvents lblMostrarNombre As System.Windows.Forms.Label
        Friend WithEvents btnCalcular As System.Windows.Forms.Button
        Friend WithEvents btnGuardar As System.Windows.Forms.Button
        Friend WithEvents lblMostrarReferencia As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtId_Referencia As System.Windows.Forms.TextBox
        Friend WithEvents gbBitacora As System.Windows.Forms.GroupBox
        Friend WithEvents dgvBitacora As System.Windows.Forms.DataGridView
        Friend WithEvents txtDescuentoGen As System.Windows.Forms.TextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    End Class
End Namespace