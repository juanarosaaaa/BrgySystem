Public Class MainForm


    Public Sub Dashboard_Button_Click(sender As Object, e As EventArgs)
        Dashboard.Dispose()
        showPanelDisplayOf(Dashboard)
    End Sub
    Private Sub Residents_Button_Click(sender As Object, e As EventArgs)
        MyResidents.Dispose()
        showPanelDisplayOf(MyResidents)
    End Sub

    Private Sub Purok_Button_Click(sender As Object, e As EventArgs)
        Purok.Dispose()

        showPanelDisplayOf(Purok)
    End Sub

    Private Sub Clearance_Button_Click(sender As Object, e As EventArgs)
        Clearance.Dispose()

        showPanelDisplayOf(Clearance)
    End Sub

    Private Sub Officials_Button_Click(sender As Object, e As EventArgs)
        Officials.Dispose()
        showPanelDisplayOf(Officials)
    End Sub

    Private Sub Blotter_Button_Click(sender As Object, e As EventArgs)
        Blotter.Dispose()
        showPanelDisplayOf(Blotter)
    End Sub

    Private Sub Archive_Button_Click(sender As Object, e As EventArgs)
        Archive.Dispose()
        showPanelDisplayOf(Archive)
    End Sub

    Private Sub Settings_Button_Click(sender As Object, e As EventArgs)
        Settings.Dispose()
        showPanelDisplayOf(Settings)

    End Sub

    Private Sub OrganizationalChartButton_Click(sender As Object, e As EventArgs)
        OrganizationalChart.Dispose()
        showPanelDisplayOf(OrganizationalChart)
    End Sub





    Sub showPanelDisplayOf(panelDisplay As Form)


        MainPanel.Controls.Clear()
        panelDisplay.TopLevel = False
        panelDisplay.WindowState = FormWindowState.Maximized
        MainPanel.Controls.Add(panelDisplay)
        closeConnection()
        panelDisplay.Show()

    End Sub

    Private Sub Logout_Button_Click(sender As Object, e As EventArgs)
        My.Settings.UserNotLoggedOut = False
        closeConnection()
        Application.Exit()

    End Sub

End Class
