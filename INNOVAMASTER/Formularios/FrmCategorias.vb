Imports System.Data.SqlClient
Imports DevExpress.XtraEditors

Public Class FrmCategoria
    Dim dt As New DataTable
    Public var As Integer = 0
    Private Sub FrmCategorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarCategoria()
        GbDatos.Enabled = False
        TxtIdCategoria.Enabled = False
        GCPrincipal.Enabled = True

        Dim NombreArchivo As String = HTMLHelpClass.GetLocalHelpFileName("InnovaMasterAyuda2017.chm")
        HelpProvider1.HelpNamespace = NombreArchivo
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "Categoría")
    End Sub
    Private Sub MostrarCategoria()
        Try
            Dim datos As New Fcategoria
            dt = datos.MostrarCategoria

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
        TxtIdCategoria.EditValue = Nothing
        TxtCategoria.EditValue = Nothing
        BtnNuevo.Visible = False
        BtnEditar.Visible = False
        BtnInsertar.Visible = True
        BtnCancelar.Visible = True
        GCPrincipal.Enabled = False



    End Sub
    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If TxtIdCategoria.Text <> Nothing Then

            GbDatos.Enabled = True
            BtnNuevo.Visible = False
            BtnEditar.Visible = False
            BtnActualizar.Visible = True
            BtnCancelar.Visible = True
            BtnInsertar.Visible = False
            TxtIdCategoria.Visible = True
            GbDatos.Enabled = True
            GCPrincipal.Enabled = False


        Else
            XtraMessageBox.Show("Seleccione la Categoria a Actualizar", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If



    End Sub
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click

        Dim r As DialogResult = XtraMessageBox.Show("¿Desea Cancelar el Proceso?", "INNOVAMASTER ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If r = DialogResult.Yes Then
            GbDatos.Enabled = False
            TxtIdCategoria.EditValue = Nothing
            TxtCategoria.EditValue = Nothing
            BtnNuevo.Visible = True
            BtnEditar.Visible = True
            BtnInsertar.Visible = False
            BtnCancelar.Visible = False
            BtnActualizar.Visible = False
            GCPrincipal.Enabled = True


        End If

    End Sub
    Private Sub Btninsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        If TxtCategoria.Text = Nothing Then

            XtraMessageBox.Show("Ingrese el Nombre de la Categoría", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtCategoria.Focus()
        Else
            Try

                Dim datos As New DatosProfesion
                Dim funcion As New Fcategoria

                datos.gcategoria = TxtCategoria.Text

                If funcion.Insertar(datos) Then
                    XtraMessageBox.Show("Categoria Insertada con Exito", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    GbDatos.Enabled = False
                    TxtIdCategoria.EditValue = Nothing
                    TxtCategoria.EditValue = Nothing
                    BtnNuevo.Visible = True
                    BtnEditar.Visible = True
                    BtnInsertar.Visible = False
                    BtnCancelar.Visible = False
                    BtnActualizar.Visible = False
                    GCPrincipal.Enabled = True

                    MostrarCategoria()


                End If

            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try
        End If


    End Sub
    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If TxtCategoria.Text = Nothing Then

            XtraMessageBox.Show("Ingrese el Nombre de la Categoría", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtCategoria.Focus()
        Else
            Try

                Dim datos As New DatosProfesion
                Dim funcion As New Fcategoria

                datos.gcategoria = TxtCategoria.Text
                datos.gidcategoria = TxtIdCategoria.Text

                If funcion.Actualizar(datos) Then
                    XtraMessageBox.Show("Categoria Actualizada con Exito", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    GbDatos.Enabled = False
                    TxtIdCategoria.EditValue = Nothing
                    TxtCategoria.EditValue = Nothing
                    BtnNuevo.Visible = True
                    BtnEditar.Visible = True
                    BtnInsertar.Visible = False
                    BtnCancelar.Visible = False
                    BtnActualizar.Visible = False
                    GCPrincipal.Enabled = True

                    MostrarCategoria()


                End If

            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try
        End If


    End Sub


    Private Sub GCPrincipal_Click(sender As Object, e As EventArgs) Handles GCPrincipal.Click
        Dim index As Integer = DgvCategoria.FocusedRowHandle
        TxtIdCategoria.EditValue = DgvCategoria.GetRowCellValue(index, ColIdCategoria)
        TxtCategoria.EditValue = DgvCategoria.GetRowCellValue(index, ColCategoria)

    End Sub

    Private Sub GCPrincipal_DoubleClick(sender As Object, e As EventArgs) Handles GCPrincipal.DoubleClick
        If var = 1 Then
            FrmProducto.LlenarCombos()
            FrmProducto.CboCategoria.Text = DgvCategoria.GetRowCellValue(DgvCategoria.FocusedRowHandle, ColCategoria)
            Me.Close()
        End If
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
        MostrarCategoria()
    End Sub

    Private Sub DgvCategoria_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles DgvCategoria.FocusedRowChanged
        Dim index As Integer = DgvCategoria.FocusedRowHandle
        TxtIdCategoria.EditValue = DgvCategoria.GetRowCellValue(index, ColIdCategoria)
        TxtCategoria.EditValue = DgvCategoria.GetRowCellValue(index, ColCategoria)

    End Sub
End Class