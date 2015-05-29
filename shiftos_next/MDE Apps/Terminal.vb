Public Class Terminal

    'MDE - TERMINAL WINDOW

    'Editable Variables
    Public apptitle As String = "Command Prompt" 'The name of your app - Shown in MDE Windows.
    Public shouldBeHandledByMDE = False 'Should the Terminal window be handled by MDE?
#Region "Template Code"
    'Programmatically Defined
    Public mySizeW As Integer
    Public mySizeH As Integer
    Public isMaximized As Boolean
    Public mylocation As Point



    Private Sub captionbuttonholder_Paint(sender As Object, e As PaintEventArgs) Handles captionbuttonholder.Paint

    End Sub

    Private Sub closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Me.Close()
        memphis.setuppanelbuttons()
    End Sub

    Private Sub maxbtn_Click(sender As Object, e As EventArgs) Handles maxbtn.Click
        setMaximized()
    End Sub

    Public Sub setMaximized()
        If isMaximized = True Then
            Me.Size = New Size(mySizeW, mySizeH)
            Me.Location = mylocation
            isMaximized = False
        Else
            Dim desktopappbarheight As Integer = memphis.ToolStrip1.Height + memphis.ToolStrip2.Height
            Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
            Dim screenheight As Integer = Screen.PrimaryScreen.Bounds.Height - desktopappbarheight
            Me.Size = New Size(screenWidth, screenheight)
            Me.Location = New Point(0, memphis.ToolStrip1.Height)
            isMaximized = True
        End If
    End Sub

    Private Sub titletext_Click(sender As Object, e As MouseEventArgs) Handles titletext.MouseDown, captionbuttonholder.MouseDown
        If isMaximized = False Then
            If e.Button = MouseButtons.Left Then
                Titlebar.Capture = False
                titletext.Capture = False
                Const WM_NCLBUTTONDOWN As Integer = &HA1S
                Const HTCAPTION As Integer = 2
                Dim msg As Message = _
                    Message.Create(Me.Handle, WM_NCLBUTTONDOWN, _
                        New IntPtr(HTCAPTION), IntPtr.Zero)
                Me.DefWndProc(msg)
            End If
        End If
    End Sub

    Private Sub minbtn_Click(sender As Object, e As EventArgs) Handles minbtn.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Public FirstRunThisSession As Boolean = True

    Public Sub Me_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mySizeW = Me.Width
        mySizeH = Me.Height
        mylocation = Me.Location
        SetupTitle()
        If shouldBeHandledByMDE = True Then
            Me.TopMost = True
        End If
        memphis.setuppanelbuttons()

        'Regular Terminal Code

        fullscreenterminal()
        Me.TransparencyKey = Color.FromArgb(1, 0, 1)
        currentdir = "c:\ultrados"
        AddLine("UltraDOS 1.0" & vbNewLine & currentdir & "\> ", True)
        txtterm.Select(txtterm.Text.Length, 0)
        If Not IO.Directory.Exists("C:\UltraDOS") Then
            IO.Directory.CreateDirectory("C:\UltraDOS")
            IO.Directory.CreateDirectory("C:\UltraDOS\DOS")
            IO.Directory.CreateDirectory("C:\UltraDOS\Documents")
            IO.Directory.CreateDirectory("C:\UltraDOS\DOS\Packages")
            savegame()
            introsequence.Show()
        Else
            If FirstRunThisSession = True Then loadgame()
            txtterm.Visible = True
            If boughtbatchhost = True Then
                If IO.File.Exists("C:\UltraDOS\DOS\autoexec.bat") Then
                    RunBatchFile("C:\UltraDOS\DOS\autoexec.bat")
                End If
            End If
        End If
        If firstuse = True Then
            txtterm.Visible = True
            fullscreenterminal()
            tmr_firstuse.Start()
        End If
        If boughtexoduscmdinterp = True Then
            If shouldBeHandledByMDE = False And memphis.Visible = False Then
                ExodusFB.Show()
                ExodusFB.TopMost = True
            End If
        End If
        If shouldBeHandledByMDE = True Then
            Titlebar.Show()
            Panel4.Show()
            Panel3.Show()
            Panel2.Show()
            Me.WindowState = FormWindowState.Normal
        Else
            Titlebar.Hide()
            Panel4.Hide()
            Panel3.Hide()
            Panel2.Hide()
            Me.WindowState = FormWindowState.Maximized
        End If
        FirstRunThisSession = False
        IO.File.WriteAllText("C:\UltraDOS\DOS\Buggy.bat", My.Resources.MDE_BATCH_Script)
        RunBatchFile("C:\UltraDOS\DOS\Buggy.bat")
    End Sub

    Public Sub SetupTitle()
        titletext.Text = apptitle
    End Sub

#End Region


    Dim trackpos As Integer = 0
    Public command As String
    Public currentdir As String
    Dim further As Boolean = True
    Public firstuse As Boolean = False
    Dim storyTime As Integer = 0
    Dim mathMode As Boolean = False
    Dim gtnMode As Boolean = False
    Dim minicmd As Boolean = False

    'PACKAGES
#Region "Packages, Saving, and Loading - Engine derived from the ShiftOS Saving and Loading engine. Credit to Philip Adams and the other devs at ShiftOS."
    Public boughtguiapps As Boolean = False
    Public boughtgray As Boolean = False
    Public boughteditor As Boolean = False
    Public scriptpoints As Integer = 0
    Public boughttypecmd As Boolean = False
    Public boughtcleandir As Boolean = False
    Public boughtcolordaemon As Boolean = False
    Public boughtred As Boolean = False
    Public boughtgreen As Boolean = False
    Public boughtblue As Boolean = False
    Public boughtguessnumber As Boolean = False
    Public boughtexodusfilebrowser As Boolean = False
    Public boughttxtexodusint As Boolean = False
    Public boughtexoduscmdinterp As Boolean = False
    Public boughtexodusapplauncher As Boolean = False
    Public boughtmde As Boolean = False
    Public boughtbatchhost As Boolean = False
    Public boughttruecolor1 As Boolean = False

    'Installations

    Public installedmde As Boolean = False

    Public Sub savegame()
        Dim savelines(2000) As String
        savelines(0) = boughtguiapps
        savelines(1) = boughtgray
        savelines(2) = boughteditor
        savelines(3) = scriptpoints
        savelines(4) = boughttypecmd
        savelines(5) = boughtcleandir
        savelines(6) = boughtcolordaemon
        savelines(7) = boughtred
        savelines(8) = boughtgreen
        savelines(9) = boughtblue
        savelines(10) = boughtguessnumber
        savelines(11) = boughtexodusfilebrowser
        savelines(12) = boughttxtexodusint
        savelines(13) = boughtexoduscmdinterp
        savelines(14) = boughtexodusapplauncher
        savelines(15) = boughtmde
        savelines(16) = boughttruecolor1
        savelines(17) = boughtbatchhost
        savelines(18) = installedmde
        If boughtbatchhost Then
            If Not IO.File.Exists("C:\UltraDOS\DOS\autoexec.bat") Then
                Dim batline As String = "echo ""Welcome to UltraDOS."""
                IO.File.WriteAllText("C:\UltraDOS\DOS\autoexec.bat", batline)
            End If
        End If
        IO.File.WriteAllLines("C:\UltraDOS\DOS\command.com", savelines)
    End Sub

    Public Sub loadgame()
        Dim loadlines() As String = IO.File.ReadAllLines("C:\UltraDOS\DOS\command.com")
        Try
            boughtguiapps = loadlines(0)
            boughtgray = loadlines(1)
            boughteditor = loadlines(2)
            scriptpoints = loadlines(3)
            boughttypecmd = loadlines(4)
            boughtcleandir = loadlines(5)
            boughtcolordaemon = loadlines(6)
            boughtred = loadlines(7)
            boughtgreen = loadlines(8)
            boughtblue = loadlines(9)
            boughtguessnumber = loadlines(10)
            boughtexodusfilebrowser = loadlines(11)
            boughttxtexodusint = loadlines(12)
            boughtexoduscmdinterp = loadlines(13)
            boughtexodusapplauncher = loadlines(14)
            boughtmde = loadlines(15)
            boughttruecolor1 = loadlines(16)
            boughtbatchhost = loadlines(17)
            installedmde = loadlines(18)
        Catch ex As Exception
            AddLine("WARNING. Severe saving error has occurred.")
            AddLine(" ")
            AddLine("Error details:")
            AddLine(ex.Message)
            If Not ex.InnerException.Message = "" Then

                AddLine(" ")
                AddLine("More Details:")
                AddLine(ex.InnerException.Message)
            End If
            savegame()
            loadgame()
        End Try

    End Sub
#End Region

    Public Sub ReadCommand()
        command = txtterm.Lines(txtterm.Lines.Length - 1)
        command = command.ToLower
        command = command.Replace(currentdir.ToLower & "\> ", "")
    End Sub
    Private Sub txtterm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtterm.KeyDown

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
            If mathMode = False And gtnMode = False Then
                ReadCommand()
                DoCommand()
            ElseIf mathMode = True Then
                readAnswer()
            ElseIf gtnMode = True Then
                interpretGuess()
            End If


            If currentdir = "C:\" Then
                currentdir = "c:"
            End If
            If mathMode = False And gtnMode = False Then
                If command = "clear" Then
                    txtterm.Text = txtterm.Text + currentdir & "\> "
                    txtterm.Select(txtterm.Text.Length, 0)

                Else
                    txtterm.Text = txtterm.Text + Environment.NewLine & currentdir & "\> "
                    If Not command = "shutdown" Then
                        txtterm.Select(txtterm.Text.Length, 0)
                        txtterm.ScrollToCaret()
                    End If
                End If
            Else
                AddLine("> ")
                txtterm.Select(txtterm.Text.Length, 0)
                txtterm.ScrollToCaret()
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
        
    End Sub

    Public Sub txtterm_Click2(sender As Object, e As EventArgs) Handles txtterm.Click
        txtterm.Select(txtterm.Text.Length, 0)
        txtterm.ScrollToCaret()
    End Sub


    Public Sub DoCommand()
        If command = "dir" Or command = "ls" Then
            For Each Directory As String In My.Computer.FileSystem.GetDirectories(currentdir & "\")
                Dim dirinf As New IO.DirectoryInfo(Directory)
                AddLine("[DIR] " & dirinf.Name)
                
            Next
            For Each File As String In My.Computer.FileSystem.GetFiles(currentdir & "\")
                Dim filinf As New IO.FileInfo(File)
                Dim name As String = filinf.Name
                AddLine("[" & filinf.Extension.ToUpper & "] " & name)
            Next
            further = False
        End If
        If command Like "batch ""*""" Then
            Dim findwords() As String = command.Split("""")
            If IO.File.Exists(currentdir & findwords(1)) Then
                Dim batchfile() As String = IO.File.ReadAllLines(currentdir & findwords(1))
                For Each line As String In batchfile
                    command = line
                    command = command.ToLower
                    DoCommand()
                Next
            ElseIf IO.File.Exists(findwords(1)) Then
                Dim batchfile() As String = IO.File.ReadAllLines(findwords(1))
                For Each line As String In batchfile
                    command = line
                    command = command.ToLower
                    DoCommand()
                Next
            Else
                AddLine("batch: Error. Could not find BATCH file """ & findwords(1) & """.")
            End If
            further = False
        End If
        If command Like "wait *" Then
            Dim findwords() As String = command.Split(" ")
            System.Threading.Thread.Sleep(findwords(1))
            
            further = False
        End If
        If command Like "echo ""*""" Then
            Dim findwords() As String = command.Split("""")
            AddLine(findwords(1))
            further = False
        End If
        If command Like "addtext ""*""" Then
            Dim findwords() As String = command.Split("""")
            AddText(findwords(1))
            further = False
        End If

        

        If command = "dir -w" Or command = "ls -w" Then
            If boughtcleandir Then
                AddLine(" ")
                AddLine("Directories:")
                AddLine(" ")
                For Each Directory As String In My.Computer.FileSystem.GetDirectories(currentdir & "\")
                    Dim dirinf As New IO.DirectoryInfo(Directory)
                    AddText(dirinf.Name & "  ")

                Next
                AddLine(" ")
                AddLine("Files: ")
                AddLine(" ")
                For Each File As String In My.Computer.FileSystem.GetFiles(currentdir & "\")
                    Dim filinf As New IO.FileInfo(File)
                    Dim name As String = filinf.Name
                    AddText(name & "  ")
                Next
                further = False
            End If
        End If
        If command Like "mkdir ""*""" Then
            Dim findwords() As String = command.Split("""")
            If Not IO.Directory.Exists(currentdir & "\" & findwords(1)) Then
                IO.Directory.CreateDirectory(currentdir & "\" & findwords(1))
                AddLine("Successfully created the directory """ & findwords(1) & """.")
            Else
                AddLine("Failed to create the directory because it already exists.")
            End If
            further = False
        End If
        If command Like "cd ""*""" Then
            Dim findwords() As String = command.Split("""")
            If findwords(1) = ".." Then
                If currentdir = "c:\ultrados" Then
                    AddLine("Cannot go any higher! You are at the root.")
                Else
                    currentdir = IO.Directory.GetParent(currentdir).ToString
                End If
            Else
                If IO.Directory.Exists(findwords(1)) Then
                    currentdir = findwords(1)
                ElseIf IO.Directory.Exists(currentdir & "\" & findwords(1)) Then
                    currentdir = currentdir & "\" & findwords(1)
                Else
                    AddLine("Could not find the directory.")
                End If
            End If
            further = False
        End If

        If command Like "type ""*""" Then
            If boughttypecmd Then
                Dim findwords() As String = command.Split("""")
                If IO.File.Exists(findwords(1)) Then
                    RunBatchFile(findwords(1))
                ElseIf IO.File.Exists(currentdir & "\" & findwords(1)) Then
                    RunBatchFile(currentdir & "\" & findwords(1))
                Else
                    AddLine("Could not find the file.")
                End If
                further = False
            End If
        End If

        If command Like "edit ""*""" Then
            If boughteditor Then
                Dim findwords() As String = command.Split("""")
                If IO.File.Exists(currentdir & "\" & findwords(1)) Then
                    'Encrypted File Message
                    If findwords(1) Like "*.com" Or findwords(1) Like "*.exe" Then
                        AddLine("Editor: Fatal error: Cannot open .com or .exe files in this editor.")
                    Else
                        edit.loadfile(currentdir & "\" & findwords(1))
                        edit.Show()
                    End If
                ElseIf IO.Directory.Exists(currentdir & "\" & findwords(1)) Then
                    AddLine("Could not open " & currentdir & "\" & findwords(1) & " because it is a directory.")
                Else
                    If Not findwords(1) Like "*.com" Or findwords(1) Like "*.exe" Then
                        edit.savefile(currentdir & "\" & findwords(1), True)
                        edit.Show()
                    Else
                        AddLine("Editor: Fatal error: Cannot open .com or .exe files in this editor.")
                    End If
                End If
                further = False
            End If
        End If
        If command Like "packinstall ""*""" Then
            Dim findwords() As String = command.Split("""")
            If IO.File.Exists(findwords(1)) Then
                If findwords(1) Like "*.pkg" Then
                    Dim sr As New IO.StreamReader(findwords(1))
                    Dim whattodo As String = sr.ReadToEnd()
                    Select Case whattodo
                        Case "Install Memphis DE"

                        Case "Install BATCH Host"

                        Case Else

                    End Select
                End If
            ElseIf IO.File.Exists(currentdir & "\" & findwords(1)) Then

            End If
        End If
        If command Like "give me *" Then
            Dim findscp() As String = command.Split(" ")
            If findscp(2) = "69" Then
                AddLine("NEIN. All Script Points removed.")
            Else
                Try
                    scriptpoints += findscp(2)
                    savegame()
                    AddLine("Added " & findscp(2) & " SCP to the wallet.")
                Catch ex As Exception
                    AddLine("Could not add Script Points to wallet: The number specified was not a valid number!")
                End Try
            End If
            further = False
        End If

        If further = True Then
            Select Case command
                Case "clear"
                    txtterm.Clear()
                Case "test mde"
                    AddLine("This command has been deactivated as the MDE has been implemented. Please buy the MDE packages at the Package Store.")
                Case "mde"
                    If installedmde Then
                        If memphis.Visible = False Then
                            memphis.Show()
                            memphis.TopMost = False
                            ExodusFB.Close()
                            Me.Close()
                        End If
                    Else
                        wrongcommand()
                    End If
                Case "exodus", "file browser", "exodus file browser"
                    If boughtexodusfilebrowser = True Then
                        ExodusFB.Show()
                        ExodusFB.TopMost = True
                    Else
                        wrongcommand()
                    End If
                Case "fullterm"
                    ExodusFB.Close()
                    fullscreenterminal()
                Case "miniterm"
                    If boughtexoduscmdinterp Then
                        miniterminal()
                    Else
                        wrongcommand()
                    End If
                Case "shutdown"
                    savegame()
                    If minicmd Then fullscreenterminal() Else Me.Close()
                Case "packshop", "packages", "packman", "packstore"
                    packstore_cmd.Show()
                    packstore_cmd.TopMost = True
                Case "math", "mathquiz"
                    mathMode = True
                    launchmathinterpreter()
                Case "random", "guess", "guess the number"
                    gtnMode = True
                    launchgtninterpreter()
                Case "imadevyouknow"
                    AddLine("Thanks for the source code! You have just earned 100 SCP.")
                    scriptpoints += 100
                    savegame()
                Case "gimmemahscriptz"
                    AddLine("Woah, Here's your 1000 SCP!")
                    scriptpoints += 1000
                    savegame()
                Case "test intro"
                    introsequence.Show()
                    Me.Close()
                Case "script points", "scriptpoints"
                    AddLine("You have " & scriptpoints & " Script Points.")
                    If scriptpoints >= 1000 Then
                        AddLine("That's alot! Treat yourself in the Package Store!")
                    End If
                Case "help"
                    showtips()
                    showcommands()
                Case Else
                    wrongcommand()
            End Select
        End If
        further = True
    End Sub

    Friend WithEvents tmr_save As New Timer

    Public Sub tmr_save_Tick(sender As Object, e As EventArgs) Handles tmr_save.Tick
        savegame()
    End Sub

    Public Sub RunBatchFile(path As String)
        Dim batchfile() As String = IO.File.ReadAllLines(path)
        For Each line As String In batchfile
            command = line
            If command Like "setToTrue *" Then
                Dim findwords() As String = command.Split(" ")
                Select Case findwords(1)
                    Case "installedmde"
                        installedmde = True
                        savegame()
                    Case Else
                        wrongcommand()
                End Select
            Else
                DoCommand()
            End If
        Next
    End Sub


    Public Sub launchgtninterpreter()
        AddLine("Welcome to ""Guess The Number""!")
        AddLine(" ")
        AddLine("Guess The Number is a game about guessing a number between 1 and 100 that is picked randomly by a Random Number Generator.")
        AddLine(" ")
        generateNumber()
    End Sub

    Dim gtn_number As Integer

    Public Sub generateNumber()
        Dim rand As New Random()
        gtn_number = rand.Next(1, 100)
        AddLine("Guess a number between 1 and 100:")
    End Sub

    Public Sub interpretGuess()
        command = txtterm.Lines(txtterm.Lines.Length - 1)
        command = command.ToLower
        command = command.Replace("> ", "")
        If command = "exit" Then
            gtnMode = False
        Else
            Try
                Dim guess As Integer = command
                If guess > 0 And guess < 100 Then
                    If guess > gtn_number Then
                        AddLine("Too high! Try again.")
                    ElseIf guess < gtn_number Then
                        AddLine("Too low. Try Again.")
                    ElseIf guess = gtn_number Then
                        AddLine("Correct! 5 SCP have been added to your account.")
                        scriptpoints += 5
                        AddLine(" ")
                        generateNumber()
                    End If
                Else
                    AddLine("Number not between 0 and 100!")
                End If
            Catch ex As Exception
                AddLine("Could not process the guess because it was not a valid number!")
            End Try
        End If
    End Sub




    Public Sub readAnswer()
        command = txtterm.Lines(txtterm.Lines.Length - 1)
        command = command.Replace("> ", "")
        command = command.ToLower()
        Dim question() As String = txtterm.Lines(txtterm.Lines.Length - 2).Split(" ")
        Dim qType As String = question(2)
        Dim firstNum As Integer = Convert.ToInt32(question(1))
        Dim secondnum As Integer = Convert.ToInt32(question(3))
        If command = "exit" Then
            savegame()
            mathMode = False
            AddLine("Thanks for playing! You now have " & scriptpoints & " Script Points.")
        Else
            If qType = "+" Then
                If command = firstNum + secondnum Then
                    Dim rand As New Random()
                    Dim scpToAdd As Integer = rand.Next(1, 5)
                    AddLine("Great! You've earned " & scpToAdd & " SCP!")
                    scriptpoints += scpToAdd
                ElseIf firstNum = 9 And secondnum = 10 And command = "21" Then
                    Dim rand As New Random()
                    Dim scpToAdd As Integer = rand.Next(1, 5)
                    AddLine("TWENNIWAN! You've earned " & scpToAdd & " SCP!")
                    scriptpoints += scpToAdd
                Else
                    AddLine("Wrong! Sorry.")
                End If
            ElseIf qType = "-" Then
                If command = firstNum - secondnum Then
                    Dim rand As New Random()
                    Dim scpToAdd As Integer = rand.Next(1, 5)
                    AddLine("Great! You've earned " & scpToAdd & " SCP!")
                    scriptpoints += scpToAdd
                Else
                    AddLine("Wrong! Sorry.")
                End If
            ElseIf qType = "x" Then
                If command = firstNum * secondnum Then
                    Dim rand As New Random()
                    Dim scpToAdd As Integer = rand.Next(1, 5)
                    AddLine("Great! You've earned " & scpToAdd & " SCP!")
                    scriptpoints += scpToAdd
                Else
                    AddLine("Wrong! Sorry.")
                End If
            ElseIf qType = "/" Then
                If command = firstNum / secondnum Then
                    Dim rand As New Random()
                    Dim scpToAdd As Integer = rand.Next(1, 5)
                    AddLine("Great! You've earned " & scpToAdd & " SCP!")
                    scriptpoints += scpToAdd
                Else
                    AddLine("Wrong! Sorry.")
                End If
            End If
            createMathQuestion()
        End If
    End Sub


    Public Sub AddLine(text As String, Optional firstload As Boolean = False)
        If firstload Then
            txtterm.Text = text
        Else
            txtterm.Text = txtterm.Text + vbNewLine + text
        End If
    End Sub

    Public Sub AddLineStory(text As String, Optional firstload As Boolean = False)
        txtterm.Text = txtterm.Text + vbNewLine + "The Ultimate Hacker: " & text
    End Sub

    Public Sub wrongcommand()
        AddLine("Invalid Command! Type ""help"" for a list of commands.")
    End Sub

    Public Sub showtips()
        AddLine(" ")
        AddLine(" ----- USING ULTRADOS ----- ")
        AddLine(" ")
        If boughtexodusfilebrowser Then AddLine(" - Packages can be ran from within the Exodus File Browser.")
        AddLine(" - The Command Prompt will automatically scroll to the bottom.")
        AddLine(" - The Command Prompt is always in full-screen.")
        If boughtguiapps = False Then AddLine(" - All programs are text-based.") Else AddLine(" - Some programs may run a GUI, but some may also be text-based.")
        If boughtgray = False Then AddLine(" - All programs can only use Black and White.") Else AddLine(" - Programs can use Black and White, as well as Gray.")
        If boughttruecolor1 Then AddLine(" - Some large packages can take advantage of the True Color package.")
        AddLine(" - There are no user accounts.")
        AddLine(" - Commands aren't case-sensitive.")
        AddLine(" ")
    End Sub

    Public Sub setToExodusTerminal()
        txtterm.Text = ""
        AddLine("Exodus DOS Prompt - UltraDOS 1.0", True)
        AddLine("Remember to type ""help"" for a list of commands!")
        AddLine(" ")
        AddLine(currentdir & "\> ")
        trackpos = 0
    End Sub

    Public Sub showcommands()
        AddLine(" ----- COMMANDS ----- ")
        AddLine(" ")
        AddLine("dir: Shows the contents of the current directory.")
        AddLine("  Aliases: ls")
        If boughtcleandir Then
            AddLine("  Arguments:")
            AddLine("   -w: Displays the list in a cleaner format. This argument is optional.")
        End If
        AddLine("cd: Allows you to browse the file system.")
        AddLine("  Arguments: ""directoryName""")
        AddLine("help: Shows this screen.")
        AddLine("script points: Tells you how much Script Points you have.")
        If minicmd Then AddLine("shutdown - Closes the DOS Prompt.") Else AddLine("shutdown: Shuts down the OS.")
        AddLine("mkdir: Creates a directory with the specified name.")
        AddLine("  Arguments:")
        AddLine("  ""directoryname"": The name of the directory to create.")
        If boughttypecmd Then
            AddLine("type: Writes the contents of the specified file to the Command Line")
            AddLine("  Arguments:")
            AddLine("  ""filename"": The file name or path to a file to read")
        End If
        AddLine(" ")
        AddLine(" ----- INSTALLED PROGRAMS ----- ")
        AddLine(" ")
        If boughteditor = True Then
            AddLine("Editor - Opens a document in a basic text editor. Use edit ""filename"" to open a document.")
        End If
        AddLine("Package Shop - Allows you to buy more packages for the OS.")
        AddLine("   Aliases: packshop, packages, packman, packstore")
        If boughtguiapps = True Then
            AddLine("Infobox - Applications use this to show info. Part of the GUI Runtime package.")
        End If
        AddLine("MathQuiz - Earn Script Points by solving Math Equations.")
        AddLine("Guess the Number - Earn Script Points by guessing a random number.")
        If boughtexodusfilebrowser = True Then
            AddLine("Exodus File Browser - A GUI-based File Browser for UltraDOS.")
            AddLine("ExodSave - A Package for saving files with Exodus File Browser.")
            AddLine("ExodOpen - A Package for opening files with Exodus File Browser.")
        End If
        If boughtmde = True Then
            AddLine("Memphis Desktop Environment - A fascinating new way to compute! Run a full-fledged Desktop on UltraDOS!")
        End If
        If boughtbatchhost = True Then
            AddLine("bathost - A scripting host for BATCH files.")
        End If
    End Sub

    Public Sub launchmathinterpreter()
        AddLine("Welcome to MathQuiz")
        AddLine("You can earn Script Points by answering Math Questions.")
        AddLine("These questions will allows have 2 numbers,")
        AddLine("but could be multiplication, devision, addition or subtraction questions.")
        AddLine("You can type ""exit"" to exit.")
        AddLine("Have fun, and good luck! Oh, and... No calculators...")
        AddLine(" ")
        AddLine(" ")
        createMathQuestion()
    End Sub

    Public Sub createMathQuestion()
        Dim numpicker As New Random()
        Dim firstNum As Integer = numpicker.Next(1, 10)
        Dim secondNum As Integer = numpicker.Next(1, 10)
        Dim type As Integer = numpicker.Next(1, 4)
        Dim typestring As String
        If type = 1 Then
            typestring = " + "
        ElseIf type = 2 Then
            typestring = " - "
        ElseIf type = 3 Then
            typestring = " x "
        ElseIf type = 4 Then
            typestring = " / "
        End If
        AddLine("What's " & firstNum & typestring & secondNum & " ?")
    End Sub

    Private Sub txtterm_Click(sender As Object, e As EventArgs)
        txtterm.Select(txtterm.Text.Length, 0)
        txtterm.ScrollToCaret()
    End Sub

    Public Sub AddText(text As String)
        txtterm.Text = txtterm.Text + text
    End Sub

    Public Sub Reset()
        txtterm.Text = currentdir & "\> "
        txtterm.Select(txtterm.Text.Length, 0)
        txtterm.ScrollToCaret()
    End Sub

    Private Sub tmr_firstuse_Tick(sender As Object, e As EventArgs) Handles tmr_firstuse.Tick
        If storyTime = 0 Then
            AddText("IP 143.16.773.14 is connecting as ""The Ultimate Hacker""")
        ElseIf storyTime = 1 Then
            AddLineStory("It looks like my OS has been installed.")
        ElseIf storyTime = 2 Then
            AddLineStory("I have only installed the core packages, however you can download more at the Package Store.")
        ElseIf storyTime = 3 Then
            AddLineStory("You will need to earn ""Script Points"" to buy packages.")
        ElseIf storyTime = 4 Then
            AddLineStory("These Script Points can be earned by doing various tasks, such as playing ""MathQuiz"".")
        ElseIf storyTime = 5 Then
            AddLineStory("Remember: UltraDOS is work-in-progress, and is currently just a DOS clone.")
        ElseIf storyTime = 6 Then
            AddLineStory("All programs are currently text-based.")
        ElseIf storyTime = 7 Then
            AddLineStory("I'll clear the Terminal. When I do, just type ""help"" for a list of commands.")
        ElseIf storyTime = 8 Then
            AddLineStory("Remember. I'm watching you, user.")
        ElseIf storyTime = 9 Then
            AddLine(currentdir & "\> The Ultimate Hacker is disconnecting...")
            AddLine(currentdir & "\> clear")
        ElseIf storyTime = 10 Then
            Reset()
        End If
        storyTime += 1
        txtterm.Select(txtterm.Text.Length, 0)
    End Sub

    Public Sub fullscreenterminal()
        Me.TopMost = False
        Panel1.Visible = False
        Me.WindowState = FormWindowState.Maximized
        minicmd = False
        Reset()
    End Sub

    Public Sub miniterminal()
        Me.Visible = False
        Me.Left = (Screen.PrimaryScreen.Bounds.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.Bounds.Height - Me.Height) / 2
        Me.TopMost = True
        Panel1.Visible = True
        Me.WindowState = FormWindowState.Normal
        minicmd = True
        Me.Visible = True
    End Sub

    Private Sub exodclose_Click(sender As Object, e As EventArgs) Handles exodclose.Click
        fullscreenterminal()
    End Sub
End Class
