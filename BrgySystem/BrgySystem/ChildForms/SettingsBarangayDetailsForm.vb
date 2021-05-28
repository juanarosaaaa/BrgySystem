Imports MySql.Data.MySqlClient
Imports System.IO
Public Class SettingsBarangayDetailsForm
    Private imageFile As ImageFileManager = New ImageFileManager()
    Private brgyInfo As BarangayInformation = New BarangayInformation
    Private Sub SettingsBarangayDetailsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RemainSizeOfForm.ToTheSizeOfTheSetting(Me)


        brgyInfo.displayInformation()
        AdminNameTextBox.Text = brgyInfo.getAdminName
        Addresstextbox.Text = brgyInfo.getAddress
        BarangayCaptainTextBox.Text = brgyInfo.getBarangayCaptainName
        ZipCodeTxtBox.Text = brgyInfo.getZipCode
        ContactNumberTextBox.Text = brgyInfo.getContactNumber

        Try
            imageFile.setImage(brgyInfo.getImagePath, MunicipalityLogoPictureBox)
            MunicipalityLogoPictureBox.Image = Image.FromFile(brgyInfo.getImagePath)
        Catch n As FileNotFoundException
            MessageBox.Show("Municipality Logo not found. File might have been moved or deleted.", "IMAGE NOT FOUND!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Try
            If MunicipalityLogoPictureBox.Image Is MunicipalityLogoPictureBox.InitialImage Then
                Throw New NoNullAllowedException
            End If
            imageFile.saveImageAt("BarangayDetails")
            brgyInfo.setImagePath(imageFile.getImageFolderPath)
            brgyInfo.setImageName(imageFile.getImageName)

            If brgyInfo.oneInputIsNull() Then
                MessageBox.Show("Incomplete details!", "FAILED TO UPDATE BARANGAY INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf InputContainsNumber(brgyInfo.getAdminName) Or InputContainsSpecialCharacter(brgyInfo.getAdminName) Then
                MessageBox.Show("Admin name is invalid!", "FAILED TO UPDATE BARANGAY INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf isCharacterSizeInvalid(11, brgyInfo.getContactNumber) Or InputContainsLetter(brgyInfo.getContactNumber) Or InputContainsSpecialCharacter(brgyInfo.getContactNumber) Then
                MessageBox.Show("Contact number is invalid!", "FAILED TO UPDATE BARANGAY INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf InputContainsNumber(brgyInfo.getBarangayCaptainName) Or InputContainsSpecialCharacter(brgyInfo.getBarangayCaptainName) Then
                MessageBox.Show("Barangay Captain name is invalid!", "FAILED TO UPDATE BARANGAY INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf isCharacterSizeInvalid(4, brgyInfo.getZipCode) Or InputContainsLetter(brgyInfo.getZipCode) Or InputContainsSpecialCharacter(brgyInfo.getZipCode) Then
                MessageBox.Show("Zip code is invalid!", "FAILED TO UPDATE BARANGAY INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                brgyInfo.updateBarangayInformation()
                MainForm.AdminNameTextBox.Text = brgyInfo.getAdminName
                MainForm.MunicipalityLogo.Image = Image.FromFile(brgyInfo.getImagePath)
                MessageBox.Show("Barangay Information updated successfully!", "SUCCESSFULLY UPDATED!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        Catch x As NoNullAllowedException
            MessageBox.Show("No picture selected!", "INCOMPLETE DETAILS!", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End Try



    End Sub

    Private Sub BrowseButton_Click(sender As Object, e As EventArgs) Handles BrowseButton.Click
        imageFile.openImageFromPictureBox(MunicipalityLogoPictureBox)


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


End Class