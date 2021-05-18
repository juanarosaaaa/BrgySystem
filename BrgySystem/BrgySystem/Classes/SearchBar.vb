Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms
Public Class SearchBar

    Implements SearchValue
    Sub searchValueIn(query As String, gridview As Guna2DataGridView) Implements SearchValue.searchValueIn
        openConnection()
        Dim table As New DataTable
        Dim adapter As New MySqlDataAdapter(query, getConnection)
        adapter.Fill(table)
        gridview.DataSource = table
        closeConnection()
    End Sub

End Class
