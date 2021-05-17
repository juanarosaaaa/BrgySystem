Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms
Public Class SearchBar
    Implements SearchValue
    Sub searchValueIn(tableName As String, valueYouSearchFor As String, gridview As Guna2DataGridView) Implements SearchValue.searchValueIn
        openConnection()
        Dim table As New DataTable
        Dim adapter As New MySqlDataAdapter("SELECT * FROM `" & tableName.Trim & "` WHERE PurokName Like '%" & valueYouSearchFor.Trim & "%'", getConnection)
        adapter.Fill(table)
        gridview.DataSource = table
        closeConnection()
    End Sub

End Class
