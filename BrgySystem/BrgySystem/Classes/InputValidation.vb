Imports MySql.Data.MySqlClient
Imports Bunifu.UI.WinForms


Module InputValidation
    Function InputContainsSpecialCharacter(s As String) As Boolean
        Return s.IndexOfAny("[~`!@#$%^&*()-+=|{}':;.,<>/?]".ToCharArray) <> -1
    End Function
    Function InputContainsLetter(s As String) As Boolean
        Return s.IndexOfAny("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray) <> -1
    End Function
    Function InputContainsNumber(s As String) As Boolean
        Return s.IndexOfAny("1234567890".ToCharArray) <> -1
    End Function
    Function ContainsSpecialChars(s As String) As Boolean
        Return s.IndexOfAny("[~`!@#$%^&*()-+=|{}':;.,<>/?]".ToCharArray) <> -1
    End Function

    Function InputIsNull(s As String) As Boolean
        Return s.Length = 0 Or s = ""
    End Function

    Function isDateOrBirthdayInvalid(val As DateTimePicker) As Boolean
        Return val.Value.Year >= Date.Now.Year
    End Function

    Function isInputAlreadyExist(columnName As String, tableName As String, input As String) As Boolean 'select fullname from  residents where fullname = 'therter'
        Dim datatable As New DataTable
        Dim adapter As New MySqlDataAdapter("SELECT " & columnName & " from  " & tableName & " where " & columnName & " = '" & input & "' ", ConnectionDB.getConnection)
        adapter.Fill(datatable)
        Return datatable.Rows.Count
    End Function



End Module
