Imports Bunifu.UI.WinForms
Imports MySql.Data.MySqlClient
Public Class MySettingsOrganizationalChart
    Private manage As DataManipulation = New ManageSystem
    Private query As String
    Private command As MySqlCommand
    Private reader As MySqlDataReader
    Function setImage(name As String) As String
        openConnection()
        query = "SELECT ImagePath FROM `officials` WHERE Name = '" & name.Trim & "' "
        command = New MySqlCommand(query, getConnection)
        reader = command.ExecuteReader
        Try
            While reader.Read()
                Return reader.GetString("ImagePath")
            End While
        Catch x As MySqlException
            MessageBox.Show(x.Message, "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As ArgumentException

        Finally
            closeConnection()
        End Try

        Return " "
    End Function
    Function updateOfficial(id As Integer, name As String, imagePath As String) As Boolean
        Dim query As String = "UPDATE `orgchart` `Fullname`= '" & name & "',`ImagePath`='" & imagePathManager.getImagePath(imagePath) & "' WHERE id = '" & id & "'"
        Return manage.manipulateDataAt(query)
        closeConnection()
    End Function
    Sub displayInfo(id As Integer, name As String, pic As BunifuPictureBox)
        query = "SELECT  `Fullname`, `ImagePath` FROM `orgchart` WHERE id = '" & id & "'"
        command = New MySqlCommand(query, getConnection)
        reader = command.ExecuteReader
        Try
            While reader.Read
                name = reader.GetString("Fullname")
                pic.Image = Image.FromFile(reader.GetString("ImagePath"))
            End While
        Catch x As MySqlException
            MessageBox.Show(x.Message, "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As ArgumentException

        Finally
            closeConnection()
        End Try
    End Sub



End Class
