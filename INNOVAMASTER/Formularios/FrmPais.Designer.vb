<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPais
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPais))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtPais = New DevExpress.XtraEditors.TextEdit()
        Me.TxtIdPais = New DevExpress.XtraEditors.TextEdit()
        Me.LblFilas = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.GCPrincipal = New DevExpress.XtraGrid.GridControl()
        Me.DgvPais = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColIdPais = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPais = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.BtnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnEditar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnInsertar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnActualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.GboPais = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPais.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtIdPais.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvPais, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GboPais, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GboPais.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.INNOVAMASTER.My.Resources.Resources._03a_photo_NewsBriefs2
        Me.PictureBox2.Location = New System.Drawing.Point(35, 24)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(59, 59)
        Me.PictureBox2.TabIndex = 83
        Me.PictureBox2.TabStop = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Location = New System.Drawing.Point(66, 86)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(24, 19)
        Me.LabelControl3.TabIndex = 106
        Me.LabelControl3.Text = "País"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Location = New System.Drawing.Point(19, 40)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(71, 19)
        Me.LabelControl2.TabIndex = 105
        Me.LabelControl2.Text = "Código País"
        '
        'TxtPais
        '
        Me.TxtPais.Location = New System.Drawing.Point(96, 85)
        Me.TxtPais.Name = "TxtPais"
        Me.TxtPais.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPais.Size = New System.Drawing.Size(255, 20)
        Me.TxtPais.TabIndex = 105
        '
        'TxtIdPais
        '
        Me.TxtIdPais.Location = New System.Drawing.Point(96, 39)
        Me.TxtIdPais.Name = "TxtIdPais"
        Me.TxtIdPais.Size = New System.Drawing.Size(255, 20)
        Me.TxtIdPais.TabIndex = 104
        '
        'LblFilas
        '
        Me.LblFilas.AutoSize = True
        Me.LblFilas.Location = New System.Drawing.Point(995, 330)
        Me.LblFilas.Name = "LblFilas"
        Me.LblFilas.Size = New System.Drawing.Size(61, 13)
        Me.LblFilas.TabIndex = 80
        Me.LblFilas.Text = "SIN DATOS"
        Me.LblFilas.Visible = False
        '
        'GCPrincipal
        '
        Me.GCPrincipal.Location = New System.Drawing.Point(486, 35)
        Me.GCPrincipal.MainView = Me.DgvPais
        Me.GCPrincipal.Name = "GCPrincipal"
        Me.GCPrincipal.Size = New System.Drawing.Size(838, 407)
        Me.GCPrincipal.TabIndex = 103
        Me.GCPrincipal.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DgvPais})
        '
        'DgvPais
        '
        Me.DgvPais.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvPais.Appearance.Empty.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvPais.Appearance.Empty.Options.UseBackColor = True
        Me.DgvPais.Appearance.FocusedCell.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvPais.Appearance.FocusedCell.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DgvPais.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.DgvPais.Appearance.FocusedCell.Options.UseBackColor = True
        Me.DgvPais.Appearance.FocusedCell.Options.UseFont = True
        Me.DgvPais.Appearance.FocusedCell.Options.UseForeColor = True
        Me.DgvPais.Appearance.FocusedRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvPais.Appearance.FocusedRow.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DgvPais.Appearance.FocusedRow.Options.UseBackColor = True
        Me.DgvPais.Appearance.FocusedRow.Options.UseFont = True
        Me.DgvPais.Appearance.FooterPanel.Options.UseTextOptions = True
        Me.DgvPais.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.DgvPais.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvPais.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DgvPais.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White
        Me.DgvPais.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.DgvPais.Appearance.HideSelectionRow.Options.UseFont = True
        Me.DgvPais.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.DgvPais.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DgvPais.Appearance.HorzLine.Options.UseBackColor = True
        Me.DgvPais.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvPais.Appearance.Row.Options.UseBackColor = True
        Me.DgvPais.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvPais.Appearance.RowSeparator.Options.UseBackColor = True
        Me.DgvPais.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DgvPais.Appearance.VertLine.Options.UseBackColor = True
        Me.DgvPais.ColumnPanelRowHeight = 26
        Me.DgvPais.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColIdPais, Me.ColPais})
        Me.DgvPais.GridControl = Me.GCPrincipal
        Me.DgvPais.Name = "DgvPais"
        Me.DgvPais.OptionsBehavior.AllowIncrementalSearch = True
        Me.DgvPais.OptionsBehavior.AutoSelectAllInEditor = False
        Me.DgvPais.OptionsBehavior.Editable = False
        Me.DgvPais.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.DgvPais.OptionsFind.AlwaysVisible = True
        Me.DgvPais.OptionsFind.FindNullPrompt = "Introduzca municipio a buscar..."
        Me.DgvPais.OptionsView.EnableAppearanceEvenRow = True
        Me.DgvPais.OptionsView.EnableAppearanceOddRow = True
        Me.DgvPais.OptionsView.ShowFooter = True
        Me.DgvPais.OptionsView.ShowGroupPanel = False
        Me.DgvPais.RowHeight = 22
        '
        'ColIdPais
        '
        Me.ColIdPais.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColIdPais.AppearanceCell.Options.UseFont = True
        Me.ColIdPais.AppearanceCell.Options.UseTextOptions = True
        Me.ColIdPais.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColIdPais.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColIdPais.AppearanceHeader.Options.UseFont = True
        Me.ColIdPais.AppearanceHeader.Options.UseTextOptions = True
        Me.ColIdPais.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColIdPais.Caption = "ID"
        Me.ColIdPais.FieldName = "IdPais"
        Me.ColIdPais.Name = "ColIdPais"
        Me.ColIdPais.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdMunicipio", "Total Pais = {0}")})
        Me.ColIdPais.Visible = True
        Me.ColIdPais.VisibleIndex = 0
        Me.ColIdPais.Width = 244
        '
        'ColPais
        '
        Me.ColPais.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColPais.AppearanceCell.Options.UseFont = True
        Me.ColPais.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColPais.AppearanceHeader.Options.UseFont = True
        Me.ColPais.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPais.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPais.Caption = "País"
        Me.ColPais.FieldName = "Pais"
        Me.ColPais.Name = "ColPais"
        Me.ColPais.Visible = True
        Me.ColPais.VisibleIndex = 1
        Me.ColPais.Width = 833
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.LabelControl1.Location = New System.Drawing.Point(97, 32)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(59, 43)
        Me.LabelControl1.TabIndex = 104
        Me.LabelControl1.Text = "País"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnCancelar.Location = New System.Drawing.Point(342, 455)
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
        Me.BtnEditar.Location = New System.Drawing.Point(134, 455)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(98, 68)
        Me.BtnEditar.TabIndex = 122
        Me.BtnEditar.Text = "Editar"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnNuevo.Location = New System.Drawing.Point(30, 455)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(98, 68)
        Me.BtnNuevo.TabIndex = 121
        Me.BtnNuevo.Text = "Nuevo"
        '
        'BtnInsertar
        '
        Me.BtnInsertar.Image = CType(resources.GetObject("BtnInsertar.Image"), System.Drawing.Image)
        Me.BtnInsertar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnInsertar.Location = New System.Drawing.Point(238, 455)
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
        Me.BtnActualizar.Location = New System.Drawing.Point(238, 455)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(98, 68)
        Me.BtnActualizar.TabIndex = 123
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.Visible = False
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(988, 450)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton2.TabIndex = 127
        Me.SimpleButton2.Text = "Exportar Excel"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(1159, 450)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton1.TabIndex = 126
        Me.SimpleButton1.Text = "Vista Previa"
        '
        'GboPais
        '
        Me.GboPais.Controls.Add(Me.LabelControl2)
        Me.GboPais.Controls.Add(Me.LabelControl3)
        Me.GboPais.Controls.Add(Me.TxtIdPais)
        Me.GboPais.Controls.Add(Me.TxtPais)
        Me.GboPais.Location = New System.Drawing.Point(35, 110)
        Me.GboPais.Name = "GboPais"
        Me.GboPais.Size = New System.Drawing.Size(379, 132)
        Me.GboPais.TabIndex = 128
        Me.GboPais.Text = "Datos País"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Image = CType(resources.GetObject("SimpleButton5.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(646, 450)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton5.TabIndex = 132
        Me.SimpleButton5.Text = "Actualizar Datos"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(817, 450)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton4.TabIndex = 131
        Me.SimpleButton4.Text = "Exportar PDF"
        '
        'FrmPais
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1352, 573)
        Me.Controls.Add(Me.SimpleButton5)
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.GboPais)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnInsertar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.GCPrincipal)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LblFilas)
        Me.HelpButton = True
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TableOfContents)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPais"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "Pais"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPais.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtIdPais.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvPais, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GboPais, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GboPais.ResumeLayout(False)
        Me.GboPais.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LblFilas As Label
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents GCPrincipal As DevExpress.XtraGrid.GridControl
    Friend WithEvents DgvPais As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColIdPais As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPais As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtPais As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtIdPais As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BtnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnEditar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnInsertar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnActualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GboPais As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
End Class
