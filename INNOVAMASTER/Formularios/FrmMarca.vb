Imports System.Data.SqlClient
Imports DevExpress.XtraEditors

Public Class FrmMarca

    Dim dt As New DataTable
    Public var As Integer = 0
    Private Sub FrmMarca_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MostrarMarca()
        GbMarca.Enabled = False
        TxtIdMarca.Enabled = False
        GCPrincipal.Enabled = True

        Dim NombreArchivo As String = HTMLHelpClass.GetLocalHelpFileName("InnovaMasterAyuda2017.chm")
        HelpProvider1.HelpNamespace = NombreArchivo
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "Marca")

    End Sub
    Private Sub MostrarMarca()
        Try
            Dim datos As New FMarca
            dt = datos.MostrarMarca

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
        GbMarca.Enabled = True
        TxtIdMarca.EditValue = Nothing
        TxtMarca.EditValue = Nothing
        BtnNuevo.Visible = False
        BtnEditar.Visible = False
        BtnInsertar.Visible = True
        BtnCancelar.Visible = True
        GCPrincipal.Enabled = False

    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If TxtMarca.Text <> Nothing Then

            GbMarca.Enabled = True
            BtnNuevo.Visible = False
            BtnEditar.Visible = False
            BtnActualizar.Visible = True
            BtnCancelar.Visible = True
            BtnInsertar.Visible = False
            TxtIdMarca.Visible = True
            GbMarca.Enabled = True
            GCPrincipal.Enabled = False


        Else
            XtraMessageBox.Show("Seleccione la Marca a Actualizar", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If



    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim r As DialogResult = XtraMessageBox.Show("¿Desea Cancelar el Proceso?", "INNOVAMASTER ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If r = DialogResult.Yes Then
            GbMarca.Enabled = False
            BtnNuevo.Visible = False
            BtnEditar.Visible = False
            BtnNuevo.Visible = True
            BtnEditar.Visible = True
            BtnInsertar.Visible = False
            BtnCancelar.Visible = False
            BtnActualizar.Visible = False
            GCPrincipal.Enabled = True


        End If

    End Sub

    Private Sub Btninsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        If TxtMarca.Text = Nothing Then

            XtraMessageBox.Show("Ingrese el Nombre de la Marca", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtMarca.Focus()
        Else
            Try

                Dim datos As New DatosMarca
                Dim funcion As New FMarca

                datos.gMarca = TxtMarca.EditValue

                If funcion.Insertar(datos) Then
                    XtraMessageBox.Show("Marca Insertada con éxito", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    GbMarca.Enabled = False
                    BtnNuevo.Visible = False
                    BtnEditar.Visible = False
                    BtnNuevo.Visible = True
                    BtnEditar.Visible = True
                    BtnInsertar.Visible = False
                    BtnCancelar.Visible = False
                    BtnActualizar.Visible = False
                    GCPrincipal.Enabled = True

                    MostrarMarca()


                End If

            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try
        End If


    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If TxtMarca.Text = Nothing Then

            XtraMessageBox.Show("Ingrese el Nombre de la Marca", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtMarca.Focus()
        Else
            Try

                Dim datos As New DatosMarca
                Dim funcion As New FMarca

                datos.gMarca = TxtMarca.EditValue
                datos.gIdMarca = TxtIdMarca.EditValue

                If funcion.Actualizar(datos) Then
                    XtraMessageBox.Show("Marca Actulizada con éxito", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    GbMarca.Enabled = False
                    BtnNuevo.Visible = False
                    BtnEditar.Visible = False
                    BtnNuevo.Visible = True
                    BtnEditar.Visible = True
                    BtnInsertar.Visible = False
                    BtnCancelar.Visible = False
                    BtnActualizar.Visible = False
                    GCPrincipal.Enabled = True

                    MostrarMarca()

                End If

            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try
        End If


    End Sub

    Private Sub GCPrincipal_Click(sender As Object, e As EventArgs) Handles GCPrincipal.Click
        Dim index As Integer = DgvMarca.FocusedRowHandle
        TxtIdMarca.EditValue = DgvMarca.GetRowCellValue(index, ColIdMarca)
        TxtMarca.EditValue = DgvMarca.GetRowCellValue(index, ColMarca)

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
        MostrarMarca()
    End Sub

    Private Sub DgvMarca_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles DgvMarca.FocusedRowChanged
        Dim index As Integer = DgvMarca.FocusedRowHandle
        TxtIdMarca.EditValue = DgvMarca.GetRowCellValue(index, ColIdMarca)
        TxtMarca.EditValue = DgvMarca.GetRowCellValue(index, ColMarca)
    End Sub
End Class