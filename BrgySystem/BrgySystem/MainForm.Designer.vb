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
        Me.Dashboard_Button = New Guna.UI2.WinForms.Guna2Button()
        Me.Residents_Button = New Guna.UI2.WinForms.Guna2Button()
        Me.Settings_Button = New Guna.UI2.WinForms.Guna2Button()
        Me.OrganizationalChartButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Archive_Button = New Guna.UI2.WinForms.Guna2Button()
        Me.Clearance_Button = New Guna.UI2.WinForms.Guna2Button()
        Me.Purok_Button = New Guna.UI2.WinForms.Guna2Button()
        Me.Officials_Button = New Guna.UI2.WinForms.Guna2Button()
        Me.Logout_Button = New Guna.UI2.WinForms.Guna2Button()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.MainPanel = New Bunifu.UI.WinForms.BunifuPanel()
        Me.AdminNameTextBox = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaTextBox2 = New Guna.UI.WinForms.GunaTextBox()
        Me.MunicipalityLogo = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaCirclePictureBox2 = New Guna.UI.WinForms.GunaCirclePictureBox()
        CType(Me.MunicipalityLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaCirclePictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dashboard_Button
        '
        Me.Dashboard_Button.CheckedState.Parent = Me.Dashboard_Button
        Me.Dashboard_Button.CustomImages.Parent = Me.Dashboard_Button
        Me.Dashboard_Button.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dashboard_Button.ForeColor = System.Drawing.Color.White
        Me.Dashboard_Button.HoverState.Parent = Me.Dashboard_Button
        Me.Dashboard_Button.Location = New System.Drawing.Point(-1, 258)
        Me.Dashboard_Button.Name = "Dashboard_Button"
        Me.Dashboard_Button.ShadowDecoration.Parent = Me.Dashboard_Button
        Me.Dashboard_Button.Size = New System.Drawing.Size(243, 45)
        Me.Dashboard_Button.TabIndex = 17
        Me.Dashboard_Button.Text = "Dashboard"
        '
        'Residents_Button
        '
        Me.Residents_Button.CheckedState.Parent = Me.Residents_Button
        Me.Residents_Button.CustomImages.Parent = Me.Residents_Button
        Me.Residents_Button.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Residents_Button.ForeColor = System.Drawing.Color.White
        Me.Residents_Button.HoverState.Parent = Me.Residents_Button
        Me.Residents_Button.Location = New System.Drawing.Point(-1, 310)
        Me.Residents_Button.Name = "Residents_Button"
        Me.Residents_Button.ShadowDecoration.Parent = Me.Residents_Button
        Me.Residents_Button.Size = New System.Drawing.Size(243, 45)
        Me.Residents_Button.TabIndex = 18
        Me.Residents_Button.Text = "Residents"
        '
        'Settings_Button
        '
        Me.Settings_Button.CheckedState.Parent = Me.Settings_Button
        Me.Settings_Button.CustomImages.Parent = Me.Settings_Button
        Me.Settings_Button.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Settings_Button.ForeColor = System.Drawing.Color.White
        Me.Settings_Button.HoverState.Parent = Me.Settings_Button
        Me.Settings_Button.Location = New System.Drawing.Point(-1, 617)
        Me.Settings_Button.Name = "Settings_Button"
        Me.Settings_Button.ShadowDecoration.Parent = Me.Settings_Button
        Me.Settings_Button.Size = New System.Drawing.Size(243, 45)
        Me.Settings_Button.TabIndex = 19
        Me.Settings_Button.Text = "Settings"
        '
        'OrganizationalChartButton
        '
        Me.OrganizationalChartButton.CheckedState.Parent = Me.OrganizationalChartButton
        Me.OrganizationalChartButton.CustomImages.Parent = Me.OrganizationalChartButton
        Me.OrganizationalChartButton.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrganizationalChartButton.ForeColor = System.Drawing.Color.White
        Me.OrganizationalChartButton.HoverState.Parent = Me.OrganizationalChartButton
        Me.OrganizationalChartButton.Location = New System.Drawing.Point(-1, 566)
        Me.OrganizationalChartButton.Name = "OrganizationalChartButton"
        Me.OrganizationalChartButton.ShadowDecoration.Parent = Me.OrganizationalChartButton
        Me.OrganizationalChartButton.Size = New System.Drawing.Size(243, 45)
        Me.OrganizationalChartButton.TabIndex = 20
        Me.OrganizationalChartButton.Text = "Organizational Chart"
        '
        'Archive_Button
        '
        Me.Archive_Button.CheckedState.Parent = Me.Archive_Button
        Me.Archive_Button.CustomImages.Parent = Me.Archive_Button
        Me.Archive_Button.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Archive_Button.ForeColor = System.Drawing.Color.White
        Me.Archive_Button.HoverState.Parent = Me.Archive_Button
        Me.Archive_Button.Location = New System.Drawing.Point(-1, 514)
        Me.Archive_Button.Name = "Archive_Button"
        Me.Archive_Button.ShadowDecoration.Parent = Me.Archive_Button
        Me.Archive_Button.Size = New System.Drawing.Size(243, 45)
        Me.Archive_Button.TabIndex = 21
        Me.Archive_Button.Text = "Archive"
        '
        'Clearance_Button
        '
        Me.Clearance_Button.CheckedState.Parent = Me.Clearance_Button
        Me.Clearance_Button.CustomImages.Parent = Me.Clearance_Button
        Me.Clearance_Button.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clearance_Button.ForeColor = System.Drawing.Color.White
        Me.Clearance_Button.HoverState.Parent = Me.Clearance_Button
        Me.Clearance_Button.Location = New System.Drawing.Point(-1, 464)
        Me.Clearance_Button.Name = "Clearance_Button"
        Me.Clearance_Button.ShadowDecoration.Parent = Me.Clearance_Button
        Me.Clearance_Button.Size = New System.Drawing.Size(243, 45)
        Me.Clearance_Button.TabIndex = 23
        Me.Clearance_Button.Text = "Clearance"
        '
        'Purok_Button
        '
        Me.Purok_Button.CheckedState.Parent = Me.Purok_Button
        Me.Purok_Button.CustomImages.Parent = Me.Purok_Button
        Me.Purok_Button.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Purok_Button.ForeColor = System.Drawing.Color.White
        Me.Purok_Button.HoverState.Parent = Me.Purok_Button
        Me.Purok_Button.Location = New System.Drawing.Point(-1, 412)
        Me.Purok_Button.Name = "Purok_Button"
        Me.Purok_Button.ShadowDecoration.Parent = Me.Purok_Button
        Me.Purok_Button.Size = New System.Drawing.Size(243, 45)
        Me.Purok_Button.TabIndex = 24
        Me.Purok_Button.Text = "Purok"
        '
        'Officials_Button
        '
        Me.Officials_Button.CheckedState.Parent = Me.Officials_Button
        Me.Officials_Button.CustomImages.Parent = Me.Officials_Button
        Me.Officials_Button.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Officials_Button.ForeColor = System.Drawing.Color.White
        Me.Officials_Button.HoverState.Parent = Me.Officials_Button
        Me.Officials_Button.Location = New System.Drawing.Point(-1, 361)
        Me.Officials_Button.Name = "Officials_Button"
        Me.Officials_Button.ShadowDecoration.Parent = Me.Officials_Button
        Me.Officials_Button.Size = New System.Drawing.Size(243, 45)
        Me.Officials_Button.TabIndex = 25
        Me.Officials_Button.Text = "Officials"
        '
        'Logout_Button
        '
        Me.Logout_Button.CheckedState.Parent = Me.Logout_Button
        Me.Logout_Button.CustomImages.Parent = Me.Logout_Button
        Me.Logout_Button.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Logout_Button.ForeColor = System.Drawing.Color.White
        Me.Logout_Button.HoverState.Parent = Me.Logout_Button
        Me.Logout_Button.Location = New System.Drawing.Point(-1, 668)
        Me.Logout_Button.Name = "Logout_Button"
        Me.Logout_Button.ShadowDecoration.Parent = Me.Logout_Button
        Me.Logout_Button.Size = New System.Drawing.Size(243, 45)
        Me.Logout_Button.TabIndex = 26
        Me.Logout_Button.Text = "Logout"
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AllowParentOverrides = False
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.Font = New System.Drawing.Font("Segoe UI Semilight", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BunifuLabel1.Location = New System.Drawing.Point(62, 18)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(175, 32)
        Me.BunifuLabel1.TabIndex = 0
        Me.BunifuLabel1.Text = "Barangay System"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
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
        'AdminNameTextBox
        '
        Me.AdminNameTextBox.BaseColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.AdminNameTextBox.BorderColor = System.Drawing.Color.Silver
        Me.AdminNameTextBox.BorderSize = 0
        Me.AdminNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AdminNameTextBox.FocusedBaseColor = System.Drawing.Color.White
        Me.AdminNameTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AdminNameTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.AdminNameTextBox.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminNameTextBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AdminNameTextBox.Location = New System.Drawing.Point(3, 158)
        Me.AdminNameTextBox.Name = "AdminNameTextBox"
        Me.AdminNameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AdminNameTextBox.SelectedText = ""
        Me.AdminNameTextBox.Size = New System.Drawing.Size(243, 36)
        Me.AdminNameTextBox.TabIndex = 28
        Me.AdminNameTextBox.Text = "Admin Name"
        Me.AdminNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GunaTextBox2
        '
        Me.GunaTextBox2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GunaTextBox2.BorderColor = System.Drawing.Color.Silver
        Me.GunaTextBox2.BorderSize = 1
        Me.GunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox2.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox2.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaTextBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GunaTextBox2.Location = New System.Drawing.Point(3, 198)
        Me.GunaTextBox2.Name = "GunaTextBox2"
        Me.GunaTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox2.SelectedText = ""
        Me.GunaTextBox2.Size = New System.Drawing.Size(241, 36)
        Me.GunaTextBox2.TabIndex = 29
        Me.GunaTextBox2.Text = "ADMINISTRATOR"
        Me.GunaTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MunicipalityLogo
        '
        Me.MunicipalityLogo.BaseColor = System.Drawing.Color.White
        Me.MunicipalityLogo.Image = Global.BrgySystem.My.Resources.Resources.barangay1Logo
        Me.MunicipalityLogo.Location = New System.Drawing.Point(9, 13)
        Me.MunicipalityLogo.Name = "MunicipalityLogo"
        Me.MunicipalityLogo.Size = New System.Drawing.Size(47, 47)
        Me.MunicipalityLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MunicipalityLogo.TabIndex = 0
        Me.MunicipalityLogo.TabStop = False
        Me.MunicipalityLogo.UseTransfarantBackground = False
        '
        'GunaCirclePictureBox2
        '
        Me.GunaCirclePictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox2.Image = Global.BrgySystem.My.Resources.Resources.icons8_administrator_male_60px
        Me.GunaCirclePictureBox2.Location = New System.Drawing.Point(86, 80)
        Me.GunaCirclePictureBox2.Name = "GunaCirclePictureBox2"
        Me.GunaCirclePictureBox2.Size = New System.Drawing.Size(70, 63)
        Me.GunaCirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox2.TabIndex = 30
        Me.GunaCirclePictureBox2.TabStop = False
        Me.GunaCirclePictureBox2.UseTransfarantBackground = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.GunaCirclePictureBox2)
        Me.Controls.Add(Me.MunicipalityLogo)
        Me.Controls.Add(Me.GunaTextBox2)
        Me.Controls.Add(Me.AdminNameTextBox)
        Me.Controls.Add(Me.BunifuLabel1)
        Me.Controls.Add(Me.Logout_Button)
        Me.Controls.Add(Me.Officials_Button)
        Me.Controls.Add(Me.Purok_Button)
        Me.Controls.Add(Me.Clearance_Button)
        Me.Controls.Add(Me.Archive_Button)
        Me.Controls.Add(Me.OrganizationalChartButton)
        Me.Controls.Add(Me.Settings_Button)
        Me.Controls.Add(Me.Residents_Button)
        Me.Controls.Add(Me.Dashboard_Button)
        Me.Controls.Add(Me.MainPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1366, 768)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.MunicipalityLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaCirclePictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
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
