Imports MySql.Data.MySqlClient

Public Class ManageSystem
    Implements InsertValue, DeleteValue, UpdateValue, ArchiveValue

    Public Function insertValue(query As String) As Boolean Implements InsertValue.insertValueAt
        openConnection()
        Return New MySqlCommand(query, ConnectionDB.getConnection).ExecuteNonQuery
    End Function
    Public Function deletevalue(query As String) As Boolean Implements DeleteValue.deleteValueAt
        openConnection()
        Return New MySqlCommand(query, ConnectionDB.getConnection).ExecuteNonQuery

    End Function
    Public Function updatevalue(query As String) As Boolean Implements UpdateValue.updateValueAt
        openConnection()
        Return New MySqlCommand(query, ConnectionDB.getConnection).ExecuteNonQuery
    End Function

    Public Function archiveValue(query As String) As Boolean Implements ArchiveValue.ArchiveValueAt
        openConnection()
        Return New MySqlCommand(query, ConnectionDB.getConnection).ExecuteNonQuery
    End Function
End Class
