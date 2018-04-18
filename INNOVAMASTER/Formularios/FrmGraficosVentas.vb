Public Class FrmGraficosVentas
    Dim i As Integer = 0
    Dim j As Integer = 0
    Private Sub AccordionControlElement2_Click(sender As Object, e As EventArgs) Handles AccordionControlElement2.Click
        Sp_Graficos_VentaTableAdapter.Fill(DsReportes.Sp_Graficos_Venta, 0, 1)
        ChartControl1.SendToBack()
        ChartControl3.SendToBack()
        i = 1
        j = 1
        Normal(i, j)
    End Sub

    Private Sub AccordionControlElement3_Click(sender As Object, e As EventArgs) Handles AccordionControlElement3.Click
        Sp_Graficos_VentaTableAdapter.Fill(DsReportes.Sp_Graficos_Venta, DateEdit1.DateTime.Year, 2)
        ChartControl1.SendToBack()
        ChartControl3.SendToBack()
        i = 1
        j = 2
        Normal(i, j)
    End Sub

    Private Sub AccordionControlElement4_Click(sender As Object, e As EventArgs) Handles AccordionControlElement4.Click
        Sp_Graficos_VentaTableAdapter.Fill(DsReportes.Sp_Graficos_Venta, DateEdit1.DateTime.Year, 3)
        ChartControl1.SendToBack()
        ChartControl3.SendToBack()
        i = 1
        j = 3
        Normal(i, j)
    End Sub

    Private Sub AccordionControlElement6_Click(sender As Object, e As EventArgs) Handles AccordionControlElement6.Click
        Sp_Graficos_CompraTableAdapter.Fill(DsReportes.Sp_Graficos_Compra, 0, 1)
        ChartControl2.SendToBack()
        ChartControl3.SendToBack()
        i = 2
        j = 1
        Normal(i, j)
    End Sub

    Private Sub AccordionControlElement7_Click(sender As Object, e As EventArgs) Handles AccordionControlElement7.Click
        Sp_Graficos_CompraTableAdapter.Fill(DsReportes.Sp_Graficos_Compra, DateEdit1.DateTime.Year, 2)
        ChartControl2.SendToBack()
        ChartControl3.SendToBack()
        i = 2
        j = 2
        Normal(i, j)
    End Sub

    Private Sub AccordionControlElement8_Click(sender As Object, e As EventArgs) Handles AccordionControlElement8.Click
        Sp_Graficos_CompraTableAdapter.Fill(DsReportes.Sp_Graficos_Compra, DateEdit1.DateTime.Year, 3)
        ChartControl2.SendToBack()
        ChartControl3.SendToBack()
        i = 2
        j = 3
        Normal(i, j)
    End Sub

    Private Sub AccordionControlElement10_Click(sender As Object, e As EventArgs) Handles AccordionControlElement10.Click
        SP_Productos_Mas_VendidosTableAdapter.Fill(DsReportes.SP_Productos_Mas_Vendidos, DateEdit1.DateTime, 1)
        ChartControl1.SendToBack()
        ChartControl2.SendToBack()
        i = 3
        j = 1
        Normal(i, j)
    End Sub

    Private Sub AccordionControlElement11_Click(sender As Object, e As EventArgs) Handles AccordionControlElement11.Click
        SP_Productos_Mas_VendidosTableAdapter.Fill(DsReportes.SP_Productos_Mas_Vendidos, DateEdit1.DateTime, 2)
        ChartControl1.SendToBack()
        ChartControl2.SendToBack()
        i = 3
        j = 2
        Normal(i, j)
    End Sub

    Private Sub FrmGraficosVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateEdit1.Text = DateTime.Now.ToShortDateString()
        Sp_Graficos_VentaTableAdapter.Fill(DsReportes.Sp_Graficos_Venta, 0, 1)
        ChartControl1.SendToBack()
        ChartControl3.SendToBack()
        i = 1
        j = 1
        Normal(i, j)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim Title As New DevExpress.XtraCharts.ChartTitle
        If i = 1 Then
            If j = 1 Then
                PrintableComponentLink2.CreateDocument()
                PrintableComponentLink2.ShowPreview()
            ElseIf j = 2 Then
                PrintableComponentLink6.CreateDocument()
                PrintableComponentLink6.ShowPreview()
            ElseIf j = 3 Then
                PrintableComponentLink7.CreateDocument()
                PrintableComponentLink7.ShowPreview()
            End If

        ElseIf i = 2 Then
            'ChartControl1.ShowPrintPreview()
            If j = 1 Then
                PrintableComponentLink1.CreateDocument()
                PrintableComponentLink1.ShowPreview()
            ElseIf j = 2 Then
                PrintableComponentLink4.CreateDocument()
                PrintableComponentLink4.ShowPreview()
            ElseIf j = 3 Then
                PrintableComponentLink5.CreateDocument()
                PrintableComponentLink5.ShowPreview()
            End If
        ElseIf i = 3 Then
            'ChartControl3.Show()
            If j = 1 Then
                PrintableComponentLink3.CreateDocument()
                PrintableComponentLink3.ShowPreview()
            ElseIf j = 2 Then
                PrintableComponentLink8.CreateDocument()
                PrintableComponentLink8.ShowPreview()
            End If
        End If
    End Sub

    Private Sub Normal(ByVal i As Int16, ByVal j As Int16)
        If i = 1 Then
            If j = 1 Then
                AccordionControlElement2.Appearance.Normal.BackColor = Color.DeepSkyBlue
                AccordionControlElement2.Appearance.Normal.ForeColor = Color.White
                AccordionControlElement3.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement3.Appearance.Normal.ForeColor = Color.Black
                AccordionControlElement4.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement4.Appearance.Normal.ForeColor = Color.Black
                AccordionControlElement6.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement6.Appearance.Normal.ForeColor = Color.Black
                AccordionControlElement7.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement7.Appearance.Normal.ForeColor = Color.Black
                AccordionControlElement8.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement8.Appearance.Normal.ForeColor = Color.Black
                AccordionControlElement10.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement10.Appearance.Normal.ForeColor = Color.Black
                AccordionControlElement11.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement11.Appearance.Normal.ForeColor = Color.Black
            ElseIf j = 2 Then
                AccordionControlElement2.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement2.Appearance.Normal.ForeColor = Color.Black
                AccordionControlElement3.Appearance.Normal.BackColor = Color.DeepSkyBlue
                AccordionControlElement3.Appearance.Normal.ForeColor = Color.White
                AccordionControlElement4.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement4.Appearance.Normal.ForeColor = Color.Black
                AccordionControlElement6.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement6.Appearance.Normal.ForeColor = Color.Black
                AccordionControlElement7.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement7.Appearance.Normal.ForeColor = Color.Black
                AccordionControlElement8.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement8.Appearance.Normal.ForeColor = Color.Black
                AccordionControlElement10.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement10.Appearance.Normal.ForeColor = Color.Black
                AccordionControlElement11.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement11.Appearance.Normal.ForeColor = Color.Black

            ElseIf j = 3 Then
                AccordionControlElement2.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement2.Appearance.Normal.ForeColor = Color.Black
                AccordionControlElement3.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement3.Appearance.Normal.ForeColor = Color.Black
                AccordionControlElement4.Appearance.Normal.BackColor = Color.DeepSkyBlue
                AccordionControlElement4.Appearance.Normal.ForeColor = Color.White
                AccordionControlElement6.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement6.Appearance.Normal.ForeColor = Color.Black
                AccordionControlElement7.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement7.Appearance.Normal.ForeColor = Color.Black
                AccordionControlElement8.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement8.Appearance.Normal.ForeColor = Color.Black
                AccordionControlElement10.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement10.Appearance.Normal.ForeColor = Color.Black
                AccordionControlElement11.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement11.Appearance.Normal.ForeColor = Color.Black
            End If
        ElseIf i = 2 Then
            If j = 1 Then
                AccordionControlElement2.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement2.Appearance.Normal.ForeColor = Color.Black
                AccordionControlElement3.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement3.Appearance.Normal.ForeColor = Color.Black
                AccordionControlElement4.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement4.Appearance.Normal.ForeColor = Color.Black
                AccordionControlElement6.Appearance.Normal.BackColor = Color.DeepSkyBlue
                AccordionControlElement6.Appearance.Normal.ForeColor = Color.White
                AccordionControlElement7.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement7.Appearance.Normal.ForeColor = Color.Black
                AccordionControlElement8.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement8.Appearance.Normal.ForeColor = Color.Black
                AccordionControlElement10.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement10.Appearance.Normal.ForeColor = Color.Black
                AccordionControlElement11.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement11.Appearance.Normal.ForeColor = Color.Black
            ElseIf j = 2 Then
                AccordionControlElement2.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement2.Appearance.Normal.ForeColor = Color.Black
                AccordionControlElement3.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement3.Appearance.Normal.ForeColor = Color.Black
                AccordionControlElement4.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement4.Appearance.Normal.ForeColor = Color.Black
                AccordionControlElement6.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement6.Appearance.Normal.ForeColor = Color.Black
                AccordionControlElement7.Appearance.Normal.BackColor = Color.DeepSkyBlue
                AccordionControlElement7.Appearance.Normal.ForeColor = Color.White
                AccordionControlElement8.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement8.Appearance.Normal.ForeColor = Color.Black
                AccordionControlElement10.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement10.Appearance.Normal.ForeColor = Color.Black
                AccordionControlElement11.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement11.Appearance.Normal.ForeColor = Color.Black

            ElseIf j = 3 Then
                AccordionControlElement2.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement2.Appearance.Normal.ForeColor = Color.Black
                AccordionControlElement3.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement3.Appearance.Normal.ForeColor = Color.Black
                AccordionControlElement4.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement4.Appearance.Normal.ForeColor = Color.Black
                AccordionControlElement6.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement6.Appearance.Normal.ForeColor = Color.Black
                AccordionControlElement7.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement7.Appearance.Normal.ForeColor = Color.Black
                AccordionControlElement8.Appearance.Normal.BackColor = Color.DeepSkyBlue
                AccordionControlElement8.Appearance.Normal.ForeColor = Color.White
                AccordionControlElement10.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement10.Appearance.Normal.ForeColor = Color.Black
                AccordionControlElement11.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement11.Appearance.Normal.ForeColor = Color.Black
            End If

        ElseIf i = 3 Then
            If j = 1 Then
                AccordionControlElement2.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement2.Appearance.Normal.ForeColor = Color.Black
                AccordionControlElement3.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement3.Appearance.Normal.ForeColor = Color.Black
                AccordionControlElement4.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement4.Appearance.Normal.ForeColor = Color.Black
                AccordionControlElement6.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement6.Appearance.Normal.ForeColor = Color.Black
                AccordionControlElement7.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement7.Appearance.Normal.ForeColor = Color.Black
                AccordionControlElement8.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement8.Appearance.Normal.ForeColor = Color.Black
                AccordionControlElement10.Appearance.Normal.BackColor = Color.DeepSkyBlue
                AccordionControlElement10.Appearance.Normal.ForeColor = Color.White
                AccordionControlElement11.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement11.Appearance.Normal.ForeColor = Color.Black
            ElseIf j = 2 Then
                AccordionControlElement2.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement2.Appearance.Normal.ForeColor = Color.Black
                AccordionControlElement3.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement3.Appearance.Normal.ForeColor = Color.Black
                AccordionControlElement4.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement4.Appearance.Normal.ForeColor = Color.Black
                AccordionControlElement6.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement6.Appearance.Normal.ForeColor = Color.Black
                AccordionControlElement7.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement7.Appearance.Normal.ForeColor = Color.Black
                AccordionControlElement8.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement8.Appearance.Normal.ForeColor = Color.Black
                AccordionControlElement10.Appearance.Normal.BackColor = Color.Transparent
                AccordionControlElement10.Appearance.Normal.ForeColor = Color.Black
                AccordionControlElement11.Appearance.Normal.BackColor = Color.DeepSkyBlue
                AccordionControlElement11.Appearance.Normal.ForeColor = Color.White
            End If
        End If

    End Sub
End Class