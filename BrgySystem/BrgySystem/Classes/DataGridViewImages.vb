Class DataGridViewImages
    Implements SettingImageAtDataGridView
    Sub setImageAtButtonColumnOf(name As String, table As DataGridView, event_ As DataGridViewCellFormattingEventArgs, resource As Bitmap) Implements SettingImageAtDataGridView.setImageAtButtonColumnOf
        If (table.Columns(event_.ColumnIndex).Name = name) Then
            event_.Value = resource
        End If
    End Sub
End Class
