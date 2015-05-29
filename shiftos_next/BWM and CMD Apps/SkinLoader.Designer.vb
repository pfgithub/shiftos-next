<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SkinLoader
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
        Me.Titlebar = New shiftos_next.Titlebar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlwindowpreview = New System.Windows.Forms.Panel()
        Me.prev_titlebar = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.prev_desktop = New System.Windows.Forms.Panel()
        Me.prev_newterminal = New System.Windows.Forms.Button()
        Me.btnapply = New System.Windows.Forms.Button()
        Me.btnload = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.pnlwindowpreview.SuspendLayout()
        Me.prev_desktop.SuspendLayout()
        Me.SuspendLayout()
        '
        'Titlebar
        '
        Me.Titlebar.AppName = "Skin Loader"
        Me.Titlebar.Dock = System.Windows.Forms.DockStyle.Top
        Me.Titlebar.Font = New System.Drawing.Font("Courier New", 8.25!)
        Me.Titlebar.ForeColor = System.Drawing.Color.White
        Me.Titlebar.Location = New System.Drawing.Point(0, 0)
        Me.Titlebar.Name = "Titlebar"
        Me.Titlebar.Size = New System.Drawing.Size(458, 32)
        Me.Titlebar.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Preview (Window)"
        '
        'pnlwindowpreview
        '
        Me.pnlwindowpreview.Controls.Add(Me.prev_titlebar)
        Me.pnlwindowpreview.Location = New System.Drawing.Point(15, 84)
        Me.pnlwindowpreview.Name = "pnlwindowpreview"
        Me.pnlwindowpreview.Size = New System.Drawing.Size(431, 127)
        Me.pnlwindowpreview.TabIndex = 2
        '
        'prev_titlebar
        '
        Me.prev_titlebar.BackColor = System.Drawing.Color.Gray
        Me.prev_titlebar.Dock = System.Windows.Forms.DockStyle.Top
        Me.prev_titlebar.Location = New System.Drawing.Point(0, 0)
        Me.prev_titlebar.Name = "prev_titlebar"
        Me.prev_titlebar.Size = New System.Drawing.Size(431, 30)
        Me.prev_titlebar.TabIndex = 0
        Me.prev_titlebar.Text = "Application"
        Me.prev_titlebar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 227)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Preview (Desktop)"
        '
        'prev_desktop
        '
        Me.prev_desktop.Controls.Add(Me.prev_newterminal)
        Me.prev_desktop.Location = New System.Drawing.Point(15, 244)
        Me.prev_desktop.Name = "prev_desktop"
        Me.prev_desktop.Size = New System.Drawing.Size(431, 161)
        Me.prev_desktop.TabIndex = 4
        '
        'prev_newterminal
        '
        Me.prev_newterminal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.prev_newterminal.Location = New System.Drawing.Point(17, 13)
        Me.prev_newterminal.Name = "prev_newterminal"
        Me.prev_newterminal.Size = New System.Drawing.Size(109, 23)
        Me.prev_newterminal.TabIndex = 0
        Me.prev_newterminal.Text = "New Terminal"
        Me.prev_newterminal.UseVisualStyleBackColor = True
        '
        'btnapply
        '
        Me.btnapply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnapply.Location = New System.Drawing.Point(338, 417)
        Me.btnapply.Name = "btnapply"
        Me.btnapply.Size = New System.Drawing.Size(108, 23)
        Me.btnapply.TabIndex = 5
        Me.btnapply.Text = "Apply Skin"
        Me.btnapply.UseVisualStyleBackColor = True
        '
        'btnload
        '
        Me.btnload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnload.Location = New System.Drawing.Point(207, 417)
        Me.btnload.Name = "btnload"
        Me.btnload.Size = New System.Drawing.Size(125, 23)
        Me.btnload.TabIndex = 6
        Me.btnload.Text = "Load from File"
        Me.btnload.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Location = New System.Drawing.Point(93, 417)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(108, 23)
        Me.btnsave.TabIndex = 7
        Me.btnsave.Text = "Save to File"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'SkinLoader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(458, 452)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnload)
        Me.Controls.Add(Me.btnapply)
        Me.Controls.Add(Me.prev_desktop)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pnlwindowpreview)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Titlebar)
        Me.Font = New System.Drawing.Font("Courier New", 8.25!)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SkinLoader"
        Me.Text = "SkinLoader"
        Me.pnlwindowpreview.ResumeLayout(False)
        Me.prev_desktop.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Titlebar As shiftos_next.Titlebar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlwindowpreview As System.Windows.Forms.Panel
    Friend WithEvents prev_titlebar As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents prev_desktop As System.Windows.Forms.Panel
    Friend WithEvents prev_newterminal As System.Windows.Forms.Button
    Friend WithEvents btnapply As System.Windows.Forms.Button
    Friend WithEvents btnload As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
End Class
