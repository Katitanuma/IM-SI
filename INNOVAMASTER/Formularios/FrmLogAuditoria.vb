Imports System.Data.SqlClient
Public Class FrmLogAuditoria
    Dim conec As New Conexion
    Private Sub MostrarTodosLogAuditoria()

        Using cmd As New SqlCommand
            Try
                conec.Conectarse()

                With cmd
                    .CommandText = "Sp_MostrarTodoLogAuditoria"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = conec.Con
                End With

                Dim AdaptadorLog As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorLog.Fill(dt)
                GCPrincipal.DataSource = dt

            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos del log de auditoria" + ex.Message)
            Finally
                conec.Conectarse()
            End Try

        End Using
    End Sub


    Private Sub FrmLogAuditoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarTodosLogAuditoria()

        Dim NombreArchivo As String = HTMLHelpClass.GetLocalHelpFileName("InnovaMasterAyuda2017.chm")
        HelpProvider1.HelpNamespace = NombreArchivo
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "Auditoría")
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Exportar_a_Excel(GCPrincipal, Me.Text)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        GCPrincipal.ShowPrintPreview()
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Exportar_a_PDF(GCPrincipal, Me.Text)
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        MostrarTodosLogAuditoria()
    End Sub


End Class