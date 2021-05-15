Imports MySql.Data.MySqlClient

Public Class MyLogin
    Implements BarangayAccount
    Sub authenticateLogin(form As Object, userName As String, password As String) Implements BarangayAccount.authenticateLogin
        Dim command As New MySqlCommand("SELECT `Username`, `Password` FROM `login` where Username = '" & userName & "' and Password = '" & password & "'", ConnectionDB.getConnection)


        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable

        adapter.Fill(table)
        If (table.Rows.Count > 0) Then
            My.Settings.UserNotLoggedOut = True
            MainForm.Show()
            form.Close()
            closeConnection()
        Else
            MessageBox.Show("Username or Password is Incorrect.", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        'if user logged out then 
        ' load this form 
        ' else continue
    End Sub
End Class
