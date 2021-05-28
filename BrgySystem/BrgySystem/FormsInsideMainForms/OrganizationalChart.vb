Public Class OrganizationalChart
    Private orgChart As MySettingsOrganizationalChart = New MySettingsOrganizationalChart

    Private Sub OrganizationalChart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        orgChart.displayInfo(1, BarangayCaptainTextBox, BarangayCaptainPictureBox)
        orgChart.displayInfo(2, SecretaryTextBox, SecretaryPictureBox)
        orgChart.displayInfo(3, TreasurerTextBox, TreasurerPictureBox)
        orgChart.displayInfo(4, CouncilorTextBox1, CouncilorPictureBox1)
        orgChart.displayInfo(5, KagawadTextBox1, KagawadPicturebox1)
        orgChart.displayInfo(6, KagawadTextBox2, KagawadPicturebox2)
        orgChart.displayInfo(7, CommitteeTextBox1, CommitteePictureBox1)
        orgChart.displayInfo(8, CouncilorTextBox2, CouncilorPictureBox2)
        orgChart.displayInfo(9, CouncilorTextBox3, CouncilorPictureBox3)
        orgChart.displayInfo(10, SkChairmanTextBox, SkChairmanPictureBox)
        orgChart.displayInfo(11, KagawadTextBox3, KagawadPicturebox3)
        orgChart.displayInfo(12, CommitteeTextBox2, CommitteePictureBox2)
        orgChart.displayInfo(13, CommitteeTextBox3, CommitteePictureBox3)
    End Sub


End Class