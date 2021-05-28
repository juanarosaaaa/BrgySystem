Imports MySql.Data.MySqlClient

Public Class Archive
    Dim SettinggridViewImage As New DataGridViewImages
    Dim SettingAction As New DataGridViewActionButtonEvent
    Private manage As loadGridViewValue = New ManageSystem
    Private search As Search = New SearchingFeature_Implementation
    Private archive As New MyArchive
    Private AlreadyStartAtPurokArchive As Boolean = False
    Private AlreadyStartAtResidentArchive As Boolean = False
    Private alreadyStartAtOfficialArchive As Boolean = False
    Private Const archivePurokQuery As String = "SELECT PurokName FROM `archive_purok`"
    Private Const archiveResidentsQuery As String = "SELECT FULLNAME,SEX,AGE,RELIGION,CITIZENSHIP,ADDRESS FROM `archive_residents`"
    Private Const archiveOfficialQuery As String = "SELECT NAME,STATUS,CONTACT,POSITION,TERM,SEX,PUROK,AGE from `archive_officials`"





    Private Sub ResidentsArchiveCellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles ResidentsArchiveGridView.CellFormatting
        SettinggridViewImage.setImageAtButtonColumnOf("restoreofficials_ButtonColumn", ResidentsArchiveGridView, e, My.Resources.icons8_restore_page_24px_4)
        SettinggridViewImage.setImageAtButtonColumnOf("deleteOfficials_ButtonColumn", ResidentsArchiveGridView, e, My.Resources.icons8_trash_24px)
    End Sub
    Private Sub PurokCellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles PurokGridView.CellFormatting
        SettinggridViewImage.setImageAtButtonColumnOf("restoreButton_Column", PurokGridView, e, My.Resources.icons8_restore_page_24px_4)
        SettinggridViewImage.setImageAtButtonColumnOf("deleteButton_Column", PurokGridView, e, My.Resources.icons8_trash_24px)
    End Sub

    Private Sub OfficialCellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles ArchiveOfficialGridView.CellFormatting

        SettinggridViewImage.setImageAtButtonColumnOf("restoreButtonColumnOfficials", ArchiveOfficialGridView, e, My.Resources.icons8_restore_page_24px_4)
        SettinggridViewImage.setImageAtButtonColumnOf("deleteButtonColumnOfficials", ArchiveOfficialGridView, e, My.Resources.icons8_trash_24px)

    End Sub

    Private Sub Archive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        archive.arrangePurokColumn()
        archive.arrangeResidentsColumn()
        archive.arrangeOfficialsColumns()
        manage.loadGridViewValueOf(archivePurokQuery, PurokGridView)
        manage.loadGridViewValueOf(archiveResidentsQuery, ResidentsArchiveGridView)
        manage.loadGridViewValueOf(archiveOfficialQuery, ArchiveOfficialGridView)

        search.addAndRefresh_DataSuggestion_WhileSearchingAt("PurokName", "archive_purok", PurokArchiveSearchField)
        search.addAndRefresh_DataSuggestion_WhileSearchingAt("FULLNAME", "archive_residents", ResidentsArchiveSearchField)
        search.addAndRefresh_DataSuggestion_WhileSearchingAt("NAME", "archive_officials", OfficialsArchiveSearchField)

        PurokArchiveSearchField.PlaceholderText = "Search Purok"
        OfficialsArchiveSearchField.PlaceholderText = "Search Name"
        ResidentsArchiveSearchField.PlaceholderText = "Search Name"
    End Sub








    Private Sub PurokGridViewCellIsClick(sender As Object, e As DataGridViewCellEventArgs) Handles PurokGridView.CellClick
        If SettingAction.buttonOf_IsClick("restoreButton_Column", PurokGridView, e) Then
            archive.restorePurok(PurokGridView.CurrentRow.Cells("purok_Column").FormattedValue)
            search.addAndRefresh_DataSuggestion_WhileSearchingAt("PurokName", "archive_purok", PurokArchiveSearchField)
            manage.loadGridViewValueOf(archivePurokQuery, PurokGridView)

        ElseIf SettingAction.buttonOf_IsClick("deleteButton_Column", PurokGridView, e) Then

            archive.deletePurok(PurokGridView.CurrentRow.Cells("purok_Column").FormattedValue)
            search.addAndRefresh_DataSuggestion_WhileSearchingAt("PurokName", "archive_purok", PurokArchiveSearchField)
            manage.loadGridViewValueOf(archivePurokQuery, PurokGridView)
        End If

    End Sub

    Private Sub PurokArchiveSearchButton_isClicked(sender As Object, e As EventArgs) Handles PurokArchiveSearchButton.Click
        search.searchValueIn("SELECT * FROM `archive_purok` WHERE PurokName Like '%" & PurokArchiveSearchField.Text.Trim & "%'", PurokGridView)
    End Sub

    Private Sub PurokArchiveSearchField_TextChanged(sender As Object, e As EventArgs) Handles PurokArchiveSearchField.TextChange
        If InputIsNull(PurokArchiveSearchField.Text.Trim) And AlreadyStartAtPurokArchive Then
            manage.loadGridViewValueOf(archivePurokQuery, PurokGridView)
        End If
    End Sub

    Private Sub PurokArchiveSearchFieldIsClicked(sender As Object, e As EventArgs) Handles PurokArchiveSearchField.Click
        AlreadyStartAtPurokArchive = True
    End Sub

    Private Sub PurokArchiveKeyDown(sender As Object, e As KeyEventArgs) Handles PurokArchiveSearchField.KeyDown
        If e.KeyCode = Keys.Enter Then
            search.searchValueIn("SELECT * FROM `archive_purok` WHERE PurokName Like '%" & PurokArchiveSearchField.Text.Trim & "%'", PurokGridView)
        End If
    End Sub











    Private Sub ResidentsArchiveGridviewClicked(sender As Object, e As DataGridViewCellEventArgs) Handles ResidentsArchiveGridView.CellContentClick
        If SettingAction.buttonOf_IsClick("restoreofficials_ButtonColumn", ResidentsArchiveGridView, e) Then
            archive.restoreResidents(ResidentsArchiveGridView.CurrentRow.Cells("fname_Column").FormattedValue)
            search.addAndRefresh_DataSuggestion_WhileSearchingAt("FULLNAME", "archive_residents", ResidentsArchiveSearchField)
            manage.loadGridViewValueOf(archiveResidentsQuery, ResidentsArchiveGridView)

        ElseIf SettingAction.buttonOf_IsClick("deleteOfficials_ButtonColumn", ResidentsArchiveGridView, e) Then
            archive.deleteResidents(ResidentsArchiveGridView.CurrentRow.Cells("fname_Column").FormattedValue)
            search.addAndRefresh_DataSuggestion_WhileSearchingAt("FULLNAME", "archive_residents", ResidentsArchiveSearchField)
            manage.loadGridViewValueOf(archiveResidentsQuery, ResidentsArchiveGridView)
        End If


    End Sub

    Private Sub ResidentsArchiveSearchButton_Click(sender As Object, e As EventArgs) Handles ResidentsArchiveSearchButton.Click
        search.searchValueIn(archiveResidentsQuery & " WHERE FULLNAME Like '%" & ResidentsArchiveSearchField.Text.Trim & "%'", ResidentsArchiveGridView)
    End Sub



    Private Sub ResidentsArchiveSearchFieldTextChanged(sender As Object, e As EventArgs) Handles ResidentsArchiveSearchField.TextChange
        If InputIsNull(ResidentsArchiveSearchField.Text.Trim) And AlreadyStartAtResidentArchive Then
            manage.loadGridViewValueOf(archiveResidentsQuery, ResidentsArchiveGridView)
        End If
    End Sub

    Private Sub ResidentsArchiveSearchFieldIsClicked(sender As Object, e As EventArgs) Handles ResidentsArchiveSearchField.Click
        AlreadyStartAtResidentArchive = True
    End Sub

    Private Sub SearchFieldKeyDown(sender As Object, e As KeyEventArgs) Handles ResidentsArchiveSearchField.KeyDown
        If e.KeyCode = Keys.Enter Then
            search.searchValueIn(archiveResidentsQuery & "WHERE FULLNAME LIKE '%" & ResidentsArchiveSearchField.Text.Trim & "%'", ResidentsArchiveGridView)
        End If
    End Sub














    Private Sub OfficialArchiveGridViewIsClicked(sender As Object, e As DataGridViewCellEventArgs) Handles ArchiveOfficialGridView.CellClick
        If SettingAction.buttonOf_IsClick("restoreButtonColumnOfficials", ArchiveOfficialGridView, e) Then
            archive.restoreOfficials(ArchiveOfficialGridView.CurrentRow.Cells("fullnameColumnOfficials").FormattedValue)
            search.addAndRefresh_DataSuggestion_WhileSearchingAt("NAME", "archive_officials", OfficialsArchiveSearchField)
            manage.loadGridViewValueOf(archiveOfficialQuery, ArchiveOfficialGridView)
        ElseIf SettingAction.buttonOf_IsClick("deleteButtonColumnOfficials", ArchiveOfficialGridView, e) Then
            archive.deleteOfficials(ArchiveOfficialGridView.CurrentRow.Cells("fullnameColumnOfficials").FormattedValue)
            search.addAndRefresh_DataSuggestion_WhileSearchingAt("NAME", "archive_officials", OfficialsArchiveSearchField)
            manage.loadGridViewValueOf(archiveOfficialQuery, ArchiveOfficialGridView)
        End If

    End Sub





    Private Sub ArchiveOfficialsSearchFieldTextChanged(sender As Object, e As EventArgs) Handles OfficialsArchiveSearchField.TextChange
        If InputIsNull(OfficialsArchiveSearchField.Text.Trim) And alreadyStartAtOfficialArchive Then
            manage.loadGridViewValueOf(archiveOfficialQuery, ArchiveOfficialGridView)
        End If
    End Sub

    Private Sub ArchiveOfficialsSearchFieldClicked(sender As Object, e As EventArgs) Handles OfficialsArchiveSearchField.Click
        alreadyStartAtOfficialArchive = True
    End Sub

    Private Sub ArchiveOfficialSearchFieldKeyDown(sender As Object, e As KeyEventArgs) Handles OfficialsArchiveSearchField.KeyDown
        If e.KeyCode = Keys.Enter Then
            search.searchValueIn(archiveOfficialQuery & "WHERE Name LIKE '%" & OfficialsArchiveSearchField.Text.Trim & "%'", ArchiveOfficialGridView)
        End If
    End Sub

    Private Sub OfficialSearchButton_Click_1(sender As Object, e As EventArgs) Handles OfficialSearchButton.Click
        search.searchValueIn(archiveOfficialQuery & "WHERE Name LIKE '%" & OfficialsArchiveSearchField.Text.Trim & "%'", ArchiveOfficialGridView)
    End Sub
End Class