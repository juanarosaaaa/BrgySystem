Module checkInputValidity
    Function ContainsSpecialChars(value As String) As Boolean
        Return value.IndexOfAny("[~`!@#$%^&*()-+=|{}':;.,<>/?]".ToCharArray) <> -1
    End Function

End Module
