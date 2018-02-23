<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUsuario
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
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsuario))
        Me.ColEstado = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_ColEstado = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.LblRespaldo = New System.Windows.Forms.Label()
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.LblFilas = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.GCPrincipal = New DevExpress.XtraGrid.GridControl()
        Me.DgvUsuario = New DevExpress.XtraGrid.Views.Layout.LayoutView()
        Me.ColIdUsuario = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_ColIdUsuario = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.ColUsuario = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_ColUsuario = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.ColNombre = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_ColNombre = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.ColTipoAcceso = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_ColTipoAcceso = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.ColContrasena = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_ColContrasena = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.LayoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnEditar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnInsertar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnActualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.GbUsuario = New DevExpress.XtraEditors.GroupControl()
        Me.CboTipoA = New DevExpress.XtraEditors.DropDownButton()
        Me.CboEmpleado = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ChkVer = New DevExpress.XtraEditors.CheckEdit()
        Me.TxtContra2 = New DevExpress.XtraEditors.TextEdit()
        Me.TxtContra = New DevExpress.XtraEditors.TextEdit()
        Me.TxtUsuario = New DevExpress.XtraEditors.TextEdit()
        Me.TxtIdUsuario = New DevExpress.XtraEditors.TextEdit()
        Me.RdbInactivo = New System.Windows.Forms.RadioButton()
        Me.RdbActivo = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.layoutViewField_ColEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_ColIdUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_ColUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_ColNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_ColTipoAcceso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_ColContrasena, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GbUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbUsuario.SuspendLayout()
        CType(Me.CboEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkVer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtContra2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtContra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtIdUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ColEstado
        '
        Me.ColEstado.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColEstado.AppearanceCell.Options.UseFont = True
        Me.ColEstado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColEstado.AppearanceHeader.Options.UseFont = True
        Me.ColEstado.AppearanceHeader.Options.UseTextOptions = True
        Me.ColEstado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColEstado.Caption = "Estado"
        Me.ColEstado.FieldName = "Estado"
        Me.ColEstado.LayoutViewField = Me.layoutViewField_ColEstado
        Me.ColEstado.Name = "ColEstado"
        Me.ColEstado.Width = 183
        '
        'layoutViewField_ColEstado
        '
        Me.layoutViewField_ColEstado.EditorPreferredWidth = 221
        Me.layoutViewField_ColEstado.Location = New System.Drawing.Point(0, 168)
        Me.layoutViewField_ColEstado.Name = "layoutViewField_ColEstado"
        Me.layoutViewField_ColEstado.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10)
        Me.layoutViewField_ColEstado.Size = New System.Drawing.Size(338, 42)
        Me.layoutViewField_ColEstado.Spacing = New DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1)
        Me.layoutViewField_ColEstado.TextLocation = DevExpress.Utils.Locations.Left
        Me.layoutViewField_ColEstado.TextSize = New System.Drawing.Size(89, 13)
        '
        'LblRespaldo
        '
        Me.LblRespaldo.AutoSize = True
        Me.LblRespaldo.Location = New System.Drawing.Point(400, 22)
        Me.LblRespaldo.Name = "LblRespaldo"
        Me.LblRespaldo.Size = New System.Drawing.Size(0, 13)
        Me.LblRespaldo.TabIndex = 70
        Me.LblRespaldo.Visible = False
        '
        'PopupMenu1
        '
        Me.PopupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2)})
        Me.PopupMenu1.Manager = Me.BarManager1
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Administrador"
        Me.BarButtonItem1.Glyph = Global.INNOVAMASTER.My.Resources.Resources._2
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Usuario"
        Me.BarButtonItem2.Glyph = Global.INNOVAMASTER.My.Resources.Resources.user
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2})
        Me.BarManager1.MaxItemId = 2
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1354, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 573)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1354, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 573)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1354, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 573)
        '
        'LblFilas
        '
        Me.LblFilas.AutoSize = True
        Me.LblFilas.Location = New System.Drawing.Point(919, 328)
        Me.LblFilas.Name = "LblFilas"
        Me.LblFilas.Size = New System.Drawing.Size(61, 13)
        Me.LblFilas.TabIndex = 68
        Me.LblFilas.Text = "SIN DATOS"
        Me.LblFilas.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.INNOVAMASTER.My.Resources.Resources.users
        Me.PictureBox2.Location = New System.Drawing.Point(30, 17)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(59, 59)
        Me.PictureBox2.TabIndex = 72
        Me.PictureBox2.TabStop = False
        '
        'GCPrincipal
        '
        Me.GCPrincipal.Location = New System.Drawing.Point(495, 24)
        Me.GCPrincipal.MainView = Me.DgvUsuario
        Me.GCPrincipal.Name = "GCPrincipal"
        Me.GCPrincipal.Size = New System.Drawing.Size(845, 436)
        Me.GCPrincipal.TabIndex = 104
        Me.GCPrincipal.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DgvUsuario})
        '
        'DgvUsuario
        '
        Me.DgvUsuario.Appearance.FieldCaption.Font = New System.Drawing.Font("Tahoma", 14.25!)
        Me.DgvUsuario.Appearance.FieldCaption.ForeColor = System.Drawing.Color.Blue
        Me.DgvUsuario.Appearance.FieldCaption.Options.UseFont = True
        Me.DgvUsuario.Appearance.FieldCaption.Options.UseForeColor = True
        Me.DgvUsuario.Appearance.FieldCaption.Options.UseTextOptions = True
        Me.DgvUsuario.Appearance.FieldCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.DgvUsuario.Appearance.FieldValue.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.DgvUsuario.Appearance.FieldValue.Options.UseFont = True
        Me.DgvUsuario.CardMinSize = New System.Drawing.Size(159, 250)
        Me.DgvUsuario.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() {Me.ColIdUsuario, Me.ColUsuario, Me.ColNombre, Me.ColTipoAcceso, Me.ColEstado, Me.ColContrasena})
        GridFormatRule1.ApplyToRow = True
        GridFormatRule1.Column = Me.ColEstado
        GridFormatRule1.Name = "Estado"
        FormatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.Red
        FormatConditionRuleValue1.Appearance.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        FormatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.White
        FormatConditionRuleValue1.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue1.Appearance.Options.UseFont = True
        FormatConditionRuleValue1.Appearance.Options.UseForeColor = True
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.NotEqual
        FormatConditionRuleValue1.Value1 = "Activo"
        GridFormatRule1.Rule = FormatConditionRuleValue1
        Me.DgvUsuario.FormatRules.Add(GridFormatRule1)
        Me.DgvUsuario.GridControl = Me.GCPrincipal
        Me.DgvUsuario.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_ColContrasena})
        Me.DgvUsuario.Name = "DgvUsuario"
        Me.DgvUsuario.OptionsBehavior.AutoSelectAllInEditor = False
        Me.DgvUsuario.OptionsBehavior.Editable = False
        Me.DgvUsuario.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.DgvUsuario.OptionsFind.AlwaysVisible = True
        Me.DgvUsuario.OptionsFind.FindNullPrompt = "Introduzca municipio a buscar..."
        Me.DgvUsuario.OptionsItemText.TextToControlDistance = 6
        Me.DgvUsuario.TemplateCard = Me.LayoutViewCard1
        '
        'ColIdUsuario
        '
        Me.ColIdUsuario.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColIdUsuario.AppearanceCell.Options.UseFont = True
        Me.ColIdUsuario.AppearanceCell.Options.UseTextOptions = True
        Me.ColIdUsuario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColIdUsuario.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColIdUsuario.AppearanceHeader.Options.UseFont = True
        Me.ColIdUsuario.AppearanceHeader.Options.UseTextOptions = True
        Me.ColIdUsuario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColIdUsuario.Caption = "ID"
        Me.ColIdUsuario.FieldName = "IdUsuario"
        Me.ColIdUsuario.LayoutViewField = Me.layoutViewField_ColIdUsuario
        Me.ColIdUsuario.Name = "ColIdUsuario"
        Me.ColIdUsuario.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdMunicipio", "{0}")})
        Me.ColIdUsuario.Width = 126
        '
        'layoutViewField_ColIdUsuario
        '
        Me.layoutViewField_ColIdUsuario.EditorPreferredWidth = 221
        Me.layoutViewField_ColIdUsuario.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_ColIdUsuario.Name = "layoutViewField_ColIdUsuario"
        Me.layoutViewField_ColIdUsuario.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10)
        Me.layoutViewField_ColIdUsuario.Size = New System.Drawing.Size(338, 42)
        Me.layoutViewField_ColIdUsuario.Spacing = New DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1)
        Me.layoutViewField_ColIdUsuario.TextLocation = DevExpress.Utils.Locations.Left
        Me.layoutViewField_ColIdUsuario.TextSize = New System.Drawing.Size(89, 13)
        '
        'ColUsuario
        '
        Me.ColUsuario.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColUsuario.AppearanceCell.Options.UseFont = True
        Me.ColUsuario.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColUsuario.AppearanceHeader.Options.UseFont = True
        Me.ColUsuario.AppearanceHeader.Options.UseTextOptions = True
        Me.ColUsuario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColUsuario.Caption = "Usuario"
        Me.ColUsuario.FieldName = "Usuario"
        Me.ColUsuario.LayoutViewField = Me.layoutViewField_ColUsuario
        Me.ColUsuario.Name = "ColUsuario"
        Me.ColUsuario.Width = 188
        '
        'layoutViewField_ColUsuario
        '
        Me.layoutViewField_ColUsuario.EditorPreferredWidth = 221
        Me.layoutViewField_ColUsuario.Location = New System.Drawing.Point(0, 42)
        Me.layoutViewField_ColUsuario.Name = "layoutViewField_ColUsuario"
        Me.layoutViewField_ColUsuario.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10)
        Me.layoutViewField_ColUsuario.Size = New System.Drawing.Size(338, 42)
        Me.layoutViewField_ColUsuario.Spacing = New DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1)
        Me.layoutViewField_ColUsuario.TextLocation = DevExpress.Utils.Locations.Left
        Me.layoutViewField_ColUsuario.TextSize = New System.Drawing.Size(89, 13)
        '
        'ColNombre
        '
        Me.ColNombre.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColNombre.AppearanceCell.Options.UseFont = True
        Me.ColNombre.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColNombre.AppearanceHeader.Options.UseFont = True
        Me.ColNombre.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNombre.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNombre.Caption = "Nombre Completo"
        Me.ColNombre.FieldName = "Nombre_Completo"
        Me.ColNombre.LayoutViewField = Me.layoutViewField_ColNombre
        Me.ColNombre.Name = "ColNombre"
        Me.ColNombre.Width = 376
        '
        'layoutViewField_ColNombre
        '
        Me.layoutViewField_ColNombre.EditorPreferredWidth = 221
        Me.layoutViewField_ColNombre.Location = New System.Drawing.Point(0, 84)
        Me.layoutViewField_ColNombre.Name = "layoutViewField_ColNombre"
        Me.layoutViewField_ColNombre.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10)
        Me.layoutViewField_ColNombre.Size = New System.Drawing.Size(338, 42)
        Me.layoutViewField_ColNombre.Spacing = New DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1)
        Me.layoutViewField_ColNombre.TextLocation = DevExpress.Utils.Locations.Left
        Me.layoutViewField_ColNombre.TextSize = New System.Drawing.Size(89, 13)
        '
        'ColTipoAcceso
        '
        Me.ColTipoAcceso.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColTipoAcceso.AppearanceCell.Options.UseFont = True
        Me.ColTipoAcceso.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColTipoAcceso.AppearanceHeader.Options.UseFont = True
        Me.ColTipoAcceso.AppearanceHeader.Options.UseTextOptions = True
        Me.ColTipoAcceso.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColTipoAcceso.Caption = "TipoAcceso"
        Me.ColTipoAcceso.FieldName = "TipoAcceso"
        Me.ColTipoAcceso.LayoutViewField = Me.layoutViewField_ColTipoAcceso
        Me.ColTipoAcceso.Name = "ColTipoAcceso"
        Me.ColTipoAcceso.Width = 204
        '
        'layoutViewField_ColTipoAcceso
        '
        Me.layoutViewField_ColTipoAcceso.EditorPreferredWidth = 221
        Me.layoutViewField_ColTipoAcceso.Location = New System.Drawing.Point(0, 126)
        Me.layoutViewField_ColTipoAcceso.Name = "layoutViewField_ColTipoAcceso"
        Me.layoutViewField_ColTipoAcceso.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10)
        Me.layoutViewField_ColTipoAcceso.Size = New System.Drawing.Size(338, 42)
        Me.layoutViewField_ColTipoAcceso.Spacing = New DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1)
        Me.layoutViewField_ColTipoAcceso.TextLocation = DevExpress.Utils.Locations.Left
        Me.layoutViewField_ColTipoAcceso.TextSize = New System.Drawing.Size(89, 13)
        '
        'ColContrasena
        '
        Me.ColContrasena.Caption = "GridColumn1"
        Me.ColContrasena.FieldName = "Contrasena"
        Me.ColContrasena.LayoutViewField = Me.layoutViewField_ColContrasena
        Me.ColContrasena.Name = "ColContrasena"
        '
        'layoutViewField_ColContrasena
        '
        Me.layoutViewField_ColContrasena.EditorPreferredWidth = 20
        Me.layoutViewField_ColContrasena.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_ColContrasena.Name = "layoutViewField_ColContrasena"
        Me.layoutViewField_ColContrasena.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10)
        Me.layoutViewField_ColContrasena.Size = New System.Drawing.Size(338, 210)
        Me.layoutViewField_ColContrasena.Spacing = New DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1)
        Me.layoutViewField_ColContrasena.TextLocation = DevExpress.Utils.Locations.Left
        Me.layoutViewField_ColContrasena.TextSize = New System.Drawing.Size(89, 20)
        '
        'LayoutViewCard1
        '
        Me.LayoutViewCard1.CustomizationFormText = "TemplateCard"
        Me.LayoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.LayoutViewCard1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_ColIdUsuario, Me.layoutViewField_ColUsuario, Me.layoutViewField_ColNombre, Me.layoutViewField_ColTipoAcceso, Me.layoutViewField_ColEstado})
        Me.LayoutViewCard1.Name = "layoutViewTemplateCard"
        Me.LayoutViewCard1.OptionsItemText.TextToControlDistance = 6
        Me.LayoutViewCard1.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10)
        Me.LayoutViewCard1.Text = "TemplateCard"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Image = CType(resources.GetObject("SimpleButton5.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(662, 466)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton5.TabIndex = 134
        Me.SimpleButton5.Text = "Actualizar Datos"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(833, 466)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton4.TabIndex = 133
        Me.SimpleButton4.Text = "Exportar PDF"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(1004, 466)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton2.TabIndex = 132
        Me.SimpleButton2.Text = "Exportar Excel"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(1175, 466)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton1.TabIndex = 131
        Me.SimpleButton1.Text = "Vista Previa"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnCancelar.Location = New System.Drawing.Point(355, 475)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(98, 68)
        Me.BtnCancelar.TabIndex = 138
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.Visible = False
        '
        'BtnEditar
        '
        Me.BtnEditar.Image = CType(resources.GetObject("BtnEditar.Image"), System.Drawing.Image)
        Me.BtnEditar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnEditar.Location = New System.Drawing.Point(147, 475)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(98, 68)
        Me.BtnEditar.TabIndex = 136
        Me.BtnEditar.Text = "Editar"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnNuevo.Location = New System.Drawing.Point(43, 475)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(98, 68)
        Me.BtnNuevo.TabIndex = 135
        Me.BtnNuevo.Text = "Nuevo"
        '
        'BtnInsertar
        '
        Me.BtnInsertar.Image = CType(resources.GetObject("BtnInsertar.Image"), System.Drawing.Image)
        Me.BtnInsertar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnInsertar.Location = New System.Drawing.Point(251, 475)
        Me.BtnInsertar.Name = "BtnInsertar"
        Me.BtnInsertar.Size = New System.Drawing.Size(98, 68)
        Me.BtnInsertar.TabIndex = 139
        Me.BtnInsertar.Text = "Guardar"
        Me.BtnInsertar.Visible = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Image = CType(resources.GetObject("BtnActualizar.Image"), System.Drawing.Image)
        Me.BtnActualizar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnActualizar.Location = New System.Drawing.Point(251, 475)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(98, 68)
        Me.BtnActualizar.TabIndex = 137
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.Visible = False
        '
        'GbUsuario
        '
        Me.GbUsuario.Controls.Add(Me.CboTipoA)
        Me.GbUsuario.Controls.Add(Me.CboEmpleado)
        Me.GbUsuario.Controls.Add(Me.ChkVer)
        Me.GbUsuario.Controls.Add(Me.TxtContra2)
        Me.GbUsuario.Controls.Add(Me.TxtContra)
        Me.GbUsuario.Controls.Add(Me.TxtUsuario)
        Me.GbUsuario.Controls.Add(Me.TxtIdUsuario)
        Me.GbUsuario.Controls.Add(Me.RdbInactivo)
        Me.GbUsuario.Controls.Add(Me.RdbActivo)
        Me.GbUsuario.Controls.Add(Me.Label6)
        Me.GbUsuario.Controls.Add(Me.Label5)
        Me.GbUsuario.Controls.Add(Me.Label8)
        Me.GbUsuario.Controls.Add(Me.Label3)
        Me.GbUsuario.Controls.Add(Me.Label4)
        Me.GbUsuario.Controls.Add(Me.Label2)
        Me.GbUsuario.Controls.Add(Me.Label1)
        Me.GbUsuario.Enabled = False
        Me.GbUsuario.Location = New System.Drawing.Point(30, 82)
        Me.GbUsuario.Name = "GbUsuario"
        Me.GbUsuario.Size = New System.Drawing.Size(423, 292)
        Me.GbUsuario.TabIndex = 144
        Me.GbUsuario.Text = "Datos Usuario"
        '
        'CboTipoA
        '
        Me.CboTipoA.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Hide
        Me.CboTipoA.DropDownControl = Me.PopupMenu1
        Me.CboTipoA.Location = New System.Drawing.Point(136, 226)
        Me.CboTipoA.Name = "CboTipoA"
        Me.CboTipoA.Size = New System.Drawing.Size(229, 23)
        Me.CboTipoA.TabIndex = 127
        Me.CboTipoA.Text = "Administrador"
        '
        'CboEmpleado
        '
        Me.CboEmpleado.EditValue = ""
        Me.CboEmpleado.Location = New System.Drawing.Point(136, 187)
        Me.CboEmpleado.Name = "CboEmpleado"
        Me.CboEmpleado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CboEmpleado.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CboEmpleado.Properties.DisplayMember = "Nombre"
        Me.CboEmpleado.Properties.NullText = "SELECCIONE EMPLEADO"
        Me.CboEmpleado.Properties.ValueMember = "IdEmpleado"
        Me.CboEmpleado.Properties.View = Me.SearchLookUpEdit1View
        Me.CboEmpleado.Size = New System.Drawing.Size(282, 20)
        Me.CboEmpleado.TabIndex = 126
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SearchLookUpEdit1View.Appearance.Empty.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SearchLookUpEdit1View.Appearance.Empty.Options.UseBackColor = True
        Me.SearchLookUpEdit1View.Appearance.FocusedCell.BackColor = System.Drawing.Color.DodgerBlue
        Me.SearchLookUpEdit1View.Appearance.FocusedCell.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.SearchLookUpEdit1View.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.SearchLookUpEdit1View.Appearance.FocusedCell.Options.UseBackColor = True
        Me.SearchLookUpEdit1View.Appearance.FocusedCell.Options.UseFont = True
        Me.SearchLookUpEdit1View.Appearance.FocusedCell.Options.UseForeColor = True
        Me.SearchLookUpEdit1View.Appearance.FocusedRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.SearchLookUpEdit1View.Appearance.FocusedRow.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.SearchLookUpEdit1View.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.SearchLookUpEdit1View.Appearance.FocusedRow.Options.UseBackColor = True
        Me.SearchLookUpEdit1View.Appearance.FocusedRow.Options.UseFont = True
        Me.SearchLookUpEdit1View.Appearance.FocusedRow.Options.UseForeColor = True
        Me.SearchLookUpEdit1View.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.SearchLookUpEdit1View.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.SearchLookUpEdit1View.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White
        Me.SearchLookUpEdit1View.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.SearchLookUpEdit1View.Appearance.HideSelectionRow.Options.UseFont = True
        Me.SearchLookUpEdit1View.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.SearchLookUpEdit1View.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.SearchLookUpEdit1View.Appearance.HorzLine.Options.UseBackColor = True
        Me.SearchLookUpEdit1View.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SearchLookUpEdit1View.Appearance.Row.Options.UseBackColor = True
        Me.SearchLookUpEdit1View.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.SearchLookUpEdit1View.Appearance.VertLine.Options.UseBackColor = True
        Me.SearchLookUpEdit1View.ColumnPanelRowHeight = 26
        Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsBehavior.AllowIncrementalSearch = True
        Me.SearchLookUpEdit1View.OptionsBehavior.Editable = False
        Me.SearchLookUpEdit1View.OptionsFind.AlwaysVisible = True
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.EnableAppearanceEvenRow = True
        Me.SearchLookUpEdit1View.OptionsView.EnableAppearanceOddRow = True
        Me.SearchLookUpEdit1View.OptionsView.ShowFooter = True
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        Me.SearchLookUpEdit1View.RowHeight = 22
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.GridColumn1.AppearanceCell.Options.UseFont = True
        Me.GridColumn1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.GridColumn1.AppearanceHeader.Options.UseFont = True
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "Identidad"
        Me.GridColumn1.FieldName = "IdEmpleado"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Identidad", "Total = {0}")})
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 242
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.GridColumn2.AppearanceCell.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.GridColumn2.AppearanceHeader.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Nombre Completo"
        Me.GridColumn2.FieldName = "Nombre"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 836
        '
        'ChkVer
        '
        Me.ChkVer.Location = New System.Drawing.Point(345, 110)
        Me.ChkVer.Name = "ChkVer"
        Me.ChkVer.Properties.Caption = "Ver"
        Me.ChkVer.Size = New System.Drawing.Size(47, 19)
        Me.ChkVer.TabIndex = 125
        '
        'TxtContra2
        '
        Me.TxtContra2.Location = New System.Drawing.Point(136, 148)
        Me.TxtContra2.Name = "TxtContra2"
        Me.TxtContra2.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtContra2.Size = New System.Drawing.Size(203, 20)
        Me.TxtContra2.TabIndex = 124
        '
        'TxtContra
        '
        Me.TxtContra.Location = New System.Drawing.Point(136, 109)
        Me.TxtContra.Name = "TxtContra"
        Me.TxtContra.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtContra.Size = New System.Drawing.Size(203, 20)
        Me.TxtContra.TabIndex = 123
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Location = New System.Drawing.Point(137, 66)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(203, 20)
        Me.TxtUsuario.TabIndex = 122
        '
        'TxtIdUsuario
        '
        Me.TxtIdUsuario.Enabled = False
        Me.TxtIdUsuario.Location = New System.Drawing.Point(137, 26)
        Me.TxtIdUsuario.Name = "TxtIdUsuario"
        Me.TxtIdUsuario.Size = New System.Drawing.Size(203, 20)
        Me.TxtIdUsuario.TabIndex = 121
        '
        'RdbInactivo
        '
        Me.RdbInactivo.AutoSize = True
        Me.RdbInactivo.Location = New System.Drawing.Point(205, 255)
        Me.RdbInactivo.Name = "RdbInactivo"
        Me.RdbInactivo.Size = New System.Drawing.Size(64, 17)
        Me.RdbInactivo.TabIndex = 120
        Me.RdbInactivo.TabStop = True
        Me.RdbInactivo.Text = "Inactivo"
        Me.RdbInactivo.UseVisualStyleBackColor = True
        '
        'RdbActivo
        '
        Me.RdbActivo.AutoSize = True
        Me.RdbActivo.Location = New System.Drawing.Point(137, 255)
        Me.RdbActivo.Name = "RdbActivo"
        Me.RdbActivo.Size = New System.Drawing.Size(55, 17)
        Me.RdbActivo.TabIndex = 119
        Me.RdbActivo.TabStop = True
        Me.RdbActivo.Text = "Activo"
        Me.RdbActivo.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(77, 255)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 19)
        Me.Label6.TabIndex = 118
        Me.Label6.Text = "Estado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 19)
        Me.Label5.TabIndex = 117
        Me.Label5.Text = "Repetir Contraseña"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(26, 226)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 19)
        Me.Label8.TabIndex = 116
        Me.Label8.Text = "Tipo de Acceso"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(66, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 19)
        Me.Label3.TabIndex = 115
        Me.Label3.Text = "Empleado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(55, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 19)
        Me.Label4.TabIndex = 114
        Me.Label4.Text = "Contraseña"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(77, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 19)
        Me.Label2.TabIndex = 113
        Me.Label2.Text = "Usuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 19)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "Código Usuario"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.LabelControl1.Location = New System.Drawing.Point(90, 24)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(238, 43)
        Me.LabelControl1.TabIndex = 149
        Me.LabelControl1.Text = "Perfil del Usuario"
        '
        'FrmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 573)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.GbUsuario)
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
        Me.Controls.Add(Me.LblRespaldo)
        Me.Controls.Add(Me.LblFilas)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TableOfContents)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmUsuario"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuario"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.layoutViewField_ColEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_ColIdUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_ColUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_ColNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_ColTipoAcceso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_ColContrasena, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GbUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbUsuario.ResumeLayout(False)
        Me.GbUsuario.PerformLayout()
        CType(Me.CboEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkVer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtContra2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtContra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtIdUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LblRespaldo As Label
    Friend WithEvents LblFilas As Label
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents GCPrincipal As DevExpress.XtraGrid.GridControl
    Friend WithEvents DgvUsuario As DevExpress.XtraGrid.Views.Layout.LayoutView
    Friend WithEvents ColIdUsuario As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents ColUsuario As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents ColNombre As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents ColTipoAcceso As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents ColEstado As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents ColContrasena As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_ColEstado As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_ColIdUsuario As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_ColUsuario As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_ColNombre As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_ColTipoAcceso As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_ColContrasena As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents LayoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnEditar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnInsertar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnActualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents GbUsuario As DevExpress.XtraEditors.GroupControl
    Friend WithEvents CboTipoA As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents CboEmpleado As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChkVer As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents TxtContra2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtContra As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtUsuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtIdUsuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RdbInactivo As RadioButton
    Friend WithEvents RdbActivo As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
