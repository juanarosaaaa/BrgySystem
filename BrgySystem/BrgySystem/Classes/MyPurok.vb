Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms
Imports Bunifu.UI.WinForms
Public Class MyPurok
    Private Const purokQuery As String = "SELECT * FROM Purok"
    Private manage As DataManipulation = New ManageSystem

    Sub addNewPurok(name As String)
        Try


            If (InputIsNull(name.Trim) Or InputContainsSpecialCharacter(name.Trim) Or InputContainsNumber(name.Trim)) Then
                Throw New NoNullAllowedException
            ElseIf (manage.manipulateDataAt("INSERT INTO `purok` VALUES ('" & name.Trim & "')")) Then
                MessageBox.Show("Purok '" & name.Trim.ToUpper & "' successfully added!", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Failed to add new Purok!", "FAILED!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch duplicate As MySqlException
            MessageBox.Show("Purok '" & name.Trim.ToUpper & "' already exist!", "FAILED TO ADD!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch nullValues As NoNullAllowedException
            MessageBox.Show("Input is invalid! An input must not leave empty or contain special characters \/:*?`<>| ", "FAILED TO ADD!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            closeConnection()
        End Try

    End Sub

    Sub updatePurokTo(name As String)

        Try
            If (InputIsNull(name.Trim) Or InputContainsSpecialCharacter(name.Trim)) Then
                Throw New NoNullAllowedException
            ElseIf (manage.manipulateDataAt("UPDATE `purok` SET PurokName = '" & name.Trim & "' WHERE PurokName = '" & Purok.PurokGridView.CurrentRow.Cells("purok_Column").FormattedValue & "' ")) Then
                MessageBox.Show("Purok '" & Purok.PurokGridView.CurrentRow.Cells("purok_Column").FormattedValue.ToString.ToUpper & "' successfully updated to '" & name.ToUpper & "' ", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Failed to update Purok! ", "FAILED!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch duplicate As MySqlException
            MessageBox.Show("Purok '" & name.Trim.ToUpper & "' already exist!", "FAILED TO ADD!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch nullValues As NoNullAllowedException
            MessageBox.Show("Input is invalid! An input must not leave empty or contain special characters \/:*?`<>| ", "FAILED TO ADD!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            closeConnection()
        End Try

    End Sub

    Sub deletePurok(name As String)

        If (MessageBox.Show("Are you sure you want to delete '" & name.ToUpper.Trim & "' Purok?", "Are you sure you want to delete?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK) Then
            If (manage.manipulateDataAt("DELETE FROM `purok` WHERE PurokName = '" & name.Trim & "' ")) Then
                MessageBox.Show("Purok '" & name.ToUpper.Trim & "' was successfully deleted! ", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Failed to delete Purok!", "FAILED!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        closeConnection()
    End Sub

    Sub archivePurok(nameToArchive As String)

        Dim query As String = "INSERT INTO archive_purok SELECT * from purok where PurokName = '" & nameToArchive & "';
                            DELETE FROM purok WHERE PurokName = '" & nameToArchive & "';"

        Try
            If (MessageBox.Show("Are you sure you want to archive '" & nameToArchive.ToUpper.Trim & "' Purok?", "Are you sure you want to archive?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK) Then
                If (manage.manipulateDataAt(query)) Then
                    MessageBox.Show("Purok '" & nameToArchive.ToUpper.Trim & "' was archived successfully! ", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Failed to archive Purok!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch duplicate As MySqlException
            MessageBox.Show("Failed archiving Purok. A Purok '" & nameToArchive.ToUpper.Trim & "' already exist at the archive list.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            closeConnection()

        End Try


    End Sub

    Function getAllPurokQuery() As String
        Return purokQuery
    End Function

End Class
