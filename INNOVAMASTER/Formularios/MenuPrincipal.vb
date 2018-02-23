Imports DevExpress.XtraLayout
Imports DevExpress.XtraLayout.Helpers
Imports System.ComponentModel.DataAnnotations
Imports System.IO
Imports System.ComponentModel
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.XtraEditors

Partial Public Class MenuPrincipal
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm


    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableMdiFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()

        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()
        SkinHelper.InitSkinGallery(SkinRibbonGalleryBarItem1, True)

        'Me.LookAndFeel.SkinName = "Office 2007 Silver"
        'Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Silver"

        Dim NombreArchivo As String = HTMLHelpClass.GetLocalHelpFileName("InnovaMasterAyuda2017.chm")
        HelpProvider1.HelpNamespace = NombreArchivo
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "Principal")

        If My.Settings.Tema <> Nothing Then
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = My.Settings.Tema
        End If



    End Sub
    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnRegistroClientes.ItemClick
        Tema = DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName
        FrmCliente.MdiParent = Me
        FrmCliente.Focus()
        FrmCliente.Show()
        FrmCliente.Focus()
    End Sub
    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnRegistroEmpleado.ItemClick
        Tema = DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName
        FrmEmpleado.MdiParent = Me
        FrmEmpleado.Focus()
        FrmEmpleado.Show()
    End Sub
    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnRegistroUsuarios.ItemClick
        Tema = DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName
        FrmUsuario.MdiParent = Me
        FrmUsuario.Focus()
        FrmUsuario.Show()
    End Sub
    Private Sub BarButtonItem7_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick

    End Sub
    Private Sub BarButtonItem9_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        Tema = DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName
        FrmProducto.MdiParent = Me
        FrmProducto.Focus()
        FrmProducto.Show()
    End Sub
    Private Sub BarButtonItem11_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnRegistroVenta.ItemClick


    End Sub
    Private Sub BarButtonItem14_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem14.ItemClick
        Tema = DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName
        FrmConfiguracion.ShowDialog()


    End Sub
    Private Sub BarButtonItem15_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem15.ItemClick
        Tema = DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName
        FrmBackup.ShowDialog()
    End Sub
    Private Sub BarButtonItem16_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnCambiarUsuario.ItemClick

        FrmLogin.Show()
        FrmLogin.TxtUsuario.Text = Nothing
        FrmLogin.TxtContrasena.Clear()
        FrmLogin.ChkVer.Checked = False
        FrmLogin.TxtUsuario.Focus()

        Me.Hide()

    End Sub


    Private Sub BarButtonItem17_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem17.ItemClick
        Tema = DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName
        FrmCategoria.MdiParent = Me
        FrmCategoria.Focus()
        FrmCategoria.Show()
    End Sub

    Private Sub BarButtonItem18_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem18.ItemClick
        'Formulario de Pais
        Tema = DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName
        FrmPais.MdiParent = Me
        FrmPais.Show()
        FrmPais.Focus()
    End Sub

    Private Sub BarButtonItem19_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem19.ItemClick
        Tema = DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName
        FrmDepartamento.MdiParent = Me
        FrmDepartamento.Show()
        FrmDepartamento.Focus()
    End Sub

    Private Sub BarButtonItem20_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem20.ItemClick
        Tema = DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName
        FrmMunicipio.MdiParent = Me
        FrmMunicipio.Focus()
        FrmMunicipio.Show()
    End Sub

    Private Sub BarButtonItem22_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnCargo.ItemClick
        Tema = DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName
        frmCargo.MdiParent = Me
        frmCargo.Focus()
        frmCargo.Show()
    End Sub

    Private Sub BarButtonItem21_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnProfesion.ItemClick
        Tema = DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName
        FrmProfesiones.MdiParent = Me
        FrmProfesiones.Focus()
        FrmProfesiones.Show()
    End Sub

    Private Sub BarButtonItem23_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem23.ItemClick
        Tema = DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName
        FrmMarca.MdiParent = Me
        FrmMarca.Focus()
        FrmMarca.Show()
    End Sub

    Private Sub BarButtonItem24_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem24.ItemClick
        Tema = DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName
        FrmModelo.MdiParent = Me
        FrmModelo.Focus()
        FrmModelo.Show()
    End Sub

    Private Sub MenuPrincipal_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        If EstaAbierto(FrmDetalleVenta) Then
            FrmDetalleVenta.Button1.PerformClick()
            e.Cancel = True
        ElseIf EstaAbierto(FrmCompras) Then
            FrmCompras.Button1.PerformClick()
            e.Cancel = True
        ElseIf EstaAbierto(FrmPedidos) Then
            FrmPedidos.Button1.PerformClick()
            e.Cancel = True
        ElseIf XtraMessageBox.Show("¿Desea Salir del Sistema?", "INNOVAMASTER", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then
            e.Cancel = True
        Else
            My.Settings.Tema = DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName
            My.Settings.Save()
            Application.Exit()
        End If


    End Sub
    Public Function EstaAbierto(ByVal Myform As Form)
        Dim objForm As Form
        Dim blnAbierto As Boolean = False
        blnAbierto = False
        For Each objForm In My.Application.OpenForms
            If (Trim(objForm.Name) = Trim(Myform.Name)) Then
                blnAbierto = True
            End If
        Next
        Return blnAbierto
    End Function

    Private Sub BtnF_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnF.ItemClick


    End Sub

    Private Sub BarButtonItem1_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Tema = DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName
        FrmProveedor.MdiParent = Me
        FrmProveedor.Focus()
        FrmProveedor.Show()
    End Sub

    Private Sub BarButtonItem3_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        Tema = DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName
        FrmCompras.MdiParent = Me
        FrmCompras.Focus()
        FrmCompras.Show()
    End Sub



    Private Sub BarButtonItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        Tema = DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName
        FrmPedidos.MdiParent = Me
        FrmPedidos.Focus()
        FrmPedidos.Show()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Tema = DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName
        ReporteClientes.Location = New Point(285, 220)
        ReporteClientes.Show()


    End Sub

    Private Sub BarButtonItem21_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem21.ItemClick
        Tema = DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName
        ReportePedido.Location = New Point(285, 220)
        ReportePedido.Show()
    End Sub

    Private Sub BarButtonItem16_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem16.ItemClick
        Tema = DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName
        ReporteCompras.Location = New Point(285, 220)
        ReporteCompras.Show()
    End Sub

    Private Sub BarButtonItem22_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem22.ItemClick


    End Sub

    Private Sub BarButtonItem11_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        Tema = DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName
        ReporteProductos.Location = New Point(285, 220)
        ReporteProductos.Show()
    End Sub

    Private Sub BarButtonItem25_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem25.ItemClick

        Tema = DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName
        Acerca_de_InnovaMaster.Show()
    End Sub

    Private Sub BarButtonItem26_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem26.ItemClick
        Tema = DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName
        FrmFacturacionVenta.MdiParent = Me
        FrmFacturacionVenta.Focus()
        FrmFacturacionVenta.Show()
    End Sub

    Private Sub BarButtonItem28_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem28.ItemClick
        Tema = DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName
        ReporteVentas.Location = New Point(285, 220)
        ReporteVentas.Show()
    End Sub

    Private Sub BarButtonItem27_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem27.ItemClick
        Tema = DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName
        FrmVenta.MdiParent = Me
        FrmVenta.Focus()
        FrmVenta.Show()
    End Sub

    Private Sub BarButtonItem29_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem29.ItemClick
        Tema = DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName
        FrmLogAuditoria.Location = New Point(285, 220)
        FrmLogAuditoria.Show()
    End Sub

    Private Sub GestionarForms(sender As Object, e As DevExpress.XtraTabbedMdi.MdiTabPageEventArgs) Handles XtraTabbedMdiManager1.PageAdded, XtraTabbedMdiManager1.PageRemoved
        If XtraTabbedMdiManager1.Pages.Count = 0 Then
            pcFondo.Visible = True
        Else
            pcFondo.Visible = False
        End If
    End Sub

    Private Sub MenuPrincipal_Activated(sender As Object, e As EventArgs) Handles Me.Activated


    End Sub

    Private Sub BarButtonItem30_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem30.ItemClick
        Tema = DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName

    End Sub

    Private Sub BarButtonItem31_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem31.ItemClick
        FrmPermisos.MdiParent = Me
        FrmPermisos.Focus()
        FrmPermisos.Show()
    End Sub



    Private Sub BarButtonItem33_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem33.ItemClick
        FrmParametrosDEI.Focus()
        FrmParametrosDEI.Show()
    End Sub
End Class
