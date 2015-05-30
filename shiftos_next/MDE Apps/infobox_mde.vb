Namespace memphis
    Public Class infobox

        Public userinput As String

        Public Sub showinfo(title As String, msg As String, Optional showtextbox As Boolean = False)
            windowborder.AppName = title
            lbmsgtext.Text = msg
            txtuserinput.Visible = showtextbox
            Me.Show()
        End Sub

        Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
            userinput = txtuserinput.Text
            Me.Close()
        End Sub


        Private Sub infobox_Load(sender As Object, e As EventArgs) Handles Me.Load
            My.Computer.Audio.Play(My.Resources.infobox, AudioPlayMode.Background)
            Me.Left = (Screen.PrimaryScreen.Bounds.Width - Me.Width) / 2
            Me.Top = (Screen.PrimaryScreen.Bounds.Height - Me.Height) / 2
        End Sub
    End Class
End Namespace
