Module RemainSizeOfTheForm
    Sub ToTheSizeOfTheSetting(val As Form)
        val.Height = Settings.MainPanelSetting.Height
        val.Width = Settings.MainPanelSetting.Width
    End Sub
End Module
