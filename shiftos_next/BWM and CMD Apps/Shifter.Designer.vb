<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Shifter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Shifter))
        Me.titlebar = New shiftos_next.Titlebar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btntitletext = New System.Windows.Forms.Button()
        Me.btndeskbackcolor = New System.Windows.Forms.Button()
        Me.btntitlebackcolor = New System.Windows.Forms.Button()
        Me.btnnttext = New System.Windows.Forms.Button()
        Me.btnntback = New System.Windows.Forms.Button()
        Me.btnapply = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'titlebar
        '
        Me.titlebar.AppName = "Shifter - v1.0"
        Me.titlebar.Dock = System.Windows.Forms.DockStyle.Top
        Me.titlebar.Font = New System.Drawing.Font("Courier New", 8.25!)
        Me.titlebar.ForeColor = System.Drawing.Color.White
        Me.titlebar.Location = New System.Drawing.Point(0, 0)
        Me.titlebar.Name = "titlebar"
        Me.titlebar.Size = New System.Drawing.Size(420, 34)
        Me.titlebar.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(13, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(395, 91)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Titlebar Text Color:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(189, 14)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Titlebar Background Color:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(211, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 14)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Desktop Color:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(238, 14)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = """New Terminal"" button text color:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 261)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(280, 14)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = """New Terminal"" button background color:"
        '
        'btntitletext
        '
        Me.btntitletext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntitletext.Location = New System.Drawing.Point(166, 163)
        Me.btntitletext.Name = "btntitletext"
        Me.btntitletext.Size = New System.Drawing.Size(25, 23)
        Me.btntitletext.TabIndex = 7
        Me.btntitletext.UseVisualStyleBackColor = True
        '
        'btndeskbackcolor
        '
        Me.btndeskbackcolor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndeskbackcolor.Location = New System.Drawing.Point(322, 163)
        Me.btndeskbackcolor.Name = "btndeskbackcolor"
        Me.btndeskbackcolor.Size = New System.Drawing.Size(25, 23)
        Me.btndeskbackcolor.TabIndex = 8
        Me.btndeskbackcolor.UseVisualStyleBackColor = True
        '
        'btntitlebackcolor
        '
        Me.btntitlebackcolor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntitlebackcolor.Location = New System.Drawing.Point(208, 192)
        Me.btntitlebackcolor.Name = "btntitlebackcolor"
        Me.btntitlebackcolor.Size = New System.Drawing.Size(25, 23)
        Me.btntitlebackcolor.TabIndex = 9
        Me.btntitlebackcolor.UseVisualStyleBackColor = True
        '
        'btnnttext
        '
        Me.btnnttext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnttext.Location = New System.Drawing.Point(257, 225)
        Me.btnnttext.Name = "btnnttext"
        Me.btnnttext.Size = New System.Drawing.Size(25, 23)
        Me.btnnttext.TabIndex = 10
        Me.btnnttext.UseVisualStyleBackColor = True
        '
        'btnntback
        '
        Me.btnntback.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnntback.Location = New System.Drawing.Point(299, 257)
        Me.btnntback.Name = "btnntback"
        Me.btnntback.Size = New System.Drawing.Size(25, 23)
        Me.btnntback.TabIndex = 11
        Me.btnntback.UseVisualStyleBackColor = True
        '
        'btnapply
        '
        Me.btnapply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnapply.Location = New System.Drawing.Point(333, 312)
        Me.btnapply.Name = "btnapply"
        Me.btnapply.Size = New System.Drawing.Size(75, 23)
        Me.btnapply.TabIndex = 12
        Me.btnapply.Text = "Apply"
        Me.btnapply.UseVisualStyleBackColor = True
        '
        'Shifter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(420, 347)
        Me.Controls.Add(Me.btnapply)
        Me.Controls.Add(Me.btnntback)
        Me.Controls.Add(Me.btnnttext)
        Me.Controls.Add(Me.btntitlebackcolor)
        Me.Controls.Add(Me.btndeskbackcolor)
        Me.Controls.Add(Me.btntitletext)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.titlebar)
        Me.Font = New System.Drawing.Font("Courier New", 8.25!)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Shifter"
        Me.Text = "Shifter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents titlebar As shiftos_next.Titlebar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btntitletext As System.Windows.Forms.Button
    Friend WithEvents btndeskbackcolor As System.Windows.Forms.Button
    Friend WithEvents btntitlebackcolor As System.Windows.Forms.Button
    Friend WithEvents btnnttext As System.Windows.Forms.Button
    Friend WithEvents btnntback As System.Windows.Forms.Button
    Friend WithEvents btnapply As System.Windows.Forms.Button
End Class
