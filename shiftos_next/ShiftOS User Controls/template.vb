Namespace ShiftDE
    <System.ComponentModel.Designer(GetType(Designer))> _
    Public Class template
        Inherits System.Windows.Forms.UserControl

        <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property Content() As Panel
            Get
                Return Me.pgcontents
            End Get
        End Property

#Region "Template Code"

        Friend WithEvents tmrcheckskin As New Timer

        Public Property AppName As String
            Get
                Return lbtitletext.Text
            End Get
            Set(value As String)
                lbtitletext.Text = value
            End Set
        End Property
        Public Shared isdesigning As Boolean = True
        Public ReadOnly Property designing As Boolean
            Get
                Return designing
            End Get
        End Property
        Public rolldownsize As Integer
        Public oldbordersize As Integer
        Public oldtitlebarheight As Integer
        Public justopened As Boolean = True
        Public needtorollback As Boolean = False
        Public minwidth As Integer
        Public minheight As Integer
        Public ReadOnly Property minimumappsize As Size
            Get
                Return New Size(minwidth, minheight)
            End Get
        End Property

        Friend WithEvents prnt As Form = ParentForm

        Private Sub Template_Load(sender As Object, e As EventArgs) Handles Me.Load
            tmrcheckskin.Interval = 200
            tmrcheckskin.Start()
            Me.Dock = DockStyle.Fill
        End Sub

        Public Sub tmrcheckskin_Tick(sender As Object, e As EventArgs) Handles tmrcheckskin.Tick
            setupall()
        End Sub

        Public Sub InitialSetup()
            If justopened = True Then
                setupall()
                minwidth = ParentForm.MinimumSize.Width
                minheight = ParentForm.MinimumSize.Height
            End If
        End Sub

        Public Sub setupall()
            setuptitlebar()
            setupborders()
            setskin()
        End Sub

        Private Sub ShiftOSDesktop_keydown(sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
            'Make terminal appear
            If e.KeyCode = Keys.T AndAlso e.Control Then
                Dim term As New ShiftDE.Terminal
                term.Show()
                term.Visible = True
                term.BringToFront()
            End If

        End Sub

        Private Sub titlebar_MouseDown(sender As Object, e As MouseEventArgs) Handles titlebar.MouseDown, lbtitletext.MouseDown, pnlicon.MouseDown, pgtoplcorner.MouseDown, pgtoprcorner.MouseDown
            ' Handle Draggable Windows
            If boughtdraggablewindows = True Then
                If e.Button = MouseButtons.Left Then
                    titlebar.Capture = False
                    lbtitletext.Capture = False
                    pnlicon.Capture = False
                    pgtoplcorner.Capture = False
                    pgtoprcorner.Capture = False
                    Const WM_NCLBUTTONDOWN As Integer = &HA1S
                    Const HTCAPTION As Integer = 2
                    Dim msg As Message = _
                        Message.Create(ParentForm.Handle, WM_NCLBUTTONDOWN, _
                            New IntPtr(HTCAPTION), IntPtr.Zero)
                    Me.DefWndProc(msg)
                End If
            End If
        End Sub

        Public Sub setupborders()
            If boughtwindowborders = False Then
                pgleft.Hide()
                pgbottom.Hide()
                pgright.Hide()
                ParentForm.Size = New Size(ParentForm.Width - pgleft.Width - pgright.Width, ParentForm.Height - pgbottom.Height)
            End If
        End Sub

        Private Sub closebutton_Click(sender As Object, e As EventArgs) Handles closebutton.Click
            ParentForm.Close()
        End Sub

        Private Sub closebutton_MouseEnter(sender As Object, e As EventArgs) Handles closebutton.MouseEnter, closebutton.MouseUp
            closebutton.BackgroundImage = Skins.closebtnhover
        End Sub

        Private Sub closebutton_MouseLeave(sender As Object, e As EventArgs) Handles closebutton.MouseLeave
            closebutton.BackgroundImage = Skins.closebtn
        End Sub

        Private Sub closebutton_MouseDown(sender As Object, e As EventArgs) Handles closebutton.MouseDown
            closebutton.BackgroundImage = Skins.closebtnclick
        End Sub

        Private Sub minimizebutton_Click(sender As Object, e As EventArgs) Handles minimizebutton.Click
            ParentForm.WindowState = FormWindowState.Minimized
        End Sub

        Private Sub rollupbutton_Click(sender As Object, e As EventArgs) Handles rollupbutton.Click
            rollupanddown()
        End Sub

        Private Sub rollupbutton_MouseEnter(sender As Object, e As EventArgs) Handles rollupbutton.MouseEnter, rollupbutton.MouseUp
            rollupbutton.BackgroundImage = Skins.rollbtnhover
        End Sub

        Private Sub rollupbutton_MouseLeave(sender As Object, e As EventArgs) Handles rollupbutton.MouseLeave
            rollupbutton.BackgroundImage = Skins.rollbtn
        End Sub

        Private Sub rollupbutton_MouseDown(sender As Object, e As EventArgs) Handles rollupbutton.MouseDown
            rollupbutton.BackgroundImage = Skins.rollbtnclick
        End Sub

        Public Sub setuptitlebar()

            setupborders()

            If Me.Height = Me.titlebar.Height Then pgleft.Show() : pgbottom.Show() : pgright.Show() : Me.Height = rolldownsize : needtorollback = True
            pgleft.Width = Skins.borderwidth
            pgright.Width = Skins.borderwidth
            pgbottom.Height = Skins.borderwidth
            titlebar.Height = Skins.titlebarheight

            If justopened = True Then
                ParentForm.Size = minimumappsize
                ParentForm.Size = New Size(ParentForm.Width, ParentForm.Height + Skins.titlebarheight - 30)
                ParentForm.Size = New Size(ParentForm.Width + Skins.borderwidth + Skins.borderwidth, ParentForm.Height + Skins.borderwidth)
                oldbordersize = Skins.borderwidth
                oldtitlebarheight = Skins.titlebarheight
                justopened = False
            Else
                If ParentForm.Visible = True Then
                    ParentForm.Size = New Size(ParentForm.Width - (2 * oldbordersize) + (2 * Skins.borderwidth), (ParentForm.Height - oldtitlebarheight - oldbordersize) + Skins.titlebarheight + Skins.borderwidth)
                    oldbordersize = Skins.borderwidth
                    oldtitlebarheight = Skins.titlebarheight
                    rolldownsize = ParentForm.Height
                    If needtorollback = True Then ParentForm.Height = titlebar.Height : pgleft.Hide() : pgbottom.Hide() : pgright.Hide()
                End If
            End If

            If Skins.enablecorners = True Then
                pgtoplcorner.Show()
                pgtoprcorner.Show()
                pgtoprcorner.Width = Skins.titlebarcornerwidth
                pgtoplcorner.Width = Skins.titlebarcornerwidth
            Else
                pgtoplcorner.Hide()
                pgtoprcorner.Hide()
            End If

            If boughttitlebar = False Then
                titlebar.Hide()
                ParentForm.Size = New Size(ParentForm.Width, ParentForm.Height - titlebar.Height)
            Else
                If boughtmovablewindows = False Then
                    ParentForm.Location = New Point((Screen.PrimaryScreen.Bounds.Width - ParentForm.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - ParentForm.Height) / 2)
                End If
            End If

            If boughttitletext = False Then
                lbtitletext.Hide()
            Else
                lbtitletext.Font = New Font(Skins.titletextfontfamily, Skins.titletextfontsize, Skins.titletextfontstyle, GraphicsUnit.Point)
                lbtitletext.Text = AppName
                lbtitletext.Show()
            End If

            If boughtclosebutton = False Then
                closebutton.Hide()
            Else
                closebutton.BackColor = Skins.closebtncolour
                closebutton.Size = Skins.closebtnsize
                closebutton.Show()
            End If

            If boughtrollupbutton = False Then
                rollupbutton.Hide()
            Else
                rollupbutton.BackColor = Skins.rollbtncolour
                rollupbutton.Size = Skins.rollbtnsize
                rollupbutton.Show()
            End If

            If boughtminimizebutton = False Then
                minimizebutton.Hide()
            Else
                minimizebutton.BackColor = Skins.minbtncolour
                minimizebutton.Size = Skins.minbtnsize
                minimizebutton.Show()
            End If

            If boughtwindowborders = True Then
                closebutton.Location = New Point(titlebar.Size.Width - Skins.closebtnfromside - closebutton.Size.Width, Skins.closebtnfromtop)
                rollupbutton.Location = New Point(titlebar.Size.Width - Skins.rollbtnfromside - rollupbutton.Size.Width, Skins.rollbtnfromtop)
                minimizebutton.Location = New Point(titlebar.Size.Width - Skins.minbtnfromside - minimizebutton.Size.Width, Skins.minbtnfromtop)
                Select Case Skins.titletextpos
                    Case "Left"
                        lbtitletext.Location = New Point(Skins.titletextfromside, Skins.titletextfromtop)
                    Case "Centre"
                        lbtitletext.Location = New Point((titlebar.Width / 2) - lbtitletext.Width / 2, Skins.titletextfromtop)
                End Select
                lbtitletext.ForeColor = Skins.titletextcolour
            Else
                closebutton.Location = New Point(titlebar.Size.Width - Skins.closebtnfromside - pgtoplcorner.Width - pgtoprcorner.Width - closebutton.Size.Width, Skins.closebtnfromtop)
                rollupbutton.Location = New Point(titlebar.Size.Width - Skins.rollbtnfromside - pgtoplcorner.Width - pgtoprcorner.Width - rollupbutton.Size.Width, Skins.rollbtnfromtop)
                minimizebutton.Location = New Point(titlebar.Size.Width - Skins.minbtnfromside - pgtoplcorner.Width - pgtoprcorner.Width - minimizebutton.Size.Width, Skins.minbtnfromtop)
                Select Case Skins.titletextpos
                    Case "Left"
                        lbtitletext.Location = New Point(Skins.titletextfromside + pgtoplcorner.Width, Skins.titletextfromtop)
                    Case "Centre"
                        lbtitletext.Location = New Point((titlebar.Width / 2) - lbtitletext.Width / 2, Skins.titletextfromtop)
                End Select
                lbtitletext.ForeColor = Skins.titletextcolour
            End If

        End Sub

        Public Sub rollupanddown()
            If ParentForm.Height = Me.titlebar.Height Then
                pgleft.Show()
                pgbottom.Show()
                pgright.Show()
                ParentForm.Height = rolldownsize
                ParentForm.MinimumSize = minimumappsize
            Else
                ParentForm.MinimumSize = New Size(0, 0)
                pgleft.Hide()
                pgbottom.Hide()
                pgright.Hide()
                rolldownsize = Me.Height
                ParentForm.Height = Me.titlebar.Height
            End If
        End Sub

        Public Sub resettitlebar()
            If boughtwindowborders = True Then
                closebutton.Location = New Point(titlebar.Size.Width - Skins.closebtnfromside - closebutton.Size.Width, Skins.closebtnfromtop)
                rollupbutton.Location = New Point(titlebar.Size.Width - Skins.rollbtnfromside - rollupbutton.Size.Width, Skins.rollbtnfromtop)
                minimizebutton.Location = New Point(titlebar.Size.Width - Skins.minbtnfromside - minimizebutton.Size.Width, Skins.minbtnfromtop)
                Select Case Skins.titletextpos
                    Case "Left"
                        lbtitletext.Location = New Point(Skins.titletextfromside, Skins.titletextfromtop)
                    Case "Centre"
                        lbtitletext.Location = New Point((titlebar.Width / 2) - lbtitletext.Width / 2, Skins.titletextfromtop)
                End Select
                lbtitletext.ForeColor = Skins.titletextcolour
            Else
                closebutton.Location = New Point(titlebar.Size.Width - Skins.closebtnfromside - pgtoplcorner.Width - pgtoprcorner.Width - closebutton.Size.Width, Skins.closebtnfromtop)
                rollupbutton.Location = New Point(titlebar.Size.Width - Skins.rollbtnfromside - pgtoplcorner.Width - pgtoprcorner.Width - rollupbutton.Size.Width, Skins.rollbtnfromtop)
                minimizebutton.Location = New Point(titlebar.Size.Width - Skins.minbtnfromside - pgtoplcorner.Width - pgtoprcorner.Width - minimizebutton.Size.Width, Skins.minbtnfromtop)
                Select Case Skins.titletextpos
                    Case "Left"
                        lbtitletext.Location = New Point(Skins.titletextfromside + pgtoplcorner.Width, Skins.titletextfromtop)
                    Case "Centre"
                        lbtitletext.Location = New Point((titlebar.Width / 2) - lbtitletext.Width / 2, Skins.titletextfromtop)
                End Select
                lbtitletext.ForeColor = Skins.titletextcolour
            End If
        End Sub

        Private Sub pullside_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pullside.Tick
            ParentForm.Width = Cursor.Position.X - ParentForm.Location.X
            resettitlebar()
        End Sub

        Private Sub pullbottom_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pullbottom.Tick
            ParentForm.Height = Cursor.Position.Y - ParentForm.Location.Y
            resettitlebar()
        End Sub

        Private Sub pullbs_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles pullbs.Tick
            ParentForm.Width = Cursor.Position.X - ParentForm.Location.X
            ParentForm.Height = Cursor.Position.Y - ParentForm.Location.Y
            resettitlebar()
        End Sub

        'delete this for non-resizable windows
        Private Sub Rightpull_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pgright.MouseDown
            If boughtresizablewindows = True Then
                pullside.Start()
            End If
        End Sub

        Private Sub RightCursorOn_MouseDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles pgright.MouseEnter
            If boughtresizablewindows = True Then
                Cursor = Cursors.SizeWE
            End If
        End Sub

        Private Sub bottomCursorOn_MouseDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles pgbottom.MouseEnter
            If boughtresizablewindows = True Then
                Cursor = Cursors.SizeNS
            End If
        End Sub

        Private Sub CornerCursorOn_MouseDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles pgbottomrcorner.MouseEnter
            If boughtresizablewindows = True Then
                Cursor = Cursors.SizeNWSE
            End If
        End Sub

        Private Sub SizeCursoroff_MouseDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles pgright.MouseLeave, pgbottom.MouseLeave, pgbottomrcorner.MouseLeave
            If boughtresizablewindows = True Then
                Cursor = Cursors.Default
            End If
        End Sub

        Private Sub rightpull_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pgright.MouseUp
            If boughtresizablewindows = True Then
                pullside.Stop()
            End If
        End Sub

        Private Sub bottompull_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pgbottom.MouseDown
            If boughtresizablewindows = True Then
                pullbottom.Start()
            End If
        End Sub

        Private Sub buttompull_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pgbottom.MouseUp
            If boughtresizablewindows = True Then
                pullbottom.Stop()
            End If
        End Sub

        Private Sub bspull_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pgbottomrcorner.MouseDown
            If boughtresizablewindows = True Then
                pullbs.Start()
            End If
        End Sub

        Private Sub bspull_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pgbottomrcorner.MouseUp
            If boughtresizablewindows = True Then
                pullbs.Stop()
            End If
        End Sub

        Public Sub setskin()
            'disposals
            closebutton.BackgroundImage = Nothing
            titlebar.BackgroundImage = Nothing
            rollupbutton.BackgroundImage = Nothing
            pgtoplcorner.BackgroundImage = Nothing
            pgtoprcorner.BackgroundImage = Nothing
            minimizebutton.BackgroundImage = Nothing
            'apply new skin
            If Skins.closebtn Is Nothing Then closebutton.BackColor = Skins.closebtncolour Else closebutton.BackgroundImage = Skins.closebtn
            closebutton.BackgroundImageLayout = Skins.closebtnlayout
            If Skins.titlebar Is Nothing Then titlebar.BackColor = Skins.titlebarcolour Else titlebar.BackgroundImage = Skins.titlebar
            titlebar.BackgroundImageLayout = Skins.titlebarlayout
            If Skins.rollbtn Is Nothing Then rollupbutton.BackColor = Skins.rollbtncolour Else rollupbutton.BackgroundImage = Skins.rollbtn
            rollupbutton.BackgroundImageLayout = Skins.rollbtnlayout
            If Skins.leftcorner Is Nothing Then pgtoplcorner.BackColor = Skins.leftcornercolour Else pgtoplcorner.BackgroundImage = Skins.leftcorner
            pgtoplcorner.BackgroundImageLayout = Skins.leftcornerlayout
            If Skins.rightcorner Is Nothing Then pgtoprcorner.BackColor = Skins.rightcornercolour Else pgtoprcorner.BackgroundImage = Skins.rightcorner
            pgtoprcorner.BackgroundImageLayout = Skins.rightcornerlayout
            If Skins.minbtn Is Nothing Then minimizebutton.BackColor = Skins.minbtncolour Else minimizebutton.BackgroundImage = Skins.minbtn
            minimizebutton.BackgroundImageLayout = Skins.minbtnlayout
            If Skins.borderleft Is Nothing Then pgleft.BackColor = Skins.borderleftcolour Else pgleft.BackgroundImage = Skins.borderleft
            pgleft.BackgroundImageLayout = Skins.borderleftlayout
            If Skins.borderright Is Nothing Then pgright.BackColor = Skins.borderrightcolour Else pgright.BackgroundImage = Skins.borderright
            pgleft.BackgroundImageLayout = Skins.borderrightlayout
            If Skins.borderbottom Is Nothing Then pgbottom.BackColor = Skins.borderbottomcolour Else pgbottom.BackgroundImage = Skins.borderbottom
            pgbottom.BackgroundImageLayout = Skins.borderbottomlayout
            If enablebordercorners = True Then
                If Skins.bottomleftcorner Is Nothing Then pgbottomlcorner.BackColor = Skins.bottomleftcornercolour Else pgbottomlcorner.BackgroundImage = Skins.bottomleftcorner
                pgbottomlcorner.BackgroundImageLayout = Skins.bottomleftcornerlayout
                If Skins.bottomrightcorner Is Nothing Then pgbottomrcorner.BackColor = Skins.bottomrightcornercolour Else pgbottomrcorner.BackgroundImage = Skins.bottomrightcorner
                pgbottomrcorner.BackgroundImageLayout = Skins.bottomrightcornerlayout
            Else
                pgbottomlcorner.BackColor = Skins.borderrightcolour
                pgbottomrcorner.BackColor = Skins.borderrightcolour
                pgbottomlcorner.BackgroundImage = Nothing
                pgbottomrcorner.BackgroundImage = Nothing
            End If

            'set bottom border corner size
            pgbottomlcorner.Size = New Size(Skins.borderwidth, Skins.borderwidth)
            pgbottomrcorner.Size = New Size(Skins.borderwidth, Skins.borderwidth)
            pgbottomlcorner.Location = New Point(0, Me.Height - Skins.borderwidth)
            pgbottomrcorner.Location = New Point(Me.Width, Me.Height - Skins.borderwidth)

            ParentForm.TransparencyKey = ShiftOSDesktop.globaltransparencykey
        End Sub

        'end of general setup
#End Region
    End Class

    Public Class Designer
        Inherits System.Windows.Forms.Design.ControlDesigner

        Public Overrides Sub Initialize(ByVal component As System.ComponentModel.IComponent)
            MyBase.Initialize(component)

            EnableDesignMode(DirectCast(component, template).Content, "Content")

        End Sub

    End Class
End Namespace
