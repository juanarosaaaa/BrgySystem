Imports Bunifu.UI.WinForms



Public Class SettingsOrganizationChart
    Private search As Search = New SearchingFeature_Implementation
    Private orgChart As MySettingsOrganizationalChart = New MySettingsOrganizationalChart

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


    End Sub

    Private Sub CaptainNameTextChanged(sender As Object, e As EventArgs)
        Try
            If InputIsNull(CaptainTextBox.Text.Trim) Then

            End If


            CaptainPictureBox.Image = Image.FromFile(orgChart.setImage(CaptainTextBox.Text.Trim))
        Catch x As ArgumentException
            Debug.Write(x.Message)
        End Try
    End Sub

    Private Sub SecretaryTextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TreasurerTextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CouncilorTextBox1_TextChange(sender As Object, e As EventArgs)

    End Sub

    Private Sub KagawadTextBox1_TextChange(sender As Object, e As EventArgs)

    End Sub

    Private Sub KagawadTextBox2_TextChange(sender As Object, e As EventArgs)

    End Sub

    Private Sub CommitteeTextBox1_TextChange(sender As Object, e As EventArgs)

    End Sub

    Private Sub CouncilorTextBox2_TextChange(sender As Object, e As EventArgs)

    End Sub

    Private Sub CouncilorTextBox3_TextChange(sender As Object, e As EventArgs)

    End Sub

    Private Sub SkChairmanTextBox_TextChange(sender As Object, e As EventArgs)

    End Sub

    Private Sub KagawadTextbox3_TextChange(sender As Object, e As EventArgs)

    End Sub

    Private Sub CommitteeTextBox2_TextChange(sender As Object, e As EventArgs)

    End Sub


    Private Sub CommitteeTextBox3_TextChange(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuLabel50_Click(sender As Object, e As EventArgs) Handles BunifuLabel50.Click

    End Sub



    Private Sub SecretaryTextBox_TextChanged(sender As Object, e As EventArgs) Handles SecretaryTextBox.TextChanged

    End Sub
End Class