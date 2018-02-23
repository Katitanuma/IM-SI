Imports DevExpress.XtraReports.UI

Module Modulo1
    Public Function SHA1(ByVal strToHash As String) As String
        Dim sha1Obj As New Security.Cryptography.SHA1CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)

        bytesToHash = sha1Obj.ComputeHash(bytesToHash)

        Dim strResult As String = ""

        For Each b As Byte In bytesToHash
            strResult += b.ToString("x2")
        Next

        Return strResult
    End Function
    Public Sub MostrarReporte(ByVal Titulo As String, ByVal Reporte As XtraReport, ByVal FormMDI As Form, Optional ByVal OcultarMenu As Boolean = False)
        Dim _printPreview As New FrmModeloReporte
        With _printPreview
            .HideToolBars = OcultarMenu
            .Text = Titulo
            .MdiParent = FormMDI
            .Report = Reporte
            .Show()
            .Focus()
        End With
    End Sub
End Module
