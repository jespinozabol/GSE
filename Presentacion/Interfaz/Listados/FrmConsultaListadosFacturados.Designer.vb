<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaListadosFacturados
    Inherits System.Windows.Forms.Form

    Private oLogica_Listado As New Logica_Negocios.LogicaListado

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvListados = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblMostrar = New System.Windows.Forms.Label()
        Me.btnEliminar_Listados = New System.Windows.Forms.Button()
        CType(Me.dgvListados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvListados
        '
        Me.dgvListados.AllowUserToAddRows = False
        Me.dgvListados.AllowUserToDeleteRows = False
        Me.dgvListados.AllowUserToResizeColumns = False
        Me.dgvListados.AllowUserToResizeRows = False
        Me.dgvListados.BackgroundColor = System.Drawing.Color.White
        Me.dgvListados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvListados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Fecha, Me.Cliente, Me.Telefono, Me.Total})
        Me.dgvListados.GridColor = System.Drawing.Color.White
        Me.dgvListados.Location = New System.Drawing.Point(3, 56)
        Me.dgvListados.MultiSelect = False
        Me.dgvListados.Name = "dgvListados"
        Me.dgvListados.ReadOnly = True
        Me.dgvListados.RowHeadersVisible = False
        Me.dgvListados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListados.Size = New System.Drawing.Size(587, 335)
        Me.dgvListados.TabIndex = 4
        '
        'Id
        '
        Me.Id.HeaderText = "# List"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Width = 55
        '
        'Fecha
        '
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Fecha.DefaultCellStyle = DataGridViewCellStyle1
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 85
        '
        'Cliente
        '
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.ReadOnly = True
        Me.Cliente.Width = 260
        '
        'Telefono
        '
        Me.Telefono.HeaderText = "Telefono"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.ReadOnly = True
        Me.Telefono.Width = 80
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'lblMostrar
        '
        Me.lblMostrar.AutoSize = True
        Me.lblMostrar.Font = New System.Drawing.Font("Candara", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMostrar.Location = New System.Drawing.Point(331, 9)
        Me.lblMostrar.Name = "lblMostrar"
        Me.lblMostrar.Size = New System.Drawing.Size(237, 36)
        Me.lblMostrar.TabIndex = 3
        Me.lblMostrar.Text = "Listados Impresos"
        '
        'btnEliminar_Listados
        '
        Me.btnEliminar_Listados.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEliminar_Listados.Location = New System.Drawing.Point(0, 0)
        Me.btnEliminar_Listados.Name = "btnEliminar_Listados"
        Me.btnEliminar_Listados.Size = New System.Drawing.Size(104, 52)
        Me.btnEliminar_Listados.TabIndex = 6
        Me.btnEliminar_Listados.Text = "Eliminar Listados Antiguos"
        Me.btnEliminar_Listados.UseVisualStyleBackColor = True
        '
        'FrmConsultaListadosFacturados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 393)
        Me.Controls.Add(Me.btnEliminar_Listados)
        Me.Controls.Add(Me.dgvListados)
        Me.Controls.Add(Me.lblMostrar)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConsultaListadosFacturados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmConsulta_Listados_Facturados"
        CType(Me.dgvListados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvListados As System.Windows.Forms.DataGridView
    Friend WithEvents lblMostrar As System.Windows.Forms.Label
    Friend WithEvents btnEliminar_Listados As System.Windows.Forms.Button

    Private Sub btnEliminar_Listados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar_Listados.Click

        Dim elimina As Integer
        elimina = MessageBox.Show("Esta seguro que desea eliminar los listados facturados anteriores al mes pasado?", "Eliminar Listados Facturados", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If elimina = vbYes Then

            Dim hoy As Date = Now.Date
            Dim fecha As Date = DateAdd(DateInterval.Day, -30, hoy)

            Dim oListaListado = oLogica_Listado.consultarFacturadosEliminar(fecha)

            For i As Integer = 0 To oListaListado.Count - 1
                oLogica_Listado.eliminar(oListaListado(i).IdListado)
            Next

            dgvListados.Rows.Clear()
            llenarListados()
        End If
    End Sub

    Private Sub FrmConsulta_Listados_Facturados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarListados()
    End Sub

    Private Sub llenarListados()
        Dim tblListados = oLogica_Listado.consultarTodosFacturados

        With tblListados
            For i = 0 To .Rows.Count - 1
                dgvListados.Rows.Add(.Rows(i).Item(0), .Rows(i).Item(1), .Rows(i).Item(2), .Rows(i).Item(3), Format(.Rows(i).Item(4), "###,##0.00"))
            Next
        End With
    End Sub

    Private Sub FrmConsulta_Listados_Facturados_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
