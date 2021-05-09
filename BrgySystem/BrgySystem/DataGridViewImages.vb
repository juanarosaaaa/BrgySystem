Module DataGridViewImages
    Sub setImageAtButtonColumnOf(name As String, table As DataGridView, event_ As DataGridViewCellFormattingEventArgs, resource As Bitmap)
        If (table.Columns(event_.ColumnIndex).Name = name) Then
            event_.Value = resource
        End If
    End Sub
End Module
