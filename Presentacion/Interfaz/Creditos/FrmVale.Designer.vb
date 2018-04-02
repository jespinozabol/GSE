Namespace Interfaz.Creditos
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmVale
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
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.btnGuardar = New System.Windows.Forms.Button()
            Me.btnLimpiar = New System.Windows.Forms.Button()
            Me.lblFecha = New System.Windows.Forms.Label()
            Me.lblMostrarFecha = New System.Windows.Forms.Label()
            Me.lblSolicitante = New System.Windows.Forms.Label()
            Me.lblAutorizado = New System.Windows.Forms.Label()
            Me.lblMostrarHora = New System.Windows.Forms.Label()
            Me.lblHora = New System.Windows.Forms.Label()
            Me.txtNum_vale = New System.Windows.Forms.TextBox()
            Me.txtMonto = New System.Windows.Forms.TextBox()
            Me.lblMonto = New System.Windows.Forms.Label()
            Me.txtObservaciones = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.dgvVales = New System.Windows.Forms.DataGridView()
            Me.IdVale = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Solicitante = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Autorizo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.cmbSolicitante = New System.Windows.Forms.ComboBox()
            Me.cmbAutorizado = New System.Windows.Forms.ComboBox()
            Me.errorVale = New System.Windows.Forms.ErrorProvider(Me.components)
            Me.btnEliminar = New System.Windows.Forms.Button()
            CType(Me.dgvVales, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.errorVale, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'btnGuardar
            '
            Me.btnGuardar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = Global.Presentacion.My.Resources.Resources.Imprimir
            Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnGuardar.Location = New System.Drawing.Point(0, 0)
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(71, 57)
            Me.btnGuardar.TabIndex = 42
            Me.btnGuardar.Text = "Imprimir"
            Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnGuardar.UseVisualStyleBackColor = True
            '
            'btnLimpiar
            '
            Me.btnLimpiar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnLimpiar.Image = Global.Presentacion.My.Resources.Resources.Limpiar
            Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnLimpiar.Location = New System.Drawing.Point(140, 0)
            Me.btnLimpiar.Name = "btnLimpiar"
            Me.btnLimpiar.Size = New System.Drawing.Size(71, 57)
            Me.btnLimpiar.TabIndex = 41
            Me.btnLimpiar.Text = "Limpiar"
            Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnLimpiar.UseVisualStyleBackColor = True
            '
            'lblFecha
            '
            Me.lblFecha.AutoSize = True
            Me.lblFecha.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFecha.Location = New System.Drawing.Point(377, 72)
            Me.lblFecha.Name = "lblFecha"
            Me.lblFecha.Size = New System.Drawing.Size(39, 15)
            Me.lblFecha.TabIndex = 45
            Me.lblFecha.Text = "Fecha"
            '
            'lblMostrarFecha
            '
            Me.lblMostrarFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarFecha.Location = New System.Drawing.Point(422, 72)
            Me.lblMostrarFecha.Name = "lblMostrarFecha"
            Me.lblMostrarFecha.Size = New System.Drawing.Size(87, 18)
            Me.lblMostrarFecha.TabIndex = 46
            '
            'lblSolicitante
            '
            Me.lblSolicitante.AutoSize = True
            Me.lblSolicitante.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSolicitante.Location = New System.Drawing.Point(12, 104)
            Me.lblSolicitante.Name = "lblSolicitante"
            Me.lblSolicitante.Size = New System.Drawing.Size(66, 15)
            Me.lblSolicitante.TabIndex = 47
            Me.lblSolicitante.Text = "Solicitante"
            '
            'lblAutorizado
            '
            Me.lblAutorizado.AutoSize = True
            Me.lblAutorizado.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblAutorizado.Location = New System.Drawing.Point(12, 138)
            Me.lblAutorizado.Name = "lblAutorizado"
            Me.lblAutorizado.Size = New System.Drawing.Size(68, 15)
            Me.lblAutorizado.TabIndex = 49
            Me.lblAutorizado.Text = "Autorizado"
            '
            'lblMostrarHora
            '
            Me.lblMostrarHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarHora.Location = New System.Drawing.Point(287, 70)
            Me.lblMostrarHora.Name = "lblMostrarHora"
            Me.lblMostrarHora.Size = New System.Drawing.Size(84, 18)
            Me.lblMostrarHora.TabIndex = 52
            '
            'lblHora
            '
            Me.lblHora.AutoSize = True
            Me.lblHora.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblHora.Location = New System.Drawing.Point(248, 70)
            Me.lblHora.Name = "lblHora"
            Me.lblHora.Size = New System.Drawing.Size(33, 15)
            Me.lblHora.TabIndex = 51
            Me.lblHora.Text = "Hora"
            '
            'txtNum_vale
            '
            Me.txtNum_vale.Enabled = False
            Me.txtNum_vale.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNum_vale.Location = New System.Drawing.Point(346, 12)
            Me.txtNum_vale.Name = "txtNum_vale"
            Me.txtNum_vale.Size = New System.Drawing.Size(70, 23)
            Me.txtNum_vale.TabIndex = 53
            Me.txtNum_vale.Visible = False
            '
            'txtMonto
            '
            Me.txtMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMonto.Location = New System.Drawing.Point(106, 68)
            Me.txtMonto.Name = "txtMonto"
            Me.txtMonto.Size = New System.Drawing.Size(125, 21)
            Me.txtMonto.TabIndex = 0
            '
            'lblMonto
            '
            Me.lblMonto.AutoSize = True
            Me.lblMonto.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMonto.Location = New System.Drawing.Point(12, 72)
            Me.lblMonto.Name = "lblMonto"
            Me.lblMonto.Size = New System.Drawing.Size(54, 15)
            Me.lblMonto.TabIndex = 54
            Me.lblMonto.Text = "Monto ¢"
            '
            'txtObservaciones
            '
            Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtObservaciones.Location = New System.Drawing.Point(106, 169)
            Me.txtObservaciones.Name = "txtObservaciones"
            Me.txtObservaciones.Size = New System.Drawing.Size(403, 21)
            Me.txtObservaciones.TabIndex = 3
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(12, 172)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(87, 15)
            Me.Label1.TabIndex = 56
            Me.Label1.Text = "Observaciones"
            '
            'dgvVales
            '
            Me.dgvVales.AllowUserToAddRows = False
            Me.dgvVales.AllowUserToDeleteRows = False
            Me.dgvVales.AllowUserToResizeColumns = False
            Me.dgvVales.AllowUserToResizeRows = False
            Me.dgvVales.BackgroundColor = System.Drawing.Color.White
            Me.dgvVales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            Me.dgvVales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdVale, Me.Fecha, Me.Solicitante, Me.Monto, Me.Autorizo})
            Me.dgvVales.GridColor = System.Drawing.Color.White
            Me.dgvVales.Location = New System.Drawing.Point(11, 204)
            Me.dgvVales.MultiSelect = False
            Me.dgvVales.Name = "dgvVales"
            Me.dgvVales.ReadOnly = True
            Me.dgvVales.RowHeadersVisible = False
            Me.dgvVales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
            Me.dgvVales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvVales.Size = New System.Drawing.Size(565, 197)
            Me.dgvVales.TabIndex = 58
            '
            'IdVale
            '
            Me.IdVale.HeaderText = "Id"
            Me.IdVale.Name = "IdVale"
            Me.IdVale.ReadOnly = True
            Me.IdVale.Visible = False
            '
            'Fecha
            '
            DataGridViewCellStyle3.Format = "d"
            DataGridViewCellStyle3.NullValue = Nothing
            Me.Fecha.DefaultCellStyle = DataGridViewCellStyle3
            Me.Fecha.HeaderText = "Fecha"
            Me.Fecha.Name = "Fecha"
            Me.Fecha.ReadOnly = True
            Me.Fecha.Width = 70
            '
            'Solicitante
            '
            Me.Solicitante.HeaderText = "Solicitante"
            Me.Solicitante.Name = "Solicitante"
            Me.Solicitante.ReadOnly = True
            Me.Solicitante.Width = 200
            '
            'Monto
            '
            Me.Monto.HeaderText = "Monto"
            Me.Monto.Name = "Monto"
            Me.Monto.ReadOnly = True
            Me.Monto.Width = 80
            '
            'Autorizo
            '
            Me.Autorizo.HeaderText = "Autorizó"
            Me.Autorizo.Name = "Autorizo"
            Me.Autorizo.ReadOnly = True
            Me.Autorizo.Width = 200
            '
            'cmbSolicitante
            '
            Me.cmbSolicitante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbSolicitante.FormattingEnabled = True
            Me.cmbSolicitante.Location = New System.Drawing.Point(106, 104)
            Me.cmbSolicitante.Name = "cmbSolicitante"
            Me.cmbSolicitante.Size = New System.Drawing.Size(310, 23)
            Me.cmbSolicitante.TabIndex = 60
            '
            'cmbAutorizado
            '
            Me.cmbAutorizado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbAutorizado.FormattingEnabled = True
            Me.cmbAutorizado.Location = New System.Drawing.Point(106, 138)
            Me.cmbAutorizado.Name = "cmbAutorizado"
            Me.cmbAutorizado.Size = New System.Drawing.Size(310, 23)
            Me.cmbAutorizado.TabIndex = 61
            '
            'errorVale
            '
            Me.errorVale.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
            Me.errorVale.ContainerControl = Me
            '
            'btnEliminar
            '
            Me.btnEliminar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliminar.Image = Global.Presentacion.My.Resources.Resources.Eliminar
            Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnEliminar.Location = New System.Drawing.Point(70, 0)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(71, 57)
            Me.btnEliminar.TabIndex = 62
            Me.btnEliminar.Text = "Eliminar"
            Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnEliminar.UseVisualStyleBackColor = True
            Me.btnEliminar.Visible = False
            '
            'FrmVale
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(594, 413)
            Me.Controls.Add(Me.btnEliminar)
            Me.Controls.Add(Me.cmbAutorizado)
            Me.Controls.Add(Me.cmbSolicitante)
            Me.Controls.Add(Me.dgvVales)
            Me.Controls.Add(Me.txtObservaciones)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.txtMonto)
            Me.Controls.Add(Me.lblMonto)
            Me.Controls.Add(Me.lblMostrarHora)
            Me.Controls.Add(Me.lblHora)
            Me.Controls.Add(Me.lblAutorizado)
            Me.Controls.Add(Me.lblSolicitante)
            Me.Controls.Add(Me.lblMostrarFecha)
            Me.Controls.Add(Me.lblFecha)
            Me.Controls.Add(Me.btnGuardar)
            Me.Controls.Add(Me.btnLimpiar)
            Me.Controls.Add(Me.txtNum_vale)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmVale"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Vale"
            CType(Me.dgvVales, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.errorVale, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents btnGuardar As System.Windows.Forms.Button
        Friend WithEvents btnLimpiar As System.Windows.Forms.Button
        Friend WithEvents lblFecha As System.Windows.Forms.Label
        Friend WithEvents lblMostrarFecha As System.Windows.Forms.Label
        Friend WithEvents lblSolicitante As System.Windows.Forms.Label
        Friend WithEvents lblAutorizado As System.Windows.Forms.Label
        Friend WithEvents lblMostrarHora As System.Windows.Forms.Label
        Friend WithEvents lblHora As System.Windows.Forms.Label
        Friend WithEvents txtNum_vale As System.Windows.Forms.TextBox
        Friend WithEvents txtMonto As System.Windows.Forms.TextBox
        Friend WithEvents lblMonto As System.Windows.Forms.Label
        Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents dgvVales As System.Windows.Forms.DataGridView
        Friend WithEvents cmbSolicitante As System.Windows.Forms.ComboBox
        Friend WithEvents cmbAutorizado As System.Windows.Forms.ComboBox
        Friend WithEvents errorVale As System.Windows.Forms.ErrorProvider
        Friend WithEvents IdVale As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Solicitante As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Monto As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Autorizo As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents btnEliminar As System.Windows.Forms.Button
    End Class
End Namespace