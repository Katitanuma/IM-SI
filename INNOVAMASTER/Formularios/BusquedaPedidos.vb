
Imports System.IO
Imports DevExpress.XtraEditors

Public Class BusquedaPedidos
    Dim dt As New DataTable
    Dim conec As New Conexion
    Public P As String
    Private Sub MostrarProducto()

        Try
            Dim datos As New DatosBUsquedaPed
            Dim funcion As New FBUSQUEDAP
            datos.gproveedor = P

            dt = funcion.MostrarPP(datos)
            If dt.Rows.Count <> 0 Then
                GCPrincipal.DataSource = dt
            Else
                GCPrincipal.DataSource = Nothing
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BusquedaPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarProducto()
    End Sub

    Private Sub GCPrincipal_DoubleClick(sender As Object, e As EventArgs) Handles GCPrincipal.DoubleClick
        FrmPedidos.DgvDetalle.Rows.Add()
        Dim costo, ISV, total As Double
        FrmPedidos.DgvDetalle.Rows(FrmPedidos.DgvDetalle.RowCount - 2).Cells(1).Value = DgvProductos.GetRowCellValue(DgvProductos.FocusedRowHandle, ColIdProducto)
        FrmPedidos.DgvDetalle.Rows(FrmPedidos.DgvDetalle.RowCount - 2).Cells(2).Value = DgvProductos.GetRowCellValue(DgvProductos.FocusedRowHandle, ColDescripcion).ToString.ToUpper
        FrmPedidos.DgvDetalle.Rows(FrmPedidos.DgvDetalle.RowCount - 2).Cells(3).Value = "1"
        FrmPedidos.DgvDetalle.Rows(FrmPedidos.DgvDetalle.RowCount - 2).Cells(4).Value = FormatCurrency(CDbl(DgvProductos.GetRowCellValue(DgvProductos.FocusedRowHandle, ColCosto).ToString.ToUpper))
        costo = CDbl(DgvProductos.GetRowCellValue(DgvProductos.FocusedRowHandle, ColCosto).ToString.ToUpper)
        FrmPedidos.DgvDetalle.Rows(FrmPedidos.DgvDetalle.RowCount - 2).Cells(5).Value = FormatCurrency(CDbl(DgvProductos.GetRowCellValue(DgvProductos.FocusedRowHandle, ColISV).ToString.ToUpper))
        ISV = CDbl(DgvProductos.GetRowCellValue(DgvProductos.FocusedRowHandle, ColISV).ToString.ToUpper)
        FrmPedidos.DgvDetalle.Rows(FrmPedidos.DgvDetalle.RowCount - 2).Cells(6).Value = FormatCurrency(CDbl(costo * CDbl(FrmPedidos.DgvDetalle.Rows(FrmPedidos.DgvDetalle.RowCount - 2).Cells(3).Value)))
        FrmPedidos.DgvDetalle.Rows(FrmPedidos.DgvDetalle.RowCount - 2).Cells(7).Value = DgvProductos.GetRowCellValue(DgvProductos.FocusedRowHandle, ColIdProductoProveedor)
        FrmPedidos.DgvDetalle.EndEdit()
        FrmPedidos.LlenarTextBox()
        SendKeys.Send("{Tab}")
        Close()
        FrmPedidos.DgvDetalle.Focus()

    End Sub


    Private Sub DgvProductos_Click(sender As Object, e As EventArgs) Handles DgvProductos.Click

        Dim Imagen() As Byte = DirectCast(DgvProductos.GetRowCellValue(DgvProductos.FocusedRowHandle, ColImagen), Byte())
        Dim ms As New MemoryStream(Imagen)
        PbProducto.Image = Image.FromStream(ms)
    End Sub

    Private Sub DgvProductos_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles DgvProductos.FocusedRowChanged
        Dim Imagen() As Byte = DirectCast(DgvProductos.GetRowCellValue(DgvProductos.FocusedRowHandle, ColImagen), Byte())
        Dim ms As New MemoryStream(Imagen)
        PbProducto.Image = Image.FromStream(ms)

    End Sub

    Private Sub GCPrincipal_KeyDown(sender As Object, e As KeyEventArgs) Handles GCPrincipal.KeyDown
        If e.KeyCode = Keys.Enter Then
            FrmPedidos.DgvDetalle.Rows.Add()
            Dim costo, ISV, total As Double
            FrmPedidos.DgvDetalle.Rows(FrmPedidos.DgvDetalle.RowCount - 2).Cells(1).Value = DgvProductos.GetRowCellValue(DgvProductos.FocusedRowHandle, ColIdProducto)
            FrmPedidos.DgvDetalle.Rows(FrmPedidos.DgvDetalle.RowCount - 2).Cells(2).Value = DgvProductos.GetRowCellValue(DgvProductos.FocusedRowHandle, ColDescripcion).ToString.ToUpper
            FrmPedidos.DgvDetalle.Rows(FrmPedidos.DgvDetalle.RowCount - 2).Cells(3).Value = "1"
            FrmPedidos.DgvDetalle.Rows(FrmPedidos.DgvDetalle.RowCount - 2).Cells(4).Value = FormatCurrency(CDbl(DgvProductos.GetRowCellValue(DgvProductos.FocusedRowHandle, ColCosto).ToString.ToUpper))
            costo = CDbl(DgvProductos.GetRowCellValue(DgvProductos.FocusedRowHandle, ColCosto).ToString.ToUpper)
            FrmPedidos.DgvDetalle.Rows(FrmPedidos.DgvDetalle.RowCount - 2).Cells(5).Value = FormatCurrency(CDbl(DgvProductos.GetRowCellValue(DgvProductos.FocusedRowHandle, ColISV).ToString.ToUpper))
            ISV = CDbl(DgvProductos.GetRowCellValue(DgvProductos.FocusedRowHandle, ColISV).ToString.ToUpper)
            FrmPedidos.DgvDetalle.Rows(FrmPedidos.DgvDetalle.RowCount - 2).Cells(6).Value = FormatCurrency(CDbl(costo * CDbl(FrmPedidos.DgvDetalle.Rows(FrmPedidos.DgvDetalle.RowCount - 2).Cells(3).Value)))
            FrmPedidos.DgvDetalle.Rows(FrmPedidos.DgvDetalle.RowCount - 2).Cells(7).Value = DgvProductos.GetRowCellValue(DgvProductos.FocusedRowHandle, ColIdProductoProveedor)
            FrmPedidos.DgvDetalle.EndEdit()
            FrmPedidos.LlenarTextBox()
            SendKeys.Send("{Tab}")
            Close()
        End If
        FrmPedidos.DgvDetalle.Focus()
    End Sub
End Class