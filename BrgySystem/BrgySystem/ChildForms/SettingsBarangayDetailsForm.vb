Imports MySql.Data.MySqlClient

Public Class SettingsBarangayDetailsForm
    Private imageFile As ImageFileManager = New ImageFileManager()
    Private brgyInfo As BarangayInformation = New BarangayInformation
    Private Sub SettingsBarangayDetailsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RemainSizeOfForm.ToTheSizeOfTheSetting(Me)

        brgyInfo.displayInformation()
        imageFile.setImage(brgyInfo.getImagePath, MunicipalityLogoPictureBox)
        AdminNameTextBox.Text = brgyInfo.getAdminName
        Addresstextbox.Text = brgyInfo.getAddress
        BarangayCaptainTextBox.Text = brgyInfo.getBarangayCaptainName
        ZipCodeTxtBox.Text = brgyInfo.getZipCode
        ContactNumberTextBox.Text = brgyInfo.getContactNumber
        MunicipalityLogoPictureBox.Image = Image.FromFile(brgyInfo.getImagePath)

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        imageFile.saveImageAt("BarangayDetails")

    End Sub

    Private Sub BrowseButton_Click(sender As Object, e As EventArgs) Handles BrowseButton.Click
        imageFile.openImageFromPictureBox(MunicipalityLogoPictureBox)

        brgyInfo.setImagePath(imageFile.getImageFolderPath)
        brgyInfo.setImageName(imageFile.getImageName)
    End Sub

    Private Sub AdminNameTextChanged(sender As Object, e As EventArgs) Handles AdminNameTextBox.TextChanged
        brgyInfo.setAdminName(AdminNameTextBox.Text.Trim)
    End Sub

    Private Sub AddressTextBoxTextChanged(sender As Object, e As EventArgs) Handles Addresstextbox.TextChange
        brgyInfo.setAddress(Addresstextbox.Text.Trim)
    End Sub

    Private Sub BarangayCaptainTextChanged(sender As Object, e As EventArgs) Handles BarangayCaptainTextBox.TextChange
        brgyInfo.setBarangayCaptainName(BarangayCaptainTextBox.Text.Trim)
    End Sub

    Private Sub ZipcodeTextChanged(sender As Object, e As EventArgs) Handles ZipCodeTxtBox.TextChange
        brgyInfo.setZipcode(ZipCodeTxtBox.Text)
    End Sub

    Private Sub ContactNumberTextChanged(sender As Object, e As EventArgs) Handles ContactNumberTextBox.TextChange
        brgyInfo.setContactNumber(ContactNumberTextBox.Text.Trim)
    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles SaveButton.Click

    End Sub
End Class