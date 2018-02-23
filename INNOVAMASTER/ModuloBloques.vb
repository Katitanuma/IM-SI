Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI
Imports System.Text
Imports System.Security.Cryptography

Module ModuloBloques
    Public Tema As String
    Public RUTA_INI As String = Application.StartupPath & "\" & "MyConf.ini"
    Public Ip, BaseDatos, Usuario, Contrasena, con As String
    Public Sub Exportar_a_Excel(ByRef Grilla As DevExpress.XtraGrid.GridControl, ByVal Nombre As String)
        Dim Archivo As New SaveFileDialog

        Try
            Archivo.Filter = "xls|*.xls"
            Archivo.FileName = Nombre
            Archivo.ShowDialog()
            If Archivo.FileName.Length > 0 Then

                Grilla.ExportToXls(Archivo.FileName)

                ' Lanzar excel 
                Process.Start(Archivo.FileName)

            End If

        Catch Ex As Exception
            Dim _st As New System.Diagnostics.StackTrace()
            Dim _miFuncion As String = _st.GetFrame(0).GetMethod().Name
            MessageBox.Show(Ex.Message)
        End Try
    End Sub

    Public Sub Exportar_a_PDF(ByRef Grilla As DevExpress.XtraGrid.GridControl, ByVal Nombre As String)
        Dim Archivo As New SaveFileDialog

        Try
            Archivo.Filter = "pdf|*.pdf"
            Archivo.FileName = Nombre
            Archivo.ShowDialog()
            If Archivo.FileName.Length > 0 Then

                Grilla.ExportToPdf(Archivo.FileName)

                ' Lanzar el archivo
                Process.Start(Archivo.FileName)

            End If

        Catch Ex As Exception
            Dim _st As New System.Diagnostics.StackTrace()
            Dim _miFuncion As String = _st.GetFrame(0).GetMethod().Name
            XtraMessageBox.Show(Ex.Message)
        End Try
    End Sub
    Public Sub MostrarReporte(ByVal Titulo As String, ByVal Reporte As XtraReport, ByVal FormMDI As Form, Optional ByVal OcultarMenu As Boolean = False)
        Dim _printPreview As New FormularioDocument
        With _printPreview
            .HideToolBars = OcultarMenu
            .Text = Titulo
            .MdiParent = FormMDI
            .Report = Reporte
            .Show()
            .Focus()
        End With
    End Sub

    Public Function Encriptar(ByVal Input As String) As String

        Dim IV() As Byte = ASCIIEncoding.ASCII.GetBytes("qualityi") 'La clave debe ser de 8 caracteres
        Dim EncryptionKey() As Byte = Convert.FromBase64String("rpaSPvIvVLlrcmtzPU9/c67Gkj7yL1S5") 'No se puede alterar la cantidad de caracteres pero si la clave
        Dim buffer() As Byte = Encoding.UTF8.GetBytes(Input)
        Dim des As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider
        des.Key = EncryptionKey
        des.IV = IV

        Return Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length()))

    End Function

    Public Function Desencriptar(ByVal Input As String) As String

        Dim IV() As Byte = ASCIIEncoding.ASCII.GetBytes("qualityi") 'La clave debe ser de 8 caracteres
        Dim EncryptionKey() As Byte = Convert.FromBase64String("rpaSPvIvVLlrcmtzPU9/c67Gkj7yL1S5") 'No se puede alterar la cantidad de caracteres pero si la clave
        Dim buffer() As Byte = Convert.FromBase64String(Input)
        Dim des As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider
        des.Key = EncryptionKey
        des.IV = IV
        Return Encoding.UTF8.GetString(des.CreateDecryptor().TransformFinalBlock(buffer, 0, buffer.Length()))

    End Function

End Module
