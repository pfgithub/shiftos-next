Public Class Terminal

    Public currentdir As String = root
    Public prompttoupdatesave As Boolean = False
    Dim trackpos As Integer = 0

    Public Sub terminal_Innitiate(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        loadgame()
        AddLine(username + "@" + osname + " " & currentdir.ToLower.Replace("c:\shiftos", "~") & "$> ")
        SelectBottom()
        If prompttoupdatesave = True Then
            AddLine("ShiftOS has encountered an error loading configuration files. Press any key to reset damaged files.")
        End If
    End Sub



    Public Sub Interpret(command As String)
        command = command.ToLower
        If command Like "help" Then
            ShowHelp()
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
                        Select Case args(2)
                            Case "black"
                                AddLine("Error! Black and black don't go too well...")
                            Case "white"
                                txtterm.ForeColor = Color.White
                            Case "gray"
                                If boughtgray Then
                                    txtterm.ForeColor = Color.Gray
                                Else
                                    AddLine("Error! Unsupported color.")
                                End If
                            Case "red"
                                If boughtred Then
                                    txtterm.ForeColor = Color.Red
                                Else
                                    AddLine("Error! Unsupported color.")
                                End If
                            Case "green"
                                If boughtgreen Then
                                    txtterm.ForeColor = Color.Green
                                Else
                                    AddLine("Error! Unsupported color.")
                                End If
                            Case "blue"
                                If boughtblue Then
                                    txtterm.ForeColor = Color.Blue
                                Else
                                    AddLine("Error! Unsupported color.")
                                End If
                            Case "yellow"
                                If boughtyellow Then
                                    txtterm.ForeColor = Color.Yellow
                                Else
                                    AddLine("Error! Unsupported color.")
                                End If
                            Case "orange"
                                If boughtorange Then
                                    txtterm.ForeColor = Color.Orange
                                Else
                                    AddLine("Error! Unsupported color.")
                                End If
                            Case "pink"
                                If boughtpink Then
                                    txtterm.ForeColor = Color.Pink
                                Else
                                    AddLine("Error! Unsupported color.")
                                End If
                            Case "purple"
                                If boughtpurple Then
                                    txtterm.ForeColor = Color.Purple
                                Else
                                    AddLine("Error! Unsupported color.")
                                End If
                            Case "brown"
                                If boughtbrown Then
                                    txtterm.ForeColor = Color.Brown
                                Else
                                    AddLine("Error! Unsupported color.")
                                End If
                            Case Else
                                AddLine("Error! Unsupported color, check 'colors' for a list of supported colors.")
                        End Select
                    End If
                Case Else
                    AddLine("set: No valid setting node in configuration file for """ & args(1) & """.")
            End Select
        ElseIf command Like "open *" Then
            Dim progtoopen As String = command.Replace("open ", "")
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
        ElseIf command Like "shutdown" Then
            savegame()
            Me.Close()
        ElseIf command Like "math*" Then
            mathquiz = True
            changeinterpreter()
        ElseIf command Like "guess the number" Or command Like "guess" Then
            guessthenumber = True
            changeinterpreter()
        ElseIf command Like "code*" Or command = "code points" Then
            AddLine("You have " & codepoints & " Codepoints.")
        ElseIf command = "colors" Then
            showterminalcolors()
        ElseIf command Like "" Then
            'This is here to make it so that the Terminal doesn't say "Wrong Command" if the user doesn't input anything.
        Else
            If IO.File.Exists(currentdir + "\" + command) Then
                OpenFile(currentdir + "\" + command)
            ElseIf IO.File.Exists(command) Then
                OpenFile(command)
            Else
                wrongcommand()
            End If
        End If
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


End Class