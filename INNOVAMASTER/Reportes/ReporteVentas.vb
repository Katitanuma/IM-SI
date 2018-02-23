Imports System.Data.SqlClient
Public Class ReporteVentas
    Dim Connect As New Conexion
    Protected Overrides Sub MostrarDatos()
        Using cmd As New SqlCommand
            Try
                Connect.Conectarse()
                With cmd
                    .CommandText = "MostrarDatosVentaReporte"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Connect.Con
                End With

                Dim AdaptadorReporteVentas As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorReporteVentas.Fill(dt)
                GCPrincipal.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error al mostrar el reporte de las ventas " + ex.Message)
            Finally
                Connect.Desconectarse()
            End Try

        End Using
    End Sub
    Protected Overrides Sub AyudaHTML()
        Dim NombreArchivo As String = HTMLHelpClass.GetLocalHelpFileName("InnovaMasterAyuda2017.chm")
        HelpProvider1.HelpNamespace = NombreArchivo
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "Reporte Venta")
    End Sub

    Private Sub ImprimirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirToolStripMenuItem.Click
        Dim conec As New Conexion
        Dim cmd As New SqlCommand
        Dim ds As New DsReportes
        Dim rpt As New ReporteVenta
        Try

            conec.Conectarse()
            cmd = New SqlCommand("ReporteVenta", Conec.Con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@IdVenta", SqlDbType.NVarChar, 50).Value = DgvPrincipal.GetRowCellValue(DgvPrincipal.FocusedRowHandle, "IdVenta")
            cmd.ExecuteNonQuery()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(ds, "ReporteVenta")
            rpt.SetDataSource(ds)
            If DgvPrincipal.GetRowCellValue(DgvPrincipal.FocusedRowHandle, "Cambio").ToString <> Nothing Then
                rpt.SetParameterValue("Cambio", DgvPrincipal.GetRowCellValue(DgvPrincipal.FocusedRowHandle, "Cambio").ToString)
            Else
                rpt.SetParameterValue("Cambio", "0.00")
            End If
            rpt.SetParameterValue("CAI", My.Settings.CAI.Trim.ToUpper)
            rpt.SetParameterValue("R1", My.Settings.R1 & " A " & My.Settings.R2)
            rpt.SetParameterValue("FL", My.Settings.FL.Trim.ToUpper)

            rpt.PrintToPrinter(1, False, 0, 0)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub VerReporeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerReporeToolStripMenuItem.Click


        'FrmFactura.var = 3
        'FrmFactura.MdiParent = FrmMenuPrincipal
        'FrmFactura.Show()
        Dim frm As New FrmFactura
        frm.var = 3
        frm.MdiParent = FrmMenuPrincipal
        frm.Show()

    End Sub

    Protected Overrides Sub ExportarExcel()
        Exportar_a_Excel(GCPrincipal, Me.Text)
    End Sub
    Protected Overrides Sub ExportarPDF()
        Exportar_a_PDF(GCPrincipal, Me.Text)
    End Sub
    Protected Overrides Sub ActualizarDatos()
        Using cmd As New SqlCommand
            Try
                Connect.Conectarse()
                With cmd
                    .CommandText = "MostrarDatosVentaReporte"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Connect.Con
                End With

                Dim AdaptadorReporteVentas As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorReporteVentas.Fill(dt)
                GCPrincipal.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error al mostrar el reporte de las ventas " + ex.Message)
            Finally
                Connect.Desconectarse()
            End Try

        End Using
    End Sub

    Private Sub ReporteVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class