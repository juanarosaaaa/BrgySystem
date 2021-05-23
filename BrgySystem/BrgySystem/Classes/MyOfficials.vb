Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms
Imports Bunifu.UI.WinForms
Imports System.IO



Public Class MyOfficials
    Private getValuesQueryOfTheSelectedColumn As String = "SELECT NAME,AGE,TERM,POSITION,SEX,STATUS,CONTACT FROM `officials`"
    Private manage As DataManipulation = New ManageSystem
    Private imgname, imgpath As String




    Sub arrangeGridView()
        Officials.OfficialsGridVIew.Columns("name_Column").DataPropertyName = "NAME"
        Officials.OfficialsGridVIew.Columns("age_Column").DataPropertyName = "AGE"
        Officials.OfficialsGridVIew.Columns("term_Column").DataPropertyName = "TERM"
        Officials.OfficialsGridVIew.Columns("position_Column").DataPropertyName = "POSITION"
        Officials.OfficialsGridVIew.Columns("sex_Column").DataPropertyName = "SEX"
        Officials.OfficialsGridVIew.Columns("status_Column").DataPropertyName = "STATUS"
        Officials.OfficialsGridVIew.Columns("contact_Column").DataPropertyName = "CONTACT"
    End Sub


    Function getInsertQuery(imageName As String, imagePath As String) As String

        Dim age As String = Date.Now.Year - Officials.BirthdateDatePicker.Value.Year
        Return "INSERT INTO `officials` VALUES ('" & Officials.FullnameTextBox.Text.Trim & "',
                                                '" & age & "',
                                                '" & Officials.BirthdateDatePicker.Value.Date & "',
                                                '" & Officials.SexComboBox.Text & "',
                                                '" & Officials.TermComboBox.Text & "',
                                                '" & Officials.StatusCombobox.Text & "',
                                                '" & Officials.PositionCombobox.Text & "',
                                                '" & Officials.CitizenshipTextBox.Text & "',
                                                '" & Officials.HighestEducationalAttainmentTextBox.Text & "',
                                                '" & imagePathManager.getImagePath(imagePath) & "',
                                                '" & Officials.ContactTextBox.Text & "',
                                                '" & imageName & "',
                                                '" & Officials.PurokTxtBox.Text.Trim & "',
                                                '" & Officials.AddressTextBox.Text.Trim & "')"

    End Function


    Function getUpdateQuery(nameFromSelectedRow As String, imagename As String, imagepath As String) As String

        Dim age As String = Date.Now.Year - Officials.BirthdateDatePicker.Value.Year

        Return "UPDATE `officials` SET `Name`= '" & Officials.FullnameTextBox.Text.Trim & "',
                                       `AGE`= '" & age & "',
                                       `BIRTHDATE`= '" & Officials.BirthdateDatePicker.Value.Date & "',
                                       `SEX`= '" & Officials.SexComboBox.Text & "',
                                       `TERM`= '" & Officials.TermComboBox.Text & "',
                                       `STATUS`= '" & Officials.StatusCombobox.Text & "',
                                       `POSITION`= '" & Officials.PositionCombobox.Text & "',
                                       `Citizenship`= '" & Officials.CitizenshipTextBox.Text & "',
                                       `Educational Attainment`= '" & Officials.HighestEducationalAttainmentTextBox.Text & "',
                                       `ImagePath`= '" & imagePathManager.getImagePath(imagepath) & "',
                                       `CONTACT`= '" & Officials.ContactTextBox.Text & "',
                                       `ImageName`= '" & imagename & "',
                                       `Purok`= '" & Officials.PurokTxtBox.Text.Trim & "',
                                       `Address`= '" & Officials.AddressTextBox.Text.Trim & "'
                                        WHERE NAME = '" & nameFromSelectedRow & "'; "


    End Function


    Sub clearAllInputs()

        Officials.FullnameTextBox.Clear()
        Officials.BirthdateDatePicker.Value = Date.Now
        Officials.SexComboBox.SelectedIndex = -1
        Officials.TermComboBox.SelectedIndex = -1
        Officials.StatusCombobox.SelectedIndex = -1
        Officials.PositionCombobox.SelectedIndex = -1
        Officials.CitizenshipTextBox.Clear()
        Officials.HighestEducationalAttainmentTextBox.Clear()
        Officials.OfficialsPictureBox.Image = Officials.OfficialsPictureBox.InitialImage
        Officials.ContactTextBox.Clear()
        Officials.PurokTxtBox.Clear()
        Officials.AddressTextBox.Clear()


        Officials.isNameModified = False
        Officials.isContactModified = False

    End Sub

    Function addOrUpdateOfficials(message As String, query As String, imageName As String) As Boolean
        Try
            If (IsInputValid()) Then
                Return False
                Exit Function
            ElseIf InputContainsLetter(Officials.ContactTextBox.Text) Then
                MessageBox.Show("Contact Number must not contains letter.", "INVALID INPUT!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
                Exit Function
            ElseIf isDateOrBirthdayInvalid(Officials.BirthdateDatePicker) Then
                MessageBox.Show("Birthdate is invalid.", "INVALID INPUT!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
                Exit Function
            ElseIf (manage.manipulateDataAt(query)) Then
                MessageBox.Show(message, "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                clearAllInputs()
                Return True
                Exit Function
            Else
                MessageBox.Show("An error occured. Failed to add new Barangay Officials!", "FAILED!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
                Exit Function
            End If
        Catch duplicate As MySqlException

            If (isInputAlreadyExist("Name", "officials", Officials.FullnameTextBox.Text.Trim) And Officials.isNameModified) Then
                MessageBox.Show("Name '" & Officials.FullnameTextBox.Text.Trim.ToUpper & "' is already exist.", "INVALID FULL NAME!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
                Exit Function
            ElseIf (isInputAlreadyExist("Contact", "officials", Officials.ContactTextBox.Text.Trim) And Officials.isContactModified) Then
                MessageBox.Show("Contact is already used.", "INVALID CONTACT!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
                Exit Function
            Else isInputAlreadyExist("ImageName", "officials", imageName)
                MessageBox.Show("Image is already used.", "INVALID IMAGE!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
                Exit Function
            End If

        Finally
            closeConnection()
        End Try


        Return False
    End Function

    Sub deleteOfficial(officialname As String)
        If (MessageBox.Show("Are you sure you want to delete '" & officialname.ToUpper.Trim & "' Barangay Official?", "Are you sure you want to delete?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK) Then
            If (manage.manipulateDataAt("DELETE FROM `officials` WHERE NAME = '" & officialname.Trim & "' ")) Then
                MessageBox.Show("Barangay Official '" & officialname.ToUpper.Trim & "' was successfully deleted! ", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Failed to delete Barangay Official!", "FAILED!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        closeConnection()
    End Sub

    Sub archiveOfficials(official As String)
        Dim query As String = "INSERT INTO archive_officials SELECT * from `officials` where Name = '" & official & "';
                            DELETE FROM `officials` WHERE Name = '" & official & "';"

        Try
            If (MessageBox.Show("Are you sure you want to archive '" & official.ToUpper.Trim & "' Barangay Official?", "Are you sure you want to archive?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK) Then
                If (manage.manipulateDataAt(query)) Then
                    MessageBox.Show("Barangay Official '" & official.ToUpper.Trim & "' was archived successfully! ", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Failed to archive Barangay Official!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch duplicate As MySqlException

            Dim officialName_IfImageExist As String = isInputAlreadyExistAtAnotherTable("Name", "archive_officials", "officials", "officials.ImageName", "archive_officials.ImageName")
            Dim officialName_IfContactExist As String = isInputAlreadyExistAtAnotherTable("Name", "archive_officials", "officials", "officials.CONTACT", "archive_officials.CONTACT")

            If officialName_IfImageExist.Length > 0 Then
                MessageBox.Show("Failed archiving Barangay Official. Official '" & officialName_IfImageExist & "' from archive is already used this Image.", "IMAGE ALREADY EXIST!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf officialName_IfContactExist.Length > 0 Then
                MessageBox.Show("Failed archiving Barangay Official. Official '" & officialName_IfImageExist & "' from archive is already used this Contact Number.", "IMAGE ALREADY EXIST!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Failed archiving Barangay Official. Official '" & official.ToUpper.Trim & "' already exist at the archive list.", "NAME ALREADY EXIST!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Finally
            closeConnection()

        End Try
    End Sub

    Function getOfficialsQueryValuesSelectedColumn() As String
        Return getValuesQueryOfTheSelectedColumn
    End Function

    Function IsInputValid()


        Dim arr() As Object = {Officials.FullnameTextBox,
                                Officials.ContactTextBox,
                                Officials.HighestEducationalAttainmentTextBox,
                                Officials.PurokTxtBox,
                                Officials.CitizenshipTextBox,
                                Officials.PurokTxtBox,
                                Officials.AddressTextBox}

        For Each inputObjects As Object In arr


            If (InputIsNull(inputObjects.Text)) Then
                MessageBox.Show("Please enter your " & inputObjects.AccessibleName & ".", "INCOMPLETE DETAILS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return True
                Exit For
                Exit Function
            ElseIf (InputContainsSpecialCharacter(inputObjects.Text)) Then
                MessageBox.Show("Input is invalid. Your '" & inputObjects.AccessibleName & "' field contains special characters ^&*()-+=|{}':;.", "INCOMPLETE DETAILS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return True
                Exit For
                Exit Function
            End If

            If inputObjects.Equals(Officials.ContactTextBox) Or inputObjects.Equals(Officials.PurokTxtBox) Or inputObjects.Equals(Officials.AddressTextBox) Then
                Continue For
            ElseIf InputContainsNumber(inputObjects.Text) Then
                MessageBox.Show("Input is invalid! Your " & inputObjects.AccessibleName & " contains number.", "INCOMPLETE DETAILS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return True
                Exit For
                Exit Function

            End If


        Next

        Return False
    End Function


    Sub getValuesFromDatabaseAndDisplayToInputs(nameOfTheSelectedRow As String)

        openConnection()
        Dim command As New MySqlCommand("SELECT * from officials where NAME = '" & nameOfTheSelectedRow & "' ", getConnection)
        Dim reader As MySqlDataReader
        reader = command.ExecuteReader
        Try


            While reader.Read

                Officials.FullnameTextBox.Text = reader.GetString("NAME")
                Officials.BirthdateDatePicker.Value = reader.GetString("BIRTHDATE")
                Officials.SexComboBox.Text = reader.GetString("SEX")
                Officials.TermComboBox.Text = reader.GetString("TERM")
                Officials.StatusCombobox.Text = reader.GetString("STATUS")
                Officials.PositionCombobox.Text = reader.GetString("POSITION")
                Officials.CitizenshipTextBox.Text = reader.GetString("Citizenship")
                Officials.HighestEducationalAttainmentTextBox.Text = reader.GetString("Educational Attainment")
                Officials.OfficialsPictureBox.Image = Image.FromFile(reader.GetString("ImagePath"))
                Officials.ContactTextBox.Text = reader.GetString("CONTACT")
                Officials.PurokTxtBox.Text = reader.GetString("Purok")
                Officials.AddressTextBox.Text = reader.GetString("Address")

                imgname = reader.GetString("ImageName")
                imgpath = reader.GetString("ImagePath")


            End While
        Catch x As FileNotFoundException
            MessageBox.Show("Picture for Barangay Official '" & reader.GetString("NAME").ToUpper & "' not found. File might have been moved or deleted.", "IMAGE NOT FOUND!", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
