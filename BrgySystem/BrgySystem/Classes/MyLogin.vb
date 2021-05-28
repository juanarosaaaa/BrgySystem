Imports MySql.Data.MySqlClient

Public Class MyLogin

    Sub authenticateLogin(form As Object, userName As String, password As String)

        If (IsUserNameAndPasswordCorrect(userName, password)) Then
            My.Settings.UserNotLoggedOut = True
            MainForm.Show()
            form.Close()

        Else
            MessageBox.Show("Username or Password is Incorrect.", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Function IsUserNameAndPasswordCorrect(userName As String, password As String) As Boolean
        Dim datatable As New DataTable

        Dim adapter As New MySqlDataAdapter("SELECT `Username`, `Password` FROM `login` where Username = '" & userName & "' and Password = '" & password & "'", ConnectionDB.getConnection)
        adapter.Fill(datatable)
        Return datatable.Rows.Count
        closeConnection()
    End Function
End Class
