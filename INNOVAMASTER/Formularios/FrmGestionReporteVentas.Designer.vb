<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGestionReporteVentas
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
        Me.GCPrincipal = New DevExpress.XtraGrid.GridControl()
        Me.DgvClientes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColIdCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNombreCompleto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDireccion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColTelefono = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCorreo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColFechaNacimiento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSexo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColMunicipio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColEstadoCivil = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit()
        Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup()
        Me.DateEdit3 = New DevExpress.XtraEditors.DateEdit()
        CType(Me.GCPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit3.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GCPrincipal
        '
        Me.GCPrincipal.Location = New System.Drawing.Point(12, 91)
        Me.GCPrincipal.MainView = Me.DgvClientes
        Me.GCPrincipal.Name = "GCPrincipal"
        Me.GCPrincipal.Size = New System.Drawing.Size(836, 356)
        Me.GCPrincipal.TabIndex = 104
        Me.GCPrincipal.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DgvClientes})
        '
        'DgvClientes
        '
        Me.DgvClientes.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvClientes.Appearance.Empty.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvClientes.Appearance.Empty.Options.UseBackColor = True
        Me.DgvClientes.Appearance.FocusedCell.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvClientes.Appearance.FocusedCell.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DgvClientes.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.DgvClientes.Appearance.FocusedCell.Options.UseBackColor = True
        Me.DgvClientes.Appearance.FocusedCell.Options.UseFont = True
        Me.DgvClientes.Appearance.FocusedCell.Options.UseForeColor = True
        Me.DgvClientes.Appearance.FocusedRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvClientes.Appearance.FocusedRow.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DgvClientes.Appearance.FocusedRow.Options.UseBackColor = True
        Me.DgvClientes.Appearance.FocusedRow.Options.UseFont = True
        Me.DgvClientes.Appearance.FooterPanel.Options.UseTextOptions = True
        Me.DgvClientes.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.DgvClientes.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvClientes.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DgvClientes.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White
        Me.DgvClientes.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.DgvClientes.Appearance.HideSelectionRow.Options.UseFont = True
        Me.DgvClientes.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.DgvClientes.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DgvClientes.Appearance.HorzLine.Options.UseBackColor = True
        Me.DgvClientes.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvClientes.Appearance.Row.Options.UseBackColor = True
        Me.DgvClientes.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvClientes.Appearance.RowSeparator.Options.UseBackColor = True
        Me.DgvClientes.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DgvClientes.Appearance.VertLine.Options.UseBackColor = True
        Me.DgvClientes.ColumnPanelRowHeight = 26
        Me.DgvClientes.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColIdCliente, Me.ColNombreCompleto, Me.ColDireccion, Me.ColTelefono, Me.ColCorreo, Me.ColFechaNacimiento, Me.ColSexo, Me.ColMunicipio, Me.ColEstadoCivil})
        Me.DgvClientes.GridControl = Me.GCPrincipal
        Me.DgvClientes.Name = "DgvClientes"
        Me.DgvClientes.OptionsBehavior.AllowIncrementalSearch = True
        Me.DgvClientes.OptionsBehavior.AutoSelectAllInEditor = False
        Me.DgvClientes.OptionsBehavior.Editable = False
        Me.DgvClientes.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.DgvClientes.OptionsFind.AlwaysVisible = True
        Me.DgvClientes.OptionsFind.FindNullPrompt = "Introduzca cliente a buscar..."
        Me.DgvClientes.OptionsView.ColumnAutoWidth = False
        Me.DgvClientes.OptionsView.EnableAppearanceEvenRow = True
        Me.DgvClientes.OptionsView.EnableAppearanceOddRow = True
        Me.DgvClientes.OptionsView.ShowFooter = True
        Me.DgvClientes.OptionsView.ShowGroupPanel = False
        Me.DgvClientes.RowHeight = 22
        '
        'ColIdCliente
        '
        Me.ColIdCliente.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColIdCliente.AppearanceCell.Options.UseFont = True
        Me.ColIdCliente.AppearanceCell.Options.UseTextOptions = True
        Me.ColIdCliente.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColIdCliente.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColIdCliente.AppearanceHeader.Options.UseFont = True
        Me.ColIdCliente.AppearanceHeader.Options.UseTextOptions = True
        Me.ColIdCliente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColIdCliente.Caption = "Identidad"
        Me.ColIdCliente.FieldName = "Identidad"
        Me.ColIdCliente.Name = "ColIdCliente"
        Me.ColIdCliente.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdMunicipio", "Total Clientes = {0}")})
        Me.ColIdCliente.Visible = True
        Me.ColIdCliente.VisibleIndex = 0
        Me.ColIdCliente.Width = 150
        '
        'ColNombreCompleto
        '
        Me.ColNombreCompleto.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColNombreCompleto.AppearanceCell.Options.UseFont = True
        Me.ColNombreCompleto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColNombreCompleto.AppearanceHeader.Options.UseFont = True
        Me.ColNombreCompleto.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNombreCompleto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNombreCompleto.Caption = "Nombre Completo"
        Me.ColNombreCompleto.FieldName = "Nombre_Completo"
        Me.ColNombreCompleto.Name = "ColNombreCompleto"
        Me.ColNombreCompleto.Visible = True
        Me.ColNombreCompleto.VisibleIndex = 1
        Me.ColNombreCompleto.Width = 350
        '
        'ColDireccion
        '
        Me.ColDireccion.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColDireccion.AppearanceCell.Options.UseFont = True
        Me.ColDireccion.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColDireccion.AppearanceHeader.Options.UseFont = True
        Me.ColDireccion.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDireccion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDireccion.Caption = "Dirección"
        Me.ColDireccion.FieldName = "DireccionCliente"
        Me.ColDireccion.Name = "ColDireccion"
        Me.ColDireccion.Visible = True
        Me.ColDireccion.VisibleIndex = 2
        Me.ColDireccion.Width = 300
        '
        'ColTelefono
        '
        Me.ColTelefono.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColTelefono.AppearanceCell.Options.UseFont = True
        Me.ColTelefono.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColTelefono.AppearanceHeader.Options.UseFont = True
        Me.ColTelefono.AppearanceHeader.Options.UseTextOptions = True
        Me.ColTelefono.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColTelefono.Caption = "Telefono"
        Me.ColTelefono.FieldName = "TelefonoCliente"
        Me.ColTelefono.Name = "ColTelefono"
        Me.ColTelefono.Visible = True
        Me.ColTelefono.VisibleIndex = 3
        Me.ColTelefono.Width = 100
        '
        'ColCorreo
        '
        Me.ColCorreo.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColCorreo.AppearanceCell.Options.UseFont = True
        Me.ColCorreo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColCorreo.AppearanceHeader.Options.UseFont = True
        Me.ColCorreo.AppearanceHeader.Options.UseTextOptions = True
        Me.ColCorreo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColCorreo.Caption = "Correo"
        Me.ColCorreo.FieldName = "CorreoCliente"
        Me.ColCorreo.Name = "ColCorreo"
        Me.ColCorreo.Visible = True
        Me.ColCorreo.VisibleIndex = 4
        Me.ColCorreo.Width = 160
        '
        'ColFechaNacimiento
        '
        Me.ColFechaNacimiento.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColFechaNacimiento.AppearanceCell.Options.UseFont = True
        Me.ColFechaNacimiento.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColFechaNacimiento.AppearanceHeader.Options.UseFont = True
        Me.ColFechaNacimiento.AppearanceHeader.Options.UseTextOptions = True
        Me.ColFechaNacimiento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColFechaNacimiento.Caption = "Fecha Nacimiento"
        Me.ColFechaNacimiento.FieldName = "FechaNacimiento"
        Me.ColFechaNacimiento.Name = "ColFechaNacimiento"
        Me.ColFechaNacimiento.Visible = True
        Me.ColFechaNacimiento.VisibleIndex = 5
        Me.ColFechaNacimiento.Width = 130
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
        Me.ColSexo.VisibleIndex = 6
        Me.ColSexo.Width = 100
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
        Me.ColMunicipio.VisibleIndex = 7
        Me.ColMunicipio.Width = 100
        '
        'ColEstadoCivil
        '
        Me.ColEstadoCivil.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColEstadoCivil.AppearanceCell.Options.UseFont = True
        Me.ColEstadoCivil.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColEstadoCivil.AppearanceHeader.Options.UseFont = True
        Me.ColEstadoCivil.AppearanceHeader.Options.UseTextOptions = True
        Me.ColEstadoCivil.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColEstadoCivil.Caption = "Estado Civil"
        Me.ColEstadoCivil.FieldName = "EstadoCivil"
        Me.ColEstadoCivil.Name = "ColEstadoCivil"
        Me.ColEstadoCivil.Visible = True
        Me.ColEstadoCivil.VisibleIndex = 8
        Me.ColEstadoCivil.Width = 100
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
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Rango de Fecha"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Dia"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Cliente")})
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
        'FrmGestionReporteVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 459)
        Me.Controls.Add(Me.DateEdit3)
        Me.Controls.Add(Me.RadioGroup1)
        Me.Controls.Add(Me.DateEdit2)
        Me.Controls.Add(Me.DateEdit1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GCPrincipal)
        Me.Name = "FrmGestionReporteVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Venta"
        CType(Me.GCPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit3.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GCPrincipal As DevExpress.XtraGrid.GridControl
    Friend WithEvents DgvClientes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColIdCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColNombreCompleto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDireccion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColTelefono As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCorreo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColFechaNacimiento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColSexo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColMunicipio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColEstadoCivil As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents DateEdit3 As DevExpress.XtraEditors.DateEdit
End Class
