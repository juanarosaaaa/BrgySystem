Imports MySql.Data.MySqlClient
Public Class MyArchive
    Inherits MyPurok
    Private manipulate As DataManipulation = New ManageSystem

    Sub restorePurok(nameToRestore As String)
        Dim query As String = "INSERT INTO Purok SELECT * from archive_purok where PurokName = '" & nameToRestore & "';
                            DELETE FROM archive_purok WHERE PurokName = '" & nameToRestore & "';"

        Try
            If (MessageBox.Show("Are you sure you want to restore '" & nameToRestore.ToUpper.Trim & "' Purok?", "Are you sure you want to archive?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK) Then
                If (manipulate.manipulateDataAt(query)) Then
                    MessageBox.Show("Purok '" & nameToRestore.ToUpper.Trim & "' was restored successfully! ", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("An error occured. Failed to restore '" & nameToRestore.ToUpper.Trim & "' Purok.", "FAILED!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch duplicate As MySqlException
            MessageBox.Show("Failed restoring Purok. A Purok '" & nameToRestore.ToUpper.Trim & "' already exist at the Purok list.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            closeConnection()
        End Try



    End Sub
    Overloads Sub deletePurok(name As String)

        If (MessageBox.Show("Are you sure you want to delete '" & name.ToUpper.Trim & "' Purok?", "Are you sure you want to delete?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK) Then
            If (manipulate.manipulateDataAt("DELETE FROM `archive_purok` WHERE PurokName = '" & name.Trim & "' ")) Then
                MessageBox.Show("Purok '" & name.ToUpper.Trim & "' was successfully deleted! ", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("An error occured. Failed to delete Purok'" & name & "'", "FAILED!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        closeConnection()
    End Sub








    Sub arrangePurokColumn()
        Archive.PurokGridView.Columns("purok_Column").DataPropertyName = "PurokName"
    End Sub

    Sub arrangeResidentsColumn()
        Archive.ResidentsArchiveGridView.Columns("fname_Column").DataPropertyName = "FULLNAME"
        Archive.ResidentsArchiveGridView.Columns("sex_Column").DataPropertyName = "SEX"
        Archive.ResidentsArchiveGridView.Columns("age_Column").DataPropertyName = "AGE"
        Archive.ResidentsArchiveGridView.Columns("religion_Column").DataPropertyName = "RELIGION"
        Archive.ResidentsArchiveGridView.Columns("citizenship_Column").DataPropertyName = "CITIZENSHIP"
        Archive.ResidentsArchiveGridView.Columns("address_Column").DataPropertyName = "ADDRESS"
    End Sub














    Sub restoreResidents(nameToRestore As String)
        Dim query As String = "INSERT INTO `residents` SELECT * from archive_residents where FULLNAME = '" & nameToRestore & "';
                            DELETE FROM archive_residents WHERE FULLNAME = '" & nameToRestore & "';"

        Try
            If (MessageBox.Show("Are you sure you want to restore '" & nameToRestore.ToUpper.Trim & "' Resident?", "Are you sure you want to archive?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK) Then
                If (manipulate.manipulateDataAt(query)) Then
                    MessageBox.Show("Resident '" & nameToRestore.ToUpper.Trim & "' was restored successfully! ", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("An error occured. Failed to restore '" & nameToRestore.ToUpper.Trim & "' Resident.", "FAILED!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch duplicate As MySqlException
            MessageBox.Show("Failed restoring Resident. A Resident '" & nameToRestore.ToUpper.Trim & "' already exist at the Resident's list.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            closeConnection()
        End Try

    End Sub

    Sub deleteResidents(name As String)

        If (MessageBox.Show("Are you sure you want to delete '" & name.ToUpper.Trim & "' Resident?", "Are you sure you want to delete?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK) Then
            If (manipulate.manipulateDataAt("DELETE FROM `archive_residents` WHERE FULLNAME = '" & name.Trim & "' ")) Then
                MessageBox.Show("Resident '" & name.ToUpper.Trim & "' was successfully deleted! ", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("An error occured. Failed to delete Resident '" & name & "'", "FAILED!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        closeConnection()
    End Sub












End Class
