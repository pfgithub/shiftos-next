﻿Imports System
Imports System.IO
Imports System.Text
Imports System.Net.Mail

Public Class HijackScreen
    Public actualshiftversion As String = "NEXT 0.0.1"
    Dim newgame As Boolean = True
    Dim tcount As Integer = 0
    Dim rtext As String
    Dim gtexttotype As String
    Dim charcount As Integer
    Dim currentletter As Integer
    Dim slashcount As Integer
    Dim conversationcount As Integer = 0
    Dim textgeninput As Object
    Dim di As DirectoryInfo
    Dim needtoclose As Boolean = False
    Dim oldversion As String
    Public upgraded As Boolean = False

    Dim fs As FileStream
    Dim sw As StreamWriter
    Dim hackeffect As Integer
    Dim percentcount As Integer
    Dim cdrive As System.IO.DriveInfo

    Private Sub HijackScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'extractdlls()
        Control.CheckForIllegalCrossThreadCalls = False
        cdrive = My.Computer.FileSystem.GetDriveInfo("C:\")
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        If My.Computer.FileSystem.DirectoryExists("C:\ShiftOS") Then
            If IO.File.ReadAllText("C:/ShiftOS/Shiftum42/HDAccess.sft") = actualshiftversion Then
                conversationtimer.Start()
                needtoclose = True
                loadgame()
                If boughtbasicwm = True Then
                    BasicWM.Desktop.Show()
                Else
                    Terminal.Show()
                End If
            Else
                oldversion = IO.File.ReadAllText(systemdir + "HDAccess.sft")
                upgraded = True
                System.IO.Directory.Delete(root, True)
                BackgroundWorker1.RunWorkerAsync()
                conversationtimer.Start()
                hackeffecttimer.Start()
            End If
        Else
            BackgroundWorker1.RunWorkerAsync()
            conversationtimer.Start()
            hackeffecttimer.Start()
        End If
    End Sub

    Private Sub TextType(texttotype As String)
        conversationtimer.Stop()
        charcount = texttotype.Length
        gtexttotype = texttotype
        currentletter = 0
        slashcount = 1
        textgen.Start()
    End Sub

    Private Sub textgen_Tick(sender As Object, e As EventArgs) Handles textgen.Tick

        Select Case slashcount
            Case 1
                If currentletter < gtexttotype.Length Then
                    textgeninput.Text = rtext & "\"
                End If

            Case 2
                If currentletter < gtexttotype.Length Then
                    textgeninput.Text = rtext & "|"
                End If

            Case 3
                If currentletter < gtexttotype.Length Then
                    textgeninput.Text = rtext & "/"
                End If

            Case 4
                If currentletter < gtexttotype.Length Then
                    rtext = rtext + gtexttotype.ToCharArray(currentletter, 1)
                    currentletter = currentletter + 1
                    textgeninput.Text = rtext
                    My.Computer.Audio.Play(My.Resources.typesound, AudioPlayMode.Background)
                End If
        End Select

        slashcount = slashcount + 1

        If slashcount = 5 Then slashcount = 1
        If currentletter = gtexttotype.Length Then
            gtexttotype = ""
            conversationtimer.Start()
            textgen.Stop()
        End If


    End Sub

    Private Sub conversationtimer_Tick(sender As Object, e As EventArgs) Handles conversationtimer.Tick
        Select Case conversationcount
            Case 0
                If needtoclose = True Then Me.Close()
            Case 1

                textgeninput = lblHijack
                TextType("Your computer is now being Hijacked")
                conversationtimer.Interval = 1000

            Case 3
                textgeninput = lblhackwords
                textgen.Interval = 10
                rtext = ""
                TextType("Hello, user. My name is DevX. I am the creator of ShiftOS." & Environment.NewLine & Environment.NewLine)
            Case 4
                TextType("I've been scanning your computer, and it seems you have tested a lot of ShiftOS, however since then I've released a lot of updates." & Environment.NewLine & Environment.NewLine)
            Case 5
                TextType("These updates fix a lot of bugs and security holes in ShiftOS and it's mandatory that I install them for you." & Environment.NewLine & Environment.NewLine)
            Case 6
                TextType("Much of the experience is similar, and you will have to upgrade the OS." & Environment.NewLine & Environment.NewLine)
            Case 7
                TextType("In order to install these updates, your hard drive will be involuntarily formatted." & Environment.NewLine & Environment.NewLine)
            Case 8
                TextType("Beginning Hard Drive Format...")
                conversationtimer.Interval = 500
            Case 9, 10, 11, 12, 13, 14, 15, 16, 17
                TextType(".")
            Case 18
                TextType(".")
            Case 19
                rtext = ""
            Case 20
                TextType("Scanning Drive C:\")
            Case 21

                TextType(Environment.NewLine & Environment.NewLine & "Drive Label: " & cdrive.VolumeLabel)
            Case 22
                TextType(Environment.NewLine & "Total Drive Size: " & Format(cdrive.TotalSize.ToString / 1024 / 1024 / 1024, "0.00") & " GigaBytes")
            Case 23
                TextType(Environment.NewLine & "Old File System: ShiftFS")
            Case 24
                TextType(Environment.NewLine & "New File System: ShiftFS_Ultra")
            Case 25
                TextType(Environment.NewLine & Environment.NewLine & "Formatting C:\ - ")
                conversationtimer.Interval = 100
            Case 26 To 126
                textgeninput.Text = rtext & percentcount & "%"
                If percentcount < 101 Then
                    percentcount = percentcount + 1
                    My.Computer.Audio.Play(My.Resources.writesound, AudioPlayMode.Background)
                End If
            Case 127
                rtext = rtext + "100%"
                conversationtimer.Interval = 1000
            Case 128
                TextType(Environment.NewLine & "Format Complete")
            Case 129
                rtext = ""
                percentcount = 0
                TextType("Installing ShiftOS Beta 1.0 - ")
                conversationtimer.Interval = 200
            Case 130 To 230
                textgeninput.Text = rtext & percentcount & "%" & Environment.NewLine & Environment.NewLine
                If percentcount < 101 Then
                    percentcount = percentcount + 1
                    My.Computer.Audio.Play(My.Resources.writesound, AudioPlayMode.Background)
                End If
                Select Case percentcount
                    Case 1 To 2
                        textgeninput.Text = textgeninput.Text & "~/Home"
                        If (Not System.IO.Directory.Exists(home)) Then System.IO.Directory.CreateDirectory(home)
                    Case 3 To 4
                        textgeninput.Text = textgeninput.Text & "~/Home/Documents"
                        If (Not System.IO.Directory.Exists(documents)) Then System.IO.Directory.CreateDirectory(documents)
                    Case 5 To 9
                        textgeninput.Text = textgeninput.Text & "~/Home/Documents/ShiftOSInfo.txt"
                        fs = File.Create(home + "ShiftOSInfo.txt")
                        fs.Close()
                    Case 10 To 12
                        textgeninput.Text = textgeninput.Text & "~/Home/Music"
                        If (Not System.IO.Directory.Exists(music)) Then System.IO.Directory.CreateDirectory(music)
                    Case 13 To 15
                        textgeninput.Text = textgeninput.Text & "~/Home/Pictures"
                        If (Not System.IO.Directory.Exists(pictures)) Then System.IO.Directory.CreateDirectory(pictures)
                    Case 16 To 18
                        textgeninput.Text = textgeninput.Text & "~/Shiftum42"
                        If (Not System.IO.Directory.Exists(systemdir)) Then System.IO.Directory.CreateDirectory(systemdir)
                    Case 19 To 20
                        textgeninput.Text = textgeninput.Text & "~/Shiftum42/Drivers"
                        If (Not System.IO.Directory.Exists(drivers)) Then System.IO.Directory.CreateDirectory(drivers)
                    Case 21 To 27
                        textgeninput.Text = textgeninput.Text & "Writing config files..."
                        savegame()
                    Case 28 To 35
                        textgeninput.Text = textgeninput.Text & "Copying Drivers..."
                        fs = File.Create(drivers + "Keyboard.dri")
                        fs.Close()
                    Case 36 To 44
                        textgeninput.Text = textgeninput.Text & "Copying Drivers..."
                        fs = File.Create(drivers + "Monitor.dri")
                        fs.Close()
                    Case 45 To 52
                        textgeninput.Text = textgeninput.Text & "Copying Drivers..."
                        fs = File.Create(drivers + "Mouse.dri")
                        fs.Close()
                    Case 53 To 60
                        textgeninput.Text = textgeninput.Text & "Copying Drivers..."
                        fs = File.Create(drivers + "Printer.dri")
                        fs.Close()
                    Case 61 To 68
                        textgeninput.Text = textgeninput.Text & "Generating Languages..."
                        If (Not System.IO.Directory.Exists(systemdir + "Languages/")) Then System.IO.Directory.CreateDirectory(systemdir + "Languages/")
                    Case 69 To 76
                        textgeninput.Text = textgeninput.Text & "Generating Languages..."
                        fs = File.Create(systemdir + "Languages/English.lang")
                        fs.Close()
                    Case 77 To 84
                        textgeninput.Text = textgeninput.Text & "Completing update..."
                        fs = File.Create(systemdir + "HDAccess.sft")
                        fs.Close()
                        Dim objWriter As New System.IO.StreamWriter(systemdir + "HDAccess.sft", False)
                        objWriter.Write(actualshiftversion)
                        objWriter.Close()
                    Case 85 To 89
                        textgeninput.Text = textgeninput.Text & "Completing update..."
                        fs = File.Create("C:/ShiftOS/Shiftum42/ShiftGUI.sft")
                        fs.Close()
                    Case 90 To 93
                        textgeninput.Text = textgeninput.Text & "Completing update..."
                        fs = File.Create("C:/ShiftOS/Shiftum42/SKernal.sft")
                        fs.Close()
                    Case 94 To 97
                        textgeninput.Text = textgeninput.Text & "Completing update..."
                        fs = File.Create("C:/ShiftOS/Shiftum42/SRead.sft")
                        fs.Close()
                    Case 98 To 101
                        textgeninput.Text = textgeninput.Text & "Completing update..."
                        fs = File.Create("C:/ShiftOS/Shiftum42/SWrite.sft")
                        fs.Close()
                End Select


            Case 231
                textgeninput.Text = rtext & "100%" & Environment.NewLine & Environment.NewLine & "C:/Shiftum42/SWrite.sft"
                conversationtimer.Interval = 1000
                My.Computer.Audio.Play(My.Resources.writesound, AudioPlayMode.Background)
            Case 232
                textgeninput.Text = rtext & "100%" & Environment.NewLine & Environment.NewLine & "ShiftOS Installation Complete!"
                My.Computer.Audio.Play(My.Resources.typesound, AudioPlayMode.Background)
                If (Not System.IO.Directory.Exists("C:/ShiftOS/SoftwareData/")) Then System.IO.Directory.CreateDirectory("C:/ShiftOS/SoftwareData/")
                If (Not System.IO.Directory.Exists("C:/ShiftOS/SoftwareData/KnowledgeInput")) Then System.IO.Directory.CreateDirectory("C:/ShiftOS/SoftwareData/KnowledgeInput")
                fs = File.Create("C:/ShiftOS/SoftwareData/KnowledgeInput/Animals.lst")
                fs.Close()
                fs = File.Create("C:/ShiftOS/SoftwareData/KnowledgeInput/Fruits.lst")
                fs.Close()
                fs = File.Create("C:/ShiftOS/SoftwareData/KnowledgeInput/Countries.lst")
                fs.Close()
            Case 234
                'ShiftOSDesktop.newgame = True
                'ShiftOSDesktop.Show()
                Terminal.Show()
                Terminal.tmrfirstuse.Start()
                Me.Close()

        End Select
        conversationcount = conversationcount + 1
    End Sub

    Private Sub hackeffecttimer_Tick(sender As Object, e As EventArgs) Handles hackeffecttimer.Tick
        If hackeffect < 101 Then
            Select Case hackeffect
                Case 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39, 41, 43, 45, 47, 49, 51, 53, 55, 57, 59, 61, 63, 65, 67, 69, 71, 73, 75, 77, 79, 81, 83, 85, 87, 89, 91, 93, 95
                    Me.BackColor = Color.Black
                    My.Computer.Audio.Play(My.Resources.writesound, AudioPlayMode.Background)
                Case 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28
                    Me.BackColor = Color.White
                    My.Computer.Audio.Play(My.Resources.typesound, AudioPlayMode.Background)
                Case 30, 32, 34, 36, 38, 40, 42, 44, 46, 48, 50
                    Me.BackColor = Color.Gainsboro
                    My.Computer.Audio.Play(My.Resources.typesound, AudioPlayMode.Background)
                Case 52, 54, 56, 58, 60, 62, 64, 66, 68, 70, 72, 74, 76
                    Me.BackColor = Color.Silver
                    My.Computer.Audio.Play(My.Resources.typesound, AudioPlayMode.Background)
                Case 76, 78, 80, 82, 84, 86, 88, 90, 92, 94
                    Me.BackColor = Color.DimGray
                    My.Computer.Audio.Play(My.Resources.typesound, AudioPlayMode.Background)
                Case 96
                    lblHijack.BackColor = Color.LightGray
                Case 97
                    lblHijack.BackColor = Color.DarkGray
                Case 98
                    lblHijack.BackColor = Color.DimGray
                Case 99
                    lblHijack.BackColor = Color.Black
                    lblHijack.ForeColor = Color.DimGray
                Case 100
                    lblHijack.Hide()
            End Select
        Else
            hackeffecttimer.Stop()
        End If
        hackeffect = hackeffect + 1
    End Sub

    'Private Sub extractdlls() 'If dlls are not in the same folder, this extracts them from resources 
    '    If Not File.Exists(My.Computer.FileSystem.CurrentDirectory & "\AxInterop.WMPLib.dll") Then
    '        System.IO.File.WriteAllBytes(My.Computer.FileSystem.CurrentDirectory & "\AxInterop.WMPLib.dll", My.Resources.AxInterop_WMPLib)
    '    End If
    '    If Not File.Exists(My.Computer.FileSystem.CurrentDirectory & "\Interop.WMPLib.dll") Then
    '        System.IO.File.WriteAllBytes(My.Computer.FileSystem.CurrentDirectory & "\Interop.WMPLib.dll", My.Resources.Interop_WMPLib)
    '    End If
    '   If Not File.Exists(My.Computer.FileSystem.CurrentDirectory & "\ShiftOS License.txt") Then
    '        System.IO.File.WriteAllBytes(My.Computer.FileSystem.CurrentDirectory & "\ShiftOS License.txt", My.Resources.license)
    '   End If
    'End Sub
End Class

