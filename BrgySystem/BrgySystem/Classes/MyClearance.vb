Public Class MyClearance
    Private getValuesQueryOftheSelectedColumn As String = "SELECT `TransactNo`,`Fullname`,`Purpose`,`DateAndTime`,`Given_By`,`Type` FROM `clearance` "

    Sub arrangeGridView()

        Clearance.ClearanceGridView.Columns("transact_Col").DataPropertyName = "TransactNo"

        Clearance.ClearanceGridView.Columns("fullname_Column").DataPropertyName = "Fullname"

        Clearance.ClearanceGridView.Columns("purpose_Column").DataPropertyName = "Purpose"

        Clearance.ClearanceGridView.Columns("date_Column").DataPropertyName = "DateAndTime"

        Clearance.ClearanceGridView.Columns("givenBy_Column").DataPropertyName = "Given_By"

        Clearance.ClearanceGridView.Columns("type_Column").DataPropertyName = "Type"


    End Sub


    Function getClearanceValuesSelectedColumn() As String
        Return getValuesQueryOftheSelectedColumn
    End Function


    Function IsInputInValid()


        Dim arr() As Object = {Clearance.nameTextBox,
            Clearance.businessNameTextBox, Clearance.BusinessTypeTextBox, Clearance.TransactionNumberTextBox, Clearance.PurposeTextBox,
             Clearance.IssuedAtTextBox, Clearance.Quantity, Clearance.AmountTextBox, Clearance.TotalTextBox}

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


    Function addClearance() As Boolean
        Dim res As Boolean = False
        If IsInputInValid() Then
            res = False
            Exit Function
        ElseIf InputContainsLetter(Clearance.TransactionNumberTextBox.Text.Trim) Then
            MessageBox.Show("Transaction Number contains letter!", "Transaction Number Invalid!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            res = False
        ElseIf InputContainsLetter(Clearance.Quantity.Text) Then
            MessageBox.Show("Quantity contains letter!", "Quantity Invalid!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            res = False
        ElseIf InputContainsLetter(Clearance.AmountTextBox.Text) Then
            MessageBox.Show("Cash Amount contains letter!", "Cash Amount Invalid!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            res = False
        ElseIf InputContainsLetter(Clearance.TotalTextBox.Text) Then
            MessageBox.Show("Total Amount contains letter!", "Total Amount  Invalid!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (Not isInputAlreadyExist("FULLNAME", "residents", Clearance.nameTextBox.Text.Trim)) Then
            MessageBox.Show("Resident '" & Clearance.nameTextBox.Text.Trim.ToUpper & "' does not exist in Purok list.", "INVALID INPUT!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            res = False

        End If
    End Function












End Class
