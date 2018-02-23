Imports DevExpress.XtraEditors

Public Class frmCargo
    Dim dt As New DataTable
    Public var As Integer = 0
    Private Sub frmCargo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarCargo()
        GbDatos.Enabled = False
        TxtIdCargo.Enabled = False
        GCPrincipal.Enabled = True

        Dim NombreArchivo As String = HTMLHelpClass.GetLocalHelpFileName("InnovaMasterAyuda2017.chm")
        HelpProvider1.HelpNamespace = NombreArchivo
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "Cargo Empleado")
    End Sub
    Private Sub MostrarCargo()
        Try
            Dim datos As New Fcargo
            dt = datos.MostrarCargo
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
        TxtIdCargo.EditValue = Nothing
        TxtCargo.EditValue = Nothing
        BtnNuevo.Visible = False
        BtnEditar.Visible = False
        BtnInsertar.Visible = True
        BtnCancelar.Visible = True
        GCPrincipal.Enabled = False
    End Sub
    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If TxtIdCargo.Text <> Nothing Then
            GbDatos.Enabled = True
            BtnNuevo.Visible = False
            BtnEditar.Visible = False
            BtnActualizar.Visible = True
            BtnCancelar.Visible = True
            BtnInsertar.Visible = False
            TxtIdCargo.Visible = True
            GbDatos.Enabled = True
            GCPrincipal.Enabled = False
        Else
            XtraMessageBox.Show("Seleccione el cargo a actualizar", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim r As DialogResult = XtraMessageBox.Show("¿Desea cancelar el proceso?", "INNOVAMASTER ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If r = DialogResult.Yes Then
            GbDatos.Enabled = False
            TxtIdCargo.EditValue = Nothing
            TxtCargo.EditValue = Nothing
            BtnNuevo.Visible = True
            BtnEditar.Visible = True
            BtnInsertar.Visible = False
            BtnCancelar.Visible = False
            BtnActualizar.Visible = False
            GCPrincipal.Enabled = True


        End If

    End Sub
    Private Sub Btninsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        If TxtCargo.Text = Nothing Then

            XtraMessageBox.Show("Ingrese el Nombre del Cargo", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtCargo.Focus()
        Else
            Try

                Dim datos As New DatosCargo
                Dim funcion As New Fcargo

                datos.gcargo = TxtCargo.Text

                If funcion.InsertarCargo(datos) Then
                    XtraMessageBox.Show("Cargo insertado con éxito", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    GbDatos.Enabled = False
                    TxtIdCargo.EditValue = Nothing
                    TxtCargo.EditValue = Nothing
                    BtnNuevo.Visible = True
                    BtnEditar.Visible = True
                    BtnInsertar.Visible = False
                    BtnCancelar.Visible = False
                    BtnActualizar.Visible = False
                    GCPrincipal.Enabled = True

                    MostrarCargo()
                End If

            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try
        End If
    End Sub
    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If TxtCargo.Text = Nothing Then

            XtraMessageBox.Show("Ingrese el Nombre del Cargo", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtCargo.Focus()
        Else
            Try

                Dim datos As New DatosCargo
                Dim funcion As New Fcargo

                datos.gcargo = TxtCargo.Text
                datos.gidcargo = TxtIdCargo.Text

                If funcion.Actualizar(datos) Then
                    XtraMessageBox.Show("Cargo actualizado con éxito", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    GbDatos.Enabled = False
                    TxtIdCargo.EditValue = Nothing
                    TxtCargo.EditValue = Nothing
                    BtnNuevo.Visible = True
                    BtnEditar.Visible = True
                    BtnInsertar.Visible = False
                    BtnCancelar.Visible = False
                    BtnActualizar.Visible = False
                    GCPrincipal.Enabled = True

                    MostrarCargo()
                End If

            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try
        End If


    End Sub

    Private Sub GCPrincipal_Click(sender As Object, e As EventArgs) Handles GCPrincipal.Click
        Dim index As Integer = DgvCargo.FocusedRowHandle
        TxtIdCargo.EditValue = DgvCargo.GetRowCellValue(index, ColIdCargo)
        TxtCargo.EditValue = DgvCargo.GetRowCellValue(index, ColCargo)
    End Sub

    Private Sub GCPrincipal_DoubleClick(sender As Object, e As EventArgs) Handles GCPrincipal.DoubleClick
        If var = 1 Then
            FrmEmpleado.LlenarComboCargo()
            FrmEmpleado.CboCargo.Text = DgvCargo.GetRowCellValue(DgvCargo.FocusedRowHandle, ColCargo)
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
        MostrarCargo()
    End Sub

    Private Sub DgvCargo_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles DgvCargo.FocusedRowChanged
        Dim index As Integer = DgvCargo.FocusedRowHandle
        TxtIdCargo.EditValue = DgvCargo.GetRowCellValue(index, ColIdCargo)
        TxtCargo.EditValue = DgvCargo.GetRowCellValue(index, ColCargo)
    End Sub
End Class