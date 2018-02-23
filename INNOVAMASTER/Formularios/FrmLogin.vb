Imports System.ComponentModel
Imports DevExpress.XtraEditors
Imports System.Data.SqlClient

Public Class FrmLogin

    Dim Conec As New Conexion


    Private Function Validar() As Boolean
        Dim estado As Boolean
        If TxtUsuario.Text = Nothing And TxtContrasena.Text = Nothing Then
            TxtUsuario.Focus()
            EpMensaje.SetError(TxtUsuario, "Ingrese el Usuario")
            EpMensaje.SetError(TxtContrasena, "Ingrese la Contraseña")
            estado = False
        ElseIf TxtUsuario.Text = Nothing Then
            TxtUsuario.Focus()
            EpMensaje.SetError(TxtUsuario, "Ingrese el Usuario")
            EpMensaje.SetError(TxtContrasena, "")
            estado = False
        ElseIf TxtContrasena.Text = Nothing Then
            TxtContrasena.Focus()
            EpMensaje.SetError(TxtUsuario, "")
            EpMensaje.SetError(TxtContrasena, "Ingrese la Contraseña")
            estado = False
        Else
            EpMensaje.SetError(TxtUsuario, "")
            EpMensaje.SetError(TxtContrasena, "")
            estado = True
        End If
        Return estado
    End Function
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cone As New Conexion
        If cone.Conectarse() = False Then
            FrmConfiguracion.Label5.Text = "1"
            FrmConfiguracion.txtUsername.Text = Nothing
            FrmConfiguracion.txtPassword.Text = Nothing
            FrmConfiguracion.txtDB.Text = Nothing
            FrmConfiguracion.txtServer.Text = Nothing
            FrmConfiguracion.Show()
            Me.Close()
            Exit Sub
        End If

        Dim NombreArchivo As String = HTMLHelpClass.GetLocalHelpFileName("InnovaMasterAyuda2017.chm")
        HelpProvider1.HelpNamespace = NombreArchivo
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "Inicio de Sesión")
        Me.Focus()
        FrmMenuPrincipal.Close()
    End Sub


    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Application.Exit()
        My.Settings.Save()
    End Sub

    Private Sub BtnIniciar_Click(sender As Object, e As EventArgs) Handles BtnIniciar.Click
        If Validar() Then
            Try
                Conec.Conectarse()
                Dim dr As SqlClient.SqlDataReader
                Dim cmd As New SqlClient.SqlCommand("Logeo", Conec.Con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Usuario", Replace(TxtUsuario.Text, "'", ""))
                cmd.Parameters.AddWithValue("@Contrasena", Replace(SHA1(TxtContrasena.Text), "'", ""))


                dr = cmd.ExecuteReader
                If dr.Read Then
                    If dr("Estado").ToString = "Activo" Then
                        FrmMenuPrincipal.LblIdUsuario.Text = dr.GetValue(0).ToString
                        FrmMenuPrincipal.BarButtonBaseDatos.Caption = BaseDatos
                        FrmMenuPrincipal.BarButtonServidor.Caption = Ip
                        FrmMenuPrincipal.BarButtonUsuario.Caption = TxtUsuario.Text.Trim.ToUpper
                        FrmMenuPrincipal.BarButtonVersion.Caption = FrmMenuPrincipal.BarButtonVersion.Caption & ": " & ProductVersion
                        If dr.GetValue(1).ToString = "Administrador" Then
                            Permisos()
                            Acerca_de_InnovaMaster.Close()
                            frmCargo.Close()
                            FrmBackup.Close()
                            FrmConfiguracion.Close()
                            FrmCliente.Close()
                            FrmCompras.Close()
                            FrmMunicipio.Close()
                            FrmDepartamento.Close()
                            FrmPais.Close()
                            FrmProducto.Close()
                            FrmCategoria.Close()
                            FrmMarca.Close()
                            FrmModelo.Close()
                            FrmUsuario.Close()
                            FrmEmpleado.Close()
                            FrmProfesiones.Close()
                            FrmProveedor.Close()
                            FrmVenta.Close()
                            FrmFactura.Close()
                            FrmLogAuditoria.Close()
                            FrmFacturacionVenta.Close()
                            FrmPedidos.Close()
                            FrmPermisos.Close()
                            FrmRptCliente.Close()
                            FrmRptCompra.Close()
                            FrmRptPedido.Close()
                            FrmRptProducto.Close()
                            FrmPExistencia.Close()
                            ReporteClientes.Close()
                            ReporteCompras.Close()
                            ReportePedido.Close()
                            ReporteProductos.Close()
                            ReporteVentas.Close()
                        Else
                            Permisos()
                            Acerca_de_InnovaMaster.Close()
                            frmCargo.Close()
                            FrmBackup.Close()
                            FrmConfiguracion.Close()
                            FrmCliente.Close()
                            FrmCompras.Close()
                            FrmMunicipio.Close()
                            FrmDepartamento.Close()
                            FrmPais.Close()
                            FrmProducto.Close()
                            FrmCategoria.Close()
                            FrmMarca.Close()
                            FrmModelo.Close()
                            FrmUsuario.Close()
                            FrmEmpleado.Close()
                            FrmProfesiones.Close()
                            FrmProveedor.Close()
                            FrmVenta.Close()
                            FrmFactura.Close()
                            FrmLogAuditoria.Close()
                            FrmFacturacionVenta.Close()
                            FrmPedidos.Close()
                            FrmPermisos.Close()
                            FrmRptCliente.Close()
                            FrmRptCompra.Close()
                            FrmRptPedido.Close()
                            FrmRptProducto.Close()
                            FrmPExistencia.Close()
                            ReporteClientes.Close()
                            ReporteCompras.Close()
                            ReportePedido.Close()
                            ReporteProductos.Close()
                            ReporteVentas.Close()
                        End If

                        Me.Hide()
                        FrmMenuPrincipal.Show()
                    Else
                        XtraMessageBox.Show("Usuario Inactivo", "INNOVAMASTER")
                    End If

                Else
                    MsgBox("Usuario o Contraseña No Valido", MsgBoxStyle.Critical)
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub BtnConfiguracion_Click(sender As Object, e As EventArgs) Handles BtnConfiguracion.Click
        FrmConfiguracion.Show()
    End Sub

    Private Sub ChkVer_CheckedChanged_1(sender As Object, e As EventArgs) Handles ChkVer.CheckedChanged
        If ChkVer.Checked = True Then
            TxtContrasena.UseSystemPasswordChar = False
        Else
            TxtContrasena.UseSystemPasswordChar = True
        End If
    End Sub



    Private Sub TxtContrasena_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtContrasena.KeyPress
        If Asc(e.KeyChar) = 13 Then
            BtnIniciar.PerformClick()
        End If
    End Sub

    Private Sub TxtUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnIniciar.PerformClick()
        End If
    End Sub
    Private Sub Permisos()
        Try
            Conec.Conectarse()
            Dim ID As Integer
            Dim dr As SqlClient.SqlDataReader
            Dim cmd As New SqlClient.SqlCommand("Select IdUsuario From Usuario Where Usuario = '" & Replace(TxtUsuario.Text, "'", "") & "'", Conec.Con)
            cmd.CommandType = CommandType.Text
            dr = cmd.ExecuteReader()

            If dr.Read Then
                ID = CInt(dr(0))
                MostrarPermisosDenegados(ID)
                MostrarPermisosPermitidos(ID)
            End If


        Catch ex As Exception
            XtraMessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub MostrarPermisosDenegados(ByVal IdUsuario As Integer)

        Try
            Dim cmd As New SqlCommand
            Dim dr As SqlClient.SqlDataReader
            Conec.Conectarse()
            cmd = New SqlCommand("SP_MostraPermisosDenegados")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = Conec.Con

            cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = IdUsuario

            dr = cmd.ExecuteReader

            While dr.Read()
                If dr.GetValue(2).ToString = "VENTAS" Then
                    FrmMenuPrincipal.PagVentas.Enabled = False
                End If
                If dr.GetValue(2).ToString = "CLIENTES" Then
                    FrmMenuPrincipal.RibbonPageGroupCliente.Enabled = False
                End If
                If dr.GetValue(2).ToString = "EMPLEADOS" Then
                    FrmMenuPrincipal.RibbonGroupEmpleados.Enabled = False
                End If
                If dr.GetValue(2).ToString = "USUARIOS" Then
                    FrmMenuPrincipal.RibbonPageGroupUsuario.Enabled = False
                End If
                If dr.GetValue(2).ToString = "PRODUCTOS" Then
                    FrmMenuPrincipal.PagProductos.Enabled = False
                End If
                If dr.GetValue(2).ToString = "COMPRAS" Then
                    FrmMenuPrincipal.PagComprasPedidos.Enabled = False
                End If
                If dr.GetValue(2).ToString = "PROVEEDORES" Then
                    FrmMenuPrincipal.RibbonPageGroupProveedores.Enabled = False
                End If
                If dr.GetValue(2).ToString = "UBICACIÓN" Then
                    FrmMenuPrincipal.RibbonGroupUbucacion.Enabled = False
                End If
                If dr.GetValue(2).ToString = "CONFIGURACIÓN" Then
                    FrmMenuPrincipal.PagConfiguracion.Enabled = False
                End If
                If dr.GetValue(2).ToString = "AUDITORÍA" Then
                    FrmMenuPrincipal.PagAuditoria.Enabled = False
                End If
                If dr.GetValue(2).ToString = "REPORTES" Then
                    FrmMenuPrincipal.RibbonPageGroupReportes.Enabled = False
                End If

            End While

        Catch ex As Exception
            XtraMessageBox.Show(ex.ToString)
        Finally
            Conec.Desconectarse()
        End Try
    End Sub
    Private Sub MostrarPermisosPermitidos(ByVal IdUsuario As Integer)

        Try
            Dim cmd As New SqlCommand
            Dim dr As SqlClient.SqlDataReader
            Conec.Conectarse()
            cmd = New SqlCommand("SP_MostraPermisosPermitidos")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = Conec.Con

            cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = IdUsuario

            dr = cmd.ExecuteReader

            While dr.Read()
                If dr.GetValue(2).ToString = "VENTAS" Then
                    FrmMenuPrincipal.PagVentas.Enabled = True
                End If
                If dr.GetValue(2).ToString = "CLIENTES" Then
                    FrmMenuPrincipal.RibbonPageGroupCliente.Enabled = True
                End If
                If dr.GetValue(2).ToString = "EMPLEADOS" Then
                    FrmMenuPrincipal.RibbonGroupEmpleados.Enabled = True
                End If
                If dr.GetValue(2).ToString = "USUARIOS" Then
                    FrmMenuPrincipal.RibbonPageGroupUsuario.Enabled = True
                End If
                If dr.GetValue(2).ToString = "PRODUCTOS" Then
                    FrmMenuPrincipal.PagProductos.Enabled = True
                End If
                If dr.GetValue(2).ToString = "COMPRAS" Then
                    FrmMenuPrincipal.PagComprasPedidos.Enabled = True
                End If

                If dr.GetValue(2).ToString = "PROVEEDORES" Then
                    FrmMenuPrincipal.RibbonPageGroupProveedores.Enabled = True
                End If
                If dr.GetValue(2).ToString = "UBICACIÓN" Then
                    FrmMenuPrincipal.RibbonGroupUbucacion.Enabled = True
                End If
                If dr.GetValue(2).ToString = "CONFIGURACIÓN" Then
                    FrmMenuPrincipal.PagConfiguracion.Enabled = True
                End If
                If dr.GetValue(2).ToString = "AUDITORÍA" Then
                    FrmMenuPrincipal.PagAuditoria.Enabled = True
                End If
                If dr.GetValue(2).ToString = "REPORTES" Then
                    FrmMenuPrincipal.RibbonPageGroupReportes.Enabled = True
                End If

            End While

        Catch ex As Exception
            XtraMessageBox.Show(ex.ToString)
        Finally
            Conec.Desconectarse()
        End Try
    End Sub
End Class