Imports MySql.Data.MySqlClient

Public Class Archive
    Dim SettinggridViewImage As SettingImageAtDataGridView = New DataGridViewImages
    Dim SettingAction As SettingActionButton = New DataGridViewActionButtonEvent
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

    End Sub
End Class