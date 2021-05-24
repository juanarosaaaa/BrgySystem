Imports MySql.Data.MySqlClient
Imports Guna.UI.WinForms
Imports Guna.UI2.WinForms
Public Class ManageSystem
    Implements loadGridViewValue, DataManipulation

    Public Function manipulateDataAt(query As String) As Boolean Implements DataManipulation.manipulateDataAt
        openConnection()
        Return New MySqlCommand(query, ConnectionDB.getConnection).ExecuteNonQuery
    End Function


    Public Sub loadGridViewValueOf(allValuesQuery As String, gridView As Guna2DataGridView) Implements loadGridViewValue.loadGridViewValueOf
        openConnection()
        Dim table As New DataTable
        Dim adapter As New MySqlDataAdapter(allValuesQuery, getConnection)
        adapter.Fill(table)
        gridView.DataSource = table
        closeConnection()
    End Sub






End Class
