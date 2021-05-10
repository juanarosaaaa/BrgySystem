Public Class BlotterSettlementSchedule
    Private Sub CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles TableGridView.CellFormatting

        DataGridViewImages.setImageAtButtonColumnOf("updateStatusButtonColumn", TableGridView, e, My.Resources.icons8_edit_24px)
        DataGridViewImages.setImageAtButtonColumnOf("PrintButtonColumn", TableGridView, e, My.Resources.icons8_save_24px)

    End Sub

    Private Sub CellContentClicked(sender As Object, e As DataGridViewCellEventArgs) Handles TableGridView.CellContentClick
        If (DataGridViewActionButtonEvent.buttonOf_IsClick("updateStatusButtonColumn", TableGridView, e)) Then
            UpdateStatusOfSettlementBlotter.ShowDialog()
        End If
    End Sub

End Class