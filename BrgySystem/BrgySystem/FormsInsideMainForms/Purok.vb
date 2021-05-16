Public Class Purok
    Dim SettinggridViewImage As New DataGridViewImages
    Dim SettingAction As New DataGridViewActionButtonEvent
    Private var As MyPurok = New MyPurok
    Private Sub BunifuDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PurokGridView.CellClick
        If SettingAction.buttonOf_IsClick("editButton_Column", PurokGridView, e) Then
            PurokChildForm.AddPurokTextBox.Text = PurokGridView.SelectedCells(0).Value.ToString
            PurokChildForm.AddPurokBttn.Enabled = False
            closeConnection()
            PurokChildForm.ShowDialog()


        ElseIf (SettingAction.buttonOf_IsClick("deleteButton_Column", PurokGridView, e)) Then
            MsgBox("delete")
        ElseIf (SettingAction.buttonOf_IsClick("archiveButton_Column", PurokGridView, e)) Then
            MsgBox("archive")
        End If

    End Sub



    Private Sub CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles PurokGridView.CellFormatting
        SettinggridViewImage.setImageAtButtonColumnOf("editButton_Column", PurokGridView, e, My.Resources.icons8_edit_24px)
        SettinggridViewImage.setImageAtButtonColumnOf("deleteButton_Column", PurokGridView, e, My.Resources.icons8_trash_24px)
        SettinggridViewImage.setImageAtButtonColumnOf("archiveButton_Column", PurokGridView, e, My.Resources.icons8_archive_24px_1)
    End Sub

    Private Sub Purok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openConnection()

        var.loadPurok(PurokGridView)
    End Sub

    Private Sub AddPurokButton_Click(sender As Object, e As EventArgs) Handles AddPurokButton.Click
        closeConnection()
        PurokChildForm.UpdateBttn.Enabled = False
        PurokChildForm.ShowDialog()
    End Sub
End Class