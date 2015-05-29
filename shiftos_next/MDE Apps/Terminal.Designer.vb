<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Terminal
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
        Me.tmr_firstuse = New System.Windows.Forms.Timer(Me.components)
        Me.txtterm = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.exodclose = New System.Windows.Forms.Button()
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
        Me.Panel1.SuspendLayout()
        Me.Titlebar.SuspendLayout()
        Me.captionbuttonholder.SuspendLayout()
        CType(Me.minbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maxbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closebtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmr_firstuse
        '
        Me.tmr_firstuse.Interval = 5000
        '
        'txtterm
        '
        Me.txtterm.BackColor = System.Drawing.Color.Black
        Me.txtterm.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtterm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtterm.Font = New System.Drawing.Font("Courier New", 8.25!)
        Me.txtterm.ForeColor = System.Drawing.Color.White
        Me.txtterm.Location = New System.Drawing.Point(2, 60)
        Me.txtterm.Multiline = True
        Me.txtterm.Name = "txtterm"
        Me.txtterm.Size = New System.Drawing.Size(789, 464)
        Me.txtterm.TabIndex = 0
        Me.txtterm.Text = "UltraDOS 1.0"
        Me.txtterm.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.exodclose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(2, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(789, 30)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Courier New", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(689, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "  DOS Prompt"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'exodclose
        '
        Me.exodclose.Dock = System.Windows.Forms.DockStyle.Right
        Me.exodclose.FlatAppearance.BorderSize = 0
        Me.exodclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exodclose.Font = New System.Drawing.Font("Courier New", 8.25!)
        Me.exodclose.ForeColor = System.Drawing.Color.White
        Me.exodclose.Location = New System.Drawing.Point(689, 0)
        Me.exodclose.Name = "exodclose"
        Me.exodclose.Size = New System.Drawing.Size(100, 30)
        Me.exodclose.TabIndex = 0
        Me.exodclose.Text = "CLOSE"
        Me.exodclose.UseVisualStyleBackColor = True
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
        Me.Titlebar.Size = New System.Drawing.Size(789, 30)
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
        Me.titletext.Size = New System.Drawing.Size(694, 30)
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
        Me.captionbuttonholder.Location = New System.Drawing.Point(694, 0)
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
        Me.Contents.Size = New System.Drawing.Size(789, 524)
        Me.Contents.TabIndex = 9
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Red
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(2, 524)
        Me.Panel4.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Red
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 524)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(791, 2)
        Me.Panel3.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Red
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(791, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(2, 526)
        Me.Panel2.TabIndex = 6
        '
        'Terminal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(793, 526)
        Me.Controls.Add(Me.txtterm)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Titlebar)
        Me.Controls.Add(Me.Contents)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Terminal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Terminal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Titlebar.ResumeLayout(False)
        Me.captionbuttonholder.ResumeLayout(False)
        CType(Me.minbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maxbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closebtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmr_firstuse As System.Windows.Forms.Timer
    Friend WithEvents txtterm As TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents exodclose As System.Windows.Forms.Button
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

End Class
