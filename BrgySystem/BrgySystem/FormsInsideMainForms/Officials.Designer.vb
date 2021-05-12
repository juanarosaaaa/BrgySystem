<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Officials
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Officials))
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Me.TableGridView = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.nameColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.termColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PositionColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.editButtonColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.deleteButtonColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.archiveButtonColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BunifuTextBox1 = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.BunifuButton1 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        CType(Me.TableGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableGridView
        '
        Me.TableGridView.AllowCustomTheming = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.TableGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.TableGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TableGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TableGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.TableGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TableGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.TableGridView.ColumnHeadersHeight = 40
        Me.TableGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nameColumn, Me.AgeColumn, Me.termColumn, Me.PositionColumn, Me.SexColumn, Me.StatusColumn, Me.ContactColumn, Me.editButtonColumn, Me.deleteButtonColumn, Me.archiveButtonColumn})
        Me.TableGridView.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TableGridView.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TableGridView.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.TableGridView.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TableGridView.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.TableGridView.CurrentTheme.BackColor = System.Drawing.Color.White
        Me.TableGridView.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TableGridView.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TableGridView.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.TableGridView.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.TableGridView.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TableGridView.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.TableGridView.CurrentTheme.Name = Nothing
        Me.TableGridView.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White
        Me.TableGridView.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TableGridView.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.TableGridView.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TableGridView.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TableGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.TableGridView.EnableHeadersVisualStyles = False
        Me.TableGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TableGridView.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TableGridView.HeaderBgColor = System.Drawing.Color.Empty
        Me.TableGridView.HeaderForeColor = System.Drawing.Color.White
        Me.TableGridView.Location = New System.Drawing.Point(16, 91)
        Me.TableGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableGridView.Name = "TableGridView"
        Me.TableGridView.RowHeadersVisible = False
        Me.TableGridView.RowHeadersWidth = 51
        Me.TableGridView.RowTemplate.Height = 40
        Me.TableGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TableGridView.Size = New System.Drawing.Size(1447, 786)
        Me.TableGridView.TabIndex = 0
        Me.TableGridView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light
        '
        'nameColumn
        '
        Me.nameColumn.HeaderText = "NAME"
        Me.nameColumn.MinimumWidth = 6
        Me.nameColumn.Name = "nameColumn"
        '
        'AgeColumn
        '
        Me.AgeColumn.HeaderText = "AGE"
        Me.AgeColumn.MinimumWidth = 6
        Me.AgeColumn.Name = "AgeColumn"
        '
        'termColumn
        '
        Me.termColumn.HeaderText = "TERM"
        Me.termColumn.MinimumWidth = 6
        Me.termColumn.Name = "termColumn"
        '
        'PositionColumn
        '
        Me.PositionColumn.HeaderText = "POSITION"
        Me.PositionColumn.MinimumWidth = 6
        Me.PositionColumn.Name = "PositionColumn"
        '
        'SexColumn
        '
        Me.SexColumn.HeaderText = "SEX"
        Me.SexColumn.MinimumWidth = 6
        Me.SexColumn.Name = "SexColumn"
        '
        'StatusColumn
        '
        Me.StatusColumn.HeaderText = "STATUS"
        Me.StatusColumn.MinimumWidth = 6
        Me.StatusColumn.Name = "StatusColumn"
        '
        'ContactColumn
        '
        Me.ContactColumn.HeaderText = "CONTACT"
        Me.ContactColumn.MinimumWidth = 6
        Me.ContactColumn.Name = "ContactColumn"
        '
        'editButtonColumn
        '
        Me.editButtonColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.editButtonColumn.HeaderText = ""
        Me.editButtonColumn.MinimumWidth = 25
        Me.editButtonColumn.Name = "editButtonColumn"
        Me.editButtonColumn.Width = 25
        '
        'deleteButtonColumn
        '
        Me.deleteButtonColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.deleteButtonColumn.HeaderText = ""
        Me.deleteButtonColumn.MinimumWidth = 25
        Me.deleteButtonColumn.Name = "deleteButtonColumn"
        Me.deleteButtonColumn.Width = 25
        '
        'archiveButtonColumn
        '
        Me.archiveButtonColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.archiveButtonColumn.HeaderText = ""
        Me.archiveButtonColumn.MinimumWidth = 25
        Me.archiveButtonColumn.Name = "archiveButtonColumn"
        Me.archiveButtonColumn.Width = 25
        '
        'Button1
        '
        Me.Button1.Image = Global.BrgySystem.My.Resources.Resources.icons8_search_24px
        Me.Button1.Location = New System.Drawing.Point(1423, 39)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 43)
        Me.Button1.TabIndex = 4
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BunifuTextBox1
        '
        Me.BunifuTextBox1.AcceptsReturn = False
        Me.BunifuTextBox1.AcceptsTab = False
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
        Me.BunifuTextBox1.Location = New System.Drawing.Point(1108, 38)
        Me.BunifuTextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.BunifuTextBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BunifuTextBox1.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.BunifuTextBox1.PlaceholderText = "SEARCH"
        Me.BunifuTextBox1.ReadOnly = False
        Me.BunifuTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.BunifuTextBox1.SelectedText = ""
        Me.BunifuTextBox1.SelectionLength = 0
        Me.BunifuTextBox1.SelectionStart = 0
        Me.BunifuTextBox1.ShortcutsEnabled = True
        Me.BunifuTextBox1.Size = New System.Drawing.Size(320, 46)
        Me.BunifuTextBox1.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu
        Me.BunifuTextBox1.TabIndex = 2
        Me.BunifuTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BunifuTextBox1.TextMarginBottom = 0
        Me.BunifuTextBox1.TextMarginLeft = 3
        Me.BunifuTextBox1.TextMarginTop = 0
        Me.BunifuTextBox1.TextPlaceholder = "SEARCH"
        Me.BunifuTextBox1.UseSystemPasswordChar = False
        Me.BunifuTextBox1.WordWrap = True
        '
        'BunifuButton1
        '
        Me.BunifuButton1.AllowAnimations = True
        Me.BunifuButton1.AllowMouseEffects = True
        Me.BunifuButton1.AllowToggling = False
        Me.BunifuButton1.AnimationSpeed = 200
        Me.BunifuButton1.AutoGenerateColors = False
        Me.BunifuButton1.AutoRoundBorders = False
        Me.BunifuButton1.AutoSizeLeftIcon = True
        Me.BunifuButton1.AutoSizeRightIcon = True
        Me.BunifuButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton1.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton1.BackgroundImage = CType(resources.GetObject("BunifuButton1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.ButtonText = "ADD NEW OFFICIALS"
        Me.BunifuButton1.ButtonTextMarginLeft = 0
        Me.BunifuButton1.ColorContrastOnClick = 45
        Me.BunifuButton1.ColorContrastOnHover = 45
        Me.BunifuButton1.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.BunifuButton1.CustomizableEdges = BorderEdges1
        Me.BunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton1.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuButton1.ForeColor = System.Drawing.Color.White
        Me.BunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton1.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton1.IconMarginLeft = 11
        Me.BunifuButton1.IconPadding = 10
        Me.BunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton1.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton1.IconSize = 25
        Me.BunifuButton1.IdleBorderColor = System.Drawing.Color.Transparent
        Me.BunifuButton1.IdleBorderRadius = 1
        Me.BunifuButton1.IdleBorderThickness = 1
        Me.BunifuButton1.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton1.IdleIconLeftImage = Nothing
        Me.BunifuButton1.IdleIconRightImage = Nothing
        Me.BunifuButton1.IndicateFocus = False
        Me.BunifuButton1.Location = New System.Drawing.Point(16, 39)
        Me.BunifuButton1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuButton1.Name = "BunifuButton1"
        Me.BunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton1.OnDisabledState.BorderRadius = 1
        Me.BunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.OnDisabledState.BorderThickness = 1
        Me.BunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton1.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton1.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuButton1.onHoverState.BorderRadius = 1
        Me.BunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.onHoverState.BorderThickness = 1
        Me.BunifuButton1.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuButton1.onHoverState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton1.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton1.onHoverState.IconRightImage = Nothing
        Me.BunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuButton1.OnIdleState.BorderRadius = 1
        Me.BunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.OnIdleState.BorderThickness = 1
        Me.BunifuButton1.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton1.OnIdleState.IconLeftImage = Nothing
        Me.BunifuButton1.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuButton1.OnPressedState.BorderRadius = 1
        Me.BunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.OnPressedState.BorderThickness = 1
        Me.BunifuButton1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton1.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton1.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton1.Size = New System.Drawing.Size(241, 44)
        Me.BunifuButton1.TabIndex = 1
        Me.BunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton1.TextMarginLeft = 0
        Me.BunifuButton1.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton1.UseDefaultRadiusAndThickness = True
        '
        'Officials
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1477, 896)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BunifuTextBox1)
        Me.Controls.Add(Me.BunifuButton1)
        Me.Controls.Add(Me.TableGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Officials"
        Me.Text = "Officials"
        CType(Me.TableGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableGridView As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents BunifuButton1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuTextBox1 As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents nameColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgeColumn As DataGridViewTextBoxColumn
    Friend WithEvents termColumn As DataGridViewTextBoxColumn
    Friend WithEvents PositionColumn As DataGridViewTextBoxColumn
    Friend WithEvents SexColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactColumn As DataGridViewTextBoxColumn
    Friend WithEvents editButtonColumn As DataGridViewImageColumn
    Friend WithEvents deleteButtonColumn As DataGridViewImageColumn
    Friend WithEvents archiveButtonColumn As DataGridViewImageColumn
End Class
