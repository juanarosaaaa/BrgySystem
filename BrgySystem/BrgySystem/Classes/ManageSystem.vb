Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms
Public Class ManageSystem
    Implements InsertValue, DeleteValue, UpdateValue, ArchiveValue, loadGridViewValue, RestoreValue

    Public Function insertValue(query As String) As Boolean Implements InsertValue.insertValueAt
        openConnection()
        Return New MySqlCommand(query, ConnectionDB.getConnection).ExecuteNonQuery
    End Function

    Public Function updatevalue(query As String) As Boolean Implements UpdateValue.updateValueAt
        openConnection()
        Return New MySqlCommand(query, ConnectionDB.getConnection).ExecuteNonQuery
    End Function

    Public Function RestoreValue(query As String) As Boolean Implements RestoreValue.RestoreValueAt
        openConnection()
        Return New MySqlCommand(query, ConnectionDB.getConnection).ExecuteNonQuery
    End Function


    Public Function archiveValue(query As String) As Boolean Implements ArchiveValue.ArchiveValueAt
        openConnection()
        Return New MySqlCommand(query, ConnectionDB.getConnection).ExecuteNonQuery
    End Function
    Public Function deletevalue(query As String) As Boolean Implements DeleteValue.deleteValueAt
        openConnection()
        Return New MySqlCommand(query, ConnectionDB.getConnection).ExecuteNonQuery

    End Function
    Public Sub loadGridViewValueAt(query As String, gridView As Guna2DataGridView) Implements loadGridViewValue.loadGridViewValueOf
        openConnection()
        Dim table As New DataTable
        Dim adapter As New MySqlDataAdapter(query, getConnection)
        adapter.Fill(table)
        gridView.DataSource = table

        closeConnection()
    End Sub






End Class
