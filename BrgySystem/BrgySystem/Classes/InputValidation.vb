Module InputValidation
    Function InputContainsLetter(s As String) As Boolean
        Return s.IndexOfAny("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray) <> -1
    End Function

    Function InputContainsNumber(s As String) As Boolean
        Return s.IndexOfAny("1234567890".ToCharArray) <> -1
    End Function

    Function InputContainsSpecialCharacter(s As String) As Boolean
        Return s.IndexOfAny("[~`!@#$%^&*()-+=|{}':;.,<>/?]".ToCharArray) <> -1
    End Function

    Function InputIsNull(s As String) As Boolean
        Return s.Length = 0 Or s = ""
    End Function

    Function isDateOrBirthdayInvalid(d As DateTimePicker) As Boolean
        Return d.Value.Year >= Date.Now.Year
    End Function

    'todo fucntion to check if input already exist
End Module
