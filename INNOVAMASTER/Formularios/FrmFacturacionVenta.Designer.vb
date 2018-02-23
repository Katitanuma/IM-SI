<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmFacturacionVenta
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFacturacionVenta))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.PopupMenu2 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.BtnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnEliminarTodo = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnFacturar = New DevExpress.XtraEditors.SimpleButton()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ISV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDescuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DgvDetalle = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LblCant = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblCambio = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtSubtotal = New DevExpress.XtraEditors.TextEdit()
        Me.TxtDescuento = New DevExpress.XtraEditors.TextEdit()
        Me.TxtImpuesto = New DevExpress.XtraEditors.TextEdit()
        Me.TxtTotal = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.BtnBusqueda = New DevExpress.XtraEditors.SimpleButton()
        Me.TxtFechaVencimiento = New DevExpress.XtraEditors.DateEdit()
        Me.TxtFechaVenta = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.TxtP = New DevExpress.XtraEditors.TextEdit()
        Me.TxtDescuentoExtra = New DevExpress.XtraEditors.CalcEdit()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.RdbCantidad = New System.Windows.Forms.RadioButton()
        Me.RdbPorcentaje = New System.Windows.Forms.RadioButton()
        Me.LblP = New System.Windows.Forms.Label()
        Me.TxtIdVenta = New DevExpress.XtraEditors.TextEdit()
        Me.CboTV = New DevExpress.XtraEditors.DropDownButton()
        Me.CboFV = New DevExpress.XtraEditors.DropDownButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CboCliente = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LblSaberCredito = New System.Windows.Forms.Label()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSubtotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDescuento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtImpuesto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.TxtFechaVencimiento.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFechaVencimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFechaVenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.TxtP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDescuentoExtra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtIdVenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5})
        Me.BarManager1.MaxItemId = 5
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1354, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 563)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1354, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 563)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1354, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 563)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Unitario"
        Me.BarButtonItem1.Glyph = Global.INNOVAMASTER.My.Resources.Resources.Cherry_48px
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Mayoreo"
        Me.BarButtonItem2.Glyph = Global.INNOVAMASTER.My.Resources.Resources.Color_Palette_48px
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Contado"
        Me.BarButtonItem3.Glyph = Global.INNOVAMASTER.My.Resources.Resources.Cash_in_Hand_48px
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "BarButtonItem4"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Crédito"
        Me.BarButtonItem5.Glyph = Global.INNOVAMASTER.My.Resources.Resources.Money_Box_48px
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'PopupMenu2
        '
        Me.PopupMenu2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5)})
        Me.PopupMenu2.Manager = Me.BarManager1
        Me.PopupMenu2.Name = "PopupMenu2"
        '
        'PopupMenu1
        '
        Me.PopupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2)})
        Me.PopupMenu1.Manager = Me.BarManager1
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Appearance.Options.UseFont = True
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(840, 487)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.HelpProvider1.SetShowHelp(Me.BtnCancelar, True)
        Me.BtnCancelar.Size = New System.Drawing.Size(167, 46)
        Me.BtnCancelar.TabIndex = 141
        Me.BtnCancelar.Text = "&Cancelar"
        '
        'BtnEliminarTodo
        '
        Me.BtnEliminarTodo.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminarTodo.Appearance.Options.UseFont = True
        Me.BtnEliminarTodo.Image = CType(resources.GetObject("BtnEliminarTodo.Image"), System.Drawing.Image)
        Me.BtnEliminarTodo.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.BtnEliminarTodo.Location = New System.Drawing.Point(1013, 487)
        Me.BtnEliminarTodo.Name = "BtnEliminarTodo"
        Me.HelpProvider1.SetShowHelp(Me.BtnEliminarTodo, True)
        Me.BtnEliminarTodo.Size = New System.Drawing.Size(167, 46)
        Me.BtnEliminarTodo.TabIndex = 140
        Me.BtnEliminarTodo.Text = "&Eliminar Todos"
        '
        'BtnFacturar
        '
        Me.BtnFacturar.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFacturar.Appearance.Options.UseFont = True
        Me.BtnFacturar.Image = Global.INNOVAMASTER.My.Resources.Resources.Receipt_32px
        Me.BtnFacturar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.BtnFacturar.Location = New System.Drawing.Point(1186, 487)
        Me.BtnFacturar.Name = "BtnFacturar"
        Me.HelpProvider1.SetShowHelp(Me.BtnFacturar, True)
        Me.BtnFacturar.Size = New System.Drawing.Size(164, 46)
        Me.BtnFacturar.TabIndex = 142
        Me.BtnFacturar.Text = "&Facturar"
        '
        'Total
        '
        Me.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'ISV
        '
        Me.ISV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ISV.HeaderText = "ISV"
        Me.ISV.Name = "ISV"
        Me.ISV.ReadOnly = True
        '
        'TotalDescuento
        '
        Me.TotalDescuento.HeaderText = "Total Descuento"
        Me.TotalDescuento.Name = "TotalDescuento"
        '
        'Descuento
        '
        Me.Descuento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Descuento.HeaderText = "Descuento %"
        Me.Descuento.Name = "Descuento"
        '
        'Precio
        '
        Me.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Width = 75
        '
        'Descripcion
        '
        Me.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Descripcion.Frozen = True
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Width = 163
        '
        'Codigo
        '
        Me.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Codigo.Frozen = True
        Me.Codigo.HeaderText = "Código"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Width = 163
        '
        'Eliminar
        '
        Me.Eliminar.Frozen = True
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.ToolTipText = "Eliminar"
        Me.Eliminar.UseColumnTextForButtonValue = True
        '
        'DgvDetalle
        '
        Me.DgvDetalle.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvDetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DgvDetalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvDetalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar, Me.Codigo, Me.Descripcion, Me.Cantidad, Me.Precio, Me.Descuento, Me.TotalDescuento, Me.ISV, Me.Total})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvDetalle.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvDetalle.GridColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DgvDetalle.Location = New System.Drawing.Point(12, 181)
        Me.DgvDetalle.MultiSelect = False
        Me.DgvDetalle.Name = "DgvDetalle"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvDetalle.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.DgvDetalle.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvDetalle.Size = New System.Drawing.Size(1338, 301)
        Me.DgvDetalle.TabIndex = 63
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(80, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(224, 39)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "Detalle de Venta"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.INNOVAMASTER.My.Resources.Resources.factur
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(22, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(62, 51)
        Me.PictureBox2.TabIndex = 75
        Me.PictureBox2.TabStop = False
        '
        'LblCant
        '
        Me.LblCant.AutoSize = True
        Me.LblCant.Location = New System.Drawing.Point(1130, 29)
        Me.LblCant.Name = "LblCant"
        Me.LblCant.Size = New System.Drawing.Size(38, 13)
        Me.LblCant.TabIndex = 76
        Me.LblCant.Text = "Label7"
        Me.LblCant.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(1027, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "0"
        Me.Label7.Visible = False
        '
        'LblCambio
        '
        Me.LblCambio.AutoSize = True
        Me.LblCambio.Location = New System.Drawing.Point(1047, 379)
        Me.LblCambio.Name = "LblCambio"
        Me.LblCambio.Size = New System.Drawing.Size(38, 13)
        Me.LblCambio.TabIndex = 80
        Me.LblCambio.Text = "Label9"
        Me.LblCambio.Visible = False
        '
        'LblNombre
        '
        Me.LblNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.Location = New System.Drawing.Point(322, 12)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(0, 23)
        Me.LblNombre.TabIndex = 89
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(850, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 90
        Me.Label10.Text = "Label10"
        Me.Label10.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(590, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 13)
        Me.Label12.TabIndex = 91
        Me.Label12.Text = "Label12"
        Me.Label12.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 19)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "Subtotal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(209, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 19)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "Descuento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(416, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 19)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "Impuesto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(622, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 19)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "Total"
        '
        'TxtSubtotal
        '
        Me.TxtSubtotal.EditValue = "0.00"
        Me.TxtSubtotal.Location = New System.Drawing.Point(8, 22)
        Me.TxtSubtotal.MenuManager = Me.BarManager1
        Me.TxtSubtotal.Name = "TxtSubtotal"
        Me.TxtSubtotal.Properties.ReadOnly = True
        Me.TxtSubtotal.Size = New System.Drawing.Size(165, 20)
        Me.TxtSubtotal.TabIndex = 101
        '
        'TxtDescuento
        '
        Me.TxtDescuento.EditValue = "0.00"
        Me.TxtDescuento.Location = New System.Drawing.Point(213, 22)
        Me.TxtDescuento.MenuManager = Me.BarManager1
        Me.TxtDescuento.Name = "TxtDescuento"
        Me.TxtDescuento.Properties.ReadOnly = True
        Me.TxtDescuento.Size = New System.Drawing.Size(165, 20)
        Me.TxtDescuento.TabIndex = 102
        '
        'TxtImpuesto
        '
        Me.TxtImpuesto.EditValue = "0.00"
        Me.TxtImpuesto.Location = New System.Drawing.Point(420, 22)
        Me.TxtImpuesto.MenuManager = Me.BarManager1
        Me.TxtImpuesto.Name = "TxtImpuesto"
        Me.TxtImpuesto.Properties.ReadOnly = True
        Me.TxtImpuesto.Size = New System.Drawing.Size(165, 20)
        Me.TxtImpuesto.TabIndex = 103
        '
        'TxtTotal
        '
        Me.TxtTotal.EditValue = "0.00"
        Me.TxtTotal.Location = New System.Drawing.Point(626, 22)
        Me.TxtTotal.MenuManager = Me.BarManager1
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Properties.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(165, 20)
        Me.TxtTotal.TabIndex = 104
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.BtnBusqueda)
        Me.PanelControl1.Controls.Add(Me.TxtFechaVencimiento)
        Me.PanelControl1.Controls.Add(Me.TxtFechaVenta)
        Me.PanelControl1.Controls.Add(Me.GroupControl2)
        Me.PanelControl1.Controls.Add(Me.TxtIdVenta)
        Me.PanelControl1.Controls.Add(Me.CboTV)
        Me.PanelControl1.Controls.Add(Me.CboFV)
        Me.PanelControl1.Controls.Add(Me.Label14)
        Me.PanelControl1.Controls.Add(Me.Label15)
        Me.PanelControl1.Controls.Add(Me.Label11)
        Me.PanelControl1.Controls.Add(Me.Label9)
        Me.PanelControl1.Controls.Add(Me.Label8)
        Me.PanelControl1.Controls.Add(Me.Label5)
        Me.PanelControl1.Controls.Add(Me.CboCliente)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 49)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1338, 97)
        Me.PanelControl1.TabIndex = 98
        '
        'BtnBusqueda
        '
        Me.BtnBusqueda.Location = New System.Drawing.Point(319, 66)
        Me.BtnBusqueda.Name = "BtnBusqueda"
        Me.BtnBusqueda.Size = New System.Drawing.Size(30, 23)
        Me.BtnBusqueda.TabIndex = 113
        Me.BtnBusqueda.Text = "..."
        '
        'TxtFechaVencimiento
        '
        Me.TxtFechaVencimiento.EditValue = Nothing
        Me.TxtFechaVencimiento.Location = New System.Drawing.Point(1048, 26)
        Me.TxtFechaVencimiento.MenuManager = Me.BarManager1
        Me.TxtFechaVencimiento.Name = "TxtFechaVencimiento"
        Me.TxtFechaVencimiento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtFechaVencimiento.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtFechaVencimiento.Size = New System.Drawing.Size(285, 20)
        Me.TxtFechaVencimiento.TabIndex = 112
        '
        'TxtFechaVenta
        '
        Me.TxtFechaVenta.Location = New System.Drawing.Point(1048, 64)
        Me.TxtFechaVenta.MenuManager = Me.BarManager1
        Me.TxtFechaVenta.Name = "TxtFechaVenta"
        Me.TxtFechaVenta.Properties.ReadOnly = True
        Me.TxtFechaVenta.Size = New System.Drawing.Size(285, 20)
        Me.TxtFechaVenta.TabIndex = 111
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.TxtP)
        Me.GroupControl2.Controls.Add(Me.TxtDescuentoExtra)
        Me.GroupControl2.Controls.Add(Me.Label13)
        Me.GroupControl2.Controls.Add(Me.RdbCantidad)
        Me.GroupControl2.Controls.Add(Me.RdbPorcentaje)
        Me.GroupControl2.Controls.Add(Me.LblP)
        Me.GroupControl2.Location = New System.Drawing.Point(628, 14)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(410, 74)
        Me.GroupControl2.TabIndex = 110
        Me.GroupControl2.Text = "Descuento"
        '
        'TxtP
        '
        Me.TxtP.EditValue = "0"
        Me.TxtP.Location = New System.Drawing.Point(317, 34)
        Me.TxtP.MenuManager = Me.BarManager1
        Me.TxtP.Name = "TxtP"
        Me.TxtP.Size = New System.Drawing.Size(50, 20)
        Me.TxtP.TabIndex = 46
        '
        'TxtDescuentoExtra
        '
        Me.TxtDescuentoExtra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtDescuentoExtra.Location = New System.Drawing.Point(5, 47)
        Me.TxtDescuentoExtra.Name = "TxtDescuentoExtra"
        Me.TxtDescuentoExtra.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.TxtDescuentoExtra.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescuentoExtra.Properties.Appearance.Options.UseBackColor = True
        Me.TxtDescuentoExtra.Properties.Appearance.Options.UseFont = True
        Me.TxtDescuentoExtra.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtDescuentoExtra.Size = New System.Drawing.Size(179, 22)
        Me.TxtDescuentoExtra.TabIndex = 42
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(5, 25)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(113, 19)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "Descuento Extra"
        '
        'RdbCantidad
        '
        Me.RdbCantidad.AutoSize = True
        Me.RdbCantidad.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbCantidad.Location = New System.Drawing.Point(192, 23)
        Me.RdbCantidad.Name = "RdbCantidad"
        Me.RdbCantidad.Size = New System.Drawing.Size(108, 23)
        Me.RdbCantidad.TabIndex = 43
        Me.RdbCantidad.TabStop = True
        Me.RdbCantidad.Text = "Por Cantidad"
        Me.RdbCantidad.UseVisualStyleBackColor = True
        '
        'RdbPorcentaje
        '
        Me.RdbPorcentaje.AutoSize = True
        Me.RdbPorcentaje.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbPorcentaje.Location = New System.Drawing.Point(192, 46)
        Me.RdbPorcentaje.Name = "RdbPorcentaje"
        Me.RdbPorcentaje.Size = New System.Drawing.Size(119, 23)
        Me.RdbPorcentaje.TabIndex = 44
        Me.RdbPorcentaje.TabStop = True
        Me.RdbPorcentaje.Text = "Por Porcentaje"
        Me.RdbPorcentaje.UseVisualStyleBackColor = True
        '
        'LblP
        '
        Me.LblP.AutoSize = True
        Me.LblP.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblP.Location = New System.Drawing.Point(373, 34)
        Me.LblP.Name = "LblP"
        Me.LblP.Size = New System.Drawing.Size(20, 19)
        Me.LblP.TabIndex = 45
        Me.LblP.Text = "%"
        Me.LblP.Visible = False
        '
        'TxtIdVenta
        '
        Me.TxtIdVenta.Location = New System.Drawing.Point(10, 26)
        Me.TxtIdVenta.MenuManager = Me.BarManager1
        Me.TxtIdVenta.Name = "TxtIdVenta"
        Me.TxtIdVenta.Properties.ReadOnly = True
        Me.TxtIdVenta.Size = New System.Drawing.Size(191, 20)
        Me.TxtIdVenta.TabIndex = 108
        '
        'CboTV
        '
        Me.CboTV.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Hide
        Me.CboTV.DropDownControl = Me.PopupMenu2
        Me.CboTV.Location = New System.Drawing.Point(358, 65)
        Me.CboTV.Name = "CboTV"
        Me.CboTV.Size = New System.Drawing.Size(264, 23)
        Me.CboTV.TabIndex = 107
        Me.CboTV.Text = "Contado"
        '
        'CboFV
        '
        Me.CboFV.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Hide
        Me.CboFV.DropDownControl = Me.PopupMenu1
        Me.CboFV.Location = New System.Drawing.Point(358, 24)
        Me.CboFV.Name = "CboFV"
        Me.CboFV.Size = New System.Drawing.Size(264, 23)
        Me.CboFV.TabIndex = 106
        Me.CboFV.Text = "Unitario"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(352, 44)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(99, 19)
        Me.Label14.TabIndex = 105
        Me.Label14.Text = "Tipo de Venta"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(354, 2)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(110, 19)
        Me.Label15.TabIndex = 104
        Me.Label15.Text = "Forma de Venta"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(1044, 2)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(148, 19)
        Me.Label11.TabIndex = 103
        Me.Label11.Text = "Fecha de Vencimiento"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(1043, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 19)
        Me.Label9.TabIndex = 102
        Me.Label9.Text = "Fecha de Venta"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(10, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 19)
        Me.Label8.TabIndex = 100
        Me.Label8.Text = "Cliente"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 19)
        Me.Label5.TabIndex = 99
        Me.Label5.Text = "Código de la Venta"
        '
        'CboCliente
        '
        Me.CboCliente.EditValue = ""
        Me.CboCliente.Location = New System.Drawing.Point(10, 69)
        Me.CboCliente.MenuManager = Me.BarManager1
        Me.CboCliente.Name = "CboCliente"
        Me.CboCliente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CboCliente.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CboCliente.Properties.DisplayMember = "Nombre_Completo"
        Me.CboCliente.Properties.NullText = "SELECCIONE CLIENTE"
        Me.CboCliente.Properties.ValueMember = "Identidad"
        Me.CboCliente.Properties.View = Me.SearchLookUpEdit1View
        Me.CboCliente.Size = New System.Drawing.Size(303, 20)
        Me.CboCliente.TabIndex = 109
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
        Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
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
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.GridColumn1.AppearanceCell.Options.UseFont = True
        Me.GridColumn1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.GridColumn1.AppearanceHeader.Options.UseFont = True
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "Identidad"
        Me.GridColumn1.FieldName = "Identidad"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Identidad", "Total = {0}")})
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 242
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.GridColumn2.AppearanceCell.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.GridColumn2.AppearanceHeader.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Nombre Completo"
        Me.GridColumn2.FieldName = "Nombre_Completo"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 836
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.TxtTotal)
        Me.PanelControl2.Controls.Add(Me.Label1)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.TxtImpuesto)
        Me.PanelControl2.Controls.Add(Me.Label3)
        Me.PanelControl2.Controls.Add(Me.TxtDescuento)
        Me.PanelControl2.Controls.Add(Me.Label4)
        Me.PanelControl2.Controls.Add(Me.TxtSubtotal)
        Me.PanelControl2.Location = New System.Drawing.Point(12, 485)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(822, 48)
        Me.PanelControl2.TabIndex = 147
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 148)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(41, 31)
        Me.SimpleButton1.TabIndex = 114
        '
        'LblSaberCredito
        '
        Me.LblSaberCredito.AutoSize = True
        Me.LblSaberCredito.Location = New System.Drawing.Point(326, 21)
        Me.LblSaberCredito.Name = "LblSaberCredito"
        Me.LblSaberCredito.Size = New System.Drawing.Size(44, 13)
        Me.LblSaberCredito.TabIndex = 152
        Me.LblSaberCredito.Text = "Label16"
        Me.LblSaberCredito.Visible = False
        '
        'FrmFacturacionVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 563)
        Me.Controls.Add(Me.LblSaberCredito)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.BtnEliminarTodo)
        Me.Controls.Add(Me.BtnFacturar)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.LblCambio)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LblCant)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DgvDetalle)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.HelpButton = True
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TableOfContents)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmFacturacionVenta"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturación de Venta"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSubtotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDescuento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtImpuesto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.TxtFechaVencimiento.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFechaVencimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFechaVenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.TxtP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDescuentoExtra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtIdVenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents PopupMenu2 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents TxtFechaVencimiento As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TxtFechaVenta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TxtP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtDescuentoExtra As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents Label13 As Label
    Friend WithEvents RdbCantidad As RadioButton
    Friend WithEvents RdbPorcentaje As RadioButton
    Friend WithEvents LblP As Label
    Friend WithEvents TxtIdVenta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CboTV As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents CboFV As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CboCliente As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TxtTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtImpuesto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtDescuento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtSubtotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents LblCambio As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LblCant As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DgvDetalle As DataGridView
    Friend WithEvents Eliminar As DataGridViewButtonColumn
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Descuento As DataGridViewTextBoxColumn
    Friend WithEvents TotalDescuento As DataGridViewTextBoxColumn
    Friend WithEvents ISV As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents BtnBusqueda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnEliminarTodo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnFacturar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LblSaberCredito As Label
End Class
