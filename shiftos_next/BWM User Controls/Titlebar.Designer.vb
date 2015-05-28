<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Titlebar
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.pnltop = New System.Windows.Forms.Panel()
        Me.lbtitle = New System.Windows.Forms.Label()
        Me.pnltop.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnltop
        '
        Me.pnltop.BackColor = System.Drawing.Color.Gray
        Me.pnltop.Controls.Add(Me.lbtitle)
        Me.pnltop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnltop.Location = New System.Drawing.Point(0, 0)
        Me.pnltop.Name = "pnltop"
        Me.pnltop.Size = New System.Drawing.Size(678, 32)
        Me.pnltop.TabIndex = 1
        '
        'lbtitle
        '
        Me.lbtitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbtitle.Location = New System.Drawing.Point(0, 0)
        Me.lbtitle.Name = "lbtitle"
        Me.lbtitle.Size = New System.Drawing.Size(678, 32)
        Me.lbtitle.TabIndex = 0
        Me.lbtitle.Text = "Color Picker"
        Me.lbtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Titlebar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnltop)
        Me.Font = New System.Drawing.Font("Courier New", 8.25!)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Titlebar"
        Me.Size = New System.Drawing.Size(678, 32)
        Me.pnltop.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnltop As System.Windows.Forms.Panel
    Friend WithEvents lbtitle As System.Windows.Forms.Label

End Class
