Public Class Blotter
    Dim SettinggridViewImage As New DataGridViewImages
    Dim SettingAction As New DataGridViewActionButtonEvent
    Private Sub CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick
        If (SettingAction.buttonOf_IsClick("settlementScheduleButton_Column", Guna2DataGridView1, e)) Then
            BlotterSettlementSchedule.ShowDialog()
        End If
        If (SettingAction.buttonOf_IsClick("updateButton_Column", Guna2DataGridView1, e)) Then
            UpdateStatusOfSettlementBlotter.ShowDialog()
        End If

    End Sub

    Private Sub CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles Guna2DataGridView1.CellFormatting
        SettinggridViewImage.setImageAtButtonColumnOf("settlementScheduleButton_Column", Guna2DataGridView1, e, My.Resources.icons8_schedule_24px)
        SettinggridViewImage.setImageAtButtonColumnOf("updateButton_Column", Guna2DataGridView1, e, My.Resources.icons8_edit_24px)
        SettinggridViewImage.setImageAtButtonColumnOf("printButton_Column", Guna2DataGridView1, e, My.Resources.icons8_save_24px)
    End Sub


End Class