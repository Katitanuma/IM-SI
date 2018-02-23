<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProfesiones
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProfesiones))
        Me.LblFilas = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.GCPrincipal = New DevExpress.XtraGrid.GridControl()
        Me.DgvProfesion = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColIdProfesion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColProfesion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnEditar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnInsertar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnActualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.GbDatos = New DevExpress.XtraEditors.GroupControl()
        Me.TxtProfesion = New DevExpress.XtraEditors.TextEdit()
        Me.TxtIdProfesion = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvProfesion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GbDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbDatos.SuspendLayout()
        CType(Me.TxtProfesion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtIdProfesion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblFilas
        '
        Me.LblFilas.AutoSize = True
        Me.LblFilas.Location = New System.Drawing.Point(995, 323)
        Me.LblFilas.Name = "LblFilas"
        Me.LblFilas.Size = New System.Drawing.Size(61, 13)
        Me.LblFilas.TabIndex = 80
        Me.LblFilas.Text = "SIN DATOS"
        Me.LblFilas.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.INNOVAMASTER.My.Resources.Resources.egresado
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(38, 18)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(59, 59)
        Me.PictureBox2.TabIndex = 83
        Me.PictureBox2.TabStop = False
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(989, 467)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton2.TabIndex = 152
        Me.SimpleButton2.Text = "Exportar Excel"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(1160, 467)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton1.TabIndex = 151
        Me.SimpleButton1.Text = "Vista Previa"
        '
        'GCPrincipal
        '
        Me.GCPrincipal.Location = New System.Drawing.Point(519, 25)
        Me.GCPrincipal.MainView = Me.DgvProfesion
        Me.GCPrincipal.Name = "GCPrincipal"
        Me.GCPrincipal.Size = New System.Drawing.Size(806, 433)
        Me.GCPrincipal.TabIndex = 150
        Me.GCPrincipal.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DgvProfesion})
        '
        'DgvProfesion
        '
        Me.DgvProfesion.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvProfesion.Appearance.Empty.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvProfesion.Appearance.Empty.Options.UseBackColor = True
        Me.DgvProfesion.Appearance.FocusedCell.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvProfesion.Appearance.FocusedCell.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvProfesion.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.DgvProfesion.Appearance.FocusedCell.Options.UseBackColor = True
        Me.DgvProfesion.Appearance.FocusedCell.Options.UseFont = True
        Me.DgvProfesion.Appearance.FocusedCell.Options.UseForeColor = True
        Me.DgvProfesion.Appearance.FocusedRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvProfesion.Appearance.FocusedRow.Options.UseBackColor = True
        Me.DgvProfesion.Appearance.FooterPanel.Options.UseTextOptions = True
        Me.DgvProfesion.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.DgvProfesion.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvProfesion.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvProfesion.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White
        Me.DgvProfesion.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.DgvProfesion.Appearance.HideSelectionRow.Options.UseFont = True
        Me.DgvProfesion.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.DgvProfesion.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DgvProfesion.Appearance.HorzLine.Options.UseBackColor = True
        Me.DgvProfesion.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvProfesion.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvProfesion.Appearance.Row.Options.UseBackColor = True
        Me.DgvProfesion.Appearance.Row.Options.UseFont = True
        Me.DgvProfesion.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DgvProfesion.Appearance.VertLine.Options.UseBackColor = True
        Me.DgvProfesion.ColumnPanelRowHeight = 26
        Me.DgvProfesion.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColIdProfesion, Me.ColProfesion})
        Me.DgvProfesion.GridControl = Me.GCPrincipal
        Me.DgvProfesion.Name = "DgvProfesion"
        Me.DgvProfesion.OptionsBehavior.AllowIncrementalSearch = True
        Me.DgvProfesion.OptionsBehavior.Editable = False
        Me.DgvProfesion.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.DgvProfesion.OptionsFind.AlwaysVisible = True
        Me.DgvProfesion.OptionsFind.FindNullPrompt = "Introduzca modelo a buscar..."
        Me.DgvProfesion.OptionsView.EnableAppearanceEvenRow = True
        Me.DgvProfesion.OptionsView.EnableAppearanceOddRow = True
        Me.DgvProfesion.OptionsView.ShowFooter = True
        Me.DgvProfesion.OptionsView.ShowGroupPanel = False
        Me.DgvProfesion.RowHeight = 22
        '
        'ColIdProfesion
        '
        Me.ColIdProfesion.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColIdProfesion.AppearanceCell.Options.UseFont = True
        Me.ColIdProfesion.AppearanceCell.Options.UseTextOptions = True
        Me.ColIdProfesion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColIdProfesion.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColIdProfesion.AppearanceHeader.Options.UseFont = True
        Me.ColIdProfesion.AppearanceHeader.Options.UseTextOptions = True
        Me.ColIdProfesion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColIdProfesion.Caption = "ID"
        Me.ColIdProfesion.FieldName = "IdProfesion"
        Me.ColIdProfesion.Name = "ColIdProfesion"
        Me.ColIdProfesion.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdModelo", "Total Profesiones = {0}")})
        Me.ColIdProfesion.Visible = True
        Me.ColIdProfesion.VisibleIndex = 0
        Me.ColIdProfesion.Width = 92
        '
        'ColProfesion
        '
        Me.ColProfesion.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColProfesion.AppearanceCell.Options.UseFont = True
        Me.ColProfesion.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColProfesion.AppearanceHeader.Options.UseFont = True
        Me.ColProfesion.AppearanceHeader.Options.UseTextOptions = True
        Me.ColProfesion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColProfesion.Caption = "Profesion"
        Me.ColProfesion.FieldName = "Profesion"
        Me.ColProfesion.Name = "ColProfesion"
        Me.ColProfesion.Visible = True
        Me.ColProfesion.VisibleIndex = 1
        Me.ColProfesion.Width = 305
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnCancelar.Location = New System.Drawing.Point(350, 467)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(98, 68)
        Me.BtnCancelar.TabIndex = 156
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.Visible = False
        '
        'BtnEditar
        '
        Me.BtnEditar.Image = CType(resources.GetObject("BtnEditar.Image"), System.Drawing.Image)
        Me.BtnEditar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnEditar.Location = New System.Drawing.Point(142, 467)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(98, 68)
        Me.BtnEditar.TabIndex = 154
        Me.BtnEditar.Text = "Editar"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnNuevo.Location = New System.Drawing.Point(38, 467)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(98, 68)
        Me.BtnNuevo.TabIndex = 153
        Me.BtnNuevo.Text = "Nuevo"
        '
        'BtnInsertar
        '
        Me.BtnInsertar.Image = CType(resources.GetObject("BtnInsertar.Image"), System.Drawing.Image)
        Me.BtnInsertar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnInsertar.Location = New System.Drawing.Point(246, 467)
        Me.BtnInsertar.Name = "BtnInsertar"
        Me.BtnInsertar.Size = New System.Drawing.Size(98, 68)
        Me.BtnInsertar.TabIndex = 157
        Me.BtnInsertar.Text = "Guardar"
        Me.BtnInsertar.Visible = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Image = CType(resources.GetObject("BtnActualizar.Image"), System.Drawing.Image)
        Me.BtnActualizar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnActualizar.Location = New System.Drawing.Point(246, 467)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(98, 68)
        Me.BtnActualizar.TabIndex = 155
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.Visible = False
        '
        'GbDatos
        '
        Me.GbDatos.Controls.Add(Me.TxtProfesion)
        Me.GbDatos.Controls.Add(Me.TxtIdProfesion)
        Me.GbDatos.Controls.Add(Me.LabelControl2)
        Me.GbDatos.Controls.Add(Me.LabelControl1)
        Me.GbDatos.Location = New System.Drawing.Point(38, 97)
        Me.GbDatos.Name = "GbDatos"
        Me.GbDatos.Size = New System.Drawing.Size(369, 116)
        Me.GbDatos.TabIndex = 158
        Me.GbDatos.Text = "Datos Profesión"
        '
        'TxtProfesion
        '
        Me.TxtProfesion.Location = New System.Drawing.Point(142, 69)
        Me.TxtProfesion.Name = "TxtProfesion"
        Me.TxtProfesion.Size = New System.Drawing.Size(198, 20)
        Me.TxtProfesion.TabIndex = 3
        '
        'TxtIdProfesion
        '
        Me.TxtIdProfesion.Location = New System.Drawing.Point(142, 33)
        Me.TxtIdProfesion.Name = "TxtIdProfesion"
        Me.TxtIdProfesion.Size = New System.Drawing.Size(198, 20)
        Me.TxtIdProfesion.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Location = New System.Drawing.Point(53, 70)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(58, 19)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Profesión"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Location = New System.Drawing.Point(12, 35)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(105, 19)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Código Profesión"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.LabelControl3.Location = New System.Drawing.Point(92, 25)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(125, 43)
        Me.LabelControl3.TabIndex = 159
        Me.LabelControl3.Text = "Profesión"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Image = CType(resources.GetObject("SimpleButton5.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(647, 467)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton5.TabIndex = 161
        Me.SimpleButton5.Text = "Actualizar Datos"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(818, 467)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton4.TabIndex = 160
        Me.SimpleButton4.Text = "Exportar PDF"
        '
        'FrmProfesiones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 571)
        Me.Controls.Add(Me.SimpleButton5)
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.LabelControl3)
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
        Me.Name = "FrmProfesiones"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "Profesion"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvProfesion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GbDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbDatos.ResumeLayout(False)
        Me.GbDatos.PerformLayout()
        CType(Me.TxtProfesion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtIdProfesion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LblFilas As Label
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GCPrincipal As DevExpress.XtraGrid.GridControl
    Friend WithEvents DgvProfesion As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColIdProfesion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColProfesion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnEditar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnInsertar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnActualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GbDatos As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TxtProfesion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtIdProfesion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
End Class
