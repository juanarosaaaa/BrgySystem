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
                                                '" & imageName & "')"

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
                MessageBox.Show("An error occured. Failed to add new Officials!", "FAILED!", MessageBoxButtons.OK, MessageBoxIcon.Error)
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





    Function getOfficialsQueryValuesSelectedColumn() As String
        Return getValuesQueryOfTheSelectedColumn
    End Function

    Function IsInputValid()


        Dim arr() As Object = {Officials.FullnameTextBox,
                                Officials.ContactTextBox,
                                Officials.HighestEducationalAttainmentTextBox,
                                Officials.PurokTextBox,
                                Officials.CitizenshipTextBox}

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

            If inputObjects.Equals(Officials.ContactTextBox) Or inputObjects.Equals(Officials.PurokTextBox) Then
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

                imgname = reader.GetString("ImageName")
                imgpath = reader.GetString("ImagePath")


            End While
        Catch x As FileNotFoundException
            MessageBox.Show("Picture for Official '" & reader.GetString("NAME").ToUpper & "' not found. File might have been moved or deleted.", "IMAGE NOT FOUND!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


        closeConnection()

    End Sub

    Function getImageNameFromSelectedRowValue()
        Return imgname
    End Function

    Function getImagePathFromSelectedRowValue()
        Return imgpath
    End Function
End Class
