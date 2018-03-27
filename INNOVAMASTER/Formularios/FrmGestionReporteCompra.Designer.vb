<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGestionReporteCompra
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
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit()
        Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup()
        Me.DateEdit3 = New DevExpress.XtraEditors.DateEdit()
        Me.GCPrincipal = New DevExpress.XtraGrid.GridControl()
        Me.DgvProveedor = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColIdProveedor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColRTN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNombreEmpresa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDireccionEmpresa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNombreContacto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColApellidoContacto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDireccionContacto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColTelefonoContacto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCorreoContacto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColMunicipio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSexo = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit3.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(359, 8)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 105
        Me.SimpleButton1.Text = "Buscar"
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(147, 12)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.NullText = "Fecha Inicial"
        Me.DateEdit1.Size = New System.Drawing.Size(100, 20)
        Me.DateEdit1.TabIndex = 106
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Location = New System.Drawing.Point(253, 12)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.NullText = "Fecha Final"
        Me.DateEdit2.Size = New System.Drawing.Size(100, 20)
        Me.DateEdit2.TabIndex = 107
        '
        'RadioGroup1
        '
        Me.RadioGroup1.Location = New System.Drawing.Point(12, 3)
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Rango de Fecha"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Dia"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Proveedor")})
        Me.RadioGroup1.Size = New System.Drawing.Size(129, 82)
        Me.RadioGroup1.TabIndex = 108
        '
        'DateEdit3
        '
        Me.DateEdit3.EditValue = Nothing
        Me.DateEdit3.Location = New System.Drawing.Point(147, 12)
        Me.DateEdit3.Name = "DateEdit3"
        Me.DateEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit3.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit3.Properties.NullText = "Fecha"
        Me.DateEdit3.Size = New System.Drawing.Size(100, 20)
        Me.DateEdit3.TabIndex = 109
        Me.DateEdit3.Visible = False
        '
        'GCPrincipal
        '
        Me.GCPrincipal.Location = New System.Drawing.Point(12, 91)
        Me.GCPrincipal.MainView = Me.DgvProveedor
        Me.GCPrincipal.Name = "GCPrincipal"
        Me.GCPrincipal.Size = New System.Drawing.Size(837, 356)
        Me.GCPrincipal.TabIndex = 110
        Me.GCPrincipal.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DgvProveedor})
        '
        'DgvProveedor
        '
        Me.DgvProveedor.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvProveedor.Appearance.Empty.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvProveedor.Appearance.Empty.Options.UseBackColor = True
        Me.DgvProveedor.Appearance.FocusedCell.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvProveedor.Appearance.FocusedCell.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DgvProveedor.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.DgvProveedor.Appearance.FocusedCell.Options.UseBackColor = True
        Me.DgvProveedor.Appearance.FocusedCell.Options.UseFont = True
        Me.DgvProveedor.Appearance.FocusedCell.Options.UseForeColor = True
        Me.DgvProveedor.Appearance.FocusedRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvProveedor.Appearance.FocusedRow.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DgvProveedor.Appearance.FocusedRow.Options.UseBackColor = True
        Me.DgvProveedor.Appearance.FocusedRow.Options.UseFont = True
        Me.DgvProveedor.Appearance.FooterPanel.Options.UseTextOptions = True
        Me.DgvProveedor.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.DgvProveedor.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvProveedor.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DgvProveedor.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White
        Me.DgvProveedor.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.DgvProveedor.Appearance.HideSelectionRow.Options.UseFont = True
        Me.DgvProveedor.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.DgvProveedor.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DgvProveedor.Appearance.HorzLine.Options.UseBackColor = True
        Me.DgvProveedor.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvProveedor.Appearance.Row.Options.UseBackColor = True
        Me.DgvProveedor.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvProveedor.Appearance.RowSeparator.Options.UseBackColor = True
        Me.DgvProveedor.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DgvProveedor.Appearance.VertLine.Options.UseBackColor = True
        Me.DgvProveedor.ColumnPanelRowHeight = 26
        Me.DgvProveedor.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColIdProveedor, Me.ColRTN, Me.ColNombreEmpresa, Me.ColDireccionEmpresa, Me.ColNombreContacto, Me.ColApellidoContacto, Me.ColDireccionContacto, Me.ColTelefonoContacto, Me.ColCorreoContacto, Me.ColMunicipio, Me.ColSexo})
        Me.DgvProveedor.GridControl = Me.GCPrincipal
        Me.DgvProveedor.Name = "DgvProveedor"
        Me.DgvProveedor.OptionsBehavior.AllowIncrementalSearch = True
        Me.DgvProveedor.OptionsBehavior.AutoSelectAllInEditor = False
        Me.DgvProveedor.OptionsBehavior.Editable = False
        Me.DgvProveedor.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.DgvProveedor.OptionsFind.AlwaysVisible = True
        Me.DgvProveedor.OptionsFind.FindNullPrompt = "Introduzca municipio a buscar..."
        Me.DgvProveedor.OptionsView.ColumnAutoWidth = False
        Me.DgvProveedor.OptionsView.EnableAppearanceEvenRow = True
        Me.DgvProveedor.OptionsView.EnableAppearanceOddRow = True
        Me.DgvProveedor.OptionsView.ShowFooter = True
        Me.DgvProveedor.OptionsView.ShowGroupPanel = False
        Me.DgvProveedor.RowHeight = 22
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
        Me.ColIdProveedor.Caption = "ID"
        Me.ColIdProveedor.FieldName = "IdProveedor"
        Me.ColIdProveedor.Name = "ColIdProveedor"
        Me.ColIdProveedor.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdProveedor", "Total Proveedores = {0}")})
        Me.ColIdProveedor.Visible = True
        Me.ColIdProveedor.VisibleIndex = 0
        Me.ColIdProveedor.Width = 156
        '
        'ColRTN
        '
        Me.ColRTN.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColRTN.AppearanceCell.Options.UseFont = True
        Me.ColRTN.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColRTN.AppearanceHeader.Options.UseFont = True
        Me.ColRTN.AppearanceHeader.Options.UseTextOptions = True
        Me.ColRTN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColRTN.Caption = "RTN"
        Me.ColRTN.FieldName = "RTN"
        Me.ColRTN.Name = "ColRTN"
        Me.ColRTN.Visible = True
        Me.ColRTN.VisibleIndex = 1
        Me.ColRTN.Width = 209
        '
        'ColNombreEmpresa
        '
        Me.ColNombreEmpresa.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColNombreEmpresa.AppearanceCell.Options.UseFont = True
        Me.ColNombreEmpresa.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColNombreEmpresa.AppearanceHeader.Options.UseFont = True
        Me.ColNombreEmpresa.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNombreEmpresa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNombreEmpresa.Caption = "Nombre Empresa"
        Me.ColNombreEmpresa.FieldName = "NombreEmpresa"
        Me.ColNombreEmpresa.Name = "ColNombreEmpresa"
        Me.ColNombreEmpresa.Visible = True
        Me.ColNombreEmpresa.VisibleIndex = 2
        Me.ColNombreEmpresa.Width = 184
        '
        'ColDireccionEmpresa
        '
        Me.ColDireccionEmpresa.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColDireccionEmpresa.AppearanceCell.Options.UseFont = True
        Me.ColDireccionEmpresa.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColDireccionEmpresa.AppearanceHeader.Options.UseFont = True
        Me.ColDireccionEmpresa.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDireccionEmpresa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDireccionEmpresa.Caption = "Direccion Empresa"
        Me.ColDireccionEmpresa.FieldName = "DireccionEmpresa"
        Me.ColDireccionEmpresa.Name = "ColDireccionEmpresa"
        Me.ColDireccionEmpresa.Visible = True
        Me.ColDireccionEmpresa.VisibleIndex = 3
        Me.ColDireccionEmpresa.Width = 156
        '
        'ColNombreContacto
        '
        Me.ColNombreContacto.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColNombreContacto.AppearanceCell.Options.UseFont = True
        Me.ColNombreContacto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColNombreContacto.AppearanceHeader.Options.UseFont = True
        Me.ColNombreContacto.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNombreContacto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNombreContacto.Caption = "Nombre Contacto"
        Me.ColNombreContacto.FieldName = "NombreContacto"
        Me.ColNombreContacto.Name = "ColNombreContacto"
        Me.ColNombreContacto.Visible = True
        Me.ColNombreContacto.VisibleIndex = 4
        Me.ColNombreContacto.Width = 141
        '
        'ColApellidoContacto
        '
        Me.ColApellidoContacto.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColApellidoContacto.AppearanceCell.Options.UseFont = True
        Me.ColApellidoContacto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColApellidoContacto.AppearanceHeader.Options.UseFont = True
        Me.ColApellidoContacto.AppearanceHeader.Options.UseTextOptions = True
        Me.ColApellidoContacto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColApellidoContacto.Caption = "Apellido Contacto"
        Me.ColApellidoContacto.FieldName = "ApellidoContacto"
        Me.ColApellidoContacto.Name = "ColApellidoContacto"
        Me.ColApellidoContacto.Visible = True
        Me.ColApellidoContacto.VisibleIndex = 5
        Me.ColApellidoContacto.Width = 134
        '
        'ColDireccionContacto
        '
        Me.ColDireccionContacto.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColDireccionContacto.AppearanceCell.Options.UseFont = True
        Me.ColDireccionContacto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColDireccionContacto.AppearanceHeader.Options.UseFont = True
        Me.ColDireccionContacto.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDireccionContacto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDireccionContacto.Caption = "Direccion Contacto"
        Me.ColDireccionContacto.FieldName = "DireccionContacto"
        Me.ColDireccionContacto.Name = "ColDireccionContacto"
        Me.ColDireccionContacto.Visible = True
        Me.ColDireccionContacto.VisibleIndex = 6
        Me.ColDireccionContacto.Width = 148
        '
        'ColTelefonoContacto
        '
        Me.ColTelefonoContacto.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColTelefonoContacto.AppearanceCell.Options.UseFont = True
        Me.ColTelefonoContacto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColTelefonoContacto.AppearanceHeader.Options.UseFont = True
        Me.ColTelefonoContacto.AppearanceHeader.Options.UseTextOptions = True
        Me.ColTelefonoContacto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColTelefonoContacto.Caption = "Telefono Contacto"
        Me.ColTelefonoContacto.FieldName = "TelefonoContacto"
        Me.ColTelefonoContacto.Name = "ColTelefonoContacto"
        Me.ColTelefonoContacto.Visible = True
        Me.ColTelefonoContacto.VisibleIndex = 7
        Me.ColTelefonoContacto.Width = 140
        '
        'ColCorreoContacto
        '
        Me.ColCorreoContacto.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColCorreoContacto.AppearanceCell.Options.UseFont = True
        Me.ColCorreoContacto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColCorreoContacto.AppearanceHeader.Options.UseFont = True
        Me.ColCorreoContacto.AppearanceHeader.Options.UseTextOptions = True
        Me.ColCorreoContacto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColCorreoContacto.Caption = "Correo Contacto"
        Me.ColCorreoContacto.FieldName = "correocontacto"
        Me.ColCorreoContacto.Name = "ColCorreoContacto"
        Me.ColCorreoContacto.Visible = True
        Me.ColCorreoContacto.VisibleIndex = 8
        Me.ColCorreoContacto.Width = 128
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
        Me.ColMunicipio.Visible = True
        Me.ColMunicipio.VisibleIndex = 9
        Me.ColMunicipio.Width = 132
        '
        'ColSexo
        '
        Me.ColSexo.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColSexo.AppearanceCell.Options.UseFont = True
        Me.ColSexo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColSexo.AppearanceHeader.Options.UseFont = True
        Me.ColSexo.AppearanceHeader.Options.UseTextOptions = True
        Me.ColSexo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColSexo.Caption = "Sexo"
        Me.ColSexo.FieldName = "Sexo"
        Me.ColSexo.Name = "ColSexo"
        Me.ColSexo.Visible = True
        Me.ColSexo.VisibleIndex = 10
        '
        'FrmGestionReporteCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 459)
        Me.Controls.Add(Me.GCPrincipal)
        Me.Controls.Add(Me.DateEdit3)
        Me.Controls.Add(Me.RadioGroup1)
        Me.Controls.Add(Me.DateEdit2)
        Me.Controls.Add(Me.DateEdit1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Name = "FrmGestionReporteCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Compra"
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit3.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents DateEdit3 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GCPrincipal As DevExpress.XtraGrid.GridControl
    Friend WithEvents DgvProveedor As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColIdProveedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColRTN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColNombreEmpresa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDireccionEmpresa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColNombreContacto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColApellidoContacto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDireccionContacto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColTelefonoContacto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCorreoContacto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColMunicipio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColSexo As DevExpress.XtraGrid.Columns.GridColumn
End Class
