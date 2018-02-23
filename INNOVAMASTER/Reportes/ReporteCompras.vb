Imports System.Data.SqlClient

Public Class ReporteCompras
    Dim Connect As New Conexion
    Dim conec As New Conexion

    Protected Overrides Sub MostrarDatos()
        Using cmd As New SqlCommand
            Try
                Connect.Conectarse()
                With cmd
                    .CommandText = "MostrarDatosCompraReporte"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Connect.Con
                End With

                Dim AdaptadorReporteClientes As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorReporteClientes.Fill(dt)
                GCPrincipal.DataSource = dt

            Catch ex As Exception
                MessageBox.Show("Error al mostrar el reporte de los clientes " + ex.Message)
            Finally
                Connect.Desconectarse()
            End Try

        End Using
    End Sub

    Protected Overrides Sub AyudaHTML()

        Dim NombreArchivo As String = HTMLHelpClass.GetLocalHelpFileName("InnovaMasterAyuda2017.chm")
        HelpProvider1.HelpNamespace = NombreArchivo
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "Reporte Compra")

    End Sub

    Private Sub ImprimirReporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirReporteToolStripMenuItem.Click
        Dim ds As New DsReportes
        Dim rpt As New RptCompra
        Try

            conec.Conectarse()
            Dim cmd As New SqlCommand
            cmd = New SqlCommand("ReporteCompra", conec.Con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@IdCompra", SqlDbType.Int).Value = CInt(DgvPrincipal.GetRowCellValue(DgvPrincipal.FocusedRowHandle, "IdCompra").ToString)
            cmd.ExecuteNonQuery()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(ds, "ReporteCompra")
            rpt.SetDataSource(ds)
            rpt.PrintToPrinter(1, False, 0, 0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub VisualizarReporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisualizarReporteToolStripMenuItem.Click
        'FrmRptCompra.var = 1
        'FrmRptCompra.MdiParent = FrmMenuPrincipal
        'FrmRptCompra.Show()

        Dim frm As New FrmRptCompra
        frm.var = 1
        frm.MdiParent = FrmMenuPrincipal
        frm.Show()
    End Sub

    Protected Overrides Sub ActualizarDatos()
        Using cmd As New SqlCommand
            Try
                Connect.Conectarse()
                With cmd
                    .CommandText = "MostrarDatosCompraReporte"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Connect.Con
                End With

                Dim AdaptadorReporteClientes As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorReporteClientes.Fill(dt)
                GCPrincipal.DataSource = dt

            Catch ex As Exception
                MessageBox.Show("Error al mostrar el reporte de los clientes " + ex.Message)
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