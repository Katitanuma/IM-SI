
Namespace My

    'Esta clase le permite controlar eventos específicos en la clase de configuración:
    ' El evento SettingChanging se desencadena antes de cambiar un valor de configuración.
    ' El evento PropertyChanged se desencadena después de cambiar el valor de configuración.
    ' El evento SettingsLoaded se desencadena después de cargar los valores de configuración.
    ' El evento SettingsSaving se desencadena antes de guardar los valores de configuración.
    Partial Public NotInheritable Class MySettings


        Private Sub MySettings_PropertyChanged(ByVal sender As Object, ByVal e As System.ComponentModel.PropertyChangedEventArgs) Handles Me.PropertyChanged
            Select Case e.PropertyName
                Case "Conect1"
                    Me("Conect") = My.Settings.Conect1

                    'Case "SECrunTime_ConecctionString"
                    '    Me("SEC_ConnectionString") = My.Settings.Conect1

            End Select
        End Sub

        Private Sub MySettings_SettingsLoaded(ByVal sender As Object, ByVal e As System.Configuration.SettingsLoadedEventArgs) Handles Me.SettingsLoaded
            If My.Settings.Conect1.Trim.Length > 0 Then
                Me("Conect") = My.Settings.Conect1
            End If

            'If My.Settings.SECrunTime_ConecctionString.Trim.Length > 0 Then
            '    Me("SEC_ConnectionString") = My.Settings.Conect1
            'End If

        End Sub
    End Class
End Namespace
