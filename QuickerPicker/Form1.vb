Imports System.Drawing.Text
Imports System.Globalization
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Form1
    Public myDir = My.Settings.Directory
    Public okToExit As Boolean = False
    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Long = 0
        For Each file As String In System.IO.Directory.GetFiles(myDir)
            'ComboBox1.Items.Add(System.IO.Path.GetFileName(file))
            If System.IO.Path.GetExtension(file) = ".exe" Or System.IO.Path.GetExtension(file) = ".com" Then
                'Do Nothing
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
        TextBox1.Text = My.Settings.Directory
    End Sub
    Private Sub ToolMenuItem_Click(sender As Object, ByVal e As EventArgs)
        Process.Start(myDir + sender.ToString)
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
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        Me.ShowInTaskbar = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'OpenFileDialog1.ShowDialog()
        'TextBox1.Text = OpenFileDialog1.InitialDirectory
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            TextBox1.Text = FolderBrowserDialog1.SelectedPath + "\"
            My.Settings.Save()
            MsgBox("The Application Will Now Restart",, "Location Updated")
            Application.Restart()

        End If
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        Me.ShowInTaskbar = True
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        okToExit = True
        Me.Close()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.Hide()
        Application.Restart()
    End Sub

    Private Sub OpenFolderLocationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFolderLocationToolStripMenuItem.Click
        Process.Start(myDir)
    End Sub

End Class