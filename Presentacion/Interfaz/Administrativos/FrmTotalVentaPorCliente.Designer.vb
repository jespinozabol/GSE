Namespace Interfaz.Administrativos
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmTotalVentaPorCliente
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
            Me.lblFechaFinal = New System.Windows.Forms.Label()
            Me.lblFechaInicial = New System.Windows.Forms.Label()
            Me.dtpFinal = New System.Windows.Forms.DateTimePicker()
            Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
            Me.btnCalcular = New System.Windows.Forms.Button()
            Me.dgvLista = New System.Windows.Forms.DataGridView()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtMayor = New System.Windows.Forms.TextBox()
            CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'lblFechaFinal
            '
            Me.lblFechaFinal.AutoSize = True
            Me.lblFechaFinal.Location = New System.Drawing.Point(223, 20)
            Me.lblFechaFinal.Name = "lblFechaFinal"
            Me.lblFechaFinal.Size = New System.Drawing.Size(62, 13)
            Me.lblFechaFinal.TabIndex = 225
            Me.lblFechaFinal.Text = "Fecha Final"
            '
            'lblFechaInicial
            '
            Me.lblFechaInicial.AutoSize = True
            Me.lblFechaInicial.Location = New System.Drawing.Point(101, 20)
            Me.lblFechaInicial.Name = "lblFechaInicial"
            Me.lblFechaInicial.Size = New System.Drawing.Size(67, 13)
            Me.lblFechaInicial.TabIndex = 224
            Me.lblFechaInicial.Text = "Fecha Inicial"
            '
            'dtpFinal
            '
            Me.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFinal.Location = New System.Drawing.Point(226, 35)
            Me.dtpFinal.MaxDate = New Date(3000, 12, 31, 0, 0, 0, 0)
            Me.dtpFinal.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
            Me.dtpFinal.Name = "dtpFinal"
            Me.dtpFinal.Size = New System.Drawing.Size(99, 20)
            Me.dtpFinal.TabIndex = 223
            Me.dtpFinal.Value = New Date(2011, 12, 27, 0, 0, 0, 0)
            '
            'dtpInicio
            '
            Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpInicio.Location = New System.Drawing.Point(101, 35)
            Me.dtpInicio.MaxDate = New Date(3000, 12, 31, 0, 0, 0, 0)
            Me.dtpInicio.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
            Me.dtpInicio.Name = "dtpInicio"
            Me.dtpInicio.Size = New System.Drawing.Size(99, 20)
            Me.dtpInicio.TabIndex = 222
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
            Me.btnCalcular.TabIndex = 221
            Me.btnCalcular.Text = "Calcular"
            Me.btnCalcular.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnCalcular.UseVisualStyleBackColor = True
            '
            'dgvLista
            '
            Me.dgvLista.AllowUserToAddRows = False
            Me.dgvLista.AllowUserToDeleteRows = False
            Me.dgvLista.AllowUserToResizeColumns = False
            Me.dgvLista.AllowUserToResizeRows = False
            Me.dgvLista.BackgroundColor = System.Drawing.Color.White
            Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            Me.dgvLista.GridColor = System.Drawing.Color.White
            Me.dgvLista.Location = New System.Drawing.Point(13, 78)
            Me.dgvLista.MultiSelect = False
            Me.dgvLista.Name = "dgvLista"
            Me.dgvLista.ReadOnly = True
            Me.dgvLista.RowHeadersVisible = False
            Me.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvLista.Size = New System.Drawing.Size(512, 409)
            Me.dgvLista.TabIndex = 226
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(367, 20)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(45, 13)
            Me.Label1.TabIndex = 227
            Me.Label1.Text = "Mayor a"
            '
            'txtMayor
            '
            Me.txtMayor.Location = New System.Drawing.Point(370, 35)
            Me.txtMayor.Name = "txtMayor"
            Me.txtMayor.Size = New System.Drawing.Size(100, 20)
            Me.txtMayor.TabIndex = 228
            Me.txtMayor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'FrmTotalVentaPorCliente
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(538, 496)
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
            Me.Name = "FrmTotalVentaPorCliente"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "FrmTotalVentaPorCliente"
            CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents lblFechaFinal As System.Windows.Forms.Label
        Friend WithEvents lblFechaInicial As System.Windows.Forms.Label
        Friend WithEvents dtpFinal As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
        Friend WithEvents btnCalcular As System.Windows.Forms.Button
        Friend WithEvents dgvLista As System.Windows.Forms.DataGridView
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtMayor As System.Windows.Forms.TextBox
    End Class
End Namespace