Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms
Imports Bunifu.UI.WinForms
Public Class MyPurok
    Private purok_name As String
    Private manage As ManageSystem = New ManageSystem

    Sub addNewPurok(name As String)
        Try
            purok_name = name

            If (InputIsNull(purok_name.Trim) Or ContainsSpecialChars(purok_name.Trim)) Then
                Throw New NoNullAllowedException
            ElseIf (manage.insertValue("INSERT INTO `purok` VALUES ('" & purok_name.Trim & "')")) Then
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


    Sub loadPurok(_gridVIew As Guna2DataGridView)
        openConnection()
        Dim table As New DataTable
        Dim adapter As New MySqlDataAdapter("SELECT * FROM `Purok`", getConnection)


        adapter.Fill(table)
        _gridVIew.DataSource = table

        closeConnection()
    End Sub


    Sub updatePurokTo(name As String)
        purok_name = name
        Try
            If (InputIsNull(purok_name.Trim) Or ContainsSpecialChars(purok_name.Trim)) Then
                Throw New NoNullAllowedException
            ElseIf (manage.updatevalue("UPDATE `purok` SET PurokName = '" & purok_name.Trim & "' WHERE PurokName = '" & Purok.PurokGridView.CurrentRow.Cells("purok_Column").FormattedValue & "' ")) Then
                MessageBox.Show("Purok '" & Purok.PurokGridView.CurrentRow.Cells("purok_Column").FormattedValue.ToString.ToUpper & "' successfully updated to '" & purok_name.ToUpper & "' ", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        If (manage.deletevalue("DELETE FROM `purok` WHERE PurokName = '" & purok_name.Trim & "' ") And MessageBox.Show("Are you sure you want to delete '" & purok_name.ToUpper.Trim & "' Purok?", "Are you sure you want to delete?", MessageBoxButtons.OK, MessageBoxIcon.Question) = DialogResult.OK) Then
            MessageBox.Show("Purok '" & purok_name.ToUpper.Trim & "' was successfully deleted! ", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        closeConnection()
    End Sub

    Sub archivePurok(name As String)

    End Sub
End Class
