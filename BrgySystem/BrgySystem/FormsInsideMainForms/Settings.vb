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

    Sub showPanelDisplayOf(panelDisplay As Form)
        MainPanelSetting.Controls.Clear()
        panelDisplay.TopLevel = False
        panelDisplay.WindowState = FormWindowState.Maximized
        MainPanelSetting.Controls.Add(panelDisplay)
        panelDisplay.Show()
    End Sub



    Private Sub AccountSettingsButtonClick(sender As Object, e As EventArgs) Handles AccountSettingsButton.Click

        showPanelDisplayOf(SettingsAccountSettingsForm)
   
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showPanelDisplayOf(SettingsAccountSettingsForm)
    End Sub


End Class