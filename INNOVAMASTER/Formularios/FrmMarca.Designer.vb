<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMarca
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMarca))
        Me.LblFilas = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.GCPrincipal = New DevExpress.XtraGrid.GridControl()
        Me.DgvMarca = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColIdMarca = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColMarca = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnEditar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnInsertar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnActualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GbMarca = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtMarca = New DevExpress.XtraEditors.TextEdit()
        Me.TxtIdMarca = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GbMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbMarca.SuspendLayout()
        CType(Me.TxtMarca.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtIdMarca.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblFilas
        '
        Me.LblFilas.AutoSize = True
        Me.LblFilas.Location = New System.Drawing.Point(879, 331)
        Me.LblFilas.Name = "LblFilas"
        Me.LblFilas.Size = New System.Drawing.Size(61, 13)
        Me.LblFilas.TabIndex = 54
        Me.LblFilas.Text = "SIN DATOS"
        Me.LblFilas.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.INNOVAMASTER.My.Resources.Resources.box
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(36, 30)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(59, 49)
        Me.PictureBox2.TabIndex = 57
        Me.PictureBox2.TabStop = False
        '
        'GCPrincipal
        '
        Me.GCPrincipal.Location = New System.Drawing.Point(479, 30)
        Me.GCPrincipal.MainView = Me.DgvMarca
        Me.GCPrincipal.Name = "GCPrincipal"
        Me.GCPrincipal.Size = New System.Drawing.Size(838, 433)
        Me.GCPrincipal.TabIndex = 100
        Me.GCPrincipal.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DgvMarca})
        '
        'DgvMarca
        '
        Me.DgvMarca.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvMarca.Appearance.Empty.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvMarca.Appearance.Empty.Options.UseBackColor = True
        Me.DgvMarca.Appearance.FocusedCell.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvMarca.Appearance.FocusedCell.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvMarca.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.DgvMarca.Appearance.FocusedCell.Options.UseBackColor = True
        Me.DgvMarca.Appearance.FocusedCell.Options.UseFont = True
        Me.DgvMarca.Appearance.FocusedCell.Options.UseForeColor = True
        Me.DgvMarca.Appearance.FocusedRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvMarca.Appearance.FocusedRow.Options.UseBackColor = True
        Me.DgvMarca.Appearance.FooterPanel.Options.UseTextOptions = True
        Me.DgvMarca.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.DgvMarca.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvMarca.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvMarca.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White
        Me.DgvMarca.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.DgvMarca.Appearance.HideSelectionRow.Options.UseFont = True
        Me.DgvMarca.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.DgvMarca.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DgvMarca.Appearance.HorzLine.Options.UseBackColor = True
        Me.DgvMarca.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvMarca.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvMarca.Appearance.Row.Options.UseBackColor = True
        Me.DgvMarca.Appearance.Row.Options.UseFont = True
        Me.DgvMarca.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DgvMarca.Appearance.VertLine.Options.UseBackColor = True
        Me.DgvMarca.ColumnPanelRowHeight = 26
        Me.DgvMarca.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColIdMarca, Me.ColMarca})
        Me.DgvMarca.GridControl = Me.GCPrincipal
        Me.DgvMarca.Name = "DgvMarca"
        Me.DgvMarca.OptionsBehavior.AllowIncrementalSearch = True
        Me.DgvMarca.OptionsBehavior.Editable = False
        Me.DgvMarca.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.DgvMarca.OptionsFind.AlwaysVisible = True
        Me.DgvMarca.OptionsFind.FindNullPrompt = "Introduzca modelo a buscar..."
        Me.DgvMarca.OptionsView.EnableAppearanceEvenRow = True
        Me.DgvMarca.OptionsView.EnableAppearanceOddRow = True
        Me.DgvMarca.OptionsView.ShowFooter = True
        Me.DgvMarca.OptionsView.ShowGroupPanel = False
        Me.DgvMarca.RowHeight = 22
        '
        'ColIdMarca
        '
        Me.ColIdMarca.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColIdMarca.AppearanceCell.Options.UseFont = True
        Me.ColIdMarca.AppearanceCell.Options.UseTextOptions = True
        Me.ColIdMarca.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColIdMarca.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColIdMarca.AppearanceHeader.Options.UseFont = True
        Me.ColIdMarca.AppearanceHeader.Options.UseTextOptions = True
        Me.ColIdMarca.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColIdMarca.Caption = "ID"
        Me.ColIdMarca.FieldName = "IdMarca"
        Me.ColIdMarca.Name = "ColIdMarca"
        Me.ColIdMarca.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdModelo", "Total Marca = {0}")})
        Me.ColIdMarca.Visible = True
        Me.ColIdMarca.VisibleIndex = 0
        Me.ColIdMarca.Width = 220
        '
        'ColMarca
        '
        Me.ColMarca.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColMarca.AppearanceCell.Options.UseFont = True
        Me.ColMarca.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColMarca.AppearanceHeader.Options.UseFont = True
        Me.ColMarca.AppearanceHeader.Options.UseTextOptions = True
        Me.ColMarca.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColMarca.Caption = "Marca"
        Me.ColMarca.FieldName = "Marca"
        Me.ColMarca.Name = "ColMarca"
        Me.ColMarca.Visible = True
        Me.ColMarca.VisibleIndex = 1
        Me.ColMarca.Width = 568
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnCancelar.Location = New System.Drawing.Point(339, 466)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(98, 68)
        Me.BtnCancelar.TabIndex = 129
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.Visible = False
        '
        'BtnEditar
        '
        Me.BtnEditar.Image = CType(resources.GetObject("BtnEditar.Image"), System.Drawing.Image)
        Me.BtnEditar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnEditar.Location = New System.Drawing.Point(131, 466)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(98, 68)
        Me.BtnEditar.TabIndex = 127
        Me.BtnEditar.Text = "Editar"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnNuevo.Location = New System.Drawing.Point(27, 466)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(98, 68)
        Me.BtnNuevo.TabIndex = 126
        Me.BtnNuevo.Text = "Nuevo"
        '
        'BtnInsertar
        '
        Me.BtnInsertar.Image = CType(resources.GetObject("BtnInsertar.Image"), System.Drawing.Image)
        Me.BtnInsertar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnInsertar.Location = New System.Drawing.Point(235, 465)
        Me.BtnInsertar.Name = "BtnInsertar"
        Me.BtnInsertar.Size = New System.Drawing.Size(98, 68)
        Me.BtnInsertar.TabIndex = 130
        Me.BtnInsertar.Text = "Guardar"
        Me.BtnInsertar.Visible = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Image = CType(resources.GetObject("BtnActualizar.Image"), System.Drawing.Image)
        Me.BtnActualizar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnActualizar.Location = New System.Drawing.Point(235, 466)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(98, 68)
        Me.BtnActualizar.TabIndex = 128
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.LabelControl1.Location = New System.Drawing.Point(101, 32)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(88, 43)
        Me.LabelControl1.TabIndex = 131
        Me.LabelControl1.Text = "Marca"
        '
        'GbMarca
        '
        Me.GbMarca.Controls.Add(Me.LabelControl3)
        Me.GbMarca.Controls.Add(Me.LabelControl2)
        Me.GbMarca.Controls.Add(Me.TxtMarca)
        Me.GbMarca.Controls.Add(Me.TxtIdMarca)
        Me.GbMarca.Location = New System.Drawing.Point(34, 90)
        Me.GbMarca.Name = "GbMarca"
        Me.GbMarca.Size = New System.Drawing.Size(403, 168)
        Me.GbMarca.TabIndex = 132
        Me.GbMarca.Text = "Datos Marca"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Location = New System.Drawing.Point(68, 87)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(38, 19)
        Me.LabelControl3.TabIndex = 134
        Me.LabelControl3.Text = "Marca"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Location = New System.Drawing.Point(21, 46)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(85, 19)
        Me.LabelControl2.TabIndex = 133
        Me.LabelControl2.Text = "Código Marca"
        '
        'TxtMarca
        '
        Me.TxtMarca.Location = New System.Drawing.Point(115, 88)
        Me.TxtMarca.Name = "TxtMarca"
        Me.TxtMarca.Size = New System.Drawing.Size(241, 20)
        Me.TxtMarca.TabIndex = 1
        '
        'TxtIdMarca
        '
        Me.TxtIdMarca.Location = New System.Drawing.Point(115, 47)
        Me.TxtIdMarca.Name = "TxtIdMarca"
        Me.TxtIdMarca.Size = New System.Drawing.Size(241, 20)
        Me.TxtIdMarca.TabIndex = 0
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(980, 469)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton2.TabIndex = 134
        Me.SimpleButton2.Text = "Exportar Excel"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(1151, 469)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton1.TabIndex = 133
        Me.SimpleButton1.Text = "Vista Previa"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Image = CType(resources.GetObject("SimpleButton5.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(638, 469)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton5.TabIndex = 136
        Me.SimpleButton5.Text = "Actualizar Datos"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(809, 469)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton4.TabIndex = 135
        Me.SimpleButton4.Text = "Exportar PDF"
        '
        'FrmMarca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 573)
        Me.Controls.Add(Me.SimpleButton5)
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GbMarca)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnInsertar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.GCPrincipal)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LblFilas)
        Me.HelpButton = True
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TableOfContents)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMarca"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "Marca"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvMarca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GbMarca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbMarca.ResumeLayout(False)
        Me.GbMarca.PerformLayout()
        CType(Me.TxtMarca.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtIdMarca.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LblFilas As Label
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents GCPrincipal As DevExpress.XtraGrid.GridControl
    Friend WithEvents DgvMarca As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColIdMarca As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColMarca As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnEditar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnInsertar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnActualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GbMarca As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtMarca As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtIdMarca As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
End Class
