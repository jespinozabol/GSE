<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEncargadosCliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtCorreoEncargado = New System.Windows.Forms.TextBox()
        Me.lblCorreoEncargado = New System.Windows.Forms.Label()
        Me.txtExt1_Encargado = New System.Windows.Forms.TextBox()
        Me.lblExt1_Encargado = New System.Windows.Forms.Label()
        Me.txtTelefono2_Encargado = New System.Windows.Forms.TextBox()
        Me.btnAgregar_Encargado = New System.Windows.Forms.Button()
        Me.txtFax_Encargado = New System.Windows.Forms.TextBox()
        Me.txtTelefono1_Encargado = New System.Windows.Forms.TextBox()
        Me.txtServicio = New System.Windows.Forms.TextBox()
        Me.lblServicio = New System.Windows.Forms.Label()
        Me.lblFax_Encargado = New System.Windows.Forms.Label()
        Me.lblNombre_Encargado = New System.Windows.Forms.Label()
        Me.lblTelefono1_Encargado = New System.Windows.Forms.Label()
        Me.lblTelefono2_Encargado = New System.Windows.Forms.Label()
        Me.txtNombre_Encargado = New System.Windows.Forms.TextBox()
        Me.dgvEncargados = New System.Windows.Forms.DataGridView()
        Me.txtId_Encargado = New System.Windows.Forms.TextBox()
        Me.errProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MnEliminarEncargado = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EliminarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvEncargados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MnEliminarEncargado.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCorreoEncargado
        '
        Me.txtCorreoEncargado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtCorreoEncargado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreoEncargado.Location = New System.Drawing.Point(330, 61)
        Me.txtCorreoEncargado.MaxLength = 100
        Me.txtCorreoEncargado.Name = "txtCorreoEncargado"
        Me.txtCorreoEncargado.Size = New System.Drawing.Size(285, 20)
        Me.txtCorreoEncargado.TabIndex = 6
        '
        'lblCorreoEncargado
        '
        Me.lblCorreoEncargado.AutoSize = True
        Me.lblCorreoEncargado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCorreoEncargado.Location = New System.Drawing.Point(327, 47)
        Me.lblCorreoEncargado.Name = "lblCorreoEncargado"
        Me.lblCorreoEncargado.Size = New System.Drawing.Size(38, 13)
        Me.lblCorreoEncargado.TabIndex = 47
        Me.lblCorreoEncargado.Text = "Correo"
        '
        'txtExt1_Encargado
        '
        Me.txtExt1_Encargado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtExt1_Encargado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExt1_Encargado.Location = New System.Drawing.Point(486, 25)
        Me.txtExt1_Encargado.MaxLength = 4
        Me.txtExt1_Encargado.Name = "txtExt1_Encargado"
        Me.txtExt1_Encargado.Size = New System.Drawing.Size(50, 20)
        Me.txtExt1_Encargado.TabIndex = 4
        Me.txtExt1_Encargado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblExt1_Encargado
        '
        Me.lblExt1_Encargado.AutoSize = True
        Me.lblExt1_Encargado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblExt1_Encargado.Location = New System.Drawing.Point(486, 9)
        Me.lblExt1_Encargado.Name = "lblExt1_Encargado"
        Me.lblExt1_Encargado.Size = New System.Drawing.Size(38, 13)
        Me.lblExt1_Encargado.TabIndex = 46
        Me.lblExt1_Encargado.Text = "Ext #1"
        '
        'txtTelefono2_Encargado
        '
        Me.txtTelefono2_Encargado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtTelefono2_Encargado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono2_Encargado.Location = New System.Drawing.Point(333, 25)
        Me.txtTelefono2_Encargado.MaxLength = 9
        Me.txtTelefono2_Encargado.Name = "txtTelefono2_Encargado"
        Me.txtTelefono2_Encargado.Size = New System.Drawing.Size(70, 20)
        Me.txtTelefono2_Encargado.TabIndex = 2
        Me.txtTelefono2_Encargado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnAgregar_Encargado
        '
        Me.btnAgregar_Encargado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar_Encargado.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar_Encargado.Location = New System.Drawing.Point(549, 12)
        Me.btnAgregar_Encargado.Name = "btnAgregar_Encargado"
        Me.btnAgregar_Encargado.Size = New System.Drawing.Size(66, 38)
        Me.btnAgregar_Encargado.TabIndex = 7
        Me.btnAgregar_Encargado.Text = "Agregar / Modificar"
        Me.btnAgregar_Encargado.UseVisualStyleBackColor = True
        '
        'txtFax_Encargado
        '
        Me.txtFax_Encargado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtFax_Encargado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFax_Encargado.Location = New System.Drawing.Point(410, 25)
        Me.txtFax_Encargado.MaxLength = 9
        Me.txtFax_Encargado.Name = "txtFax_Encargado"
        Me.txtFax_Encargado.Size = New System.Drawing.Size(70, 20)
        Me.txtFax_Encargado.TabIndex = 3
        Me.txtFax_Encargado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTelefono1_Encargado
        '
        Me.txtTelefono1_Encargado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtTelefono1_Encargado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono1_Encargado.Location = New System.Drawing.Point(257, 25)
        Me.txtTelefono1_Encargado.MaxLength = 9
        Me.txtTelefono1_Encargado.Name = "txtTelefono1_Encargado"
        Me.txtTelefono1_Encargado.Size = New System.Drawing.Size(70, 20)
        Me.txtTelefono1_Encargado.TabIndex = 1
        Me.txtTelefono1_Encargado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtServicio
        '
        Me.txtServicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServicio.Location = New System.Drawing.Point(15, 62)
        Me.txtServicio.MaxLength = 50
        Me.txtServicio.Name = "txtServicio"
        Me.txtServicio.Size = New System.Drawing.Size(312, 20)
        Me.txtServicio.TabIndex = 5
        '
        'lblServicio
        '
        Me.lblServicio.AutoSize = True
        Me.lblServicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblServicio.Location = New System.Drawing.Point(12, 48)
        Me.lblServicio.Name = "lblServicio"
        Me.lblServicio.Size = New System.Drawing.Size(45, 13)
        Me.lblServicio.TabIndex = 6
        Me.lblServicio.Text = "Servicio"
        '
        'lblFax_Encargado
        '
        Me.lblFax_Encargado.AutoSize = True
        Me.lblFax_Encargado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblFax_Encargado.Location = New System.Drawing.Point(409, 9)
        Me.lblFax_Encargado.Name = "lblFax_Encargado"
        Me.lblFax_Encargado.Size = New System.Drawing.Size(24, 13)
        Me.lblFax_Encargado.TabIndex = 5
        Me.lblFax_Encargado.Text = "Fax"
        '
        'lblNombre_Encargado
        '
        Me.lblNombre_Encargado.AutoSize = True
        Me.lblNombre_Encargado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblNombre_Encargado.Location = New System.Drawing.Point(12, 9)
        Me.lblNombre_Encargado.Name = "lblNombre_Encargado"
        Me.lblNombre_Encargado.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre_Encargado.TabIndex = 3
        Me.lblNombre_Encargado.Text = "Nombre"
        '
        'lblTelefono1_Encargado
        '
        Me.lblTelefono1_Encargado.AutoSize = True
        Me.lblTelefono1_Encargado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblTelefono1_Encargado.Location = New System.Drawing.Point(254, 9)
        Me.lblTelefono1_Encargado.Name = "lblTelefono1_Encargado"
        Me.lblTelefono1_Encargado.Size = New System.Drawing.Size(65, 13)
        Me.lblTelefono1_Encargado.TabIndex = 2
        Me.lblTelefono1_Encargado.Text = "Teléfono #1"
        '
        'lblTelefono2_Encargado
        '
        Me.lblTelefono2_Encargado.AutoSize = True
        Me.lblTelefono2_Encargado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblTelefono2_Encargado.Location = New System.Drawing.Point(332, 9)
        Me.lblTelefono2_Encargado.Name = "lblTelefono2_Encargado"
        Me.lblTelefono2_Encargado.Size = New System.Drawing.Size(65, 13)
        Me.lblTelefono2_Encargado.TabIndex = 1
        Me.lblTelefono2_Encargado.Text = "Teléfono #2"
        '
        'txtNombre_Encargado
        '
        Me.txtNombre_Encargado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtNombre_Encargado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre_Encargado.Location = New System.Drawing.Point(12, 25)
        Me.txtNombre_Encargado.MaxLength = 40
        Me.txtNombre_Encargado.Name = "txtNombre_Encargado"
        Me.txtNombre_Encargado.Size = New System.Drawing.Size(240, 20)
        Me.txtNombre_Encargado.TabIndex = 0
        '
        'dgvEncargados
        '
        Me.dgvEncargados.AllowUserToAddRows = False
        Me.dgvEncargados.AllowUserToDeleteRows = False
        Me.dgvEncargados.AllowUserToResizeColumns = False
        Me.dgvEncargados.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvEncargados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvEncargados.BackgroundColor = System.Drawing.Color.White
        Me.dgvEncargados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEncargados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvEncargados.Location = New System.Drawing.Point(15, 93)
        Me.dgvEncargados.MultiSelect = False
        Me.dgvEncargados.Name = "dgvEncargados"
        Me.dgvEncargados.ReadOnly = True
        Me.dgvEncargados.RowHeadersVisible = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvEncargados.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvEncargados.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvEncargados.RowTemplate.Height = 18
        Me.dgvEncargados.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEncargados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEncargados.Size = New System.Drawing.Size(600, 155)
        Me.dgvEncargados.TabIndex = 41
        '
        'txtId_Encargado
        '
        Me.txtId_Encargado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtId_Encargado.Enabled = False
        Me.txtId_Encargado.Location = New System.Drawing.Point(549, 104)
        Me.txtId_Encargado.Name = "txtId_Encargado"
        Me.txtId_Encargado.Size = New System.Drawing.Size(50, 20)
        Me.txtId_Encargado.TabIndex = 20
        Me.txtId_Encargado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtId_Encargado.Visible = False
        '
        'errProvider
        '
        Me.errProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.errProvider.ContainerControl = Me
        '
        'MnEliminarEncargado
        '
        Me.MnEliminarEncargado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarToolStripMenuItem1})
        Me.MnEliminarEncargado.Name = "MnEliminarEncargado"
        Me.MnEliminarEncargado.Size = New System.Drawing.Size(118, 26)
        '
        'EliminarToolStripMenuItem1
        '
        Me.EliminarToolStripMenuItem1.Name = "EliminarToolStripMenuItem1"
        Me.EliminarToolStripMenuItem1.Size = New System.Drawing.Size(117, 22)
        Me.EliminarToolStripMenuItem1.Text = "Eliminar"
        '
        'FrmEncargadosCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 258)
        Me.Controls.Add(Me.txtCorreoEncargado)
        Me.Controls.Add(Me.lblCorreoEncargado)
        Me.Controls.Add(Me.dgvEncargados)
        Me.Controls.Add(Me.txtExt1_Encargado)
        Me.Controls.Add(Me.txtId_Encargado)
        Me.Controls.Add(Me.lblExt1_Encargado)
        Me.Controls.Add(Me.txtNombre_Encargado)
        Me.Controls.Add(Me.lblTelefono2_Encargado)
        Me.Controls.Add(Me.lblTelefono1_Encargado)
        Me.Controls.Add(Me.txtTelefono2_Encargado)
        Me.Controls.Add(Me.lblNombre_Encargado)
        Me.Controls.Add(Me.btnAgregar_Encargado)
        Me.Controls.Add(Me.lblFax_Encargado)
        Me.Controls.Add(Me.txtFax_Encargado)
        Me.Controls.Add(Me.lblServicio)
        Me.Controls.Add(Me.txtTelefono1_Encargado)
        Me.Controls.Add(Me.txtServicio)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmEncargadosCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Encargados"
        CType(Me.dgvEncargados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MnEliminarEncargado.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCorreoEncargado As System.Windows.Forms.TextBox
    Friend WithEvents lblCorreoEncargado As System.Windows.Forms.Label
    Friend WithEvents txtExt1_Encargado As System.Windows.Forms.TextBox
    Friend WithEvents lblExt1_Encargado As System.Windows.Forms.Label
    Friend WithEvents txtTelefono2_Encargado As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregar_Encargado As System.Windows.Forms.Button
    Friend WithEvents txtFax_Encargado As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono1_Encargado As System.Windows.Forms.TextBox
    Friend WithEvents txtServicio As System.Windows.Forms.TextBox
    Friend WithEvents lblServicio As System.Windows.Forms.Label
    Friend WithEvents lblFax_Encargado As System.Windows.Forms.Label
    Friend WithEvents lblNombre_Encargado As System.Windows.Forms.Label
    Friend WithEvents lblTelefono1_Encargado As System.Windows.Forms.Label
    Friend WithEvents lblTelefono2_Encargado As System.Windows.Forms.Label
    Friend WithEvents txtNombre_Encargado As System.Windows.Forms.TextBox
    Friend WithEvents dgvEncargados As System.Windows.Forms.DataGridView
    Friend WithEvents txtId_Encargado As System.Windows.Forms.TextBox
    Friend WithEvents errProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents MnEliminarEncargado As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EliminarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
