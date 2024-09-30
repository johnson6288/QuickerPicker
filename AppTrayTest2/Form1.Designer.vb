<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReloadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFolderLocationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdChange = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.cmdReload = New System.Windows.Forms.Button()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.picShortLtBlue = New System.Windows.Forms.PictureBox()
        Me.picEnvYellow = New System.Windows.Forms.PictureBox()
        Me.picShortMagenta = New System.Windows.Forms.PictureBox()
        Me.picEnvRed = New System.Windows.Forms.PictureBox()
        Me.picShortOrange = New System.Windows.Forms.PictureBox()
        Me.picEnvPurple = New System.Windows.Forms.PictureBox()
        Me.picShortPink = New System.Windows.Forms.PictureBox()
        Me.picEnvPink = New System.Windows.Forms.PictureBox()
        Me.picShortPurple = New System.Windows.Forms.PictureBox()
        Me.picEnvOrange = New System.Windows.Forms.PictureBox()
        Me.picShortRed = New System.Windows.Forms.PictureBox()
        Me.picEnvMagenta = New System.Windows.Forms.PictureBox()
        Me.picShortYellow = New System.Windows.Forms.PictureBox()
        Me.picEnvLtBlue = New System.Windows.Forms.PictureBox()
        Me.picShortBlue = New System.Windows.Forms.PictureBox()
        Me.picEnvGreen = New System.Windows.Forms.PictureBox()
        Me.picShortGreen = New System.Windows.Forms.PictureBox()
        Me.picEnvBlue = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.myIcon = New System.Windows.Forms.PictureBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbxStartupLoad = New System.Windows.Forms.CheckBox()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.picShortLtBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEnvYellow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShortMagenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEnvRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShortOrange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEnvPurple, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShortPink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEnvPink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShortPurple, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEnvOrange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShortRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEnvMagenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShortYellow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEnvLtBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShortBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEnvGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShortGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEnvBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.myIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Quicker Picker"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.OpenFolderLocationToolStripMenuItem, Me.ToolStripSeparator1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(222, 58)
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem, Me.ReloadToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(221, 24)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(185, 26)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ReloadToolStripMenuItem
        '
        Me.ReloadToolStripMenuItem.Name = "ReloadToolStripMenuItem"
        Me.ReloadToolStripMenuItem.Size = New System.Drawing.Size(185, 26)
        Me.ReloadToolStripMenuItem.Text = "Reload"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(185, 26)
        Me.ExitToolStripMenuItem.Text = "Exit From Tray"
        '
        'OpenFolderLocationToolStripMenuItem
        '
        Me.OpenFolderLocationToolStripMenuItem.Name = "OpenFolderLocationToolStripMenuItem"
        Me.OpenFolderLocationToolStripMenuItem.Size = New System.Drawing.Size(221, 24)
        Me.OpenFolderLocationToolStripMenuItem.Text = "Open Folder Location"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(218, 6)
        '
        'cmdChange
        '
        Me.cmdChange.Location = New System.Drawing.Point(134, 232)
        Me.cmdChange.Name = "cmdChange"
        Me.cmdChange.Size = New System.Drawing.Size(122, 23)
        Me.cmdChange.TabIndex = 0
        Me.cmdChange.Text = "Change Location"
        Me.cmdChange.UseVisualStyleBackColor = True
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.SelectedPath = "C:\"
        '
        'cmdReload
        '
        Me.cmdReload.Location = New System.Drawing.Point(268, 232)
        Me.cmdReload.Name = "cmdReload"
        Me.cmdReload.Size = New System.Drawing.Size(122, 23)
        Me.cmdReload.TabIndex = 1
        Me.cmdReload.Text = "Reload"
        Me.cmdReload.UseVisualStyleBackColor = True
        '
        'picLogo
        '
        Me.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(5, 7)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(515, 64)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 8
        Me.picLogo.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(26, 74)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(474, 152)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 10
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(466, 126)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Getting Started"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(455, 15)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Quicker Picker - The Quick File Picker"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(455, 108)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(466, 126)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Icon Selector"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.picShortLtBlue)
        Me.GroupBox2.Controls.Add(Me.picEnvYellow)
        Me.GroupBox2.Controls.Add(Me.picShortMagenta)
        Me.GroupBox2.Controls.Add(Me.picEnvRed)
        Me.GroupBox2.Controls.Add(Me.picShortOrange)
        Me.GroupBox2.Controls.Add(Me.picEnvPurple)
        Me.GroupBox2.Controls.Add(Me.picShortPink)
        Me.GroupBox2.Controls.Add(Me.picEnvPink)
        Me.GroupBox2.Controls.Add(Me.picShortPurple)
        Me.GroupBox2.Controls.Add(Me.picEnvOrange)
        Me.GroupBox2.Controls.Add(Me.picShortRed)
        Me.GroupBox2.Controls.Add(Me.picEnvMagenta)
        Me.GroupBox2.Controls.Add(Me.picShortYellow)
        Me.GroupBox2.Controls.Add(Me.picEnvLtBlue)
        Me.GroupBox2.Controls.Add(Me.picShortBlue)
        Me.GroupBox2.Controls.Add(Me.picEnvGreen)
        Me.GroupBox2.Controls.Add(Me.picShortGreen)
        Me.GroupBox2.Controls.Add(Me.picEnvBlue)
        Me.GroupBox2.Location = New System.Drawing.Point(112, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(348, 100)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Choose An Icon"
        '
        'picShortLtBlue
        '
        Me.picShortLtBlue.BackgroundImage = Global.QuickerPicker.My.Resources.Resources.shortcut_ltblue
        Me.picShortLtBlue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picShortLtBlue.Location = New System.Drawing.Point(82, 22)
        Me.picShortLtBlue.Name = "picShortLtBlue"
        Me.picShortLtBlue.Size = New System.Drawing.Size(32, 32)
        Me.picShortLtBlue.TabIndex = 19
        Me.picShortLtBlue.TabStop = False
        Me.picShortLtBlue.Tag = "iconSelections"
        '
        'picEnvYellow
        '
        Me.picEnvYellow.BackgroundImage = Global.QuickerPicker.My.Resources.Resources.env_yellow
        Me.picEnvYellow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picEnvYellow.Location = New System.Drawing.Point(310, 60)
        Me.picEnvYellow.Name = "picEnvYellow"
        Me.picEnvYellow.Size = New System.Drawing.Size(32, 32)
        Me.picEnvYellow.TabIndex = 36
        Me.picEnvYellow.TabStop = False
        Me.picEnvYellow.Tag = "iconSelections"
        '
        'picShortMagenta
        '
        Me.picShortMagenta.BackgroundImage = Global.QuickerPicker.My.Resources.Resources.shortcut_magenta
        Me.picShortMagenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picShortMagenta.Location = New System.Drawing.Point(120, 22)
        Me.picShortMagenta.Name = "picShortMagenta"
        Me.picShortMagenta.Size = New System.Drawing.Size(32, 32)
        Me.picShortMagenta.TabIndex = 20
        Me.picShortMagenta.TabStop = False
        Me.picShortMagenta.Tag = "iconSelections"
        '
        'picEnvRed
        '
        Me.picEnvRed.BackgroundImage = Global.QuickerPicker.My.Resources.Resources.env_red
        Me.picEnvRed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picEnvRed.Location = New System.Drawing.Point(272, 60)
        Me.picEnvRed.Name = "picEnvRed"
        Me.picEnvRed.Size = New System.Drawing.Size(32, 32)
        Me.picEnvRed.TabIndex = 35
        Me.picEnvRed.TabStop = False
        Me.picEnvRed.Tag = "iconSelections"
        '
        'picShortOrange
        '
        Me.picShortOrange.BackgroundImage = Global.QuickerPicker.My.Resources.Resources.shortcut_orange
        Me.picShortOrange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picShortOrange.Location = New System.Drawing.Point(158, 22)
        Me.picShortOrange.Name = "picShortOrange"
        Me.picShortOrange.Size = New System.Drawing.Size(32, 32)
        Me.picShortOrange.TabIndex = 21
        Me.picShortOrange.TabStop = False
        Me.picShortOrange.Tag = "iconSelections"
        '
        'picEnvPurple
        '
        Me.picEnvPurple.BackgroundImage = Global.QuickerPicker.My.Resources.Resources.env_purple
        Me.picEnvPurple.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picEnvPurple.Location = New System.Drawing.Point(234, 60)
        Me.picEnvPurple.Name = "picEnvPurple"
        Me.picEnvPurple.Size = New System.Drawing.Size(32, 32)
        Me.picEnvPurple.TabIndex = 34
        Me.picEnvPurple.TabStop = False
        Me.picEnvPurple.Tag = "iconSelections"
        '
        'picShortPink
        '
        Me.picShortPink.BackgroundImage = Global.QuickerPicker.My.Resources.Resources.shortcut_pink
        Me.picShortPink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picShortPink.Location = New System.Drawing.Point(196, 22)
        Me.picShortPink.Name = "picShortPink"
        Me.picShortPink.Size = New System.Drawing.Size(32, 32)
        Me.picShortPink.TabIndex = 22
        Me.picShortPink.TabStop = False
        Me.picShortPink.Tag = "iconSelections"
        '
        'picEnvPink
        '
        Me.picEnvPink.BackgroundImage = Global.QuickerPicker.My.Resources.Resources.env_pink
        Me.picEnvPink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picEnvPink.Location = New System.Drawing.Point(196, 60)
        Me.picEnvPink.Name = "picEnvPink"
        Me.picEnvPink.Size = New System.Drawing.Size(32, 32)
        Me.picEnvPink.TabIndex = 33
        Me.picEnvPink.TabStop = False
        Me.picEnvPink.Tag = "iconSelections"
        '
        'picShortPurple
        '
        Me.picShortPurple.BackgroundImage = Global.QuickerPicker.My.Resources.Resources.shortcut_purple
        Me.picShortPurple.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picShortPurple.Location = New System.Drawing.Point(234, 22)
        Me.picShortPurple.Name = "picShortPurple"
        Me.picShortPurple.Size = New System.Drawing.Size(32, 32)
        Me.picShortPurple.TabIndex = 23
        Me.picShortPurple.TabStop = False
        Me.picShortPurple.Tag = "iconSelections"
        '
        'picEnvOrange
        '
        Me.picEnvOrange.BackgroundImage = Global.QuickerPicker.My.Resources.Resources.env_orange
        Me.picEnvOrange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picEnvOrange.Location = New System.Drawing.Point(158, 60)
        Me.picEnvOrange.Name = "picEnvOrange"
        Me.picEnvOrange.Size = New System.Drawing.Size(32, 32)
        Me.picEnvOrange.TabIndex = 32
        Me.picEnvOrange.TabStop = False
        Me.picEnvOrange.Tag = "iconSelections"
        '
        'picShortRed
        '
        Me.picShortRed.BackgroundImage = Global.QuickerPicker.My.Resources.Resources.shortcut_red
        Me.picShortRed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picShortRed.Location = New System.Drawing.Point(272, 22)
        Me.picShortRed.Name = "picShortRed"
        Me.picShortRed.Size = New System.Drawing.Size(32, 32)
        Me.picShortRed.TabIndex = 24
        Me.picShortRed.TabStop = False
        Me.picShortRed.Tag = "iconSelections"
        '
        'picEnvMagenta
        '
        Me.picEnvMagenta.BackgroundImage = Global.QuickerPicker.My.Resources.Resources.env_magenta
        Me.picEnvMagenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picEnvMagenta.Location = New System.Drawing.Point(120, 60)
        Me.picEnvMagenta.Name = "picEnvMagenta"
        Me.picEnvMagenta.Size = New System.Drawing.Size(32, 32)
        Me.picEnvMagenta.TabIndex = 31
        Me.picEnvMagenta.TabStop = False
        Me.picEnvMagenta.Tag = "iconSelections"
        '
        'picShortYellow
        '
        Me.picShortYellow.BackgroundImage = Global.QuickerPicker.My.Resources.Resources.shortcut_yellow
        Me.picShortYellow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picShortYellow.Location = New System.Drawing.Point(310, 22)
        Me.picShortYellow.Name = "picShortYellow"
        Me.picShortYellow.Size = New System.Drawing.Size(32, 32)
        Me.picShortYellow.TabIndex = 25
        Me.picShortYellow.TabStop = False
        Me.picShortYellow.Tag = "iconSelections"
        '
        'picEnvLtBlue
        '
        Me.picEnvLtBlue.BackgroundImage = Global.QuickerPicker.My.Resources.Resources.env_ltblue
        Me.picEnvLtBlue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picEnvLtBlue.Location = New System.Drawing.Point(82, 60)
        Me.picEnvLtBlue.Name = "picEnvLtBlue"
        Me.picEnvLtBlue.Size = New System.Drawing.Size(32, 32)
        Me.picEnvLtBlue.TabIndex = 30
        Me.picEnvLtBlue.TabStop = False
        Me.picEnvLtBlue.Tag = "iconSelections"
        '
        'picShortBlue
        '
        Me.picShortBlue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picShortBlue.Image = Global.QuickerPicker.My.Resources.Resources.shortcut_blue
        Me.picShortBlue.Location = New System.Drawing.Point(6, 22)
        Me.picShortBlue.Name = "picShortBlue"
        Me.picShortBlue.Size = New System.Drawing.Size(32, 32)
        Me.picShortBlue.TabIndex = 26
        Me.picShortBlue.TabStop = False
        Me.picShortBlue.Tag = "iconSelections"
        '
        'picEnvGreen
        '
        Me.picEnvGreen.BackgroundImage = Global.QuickerPicker.My.Resources.Resources.env_green
        Me.picEnvGreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picEnvGreen.Location = New System.Drawing.Point(44, 60)
        Me.picEnvGreen.Name = "picEnvGreen"
        Me.picEnvGreen.Size = New System.Drawing.Size(32, 32)
        Me.picEnvGreen.TabIndex = 29
        Me.picEnvGreen.TabStop = False
        Me.picEnvGreen.Tag = "iconSelections"
        '
        'picShortGreen
        '
        Me.picShortGreen.BackgroundImage = Global.QuickerPicker.My.Resources.Resources.shortcut_green
        Me.picShortGreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picShortGreen.Location = New System.Drawing.Point(44, 22)
        Me.picShortGreen.Name = "picShortGreen"
        Me.picShortGreen.Size = New System.Drawing.Size(32, 32)
        Me.picShortGreen.TabIndex = 27
        Me.picShortGreen.TabStop = False
        Me.picShortGreen.Tag = "iconSelections"
        '
        'picEnvBlue
        '
        Me.picEnvBlue.BackgroundImage = Global.QuickerPicker.My.Resources.Resources.env_blue
        Me.picEnvBlue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picEnvBlue.Location = New System.Drawing.Point(6, 60)
        Me.picEnvBlue.Name = "picEnvBlue"
        Me.picEnvBlue.Size = New System.Drawing.Size(32, 32)
        Me.picEnvBlue.TabIndex = 28
        Me.picEnvBlue.TabStop = False
        Me.picEnvBlue.Tag = "iconSelections"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.myIcon)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(100, 100)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "My Icon"
        '
        'myIcon
        '
        Me.myIcon.BackgroundImage = Global.QuickerPicker.My.Resources.Resources.shortcut_blue
        Me.myIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.myIcon.Location = New System.Drawing.Point(25, 30)
        Me.myIcon.Name = "myIcon"
        Me.myIcon.Size = New System.Drawing.Size(50, 50)
        Me.myIcon.TabIndex = 39
        Me.myIcon.TabStop = False
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(466, 126)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "About"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(455, 108)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = resources.GetString("Label5.Text")
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(455, 15)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Quicker Picker - The Quick File Picker"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cbxStartupLoad
        '
        Me.cbxStartupLoad.AutoSize = True
        Me.cbxStartupLoad.Checked = Global.QuickerPicker.My.MySettings.Default.LoadAtStartUp
        Me.cbxStartupLoad.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.QuickerPicker.My.MySettings.Default, "LoadAtStartUp", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbxStartupLoad.Enabled = False
        Me.cbxStartupLoad.Location = New System.Drawing.Point(413, 263)
        Me.cbxStartupLoad.Name = "cbxStartupLoad"
        Me.cbxStartupLoad.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cbxStartupLoad.Size = New System.Drawing.Size(103, 18)
        Me.cbxStartupLoad.TabIndex = 3
        Me.cbxStartupLoad.Text = "Load at Startup"
        Me.cbxStartupLoad.UseCompatibleTextRendering = True
        Me.cbxStartupLoad.UseVisualStyleBackColor = True
        '
        'txtLocation
        '
        Me.txtLocation.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.QuickerPicker.My.MySettings.Default, "Directory", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtLocation.Location = New System.Drawing.Point(122, 260)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(281, 20)
        Me.txtLocation.TabIndex = 2
        Me.txtLocation.Text = Global.QuickerPicker.My.MySettings.Default.Directory
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 288)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.cbxStartupLoad)
        Me.Controls.Add(Me.cmdReload)
        Me.Controls.Add(Me.cmdChange)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.picLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.ShowInTaskbar = False
        Me.Text = "About / Settings"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.picShortLtBlue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEnvYellow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShortMagenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEnvRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShortOrange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEnvPurple, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShortPink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEnvPink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShortPurple, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEnvOrange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShortRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEnvMagenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShortYellow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEnvLtBlue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShortBlue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEnvGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShortGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEnvBlue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.myIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents cmdChange As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmdReload As Button
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents OpenFolderLocationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReloadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents cbxStartupLoad As CheckBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents picEnvYellow As PictureBox
    Friend WithEvents picEnvRed As PictureBox
    Friend WithEvents picEnvPurple As PictureBox
    Friend WithEvents picEnvPink As PictureBox
    Friend WithEvents picEnvOrange As PictureBox
    Friend WithEvents picEnvMagenta As PictureBox
    Friend WithEvents picEnvLtBlue As PictureBox
    Friend WithEvents picEnvGreen As PictureBox
    Friend WithEvents picEnvBlue As PictureBox
    Friend WithEvents picShortGreen As PictureBox
    Friend WithEvents picShortBlue As PictureBox
    Friend WithEvents picShortYellow As PictureBox
    Friend WithEvents picShortRed As PictureBox
    Friend WithEvents picShortPurple As PictureBox
    Friend WithEvents picShortPink As PictureBox
    Friend WithEvents picShortOrange As PictureBox
    Friend WithEvents picShortMagenta As PictureBox
    Friend WithEvents picShortLtBlue As PictureBox
    Friend WithEvents myIcon As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class
