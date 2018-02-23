<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEmpleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEmpleado))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.GCPrincipal = New DevExpress.XtraGrid.GridControl()
        Me.DgvEmpleado = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColIdEmpleado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColApellido = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDireccion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColTelefono = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColFechaN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColFechaC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCargo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColMunicipio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColEstadoC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColProfesion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSexo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSucursal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnEditar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnInsertar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnActualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.GbEmpleado = New DevExpress.XtraEditors.GroupControl()
        Me.PbEmpleado = New DevExpress.XtraEditors.PictureEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.CboSexo = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.CmbEstadoCivil = New DevExpress.XtraEditors.LookUpEdit()
        Me.BtnBProfesion = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.CboSucursal = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.CboProfesion = New DevExpress.XtraEditors.LookUpEdit()
        Me.BtnBCargo = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnBusquedaMunicipio = New DevExpress.XtraEditors.SimpleButton()
        Me.DteFechaC = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.CboCargo = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.CmbMunicipio = New DevExpress.XtraEditors.LookUpEdit()
        Me.DteFechaNac = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtCelular = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtTelefono = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtDireccion = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtApellidos = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtNombres = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtIdEmpleado = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GbEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbEmpleado.SuspendLayout()
        CType(Me.PbEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.CboSexo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbEstadoCivil.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboProfesion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DteFechaC.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DteFechaC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboCargo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbMunicipio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DteFechaNac.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DteFechaNac.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCelular.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTelefono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDireccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtApellidos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNombres.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtIdEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(69, 2)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(0, 43)
        Me.Label16.TabIndex = 59
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.INNOVAMASTER.My.Resources.Resources._2
        Me.PictureBox2.Location = New System.Drawing.Point(16, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(59, 51)
        Me.PictureBox2.TabIndex = 64
        Me.PictureBox2.TabStop = False
        '
        'GCPrincipal
        '
        Me.GCPrincipal.Location = New System.Drawing.Point(602, 20)
        Me.GCPrincipal.MainView = Me.DgvEmpleado
        Me.GCPrincipal.Name = "GCPrincipal"
        Me.GCPrincipal.Size = New System.Drawing.Size(748, 447)
        Me.GCPrincipal.TabIndex = 108
        Me.GCPrincipal.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DgvEmpleado})
        '
        'DgvEmpleado
        '
        Me.DgvEmpleado.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvEmpleado.Appearance.Empty.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvEmpleado.Appearance.Empty.Options.UseBackColor = True
        Me.DgvEmpleado.Appearance.FocusedCell.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvEmpleado.Appearance.FocusedCell.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DgvEmpleado.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.DgvEmpleado.Appearance.FocusedCell.Options.UseBackColor = True
        Me.DgvEmpleado.Appearance.FocusedCell.Options.UseFont = True
        Me.DgvEmpleado.Appearance.FocusedCell.Options.UseForeColor = True
        Me.DgvEmpleado.Appearance.FocusedRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvEmpleado.Appearance.FocusedRow.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DgvEmpleado.Appearance.FocusedRow.Options.UseBackColor = True
        Me.DgvEmpleado.Appearance.FocusedRow.Options.UseFont = True
        Me.DgvEmpleado.Appearance.FooterPanel.Options.UseTextOptions = True
        Me.DgvEmpleado.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.DgvEmpleado.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvEmpleado.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DgvEmpleado.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White
        Me.DgvEmpleado.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.DgvEmpleado.Appearance.HideSelectionRow.Options.UseFont = True
        Me.DgvEmpleado.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.DgvEmpleado.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DgvEmpleado.Appearance.HorzLine.Options.UseBackColor = True
        Me.DgvEmpleado.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvEmpleado.Appearance.Row.Options.UseBackColor = True
        Me.DgvEmpleado.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvEmpleado.Appearance.RowSeparator.Options.UseBackColor = True
        Me.DgvEmpleado.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DgvEmpleado.Appearance.VertLine.Options.UseBackColor = True
        Me.DgvEmpleado.ColumnPanelRowHeight = 26
        Me.DgvEmpleado.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColIdEmpleado, Me.ColNombre, Me.ColApellido, Me.ColDireccion, Me.ColTelefono, Me.ColCel, Me.ColFechaN, Me.ColFechaC, Me.ColCargo, Me.ColMunicipio, Me.ColEstadoC, Me.ColProfesion, Me.ColSexo, Me.ColSucursal})
        Me.DgvEmpleado.GridControl = Me.GCPrincipal
        Me.DgvEmpleado.Name = "DgvEmpleado"
        Me.DgvEmpleado.OptionsBehavior.AllowIncrementalSearch = True
        Me.DgvEmpleado.OptionsBehavior.AutoSelectAllInEditor = False
        Me.DgvEmpleado.OptionsBehavior.Editable = False
        Me.DgvEmpleado.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.DgvEmpleado.OptionsFind.AlwaysVisible = True
        Me.DgvEmpleado.OptionsFind.FindNullPrompt = "Introduzca municipio a buscar..."
        Me.DgvEmpleado.OptionsView.ColumnAutoWidth = False
        Me.DgvEmpleado.OptionsView.EnableAppearanceEvenRow = True
        Me.DgvEmpleado.OptionsView.EnableAppearanceOddRow = True
        Me.DgvEmpleado.OptionsView.ShowFooter = True
        Me.DgvEmpleado.OptionsView.ShowGroupPanel = False
        Me.DgvEmpleado.RowHeight = 22
        '
        'ColIdEmpleado
        '
        Me.ColIdEmpleado.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColIdEmpleado.AppearanceCell.Options.UseFont = True
        Me.ColIdEmpleado.AppearanceCell.Options.UseTextOptions = True
        Me.ColIdEmpleado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColIdEmpleado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColIdEmpleado.AppearanceHeader.Options.UseFont = True
        Me.ColIdEmpleado.AppearanceHeader.Options.UseTextOptions = True
        Me.ColIdEmpleado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColIdEmpleado.Caption = "ID"
        Me.ColIdEmpleado.FieldName = "Identidad"
        Me.ColIdEmpleado.Name = "ColIdEmpleado"
        Me.ColIdEmpleado.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdProveedor", "Total Empleado = {0}")})
        Me.ColIdEmpleado.Visible = True
        Me.ColIdEmpleado.VisibleIndex = 0
        Me.ColIdEmpleado.Width = 156
        '
        'ColNombre
        '
        Me.ColNombre.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColNombre.AppearanceCell.Options.UseFont = True
        Me.ColNombre.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColNombre.AppearanceHeader.Options.UseFont = True
        Me.ColNombre.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNombre.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNombre.Caption = "Nombre Empleado"
        Me.ColNombre.FieldName = "NombreEmpleado"
        Me.ColNombre.Name = "ColNombre"
        Me.ColNombre.Visible = True
        Me.ColNombre.VisibleIndex = 1
        Me.ColNombre.Width = 209
        '
        'ColApellido
        '
        Me.ColApellido.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColApellido.AppearanceCell.Options.UseFont = True
        Me.ColApellido.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColApellido.AppearanceHeader.Options.UseFont = True
        Me.ColApellido.AppearanceHeader.Options.UseTextOptions = True
        Me.ColApellido.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColApellido.Caption = "Apellido Empleado"
        Me.ColApellido.FieldName = "ApellidoEmpleado"
        Me.ColApellido.Name = "ColApellido"
        Me.ColApellido.Visible = True
        Me.ColApellido.VisibleIndex = 2
        Me.ColApellido.Width = 184
        '
        'ColDireccion
        '
        Me.ColDireccion.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColDireccion.AppearanceCell.Options.UseFont = True
        Me.ColDireccion.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColDireccion.AppearanceHeader.Options.UseFont = True
        Me.ColDireccion.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDireccion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDireccion.Caption = "Direccion Empleado"
        Me.ColDireccion.FieldName = "DireccionEmpleado"
        Me.ColDireccion.Name = "ColDireccion"
        Me.ColDireccion.Visible = True
        Me.ColDireccion.VisibleIndex = 3
        Me.ColDireccion.Width = 156
        '
        'ColTelefono
        '
        Me.ColTelefono.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColTelefono.AppearanceCell.Options.UseFont = True
        Me.ColTelefono.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColTelefono.AppearanceHeader.Options.UseFont = True
        Me.ColTelefono.AppearanceHeader.Options.UseTextOptions = True
        Me.ColTelefono.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColTelefono.Caption = "Telefono Empleado"
        Me.ColTelefono.FieldName = "TelefonoEmpleado"
        Me.ColTelefono.Name = "ColTelefono"
        Me.ColTelefono.Visible = True
        Me.ColTelefono.VisibleIndex = 4
        Me.ColTelefono.Width = 141
        '
        'ColCel
        '
        Me.ColCel.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColCel.AppearanceCell.Options.UseFont = True
        Me.ColCel.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColCel.AppearanceHeader.Options.UseFont = True
        Me.ColCel.AppearanceHeader.Options.UseTextOptions = True
        Me.ColCel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColCel.Caption = "Celular Empleado"
        Me.ColCel.FieldName = "CelularEmpleado"
        Me.ColCel.Name = "ColCel"
        Me.ColCel.Visible = True
        Me.ColCel.VisibleIndex = 5
        Me.ColCel.Width = 134
        '
        'ColFechaN
        '
        Me.ColFechaN.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColFechaN.AppearanceCell.Options.UseFont = True
        Me.ColFechaN.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColFechaN.AppearanceHeader.Options.UseFont = True
        Me.ColFechaN.AppearanceHeader.Options.UseTextOptions = True
        Me.ColFechaN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColFechaN.Caption = "Fecha de Nacimiento"
        Me.ColFechaN.FieldName = "FechaNacimiento"
        Me.ColFechaN.Name = "ColFechaN"
        Me.ColFechaN.Visible = True
        Me.ColFechaN.VisibleIndex = 6
        Me.ColFechaN.Width = 148
        '
        'ColFechaC
        '
        Me.ColFechaC.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColFechaC.AppearanceCell.Options.UseFont = True
        Me.ColFechaC.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColFechaC.AppearanceHeader.Options.UseFont = True
        Me.ColFechaC.AppearanceHeader.Options.UseTextOptions = True
        Me.ColFechaC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColFechaC.Caption = "Fecha Contratación"
        Me.ColFechaC.FieldName = "FechaContratacion"
        Me.ColFechaC.Name = "ColFechaC"
        Me.ColFechaC.Visible = True
        Me.ColFechaC.VisibleIndex = 7
        Me.ColFechaC.Width = 140
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
        Me.ColCargo.VisibleIndex = 8
        Me.ColCargo.Width = 128
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
        Me.ColMunicipio.VisibleIndex = 10
        Me.ColMunicipio.Width = 132
        '
        'ColEstadoC
        '
        Me.ColEstadoC.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColEstadoC.AppearanceCell.Options.UseFont = True
        Me.ColEstadoC.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColEstadoC.AppearanceHeader.Options.UseFont = True
        Me.ColEstadoC.AppearanceHeader.Options.UseTextOptions = True
        Me.ColEstadoC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColEstadoC.Caption = "Estado Civil"
        Me.ColEstadoC.FieldName = "EstadoCivil"
        Me.ColEstadoC.Name = "ColEstadoC"
        Me.ColEstadoC.Visible = True
        Me.ColEstadoC.VisibleIndex = 9
        '
        'ColProfesion
        '
        Me.ColProfesion.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColProfesion.AppearanceCell.Options.UseFont = True
        Me.ColProfesion.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColProfesion.AppearanceHeader.Options.UseFont = True
        Me.ColProfesion.AppearanceHeader.Options.UseTextOptions = True
        Me.ColProfesion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColProfesion.Caption = "Profesión"
        Me.ColProfesion.FieldName = "Profesion"
        Me.ColProfesion.Name = "ColProfesion"
        Me.ColProfesion.Visible = True
        Me.ColProfesion.VisibleIndex = 12
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
        Me.ColSexo.VisibleIndex = 11
        '
        'ColSucursal
        '
        Me.ColSucursal.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.ColSucursal.AppearanceCell.Options.UseFont = True
        Me.ColSucursal.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ColSucursal.AppearanceHeader.Options.UseFont = True
        Me.ColSucursal.AppearanceHeader.Options.UseTextOptions = True
        Me.ColSucursal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColSucursal.Caption = "Sucursal"
        Me.ColSucursal.FieldName = "Sucursal"
        Me.ColSucursal.Name = "ColSucursal"
        Me.ColSucursal.Visible = True
        Me.ColSucursal.VisibleIndex = 13
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Image = CType(resources.GetObject("SimpleButton5.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(672, 473)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton5.TabIndex = 152
        Me.SimpleButton5.Text = "Actualizar Datos"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(843, 473)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton4.TabIndex = 151
        Me.SimpleButton4.Text = "Exportar PDF"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(1014, 473)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton1.TabIndex = 150
        Me.SimpleButton1.Text = "Exportar Excel"
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Image = CType(resources.GetObject("SimpleButton6.Image"), System.Drawing.Image)
        Me.SimpleButton6.Location = New System.Drawing.Point(1185, 473)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton6.TabIndex = 149
        Me.SimpleButton6.Text = "Vista Previa"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnCancelar.Location = New System.Drawing.Point(385, 478)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(98, 68)
        Me.BtnCancelar.TabIndex = 157
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.Visible = False
        '
        'BtnEditar
        '
        Me.BtnEditar.Image = CType(resources.GetObject("BtnEditar.Image"), System.Drawing.Image)
        Me.BtnEditar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnEditar.Location = New System.Drawing.Point(177, 478)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(98, 68)
        Me.BtnEditar.TabIndex = 155
        Me.BtnEditar.Text = "Editar"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnNuevo.Location = New System.Drawing.Point(73, 478)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(98, 68)
        Me.BtnNuevo.TabIndex = 154
        Me.BtnNuevo.Text = "Nuevo"
        '
        'BtnInsertar
        '
        Me.BtnInsertar.Image = CType(resources.GetObject("BtnInsertar.Image"), System.Drawing.Image)
        Me.BtnInsertar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnInsertar.Location = New System.Drawing.Point(281, 480)
        Me.BtnInsertar.Name = "BtnInsertar"
        Me.BtnInsertar.Size = New System.Drawing.Size(98, 68)
        Me.BtnInsertar.TabIndex = 158
        Me.BtnInsertar.Text = "Guardar"
        Me.BtnInsertar.Visible = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Image = CType(resources.GetObject("BtnActualizar.Image"), System.Drawing.Image)
        Me.BtnActualizar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnActualizar.Location = New System.Drawing.Point(281, 478)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(98, 68)
        Me.BtnActualizar.TabIndex = 156
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.Visible = False
        '
        'GbEmpleado
        '
        Me.GbEmpleado.Controls.Add(Me.PbEmpleado)
        Me.GbEmpleado.Controls.Add(Me.PanelControl1)
        Me.GbEmpleado.Controls.Add(Me.LabelControl13)
        Me.GbEmpleado.Controls.Add(Me.CboSexo)
        Me.GbEmpleado.Controls.Add(Me.LabelControl14)
        Me.GbEmpleado.Controls.Add(Me.CmbEstadoCivil)
        Me.GbEmpleado.Controls.Add(Me.BtnBProfesion)
        Me.GbEmpleado.Controls.Add(Me.LabelControl11)
        Me.GbEmpleado.Controls.Add(Me.CboSucursal)
        Me.GbEmpleado.Controls.Add(Me.LabelControl12)
        Me.GbEmpleado.Controls.Add(Me.CboProfesion)
        Me.GbEmpleado.Controls.Add(Me.BtnBCargo)
        Me.GbEmpleado.Controls.Add(Me.BtnBusquedaMunicipio)
        Me.GbEmpleado.Controls.Add(Me.DteFechaC)
        Me.GbEmpleado.Controls.Add(Me.LabelControl10)
        Me.GbEmpleado.Controls.Add(Me.LabelControl9)
        Me.GbEmpleado.Controls.Add(Me.CboCargo)
        Me.GbEmpleado.Controls.Add(Me.LabelControl8)
        Me.GbEmpleado.Controls.Add(Me.CmbMunicipio)
        Me.GbEmpleado.Controls.Add(Me.DteFechaNac)
        Me.GbEmpleado.Controls.Add(Me.LabelControl7)
        Me.GbEmpleado.Controls.Add(Me.LabelControl6)
        Me.GbEmpleado.Controls.Add(Me.TxtCelular)
        Me.GbEmpleado.Controls.Add(Me.LabelControl5)
        Me.GbEmpleado.Controls.Add(Me.TxtTelefono)
        Me.GbEmpleado.Controls.Add(Me.LabelControl4)
        Me.GbEmpleado.Controls.Add(Me.TxtDireccion)
        Me.GbEmpleado.Controls.Add(Me.LabelControl3)
        Me.GbEmpleado.Controls.Add(Me.TxtApellidos)
        Me.GbEmpleado.Controls.Add(Me.LabelControl2)
        Me.GbEmpleado.Controls.Add(Me.TxtNombres)
        Me.GbEmpleado.Controls.Add(Me.LabelControl15)
        Me.GbEmpleado.Controls.Add(Me.TxtIdEmpleado)
        Me.GbEmpleado.Location = New System.Drawing.Point(12, 70)
        Me.GbEmpleado.Name = "GbEmpleado"
        Me.GbEmpleado.Size = New System.Drawing.Size(580, 383)
        Me.GbEmpleado.TabIndex = 159
        Me.GbEmpleado.Text = "Datos Empleado"
        '
        'PbEmpleado
        '
        Me.PbEmpleado.Location = New System.Drawing.Point(404, 28)
        Me.PbEmpleado.Name = "PbEmpleado"
        Me.PbEmpleado.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PbEmpleado.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PbEmpleado.Properties.ZoomAccelerationFactor = 1.0R
        Me.PbEmpleado.Size = New System.Drawing.Size(129, 124)
        Me.PbEmpleado.TabIndex = 49
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.SimpleButton2)
        Me.PanelControl1.Controls.Add(Me.SimpleButton3)
        Me.PanelControl1.Location = New System.Drawing.Point(403, 153)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(130, 34)
        Me.PanelControl1.TabIndex = 48
        '
        'SimpleButton2
        '
        Me.SimpleButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SimpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(74, 1)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(38, 30)
        Me.SimpleButton2.TabIndex = 49
        '
        'SimpleButton3
        '
        Me.SimpleButton3.BackgroundImage = Global.INNOVAMASTER.My.Resources.Resources.image_remove
        Me.SimpleButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SimpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(13, 2)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(38, 30)
        Me.SimpleButton3.TabIndex = 0
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl13.Location = New System.Drawing.Point(367, 337)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(31, 19)
        Me.LabelControl13.TabIndex = 30
        Me.LabelControl13.Text = "Sexo"
        '
        'CboSexo
        '
        Me.CboSexo.Location = New System.Drawing.Point(404, 338)
        Me.CboSexo.Name = "CboSexo"
        Me.CboSexo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CboSexo.Properties.DisplayMember = "Sexo"
        Me.CboSexo.Properties.NullText = "Seleccione Sexo"
        Me.CboSexo.Properties.ValueMember = "IdSexo"
        Me.CboSexo.Size = New System.Drawing.Size(135, 20)
        Me.CboSexo.TabIndex = 29
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl14.Location = New System.Drawing.Point(80, 339)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(74, 19)
        Me.LabelControl14.TabIndex = 28
        Me.LabelControl14.Text = "Estado Civil"
        '
        'CmbEstadoCivil
        '
        Me.CmbEstadoCivil.Location = New System.Drawing.Point(160, 339)
        Me.CmbEstadoCivil.Name = "CmbEstadoCivil"
        Me.CmbEstadoCivil.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbEstadoCivil.Properties.DisplayMember = "EstadoCivil"
        Me.CmbEstadoCivil.Properties.NullText = "Seleccione Estado Civil"
        Me.CmbEstadoCivil.Properties.ValueMember = "IdEstadoCivil"
        Me.CmbEstadoCivil.Size = New System.Drawing.Size(135, 20)
        Me.CmbEstadoCivil.TabIndex = 27
        '
        'BtnBProfesion
        '
        Me.BtnBProfesion.Location = New System.Drawing.Point(301, 309)
        Me.BtnBProfesion.Name = "BtnBProfesion"
        Me.BtnBProfesion.Size = New System.Drawing.Size(29, 23)
        Me.BtnBProfesion.TabIndex = 26
        Me.BtnBProfesion.Text = "..."
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl11.Location = New System.Drawing.Point(345, 307)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(53, 19)
        Me.LabelControl11.TabIndex = 25
        Me.LabelControl11.Text = "Sucursal"
        '
        'CboSucursal
        '
        Me.CboSucursal.Location = New System.Drawing.Point(404, 308)
        Me.CboSucursal.Name = "CboSucursal"
        Me.CboSucursal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CboSucursal.Properties.DisplayMember = "Sucursal"
        Me.CboSucursal.Properties.NullText = "Seleccione Sucursal"
        Me.CboSucursal.Properties.ValueMember = "IdSucursal"
        Me.CboSucursal.Size = New System.Drawing.Size(135, 20)
        Me.CboSucursal.TabIndex = 24
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl12.Location = New System.Drawing.Point(92, 309)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(58, 19)
        Me.LabelControl12.TabIndex = 23
        Me.LabelControl12.Text = "Profesión"
        '
        'CboProfesion
        '
        Me.CboProfesion.Location = New System.Drawing.Point(160, 310)
        Me.CboProfesion.Name = "CboProfesion"
        Me.CboProfesion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CboProfesion.Properties.DisplayMember = "Profesion"
        Me.CboProfesion.Properties.NullText = "Seleccione Profesión"
        Me.CboProfesion.Properties.ValueMember = "IdProfesion"
        Me.CboProfesion.Size = New System.Drawing.Size(135, 20)
        Me.CboProfesion.TabIndex = 22
        '
        'BtnBCargo
        '
        Me.BtnBCargo.Location = New System.Drawing.Point(545, 250)
        Me.BtnBCargo.Name = "BtnBCargo"
        Me.BtnBCargo.Size = New System.Drawing.Size(29, 23)
        Me.BtnBCargo.TabIndex = 21
        Me.BtnBCargo.Text = "..."
        '
        'BtnBusquedaMunicipio
        '
        Me.BtnBusquedaMunicipio.Location = New System.Drawing.Point(301, 253)
        Me.BtnBusquedaMunicipio.Name = "BtnBusquedaMunicipio"
        Me.BtnBusquedaMunicipio.Size = New System.Drawing.Size(29, 23)
        Me.BtnBusquedaMunicipio.TabIndex = 20
        Me.BtnBusquedaMunicipio.Text = "..."
        '
        'DteFechaC
        '
        Me.DteFechaC.EditValue = Nothing
        Me.DteFechaC.Location = New System.Drawing.Point(159, 279)
        Me.DteFechaC.Name = "DteFechaC"
        Me.DteFechaC.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DteFechaC.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DteFechaC.Size = New System.Drawing.Size(135, 20)
        Me.DteFechaC.TabIndex = 19
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl10.Location = New System.Drawing.Point(12, 279)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(143, 19)
        Me.LabelControl10.TabIndex = 18
        Me.LabelControl10.Text = "Fecha de Contratación"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl9.Location = New System.Drawing.Point(364, 254)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(35, 19)
        Me.LabelControl9.TabIndex = 17
        Me.LabelControl9.Text = "Cargo"
        '
        'CboCargo
        '
        Me.CboCargo.Location = New System.Drawing.Point(404, 252)
        Me.CboCargo.Name = "CboCargo"
        Me.CboCargo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CboCargo.Properties.DisplayMember = "Cargo"
        Me.CboCargo.Properties.NullText = "Seleccione Cargo"
        Me.CboCargo.Properties.ValueMember = "IdCargo"
        Me.CboCargo.Size = New System.Drawing.Size(135, 20)
        Me.CboCargo.TabIndex = 16
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl8.Location = New System.Drawing.Point(92, 253)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(58, 19)
        Me.LabelControl8.TabIndex = 15
        Me.LabelControl8.Text = "Municipio"
        '
        'CmbMunicipio
        '
        Me.CmbMunicipio.Location = New System.Drawing.Point(160, 254)
        Me.CmbMunicipio.Name = "CmbMunicipio"
        Me.CmbMunicipio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbMunicipio.Properties.DisplayMember = "Municipio"
        Me.CmbMunicipio.Properties.NullText = "Seleccione Municipio"
        Me.CmbMunicipio.Properties.ValueMember = "IdMunicipio"
        Me.CmbMunicipio.Size = New System.Drawing.Size(135, 20)
        Me.CmbMunicipio.TabIndex = 14
        '
        'DteFechaNac
        '
        Me.DteFechaNac.EditValue = Nothing
        Me.DteFechaNac.Location = New System.Drawing.Point(160, 226)
        Me.DteFechaNac.Name = "DteFechaNac"
        Me.DteFechaNac.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DteFechaNac.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DteFechaNac.Size = New System.Drawing.Size(135, 20)
        Me.DteFechaNac.TabIndex = 13
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl7.Location = New System.Drawing.Point(13, 226)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(134, 19)
        Me.LabelControl7.TabIndex = 12
        Me.LabelControl7.Text = "Fecha de Nacimiento"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl6.Location = New System.Drawing.Point(366, 201)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(43, 19)
        Me.LabelControl6.TabIndex = 11
        Me.LabelControl6.Text = "Celular"
        '
        'TxtCelular
        '
        Me.TxtCelular.Location = New System.Drawing.Point(415, 200)
        Me.TxtCelular.Name = "TxtCelular"
        Me.TxtCelular.Properties.Mask.EditMask = "\d\d?\d?\d?-\d?\d?\d?\d?"
        Me.TxtCelular.Properties.Mask.IgnoreMaskBlank = False
        Me.TxtCelular.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular
        Me.TxtCelular.Properties.Mask.PlaceHolder = Global.Microsoft.VisualBasic.ChrW(32)
        Me.TxtCelular.Size = New System.Drawing.Size(109, 20)
        Me.TxtCelular.TabIndex = 10
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl5.Location = New System.Drawing.Point(92, 201)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(55, 19)
        Me.LabelControl5.TabIndex = 9
        Me.LabelControl5.Text = "Teléfono"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(160, 200)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Properties.Mask.EditMask = "\d\d?\d?\d?-\d?\d?\d?\d?"
        Me.TxtTelefono.Properties.Mask.IgnoreMaskBlank = False
        Me.TxtTelefono.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular
        Me.TxtTelefono.Properties.Mask.PlaceHolder = Global.Microsoft.VisualBasic.ChrW(32)
        Me.TxtTelefono.Size = New System.Drawing.Size(109, 20)
        Me.TxtTelefono.TabIndex = 8
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl4.Location = New System.Drawing.Point(89, 121)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(58, 19)
        Me.LabelControl4.TabIndex = 7
        Me.LabelControl4.Text = "Dirección"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(160, 118)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(226, 69)
        Me.TxtDireccion.TabIndex = 6
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Location = New System.Drawing.Point(89, 91)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(57, 19)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "Apellidos"
        '
        'TxtApellidos
        '
        Me.TxtApellidos.Location = New System.Drawing.Point(160, 92)
        Me.TxtApellidos.Name = "TxtApellidos"
        Me.TxtApellidos.Size = New System.Drawing.Size(226, 20)
        Me.TxtApellidos.TabIndex = 4
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Location = New System.Drawing.Point(89, 65)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(55, 19)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Nombres"
        '
        'TxtNombres
        '
        Me.TxtNombres.Location = New System.Drawing.Point(160, 66)
        Me.TxtNombres.Name = "TxtNombres"
        Me.TxtNombres.Size = New System.Drawing.Size(226, 20)
        Me.TxtNombres.TabIndex = 2
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl15.Location = New System.Drawing.Point(39, 37)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(105, 19)
        Me.LabelControl15.TabIndex = 1
        Me.LabelControl15.Text = "Código Empleado"
        '
        'TxtIdEmpleado
        '
        Me.TxtIdEmpleado.Location = New System.Drawing.Point(158, 38)
        Me.TxtIdEmpleado.Name = "TxtIdEmpleado"
        Me.TxtIdEmpleado.Properties.Mask.EditMask = "\d?\d?\d?\d?-\d?\d?\d?\d?-\d?\d?\d?\d?\d?"
        Me.TxtIdEmpleado.Properties.Mask.IgnoreMaskBlank = False
        Me.TxtIdEmpleado.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular
        Me.TxtIdEmpleado.Properties.Mask.PlaceHolder = Global.Microsoft.VisualBasic.ChrW(32)
        Me.TxtIdEmpleado.Size = New System.Drawing.Size(137, 20)
        Me.TxtIdEmpleado.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.LabelControl1.Location = New System.Drawing.Point(73, 10)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(263, 43)
        Me.LabelControl1.TabIndex = 160
        Me.LabelControl1.Text = "Perfil del Empleado"
        '
        'FrmEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 589)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.GbEmpleado)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnInsertar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.SimpleButton5)
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.SimpleButton6)
        Me.Controls.Add(Me.GCPrincipal)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label16)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TableOfContents)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmEmpleado"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empleados"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GbEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbEmpleado.ResumeLayout(False)
        Me.GbEmpleado.PerformLayout()
        CType(Me.PbEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.CboSexo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbEstadoCivil.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboProfesion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DteFechaC.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DteFechaC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboCargo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbMunicipio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DteFechaNac.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DteFechaNac.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCelular.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTelefono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDireccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtApellidos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNombres.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtIdEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label16 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents GCPrincipal As DevExpress.XtraGrid.GridControl
    Friend WithEvents DgvEmpleado As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColIdEmpleado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColApellido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDireccion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColTelefono As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColFechaN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColFechaC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCargo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColMunicipio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColEstadoC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColProfesion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColSexo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColSucursal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnEditar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnInsertar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnActualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GbEmpleado As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CboSexo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CmbEstadoCivil As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents BtnBProfesion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CboSucursal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CboProfesion As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents BtnBCargo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnBusquedaMunicipio As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DteFechaC As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CboCargo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CmbMunicipio As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents DteFechaNac As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtCelular As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtTelefono As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtDireccion As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtApellidos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtNombres As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtIdEmpleado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PbEmpleado As DevExpress.XtraEditors.PictureEdit
End Class
