Imports DevExpress.XtraEditors
Imports System.Data.SqlClient

Public Class FrmParametrosDEI

    Private Sub FrmParametrosDEI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim archivo As New FileIni
        TxtCAI.EditValue = archivo.IniGet(RUTA_INI, "SAR", "CAI", "")
        TxtRango1.EditValue = archivo.IniGet(RUTA_INI, "SAR", "R1", "")
        TxtRango2.EditValue = archivo.IniGet(RUTA_INI, "SAR", "R2", "")
        If archivo.IniGet(RUTA_INI, "SAR", "CAI", "") <> Nothing Then
            DteLimite.EditValue = CDate(archivo.IniGet(RUTA_INI, "SAR", "Fecha", ""))
        End If
        ISV.EditValue = archivo.IniGet(RUTA_INI, "SAR", "ISV", "")

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        Dim archivo As New FileIni
        archivo.IniWrite(RUTA_INI, "SAR", "CAI", TxtCAI.EditValue)
        archivo.IniWrite(RUTA_INI, "SAR", "R1", TxtRango1.EditValue)
        archivo.IniWrite(RUTA_INI, "SAR", "R2", TxtRango2.EditValue)
        archivo.IniWrite(RUTA_INI, "SAR", "Fecha", DteLimite.EditValue)
        archivo.IniWrite(RUTA_INI, "SAR", "ISV", ISV.EditValue)
        ActualizarISV(ISV.EditValue)

    End Sub

    Private Sub TxtCAI_EditValueChanged(sender As Object, e As EventArgs) Handles TxtCAI.EditValueChanged, TxtRango1.EditValueChanged, TxtRango2.EditValueChanged, DteLimite.EditValueChanged, ISV.EditValueChanged
        If (TxtCAI.EditValue <> Nothing And TxtRango1.EditValue <> Nothing And TxtRango2.EditValue <> Nothing And DteLimite.EditValue <> Nothing And ISV.EditValue <> Nothing) Then
            BtnGuardar.Enabled = True
        Else
            BtnGuardar.Enabled = False
        End If
    End Sub

    Private Sub ActualizarISV(ByVal ISV As Double)
        Dim cmd As New SqlCommand
        Dim con As New Conexion
        Try
            con.Conectarse()
            cmd = New SqlCommand("UPDATE Producto SET Gravado = PrecioUnitario * " & CDbl(ISV) & "
                                  WHERE Gravado > 0")
            cmd.CommandType = CommandType.Text
            cmd.Connection = con.Con

            cmd.ExecuteNonQuery()
            XtraMessageBox.Show("Parámetros almacenados con exito")
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub
End Class