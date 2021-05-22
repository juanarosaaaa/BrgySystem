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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Purok))
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PurokGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.SearchBarField = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.AddPurokButton = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.purok_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.editButton_Column = New System.Windows.Forms.DataGridViewImageColumn()
        Me.deleteButton_Column = New System.Windows.Forms.DataGridViewImageColumn()
        Me.archiveButton_Column = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PurokGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.SearchButton)
        Me.GroupBox1.Controls.Add(Me.PurokGridView)
        Me.GroupBox1.Controls.Add(Me.SearchBarField)
        Me.GroupBox1.Controls.Add(Me.AddPurokButton)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1115, 751)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'PurokGridView
        '
        Me.PurokGridView.AllowUserToAddRows = False
        Me.PurokGridView.AllowUserToDeleteRows = False
        Me.PurokGridView.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.PurokGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.PurokGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PurokGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.PurokGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.PurokGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.PurokGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PurokGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.PurokGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(245, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PurokGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.PurokGridView.ColumnHeadersHeight = 40
        Me.PurokGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.purok_Column, Me.editButton_Column, Me.deleteButton_Column, Me.archiveButton_Column})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PurokGridView.DefaultCellStyle = DataGridViewCellStyle7
        Me.PurokGridView.EnableHeadersVisualStyles = False
        Me.PurokGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PurokGridView.Location = New System.Drawing.Point(4, 70)
        Me.PurokGridView.Name = "PurokGridView"
        Me.PurokGridView.ReadOnly = True
        Me.PurokGridView.RowHeadersVisible = False
        Me.PurokGridView.RowHeadersWidth = 47
        Me.PurokGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.PurokGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PurokGridView.Size = New System.Drawing.Size(1107, 674)
        Me.PurokGridView.TabIndex = 6
        Me.PurokGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.PurokGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.PurokGridView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.PurokGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.PurokGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.PurokGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.PurokGridView.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.PurokGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PurokGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.PurokGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.PurokGridView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PurokGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.PurokGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.PurokGridView.ThemeStyle.HeaderStyle.Height = 40
        Me.PurokGridView.ThemeStyle.ReadOnly = True
        Me.PurokGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.PurokGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.PurokGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PurokGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.PurokGridView.ThemeStyle.RowsStyle.Height = 22
        Me.PurokGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PurokGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'SearchBarField
        '
        Me.SearchBarField.AcceptsReturn = False
        Me.SearchBarField.AcceptsTab = False
        Me.SearchBarField.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchBarField.AnimationSpeed = 200
        Me.SearchBarField.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.SearchBarField.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.SearchBarField.BackColor = System.Drawing.Color.Transparent
        Me.SearchBarField.BackgroundImage = CType(resources.GetObject("SearchBarField.BackgroundImage"), System.Drawing.Image)
        Me.SearchBarField.BorderColorActive = System.Drawing.Color.DodgerBlue
        Me.SearchBarField.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.SearchBarField.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SearchBarField.BorderColorIdle = System.Drawing.Color.Silver
        Me.SearchBarField.BorderRadius = 20
        Me.SearchBarField.BorderThickness = 1
        Me.SearchBarField.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.SearchBarField.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SearchBarField.DefaultFont = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBarField.DefaultText = ""
        Me.SearchBarField.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.SearchBarField.HideSelection = True
        Me.SearchBarField.IconLeft = Nothing
        Me.SearchBarField.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.SearchBarField.IconPadding = 10
        Me.SearchBarField.IconRight = Nothing
        Me.SearchBarField.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.SearchBarField.Lines = New String(-1) {}
        Me.SearchBarField.Location = New System.Drawing.Point(799, 17)
        Me.SearchBarField.MaxLength = 32767
        Me.SearchBarField.MinimumSize = New System.Drawing.Size(1, 1)
        Me.SearchBarField.Modified = False
        Me.SearchBarField.Multiline = False
        Me.SearchBarField.Name = "SearchBarField"
        StateProperties1.BorderColor = System.Drawing.Color.DodgerBlue
        StateProperties1.FillColor = System.Drawing.Color.Empty
        StateProperties1.ForeColor = System.Drawing.Color.Empty
        StateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.SearchBarField.OnActiveState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.SearchBarField.OnDisabledState = StateProperties2
        StateProperties3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties3.FillColor = System.Drawing.Color.Empty
        StateProperties3.ForeColor = System.Drawing.Color.Empty
        StateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.SearchBarField.OnHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.Silver
        StateProperties4.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        StateProperties4.ForeColor = System.Drawing.Color.Empty
        StateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.SearchBarField.OnIdleState = StateProperties4
        Me.SearchBarField.Padding = New System.Windows.Forms.Padding(3)
        Me.SearchBarField.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SearchBarField.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.SearchBarField.PlaceholderText = "Search"
        Me.SearchBarField.ReadOnly = False
        Me.SearchBarField.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.SearchBarField.SelectedText = ""
        Me.SearchBarField.SelectionLength = 0
        Me.SearchBarField.SelectionStart = 0
        Me.SearchBarField.ShortcutsEnabled = True
        Me.SearchBarField.Size = New System.Drawing.Size(286, 42)
        Me.SearchBarField.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu
        Me.SearchBarField.TabIndex = 1
        Me.SearchBarField.TabStop = False
        Me.SearchBarField.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.SearchBarField.TextMarginBottom = 0
        Me.SearchBarField.TextMarginLeft = 3
        Me.SearchBarField.TextMarginTop = 0
        Me.SearchBarField.TextPlaceholder = "Search"
        Me.SearchBarField.UseSystemPasswordChar = False
        Me.SearchBarField.WordWrap = True
        '
        'AddPurokButton
        '
        Me.AddPurokButton.AllowAnimations = True
        Me.AddPurokButton.AllowMouseEffects = True
        Me.AddPurokButton.AllowToggling = False
        Me.AddPurokButton.AnimationSpeed = 200
        Me.AddPurokButton.AutoGenerateColors = False
        Me.AddPurokButton.AutoRoundBorders = True
        Me.AddPurokButton.AutoSizeLeftIcon = True
        Me.AddPurokButton.AutoSizeRightIcon = True
        Me.AddPurokButton.BackColor = System.Drawing.Color.Transparent
        Me.AddPurokButton.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(245, Byte), Integer))
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
        Me.AddPurokButton.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.AddPurokButton.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.AddPurokButton.IdleBorderRadius = 35
        Me.AddPurokButton.IdleBorderThickness = 1
        Me.AddPurokButton.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.AddPurokButton.IdleIconLeftImage = Nothing
        Me.AddPurokButton.IdleIconRightImage = Nothing
        Me.AddPurokButton.IndicateFocus = False
        Me.AddPurokButton.Location = New System.Drawing.Point(9, 17)
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
        Me.AddPurokButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.AddPurokButton.OnIdleState.BorderRadius = 1
        Me.AddPurokButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.AddPurokButton.OnIdleState.BorderThickness = 1
        Me.AddPurokButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(245, Byte), Integer))
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
        Me.AddPurokButton.Size = New System.Drawing.Size(150, 37)
        Me.AddPurokButton.TabIndex = 5
        Me.AddPurokButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AddPurokButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.AddPurokButton.TextMarginLeft = 0
        Me.AddPurokButton.TextPadding = New System.Windows.Forms.Padding(0)
        Me.AddPurokButton.UseDefaultRadiusAndThickness = True
        '
        'SearchButton
        '
        Me.SearchButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchButton.Image = Global.BrgySystem.My.Resources.Resources.icons8_search_24px
        Me.SearchButton.Location = New System.Drawing.Point(1071, 17)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(40, 42)
        Me.SearchButton.TabIndex = 3
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'purok_Column
        '
        Me.purok_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.NullValue = "asdasdasd"
        Me.purok_Column.DefaultCellStyle = DataGridViewCellStyle3
        Me.purok_Column.HeaderText = "Purok"
        Me.purok_Column.Name = "purok_Column"
        Me.purok_Column.ReadOnly = True
        '
        'editButton_Column
        '
        Me.editButton_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.editButton_Column.DefaultCellStyle = DataGridViewCellStyle4
        Me.editButton_Column.HeaderText = ""
        Me.editButton_Column.MinimumWidth = 25
        Me.editButton_Column.Name = "editButton_Column"
        Me.editButton_Column.ReadOnly = True
        Me.editButton_Column.Width = 25
        '
        'deleteButton_Column
        '
        Me.deleteButton_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.deleteButton_Column.DefaultCellStyle = DataGridViewCellStyle5
        Me.deleteButton_Column.HeaderText = ""
        Me.deleteButton_Column.MinimumWidth = 25
        Me.deleteButton_Column.Name = "deleteButton_Column"
        Me.deleteButton_Column.ReadOnly = True
        Me.deleteButton_Column.Width = 25
        '
        'archiveButton_Column
        '
        Me.archiveButton_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.archiveButton_Column.DefaultCellStyle = DataGridViewCellStyle6
        Me.archiveButton_Column.HeaderText = ""
        Me.archiveButton_Column.MinimumWidth = 25
        Me.archiveButton_Column.Name = "archiveButton_Column"
        Me.archiveButton_Column.ReadOnly = True
        Me.archiveButton_Column.Width = 25
        '
        'Purok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1124, 766)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Purok"
        Me.Text = "Purok"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PurokGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SearchButton As Button
    Friend WithEvents SearchBarField As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents AddPurokButton As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PurokGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents purok_Column As DataGridViewTextBoxColumn
    Friend WithEvents editButton_Column As DataGridViewImageColumn
    Friend WithEvents deleteButton_Column As DataGridViewImageColumn
    Friend WithEvents archiveButton_Column As DataGridViewImageColumn
End Class
