Imports MySql.Data.MySqlClient
Module ConnectionDB

    Enum ConnectionState
        NotWorking
        Working
    End Enum


    Private myconnection As MySqlConnection = New MySqlConnection("server=localhost;user id=root;database=barangay_system")


    Private stateOfConnection As ConnectionState

    Public Sub open_Connection()
        Try
            myconnection.Open()
            stateOfConnection = ConnectionState.Working
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show("An error occured, please check the connection of your Database", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            stateOfConnection = ConnectionState.NotWorking
        End Try
    End Sub
    Public Sub close_Connection()
        myconnection.Close()
    End Sub

    Public Function getConnectionState() As ConnectionState
        Return stateOfConnection
    End Function


    Sub checkConnectionConnectivityInForm(varForm As Form)
        If getConnectionState() = ConnectionState.NotWorking Then
            varForm.Dispose()
            Application.Exit()
            close_Connection()
        End If
    End Sub

    Public Function getConnection() As MySqlConnection
        Return myconnection
    End Function



End Module
