<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmModelo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModelo))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtModelo = New DevExpress.XtraEditors.TextEdit()
        Me.TxtIdModelo = New DevExpress.XtraEditors.TextEdit()
        Me.CboMarca = New DevExpress.XtraEditors.LookUpEdit()
        Me.LblFilas = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.GCPrincipal = New DevExpress.XtraGrid.GridControl()
        Me.DgvModelo = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColIdModelo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColModelo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColMarca = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnEditar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnInsertar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnActualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GbModelo = New DevExpress.XtraEditors.GroupControl()
        Me.BtnBusquedaCliente = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.TxtModelo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtIdModelo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboMarca.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvModelo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GbModelo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbModelo.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl4.Location = New System.Drawing.Point(80, 117)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(38, 19)
        Me.LabelControl4.TabIndex = 129
        Me.LabelControl4.Text = "Marca"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Location = New System.Drawing.Point(68, 72)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(50, 19)
        Me.LabelControl3.TabIndex = 128
        Me.LabelControl3.Text = " Modelo"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Location = New System.Drawing.Point(27, 35)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(91, 19)
        Me.LabelControl2.TabIndex = 127
        Me.LabelControl2.Text = "Código Modelo"
        '
        'TxtModelo
        '
        Me.TxtModelo.Location = New System.Drawing.Point(124, 73)
        Me.TxtModelo.Name = "TxtModelo"
        Me.TxtModelo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtModelo.Size = New System.Drawing.Size(241, 20)
        Me.TxtModelo.TabIndex = 127
        '
        'TxtIdModelo
        '
        Me.TxtIdModelo.Location = New System.Drawing.Point(124, 36)
        Me.TxtIdModelo.Name = "TxtIdModelo"
        Me.TxtIdModelo.Size = New System.Drawing.Size(241, 20)
        Me.TxtIdModelo.TabIndex = 126
        '
        'CboMarca
        '
        Me.CboMarca.Location = New System.Drawing.Point(124, 118)
        Me.CboMarca.Name = "CboMarca"
        Me.CboMarca.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CboMarca.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CboMarca.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdMarca", 10, "ID"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Marca", 30, "Marca")})
        Me.CboMarca.Properties.DisplayMember = "Marca"
        Me.CboMarca.Properties.NullText = "SELECCIONE MARCA"
        Me.CboMarca.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.CboMarca.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.CboMarca.Properties.ValueMember = "IdMarca"
        Me.CboMarca.Size = New System.Drawing.Size(199, 20)
        Me.CboMarca.TabIndex = 100
        '
        'LblFilas
        '
        Me.LblFilas.AutoSize = True
        Me.LblFilas.Location = New System.Drawing.Point(993, 332)
        Me.LblFilas.Name = "LblFilas"
        Me.LblFilas.Size = New System.Drawing.Size(61, 13)
        Me.LblFilas.TabIndex = 61
        Me.LblFilas.Text = "SIN DATOS"
        Me.LblFilas.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.INNOVAMASTER.My.Resources.Resources.product_icon
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(34, 23)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(59, 59)
        Me.PictureBox2.TabIndex = 64
        Me.PictureBox2.TabStop = False
        '
        'GCPrincipal
        '
        Me.GCPrincipal.Location = New System.Drawing.Point(492, 23)
        Me.GCPrincipal.MainView = Me.DgvModelo
        Me.GCPrincipal.Name = "GCPrincipal"
        Me.GCPrincipal.Size = New System.Drawing.Size(806, 433)
        Me.GCPrincipal.TabIndex = 99
        Me.GCPrincipal.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DgvModelo})
        '
        'DgvModelo
        '
        Me.DgvModelo.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvModelo.Appearance.Empty.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvModelo.Appearance.Empty.Options.UseBackColor = True
        Me.DgvModelo.Appearance.FocusedCell.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvModelo.Appearance.FocusedCell.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvModelo.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.DgvModelo.Appearance.FocusedCell.Options.UseBackColor = True
        Me.DgvModelo.Appearance.FocusedCell.Options.UseFont = True
        Me.DgvModelo.Appearance.FocusedCell.Options.UseForeColor = True
        Me.DgvModelo.Appearance.FocusedRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvModelo.Appearance.FocusedRow.Options.UseBackColor = True
        Me.DgvModelo.Appearance.FooterPanel.Options.UseTextOptions = True
        Me.DgvModelo.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.DgvModelo.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvModelo.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvModelo.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White
        Me.DgvModelo.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.DgvModelo.Appearance.HideSelectionRow.Options.UseFont = True
        Me.DgvModelo.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.DgvModelo.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DgvModelo.Appearance.HorzLine.Options.UseBackColor = True
        Me.DgvModelo.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvModelo.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvModelo.Appearance.Row.Options.UseBackColor = True
        Me.DgvModelo.Appearance.Row.Options.UseFont = True
        Me.DgvModelo.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DgvModelo.Appearance.VertLine.Options.UseBackColor = True
        Me.DgvModelo.ColumnPanelRowHeight = 26
        Me.DgvModelo.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColIdModelo, Me.ColModelo, Me.ColMarca})
        Me.DgvModelo.GridControl = Me.GCPrincipal
        Me.DgvModelo.Name = "DgvModelo"
        Me.DgvModelo.OptionsBehavior.AllowIncrementalSearch = True
        Me.DgvModelo.OptionsBehavior.Editable = False
        Me.DgvModelo.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.DgvModelo.OptionsFind.AlwaysVisible = True
        Me.DgvModelo.OptionsFind.FindNullPrompt = "Introduzca modelo a buscar..."
        Me.DgvModelo.OptionsView.EnableAppearanceEvenRow = True
        Me.DgvModelo.OptionsView.EnableAppearanceOddRow = True
        Me.DgvModelo.OptionsView.ShowFooter = True
        Me.DgvModelo.OptionsView.ShowGroupPanel = False
        Me.DgvModelo.RowHeight = 22
        '
        'ColIdModelo
        '
        Me.ColIdModelo.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColIdModelo.AppearanceCell.Options.UseFont = True
        Me.ColIdModelo.AppearanceCell.Options.UseTextOptions = True
        Me.ColIdModelo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColIdModelo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColIdModelo.AppearanceHeader.Options.UseFont = True
        Me.ColIdModelo.AppearanceHeader.Options.UseTextOptions = True
        Me.ColIdModelo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColIdModelo.Caption = "ID"
        Me.ColIdModelo.FieldName = "IdModelo"
        Me.ColIdModelo.Name = "ColIdModelo"
        Me.ColIdModelo.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdModelo", "Total Modelo = {0}")})
        Me.ColIdModelo.Visible = True
        Me.ColIdModelo.VisibleIndex = 0
        Me.ColIdModelo.Width = 92
        '
        'ColModelo
        '
        Me.ColModelo.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColModelo.AppearanceCell.Options.UseFont = True
        Me.ColModelo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColModelo.AppearanceHeader.Options.UseFont = True
        Me.ColModelo.AppearanceHeader.Options.UseTextOptions = True
        Me.ColModelo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColModelo.Caption = "Modelo"
        Me.ColModelo.FieldName = "Modelo"
        Me.ColModelo.Name = "ColModelo"
        Me.ColModelo.Visible = True
        Me.ColModelo.VisibleIndex = 1
        Me.ColModelo.Width = 305
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
        Me.ColMarca.VisibleIndex = 2
        Me.ColMarca.Width = 299
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnCancelar.Location = New System.Drawing.Point(345, 473)
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
        Me.BtnEditar.Location = New System.Drawing.Point(137, 473)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(98, 68)
        Me.BtnEditar.TabIndex = 122
        Me.BtnEditar.Text = "Editar"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnNuevo.Location = New System.Drawing.Point(33, 473)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(98, 68)
        Me.BtnNuevo.TabIndex = 121
        Me.BtnNuevo.Text = "Nuevo"
        '
        'BtnInsertar
        '
        Me.BtnInsertar.Image = CType(resources.GetObject("BtnInsertar.Image"), System.Drawing.Image)
        Me.BtnInsertar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnInsertar.Location = New System.Drawing.Point(241, 473)
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
        Me.BtnActualizar.Location = New System.Drawing.Point(241, 473)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(98, 68)
        Me.BtnActualizar.TabIndex = 123
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.LabelControl1.Location = New System.Drawing.Point(99, 35)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(99, 43)
        Me.LabelControl1.TabIndex = 126
        Me.LabelControl1.Text = "Modelo"
        '
        'GbModelo
        '
        Me.GbModelo.Controls.Add(Me.BtnBusquedaCliente)
        Me.GbModelo.Controls.Add(Me.TxtModelo)
        Me.GbModelo.Controls.Add(Me.LabelControl4)
        Me.GbModelo.Controls.Add(Me.CboMarca)
        Me.GbModelo.Controls.Add(Me.LabelControl3)
        Me.GbModelo.Controls.Add(Me.TxtIdModelo)
        Me.GbModelo.Controls.Add(Me.LabelControl2)
        Me.GbModelo.Location = New System.Drawing.Point(33, 88)
        Me.GbModelo.Name = "GbModelo"
        Me.GbModelo.Size = New System.Drawing.Size(396, 179)
        Me.GbModelo.TabIndex = 130
        Me.GbModelo.Text = "Datos Modelo"
        '
        'BtnBusquedaCliente
        '
        Me.BtnBusquedaCliente.Location = New System.Drawing.Point(332, 116)
        Me.BtnBusquedaCliente.Name = "BtnBusquedaCliente"
        Me.BtnBusquedaCliente.Size = New System.Drawing.Size(33, 23)
        Me.BtnBusquedaCliente.TabIndex = 130
        Me.BtnBusquedaCliente.Text = "..."
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(962, 466)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton2.TabIndex = 132
        Me.SimpleButton2.Text = "Exportar Excel"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(1133, 466)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton1.TabIndex = 131
        Me.SimpleButton1.Text = "Vista Previa"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Image = CType(resources.GetObject("SimpleButton5.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(620, 466)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton5.TabIndex = 134
        Me.SimpleButton5.Text = "Actualizar Datos"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(791, 466)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton4.TabIndex = 133
        Me.SimpleButton4.Text = "Exportar PDF"
        '
        'FrmModelo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1352, 573)
        Me.Controls.Add(Me.SimpleButton5)
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GbModelo)
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
        Me.Name = "FrmModelo"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "Modelo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.TxtModelo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtIdModelo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboMarca.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvModelo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GbModelo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbModelo.ResumeLayout(False)
        Me.GbModelo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LblFilas As Label
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents GCPrincipal As DevExpress.XtraGrid.GridControl
    Friend WithEvents DgvModelo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColIdModelo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColModelo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColMarca As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CboMarca As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents BtnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnEditar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnInsertar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnActualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtModelo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtIdModelo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GbModelo As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BtnBusquedaCliente As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
End Class
