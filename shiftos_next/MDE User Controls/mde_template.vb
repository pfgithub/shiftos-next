<System.ComponentModel.Designer(GetType(Designer))> _
Public Class mde_template
    Inherits System.Windows.Forms.UserControl

    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)> _
    Public ReadOnly Property Content() As Panel
        Get
            Return Me.Contents
        End Get
    End Property

    Public Property AppName As String
        Get
            Return titletext.Text
        End Get
        Set(value As String)
            titletext.Text = value
        End Set
    End Property

#Region "Template Code"
    'Programmatically Defined
    Public mySizeW As Integer
    Public mySizeH As Integer
    Public isMaximized As Boolean
    Public mylocation As Point



    Private Sub captionbuttonholder_Paint(sender As Object, e As PaintEventArgs) Handles captionbuttonholder.Paint

    End Sub

    Private Sub closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        ParentForm.Close()
        memphis.setuppanelbuttons()
    End Sub

    Private Sub maxbtn_Click(sender As Object, e As EventArgs) Handles maxbtn.Click
        setMaximized()
    End Sub

    Public Sub setMaximized()
        If isMaximized = True Then
            ParentForm.Size = New Size(mySizeW, mySizeH)
            ParentForm.Location = mylocation
            isMaximized = False
        Else
            Dim desktopappbarheight As Integer = memphis.ToolStrip1.Height + memphis.ToolStrip2.Height
            Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
            Dim screenheight As Integer = Screen.PrimaryScreen.Bounds.Height - desktopappbarheight
            ParentForm.Size = New Size(screenWidth, screenheight)
            ParentForm.Location = New Point(0, memphis.ToolStrip1.Height)
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
                    Message.Create(ParentForm.Handle, WM_NCLBUTTONDOWN, _
                        New IntPtr(HTCAPTION), IntPtr.Zero)
                Me.DefWndProc(msg)
            End If
        End If
    End Sub

    Private Sub minbtn_Click(sender As Object, e As EventArgs) Handles minbtn.Click
        ParentForm.WindowState = FormWindowState.Minimized
    End Sub

    Public Sub Me_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mySizeW = ParentForm.Width
        mySizeH = ParentForm.Height
        mylocation = ParentForm.Location
        SetupTitle()
        ParentForm.TopMost = True
        memphis.setuppanelbuttons()
    End Sub

    Public Sub SetupTitle()
        titletext.Text = AppName
    End Sub

#End Region

End Class

Public Class Designer
    Inherits System.Windows.Forms.Design.ControlDesigner

    Public Overrides Sub Initialize(ByVal component As System.ComponentModel.IComponent)
        MyBase.Initialize(component)

        EnableDesignMode(DirectCast(component, mde_template).Content, "Content")

    End Sub

End Class