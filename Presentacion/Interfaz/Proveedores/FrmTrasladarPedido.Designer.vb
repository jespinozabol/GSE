Namespace Interfaz.Proveedores
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmTrasladarPedido
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
            Me.txtNombreTrasladar = New System.Windows.Forms.TextBox()
            Me.lblNombre = New System.Windows.Forms.Label()
            Me.dgvProveedores = New System.Windows.Forms.DataGridView()
            Me.btnAceptar = New System.Windows.Forms.Button()
            Me.txtFechaCreacion = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtNombre = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtId_Pedido = New System.Windows.Forms.TextBox()
            Me.txtIdProveedorTrasladar = New System.Windows.Forms.TextBox()
            CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'txtNombreTrasladar
            '
            Me.txtNombreTrasladar.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtNombreTrasladar.Location = New System.Drawing.Point(18, 62)
            Me.txtNombreTrasladar.MaxLength = 45
            Me.txtNombreTrasladar.Name = "txtNombreTrasladar"
            Me.txtNombreTrasladar.Size = New System.Drawing.Size(311, 20)
            Me.txtNombreTrasladar.TabIndex = 120
            '
            'lblNombre
            '
            Me.lblNombre.AutoSize = True
            Me.lblNombre.BackColor = System.Drawing.Color.Transparent
            Me.lblNombre.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblNombre.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombre.Location = New System.Drawing.Point(16, 46)
            Me.lblNombre.Name = "lblNombre"
            Me.lblNombre.Size = New System.Drawing.Size(67, 15)
            Me.lblNombre.TabIndex = 121
            Me.lblNombre.Text = "Trasladar A"
            '
            'dgvProveedores
            '
            Me.dgvProveedores.AllowUserToAddRows = False
            Me.dgvProveedores.AllowUserToDeleteRows = False
            Me.dgvProveedores.AllowUserToResizeColumns = False
            Me.dgvProveedores.AllowUserToResizeRows = False
            Me.dgvProveedores.BackgroundColor = System.Drawing.Color.White
            Me.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvProveedores.Cursor = System.Windows.Forms.Cursors.Hand
            Me.dgvProveedores.GridColor = System.Drawing.Color.White
            Me.dgvProveedores.Location = New System.Drawing.Point(18, 83)
            Me.dgvProveedores.MultiSelect = False
            Me.dgvProveedores.Name = "dgvProveedores"
            Me.dgvProveedores.ReadOnly = True
            Me.dgvProveedores.RowHeadersVisible = False
            Me.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvProveedores.Size = New System.Drawing.Size(287, 92)
            Me.dgvProveedores.TabIndex = 126
            Me.dgvProveedores.Visible = False
            '
            'btnAceptar
            '
            Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnAceptar.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAceptar.Image = Global.Presentacion.My.Resources.Resources.aceptar
            Me.btnAceptar.Location = New System.Drawing.Point(192, 102)
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(64, 52)
            Me.btnAceptar.TabIndex = 127
            Me.btnAceptar.Text = "Trasladar"
            Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnAceptar.UseVisualStyleBackColor = True
            '
            'txtFechaCreacion
            '
            Me.txtFechaCreacion.Enabled = False
            Me.txtFechaCreacion.Location = New System.Drawing.Point(336, 23)
            Me.txtFechaCreacion.MaxLength = 8
            Me.txtFechaCreacion.Name = "txtFechaCreacion"
            Me.txtFechaCreacion.ReadOnly = True
            Me.txtFechaCreacion.Size = New System.Drawing.Size(87, 20)
            Me.txtFechaCreacion.TabIndex = 129
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(333, 7)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(82, 13)
            Me.Label1.TabIndex = 131
            Me.Label1.Text = "Fecha Creación"
            '
            'txtNombre
            '
            Me.txtNombre.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtNombre.Location = New System.Drawing.Point(18, 23)
            Me.txtNombre.MaxLength = 45
            Me.txtNombre.Name = "txtNombre"
            Me.txtNombre.ReadOnly = True
            Me.txtNombre.Size = New System.Drawing.Size(311, 20)
            Me.txtNombre.TabIndex = 128
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.BackColor = System.Drawing.Color.Transparent
            Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Label2.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(17, 7)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(53, 15)
            Me.Label2.TabIndex = 130
            Me.Label2.Text = "Nombre"
            '
            'txtId_Pedido
            '
            Me.txtId_Pedido.Location = New System.Drawing.Point(76, 2)
            Me.txtId_Pedido.Name = "txtId_Pedido"
            Me.txtId_Pedido.ReadOnly = True
            Me.txtId_Pedido.Size = New System.Drawing.Size(42, 20)
            Me.txtId_Pedido.TabIndex = 132
            Me.txtId_Pedido.Visible = False
            '
            'txtIdProveedorTrasladar
            '
            Me.txtIdProveedorTrasladar.Location = New System.Drawing.Point(336, 49)
            Me.txtIdProveedorTrasladar.Name = "txtIdProveedorTrasladar"
            Me.txtIdProveedorTrasladar.ReadOnly = True
            Me.txtIdProveedorTrasladar.Size = New System.Drawing.Size(42, 20)
            Me.txtIdProveedorTrasladar.TabIndex = 133
            Me.txtIdProveedorTrasladar.Visible = False
            '
            'FrmTrasladarPedido
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(427, 182)
            Me.Controls.Add(Me.dgvProveedores)
            Me.Controls.Add(Me.txtIdProveedorTrasladar)
            Me.Controls.Add(Me.txtId_Pedido)
            Me.Controls.Add(Me.txtFechaCreacion)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.txtNombre)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.btnAceptar)
            Me.Controls.Add(Me.txtNombreTrasladar)
            Me.Controls.Add(Me.lblNombre)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmTrasladarPedido"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Trasladar pedido"
            CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents txtNombreTrasladar As System.Windows.Forms.TextBox
        Friend WithEvents lblNombre As System.Windows.Forms.Label
        Friend WithEvents dgvProveedores As System.Windows.Forms.DataGridView
        Friend WithEvents btnAceptar As System.Windows.Forms.Button
        Friend WithEvents txtFechaCreacion As System.Windows.Forms.TextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtNombre As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtId_Pedido As System.Windows.Forms.TextBox
        Friend WithEvents txtIdProveedorTrasladar As System.Windows.Forms.TextBox
    End Class
End Namespace

