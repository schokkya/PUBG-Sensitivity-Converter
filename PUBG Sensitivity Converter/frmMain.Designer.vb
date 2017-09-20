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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblPath = New System.Windows.Forms.Label()
        Me.btnIncorrect = New System.Windows.Forms.Button()
        Me.TrackFOV = New System.Windows.Forms.TrackBar()
        Me.lblFOV = New System.Windows.Forms.Label()
        Me.txtCSGO = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPUBG = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPUBGSCOPED = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCopyCSGO = New System.Windows.Forms.Button()
        Me.btnCopyPUBG = New System.Windows.Forms.Button()
        Me.btnCopyPUBGSCOPE = New System.Windows.Forms.Button()
        Me.btnAutoSet = New System.Windows.Forms.Button()
        Me.txtHelp = New System.Windows.Forms.TextBox()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.TrackFOV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPath
        '
        Me.lblPath.AutoSize = True
        Me.lblPath.Location = New System.Drawing.Point(5, 173)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(83, 13)
        Me.lblPath.TabIndex = 0
        Me.lblPath.Text = "Config file path: "
        '
        'btnIncorrect
        '
        Me.btnIncorrect.Location = New System.Drawing.Point(8, 189)
        Me.btnIncorrect.Name = "btnIncorrect"
        Me.btnIncorrect.Size = New System.Drawing.Size(155, 23)
        Me.btnIncorrect.TabIndex = 1
        Me.btnIncorrect.Text = "Incorrect path to config file?"
        Me.btnIncorrect.UseVisualStyleBackColor = True
        '
        'TrackFOV
        '
        Me.TrackFOV.Location = New System.Drawing.Point(8, 239)
        Me.TrackFOV.Maximum = 103
        Me.TrackFOV.Minimum = 80
        Me.TrackFOV.Name = "TrackFOV"
        Me.TrackFOV.Size = New System.Drawing.Size(649, 45)
        Me.TrackFOV.TabIndex = 2
        Me.TrackFOV.Value = 80
        '
        'lblFOV
        '
        Me.lblFOV.AutoSize = True
        Me.lblFOV.Location = New System.Drawing.Point(8, 223)
        Me.lblFOV.Name = "lblFOV"
        Me.lblFOV.Size = New System.Drawing.Size(120, 13)
        Me.lblFOV.TabIndex = 3
        Me.lblFOV.Text = "FOV setting in-game: 80"
        '
        'txtCSGO
        '
        Me.txtCSGO.Location = New System.Drawing.Point(104, 281)
        Me.txtCSGO.Name = "txtCSGO"
        Me.txtCSGO.Size = New System.Drawing.Size(60, 20)
        Me.txtCSGO.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 284)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "CSGO Sensitivity:"
        '
        'txtPUBG
        '
        Me.txtPUBG.Enabled = False
        Me.txtPUBG.Location = New System.Drawing.Point(310, 281)
        Me.txtPUBG.Name = "txtPUBG"
        Me.txtPUBG.Size = New System.Drawing.Size(60, 20)
        Me.txtPUBG.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(214, 284)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "PUBG Sensitivity:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(411, 284)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "PUBG Sensitivity(scoped):"
        '
        'txtPUBGSCOPED
        '
        Me.txtPUBGSCOPED.Enabled = False
        Me.txtPUBGSCOPED.Location = New System.Drawing.Point(556, 281)
        Me.txtPUBGSCOPED.Name = "txtPUBGSCOPED"
        Me.txtPUBGSCOPED.Size = New System.Drawing.Size(60, 20)
        Me.txtPUBGSCOPED.TabIndex = 6
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(666, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'btnCopyCSGO
        '
        Me.btnCopyCSGO.Font = New System.Drawing.Font("Optima", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCopyCSGO.Location = New System.Drawing.Point(170, 284)
        Me.btnCopyCSGO.Name = "btnCopyCSGO"
        Me.btnCopyCSGO.Size = New System.Drawing.Size(35, 17)
        Me.btnCopyCSGO.TabIndex = 8
        Me.btnCopyCSGO.Text = "copy"
        Me.btnCopyCSGO.UseVisualStyleBackColor = True
        '
        'btnCopyPUBG
        '
        Me.btnCopyPUBG.Font = New System.Drawing.Font("Optima", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCopyPUBG.Location = New System.Drawing.Point(376, 284)
        Me.btnCopyPUBG.Name = "btnCopyPUBG"
        Me.btnCopyPUBG.Size = New System.Drawing.Size(35, 17)
        Me.btnCopyPUBG.TabIndex = 8
        Me.btnCopyPUBG.Text = "copy"
        Me.btnCopyPUBG.UseVisualStyleBackColor = True
        '
        'btnCopyPUBGSCOPE
        '
        Me.btnCopyPUBGSCOPE.Font = New System.Drawing.Font("Optima", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCopyPUBGSCOPE.Location = New System.Drawing.Point(622, 284)
        Me.btnCopyPUBGSCOPE.Name = "btnCopyPUBGSCOPE"
        Me.btnCopyPUBGSCOPE.Size = New System.Drawing.Size(35, 17)
        Me.btnCopyPUBGSCOPE.TabIndex = 8
        Me.btnCopyPUBGSCOPE.Text = "copy"
        Me.btnCopyPUBGSCOPE.UseVisualStyleBackColor = True
        '
        'btnAutoSet
        '
        Me.btnAutoSet.Location = New System.Drawing.Point(436, 307)
        Me.btnAutoSet.Name = "btnAutoSet"
        Me.btnAutoSet.Size = New System.Drawing.Size(214, 23)
        Me.btnAutoSet.TabIndex = 9
        Me.btnAutoSet.Text = "Automatically apply changes to my config"
        Me.btnAutoSet.UseVisualStyleBackColor = True
        '
        'txtHelp
        '
        Me.txtHelp.Enabled = False
        Me.txtHelp.Location = New System.Drawing.Point(8, 335)
        Me.txtHelp.Multiline = True
        Me.txtHelp.Name = "txtHelp"
        Me.txtHelp.Size = New System.Drawing.Size(646, 130)
        Me.txtHelp.TabIndex = 10
        '
        'btnBackup
        '
        Me.btnBackup.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.btnBackup.Location = New System.Drawing.Point(8, 307)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(165, 23)
        Me.btnBackup.TabIndex = 11
        Me.btnBackup.Text = "Create backup of current config file"
        Me.btnBackup.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(649, 143)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 333)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnBackup)
        Me.Controls.Add(Me.txtHelp)
        Me.Controls.Add(Me.btnAutoSet)
        Me.Controls.Add(Me.btnCopyPUBGSCOPE)
        Me.Controls.Add(Me.btnCopyPUBG)
        Me.Controls.Add(Me.btnCopyCSGO)
        Me.Controls.Add(Me.txtPUBGSCOPED)
        Me.Controls.Add(Me.txtPUBG)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCSGO)
        Me.Controls.Add(Me.lblFOV)
        Me.Controls.Add(Me.TrackFOV)
        Me.Controls.Add(Me.btnIncorrect)
        Me.Controls.Add(Me.lblPath)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "PUBG Sensitivity Converter by SCHOKK-YA"
        CType(Me.TrackFOV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPath As Label
    Friend WithEvents btnIncorrect As Button
    Friend WithEvents TrackFOV As TrackBar
    Friend WithEvents lblFOV As Label
    Friend WithEvents txtCSGO As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPUBG As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPUBGSCOPED As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnCopyCSGO As Button
    Friend WithEvents btnCopyPUBG As Button
    Friend WithEvents btnCopyPUBGSCOPE As Button
    Friend WithEvents btnAutoSet As Button
    Friend WithEvents txtHelp As TextBox
    Friend WithEvents btnBackup As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
