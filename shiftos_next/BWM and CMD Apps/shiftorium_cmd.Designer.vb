<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class shiftorium_cmd
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
        Me.pnltop = New System.Windows.Forms.Panel()
        Me.lbtitle = New System.Windows.Forms.Label()
        Me.pnlbottom = New System.Windows.Forms.Panel()
        Me.lbcodepoints = New System.Windows.Forms.Label()
        Me.lbcontrols = New System.Windows.Forms.Label()
        Me.pnldetails = New System.Windows.Forms.Panel()
        Me.pnlbuy = New System.Windows.Forms.Panel()
        Me.btnbuy = New System.Windows.Forms.Button()
        Me.lbprice = New System.Windows.Forms.Label()
        Me.lbdescription = New System.Windows.Forms.Label()
        Me.lbitemname = New System.Windows.Forms.Label()
        Me.lbitems = New System.Windows.Forms.ListBox()
        Me.pnltop.SuspendLayout()
        Me.pnlbottom.SuspendLayout()
        Me.pnldetails.SuspendLayout()
        Me.pnlbuy.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnltop
        '
        Me.pnltop.Controls.Add(Me.lbtitle)
        Me.pnltop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnltop.Location = New System.Drawing.Point(0, 0)
        Me.pnltop.Name = "pnltop"
        Me.pnltop.Size = New System.Drawing.Size(1007, 30)
        Me.pnltop.TabIndex = 0
        '
        'lbtitle
        '
        Me.lbtitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbtitle.Location = New System.Drawing.Point(0, 0)
        Me.lbtitle.Name = "lbtitle"
        Me.lbtitle.Size = New System.Drawing.Size(1007, 30)
        Me.lbtitle.TabIndex = 0
        Me.lbtitle.Text = "SHIFTORIUM"
        Me.lbtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlbottom
        '
        Me.pnlbottom.Controls.Add(Me.lbcodepoints)
        Me.pnlbottom.Controls.Add(Me.lbcontrols)
        Me.pnlbottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlbottom.Location = New System.Drawing.Point(0, 570)
        Me.pnlbottom.Name = "pnlbottom"
        Me.pnlbottom.Size = New System.Drawing.Size(1007, 22)
        Me.pnlbottom.TabIndex = 1
        '
        'lbcodepoints
        '
        Me.lbcodepoints.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbcodepoints.Location = New System.Drawing.Point(815, 0)
        Me.lbcodepoints.Name = "lbcodepoints"
        Me.lbcodepoints.Size = New System.Drawing.Size(192, 22)
        Me.lbcodepoints.TabIndex = 1
        Me.lbcodepoints.Text = "Codepoints: {0}"
        Me.lbcodepoints.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbcontrols
        '
        Me.lbcontrols.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbcontrols.Location = New System.Drawing.Point(0, 0)
        Me.lbcontrols.Name = "lbcontrols"
        Me.lbcontrols.Size = New System.Drawing.Size(815, 22)
        Me.lbcontrols.TabIndex = 0
        Me.lbcontrols.Text = "Controls: UP/DOWN - Choose item, ENTER - View details, SPACE: Download"
        Me.lbcontrols.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnldetails
        '
        Me.pnldetails.Controls.Add(Me.pnlbuy)
        Me.pnldetails.Controls.Add(Me.lbdescription)
        Me.pnldetails.Controls.Add(Me.lbitemname)
        Me.pnldetails.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnldetails.Location = New System.Drawing.Point(0, 30)
        Me.pnldetails.Name = "pnldetails"
        Me.pnldetails.Size = New System.Drawing.Size(1007, 205)
        Me.pnldetails.TabIndex = 2
        '
        'pnlbuy
        '
        Me.pnlbuy.Controls.Add(Me.btnbuy)
        Me.pnlbuy.Controls.Add(Me.lbprice)
        Me.pnlbuy.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlbuy.Location = New System.Drawing.Point(0, 176)
        Me.pnlbuy.Name = "pnlbuy"
        Me.pnlbuy.Size = New System.Drawing.Size(1007, 29)
        Me.pnlbuy.TabIndex = 2
        '
        'btnbuy
        '
        Me.btnbuy.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnbuy.FlatAppearance.BorderSize = 0
        Me.btnbuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuy.Location = New System.Drawing.Point(815, 0)
        Me.btnbuy.Name = "btnbuy"
        Me.btnbuy.Size = New System.Drawing.Size(192, 29)
        Me.btnbuy.TabIndex = 1
        Me.btnbuy.Text = "Press SPACE to buy"
        Me.btnbuy.UseVisualStyleBackColor = True
        '
        'lbprice
        '
        Me.lbprice.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbprice.Location = New System.Drawing.Point(0, 0)
        Me.lbprice.Name = "lbprice"
        Me.lbprice.Size = New System.Drawing.Size(815, 29)
        Me.lbprice.TabIndex = 0
        Me.lbprice.Text = "This item costs {0} Codepoints."
        Me.lbprice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbdescription
        '
        Me.lbdescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbdescription.Location = New System.Drawing.Point(0, 28)
        Me.lbdescription.Name = "lbdescription"
        Me.lbdescription.Size = New System.Drawing.Size(1007, 177)
        Me.lbdescription.TabIndex = 1
        Me.lbdescription.Text = "The Shiftorium lets you upgrade different aspects of ShiftOS using Codepoints. Yo" & _
    "u can download anything from color support, terminal commands, programs, and eve" & _
    "n desktop environments."
        Me.lbdescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbitemname
        '
        Me.lbitemname.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbitemname.Location = New System.Drawing.Point(0, 0)
        Me.lbitemname.Name = "lbitemname"
        Me.lbitemname.Size = New System.Drawing.Size(1007, 28)
        Me.lbitemname.TabIndex = 0
        Me.lbitemname.Text = "Welcome to the Shiftorium!"
        Me.lbitemname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbitems
        '
        Me.lbitems.BackColor = System.Drawing.Color.Black
        Me.lbitems.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbitems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbitems.ForeColor = System.Drawing.Color.White
        Me.lbitems.FormattingEnabled = True
        Me.lbitems.ItemHeight = 14
        Me.lbitems.Location = New System.Drawing.Point(0, 235)
        Me.lbitems.Name = "lbitems"
        Me.lbitems.Size = New System.Drawing.Size(1007, 335)
        Me.lbitems.TabIndex = 3
        '
        'shiftorium_cmd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1007, 592)
        Me.Controls.Add(Me.lbitems)
        Me.Controls.Add(Me.pnldetails)
        Me.Controls.Add(Me.pnlbottom)
        Me.Controls.Add(Me.pnltop)
        Me.Font = New System.Drawing.Font("Courier New", 8.25!)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "shiftorium_cmd"
        Me.Text = "shiftorium_cmd"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnltop.ResumeLayout(False)
        Me.pnlbottom.ResumeLayout(False)
        Me.pnldetails.ResumeLayout(False)
        Me.pnlbuy.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnltop As System.Windows.Forms.Panel
    Friend WithEvents lbtitle As System.Windows.Forms.Label
    Friend WithEvents pnlbottom As System.Windows.Forms.Panel
    Friend WithEvents lbcodepoints As System.Windows.Forms.Label
    Friend WithEvents lbcontrols As System.Windows.Forms.Label
    Friend WithEvents pnldetails As System.Windows.Forms.Panel
    Friend WithEvents lbitems As System.Windows.Forms.ListBox
    Friend WithEvents pnlbuy As System.Windows.Forms.Panel
    Friend WithEvents btnbuy As System.Windows.Forms.Button
    Friend WithEvents lbprice As System.Windows.Forms.Label
    Friend WithEvents lbdescription As System.Windows.Forms.Label
    Friend WithEvents lbitemname As System.Windows.Forms.Label
End Class
