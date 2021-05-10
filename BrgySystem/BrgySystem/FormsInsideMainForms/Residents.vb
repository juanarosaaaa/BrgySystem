Public Class Residents
    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        ResidentsChildForm.ShowDialog()
    End Sub

    Private Sub CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles TableGridView.CellFormatting
        DataGridViewImages.setImageAtButtonColumnOf("deleteButtonColumn", TableGridView, e, My.Resources.icons8_trash_24px)
        DataGridViewImages.setImageAtButtonColumnOf("archiveButtonColumn", TableGridView, e, My.Resources.icons8_archive_24px_1)
        DataGridViewImages.setImageAtButtonColumnOf("editButtonColumn", TableGridView, e, My.Resources.icons8_edit_24px)
    End Sub
End Class