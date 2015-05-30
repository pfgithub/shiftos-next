Namespace memphis
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
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.lbmsgtext = New System.Windows.Forms.Label()
            Me.txtuserinput = New System.Windows.Forms.TextBox()
            Me.btnok = New System.Windows.Forms.Button()
            Me.Contents = New System.Windows.Forms.Panel()
            Me.windowborder = New shiftos_next.mde_template()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Contents.SuspendLayout()
            Me.windowborder.Content.SuspendLayout()
            Me.windowborder.SuspendLayout()
            Me.SuspendLayout()
            '
            'PictureBox1
            '
            Me.PictureBox1.Image = Global.shiftos_next.My.Resources.Resources.infobox_mde_notify
            Me.PictureBox1.Location = New System.Drawing.Point(10, 18)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(69, 66)
            Me.PictureBox1.TabIndex = 0
            Me.PictureBox1.TabStop = False
            '
            'lbmsgtext
            '
            Me.lbmsgtext.Location = New System.Drawing.Point(83, 18)
            Me.lbmsgtext.Name = "lbmsgtext"
            Me.lbmsgtext.Size = New System.Drawing.Size(299, 107)
            Me.lbmsgtext.TabIndex = 1
            Me.lbmsgtext.Text = "Label1"
            '
            'txtuserinput
            '
            Me.txtuserinput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtuserinput.Location = New System.Drawing.Point(86, 128)
            Me.txtuserinput.Name = "txtuserinput"
            Me.txtuserinput.Size = New System.Drawing.Size(296, 20)
            Me.txtuserinput.TabIndex = 2
            '
            'btnok
            '
            Me.btnok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnok.Location = New System.Drawing.Point(293, 154)
            Me.btnok.Name = "btnok"
            Me.btnok.Size = New System.Drawing.Size(89, 32)
            Me.btnok.TabIndex = 3
            Me.btnok.Text = "OK"
            Me.btnok.UseVisualStyleBackColor = True
            '
            'Contents
            '
            Me.Contents.BackColor = System.Drawing.Color.White
            Me.Contents.Controls.Add(Me.windowborder)
            Me.Contents.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Contents.Location = New System.Drawing.Point(0, 0)
            Me.Contents.Name = "Contents"
            Me.Contents.Size = New System.Drawing.Size(396, 228)
            Me.Contents.TabIndex = 9
            '
            'windowborder
            '
            Me.windowborder.AppName = "Application Title"
            '
            'windowborder.Content
            '
            Me.windowborder.Content.BackColor = System.Drawing.Color.White
            Me.windowborder.Content.Controls.Add(Me.btnok)
            Me.windowborder.Content.Controls.Add(Me.txtuserinput)
            Me.windowborder.Content.Controls.Add(Me.lbmsgtext)
            Me.windowborder.Content.Controls.Add(Me.PictureBox1)
            Me.windowborder.Content.Dock = System.Windows.Forms.DockStyle.Fill
            Me.windowborder.Content.Location = New System.Drawing.Point(2, 30)
            Me.windowborder.Content.Name = "Content"
            Me.windowborder.Content.Size = New System.Drawing.Size(392, 196)
            Me.windowborder.Content.TabIndex = 4
            Me.windowborder.Dock = System.Windows.Forms.DockStyle.Fill
            Me.windowborder.Location = New System.Drawing.Point(0, 0)
            Me.windowborder.Name = "windowborder"
            Me.windowborder.ShowMaximizeButton = False
            Me.windowborder.ShowMinimizeButton = False
            Me.windowborder.Size = New System.Drawing.Size(396, 228)
            Me.windowborder.TabIndex = 4
            '
            'infobox
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(396, 228)
            Me.Controls.Add(Me.Contents)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "infobox"
            Me.Text = "infobox_mde"
            Me.TopMost = True
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Contents.ResumeLayout(False)
            Me.windowborder.Content.ResumeLayout(False)
            Me.windowborder.Content.PerformLayout()
            Me.windowborder.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents lbmsgtext As System.Windows.Forms.Label
        Friend WithEvents txtuserinput As System.Windows.Forms.TextBox
        Friend WithEvents btnok As System.Windows.Forms.Button
        Friend WithEvents Contents As System.Windows.Forms.Panel
        Friend WithEvents windowborder As shiftos_next.mde_template
    End Class
End Namespace