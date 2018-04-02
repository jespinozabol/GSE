<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmail
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblAsunto = New System.Windows.Forms.Label()
        Me.txtEmails = New System.Windows.Forms.TextBox()
        Me.lblBody = New System.Windows.Forms.Label()
        Me.txtAsunto = New System.Windows.Forms.TextBox()
        Me.txtBody = New System.Windows.Forms.TextBox()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMostrarAdjuntos = New System.Windows.Forms.Label()
        Me.OpenFileAdjuntar = New System.Windows.Forms.OpenFileDialog()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.pnlEmails = New System.Windows.Forms.Panel()
        Me.btnAgregarEmail = New System.Windows.Forms.Button()
        Me.dgvEmails = New System.Windows.Forms.DataGridView()
        Me.Check = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlEmails.SuspendLayout()
        CType(Me.dgvEmails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(23, 9)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 0
        Me.lblEmail.Text = "Para:"
        '
        'lblAsunto
        '
        Me.lblAsunto.AutoSize = True
        Me.lblAsunto.Location = New System.Drawing.Point(12, 64)
        Me.lblAsunto.Name = "lblAsunto"
        Me.lblAsunto.Size = New System.Drawing.Size(43, 13)
        Me.lblAsunto.TabIndex = 1
        Me.lblAsunto.Text = "Asunto:"
        '
        'txtEmails
        '
        Me.txtEmails.Location = New System.Drawing.Point(62, 9)
        Me.txtEmails.Multiline = True
        Me.txtEmails.Name = "txtEmails"
        Me.txtEmails.Size = New System.Drawing.Size(280, 42)
        Me.txtEmails.TabIndex = 2
        '
        'lblBody
        '
        Me.lblBody.AutoSize = True
        Me.lblBody.Location = New System.Drawing.Point(12, 90)
        Me.lblBody.Name = "lblBody"
        Me.lblBody.Size = New System.Drawing.Size(34, 13)
        Me.lblBody.TabIndex = 3
        Me.lblBody.Text = "Body:"
        '
        'txtAsunto
        '
        Me.txtAsunto.Location = New System.Drawing.Point(62, 61)
        Me.txtAsunto.Name = "txtAsunto"
        Me.txtAsunto.Size = New System.Drawing.Size(329, 20)
        Me.txtAsunto.TabIndex = 4
        '
        'txtBody
        '
        Me.txtBody.Location = New System.Drawing.Point(62, 90)
        Me.txtBody.Multiline = True
        Me.txtBody.Name = "txtBody"
        Me.txtBody.Size = New System.Drawing.Size(329, 152)
        Me.txtBody.TabIndex = 5
        Me.txtBody.Text = "Saludos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Adjunto encontrará el estado de cuenta de su representada " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "en formato" & _
    " PDF, cualquier duda estoy para servirle." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Atte. Erick Vindas Bolaños" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tel: 24" & _
    "63-1585"
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(316, 249)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(75, 40)
        Me.btnEnviar.TabIndex = 6
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 245)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Archivo Adjunto:"
        '
        'lblMostrarAdjuntos
        '
        Me.lblMostrarAdjuntos.Location = New System.Drawing.Point(12, 267)
        Me.lblMostrarAdjuntos.Name = "lblMostrarAdjuntos"
        Me.lblMostrarAdjuntos.Size = New System.Drawing.Size(234, 20)
        Me.lblMostrarAdjuntos.TabIndex = 8
        Me.lblMostrarAdjuntos.Text = "lblMostrarArchivos"
        '
        'OpenFileAdjuntar
        '
        Me.OpenFileAdjuntar.FileName = "OpenFileAdjuntar"
        Me.OpenFileAdjuntar.Filter = "pdf files (*.pdf)|"
        Me.OpenFileAdjuntar.Title = "Adjuntar Archivo"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(348, 9)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(51, 42)
        Me.btnBuscar.TabIndex = 10
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'pnlEmails
        '
        Me.pnlEmails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlEmails.Controls.Add(Me.btnAgregarEmail)
        Me.pnlEmails.Controls.Add(Me.dgvEmails)
        Me.pnlEmails.Location = New System.Drawing.Point(62, 51)
        Me.pnlEmails.Name = "pnlEmails"
        Me.pnlEmails.Size = New System.Drawing.Size(280, 135)
        Me.pnlEmails.TabIndex = 11
        Me.pnlEmails.Visible = False
        '
        'btnAgregarEmail
        '
        Me.btnAgregarEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarEmail.Location = New System.Drawing.Point(215, 114)
        Me.btnAgregarEmail.Name = "btnAgregarEmail"
        Me.btnAgregarEmail.Size = New System.Drawing.Size(64, 20)
        Me.btnAgregarEmail.TabIndex = 12
        Me.btnAgregarEmail.Text = "Agregar"
        Me.btnAgregarEmail.UseVisualStyleBackColor = True
        '
        'dgvEmails
        '
        Me.dgvEmails.AllowUserToAddRows = False
        Me.dgvEmails.AllowUserToDeleteRows = False
        Me.dgvEmails.AllowUserToResizeColumns = False
        Me.dgvEmails.AllowUserToResizeRows = False
        Me.dgvEmails.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvEmails.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvEmails.ColumnHeadersHeight = 19
        Me.dgvEmails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvEmails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Check, Me.Email})
        Me.dgvEmails.GridColor = System.Drawing.SystemColors.Control
        Me.dgvEmails.Location = New System.Drawing.Point(0, 0)
        Me.dgvEmails.Name = "dgvEmails"
        Me.dgvEmails.RowHeadersVisible = False
        Me.dgvEmails.RowTemplate.Height = 18
        Me.dgvEmails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmails.Size = New System.Drawing.Size(279, 114)
        Me.dgvEmails.TabIndex = 0
        '
        'Check
        '
        Me.Check.HeaderText = ""
        Me.Check.Name = "Check"
        Me.Check.Width = 30
        '
        'Email
        '
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        Me.Email.Width = 220
        '
        'FrmEmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 294)
        Me.Controls.Add(Me.pnlEmails)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.lblMostrarAdjuntos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.txtBody)
        Me.Controls.Add(Me.txtAsunto)
        Me.Controls.Add(Me.lblBody)
        Me.Controls.Add(Me.txtEmails)
        Me.Controls.Add(Me.lblAsunto)
        Me.Controls.Add(Me.lblEmail)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmEmail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enviar correo"
        Me.pnlEmails.ResumeLayout(False)
        CType(Me.dgvEmails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblAsunto As System.Windows.Forms.Label
    Friend WithEvents txtEmails As System.Windows.Forms.TextBox
    Friend WithEvents lblBody As System.Windows.Forms.Label
    Friend WithEvents txtAsunto As System.Windows.Forms.TextBox
    Friend WithEvents txtBody As System.Windows.Forms.TextBox
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblMostrarAdjuntos As System.Windows.Forms.Label
    Friend WithEvents OpenFileAdjuntar As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents pnlEmails As System.Windows.Forms.Panel
    Friend WithEvents dgvEmails As System.Windows.Forms.DataGridView
    Friend WithEvents btnAgregarEmail As System.Windows.Forms.Button
    Friend WithEvents Check As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Email As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
