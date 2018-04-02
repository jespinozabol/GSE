<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSeleccionarEmails
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
        Me.lblMostrarProveedor = New System.Windows.Forms.Label()
        Me.lblIdProveedor = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbEmails = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.dgvEmails = New System.Windows.Forms.DataGridView()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnEnviar = New System.Windows.Forms.Button()
        CType(Me.dgvEmails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMostrarProveedor
        '
        Me.lblMostrarProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMostrarProveedor.Location = New System.Drawing.Point(14, 13)
        Me.lblMostrarProveedor.Name = "lblMostrarProveedor"
        Me.lblMostrarProveedor.Size = New System.Drawing.Size(368, 20)
        Me.lblMostrarProveedor.TabIndex = 1
        '
        'lblIdProveedor
        '
        Me.lblIdProveedor.Location = New System.Drawing.Point(12, 5)
        Me.lblIdProveedor.Name = "lblIdProveedor"
        Me.lblIdProveedor.Size = New System.Drawing.Size(8, 8)
        Me.lblIdProveedor.TabIndex = 2
        Me.lblIdProveedor.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Emails"
        '
        'cmbEmails
        '
        Me.cmbEmails.FormattingEnabled = True
        Me.cmbEmails.Location = New System.Drawing.Point(57, 39)
        Me.cmbEmails.Name = "cmbEmails"
        Me.cmbEmails.Size = New System.Drawing.Size(243, 21)
        Me.cmbEmails.TabIndex = 4
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(307, 36)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'dgvEmails
        '
        Me.dgvEmails.AllowUserToAddRows = False
        Me.dgvEmails.AllowUserToDeleteRows = False
        Me.dgvEmails.AllowUserToResizeColumns = False
        Me.dgvEmails.AllowUserToResizeRows = False
        Me.dgvEmails.BackgroundColor = System.Drawing.Color.White
        Me.dgvEmails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgvEmails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvEmails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Email})
        Me.dgvEmails.GridColor = System.Drawing.Color.White
        Me.dgvEmails.Location = New System.Drawing.Point(16, 66)
        Me.dgvEmails.MultiSelect = False
        Me.dgvEmails.Name = "dgvEmails"
        Me.dgvEmails.ReadOnly = True
        Me.dgvEmails.RowHeadersVisible = False
        Me.dgvEmails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvEmails.Size = New System.Drawing.Size(366, 111)
        Me.dgvEmails.TabIndex = 6
        '
        'Email
        '
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        Me.Email.Width = 150
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.Presentacion.My.Resources.Resources.Cancelar
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancelar.Location = New System.Drawing.Point(225, 197)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 46)
        Me.btnCancelar.TabIndex = 39
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Image = Global.Presentacion.My.Resources.Resources.aceptar
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAceptar.Location = New System.Drawing.Point(90, 197)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 46)
        Me.btnAceptar.TabIndex = 38
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnEnviar
        '
        Me.btnEnviar.Image = Global.Presentacion.My.Resources.Resources.aceptar
        Me.btnEnviar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEnviar.Location = New System.Drawing.Point(90, 197)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(75, 46)
        Me.btnEnviar.TabIndex = 40
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEnviar.UseVisualStyleBackColor = True
        Me.btnEnviar.Visible = False
        '
        'FrmSeleccionarEmails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 255)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.dgvEmails)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.cmbEmails)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblIdProveedor)
        Me.Controls.Add(Me.lblMostrarProveedor)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.btnAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSeleccionarEmails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccionar Emails"
        CType(Me.dgvEmails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMostrarProveedor As System.Windows.Forms.Label
    Friend WithEvents lblIdProveedor As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbEmails As System.Windows.Forms.ComboBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents dgvEmails As System.Windows.Forms.DataGridView
    Friend WithEvents Email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
End Class
