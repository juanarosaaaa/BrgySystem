Public Class Blotter
    Private Sub CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick
        If (DataGridViewActionButtonEvent.buttonOf_IsClick("settlementScheduleButton_Column", Guna2DataGridView1, e)) Then
            BlotterSettlementSchedule.ShowDialog()
        End If
        If (DataGridViewActionButtonEvent.buttonOf_IsClick("updateButton_Column", Guna2DataGridView1, e)) Then
            UpdateStatusOfSettlementBlotter.ShowDialog()
        End If

    End Sub

    Private Sub CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles Guna2DataGridView1.CellFormatting
        DataGridViewImages.setImageAtButtonColumnOf("settlementScheduleButton_Column", Guna2DataGridView1, e, My.Resources.icons8_schedule_24px)
        DataGridViewImages.setImageAtButtonColumnOf("updateButton_Column", Guna2DataGridView1, e, My.Resources.icons8_edit_24px)
        DataGridViewImages.setImageAtButtonColumnOf("printButton_Column", Guna2DataGridView1, e, My.Resources.icons8_save_24px)
    End Sub

    Private Sub BunifuTextBox6_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class