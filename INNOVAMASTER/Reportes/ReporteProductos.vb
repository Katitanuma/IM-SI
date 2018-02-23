Imports System.Data.SqlClient
Public Class ReporteProductos
    Dim connect As New Conexion
    Protected Overrides Sub MostrarDatos()

        Using cmd As New SqlCommand
            Try
                Connect.Conectarse()
                With cmd
                    .CommandText = "MostrarDatosProductoReporte"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Connect.Con
                End With

                Dim AdaptadorReporteProductos As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorReporteProductos.Fill(dt)
                GCPrincipal.DataSource = dt

            Catch ex As Exception
                MessageBox.Show("Error al mostrar el reporte de los productos " + ex.Message)
            Finally
                Connect.Desconectarse()
            End Try

        End Using
    End Sub

    Protected Overrides Sub AyudaHTML()
        Dim NombreArchivo As String = HTMLHelpClass.GetLocalHelpFileName("InnovaMasterAyuda2017.chm")
        HelpProvider1.HelpNamespace = NombreArchivo
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "Reporte Producto")
    End Sub

    Protected Overrides Sub Reporte()
        'FrmRptProducto.MdiParent = FrmMenuPrincipal
        'FrmRptProducto.Show()

        Dim frm As New FrmRptProducto
        frm.MdiParent = FrmMenuPrincipal
        frm.Show()
    End Sub

    Protected Overrides Sub Imprimir()
        Dim ds As New DsReportes
        Dim rpt As New RptProducto
        Try

            connect.Conectarse()
            Dim cmd As New SqlCommand("ReporteProducto", connect.Con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.ExecuteNonQuery()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(ds, "ReporteProducto")
            rpt.SetDataSource(ds)
            rpt.PrintToPrinter(1, False, 0, 0)

        Catch ex As Exception

        End Try

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
                connect.Conectarse()
                With cmd
                    .CommandText = "MostrarDatosProductoReporte"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = connect.Con
                End With

                Dim AdaptadorReporteProductos As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorReporteProductos.Fill(dt)
                GCPrincipal.DataSource = dt

            Catch ex As Exception
                MessageBox.Show("Error al mostrar el reporte de los productos " + ex.Message)
            Finally
                connect.Desconectarse()
            End Try

        End Using
    End Sub


End Class