Public Class SettingsMissionVissionForm

    Private setting As SettingMissionVision = New SettingMissionVision
    Private Sub SettingsMissionVissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RemainSizeOfForm.ToTheSizeOfTheSetting(Me)

        setting.displayMissionAndVision()

        MissionRichTextBox.Text = setting.getMission
        VisionRichTextBox.Text = setting.getVision
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        setting = New SettingMissionVision(MissionRichTextBox.Text, VisionRichTextBox.Text)
        setting.updateMissionVision()
    End Sub



End Class