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
End Module
