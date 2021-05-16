Imports MySql.Data.MySqlClient
Public Class Login


    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openConnection()
        checkConnectionConnectivityInForm(Me)

        If (My.Settings.UserNotLoggedOut) Then
            MainForm.Show()
            Me.Close()
            closeConnection()
        End If


    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim login As BarangayAccount = New MyLogin
        login.authenticateLogin(Me, userNameTextBox.Text.Trim, passwordTextBox.Text.Trim)
    End Sub
End Class