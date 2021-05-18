Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms
Public Class MyBrgyResidents

    Sub arrangeGridView(gridView As Guna2DataGridView)
        gridView.Columns("fullname_Column").DataPropertyName = "FULLNAME"
        gridView.Columns("sex_Column").DataPropertyName = "SEX"
        gridView.Columns("age_Column").DataPropertyName = "AGE"
        gridView.Columns("civilStatus_Column").DataPropertyName = "CIVIL_STATUS"
        gridView.Columns("occupation_Column").DataPropertyName = "OCCUPATION"
        gridView.Columns("voter_Column").DataPropertyName = "VOTER"
        gridView.Columns("address_Column").DataPropertyName = "ADDRESS"
    End Sub
End Class
