Namespace Interfaz.Creditos
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmConsultaCreditos
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
            Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.rbTodos = New System.Windows.Forms.RadioButton()
            Me.rbCerrado = New System.Windows.Forms.RadioButton()
            Me.rbAtrasados = New System.Windows.Forms.RadioButton()
            Me.gbBusqueda = New System.Windows.Forms.GroupBox()
            Me.rbCreditoCongelado = New System.Windows.Forms.RadioButton()
            Me.rbAbierto = New System.Windows.Forms.RadioButton()
            Me.btnBuscar = New System.Windows.Forms.Button()
            Me.gbEnte = New System.Windows.Forms.GroupBox()
            Me.rbTodosClientes = New System.Windows.Forms.RadioButton()
            Me.rbJuridico = New System.Windows.Forms.RadioButton()
            Me.rbFisico = New System.Windows.Forms.RadioButton()
            Me.dgvLista = New System.Windows.Forms.DataGridView()
            Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Telefono2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Limite = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Dias = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Atrasado = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.MnDatos = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.VerDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.VerFacturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnImprimir = New System.Windows.Forms.Button()
            Me.lblTotal1 = New System.Windows.Forms.Label()
            Me.lblMostrarTipo = New System.Windows.Forms.Label()
            Me.lblMostrarTotalGeneral = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.rbTodosEstado = New System.Windows.Forms.RadioButton()
            Me.rbAlDia = New System.Windows.Forms.RadioButton()
            Me.gbOtrasOpciones = New System.Windows.Forms.GroupBox()
            Me.chkIncluirEnCobro = New System.Windows.Forms.CheckBox()
            Me.gbBusqueda.SuspendLayout()
            Me.gbEnte.SuspendLayout()
            CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MnDatos.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.gbOtrasOpciones.SuspendLayout()
            Me.SuspendLayout()
            '
            'rbTodos
            '
            Me.rbTodos.AutoSize = True
            Me.rbTodos.Location = New System.Drawing.Point(10, 16)
            Me.rbTodos.Name = "rbTodos"
            Me.rbTodos.Size = New System.Drawing.Size(57, 19)
            Me.rbTodos.TabIndex = 6
            Me.rbTodos.Text = "Todos"
            Me.rbTodos.UseVisualStyleBackColor = True
            '
            'rbCerrado
            '
            Me.rbCerrado.AutoSize = True
            Me.rbCerrado.Location = New System.Drawing.Point(10, 91)
            Me.rbCerrado.Name = "rbCerrado"
            Me.rbCerrado.Size = New System.Drawing.Size(113, 19)
            Me.rbCerrado.TabIndex = 7
            Me.rbCerrado.Text = "Crédito Cerrado"
            Me.rbCerrado.UseVisualStyleBackColor = True
            '
            'rbAtrasados
            '
            Me.rbAtrasados.AutoSize = True
            Me.rbAtrasados.Checked = True
            Me.rbAtrasados.Location = New System.Drawing.Point(6, 57)
            Me.rbAtrasados.Name = "rbAtrasados"
            Me.rbAtrasados.Size = New System.Drawing.Size(118, 19)
            Me.rbAtrasados.TabIndex = 8
            Me.rbAtrasados.TabStop = True
            Me.rbAtrasados.Text = "Crédito Atrasado"
            Me.rbAtrasados.UseVisualStyleBackColor = True
            '
            'gbBusqueda
            '
            Me.gbBusqueda.Controls.Add(Me.rbCreditoCongelado)
            Me.gbBusqueda.Controls.Add(Me.rbAbierto)
            Me.gbBusqueda.Controls.Add(Me.rbCerrado)
            Me.gbBusqueda.Controls.Add(Me.rbTodos)
            Me.gbBusqueda.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbBusqueda.Location = New System.Drawing.Point(330, 2)
            Me.gbBusqueda.Name = "gbBusqueda"
            Me.gbBusqueda.Size = New System.Drawing.Size(138, 116)
            Me.gbBusqueda.TabIndex = 9
            Me.gbBusqueda.TabStop = False
            Me.gbBusqueda.Text = "Tipo busqueda"
            '
            'rbCreditoCongelado
            '
            Me.rbCreditoCongelado.AutoSize = True
            Me.rbCreditoCongelado.Location = New System.Drawing.Point(10, 66)
            Me.rbCreditoCongelado.Name = "rbCreditoCongelado"
            Me.rbCreditoCongelado.Size = New System.Drawing.Size(127, 19)
            Me.rbCreditoCongelado.TabIndex = 11
            Me.rbCreditoCongelado.Text = "Crédito Congelado"
            Me.rbCreditoCongelado.UseVisualStyleBackColor = True
            '
            'rbAbierto
            '
            Me.rbAbierto.AutoSize = True
            Me.rbAbierto.Checked = True
            Me.rbAbierto.Location = New System.Drawing.Point(10, 41)
            Me.rbAbierto.Name = "rbAbierto"
            Me.rbAbierto.Size = New System.Drawing.Size(111, 19)
            Me.rbAbierto.TabIndex = 9
            Me.rbAbierto.TabStop = True
            Me.rbAbierto.Text = "Crédito Abierto"
            Me.rbAbierto.UseVisualStyleBackColor = True
            '
            'btnBuscar
            '
            Me.btnBuscar.Image = Global.Presentacion.My.Resources.Resources.buscar
            Me.btnBuscar.Location = New System.Drawing.Point(64, 0)
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(65, 57)
            Me.btnBuscar.TabIndex = 10
            Me.btnBuscar.Text = "Buscar"
            Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnBuscar.UseVisualStyleBackColor = True
            '
            'gbEnte
            '
            Me.gbEnte.Controls.Add(Me.rbTodosClientes)
            Me.gbEnte.Controls.Add(Me.rbJuridico)
            Me.gbEnte.Controls.Add(Me.rbFisico)
            Me.gbEnte.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbEnte.Location = New System.Drawing.Point(233, 18)
            Me.gbEnte.Name = "gbEnte"
            Me.gbEnte.Size = New System.Drawing.Size(84, 87)
            Me.gbEnte.TabIndex = 11
            Me.gbEnte.TabStop = False
            Me.gbEnte.Text = "Cliente"
            '
            'rbTodosClientes
            '
            Me.rbTodosClientes.AutoSize = True
            Me.rbTodosClientes.Checked = True
            Me.rbTodosClientes.Location = New System.Drawing.Point(6, 19)
            Me.rbTodosClientes.Name = "rbTodosClientes"
            Me.rbTodosClientes.Size = New System.Drawing.Size(57, 19)
            Me.rbTodosClientes.TabIndex = 10
            Me.rbTodosClientes.TabStop = True
            Me.rbTodosClientes.Text = "Todos"
            Me.rbTodosClientes.UseVisualStyleBackColor = True
            '
            'rbJuridico
            '
            Me.rbJuridico.AutoSize = True
            Me.rbJuridico.Location = New System.Drawing.Point(6, 64)
            Me.rbJuridico.Name = "rbJuridico"
            Me.rbJuridico.Size = New System.Drawing.Size(68, 19)
            Me.rbJuridico.TabIndex = 9
            Me.rbJuridico.Text = "Jurídico"
            Me.rbJuridico.UseVisualStyleBackColor = True
            '
            'rbFisico
            '
            Me.rbFisico.AutoSize = True
            Me.rbFisico.Location = New System.Drawing.Point(6, 41)
            Me.rbFisico.Name = "rbFisico"
            Me.rbFisico.Size = New System.Drawing.Size(55, 19)
            Me.rbFisico.TabIndex = 9
            Me.rbFisico.Text = "Físico"
            Me.rbFisico.UseVisualStyleBackColor = True
            '
            'dgvLista
            '
            Me.dgvLista.AllowUserToAddRows = False
            Me.dgvLista.AllowUserToDeleteRows = False
            Me.dgvLista.AllowUserToResizeColumns = False
            Me.dgvLista.AllowUserToResizeRows = False
            Me.dgvLista.BackgroundColor = System.Drawing.Color.White
            Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            Me.dgvLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Nombre, Me.Telefono, Me.Telefono2, Me.Total, Me.Limite, Me.Dias, Me.Atrasado, Me.Estado})
            Me.dgvLista.GridColor = System.Drawing.Color.White
            Me.dgvLista.Location = New System.Drawing.Point(12, 124)
            Me.dgvLista.MultiSelect = False
            Me.dgvLista.Name = "dgvLista"
            Me.dgvLista.ReadOnly = True
            Me.dgvLista.RowHeadersVisible = False
            Me.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvLista.Size = New System.Drawing.Size(835, 425)
            Me.dgvLista.TabIndex = 12
            '
            'Id
            '
            Me.Id.HeaderText = "ID"
            Me.Id.Name = "Id"
            Me.Id.ReadOnly = True
            Me.Id.Width = 36
            '
            'Nombre
            '
            Me.Nombre.HeaderText = "Nombre"
            Me.Nombre.Name = "Nombre"
            Me.Nombre.ReadOnly = True
            Me.Nombre.Width = 300
            '
            'Telefono
            '
            Me.Telefono.HeaderText = "Teléfono"
            Me.Telefono.Name = "Telefono"
            Me.Telefono.ReadOnly = True
            Me.Telefono.Width = 65
            '
            'Telefono2
            '
            Me.Telefono2.HeaderText = "Telefono2"
            Me.Telefono2.Name = "Telefono2"
            Me.Telefono2.ReadOnly = True
            Me.Telefono2.Width = 65
            '
            'Total
            '
            DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Total.DefaultCellStyle = DataGridViewCellStyle13
            Me.Total.HeaderText = "Total Créditos"
            Me.Total.Name = "Total"
            Me.Total.ReadOnly = True
            Me.Total.Width = 80
            '
            'Limite
            '
            DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Limite.DefaultCellStyle = DataGridViewCellStyle14
            Me.Limite.HeaderText = "Límite"
            Me.Limite.Name = "Limite"
            Me.Limite.ReadOnly = True
            Me.Limite.Width = 80
            '
            'Dias
            '
            DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Dias.DefaultCellStyle = DataGridViewCellStyle15
            Me.Dias.HeaderText = "Dias"
            Me.Dias.Name = "Dias"
            Me.Dias.ReadOnly = True
            Me.Dias.Width = 40
            '
            'Atrasado
            '
            DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Atrasado.DefaultCellStyle = DataGridViewCellStyle16
            Me.Atrasado.HeaderText = "Total Atrasado"
            Me.Atrasado.Name = "Atrasado"
            Me.Atrasado.ReadOnly = True
            Me.Atrasado.Width = 83
            '
            'Estado
            '
            Me.Estado.HeaderText = "Estado"
            Me.Estado.Name = "Estado"
            Me.Estado.ReadOnly = True
            Me.Estado.Width = 65
            '
            'MnDatos
            '
            Me.MnDatos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerDatosToolStripMenuItem, Me.VerFacturasToolStripMenuItem})
            Me.MnDatos.Name = "ContextMenu"
            Me.MnDatos.Size = New System.Drawing.Size(198, 48)
            '
            'VerDatosToolStripMenuItem
            '
            Me.VerDatosToolStripMenuItem.Name = "VerDatosToolStripMenuItem"
            Me.VerDatosToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
            Me.VerDatosToolStripMenuItem.Text = "Ver datos"
            '
            'VerFacturasToolStripMenuItem
            '
            Me.VerFacturasToolStripMenuItem.Name = "VerFacturasToolStripMenuItem"
            Me.VerFacturasToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
            Me.VerFacturasToolStripMenuItem.Text = "Ver facturas pendientes"
            '
            'btnImprimir
            '
            Me.btnImprimir.Image = Global.Presentacion.My.Resources.Resources.Imprimir
            Me.btnImprimir.Location = New System.Drawing.Point(0, 0)
            Me.btnImprimir.Name = "btnImprimir"
            Me.btnImprimir.Size = New System.Drawing.Size(65, 57)
            Me.btnImprimir.TabIndex = 13
            Me.btnImprimir.Text = "Imprimir"
            Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnImprimir.UseVisualStyleBackColor = True
            '
            'lblTotal1
            '
            Me.lblTotal1.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotal1.Location = New System.Drawing.Point(409, 552)
            Me.lblTotal1.Name = "lblTotal1"
            Me.lblTotal1.Size = New System.Drawing.Size(279, 26)
            Me.lblTotal1.TabIndex = 14
            Me.lblTotal1.Text = "Deuda por créditos atrasados"
            Me.lblTotal1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblMostrarTipo
            '
            Me.lblMostrarTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarTipo.ForeColor = System.Drawing.Color.Red
            Me.lblMostrarTipo.Location = New System.Drawing.Point(695, 553)
            Me.lblMostrarTipo.Name = "lblMostrarTipo"
            Me.lblMostrarTipo.Size = New System.Drawing.Size(149, 24)
            Me.lblMostrarTipo.TabIndex = 16
            Me.lblMostrarTipo.Text = "0.00"
            Me.lblMostrarTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblMostrarTotalGeneral
            '
            Me.lblMostrarTotalGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarTotalGeneral.ForeColor = System.Drawing.Color.Red
            Me.lblMostrarTotalGeneral.Location = New System.Drawing.Point(698, 594)
            Me.lblMostrarTotalGeneral.Name = "lblMostrarTotalGeneral"
            Me.lblMostrarTotalGeneral.Size = New System.Drawing.Size(149, 24)
            Me.lblMostrarTotalGeneral.TabIndex = 18
            Me.lblMostrarTotalGeneral.Text = "0.00"
            Me.lblMostrarTotalGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(419, 590)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(269, 29)
            Me.Label2.TabIndex = 19
            Me.Label2.Text = "Total General de Créditos"
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.rbTodosEstado)
            Me.GroupBox1.Controls.Add(Me.rbAlDia)
            Me.GroupBox1.Controls.Add(Me.rbAtrasados)
            Me.GroupBox1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(474, 18)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(127, 84)
            Me.GroupBox1.TabIndex = 12
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Estado crédito"
            '
            'rbTodosEstado
            '
            Me.rbTodosEstado.AutoSize = True
            Me.rbTodosEstado.Location = New System.Drawing.Point(6, 14)
            Me.rbTodosEstado.Name = "rbTodosEstado"
            Me.rbTodosEstado.Size = New System.Drawing.Size(57, 19)
            Me.rbTodosEstado.TabIndex = 12
            Me.rbTodosEstado.Text = "Todos"
            Me.rbTodosEstado.UseVisualStyleBackColor = True
            '
            'rbAlDia
            '
            Me.rbAlDia.AutoSize = True
            Me.rbAlDia.Location = New System.Drawing.Point(6, 36)
            Me.rbAlDia.Name = "rbAlDia"
            Me.rbAlDia.Size = New System.Drawing.Size(55, 19)
            Me.rbAlDia.TabIndex = 10
            Me.rbAlDia.Text = "Al día"
            Me.rbAlDia.UseVisualStyleBackColor = True
            '
            'gbOtrasOpciones
            '
            Me.gbOtrasOpciones.Controls.Add(Me.chkIncluirEnCobro)
            Me.gbOtrasOpciones.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbOtrasOpciones.Location = New System.Drawing.Point(616, 21)
            Me.gbOtrasOpciones.Name = "gbOtrasOpciones"
            Me.gbOtrasOpciones.Size = New System.Drawing.Size(225, 84)
            Me.gbOtrasOpciones.TabIndex = 13
            Me.gbOtrasOpciones.TabStop = False
            Me.gbOtrasOpciones.Text = "Otras opciones"
            '
            'chkIncluirEnCobro
            '
            Me.chkIncluirEnCobro.AutoSize = True
            Me.chkIncluirEnCobro.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkIncluirEnCobro.Location = New System.Drawing.Point(7, 21)
            Me.chkIncluirEnCobro.Name = "chkIncluirEnCobro"
            Me.chkIncluirEnCobro.Size = New System.Drawing.Size(214, 50)
            Me.chkIncluirEnCobro.TabIndex = 0
            Me.chkIncluirEnCobro.Text = "Incluir clientes con crédito cerrado " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ó congelado, con saldo pendiente" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "que se v" & _
        "a a continuar cobrando"
            Me.chkIncluirEnCobro.UseCompatibleTextRendering = True
            Me.chkIncluirEnCobro.UseVisualStyleBackColor = True
            '
            'FrmConsultaCreditos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(853, 628)
            Me.Controls.Add(Me.gbOtrasOpciones)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.btnImprimir)
            Me.Controls.Add(Me.dgvLista)
            Me.Controls.Add(Me.lblMostrarTotalGeneral)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.lblMostrarTipo)
            Me.Controls.Add(Me.lblTotal1)
            Me.Controls.Add(Me.gbEnte)
            Me.Controls.Add(Me.btnBuscar)
            Me.Controls.Add(Me.gbBusqueda)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmConsultaCreditos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Análisis de Créditos General"
            Me.gbBusqueda.ResumeLayout(False)
            Me.gbBusqueda.PerformLayout()
            Me.gbEnte.ResumeLayout(False)
            Me.gbEnte.PerformLayout()
            CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MnDatos.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.gbOtrasOpciones.ResumeLayout(False)
            Me.gbOtrasOpciones.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents rbTodos As System.Windows.Forms.RadioButton
        Friend WithEvents rbCerrado As System.Windows.Forms.RadioButton
        Friend WithEvents rbAtrasados As System.Windows.Forms.RadioButton
        Friend WithEvents gbBusqueda As System.Windows.Forms.GroupBox
        Friend WithEvents btnBuscar As System.Windows.Forms.Button
        Friend WithEvents gbEnte As System.Windows.Forms.GroupBox
        Friend WithEvents rbJuridico As System.Windows.Forms.RadioButton
        Friend WithEvents rbFisico As System.Windows.Forms.RadioButton
        Friend WithEvents rbTodosClientes As System.Windows.Forms.RadioButton
        Friend WithEvents dgvLista As System.Windows.Forms.DataGridView
        Friend WithEvents MnDatos As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents VerDatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents VerFacturasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnImprimir As System.Windows.Forms.Button
        Friend WithEvents lblTotal1 As System.Windows.Forms.Label
        Friend WithEvents lblMostrarTipo As System.Windows.Forms.Label
        Friend WithEvents rbAbierto As System.Windows.Forms.RadioButton
        Friend WithEvents lblMostrarTotalGeneral As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Private WithEvents rbCreditoCongelado As System.Windows.Forms.RadioButton
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents rbAlDia As System.Windows.Forms.RadioButton
        Friend WithEvents rbTodosEstado As System.Windows.Forms.RadioButton
        Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Telefono As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Telefono2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Limite As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Dias As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Atrasado As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Estado As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents gbOtrasOpciones As System.Windows.Forms.GroupBox
        Friend WithEvents chkIncluirEnCobro As System.Windows.Forms.CheckBox
    End Class
End Namespace