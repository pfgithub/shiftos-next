Public Class MDE_Terminal
    Public Sub Init()
        txtterm = terminaltext
    End Sub

    Dim currentdironthisterminal As String = home


    Private Sub MDE_Terminal_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        API.txtterm = Me.terminaltext
        currentdir = currentdironthisterminal
        AddLine(username + "@" + osname + " " & currentdironthisterminal.ToLower.Replace("c:\shiftos", "~") & "$> ")
        SelectBottom()
    End Sub
End Class
