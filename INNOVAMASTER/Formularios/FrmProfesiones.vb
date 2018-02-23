Imports System.Data.SqlClient
Imports DevExpress.XtraEditors

Public Class FrmProfesiones
    Dim dt As New DataTable
    Public var As Integer = 0
    Private Sub FrmProfesiones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarProfesiones()
        GbDatos.Enabled = False
        TxtIdProfesion.Enabled = False
        GCPrincipal.Enabled = True

        Dim NombreArchivo As String = HTMLHelpClass.GetLocalHelpFileName("InnovaMasterAyuda2017.chm")
        HelpProvider1.HelpNamespace = NombreArchivo
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "Profesión")
    End Sub

    Private Sub MostrarProfesiones()
        Try
            Dim datos As New FProfesiones
            dt = datos.MostrarProfesion

            If dt.Rows.Count <> 0 Then
                LblFilas.Visible = False
                GCPrincipal.DataSource = dt

            Else
                LblFilas.Visible = True
                GCPrincipal.DataSource = Nothing

            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        GbDatos.Enabled = True
        TxtIdProfesion.EditValue = Nothing
        TxtProfesion.EditValue = Nothing
        BtnNuevo.Visible = False
        BtnEditar.Visible = False
        BtnInsertar.Visible = True
        BtnCancelar.Visible = True
        GCPrincipal.Enabled = False



    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If TxtIdProfesion.Text <> Nothing Then

            GbDatos.Enabled = True
            BtnNuevo.Visible = False
            BtnEditar.Visible = False
            BtnActualizar.Visible = True
            BtnCancelar.Visible = True
            BtnInsertar.Visible = False
            TxtIdProfesion.Visible = True
            GbDatos.Enabled = True
            GCPrincipal.Enabled = False


        Else
            XtraMessageBox.Show("Seleccione la Profesion a Actualizar", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If



    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim r As DialogResult = XtraMessageBox.Show("¿Desea Cancelar el Proceso?", "INNOVAMASTER ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If r = DialogResult.Yes Then
            GbDatos.Enabled = False
            TxtIdProfesion.EditValue = Nothing
            TxtProfesion.EditValue = Nothing
            BtnNuevo.Visible = True
            BtnEditar.Visible = True
            BtnInsertar.Visible = False
            BtnCancelar.Visible = False
            BtnActualizar.Visible = False
            GCPrincipal.Enabled = True


        End If

    End Sub

    Private Sub Btninsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        If TxtProfesion.Text = Nothing Then

            XtraMessageBox.Show("Ingrese el Nombre de la Profesion", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtProfesion.Focus()
        Else
            Try

                Dim datos As New DatosProfesiones
                Dim funcion As New FProfesiones

                datos.gprofesion = TxtProfesion.Text

                If funcion.Insertar(datos) Then
                    XtraMessageBox.Show("Profesion Insertada con éxito", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    GbDatos.Enabled = False
                    TxtIdProfesion.EditValue = Nothing
                    TxtProfesion.EditValue = Nothing
                    BtnNuevo.Visible = True
                    BtnEditar.Visible = True
                    BtnInsertar.Visible = False
                    BtnCancelar.Visible = False
                    BtnActualizar.Visible = False
                    GCPrincipal.Enabled = True

                    MostrarProfesiones()


                End If

            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try
        End If


    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If TxtProfesion.Text = Nothing Then

            XtraMessageBox.Show("Ingrese el Nombre de la profesion", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtProfesion.Focus()
        Else
            Try

                Dim datos As New DatosProfesiones
                Dim funcion As New FProfesiones

                datos.gprofesion = TxtProfesion.Text
                datos.gidprofesion = TxtIdProfesion.Text

                If funcion.Actualizar(datos) Then
                    XtraMessageBox.Show("Profesion Insertada con éxito", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    GbDatos.Enabled = False
                    TxtIdProfesion.EditValue = Nothing
                    TxtProfesion.EditValue = Nothing
                    BtnNuevo.Visible = True
                    BtnEditar.Visible = True
                    BtnInsertar.Visible = False
                    BtnCancelar.Visible = False
                    BtnActualizar.Visible = False
                    GCPrincipal.Enabled = True

                    MostrarProfesiones()


                End If

            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try
        End If


    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Exportar_a_Excel(GCPrincipal, Me.Text)
    End Sub

    Private Sub GCPrincipal_Click(sender As Object, e As EventArgs) Handles GCPrincipal.Click
        Dim index As Integer = DgvProfesion.FocusedRowHandle
        TxtIdProfesion.EditValue = DgvProfesion.GetRowCellValue(index, ColIdProfesion)
        TxtProfesion.EditValue = DgvProfesion.GetRowCellValue(index, ColProfesion)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        GCPrincipal.ShowPrintPreview()
    End Sub

    Private Sub GCPrincipal_DoubleClick(sender As Object, e As EventArgs) Handles GCPrincipal.DoubleClick
        If var = 1 Then
            FrmEmpleado.LlenarComboProfesion()
            FrmEmpleado.CboProfesion.Text = DgvProfesion.GetRowCellValue(DgvProfesion.FocusedRowHandle, ColProfesion)
            Me.Close()
        End If
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Exportar_a_PDF(GCPrincipal, Me.Text)
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        MostrarProfesiones()
    End Sub
End Class