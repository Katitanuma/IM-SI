<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCategoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCategoria))
        Me.LblFilas = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.GCPrincipal = New DevExpress.XtraGrid.GridControl()
        Me.DgvCategoria = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColIdCategoria = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCategoria = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnEditar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnInsertar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnActualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.GbDatos = New DevExpress.XtraEditors.GroupControl()
        Me.TxtCategoria = New DevExpress.XtraEditors.TextEdit()
        Me.TxtIdCategoria = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GbDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbDatos.SuspendLayout()
        CType(Me.TxtCategoria.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtIdCategoria.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblFilas
        '
        Me.LblFilas.AutoSize = True
        Me.LblFilas.Location = New System.Drawing.Point(998, 336)
        Me.LblFilas.Name = "LblFilas"
        Me.LblFilas.Size = New System.Drawing.Size(61, 13)
        Me.LblFilas.TabIndex = 52
        Me.LblFilas.Text = "SIN DATOS"
        Me.LblFilas.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.INNOVAMASTER.My.Resources.Resources.WhatsApp_Image_2017_03_10_at8_3
        Me.PictureBox2.Location = New System.Drawing.Point(37, 25)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(59, 59)
        Me.PictureBox2.TabIndex = 110
        Me.PictureBox2.TabStop = False
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(992, 472)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton2.TabIndex = 135
        Me.SimpleButton2.Text = "Exportar Excel"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(1163, 472)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton1.TabIndex = 134
        Me.SimpleButton1.Text = "Vista Previa"
        '
        'GCPrincipal
        '
        Me.GCPrincipal.Location = New System.Drawing.Point(522, 29)
        Me.GCPrincipal.MainView = Me.DgvCategoria
        Me.GCPrincipal.Name = "GCPrincipal"
        Me.GCPrincipal.Size = New System.Drawing.Size(806, 433)
        Me.GCPrincipal.TabIndex = 133
        Me.GCPrincipal.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DgvCategoria})
        '
        'DgvCategoria
        '
        Me.DgvCategoria.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvCategoria.Appearance.Empty.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvCategoria.Appearance.Empty.Options.UseBackColor = True
        Me.DgvCategoria.Appearance.FocusedCell.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvCategoria.Appearance.FocusedCell.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvCategoria.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.DgvCategoria.Appearance.FocusedCell.Options.UseBackColor = True
        Me.DgvCategoria.Appearance.FocusedCell.Options.UseFont = True
        Me.DgvCategoria.Appearance.FocusedCell.Options.UseForeColor = True
        Me.DgvCategoria.Appearance.FocusedRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvCategoria.Appearance.FocusedRow.Options.UseBackColor = True
        Me.DgvCategoria.Appearance.FooterPanel.Options.UseTextOptions = True
        Me.DgvCategoria.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.DgvCategoria.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvCategoria.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvCategoria.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White
        Me.DgvCategoria.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.DgvCategoria.Appearance.HideSelectionRow.Options.UseFont = True
        Me.DgvCategoria.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.DgvCategoria.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DgvCategoria.Appearance.HorzLine.Options.UseBackColor = True
        Me.DgvCategoria.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvCategoria.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvCategoria.Appearance.Row.Options.UseBackColor = True
        Me.DgvCategoria.Appearance.Row.Options.UseFont = True
        Me.DgvCategoria.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DgvCategoria.Appearance.VertLine.Options.UseBackColor = True
        Me.DgvCategoria.ColumnPanelRowHeight = 26
        Me.DgvCategoria.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColIdCategoria, Me.ColCategoria})
        Me.DgvCategoria.GridControl = Me.GCPrincipal
        Me.DgvCategoria.Name = "DgvCategoria"
        Me.DgvCategoria.OptionsBehavior.AllowIncrementalSearch = True
        Me.DgvCategoria.OptionsBehavior.Editable = False
        Me.DgvCategoria.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.DgvCategoria.OptionsFind.AlwaysVisible = True
        Me.DgvCategoria.OptionsFind.FindNullPrompt = "Introduzca modelo a buscar..."
        Me.DgvCategoria.OptionsView.EnableAppearanceEvenRow = True
        Me.DgvCategoria.OptionsView.EnableAppearanceOddRow = True
        Me.DgvCategoria.OptionsView.ShowFooter = True
        Me.DgvCategoria.OptionsView.ShowGroupPanel = False
        Me.DgvCategoria.RowHeight = 22
        '
        'ColIdCategoria
        '
        Me.ColIdCategoria.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColIdCategoria.AppearanceCell.Options.UseFont = True
        Me.ColIdCategoria.AppearanceCell.Options.UseTextOptions = True
        Me.ColIdCategoria.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColIdCategoria.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColIdCategoria.AppearanceHeader.Options.UseFont = True
        Me.ColIdCategoria.AppearanceHeader.Options.UseTextOptions = True
        Me.ColIdCategoria.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColIdCategoria.Caption = "ID"
        Me.ColIdCategoria.FieldName = "IdCategoria"
        Me.ColIdCategoria.Name = "ColIdCategoria"
        Me.ColIdCategoria.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdModelo", "Total Categoria = {0}")})
        Me.ColIdCategoria.Visible = True
        Me.ColIdCategoria.VisibleIndex = 0
        Me.ColIdCategoria.Width = 92
        '
        'ColCategoria
        '
        Me.ColCategoria.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColCategoria.AppearanceCell.Options.UseFont = True
        Me.ColCategoria.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColCategoria.AppearanceHeader.Options.UseFont = True
        Me.ColCategoria.AppearanceHeader.Options.UseTextOptions = True
        Me.ColCategoria.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColCategoria.Caption = "Categoría"
        Me.ColCategoria.FieldName = "Categoria"
        Me.ColCategoria.Name = "ColCategoria"
        Me.ColCategoria.Visible = True
        Me.ColCategoria.VisibleIndex = 1
        Me.ColCategoria.Width = 305
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnCancelar.Location = New System.Drawing.Point(358, 449)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(98, 68)
        Me.BtnCancelar.TabIndex = 139
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.Visible = False
        '
        'BtnEditar
        '
        Me.BtnEditar.Image = CType(resources.GetObject("BtnEditar.Image"), System.Drawing.Image)
        Me.BtnEditar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnEditar.Location = New System.Drawing.Point(150, 449)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(98, 68)
        Me.BtnEditar.TabIndex = 137
        Me.BtnEditar.Text = "Editar"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnNuevo.Location = New System.Drawing.Point(46, 449)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(98, 68)
        Me.BtnNuevo.TabIndex = 136
        Me.BtnNuevo.Text = "Nuevo"
        '
        'BtnInsertar
        '
        Me.BtnInsertar.Image = CType(resources.GetObject("BtnInsertar.Image"), System.Drawing.Image)
        Me.BtnInsertar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnInsertar.Location = New System.Drawing.Point(254, 449)
        Me.BtnInsertar.Name = "BtnInsertar"
        Me.BtnInsertar.Size = New System.Drawing.Size(98, 68)
        Me.BtnInsertar.TabIndex = 140
        Me.BtnInsertar.Text = "Guardar"
        Me.BtnInsertar.Visible = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Image = CType(resources.GetObject("BtnActualizar.Image"), System.Drawing.Image)
        Me.BtnActualizar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnActualizar.Location = New System.Drawing.Point(254, 449)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(98, 68)
        Me.BtnActualizar.TabIndex = 138
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.Visible = False
        '
        'GbDatos
        '
        Me.GbDatos.Controls.Add(Me.TxtCategoria)
        Me.GbDatos.Controls.Add(Me.TxtIdCategoria)
        Me.GbDatos.Controls.Add(Me.LabelControl2)
        Me.GbDatos.Controls.Add(Me.LabelControl1)
        Me.GbDatos.Location = New System.Drawing.Point(37, 111)
        Me.GbDatos.Name = "GbDatos"
        Me.GbDatos.Size = New System.Drawing.Size(405, 144)
        Me.GbDatos.TabIndex = 141
        Me.GbDatos.Text = "Datos Categoría"
        '
        'TxtCategoria
        '
        Me.TxtCategoria.Location = New System.Drawing.Point(144, 78)
        Me.TxtCategoria.Name = "TxtCategoria"
        Me.TxtCategoria.Size = New System.Drawing.Size(241, 20)
        Me.TxtCategoria.TabIndex = 3
        '
        'TxtIdCategoria
        '
        Me.TxtIdCategoria.Location = New System.Drawing.Point(144, 36)
        Me.TxtIdCategoria.Name = "TxtIdCategoria"
        Me.TxtIdCategoria.Size = New System.Drawing.Size(241, 20)
        Me.TxtIdCategoria.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Location = New System.Drawing.Point(76, 81)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(59, 19)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Categoría"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Location = New System.Drawing.Point(11, 35)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(127, 19)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Código de Categoría"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Image = CType(resources.GetObject("SimpleButton5.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(650, 472)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton5.TabIndex = 143
        Me.SimpleButton5.Text = "Actualizar Datos"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(821, 472)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton4.TabIndex = 142
        Me.SimpleButton4.Text = "Exportar PDF"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.LabelControl3.Location = New System.Drawing.Point(99, 34)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(302, 43)
        Me.LabelControl3.TabIndex = 150
        Me.LabelControl3.Text = "Categoría del Producto"
        '
        'FrmCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 573)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.SimpleButton5)
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.GbDatos)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnInsertar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GCPrincipal)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LblFilas)
        Me.HelpButton = True
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TableOfContents)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCategoria"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "Categoría"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GbDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbDatos.ResumeLayout(False)
        Me.GbDatos.PerformLayout()
        CType(Me.TxtCategoria.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtIdCategoria.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblFilas As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GCPrincipal As DevExpress.XtraGrid.GridControl
    Friend WithEvents DgvCategoria As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColIdCategoria As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCategoria As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnEditar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnInsertar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnActualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GbDatos As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TxtCategoria As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtIdCategoria As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
End Class
