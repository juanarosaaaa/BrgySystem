Public Class Officials
    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        OfficialsChildForm.ShowDialog()
    End Sub

    Private Sub CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles Guna2DataGridView1.CellFormatting
        DataGridViewImages.setImageAtButtonColumnOf("editButton_Column", Guna2DataGridView1, e, My.Resources.icons8_edit_24px)
        DataGridViewImages.setImageAtButtonColumnOf("deleteButton_Column", Guna2DataGridView1, e, My.Resources.icons8_trash_24px)
        DataGridViewImages.setImageAtButtonColumnOf("archiveButton_Column", Guna2DataGridView1, e, My.Resources.icons8_archive_24px_1)
    End Sub

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick

    End Sub
End Class