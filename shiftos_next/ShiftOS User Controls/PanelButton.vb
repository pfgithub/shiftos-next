Public Class PanelButton
#Region "Properties"
    Public Property appname As String
        Get
            Return lbappname.Text
        End Get
        Set(value As String)
            lbappname.Text = value
        End Set
    End Property

    Dim frm As Form

    Public Property formToControl As Form
        Get
            Return frm
        End Get
        Set(value As Form)
            frm = value
        End Set
    End Property

    Public Property Icon As System.Drawing.Bitmap
        Get
            Return pbicon.Image
        End Get
        Set(value As System.Drawing.Bitmap)
            pbicon.Image = value
        End Set
    End Property

#End Region

#Region "Events"
    Private Sub PanelButton_Click(sender As Object, e As EventArgs) Handles Me.Click
        If boughtusefulpanelbuttons = True Then
            If frm.WindowState = FormWindowState.Minimized Then
                frm.WindowState = FormWindowState.Normal
            Else
                frm.WindowState = FormWindowState.Minimized
            End If
        End If
    End Sub

    Private Sub close_Click(sender As Object, e As EventArgs) Handles close.Click
        frm.Close()
    End Sub

    Private Sub minimize_Click(sender As Object, e As EventArgs) Handles minimize.Click
        frm.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub restore_Click(sender As Object, e As EventArgs) Handles restore.Click
        frm.WindowState = FormWindowState.Normal
    End Sub


    Private Sub PanelButton_Load(sender As Object, e As EventArgs) Handles Me.Load
        ShiftOSDesktop.setpanelbuttonappearance()
    End Sub
#End Region



End Class
