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
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Me.PurokTextBox = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.AddPurokBttn = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.UpdateBttn = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'PurokTextBox
        '
        Me.PurokTextBox.AcceptsReturn = False
        Me.PurokTextBox.AcceptsTab = False
        Me.PurokTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PurokTextBox.AnimationSpeed = 200
        Me.PurokTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.PurokTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.PurokTextBox.BackColor = System.Drawing.Color.Transparent
        Me.PurokTextBox.BackgroundImage = CType(resources.GetObject("PurokTextBox.BackgroundImage"), System.Drawing.Image)
        Me.PurokTextBox.BorderColorActive = System.Drawing.Color.DodgerBlue
        Me.PurokTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.PurokTextBox.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PurokTextBox.BorderColorIdle = System.Drawing.Color.Silver
        Me.PurokTextBox.BorderRadius = 20
        Me.PurokTextBox.BorderThickness = 1
        Me.PurokTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.PurokTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PurokTextBox.DefaultFont = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PurokTextBox.DefaultText = ""
        Me.PurokTextBox.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.PurokTextBox.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.PurokTextBox.HideSelection = True
        Me.PurokTextBox.IconLeft = Nothing
        Me.PurokTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.PurokTextBox.IconPadding = 10
        Me.PurokTextBox.IconRight = Nothing
        Me.PurokTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.PurokTextBox.Lines = New String(-1) {}
        Me.PurokTextBox.Location = New System.Drawing.Point(19, 108)
        Me.PurokTextBox.MaxLength = 32767
        Me.PurokTextBox.MinimumSize = New System.Drawing.Size(1, 1)
        Me.PurokTextBox.Modified = False
        Me.PurokTextBox.Multiline = False
        Me.PurokTextBox.Name = "PurokTextBox"
        StateProperties1.BorderColor = System.Drawing.Color.DodgerBlue
        StateProperties1.FillColor = System.Drawing.Color.Empty
        StateProperties1.ForeColor = System.Drawing.Color.Empty
        StateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.PurokTextBox.OnActiveState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.PurokTextBox.OnDisabledState = StateProperties2
        StateProperties3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties3.FillColor = System.Drawing.Color.Empty
        StateProperties3.ForeColor = System.Drawing.Color.Empty
        StateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.PurokTextBox.OnHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.Silver
        StateProperties4.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        StateProperties4.ForeColor = System.Drawing.Color.WhiteSmoke
        StateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.PurokTextBox.OnIdleState = StateProperties4
        Me.PurokTextBox.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.PurokTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PurokTextBox.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.PurokTextBox.PlaceholderText = ""
        Me.PurokTextBox.ReadOnly = False
        Me.PurokTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.PurokTextBox.SelectedText = ""
        Me.PurokTextBox.SelectionLength = 0
        Me.PurokTextBox.SelectionStart = 0
        Me.PurokTextBox.ShortcutsEnabled = True
        Me.PurokTextBox.Size = New System.Drawing.Size(426, 42)
        Me.PurokTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu
        Me.PurokTextBox.TabIndex = 0
        Me.PurokTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.PurokTextBox.TextMarginBottom = 0
        Me.PurokTextBox.TextMarginLeft = 3
        Me.PurokTextBox.TextMarginTop = 0
        Me.PurokTextBox.TextPlaceholder = ""
        Me.PurokTextBox.UseSystemPasswordChar = False
        Me.PurokTextBox.WordWrap = True
        '
        'AddPurokBttn
        '
        Me.AddPurokBttn.AllowAnimations = True
        Me.AddPurokBttn.AllowMouseEffects = True
        Me.AddPurokBttn.AllowToggling = False
        Me.AddPurokBttn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.AddPurokBttn.AnimationSpeed = 200
        Me.AddPurokBttn.AutoGenerateColors = False
        Me.AddPurokBttn.AutoRoundBorders = True
        Me.AddPurokBttn.AutoSizeLeftIcon = True
        Me.AddPurokBttn.AutoSizeRightIcon = True
        Me.AddPurokBttn.BackColor = System.Drawing.Color.Transparent
        Me.AddPurokBttn.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.AddPurokBttn.BackgroundImage = CType(resources.GetObject("AddPurokBttn.BackgroundImage"), System.Drawing.Image)
        Me.AddPurokBttn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.AddPurokBttn.ButtonText = "Add"
        Me.AddPurokBttn.ButtonTextMarginLeft = 0
        Me.AddPurokBttn.ColorContrastOnClick = 45
        Me.AddPurokBttn.ColorContrastOnHover = 45
        Me.AddPurokBttn.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.AddPurokBttn.CustomizableEdges = BorderEdges1
        Me.AddPurokBttn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.AddPurokBttn.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.AddPurokBttn.DisabledFillColor = System.Drawing.Color.Transparent
        Me.AddPurokBttn.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.AddPurokBttn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.AddPurokBttn.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.AddPurokBttn.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.AddPurokBttn.IdleBorderRadius = 42
        Me.AddPurokBttn.IdleBorderThickness = 1
        Me.AddPurokBttn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.AddPurokBttn.IdleIconLeftImage = Nothing
        Me.AddPurokBttn.IdleIconRightImage = Nothing
        Me.AddPurokBttn.IndicateFocus = False
        Me.AddPurokBttn.Location = New System.Drawing.Point(240, 169)
        Me.AddPurokBttn.Name = "AddPurokBttn"
        Me.AddPurokBttn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.AddPurokBttn.OnDisabledState.BorderRadius = 1
        Me.AddPurokBttn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.AddPurokBttn.OnDisabledState.BorderThickness = 1
        Me.AddPurokBttn.OnDisabledState.FillColor = System.Drawing.Color.Transparent
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
        Me.AddPurokBttn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.AddPurokBttn.OnIdleState.BorderRadius = 1
        Me.AddPurokBttn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.AddPurokBttn.OnIdleState.BorderThickness = 1
        Me.AddPurokBttn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(245, Byte), Integer))
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
        Me.AddPurokBttn.Size = New System.Drawing.Size(173, 44)
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
        Me.UpdateBttn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UpdateBttn.AnimationSpeed = 200
        Me.UpdateBttn.AutoGenerateColors = False
        Me.UpdateBttn.AutoRoundBorders = True
        Me.UpdateBttn.AutoSizeLeftIcon = True
        Me.UpdateBttn.AutoSizeRightIcon = True
        Me.UpdateBttn.BackColor = System.Drawing.Color.Transparent
        Me.UpdateBttn.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.UpdateBttn.BackgroundImage = CType(resources.GetObject("UpdateBttn.BackgroundImage"), System.Drawing.Image)
        Me.UpdateBttn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.UpdateBttn.ButtonText = "Update"
        Me.UpdateBttn.ButtonTextMarginLeft = 0
        Me.UpdateBttn.ColorContrastOnClick = 45
        Me.UpdateBttn.ColorContrastOnHover = 45
        Me.UpdateBttn.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges2.BottomLeft = True
        BorderEdges2.BottomRight = True
        BorderEdges2.TopLeft = True
        BorderEdges2.TopRight = True
        Me.UpdateBttn.CustomizableEdges = BorderEdges2
        Me.UpdateBttn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.UpdateBttn.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.UpdateBttn.DisabledFillColor = System.Drawing.Color.Transparent
        Me.UpdateBttn.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.UpdateBttn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.UpdateBttn.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.UpdateBttn.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.UpdateBttn.IdleBorderRadius = 42
        Me.UpdateBttn.IdleBorderThickness = 1
        Me.UpdateBttn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.UpdateBttn.IdleIconLeftImage = Nothing
        Me.UpdateBttn.IdleIconRightImage = Nothing
        Me.UpdateBttn.IndicateFocus = False
        Me.UpdateBttn.Location = New System.Drawing.Point(48, 168)
        Me.UpdateBttn.Name = "UpdateBttn"
        Me.UpdateBttn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.UpdateBttn.OnDisabledState.BorderRadius = 1
        Me.UpdateBttn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.UpdateBttn.OnDisabledState.BorderThickness = 1
        Me.UpdateBttn.OnDisabledState.FillColor = System.Drawing.Color.Transparent
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
        Me.UpdateBttn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.UpdateBttn.OnIdleState.BorderRadius = 1
        Me.UpdateBttn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.UpdateBttn.OnIdleState.BorderThickness = 1
        Me.UpdateBttn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(245, Byte), Integer))
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
        Me.UpdateBttn.Size = New System.Drawing.Size(172, 44)
        Me.UpdateBttn.TabIndex = 2
        Me.UpdateBttn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UpdateBttn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.UpdateBttn.TextMarginLeft = 0
        Me.UpdateBttn.TextPadding = New System.Windows.Forms.Padding(0)
        Me.UpdateBttn.UseDefaultRadiusAndThickness = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(1221, 132)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 30)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Add Purok"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(176, 46)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 26)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Add Purok"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.HoverState.ForeColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Image = Global.BrgySystem.My.Resources.Resources.icons8_close_window_33px
        Me.Guna2Button1.ImageSize = New System.Drawing.Size(28, 28)
        Me.Guna2Button1.Location = New System.Drawing.Point(432, 10)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.PressedColor = System.Drawing.Color.White
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(22, 22)
        Me.Guna2Button1.TabIndex = 5
        '
        'PurokChildForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(463, 241)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UpdateBttn)
        Me.Controls.Add(Me.AddPurokBttn)
        Me.Controls.Add(Me.PurokTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimizeBox = False
        Me.Name = "PurokChildForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PurokTextBox As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents AddPurokBttn As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents UpdateBttn As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class
