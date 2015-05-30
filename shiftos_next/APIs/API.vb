Module API
    'Terminal

    Public prompttoupdatesave As Boolean
    Public debugmode As Boolean = False 'If this boolean value is set to True, any exceptions will be shown, rather than supressed.
    Friend WithEvents txtterm As TextBox = Terminal.terminaltext
    Public currentdir As String
    Dim trackpos As Integer = 0

    Private Sub txtterm_KeyDown(sender As Object, e As KeyEventArgs) Handles txtterm.KeyDown
        If prompttoupdatesave = False Then

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
                If mathquiz = True Then
                    Dim question As String = txtterm.Lines(txtterm.Lines.Length - 2)
                    Dim answer As String = txtterm.Lines(txtterm.Lines.Length - 1).Replace("> ", "")
                    If answer = "exit" Then
                        mathquiz = False
                        AddLine(username + "@" + osname + " " & currentdir.ToLower.Replace("c:\shiftos", "~") & "$> ")
                    Else
                        Try
                            MQInterpret(question, answer)
                        Catch ex As Exception
                            AddLine("The answer provided isn't a proper number!")
                        End Try
                        AddLine("> ")
                    End If
                ElseIf guessthenumber = True Then
                    Dim answer As String = txtterm.Lines(txtterm.Lines.Length - 1).Replace("> ", "")
                    If answer = "exit" Then
                        guessthenumber = False
                        AddLine(username + "@" + osname + " " & currentdir.ToLower.Replace("c:\shiftos", "~") & "$> ")
                    Else
                        Try
                            GTNInterpret(answer)
                        Catch ex As Exception
                            AddLine("The answer provided isn't a proper number.")
                        End Try
                        AddLine("> ")
                    End If
                Else
                    Dim command As String = txtterm.Lines(txtterm.Lines.Length - 1).Replace(username + "@" + osname + " " & currentdir.ToLower.Replace("c:\shiftos", "~") & "$> ", "").ToLower
                    Interpret(command)

                    If mathquiz Or guessthenumber Then
                        AddLine("> ")
                    Else
                        If command = "clear" Then
                            txtterm.Text = username + "@" + osname + " " & currentdir.ToLower.Replace("c:\shiftos", "~") & "$> "
                            txtterm.Select(txtterm.Text.Length, 0)

                        Else
                            AddLine(username + "@" + osname + " " & currentdir.ToLower.Replace("c:\shiftos", "~") & "$> ")
                            txtterm.Select(txtterm.Text.Length, 0)
                        End If
                    End If
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
        Else
            e.SuppressKeyPress = True
            savegame()
            loadgame()
            AddLine("Self-repair complete with no errors.")
            prompttoupdatesave = False
            AddLine(username + "@" + osname + " " & currentdir.ToLower.Replace("c:\shiftos", "~") & "$> ")
        End If
    End Sub

    Public Sub Interpret(command As String)
        command = command.ToLower
        If command Like "help" Then
            ShowHelp()
        ElseIf command = "test sde" Then
            ShiftOSDesktop.Show()
            txtterm.FindForm.Close()
        ElseIf command Like "cd *" Then
            If boughtdirectorysurfing = True Then
                Dim folder As String = command.Replace("cd ", "")

                If folder = ".." Then
                    If currentdir.ToLower = "c:\shiftos" Then
                        AddLine("cd: Error! You are at the root of your drive.")
                    Else
                        currentdir = IO.Directory.GetParent(currentdir).ToString
                    End If
                Else
                    If IO.Directory.Exists(currentdir + "\" + folder) Then
                        currentdir = currentdir & "\" & folder
                    ElseIf IO.Directory.Exists(folder) Then
                        currentdir = folder
                    Else
                        AddLine("cd: Directory """ & folder & """ doesn't exist.")
                    End If
                End If
            Else
                wrongcommand()
            End If
        ElseIf command = "test mde" Then
            memphis.desktop.Show()
            txtterm.FindForm.TopMost = False
        ElseIf command = "dir" Or command = "ls" Then
            If boughtdirectorysurfing Then
                AddLine("Type   | Name ")
                AddLine("-------+-------------------------------------------")
                For Each Dir As String In IO.Directory.GetDirectories(currentdir)
                    Dim dirinf As New IO.DirectoryInfo(Dir)
                    AddLine("[DIR]  | " & dirinf.Name)
                Next
                For Each file As String In IO.Directory.GetFiles(currentdir)
                    Dim filinf As New IO.FileInfo(file)
                    AddLine(filinf.Extension & "   | " & filinf.Name)
                Next
            Else
                wrongcommand()
            End If
        ElseIf command Like "mkdir *" Then
            If boughtdirectorysurfing = True Then
                Dim foldertomake As String = command.Replace("mkdir ", "")
                If IO.Directory.Exists(currentdir + "\" + foldertomake) Then
                    AddLine("Directory already exists!")
                Else
                    IO.Directory.CreateDirectory(currentdir + "\" + foldertomake)
                    AddLine("mkdir: Directory created successfully.")
                End If
            Else
                wrongcommand()
            End If
        ElseIf command Like "give me * codepoints" Then
            Dim args() As String = command.Split(" ")
            Dim cp As String = args(2)
            AddCP(cp)
            AddLine("Added " & cp & " to your existing ammount of Codepoints.")
        ElseIf command Like "set * *" Then
            Dim args() As String = command.Split(" ")
            Select Case args(1)
                Case "username"
                    If boughtcustomusername Then
                        username = args(2)
                    Else
                        wrongcommand()
                    End If
                Case "textcolor"
                    If boughtterminalsettextcolor Then
                        txtterm.ForeColor = SetColorbasic(args(2))
                    End If
                Case Else
                    AddLine("set: No valid setting node in configuration file for """ & args(1) & """.")
            End Select
        ElseIf command = "05tray" Then
            AddLine("500 Codepoints have been added.")
            AddCP(500)
        ElseIf command Like "open *" Then
            Dim progtoopen As String = command.Replace("open ", "")
            OpenProgram(progtoopen)
        ElseIf command Like "close *" Then
            Dim progtoclose As String = command.Replace("close ", "")
            If progtoclose = "terminal" Then
                If boughtbasicwm = True Then
                    txtterm.FindForm.Close()
                Else
                    AddLine("close: Cannot close the Terminal!")
                End If
            Else
                closeprogram(progtoclose)
            End If
        ElseIf command Like "shutdown" Then
            savegame()
            Application.Exit()
        ElseIf command Like "math*" Then
            mathquiz = True
            changeinterpreter()
        ElseIf command Like "guess the number" Or command Like "guess" Then
            guessthenumber = True
            changeinterpreter()
        ElseIf command Like "code*" Or command = "code points" Then
            AddLine("You have " & codepoints & " Codepoints.")
        ElseIf command Like "bwm" Then
            If boughtbasicwm = True Then
                BasicWM.Desktop.Show()
            Else
                wrongcommand()
            End If
        ElseIf command = "colors" Then
            showterminalcolors()
        ElseIf command Like "" Then
            'This is here to make it so that the Terminal doesn't say "Wrong Command" if the user doesn't input anything.
        Else
            If IO.File.Exists(currentdir + "\" + command) Then
                openfile(currentdir + "\" + command)
            ElseIf IO.File.Exists(command) Then
                openfile(command)
            Else
                OpenProgram(command)
            End If
        End If
    End Sub

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
            Case "shifter", "skin", "shift"
                If boughtshifter Then BasicWM.Shifter.Show() Else AddLine("open: Invalid program """ & progtoopen & """.")

            Case "shiftorium", "packages", "pacman", "code shop"
                shiftorium_cmd.Show()
            Case "math", "mathquiz", "math quiz"
                mathquiz = True
                changeinterpreter()
            Case "guess the number", "guess"
                guessthenumber = True
                changeinterpreter()
            Case "files", "fileskimmer", "file skimmer", "fs", "file browser"
                If boughtfileskimmer = True Then
                    BasicWM.File_Skimmer.Show()
                Else
                    AddLine("open: Invalid program """ & progtoopen & """.")
                End If
            Case "skinloader", "skin loader"
                If boughtskinloader = True Then BasicWM.SkinLoader.Show() Else AddLine("open: Invalid program """ & progtoopen & """.")

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
                    BasicWM.File_Skimmer.Hide()
                Else
                    AddLine("close: Invalid program """ & progtoclose & """.")
                End If
            Case "textpad", "text", "notepad"
                If boughttextpad = True Then
                    TextPad.Hide()
                Else
                    AddLine("close: Invalid program """ & progtoclose & """.")
                End If
            Case "shifter", "skin", "shift"
                If boughtshifter Then BasicWM.Shifter.Hide() Else AddLine("close: Invalid program """ & progtoclose & """.")
            Case "skinloader", "skin loader"
                If boughtskinloader = True Then BasicWM.SkinLoader.Hide() Else AddLine("close: Invalid program """ & progtoclose & """.")
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

