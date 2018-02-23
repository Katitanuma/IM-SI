Imports System.ComponentModel
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Public Class FrmFactura
    Dim conec As New Conexion
    Public var As Integer = 0
    Private Sub FrmFactura_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        If var = 1 Then
            FrmFacturacionVenta.Close()
        ElseIf var = 2 Then
            FrmDetalleVenta.Close()

        End If

    End Sub

    Private Sub FrmFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If var = 1 Then
            Dim cmd As SqlCommand
            Dim ds As New DsReportes
            Dim rpt As New ReporteVenta
            conec.Conectarse()
            cmd = New SqlCommand("ReporteVenta", conec.Con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@IdVenta", SqlDbType.NVarChar, 50).Value = FrmFacturacionVenta.TxtIdVenta.Text
            cmd.ExecuteNonQuery()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(ds, "ReporteVenta")
            rpt.SetDataSource(ds)
            rpt.SetParameterValue("Cambio", FrmFacturacionVenta.LblCambio.Text)

            Dim archivo As New FileIni
            rpt.SetParameterValue("CAI", archivo.IniGet(RUTA_INI, "SAR", "CAI", "").ToUpper)
            rpt.SetParameterValue("R1", archivo.IniGet(RUTA_INI, "SAR", "R1", "") & " A " & archivo.IniGet(RUTA_INI, "SAR", "R2", ""))
            rpt.SetParameterValue("FL", archivo.IniGet(RUTA_INI, "SAR", "Fecha", ""))
            CrystalReportViewer1.ReportSource = rpt
        ElseIf var = 2 Then
            Dim cmd As SqlCommand
            Dim ds As New DsReportes
            Dim rpt As New ReporteVenta
            conec.Conectarse()
            cmd = New SqlCommand("ReporteVenta", conec.Con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@IdVenta", SqlDbType.NVarChar, 50).Value = FrmDetalleVenta.LblCodigoVenta.Text
            cmd.ExecuteNonQuery()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(ds, "ReporteVenta")
            rpt.SetDataSource(ds)
            Dim archivo As New FileIni
            rpt.SetParameterValue("Cambio", FrmDetalleVenta.LblCambio.Text)
            rpt.SetParameterValue("CAI", archivo.IniGet(RUTA_INI, "SAR", "CAI", "").ToUpper)
            rpt.SetParameterValue("R1", archivo.IniGet(RUTA_INI, "SAR", "R1", "") & " A " & archivo.IniGet(RUTA_INI, "SAR", "R2", ""))
            rpt.SetParameterValue("FL", archivo.IniGet(RUTA_INI, "SAR", "Fecha", ""))
            CrystalReportViewer1.ReportSource = rpt
        ElseIf var = 3 Then
            Dim cmd As SqlCommand
            Dim ds As New DsReportes
            Dim rpt As New ReporteVenta
            conec.Conectarse()
            cmd = New SqlCommand("ReporteVenta", conec.Con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@IdVenta", SqlDbType.NVarChar, 50).Value = ReporteVentas.DgvPrincipal.GetRowCellValue(ReporteVentas.DgvPrincipal.FocusedRowHandle, "IdVenta").ToString
            cmd.ExecuteNonQuery()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(ds, "ReporteVenta")
            rpt.SetDataSource(ds)
            If ReporteVentas.DgvPrincipal.GetRowCellValue(ReporteVentas.DgvPrincipal.FocusedRowHandle, "cambio").ToString <> Nothing Then
                rpt.SetParameterValue("Cambio", ReporteVentas.DgvPrincipal.GetRowCellValue(ReporteVentas.DgvPrincipal.FocusedRowHandle, "cambio").ToString)
            Else
                rpt.SetParameterValue("Cambio", "0.00")
            End If
            Dim archivo As New FileIni
            rpt.SetParameterValue("CAI", archivo.IniGet(RUTA_INI, "SAR", "CAI", "").ToUpper)
            rpt.SetParameterValue("R1", archivo.IniGet(RUTA_INI, "SAR", "R1", "") & " A " & archivo.IniGet(RUTA_INI, "SAR", "R2", ""))
            rpt.SetParameterValue("FL", archivo.IniGet(RUTA_INI, "SAR", "Fecha", ""))

            CrystalReportViewer1.ReportSource = rpt
        End If

    End Sub
End Class