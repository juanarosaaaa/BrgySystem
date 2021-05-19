Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms
Imports Bunifu.UI.WinForms
Public Class SearchingFeatureImplementation

    Implements Search
    Sub searchValueIn(query As String, gridview As Guna2DataGridView) Implements Search.searchValueIn
        openConnection()
        Dim table As New DataTable
        Dim adapter As New MySqlDataAdapter(query, getConnection)
        adapter.Fill(table)
        gridview.DataSource = table
        closeConnection()
    End Sub


    Sub addDataSuggestionWhileSearchingAt(tableName As String, query As String, val As BunifuTextBox) Implements Search.addDataSuggestionWhileSearchingAt
        val.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        val.AutoCompleteSource = AutoCompleteSource.CustomSource
        Dim autoFill As AutoCompleteStringCollection = New AutoCompleteStringCollection
        Dim command As New MySqlCommand(query, getConnection)
        Dim reader As MySqlDataReader

        openConnection()
        reader = command.ExecuteReader
        While reader.Read
            autoFill.Add(reader.GetString(tableName))
        End While
        val.AutoCompleteCustomSource = autoFill
        closeConnection()
    End Sub


End Class
