﻿Namespace Interfaz.Proformas
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmExistenciasProforma
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
            Me.lblTotal = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.lblCantidad = New System.Windows.Forms.Label()
            Me.lblTipo = New System.Windows.Forms.Label()
            Me.lblDescripcion = New System.Windows.Forms.Label()
            Me.lblCodigo = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.lblExistencias = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.btnCancelar = New System.Windows.Forms.Button()
            Me.btnAceptar = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'lblTotal
            '
            Me.lblTotal.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotal.Location = New System.Drawing.Point(115, 98)
            Me.lblTotal.Name = "lblTotal"
            Me.lblTotal.Size = New System.Drawing.Size(64, 13)
            Me.lblTotal.TabIndex = 33
            Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(59, 96)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(37, 15)
            Me.Label4.TabIndex = 32
            Me.Label4.Text = "Total:"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(159, 70)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(64, 15)
            Me.Label3.TabIndex = 31
            Me.Label3.Text = "Unidad(s)."
            '
            'lblCantidad
            '
            Me.lblCantidad.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblCantidad.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCantidad.Location = New System.Drawing.Point(102, 71)
            Me.lblCantidad.Name = "lblCantidad"
            Me.lblCantidad.Size = New System.Drawing.Size(50, 13)
            Me.lblCantidad.TabIndex = 29
            Me.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblTipo
            '
            Me.lblTipo.AutoSize = True
            Me.lblTipo.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTipo.Location = New System.Drawing.Point(14, 69)
            Me.lblTipo.Name = "lblTipo"
            Me.lblTipo.Size = New System.Drawing.Size(82, 15)
            Me.lblTipo.TabIndex = 28
            Me.lblTipo.Text = "Se va a sumar"
            '
            'lblDescripcion
            '
            Me.lblDescripcion.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblDescripcion.Location = New System.Drawing.Point(-3, 29)
            Me.lblDescripcion.Name = "lblDescripcion"
            Me.lblDescripcion.Size = New System.Drawing.Size(265, 14)
            Me.lblDescripcion.TabIndex = 27
            Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblCodigo
            '
            Me.lblCodigo.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblCodigo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCodigo.Location = New System.Drawing.Point(204, 4)
            Me.lblCodigo.Name = "lblCodigo"
            Me.lblCodigo.Size = New System.Drawing.Size(67, 13)
            Me.lblCodigo.TabIndex = 26
            Me.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label2
            '
            Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Label2.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(113, 4)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(85, 15)
            Me.Label2.TabIndex = 25
            Me.Label2.Text = "unidad(s) del"
            '
            'lblExistencias
            '
            Me.lblExistencias.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblExistencias.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblExistencias.Location = New System.Drawing.Point(60, 4)
            Me.lblExistencias.Name = "lblExistencias"
            Me.lblExistencias.Size = New System.Drawing.Size(50, 13)
            Me.lblExistencias.TabIndex = 24
            Me.lblExistencias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Label1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(-3, 4)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(64, 15)
            Me.Label1.TabIndex = 23
            Me.Label1.Text = "Ya existen"
            '
            'btnCancelar
            '
            Me.btnCancelar.Image = Global.Presentacion.My.Resources.Resources.cancela
            Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnCancelar.Location = New System.Drawing.Point(150, 124)
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.Size = New System.Drawing.Size(65, 50)
            Me.btnCancelar.TabIndex = 34
            Me.btnCancelar.Text = "Cancelar"
            Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnCancelar.UseVisualStyleBackColor = True
            '
            'btnAceptar
            '
            Me.btnAceptar.Image = Global.Presentacion.My.Resources.Resources.aceptar
            Me.btnAceptar.Location = New System.Drawing.Point(24, 124)
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(65, 50)
            Me.btnAceptar.TabIndex = 30
            Me.btnAceptar.Text = "Aceptar"
            Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnAceptar.UseVisualStyleBackColor = True
            '
            'FrmExistenciasProforma
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(268, 178)
            Me.ControlBox = False
            Me.Controls.Add(Me.btnCancelar)
            Me.Controls.Add(Me.btnAceptar)
            Me.Controls.Add(Me.lblTotal)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.lblCantidad)
            Me.Controls.Add(Me.lblTipo)
            Me.Controls.Add(Me.lblDescripcion)
            Me.Controls.Add(Me.lblCodigo)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.lblExistencias)
            Me.Controls.Add(Me.Label1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Name = "FrmExistenciasProforma"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Existencias Proforma"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents btnCancelar As System.Windows.Forms.Button
        Friend WithEvents btnAceptar As System.Windows.Forms.Button
        Friend WithEvents lblTotal As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents lblCantidad As System.Windows.Forms.Label
        Friend WithEvents lblTipo As System.Windows.Forms.Label
        Friend WithEvents lblDescripcion As System.Windows.Forms.Label
        Friend WithEvents lblCodigo As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents lblExistencias As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
    End Class
End Namespace