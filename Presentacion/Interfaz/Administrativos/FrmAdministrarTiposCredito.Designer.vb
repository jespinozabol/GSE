Namespace Interfaz.Administrativos
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmAdministrarTiposCredito
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
            Me.gbPreferencial = New System.Windows.Forms.GroupBox()
            Me.txtDiasCobroPre = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtLimiteExtraPre = New System.Windows.Forms.TextBox()
            Me.lblLimiteExtraPre = New System.Windows.Forms.Label()
            Me.txtDiasCreditoPre = New System.Windows.Forms.TextBox()
            Me.lblDiasPlazoPre = New System.Windows.Forms.Label()
            Me.lbl1 = New System.Windows.Forms.Label()
            Me.btnGuardar = New System.Windows.Forms.Button()
            Me.gbNormal = New System.Windows.Forms.GroupBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtDiasCobroNor = New System.Windows.Forms.TextBox()
            Me.txtLimiteExtraNor = New System.Windows.Forms.TextBox()
            Me.lblLimiteExtraNor = New System.Windows.Forms.Label()
            Me.txtDiasCreditoNor = New System.Windows.Forms.TextBox()
            Me.lblDiasPlazoNor = New System.Windows.Forms.Label()
            Me.gbPrueba = New System.Windows.Forms.GroupBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtDiasCobroPru = New System.Windows.Forms.TextBox()
            Me.txtLimiteExtraPru = New System.Windows.Forms.TextBox()
            Me.lblLimiteExtraPru = New System.Windows.Forms.Label()
            Me.txtDiasCreditoPru = New System.Windows.Forms.TextBox()
            Me.lblDiasPlazoPru = New System.Windows.Forms.Label()
            Me.errorTipos = New System.Windows.Forms.ErrorProvider(Me.components)
            Me.lblError1 = New System.Windows.Forms.Label()
            Me.lblerror2 = New System.Windows.Forms.Label()
            Me.lblerror3 = New System.Windows.Forms.Label()
            Me.gbPreferencial.SuspendLayout()
            Me.gbNormal.SuspendLayout()
            Me.gbPrueba.SuspendLayout()
            CType(Me.errorTipos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gbPreferencial
            '
            Me.gbPreferencial.Controls.Add(Me.txtDiasCobroPre)
            Me.gbPreferencial.Controls.Add(Me.Label1)
            Me.gbPreferencial.Controls.Add(Me.txtLimiteExtraPre)
            Me.gbPreferencial.Controls.Add(Me.lblLimiteExtraPre)
            Me.gbPreferencial.Controls.Add(Me.txtDiasCreditoPre)
            Me.gbPreferencial.Controls.Add(Me.lblDiasPlazoPre)
            Me.gbPreferencial.Location = New System.Drawing.Point(25, 73)
            Me.gbPreferencial.Name = "gbPreferencial"
            Me.gbPreferencial.Size = New System.Drawing.Size(475, 45)
            Me.gbPreferencial.TabIndex = 56
            Me.gbPreferencial.TabStop = False
            Me.gbPreferencial.Text = "Preferencial"
            '
            'txtDiasCobroPre
            '
            Me.txtDiasCobroPre.Location = New System.Drawing.Point(408, 17)
            Me.txtDiasCobroPre.Name = "txtDiasCobroPre"
            Me.txtDiasCobroPre.Size = New System.Drawing.Size(55, 20)
            Me.txtDiasCobroPre.TabIndex = 5
            Me.txtDiasCobroPre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(300, 20)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(105, 13)
            Me.Label1.TabIndex = 4
            Me.Label1.Text = "Días Plazo P/Cobro:"
            '
            'txtLimiteExtraPre
            '
            Me.txtLimiteExtraPre.Location = New System.Drawing.Point(247, 17)
            Me.txtLimiteExtraPre.Name = "txtLimiteExtraPre"
            Me.txtLimiteExtraPre.Size = New System.Drawing.Size(47, 20)
            Me.txtLimiteExtraPre.TabIndex = 3
            Me.txtLimiteExtraPre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblLimiteExtraPre
            '
            Me.lblLimiteExtraPre.AutoSize = True
            Me.lblLimiteExtraPre.Location = New System.Drawing.Point(202, 20)
            Me.lblLimiteExtraPre.Name = "lblLimiteExtraPre"
            Me.lblLimiteExtraPre.Size = New System.Drawing.Size(39, 13)
            Me.lblLimiteExtraPre.TabIndex = 2
            Me.lblLimiteExtraPre.Text = "Límite:"
            '
            'txtDiasCreditoPre
            '
            Me.txtDiasCreditoPre.Location = New System.Drawing.Point(139, 17)
            Me.txtDiasCreditoPre.Name = "txtDiasCreditoPre"
            Me.txtDiasCreditoPre.Size = New System.Drawing.Size(55, 20)
            Me.txtDiasCreditoPre.TabIndex = 1
            Me.txtDiasCreditoPre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblDiasPlazoPre
            '
            Me.lblDiasPlazoPre.AutoSize = True
            Me.lblDiasPlazoPre.Location = New System.Drawing.Point(7, 20)
            Me.lblDiasPlazoPre.Name = "lblDiasPlazoPre"
            Me.lblDiasPlazoPre.Size = New System.Drawing.Size(130, 13)
            Me.lblDiasPlazoPre.TabIndex = 0
            Me.lblDiasPlazoPre.Text = "Días Plazo P/Dar Crédito:"
            '
            'lbl1
            '
            Me.lbl1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbl1.Location = New System.Drawing.Point(253, 9)
            Me.lbl1.Name = "lbl1"
            Me.lbl1.Size = New System.Drawing.Size(149, 48)
            Me.lbl1.TabIndex = 53
            Me.lbl1.Text = "Administrar Tipos de Crédito"
            Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
            'gbNormal
            '
            Me.gbNormal.Controls.Add(Me.Label2)
            Me.gbNormal.Controls.Add(Me.txtDiasCobroNor)
            Me.gbNormal.Controls.Add(Me.txtLimiteExtraNor)
            Me.gbNormal.Controls.Add(Me.lblLimiteExtraNor)
            Me.gbNormal.Controls.Add(Me.txtDiasCreditoNor)
            Me.gbNormal.Controls.Add(Me.lblDiasPlazoNor)
            Me.gbNormal.Location = New System.Drawing.Point(25, 145)
            Me.gbNormal.Name = "gbNormal"
            Me.gbNormal.Size = New System.Drawing.Size(475, 45)
            Me.gbNormal.TabIndex = 57
            Me.gbNormal.TabStop = False
            Me.gbNormal.Text = "Normal"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(300, 20)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(105, 13)
            Me.Label2.TabIndex = 10
            Me.Label2.Text = "Días Plazo P/Cobro:"
            '
            'txtDiasCobroNor
            '
            Me.txtDiasCobroNor.Location = New System.Drawing.Point(408, 17)
            Me.txtDiasCobroNor.Name = "txtDiasCobroNor"
            Me.txtDiasCobroNor.Size = New System.Drawing.Size(55, 20)
            Me.txtDiasCobroNor.TabIndex = 7
            Me.txtDiasCobroNor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtLimiteExtraNor
            '
            Me.txtLimiteExtraNor.Location = New System.Drawing.Point(247, 17)
            Me.txtLimiteExtraNor.Name = "txtLimiteExtraNor"
            Me.txtLimiteExtraNor.Size = New System.Drawing.Size(47, 20)
            Me.txtLimiteExtraNor.TabIndex = 3
            Me.txtLimiteExtraNor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblLimiteExtraNor
            '
            Me.lblLimiteExtraNor.AutoSize = True
            Me.lblLimiteExtraNor.Location = New System.Drawing.Point(202, 20)
            Me.lblLimiteExtraNor.Name = "lblLimiteExtraNor"
            Me.lblLimiteExtraNor.Size = New System.Drawing.Size(39, 13)
            Me.lblLimiteExtraNor.TabIndex = 2
            Me.lblLimiteExtraNor.Text = "Límite:"
            '
            'txtDiasCreditoNor
            '
            Me.txtDiasCreditoNor.Location = New System.Drawing.Point(139, 17)
            Me.txtDiasCreditoNor.Name = "txtDiasCreditoNor"
            Me.txtDiasCreditoNor.Size = New System.Drawing.Size(55, 20)
            Me.txtDiasCreditoNor.TabIndex = 1
            Me.txtDiasCreditoNor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblDiasPlazoNor
            '
            Me.lblDiasPlazoNor.AutoSize = True
            Me.lblDiasPlazoNor.Location = New System.Drawing.Point(7, 20)
            Me.lblDiasPlazoNor.Name = "lblDiasPlazoNor"
            Me.lblDiasPlazoNor.Size = New System.Drawing.Size(130, 13)
            Me.lblDiasPlazoNor.TabIndex = 0
            Me.lblDiasPlazoNor.Text = "Días Plazo P/Dar Crédito:"
            '
            'gbPrueba
            '
            Me.gbPrueba.Controls.Add(Me.Label3)
            Me.gbPrueba.Controls.Add(Me.txtDiasCobroPru)
            Me.gbPrueba.Controls.Add(Me.txtLimiteExtraPru)
            Me.gbPrueba.Controls.Add(Me.lblLimiteExtraPru)
            Me.gbPrueba.Controls.Add(Me.txtDiasCreditoPru)
            Me.gbPrueba.Controls.Add(Me.lblDiasPlazoPru)
            Me.gbPrueba.Location = New System.Drawing.Point(25, 216)
            Me.gbPrueba.Name = "gbPrueba"
            Me.gbPrueba.Size = New System.Drawing.Size(475, 45)
            Me.gbPrueba.TabIndex = 57
            Me.gbPrueba.TabStop = False
            Me.gbPrueba.Text = "Prueba"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(300, 20)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(105, 13)
            Me.Label3.TabIndex = 11
            Me.Label3.Text = "Días Plazo P/Cobro:"
            '
            'txtDiasCobroPru
            '
            Me.txtDiasCobroPru.Location = New System.Drawing.Point(408, 17)
            Me.txtDiasCobroPru.Name = "txtDiasCobroPru"
            Me.txtDiasCobroPru.Size = New System.Drawing.Size(55, 20)
            Me.txtDiasCobroPru.TabIndex = 9
            Me.txtDiasCobroPru.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtLimiteExtraPru
            '
            Me.txtLimiteExtraPru.Location = New System.Drawing.Point(247, 17)
            Me.txtLimiteExtraPru.Name = "txtLimiteExtraPru"
            Me.txtLimiteExtraPru.Size = New System.Drawing.Size(47, 20)
            Me.txtLimiteExtraPru.TabIndex = 3
            Me.txtLimiteExtraPru.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblLimiteExtraPru
            '
            Me.lblLimiteExtraPru.AutoSize = True
            Me.lblLimiteExtraPru.Location = New System.Drawing.Point(202, 20)
            Me.lblLimiteExtraPru.Name = "lblLimiteExtraPru"
            Me.lblLimiteExtraPru.Size = New System.Drawing.Size(39, 13)
            Me.lblLimiteExtraPru.TabIndex = 2
            Me.lblLimiteExtraPru.Text = "Límite:"
            '
            'txtDiasCreditoPru
            '
            Me.txtDiasCreditoPru.Location = New System.Drawing.Point(139, 17)
            Me.txtDiasCreditoPru.Name = "txtDiasCreditoPru"
            Me.txtDiasCreditoPru.Size = New System.Drawing.Size(55, 20)
            Me.txtDiasCreditoPru.TabIndex = 1
            Me.txtDiasCreditoPru.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblDiasPlazoPru
            '
            Me.lblDiasPlazoPru.AutoSize = True
            Me.lblDiasPlazoPru.Location = New System.Drawing.Point(7, 20)
            Me.lblDiasPlazoPru.Name = "lblDiasPlazoPru"
            Me.lblDiasPlazoPru.Size = New System.Drawing.Size(130, 13)
            Me.lblDiasPlazoPru.TabIndex = 0
            Me.lblDiasPlazoPru.Text = "Días Plazo P/Dar Crédito:"
            '
            'errorTipos
            '
            Me.errorTipos.ContainerControl = Me
            '
            'lblError1
            '
            Me.lblError1.AutoSize = True
            Me.lblError1.Location = New System.Drawing.Point(203, 63)
            Me.lblError1.Name = "lblError1"
            Me.lblError1.Size = New System.Drawing.Size(0, 13)
            Me.lblError1.TabIndex = 58
            '
            'lblerror2
            '
            Me.lblerror2.AutoSize = True
            Me.lblerror2.Location = New System.Drawing.Point(254, 63)
            Me.lblerror2.Name = "lblerror2"
            Me.lblerror2.Size = New System.Drawing.Size(0, 13)
            Me.lblerror2.TabIndex = 59
            '
            'lblerror3
            '
            Me.lblerror3.AutoSize = True
            Me.lblerror3.Location = New System.Drawing.Point(446, 63)
            Me.lblerror3.Name = "lblerror3"
            Me.lblerror3.Size = New System.Drawing.Size(0, 13)
            Me.lblerror3.TabIndex = 60
            '
            'FrmAdministrarTiposCredito
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(514, 281)
            Me.Controls.Add(Me.lblerror2)
            Me.Controls.Add(Me.lblerror3)
            Me.Controls.Add(Me.gbPrueba)
            Me.Controls.Add(Me.lblError1)
            Me.Controls.Add(Me.gbNormal)
            Me.Controls.Add(Me.gbPreferencial)
            Me.Controls.Add(Me.btnGuardar)
            Me.Controls.Add(Me.lbl1)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmAdministrarTiposCredito"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Administrar TiposCredito"
            Me.gbPreferencial.ResumeLayout(False)
            Me.gbPreferencial.PerformLayout()
            Me.gbNormal.ResumeLayout(False)
            Me.gbNormal.PerformLayout()
            Me.gbPrueba.ResumeLayout(False)
            Me.gbPrueba.PerformLayout()
            CType(Me.errorTipos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents gbPreferencial As System.Windows.Forms.GroupBox
        Friend WithEvents txtDiasCreditoPre As System.Windows.Forms.TextBox
        Friend WithEvents lblDiasPlazoPre As System.Windows.Forms.Label
        Friend WithEvents btnGuardar As System.Windows.Forms.Button
        Friend WithEvents lbl1 As System.Windows.Forms.Label
        Friend WithEvents txtLimiteExtraPre As System.Windows.Forms.TextBox
        Friend WithEvents lblLimiteExtraPre As System.Windows.Forms.Label
        Friend WithEvents gbNormal As System.Windows.Forms.GroupBox
        Friend WithEvents txtLimiteExtraNor As System.Windows.Forms.TextBox
        Friend WithEvents lblLimiteExtraNor As System.Windows.Forms.Label
        Friend WithEvents txtDiasCreditoNor As System.Windows.Forms.TextBox
        Friend WithEvents lblDiasPlazoNor As System.Windows.Forms.Label
        Friend WithEvents gbPrueba As System.Windows.Forms.GroupBox
        Friend WithEvents txtLimiteExtraPru As System.Windows.Forms.TextBox
        Friend WithEvents lblLimiteExtraPru As System.Windows.Forms.Label
        Friend WithEvents txtDiasCreditoPru As System.Windows.Forms.TextBox
        Friend WithEvents lblDiasPlazoPru As System.Windows.Forms.Label
        Friend WithEvents errorTipos As System.Windows.Forms.ErrorProvider
        Friend WithEvents lblerror2 As System.Windows.Forms.Label
        Friend WithEvents lblError1 As System.Windows.Forms.Label
        Friend WithEvents txtDiasCobroPre As System.Windows.Forms.TextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtDiasCobroNor As System.Windows.Forms.TextBox
        Friend WithEvents txtDiasCobroPru As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents lblerror3 As System.Windows.Forms.Label
    End Class
End Namespace