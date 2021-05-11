Public Class MainForm


    Public Sub Dashboard_Button_Click(sender As Object, e As EventArgs) Handles Dashboard_Button.Click
        Dashboard.Dispose()
        showPanelDisplayOf(Dashboard)
    End Sub
    Private Sub Residents_Button_Click(sender As Object, e As EventArgs) Handles Residents_Button.Click
        Residents.Dispose()
        showPanelDisplayOf(Residents)
    End Sub

    Private Sub Purok_Button_Click(sender As Object, e As EventArgs) Handles Purok_Button.Click
        Purok.Dispose()
        showPanelDisplayOf(Purok)
    End Sub

    Private Sub Clearance_Button_Click(sender As Object, e As EventArgs) Handles Clearance_Button.Click
        Clearance.Dispose()
        showPanelDisplayOf(Clearance)
    End Sub

    Private Sub Officials_Button_Click(sender As Object, e As EventArgs) Handles Officials_Button.Click
        Officials.Dispose()
        showPanelDisplayOf(Officials)
    End Sub

    Private Sub Blotter_Button_Click(sender As Object, e As EventArgs) Handles Blotter_Button.Click
        Blotter.Dispose()
        showPanelDisplayOf(Blotter)
    End Sub

    Private Sub Archive_Button_Click(sender As Object, e As EventArgs) Handles Archive_Button.Click
        Archive.Dispose()
        showPanelDisplayOf(Archive)
    End Sub

    Private Sub Settings_Button_Click(sender As Object, e As EventArgs) Handles Settings_Button.Click
        Settings.Dispose()
        showPanelDisplayOf(Settings)

    End Sub

    Private Sub OrganizationalChartButton_Click(sender As Object, e As EventArgs) Handles OrganizationalChartButton.Click
        OrganizationalChart.Dispose()
        showPanelDisplayOf(OrganizationalChart)
    End Sub


    Private Sub Logout_Button_Click(sender As Object, e As EventArgs) Handles Logout_Button.Click
        Logout.Dispose()
        showPanelDisplayOf(Logout)
    End Sub


    Sub showPanelDisplayOf(panelDisplay As Form)


        MainPanel.Controls.Clear()
        panelDisplay.TopLevel = False
        MainPanel.Controls.Add(panelDisplay)
        panelDisplay.Show()

    End Sub

    Private Sub FormClose(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.Closed
        Me.Dispose()
        GC.SuppressFinalize(Me)
        Application.Exit()
    End Sub


End Class
