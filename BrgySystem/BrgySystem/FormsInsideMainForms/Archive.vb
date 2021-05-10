Public Class Archive
    Private Sub CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles TableGridView.CellFormatting
        DataGridViewImages.setImageAtButtonColumnOf("restoreButtonColumn", TableGridView, e, My.Resources.icons8_restore_page_24px_4)
    End Sub


End Class