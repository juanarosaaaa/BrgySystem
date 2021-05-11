Public Class Archive
    Private Sub ResidentsCellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles ResidentsGridView.CellFormatting
        DataGridViewImages.setImageAtButtonColumnOf("restore_Button_Column", ResidentsGridView, e, My.Resources.icons8_restore_page_24px_4)
        DataGridViewImages.setImageAtButtonColumnOf("delete_Button_Column", ResidentsGridView, e, My.Resources.icons8_trash_24px)

    End Sub

    Private Sub PurokCellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles PurokGridView.CellFormatting
        DataGridViewImages.setImageAtButtonColumnOf("restoreButton_Column", PurokGridView, e, My.Resources.icons8_restore_page_24px_4)
        DataGridViewImages.setImageAtButtonColumnOf("deleteButton_Column", PurokGridView, e, My.Resources.icons8_trash_24px)
    End Sub

    Private Sub OfficialCellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles ArchiveGridView.CellFormatting
        DataGridViewImages.setImageAtButtonColumnOf("restoreButtonColumnOfficials", ArchiveGridView, e, My.Resources.icons8_restore_page_24px_4)
        DataGridViewImages.setImageAtButtonColumnOf("deleteButtonColumnOfficials", ArchiveGridView, e, My.Resources.icons8_trash_24px)
    End Sub


End Class