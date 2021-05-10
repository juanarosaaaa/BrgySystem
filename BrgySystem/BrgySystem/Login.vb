Public Class Login
    Private Sub FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.Closed
        Me.Dispose()
        GC.SuppressFinalize(Me)
        Application.Exit()
    End Sub

End Class