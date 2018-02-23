Imports System.Data.SqlClient
Imports DevExpress.XtraEditors

Public Class FrmProductoProveedor
    Dim conec As New Conexion
    Private Sub FrmProductoProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarComboBox()
        TxtCodigoProducto.EditValue = 0
        CboProveedor.Text = Nothing
        MostrarDatos()
    End Sub
    Public Sub LlenarComboBox()
        Using Cmd As New SqlCommand
            Try
                conec.Conectarse()
                With Cmd
                    .CommandText = "MostrarIdentificacionProveedor"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@IdProducto", SqlDbType.NVarChar, 50).Value = FrmProducto.TxtIdProducto.Text.Trim
                    .Connection = conec.Con
                    .ExecuteNonQuery()
                End With
                Dim Adaptador As New SqlDataAdapter(Cmd)
                Dim dt As New DataTable
                Adaptador.Fill(dt)
                CboProveedor.Properties.DataSource = dt

            Catch ex As Exception
                XtraMessageBox.Show(ex.Message)
            End Try
        End Using
    End Sub
    Private Sub MostrarDatos()
        Using Cmd As New SqlCommand
            Try
                conec.Conectarse()
                With Cmd
                    .CommandText = "MostrarProductoProveedor"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@IdProducto", SqlDbType.NVarChar, 50).Value = FrmProducto.TxtIdProducto.Text.Trim
                    .Connection = conec.Con
                    .ExecuteNonQuery()
                End With

                Dim Adaptador As New SqlDataAdapter(Cmd)
                Dim dt As New DataTable
                Adaptador.Fill(dt)
                GCPrincipal.DataSource = dt



            Catch ex As Exception
                XtraMessageBox.Show(ex.Message)
            End Try
        End Using
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Using Cmd As New SqlCommand
            Try
                conec.Conectarse()
                With Cmd
                    .CommandText = "EliminarProductoProveedor"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@IdProductoProveedor", SqlDbType.NVarChar, 50).Value = DgvProductoProveedor.GetRowCellValue(DgvProductoProveedor.FocusedRowHandle, ColIdProvPro)
                    .Parameters.Add("@IdProveedor", SqlDbType.VarChar, 15).Value = DgvProductoProveedor.GetRowCellValue(DgvProductoProveedor.FocusedRowHandle, ColIdProv)
                    .Connection = conec.Con
                    .ExecuteNonQuery()
                End With
                MostrarDatos()
                LlenarComboBox()
                TxtCodigoProducto.EditValue = Nothing
                CboProveedor.Text = Nothing
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TxtCodigoProducto.Text <> Nothing And CboProveedor.EditValue <> Nothing Then
            Using Cmd As New SqlCommand
                Try
                    conec.Conectarse()
                    With Cmd
                        .CommandText = "InsertarProductoProveedor"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@IdProductoProveedor", SqlDbType.NVarChar, 50).Value = TxtCodigoProducto.Text.Trim
                        .Parameters.Add("@IdProducto", SqlDbType.NVarChar, 50).Value = FrmProducto.TxtIdProducto.Text.Trim
                        .Parameters.Add("@IdProveedor", SqlDbType.VarChar, 15).Value = CboProveedor.EditValue.ToString
                        .Connection = conec.Con
                        .ExecuteNonQuery()
                    End With
                    MostrarDatos()
                    LlenarComboBox()
                    TxtCodigoProducto.EditValue = Nothing
                    CboProveedor.Text = Nothing
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using
        Else
            XtraMessageBox.Show("Ingrese o seleccione los valores", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


End Class