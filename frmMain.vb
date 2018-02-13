Public Class frmMain
    Dim configpath, backupdate As String
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        configpath = GetConfig()
        If Not configpath = "NULL" Then
            lblPath.Text = "Config file path: " & configpath
        Else
            lblPath.Text = "Config file path: CONFIG NOT FOUND, GAME INSTALLED PROPERLY?"
        End If
        txtHelp.Text = "How to use: 
1) Make sure the game is not running!!
2) Make sure the location of the 'GameUserSettings.ini' config file is correct, if not then manually change it. 
3) Enter your CSGO sensitivity in the textbox, set the FOV slider to your in-game FOV setting and you should see the rest of the textboxes     changing.
4) You can either go to the path of your config to copy and paste the calculated values yourself now. 
    Or you could just press the 'Automatically apply changes to my config' button and the program will set the values for you.
5) Start the game and don't change the sliders in-game or you will have to do this process again. 
    Any changes to the controls you make will overwrite the changes made by this program or yourself if done manually."
    End Sub
    Public Function GetConfig() As String
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\TslGame\Saved\Config\WindowsNoEditor"
        If IO.File.Exists(path & "\GameUserSettings.ini") Then
            Return path & "\GameUserSettings.ini"
        Else
            Return "NULL"
        End If
    End Function

    Private Sub btnIncorrect_Click(sender As Object, e As EventArgs) Handles btnIncorrect.Click
        Dim ofd As New OpenFileDialog
        With ofd
            .FileName = "GameUserSettings.ini"
            .Title = "Show me the way to GameUserSettings.ini"
            .DefaultExt = ".ini"
            .Filter = "ini configuration (.ini)|*.ini"
            If .ShowDialog = DialogResult.OK Then
                MsgBox(.FileName)
                If IO.File.Exists(.FileName) Then
                    configpath = .FileName
                    lblPath.Text = "Config file path: " & configpath
                Else
                    MsgBox("Invalid file chosen.", MsgBoxStyle.Critical)
                End If
            End If
        End With
    End Sub

    Private Sub TrackFOV_Scroll(sender As Object, e As EventArgs) Handles TrackFOV.Scroll
        lblFOV.Text = "FOV setting in-game: " & TrackFOV.Value
        If Not txtCSGO.Text = "" Then
            Dim csgosens As Decimal = CDec(txtCSGO.Text)
            txtPUBG.Text = Math.Round(csgosens / 101.0101 * 80 / TrackFOV.Value, 6).ToString
            txtPUBGSCOPED.Text = Math.Round(csgosens / 88.38, 6).ToString
        End If
    End Sub

    Private Sub txtCSGO_TextChanged(sender As Object, e As EventArgs) Handles txtCSGO.TextChanged
        If Not txtCSGO.Text = "" Then
            Dim csgosens As Decimal = CDec(txtCSGO.Text)
            txtPUBG.Text = Math.Round(csgosens / 101.0101 * 80 / TrackFOV.Value, 6).ToString
            txtPUBGSCOPED.Text = Math.Round(csgosens / 88.38, 6).ToString
        End If
    End Sub

    Private Sub btnCopyCSGO_Click(sender As Object, e As EventArgs) Handles btnCopyCSGO.Click
        My.Computer.Clipboard.SetText(txtCSGO.Text)
    End Sub

    Private Sub btnCopyPUBG_Click(sender As Object, e As EventArgs) Handles btnCopyPUBG.Click
        My.Computer.Clipboard.SetText(txtPUBG.Text)
    End Sub

    Private Sub btnCopyPUBGSCOPE_Click(sender As Object, e As EventArgs) Handles btnCopyPUBGSCOPE.Click
        My.Computer.Clipboard.SetText(txtPUBGSCOPED.Text)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.Show()
    End Sub
    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        If Me.Size = New Size(682, 372) Then
            Me.Size = New Size(682, 512)
        Else
            Me.Size = New Size(682, 372)
        End If
    End Sub
    Private Sub btnAutoSet_Click(sender As Object, e As EventArgs) Handles btnAutoSet.Click
        If Not configpath = "NULL" Then
            If txtCSGO.Text = "" Then
                MsgBox("Please enter your CSGO sensitivity.")
            Else
                If IO.File.Exists(configpath) Then
                    Dim config As List(Of String) = IO.File.ReadAllLines(configpath).ToList()
                    For i = 0 To config.Count - 1
                        If config(i).Contains("MouseSensitiveList=") Then
                            For j = 0 To 7
                                Dim indexpos As Integer
                                If j = 0 Then
                                    indexpos = config(i).IndexOf("LastConvertedMouseSensitivity=") + 30
                                Else
                                    indexpos = config(i).IndexOf("LastConvertedMouseSensitivity=", indexpos) + 30
                                End If
                                If j < 3 Then
                                    config(i) = config(i).Remove(indexpos, 8).Insert(indexpos, txtPUBG.Text)
                                ElseIf j >= 3 And j < 8 Then
                                    config(i) = config(i).Remove(indexpos, 8).Insert(indexpos, txtPUBGSCOPED.Text)
                                End If
                            Next
                            IO.File.WriteAllLines(configpath, config)
                            MsgBox("Config file written! (I hope, hehe xd)")
                        End If
                    Next
                End If
            End If
        Else
            MsgBox("CONFIG NOT FOUND, GAME INSTALLED PROPERLY?")
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        Dim DateToday As String = String.Format("{0:dd.MM.yyyy - HH.mm}", DateTime.Now)
        backupdate = String.Format("{0:dd.MM.yyyy - HH.mm}", DateTime.Now)
        If Not IO.Directory.Exists(Application.StartupPath & "\Backups") Then
            IO.Directory.CreateDirectory(Application.StartupPath & "\Backups")
            If Not IO.Directory.Exists(Application.StartupPath & "\Backups\" & DateToday) Then
                IO.Directory.CreateDirectory(Application.StartupPath & "\Backups\" & DateToday)
                IO.File.Copy((configpath), Application.StartupPath & "\Backups\" & DateToday & "\GameUserSettings.ini")
            Else
                MsgBox("You can only create one backup per minute, sorry.")
            End If
        Else
            If Not IO.Directory.Exists(Application.StartupPath & "\Backups\" & DateToday) Then
                IO.Directory.CreateDirectory(Application.StartupPath & "\Backups\" & DateToday)
                IO.File.Copy((configpath), Application.StartupPath & "\Backups\" & DateToday & "\GameUserSettings.ini")
            Else
                MsgBox("You can only create one backup per minute, sorry.")
            End If
        End If
    End Sub
End Class
