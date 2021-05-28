Imports MySql.Data.MySqlClient
Public Class MyArchive
    Inherits MyPurok
    Private manipulate As DataManipulation = New ManageSystem

    Sub restorePurok(nameToRestore As String)
        Dim query As String = "INSERT INTO Purok SELECT * from archive_purok where PurokName = '" & nameToRestore & "';
                            DELETE FROM archive_purok WHERE PurokName = '" & nameToRestore & "';"

        Try
            If (MessageBox.Show("Are you sure you want to restore '" & nameToRestore.ToUpper.Trim & "' Purok?", "Are you sure you want to restore?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
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

        If (MessageBox.Show("Are you sure you want to delete '" & name.ToUpper.Trim & "' Purok?", "Are you sure you want to delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
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
        Archive.ResidentsArchiveGridView.Columns("civilStatus_Col").DataPropertyName = "CIVIL_STATUS"
        Archive.ResidentsArchiveGridView.Columns("registeredvoter_column").DataPropertyName = "REGISTERED_VOTER"
    End Sub
    Sub arrangeOfficialsColumns()
        Archive.ArchiveOfficialGridView.Columns("fullnameColumnOfficials").DataPropertyName = "NAME"
        Archive.ArchiveOfficialGridView.Columns("status_ColumnOfficials").DataPropertyName = "STATUS"
        Archive.ArchiveOfficialGridView.Columns("contact_ColumnOfficials").DataPropertyName = "CONTACT"
        Archive.ArchiveOfficialGridView.Columns("positionColumnOfficials").DataPropertyName = "POSITION"
        Archive.ArchiveOfficialGridView.Columns("termColumnOfficials").DataPropertyName = "TERM"
        Archive.ArchiveOfficialGridView.Columns("sexColumnOfficials").DataPropertyName = "SEX"
        Archive.ArchiveOfficialGridView.Columns("purokColumnOfficials").DataPropertyName = "Purok"
        Archive.ArchiveOfficialGridView.Columns("ageColumnOfficials").DataPropertyName = "AGE"

    End Sub












    Sub restoreResidents(nameToRestore As String)
        Dim query As String = "INSERT INTO `residents` SELECT * from archive_residents where FULLNAME = '" & nameToRestore & "';
                            DELETE FROM archive_residents WHERE FULLNAME = '" & nameToRestore & "';"

        Try
            If (MessageBox.Show("Are you sure you want to restore '" & nameToRestore.ToUpper.Trim & "' Resident?", "Are you sure you want to restore?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                If (manipulate.manipulateDataAt(query)) Then
                    MessageBox.Show("Resident '" & nameToRestore.ToUpper.Trim & "' was restored successfully! ", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("An error occured. Failed to restore '" & nameToRestore.ToUpper.Trim & "' Resident.", "FAILED!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

        Catch duplicate As MySqlException

            Dim residentsName_IfImageExist As String = isInputAlreadyExistAtAnotherTable("FULLNAME", "residents", "archive_residents", "archive_residents.ImageName", "residents.ImageName")
            Dim residentsName_IfContactExist As String = isInputAlreadyExistAtAnotherTable("FULLNAME", "residents", "archive_residents", "archive_residents.CONTACT_NUMBER", "residents.CONTACT_NUMBER")

            If residentsName_IfImageExist.Length > 0 Then
                MessageBox.Show("Failed restoring Resident. Resident '" & residentsName_IfImageExist & "' from Resident's list is already used this image.", "IMAGE ALREADY USED!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf residentsName_IfContactExist.Length > 0 Then
                MessageBox.Show("Failed restoring Resident. Resident '" & residentsName_IfContactExist & "' from Resident's list is already used this contact number.", "CONTACT NUMBER ALREADY USED!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Failed restoring Resident. Resident '" & nameToRestore.ToUpper.Trim & "' already exist at the Resident's list.", "NAME ALREADY USED!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Finally
            closeConnection()
        End Try

    End Sub

    Sub deleteResidents(name As String)

        If (MessageBox.Show("Are you sure you want to delete '" & name.ToUpper.Trim & "' Resident?", "Are you sure you want to delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            If (manipulate.manipulateDataAt("DELETE FROM `archive_residents` WHERE FULLNAME = '" & name.Trim & "' ")) Then
                MessageBox.Show("Resident '" & name.ToUpper.Trim & "' was successfully deleted! ", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("An error occured. Failed to delete Resident '" & name & "'", "FAILED!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        closeConnection()
    End Sub









    Sub restoreOfficials(nameToRestore As String)
        Dim query As String = "INSERT INTO `officials` SELECT * from archive_officials where NAME = '" & nameToRestore & "';
                            DELETE FROM archive_officials WHERE NAME = '" & nameToRestore & "';"




        Try
            openConnection()
            Dim officialBarangayCaptain_IfPositionExist As String = isInputAlreadyExistAtAnotherTable("Name", "officials", "archive_officials", "archive_officials.POSITION", "officials.POSITION")
            closeConnection()

            If (MessageBox.Show("Are you sure you want to restore '" & nameToRestore.ToUpper.Trim & "' Barangay Official?", "Are you sure you want to restore?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then

                If officialBarangayCaptain_IfPositionExist.Length > 0 Then
                    MessageBox.Show("Failed restoring Barangay Official. '" & officialBarangayCaptain_IfPositionExist & "' from Barangay Official's list is already assigned as Barangay Captain.", "BARANGAY POSITION IS INVALID!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf (manipulate.manipulateDataAt(query)) Then
                    MessageBox.Show("Barangay Official '" & nameToRestore.ToUpper.Trim & "' was restored successfully! ", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("An error occured. Failed to restore '" & nameToRestore.ToUpper.Trim & "' Barangay Official.", "FAILED!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End If
        Catch duplicate As MySqlException


            Dim officialName_IfImageExist As String = isInputAlreadyExistAtAnotherTable("Name", "officials", "archive_officials", "archive_officials.ImageName", "officials.ImageName")
            Dim officialName_IfContactExist As String = isInputAlreadyExistAtAnotherTable("Name", "officials", "archive_officials", "archive_officials.CONTACT", "officials.CONTACT")



            If officialName_IfImageExist.Length > 0 Then
                MessageBox.Show("Failed restoring Barangay Official. Official '" & officialName_IfImageExist & "' from Barangay Official's list is already used this image.", "IMAGE ALREADY USED!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf officialName_IfContactExist.Length > 0 Then
                MessageBox.Show("Failed restoring Barangay Official. Official '" & officialName_IfImageExist & "' from Barangay Official's list is already used this contact number.", "CONTACT NUMBER ALREADY USED!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Failed restoring Barangay Official. Official '" & nameToRestore.ToUpper.Trim & "' already exist at the Barangay Official's list.", "NAME ALREADY EXIST!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If





        Finally
            closeConnection()
        End Try

    End Sub


    Sub deleteOfficials(name As String)

        If (MessageBox.Show("Are you sure you want to delete '" & name.ToUpper.Trim & "' Barangay Official?", "Are you sure you want to delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            If (manipulate.manipulateDataAt("DELETE FROM `archive_officials` WHERE Name = '" & name.Trim & "' ")) Then
                MessageBox.Show("Barangay Official '" & name.ToUpper.Trim & "' was successfully deleted! ", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("An error occured. Failed to delete Barangay Official '" & name & "'", "FAILED!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        closeConnection()
    End Sub






End Class
