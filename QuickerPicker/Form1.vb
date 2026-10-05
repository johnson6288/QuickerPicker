Imports System.Drawing.Text
Imports System.Globalization
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Win32
Imports System.Security.Principal
Imports System.IO
Imports System.Reflection
'Imports QuickerPicker.My
Public Class frmMain
    ' Create boolean to disable checkbox actions until after they checked and initial value set
    Private disableCheckBoxActions As Boolean = True
    Public thisProgramName As String
    ' Create the registry key object.
    Public regKey As Object
    'INPUT TEST 10/28/2025 2:53pm
    Public myDir = My.Settings.Directory
    Public okToExit As Boolean = False
    Public unapprovedFiles As Boolean = False
    Private Sub LoadMenu()
        Dim i As Long = 0
        unapprovedFiles = False


        'Testing for future use of folders in the picker. It can either open the folder, or be a nested menu
        'For Each folder As String In System.IO.Directory.GetDirectories(myDir)
        'MsgBox(folder)
        'Next


        For Each file As String In System.IO.Directory.GetFiles(myDir)
            'ComboBox1.Items.Add(System.IO.Path.GetFileName(file))
            If LCase(System.IO.Path.GetExtension(file)) = ".exe" Or LCase(System.IO.Path.GetExtension(file)) = ".com" Or LSet(System.IO.Path.GetFileNameWithoutExtension(file), 1) = "~" Then
                unapprovedFiles = True


            Else
                Dim tempName As New ToolStripMenuItem
                tempName.Name = "mnuName" + i.ToString
                tempName.Text = (System.IO.Path.GetFileName(file))
                tempName.Image = (System.Drawing.Icon.ExtractAssociatedIcon(file)).ToBitmap

                'MsgBox(tempName.Name)
                AddHandler(tempName.Click), AddressOf ToolMenuItem_Click
                'tempName.Enabled = True
                ContextMenuStrip1.Items.Add(tempName)
                'ContextMenuStrip1.Items.Add(System.IO.Path.GetFileName(file))
                'Me.ToolStripMenuItem5555 = New System.Windows.Forms.ToolStripMenuItem()
                'ContextMenuStrip1.Items.Add
                i += 1
                'MsgBox(i)
            End If
        Next


        txtLocation.Text = My.Settings.Directory
        'Dim newIcon As Icon
        'newIcon = My.Settings.TrayIcon

        'If My.User.IsInRole(ApplicationServices.BuiltInRole.Administrator) Then
        '    cbxStartupLoad.Enabled = True
        '    ToolTip1.SetToolTip(cbxStartupLoad, "Must Run As Administrator")
        'Else
        '    cbxStartupLoad.Enabled = False
        '    ToolTip1.SetToolTip(cbxStartupLoad, "Must Run As Administrator")
        'End If
        'MsgBox(My.Settings.TrayIcon)
        'NotifyIcon1.Icon = Icon.FromHandle(mystring())
        Dim resources = My.Resources.ResourceManager.GetResourceSet(Globalization.CultureInfo.CurrentCulture, True, True)
        'Dim icons As New List(Of Icon)
        For Each resource As DictionaryEntry In resources
            'MsgBox(resource.Key.ToString)
            If resource.Key.ToString = My.Settings.TrayIcon Then
                'MsgBox(resource.Key.ToString)
                NotifyIcon1.Icon = Icon.FromHandle(resource.Value.GetHicon())
                Dim mystring = "Global.QuickerPicker.My.Resources.Resources." & resource.ToString
                'myIcon.BackgroundImage = 
                'icons.Add(DirectCast(resource.Value, Icon))
            End If
        Next
    End Sub

    Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.Hide()
        Me.ShowInTaskbar = False
    End Sub

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Visible = False
        ShowInTaskbar = False
        thisProgramName = Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().Location)
        regKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).GetValue("QP_" & thisProgramName)
        'regKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
        'MsgBox(regKey)
        'If My.Settings.Directory = "<undefined>" Then
        '    Me.Show()
        '    MsgBox("Please setup your desired folder",, "Initial Setup")
        '    CmdChange_Click(Me, e)
        'End If
        'Check to see if the registry exists to load on startup and check the box if so
        ' Check if it exists
        If regKey Is Nothing Then
            'MsgBox("Registry key Not found.")
            cbxStartupLoad.Checked = False
        Else
            'MsgBox("Registry key exists.")
            cbxStartupLoad.Checked = True
        End If
        disableCheckBoxActions = False

        LoadMenu()

        'MsgBox(My.Settings.myIconPictureBox)
        'Loop through GroupBox2 controls to determine which picturebox matches the settings
        For Each cnt As Control In Me.GroupBox2.Controls
            'MsgBox(cnt.Name)
            If cnt.Tag = "iconSelections" Then
                'If TypeOf cnt Is PictureBox Then
                If cnt.Name = My.Settings.myIconPictureBox Then
                    'MsgBox(cnt.Name)
                    myIcon.BackgroundImage = cnt.BackgroundImage
                End If
            End If
        Next

        NotifyIcon1.Text = thisProgramName
        NotifyIcon1.Visible = True
    End Sub
    Private Sub ToolMenuItem_Click(sender As Object, ByVal e As EventArgs)
        Try
            Process.Start(myDir + sender.ToString)
        Catch
            MsgBox("Unable to load the Picker item. If you have deleted Or renamed a file, a reload will be needed.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Minimized Then
            Me.Hide()
        Else
            Me.Show()
        End If
    End Sub
    Private Sub Window_Closing(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If okToExit = False Then
            WindowState = FormWindowState.Minimized
            e.Cancel = True
        End If
    End Sub


    Private Sub NotifyIcon1_DoubleClick(sender As Object, e As EventArgs) Handles NotifyIcon1.DoubleClick
        Me.Text = "About / Settings - " & thisProgramName
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        Me.ShowInTaskbar = True
    End Sub

    Private Sub CmdChange_Click(sender As Object, e As EventArgs) Handles cmdChange.Click
        'OpenFileDialog1.ShowDialog()
        'TextBox1.Text = OpenFileDialog1.InitialDirectory
        'MsgBox(ContextMenuStrip1.Controls.ToString)
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            txtLocation.Text = FolderBrowserDialog1.SelectedPath + "\"
            myDir = txtLocation.Text
            My.Settings.Save()
            'MsgBox("The Menu Will Now Reload",, "Location Updated")
            CmdReload_Click(sender, e)
            If unapprovedFiles = True Then
                MsgBox("Your Picker folder contains files that have been skipped for security reasons. " &
                       "These could be applications or files that contain a .BAT or .EXE extension." & vbCrLf & vbCrLf &
                       "If you wish to use these files in your Picker, it is recommended to set up a shortcut " &
                       "and place it in the Picker folder.", vbCritical, "Security Notification")
            End If



        End If
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        Me.ShowInTaskbar = True
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        okToExit = True
        'Me.Close()
        Application.Exit()
    End Sub

    Private Sub CmdReload_Click(sender As Object, e As EventArgs) Handles cmdReload.Click
        ContextMenuStrip1.Items.Clear()
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.OpenFolderLocationToolStripMenuItem, Me.ToolStripSeparator1})
        LoadMenu()
        MsgBox("The Picker Has Been Updated", MsgBoxStyle.Information, "Notice")
    End Sub

    Private Sub OpenFolderLocationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFolderLocationToolStripMenuItem.Click
        Process.Start(myDir)
    End Sub

    Private Sub ReloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReloadToolStripMenuItem.Click
        CmdReload_Click(sender, e)
    End Sub

    Private Sub CbxStartupLoad_CheckedChanged(sender As Object, e As EventArgs) Handles cbxStartupLoad.CheckedChanged
        If disableCheckBoxActions Then Exit Sub
        'MsgBox("Checked")
        'Dim thisProgramName As String
        'Dim regKey As Microsoft.Win32.RegistryKey

        regKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
        If cbxStartupLoad.Checked = True Then
            'MsgBox("true")
            regKey.SetValue("QP_" & thisProgramName, Application.ExecutablePath)
            regKey.Close()
        Else
            'MsgBox("False")
            regKey.DeleteValue("QP_" & thisProgramName, False)
            regKey.Close()
        End If
    End Sub

    Private Sub NotifyIcon1_MouseUp(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseUp
        'ContextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y)
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles picShortRed.Click
        myIcon.BackgroundImage = picShortRed.BackgroundImage
        My.Settings.TrayIcon = "shortcut_red"
        My.Settings.myIconPictureBox = sender.name
        NotifyIcon1.Icon = Icon.FromHandle(My.Resources.shortcut_red.GetHicon())
        My.Settings.Save()
        My.Settings.Reload()
    End Sub
    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles picShortBlue.Click
        myIcon.BackgroundImage = picShortBlue.Image
        My.Settings.TrayIcon = "shortcut_blue"
        My.Settings.myIconPictureBox = sender.name
        NotifyIcon1.Icon = Icon.FromHandle(My.Resources.shortcut_blue.GetHicon())
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles picEnvLtBlue.Click
        myIcon.BackgroundImage = picEnvLtBlue.BackgroundImage
        My.Settings.TrayIcon = "env_ltblue"
        My.Settings.myIconPictureBox = sender.name
        NotifyIcon1.Icon = Icon.FromHandle(My.Resources.env_ltblue.GetHicon())
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles picShortGreen.Click
        myIcon.BackgroundImage = picShortGreen.BackgroundImage
        My.Settings.TrayIcon = "shortcut_green"
        My.Settings.myIconPictureBox = sender.name
        NotifyIcon1.Icon = Icon.FromHandle(My.Resources.shortcut_green.GetHicon())
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles picEnvPurple.Click
        myIcon.BackgroundImage = picEnvPurple.BackgroundImage
        My.Settings.TrayIcon = "env_purple"
        My.Settings.myIconPictureBox = sender.name
        NotifyIcon1.Icon = Icon.FromHandle(My.Resources.env_purple.GetHicon())
        My.Settings.Save()
        My.Settings.Reload()
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picShortLtBlue.Click
        myIcon.BackgroundImage = picShortLtBlue.BackgroundImage
        My.Settings.TrayIcon = "shortcut_ltblue"
        My.Settings.myIconPictureBox = sender.name
        NotifyIcon1.Icon = Icon.FromHandle(My.Resources.shortcut_ltblue.GetHicon())
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles picShortMagenta.Click
        myIcon.BackgroundImage = picShortMagenta.BackgroundImage
        My.Settings.TrayIcon = "shortcut_magenta"
        My.Settings.myIconPictureBox = sender.name
        NotifyIcon1.Icon = Icon.FromHandle(My.Resources.shortcut_magenta.GetHicon())
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles picShortOrange.Click
        myIcon.BackgroundImage = picShortOrange.BackgroundImage
        My.Settings.TrayIcon = "shortcut_orange"
        My.Settings.myIconPictureBox = sender.name
        NotifyIcon1.Icon = Icon.FromHandle(My.Resources.shortcut_orange.GetHicon())
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles picShortPink.Click
        myIcon.BackgroundImage = picShortPink.BackgroundImage
        My.Settings.TrayIcon = "shortcut_pink"
        My.Settings.myIconPictureBox = sender.name
        NotifyIcon1.Icon = Icon.FromHandle(My.Resources.shortcut_pink.GetHicon())
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles picShortPurple.Click
        myIcon.BackgroundImage = picShortPurple.BackgroundImage
        My.Settings.TrayIcon = "shortcut_purple"
        My.Settings.myIconPictureBox = sender.name
        NotifyIcon1.Icon = Icon.FromHandle(My.Resources.shortcut_purple.GetHicon())
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles picShortYellow.Click
        myIcon.BackgroundImage = picShortYellow.BackgroundImage
        My.Settings.TrayIcon = "shortcut_yellow"
        My.Settings.myIconPictureBox = sender.name
        NotifyIcon1.Icon = Icon.FromHandle(My.Resources.shortcut_yellow.GetHicon())
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles picEnvGreen.Click
        myIcon.BackgroundImage = picEnvGreen.BackgroundImage
        My.Settings.TrayIcon = "env_green"
        My.Settings.myIconPictureBox = sender.name
        NotifyIcon1.Icon = Icon.FromHandle(My.Resources.env_green.GetHicon())
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles picEnvMagenta.Click
        myIcon.BackgroundImage = picEnvMagenta.BackgroundImage
        My.Settings.TrayIcon = "env_magenta"
        My.Settings.myIconPictureBox = sender.name
        NotifyIcon1.Icon = Icon.FromHandle(My.Resources.env_magenta.GetHicon())
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles picEnvOrange.Click
        myIcon.BackgroundImage = picEnvOrange.BackgroundImage
        My.Settings.TrayIcon = "env_orange"
        My.Settings.myIconPictureBox = sender.name
        NotifyIcon1.Icon = Icon.FromHandle(My.Resources.env_orange.GetHicon())
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles picEnvPink.Click
        myIcon.BackgroundImage = picEnvPink.BackgroundImage
        My.Settings.TrayIcon = "env_pink"
        My.Settings.myIconPictureBox = sender.name
        NotifyIcon1.Icon = Icon.FromHandle(My.Resources.env_pink.GetHicon())
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles picEnvRed.Click
        myIcon.BackgroundImage = picEnvRed.BackgroundImage
        My.Settings.TrayIcon = "env_red"
        My.Settings.myIconPictureBox = sender.name
        NotifyIcon1.Icon = Icon.FromHandle(My.Resources.env_red.GetHicon())
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles picEnvYellow.Click
        myIcon.BackgroundImage = picEnvYellow.BackgroundImage
        My.Settings.TrayIcon = "env_yellow"
        My.Settings.myIconPictureBox = sender.name
        NotifyIcon1.Icon = Icon.FromHandle(My.Resources.env_yellow.GetHicon())
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles picEnvBlue.Click
        myIcon.BackgroundImage = picEnvBlue.BackgroundImage
        My.Settings.TrayIcon = "env_blue"
        My.Settings.myIconPictureBox = sender.name
        NotifyIcon1.Icon = Icon.FromHandle(My.Resources.env_blue.GetHicon())
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        thisProgramName = Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().Location)
        'MsgBox(thisProgramName)
        ' Create the registry key object.
        Dim regKey As Object = Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).GetValue("QP_" & thisProgramName)
        'MsgBox("regKey= " & regKey)
        ' Check if it exists
        If regKey Is Nothing Then
            MsgBox("Registry key not found.")
        Else
            MsgBox("Registry key exists.")
        End If
    End Sub

    Private Sub NotifyIcon1_MouseClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseClick
        ' Check if the left mouse button was clicked 
        ' AND if the Shift key is currently held down
        If e.Button = MouseButtons.Left AndAlso Control.ModifierKeys = Keys.Shift Then
            ' Close the application cleanly
            Application.Exit()
        End If

        ' Check if the left mouse button was clicked 
        ' AND if the Ctrl key is currently held down
        If e.Button = MouseButtons.Left AndAlso Control.ModifierKeys = Keys.Control Then
            ' Run the reload code
            CmdReload_Click(sender, e)
        End If

        ' Check if the left mouse button was clicked 
        ' AND if the Alt key is currently held down
        If e.Button = MouseButtons.Left AndAlso Control.ModifierKeys = Keys.Alt Then
            ' Open the settings
            Me.Show()
            Me.WindowState = FormWindowState.Normal
            Me.ShowInTaskbar = True
        End If
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.WindowsShutDown Then
            e.Cancel = False
        End If
    End Sub
End Class