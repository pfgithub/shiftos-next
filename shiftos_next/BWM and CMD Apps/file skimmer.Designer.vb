<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class file_skimmer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(file_skimmer))
        Me.topmenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.newseperator = New System.Windows.Forms.ToolStripSeparator()
        Me.TextFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitSessionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tools = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.lbcurrentdir = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnnewfolder = New System.Windows.Forms.ToolStripButton()
        Me.btndelete = New System.Windows.Forms.ToolStripButton()
        Me.lvfiles = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pnlsave = New System.Windows.Forms.Panel()
        Me.txtfilename = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.pnltop = New shiftos_next.Titlebar()
        Me.lbextension = New System.Windows.Forms.Label()
        Me.topmenu.SuspendLayout()
        Me.tools.SuspendLayout()
        Me.pnlsave.SuspendLayout()
        Me.SuspendLayout()
        '
        'topmenu
        '
        Me.topmenu.BackColor = System.Drawing.Color.Gray
        Me.topmenu.Font = New System.Drawing.Font("Courier New", 8.25!)
        Me.topmenu.ForeColor = System.Drawing.Color.White
        Me.topmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.topmenu.Location = New System.Drawing.Point(0, 32)
        Me.topmenu.Name = "topmenu"
        Me.topmenu.Size = New System.Drawing.Size(591, 24)
        Me.topmenu.TabIndex = 0
        Me.topmenu.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.ExitSessionToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FolderToolStripMenuItem, Me.newseperator, Me.TextFileToolStripMenuItem})
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'FolderToolStripMenuItem
        '
        Me.FolderToolStripMenuItem.Name = "FolderToolStripMenuItem"
        Me.FolderToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.FolderToolStripMenuItem.Text = "Folder"
        '
        'newseperator
        '
        Me.newseperator.Name = "newseperator"
        Me.newseperator.Size = New System.Drawing.Size(134, 6)
        '
        'TextFileToolStripMenuItem
        '
        Me.TextFileToolStripMenuItem.Name = "TextFileToolStripMenuItem"
        Me.TextFileToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.TextFileToolStripMenuItem.Text = "Text File"
        '
        'ExitSessionToolStripMenuItem
        '
        Me.ExitSessionToolStripMenuItem.Name = "ExitSessionToolStripMenuItem"
        Me.ExitSessionToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.ExitSessionToolStripMenuItem.Text = "Exit Session"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductInfoToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ProductInfoToolStripMenuItem
        '
        Me.ProductInfoToolStripMenuItem.Name = "ProductInfoToolStripMenuItem"
        Me.ProductInfoToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.ProductInfoToolStripMenuItem.Text = "Product Info"
        '
        'tools
        '
        Me.tools.BackColor = System.Drawing.Color.Gray
        Me.tools.Font = New System.Drawing.Font("Courier New", 8.25!)
        Me.tools.ForeColor = System.Drawing.Color.White
        Me.tools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.lbcurrentdir, Me.ToolStripSeparator1, Me.btnnewfolder, Me.btndelete})
        Me.tools.Location = New System.Drawing.Point(0, 56)
        Me.tools.Name = "tools"
        Me.tools.Size = New System.Drawing.Size(591, 25)
        Me.tools.TabIndex = 1
        Me.tools.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(133, 22)
        Me.ToolStripLabel1.Text = "Current Directory:"
        '
        'lbcurrentdir
        '
        Me.lbcurrentdir.Name = "lbcurrentdir"
        Me.lbcurrentdir.Size = New System.Drawing.Size(49, 22)
        Me.lbcurrentdir.Text = "~/Home"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnnewfolder
        '
        Me.btnnewfolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnnewfolder.Image = CType(resources.GetObject("btnnewfolder.Image"), System.Drawing.Image)
        Me.btnnewfolder.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnnewfolder.Name = "btnnewfolder"
        Me.btnnewfolder.Size = New System.Drawing.Size(81, 22)
        Me.btnnewfolder.Text = "New Folder"
        '
        'btndelete
        '
        Me.btndelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btndelete.Image = CType(resources.GetObject("btndelete.Image"), System.Drawing.Image)
        Me.btndelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(53, 22)
        Me.btndelete.Text = "Delete"
        '
        'lvfiles
        '
        Me.lvfiles.BackColor = System.Drawing.Color.Black
        Me.lvfiles.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvfiles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvfiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvfiles.ForeColor = System.Drawing.Color.White
        Me.lvfiles.Location = New System.Drawing.Point(0, 81)
        Me.lvfiles.Name = "lvfiles"
        Me.lvfiles.Size = New System.Drawing.Size(591, 249)
        Me.lvfiles.TabIndex = 3
        Me.lvfiles.UseCompatibleStateImageBehavior = False
        Me.lvfiles.View = System.Windows.Forms.View.Tile
        '
        'pnlsave
        '
        Me.pnlsave.Controls.Add(Me.lbextension)
        Me.pnlsave.Controls.Add(Me.txtfilename)
        Me.pnlsave.Controls.Add(Me.Label1)
        Me.pnlsave.Controls.Add(Me.btnsave)
        Me.pnlsave.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlsave.Location = New System.Drawing.Point(0, 330)
        Me.pnlsave.Name = "pnlsave"
        Me.pnlsave.Size = New System.Drawing.Size(591, 30)
        Me.pnlsave.TabIndex = 4
        '
        'txtfilename
        '
        Me.txtfilename.BackColor = System.Drawing.Color.Black
        Me.txtfilename.ForeColor = System.Drawing.Color.White
        Me.txtfilename.Location = New System.Drawing.Point(86, 5)
        Me.txtfilename.Name = "txtfilename"
        Me.txtfilename.Size = New System.Drawing.Size(376, 20)
        Me.txtfilename.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "File Name:"
        '
        'btnsave
        '
        Me.btnsave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Location = New System.Drawing.Point(513, 4)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 0
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'pnltop
        '
        Me.pnltop.AppName = "File Skimmer"
        Me.pnltop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnltop.Font = New System.Drawing.Font("Courier New", 8.25!)
        Me.pnltop.ForeColor = System.Drawing.Color.White
        Me.pnltop.Location = New System.Drawing.Point(0, 0)
        Me.pnltop.Name = "pnltop"
        Me.pnltop.Size = New System.Drawing.Size(591, 32)
        Me.pnltop.TabIndex = 5
        '
        'lbextension
        '
        Me.lbextension.AutoSize = True
        Me.lbextension.Location = New System.Drawing.Point(468, 8)
        Me.lbextension.Name = "lbextension"
        Me.lbextension.Size = New System.Drawing.Size(35, 14)
        Me.lbextension.TabIndex = 3
        Me.lbextension.Text = ".xxx"
        '
        'file_skimmer
        '
        Me.AcceptButton = Me.btnsave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(591, 360)
        Me.Controls.Add(Me.lvfiles)
        Me.Controls.Add(Me.pnlsave)
        Me.Controls.Add(Me.tools)
        Me.Controls.Add(Me.topmenu)
        Me.Controls.Add(Me.pnltop)
        Me.Font = New System.Drawing.Font("Courier New", 8.25!)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.topmenu
        Me.Name = "file_skimmer"
        Me.Text = "file_skimmer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.topmenu.ResumeLayout(False)
        Me.topmenu.PerformLayout()
        Me.tools.ResumeLayout(False)
        Me.tools.PerformLayout()
        Me.pnlsave.ResumeLayout(False)
        Me.pnlsave.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents topmenu As System.Windows.Forms.MenuStrip
    Friend WithEvents tools As System.Windows.Forms.ToolStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitSessionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lbcurrentdir As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnnewfolder As System.Windows.Forms.ToolStripButton
    Friend WithEvents btndelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents lvfiles As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ProductInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FolderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents newseperator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TextFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlsave As System.Windows.Forms.Panel
    Friend WithEvents txtfilename As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents pnltop As shiftos_next.Titlebar
    Friend WithEvents lbextension As System.Windows.Forms.Label
End Class
