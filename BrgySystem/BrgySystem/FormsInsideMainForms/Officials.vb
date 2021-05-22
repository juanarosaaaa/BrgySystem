Public Class Officials
    Private SettinggridViewImage As New DataGridViewImages
    Private SettingAction As New DataGridViewActionButtonEvent
    Private officials As New MyOfficials
    Private manage As loadGridViewValue = New ManageSystem
    Private search As Search = New SearchingFeature_Implementation
    Private isAlreadyStart As Boolean = False
    Private searchingSelectedColumnsQuery As String
    Private imageFile As ImageFileManager = New ImageFileManager()


    Private Sub CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles OfficialsGridVIew.CellFormatting
        SettinggridViewImage.setImageAtButtonColumnOf("editButton_Column", OfficialsGridVIew, e, My.Resources.icons8_edit_24px)
        SettinggridViewImage.setImageAtButtonColumnOf("deleteButton_Column", OfficialsGridVIew, e, My.Resources.icons8_trash_24px)
        SettinggridViewImage.setImageAtButtonColumnOf("archiveButton_Column", OfficialsGridVIew, e, My.Resources.icons8_archive_24px_1)
    End Sub

    Private Sub Officials_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        officials.arrangeGridView()
        manage.loadGridViewValueOf(officials.getOfficialsQueryValuesSelectedColumn, OfficialsGridVIew)
        search.addAndRefresh_DataSuggestion_WhileSearchingAt("Name", "officials", SearchfieldTExtBox)
        search.addAndRefresh_DataSuggestion_WhileSearchingAt("PurokName", "Purok", PurokTextBox)
    End Sub

    Private Sub SearchFieldIsClicked(sender As Object, e As EventArgs) Handles SearchfieldTExtBox.Click
        isAlreadyStart = True
    End Sub

    Private Sub SearchfieldTExtBox_TextChanged(sender As Object, e As EventArgs) Handles SearchfieldTExtBox.TextChanged
        If isAlreadyStart Then
            searchingSelectedColumnsQuery = officials.getOfficialsQueryValuesSelectedColumn + "WHERE NAME LIKE '%" & SearchfieldTExtBox.Text.Trim & "%' "
            search.searchValueIn(searchingSelectedColumnsQuery, OfficialsGridVIew)
            If InputIsNull(SearchfieldTExtBox.Text.Trim) Then
                manage.loadGridViewValueOf(officials.getOfficialsQueryValuesSelectedColumn, OfficialsGridVIew)
            End If
        End If

    End Sub

    Private Sub SearchbarButton_Click(sender As Object, e As EventArgs) Handles SearchbarButton.Click
        search.searchValueIn(searchingSelectedColumnsQuery, OfficialsGridVIew)
    End Sub

    Private Sub BrowseButton_Click(sender As Object, e As EventArgs) Handles BrowseButton.Click
        imageFile.openImageFromPictureBox(OfficialsPictureBox)
    End Sub

    Private Sub CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles OfficialsGridVIew.CellContentClick

        If SettingAction.buttonOf_IsClick("editButton_Column", OfficialsGridVIew, e) Then
            MsgBox("editbutton is click")
        ElseIf SettingAction.buttonOf_IsClick("deleteButton_Column", OfficialsGridVIew, e) Then
            MsgBox("deleteButton_Column is click")
        ElseIf SettingAction.buttonOf_IsClick("archiveButton_Column", OfficialsGridVIew, e) Then
            MsgBox("archiveButton_Column is click")
        End If

    End Sub





End Class