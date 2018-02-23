Imports System.Data.SqlClient
Public Class FrmPExistencia
    Dim conec As New Conexion
    Private Sub FrmPExistencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        Try
            conec.Conectarse()
            Dim da As New SqlDataAdapter("Sp_ProductosBajaExistencia", conec.Con)
            da.Fill(dt)
            GCPrincipal.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conec.Desconectarse()
        End Try
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Dim dt As New DataTable
        Try
            conec.Conectarse()
            Dim da As New SqlDataAdapter("Sp_ProductosBajaExistencia", conec.Con)
            da.Fill(dt)
            GCPrincipal.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conec.Desconectarse()
        End Try
    End Sub

    Private Sub BtnExportarPDF_Click(sender As Object, e As EventArgs) Handles BtnExportarPDF.Click
        Exportar_a_PDF(GCPrincipal, Me.Text)
    End Sub

    Private Sub BtnExportarExcel_Click(sender As Object, e As EventArgs) Handles BtnExportarExcel.Click
        Exportar_a_Excel(GCPrincipal, Me.Text)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        GCPrincipal.ShowPrintPreview()
    End Sub
End Class