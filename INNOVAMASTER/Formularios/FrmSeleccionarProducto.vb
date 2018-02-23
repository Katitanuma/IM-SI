Public Class FrmSeleccionarProducto
    Private Sub FrmSeleccionarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarProducto()
    End Sub
    Dim dt As New DataTable

    Private Sub MostrarProducto()
        Try
            Dim datos As New Fproducto
            dt = datos.MostrarProducto

            If dt.Rows.Count <> 0 Then
                GCPrincipal.DataSource = dt
            Else
                GCPrincipal.DataSource = Nothing
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DgvProductos_DoubleClick(sender As Object, e As EventArgs) Handles DgvProductos.DoubleClick
        FrmFacturacionVenta.DgvDetalle.Rows.Add()
        Dim precio, totalDescuento, ISV, total As Double
        FrmFacturacionVenta.DgvDetalle.Rows(FrmFacturacionVenta.DgvDetalle.RowCount - 2).Cells(1).Value = DgvProductos.GetRowCellValue(DgvProductos.FocusedRowHandle, ColIdProducto)
        FrmFacturacionVenta.DgvDetalle.Rows(FrmFacturacionVenta.DgvDetalle.RowCount - 2).Cells(2).Value = DgvProductos.GetRowCellValue(DgvProductos.FocusedRowHandle, ColDescripcion).ToString.ToUpper
        FrmFacturacionVenta.DgvDetalle.Rows(FrmFacturacionVenta.DgvDetalle.RowCount - 2).Cells(3).Value = "1"
        If FrmFacturacionVenta.CboFV.Text = "Unitario" Then
            FrmFacturacionVenta.DgvDetalle.Rows(FrmFacturacionVenta.DgvDetalle.RowCount - 2).Cells(4).Value = FormatCurrency(CDbl(DgvProductos.GetRowCellValue(DgvProductos.FocusedRowHandle, ColPrecioUnitario).ToString.ToUpper))
            precio = CDbl(DgvProductos.GetRowCellValue(DgvProductos.FocusedRowHandle, ColPrecioUnitario).ToString.ToUpper)
        Else
            FrmFacturacionVenta.DgvDetalle.Rows(FrmFacturacionVenta.DgvDetalle.RowCount - 2).Cells(4).Value = FormatCurrency(CDbl(DgvProductos.GetRowCellValue(DgvProductos.FocusedRowHandle, ColPreciolMayorista).ToString.ToUpper))
            precio = CDbl(DgvProductos.GetRowCellValue(DgvProductos.FocusedRowHandle, ColPreciolMayorista).ToString.ToUpper)
        End If
        totalDescuento = 0
        ISV = CDbl(DgvProductos.GetRowCellValue(DgvProductos.FocusedRowHandle, ColISV).ToString.ToUpper)

        FrmFacturacionVenta.DgvDetalle.Rows(FrmFacturacionVenta.DgvDetalle.RowCount - 2).Cells(5).Value = "0"
        FrmFacturacionVenta.DgvDetalle.Rows(FrmFacturacionVenta.DgvDetalle.RowCount - 2).Cells(6).Value = FormatCurrency(0)
        FrmFacturacionVenta.DgvDetalle.Rows(FrmFacturacionVenta.DgvDetalle.RowCount - 2).Cells(7).Value = FormatCurrency(CDbl(DgvProductos.GetRowCellValue(DgvProductos.FocusedRowHandle, ColISV).ToString.ToUpper))
        FrmFacturacionVenta.DgvDetalle.Rows(FrmFacturacionVenta.DgvDetalle.RowCount - 2).Cells(8).Value = FormatCurrency(CDbl(precio * CDbl(FrmFacturacionVenta.DgvDetalle.Rows(FrmFacturacionVenta.DgvDetalle.RowCount - 2).Cells(3).Value)))
        FrmFacturacionVenta.DgvDetalle.EndEdit()
        FrmFacturacionVenta.LlenarTextBox()
        SendKeys.Send("{Tab}")
        Close()
    End Sub
End Class