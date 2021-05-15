Public Class Purok
    Private Sub BunifuDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick
        DataGridViewActionButtonEvent.buttonOf_IsClick("editButton_Column", Guna2DataGridView1, e)
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        PurokChildForm.ShowDialog()
    End Sub

    Private Sub CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles Guna2DataGridView1.CellFormatting
        DataGridViewImages.setImageAtButtonColumnOf("editButton_Column", Guna2DataGridView1, e, My.Resources.icons8_edit_24px)
        DataGridViewImages.setImageAtButtonColumnOf("deleteButton_Column", Guna2DataGridView1, e, My.Resources.icons8_trash_24px)
        DataGridViewImages.setImageAtButtonColumnOf("archiveButton_Column", Guna2DataGridView1, e, My.Resources.icons8_archive_24px_1)
    End Sub

    Private Sub Purok_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class