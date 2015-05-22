Public Class basicwm_infobox

    Public userinput As String

    Public Sub showinfo(title As String, message As String, Optional showtextbox As Boolean = False)
        lbtitle.Text = title
        lbmessage.Text = message
        btnok.Text = "> OK <"
        txtuserinput.Visible = showtextbox
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.ShowDialog()
    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        userinput = txtuserinput.Text
        Me.Close()
    End Sub
End Class