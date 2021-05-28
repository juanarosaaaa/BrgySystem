<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.LiveDateAndTime = New Bunifu.UI.WinForms.BunifuLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuGradientPanel5 = New Bunifu.UI.WinForms.BunifuGradientPanel()
        Me.RichTextBoxVision = New System.Windows.Forms.RichTextBox()
        Me.BunifuLabel10 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuGradientPanel4 = New Bunifu.UI.WinForms.BunifuGradientPanel()
        Me.RichTextBoxMission = New System.Windows.Forms.RichTextBox()
        Me.BunifuLabel8 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuGradientPanel3 = New Bunifu.UI.WinForms.BunifuGradientPanel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.lblCountPurok = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel7 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuGradientPanel6 = New Bunifu.UI.WinForms.BunifuGradientPanel()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.lblCountClearance = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel11 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.ResBttn = New Bunifu.UI.WinForms.BunifuGradientPanel()
        Me.ResBttn1 = New Guna.UI2.WinForms.Guna2Button()
        Me.lblCountResidents = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel2 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuGradientPanel5.SuspendLayout()
        Me.BunifuGradientPanel4.SuspendLayout()
        Me.BunifuGradientPanel3.SuspendLayout()
        Me.BunifuGradientPanel6.SuspendLayout()
        Me.ResBttn.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AllowParentOverrides = False
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.CursorType = Nothing
        Me.BunifuLabel1.Font = New System.Drawing.Font("Palatino Linotype", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel1.Location = New System.Drawing.Point(23, 30)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(170, 47)
        Me.BunifuLabel1.TabIndex = 1
        Me.BunifuLabel1.Text = "Dashboard"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'LiveDateAndTime
        '
        Me.LiveDateAndTime.AllowParentOverrides = False
        Me.LiveDateAndTime.AutoEllipsis = False
        Me.LiveDateAndTime.Cursor = System.Windows.Forms.Cursors.Default
        Me.LiveDateAndTime.CursorType = System.Windows.Forms.Cursors.Default
        Me.LiveDateAndTime.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LiveDateAndTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LiveDateAndTime.Location = New System.Drawing.Point(23, 69)
        Me.LiveDateAndTime.Name = "LiveDateAndTime"
        Me.LiveDateAndTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LiveDateAndTime.Size = New System.Drawing.Size(258, 26)
        Me.LiveDateAndTime.TabIndex = 5
        Me.LiveDateAndTime.Text = "TODAY IS 9/9/1111 12:00 AM"
        Me.LiveDateAndTime.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LiveDateAndTime.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'BunifuGradientPanel5
        '
        Me.BunifuGradientPanel5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BunifuGradientPanel5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuGradientPanel5.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel5.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel5.BorderRadius = 30
        Me.BunifuGradientPanel5.Controls.Add(Me.RichTextBoxVision)
        Me.BunifuGradientPanel5.Controls.Add(Me.BunifuLabel10)
        Me.BunifuGradientPanel5.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BunifuGradientPanel5.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BunifuGradientPanel5.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BunifuGradientPanel5.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BunifuGradientPanel5.Location = New System.Drawing.Point(17, 490)
        Me.BunifuGradientPanel5.Margin = New System.Windows.Forms.Padding(2)
        Me.BunifuGradientPanel5.Name = "BunifuGradientPanel5"
        Me.BunifuGradientPanel5.Quality = 10
        Me.BunifuGradientPanel5.Size = New System.Drawing.Size(1089, 208)
        Me.BunifuGradientPanel5.TabIndex = 4
        '
        'RichTextBoxVision
        '
        Me.RichTextBoxVision.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.RichTextBoxVision.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBoxVision.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxVision.Location = New System.Drawing.Point(13, 54)
        Me.RichTextBoxVision.Name = "RichTextBoxVision"
        Me.RichTextBoxVision.ReadOnly = True
        Me.RichTextBoxVision.Size = New System.Drawing.Size(1061, 154)
        Me.RichTextBoxVision.TabIndex = 2
        Me.RichTextBoxVision.Text = resources.GetString("RichTextBoxVision.Text")
        '
        'BunifuLabel10
        '
        Me.BunifuLabel10.AllowParentOverrides = False
        Me.BunifuLabel10.AutoEllipsis = False
        Me.BunifuLabel10.CursorType = Nothing
        Me.BunifuLabel10.Font = New System.Drawing.Font("Palatino Linotype", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel10.Location = New System.Drawing.Point(7, 7)
        Me.BunifuLabel10.Margin = New System.Windows.Forms.Padding(2)
        Me.BunifuLabel10.Name = "BunifuLabel10"
        Me.BunifuLabel10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel10.Size = New System.Drawing.Size(83, 38)
        Me.BunifuLabel10.TabIndex = 0
        Me.BunifuLabel10.Text = "Vision"
        Me.BunifuLabel10.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel10.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuGradientPanel4
        '
        Me.BunifuGradientPanel4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BunifuGradientPanel4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuGradientPanel4.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel4.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel4.BorderRadius = 25
        Me.BunifuGradientPanel4.Controls.Add(Me.RichTextBoxMission)
        Me.BunifuGradientPanel4.Controls.Add(Me.BunifuLabel8)
        Me.BunifuGradientPanel4.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BunifuGradientPanel4.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BunifuGradientPanel4.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BunifuGradientPanel4.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BunifuGradientPanel4.Location = New System.Drawing.Point(17, 269)
        Me.BunifuGradientPanel4.Margin = New System.Windows.Forms.Padding(2)
        Me.BunifuGradientPanel4.Name = "BunifuGradientPanel4"
        Me.BunifuGradientPanel4.Quality = 10
        Me.BunifuGradientPanel4.Size = New System.Drawing.Size(1089, 208)
        Me.BunifuGradientPanel4.TabIndex = 4
        '
        'RichTextBoxMission
        '
        Me.RichTextBoxMission.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.RichTextBoxMission.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBoxMission.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxMission.Location = New System.Drawing.Point(13, 48)
        Me.RichTextBoxMission.Name = "RichTextBoxMission"
        Me.RichTextBoxMission.ReadOnly = True
        Me.RichTextBoxMission.Size = New System.Drawing.Size(1061, 154)
        Me.RichTextBoxMission.TabIndex = 1
        Me.RichTextBoxMission.Text = resources.GetString("RichTextBoxMission.Text")
        '
        'BunifuLabel8
        '
        Me.BunifuLabel8.AllowParentOverrides = False
        Me.BunifuLabel8.AutoEllipsis = False
        Me.BunifuLabel8.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel8.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel8.Font = New System.Drawing.Font("Palatino Linotype", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel8.Location = New System.Drawing.Point(13, 5)
        Me.BunifuLabel8.Margin = New System.Windows.Forms.Padding(2)
        Me.BunifuLabel8.Name = "BunifuLabel8"
        Me.BunifuLabel8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel8.Size = New System.Drawing.Size(101, 38)
        Me.BunifuLabel8.TabIndex = 0
        Me.BunifuLabel8.Text = "Mission"
        Me.BunifuLabel8.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel8.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuGradientPanel3
        '
        Me.BunifuGradientPanel3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BunifuGradientPanel3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuGradientPanel3.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel3.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel3.BorderRadius = 30
        Me.BunifuGradientPanel3.Controls.Add(Me.Guna2Button1)
        Me.BunifuGradientPanel3.Controls.Add(Me.lblCountPurok)
        Me.BunifuGradientPanel3.Controls.Add(Me.BunifuLabel7)
        Me.BunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BunifuGradientPanel3.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BunifuGradientPanel3.Location = New System.Drawing.Point(759, 114)
        Me.BunifuGradientPanel3.Margin = New System.Windows.Forms.Padding(2)
        Me.BunifuGradientPanel3.Name = "BunifuGradientPanel3"
        Me.BunifuGradientPanel3.Quality = 10
        Me.BunifuGradientPanel3.Size = New System.Drawing.Size(347, 138)
        Me.BunifuGradientPanel3.TabIndex = 3
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2Button1.BorderThickness = 2
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Image = Global.BrgySystem.My.Resources.Resources.icons8_downtown_70px
        Me.Guna2Button1.ImageSize = New System.Drawing.Size(78, 78)
        Me.Guna2Button1.Location = New System.Drawing.Point(-1, -1)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(101, 141)
        Me.Guna2Button1.TabIndex = 6
        '
        'lblCountPurok
        '
        Me.lblCountPurok.AllowParentOverrides = False
        Me.lblCountPurok.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCountPurok.AutoEllipsis = False
        Me.lblCountPurok.CursorType = Nothing
        Me.lblCountPurok.Font = New System.Drawing.Font("Palatino Linotype", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountPurok.Location = New System.Drawing.Point(110, 31)
        Me.lblCountPurok.Margin = New System.Windows.Forms.Padding(2)
        Me.lblCountPurok.Name = "lblCountPurok"
        Me.lblCountPurok.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCountPurok.Size = New System.Drawing.Size(14, 36)
        Me.lblCountPurok.TabIndex = 2
        Me.lblCountPurok.Text = "1"
        Me.lblCountPurok.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.lblCountPurok.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel7
        '
        Me.BunifuLabel7.AllowParentOverrides = False
        Me.BunifuLabel7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BunifuLabel7.AutoEllipsis = False
        Me.BunifuLabel7.CursorType = Nothing
        Me.BunifuLabel7.Font = New System.Drawing.Font("Palatino Linotype", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel7.Location = New System.Drawing.Point(112, 76)
        Me.BunifuLabel7.Margin = New System.Windows.Forms.Padding(2)
        Me.BunifuLabel7.Name = "BunifuLabel7"
        Me.BunifuLabel7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel7.Size = New System.Drawing.Size(170, 23)
        Me.BunifuLabel7.TabIndex = 0
        Me.BunifuLabel7.Text = "NUMBER OF PUROK"
        Me.BunifuLabel7.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel7.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuGradientPanel6
        '
        Me.BunifuGradientPanel6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BunifuGradientPanel6.BackColor = System.Drawing.Color.Transparent
        Me.BunifuGradientPanel6.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel6.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel6.BorderRadius = 30
        Me.BunifuGradientPanel6.Controls.Add(Me.Guna2Button2)
        Me.BunifuGradientPanel6.Controls.Add(Me.lblCountClearance)
        Me.BunifuGradientPanel6.Controls.Add(Me.BunifuLabel11)
        Me.BunifuGradientPanel6.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BunifuGradientPanel6.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BunifuGradientPanel6.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BunifuGradientPanel6.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BunifuGradientPanel6.Location = New System.Drawing.Point(387, 114)
        Me.BunifuGradientPanel6.Margin = New System.Windows.Forms.Padding(2)
        Me.BunifuGradientPanel6.Name = "BunifuGradientPanel6"
        Me.BunifuGradientPanel6.Quality = 10
        Me.BunifuGradientPanel6.Size = New System.Drawing.Size(347, 138)
        Me.BunifuGradientPanel6.TabIndex = 2
        '
        'Guna2Button2
        '
        Me.Guna2Button2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2Button2.BorderThickness = 2
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Button2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.Image = Global.BrgySystem.My.Resources.Resources.icons8_folder_78px1
        Me.Guna2Button2.ImageSize = New System.Drawing.Size(78, 78)
        Me.Guna2Button2.Location = New System.Drawing.Point(0, -1)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(101, 143)
        Me.Guna2Button2.TabIndex = 7
        '
        'lblCountClearance
        '
        Me.lblCountClearance.AllowParentOverrides = False
        Me.lblCountClearance.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCountClearance.AutoEllipsis = False
        Me.lblCountClearance.CursorType = Nothing
        Me.lblCountClearance.Font = New System.Drawing.Font("Palatino Linotype", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountClearance.Location = New System.Drawing.Point(108, 31)
        Me.lblCountClearance.Margin = New System.Windows.Forms.Padding(2)
        Me.lblCountClearance.Name = "lblCountClearance"
        Me.lblCountClearance.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCountClearance.Size = New System.Drawing.Size(28, 36)
        Me.lblCountClearance.TabIndex = 2
        Me.lblCountClearance.Text = "10"
        Me.lblCountClearance.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.lblCountClearance.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel11
        '
        Me.BunifuLabel11.AllowParentOverrides = False
        Me.BunifuLabel11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BunifuLabel11.AutoEllipsis = False
        Me.BunifuLabel11.CursorType = Nothing
        Me.BunifuLabel11.Font = New System.Drawing.Font("Palatino Linotype", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel11.Location = New System.Drawing.Point(108, 76)
        Me.BunifuLabel11.Margin = New System.Windows.Forms.Padding(2)
        Me.BunifuLabel11.Name = "BunifuLabel11"
        Me.BunifuLabel11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel11.Size = New System.Drawing.Size(214, 23)
        Me.BunifuLabel11.TabIndex = 0
        Me.BunifuLabel11.Text = "NUMBER OF CLEARANCE"
        Me.BunifuLabel11.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel11.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'ResBttn
        '
        Me.ResBttn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ResBttn.BackColor = System.Drawing.Color.Transparent
        Me.ResBttn.BackgroundImage = CType(resources.GetObject("ResBttn.BackgroundImage"), System.Drawing.Image)
        Me.ResBttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ResBttn.BorderRadius = 30
        Me.ResBttn.Controls.Add(Me.ResBttn1)
        Me.ResBttn.Controls.Add(Me.lblCountResidents)
        Me.ResBttn.Controls.Add(Me.BunifuLabel2)
        Me.ResBttn.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ResBttn.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ResBttn.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.ResBttn.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ResBttn.Location = New System.Drawing.Point(17, 114)
        Me.ResBttn.Margin = New System.Windows.Forms.Padding(2)
        Me.ResBttn.Name = "ResBttn"
        Me.ResBttn.Quality = 10
        Me.ResBttn.Size = New System.Drawing.Size(347, 138)
        Me.ResBttn.TabIndex = 2
        '
        'ResBttn1
        '
        Me.ResBttn1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ResBttn1.BorderThickness = 2
        Me.ResBttn1.CheckedState.Parent = Me.ResBttn1
        Me.ResBttn1.CustomImages.Parent = Me.ResBttn1
        Me.ResBttn1.FillColor = System.Drawing.Color.Transparent
        Me.ResBttn1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ResBttn1.ForeColor = System.Drawing.Color.White
        Me.ResBttn1.HoverState.Parent = Me.ResBttn1
        Me.ResBttn1.Image = Global.BrgySystem.My.Resources.Resources.icons8_people_78px
        Me.ResBttn1.ImageSize = New System.Drawing.Size(78, 78)
        Me.ResBttn1.Location = New System.Drawing.Point(0, -1)
        Me.ResBttn1.Name = "ResBttn1"
        Me.ResBttn1.ShadowDecoration.Parent = Me.ResBttn1
        Me.ResBttn1.Size = New System.Drawing.Size(101, 143)
        Me.ResBttn1.TabIndex = 8
        '
        'lblCountResidents
        '
        Me.lblCountResidents.AllowParentOverrides = False
        Me.lblCountResidents.AutoEllipsis = False
        Me.lblCountResidents.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCountResidents.CursorType = System.Windows.Forms.Cursors.Default
        Me.lblCountResidents.Font = New System.Drawing.Font("Palatino Linotype", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountResidents.Location = New System.Drawing.Point(107, 31)
        Me.lblCountResidents.Margin = New System.Windows.Forms.Padding(2)
        Me.lblCountResidents.Name = "lblCountResidents"
        Me.lblCountResidents.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCountResidents.Size = New System.Drawing.Size(28, 36)
        Me.lblCountResidents.TabIndex = 2
        Me.lblCountResidents.Text = "10"
        Me.lblCountResidents.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.lblCountResidents.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel2
        '
        Me.BunifuLabel2.AllowParentOverrides = False
        Me.BunifuLabel2.AutoEllipsis = False
        Me.BunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel2.Font = New System.Drawing.Font("Palatino Linotype", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel2.Location = New System.Drawing.Point(107, 76)
        Me.BunifuLabel2.Margin = New System.Windows.Forms.Padding(2)
        Me.BunifuLabel2.Name = "BunifuLabel2"
        Me.BunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel2.Size = New System.Drawing.Size(205, 23)
        Me.BunifuLabel2.TabIndex = 0
        Me.BunifuLabel2.Text = "NUMBER OF RESIDENTS"
        Me.BunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1124, 766)
        Me.Controls.Add(Me.BunifuGradientPanel5)
        Me.Controls.Add(Me.LiveDateAndTime)
        Me.Controls.Add(Me.BunifuGradientPanel4)
        Me.Controls.Add(Me.BunifuGradientPanel3)
        Me.Controls.Add(Me.BunifuGradientPanel6)
        Me.Controls.Add(Me.ResBttn)
        Me.Controls.Add(Me.BunifuLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.BunifuGradientPanel5.ResumeLayout(False)
        Me.BunifuGradientPanel5.PerformLayout()
        Me.BunifuGradientPanel4.ResumeLayout(False)
        Me.BunifuGradientPanel4.PerformLayout()
        Me.BunifuGradientPanel3.ResumeLayout(False)
        Me.BunifuGradientPanel3.PerformLayout()
        Me.BunifuGradientPanel6.ResumeLayout(False)
        Me.BunifuGradientPanel6.PerformLayout()
        Me.ResBttn.ResumeLayout(False)
        Me.ResBttn.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents ResBttn As Bunifu.UI.WinForms.BunifuGradientPanel
    Friend WithEvents lblCountResidents As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel2 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuGradientPanel3 As Bunifu.UI.WinForms.BunifuGradientPanel
    Friend WithEvents BunifuLabel7 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuGradientPanel4 As Bunifu.UI.WinForms.BunifuGradientPanel
    Friend WithEvents BunifuLabel8 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuGradientPanel5 As Bunifu.UI.WinForms.BunifuGradientPanel
    Friend WithEvents BunifuLabel10 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuGradientPanel6 As Bunifu.UI.WinForms.BunifuGradientPanel
    Friend WithEvents lblCountClearance As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel11 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents LiveDateAndTime As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblCountPurok As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ResBttn1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents RichTextBoxMission As RichTextBox
    Friend WithEvents RichTextBoxVision As RichTextBox
End Class
