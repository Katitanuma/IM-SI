<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCargo))
        Me.LblFilas = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.GCPrincipal = New DevExpress.XtraGrid.GridControl()
        Me.DgvCargo = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColIdCargo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCargo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnEditar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnInsertar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnActualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.GbDatos = New DevExpress.XtraEditors.GroupControl()
        Me.TxtCargo = New DevExpress.XtraEditors.TextEdit()
        Me.TxtIdCargo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvCargo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GbDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbDatos.SuspendLayout()
        CType(Me.TxtCargo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtIdCargo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblFilas
        '
        Me.LblFilas.AutoSize = True
        Me.LblFilas.Location = New System.Drawing.Point(991, 330)
        Me.LblFilas.Name = "LblFilas"
        Me.LblFilas.Size = New System.Drawing.Size(61, 13)
        Me.LblFilas.TabIndex = 59
        Me.LblFilas.Text = "SIN DATOS"
        Me.LblFilas.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.INNOVAMASTER.My.Resources.Resources._3
        Me.PictureBox1.Location = New System.Drawing.Point(32, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(58, 58)
        Me.PictureBox1.TabIndex = 110
        Me.PictureBox1.TabStop = False
        '
        'GCPrincipal
        '
        Me.GCPrincipal.Location = New System.Drawing.Point(530, 31)
        Me.GCPrincipal.MainView = Me.DgvCargo
        Me.GCPrincipal.Name = "GCPrincipal"
        Me.GCPrincipal.Size = New System.Drawing.Size(806, 433)
        Me.GCPrincipal.TabIndex = 134
        Me.GCPrincipal.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DgvCargo})
        '
        'DgvCargo
        '
        Me.DgvCargo.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvCargo.Appearance.Empty.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvCargo.Appearance.Empty.Options.UseBackColor = True
        Me.DgvCargo.Appearance.FocusedCell.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvCargo.Appearance.FocusedCell.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvCargo.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.DgvCargo.Appearance.FocusedCell.Options.UseBackColor = True
        Me.DgvCargo.Appearance.FocusedCell.Options.UseFont = True
        Me.DgvCargo.Appearance.FocusedCell.Options.UseForeColor = True
        Me.DgvCargo.Appearance.FocusedRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvCargo.Appearance.FocusedRow.Options.UseBackColor = True
        Me.DgvCargo.Appearance.FooterPanel.Options.UseTextOptions = True
        Me.DgvCargo.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.DgvCargo.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvCargo.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvCargo.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White
        Me.DgvCargo.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.DgvCargo.Appearance.HideSelectionRow.Options.UseFont = True
        Me.DgvCargo.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.DgvCargo.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DgvCargo.Appearance.HorzLine.Options.UseBackColor = True
        Me.DgvCargo.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvCargo.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvCargo.Appearance.Row.Options.UseBackColor = True
        Me.DgvCargo.Appearance.Row.Options.UseFont = True
        Me.DgvCargo.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DgvCargo.Appearance.VertLine.Options.UseBackColor = True
        Me.DgvCargo.ColumnPanelRowHeight = 26
        Me.DgvCargo.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColIdCargo, Me.ColCargo})
        Me.DgvCargo.GridControl = Me.GCPrincipal
        Me.DgvCargo.Name = "DgvCargo"
        Me.DgvCargo.OptionsBehavior.AllowIncrementalSearch = True
        Me.DgvCargo.OptionsBehavior.Editable = False
        Me.DgvCargo.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.DgvCargo.OptionsFind.AlwaysVisible = True
        Me.DgvCargo.OptionsFind.FindNullPrompt = "Introduzca modelo a buscar..."
        Me.DgvCargo.OptionsView.EnableAppearanceEvenRow = True
        Me.DgvCargo.OptionsView.EnableAppearanceOddRow = True
        Me.DgvCargo.OptionsView.ShowFooter = True
        Me.DgvCargo.OptionsView.ShowGroupPanel = False
        Me.DgvCargo.RowHeight = 22
        '
        'ColIdCargo
        '
        Me.ColIdCargo.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColIdCargo.AppearanceCell.Options.UseFont = True
        Me.ColIdCargo.AppearanceCell.Options.UseTextOptions = True
        Me.ColIdCargo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColIdCargo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColIdCargo.AppearanceHeader.Options.UseFont = True
        Me.ColIdCargo.AppearanceHeader.Options.UseTextOptions = True
        Me.ColIdCargo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColIdCargo.Caption = "ID"
        Me.ColIdCargo.FieldName = "IdCargo"
        Me.ColIdCargo.Name = "ColIdCargo"
        Me.ColIdCargo.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdModelo", "Total Cargos = {0}")})
        Me.ColIdCargo.Visible = True
        Me.ColIdCargo.VisibleIndex = 0
        Me.ColIdCargo.Width = 92
        '
        'ColCargo
        '
        Me.ColCargo.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColCargo.AppearanceCell.Options.UseFont = True
        Me.ColCargo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColCargo.AppearanceHeader.Options.UseFont = True
        Me.ColCargo.AppearanceHeader.Options.UseTextOptions = True
        Me.ColCargo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColCargo.Caption = "Cargo"
        Me.ColCargo.FieldName = "Cargo"
        Me.ColCargo.Name = "ColCargo"
        Me.ColCargo.Visible = True
        Me.ColCargo.VisibleIndex = 1
        Me.ColCargo.Width = 305
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnCancelar.Location = New System.Drawing.Point(351, 473)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(98, 68)
        Me.BtnCancelar.TabIndex = 144
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.Visible = False
        '
        'BtnEditar
        '
        Me.BtnEditar.Image = CType(resources.GetObject("BtnEditar.Image"), System.Drawing.Image)
        Me.BtnEditar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnEditar.Location = New System.Drawing.Point(143, 473)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(98, 68)
        Me.BtnEditar.TabIndex = 142
        Me.BtnEditar.Text = "Editar"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnNuevo.Location = New System.Drawing.Point(39, 473)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(98, 68)
        Me.BtnNuevo.TabIndex = 141
        Me.BtnNuevo.Text = "Nuevo"
        '
        'BtnInsertar
        '
        Me.BtnInsertar.Image = CType(resources.GetObject("BtnInsertar.Image"), System.Drawing.Image)
        Me.BtnInsertar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnInsertar.Location = New System.Drawing.Point(247, 473)
        Me.BtnInsertar.Name = "BtnInsertar"
        Me.BtnInsertar.Size = New System.Drawing.Size(98, 68)
        Me.BtnInsertar.TabIndex = 145
        Me.BtnInsertar.Text = "Guardar"
        Me.BtnInsertar.Visible = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Image = CType(resources.GetObject("BtnActualizar.Image"), System.Drawing.Image)
        Me.BtnActualizar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnActualizar.Location = New System.Drawing.Point(247, 473)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(98, 68)
        Me.BtnActualizar.TabIndex = 143
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.Visible = False
        '
        'GbDatos
        '
        Me.GbDatos.Controls.Add(Me.TxtCargo)
        Me.GbDatos.Controls.Add(Me.TxtIdCargo)
        Me.GbDatos.Controls.Add(Me.LabelControl2)
        Me.GbDatos.Controls.Add(Me.LabelControl1)
        Me.GbDatos.Location = New System.Drawing.Point(32, 99)
        Me.GbDatos.Name = "GbDatos"
        Me.GbDatos.Size = New System.Drawing.Size(413, 144)
        Me.GbDatos.TabIndex = 146
        Me.GbDatos.Text = "Datos Cargo"
        '
        'TxtCargo
        '
        Me.TxtCargo.Location = New System.Drawing.Point(111, 88)
        Me.TxtCargo.Name = "TxtCargo"
        Me.TxtCargo.Size = New System.Drawing.Size(238, 20)
        Me.TxtCargo.TabIndex = 3
        '
        'TxtIdCargo
        '
        Me.TxtIdCargo.EditValue = ""
        Me.TxtIdCargo.Location = New System.Drawing.Point(111, 39)
        Me.TxtIdCargo.Name = "TxtIdCargo"
        Me.TxtIdCargo.Size = New System.Drawing.Size(238, 20)
        Me.TxtIdCargo.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Location = New System.Drawing.Point(53, 87)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(41, 19)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = " Cargo"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Location = New System.Drawing.Point(18, 42)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(82, 19)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Código Cargo"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.LabelControl3.Location = New System.Drawing.Point(90, 30)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(264, 43)
        Me.LabelControl3.TabIndex = 147
        Me.LabelControl3.Text = "Cargo del Empleado"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(1000, 473)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton2.TabIndex = 149
        Me.SimpleButton2.Text = "Exportar Excel"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(1171, 473)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton1.TabIndex = 148
        Me.SimpleButton1.Text = "Vista Previa"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Image = CType(resources.GetObject("SimpleButton5.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(658, 473)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton5.TabIndex = 151
        Me.SimpleButton5.Text = "Actualizar Datos"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(829, 473)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton4.TabIndex = 150
        Me.SimpleButton4.Text = "Exportar PDF"
        '
        'frmCargo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 571)
        Me.Controls.Add(Me.SimpleButton5)
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.GbDatos)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnInsertar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.GCPrincipal)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LblFilas)
        Me.HelpButton = True
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TableOfContents)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCargo"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "Cargo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvCargo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GbDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbDatos.ResumeLayout(False)
        Me.GbDatos.PerformLayout()
        CType(Me.TxtCargo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtIdCargo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblFilas As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents GCPrincipal As DevExpress.XtraGrid.GridControl
    Friend WithEvents DgvCargo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColIdCargo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCargo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnEditar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnInsertar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnActualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GbDatos As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TxtCargo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtIdCargo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
End Class
