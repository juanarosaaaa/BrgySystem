<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.AdminNameTextBox = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaTextBox2 = New Guna.UI.WinForms.GunaTextBox()
        Me.Settings_Button = New Guna.UI2.WinForms.Guna2Button()
        Me.Logout_Button = New Guna.UI2.WinForms.Guna2Button()
        Me.Purok_Button = New Guna.UI2.WinForms.Guna2Button()
        Me.OrganizationalChartButton = New Guna.UI2.WinForms.Guna2Button()
        Me.GunaCirclePictureBox2 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.Archive_Button = New Guna.UI2.WinForms.Guna2Button()
        Me.Residents_Button = New Guna.UI2.WinForms.Guna2Button()
        Me.MunicipalityLogo = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.Dashboard_Button = New Guna.UI2.WinForms.Guna2Button()
        Me.Clearance_Button = New Guna.UI2.WinForms.Guna2Button()
        Me.Officials_Button = New Guna.UI2.WinForms.Guna2Button()
        Me.MainPanel = New Bunifu.UI.WinForms.BunifuPanel()
        CType(Me.GunaCirclePictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MunicipalityLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AllowParentOverrides = False
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BunifuLabel1.Location = New System.Drawing.Point(60, 16)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(178, 32)
        Me.BunifuLabel1.TabIndex = 0
        Me.BunifuLabel1.Text = "Barangay System"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'AdminNameTextBox
        '
        Me.AdminNameTextBox.BaseColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.AdminNameTextBox.BorderColor = System.Drawing.Color.Silver
        Me.AdminNameTextBox.BorderSize = 0
        Me.AdminNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AdminNameTextBox.FocusedBaseColor = System.Drawing.Color.White
        Me.AdminNameTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AdminNameTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.AdminNameTextBox.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminNameTextBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AdminNameTextBox.Location = New System.Drawing.Point(-1, 129)
        Me.AdminNameTextBox.Name = "AdminNameTextBox"
        Me.AdminNameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AdminNameTextBox.SelectedText = ""
        Me.AdminNameTextBox.Size = New System.Drawing.Size(243, 36)
        Me.AdminNameTextBox.TabIndex = 28
        Me.AdminNameTextBox.Text = "Admin Name"
        Me.AdminNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaTextBox2
        '
        Me.GunaTextBox2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GunaTextBox2.BorderColor = System.Drawing.Color.Silver
        Me.GunaTextBox2.BorderSize = 1
        Me.GunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox2.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox2.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaTextBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GunaTextBox2.Location = New System.Drawing.Point(-1, 165)
        Me.GunaTextBox2.Name = "GunaTextBox2"
        Me.GunaTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox2.SelectedText = ""
        Me.GunaTextBox2.Size = New System.Drawing.Size(250, 36)
        Me.GunaTextBox2.TabIndex = 29
        Me.GunaTextBox2.Text = "ADMINISTRATOR"
        Me.GunaTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Settings_Button
        '
        Me.Settings_Button.CheckedState.Parent = Me.Settings_Button
        Me.Settings_Button.CustomImages.Parent = Me.Settings_Button
        Me.Settings_Button.FillColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Settings_Button.Font = New System.Drawing.Font("Palatino Linotype", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Settings_Button.ForeColor = System.Drawing.Color.White
        Me.Settings_Button.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Settings_Button.HoverState.Parent = Me.Settings_Button
        Me.Settings_Button.Image = Global.BrgySystem.My.Resources.Resources.icons8_settings_50px
        Me.Settings_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Settings_Button.ImageOffset = New System.Drawing.Point(3, 0)
        Me.Settings_Button.ImageSize = New System.Drawing.Size(30, 30)
        Me.Settings_Button.Location = New System.Drawing.Point(-1, 566)
        Me.Settings_Button.Name = "Settings_Button"
        Me.Settings_Button.ShadowDecoration.Parent = Me.Settings_Button
        Me.Settings_Button.Size = New System.Drawing.Size(243, 45)
        Me.Settings_Button.TabIndex = 19
        Me.Settings_Button.Text = "Settings"
        Me.Settings_Button.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Settings_Button.TextOffset = New System.Drawing.Point(7, 0)
        '
        'Logout_Button
        '
        Me.Logout_Button.CheckedState.Parent = Me.Logout_Button
        Me.Logout_Button.CustomImages.Parent = Me.Logout_Button
        Me.Logout_Button.FillColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Logout_Button.Font = New System.Drawing.Font("Palatino Linotype", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Logout_Button.ForeColor = System.Drawing.Color.White
        Me.Logout_Button.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Logout_Button.HoverState.Parent = Me.Logout_Button
        Me.Logout_Button.Image = Global.BrgySystem.My.Resources.Resources.icons8_logout_rounded_down_50px
        Me.Logout_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Logout_Button.ImageOffset = New System.Drawing.Point(4, 0)
        Me.Logout_Button.ImageSize = New System.Drawing.Size(27, 27)
        Me.Logout_Button.Location = New System.Drawing.Point(-1, 616)
        Me.Logout_Button.Name = "Logout_Button"
        Me.Logout_Button.ShadowDecoration.Parent = Me.Logout_Button
        Me.Logout_Button.Size = New System.Drawing.Size(243, 45)
        Me.Logout_Button.TabIndex = 26
        Me.Logout_Button.Text = "Logout"
        Me.Logout_Button.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Logout_Button.TextOffset = New System.Drawing.Point(9, 0)
        '
        'Purok_Button
        '
        Me.Purok_Button.CheckedState.Parent = Me.Purok_Button
        Me.Purok_Button.CustomImages.Parent = Me.Purok_Button
        Me.Purok_Button.FillColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Purok_Button.Font = New System.Drawing.Font("Palatino Linotype", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Purok_Button.ForeColor = System.Drawing.Color.White
        Me.Purok_Button.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Purok_Button.HoverState.Parent = Me.Purok_Button
        Me.Purok_Button.Image = Global.BrgySystem.My.Resources.Resources.icons8_house_50px
        Me.Purok_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Purok_Button.ImageOffset = New System.Drawing.Point(3, 0)
        Me.Purok_Button.ImageSize = New System.Drawing.Size(32, 32)
        Me.Purok_Button.Location = New System.Drawing.Point(-1, 373)
        Me.Purok_Button.Name = "Purok_Button"
        Me.Purok_Button.ShadowDecoration.Parent = Me.Purok_Button
        Me.Purok_Button.Size = New System.Drawing.Size(243, 45)
        Me.Purok_Button.TabIndex = 24
        Me.Purok_Button.Text = "Purok"
        Me.Purok_Button.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Purok_Button.TextOffset = New System.Drawing.Point(7, 0)
        '
        'OrganizationalChartButton
        '
        Me.OrganizationalChartButton.CheckedState.Parent = Me.OrganizationalChartButton
        Me.OrganizationalChartButton.CustomImages.Parent = Me.OrganizationalChartButton
        Me.OrganizationalChartButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.OrganizationalChartButton.Font = New System.Drawing.Font("Palatino Linotype", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrganizationalChartButton.ForeColor = System.Drawing.Color.White
        Me.OrganizationalChartButton.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.OrganizationalChartButton.HoverState.Parent = Me.OrganizationalChartButton
        Me.OrganizationalChartButton.Image = Global.BrgySystem.My.Resources.Resources.icons8_organization_chart_people_50px
        Me.OrganizationalChartButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.OrganizationalChartButton.ImageOffset = New System.Drawing.Point(5, 0)
        Me.OrganizationalChartButton.ImageSize = New System.Drawing.Size(27, 27)
        Me.OrganizationalChartButton.Location = New System.Drawing.Point(-1, 516)
        Me.OrganizationalChartButton.Name = "OrganizationalChartButton"
        Me.OrganizationalChartButton.ShadowDecoration.Parent = Me.OrganizationalChartButton
        Me.OrganizationalChartButton.Size = New System.Drawing.Size(243, 45)
        Me.OrganizationalChartButton.TabIndex = 20
        Me.OrganizationalChartButton.Text = "Organizational Chart"
        Me.OrganizationalChartButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.OrganizationalChartButton.TextOffset = New System.Drawing.Point(10, 0)
        '
        'GunaCirclePictureBox2
        '
        Me.GunaCirclePictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox2.Image = Global.BrgySystem.My.Resources.Resources.icons8_administrator_male_60px
        Me.GunaCirclePictureBox2.Location = New System.Drawing.Point(86, 61)
        Me.GunaCirclePictureBox2.Name = "GunaCirclePictureBox2"
        Me.GunaCirclePictureBox2.Size = New System.Drawing.Size(70, 63)
        Me.GunaCirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox2.TabIndex = 30
        Me.GunaCirclePictureBox2.TabStop = False
        Me.GunaCirclePictureBox2.UseTransfarantBackground = False
        '
        'Archive_Button
        '
        Me.Archive_Button.CheckedState.Parent = Me.Archive_Button
        Me.Archive_Button.CustomImages.Parent = Me.Archive_Button
        Me.Archive_Button.FillColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Archive_Button.Font = New System.Drawing.Font("Palatino Linotype", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Archive_Button.ForeColor = System.Drawing.Color.White
        Me.Archive_Button.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Archive_Button.HoverState.Parent = Me.Archive_Button
        Me.Archive_Button.Image = Global.BrgySystem.My.Resources.Resources.icons8_archive_folder_50px
        Me.Archive_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Archive_Button.ImageOffset = New System.Drawing.Point(5, 0)
        Me.Archive_Button.ImageSize = New System.Drawing.Size(27, 27)
        Me.Archive_Button.Location = New System.Drawing.Point(-1, 467)
        Me.Archive_Button.Name = "Archive_Button"
        Me.Archive_Button.ShadowDecoration.Parent = Me.Archive_Button
        Me.Archive_Button.Size = New System.Drawing.Size(243, 45)
        Me.Archive_Button.TabIndex = 21
        Me.Archive_Button.Text = "Archive"
        Me.Archive_Button.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Archive_Button.TextOffset = New System.Drawing.Point(10, 0)
        '
        'Residents_Button
        '
        Me.Residents_Button.CheckedState.Parent = Me.Residents_Button
        Me.Residents_Button.CustomImages.Parent = Me.Residents_Button
        Me.Residents_Button.FillColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Residents_Button.Font = New System.Drawing.Font("Palatino Linotype", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Residents_Button.ForeColor = System.Drawing.Color.White
        Me.Residents_Button.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Residents_Button.HoverState.Parent = Me.Residents_Button
        Me.Residents_Button.Image = Global.BrgySystem.My.Resources.Resources.icons8_people_50px1
        Me.Residents_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Residents_Button.ImageOffset = New System.Drawing.Point(3, 0)
        Me.Residents_Button.ImageSize = New System.Drawing.Size(32, 32)
        Me.Residents_Button.Location = New System.Drawing.Point(-1, 275)
        Me.Residents_Button.Name = "Residents_Button"
        Me.Residents_Button.ShadowDecoration.Parent = Me.Residents_Button
        Me.Residents_Button.Size = New System.Drawing.Size(243, 45)
        Me.Residents_Button.TabIndex = 18
        Me.Residents_Button.Text = "Residents"
        Me.Residents_Button.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Residents_Button.TextOffset = New System.Drawing.Point(8, 0)
        '
        'MunicipalityLogo
        '
        Me.MunicipalityLogo.BaseColor = System.Drawing.Color.White
        Me.MunicipalityLogo.Image = Global.BrgySystem.My.Resources.Resources.barangay1Logo
        Me.MunicipalityLogo.Location = New System.Drawing.Point(6, 8)
        Me.MunicipalityLogo.Name = "MunicipalityLogo"
        Me.MunicipalityLogo.Size = New System.Drawing.Size(47, 47)
        Me.MunicipalityLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MunicipalityLogo.TabIndex = 0
        Me.MunicipalityLogo.TabStop = False
        Me.MunicipalityLogo.UseTransfarantBackground = False
        '
        'Dashboard_Button
        '
        Me.Dashboard_Button.CheckedState.Parent = Me.Dashboard_Button
        Me.Dashboard_Button.CustomImages.Parent = Me.Dashboard_Button
        Me.Dashboard_Button.FillColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Dashboard_Button.Font = New System.Drawing.Font("Palatino Linotype", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dashboard_Button.ForeColor = System.Drawing.Color.White
        Me.Dashboard_Button.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Dashboard_Button.HoverState.Parent = Me.Dashboard_Button
        Me.Dashboard_Button.Image = Global.BrgySystem.My.Resources.Resources.icons8_dashboard_50px
        Me.Dashboard_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Dashboard_Button.ImageSize = New System.Drawing.Size(37, 37)
        Me.Dashboard_Button.Location = New System.Drawing.Point(-1, 226)
        Me.Dashboard_Button.Name = "Dashboard_Button"
        Me.Dashboard_Button.ShadowDecoration.Parent = Me.Dashboard_Button
        Me.Dashboard_Button.Size = New System.Drawing.Size(243, 45)
        Me.Dashboard_Button.TabIndex = 17
        Me.Dashboard_Button.Text = "Dashboard"
        Me.Dashboard_Button.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Dashboard_Button.TextOffset = New System.Drawing.Point(3, 0)
        '
        'Clearance_Button
        '
        Me.Clearance_Button.CheckedState.Parent = Me.Clearance_Button
        Me.Clearance_Button.CustomImages.Parent = Me.Clearance_Button
        Me.Clearance_Button.FillColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Clearance_Button.Font = New System.Drawing.Font("Palatino Linotype", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clearance_Button.ForeColor = System.Drawing.Color.White
        Me.Clearance_Button.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Clearance_Button.HoverState.Parent = Me.Clearance_Button
        Me.Clearance_Button.Image = Global.BrgySystem.My.Resources.Resources.icons8_folder_50px
        Me.Clearance_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Clearance_Button.ImageOffset = New System.Drawing.Point(6, 0)
        Me.Clearance_Button.ImageSize = New System.Drawing.Size(26, 26)
        Me.Clearance_Button.Location = New System.Drawing.Point(-1, 421)
        Me.Clearance_Button.Name = "Clearance_Button"
        Me.Clearance_Button.ShadowDecoration.Parent = Me.Clearance_Button
        Me.Clearance_Button.Size = New System.Drawing.Size(243, 45)
        Me.Clearance_Button.TabIndex = 23
        Me.Clearance_Button.Text = "Clearance"
        Me.Clearance_Button.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Clearance_Button.TextOffset = New System.Drawing.Point(12, 0)
        '
        'Officials_Button
        '
        Me.Officials_Button.CheckedState.Parent = Me.Officials_Button
        Me.Officials_Button.CustomImages.Parent = Me.Officials_Button
        Me.Officials_Button.FillColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Officials_Button.Font = New System.Drawing.Font("Palatino Linotype", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Officials_Button.ForeColor = System.Drawing.Color.White
        Me.Officials_Button.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Officials_Button.HoverState.Parent = Me.Officials_Button
        Me.Officials_Button.Image = Global.BrgySystem.My.Resources.Resources.icons8_manager_50px
        Me.Officials_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Officials_Button.ImageSize = New System.Drawing.Size(37, 37)
        Me.Officials_Button.Location = New System.Drawing.Point(-1, 324)
        Me.Officials_Button.Name = "Officials_Button"
        Me.Officials_Button.ShadowDecoration.Parent = Me.Officials_Button
        Me.Officials_Button.Size = New System.Drawing.Size(243, 45)
        Me.Officials_Button.TabIndex = 25
        Me.Officials_Button.Text = "Officials"
        Me.Officials_Button.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Officials_Button.TextOffset = New System.Drawing.Point(2, 0)
        '
        'MainPanel
        '
        Me.MainPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainPanel.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.MainPanel.BackgroundImage = CType(resources.GetObject("MainPanel.BackgroundImage"), System.Drawing.Image)
        Me.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainPanel.BorderColor = System.Drawing.Color.Transparent
        Me.MainPanel.BorderRadius = 3
        Me.MainPanel.BorderThickness = 1
        Me.MainPanel.Location = New System.Drawing.Point(242, -1)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.ShowBorders = True
        Me.MainPanel.Size = New System.Drawing.Size(1125, 769)
        Me.MainPanel.TabIndex = 1
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.Settings_Button)
        Me.Controls.Add(Me.Logout_Button)
        Me.Controls.Add(Me.Purok_Button)
        Me.Controls.Add(Me.OrganizationalChartButton)
        Me.Controls.Add(Me.GunaCirclePictureBox2)
        Me.Controls.Add(Me.Archive_Button)
        Me.Controls.Add(Me.Residents_Button)
        Me.Controls.Add(Me.MunicipalityLogo)
        Me.Controls.Add(Me.Dashboard_Button)
        Me.Controls.Add(Me.AdminNameTextBox)
        Me.Controls.Add(Me.Clearance_Button)
        Me.Controls.Add(Me.Officials_Button)
        Me.Controls.Add(Me.BunifuLabel1)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.GunaTextBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1366, 768)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GunaCirclePictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MunicipalityLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MainPanel As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents Dashboard_Button As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Residents_Button As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Settings_Button As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents OrganizationalChartButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Archive_Button As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Clearance_Button As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Purok_Button As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Officials_Button As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Logout_Button As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents AdminNameTextBox As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaTextBox2 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents MunicipalityLogo As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents GunaCirclePictureBox2 As Guna.UI.WinForms.GunaCirclePictureBox
End Class
