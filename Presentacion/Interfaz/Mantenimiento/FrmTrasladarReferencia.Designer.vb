Namespace Interfaz.Mantenimiento
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmTrasladarReferencia
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
            Me.txtNombre = New System.Windows.Forms.TextBox()
            Me.txtIdRef = New System.Windows.Forms.TextBox()
            Me.lblNombre = New System.Windows.Forms.Label()
            Me.lblIdRef = New System.Windows.Forms.Label()
            Me.lblEtiq1 = New System.Windows.Forms.Label()
            Me.txtNombreCambio = New System.Windows.Forms.TextBox()
            Me.txtId = New System.Windows.Forms.TextBox()
            Me.lblNombreC = New System.Windows.Forms.Label()
            Me.lblId = New System.Windows.Forms.Label()
            Me.txtGen = New System.Windows.Forms.TextBox()
            Me.lblGen = New System.Windows.Forms.Label()
            Me.btnTrasladar = New System.Windows.Forms.Button()
            Me.txtCedula = New System.Windows.Forms.TextBox()
            Me.lblCedula = New System.Windows.Forms.Label()
            Me.txtDireccion = New System.Windows.Forms.TextBox()
            Me.lblDireccion = New System.Windows.Forms.Label()
            Me.errorTrasladar = New System.Windows.Forms.ErrorProvider(Me.components)
            Me.dgvPersonas = New System.Windows.Forms.DataGridView()
            Me.lblEmail = New System.Windows.Forms.Label()
            Me.txtEmail = New System.Windows.Forms.TextBox()
            Me.txtOtroTelefono = New System.Windows.Forms.TextBox()
            Me.lblOtroTelefono = New System.Windows.Forms.Label()
            Me.txtFax = New System.Windows.Forms.TextBox()
            Me.lblFax = New System.Windows.Forms.Label()
            Me.txtTelefono = New System.Windows.Forms.TextBox()
            Me.lblTelefono = New System.Windows.Forms.Label()
            CType(Me.errorTrasladar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvPersonas, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'txtNombre
            '
            Me.txtNombre.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombre.Location = New System.Drawing.Point(139, 81)
            Me.txtNombre.Name = "txtNombre"
            Me.txtNombre.ReadOnly = True
            Me.txtNombre.Size = New System.Drawing.Size(249, 20)
            Me.txtNombre.TabIndex = 31
            '
            'txtIdRef
            '
            Me.txtIdRef.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtIdRef.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdRef.Location = New System.Drawing.Point(14, 81)
            Me.txtIdRef.Name = "txtIdRef"
            Me.txtIdRef.ReadOnly = True
            Me.txtIdRef.Size = New System.Drawing.Size(55, 20)
            Me.txtIdRef.TabIndex = 34
            '
            'lblNombre
            '
            Me.lblNombre.AutoSize = True
            Me.lblNombre.BackColor = System.Drawing.Color.Transparent
            Me.lblNombre.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblNombre.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombre.Location = New System.Drawing.Point(136, 60)
            Me.lblNombre.Name = "lblNombre"
            Me.lblNombre.Size = New System.Drawing.Size(53, 15)
            Me.lblNombre.TabIndex = 33
            Me.lblNombre.Text = "Nombre"
            '
            'lblIdRef
            '
            Me.lblIdRef.AutoSize = True
            Me.lblIdRef.BackColor = System.Drawing.Color.Transparent
            Me.lblIdRef.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblIdRef.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdRef.Location = New System.Drawing.Point(10, 60)
            Me.lblIdRef.Name = "lblIdRef"
            Me.lblIdRef.Size = New System.Drawing.Size(37, 15)
            Me.lblIdRef.TabIndex = 32
            Me.lblIdRef.Text = "IdRef"
            '
            'lblEtiq1
            '
            Me.lblEtiq1.AutoSize = True
            Me.lblEtiq1.BackColor = System.Drawing.Color.Transparent
            Me.lblEtiq1.Font = New System.Drawing.Font("Candara", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEtiq1.Location = New System.Drawing.Point(134, 104)
            Me.lblEtiq1.Name = "lblEtiq1"
            Me.lblEtiq1.Size = New System.Drawing.Size(114, 26)
            Me.lblEtiq1.TabIndex = 35
            Me.lblEtiq1.Text = "Trasladar a "
            '
            'txtNombreCambio
            '
            Me.txtNombreCambio.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtNombreCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreCambio.Location = New System.Drawing.Point(74, 148)
            Me.txtNombreCambio.Name = "txtNombreCambio"
            Me.txtNombreCambio.Size = New System.Drawing.Size(282, 20)
            Me.txtNombreCambio.TabIndex = 0
            '
            'txtId
            '
            Me.txtId.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtId.Location = New System.Drawing.Point(14, 148)
            Me.txtId.Name = "txtId"
            Me.txtId.ReadOnly = True
            Me.txtId.Size = New System.Drawing.Size(55, 20)
            Me.txtId.TabIndex = 39
            '
            'lblNombreC
            '
            Me.lblNombreC.AutoSize = True
            Me.lblNombreC.BackColor = System.Drawing.Color.Transparent
            Me.lblNombreC.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblNombreC.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombreC.Location = New System.Drawing.Point(73, 127)
            Me.lblNombreC.Name = "lblNombreC"
            Me.lblNombreC.Size = New System.Drawing.Size(53, 15)
            Me.lblNombreC.TabIndex = 38
            Me.lblNombreC.Text = "Nombre"
            '
            'lblId
            '
            Me.lblId.AutoSize = True
            Me.lblId.BackColor = System.Drawing.Color.Transparent
            Me.lblId.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblId.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblId.Location = New System.Drawing.Point(12, 127)
            Me.lblId.Name = "lblId"
            Me.lblId.Size = New System.Drawing.Size(18, 15)
            Me.lblId.TabIndex = 37
            Me.lblId.Text = "Id"
            '
            'txtGen
            '
            Me.txtGen.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtGen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtGen.Location = New System.Drawing.Point(76, 81)
            Me.txtGen.Name = "txtGen"
            Me.txtGen.ReadOnly = True
            Me.txtGen.Size = New System.Drawing.Size(55, 20)
            Me.txtGen.TabIndex = 41
            '
            'lblGen
            '
            Me.lblGen.AutoSize = True
            Me.lblGen.BackColor = System.Drawing.Color.Transparent
            Me.lblGen.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblGen.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblGen.Location = New System.Drawing.Point(72, 60)
            Me.lblGen.Name = "lblGen"
            Me.lblGen.Size = New System.Drawing.Size(40, 15)
            Me.lblGen.TabIndex = 40
            Me.lblGen.Text = "IdGen"
            '
            'btnTrasladar
            '
            Me.btnTrasladar.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnTrasladar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnTrasladar.Image = Global.Presentacion.My.Resources.Resources.Copiar
            Me.btnTrasladar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnTrasladar.Location = New System.Drawing.Point(0, 0)
            Me.btnTrasladar.Name = "btnTrasladar"
            Me.btnTrasladar.Size = New System.Drawing.Size(70, 57)
            Me.btnTrasladar.TabIndex = 42
            Me.btnTrasladar.Text = "Trasladar"
            Me.btnTrasladar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnTrasladar.UseVisualStyleBackColor = True
            '
            'txtCedula
            '
            Me.txtCedula.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCedula.Location = New System.Drawing.Point(15, 235)
            Me.txtCedula.Name = "txtCedula"
            Me.txtCedula.Size = New System.Drawing.Size(100, 20)
            Me.txtCedula.TabIndex = 45
            '
            'lblCedula
            '
            Me.lblCedula.AutoSize = True
            Me.lblCedula.BackColor = System.Drawing.Color.Transparent
            Me.lblCedula.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblCedula.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCedula.Location = New System.Drawing.Point(13, 213)
            Me.lblCedula.Name = "lblCedula"
            Me.lblCedula.Size = New System.Drawing.Size(44, 15)
            Me.lblCedula.TabIndex = 44
            Me.lblCedula.Text = "Cédula"
            '
            'txtDireccion
            '
            Me.txtDireccion.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDireccion.Location = New System.Drawing.Point(15, 279)
            Me.txtDireccion.Name = "txtDireccion"
            Me.txtDireccion.Size = New System.Drawing.Size(360, 20)
            Me.txtDireccion.TabIndex = 51
            '
            'lblDireccion
            '
            Me.lblDireccion.AutoSize = True
            Me.lblDireccion.BackColor = System.Drawing.Color.Transparent
            Me.lblDireccion.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblDireccion.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDireccion.Location = New System.Drawing.Point(12, 258)
            Me.lblDireccion.Name = "lblDireccion"
            Me.lblDireccion.Size = New System.Drawing.Size(59, 15)
            Me.lblDireccion.TabIndex = 50
            Me.lblDireccion.Text = "Dirección"
            '
            'errorTrasladar
            '
            Me.errorTrasladar.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
            Me.errorTrasladar.ContainerControl = Me
            '
            'dgvPersonas
            '
            Me.dgvPersonas.AllowUserToAddRows = False
            Me.dgvPersonas.AllowUserToDeleteRows = False
            Me.dgvPersonas.AllowUserToResizeColumns = False
            Me.dgvPersonas.AllowUserToResizeRows = False
            Me.dgvPersonas.BackgroundColor = System.Drawing.Color.White
            Me.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvPersonas.GridColor = System.Drawing.Color.White
            Me.dgvPersonas.Location = New System.Drawing.Point(75, 168)
            Me.dgvPersonas.MultiSelect = False
            Me.dgvPersonas.Name = "dgvPersonas"
            Me.dgvPersonas.ReadOnly = True
            Me.dgvPersonas.RowHeadersVisible = False
            Me.dgvPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvPersonas.Size = New System.Drawing.Size(313, 104)
            Me.dgvPersonas.TabIndex = 52
            Me.dgvPersonas.Visible = False
            '
            'lblEmail
            '
            Me.lblEmail.AutoSize = True
            Me.lblEmail.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEmail.Location = New System.Drawing.Point(121, 214)
            Me.lblEmail.Name = "lblEmail"
            Me.lblEmail.Size = New System.Drawing.Size(37, 15)
            Me.lblEmail.TabIndex = 255
            Me.lblEmail.Text = "Email"
            '
            'txtEmail
            '
            Me.txtEmail.Location = New System.Drawing.Point(122, 234)
            Me.txtEmail.MaxLength = 45
            Me.txtEmail.Name = "txtEmail"
            Me.txtEmail.Size = New System.Drawing.Size(256, 23)
            Me.txtEmail.TabIndex = 254
            '
            'txtOtroTelefono
            '
            Me.txtOtroTelefono.Location = New System.Drawing.Point(138, 187)
            Me.txtOtroTelefono.MaxLength = 9
            Me.txtOtroTelefono.Name = "txtOtroTelefono"
            Me.txtOtroTelefono.Size = New System.Drawing.Size(90, 23)
            Me.txtOtroTelefono.TabIndex = 253
            Me.txtOtroTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblOtroTelefono
            '
            Me.lblOtroTelefono.AutoSize = True
            Me.lblOtroTelefono.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblOtroTelefono.Location = New System.Drawing.Point(137, 171)
            Me.lblOtroTelefono.Name = "lblOtroTelefono"
            Me.lblOtroTelefono.Size = New System.Drawing.Size(84, 15)
            Me.lblOtroTelefono.TabIndex = 252
            Me.lblOtroTelefono.Text = "Otro Teléfono"
            '
            'txtFax
            '
            Me.txtFax.Location = New System.Drawing.Point(257, 187)
            Me.txtFax.MaxLength = 9
            Me.txtFax.Name = "txtFax"
            Me.txtFax.Size = New System.Drawing.Size(90, 23)
            Me.txtFax.TabIndex = 251
            Me.txtFax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblFax
            '
            Me.lblFax.AutoSize = True
            Me.lblFax.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFax.Location = New System.Drawing.Point(255, 171)
            Me.lblFax.Name = "lblFax"
            Me.lblFax.Size = New System.Drawing.Size(76, 15)
            Me.lblFax.TabIndex = 250
            Me.lblFax.Text = "Fax Principal"
            '
            'txtTelefono
            '
            Me.txtTelefono.Location = New System.Drawing.Point(15, 187)
            Me.txtTelefono.MaxLength = 9
            Me.txtTelefono.Name = "txtTelefono"
            Me.txtTelefono.Size = New System.Drawing.Size(90, 23)
            Me.txtTelefono.TabIndex = 249
            Me.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblTelefono
            '
            Me.lblTelefono.AutoSize = True
            Me.lblTelefono.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTelefono.Location = New System.Drawing.Point(13, 171)
            Me.lblTelefono.Name = "lblTelefono"
            Me.lblTelefono.Size = New System.Drawing.Size(100, 14)
            Me.lblTelefono.TabIndex = 248
            Me.lblTelefono.Text = "Teléfono Principal"
            '
            'FrmTrasladarReferencia
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.ClientSize = New System.Drawing.Size(393, 308)
            Me.Controls.Add(Me.dgvPersonas)
            Me.Controls.Add(Me.lblEmail)
            Me.Controls.Add(Me.txtEmail)
            Me.Controls.Add(Me.txtOtroTelefono)
            Me.Controls.Add(Me.lblOtroTelefono)
            Me.Controls.Add(Me.txtFax)
            Me.Controls.Add(Me.lblFax)
            Me.Controls.Add(Me.txtTelefono)
            Me.Controls.Add(Me.lblTelefono)
            Me.Controls.Add(Me.txtDireccion)
            Me.Controls.Add(Me.lblDireccion)
            Me.Controls.Add(Me.txtCedula)
            Me.Controls.Add(Me.lblCedula)
            Me.Controls.Add(Me.btnTrasladar)
            Me.Controls.Add(Me.txtGen)
            Me.Controls.Add(Me.lblGen)
            Me.Controls.Add(Me.txtNombreCambio)
            Me.Controls.Add(Me.txtId)
            Me.Controls.Add(Me.lblNombreC)
            Me.Controls.Add(Me.lblId)
            Me.Controls.Add(Me.lblEtiq1)
            Me.Controls.Add(Me.txtNombre)
            Me.Controls.Add(Me.txtIdRef)
            Me.Controls.Add(Me.lblNombre)
            Me.Controls.Add(Me.lblIdRef)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmTrasladarReferencia"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "FrmTrasladarReferencia"
            CType(Me.errorTrasladar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvPersonas, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents txtNombre As System.Windows.Forms.TextBox
        Friend WithEvents txtIdRef As System.Windows.Forms.TextBox
        Friend WithEvents lblNombre As System.Windows.Forms.Label
        Friend WithEvents lblIdRef As System.Windows.Forms.Label
        Friend WithEvents lblEtiq1 As System.Windows.Forms.Label
        Friend WithEvents txtNombreCambio As System.Windows.Forms.TextBox
        Friend WithEvents txtId As System.Windows.Forms.TextBox
        Friend WithEvents lblNombreC As System.Windows.Forms.Label
        Friend WithEvents lblId As System.Windows.Forms.Label
        Friend WithEvents txtGen As System.Windows.Forms.TextBox
        Friend WithEvents lblGen As System.Windows.Forms.Label
        Friend WithEvents btnTrasladar As System.Windows.Forms.Button
        Friend WithEvents txtCedula As System.Windows.Forms.TextBox
        Friend WithEvents lblCedula As System.Windows.Forms.Label
        Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
        Friend WithEvents lblDireccion As System.Windows.Forms.Label
        Friend WithEvents errorTrasladar As System.Windows.Forms.ErrorProvider
        Friend WithEvents dgvPersonas As System.Windows.Forms.DataGridView
        Friend WithEvents lblEmail As System.Windows.Forms.Label
        Friend WithEvents txtEmail As System.Windows.Forms.TextBox
        Friend WithEvents txtOtroTelefono As System.Windows.Forms.TextBox
        Friend WithEvents lblOtroTelefono As System.Windows.Forms.Label
        Friend WithEvents txtFax As System.Windows.Forms.TextBox
        Friend WithEvents lblFax As System.Windows.Forms.Label
        Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
        Friend WithEvents lblTelefono As System.Windows.Forms.Label
    End Class
End Namespace