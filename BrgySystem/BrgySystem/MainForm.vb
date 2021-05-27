Public Class MainForm



    Sub showPanelDisplayOf(panelDisplay As Form)

        MainPanel.Controls.Clear()
        panelDisplay.TopLevel = False
        panelDisplay.WindowState = FormWindowState.Maximized
        MainPanel.Controls.Add(panelDisplay)

        panelDisplay.Show()

    End Sub


    Private Sub Dashboard_Button_Click_1(sender As Object, e As EventArgs) Handles Dashboard_Button.Click
        Dashboard.Dispose()
        showPanelDisplayOf(Dashboard)
    End Sub

    Private Sub Residents_Button_Click_1(sender As Object, e As EventArgs) Handles Residents_Button.Click
        MyResidents.Dispose()
        showPanelDisplayOf(MyResidents)
    End Sub

    Private Sub Officials_Button_Click_1(sender As Object, e As EventArgs) Handles Officials_Button.Click
        Officials.Dispose()
        showPanelDisplayOf(Officials)
    End Sub

    Private Sub Purok_Button_Click_1(sender As Object, e As EventArgs) Handles Purok_Button.Click
        Purok.Dispose()
        showPanelDisplayOf(Purok)
    End Sub

    Private Sub Clearance_Button_Click_1(sender As Object, e As EventArgs) Handles Clearance_Button.Click
        Clearance.Dispose()

        showPanelDisplayOf(Clearance)
    End Sub



    Private Sub Archive_Button_Click_1(sender As Object, e As EventArgs) Handles Archive_Button.Click
        Archive.Dispose()
        showPanelDisplayOf(Archive)
    End Sub

    Private Sub OrganizationalChartButton_Click_1(sender As Object, e As EventArgs) Handles OrganizationalChartButton.Click
        OrganizationalChart.Dispose()
        showPanelDisplayOf(OrganizationalChart)
    End Sub

    Private Sub Settings_Button_Click_1(sender As Object, e As EventArgs) Handles Settings_Button.Click
        Settings.Dispose()
        showPanelDisplayOf(Settings)
    End Sub

    Private Sub Logout_Button_Click_1(sender As Object, e As EventArgs) Handles Logout_Button.Click
        My.Settings.UserNotLoggedOut = False
        closeConnection() 'check later
        Application.Exit()

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showPanelDisplayOf(Dashboard)
    End Sub
End Class
