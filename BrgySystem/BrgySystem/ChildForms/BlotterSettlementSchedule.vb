Public Class BlotterSettlementSchedule
    Dim SettinggridView As SettingImageAtDataGridView = New DataGridViewImages
    Dim SettingAction As SettingActionButton = New DataGridViewActionButtonEvent
    Private Sub CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView.CellFormatting

        SettinggridView.setImageAtButtonColumnOf("update_Button_Column", DataGridView, e, My.Resources.icons8_edit_24px)
        SettinggridView.setImageAtButtonColumnOf("print_Button_Column", DataGridView, e, My.Resources.icons8_save_24px)

    End Sub

    Private Sub CellContentClicked(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView.CellContentClick
        If (SettingAction.buttonOf_IsClick("update_Button_Column", DataGridView, e)) Then
            UpdateStatusOfSettlementBlotter.ShowDialog()
        End If
    End Sub


End Class