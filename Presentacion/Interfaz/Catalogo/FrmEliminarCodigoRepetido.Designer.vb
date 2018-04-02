Namespace Interfaz.Catalogo
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmEliminarCodigoRepetido
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
            Me.txtCodigo = New System.Windows.Forms.TextBox()
            Me.lblNuevoDescripción = New System.Windows.Forms.Label()
            Me.lblMostrarDescripNuevo = New System.Windows.Forms.Label()
            Me.lblCodigoNuevo = New System.Windows.Forms.Label()
            Me.lbl1 = New System.Windows.Forms.Label()
            Me.lblMostrarDescripcion = New System.Windows.Forms.Label()
            Me.lblDescripción = New System.Windows.Forms.Label()
            Me.lblMostrarCodigo = New System.Windows.Forms.Label()
            Me.lblCodigo = New System.Windows.Forms.Label()
            Me.btnEliminar = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'txtCodigo
            '
            Me.txtCodigo.Location = New System.Drawing.Point(16, 193)
            Me.txtCodigo.Name = "txtCodigo"
            Me.txtCodigo.Size = New System.Drawing.Size(67, 20)
            Me.txtCodigo.TabIndex = 54
            '
            'lblNuevoDescripción
            '
            Me.lblNuevoDescripción.Location = New System.Drawing.Point(93, 193)
            Me.lblNuevoDescripción.Name = "lblNuevoDescripción"
            Me.lblNuevoDescripción.Size = New System.Drawing.Size(300, 20)
            Me.lblNuevoDescripción.TabIndex = 53
            '
            'lblMostrarDescripNuevo
            '
            Me.lblMostrarDescripNuevo.AutoSize = True
            Me.lblMostrarDescripNuevo.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarDescripNuevo.Location = New System.Drawing.Point(90, 167)
            Me.lblMostrarDescripNuevo.Name = "lblMostrarDescripNuevo"
            Me.lblMostrarDescripNuevo.Size = New System.Drawing.Size(71, 15)
            Me.lblMostrarDescripNuevo.TabIndex = 52
            Me.lblMostrarDescripNuevo.Text = "Descripción"
            '
            'lblCodigoNuevo
            '
            Me.lblCodigoNuevo.AutoSize = True
            Me.lblCodigoNuevo.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCodigoNuevo.Location = New System.Drawing.Point(17, 168)
            Me.lblCodigoNuevo.Name = "lblCodigoNuevo"
            Me.lblCodigoNuevo.Size = New System.Drawing.Size(45, 15)
            Me.lblCodigoNuevo.TabIndex = 51
            Me.lblCodigoNuevo.Text = "Código"
            '
            'lbl1
            '
            Me.lbl1.AutoSize = True
            Me.lbl1.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbl1.Location = New System.Drawing.Point(119, 131)
            Me.lbl1.Name = "lbl1"
            Me.lbl1.Size = New System.Drawing.Size(148, 23)
            Me.lbl1.TabIndex = 50
            Me.lbl1.Text = "Trasladar datos A"
            '
            'lblMostrarDescripcion
            '
            Me.lblMostrarDescripcion.Location = New System.Drawing.Point(93, 97)
            Me.lblMostrarDescripcion.Name = "lblMostrarDescripcion"
            Me.lblMostrarDescripcion.Size = New System.Drawing.Size(300, 15)
            Me.lblMostrarDescripcion.TabIndex = 49
            Me.lblMostrarDescripcion.Text = "Label1"
            '
            'lblDescripción
            '
            Me.lblDescripción.AutoSize = True
            Me.lblDescripción.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDescripción.Location = New System.Drawing.Point(90, 71)
            Me.lblDescripción.Name = "lblDescripción"
            Me.lblDescripción.Size = New System.Drawing.Size(71, 15)
            Me.lblDescripción.TabIndex = 48
            Me.lblDescripción.Text = "Descripción"
            '
            'lblMostrarCodigo
            '
            Me.lblMostrarCodigo.AutoSize = True
            Me.lblMostrarCodigo.Location = New System.Drawing.Point(17, 97)
            Me.lblMostrarCodigo.Name = "lblMostrarCodigo"
            Me.lblMostrarCodigo.Size = New System.Drawing.Size(39, 13)
            Me.lblMostrarCodigo.TabIndex = 47
            Me.lblMostrarCodigo.Text = "Label1"
            '
            'lblCodigo
            '
            Me.lblCodigo.AutoSize = True
            Me.lblCodigo.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCodigo.Location = New System.Drawing.Point(17, 72)
            Me.lblCodigo.Name = "lblCodigo"
            Me.lblCodigo.Size = New System.Drawing.Size(45, 15)
            Me.lblCodigo.TabIndex = 46
            Me.lblCodigo.Text = "Código"
            '
            'btnEliminar
            '
            Me.btnEliminar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliminar.Image = Global.Presentacion.My.Resources.Resources.Eliminar
            Me.btnEliminar.Location = New System.Drawing.Point(0, 0)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(71, 57)
            Me.btnEliminar.TabIndex = 56
            Me.btnEliminar.Text = "Eliminar"
            Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnEliminar.UseVisualStyleBackColor = True
            '
            'FrmEliminarCodigoRepetido
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(416, 227)
            Me.Controls.Add(Me.btnEliminar)
            Me.Controls.Add(Me.txtCodigo)
            Me.Controls.Add(Me.lblNuevoDescripción)
            Me.Controls.Add(Me.lblMostrarDescripNuevo)
            Me.Controls.Add(Me.lblCodigoNuevo)
            Me.Controls.Add(Me.lbl1)
            Me.Controls.Add(Me.lblMostrarDescripcion)
            Me.Controls.Add(Me.lblDescripción)
            Me.Controls.Add(Me.lblMostrarCodigo)
            Me.Controls.Add(Me.lblCodigo)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmEliminarCodigoRepetido"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "FrmEliminar_Codigo_Repetido"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents btnEliminar As System.Windows.Forms.Button
        Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
        Friend WithEvents lblNuevoDescripción As System.Windows.Forms.Label
        Friend WithEvents lblMostrarDescripNuevo As System.Windows.Forms.Label
        Friend WithEvents lblCodigoNuevo As System.Windows.Forms.Label
        Friend WithEvents lbl1 As System.Windows.Forms.Label
        Friend WithEvents lblMostrarDescripcion As System.Windows.Forms.Label
        Friend WithEvents lblDescripción As System.Windows.Forms.Label
        Friend WithEvents lblMostrarCodigo As System.Windows.Forms.Label
        Friend WithEvents lblCodigo As System.Windows.Forms.Label
    End Class
End Namespace