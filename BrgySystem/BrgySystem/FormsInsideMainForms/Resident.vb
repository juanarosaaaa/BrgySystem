﻿Imports MySql.Data.MySqlClient

Public Class MyResidents

    Private search As SearchValue = New SearchBar
    Private SettinggridViewImage As New DataGridViewImages
    Private SettingAction As New DataGridViewActionButtonEvent
    Private brgyResidents As New MyBrgyResidents
    Private imageFile As ImageFileManager = New ImageFileManager()
    Private manage As loadGridViewValue = New ManageSystem
    Private AlreadyStart As Boolean = False
    Private Const folderImage As String = "ResidentsImages"




    Private Sub CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles ResidentsGridView.CellFormatting
        SettinggridViewImage.setImageAtButtonColumnOf("deleteButton_Column", ResidentsGridView, e, My.Resources.icons8_trash_24px)
        SettinggridViewImage.setImageAtButtonColumnOf("archiveButton_Column", ResidentsGridView, e, My.Resources.icons8_archive_24px_1)
        SettinggridViewImage.setImageAtButtonColumnOf("editButton_Column", ResidentsGridView, e, My.Resources.icons8_edit_24px)
    End Sub

    Private Sub MyResidents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        brgyResidents.arrangeGridView(ResidentsGridView)
        manage.loadGridViewValueOf(brgyResidents.getResidentsQuery, ResidentsGridView)

    End Sub

    Private Sub BrowseButton_Click(sender As Object, e As EventArgs) Handles BrowseButton.Click

        imageFile.openImageFromPictureBox(ResidentsPictureBOx)

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        'fix parameter in constructor bug

        imageFile.saveImageAt("ResidentsImages")

        'brgyResidents.addResidents(imageFile.getImageName, imageFile.getImageFolderPath)

        'MsgBox(imageFile.getImageName)
        'MsgBox(imageFile.getImageFolderPath)

    End Sub

    Private Sub SearchFieldTextChanged(sender As Object, e As EventArgs) Handles SearchFieldTxtBox.TextChange
        If AlreadyStart Then
            search.searchValueIn(brgyResidents.getResidentsQuery + "WHERE FULLNAME LIKE '%" & SearchFieldTxtBox.Text.Trim & "%'", ResidentsGridView)
        End If

    End Sub

    Private Sub SearchFieldIsClicked(sender As Object, e As EventArgs) Handles SearchFieldTxtBox.Click
        AlreadyStart = True
    End Sub
End Class