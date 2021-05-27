Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms
Imports Bunifu.UI.WinForms
Public Class SearchingFeature_Implementation

    Implements Search
    Sub searchValueIn(query As String, gridview As Guna2DataGridView) Implements Search.searchValueIn
        openConnection()
        Dim table As New DataTable
        Dim adapter As New MySqlDataAdapter(query, getConnection)
        adapter.Fill(table)
        gridview.DataSource = table

        closeConnection()
    End Sub


    Sub addAndRefresh_DataSuggestion_WhileSearchingAt(columnName As String, tableName As String, searchField As BunifuTextBox) Implements Search.addAndRefresh_DataSuggestion_WhileSearchingAt

        searchField.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        searchField.AutoCompleteSource = AutoCompleteSource.CustomSource
        Dim autoFill As AutoCompleteStringCollection = New AutoCompleteStringCollection
        Dim command As New MySqlCommand("SELECT " & columnName & " from " & tableName & " where " & columnName & " like '%" & searchField.Text & "%'", getConnection)
        Dim reader As MySqlDataReader

        openConnection()
        reader = command.ExecuteReader
        While reader.Read
            autoFill.Add(reader.GetString(columnName))
        End While
        searchField.AutoCompleteCustomSource = autoFill
        reader.Close()
        closeConnection()
    End Sub


End Class
