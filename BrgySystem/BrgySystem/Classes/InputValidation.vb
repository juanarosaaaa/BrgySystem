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

    Function isInputAlreadyExist(columnName As String, tableName As String, input As String) As Boolean 'select PurokName from  Purok where PurokName = 'therter'

        Dim datatable As New DataTable
        Dim adapter As New MySqlDataAdapter("SELECT " & columnName & " from  " & tableName & " where " & columnName & " = '" & input & "' ", ConnectionDB.getConnection)
        adapter.Fill(datatable)
        Return datatable.Rows.Count

    End Function


    Function isInputAlreadyExistAtAnotherTable(columnName_Tbl_B As String, table_b As String, thisTable As String, value_Tbl_A As String, value_Tbl_B As String) As String

        Dim res As String = ""
        Dim command As New MySqlCommand("SELECT " & columnName_Tbl_B & " FROM " & table_b & " WHERE  EXISTS (SELECT 1 FROM  " & thisTable & "  WHERE  " & value_Tbl_A & " =  " & value_Tbl_B & ") ", getConnection)
        Dim reader As MySqlDataReader
        reader = command.ExecuteReader

        If reader.Read Then
            res = reader.GetString(columnName_Tbl_B)
        End If

        reader.Close()
        Return res
    End Function



End Module
