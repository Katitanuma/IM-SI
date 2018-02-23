<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPedidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPedidos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.LblCambio = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LblId = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Button1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Button2 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtFechaPedido = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.CboProveedor = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtSubtotal = New DevExpress.XtraEditors.TextEdit()
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
        Me.ChIdProductoProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.TxtFechaPedido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.CboProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSubtotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LblNombre.Location = New System.Drawing.Point(315, -5)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(0, 23)
        Me.LblNombre.TabIndex = 127
        '
        'LblCambio
        '
        Me.LblCambio.AutoSize = True
        Me.LblCambio.Location = New System.Drawing.Point(1018, 496)
        Me.LblCambio.Name = "LblCambio"
        Me.LblCambio.Size = New System.Drawing.Size(38, 13)
        Me.LblCambio.TabIndex = 126
        Me.LblCambio.Text = "Label9"
        Me.LblCambio.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(387, 485)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 19)
        Me.Label4.TabIndex = 118
        Me.Label4.Text = "Total"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(199, 485)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 19)
        Me.Label3.TabIndex = 116
        Me.Label3.Text = "Impuesto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 487)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 19)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "Subtotal"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.INNOVAMASTER.My.Resources.Resources.ef469d7feb7cd58c486a7d18c52245e7
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(15, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(62, 51)
        Me.PictureBox2.TabIndex = 123
        Me.PictureBox2.TabStop = False
        '
        'LblId
        '
        Me.LblId.AutoSize = True
        Me.LblId.Location = New System.Drawing.Point(394, 22)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(38, 13)
        Me.LblId.TabIndex = 128
        Me.LblId.Text = "Label2"
        Me.LblId.Visible = False
        '
        'Button1
        '
        Me.Button1.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Appearance.Options.UseFont = True
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(1150, 477)
        Me.Button1.Name = "Button1"
        Me.HelpProvider1.SetShowHelp(Me.Button1, True)
        Me.Button1.Size = New System.Drawing.Size(167, 49)
        Me.Button1.TabIndex = 145
        Me.Button1.Text = "&Cancelar"
        '
        'Button2
        '
        Me.Button2.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Appearance.Options.UseFont = True
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(980, 477)
        Me.Button2.Name = "Button2"
        Me.HelpProvider1.SetShowHelp(Me.Button2, True)
        Me.Button2.Size = New System.Drawing.Size(167, 49)
        Me.Button2.TabIndex = 144
        Me.Button2.Text = "&Eliminar Todos"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.TxtFechaPedido)
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Location = New System.Drawing.Point(15, 61)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1327, 90)
        Me.PanelControl1.TabIndex = 129
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Location = New System.Drawing.Point(549, 20)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(105, 19)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Fecha de Pedido"
        '
        'TxtFechaPedido
        '
        Me.TxtFechaPedido.Location = New System.Drawing.Point(528, 45)
        Me.TxtFechaPedido.Name = "TxtFechaPedido"
        Me.TxtFechaPedido.Size = New System.Drawing.Size(151, 20)
        Me.TxtFechaPedido.TabIndex = 1
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.CboProveedor)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(5, 11)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(513, 70)
        Me.GroupControl1.TabIndex = 0
        '
        'CboProveedor
        '
        Me.CboProveedor.Location = New System.Drawing.Point(10, 42)
        Me.CboProveedor.Name = "CboProveedor"
        Me.CboProveedor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CboProveedor.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdProveedor", "ID"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Proveedor")})
        Me.CboProveedor.Properties.DisplayMember = "Nombre"
        Me.CboProveedor.Properties.NullText = "Seleccione Proveedor"
        Me.CboProveedor.Properties.ValueMember = "IdProveedor"
        Me.CboProveedor.Size = New System.Drawing.Size(399, 20)
        Me.CboProveedor.TabIndex = 152
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Location = New System.Drawing.Point(10, 16)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(61, 19)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Proveedor"
        '
        'TxtSubtotal
        '
        Me.TxtSubtotal.EditValue = "0.00"
        Me.TxtSubtotal.Location = New System.Drawing.Point(12, 507)
        Me.TxtSubtotal.Name = "TxtSubtotal"
        Me.TxtSubtotal.Properties.Appearance.Options.UseTextOptions = True
        Me.TxtSubtotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TxtSubtotal.Size = New System.Drawing.Size(163, 20)
        Me.TxtSubtotal.TabIndex = 130
        '
        'TxtImpuesto
        '
        Me.TxtImpuesto.EditValue = "0.00"
        Me.TxtImpuesto.Location = New System.Drawing.Point(198, 506)
        Me.TxtImpuesto.Name = "TxtImpuesto"
        Me.TxtImpuesto.Properties.Appearance.Options.UseTextOptions = True
        Me.TxtImpuesto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TxtImpuesto.Size = New System.Drawing.Size(164, 20)
        Me.TxtImpuesto.TabIndex = 131
        '
        'TxtTotal
        '
        Me.TxtTotal.EditValue = "0.00"
        Me.TxtTotal.Location = New System.Drawing.Point(391, 506)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.TxtTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TxtTotal.Size = New System.Drawing.Size(164, 20)
        Me.TxtTotal.TabIndex = 132
        '
        'BtnFacturar
        '
        Me.BtnFacturar.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.BtnFacturar.Appearance.Options.UseFont = True
        Me.BtnFacturar.Image = CType(resources.GetObject("BtnFacturar.Image"), System.Drawing.Image)
        Me.BtnFacturar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.BtnFacturar.Location = New System.Drawing.Point(807, 477)
        Me.BtnFacturar.Name = "BtnFacturar"
        Me.BtnFacturar.Size = New System.Drawing.Size(167, 49)
        Me.BtnFacturar.TabIndex = 143
        Me.BtnFacturar.Text = "&Pedir"
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
        Me.DgvDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar, Me.Codigo, Me.Descripcion, Me.Cantidad, Me.Precio, Me.ISV, Me.Total, Me.ChIdProductoProveedor})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvDetalle.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvDetalle.GridColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DgvDetalle.Location = New System.Drawing.Point(14, 158)
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
        Me.DgvDetalle.Size = New System.Drawing.Size(1328, 314)
        Me.DgvDetalle.TabIndex = 147
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
        Me.Cantidad.Frozen = True
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Width = 75
        '
        'Precio
        '
        Me.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Precio.Frozen = True
        Me.Precio.HeaderText = "Costo"
        Me.Precio.MinimumWidth = 212
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        Me.Precio.Width = 212
        '
        'ISV
        '
        Me.ISV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ISV.Frozen = True
        Me.ISV.HeaderText = "ISV"
        Me.ISV.Name = "ISV"
        Me.ISV.ReadOnly = True
        Me.ISV.Width = 130
        '
        'Total
        '
        Me.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Total.Frozen = True
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 130
        '
        'ChIdProductoProveedor
        '
        Me.ChIdProductoProveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ChIdProductoProveedor.HeaderText = "Código Producto Proveedor"
        Me.ChIdProductoProveedor.MinimumWidth = 212
        Me.ChIdProductoProveedor.Name = "ChIdProductoProveedor"
        Me.ChIdProductoProveedor.ReadOnly = True
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.LabelControl3.Location = New System.Drawing.Point(83, 6)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(270, 43)
        Me.LabelControl3.TabIndex = 151
        Me.LabelControl3.Text = "Pedido de Productos"
        '
        'FrmPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 549)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.DgvDetalle)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnFacturar)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.TxtImpuesto)
        Me.Controls.Add(Me.TxtSubtotal)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.LblId)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.LblCambio)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TableOfContents)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPedidos"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "Pedidos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.TxtFechaPedido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.CboProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSubtotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtImpuesto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblNombre As Label
    Friend WithEvents LblCambio As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LblId As Label
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtFechaPedido As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtSubtotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtImpuesto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Button1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnFacturar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DgvDetalle As DataGridView
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CboProveedor As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Eliminar As DataGridViewButtonColumn
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents ISV As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents ChIdProductoProveedor As DataGridViewTextBoxColumn
End Class
