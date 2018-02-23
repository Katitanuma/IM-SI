<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMunicipio
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMunicipio))
        Me.LblFilas = New System.Windows.Forms.Label()
        Me.CboDepartamento = New DevExpress.XtraEditors.LookUpEdit()
        Me.TxtIdMunicipio = New DevExpress.XtraEditors.TextEdit()
        Me.TxtMunicipio = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.GCPrincipal = New DevExpress.XtraGrid.GridControl()
        Me.DgvMunicipio = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColIdMunicipio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColMunicipio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDepartamento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.GbMunicipio = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.Codigo = New DevExpress.XtraEditors.LabelControl()
        Me.BtnNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnEditar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnActualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnInsertar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.CboDepartamento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtIdMunicipio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMunicipio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvMunicipio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GbMunicipio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbMunicipio.SuspendLayout()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblFilas
        '
        Me.LblFilas.AutoSize = True
        Me.LblFilas.Location = New System.Drawing.Point(956, 329)
        Me.LblFilas.Name = "LblFilas"
        Me.LblFilas.Size = New System.Drawing.Size(61, 13)
        Me.LblFilas.TabIndex = 94
        Me.LblFilas.Text = "SIN DATOS"
        Me.LblFilas.Visible = False
        '
        'CboDepartamento
        '
        Me.CboDepartamento.Location = New System.Drawing.Point(129, 112)
        Me.CboDepartamento.Name = "CboDepartamento"
        Me.CboDepartamento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CboDepartamento.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CboDepartamento.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdDepartamento", 10, "ID"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Departamento", 30, "Departamento"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Pais", "Pais")})
        Me.CboDepartamento.Properties.DisplayMember = "Departamento"
        Me.CboDepartamento.Properties.NullText = "Seleccione Departamento"
        Me.CboDepartamento.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.CboDepartamento.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.CboDepartamento.Properties.ValueMember = "IdDepartamento"
        Me.CboDepartamento.Size = New System.Drawing.Size(203, 20)
        Me.CboDepartamento.TabIndex = 108
        '
        'TxtIdMunicipio
        '
        Me.TxtIdMunicipio.Location = New System.Drawing.Point(129, 25)
        Me.TxtIdMunicipio.Name = "TxtIdMunicipio"
        Me.TxtIdMunicipio.Size = New System.Drawing.Size(239, 20)
        Me.TxtIdMunicipio.TabIndex = 107
        '
        'TxtMunicipio
        '
        Me.TxtMunicipio.Location = New System.Drawing.Point(129, 68)
        Me.TxtMunicipio.Name = "TxtMunicipio"
        Me.TxtMunicipio.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMunicipio.Size = New System.Drawing.Size(239, 20)
        Me.TxtMunicipio.TabIndex = 106
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Location = New System.Drawing.Point(338, 110)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(30, 23)
        Me.SimpleButton3.TabIndex = 105
        Me.SimpleButton3.Text = "..."
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.INNOVAMASTER.My.Resources.Resources.aguascalientes
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(32, 31)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(59, 59)
        Me.PictureBox2.TabIndex = 96
        Me.PictureBox2.TabStop = False
        '
        'GCPrincipal
        '
        Me.GCPrincipal.Location = New System.Drawing.Point(504, 31)
        Me.GCPrincipal.MainView = Me.DgvMunicipio
        Me.GCPrincipal.Name = "GCPrincipal"
        Me.GCPrincipal.Size = New System.Drawing.Size(819, 427)
        Me.GCPrincipal.TabIndex = 102
        Me.GCPrincipal.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DgvMunicipio})
        '
        'DgvMunicipio
        '
        Me.DgvMunicipio.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvMunicipio.Appearance.Empty.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvMunicipio.Appearance.Empty.Options.UseBackColor = True
        Me.DgvMunicipio.Appearance.FocusedCell.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvMunicipio.Appearance.FocusedCell.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvMunicipio.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.DgvMunicipio.Appearance.FocusedCell.Options.UseBackColor = True
        Me.DgvMunicipio.Appearance.FocusedCell.Options.UseFont = True
        Me.DgvMunicipio.Appearance.FocusedCell.Options.UseForeColor = True
        Me.DgvMunicipio.Appearance.FocusedRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvMunicipio.Appearance.FocusedRow.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvMunicipio.Appearance.FocusedRow.Options.UseBackColor = True
        Me.DgvMunicipio.Appearance.FocusedRow.Options.UseFont = True
        Me.DgvMunicipio.Appearance.FooterPanel.Options.UseTextOptions = True
        Me.DgvMunicipio.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.DgvMunicipio.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvMunicipio.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvMunicipio.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White
        Me.DgvMunicipio.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.DgvMunicipio.Appearance.HideSelectionRow.Options.UseFont = True
        Me.DgvMunicipio.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.DgvMunicipio.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DgvMunicipio.Appearance.HorzLine.Options.UseBackColor = True
        Me.DgvMunicipio.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvMunicipio.Appearance.Row.Options.UseBackColor = True
        Me.DgvMunicipio.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvMunicipio.Appearance.RowSeparator.Options.UseBackColor = True
        Me.DgvMunicipio.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DgvMunicipio.Appearance.VertLine.Options.UseBackColor = True
        Me.DgvMunicipio.ColumnPanelRowHeight = 26
        Me.DgvMunicipio.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColIdMunicipio, Me.ColMunicipio, Me.ColDepartamento})
        Me.DgvMunicipio.GridControl = Me.GCPrincipal
        Me.DgvMunicipio.Name = "DgvMunicipio"
        Me.DgvMunicipio.OptionsBehavior.AllowIncrementalSearch = True
        Me.DgvMunicipio.OptionsBehavior.AutoSelectAllInEditor = False
        Me.DgvMunicipio.OptionsBehavior.Editable = False
        Me.DgvMunicipio.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.DgvMunicipio.OptionsFind.AlwaysVisible = True
        Me.DgvMunicipio.OptionsFind.FindNullPrompt = "Introduzca municipio a buscar..."
        Me.DgvMunicipio.OptionsView.EnableAppearanceEvenRow = True
        Me.DgvMunicipio.OptionsView.EnableAppearanceOddRow = True
        Me.DgvMunicipio.OptionsView.ShowFooter = True
        Me.DgvMunicipio.OptionsView.ShowGroupPanel = False
        Me.DgvMunicipio.RowHeight = 22
        '
        'ColIdMunicipio
        '
        Me.ColIdMunicipio.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColIdMunicipio.AppearanceCell.Options.UseFont = True
        Me.ColIdMunicipio.AppearanceCell.Options.UseTextOptions = True
        Me.ColIdMunicipio.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColIdMunicipio.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColIdMunicipio.AppearanceHeader.Options.UseFont = True
        Me.ColIdMunicipio.AppearanceHeader.Options.UseTextOptions = True
        Me.ColIdMunicipio.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColIdMunicipio.Caption = "ID"
        Me.ColIdMunicipio.FieldName = "IdMunicipio"
        Me.ColIdMunicipio.Name = "ColIdMunicipio"
        Me.ColIdMunicipio.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdMunicipio", "Total Municipios = {0}")})
        Me.ColIdMunicipio.Visible = True
        Me.ColIdMunicipio.VisibleIndex = 0
        Me.ColIdMunicipio.Width = 164
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
        Me.ColMunicipio.VisibleIndex = 1
        Me.ColMunicipio.Width = 470
        '
        'ColDepartamento
        '
        Me.ColDepartamento.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColDepartamento.AppearanceCell.Options.UseFont = True
        Me.ColDepartamento.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColDepartamento.AppearanceHeader.Options.UseFont = True
        Me.ColDepartamento.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDepartamento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDepartamento.Caption = "Departamento"
        Me.ColDepartamento.FieldName = "Departamento"
        Me.ColDepartamento.Name = "ColDepartamento"
        Me.ColDepartamento.Visible = True
        Me.ColDepartamento.VisibleIndex = 2
        Me.ColDepartamento.Width = 443
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(1158, 464)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton1.TabIndex = 103
        Me.SimpleButton1.Text = "Vista Previa"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(987, 464)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton2.TabIndex = 104
        Me.SimpleButton2.Text = "Exportar Excel"
        '
        'PopupMenu1
        '
        Me.PopupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2)})
        Me.PopupMenu1.Manager = Me.BarManager1
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Municipio"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Departamento"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(1352, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 573)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1352, 0)
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
        Me.barDockControlRight.Location = New System.Drawing.Point(1352, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 573)
        '
        'GbMunicipio
        '
        Me.GbMunicipio.Controls.Add(Me.LabelControl2)
        Me.GbMunicipio.Controls.Add(Me.LabelControl1)
        Me.GbMunicipio.Controls.Add(Me.Codigo)
        Me.GbMunicipio.Controls.Add(Me.CboDepartamento)
        Me.GbMunicipio.Controls.Add(Me.TxtIdMunicipio)
        Me.GbMunicipio.Controls.Add(Me.SimpleButton3)
        Me.GbMunicipio.Controls.Add(Me.TxtMunicipio)
        Me.GbMunicipio.Location = New System.Drawing.Point(31, 111)
        Me.GbMunicipio.Name = "GbMunicipio"
        Me.GbMunicipio.Size = New System.Drawing.Size(401, 152)
        Me.GbMunicipio.TabIndex = 111
        Me.GbMunicipio.Text = "Datos Municipio"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Location = New System.Drawing.Point(37, 111)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(86, 19)
        Me.LabelControl2.TabIndex = 123
        Me.LabelControl2.Text = "Departamento"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Location = New System.Drawing.Point(65, 67)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(58, 19)
        Me.LabelControl1.TabIndex = 122
        Me.LabelControl1.Text = "Municipio"
        '
        'Codigo
        '
        Me.Codigo.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Codigo.Location = New System.Drawing.Point(18, 24)
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Size = New System.Drawing.Size(105, 19)
        Me.Codigo.TabIndex = 121
        Me.Codigo.Text = "Código Municipio"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnNuevo.Location = New System.Drawing.Point(31, 453)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(98, 68)
        Me.BtnNuevo.TabIndex = 116
        Me.BtnNuevo.Text = "Nuevo"
        '
        'BtnEditar
        '
        Me.BtnEditar.Image = CType(resources.GetObject("BtnEditar.Image"), System.Drawing.Image)
        Me.BtnEditar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnEditar.Location = New System.Drawing.Point(135, 453)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(98, 68)
        Me.BtnEditar.TabIndex = 117
        Me.BtnEditar.Text = "Editar"
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Image = CType(resources.GetObject("BtnActualizar.Image"), System.Drawing.Image)
        Me.BtnActualizar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnActualizar.Location = New System.Drawing.Point(239, 453)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(98, 68)
        Me.BtnActualizar.TabIndex = 118
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.Visible = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnCancelar.Location = New System.Drawing.Point(343, 453)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(98, 68)
        Me.BtnCancelar.TabIndex = 119
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.Visible = False
        '
        'BtnInsertar
        '
        Me.BtnInsertar.Image = CType(resources.GetObject("BtnInsertar.Image"), System.Drawing.Image)
        Me.BtnInsertar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnInsertar.Location = New System.Drawing.Point(239, 453)
        Me.BtnInsertar.Name = "BtnInsertar"
        Me.BtnInsertar.Size = New System.Drawing.Size(98, 68)
        Me.BtnInsertar.TabIndex = 120
        Me.BtnInsertar.Text = "Guardar"
        Me.BtnInsertar.Visible = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.LabelControl3.Location = New System.Drawing.Point(97, 41)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(136, 43)
        Me.LabelControl3.TabIndex = 124
        Me.LabelControl3.Text = "Municipio"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(816, 464)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton4.TabIndex = 129
        Me.SimpleButton4.Text = "Exportar PDF"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Image = CType(resources.GetObject("SimpleButton5.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(645, 464)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton5.TabIndex = 130
        Me.SimpleButton5.Text = "Actualizar Datos"
        '
        'PrintingSystem1
        '
        Me.PrintingSystem1.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.GCPrincipal
        Me.PrintableComponentLink1.Landscape = True
        Me.PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(30, 30, 30, 30)
        Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
        Me.PrintableComponentLink1.RtfReportHeader = resources.GetString("PrintableComponentLink1.RtfReportHeader")
        '
        'FrmMunicipio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1352, 573)
        Me.Controls.Add(Me.SimpleButton5)
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.GbMunicipio)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LblFilas)
        Me.Controls.Add(Me.GCPrincipal)
        Me.Controls.Add(Me.BtnInsertar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.HelpButton = True
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TableOfContents)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMunicipio"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "Municipio"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.CboDepartamento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtIdMunicipio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMunicipio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvMunicipio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GbMunicipio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbMunicipio.ResumeLayout(False)
        Me.GbMunicipio.PerformLayout()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LblFilas As Label
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents GCPrincipal As DevExpress.XtraGrid.GridControl
    Friend WithEvents DgvMunicipio As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtIdMunicipio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtMunicipio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CboDepartamento As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents ColIdMunicipio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColMunicipio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDepartamento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GbMunicipio As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BtnInsertar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnActualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnEditar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Codigo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
End Class
