Namespace Interfaz.Listados
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmExistenciasListado
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
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblExistencias = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.lblCodigo = New System.Windows.Forms.Label()
            Me.lblDescripcion = New System.Windows.Forms.Label()
            Me.Resumen = New System.Windows.Forms.GroupBox()
            Me.btnCancelar = New System.Windows.Forms.Button()
            Me.btnAceptar = New System.Windows.Forms.Button()
            Me.lblTotal = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.lblCantidad = New System.Windows.Forms.Label()
            Me.lblTipo = New System.Windows.Forms.Label()
            Me.btnRestar = New System.Windows.Forms.Button()
            Me.btnSumar = New System.Windows.Forms.Button()
            Me.Resumen.SuspendLayout()
            Me.SuspendLayout()
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Label1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(12, 9)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(64, 15)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Ya existen"
            '
            'lblExistencias
            '
            Me.lblExistencias.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblExistencias.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblExistencias.Location = New System.Drawing.Point(75, 9)
            Me.lblExistencias.Name = "lblExistencias"
            Me.lblExistencias.Size = New System.Drawing.Size(50, 13)
            Me.lblExistencias.TabIndex = 1
            Me.lblExistencias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label2
            '
            Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Label2.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(128, 9)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(85, 15)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "unidad(s) del"
            '
            'lblCodigo
            '
            Me.lblCodigo.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblCodigo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCodigo.Location = New System.Drawing.Point(219, 9)
            Me.lblCodigo.Name = "lblCodigo"
            Me.lblCodigo.Size = New System.Drawing.Size(67, 13)
            Me.lblCodigo.TabIndex = 3
            Me.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblDescripcion
            '
            Me.lblDescripcion.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblDescripcion.Location = New System.Drawing.Point(12, 34)
            Me.lblDescripcion.Name = "lblDescripcion"
            Me.lblDescripcion.Size = New System.Drawing.Size(259, 14)
            Me.lblDescripcion.TabIndex = 4
            Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Resumen
            '
            Me.Resumen.Controls.Add(Me.btnCancelar)
            Me.Resumen.Controls.Add(Me.btnAceptar)
            Me.Resumen.Controls.Add(Me.lblTotal)
            Me.Resumen.Controls.Add(Me.Label4)
            Me.Resumen.Controls.Add(Me.Label3)
            Me.Resumen.Controls.Add(Me.lblCantidad)
            Me.Resumen.Controls.Add(Me.lblTipo)
            Me.Resumen.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Resumen.Location = New System.Drawing.Point(13, 123)
            Me.Resumen.Name = "Resumen"
            Me.Resumen.Size = New System.Drawing.Size(258, 127)
            Me.Resumen.TabIndex = 7
            Me.Resumen.TabStop = False
            Me.Resumen.Visible = False
            '
            'btnCancelar
            '
            Me.btnCancelar.Image = Global.Presentacion.My.Resources.Resources.cancela
            Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnCancelar.Location = New System.Drawing.Point(153, 71)
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.Size = New System.Drawing.Size(65, 50)
            Me.btnCancelar.TabIndex = 12
            Me.btnCancelar.Text = "Cancelar"
            Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnCancelar.UseVisualStyleBackColor = True
            '
            'btnAceptar
            '
            Me.btnAceptar.Image = Global.Presentacion.My.Resources.Resources.aceptar
            Me.btnAceptar.Location = New System.Drawing.Point(27, 71)
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(65, 50)
            Me.btnAceptar.TabIndex = 8
            Me.btnAceptar.Text = "Aceptar"
            Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnAceptar.UseVisualStyleBackColor = True
            '
            'lblTotal
            '
            Me.lblTotal.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotal.Location = New System.Drawing.Point(118, 45)
            Me.lblTotal.Name = "lblTotal"
            Me.lblTotal.Size = New System.Drawing.Size(64, 13)
            Me.lblTotal.TabIndex = 11
            Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(62, 43)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(37, 15)
            Me.Label4.TabIndex = 10
            Me.Label4.Text = "Total:"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(162, 17)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(64, 15)
            Me.Label3.TabIndex = 9
            Me.Label3.Text = "Unidad(s)."
            '
            'lblCantidad
            '
            Me.lblCantidad.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblCantidad.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCantidad.Location = New System.Drawing.Point(105, 18)
            Me.lblCantidad.Name = "lblCantidad"
            Me.lblCantidad.Size = New System.Drawing.Size(50, 13)
            Me.lblCantidad.TabIndex = 8
            Me.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblTipo
            '
            Me.lblTipo.AutoSize = True
            Me.lblTipo.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTipo.Location = New System.Drawing.Point(17, 16)
            Me.lblTipo.Name = "lblTipo"
            Me.lblTipo.Size = New System.Drawing.Size(82, 15)
            Me.lblTipo.TabIndex = 0
            Me.lblTipo.Text = "Se va a sumar"
            '
            'btnRestar
            '
            Me.btnRestar.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnRestar.Image = Global.Presentacion.My.Resources.Resources.restar
            Me.btnRestar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnRestar.Location = New System.Drawing.Point(166, 64)
            Me.btnRestar.Name = "btnRestar"
            Me.btnRestar.Size = New System.Drawing.Size(65, 50)
            Me.btnRestar.TabIndex = 6
            Me.btnRestar.Text = "Restar"
            Me.btnRestar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnRestar.UseVisualStyleBackColor = True
            '
            'btnSumar
            '
            Me.btnSumar.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnSumar.Image = Global.Presentacion.My.Resources.Resources.sumar
            Me.btnSumar.Location = New System.Drawing.Point(40, 64)
            Me.btnSumar.Name = "btnSumar"
            Me.btnSumar.Size = New System.Drawing.Size(65, 50)
            Me.btnSumar.TabIndex = 5
            Me.btnSumar.Text = "Sumar"
            Me.btnSumar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnSumar.UseVisualStyleBackColor = True
            '
            'FrmExistenciasListado
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(284, 262)
            Me.Controls.Add(Me.Resumen)
            Me.Controls.Add(Me.btnRestar)
            Me.Controls.Add(Me.btnSumar)
            Me.Controls.Add(Me.lblDescripcion)
            Me.Controls.Add(Me.lblCodigo)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.lblExistencias)
            Me.Controls.Add(Me.Label1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmExistenciasListado"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "FrmExistenciasListado"
            Me.Resumen.ResumeLayout(False)
            Me.Resumen.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents lblExistencias As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents lblCodigo As System.Windows.Forms.Label
        Friend WithEvents lblDescripcion As System.Windows.Forms.Label
        Friend WithEvents btnSumar As System.Windows.Forms.Button
        Friend WithEvents btnRestar As System.Windows.Forms.Button
        Friend WithEvents Resumen As System.Windows.Forms.GroupBox
        Friend WithEvents lblTipo As System.Windows.Forms.Label
        Friend WithEvents btnCancelar As System.Windows.Forms.Button
        Friend WithEvents btnAceptar As System.Windows.Forms.Button
        Friend WithEvents lblTotal As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents lblCantidad As System.Windows.Forms.Label
    End Class
End Namespace