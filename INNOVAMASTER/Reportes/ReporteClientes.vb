Imports System.Data.SqlClient
Imports DevExpress.XtraEditors

Public Class ReporteClientes
    Dim connect As New Conexion
    Protected Overrides Sub MostrarDatos()
        Using cmd As New SqlCommand
            Try
                connect.Conectarse()
                With cmd
                    .CommandText = "MostrarDatosClienteReporte"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = connect.Con
                End With

                Dim AdaptadorReporteClientes As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorReporteClientes.Fill(dt)
                GCPrincipal.DataSource = dt

            Catch ex As Exception
                MessageBox.Show("Error al mostrar el reporte de los clientes " + ex.Message)
            Finally
                connect.Desconectarse()
            End Try

        End Using
    End Sub

    Protected Overrides Sub AyudaHTML()
        Dim NombreArchivo As String = HTMLHelpClass.GetLocalHelpFileName("InnovaMasterAyuda2017.chm")
        HelpProvider1.HelpNamespace = NombreArchivo
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "Reporte Cliente")
    End Sub

    Protected Overrides Sub Reporte()
        'FrmRptCliente.MdiParent = FrmMenuPrincipal
        'FrmRptCliente.Show()

        Dim frm As New FrmRptCliente
        frm.MdiParent = Me
        frm.Show()

    End Sub

    Protected Overrides Sub Imprimir()
        Dim ds As New DsReportes
        Dim rpt As New RptCliente
        Try

            connect.Conectarse()
            Dim cmd As New SqlCommand("ReporteCliente", connect.Con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.ExecuteNonQuery()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(ds, "ReporteCliente")
            rpt.SetDataSource(ds)
            rpt.PrintToPrinter(1, False, 0, 0)

        Catch ex As Exception

        End Try
    End Sub

    Protected Overrides Sub ActualizarDatos()
        Using cmd As New SqlCommand
            Try
                connect.Conectarse()
                With cmd
                    .CommandText = "MostrarDatosClienteReporte"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = connect.Con
                End With

                Dim AdaptadorReporteClientes As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorReporteClientes.Fill(dt)
                GCPrincipal.DataSource = dt

            Catch ex As Exception
                MessageBox.Show("Error al mostrar el reporte de los clientes " + ex.Message)
            Finally
                connect.Desconectarse()
            End Try

        End Using
    End Sub

    Protected Overrides Sub ExportarExcel()
        Exportar_a_Excel(GCPrincipal, Me.Text)
    End Sub
    Protected Overrides Sub ExportarPDF()
        Exportar_a_PDF(GCPrincipal, Me.Text)
    End Sub

    Private Sub BtnReporte_Click(sender As Object, e As EventArgs) Handles BtnReporte.Click

    End Sub


End Class