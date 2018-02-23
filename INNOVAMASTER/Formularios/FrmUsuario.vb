Imports System.Data.SqlClient
Imports DevExpress.XtraEditors

Public Class FrmUsuario

    Dim dt As New DataTable
    Dim Conec As New Conexion
    Dim cmd As SqlCommand
    Private Sub FrmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MostrarUsuario()
        LlenarCombos()

        Dim NombreArchivo As String = HTMLHelpClass.GetLocalHelpFileName("InnovaMasterAyuda2017.chm")
        HelpProvider1.HelpNamespace = NombreArchivo
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "Registro Usuario")
    End Sub
    Private Sub MostrarUsuario()
        Try
            Dim datos As New Fusuario
            dt = datos.MostrarUsuario
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
        GbUsuario.Enabled = True
        TxtIdUsuario.EditValue = Nothing
        TxtUsuario.EditValue = Nothing
        TxtContra.EditValue = Nothing
        TxtContra2.EditValue = Nothing
        CboEmpleado.EditValue = Nothing
        CboTipoA.Text = "Administrador"
        BtnCancelar.Visible = True
        BtnInsertar.Visible = True
        BtnEditar.Visible = False
        BtnNuevo.Visible = False
        GCPrincipal.Enabled = True
        RdbActivo.Checked = True
    End Sub
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim r As DialogResult = MessageBox.Show("¿Desea Cancelar el Proceso?", "INNOVAMASTER", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If r = DialogResult.Yes Then
            GCPrincipal.Enabled = True
            GbUsuario.Enabled = False
            TxtIdUsuario.EditValue = Nothing
            TxtUsuario.EditValue = Nothing
            TxtContra.EditValue = Nothing
            TxtContra2.EditValue = Nothing
            CboEmpleado.EditValue = Nothing
            CboTipoA.Text = "Administrador"
            BtnCancelar.Visible = False
            BtnInsertar.Visible = False
            BtnEditar.Visible = False
            BtnEditar.Visible = True
            BtnNuevo.Visible = True
            ChkVer.Checked = False

        End If


    End Sub
    Private Sub BtnNuevoEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If TxtIdUsuario.Text <> Nothing Then
            TxtIdUsuario.Enabled = False
            GbUsuario.Enabled = True
            BtnCancelar.Visible = True
            BtnInsertar.Visible = False
            BtnEditar.Visible = True
            BtnNuevo.Visible = False
            BtnEditar.Visible = False
            GCPrincipal.Enabled = False
            TxtContra.EditValue = Nothing
            TxtContra2.EditValue = Nothing
            ChkVer.Checked = False
        Else
            MessageBox.Show("Seleccione el Usuario a Editar", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


    End Sub

    Private Sub BtnInsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        If TxtUsuario.Text = Nothing Then
            XtraMessageBox.Show("Ingrese el Usuario", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf TxtContra.Text = Nothing Then
            XtraMessageBox.Show("Ingrese la Contraseña", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf TxtContra2.Text = Nothing Then
            XtraMessageBox.Show("Ingrese la Confirmarcion de la Contraseña", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf CboEmpleado.EditValue = Nothing Then
            XtraMessageBox.Show("Seleccione el Empleado", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf CboTipoA.Text = Nothing Then
            XtraMessageBox.Show("Selecciones el Tipo Acceso", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If TxtContra.Text = TxtContra2.Text Then
                Try

                    Dim datos As New DatosUsuario
                    Dim funcion As New Fusuario
                    datos.gUsuario = TxtUsuario.Text
                    datos.gContrasena = SHA1(TxtContra.Text)
                    datos.gIdEmpleado = CboEmpleado.EditValue
                    If RdbActivo.Checked = True Then
                        datos.gEstado = "Activo"
                    Else
                        datos.gEstado = "Inactivo"
                    End If
                    Conec.Conectarse()
                    Try

                        Dim dr2 As SqlDataReader
                        cmd = New SqlCommand("Select IdTipoAcceso from TipoAcceso Where TipoAcceso= '" & CboTipoA.Text & "'")
                        cmd.CommandType = CommandType.Text
                        cmd.Connection = Conec.Con

                        dr2 = cmd.ExecuteReader

                        If dr2.Read Then
                            datos.gIdTipoAcceso = dr2(0)
                        End If

                        dr2.Close()

                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try


                    If funcion.InsertarUsuario(datos) Then
                        Dim id As Integer
                        Conec.Conectarse()
                        Try

                            Dim dr3 As SqlDataReader
                            cmd = New SqlCommand("Select IdUsuario from Usuario Where Usuario= '" & TxtUsuario.Text & "'")
                            cmd.CommandType = CommandType.Text
                            cmd.Connection = Conec.Con

                            dr3 = cmd.ExecuteReader

                            If dr3.Read Then
                                id = CInt(dr3(0))
                            End If

                            dr3.Close()

                            If CboTipoA.Text = "Administrador" Then
                                cmd = New SqlCommand("INSERT INTO dbo.PermisosPermitidos
                                                    (
                                                        IdUsuario
                                                        ,IdPermiso
                                                    )
                                                    SELECT " & id & ", IdPermiso
                                                    FROM  Permisos ")
                                cmd.CommandType = CommandType.Text
                                cmd.Connection = Conec.Con

                                cmd.ExecuteNonQuery()
                            Else
                                cmd = New SqlCommand("INSERT INTO dbo.PermisosDenegados
                                                    (
                                                        IdUsuario
                                                        ,IdPermiso
                                                    )
                                                    SELECT " & id & ", IdPermiso
                                                    FROM  Permisos ")
                                cmd.CommandType = CommandType.Text
                                cmd.Connection = Conec.Con

                                cmd.ExecuteNonQuery()
                            End If



                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try





                        MessageBox.Show("Usuario Insertado Con Exito", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        GbUsuario.Enabled = False
                        TxtIdUsuario.EditValue = Nothing
                        TxtUsuario.EditValue = Nothing
                        TxtContra.EditValue = Nothing
                        TxtContra2.EditValue = Nothing
                        CboEmpleado.EditValue = Nothing
                        CboTipoA.Text = "Administrador"
                        BtnCancelar.Visible = False
                        BtnInsertar.Visible = False
                        BtnEditar.Visible = False
                        BtnEditar.Visible = True
                        BtnNuevo.Visible = True
                        GCPrincipal.Enabled = True
                        MostrarUsuario()
                        ChkVer.Checked = False
                    End If

                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    Conec.Desconectarse()
                End Try
            Else
                XtraMessageBox.Show("Las Contraseñas no son Iguales", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If


        End If
    End Sub
    Private Sub LlenarCombos()
        Dim _DT As New DataTable
        Dim da As New SqlDataAdapter
        Try
            Conec.Conectarse()
            cmd = New SqlCommand("Select (NombreEmpleado + ' ' + ApellidoEmpleado) as Nombre ,IdEmpleado from Empleado")
            cmd.CommandType = CommandType.Text
            cmd.Connection = Conec.Con

            If cmd.ExecuteNonQuery Then
                da = New SqlDataAdapter(cmd)
                da.Fill(_DT)
                CboEmpleado.Properties.DataSource = _DT
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            Conec.Desconectarse()
        End Try
    End Sub
    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If TxtUsuario.Text = Nothing Then
            XtraMessageBox.Show("Ingrese el Usuario", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf CboEmpleado.Text = Nothing Then
            XtraMessageBox.Show("Seleccione el Empleado", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf CboTipoA.Text = Nothing Then
            XtraMessageBox.Show("Selecciones el Tipo Acceso", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf TxtContra.Text <> TxtContra2.Text Then
            XtraMessageBox.Show("Las Contraseñas no son Iguales", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                Dim datos As New DatosUsuario
                Dim funcion As New Fusuario
                datos.gIdUsuario = TxtIdUsuario.Text
                datos.gUsuario = TxtUsuario.Text
                If TxtContra.Text = Nothing And TxtContra2.Text = TxtContra.Text Then
                    datos.gContrasena = LblRespaldo.Text
                Else
                    datos.gContrasena = SHA1(TxtContra.Text)
                End If
                datos.gIdEmpleado = CboEmpleado.EditValue
                If RdbActivo.Checked = True Then
                    datos.gEstado = "Activo"
                Else
                    datos.gEstado = "Inactivo"
                End If
                Conec.Conectarse()
                Try
                    Dim dr2 As SqlDataReader
                    cmd = New SqlCommand("Select IdTipoAcceso from TipoAcceso Where TipoAcceso= '" & CboTipoA.Text & "'")
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = Conec.Con

                    dr2 = cmd.ExecuteReader

                    If dr2.Read Then
                        datos.gIdTipoAcceso = dr2(0)
                    End If

                    dr2.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                If funcion.EditarUsuario(datos) Then
                    XtraMessageBox.Show("Usuario Editado Con Exito", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GbUsuario.Enabled = False
                    TxtIdUsuario.EditValue = Nothing
                    TxtUsuario.EditValue = Nothing
                    TxtContra.EditValue = Nothing
                    TxtContra2.EditValue = Nothing
                    CboEmpleado.EditValue = Nothing
                    CboTipoA.Text = "Administrador"
                    BtnCancelar.Visible = False
                    BtnInsertar.Visible = False
                    BtnEditar.Visible = False
                    BtnEditar.Visible = True
                    BtnNuevo.Visible = True
                    GCPrincipal.Enabled = True
                    MostrarUsuario()
                    ChkVer.Checked = False

                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                Conec.Desconectarse()
            End Try

        End If
    End Sub
    Private Sub CboEmpleado_SelectedIndexChanged(sender As Object, e As EventArgs)
        If TxtContra.Text <> TxtContra2.Text Then
            MessageBox.Show("Las Contraseñas no son Iguales", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub GCPrincipal_Click(sender As Object, e As EventArgs) Handles GCPrincipal.Click
        TxtIdUsuario.Text = DgvUsuario.GetRowCellValue(DgvUsuario.FocusedRowHandle, ColIdUsuario)
        TxtUsuario.Text = DgvUsuario.GetRowCellValue(DgvUsuario.FocusedRowHandle, ColUsuario)
        TxtContra.Text = DgvUsuario.GetRowCellValue(DgvUsuario.FocusedRowHandle, ColContrasena)
        TxtContra2.Text = DgvUsuario.GetRowCellValue(DgvUsuario.FocusedRowHandle, ColContrasena)
        Conec.Conectarse()
        Try

            Dim dr3 As SqlDataReader
            cmd = New SqlCommand("Select IdEmpleado from Usuario Where IdUsuario= '" & CInt(TxtIdUsuario.Text) & "'")
            cmd.CommandType = CommandType.Text
            cmd.Connection = Conec.Con

            dr3 = cmd.ExecuteReader

            If dr3.Read Then
                CboEmpleado.EditValue = dr3(0)
            End If

            dr3.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        CboTipoA.Text = DgvUsuario.GetRowCellValue(DgvUsuario.FocusedRowHandle, ColTipoAcceso).ToString
        LblRespaldo.Text = DgvUsuario.GetRowCellValue(DgvUsuario.FocusedRowHandle, ColUsuario)
        If DgvUsuario.GetRowCellValue(DgvUsuario.FocusedRowHandle, ColEstado).ToString = "Activo" Then
            RdbActivo.Checked = True
        Else
            RdbInactivo.Checked = True
        End If
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
        MostrarUsuario()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        CboTipoA.Text = "Administrador"
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        CboTipoA.Text = "Usuario"
    End Sub

    Private Sub ChkVer_CheckedChanged_1(sender As Object, e As EventArgs) Handles ChkVer.CheckedChanged
        If ChkVer.Checked = True Then
            TxtContra.Properties.PasswordChar = ""
            TxtContra2.Properties.PasswordChar = ""
            TxtContra.Focus()
        Else
            TxtContra.Properties.PasswordChar = "*"
            TxtContra2.Properties.PasswordChar = "*"
            TxtContra.Focus()

        End If
    End Sub



    Private Sub DgvUsuario_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles DgvUsuario.FocusedRowChanged
        TxtIdUsuario.Text = DgvUsuario.GetRowCellValue(DgvUsuario.FocusedRowHandle, ColIdUsuario)
        TxtUsuario.Text = DgvUsuario.GetRowCellValue(DgvUsuario.FocusedRowHandle, ColUsuario)
        TxtContra.Text = DgvUsuario.GetRowCellValue(DgvUsuario.FocusedRowHandle, ColContrasena)
        TxtContra2.Text = DgvUsuario.GetRowCellValue(DgvUsuario.FocusedRowHandle, ColContrasena)
        Conec.Conectarse()
        Try

            Dim dr3 As SqlDataReader
            cmd = New SqlCommand("Select IdEmpleado from Usuario Where IdUsuario= '" & CInt(TxtIdUsuario.Text) & "'")
            cmd.CommandType = CommandType.Text
            cmd.Connection = Conec.Con

            dr3 = cmd.ExecuteReader

            If dr3.Read Then
                CboEmpleado.EditValue = dr3(0)
            End If

            dr3.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        CboTipoA.Text = DgvUsuario.GetRowCellValue(DgvUsuario.FocusedRowHandle, ColTipoAcceso).ToString
        LblRespaldo.Text = DgvUsuario.GetRowCellValue(DgvUsuario.FocusedRowHandle, ColUsuario)
        If DgvUsuario.GetRowCellValue(DgvUsuario.FocusedRowHandle, ColEstado).ToString = "Activo" Then
            RdbActivo.Checked = True
        Else
            RdbInactivo.Checked = True
        End If
    End Sub


End Class