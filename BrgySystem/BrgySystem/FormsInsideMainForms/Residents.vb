﻿Imports MySql.Data.MySqlClient

Public Class MyResidents
    Dim SettinggridViewImage As SettingImageAtDataGridView = New DataGridViewImages
    Dim SettingAction As SettingActionButton = New DataGridViewActionButtonEvent


    Private Sub CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles Guna2DataGridView1.CellFormatting
        SettinggridViewImage.setImageAtButtonColumnOf("deleteButton_Column", Guna2DataGridView1, e, My.Resources.icons8_trash_24px)
        SettinggridViewImage.setImageAtButtonColumnOf("archiveButton_Column", Guna2DataGridView1, e, My.Resources.icons8_archive_24px_1)
        SettinggridViewImage.setImageAtButtonColumnOf("editButton_Column", Guna2DataGridView1, e, My.Resources.icons8_edit_24px)
    End Sub

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick

    End Sub


End Class