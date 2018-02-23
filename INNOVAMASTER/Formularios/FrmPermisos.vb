Imports System.Data.SqlClient
Imports DevExpress.XtraEditors

Public Class FrmPermisos
    Dim con As New Conexion
    Dim i As Integer
    Private Sub FrmPermisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MostrarUsuario()
    End Sub

    Private Sub MostrarUsuario()
        Dim dt As New DataTable
        Try
            Dim datos As New Fusuario
            dt = datos.MostrarUsuario
            If dt.Rows.Count <> 0 Then
                GCPrincipal.DataSource = dt
            Else
                GCPrincipal.DataSource = Nothing

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GCPrincipal_Click(sender As Object, e As EventArgs) Handles GCPrincipal.Click
        i = CInt(DgvUsuario.GetRowCellValue(DgvUsuario.FocusedRowHandle, ColIdUsuario))
        MostrarPermisosPermitidos(CInt(DgvUsuario.GetRowCellValue(DgvUsuario.FocusedRowHandle, ColIdUsuario)))
        MostrarPermisosDenegados(CInt(DgvUsuario.GetRowCellValue(DgvUsuario.FocusedRowHandle, ColIdUsuario)))
    End Sub
    Private Sub MostrarPermisosPermitidos(ByVal IdUsuario As Integer)
        Dim cmd As New SqlCommand
        Try
            con.Conectarse()
            cmd = New SqlCommand("SP_MostraPermisosPermitidos")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = con.Con

            cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = IdUsuario

            Dim da As New SqlDataAdapter
            Dim dt As New DataTable

            If cmd.ExecuteNonQuery Then
                da = New SqlDataAdapter(cmd)
                da.Fill(dt)
                GCPD.DataSource = dt
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.ToString)
        Finally
            con.Desconectarse()
        End Try
    End Sub
    Private Sub MostrarPermisosDenegados(ByVal IdUsuario As Integer)
        Dim cmd As New SqlCommand
        Try
            con.Conectarse()
            cmd = New SqlCommand("SP_MostraPermisosDenegados")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = con.Con

            cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = IdUsuario

            Dim da As New SqlDataAdapter
            Dim dt As New DataTable

            If cmd.ExecuteNonQuery Then
                da = New SqlDataAdapter(cmd)
                da.Fill(dt)
                GCPP.DataSource = dt
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.ToString)
        Finally
            con.Desconectarse()
        End Try
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dim index As Integer = DgvP.FocusedRowHandle
        If index >= 0 Then
            Dim cmd As New SqlCommand
            Try
                con.Conectarse()
                cmd = New SqlCommand("SP_InsertarPermisoDenegado")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = con.Con

                cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = DgvP.GetRowCellValue(index, ColIdUsuario2)
                cmd.Parameters.Add("@IdPermiso", SqlDbType.Int).Value = DgvP.GetRowCellValue(index, ColIdPermiso2)


                If cmd.ExecuteNonQuery Then
                    MostrarPermisosPermitidos(CInt(DgvP.GetRowCellValue(DgvP.FocusedRowHandle, ColIdUsuario2)))
                    MostrarPermisosDenegados(CInt(DgvP.GetRowCellValue(DgvP.FocusedRowHandle, ColIdUsuario2)))
                End If
            Catch ex As Exception
                XtraMessageBox.Show(ex.ToString)
            Finally
                con.Desconectarse()
            End Try
        Else
            If (i >= 0) Then
                MostrarPermisosPermitidos(i)
                MostrarPermisosDenegados(i)
            End If
            XtraMessageBox.Show("Seleccione el Permiso", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If (i >= 0) Then
            MostrarPermisosPermitidos(i)
            MostrarPermisosDenegados(i)
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim index As Integer = DgvD.FocusedRowHandle
        If index >= 0 Then
            Dim cmd As New SqlCommand
            Try
                con.Conectarse()
                cmd = New SqlCommand("SP_InsertarPermisoPermitido")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = con.Con

                cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = DgvD.GetRowCellValue(index, ColIdUsuario1)
                cmd.Parameters.Add("@IdPermiso", SqlDbType.Int).Value = DgvD.GetRowCellValue(index, ColIdPermiso1)


                If cmd.ExecuteNonQuery Then
                    MostrarPermisosPermitidos(CInt(DgvD.GetRowCellValue(DgvD.FocusedRowHandle, ColIdUsuario1)))
                    MostrarPermisosDenegados(CInt(DgvD.GetRowCellValue(DgvD.FocusedRowHandle, ColIdUsuario1)))
                End If
            Catch ex As Exception
                XtraMessageBox.Show(ex.ToString)
            Finally
                con.Desconectarse()
            End Try
        Else
            If (i >= 0) Then
                MostrarPermisosPermitidos(i)
                MostrarPermisosDenegados(i)
            End If
            XtraMessageBox.Show("Seleccione el Permiso", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If (i >= 0) Then
            MostrarPermisosPermitidos(i)
            MostrarPermisosDenegados(i)
        End If
    End Sub

    Private Sub DgvUsuario_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles DgvUsuario.FocusedRowChanged
        i = CInt(DgvUsuario.GetRowCellValue(DgvUsuario.FocusedRowHandle, ColIdUsuario))
        MostrarPermisosPermitidos(CInt(DgvUsuario.GetRowCellValue(DgvUsuario.FocusedRowHandle, ColIdUsuario)))
        MostrarPermisosDenegados(CInt(DgvUsuario.GetRowCellValue(DgvUsuario.FocusedRowHandle, ColIdUsuario)))
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        MostrarUsuario()
    End Sub
End Class