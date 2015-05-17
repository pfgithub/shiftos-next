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
        Me.tmrfirstuse = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'txtterm
        '
        Me.txtterm.BackColor = System.Drawing.Color.Black
        Me.txtterm.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtterm.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtterm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtterm.Font = New System.Drawing.Font("Courier New", 8.25!)
        Me.txtterm.ForeColor = System.Drawing.Color.White
        Me.txtterm.Location = New System.Drawing.Point(0, 0)
        Me.txtterm.Multiline = True
        Me.txtterm.Name = "txtterm"
        Me.txtterm.Size = New System.Drawing.Size(635, 418)
        Me.txtterm.TabIndex = 0
        Me.txtterm.Text = "ShiftOS Beta 1.0"
        '
        'tmrfirstuse
        '
        Me.tmrfirstuse.Interval = 5000
        '
        'Terminal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 418)
        Me.Controls.Add(Me.txtterm)
        Me.Name = "Terminal"
        Me.Text = "Terminal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtterm As System.Windows.Forms.TextBox
    Friend WithEvents tmrfirstuse As System.Windows.Forms.Timer
End Class
