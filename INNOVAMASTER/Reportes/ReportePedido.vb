Imports System.Data.SqlClient
Public Class ReportePedido
    Dim Connect As New Conexion
    Protected Overrides Sub MostrarDatos()
        Using cmd As New SqlCommand
            Try
                Connect.Conectarse()
                With cmd
                    .CommandText = "MostrarDatosPedidoReporte"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Connect.Con
                End With

                Dim AdaptadorReportePedidos As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorReportePedidos.Fill(dt)
                GCPrincipal.DataSource = dt

            Catch ex As Exception
                MessageBox.Show("Error al mostrar el reporte de los pedidos " + ex.Message)
            Finally
                Connect.Desconectarse()
            End Try

        End Using
    End Sub
    Protected Overrides Sub AyudaHTML()
        Dim NombreArchivo As String = HTMLHelpClass.GetLocalHelpFileName("InnovaMasterAyuda2017.chm")
        HelpProvider1.HelpNamespace = NombreArchivo
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "Reporte Pedidos")
    End Sub

    Private Sub VisualizarReporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisualizarReporteToolStripMenuItem.Click
        'FrmRptPedido.var = 1
        'FrmRptPedido.MdiParent = FrmMenuPrincipal
        'FrmRptPedido.Show()
        Dim frm As New FrmRptPedido
        frm.var = 1
        frm.MdiParent = FrmMenuPrincipal
        frm.Show()
    End Sub

    Private Sub ImprimirReporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirReporteToolStripMenuItem.Click
        Dim ds As New DsReportes
        Dim rpt As New RptPedido
        Dim conec As New Conexion
        Try

            conec.Conectarse()
            Dim cmd As New SqlCommand
            cmd = New SqlCommand("ReportePedido", conec.Con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@IdPedido", SqlDbType.Int).Value = CInt(DgvPrincipal.GetRowCellValue(DgvPrincipal.FocusedRowHandle, "IdPedido").ToString)
            cmd.ExecuteNonQuery()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(ds, "ReportePedido")
            rpt.SetDataSource(ds)
            rpt.PrintToPrinter(1, False, 0, 0)

        Catch ex As Exception

        End Try
    End Sub
    Protected Overrides Sub ActualizarDatos()
        Using cmd As New SqlCommand
            Try
                Connect.Conectarse()
                With cmd
                    .CommandText = "MostrarDatosPedidoReporte"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Connect.Con
                End With

                Dim AdaptadorReportePedidos As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorReportePedidos.Fill(dt)
                GCPrincipal.DataSource = dt

            Catch ex As Exception
                MessageBox.Show("Error al mostrar el reporte de los pedidos " + ex.Message)
            Finally
                Connect.Desconectarse()
            End Try

        End Using
    End Sub
    Protected Overrides Sub ExportarExcel()
        Exportar_a_Excel(GCPrincipal, Me.Text)
    End Sub
    Protected Overrides Sub ExportarPDF()
        Exportar_a_PDF(GCPrincipal, Me.Text)
    End Sub


End Class