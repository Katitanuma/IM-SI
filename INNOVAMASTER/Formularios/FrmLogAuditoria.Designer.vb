<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogAuditoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogAuditoria))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.GCPrincipal = New DevExpress.XtraGrid.GridControl()
        Me.DgvLogAuditoria = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColIdTrigger = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAccion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColUsuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColHora = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvLogAuditoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.INNOVAMASTER.My.Resources.Resources.chart_icon
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(200, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 51)
        Me.PictureBox2.TabIndex = 77
        Me.PictureBox2.TabStop = False
        '
        'GCPrincipal
        '
        Me.GCPrincipal.Location = New System.Drawing.Point(22, 76)
        Me.GCPrincipal.MainView = Me.DgvLogAuditoria
        Me.GCPrincipal.Name = "GCPrincipal"
        Me.GCPrincipal.Size = New System.Drawing.Size(742, 295)
        Me.GCPrincipal.TabIndex = 150
        Me.GCPrincipal.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DgvLogAuditoria})
        '
        'DgvLogAuditoria
        '
        Me.DgvLogAuditoria.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvLogAuditoria.Appearance.Empty.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvLogAuditoria.Appearance.Empty.Options.UseBackColor = True
        Me.DgvLogAuditoria.Appearance.FocusedCell.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvLogAuditoria.Appearance.FocusedCell.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvLogAuditoria.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.DgvLogAuditoria.Appearance.FocusedCell.Options.UseBackColor = True
        Me.DgvLogAuditoria.Appearance.FocusedCell.Options.UseFont = True
        Me.DgvLogAuditoria.Appearance.FocusedCell.Options.UseForeColor = True
        Me.DgvLogAuditoria.Appearance.FocusedRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvLogAuditoria.Appearance.FocusedRow.Options.UseBackColor = True
        Me.DgvLogAuditoria.Appearance.FooterPanel.Options.UseTextOptions = True
        Me.DgvLogAuditoria.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.DgvLogAuditoria.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvLogAuditoria.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvLogAuditoria.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White
        Me.DgvLogAuditoria.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.DgvLogAuditoria.Appearance.HideSelectionRow.Options.UseFont = True
        Me.DgvLogAuditoria.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.DgvLogAuditoria.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DgvLogAuditoria.Appearance.HorzLine.Options.UseBackColor = True
        Me.DgvLogAuditoria.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvLogAuditoria.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvLogAuditoria.Appearance.Row.Options.UseBackColor = True
        Me.DgvLogAuditoria.Appearance.Row.Options.UseFont = True
        Me.DgvLogAuditoria.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DgvLogAuditoria.Appearance.VertLine.Options.UseBackColor = True
        Me.DgvLogAuditoria.ColumnPanelRowHeight = 26
        Me.DgvLogAuditoria.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColIdTrigger, Me.ColAccion, Me.ColFecha, Me.ColUsuario, Me.ColHora})
        Me.DgvLogAuditoria.GridControl = Me.GCPrincipal
        Me.DgvLogAuditoria.Name = "DgvLogAuditoria"
        Me.DgvLogAuditoria.OptionsBehavior.AllowIncrementalSearch = True
        Me.DgvLogAuditoria.OptionsBehavior.Editable = False
        Me.DgvLogAuditoria.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.DgvLogAuditoria.OptionsFind.AlwaysVisible = True
        Me.DgvLogAuditoria.OptionsFind.FindNullPrompt = "Introduzca modelo a buscar..."
        Me.DgvLogAuditoria.OptionsView.EnableAppearanceEvenRow = True
        Me.DgvLogAuditoria.OptionsView.EnableAppearanceOddRow = True
        Me.DgvLogAuditoria.OptionsView.ShowFooter = True
        Me.DgvLogAuditoria.OptionsView.ShowGroupPanel = False
        Me.DgvLogAuditoria.RowHeight = 22
        '
        'ColIdTrigger
        '
        Me.ColIdTrigger.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColIdTrigger.AppearanceCell.Options.UseFont = True
        Me.ColIdTrigger.AppearanceCell.Options.UseTextOptions = True
        Me.ColIdTrigger.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColIdTrigger.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColIdTrigger.AppearanceHeader.Options.UseFont = True
        Me.ColIdTrigger.AppearanceHeader.Options.UseTextOptions = True
        Me.ColIdTrigger.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColIdTrigger.Caption = "ID"
        Me.ColIdTrigger.FieldName = "IdTrigger"
        Me.ColIdTrigger.Name = "ColIdTrigger"
        Me.ColIdTrigger.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdModelo", "Total Acciones = {0}")})
        Me.ColIdTrigger.Visible = True
        Me.ColIdTrigger.VisibleIndex = 0
        Me.ColIdTrigger.Width = 91
        '
        'ColAccion
        '
        Me.ColAccion.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColAccion.AppearanceCell.Options.UseFont = True
        Me.ColAccion.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColAccion.AppearanceHeader.Options.UseFont = True
        Me.ColAccion.AppearanceHeader.Options.UseTextOptions = True
        Me.ColAccion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColAccion.Caption = "Accion"
        Me.ColAccion.FieldName = "Accion"
        Me.ColAccion.Name = "ColAccion"
        Me.ColAccion.Visible = True
        Me.ColAccion.VisibleIndex = 1
        Me.ColAccion.Width = 279
        '
        'ColFecha
        '
        Me.ColFecha.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColFecha.AppearanceCell.Options.UseFont = True
        Me.ColFecha.AppearanceCell.Options.UseTextOptions = True
        Me.ColFecha.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColFecha.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColFecha.AppearanceHeader.Options.UseFont = True
        Me.ColFecha.AppearanceHeader.Options.UseTextOptions = True
        Me.ColFecha.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColFecha.Caption = "Fecha"
        Me.ColFecha.FieldName = "Fecha"
        Me.ColFecha.Name = "ColFecha"
        Me.ColFecha.Visible = True
        Me.ColFecha.VisibleIndex = 2
        Me.ColFecha.Width = 82
        '
        'ColUsuario
        '
        Me.ColUsuario.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColUsuario.AppearanceCell.Options.UseFont = True
        Me.ColUsuario.AppearanceCell.Options.UseTextOptions = True
        Me.ColUsuario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColUsuario.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColUsuario.AppearanceHeader.Options.UseFont = True
        Me.ColUsuario.AppearanceHeader.Options.UseTextOptions = True
        Me.ColUsuario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColUsuario.Caption = "Usuario"
        Me.ColUsuario.FieldName = "Usuario"
        Me.ColUsuario.Name = "ColUsuario"
        Me.ColUsuario.Visible = True
        Me.ColUsuario.VisibleIndex = 3
        Me.ColUsuario.Width = 82
        '
        'ColHora
        '
        Me.ColHora.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColHora.AppearanceCell.Options.UseFont = True
        Me.ColHora.AppearanceCell.Options.UseTextOptions = True
        Me.ColHora.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColHora.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColHora.AppearanceHeader.Options.UseFont = True
        Me.ColHora.AppearanceHeader.Options.UseTextOptions = True
        Me.ColHora.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColHora.Caption = "Hora"
        Me.ColHora.FieldName = "Hora"
        Me.ColHora.Name = "ColHora"
        Me.ColHora.Visible = True
        Me.ColHora.VisibleIndex = 4
        Me.ColHora.Width = 86
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(397, 377)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton2.TabIndex = 152
        Me.SimpleButton2.Text = "Exportar Excel"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(568, 377)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton1.TabIndex = 151
        Me.SimpleButton1.Text = "Vista Previa"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.LabelControl1.Location = New System.Drawing.Point(256, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(298, 43)
        Me.LabelControl1.TabIndex = 153
        Me.LabelControl1.Text = "Registros de Auditoría"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Image = CType(resources.GetObject("SimpleButton5.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(55, 377)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton5.TabIndex = 155
        Me.SimpleButton5.Text = "Actualizar Datos"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(226, 377)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton4.TabIndex = 154
        Me.SimpleButton4.Text = "Exportar PDF"
        '
        'FrmLogAuditoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 430)
        Me.Controls.Add(Me.SimpleButton5)
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GCPrincipal)
        Me.Controls.Add(Me.PictureBox2)
        Me.HelpButton = True
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TableOfContents)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmLogAuditoria"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auditoría"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvLogAuditoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents GCPrincipal As DevExpress.XtraGrid.GridControl
    Friend WithEvents DgvLogAuditoria As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColIdTrigger As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAccion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColHora As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
End Class
