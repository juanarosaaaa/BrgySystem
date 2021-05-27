Public Class Dashboard
    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LiveDateAndTime.Text = "TODAY IS " & Date.Now
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LiveDateAndTime.Text = "TODAY IS " & Date.Now
    End Sub
End Class