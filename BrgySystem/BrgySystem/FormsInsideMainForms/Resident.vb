Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms
Imports Bunifu.UI.WinForms
Public Class MyResidents



    Private search As Search = New SearchingFeature_Implementation
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


    Private Sub ResidentsGridViewCellClicked(sender As Object, e As DataGridViewCellEventArgs) Handles ResidentsGridView.CellContentClick

        If SettingAction.buttonOf_IsClick("editButton_Column", ResidentsGridView, e) Then


        ElseIf SettingAction.buttonOf_IsClick("deleteButton_Column", ResidentsGridView, e) Then


        ElseIf SettingAction.buttonOf_IsClick("archiveButton_Column", ResidentsGridView, e) Then


        End If

        'editButton_Column
        'deleteButton_Column
        'archiveButton_Column
    End Sub




    Private Sub MyResidents_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        brgyResidents.arrangeGridView(ResidentsGridView)

        manage.loadGridViewValueOf(brgyResidents.getResidentsQueryForSelectedColumns, ResidentsGridView)
        search.addAndRefresh_DataSuggestion_WhileSearchingAt("FULLNAME", "Residents", SearchFieldTxtBox)
        search.addAndRefresh_DataSuggestion_WhileSearchingAt("PurokName", "Purok", PurokTextBox)

    End Sub




    Private Sub BrowseButton_Click(sender As Object, e As EventArgs) Handles BrowseButton.Click

        imageFile.openImageFromPictureBox(ResidentsPictureBOx)


    End Sub


    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click

        Try
            imageFile.saveImageAt("ResidentsImages")
        Catch x As NoNullAllowedException
            MessageBox.Show("No picture selected!", "INCOMPLETE DETAILS!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End Try
        brgyResidents.addResidents(imageFile.getImageName, imageFile.getImageFolderPath)
        search.addAndRefresh_DataSuggestion_WhileSearchingAt("FULLNAME", "Residents", SearchFieldTxtBox)
        manage.loadGridViewValueOf(brgyResidents.getResidentsQueryForSelectedColumns, ResidentsGridView)
    End Sub





    Private Sub searchFieldTextChanged(sender As Object, e As EventArgs) Handles SearchFieldTxtBox.TextChange
        If AlreadyStart Then
            search.searchValueIn(brgyResidents.getResidentsQueryForSelectedColumns + "WHERE FULLNAME LIKE '" & SearchFieldTxtBox.Text.Trim & "'", ResidentsGridView)
            If (InputIsNull(SearchFieldTxtBox.Text.Trim)) Then
                manage.loadGridViewValueOf(brgyResidents.getResidentsQueryForSelectedColumns, ResidentsGridView)
            End If
        End If

    End Sub



    Private Sub SearchFieldIsClicked(sender As Object, e As EventArgs) Handles SearchFieldTxtBox.Click
        AlreadyStart = True
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        search.searchValueIn(brgyResidents.getResidentsQueryForSelectedColumns + "WHERE FULLNAME LIKE '" & SearchFieldTxtBox.Text.Trim & "'", ResidentsGridView)
    End Sub

    Private Sub PurokTxtBoxTextChanged(sender As Object, e As EventArgs) Handles PurokTextBox.TextChange

    End Sub


End Class