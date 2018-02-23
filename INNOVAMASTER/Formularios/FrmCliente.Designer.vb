<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCliente
    Inherits DevExpress.XtraEditors.XtraForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCliente))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.LblRelacionClienteVenta = New System.Windows.Forms.Label()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.CboSexo = New DevExpress.XtraEditors.LookUpEdit()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.CboEstadoCivil = New DevExpress.XtraEditors.LookUpEdit()
        Me.CboMunicipio = New DevExpress.XtraEditors.LookUpEdit()
        Me.TxtCorreo = New DevExpress.XtraEditors.TextEdit()
        Me.TxtTelefono = New DevExpress.XtraEditors.TextEdit()
        Me.TxtDireccion = New DevExpress.XtraEditors.MemoEdit()
        Me.TxtApellidos = New DevExpress.XtraEditors.TextEdit()
        Me.TxtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.TxtFecha = New DevExpress.XtraEditors.DateEdit()
        Me.TxtIdCliente = New DevExpress.XtraEditors.TextEdit()
        Me.GCPrincipal = New DevExpress.XtraGrid.GridControl()
        Me.DgvClientes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColIdCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNombreCompleto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDireccion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColTelefono = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCorreo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColFechaNacimiento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSexo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColMunicipio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColEstadoCivil = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnEditar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnInsertar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnActualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.GbCliente = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboSexo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboEstadoCivil.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboMunicipio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCorreo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTelefono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDireccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtApellidos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtIdCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GbCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbCliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Name = "Label11"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.INNOVAMASTER.My.Resources.Resources.user
        resources.ApplyResources(Me.PictureBox2, "PictureBox2")
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.TabStop = False
        '
        'LblRelacionClienteVenta
        '
        resources.ApplyResources(Me.LblRelacionClienteVenta, "LblRelacionClienteVenta")
        Me.LblRelacionClienteVenta.Name = "LblRelacionClienteVenta"
        Me.HelpProvider1.SetShowHelp(Me.LblRelacionClienteVenta, CType(resources.GetObject("LblRelacionClienteVenta.ShowHelp"), Boolean))
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = CType(resources.GetObject("LabelControl10.Appearance.Font"), System.Drawing.Font)
        resources.ApplyResources(Me.LabelControl10, "LabelControl10")
        Me.LabelControl10.Name = "LabelControl10"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl10, CType(resources.GetObject("LabelControl10.ShowHelp"), Boolean))
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = CType(resources.GetObject("LabelControl9.Appearance.Font"), System.Drawing.Font)
        resources.ApplyResources(Me.LabelControl9, "LabelControl9")
        Me.LabelControl9.Name = "LabelControl9"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl9, CType(resources.GetObject("LabelControl9.ShowHelp"), Boolean))
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = CType(resources.GetObject("LabelControl8.Appearance.Font"), System.Drawing.Font)
        resources.ApplyResources(Me.LabelControl8, "LabelControl8")
        Me.LabelControl8.Name = "LabelControl8"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl8, CType(resources.GetObject("LabelControl8.ShowHelp"), Boolean))
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = CType(resources.GetObject("LabelControl7.Appearance.Font"), System.Drawing.Font)
        resources.ApplyResources(Me.LabelControl7, "LabelControl7")
        Me.LabelControl7.Name = "LabelControl7"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl7, CType(resources.GetObject("LabelControl7.ShowHelp"), Boolean))
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = CType(resources.GetObject("LabelControl6.Appearance.Font"), System.Drawing.Font)
        resources.ApplyResources(Me.LabelControl6, "LabelControl6")
        Me.LabelControl6.Name = "LabelControl6"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl6, CType(resources.GetObject("LabelControl6.ShowHelp"), Boolean))
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = CType(resources.GetObject("LabelControl5.Appearance.Font"), System.Drawing.Font)
        resources.ApplyResources(Me.LabelControl5, "LabelControl5")
        Me.LabelControl5.Name = "LabelControl5"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl5, CType(resources.GetObject("LabelControl5.ShowHelp"), Boolean))
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = CType(resources.GetObject("LabelControl4.Appearance.Font"), System.Drawing.Font)
        resources.ApplyResources(Me.LabelControl4, "LabelControl4")
        Me.LabelControl4.Name = "LabelControl4"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl4, CType(resources.GetObject("LabelControl4.ShowHelp"), Boolean))
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = CType(resources.GetObject("LabelControl3.Appearance.Font"), System.Drawing.Font)
        resources.ApplyResources(Me.LabelControl3, "LabelControl3")
        Me.LabelControl3.Name = "LabelControl3"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl3, CType(resources.GetObject("LabelControl3.ShowHelp"), Boolean))
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = CType(resources.GetObject("LabelControl2.Appearance.Font"), System.Drawing.Font)
        resources.ApplyResources(Me.LabelControl2, "LabelControl2")
        Me.LabelControl2.Name = "LabelControl2"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl2, CType(resources.GetObject("LabelControl2.ShowHelp"), Boolean))
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = CType(resources.GetObject("LabelControl1.Appearance.Font"), System.Drawing.Font)
        resources.ApplyResources(Me.LabelControl1, "LabelControl1")
        Me.LabelControl1.Name = "LabelControl1"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl1, CType(resources.GetObject("LabelControl1.ShowHelp"), Boolean))
        '
        'CboSexo
        '
        resources.ApplyResources(Me.CboSexo, "CboSexo")
        Me.CboSexo.Name = "CboSexo"
        Me.CboSexo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("CboSexo.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.CboSexo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CboSexo.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("CboSexo.Properties.Columns"), CType(resources.GetObject("CboSexo.Properties.Columns1"), Integer), resources.GetString("CboSexo.Properties.Columns2")), New DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("CboSexo.Properties.Columns3"), CType(resources.GetObject("CboSexo.Properties.Columns4"), Integer), resources.GetString("CboSexo.Properties.Columns5"))})
        Me.CboSexo.Properties.DisplayMember = "Sexo"
        Me.CboSexo.Properties.NullText = resources.GetString("CboSexo.Properties.NullText")
        Me.CboSexo.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.CboSexo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.CboSexo.Properties.ValueMember = "IdSexo"
        Me.HelpProvider1.SetShowHelp(Me.CboSexo, CType(resources.GetObject("CboSexo.ShowHelp"), Boolean))
        '
        'SimpleButton3
        '
        resources.ApplyResources(Me.SimpleButton3, "SimpleButton3")
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.HelpProvider1.SetShowHelp(Me.SimpleButton3, CType(resources.GetObject("SimpleButton3.ShowHelp"), Boolean))
        '
        'CboEstadoCivil
        '
        resources.ApplyResources(Me.CboEstadoCivil, "CboEstadoCivil")
        Me.CboEstadoCivil.Name = "CboEstadoCivil"
        Me.CboEstadoCivil.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("CboEstadoCivil.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.CboEstadoCivil.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CboEstadoCivil.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("CboEstadoCivil.Properties.Columns"), CType(resources.GetObject("CboEstadoCivil.Properties.Columns1"), Integer), resources.GetString("CboEstadoCivil.Properties.Columns2"))})
        Me.CboEstadoCivil.Properties.DisplayMember = "EstadoCivil"
        Me.CboEstadoCivil.Properties.NullText = resources.GetString("CboEstadoCivil.Properties.NullText")
        Me.CboEstadoCivil.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.CboEstadoCivil.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.CboEstadoCivil.Properties.ValueMember = "IdEstadoCivil"
        Me.HelpProvider1.SetShowHelp(Me.CboEstadoCivil, CType(resources.GetObject("CboEstadoCivil.ShowHelp"), Boolean))
        '
        'CboMunicipio
        '
        resources.ApplyResources(Me.CboMunicipio, "CboMunicipio")
        Me.CboMunicipio.Name = "CboMunicipio"
        Me.CboMunicipio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("CboMunicipio.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.CboMunicipio.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CboMunicipio.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("CboMunicipio.Properties.Columns"), CType(resources.GetObject("CboMunicipio.Properties.Columns1"), Integer), resources.GetString("CboMunicipio.Properties.Columns2")), New DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("CboMunicipio.Properties.Columns3"), CType(resources.GetObject("CboMunicipio.Properties.Columns4"), Integer), resources.GetString("CboMunicipio.Properties.Columns5")), New DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("CboMunicipio.Properties.Columns6"), resources.GetString("CboMunicipio.Properties.Columns7"))})
        Me.CboMunicipio.Properties.DisplayMember = "Municipio"
        Me.CboMunicipio.Properties.NullText = resources.GetString("CboMunicipio.Properties.NullText")
        Me.CboMunicipio.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.CboMunicipio.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.CboMunicipio.Properties.ValueMember = "IdMunicipio"
        Me.HelpProvider1.SetShowHelp(Me.CboMunicipio, CType(resources.GetObject("CboMunicipio.ShowHelp"), Boolean))
        '
        'TxtCorreo
        '
        resources.ApplyResources(Me.TxtCorreo, "TxtCorreo")
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.HelpProvider1.SetShowHelp(Me.TxtCorreo, CType(resources.GetObject("TxtCorreo.ShowHelp"), Boolean))
        '
        'TxtTelefono
        '
        resources.ApplyResources(Me.TxtTelefono, "TxtTelefono")
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Properties.Mask.EditMask = resources.GetString("TxtTelefono.Properties.Mask.EditMask")
        Me.TxtTelefono.Properties.Mask.MaskType = CType(resources.GetObject("TxtTelefono.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.TxtTelefono.Properties.Mask.PlaceHolder = CType(resources.GetObject("TxtTelefono.Properties.Mask.PlaceHolder"), Char)
        Me.HelpProvider1.SetShowHelp(Me.TxtTelefono, CType(resources.GetObject("TxtTelefono.ShowHelp"), Boolean))
        '
        'TxtDireccion
        '
        resources.ApplyResources(Me.TxtDireccion, "TxtDireccion")
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.HelpProvider1.SetShowHelp(Me.TxtDireccion, CType(resources.GetObject("TxtDireccion.ShowHelp"), Boolean))
        '
        'TxtApellidos
        '
        resources.ApplyResources(Me.TxtApellidos, "TxtApellidos")
        Me.TxtApellidos.Name = "TxtApellidos"
        Me.TxtApellidos.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.HelpProvider1.SetShowHelp(Me.TxtApellidos, CType(resources.GetObject("TxtApellidos.ShowHelp"), Boolean))
        '
        'TxtNombre
        '
        resources.ApplyResources(Me.TxtNombre, "TxtNombre")
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.HelpProvider1.SetShowHelp(Me.TxtNombre, CType(resources.GetObject("TxtNombre.ShowHelp"), Boolean))
        '
        'TxtFecha
        '
        resources.ApplyResources(Me.TxtFecha, "TxtFecha")
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("TxtFecha.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.TxtFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("TxtFecha.Properties.CalendarTimeProperties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.HelpProvider1.SetShowHelp(Me.TxtFecha, CType(resources.GetObject("TxtFecha.ShowHelp"), Boolean))
        '
        'TxtIdCliente
        '
        resources.ApplyResources(Me.TxtIdCliente, "TxtIdCliente")
        Me.TxtIdCliente.Name = "TxtIdCliente"
        Me.TxtIdCliente.Properties.Mask.EditMask = resources.GetString("TxtIdCliente.Properties.Mask.EditMask")
        Me.TxtIdCliente.Properties.Mask.MaskType = CType(resources.GetObject("TxtIdCliente.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.TxtIdCliente.Properties.Mask.PlaceHolder = CType(resources.GetObject("TxtIdCliente.Properties.Mask.PlaceHolder"), Char)
        Me.HelpProvider1.SetShowHelp(Me.TxtIdCliente, CType(resources.GetObject("TxtIdCliente.ShowHelp"), Boolean))
        '
        'GCPrincipal
        '
        resources.ApplyResources(Me.GCPrincipal, "GCPrincipal")
        Me.GCPrincipal.MainView = Me.DgvClientes
        Me.GCPrincipal.Name = "GCPrincipal"
        Me.GCPrincipal.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DgvClientes})
        '
        'DgvClientes
        '
        Me.DgvClientes.Appearance.Empty.BackColor = CType(resources.GetObject("DgvClientes.Appearance.Empty.BackColor"), System.Drawing.Color)
        Me.DgvClientes.Appearance.Empty.BackColor2 = CType(resources.GetObject("DgvClientes.Appearance.Empty.BackColor2"), System.Drawing.Color)
        Me.DgvClientes.Appearance.Empty.Options.UseBackColor = True
        Me.DgvClientes.Appearance.FocusedCell.BackColor = CType(resources.GetObject("DgvClientes.Appearance.FocusedCell.BackColor"), System.Drawing.Color)
        Me.DgvClientes.Appearance.FocusedCell.Font = CType(resources.GetObject("DgvClientes.Appearance.FocusedCell.Font"), System.Drawing.Font)
        Me.DgvClientes.Appearance.FocusedCell.ForeColor = CType(resources.GetObject("DgvClientes.Appearance.FocusedCell.ForeColor"), System.Drawing.Color)
        Me.DgvClientes.Appearance.FocusedCell.Options.UseBackColor = True
        Me.DgvClientes.Appearance.FocusedCell.Options.UseFont = True
        Me.DgvClientes.Appearance.FocusedCell.Options.UseForeColor = True
        Me.DgvClientes.Appearance.FocusedRow.BackColor = CType(resources.GetObject("DgvClientes.Appearance.FocusedRow.BackColor"), System.Drawing.Color)
        Me.DgvClientes.Appearance.FocusedRow.Font = CType(resources.GetObject("DgvClientes.Appearance.FocusedRow.Font"), System.Drawing.Font)
        Me.DgvClientes.Appearance.FocusedRow.Options.UseBackColor = True
        Me.DgvClientes.Appearance.FocusedRow.Options.UseFont = True
        Me.DgvClientes.Appearance.FooterPanel.Options.UseTextOptions = True
        Me.DgvClientes.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.DgvClientes.Appearance.HideSelectionRow.BackColor = CType(resources.GetObject("DgvClientes.Appearance.HideSelectionRow.BackColor"), System.Drawing.Color)
        Me.DgvClientes.Appearance.HideSelectionRow.Font = CType(resources.GetObject("DgvClientes.Appearance.HideSelectionRow.Font"), System.Drawing.Font)
        Me.DgvClientes.Appearance.HideSelectionRow.ForeColor = CType(resources.GetObject("DgvClientes.Appearance.HideSelectionRow.ForeColor"), System.Drawing.Color)
        Me.DgvClientes.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.DgvClientes.Appearance.HideSelectionRow.Options.UseFont = True
        Me.DgvClientes.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.DgvClientes.Appearance.HorzLine.BackColor = CType(resources.GetObject("DgvClientes.Appearance.HorzLine.BackColor"), System.Drawing.Color)
        Me.DgvClientes.Appearance.HorzLine.Options.UseBackColor = True
        Me.DgvClientes.Appearance.Row.BackColor = CType(resources.GetObject("DgvClientes.Appearance.Row.BackColor"), System.Drawing.Color)
        Me.DgvClientes.Appearance.Row.Options.UseBackColor = True
        Me.DgvClientes.Appearance.RowSeparator.BackColor = CType(resources.GetObject("DgvClientes.Appearance.RowSeparator.BackColor"), System.Drawing.Color)
        Me.DgvClientes.Appearance.RowSeparator.Options.UseBackColor = True
        Me.DgvClientes.Appearance.VertLine.BackColor = CType(resources.GetObject("DgvClientes.Appearance.VertLine.BackColor"), System.Drawing.Color)
        Me.DgvClientes.Appearance.VertLine.Options.UseBackColor = True
        Me.DgvClientes.ColumnPanelRowHeight = 26
        Me.DgvClientes.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColIdCliente, Me.ColNombreCompleto, Me.ColDireccion, Me.ColTelefono, Me.ColCorreo, Me.ColFechaNacimiento, Me.ColSexo, Me.ColMunicipio, Me.ColEstadoCivil})
        Me.DgvClientes.GridControl = Me.GCPrincipal
        Me.DgvClientes.Name = "DgvClientes"
        Me.DgvClientes.OptionsBehavior.AllowIncrementalSearch = True
        Me.DgvClientes.OptionsBehavior.AutoSelectAllInEditor = False
        Me.DgvClientes.OptionsBehavior.Editable = False
        Me.DgvClientes.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.DgvClientes.OptionsFind.AlwaysVisible = True
        Me.DgvClientes.OptionsFind.FindNullPrompt = "Introduzca cliente a buscar..."
        Me.DgvClientes.OptionsView.ColumnAutoWidth = False
        Me.DgvClientes.OptionsView.EnableAppearanceEvenRow = True
        Me.DgvClientes.OptionsView.EnableAppearanceOddRow = True
        Me.DgvClientes.OptionsView.ShowFooter = True
        Me.DgvClientes.OptionsView.ShowGroupPanel = False
        Me.DgvClientes.RowHeight = 22
        '
        'ColIdCliente
        '
        Me.ColIdCliente.AppearanceCell.Font = CType(resources.GetObject("ColIdCliente.AppearanceCell.Font"), System.Drawing.Font)
        Me.ColIdCliente.AppearanceCell.Options.UseFont = True
        Me.ColIdCliente.AppearanceCell.Options.UseTextOptions = True
        Me.ColIdCliente.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColIdCliente.AppearanceHeader.Font = CType(resources.GetObject("ColIdCliente.AppearanceHeader.Font"), System.Drawing.Font)
        Me.ColIdCliente.AppearanceHeader.Options.UseFont = True
        Me.ColIdCliente.AppearanceHeader.Options.UseTextOptions = True
        Me.ColIdCliente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.ColIdCliente, "ColIdCliente")
        Me.ColIdCliente.FieldName = "Identidad"
        Me.ColIdCliente.Name = "ColIdCliente"
        Me.ColIdCliente.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("ColIdCliente.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("ColIdCliente.Summary1"), resources.GetString("ColIdCliente.Summary2"))})
        '
        'ColNombreCompleto
        '
        Me.ColNombreCompleto.AppearanceCell.Font = CType(resources.GetObject("ColNombreCompleto.AppearanceCell.Font"), System.Drawing.Font)
        Me.ColNombreCompleto.AppearanceCell.Options.UseFont = True
        Me.ColNombreCompleto.AppearanceHeader.Font = CType(resources.GetObject("ColNombreCompleto.AppearanceHeader.Font"), System.Drawing.Font)
        Me.ColNombreCompleto.AppearanceHeader.Options.UseFont = True
        Me.ColNombreCompleto.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNombreCompleto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.ColNombreCompleto, "ColNombreCompleto")
        Me.ColNombreCompleto.FieldName = "Nombre_Completo"
        Me.ColNombreCompleto.Name = "ColNombreCompleto"
        '
        'ColDireccion
        '
        Me.ColDireccion.AppearanceCell.Font = CType(resources.GetObject("ColDireccion.AppearanceCell.Font"), System.Drawing.Font)
        Me.ColDireccion.AppearanceCell.Options.UseFont = True
        Me.ColDireccion.AppearanceHeader.Font = CType(resources.GetObject("ColDireccion.AppearanceHeader.Font"), System.Drawing.Font)
        Me.ColDireccion.AppearanceHeader.Options.UseFont = True
        Me.ColDireccion.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDireccion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.ColDireccion, "ColDireccion")
        Me.ColDireccion.FieldName = "DireccionCliente"
        Me.ColDireccion.Name = "ColDireccion"
        '
        'ColTelefono
        '
        Me.ColTelefono.AppearanceCell.Font = CType(resources.GetObject("ColTelefono.AppearanceCell.Font"), System.Drawing.Font)
        Me.ColTelefono.AppearanceCell.Options.UseFont = True
        Me.ColTelefono.AppearanceHeader.Font = CType(resources.GetObject("ColTelefono.AppearanceHeader.Font"), System.Drawing.Font)
        Me.ColTelefono.AppearanceHeader.Options.UseFont = True
        Me.ColTelefono.AppearanceHeader.Options.UseTextOptions = True
        Me.ColTelefono.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.ColTelefono, "ColTelefono")
        Me.ColTelefono.FieldName = "TelefonoCliente"
        Me.ColTelefono.Name = "ColTelefono"
        '
        'ColCorreo
        '
        Me.ColCorreo.AppearanceCell.Font = CType(resources.GetObject("ColCorreo.AppearanceCell.Font"), System.Drawing.Font)
        Me.ColCorreo.AppearanceCell.Options.UseFont = True
        Me.ColCorreo.AppearanceHeader.Font = CType(resources.GetObject("ColCorreo.AppearanceHeader.Font"), System.Drawing.Font)
        Me.ColCorreo.AppearanceHeader.Options.UseFont = True
        Me.ColCorreo.AppearanceHeader.Options.UseTextOptions = True
        Me.ColCorreo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.ColCorreo, "ColCorreo")
        Me.ColCorreo.FieldName = "CorreoCliente"
        Me.ColCorreo.Name = "ColCorreo"
        '
        'ColFechaNacimiento
        '
        Me.ColFechaNacimiento.AppearanceCell.Font = CType(resources.GetObject("ColFechaNacimiento.AppearanceCell.Font"), System.Drawing.Font)
        Me.ColFechaNacimiento.AppearanceCell.Options.UseFont = True
        Me.ColFechaNacimiento.AppearanceHeader.Font = CType(resources.GetObject("ColFechaNacimiento.AppearanceHeader.Font"), System.Drawing.Font)
        Me.ColFechaNacimiento.AppearanceHeader.Options.UseFont = True
        Me.ColFechaNacimiento.AppearanceHeader.Options.UseTextOptions = True
        Me.ColFechaNacimiento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.ColFechaNacimiento, "ColFechaNacimiento")
        Me.ColFechaNacimiento.FieldName = "FechaNacimiento"
        Me.ColFechaNacimiento.Name = "ColFechaNacimiento"
        '
        'ColSexo
        '
        Me.ColSexo.AppearanceCell.Font = CType(resources.GetObject("ColSexo.AppearanceCell.Font"), System.Drawing.Font)
        Me.ColSexo.AppearanceCell.Options.UseFont = True
        Me.ColSexo.AppearanceHeader.Font = CType(resources.GetObject("ColSexo.AppearanceHeader.Font"), System.Drawing.Font)
        Me.ColSexo.AppearanceHeader.Options.UseFont = True
        Me.ColSexo.AppearanceHeader.Options.UseTextOptions = True
        Me.ColSexo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.ColSexo, "ColSexo")
        Me.ColSexo.FieldName = "Sexo"
        Me.ColSexo.Name = "ColSexo"
        '
        'ColMunicipio
        '
        Me.ColMunicipio.AppearanceCell.Font = CType(resources.GetObject("ColMunicipio.AppearanceCell.Font"), System.Drawing.Font)
        Me.ColMunicipio.AppearanceCell.Options.UseFont = True
        Me.ColMunicipio.AppearanceHeader.Font = CType(resources.GetObject("ColMunicipio.AppearanceHeader.Font"), System.Drawing.Font)
        Me.ColMunicipio.AppearanceHeader.Options.UseFont = True
        Me.ColMunicipio.AppearanceHeader.Options.UseTextOptions = True
        Me.ColMunicipio.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.ColMunicipio, "ColMunicipio")
        Me.ColMunicipio.FieldName = "Municipio"
        Me.ColMunicipio.Name = "ColMunicipio"
        '
        'ColEstadoCivil
        '
        Me.ColEstadoCivil.AppearanceCell.Font = CType(resources.GetObject("ColEstadoCivil.AppearanceCell.Font"), System.Drawing.Font)
        Me.ColEstadoCivil.AppearanceCell.Options.UseFont = True
        Me.ColEstadoCivil.AppearanceHeader.Font = CType(resources.GetObject("ColEstadoCivil.AppearanceHeader.Font"), System.Drawing.Font)
        Me.ColEstadoCivil.AppearanceHeader.Options.UseFont = True
        Me.ColEstadoCivil.AppearanceHeader.Options.UseTextOptions = True
        Me.ColEstadoCivil.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.ColEstadoCivil, "ColEstadoCivil")
        Me.ColEstadoCivil.FieldName = "EstadoCivil"
        Me.ColEstadoCivil.Name = "ColEstadoCivil"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Image = CType(resources.GetObject("SimpleButton5.Image"), System.Drawing.Image)
        resources.ApplyResources(Me.SimpleButton5, "SimpleButton5")
        Me.SimpleButton5.Name = "SimpleButton5"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        resources.ApplyResources(Me.SimpleButton4, "SimpleButton4")
        Me.SimpleButton4.Name = "SimpleButton4"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        resources.ApplyResources(Me.SimpleButton2, "SimpleButton2")
        Me.SimpleButton2.Name = "SimpleButton2"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        resources.ApplyResources(Me.SimpleButton1, "SimpleButton1")
        Me.SimpleButton1.Name = "SimpleButton1"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        resources.ApplyResources(Me.BtnCancelar, "BtnCancelar")
        Me.BtnCancelar.Name = "BtnCancelar"
        '
        'BtnEditar
        '
        Me.BtnEditar.Image = CType(resources.GetObject("BtnEditar.Image"), System.Drawing.Image)
        Me.BtnEditar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        resources.ApplyResources(Me.BtnEditar, "BtnEditar")
        Me.BtnEditar.Name = "BtnEditar"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        resources.ApplyResources(Me.BtnNuevo, "BtnNuevo")
        Me.BtnNuevo.Name = "BtnNuevo"
        '
        'BtnInsertar
        '
        Me.BtnInsertar.Image = CType(resources.GetObject("BtnInsertar.Image"), System.Drawing.Image)
        Me.BtnInsertar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        resources.ApplyResources(Me.BtnInsertar, "BtnInsertar")
        Me.BtnInsertar.Name = "BtnInsertar"
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Image = CType(resources.GetObject("BtnActualizar.Image"), System.Drawing.Image)
        Me.BtnActualizar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        resources.ApplyResources(Me.BtnActualizar, "BtnActualizar")
        Me.BtnActualizar.Name = "BtnActualizar"
        '
        'GbCliente
        '
        Me.GbCliente.Controls.Add(Me.LabelControl10)
        Me.GbCliente.Controls.Add(Me.LabelControl9)
        Me.GbCliente.Controls.Add(Me.LabelControl8)
        Me.GbCliente.Controls.Add(Me.LabelControl7)
        Me.GbCliente.Controls.Add(Me.LabelControl6)
        Me.GbCliente.Controls.Add(Me.LabelControl5)
        Me.GbCliente.Controls.Add(Me.LabelControl4)
        Me.GbCliente.Controls.Add(Me.LabelControl3)
        Me.GbCliente.Controls.Add(Me.LabelControl2)
        Me.GbCliente.Controls.Add(Me.LabelControl1)
        Me.GbCliente.Controls.Add(Me.CboSexo)
        Me.GbCliente.Controls.Add(Me.SimpleButton3)
        Me.GbCliente.Controls.Add(Me.CboEstadoCivil)
        Me.GbCliente.Controls.Add(Me.CboMunicipio)
        Me.GbCliente.Controls.Add(Me.TxtCorreo)
        Me.GbCliente.Controls.Add(Me.TxtTelefono)
        Me.GbCliente.Controls.Add(Me.TxtDireccion)
        Me.GbCliente.Controls.Add(Me.TxtApellidos)
        Me.GbCliente.Controls.Add(Me.TxtNombre)
        Me.GbCliente.Controls.Add(Me.TxtFecha)
        Me.GbCliente.Controls.Add(Me.TxtIdCliente)
        resources.ApplyResources(Me.GbCliente, "GbCliente")
        Me.GbCliente.Name = "GbCliente"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = CType(resources.GetObject("LabelControl11.Appearance.Font"), System.Drawing.Font)
        resources.ApplyResources(Me.LabelControl11, "LabelControl11")
        Me.LabelControl11.Name = "LabelControl11"
        '
        'FrmCliente
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.GbCliente)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnInsertar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.SimpleButton5)
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GCPrincipal)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.LblRelacionClienteVenta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.HelpProvider1.SetHelpNavigator(Me, CType(resources.GetObject("$this.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.Name = "FrmCliente"
        Me.HelpProvider1.SetShowHelp(Me, CType(resources.GetObject("$this.ShowHelp"), Boolean))
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboSexo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboEstadoCivil.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboMunicipio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCorreo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTelefono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDireccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtApellidos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtIdCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GbCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbCliente.ResumeLayout(False)
        Me.GbCliente.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents LblRelacionClienteVenta As Label
    Friend WithEvents GCPrincipal As DevExpress.XtraGrid.GridControl
    Friend WithEvents DgvClientes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColIdCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColNombreCompleto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDireccion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ColTelefono As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCorreo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColFechaNacimiento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColSexo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColMunicipio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColEstadoCivil As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnEditar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnInsertar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnActualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GbCliente As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CboSexo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CboEstadoCivil As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CboMunicipio As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TxtCorreo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtTelefono As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtDireccion As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents TxtApellidos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TxtIdCliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
End Class
