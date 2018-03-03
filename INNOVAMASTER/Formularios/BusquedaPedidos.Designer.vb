<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BusquedaPedidos
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.GCPrincipal = New DevExpress.XtraGrid.GridControl()
        Me.DgvProductos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColIdProveedor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColIdProductoProveedor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColIdProducto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCosto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColISV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColImagen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PbProducto = New System.Windows.Forms.PictureBox()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        CType(Me.GCPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GCPrincipal
        '
        Me.GCPrincipal.Location = New System.Drawing.Point(-1, 0)
        Me.GCPrincipal.MainView = Me.DgvProductos
        Me.GCPrincipal.Name = "GCPrincipal"
        Me.GCPrincipal.Size = New System.Drawing.Size(821, 436)
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
        Me.DgvProductos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColIdProveedor, Me.ColIdProductoProveedor, Me.ColIdProducto, Me.ColDescripcion, Me.ColCosto, Me.ColISV, Me.ColImagen})
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
        Me.DgvProductos.OptionsView.ShowFooter = True
        Me.DgvProductos.OptionsView.ShowGroupPanel = False
        Me.DgvProductos.RowHeight = 22
        '
        'ColIdProveedor
        '
        Me.ColIdProveedor.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColIdProveedor.AppearanceCell.Options.UseFont = True
        Me.ColIdProveedor.AppearanceCell.Options.UseTextOptions = True
        Me.ColIdProveedor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColIdProveedor.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColIdProveedor.AppearanceHeader.Options.UseFont = True
        Me.ColIdProveedor.AppearanceHeader.Options.UseTextOptions = True
        Me.ColIdProveedor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColIdProveedor.Caption = "Código Proveedor"
        Me.ColIdProveedor.FieldName = "IdProveedor"
        Me.ColIdProveedor.Name = "ColIdProveedor"
        Me.ColIdProveedor.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdProducto", "Total Productos = {0}")})
        Me.ColIdProveedor.Visible = True
        Me.ColIdProveedor.VisibleIndex = 0
        Me.ColIdProveedor.Width = 100
        '
        'ColIdProductoProveedor
        '
        Me.ColIdProductoProveedor.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColIdProductoProveedor.AppearanceCell.Options.UseFont = True
        Me.ColIdProductoProveedor.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColIdProductoProveedor.AppearanceHeader.Options.UseFont = True
        Me.ColIdProductoProveedor.AppearanceHeader.Options.UseTextOptions = True
        Me.ColIdProductoProveedor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColIdProductoProveedor.Caption = "Código Producto Proveedor"
        Me.ColIdProductoProveedor.FieldName = "IdProductoProveedor"
        Me.ColIdProductoProveedor.Name = "ColIdProductoProveedor"
        Me.ColIdProductoProveedor.Visible = True
        Me.ColIdProductoProveedor.VisibleIndex = 5
        Me.ColIdProductoProveedor.Width = 100
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
        Me.ColIdProducto.Caption = "Código Producto"
        Me.ColIdProducto.FieldName = "IdProducto"
        Me.ColIdProducto.Name = "ColIdProducto"
        Me.ColIdProducto.Visible = True
        Me.ColIdProducto.VisibleIndex = 1
        Me.ColIdProducto.Width = 100
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
        Me.ColDescripcion.VisibleIndex = 2
        Me.ColDescripcion.Width = 300
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
        Me.ColCosto.VisibleIndex = 3
        Me.ColCosto.Width = 100
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
        Me.ColISV.VisibleIndex = 4
        Me.ColISV.Width = 100
        '
        'ColImagen
        '
        Me.ColImagen.Caption = "IMAGEN"
        Me.ColImagen.FieldName = "Imagen"
        Me.ColImagen.Name = "ColImagen"
        Me.ColImagen.Width = 20
        '
        'PbProducto
        '
        Me.PbProducto.Location = New System.Drawing.Point(13, 124)
        Me.PbProducto.Name = "PbProducto"
        Me.PbProducto.Size = New System.Drawing.Size(179, 176)
        Me.PbProducto.TabIndex = 106
        Me.PbProducto.TabStop = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.Silver
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Controls.Add(Me.PbProducto)
        Me.PanelControl1.Location = New System.Drawing.Point(812, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(198, 436)
        Me.PanelControl1.TabIndex = 107
        '
        'BusquedaPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 435)
        Me.Controls.Add(Me.GCPrincipal)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "BusquedaPedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BusquedaPedidos"
        CType(Me.GCPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents GCPrincipal As DevExpress.XtraGrid.GridControl
    Friend WithEvents DgvProductos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColIdProveedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCosto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColISV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColIdProductoProveedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColIdProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PbProducto As PictureBox
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents ColImagen As DevExpress.XtraGrid.Columns.GridColumn
End Class
