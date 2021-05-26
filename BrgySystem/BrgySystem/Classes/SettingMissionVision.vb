Imports MySql.Data.MySqlClient
Public Class SettingMissionVision
    Private mission As String
    Private vision As String

    Private manage As DataManipulation = New ManageSystem
    Sub New(mission As String, vision As String)
        Me.mission = mission
        Me.vision = vision
    End Sub

    Sub New()

    End Sub







    Sub displayMissionAndVision()
        openConnection()
        Dim query As String = "SELECT * FROM `mission_vision` WHERE id = 1"
        Dim command As New MySqlCommand(query, getConnection)
        Dim reader As MySqlDataReader
        reader = command.ExecuteReader
        Try
            While reader.Read
                mission = reader.GetString("Mission")
                vision = reader.GetString("Vision")
            End While
        Catch x As MySqlException
            MessageBox.Show(x.Message, "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
            closeConnection()
        End Try
    End Sub

    Sub updateMissionVision()

        Dim query As String = "UPDATE `mission_vision` SET `Mission`='" & mission & "',`Vision`='" & vision & "' WHERE id = 1"
        If manage.manipulateDataAt(query) Then
            MessageBox.Show("Mission and Vision successfully updated!", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Failed to update Mission and Vision!", "FAILED!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        closeConnection()
    End Sub

    Function getMission() As String
        Return mission
    End Function


    Function getVision() As String
        Return vision
    End Function

End Class



