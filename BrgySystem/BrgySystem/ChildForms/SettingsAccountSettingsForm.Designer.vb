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
        Me.UsernametextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CurrentPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BunifuLabel2 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel3 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.NewPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BunifuLabel4 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.ConfirmPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BunifuLabel5 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.SubmitButton = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UsernametextBox
        '
        Me.UsernametextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        Me.UsernametextBox.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernametextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UsernametextBox.HoverState.Parent = Me.UsernametextBox
        Me.UsernametextBox.Location = New System.Drawing.Point(176, 4)
        Me.UsernametextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UsernametextBox.Name = "UsernametextBox"
        Me.UsernametextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UsernametextBox.PlaceholderText = ""
        Me.UsernametextBox.SelectedText = ""
        Me.UsernametextBox.ShadowDecoration.Parent = Me.UsernametextBox
        Me.UsernametextBox.Size = New System.Drawing.Size(373, 38)
        Me.UsernametextBox.TabIndex = 0
        '
        'CurrentPassword
        '
        Me.CurrentPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        Me.CurrentPassword.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CurrentPassword.HoverState.Parent = Me.CurrentPassword
        Me.CurrentPassword.Location = New System.Drawing.Point(176, 50)
        Me.CurrentPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CurrentPassword.Name = "CurrentPassword"
        Me.CurrentPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.CurrentPassword.PlaceholderText = ""
        Me.CurrentPassword.SelectedText = ""
        Me.CurrentPassword.ShadowDecoration.Parent = Me.CurrentPassword
        Me.CurrentPassword.Size = New System.Drawing.Size(373, 39)
        Me.CurrentPassword.TabIndex = 0
        Me.CurrentPassword.UseSystemPasswordChar = True
        '
        'BunifuLabel2
        '
        Me.BunifuLabel2.AllowParentOverrides = False
        Me.BunifuLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BunifuLabel2.AutoEllipsis = False
        Me.BunifuLabel2.CursorType = Nothing
        Me.BunifuLabel2.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel2.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel2.Location = New System.Drawing.Point(23, 57)
        Me.BunifuLabel2.Name = "BunifuLabel2"
        Me.BunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel2.Size = New System.Drawing.Size(146, 25)
        Me.BunifuLabel2.TabIndex = 1
        Me.BunifuLabel2.Text = "Current Password:"
        Me.BunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel3
        '
        Me.BunifuLabel3.AllowParentOverrides = False
        Me.BunifuLabel3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BunifuLabel3.AutoEllipsis = False
        Me.BunifuLabel3.CursorType = Nothing
        Me.BunifuLabel3.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel3.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel3.Location = New System.Drawing.Point(82, 10)
        Me.BunifuLabel3.Name = "BunifuLabel3"
        Me.BunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel3.Size = New System.Drawing.Size(87, 25)
        Me.BunifuLabel3.TabIndex = 1
        Me.BunifuLabel3.Text = "Username:"
        Me.BunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'NewPassword
        '
        Me.NewPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        Me.NewPassword.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NewPassword.HoverState.Parent = Me.NewPassword
        Me.NewPassword.Location = New System.Drawing.Point(176, 97)
        Me.NewPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NewPassword.Name = "NewPassword"
        Me.NewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.NewPassword.PlaceholderText = ""
        Me.NewPassword.SelectedText = ""
        Me.NewPassword.ShadowDecoration.Parent = Me.NewPassword
        Me.NewPassword.Size = New System.Drawing.Size(373, 35)
        Me.NewPassword.TabIndex = 0
        Me.NewPassword.UseSystemPasswordChar = True
        '
        'BunifuLabel4
        '
        Me.BunifuLabel4.AllowParentOverrides = False
        Me.BunifuLabel4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BunifuLabel4.AutoEllipsis = False
        Me.BunifuLabel4.CursorType = Nothing
        Me.BunifuLabel4.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel4.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel4.Location = New System.Drawing.Point(46, 102)
        Me.BunifuLabel4.Name = "BunifuLabel4"
        Me.BunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel4.Size = New System.Drawing.Size(123, 25)
        Me.BunifuLabel4.TabIndex = 1
        Me.BunifuLabel4.Text = "New Password:"
        Me.BunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'ConfirmPassword
        '
        Me.ConfirmPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        Me.ConfirmPassword.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ConfirmPassword.HoverState.Parent = Me.ConfirmPassword
        Me.ConfirmPassword.Location = New System.Drawing.Point(176, 140)
        Me.ConfirmPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ConfirmPassword.Name = "ConfirmPassword"
        Me.ConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ConfirmPassword.PlaceholderText = ""
        Me.ConfirmPassword.SelectedText = ""
        Me.ConfirmPassword.ShadowDecoration.Parent = Me.ConfirmPassword
        Me.ConfirmPassword.Size = New System.Drawing.Size(373, 36)
        Me.ConfirmPassword.TabIndex = 0
        Me.ConfirmPassword.UseSystemPasswordChar = True
        '
        'BunifuLabel5
        '
        Me.BunifuLabel5.AllowParentOverrides = False
        Me.BunifuLabel5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BunifuLabel5.AutoEllipsis = False
        Me.BunifuLabel5.CursorType = Nothing
        Me.BunifuLabel5.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel5.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel5.Location = New System.Drawing.Point(18, 145)
        Me.BunifuLabel5.Name = "BunifuLabel5"
        Me.BunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel5.Size = New System.Drawing.Size(151, 25)
        Me.BunifuLabel5.TabIndex = 1
        Me.BunifuLabel5.Text = "Confirm Password:"
        Me.BunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
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
        Me.SubmitButton.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.SubmitButton.Location = New System.Drawing.Point(416, 291)
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
        Me.SubmitButton.Size = New System.Drawing.Size(157, 44)
        Me.SubmitButton.TabIndex = 2
        Me.SubmitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SubmitButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.SubmitButton.TextMarginLeft = 0
        Me.SubmitButton.TextPadding = New System.Windows.Forms.Padding(0)
        Me.SubmitButton.UseDefaultRadiusAndThickness = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.93311!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.06689!))
        Me.TableLayoutPanel1.Controls.Add(Me.UsernametextBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.SubmitButton, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.CurrentPassword, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.BunifuLabel3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ConfirmPassword, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.BunifuLabel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.BunifuLabel4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.BunifuLabel5, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.NewPassword, 1, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(250, 114)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(100, 3, 3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.60947!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.90533!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.72189!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.01775!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.4497!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(576, 338)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Location = New System.Drawing.Point(12, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1077, 609)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Change Password"
        '
        'SettingsAccountSettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1101, 626)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SettingsAccountSettingsForm"
        Me.Text = "SettingsAccountSettingsForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
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
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
End Class
