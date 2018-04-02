Namespace Interfaz.Mantenimiento
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmModificarCliente
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
            Me.lblId = New System.Windows.Forms.Label()
            Me.txtId = New System.Windows.Forms.TextBox()
            Me.txtCedula = New System.Windows.Forms.TextBox()
            Me.lblCedula = New System.Windows.Forms.Label()
            Me.txtNombre = New System.Windows.Forms.TextBox()
            Me.lblNombre = New System.Windows.Forms.Label()
            Me.txtApellido1 = New System.Windows.Forms.TextBox()
            Me.lblApellido1 = New System.Windows.Forms.Label()
            Me.txtApellido2 = New System.Windows.Forms.TextBox()
            Me.lblApellido2 = New System.Windows.Forms.Label()
            Me.btnGuardar = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'lblId
            '
            Me.lblId.AutoSize = True
            Me.lblId.BackColor = System.Drawing.Color.Transparent
            Me.lblId.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblId.Location = New System.Drawing.Point(12, 72)
            Me.lblId.Name = "lblId"
            Me.lblId.Size = New System.Drawing.Size(21, 15)
            Me.lblId.TabIndex = 0
            Me.lblId.Text = "Id:"
            '
            'txtId
            '
            Me.txtId.Location = New System.Drawing.Point(31, 70)
            Me.txtId.Name = "txtId"
            Me.txtId.ReadOnly = True
            Me.txtId.Size = New System.Drawing.Size(51, 20)
            Me.txtId.TabIndex = 6
            '
            'txtCedula
            '
            Me.txtCedula.Location = New System.Drawing.Point(147, 69)
            Me.txtCedula.MaxLength = 18
            Me.txtCedula.Name = "txtCedula"
            Me.txtCedula.Size = New System.Drawing.Size(130, 20)
            Me.txtCedula.TabIndex = 0
            '
            'lblCedula
            '
            Me.lblCedula.AutoSize = True
            Me.lblCedula.BackColor = System.Drawing.Color.Transparent
            Me.lblCedula.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCedula.Location = New System.Drawing.Point(94, 70)
            Me.lblCedula.Name = "lblCedula"
            Me.lblCedula.Size = New System.Drawing.Size(47, 15)
            Me.lblCedula.TabIndex = 2
            Me.lblCedula.Text = "Cédula:"
            '
            'txtNombre
            '
            Me.txtNombre.Location = New System.Drawing.Point(75, 98)
            Me.txtNombre.Name = "txtNombre"
            Me.txtNombre.Size = New System.Drawing.Size(222, 20)
            Me.txtNombre.TabIndex = 1
            '
            'lblNombre
            '
            Me.lblNombre.AutoSize = True
            Me.lblNombre.BackColor = System.Drawing.Color.Transparent
            Me.lblNombre.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombre.Location = New System.Drawing.Point(13, 103)
            Me.lblNombre.Name = "lblNombre"
            Me.lblNombre.Size = New System.Drawing.Size(56, 15)
            Me.lblNombre.TabIndex = 4
            Me.lblNombre.Text = "Nombre:"
            '
            'txtApellido1
            '
            Me.txtApellido1.Location = New System.Drawing.Point(75, 130)
            Me.txtApellido1.Name = "txtApellido1"
            Me.txtApellido1.Size = New System.Drawing.Size(132, 20)
            Me.txtApellido1.TabIndex = 2
            '
            'lblApellido1
            '
            Me.lblApellido1.AutoSize = True
            Me.lblApellido1.BackColor = System.Drawing.Color.Transparent
            Me.lblApellido1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblApellido1.Location = New System.Drawing.Point(6, 135)
            Me.lblApellido1.Name = "lblApellido1"
            Me.lblApellido1.Size = New System.Drawing.Size(63, 15)
            Me.lblApellido1.TabIndex = 6
            Me.lblApellido1.Text = "Apellido 1:"
            '
            'txtApellido2
            '
            Me.txtApellido2.Location = New System.Drawing.Point(77, 166)
            Me.txtApellido2.Name = "txtApellido2"
            Me.txtApellido2.Size = New System.Drawing.Size(130, 20)
            Me.txtApellido2.TabIndex = 3
            '
            'lblApellido2
            '
            Me.lblApellido2.AutoSize = True
            Me.lblApellido2.BackColor = System.Drawing.Color.Transparent
            Me.lblApellido2.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblApellido2.Location = New System.Drawing.Point(7, 171)
            Me.lblApellido2.Name = "lblApellido2"
            Me.lblApellido2.Size = New System.Drawing.Size(64, 15)
            Me.lblApellido2.TabIndex = 8
            Me.lblApellido2.Text = "Apellido 2:"
            '
            'btnGuardar
            '
            Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnGuardar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = Global.Presentacion.My.Resources.Resources.Guardar
            Me.btnGuardar.Location = New System.Drawing.Point(0, 0)
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(71, 57)
            Me.btnGuardar.TabIndex = 4
            Me.btnGuardar.Text = "Guardar"
            Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnGuardar.UseVisualStyleBackColor = True
            '
            'FrmModificarCliente
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.ClientSize = New System.Drawing.Size(302, 193)
            Me.Controls.Add(Me.btnGuardar)
            Me.Controls.Add(Me.txtApellido2)
            Me.Controls.Add(Me.lblApellido2)
            Me.Controls.Add(Me.txtApellido1)
            Me.Controls.Add(Me.lblApellido1)
            Me.Controls.Add(Me.txtNombre)
            Me.Controls.Add(Me.lblNombre)
            Me.Controls.Add(Me.txtCedula)
            Me.Controls.Add(Me.lblCedula)
            Me.Controls.Add(Me.txtId)
            Me.Controls.Add(Me.lblId)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmModificarCliente"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "FrmModificarCliente"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents lblId As System.Windows.Forms.Label
        Friend WithEvents txtId As System.Windows.Forms.TextBox
        Friend WithEvents txtCedula As System.Windows.Forms.TextBox
        Friend WithEvents lblCedula As System.Windows.Forms.Label
        Friend WithEvents txtNombre As System.Windows.Forms.TextBox
        Friend WithEvents lblNombre As System.Windows.Forms.Label
        Friend WithEvents txtApellido1 As System.Windows.Forms.TextBox
        Friend WithEvents lblApellido1 As System.Windows.Forms.Label
        Friend WithEvents txtApellido2 As System.Windows.Forms.TextBox
        Friend WithEvents lblApellido2 As System.Windows.Forms.Label
        Friend WithEvents btnGuardar As System.Windows.Forms.Button
    End Class
End Namespace