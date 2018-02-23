Imports System.ComponentModel
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors

Public Class FrmDepartamento
    Dim dt As New DataTable
    Dim conec As New Conexion
    Public var As Integer = 0
    Private Sub FrmDepartamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarDepartamento()
        GbDepartamento.Enabled = False
        TxtIdDepartamento.Enabled = False
        GCPrincipal.Enabled = True
        Call LlenarComboboxPais()

        Dim NombreArchivo As String = HTMLHelpClass.GetLocalHelpFileName("InnovaMasterAyuda2017.chm")
        HelpProvider1.HelpNamespace = NombreArchivo
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "Departamento")
    End Sub

    Private Sub MostrarDepartamento()
        Try
            Dim datos As New FDepartamento
            dt = datos.MostrarDepartamento

            If dt.Rows.Count <> 0 Then
                LblFilas.Visible = False
                GCPrincipal.DataSource = dt

            Else
                LblFilas.Visible = True
                GCPrincipal.DataSource = Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub LlenarComboboxPais()
        Dim _DT As New DataTable
        Dim DA As SqlDataAdapter

        Try
            conec.Conectarse()
            Dim cmd As New SqlCommand
            cmd = New SqlCommand("MostrarPais")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conec.Con

            If cmd.ExecuteNonQuery Then
                DA = New SqlDataAdapter(cmd)
                DA.Fill(_DT)
                CboPais.Properties.DataSource = _DT
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            conec.Desconectarse()
        End Try

    End Sub





    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        GbDepartamento.Enabled = True
        TxtIdDepartamento.EditValue = Nothing
        TxtDepartamento.EditValue = Nothing
        CboPais.EditValue = Nothing
        BtnNuevo.Visible = False
        BtnEditar.Visible = False
        BtnInsertar.Visible = True
        BtnCancelar.Visible = True
        GCPrincipal.Enabled = False
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If TxtIdDepartamento.Text <> Nothing Then

            GbDepartamento.Enabled = True
            BtnNuevo.Visible = False
            BtnEditar.Visible = False
            BtnActualizar.Visible = True
            BtnCancelar.Visible = True
            BtnInsertar.Visible = False
            TxtIdDepartamento.Visible = True
            GCPrincipal.Enabled = False


        Else
            XtraMessageBox.Show("Seleccione el Departamento a Actualizar", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click

        If TxtDepartamento.Text = Nothing Then
            XtraMessageBox.Show("Ingrese el Nombre del Departamento", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtDepartamento.Focus()
        ElseIf CboPais.EditValue = Nothing Then
            XtraMessageBox.Show("Seleccione el País", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else
            Try
                conec.Conectarse()
                Dim datos As New DatosDepartamento
                Dim funcion As New FDepartamento

                datos.gDepartamento = TxtDepartamento.Text
                datos.gIdDepartamento = CInt(TxtIdDepartamento.Text)


                datos.gIdPais = CInt(CboPais.EditValue)



                If funcion.Actualizar(datos) Then
                    XtraMessageBox.Show("Departamento Modificado con Exito", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    GbDepartamento.Enabled = False
                    TxtIdDepartamento.EditValue = Nothing
                    TxtDepartamento.EditValue = Nothing
                    CboPais.EditValue = Nothing
                    BtnNuevo.Visible = True
                    BtnEditar.Visible = True
                    BtnInsertar.Visible = False
                    BtnCancelar.Visible = False
                    BtnActualizar.Visible = False
                    GCPrincipal.Enabled = True

                    MostrarDepartamento()

                End If

            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim r As DialogResult = XtraMessageBox.Show("¿Desea Cancelar el Proceso?", "INNOVAMASTER ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If r = DialogResult.Yes Then
            GbDepartamento.Enabled = False
            TxtIdDepartamento.EditValue = Nothing
            TxtDepartamento.EditValue = Nothing
            CboPais.EditValue = Nothing
            BtnNuevo.Visible = True
            BtnEditar.Visible = True
            BtnInsertar.Visible = False
            BtnCancelar.Visible = False
            BtnActualizar.Visible = False
            GCPrincipal.Enabled = True

        End If
    End Sub

    Private Sub Btninsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        If TxtDepartamento.Text = Nothing Then
            XtraMessageBox.Show("Ingrese el Nombre del Departamento", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtDepartamento.Focus()
        ElseIf CboPais.EditValue = Nothing Then
            XtraMessageBox.Show("Seleccione el País", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else
            Try
                conec.Conectarse()
                Dim datos As New DatosDepartamento
                Dim funcion As New FDepartamento

                datos.gDepartamento = TxtDepartamento.Text
                datos.gIdPais = CInt(CboPais.EditValue)

                If funcion.Insertar(datos) Then
                    XtraMessageBox.Show("Departamento Insertado con Exito", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    GbDepartamento.Enabled = False
                    TxtIdDepartamento.EditValue = Nothing
                    TxtDepartamento.EditValue = Nothing
                    CboPais.EditValue = Nothing
                    BtnNuevo.Visible = True
                    BtnEditar.Visible = True
                    BtnInsertar.Visible = False
                    BtnCancelar.Visible = False
                    BtnActualizar.Visible = False
                    GCPrincipal.Enabled = True

                    MostrarDepartamento()


                End If

            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try
        End If
    End Sub





    Private Sub BtnBusquedaCliente_Click(sender As Object, e As EventArgs) Handles BtnBusquedaCliente.Click
        With FrmPais
            FrmPais.var = 1
            .MdiParent = MenuPrincipal
            .Dock = DockStyle.Fill
            .Show()
        End With
    End Sub

    Private Sub GCPrincipal_DoubleClick(sender As Object, e As EventArgs) Handles GCPrincipal.DoubleClick
        If var = 1 Then
            FrmMunicipio.LlenarComboboxDepartamento()
            FrmMunicipio.CboDepartamento.Text = DgvDepartamento.GetRowCellValue(DgvDepartamento.FocusedRowHandle, ColDepartamento)
            Me.Close()
        End If
    End Sub

    Private Sub GCPrincipal_Click(sender As Object, e As EventArgs) Handles GCPrincipal.Click
        Dim index As Integer = DgvDepartamento.FocusedRowHandle
        TxtIdDepartamento.EditValue = DgvDepartamento.GetRowCellValue(index, ColIdDepartamento)
        TxtDepartamento.EditValue = DgvDepartamento.GetRowCellValue(index, ColDepartamento)
        CboPais.Text = DgvDepartamento.GetRowCellValue(index, ColPais)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        GCPrincipal.ShowPrintPreview()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Exportar_a_Excel(GCPrincipal, Me.Text)
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Exportar_a_PDF(GCPrincipal, Me.Text)
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        MostrarDepartamento()
    End Sub

    Private Sub DgvDepartamento_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles DgvDepartamento.FocusedRowChanged
        Dim index As Integer = DgvDepartamento.FocusedRowHandle
        TxtIdDepartamento.EditValue = DgvDepartamento.GetRowCellValue(index, ColIdDepartamento)
        TxtDepartamento.EditValue = DgvDepartamento.GetRowCellValue(index, ColDepartamento)
        CboPais.Text = DgvDepartamento.GetRowCellValue(index, ColPais)
    End Sub
End Class