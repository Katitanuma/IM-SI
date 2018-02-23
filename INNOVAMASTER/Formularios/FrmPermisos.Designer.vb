<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPermisos
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
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPermisos))
        Me.ColEstado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GCPrincipal = New DevExpress.XtraGrid.GridControl()
        Me.DgvUsuario = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColIdUsuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColUsuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColTipoAcceso = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SplitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GCPP = New DevExpress.XtraGrid.GridControl()
        Me.DgvD = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColIdPermiso1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColIdUsuario1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPermiso1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SplitterControl1 = New DevExpress.XtraEditors.SplitterControl()
        Me.GCPD = New DevExpress.XtraGrid.GridControl()
        Me.DgvP = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColIdPermiso2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColIdUsuario2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPermiso2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.GCPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl2.SuspendLayout()
        CType(Me.GCPP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.GCPD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvP, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ColEstado.Name = "ColEstado"
        Me.ColEstado.Visible = True
        Me.ColEstado.VisibleIndex = 4
        Me.ColEstado.Width = 183
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GCPrincipal)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.SplitContainerControl2)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1354, 733)
        Me.SplitContainerControl1.SplitterPosition = 268
        Me.SplitContainerControl1.TabIndex = 0
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'GCPrincipal
        '
        Me.GCPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.GCPrincipal.MainView = Me.DgvUsuario
        Me.GCPrincipal.Name = "GCPrincipal"
        Me.GCPrincipal.Size = New System.Drawing.Size(1354, 268)
        Me.GCPrincipal.TabIndex = 103
        Me.GCPrincipal.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DgvUsuario})
        '
        'DgvUsuario
        '
        Me.DgvUsuario.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvUsuario.Appearance.Empty.Options.UseBackColor = True
        Me.DgvUsuario.Appearance.FocusedCell.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvUsuario.Appearance.FocusedCell.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DgvUsuario.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.DgvUsuario.Appearance.FocusedCell.Options.UseBackColor = True
        Me.DgvUsuario.Appearance.FocusedCell.Options.UseFont = True
        Me.DgvUsuario.Appearance.FocusedCell.Options.UseForeColor = True
        Me.DgvUsuario.Appearance.FocusedRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvUsuario.Appearance.FocusedRow.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DgvUsuario.Appearance.FocusedRow.Options.UseBackColor = True
        Me.DgvUsuario.Appearance.FocusedRow.Options.UseFont = True
        Me.DgvUsuario.Appearance.FooterPanel.Options.UseTextOptions = True
        Me.DgvUsuario.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.DgvUsuario.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvUsuario.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DgvUsuario.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White
        Me.DgvUsuario.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.DgvUsuario.Appearance.HideSelectionRow.Options.UseFont = True
        Me.DgvUsuario.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.DgvUsuario.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DgvUsuario.Appearance.HorzLine.Options.UseBackColor = True
        Me.DgvUsuario.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvUsuario.Appearance.Row.Options.UseBackColor = True
        Me.DgvUsuario.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvUsuario.Appearance.RowSeparator.Options.UseBackColor = True
        Me.DgvUsuario.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DgvUsuario.Appearance.VertLine.Options.UseBackColor = True
        Me.DgvUsuario.ColumnPanelRowHeight = 26
        Me.DgvUsuario.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColIdUsuario, Me.ColUsuario, Me.ColNombre, Me.ColTipoAcceso, Me.ColEstado})
        GridFormatRule1.ApplyToRow = True
        GridFormatRule1.Column = Me.ColEstado
        GridFormatRule1.Name = "Estado"
        FormatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.Red
        FormatConditionRuleValue1.Appearance.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FormatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.White
        FormatConditionRuleValue1.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue1.Appearance.Options.UseFont = True
        FormatConditionRuleValue1.Appearance.Options.UseForeColor = True
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.NotEqual
        FormatConditionRuleValue1.Value1 = "Activo"
        GridFormatRule1.Rule = FormatConditionRuleValue1
        Me.DgvUsuario.FormatRules.Add(GridFormatRule1)
        Me.DgvUsuario.GridControl = Me.GCPrincipal
        Me.DgvUsuario.Name = "DgvUsuario"
        Me.DgvUsuario.OptionsBehavior.AllowIncrementalSearch = True
        Me.DgvUsuario.OptionsBehavior.AutoSelectAllInEditor = False
        Me.DgvUsuario.OptionsBehavior.Editable = False
        Me.DgvUsuario.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.DgvUsuario.OptionsFind.FindNullPrompt = "Introduzca municipio a buscar..."
        Me.DgvUsuario.OptionsView.EnableAppearanceEvenRow = True
        Me.DgvUsuario.OptionsView.EnableAppearanceOddRow = True
        Me.DgvUsuario.OptionsView.ShowFooter = True
        Me.DgvUsuario.OptionsView.ShowGroupPanel = False
        Me.DgvUsuario.RowHeight = 22
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
        Me.ColIdUsuario.Name = "ColIdUsuario"
        Me.ColIdUsuario.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdMunicipio", "{0}")})
        Me.ColIdUsuario.Visible = True
        Me.ColIdUsuario.VisibleIndex = 0
        Me.ColIdUsuario.Width = 126
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
        Me.ColUsuario.Name = "ColUsuario"
        Me.ColUsuario.Visible = True
        Me.ColUsuario.VisibleIndex = 1
        Me.ColUsuario.Width = 188
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
        Me.ColNombre.Name = "ColNombre"
        Me.ColNombre.Visible = True
        Me.ColNombre.VisibleIndex = 2
        Me.ColNombre.Width = 376
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
        Me.ColTipoAcceso.Name = "ColTipoAcceso"
        Me.ColTipoAcceso.Visible = True
        Me.ColTipoAcceso.VisibleIndex = 3
        Me.ColTipoAcceso.Width = 204
        '
        'SplitContainerControl2
        '
        Me.SplitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl2.Name = "SplitContainerControl2"
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.GCPP)
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainerControl2.Panel1.Text = "Panel1"
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.GCPD)
        Me.SplitContainerControl2.Panel2.Text = "Panel2"
        Me.SplitContainerControl2.Size = New System.Drawing.Size(1354, 459)
        Me.SplitContainerControl2.SplitterPosition = 710
        Me.SplitContainerControl2.TabIndex = 0
        Me.SplitContainerControl2.Text = "SplitContainerControl2"
        '
        'GCPP
        '
        Me.GCPP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCPP.Location = New System.Drawing.Point(0, 0)
        Me.GCPP.MainView = Me.DgvD
        Me.GCPP.Name = "GCPP"
        Me.GCPP.Size = New System.Drawing.Size(647, 459)
        Me.GCPP.TabIndex = 105
        Me.GCPP.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DgvD})
        '
        'DgvD
        '
        Me.DgvD.Appearance.Empty.BackColor = System.Drawing.Color.Linen
        Me.DgvD.Appearance.Empty.Options.UseBackColor = True
        Me.DgvD.Appearance.FocusedCell.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvD.Appearance.FocusedCell.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvD.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.DgvD.Appearance.FocusedCell.Options.UseBackColor = True
        Me.DgvD.Appearance.FocusedCell.Options.UseFont = True
        Me.DgvD.Appearance.FocusedCell.Options.UseForeColor = True
        Me.DgvD.Appearance.FocusedRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvD.Appearance.FocusedRow.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvD.Appearance.FocusedRow.Options.UseBackColor = True
        Me.DgvD.Appearance.FocusedRow.Options.UseFont = True
        Me.DgvD.Appearance.FooterPanel.Options.UseTextOptions = True
        Me.DgvD.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.DgvD.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvD.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvD.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White
        Me.DgvD.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.DgvD.Appearance.HideSelectionRow.Options.UseFont = True
        Me.DgvD.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.DgvD.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DgvD.Appearance.HorzLine.Options.UseBackColor = True
        Me.DgvD.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DgvD.Appearance.OddRow.Options.UseBackColor = True
        Me.DgvD.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DgvD.Appearance.Row.Options.UseBackColor = True
        Me.DgvD.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvD.Appearance.RowSeparator.Options.UseBackColor = True
        Me.DgvD.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DgvD.Appearance.VertLine.Options.UseBackColor = True
        Me.DgvD.ColumnPanelRowHeight = 26
        Me.DgvD.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColIdPermiso1, Me.ColIdUsuario1, Me.ColPermiso1})
        Me.DgvD.GridControl = Me.GCPP
        Me.DgvD.Name = "DgvD"
        Me.DgvD.OptionsBehavior.AllowIncrementalSearch = True
        Me.DgvD.OptionsBehavior.AutoSelectAllInEditor = False
        Me.DgvD.OptionsBehavior.Editable = False
        Me.DgvD.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.DgvD.OptionsFind.FindNullPrompt = "Introduzca municipio a buscar..."
        Me.DgvD.OptionsView.EnableAppearanceEvenRow = True
        Me.DgvD.OptionsView.EnableAppearanceOddRow = True
        Me.DgvD.OptionsView.ShowFooter = True
        Me.DgvD.OptionsView.ShowGroupPanel = False
        Me.DgvD.RowHeight = 22
        '
        'ColIdPermiso1
        '
        Me.ColIdPermiso1.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColIdPermiso1.AppearanceCell.Options.UseFont = True
        Me.ColIdPermiso1.AppearanceCell.Options.UseTextOptions = True
        Me.ColIdPermiso1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColIdPermiso1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColIdPermiso1.AppearanceHeader.Options.UseFont = True
        Me.ColIdPermiso1.AppearanceHeader.Options.UseTextOptions = True
        Me.ColIdPermiso1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColIdPermiso1.Caption = "ID"
        Me.ColIdPermiso1.FieldName = "IdPermiso"
        Me.ColIdPermiso1.Name = "ColIdPermiso1"
        Me.ColIdPermiso1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdMunicipio", "{0}")})
        Me.ColIdPermiso1.Width = 164
        '
        'ColIdUsuario1
        '
        Me.ColIdUsuario1.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColIdUsuario1.AppearanceCell.Options.UseFont = True
        Me.ColIdUsuario1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColIdUsuario1.AppearanceHeader.Options.UseFont = True
        Me.ColIdUsuario1.AppearanceHeader.Options.UseTextOptions = True
        Me.ColIdUsuario1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColIdUsuario1.Caption = "IDUsuario"
        Me.ColIdUsuario1.FieldName = "IdUsuario"
        Me.ColIdUsuario1.Name = "ColIdUsuario1"
        Me.ColIdUsuario1.Width = 470
        '
        'ColPermiso1
        '
        Me.ColPermiso1.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColPermiso1.AppearanceCell.Options.UseFont = True
        Me.ColPermiso1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColPermiso1.AppearanceHeader.Options.UseFont = True
        Me.ColPermiso1.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPermiso1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPermiso1.Caption = "PERMISOS DENEGADOS"
        Me.ColPermiso1.FieldName = "Pemisos"
        Me.ColPermiso1.Name = "ColPermiso1"
        Me.ColPermiso1.Visible = True
        Me.ColPermiso1.VisibleIndex = 0
        Me.ColPermiso1.Width = 443
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SimpleButton3)
        Me.Panel1.Controls.Add(Me.SimpleButton2)
        Me.Panel1.Controls.Add(Me.SimpleButton1)
        Me.Panel1.Controls.Add(Me.SplitterControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(647, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(63, 459)
        Me.Panel1.TabIndex = 0
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.SimpleButton3.Location = New System.Drawing.Point(9, 174)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(49, 45)
        Me.SimpleButton3.TabIndex = 3
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.SimpleButton2.Location = New System.Drawing.Point(9, 123)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(49, 45)
        Me.SimpleButton2.TabIndex = 2
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.SimpleButton1.Location = New System.Drawing.Point(9, 72)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(49, 45)
        Me.SimpleButton1.TabIndex = 1
        '
        'SplitterControl1
        '
        Me.SplitterControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitterControl1.Name = "SplitterControl1"
        Me.SplitterControl1.Size = New System.Drawing.Size(6, 459)
        Me.SplitterControl1.TabIndex = 0
        Me.SplitterControl1.TabStop = False
        '
        'GCPD
        '
        Me.GCPD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCPD.Location = New System.Drawing.Point(0, 0)
        Me.GCPD.MainView = Me.DgvP
        Me.GCPD.Name = "GCPD"
        Me.GCPD.Size = New System.Drawing.Size(638, 459)
        Me.GCPD.TabIndex = 106
        Me.GCPD.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DgvP})
        '
        'DgvP
        '
        Me.DgvP.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DgvP.Appearance.Empty.Options.UseBackColor = True
        Me.DgvP.Appearance.FocusedCell.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvP.Appearance.FocusedCell.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvP.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.DgvP.Appearance.FocusedCell.Options.UseBackColor = True
        Me.DgvP.Appearance.FocusedCell.Options.UseFont = True
        Me.DgvP.Appearance.FocusedCell.Options.UseForeColor = True
        Me.DgvP.Appearance.FocusedRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvP.Appearance.FocusedRow.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvP.Appearance.FocusedRow.Options.UseBackColor = True
        Me.DgvP.Appearance.FocusedRow.Options.UseFont = True
        Me.DgvP.Appearance.FooterPanel.Options.UseTextOptions = True
        Me.DgvP.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.DgvP.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvP.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvP.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White
        Me.DgvP.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.DgvP.Appearance.HideSelectionRow.Options.UseFont = True
        Me.DgvP.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.DgvP.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DgvP.Appearance.HorzLine.Options.UseBackColor = True
        Me.DgvP.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DgvP.Appearance.OddRow.Options.UseBackColor = True
        Me.DgvP.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DgvP.Appearance.Row.Options.UseBackColor = True
        Me.DgvP.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvP.Appearance.RowSeparator.Options.UseBackColor = True
        Me.DgvP.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DgvP.Appearance.VertLine.Options.UseBackColor = True
        Me.DgvP.ColumnPanelRowHeight = 26
        Me.DgvP.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColIdPermiso2, Me.ColIdUsuario2, Me.ColPermiso2})
        Me.DgvP.GridControl = Me.GCPD
        Me.DgvP.Name = "DgvP"
        Me.DgvP.OptionsBehavior.AllowIncrementalSearch = True
        Me.DgvP.OptionsBehavior.AutoSelectAllInEditor = False
        Me.DgvP.OptionsBehavior.Editable = False
        Me.DgvP.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.DgvP.OptionsFind.FindNullPrompt = "Introduzca municipio a buscar..."
        Me.DgvP.OptionsView.EnableAppearanceEvenRow = True
        Me.DgvP.OptionsView.EnableAppearanceOddRow = True
        Me.DgvP.OptionsView.ShowFooter = True
        Me.DgvP.OptionsView.ShowGroupPanel = False
        Me.DgvP.RowHeight = 22
        '
        'ColIdPermiso2
        '
        Me.ColIdPermiso2.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColIdPermiso2.AppearanceCell.Options.UseFont = True
        Me.ColIdPermiso2.AppearanceCell.Options.UseTextOptions = True
        Me.ColIdPermiso2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColIdPermiso2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColIdPermiso2.AppearanceHeader.Options.UseFont = True
        Me.ColIdPermiso2.AppearanceHeader.Options.UseTextOptions = True
        Me.ColIdPermiso2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColIdPermiso2.Caption = "ID"
        Me.ColIdPermiso2.FieldName = "IdPermiso"
        Me.ColIdPermiso2.Name = "ColIdPermiso2"
        Me.ColIdPermiso2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdMunicipio", "{0}")})
        Me.ColIdPermiso2.Width = 164
        '
        'ColIdUsuario2
        '
        Me.ColIdUsuario2.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColIdUsuario2.AppearanceCell.Options.UseFont = True
        Me.ColIdUsuario2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColIdUsuario2.AppearanceHeader.Options.UseFont = True
        Me.ColIdUsuario2.AppearanceHeader.Options.UseTextOptions = True
        Me.ColIdUsuario2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColIdUsuario2.Caption = "IDUsuario"
        Me.ColIdUsuario2.FieldName = "IdUsuario"
        Me.ColIdUsuario2.Name = "ColIdUsuario2"
        Me.ColIdUsuario2.Width = 470
        '
        'ColPermiso2
        '
        Me.ColPermiso2.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColPermiso2.AppearanceCell.Options.UseFont = True
        Me.ColPermiso2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColPermiso2.AppearanceHeader.Options.UseFont = True
        Me.ColPermiso2.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPermiso2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPermiso2.Caption = "PERMISOS AUTORIZADOS"
        Me.ColPermiso2.FieldName = "Pemisos"
        Me.ColPermiso2.Name = "ColPermiso2"
        Me.ColPermiso2.Visible = True
        Me.ColPermiso2.VisibleIndex = 0
        Me.ColPermiso2.Width = 443
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.GridColumn5.AppearanceCell.Options.UseFont = True
        Me.GridColumn5.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.GridColumn5.AppearanceHeader.Options.UseFont = True
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "Municipio"
        Me.GridColumn5.FieldName = "Municipio"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Width = 470
        '
        'FrmPermisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPermisos"
        Me.Text = "Permisos Usuarios"
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.GCPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl2.ResumeLayout(False)
        CType(Me.GCPP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.GCPD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents GCPrincipal As DevExpress.XtraGrid.GridControl
    Friend WithEvents DgvUsuario As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColIdUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SplitterControl1 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents ColTipoAcceso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GCPP As DevExpress.XtraGrid.GridControl
    Friend WithEvents DgvD As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColIdPermiso1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColIdUsuario1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPermiso1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCPD As DevExpress.XtraGrid.GridControl
    Friend WithEvents DgvP As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColIdPermiso2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColIdUsuario2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPermiso2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
End Class
