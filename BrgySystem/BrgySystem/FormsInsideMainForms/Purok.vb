Public Class Purok
    Dim SettinggridViewImage As SettingImageAtDataGridView = New DataGridViewImages
    Dim SettingAction As SettingActionButton = New DataGridViewActionButtonEvent
    Private Sub BunifuDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PurokGridView.CellContentClick
        SettingAction.buttonOf_IsClick("editButton_Column", PurokGridView, e)
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        PurokChildForm.ShowDialog()
    End Sub

    Private Sub CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles PurokGridView.CellFormatting
        SettinggridViewImage.setImageAtButtonColumnOf("editButton_Column", PurokGridView, e, My.Resources.icons8_edit_24px)
        SettinggridViewImage.setImageAtButtonColumnOf("deleteButton_Column", PurokGridView, e, My.Resources.icons8_trash_24px)
        SettinggridViewImage.setImageAtButtonColumnOf("archiveButton_Column", PurokGridView, e, My.Resources.icons8_archive_24px_1)
    End Sub

    Private Sub Purok_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class