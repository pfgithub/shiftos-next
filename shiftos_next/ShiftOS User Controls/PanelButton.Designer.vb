<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelButton
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
        Me.components = New System.ComponentModel.Container()
        Me.pbicon = New System.Windows.Forms.PictureBox()
        Me.lbappname = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.close = New System.Windows.Forms.ToolStripMenuItem()
        Me.minimize = New System.Windows.Forms.ToolStripMenuItem()
        Me.restore = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.pbicon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbicon
        '
        Me.pbicon.Location = New System.Drawing.Point(2, 2)
        Me.pbicon.Name = "pbicon"
        Me.pbicon.Size = New System.Drawing.Size(19, 16)
        Me.pbicon.TabIndex = 0
        Me.pbicon.TabStop = False
        '
        'lbappname
        '
        Me.lbappname.Location = New System.Drawing.Point(28, 2)
        Me.lbappname.Name = "lbappname"
        Me.lbappname.Size = New System.Drawing.Size(117, 16)
        Me.lbappname.TabIndex = 1
        Me.lbappname.Text = "Application"
        Me.lbappname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.close, Me.minimize, Me.restore})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(178, 70)
        '
        'close
        '
        Me.close.Name = "close"
        Me.close.Size = New System.Drawing.Size(177, 22)
        Me.close.Text = "Close ""Application"""
        '
        'minimize
        '
        Me.minimize.Name = "minimize"
        Me.minimize.Size = New System.Drawing.Size(177, 22)
        Me.minimize.Text = "Minimize"
        '
        'restore
        '
        Me.restore.Name = "restore"
        Me.restore.Size = New System.Drawing.Size(177, 22)
        Me.restore.Text = "Restore"
        '
        'PanelButton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.Controls.Add(Me.lbappname)
        Me.Controls.Add(Me.pbicon)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "PanelButton"
        Me.Size = New System.Drawing.Size(226, 20)
        CType(Me.pbicon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbicon As System.Windows.Forms.PictureBox
    Friend WithEvents lbappname As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents close As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents minimize As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents restore As System.Windows.Forms.ToolStripMenuItem

End Class
