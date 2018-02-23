<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProducto))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LblFilas = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
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
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnEditar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnInsertar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnActualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.GbProducto = New DevExpress.XtraEditors.GroupControl()
        Me.BtnCodigoProveedor = New DevExpress.XtraEditors.SimpleButton()
        Me.ChkGravado = New DevExpress.XtraEditors.CheckEdit()
        Me.TxtPrecioMayorista = New DevExpress.XtraEditors.CalcEdit()
        Me.TxtPrecioUnitario = New DevExpress.XtraEditors.CalcEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CboModelo = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColMarca = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ChkEstado = New DevExpress.XtraEditors.CheckEdit()
        Me.CboCategoria = New DevExpress.XtraEditors.LookUpEdit()
        Me.TxtExistencia = New DevExpress.XtraEditors.SpinEdit()
        Me.TxtCosto = New DevExpress.XtraEditors.CalcEdit()
        Me.TxtDescripcion = New DevExpress.XtraEditors.TextEdit()
        Me.TxtIdProducto = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.BtnEliminarImagen = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnAgregarImagen = New DevExpress.XtraEditors.SimpleButton()
        Me.PbProducto = New DevExpress.XtraEditors.PictureEdit()
        Me.TxtGravado = New DevExpress.XtraEditors.CalcEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GbProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbProducto.SuspendLayout()
        CType(Me.ChkGravado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPrecioMayorista.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPrecioUnitario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboModelo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkEstado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboCategoria.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtExistencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCosto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtIdProducto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PbProducto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtGravado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(80, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(268, 43)
        Me.Label13.TabIndex = 78
        Me.Label13.Text = "Perfil del Producto"
        '
        'LblFilas
        '
        Me.LblFilas.AutoSize = True
        Me.LblFilas.Location = New System.Drawing.Point(917, 329)
        Me.LblFilas.Name = "LblFilas"
        Me.LblFilas.Size = New System.Drawing.Size(61, 13)
        Me.LblFilas.TabIndex = 69
        Me.LblFilas.Text = "SIN DATOS"
        Me.LblFilas.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.INNOVAMASTER.My.Resources.Resources.WhatsApp_Image_2017_03_10_at_6311
        Me.PictureBox2.Location = New System.Drawing.Point(18, 15)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(61, 50)
        Me.PictureBox2.TabIndex = 82
        Me.PictureBox2.TabStop = False
        '
        'GCPrincipal
        '
        Me.GCPrincipal.Location = New System.Drawing.Point(514, 20)
        Me.GCPrincipal.MainView = Me.DgvProductos
        Me.GCPrincipal.Name = "GCPrincipal"
        Me.HelpProvider1.SetShowHelp(Me.GCPrincipal, True)
        Me.GCPrincipal.Size = New System.Drawing.Size(836, 439)
        Me.GCPrincipal.TabIndex = 104
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
        Me.DgvProductos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColIdProducto, Me.ColDescripcion, Me.ColCosto, Me.ColPrecioUnitario, Me.ColPreciolMayorista, Me.ColISV, Me.ColExistencia, Me.ColCategoria, Me.ColModelo, Me.ColEstado, Me.ColImagen})
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
        Me.ColIdProducto.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdProducto", "Total Productos = {0}")})
        Me.ColIdProducto.Visible = True
        Me.ColIdProducto.VisibleIndex = 0
        Me.ColIdProducto.Width = 150
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
        Me.ColModelo.Width = 174
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
        'SimpleButton5
        '
        Me.SimpleButton5.Image = CType(resources.GetObject("SimpleButton5.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(672, 465)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.HelpProvider1.SetShowHelp(Me.SimpleButton5, True)
        Me.SimpleButton5.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton5.TabIndex = 138
        Me.SimpleButton5.Text = "Actualizar Datos"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(843, 465)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.HelpProvider1.SetShowHelp(Me.SimpleButton4, True)
        Me.SimpleButton4.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton4.TabIndex = 137
        Me.SimpleButton4.Text = "Exportar PDF"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(1014, 465)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.HelpProvider1.SetShowHelp(Me.SimpleButton2, True)
        Me.SimpleButton2.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton2.TabIndex = 136
        Me.SimpleButton2.Text = "Exportar Excel"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(1185, 465)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.HelpProvider1.SetShowHelp(Me.SimpleButton1, True)
        Me.SimpleButton1.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton1.TabIndex = 135
        Me.SimpleButton1.Text = "Vista Previa"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnCancelar.Location = New System.Drawing.Point(370, 465)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.HelpProvider1.SetShowHelp(Me.BtnCancelar, True)
        Me.BtnCancelar.Size = New System.Drawing.Size(98, 68)
        Me.BtnCancelar.TabIndex = 143
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.Visible = False
        '
        'BtnEditar
        '
        Me.BtnEditar.Image = CType(resources.GetObject("BtnEditar.Image"), System.Drawing.Image)
        Me.BtnEditar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnEditar.Location = New System.Drawing.Point(162, 465)
        Me.BtnEditar.Name = "BtnEditar"
        Me.HelpProvider1.SetShowHelp(Me.BtnEditar, True)
        Me.BtnEditar.Size = New System.Drawing.Size(98, 68)
        Me.BtnEditar.TabIndex = 141
        Me.BtnEditar.Text = "Editar"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnNuevo.Location = New System.Drawing.Point(58, 465)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.HelpProvider1.SetShowHelp(Me.BtnNuevo, True)
        Me.BtnNuevo.Size = New System.Drawing.Size(98, 68)
        Me.BtnNuevo.TabIndex = 140
        Me.BtnNuevo.Text = "Nuevo"
        '
        'BtnInsertar
        '
        Me.BtnInsertar.Image = CType(resources.GetObject("BtnInsertar.Image"), System.Drawing.Image)
        Me.BtnInsertar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnInsertar.Location = New System.Drawing.Point(266, 465)
        Me.BtnInsertar.Name = "BtnInsertar"
        Me.HelpProvider1.SetShowHelp(Me.BtnInsertar, True)
        Me.BtnInsertar.Size = New System.Drawing.Size(98, 68)
        Me.BtnInsertar.TabIndex = 144
        Me.BtnInsertar.Text = "Guardar"
        Me.BtnInsertar.Visible = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Image = CType(resources.GetObject("BtnActualizar.Image"), System.Drawing.Image)
        Me.BtnActualizar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnActualizar.Location = New System.Drawing.Point(266, 465)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.HelpProvider1.SetShowHelp(Me.BtnActualizar, True)
        Me.BtnActualizar.Size = New System.Drawing.Size(98, 68)
        Me.BtnActualizar.TabIndex = 142
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.Visible = False
        '
        'GbProducto
        '
        Me.GbProducto.Controls.Add(Me.BtnCodigoProveedor)
        Me.GbProducto.Controls.Add(Me.ChkGravado)
        Me.GbProducto.Controls.Add(Me.TxtPrecioMayorista)
        Me.GbProducto.Controls.Add(Me.TxtPrecioUnitario)
        Me.GbProducto.Controls.Add(Me.Label6)
        Me.GbProducto.Controls.Add(Me.Label7)
        Me.GbProducto.Controls.Add(Me.CboModelo)
        Me.GbProducto.Controls.Add(Me.ChkEstado)
        Me.GbProducto.Controls.Add(Me.CboCategoria)
        Me.GbProducto.Controls.Add(Me.TxtExistencia)
        Me.GbProducto.Controls.Add(Me.TxtCosto)
        Me.GbProducto.Controls.Add(Me.TxtDescripcion)
        Me.GbProducto.Controls.Add(Me.TxtIdProducto)
        Me.GbProducto.Controls.Add(Me.PanelControl1)
        Me.GbProducto.Controls.Add(Me.PbProducto)
        Me.GbProducto.Controls.Add(Me.TxtGravado)
        Me.GbProducto.Controls.Add(Me.Label5)
        Me.GbProducto.Controls.Add(Me.Label12)
        Me.GbProducto.Controls.Add(Me.Label10)
        Me.GbProducto.Controls.Add(Me.Label9)
        Me.GbProducto.Controls.Add(Me.Label8)
        Me.GbProducto.Controls.Add(Me.Label4)
        Me.GbProducto.Controls.Add(Me.Label2)
        Me.GbProducto.Controls.Add(Me.Label1)
        Me.GbProducto.Enabled = False
        Me.GbProducto.Location = New System.Drawing.Point(18, 71)
        Me.GbProducto.Name = "GbProducto"
        Me.GbProducto.Size = New System.Drawing.Size(468, 388)
        Me.GbProducto.TabIndex = 145
        Me.GbProducto.Text = "Datos Producto"
        '
        'BtnCodigoProveedor
        '
        Me.BtnCodigoProveedor.Image = CType(resources.GetObject("BtnCodigoProveedor.Image"), System.Drawing.Image)
        Me.BtnCodigoProveedor.Location = New System.Drawing.Point(319, 347)
        Me.BtnCodigoProveedor.Name = "BtnCodigoProveedor"
        Me.BtnCodigoProveedor.Size = New System.Drawing.Size(130, 34)
        Me.BtnCodigoProveedor.TabIndex = 186
        Me.BtnCodigoProveedor.Text = "Código Proveedor"
        Me.BtnCodigoProveedor.Visible = False
        '
        'ChkGravado
        '
        Me.ChkGravado.Location = New System.Drawing.Point(245, 211)
        Me.ChkGravado.Name = "ChkGravado"
        Me.ChkGravado.Properties.Caption = "Gravado"
        Me.ChkGravado.Size = New System.Drawing.Size(68, 19)
        Me.ChkGravado.TabIndex = 185
        '
        'TxtPrecioMayorista
        '
        Me.TxtPrecioMayorista.Location = New System.Drawing.Point(146, 170)
        Me.TxtPrecioMayorista.Name = "TxtPrecioMayorista"
        Me.TxtPrecioMayorista.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtPrecioMayorista.Size = New System.Drawing.Size(157, 20)
        Me.TxtPrecioMayorista.TabIndex = 184
        '
        'TxtPrecioUnitario
        '
        Me.TxtPrecioUnitario.Location = New System.Drawing.Point(146, 133)
        Me.TxtPrecioUnitario.Name = "TxtPrecioUnitario"
        Me.TxtPrecioUnitario.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtPrecioUnitario.Size = New System.Drawing.Size(157, 20)
        Me.TxtPrecioUnitario.TabIndex = 183
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(32, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 19)
        Me.Label6.TabIndex = 182
        Me.Label6.Text = "Precio Mayorista"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(42, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 19)
        Me.Label7.TabIndex = 181
        Me.Label7.Text = "Precio Unitario"
        '
        'CboModelo
        '
        Me.CboModelo.EditValue = ""
        Me.CboModelo.Location = New System.Drawing.Point(146, 321)
        Me.CboModelo.Name = "CboModelo"
        Me.CboModelo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CboModelo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CboModelo.Properties.DisplayMember = "Modelo"
        Me.CboModelo.Properties.NullText = "SELECCIONE MODELO"
        Me.CboModelo.Properties.ValueMember = "IdModelo"
        Me.CboModelo.Properties.View = Me.SearchLookUpEdit1View
        Me.CboModelo.Size = New System.Drawing.Size(228, 20)
        Me.CboModelo.TabIndex = 180
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SearchLookUpEdit1View.Appearance.Empty.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SearchLookUpEdit1View.Appearance.Empty.Options.UseBackColor = True
        Me.SearchLookUpEdit1View.Appearance.FocusedCell.BackColor = System.Drawing.Color.DodgerBlue
        Me.SearchLookUpEdit1View.Appearance.FocusedCell.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.SearchLookUpEdit1View.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.SearchLookUpEdit1View.Appearance.FocusedCell.Options.UseBackColor = True
        Me.SearchLookUpEdit1View.Appearance.FocusedCell.Options.UseFont = True
        Me.SearchLookUpEdit1View.Appearance.FocusedCell.Options.UseForeColor = True
        Me.SearchLookUpEdit1View.Appearance.FocusedRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.SearchLookUpEdit1View.Appearance.FocusedRow.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.SearchLookUpEdit1View.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.SearchLookUpEdit1View.Appearance.FocusedRow.Options.UseBackColor = True
        Me.SearchLookUpEdit1View.Appearance.FocusedRow.Options.UseFont = True
        Me.SearchLookUpEdit1View.Appearance.FocusedRow.Options.UseForeColor = True
        Me.SearchLookUpEdit1View.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.SearchLookUpEdit1View.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.SearchLookUpEdit1View.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White
        Me.SearchLookUpEdit1View.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.SearchLookUpEdit1View.Appearance.HideSelectionRow.Options.UseFont = True
        Me.SearchLookUpEdit1View.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.SearchLookUpEdit1View.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.SearchLookUpEdit1View.Appearance.HorzLine.Options.UseBackColor = True
        Me.SearchLookUpEdit1View.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SearchLookUpEdit1View.Appearance.Row.Options.UseBackColor = True
        Me.SearchLookUpEdit1View.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.SearchLookUpEdit1View.Appearance.VertLine.Options.UseBackColor = True
        Me.SearchLookUpEdit1View.ColumnPanelRowHeight = 26
        Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColId, Me.GridColumn2, Me.ColMarca})
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsBehavior.AllowIncrementalSearch = True
        Me.SearchLookUpEdit1View.OptionsBehavior.Editable = False
        Me.SearchLookUpEdit1View.OptionsFind.AlwaysVisible = True
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.EnableAppearanceEvenRow = True
        Me.SearchLookUpEdit1View.OptionsView.EnableAppearanceOddRow = True
        Me.SearchLookUpEdit1View.OptionsView.ShowFooter = True
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        Me.SearchLookUpEdit1View.RowHeight = 22
        '
        'ColId
        '
        Me.ColId.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.ColId.AppearanceCell.Options.UseFont = True
        Me.ColId.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.ColId.AppearanceHeader.Options.UseFont = True
        Me.ColId.AppearanceHeader.Options.UseTextOptions = True
        Me.ColId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColId.Caption = "ID"
        Me.ColId.FieldName = "IdModelo"
        Me.ColId.Name = "ColId"
        Me.ColId.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdModelo", "Total = {0}")})
        Me.ColId.Visible = True
        Me.ColId.VisibleIndex = 0
        Me.ColId.Width = 146
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.GridColumn2.AppearanceCell.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.GridColumn2.AppearanceHeader.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Modelo"
        Me.GridColumn2.FieldName = "Modelo"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 245
        '
        'ColMarca
        '
        Me.ColMarca.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.ColMarca.AppearanceCell.Options.UseFont = True
        Me.ColMarca.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.ColMarca.AppearanceHeader.Options.UseFont = True
        Me.ColMarca.AppearanceHeader.Options.UseTextOptions = True
        Me.ColMarca.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColMarca.Caption = "Marca"
        Me.ColMarca.FieldName = "Marca"
        Me.ColMarca.Name = "ColMarca"
        Me.ColMarca.Visible = True
        Me.ColMarca.VisibleIndex = 2
        Me.ColMarca.Width = 305
        '
        'ChkEstado
        '
        Me.ChkEstado.Location = New System.Drawing.Point(146, 355)
        Me.ChkEstado.Name = "ChkEstado"
        Me.ChkEstado.Properties.Caption = "Activo"
        Me.ChkEstado.Size = New System.Drawing.Size(75, 19)
        Me.ChkEstado.TabIndex = 179
        '
        'CboCategoria
        '
        Me.CboCategoria.Location = New System.Drawing.Point(146, 284)
        Me.CboCategoria.Name = "CboCategoria"
        Me.CboCategoria.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CboCategoria.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CboCategoria.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdCategoria", 10, "ID"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Categoria", 40, "Categoria")})
        Me.CboCategoria.Properties.DisplayMember = "Categoria"
        Me.CboCategoria.Properties.NullText = "SELECCIONE CATEGORÍA"
        Me.CboCategoria.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.CboCategoria.Properties.ValueMember = "IdCategoria"
        Me.CboCategoria.Size = New System.Drawing.Size(228, 20)
        Me.CboCategoria.TabIndex = 178
        '
        'TxtExistencia
        '
        Me.TxtExistencia.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.TxtExistencia.Location = New System.Drawing.Point(146, 246)
        Me.TxtExistencia.Name = "TxtExistencia"
        Me.TxtExistencia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtExistencia.Size = New System.Drawing.Size(157, 20)
        Me.TxtExistencia.TabIndex = 177
        '
        'TxtCosto
        '
        Me.TxtCosto.Location = New System.Drawing.Point(146, 94)
        Me.TxtCosto.Name = "TxtCosto"
        Me.TxtCosto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtCosto.Size = New System.Drawing.Size(157, 20)
        Me.TxtCosto.TabIndex = 176
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(146, 61)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDescripcion.Size = New System.Drawing.Size(303, 20)
        Me.TxtDescripcion.TabIndex = 175
        '
        'TxtIdProducto
        '
        Me.TxtIdProducto.Location = New System.Drawing.Point(146, 22)
        Me.TxtIdProducto.Name = "TxtIdProducto"
        Me.TxtIdProducto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtIdProducto.Size = New System.Drawing.Size(174, 20)
        Me.TxtIdProducto.TabIndex = 174
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.BtnEliminarImagen)
        Me.PanelControl1.Controls.Add(Me.BtnAgregarImagen)
        Me.PanelControl1.Location = New System.Drawing.Point(319, 231)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(130, 34)
        Me.PanelControl1.TabIndex = 173
        '
        'BtnEliminarImagen
        '
        Me.BtnEliminarImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEliminarImagen.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.BtnEliminarImagen.Image = CType(resources.GetObject("BtnEliminarImagen.Image"), System.Drawing.Image)
        Me.BtnEliminarImagen.Location = New System.Drawing.Point(74, 1)
        Me.BtnEliminarImagen.Name = "BtnEliminarImagen"
        Me.BtnEliminarImagen.Size = New System.Drawing.Size(38, 30)
        Me.BtnEliminarImagen.TabIndex = 49
        '
        'BtnAgregarImagen
        '
        Me.BtnAgregarImagen.BackgroundImage = Global.INNOVAMASTER.My.Resources.Resources.image_remove
        Me.BtnAgregarImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAgregarImagen.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.BtnAgregarImagen.Image = CType(resources.GetObject("BtnAgregarImagen.Image"), System.Drawing.Image)
        Me.BtnAgregarImagen.Location = New System.Drawing.Point(13, 1)
        Me.BtnAgregarImagen.Name = "BtnAgregarImagen"
        Me.BtnAgregarImagen.Size = New System.Drawing.Size(38, 30)
        Me.BtnAgregarImagen.TabIndex = 0
        '
        'PbProducto
        '
        Me.PbProducto.Location = New System.Drawing.Point(319, 94)
        Me.PbProducto.Name = "PbProducto"
        Me.PbProducto.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PbProducto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PbProducto.Properties.ZoomAccelerationFactor = 1.0R
        Me.PbProducto.Size = New System.Drawing.Size(130, 136)
        Me.PbProducto.TabIndex = 172
        '
        'TxtGravado
        '
        Me.TxtGravado.Enabled = False
        Me.TxtGravado.Location = New System.Drawing.Point(145, 210)
        Me.TxtGravado.Name = "TxtGravado"
        Me.TxtGravado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtGravado.Size = New System.Drawing.Size(96, 20)
        Me.TxtGravado.TabIndex = 171
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(94, 356)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 19)
        Me.Label5.TabIndex = 170
        Me.Label5.Text = "Estado"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(72, 241)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 19)
        Me.Label12.TabIndex = 169
        Me.Label12.Text = "Existencia"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(92, 318)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 19)
        Me.Label10.TabIndex = 168
        Me.Label10.Text = "Modelo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(77, 282)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 19)
        Me.Label9.TabIndex = 167
        Me.Label9.Text = "Categoria"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(86, 209)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 19)
        Me.Label8.TabIndex = 166
        Me.Label8.Text = "Gravado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(102, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 19)
        Me.Label4.TabIndex = 165
        Me.Label4.Text = "Costo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(65, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 19)
        Me.Label2.TabIndex = 164
        Me.Label2.Text = "Descripción"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 19)
        Me.Label1.TabIndex = 163
        Me.Label1.Text = "Código del Producto"
        '
        'PrintingSystem1
        '
        Me.PrintingSystem1.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.GCPrincipal
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.ImageCollection.Images.SetKeyName(0, "toyota_corolla_rojo_7282904_0.jpg")
        Me.PrintableComponentLink1.ImageCollection.Images.SetKeyName(1, "logo2.png")
        Me.PrintableComponentLink1.Landscape = True
        Me.PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(30, 30, 30, 30)
        Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
        Me.PrintableComponentLink1.RtfReportFooter = resources.GetString("PrintableComponentLink1.RtfReportFooter")
        Me.PrintableComponentLink1.RtfReportHeader = resources.GetString("PrintableComponentLink1.RtfReportHeader")
        Me.PrintableComponentLink1.SkipArea = CType((DevExpress.XtraPrinting.BrickModifier.MarginalHeader Or DevExpress.XtraPrinting.BrickModifier.MarginalFooter), DevExpress.XtraPrinting.BrickModifier)
        '
        'FrmProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 573)
        Me.Controls.Add(Me.GbProducto)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnInsertar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.SimpleButton5)
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GCPrincipal)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.LblFilas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TableOfContents)
        Me.Name = "FrmProducto"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "Productos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GbProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbProducto.ResumeLayout(False)
        Me.GbProducto.PerformLayout()
        CType(Me.ChkGravado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPrecioMayorista.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPrecioUnitario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboModelo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkEstado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboCategoria.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtExistencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCosto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtIdProducto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PbProducto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtGravado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents LblFilas As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents GCPrincipal As DevExpress.XtraGrid.GridControl
    Friend WithEvents DgvProductos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColIdProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCosto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPrecioUnitario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPreciolMayorista As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColExistencia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCategoria As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColModelo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ColImagen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColISV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnEditar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnInsertar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnActualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GbProducto As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BtnCodigoProveedor As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ChkGravado As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents TxtPrecioMayorista As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents TxtPrecioUnitario As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CboModelo As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColMarca As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChkEstado As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CboCategoria As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TxtExistencia As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents TxtCosto As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents TxtDescripcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtIdProducto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BtnEliminarImagen As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnAgregarImagen As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PbProducto As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents TxtGravado As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents Label5 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
End Class
