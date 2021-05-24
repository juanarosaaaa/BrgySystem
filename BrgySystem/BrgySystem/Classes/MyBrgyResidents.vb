Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms
Imports Bunifu.UI.WinForms
Imports System.IO


Public Class MyBrgyResidents




    Private manage As DataManipulation = New ManageSystem
    Private Const residentsQuery As String = "SELECT FULLNAME,SEX,AGE,CIVIL_STATUS,OCCUPATION,REGISTERED_VOTER,ADDRESS FROM `residents`"

    Private imgname, imgpath As String






    Function getInsertQuery(imagename As String, imagepath As String) As String


        Dim age As String = Date.Now.Year - MyResidents.BirthdateDatePicker.Value.Year

        Return "INSERT INTO `residents` Values ('" & MyResidents.Fullnametxtbox.Text.Trim & "',
                                                '" & MyResidents.SuffixComboBox.Text & "',
                                                '" & MyResidents.SexComboBox.Text & "',
                                                '" & MyResidents.BirthdateDatePicker.Value.Date & "',
                                                '" & age & "','" & MyResidents.OccupationTextBox.Text & "',
                                                '" & MyResidents.ReligionTextBOx.Text & "',
                                                '" & MyResidents.HighestEducationAttainmentTextBox.Text & "',
                                                '" & MyResidents.PurokTextBox.Text & "',
                                                '" & MyResidents.AddressTextBox.Text & "',
                                                '" & MyResidents.CivilStatusComboBox.Text & "',
                                                '" & MyResidents.VoterComboBox.Text & "',
                                                '" & MyResidents.ContactTextBox.Text & "',
                                                '" & MyResidents.CitizenshipTextBox.Text & "',
                                                '" & imagePathManager.getImagePath(imagepath) & "',
                                                '" & imagename & "',
                                                '" & MyResidents.SeniorComboBox.Text & "')"
    End Function




    Function getUpdateQuery(fullnameFromSelectedRow As String, imagename As String, imagepath As String) As String
        Dim age As String = Date.Now.Year - MyResidents.BirthdateDatePicker.Value.Year

        Return " UPDATE `residents` Set `FULLNAME`= '" & MyResidents.Fullnametxtbox.Text.Trim & "',         
                                        `SUFFIX`= '" & MyResidents.SuffixComboBox.Text & "',
                                        `SEX`= '" & MyResidents.SexComboBox.Text & "',
                                        `BIRTHDATE`= '" & MyResidents.BirthdateDatePicker.Value.Date & "' ,
                                        `AGE`= '" & age & "',
                                        `OCCUPATION`='" & MyResidents.OccupationTextBox.Text & "' ,
                                        `RELIGION`= '" & MyResidents.ReligionTextBOx.Text & "',
                                        `Educational Attainment`='" & MyResidents.HighestEducationAttainmentTextBox.Text & "',
                                        `PUROK`= '" & MyResidents.PurokTextBox.Text & "',
                                        `ADDRESS`= '" & MyResidents.AddressTextBox.Text & "',
                                        `CIVIL_STATUS`= '" & MyResidents.CivilStatusComboBox.Text & "',
                                        `REGISTERED_VOTER`= '" & MyResidents.VoterComboBox.Text & "',
                                        `CONTACT_NUMBER`='" & MyResidents.ContactTextBox.Text & "',
                                        `CITIZENSHIP`= '" & MyResidents.CitizenshipTextBox.Text & "' ,
                                        `IMAGEPATH`= '" & imagePathManager.getImagePath(imagepath) & "',
                                        `ImageName`= '" & imagename & "',
                                        `SeniorCitizen`= '" & MyResidents.SeniorComboBox.Text & "' 
                                         WHERE `FULLNAME` = '" & fullnameFromSelectedRow & "' "
    End Function


    Sub deleteResidents(resident As String)

        If (MessageBox.Show("Are you sure you want to delete '" & resident.ToUpper.Trim & "' Resident?", "Are you sure you want to delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            If (manage.manipulateDataAt("DELETE FROM `residents` WHERE FULLNAME = '" & resident.Trim & "' ")) Then
                MessageBox.Show("Resident '" & resident.ToUpper.Trim & "' was successfully deleted! ", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Failed to delete Resident!", "FAILED!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        closeConnection()
    End Sub




    Sub archiveResidents(resident As String)
        Dim query As String = "INSERT INTO archive_residents SELECT * from `residents` where Fullname = '" & resident & "';
                            DELETE FROM `residents` WHERE Fullname = '" & resident & "';"

        Try
            If (MessageBox.Show("Are you sure you want to archive '" & resident.ToUpper.Trim & "' Resident?", "Are you sure you want to archive?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                If (manage.manipulateDataAt(query)) Then
                    MessageBox.Show("Resident '" & resident.ToUpper.Trim & "' was archived successfully! ", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Failed to archive Resident!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch duplicate As MySqlException

            Dim residentName_IfImageExist As String = isInputAlreadyExistAtAnotherTable("FULLNAME", "archive_residents", "residents", "residents.ImageName", "archive_residents.ImageName")
            Dim residentName_IfContactExist As String = isInputAlreadyExistAtAnotherTable("FULLNAME", "archive_residents", "residents", "residents.CONTACT_NUMBER", "archive_residents.CONTACT_NUMBER")

            If residentName_IfImageExist.Length > 0 Then
                MessageBox.Show("Failed archiving Resident. Resident '" & residentName_IfImageExist & "' from archive is already used this image.", "IMAGE ALREADY USED!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf residentName_IfContactExist.Length > 0 Then
                MessageBox.Show("Failed archiving Resident. Resident '" & residentName_IfContactExist & "' from archive is already used this contact number.", "CONTACT NUMBER ALREADY USED!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Failed archiving Resident. Resident '" & resident.ToUpper.Trim & "' already exist at the archive list.", "NAME ALREADY EXIST!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Finally
            closeConnection()

        End Try
    End Sub

    Sub arrangeGridView(gridView As Guna2DataGridView)
        gridView.Columns("fullname_Column").DataPropertyName = "FULLNAME"
        gridView.Columns("sex_Column").DataPropertyName = "SEX"
        gridView.Columns("age_Column").DataPropertyName = "AGE"
        gridView.Columns("civilStatus_Column").DataPropertyName = "CIVIL_STATUS"
        gridView.Columns("occupation_Column").DataPropertyName = "OCCUPATION"
        gridView.Columns("voter_Column").DataPropertyName = "REGISTERED_VOTER"
        gridView.Columns("address_Column").DataPropertyName = "ADDRESS"
    End Sub

    Sub clearAllInputs()
        MyResidents.Fullnametxtbox.Clear()
        MyResidents.SuffixComboBox.SelectedIndex = -1
        MyResidents.CitizenshipTextBox.Clear()
        MyResidents.AddressTextBox.Clear()
        MyResidents.ReligionTextBOx.Clear()
        MyResidents.HighestEducationAttainmentTextBox.Clear()
        MyResidents.ContactTextBox.Clear()
        MyResidents.OccupationTextBox.Clear()
        MyResidents.PurokTextBox.Clear()
        MyResidents.BirthdateDatePicker.Value = Date.Now
        MyResidents.CivilStatusComboBox.SelectedIndex = -1
        MyResidents.ResidentsPictureBOx.Image = MyResidents.ResidentsPictureBOx.InitialImage


        MyResidents.SexComboBox.SelectedIndex = -1
        MyResidents.VoterComboBox.SelectedIndex = -1
        MyResidents.SeniorComboBox.SelectedIndex = -1

        MyResidents.isFullNameModified = False
        MyResidents.isContactModified = False


    End Sub



    Function addOrUpdateResident(message As String, query As String, imageName As String) As Boolean

        Try
            If (IsInputInValid()) Then
                Return False
                Exit Function
            ElseIf InputContainsLetter(MyResidents.ContactTextBox.Text) Then
                MessageBox.Show("Contact Number must not contains letter.", "INVALID INPUT!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            ElseIf isDateOrBirthdayInvalid(MyResidents.BirthdateDatePicker) Then
                MessageBox.Show("Birthdate is invalid.", "INVALID INPUT!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            ElseIf (Not isInputAlreadyExist("PurokName", "Purok", MyResidents.PurokTextBox.Text.Trim)) Then
                MessageBox.Show("Purok '" & MyResidents.PurokTextBox.Text.Trim.ToUpper & "' does not exist in Purok list.", "INVALID INPUT!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            ElseIf (manage.manipulateDataAt(query)) Then
                MessageBox.Show(message, "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                clearAllInputs()
                Return True
            Else
                MessageBox.Show("An error occured. Failed to add/update Resident.", "FAILED!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        Catch duplicate As MySqlException

            If (isInputAlreadyExist("FULLNAME", "residents", MyResidents.Fullnametxtbox.Text.Trim) And MyResidents.isFullNameModified) Then
                MessageBox.Show("Name '" & MyResidents.Fullnametxtbox.Text.Trim.ToUpper & "' is already exist.", "INVALID FULL NAME!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False

            ElseIf (isInputAlreadyExist("CONTACT_NUMBER", "residents", MyResidents.ContactTextBox.Text.Trim) And MyResidents.isContactModified) Then
                MessageBox.Show("Contact is already used.", "INVALID CONTACT!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False

            Else isInputAlreadyExist("ImageName", "residents", imageName)
                MessageBox.Show("Image is already used.", "INVALID IMAGE!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False

            End If

        Finally
            closeConnection()
        End Try


        Return False
    End Function


    Function getResidentsQueryForSelectedColumns() As String
        Return residentsQuery
    End Function

    Function IsInputInValid()


        Dim arr() As Object = {MyResidents.Fullnametxtbox,
                               MyResidents.SuffixComboBox,
                               MyResidents.CitizenshipTextBox,
                               MyResidents.AddressTextBox,
                               MyResidents.ReligionTextBOx,
                               MyResidents.HighestEducationAttainmentTextBox,
                               MyResidents.ContactTextBox,
                               MyResidents.OccupationTextBox,
                               MyResidents.PurokTextBox,
                               MyResidents.CivilStatusComboBox,
                               MyResidents.SexComboBox,
                               MyResidents.VoterComboBox,
                               MyResidents.SeniorComboBox}

        For Each inputObjects As Object In arr


            If (InputIsNull(inputObjects.Text)) Then
                MessageBox.Show("Please enter your " & inputObjects.AccessibleName & ".", "INCOMPLETE DETAILS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return True
                Exit For
                Exit Function
            ElseIf (InputContainsSpecialCharacter(inputObjects.Text)) Then
                MessageBox.Show("Input is invalid. Your '" & inputObjects.AccessibleName & "' field contains special characters ^&*()-+=|{}':;.", "INVALID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return True
                Exit For
                Exit Function
            End If

            If inputObjects.Equals(MyResidents.ContactTextBox) Or inputObjects.Equals(MyResidents.AddressTextBox) Or inputObjects.Equals(MyResidents.PurokTextBox) Then
                Continue For
            ElseIf InputContainsNumber(inputObjects.Text) Then
                MessageBox.Show("Input is invalid! Your " & inputObjects.AccessibleName & " contains number.", "INVALID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return True
                Exit For
                Exit Function

            End If


        Next

        Return False
    End Function




    Sub getValuesFromDatabaseAndDisplayToInputs(nameOfTheSelectedRow As String)

        openConnection()
        Dim command As New MySqlCommand("SELECT * from residents where Fullname = '" & nameOfTheSelectedRow & "' ", getConnection)
        Dim reader As MySqlDataReader
        reader = command.ExecuteReader
        Try


            While reader.Read
                MyResidents.Fullnametxtbox.Text = reader.GetString("FULLNAME")
                MyResidents.SuffixComboBox.Text = reader.GetString("SUFFIX")
                MyResidents.CitizenshipTextBox.Text = reader.GetString("CITIZENSHIP")
                MyResidents.AddressTextBox.Text = reader.GetString("ADDRESS")
                MyResidents.ReligionTextBOx.Text = reader.GetString("RELIGION")
                MyResidents.HighestEducationAttainmentTextBox.Text = reader.GetString("Educational Attainment")
                MyResidents.ContactTextBox.Text = reader.GetString("CONTACT_NUMBER")
                MyResidents.OccupationTextBox.Text = reader.GetString("OCCUPATION")
                MyResidents.PurokTextBox.Text = reader.GetString("PUROK")
                MyResidents.BirthdateDatePicker.Value = reader.GetString("BIRTHDATE")
                MyResidents.CivilStatusComboBox.Text = reader.GetString("CIVIL_STATUS")
                MyResidents.SexComboBox.Text = reader.GetString("SEX")
                MyResidents.VoterComboBox.Text = reader.GetString("REGISTERED_VOTER")
                MyResidents.SeniorComboBox.Text = reader.GetString("SeniorCitizen")

                imgname = reader.GetString("ImageName")
                imgpath = reader.GetString("ImagePath")

                MyResidents.ResidentsPictureBOx.Image = Image.FromFile(reader.GetString("Imagepath"))
            End While
        Catch x As FileNotFoundException
            MessageBox.Show("Picture for Resident '" & reader.GetString("FULLNAME").ToUpper & "' not found. File might have been moved or deleted.", "IMAGE NOT FOUND!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            closeConnection()
        End Try


    End Sub

    Function getImageNameFromSelectedRowValue()
        Return imgname
    End Function

    Function getImagePathFromSelectedRowValue()
        Return imgpath
    End Function
End Class
