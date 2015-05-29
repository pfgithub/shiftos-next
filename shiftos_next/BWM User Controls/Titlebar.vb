Public Class Titlebar

    Public Property AppName As String
        Set(value As String)
            lbtitle.Text = value
        End Set
        Get
            Return lbtitle.Text
        End Get
    End Property

    Friend WithEvents prnt As Form = ParentForm

    Private Sub Titlebar_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Dock = DockStyle.Top
        Me.BringToFront()
    End Sub

    Private Sub titlebar_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, lbtitle.MouseDown
        ' Handle Draggable Windows
        If boughtdraggablewindows = True Then
            If e.Button = MouseButtons.Left Then
                Me.Capture = False
                lbtitle.Capture = False
                Const WM_NCLBUTTONDOWN As Integer = &HA1S
                Const HTCAPTION As Integer = 2
                Dim msg As Message = _
                    Message.Create(ParentForm.Handle, WM_NCLBUTTONDOWN, _
                        New IntPtr(HTCAPTION), IntPtr.Zero)
                Me.DefWndProc(msg)
            End If
        End If
    End Sub

    Public Sub DetermineMyVisibility()
        If boughtbasicwm = True Then
            Me.Show()
            ParentForm.WindowState = FormWindowState.Normal
            ParentForm.Left = (Screen.PrimaryScreen.Bounds.Width - ParentForm.Width) / 2
            ParentForm.Top = (Screen.PrimaryScreen.Bounds.Height - ParentForm.Height) / 2
            ParentForm.TopMost = True
        Else
            Me.Hide()
            ParentForm.WindowState = FormWindowState.Maximized
            ParentForm.TopMost = False
        End If
    End Sub

End Class
