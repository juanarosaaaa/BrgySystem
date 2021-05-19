Module RemainThisSizeOfTheForm
    Sub ToTheSizeOfTheSetting(var As Form)
        var.Height = Settings.MainPanelSetting.Height
        var.Width = Settings.MainPanelSetting.Width
        'var.size has bug
    End Sub
End Module
