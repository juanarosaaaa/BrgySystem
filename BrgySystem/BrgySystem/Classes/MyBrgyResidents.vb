Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms
Public Class MyBrgyResidents
    Private manage As DataManipulation = New ManageSystem
    Private Const residentsQuery As String = "SELECT FULLNAME,SEX,AGE,CIVIL_STATUS,OCCUPATION,VOTER,ADDRESS FROM `residents`"
    Sub arrangeGridView(gridView As Guna2DataGridView)
        gridView.Columns("fullname_Column").DataPropertyName = "FULLNAME"
        gridView.Columns("sex_Column").DataPropertyName = "SEX"
        gridView.Columns("age_Column").DataPropertyName = "AGE"
        gridView.Columns("civilStatus_Column").DataPropertyName = "CIVIL_STATUS"
        gridView.Columns("occupation_Column").DataPropertyName = "OCCUPATION"
        gridView.Columns("voter_Column").DataPropertyName = "VOTER"
        gridView.Columns("address_Column").DataPropertyName = "ADDRESS"
    End Sub


    'Sub addResidents()
    '    Try

    '        If (InputIsNull(name.Trim) Or ContainsSpecialChars(name.Trim)) Then
    '            Throw New NoNullAllowedException
    '        ElseIf (manage.manipulateDataAt("INSERT INTO `purok` VALUES ('" & name.Trim & "')")) Then
    '            MessageBox.Show("Purok '" & name.Trim.ToUpper & "' successfully added!", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        End If

    '    Catch duplicate As MySqlException
    '        MessageBox.Show("Purok '" & name.Trim.ToUpper & "' already exist!", "FAILED TO ADD!", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Catch nullValues As NoNullAllowedException
    '        MessageBox.Show("Input is invalid! An input must not leave empty or contain special characters \/:*?`<>| ", "FAILED TO ADD!", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Finally
    '        closeConnection()
    '    End Try
    'End Sub
    Function getResidentsQuery() As String
        Return residentsQuery
    End Function



    Function isInputNullAt(txtbox As Bunifu.UI.WinForms.BunifuTextBox)
        If (String.IsNullOrEmpty(txtbox.Text)) Then

            Return True
        End If
    End Function

    Function oneOfTheInputsIsNull()
        Dim arr() As String = {MyResidents.LastNameTextBox.Text, MyResidents.MiddleNameTextBox.Text, MyResidents.FirstNameTextBox.Text,
        MyResidents.SuffixComboBox.Text, MyResidents.CitizenshipTextBox.Text, MyResidents.AddressTextBox.Text,
        MyResidents.ReligionTextBOx.Text, MyResidents.HighestEducationAttainmentTextBox.Text, MyResidents.ContactTextBox.Text, MyResidents.OccupationTextBox.Text,
        MyResidents.PurokTextBox.Text, MyResidents.BirthdateDatePicker.Value.Date, MyResidents.CivilStatusComboBox.Text, MyResidents.SexComboBox.Text, MyResidents.VoterComboBox.Text,
        MyResidents.SeniorComboBox.Text}

        For Each input As String In arr
            Return String.IsNullOrEmpty(input)
        Next
    End Function
End Class
