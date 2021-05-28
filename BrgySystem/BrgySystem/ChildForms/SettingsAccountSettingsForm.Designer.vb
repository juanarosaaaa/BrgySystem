<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsAccountSettingsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsAccountSettingsForm))
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Me.BunifuLabel2 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel3 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.NewPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BunifuLabel4 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.ConfirmPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BunifuLabel5 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SubmitButton = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.UsernametextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CurrentPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuLabel2
        '
        Me.BunifuLabel2.AllowParentOverrides = False
        Me.BunifuLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BunifuLabel2.AutoEllipsis = False
        Me.BunifuLabel2.CursorType = Nothing
        Me.BunifuLabel2.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel2.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel2.Location = New System.Drawing.Point(321, 173)
        Me.BunifuLabel2.Name = "BunifuLabel2"
        Me.BunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel2.Size = New System.Drawing.Size(153, 26)
        Me.BunifuLabel2.TabIndex = 1
        Me.BunifuLabel2.Text = "Current Password:"
        Me.BunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel3
        '
        Me.BunifuLabel3.AllowParentOverrides = False
        Me.BunifuLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BunifuLabel3.AutoEllipsis = False
        Me.BunifuLabel3.CursorType = Nothing
        Me.BunifuLabel3.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel3.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel3.Location = New System.Drawing.Point(323, 94)
        Me.BunifuLabel3.Name = "BunifuLabel3"
        Me.BunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel3.Size = New System.Drawing.Size(90, 26)
        Me.BunifuLabel3.TabIndex = 1
        Me.BunifuLabel3.Text = "Username:"
        Me.BunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'NewPassword
        '
        Me.NewPassword.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.NewPassword.BorderRadius = 10
        Me.NewPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NewPassword.DefaultText = ""
        Me.NewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.NewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.NewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NewPassword.DisabledState.Parent = Me.NewPassword
        Me.NewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NewPassword.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.NewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NewPassword.FocusedState.Parent = Me.NewPassword
        Me.NewPassword.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NewPassword.HoverState.Parent = Me.NewPassword
        Me.NewPassword.IconLeft = Global.BrgySystem.My.Resources.Resources.icons8_password_30px
        Me.NewPassword.IconLeftOffset = New System.Drawing.Point(3, 0)
        Me.NewPassword.IconLeftSize = New System.Drawing.Size(28, 28)
        Me.NewPassword.Location = New System.Drawing.Point(321, 278)
        Me.NewPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.NewPassword.Name = "NewPassword"
        Me.NewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.NewPassword.PlaceholderText = ""
        Me.NewPassword.SelectedText = ""
        Me.NewPassword.ShadowDecoration.Parent = Me.NewPassword
        Me.NewPassword.Size = New System.Drawing.Size(480, 40)
        Me.NewPassword.TabIndex = 0
        Me.NewPassword.UseSystemPasswordChar = True
        '
        'BunifuLabel4
        '
        Me.BunifuLabel4.AllowParentOverrides = False
        Me.BunifuLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BunifuLabel4.AutoEllipsis = False
        Me.BunifuLabel4.CursorType = Nothing
        Me.BunifuLabel4.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel4.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel4.Location = New System.Drawing.Point(320, 250)
        Me.BunifuLabel4.Name = "BunifuLabel4"
        Me.BunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel4.Size = New System.Drawing.Size(130, 26)
        Me.BunifuLabel4.TabIndex = 1
        Me.BunifuLabel4.Text = "New Password:"
        Me.BunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'ConfirmPassword
        '
        Me.ConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ConfirmPassword.BorderRadius = 10
        Me.ConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ConfirmPassword.DefaultText = ""
        Me.ConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ConfirmPassword.DisabledState.Parent = Me.ConfirmPassword
        Me.ConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ConfirmPassword.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ConfirmPassword.FocusedState.Parent = Me.ConfirmPassword
        Me.ConfirmPassword.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ConfirmPassword.HoverState.Parent = Me.ConfirmPassword
        Me.ConfirmPassword.IconLeft = Global.BrgySystem.My.Resources.Resources.icons8_password_30px
        Me.ConfirmPassword.IconLeftOffset = New System.Drawing.Point(3, 0)
        Me.ConfirmPassword.IconLeftSize = New System.Drawing.Size(28, 28)
        Me.ConfirmPassword.IconRightOffset = New System.Drawing.Point(4, 0)
        Me.ConfirmPassword.Location = New System.Drawing.Point(320, 353)
        Me.ConfirmPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.ConfirmPassword.Name = "ConfirmPassword"
        Me.ConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ConfirmPassword.PlaceholderText = ""
        Me.ConfirmPassword.SelectedText = ""
        Me.ConfirmPassword.ShadowDecoration.Parent = Me.ConfirmPassword
        Me.ConfirmPassword.Size = New System.Drawing.Size(481, 45)
        Me.ConfirmPassword.TabIndex = 0
        Me.ConfirmPassword.UseSystemPasswordChar = True
        '
        'BunifuLabel5
        '
        Me.BunifuLabel5.AllowParentOverrides = False
        Me.BunifuLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BunifuLabel5.AutoEllipsis = False
        Me.BunifuLabel5.CursorType = Nothing
        Me.BunifuLabel5.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel5.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel5.Location = New System.Drawing.Point(320, 323)
        Me.BunifuLabel5.Name = "BunifuLabel5"
        Me.BunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel5.Size = New System.Drawing.Size(158, 26)
        Me.BunifuLabel5.TabIndex = 1
        Me.BunifuLabel5.Text = "Confirm Password:"
        Me.BunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.SubmitButton)
        Me.GroupBox1.Controls.Add(Me.UsernametextBox)
        Me.GroupBox1.Controls.Add(Me.ConfirmPassword)
        Me.GroupBox1.Controls.Add(Me.CurrentPassword)
        Me.GroupBox1.Controls.Add(Me.NewPassword)
        Me.GroupBox1.Controls.Add(Me.BunifuLabel3)
        Me.GroupBox1.Controls.Add(Me.BunifuLabel5)
        Me.GroupBox1.Controls.Add(Me.BunifuLabel4)
        Me.GroupBox1.Controls.Add(Me.BunifuLabel2)
        Me.GroupBox1.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Location = New System.Drawing.Point(3, -3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1123, 649)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Change Password"
        '
        'SubmitButton
        '
        Me.SubmitButton.AllowAnimations = True
        Me.SubmitButton.AllowMouseEffects = True
        Me.SubmitButton.AllowToggling = False
        Me.SubmitButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SubmitButton.AnimationSpeed = 200
        Me.SubmitButton.AutoGenerateColors = False
        Me.SubmitButton.AutoRoundBorders = True
        Me.SubmitButton.AutoSizeLeftIcon = True
        Me.SubmitButton.AutoSizeRightIcon = True
        Me.SubmitButton.BackColor = System.Drawing.Color.Transparent
        Me.SubmitButton.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.SubmitButton.BackgroundImage = CType(resources.GetObject("SubmitButton.BackgroundImage"), System.Drawing.Image)
        Me.SubmitButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.SubmitButton.ButtonText = "Submit"
        Me.SubmitButton.ButtonTextMarginLeft = 0
        Me.SubmitButton.ColorContrastOnClick = 45
        Me.SubmitButton.ColorContrastOnHover = 45
        Me.SubmitButton.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.SubmitButton.CustomizableEdges = BorderEdges1
        Me.SubmitButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.SubmitButton.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.SubmitButton.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.SubmitButton.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.SubmitButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.SubmitButton.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubmitButton.ForeColor = System.Drawing.Color.White
        Me.SubmitButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SubmitButton.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.SubmitButton.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.SubmitButton.IconMarginLeft = 11
        Me.SubmitButton.IconPadding = 10
        Me.SubmitButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SubmitButton.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.SubmitButton.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.SubmitButton.IconSize = 25
        Me.SubmitButton.IdleBorderColor = System.Drawing.Color.Transparent
        Me.SubmitButton.IdleBorderRadius = 42
        Me.SubmitButton.IdleBorderThickness = 1
        Me.SubmitButton.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.SubmitButton.IdleIconLeftImage = Nothing
        Me.SubmitButton.IdleIconRightImage = Nothing
        Me.SubmitButton.IndicateFocus = False
        Me.SubmitButton.Location = New System.Drawing.Point(910, 582)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.SubmitButton.OnDisabledState.BorderRadius = 1
        Me.SubmitButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.SubmitButton.OnDisabledState.BorderThickness = 1
        Me.SubmitButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.SubmitButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.SubmitButton.OnDisabledState.IconLeftImage = Nothing
        Me.SubmitButton.OnDisabledState.IconRightImage = Nothing
        Me.SubmitButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SubmitButton.onHoverState.BorderRadius = 1
        Me.SubmitButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.SubmitButton.onHoverState.BorderThickness = 1
        Me.SubmitButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SubmitButton.onHoverState.ForeColor = System.Drawing.Color.White
        Me.SubmitButton.onHoverState.IconLeftImage = Nothing
        Me.SubmitButton.onHoverState.IconRightImage = Nothing
        Me.SubmitButton.OnIdleState.BorderColor = System.Drawing.Color.Transparent
        Me.SubmitButton.OnIdleState.BorderRadius = 1
        Me.SubmitButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.SubmitButton.OnIdleState.BorderThickness = 1
        Me.SubmitButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.SubmitButton.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.SubmitButton.OnIdleState.IconLeftImage = Nothing
        Me.SubmitButton.OnIdleState.IconRightImage = Nothing
        Me.SubmitButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.SubmitButton.OnPressedState.BorderRadius = 1
        Me.SubmitButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.SubmitButton.OnPressedState.BorderThickness = 1
        Me.SubmitButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.SubmitButton.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.SubmitButton.OnPressedState.IconLeftImage = Nothing
        Me.SubmitButton.OnPressedState.IconRightImage = Nothing
        Me.SubmitButton.Size = New System.Drawing.Size(188, 44)
        Me.SubmitButton.TabIndex = 2
        Me.SubmitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SubmitButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.SubmitButton.TextMarginLeft = 0
        Me.SubmitButton.TextPadding = New System.Windows.Forms.Padding(0)
        Me.SubmitButton.UseDefaultRadiusAndThickness = True
        '
        'UsernametextBox
        '
        Me.UsernametextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UsernametextBox.BorderRadius = 10
        Me.UsernametextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UsernametextBox.DefaultText = ""
        Me.UsernametextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UsernametextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.UsernametextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UsernametextBox.DisabledState.Parent = Me.UsernametextBox
        Me.UsernametextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UsernametextBox.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.UsernametextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UsernametextBox.FocusedState.Parent = Me.UsernametextBox
        Me.UsernametextBox.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernametextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UsernametextBox.HoverState.Parent = Me.UsernametextBox
        Me.UsernametextBox.IconLeft = Global.BrgySystem.My.Resources.Resources.icons8_user_male_30px1
        Me.UsernametextBox.IconLeftOffset = New System.Drawing.Point(2, 0)
        Me.UsernametextBox.IconLeftSize = New System.Drawing.Size(30, 30)
        Me.UsernametextBox.Location = New System.Drawing.Point(323, 124)
        Me.UsernametextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.UsernametextBox.Name = "UsernametextBox"
        Me.UsernametextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UsernametextBox.PlaceholderText = ""
        Me.UsernametextBox.SelectedText = ""
        Me.UsernametextBox.ShadowDecoration.Parent = Me.UsernametextBox
        Me.UsernametextBox.Size = New System.Drawing.Size(478, 44)
        Me.UsernametextBox.TabIndex = 0
        '
        'CurrentPassword
        '
        Me.CurrentPassword.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CurrentPassword.BorderRadius = 10
        Me.CurrentPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CurrentPassword.DefaultText = ""
        Me.CurrentPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CurrentPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CurrentPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CurrentPassword.DisabledState.Parent = Me.CurrentPassword
        Me.CurrentPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CurrentPassword.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.CurrentPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CurrentPassword.FocusedState.Parent = Me.CurrentPassword
        Me.CurrentPassword.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CurrentPassword.HoverState.Parent = Me.CurrentPassword
        Me.CurrentPassword.IconLeft = Global.BrgySystem.My.Resources.Resources.icons8_password_30px
        Me.CurrentPassword.IconLeftOffset = New System.Drawing.Point(2, 0)
        Me.CurrentPassword.IconLeftSize = New System.Drawing.Size(28, 28)
        Me.CurrentPassword.Location = New System.Drawing.Point(323, 202)
        Me.CurrentPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.CurrentPassword.Name = "CurrentPassword"
        Me.CurrentPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.CurrentPassword.PlaceholderText = ""
        Me.CurrentPassword.SelectedText = ""
        Me.CurrentPassword.ShadowDecoration.Parent = Me.CurrentPassword
        Me.CurrentPassword.Size = New System.Drawing.Size(478, 41)
        Me.CurrentPassword.TabIndex = 0
        Me.CurrentPassword.UseSystemPasswordChar = True
        '
        'SettingsAccountSettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1127, 647)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SettingsAccountSettingsForm"
        Me.Text = "SettingsAccountSettingsForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UsernametextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CurrentPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BunifuLabel2 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel3 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents NewPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BunifuLabel4 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents ConfirmPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BunifuLabel5 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents SubmitButton As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents GroupBox1 As GroupBox
End Class
