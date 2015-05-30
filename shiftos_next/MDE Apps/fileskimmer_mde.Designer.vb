<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fileskimmer_mde
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fileskimmer_mde))
        Me.Contents = New System.Windows.Forms.Panel()
        Me.windowborder = New shiftos_next.mde_template()
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.lbcurrentfolder = New System.Windows.Forms.ToolStripLabel()
        Me.myfileimages = New System.Windows.Forms.ImageList(Me.components)
        Me.Contents.SuspendLayout()
        Me.windowborder.Content.SuspendLayout()
        Me.windowborder.SuspendLayout()
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
        'Contents
        '
        Me.Contents.BackColor = System.Drawing.Color.White
        Me.Contents.Controls.Add(Me.windowborder)
        Me.Contents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Contents.Location = New System.Drawing.Point(0, 0)
        Me.Contents.Name = "Contents"
        Me.Contents.Size = New System.Drawing.Size(736, 386)
        Me.Contents.TabIndex = 9
        '
        'windowborder
        '
        Me.windowborder.AppName = "File Skimmer"
        '
        'windowborder.Content
        '
        Me.windowborder.Content.BackColor = System.Drawing.Color.White
        Me.windowborder.Content.Controls.Add(Me.ToolStripContainer1)
        Me.windowborder.Content.Dock = System.Windows.Forms.DockStyle.Fill
        Me.windowborder.Content.Location = New System.Drawing.Point(2, 30)
        Me.windowborder.Content.Name = "Content"
        Me.windowborder.Content.Size = New System.Drawing.Size(732, 354)
        Me.windowborder.Content.TabIndex = 4
        Me.windowborder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.windowborder.Location = New System.Drawing.Point(0, 0)
        Me.windowborder.Name = "windowborder"
        Me.windowborder.ShowMaximizeButton = True
        Me.windowborder.ShowMinimizeButton = True
        Me.windowborder.Size = New System.Drawing.Size(736, 386)
        Me.windowborder.TabIndex = 1
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.SplitContainer1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(732, 305)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
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
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'FolderToolStripMenuItem
        '
        Me.FolderToolStripMenuItem.Name = "FolderToolStripMenuItem"
        Me.FolderToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.FolderToolStripMenuItem.Text = "Folder"
        '
        'TextFileToolStripMenuItem
        '
        Me.TextFileToolStripMenuItem.Name = "TextFileToolStripMenuItem"
        Me.TextFileToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.TextFileToolStripMenuItem.Text = "Text File"
        '
        'BATCHScriptToolStripMenuItem
        '
        Me.BATCHScriptToolStripMenuItem.Name = "BATCHScriptToolStripMenuItem"
        Me.BATCHScriptToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.BATCHScriptToolStripMenuItem.Text = "BATCH Script"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
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
        Me.FileActionsToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.FileActionsToolStripMenuItem.Text = "File Actions..."
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'RenameToolStripMenuItem
        '
        Me.RenameToolStripMenuItem.Name = "RenameToolStripMenuItem"
        Me.RenameToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.RenameToolStripMenuItem.Text = "Rename"
        '
        'SendToToolStripMenuItem
        '
        Me.SendToToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DesktopToolStripMenuItem, Me.DocumentsToolStripMenuItem, Me.MusicToolStripMenuItem, Me.PicturesToolStripMenuItem, Me.VideosToolStripMenuItem})
        Me.SendToToolStripMenuItem.Name = "SendToToolStripMenuItem"
        Me.SendToToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.SendToToolStripMenuItem.Text = "Send To..."
        '
        'DesktopToolStripMenuItem
        '
        Me.DesktopToolStripMenuItem.Name = "DesktopToolStripMenuItem"
        Me.DesktopToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.DesktopToolStripMenuItem.Text = "Desktop"
        '
        'DocumentsToolStripMenuItem
        '
        Me.DocumentsToolStripMenuItem.Name = "DocumentsToolStripMenuItem"
        Me.DocumentsToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.DocumentsToolStripMenuItem.Text = "Documents"
        '
        'MusicToolStripMenuItem
        '
        Me.MusicToolStripMenuItem.Name = "MusicToolStripMenuItem"
        Me.MusicToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.MusicToolStripMenuItem.Text = "Music"
        '
        'PicturesToolStripMenuItem
        '
        Me.PicturesToolStripMenuItem.Name = "PicturesToolStripMenuItem"
        Me.PicturesToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.PicturesToolStripMenuItem.Text = "Pictures"
        '
        'VideosToolStripMenuItem
        '
        Me.VideosToolStripMenuItem.Name = "VideosToolStripMenuItem"
        Me.VideosToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.VideosToolStripMenuItem.Text = "Videos"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutExodusForMemphisDesktopEnvironmentToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'AboutExodusForMemphisDesktopEnvironmentToolStripMenuItem
        '
        Me.AboutExodusForMemphisDesktopEnvironmentToolStripMenuItem.Name = "AboutExodusForMemphisDesktopEnvironmentToolStripMenuItem"
        Me.AboutExodusForMemphisDesktopEnvironmentToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.AboutExodusForMemphisDesktopEnvironmentToolStripMenuItem.Text = "About File Skimmer"
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
        Me.lbcurrentfolder.Size = New System.Drawing.Size(85, 22)
        Me.lbcurrentfolder.Text = "C:\shiftos_next"
        '
        'myfileimages
        '
        Me.myfileimages.ImageStream = CType(resources.GetObject("myfileimages.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.myfileimages.TransparentColor = System.Drawing.Color.Transparent
        Me.myfileimages.Images.SetKeyName(0, "Folder")
        Me.myfileimages.Images.SetKeyName(1, "TextFile")
        '
        'fileskimmer_mde
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 386)
        Me.Controls.Add(Me.Contents)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "fileskimmer_mde"
        Me.Text = "ExodusFB_mde"
        Me.TopMost = True
        Me.Contents.ResumeLayout(False)
        Me.windowborder.Content.ResumeLayout(False)
        Me.windowborder.ResumeLayout(False)
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
    Friend WithEvents Contents As System.Windows.Forms.Panel
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
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents tvfolders As System.Windows.Forms.TreeView
    Friend WithEvents lvitems As System.Windows.Forms.ListView
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lbcurrentfolder As System.Windows.Forms.ToolStripLabel
    Friend WithEvents myfileimages As System.Windows.Forms.ImageList
    Friend WithEvents windowborder As shiftos_next.mde_template
End Class
