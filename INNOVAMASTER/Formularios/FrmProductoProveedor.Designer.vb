<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmProductoProveedor
    Inherits DevExpress.XtraEditors.XtraForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProductoProveedor))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCodigoProducto = New DevExpress.XtraEditors.TextEdit()
        Me.CboProveedor = New DevExpress.XtraEditors.LookUpEdit()
        Me.Button1 = New DevExpress.XtraEditors.SimpleButton()
        Me.ColIdMunicipio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColMunicipio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDepartamento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCPrincipal = New DevExpress.XtraGrid.GridControl()
        Me.DgvProductoProveedor = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColIdProvPro = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColIdProducto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColIdProv = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.TxtCodigoProducto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvProductoProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(118, 26)
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.INNOVAMASTER.My.Resources.Resources.x_mark_3_xxl
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Código de Producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(274, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Proveedor"
        '
        'TxtCodigoProducto
        '
        Me.TxtCodigoProducto.Location = New System.Drawing.Point(12, 22)
        Me.TxtCodigoProducto.Name = "TxtCodigoProducto"
        Me.TxtCodigoProducto.Size = New System.Drawing.Size(245, 20)
        Me.TxtCodigoProducto.TabIndex = 7
        '
        'CboProveedor
        '
        Me.CboProveedor.Location = New System.Drawing.Point(277, 22)
        Me.CboProveedor.Name = "CboProveedor"
        Me.CboProveedor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CboProveedor.Properties.DisplayMember = "Nombre"
        Me.CboProveedor.Properties.NullText = "Seleccione Proveedor"
        Me.CboProveedor.Properties.ValueMember = "IdProveedor"
        Me.CboProveedor.Size = New System.Drawing.Size(246, 20)
        Me.CboProveedor.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(393, 49)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Agregar"
        '
        'ColIdMunicipio
        '
        Me.ColIdMunicipio.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColIdMunicipio.AppearanceCell.Options.UseFont = True
        Me.ColIdMunicipio.AppearanceCell.Options.UseTextOptions = True
        Me.ColIdMunicipio.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColIdMunicipio.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColIdMunicipio.AppearanceHeader.Options.UseFont = True
        Me.ColIdMunicipio.AppearanceHeader.Options.UseTextOptions = True
        Me.ColIdMunicipio.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColIdMunicipio.Caption = "ID"
        Me.ColIdMunicipio.FieldName = "IdMunicipio"
        Me.ColIdMunicipio.Name = "ColIdMunicipio"
        Me.ColIdMunicipio.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdMunicipio", "Total Municipios = {0}")})
        Me.ColIdMunicipio.Width = 164
        '
        'ColMunicipio
        '
        Me.ColMunicipio.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColMunicipio.AppearanceCell.Options.UseFont = True
        Me.ColMunicipio.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColMunicipio.AppearanceHeader.Options.UseFont = True
        Me.ColMunicipio.AppearanceHeader.Options.UseTextOptions = True
        Me.ColMunicipio.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColMunicipio.Caption = "Municipio"
        Me.ColMunicipio.FieldName = "Municipio"
        Me.ColMunicipio.Name = "ColMunicipio"
        Me.ColMunicipio.Width = 470
        '
        'ColDepartamento
        '
        Me.ColDepartamento.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColDepartamento.AppearanceCell.Options.UseFont = True
        Me.ColDepartamento.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColDepartamento.AppearanceHeader.Options.UseFont = True
        Me.ColDepartamento.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDepartamento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDepartamento.Caption = "Departamento"
        Me.ColDepartamento.FieldName = "Departamento"
        Me.ColDepartamento.Name = "ColDepartamento"
        Me.ColDepartamento.Width = 443
        '
        'GCPrincipal
        '
        Me.GCPrincipal.Location = New System.Drawing.Point(12, 78)
        Me.GCPrincipal.MainView = Me.DgvProductoProveedor
        Me.GCPrincipal.Name = "GCPrincipal"
        Me.GCPrincipal.Size = New System.Drawing.Size(533, 190)
        Me.GCPrincipal.TabIndex = 101
        Me.GCPrincipal.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DgvProductoProveedor})
        '
        'DgvProductoProveedor
        '
        Me.DgvProductoProveedor.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvProductoProveedor.Appearance.Empty.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvProductoProveedor.Appearance.Empty.Options.UseBackColor = True
        Me.DgvProductoProveedor.Appearance.FocusedCell.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvProductoProveedor.Appearance.FocusedCell.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DgvProductoProveedor.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.DgvProductoProveedor.Appearance.FocusedCell.Options.UseBackColor = True
        Me.DgvProductoProveedor.Appearance.FocusedCell.Options.UseFont = True
        Me.DgvProductoProveedor.Appearance.FocusedCell.Options.UseForeColor = True
        Me.DgvProductoProveedor.Appearance.FocusedRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvProductoProveedor.Appearance.FocusedRow.Options.UseBackColor = True
        Me.DgvProductoProveedor.Appearance.FooterPanel.Options.UseTextOptions = True
        Me.DgvProductoProveedor.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.DgvProductoProveedor.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvProductoProveedor.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DgvProductoProveedor.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White
        Me.DgvProductoProveedor.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.DgvProductoProveedor.Appearance.HideSelectionRow.Options.UseFont = True
        Me.DgvProductoProveedor.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.DgvProductoProveedor.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DgvProductoProveedor.Appearance.HorzLine.Options.UseBackColor = True
        Me.DgvProductoProveedor.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvProductoProveedor.Appearance.Row.Options.UseBackColor = True
        Me.DgvProductoProveedor.Appearance.Row.Options.UseFont = True
        Me.DgvProductoProveedor.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DgvProductoProveedor.Appearance.VertLine.Options.UseBackColor = True
        Me.DgvProductoProveedor.ColumnPanelRowHeight = 26
        Me.DgvProductoProveedor.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColIdProvPro, Me.ColIdProducto, Me.ColIdProv, Me.ColNombre})
        Me.DgvProductoProveedor.GridControl = Me.GCPrincipal
        Me.DgvProductoProveedor.Name = "DgvProductoProveedor"
        Me.DgvProductoProveedor.OptionsBehavior.AllowIncrementalSearch = True
        Me.DgvProductoProveedor.OptionsBehavior.Editable = False
        Me.DgvProductoProveedor.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.DgvProductoProveedor.OptionsFind.AlwaysVisible = True
        Me.DgvProductoProveedor.OptionsFind.FindNullPrompt = "Introduzca modelo a buscar..."
        Me.DgvProductoProveedor.OptionsView.EnableAppearanceEvenRow = True
        Me.DgvProductoProveedor.OptionsView.EnableAppearanceOddRow = True
        Me.DgvProductoProveedor.OptionsView.ShowFooter = True
        Me.DgvProductoProveedor.OptionsView.ShowGroupPanel = False
        Me.DgvProductoProveedor.RowHeight = 22
        '
        'ColIdProvPro
        '
        Me.ColIdProvPro.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColIdProvPro.AppearanceCell.Options.UseFont = True
        Me.ColIdProvPro.AppearanceCell.Options.UseTextOptions = True
        Me.ColIdProvPro.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColIdProvPro.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColIdProvPro.AppearanceHeader.Options.UseFont = True
        Me.ColIdProvPro.AppearanceHeader.Options.UseTextOptions = True
        Me.ColIdProvPro.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColIdProvPro.Caption = "ID"
        Me.ColIdProvPro.FieldName = "IdProductoProveedor"
        Me.ColIdProvPro.Name = "ColIdProvPro"
        Me.ColIdProvPro.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdProductoProveedor", "Total de Proveedores = {0}")})
        Me.ColIdProvPro.Visible = True
        Me.ColIdProvPro.VisibleIndex = 0
        Me.ColIdProvPro.Width = 183
        '
        'ColIdProducto
        '
        Me.ColIdProducto.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColIdProducto.AppearanceCell.Options.UseFont = True
        Me.ColIdProducto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColIdProducto.AppearanceHeader.Options.UseFont = True
        Me.ColIdProducto.AppearanceHeader.Options.UseTextOptions = True
        Me.ColIdProducto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColIdProducto.Caption = "Id Producto"
        Me.ColIdProducto.FieldName = "IdProducto"
        Me.ColIdProducto.Name = "ColIdProducto"
        Me.ColIdProducto.Visible = True
        Me.ColIdProducto.VisibleIndex = 1
        Me.ColIdProducto.Width = 307
        '
        'ColIdProv
        '
        Me.ColIdProv.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColIdProv.AppearanceCell.Options.UseFont = True
        Me.ColIdProv.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColIdProv.AppearanceHeader.Options.UseFont = True
        Me.ColIdProv.AppearanceHeader.Options.UseTextOptions = True
        Me.ColIdProv.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColIdProv.Caption = "Id Proveedor"
        Me.ColIdProv.FieldName = "IdProveedor"
        Me.ColIdProv.Name = "ColIdProv"
        '
        'ColNombre
        '
        Me.ColNombre.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColNombre.AppearanceCell.Options.UseFont = True
        Me.ColNombre.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColNombre.AppearanceHeader.Options.UseFont = True
        Me.ColNombre.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNombre.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNombre.Caption = "Proveedor"
        Me.ColNombre.FieldName = "Proveedor"
        Me.ColNombre.Name = "ColNombre"
        Me.ColNombre.Visible = True
        Me.ColNombre.VisibleIndex = 2
        Me.ColNombre.Width = 230
        '
        'FrmProductoProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 291)
        Me.Controls.Add(Me.GCPrincipal)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CboProveedor)
        Me.Controls.Add(Me.TxtCodigoProducto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmProductoProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Código Producto de Proveedores"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.TxtCodigoProducto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvProductoProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TxtCodigoProducto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CboProveedor As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Button1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ColIdMunicipio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColMunicipio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDepartamento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCPrincipal As DevExpress.XtraGrid.GridControl
    Friend WithEvents DgvProductoProveedor As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColIdProvPro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColIdProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColIdProv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColNombre As DevExpress.XtraGrid.Columns.GridColumn
End Class
