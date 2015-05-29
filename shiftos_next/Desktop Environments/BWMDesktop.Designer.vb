Namespace BasicWM
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class Desktop
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
            Me.btnnewterminal = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'btnnewterminal
            '
            Me.btnnewterminal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnnewterminal.Location = New System.Drawing.Point(12, 12)
            Me.btnnewterminal.Name = "btnnewterminal"
            Me.btnnewterminal.Size = New System.Drawing.Size(105, 23)
            Me.btnnewterminal.TabIndex = 0
            Me.btnnewterminal.Text = "New Terminal"
            Me.btnnewterminal.UseVisualStyleBackColor = True
            '
            'Desktop
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.Black
            Me.ClientSize = New System.Drawing.Size(535, 286)
            Me.Controls.Add(Me.btnnewterminal)
            Me.Font = New System.Drawing.Font("Courier New", 8.25!)
            Me.ForeColor = System.Drawing.Color.White
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "Desktop"
            Me.Text = "BWMDesktop"
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents btnnewterminal As System.Windows.Forms.Button
    End Class
End Namespace