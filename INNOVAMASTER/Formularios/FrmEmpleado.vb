Imports System.Data.SqlClient
Imports System.IO
Imports DevExpress.XtraEditors

Public Class FrmEmpleado
    Dim conec As New Conexion
    Dim dt As New DataTable
    Dim cmd As SqlCommand
    Private Sub FrmEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Mostrar()
        LlenarComboMunicipio()
        LlenarComboSexo()
        LlenarComboEstadoCivil()
        LlenarComboCargo()
        LlenarComboProfesion()
        LlenarComboSucursal()
        PbEmpleado.Enabled = False
        BtnInsertar.Visible = False
        BtnCancelar.Visible = False
        BtnEditar.Visible = True
        GbEmpleado.Enabled = False


        Dim NombreArchivo As String = HTMLHelpClass.GetLocalHelpFileName("InnovaMasterAyuda2017.chm")
        HelpProvider1.HelpNamespace = NombreArchivo
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "Registro Empleado")

    End Sub
    Private Sub Mostrar()
        Try
            Dim funcion As New Fempleado
            dt = funcion.MostrarEmpleado

            If dt.Rows.Count <> 0 Then
                GCPrincipal.DataSource = dt

            Else
                GCPrincipal.DataSource = Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub LlenarComboMunicipio()
        CmbMunicipio.EditValue = Nothing

        Dim da As SqlDataAdapter
        Dim _DT As New DataTable
        Try
            conec.Conectarse()
            Dim cmd As New SqlCommand
            cmd = New SqlCommand("Select IdMunicipio, Municipio from Municipio")
            cmd.CommandType = CommandType.Text
            cmd.Connection = conec.Con


            If cmd.ExecuteNonQuery Then
                da = New SqlDataAdapter(cmd)
                da.Fill(_DT)
                CmbMunicipio.Properties.DataSource = _DT
                'LookUpEdit1.Properties.DataSource = _DT
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            conec.Desconectarse()
        End Try

    End Sub
    Private Sub LlenarComboEstadoCivil()
        CmbEstadoCivil.EditValue = Nothing

        Dim da As SqlDataAdapter
        Dim _DT As New DataTable
        Try
            conec.Conectarse()
            Dim cmd As New SqlCommand
            cmd = New SqlCommand("Select IdEstadoCivil, EstadoCivil from EstadoCivil")
            cmd.CommandType = CommandType.Text
            cmd.Connection = conec.Con


            If cmd.ExecuteNonQuery Then
                da = New SqlDataAdapter(cmd)
                da.Fill(_DT)
                CmbEstadoCivil.Properties.DataSource = _DT
                'LookUpEdit1.Properties.DataSource = _DT
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            conec.Desconectarse()
        End Try
    End Sub
    Public Sub LlenarComboCargo()
        CboCargo.EditValue = Nothing

        Dim da As SqlDataAdapter
        Dim _DT As New DataTable
        Try
            conec.Conectarse()
            Dim cmd As New SqlCommand
            cmd = New SqlCommand("Select IdCargo, Cargo from Cargo")
            cmd.CommandType = CommandType.Text
            cmd.Connection = conec.Con


            If cmd.ExecuteNonQuery Then
                da = New SqlDataAdapter(cmd)
                da.Fill(_DT)
                CboCargo.Properties.DataSource = _DT
                'LookUpEdit1.Properties.DataSource = _DT
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            conec.Desconectarse()
        End Try
    End Sub
    Public Sub LlenarComboProfesion()
        CboProfesion.EditValue = Nothing

        Dim da As SqlDataAdapter
        Dim _DT As New DataTable
        Try
            conec.Conectarse()
            Dim cmd As New SqlCommand
            cmd = New SqlCommand("Select IdProfesion, Profesion  from Profesion")
            cmd.CommandType = CommandType.Text
            cmd.Connection = conec.Con


            If cmd.ExecuteNonQuery Then
                da = New SqlDataAdapter(cmd)
                da.Fill(_DT)
                CboProfesion.Properties.DataSource = _DT
                'LookUpEdit1.Properties.DataSource = _DT
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            conec.Desconectarse()
        End Try
    End Sub
    Private Sub LlenarComboSucursal()
        CboSucursal.EditValue = Nothing

        Dim da As SqlDataAdapter
        Dim _DT As New DataTable
        Try
            conec.Conectarse()
            Dim cmd As New SqlCommand
            cmd = New SqlCommand("Select IdSucursal, Sucursal from Sucursal")
            cmd.CommandType = CommandType.Text
            cmd.Connection = conec.Con


            If cmd.ExecuteNonQuery Then
                da = New SqlDataAdapter(cmd)
                da.Fill(_DT)
                CboSucursal.Properties.DataSource = _DT
                'LookUpEdit1.Properties.DataSource = _DT
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            conec.Desconectarse()
        End Try
    End Sub
    Private Sub LlenarComboSexo()
        CboSexo.EditValue = Nothing

        Dim da As SqlDataAdapter
        Dim _DT As New DataTable
        Try
            conec.Conectarse()
            Dim cmd As New SqlCommand
            cmd = New SqlCommand("Select IdSexo, Sexo from Sexo")
            cmd.CommandType = CommandType.Text
            cmd.Connection = conec.Con


            If cmd.ExecuteNonQuery Then
                da = New SqlDataAdapter(cmd)
                da.Fill(_DT)
                CboSexo.Properties.DataSource = _DT
                'LookUpEdit1.Properties.DataSource = _DT
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            conec.Desconectarse()
        End Try
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        'Habilitar y deshabilitar controles del formulario
        PbEmpleado.Enabled = True
        GbEmpleado.Enabled = True
        BtnNuevo.Visible = False
        BtnInsertar.Visible = True
        BtnCancelar.Visible = True
        BtnEditar.Visible = False
        GCPrincipal.Enabled = False
        BtnActualizar.Visible = False
        TxtIdEmpleado.Enabled = True
        TxtIdEmpleado.Text = Nothing
        TxtNombres.EditValue = Nothing
        TxtDireccion.EditValue = Nothing
        TxtApellidos.EditValue = Nothing
        TxtCelular.EditValue = Nothing
        TxtTelefono.EditValue = Nothing
        DteFechaC.EditValue = Nothing
        DteFechaNac.EditValue = Nothing
        CmbMunicipio.Text = Nothing
        CmbEstadoCivil.Text = Nothing
        CboSucursal.Text = Nothing
        CboCargo.Text = Nothing
        LlenarComboMunicipio()
        LlenarComboEstadoCivil()
        LlenarComboCargo()
        LlenarComboProfesion()
        LlenarComboSucursal()
        LlenarComboSexo()
        PbEmpleado.Image = Nothing

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        'Cancelar el procesos realizados por el usuario
        Dim R As DialogResult
        R = XtraMessageBox.Show("¿Desea Cancelar el Proceso?", "INNOVAMASTER", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If R = DialogResult.Yes Then
            Limpiar()
        End If

    End Sub
    Private Sub BtnInsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        'Metodo del evento click del boton insetar, el cual realizar las operación correspondiente

        If TxtIdEmpleado.Text.Length < 15 Then
            XtraMessageBox.Show("Ingrese el Numero de Identidad del Empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtIdEmpleado.Focus()
        ElseIf TxtNombres.Text = Nothing Then
            XtraMessageBox.Show("Ingrese el Nombre del Empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtNombres.Focus()
        ElseIf TxtApellidos.Text = Nothing Then
            XtraMessageBox.Show("Ingrese los Apellidos del Empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtApellidos.Focus()
        ElseIf TxtDireccion.Text = Nothing Then
            XtraMessageBox.Show("Ingrese la Dirección del Empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtDireccion.Focus()
        ElseIf DteFechaNac.EditValue = Nothing Then
            XtraMessageBox.Show("Seleccione la Fecha de Nacimiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            DteFechaNac.Focus()
        ElseIf CmbMunicipio.EditValue = Nothing Then
            XtraMessageBox.Show("Seleccione el Municipio del Empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CmbMunicipio.Focus()
        ElseIf CboCargo.EditValue = Nothing Then
            XtraMessageBox.Show("Seleccione el Municipio del Empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CboCargo.Focus()
        ElseIf DteFechaC.EditValue = Nothing Then
            XtraMessageBox.Show("Seleccione la Fecha de Contratacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            DteFechaC.Focus()
        ElseIf CboProfesion.EditValue = Nothing Then
            XtraMessageBox.Show("Seleccione el Estado Civil del Empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CboProfesion.Focus()
        ElseIf CboSucursal.EditValue = Nothing Then
            XtraMessageBox.Show("Seleccione el Estado Civil del Empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CboSucursal.Focus()
        ElseIf CmbEstadoCivil.EditValue = Nothing Then
            XtraMessageBox.Show("Seleccione el Estado Civil del Empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CmbEstadoCivil.Focus()
        ElseIf CboSexo.EditValue = Nothing Then
            XtraMessageBox.Show("Seleccione un sexo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CboSexo.Focus()
        Else
            'Envio de datos a la Clase DatosEmpleado 
            Try
                Dim datos As New DatosEmpleado
                Dim funcion As New Fempleado

                datos.gIdEmpleado = TxtIdEmpleado.Text
                datos.gNombreEmpleado = TxtNombres.Text
                datos.gApellidoEmpleado = TxtApellidos.Text
                datos.gDireccionEmpleado = TxtDireccion.Text
                datos.gTelefonoEmpleado = TxtTelefono.Text
                datos.gCelularEmpleado = TxtCelular.Text

                Dim ms As New System.IO.MemoryStream

                If PbEmpleado.Image Is Nothing Then
                    PbEmpleado.Image = INNOVAMASTER.My.Resources.NULLA
                End If
                PbEmpleado.Image.Save(ms, PbEmpleado.Image.RawFormat)

                datos.gImagen = ms.GetBuffer
                datos.gFechaNacimiento = DteFechaNac.Text
                datos.gFechaContratacion = DteFechaC.Text

                Try
                    conec.Conectarse()
                    cmd = New SqlCommand("Select IdSexo From Sexo Where Sexo= '" & CboSexo.Text & "'")
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = conec.Con
                    Dim dr As SqlDataReader
                    dr = cmd.ExecuteReader

                    If dr.Read Then
                        datos.gIdSexo = Int(dr(0))
                    End If
                    dr.Close()
                Catch ex As Exception
                    XtraMessageBox.Show(ex.Message)
                End Try

                Try
                    conec.Conectarse()
                    cmd = New SqlCommand("Select IdMunicipio From Municipio Where Municipio= '" & CmbMunicipio.Text & "'")
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = conec.Con
                    Dim dr As SqlDataReader
                    dr = cmd.ExecuteReader

                    If dr.Read Then
                        datos.gIdMunicipio = Int(dr(0))
                    End If
                    dr.Close()
                Catch ex As Exception
                    XtraMessageBox.Show(ex.Message)
                End Try
                Try
                    cmd = New SqlCommand("Select IdEstadoCivil From EstadoCivil Where EstadoCivil= '" & CmbEstadoCivil.Text & "'")
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = conec.Con
                    Dim dr2 As SqlDataReader
                    dr2 = cmd.ExecuteReader

                    If dr2.Read Then
                        datos.gIdEstadoCivil = dr2(0)
                    End If
                    dr2.Close()
                Catch ex As Exception
                    XtraMessageBox.Show(ex.Message)
                End Try
                Try
                    cmd = New SqlCommand("Select IdCargo From Cargo Where Cargo= '" & CboCargo.Text & "'")
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = conec.Con
                    Dim dr3 As SqlDataReader
                    dr3 = cmd.ExecuteReader

                    If dr3.Read Then
                        datos.gIdCargo = dr3(0)
                    End If
                    dr3.Close()
                Catch ex As Exception
                    XtraMessageBox.Show(ex.Message)
                End Try

                Try
                    cmd = New SqlCommand("Select IdProfesion From Profesion Where Profesion= '" & CboProfesion.Text & "'")

                    cmd.CommandType = CommandType.Text
                    cmd.Connection = conec.Con
                    Dim dr4 As SqlDataReader
                    dr4 = cmd.ExecuteReader

                    If dr4.Read Then
                        datos.gIdProfesion = dr4(0)

                    End If
                    dr4.Close()
                Catch ex As Exception
                    XtraMessageBox.Show(ex.Message)
                End Try

                Try
                    cmd = New SqlCommand("Select IdSucursal From Sucursal Where Sucursal= '" & CboSucursal.Text & "'")
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = conec.Con
                    Dim dr5 As SqlDataReader
                    dr5 = cmd.ExecuteReader

                    If dr5.Read Then
                        datos.gIdSucursal = dr5(0)
                    End If
                    dr5.Close()
                Catch ex As Exception
                    XtraMessageBox.Show(ex.Message)
                End Try
                'Ejecucion del proceso para la manipulación de datos de la base de datos
                If funcion.InsertarEmpleado(datos) Then
                    XtraMessageBox.Show("Empleado Ingresado con Éxito", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Limpiar()
                    Mostrar()
                    PbEmpleado.Image = Nothing
                End If

            Catch ex As Exception
                XtraMessageBox.Show(ex.ToString)
            Finally
                conec.Desconectarse()
            End Try

        End If

    End Sub
    Private Sub Limpiar()
        'Metodo para limpiar
        GbEmpleado.Enabled = False
        BtnInsertar.Visible = False
        BtnNuevo.Visible = True
        BtnEditar.Visible = True
        BtnActualizar.Visible = False
        BtnCancelar.Visible = False
        GCPrincipal.Enabled = True
        TxtIdEmpleado.EditValue = Nothing
        TxtNombres.EditValue = Nothing
        TxtDireccion.EditValue = Nothing
        TxtApellidos.EditValue = Nothing
        TxtCelular.EditValue = Nothing
        TxtTelefono.EditValue = Nothing
        DteFechaC.EditValue = Nothing
        DteFechaNac.EditValue = Nothing
        CmbMunicipio.EditValue = Nothing
        CmbEstadoCivil.EditValue = Nothing
        CboSucursal.EditValue = Nothing
        CboCargo.EditValue = Nothing
        CboProfesion.EditValue = Nothing
        CboSexo.EditValue = Nothing
        PbEmpleado.Image = Nothing
        PbEmpleado.Enabled = False

    End Sub
    Private Sub BtnEditar_Click_1(sender As Object, e As EventArgs) Handles BtnEditar.Click
        'Limpieza de los controles TextBox y habilitar varios controles
        If TxtNombres.Text <> Nothing Then
            GbEmpleado.Enabled = True
            BtnNuevo.Visible = False
            BtnInsertar.Visible = False
            BtnEditar.Visible = False
            BtnActualizar.Visible = True
            BtnCancelar.Visible = True
            GCPrincipal.Enabled = False
            TxtIdEmpleado.Enabled = False
            PbEmpleado.Enabled = True
        Else
            XtraMessageBox.Show("Seleccione el Cliente a Editar", "Seleccionar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub
    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        'Metodo del evento click del boton editar, para realizar la opeacion conrrespondiente
        If TxtNombres.Text = Nothing Then
            XtraMessageBox.Show("Ingrese el Nombre del Empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtNombres.Focus()
        ElseIf TxtApellidos.Text = Nothing Then
            XtraMessageBox.Show("Ingrese los Apellidos del Empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtApellidos.Focus()
        ElseIf TxtDireccion.Text = Nothing Then
            XtraMessageBox.Show("Ingrese la Dirección del Empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtDireccion.Focus()
        ElseIf DteFechaNac.EditValue = Nothing Then
            XtraMessageBox.Show("Seleccione la Fecha de Nacimiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            DteFechaNac.Focus()
        ElseIf CmbMunicipio.EditValue = Nothing Then
            XtraMessageBox.Show("Seleccione el Municipio del Empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CmbMunicipio.Focus()
        ElseIf CboCargo.EditValue = Nothing Then
            XtraMessageBox.Show("Seleccione el Municipio del Empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CboCargo.Focus()
        ElseIf DteFechaC.EditValue = Nothing Then
            XtraMessageBox.Show("Seleccione la Fecha de Contratacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            DteFechaC.Focus()
        ElseIf CboProfesion.EditValue = Nothing Then
            XtraMessageBox.Show("Seleccione el Estado Civil del Empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CboProfesion.Focus()
        ElseIf CboSucursal.EditValue = Nothing Then
            XtraMessageBox.Show("Seleccione el Estado Civil del Empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CboSucursal.Focus()
        ElseIf CmbEstadoCivil.EditValue = Nothing Then
            XtraMessageBox.Show("Seleccione el Estado Civil del Empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CmbEstadoCivil.Focus()
        ElseIf CboSexo.EditValue = Nothing Then
            XtraMessageBox.Show("Seleccione un sexo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CboSexo.Focus()
        Else
            'Envio de datos a la clase DatosEmpleado
            Try

                Dim datos As New DatosEmpleado
                Dim funcion As New Fempleado

                datos.gIdEmpleado = TxtIdEmpleado.Text
                datos.gNombreEmpleado = TxtNombres.Text
                datos.gApellidoEmpleado = TxtApellidos.Text
                datos.gDireccionEmpleado = TxtDireccion.Text
                datos.gTelefonoEmpleado = TxtTelefono.Text
                datos.gCelularEmpleado = TxtCelular.Text

                Dim ms As New System.IO.MemoryStream

                If PbEmpleado.Image Is Nothing Then
                    'PbEmpleado.Image = Image.FromFile("C:\Archivo.PNG")
                    PbEmpleado.Image = INNOVAMASTER.My.Resources.NULLA
                End If
                PbEmpleado.Image.Save(ms, PbEmpleado.Image.RawFormat)
                datos.gImagen = ms.GetBuffer
                datos.gFechaNacimiento = DteFechaNac.Text
                datos.gFechaContratacion = DteFechaC.Text


                conec.Conectarse()
                Try
                    conec.Conectarse()
                    cmd = New SqlCommand("Select IdSexo From Sexo Where Sexo= '" & CboSexo.Text & "'")
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = conec.Con
                    Dim dr As SqlDataReader
                    dr = cmd.ExecuteReader

                    If dr.Read Then
                        datos.gIdSexo = Int(dr(0))
                    End If
                    dr.Close()
                Catch ex As Exception
                    XtraMessageBox.Show(ex.Message)
                End Try

                Try
                    conec.Conectarse()
                    cmd = New SqlCommand("Select IdMunicipio From Municipio Where Municipio= '" & CmbMunicipio.Text & "'")
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = conec.Con
                    Dim dr As SqlDataReader
                    dr = cmd.ExecuteReader

                    If dr.Read Then
                        datos.gIdMunicipio = Int(dr(0))
                    End If
                    dr.Close()
                Catch ex As Exception
                    XtraMessageBox.Show(ex.Message)
                End Try
                Try
                    cmd = New SqlCommand("Select IdEstadoCivil From EstadoCivil Where EstadoCivil= '" & CmbEstadoCivil.Text & "'")
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = conec.Con
                    Dim dr2 As SqlDataReader
                    dr2 = cmd.ExecuteReader

                    If dr2.Read Then
                        datos.gIdEstadoCivil = dr2(0)
                    End If
                    dr2.Close()
                Catch ex As Exception
                    XtraMessageBox.Show(ex.Message)
                End Try
                Try
                    cmd = New SqlCommand("Select IdCargo From Cargo Where Cargo= '" & CboCargo.Text & "'")
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = conec.Con
                    Dim dr3 As SqlDataReader
                    dr3 = cmd.ExecuteReader

                    If dr3.Read Then
                        datos.gIdCargo = dr3(0)
                    End If
                    dr3.Close()
                Catch ex As Exception
                    XtraMessageBox.Show(ex.Message)
                End Try

                Try
                    cmd = New SqlCommand("Select IdProfesion From Profesion Where Profesion= '" & CboProfesion.Text & "'")

                    cmd.CommandType = CommandType.Text
                    cmd.Connection = conec.Con
                    Dim dr4 As SqlDataReader
                    dr4 = cmd.ExecuteReader

                    If dr4.Read Then
                        datos.gIdProfesion = dr4(0)

                    End If
                    dr4.Close()
                Catch ex As Exception
                    XtraMessageBox.Show(ex.Message)
                End Try

                Try
                    cmd = New SqlCommand("Select IdSucursal From Sucursal Where Sucursal= '" & CboSucursal.Text & "'")
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = conec.Con
                    Dim dr5 As SqlDataReader
                    dr5 = cmd.ExecuteReader

                    If dr5.Read Then
                        datos.gIdSucursal = dr5(0)
                    End If
                    dr5.Close()
                Catch ex As Exception
                    XtraMessageBox.Show(ex.Message)
                End Try

                'Ejecución de la accion para la manipulación de los datos
                If funcion.EditarEmpleado(datos) Then
                    XtraMessageBox.Show("Empleado editado con éxito", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Limpiar()
                    Mostrar()
                    PbEmpleado.Image = Nothing
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                conec.Desconectarse()
            End Try

        End If

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        'Agregar imagen al PictureBox
        OpenFileDialog1.Filter = "Imagenes JPG|*.jpg|Imagenes GIF|*.gif|Imagenes Bitmasps|*.bmp"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PbEmpleado.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        PbEmpleado.Image = Nothing
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        GCPrincipal.ShowPrintPreview()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Exportar_a_Excel(GCPrincipal, Me.Text)
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Exportar_a_PDF(GCPrincipal, Me.Text)
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        Mostrar()
        LlenarComboCargo()
        LlenarComboEstadoCivil()
        LlenarComboMunicipio()
        LlenarComboProfesion()
        LlenarComboSexo()
        LlenarComboSucursal()
    End Sub

    Private Sub BtnBusquedaMunicipio_Click(sender As Object, e As EventArgs) Handles BtnBusquedaMunicipio.Click
        With FrmMunicipio
            FrmMunicipio.var = 2
            .MdiParent = FrmMenuPrincipal
            .Dock = DockStyle.Fill
            .Show()
        End With
    End Sub

    Private Sub BtnBCargo_Click(sender As Object, e As EventArgs) Handles BtnBCargo.Click
        With frmCargo
            frmCargo.var = 1
            .MdiParent = FrmMenuPrincipal
            .Dock = DockStyle.Fill
            .Show()
        End With
    End Sub

    Private Sub BtnBProfesion_Click(sender As Object, e As EventArgs) Handles BtnBProfesion.Click
        With FrmProfesiones
            FrmProfesiones.var = 1
            .MdiParent = FrmMenuPrincipal
            .Dock = DockStyle.Fill
            .Show()
        End With
    End Sub

    Private Sub DgvEmpleado_Click(sender As Object, e As EventArgs) Handles DgvEmpleado.Click


        TxtIdEmpleado.EditValue = DgvEmpleado.GetRowCellValue(DgvEmpleado.FocusedRowHandle, ColIdEmpleado)
        TxtNombres.EditValue = DgvEmpleado.GetRowCellValue(DgvEmpleado.FocusedRowHandle, ColNombre)
        TxtApellidos.EditValue = DgvEmpleado.GetRowCellValue(DgvEmpleado.FocusedRowHandle, ColApellido)
        TxtDireccion.EditValue = DgvEmpleado.GetRowCellValue(DgvEmpleado.FocusedRowHandle, ColDireccion)
        TxtTelefono.EditValue = DgvEmpleado.GetRowCellValue(DgvEmpleado.FocusedRowHandle, ColTelefono)
        TxtCelular.EditValue = DgvEmpleado.GetRowCellValue(DgvEmpleado.FocusedRowHandle, ColCel)
        DteFechaNac.EditValue = DgvEmpleado.GetRowCellValue(DgvEmpleado.FocusedRowHandle, ColFechaN)
        CmbMunicipio.Text = DgvEmpleado.GetRowCellValue(DgvEmpleado.FocusedRowHandle, ColMunicipio)
        CboCargo.Text = DgvEmpleado.GetRowCellValue(DgvEmpleado.FocusedRowHandle, ColCargo)
        DteFechaC.Text = DgvEmpleado.GetRowCellValue(DgvEmpleado.FocusedRowHandle, ColFechaC)
        CboProfesion.Text = DgvEmpleado.GetRowCellValue(DgvEmpleado.FocusedRowHandle, ColProfesion)
        CboSucursal.Text = DgvEmpleado.GetRowCellValue(DgvEmpleado.FocusedRowHandle, ColSucursal)
        CmbEstadoCivil.Text = DgvEmpleado.GetRowCellValue(DgvEmpleado.FocusedRowHandle, ColEstadoC)
        CboSexo.Text = DgvEmpleado.GetRowCellValue(DgvEmpleado.FocusedRowHandle, ColSexo)


        Try
            conec.Conectarse()
            cmd = New SqlCommand("Select Imagen From Empleado Where IdEmpleado= '" & TxtIdEmpleado.Text & "'")
            cmd.CommandType = CommandType.Text
            cmd.Connection = conec.Con
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader

            If dr.Read Then
                Dim img() As Byte = DirectCast(dr(0), Byte())
                PbEmpleado.Image = ByteArrayToImage(img)
            End If
            dr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try


    End Sub
    Public Shared Function ByteArrayToImage(ByVal byteArrayIn As Byte()) As Image

        Dim ms As New MemoryStream(byteArrayIn)
        Return Image.FromStream(ms)

    End Function

    Private Sub DgvEmpleado_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles DgvEmpleado.FocusedRowChanged
        TxtIdEmpleado.EditValue = DgvEmpleado.GetRowCellValue(DgvEmpleado.FocusedRowHandle, ColIdEmpleado)
        TxtNombres.EditValue = DgvEmpleado.GetRowCellValue(DgvEmpleado.FocusedRowHandle, ColNombre)
        TxtApellidos.EditValue = DgvEmpleado.GetRowCellValue(DgvEmpleado.FocusedRowHandle, ColApellido)
        TxtDireccion.EditValue = DgvEmpleado.GetRowCellValue(DgvEmpleado.FocusedRowHandle, ColDireccion)
        TxtTelefono.EditValue = DgvEmpleado.GetRowCellValue(DgvEmpleado.FocusedRowHandle, ColTelefono)
        TxtCelular.EditValue = DgvEmpleado.GetRowCellValue(DgvEmpleado.FocusedRowHandle, ColCel)
        DteFechaNac.EditValue = DgvEmpleado.GetRowCellValue(DgvEmpleado.FocusedRowHandle, ColFechaN)
        CmbMunicipio.Text = DgvEmpleado.GetRowCellValue(DgvEmpleado.FocusedRowHandle, ColMunicipio)
        CboCargo.Text = DgvEmpleado.GetRowCellValue(DgvEmpleado.FocusedRowHandle, ColCargo)
        DteFechaC.Text = DgvEmpleado.GetRowCellValue(DgvEmpleado.FocusedRowHandle, ColFechaC)
        CboProfesion.Text = DgvEmpleado.GetRowCellValue(DgvEmpleado.FocusedRowHandle, ColProfesion)
        CboSucursal.Text = DgvEmpleado.GetRowCellValue(DgvEmpleado.FocusedRowHandle, ColSucursal)
        CmbEstadoCivil.Text = DgvEmpleado.GetRowCellValue(DgvEmpleado.FocusedRowHandle, ColEstadoC)
        CboSexo.Text = DgvEmpleado.GetRowCellValue(DgvEmpleado.FocusedRowHandle, ColSexo)


        Try
            conec.Conectarse()
            cmd = New SqlCommand("Select Imagen From Empleado Where IdEmpleado= '" & TxtIdEmpleado.Text & "'")
            cmd.CommandType = CommandType.Text
            cmd.Connection = conec.Con
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader

            If dr.Read Then
                Dim img() As Byte = DirectCast(dr(0), Byte())
                PbEmpleado.Image = ByteArrayToImage(img)
            End If
            dr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub
End Class