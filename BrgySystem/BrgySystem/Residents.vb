Public Class Residents
    Private fullname As String
    Private educationalAttainment As String
    Private contact As String
    Private citizenship As String
    Private address As String
    Private occupation As String
    Private religion As String
    Private sex As String
    Private civilStatus As String
    Private voter As String
    Private suffix As String
    Private purok As String
    Private ReadOnly birthdate As DateTime
    Private senior As String
    Private image As String

    Public Property setSex As String
        Get
            Return sex
        End Get
        Set(value As String)
            sex = value
        End Set
    End Property

End Class
