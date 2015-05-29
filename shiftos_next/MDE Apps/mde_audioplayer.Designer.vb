<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mde_audioplayer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mde_audioplayer))
        Me.Titlebar = New System.Windows.Forms.Panel()
        Me.titletext = New System.Windows.Forms.Label()
        Me.captionbuttonholder = New System.Windows.Forms.Panel()
        Me.minbtn = New System.Windows.Forms.PictureBox()
        Me.maxbtn = New System.Windows.Forms.PictureBox()
        Me.closebtn = New System.Windows.Forms.PictureBox()
        Me.Contents = New System.Windows.Forms.Panel()
        Me.pnl_player = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Titlebar.SuspendLayout()
        Me.captionbuttonholder.SuspendLayout()
        CType(Me.minbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maxbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closebtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Contents.SuspendLayout()
        Me.pnl_player.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Titlebar.Size = New System.Drawing.Size(559, 30)
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
        Me.titletext.Size = New System.Drawing.Size(464, 30)
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
        Me.captionbuttonholder.Location = New System.Drawing.Point(464, 0)
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
        Me.Contents.Controls.Add(Me.pnl_player)
        Me.Contents.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Contents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Contents.Location = New System.Drawing.Point(2, 0)
        Me.Contents.Name = "Contents"
        Me.Contents.Size = New System.Drawing.Size(559, 302)
        Me.Contents.TabIndex = 9
        '
        'pnl_player
        '
        Me.pnl_player.Controls.Add(Me.Button3)
        Me.pnl_player.Controls.Add(Me.TrackBar1)
        Me.pnl_player.Controls.Add(Me.Button2)
        Me.pnl_player.Controls.Add(Me.Button1)
        Me.pnl_player.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_player.Location = New System.Drawing.Point(0, 274)
        Me.pnl_player.Name = "pnl_player"
        Me.pnl_player.Size = New System.Drawing.Size(559, 28)
        Me.pnl_player.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Play/Pause"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(0, 0)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(559, 302)
        Me.AxWindowsMediaPlayer1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Red
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(2, 302)
        Me.Panel4.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Red
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 302)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(561, 2)
        Me.Panel3.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Red
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(561, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(2, 304)
        Me.Panel2.TabIndex = 6
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(448, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Browse For Media"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TrackBar1
        '
        Me.TrackBar1.AutoSize = False
        Me.TrackBar1.Location = New System.Drawing.Point(84, 5)
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(163, 25)
        Me.TrackBar1.TabIndex = 2
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.None
        Me.TrackBar1.Value = 10
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(253, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Stop"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'mde_audioplayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 304)
        Me.Controls.Add(Me.Titlebar)
        Me.Controls.Add(Me.Contents)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "mde_audioplayer"
        Me.Text = "mde_audioplayer"
        Me.Titlebar.ResumeLayout(False)
        Me.captionbuttonholder.ResumeLayout(False)
        CType(Me.minbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maxbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closebtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Contents.ResumeLayout(False)
        Me.pnl_player.ResumeLayout(False)
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents pnl_player As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
