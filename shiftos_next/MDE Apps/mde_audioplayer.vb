Public Class mde_audioplayer
    'Editable Variables
    Public apptitle As String = "No Track Playing - Memphis Audio" 'The name of your app

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

    Public Sub Me_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mySizeW = Me.Width
        mySizeH = Me.Height
        mylocation = Me.Location
        SetupTitle()
        Me.TopMost = True
        memphis.setuppanelbuttons()
        SetupMediaPlayer()
    End Sub

    Public Sub SetupTitle()
        titletext.Text = apptitle
    End Sub

#End Region

    Public Sub SetupMediaPlayer()
        AxWindowsMediaPlayer1.uiMode = "none"
        AxWindowsMediaPlayer1.enableContextMenu = False
        TrackBar1.Value = AxWindowsMediaPlayer1.settings.volume / 10
    End Sub
    Public Sub loadSongFile(file As String)
        AxWindowsMediaPlayer1.URL = file
        apptitle = AxWindowsMediaPlayer1.currentMedia.name & " - Memphis Audio"
        SetupTitle()
        Me.Show()
    End Sub

    Public Sub playPause()
        If AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            AxWindowsMediaPlayer1.Ctlcontrols.pause()
        Else
            AxWindowsMediaPlayer1.Ctlcontrols.play()
        End If
        apptitle = AxWindowsMediaPlayer1.currentMedia.name & " - Memphis Audio"
        SetupTitle()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        playPause()
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        AxWindowsMediaPlayer1.settings.volume = TrackBar1.Value * 10
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
        apptitle = "No Track Playing - Memphis Audio"
        SetupTitle()
    End Sub
End Class