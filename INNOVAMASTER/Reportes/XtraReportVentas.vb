﻿Public Class XtraReportVentas
    Public Sub New(ByVal FechaInicial As Date, ByVal FechaFinal As Date, ByVal EsDiario As Boolean, ByVal Dia As Date, ByVal IdCliente As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Sp_ReporteVentasFechaTableAdapter1.Fill(DsReportes1.Sp_ReporteVentasFecha, EsDiario, FechaInicial, FechaFinal, Dia, IdCliente)

        If EsDiario = True Then
            XrLabel18.Text = "Reporte de ventas por dia"
        ElseIf IdCliente <> ""
            XrLabel18.Text = "Reporte de ventas por cliente"
        Else
            XrLabel18.Text = "Reporte de ventas por Fecha"
        End If
    End Sub
End Class