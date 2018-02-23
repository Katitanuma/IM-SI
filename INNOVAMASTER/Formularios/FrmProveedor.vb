Imports System.ComponentModel
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors

Public Class FrmProveedor

    Dim dt As New DataTable
    Dim Conec As New Conexion
    Dim cmd As SqlCommand
    Public var As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpiar()
        Mostrar()
        LlenarComboMunicipio()
        LlenarComboSexo()
        BtnInsertar.Visible = False
        BtnCancelar.Visible = False
        BtnEditar.Visible = True
        GBProveedor.Enabled = False

        Dim NombreArchivo As String = HTMLHelpClass.GetLocalHelpFileName("InnovaMasterAyuda2017.chm")
        HelpProvider1.HelpNamespace = NombreArchivo
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "Registro Proveedor")

    End Sub
    Private Sub Mostrar()
        Try
            Dim funcion As New Fproveedores
            dt = funcion.MostrarProveedores

            If dt.Rows.Count <> 0 Then
                GCPrincipal.DataSource = dt
            Else
                GCPrincipal.DataSource = Nothing

            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Sub LlenarComboMunicipio()
        Dim da As SqlDataAdapter
        Dim _DT As New DataTable
        CboMunicipio.EditValue = Nothing
        Try
            Conec.Conectarse()
            cmd = New SqlCommand("Select IdMunicipio, Municipio from Municipio")
            cmd.CommandType = CommandType.Text
            cmd.Connection = Conec.Con

            If cmd.ExecuteNonQuery Then
                da = New SqlDataAdapter(cmd)
                da.Fill(_DT)
                CboMunicipio.Properties.DataSource = _DT
            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        Finally
            Conec.Desconectarse()
        End Try
    End Sub
    Public Sub LlenarComboSexo()
        Dim da As SqlDataAdapter
        Dim _DT As New DataTable
        CboMunicipio.EditValue = Nothing
        Try
            Conec.Conectarse()
            cmd = New SqlCommand("Select * from Sexo")
            cmd.CommandType = CommandType.Text
            cmd.Connection = Conec.Con

            If cmd.ExecuteNonQuery Then
                da = New SqlDataAdapter(cmd)
                da.Fill(_DT)
                CboSexo.Properties.DataSource = _DT
            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        Finally
            Conec.Desconectarse()
        End Try
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        TxtIdProveedor.Enabled = True
        TxtRTN.Enabled = True
        GBProveedor.Enabled = True
        BtnNuevo.Visible = False
        BtnInsertar.Visible = True
        BtnCancelar.Visible = True
        BtnEditar.Visible = False
        GCPrincipal.Enabled = False
        BtnActualizar.Visible = False
        TxtIdProveedor.EditValue = Nothing
        TxtRTN.EditValue = Nothing
        TxtNombreContacto.EditValue = Nothing
        TxtNombreEmpresa.EditValue = Nothing
        TxtDireccionEmpresa.EditValue = Nothing
        TxtNombreContacto.EditValue = Nothing
        TxtApellidosContacto.EditValue = Nothing
        TxtDireccionContacto.EditValue = Nothing
        TxtTelefono.EditValue = Nothing
        TxtCorreo.EditValue = Nothing
        CboSexo.EditValue = Nothing
        CboMunicipio.EditValue = Nothing
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim R As DialogResult
        R = MessageBox.Show("¿Desea Cancelar el Proceso?", "INNOVAMASTER", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If R = DialogResult.Yes Then
            Limpiar()
            Me.Focus()
        End If

    End Sub
    Private Sub BtnInsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        If TxtIdProveedor.Text.Length < 15 Then
            XtraMessageBox.Show("Ingrese un Numero de Identidad Correcto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf TxtRTN.Text.Length < 15 Then
            XtraMessageBox.Show("Ingrese un RTN Correcto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf TxtNombreEmpresa.Text = Nothing Then
            XtraMessageBox.Show("Ingrese el Nombre de la Empresa", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf TxtDireccionEmpresa.Text = Nothing Then
            XtraMessageBox.Show("Ingrese la Direccion de la Empresa", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf TxtNombreContacto.Text = Nothing Then
            XtraMessageBox.Show("Ingrese el Nombre del Contacto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf TxtApellidosContacto.Text = Nothing Then
            XtraMessageBox.Show("Ingrese el Apellido del Contacto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf TxtDireccionContacto.Text = Nothing Then
            XtraMessageBox.Show("Ingrese la Dirección del Contacto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            Try
                Dim datos As New DatosProveedor
                Dim funcion As New Fproveedores

                datos.gIdProveedor = TxtIdProveedor.Text
                If TxtRTN.Text.Length = 15 Then
                    datos.gRTN = TxtRTN.Text
                Else
                    datos.gRTN = Nothing
                End If
                datos.gNombreEmpresa = TxtNombreEmpresa.Text
                datos.gDireccionEmpresa = TxtDireccionEmpresa.Text
                datos.gNombreContacto = TxtNombreContacto.Text
                datos.gApellidoContacto = TxtApellidosContacto.Text
                datos.gDireccionContacto = TxtDireccionContacto.Text
                datos.gTelefonoContacto = TxtTelefono.Text
                datos.gCorreoContacto = TxtCorreo.Text



                Conec.Conectarse()
                Try
                    cmd = New SqlCommand("Select IdMunicipio From Municipio Where Municipio= '" & CboMunicipio.Text & "'")
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = Conec.Con
                    Dim dr As SqlDataReader
                    dr = cmd.ExecuteReader

                    If dr.Read Then
                        datos.gIdMunicipio = dr(0)
                    End If
                    dr.Close()
                Catch ex As Exception
                    XtraMessageBox.Show(ex.Message)
                End Try

                Try
                    cmd = New SqlCommand("Select IdSexo From Sexo Where Sexo= '" & CboSexo.Text & "'")
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = Conec.Con
                    Dim dr As SqlDataReader
                    dr = cmd.ExecuteReader

                    If dr.Read Then
                        datos.gIdSexo = dr(0)
                    End If
                    dr.Close()
                Catch ex As Exception
                    XtraMessageBox.Show(ex.Message)
                End Try



                If funcion.InsertarProveedor(datos) Then
                    XtraMessageBox.Show("Proveedor registrado correctamente", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Limpiar()
                    Mostrar()
                    Focus()
                End If

            Catch ex As Exception
                XtraMessageBox.Show(ex.ToString)
            Finally
                Conec.Desconectarse()
            End Try

        End If

    End Sub
    Private Sub Limpiar()
        GBProveedor.Enabled = False
        BtnInsertar.Visible = False
        BtnNuevo.Visible = True
        BtnEditar.Visible = True
        BtnActualizar.Visible = False
        BtnCancelar.Visible = False
        GCPrincipal.Enabled = True
        TxtIdProveedor.EditValue = Nothing
        TxtRTN.EditValue = Nothing
        TxtNombreEmpresa.EditValue = Nothing
        TxtNombreContacto.EditValue = Nothing
        TxtDireccionEmpresa.EditValue = Nothing
        TxtNombreContacto.EditValue = Nothing
        TxtApellidosContacto.EditValue = Nothing
        TxtDireccionContacto.EditValue = Nothing
        TxtTelefono.EditValue = Nothing
        TxtCorreo.EditValue = Nothing
        CboMunicipio.EditValue = Nothing
        CboSexo.EditValue = Nothing
    End Sub
    Private Sub BtnEditar_Click_1(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If TxtIdProveedor.Text <> Nothing Then
            GBProveedor.Enabled = True
            BtnNuevo.Visible = False
            BtnInsertar.Visible = False
            BtnActualizar.Visible = True
            BtnEditar.Visible = False
            BtnCancelar.Visible = True
            GCPrincipal.Enabled = False
            TxtIdProveedor.Enabled = False
            Focus()
        Else
            XtraMessageBox.Show("Seleccione el Proveedor a Editar", "Seleccionar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If TxtRTN.Text.Length < 15 Then
            XtraMessageBox.Show("Ingrese un RTN Correcto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf TxtNombreEmpresa.Text = Nothing Then
            XtraMessageBox.Show("Ingrese el Nombre de la Empresa", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf TxtDireccionEmpresa.Text = Nothing Then
            XtraMessageBox.Show("Ingrese la Direccion de la Empresa", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf TxtNombreContacto.Text = Nothing Then
            XtraMessageBox.Show("Ingrese el Nombre del Contacto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf TxtApellidosContacto.Text = Nothing Then
            XtraMessageBox.Show("Ingrese el Apellido del Contacto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf TxtDireccionContacto.Text = Nothing Then
            XtraMessageBox.Show("Ingrese la Dirección del Contacto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            Try
                Dim datos As New DatosProveedor
                Dim funcion As New Fproveedores

                datos.gIdProveedor = TxtIdProveedor.Text

                If TxtRTN.Text.Length = 15 Then
                    datos.gRTN = TxtRTN.Text
                Else
                    datos.gRTN = Nothing
                End If

                datos.gNombreEmpresa = TxtNombreEmpresa.Text
                datos.gDireccionEmpresa = TxtDireccionEmpresa.Text
                datos.gNombreContacto = TxtNombreContacto.Text
                datos.gApellidoContacto = TxtApellidosContacto.Text
                datos.gDireccionContacto = TxtDireccionContacto.Text
                datos.gTelefonoContacto = TxtTelefono.Text
                datos.gCorreoContacto = TxtCorreo.EditValue


                Conec.Conectarse()
                Try
                    cmd = New SqlCommand("Select IdMunicipio From Municipio Where Municipio= '" & CboMunicipio.Text & "'")
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = Conec.Con
                    Dim dr As SqlDataReader
                    dr = cmd.ExecuteReader

                    If dr.Read Then
                        datos.gIdMunicipio = dr(0)
                    End If
                    dr.Close()
                Catch ex As Exception
                    XtraMessageBox.Show(ex.Message)
                End Try


                Try
                    cmd = New SqlCommand("Select IdSexo From Sexo Where Sexo= '" & CboSexo.Text & "'")
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = Conec.Con
                    Dim dr As SqlDataReader
                    dr = cmd.ExecuteReader

                    If dr.Read Then
                        datos.gIdSexo = dr(0)
                    End If
                    dr.Close()
                Catch ex As Exception
                    XtraMessageBox.Show(ex.Message)
                End Try

                If funcion.EditarProveedor(datos) Then
                    XtraMessageBox.Show("Proveedor modificado correctamente", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Limpiar()
                    Mostrar()
                    Focus()
                End If

            Catch ex As Exception
                XtraMessageBox.Show(ex.ToString)
            Finally
                Conec.Desconectarse()
            End Try

        End If
    End Sub

    Private Sub BtnBusquedaMunicipio_Click(sender As Object, e As EventArgs) Handles BtnBusquedaMunicipio.Click

        With FrmMunicipio
            FrmMunicipio.var = 3
            .MdiParent = FrmMenuPrincipal
            .Dock = DockStyle.Fill
            .Show()
        End With
    End Sub

    Private Sub FrmCliente_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        LblRelacionClienteVenta.Text = "0"
    End Sub

    Private Sub DgvProveedor_Click(sender As Object, e As EventArgs) Handles DgvProveedor.Click
        TxtIdProveedor.Text = DgvProveedor.GetRowCellValue(DgvProveedor.FocusedRowHandle, ColIdProveedor)
        TxtRTN.Text = DgvProveedor.GetRowCellValue(DgvProveedor.FocusedRowHandle, ColRTN)
        TxtNombreEmpresa.Text = DgvProveedor.GetRowCellValue(DgvProveedor.FocusedRowHandle, ColNombreEmpresa)
        TxtDireccionEmpresa.Text = DgvProveedor.GetRowCellValue(DgvProveedor.FocusedRowHandle, ColDireccionEmpresa)
        TxtNombreContacto.Text = DgvProveedor.GetRowCellValue(DgvProveedor.FocusedRowHandle, ColNombreContacto)
        TxtApellidosContacto.Text = DgvProveedor.GetRowCellValue(DgvProveedor.FocusedRowHandle, ColApellidoContacto)
        TxtDireccionContacto.Text = DgvProveedor.GetRowCellValue(DgvProveedor.FocusedRowHandle, ColDireccionContacto)
        TxtTelefono.Text = DgvProveedor.GetRowCellValue(DgvProveedor.FocusedRowHandle, ColTelefonoContacto)
        TxtCorreo.Text = DgvProveedor.GetRowCellValue(DgvProveedor.FocusedRowHandle, ColCorreoContacto)
        CboMunicipio.Text = DgvProveedor.GetRowCellValue(DgvProveedor.FocusedRowHandle, ColMunicipio)
        CboSexo.Text = DgvProveedor.GetRowCellValue(DgvProveedor.FocusedRowHandle, ColSexo)
    End Sub

    Private Sub DgvProveedor_DoubleClick(sender As Object, e As EventArgs) Handles DgvProveedor.DoubleClick
        'Dim frm As FrmPedidos
        'frm.CboProveedor.Text = DgvProveedor.GetRowCellValue(DgvProveedor.FocusedRowHandle, ColNombreContacto) & " " & DgvProveedor.GetRowCellValue(DgvProveedor.FocusedRowHandle, ColApellidoContacto)
    End Sub

    Private Sub DgvProveedor_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles DgvProveedor.FocusedRowChanged
        TxtIdProveedor.Text = DgvProveedor.GetRowCellValue(DgvProveedor.FocusedRowHandle, ColIdProveedor)
        TxtRTN.Text = DgvProveedor.GetRowCellValue(DgvProveedor.FocusedRowHandle, ColRTN)
        TxtNombreEmpresa.Text = DgvProveedor.GetRowCellValue(DgvProveedor.FocusedRowHandle, ColNombreEmpresa)
        TxtDireccionEmpresa.Text = DgvProveedor.GetRowCellValue(DgvProveedor.FocusedRowHandle, ColDireccionEmpresa)
        TxtNombreContacto.Text = DgvProveedor.GetRowCellValue(DgvProveedor.FocusedRowHandle, ColNombreContacto)
        TxtApellidosContacto.Text = DgvProveedor.GetRowCellValue(DgvProveedor.FocusedRowHandle, ColApellidoContacto)
        TxtDireccionContacto.Text = DgvProveedor.GetRowCellValue(DgvProveedor.FocusedRowHandle, ColDireccionContacto)
        TxtTelefono.EditValue = DgvProveedor.GetRowCellValue(DgvProveedor.FocusedRowHandle, ColTelefonoContacto)
        TxtCorreo.EditValue = DgvProveedor.GetRowCellValue(DgvProveedor.FocusedRowHandle, ColCorreoContacto)
        CboMunicipio.Text = DgvProveedor.GetRowCellValue(DgvProveedor.FocusedRowHandle, ColMunicipio)
        CboSexo.Text = DgvProveedor.GetRowCellValue(DgvProveedor.FocusedRowHandle, ColSexo)
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
        Mostrar()
        LlenarComboMunicipio()
        LlenarComboSexo()
    End Sub
End Class