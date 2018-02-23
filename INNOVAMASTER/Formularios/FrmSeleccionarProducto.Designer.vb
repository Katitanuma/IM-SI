<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSeleccionarProducto
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Me.GCPrincipal = New DevExpress.XtraGrid.GridControl()
        Me.DgvProductos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColIdProducto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCosto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPrecioUnitario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPreciolMayorista = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColISV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColExistencia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCategoria = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColModelo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColEstado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColImagen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GCPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GCPrincipal
        '
        Me.GCPrincipal.Location = New System.Drawing.Point(0, 1)
        Me.GCPrincipal.MainView = Me.DgvProductos
        Me.GCPrincipal.Name = "GCPrincipal"
        Me.GCPrincipal.Size = New System.Drawing.Size(836, 371)
        Me.GCPrincipal.TabIndex = 105
        Me.GCPrincipal.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DgvProductos})
        '
        'DgvProductos
        '
        Me.DgvProductos.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvProductos.Appearance.Empty.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvProductos.Appearance.Empty.Options.UseBackColor = True
        Me.DgvProductos.Appearance.FocusedCell.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvProductos.Appearance.FocusedCell.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DgvProductos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.DgvProductos.Appearance.FocusedCell.Options.UseBackColor = True
        Me.DgvProductos.Appearance.FocusedCell.Options.UseFont = True
        Me.DgvProductos.Appearance.FocusedCell.Options.UseForeColor = True
        Me.DgvProductos.Appearance.FocusedRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvProductos.Appearance.FocusedRow.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DgvProductos.Appearance.FocusedRow.Options.UseBackColor = True
        Me.DgvProductos.Appearance.FocusedRow.Options.UseFont = True
        Me.DgvProductos.Appearance.FooterPanel.Options.UseTextOptions = True
        Me.DgvProductos.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.DgvProductos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvProductos.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DgvProductos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White
        Me.DgvProductos.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.DgvProductos.Appearance.HideSelectionRow.Options.UseFont = True
        Me.DgvProductos.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.DgvProductos.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DgvProductos.Appearance.HorzLine.Options.UseBackColor = True
        Me.DgvProductos.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvProductos.Appearance.Row.Options.UseBackColor = True
        Me.DgvProductos.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvProductos.Appearance.RowSeparator.Options.UseBackColor = True
        Me.DgvProductos.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DgvProductos.Appearance.VertLine.Options.UseBackColor = True
        Me.DgvProductos.ColumnPanelRowHeight = 26
        Me.DgvProductos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColIdProducto, Me.ColDescripcion, Me.ColCosto, Me.ColPrecioUnitario, Me.ColPreciolMayorista, Me.ColISV, Me.ColExistencia, Me.ColCategoria, Me.ColModelo, Me.ColEstado, Me.ColImagen, Me.GridColumn1})
        GridFormatRule1.ApplyToRow = True
        GridFormatRule1.Column = Me.ColExistencia
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.Red
        FormatConditionRuleValue1.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.LessOrEqual
        FormatConditionRuleValue1.Value1 = CType(5, Long)
        GridFormatRule1.Rule = FormatConditionRuleValue1
        Me.DgvProductos.FormatRules.Add(GridFormatRule1)
        Me.DgvProductos.GridControl = Me.GCPrincipal
        Me.DgvProductos.Name = "DgvProductos"
        Me.DgvProductos.OptionsBehavior.AllowIncrementalSearch = True
        Me.DgvProductos.OptionsBehavior.AutoSelectAllInEditor = False
        Me.DgvProductos.OptionsBehavior.Editable = False
        Me.DgvProductos.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.DgvProductos.OptionsFind.AlwaysVisible = True
        Me.DgvProductos.OptionsFind.FindNullPrompt = "Introduzca producto a buscar..."
        Me.DgvProductos.OptionsView.ColumnAutoWidth = False
        Me.DgvProductos.OptionsView.EnableAppearanceEvenRow = True
        Me.DgvProductos.OptionsView.EnableAppearanceOddRow = True
        Me.DgvProductos.OptionsView.ShowGroupPanel = False
        Me.DgvProductos.RowHeight = 22
        '
        'ColIdProducto
        '
        Me.ColIdProducto.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColIdProducto.AppearanceCell.Options.UseFont = True
        Me.ColIdProducto.AppearanceCell.Options.UseTextOptions = True
        Me.ColIdProducto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColIdProducto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColIdProducto.AppearanceHeader.Options.UseFont = True
        Me.ColIdProducto.AppearanceHeader.Options.UseTextOptions = True
        Me.ColIdProducto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColIdProducto.Caption = "Código"
        Me.ColIdProducto.FieldName = "IdProducto"
        Me.ColIdProducto.Name = "ColIdProducto"
        Me.ColIdProducto.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdMunicipio", "Total Productos = {0}")})
        Me.ColIdProducto.Visible = True
        Me.ColIdProducto.VisibleIndex = 0
        Me.ColIdProducto.Width = 141
        '
        'ColDescripcion
        '
        Me.ColDescripcion.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColDescripcion.AppearanceCell.Options.UseFont = True
        Me.ColDescripcion.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColDescripcion.AppearanceHeader.Options.UseFont = True
        Me.ColDescripcion.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDescripcion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDescripcion.Caption = "Descripción"
        Me.ColDescripcion.FieldName = "Descripcion"
        Me.ColDescripcion.Name = "ColDescripcion"
        Me.ColDescripcion.Visible = True
        Me.ColDescripcion.VisibleIndex = 1
        Me.ColDescripcion.Width = 411
        '
        'ColCosto
        '
        Me.ColCosto.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColCosto.AppearanceCell.Options.UseFont = True
        Me.ColCosto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColCosto.AppearanceHeader.Options.UseFont = True
        Me.ColCosto.AppearanceHeader.Options.UseTextOptions = True
        Me.ColCosto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColCosto.Caption = "Costo"
        Me.ColCosto.FieldName = "Costo"
        Me.ColCosto.Name = "ColCosto"
        Me.ColCosto.Visible = True
        Me.ColCosto.VisibleIndex = 2
        Me.ColCosto.Width = 118
        '
        'ColPrecioUnitario
        '
        Me.ColPrecioUnitario.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColPrecioUnitario.AppearanceCell.Options.UseFont = True
        Me.ColPrecioUnitario.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColPrecioUnitario.AppearanceHeader.Options.UseFont = True
        Me.ColPrecioUnitario.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPrecioUnitario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPrecioUnitario.Caption = "Precio Unitario"
        Me.ColPrecioUnitario.FieldName = "PrecioUnitario"
        Me.ColPrecioUnitario.Name = "ColPrecioUnitario"
        Me.ColPrecioUnitario.Visible = True
        Me.ColPrecioUnitario.VisibleIndex = 3
        Me.ColPrecioUnitario.Width = 113
        '
        'ColPreciolMayorista
        '
        Me.ColPreciolMayorista.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColPreciolMayorista.AppearanceCell.Options.UseFont = True
        Me.ColPreciolMayorista.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColPreciolMayorista.AppearanceHeader.Options.UseFont = True
        Me.ColPreciolMayorista.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPreciolMayorista.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPreciolMayorista.Caption = "Precio Mayorista"
        Me.ColPreciolMayorista.FieldName = "PrecioMayorista"
        Me.ColPreciolMayorista.Name = "ColPreciolMayorista"
        Me.ColPreciolMayorista.Visible = True
        Me.ColPreciolMayorista.VisibleIndex = 4
        Me.ColPreciolMayorista.Width = 125
        '
        'ColISV
        '
        Me.ColISV.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColISV.AppearanceCell.Options.UseFont = True
        Me.ColISV.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColISV.AppearanceHeader.Options.UseFont = True
        Me.ColISV.AppearanceHeader.Options.UseTextOptions = True
        Me.ColISV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColISV.Caption = "ISV"
        Me.ColISV.FieldName = "Gravado"
        Me.ColISV.Name = "ColISV"
        Me.ColISV.Visible = True
        Me.ColISV.VisibleIndex = 5
        Me.ColISV.Width = 111
        '
        'ColExistencia
        '
        Me.ColExistencia.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColExistencia.AppearanceCell.Options.UseFont = True
        Me.ColExistencia.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColExistencia.AppearanceHeader.Options.UseFont = True
        Me.ColExistencia.AppearanceHeader.Options.UseTextOptions = True
        Me.ColExistencia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColExistencia.Caption = "Existencia"
        Me.ColExistencia.FieldName = "Existencia"
        Me.ColExistencia.Name = "ColExistencia"
        Me.ColExistencia.Visible = True
        Me.ColExistencia.VisibleIndex = 6
        Me.ColExistencia.Width = 82
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
        Me.ColCategoria.VisibleIndex = 7
        Me.ColCategoria.Width = 115
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
        Me.ColModelo.VisibleIndex = 8
        Me.ColModelo.Width = 184
        '
        'ColEstado
        '
        Me.ColEstado.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColEstado.AppearanceCell.Options.UseFont = True
        Me.ColEstado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColEstado.AppearanceHeader.Options.UseFont = True
        Me.ColEstado.AppearanceHeader.Options.UseTextOptions = True
        Me.ColEstado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColEstado.Caption = "Estado"
        Me.ColEstado.FieldName = "Estado"
        Me.ColEstado.Name = "ColEstado"
        Me.ColEstado.Visible = True
        Me.ColEstado.VisibleIndex = 9
        Me.ColEstado.Width = 80
        '
        'ColImagen
        '
        Me.ColImagen.Caption = "Imagen"
        Me.ColImagen.FieldName = "Imagen"
        Me.ColImagen.Name = "ColImagen"
        '
        'GridColumn1
        '
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 10
        '
        'FrmSeleccionarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 375)
        Me.Controls.Add(Me.GCPrincipal)
        Me.Name = "FrmSeleccionarProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Productos"
        CType(Me.GCPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GCPrincipal As DevExpress.XtraGrid.GridControl
    Friend WithEvents DgvProductos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColIdProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCosto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPrecioUnitario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPreciolMayorista As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColISV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColExistencia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCategoria As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColModelo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColImagen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
