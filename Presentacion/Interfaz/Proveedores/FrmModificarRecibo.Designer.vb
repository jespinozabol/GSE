Namespace Interfaz.Proveedores
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmModificarRecibo
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
            Me.lblFecha = New System.Windows.Forms.Label()
            Me.txtFecha = New System.Windows.Forms.TextBox()
            Me.txtNumRecibo = New System.Windows.Forms.TextBox()
            Me.lblRecibo = New System.Windows.Forms.Label()
            Me.btnGuardar = New System.Windows.Forms.Button()
            Me.lblEmpresa = New System.Windows.Forms.Label()
            Me.lblNomreEmpresa = New System.Windows.Forms.Label()
            Me.lblMontoRecibo = New System.Windows.Forms.Label()
            Me.lblMonto = New System.Windows.Forms.Label()
            Me.chkHoy = New System.Windows.Forms.CheckBox()
            Me.txtNum_Recibo = New System.Windows.Forms.TextBox()
            Me.txtObservaciones = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.SuspendLayout()
            '
            'lblFecha
            '
            Me.lblFecha.AutoSize = True
            Me.lblFecha.Location = New System.Drawing.Point(-2, 124)
            Me.lblFecha.Name = "lblFecha"
            Me.lblFecha.Size = New System.Drawing.Size(74, 13)
            Me.lblFecha.TabIndex = 0
            Me.lblFecha.Text = "Fecha Recibo"
            '
            'txtFecha
            '
            Me.txtFecha.Location = New System.Drawing.Point(74, 121)
            Me.txtFecha.MaxLength = 10
            Me.txtFecha.Name = "txtFecha"
            Me.txtFecha.Size = New System.Drawing.Size(100, 20)
            Me.txtFecha.TabIndex = 0
            '
            'txtNumRecibo
            '
            Me.txtNumRecibo.Location = New System.Drawing.Point(74, 149)
            Me.txtNumRecibo.MaxLength = 20
            Me.txtNumRecibo.Name = "txtNumRecibo"
            Me.txtNumRecibo.Size = New System.Drawing.Size(162, 20)
            Me.txtNumRecibo.TabIndex = 3
            '
            'lblRecibo
            '
            Me.lblRecibo.AutoSize = True
            Me.lblRecibo.Location = New System.Drawing.Point(18, 153)
            Me.lblRecibo.Name = "lblRecibo"
            Me.lblRecibo.Size = New System.Drawing.Size(51, 13)
            Me.lblRecibo.TabIndex = 2
            Me.lblRecibo.Text = "# Recibo"
            '
            'btnGuardar
            '
            Me.btnGuardar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = Global.Presentacion.My.Resources.Resources.Guardar
            Me.btnGuardar.Location = New System.Drawing.Point(-1, 0)
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(65, 57)
            Me.btnGuardar.TabIndex = 210
            Me.btnGuardar.Text = "Guardar"
            Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnGuardar.UseVisualStyleBackColor = True
            '
            'lblEmpresa
            '
            Me.lblEmpresa.AutoSize = True
            Me.lblEmpresa.Location = New System.Drawing.Point(20, 73)
            Me.lblEmpresa.Name = "lblEmpresa"
            Me.lblEmpresa.Size = New System.Drawing.Size(48, 13)
            Me.lblEmpresa.TabIndex = 211
            Me.lblEmpresa.Text = "Empresa"
            '
            'lblNomreEmpresa
            '
            Me.lblNomreEmpresa.Location = New System.Drawing.Point(74, 73)
            Me.lblNomreEmpresa.Name = "lblNomreEmpresa"
            Me.lblNomreEmpresa.Size = New System.Drawing.Size(273, 13)
            Me.lblNomreEmpresa.TabIndex = 212
            '
            'lblMontoRecibo
            '
            Me.lblMontoRecibo.Location = New System.Drawing.Point(71, 98)
            Me.lblMontoRecibo.Name = "lblMontoRecibo"
            Me.lblMontoRecibo.Size = New System.Drawing.Size(101, 13)
            Me.lblMontoRecibo.TabIndex = 214
            '
            'lblMonto
            '
            Me.lblMonto.AutoSize = True
            Me.lblMonto.Location = New System.Drawing.Point(31, 98)
            Me.lblMonto.Name = "lblMonto"
            Me.lblMonto.Size = New System.Drawing.Size(37, 13)
            Me.lblMonto.TabIndex = 213
            Me.lblMonto.Text = "Monto"
            '
            'chkHoy
            '
            Me.chkHoy.AutoSize = True
            Me.chkHoy.Location = New System.Drawing.Point(180, 123)
            Me.chkHoy.Name = "chkHoy"
            Me.chkHoy.Size = New System.Drawing.Size(45, 17)
            Me.chkHoy.TabIndex = 215
            Me.chkHoy.Text = "Hoy"
            Me.chkHoy.UseVisualStyleBackColor = True
            '
            'txtNum_Recibo
            '
            Me.txtNum_Recibo.Location = New System.Drawing.Point(12, 12)
            Me.txtNum_Recibo.MaxLength = 10
            Me.txtNum_Recibo.Name = "txtNum_Recibo"
            Me.txtNum_Recibo.Size = New System.Drawing.Size(51, 20)
            Me.txtNum_Recibo.TabIndex = 216
            Me.txtNum_Recibo.Visible = False
            '
            'txtObservaciones
            '
            Me.txtObservaciones.Location = New System.Drawing.Point(74, 175)
            Me.txtObservaciones.MaxLength = 250
            Me.txtObservaciones.Multiline = True
            Me.txtObservaciones.Name = "txtObservaciones"
            Me.txtObservaciones.Size = New System.Drawing.Size(275, 69)
            Me.txtObservaciones.TabIndex = 218
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(27, 179)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(40, 13)
            Me.Label1.TabIndex = 217
            Me.Label1.Text = "Detalle"
            '
            'FrmModificarRecibo
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(355, 256)
            Me.Controls.Add(Me.txtObservaciones)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.chkHoy)
            Me.Controls.Add(Me.lblMontoRecibo)
            Me.Controls.Add(Me.lblMonto)
            Me.Controls.Add(Me.lblNomreEmpresa)
            Me.Controls.Add(Me.lblEmpresa)
            Me.Controls.Add(Me.txtNumRecibo)
            Me.Controls.Add(Me.lblRecibo)
            Me.Controls.Add(Me.txtFecha)
            Me.Controls.Add(Me.lblFecha)
            Me.Controls.Add(Me.btnGuardar)
            Me.Controls.Add(Me.txtNum_Recibo)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmModificarRecibo"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Modificar Recibo"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents lblFecha As System.Windows.Forms.Label
        Friend WithEvents txtFecha As System.Windows.Forms.TextBox
        Friend WithEvents txtNumRecibo As System.Windows.Forms.TextBox
        Friend WithEvents lblRecibo As System.Windows.Forms.Label
        Friend WithEvents btnGuardar As System.Windows.Forms.Button
        Friend WithEvents lblEmpresa As System.Windows.Forms.Label
        Friend WithEvents lblNomreEmpresa As System.Windows.Forms.Label
        Friend WithEvents lblMontoRecibo As System.Windows.Forms.Label
        Friend WithEvents lblMonto As System.Windows.Forms.Label
        Friend WithEvents chkHoy As System.Windows.Forms.CheckBox
        Friend WithEvents txtNum_Recibo As System.Windows.Forms.TextBox
        Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
    End Class
End Namespace