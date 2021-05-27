Imports MySql.Data.MySqlClient

Public Class Dashboard

    Private setMissionVision As SettingMissionVision = New SettingMissionVision
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setMissionVision.displayMissionAndVision()
        LiveDateAndTime.Text = "TODAY IS " & Date.Now
        lblCountClearance.Text = getRowCount("clearance")
        lblCountResidents.Text = getRowCount("residents")
        lblCountPurok.Text = getRowCount("purok")

        RichTextBoxMission.Text = setMissionVision.getMission
        RichTextBoxVision.Text = setMissionVision.getVision
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LiveDateAndTime.Text = "TODAY IS " & Date.Now
    End Sub

    Function getRowCount(tablename As String) As String

        openConnection()
        Dim query As String = "SELECT COUNT(*) FROM " & tablename & ""
        Dim command As New MySqlCommand(query, getConnection)
        Dim reader As MySqlDataReader
        reader = command.ExecuteReader
        Try
            If reader.Read Then
                Return reader.GetString("COUNT(*)")

                Exit Function
            End If
        Catch x As Exception
            MessageBox.Show(x.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            reader.Close()
            closeConnection()
        End Try

        Return "0"
    End Function

End Class