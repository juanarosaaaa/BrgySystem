
Imports MySql.Data.MySqlClient
Public Class Purok

    Dim SettinggridViewImage As New DataGridViewImages
    Dim SettingAction As New DataGridViewActionButtonEvent

    Private var As MyPurok = New MyPurok
    Private manage As loadGridViewValue = New ManageSystem
    Private foo As Search = New SearchingFeature_Implementation
    Private AlreadyStart As Boolean = False ' due to problems in threading textchanged event start first before load event. that's why text change throws an error 



    Private Sub BunifuDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PurokGridView.CellClick
        If SettingAction.buttonOf_IsClick("editButton_Column", PurokGridView, e) Then

            PurokChildForm.PurokTextBox.Text = PurokGridView.CurrentRow.Cells("purok_Column").FormattedValue
            PurokChildForm.AddPurokBttn.Enabled = False
            PurokChildForm.UpdateBttn.Enabled = False
            PurokChildForm.changesInPurokText = True
            PurokChildForm.ShowDialog()

        ElseIf (SettingAction.buttonOf_IsClick("deleteButton_Column", PurokGridView, e)) Then
            var.deletePurok(PurokGridView.CurrentRow.Cells("purok_Column").FormattedValue)
            foo.addAndRefresh_DataSuggestion_WhileSearchingAt("PurokName", "Purok", SearchBarField)
        ElseIf (SettingAction.buttonOf_IsClick("archiveButton_Column", PurokGridView, e)) Then
            var.archivePurok(PurokGridView.CurrentRow.Cells("purok_Column").FormattedValue)
            foo.addAndRefresh_DataSuggestion_WhileSearchingAt("PurokName", "Purok", SearchBarField)
        End If
        manage.loadGridViewValueOf(var.getAllPurokQuery, PurokGridView)
    End Sub









    Private Sub CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles PurokGridView.CellFormatting
        SettinggridViewImage.setImageAtButtonColumnOf("editButton_Column", PurokGridView, e, My.Resources.icons8_edit_24px)
        SettinggridViewImage.setImageAtButtonColumnOf("deleteButton_Column", PurokGridView, e, My.Resources.icons8_trash_24px)
        SettinggridViewImage.setImageAtButtonColumnOf("archiveButton_Column", PurokGridView, e, My.Resources.icons8_archive_24px_1)
    End Sub







    Private Sub Purok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PurokGridView.Columns("purok_Column").DataPropertyName = "PurokName"
        manage.loadGridViewValueOf(var.getAllPurokQuery, PurokGridView)
        foo.addAndRefresh_DataSuggestion_WhileSearchingAt("PurokName", "Purok", SearchBarField)
    End Sub





    Private Sub AddPurokButton_Click(sender As Object, e As EventArgs) Handles AddPurokButton.Click

        PurokChildForm.UpdateBttn.Enabled = False
        PurokChildForm.changesInPurokText = False
        PurokChildForm.ShowDialog()
    End Sub






    Private Sub SearchBarTextChanged(sender As Object, e As EventArgs) Handles SearchBarField.TextChange

        If (AlreadyStart) Then
            foo.searchValueIn("SELECT * FROM `Purok` WHERE PurokName Like '%" & SearchBarField.Text.Trim & "%'", PurokGridView)
        End If

    End Sub






    Private Sub SearchBarClick(sender As Object, e As EventArgs) Handles SearchBarField.Click
        AlreadyStart = True
    End Sub






    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        foo.searchValueIn("SELECT * FROM `Purok` WHERE PurokName Like '%" & SearchBarField.Text.Trim & "%'", PurokGridView)
    End Sub
End Class