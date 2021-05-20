Imports MySql.Data.MySqlClient

Public Class Archive
    Dim SettinggridViewImage As New DataGridViewImages
    Dim SettingAction As New DataGridViewActionButtonEvent
    Private manage As loadGridViewValue = New ManageSystem
    Private search As Search = New SearchingFeature_Implementation
    Private operation As New MyArchive
    Private AlreadyStartAtPurokArchive As Boolean = False
    Private Const archivePurokQuery As String = "SELECT * FROM `archive_purok`"
    Private Sub ResidentsCellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles ResidentsGridView.CellFormatting
        SettinggridViewImage.setImageAtButtonColumnOf("restore_Button_Column", ResidentsGridView, e, My.Resources.icons8_restore_page_24px_4)
        SettinggridViewImage.setImageAtButtonColumnOf("delete_Button_Column", ResidentsGridView, e, My.Resources.icons8_trash_24px)

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
        PurokGridView.Columns("purok_Column").DataPropertyName = "PurokName"
        manage.loadGridViewValueOf(archivePurokQuery, PurokGridView)
        search.addAndRefresh_DataSuggestion_WhileSearchingAt("PurokName", "archive_purok", PurokArchiveSearchField)
    End Sub

    Private Sub PurokGridViewCellIsClick(sender As Object, e As DataGridViewCellEventArgs) Handles PurokGridView.CellClick
        If SettingAction.buttonOf_IsClick("restoreButton_Column", PurokGridView, e) Then
            operation.restoreData(PurokGridView.CurrentRow.Cells("purok_Column").FormattedValue)
            search.addAndRefresh_DataSuggestion_WhileSearchingAt("PurokName", "archive_purok", PurokArchiveSearchField)
            manage.loadGridViewValueOf(archivePurokQuery, PurokGridView)

        ElseIf SettingAction.buttonOf_IsClick("deleteButton_Column", PurokGridView, e) Then

            operation.deletePurok(PurokGridView.CurrentRow.Cells("purok_Column").FormattedValue)
            search.addAndRefresh_DataSuggestion_WhileSearchingAt("PurokName", "archive_purok", PurokArchiveSearchField)
            manage.loadGridViewValueOf(archivePurokQuery, PurokGridView)
        End If

    End Sub


    Private Sub PurokArchiveSearchField_isClicked(sender As Object, e As EventArgs) Handles TabPage2.Click
        AlreadyStartAtPurokArchive = True
    End Sub

    Private Sub PurokArchiveSearchButton_isClicked(sender As Object, e As EventArgs) Handles PurokArchiveSearchButton.Click
        search.searchValueIn("SELECT * FROM `archive_purok` WHERE PurokName Like '%" & PurokArchiveSearchField.Text.Trim & "%'", PurokGridView)
    End Sub

    Private Sub PurokArchiveSearchField_TextChanged(sender As Object, e As EventArgs) Handles PurokArchiveSearchField.TextChange
        If (AlreadyStartAtPurokArchive) Then
            search.searchValueIn("SELECT * FROM `archive_purok` WHERE PurokName Like '%" & PurokArchiveSearchField.Text.Trim & "%'", PurokGridView)
            If InputIsNull(PurokArchiveSearchField.Text.Trim) Then
                manage.loadGridViewValueOf(archivePurokQuery, PurokGridView)
            End If
        End If

    End Sub
End Class