Namespace Interfaz.Catalogo
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmTrasladarCodigo
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTrasladarCodigo))
            Me.lblCodigo = New System.Windows.Forms.Label()
            Me.lblMostrarCodigo = New System.Windows.Forms.Label()
            Me.lblDescripción = New System.Windows.Forms.Label()
            Me.lblMostrarDescripcion = New System.Windows.Forms.Label()
            Me.lbl1 = New System.Windows.Forms.Label()
            Me.lblNuevoDescripción = New System.Windows.Forms.Label()
            Me.lblMostrarDescripNuevo = New System.Windows.Forms.Label()
            Me.lblCodigoNuevo = New System.Windows.Forms.Label()
            Me.txtCodigo = New System.Windows.Forms.TextBox()
            Me.btnTrasladar = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'lblCodigo
            '
            Me.lblCodigo.AutoSize = True
            Me.lblCodigo.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCodigo.Location = New System.Drawing.Point(15, 71)
            Me.lblCodigo.Name = "lblCodigo"
            Me.lblCodigo.Size = New System.Drawing.Size(45, 15)
            Me.lblCodigo.TabIndex = 0
            Me.lblCodigo.Text = "Código"
            '
            'lblMostrarCodigo
            '
            Me.lblMostrarCodigo.AutoSize = True
            Me.lblMostrarCodigo.Location = New System.Drawing.Point(15, 96)
            Me.lblMostrarCodigo.Name = "lblMostrarCodigo"
            Me.lblMostrarCodigo.Size = New System.Drawing.Size(39, 13)
            Me.lblMostrarCodigo.TabIndex = 1
            Me.lblMostrarCodigo.Text = "Label1"
            '
            'lblDescripción
            '
            Me.lblDescripción.AutoSize = True
            Me.lblDescripción.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDescripción.Location = New System.Drawing.Point(88, 70)
            Me.lblDescripción.Name = "lblDescripción"
            Me.lblDescripción.Size = New System.Drawing.Size(71, 15)
            Me.lblDescripción.TabIndex = 2
            Me.lblDescripción.Text = "Descripción"
            '
            'lblMostrarDescripcion
            '
            Me.lblMostrarDescripcion.Location = New System.Drawing.Point(91, 96)
            Me.lblMostrarDescripcion.Name = "lblMostrarDescripcion"
            Me.lblMostrarDescripcion.Size = New System.Drawing.Size(300, 15)
            Me.lblMostrarDescripcion.TabIndex = 3
            Me.lblMostrarDescripcion.Text = "Label1"
            '
            'lbl1
            '
            Me.lbl1.AutoSize = True
            Me.lbl1.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbl1.Location = New System.Drawing.Point(158, 130)
            Me.lbl1.Name = "lbl1"
            Me.lbl1.Size = New System.Drawing.Size(99, 23)
            Me.lbl1.TabIndex = 4
            Me.lbl1.Text = "Trasladar A"
            '
            'lblNuevoDescripción
            '
            Me.lblNuevoDescripción.Location = New System.Drawing.Point(91, 192)
            Me.lblNuevoDescripción.Name = "lblNuevoDescripción"
            Me.lblNuevoDescripción.Size = New System.Drawing.Size(300, 20)
            Me.lblNuevoDescripción.TabIndex = 8
            '
            'lblMostrarDescripNuevo
            '
            Me.lblMostrarDescripNuevo.AutoSize = True
            Me.lblMostrarDescripNuevo.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarDescripNuevo.Location = New System.Drawing.Point(88, 166)
            Me.lblMostrarDescripNuevo.Name = "lblMostrarDescripNuevo"
            Me.lblMostrarDescripNuevo.Size = New System.Drawing.Size(71, 15)
            Me.lblMostrarDescripNuevo.TabIndex = 7
            Me.lblMostrarDescripNuevo.Text = "Descripción"
            '
            'lblCodigoNuevo
            '
            Me.lblCodigoNuevo.AutoSize = True
            Me.lblCodigoNuevo.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCodigoNuevo.Location = New System.Drawing.Point(15, 167)
            Me.lblCodigoNuevo.Name = "lblCodigoNuevo"
            Me.lblCodigoNuevo.Size = New System.Drawing.Size(45, 15)
            Me.lblCodigoNuevo.TabIndex = 5
            Me.lblCodigoNuevo.Text = "Código"
            '
            'txtCodigo
            '
            Me.txtCodigo.Location = New System.Drawing.Point(14, 192)
            Me.txtCodigo.Name = "txtCodigo"
            Me.txtCodigo.Size = New System.Drawing.Size(67, 20)
            Me.txtCodigo.TabIndex = 9
            '
            'btnTrasladar
            '
            Me.btnTrasladar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnTrasladar.Image = CType(resources.GetObject("btnTrasladar.Image"), System.Drawing.Image)
            Me.btnTrasladar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnTrasladar.Location = New System.Drawing.Point(0, 0)
            Me.btnTrasladar.Name = "btnTrasladar"
            Me.btnTrasladar.Size = New System.Drawing.Size(71, 57)
            Me.btnTrasladar.TabIndex = 45
            Me.btnTrasladar.Text = "Trasladar"
            Me.btnTrasladar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnTrasladar.UseVisualStyleBackColor = True
            '
            'FrmTrasladarCodigo
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(406, 226)
            Me.Controls.Add(Me.btnTrasladar)
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
            Me.Name = "FrmTrasladarCodigo"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "FrmTrasladarCódigo"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents lblCodigo As System.Windows.Forms.Label
        Friend WithEvents lblMostrarCodigo As System.Windows.Forms.Label
        Friend WithEvents lblDescripción As System.Windows.Forms.Label
        Friend WithEvents lblMostrarDescripcion As System.Windows.Forms.Label
        Friend WithEvents lbl1 As System.Windows.Forms.Label
        Friend WithEvents lblNuevoDescripción As System.Windows.Forms.Label
        Friend WithEvents lblMostrarDescripNuevo As System.Windows.Forms.Label
        Friend WithEvents lblCodigoNuevo As System.Windows.Forms.Label
        Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
        Friend WithEvents btnTrasladar As System.Windows.Forms.Button
    End Class
End Namespace