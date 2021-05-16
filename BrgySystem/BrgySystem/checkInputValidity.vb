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

End Module
