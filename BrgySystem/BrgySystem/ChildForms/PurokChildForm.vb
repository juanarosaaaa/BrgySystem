Imports MySql.Data.MySqlClient
Public Class PurokChildForm
    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Try
            setCharacterLengthLimit(0, PurokNameTextBox.Text.Trim)
            openConnection()
            Dim command As New MySqlCommand("INSERT INTO `purok` VALUES ('" & PurokNameTextBox.Text & "')", ConnectionDB.getConnection)

            If (InputIsNull(PurokNameTextBox.Text.Trim) Or ContainsSpecialChars(PurokNameTextBox.Text.Trim)) Then
                Throw New NoNullAllowedException
                If (command.ExecuteNonQuery > 0) Then
                    MessageBox.Show("Purok '" & PurokNameTextBox.Text.Trim.ToUpper & "' successfully added!", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    closeConnection()
                End If
            End If

        Catch duplicate As MySqlException
            MessageBox.Show("Purok '" & PurokNameTextBox.Text.Trim.ToUpper & "' already exist!", "FAILED TO ADD!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch nullValues As NoNullAllowedException
            MessageBox.Show("Input is invalid! An input must not leave empty or contain special characters \/:*?`<>| ", "FAILED TO ADD!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            closeConnection()
        End Try

        'character length

    End Sub
End Class