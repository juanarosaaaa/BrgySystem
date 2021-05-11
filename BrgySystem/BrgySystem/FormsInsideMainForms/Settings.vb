Public Class Settings

    Private Sub BarangayDetailsButton_Click(sender As Object, e As EventArgs) Handles BarangayDetailsButton.Click
        showPanelDisplayOf(SettingsBarangayDetailsForm)
    End Sub

    Private Sub MissionVisionzButton_Click(sender As Object, e As EventArgs) Handles MissionVisionzButton.Click
        showPanelDisplayOf(SettingsMissionVissionForm)
    End Sub

    Private Sub OrganizationChart_Click(sender As Object, e As EventArgs) Handles OrganizationChart.Click
        showPanelDisplayOf(SettingsOrganizationChart)
    End Sub
    Private Sub BackupAndRestoreButton_Click(sender As Object, e As EventArgs) Handles BackupAndRestoreButton.Click
        showPanelDisplayOf(SettingsbackupAndRestoreForm)
    End Sub
    Sub showPanelDisplayOf(panelDisplay As Form)
        MainPanelSetting.Controls.Clear()
        panelDisplay.TopLevel = False
        MainPanelSetting.Controls.Add(panelDisplay)
        panelDisplay.Show()
    End Sub



    Private Sub AccountSettingsButtonClick(sender As Object, e As EventArgs) Handles AccountSettingsButton.Click
        showPanelDisplayOf(SettingsAccountSettingsForm)
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)
        MsgBox(True)
    End Sub
End Class