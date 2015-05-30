Namespace ShiftDE
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class SDE_File_Skimmer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SDE_File_Skimmer))
        Me.fileactions = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.lbllocation = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btndeletefile = New System.Windows.Forms.Button()
        Me.btnnewfolder = New System.Windows.Forms.Button()
        Me.pnlbreak = New System.Windows.Forms.Panel()
        Me.pnloptions = New System.Windows.Forms.Panel()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.lvfiles = New System.Windows.Forms.ListView()
        Me.pgcontents = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout
        Me.pnloptions.SuspendLayout
        Me.pgcontents.SuspendLayout
        Me.SuspendLayout
        '
        'fileactions
        '
        Me.fileactions.BackColor = System.Drawing.Color.Black
        Me.fileactions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.fileactions.Name = "fileactions"
        Me.fileactions.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.fileactions.Size = New System.Drawing.Size(61, 4)
        '
        'lbllocation
        '
        Me.lbllocation.BackColor = System.Drawing.Color.White
        Me.lbllocation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbllocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbllocation.ForeColor = System.Drawing.Color.Black
        Me.lbllocation.Location = New System.Drawing.Point(0, 0)
        Me.lbllocation.Name = "lbllocation"
        Me.lbllocation.Size = New System.Drawing.Size(587, 31)
        Me.lbllocation.TabIndex = 0
        Me.lbllocation.Text = "C:/ShiftOS/"
        Me.lbllocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 31)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(587, 2)
        Me.Panel2.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lbllocation)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(587, 31)
        Me.Panel1.TabIndex = 4
        '
        'btndeletefile
        '
        Me.btndeletefile.BackColor = System.Drawing.Color.White
        Me.btndeletefile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndeletefile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btndeletefile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndeletefile.Location = New System.Drawing.Point(129, 4)
        Me.btndeletefile.Name = "btndeletefile"
        Me.btndeletefile.Size = New System.Drawing.Size(130, 31)
        Me.btndeletefile.TabIndex = 4
        Me.btndeletefile.Text = "Delete Folder"
        Me.btndeletefile.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btndeletefile.UseVisualStyleBackColor = false
        '
        'btnnewfolder
        '
        Me.btnnewfolder.BackColor = System.Drawing.Color.White
        Me.btnnewfolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnewfolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnnewfolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnnewfolder.Location = New System.Drawing.Point(6, 4)
        Me.btnnewfolder.Name = "btnnewfolder"
        Me.btnnewfolder.Size = New System.Drawing.Size(117, 31)
        Me.btnnewfolder.TabIndex = 3
        Me.btnnewfolder.Text = "New Folder"
        Me.btnnewfolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnnewfolder.UseVisualStyleBackColor = false
        '
        'pnlbreak
        '
        Me.pnlbreak.BackColor = System.Drawing.Color.White
        Me.pnlbreak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlbreak.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlbreak.ForeColor = System.Drawing.Color.Black
        Me.pnlbreak.Location = New System.Drawing.Point(0, 341)
        Me.pnlbreak.Name = "pnlbreak"
        Me.pnlbreak.Size = New System.Drawing.Size(587, 15)
        Me.pnlbreak.TabIndex = 7
        '
        'pnloptions
        '
        Me.pnloptions.Controls.Add(Me.btndeletefile)
        Me.pnloptions.Controls.Add(Me.btnnewfolder)
        Me.pnloptions.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnloptions.Location = New System.Drawing.Point(0, 303)
        Me.pnloptions.Name = "pnloptions"
        Me.pnloptions.Size = New System.Drawing.Size(587, 38)
        Me.pnloptions.TabIndex = 6
        Me.pnloptions.Visible = false
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"),System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "folder.png")
        Me.ImageList1.Images.SetKeyName(1, "unknown.png")
        Me.ImageList1.Images.SetKeyName(2, "textfile.png")
        Me.ImageList1.Images.SetKeyName(3, "imagefile.png")
        Me.ImageList1.Images.SetKeyName(4, "videofile.png")
        Me.ImageList1.Images.SetKeyName(5, "folderup.png")
        Me.ImageList1.Images.SetKeyName(6, "philips dll.png")
        Me.ImageList1.Images.SetKeyName(7, "philips exe.png")
        Me.ImageList1.Images.SetKeyName(8, "config.png")
        Me.ImageList1.Images.SetKeyName(9, "driver.png")
        Me.ImageList1.Images.SetKeyName(10, "skinfile.png")
        Me.ImageList1.Images.SetKeyName(11, "namelistfile.png")
        Me.ImageList1.Images.SetKeyName(12, "iconpackfile.png")
        Me.ImageList1.Images.SetKeyName(13, "iconins.png")
        Me.ImageList1.Images.SetKeyName(14, "icontrm.png")
        Me.ImageList1.Images.SetKeyName(15, "iconsaa 2.png")
        Me.ImageList1.Images.SetKeyName(16, "iconflood.png")
        Me.ImageList1.Images.SetKeyName(17, "iconurl.png")
        Me.ImageList1.Images.SetKeyName(18, "iconurls.png")
        Me.ImageList1.Images.SetKeyName(19, "iconsaag.png")
        '
        'lvfiles
        '
        Me.lvfiles.BackColor = System.Drawing.Color.White
        Me.lvfiles.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvfiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvfiles.LargeImageList = Me.ImageList1
        Me.lvfiles.Location = New System.Drawing.Point(0, 31)
        Me.lvfiles.Name = "lvfiles"
        Me.lvfiles.Size = New System.Drawing.Size(587, 325)
        Me.lvfiles.TabIndex = 3
        Me.lvfiles.UseCompatibleStateImageBehavior = false
        '
        'pgcontents
        '
        Me.pgcontents.Controls.Add(Me.Panel2)
        Me.pgcontents.Controls.Add(Me.pnloptions)
        Me.pgcontents.Controls.Add(Me.pnlbreak)
        Me.pgcontents.Controls.Add(Me.lvfiles)
        Me.pgcontents.Controls.Add(Me.Panel1)
        Me.pgcontents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pgcontents.Location = New System.Drawing.Point(0, 0)
        Me.pgcontents.Name = "pgcontents"
        Me.pgcontents.Size = New System.Drawing.Size(587, 356)
        Me.pgcontents.TabIndex = 25
        '
        'SDE_File_Skimmer
        '
        Me.ClientSize = New System.Drawing.Size(587, 356)
        Me.Controls.Add(Me.pgcontents)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SDE_File_Skimmer"
        Me.Panel1.ResumeLayout(false)
        Me.pnloptions.ResumeLayout(false)
        Me.pgcontents.ResumeLayout(false)
        Me.ResumeLayout(false)

        End Sub
        Friend WithEvents fileactions As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents lbllocation As System.Windows.Forms.Label
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents btndeletefile As System.Windows.Forms.Button
        Friend WithEvents btnnewfolder As System.Windows.Forms.Button
        Friend WithEvents pnlbreak As System.Windows.Forms.Panel
        Friend WithEvents pnloptions As System.Windows.Forms.Panel
        Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
        Friend WithEvents lvfiles As System.Windows.Forms.ListView
        Friend WithEvents pgcontents As System.Windows.Forms.Panel
    End Class
End Namespace
