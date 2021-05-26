
Imports MySql.Data.MySqlClient
Imports Bunifu.UI.WinForms
Imports System.IO
Public Class BarangayInformation
    Private adminName As String
    Private address As String
    Private contactNumber As String
    Private barangayCaptainName As String
    Private zipCode As String
    Private imagePath As String
    Private imageName As String
    Private manage As DataManipulation = New ManageSystem
    Sub setAdminName(adminName As String)
        Me.adminName = adminName
    End Sub

    Sub setAddress(address As String)
        Me.address = address
    End Sub

    Sub setContactNumber(contactNumber As String)
        Me.contactNumber = contactNumber
    End Sub

    Sub setBarangayCaptainName(captainName As String)
        Me.barangayCaptainName = captainName
    End Sub

    Sub setZipcode(zipcode As String)
        Me.zipCode = zipcode
    End Sub

    Sub setImagePath(imagepath As String)
        Me.imagePath = imagepath
    End Sub


    Sub setImageName(imageName As String)
        Me.imageName = imageName
    End Sub





    Function getAdminName() As String
        Return adminName
    End Function

    Function getAddress() As String
        Return address
    End Function
    Function getContactNumber() As String
        Return contactNumber
    End Function
    Function getBarangayCaptainName() As String
        Return barangayCaptainName
    End Function
    Function getZipCode() As String
        Return zipCode
    End Function
    Function getImagePath() As String
        Return imagePath
    End Function
    Function getImageName() As String
        Return imageName
    End Function


    Sub displayInformation()
        openConnection()
        Dim query As String = "SELECT * FROM `barangaydetails` WHERE id = 1"
        Dim command As New MySqlCommand(query, getConnection)
        Dim reader As MySqlDataReader
        reader = command.ExecuteReader
        Try
            While reader.Read
                adminName = reader.GetString("AdminName")
                address = reader.GetString("Address")
                contactNumber = reader.GetString("ContactNumber")
                barangayCaptainName = reader.GetString("BarangayCaptain")
                zipCode = reader.GetString("Zipcode")
                imagePath = reader.GetString("ImagePath")
                imageName = reader.GetString("ImageName")
            End While
        Catch x As FileNotFoundException
            MessageBox.Show("Municipality Logo not found. File might have been moved or deleted.", "IMAGE NOT FOUND!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
        End Try
        closeConnection()

    End Sub

    Sub updateBarangayInformation()
        Dim query As String = "UPDATE `barangaydetails` SET `AdminName` = '" & adminName & "',
                                                            `Address` = '" & address & "',
                                                            `ContactNumber` = '" & contactNumber & "',
                                                            `BarangayCaptain` = '" & barangayCaptainName & "',
                                                            `Zipcode` = '" & zipCode & "',
                                                            `ImagePath` = '" & imagePathManager.getImagePath(imagePath) & "',
                                                            `ImageName` = '" & imageName & "' WHERE ID = 1"



        manage.manipulateDataAt(query)
        closeConnection()

    End Sub

    Function oneInputIsNull() As Boolean
        Dim val() As String = {adminName, address, contactNumber, barangayCaptainName, zipCode}
        For Each i As String In val
            Return InputIsNull(i)
            Exit Function
        Next
        Return False
    End Function
    'update
    'check nulls
    'display
    ' check this \\\






















End Class
