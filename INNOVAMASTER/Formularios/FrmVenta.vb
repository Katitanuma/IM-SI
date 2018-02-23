Imports System.Data.SqlClient
Public Class FrmVenta
    Dim dt As New DataTable
    Dim Conec As New Conexion
    Dim cmd As SqlCommand
    Private Sub FrmVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()

        Dim NombreArchivo As String = HTMLHelpClass.GetLocalHelpFileName("InnovaMasterAyuda2017.chm")
        HelpProvider1.HelpNamespace = NombreArchivo
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "Registro Venta")
        MostrarCliente()


    End Sub
    Private Sub Mostrar()
        Try
            Dim funcion As New Fventa
            dt = funcion.MostrarVenta

            If dt.Rows.Count <> 0 Then
                ' DgvVenta.DataSource = dt

            Else
                ' DgvVenta.DataSource = Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MostrarCliente()
        Try
            Dim funcion As New Fcliente
            dt = funcion.MostrarCliente

            If dt.Rows.Count <> 0 Then
                GCPrincipal.DataSource = dt

            Else
                GCPrincipal.DataSource = Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub GCPrincipal_Click(sender As Object, e As EventArgs) Handles GCPrincipal.Click
        Dim sql As String = "Select A.IdVenta,A.IdCliente,A.FechaVenta,A.FechaVencimiento,B.FormaVenta,C.TipoVenta,D.Usuario,A.DescuentoExtra
                            from Venta A inner join FormaVenta  B
                            on A.IdFormaVenta = B.IdFormaVenta 
                            inner join TipoVenta C
                            on A.IdTipoVenta = C.IdTipoVenta 
                            inner join Usuario D
                            on A.IdUsuario = D.IdUsuario
                            WHERE A.IdCliente = '" & DgvPrincipal.GetRowCellValue(DgvPrincipal.FocusedRowHandle, "Identidad") & "' "
        Dim con As New Conexion
        Try
            con.Conectarse()

            cmd = New SqlCommand(sql)
            cmd.CommandType = CommandType.Text
            cmd.Connection = con.Con

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter
                da = New SqlDataAdapter(cmd)
                da.Fill(dt)
                GCPrincipal2.DataSource = dt
            Else

                GCPrincipal2.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)

        Finally
            con.Desconectarse()
        End Try


    End Sub

    Private Sub DgvPrincipal_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles DgvPrincipal.FocusedRowChanged
        Dim sql As String = "Select A.IdVenta,A.IdCliente,A.FechaVenta,A.FechaVencimiento,B.FormaVenta,C.TipoVenta,D.Usuario,A.DescuentoExtra
                            from Venta A inner join FormaVenta  B
                            on A.IdFormaVenta = B.IdFormaVenta 
                            inner join TipoVenta C
                            on A.IdTipoVenta = C.IdTipoVenta 
                            inner join Usuario D
                            on A.IdUsuario = D.IdUsuario
                            WHERE A.IdCliente = '" & DgvPrincipal.GetRowCellValue(DgvPrincipal.FocusedRowHandle, "Identidad") & "' "
        Dim con As New Conexion
        Try
            con.Conectarse()

            cmd = New SqlCommand(sql)
            cmd.CommandType = CommandType.Text
            cmd.Connection = con.Con

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter
                da = New SqlDataAdapter(cmd)
                da.Fill(dt)
                GCPrincipal2.DataSource = dt
            Else

                GCPrincipal2.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)

        Finally
            con.Desconectarse()
        End Try


    End Sub

End Class