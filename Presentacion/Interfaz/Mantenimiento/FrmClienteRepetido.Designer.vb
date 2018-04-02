Namespace Interfaz.Mantenimiento
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmClienteRepetido
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
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
            Me.dgvCliente1 = New System.Windows.Forms.DataGridView()
            Me.txtOtroTelefono1 = New System.Windows.Forms.TextBox()
            Me.lblOtroTelefono1 = New System.Windows.Forms.Label()
            Me.txtFax1 = New System.Windows.Forms.TextBox()
            Me.lblFax1 = New System.Windows.Forms.Label()
            Me.txtTelPrincipal1 = New System.Windows.Forms.TextBox()
            Me.lblTelefonoPrincipal1 = New System.Windows.Forms.Label()
            Me.txtSitioWeb1 = New System.Windows.Forms.TextBox()
            Me.lblSitio1 = New System.Windows.Forms.Label()
            Me.txtEmail1 = New System.Windows.Forms.TextBox()
            Me.btnGuardar = New System.Windows.Forms.Button()
            Me.btnLimpiar1 = New System.Windows.Forms.Button()
            Me.tabCliente1 = New System.Windows.Forms.TabControl()
            Me.tagPageOtrosDatos1 = New System.Windows.Forms.TabPage()
            Me.gbFacturas1 = New System.Windows.Forms.GroupBox()
            Me.lblMostrarUltimaCompra1 = New System.Windows.Forms.Label()
            Me.lblMostrarCantContado1 = New System.Windows.Forms.Label()
            Me.lblUltimaCompra1 = New System.Windows.Forms.Label()
            Me.lblCantidadContado1 = New System.Windows.Forms.Label()
            Me.gbCrédito1 = New System.Windows.Forms.GroupBox()
            Me.lblMostrarId_Credito1 = New System.Windows.Forms.Label()
            Me.lblId_Credito1 = New System.Windows.Forms.Label()
            Me.lblMostrarEstado1 = New System.Windows.Forms.Label()
            Me.txtLimite1 = New System.Windows.Forms.TextBox()
            Me.gbEnte1 = New System.Windows.Forms.GroupBox()
            Me.rbJuridico1 = New System.Windows.Forms.RadioButton()
            Me.rbFisico1 = New System.Windows.Forms.RadioButton()
            Me.gbTipo1 = New System.Windows.Forms.GroupBox()
            Me.rbPrueba1 = New System.Windows.Forms.RadioButton()
            Me.rbNormal1 = New System.Windows.Forms.RadioButton()
            Me.rbPreferencial1 = New System.Windows.Forms.RadioButton()
            Me.lblEstado1 = New System.Windows.Forms.Label()
            Me.lblLimite1 = New System.Windows.Forms.Label()
            Me.tabPageFactCredito = New System.Windows.Forms.TabPage()
            Me.lblMostrarCantidad1 = New System.Windows.Forms.Label()
            Me.lblCantidad1 = New System.Windows.Forms.Label()
            Me.lblMostrarTotal1 = New System.Windows.Forms.Label()
            Me.lblTotal1 = New System.Windows.Forms.Label()
            Me.tblFactCredito1 = New System.Windows.Forms.DataGridView()
            Me.Factura = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.lblFacturasCredito = New System.Windows.Forms.Label()
            Me.tabPageEmple1 = New System.Windows.Forms.TabPage()
            Me.gbReferencia1 = New System.Windows.Forms.GroupBox()
            Me.lblMuestraUltimoCalRef1 = New System.Windows.Forms.Label()
            Me.lblUltimoCalRef1 = New System.Windows.Forms.Label()
            Me.lblMuestraActivoRef1 = New System.Windows.Forms.Label()
            Me.lblMuestraCodRef1 = New System.Windows.Forms.Label()
            Me.lblActivoRef1 = New System.Windows.Forms.Label()
            Me.lblCodRef1 = New System.Windows.Forms.Label()
            Me.gbEmpleado1 = New System.Windows.Forms.GroupBox()
            Me.lblMuestraPuestoEmpleado1 = New System.Windows.Forms.Label()
            Me.lblMuestraCodEmpleado1 = New System.Windows.Forms.Label()
            Me.lblPuestoEmpleado1 = New System.Windows.Forms.Label()
            Me.lblCodEmpleado1 = New System.Windows.Forms.Label()
            Me.TabPageEncarg1 = New System.Windows.Forms.TabPage()
            Me.dgvEncargado1 = New System.Windows.Forms.DataGridView()
            Me.IdEncargado1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.NombreEncargado1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.txtCorreoEncarg1 = New System.Windows.Forms.TextBox()
            Me.lblCorreoEncargado = New System.Windows.Forms.Label()
            Me.txtExt1Encarg1 = New System.Windows.Forms.TextBox()
            Me.txtId_Encargado = New System.Windows.Forms.TextBox()
            Me.lblExt1_Encargado = New System.Windows.Forms.Label()
            Me.txtNombreEncarg1 = New System.Windows.Forms.TextBox()
            Me.lblTelefono2_Encargado = New System.Windows.Forms.Label()
            Me.lblTelefono1_Encargado = New System.Windows.Forms.Label()
            Me.txtTelf2Encarg1 = New System.Windows.Forms.TextBox()
            Me.lblNombre_Encargado = New System.Windows.Forms.Label()
            Me.btnModificarEncarg1 = New System.Windows.Forms.Button()
            Me.lblFax_Encargado = New System.Windows.Forms.Label()
            Me.txtFaxEncarg1 = New System.Windows.Forms.TextBox()
            Me.lblServicioEncargado = New System.Windows.Forms.Label()
            Me.txtTelf1Encarg1 = New System.Windows.Forms.TextBox()
            Me.txtServicioEncarg1 = New System.Windows.Forms.TextBox()
            Me.txtObservaciones1 = New System.Windows.Forms.TextBox()
            Me.lblObserv1 = New System.Windows.Forms.Label()
            Me.txtDireccion1 = New System.Windows.Forms.TextBox()
            Me.lblDireccion1 = New System.Windows.Forms.Label()
            Me.lblEmail1 = New System.Windows.Forms.Label()
            Me.txtSegundoApellido1 = New System.Windows.Forms.TextBox()
            Me.txtPrimerApellido1 = New System.Windows.Forms.TextBox()
            Me.lblSegundoApellido1 = New System.Windows.Forms.Label()
            Me.lblPrimerApellido1 = New System.Windows.Forms.Label()
            Me.txtCedula1 = New System.Windows.Forms.TextBox()
            Me.lblCedula1 = New System.Windows.Forms.Label()
            Me.txtNombre1 = New System.Windows.Forms.TextBox()
            Me.txtId_Cliente1 = New System.Windows.Forms.TextBox()
            Me.lblNombre1 = New System.Windows.Forms.Label()
            Me.lblId_Cliente1 = New System.Windows.Forms.Label()
            Me.dgvCliente2 = New System.Windows.Forms.DataGridView()
            Me.btnLimpiar2 = New System.Windows.Forms.Button()
            Me.txtSitioWeb2 = New System.Windows.Forms.TextBox()
            Me.txtEmail2 = New System.Windows.Forms.TextBox()
            Me.lblEmail2 = New System.Windows.Forms.Label()
            Me.tabCliente2 = New System.Windows.Forms.TabControl()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.btnTrasladarFacturasContado = New System.Windows.Forms.Button()
            Me.lblMostrarUltimaCompra2 = New System.Windows.Forms.Label()
            Me.lblMostrarCantContado2 = New System.Windows.Forms.Label()
            Me.lblUltimaCompra2 = New System.Windows.Forms.Label()
            Me.lblCantidadContado2 = New System.Windows.Forms.Label()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.btnTrasladarCredito = New System.Windows.Forms.Button()
            Me.lblMostrarId_Credito2 = New System.Windows.Forms.Label()
            Me.lblId_Credito2 = New System.Windows.Forms.Label()
            Me.gbEnte2 = New System.Windows.Forms.GroupBox()
            Me.rbJuridico2 = New System.Windows.Forms.RadioButton()
            Me.rbFisico2 = New System.Windows.Forms.RadioButton()
            Me.lblMostrarEstado2 = New System.Windows.Forms.Label()
            Me.txtLimite2 = New System.Windows.Forms.TextBox()
            Me.gbTipo2 = New System.Windows.Forms.GroupBox()
            Me.rbPrueba2 = New System.Windows.Forms.RadioButton()
            Me.rbNormal2 = New System.Windows.Forms.RadioButton()
            Me.rbPreferencial2 = New System.Windows.Forms.RadioButton()
            Me.lblEstado2 = New System.Windows.Forms.Label()
            Me.lblLimite2 = New System.Windows.Forms.Label()
            Me.TabPage2 = New System.Windows.Forms.TabPage()
            Me.tblFactCredito2 = New System.Windows.Forms.DataGridView()
            Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.lblMostrarCantidad2 = New System.Windows.Forms.Label()
            Me.lblCantidad2 = New System.Windows.Forms.Label()
            Me.lblMostrarTotal2 = New System.Windows.Forms.Label()
            Me.lblTotal2 = New System.Windows.Forms.Label()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.TabPage3 = New System.Windows.Forms.TabPage()
            Me.gbReferencia2 = New System.Windows.Forms.GroupBox()
            Me.lblMuestraUltimoCalRef2 = New System.Windows.Forms.Label()
            Me.lblUltimoCalRef2 = New System.Windows.Forms.Label()
            Me.btnTrasladarReferencia2 = New System.Windows.Forms.Button()
            Me.lblMuestraActivoRef2 = New System.Windows.Forms.Label()
            Me.lblMuestraCodRef2 = New System.Windows.Forms.Label()
            Me.lblActivo = New System.Windows.Forms.Label()
            Me.lblCodRef2 = New System.Windows.Forms.Label()
            Me.gbEmpleado2 = New System.Windows.Forms.GroupBox()
            Me.btnTrasladarEmpleado2 = New System.Windows.Forms.Button()
            Me.lblMuestraPuesto2 = New System.Windows.Forms.Label()
            Me.lblMuestraCodEmpleado2 = New System.Windows.Forms.Label()
            Me.lblPuesto2 = New System.Windows.Forms.Label()
            Me.lblCodEmpleado2 = New System.Windows.Forms.Label()
            Me.TabPageEncarg2 = New System.Windows.Forms.TabPage()
            Me.lblMostrarExtEncarg2 = New System.Windows.Forms.Label()
            Me.lblMostrarCorreoEncarg2 = New System.Windows.Forms.Label()
            Me.lblMostrarFaxEncarg2 = New System.Windows.Forms.Label()
            Me.lblMostrarServicioEncarg2 = New System.Windows.Forms.Label()
            Me.lblMostrarTel2Encarg2 = New System.Windows.Forms.Label()
            Me.lblMostrarTel1Encarg2 = New System.Windows.Forms.Label()
            Me.lblMostrarNombreEncarg2 = New System.Windows.Forms.Label()
            Me.btnTrasladarTodosEncargados = New System.Windows.Forms.Button()
            Me.lblCorreoEncarg2 = New System.Windows.Forms.Label()
            Me.lblExtEncarg2 = New System.Windows.Forms.Label()
            Me.lblTel2Encarg2 = New System.Windows.Forms.Label()
            Me.lblTel1Encarg2 = New System.Windows.Forms.Label()
            Me.lblNombreEncarg2 = New System.Windows.Forms.Label()
            Me.llblFaxEncarga2 = New System.Windows.Forms.Label()
            Me.lblServicioEncarg2 = New System.Windows.Forms.Label()
            Me.btnTrasladarEncargado = New System.Windows.Forms.Button()
            Me.dgvEncargado2 = New System.Windows.Forms.DataGridView()
            Me.IdEncargado2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.NombreEncargado2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.btnEliminar = New System.Windows.Forms.Button()
            Me.txtObserv2 = New System.Windows.Forms.TextBox()
            Me.lblObservaciones2 = New System.Windows.Forms.Label()
            Me.txtDireccion2 = New System.Windows.Forms.TextBox()
            Me.lblDireccion2 = New System.Windows.Forms.Label()
            Me.txtNombre2 = New System.Windows.Forms.TextBox()
            Me.txtId_Cliente2 = New System.Windows.Forms.TextBox()
            Me.lblNombre2 = New System.Windows.Forms.Label()
            Me.lblId_Cliente2 = New System.Windows.Forms.Label()
            Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
            Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.lblCedula2 = New System.Windows.Forms.Label()
            Me.lblSegundoApellido2 = New System.Windows.Forms.Label()
            Me.txtSegundoApellido2 = New System.Windows.Forms.TextBox()
            Me.txtCedula2 = New System.Windows.Forms.TextBox()
            Me.txtOtroTelefono2 = New System.Windows.Forms.TextBox()
            Me.lblOtroTelefono2 = New System.Windows.Forms.Label()
            Me.txtFax2 = New System.Windows.Forms.TextBox()
            Me.lblFax2 = New System.Windows.Forms.Label()
            Me.lblSitio2 = New System.Windows.Forms.Label()
            Me.txtTelPrincipal2 = New System.Windows.Forms.TextBox()
            Me.lblTelefonoPrincipal2 = New System.Windows.Forms.Label()
            Me.txtPrimerApellido2 = New System.Windows.Forms.TextBox()
            Me.lblPrimerApellido2 = New System.Windows.Forms.Label()
            Me.errorCliente = New System.Windows.Forms.ErrorProvider(Me.components)
            Me.txtIdEncargadoCliente2 = New System.Windows.Forms.TextBox()
            CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitContainer1.Panel1.SuspendLayout()
            Me.SplitContainer1.Panel2.SuspendLayout()
            Me.SplitContainer1.SuspendLayout()
            CType(Me.dgvCliente1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabCliente1.SuspendLayout()
            Me.tagPageOtrosDatos1.SuspendLayout()
            Me.gbFacturas1.SuspendLayout()
            Me.gbCrédito1.SuspendLayout()
            Me.gbEnte1.SuspendLayout()
            Me.gbTipo1.SuspendLayout()
            Me.tabPageFactCredito.SuspendLayout()
            CType(Me.tblFactCredito1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPageEmple1.SuspendLayout()
            Me.gbReferencia1.SuspendLayout()
            Me.gbEmpleado1.SuspendLayout()
            Me.TabPageEncarg1.SuspendLayout()
            CType(Me.dgvEncargado1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvCliente2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabCliente2.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.gbEnte2.SuspendLayout()
            Me.gbTipo2.SuspendLayout()
            Me.TabPage2.SuspendLayout()
            CType(Me.tblFactCredito2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabPage3.SuspendLayout()
            Me.gbReferencia2.SuspendLayout()
            Me.gbEmpleado2.SuspendLayout()
            Me.TabPageEncarg2.SuspendLayout()
            CType(Me.dgvEncargado2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.errorCliente, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'SplitContainer1
            '
            Me.SplitContainer1.Location = New System.Drawing.Point(-1, 1)
            Me.SplitContainer1.Name = "SplitContainer1"
            '
            'SplitContainer1.Panel1
            '
            Me.SplitContainer1.Panel1.AllowDrop = True
            Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control
            Me.SplitContainer1.Panel1.Controls.Add(Me.dgvCliente1)
            Me.SplitContainer1.Panel1.Controls.Add(Me.txtOtroTelefono1)
            Me.SplitContainer1.Panel1.Controls.Add(Me.lblOtroTelefono1)
            Me.SplitContainer1.Panel1.Controls.Add(Me.txtFax1)
            Me.SplitContainer1.Panel1.Controls.Add(Me.lblFax1)
            Me.SplitContainer1.Panel1.Controls.Add(Me.txtTelPrincipal1)
            Me.SplitContainer1.Panel1.Controls.Add(Me.lblTelefonoPrincipal1)
            Me.SplitContainer1.Panel1.Controls.Add(Me.txtSitioWeb1)
            Me.SplitContainer1.Panel1.Controls.Add(Me.lblSitio1)
            Me.SplitContainer1.Panel1.Controls.Add(Me.txtEmail1)
            Me.SplitContainer1.Panel1.Controls.Add(Me.btnGuardar)
            Me.SplitContainer1.Panel1.Controls.Add(Me.btnLimpiar1)
            Me.SplitContainer1.Panel1.Controls.Add(Me.tabCliente1)
            Me.SplitContainer1.Panel1.Controls.Add(Me.txtObservaciones1)
            Me.SplitContainer1.Panel1.Controls.Add(Me.lblObserv1)
            Me.SplitContainer1.Panel1.Controls.Add(Me.txtDireccion1)
            Me.SplitContainer1.Panel1.Controls.Add(Me.lblDireccion1)
            Me.SplitContainer1.Panel1.Controls.Add(Me.lblEmail1)
            Me.SplitContainer1.Panel1.Controls.Add(Me.txtSegundoApellido1)
            Me.SplitContainer1.Panel1.Controls.Add(Me.txtPrimerApellido1)
            Me.SplitContainer1.Panel1.Controls.Add(Me.lblSegundoApellido1)
            Me.SplitContainer1.Panel1.Controls.Add(Me.lblPrimerApellido1)
            Me.SplitContainer1.Panel1.Controls.Add(Me.txtCedula1)
            Me.SplitContainer1.Panel1.Controls.Add(Me.lblCedula1)
            Me.SplitContainer1.Panel1.Controls.Add(Me.txtNombre1)
            Me.SplitContainer1.Panel1.Controls.Add(Me.txtId_Cliente1)
            Me.SplitContainer1.Panel1.Controls.Add(Me.lblNombre1)
            Me.SplitContainer1.Panel1.Controls.Add(Me.lblId_Cliente1)
            '
            'SplitContainer1.Panel2
            '
            Me.SplitContainer1.Panel2.AllowDrop = True
            Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control
            Me.SplitContainer1.Panel2.Controls.Add(Me.dgvCliente2)
            Me.SplitContainer1.Panel2.Controls.Add(Me.btnLimpiar2)
            Me.SplitContainer1.Panel2.Controls.Add(Me.txtSitioWeb2)
            Me.SplitContainer1.Panel2.Controls.Add(Me.txtEmail2)
            Me.SplitContainer1.Panel2.Controls.Add(Me.lblEmail2)
            Me.SplitContainer1.Panel2.Controls.Add(Me.tabCliente2)
            Me.SplitContainer1.Panel2.Controls.Add(Me.btnEliminar)
            Me.SplitContainer1.Panel2.Controls.Add(Me.txtObserv2)
            Me.SplitContainer1.Panel2.Controls.Add(Me.lblObservaciones2)
            Me.SplitContainer1.Panel2.Controls.Add(Me.txtDireccion2)
            Me.SplitContainer1.Panel2.Controls.Add(Me.lblDireccion2)
            Me.SplitContainer1.Panel2.Controls.Add(Me.txtNombre2)
            Me.SplitContainer1.Panel2.Controls.Add(Me.txtId_Cliente2)
            Me.SplitContainer1.Panel2.Controls.Add(Me.lblNombre2)
            Me.SplitContainer1.Panel2.Controls.Add(Me.lblId_Cliente2)
            Me.SplitContainer1.Panel2.Controls.Add(Me.ShapeContainer2)
            Me.SplitContainer1.Panel2.Controls.Add(Me.lblCedula2)
            Me.SplitContainer1.Panel2.Controls.Add(Me.lblSegundoApellido2)
            Me.SplitContainer1.Panel2.Controls.Add(Me.txtSegundoApellido2)
            Me.SplitContainer1.Panel2.Controls.Add(Me.txtCedula2)
            Me.SplitContainer1.Panel2.Controls.Add(Me.txtOtroTelefono2)
            Me.SplitContainer1.Panel2.Controls.Add(Me.lblOtroTelefono2)
            Me.SplitContainer1.Panel2.Controls.Add(Me.txtFax2)
            Me.SplitContainer1.Panel2.Controls.Add(Me.lblFax2)
            Me.SplitContainer1.Panel2.Controls.Add(Me.lblSitio2)
            Me.SplitContainer1.Panel2.Controls.Add(Me.txtTelPrincipal2)
            Me.SplitContainer1.Panel2.Controls.Add(Me.lblTelefonoPrincipal2)
            Me.SplitContainer1.Panel2.Controls.Add(Me.txtPrimerApellido2)
            Me.SplitContainer1.Panel2.Controls.Add(Me.lblPrimerApellido2)
            Me.SplitContainer1.Size = New System.Drawing.Size(787, 663)
            Me.SplitContainer1.SplitterDistance = 388
            Me.SplitContainer1.TabIndex = 0
            '
            'dgvCliente1
            '
            Me.dgvCliente1.AllowUserToAddRows = False
            Me.dgvCliente1.AllowUserToDeleteRows = False
            Me.dgvCliente1.BackgroundColor = System.Drawing.Color.White
            Me.dgvCliente1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvCliente1.GridColor = System.Drawing.Color.White
            Me.dgvCliente1.Location = New System.Drawing.Point(61, 111)
            Me.dgvCliente1.MultiSelect = False
            Me.dgvCliente1.Name = "dgvCliente1"
            Me.dgvCliente1.ReadOnly = True
            Me.dgvCliente1.RowHeadersVisible = False
            Me.dgvCliente1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvCliente1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvCliente1.Size = New System.Drawing.Size(324, 105)
            Me.dgvCliente1.TabIndex = 230
            Me.dgvCliente1.Visible = False
            '
            'txtOtroTelefono1
            '
            Me.txtOtroTelefono1.Location = New System.Drawing.Point(133, 176)
            Me.txtOtroTelefono1.MaxLength = 9
            Me.txtOtroTelefono1.Name = "txtOtroTelefono1"
            Me.txtOtroTelefono1.Size = New System.Drawing.Size(90, 20)
            Me.txtOtroTelefono1.TabIndex = 245
            Me.txtOtroTelefono1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblOtroTelefono1
            '
            Me.lblOtroTelefono1.AutoSize = True
            Me.lblOtroTelefono1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblOtroTelefono1.Location = New System.Drawing.Point(132, 160)
            Me.lblOtroTelefono1.Name = "lblOtroTelefono1"
            Me.lblOtroTelefono1.Size = New System.Drawing.Size(84, 15)
            Me.lblOtroTelefono1.TabIndex = 244
            Me.lblOtroTelefono1.Text = "Otro Teléfono"
            '
            'txtFax1
            '
            Me.txtFax1.Location = New System.Drawing.Point(257, 176)
            Me.txtFax1.MaxLength = 9
            Me.txtFax1.Name = "txtFax1"
            Me.txtFax1.Size = New System.Drawing.Size(90, 20)
            Me.txtFax1.TabIndex = 243
            Me.txtFax1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblFax1
            '
            Me.lblFax1.AutoSize = True
            Me.lblFax1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFax1.Location = New System.Drawing.Point(255, 160)
            Me.lblFax1.Name = "lblFax1"
            Me.lblFax1.Size = New System.Drawing.Size(76, 15)
            Me.lblFax1.TabIndex = 242
            Me.lblFax1.Text = "Fax Principal"
            '
            'txtTelPrincipal1
            '
            Me.txtTelPrincipal1.Location = New System.Drawing.Point(10, 176)
            Me.txtTelPrincipal1.MaxLength = 9
            Me.txtTelPrincipal1.Name = "txtTelPrincipal1"
            Me.txtTelPrincipal1.Size = New System.Drawing.Size(90, 20)
            Me.txtTelPrincipal1.TabIndex = 241
            Me.txtTelPrincipal1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblTelefonoPrincipal1
            '
            Me.lblTelefonoPrincipal1.AutoSize = True
            Me.lblTelefonoPrincipal1.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTelefonoPrincipal1.Location = New System.Drawing.Point(8, 160)
            Me.lblTelefonoPrincipal1.Name = "lblTelefonoPrincipal1"
            Me.lblTelefonoPrincipal1.Size = New System.Drawing.Size(100, 14)
            Me.lblTelefonoPrincipal1.TabIndex = 240
            Me.lblTelefonoPrincipal1.Text = "Teléfono Principal"
            '
            'txtSitioWeb1
            '
            Me.txtSitioWeb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSitioWeb1.Location = New System.Drawing.Point(189, 222)
            Me.txtSitioWeb1.MaxLength = 45
            Me.txtSitioWeb1.Name = "txtSitioWeb1"
            Me.txtSitioWeb1.Size = New System.Drawing.Size(182, 20)
            Me.txtSitioWeb1.TabIndex = 222
            '
            'lblSitio1
            '
            Me.lblSitio1.AutoSize = True
            Me.lblSitio1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSitio1.Location = New System.Drawing.Point(188, 204)
            Me.lblSitio1.Name = "lblSitio1"
            Me.lblSitio1.Size = New System.Drawing.Size(61, 15)
            Me.lblSitio1.TabIndex = 221
            Me.lblSitio1.Text = "Sitio Web"
            '
            'txtEmail1
            '
            Me.txtEmail1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtEmail1.Location = New System.Drawing.Point(9, 222)
            Me.txtEmail1.MaxLength = 45
            Me.txtEmail1.Name = "txtEmail1"
            Me.txtEmail1.Size = New System.Drawing.Size(174, 20)
            Me.txtEmail1.TabIndex = 220
            '
            'btnGuardar
            '
            Me.btnGuardar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = Global.Presentacion.My.Resources.Resources.Guardar
            Me.btnGuardar.Location = New System.Drawing.Point(0, 0)
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(65, 57)
            Me.btnGuardar.TabIndex = 212
            Me.btnGuardar.Text = "Guardar"
            Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnGuardar.UseVisualStyleBackColor = True
            '
            'btnLimpiar1
            '
            Me.btnLimpiar1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnLimpiar1.Image = Global.Presentacion.My.Resources.Resources.Limpiar
            Me.btnLimpiar1.Location = New System.Drawing.Point(64, 0)
            Me.btnLimpiar1.Name = "btnLimpiar1"
            Me.btnLimpiar1.Size = New System.Drawing.Size(65, 57)
            Me.btnLimpiar1.TabIndex = 211
            Me.btnLimpiar1.Text = "Limpiar"
            Me.btnLimpiar1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnLimpiar1.UseVisualStyleBackColor = True
            '
            'tabCliente1
            '
            Me.tabCliente1.Controls.Add(Me.tagPageOtrosDatos1)
            Me.tabCliente1.Controls.Add(Me.tabPageFactCredito)
            Me.tabCliente1.Controls.Add(Me.tabPageEmple1)
            Me.tabCliente1.Controls.Add(Me.TabPageEncarg1)
            Me.tabCliente1.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tabCliente1.Location = New System.Drawing.Point(11, 368)
            Me.tabCliente1.Name = "tabCliente1"
            Me.tabCliente1.SelectedIndex = 0
            Me.tabCliente1.Size = New System.Drawing.Size(359, 248)
            Me.tabCliente1.TabIndex = 210
            '
            'tagPageOtrosDatos1
            '
            Me.tagPageOtrosDatos1.Controls.Add(Me.gbFacturas1)
            Me.tagPageOtrosDatos1.Controls.Add(Me.gbCrédito1)
            Me.tagPageOtrosDatos1.Location = New System.Drawing.Point(4, 22)
            Me.tagPageOtrosDatos1.Name = "tagPageOtrosDatos1"
            Me.tagPageOtrosDatos1.Padding = New System.Windows.Forms.Padding(3)
            Me.tagPageOtrosDatos1.Size = New System.Drawing.Size(351, 222)
            Me.tagPageOtrosDatos1.TabIndex = 4
            Me.tagPageOtrosDatos1.Text = "Otros Datos"
            Me.tagPageOtrosDatos1.UseVisualStyleBackColor = True
            '
            'gbFacturas1
            '
            Me.gbFacturas1.Controls.Add(Me.lblMostrarUltimaCompra1)
            Me.gbFacturas1.Controls.Add(Me.lblMostrarCantContado1)
            Me.gbFacturas1.Controls.Add(Me.lblUltimaCompra1)
            Me.gbFacturas1.Controls.Add(Me.lblCantidadContado1)
            Me.gbFacturas1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbFacturas1.Location = New System.Drawing.Point(6, 130)
            Me.gbFacturas1.Name = "gbFacturas1"
            Me.gbFacturas1.Size = New System.Drawing.Size(341, 82)
            Me.gbFacturas1.TabIndex = 228
            Me.gbFacturas1.TabStop = False
            Me.gbFacturas1.Text = "Facturas Contado"
            '
            'lblMostrarUltimaCompra1
            '
            Me.lblMostrarUltimaCompra1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarUltimaCompra1.Location = New System.Drawing.Point(102, 49)
            Me.lblMostrarUltimaCompra1.Name = "lblMostrarUltimaCompra1"
            Me.lblMostrarUltimaCompra1.Size = New System.Drawing.Size(83, 23)
            Me.lblMostrarUltimaCompra1.TabIndex = 227
            '
            'lblMostrarCantContado1
            '
            Me.lblMostrarCantContado1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarCantContado1.Location = New System.Drawing.Point(70, 19)
            Me.lblMostrarCantContado1.Name = "lblMostrarCantContado1"
            Me.lblMostrarCantContado1.Size = New System.Drawing.Size(46, 23)
            Me.lblMostrarCantContado1.TabIndex = 225
            '
            'lblUltimaCompra1
            '
            Me.lblUltimaCompra1.AutoSize = True
            Me.lblUltimaCompra1.Location = New System.Drawing.Point(6, 50)
            Me.lblUltimaCompra1.Name = "lblUltimaCompra1"
            Me.lblUltimaCompra1.Size = New System.Drawing.Size(93, 15)
            Me.lblUltimaCompra1.TabIndex = 226
            Me.lblUltimaCompra1.Text = "Ultima Compra:"
            Me.lblUltimaCompra1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblCantidadContado1
            '
            Me.lblCantidadContado1.AutoSize = True
            Me.lblCantidadContado1.Location = New System.Drawing.Point(6, 22)
            Me.lblCantidadContado1.Name = "lblCantidadContado1"
            Me.lblCantidadContado1.Size = New System.Drawing.Size(58, 15)
            Me.lblCantidadContado1.TabIndex = 225
            Me.lblCantidadContado1.Text = "Cantidad:"
            '
            'gbCrédito1
            '
            Me.gbCrédito1.Controls.Add(Me.lblMostrarId_Credito1)
            Me.gbCrédito1.Controls.Add(Me.lblId_Credito1)
            Me.gbCrédito1.Controls.Add(Me.lblMostrarEstado1)
            Me.gbCrédito1.Controls.Add(Me.txtLimite1)
            Me.gbCrédito1.Controls.Add(Me.gbEnte1)
            Me.gbCrédito1.Controls.Add(Me.gbTipo1)
            Me.gbCrédito1.Controls.Add(Me.lblEstado1)
            Me.gbCrédito1.Controls.Add(Me.lblLimite1)
            Me.gbCrédito1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbCrédito1.Location = New System.Drawing.Point(4, 6)
            Me.gbCrédito1.Name = "gbCrédito1"
            Me.gbCrédito1.Size = New System.Drawing.Size(344, 115)
            Me.gbCrédito1.TabIndex = 227
            Me.gbCrédito1.TabStop = False
            Me.gbCrédito1.Text = "Crédito"
            '
            'lblMostrarId_Credito1
            '
            Me.lblMostrarId_Credito1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarId_Credito1.Location = New System.Drawing.Point(4, 31)
            Me.lblMostrarId_Credito1.Name = "lblMostrarId_Credito1"
            Me.lblMostrarId_Credito1.Size = New System.Drawing.Size(46, 23)
            Me.lblMostrarId_Credito1.TabIndex = 224
            '
            'lblId_Credito1
            '
            Me.lblId_Credito1.AutoSize = True
            Me.lblId_Credito1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblId_Credito1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.lblId_Credito1.Location = New System.Drawing.Point(0, 16)
            Me.lblId_Credito1.Name = "lblId_Credito1"
            Me.lblId_Credito1.Size = New System.Drawing.Size(62, 15)
            Me.lblId_Credito1.TabIndex = 223
            Me.lblId_Credito1.Text = "Id Crédito"
            '
            'lblMostrarEstado1
            '
            Me.lblMostrarEstado1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarEstado1.Location = New System.Drawing.Point(91, 32)
            Me.lblMostrarEstado1.Name = "lblMostrarEstado1"
            Me.lblMostrarEstado1.Size = New System.Drawing.Size(85, 23)
            Me.lblMostrarEstado1.TabIndex = 221
            '
            'txtLimite1
            '
            Me.txtLimite1.Enabled = False
            Me.txtLimite1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtLimite1.Location = New System.Drawing.Point(7, 83)
            Me.txtLimite1.Name = "txtLimite1"
            Me.txtLimite1.Size = New System.Drawing.Size(82, 20)
            Me.txtLimite1.TabIndex = 220
            '
            'gbEnte1
            '
            Me.gbEnte1.Controls.Add(Me.rbJuridico1)
            Me.gbEnte1.Controls.Add(Me.rbFisico1)
            Me.gbEnte1.Enabled = False
            Me.gbEnte1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbEnte1.Location = New System.Drawing.Point(126, 55)
            Me.gbEnte1.Name = "gbEnte1"
            Me.gbEnte1.Size = New System.Drawing.Size(79, 54)
            Me.gbEnte1.TabIndex = 218
            Me.gbEnte1.TabStop = False
            Me.gbEnte1.Text = "Cliente"
            '
            'rbJuridico1
            '
            Me.rbJuridico1.AutoSize = True
            Me.rbJuridico1.Location = New System.Drawing.Point(6, 34)
            Me.rbJuridico1.Name = "rbJuridico1"
            Me.rbJuridico1.Size = New System.Drawing.Size(68, 19)
            Me.rbJuridico1.TabIndex = 1
            Me.rbJuridico1.Text = "Jurídico"
            Me.rbJuridico1.UseVisualStyleBackColor = True
            '
            'rbFisico1
            '
            Me.rbFisico1.AutoSize = True
            Me.rbFisico1.Location = New System.Drawing.Point(6, 15)
            Me.rbFisico1.Name = "rbFisico1"
            Me.rbFisico1.Size = New System.Drawing.Size(55, 19)
            Me.rbFisico1.TabIndex = 0
            Me.rbFisico1.Text = "Físico"
            Me.rbFisico1.UseVisualStyleBackColor = True
            '
            'gbTipo1
            '
            Me.gbTipo1.Controls.Add(Me.rbPrueba1)
            Me.gbTipo1.Controls.Add(Me.rbNormal1)
            Me.gbTipo1.Controls.Add(Me.rbPreferencial1)
            Me.gbTipo1.Enabled = False
            Me.gbTipo1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTipo1.Location = New System.Drawing.Point(222, 25)
            Me.gbTipo1.Name = "gbTipo1"
            Me.gbTipo1.Size = New System.Drawing.Size(108, 80)
            Me.gbTipo1.TabIndex = 217
            Me.gbTipo1.TabStop = False
            Me.gbTipo1.Text = "Tipo"
            '
            'rbPrueba1
            '
            Me.rbPrueba1.AutoSize = True
            Me.rbPrueba1.Location = New System.Drawing.Point(12, 57)
            Me.rbPrueba1.Name = "rbPrueba1"
            Me.rbPrueba1.Size = New System.Drawing.Size(64, 19)
            Me.rbPrueba1.TabIndex = 2
            Me.rbPrueba1.Text = "Prueba"
            Me.rbPrueba1.UseVisualStyleBackColor = True
            '
            'rbNormal1
            '
            Me.rbNormal1.AutoSize = True
            Me.rbNormal1.Location = New System.Drawing.Point(12, 38)
            Me.rbNormal1.Name = "rbNormal1"
            Me.rbNormal1.Size = New System.Drawing.Size(66, 19)
            Me.rbNormal1.TabIndex = 1
            Me.rbNormal1.Text = "Normal"
            Me.rbNormal1.UseVisualStyleBackColor = True
            '
            'rbPreferencial1
            '
            Me.rbPreferencial1.AutoSize = True
            Me.rbPreferencial1.Location = New System.Drawing.Point(12, 19)
            Me.rbPreferencial1.Name = "rbPreferencial1"
            Me.rbPreferencial1.Size = New System.Drawing.Size(92, 19)
            Me.rbPreferencial1.TabIndex = 0
            Me.rbPreferencial1.Text = "Preferencial"
            Me.rbPreferencial1.UseVisualStyleBackColor = True
            '
            'lblEstado1
            '
            Me.lblEstado1.AutoSize = True
            Me.lblEstado1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEstado1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.lblEstado1.Location = New System.Drawing.Point(88, 17)
            Me.lblEstado1.Name = "lblEstado1"
            Me.lblEstado1.Size = New System.Drawing.Size(82, 15)
            Me.lblEstado1.TabIndex = 216
            Me.lblEstado1.Text = "Estado Actual"
            '
            'lblLimite1
            '
            Me.lblLimite1.AutoSize = True
            Me.lblLimite1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblLimite1.Location = New System.Drawing.Point(4, 65)
            Me.lblLimite1.Name = "lblLimite1"
            Me.lblLimite1.Size = New System.Drawing.Size(42, 15)
            Me.lblLimite1.TabIndex = 209
            Me.lblLimite1.Text = "Límite"
            '
            'tabPageFactCredito
            '
            Me.tabPageFactCredito.Controls.Add(Me.lblMostrarCantidad1)
            Me.tabPageFactCredito.Controls.Add(Me.lblCantidad1)
            Me.tabPageFactCredito.Controls.Add(Me.lblMostrarTotal1)
            Me.tabPageFactCredito.Controls.Add(Me.lblTotal1)
            Me.tabPageFactCredito.Controls.Add(Me.tblFactCredito1)
            Me.tabPageFactCredito.Controls.Add(Me.lblFacturasCredito)
            Me.tabPageFactCredito.Location = New System.Drawing.Point(4, 22)
            Me.tabPageFactCredito.Name = "tabPageFactCredito"
            Me.tabPageFactCredito.Padding = New System.Windows.Forms.Padding(3)
            Me.tabPageFactCredito.Size = New System.Drawing.Size(351, 222)
            Me.tabPageFactCredito.TabIndex = 1
            Me.tabPageFactCredito.Text = "Facturas Credito"
            Me.tabPageFactCredito.UseVisualStyleBackColor = True
            '
            'lblMostrarCantidad1
            '
            Me.lblMostrarCantidad1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarCantidad1.Location = New System.Drawing.Point(272, 55)
            Me.lblMostrarCantidad1.Name = "lblMostrarCantidad1"
            Me.lblMostrarCantidad1.Size = New System.Drawing.Size(55, 23)
            Me.lblMostrarCantidad1.TabIndex = 228
            Me.lblMostrarCantidad1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblCantidad1
            '
            Me.lblCantidad1.AutoSize = True
            Me.lblCantidad1.Location = New System.Drawing.Point(272, 32)
            Me.lblCantidad1.Name = "lblCantidad1"
            Me.lblCantidad1.Size = New System.Drawing.Size(47, 13)
            Me.lblCantidad1.TabIndex = 227
            Me.lblCantidad1.Text = "Cantidad"
            '
            'lblMostrarTotal1
            '
            Me.lblMostrarTotal1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarTotal1.Location = New System.Drawing.Point(250, 105)
            Me.lblMostrarTotal1.Name = "lblMostrarTotal1"
            Me.lblMostrarTotal1.Size = New System.Drawing.Size(98, 27)
            Me.lblMostrarTotal1.TabIndex = 226
            Me.lblMostrarTotal1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblTotal1
            '
            Me.lblTotal1.AutoSize = True
            Me.lblTotal1.Location = New System.Drawing.Point(281, 90)
            Me.lblTotal1.Name = "lblTotal1"
            Me.lblTotal1.Size = New System.Drawing.Size(30, 13)
            Me.lblTotal1.TabIndex = 225
            Me.lblTotal1.Text = "Total"
            '
            'tblFactCredito1
            '
            Me.tblFactCredito1.AllowUserToAddRows = False
            Me.tblFactCredito1.AllowUserToDeleteRows = False
            Me.tblFactCredito1.AllowUserToResizeColumns = False
            Me.tblFactCredito1.AllowUserToResizeRows = False
            Me.tblFactCredito1.BackgroundColor = System.Drawing.Color.White
            Me.tblFactCredito1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.tblFactCredito1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Factura, Me.Fecha, Me.Monto})
            Me.tblFactCredito1.GridColor = System.Drawing.Color.White
            Me.tblFactCredito1.Location = New System.Drawing.Point(7, 32)
            Me.tblFactCredito1.Name = "tblFactCredito1"
            Me.tblFactCredito1.ReadOnly = True
            Me.tblFactCredito1.RowHeadersVisible = False
            Me.tblFactCredito1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.tblFactCredito1.Size = New System.Drawing.Size(237, 183)
            Me.tblFactCredito1.TabIndex = 224
            '
            'Factura
            '
            Me.Factura.HeaderText = "Factura"
            Me.Factura.Name = "Factura"
            Me.Factura.ReadOnly = True
            Me.Factura.Width = 55
            '
            'Fecha
            '
            DataGridViewCellStyle1.Format = "d"
            DataGridViewCellStyle1.NullValue = Nothing
            Me.Fecha.DefaultCellStyle = DataGridViewCellStyle1
            Me.Fecha.HeaderText = "Fecha"
            Me.Fecha.Name = "Fecha"
            Me.Fecha.ReadOnly = True
            Me.Fecha.Width = 75
            '
            'Monto
            '
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle2.Format = "C2"
            DataGridViewCellStyle2.NullValue = Nothing
            Me.Monto.DefaultCellStyle = DataGridViewCellStyle2
            Me.Monto.HeaderText = "Monto"
            Me.Monto.Name = "Monto"
            Me.Monto.ReadOnly = True
            Me.Monto.Width = 85
            '
            'lblFacturasCredito
            '
            Me.lblFacturasCredito.AutoSize = True
            Me.lblFacturasCredito.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFacturasCredito.ForeColor = System.Drawing.Color.Black
            Me.lblFacturasCredito.Location = New System.Drawing.Point(107, 3)
            Me.lblFacturasCredito.Name = "lblFacturasCredito"
            Me.lblFacturasCredito.Size = New System.Drawing.Size(141, 23)
            Me.lblFacturasCredito.TabIndex = 223
            Me.lblFacturasCredito.Text = "Facturas Crédito"
            '
            'tabPageEmple1
            '
            Me.tabPageEmple1.Controls.Add(Me.gbReferencia1)
            Me.tabPageEmple1.Controls.Add(Me.gbEmpleado1)
            Me.tabPageEmple1.Location = New System.Drawing.Point(4, 22)
            Me.tabPageEmple1.Name = "tabPageEmple1"
            Me.tabPageEmple1.Padding = New System.Windows.Forms.Padding(3)
            Me.tabPageEmple1.Size = New System.Drawing.Size(351, 222)
            Me.tabPageEmple1.TabIndex = 5
            Me.tabPageEmple1.Text = "Empleado/Referencia"
            Me.tabPageEmple1.UseVisualStyleBackColor = True
            '
            'gbReferencia1
            '
            Me.gbReferencia1.Controls.Add(Me.lblMuestraUltimoCalRef1)
            Me.gbReferencia1.Controls.Add(Me.lblUltimoCalRef1)
            Me.gbReferencia1.Controls.Add(Me.lblMuestraActivoRef1)
            Me.gbReferencia1.Controls.Add(Me.lblMuestraCodRef1)
            Me.gbReferencia1.Controls.Add(Me.lblActivoRef1)
            Me.gbReferencia1.Controls.Add(Me.lblCodRef1)
            Me.gbReferencia1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbReferencia1.Location = New System.Drawing.Point(7, 104)
            Me.gbReferencia1.Name = "gbReferencia1"
            Me.gbReferencia1.Size = New System.Drawing.Size(341, 101)
            Me.gbReferencia1.TabIndex = 232
            Me.gbReferencia1.TabStop = False
            Me.gbReferencia1.Text = "Referencia"
            '
            'lblMuestraUltimoCalRef1
            '
            Me.lblMuestraUltimoCalRef1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMuestraUltimoCalRef1.Location = New System.Drawing.Point(112, 70)
            Me.lblMuestraUltimoCalRef1.Name = "lblMuestraUltimoCalRef1"
            Me.lblMuestraUltimoCalRef1.Size = New System.Drawing.Size(83, 23)
            Me.lblMuestraUltimoCalRef1.TabIndex = 230
            '
            'lblUltimoCalRef1
            '
            Me.lblUltimoCalRef1.AutoSize = True
            Me.lblUltimoCalRef1.Location = New System.Drawing.Point(6, 78)
            Me.lblUltimoCalRef1.Name = "lblUltimoCalRef1"
            Me.lblUltimoCalRef1.Size = New System.Drawing.Size(90, 15)
            Me.lblUltimoCalRef1.TabIndex = 229
            Me.lblUltimoCalRef1.Text = "Ultimo Cálculo:"
            Me.lblUltimoCalRef1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblMuestraActivoRef1
            '
            Me.lblMuestraActivoRef1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMuestraActivoRef1.Location = New System.Drawing.Point(102, 49)
            Me.lblMuestraActivoRef1.Name = "lblMuestraActivoRef1"
            Me.lblMuestraActivoRef1.Size = New System.Drawing.Size(83, 23)
            Me.lblMuestraActivoRef1.TabIndex = 227
            '
            'lblMuestraCodRef1
            '
            Me.lblMuestraCodRef1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMuestraCodRef1.Location = New System.Drawing.Point(70, 19)
            Me.lblMuestraCodRef1.Name = "lblMuestraCodRef1"
            Me.lblMuestraCodRef1.Size = New System.Drawing.Size(46, 23)
            Me.lblMuestraCodRef1.TabIndex = 225
            '
            'lblActivoRef1
            '
            Me.lblActivoRef1.AutoSize = True
            Me.lblActivoRef1.Location = New System.Drawing.Point(6, 50)
            Me.lblActivoRef1.Name = "lblActivoRef1"
            Me.lblActivoRef1.Size = New System.Drawing.Size(45, 15)
            Me.lblActivoRef1.TabIndex = 226
            Me.lblActivoRef1.Text = "Activo:"
            Me.lblActivoRef1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblCodRef1
            '
            Me.lblCodRef1.AutoSize = True
            Me.lblCodRef1.Location = New System.Drawing.Point(6, 22)
            Me.lblCodRef1.Name = "lblCodRef1"
            Me.lblCodRef1.Size = New System.Drawing.Size(48, 15)
            Me.lblCodRef1.TabIndex = 225
            Me.lblCodRef1.Text = "Código:"
            '
            'gbEmpleado1
            '
            Me.gbEmpleado1.Controls.Add(Me.lblMuestraPuestoEmpleado1)
            Me.gbEmpleado1.Controls.Add(Me.lblMuestraCodEmpleado1)
            Me.gbEmpleado1.Controls.Add(Me.lblPuestoEmpleado1)
            Me.gbEmpleado1.Controls.Add(Me.lblCodEmpleado1)
            Me.gbEmpleado1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbEmpleado1.Location = New System.Drawing.Point(7, 14)
            Me.gbEmpleado1.Name = "gbEmpleado1"
            Me.gbEmpleado1.Size = New System.Drawing.Size(341, 96)
            Me.gbEmpleado1.TabIndex = 231
            Me.gbEmpleado1.TabStop = False
            Me.gbEmpleado1.Text = "Empleado"
            '
            'lblMuestraPuestoEmpleado1
            '
            Me.lblMuestraPuestoEmpleado1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMuestraPuestoEmpleado1.Location = New System.Drawing.Point(70, 50)
            Me.lblMuestraPuestoEmpleado1.Name = "lblMuestraPuestoEmpleado1"
            Me.lblMuestraPuestoEmpleado1.Size = New System.Drawing.Size(184, 23)
            Me.lblMuestraPuestoEmpleado1.TabIndex = 227
            '
            'lblMuestraCodEmpleado1
            '
            Me.lblMuestraCodEmpleado1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMuestraCodEmpleado1.Location = New System.Drawing.Point(70, 19)
            Me.lblMuestraCodEmpleado1.Name = "lblMuestraCodEmpleado1"
            Me.lblMuestraCodEmpleado1.Size = New System.Drawing.Size(46, 23)
            Me.lblMuestraCodEmpleado1.TabIndex = 225
            '
            'lblPuestoEmpleado1
            '
            Me.lblPuestoEmpleado1.AutoSize = True
            Me.lblPuestoEmpleado1.Location = New System.Drawing.Point(6, 50)
            Me.lblPuestoEmpleado1.Name = "lblPuestoEmpleado1"
            Me.lblPuestoEmpleado1.Size = New System.Drawing.Size(48, 15)
            Me.lblPuestoEmpleado1.TabIndex = 226
            Me.lblPuestoEmpleado1.Text = "Puesto:"
            Me.lblPuestoEmpleado1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblCodEmpleado1
            '
            Me.lblCodEmpleado1.AutoSize = True
            Me.lblCodEmpleado1.Location = New System.Drawing.Point(6, 22)
            Me.lblCodEmpleado1.Name = "lblCodEmpleado1"
            Me.lblCodEmpleado1.Size = New System.Drawing.Size(48, 15)
            Me.lblCodEmpleado1.TabIndex = 225
            Me.lblCodEmpleado1.Text = "Código:"
            '
            'TabPageEncarg1
            '
            Me.TabPageEncarg1.Controls.Add(Me.dgvEncargado1)
            Me.TabPageEncarg1.Controls.Add(Me.txtCorreoEncarg1)
            Me.TabPageEncarg1.Controls.Add(Me.lblCorreoEncargado)
            Me.TabPageEncarg1.Controls.Add(Me.txtExt1Encarg1)
            Me.TabPageEncarg1.Controls.Add(Me.txtId_Encargado)
            Me.TabPageEncarg1.Controls.Add(Me.lblExt1_Encargado)
            Me.TabPageEncarg1.Controls.Add(Me.txtNombreEncarg1)
            Me.TabPageEncarg1.Controls.Add(Me.lblTelefono2_Encargado)
            Me.TabPageEncarg1.Controls.Add(Me.lblTelefono1_Encargado)
            Me.TabPageEncarg1.Controls.Add(Me.txtTelf2Encarg1)
            Me.TabPageEncarg1.Controls.Add(Me.lblNombre_Encargado)
            Me.TabPageEncarg1.Controls.Add(Me.btnModificarEncarg1)
            Me.TabPageEncarg1.Controls.Add(Me.lblFax_Encargado)
            Me.TabPageEncarg1.Controls.Add(Me.txtFaxEncarg1)
            Me.TabPageEncarg1.Controls.Add(Me.lblServicioEncargado)
            Me.TabPageEncarg1.Controls.Add(Me.txtTelf1Encarg1)
            Me.TabPageEncarg1.Controls.Add(Me.txtServicioEncarg1)
            Me.TabPageEncarg1.Location = New System.Drawing.Point(4, 22)
            Me.TabPageEncarg1.Name = "TabPageEncarg1"
            Me.TabPageEncarg1.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPageEncarg1.Size = New System.Drawing.Size(351, 222)
            Me.TabPageEncarg1.TabIndex = 6
            Me.TabPageEncarg1.Text = "Encargados"
            Me.TabPageEncarg1.UseVisualStyleBackColor = True
            '
            'dgvEncargado1
            '
            Me.dgvEncargado1.AllowUserToAddRows = False
            Me.dgvEncargado1.AllowUserToDeleteRows = False
            Me.dgvEncargado1.AllowUserToResizeColumns = False
            Me.dgvEncargado1.AllowUserToResizeRows = False
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvEncargado1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
            Me.dgvEncargado1.BackgroundColor = System.Drawing.Color.White
            Me.dgvEncargado1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvEncargado1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdEncargado1, Me.NombreEncargado1})
            Me.dgvEncargado1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.dgvEncargado1.Location = New System.Drawing.Point(6, 121)
            Me.dgvEncargado1.MultiSelect = False
            Me.dgvEncargado1.Name = "dgvEncargado1"
            Me.dgvEncargado1.ReadOnly = True
            Me.dgvEncargado1.RowHeadersVisible = False
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvEncargado1.RowsDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvEncargado1.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvEncargado1.RowTemplate.Height = 18
            Me.dgvEncargado1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvEncargado1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvEncargado1.Size = New System.Drawing.Size(336, 93)
            Me.dgvEncargado1.TabIndex = 62
            '
            'IdEncargado1
            '
            Me.IdEncargado1.HeaderText = "Id"
            Me.IdEncargado1.Name = "IdEncargado1"
            Me.IdEncargado1.ReadOnly = True
            Me.IdEncargado1.Visible = False
            '
            'NombreEncargado1
            '
            Me.NombreEncargado1.HeaderText = "Nombre"
            Me.NombreEncargado1.Name = "NombreEncargado1"
            Me.NombreEncargado1.ReadOnly = True
            Me.NombreEncargado1.Width = 315
            '
            'txtCorreoEncarg1
            '
            Me.txtCorreoEncarg1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtCorreoEncarg1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCorreoEncarg1.Location = New System.Drawing.Point(6, 95)
            Me.txtCorreoEncarg1.MaxLength = 100
            Me.txtCorreoEncarg1.Name = "txtCorreoEncarg1"
            Me.txtCorreoEncarg1.Size = New System.Drawing.Size(208, 20)
            Me.txtCorreoEncarg1.TabIndex = 59
            '
            'lblCorreoEncargado
            '
            Me.lblCorreoEncargado.AutoSize = True
            Me.lblCorreoEncargado.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblCorreoEncargado.Location = New System.Drawing.Point(6, 80)
            Me.lblCorreoEncargado.Name = "lblCorreoEncargado"
            Me.lblCorreoEncargado.Size = New System.Drawing.Size(39, 13)
            Me.lblCorreoEncargado.TabIndex = 64
            Me.lblCorreoEncargado.Text = "Correo"
            '
            'txtExt1Encarg1
            '
            Me.txtExt1Encarg1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtExt1Encarg1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtExt1Encarg1.Location = New System.Drawing.Point(220, 95)
            Me.txtExt1Encarg1.MaxLength = 4
            Me.txtExt1Encarg1.Name = "txtExt1Encarg1"
            Me.txtExt1Encarg1.Size = New System.Drawing.Size(50, 20)
            Me.txtExt1Encarg1.TabIndex = 55
            Me.txtExt1Encarg1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtId_Encargado
            '
            Me.txtId_Encargado.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtId_Encargado.Enabled = False
            Me.txtId_Encargado.Location = New System.Drawing.Point(265, 147)
            Me.txtId_Encargado.Name = "txtId_Encargado"
            Me.txtId_Encargado.Size = New System.Drawing.Size(50, 21)
            Me.txtId_Encargado.TabIndex = 61
            Me.txtId_Encargado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.txtId_Encargado.Visible = False
            '
            'lblExt1_Encargado
            '
            Me.lblExt1_Encargado.AutoSize = True
            Me.lblExt1_Encargado.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblExt1_Encargado.Location = New System.Drawing.Point(218, 80)
            Me.lblExt1_Encargado.Name = "lblExt1_Encargado"
            Me.lblExt1_Encargado.Size = New System.Drawing.Size(35, 13)
            Me.lblExt1_Encargado.TabIndex = 63
            Me.lblExt1_Encargado.Text = "Ext #1"
            '
            'txtNombreEncarg1
            '
            Me.txtNombreEncarg1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtNombreEncarg1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreEncarg1.Location = New System.Drawing.Point(5, 19)
            Me.txtNombreEncarg1.MaxLength = 40
            Me.txtNombreEncarg1.Name = "txtNombreEncarg1"
            Me.txtNombreEncarg1.Size = New System.Drawing.Size(265, 20)
            Me.txtNombreEncarg1.TabIndex = 48
            '
            'lblTelefono2_Encargado
            '
            Me.lblTelefono2_Encargado.AutoSize = True
            Me.lblTelefono2_Encargado.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblTelefono2_Encargado.Location = New System.Drawing.Point(197, 41)
            Me.lblTelefono2_Encargado.Name = "lblTelefono2_Encargado"
            Me.lblTelefono2_Encargado.Size = New System.Drawing.Size(62, 13)
            Me.lblTelefono2_Encargado.TabIndex = 49
            Me.lblTelefono2_Encargado.Text = "Teléfono #2"
            '
            'lblTelefono1_Encargado
            '
            Me.lblTelefono1_Encargado.AutoSize = True
            Me.lblTelefono1_Encargado.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblTelefono1_Encargado.Location = New System.Drawing.Point(272, 3)
            Me.lblTelefono1_Encargado.Name = "lblTelefono1_Encargado"
            Me.lblTelefono1_Encargado.Size = New System.Drawing.Size(61, 13)
            Me.lblTelefono1_Encargado.TabIndex = 51
            Me.lblTelefono1_Encargado.Text = "Teléfono #1"
            '
            'txtTelf2Encarg1
            '
            Me.txtTelf2Encarg1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtTelf2Encarg1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTelf2Encarg1.Location = New System.Drawing.Point(199, 57)
            Me.txtTelf2Encarg1.MaxLength = 9
            Me.txtTelf2Encarg1.Name = "txtTelf2Encarg1"
            Me.txtTelf2Encarg1.Size = New System.Drawing.Size(70, 20)
            Me.txtTelf2Encarg1.TabIndex = 52
            Me.txtTelf2Encarg1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblNombre_Encargado
            '
            Me.lblNombre_Encargado.AutoSize = True
            Me.lblNombre_Encargado.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblNombre_Encargado.Location = New System.Drawing.Point(3, 3)
            Me.lblNombre_Encargado.Name = "lblNombre_Encargado"
            Me.lblNombre_Encargado.Size = New System.Drawing.Size(45, 13)
            Me.lblNombre_Encargado.TabIndex = 54
            Me.lblNombre_Encargado.Text = "Nombre"
            '
            'btnModificarEncarg1
            '
            Me.btnModificarEncarg1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnModificarEncarg1.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModificarEncarg1.Location = New System.Drawing.Point(280, 87)
            Me.btnModificarEncarg1.Name = "btnModificarEncarg1"
            Me.btnModificarEncarg1.Size = New System.Drawing.Size(65, 29)
            Me.btnModificarEncarg1.TabIndex = 60
            Me.btnModificarEncarg1.Text = "Modificar"
            Me.btnModificarEncarg1.UseVisualStyleBackColor = True
            '
            'lblFax_Encargado
            '
            Me.lblFax_Encargado.AutoSize = True
            Me.lblFax_Encargado.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblFax_Encargado.Location = New System.Drawing.Point(276, 41)
            Me.lblFax_Encargado.Name = "lblFax_Encargado"
            Me.lblFax_Encargado.Size = New System.Drawing.Size(23, 13)
            Me.lblFax_Encargado.TabIndex = 56
            Me.lblFax_Encargado.Text = "Fax"
            '
            'txtFaxEncarg1
            '
            Me.txtFaxEncarg1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtFaxEncarg1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFaxEncarg1.Location = New System.Drawing.Point(275, 57)
            Me.txtFaxEncarg1.MaxLength = 9
            Me.txtFaxEncarg1.Name = "txtFaxEncarg1"
            Me.txtFaxEncarg1.Size = New System.Drawing.Size(70, 20)
            Me.txtFaxEncarg1.TabIndex = 53
            Me.txtFaxEncarg1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblServicioEncargado
            '
            Me.lblServicioEncargado.AutoSize = True
            Me.lblServicioEncargado.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblServicioEncargado.Location = New System.Drawing.Point(3, 41)
            Me.lblServicioEncargado.Name = "lblServicioEncargado"
            Me.lblServicioEncargado.Size = New System.Drawing.Size(43, 13)
            Me.lblServicioEncargado.TabIndex = 58
            Me.lblServicioEncargado.Text = "Servicio"
            '
            'txtTelf1Encarg1
            '
            Me.txtTelf1Encarg1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtTelf1Encarg1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTelf1Encarg1.Location = New System.Drawing.Point(275, 19)
            Me.txtTelf1Encarg1.MaxLength = 9
            Me.txtTelf1Encarg1.Name = "txtTelf1Encarg1"
            Me.txtTelf1Encarg1.Size = New System.Drawing.Size(70, 20)
            Me.txtTelf1Encarg1.TabIndex = 50
            Me.txtTelf1Encarg1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtServicioEncarg1
            '
            Me.txtServicioEncarg1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtServicioEncarg1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtServicioEncarg1.Location = New System.Drawing.Point(5, 57)
            Me.txtServicioEncarg1.MaxLength = 50
            Me.txtServicioEncarg1.Name = "txtServicioEncarg1"
            Me.txtServicioEncarg1.Size = New System.Drawing.Size(187, 20)
            Me.txtServicioEncarg1.TabIndex = 57
            '
            'txtObservaciones1
            '
            Me.txtObservaciones1.Location = New System.Drawing.Point(11, 320)
            Me.txtObservaciones1.MaxLength = 180
            Me.txtObservaciones1.Multiline = True
            Me.txtObservaciones1.Name = "txtObservaciones1"
            Me.txtObservaciones1.Size = New System.Drawing.Size(362, 42)
            Me.txtObservaciones1.TabIndex = 207
            '
            'lblObserv1
            '
            Me.lblObserv1.AutoSize = True
            Me.lblObserv1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblObserv1.Location = New System.Drawing.Point(11, 302)
            Me.lblObserv1.Name = "lblObserv1"
            Me.lblObserv1.Size = New System.Drawing.Size(87, 15)
            Me.lblObserv1.TabIndex = 209
            Me.lblObserv1.Text = "Observaciones"
            '
            'txtDireccion1
            '
            Me.txtDireccion1.Location = New System.Drawing.Point(11, 259)
            Me.txtDireccion1.MaxLength = 100
            Me.txtDireccion1.Multiline = True
            Me.txtDireccion1.Name = "txtDireccion1"
            Me.txtDireccion1.Size = New System.Drawing.Size(362, 39)
            Me.txtDireccion1.TabIndex = 206
            '
            'lblDireccion1
            '
            Me.lblDireccion1.AutoSize = True
            Me.lblDireccion1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDireccion1.Location = New System.Drawing.Point(11, 241)
            Me.lblDireccion1.Name = "lblDireccion1"
            Me.lblDireccion1.Size = New System.Drawing.Size(59, 15)
            Me.lblDireccion1.TabIndex = 208
            Me.lblDireccion1.Text = "Dirección"
            '
            'lblEmail1
            '
            Me.lblEmail1.AutoSize = True
            Me.lblEmail1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEmail1.Location = New System.Drawing.Point(8, 204)
            Me.lblEmail1.Name = "lblEmail1"
            Me.lblEmail1.Size = New System.Drawing.Size(37, 15)
            Me.lblEmail1.TabIndex = 205
            Me.lblEmail1.Text = "Email"
            '
            'txtSegundoApellido1
            '
            Me.txtSegundoApellido1.Location = New System.Drawing.Point(136, 132)
            Me.txtSegundoApellido1.MaxLength = 15
            Me.txtSegundoApellido1.Name = "txtSegundoApellido1"
            Me.txtSegundoApellido1.Size = New System.Drawing.Size(120, 20)
            Me.txtSegundoApellido1.TabIndex = 195
            '
            'txtPrimerApellido1
            '
            Me.txtPrimerApellido1.Location = New System.Drawing.Point(10, 132)
            Me.txtPrimerApellido1.MaxLength = 15
            Me.txtPrimerApellido1.Name = "txtPrimerApellido1"
            Me.txtPrimerApellido1.Size = New System.Drawing.Size(120, 20)
            Me.txtPrimerApellido1.TabIndex = 194
            '
            'lblSegundoApellido1
            '
            Me.lblSegundoApellido1.AutoSize = True
            Me.lblSegundoApellido1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSegundoApellido1.Location = New System.Drawing.Point(133, 114)
            Me.lblSegundoApellido1.Name = "lblSegundoApellido1"
            Me.lblSegundoApellido1.Size = New System.Drawing.Size(104, 15)
            Me.lblSegundoApellido1.TabIndex = 196
            Me.lblSegundoApellido1.Text = "Segundo Apellido"
            '
            'lblPrimerApellido1
            '
            Me.lblPrimerApellido1.AutoSize = True
            Me.lblPrimerApellido1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPrimerApellido1.Location = New System.Drawing.Point(7, 114)
            Me.lblPrimerApellido1.Name = "lblPrimerApellido1"
            Me.lblPrimerApellido1.Size = New System.Drawing.Size(93, 15)
            Me.lblPrimerApellido1.TabIndex = 193
            Me.lblPrimerApellido1.Text = "Primer Apellido"
            '
            'txtCedula1
            '
            Me.txtCedula1.Location = New System.Drawing.Point(265, 132)
            Me.txtCedula1.MaxLength = 18
            Me.txtCedula1.Name = "txtCedula1"
            Me.txtCedula1.Size = New System.Drawing.Size(107, 20)
            Me.txtCedula1.TabIndex = 191
            '
            'lblCedula1
            '
            Me.lblCedula1.AutoSize = True
            Me.lblCedula1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCedula1.Location = New System.Drawing.Point(262, 114)
            Me.lblCedula1.Name = "lblCedula1"
            Me.lblCedula1.Size = New System.Drawing.Size(44, 15)
            Me.lblCedula1.TabIndex = 192
            Me.lblCedula1.Text = "Cédula"
            '
            'txtNombre1
            '
            Me.txtNombre1.Location = New System.Drawing.Point(61, 91)
            Me.txtNombre1.MaxLength = 60
            Me.txtNombre1.Name = "txtNombre1"
            Me.txtNombre1.Size = New System.Drawing.Size(311, 20)
            Me.txtNombre1.TabIndex = 189
            '
            'txtId_Cliente1
            '
            Me.txtId_Cliente1.Location = New System.Drawing.Point(10, 91)
            Me.txtId_Cliente1.MaxLength = 5
            Me.txtId_Cliente1.Name = "txtId_Cliente1"
            Me.txtId_Cliente1.Size = New System.Drawing.Size(45, 20)
            Me.txtId_Cliente1.TabIndex = 188
            '
            'lblNombre1
            '
            Me.lblNombre1.AutoSize = True
            Me.lblNombre1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombre1.Location = New System.Drawing.Point(59, 73)
            Me.lblNombre1.Name = "lblNombre1"
            Me.lblNombre1.Size = New System.Drawing.Size(53, 15)
            Me.lblNombre1.TabIndex = 190
            Me.lblNombre1.Text = "Nombre"
            '
            'lblId_Cliente1
            '
            Me.lblId_Cliente1.AutoSize = True
            Me.lblId_Cliente1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblId_Cliente1.Location = New System.Drawing.Point(7, 72)
            Me.lblId_Cliente1.Name = "lblId_Cliente1"
            Me.lblId_Cliente1.Size = New System.Drawing.Size(18, 15)
            Me.lblId_Cliente1.TabIndex = 187
            Me.lblId_Cliente1.Text = "Id"
            '
            'dgvCliente2
            '
            Me.dgvCliente2.AllowUserToAddRows = False
            Me.dgvCliente2.AllowUserToDeleteRows = False
            Me.dgvCliente2.BackgroundColor = System.Drawing.Color.White
            Me.dgvCliente2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvCliente2.GridColor = System.Drawing.Color.White
            Me.dgvCliente2.Location = New System.Drawing.Point(74, 111)
            Me.dgvCliente2.MultiSelect = False
            Me.dgvCliente2.Name = "dgvCliente2"
            Me.dgvCliente2.ReadOnly = True
            Me.dgvCliente2.RowHeadersVisible = False
            Me.dgvCliente2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvCliente2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvCliente2.Size = New System.Drawing.Size(311, 105)
            Me.dgvCliente2.TabIndex = 247
            Me.dgvCliente2.Visible = False
            '
            'btnLimpiar2
            '
            Me.btnLimpiar2.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnLimpiar2.Image = Global.Presentacion.My.Resources.Resources.Limpiar
            Me.btnLimpiar2.Location = New System.Drawing.Point(64, 0)
            Me.btnLimpiar2.Name = "btnLimpiar2"
            Me.btnLimpiar2.Size = New System.Drawing.Size(65, 57)
            Me.btnLimpiar2.TabIndex = 231
            Me.btnLimpiar2.Text = "Limpiar"
            Me.btnLimpiar2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnLimpiar2.UseVisualStyleBackColor = True
            '
            'txtSitioWeb2
            '
            Me.txtSitioWeb2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSitioWeb2.Location = New System.Drawing.Point(203, 222)
            Me.txtSitioWeb2.MaxLength = 45
            Me.txtSitioWeb2.Name = "txtSitioWeb2"
            Me.txtSitioWeb2.Size = New System.Drawing.Size(182, 20)
            Me.txtSitioWeb2.TabIndex = 257
            '
            'txtEmail2
            '
            Me.txtEmail2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtEmail2.Location = New System.Drawing.Point(23, 222)
            Me.txtEmail2.MaxLength = 45
            Me.txtEmail2.Name = "txtEmail2"
            Me.txtEmail2.Size = New System.Drawing.Size(163, 20)
            Me.txtEmail2.TabIndex = 255
            '
            'lblEmail2
            '
            Me.lblEmail2.AutoSize = True
            Me.lblEmail2.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEmail2.Location = New System.Drawing.Point(22, 204)
            Me.lblEmail2.Name = "lblEmail2"
            Me.lblEmail2.Size = New System.Drawing.Size(37, 15)
            Me.lblEmail2.TabIndex = 254
            Me.lblEmail2.Text = "Email"
            '
            'tabCliente2
            '
            Me.tabCliente2.Controls.Add(Me.TabPage1)
            Me.tabCliente2.Controls.Add(Me.TabPage2)
            Me.tabCliente2.Controls.Add(Me.TabPage3)
            Me.tabCliente2.Controls.Add(Me.TabPageEncarg2)
            Me.tabCliente2.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tabCliente2.Location = New System.Drawing.Point(22, 368)
            Me.tabCliente2.Name = "tabCliente2"
            Me.tabCliente2.SelectedIndex = 0
            Me.tabCliente2.Size = New System.Drawing.Size(359, 248)
            Me.tabCliente2.TabIndex = 239
            '
            'TabPage1
            '
            Me.TabPage1.Controls.Add(Me.GroupBox1)
            Me.TabPage1.Controls.Add(Me.GroupBox2)
            Me.TabPage1.Location = New System.Drawing.Point(4, 22)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage1.Size = New System.Drawing.Size(351, 222)
            Me.TabPage1.TabIndex = 4
            Me.TabPage1.Text = "Otros Datos"
            Me.TabPage1.UseVisualStyleBackColor = True
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.btnTrasladarFacturasContado)
            Me.GroupBox1.Controls.Add(Me.lblMostrarUltimaCompra2)
            Me.GroupBox1.Controls.Add(Me.lblMostrarCantContado2)
            Me.GroupBox1.Controls.Add(Me.lblUltimaCompra2)
            Me.GroupBox1.Controls.Add(Me.lblCantidadContado2)
            Me.GroupBox1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(7, 147)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(341, 67)
            Me.GroupBox1.TabIndex = 228
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Facturas Contado"
            '
            'btnTrasladarFacturasContado
            '
            Me.btnTrasladarFacturasContado.Enabled = False
            Me.btnTrasladarFacturasContado.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnTrasladarFacturasContado.Image = Global.Presentacion.My.Resources.Resources.flecha_izquierda
            Me.btnTrasladarFacturasContado.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnTrasladarFacturasContado.Location = New System.Drawing.Point(260, 19)
            Me.btnTrasladarFacturasContado.Name = "btnTrasladarFacturasContado"
            Me.btnTrasladarFacturasContado.Size = New System.Drawing.Size(65, 40)
            Me.btnTrasladarFacturasContado.TabIndex = 232
            Me.btnTrasladarFacturasContado.Text = "Trasladar"
            Me.btnTrasladarFacturasContado.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnTrasladarFacturasContado.UseVisualStyleBackColor = True
            '
            'lblMostrarUltimaCompra2
            '
            Me.lblMostrarUltimaCompra2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarUltimaCompra2.Location = New System.Drawing.Point(102, 49)
            Me.lblMostrarUltimaCompra2.Name = "lblMostrarUltimaCompra2"
            Me.lblMostrarUltimaCompra2.Size = New System.Drawing.Size(83, 23)
            Me.lblMostrarUltimaCompra2.TabIndex = 227
            '
            'lblMostrarCantContado2
            '
            Me.lblMostrarCantContado2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarCantContado2.Location = New System.Drawing.Point(70, 19)
            Me.lblMostrarCantContado2.Name = "lblMostrarCantContado2"
            Me.lblMostrarCantContado2.Size = New System.Drawing.Size(46, 23)
            Me.lblMostrarCantContado2.TabIndex = 225
            '
            'lblUltimaCompra2
            '
            Me.lblUltimaCompra2.AutoSize = True
            Me.lblUltimaCompra2.Location = New System.Drawing.Point(6, 50)
            Me.lblUltimaCompra2.Name = "lblUltimaCompra2"
            Me.lblUltimaCompra2.Size = New System.Drawing.Size(93, 15)
            Me.lblUltimaCompra2.TabIndex = 226
            Me.lblUltimaCompra2.Text = "Ultima Compra:"
            Me.lblUltimaCompra2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblCantidadContado2
            '
            Me.lblCantidadContado2.AutoSize = True
            Me.lblCantidadContado2.Location = New System.Drawing.Point(6, 22)
            Me.lblCantidadContado2.Name = "lblCantidadContado2"
            Me.lblCantidadContado2.Size = New System.Drawing.Size(58, 15)
            Me.lblCantidadContado2.TabIndex = 225
            Me.lblCantidadContado2.Text = "Cantidad:"
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.btnTrasladarCredito)
            Me.GroupBox2.Controls.Add(Me.lblMostrarId_Credito2)
            Me.GroupBox2.Controls.Add(Me.lblId_Credito2)
            Me.GroupBox2.Controls.Add(Me.gbEnte2)
            Me.GroupBox2.Controls.Add(Me.lblMostrarEstado2)
            Me.GroupBox2.Controls.Add(Me.txtLimite2)
            Me.GroupBox2.Controls.Add(Me.gbTipo2)
            Me.GroupBox2.Controls.Add(Me.lblEstado2)
            Me.GroupBox2.Controls.Add(Me.lblLimite2)
            Me.GroupBox2.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.Location = New System.Drawing.Point(4, 6)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(344, 135)
            Me.GroupBox2.TabIndex = 227
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Crédito"
            '
            'btnTrasladarCredito
            '
            Me.btnTrasladarCredito.Enabled = False
            Me.btnTrasladarCredito.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnTrasladarCredito.Image = Global.Presentacion.My.Resources.Resources.flecha_izquierda
            Me.btnTrasladarCredito.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnTrasladarCredito.Location = New System.Drawing.Point(263, 77)
            Me.btnTrasladarCredito.Name = "btnTrasladarCredito"
            Me.btnTrasladarCredito.Size = New System.Drawing.Size(65, 40)
            Me.btnTrasladarCredito.TabIndex = 230
            Me.btnTrasladarCredito.Text = "Trasladar"
            Me.btnTrasladarCredito.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnTrasladarCredito.UseVisualStyleBackColor = True
            '
            'lblMostrarId_Credito2
            '
            Me.lblMostrarId_Credito2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarId_Credito2.Location = New System.Drawing.Point(64, 17)
            Me.lblMostrarId_Credito2.Name = "lblMostrarId_Credito2"
            Me.lblMostrarId_Credito2.Size = New System.Drawing.Size(46, 23)
            Me.lblMostrarId_Credito2.TabIndex = 224
            '
            'lblId_Credito2
            '
            Me.lblId_Credito2.AutoSize = True
            Me.lblId_Credito2.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblId_Credito2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.lblId_Credito2.Location = New System.Drawing.Point(0, 21)
            Me.lblId_Credito2.Name = "lblId_Credito2"
            Me.lblId_Credito2.Size = New System.Drawing.Size(62, 15)
            Me.lblId_Credito2.TabIndex = 223
            Me.lblId_Credito2.Text = "Id Crédito"
            '
            'gbEnte2
            '
            Me.gbEnte2.Controls.Add(Me.rbJuridico2)
            Me.gbEnte2.Controls.Add(Me.rbFisico2)
            Me.gbEnte2.Enabled = False
            Me.gbEnte2.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbEnte2.Location = New System.Drawing.Point(140, 68)
            Me.gbEnte2.Name = "gbEnte2"
            Me.gbEnte2.Size = New System.Drawing.Size(79, 54)
            Me.gbEnte2.TabIndex = 218
            Me.gbEnte2.TabStop = False
            Me.gbEnte2.Text = "Cliente"
            '
            'rbJuridico2
            '
            Me.rbJuridico2.AutoSize = True
            Me.rbJuridico2.Location = New System.Drawing.Point(6, 34)
            Me.rbJuridico2.Name = "rbJuridico2"
            Me.rbJuridico2.Size = New System.Drawing.Size(68, 19)
            Me.rbJuridico2.TabIndex = 1
            Me.rbJuridico2.Text = "Jurídico"
            Me.rbJuridico2.UseVisualStyleBackColor = True
            '
            'rbFisico2
            '
            Me.rbFisico2.AutoSize = True
            Me.rbFisico2.Location = New System.Drawing.Point(6, 15)
            Me.rbFisico2.Name = "rbFisico2"
            Me.rbFisico2.Size = New System.Drawing.Size(55, 19)
            Me.rbFisico2.TabIndex = 0
            Me.rbFisico2.Text = "Físico"
            Me.rbFisico2.UseVisualStyleBackColor = True
            '
            'lblMostrarEstado2
            '
            Me.lblMostrarEstado2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarEstado2.Location = New System.Drawing.Point(212, 42)
            Me.lblMostrarEstado2.Name = "lblMostrarEstado2"
            Me.lblMostrarEstado2.Size = New System.Drawing.Size(85, 23)
            Me.lblMostrarEstado2.TabIndex = 221
            '
            'txtLimite2
            '
            Me.txtLimite2.Enabled = False
            Me.txtLimite2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtLimite2.Location = New System.Drawing.Point(172, 17)
            Me.txtLimite2.Name = "txtLimite2"
            Me.txtLimite2.Size = New System.Drawing.Size(82, 20)
            Me.txtLimite2.TabIndex = 220
            '
            'gbTipo2
            '
            Me.gbTipo2.Controls.Add(Me.rbPrueba2)
            Me.gbTipo2.Controls.Add(Me.rbNormal2)
            Me.gbTipo2.Controls.Add(Me.rbPreferencial2)
            Me.gbTipo2.Enabled = False
            Me.gbTipo2.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTipo2.Location = New System.Drawing.Point(7, 49)
            Me.gbTipo2.Name = "gbTipo2"
            Me.gbTipo2.Size = New System.Drawing.Size(108, 80)
            Me.gbTipo2.TabIndex = 217
            Me.gbTipo2.TabStop = False
            Me.gbTipo2.Text = "Tipo"
            '
            'rbPrueba2
            '
            Me.rbPrueba2.AutoSize = True
            Me.rbPrueba2.Location = New System.Drawing.Point(12, 57)
            Me.rbPrueba2.Name = "rbPrueba2"
            Me.rbPrueba2.Size = New System.Drawing.Size(64, 19)
            Me.rbPrueba2.TabIndex = 2
            Me.rbPrueba2.Text = "Prueba"
            Me.rbPrueba2.UseVisualStyleBackColor = True
            '
            'rbNormal2
            '
            Me.rbNormal2.AutoSize = True
            Me.rbNormal2.Location = New System.Drawing.Point(12, 38)
            Me.rbNormal2.Name = "rbNormal2"
            Me.rbNormal2.Size = New System.Drawing.Size(66, 19)
            Me.rbNormal2.TabIndex = 1
            Me.rbNormal2.Text = "Normal"
            Me.rbNormal2.UseVisualStyleBackColor = True
            '
            'rbPreferencial2
            '
            Me.rbPreferencial2.AutoSize = True
            Me.rbPreferencial2.Location = New System.Drawing.Point(12, 19)
            Me.rbPreferencial2.Name = "rbPreferencial2"
            Me.rbPreferencial2.Size = New System.Drawing.Size(92, 19)
            Me.rbPreferencial2.TabIndex = 0
            Me.rbPreferencial2.Text = "Preferencial"
            Me.rbPreferencial2.UseVisualStyleBackColor = True
            '
            'lblEstado2
            '
            Me.lblEstado2.AutoSize = True
            Me.lblEstado2.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEstado2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.lblEstado2.Location = New System.Drawing.Point(124, 46)
            Me.lblEstado2.Name = "lblEstado2"
            Me.lblEstado2.Size = New System.Drawing.Size(82, 15)
            Me.lblEstado2.TabIndex = 216
            Me.lblEstado2.Text = "Estado Actual"
            '
            'lblLimite2
            '
            Me.lblLimite2.AutoSize = True
            Me.lblLimite2.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblLimite2.Location = New System.Drawing.Point(124, 21)
            Me.lblLimite2.Name = "lblLimite2"
            Me.lblLimite2.Size = New System.Drawing.Size(42, 15)
            Me.lblLimite2.TabIndex = 209
            Me.lblLimite2.Text = "Límite"
            '
            'TabPage2
            '
            Me.TabPage2.Controls.Add(Me.tblFactCredito2)
            Me.TabPage2.Controls.Add(Me.lblMostrarCantidad2)
            Me.TabPage2.Controls.Add(Me.lblCantidad2)
            Me.TabPage2.Controls.Add(Me.lblMostrarTotal2)
            Me.TabPage2.Controls.Add(Me.lblTotal2)
            Me.TabPage2.Controls.Add(Me.Label16)
            Me.TabPage2.Location = New System.Drawing.Point(4, 22)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage2.Size = New System.Drawing.Size(351, 222)
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "Facturas Credito"
            Me.TabPage2.UseVisualStyleBackColor = True
            '
            'tblFactCredito2
            '
            Me.tblFactCredito2.AllowUserToAddRows = False
            Me.tblFactCredito2.AllowUserToDeleteRows = False
            Me.tblFactCredito2.AllowUserToResizeColumns = False
            Me.tblFactCredito2.AllowUserToResizeRows = False
            Me.tblFactCredito2.BackgroundColor = System.Drawing.Color.White
            Me.tblFactCredito2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.tblFactCredito2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
            Me.tblFactCredito2.GridColor = System.Drawing.Color.White
            Me.tblFactCredito2.Location = New System.Drawing.Point(7, 32)
            Me.tblFactCredito2.Name = "tblFactCredito2"
            Me.tblFactCredito2.ReadOnly = True
            Me.tblFactCredito2.RowHeadersVisible = False
            Me.tblFactCredito2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tblFactCredito2.RowsDefaultCellStyle = DataGridViewCellStyle7
            Me.tblFactCredito2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.tblFactCredito2.Size = New System.Drawing.Size(237, 183)
            Me.tblFactCredito2.TabIndex = 229
            '
            'DataGridViewTextBoxColumn1
            '
            Me.DataGridViewTextBoxColumn1.HeaderText = "Factura"
            Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
            Me.DataGridViewTextBoxColumn1.ReadOnly = True
            Me.DataGridViewTextBoxColumn1.Width = 55
            '
            'DataGridViewTextBoxColumn2
            '
            DataGridViewCellStyle5.Format = "d"
            DataGridViewCellStyle5.NullValue = Nothing
            Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle5
            Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha"
            Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
            Me.DataGridViewTextBoxColumn2.ReadOnly = True
            Me.DataGridViewTextBoxColumn2.Width = 75
            '
            'DataGridViewTextBoxColumn3
            '
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle6.Format = "C2"
            DataGridViewCellStyle6.NullValue = Nothing
            Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle6
            Me.DataGridViewTextBoxColumn3.HeaderText = "Monto"
            Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
            Me.DataGridViewTextBoxColumn3.ReadOnly = True
            Me.DataGridViewTextBoxColumn3.Width = 85
            '
            'lblMostrarCantidad2
            '
            Me.lblMostrarCantidad2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarCantidad2.Location = New System.Drawing.Point(272, 57)
            Me.lblMostrarCantidad2.Name = "lblMostrarCantidad2"
            Me.lblMostrarCantidad2.Size = New System.Drawing.Size(55, 23)
            Me.lblMostrarCantidad2.TabIndex = 228
            Me.lblMostrarCantidad2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblCantidad2
            '
            Me.lblCantidad2.AutoSize = True
            Me.lblCantidad2.Location = New System.Drawing.Point(272, 32)
            Me.lblCantidad2.Name = "lblCantidad2"
            Me.lblCantidad2.Size = New System.Drawing.Size(47, 13)
            Me.lblCantidad2.TabIndex = 227
            Me.lblCantidad2.Text = "Cantidad"
            '
            'lblMostrarTotal2
            '
            Me.lblMostrarTotal2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarTotal2.Location = New System.Drawing.Point(251, 105)
            Me.lblMostrarTotal2.Name = "lblMostrarTotal2"
            Me.lblMostrarTotal2.Size = New System.Drawing.Size(97, 27)
            Me.lblMostrarTotal2.TabIndex = 226
            Me.lblMostrarTotal2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblTotal2
            '
            Me.lblTotal2.AutoSize = True
            Me.lblTotal2.Location = New System.Drawing.Point(281, 90)
            Me.lblTotal2.Name = "lblTotal2"
            Me.lblTotal2.Size = New System.Drawing.Size(30, 13)
            Me.lblTotal2.TabIndex = 225
            Me.lblTotal2.Text = "Total"
            '
            'Label16
            '
            Me.Label16.AutoSize = True
            Me.Label16.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label16.ForeColor = System.Drawing.Color.Black
            Me.Label16.Location = New System.Drawing.Point(107, 3)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(141, 23)
            Me.Label16.TabIndex = 223
            Me.Label16.Text = "Facturas Crédito"
            '
            'TabPage3
            '
            Me.TabPage3.Controls.Add(Me.gbReferencia2)
            Me.TabPage3.Controls.Add(Me.gbEmpleado2)
            Me.TabPage3.Location = New System.Drawing.Point(4, 22)
            Me.TabPage3.Name = "TabPage3"
            Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage3.Size = New System.Drawing.Size(351, 222)
            Me.TabPage3.TabIndex = 5
            Me.TabPage3.Text = "Empleado/Referencia"
            Me.TabPage3.UseVisualStyleBackColor = True
            '
            'gbReferencia2
            '
            Me.gbReferencia2.Controls.Add(Me.lblMuestraUltimoCalRef2)
            Me.gbReferencia2.Controls.Add(Me.lblUltimoCalRef2)
            Me.gbReferencia2.Controls.Add(Me.btnTrasladarReferencia2)
            Me.gbReferencia2.Controls.Add(Me.lblMuestraActivoRef2)
            Me.gbReferencia2.Controls.Add(Me.lblMuestraCodRef2)
            Me.gbReferencia2.Controls.Add(Me.lblActivo)
            Me.gbReferencia2.Controls.Add(Me.lblCodRef2)
            Me.gbReferencia2.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbReferencia2.Location = New System.Drawing.Point(7, 103)
            Me.gbReferencia2.Name = "gbReferencia2"
            Me.gbReferencia2.Size = New System.Drawing.Size(341, 101)
            Me.gbReferencia2.TabIndex = 230
            Me.gbReferencia2.TabStop = False
            Me.gbReferencia2.Text = "Referencia"
            '
            'lblMuestraUltimoCalRef2
            '
            Me.lblMuestraUltimoCalRef2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMuestraUltimoCalRef2.Location = New System.Drawing.Point(112, 70)
            Me.lblMuestraUltimoCalRef2.Name = "lblMuestraUltimoCalRef2"
            Me.lblMuestraUltimoCalRef2.Size = New System.Drawing.Size(83, 23)
            Me.lblMuestraUltimoCalRef2.TabIndex = 230
            '
            'lblUltimoCalRef2
            '
            Me.lblUltimoCalRef2.AutoSize = True
            Me.lblUltimoCalRef2.Location = New System.Drawing.Point(6, 78)
            Me.lblUltimoCalRef2.Name = "lblUltimoCalRef2"
            Me.lblUltimoCalRef2.Size = New System.Drawing.Size(90, 15)
            Me.lblUltimoCalRef2.TabIndex = 229
            Me.lblUltimoCalRef2.Text = "Ultimo Cálculo:"
            Me.lblUltimoCalRef2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnTrasladarReferencia2
            '
            Me.btnTrasladarReferencia2.Enabled = False
            Me.btnTrasladarReferencia2.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnTrasladarReferencia2.Image = Global.Presentacion.My.Resources.Resources.flecha_izquierda
            Me.btnTrasladarReferencia2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnTrasladarReferencia2.Location = New System.Drawing.Point(260, 21)
            Me.btnTrasladarReferencia2.Name = "btnTrasladarReferencia2"
            Me.btnTrasladarReferencia2.Size = New System.Drawing.Size(65, 40)
            Me.btnTrasladarReferencia2.TabIndex = 228
            Me.btnTrasladarReferencia2.Text = "Trasladar"
            Me.btnTrasladarReferencia2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnTrasladarReferencia2.UseVisualStyleBackColor = True
            '
            'lblMuestraActivoRef2
            '
            Me.lblMuestraActivoRef2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMuestraActivoRef2.Location = New System.Drawing.Point(102, 49)
            Me.lblMuestraActivoRef2.Name = "lblMuestraActivoRef2"
            Me.lblMuestraActivoRef2.Size = New System.Drawing.Size(83, 23)
            Me.lblMuestraActivoRef2.TabIndex = 227
            '
            'lblMuestraCodRef2
            '
            Me.lblMuestraCodRef2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMuestraCodRef2.Location = New System.Drawing.Point(70, 19)
            Me.lblMuestraCodRef2.Name = "lblMuestraCodRef2"
            Me.lblMuestraCodRef2.Size = New System.Drawing.Size(46, 23)
            Me.lblMuestraCodRef2.TabIndex = 225
            '
            'lblActivo
            '
            Me.lblActivo.AutoSize = True
            Me.lblActivo.Location = New System.Drawing.Point(6, 50)
            Me.lblActivo.Name = "lblActivo"
            Me.lblActivo.Size = New System.Drawing.Size(45, 15)
            Me.lblActivo.TabIndex = 226
            Me.lblActivo.Text = "Activo:"
            Me.lblActivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblCodRef2
            '
            Me.lblCodRef2.AutoSize = True
            Me.lblCodRef2.Location = New System.Drawing.Point(6, 22)
            Me.lblCodRef2.Name = "lblCodRef2"
            Me.lblCodRef2.Size = New System.Drawing.Size(48, 15)
            Me.lblCodRef2.TabIndex = 225
            Me.lblCodRef2.Text = "Código:"
            '
            'gbEmpleado2
            '
            Me.gbEmpleado2.Controls.Add(Me.btnTrasladarEmpleado2)
            Me.gbEmpleado2.Controls.Add(Me.lblMuestraPuesto2)
            Me.gbEmpleado2.Controls.Add(Me.lblMuestraCodEmpleado2)
            Me.gbEmpleado2.Controls.Add(Me.lblPuesto2)
            Me.gbEmpleado2.Controls.Add(Me.lblCodEmpleado2)
            Me.gbEmpleado2.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbEmpleado2.Location = New System.Drawing.Point(7, 13)
            Me.gbEmpleado2.Name = "gbEmpleado2"
            Me.gbEmpleado2.Size = New System.Drawing.Size(341, 84)
            Me.gbEmpleado2.TabIndex = 229
            Me.gbEmpleado2.TabStop = False
            Me.gbEmpleado2.Text = "Empleado"
            '
            'btnTrasladarEmpleado2
            '
            Me.btnTrasladarEmpleado2.Enabled = False
            Me.btnTrasladarEmpleado2.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnTrasladarEmpleado2.Image = Global.Presentacion.My.Resources.Resources.flecha_izquierda
            Me.btnTrasladarEmpleado2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnTrasladarEmpleado2.Location = New System.Drawing.Point(260, 20)
            Me.btnTrasladarEmpleado2.Name = "btnTrasladarEmpleado2"
            Me.btnTrasladarEmpleado2.Size = New System.Drawing.Size(65, 40)
            Me.btnTrasladarEmpleado2.TabIndex = 228
            Me.btnTrasladarEmpleado2.Text = "Trasladar"
            Me.btnTrasladarEmpleado2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnTrasladarEmpleado2.UseVisualStyleBackColor = True
            '
            'lblMuestraPuesto2
            '
            Me.lblMuestraPuesto2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMuestraPuesto2.Location = New System.Drawing.Point(70, 50)
            Me.lblMuestraPuesto2.Name = "lblMuestraPuesto2"
            Me.lblMuestraPuesto2.Size = New System.Drawing.Size(184, 23)
            Me.lblMuestraPuesto2.TabIndex = 227
            '
            'lblMuestraCodEmpleado2
            '
            Me.lblMuestraCodEmpleado2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMuestraCodEmpleado2.Location = New System.Drawing.Point(70, 19)
            Me.lblMuestraCodEmpleado2.Name = "lblMuestraCodEmpleado2"
            Me.lblMuestraCodEmpleado2.Size = New System.Drawing.Size(46, 23)
            Me.lblMuestraCodEmpleado2.TabIndex = 225
            '
            'lblPuesto2
            '
            Me.lblPuesto2.AutoSize = True
            Me.lblPuesto2.Location = New System.Drawing.Point(6, 50)
            Me.lblPuesto2.Name = "lblPuesto2"
            Me.lblPuesto2.Size = New System.Drawing.Size(48, 15)
            Me.lblPuesto2.TabIndex = 226
            Me.lblPuesto2.Text = "Puesto:"
            Me.lblPuesto2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblCodEmpleado2
            '
            Me.lblCodEmpleado2.AutoSize = True
            Me.lblCodEmpleado2.Location = New System.Drawing.Point(6, 22)
            Me.lblCodEmpleado2.Name = "lblCodEmpleado2"
            Me.lblCodEmpleado2.Size = New System.Drawing.Size(48, 15)
            Me.lblCodEmpleado2.TabIndex = 225
            Me.lblCodEmpleado2.Text = "Código:"
            '
            'TabPageEncarg2
            '
            Me.TabPageEncarg2.Controls.Add(Me.lblMostrarExtEncarg2)
            Me.TabPageEncarg2.Controls.Add(Me.lblMostrarCorreoEncarg2)
            Me.TabPageEncarg2.Controls.Add(Me.lblMostrarFaxEncarg2)
            Me.TabPageEncarg2.Controls.Add(Me.lblMostrarServicioEncarg2)
            Me.TabPageEncarg2.Controls.Add(Me.lblMostrarTel2Encarg2)
            Me.TabPageEncarg2.Controls.Add(Me.lblMostrarTel1Encarg2)
            Me.TabPageEncarg2.Controls.Add(Me.lblMostrarNombreEncarg2)
            Me.TabPageEncarg2.Controls.Add(Me.btnTrasladarTodosEncargados)
            Me.TabPageEncarg2.Controls.Add(Me.lblCorreoEncarg2)
            Me.TabPageEncarg2.Controls.Add(Me.lblExtEncarg2)
            Me.TabPageEncarg2.Controls.Add(Me.lblTel2Encarg2)
            Me.TabPageEncarg2.Controls.Add(Me.lblTel1Encarg2)
            Me.TabPageEncarg2.Controls.Add(Me.lblNombreEncarg2)
            Me.TabPageEncarg2.Controls.Add(Me.llblFaxEncarga2)
            Me.TabPageEncarg2.Controls.Add(Me.lblServicioEncarg2)
            Me.TabPageEncarg2.Controls.Add(Me.btnTrasladarEncargado)
            Me.TabPageEncarg2.Controls.Add(Me.dgvEncargado2)
            Me.TabPageEncarg2.Controls.Add(Me.txtIdEncargadoCliente2)
            Me.TabPageEncarg2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TabPageEncarg2.Location = New System.Drawing.Point(4, 22)
            Me.TabPageEncarg2.Name = "TabPageEncarg2"
            Me.TabPageEncarg2.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPageEncarg2.Size = New System.Drawing.Size(351, 222)
            Me.TabPageEncarg2.TabIndex = 6
            Me.TabPageEncarg2.Text = "Encargados"
            Me.TabPageEncarg2.UseVisualStyleBackColor = True
            '
            'lblMostrarExtEncarg2
            '
            Me.lblMostrarExtEncarg2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblMostrarExtEncarg2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarExtEncarg2.Location = New System.Drawing.Point(270, 69)
            Me.lblMostrarExtEncarg2.Name = "lblMostrarExtEncarg2"
            Me.lblMostrarExtEncarg2.Size = New System.Drawing.Size(68, 13)
            Me.lblMostrarExtEncarg2.TabIndex = 244
            '
            'lblMostrarCorreoEncarg2
            '
            Me.lblMostrarCorreoEncarg2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblMostrarCorreoEncarg2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarCorreoEncarg2.Location = New System.Drawing.Point(59, 69)
            Me.lblMostrarCorreoEncarg2.Name = "lblMostrarCorreoEncarg2"
            Me.lblMostrarCorreoEncarg2.Size = New System.Drawing.Size(152, 12)
            Me.lblMostrarCorreoEncarg2.TabIndex = 243
            '
            'lblMostrarFaxEncarg2
            '
            Me.lblMostrarFaxEncarg2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblMostrarFaxEncarg2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarFaxEncarg2.Location = New System.Drawing.Point(270, 49)
            Me.lblMostrarFaxEncarg2.Name = "lblMostrarFaxEncarg2"
            Me.lblMostrarFaxEncarg2.Size = New System.Drawing.Size(68, 13)
            Me.lblMostrarFaxEncarg2.TabIndex = 242
            '
            'lblMostrarServicioEncarg2
            '
            Me.lblMostrarServicioEncarg2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblMostrarServicioEncarg2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarServicioEncarg2.Location = New System.Drawing.Point(59, 49)
            Me.lblMostrarServicioEncarg2.Name = "lblMostrarServicioEncarg2"
            Me.lblMostrarServicioEncarg2.Size = New System.Drawing.Size(152, 13)
            Me.lblMostrarServicioEncarg2.TabIndex = 241
            '
            'lblMostrarTel2Encarg2
            '
            Me.lblMostrarTel2Encarg2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblMostrarTel2Encarg2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarTel2Encarg2.Location = New System.Drawing.Point(270, 29)
            Me.lblMostrarTel2Encarg2.Name = "lblMostrarTel2Encarg2"
            Me.lblMostrarTel2Encarg2.Size = New System.Drawing.Size(68, 13)
            Me.lblMostrarTel2Encarg2.TabIndex = 240
            '
            'lblMostrarTel1Encarg2
            '
            Me.lblMostrarTel1Encarg2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblMostrarTel1Encarg2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarTel1Encarg2.Location = New System.Drawing.Point(57, 29)
            Me.lblMostrarTel1Encarg2.Name = "lblMostrarTel1Encarg2"
            Me.lblMostrarTel1Encarg2.Size = New System.Drawing.Size(68, 13)
            Me.lblMostrarTel1Encarg2.TabIndex = 239
            '
            'lblMostrarNombreEncarg2
            '
            Me.lblMostrarNombreEncarg2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblMostrarNombreEncarg2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMostrarNombreEncarg2.Location = New System.Drawing.Point(59, 5)
            Me.lblMostrarNombreEncarg2.Name = "lblMostrarNombreEncarg2"
            Me.lblMostrarNombreEncarg2.Size = New System.Drawing.Size(277, 15)
            Me.lblMostrarNombreEncarg2.TabIndex = 238
            '
            'btnTrasladarTodosEncargados
            '
            Me.btnTrasladarTodosEncargados.Enabled = False
            Me.btnTrasladarTodosEncargados.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnTrasladarTodosEncargados.Image = Global.Presentacion.My.Resources.Resources.flecha_izquierda
            Me.btnTrasladarTodosEncargados.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnTrasladarTodosEncargados.Location = New System.Drawing.Point(188, 180)
            Me.btnTrasladarTodosEncargados.Name = "btnTrasladarTodosEncargados"
            Me.btnTrasladarTodosEncargados.Size = New System.Drawing.Size(105, 40)
            Me.btnTrasladarTodosEncargados.TabIndex = 237
            Me.btnTrasladarTodosEncargados.Text = "Trasladar Todos"
            Me.btnTrasladarTodosEncargados.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnTrasladarTodosEncargados.UseVisualStyleBackColor = True
            '
            'lblCorreoEncarg2
            '
            Me.lblCorreoEncarg2.AutoSize = True
            Me.lblCorreoEncarg2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblCorreoEncarg2.Location = New System.Drawing.Point(13, 69)
            Me.lblCorreoEncarg2.Name = "lblCorreoEncarg2"
            Me.lblCorreoEncarg2.Size = New System.Drawing.Size(38, 13)
            Me.lblCorreoEncarg2.TabIndex = 236
            Me.lblCorreoEncarg2.Text = "Correo"
            '
            'lblExtEncarg2
            '
            Me.lblExtEncarg2.AutoSize = True
            Me.lblExtEncarg2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblExtEncarg2.Location = New System.Drawing.Point(219, 69)
            Me.lblExtEncarg2.Name = "lblExtEncarg2"
            Me.lblExtEncarg2.Size = New System.Drawing.Size(38, 13)
            Me.lblExtEncarg2.TabIndex = 235
            Me.lblExtEncarg2.Text = "Ext #1"
            '
            'lblTel2Encarg2
            '
            Me.lblTel2Encarg2.AutoSize = True
            Me.lblTel2Encarg2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblTel2Encarg2.Location = New System.Drawing.Point(213, 29)
            Me.lblTel2Encarg2.Name = "lblTel2Encarg2"
            Me.lblTel2Encarg2.Size = New System.Drawing.Size(47, 13)
            Me.lblTel2Encarg2.TabIndex = 230
            Me.lblTel2Encarg2.Text = "Teléf #2"
            '
            'lblTel1Encarg2
            '
            Me.lblTel1Encarg2.AutoSize = True
            Me.lblTel1Encarg2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblTel1Encarg2.Location = New System.Drawing.Point(6, 29)
            Me.lblTel1Encarg2.Name = "lblTel1Encarg2"
            Me.lblTel1Encarg2.Size = New System.Drawing.Size(47, 13)
            Me.lblTel1Encarg2.TabIndex = 231
            Me.lblTel1Encarg2.Text = "Teléf #1"
            '
            'lblNombreEncarg2
            '
            Me.lblNombreEncarg2.AutoSize = True
            Me.lblNombreEncarg2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblNombreEncarg2.Location = New System.Drawing.Point(6, 5)
            Me.lblNombreEncarg2.Name = "lblNombreEncarg2"
            Me.lblNombreEncarg2.Size = New System.Drawing.Size(44, 13)
            Me.lblNombreEncarg2.TabIndex = 232
            Me.lblNombreEncarg2.Text = "Nombre"
            '
            'llblFaxEncarga2
            '
            Me.llblFaxEncarga2.AutoSize = True
            Me.llblFaxEncarga2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.llblFaxEncarga2.Location = New System.Drawing.Point(230, 49)
            Me.llblFaxEncarga2.Name = "llblFaxEncarga2"
            Me.llblFaxEncarga2.Size = New System.Drawing.Size(24, 13)
            Me.llblFaxEncarga2.TabIndex = 233
            Me.llblFaxEncarga2.Text = "Fax"
            '
            'lblServicioEncarg2
            '
            Me.lblServicioEncarg2.AutoSize = True
            Me.lblServicioEncarg2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblServicioEncarg2.Location = New System.Drawing.Point(6, 49)
            Me.lblServicioEncarg2.Name = "lblServicioEncarg2"
            Me.lblServicioEncarg2.Size = New System.Drawing.Size(45, 13)
            Me.lblServicioEncarg2.TabIndex = 234
            Me.lblServicioEncarg2.Text = "Servicio"
            '
            'btnTrasladarEncargado
            '
            Me.btnTrasladarEncargado.Enabled = False
            Me.btnTrasladarEncargado.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnTrasladarEncargado.Image = Global.Presentacion.My.Resources.Resources.flecha_izquierda
            Me.btnTrasladarEncargado.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnTrasladarEncargado.Location = New System.Drawing.Point(70, 180)
            Me.btnTrasladarEncargado.Name = "btnTrasladarEncargado"
            Me.btnTrasladarEncargado.Size = New System.Drawing.Size(65, 40)
            Me.btnTrasladarEncargado.TabIndex = 229
            Me.btnTrasladarEncargado.Text = "Trasladar"
            Me.btnTrasladarEncargado.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnTrasladarEncargado.UseVisualStyleBackColor = True
            '
            'dgvEncargado2
            '
            Me.dgvEncargado2.AllowUserToAddRows = False
            Me.dgvEncargado2.AllowUserToDeleteRows = False
            Me.dgvEncargado2.AllowUserToResizeColumns = False
            Me.dgvEncargado2.AllowUserToResizeRows = False
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvEncargado2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
            Me.dgvEncargado2.BackgroundColor = System.Drawing.Color.White
            Me.dgvEncargado2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvEncargado2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdEncargado2, Me.NombreEncargado2})
            Me.dgvEncargado2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.dgvEncargado2.Location = New System.Drawing.Point(9, 86)
            Me.dgvEncargado2.MultiSelect = False
            Me.dgvEncargado2.Name = "dgvEncargado2"
            Me.dgvEncargado2.ReadOnly = True
            Me.dgvEncargado2.RowHeadersVisible = False
            DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvEncargado2.RowsDefaultCellStyle = DataGridViewCellStyle9
            Me.dgvEncargado2.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvEncargado2.RowTemplate.Height = 18
            Me.dgvEncargado2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvEncargado2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvEncargado2.Size = New System.Drawing.Size(336, 93)
            Me.dgvEncargado2.TabIndex = 63
            '
            'IdEncargado2
            '
            Me.IdEncargado2.HeaderText = "IdEncargado2"
            Me.IdEncargado2.Name = "IdEncargado2"
            Me.IdEncargado2.ReadOnly = True
            Me.IdEncargado2.Visible = False
            '
            'NombreEncargado2
            '
            Me.NombreEncargado2.HeaderText = "Nombre"
            Me.NombreEncargado2.Name = "NombreEncargado2"
            Me.NombreEncargado2.ReadOnly = True
            Me.NombreEncargado2.Width = 315
            '
            'btnEliminar
            '
            Me.btnEliminar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliminar.Image = Global.Presentacion.My.Resources.Resources.Eliminar
            Me.btnEliminar.Location = New System.Drawing.Point(0, 0)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(65, 57)
            Me.btnEliminar.TabIndex = 238
            Me.btnEliminar.Text = "Eliminar"
            Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnEliminar.UseVisualStyleBackColor = True
            '
            'txtObserv2
            '
            Me.txtObserv2.Location = New System.Drawing.Point(22, 319)
            Me.txtObserv2.MaxLength = 180
            Me.txtObserv2.Multiline = True
            Me.txtObserv2.Name = "txtObserv2"
            Me.txtObserv2.Size = New System.Drawing.Size(362, 42)
            Me.txtObserv2.TabIndex = 230
            '
            'lblObservaciones2
            '
            Me.lblObservaciones2.AutoSize = True
            Me.lblObservaciones2.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblObservaciones2.Location = New System.Drawing.Point(22, 301)
            Me.lblObservaciones2.Name = "lblObservaciones2"
            Me.lblObservaciones2.Size = New System.Drawing.Size(87, 15)
            Me.lblObservaciones2.TabIndex = 232
            Me.lblObservaciones2.Text = "Observaciones"
            '
            'txtDireccion2
            '
            Me.txtDireccion2.Location = New System.Drawing.Point(22, 259)
            Me.txtDireccion2.MaxLength = 100
            Me.txtDireccion2.Multiline = True
            Me.txtDireccion2.Name = "txtDireccion2"
            Me.txtDireccion2.Size = New System.Drawing.Size(362, 39)
            Me.txtDireccion2.TabIndex = 229
            '
            'lblDireccion2
            '
            Me.lblDireccion2.AutoSize = True
            Me.lblDireccion2.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDireccion2.Location = New System.Drawing.Point(22, 241)
            Me.lblDireccion2.Name = "lblDireccion2"
            Me.lblDireccion2.Size = New System.Drawing.Size(59, 15)
            Me.lblDireccion2.TabIndex = 231
            Me.lblDireccion2.Text = "Dirección"
            '
            'txtNombre2
            '
            Me.txtNombre2.Location = New System.Drawing.Point(74, 91)
            Me.txtNombre2.MaxLength = 60
            Me.txtNombre2.Name = "txtNombre2"
            Me.txtNombre2.Size = New System.Drawing.Size(311, 20)
            Me.txtNombre2.TabIndex = 213
            '
            'txtId_Cliente2
            '
            Me.txtId_Cliente2.Location = New System.Drawing.Point(23, 91)
            Me.txtId_Cliente2.MaxLength = 5
            Me.txtId_Cliente2.Name = "txtId_Cliente2"
            Me.txtId_Cliente2.Size = New System.Drawing.Size(45, 20)
            Me.txtId_Cliente2.TabIndex = 212
            '
            'lblNombre2
            '
            Me.lblNombre2.AutoSize = True
            Me.lblNombre2.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombre2.Location = New System.Drawing.Point(72, 73)
            Me.lblNombre2.Name = "lblNombre2"
            Me.lblNombre2.Size = New System.Drawing.Size(53, 15)
            Me.lblNombre2.TabIndex = 214
            Me.lblNombre2.Text = "Nombre"
            '
            'lblId_Cliente2
            '
            Me.lblId_Cliente2.AutoSize = True
            Me.lblId_Cliente2.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblId_Cliente2.Location = New System.Drawing.Point(20, 72)
            Me.lblId_Cliente2.Name = "lblId_Cliente2"
            Me.lblId_Cliente2.Size = New System.Drawing.Size(18, 15)
            Me.lblId_Cliente2.TabIndex = 211
            Me.lblId_Cliente2.Text = "Id"
            '
            'ShapeContainer2
            '
            Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
            Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
            Me.ShapeContainer2.Name = "ShapeContainer2"
            Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2})
            Me.ShapeContainer2.Size = New System.Drawing.Size(395, 663)
            Me.ShapeContainer2.TabIndex = 234
            Me.ShapeContainer2.TabStop = False
            '
            'LineShape2
            '
            Me.LineShape2.BorderWidth = 3
            Me.LineShape2.Name = "LineShape2"
            Me.LineShape2.X1 = 1
            Me.LineShape2.X2 = 1
            Me.LineShape2.Y1 = 0
            Me.LineShape2.Y2 = 648
            '
            'lblCedula2
            '
            Me.lblCedula2.AutoSize = True
            Me.lblCedula2.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCedula2.Location = New System.Drawing.Point(275, 114)
            Me.lblCedula2.Name = "lblCedula2"
            Me.lblCedula2.Size = New System.Drawing.Size(44, 15)
            Me.lblCedula2.TabIndex = 216
            Me.lblCedula2.Text = "Cédula"
            '
            'lblSegundoApellido2
            '
            Me.lblSegundoApellido2.AutoSize = True
            Me.lblSegundoApellido2.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSegundoApellido2.Location = New System.Drawing.Point(146, 114)
            Me.lblSegundoApellido2.Name = "lblSegundoApellido2"
            Me.lblSegundoApellido2.Size = New System.Drawing.Size(104, 15)
            Me.lblSegundoApellido2.TabIndex = 220
            Me.lblSegundoApellido2.Text = "Segundo Apellido"
            '
            'txtSegundoApellido2
            '
            Me.txtSegundoApellido2.Location = New System.Drawing.Point(149, 132)
            Me.txtSegundoApellido2.MaxLength = 15
            Me.txtSegundoApellido2.Name = "txtSegundoApellido2"
            Me.txtSegundoApellido2.Size = New System.Drawing.Size(120, 20)
            Me.txtSegundoApellido2.TabIndex = 219
            '
            'txtCedula2
            '
            Me.txtCedula2.Location = New System.Drawing.Point(278, 132)
            Me.txtCedula2.MaxLength = 18
            Me.txtCedula2.Name = "txtCedula2"
            Me.txtCedula2.Size = New System.Drawing.Size(107, 20)
            Me.txtCedula2.TabIndex = 215
            '
            'txtOtroTelefono2
            '
            Me.txtOtroTelefono2.Location = New System.Drawing.Point(129, 176)
            Me.txtOtroTelefono2.MaxLength = 9
            Me.txtOtroTelefono2.Name = "txtOtroTelefono2"
            Me.txtOtroTelefono2.Size = New System.Drawing.Size(90, 20)
            Me.txtOtroTelefono2.TabIndex = 252
            Me.txtOtroTelefono2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblOtroTelefono2
            '
            Me.lblOtroTelefono2.AutoSize = True
            Me.lblOtroTelefono2.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblOtroTelefono2.Location = New System.Drawing.Point(128, 160)
            Me.lblOtroTelefono2.Name = "lblOtroTelefono2"
            Me.lblOtroTelefono2.Size = New System.Drawing.Size(84, 15)
            Me.lblOtroTelefono2.TabIndex = 251
            Me.lblOtroTelefono2.Text = "Otro Teléfono"
            '
            'txtFax2
            '
            Me.txtFax2.Location = New System.Drawing.Point(235, 176)
            Me.txtFax2.MaxLength = 9
            Me.txtFax2.Name = "txtFax2"
            Me.txtFax2.Size = New System.Drawing.Size(90, 20)
            Me.txtFax2.TabIndex = 250
            Me.txtFax2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblFax2
            '
            Me.lblFax2.AutoSize = True
            Me.lblFax2.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFax2.Location = New System.Drawing.Point(233, 160)
            Me.lblFax2.Name = "lblFax2"
            Me.lblFax2.Size = New System.Drawing.Size(76, 15)
            Me.lblFax2.TabIndex = 249
            Me.lblFax2.Text = "Fax Principal"
            '
            'lblSitio2
            '
            Me.lblSitio2.AutoSize = True
            Me.lblSitio2.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSitio2.Location = New System.Drawing.Point(202, 204)
            Me.lblSitio2.Name = "lblSitio2"
            Me.lblSitio2.Size = New System.Drawing.Size(61, 15)
            Me.lblSitio2.TabIndex = 256
            Me.lblSitio2.Text = "Sitio Web"
            '
            'txtTelPrincipal2
            '
            Me.txtTelPrincipal2.Location = New System.Drawing.Point(24, 176)
            Me.txtTelPrincipal2.MaxLength = 9
            Me.txtTelPrincipal2.Name = "txtTelPrincipal2"
            Me.txtTelPrincipal2.Size = New System.Drawing.Size(90, 20)
            Me.txtTelPrincipal2.TabIndex = 248
            Me.txtTelPrincipal2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblTelefonoPrincipal2
            '
            Me.lblTelefonoPrincipal2.AutoSize = True
            Me.lblTelefonoPrincipal2.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTelefonoPrincipal2.Location = New System.Drawing.Point(22, 160)
            Me.lblTelefonoPrincipal2.Name = "lblTelefonoPrincipal2"
            Me.lblTelefonoPrincipal2.Size = New System.Drawing.Size(100, 14)
            Me.lblTelefonoPrincipal2.TabIndex = 247
            Me.lblTelefonoPrincipal2.Text = "Teléfono Principal"
            '
            'txtPrimerApellido2
            '
            Me.txtPrimerApellido2.Location = New System.Drawing.Point(23, 132)
            Me.txtPrimerApellido2.MaxLength = 15
            Me.txtPrimerApellido2.Name = "txtPrimerApellido2"
            Me.txtPrimerApellido2.Size = New System.Drawing.Size(120, 20)
            Me.txtPrimerApellido2.TabIndex = 218
            '
            'lblPrimerApellido2
            '
            Me.lblPrimerApellido2.AutoSize = True
            Me.lblPrimerApellido2.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPrimerApellido2.Location = New System.Drawing.Point(20, 114)
            Me.lblPrimerApellido2.Name = "lblPrimerApellido2"
            Me.lblPrimerApellido2.Size = New System.Drawing.Size(93, 15)
            Me.lblPrimerApellido2.TabIndex = 217
            Me.lblPrimerApellido2.Text = "Primer Apellido"
            '
            'errorCliente
            '
            Me.errorCliente.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
            Me.errorCliente.ContainerControl = Me
            '
            'txtIdEncargadoCliente2
            '
            Me.txtIdEncargadoCliente2.Location = New System.Drawing.Point(24, 121)
            Me.txtIdEncargadoCliente2.Name = "txtIdEncargadoCliente2"
            Me.txtIdEncargadoCliente2.Size = New System.Drawing.Size(64, 20)
            Me.txtIdEncargadoCliente2.TabIndex = 245
            '
            'FrmClienteRepetido
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(791, 619)
            Me.Controls.Add(Me.SplitContainer1)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmClienteRepetido"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "FrmTrasladar_Persona"
            Me.SplitContainer1.Panel1.ResumeLayout(False)
            Me.SplitContainer1.Panel1.PerformLayout()
            Me.SplitContainer1.Panel2.ResumeLayout(False)
            Me.SplitContainer1.Panel2.PerformLayout()
            CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitContainer1.ResumeLayout(False)
            CType(Me.dgvCliente1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabCliente1.ResumeLayout(False)
            Me.tagPageOtrosDatos1.ResumeLayout(False)
            Me.gbFacturas1.ResumeLayout(False)
            Me.gbFacturas1.PerformLayout()
            Me.gbCrédito1.ResumeLayout(False)
            Me.gbCrédito1.PerformLayout()
            Me.gbEnte1.ResumeLayout(False)
            Me.gbEnte1.PerformLayout()
            Me.gbTipo1.ResumeLayout(False)
            Me.gbTipo1.PerformLayout()
            Me.tabPageFactCredito.ResumeLayout(False)
            Me.tabPageFactCredito.PerformLayout()
            CType(Me.tblFactCredito1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPageEmple1.ResumeLayout(False)
            Me.gbReferencia1.ResumeLayout(False)
            Me.gbReferencia1.PerformLayout()
            Me.gbEmpleado1.ResumeLayout(False)
            Me.gbEmpleado1.PerformLayout()
            Me.TabPageEncarg1.ResumeLayout(False)
            Me.TabPageEncarg1.PerformLayout()
            CType(Me.dgvEncargado1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvCliente2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabCliente2.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.gbEnte2.ResumeLayout(False)
            Me.gbEnte2.PerformLayout()
            Me.gbTipo2.ResumeLayout(False)
            Me.gbTipo2.PerformLayout()
            Me.TabPage2.ResumeLayout(False)
            Me.TabPage2.PerformLayout()
            CType(Me.tblFactCredito2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabPage3.ResumeLayout(False)
            Me.gbReferencia2.ResumeLayout(False)
            Me.gbReferencia2.PerformLayout()
            Me.gbEmpleado2.ResumeLayout(False)
            Me.gbEmpleado2.PerformLayout()
            Me.TabPageEncarg2.ResumeLayout(False)
            Me.TabPageEncarg2.PerformLayout()
            CType(Me.dgvEncargado2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.errorCliente, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
        Friend WithEvents txtCedula1 As System.Windows.Forms.TextBox
        Friend WithEvents lblCedula1 As System.Windows.Forms.Label
        Friend WithEvents txtNombre1 As System.Windows.Forms.TextBox
        Friend WithEvents txtId_Cliente1 As System.Windows.Forms.TextBox
        Friend WithEvents lblNombre1 As System.Windows.Forms.Label
        Friend WithEvents lblId_Cliente1 As System.Windows.Forms.Label
        Friend WithEvents txtSegundoApellido1 As System.Windows.Forms.TextBox
        Friend WithEvents txtPrimerApellido1 As System.Windows.Forms.TextBox
        Friend WithEvents lblSegundoApellido1 As System.Windows.Forms.Label
        Friend WithEvents lblPrimerApellido1 As System.Windows.Forms.Label
        Friend WithEvents lblEmail1 As System.Windows.Forms.Label
        Friend WithEvents txtObservaciones1 As System.Windows.Forms.TextBox
        Friend WithEvents lblObserv1 As System.Windows.Forms.Label
        Friend WithEvents txtDireccion1 As System.Windows.Forms.TextBox
        Friend WithEvents lblDireccion1 As System.Windows.Forms.Label
        Friend WithEvents tabCliente1 As System.Windows.Forms.TabControl
        Friend WithEvents tabPageFactCredito As System.Windows.Forms.TabPage
        Friend WithEvents txtObserv2 As System.Windows.Forms.TextBox
        Friend WithEvents lblObservaciones2 As System.Windows.Forms.Label
        Friend WithEvents txtDireccion2 As System.Windows.Forms.TextBox
        Friend WithEvents lblDireccion2 As System.Windows.Forms.Label
        Friend WithEvents txtSegundoApellido2 As System.Windows.Forms.TextBox
        Friend WithEvents txtPrimerApellido2 As System.Windows.Forms.TextBox
        Friend WithEvents lblSegundoApellido2 As System.Windows.Forms.Label
        Friend WithEvents lblPrimerApellido2 As System.Windows.Forms.Label
        Friend WithEvents txtCedula2 As System.Windows.Forms.TextBox
        Friend WithEvents lblCedula2 As System.Windows.Forms.Label
        Friend WithEvents txtNombre2 As System.Windows.Forms.TextBox
        Friend WithEvents txtId_Cliente2 As System.Windows.Forms.TextBox
        Friend WithEvents lblNombre2 As System.Windows.Forms.Label
        Friend WithEvents lblId_Cliente2 As System.Windows.Forms.Label
        Friend WithEvents tagPageOtrosDatos1 As System.Windows.Forms.TabPage
        Friend WithEvents btnGuardar As System.Windows.Forms.Button
        Friend WithEvents btnLimpiar1 As System.Windows.Forms.Button
        Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents btnEliminar As System.Windows.Forms.Button
        Friend WithEvents lblLimite1 As System.Windows.Forms.Label
        Friend WithEvents lblEstado1 As System.Windows.Forms.Label
        Friend WithEvents txtLimite1 As System.Windows.Forms.TextBox
        Friend WithEvents gbEnte1 As System.Windows.Forms.GroupBox
        Friend WithEvents rbJuridico1 As System.Windows.Forms.RadioButton
        Friend WithEvents rbFisico1 As System.Windows.Forms.RadioButton
        Friend WithEvents gbTipo1 As System.Windows.Forms.GroupBox
        Friend WithEvents rbPrueba1 As System.Windows.Forms.RadioButton
        Friend WithEvents rbNormal1 As System.Windows.Forms.RadioButton
        Friend WithEvents rbPreferencial1 As System.Windows.Forms.RadioButton
        Friend WithEvents lblMostrarEstado1 As System.Windows.Forms.Label
        Friend WithEvents lblFacturasCredito As System.Windows.Forms.Label
        Friend WithEvents tblFactCredito1 As System.Windows.Forms.DataGridView
        Friend WithEvents lblMostrarTotal1 As System.Windows.Forms.Label
        Friend WithEvents lblTotal1 As System.Windows.Forms.Label
        Friend WithEvents lblMostrarId_Credito1 As System.Windows.Forms.Label
        Friend WithEvents lblId_Credito1 As System.Windows.Forms.Label
        Friend WithEvents lblUltimaCompra1 As System.Windows.Forms.Label
        Friend WithEvents lblCantidadContado1 As System.Windows.Forms.Label
        Friend WithEvents gbFacturas1 As System.Windows.Forms.GroupBox
        Friend WithEvents gbCrédito1 As System.Windows.Forms.GroupBox
        Friend WithEvents lblMostrarUltimaCompra1 As System.Windows.Forms.Label
        Friend WithEvents lblMostrarCantContado1 As System.Windows.Forms.Label
        Friend WithEvents lblMostrarCantidad1 As System.Windows.Forms.Label
        Friend WithEvents lblCantidad1 As System.Windows.Forms.Label
        Friend WithEvents tabCliente2 As System.Windows.Forms.TabControl
        Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents lblMostrarUltimaCompra2 As System.Windows.Forms.Label
        Friend WithEvents lblMostrarCantContado2 As System.Windows.Forms.Label
        Friend WithEvents lblUltimaCompra2 As System.Windows.Forms.Label
        Friend WithEvents lblCantidadContado2 As System.Windows.Forms.Label
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents lblMostrarId_Credito2 As System.Windows.Forms.Label
        Friend WithEvents lblId_Credito2 As System.Windows.Forms.Label
        Friend WithEvents lblMostrarEstado2 As System.Windows.Forms.Label
        Friend WithEvents txtLimite2 As System.Windows.Forms.TextBox
        Friend WithEvents gbEnte2 As System.Windows.Forms.GroupBox
        Friend WithEvents rbJuridico2 As System.Windows.Forms.RadioButton
        Friend WithEvents rbFisico2 As System.Windows.Forms.RadioButton
        Friend WithEvents gbTipo2 As System.Windows.Forms.GroupBox
        Friend WithEvents rbPrueba2 As System.Windows.Forms.RadioButton
        Friend WithEvents rbNormal2 As System.Windows.Forms.RadioButton
        Friend WithEvents rbPreferencial2 As System.Windows.Forms.RadioButton
        Friend WithEvents lblEstado2 As System.Windows.Forms.Label
        Friend WithEvents lblLimite2 As System.Windows.Forms.Label
        Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
        Friend WithEvents lblMostrarCantidad2 As System.Windows.Forms.Label
        Friend WithEvents lblCantidad2 As System.Windows.Forms.Label
        Friend WithEvents lblMostrarTotal2 As System.Windows.Forms.Label
        Friend WithEvents lblTotal2 As System.Windows.Forms.Label
        Friend WithEvents Label16 As System.Windows.Forms.Label
        Friend WithEvents txtSitioWeb1 As System.Windows.Forms.TextBox
        Friend WithEvents lblSitio1 As System.Windows.Forms.Label
        Friend WithEvents txtEmail1 As System.Windows.Forms.TextBox
        Friend WithEvents txtSitioWeb2 As System.Windows.Forms.TextBox
        Friend WithEvents lblSitio2 As System.Windows.Forms.Label
        Friend WithEvents txtEmail2 As System.Windows.Forms.TextBox
        Friend WithEvents lblEmail2 As System.Windows.Forms.Label
        Friend WithEvents Factura As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Monto As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents tblFactCredito2 As System.Windows.Forms.DataGridView
        Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvCliente1 As System.Windows.Forms.DataGridView
        Friend WithEvents btnLimpiar2 As System.Windows.Forms.Button
        Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
        Friend WithEvents gbReferencia2 As System.Windows.Forms.GroupBox
        Friend WithEvents btnTrasladarReferencia2 As System.Windows.Forms.Button
        Friend WithEvents lblMuestraActivoRef2 As System.Windows.Forms.Label
        Friend WithEvents lblMuestraCodRef2 As System.Windows.Forms.Label
        Friend WithEvents lblActivo As System.Windows.Forms.Label
        Friend WithEvents lblCodRef2 As System.Windows.Forms.Label
        Friend WithEvents gbEmpleado2 As System.Windows.Forms.GroupBox
        Friend WithEvents btnTrasladarEmpleado2 As System.Windows.Forms.Button
        Friend WithEvents lblMuestraPuesto2 As System.Windows.Forms.Label
        Friend WithEvents lblMuestraCodEmpleado2 As System.Windows.Forms.Label
        Friend WithEvents lblPuesto2 As System.Windows.Forms.Label
        Friend WithEvents lblCodEmpleado2 As System.Windows.Forms.Label
        Friend WithEvents lblMuestraUltimoCalRef2 As System.Windows.Forms.Label
        Friend WithEvents lblUltimoCalRef2 As System.Windows.Forms.Label
        Friend WithEvents tabPageEmple1 As System.Windows.Forms.TabPage
        Friend WithEvents gbReferencia1 As System.Windows.Forms.GroupBox
        Friend WithEvents lblMuestraUltimoCalRef1 As System.Windows.Forms.Label
        Friend WithEvents lblUltimoCalRef1 As System.Windows.Forms.Label
        Friend WithEvents lblMuestraActivoRef1 As System.Windows.Forms.Label
        Friend WithEvents lblMuestraCodRef1 As System.Windows.Forms.Label
        Friend WithEvents lblActivoRef1 As System.Windows.Forms.Label
        Friend WithEvents lblCodRef1 As System.Windows.Forms.Label
        Friend WithEvents gbEmpleado1 As System.Windows.Forms.GroupBox
        Friend WithEvents lblMuestraPuestoEmpleado1 As System.Windows.Forms.Label
        Friend WithEvents lblMuestraCodEmpleado1 As System.Windows.Forms.Label
        Friend WithEvents lblPuestoEmpleado1 As System.Windows.Forms.Label
        Friend WithEvents lblCodEmpleado1 As System.Windows.Forms.Label
        Friend WithEvents errorCliente As System.Windows.Forms.ErrorProvider
        Friend WithEvents btnTrasladarCredito As System.Windows.Forms.Button
        Friend WithEvents btnTrasladarFacturasContado As System.Windows.Forms.Button
        Friend WithEvents txtOtroTelefono1 As System.Windows.Forms.TextBox
        Friend WithEvents lblOtroTelefono1 As System.Windows.Forms.Label
        Friend WithEvents txtFax1 As System.Windows.Forms.TextBox
        Friend WithEvents lblFax1 As System.Windows.Forms.Label
        Friend WithEvents txtTelPrincipal1 As System.Windows.Forms.TextBox
        Friend WithEvents lblTelefonoPrincipal1 As System.Windows.Forms.Label
        Friend WithEvents txtOtroTelefono2 As System.Windows.Forms.TextBox
        Friend WithEvents lblOtroTelefono2 As System.Windows.Forms.Label
        Friend WithEvents lblTelefonoPrincipal2 As System.Windows.Forms.Label
        Friend WithEvents txtFax2 As System.Windows.Forms.TextBox
        Friend WithEvents txtTelPrincipal2 As System.Windows.Forms.TextBox
        Friend WithEvents lblFax2 As System.Windows.Forms.Label
        Friend WithEvents dgvCliente2 As System.Windows.Forms.DataGridView
        Friend WithEvents TabPageEncarg1 As System.Windows.Forms.TabPage
        Friend WithEvents txtCorreoEncarg1 As System.Windows.Forms.TextBox
        Friend WithEvents lblCorreoEncargado As System.Windows.Forms.Label
        Friend WithEvents dgvEncargado1 As System.Windows.Forms.DataGridView
        Friend WithEvents txtExt1Encarg1 As System.Windows.Forms.TextBox
        Friend WithEvents txtId_Encargado As System.Windows.Forms.TextBox
        Friend WithEvents lblExt1_Encargado As System.Windows.Forms.Label
        Friend WithEvents txtNombreEncarg1 As System.Windows.Forms.TextBox
        Friend WithEvents lblTelefono2_Encargado As System.Windows.Forms.Label
        Friend WithEvents lblTelefono1_Encargado As System.Windows.Forms.Label
        Friend WithEvents txtTelf2Encarg1 As System.Windows.Forms.TextBox
        Friend WithEvents lblNombre_Encargado As System.Windows.Forms.Label
        Friend WithEvents btnModificarEncarg1 As System.Windows.Forms.Button
        Friend WithEvents lblFax_Encargado As System.Windows.Forms.Label
        Friend WithEvents txtFaxEncarg1 As System.Windows.Forms.TextBox
        Friend WithEvents lblServicioEncargado As System.Windows.Forms.Label
        Friend WithEvents txtTelf1Encarg1 As System.Windows.Forms.TextBox
        Friend WithEvents txtServicioEncarg1 As System.Windows.Forms.TextBox
        Friend WithEvents TabPageEncarg2 As System.Windows.Forms.TabPage
        Friend WithEvents btnTrasladarTodosEncargados As System.Windows.Forms.Button
        Friend WithEvents dgvEncargado2 As System.Windows.Forms.DataGridView
        Friend WithEvents lblCorreoEncarg2 As System.Windows.Forms.Label
        Friend WithEvents lblExtEncarg2 As System.Windows.Forms.Label
        Friend WithEvents lblTel2Encarg2 As System.Windows.Forms.Label
        Friend WithEvents lblTel1Encarg2 As System.Windows.Forms.Label
        Friend WithEvents lblNombreEncarg2 As System.Windows.Forms.Label
        Friend WithEvents llblFaxEncarga2 As System.Windows.Forms.Label
        Friend WithEvents lblServicioEncarg2 As System.Windows.Forms.Label
        Friend WithEvents btnTrasladarEncargado As System.Windows.Forms.Button
        Friend WithEvents lblMostrarTel1Encarg2 As System.Windows.Forms.Label
        Friend WithEvents lblMostrarNombreEncarg2 As System.Windows.Forms.Label
        Friend WithEvents lblMostrarServicioEncarg2 As System.Windows.Forms.Label
        Friend WithEvents lblMostrarTel2Encarg2 As System.Windows.Forms.Label
        Friend WithEvents lblMostrarFaxEncarg2 As System.Windows.Forms.Label
        Friend WithEvents lblMostrarCorreoEncarg2 As System.Windows.Forms.Label
        Friend WithEvents lblMostrarExtEncarg2 As System.Windows.Forms.Label
        Friend WithEvents IdEncargado1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents NombreEncargado1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents IdEncargado2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents NombreEncargado2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents txtIdEncargadoCliente2 As System.Windows.Forms.TextBox
    End Class
End Namespace