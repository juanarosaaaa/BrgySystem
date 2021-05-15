Imports MySql.Data.MySqlClient
Public Class Login


    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openConnection()
        checkConnectionConnectivityInForm(Me)

        If (My.Settings.UserNotLoggedOut) Then
            MainForm.Show()
            Me.Close()
        End If


    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click

        Dim command As New MySqlCommand("SELECT `Username`, `Password` FROM `login` where Username = '" & userNameTextBox.Text.Trim & "' and Password = '" & passwordTextBox.Text.Trim & "'", ConnectionDB.getConnection)


        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable

        adapter.Fill(table)
        If (table.Rows.Count > 0) Then
            My.Settings.UserNotLoggedOut = True
            MainForm.Show()
            Me.Close()
            closeConnection()
        Else
            MessageBox.Show("Username or Password is Incorrect.", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        'if user logged out then 
        ' load this form 
        ' else continue
    End Sub
End Class