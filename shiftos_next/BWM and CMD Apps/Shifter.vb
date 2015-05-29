Public Class Shifter

    Dim cp As Integer

    Private Sub btntitletext_Click(sender As Object, e As EventArgs) Handles btntitletext.Click, btntitlebackcolor.Click, btndeskbackcolor.Click, btnntback.Click, btnnttext.Click
        BasicWM.ColorPicker.oldcolor = sender.BackColor
        BasicWM.ColorPicker.ShowDialog()
        sender.BackColor = BasicWM.ColorPicker.Color
        Dim random As New Random()
        Dim cptoadd As Integer = random.Next(1, 5)
        cp += cptoadd
    End Sub

    Public Sub loadsettings()
        btntitletext.BackColor = titlebartextcolor
        btntitlebackcolor.BackColor = titlebarcolor
        btndeskbackcolor.BackColor = desktopbackcolor
        btnntback.BackColor = newterminalbuttonbackcolor
        btnnttext.BackColor = newterminalbuttontextcolor
    End Sub

    Private Sub btnapply_Click(sender As Object, e As EventArgs) Handles btnapply.Click
        'Store data in Skinning Engine
        titlebartextcolor = btntitletext.BackColor
        titlebarcolor = btntitlebackcolor.BackColor
        desktopbackcolor = btndeskbackcolor.BackColor
        newterminalbuttonbackcolor = btnntback.BackColor
        newterminalbuttontextcolor = btnnttext.BackColor
        'Save to save file
        saveskindata()
        'By now, the skin has been applied, so we'll tell the user how many codepoints they've earned.
        AddCP(cp)
        basicwm_infobox.showinfo("Shifter - Skin applied", "The skin has been applied to the desktop environment. You have earned " & cp & " Codepoints.")
    End Sub

    Private Sub Shifter_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadsettings()
        Me.TopMost = True
        Me.Left = (Screen.PrimaryScreen.Bounds.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.Bounds.Height - Me.Height) / 2
    End Sub
End Class