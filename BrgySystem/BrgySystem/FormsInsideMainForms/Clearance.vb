Public Class Clearance
    Private Sub CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles Guna2DataGridView1.CellFormatting
        DataGridViewImages.setImageAtButtonColumnOf("deleteButton_Column", Guna2DataGridView1, e, My.Resources.icons8_trash_24px)
        DataGridViewImages.setImageAtButtonColumnOf("viewButtonColumn", Guna2DataGridView1, e, My.Resources.icons8_edit_24px)

    End Sub





    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs)
        ClearanceChildForm.ShowDialog()
    End Sub


End Class