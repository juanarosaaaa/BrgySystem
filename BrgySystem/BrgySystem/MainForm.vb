Public Class MainForm


    Private Sub Dashboard_Button_Click(sender As Object, e As EventArgs) Handles Dashboard_Button.Click
        showPanelDisplayOf(Dashboard)
    End Sub
    Private Sub Residents_Button_Click(sender As Object, e As EventArgs) Handles Residents_Button.Click
        showPanelDisplayOf(Residents)
    End Sub

    Private Sub Purok_Button_Click(sender As Object, e As EventArgs) Handles Purok_Button.Click
        showPanelDisplayOf(Purok)
    End Sub

    Private Sub Clearance_Button_Click(sender As Object, e As EventArgs) Handles Clearance_Button.Click
        showPanelDisplayOf(Clearance)
    End Sub

    Private Sub Officials_Button_Click(sender As Object, e As EventArgs) Handles Officials_Button.Click
        showPanelDisplayOf(Officials)
    End Sub

    Private Sub Blotter_Button_Click(sender As Object, e As EventArgs) Handles Blotter_Button.Click
        showPanelDisplayOf(Blotter)
    End Sub

    Private Sub Record_Button_Click(sender As Object, e As EventArgs) Handles Record_Button.Click
        showPanelDisplayOf(Record)
    End Sub

    Private Sub Archive_Button_Click(sender As Object, e As EventArgs) Handles Archive_Button.Click
        showPanelDisplayOf(Archive)
    End Sub

    Private Sub Settings_Button_Click(sender As Object, e As EventArgs) Handles Settings_Button.Click
        showPanelDisplayOf(Settings)
    End Sub

    Private Sub Activities_Button_Click(sender As Object, e As EventArgs) Handles Activities_Button.Click
        showPanelDisplayOf(Activities)
    End Sub

    Private Sub Logout_Button_Click(sender As Object, e As EventArgs) Handles Logout_Button.Click
        showPanelDisplayOf(Logout)
    End Sub


    Sub showPanelDisplayOf(panelDisplay As Form)
        MainPanel.Controls.Clear()
        panelDisplay.TopLevel = False
        MainPanel.Controls.Add(panelDisplay)
        panelDisplay.Show()
    End Sub
End Class
