Public Class FrmReportesBase

    Private _MostrarBotonImprimir As Boolean = True
    Private _MostrarBotonReporte As Boolean = True
    Private _TituloEtiqueta As String = "Reporte de Datos"

    Public Property MostrarBotonImprimir As Boolean
        Get
            Return _MostrarBotonImprimir
        End Get
        Set(value As Boolean)
            _MostrarBotonImprimir = value
            BtnImprimir.Visible = _MostrarBotonImprimir
        End Set
    End Property

    Public Property MostrarBotonReporte As Boolean
        Get
            Return _MostrarBotonReporte
        End Get
        Set(value As Boolean)
            _MostrarBotonReporte = value
            BtnReporte.Visible = _MostrarBotonReporte
        End Set
    End Property

    Public Property TituloEtiqueta As String
        Get
            Return _TituloEtiqueta
        End Get
        Set(value As String)
            _TituloEtiqueta = value
            LblEtiqueta.Text = _TituloEtiqueta
        End Set
    End Property

    Protected Overridable Sub MostrarDatos()

    End Sub

    Protected Overridable Sub ExportarPDF()

    End Sub

    Protected Overridable Sub ExportarExcel()

    End Sub

    Protected Overridable Sub ActualizarDatos()

    End Sub
    Protected Overridable Sub Imprimir()

    End Sub

    Protected Overridable Sub Reporte()

    End Sub

    Protected Overridable Sub AyudaHTML()

    End Sub

    Private Sub FrmReportesBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AyudaHTML()
        MostrarDatos()
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        ActualizarDatos()
    End Sub

    Private Sub BtnExportarPDF_Click(sender As Object, e As EventArgs) Handles BtnExportarPDF.Click
        ExportarPDF()
    End Sub

    Private Sub BtnExportarExcel_Click(sender As Object, e As EventArgs) Handles BtnExportarExcel.Click
        ExportarExcel()
    End Sub

    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs) Handles BtnImprimir.Click
        Imprimir()
    End Sub

    Private Sub BtnReporte_Click(sender As Object, e As EventArgs) Handles BtnReporte.Click
        Reporte()
    End Sub
End Class