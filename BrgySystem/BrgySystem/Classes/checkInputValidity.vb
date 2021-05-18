Imports Bunifu.UI.WinForms

Module checkInputValidity
    Function ContainsSpecialChars(value As String) As Boolean
        Return value.IndexOfAny("[~`!@#$%^&*()-+=|{}':;.,<>/?]".ToCharArray) <> -1
    End Function
    Function InputIsNull(valueInput As String) As Boolean
        Return valueInput.Length = 0

    End Function
    Sub setCharacterLengthLimit(length As Integer, value As String)
        'to be use somewhere else
    End Sub

    Function isDateValidIn(date_ As BunifuDatePicker) As Boolean
        Return date_.Value.Year >= Date.Now.Year
    End Function



End Module
