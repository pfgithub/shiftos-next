<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mde_template
    Inherits System.Windows.Forms.UserControl

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
        Me.Titlebar = New System.Windows.Forms.Panel()
        Me.titletext = New System.Windows.Forms.Label()
        Me.captionbuttonholder = New System.Windows.Forms.Panel()
        Me.minbtn = New System.Windows.Forms.PictureBox()
        Me.maxbtn = New System.Windows.Forms.PictureBox()
        Me.closebtn = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Contents = New System.Windows.Forms.Panel()
        Me.Titlebar.SuspendLayout()
        Me.captionbuttonholder.SuspendLayout()
        CType(Me.minbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maxbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closebtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Titlebar
        '
        Me.Titlebar.BackColor = System.Drawing.Color.Red
        Me.Titlebar.BackgroundImage = Global.shiftos_next.My.Resources.Resources.title
        Me.Titlebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Titlebar.Controls.Add(Me.titletext)
        Me.Titlebar.Controls.Add(Me.captionbuttonholder)
        Me.Titlebar.Dock = System.Windows.Forms.DockStyle.Top
        Me.Titlebar.Location = New System.Drawing.Point(0, 0)
        Me.Titlebar.Name = "Titlebar"
        Me.Titlebar.Size = New System.Drawing.Size(709, 30)
        Me.Titlebar.TabIndex = 0
        '
        'titletext
        '
        Me.titletext.BackColor = System.Drawing.Color.Transparent
        Me.titletext.Dock = System.Windows.Forms.DockStyle.Fill
        Me.titletext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.titletext.ForeColor = System.Drawing.Color.White
        Me.titletext.Location = New System.Drawing.Point(0, 0)
        Me.titletext.Name = "titletext"
        Me.titletext.Size = New System.Drawing.Size(614, 30)
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
        Me.captionbuttonholder.Location = New System.Drawing.Point(614, 0)
        Me.captionbuttonholder.Name = "captionbuttonholder"
        Me.captionbuttonholder.Size = New System.Drawing.Size(95, 30)
        Me.captionbuttonholder.TabIndex = 1
        '
        'minbtn
        '
        Me.minbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minbtn.Image = Global.shiftos_next.My.Resources.Resources.minimize2
        Me.minbtn.Location = New System.Drawing.Point(14, 5)
        Me.minbtn.Name = "minbtn"
        Me.minbtn.Size = New System.Drawing.Size(22, 22)
        Me.minbtn.TabIndex = 2
        Me.minbtn.TabStop = False
        '
        'maxbtn
        '
        Me.maxbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.maxbtn.Image = Global.shiftos_next.My.Resources.Resources.minimize
        Me.maxbtn.Location = New System.Drawing.Point(42, 5)
        Me.maxbtn.Name = "maxbtn"
        Me.maxbtn.Size = New System.Drawing.Size(22, 22)
        Me.maxbtn.TabIndex = 1
        Me.maxbtn.TabStop = False
        '
        'closebtn
        '
        Me.closebtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.closebtn.Image = Global.shiftos_next.My.Resources.Resources.close
        Me.closebtn.Location = New System.Drawing.Point(70, 5)
        Me.closebtn.Name = "closebtn"
        Me.closebtn.Size = New System.Drawing.Size(22, 22)
        Me.closebtn.TabIndex = 0
        Me.closebtn.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Red
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(707, 30)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(2, 355)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Red
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 383)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(707, 2)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Red
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 30)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(2, 353)
        Me.Panel4.TabIndex = 3
        '
        'Contents
        '
        Me.Contents.BackColor = System.Drawing.Color.White
        Me.Contents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Contents.Location = New System.Drawing.Point(2, 30)
        Me.Contents.Name = "Contents"
        Me.Contents.Size = New System.Drawing.Size(705, 353)
        Me.Contents.TabIndex = 4
        '
        'mde_template
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 385)
        Me.Controls.Add(Me.Contents)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Titlebar)
        Me.Name = "mde_template"
        Me.Text = "mde_template"
        Me.Titlebar.ResumeLayout(False)
        Me.captionbuttonholder.ResumeLayout(False)
        CType(Me.minbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maxbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closebtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Titlebar As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Contents As System.Windows.Forms.Panel
    Friend WithEvents captionbuttonholder As System.Windows.Forms.Panel
    Friend WithEvents titletext As System.Windows.Forms.Label
    Friend WithEvents minbtn As System.Windows.Forms.PictureBox
    Friend WithEvents maxbtn As System.Windows.Forms.PictureBox
    Friend WithEvents closebtn As System.Windows.Forms.PictureBox
End Class
