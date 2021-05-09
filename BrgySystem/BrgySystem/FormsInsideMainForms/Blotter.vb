Public Class Blotter
    Private Sub CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TableGridView.CellContentClick
        If (DataGridViewActionButtonEvent.buttonOf_IsClick("settlementscheduleButtonColumn", TableGridView, e)) Then
            MsgBox(True)
        End If

    End Sub

    Private Sub CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles TableGridView.CellFormatting
        DataGridViewImages.setImageAtButtonColumnOf("settlementscheduleButtonColumn", TableGridView, e, My.Resources.icons8_schedule_24px)
        DataGridViewImages.setImageAtButtonColumnOf("updateButtonColumn", TableGridView, e, My.Resources.icons8_edit_24px)
        DataGridViewImages.setImageAtButtonColumnOf("printButtonColumn", TableGridView, e, My.Resources.icons8_save_24px)
    End Sub

End Class