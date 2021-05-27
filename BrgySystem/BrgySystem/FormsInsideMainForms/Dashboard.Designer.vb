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
        Me.BunifuPictureBox3 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.lblCountPurok = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel7 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuGradientPanel6 = New Bunifu.UI.WinForms.BunifuGradientPanel()
        Me.BunifuPictureBox4 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.lblCountClearance = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel11 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuGradientPanel1 = New Bunifu.UI.WinForms.BunifuGradientPanel()
        Me.BunifuPictureBox1 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.lblCountResidents = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel2 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.lblMission = New Guna.UI.WinForms.GunaLabel()
        Me.BunifuGradientPanel5.SuspendLayout()
        Me.BunifuGradientPanel4.SuspendLayout()
        Me.BunifuGradientPanel3.SuspendLayout()
        CType(Me.BunifuPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel6.SuspendLayout()
        CType(Me.BunifuPictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AllowParentOverrides = False
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.CursorType = Nothing
        Me.BunifuLabel1.Font = New System.Drawing.Font("Segoe UI Semilight", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel1.Location = New System.Drawing.Point(31, 37)
        Me.BunifuLabel1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(165, 47)
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
        Me.LiveDateAndTime.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LiveDateAndTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LiveDateAndTime.Location = New System.Drawing.Point(31, 85)
        Me.LiveDateAndTime.Margin = New System.Windows.Forms.Padding(4)
        Me.LiveDateAndTime.Name = "LiveDateAndTime"
        Me.LiveDateAndTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LiveDateAndTime.Size = New System.Drawing.Size(225, 25)
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
        Me.BunifuGradientPanel5.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BunifuGradientPanel5.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BunifuGradientPanel5.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BunifuGradientPanel5.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BunifuGradientPanel5.Location = New System.Drawing.Point(23, 603)
        Me.BunifuGradientPanel5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuGradientPanel5.Name = "BunifuGradientPanel5"
        Me.BunifuGradientPanel5.Quality = 10
        Me.BunifuGradientPanel5.Size = New System.Drawing.Size(1452, 256)
        Me.BunifuGradientPanel5.TabIndex = 4
        '
        'RichTextBoxVision
        '
        Me.RichTextBoxVision.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.RichTextBoxVision.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBoxVision.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxVision.Location = New System.Drawing.Point(1, 66)
        Me.RichTextBoxVision.Margin = New System.Windows.Forms.Padding(4)
        Me.RichTextBoxVision.Name = "RichTextBoxVision"
        Me.RichTextBoxVision.Size = New System.Drawing.Size(1449, 190)
        Me.RichTextBoxVision.TabIndex = 2
        Me.RichTextBoxVision.Text = resources.GetString("RichTextBoxVision.Text")
        '
        'BunifuLabel10
        '
        Me.BunifuLabel10.AllowParentOverrides = False
        Me.BunifuLabel10.AutoEllipsis = False
        Me.BunifuLabel10.CursorType = Nothing
        Me.BunifuLabel10.Font = New System.Drawing.Font("Segoe UI Semilight", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel10.Location = New System.Drawing.Point(8, 20)
        Me.BunifuLabel10.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel10.Name = "BunifuLabel10"
        Me.BunifuLabel10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel10.Size = New System.Drawing.Size(75, 40)
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
        Me.BunifuGradientPanel4.Controls.Add(Me.lblMission)
        Me.BunifuGradientPanel4.Controls.Add(Me.RichTextBoxMission)
        Me.BunifuGradientPanel4.Controls.Add(Me.BunifuLabel8)
        Me.BunifuGradientPanel4.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BunifuGradientPanel4.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BunifuGradientPanel4.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BunifuGradientPanel4.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BunifuGradientPanel4.Location = New System.Drawing.Point(23, 331)
        Me.BunifuGradientPanel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuGradientPanel4.Name = "BunifuGradientPanel4"
        Me.BunifuGradientPanel4.Quality = 10
        Me.BunifuGradientPanel4.Size = New System.Drawing.Size(1452, 256)
        Me.BunifuGradientPanel4.TabIndex = 4
        '
        'RichTextBoxMission
        '
        Me.RichTextBoxMission.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.RichTextBoxMission.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBoxMission.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxMission.Location = New System.Drawing.Point(1, 66)
        Me.RichTextBoxMission.Margin = New System.Windows.Forms.Padding(4)
        Me.RichTextBoxMission.Name = "RichTextBoxMission"
        Me.RichTextBoxMission.Size = New System.Drawing.Size(1449, 190)
        Me.RichTextBoxMission.TabIndex = 1
        Me.RichTextBoxMission.Text = resources.GetString("RichTextBoxMission.Text")
        '
        'BunifuLabel8
        '
        Me.BunifuLabel8.AllowParentOverrides = False
        Me.BunifuLabel8.AutoEllipsis = False
        Me.BunifuLabel8.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel8.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel8.Font = New System.Drawing.Font("Segoe UI Semilight", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel8.Location = New System.Drawing.Point(8, 20)
        Me.BunifuLabel8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel8.Name = "BunifuLabel8"
        Me.BunifuLabel8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel8.Size = New System.Drawing.Size(94, 40)
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
        Me.BunifuGradientPanel3.Controls.Add(Me.BunifuPictureBox3)
        Me.BunifuGradientPanel3.Controls.Add(Me.Guna2Button1)
        Me.BunifuGradientPanel3.Controls.Add(Me.lblCountPurok)
        Me.BunifuGradientPanel3.Controls.Add(Me.BunifuLabel7)
        Me.BunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BunifuGradientPanel3.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BunifuGradientPanel3.Location = New System.Drawing.Point(1012, 140)
        Me.BunifuGradientPanel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuGradientPanel3.Name = "BunifuGradientPanel3"
        Me.BunifuGradientPanel3.Quality = 10
        Me.BunifuGradientPanel3.Size = New System.Drawing.Size(463, 170)
        Me.BunifuGradientPanel3.TabIndex = 3
        '
        'BunifuPictureBox3
        '
        Me.BunifuPictureBox3.AllowFocused = False
        Me.BunifuPictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BunifuPictureBox3.AutoSizeHeight = True
        Me.BunifuPictureBox3.BorderRadius = 0
        Me.BunifuPictureBox3.Image = Global.BrgySystem.My.Resources.Resources.icons8_downtown_70px
        Me.BunifuPictureBox3.IsCircle = True
        Me.BunifuPictureBox3.Location = New System.Drawing.Point(15, 33)
        Me.BunifuPictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuPictureBox3.Name = "BunifuPictureBox3"
        Me.BunifuPictureBox3.Size = New System.Drawing.Size(104, 104)
        Me.BunifuPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuPictureBox3.TabIndex = 1
        Me.BunifuPictureBox3.TabStop = False
        Me.BunifuPictureBox3.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square
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
        Me.Guna2Button1.Location = New System.Drawing.Point(-1, -1)
        Me.Guna2Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(135, 174)
        Me.Guna2Button1.TabIndex = 6
        '
        'lblCountPurok
        '
        Me.lblCountPurok.AllowParentOverrides = False
        Me.lblCountPurok.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCountPurok.AutoEllipsis = False
        Me.lblCountPurok.CursorType = Nothing
        Me.lblCountPurok.Font = New System.Drawing.Font("Segoe UI Semilight", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountPurok.Location = New System.Drawing.Point(147, 38)
        Me.lblCountPurok.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lblCountPurok.Name = "lblCountPurok"
        Me.lblCountPurok.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCountPurok.Size = New System.Drawing.Size(13, 47)
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
        Me.BunifuLabel7.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel7.Location = New System.Drawing.Point(149, 94)
        Me.BunifuLabel7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel7.Name = "BunifuLabel7"
        Me.BunifuLabel7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel7.Size = New System.Drawing.Size(186, 30)
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
        Me.BunifuGradientPanel6.Controls.Add(Me.BunifuPictureBox4)
        Me.BunifuGradientPanel6.Controls.Add(Me.Guna2Button2)
        Me.BunifuGradientPanel6.Controls.Add(Me.lblCountClearance)
        Me.BunifuGradientPanel6.Controls.Add(Me.BunifuLabel11)
        Me.BunifuGradientPanel6.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BunifuGradientPanel6.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BunifuGradientPanel6.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BunifuGradientPanel6.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BunifuGradientPanel6.Location = New System.Drawing.Point(516, 140)
        Me.BunifuGradientPanel6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuGradientPanel6.Name = "BunifuGradientPanel6"
        Me.BunifuGradientPanel6.Quality = 10
        Me.BunifuGradientPanel6.Size = New System.Drawing.Size(463, 170)
        Me.BunifuGradientPanel6.TabIndex = 2
        '
        'BunifuPictureBox4
        '
        Me.BunifuPictureBox4.AllowFocused = False
        Me.BunifuPictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BunifuPictureBox4.AutoSizeHeight = True
        Me.BunifuPictureBox4.BorderRadius = 0
        Me.BunifuPictureBox4.Image = CType(resources.GetObject("BunifuPictureBox4.Image"), System.Drawing.Image)
        Me.BunifuPictureBox4.IsCircle = True
        Me.BunifuPictureBox4.Location = New System.Drawing.Point(17, 33)
        Me.BunifuPictureBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuPictureBox4.Name = "BunifuPictureBox4"
        Me.BunifuPictureBox4.Size = New System.Drawing.Size(104, 104)
        Me.BunifuPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuPictureBox4.TabIndex = 1
        Me.BunifuPictureBox4.TabStop = False
        Me.BunifuPictureBox4.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square
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
        Me.Guna2Button2.Location = New System.Drawing.Point(0, -1)
        Me.Guna2Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(135, 176)
        Me.Guna2Button2.TabIndex = 7
        '
        'lblCountClearance
        '
        Me.lblCountClearance.AllowParentOverrides = False
        Me.lblCountClearance.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCountClearance.AutoEllipsis = False
        Me.lblCountClearance.CursorType = Nothing
        Me.lblCountClearance.Font = New System.Drawing.Font("Segoe UI Semilight", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountClearance.Location = New System.Drawing.Point(144, 38)
        Me.lblCountClearance.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lblCountClearance.Name = "lblCountClearance"
        Me.lblCountClearance.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCountClearance.Size = New System.Drawing.Size(31, 47)
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
        Me.BunifuLabel11.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel11.Location = New System.Drawing.Point(144, 94)
        Me.BunifuLabel11.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel11.Name = "BunifuLabel11"
        Me.BunifuLabel11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel11.Size = New System.Drawing.Size(231, 30)
        Me.BunifuLabel11.TabIndex = 0
        Me.BunifuLabel11.Text = "NUMBER OF CLEARANCE"
        Me.BunifuLabel11.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel11.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.BorderRadius = 30
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuPictureBox1)
        Me.BunifuGradientPanel1.Controls.Add(Me.Guna2Button3)
        Me.BunifuGradientPanel1.Controls.Add(Me.lblCountResidents)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuLabel2)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(23, 140)
        Me.BunifuGradientPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(463, 170)
        Me.BunifuGradientPanel1.TabIndex = 2
        '
        'BunifuPictureBox1
        '
        Me.BunifuPictureBox1.AllowFocused = False
        Me.BunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BunifuPictureBox1.AutoSizeHeight = True
        Me.BunifuPictureBox1.BorderRadius = 50
        Me.BunifuPictureBox1.Image = Global.BrgySystem.My.Resources.Resources.icons8_people_78px
        Me.BunifuPictureBox1.IsCircle = True
        Me.BunifuPictureBox1.Location = New System.Drawing.Point(19, 33)
        Me.BunifuPictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuPictureBox1.Name = "BunifuPictureBox1"
        Me.BunifuPictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.BunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuPictureBox1.TabIndex = 1
        Me.BunifuPictureBox1.TabStop = False
        Me.BunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle
        '
        'Guna2Button3
        '
        Me.Guna2Button3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2Button3.BorderThickness = 2
        Me.Guna2Button3.CheckedState.Parent = Me.Guna2Button3
        Me.Guna2Button3.CustomImages.Parent = Me.Guna2Button3
        Me.Guna2Button3.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.HoverState.Parent = Me.Guna2Button3
        Me.Guna2Button3.Location = New System.Drawing.Point(0, -1)
        Me.Guna2Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.ShadowDecoration.Parent = Me.Guna2Button3
        Me.Guna2Button3.Size = New System.Drawing.Size(135, 176)
        Me.Guna2Button3.TabIndex = 8
        '
        'lblCountResidents
        '
        Me.lblCountResidents.AllowParentOverrides = False
        Me.lblCountResidents.AutoEllipsis = False
        Me.lblCountResidents.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCountResidents.CursorType = System.Windows.Forms.Cursors.Default
        Me.lblCountResidents.Font = New System.Drawing.Font("Segoe UI Semilight", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountResidents.Location = New System.Drawing.Point(143, 38)
        Me.lblCountResidents.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lblCountResidents.Name = "lblCountResidents"
        Me.lblCountResidents.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCountResidents.Size = New System.Drawing.Size(31, 47)
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
        Me.BunifuLabel2.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel2.Location = New System.Drawing.Point(143, 94)
        Me.BunifuLabel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel2.Name = "BunifuLabel2"
        Me.BunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel2.Size = New System.Drawing.Size(221, 30)
        Me.BunifuLabel2.TabIndex = 0
        Me.BunifuLabel2.Text = "NUMBER OF RESIDENTS"
        Me.BunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'lblMission
        '
        Me.lblMission.AutoSize = True
        Me.lblMission.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMission.Location = New System.Drawing.Point(3, 150)
        Me.lblMission.Name = "lblMission"
        Me.lblMission.Size = New System.Drawing.Size(1444, 75)
        Me.lblMission.TabIndex = 6
        Me.lblMission.Text = resources.GetString("lblMission.Text")
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1499, 943)
        Me.Controls.Add(Me.BunifuGradientPanel5)
        Me.Controls.Add(Me.LiveDateAndTime)
        Me.Controls.Add(Me.BunifuGradientPanel4)
        Me.Controls.Add(Me.BunifuGradientPanel3)
        Me.Controls.Add(Me.BunifuGradientPanel6)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.Controls.Add(Me.BunifuLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.BunifuGradientPanel5.ResumeLayout(False)
        Me.BunifuGradientPanel5.PerformLayout()
        Me.BunifuGradientPanel4.ResumeLayout(False)
        Me.BunifuGradientPanel4.PerformLayout()
        Me.BunifuGradientPanel3.ResumeLayout(False)
        Me.BunifuGradientPanel3.PerformLayout()
        CType(Me.BunifuPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel6.ResumeLayout(False)
        Me.BunifuGradientPanel6.PerformLayout()
        CType(Me.BunifuPictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuGradientPanel1 As Bunifu.UI.WinForms.BunifuGradientPanel
    Friend WithEvents lblCountResidents As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuPictureBox1 As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents BunifuLabel2 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuGradientPanel3 As Bunifu.UI.WinForms.BunifuGradientPanel
    Friend WithEvents BunifuPictureBox3 As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents BunifuLabel7 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuGradientPanel4 As Bunifu.UI.WinForms.BunifuGradientPanel
    Friend WithEvents BunifuLabel8 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuGradientPanel5 As Bunifu.UI.WinForms.BunifuGradientPanel
    Friend WithEvents BunifuLabel10 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuGradientPanel6 As Bunifu.UI.WinForms.BunifuGradientPanel
    Friend WithEvents lblCountClearance As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuPictureBox4 As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents BunifuLabel11 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents LiveDateAndTime As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblCountPurok As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents RichTextBoxMission As RichTextBox
    Friend WithEvents RichTextBoxVision As RichTextBox
    Friend WithEvents lblMission As Guna.UI.WinForms.GunaLabel
End Class
