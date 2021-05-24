Public Class Clearance
    Dim SettinggridViewImage As New DataGridViewImages
    Dim SettingAction As New DataGridViewActionButtonEvent
    Private clearance As MyClearance = New MyClearance
    Private manage As loadGridViewValue = New ManageSystem
    Private search As Search = New SearchingFeature_Implementation
    Private isAlreadyStartSearchField, IsAlreadyStartAtName As Boolean
    Private valueYouSearchFor As String
    Public isBusinessNamemodified, isTransactNumberModified As Boolean

    Private Sub CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles ClearanceDataGridView.CellFormatting
        SettinggridViewImage.setImageAtButtonColumnOf("deleteButton_Column", ClearanceDataGridView, e, My.Resources.icons8_trash_24px)
        'SettinggridViewImage.setImageAtButtonColumnOf("viewButtonColumn", ClearanceGridView, e, My.Resources.icons8_edit_24px)

    End Sub

    Private Sub BrgyClearanceTypeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BrgyClearanceTypeComboBox.SelectedIndexChanged
        If BrgyClearanceTypeComboBox.SelectedIndex = 0 Then
            businessNameTextBox.Enabled = False
            BusinessTypeTextBox.Enabled = False
            businessNameTextBox.Clear()
            BusinessTypeTextBox.Clear()
        ElseIf BrgyClearanceTypeComboBox.SelectedIndex = 1 Then

            businessNameTextBox.Enabled = True
            BusinessTypeTextBox.Enabled = True
        End If
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click

    End Sub



    Private Sub Clearance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        isBusinessNamemodified = False
        isTransactNumberModified = False
        clearance.arrangeGridView()
        manage.loadGridViewValueOf(clearance.getClearanceValuesSelectedColumn, ClearanceDataGridView)

        search.addAndRefresh_DataSuggestion_WhileSearchingAt("Fullname", "clearance", SearchFieldtextBox)
        search.addAndRefresh_DataSuggestion_WhileSearchingAt("Fullname", "residents", nameTextBox)
    End Sub

























    Private Sub SearchFieldIsClick(sender As Object, e As EventArgs) Handles SearchFieldtextBox.Click
        isAlreadyStartSearchField = True
    End Sub

    Private Sub SearchFieldTextChange(sender As Object, e As EventArgs) Handles SearchFieldtextBox.TextChange
        If InputIsNull(SearchFieldtextBox.Text.Trim) And isAlreadyStartSearchField Then
            '    manage.loadGridViewValueOf(clearance.getClearanceValuesSelectedColumn, ClearanceGridView)
        End If
    End Sub

    Private Sub SearchFieldKeyDown(sender As Object, e As KeyEventArgs) Handles SearchFieldtextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            valueYouSearchFor = clearance.getClearanceValuesSelectedColumn + "where Fullname Like '%" & SearchFieldtextBox.Text.Trim & "%'"
            search.searchValueIn(valueYouSearchFor, ClearanceDataGridView)
        End If
    End Sub


    Private Sub SearchButtonClicked(sender As Object, e As EventArgs) Handles Button1.Click
        search.searchValueIn(valueYouSearchFor, ClearanceDataGridView)
    End Sub








    Private Sub NameTextBoxIsClick(sender As Object, e As EventArgs) Handles nameTextBox.Click
        IsAlreadyStartAtName = True
    End Sub

    Private Sub nameTextBoxtTExtChanged(sender As Object, e As EventArgs) Handles nameTextBox.TextChange
        If InputIsNull(nameTextBox.Text.Trim) And IsAlreadyStartAtName Then
            addressTextBox.Clear()
            SexTextBox.Clear()
            AgeTextBox.Clear()
        End If
    End Sub

    Private Sub ClearanceGridViewClicked(sender As Object, e As DataGridViewCellEventArgs) Handles ClearanceDataGridView.CellClick
        If SettingAction.buttonOf_IsClick("deleteButton_Column", ClearanceDataGridView, e) Then
            isBusinessNamemodified = False
            isTransactNumberModified = False
        End If
    End Sub

    Private Sub TransactionNumTxtBoxTextChanged(sender As Object, e As KeyEventArgs) Handles TransactionNumberTextBox.KeyDown
        isTransactNumberModified = True
    End Sub

    Private Sub BusinessNameTxtBoxKeyDown(sender As Object, e As KeyEventArgs) Handles businessNameTextBox.KeyDown
        isBusinessNamemodified = True
    End Sub

    Private Sub NameTextBoxKeyDown(sender As Object, e As KeyEventArgs) Handles nameTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            'show inputs
        End If
    End Sub
End Class