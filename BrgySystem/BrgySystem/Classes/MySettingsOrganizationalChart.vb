Imports Bunifu.UI.WinForms
Imports MySql.Data.MySqlClient

Public Class MySettingsOrganizationalChart
    Private manage As DataManipulation = New ManageSystem


    Function getImage(name As String) As String
        openConnection()
        Dim query As String = "SELECT ImagePath FROM `officials` WHERE Name = '" & name.Trim & "' "
        Dim command As MySqlCommand = New MySqlCommand(query, getConnection)
        Dim reader As MySqlDataReader = command.ExecuteReader
        Try
            While reader.Read()
                Return reader.GetString("ImagePath")

            End While
        Catch x As MySqlException

            MessageBox.Show(x.Message, "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As ArgumentException

        Finally
            reader.Close()
            closeConnection()
        End Try

        Return " "
    End Function
    Function updateOfficial(id As Integer, name As String, imagePath As String) As Boolean
        Dim query As String = "UPDATE `orgchart` SET `Fullname`= '" & name & "',`ImagePath`='" & imagePathManager.getImagePath(imagePath) & "' WHERE id = '" & id & "'"

        Dim res As Boolean = manage.manipulateDataAt(query)
        closeConnection()
        Return res

    End Function

    Sub displayInfo(id As Integer, name As BunifuTextBox, pic As BunifuPictureBox)
        openConnection()
        Dim query As String = "SELECT  `Fullname`, `ImagePath` FROM `orgchart` WHERE id = '" & id & "'"
        Dim Command As MySqlCommand = New MySqlCommand(query, getConnection)
        Dim reader As MySqlDataReader = Command.ExecuteReader
        Try
            While reader.Read
                name.Text = reader.GetString("Fullname")
                pic.Image = Image.FromFile(reader.GetString("ImagePath"))
            End While
        Catch x As MySqlException

            MessageBox.Show(x.Message, "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As ArgumentException

        Catch ex1 As System.IO.FileNotFoundException
            ' let it be
        Finally
            reader.Close()
            closeConnection()
        End Try
    End Sub



End Class
