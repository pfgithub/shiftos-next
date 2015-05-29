Module API
    'Terminal

    Public debugmode As Boolean = False 'If this boolean value is set to True, any exceptions will be shown, rather than supressed.
    Public txtterm As TextBox = Terminal.terminaltext

    Public Function SetColorbasic(colorname As String)
        Dim element As Color
        Select Case colorname
            Case "black"
                AddLine("Error! Black and black don't go too well...")
            Case "white"
                element = Color.White
            Case "gray"
                If boughtgray Then
                    element = Color.Gray
                Else
                    AddLine("Error! Unsupported color.")
                End If
            Case "red"
                If boughtred Then
                    element = Color.Red
                Else
                    AddLine("Error! Unsupported color.")
                End If
            Case "green"
                If boughtgreen Then
                    element = Color.Green
                Else
                    AddLine("Error! Unsupported color.")
                End If
            Case "blue"
                If boughtblue Then
                    element = Color.Blue
                Else
                    AddLine("Error! Unsupported color.")
                End If
            Case "yellow"
                If boughtyellow Then
                    element = Color.Yellow
                Else
                    AddLine("Error! Unsupported color.")
                End If
            Case "orange"
                If boughtorange Then
                    element = Color.Orange
                Else
                    AddLine("Error! Unsupported color.")
                End If
            Case "pink"
                If boughtpink Then
                    element = Color.Pink
                Else
                    AddLine("Error! Unsupported color.")
                End If
            Case "purple"
                If boughtpurple Then
                    element = Color.Purple
                Else
                    AddLine("Error! Unsupported color.")
                End If
            Case "brown"
                If boughtbrown Then
                    element = Color.Brown
                Else
                    AddLine("Error! Unsupported color.")
                End If
            Case Else
                AddLine("Error! Unsupported color, check 'colors' for a list of supported colors.")
        End Select
        Return element
    End Function

    Public Sub OpenProgram(progtoopen As String)
        Select Case progtoopen
            Case "shiftorium", "packages", "pacman", "code shop"
                shiftorium_cmd.Show()
            Case "files", "fileskimmer", "file skimmer", "fs", "file browser"
                If boughtfileskimmer = True Then
                    file_skimmer.Show()
                Else
                    AddLine("open: Invalid program """ & progtoopen & """.")
                End If
            Case "textpad", "text", "notepad"
                If boughttextpad = True Then
                    TextPad.Show()
                Else
                    AddLine("open: Invalid program """ & progtoopen & """.")
                End If
            Case Else
                AddLine("open: Invalid program """ & progtoopen & """.")
        End Select
    End Sub

    Public Sub closeprogram(progtoclose As String)
        Select Case progtoclose
            Case "shiftorium", "packages", "pacman", "code shop"
                shiftorium_cmd.Hide()
            Case "files", "fileskimmer", "file skimmer", "fs", "file browser"
                If boughtfileskimmer = True Then
                    file_skimmer.Hide()
                Else
                    AddLine("close: Invalid program """ & progtoclose & """.")
                End If
            Case "textpad", "text", "notepad"
                If boughttextpad = True Then
                    TextPad.Hide()
                Else
                    AddLine("close: Invalid program """ & progtoclose & """.")
                End If

            Case Else
                AddLine("close: Invalid program """ & progtoclose & """.")
        End Select
    End Sub

    Public Sub wrongcommand()
        AddLine("Invalid command! Type ""help"" for a list of commands.")
    End Sub

    Public Sub AddLine(text As String)
        txtterm.Text += vbNewLine + text
        SelectBottom()
    End Sub

    Public Sub openfile(file As String)
        Dim filinfo As New IO.FileInfo(file)
        Select Case filinfo.Extension
            Case ".txt"
                If boughttextpad = True Then
                    Dim sr As New IO.StreamReader(file)
                    TextPad.txtfilebody.Text = sr.ReadToEnd()
                    sr.Close()
                    TextPad.Show()
                Else
                    wrongcommand()
                End If
            Case Else
                wrongcommand()
        End Select
    End Sub


    Public Sub showterminalcolors()
        AddLine(" ==== SUPPORTED TERMINAL COLORS ==== " & vbNewLine)
        AddLine("Below is a list of values that you can specify in <colorname> arguments. Note that only certain colors are supported; and if the video driver can output a color but it isn't on this list, it is not supported by the Terminal display engine." & vbNewLine)
        If boughtgray Then AddLine("gray")
        AddLine("white")
        AddLine("black")
        If boughtred Then AddLine("red")
        If boughtgreen Then AddLine("green")
        If boughtblue Then AddLine("blue")
        If boughtyellow Then AddLine("yellow")
        If boughtorange Then AddLine("orange")
        If boughtpink Then AddLine("pink")
        If boughtpurple Then AddLine("purple")
        If boughtbrown Then AddLine("brown")
    End Sub

    Public Sub ShowHelp()
        AddLine("ShiftOS Help" & vbNewLine)
        AddLine("Usage tips: " & vbNewLine)
        AddLine(" - The terminal runs in full-screen.")
        If boughttextpad = True Then AddLine(" - Typing the path to a text file will open it in Textpad.")
        AddLine(" - There are no window managers or desktop environments.")
        If boughtbasicgui = True Then
            AddLine(" - Applications can use the GUI server to display a proper GUI.")
        Else
            AddLine(" - Applications are fully text-based.")
        End If
        AddLine(" - Terminal commands are case-insensitive." & vbNewLine)
        AddLine("Commands: " & vbNewLine)
        If boughtdirectorysurfing Then
            AddLine(" - cd: Change to the specified directory.")
            AddLine(" - mkdir: Create a directory inside the current directory (marked before the %)")
            AddLine(" - ls, dir: View the contents of the current directory.")
        End If
        If boughtbasicsettings Then
            AddLine(" - set <setting> <value>: Change some minimal settings in ShiftOS.")
            If boughtcustomusername Then
                AddLine("   Settings: ")
                AddLine("   username <string>: Set the username of the OS.")
            End If
            If boughtterminalsettextcolor = True Then
                AddLine("   textcolor <colorname>: Set the terminal text color.")
            End If
        End If
        AddLine(" - codepoints: Shows the current amount of codepoints.")
        AddLine(" - shutdown: Shuts the system down.")
        AddLine(" - colors: Shows the colors supported by both the Terminal display engine, and the video driver.")
        AddLine(" - help: Shows this screen." & vbNewLine)
        AddLine("Installed Programs:" & vbNewLine)
        AddLine("Below is a list of all the programs on your computer, followed by what they do. You can open one by typing ""open <name>""." & vbNewLine)
        AddLine(" - shiftorium: Upgrade the OS with Codepoints using this application.")
        If boughtfileskimmer Then AddLine(" - file skimmer: A handy little file browser.")
        If boughttextpad Then AddLine(" - textpad: An application that allows for creating and editing text files.")
        AddLine(" - MathQuiz: Earn Codepoints by solving math questions.")
        AddLine(" - Guess the Number: Earn Codepoints by guessing a random number between 1 and 100.")
    End Sub

    Public Sub SelectBottom()
        txtterm.Select(txtterm.Text.Length, 0)
        txtterm.ScrollToCaret()
    End Sub

End Module
