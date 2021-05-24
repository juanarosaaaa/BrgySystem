Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms
Imports Bunifu.UI.WinForms
Imports System.IO



Public Class MyClearance
    Private getValuesQueryOftheSelectedColumn As String = "SELECT `Fullname`,`TransactNo`,`Purpose`,`DateAndTime`,`Given_By`,`Type` FROM `clearance` "
    Private manage As DataManipulation = New ManageSystem
    Sub arrangeGridView()

        Clearance.ClearanceGridView.Columns("fullname_Column").DataPropertyName = "Fullname"
        Clearance.ClearanceGridView.Columns("Transact_Col").DataPropertyName = "TransactNo"
        Clearance.ClearanceGridView.Columns("purpose_Column").DataPropertyName = "Purpose"
        Clearance.ClearanceGridView.Columns("date_Column").DataPropertyName = "DateAndTime"
        Clearance.ClearanceGridView.Columns("givenBy_Column").DataPropertyName = "Given_By"
        Clearance.ClearanceGridView.Columns("typeColumn").DataPropertyName = "Type"


    End Sub


    Function insertClearanceQuery() As String
        Return "INSERT INTO `clearance` VALUES ('" & Clearance.TransactionNumber_TextBox.Text.Trim & "',
'" & Clearance.FullNameTextBox.Text.Trim & "',
'" & Clearance.AddressTextBox.Text.Trim & "',
'" & Clearance.SexTextBox.Text & "',
'" & Clearance.AgeTextBox.Text & "', 
'" & Clearance.QuantityTextBox.Text & "',
'" & Clearance.DateAndTimeTextBox.Text & "',
'ADMIN',
'" & Clearance.PurposeTextBox.Text.Trim & "',
'" & Clearance.BrgyClearanceComboBox.Text.Trim & "',
'" & Clearance.AmountTextbox.Text.Trim & "',
'" & Clearance.TotalTextbox.Text.Trim & "',
'" & Clearance.TotalTextbox.Text.Trim & "',
'" & Clearance.BusinessTypeTextBox.Text.Trim & "',
'" & Clearance.IssuedAtTextBox.Text.Trim & "')"
    End Function

    Function getClearanceValuesSelectedColumn() As String
        Return getValuesQueryOftheSelectedColumn
    End Function


    Function IsInputInValid()


        Dim arr() As Object = {Clearance.FullNameTextBox,
            Clearance.BusinessNameTextBOx, Clearance.BusinessTypeTextBox, Clearance.TransactionNumber_TextBox, Clearance.PurposeTextBox,
             Clearance.IssuedAtTextBox, Clearance.QuantityTextBox, Clearance.AmountTextbox, Clearance.TotalTextbox}

        For Each inputObjects As Object In arr


            If (InputIsNull(inputObjects.Text)) Then
                MessageBox.Show("Please enter your " & inputObjects.AccessibleName & ".", "INCOMPLETE DETAILS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return True
                Exit For
                Exit Function
            ElseIf (InputContainsSpecialCharacter(inputObjects.Text)) Then
                MessageBox.Show("Input is invalid. Your '" & inputObjects.AccessibleName & "' field contains special characters ^&*()-+=|{}':;.", "INCOMPLETE DETAILS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return True
                Exit For
                Exit Function
            End If

            If inputObjects.Equals(arr(1)) Or inputObjects.Equals(arr(3)) Or inputObjects.Equals(arr(5)) Or inputObjects.Equals(arr(6)) Or inputObjects.Equals(arr(7)) Or inputObjects.Equals(arr(8)) Then
                Continue For
            ElseIf InputContainsNumber(inputObjects.Text) Then
                MessageBox.Show("Input is invalid! Your " & inputObjects.AccessibleName & " contains number.", "INCOMPLETE DETAILS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return True
                Exit For
                Exit Function

            End If


        Next

        Return False

    End Function

    Sub setInputValuesFrom(name As String)
        openConnection()
        Dim command As New MySqlCommand("SELECT ADDRESS,AGE,SEX FROM `residents` WHERE FULLNAME = '" & name.Trim & "'", getConnection)
        Dim reader As MySqlDataReader
        reader = command.ExecuteReader

        Try
            While reader.Read
                With Clearance
                    .AddressTextBox.Text = reader.GetString("ADDRESS")
                    .AgeTextBox.Text = reader.GetString("AGE")
                    .SexTextBox.Text = reader.GetString("SEX")
                End With
            End While


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            closeConnection()
        End Try
    End Sub




    Function addClearance(query As String) As Boolean
        Try
            If IsInputInValid() Then
                Return False
                Exit Function
            ElseIf InputContainsLetter(Clearance.TransactionNumber_TextBox.Text.Trim) Then
                MessageBox.Show("Transaction Number contains letter!", "Transaction Number Invalid!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            ElseIf InputContainsLetter(Clearance.QuantityTextBox.Text) Then
                MessageBox.Show("Quantity contains letter!", "Quantity Invalid!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            ElseIf InputContainsLetter(Clearance.AmountTextbox.Text) Then
                MessageBox.Show("Cash Amount contains letter!", "Cash Amount Invalid!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            ElseIf InputContainsLetter(Clearance.TotalTextbox.Text) Then
                MessageBox.Show("Total Amount contains letter!", "Total Amount  Invalid!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf (Not isInputAlreadyExist("FULLNAME", "residents", Clearance.FullNameTextBox.Text.Trim)) Then
                MessageBox.Show("Unknown Resident. Resident '" & Clearance.FullNameTextBox.Text.Trim.ToUpper & "' does not exist in Resident's list.", "INVALID Resident!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            ElseIf (manage.manipulateDataAt(query)) Then
                MessageBox.Show("Clearance sucessfully added!", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                clearAllInputs()
                Return True
            Else
                MessageBox.Show("An error occured. Failed saving Clearance!", "FAILED!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        Catch duplicate As MySqlException
            If isInputAlreadyExist("Business Name", "clearance", Clearance.BusinessNameTextBOx.Text.Trim) And Clearance.isBusinessNamemodified Then
                MessageBox.Show("Business Name '" & Clearance.BusinessNameTextBOx.Text.Trim.ToUpper & "' is already used.", "INVALID BUSINESS NAME!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            ElseIf isInputAlreadyExist("TransactNo", "clearance", Clearance.TransactionNumber_TextBox.Text.Trim) And Clearance.isTransactNumberModified Then
                MessageBox.Show("Transaction Number '" & Clearance.TransactionNumber_TextBox.Text.Trim.ToUpper & "' is already exist.", "INVALID TRANSACTION NUMBER!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If
        Finally
            closeConnection()
        End Try

        Return False
    End Function

    Sub clearAllInputs()

        With Clearance
            .FullNameTextBox.Clear()
            .BusinessNameTextBOx.Clear()
            .BusinessTypeTextBox.Clear()
            .TransactionNumber_TextBox.Clear()
            .PurposeTextBox.Clear()
            .AddressTextBox.Clear()
            .IssuedAtTextBox.Clear()
            .SexTextBox.Clear()
            .AgeTextBox.Clear()

            .isBusinessNamemodified = False
            .isTransactNumberModified = False
        End With





    End Sub










End Class
