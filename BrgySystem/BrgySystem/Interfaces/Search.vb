Imports Guna.UI2.WinForms
Imports Bunifu.UI.WinForms
Public Interface Search
    Sub searchValueIn(query As String, gridview As Guna2DataGridView)
    Sub addAndRefresh_DataSuggestion_WhileSearchingAt(columnName As String, tableName As String, searchField As BunifuTextBox)
End Interface