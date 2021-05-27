Imports Bunifu.UI.WinForms



Public Class SettingsOrganizationChart
    Private search As Search = New SearchingFeature_Implementation
    Private orgChart As MySettingsOrganizationalChart = New MySettingsOrganizationalChart
    Private isAlreadyStart As Boolean = False
    Private Sub BunifuLabel4_Click(sender As Object, e As EventArgs) Handles BunifuLabel4.Click

    End Sub

    Private Sub SettingsOrganizationChart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RemainSizeOfForm.ToTheSizeOfTheSetting(Me)

        Dim obj() As BunifuTextBox = {CaptainTextBox,
        SecretaryTextBox,
        TreasurerTextBox,
        CouncilorTextBox1,
        KagawadTextBox1,
        KagawadTextBox2,
        CommitteeTextBox1,
        CouncilorTextBox1,
        CouncilorTextBox2,
        SkChairmanTextBox,
        KagawadTextbox3,
        CommitteeTextBox2,
        CommitteeTextBox3}

        For Each i As BunifuTextBox In obj
            search.addAndRefresh_DataSuggestion_WhileSearchingAt("Name", "officials", i)
        Next

        orgChart.displayInfo(1, CaptainTextBox, CaptainPictureBox)
        orgChart.displayInfo(2, SecretaryTextBox, SecretaryPictureBox)
        orgChart.displayInfo(3, TreasurerTextBox, TreasurerPictureBox)
        orgChart.displayInfo(4, CouncilorTextBox1, CouncilorPicturebox1)
        orgChart.displayInfo(5, KagawadTextBox1, KagawadPicturebox1)
        orgChart.displayInfo(6, KagawadTextBox2, KagawadPictureBox2)
        orgChart.displayInfo(7, CommitteeTextBox1, CommitteePictureBox1)
        orgChart.displayInfo(8, CouncilorTextBox2, CouncilorPicturebox2)
        orgChart.displayInfo(9, CouncilorTextBox3, CouncilorPicturebox3)
        orgChart.displayInfo(10, SkChairmanTextBox, SkChairmanPictureBox)
        orgChart.displayInfo(11, KagawadTextbox3, KagawadPicturebox3)
        orgChart.displayInfo(12, CommitteeTextBox2, CommitteePictureBox2)
        orgChart.displayInfo(13, CommitteeTextBox3, CommitteePictureBox3)

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click

        orgChart.updateOfficial(1, CaptainTextBox.Text.Trim, orgChart.getImage(CaptainTextBox.Text.Trim))

        orgChart.updateOfficial(2, SecretaryTextBox.Text.Trim, orgChart.getImage(SecretaryTextBox.Text.Trim))

        orgChart.updateOfficial(3, TreasurerTextBox.Text.Trim, orgChart.getImage(TreasurerTextBox.Text.Trim))

        orgChart.updateOfficial(4, CouncilorTextBox1.Text.Trim, orgChart.getImage(CouncilorTextBox1.Text.Trim))

        orgChart.updateOfficial(5, KagawadTextBox1.Text.Trim, orgChart.getImage(KagawadTextBox1.Text.Trim))

        orgChart.updateOfficial(6, KagawadTextBox2.Text.Trim, orgChart.getImage(KagawadTextBox2.Text.Trim))

        orgChart.updateOfficial(7, CommitteeTextBox1.Text.Trim, orgChart.getImage(CommitteeTextBox1.Text.Trim))

        orgChart.updateOfficial(8, CouncilorTextBox2.Text.Trim, orgChart.getImage(CouncilorTextBox2.Text.Trim))

        orgChart.updateOfficial(9, CouncilorTextBox3.Text.Trim, orgChart.getImage(CouncilorTextBox3.Text.Trim))

        orgChart.updateOfficial(10, SkChairmanTextBox.Text.Trim, orgChart.getImage(SkChairmanTextBox.Text.Trim))

        orgChart.updateOfficial(11, KagawadTextbox3.Text.Trim, orgChart.getImage(KagawadTextbox3.Text.Trim))

        orgChart.updateOfficial(12, CommitteeTextBox2.Text.Trim, orgChart.getImage(CommitteeTextBox2.Text.Trim))

        orgChart.updateOfficial(13, CommitteeTextBox3.Text.Trim, orgChart.getImage(CommitteeTextBox3.Text.Trim))

        MessageBox.Show("Organizational Chart successfully updated!", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub






    Private Sub CaptainTextBox_TextChange(sender As Object, e As EventArgs) Handles CaptainTextBox.TextChange
        displayOfficials(CaptainTextBox, CaptainPictureBox, CaptainNameLabelStatus)
    End Sub


    Private Sub SecretaryTextBox_TextChange(sender As Object, e As EventArgs) Handles SecretaryTextBox.TextChange
        displayOfficials(SecretaryTextBox, SecretaryPictureBox, SecretaryLabelStatus)
    End Sub

    Private Sub TreasurerTextBox_TextChange(sender As Object, e As EventArgs) Handles TreasurerTextBox.TextChange
        displayOfficials(TreasurerTextBox, TreasurerPictureBox, TreasurerLabelStatus)
    End Sub

    Private Sub CouncilorTextBox1_TextChange(sender As Object, e As EventArgs) Handles CouncilorTextBox1.TextChange
        displayOfficials(CouncilorTextBox1, CouncilorPicturebox1, CouncilorLabelStatus1)
    End Sub

    Private Sub KagawadTextBox1_TextChange(sender As Object, e As EventArgs) Handles KagawadTextBox1.TextChange
        displayOfficials(KagawadTextBox1, KagawadPicturebox1, KagawadLabelStatus1)
    End Sub

    Private Sub KagawadTextBox2_TextChange(sender As Object, e As EventArgs) Handles KagawadTextBox2.TextChange
        displayOfficials(KagawadTextBox2, KagawadPictureBox2, KagawadLabelStatus2)
    End Sub

    Private Sub CommitteeTextBox1_TextChange(sender As Object, e As EventArgs) Handles CommitteeTextBox1.TextChange
        displayOfficials(CommitteeTextBox1, CommitteePictureBox1, CommitteeLabelStatus1)
    End Sub

    Private Sub CouncilorTextBox2_TextChange(sender As Object, e As EventArgs) Handles CouncilorTextBox2.TextChange
        displayOfficials(CouncilorTextBox2, CouncilorPicturebox2, CouncilorLabelStatus2)
    End Sub

    Private Sub CouncilorTextBox3_TextChange(sender As Object, e As EventArgs) Handles CouncilorTextBox3.TextChange
        displayOfficials(CouncilorTextBox3, CouncilorPicturebox3, CouncilorLabelStatus3)
    End Sub

    Private Sub SkChairmanTextBox_TextChange(sender As Object, e As EventArgs) Handles SkChairmanTextBox.TextChange
        displayOfficials(SkChairmanTextBox, SkChairmanPictureBox, SkChairmanLabelStatus)
    End Sub

    Private Sub KagawadTextbox3_TextChange(sender As Object, e As EventArgs) Handles KagawadTextbox3.TextChange
        displayOfficials(KagawadTextbox3, KagawadPicturebox3, KagawadLabelStatus3)
    End Sub

    Private Sub CommitteeTextBox2_TextChange(sender As Object, e As EventArgs) Handles CommitteeTextBox2.TextChange
        displayOfficials(CommitteeTextBox2, CommitteePictureBox2, CommitteeLabelStatus2)
    End Sub

    Private Sub CommitteeTextBox3_TextChange(sender As Object, e As EventArgs) Handles CommitteeTextBox3.TextChange
        displayOfficials(CommitteeTextBox3, CommitteePictureBox3, CommitteeLabelStatus3)
    End Sub






































    Private Sub CaptainTextBox_Click(sender As Object, e As EventArgs) Handles CaptainTextBox.Click, SecretaryTextBox.Click, TreasurerTextBox.Click, CommitteeTextBox3.Click, CouncilorTextBox1.Click, CommitteeTextBox2.Click, KagawadTextBox1.Click, KagawadTextBox2.Click, CommitteeTextBox1.Click, CouncilorTextBox2.Click, CouncilorTextBox3.Click, SkChairmanTextBox.Click, KagawadTextbox3.Click, KagawadTextbox3.Click
        isAlreadyStart = True
    End Sub

    Sub displayOfficials(txtBox As BunifuTextBox, picBox As BunifuPictureBox, labelstatus As BunifuLabel)
        Try
            If isAlreadyStart Then
                If InputIsNull(txtBox.Text.Trim) Then
                    picBox.Image = picBox.InitialImage
                    labelstatus.Visible = False
                ElseIf Not isInputAlreadyExist("Name", "officials", txtBox.Text) Then
                    labelstatus.Visible = True
                Else
                    picBox.Image = Image.FromFile(orgChart.getImage(txtBox.Text.Trim))
                    labelstatus.Visible = False
                End If
            End If

        Catch x As ArgumentException

        End Try
    End Sub

    Private Sub TreasurerTextBox_TextChanged(sender As Object, e As EventArgs) Handles TreasurerTextBox.TextChanged

    End Sub
End Class