﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteClientes
    Inherits FrmReportesBase

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReporteClientes))
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GCPrincipal = New DevExpress.XtraGrid.GridControl()
        Me.DgvPrincipal = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnExportarPDF
        '
        Me.BtnExportarPDF.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnExportarPDF.Location = New System.Drawing.Point(188, 340)
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnActualizar.Location = New System.Drawing.Point(17, 340)
        '
        'BtnExportarExcel
        '
        Me.BtnExportarExcel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnExportarExcel.Location = New System.Drawing.Point(359, 340)
        '
        'BtnReporte
        '
        Me.BtnReporte.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnReporte.Location = New System.Drawing.Point(701, 340)
        '
        'BtnImprimir
        '
        Me.BtnImprimir.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnImprimir.Location = New System.Drawing.Point(530, 340)
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.Location = New System.Drawing.Point(290, 8)
        '
        'LblEtiqueta
        '
        Me.LblEtiqueta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblEtiqueta.Appearance.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.LblEtiqueta.Location = New System.Drawing.Point(346, 12)
        Me.LblEtiqueta.Size = New System.Drawing.Size(256, 43)
        Me.LblEtiqueta.Text = "Reporte de Clientes"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GCPrincipal
        Me.GridView1.Name = "GridView1"
        '
        'GCPrincipal
        '
        Me.GCPrincipal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GCPrincipal.Location = New System.Drawing.Point(17, 61)
        Me.GCPrincipal.MainView = Me.DgvPrincipal
        Me.GCPrincipal.Name = "GCPrincipal"
        Me.GCPrincipal.Size = New System.Drawing.Size(849, 265)
        Me.GCPrincipal.TabIndex = 139
        Me.GCPrincipal.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DgvPrincipal, Me.GridView2, Me.GridView1})
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
        Me.DgvPrincipal.OptionsFind.FindNullPrompt = "Introduzca municipio a buscar..."
        Me.DgvPrincipal.OptionsView.EnableAppearanceEvenRow = True
        Me.DgvPrincipal.OptionsView.EnableAppearanceOddRow = True
        Me.DgvPrincipal.OptionsView.ShowGroupPanel = False
        Me.DgvPrincipal.RowHeight = 22
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GCPrincipal
        Me.GridView2.Name = "GridView2"
        '
        'ReporteClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 396)
        Me.Controls.Add(Me.GCPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TableOfContents)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ReporteClientes"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "Clientes"
        Me.TituloEtiqueta = "Reporte de Clientes"
        Me.Controls.SetChildIndex(Me.BtnImprimir, 0)
        Me.Controls.SetChildIndex(Me.BtnExportarExcel, 0)
        Me.Controls.SetChildIndex(Me.BtnExportarPDF, 0)
        Me.Controls.SetChildIndex(Me.BtnActualizar, 0)
        Me.Controls.SetChildIndex(Me.BtnReporte, 0)
        Me.Controls.SetChildIndex(Me.PictureBox2, 0)
        Me.Controls.SetChildIndex(Me.LblEtiqueta, 0)
        Me.Controls.SetChildIndex(Me.GCPrincipal, 0)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GCPrincipal As DevExpress.XtraGrid.GridControl
    Friend WithEvents DgvPrincipal As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
