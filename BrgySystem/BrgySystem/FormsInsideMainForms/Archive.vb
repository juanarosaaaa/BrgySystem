Imports MySql.Data.MySqlClient

Public Class Archive
    Dim SettinggridViewImage As New DataGridViewImages
    Dim SettingAction As New DataGridViewActionButtonEvent
    Private manage As loadGridViewValue = New ManageSystem
    Private search As Search = New SearchingFeature_Implementation
    Private archive As New MyArchive
    Private AlreadyStartAtPurokArchive As Boolean = False
    Private AlreadyStartAtResidentArchive As Boolean = False

    Private Const archivePurokQuery As String = "SELECT PurokName FROM `archive_purok`"
    Private Const archiveResidentsQuery As String = "SELECT FULLNAME,SEX,AGE,RELIGION,CITIZENSHIP,ADDRESS FROM `archive_residents`"

    Private Sub ResidentsArchiveCellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles ResidentsArchiveGridView.CellFormatting
        SettinggridViewImage.setImageAtButtonColumnOf("restoreofficials_ButtonColumn", ResidentsArchiveGridView, e, My.Resources.icons8_restore_page_24px_4)
        SettinggridViewImage.setImageAtButtonColumnOf("deleteOfficials_ButtonColumn", ResidentsArchiveGridView, e, My.Resources.icons8_trash_24px)
    End Sub
    Private Sub PurokCellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles PurokGridView.CellFormatting
        SettinggridViewImage.setImageAtButtonColumnOf("restoreButton_Column", PurokGridView, e, My.Resources.icons8_restore_page_24px_4)
        SettinggridViewImage.setImageAtButtonColumnOf("deleteButton_Column", PurokGridView, e, My.Resources.icons8_trash_24px)
    End Sub

    Private Sub OfficialCellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles ArchiveGridView.CellFormatting

        SettinggridViewImage.setImageAtButtonColumnOf("restoreButtonColumnOfficials", ArchiveGridView, e, My.Resources.icons8_restore_page_24px_4)
        SettinggridViewImage.setImageAtButtonColumnOf("deleteButtonColumnOfficials", ArchiveGridView, e, My.Resources.icons8_trash_24px)

    End Sub











    Private Sub Archive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        archive.arrangePurokColumn()
        archive.arrangeResidentsColumn()

        manage.loadGridViewValueOf(archivePurokQuery, PurokGridView)
        manage.loadGridViewValueOf(archiveResidentsQuery, ResidentsArchiveGridView)

        search.addAndRefresh_DataSuggestion_WhileSearchingAt("PurokName", "archive_purok", PurokArchiveSearchField)
       search.addAndRefresh_DataSuggestion_WhileSearchingAt("FULLNAME", "archive_residents", ResidentsArchiveSearchField)
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
        If (AlreadyStartAtPurokArchive) Then
            search.searchValueIn("SELECT PurokName FROM `archive_purok` WHERE PurokName Like '%" & PurokArchiveSearchField.Text.Trim & "%'", PurokGridView)
            If InputIsNull(PurokArchiveSearchField.Text.Trim) Then
                manage.loadGridViewValueOf(archivePurokQuery, PurokGridView)
            End If
        End If
    End Sub

    Private Sub PurokArchiveSearchFieldIsClicked(sender As Object, e As EventArgs) Handles PurokArchiveSearchField.Click
        AlreadyStartAtPurokArchive = True
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
        search.searchValueIn("SELECT * FROM `archive_residents` WHERE FULLNAME Like '%" & ResidentsArchiveSearchField.Text.Trim & "%'", ResidentsArchiveGridView)
    End Sub



    Private Sub ResidentsArchiveSearchFieldTextChanged(sender As Object, e As EventArgs) Handles ResidentsArchiveSearchField.TextChange
        If (AlreadyStartAtResidentArchive) Then
            search.searchValueIn(archiveResidentsQuery & "WHERE FULLNAME LIKE '%" & ResidentsArchiveSearchField.Text.Trim & "%'", ResidentsArchiveGridView)
            If InputIsNull(ResidentsArchiveSearchField.Text.Trim) Then
                manage.loadGridViewValueOf(archiveResidentsQuery, ResidentsArchiveGridView)
            End If
        End If
    End Sub

    Private Sub ResidentsArchiveSearchFieldIsClicked(sender As Object, e As EventArgs) Handles ResidentsArchiveSearchField.Click
        AlreadyStartAtResidentArchive = True
    End Sub


End Class