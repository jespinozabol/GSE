Namespace Interfaz.Facturas
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmReferenciaAFactura
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
            Me.btnAsigar = New System.Windows.Forms.Button()
            Me.lblNum_Factura = New System.Windows.Forms.Label()
            Me.lblNombre = New System.Windows.Forms.Label()
            Me.txtNumFactura = New System.Windows.Forms.TextBox()
            Me.txtNombre = New System.Windows.Forms.TextBox()
            Me.txtNombre_Referencia = New System.Windows.Forms.TextBox()
            Me.txtId_Referencia = New System.Windows.Forms.TextBox()
            Me.lblNombre_Referencia = New System.Windows.Forms.Label()
            Me.lblId_Referencia = New System.Windows.Forms.Label()
            Me.SuspendLayout()
            '
            'btnAsigar
            '
            Me.btnAsigar.Image = Global.Presentacion.My.Resources.Resources.aceptar
            Me.btnAsigar.Location = New System.Drawing.Point(0, 0)
            Me.btnAsigar.Name = "btnAsigar"
            Me.btnAsigar.Size = New System.Drawing.Size(65, 57)
            Me.btnAsigar.TabIndex = 15
            Me.btnAsigar.Text = "Asignar"
            Me.btnAsigar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnAsigar.UseVisualStyleBackColor = True
            '
            'lblNum_Factura
            '
            Me.lblNum_Factura.AutoSize = True
            Me.lblNum_Factura.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNum_Factura.Location = New System.Drawing.Point(13, 64)
            Me.lblNum_Factura.Name = "lblNum_Factura"
            Me.lblNum_Factura.Size = New System.Drawing.Size(63, 15)
            Me.lblNum_Factura.TabIndex = 16
            Me.lblNum_Factura.Text = "N° Factura"
            '
            'lblNombre
            '
            Me.lblNombre.AutoSize = True
            Me.lblNombre.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombre.Location = New System.Drawing.Point(78, 64)
            Me.lblNombre.Name = "lblNombre"
            Me.lblNombre.Size = New System.Drawing.Size(53, 15)
            Me.lblNombre.TabIndex = 17
            Me.lblNombre.Text = "Nombre"
            '
            'txtNumFactura
            '
            Me.txtNumFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumFactura.Location = New System.Drawing.Point(16, 80)
            Me.txtNumFactura.MaxLength = 10
            Me.txtNumFactura.Name = "txtNumFactura"
            Me.txtNumFactura.ReadOnly = True
            Me.txtNumFactura.Size = New System.Drawing.Size(55, 21)
            Me.txtNumFactura.TabIndex = 1
            '
            'txtNombre
            '
            Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombre.Location = New System.Drawing.Point(77, 80)
            Me.txtNombre.Name = "txtNombre"
            Me.txtNombre.ReadOnly = True
            Me.txtNombre.Size = New System.Drawing.Size(313, 21)
            Me.txtNombre.TabIndex = 50
            '
            'txtNombre_Referencia
            '
            Me.txtNombre_Referencia.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtNombre_Referencia.Enabled = False
            Me.txtNombre_Referencia.Location = New System.Drawing.Point(77, 123)
            Me.txtNombre_Referencia.Name = "txtNombre_Referencia"
            Me.txtNombre_Referencia.Size = New System.Drawing.Size(313, 20)
            Me.txtNombre_Referencia.TabIndex = 168
            '
            'txtId_Referencia
            '
            Me.txtId_Referencia.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtId_Referencia.Location = New System.Drawing.Point(16, 123)
            Me.txtId_Referencia.Name = "txtId_Referencia"
            Me.txtId_Referencia.Size = New System.Drawing.Size(55, 20)
            Me.txtId_Referencia.TabIndex = 0
            '
            'lblNombre_Referencia
            '
            Me.lblNombre_Referencia.AutoSize = True
            Me.lblNombre_Referencia.BackColor = System.Drawing.Color.Transparent
            Me.lblNombre_Referencia.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblNombre_Referencia.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombre_Referencia.Location = New System.Drawing.Point(78, 107)
            Me.lblNombre_Referencia.Name = "lblNombre_Referencia"
            Me.lblNombre_Referencia.Size = New System.Drawing.Size(53, 15)
            Me.lblNombre_Referencia.TabIndex = 167
            Me.lblNombre_Referencia.Text = "Nombre"
            Me.lblNombre_Referencia.Visible = False
            '
            'lblId_Referencia
            '
            Me.lblId_Referencia.AutoSize = True
            Me.lblId_Referencia.BackColor = System.Drawing.Color.Transparent
            Me.lblId_Referencia.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblId_Referencia.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblId_Referencia.Location = New System.Drawing.Point(15, 107)
            Me.lblId_Referencia.Name = "lblId_Referencia"
            Me.lblId_Referencia.Size = New System.Drawing.Size(40, 15)
            Me.lblId_Referencia.TabIndex = 165
            Me.lblId_Referencia.Text = "Id Ref"
            Me.lblId_Referencia.Visible = False
            '
            'FrmReferenciaAFactura
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(402, 161)
            Me.Controls.Add(Me.txtNombre_Referencia)
            Me.Controls.Add(Me.txtId_Referencia)
            Me.Controls.Add(Me.lblNombre_Referencia)
            Me.Controls.Add(Me.lblId_Referencia)
            Me.Controls.Add(Me.txtNumFactura)
            Me.Controls.Add(Me.txtNombre)
            Me.Controls.Add(Me.lblNombre)
            Me.Controls.Add(Me.lblNum_Factura)
            Me.Controls.Add(Me.btnAsigar)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmReferenciaAFactura"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "FrmReferencia_a_Factura"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents btnAsigar As System.Windows.Forms.Button
        Friend WithEvents lblNum_Factura As System.Windows.Forms.Label
        Friend WithEvents lblNombre As System.Windows.Forms.Label
        Friend WithEvents txtNumFactura As System.Windows.Forms.TextBox
        Friend WithEvents txtNombre As System.Windows.Forms.TextBox
        Friend WithEvents txtNombre_Referencia As System.Windows.Forms.TextBox
        Friend WithEvents txtId_Referencia As System.Windows.Forms.TextBox
        Friend WithEvents lblNombre_Referencia As System.Windows.Forms.Label
        Friend WithEvents lblId_Referencia As System.Windows.Forms.Label
    End Class
End Namespace