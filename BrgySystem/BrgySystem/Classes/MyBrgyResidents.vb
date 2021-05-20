Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms
Imports Bunifu.UI.WinForms
Public Class MyBrgyResidents


    Private manage As DataManipulation = New ManageSystem
    Private Const residentsQuery As String = "SELECT FULLNAME,SEX,AGE,CIVIL_STATUS,OCCUPATION,REGISTERED_VOTER,ADDRESS FROM `residents`"
    Private result As Boolean
    Dim fullname As String


    Function insertQuery(imagename As String, imagepath As String) As String
        fullname = "" & MyResidents.LastNameTextBox.Text + MyResidents.MiddleNameTextBox.Text + MyResidents.FirstNameTextBox.Text & ""


        Dim age As String = Date.Now.Year - MyResidents.BirthdateDatePicker.Value.Year

        Return "INSERT INTO `residents` Values ('" & fullname & "','" & MyResidents.SuffixComboBox.Text & "','" & MyResidents.SexComboBox.Text & "',
                '" & MyResidents.BirthdateDatePicker.Value.Date & "','" & age & "','" & MyResidents.OccupationTextBox.Text & "','" & MyResidents.ReligionTextBOx.Text & "','" & MyResidents.HighestEducationAttainmentTextBox.Text & "',
                '" & MyResidents.PurokTextBox.Text & "','" & MyResidents.AddressTextBox.Text & "','" & MyResidents.CivilStatusComboBox.Text & "','" & MyResidents.VoterComboBox.Text & "','" & MyResidents.ContactTextBox.Text & "','" & MyResidents.CitizenshipTextBox.Text & "','" & imagepath & "','" & imagename & "',
                '" & MyResidents.SeniorComboBox.Text & "')"
    End Function


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
        MyResidents.LastNameTextBox.Clear()
        MyResidents.MiddleNameTextBox.Clear()
        MyResidents.FirstNameTextBox.Clear()
        MyResidents.SuffixComboBox.Text = ""
        MyResidents.CitizenshipTextBox.Clear()
        MyResidents.AddressTextBox.Clear()
        MyResidents.ReligionTextBOx.Clear()
        MyResidents.HighestEducationAttainmentTextBox.Clear()
        MyResidents.ContactTextBox.Clear()
        MyResidents.OccupationTextBox.Clear()
        MyResidents.PurokTextBox.Clear()
        MyResidents.BirthdateDatePicker.Value = Date.Now
        MyResidents.CivilStatusComboBox.Text = ""
        MyResidents.ResidentsPictureBOx.Image = MyResidents.ResidentsPictureBOx.InitialImage
        MyResidents.SexComboBox.Text = ""
        MyResidents.VoterComboBox.Text = ""
        MyResidents.SeniorComboBox.Text = ""
    End Sub



    Sub addResidents(imageName As String, imagePath As String)
        Try
            If (IsInputValid()) Then
                Exit Sub
            ElseIf InputContainsLetter(MyResidents.ContactTextBox.Text) Then
                MessageBox.Show("Contact Number must not contains letter.", "INVALID INPUT!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            ElseIf isDateOrBirthdayInvalid(MyResidents.BirthdateDatePicker) Then
                MessageBox.Show("Birthdate is invalid.", "INVALID INPUT!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            ElseIf (manage.manipulateDataAt(insertQuery(imageName, imagePath))) Then
                MessageBox.Show("Resident successfully added!", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch x As MySqlException
            If isInputAlreadyExist("FULLNAME", "residents", fullname) Then
                MessageBox.Show("Name '" & fullname.Trim.ToUpper & "' already exist.", "INVALID FULL NAME!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            ElseIf isInputAlreadyExist("CONTACT_NUMBER ", "residents", MyResidents.ContactTextBox.Text.Trim) Then
                MessageBox.Show("Contact already used.", "INVALID CONTACT!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            ElseIf isInputAlreadyExist("ImageName  ", "residents", imageName) Then
                MessageBox.Show("Image already used.", "INVALID IMAGE!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                clearAllInputs()
                Exit Sub

            End If
        Finally
            closeConnection()
        End Try

    End Sub


    Function getResidentsQueryForSelectedColumns() As String
        Return residentsQuery
    End Function

    Function IsInputValid()
        result = False

        Dim arr() As Object = {MyResidents.LastNameTextBox, MyResidents.MiddleNameTextBox, MyResidents.FirstNameTextBox, MyResidents.SuffixComboBox, MyResidents.CitizenshipTextBox, MyResidents.AddressTextBox,
        MyResidents.ReligionTextBOx, MyResidents.HighestEducationAttainmentTextBox, MyResidents.ContactTextBox, MyResidents.OccupationTextBox, MyResidents.PurokTextBox, MyResidents.CivilStatusComboBox, MyResidents.SexComboBox, MyResidents.VoterComboBox, MyResidents.SeniorComboBox}

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

            If inputObjects.Equals(MyResidents.ContactTextBox) Or inputObjects.Equals(MyResidents.AddressTextBox) Or inputObjects.Equals(MyResidents.PurokTextBox) Then
                Continue For
            ElseIf InputContainsNumber(inputObjects.Text) Then
                MessageBox.Show("Input is invalid! Your " & inputObjects.AccessibleName & " contains number.", "INCOMPLETE DETAILS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return True
                Exit For
                Exit Function

            End If


        Next

        Return result
    End Function


<<<<<<< HEAD
    Sub getValuesFromDatabaseAndDisplayToInputs(name As String)

        Dim command As New MySqlCommand("SELECT * FROM `residents` WHERE FULLNAME = 'Mikocabaljasmin' ")
        Dim reader As MySqlDataReader

        openConnection()
        reader = command.ExecuteReader
        While reader.Read
            MyResidents.FullNameTxtBox.Text = reader.GetString("FULLNAME ")
            MyResidents.SuffixComboBox.Text = reader.GetString("SUFFIX ")
            MyResidents.CitizenshipTextBox.Text = reader.GetString("CITIZENSHIP")
            MyResidents.AddressTextBox.Text = reader.GetString("ADDRESS")
            MyResidents.ReligionTextBOx.Text = reader.GetString("RELIGION")
            MyResidents.HighestEducationAttainmentTextBox.Text = reader.GetString("Educational Attainment")
            MyResidents.ContactTextBox.Text = reader.GetString("CONTACT_NUMBER")
            MyResidents.OccupationTextBox.Text = reader.GetString("OCCUPATION")
            MyResidents.PurokTextBox.Text = reader.GetString("PUROK")
            MyResidents.BirthdateDatePicker.Value = reader.GetMySqlDateTime("BIRTHDATE")
            MyResidents.CivilStatusComboBox.Text = reader.GetString("CIVIL_STATUS")
            MyResidents.ResidentsPictureBOx.Image = Image.FromFile(reader.GetString("IMAGEPATH"))
            MyResidents.SexComboBox.Text = reader.GetString("SEX ")
            MyResidents.VoterComboBox.Text = reader.GetString("REGISTERED_VOTER")
            MyResidents.SeniorComboBox.Text = reader.GetString("SeniorCitizen")
        End While
        closeConnection()

    End Sub

=======
>>>>>>> parent of 3da7177 (Fix bug in imagepath when inserting imagepath to DB mysql  ignores backslashes, and adding fullname txtbox to residents)
    'check if datapicker is date.now then error
    'check if image is null
    'check if contact contains letter

End Class
