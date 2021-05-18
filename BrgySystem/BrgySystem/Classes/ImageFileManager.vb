Imports System.IO
Public Class ImageFileManager

    Private imagePath As String
    Private imageName As String
    Private uniqueValue As String
    Private openPicFile As OpenFileDialog = New OpenFileDialog
    Private pictureValue As PictureBox = New PictureBox
    Sub New(lastNameOfUser As String) 
        uniqueValue = lastNameOfUser
    End Sub

    'todo
    '1. open file --done
    '2. save image to resource -- done
    '3. get image path according to resource --done
    '4. get image name --done
    '5, insert image path and name 
    '6. add file filter only jpg,png --done
    Sub openImageFromFile(pic As PictureBox)
        openPicFile.Filter = "Images|*.png;*.jpg;*.jpeg"
        If openPicFile.ShowDialog = DialogResult.OK Then
            imageName = openPicFile.FileName
            pictureValue = pic
            pictureValue.Image = Image.FromFile(imageName)
        Else
            imageName = " "
        End If
    End Sub

    Function getFileName()

        Return Path.Combine(uniqueValue, Path.GetFileName(imageName.Trim))

    End Function

    Sub saveImageAt(folderName As String)
        imagePath = Path.Combine(My.Application.Info.DirectoryPath.ToString + "\" & folderName & "", Path.GetFileName(imageName))
        pictureValue.Image.Save(imagePath)

    End Sub

    Function getImagePath() As String
        Return imagePath
    End Function


End Class
