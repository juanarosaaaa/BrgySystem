Public Class MySettingsFormAcountSettings
    Inherits MyLogin

    Private username As String
    Private currentpassword, newpassword, confirmpassword As String
    Private manage As DataManipulation = New ManageSystem




    Sub New(username As String, currentpassword As String, newpassword As String, confirmpassword As String)
        Me.username = username
        Me.currentpassword = currentpassword
        Me.newpassword = newpassword
        Me.confirmpassword = confirmpassword

    End Sub


    Function isPasswordinvalid()
        Return newpassword <> confirmpassword
    End Function


    Function userAndPasswordCorrect() As Boolean

        Return IsUserNameAndPasswordCorrect(username, currentpassword)

    End Function

    Function isPasswordStrong() As Boolean
        Return (confirmpassword.Length >= 8 Or confirmpassword.Length <= 16) And InputContainsNumber(confirmpassword) And (InputContainsLetter(confirmpassword) Or InputContainsSpecialCharacter(confirmpassword))
    End Function

    Sub updatePassword()
        Dim updateQuery As String = "UPDATE `login` SET `Password`='" & confirmpassword.Trim & "' WHERE `Username` = '" & username.Trim & "';"
        manage.manipulateDataAt(updateQuery)
        closeConnection()
    End Sub


    Function OneInputNull() As Boolean
        Dim val() As String = {username, currentpassword, newpassword, confirmpassword}
        For Each i As String In val
            Return InputIsNull(i)
            Exit Function
        Next
        Return False
    End Function
End Class
