<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCompras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCompras))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.LblCambio = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.Descuento = New DevExpress.XtraEditors.LabelControl()
        Me.TxtDescuentoExtra = New DevExpress.XtraEditors.CalcEdit()
        Me.LblP = New DevExpress.XtraEditors.LabelControl()
        Me.TxtP = New DevExpress.XtraEditors.TextEdit()
        Me.RdbPorcentaje = New System.Windows.Forms.RadioButton()
        Me.RdbCantidad = New System.Windows.Forms.RadioButton()
        Me.LblId = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Button2 = New DevExpress.XtraEditors.SimpleButton()
        Me.Button1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.CboPedido = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtFechaCompra = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtSubtotal = New DevExpress.XtraEditors.TextEdit()
        Me.TxtDescuento = New DevExpress.XtraEditors.TextEdit()
        Me.TxtImpuesto = New DevExpress.XtraEditors.TextEdit()
        Me.TxtTotal = New DevExpress.XtraEditors.TextEdit()
        Me.BtnFacturar = New DevExpress.XtraEditors.SimpleButton()
        Me.DgvDetalle = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ISV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.TxtDescuentoExtra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.CboPedido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFechaCompra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSubtotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDescuento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtImpuesto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblNombre
        '
        Me.LblNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.Location = New System.Drawing.Point(312, -2)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(0, 23)
        Me.LblNombre.TabIndex = 110
        '
        'LblCambio
        '
        Me.LblCambio.AutoSize = True
        Me.LblCambio.Location = New System.Drawing.Point(1304, 482)
        Me.LblCambio.Name = "LblCambio"
        Me.LblCambio.Size = New System.Drawing.Size(38, 13)
        Me.LblCambio.TabIndex = 109
        Me.LblCambio.Text = "Label9"
        Me.LblCambio.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.INNOVAMASTER.My.Resources.Resources.f15039a22a397b8d72599899f10c9cbd
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(12, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(62, 51)
        Me.PictureBox2.TabIndex = 104
        Me.PictureBox2.TabStop = False
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.Descuento)
        Me.GroupControl1.Controls.Add(Me.TxtDescuentoExtra)
        Me.GroupControl1.Controls.Add(Me.LblP)
        Me.GroupControl1.Controls.Add(Me.TxtP)
        Me.GroupControl1.Controls.Add(Me.RdbPorcentaje)
        Me.GroupControl1.Controls.Add(Me.RdbCantidad)
        Me.GroupControl1.Location = New System.Drawing.Point(5, 5)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(532, 73)
        Me.GroupControl1.TabIndex = 83
        '
        'Descuento
        '
        Me.Descuento.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Descuento.Location = New System.Drawing.Point(16, 19)
        Me.Descuento.Name = "Descuento"
        Me.Descuento.Size = New System.Drawing.Size(63, 19)
        Me.Descuento.TabIndex = 40
        Me.Descuento.Text = "Descuento"
        '
        'TxtDescuentoExtra
        '
        Me.TxtDescuentoExtra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtDescuentoExtra.Location = New System.Drawing.Point(16, 38)
        Me.TxtDescuentoExtra.Name = "TxtDescuentoExtra"
        Me.TxtDescuentoExtra.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.TxtDescuentoExtra.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescuentoExtra.Properties.Appearance.Options.UseBackColor = True
        Me.TxtDescuentoExtra.Properties.Appearance.Options.UseFont = True
        Me.TxtDescuentoExtra.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtDescuentoExtra.Size = New System.Drawing.Size(179, 22)
        Me.TxtDescuentoExtra.TabIndex = 35
        '
        'LblP
        '
        Me.LblP.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LblP.Location = New System.Drawing.Point(497, 38)
        Me.LblP.Name = "LblP"
        Me.LblP.Size = New System.Drawing.Size(12, 19)
        Me.LblP.TabIndex = 39
        Me.LblP.Text = "%"
        Me.LblP.Visible = False
        '
        'TxtP
        '
        Me.TxtP.Location = New System.Drawing.Point(448, 38)
        Me.TxtP.Name = "TxtP"
        Me.TxtP.Size = New System.Drawing.Size(43, 20)
        Me.TxtP.TabIndex = 38
        Me.TxtP.Visible = False
        '
        'RdbPorcentaje
        '
        Me.RdbPorcentaje.AutoSize = True
        Me.RdbPorcentaje.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbPorcentaje.Location = New System.Drawing.Point(324, 36)
        Me.RdbPorcentaje.Name = "RdbPorcentaje"
        Me.RdbPorcentaje.Size = New System.Drawing.Size(119, 23)
        Me.RdbPorcentaje.TabIndex = 37
        Me.RdbPorcentaje.Text = "Por Porcentaje"
        Me.RdbPorcentaje.UseVisualStyleBackColor = True
        '
        'RdbCantidad
        '
        Me.RdbCantidad.AutoSize = True
        Me.RdbCantidad.Checked = True
        Me.RdbCantidad.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbCantidad.Location = New System.Drawing.Point(211, 36)
        Me.RdbCantidad.Name = "RdbCantidad"
        Me.RdbCantidad.Size = New System.Drawing.Size(108, 23)
        Me.RdbCantidad.TabIndex = 36
        Me.RdbCantidad.TabStop = True
        Me.RdbCantidad.Text = "Por Cantidad"
        Me.RdbCantidad.UseVisualStyleBackColor = True
        '
        'LblId
        '
        Me.LblId.AutoSize = True
        Me.LblId.Location = New System.Drawing.Point(418, 26)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(38, 13)
        Me.LblId.TabIndex = 111
        Me.LblId.Text = "Label5"
        Me.LblId.Visible = False
        '
        'Button2
        '
        Me.Button2.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Appearance.Options.UseFont = True
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(992, 481)
        Me.Button2.Name = "Button2"
        Me.HelpProvider1.SetShowHelp(Me.Button2, True)
        Me.Button2.Size = New System.Drawing.Size(167, 44)
        Me.Button2.TabIndex = 141
        Me.Button2.Text = "&Eliminar Todos"
        '
        'Button1
        '
        Me.Button1.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Appearance.Options.UseFont = True
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(1162, 481)
        Me.Button1.Name = "Button1"
        Me.HelpProvider1.SetShowHelp(Me.Button1, True)
        Me.Button1.Size = New System.Drawing.Size(167, 44)
        Me.Button1.TabIndex = 142
        Me.Button1.Text = "&Cancelar"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.CboPedido)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.TxtFechaCompra)
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Location = New System.Drawing.Point(10, 62)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1294, 83)
        Me.PanelControl1.TabIndex = 112
        '
        'CboPedido
        '
        Me.CboPedido.Location = New System.Drawing.Point(543, 49)
        Me.CboPedido.Name = "CboPedido"
        Me.CboPedido.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CboPedido.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdPedido", 10, "ID"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Proveedor", 30, "Proveedor"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Fecha", "Fecha")})
        Me.CboPedido.Properties.DisplayMember = "Proveedor"
        Me.CboPedido.Properties.NullText = "Seleccione Pedido"
        Me.CboPedido.Properties.ValueMember = "IdPedido"
        Me.CboPedido.Size = New System.Drawing.Size(399, 20)
        Me.CboPedido.TabIndex = 153
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Location = New System.Drawing.Point(545, 0)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(109, 19)
        Me.LabelControl2.TabIndex = 85
        Me.LabelControl2.Text = "Fecha de Compra"
        '
        'TxtFechaCompra
        '
        Me.TxtFechaCompra.Location = New System.Drawing.Point(543, 23)
        Me.TxtFechaCompra.Name = "TxtFechaCompra"
        Me.TxtFechaCompra.Size = New System.Drawing.Size(155, 20)
        Me.TxtFechaCompra.TabIndex = 84
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Location = New System.Drawing.Point(13, 482)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(54, 19)
        Me.LabelControl1.TabIndex = 41
        Me.LabelControl1.Text = "Subtotal"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Location = New System.Drawing.Point(219, 484)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(63, 19)
        Me.LabelControl3.TabIndex = 113
        Me.LabelControl3.Text = "Descuento"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl4.Location = New System.Drawing.Point(427, 482)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(57, 19)
        Me.LabelControl4.TabIndex = 114
        Me.LabelControl4.Text = "Impuesto"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl5.Location = New System.Drawing.Point(631, 482)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(33, 19)
        Me.LabelControl5.TabIndex = 115
        Me.LabelControl5.Text = "Total"
        '
        'TxtSubtotal
        '
        Me.TxtSubtotal.EditValue = "0.00"
        Me.TxtSubtotal.Location = New System.Drawing.Point(12, 505)
        Me.TxtSubtotal.Name = "TxtSubtotal"
        Me.TxtSubtotal.Properties.Appearance.Options.UseTextOptions = True
        Me.TxtSubtotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TxtSubtotal.Size = New System.Drawing.Size(164, 20)
        Me.TxtSubtotal.TabIndex = 116
        '
        'TxtDescuento
        '
        Me.TxtDescuento.EditValue = "0.00"
        Me.TxtDescuento.Location = New System.Drawing.Point(219, 504)
        Me.TxtDescuento.Name = "TxtDescuento"
        Me.TxtDescuento.Properties.Appearance.Options.UseTextOptions = True
        Me.TxtDescuento.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TxtDescuento.Size = New System.Drawing.Size(164, 20)
        Me.TxtDescuento.TabIndex = 117
        '
        'TxtImpuesto
        '
        Me.TxtImpuesto.EditValue = "0.00"
        Me.TxtImpuesto.Location = New System.Drawing.Point(421, 504)
        Me.TxtImpuesto.Name = "TxtImpuesto"
        Me.TxtImpuesto.Properties.Appearance.Options.UseTextOptions = True
        Me.TxtImpuesto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TxtImpuesto.Size = New System.Drawing.Size(164, 20)
        Me.TxtImpuesto.TabIndex = 118
        '
        'TxtTotal
        '
        Me.TxtTotal.EditValue = "0.00"
        Me.TxtTotal.Location = New System.Drawing.Point(622, 504)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.TxtTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TxtTotal.Size = New System.Drawing.Size(162, 20)
        Me.TxtTotal.TabIndex = 119
        '
        'BtnFacturar
        '
        Me.BtnFacturar.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.BtnFacturar.Appearance.Options.UseFont = True
        Me.BtnFacturar.Image = CType(resources.GetObject("BtnFacturar.Image"), System.Drawing.Image)
        Me.BtnFacturar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.BtnFacturar.Location = New System.Drawing.Point(819, 481)
        Me.BtnFacturar.Name = "BtnFacturar"
        Me.BtnFacturar.Size = New System.Drawing.Size(167, 44)
        Me.BtnFacturar.TabIndex = 120
        Me.BtnFacturar.Text = "&Guardar"
        '
        'DgvDetalle
        '
        Me.DgvDetalle.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvDetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DgvDetalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvDetalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar, Me.Codigo, Me.Descripcion, Me.Cantidad, Me.Precio, Me.ISV, Me.Total})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvDetalle.DefaultCellStyle = DataGridViewCellStyle6
        Me.DgvDetalle.GridColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DgvDetalle.Location = New System.Drawing.Point(10, 151)
        Me.DgvDetalle.MultiSelect = False
        Me.DgvDetalle.Name = "DgvDetalle"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvDetalle.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        Me.DgvDetalle.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DgvDetalle.Size = New System.Drawing.Size(1338, 327)
        Me.DgvDetalle.TabIndex = 143
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
        'Codigo
        '
        Me.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Codigo.Frozen = True
        Me.Codigo.HeaderText = "Código"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Width = 163
        '
        'Descripcion
        '
        Me.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Descripcion.Frozen = True
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Width = 230
        '
        'Cantidad
        '
        Me.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Width = 75
        '
        'Precio
        '
        Me.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Precio.HeaderText = "Costo"
        Me.Precio.Name = "Precio"
        '
        'ISV
        '
        Me.ISV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ISV.HeaderText = "ISV"
        Me.ISV.Name = "ISV"
        Me.ISV.ReadOnly = True
        '
        'Total
        '
        Me.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.LabelControl6.Location = New System.Drawing.Point(75, 10)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(281, 43)
        Me.LabelControl6.TabIndex = 151
        Me.LabelControl6.Text = "Compra de Productos"
        '
        'FrmCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 553)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.DgvDetalle)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnFacturar)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.TxtImpuesto)
        Me.Controls.Add(Me.TxtDescuento)
        Me.Controls.Add(Me.TxtSubtotal)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.LblId)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.LblCambio)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TableOfContents)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCompras"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "Compras"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.TxtDescuentoExtra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.CboPedido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFechaCompra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSubtotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDescuento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtImpuesto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblNombre As Label
    Friend WithEvents LblCambio As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TxtDescuentoExtra As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents RdbCantidad As RadioButton
    Friend WithEvents RdbPorcentaje As RadioButton
    Friend WithEvents LblId As Label
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Descuento As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblP As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtFechaCompra As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtSubtotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtDescuento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtImpuesto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BtnFacturar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DgvDetalle As DataGridView
    Friend WithEvents Eliminar As DataGridViewButtonColumn
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents ISV As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CboPedido As DevExpress.XtraEditors.LookUpEdit
End Class
