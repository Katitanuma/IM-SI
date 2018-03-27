Public Class XtraReport2

    Public Sub New(ByVal FechaInicial As Date, ByVal FechaFinal As Date, ByVal EsDiario As Boolean, ByVal Dia As Date, ByVal IdCliente As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Sp_ReporteComprasFechaTableAdapter1.Fill(DsReportes1.Sp_ReporteComprasFecha, EsDiario, FechaInicial, FechaFinal, Dia, IdCliente)

        If EsDiario = True Then
            XrLabel18.Text = "Reporte de compras por dia"
        ElseIf IdCliente <> ""
            XrLabel18.Text = "Reporte de compras por proveedor"
        Else
            XrLabel18.Text = "Reporte de compras por Fecha"
        End If
    End Sub
End Class