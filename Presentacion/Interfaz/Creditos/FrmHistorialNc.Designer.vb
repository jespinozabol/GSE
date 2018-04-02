Namespace Interfaz.Creditos
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmHistorialNc
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
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.lblMostrarFactura = New System.Windows.Forms.Label()
            Me.lblNum = New System.Windows.Forms.Label()
            Me.dgvNotas_Credito = New System.Windows.Forms.DataGridView()
            Me.lblMostrarTotal = New System.Windows.Forms.Label()
            Me.lblTotal = New System.Windows.Forms.Label()
            Me.lblMostrarReciboNotas = New System.Windows.Forms.Label()
            Me.lblRecibo = New System.Windows.Forms.Label()
            Me.dgvLineasNC = New System.Windows.Forms.DataGridView()
            Me.Cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.PrecioU = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Descuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.IV = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            CType(Me.dgvNotas_Credito, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvLineasNC, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'lblMostrarFactura
            '
            Me.lblMostrarFactura.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarFactura.Location = New System.Drawing.Point(229, 38)
            Me.lblMostrarFactura.Name = "lblMostrarFactura"
            Me.lblMostrarFactura.Size = New System.Drawing.Size(100, 23)
            Me.lblMostrarFactura.TabIndex = 180
            '
            'lblNum
            '
            Me.lblNum.AutoSize = True
            Me.lblNum.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNum.Location = New System.Drawing.Point(83, 38)
            Me.lblNum.Name = "lblNum"
            Me.lblNum.Size = New System.Drawing.Size(140, 19)
            Me.lblNum.TabIndex = 179
            Me.lblNum.Text = "Número de Factura"
            '
            'dgvNotas_Credito
            '
            Me.dgvNotas_Credito.AllowUserToAddRows = False
            Me.dgvNotas_Credito.AllowUserToDeleteRows = False
            Me.dgvNotas_Credito.AllowUserToResizeColumns = False
            Me.dgvNotas_Credito.AllowUserToResizeRows = False
            Me.dgvNotas_Credito.BackgroundColor = System.Drawing.Color.White
            Me.dgvNotas_Credito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvNotas_Credito.Location = New System.Drawing.Point(14, 19)
            Me.dgvNotas_Credito.MultiSelect = False
            Me.dgvNotas_Credito.Name = "dgvNotas_Credito"
            Me.dgvNotas_Credito.ReadOnly = True
            Me.dgvNotas_Credito.RowHeadersVisible = False
            Me.dgvNotas_Credito.RowTemplate.Height = 18
            Me.dgvNotas_Credito.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvNotas_Credito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvNotas_Credito.Size = New System.Drawing.Size(224, 103)
            Me.dgvNotas_Credito.TabIndex = 178
            '
            'lblMostrarTotal
            '
            Me.lblMostrarTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarTotal.ForeColor = System.Drawing.Color.Red
            Me.lblMostrarTotal.Location = New System.Drawing.Point(600, 306)
            Me.lblMostrarTotal.Name = "lblMostrarTotal"
            Me.lblMostrarTotal.Size = New System.Drawing.Size(123, 20)
            Me.lblMostrarTotal.TabIndex = 236
            Me.lblMostrarTotal.Text = "0.00"
            Me.lblMostrarTotal.TextAlign = System.Drawing.ContentAlignment.BottomRight
            '
            'lblTotal
            '
            Me.lblTotal.AutoSize = True
            Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotal.Location = New System.Drawing.Point(368, 307)
            Me.lblTotal.Name = "lblTotal"
            Me.lblTotal.Size = New System.Drawing.Size(230, 25)
            Me.lblTotal.TabIndex = 235
            Me.lblTotal.Text = "Total nota de crédito"
            '
            'lblMostrarReciboNotas
            '
            Me.lblMostrarReciboNotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarReciboNotas.Location = New System.Drawing.Point(106, 126)
            Me.lblMostrarReciboNotas.Name = "lblMostrarReciboNotas"
            Me.lblMostrarReciboNotas.Size = New System.Drawing.Size(62, 19)
            Me.lblMostrarReciboNotas.TabIndex = 234
            Me.lblMostrarReciboNotas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblRecibo
            '
            Me.lblRecibo.AutoSize = True
            Me.lblRecibo.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblRecibo.Location = New System.Drawing.Point(12, 130)
            Me.lblRecibo.Name = "lblRecibo"
            Me.lblRecibo.Size = New System.Drawing.Size(88, 15)
            Me.lblRecibo.TabIndex = 233
            Me.lblRecibo.Text = "# Nota Crédito"
            '
            'dgvLineasNC
            '
            Me.dgvLineasNC.AllowUserToAddRows = False
            Me.dgvLineasNC.AllowUserToDeleteRows = False
            Me.dgvLineasNC.AllowUserToResizeColumns = False
            Me.dgvLineasNC.AllowUserToResizeRows = False
            Me.dgvLineasNC.BackgroundColor = System.Drawing.Color.White
            Me.dgvLineasNC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvLineasNC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cant, Me.Cod, Me.Descripcion, Me.PrecioU, Me.Descuento, Me.IV, Me.Subtotal})
            Me.dgvLineasNC.GridColor = System.Drawing.Color.White
            Me.dgvLineasNC.Location = New System.Drawing.Point(10, 159)
            Me.dgvLineasNC.MultiSelect = False
            Me.dgvLineasNC.Name = "dgvLineasNC"
            Me.dgvLineasNC.ReadOnly = True
            Me.dgvLineasNC.RowHeadersVisible = False
            Me.dgvLineasNC.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
            Me.dgvLineasNC.RowTemplate.Height = 18
            Me.dgvLineasNC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvLineasNC.Size = New System.Drawing.Size(714, 132)
            Me.dgvLineasNC.TabIndex = 232
            '
            'Cant
            '
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Cant.DefaultCellStyle = DataGridViewCellStyle1
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
            Me.Descripcion.Width = 335
            '
            'PrecioU
            '
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.PrecioU.DefaultCellStyle = DataGridViewCellStyle2
            Me.PrecioU.HeaderText = "Precio/U"
            Me.PrecioU.Name = "PrecioU"
            Me.PrecioU.ReadOnly = True
            Me.PrecioU.Width = 75
            '
            'Descuento
            '
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Descuento.DefaultCellStyle = DataGridViewCellStyle3
            Me.Descuento.HeaderText = "Desc"
            Me.Descuento.Name = "Descuento"
            Me.Descuento.ReadOnly = True
            Me.Descuento.Width = 52
            '
            'IV
            '
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.IV.DefaultCellStyle = DataGridViewCellStyle4
            Me.IV.HeaderText = "I.V"
            Me.IV.Name = "IV"
            Me.IV.ReadOnly = True
            Me.IV.Width = 52
            '
            'Subtotal
            '
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Subtotal.DefaultCellStyle = DataGridViewCellStyle5
            Me.Subtotal.HeaderText = "SubTotal"
            Me.Subtotal.Name = "Subtotal"
            Me.Subtotal.ReadOnly = True
            Me.Subtotal.Width = 92
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.dgvNotas_Credito)
            Me.GroupBox1.Location = New System.Drawing.Point(398, 12)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(253, 132)
            Me.GroupBox1.TabIndex = 237
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Notas de Crédito"
            '
            'FrmHistorialNc
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(731, 341)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.lblMostrarTotal)
            Me.Controls.Add(Me.lblTotal)
            Me.Controls.Add(Me.lblMostrarReciboNotas)
            Me.Controls.Add(Me.lblRecibo)
            Me.Controls.Add(Me.dgvLineasNC)
            Me.Controls.Add(Me.lblMostrarFactura)
            Me.Controls.Add(Me.lblNum)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmHistorialNc"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "FrmHistorial_NC"
            CType(Me.dgvNotas_Credito, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvLineasNC, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents lblMostrarFactura As System.Windows.Forms.Label
        Friend WithEvents lblNum As System.Windows.Forms.Label
        Friend WithEvents dgvNotas_Credito As System.Windows.Forms.DataGridView
        Friend WithEvents lblMostrarTotal As System.Windows.Forms.Label
        Friend WithEvents lblTotal As System.Windows.Forms.Label
        Friend WithEvents lblMostrarReciboNotas As System.Windows.Forms.Label
        Friend WithEvents lblRecibo As System.Windows.Forms.Label
        Friend WithEvents dgvLineasNC As System.Windows.Forms.DataGridView
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents Cant As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Cod As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents PrecioU As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Descuento As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents IV As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Subtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    End Class
End Namespace