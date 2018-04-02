<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDevolucionPorPaquete
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.dgvDevoluciones = New System.Windows.Forms.DataGridView()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.lblNumPaquete = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMostrarProveedor = New System.Windows.Forms.Label()
        Me.lblMostrarNumPaquete = New System.Windows.Forms.Label()
        CType(Me.dgvDevoluciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(0, 0)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(70, 57)
        Me.btnNuevo.TabIndex = 318
        Me.btnNuevo.Text = "Agregar Artículo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'dgvDevoluciones
        '
        Me.dgvDevoluciones.AllowUserToAddRows = False
        Me.dgvDevoluciones.AllowUserToDeleteRows = False
        Me.dgvDevoluciones.AllowUserToResizeColumns = False
        Me.dgvDevoluciones.AllowUserToResizeRows = False
        Me.dgvDevoluciones.BackgroundColor = System.Drawing.Color.White
        Me.dgvDevoluciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgvDevoluciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDevoluciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvDevoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDevoluciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cantidad, Me.Producto})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDevoluciones.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvDevoluciones.GridColor = System.Drawing.Color.White
        Me.dgvDevoluciones.Location = New System.Drawing.Point(7, 99)
        Me.dgvDevoluciones.MultiSelect = False
        Me.dgvDevoluciones.Name = "dgvDevoluciones"
        Me.dgvDevoluciones.ReadOnly = True
        Me.dgvDevoluciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDevoluciones.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvDevoluciones.RowHeadersVisible = False
        Me.dgvDevoluciones.RowTemplate.Height = 18
        Me.dgvDevoluciones.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDevoluciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDevoluciones.Size = New System.Drawing.Size(591, 316)
        Me.dgvDevoluciones.TabIndex = 319
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cant"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 60
        '
        'Producto
        '
        Me.Producto.HeaderText = "Descripcion del Producto"
        Me.Producto.Name = "Producto"
        Me.Producto.ReadOnly = True
        Me.Producto.Width = 300
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Image = Global.Presentacion.My.Resources.Resources.Limpiar
        Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLimpiar.Location = New System.Drawing.Point(69, 0)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(70, 57)
        Me.btnLimpiar.TabIndex = 316
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'lblNumPaquete
        '
        Me.lblNumPaquete.AutoSize = True
        Me.lblNumPaquete.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumPaquete.Location = New System.Drawing.Point(397, 18)
        Me.lblNumPaquete.Name = "lblNumPaquete"
        Me.lblNumPaquete.Size = New System.Drawing.Size(103, 26)
        Me.lblNumPaquete.TabIndex = 320
        Me.lblNumPaquete.Text = "Paquete #"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 19)
        Me.Label1.TabIndex = 321
        Me.Label1.Text = "Proveedor"
        '
        'lblMostrarProveedor
        '
        Me.lblMostrarProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMostrarProveedor.Location = New System.Drawing.Point(98, 65)
        Me.lblMostrarProveedor.Name = "lblMostrarProveedor"
        Me.lblMostrarProveedor.Size = New System.Drawing.Size(500, 23)
        Me.lblMostrarProveedor.TabIndex = 322
        Me.lblMostrarProveedor.Text = "Label2"
        Me.lblMostrarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMostrarNumPaquete
        '
        Me.lblMostrarNumPaquete.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMostrarNumPaquete.Location = New System.Drawing.Point(507, 20)
        Me.lblMostrarNumPaquete.Name = "lblMostrarNumPaquete"
        Me.lblMostrarNumPaquete.Size = New System.Drawing.Size(100, 23)
        Me.lblMostrarNumPaquete.TabIndex = 323
        Me.lblMostrarNumPaquete.Text = "Label2"
        Me.lblMostrarNumPaquete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmDevolucionPorPaquete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 420)
        Me.Controls.Add(Me.lblMostrarNumPaquete)
        Me.Controls.Add(Me.lblMostrarProveedor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNumPaquete)
        Me.Controls.Add(Me.dgvDevoluciones)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnLimpiar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDevolucionPorPaquete"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DevolucionPorPaquete"
        CType(Me.dgvDevoluciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents dgvDevoluciones As System.Windows.Forms.DataGridView
    Friend WithEvents lblNumPaquete As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblMostrarProveedor As System.Windows.Forms.Label
    Friend WithEvents lblMostrarNumPaquete As System.Windows.Forms.Label
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Producto As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
