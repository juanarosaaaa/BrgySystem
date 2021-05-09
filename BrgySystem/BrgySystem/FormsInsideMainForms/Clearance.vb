Public Class Clearance
    Private Sub CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles TableDataGridView.CellFormatting
        DataGridViewImages.setImageAtButtonColumnOf("deleteButtonColumn", TableDataGridView, e, My.Resources.icons8_trash_24px)
    End Sub
End Class