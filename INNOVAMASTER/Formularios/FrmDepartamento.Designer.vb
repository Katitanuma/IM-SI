<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDepartamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDepartamento))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.CboPais = New DevExpress.XtraEditors.LookUpEdit()
        Me.LblFilas = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.GCPrincipal = New DevExpress.XtraGrid.GridControl()
        Me.DgvDepartamento = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColIdDepartamento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDepartamento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPais = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnEditar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnInsertar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnActualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.TxtIdDepartamento = New DevExpress.XtraEditors.TextEdit()
        Me.TxtDepartamento = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.GbDepartamento = New DevExpress.XtraEditors.GroupControl()
        Me.BtnBusquedaCliente = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboPais.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvDepartamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtIdDepartamento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDepartamento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GbDepartamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbDepartamento.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.INNOVAMASTER.My.Resources.Resources.Francisco_Morazan
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(31, 30)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(59, 59)
        Me.PictureBox2.TabIndex = 59
        Me.PictureBox2.TabStop = False
        '
        'CboPais
        '
        Me.CboPais.Location = New System.Drawing.Point(151, 111)
        Me.CboPais.Name = "CboPais"
        Me.CboPais.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CboPais.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CboPais.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdPais", 10, "ID"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Pais", 30, "Pais")})
        Me.CboPais.Properties.DisplayMember = "Pais"
        Me.CboPais.Properties.NullText = "Seleccione Pais"
        Me.CboPais.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.CboPais.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.CboPais.Properties.ValueMember = "IdPais"
        Me.CboPais.Size = New System.Drawing.Size(207, 20)
        Me.CboPais.TabIndex = 106
        '
        'LblFilas
        '
        Me.LblFilas.AutoSize = True
        Me.LblFilas.Location = New System.Drawing.Point(990, 333)
        Me.LblFilas.Name = "LblFilas"
        Me.LblFilas.Size = New System.Drawing.Size(61, 13)
        Me.LblFilas.TabIndex = 56
        Me.LblFilas.Text = "SIN DATOS"
        Me.LblFilas.Visible = False
        '
        'GCPrincipal
        '
        Me.GCPrincipal.Location = New System.Drawing.Point(503, 37)
        Me.GCPrincipal.MainView = Me.DgvDepartamento
        Me.GCPrincipal.Name = "GCPrincipal"
        Me.GCPrincipal.Size = New System.Drawing.Size(819, 403)
        Me.GCPrincipal.TabIndex = 105
        Me.GCPrincipal.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DgvDepartamento})
        '
        'DgvDepartamento
        '
        Me.DgvDepartamento.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvDepartamento.Appearance.Empty.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvDepartamento.Appearance.Empty.Options.UseBackColor = True
        Me.DgvDepartamento.Appearance.FocusedCell.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvDepartamento.Appearance.FocusedCell.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvDepartamento.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.DgvDepartamento.Appearance.FocusedCell.Options.UseBackColor = True
        Me.DgvDepartamento.Appearance.FocusedCell.Options.UseFont = True
        Me.DgvDepartamento.Appearance.FocusedCell.Options.UseForeColor = True
        Me.DgvDepartamento.Appearance.FocusedRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvDepartamento.Appearance.FocusedRow.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvDepartamento.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.DgvDepartamento.Appearance.FocusedRow.Options.UseBackColor = True
        Me.DgvDepartamento.Appearance.FocusedRow.Options.UseFont = True
        Me.DgvDepartamento.Appearance.FocusedRow.Options.UseForeColor = True
        Me.DgvDepartamento.Appearance.FooterPanel.Options.UseTextOptions = True
        Me.DgvDepartamento.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.DgvDepartamento.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvDepartamento.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvDepartamento.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White
        Me.DgvDepartamento.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.DgvDepartamento.Appearance.HideSelectionRow.Options.UseFont = True
        Me.DgvDepartamento.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.DgvDepartamento.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DgvDepartamento.Appearance.HorzLine.Options.UseBackColor = True
        Me.DgvDepartamento.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvDepartamento.Appearance.Row.Options.UseBackColor = True
        Me.DgvDepartamento.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DgvDepartamento.Appearance.VertLine.Options.UseBackColor = True
        Me.DgvDepartamento.ColumnPanelRowHeight = 26
        Me.DgvDepartamento.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColIdDepartamento, Me.ColDepartamento, Me.ColPais})
        Me.DgvDepartamento.GridControl = Me.GCPrincipal
        Me.DgvDepartamento.Name = "DgvDepartamento"
        Me.DgvDepartamento.OptionsBehavior.AllowIncrementalSearch = True
        Me.DgvDepartamento.OptionsBehavior.Editable = False
        Me.DgvDepartamento.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.DgvDepartamento.OptionsFind.AlwaysVisible = True
        Me.DgvDepartamento.OptionsFind.FindNullPrompt = "Introduzca Departamento a buscar..."
        Me.DgvDepartamento.OptionsView.EnableAppearanceEvenRow = True
        Me.DgvDepartamento.OptionsView.EnableAppearanceOddRow = True
        Me.DgvDepartamento.OptionsView.ShowFooter = True
        Me.DgvDepartamento.OptionsView.ShowGroupPanel = False
        Me.DgvDepartamento.RowHeight = 22
        '
        'ColIdDepartamento
        '
        Me.ColIdDepartamento.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColIdDepartamento.AppearanceCell.Options.UseFont = True
        Me.ColIdDepartamento.AppearanceCell.Options.UseTextOptions = True
        Me.ColIdDepartamento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColIdDepartamento.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColIdDepartamento.AppearanceHeader.Options.UseFont = True
        Me.ColIdDepartamento.AppearanceHeader.Options.UseTextOptions = True
        Me.ColIdDepartamento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColIdDepartamento.Caption = "ID"
        Me.ColIdDepartamento.FieldName = "IdDepartamento"
        Me.ColIdDepartamento.Name = "ColIdDepartamento"
        Me.ColIdDepartamento.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdDepartamento", "Total Departamento = {0}")})
        Me.ColIdDepartamento.Visible = True
        Me.ColIdDepartamento.VisibleIndex = 0
        Me.ColIdDepartamento.Width = 191
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
        Me.ColDepartamento.VisibleIndex = 1
        Me.ColDepartamento.Width = 556
        '
        'ColPais
        '
        Me.ColPais.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColPais.AppearanceCell.Options.UseFont = True
        Me.ColPais.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColPais.AppearanceHeader.Options.UseFont = True
        Me.ColPais.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPais.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPais.Caption = "Pais"
        Me.ColPais.FieldName = "Pais"
        Me.ColPais.Name = "ColPais"
        Me.ColPais.Visible = True
        Me.ColPais.VisibleIndex = 2
        Me.ColPais.Width = 331
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnCancelar.Location = New System.Drawing.Point(356, 460)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(98, 68)
        Me.BtnCancelar.TabIndex = 124
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.Visible = False
        '
        'BtnEditar
        '
        Me.BtnEditar.Image = CType(resources.GetObject("BtnEditar.Image"), System.Drawing.Image)
        Me.BtnEditar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnEditar.Location = New System.Drawing.Point(148, 460)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(98, 68)
        Me.BtnEditar.TabIndex = 122
        Me.BtnEditar.Text = "Editar"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnNuevo.Location = New System.Drawing.Point(44, 460)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(98, 68)
        Me.BtnNuevo.TabIndex = 121
        Me.BtnNuevo.Text = "Nuevo"
        '
        'BtnInsertar
        '
        Me.BtnInsertar.Image = CType(resources.GetObject("BtnInsertar.Image"), System.Drawing.Image)
        Me.BtnInsertar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnInsertar.Location = New System.Drawing.Point(252, 460)
        Me.BtnInsertar.Name = "BtnInsertar"
        Me.BtnInsertar.Size = New System.Drawing.Size(98, 68)
        Me.BtnInsertar.TabIndex = 125
        Me.BtnInsertar.Text = "Guardar"
        Me.BtnInsertar.Visible = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Image = CType(resources.GetObject("BtnActualizar.Image"), System.Drawing.Image)
        Me.BtnActualizar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnActualizar.Location = New System.Drawing.Point(252, 460)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(98, 68)
        Me.BtnActualizar.TabIndex = 123
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.Visible = False
        '
        'TxtIdDepartamento
        '
        Me.TxtIdDepartamento.Location = New System.Drawing.Point(151, 37)
        Me.TxtIdDepartamento.Name = "TxtIdDepartamento"
        Me.TxtIdDepartamento.Size = New System.Drawing.Size(241, 20)
        Me.TxtIdDepartamento.TabIndex = 126
        '
        'TxtDepartamento
        '
        Me.TxtDepartamento.Location = New System.Drawing.Point(151, 74)
        Me.TxtDepartamento.Name = "TxtDepartamento"
        Me.TxtDepartamento.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDepartamento.Size = New System.Drawing.Size(241, 20)
        Me.TxtDepartamento.TabIndex = 127
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.LabelControl1.Location = New System.Drawing.Point(93, 40)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(191, 43)
        Me.LabelControl1.TabIndex = 126
        Me.LabelControl1.Text = "Departamento"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Location = New System.Drawing.Point(12, 36)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(133, 19)
        Me.LabelControl2.TabIndex = 127
        Me.LabelControl2.Text = "Código Departamento"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Location = New System.Drawing.Point(59, 73)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(86, 19)
        Me.LabelControl3.TabIndex = 128
        Me.LabelControl3.Text = "Departamento"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl4.Location = New System.Drawing.Point(121, 112)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(24, 19)
        Me.LabelControl4.TabIndex = 129
        Me.LabelControl4.Text = "País"
        '
        'GbDepartamento
        '
        Me.GbDepartamento.Controls.Add(Me.BtnBusquedaCliente)
        Me.GbDepartamento.Controls.Add(Me.CboPais)
        Me.GbDepartamento.Controls.Add(Me.LabelControl4)
        Me.GbDepartamento.Controls.Add(Me.TxtIdDepartamento)
        Me.GbDepartamento.Controls.Add(Me.LabelControl3)
        Me.GbDepartamento.Controls.Add(Me.TxtDepartamento)
        Me.GbDepartamento.Controls.Add(Me.LabelControl2)
        Me.GbDepartamento.Location = New System.Drawing.Point(31, 107)
        Me.GbDepartamento.Name = "GbDepartamento"
        Me.GbDepartamento.Size = New System.Drawing.Size(423, 156)
        Me.GbDepartamento.TabIndex = 130
        Me.GbDepartamento.Text = "Datos Departamento"
        '
        'BtnBusquedaCliente
        '
        Me.BtnBusquedaCliente.Location = New System.Drawing.Point(364, 109)
        Me.BtnBusquedaCliente.Name = "BtnBusquedaCliente"
        Me.BtnBusquedaCliente.Size = New System.Drawing.Size(28, 23)
        Me.BtnBusquedaCliente.TabIndex = 131
        Me.BtnBusquedaCliente.Text = "..."
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(986, 447)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton2.TabIndex = 132
        Me.SimpleButton2.Text = "Exportar Excel"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(1157, 447)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton1.TabIndex = 131
        Me.SimpleButton1.Text = "Vista Previa"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Image = CType(resources.GetObject("SimpleButton5.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(644, 447)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton5.TabIndex = 134
        Me.SimpleButton5.Text = "Actualizar Datos"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(815, 447)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton4.TabIndex = 133
        Me.SimpleButton4.Text = "Exportar PDF"
        '
        'FrmDepartamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1352, 573)
        Me.Controls.Add(Me.SimpleButton5)
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GbDepartamento)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnInsertar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LblFilas)
        Me.Controls.Add(Me.GCPrincipal)
        Me.HelpButton = True
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TableOfContents)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmDepartamento"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "Departamento"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboPais.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvDepartamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtIdDepartamento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDepartamento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GbDepartamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbDepartamento.ResumeLayout(False)
        Me.GbDepartamento.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LblFilas As Label
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents GCPrincipal As DevExpress.XtraGrid.GridControl
    Friend WithEvents DgvDepartamento As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColIdDepartamento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDepartamento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPais As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CboPais As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents BtnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnEditar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnInsertar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnActualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtIdDepartamento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtDepartamento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GbDepartamento As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BtnBusquedaCliente As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
End Class
