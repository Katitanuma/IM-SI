Imports System.Data.SqlClient
Imports DevExpress.XtraEditors

Public Class FrmPais
    Dim dt As New DataTable
    Dim conec As New Conexion
    Public var As Integer = 0
    Private Sub FrmPais_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MostrarPais()
        GboPais.Enabled = False

        Dim NombreArchivo As String = HTMLHelpClass.GetLocalHelpFileName("InnovaMasterAyuda2017.chm")
        HelpProvider1.HelpNamespace = NombreArchivo
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "País")

    End Sub
    Private Sub MostrarPais()
        Try
            Dim datos As New FPais
            dt = datos.MostrarPais

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
        GboPais.Enabled = True
        TxtIdPais.EditValue = Nothing
        TxtPais.EditValue = Nothing
        GCPrincipal.Enabled = False
        BtnInsertar.Visible = True
        BtnCancelar.Visible = True
        BtnNuevo.Visible = False
        BtnEditar.Visible = False
        BtnActualizar.Visible = False
        TxtIdPais.Enabled = False
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If TxtIdPais.Text = Nothing Then
            XtraMessageBox.Show("Seleccione el País a Actualizar", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            BtnNuevo.Visible = False
            BtnEditar.Visible = False
            BtnInsertar.Visible = False
            BtnCancelar.Visible = True
            BtnActualizar.Visible = True
            GCPrincipal.Enabled = False
            GboPais.Enabled = True
            TxtIdPais.Enabled = False
        End If
    End Sub
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim r As DialogResult = XtraMessageBox.Show("¿Desea Cancelar el Proceso?", "INNOVAMASTER ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If r = DialogResult.Yes Then
            GboPais.Enabled = False
            TxtIdPais.EditValue = Nothing
            TxtPais.EditValue = Nothing
            BtnNuevo.Visible = True
            BtnEditar.Visible = True
            BtnInsertar.Visible = False
            BtnCancelar.Visible = False
            BtnActualizar.Visible = False
            GCPrincipal.Enabled = True
            MostrarPais()

        End If

    End Sub

    Private Sub Btninsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        If TxtPais.Text = Nothing Then
            XtraMessageBox.Show("Ingrese el País", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtPais.Focus()
        Else
            Try
                conec.Conectarse()
                Dim datos As New DatosPais
                Dim funcion As New FPais

                datos.gPais = TxtPais.Text


                If funcion.Insertar(datos) Then
                    XtraMessageBox.Show("Pais Insertado con éxito", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    GboPais.Enabled = False
                    TxtIdPais.EditValue = Nothing
                    TxtPais.EditValue = Nothing

                    BtnNuevo.Visible = True
                    BtnEditar.Visible = True
                    BtnInsertar.Visible = False
                    BtnCancelar.Visible = False
                    BtnActualizar.Visible = False
                    GCPrincipal.Enabled = True

                    MostrarPais()


                End If

            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try
        End If
    End Sub
    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If TxtPais.Text = Nothing Then
            XtraMessageBox.Show("Ingrese el Nombre del País", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtPais.Focus()

        Else
            Try
                conec.Conectarse()
                Dim datos As New DatosPais
                Dim funcion As New FPais

                datos.gPais = TxtPais.Text
                datos.gIdPais = Int(TxtIdPais.Text)


                If funcion.Actualizar(datos) Then
                    XtraMessageBox.Show("País Modificado con éxito", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    GboPais.Enabled = False
                    TxtIdPais.EditValue = Nothing
                    TxtPais.EditValue = Nothing

                    BtnNuevo.Visible = True
                    BtnEditar.Visible = True
                    BtnInsertar.Visible = False
                    BtnCancelar.Visible = False
                    BtnActualizar.Visible = False
                    GCPrincipal.Enabled = True

                    MostrarPais()


                End If

            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try
        End If


    End Sub



    Private Sub GCPrincipal_Click(sender As Object, e As EventArgs) Handles GCPrincipal.Click
        TxtIdPais.EditValue = DgvPais.GetRowCellValue(DgvPais.FocusedRowHandle, ColIdPais)
        TxtPais.EditValue = DgvPais.GetRowCellValue(DgvPais.FocusedRowHandle, ColPais)
    End Sub

    Private Sub GCPrincipal_DoubleClick(sender As Object, e As EventArgs) Handles GCPrincipal.DoubleClick
        If var = 1 Then
            FrmDepartamento.LlenarComboboxPais()
            FrmDepartamento.CboPais.Text = DgvPais.GetRowCellValue(DgvPais.FocusedRowHandle, ColPais)
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
        MostrarPais()
    End Sub

    Private Sub DgvPais_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles DgvPais.FocusedRowChanged
        TxtIdPais.EditValue = DgvPais.GetRowCellValue(DgvPais.FocusedRowHandle, ColIdPais)
        TxtPais.EditValue = DgvPais.GetRowCellValue(DgvPais.FocusedRowHandle, ColPais)
    End Sub
End Class