<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExodusFB_mde
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExodusFB_mde))
        Me.Titlebar = New System.Windows.Forms.Panel()
        Me.titletext = New System.Windows.Forms.Label()
        Me.captionbuttonholder = New System.Windows.Forms.Panel()
        Me.minbtn = New System.Windows.Forms.PictureBox()
        Me.maxbtn = New System.Windows.Forms.PictureBox()
        Me.closebtn = New System.Windows.Forms.PictureBox()
        Me.Contents = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.tvfolders = New System.Windows.Forms.TreeView()
        Me.lvitems = New System.Windows.Forms.ListView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BATCHScriptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileActionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SendToToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesktopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MusicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PicturesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VideosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutExodusForMemphisDesktopEnvironmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutExodusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.lbcurrentfolder = New System.Windows.Forms.ToolStripLabel()
        Me.myfileimages = New System.Windows.Forms.ImageList(Me.components)
        Me.Titlebar.SuspendLayout()
        Me.captionbuttonholder.SuspendLayout()
        CType(Me.minbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maxbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closebtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Titlebar
        '
        Me.Titlebar.BackColor = System.Drawing.Color.Red
        Me.Titlebar.BackgroundImage = Global.UltraDOS.My.Resources.Resources.title
        Me.Titlebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Titlebar.Controls.Add(Me.titletext)
        Me.Titlebar.Controls.Add(Me.captionbuttonholder)
        Me.Titlebar.Dock = System.Windows.Forms.DockStyle.Top
        Me.Titlebar.Location = New System.Drawing.Point(2, 0)
        Me.Titlebar.Name = "Titlebar"
        Me.Titlebar.Size = New System.Drawing.Size(732, 30)
        Me.Titlebar.TabIndex = 5
        '
        'titletext
        '
        Me.titletext.BackColor = System.Drawing.Color.Transparent
        Me.titletext.Dock = System.Windows.Forms.DockStyle.Fill
        Me.titletext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.titletext.ForeColor = System.Drawing.Color.White
        Me.titletext.Location = New System.Drawing.Point(0, 0)
        Me.titletext.Name = "titletext"
        Me.titletext.Size = New System.Drawing.Size(637, 30)
        Me.titletext.TabIndex = 0
        Me.titletext.Text = "Application Title"
        Me.titletext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'captionbuttonholder
        '
        Me.captionbuttonholder.BackColor = System.Drawing.Color.Transparent
        Me.captionbuttonholder.Controls.Add(Me.minbtn)
        Me.captionbuttonholder.Controls.Add(Me.maxbtn)
        Me.captionbuttonholder.Controls.Add(Me.closebtn)
        Me.captionbuttonholder.Dock = System.Windows.Forms.DockStyle.Right
        Me.captionbuttonholder.ForeColor = System.Drawing.Color.White
        Me.captionbuttonholder.Location = New System.Drawing.Point(637, 0)
        Me.captionbuttonholder.Name = "captionbuttonholder"
        Me.captionbuttonholder.Size = New System.Drawing.Size(95, 30)
        Me.captionbuttonholder.TabIndex = 1
        '
        'minbtn
        '
        Me.minbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minbtn.Image = Global.UltraDOS.My.Resources.Resources.minimize2
        Me.minbtn.Location = New System.Drawing.Point(14, 5)
        Me.minbtn.Name = "minbtn"
        Me.minbtn.Size = New System.Drawing.Size(22, 22)
        Me.minbtn.TabIndex = 2
        Me.minbtn.TabStop = False
        '
        'maxbtn
        '
        Me.maxbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.maxbtn.Image = Global.UltraDOS.My.Resources.Resources.minimize
        Me.maxbtn.Location = New System.Drawing.Point(42, 5)
        Me.maxbtn.Name = "maxbtn"
        Me.maxbtn.Size = New System.Drawing.Size(22, 22)
        Me.maxbtn.TabIndex = 1
        Me.maxbtn.TabStop = False
        '
        'closebtn
        '
        Me.closebtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.closebtn.Image = Global.UltraDOS.My.Resources.Resources.close
        Me.closebtn.Location = New System.Drawing.Point(70, 5)
        Me.closebtn.Name = "closebtn"
        Me.closebtn.Size = New System.Drawing.Size(22, 22)
        Me.closebtn.TabIndex = 0
        Me.closebtn.TabStop = False
        '
        'Contents
        '
        Me.Contents.BackColor = System.Drawing.Color.White
        Me.Contents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Contents.Location = New System.Drawing.Point(2, 0)
        Me.Contents.Name = "Contents"
        Me.Contents.Size = New System.Drawing.Size(732, 384)
        Me.Contents.TabIndex = 9
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Red
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(2, 384)
        Me.Panel4.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Red
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 384)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(734, 2)
        Me.Panel3.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Red
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(734, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(2, 386)
        Me.Panel2.TabIndex = 6
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.SplitContainer1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(732, 305)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(2, 30)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(732, 354)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.MenuStrip1)
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip1)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.tvfolders)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.lvitems)
        Me.SplitContainer1.Size = New System.Drawing.Size(732, 305)
        Me.SplitContainer1.SplitterDistance = 181
        Me.SplitContainer1.TabIndex = 0
        '
        'tvfolders
        '
        Me.tvfolders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvfolders.Location = New System.Drawing.Point(0, 0)
        Me.tvfolders.Name = "tvfolders"
        Me.tvfolders.Size = New System.Drawing.Size(181, 305)
        Me.tvfolders.TabIndex = 0
        '
        'lvitems
        '
        Me.lvitems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvitems.Location = New System.Drawing.Point(0, 0)
        Me.lvitems.Name = "lvitems"
        Me.lvitems.Size = New System.Drawing.Size(547, 305)
        Me.lvitems.TabIndex = 0
        Me.lvitems.UseCompatibleStateImageBehavior = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(732, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FolderToolStripMenuItem, Me.TextFileToolStripMenuItem, Me.BATCHScriptToolStripMenuItem})
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'FolderToolStripMenuItem
        '
        Me.FolderToolStripMenuItem.Name = "FolderToolStripMenuItem"
        Me.FolderToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FolderToolStripMenuItem.Text = "Folder"
        '
        'TextFileToolStripMenuItem
        '
        Me.TextFileToolStripMenuItem.Name = "TextFileToolStripMenuItem"
        Me.TextFileToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TextFileToolStripMenuItem.Text = "Text File"
        '
        'BATCHScriptToolStripMenuItem
        '
        Me.BATCHScriptToolStripMenuItem.Name = "BATCHScriptToolStripMenuItem"
        Me.BATCHScriptToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BATCHScriptToolStripMenuItem.Text = "BATCH Script"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileActionsToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'FileActionsToolStripMenuItem
        '
        Me.FileActionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem, Me.RenameToolStripMenuItem, Me.SendToToolStripMenuItem})
        Me.FileActionsToolStripMenuItem.Name = "FileActionsToolStripMenuItem"
        Me.FileActionsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FileActionsToolStripMenuItem.Text = "File Actions..."
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'RenameToolStripMenuItem
        '
        Me.RenameToolStripMenuItem.Name = "RenameToolStripMenuItem"
        Me.RenameToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RenameToolStripMenuItem.Text = "Rename"
        '
        'SendToToolStripMenuItem
        '
        Me.SendToToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DesktopToolStripMenuItem, Me.DocumentsToolStripMenuItem, Me.MusicToolStripMenuItem, Me.PicturesToolStripMenuItem, Me.VideosToolStripMenuItem})
        Me.SendToToolStripMenuItem.Name = "SendToToolStripMenuItem"
        Me.SendToToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SendToToolStripMenuItem.Text = "Send To..."
        '
        'DesktopToolStripMenuItem
        '
        Me.DesktopToolStripMenuItem.Name = "DesktopToolStripMenuItem"
        Me.DesktopToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DesktopToolStripMenuItem.Text = "Desktop"
        '
        'DocumentsToolStripMenuItem
        '
        Me.DocumentsToolStripMenuItem.Name = "DocumentsToolStripMenuItem"
        Me.DocumentsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DocumentsToolStripMenuItem.Text = "Documents"
        '
        'MusicToolStripMenuItem
        '
        Me.MusicToolStripMenuItem.Name = "MusicToolStripMenuItem"
        Me.MusicToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MusicToolStripMenuItem.Text = "Music"
        '
        'PicturesToolStripMenuItem
        '
        Me.PicturesToolStripMenuItem.Name = "PicturesToolStripMenuItem"
        Me.PicturesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PicturesToolStripMenuItem.Text = "Pictures"
        '
        'VideosToolStripMenuItem
        '
        Me.VideosToolStripMenuItem.Name = "VideosToolStripMenuItem"
        Me.VideosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VideosToolStripMenuItem.Text = "Videos"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutExodusForMemphisDesktopEnvironmentToolStripMenuItem, Me.AboutExodusToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'AboutExodusForMemphisDesktopEnvironmentToolStripMenuItem
        '
        Me.AboutExodusForMemphisDesktopEnvironmentToolStripMenuItem.Name = "AboutExodusForMemphisDesktopEnvironmentToolStripMenuItem"
        Me.AboutExodusForMemphisDesktopEnvironmentToolStripMenuItem.Size = New System.Drawing.Size(335, 22)
        Me.AboutExodusForMemphisDesktopEnvironmentToolStripMenuItem.Text = "About Exodus for Memphis Desktop Environment"
        '
        'AboutExodusToolStripMenuItem
        '
        Me.AboutExodusToolStripMenuItem.Name = "AboutExodusToolStripMenuItem"
        Me.AboutExodusToolStripMenuItem.Size = New System.Drawing.Size(335, 22)
        Me.AboutExodusToolStripMenuItem.Text = "About Exodus"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.lbcurrentfolder})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(732, 25)
        Me.ToolStrip1.Stretch = True
        Me.ToolStrip1.TabIndex = 1
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(76, 22)
        Me.ToolStripLabel1.Text = "You are here:"
        '
        'lbcurrentfolder
        '
        Me.lbcurrentfolder.Name = "lbcurrentfolder"
        Me.lbcurrentfolder.Size = New System.Drawing.Size(71, 22)
        Me.lbcurrentfolder.Text = "C:\UltraDOS"
        '
        'myfileimages
        '
        Me.myfileimages.ImageStream = CType(resources.GetObject("myfileimages.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.myfileimages.TransparentColor = System.Drawing.Color.Transparent
        Me.myfileimages.Images.SetKeyName(0, "Folder")
        Me.myfileimages.Images.SetKeyName(1, "TextFile")
        '
        'ExodusFB_mde
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 386)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Controls.Add(Me.Titlebar)
        Me.Controls.Add(Me.Contents)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ExodusFB_mde"
        Me.Text = "ExodusFB_mde"
        Me.Titlebar.ResumeLayout(False)
        Me.captionbuttonholder.ResumeLayout(False)
        CType(Me.minbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maxbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closebtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Titlebar As System.Windows.Forms.Panel
    Friend WithEvents titletext As System.Windows.Forms.Label
    Friend WithEvents captionbuttonholder As System.Windows.Forms.Panel
    Friend WithEvents minbtn As System.Windows.Forms.PictureBox
    Friend WithEvents maxbtn As System.Windows.Forms.PictureBox
    Friend WithEvents closebtn As System.Windows.Forms.PictureBox
    Friend WithEvents Contents As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FolderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BATCHScriptToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileActionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RenameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SendToToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DesktopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DocumentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MusicToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PicturesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VideosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutExodusForMemphisDesktopEnvironmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutExodusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents tvfolders As System.Windows.Forms.TreeView
    Friend WithEvents lvitems As System.Windows.Forms.ListView
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lbcurrentfolder As System.Windows.Forms.ToolStripLabel
    Friend WithEvents myfileimages As System.Windows.Forms.ImageList
End Class
