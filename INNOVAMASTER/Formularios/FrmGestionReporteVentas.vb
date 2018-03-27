Public Class FrmGestionReporteVentas
    Private Sub RadioGroup1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioGroup1.SelectedIndexChanged
        Dim index As Integer
        index = RadioGroup1.SelectedIndex

        Select Case index
            Case 0
                DateEdit1.Visible = True
                DateEdit2.Visible = (1 = 1)
                DateEdit3.Visible = Not True
            Case 1
                DateEdit1.Visible = False
                DateEdit2.Visible = (1 <> 1)
                DateEdit3.Visible = Not False
            Case 2
                DateEdit1.Visible = False
                DateEdit2.Visible = (1 <> 1)
                DateEdit3.Visible = Not True
        End Select

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Select Case RadioGroup1.SelectedIndex
            Case 0

                Dim id As String = DgvClientes.GetRowCellValue(DgvClientes.FocusedRowHandle, ColIdCliente)
                Dim reporte As New XtraReportVentas(DateEdit1.DateTime, DateEdit2.DateTime, False, Now, "")
                MostrarReporte(String.Format("Reporte de venta por fecha"), reporte, FrmMenuPrincipal)
                Close()
            Case 1

                Dim id As String = DgvClientes.GetRowCellValue(DgvClientes.FocusedRowHandle, ColIdCliente)
                Dim reporte As New XtraReportVentas(Now, Now, True, DateEdit3.DateTime, "")
                MostrarReporte(String.Format("Reporte de venta por dia"), reporte, FrmMenuPrincipal)
                Close()
            Case 2
                If DgvClientes.SelectedRowsCount <> 0 Then
                    Dim id As String = DgvClientes.GetRowCellValue(DgvClientes.FocusedRowHandle, ColIdCliente)
                    Dim reporte As New XtraReportVentas(Now, Now, False, Now, id)
                    MostrarReporte(String.Format("Reporte de venta por cliente"), reporte, FrmMenuPrincipal)
                    Close()
                End If
        End Select
    End Sub
    Private Sub Mostrar()
        Dim dt As New DataTable
        Try
            Dim funcion As New Fcliente
            dt = funcion.MostrarCliente

            If dt.Rows.Count <> 0 Then
                GCPrincipal.DataSource = dt

            Else
                GCPrincipal.DataSource = Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub FrmGestionReporteVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()
    End Sub
End Class