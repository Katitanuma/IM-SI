Imports System.ComponentModel
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors

Public Class FrmMunicipio

    Dim dt As New DataTable
    Dim conec As New Conexion

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public var As Integer = 0
    Private Sub FrmModelo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MostrarMunicipio()
        GbMunicipio.Enabled = False
        TxtIdMunicipio.Enabled = False
        GCPrincipal.Enabled = True
        Call LlenarComboboxDepartamento()

        Dim NombreArchivo As String = HTMLHelpClass.GetLocalHelpFileName("InnovaMasterAyuda2017.chm")
        HelpProvider1.HelpNamespace = NombreArchivo
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "Municipio")

    End Sub
    Private Sub MostrarMunicipio()
        Try
            Dim datos As New FMunicipio
            dt = datos.MostrarMunicipio

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

    'Private Sub DgvMunicipio_CellClick(sender As Object, e As DataGridViewCellEventArgs)
    '    TxtIdMunicipio.Text = DgvMunicipio.SelectedCells.Item(0).Value
    '    TxtMunicipio.Text = DgvMunicipio.SelectedCells.Item(1).Value
    '    CboDepartamento.Text = DgvMunicipio.SelectedCells.Item(2).Value
    'End Sub
    Public Sub LlenarComboboxDepartamento()
        Dim da As SqlDataAdapter
        Dim _DT As New DataTable
        Try
            conec.Conectarse()
            Dim cmd As New SqlCommand
            cmd = New SqlCommand("MostrarDepartamento")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conec.Con


            If cmd.ExecuteNonQuery Then
                da = New SqlDataAdapter(cmd)
                da.Fill(_DT)
                CboDepartamento.Properties.DataSource = _DT
                'LookUpEdit1.Properties.DataSource = _DT
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            conec.Desconectarse()
        End Try

    End Sub

    'Private Sub DgvMunicipio_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
    '    If var = 1 Then
    '        FrmCliente.LlenarComboMunicipio()
    '        FrmCliente.CboMunicipio.Text = DgvMunicipio.CurrentRow.Cells(1).Value.ToString
    '        Me.Close()
    '    ElseIf var = 2 Then
    '        FrmEmpleado.LlenarComboMunicipio()
    '        FrmEmpleado.CmbMunicipio.Text = DgvMunicipio.CurrentRow.Cells(1).Value.ToString
    '        Me.Close()
    '    ElseIf var = 3 Then
    '        FrmProveedor.LlenarComboMunicipio()
    '        FrmProveedor.CboMunicipio.Text = DgvMunicipio.CurrentRow.Cells(1).Value.ToString
    '        Me.Close()
    '    End If
    'End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        With FrmDepartamento
            FrmDepartamento.var = 1
            .MdiParent = FrmMenuPrincipal
            .Dock = DockStyle.Fill
            .Show()
        End With
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        'GCPrincipal.ShowPrintPreview()

        PrintableComponentLink1.CreateDocument()
        PrintableComponentLink1.ShowPreview()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Exportar_a_Excel(GCPrincipal, Me.Text)
    End Sub

    Private Sub GCPrincipal_DoubleClick(sender As Object, e As EventArgs) Handles GCPrincipal.DoubleClick
        If var = 1 Then
            FrmCliente.LlenarComboMunicipio()
            FrmCliente.CboMunicipio.Text = DgvMunicipio.GetRowCellValue(DgvMunicipio.FocusedRowHandle, ColMunicipio)
            Me.Close()
        ElseIf var = 2 Then
            FrmEmpleado.LlenarComboMunicipio()
            FrmEmpleado.CmbMunicipio.Text = DgvMunicipio.GetRowCellValue(DgvMunicipio.FocusedRowHandle, ColMunicipio)
            Me.Close()
        ElseIf var = 3 Then
            FrmProveedor.LlenarComboMunicipio()
            FrmProveedor.CboMunicipio.Text = DgvMunicipio.GetRowCellValue(DgvMunicipio.FocusedRowHandle, ColMunicipio)
            Me.Close()
        End If
    End Sub

    Private Sub GCPrincipal_Click(sender As Object, e As EventArgs) Handles GCPrincipal.Click
        Dim FilaActual As Integer = DgvMunicipio.FocusedRowHandle
        TxtIdMunicipio.Text = DgvMunicipio.GetRowCellValue(DgvMunicipio.FocusedRowHandle, ColIdMunicipio)
        TxtMunicipio.Text = DgvMunicipio.GetRowCellValue(FilaActual, ColMunicipio)
        CboDepartamento.Text = DgvMunicipio.GetRowCellValue(FilaActual, ColDepartamento)
    End Sub

    Private Sub BtnNuevo_Click_1(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        GbMunicipio.Enabled = True
        TxtIdMunicipio.EditValue = Nothing
        TxtMunicipio.EditValue = Nothing
        CboDepartamento.EditValue = Nothing
        BtnNuevo.Visible = False
        BtnEditar.Visible = False
        BtnInsertar.Visible = True
        BtnCancelar.Visible = True
        GCPrincipal.Enabled = False
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If TxtIdMunicipio.Text <> Nothing Then
            GbMunicipio.Enabled = True
            BtnNuevo.Visible = False
            BtnEditar.Visible = False
            BtnActualizar.Visible = True
            BtnCancelar.Visible = True
            BtnInsertar.Visible = False
            TxtIdMunicipio.Visible = True
            GCPrincipal.Enabled = False
        Else
            XtraMessageBox.Show("Seleccione el Municipio a Actualizar", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnInsertar_Click_1(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        If TxtMunicipio.Text = Nothing Then
            XtraMessageBox.Show("Ingrese el Nombre del Municipio", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtMunicipio.Focus()
        ElseIf CboDepartamento.EditValue = Nothing Then
            XtraMessageBox.Show("Seleccione el Departamento del Municipio", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else
            Try
                conec.Conectarse()
                Dim datos As New DatosMunicipio
                Dim funcion As New FMunicipio

                datos.gMunicipio = TxtMunicipio.EditValue

                datos.gIdDepartamento = CInt(CboDepartamento.EditValue)

                If funcion.Insertar(datos) Then
                    XtraMessageBox.Show("Municipio Insertado con éxito", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    GbMunicipio.Enabled = False
                    TxtIdMunicipio.EditValue = Nothing
                    TxtMunicipio.EditValue = Nothing
                    CboDepartamento.EditValue = Nothing
                    BtnNuevo.Visible = True
                    BtnEditar.Visible = True
                    BtnInsertar.Visible = False
                    BtnCancelar.Visible = False
                    BtnActualizar.Visible = False
                    GCPrincipal.Enabled = True

                    MostrarMunicipio()


                End If

            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try
        End If
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If TxtMunicipio.Text = Nothing Then
            XtraMessageBox.Show("Ingrese el Nombre del Municipio", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtMunicipio.Focus()
        ElseIf CboDepartamento.EditValue = Nothing Then
            XtraMessageBox.Show("Seleccione el Departamento del Municipio", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else
            Try
                conec.Conectarse()
                Dim datos As New DatosMunicipio
                Dim funcion As New FMunicipio

                datos.gMunicipio = TxtMunicipio.EditValue
                datos.gIdMunicipio = Int(TxtIdMunicipio.Text)

                datos.gIdDepartamento = CInt(CboDepartamento.EditValue)



                If funcion.Actualizar(datos) Then
                    XtraMessageBox.Show("Municipio Modificado con éxito", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    GbMunicipio.Enabled = False
                    TxtIdMunicipio.EditValue = Nothing
                    TxtMunicipio.EditValue = Nothing
                    CboDepartamento.EditValue = Nothing
                    BtnNuevo.Visible = True
                    BtnEditar.Visible = True
                    BtnInsertar.Visible = False
                    BtnCancelar.Visible = False
                    BtnActualizar.Visible = False
                    GCPrincipal.Enabled = True

                    MostrarMunicipio()

                End If

            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try
        End If
    End Sub

    Private Sub BtnCancelar_Click_1(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim r As DialogResult = XtraMessageBox.Show("¿Desea Cancelar el Proceso?", "INNOVAMASTER ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If r = DialogResult.Yes Then
            GbMunicipio.Enabled = False
            TxtIdMunicipio.EditValue = Nothing
            TxtMunicipio.EditValue = Nothing
            CboDepartamento.EditValue = Nothing
            BtnNuevo.Visible = True
            BtnEditar.Visible = True
            BtnInsertar.Visible = False
            BtnCancelar.Visible = False
            BtnActualizar.Visible = False
            GCPrincipal.Enabled = True

        End If
    End Sub

    Private Sub DgvMunicipio_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles DgvMunicipio.FocusedRowChanged
        Dim FilaActual As Integer = DgvMunicipio.FocusedRowHandle
        TxtIdMunicipio.Text = DgvMunicipio.GetRowCellValue(DgvMunicipio.FocusedRowHandle, ColIdMunicipio)
        TxtMunicipio.Text = DgvMunicipio.GetRowCellValue(FilaActual, ColMunicipio)
        CboDepartamento.Text = DgvMunicipio.GetRowCellValue(FilaActual, ColDepartamento)
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Exportar_a_PDF(GCPrincipal, Me.Text)
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        MostrarMunicipio()
    End Sub
End Class