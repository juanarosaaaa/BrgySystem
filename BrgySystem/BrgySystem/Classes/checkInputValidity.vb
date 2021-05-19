Imports Bunifu.UI.WinForms

Module checkInputValidity
    Function InputContainsSpecialCharacter(value As String) As Boolean
        Return value.IndexOfAny("[~`!@#$%^&*()-+=|{}':;.,<>/?]".ToCharArray) <> -1
    End Function
    Function InputIsNull(valueInput As String) As Boolean
        Return valueInput.Trim.Length = 0

    End Function
    Sub setCharacterLengthLimit(length As Integer, value As String)
        'to be use somewhere else
    End Sub

    Function isDateOrBirthdayInvalid(date_ As BunifuDatePicker) As Boolean
        Return date_.Value.Year >= Date.Now.Year
    End Function

    Function InputContainsNumber(value As String) As Boolean
        Return value.IndexOfAny("123456789".ToCharArray) <> -1
    End Function


    Function InputContainsLetter(value As String) As Boolean
        Return value.IndexOfAny("ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray) <> -1
    End Function
End Module
