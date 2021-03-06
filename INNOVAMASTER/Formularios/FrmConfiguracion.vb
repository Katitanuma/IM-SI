﻿Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Configuration
Public Class FrmConfiguracion
    Dim conec As New Conexion
    Dim EC As Estado_Conexion
    Dim CSBuilder As New SqlConnectionStringBuilder
    Private Enum Estado_Conexion
        NoComprobada
        Establecida
        NoEstablecida
    End Enum


    Private Sub FrmConfiguracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.Reload()
        Dim cadena As String = My.Settings.Conect1.ToString

        Dim c As String() = cadena.Split(";")
        txtServer.Text = Replace(c(0), "Data Source=", "")
        txtDB.Text = Replace(c(1), "Initial Catalog=", "")
        Dim n As String = Replace(c(2), "User ID=", "")
        txtUsername.Text = Replace(n, " ", "")
        txtPassword.Text = Replace(c(3), "Password=", "")

        Dim NombreArchivo As String = HTMLHelpClass.GetLocalHelpFileName("InnovaMasterAyuda2017.chm")
        HelpProvider1.HelpNamespace = NombreArchivo
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "Configuración")
    End Sub
    Private Sub FrmConfiguracion_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Settings.Save()
    End Sub

    Private Sub txtServer_KeyDown(sender As Object, e As KeyEventArgs) Handles txtServer.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnTestConnection.PerformClick()
        End If
    End Sub

    Private Sub txtDB_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDB.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnTestConnection.PerformClick()
        End If
    End Sub

    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnTestConnection.PerformClick()
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnTestConnection.PerformClick()
        End If
    End Sub

    Private Sub txtUsername_EditValueChanged(sender As Object, e As EventArgs) Handles txtUsername.EditValueChanged, txtServer.EditValueChanged, txtPassword.EditValueChanged, txtDB.EditValueChanged
        EC = Estado_Conexion.NoComprobada
        lblConnStatus.Text = "Conexión no comprobada."
        If Not String.IsNullOrWhiteSpace(txtServer.Text) And Not String.IsNullOrWhiteSpace(txtDB.Text) And
                Not String.IsNullOrWhiteSpace(txtUsername.Text) And Not String.IsNullOrWhiteSpace(txtPassword.Text) Then
            btnTestConnection.Enabled = True
        Else
            btnTestConnection.Enabled = False
        End If
    End Sub

    Private Sub btnTestConnection_Click(sender As Object, e As EventArgs) Handles btnTestConnection.Click
        btnTestConnection.Enabled = False
        lblConnStatus.Text = "Comprobando la conexión..."
        lblConnStatus.Refresh()
        With CSBuilder
            .DataSource = txtServer.Text : .InitialCatalog = txtDB.Text : .IntegratedSecurity = False
            .UserID = txtUsername.Text : .Password = txtPassword.Text
        End With
        Dim Cnx As New SqlConnection(CSBuilder.ConnectionString)
        Try
            Cnx.Open()
            EC = Estado_Conexion.Establecida
            lblConnStatus.Text = "Conexión establecida exitosamente."
            Dim nuevaCadenaConexion As String = "Data Source=" & txtServer.Text & ";Initial Catalog=" & txtDB.Text & ";User ID=" & txtUsername.Text & ";Password=" & txtPassword.Text & ""

            Dim guardarIni As New FileIni
            guardarIni.IniWrite(RUTA_INI, "Configuracion", "IP", Encriptar(txtServer.Text))
            guardarIni.IniWrite(RUTA_INI, "Configuracion", "BASE_DATOS", Encriptar(txtDB.Text))
            guardarIni.IniWrite(RUTA_INI, "Configuracion", "USUARIO", Encriptar(txtUsername.Text))
            guardarIni.IniWrite(RUTA_INI, "Configuracion", "CONTRASENA", Encriptar(txtPassword.Text))


            Ip = txtServer.Text.Trim
            BaseDatos = txtDB.Text.Trim
            Usuario = txtUsername.Text.Trim
            Contrasena = txtPassword.Text.Trim
            FrmMenuPrincipal.BarButtonBaseDatos.Caption = BaseDatos
            FrmMenuPrincipal.BarButtonServidor.Caption = Ip
            FrmMenuPrincipal.BarButtonUsuario.Caption = Usuario.Trim.ToUpper
            FrmMenuPrincipal.BarButtonVersion.Caption = "Versión" & ": " & Application.ProductVersion


            'Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath)
            'Dim connectionStringsSection As ConnectionStringsSection = DirectCast(config.GetSection("connectionStrings"), ConnectionStringsSection)
            'connectionStringsSection.ConnectionStrings("INNOVAMASTER.My.MySettings.Conect").ConnectionString = nuevaCadenaConexion
            'config.Save(ConfigurationSaveMode.Modified, False)

            My.Settings.Conect1 = nuevaCadenaConexion
            My.Settings.Save()

            If Label5.Text = "1" Then
                Label5.Text = "0"
                FrmLogin.Show()
                Me.Close()

            End If
        Catch ex As Exception
            MessageBox.Show("Error en la conexion con el servidor", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Error)
            EC = Estado_Conexion.NoEstablecida
            lblConnStatus.Text = "Error en la conexión"
        Finally
            btnTestConnection.Enabled = True
            Cnx.Close()
        End Try

    End Sub
End Class