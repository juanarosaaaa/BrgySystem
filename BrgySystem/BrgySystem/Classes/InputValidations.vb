Imports Bunifu.UI.WinForms
Imports MySql.Data.MySqlClient
Module InputValidations
    Function InputContainsSpecialCharacter(value As String) As Boolean
        Return value.IndexOfAny("[~`!@#$%^&*()-+=|{}':;.,<>/?]".ToCharArray) <> -1
    End Function
    Function InputIsNull(valueInput As String) As Boolean
        Return valueInput.Trim.Length = 0

    End Function
    'Sub setCharacterLengthLimit(length As Integer, value As String)
    '    'to be use somewhere else
    'End Sub

    Function isDateOrBirthdayInvalid(date_ As DateTimePicker) As Boolean
        Return date_.Value.Year >= Date.Now.Year
    End Function

    Function InputContainsNumber(value As String) As Boolean
        Return value.IndexOfAny("123456789".ToCharArray) <> -1
    End Function


    Function InputContainsLetter(value As String) As Boolean
        Return value.IndexOfAny("abcdefghijklmnopqrstyuvABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray) <> -1
    End Function


    'Function isValueAlreadyExistAt() As Boolean
    '    Dim datatable As New DataTable

    '    Dim adapter As New MySqlDataAdapter("SELECT `Username`, `Password` FROM `login` where Username = '" & userName & "' and Password = '" & password & "'", ConnectionDB.getConnection)
    '    adapter.Fill(datatable)
    '    Return datatable.Rows.Count
    'End Function
End Module
