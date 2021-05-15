Imports MySql.Data.MySqlClient
Public Class PurokChildForm



    Private Sub AddPurokBttn_Click_1(sender As Object, e As EventArgs) Handles AddPurokBttn.Click
        Dim newPurok As BarangayPurok = New MyPurok
        newPurok.addPurok(AddPurokTextBox)
    End Sub
End Class