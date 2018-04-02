Namespace Interfaz.Administrativos
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmTotalComprasPorProveedor
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
            Me.txtMayor = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.dgvLista = New System.Windows.Forms.DataGridView()
            Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.SubTotalIV = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.SubTotalEX = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.lblFechaFinal = New System.Windows.Forms.Label()
            Me.lblFechaInicial = New System.Windows.Forms.Label()
            Me.dtpFinal = New System.Windows.Forms.DateTimePicker()
            Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
            Me.btnCalcular = New System.Windows.Forms.Button()
            Me.btnImprimir = New System.Windows.Forms.Button()
            CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'txtMayor
            '
            Me.txtMayor.Location = New System.Drawing.Point(450, 24)
            Me.txtMayor.Name = "txtMayor"
            Me.txtMayor.Size = New System.Drawing.Size(100, 20)
            Me.txtMayor.TabIndex = 236
            Me.txtMayor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(447, 9)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(45, 13)
            Me.Label1.TabIndex = 235
            Me.Label1.Text = "Mayor a"
            '
            'dgvLista
            '
            Me.dgvLista.AllowUserToAddRows = False
            Me.dgvLista.AllowUserToDeleteRows = False
            Me.dgvLista.AllowUserToResizeColumns = False
            Me.dgvLista.AllowUserToResizeRows = False
            Me.dgvLista.BackgroundColor = System.Drawing.Color.White
            Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            Me.dgvLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.SubTotalIV, Me.SubTotalEX, Me.Total})
            Me.dgvLista.GridColor = System.Drawing.Color.White
            Me.dgvLista.Location = New System.Drawing.Point(4, 70)
            Me.dgvLista.MultiSelect = False
            Me.dgvLista.Name = "dgvLista"
            Me.dgvLista.ReadOnly = True
            Me.dgvLista.RowHeadersVisible = False
            Me.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvLista.Size = New System.Drawing.Size(568, 393)
            Me.dgvLista.TabIndex = 234
            '
            'Nombre
            '
            Me.Nombre.HeaderText = "Nombre"
            Me.Nombre.Name = "Nombre"
            Me.Nombre.ReadOnly = True
            Me.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.Nombre.Width = 220
            '
            'SubTotalIV
            '
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle1.Format = "C2"
            DataGridViewCellStyle1.NullValue = Nothing
            Me.SubTotalIV.DefaultCellStyle = DataGridViewCellStyle1
            Me.SubTotalIV.HeaderText = "SubTotal (IV)"
            Me.SubTotalIV.Name = "SubTotalIV"
            Me.SubTotalIV.ReadOnly = True
            Me.SubTotalIV.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            '
            'SubTotalEX
            '
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle2.Format = "C2"
            DataGridViewCellStyle2.NullValue = Nothing
            Me.SubTotalEX.DefaultCellStyle = DataGridViewCellStyle2
            Me.SubTotalEX.HeaderText = "SubTotal (EX)"
            Me.SubTotalEX.Name = "SubTotalEX"
            Me.SubTotalEX.ReadOnly = True
            Me.SubTotalEX.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            '
            'Total
            '
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle3.Format = "C2"
            DataGridViewCellStyle3.NullValue = Nothing
            Me.Total.DefaultCellStyle = DataGridViewCellStyle3
            Me.Total.HeaderText = "Total de Compras"
            Me.Total.Name = "Total"
            Me.Total.ReadOnly = True
            Me.Total.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.Total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
            Me.Total.Width = 120
            '
            'lblFechaFinal
            '
            Me.lblFechaFinal.AutoSize = True
            Me.lblFechaFinal.Location = New System.Drawing.Point(303, 9)
            Me.lblFechaFinal.Name = "lblFechaFinal"
            Me.lblFechaFinal.Size = New System.Drawing.Size(62, 13)
            Me.lblFechaFinal.TabIndex = 233
            Me.lblFechaFinal.Text = "Fecha Final"
            '
            'lblFechaInicial
            '
            Me.lblFechaInicial.AutoSize = True
            Me.lblFechaInicial.Location = New System.Drawing.Point(181, 9)
            Me.lblFechaInicial.Name = "lblFechaInicial"
            Me.lblFechaInicial.Size = New System.Drawing.Size(67, 13)
            Me.lblFechaInicial.TabIndex = 232
            Me.lblFechaInicial.Text = "Fecha Inicial"
            '
            'dtpFinal
            '
            Me.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFinal.Location = New System.Drawing.Point(306, 24)
            Me.dtpFinal.MaxDate = New Date(3000, 12, 31, 0, 0, 0, 0)
            Me.dtpFinal.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
            Me.dtpFinal.Name = "dtpFinal"
            Me.dtpFinal.Size = New System.Drawing.Size(99, 20)
            Me.dtpFinal.TabIndex = 231
            Me.dtpFinal.Value = New Date(2011, 12, 27, 0, 0, 0, 0)
            '
            'dtpInicio
            '
            Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpInicio.Location = New System.Drawing.Point(181, 24)
            Me.dtpInicio.MaxDate = New Date(3000, 12, 31, 0, 0, 0, 0)
            Me.dtpInicio.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
            Me.dtpInicio.Name = "dtpInicio"
            Me.dtpInicio.Size = New System.Drawing.Size(99, 20)
            Me.dtpInicio.TabIndex = 230
            Me.dtpInicio.Value = New Date(2011, 12, 27, 0, 0, 0, 0)
            '
            'btnCalcular
            '
            Me.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnCalcular.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCalcular.Image = Global.Presentacion.My.Resources.Resources.sumar
            Me.btnCalcular.Location = New System.Drawing.Point(0, 0)
            Me.btnCalcular.Name = "btnCalcular"
            Me.btnCalcular.Size = New System.Drawing.Size(71, 57)
            Me.btnCalcular.TabIndex = 229
            Me.btnCalcular.Text = "Calcular"
            Me.btnCalcular.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnCalcular.UseVisualStyleBackColor = True
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
            Me.btnImprimir.TabIndex = 237
            Me.btnImprimir.Text = "Imprimir"
            Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnImprimir.UseVisualStyleBackColor = True
            '
            'FrmTotalComprasPorProveedor
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(576, 467)
            Me.Controls.Add(Me.btnImprimir)
            Me.Controls.Add(Me.txtMayor)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.dgvLista)
            Me.Controls.Add(Me.lblFechaFinal)
            Me.Controls.Add(Me.lblFechaInicial)
            Me.Controls.Add(Me.dtpFinal)
            Me.Controls.Add(Me.dtpInicio)
            Me.Controls.Add(Me.btnCalcular)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmTotalComprasPorProveedor"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Total de compras por proveedor"
            CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents txtMayor As System.Windows.Forms.TextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents dgvLista As System.Windows.Forms.DataGridView
        Friend WithEvents lblFechaFinal As System.Windows.Forms.Label
        Friend WithEvents lblFechaInicial As System.Windows.Forms.Label
        Friend WithEvents dtpFinal As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
        Friend WithEvents btnCalcular As System.Windows.Forms.Button
        Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents SubTotalIV As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents SubTotalEX As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents btnImprimir As System.Windows.Forms.Button
    End Class
End Namespace