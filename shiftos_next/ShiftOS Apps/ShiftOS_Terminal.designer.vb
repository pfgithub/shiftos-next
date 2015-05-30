Namespace ShiftDE
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
            Me.txtterm = New System.Windows.Forms.TextBox()
            Me.tmrfirstrun = New System.Windows.Forms.Timer(Me.components)
            Me.tmrshutdown = New System.Windows.Forms.Timer(Me.components)
            Me.pgbottomlcorner = New System.Windows.Forms.Panel()
            Me.pgbottomrcorner = New System.Windows.Forms.Panel()
            Me.minimizebutton = New System.Windows.Forms.Panel()
            Me.rollupbutton = New System.Windows.Forms.Panel()
            Me.closebutton = New System.Windows.Forms.Panel()
            Me.lbtitletext = New System.Windows.Forms.Label()
            Me.pgtoplcorner = New System.Windows.Forms.Panel()
            Me.pgtoprcorner = New System.Windows.Forms.Panel()
            Me.pullbs = New System.Windows.Forms.Timer(Me.components)
            Me.pullbottom = New System.Windows.Forms.Timer(Me.components)
            Me.pullside = New System.Windows.Forms.Timer(Me.components)
            Me.tmrstorylineupdate = New System.Windows.Forms.Timer(Me.components)
            Me.pnlicon = New System.Windows.Forms.PictureBox()
            Me.Template1 = New shiftos_next.ShiftDE.template()
            CType(Me.pnlicon, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Template1.Content.SuspendLayout()
            Me.Template1.SuspendLayout()
            Me.SuspendLayout()
            '
            'txtterm
            '
            Me.txtterm.BackColor = System.Drawing.Color.Black
            Me.txtterm.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtterm.Cursor = System.Windows.Forms.Cursors.No
            Me.txtterm.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtterm.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtterm.ForeColor = System.Drawing.Color.White
            Me.txtterm.Location = New System.Drawing.Point(0, 0)
            Me.txtterm.Multiline = True
            Me.txtterm.Name = "txtterm"
            Me.txtterm.Size = New System.Drawing.Size(350, 200)
            Me.txtterm.TabIndex = 0
            '
            'tmrfirstrun
            '
            Me.tmrfirstrun.Interval = 1000
            '
            'pgbottomlcorner
            '
            Me.pgbottomlcorner.Location = New System.Drawing.Point(0, 0)
            Me.pgbottomlcorner.Name = "pgbottomlcorner"
            Me.pgbottomlcorner.Size = New System.Drawing.Size(200, 100)
            Me.pgbottomlcorner.TabIndex = 0
            '
            'pgbottomrcorner
            '
            Me.pgbottomrcorner.Location = New System.Drawing.Point(0, 0)
            Me.pgbottomrcorner.Name = "pgbottomrcorner"
            Me.pgbottomrcorner.Size = New System.Drawing.Size(200, 100)
            Me.pgbottomrcorner.TabIndex = 0
            '
            'minimizebutton
            '
            Me.minimizebutton.Location = New System.Drawing.Point(0, 0)
            Me.minimizebutton.Name = "minimizebutton"
            Me.minimizebutton.Size = New System.Drawing.Size(200, 100)
            Me.minimizebutton.TabIndex = 0
            '
            'rollupbutton
            '
            Me.rollupbutton.Location = New System.Drawing.Point(0, 0)
            Me.rollupbutton.Name = "rollupbutton"
            Me.rollupbutton.Size = New System.Drawing.Size(200, 100)
            Me.rollupbutton.TabIndex = 0
            '
            'closebutton
            '
            Me.closebutton.Location = New System.Drawing.Point(0, 0)
            Me.closebutton.Name = "closebutton"
            Me.closebutton.Size = New System.Drawing.Size(200, 100)
            Me.closebutton.TabIndex = 0
            '
            'lbtitletext
            '
            Me.lbtitletext.Location = New System.Drawing.Point(0, 0)
            Me.lbtitletext.Name = "lbtitletext"
            Me.lbtitletext.Size = New System.Drawing.Size(100, 23)
            Me.lbtitletext.TabIndex = 0
            '
            'pgtoplcorner
            '
            Me.pgtoplcorner.Location = New System.Drawing.Point(0, 0)
            Me.pgtoplcorner.Name = "pgtoplcorner"
            Me.pgtoplcorner.Size = New System.Drawing.Size(200, 100)
            Me.pgtoplcorner.TabIndex = 0
            '
            'pgtoprcorner
            '
            Me.pgtoprcorner.Location = New System.Drawing.Point(0, 0)
            Me.pgtoprcorner.Name = "pgtoprcorner"
            Me.pgtoprcorner.Size = New System.Drawing.Size(200, 100)
            Me.pgtoprcorner.TabIndex = 0
            '
            'tmrstorylineupdate
            '
            Me.tmrstorylineupdate.Interval = 1000
            '
            'pnlicon
            '
            Me.pnlicon.Location = New System.Drawing.Point(0, 0)
            Me.pnlicon.Name = "pnlicon"
            Me.pnlicon.Size = New System.Drawing.Size(100, 50)
            Me.pnlicon.TabIndex = 0
            Me.pnlicon.TabStop = False
            '
            'Template1
            '
            Me.Template1.AppName = "Terminal"
            '
            'Template1.Content
            '
            Me.Template1.Content.Controls.Add(Me.txtterm)
            Me.Template1.Content.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Template1.Content.Location = New System.Drawing.Point(0, 0)
            Me.Template1.Content.Name = "Content"
            Me.Template1.Content.Size = New System.Drawing.Size(350, 200)
            Me.Template1.Content.TabIndex = 15
            Me.Template1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Template1.Location = New System.Drawing.Point(0, 0)
            Me.Template1.Name = "Template1"
            Me.Template1.Size = New System.Drawing.Size(350, 200)
            Me.Template1.TabIndex = 1
            '
            'Terminal
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.Black
            Me.ClientSize = New System.Drawing.Size(350, 200)
            Me.Controls.Add(Me.Template1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.KeyPreview = True
            Me.MinimumSize = New System.Drawing.Size(350, 200)
            Me.Name = "Terminal"
            Me.Text = "Terminal"
            Me.TopMost = True
            Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer))
            CType(Me.pnlicon, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Template1.Content.ResumeLayout(False)
            Me.Template1.Content.PerformLayout()
            Me.Template1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents txtterm As System.Windows.Forms.TextBox
        Friend WithEvents tmrfirstrun As System.Windows.Forms.Timer
        Friend WithEvents tmrshutdown As System.Windows.Forms.Timer
        Friend WithEvents pgbottomlcorner As System.Windows.Forms.Panel
        Friend WithEvents pgbottomrcorner As System.Windows.Forms.Panel
        Friend WithEvents closebutton As System.Windows.Forms.Panel
        Friend WithEvents lbtitletext As System.Windows.Forms.Label
        Friend WithEvents pgtoplcorner As System.Windows.Forms.Panel
        Friend WithEvents pgtoprcorner As System.Windows.Forms.Panel
        Friend WithEvents rollupbutton As System.Windows.Forms.Panel
        Friend WithEvents pnlicon As System.Windows.Forms.PictureBox
        Friend WithEvents minimizebutton As System.Windows.Forms.Panel
        Friend WithEvents pullbs As System.Windows.Forms.Timer
        Friend WithEvents pullbottom As System.Windows.Forms.Timer
        Friend WithEvents pullside As System.Windows.Forms.Timer
        Friend WithEvents tmrstorylineupdate As System.Windows.Forms.Timer
        Friend WithEvents Template1 As shiftos_next.ShiftDE.template
    End Class
End Namespace
