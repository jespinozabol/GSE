Namespace Interfaz.Administrativos
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmAdministrarImpresoras
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
            Me.gbTercio = New System.Windows.Forms.GroupBox()
            Me.txtPC_Tercio_Oficio = New System.Windows.Forms.TextBox()
            Me.lblPC_Tercio_Oficio = New System.Windows.Forms.Label()
            Me.txtTercioOficio = New System.Windows.Forms.TextBox()
            Me.lblCons_NC = New System.Windows.Forms.Label()
            Me.gbMedio = New System.Windows.Forms.GroupBox()
            Me.txtPC_Medio_Oficio = New System.Windows.Forms.TextBox()
            Me.lblPC_Medio_Oficio = New System.Windows.Forms.Label()
            Me.txtMedioOficio = New System.Windows.Forms.TextBox()
            Me.lblCons_Abonos = New System.Windows.Forms.Label()
            Me.gbFacturas = New System.Windows.Forms.GroupBox()
            Me.txtPC_Factura = New System.Windows.Forms.TextBox()
            Me.lblPC_Factura = New System.Windows.Forms.Label()
            Me.txtFacturas = New System.Windows.Forms.TextBox()
            Me.lblCons_Factura = New System.Windows.Forms.Label()
            Me.btnGuardar = New System.Windows.Forms.Button()
            Me.lbl1 = New System.Windows.Forms.Label()
            Me.gbTercio.SuspendLayout()
            Me.gbMedio.SuspendLayout()
            Me.gbFacturas.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbTercio
            '
            Me.gbTercio.Controls.Add(Me.txtPC_Tercio_Oficio)
            Me.gbTercio.Controls.Add(Me.lblPC_Tercio_Oficio)
            Me.gbTercio.Controls.Add(Me.txtTercioOficio)
            Me.gbTercio.Controls.Add(Me.lblCons_NC)
            Me.gbTercio.Location = New System.Drawing.Point(12, 175)
            Me.gbTercio.Name = "gbTercio"
            Me.gbTercio.Size = New System.Drawing.Size(357, 45)
            Me.gbTercio.TabIndex = 58
            Me.gbTercio.TabStop = False
            Me.gbTercio.Text = "Tercio Oficio"
            '
            'txtPC_Tercio_Oficio
            '
            Me.txtPC_Tercio_Oficio.Location = New System.Drawing.Point(31, 18)
            Me.txtPC_Tercio_Oficio.Name = "txtPC_Tercio_Oficio"
            Me.txtPC_Tercio_Oficio.Size = New System.Drawing.Size(100, 20)
            Me.txtPC_Tercio_Oficio.TabIndex = 7
            '
            'lblPC_Tercio_Oficio
            '
            Me.lblPC_Tercio_Oficio.AutoSize = True
            Me.lblPC_Tercio_Oficio.Location = New System.Drawing.Point(6, 21)
            Me.lblPC_Tercio_Oficio.Name = "lblPC_Tercio_Oficio"
            Me.lblPC_Tercio_Oficio.Size = New System.Drawing.Size(24, 13)
            Me.lblPC_Tercio_Oficio.TabIndex = 6
            Me.lblPC_Tercio_Oficio.Text = "PC:"
            '
            'txtTercioOficio
            '
            Me.txtTercioOficio.Location = New System.Drawing.Point(188, 18)
            Me.txtTercioOficio.Name = "txtTercioOficio"
            Me.txtTercioOficio.Size = New System.Drawing.Size(163, 20)
            Me.txtTercioOficio.TabIndex = 1
            '
            'lblCons_NC
            '
            Me.lblCons_NC.AutoSize = True
            Me.lblCons_NC.Location = New System.Drawing.Point(137, 21)
            Me.lblCons_NC.Name = "lblCons_NC"
            Me.lblCons_NC.Size = New System.Drawing.Size(47, 13)
            Me.lblCons_NC.TabIndex = 0
            Me.lblCons_NC.Text = "Nombre:"
            '
            'gbMedio
            '
            Me.gbMedio.Controls.Add(Me.txtPC_Medio_Oficio)
            Me.gbMedio.Controls.Add(Me.lblPC_Medio_Oficio)
            Me.gbMedio.Controls.Add(Me.txtMedioOficio)
            Me.gbMedio.Controls.Add(Me.lblCons_Abonos)
            Me.gbMedio.Location = New System.Drawing.Point(12, 124)
            Me.gbMedio.Name = "gbMedio"
            Me.gbMedio.Size = New System.Drawing.Size(357, 45)
            Me.gbMedio.TabIndex = 57
            Me.gbMedio.TabStop = False
            Me.gbMedio.Text = "Medio Oficio"
            '
            'txtPC_Medio_Oficio
            '
            Me.txtPC_Medio_Oficio.Location = New System.Drawing.Point(32, 17)
            Me.txtPC_Medio_Oficio.Name = "txtPC_Medio_Oficio"
            Me.txtPC_Medio_Oficio.Size = New System.Drawing.Size(100, 20)
            Me.txtPC_Medio_Oficio.TabIndex = 5
            '
            'lblPC_Medio_Oficio
            '
            Me.lblPC_Medio_Oficio.AutoSize = True
            Me.lblPC_Medio_Oficio.Location = New System.Drawing.Point(8, 20)
            Me.lblPC_Medio_Oficio.Name = "lblPC_Medio_Oficio"
            Me.lblPC_Medio_Oficio.Size = New System.Drawing.Size(24, 13)
            Me.lblPC_Medio_Oficio.TabIndex = 4
            Me.lblPC_Medio_Oficio.Text = "PC:"
            '
            'txtMedioOficio
            '
            Me.txtMedioOficio.Location = New System.Drawing.Point(188, 17)
            Me.txtMedioOficio.Name = "txtMedioOficio"
            Me.txtMedioOficio.Size = New System.Drawing.Size(163, 20)
            Me.txtMedioOficio.TabIndex = 1
            '
            'lblCons_Abonos
            '
            Me.lblCons_Abonos.AutoSize = True
            Me.lblCons_Abonos.Location = New System.Drawing.Point(137, 21)
            Me.lblCons_Abonos.Name = "lblCons_Abonos"
            Me.lblCons_Abonos.Size = New System.Drawing.Size(47, 13)
            Me.lblCons_Abonos.TabIndex = 0
            Me.lblCons_Abonos.Text = "Nombre:"
            '
            'gbFacturas
            '
            Me.gbFacturas.Controls.Add(Me.txtPC_Factura)
            Me.gbFacturas.Controls.Add(Me.lblPC_Factura)
            Me.gbFacturas.Controls.Add(Me.txtFacturas)
            Me.gbFacturas.Controls.Add(Me.lblCons_Factura)
            Me.gbFacturas.Location = New System.Drawing.Point(12, 73)
            Me.gbFacturas.Name = "gbFacturas"
            Me.gbFacturas.Size = New System.Drawing.Size(357, 45)
            Me.gbFacturas.TabIndex = 56
            Me.gbFacturas.TabStop = False
            Me.gbFacturas.Text = "Facturas"
            '
            'txtPC_Factura
            '
            Me.txtPC_Factura.Location = New System.Drawing.Point(32, 19)
            Me.txtPC_Factura.Name = "txtPC_Factura"
            Me.txtPC_Factura.Size = New System.Drawing.Size(100, 20)
            Me.txtPC_Factura.TabIndex = 3
            '
            'lblPC_Factura
            '
            Me.lblPC_Factura.AutoSize = True
            Me.lblPC_Factura.Location = New System.Drawing.Point(8, 22)
            Me.lblPC_Factura.Name = "lblPC_Factura"
            Me.lblPC_Factura.Size = New System.Drawing.Size(24, 13)
            Me.lblPC_Factura.TabIndex = 2
            Me.lblPC_Factura.Text = "PC:"
            '
            'txtFacturas
            '
            Me.txtFacturas.Location = New System.Drawing.Point(188, 19)
            Me.txtFacturas.Name = "txtFacturas"
            Me.txtFacturas.Size = New System.Drawing.Size(163, 20)
            Me.txtFacturas.TabIndex = 1
            '
            'lblCons_Factura
            '
            Me.lblCons_Factura.AutoSize = True
            Me.lblCons_Factura.Location = New System.Drawing.Point(135, 22)
            Me.lblCons_Factura.Name = "lblCons_Factura"
            Me.lblCons_Factura.Size = New System.Drawing.Size(47, 13)
            Me.lblCons_Factura.TabIndex = 0
            Me.lblCons_Factura.Text = "Nombre:"
            '
            'btnGuardar
            '
            Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnGuardar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = Global.Presentacion.My.Resources.Resources.Guardar
            Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnGuardar.Location = New System.Drawing.Point(0, 0)
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(71, 57)
            Me.btnGuardar.TabIndex = 55
            Me.btnGuardar.Text = "Guardar"
            Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnGuardar.UseVisualStyleBackColor = True
            '
            'lbl1
            '
            Me.lbl1.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbl1.Location = New System.Drawing.Point(226, 10)
            Me.lbl1.Name = "lbl1"
            Me.lbl1.Size = New System.Drawing.Size(118, 48)
            Me.lbl1.TabIndex = 53
            Me.lbl1.Text = "Administrar Impresoras"
            Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'FrmAdministrarImpresoras
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(381, 228)
            Me.Controls.Add(Me.gbTercio)
            Me.Controls.Add(Me.gbMedio)
            Me.Controls.Add(Me.gbFacturas)
            Me.Controls.Add(Me.btnGuardar)
            Me.Controls.Add(Me.lbl1)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmAdministrarImpresoras"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "FrmAdministrar_Impresoras"
            Me.gbTercio.ResumeLayout(False)
            Me.gbTercio.PerformLayout()
            Me.gbMedio.ResumeLayout(False)
            Me.gbMedio.PerformLayout()
            Me.gbFacturas.ResumeLayout(False)
            Me.gbFacturas.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents gbTercio As System.Windows.Forms.GroupBox
        Friend WithEvents txtTercioOficio As System.Windows.Forms.TextBox
        Friend WithEvents lblCons_NC As System.Windows.Forms.Label
        Friend WithEvents gbMedio As System.Windows.Forms.GroupBox
        Friend WithEvents txtMedioOficio As System.Windows.Forms.TextBox
        Friend WithEvents lblCons_Abonos As System.Windows.Forms.Label
        Friend WithEvents gbFacturas As System.Windows.Forms.GroupBox
        Friend WithEvents txtFacturas As System.Windows.Forms.TextBox
        Friend WithEvents lblCons_Factura As System.Windows.Forms.Label
        Friend WithEvents btnGuardar As System.Windows.Forms.Button
        Friend WithEvents lbl1 As System.Windows.Forms.Label
        Friend WithEvents txtPC_Tercio_Oficio As System.Windows.Forms.TextBox
        Friend WithEvents lblPC_Tercio_Oficio As System.Windows.Forms.Label
        Friend WithEvents txtPC_Medio_Oficio As System.Windows.Forms.TextBox
        Friend WithEvents lblPC_Medio_Oficio As System.Windows.Forms.Label
        Friend WithEvents txtPC_Factura As System.Windows.Forms.TextBox
        Friend WithEvents lblPC_Factura As System.Windows.Forms.Label
    End Class
End Namespace