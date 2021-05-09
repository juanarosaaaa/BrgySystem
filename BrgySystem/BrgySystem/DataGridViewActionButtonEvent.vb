Module DataGridViewActionButtonEvent
    Function buttonOf_IsClick(name As String, table As DataGridView, e As DataGridViewCellEventArgs) As Boolean
        Return table.Columns(e.ColumnIndex).Name = name
    End Function

End Module
