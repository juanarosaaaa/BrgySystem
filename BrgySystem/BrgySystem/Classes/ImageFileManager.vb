Imports System.IO
Imports Bunifu.UI.WinForms
Public Class ImageFileManager

    Private imagePath As String
    Private imageName As String = ""

    Private openPicFile As OpenFileDialog = New OpenFileDialog()
    Private pictureValue As PictureBox = New PictureBox()


    Sub openImageFromPictureBox(pic As BunifuPictureBox)
        openPicFile.Filter = "Images|*.png;*.jpg;*.jpeg"
        If openPicFile.ShowDialog = DialogResult.OK Then
            imageName = openPicFile.FileName

            pictureValue = pic
            pictureValue.Image = Image.FromFile(imageName)
        Else

            Exit Sub
        End If
    End Sub

    Function getImageName()

        Return Path.GetFileName(imageName)

    End Function

    Sub setImage(imagePathFromTheImageInSelectedRow As String, pic As BunifuPictureBox)
        imageName = imagePathFromTheImageInSelectedRow

        pictureValue = pic
        pictureValue.Image = Image.FromFile(imageName)

    End Sub

    Sub saveImageAt(folderName As String)

        Try
            If (String.IsNullOrEmpty(imageName)) Then
                Throw New NoNullAllowedException()
                Exit Sub
            Else
                imagePath = Path.Combine(My.Application.Info.DirectoryPath.ToString + "\" & folderName & "", Path.GetFileName(imageName))
                pictureValue.Image.Save(imagePath)
            End If
        Catch x As System.Runtime.InteropServices.ExternalException

        End Try

    End Sub

    Function getImageFolderPath() As String
        Return imagePath
    End Function


End Class
