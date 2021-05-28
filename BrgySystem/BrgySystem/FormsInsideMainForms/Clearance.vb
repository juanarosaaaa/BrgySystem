
Public Class Clearance


    Dim SettinggridViewImage As New DataGridViewImages
    Dim SettingAction As New DataGridViewActionButtonEvent
    Private clearance As MyClearance = New MyClearance

    Private manage As loadGridViewValue = New ManageSystem
    Private search As Search = New SearchingFeature_Implementation
    Private isAlreadyStartSearchField, IsAlreadyStartAtName As Boolean
    Private valueYouSearchFor, nameYouSearchFor As String
    Public isBusinessNamemodified, isTransactNumberModified As Boolean

    Private Sub CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles ClearanceGridView.CellFormatting
        SettinggridViewImage.setImageAtButtonColumnOf("deleteButton_Column", ClearanceGridView, e, My.Resources.icons8_trash_24px)


    End Sub

    Private Sub BrgyClearanceTypeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BrgyClearanceComboBox.SelectedIndexChanged


        If BrgyClearanceComboBox.SelectedIndex = 0 Then
            BusinessNameTextBOx.ReadOnly = True
            BusinessTypeTextBox.ReadOnly = True

            BusinessNameTextBOx.Clear()
            BusinessTypeTextBox.Clear()
        ElseIf BrgyClearanceComboBox.SelectedIndex = 1 Then

            BusinessNameTextBOx.ReadOnly = False
            BusinessTypeTextBox.ReadOnly = False
        End If
    End Sub





    Private Sub Clearance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelStatus.Visible = False
        isBusinessNamemodified = False
        isTransactNumberModified = False
        BrgyClearanceComboBox.SelectedIndex = 0

        clearance.arrangeGridView()
        manage.loadGridViewValueOf(clearance.getClearanceValuesSelectedColumn, ClearanceGridView)
        TransactionNumber_TextBox.Text = clearance.getGeneratedTransactionNumber
        search.addAndRefresh_DataSuggestion_WhileSearchingAt("Fullname", "clearance", SearchFieldTextBox)
        search.addAndRefresh_DataSuggestion_WhileSearchingAt("Fullname", "residents", FullNameTextBox)

        SearchFieldTextBox.PlaceholderText = "Search Name"
    End Sub










    Private Sub SearchFieldIsClick(sender As Object, e As EventArgs) Handles SearchFieldTextBox.Click
        isAlreadyStartSearchField = True
    End Sub

    Private Sub SearchFieldTextChange(sender As Object, e As EventArgs) Handles SearchFieldTextBox.TextChange
        valueYouSearchFor = clearance.getClearanceValuesSelectedColumn + "where Fullname Like '%" & SearchFieldTextBox.Text.Trim & "%'"
        If InputIsNull(SearchFieldTextBox.Text.Trim) And isAlreadyStartSearchField Then
            manage.loadGridViewValueOf(clearance.getClearanceValuesSelectedColumn, ClearanceGridView)
        End If
    End Sub

    Private Sub SearchFieldKeyDown(sender As Object, e As KeyEventArgs) Handles SearchFieldTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            search.searchValueIn(valueYouSearchFor, ClearanceGridView)
        End If
    End Sub


    Private Sub SearchButtonClicked(sender As Object, e As EventArgs) Handles SearchButton.Click
        search.searchValueIn(valueYouSearchFor, ClearanceGridView)
    End Sub






    Private Sub FullNameTextBoxKeyDown(sender As Object, e As KeyEventArgs) Handles FullNameTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            clearance.setInputValuesFrom(FullNameTextBox.Text.Trim)
            If (Not isInputAlreadyExist("FULLNAME", "residents", FullNameTextBox.Text.Trim)) Then
                LabelStatus.Visible = True
            End If
        End If
    End Sub

    Private Sub NameTextBoxIsClick(sender As Object, e As EventArgs) Handles FullNameTextBox.Click
        IsAlreadyStartAtName = True
    End Sub

    Private Sub nameTextBoxtTExtChanged(sender As Object, e As EventArgs) Handles FullNameTextBox.TextChange

        If InputIsNull(FullNameTextBox.Text.Trim) Then
            AddressTextBox.Clear()
            SexTextBox.Clear()
            AgeTextBox.Clear()
            LabelStatus.Visible = False
        ElseIf (Not isInputAlreadyExist("FULLNAME", "residents", FullNameTextBox.Text.Trim)) Then
            closeConnection()
            LabelStatus.Visible = True
        Else
            LabelStatus.Visible = False
        End If



    End Sub

    Private Sub ClearanceGridViewClicked(sender As Object, e As DataGridViewCellEventArgs) Handles ClearanceGridView.CellClick
        If SettingAction.buttonOf_IsClick("deleteButton_Column", ClearanceGridView, e) Then
            clearance.deleteClearance(ClearanceGridView.CurrentRow.Cells("fullname_Column").FormattedValue)
            manage.loadGridViewValueOf(clearance.getClearanceValuesSelectedColumn, ClearanceGridView)
            search.addAndRefresh_DataSuggestion_WhileSearchingAt("Fullname", "clearance", SearchFieldTextBox)
            clearance.clearAllInputs()

            isBusinessNamemodified = False
            isTransactNumberModified = False
        End If
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        DateAndTimeTextBox.Text = Date.Now
    End Sub

    Private Sub QuantityTextBox_TextChange(sender As Object, e As EventArgs) Handles QuantityTextBox.TextChange
        Dim total As Double = Val(QuantityTextBox.Text) * 75
        TotalTextbox.Text = Val(total)
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub TransactionNumber_TextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles TransactionNumber_TextBox.KeyDown
        isTransactNumberModified = True
    End Sub




    Private Sub addButton_Click_1(sender As Object, e As EventArgs) Handles addButton.Click


        If Val(AmountTextbox.Text) < Val(TotalTextbox.Text) Then
            MessageBox.Show("INSUFFICIENT AMOUNT.", "NO BALANCE", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf clearance.addClearance(clearance.insertClearanceQuery) Then
            search.addAndRefresh_DataSuggestion_WhileSearchingAt("Fullname", "clearance", SearchFieldTextBox)
            manage.loadGridViewValueOf(clearance.getClearanceValuesSelectedColumn, ClearanceGridView)
        End If

    End Sub

    Private Sub BusinessNameTxtBoxKeyDown(sender As Object, e As KeyEventArgs) Handles BusinessNameTextBOx.KeyDown
        isBusinessNamemodified = True
    End Sub


End Class