Public Class Terminal

    Public currentdironthisterminal As String = root

    Private Sub Terminal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If BasicWM.Desktop.openterminals > 0 Then BasicWM.Desktop.openterminals -= 1
    End Sub

    Private Sub Terminal_GotFocus(sender As Object, e As EventArgs) Handles terminaltext.GotFocus
        API.txtterm = Me.terminaltext
        API.currentdir = Me.currentdironthisterminal
    End Sub



    Public Sub terminal_Innitiate(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        API.txtterm = Me.terminaltext
        pnltop.DetermineMyVisibility()
        AddLine(username + "@" + osname + " " & currentdironthisterminal.ToLower.Replace("c:\shiftos", "~") & "$> ")
        SelectBottom()
        If prompttoupdatesave = True Then
            AddLine("ShiftOS has encountered an error loading configuration files. Press any key to reset damaged files.")
        End If
    End Sub













    Dim firstuseconversation As Integer = 0

    Private Sub tmrfirstuse_Tick(sender As Object, e As EventArgs) Handles tmrfirstuse.Tick
        Select Case firstuseconversation
            Case 0
                terminaltext.ReadOnly = True
                AddLine("IP Address 170.245.12.80 is connecting as ""DevX"".")
            Case 1
                AddLine("DevX: It seems my updates have completly installed.")
            Case 2
                AddLine("DevX: Unfortunately, due to your hard drive being formatted, you have lost all your data.")
            Case 3
                AddLine("DevX: However, Don't worry! I've added some pretty cool features to the Terminal to make up for this.")
            Case 4
                AddLine("DevX: I can't tell you much, except for ""Type Help for a list of commands"".")
            Case 5
                AddLine("DevX: I've got to go, but I'll contact you as I develop more updates; and you test the OS.")
            Case 6
                AddLine("User ""DevX"" has disconnected.")
            Case 7
                terminaltext.ResetText()
                AddLine("user@shiftos ~$> ")
                terminaltext.ReadOnly = False
                tmrfirstuse.Stop()
        End Select
        firstuseconversation += 1
    End Sub




End Class