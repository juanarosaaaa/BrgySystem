<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Purok
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Purok))
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BunifuTextBox1 = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.PurokGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.purok_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.editButton_Column = New System.Windows.Forms.DataGridViewImageColumn()
        Me.deleteButton_Column = New System.Windows.Forms.DataGridViewImageColumn()
        Me.archiveButton_Column = New System.Windows.Forms.DataGridViewImageColumn()
        Me.AddPurokButton = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.PurokGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Image = Global.BrgySystem.My.Resources.Resources.icons8_search_24px
        Me.Button1.Location = New System.Drawing.Point(1086, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(29, 37)
        Me.Button1.TabIndex = 3
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BunifuTextBox1
        '
        Me.BunifuTextBox1.AcceptsReturn = False
        Me.BunifuTextBox1.AcceptsTab = False
        Me.BunifuTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuTextBox1.AnimationSpeed = 200
        Me.BunifuTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.BunifuTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.BunifuTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTextBox1.BackgroundImage = CType(resources.GetObject("BunifuTextBox1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuTextBox1.BorderColorActive = System.Drawing.Color.DodgerBlue
        Me.BunifuTextBox1.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuTextBox1.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuTextBox1.BorderColorIdle = System.Drawing.Color.Silver
        Me.BunifuTextBox1.BorderRadius = 1
        Me.BunifuTextBox1.BorderThickness = 1
        Me.BunifuTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.BunifuTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTextBox1.DefaultFont = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.BunifuTextBox1.DefaultText = ""
        Me.BunifuTextBox1.FillColor = System.Drawing.Color.White
        Me.BunifuTextBox1.HideSelection = True
        Me.BunifuTextBox1.IconLeft = Nothing
        Me.BunifuTextBox1.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTextBox1.IconPadding = 10
        Me.BunifuTextBox1.IconRight = Nothing
        Me.BunifuTextBox1.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTextBox1.Lines = New String(-1) {}
        Me.BunifuTextBox1.Location = New System.Drawing.Point(789, 9)
        Me.BunifuTextBox1.MaxLength = 32767
        Me.BunifuTextBox1.MinimumSize = New System.Drawing.Size(1, 1)
        Me.BunifuTextBox1.Modified = False
        Me.BunifuTextBox1.Multiline = False
        Me.BunifuTextBox1.Name = "BunifuTextBox1"
        StateProperties1.BorderColor = System.Drawing.Color.DodgerBlue
        StateProperties1.FillColor = System.Drawing.Color.Empty
        StateProperties1.ForeColor = System.Drawing.Color.Empty
        StateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.BunifuTextBox1.OnActiveState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.BunifuTextBox1.OnDisabledState = StateProperties2
        StateProperties3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties3.FillColor = System.Drawing.Color.Empty
        StateProperties3.ForeColor = System.Drawing.Color.Empty
        StateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.BunifuTextBox1.OnHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.Silver
        StateProperties4.FillColor = System.Drawing.Color.White
        StateProperties4.ForeColor = System.Drawing.Color.Empty
        StateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.BunifuTextBox1.OnIdleState = StateProperties4
        Me.BunifuTextBox1.Padding = New System.Windows.Forms.Padding(3)
        Me.BunifuTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BunifuTextBox1.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.BunifuTextBox1.PlaceholderText = "SEARCH"
        Me.BunifuTextBox1.ReadOnly = False
        Me.BunifuTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.BunifuTextBox1.SelectedText = ""
        Me.BunifuTextBox1.SelectionLength = 0
        Me.BunifuTextBox1.SelectionStart = 0
        Me.BunifuTextBox1.ShortcutsEnabled = True
        Me.BunifuTextBox1.Size = New System.Drawing.Size(299, 37)
        Me.BunifuTextBox1.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu
        Me.BunifuTextBox1.TabIndex = 1
        Me.BunifuTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BunifuTextBox1.TextMarginBottom = 0
        Me.BunifuTextBox1.TextMarginLeft = 3
        Me.BunifuTextBox1.TextMarginTop = 0
        Me.BunifuTextBox1.TextPlaceholder = "SEARCH"
        Me.BunifuTextBox1.UseSystemPasswordChar = False
        Me.BunifuTextBox1.WordWrap = True
        '
        'PurokGridView
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.PurokGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.PurokGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PurokGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.PurokGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.PurokGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.PurokGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PurokGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.PurokGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PurokGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.PurokGridView.ColumnHeadersHeight = 21
        Me.PurokGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.purok_Column, Me.editButton_Column, Me.deleteButton_Column, Me.archiveButton_Column})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PurokGridView.DefaultCellStyle = DataGridViewCellStyle4
        Me.PurokGridView.EnableHeadersVisualStyles = False
        Me.PurokGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PurokGridView.Location = New System.Drawing.Point(4, 57)
        Me.PurokGridView.Name = "PurokGridView"
        Me.PurokGridView.RowHeadersVisible = False
        Me.PurokGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PurokGridView.Size = New System.Drawing.Size(1106, 688)
        Me.PurokGridView.TabIndex = 4
        Me.PurokGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.PurokGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.PurokGridView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.PurokGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.PurokGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.PurokGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.PurokGridView.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.PurokGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PurokGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.PurokGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.PurokGridView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.PurokGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.PurokGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.PurokGridView.ThemeStyle.HeaderStyle.Height = 21
        Me.PurokGridView.ThemeStyle.ReadOnly = False
        Me.PurokGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.PurokGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.PurokGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.PurokGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.PurokGridView.ThemeStyle.RowsStyle.Height = 22
        Me.PurokGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PurokGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'purok_Column
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.NullValue = "PUROK SAMPLE"
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.purok_Column.DefaultCellStyle = DataGridViewCellStyle3
        Me.purok_Column.HeaderText = "PUROK"
        Me.purok_Column.Name = "purok_Column"
        '
        'editButton_Column
        '
        Me.editButton_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.editButton_Column.HeaderText = ""
        Me.editButton_Column.MinimumWidth = 25
        Me.editButton_Column.Name = "editButton_Column"
        Me.editButton_Column.Width = 25
        '
        'deleteButton_Column
        '
        Me.deleteButton_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.deleteButton_Column.HeaderText = ""
        Me.deleteButton_Column.MinimumWidth = 25
        Me.deleteButton_Column.Name = "deleteButton_Column"
        Me.deleteButton_Column.Width = 25
        '
        'archiveButton_Column
        '
        Me.archiveButton_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.archiveButton_Column.HeaderText = ""
        Me.archiveButton_Column.MinimumWidth = 25
        Me.archiveButton_Column.Name = "archiveButton_Column"
        Me.archiveButton_Column.Width = 25
        '
        'AddPurokButton
        '
        Me.AddPurokButton.AllowAnimations = True
        Me.AddPurokButton.AllowMouseEffects = True
        Me.AddPurokButton.AllowToggling = False
        Me.AddPurokButton.AnimationSpeed = 200
        Me.AddPurokButton.AutoGenerateColors = False
        Me.AddPurokButton.AutoRoundBorders = False
        Me.AddPurokButton.AutoSizeLeftIcon = True
        Me.AddPurokButton.AutoSizeRightIcon = True
        Me.AddPurokButton.BackColor = System.Drawing.Color.Transparent
        Me.AddPurokButton.BackColor1 = System.Drawing.Color.DodgerBlue
        Me.AddPurokButton.BackgroundImage = CType(resources.GetObject("AddPurokButton.BackgroundImage"), System.Drawing.Image)
        Me.AddPurokButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.AddPurokButton.ButtonText = "Add Purok"
        Me.AddPurokButton.ButtonTextMarginLeft = 0
        Me.AddPurokButton.ColorContrastOnClick = 45
        Me.AddPurokButton.ColorContrastOnHover = 45
        Me.AddPurokButton.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.AddPurokButton.CustomizableEdges = BorderEdges1
        Me.AddPurokButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.AddPurokButton.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.AddPurokButton.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.AddPurokButton.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.AddPurokButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.AddPurokButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AddPurokButton.ForeColor = System.Drawing.Color.White
        Me.AddPurokButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddPurokButton.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.AddPurokButton.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.AddPurokButton.IconMarginLeft = 11
        Me.AddPurokButton.IconPadding = 10
        Me.AddPurokButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AddPurokButton.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.AddPurokButton.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.AddPurokButton.IconSize = 25
        Me.AddPurokButton.IdleBorderColor = System.Drawing.Color.DodgerBlue
        Me.AddPurokButton.IdleBorderRadius = 1
        Me.AddPurokButton.IdleBorderThickness = 1
        Me.AddPurokButton.IdleFillColor = System.Drawing.Color.DodgerBlue
        Me.AddPurokButton.IdleIconLeftImage = Nothing
        Me.AddPurokButton.IdleIconRightImage = Nothing
        Me.AddPurokButton.IndicateFocus = False
        Me.AddPurokButton.Location = New System.Drawing.Point(1, 9)
        Me.AddPurokButton.Name = "AddPurokButton"
        Me.AddPurokButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.AddPurokButton.OnDisabledState.BorderRadius = 1
        Me.AddPurokButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.AddPurokButton.OnDisabledState.BorderThickness = 1
        Me.AddPurokButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.AddPurokButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.AddPurokButton.OnDisabledState.IconLeftImage = Nothing
        Me.AddPurokButton.OnDisabledState.IconRightImage = Nothing
        Me.AddPurokButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AddPurokButton.onHoverState.BorderRadius = 1
        Me.AddPurokButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.AddPurokButton.onHoverState.BorderThickness = 1
        Me.AddPurokButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AddPurokButton.onHoverState.ForeColor = System.Drawing.Color.White
        Me.AddPurokButton.onHoverState.IconLeftImage = Nothing
        Me.AddPurokButton.onHoverState.IconRightImage = Nothing
        Me.AddPurokButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue
        Me.AddPurokButton.OnIdleState.BorderRadius = 1
        Me.AddPurokButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.AddPurokButton.OnIdleState.BorderThickness = 1
        Me.AddPurokButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue
        Me.AddPurokButton.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.AddPurokButton.OnIdleState.IconLeftImage = Nothing
        Me.AddPurokButton.OnIdleState.IconRightImage = Nothing
        Me.AddPurokButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.AddPurokButton.OnPressedState.BorderRadius = 1
        Me.AddPurokButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.AddPurokButton.OnPressedState.BorderThickness = 1
        Me.AddPurokButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.AddPurokButton.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.AddPurokButton.OnPressedState.IconLeftImage = Nothing
        Me.AddPurokButton.OnPressedState.IconRightImage = Nothing
        Me.AddPurokButton.Size = New System.Drawing.Size(150, 34)
        Me.AddPurokButton.TabIndex = 5
        Me.AddPurokButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AddPurokButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.AddPurokButton.TextMarginLeft = 0
        Me.AddPurokButton.TextPadding = New System.Windows.Forms.Padding(0)
        Me.AddPurokButton.UseDefaultRadiusAndThickness = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 10)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1121, 757)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.BunifuTextBox1)
        Me.GroupBox1.Controls.Add(Me.PurokGridView)
        Me.GroupBox1.Controls.Add(Me.AddPurokButton)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1115, 751)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Purok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1124, 766)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Purok"
        Me.Text = "Purok"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PurokGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents BunifuTextBox1 As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents PurokGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents purok_Column As DataGridViewTextBoxColumn
    Friend WithEvents editButton_Column As DataGridViewImageColumn
    Friend WithEvents deleteButton_Column As DataGridViewImageColumn
    Friend WithEvents archiveButton_Column As DataGridViewImageColumn
    Friend WithEvents AddPurokButton As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
End Class
