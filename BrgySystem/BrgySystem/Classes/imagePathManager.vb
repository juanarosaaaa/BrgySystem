Module imagePathManager
    Function getImagePath(val As String) As String
        Return val.Replace("\", "\\")
    End Function
End Module
