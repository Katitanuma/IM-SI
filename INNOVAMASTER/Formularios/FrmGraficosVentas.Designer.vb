<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGraficosVentas
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
        Dim Series4 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim PieSeriesView3 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
        Dim Series5 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim PieSeriesView4 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
        Dim XyDiagram2 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series6 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGraficosVentas))
        Me.AccordionControl1 = New DevExpress.XtraBars.Navigation.AccordionControl()
        Me.AccordionControlElement1 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement2 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement3 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement4 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement5 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement6 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement7 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement8 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement9 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement10 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement11 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        Me.Sp_Graficos_VentaTableAdapter = New INNOVAMASTER.DsReportesTableAdapters.Sp_Graficos_VentaTableAdapter()
        Me.SpGraficosCompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsReportes = New INNOVAMASTER.DsReportes()
        Me.SpGraficosVentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.Sp_Graficos_CompraTableAdapter = New INNOVAMASTER.DsReportesTableAdapters.Sp_Graficos_CompraTableAdapter()
        Me.ChartControl2 = New DevExpress.XtraCharts.ChartControl()
        Me.ChartControl3 = New DevExpress.XtraCharts.ChartControl()
        Me.SPProductosMasVendidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_Productos_Mas_VendidosTableAdapter = New INNOVAMASTER.DsReportesTableAdapters.SP_Productos_Mas_VendidosTableAdapter()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.PrintableComponentLink2 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.PrintableComponentLink3 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.AccordionControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PieSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGraficosCompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsReportes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGraficosVentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PieSeriesView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPProductosMasVendidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AccordionControl1
        '
        Me.AccordionControl1.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.AccordionControlElement1, Me.AccordionControlElement5, Me.AccordionControlElement9})
        Me.AccordionControl1.Location = New System.Drawing.Point(0, 34)
        Me.AccordionControl1.Name = "AccordionControl1"
        Me.AccordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden
        Me.AccordionControl1.Size = New System.Drawing.Size(212, 454)
        Me.AccordionControl1.TabIndex = 1
        Me.AccordionControl1.Text = "AccordionControl1"
        '
        'AccordionControlElement1
        '
        Me.AccordionControlElement1.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.AccordionControlElement2, Me.AccordionControlElement3, Me.AccordionControlElement4})
        Me.AccordionControlElement1.Expanded = True
        Me.AccordionControlElement1.Name = "AccordionControlElement1"
        Me.AccordionControlElement1.Text = "Venta"
        '
        'AccordionControlElement2
        '
        Me.AccordionControlElement2.Name = "AccordionControlElement2"
        Me.AccordionControlElement2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement2.Text = "Anual"
        '
        'AccordionControlElement3
        '
        Me.AccordionControlElement3.Name = "AccordionControlElement3"
        Me.AccordionControlElement3.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement3.Text = "Trimestral"
        '
        'AccordionControlElement4
        '
        Me.AccordionControlElement4.Name = "AccordionControlElement4"
        Me.AccordionControlElement4.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement4.Text = "Bimestral"
        '
        'AccordionControlElement5
        '
        Me.AccordionControlElement5.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.AccordionControlElement6, Me.AccordionControlElement7, Me.AccordionControlElement8})
        Me.AccordionControlElement5.Expanded = True
        Me.AccordionControlElement5.Name = "AccordionControlElement5"
        Me.AccordionControlElement5.Text = "Compra"
        '
        'AccordionControlElement6
        '
        Me.AccordionControlElement6.Name = "AccordionControlElement6"
        Me.AccordionControlElement6.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement6.Text = "Anual"
        '
        'AccordionControlElement7
        '
        Me.AccordionControlElement7.Name = "AccordionControlElement7"
        Me.AccordionControlElement7.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement7.Text = "Trimestral"
        '
        'AccordionControlElement8
        '
        Me.AccordionControlElement8.Name = "AccordionControlElement8"
        Me.AccordionControlElement8.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement8.Text = "Bimestral"
        '
        'AccordionControlElement9
        '
        Me.AccordionControlElement9.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.AccordionControlElement10, Me.AccordionControlElement11})
        Me.AccordionControlElement9.Expanded = True
        Me.AccordionControlElement9.Name = "AccordionControlElement9"
        Me.AccordionControlElement9.Text = "Productos"
        '
        'AccordionControlElement10
        '
        Me.AccordionControlElement10.Name = "AccordionControlElement10"
        Me.AccordionControlElement10.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement10.Text = "Productos mas vendidos"
        '
        'AccordionControlElement11
        '
        Me.AccordionControlElement11.Name = "AccordionControlElement11"
        Me.AccordionControlElement11.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement11.Text = "Productos menos vendidos"
        '
        'ChartControl1
        '
        Me.ChartControl1.BackColor = System.Drawing.Color.AliceBlue
        Me.ChartControl1.DataAdapter = Me.Sp_Graficos_VentaTableAdapter
        Me.ChartControl1.DataSource = Me.SpGraficosCompraBindingSource
        Me.ChartControl1.Legend.Name = "Default Legend"
        Me.ChartControl1.Location = New System.Drawing.Point(212, -1)
        Me.ChartControl1.Name = "ChartControl1"
        Series4.ArgumentDataMember = "Anio"
        Series4.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series4.LegendTextPattern = "{A}: Lps.{V}"
        Series4.Name = "Total"
        Series4.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.[True]
        Series4.ToolTipPointPattern = "{A}: Lps.{V}"
        Series4.ValueDataMembersSerializable = "Total"
        Series4.View = PieSeriesView3
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series4}
        Me.ChartControl1.Size = New System.Drawing.Size(669, 488)
        Me.ChartControl1.TabIndex = 2
        '
        'Sp_Graficos_VentaTableAdapter
        '
        Me.Sp_Graficos_VentaTableAdapter.ClearBeforeFill = True
        '
        'SpGraficosCompraBindingSource
        '
        Me.SpGraficosCompraBindingSource.DataMember = "Sp_Graficos_Compra"
        Me.SpGraficosCompraBindingSource.DataSource = Me.DsReportes
        '
        'DsReportes
        '
        Me.DsReportes.DataSetName = "DsReportes"
        Me.DsReportes.EnforceConstraints = False
        Me.DsReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SpGraficosVentaBindingSource
        '
        Me.SpGraficosVentaBindingSource.DataMember = "Sp_Graficos_Venta"
        Me.SpGraficosVentaBindingSource.DataSource = Me.DsReportes
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(0, 8)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.NullText = "FECHA"
        Me.DateEdit1.Size = New System.Drawing.Size(212, 20)
        Me.DateEdit1.TabIndex = 3
        '
        'Sp_Graficos_CompraTableAdapter
        '
        Me.Sp_Graficos_CompraTableAdapter.ClearBeforeFill = True
        '
        'ChartControl2
        '
        Me.ChartControl2.BackColor = System.Drawing.Color.AliceBlue
        Me.ChartControl2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ChartControl2.DataAdapter = Me.Sp_Graficos_VentaTableAdapter
        Me.ChartControl2.DataSource = Me.SpGraficosVentaBindingSource
        Me.ChartControl2.Legend.Name = "Default Legend"
        Me.ChartControl2.Location = New System.Drawing.Point(212, 0)
        Me.ChartControl2.Name = "ChartControl2"
        Series5.ArgumentDataMember = "Anio1"
        Series5.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series5.LegendTextPattern = "{A}: Lps.{V}"
        Series5.Name = "Total"
        Series5.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.[True]
        Series5.ToolTipPointPattern = "{A}: Lps.{V}"
        Series5.ValueDataMembersSerializable = "Total"
        Series5.View = PieSeriesView4
        Me.ChartControl2.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series5}
        Me.ChartControl2.Size = New System.Drawing.Size(669, 488)
        Me.ChartControl2.TabIndex = 4
        '
        'ChartControl3
        '
        Me.ChartControl3.BackColor = System.Drawing.Color.AliceBlue
        Me.ChartControl3.DataAdapter = Me.Sp_Graficos_VentaTableAdapter
        Me.ChartControl3.DataSource = Me.SPProductosMasVendidosBindingSource
        XyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram2.AxisY.Interlaced = True
        XyDiagram2.AxisY.MinorCount = 4
        XyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartControl3.Diagram = XyDiagram2
        Me.ChartControl3.Legend.Name = "Default Legend"
        Me.ChartControl3.Location = New System.Drawing.Point(212, 0)
        Me.ChartControl3.Name = "ChartControl3"
        Series6.ArgumentDataMember = "Descripcion"
        Series6.ColorDataMember = "Cantidad Vendido"
        Series6.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series6.Name = "Cantidad"
        Series6.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.[True]
        Series6.ValueDataMembersSerializable = "Cantidad Vendido"
        Me.ChartControl3.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series6}
        Me.ChartControl3.Size = New System.Drawing.Size(669, 488)
        Me.ChartControl3.TabIndex = 5
        '
        'SPProductosMasVendidosBindingSource
        '
        Me.SPProductosMasVendidosBindingSource.DataMember = "SP_Productos_Mas_Vendidos"
        Me.SPProductosMasVendidosBindingSource.DataSource = Me.DsReportes
        '
        'SP_Productos_Mas_VendidosTableAdapter
        '
        Me.SP_Productos_Mas_VendidosTableAdapter.ClearBeforeFill = True
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(7, 443)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(199, 37)
        Me.SimpleButton1.TabIndex = 6
        Me.SimpleButton1.Text = "Vista Previa"
        '
        'PrintingSystem1
        '
        Me.PrintingSystem1.Links.AddRange(New Object() {Me.PrintableComponentLink1, Me.PrintableComponentLink2, Me.PrintableComponentLink3})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.ChartControl1
        Me.PrintableComponentLink1.Landscape = True
        Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
        Me.PrintableComponentLink1.RtfReportHeader = resources.GetString("PrintableComponentLink1.RtfReportHeader")
        '
        'PrintableComponentLink2
        '
        Me.PrintableComponentLink2.Component = Me.ChartControl2
        Me.PrintableComponentLink2.Landscape = True
        Me.PrintableComponentLink2.PrintingSystemBase = Me.PrintingSystem1
        Me.PrintableComponentLink2.RtfReportHeader = resources.GetString("PrintableComponentLink2.RtfReportHeader")
        '
        'PrintableComponentLink3
        '
        Me.PrintableComponentLink3.Component = Me.ChartControl3
        Me.PrintableComponentLink3.Landscape = True
        Me.PrintableComponentLink3.PrintingSystemBase = Me.PrintingSystem1
        Me.PrintableComponentLink3.RtfReportHeader = resources.GetString("PrintableComponentLink3.RtfReportHeader")
        '
        'FrmGraficosVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 487)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.DateEdit1)
        Me.Controls.Add(Me.AccordionControl1)
        Me.Controls.Add(Me.ChartControl2)
        Me.Controls.Add(Me.ChartControl1)
        Me.Controls.Add(Me.ChartControl3)
        Me.Name = "FrmGraficosVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Graficos Ventas"
        CType(Me.AccordionControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PieSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGraficosCompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsReportes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGraficosVentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PieSeriesView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPProductosMasVendidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AccordionControl1 As DevExpress.XtraBars.Navigation.AccordionControl
    Friend WithEvents AccordionControlElement1 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement2 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement3 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement4 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement5 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement6 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement7 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement8 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement9 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement10 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement11 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents Sp_Graficos_VentaTableAdapter As DsReportesTableAdapters.Sp_Graficos_VentaTableAdapter
    Friend WithEvents SpGraficosVentaBindingSource As BindingSource
    Friend WithEvents DsReportes As DsReportes
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SpGraficosCompraBindingSource As BindingSource
    Friend WithEvents Sp_Graficos_CompraTableAdapter As DsReportesTableAdapters.Sp_Graficos_CompraTableAdapter
    Friend WithEvents ChartControl2 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents ChartControl3 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents SPProductosMasVendidosBindingSource As BindingSource
    Friend WithEvents SP_Productos_Mas_VendidosTableAdapter As DsReportesTableAdapters.SP_Productos_Mas_VendidosTableAdapter
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents PrintableComponentLink2 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents PrintableComponentLink3 As DevExpress.XtraPrinting.PrintableComponentLink
End Class
