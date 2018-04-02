Namespace Interfaz.Proveedores
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmAnularDocPorPagar
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
            Me.lblNum_Factura = New System.Windows.Forms.Label()
            Me.lblMostrarNumFactura = New System.Windows.Forms.Label()
            Me.lblMostrarMonto = New System.Windows.Forms.Label()
            Me.lblMonto = New System.Windows.Forms.Label()
            Me.lblMotivo = New System.Windows.Forms.Label()
            Me.txtMotivo = New System.Windows.Forms.TextBox()
            Me.btnAnularFact = New System.Windows.Forms.Button()
            Me.txtId_DocPorPagar = New System.Windows.Forms.TextBox()
            Me.SuspendLayout()
            '
            'lblNum_Factura
            '
            Me.lblNum_Factura.AutoSize = True
            Me.lblNum_Factura.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNum_Factura.Location = New System.Drawing.Point(13, 78)
            Me.lblNum_Factura.Name = "lblNum_Factura"
            Me.lblNum_Factura.Size = New System.Drawing.Size(63, 15)
            Me.lblNum_Factura.TabIndex = 0
            Me.lblNum_Factura.Text = "N° Factura"
            '
            'lblMostrarNumFactura
            '
            Me.lblMostrarNumFactura.Location = New System.Drawing.Point(79, 79)
            Me.lblMostrarNumFactura.Name = "lblMostrarNumFactura"
            Me.lblMostrarNumFactura.Size = New System.Drawing.Size(163, 23)
            Me.lblMostrarNumFactura.TabIndex = 1
            Me.lblMostrarNumFactura.Text = "Label1"
            '
            'lblMostrarMonto
            '
            Me.lblMostrarMonto.Location = New System.Drawing.Point(79, 111)
            Me.lblMostrarMonto.Name = "lblMostrarMonto"
            Me.lblMostrarMonto.Size = New System.Drawing.Size(163, 23)
            Me.lblMostrarMonto.TabIndex = 3
            Me.lblMostrarMonto.Text = "Label1"
            '
            'lblMonto
            '
            Me.lblMonto.AutoSize = True
            Me.lblMonto.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMonto.Location = New System.Drawing.Point(15, 111)
            Me.lblMonto.Name = "lblMonto"
            Me.lblMonto.Size = New System.Drawing.Size(44, 15)
            Me.lblMonto.TabIndex = 2
            Me.lblMonto.Text = "Monto"
            '
            'lblMotivo
            '
            Me.lblMotivo.AutoSize = True
            Me.lblMotivo.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMotivo.Location = New System.Drawing.Point(15, 146)
            Me.lblMotivo.Name = "lblMotivo"
            Me.lblMotivo.Size = New System.Drawing.Size(46, 15)
            Me.lblMotivo.TabIndex = 4
            Me.lblMotivo.Text = "Motivo"
            '
            'txtMotivo
            '
            Me.txtMotivo.Location = New System.Drawing.Point(82, 146)
            Me.txtMotivo.MaxLength = 100
            Me.txtMotivo.Multiline = True
            Me.txtMotivo.Name = "txtMotivo"
            Me.txtMotivo.Size = New System.Drawing.Size(219, 47)
            Me.txtMotivo.TabIndex = 0
            '
            'btnAnularFact
            '
            Me.btnAnularFact.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnAnularFact.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAnularFact.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnAnularFact.Location = New System.Drawing.Point(0, 0)
            Me.btnAnularFact.Name = "btnAnularFact"
            Me.btnAnularFact.Size = New System.Drawing.Size(71, 57)
            Me.btnAnularFact.TabIndex = 46
            Me.btnAnularFact.Text = "Anular"
            Me.btnAnularFact.UseVisualStyleBackColor = True
            '
            'txtId_DocPorPagar
            '
            Me.txtId_DocPorPagar.Location = New System.Drawing.Point(93, 164)
            Me.txtId_DocPorPagar.Name = "txtId_DocPorPagar"
            Me.txtId_DocPorPagar.Size = New System.Drawing.Size(100, 20)
            Me.txtId_DocPorPagar.TabIndex = 47
            Me.txtId_DocPorPagar.Visible = False
            '
            'FrmAnularDocPorPagar
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(313, 205)
            Me.Controls.Add(Me.btnAnularFact)
            Me.Controls.Add(Me.txtMotivo)
            Me.Controls.Add(Me.lblMotivo)
            Me.Controls.Add(Me.lblMostrarMonto)
            Me.Controls.Add(Me.lblMonto)
            Me.Controls.Add(Me.lblMostrarNumFactura)
            Me.Controls.Add(Me.lblNum_Factura)
            Me.Controls.Add(Me.txtId_DocPorPagar)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmAnularDocPorPagar"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Anular DocPorPagar"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents lblNum_Factura As System.Windows.Forms.Label
        Friend WithEvents lblMostrarNumFactura As System.Windows.Forms.Label
        Friend WithEvents lblMostrarMonto As System.Windows.Forms.Label
        Friend WithEvents lblMonto As System.Windows.Forms.Label
        Friend WithEvents lblMotivo As System.Windows.Forms.Label
        Friend WithEvents txtMotivo As System.Windows.Forms.TextBox
        Friend WithEvents btnAnularFact As System.Windows.Forms.Button
        Friend WithEvents txtId_DocPorPagar As System.Windows.Forms.TextBox
    End Class
End Namespace