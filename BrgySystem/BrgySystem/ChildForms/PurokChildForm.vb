Imports MySql.Data.MySqlClient
Public Class PurokChildForm
    Private var As MyPurok = New MyPurok


    Private Sub AddPurokBttn_Click_1(sender As Object, e As EventArgs) Handles AddPurokBttn.Click
        Dim newPurok As New MyPurok
        newPurok.addNew(AddPurokTextBox)
        var.loadPurok(Purok.PurokGridView)

        Me.Close()
        closeConnection()


    End Sub

    Private Sub PurokChildForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openConnection()

    End Sub

    Private Sub UpdateBttn_Click(sender As Object, e As EventArgs) Handles UpdateBttn.Click

    End Sub

    Private Sub FormIsClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        UpdateBttn.Enabled = True
        AddPurokBttn.Enabled = True
        AddPurokTextBox.Clear()
        closeConnection()
    End Sub
End Class