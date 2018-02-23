Imports System.Data.SqlClient
Imports DevExpress.XtraEditors

Public Class FrmModelo
    Dim dt As New DataTable
    Dim conec As New Conexion
    Public var As Integer = 0
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub FrmModelo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MostrarModelo()
        GbModelo.Enabled = False
        TxtIdModelo.Enabled = False
        GCPrincipal.Enabled = True
        Call LlenarComboboxMarca()

        Dim NombreArchivo As String = HTMLHelpClass.GetLocalHelpFileName("InnovaMasterAyuda2017.chm")
        HelpProvider1.HelpNamespace = NombreArchivo
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "Modelo")
    End Sub
    Private Sub MostrarModelo()
        Try
            Dim datos As New FModelo
            dt = datos.MostrarModelo

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

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        GbModelo.Enabled = True
        TxtIdModelo.EditValue = Nothing
        TxtModelo.EditValue = Nothing
        CboMarca.EditValue = Nothing
        BtnNuevo.Visible = False
        BtnEditar.Visible = False
        BtnInsertar.Visible = True
        BtnCancelar.Visible = True
        GCPrincipal.Enabled = False
    End Sub



    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If TxtIdModelo.Text <> Nothing Then

            GbModelo.Enabled = True
            BtnNuevo.Visible = False
            BtnEditar.Visible = False
            BtnActualizar.Visible = True
            BtnCancelar.Visible = True
            BtnInsertar.Visible = False
            TxtIdModelo.Visible = True
            GCPrincipal.Enabled = False


        Else
            XtraMessageBox.Show("Seleccione el Modelo a Actualizar", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim r As DialogResult = XtraMessageBox.Show("¿Desea Cancelar el Proceso?", "INNOVAMASTER ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If r = DialogResult.Yes Then
            GbModelo.Enabled = False
            TxtIdModelo.EditValue = Nothing
            TxtModelo.EditValue = Nothing
            CboMarca.EditValue = Nothing
            BtnNuevo.Visible = True
            BtnEditar.Visible = True
            BtnInsertar.Visible = False
            BtnCancelar.Visible = False
            BtnActualizar.Visible = False
            GCPrincipal.Enabled = True

        End If

    End Sub

    Private Sub Btninsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        If TxtModelo.Text = Nothing Then
            XtraMessageBox.Show("Ingrese el Nombre del Modelo", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtModelo.Focus()
        ElseIf CboMarca.EditValue = Nothing Then
            XtraMessageBox.Show("Seleccione la Marca del Modelo", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else
            Try
                conec.Conectarse()
                Dim datos As New DatosModelo
                Dim funcion As New FModelo

                datos.gModelo = TxtModelo.Text

                datos.gIdMarca = CInt(CboMarca.EditValue)



                If funcion.Insertar(datos) Then
                    XtraMessageBox.Show("Modelo Insertado con Exito", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    GbModelo.Enabled = False
                    TxtIdModelo.EditValue = Nothing
                    TxtModelo.EditValue = Nothing
                    CboMarca.EditValue = Nothing
                    BtnNuevo.Visible = True
                    BtnEditar.Visible = True
                    BtnInsertar.Visible = False
                    BtnCancelar.Visible = False
                    BtnActualizar.Visible = False
                    GCPrincipal.Enabled = True

                    MostrarModelo()


                End If

            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try
        End If


    End Sub
    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If TxtModelo.Text = Nothing Then
            XtraMessageBox.Show("Ingrese el Nombre del Modelo", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtModelo.Focus()
        ElseIf CboMarca.EditValue = Nothing Then
            XtraMessageBox.Show("Seleccione la Marca del Modelo", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else
            Try
                conec.Conectarse()
                Dim datos As New DatosModelo
                Dim funcion As New FModelo

                datos.gModelo = TxtModelo.Text
                datos.gIdModelo = Int(TxtIdModelo.Text)
                datos.gIdMarca = CInt(CboMarca.EditValue)

                If funcion.Actualizar(datos) Then
                    XtraMessageBox.Show("Modelo Modificado con éxito", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    GbModelo.Enabled = False
                    TxtIdModelo.EditValue = Nothing
                    TxtModelo.EditValue = Nothing
                    CboMarca.EditValue = Nothing
                    BtnNuevo.Visible = True
                    BtnEditar.Visible = True
                    BtnInsertar.Visible = False
                    BtnCancelar.Visible = False
                    BtnActualizar.Visible = False
                    GCPrincipal.Enabled = True

                    MostrarModelo()


                End If

            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try
        End If


    End Sub

    Public Sub LlenarComboboxMarca()
        Dim _Dt As New DataTable
        Dim DA As SqlDataAdapter

        Try
            conec.Conectarse()
            Dim cmd As New SqlCommand
            cmd = New SqlCommand("MostrarMarcaVehiculo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conec.Con

            If cmd.ExecuteNonQuery Then
                DA = New SqlDataAdapter(cmd)
                DA.Fill(_Dt)
                CboMarca.Properties.DataSource = _Dt
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            conec.Desconectarse()
        End Try

    End Sub




    Private Sub BtnBusquedaCliente_Click(sender As Object, e As EventArgs) Handles BtnBusquedaCliente.Click
        With FrmMarca
            FrmMarca.var = 1
            .MdiParent = MenuPrincipal
            .Dock = DockStyle.Fill
            .Show()
        End With
    End Sub

    Private Sub GCPrincipal_DoubleClick(sender As Object, e As EventArgs) Handles GCPrincipal.DoubleClick
        If var = 1 Then
            FrmProducto.LlenarCombos()
            FrmProducto.CboModelo.Text = DgvModelo.GetRowCellValue(DgvModelo.FocusedRowHandle, ColModelo)
            Me.Close()
        End If
    End Sub

    Private Sub GCPrincipal_Click(sender As Object, e As EventArgs) Handles GCPrincipal.Click
        Dim index As Integer = DgvModelo.FocusedRowHandle
        TxtIdModelo.EditValue = DgvModelo.GetRowCellValue(index, ColIdModelo)
        TxtModelo.EditValue = DgvModelo.GetRowCellValue(index, ColModelo)
        CboMarca.Text = DgvModelo.GetRowCellValue(index, ColMarca)
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
        MostrarModelo()
    End Sub

    Private Sub DgvModelo_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles DgvModelo.FocusedRowChanged
        Dim index As Integer = DgvModelo.FocusedRowHandle
        TxtIdModelo.EditValue = DgvModelo.GetRowCellValue(index, ColIdModelo)
        TxtModelo.EditValue = DgvModelo.GetRowCellValue(index, ColModelo)
        CboMarca.Text = DgvModelo.GetRowCellValue(index, ColMarca)
    End Sub
End Class