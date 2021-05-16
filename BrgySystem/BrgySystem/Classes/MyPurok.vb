Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms
Imports Bunifu.UI.WinForms
Public Class MyPurok
    Private purok_name As String




    Sub addNewPurok(txtbox As BunifuTextBox)
        Try
            purok_name = txtbox.Text


            If (InputIsNull(purok_name.Trim) Or ContainsSpecialChars(purok_name.Trim)) Then
                Throw New NoNullAllowedException
            ElseIf (insertValue()) Then
                MessageBox.Show("Purok '" & purok_name.Trim.ToUpper & "' successfully added!", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        Catch duplicate As MySqlException
            MessageBox.Show("Purok '" & purok_name.Trim.ToUpper & "' already exist!", "FAILED TO ADD!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch nullValues As NoNullAllowedException
            MessageBox.Show("Input is invalid! An input must not leave empty or contain special characters \/:*?`<>| ", "FAILED TO ADD!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            closeConnection()
        End Try

    End Sub




    Sub loadPurokGridView(_gridView As Guna2DataGridView)
        openConnection()
        _gridView.Rows.Clear()
        Dim reader As MySqlDataReader
        Dim command As New MySqlCommand("SELECT * FROM `Purok`", ConnectionDB.getConnection)
        reader = command.ExecuteReader
        While (reader.Read)
            _gridView.Rows.Add(reader.Item("PurokName").ToString)
        End While

        reader.Close()
        closeConnection()
    End Sub

    Sub updatePurokTo(txtbox As BunifuTextBox)
        purok_name = txtbox.Text
        Try
            If (InputIsNull(purok_name.Trim) Or ContainsSpecialChars(purok_name.Trim)) Then
                Throw New NoNullAllowedException
            ElseIf (updateValue()) Then
                MessageBox.Show("Purok '" & Purok.PurokGridView.SelectedCells(0).Value.ToString.ToUpper & "' successfully updated to '" & purok_name.ToUpper & "' ", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        Catch duplicate As MySqlException
            MessageBox.Show("Purok '" & purok_name.Trim.ToUpper & "' already exist!", "FAILED TO ADD!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch nullValues As NoNullAllowedException
            MessageBox.Show("Input is invalid! An input must not leave empty or contain special characters \/:*?`<>| ", "FAILED TO ADD!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            closeConnection()
        End Try

    End Sub

    Sub deletePurok(name As String)
        purok_name = name
        If (deleteValue() And MessageBox.Show("Are you sure you want to delete '" & purok_name.ToUpper.Trim & "' Purok?", "Are you sure you want to delete?", MessageBoxButtons.OK, MessageBoxIcon.Question) = DialogResult.OK) Then
            MessageBox.Show("Purok '" & purok_name.ToUpper.Trim & "' was successfully deleted! ", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        closeConnection()
    End Sub







    Private Function insertValue() As Boolean
        openConnection()
        Return New MySqlCommand("INSERT INTO `purok` VALUES ('" & purok_name.Trim & "')", ConnectionDB.getConnection).ExecuteNonQuery

    End Function

    Private Function updateValue() As Boolean
        openConnection()
        Return New MySqlCommand("UPDATE `purok` SET PurokName = '" & purok_name.Trim & "' WHERE PurokName = '" & Purok.PurokGridView.SelectedCells(0).Value.ToString & "' ", ConnectionDB.getConnection).ExecuteNonQuery

    End Function

    Private Function deleteValue() As Boolean
        openConnection()
        Return New MySqlCommand("DELETE FROM `purok` WHERE PurokName = '" & purok_name.Trim & "' ", ConnectionDB.getConnection).ExecuteNonQuery
    End Function



End Class
