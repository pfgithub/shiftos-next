Imports System.Net.Mail
Namespace ShiftDE
    Public Class Terminal

        Dim firstrun As Integer = 0





        Private Sub tmrfirstrun_Tick(sender As Object, e As EventArgs) Handles tmrfirstrun.Tick
            Select Case firstrun
                Case 1
                    AddLine("The Shifter's Desktop has been installed successfully.")
                Case 2
                    AddLine("IP 199.108.232.1 Connecting as 'DevX'...")
                    My.Computer.Audio.Play(My.Resources.dial_up_modem_02, AudioPlayMode.Background)
                Case 12
                    AddLine("IP 199.108.232.1 Connected!")
                    My.Computer.Audio.Play(My.Resources.writesound, AudioPlayMode.Background)
                Case 15
                    AddLine("DevX: Wow, " & username & ". You've fallen for a huge trap.")
                    My.Computer.Audio.Play(My.Resources.writesound, AudioPlayMode.Background)
                Case 22
                    AddLine("DevX: You obviously didn't read the EULA during Setup, did you?")
                    My.Computer.Audio.Play(My.Resources.writesound, AudioPlayMode.Background)
                Case 28
                    AddLine("DevX: You see, By installing the Shifter's Desktop, you give me full access to your computer.")
                    My.Computer.Audio.Play(My.Resources.writesound, AudioPlayMode.Background)
                Case 36
                    AddLine("DevX: I can prove it. Say goodbye to your documents.")
                    My.Computer.Audio.Play(My.Resources.writesound, AudioPlayMode.Background)
                    If IO.Directory.Exists(documents) Then IO.Directory.Delete(documents, True)
                    IO.Directory.CreateDirectory(documents)
                Case 39
                    AddLine("[Core] Folder at " & documents & " has been cleared of it's files.")
                Case 44
                    AddLine("DevX: Bet you're scared, right? I'd erase your system folder, but unfortunately, I'd lose control of your PC.")
                    My.Computer.Audio.Play(My.Resources.writesound, AudioPlayMode.Background)
                Case 50
                    AddLine("DevX: Enjoy your PC, before it's too late.")
                    My.Computer.Audio.Play(My.Resources.writesound, AudioPlayMode.Background)
                Case 59
                    AddLine("DevX: Remember, I am watching you, " & username & ".")
                    My.Computer.Audio.Play(My.Resources.writesound, AudioPlayMode.Background)
                Case 65
                    AddLine("User 'DevX' has disconnected.")
                Case 72
                    My.Computer.Audio.Play(My.Resources.typesound, AudioPlayMode.Background)
                    tmrfirstrun.Stop()
                    Me.Close()
            End Select
            firstrun = firstrun + 1
        End Sub

        Public Sub runterminalfile(ByVal path As String)
            Dim sr As System.IO.StreamReader
            If My.Computer.FileSystem.FileExists(path) Then
                sr = My.Computer.FileSystem.OpenTextFileReader(path)
                Dim linenum As Integer = IO.File.ReadAllLines(path).Length
                Dim i As Integer = 1
                While i <= linenum
                    Dim command As String = sr.ReadLine()
                    Interpret(command)
                    i = i + 1
                End While
                sr.Close()
            End If
        End Sub


        Public currentdironthisterminal As String = root

        Private Sub Terminal_Load(sender As Object, e As EventArgs) Handles Me.Load
            API.txtterm = Me.txtterm
            API.currentdir = currentdironthisterminal
            AddLine(username & "@" & osname & " " & currentdir.ToLower.Replace("c:\shiftos", "~") & "$> ")
            SelectBottom()
        End Sub
    End Class
End Namespace