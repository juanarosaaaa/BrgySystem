Imports Guna.UI2.WinForms
Imports Bunifu.UI.WinForms
Public Interface Search
    Sub searchValueIn(query As String, gridview As Guna2DataGridView)
    Sub addDataSuggestionWhileSearchingAt(tableName As String, query As String, val As BunifuTextBox)
End Interface
