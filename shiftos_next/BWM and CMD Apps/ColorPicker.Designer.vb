Namespace BasicWM
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class ColorPicker
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
            Me.pnlcolors = New System.Windows.Forms.FlowLayoutPanel()
            Me.btnwhite = New System.Windows.Forms.Button()
            Me.btnblack = New System.Windows.Forms.Button()
            Me.btngray = New System.Windows.Forms.Button()
            Me.btnlightgray = New System.Windows.Forms.Button()
            Me.btndarkgray = New System.Windows.Forms.Button()
            Me.btnred = New System.Windows.Forms.Button()
            Me.btngreen = New System.Windows.Forms.Button()
            Me.btnblue = New System.Windows.Forms.Button()
            Me.btnyellow = New System.Windows.Forms.Button()
            Me.btnorange = New System.Windows.Forms.Button()
            Me.btnpink = New System.Windows.Forms.Button()
            Me.btnpurple = New System.Windows.Forms.Button()
            Me.btnbrown = New System.Windows.Forms.Button()
            Me.btnok = New System.Windows.Forms.Button()
            Me.lbselectedcolor = New System.Windows.Forms.Label()
            Me.btncancel = New System.Windows.Forms.Button()
            Me.pnltop = New shiftos_next.Titlebar()
            Me.pnlcolors.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlcolors
            '
            Me.pnlcolors.Controls.Add(Me.btnwhite)
            Me.pnlcolors.Controls.Add(Me.btnblack)
            Me.pnlcolors.Controls.Add(Me.btngray)
            Me.pnlcolors.Controls.Add(Me.btnlightgray)
            Me.pnlcolors.Controls.Add(Me.btndarkgray)
            Me.pnlcolors.Controls.Add(Me.btnred)
            Me.pnlcolors.Controls.Add(Me.btngreen)
            Me.pnlcolors.Controls.Add(Me.btnblue)
            Me.pnlcolors.Controls.Add(Me.btnyellow)
            Me.pnlcolors.Controls.Add(Me.btnorange)
            Me.pnlcolors.Controls.Add(Me.btnpink)
            Me.pnlcolors.Controls.Add(Me.btnpurple)
            Me.pnlcolors.Controls.Add(Me.btnbrown)
            Me.pnlcolors.Location = New System.Drawing.Point(15, 65)
            Me.pnlcolors.Name = "pnlcolors"
            Me.pnlcolors.Size = New System.Drawing.Size(335, 131)
            Me.pnlcolors.TabIndex = 1
            Me.pnlcolors.Tag = "colorholder"
            '
            'btnwhite
            '
            Me.btnwhite.BackColor = System.Drawing.Color.White
            Me.btnwhite.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnwhite.Location = New System.Drawing.Point(3, 3)
            Me.btnwhite.Name = "btnwhite"
            Me.btnwhite.Size = New System.Drawing.Size(26, 23)
            Me.btnwhite.TabIndex = 0
            Me.btnwhite.UseVisualStyleBackColor = False
            '
            'btnblack
            '
            Me.btnblack.BackColor = System.Drawing.Color.Black
            Me.btnblack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnblack.Location = New System.Drawing.Point(35, 3)
            Me.btnblack.Name = "btnblack"
            Me.btnblack.Size = New System.Drawing.Size(26, 23)
            Me.btnblack.TabIndex = 1
            Me.btnblack.UseVisualStyleBackColor = False
            '
            'btngray
            '
            Me.btngray.BackColor = System.Drawing.Color.Gray
            Me.btngray.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btngray.Location = New System.Drawing.Point(67, 3)
            Me.btngray.Name = "btngray"
            Me.btngray.Size = New System.Drawing.Size(26, 23)
            Me.btngray.TabIndex = 2
            Me.btngray.UseVisualStyleBackColor = False
            Me.btngray.Visible = False
            '
            'btnlightgray
            '
            Me.btnlightgray.BackColor = System.Drawing.Color.LightGray
            Me.btnlightgray.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnlightgray.Location = New System.Drawing.Point(99, 3)
            Me.btnlightgray.Name = "btnlightgray"
            Me.btnlightgray.Size = New System.Drawing.Size(26, 23)
            Me.btnlightgray.TabIndex = 11
            Me.btnlightgray.UseVisualStyleBackColor = False
            Me.btnlightgray.Visible = False
            '
            'btndarkgray
            '
            Me.btndarkgray.BackColor = System.Drawing.Color.DarkGray
            Me.btndarkgray.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btndarkgray.Location = New System.Drawing.Point(131, 3)
            Me.btndarkgray.Name = "btndarkgray"
            Me.btndarkgray.Size = New System.Drawing.Size(26, 23)
            Me.btndarkgray.TabIndex = 12
            Me.btndarkgray.UseVisualStyleBackColor = False
            Me.btndarkgray.Visible = False
            '
            'btnred
            '
            Me.btnred.BackColor = System.Drawing.Color.Red
            Me.btnred.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnred.Location = New System.Drawing.Point(163, 3)
            Me.btnred.Name = "btnred"
            Me.btnred.Size = New System.Drawing.Size(26, 23)
            Me.btnred.TabIndex = 3
            Me.btnred.UseVisualStyleBackColor = False
            Me.btnred.Visible = False
            '
            'btngreen
            '
            Me.btngreen.BackColor = System.Drawing.Color.Green
            Me.btngreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btngreen.Location = New System.Drawing.Point(195, 3)
            Me.btngreen.Name = "btngreen"
            Me.btngreen.Size = New System.Drawing.Size(26, 23)
            Me.btngreen.TabIndex = 4
            Me.btngreen.UseVisualStyleBackColor = False
            Me.btngreen.Visible = False
            '
            'btnblue
            '
            Me.btnblue.BackColor = System.Drawing.Color.Blue
            Me.btnblue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnblue.Location = New System.Drawing.Point(227, 3)
            Me.btnblue.Name = "btnblue"
            Me.btnblue.Size = New System.Drawing.Size(26, 23)
            Me.btnblue.TabIndex = 5
            Me.btnblue.UseVisualStyleBackColor = False
            Me.btnblue.Visible = False
            '
            'btnyellow
            '
            Me.btnyellow.BackColor = System.Drawing.Color.Yellow
            Me.btnyellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnyellow.Location = New System.Drawing.Point(259, 3)
            Me.btnyellow.Name = "btnyellow"
            Me.btnyellow.Size = New System.Drawing.Size(26, 23)
            Me.btnyellow.TabIndex = 6
            Me.btnyellow.UseVisualStyleBackColor = False
            Me.btnyellow.Visible = False
            '
            'btnorange
            '
            Me.btnorange.BackColor = System.Drawing.Color.Orange
            Me.btnorange.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnorange.Location = New System.Drawing.Point(291, 3)
            Me.btnorange.Name = "btnorange"
            Me.btnorange.Size = New System.Drawing.Size(26, 23)
            Me.btnorange.TabIndex = 7
            Me.btnorange.UseVisualStyleBackColor = False
            Me.btnorange.Visible = False
            '
            'btnpink
            '
            Me.btnpink.BackColor = System.Drawing.Color.Pink
            Me.btnpink.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnpink.Location = New System.Drawing.Point(3, 32)
            Me.btnpink.Name = "btnpink"
            Me.btnpink.Size = New System.Drawing.Size(26, 23)
            Me.btnpink.TabIndex = 8
            Me.btnpink.UseVisualStyleBackColor = False
            Me.btnpink.Visible = False
            '
            'btnpurple
            '
            Me.btnpurple.BackColor = System.Drawing.Color.Purple
            Me.btnpurple.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnpurple.Location = New System.Drawing.Point(35, 32)
            Me.btnpurple.Name = "btnpurple"
            Me.btnpurple.Size = New System.Drawing.Size(26, 23)
            Me.btnpurple.TabIndex = 9
            Me.btnpurple.UseVisualStyleBackColor = False
            Me.btnpurple.Visible = False
            '
            'btnbrown
            '
            Me.btnbrown.BackColor = System.Drawing.Color.Brown
            Me.btnbrown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnbrown.Location = New System.Drawing.Point(67, 32)
            Me.btnbrown.Name = "btnbrown"
            Me.btnbrown.Size = New System.Drawing.Size(26, 23)
            Me.btnbrown.TabIndex = 10
            Me.btnbrown.UseVisualStyleBackColor = False
            Me.btnbrown.Visible = False
            '
            'btnok
            '
            Me.btnok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnok.Location = New System.Drawing.Point(275, 245)
            Me.btnok.Name = "btnok"
            Me.btnok.Size = New System.Drawing.Size(75, 23)
            Me.btnok.TabIndex = 2
            Me.btnok.Text = "OK"
            Me.btnok.UseVisualStyleBackColor = True
            '
            'lbselectedcolor
            '
            Me.lbselectedcolor.AutoSize = True
            Me.lbselectedcolor.Location = New System.Drawing.Point(12, 249)
            Me.lbselectedcolor.Name = "lbselectedcolor"
            Me.lbselectedcolor.Size = New System.Drawing.Size(154, 14)
            Me.lbselectedcolor.TabIndex = 3
            Me.lbselectedcolor.Text = "Selected Color: White"
            '
            'btncancel
            '
            Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btncancel.Location = New System.Drawing.Point(194, 245)
            Me.btncancel.Name = "btncancel"
            Me.btncancel.Size = New System.Drawing.Size(75, 23)
            Me.btncancel.TabIndex = 4
            Me.btncancel.Text = "Cancel"
            Me.btncancel.UseVisualStyleBackColor = True
            '
            'pnltop
            '
            Me.pnltop.AppName = "Color Picker"
            Me.pnltop.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnltop.Font = New System.Drawing.Font("Courier New", 8.25!)
            Me.pnltop.ForeColor = System.Drawing.Color.White
            Me.pnltop.Location = New System.Drawing.Point(0, 0)
            Me.pnltop.Name = "pnltop"
            Me.pnltop.Size = New System.Drawing.Size(362, 32)
            Me.pnltop.TabIndex = 5
            '
            'ColorPicker
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.Black
            Me.ClientSize = New System.Drawing.Size(362, 280)
            Me.Controls.Add(Me.pnltop)
            Me.Controls.Add(Me.btncancel)
            Me.Controls.Add(Me.lbselectedcolor)
            Me.Controls.Add(Me.btnok)
            Me.Controls.Add(Me.pnlcolors)
            Me.Font = New System.Drawing.Font("Courier New", 8.25!)
            Me.ForeColor = System.Drawing.Color.White
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "ColorPicker"
            Me.Text = "ColorPicker"
            Me.pnlcolors.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents pnlcolors As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents btnwhite As System.Windows.Forms.Button
        Friend WithEvents btnblack As System.Windows.Forms.Button
        Friend WithEvents btngray As System.Windows.Forms.Button
        Friend WithEvents btnred As System.Windows.Forms.Button
        Friend WithEvents btngreen As System.Windows.Forms.Button
        Friend WithEvents btnblue As System.Windows.Forms.Button
        Friend WithEvents btnyellow As System.Windows.Forms.Button
        Friend WithEvents btnorange As System.Windows.Forms.Button
        Friend WithEvents btnpink As System.Windows.Forms.Button
        Friend WithEvents btnpurple As System.Windows.Forms.Button
        Friend WithEvents btnbrown As System.Windows.Forms.Button
        Friend WithEvents btnok As System.Windows.Forms.Button
        Friend WithEvents lbselectedcolor As System.Windows.Forms.Label
        Friend WithEvents btncancel As System.Windows.Forms.Button
        Friend WithEvents pnltop As shiftos_next.Titlebar
        Friend WithEvents btnlightgray As System.Windows.Forms.Button
        Friend WithEvents btndarkgray As System.Windows.Forms.Button
    End Class
End Namespace