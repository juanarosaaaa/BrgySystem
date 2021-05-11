Public Class BlotterSettlementSchedule
    Private Sub CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView.CellFormatting

        DataGridViewImages.setImageAtButtonColumnOf("update_Button_Column", DataGridView, e, My.Resources.icons8_edit_24px)
        DataGridViewImages.setImageAtButtonColumnOf("print_Button_Column", DataGridView, e, My.Resources.icons8_save_24px)

    End Sub

    Private Sub CellContentClicked(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView.CellContentClick
        If (DataGridViewActionButtonEvent.buttonOf_IsClick("update_Button_Column", DataGridView, e)) Then
            UpdateStatusOfSettlementBlotter.ShowDialog()
        End If
    End Sub


End Class