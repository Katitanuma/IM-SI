Public Class FrmGraficosVentas
    Dim i As Integer = 0
    Private Sub AccordionControlElement2_Click(sender As Object, e As EventArgs) Handles AccordionControlElement2.Click
        Sp_Graficos_VentaTableAdapter.Fill(DsReportes.Sp_Graficos_Venta, 0, 1)
        ChartControl1.SendToBack()
        ChartControl3.SendToBack()
        i = 1
    End Sub

    Private Sub AccordionControlElement3_Click(sender As Object, e As EventArgs) Handles AccordionControlElement3.Click
        Sp_Graficos_VentaTableAdapter.Fill(DsReportes.Sp_Graficos_Venta, DateEdit1.DateTime.Year, 2)
        ChartControl1.SendToBack()
        ChartControl3.SendToBack()
        i = 1
    End Sub

    Private Sub AccordionControlElement4_Click(sender As Object, e As EventArgs) Handles AccordionControlElement4.Click
        Sp_Graficos_VentaTableAdapter.Fill(DsReportes.Sp_Graficos_Venta, DateEdit1.DateTime.Year, 3)
        ChartControl1.SendToBack()
        ChartControl3.SendToBack()
        i = 1
    End Sub

    Private Sub AccordionControlElement6_Click(sender As Object, e As EventArgs) Handles AccordionControlElement6.Click
        Sp_Graficos_CompraTableAdapter.Fill(DsReportes.Sp_Graficos_Compra, 0, 1)
        ChartControl2.SendToBack()
        ChartControl3.SendToBack()
        i = 2
    End Sub

    Private Sub AccordionControlElement7_Click(sender As Object, e As EventArgs) Handles AccordionControlElement7.Click
        Sp_Graficos_CompraTableAdapter.Fill(DsReportes.Sp_Graficos_Compra, DateEdit1.DateTime.Year, 2)
        ChartControl2.SendToBack()
        ChartControl3.SendToBack()
        i = 2
    End Sub

    Private Sub AccordionControlElement8_Click(sender As Object, e As EventArgs) Handles AccordionControlElement8.Click
        Sp_Graficos_CompraTableAdapter.Fill(DsReportes.Sp_Graficos_Compra, DateEdit1.DateTime.Year, 3)
        ChartControl2.SendToBack()
        ChartControl3.SendToBack()
        i = 2
    End Sub

    Private Sub AccordionControlElement10_Click(sender As Object, e As EventArgs) Handles AccordionControlElement10.Click
        SP_Productos_Mas_VendidosTableAdapter.Fill(DsReportes.SP_Productos_Mas_Vendidos, DateEdit1.DateTime, 1)
        ChartControl1.SendToBack()
        ChartControl2.SendToBack()
        i = 3
    End Sub

    Private Sub AccordionControlElement11_Click(sender As Object, e As EventArgs) Handles AccordionControlElement11.Click
        SP_Productos_Mas_VendidosTableAdapter.Fill(DsReportes.SP_Productos_Mas_Vendidos, DateEdit1.DateTime, 2)
        ChartControl1.SendToBack()
        ChartControl2.SendToBack()
        i = 3
    End Sub

    Private Sub FrmGraficosVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If i = 1 Then
            'ChartControl2.ShowRibbonPrintPreview()
            PrintableComponentLink2.CreateDocument()
            PrintableComponentLink2.ShowPreview()
        ElseIf i = 2
            'ChartControl1.ShowPrintPreview()
            PrintableComponentLink1.CreateDocument()
            PrintableComponentLink1.ShowPreview()
        ElseIf i = 3
            'ChartControl3.Show()
            PrintableComponentLink3.Landscape = True
            PrintableComponentLink3.CreateDocument()
            PrintableComponentLink3.ShowPreview()
        End If
    End Sub
End Class