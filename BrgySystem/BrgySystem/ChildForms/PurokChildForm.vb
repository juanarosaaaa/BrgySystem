Imports MySql.Data.MySqlClient
Public Class PurokChildForm
    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        openConnection()
        Dim command As New MySqlCommand("INSERT INTO `purok` VALUES ('" & PurokNameTextBox.Text & "')", ConnectionDB.getConnection)

        If (command.ExecuteNonQuery > 0) Then
            MessageBox.Show("Purok '" & PurokNameTextBox.Text.Trim.ToUpper & "' successfully added!", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            closeConnection()
        End If


    End Sub
End Class