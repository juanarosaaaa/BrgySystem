<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PurokChildForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PurokChildForm))
        Dim StateProperties5 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties6 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties7 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties8 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim BorderEdges3 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges4 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Me.AddPurokTextBox = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.AddPurokBttn = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.UpdateBttn = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.SuspendLayout()
        '
        'AddPurokTextBox
        '
        Me.AddPurokTextBox.AcceptsReturn = False
        Me.AddPurokTextBox.AcceptsTab = False
        Me.AddPurokTextBox.AnimationSpeed = 200
        Me.AddPurokTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.AddPurokTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.AddPurokTextBox.BackColor = System.Drawing.Color.Transparent
        Me.AddPurokTextBox.BackgroundImage = CType(resources.GetObject("AddPurokTextBox.BackgroundImage"), System.Drawing.Image)
        Me.AddPurokTextBox.BorderColorActive = System.Drawing.Color.DodgerBlue
        Me.AddPurokTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.AddPurokTextBox.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AddPurokTextBox.BorderColorIdle = System.Drawing.Color.Silver
        Me.AddPurokTextBox.BorderRadius = 1
        Me.AddPurokTextBox.BorderThickness = 1
        Me.AddPurokTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.AddPurokTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AddPurokTextBox.DefaultFont = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.AddPurokTextBox.DefaultText = ""
        Me.AddPurokTextBox.FillColor = System.Drawing.Color.White
        Me.AddPurokTextBox.HideSelection = True
        Me.AddPurokTextBox.IconLeft = Nothing
        Me.AddPurokTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.AddPurokTextBox.IconPadding = 10
        Me.AddPurokTextBox.IconRight = Nothing
        Me.AddPurokTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.AddPurokTextBox.Lines = New String(-1) {}
        Me.AddPurokTextBox.Location = New System.Drawing.Point(7, 66)
        Me.AddPurokTextBox.MaxLength = 32767
        Me.AddPurokTextBox.MinimumSize = New System.Drawing.Size(1, 1)
        Me.AddPurokTextBox.Modified = False
        Me.AddPurokTextBox.Multiline = False
        Me.AddPurokTextBox.Name = "AddPurokTextBox"
        StateProperties5.BorderColor = System.Drawing.Color.DodgerBlue
        StateProperties5.FillColor = System.Drawing.Color.Empty
        StateProperties5.ForeColor = System.Drawing.Color.Empty
        StateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.AddPurokTextBox.OnActiveState = StateProperties5
        StateProperties6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        StateProperties6.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.AddPurokTextBox.OnDisabledState = StateProperties6
        StateProperties7.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties7.FillColor = System.Drawing.Color.Empty
        StateProperties7.ForeColor = System.Drawing.Color.Empty
        StateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.AddPurokTextBox.OnHoverState = StateProperties7
        StateProperties8.BorderColor = System.Drawing.Color.Silver
        StateProperties8.FillColor = System.Drawing.Color.White
        StateProperties8.ForeColor = System.Drawing.Color.Empty
        StateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.AddPurokTextBox.OnIdleState = StateProperties8
        Me.AddPurokTextBox.Padding = New System.Windows.Forms.Padding(3)
        Me.AddPurokTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AddPurokTextBox.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.AddPurokTextBox.PlaceholderText = ""
        Me.AddPurokTextBox.ReadOnly = False
        Me.AddPurokTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.AddPurokTextBox.SelectedText = ""
        Me.AddPurokTextBox.SelectionLength = 0
        Me.AddPurokTextBox.SelectionStart = 0
        Me.AddPurokTextBox.ShortcutsEnabled = True
        Me.AddPurokTextBox.Size = New System.Drawing.Size(408, 36)
        Me.AddPurokTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu
        Me.AddPurokTextBox.TabIndex = 0
        Me.AddPurokTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.AddPurokTextBox.TextMarginBottom = 0
        Me.AddPurokTextBox.TextMarginLeft = 3
        Me.AddPurokTextBox.TextMarginTop = 0
        Me.AddPurokTextBox.TextPlaceholder = ""
        Me.AddPurokTextBox.UseSystemPasswordChar = False
        Me.AddPurokTextBox.WordWrap = True
        '
        'AddPurokBttn
        '
        Me.AddPurokBttn.AllowAnimations = True
        Me.AddPurokBttn.AllowMouseEffects = True
        Me.AddPurokBttn.AllowToggling = False
        Me.AddPurokBttn.AnimationSpeed = 200
        Me.AddPurokBttn.AutoGenerateColors = False
        Me.AddPurokBttn.AutoRoundBorders = False
        Me.AddPurokBttn.AutoSizeLeftIcon = True
        Me.AddPurokBttn.AutoSizeRightIcon = True
        Me.AddPurokBttn.BackColor = System.Drawing.Color.Transparent
        Me.AddPurokBttn.BackColor1 = System.Drawing.Color.DodgerBlue
        Me.AddPurokBttn.BackgroundImage = CType(resources.GetObject("AddPurokBttn.BackgroundImage"), System.Drawing.Image)
        Me.AddPurokBttn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.AddPurokBttn.ButtonText = "Add"
        Me.AddPurokBttn.ButtonTextMarginLeft = 0
        Me.AddPurokBttn.ColorContrastOnClick = 45
        Me.AddPurokBttn.ColorContrastOnHover = 45
        Me.AddPurokBttn.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges3.BottomLeft = True
        BorderEdges3.BottomRight = True
        BorderEdges3.TopLeft = True
        BorderEdges3.TopRight = True
        Me.AddPurokBttn.CustomizableEdges = BorderEdges3
        Me.AddPurokBttn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.AddPurokBttn.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.AddPurokBttn.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.AddPurokBttn.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.AddPurokBttn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.AddPurokBttn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AddPurokBttn.ForeColor = System.Drawing.Color.White
        Me.AddPurokBttn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddPurokBttn.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.AddPurokBttn.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.AddPurokBttn.IconMarginLeft = 11
        Me.AddPurokBttn.IconPadding = 10
        Me.AddPurokBttn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AddPurokBttn.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.AddPurokBttn.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.AddPurokBttn.IconSize = 25
        Me.AddPurokBttn.IdleBorderColor = System.Drawing.Color.DodgerBlue
        Me.AddPurokBttn.IdleBorderRadius = 1
        Me.AddPurokBttn.IdleBorderThickness = 1
        Me.AddPurokBttn.IdleFillColor = System.Drawing.Color.DodgerBlue
        Me.AddPurokBttn.IdleIconLeftImage = Nothing
        Me.AddPurokBttn.IdleIconRightImage = Nothing
        Me.AddPurokBttn.IndicateFocus = False
        Me.AddPurokBttn.Location = New System.Drawing.Point(219, 117)
        Me.AddPurokBttn.Name = "AddPurokBttn"
        Me.AddPurokBttn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.AddPurokBttn.OnDisabledState.BorderRadius = 1
        Me.AddPurokBttn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.AddPurokBttn.OnDisabledState.BorderThickness = 1
        Me.AddPurokBttn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.AddPurokBttn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.AddPurokBttn.OnDisabledState.IconLeftImage = Nothing
        Me.AddPurokBttn.OnDisabledState.IconRightImage = Nothing
        Me.AddPurokBttn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AddPurokBttn.onHoverState.BorderRadius = 1
        Me.AddPurokBttn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.AddPurokBttn.onHoverState.BorderThickness = 1
        Me.AddPurokBttn.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AddPurokBttn.onHoverState.ForeColor = System.Drawing.Color.White
        Me.AddPurokBttn.onHoverState.IconLeftImage = Nothing
        Me.AddPurokBttn.onHoverState.IconRightImage = Nothing
        Me.AddPurokBttn.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue
        Me.AddPurokBttn.OnIdleState.BorderRadius = 1
        Me.AddPurokBttn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.AddPurokBttn.OnIdleState.BorderThickness = 1
        Me.AddPurokBttn.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue
        Me.AddPurokBttn.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.AddPurokBttn.OnIdleState.IconLeftImage = Nothing
        Me.AddPurokBttn.OnIdleState.IconRightImage = Nothing
        Me.AddPurokBttn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.AddPurokBttn.OnPressedState.BorderRadius = 1
        Me.AddPurokBttn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.AddPurokBttn.OnPressedState.BorderThickness = 1
        Me.AddPurokBttn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.AddPurokBttn.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.AddPurokBttn.OnPressedState.IconLeftImage = Nothing
        Me.AddPurokBttn.OnPressedState.IconRightImage = Nothing
        Me.AddPurokBttn.Size = New System.Drawing.Size(150, 34)
        Me.AddPurokBttn.TabIndex = 1
        Me.AddPurokBttn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AddPurokBttn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.AddPurokBttn.TextMarginLeft = 0
        Me.AddPurokBttn.TextPadding = New System.Windows.Forms.Padding(0)
        Me.AddPurokBttn.UseDefaultRadiusAndThickness = True
        '
        'UpdateBttn
        '
        Me.UpdateBttn.AllowAnimations = True
        Me.UpdateBttn.AllowMouseEffects = True
        Me.UpdateBttn.AllowToggling = False
        Me.UpdateBttn.AnimationSpeed = 200
        Me.UpdateBttn.AutoGenerateColors = False
        Me.UpdateBttn.AutoRoundBorders = False
        Me.UpdateBttn.AutoSizeLeftIcon = True
        Me.UpdateBttn.AutoSizeRightIcon = True
        Me.UpdateBttn.BackColor = System.Drawing.Color.Transparent
        Me.UpdateBttn.BackColor1 = System.Drawing.Color.DodgerBlue
        Me.UpdateBttn.BackgroundImage = CType(resources.GetObject("UpdateBttn.BackgroundImage"), System.Drawing.Image)
        Me.UpdateBttn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.UpdateBttn.ButtonText = "Update"
        Me.UpdateBttn.ButtonTextMarginLeft = 0
        Me.UpdateBttn.ColorContrastOnClick = 45
        Me.UpdateBttn.ColorContrastOnHover = 45
        Me.UpdateBttn.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges4.BottomLeft = True
        BorderEdges4.BottomRight = True
        BorderEdges4.TopLeft = True
        BorderEdges4.TopRight = True
        Me.UpdateBttn.CustomizableEdges = BorderEdges4
        Me.UpdateBttn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.UpdateBttn.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.UpdateBttn.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.UpdateBttn.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.UpdateBttn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.UpdateBttn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.UpdateBttn.ForeColor = System.Drawing.Color.White
        Me.UpdateBttn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UpdateBttn.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.UpdateBttn.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.UpdateBttn.IconMarginLeft = 11
        Me.UpdateBttn.IconPadding = 10
        Me.UpdateBttn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UpdateBttn.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.UpdateBttn.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.UpdateBttn.IconSize = 25
        Me.UpdateBttn.IdleBorderColor = System.Drawing.Color.DodgerBlue
        Me.UpdateBttn.IdleBorderRadius = 1
        Me.UpdateBttn.IdleBorderThickness = 1
        Me.UpdateBttn.IdleFillColor = System.Drawing.Color.DodgerBlue
        Me.UpdateBttn.IdleIconLeftImage = Nothing
        Me.UpdateBttn.IdleIconRightImage = Nothing
        Me.UpdateBttn.IndicateFocus = False
        Me.UpdateBttn.Location = New System.Drawing.Point(63, 117)
        Me.UpdateBttn.Name = "UpdateBttn"
        Me.UpdateBttn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.UpdateBttn.OnDisabledState.BorderRadius = 1
        Me.UpdateBttn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.UpdateBttn.OnDisabledState.BorderThickness = 1
        Me.UpdateBttn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.UpdateBttn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.UpdateBttn.OnDisabledState.IconLeftImage = Nothing
        Me.UpdateBttn.OnDisabledState.IconRightImage = Nothing
        Me.UpdateBttn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UpdateBttn.onHoverState.BorderRadius = 1
        Me.UpdateBttn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.UpdateBttn.onHoverState.BorderThickness = 1
        Me.UpdateBttn.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UpdateBttn.onHoverState.ForeColor = System.Drawing.Color.White
        Me.UpdateBttn.onHoverState.IconLeftImage = Nothing
        Me.UpdateBttn.onHoverState.IconRightImage = Nothing
        Me.UpdateBttn.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue
        Me.UpdateBttn.OnIdleState.BorderRadius = 1
        Me.UpdateBttn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.UpdateBttn.OnIdleState.BorderThickness = 1
        Me.UpdateBttn.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue
        Me.UpdateBttn.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.UpdateBttn.OnIdleState.IconLeftImage = Nothing
        Me.UpdateBttn.OnIdleState.IconRightImage = Nothing
        Me.UpdateBttn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.UpdateBttn.OnPressedState.BorderRadius = 1
        Me.UpdateBttn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.UpdateBttn.OnPressedState.BorderThickness = 1
        Me.UpdateBttn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.UpdateBttn.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.UpdateBttn.OnPressedState.IconLeftImage = Nothing
        Me.UpdateBttn.OnPressedState.IconRightImage = Nothing
        Me.UpdateBttn.Size = New System.Drawing.Size(150, 34)
        Me.UpdateBttn.TabIndex = 2
        Me.UpdateBttn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UpdateBttn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.UpdateBttn.TextMarginLeft = 0
        Me.UpdateBttn.TextPadding = New System.Windows.Forms.Padding(0)
        Me.UpdateBttn.UseDefaultRadiusAndThickness = True
        '
        'PurokChildForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(425, 175)
        Me.Controls.Add(Me.UpdateBttn)
        Me.Controls.Add(Me.AddPurokBttn)
        Me.Controls.Add(Me.AddPurokTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MinimizeBox = False
        Me.Name = "PurokChildForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADD PUROK"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AddPurokTextBox As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents AddPurokBttn As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents UpdateBttn As Bunifu.UI.WinForms.BunifuButton.BunifuButton
End Class
