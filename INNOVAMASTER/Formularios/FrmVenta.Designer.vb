<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVenta
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
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GCPrincipal = New DevExpress.XtraGrid.GridControl()
        Me.DgvPrincipal = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GCPrincipal2 = New DevExpress.XtraGrid.GridControl()
        Me.DgvP = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.GCPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCPrincipal2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GCPrincipal)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GCPrincipal2)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1354, 571)
        Me.SplitContainerControl1.SplitterPosition = 718
        Me.SplitContainerControl1.TabIndex = 142
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'GCPrincipal
        '
        Me.GCPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.GCPrincipal.MainView = Me.DgvPrincipal
        Me.GCPrincipal.Name = "GCPrincipal"
        Me.GCPrincipal.Size = New System.Drawing.Size(718, 571)
        Me.GCPrincipal.TabIndex = 141
        Me.GCPrincipal.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DgvPrincipal})
        '
        'DgvPrincipal
        '
        Me.DgvPrincipal.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvPrincipal.Appearance.Empty.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvPrincipal.Appearance.Empty.Options.UseBackColor = True
        Me.DgvPrincipal.Appearance.FocusedCell.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvPrincipal.Appearance.FocusedCell.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvPrincipal.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.DgvPrincipal.Appearance.FocusedCell.Options.UseBackColor = True
        Me.DgvPrincipal.Appearance.FocusedCell.Options.UseFont = True
        Me.DgvPrincipal.Appearance.FocusedCell.Options.UseForeColor = True
        Me.DgvPrincipal.Appearance.FocusedRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvPrincipal.Appearance.FocusedRow.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvPrincipal.Appearance.FocusedRow.Options.UseBackColor = True
        Me.DgvPrincipal.Appearance.FocusedRow.Options.UseFont = True
        Me.DgvPrincipal.Appearance.FooterPanel.Options.UseTextOptions = True
        Me.DgvPrincipal.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.DgvPrincipal.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvPrincipal.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvPrincipal.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White
        Me.DgvPrincipal.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.DgvPrincipal.Appearance.HideSelectionRow.Options.UseFont = True
        Me.DgvPrincipal.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.DgvPrincipal.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DgvPrincipal.Appearance.HorzLine.Options.UseBackColor = True
        Me.DgvPrincipal.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvPrincipal.Appearance.Row.Options.UseBackColor = True
        Me.DgvPrincipal.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvPrincipal.Appearance.RowSeparator.Options.UseBackColor = True
        Me.DgvPrincipal.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DgvPrincipal.Appearance.VertLine.Options.UseBackColor = True
        Me.DgvPrincipal.ColumnPanelRowHeight = 26
        Me.DgvPrincipal.GridControl = Me.GCPrincipal
        Me.DgvPrincipal.Name = "DgvPrincipal"
        Me.DgvPrincipal.OptionsBehavior.AllowIncrementalSearch = True
        Me.DgvPrincipal.OptionsBehavior.AutoSelectAllInEditor = False
        Me.DgvPrincipal.OptionsBehavior.Editable = False
        Me.DgvPrincipal.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.DgvPrincipal.OptionsFind.AlwaysVisible = True
        Me.DgvPrincipal.OptionsFind.FindNullPrompt = "Introduzca cliente a buscar..."
        Me.DgvPrincipal.OptionsView.ColumnAutoWidth = False
        Me.DgvPrincipal.OptionsView.EnableAppearanceEvenRow = True
        Me.DgvPrincipal.OptionsView.EnableAppearanceOddRow = True
        Me.DgvPrincipal.OptionsView.ShowGroupPanel = False
        Me.DgvPrincipal.RowHeight = 22
        '
        'GCPrincipal2
        '
        Me.GCPrincipal2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCPrincipal2.Location = New System.Drawing.Point(0, 0)
        Me.GCPrincipal2.MainView = Me.DgvP
        Me.GCPrincipal2.Name = "GCPrincipal2"
        Me.GCPrincipal2.Size = New System.Drawing.Size(630, 571)
        Me.GCPrincipal2.TabIndex = 107
        Me.GCPrincipal2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DgvP})
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
        Me.DgvP.GridControl = Me.GCPrincipal2
        Me.DgvP.Name = "DgvP"
        Me.DgvP.OptionsBehavior.AllowIncrementalSearch = True
        Me.DgvP.OptionsBehavior.AutoSelectAllInEditor = False
        Me.DgvP.OptionsBehavior.Editable = False
        Me.DgvP.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.DgvP.OptionsFind.AlwaysVisible = True
        Me.DgvP.OptionsFind.FindNullPrompt = "Introduzca venta a buscar..."
        Me.DgvP.OptionsView.ColumnAutoWidth = False
        Me.DgvP.OptionsView.EnableAppearanceEvenRow = True
        Me.DgvP.OptionsView.EnableAppearanceOddRow = True
        Me.DgvP.OptionsView.ShowGroupPanel = False
        Me.DgvP.RowHeight = 22
        '
        'FrmVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 571)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TableOfContents)
        Me.Name = "FrmVenta"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado Ventas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.GCPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCPrincipal2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents GCPrincipal As DevExpress.XtraGrid.GridControl
    Friend WithEvents DgvPrincipal As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GCPrincipal2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents DgvP As DevExpress.XtraGrid.Views.Grid.GridView
End Class
