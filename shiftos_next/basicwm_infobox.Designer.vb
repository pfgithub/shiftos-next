<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class basicwm_infobox
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbtitle = New System.Windows.Forms.Label()
        Me.btnok = New System.Windows.Forms.Button()
        Me.lbmessage = New System.Windows.Forms.Label()
        Me.txtuserinput = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.lbtitle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(433, 30)
        Me.Panel1.TabIndex = 0
        '
        'lbtitle
        '
        Me.lbtitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbtitle.Location = New System.Drawing.Point(0, 0)
        Me.lbtitle.Name = "lbtitle"
        Me.lbtitle.Size = New System.Drawing.Size(433, 30)
        Me.lbtitle.TabIndex = 0
        Me.lbtitle.Text = "I am a hacker."
        Me.lbtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnok
        '
        Me.btnok.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnok.FlatAppearance.BorderSize = 0
        Me.btnok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnok.Location = New System.Drawing.Point(0, 213)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(433, 44)
        Me.btnok.TabIndex = 0
        Me.btnok.Text = "> Alright <"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'lbmessage
        '
        Me.lbmessage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbmessage.Location = New System.Drawing.Point(0, 30)
        Me.lbmessage.Name = "lbmessage"
        Me.lbmessage.Size = New System.Drawing.Size(433, 183)
        Me.lbmessage.TabIndex = 1
        Me.lbmessage.Text = "I am already viewing my computer logs of that interview. Soon, I'll know everythi" & _
    "ng there is to know about that banana making factory."
        Me.lbmessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtuserinput
        '
        Me.txtuserinput.BackColor = System.Drawing.Color.Black
        Me.txtuserinput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtuserinput.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtuserinput.ForeColor = System.Drawing.Color.White
        Me.txtuserinput.Location = New System.Drawing.Point(0, 200)
        Me.txtuserinput.Name = "txtuserinput"
        Me.txtuserinput.Size = New System.Drawing.Size(433, 13)
        Me.txtuserinput.TabIndex = 2
        Me.txtuserinput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtuserinput.WordWrap = False
        '
        'basicwm_infobox
        '
        Me.AcceptButton = Me.btnok
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(433, 257)
        Me.Controls.Add(Me.txtuserinput)
        Me.Controls.Add(Me.lbmessage)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Courier New", 8.25!)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "basicwm_infobox"
        Me.Text = "basicwm_infobox"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbtitle As System.Windows.Forms.Label
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents lbmessage As System.Windows.Forms.Label
    Friend WithEvents txtuserinput As System.Windows.Forms.TextBox
End Class
