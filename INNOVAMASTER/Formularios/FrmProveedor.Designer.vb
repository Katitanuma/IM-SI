<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProveedor
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProveedor))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LblRelacionClienteVenta = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.DgvProveedor = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColIdProveedor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColRTN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNombreEmpresa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDireccionEmpresa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNombreContacto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColApellidoContacto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDireccionContacto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColTelefonoContacto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCorreoContacto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColMunicipio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSexo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCPrincipal = New DevExpress.XtraGrid.GridControl()
        Me.GBProveedor = New DevExpress.XtraEditors.GroupControl()
        Me.CboSexo = New DevExpress.XtraEditors.LookUpEdit()
        Me.CboMunicipio = New DevExpress.XtraEditors.LookUpEdit()
        Me.BtnBusquedaMunicipio = New System.Windows.Forms.Button()
        Me.TxtDireccionContacto = New DevExpress.XtraEditors.MemoEdit()
        Me.TxtCorreo = New DevExpress.XtraEditors.TextEdit()
        Me.TxtTelefono = New DevExpress.XtraEditors.TextEdit()
        Me.TxtApellidosContacto = New DevExpress.XtraEditors.TextEdit()
        Me.TxtNombreContacto = New DevExpress.XtraEditors.TextEdit()
        Me.TxtDireccionEmpresa = New DevExpress.XtraEditors.MemoEdit()
        Me.TxtNombreEmpresa = New DevExpress.XtraEditors.TextEdit()
        Me.TxtRTN = New DevExpress.XtraEditors.TextEdit()
        Me.TxtIdProveedor = New DevExpress.XtraEditors.TextEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnEditar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnInsertar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnActualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GBProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBProveedor.SuspendLayout()
        CType(Me.CboSexo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboMunicipio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDireccionContacto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCorreo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTelefono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtApellidosContacto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNombreContacto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDireccionEmpresa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNombreEmpresa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtRTN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtIdProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.INNOVAMASTER.My.Resources.Resources.user
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(59, 59)
        Me.PictureBox2.TabIndex = 69
        Me.PictureBox2.TabStop = False
        '
        'LblRelacionClienteVenta
        '
        Me.LblRelacionClienteVenta.AutoSize = True
        Me.LblRelacionClienteVenta.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblRelacionClienteVenta.Location = New System.Drawing.Point(423, 27)
        Me.LblRelacionClienteVenta.Name = "LblRelacionClienteVenta"
        Me.LblRelacionClienteVenta.Size = New System.Drawing.Size(13, 13)
        Me.LblRelacionClienteVenta.TabIndex = 54
        Me.LblRelacionClienteVenta.Text = "0"
        Me.LblRelacionClienteVenta.Visible = False
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Image = CType(resources.GetObject("SimpleButton5.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(666, 480)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton5.TabIndex = 138
        Me.SimpleButton5.Text = "Actualizar Datos"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(837, 480)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton4.TabIndex = 137
        Me.SimpleButton4.Text = "Exportar PDF"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(1008, 480)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton2.TabIndex = 136
        Me.SimpleButton2.Text = "Exportar Excel"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(1179, 480)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton1.TabIndex = 135
        Me.SimpleButton1.Text = "Vista Previa"
        '
        'DgvProveedor
        '
        Me.DgvProveedor.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvProveedor.Appearance.Empty.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvProveedor.Appearance.Empty.Options.UseBackColor = True
        Me.DgvProveedor.Appearance.FocusedCell.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvProveedor.Appearance.FocusedCell.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DgvProveedor.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.DgvProveedor.Appearance.FocusedCell.Options.UseBackColor = True
        Me.DgvProveedor.Appearance.FocusedCell.Options.UseFont = True
        Me.DgvProveedor.Appearance.FocusedCell.Options.UseForeColor = True
        Me.DgvProveedor.Appearance.FocusedRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvProveedor.Appearance.FocusedRow.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DgvProveedor.Appearance.FocusedRow.Options.UseBackColor = True
        Me.DgvProveedor.Appearance.FocusedRow.Options.UseFont = True
        Me.DgvProveedor.Appearance.FooterPanel.Options.UseTextOptions = True
        Me.DgvProveedor.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.DgvProveedor.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvProveedor.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DgvProveedor.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White
        Me.DgvProveedor.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.DgvProveedor.Appearance.HideSelectionRow.Options.UseFont = True
        Me.DgvProveedor.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.DgvProveedor.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DgvProveedor.Appearance.HorzLine.Options.UseBackColor = True
        Me.DgvProveedor.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvProveedor.Appearance.Row.Options.UseBackColor = True
        Me.DgvProveedor.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvProveedor.Appearance.RowSeparator.Options.UseBackColor = True
        Me.DgvProveedor.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DgvProveedor.Appearance.VertLine.Options.UseBackColor = True
        Me.DgvProveedor.ColumnPanelRowHeight = 26
        Me.DgvProveedor.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColIdProveedor, Me.ColRTN, Me.ColNombreEmpresa, Me.ColDireccionEmpresa, Me.ColNombreContacto, Me.ColApellidoContacto, Me.ColDireccionContacto, Me.ColTelefonoContacto, Me.ColCorreoContacto, Me.ColMunicipio, Me.ColSexo})
        Me.DgvProveedor.GridControl = Me.GCPrincipal
        Me.DgvProveedor.Name = "DgvProveedor"
        Me.DgvProveedor.OptionsBehavior.AllowIncrementalSearch = True
        Me.DgvProveedor.OptionsBehavior.AutoSelectAllInEditor = False
        Me.DgvProveedor.OptionsBehavior.Editable = False
        Me.DgvProveedor.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.DgvProveedor.OptionsFind.AlwaysVisible = True
        Me.DgvProveedor.OptionsFind.FindNullPrompt = "Introduzca municipio a buscar..."
        Me.DgvProveedor.OptionsView.ColumnAutoWidth = False
        Me.DgvProveedor.OptionsView.EnableAppearanceEvenRow = True
        Me.DgvProveedor.OptionsView.EnableAppearanceOddRow = True
        Me.DgvProveedor.OptionsView.ShowFooter = True
        Me.DgvProveedor.OptionsView.ShowGroupPanel = False
        Me.DgvProveedor.RowHeight = 22
        '
        'ColIdProveedor
        '
        Me.ColIdProveedor.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColIdProveedor.AppearanceCell.Options.UseFont = True
        Me.ColIdProveedor.AppearanceCell.Options.UseTextOptions = True
        Me.ColIdProveedor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColIdProveedor.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColIdProveedor.AppearanceHeader.Options.UseFont = True
        Me.ColIdProveedor.AppearanceHeader.Options.UseTextOptions = True
        Me.ColIdProveedor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColIdProveedor.Caption = "ID"
        Me.ColIdProveedor.FieldName = "IdProveedor"
        Me.ColIdProveedor.Name = "ColIdProveedor"
        Me.ColIdProveedor.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdProveedor", "Total Proveedores = {0}")})
        Me.ColIdProveedor.Visible = True
        Me.ColIdProveedor.VisibleIndex = 0
        Me.ColIdProveedor.Width = 156
        '
        'ColRTN
        '
        Me.ColRTN.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColRTN.AppearanceCell.Options.UseFont = True
        Me.ColRTN.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColRTN.AppearanceHeader.Options.UseFont = True
        Me.ColRTN.AppearanceHeader.Options.UseTextOptions = True
        Me.ColRTN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColRTN.Caption = "RTN"
        Me.ColRTN.FieldName = "RTN"
        Me.ColRTN.Name = "ColRTN"
        Me.ColRTN.Visible = True
        Me.ColRTN.VisibleIndex = 1
        Me.ColRTN.Width = 209
        '
        'ColNombreEmpresa
        '
        Me.ColNombreEmpresa.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColNombreEmpresa.AppearanceCell.Options.UseFont = True
        Me.ColNombreEmpresa.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColNombreEmpresa.AppearanceHeader.Options.UseFont = True
        Me.ColNombreEmpresa.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNombreEmpresa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNombreEmpresa.Caption = "Nombre Empresa"
        Me.ColNombreEmpresa.FieldName = "NombreEmpresa"
        Me.ColNombreEmpresa.Name = "ColNombreEmpresa"
        Me.ColNombreEmpresa.Visible = True
        Me.ColNombreEmpresa.VisibleIndex = 2
        Me.ColNombreEmpresa.Width = 184
        '
        'ColDireccionEmpresa
        '
        Me.ColDireccionEmpresa.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColDireccionEmpresa.AppearanceCell.Options.UseFont = True
        Me.ColDireccionEmpresa.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColDireccionEmpresa.AppearanceHeader.Options.UseFont = True
        Me.ColDireccionEmpresa.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDireccionEmpresa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDireccionEmpresa.Caption = "Direccion Empresa"
        Me.ColDireccionEmpresa.FieldName = "DireccionEmpresa"
        Me.ColDireccionEmpresa.Name = "ColDireccionEmpresa"
        Me.ColDireccionEmpresa.Visible = True
        Me.ColDireccionEmpresa.VisibleIndex = 3
        Me.ColDireccionEmpresa.Width = 156
        '
        'ColNombreContacto
        '
        Me.ColNombreContacto.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColNombreContacto.AppearanceCell.Options.UseFont = True
        Me.ColNombreContacto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColNombreContacto.AppearanceHeader.Options.UseFont = True
        Me.ColNombreContacto.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNombreContacto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNombreContacto.Caption = "Nombre Contacto"
        Me.ColNombreContacto.FieldName = "NombreContacto"
        Me.ColNombreContacto.Name = "ColNombreContacto"
        Me.ColNombreContacto.Visible = True
        Me.ColNombreContacto.VisibleIndex = 4
        Me.ColNombreContacto.Width = 141
        '
        'ColApellidoContacto
        '
        Me.ColApellidoContacto.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColApellidoContacto.AppearanceCell.Options.UseFont = True
        Me.ColApellidoContacto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColApellidoContacto.AppearanceHeader.Options.UseFont = True
        Me.ColApellidoContacto.AppearanceHeader.Options.UseTextOptions = True
        Me.ColApellidoContacto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColApellidoContacto.Caption = "Apellido Contacto"
        Me.ColApellidoContacto.FieldName = "ApellidoContacto"
        Me.ColApellidoContacto.Name = "ColApellidoContacto"
        Me.ColApellidoContacto.Visible = True
        Me.ColApellidoContacto.VisibleIndex = 5
        Me.ColApellidoContacto.Width = 134
        '
        'ColDireccionContacto
        '
        Me.ColDireccionContacto.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColDireccionContacto.AppearanceCell.Options.UseFont = True
        Me.ColDireccionContacto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColDireccionContacto.AppearanceHeader.Options.UseFont = True
        Me.ColDireccionContacto.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDireccionContacto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDireccionContacto.Caption = "Direccion Contacto"
        Me.ColDireccionContacto.FieldName = "DireccionContacto"
        Me.ColDireccionContacto.Name = "ColDireccionContacto"
        Me.ColDireccionContacto.Visible = True
        Me.ColDireccionContacto.VisibleIndex = 6
        Me.ColDireccionContacto.Width = 148
        '
        'ColTelefonoContacto
        '
        Me.ColTelefonoContacto.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColTelefonoContacto.AppearanceCell.Options.UseFont = True
        Me.ColTelefonoContacto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColTelefonoContacto.AppearanceHeader.Options.UseFont = True
        Me.ColTelefonoContacto.AppearanceHeader.Options.UseTextOptions = True
        Me.ColTelefonoContacto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColTelefonoContacto.Caption = "Telefono Contacto"
        Me.ColTelefonoContacto.FieldName = "TelefonoContacto"
        Me.ColTelefonoContacto.Name = "ColTelefonoContacto"
        Me.ColTelefonoContacto.Visible = True
        Me.ColTelefonoContacto.VisibleIndex = 7
        Me.ColTelefonoContacto.Width = 140
        '
        'ColCorreoContacto
        '
        Me.ColCorreoContacto.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColCorreoContacto.AppearanceCell.Options.UseFont = True
        Me.ColCorreoContacto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColCorreoContacto.AppearanceHeader.Options.UseFont = True
        Me.ColCorreoContacto.AppearanceHeader.Options.UseTextOptions = True
        Me.ColCorreoContacto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColCorreoContacto.Caption = "Correo Contacto"
        Me.ColCorreoContacto.FieldName = "correocontacto"
        Me.ColCorreoContacto.Name = "ColCorreoContacto"
        Me.ColCorreoContacto.Visible = True
        Me.ColCorreoContacto.VisibleIndex = 8
        Me.ColCorreoContacto.Width = 128
        '
        'ColMunicipio
        '
        Me.ColMunicipio.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColMunicipio.AppearanceCell.Options.UseFont = True
        Me.ColMunicipio.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColMunicipio.AppearanceHeader.Options.UseFont = True
        Me.ColMunicipio.AppearanceHeader.Options.UseTextOptions = True
        Me.ColMunicipio.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColMunicipio.Caption = "Municipio"
        Me.ColMunicipio.FieldName = "Municipio"
        Me.ColMunicipio.Name = "ColMunicipio"
        Me.ColMunicipio.Visible = True
        Me.ColMunicipio.VisibleIndex = 9
        Me.ColMunicipio.Width = 132
        '
        'ColSexo
        '
        Me.ColSexo.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColSexo.AppearanceCell.Options.UseFont = True
        Me.ColSexo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColSexo.AppearanceHeader.Options.UseFont = True
        Me.ColSexo.AppearanceHeader.Options.UseTextOptions = True
        Me.ColSexo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColSexo.Caption = "Sexo"
        Me.ColSexo.FieldName = "Sexo"
        Me.ColSexo.Name = "ColSexo"
        Me.ColSexo.Visible = True
        Me.ColSexo.VisibleIndex = 10
        '
        'GCPrincipal
        '
        Me.GCPrincipal.Location = New System.Drawing.Point(491, 27)
        Me.GCPrincipal.MainView = Me.DgvProveedor
        Me.GCPrincipal.Name = "GCPrincipal"
        Me.GCPrincipal.Size = New System.Drawing.Size(853, 447)
        Me.GCPrincipal.TabIndex = 104
        Me.GCPrincipal.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DgvProveedor})
        '
        'GBProveedor
        '
        Me.GBProveedor.Controls.Add(Me.CboSexo)
        Me.GBProveedor.Controls.Add(Me.CboMunicipio)
        Me.GBProveedor.Controls.Add(Me.BtnBusquedaMunicipio)
        Me.GBProveedor.Controls.Add(Me.TxtDireccionContacto)
        Me.GBProveedor.Controls.Add(Me.TxtCorreo)
        Me.GBProveedor.Controls.Add(Me.TxtTelefono)
        Me.GBProveedor.Controls.Add(Me.TxtApellidosContacto)
        Me.GBProveedor.Controls.Add(Me.TxtNombreContacto)
        Me.GBProveedor.Controls.Add(Me.TxtDireccionEmpresa)
        Me.GBProveedor.Controls.Add(Me.TxtNombreEmpresa)
        Me.GBProveedor.Controls.Add(Me.TxtRTN)
        Me.GBProveedor.Controls.Add(Me.TxtIdProveedor)
        Me.GBProveedor.Controls.Add(Me.Label6)
        Me.GBProveedor.Controls.Add(Me.Label15)
        Me.GBProveedor.Controls.Add(Me.Label3)
        Me.GBProveedor.Controls.Add(Me.Label14)
        Me.GBProveedor.Controls.Add(Me.Label5)
        Me.GBProveedor.Controls.Add(Me.Label9)
        Me.GBProveedor.Controls.Add(Me.Label7)
        Me.GBProveedor.Controls.Add(Me.Label8)
        Me.GBProveedor.Controls.Add(Me.Label4)
        Me.GBProveedor.Controls.Add(Me.Label2)
        Me.GBProveedor.Controls.Add(Me.Label1)
        Me.GBProveedor.Location = New System.Drawing.Point(12, 93)
        Me.GBProveedor.Name = "GBProveedor"
        Me.GBProveedor.Size = New System.Drawing.Size(424, 372)
        Me.GBProveedor.TabIndex = 139
        Me.GBProveedor.Text = "Datos Proveedor"
        '
        'CboSexo
        '
        Me.CboSexo.Location = New System.Drawing.Point(157, 338)
        Me.CboSexo.Name = "CboSexo"
        Me.CboSexo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CboSexo.Properties.DisplayMember = "Sexo"
        Me.CboSexo.Properties.NullText = "Seleccione Sexo"
        Me.CboSexo.Properties.ValueMember = "IdSexo"
        Me.CboSexo.Size = New System.Drawing.Size(199, 20)
        Me.CboSexo.TabIndex = 161
        '
        'CboMunicipio
        '
        Me.CboMunicipio.Location = New System.Drawing.Point(157, 308)
        Me.CboMunicipio.Name = "CboMunicipio"
        Me.CboMunicipio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CboMunicipio.Properties.DisplayMember = "Municipio"
        Me.CboMunicipio.Properties.NullText = "Seleccione Municipio"
        Me.CboMunicipio.Properties.ValueMember = "IdMunicipio"
        Me.CboMunicipio.Size = New System.Drawing.Size(199, 20)
        Me.CboMunicipio.TabIndex = 160
        '
        'BtnBusquedaMunicipio
        '
        Me.BtnBusquedaMunicipio.Location = New System.Drawing.Point(362, 305)
        Me.BtnBusquedaMunicipio.Name = "BtnBusquedaMunicipio"
        Me.BtnBusquedaMunicipio.Size = New System.Drawing.Size(30, 22)
        Me.BtnBusquedaMunicipio.TabIndex = 159
        Me.BtnBusquedaMunicipio.Text = "..."
        Me.BtnBusquedaMunicipio.UseVisualStyleBackColor = True
        '
        'TxtDireccionContacto
        '
        Me.TxtDireccionContacto.Location = New System.Drawing.Point(157, 201)
        Me.TxtDireccionContacto.Name = "TxtDireccionContacto"
        Me.TxtDireccionContacto.Size = New System.Drawing.Size(247, 40)
        Me.TxtDireccionContacto.TabIndex = 158
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Location = New System.Drawing.Point(157, 277)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(247, 20)
        Me.TxtCorreo.TabIndex = 157
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(157, 247)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Properties.Mask.EditMask = "\d\d?\d?\d?-\d?\d?\d?\d?"
        Me.TxtTelefono.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular
        Me.TxtTelefono.Properties.Mask.PlaceHolder = Global.Microsoft.VisualBasic.ChrW(32)
        Me.TxtTelefono.Size = New System.Drawing.Size(131, 20)
        Me.TxtTelefono.TabIndex = 156
        '
        'TxtApellidosContacto
        '
        Me.TxtApellidosContacto.Location = New System.Drawing.Point(157, 177)
        Me.TxtApellidosContacto.Name = "TxtApellidosContacto"
        Me.TxtApellidosContacto.Size = New System.Drawing.Size(247, 20)
        Me.TxtApellidosContacto.TabIndex = 155
        '
        'TxtNombreContacto
        '
        Me.TxtNombreContacto.Location = New System.Drawing.Point(157, 151)
        Me.TxtNombreContacto.Name = "TxtNombreContacto"
        Me.TxtNombreContacto.Size = New System.Drawing.Size(247, 20)
        Me.TxtNombreContacto.TabIndex = 154
        '
        'TxtDireccionEmpresa
        '
        Me.TxtDireccionEmpresa.Location = New System.Drawing.Point(157, 108)
        Me.TxtDireccionEmpresa.Name = "TxtDireccionEmpresa"
        Me.TxtDireccionEmpresa.Size = New System.Drawing.Size(247, 37)
        Me.TxtDireccionEmpresa.TabIndex = 153
        '
        'TxtNombreEmpresa
        '
        Me.TxtNombreEmpresa.Location = New System.Drawing.Point(157, 81)
        Me.TxtNombreEmpresa.Name = "TxtNombreEmpresa"
        Me.TxtNombreEmpresa.Size = New System.Drawing.Size(247, 20)
        Me.TxtNombreEmpresa.TabIndex = 152
        '
        'TxtRTN
        '
        Me.TxtRTN.Location = New System.Drawing.Point(157, 54)
        Me.TxtRTN.Name = "TxtRTN"
        Me.TxtRTN.Properties.Mask.EditMask = "\d?\d?\d?\d?-\d?\d?\d?\d?-\d?\d?\d?\d?\d?"
        Me.TxtRTN.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular
        Me.TxtRTN.Properties.Mask.PlaceHolder = Global.Microsoft.VisualBasic.ChrW(32)
        Me.TxtRTN.Size = New System.Drawing.Size(131, 20)
        Me.TxtRTN.TabIndex = 151
        '
        'TxtIdProveedor
        '
        Me.TxtIdProveedor.Location = New System.Drawing.Point(157, 23)
        Me.TxtIdProveedor.Name = "TxtIdProveedor"
        Me.TxtIdProveedor.Properties.Mask.EditMask = "\d?\d?\d?\d?-\d?\d?\d?\d?-\d?\d?\d?\d?\d?"
        Me.TxtIdProveedor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular
        Me.TxtIdProveedor.Properties.Mask.PlaceHolder = Global.Microsoft.VisualBasic.ChrW(32)
        Me.TxtIdProveedor.Size = New System.Drawing.Size(131, 20)
        Me.TxtIdProveedor.TabIndex = 150
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(23, 201)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 19)
        Me.Label6.TabIndex = 149
        Me.Label6.Text = "Dirección Contacto"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(26, 151)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(125, 19)
        Me.Label15.TabIndex = 148
        Me.Label15.Text = "Nombres Contacto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(23, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 19)
        Me.Label3.TabIndex = 147
        Me.Label3.Text = "Dirección Empresa"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(108, 51)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 19)
        Me.Label14.TabIndex = 146
        Me.Label14.Text = "RTN"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(43, 337)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 19)
        Me.Label5.TabIndex = 145
        Me.Label5.Text = "Sexo Contacto"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(78, 308)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 19)
        Me.Label9.TabIndex = 144
        Me.Label9.Text = "Municipio"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(96, 279)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 19)
        Me.Label7.TabIndex = 143
        Me.Label7.Text = "Correo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(83, 249)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 19)
        Me.Label8.TabIndex = 142
        Me.Label8.Text = "Teléfono"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(20, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 19)
        Me.Label4.TabIndex = 141
        Me.Label4.Text = "Apellidos Contacto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(32, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 19)
        Me.Label2.TabIndex = 140
        Me.Label2.Text = "Nombre Empresa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(34, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 19)
        Me.Label1.TabIndex = 139
        Me.Label1.Text = "Código Proveedor"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnCancelar.Location = New System.Drawing.Point(338, 475)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(98, 68)
        Me.BtnCancelar.TabIndex = 143
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.Visible = False
        '
        'BtnEditar
        '
        Me.BtnEditar.Image = CType(resources.GetObject("BtnEditar.Image"), System.Drawing.Image)
        Me.BtnEditar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnEditar.Location = New System.Drawing.Point(130, 475)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(98, 68)
        Me.BtnEditar.TabIndex = 141
        Me.BtnEditar.Text = "Editar"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnNuevo.Location = New System.Drawing.Point(26, 475)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(98, 68)
        Me.BtnNuevo.TabIndex = 140
        Me.BtnNuevo.Text = "Nuevo"
        '
        'BtnInsertar
        '
        Me.BtnInsertar.Image = CType(resources.GetObject("BtnInsertar.Image"), System.Drawing.Image)
        Me.BtnInsertar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnInsertar.Location = New System.Drawing.Point(234, 475)
        Me.BtnInsertar.Name = "BtnInsertar"
        Me.BtnInsertar.Size = New System.Drawing.Size(98, 68)
        Me.BtnInsertar.TabIndex = 144
        Me.BtnInsertar.Text = "Guardar"
        Me.BtnInsertar.Visible = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Image = CType(resources.GetObject("BtnActualizar.Image"), System.Drawing.Image)
        Me.BtnActualizar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnActualizar.Location = New System.Drawing.Point(234, 475)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(98, 68)
        Me.BtnActualizar.TabIndex = 142
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.Visible = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.LabelControl3.Location = New System.Drawing.Point(72, 21)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(266, 43)
        Me.LabelControl3.TabIndex = 151
        Me.LabelControl3.Text = "Perfil del Proveedor"
        '
        'FrmProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 579)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnInsertar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.GBProveedor)
        Me.Controls.Add(Me.SimpleButton5)
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GCPrincipal)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LblRelacionClienteVenta)
        Me.HelpButton = True
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TableOfContents)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmProveedor"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "Proveedor"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GBProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBProveedor.ResumeLayout(False)
        Me.GBProveedor.PerformLayout()
        CType(Me.CboSexo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboMunicipio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDireccionContacto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCorreo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTelefono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtApellidosContacto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNombreContacto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDireccionEmpresa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNombreEmpresa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtRTN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtIdProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LblRelacionClienteVenta As Label
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DgvProveedor As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColIdProveedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColRTN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColNombreEmpresa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDireccionEmpresa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColNombreContacto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColApellidoContacto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDireccionContacto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColTelefonoContacto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCorreoContacto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColMunicipio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColSexo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCPrincipal As DevExpress.XtraGrid.GridControl
    Friend WithEvents GBProveedor As DevExpress.XtraEditors.GroupControl
    Friend WithEvents CboSexo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CboMunicipio As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents BtnBusquedaMunicipio As Button
    Friend WithEvents TxtDireccionContacto As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents TxtCorreo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtTelefono As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtApellidosContacto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtNombreContacto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtDireccionEmpresa As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents TxtNombreEmpresa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtRTN As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtIdProveedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnEditar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnInsertar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnActualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
End Class
