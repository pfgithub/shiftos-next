Imports ShiftOS.Helper
Imports ShiftOS.Paths
Public Class infobox
    Public rolldownsize As Integer
    Public oldbordersize As Integer
    Public oldtitlebarheight As Integer
    Public justopened As Boolean = False
    Public needtorollback As Boolean = False
    Public minimumsizewidth As Integer = 0
    Public minimumsizeheight As Integer = 0

    Public textinfo As String
    Public title As String
    Public state As String
    Public sendyesno As String
    Public txtString As String
    Public showTextBox As Boolean

    Private Sub makeinfobox()
        txtmessage.Text = textinfo
        lbtitletext.Text = title
    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        If txtuserinput.Visible = True Then
            txtuserinput.Hide()
            lblintructtext.Hide()
            If state = "makingfolder" Then
                ShiftDE.SDE_File_Skimmer.makefolder()
            ElseIf state = "makingdesktopfolder" Then
                ShiftOSDesktop.makefolder()
            ElseIf state = "generatingskin" Then
                Skins.saveskin("C:/ShiftOS/Home/Desktop" & " / " & txtuserinput.Text & ".skn")
                ShiftOSDesktop.refreshIcons()
                Me.Close()
            ElseIf state = "newtextdocondesktop" Then
                Dim sw As New IO.StreamWriter("C:/ShiftOS/Home/Desktop/" & txtuserinput.Text & ".txt")
                sw.Write("[New Text Document]")
                sw.Close()
                Me.Close()
                ShiftOSDesktop.refreshIcons()
            ElseIf state = "generatingshortcut" Then
                ShiftOSDesktop.generateShortCut(txtuserinput.Text, txtString)
                ShiftOSDesktop.refreshIcons()
                Me.Close()
            Else
                txtString = txtuserinput.Text
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

    Public Sub showyesno()
        pnlyesno.Show()
    End Sub

    Private Sub btnyes_Click(sender As Object, e As EventArgs) Handles btnyes.Click
        Select Case sendyesno
            End Select
    End Sub

    Private Sub btnno_Click(sender As Object, e As EventArgs) Handles btnno.Click
        Select Case sendyesno
            Case Else
                Me.Close()
        End Select
    End Sub


    'Just loads the infobox and resizes it.
    Public Sub resizeAndLoad(x As Integer, y As Integer)
        Me.Show()
        Me.Size = New Size(x, y)
        Me.Left = (Screen.PrimaryScreen.Bounds.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.Bounds.Height - Me.Height) / 2
    End Sub

    Public Sub showinfo(ByVal titletxt As String, ByVal msg As String)
        title = titletxt
        textinfo = msg
        Me.Show()
    End Sub
End Class