Public Class memphis



    Public Sub Me_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStrip1.Renderer = New mde_renderer()
        ToolStrip2.Renderer = New mde_renderer()
        setfonts(ToolStrip1)
        setfonts(ToolStrip2)
        Me.TopMost = True
    End Sub

    Public Sub setuppanelbuttons()
        'Not Yet Implemented.
    End Sub

    Public Sub setfonts(ByRef toolStrip As ToolStrip)
        For Each item In toolStrip.Items
            item.ForeColor = Color.White
            For Each subitem In item.DropDownItems
                subitem.ForeColor = Color.White
            Next
        Next
    End Sub

    Private Sub TerminalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TerminalToolStripMenuItem.Click
        Dim term As New MDE_Terminal
        term.TopMost = True
        term.Show()
    End Sub

    Private Sub ShutdownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShutdownToolStripMenuItem.Click
        savegame()
        Me.Close()
    End Sub


    Private Sub SendBugReportToolStripMenuItem_Click(sender As Object, e As EventArgs)
        infobox_mde.showinfo("Not Yet Implemented!", "This feature has not yet been implemented, Sorry!")
    End Sub

    Private Sub FileBrowserExodusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileBrowserExodusToolStripMenuItem.Click
        ExodusFB_mde.Show()
    End Sub
End Class

Public Class mde_renderer
    Inherits ToolStripProfessionalRenderer

    Public Sub New()
        MyBase.New(New MyNamespace.mde_colortable)
    End Sub
End Class

