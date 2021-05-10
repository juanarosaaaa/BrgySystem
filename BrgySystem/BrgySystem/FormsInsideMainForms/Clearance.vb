Public Class Clearance
    Private Sub CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles TableDataGridView.CellFormatting
        DataGridViewImages.setImageAtButtonColumnOf("deleteButtonColumn", TableDataGridView, e, My.Resources.icons8_trash_24px)
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        ClearanceChildForm.ShowDialog()
    End Sub
End Class