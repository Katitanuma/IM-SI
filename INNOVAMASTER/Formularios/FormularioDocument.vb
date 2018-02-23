Imports DevExpress.XtraReports.UI

Public Class FormularioDocument
    Private _hideToolBars As Boolean
    Public Property HideToolBars() As Boolean
        Get
            Return _hideToolBars
        End Get
        Set(ByVal Value As Boolean)
            _hideToolBars = Value
        End Set
    End Property

    Private fReport As XtraReport
    Public Property Report() As XtraReport
        Get
            Return fReport
        End Get
        Set(ByVal Value As XtraReport)
            If Not (fReport Is Value) Then
                If Not fReport Is Nothing Then
                    fReport.Dispose()
                End If
                fReport = Value
                If fReport Is Nothing Then
                    Return
                End If
                Invalidate()
                Update()

                If HideToolBars Then
                    Me.PreviewBar1.Visible = False
                    '   Me.PreviewBar3.Visible = False
                End If

                'fileName = GetReportPath(fReport, "repx")
                'PrintControl1.PrintingSystem = fReport.PrintingSystem
                DocumentViewer1.PrintingSystem = fReport.PrintingSystem
                'fReport.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.ClosePreview, DevExpress.XtraPrinting.CommandVisibility.None)
                fReport.CreateDocument(True)
            End If
        End Set
    End Property
End Class