Imports System.ComponentModel
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors

Public Class FrmCliente
    Dim dt As New DataTable
    Dim Conec As New Conexion
    Dim cmd As SqlCommand
    Public Var As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Focus()
        Mostrar()
        LlenarComboMunicipio()
        LlenarComboEstadoCivil()
        LlenarComboSexo()
        BtnInsertar.Visible = False
        BtnCancelar.Visible = False
        BtnEditar.Visible = True
        BtnActualizar.Visible = False
        GbCliente.Enabled = False

        Dim NombreArchivo As String = HTMLHelpClass.GetLocalHelpFileName("InnovaMasterAyuda2017.chm")
        HelpProvider1.HelpNamespace = NombreArchivo
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "Registro Cliente")
    End Sub
    Private Sub Mostrar()
        Try
            Dim funcion As New Fcliente
            dt = funcion.MostrarCliente

            If dt.Rows.Count <> 0 Then
                GCPrincipal.DataSource = dt
                Label11.Visible = False
            Else
                GCPrincipal.DataSource = Nothing
                Label11.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub LlenarComboMunicipio()
        Dim _DT As New DataTable
        Dim da As New SqlDataAdapter
        Try
            Conec.Conectarse()
            cmd = New SqlCommand("MostrarMunicipio")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = Conec.Con

            If (cmd.ExecuteNonQuery()) Then
                da = New SqlDataAdapter(cmd)
                da.Fill(_DT)
                CboMunicipio.Properties.DataSource = _DT
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conec.Desconectarse()
        End Try
    End Sub
    Private Sub LlenarComboEstadoCivil()
        Dim _DT As New DataTable
        Dim da As New SqlDataAdapter
        Try
            Conec.Conectarse()
            cmd = New SqlCommand("Select * From EstadoCivil")
            cmd.CommandType = CommandType.Text
            cmd.Connection = Conec.Con

            If (cmd.ExecuteNonQuery()) Then
                da = New SqlDataAdapter(cmd)
                da.Fill(_DT)
                CboEstadoCivil.Properties.DataSource = _DT
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conec.Desconectarse()
        End Try
    End Sub
    Public Sub LlenarComboSexo()
        Dim _DT As New DataTable
        Dim da As New SqlDataAdapter
        Try
            Conec.Conectarse()
            cmd = New SqlCommand("Select * From Sexo")
            cmd.CommandType = CommandType.Text
            cmd.Connection = Conec.Con

            If (cmd.ExecuteNonQuery()) Then
                da = New SqlDataAdapter(cmd)
                da.Fill(_DT)
                CboSexo.Properties.DataSource = _DT
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conec.Desconectarse()
        End Try
    End Sub
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        TxtIdCliente.Enabled = True
        GbCliente.Enabled = True
        BtnNuevo.Visible = False
        BtnInsertar.Visible = True
        BtnCancelar.Visible = True
        BtnEditar.Visible = False
        GCPrincipal.Enabled = False
        TxtIdCliente.EditValue = Nothing
        TxtNombre.EditValue = Nothing
        TxtDireccion.EditValue = Nothing
        TxtApellidos.EditValue = Nothing
        TxtCorreo.EditValue = Nothing
        TxtTelefono.EditValue = Nothing
        TxtFecha.EditValue = Nothing
        CboMunicipio.EditValue = Nothing
        CboEstadoCivil.EditValue = Nothing
        CboSexo.EditValue = Nothing
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim R As DialogResult
        R = XtraMessageBox.Show("¿Desea Cancelar el Proceso?", "INNOVAMASTER", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If R = DialogResult.Yes Then
            Limpiar()
            Me.Focus()
        End If

    End Sub
    Private Sub BtnInsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        If TxtIdCliente.Text.Length < 15 Then
            XtraMessageBox.Show("Ingrese el Numero de Identidad del Cliente", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TxtNombre.EditValue = Nothing Then
            XtraMessageBox.Show("Ingrese el Nombre del Cliente", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TxtApellidos.EditValue = Nothing Then
            XtraMessageBox.Show("Ingrese el apellido del Cliente", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TxtDireccion.EditValue = Nothing Then
            XtraMessageBox.Show("Ingrese la dirección del Cliente", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf CboSexo.EditValue = Nothing Then
            XtraMessageBox.Show("Seleccione el sexo del Cliente", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf CboMunicipio.EditValue = Nothing Then
            XtraMessageBox.Show("Seleccione el municipio del Cliente", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf CboEstadoCivil.EditValue = Nothing Then
            XtraMessageBox.Show("Seleccione el estado civil del Cliente", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TxtFecha.EditValue = Nothing
            XtraMessageBox.Show("Seleccione la fecha del Cliente", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Dim datos As New DatosCliente
                Dim funcion As New Fcliente
                datos.gIdCliente = TxtIdCliente.EditValue
                datos.gNombreCliente = TxtNombre.EditValue
                datos.gApellidoCliente = TxtApellidos.EditValue
                datos.gDireccionCliente = TxtDireccion.EditValue
                datos.gTelefonoCliente = TxtTelefono.EditValue
                datos.gCorreoCliente = TxtCorreo.EditValue
                datos.gFechaNacimiento = CDate(TxtFecha.EditValue)
                datos.gIdSexo = CInt(CboSexo.EditValue)
                datos.gIdMunicipio = CInt(CboMunicipio.EditValue)
                datos.gIdEstadoCivil = CInt(CboEstadoCivil.EditValue)


                If funcion.InsertarCliente(datos) Then
                    XtraMessageBox.Show("Cliente Ingresado con Éxito", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Limpiar()
                    Mostrar()
                    Focus()
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                Conec.Desconectarse()
            End Try

        End If

    End Sub
    Private Sub Limpiar()
        GbCliente.Enabled = False
        BtnInsertar.Visible = False
        BtnNuevo.Visible = True
        BtnEditar.Visible = False
        BtnNuevo.Visible = True
        BtnCancelar.Visible = False
        GCPrincipal.Enabled = True
        TxtIdCliente.EditValue = Nothing
        TxtNombre.EditValue = Nothing
        TxtDireccion.EditValue = Nothing
        TxtFecha.EditValue = Nothing
        TxtApellidos.EditValue = Nothing
        TxtCorreo.EditValue = Nothing
        TxtTelefono.EditValue = Nothing
        CboMunicipio.EditValue = Nothing
        CboEstadoCivil.EditValue = Nothing
        CboSexo.EditValue = Nothing
    End Sub
    Private Sub BtnNuevoEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If TxtNombre.EditValue <> Nothing Then
            GbCliente.Enabled = True
            BtnNuevo.Visible = False
            BtnInsertar.Visible = False
            BtnEditar.Visible = True
            BtnNuevo.Visible = False
            BtnCancelar.Visible = True
            GCPrincipal.Enabled = False
            TxtIdCliente.Enabled = False
            Focus()
        Else
            XtraMessageBox.Show("Seleccione el Cliente a Editar", "Seleccionar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub
    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If TxtIdCliente.Text.Length < 15 Then
            XtraMessageBox.Show("Ingrese el Numero de Identidad del Cliente", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TxtNombre.EditValue = Nothing Then
            XtraMessageBox.Show("Ingrese el Nombre del Cliente", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TxtApellidos.EditValue = Nothing Then
            XtraMessageBox.Show("Ingrese el apellido del Cliente", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TxtDireccion.EditValue = Nothing Then
            XtraMessageBox.Show("Ingrese la dirección del Cliente", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf CboSexo.EditValue = Nothing Then
            XtraMessageBox.Show("Seleccione el sexo del Cliente", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf CboMunicipio.EditValue = Nothing Then
            XtraMessageBox.Show("Seleccione el municipio del Cliente", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf CboEstadoCivil.EditValue = Nothing Then
            XtraMessageBox.Show("Seleccione el estado civil del Cliente", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TxtFecha.EditValue = Nothing
            XtraMessageBox.Show("Seleccione la fecha del Cliente", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Dim datos As New DatosCliente
                Dim funcion As New Fcliente
                datos.gIdCliente = TxtIdCliente.EditValue
                datos.gNombreCliente = TxtNombre.EditValue
                datos.gApellidoCliente = TxtApellidos.EditValue
                datos.gDireccionCliente = TxtDireccion.EditValue
                datos.gTelefonoCliente = TxtTelefono.EditValue
                datos.gCorreoCliente = TxtCorreo.EditValue
                datos.gFechaNacimiento = CDate(TxtFecha.EditValue)
                datos.gIdSexo = CInt(CboSexo.EditValue)
                datos.gIdMunicipio = CInt(CboMunicipio.EditValue)
                datos.gIdEstadoCivil = CInt(CboEstadoCivil.EditValue)
                If funcion.EditarCliente(datos) Then
                    XtraMessageBox.Show("Cliente actualizado con Éxito", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Limpiar()
                    Mostrar()
                    Focus()
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                Conec.Desconectarse()
            End Try

        End If
    End Sub

    Private Sub FrmCliente_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        LblRelacionClienteVenta.Text = "0"
    End Sub



    Private Sub BtnBusquedaCliente_Click(sender As Object, e As EventArgs)
        With FrmMunicipio
            FrmMunicipio.var = 1
            .MdiParent = MenuPrincipal
            .Dock = DockStyle.Fill
            .Show()
        End With
    End Sub


    Private Sub GCPrincipal_Click(sender As Object, e As EventArgs) Handles GCPrincipal.Click
        TxtIdCliente.EditValue = DgvClientes.GetRowCellValue(DgvClientes.FocusedRowHandle, ColIdCliente)
        TxtDireccion.EditValue = DgvClientes.GetRowCellValue(DgvClientes.FocusedRowHandle, ColDireccion)
        TxtTelefono.EditValue = DgvClientes.GetRowCellValue(DgvClientes.FocusedRowHandle, ColTelefono)
        TxtCorreo.EditValue = DgvClientes.GetRowCellValue(DgvClientes.FocusedRowHandle, ColCorreo)
        CboMunicipio.Text = DgvClientes.GetRowCellValue(DgvClientes.FocusedRowHandle, ColMunicipio)
        CboEstadoCivil.Text = DgvClientes.GetRowCellValue(DgvClientes.FocusedRowHandle, ColEstadoCivil)
        CboSexo.Text = DgvClientes.GetRowCellValue(DgvClientes.FocusedRowHandle, ColSexo)
        TxtFecha.EditValue = DgvClientes.GetRowCellValue(DgvClientes.FocusedRowHandle, ColFechaNacimiento)


        Try
            Conec.Conectarse()
            cmd.CommandType = CommandType.Text
            cmd = New SqlCommand("Select NombreCliente, ApellidoCliente from Cliente Where IdCliente = '" & DgvClientes.GetRowCellValue(DgvClientes.FocusedRowHandle, ColIdCliente) & "'")
            cmd.Connection = Conec.Con
            Dim dr As SqlDataReader

            dr = cmd.ExecuteReader

            If dr.Read Then
                TxtNombre.EditValue = dr(0)
                TxtApellidos.EditValue = dr(1)
            End If
            dr.Close()

        Catch ex As Exception
        Finally
            Conec.Desconectarse()
        End Try
    End Sub

    Private Sub GCPrincipal_DoubleClick(sender As Object, e As EventArgs) Handles GCPrincipal.DoubleClick
        If LblRelacionClienteVenta.Text = "1" Then
            '' FrmVenta.TxtIdCliente.Text = DgvClientes.GetRowCellValue(DgvClientes.FocusedRowHandle, ColIdCliente)
            '' LblRelacionClienteVenta.Text = "0"
            ''Me.Close()
        ElseIf LblRelacionClienteVenta.Text = "2" Then
            FrmFacturacionVenta.CboCliente.EditValue = DgvClientes.GetRowCellValue(DgvClientes.FocusedRowHandle, ColIdCliente)
            LblRelacionClienteVenta.Text = "0"
            Me.Close()

        End If
    End Sub

    Private Sub DgvClientes_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles DgvClientes.FocusedRowChanged
        TxtIdCliente.EditValue = DgvClientes.GetRowCellValue(DgvClientes.FocusedRowHandle, ColIdCliente)
        TxtDireccion.EditValue = DgvClientes.GetRowCellValue(DgvClientes.FocusedRowHandle, ColDireccion)
        TxtTelefono.EditValue = DgvClientes.GetRowCellValue(DgvClientes.FocusedRowHandle, ColTelefono)
        TxtCorreo.EditValue = DgvClientes.GetRowCellValue(DgvClientes.FocusedRowHandle, ColCorreo)
        CboMunicipio.Text = DgvClientes.GetRowCellValue(DgvClientes.FocusedRowHandle, ColMunicipio)
        CboEstadoCivil.Text = DgvClientes.GetRowCellValue(DgvClientes.FocusedRowHandle, ColEstadoCivil)
        CboSexo.Text = DgvClientes.GetRowCellValue(DgvClientes.FocusedRowHandle, ColSexo)
        TxtFecha.EditValue = DgvClientes.GetRowCellValue(DgvClientes.FocusedRowHandle, ColFechaNacimiento)


        Try
            Conec.Conectarse()
            cmd.CommandType = CommandType.Text
            cmd = New SqlCommand("Select NombreCliente, ApellidoCliente from Cliente Where IdCliente = '" & DgvClientes.GetRowCellValue(DgvClientes.FocusedRowHandle, ColIdCliente) & "'")
            cmd.Connection = Conec.Con
            Dim dr As SqlDataReader

            dr = cmd.ExecuteReader

            If dr.Read Then
                TxtNombre.EditValue = dr(0)
                TxtApellidos.EditValue = dr(1)
            End If
            dr.Close()

        Catch ex As Exception
        Finally
            Conec.Desconectarse()
        End Try
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        Mostrar()
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Exportar_a_PDF(GCPrincipal, Me.Text)
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Exportar_a_Excel(GCPrincipal, Me.Text)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        GCPrincipal.ShowPrintPreview()
    End Sub
End Class
