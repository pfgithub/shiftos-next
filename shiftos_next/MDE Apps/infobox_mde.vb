Public Class infobox_mde
    'Editable Variables
    Public apptitle As String = "Application Template" 'The name of your app

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
    End Sub

    Public Sub SetupTitle()
        titletext.Text = apptitle
    End Sub

#End Region

    Public Sub showinfo(title As String, msg As String, Optional showtextbox As Boolean = False)
        apptitle = title
        SetupTitle()
        lbmsgtext.Text = msg
        txtuserinput.Visible = showtextbox
        Me.Show()
    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click

    End Sub
End Class