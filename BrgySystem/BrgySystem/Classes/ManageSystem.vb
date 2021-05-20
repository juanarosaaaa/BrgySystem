Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms
Public Class ManageSystem
    Implements loadGridViewValue, DataManipulation

    Public Function manipulateDataAt(query As String) As Boolean Implements DataManipulation.manipulateDataAt
        open_Connection()
        Return New MySqlCommand(query, ConnectionDB.getConnection).ExecuteNonQuery
        close_Connection()
    End Function


    Public Sub loadGridViewValueOf(query As String, gridView As Guna2DataGridView) Implements loadGridViewValue.loadGridViewValueOf
        open_Connection()
        Dim table As New DataTable
        Dim adapter As New MySqlDataAdapter(query, getConnection)
        adapter.Fill(table)
        gridView.DataSource = table
        close_Connection()
    End Sub






End Class
