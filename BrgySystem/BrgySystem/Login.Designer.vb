<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties5 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties6 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties7 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties8 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.passwordTextBox = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.userNameTextBox = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.LoginButton = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.SuspendLayout()
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AllowParentOverrides = False
        Me.BunifuLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel1.Location = New System.Drawing.Point(70, 31)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(274, 40)
        Me.BunifuLabel1.TabIndex = 3
        Me.BunifuLabel1.Text = "Admin Panel Login"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'passwordTextBox
        '
        Me.passwordTextBox.AcceptsReturn = False
        Me.passwordTextBox.AcceptsTab = False
        Me.passwordTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.passwordTextBox.AnimationSpeed = 200
        Me.passwordTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.passwordTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.passwordTextBox.BackColor = System.Drawing.Color.Transparent
        Me.passwordTextBox.BackgroundImage = CType(resources.GetObject("passwordTextBox.BackgroundImage"), System.Drawing.Image)
        Me.passwordTextBox.BorderColorActive = System.Drawing.Color.DodgerBlue
        Me.passwordTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.passwordTextBox.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.passwordTextBox.BorderColorIdle = System.Drawing.Color.Silver
        Me.passwordTextBox.BorderRadius = 1
        Me.passwordTextBox.BorderThickness = 1
        Me.passwordTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.passwordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.passwordTextBox.DefaultFont = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.passwordTextBox.DefaultText = ""
        Me.passwordTextBox.FillColor = System.Drawing.Color.White
        Me.passwordTextBox.HideSelection = True
        Me.passwordTextBox.IconLeft = Global.BrgySystem.My.Resources.Resources.icons8_password_24px
        Me.passwordTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.passwordTextBox.IconPadding = 10
        Me.passwordTextBox.IconRight = Nothing
        Me.passwordTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.passwordTextBox.Lines = New String(-1) {}
        Me.passwordTextBox.Location = New System.Drawing.Point(12, 149)
        Me.passwordTextBox.MaxLength = 32767
        Me.passwordTextBox.MinimumSize = New System.Drawing.Size(1, 1)
        Me.passwordTextBox.Modified = False
        Me.passwordTextBox.Multiline = False
        Me.passwordTextBox.Name = "passwordTextBox"
        StateProperties1.BorderColor = System.Drawing.Color.DodgerBlue
        StateProperties1.FillColor = System.Drawing.Color.Empty
        StateProperties1.ForeColor = System.Drawing.Color.Empty
        StateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.passwordTextBox.OnActiveState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.passwordTextBox.OnDisabledState = StateProperties2
        StateProperties3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties3.FillColor = System.Drawing.Color.Empty
        StateProperties3.ForeColor = System.Drawing.Color.Empty
        StateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.passwordTextBox.OnHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.Silver
        StateProperties4.FillColor = System.Drawing.Color.White
        StateProperties4.ForeColor = System.Drawing.Color.Empty
        StateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.passwordTextBox.OnIdleState = StateProperties4
        Me.passwordTextBox.Padding = New System.Windows.Forms.Padding(3)
        Me.passwordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.passwordTextBox.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.passwordTextBox.PlaceholderText = ""
        Me.passwordTextBox.ReadOnly = False
        Me.passwordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.passwordTextBox.SelectedText = ""
        Me.passwordTextBox.SelectionLength = 0
        Me.passwordTextBox.SelectionStart = 0
        Me.passwordTextBox.ShortcutsEnabled = True
        Me.passwordTextBox.Size = New System.Drawing.Size(388, 37)
        Me.passwordTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu
        Me.passwordTextBox.TabIndex = 2
        Me.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.passwordTextBox.TextMarginBottom = 0
        Me.passwordTextBox.TextMarginLeft = 3
        Me.passwordTextBox.TextMarginTop = 0
        Me.passwordTextBox.TextPlaceholder = ""
        Me.passwordTextBox.UseSystemPasswordChar = True
        Me.passwordTextBox.WordWrap = True
        '
        'userNameTextBox
        '
        Me.userNameTextBox.AcceptsReturn = False
        Me.userNameTextBox.AcceptsTab = False
        Me.userNameTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.userNameTextBox.AnimationSpeed = 200
        Me.userNameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.userNameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.userNameTextBox.BackColor = System.Drawing.Color.Transparent
        Me.userNameTextBox.BackgroundImage = CType(resources.GetObject("userNameTextBox.BackgroundImage"), System.Drawing.Image)
        Me.userNameTextBox.BorderColorActive = System.Drawing.Color.DodgerBlue
        Me.userNameTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.userNameTextBox.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.userNameTextBox.BorderColorIdle = System.Drawing.Color.Silver
        Me.userNameTextBox.BorderRadius = 1
        Me.userNameTextBox.BorderThickness = 1
        Me.userNameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.userNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.userNameTextBox.DefaultFont = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.userNameTextBox.DefaultText = ""
        Me.userNameTextBox.FillColor = System.Drawing.Color.White
        Me.userNameTextBox.HideSelection = True
        Me.userNameTextBox.IconLeft = Global.BrgySystem.My.Resources.Resources.icons8_user_28px_1
        Me.userNameTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.userNameTextBox.IconPadding = 10
        Me.userNameTextBox.IconRight = Nothing
        Me.userNameTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.userNameTextBox.Lines = New String(-1) {}
        Me.userNameTextBox.Location = New System.Drawing.Point(12, 106)
        Me.userNameTextBox.MaxLength = 32767
        Me.userNameTextBox.MinimumSize = New System.Drawing.Size(1, 1)
        Me.userNameTextBox.Modified = False
        Me.userNameTextBox.Multiline = False
        Me.userNameTextBox.Name = "userNameTextBox"
        StateProperties5.BorderColor = System.Drawing.Color.DodgerBlue
        StateProperties5.FillColor = System.Drawing.Color.Empty
        StateProperties5.ForeColor = System.Drawing.Color.Empty
        StateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.userNameTextBox.OnActiveState = StateProperties5
        StateProperties6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        StateProperties6.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.userNameTextBox.OnDisabledState = StateProperties6
        StateProperties7.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties7.FillColor = System.Drawing.Color.Empty
        StateProperties7.ForeColor = System.Drawing.Color.Empty
        StateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.userNameTextBox.OnHoverState = StateProperties7
        StateProperties8.BorderColor = System.Drawing.Color.Silver
        StateProperties8.FillColor = System.Drawing.Color.White
        StateProperties8.ForeColor = System.Drawing.Color.Empty
        StateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.userNameTextBox.OnIdleState = StateProperties8
        Me.userNameTextBox.Padding = New System.Windows.Forms.Padding(3)
        Me.userNameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.userNameTextBox.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.userNameTextBox.PlaceholderText = ""
        Me.userNameTextBox.ReadOnly = False
        Me.userNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.userNameTextBox.SelectedText = ""
        Me.userNameTextBox.SelectionLength = 0
        Me.userNameTextBox.SelectionStart = 0
        Me.userNameTextBox.ShortcutsEnabled = True
        Me.userNameTextBox.Size = New System.Drawing.Size(388, 37)
        Me.userNameTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu
        Me.userNameTextBox.TabIndex = 1
        Me.userNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.userNameTextBox.TextMarginBottom = 0
        Me.userNameTextBox.TextMarginLeft = 3
        Me.userNameTextBox.TextMarginTop = 0
        Me.userNameTextBox.TextPlaceholder = ""
        Me.userNameTextBox.UseSystemPasswordChar = False
        Me.userNameTextBox.WordWrap = True
        '
        'LoginButton
        '
        Me.LoginButton.AllowAnimations = True
        Me.LoginButton.AllowMouseEffects = True
        Me.LoginButton.AllowToggling = False
        Me.LoginButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.LoginButton.AnimationSpeed = 200
        Me.LoginButton.AutoGenerateColors = False
        Me.LoginButton.AutoRoundBorders = False
        Me.LoginButton.AutoSizeLeftIcon = True
        Me.LoginButton.AutoSizeRightIcon = True
        Me.LoginButton.BackColor = System.Drawing.Color.Transparent
        Me.LoginButton.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.LoginButton.BackgroundImage = CType(resources.GetObject("LoginButton.BackgroundImage"), System.Drawing.Image)
        Me.LoginButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.LoginButton.ButtonText = "Login"
        Me.LoginButton.ButtonTextMarginLeft = 0
        Me.LoginButton.ColorContrastOnClick = 45
        Me.LoginButton.ColorContrastOnHover = 45
        Me.LoginButton.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.LoginButton.CustomizableEdges = BorderEdges1
        Me.LoginButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.LoginButton.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.LoginButton.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.LoginButton.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.LoginButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.LoginButton.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginButton.ForeColor = System.Drawing.Color.White
        Me.LoginButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LoginButton.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.LoginButton.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.LoginButton.IconMarginLeft = 11
        Me.LoginButton.IconPadding = 10
        Me.LoginButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LoginButton.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.LoginButton.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.LoginButton.IconSize = 25
        Me.LoginButton.IdleBorderColor = System.Drawing.Color.Transparent
        Me.LoginButton.IdleBorderRadius = 1
        Me.LoginButton.IdleBorderThickness = 1
        Me.LoginButton.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.LoginButton.IdleIconLeftImage = Nothing
        Me.LoginButton.IdleIconRightImage = Nothing
        Me.LoginButton.IndicateFocus = False
        Me.LoginButton.Location = New System.Drawing.Point(122, 209)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.LoginButton.OnDisabledState.BorderRadius = 1
        Me.LoginButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.LoginButton.OnDisabledState.BorderThickness = 1
        Me.LoginButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.LoginButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.LoginButton.OnDisabledState.IconLeftImage = Nothing
        Me.LoginButton.OnDisabledState.IconRightImage = Nothing
        Me.LoginButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LoginButton.onHoverState.BorderRadius = 1
        Me.LoginButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.LoginButton.onHoverState.BorderThickness = 1
        Me.LoginButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LoginButton.onHoverState.ForeColor = System.Drawing.Color.White
        Me.LoginButton.onHoverState.IconLeftImage = Nothing
        Me.LoginButton.onHoverState.IconRightImage = Nothing
        Me.LoginButton.OnIdleState.BorderColor = System.Drawing.Color.Transparent
        Me.LoginButton.OnIdleState.BorderRadius = 1
        Me.LoginButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.LoginButton.OnIdleState.BorderThickness = 1
        Me.LoginButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.LoginButton.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.LoginButton.OnIdleState.IconLeftImage = Nothing
        Me.LoginButton.OnIdleState.IconRightImage = Nothing
        Me.LoginButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.LoginButton.OnPressedState.BorderRadius = 1
        Me.LoginButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.LoginButton.OnPressedState.BorderThickness = 1
        Me.LoginButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.LoginButton.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.LoginButton.OnPressedState.IconLeftImage = Nothing
        Me.LoginButton.OnPressedState.IconRightImage = Nothing
        Me.LoginButton.Size = New System.Drawing.Size(168, 41)
        Me.LoginButton.TabIndex = 0
        Me.LoginButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LoginButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.LoginButton.TextMarginLeft = 0
        Me.LoginButton.TextPadding = New System.Windows.Forms.Padding(0)
        Me.LoginButton.UseDefaultRadiusAndThickness = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(412, 285)
        Me.Controls.Add(Me.BunifuLabel1)
        Me.Controls.Add(Me.passwordTextBox)
        Me.Controls.Add(Me.userNameTextBox)
        Me.Controls.Add(Me.LoginButton)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LoginButton As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents userNameTextBox As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents passwordTextBox As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
End Class
