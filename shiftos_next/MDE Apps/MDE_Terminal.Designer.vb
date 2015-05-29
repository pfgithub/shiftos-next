<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDE_Terminal
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
        Me.WindowBorder = New shiftos_next.mde_template()
        Me.terminaltext = New System.Windows.Forms.TextBox()
        Me.WindowBorder.Content.SuspendLayout()
        Me.WindowBorder.SuspendLayout()
        Me.SuspendLayout()
        '
        'WindowBorder
        '
        Me.WindowBorder.AppName = "Terminal"
        '
        'WindowBorder.Content
        '
        Me.WindowBorder.Content.BackColor = System.Drawing.Color.White
        Me.WindowBorder.Content.Controls.Add(Me.terminaltext)
        Me.WindowBorder.Content.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WindowBorder.Content.Location = New System.Drawing.Point(2, 30)
        Me.WindowBorder.Content.Name = "Content"
        Me.WindowBorder.Content.Size = New System.Drawing.Size(623, 359)
        Me.WindowBorder.Content.TabIndex = 4
        Me.WindowBorder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WindowBorder.Location = New System.Drawing.Point(0, 0)
        Me.WindowBorder.Name = "WindowBorder"
        Me.WindowBorder.Size = New System.Drawing.Size(627, 391)
        Me.WindowBorder.TabIndex = 0
        '
        'terminaltext
        '
        Me.terminaltext.BackColor = System.Drawing.Color.Black
        Me.terminaltext.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.terminaltext.Dock = System.Windows.Forms.DockStyle.Fill
        Me.terminaltext.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.terminaltext.ForeColor = System.Drawing.Color.White
        Me.terminaltext.Location = New System.Drawing.Point(0, 0)
        Me.terminaltext.Multiline = True
        Me.terminaltext.Name = "terminaltext"
        Me.terminaltext.Size = New System.Drawing.Size(623, 359)
        Me.terminaltext.TabIndex = 0
        Me.terminaltext.Text = "ShiftOS Beta 1.2"
        '
        'MDE_Terminal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 391)
        Me.Controls.Add(Me.WindowBorder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MDE_Terminal"
        Me.Text = "MDE_Terminal"
        Me.TopMost = True
        Me.WindowBorder.Content.ResumeLayout(False)
        Me.WindowBorder.Content.PerformLayout()
        Me.WindowBorder.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WindowBorder As shiftos_next.mde_template
    Friend WithEvents terminaltext As System.Windows.Forms.TextBox
End Class
