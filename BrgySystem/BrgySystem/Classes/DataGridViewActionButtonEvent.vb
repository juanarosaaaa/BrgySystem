Class DataGridViewActionButtonEvent
    Implements SettingActionButton
    Function buttonOf_IsClick(name As String, table As DataGridView, e As DataGridViewCellEventArgs) As Boolean Implements SettingActionButton.buttonOf_IsClick
        Return table.Columns(e.ColumnIndex).Name = name
    End Function

End Class
