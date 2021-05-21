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
    Private selectedNameInRow As String



    Private Sub CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles ResidentsGridView.CellFormatting
        SettinggridViewImage.setImageAtButtonColumnOf("deleteButton_Column", ResidentsGridView, e, My.Resources.icons8_trash_24px)
        SettinggridViewImage.setImageAtButtonColumnOf("archiveButton_Column", ResidentsGridView, e, My.Resources.icons8_archive_24px_1)
        SettinggridViewImage.setImageAtButtonColumnOf("editButton_Column", ResidentsGridView, e, My.Resources.icons8_edit_24px)
    End Sub




    Private Sub MyResidents_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        brgyResidents.arrangeGridView(ResidentsGridView)
        UpdateButton.Enabled = False

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
        Catch X As NoNullAllowedException
            MessageBox.Show("No picture selected!", "INCOMPLETE DETAILS!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End Try
        Dim message As String = "Resident '" & Fullnametxtbox.Text.Trim.ToUpper & "' successfully added!"
        Dim query As String = brgyResidents.getInsertQuery(imageFile.getImageName, imageFile.getImageFolderPath)
        brgyResidents.addOrUpdateResident(message, query, imageFile.getImageName)
        search.addAndRefresh_DataSuggestion_WhileSearchingAt("FULLNAME", "Residents", SearchFieldTxtBox)
        manage.loadGridViewValueOf(brgyResidents.getResidentsQueryForSelectedColumns, ResidentsGridView)

    End Sub





    Private Sub searchFieldTextChanged(sender As Object, e As EventArgs) Handles SearchFieldTxtBox.TextChange
        If AlreadyStart Then
            Dim query As String = brgyResidents.getResidentsQueryForSelectedColumns + "WHERE FULLNAME LIKE '" & SearchFieldTxtBox.Text.Trim & "'"
            search.searchValueIn(query, ResidentsGridView)
            If (InputIsNull(SearchFieldTxtBox.Text.Trim)) Then
                manage.loadGridViewValueOf(brgyResidents.getResidentsQueryForSelectedColumns, ResidentsGridView)
            End If
        End If

    End Sub




    Private Sub SearchFieldIsClicked(sender As Object, e As EventArgs) Handles SearchFieldTxtBox.Click
        AlreadyStart = True
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Dim query As String = brgyResidents.getResidentsQueryForSelectedColumns + "WHERE FULLNAME LIKE '" & SearchFieldTxtBox.Text.Trim & "'"
        search.searchValueIn(query, ResidentsGridView)
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click

        Try
            imageFile.saveImageAt("ResidentsImages")
        Catch X As NoNullAllowedException
            MessageBox.Show("No picture selected!", "INCOMPLETE DETAILS!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End Try

        Dim message As String = "Resident '" & selectedNameInRow & "' successfully updated!"
        Dim query As String = brgyResidents.getUpdateQuery(selectedNameInRow, imageFile.getImageName, imageFile.getImageFolderPath)

        brgyResidents.addOrUpdateResident(message, query, imageFile.getImageName)
        search.addAndRefresh_DataSuggestion_WhileSearchingAt("FULLNAME", "Residents", SearchFieldTxtBox)
        manage.loadGridViewValueOf(brgyResidents.getResidentsQueryForSelectedColumns, ResidentsGridView)


    End Sub

    Private Sub ResdientsGridViewCellClicked(sender As Object, e As DataGridViewCellEventArgs) Handles ResidentsGridView.CellClick

        If SettingAction.buttonOf_IsClick("editButton_Column", ResidentsGridView, e) Then
            SaveButton.Enabled = False
            UpdateButton.Enabled = True
            brgyResidents.clearAllInputs()
            selectedNameInRow = ResidentsGridView.CurrentRow.Cells("fullname_Column").FormattedValue

            brgyResidents.getValuesFromDatabaseAndDisplayToInputs(selectedNameInRow)
            imageFile.getImageNameFromSelectedRow(brgyResidents.getImagePathFromSelectedRowValue, ResidentsPictureBOx)
        ElseIf SettingAction.buttonOf_IsClick("deleteButton_Column", ResidentsGridView, e) Then
            brgyResidents.clearAllInputs()
            selectedNameInRow = ResidentsGridView.CurrentRow.Cells("fullname_Column").FormattedValue

            brgyResidents.deleteResidents(selectedNameInRow)
            manage.loadGridViewValueOf(brgyResidents.getResidentsQueryForSelectedColumns, ResidentsGridView)
            search.addAndRefresh_DataSuggestion_WhileSearchingAt("FULLNAME", "residents", SearchFieldTxtBox)

        ElseIf SettingAction.buttonOf_IsClick("archiveButton_Column", ResidentsGridView, e) Then


        End If

    End Sub

    Private Sub AddNewBttn_Click(sender As Object, e As EventArgs) Handles AddNewBttn.Click
        brgyResidents.clearAllInputs()
        SaveButton.Enabled = True
        UpdateButton.Enabled = False
    End Sub



    Private Sub FnameKeyDown(sender As Object, e As KeyEventArgs) Handles Fullnametxtbox.KeyDown

    End Sub
End Class