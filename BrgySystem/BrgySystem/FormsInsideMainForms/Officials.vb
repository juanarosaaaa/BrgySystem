Public Class Officials
    Private SettinggridViewImage As New DataGridViewImages
    Private SettingAction As New DataGridViewActionButtonEvent
    Private officials_ As New MyOfficials
    Private manage As loadGridViewValue = New ManageSystem
    Private search As Search = New SearchingFeature_Implementation
    Private isAlreadyStart As Boolean = False
    Private valueYouSearchFor As String
    Private imageFile As ImageFileManager = New ImageFileManager()
    Public isNameModified, isContactModified As Boolean
    Private selectedResidentNameInROw As String





    Private Sub CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles OfficialsGridVIew.CellFormatting
        SettinggridViewImage.setImageAtButtonColumnOf("editButton_Column", OfficialsGridVIew, e, My.Resources.icons8_edit_24px)
        SettinggridViewImage.setImageAtButtonColumnOf("deleteButton_Column", OfficialsGridVIew, e, My.Resources.icons8_trash_24px)
        SettinggridViewImage.setImageAtButtonColumnOf("archiveButton_Column", OfficialsGridVIew, e, My.Resources.icons8_archive_24px_1)
    End Sub




    Private Sub Officials_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        officials_.arrangeGridView()
        isNameModified = False
        isContactModified = False
        UpdateButton.Enabled = False
        manage.loadGridViewValueOf(officials_.getOfficialsQueryValuesSelectedColumn, OfficialsGridVIew)
        search.addAndRefresh_DataSuggestion_WhileSearchingAt("Name", "officials", SearchfieldTExtBox)
        search.addAndRefresh_DataSuggestion_WhileSearchingAt("PurokName", "Purok", PurokTxtBox)
    End Sub




    Private Sub SearchFieldIsClicked(sender As Object, e As EventArgs) Handles SearchfieldTExtBox.Click
        isAlreadyStart = True
    End Sub






    Private Sub SearchfieldTExtBox_TextChanged(sender As Object, e As EventArgs) Handles SearchfieldTExtBox.TextChanged
        valueYouSearchFor = officials_.getOfficialsQueryValuesSelectedColumn + "WHERE NAME LIKE '%" & SearchfieldTExtBox.Text.Trim & "%' "
        If InputIsNull(SearchfieldTExtBox.Text.Trim) And isAlreadyStart Then
            manage.loadGridViewValueOf(officials_.getOfficialsQueryValuesSelectedColumn, OfficialsGridVIew)
        End If
    End Sub


    Private Sub SearchButtonCLicked(sender As Object, e As EventArgs) Handles OfficialSearchButton.Click
        search.searchValueIn(valueYouSearchFor, OfficialsGridVIew)
    End Sub


    Private Sub SearchFieldKeyDown(sender As Object, e As KeyEventArgs) Handles SearchfieldTExtBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            search.searchValueIn(valueYouSearchFor, OfficialsGridVIew)
        End If
    End Sub







    Private Sub BrowseButton_Click(sender As Object, e As EventArgs) Handles BrowseButton.Click
        imageFile.openImageFromPictureBox(OfficialsPictureBox)
    End Sub






    Private Sub CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles OfficialsGridVIew.CellContentClick

        If SettingAction.buttonOf_IsClick("editButton_Column", OfficialsGridVIew, e) Then

            isNameModified = False
            isContactModified = False
            SaveButton.Enabled = False
            UpdateButton.Enabled = True

            selectedResidentNameInROw = OfficialsGridVIew.CurrentRow.Cells("name_Column").FormattedValue
            officials_.getValuesFromDatabaseAndDisplayToInputs(selectedResidentNameInROw)
            imageFile.getImageNameFromSelectedRow(officials_.getImagePathFromSelectedRowValue, OfficialsPictureBox)


        ElseIf SettingAction.buttonOf_IsClick("deleteButton_Column", OfficialsGridVIew, e) Then
            selectedResidentNameInROw = OfficialsGridVIew.CurrentRow.Cells("name_Column").FormattedValue

            officials_.deleteOfficial(selectedResidentNameInROw)
            manage.loadGridViewValueOf(officials_.getOfficialsQueryValuesSelectedColumn, OfficialsGridVIew)
            search.addAndRefresh_DataSuggestion_WhileSearchingAt("Name", "officials", SearchfieldTExtBox)
            officials_.clearAllInputs()

            UpdateButton.Enabled = False
        ElseIf SettingAction.buttonOf_IsClick("archiveButton_Column", OfficialsGridVIew, e) Then
            selectedResidentNameInROw = OfficialsGridVIew.CurrentRow.Cells("name_Column").FormattedValue

            officials_.archiveOfficials(selectedResidentNameInROw)
            manage.loadGridViewValueOf(officials_.getOfficialsQueryValuesSelectedColumn, OfficialsGridVIew)
            search.addAndRefresh_DataSuggestion_WhileSearchingAt("Name", "officials", SearchfieldTExtBox)
            officials_.clearAllInputs()

            UpdateButton.Enabled = False
        End If

    End Sub





    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Try
            If OfficialsPictureBox.Image Is OfficialsPictureBox.InitialImage Then
                Throw New NoNullAllowedException
            End If
            imageFile.saveImageAt("OfficialsImages")
        Catch ex As NoNullAllowedException
            MessageBox.Show("No picture selected!", "INCOMPLETE DETAILS!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End Try

        Dim message As String = "Officials '" & FullnameTextBox.Text.Trim.ToUpper & "' successfully added!"
        Dim query As String = officials_.getInsertQuery(imageFile.getImageName, imageFile.getImageFolderPath)

        If officials_.addOrUpdateOfficials(message, query, imageFile.getImageName) Then
            search.addAndRefresh_DataSuggestion_WhileSearchingAt("Name", "officials", SearchfieldTExtBox)
            manage.loadGridViewValueOf(officials_.getOfficialsQueryValuesSelectedColumn, OfficialsGridVIew)

        End If
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Try
            If OfficialsPictureBox.Image Is OfficialsPictureBox.InitialImage Then
                Throw New NoNullAllowedException
            End If
            imageFile.saveImageAt("OfficialsImages")
        Catch ex As NoNullAllowedException
            MessageBox.Show("No picture selected!", "INCOMPLETE DETAILS!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End Try
        Dim message As String = "Officials '" & FullnameTextBox.Text.Trim.ToUpper & "' successfully updated!"
        Dim query As String = officials_.getUpdateQuery(selectedResidentNameInROw, imageFile.getImageName, imageFile.getImageFolderPath)

        If officials_.addOrUpdateOfficials(message, query, imageFile.getImageName) Then
            search.addAndRefresh_DataSuggestion_WhileSearchingAt("NAME", "officials", SearchfieldTExtBox)
            manage.loadGridViewValueOf(officials_.getOfficialsQueryValuesSelectedColumn, OfficialsGridVIew)

        End If

    End Sub




    Private Sub AddNewButton_Click(sender As Object, e As EventArgs) Handles AddNewButton.Click
        officials_.clearAllInputs()
        SaveButton.Enabled = True
        UpdateButton.Enabled = False
    End Sub

    Private Sub FullnameKeyDown(sender As Object, e As KeyEventArgs) Handles FullnameTextBox.KeyDown
        isNameModified = True
    End Sub

    Private Sub GunaWinSwitch1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub ContactKeyDown(sender As Object, e As KeyEventArgs) Handles ContactTextBox.KeyDown
        isContactModified = True
    End Sub




End Class