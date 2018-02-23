<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPExistencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPExistencia))
        Me.GCPrincipal = New DevExpress.XtraGrid.GridControl()
        Me.DgvProducto = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DigitalBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
        Me.DigitalBackgroundLayerComponent2 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
        Me.GaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl()
        Me.DigitalGauge1 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge()
        Me.DigitalBackgroundLayerComponent3 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
        Me.BtnActualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnExportarPDF = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnExportarExcel = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GCPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalBackgroundLayerComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalBackgroundLayerComponent3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GCPrincipal
        '
        Me.GCPrincipal.Location = New System.Drawing.Point(12, 84)
        Me.GCPrincipal.MainView = Me.DgvProducto
        Me.GCPrincipal.Name = "GCPrincipal"
        Me.GCPrincipal.Size = New System.Drawing.Size(849, 265)
        Me.GCPrincipal.TabIndex = 140
        Me.GCPrincipal.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DgvProducto})
        '
        'DgvProducto
        '
        Me.DgvProducto.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvProducto.Appearance.Empty.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvProducto.Appearance.Empty.Options.UseBackColor = True
        Me.DgvProducto.Appearance.FocusedCell.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvProducto.Appearance.FocusedCell.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvProducto.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.DgvProducto.Appearance.FocusedCell.Options.UseBackColor = True
        Me.DgvProducto.Appearance.FocusedCell.Options.UseFont = True
        Me.DgvProducto.Appearance.FocusedCell.Options.UseForeColor = True
        Me.DgvProducto.Appearance.FocusedRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvProducto.Appearance.FocusedRow.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvProducto.Appearance.FocusedRow.Options.UseBackColor = True
        Me.DgvProducto.Appearance.FocusedRow.Options.UseFont = True
        Me.DgvProducto.Appearance.FooterPanel.Options.UseTextOptions = True
        Me.DgvProducto.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.DgvProducto.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvProducto.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvProducto.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White
        Me.DgvProducto.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.DgvProducto.Appearance.HideSelectionRow.Options.UseFont = True
        Me.DgvProducto.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.DgvProducto.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DgvProducto.Appearance.HorzLine.Options.UseBackColor = True
        Me.DgvProducto.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvProducto.Appearance.Row.Options.UseBackColor = True
        Me.DgvProducto.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvProducto.Appearance.RowSeparator.Options.UseBackColor = True
        Me.DgvProducto.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DgvProducto.Appearance.VertLine.Options.UseBackColor = True
        Me.DgvProducto.ColumnPanelRowHeight = 26
        Me.DgvProducto.GridControl = Me.GCPrincipal
        Me.DgvProducto.Name = "DgvProducto"
        Me.DgvProducto.OptionsBehavior.AllowIncrementalSearch = True
        Me.DgvProducto.OptionsBehavior.AutoSelectAllInEditor = False
        Me.DgvProducto.OptionsBehavior.Editable = False
        Me.DgvProducto.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.DgvProducto.OptionsFind.AlwaysVisible = True
        Me.DgvProducto.OptionsFind.FindNullPrompt = "Introduzca municipio a buscar..."
        Me.DgvProducto.OptionsView.EnableAppearanceEvenRow = True
        Me.DgvProducto.OptionsView.EnableAppearanceOddRow = True
        Me.DgvProducto.OptionsView.ShowGroupPanel = False
        Me.DgvProducto.RowHeight = 22
        '
        'DigitalBackgroundLayerComponent1
        '
        Me.DigitalBackgroundLayerComponent1.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(265.8125!, 99.9625!)
        Me.DigitalBackgroundLayerComponent1.Name = "digitalBackgroundLayerComponent1"
        Me.DigitalBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style17
        Me.DigitalBackgroundLayerComponent1.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(26.0!, 0!)
        Me.DigitalBackgroundLayerComponent1.ZOrder = 1000
        '
        'DigitalBackgroundLayerComponent2
        '
        Me.DigitalBackgroundLayerComponent2.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(265.8125!, 99.9625!)
        Me.DigitalBackgroundLayerComponent2.Name = "digitalBackgroundLayerComponent1"
        Me.DigitalBackgroundLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style17
        Me.DigitalBackgroundLayerComponent2.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(26.0!, 0!)
        Me.DigitalBackgroundLayerComponent2.ZOrder = 1000
        '
        'GaugeControl1
        '
        Me.GaugeControl1.BackColor = System.Drawing.Color.Transparent
        Me.GaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.DigitalGauge1})
        Me.GaugeControl1.Location = New System.Drawing.Point(81, 12)
        Me.GaugeControl1.Name = "GaugeControl1"
        Me.GaugeControl1.Size = New System.Drawing.Size(710, 65)
        Me.GaugeControl1.TabIndex = 142
        '
        'DigitalGauge1
        '
        Me.DigitalGauge1.AppearanceOff.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#0D8097")
        Me.DigitalGauge1.AppearanceOn.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#02F0F7")
        Me.DigitalGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent() {Me.DigitalBackgroundLayerComponent3})
        Me.DigitalGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 698, 53)
        Me.DigitalGauge1.DigitCount = 25
        Me.DigitalGauge1.Name = "DigitalGauge1"
        Me.DigitalGauge1.Padding = New DevExpress.XtraGauges.Core.Base.TextSpacing(26, 20, 26, 20)
        Me.DigitalGauge1.Text = "PRODUCTOS BAJO EXISTENCIA"
        '
        'DigitalBackgroundLayerComponent3
        '
        Me.DigitalBackgroundLayerComponent3.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(1225.063!, 99.9625!)
        Me.DigitalBackgroundLayerComponent3.Name = "digitalBackgroundLayerComponent1"
        Me.DigitalBackgroundLayerComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style17
        Me.DigitalBackgroundLayerComponent3.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(26.0!, 0!)
        Me.DigitalBackgroundLayerComponent3.ZOrder = 1000
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Image = CType(resources.GetObject("BtnActualizar.Image"), System.Drawing.Image)
        Me.BtnActualizar.Location = New System.Drawing.Point(97, 368)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(165, 45)
        Me.BtnActualizar.TabIndex = 145
        Me.BtnActualizar.Text = "Actualizar Datos"
        '
        'BtnExportarPDF
        '
        Me.BtnExportarPDF.Image = CType(resources.GetObject("BtnExportarPDF.Image"), System.Drawing.Image)
        Me.BtnExportarPDF.Location = New System.Drawing.Point(268, 368)
        Me.BtnExportarPDF.Name = "BtnExportarPDF"
        Me.BtnExportarPDF.Size = New System.Drawing.Size(165, 45)
        Me.BtnExportarPDF.TabIndex = 144
        Me.BtnExportarPDF.Text = "Exportar PDF"
        '
        'BtnExportarExcel
        '
        Me.BtnExportarExcel.Image = CType(resources.GetObject("BtnExportarExcel.Image"), System.Drawing.Image)
        Me.BtnExportarExcel.Location = New System.Drawing.Point(439, 368)
        Me.BtnExportarExcel.Name = "BtnExportarExcel"
        Me.BtnExportarExcel.Size = New System.Drawing.Size(165, 45)
        Me.BtnExportarExcel.TabIndex = 143
        Me.BtnExportarExcel.Text = "Exportar Excel"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(610, 368)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(165, 45)
        Me.SimpleButton1.TabIndex = 146
        Me.SimpleButton1.Text = "Vista Previa"
        '
        'FrmPExistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 425)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnExportarPDF)
        Me.Controls.Add(Me.BtnExportarExcel)
        Me.Controls.Add(Me.GaugeControl1)
        Me.Controls.Add(Me.GCPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPExistencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos Baja Existencia"
        CType(Me.GCPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalBackgroundLayerComponent2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalGauge1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalBackgroundLayerComponent3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GCPrincipal As DevExpress.XtraGrid.GridControl
    Friend WithEvents DgvProducto As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents DigitalBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
    Private WithEvents DigitalBackgroundLayerComponent2 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
    Friend WithEvents GaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl
    Friend WithEvents DigitalGauge1 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge
    Private WithEvents DigitalBackgroundLayerComponent3 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
    Friend WithEvents BtnActualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnExportarPDF As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnExportarExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
