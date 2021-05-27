Imports MySql.Data.MySqlClient
Public Class Login


    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openConnection()
        checkConnectionConnectivityInForm(Me)

        If (My.Settings.UserNotLoggedOut) Then
            closeConnection()
            MainForm.Show()
            Me.Close()
        End If


    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim login As New MyLogin
        login.authenticateLogin(Me, userNameTextBox.Text.Trim, passwordTextBox.Text.Trim)
    End Sub

    Private Sub BunifuLabel1_Click(sender As Object, e As EventArgs) Handles BunifuLabel1.Click

    End Sub



    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Application.Exit()
    End Sub
End Class