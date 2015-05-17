Public Class Terminal

    Dim trackpos As Integer = 0

    Public Sub terminal_Innitiate(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        AddLine("user@shiftos ~$> ")
        SelectBottom()
    End Sub

    Public Sub SelectBottom()
        txtterm.Select(txtterm.Text.Length, 0)
    End Sub

    Public Sub Interpret(command As String)
        command = command.ToLower
        If command Like "help" Then
            ShowHelp()
        ElseIf command Like "shutdown" Then
            Me.Close()
        ElseIf command Like "" Then
            'This is here to make it so that the Terminal doesn't say "Wrong Command" if the user doesn't input anything.
        Else
            AddLine("Invalid command! Type ""help"" for a list of commands.")
        End If
    End Sub

    Public Sub ShowHelp()
        AddLine("ShiftOS Help" & vbNewLine)
        AddLine("Usage tips: " & vbNewLine)
        AddLine(" - The terminal runs in full-screen.")
        AddLine(" - There are no window managers or desktop environments.")
        AddLine(" - Applications are fully text-based.")
        AddLine(" - Terminal commands are case-insensitive.")
        AddLine(" - The screen can only display Black and White." & vbNewLine)
        AddLine("Commands: " & vbNewLine)
        AddLine(" - shutdown: Shuts the system down.")
        AddLine(" - help: Shows this screen.")


    End Sub

    Public Sub AddLine(text As String)
        txtterm.Text += vbNewLine + text
        SelectBottom()
    End Sub

    Dim firstuseconversation As Integer = 0

    Private Sub tmrfirstuse_Tick(sender As Object, e As EventArgs) Handles tmrfirstuse.Tick
        Select Case firstuseconversation
            Case 0
                txtterm.ReadOnly = True
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
                txtterm.ResetText()
                AddLine("user@shiftos ~$> ")
                txtterm.ReadOnly = False
                tmrfirstuse.Stop()
        End Select
        firstuseconversation += 1
    End Sub

    Private Sub txtterm_KeyDown(sender As Object, e As KeyEventArgs) Handles txtterm.KeyDown
        Select Case e.KeyCode
            Case Keys.ShiftKey
                trackpos = trackpos - 1
            Case Keys.Alt
                trackpos = trackpos - 1
            Case Keys.CapsLock
                trackpos = trackpos - 1
            Case Keys.ControlKey
                trackpos = trackpos - 1
            Case Keys.LWin
                trackpos = trackpos - 1
            Case Keys.RWin
                trackpos = trackpos - 1
            Case Keys.Right
                If txtterm.SelectionStart = txtterm.TextLength Then
                    trackpos = trackpos - 1
                End If
            Case Keys.Left
                If trackpos < 1 Then
                    e.SuppressKeyPress = True
                    trackpos = trackpos - 1
                Else
                    trackpos = trackpos - 2
                End If
            Case Keys.Up
                e.SuppressKeyPress = True
                trackpos = trackpos - 1
            Case Keys.Down
                e.SuppressKeyPress = True
                trackpos = trackpos - 1
        End Select

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Dim command As String = txtterm.Lines(txtterm.Lines.Length - 1).Replace("user@shiftos ~$> ", "").ToLower
            Interpret(command)

            If command = "clear" Then
                txtterm.Text = "user@shiftos ~$> "
                txtterm.Select(txtterm.Text.Length, 0)

            Else
                AddLine("user@shiftos ~$> ")
                txtterm.Select(txtterm.Text.Length, 0)
            End If

            trackpos = 0
        Else
            If e.KeyCode = Keys.Back Then
            Else
                trackpos = trackpos + 1
            End If
        End If

        If e.KeyCode = Keys.Back Then
            If trackpos < 1 Then
                e.SuppressKeyPress = True
            Else
                If txtterm.SelectedText.Length < 1 Then
                    trackpos = trackpos - 1
                Else
                    e.SuppressKeyPress = True
                End If
            End If
        End If

        SelectBottom()
    End Sub
End Class