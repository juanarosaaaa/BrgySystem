Module RemainSizeOfForm
    Sub ToTheSizeOfTheSetting(Obj As Form)
        Obj.Height = Settings.MainPanelSetting.Height
        Obj.Width = Settings.MainPanelSetting.Width
    End Sub
End Module
