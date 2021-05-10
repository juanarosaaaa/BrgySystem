Public Class Purok
    Private Sub BunifuDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TableGridView.CellContentClick

    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        PurokChildForm.ShowDialog()
    End Sub

    Private Sub CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles TableGridView.CellFormatting
        DataGridViewImages.setImageAtButtonColumnOf("editButtonColumn", TableGridView, e, My.Resources.icons8_edit_24px)
        DataGridViewImages.setImageAtButtonColumnOf("deleteButtonColumn", TableGridView, e, My.Resources.icons8_trash_24px)
    End Sub
End Class