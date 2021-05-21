Public Class Officials
    Dim SettinggridViewImage As New DataGridViewImages
    Dim SettingAction As New DataGridViewActionButtonEvent

    Private Sub CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles Guna2DataGridView1.CellFormatting
        SettinggridViewImage.setImageAtButtonColumnOf("editButton_Column", Guna2DataGridView1, e, My.Resources.icons8_edit_24px)
        SettinggridViewImage.setImageAtButtonColumnOf("deleteButton_Column", Guna2DataGridView1, e, My.Resources.icons8_trash_24px)
        SettinggridViewImage.setImageAtButtonColumnOf("archiveButton_Column", Guna2DataGridView1, e, My.Resources.icons8_archive_24px_1)
    End Sub


End Class