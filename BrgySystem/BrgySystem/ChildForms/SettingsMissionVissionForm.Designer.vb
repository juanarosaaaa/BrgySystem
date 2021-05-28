<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsMissionVissionForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsMissionVissionForm))
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Me.BunifuLabel2 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.VisionRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.MissionRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.SaveButton = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        Me.BunifuLabel2.Location = New System.Drawing.Point(20, 40)
        Me.BunifuLabel2.Name = "BunifuLabel2"
        Me.BunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel2.Size = New System.Drawing.Size(65, 26)
        Me.BunifuLabel2.TabIndex = 1
        Me.BunifuLabel2.Text = "Mission"
        Me.BunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'VisionRichTextBox
        '
        Me.VisionRichTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.VisionRichTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.VisionRichTextBox.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VisionRichTextBox.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.VisionRichTextBox.Location = New System.Drawing.Point(19, 353)
        Me.VisionRichTextBox.Name = "VisionRichTextBox"
        Me.VisionRichTextBox.Size = New System.Drawing.Size(1088, 240)
        Me.VisionRichTextBox.TabIndex = 0
        Me.VisionRichTextBox.Text = resources.GetString("VisionRichTextBox.Text")
        '
        'MissionRichTextBox
        '
        Me.MissionRichTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MissionRichTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.MissionRichTextBox.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MissionRichTextBox.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.MissionRichTextBox.Location = New System.Drawing.Point(18, 66)
        Me.MissionRichTextBox.Name = "MissionRichTextBox"
        Me.MissionRichTextBox.Size = New System.Drawing.Size(1088, 240)
        Me.MissionRichTextBox.TabIndex = 0
        Me.MissionRichTextBox.Text = resources.GetString("MissionRichTextBox.Text")
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AllowParentOverrides = False
        Me.BunifuLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel1.Location = New System.Drawing.Point(20, 321)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(53, 26)
        Me.BunifuLabel1.TabIndex = 1
        Me.BunifuLabel1.Text = "Vision"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'SaveButton
        '
        Me.SaveButton.AllowAnimations = True
        Me.SaveButton.AllowMouseEffects = True
        Me.SaveButton.AllowToggling = False
        Me.SaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.AnimationSpeed = 200
        Me.SaveButton.AutoGenerateColors = False
        Me.SaveButton.AutoRoundBorders = False
        Me.SaveButton.AutoSizeLeftIcon = True
        Me.SaveButton.AutoSizeRightIcon = True
        Me.SaveButton.BackColor = System.Drawing.Color.Transparent
        Me.SaveButton.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.SaveButton.BackgroundImage = CType(resources.GetObject("SaveButton.BackgroundImage"), System.Drawing.Image)
        Me.SaveButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.SaveButton.ButtonText = "Save"
        Me.SaveButton.ButtonTextMarginLeft = 0
        Me.SaveButton.ColorContrastOnClick = 45
        Me.SaveButton.ColorContrastOnHover = 45
        Me.SaveButton.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.SaveButton.CustomizableEdges = BorderEdges1
        Me.SaveButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.SaveButton.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.SaveButton.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.SaveButton.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.SaveButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.SaveButton.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.ForeColor = System.Drawing.Color.White
        Me.SaveButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SaveButton.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.SaveButton.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.SaveButton.IconMarginLeft = 11
        Me.SaveButton.IconPadding = 10
        Me.SaveButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SaveButton.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.SaveButton.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.SaveButton.IconSize = 25
        Me.SaveButton.IdleBorderColor = System.Drawing.Color.Transparent
        Me.SaveButton.IdleBorderRadius = 50
        Me.SaveButton.IdleBorderThickness = 1
        Me.SaveButton.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.SaveButton.IdleIconLeftImage = Nothing
        Me.SaveButton.IdleIconRightImage = Nothing
        Me.SaveButton.IndicateFocus = False
        Me.SaveButton.Location = New System.Drawing.Point(923, 630)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.SaveButton.OnDisabledState.BorderRadius = 50
        Me.SaveButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.SaveButton.OnDisabledState.BorderThickness = 1
        Me.SaveButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.SaveButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.SaveButton.OnDisabledState.IconLeftImage = Nothing
        Me.SaveButton.OnDisabledState.IconRightImage = Nothing
        Me.SaveButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SaveButton.onHoverState.BorderRadius = 50
        Me.SaveButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.SaveButton.onHoverState.BorderThickness = 1
        Me.SaveButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SaveButton.onHoverState.ForeColor = System.Drawing.Color.White
        Me.SaveButton.onHoverState.IconLeftImage = Nothing
        Me.SaveButton.onHoverState.IconRightImage = Nothing
        Me.SaveButton.OnIdleState.BorderColor = System.Drawing.Color.Transparent
        Me.SaveButton.OnIdleState.BorderRadius = 50
        Me.SaveButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.SaveButton.OnIdleState.BorderThickness = 1
        Me.SaveButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.SaveButton.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.SaveButton.OnIdleState.IconLeftImage = Nothing
        Me.SaveButton.OnIdleState.IconRightImage = Nothing
        Me.SaveButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.SaveButton.OnPressedState.BorderRadius = 50
        Me.SaveButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.SaveButton.OnPressedState.BorderThickness = 1
        Me.SaveButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.SaveButton.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.SaveButton.OnPressedState.IconLeftImage = Nothing
        Me.SaveButton.OnPressedState.IconRightImage = Nothing
        Me.SaveButton.Size = New System.Drawing.Size(188, 37)
        Me.SaveButton.TabIndex = 3
        Me.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SaveButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.SaveButton.TextMarginLeft = 0
        Me.SaveButton.TextPadding = New System.Windows.Forms.Padding(0)
        Me.SaveButton.UseDefaultRadiusAndThickness = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.BunifuLabel2)
        Me.GroupBox1.Controls.Add(Me.SaveButton)
        Me.GroupBox1.Controls.Add(Me.BunifuLabel1)
        Me.GroupBox1.Controls.Add(Me.VisionRichTextBox)
        Me.GroupBox1.Controls.Add(Me.MissionRichTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(3, -2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1124, 677)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Barangay's Mission and Vision"
        '
        'SettingsMissionVissionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1127, 677)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SettingsMissionVissionForm"
        Me.Text = "SettingsMissionVissionForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SaveButton As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuLabel2 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents VisionRichTextBox As RichTextBox
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents MissionRichTextBox As RichTextBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
