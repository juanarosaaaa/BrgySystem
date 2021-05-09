Public Class Officials
    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        OfficialsChildForm.ShowDialog()
    End Sub

    Private Sub CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles TableGridView.CellFormatting
        DataGridViewImages.setImageAtButtonColumnOf("editButtonColumn", TableGridView, e, My.Resources.icons8_edit_24px)
        DataGridViewImages.setImageAtButtonColumnOf("deleteButtonColumn", TableGridView, e, My.Resources.icons8_trash_24px)
    End Sub
End Class