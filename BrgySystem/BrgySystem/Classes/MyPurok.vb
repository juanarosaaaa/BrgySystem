Imports MySql.Data.MySqlClient

Public Class MyPurok

    Private nameOfPurok As String

    Function getPurokName() As String
        Return Me.nameOfPurok
    End Function
    Sub setPurokName(purokName As String)
        Me.nameOfPurok = purokName
    End Sub

    Sub addNew(txtbox As Bunifu.UI.WinForms.BunifuTextBox)
        Try



            If (InputIsNull(txtbox.Text.Trim) Or ContainsSpecialChars(txtbox.Text.Trim)) Then
                Throw New NoNullAllowedException
            ElseIf (addPurok(txtbox.Text)) Then
                MessageBox.Show("Purok '" & txtbox.Text.Trim.ToUpper & "' successfully added!", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        Catch duplicate As MySqlException
            MessageBox.Show("Purok '" & txtbox.Text.Trim.ToUpper & "' already exist!", "FAILED TO ADD!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch nullValues As NoNullAllowedException
            MessageBox.Show("Input is invalid! An input must not leave empty or contain special characters \/:*?`<>| ", "FAILED TO ADD!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Function addPurok(value As String) As Boolean
        Dim command As MySqlCommand
        command = New MySqlCommand("INSERT INTO `purok` VALUES ('" & value & "')", ConnectionDB.getConnection)
        Return command.ExecuteNonQuery
    End Function


    Sub loadPurok(gridView As Guna.UI2.WinForms.Guna2DataGridView)

        Dim reader As MySqlDataReader
        gridView.Rows.Clear()
        Dim command As New MySqlCommand("SELECT * FROM `Purok`", ConnectionDB.getConnection)
        reader = command.ExecuteReader
        While reader.Read

            gridView.Rows.Add(reader.Item("PurokName").ToString)
        End While
        reader.Close()


    End Sub
    Sub updatePurok()
        Dim command As New MySqlCommand("UPDATE `purok` SET `PurokName`= 'douglas' WHERE `PurokName` = 'lizano'", ConnectionDB.getConnection)
    End Sub





End Class
