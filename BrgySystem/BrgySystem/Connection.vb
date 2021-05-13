Imports MySql.Data.MySqlClient

Public Class Connection
    Private myconnection As MySqlConnection = New MySqlConnection("server=localhost;user id=root;database=barangay_system")
    Private resultSet As Integer
    Private command As MySqlCommand
    Private adapter As MySqlDataAdapter
    Private datatable As DataTable = New DataTable
    Public Sub openConnection()
        myconnection.Open()
    End Sub
    Public Sub closeConnection()
        myconnection.Close()
    End Sub

    Sub insertValues(query As String)
        openConnection()
        With command
            .Connection = myconnection
            .CommandText = query
            resultSet = .ExecuteNonQuery
        End With
        If (resultSet > 0) Then
            MsgBox(True)
        End If
        closeConnection()
        command.Dispose()
    End Sub

    Sub getValues(query As String)
        openConnection()
        With command
            .Connection = myconnection
            .CommandText = query
        End With
        adapter.SelectCommand = command
    End Sub
End Class
