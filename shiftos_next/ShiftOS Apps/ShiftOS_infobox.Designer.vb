<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class infobox
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
        Me.pgcontents = New System.Windows.Forms.Panel()
        Me.txtuserinput = New System.Windows.Forms.TextBox()
        Me.btnok = New System.Windows.Forms.Button()
        Me.txtmessage = New System.Windows.Forms.Label()
        Me.pboximage = New System.Windows.Forms.PictureBox()
        Me.lblintructtext = New System.Windows.Forms.Label()
        Me.pnlyesno = New System.Windows.Forms.Panel()
        Me.btnno = New System.Windows.Forms.Button()
        Me.btnyes = New System.Windows.Forms.Button()
        Me.pgleft = New System.Windows.Forms.Panel()
        Me.pgbottomlcorner = New System.Windows.Forms.Panel()
        Me.pgright = New System.Windows.Forms.Panel()
        Me.pgbottomrcorner = New System.Windows.Forms.Panel()
        Me.titlebar = New System.Windows.Forms.Panel()
        Me.minimizebutton = New System.Windows.Forms.Panel()
        Me.pnlicon = New System.Windows.Forms.PictureBox()
        Me.rollupbutton = New System.Windows.Forms.Panel()
        Me.closebutton = New System.Windows.Forms.Panel()
        Me.lbtitletext = New System.Windows.Forms.Label()
        Me.pgtoplcorner = New System.Windows.Forms.Panel()
        Me.pgtoprcorner = New System.Windows.Forms.Panel()
        Me.pgbottom = New System.Windows.Forms.Panel()
        Me.pgcontents.SuspendLayout()
        CType(Me.pboximage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlyesno.SuspendLayout()
        Me.pgleft.SuspendLayout()
        Me.pgright.SuspendLayout()
        Me.titlebar.SuspendLayout()
        CType(Me.pnlicon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pgcontents
        '
        Me.pgcontents.BackColor = System.Drawing.Color.White
        Me.pgcontents.Controls.Add(Me.pnlyesno)
        Me.pgcontents.Controls.Add(Me.txtuserinput)
        Me.pgcontents.Controls.Add(Me.btnok)
        Me.pgcontents.Controls.Add(Me.txtmessage)
        Me.pgcontents.Controls.Add(Me.pboximage)
        Me.pgcontents.Controls.Add(Me.lblintructtext)
        Me.pgcontents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pgcontents.Location = New System.Drawing.Point(2, 30)
        Me.pgcontents.Name = "pgcontents"
        Me.pgcontents.Size = New System.Drawing.Size(367, 122)
        Me.pgcontents.TabIndex = 20
        '
        'txtuserinput
        '
        Me.txtuserinput.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtuserinput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtuserinput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuserinput.Location = New System.Drawing.Point(101, 54)
        Me.txtuserinput.Multiline = True
        Me.txtuserinput.Name = "txtuserinput"
        Me.txtuserinput.Size = New System.Drawing.Size(256, 23)
        Me.txtuserinput.TabIndex = 8
        Me.txtuserinput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtuserinput.Visible = False
        '
        'btnok
        '
        Me.btnok.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnok.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnok.ForeColor = System.Drawing.Color.Black
        Me.btnok.Location = New System.Drawing.Point(134, 86)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(105, 30)
        Me.btnok.TabIndex = 7
        Me.btnok.TabStop = False
        Me.btnok.Text = "Ok"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'txtmessage
        '
        Me.txtmessage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmessage.Location = New System.Drawing.Point(98, 7)
        Me.txtmessage.Name = "txtmessage"
        Me.txtmessage.Size = New System.Drawing.Size(266, 70)
        Me.txtmessage.TabIndex = 2
        Me.txtmessage.Text = "It appears that this application may be infected. It is highly recommended that y" & _
    "ou close it immediatly with a terminal emulator such as Sterm. To close this app" & _
    "lication just type ""Close""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txtmessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pboximage
        '
        Me.pboximage.Location = New System.Drawing.Point(12, 7)
        Me.pboximage.Name = "pboximage"
        Me.pboximage.Size = New System.Drawing.Size(80, 70)
        Me.pboximage.TabIndex = 0
        Me.pboximage.TabStop = False
        '
        'lblintructtext
        '
        Me.lblintructtext.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblintructtext.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblintructtext.Location = New System.Drawing.Point(101, 7)
        Me.lblintructtext.Name = "lblintructtext"
        Me.lblintructtext.Size = New System.Drawing.Size(256, 44)
        Me.lblintructtext.TabIndex = 9
        Me.lblintructtext.Text = "Please enter a name for your new folder:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Or " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Die" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblintructtext.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblintructtext.Visible = False
        '
        'pnlyesno
        '
        Me.pnlyesno.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlyesno.Controls.Add(Me.btnno)
        Me.pnlyesno.Controls.Add(Me.btnyes)
        Me.pnlyesno.Location = New System.Drawing.Point(57, 83)
        Me.pnlyesno.Name = "pnlyesno"
        Me.pnlyesno.Size = New System.Drawing.Size(265, 33)
        Me.pnlyesno.TabIndex = 10
        Me.pnlyesno.Visible = False
        '
        'btnno
        '
        Me.btnno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnno.ForeColor = System.Drawing.Color.Black
        Me.btnno.Location = New System.Drawing.Point(142, 2)
        Me.btnno.Name = "btnno"
        Me.btnno.Size = New System.Drawing.Size(105, 30)
        Me.btnno.TabIndex = 9
        Me.btnno.TabStop = False
        Me.btnno.Text = "No"
        Me.btnno.UseVisualStyleBackColor = True
        '
        'btnyes
        '
        Me.btnyes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnyes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnyes.ForeColor = System.Drawing.Color.Black
        Me.btnyes.Location = New System.Drawing.Point(29, 2)
        Me.btnyes.Name = "btnyes"
        Me.btnyes.Size = New System.Drawing.Size(105, 30)
        Me.btnyes.TabIndex = 8
        Me.btnyes.TabStop = False
        Me.btnyes.Text = "Yes"
        Me.btnyes.UseVisualStyleBackColor = True
        '
        'pgleft
        '
        Me.pgleft.BackColor = System.Drawing.Color.Gray
        Me.pgleft.Controls.Add(Me.pgbottomlcorner)
        Me.pgleft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pgleft.Location = New System.Drawing.Point(0, 30)
        Me.pgleft.Name = "pgleft"
        Me.pgleft.Size = New System.Drawing.Size(2, 124)
        Me.pgleft.TabIndex = 21
        '
        'pgbottomlcorner
        '
        Me.pgbottomlcorner.BackColor = System.Drawing.Color.Red
        Me.pgbottomlcorner.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pgbottomlcorner.Location = New System.Drawing.Point(0, 122)
        Me.pgbottomlcorner.Name = "pgbottomlcorner"
        Me.pgbottomlcorner.Size = New System.Drawing.Size(2, 2)
        Me.pgbottomlcorner.TabIndex = 14
        '
        'pgright
        '
        Me.pgright.BackColor = System.Drawing.Color.Gray
        Me.pgright.Controls.Add(Me.pgbottomrcorner)
        Me.pgright.Dock = System.Windows.Forms.DockStyle.Right
        Me.pgright.Location = New System.Drawing.Point(369, 30)
        Me.pgright.Name = "pgright"
        Me.pgright.Size = New System.Drawing.Size(2, 124)
        Me.pgright.TabIndex = 22
        '
        'pgbottomrcorner
        '
        Me.pgbottomrcorner.BackColor = System.Drawing.Color.Red
        Me.pgbottomrcorner.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pgbottomrcorner.Location = New System.Drawing.Point(0, 122)
        Me.pgbottomrcorner.Name = "pgbottomrcorner"
        Me.pgbottomrcorner.Size = New System.Drawing.Size(2, 2)
        Me.pgbottomrcorner.TabIndex = 15
        '
        'titlebar
        '
        Me.titlebar.BackColor = System.Drawing.Color.Gray
        Me.titlebar.Controls.Add(Me.minimizebutton)
        Me.titlebar.Controls.Add(Me.pnlicon)
        Me.titlebar.Controls.Add(Me.rollupbutton)
        Me.titlebar.Controls.Add(Me.closebutton)
        Me.titlebar.Controls.Add(Me.lbtitletext)
        Me.titlebar.Controls.Add(Me.pgtoplcorner)
        Me.titlebar.Controls.Add(Me.pgtoprcorner)
        Me.titlebar.Dock = System.Windows.Forms.DockStyle.Top
        Me.titlebar.ForeColor = System.Drawing.Color.White
        Me.titlebar.Location = New System.Drawing.Point(0, 0)
        Me.titlebar.Name = "titlebar"
        Me.titlebar.Size = New System.Drawing.Size(371, 30)
        Me.titlebar.TabIndex = 19
        '
        'minimizebutton
        '
        Me.minimizebutton.BackColor = System.Drawing.Color.Black
        Me.minimizebutton.Location = New System.Drawing.Point(246, 3)
        Me.minimizebutton.Name = "minimizebutton"
        Me.minimizebutton.Size = New System.Drawing.Size(22, 22)
        Me.minimizebutton.TabIndex = 24
        '
        'infobox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 154)
        Me.Controls.Add(Me.pgcontents)
        Me.Controls.Add(Me.pgbottom)
        Me.Controls.Add(Me.pgleft)
        Me.Controls.Add(Me.pgright)
        Me.Controls.Add(Me.titlebar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "infobox"
        Me.Text = "infobox"
        Me.TopMost = True
        Me.pgcontents.ResumeLayout(False)
        Me.pgcontents.PerformLayout()
        CType(Me.pboximage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlyesno.ResumeLayout(False)
        Me.pgleft.ResumeLayout(False)
        Me.pgright.ResumeLayout(False)
        Me.titlebar.ResumeLayout(False)
        Me.titlebar.PerformLayout()
        CType(Me.pnlicon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pgcontents As System.Windows.Forms.Panel
    Friend WithEvents pgleft As System.Windows.Forms.Panel
    Friend WithEvents pgbottomlcorner As System.Windows.Forms.Panel
    Friend WithEvents pgright As System.Windows.Forms.Panel
    Friend WithEvents pgbottomrcorner As System.Windows.Forms.Panel
    Friend WithEvents titlebar As System.Windows.Forms.Panel
    Friend WithEvents rollupbutton As System.Windows.Forms.Panel
    Friend WithEvents closebutton As System.Windows.Forms.Panel
    Friend WithEvents lbtitletext As System.Windows.Forms.Label
    Friend WithEvents pgtoplcorner As System.Windows.Forms.Panel
    Friend WithEvents pgtoprcorner As System.Windows.Forms.Panel
    Friend WithEvents pgbottom As System.Windows.Forms.Panel
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents txtmessage As System.Windows.Forms.Label
    Friend WithEvents pboximage As System.Windows.Forms.PictureBox
    Friend WithEvents lblintructtext As System.Windows.Forms.Label
    Friend WithEvents txtuserinput As System.Windows.Forms.TextBox
    Friend WithEvents pnlicon As System.Windows.Forms.PictureBox
    Friend WithEvents minimizebutton As System.Windows.Forms.Panel
    Friend WithEvents pnlyesno As System.Windows.Forms.Panel
    Friend WithEvents btnno As System.Windows.Forms.Button
    Friend WithEvents btnyes As System.Windows.Forms.Button
End Class
