﻿Public Class SettingsAccountSettingsForm
    Private Sub SettingsAccountSettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RemainSizeOfForm.ToTheSizeOfTheSetting(Me)
    End Sub




    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Dim setting As MySettingsFormAcountSettings = New MySettingsFormAcountSettings(UsernametextBox.Text, CurrentPassword.Text, NewPassword.Text, ConfirmPassword.Text)


        If setting.OneInputNull Then
            MessageBox.Show("Incomplete details", "FAILED TO CHANGE PASSWORD", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf Not setting.userAndPasswordCorrect() Then
            MessageBox.Show("Username or password is incorrect!", "AUTHENTICATION FAILED!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf setting.isPasswordinvalid Then
            MessageBox.Show("The password you entered doesn't match!", "AUTHENTICATION FAILED!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            setting.updatePassword()
            MessageBox.Show("Your Password has been changed successfully!", "Password has been changed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click

    End Sub
End Class