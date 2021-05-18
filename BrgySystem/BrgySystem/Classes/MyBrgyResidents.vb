Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms
Imports Bunifu.UI.WinForms
Public Class MyBrgyResidents
    Private manage As DataManipulation = New ManageSystem
    Private Const residentsQuery As String = "SELECT FULLNAME,SEX,AGE,CIVIL_STATUS,OCCUPATION,VOTER,ADDRESS FROM `residents`"
    Private result As Boolean



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



    Function isInputNullAt(val As Object)
        If (InputIsNull(val.Text)) Then
            MessageBox.Show("Please enter your " & val.AccessibleName & ".", "INCOMPLETE DETAILS!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        End If
    End Function

    Function oneOfTheInputsIsNull()
        result = False
        Dim arr() As Object = {MyResidents.LastNameTextBox, MyResidents.MiddleNameTextBox, MyResidents.FirstNameTextBox,
        MyResidents.SuffixComboBox, MyResidents.CitizenshipTextBox, MyResidents.AddressTextBox,
        MyResidents.ReligionTextBOx, MyResidents.HighestEducationAttainmentTextBox, MyResidents.ContactTextBox, MyResidents.OccupationTextBox,
        MyResidents.PurokTextBox, MyResidents.CivilStatusComboBox, MyResidents.SexComboBox, MyResidents.VoterComboBox,
        MyResidents.SeniorComboBox}

        For Each inputObjects As Object In arr
            If (isInputNullAt(inputObjects)) Then
                result = True
                Exit For
            End If
        Next

        Return result
    End Function








    'check if datapicker is date then error
    'check if image is null

End Class
