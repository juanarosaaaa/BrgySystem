Public Class MyPurok
    Private purokName As String
    Public Sub New(purokname As String)
        Me.purokName = purokname
    End Sub
    Public Property MyPurokName As String
        Get
            Return purokName
        End Get
        Set(value As String)
            purokName = value
        End Set
    End Property
    Function isPurokValid() As Boolean
        Return checkInputValidity.ContainsSpecialChars(purokName) Or purokName = vbNull
    End Function
    'is purok exist
End Class
