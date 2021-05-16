Imports MySql.Data.MySqlClient

Public Class MyPurok
    Implements BarangayPurok

    Sub addNewPurok(txtbox As Bunifu.UI.WinForms.BunifuTextBox) Implements BarangayPurok.addPurok
        Try

            openConnection()
            Dim command As New MySqlCommand("INSERT INTO `purok` VALUES ('" & txtbox.Text & "')", ConnectionDB.getConnection)

            If (InputIsNull(txtbox.Text.Trim) Or ContainsSpecialChars(txtbox.Text.Trim)) Then
                Throw New NoNullAllowedException
            ElseIf (command.ExecuteNonQuery > 0) Then
                MessageBox.Show("Purok '" & txtbox.Text.Trim.ToUpper & "' successfully added!", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                closeConnection()
            End If

        Catch duplicate As MySqlException
            MessageBox.Show("Purok '" & txtbox.Text.Trim.ToUpper & "' already exist!", "FAILED TO ADD!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch nullValues As NoNullAllowedException
            MessageBox.Show("Input is invalid! An input must not leave empty or contain special characters \/:*?`<>| ", "FAILED TO ADD!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            closeConnection()
        End Try

    End Sub
End Class
