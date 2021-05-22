Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms
Imports Bunifu.UI.WinForms
Imports System.IO



Public Class MyOfficials
    Private getValuesQueryOfTheSelectedColumn As String = "SELECT NAME,AGE,TERM,POSITION,SEX,STATUS,CONTACT FROM `officials`"
    Private result As Boolean
    Sub arrangeGridView()
        Officials.OfficialsGridVIew.Columns("name_Column").DataPropertyName = "NAME"
        Officials.OfficialsGridVIew.Columns("age_Column").DataPropertyName = "AGE"
        Officials.OfficialsGridVIew.Columns("term_Column").DataPropertyName = "TERM"
        Officials.OfficialsGridVIew.Columns("position_Column").DataPropertyName = "POSITION"
        Officials.OfficialsGridVIew.Columns("sex_Column").DataPropertyName = "SEX"
        Officials.OfficialsGridVIew.Columns("status_Column").DataPropertyName = "STATUS"
        Officials.OfficialsGridVIew.Columns("contact_Column").DataPropertyName = "CONTACT"
    End Sub


    Function getOfficialsQueryValuesSelectedColumn() As String
        Return getValuesQueryOfTheSelectedColumn
    End Function

    Function IsInputValid()
        result = False

        'Dim arr() As Object = {MyResidents.Fullnametxtbox,
        '                       MyResidents.SuffixComboBox,
        '                       MyResidents.CitizenshipTextBox,
        '                       MyResidents.AddressTextBox,
        '                       MyResidents.ReligionTextBOx,
        '                       MyResidents.HighestEducationAttainmentTextBox,
        '                       MyResidents.ContactTextBox,
        '                       MyResidents.OccupationTextBox,
        '                       MyResidents.PurokTextBox,
        '                       MyResidents.CivilStatusComboBox,
        '                       MyResidents.SexComboBox,
        '                       MyResidents.VoterComboBox,
        '                       MyResidents.SeniorComboBox}

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





End Class
